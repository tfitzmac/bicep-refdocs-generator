---
title: Microsoft.Addons/supportProviders/supportPlanTypes 2018-03-01
description: Azure Microsoft.Addons/supportProviders/supportPlanTypes syntax and properties to use in Azure Resource Manager templates for deploying the resource. API version 2018-03-01
author: tfitzmac
zone_pivot_groups: deployment-languages-reference
ms.service: azure-resource-manager
ms.topic: reference
ms.date: 09/13/2024
ms.author: tomfitz
---
# Microsoft.Addons supportProviders/supportPlanTypes 2018-03-01

> [!div class="op_single_selector" title1="API Versions:"]
> - [Latest](../../supportproviders/supportplantypes.md)
> - [2018-03-01](../../2018-03-01/supportproviders/supportplantypes.md)
> - [2017-05-15](../../2017-05-15/supportproviders/supportplantypes.md)


::: zone pivot="deployment-language-bicep"

## Bicep resource definition

The supportProviders/supportPlanTypes resource type can be deployed with operations that target: 

* **Subscription** - See [subscription deployment commands](/azure/azure-resource-manager/bicep/deploy-to-subscription)

For a list of changed properties in each API version, see [change log](~/microsoft.addons/change-log/supportproviders/supportplantypes.md).

## Resource format

To create a Microsoft.Addons/supportProviders/supportPlanTypes resource, add the following Bicep to your template.

```bicep
resource symbolicname 'Microsoft.Addons/supportProviders/supportPlanTypes@2018-03-01' = {
  name: 'string'
}
```
## Property values

### Microsoft.Addons/supportProviders/supportPlanTypes

| Name | Description | Value |
| ---- | ----------- | ------------ |
| name | The resource name | 'Advanced'<br />'Essential'<br />'Standard' (required) |



::: zone-end

::: zone pivot="deployment-language-arm-template"

## ARM template resource definition

The supportProviders/supportPlanTypes resource type can be deployed with operations that target: 

* **Subscription** - See [subscription deployment commands](/azure/azure-resource-manager/templates/deploy-to-subscription)

For a list of changed properties in each API version, see [change log](~/microsoft.addons/change-log/supportproviders/supportplantypes.md).

## Resource format

To create a Microsoft.Addons/supportProviders/supportPlanTypes resource, add the following JSON to your template.

```json
{
  "type": "Microsoft.Addons/supportProviders/supportPlanTypes",
  "apiVersion": "2018-03-01",
  "name": "string"
}
```
## Property values

### Microsoft.Addons/supportProviders/supportPlanTypes

| Name | Description | Value |
| ---- | ----------- | ------------ |
| name | The resource name | 'Advanced'<br />'Essential'<br />'Standard' (required) |



::: zone-end

::: zone pivot="deployment-language-terraform"

## Terraform (AzAPI provider) resource definition

The supportProviders/supportPlanTypes resource type can be deployed with operations that target: 

* **Subscription**

For a list of changed properties in each API version, see [change log](~/microsoft.addons/change-log/supportproviders/supportplantypes.md).

## Resource format

To create a Microsoft.Addons/supportProviders/supportPlanTypes resource, add the following Terraform to your template.

```terraform
resource "azapi_resource" "symbolicname" = {
  type = "Microsoft.Addons/supportProviders/supportPlanTypes@2018-03-01"
  name = "string"
}
```
## Property values

### Microsoft.Addons/supportProviders/supportPlanTypes

| Name | Description | Value |
| ---- | ----------- | ------------ |
| name | The resource name | 'Advanced'<br />'Essential'<br />'Standard' (required) |


::: zone-end