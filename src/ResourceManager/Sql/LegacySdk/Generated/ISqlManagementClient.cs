// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Sql.LegacySdk;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Management.Sql.LegacySdk
{
    /// <summary>
    /// The Windows Azure SQL Database management API provides a RESTful set of
    /// web services that interact with Windows Azure SQL Database services to
    /// manage your databases. The API enables users to create, retrieve,
    /// update, and delete databases and servers.
    /// </summary>
    public partial interface ISqlManagementClient : IDisposable
    {
        /// <summary>
        /// Gets the API version.
        /// </summary>
        string ApiVersion
        {
            get; 
        }
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        Uri BaseUri
        {
            get; 
        }
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        SubscriptionCloudCredentials Credentials
        {
            get; 
        }
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationInitialTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationRetryTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Represents all the operations to manage Azure SQL Database and
        /// Database Server Audit policy.  Contains operations to: Create,
        /// Retrieve and Update audit policy.
        /// </summary>
        IAuditingPolicyOperations AuditingPolicy
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations to manage Azure SQL Database and
        /// Server blob auditing. Contains operations to: Create, Retrieve and
        /// Update blob auditing settings.
        /// </summary>
        IBlobAuditingOperations BlobAuditing
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for determining the set of
        /// capabilites available in a specified region.
        /// </summary>
        ICapabilitiesOperations Capabilities
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating pertaining to
        /// activation on Azure SQL Data Warehouse databases. Contains
        /// operations to: Pause and Resume databases
        /// </summary>
        IDatabaseActivationOperations DatabaseActivation
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for managing Advisors for Azure SQL
        /// Databases. Contains operations to retrieve Advisors and update
        /// auto execute status of an Advisor.
        /// </summary>
        IDatabaseAdvisorOperations DatabaseAdvisors
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// database backups.
        /// </summary>
        IDatabaseBackupOperations DatabaseBackup
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Databases.
        /// Contains operations to: Create, Retrieve, Update, and Delete
        /// databases, and also includes the ability to get the event logs for
        /// a database.
        /// </summary>
        IDatabaseOperations Databases
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for managing recommended actions on
        /// Azure SQL Databases. Contains operations to retrieve recommended
        /// action and update its state.
        /// </summary>
        IDatabaseRecommendedActionOperations DatabaseRecommendedActions
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// data masking. Contains operations to: Create, Retrieve, Update,
        /// and Delete data masking rules, as well as Create, Retreive and
        /// Update data masking policy.
        /// </summary>
        IDataMaskingOperations DataMasking
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for managing Advisors for Azure SQL
        /// Elastic Database Pool. Contains operations to retrieve Advisors
        /// and update auto execute status of an Advisor.
        /// </summary>
        IElasticPoolAdvisorOperations ElasticPoolAdvisors
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// Elastic Pools.  Contains operations to: Create, Retrieve, Update,
        /// and Delete.
        /// </summary>
        IElasticPoolOperations ElasticPools
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for managing recommended actions on
        /// Azure SQL Elastic Database Pools. Contains operations to retrieve
        /// recommended action and update its state.
        /// </summary>
        IElasticPoolRecommendedActionOperations ElasticPoolRecommendedActions
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// Failover Group.  Contains operations to: Create, Retrieve, Update,
        /// and Delete.
        /// </summary>
        IFailoverGroupOperations FailoverGroups
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// Server Firewall Rules.  Contains operations to: Create, Retrieve,
        /// Update, and Delete firewall rules.
        /// </summary>
        IFirewallRuleOperations FirewallRules
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for import/export on Azure SQL
        /// Databases.  Contains operations to: Import, Export, Get
        /// Import/Export status for a database.
        /// </summary>
        IImportExportOperations ImportExport
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Job
        /// Accounts. Contains operations to: Create, Retrieve, Update, and
        /// Delete Job Accounts
        /// </summary>
        IJobAccountOperations JobAccounts
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL
        /// Recommended Elastic Pools.  Contains operations to: Retrieve.
        /// </summary>
        IRecommendedElasticPoolOperations RecommendedElasticPools
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for managing recommended indexes on
        /// Azure SQL Databases. Contains operations to retrieve recommended
        /// index and update state.
        /// </summary>
        IRecommendedIndexOperations RecommendedIndexes
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// Replication Links.  Contains operations to: Delete and Retrieve
        /// replication links.
        /// </summary>
        IReplicationLinkOperations DatabaseReplicationLinks
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for managing Azure SQL Database
        /// secure connection.  Contains operations to: Create, Retrieve and
        /// Update secure connection policy .
        /// </summary>
        ISecureConnectionPolicyOperations SecureConnection
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations to manage Azure SQL Database and
        /// Database Server Security Alert policy.  Contains operations to:
        /// Create, Retrieve and Update policy.
        /// </summary>
        ISecurityAlertPolicyOperations SecurityAlertPolicy
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Server
        /// Active Directory Administrators.  Contains operations to: Create,
        /// Retrieve, Update, and Delete Azure SQL Server Active Directory
        /// Administrators.
        /// </summary>
        IServerAdministratorOperations ServerAdministrators
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for managing Advisors for Azure SQL
        /// Server. Contains operations to retrieve Advisors and update auto
        /// execute status of an Advisor.
        /// </summary>
        IServerAdvisorOperations ServerAdvisors
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Server
        /// communication links.  Contains operations to: Create, Retrieve,
        /// Update, and Delete.
        /// </summary>
        IServerCommunicationLinkOperations CommunicationLinks
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Server
        /// disaster recovery configurations. Contains operations to: Create,
        /// Retrieve, Update, Failover, and Delete.
        /// </summary>
        IServerDisasterRecoveryConfigurationOperations ServerDisasterRecoveryConfigurations
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations of Azure SQL Database that interact
        /// with Azure Key Vault Server Keys. Contains operations to: Add,
        /// Delete, and Retrieve Server Ke.
        /// </summary>
        IServerKeyOperations ServerKey
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// Servers.  Contains operations to: Create, Retrieve, Update, and
        /// Delete servers.
        /// </summary>
        IServerOperations Servers
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for managing recommended actions on
        /// Azure SQL Server. Contains operations to retrieve recommended
        /// action and update its state.
        /// </summary>
        IServerRecommendedActionOperations ServerRecommendedActions
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for Azure SQL Database Server Upgrade
        /// </summary>
        IServerUpgradeOperations ServerUpgrades
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// Service Objectives.   Contains operations to: Retrieve service
        /// objectives.
        /// </summary>
        IServiceObjectiveOperations ServiceObjectives
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on service tier
        /// advisors.  Contains operations to: Retrieve.
        /// </summary>
        IServiceTierAdvisorOperations ServiceTierAdvisors
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations of Azure SQL Database Transparent
        /// Data Encryption.  Contains operations to: Retrieve, and Update
        /// Transparent Data Encryption.
        /// </summary>
        ITransparentDataEncryptionOperations TransparentDataEncryption
        {
            get; 
        }
        
        /// <summary>
        /// Gets the status of an Azure Sql Database Failover Group Force
        /// Failover operation.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database Failover Group
        /// operation.
        /// </returns>
        Task<FailoverGroupForceFailoverResponse> GetFailoverGroupForceFailoverAllowDataLossOperationStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
    }
}
