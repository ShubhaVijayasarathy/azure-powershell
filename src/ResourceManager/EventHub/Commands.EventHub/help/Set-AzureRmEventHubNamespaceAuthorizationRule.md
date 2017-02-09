---
external help file: Microsoft.Azure.Commands.EventHub.dll-Help.xml
online version: 
schema: 2.0.0
---

# Set-AzureRmEventHubNamespaceAuthorizationRule

## SYNOPSIS
Updates the specified authorization rule description for the given Event Hub namespace.

## SYNTAX

```
Set-AzureRmEventHubNamespaceAuthorizationRule [-ResourceGroupName] <String> [-NamespaceName] <String>
 -AuthRuleObj <SharedAccessAuthorizationRuleAttributes> [-AuthorizationRuleName <String>] [-Rights <String[]>]
 [-WhatIf] [-Confirm]
```

## DESCRIPTION
The **Set-AzureRmEventHubNamespaceAuthorizationRule** cmdlet updates the description for the specified authorization rule of the given Event Hub namespace.

## EXAMPLES

### Example 1
```
PS C:\> $ObjNSAuthRule = Get-AzureRmEventHubNamespaceAuthorizationRule RGName-PWR61219 -NamespaceName EH-Example -AuthorizationRuleName AuthoRule1
PS C:\> $ObjNSAuthRule.Rights.Add("Manage")
PS C:\> Set-AzureRmEventHubNamespaceAuthorizationRule RGName-PWR61219 -NamespaceName EH-Example -AuthorizationRuleName AuthoRule1 -AuthRuleObj $ObjNSAuthRule
```

Adds **Manage** from the access rights of the authorization rule `AuthoRule1` in namespace `EH-Example`.

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
AuthorizationRule Name - Required if 'AuthruleObj' not specified.

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

### -AuthRuleObj
EventHub NameSpace AuthorizationRule Object.

```yaml
Type: SharedAccessAuthorizationRuleAttributes
Parameter Sets: (All)
Aliases: 

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Rights
Required if 'AuthruleObj' not specified.
Rights - e.g. 
@("Listen","Send","Manage")

```yaml
Type: String[]
Parameter Sets: (All)
Aliases: 

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

## INPUTS

###-ResourceGroup
 System.String
 
###-NamespaceName
 System.String
 
###-AuthRuleObj
 Microsoft.Azure.Commands.EventHub.Models.SharedAccessAuthorizationRuleAttributes

## OUTPUTS

### Microsoft.Azure.Commands.EventHub.Models.SharedAccessAuthorizationRuleAttributes

Id       : /subscriptions/854d368f-1828-428f-8f3c-f2affa9b2f7d/resourceGroups/RGName-PWR61219/providers/Microsoft.EventHub/namespaces/EH-Example/AuthorizationRules/AuthoRule1
Type     : Microsoft.EventHub/AuthorizationRules
Name     : AuthoRule1
Location :
Tags     :
Rights   : {Listen, Send, Manage}

## NOTES

## RELATED LINKS

