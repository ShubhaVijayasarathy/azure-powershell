---
external help file: Microsoft.Azure.Commands.EventHub.dll-Help.xml
online version: 
schema: 2.0.0
---

# New-AzureRmEventHubNamespaceAuthorizationRule

## SYNOPSIS
Creates a new authorization rule for the specified Event Hub namespace

## SYNTAX

```
New-AzureRmEventHubNamespaceAuthorizationRule [-ResourceGroup] <String> [-NamespaceName] <String> [-AuthorizationRuleName] <String> [-Rights] <String[]> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The **New-AzureRmEventHubNamespaceAuthorizationRule** cmdlet creates a new authorization rule for the specified Event Hub namespace.

## EXAMPLES

### Example 1
```
PS C:\> New-AzureRmEventHubNamespaceAuthorizationRule RGName-PWR61219 -NamespaceName EH-Example -AuthorizationRuleName AuthoRule1 -Rights @("Listen","Send")
```

Creates `AuthoRule1` with **Listen** and **Send** rights for the namespace `EH-Example`.

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

### -AuthorizationRuleName
AuthorizationRule Name.

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

### -Rights
Rights, e.g. 
@("Listen","Send","Manage")

```yaml
Type: String[]
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
 
###-Rights
 System.String []

## OUTPUTS

### Microsoft.Azure.Commands.EventHub.Models.SharedAccessAuthorizationRuleAttributes

Id       : /subscriptions/854d368f-1828-428f-8f3c-f2affa9b2f7d/resourceGroups/RGName-PWR61219/providers/Microsoft.EventHub/namespaces/EH-Example/AuthorizationRules/AuthoRule1
Type     : Microsoft.EventHub/AuthorizationRules
Name     : AuthoRule1
Location :
Tags     :
Rights   : {Listen, Send}

## NOTES

## RELATED LINKS

