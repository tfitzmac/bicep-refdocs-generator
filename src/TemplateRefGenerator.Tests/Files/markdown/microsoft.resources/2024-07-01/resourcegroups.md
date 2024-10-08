---
title: Microsoft.Resources/resourceGroups 2024-07-01
description: Azure Microsoft.Resources/resourceGroups syntax and properties to use in Azure Resource Manager templates for deploying the resource. API version 2024-07-01
author: tfitzmac
zone_pivot_groups: deployment-languages-reference
ms.service: azure-resource-manager
ms.topic: reference
ms.date: 09/13/2024
ms.author: tomfitz
---
# Microsoft.Resources resourceGroups 2024-07-01

> [!div class="op_single_selector" title1="API Versions:"]
> - [Latest](../resourcegroups.md)
> - [2024-07-01](../2024-07-01/resourcegroups.md)
> - [2024-03-01](../2024-03-01/resourcegroups.md)
> - [2023-07-01](../2023-07-01/resourcegroups.md)
> - [2022-09-01](../2022-09-01/resourcegroups.md)
> - [2021-04-01](../2021-04-01/resourcegroups.md)
> - [2021-01-01](../2021-01-01/resourcegroups.md)
> - [2020-10-01](../2020-10-01/resourcegroups.md)
> - [2020-08-01](../2020-08-01/resourcegroups.md)
> - [2020-06-01](../2020-06-01/resourcegroups.md)
> - [2019-10-01](../2019-10-01/resourcegroups.md)
> - [2019-08-01](../2019-08-01/resourcegroups.md)
> - [2019-07-01](../2019-07-01/resourcegroups.md)
> - [2019-05-10](../2019-05-10/resourcegroups.md)
> - [2019-05-01](../2019-05-01/resourcegroups.md)
> - [2019-03-01](../2019-03-01/resourcegroups.md)
> - [2018-05-01](../2018-05-01/resourcegroups.md)
> - [2018-02-01](../2018-02-01/resourcegroups.md)
> - [2017-05-10](../2017-05-10/resourcegroups.md)
> - [2016-09-01](../2016-09-01/resourcegroups.md)
> - [2016-07-01](../2016-07-01/resourcegroups.md)
> - [2016-02-01](../2016-02-01/resourcegroups.md)
> - [2015-11-01](../2015-11-01/resourcegroups.md)


::: zone pivot="deployment-language-bicep"

## Bicep resource definition

The resourceGroups resource type can be deployed with operations that target: 

* **Subscription** - See [subscription deployment commands](/azure/azure-resource-manager/bicep/deploy-to-subscription)

For a list of changed properties in each API version, see [change log](~/microsoft.resources/change-log/resourcegroups.md).

## Resource format

To create a Microsoft.Resources/resourceGroups resource, add the following Bicep to your template.

```bicep
resource symbolicname 'Microsoft.Resources/resourceGroups@2024-07-01' = {
  location: 'string'
  managedBy: 'string'
  name: 'string'
  properties: {}
  tags: {
    {customized property}: 'string'
  }
}
```
## Examples

A basic example of deploying a resource group.

```bicep
targetScope = 'subscription'

resource rg 'Microsoft.Resources/resourceGroups@2021-04-01' = {
  name: 'myResourceGroup'
  location: deployment().location
  tags: {
    environment: 'production'
  }
}
```
## Property values

### Microsoft.Resources/resourceGroups

