---
external help file: Microsoft.Azure.Commands.EventHub.dll-Help.xml
online version: 
schema: 2.0.0
---

# Get-AzureRmEventHubNamespace

## SYNOPSIS
Gets a description for the specified EventHub namespace within the resource group.

## SYNTAX

```
Get-AzureRmEventHubNamespace [[-ResourceGroupName] <String>] [[-NamespaceName] <String>] [<CommonParameters>]
```

## DESCRIPTION
The **Get-AzureRmEventHubNamespace** cmdlet gets a description for the specified Event Hub namespace within the resource group.

## EXAMPLES

### Example 1
```
PS C:\> Get-AzureRmEventHubNamespace -ResourceGroupName RGName-PWR61219 -NamespaceName EH-Example
```

Returns a description of the specified Event Hub namespace.

## PARAMETERS

### -NamespaceName
EventHub Namespace Name.

```yaml
Type: String
Parameter Sets: (All)
Aliases: 

Required: False
Position: 1
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -ResourceGroupName
Resource Group Name.

```yaml
Type: String
Parameter Sets: (All)
Aliases: 

Required: False
Position: 0
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

###-ResourceGroup 
System.String

###-NamespaceName 
 System.String

## OUTPUTS

### System.Collections.Generic.List`1[[Microsoft.Azure.Commands.EventHub.Models.NamespaceAttributes, Microsoft.Azure.Commands.EventHub, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null]]

Name               : EH-Example
Id                 : /subscriptions/854d368f-1828-428f-8f3c-f2affa9b2f7d/resourceGroups/RGName-PWR61219/providers/Microsoft.EventHub/namespaces/EH-Example
Location           : West US
Sku                : Name : Standard , Capacity : 10 , Tier : Standard
ProvisioningState  : Succeeded
Status             : Active
CreatedAt          : 2/9/2017 5:34:44 AM
UpdatedAt          : 2/9/2017 5:35:06 AM
ServiceBusEndpoint : https://EH-Example.servicebus.windows.net:443/
Enabled            : True

## NOTES

## RELATED LINKS

