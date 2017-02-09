---
external help file: Microsoft.Azure.Commands.EventHub.dll-Help.xml
online version: 
schema: 2.0.0
---

# Get-AzureRmEventHubNamespaceKey

## SYNOPSIS
Gets the primary and secondary connection strings for the namespace.

## SYNTAX

```
Get-AzureRmEventHubNamespaceKey [-ResourceGroupName] <String> [-NamespaceName] <String> -AuthorizationRuleName <String> [<CommonParameters>]
```

## DESCRIPTION
The **Get-AzureRmEventHubNamespaceKey** cmdlet returns the primary and secondary connection strings for the given namespace.

## EXAMPLES

### Example 1
```
PS C:\> Get-AzureRmEventHubNamespaceKey RGName-PWR61219 -NamespaceName EH-Example -AuthorizationRuleName AuthoRule1
```

Returns Primary and secondary connection string to the specified namespace.

## PARAMETERS

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

### -AuthorizationRuleName
EventHub Namespace AuthorizationRule Name.

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
 
###-AuthorizationRuleName
 System.String

## OUTPUTS

### Microsoft.Azure.Commands.EventHub.Models.ListKeysAttributes

PrimaryConnectionString   : Endpoint=sb://eh-example.servicebus.windows.net/;SharedAccessKeyName=AuthoRule1;SharedAccessKey={Primary Key}
SecondaryConnectionString : Endpoint=sb://eh-example.servicebus.windows.net/;SharedAccessKeyName=AuthoRule1;SharedAccessKey={Secondary Key}
PrimaryKey                : {Primary Key}
SecondaryKey              : {Secondary Key}
KeyName                   : AuthoRule1

## NOTES

## RELATED LINKS