| Name | Description | Value |
| ---- | ----------- | ------------ |
| location | The location of the resource group. It cannot be changed after the resource group has been created. It must be one of the supported Azure locations. | string (required) |
| managedBy | The ID of the resource that manages this resource group. | string |
| name | The resource name | string <br /><br />Constraints:<br />Min length = 1<br />Max length = 1<br />Pattern = `^[-\w\._\(\)]+$` (required) |
| properties | The resource group properties. | [ResourceGroupProperties](#resourcegroupproperties) |
| tags | The tags attached to the resource group. | [ResourceGroupTags](#resourcegrouptags) |

### ResourceGroupProperties

| Name | Description | Value |
| ---- | ----------- | ------------ |

### ResourceGroupTags

| Name | Description | Value |
| ---- | ----------- | ------------ |


## Quickstart templates

The following quickstart templates deploy this resource type.

> [!div class="mx-tableFixed"]
> | Template | Description |
> | ----- | ----- |
> | [Create a new Datadog Organization](https://github.com/Azure/azure-quickstart-templates/tree/master/quickstarts/microsoft.datadog/datadog)<br><br>[![Deploy to Azure](~/media/deploy-to-azure.svg)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2FAzure%2Fazure-quickstart-templates%2Fmaster%2Fquickstarts%2Fmicrosoft.datadog%2Fdatadog%2Fazuredeploy.json) | This template creates a new Datadog - An Azure Native ISV Service resource and a Datadog organization to monitor resources in your subscription. |
> | [Configure Deployment Environments service](https://github.com/Azure/azure-quickstart-templates/tree/master/quickstarts/microsoft.devcenter/deployment-environments)<br><br>[![Deploy to Azure](~/media/deploy-to-azure.svg)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2FAzure%2Fazure-quickstart-templates%2Fmaster%2Fquickstarts%2Fmicrosoft.devcenter%2Fdeployment-environments%2Fazuredeploy.json) | This template provides a way to configure Deployment Environments. |
> | [Create a resourceGroup](https://github.com/Azure/azure-quickstart-templates/tree/master/subscription-deployments/create-rg)<br><br>[![Deploy to Azure](~/media/deploy-to-azure.svg)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2FAzure%2Fazure-quickstart-templates%2Fmaster%2Fsubscription-deployments%2Fcreate-rg%2Fazuredeploy.json) | This template is a subscription level template that will create a resourceGroup.  Currently, this template can be deployed via the Azure Portal. |
> | [Create a resourceGroup, apply a lock and RBAC](https://github.com/Azure/azure-quickstart-templates/tree/master/subscription-deployments/create-rg-lock-role-assignment)<br><br>[![Deploy to Azure](~/media/deploy-to-azure.svg)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2FAzure%2Fazure-quickstart-templates%2Fmaster%2Fsubscription-deployments%2Fcreate-rg-lock-role-assignment%2Fazuredeploy.json) | This template is a subscription level template that will create a resourceGroup, apply a lock the the resourceGroup and assign contributor permssions to the supplied principalId.  Currently, this template cannot be deployed via the Azure Portal. |
> | [Create an Azure Virtual Network Manager and sample VNETs](https://github.com/Azure/azure-quickstart-templates/tree/master/subscription-deployments/microsoft.network/virtual-network-manager-connectivity)<br><br>[![Deploy to Azure](~/media/deploy-to-azure.svg)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2FAzure%2Fazure-quickstart-templates%2Fmaster%2Fsubscription-deployments%2Fmicrosoft.network%2Fvirtual-network-manager-connectivity%2Fazuredeploy.json) | This template deploys an Azure Virtual Network Manager and sample virtual networks into the named resource group. It supports multiple connectivity topologies and network group membership types. |

::: zone-end

::: zone pivot="deployment-language-arm-template"

## ARM template resource definition

The resourceGroups resource type can be deployed with operations that target: 

* **Subscription** - See [subscription deployment commands](/azure/azure-resource-manager/templates/deploy-to-subscription)

For a list of changed properties in each API version, see [change log](~/microsoft.resources/change-log/resourcegroups.md).

## Resource format

To create a Microsoft.Resources/resourceGroups resource, add the following JSON to your template.

```json
{
  "type": "Microsoft.Resources/resourceGroups",
  "apiVersion": "2024-07-01",
  "name": "string",
  "location": "string",
  "managedBy": "string",
  "properties": {
  },
  "tags": {
    "{customized property}": "string"
  }
}
```
## Property values

### Microsoft.Resources/resourceGroups

| Name | Description | Value |
| ---- | ----------- | ------------ |
| location | The location of the resource group. It cannot be changed after the resource group has been created. It must be one of the supported Azure locations. | string (required) |
| managedBy | The ID of the resource that manages this resource group. | string |
| name | The resource name | string <br /><br />Constraints:<br />Min length = 1<br />Max length = 1<br />Pattern = `^[-\w\._\(\)]+$` (required) |
| properties | The resource group properties. | [ResourceGroupProperties](#resourcegroupproperties-1) |
| tags | The tags attached to the resource group. | [ResourceGroupTags](#resourcegrouptags-1) |

### ResourceGroupProperties

| Name | Description | Value |
| ---- | ----------- | ------------ |

### ResourceGroupTags

| Name | Description | Value |
| ---- | ----------- | ------------ |


## Quickstart templates

The following quickstart templates deploy this resource type.

> [!div class="mx-tableFixed"]
> | Template | Description |
> | ----- | ----- |
> | [Create a new Datadog Organization](https://github.com/Azure/azure-quickstart-templates/tree/master/quickstarts/microsoft.datadog/datadog)<br><br>[![Deploy to Azure](~/media/deploy-to-azure.svg)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2FAzure%2Fazure-quickstart-templates%2Fmaster%2Fquickstarts%2Fmicrosoft.datadog%2Fdatadog%2Fazuredeploy.json) | This template creates a new Datadog - An Azure Native ISV Service resource and a Datadog organization to monitor resources in your subscription. |
> | [Configure Deployment Environments service](https://github.com/Azure/azure-quickstart-templates/tree/master/quickstarts/microsoft.devcenter/deployment-environments)<br><br>[![Deploy to Azure](~/media/deploy-to-azure.svg)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2FAzure%2Fazure-quickstart-templates%2Fmaster%2Fquickstarts%2Fmicrosoft.devcenter%2Fdeployment-environments%2Fazuredeploy.json) | This template provides a way to configure Deployment Environments. |
> | [Create a resourceGroup](https://github.com/Azure/azure-quickstart-templates/tree/master/subscription-deployments/create-rg)<br><br>[![Deploy to Azure](~/media/deploy-to-azure.svg)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2FAzure%2Fazure-quickstart-templates%2Fmaster%2Fsubscription-deployments%2Fcreate-rg%2Fazuredeploy.json) | This template is a subscription level template that will create a resourceGroup.  Currently, this template can be deployed via the Azure Portal. |
> | [Create a resourceGroup, apply a lock and RBAC](https://github.com/Azure/azure-quickstart-templates/tree/master/subscription-deployments/create-rg-lock-role-assignment)<br><br>[![Deploy to Azure](~/media/deploy-to-azure.svg)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2FAzure%2Fazure-quickstart-templates%2Fmaster%2Fsubscription-deployments%2Fcreate-rg-lock-role-assignment%2Fazuredeploy.json) | This template is a subscription level template that will create a resourceGroup, apply a lock the the resourceGroup and assign contributor permssions to the supplied principalId.  Currently, this template cannot be deployed via the Azure Portal. |
> | [Create an Azure Virtual Network Manager and sample VNETs](https://github.com/Azure/azure-quickstart-templates/tree/master/subscription-deployments/microsoft.network/virtual-network-manager-connectivity)<br><br>[![Deploy to Azure](~/media/deploy-to-azure.svg)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2FAzure%2Fazure-quickstart-templates%2Fmaster%2Fsubscription-deployments%2Fmicrosoft.network%2Fvirtual-network-manager-connectivity%2Fazuredeploy.json) | This template deploys an Azure Virtual Network Manager and sample virtual networks into the named resource group. It supports multiple connectivity topologies and network group membership types. |

::: zone-end

::: zone pivot="deployment-language-terraform"

## Terraform (AzAPI provider) resource definition

The resourceGroups resource type can be deployed with operations that target: 

* **Subscription**

For a list of changed properties in each API version, see [change log](~/microsoft.resources/change-log/resourcegroups.md).

## Resource format

To create a Microsoft.Resources/resourceGroups resource, add the following Terraform to your template.

```terraform
resource "azapi_resource" "symbolicname" = {
  type = "Microsoft.Resources/resourceGroups@2024-07-01"
  name = "string"
  location = "string"
  managedBy = "string"
  body = jsonencode({
    properties = {
    }
  })
  tags = {
    {customized property} = "string"
  }
}
```
## Property values

### Microsoft.Resources/resourceGroups

| Name | Description | Value |
| ---- | ----------- | ------------ |
| location | The location of the resource group. It cannot be changed after the resource group has been created. It must be one of the supported Azure locations. | string (required) |
| managedBy | The ID of the resource that manages this resource group. | string |
| name | The resource name | string <br /><br />Constraints:<br />Min length = 1<br />Max length = 1<br />Pattern = `^[-\w\._\(\)]+$` (required) |
| properties | The resource group properties. | [ResourceGroupProperties](#resourcegroupproperties-2) |
| tags | The tags attached to the resource group. | [ResourceGroupTags](#resourcegrouptags-2) |

### ResourceGroupProperties

| Name | Description | Value |
| ---- | ----------- | ------------ |

### ResourceGroupTags

| Name | Description | Value |
| ---- | ----------- | ------------ |


::: zone-end