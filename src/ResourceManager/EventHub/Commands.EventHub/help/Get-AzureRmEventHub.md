---
external help file: Microsoft.Azure.Commands.EventHub.dll-Help.xml
online version: 
schema: 2.0.0
---

# Get-AzureRmEventHub

## SYNOPSIS
Returns a description for the specified EventHub

## SYNTAX

```
Get-AzureRmEventHub [-ResourceGroupName] <String> [-NamespaceName] <String> [[-EventHubName] <String>] [<CommonParameters>]
```

## DESCRIPTION
The **Get-AzureRmEventHub** cmdlet returns a description of the specified EventHub.

## EXAMPLES

### Example 1
```
PS C:\> Get-AzureRmEventHub RGName-PWR61219 -NamespaceName EH-Example -EventHubName Eventhub1
```

Gets the description of specified EventHub of the give Event Hub Namespace

## PARAMETERS

### -EventHubName
EventHub Name.

```yaml
Type: String
Parameter Sets: (All)
Aliases: 

Required: False
Position: 2
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -NamespaceName
Namespace Name.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

###-ResourceGroup
 System.String

###-NamespaceName
 System.String

###-EventHubName
 System.String

## OUTPUTS

### System.Collections.Generic.List`1[[Microsoft.Azure.Commands.EventHub.Models.EventHubAttributes, Microsoft.Azure.Commands.EventHub, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null]]

Location               : West US
Name                   : Eventhub1
CreatedAt              : 2/9/2017 7:27:19 AM
MessageRetentionInDays : 6
PartitionCount         : 4
PartitionIds           : {0, 1, 2, 3}
Status                 : Active
UpdatedAt              : 2/9/2017 7:37:37 AM

## NOTES

## RELATED LINKS

