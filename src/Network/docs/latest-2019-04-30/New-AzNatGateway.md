---
external help file:
Module Name: Az.Network
online version: https://docs.microsoft.com/en-us/powershell/module/az.network/new-aznatgateway
schema: 2.0.0
---

# New-AzNatGateway

## SYNOPSIS
Creates or updates a nat gateway.

## SYNTAX

### CreateExpanded (Default)
```
New-AzNatGateway -Name <String> -ResourceGroupName <String> -SubscriptionId <String> [-Etag <String>]
 [-Id <String>] [-IdleTimeoutInMinutes <Int32>] [-Location <String>] [-ProvisioningState <String>]
 [-PublicIPAddress <ISubResource[]>] [-PublicIPPrefix <ISubResource[]>] [-ResourceGuid <String>]
 [-SkuName <NatGatewaySkuName>] [-Tag <Hashtable>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-AzNatGateway -Name <String> -ResourceGroupName <String> -SubscriptionId <String> -NatGateway <INatGateway>
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-AzNatGateway -InputObject <INetworkIdentity> [-Etag <String>] [-Id <String>]
 [-IdleTimeoutInMinutes <Int32>] [-Location <String>] [-ProvisioningState <String>]
 [-PublicIPAddress <ISubResource[]>] [-PublicIPPrefix <ISubResource[]>] [-ResourceGuid <String>]
 [-SkuName <NatGatewaySkuName>] [-Tag <Hashtable>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-AzNatGateway -InputObject <INetworkIdentity> -NatGateway <INatGateway> [-DefaultProfile <PSObject>]
 [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Creates or updates a nat gateway.

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Etag
A unique read-only string that changes whenever the resource is updated.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
Resource ID.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IdleTimeoutInMinutes
The idle timeout of the nat gateway.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.INetworkIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Location
Resource location.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Name
The name of the nat gateway.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, Create
Aliases: NatGatewayName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -NatGateway
Nat Gateway resource.
To construct, see NOTES section for NATGATEWAY properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.INatGateway
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ProvisioningState
The provisioning state of the NatGateway resource.
Possible values are: 'Updating', 'Deleting', and 'Failed'.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PublicIPAddress
An array of public ip addresses associated with the nat gateway resource.
To construct, see NOTES section for PUBLICIPADDRESS properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.ISubResource[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PublicIPPrefix
An array of public ip prefixes associated with the nat gateway resource.
To construct, see NOTES section for PUBLICIPPREFIX properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.ISubResource[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceGroupName
The name of the resource group.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceGuid
The resource GUID property of the nat gateway resource.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SkuName
Name of Nat Gateway SKU.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.NatGatewaySkuName
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SubscriptionId
The subscription credentials which uniquely identify the Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Tag
Resource tags.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.INetworkIdentity

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.INatGateway

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.INatGateway

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### NATGATEWAY <INatGateway>: Nat Gateway resource.
  - `[Id <String>]`: Resource ID.
  - `[Location <String>]`: Resource location.
  - `[Tag <IResourceTags>]`: Resource tags.
    - `[(Any) <String>]`: This indicates any property can be added to this object.
  - `[Etag <String>]`: A unique read-only string that changes whenever the resource is updated.
  - `[IdleTimeoutInMinutes <Int32?>]`: The idle timeout of the nat gateway.
  - `[ProvisioningState <String>]`: The provisioning state of the NatGateway resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
  - `[PublicIPAddress <ISubResource[]>]`: An array of public ip addresses associated with the nat gateway resource.
    - `[Id <String>]`: Resource ID.
  - `[PublicIPPrefix <ISubResource[]>]`: An array of public ip prefixes associated with the nat gateway resource.
  - `[ResourceGuid <String>]`: The resource GUID property of the nat gateway resource.
  - `[SkuName <NatGatewaySkuName?>]`: Name of Nat Gateway SKU.

#### PUBLICIPADDRESS <ISubResource[]>: An array of public ip addresses associated with the nat gateway resource.
  - `[Id <String>]`: Resource ID.

#### PUBLICIPPREFIX <ISubResource[]>: An array of public ip prefixes associated with the nat gateway resource.
  - `[Id <String>]`: Resource ID.

## RELATED LINKS
