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

using Microsoft.Azure.Commands.Relay.Models;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Relay.Commands.HybridConnections
{
    /// <summary>
    /// 'Set-AzureRmRelayHybridConnection' Cmdlet updates the specified WcfRelay
    /// </summary>
    [Cmdlet(VerbsCommon.Set, RelayHybridConnectionVerb, SupportsShouldProcess = true), OutputType(typeof(HybridConnectionAttibutes))]
    public class SetAzureRelayHybridConnections : AzureRelayCmdletBase
    {
        [Parameter(Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            Position = 0,
            HelpMessage = "Resource Group Name.")]
        [ValidateNotNullOrEmpty]
         public string ResourceGroupName { get; set; }

        [Parameter(Mandatory = true,
           ValueFromPipelineByPropertyName = true,
           Position = 1,
           HelpMessage = "Namespace Name.")]
        [ValidateNotNullOrEmpty]
        public string NamespaceName { get; set; }

        [Parameter(Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            Position = 2,
            HelpMessage = "HybridConnections Name.")]
        [ValidateNotNullOrEmpty]
        public string HybridConnectionsName { get; set; }

        [Parameter(Mandatory = false,
           ValueFromPipelineByPropertyName = true,
           HelpMessage = "HybridConnections object.")]
        [ValidateNotNullOrEmpty]
        public HybridConnectionAttibutes HybridConnectionsObj { get; set; }
        
        [Parameter(Mandatory = false,
           ValueFromPipelineByPropertyName = true,
           HelpMessage = "true if client authorization is needed for this relay; otherwise, false")]
        [ValidateNotNullOrEmpty]
        public bool? RequiresClientAuthorization { get; set; }

        [Parameter(Mandatory = false,
           ValueFromPipelineByPropertyName = true,
           HelpMessage = "Gets or sets usermetadata is a placeholder to store user-defined string data for the HybridConnection endpoint.e.g. it can be used to store  descriptive data, such as list of teams and their contact information also user-defined configuration settings can be stored.")]
        [ValidateNotNullOrEmpty]
        public string UserMetadata { get; set; }
        
        public override void ExecuteCmdlet()
        {
            HybridConnectionAttibutes hybridConnections = new HybridConnectionAttibutes();
            
            if (HybridConnectionsObj != null)
            {
                hybridConnections = HybridConnectionsObj;
            }
            else
            {                
                if (RequiresClientAuthorization.HasValue)
                    hybridConnections.RequiresClientAuthorization = RequiresClientAuthorization;
                
                if (!string.IsNullOrEmpty(UserMetadata))
                    hybridConnections.UserMetadata = UserMetadata;
            }
            
            if(ShouldProcess(target: HybridConnectionsName, action: string.Format("Updating HybridConnections:{0} of NameSpace:{1}", HybridConnectionsName,NamespaceName)))
            {
                WriteObject(Client.CreateOrUpdateHybridConnections(ResourceGroupName, NamespaceName, HybridConnectionsName, HybridConnectionsObj));
            }
        }
    }
}
