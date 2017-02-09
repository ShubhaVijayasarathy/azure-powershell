---
external help file: Microsoft.Azure.Commands.EventHub.dll-Help.xml
online version: 
schema: 2.0.0
---

# Remove-AzureRmEventHub

## SYNOPSIS
Removes the EventHub from the specified Event Hub namespace.

## SYNTAX

```
 Remove-AzureRmEventHub [-ResourceGroupName] <String> [-NamespaceName] <String> [-EventHubName] <String> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The **Remove-AzureRmEventHub** cmdlet removes EventHub from the specified Event Hub namespace.

## EXAMPLES

### Example 1
```
PS C:\> Remove-AzureRmEventHub RGName-PWR61219 -NamespaceName EH-Example -EventHubName Eventhub1
```

Removes specified EventHub of the give Event Hub Namespace

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

## NOTES

## RELATED LINKS

