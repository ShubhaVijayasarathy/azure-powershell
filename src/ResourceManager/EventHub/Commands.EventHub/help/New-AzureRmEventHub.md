---
external help file: Microsoft.Azure.Commands.EventHub.dll-Help.xml
online version: 
schema: 2.0.0
---

# New-AzureRmEventHub

## SYNOPSIS
Create a new Event Hub in  the specified Event Hub namespace.

## SYNTAX

```
New-AzureRmEventHub [-ResourceGroupName] <String> [-NamespaceName] <String> [-EventHubName] <String> [[-EventHubObj] <EventHubAttributes>] [-Confirm] [-WhatIf] -Location <String>
[-MessageRetentionInDays <Int64>] [-PartitionCount <Int64>] [<CommonParameters>]
```

## DESCRIPTION
The **New-AzureRmEventHub** cmdlet creates a new Event Hub in the specified Event Hub namespace.

## EXAMPLES

### Example 1
```
PS C:\> New-AzureRmEventHub RGName-PWR61219 -NamespaceName EH-Example -Location WestUS -EventHubName Eventhub1
```

Creates a new Event Hub `Eventhub1` in the specified Event Hub namespace `EH-Example`.

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

### -EventHubName
Eventhub Name.

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

### -EventHubObj
EventHub object.

```yaml
Type: EventHubAttributes
Parameter Sets: (All)
Aliases: 

Required: False
Position: 3
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

### -Location
Namespace Location.

```yaml
Type: String
Parameter Sets: (All)
Aliases: 

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -MessageRetentionInDays
Eventhub Message Retention In Days.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases: 

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -PartitionCount
Eventhub PartitionCount.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases: 

Required: False
Position: Named
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

###-MessageRetentionInDays
 System.Int64

###-PartitionCount
 System.Int64


## OUTPUTS

### Microsoft.Azure.Commands.EventHub.Models.EventHubAttributes

Location               : West US
Name                   : Eventhub1
CreatedAt              : 2/9/2017 7:27:19 AM
MessageRetentionInDays : 7
PartitionCount         : 4
PartitionIds           : {0, 1, 2, 3}
Status                 : Active
UpdatedAt              : 2/9/2017 7:27:29 AM

## NOTES

## RELATED LINKS

