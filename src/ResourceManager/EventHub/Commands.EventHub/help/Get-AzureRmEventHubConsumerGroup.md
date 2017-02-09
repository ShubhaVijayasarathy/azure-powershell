---
external help file: Microsoft.Azure.Commands.EventHub.dll-Help.xml
online version: 
schema: 2.0.0
---

# Get-AzureRmEventHubConsumerGroup

## SYNOPSIS
Get the description of specified Consumer Group in the given Event Hub.

## SYNTAX

```
Get-AzureRmEventHubConsumerGroup [-ResourceGroupName] <String> [-NamespaceName] <String> [-EventHubName] <String> [[-ConsumerGroupName] <String>] [<CommonParameters>]
```

## DESCRIPTION
The **Get-AzureRmEventHubConsumerGroup** cmdlet gets the description of specified Consumer Group in the given Event Hub.

## EXAMPLES

### Example 1
```
PS C:\> Get-AzureRmEventHubConsumerGroup RGName-PWR61219 -NamespaceName EH-Example -EventHubName Eventhub1 -ConsumerGroupName ConsumerGRP
```

Returns the description of Consumer Group 'ConsumerGRP'  in  the specified Event Hub 'Eventhub1' 

## PARAMETERS

### -ConsumerGroupName
ConsumerGroup Name.

```yaml
Type: String
Parameter Sets: (All)
Aliases: 

Required: False
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

