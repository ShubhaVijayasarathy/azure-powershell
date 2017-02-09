---
external help file: Microsoft.Azure.Commands.EventHub.dll-Help.xml
online version: 
schema: 2.0.0
---

# New-AzureRmEventHubConsumerGroup

## SYNOPSIS
Create a new Consumer Group in  the specified Event Hub.

## SYNTAX

```
New-AzureRmEventHubConsumerGroup [-ResourceGroupName] <String> [-NamespaceName] <String> [-EventHubName] <String> [-ConsumerGroupName] <String> [-Confirm] [-WhatIf] [-UserMetadata <String>]
[<CommonParameters>]
```

## DESCRIPTION
The **New-AzureRmEventHubConsumerGroup** cmdlet create a new Consumer Group in  the specified Event Hub.

## EXAMPLES

### Example 1
```
PS C:\> New-AzureRmEventHubConsumerGroup RGName-PWR61219 -NamespaceName EH-Example -EventHubName Eventhub1 -ConsumerGroupName ConsumerGRP
```

Create a new Consumer Group 'ConsumerGRP'  in  the specified Event Hub 'Eventhub1' .

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

### -ConsumerGroupName
ConsumerGroup Name.

```yaml
Type: String
Parameter Sets: (All)
Aliases: 

Required: True
Position: 3
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -EventHubName
EventHub Name.

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

### -UserMetadata
User Metadata for ConsumerGroup

```yaml
Type: String
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

###-ConsumerGroupName
 System.String 

## OUTPUTS

### Microsoft.Azure.Commands.EventHub.Models.ConsumerGroupAttributes

Name         : ConsumerGRP
Location     : West US
CreatedAt    : 2/9/2017 8:19:36 AM
UpdatedAt    : 2/9/2017 8:19:36 AM
EventHubPath :
UserMetadata :

## NOTES

## RELATED LINKS

