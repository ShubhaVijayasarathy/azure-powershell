---
external help file: Microsoft.Azure.Commands.EventHub.dll-Help.xml
online version: 
schema: 2.0.0
---

# Set-AzureRmEventHubNamespace

## SYNOPSIS
Updates the description of an existing Event Hub namespace.

## SYNTAX

```
Set-AzureRmEventHubNamespace [-ResourceGroupName] <String> [-NamespaceName] <String> [-Location] <String> [[-SkuName] <String> {Basic | Standard | Premium}] [[-SkuCapacity] <Int32>] [[-State]
<NamespaceState> {Unknown | Creating | Created | Activating | Enabling | Active | Disabling | Disabled | SoftDeleting | SoftDeleted | Removing | Removed | Failed}] [[-Tag] <Hashtable>]
[-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The **Set-AzureRmEventHubNamespace** cmdlet updates the description of the specified Event Hub namespace within the resource group.

## EXAMPLES

### Example 1
```
PS C:\> Set-AzureRmEventHubNamespace -ResourceGroupName RGName-PWR61219 -NamespaceName EH-Example -Location WestUS -SkuName "Standard" -SkuCapacity 11 -Tag @{Tag2="Tag2Value"}
```

Updates the Event Hub namespace with a new description

## PARAMETERS

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location
EventHub Namespace Location.

```yaml
Type: String
Parameter Sets: (All)
Aliases: 

Required: True
Position: 2
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -NamespaceName
EventHub Namespace Name.

```yaml
Type: String
Parameter Sets: (All)
Aliases: 

Required: True
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

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -SkuCapacity
The eventhub throughput units.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases: 

Required: False
Position: 4
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -SkuName
Namespace Sku Name.

```yaml
Type: String
Parameter Sets: (All)
Aliases: 
Accepted values: Basic, Standard, Premium

Required: False
Position: 3
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -State
Disable/Enable Namespace.

```yaml
Type: NamespaceState
Parameter Sets: (All)
Aliases: 
Accepted values: Unknown, Creating, Created, Activating, Enabling, Active, Disabling, Disabled, SoftDeleting, SoftDeleted, Removing, Removed, Failed

Required: False
Position: 5
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Tag
Hashtables which represents resource Tags.

```yaml
Type: Hashtable
Parameter Sets: (All)
Aliases: 

Required: False
Position: 6
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

## INPUTS

###-ResourceGroup
 System.String

###-NamespaceName
 System.String

###-Location
 System.String

###-SkuName
 System.String
 
###-SkuCapacity
 System.Int32

###-Tag
 System.Collections.Hashtable
 
## OUTPUTS

### Microsoft.Azure.Commands.EventHub.Models.NamespaceAttributes

Name               : EH-Example
Id                 : /subscriptions/854d368f-1828-428f-8f3c-f2affa9b2f7d/resourceGroups/RGName-PWR61219/providers/Microsoft.EventHub/namespaces/EH-Examp
Location           : West US
Sku                : Name : Standard , Capacity : 11 , Tier : Standard
ProvisioningState  : Succeeded
Status             : Active
CreatedAt          : 2/9/2017 5:34:44 AM
UpdatedAt          : 2/9/2017 5:43:18 AM
ServiceBusEndpoint : https://EH-Example.servicebus.windows.net:443/
Enabled            : True

## NOTES

## RELATED LINKS

