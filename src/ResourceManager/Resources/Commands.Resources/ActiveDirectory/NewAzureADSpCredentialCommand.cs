﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.ActiveDirectory.Models;
using Microsoft.Azure.Commands.Resources.Models.ActiveDirectory;
using Microsoft.Azure.Graph.RBAC.Models;
using System;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.ActiveDirectory
{
    /// <summary>
    /// Creates a new AD servicePrincipal Credential.
    /// </summary>
    [Cmdlet(VerbsCommon.New, "AzureRmADSpCredential", DefaultParameterSetName = ParameterSet.SpObjectIdWithPassword, SupportsShouldProcess = true), OutputType(typeof(PSADCredential))]
    public class NewAzureADSpCredentialCommand : ActiveDirectoryBaseCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = ParameterSet.SpObjectIdWithCertValue, HelpMessage = "The servicePrincipal object id.")]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = ParameterSet.SpObjectIdWithPassword, HelpMessage = "The servicePrincipal object id.")]
        [ValidateNotNullOrEmpty]
        [Alias("ServicePrincipalObjectId")]
        public string ObjectId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = ParameterSet.SPNWithCertValue, HelpMessage = "The servicePrincipal name.")]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = ParameterSet.SPNWithPassword, HelpMessage = "The servicePrincipal name.")]
        [ValidateNotNullOrEmpty]
        [Alias("SPN")]
        public string ServicePrincipalName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = ParameterSet.SpObjectIdWithPassword,
            HelpMessage = "The value for the password credential associated with the servicePrincipal that will be valid for one year by default.")]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = ParameterSet.SPNWithPassword,
            HelpMessage = "The value for the password credential associated with the servicePrincipal that will be valid for one year by default.")]
        [ValidateNotNullOrEmpty]
        public string Password { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = ParameterSet.SpObjectIdWithCertValue,
            HelpMessage = "The base64 encoded value for the AsymmetricX509Cert associated with the servicePrincipal that will be valid for one year by default.")]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = ParameterSet.SPNWithCertValue,
            HelpMessage = "The base64 encoded value for the AsymmetricX509Cert associated with the servicePrincipal that will be valid for one year by default.")]
        [ValidateNotNullOrEmpty]
        public string CertValue { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The start date after which password or key would be valid. Default value is current time.")]
        public DateTime StartDate { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The end date till which password or key is valid. Default value is one year after current time.")]
        public DateTime EndDate { get; set; }

        public NewAzureADSpCredentialCommand()
        {
            DateTime currentTime = DateTime.UtcNow;
            StartDate = currentTime;
            EndDate = currentTime.AddYears(1);
        }

        public override void ExecuteCmdlet()
        {
            ExecutionBlock(() =>
            {
                if (!string.IsNullOrEmpty(ServicePrincipalName))
                {
                    ObjectId = ActiveDirectoryClient.GetObjectIdFromSPN(ServicePrincipalName);
                }

                if (!string.IsNullOrEmpty(Password))
                {
                    // Create object for password credential
                    var passwordCredential = new PasswordCredential()
                    {
                        EndDate = EndDate,
                        StartDate = StartDate,
                        KeyId = Guid.NewGuid().ToString(),
                        Value = Password
                    };
                    if (ShouldProcess(target: ObjectId, action: string.Format("Adding a new password to service principal with objectId {0}", ObjectId)))
                    {
                        WriteObject(ActiveDirectoryClient.CreateSpPasswordCredential(ObjectId, passwordCredential));
                    }
                }
                else if (!string.IsNullOrEmpty(CertValue))
                {
                    // Create object for key credential
                    var keyCredential = new KeyCredential()
                    {
                        EndDate = EndDate,
                        StartDate = StartDate,
                        KeyId = Guid.NewGuid().ToString(),
                        Value = CertValue,
                        Type = "AsymmetricX509Cert",
                        Usage = "Verify"
                    };

                    if (ShouldProcess(target: ObjectId, action: string.Format("Adding a new caertificate to service principal with objectId {0}", ObjectId)))
                    {
                        WriteObject(ActiveDirectoryClient.CreateSpKeyCredential(ObjectId, keyCredential));
                    }
                }
                else
                {
                    throw new InvalidOperationException("No valid keyCredential or passwordCredential to update!!");
                }
            });
        }
    }
}
