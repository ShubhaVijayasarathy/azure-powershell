---
external help file: Microsoft.Azure.Commands.EventHub.dll-Help.xml
online version: 
schema: 2.0.0
---

# Get-AzureRmEventHubKey

## SYNOPSIS
Gets the primary and secondary connection strings for the EventHub.

## SYNTAX

```
 Get-AzureRmEventHubKey [-ResourceGroupName] <String> [-NamespaceName] <String> [-EventHubName] <String> -AuthorizationRuleName <String> [<CommonParameters>]
```

## DESCRIPTION
The **Get-AzureRmEventHubKey** cmdlet returns the primary and secondary connection strings for the given EventHub.

## EXAMPLES

### Example 1
```
PS C:\> Get-AzureRmEventHubKey RGName-PWR61219 -NamespaceName EH-Example -EventHubName Eventhub1 -AuthorizationRuleName EHAuthoRule1
```

Gets the primary and secondary connection strings for the EventHub.

## PARAMETERS

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

### -AuthorizationRuleName
EventHub AuthorizationRule Name.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

###-ResourceGroup
 System.String
 
###-NamespaceName
 System.String
 
###-EventHubName
System.String
 
###-AuthorizationRuleName
 System.String

## OUTPUTS

### Microsoft.Azure.Commands.EventHub.Models.ListKeysAttributes

PrimaryConnectionString   : Endpoint=sb://eh-example.servicebus.windows.net/;SharedAccessKeyName=EHAuthoRule1;SharedAccessKey={Primary Key};EntityPath=Eventhub
SecondaryConnectionString : Endpoint=sb://eh-example.servicebus.windows.net/;SharedAccessKeyName=EHAuthoRule1;SharedAccessKey={Secondary Key};EntityPath=Eventhub
PrimaryKey                : {Primary Key}
SecondaryKey              : {Secondary Key}
KeyName                   : EHAuthoRule1

## NOTES

## RELATED LINKS

