---
external help file: Microsoft.Azure.Commands.EventHub.dll-Help.xml
online version: 
schema: 2.0.0
---

# Get-AzureRmEventHubNamespaceAuthorizationRule

## SYNOPSIS
Gets a description of the specified authorization rule for a given namespace.

## SYNTAX

```
Get-AzureRmEventHubNamespaceAuthorizationRule [-ResourceGroupName] <String> [-NamespaceName] <String> [[-AuthorizationRuleName] <String>] [<CommonParameters>]
```

## DESCRIPTION
The **Get-AzureRmEventHubNamespaceAuthorizationRule** cmdlet gets the description of the specified authorization rule in the given namespace.

## EXAMPLES

### Example 1
```
PS C:\> Get-AzureRmEventHubNamespaceAuthorizationRule RGName-PWR61219 -NamespaceName EH-Example -AuthorizationRuleName AuthoRule1
```

Returns the specified authorization rule description for a specified namespace.

## PARAMETERS

### -AuthorizationRuleName
EventHub Namespace AuthorizationRule Name.

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

## INPUTS

###-ResourceGroup
 System.String
 
###-NamespaceName
 System.String
 
###-AuthorizationRuleName
 System.String

## OUTPUTS

### System.Collections.Generic.List`1[[Microsoft.Azure.Commands.EventHub.Models.SharedAccessAuthorizationRuleAttributes, Microsoft.Azure.Commands.EventHub, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null]]

Id       : /subscriptions/854d368f-1828-428f-8f3c-f2affa9b2f7d/resourceGroups/RGName-PWR61219/providers/Microsoft.EventHub/namespaces/EH-Example/AuthorizationRules/AuthoRule1
Type     : Microsoft.EventHub/AuthorizationRules
Name     : AuthoRule1
Location :
Tags     :
Rights   : {Listen, Send}

## NOTES

## RELATED LINKS

