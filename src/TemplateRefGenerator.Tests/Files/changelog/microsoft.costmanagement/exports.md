---
title: API change log for Microsoft.CostManagement/exports
description: Describes changes between API versions for Microsoft.CostManagement/exports.
author: tfitzmac
ms.service: azure-resource-manager
ms.topic: reference
ms.date: 09/13/2024
ms.author: tomfitz
---
# API version change log for deployment of Microsoft.CostManagement/exports

This article describes the properties that changed in each API version for [microsoft.costmanagement/exports](~/microsoft.costmanagement/exports.md). It only covers properties that are available during deployments.

## 2023-11-01

No properties added, updated or removed.

## 2023-09-01

No properties added, updated or removed.

## 2023-08-01

Removed:

* [ExportSuspensionContext](~/microsoft.costmanagement/2023-08-01/exports.md#exportsuspensioncontext)
* [FilterItems](~/microsoft.costmanagement/2023-08-01/exports.md#filteritems)

Updated:

* [ExportDatasetConfiguration](~/microsoft.costmanagement/2023-08-01/exports.md#exportdatasetconfiguration): Removed property 'dataVersion'
* [ExportDatasetConfiguration](~/microsoft.costmanagement/2023-08-01/exports.md#exportdatasetconfiguration): Removed property 'filters'
* [ExportDeliveryDestination](~/microsoft.costmanagement/2023-08-01/exports.md#exportdeliverydestination): Removed property 'type'
* [ExportProperties](~/microsoft.costmanagement/2023-08-01/exports.md#exportproperties): Removed property 'compressionMode'
* [ExportProperties](~/microsoft.costmanagement/2023-08-01/exports.md#exportproperties): Removed property 'dataOverwriteBehavior'
* [ExportProperties](~/microsoft.costmanagement/2023-08-01/exports.md#exportproperties): Removed property 'exportDescription'
* [ExportProperties](~/microsoft.costmanagement/2023-08-01/exports.md#exportproperties): Removed property 'systemSuspensionContext'


## 2023-07-01-preview

Added:

* [ExportSuspensionContext](~/microsoft.costmanagement/2023-07-01-preview/exports.md#exportsuspensioncontext)
* [FilterItems](~/microsoft.costmanagement/2023-07-01-preview/exports.md#filteritems)

Updated:

* [ExportDatasetConfiguration](~/microsoft.costmanagement/2023-07-01-preview/exports.md#exportdatasetconfiguration): Added property 'dataVersion'
* [ExportDatasetConfiguration](~/microsoft.costmanagement/2023-07-01-preview/exports.md#exportdatasetconfiguration): Added property 'filters'
* [ExportDeliveryDestination](~/microsoft.costmanagement/2023-07-01-preview/exports.md#exportdeliverydestination): Added property 'type'
* [ExportProperties](~/microsoft.costmanagement/2023-07-01-preview/exports.md#exportproperties): Added property 'compressionMode'
* [ExportProperties](~/microsoft.costmanagement/2023-07-01-preview/exports.md#exportproperties): Added property 'dataOverwriteBehavior'
* [ExportProperties](~/microsoft.costmanagement/2023-07-01-preview/exports.md#exportproperties): Added property 'exportDescription'
* [ExportProperties](~/microsoft.costmanagement/2023-07-01-preview/exports.md#exportproperties): Added property 'systemSuspensionContext'


## 2023-04-01-preview

Added:

* [SystemAssignedServiceIdentity](~/microsoft.costmanagement/2023-04-01-preview/exports.md#systemassignedserviceidentity)

Updated:

* [Microsoft.CostManagement/exports](~/microsoft.costmanagement/2023-04-01-preview/exports.md#microsoft.costmanagement/exports): Added property 'identity'
* [Microsoft.CostManagement/exports](~/microsoft.costmanagement/2023-04-01-preview/exports.md#microsoft.costmanagement/exports): Added property 'location'


## 2023-03-01

No properties added, updated or removed.

## 2022-10-01

Added:

* [ExportRun](~/microsoft.costmanagement/2022-10-01/exports.md#exportrun)

Removed:

* [ExportExecution](~/microsoft.costmanagement/2022-10-01/exports.md#exportexecution)


## 2021-10-01

No properties added, updated or removed.

## 2021-01-01

Updated:

* [ExportProperties](~/microsoft.costmanagement/2021-01-01/exports.md#exportproperties): Added property 'partitionData'


## 2020-12-01-preview

Updated:

* [ExportDeliveryDestination](~/microsoft.costmanagement/2020-12-01-preview/exports.md#exportdeliverydestination): Added property 'sasToken'
* [ExportDeliveryDestination](~/microsoft.costmanagement/2020-12-01-preview/exports.md#exportdeliverydestination): Added property 'storageAccount'


## 2020-06-01

Added:

* [ExportDataset](~/microsoft.costmanagement/2020-06-01/exports.md#exportdataset)
* [ExportDatasetConfiguration](~/microsoft.costmanagement/2020-06-01/exports.md#exportdatasetconfiguration)
* [ExportExecution](~/microsoft.costmanagement/2020-06-01/exports.md#exportexecution)
* [ExportExecutionListResult](~/microsoft.costmanagement/2020-06-01/exports.md#exportexecutionlistresult)
* [ExportTimePeriod](~/microsoft.costmanagement/2020-06-01/exports.md#exporttimeperiod)

Removed:

* [QueryAggregation](~/microsoft.costmanagement/2020-06-01/exports.md#queryaggregation)
* [QueryComparisonExpression](~/microsoft.costmanagement/2020-06-01/exports.md#querycomparisonexpression)
* [QueryDatasetAggregation](~/microsoft.costmanagement/2020-06-01/exports.md#querydatasetaggregation)
* [QueryDatasetAutoGenerated](~/microsoft.costmanagement/2020-06-01/exports.md#querydatasetautogenerated)
* [QueryDatasetConfiguration](~/microsoft.costmanagement/2020-06-01/exports.md#querydatasetconfiguration)
* [QueryFilterAutoGenerated](~/microsoft.costmanagement/2020-06-01/exports.md#queryfilterautogenerated)
* [QueryGrouping](~/microsoft.costmanagement/2020-06-01/exports.md#querygrouping)
* [QueryTimePeriod](~/microsoft.costmanagement/2020-06-01/exports.md#querytimeperiod)

Updated:

* [ExportProperties](~/microsoft.costmanagement/2020-06-01/exports.md#exportproperties): Added property 'nextRunTimeEstimate'
* [ExportProperties](~/microsoft.costmanagement/2020-06-01/exports.md#exportproperties): Added property 'runHistory'


## 2019-11-01

Added:

* [ExportDefinition](~/microsoft.costmanagement/2019-11-01/exports.md#exportdefinition)
* [QueryDatasetAutoGenerated](~/microsoft.costmanagement/2019-11-01/exports.md#querydatasetautogenerated)
* [QueryFilterAutoGenerated](~/microsoft.costmanagement/2019-11-01/exports.md#queryfilterautogenerated)

Removed:

* [QueryDataset](~/microsoft.costmanagement/2019-11-01/exports.md#querydataset)
* [QueryDefinition](~/microsoft.costmanagement/2019-11-01/exports.md#querydefinition)
* [QueryFilter](~/microsoft.costmanagement/2019-11-01/exports.md#queryfilter)
* [QuerySortingConfiguration](~/microsoft.costmanagement/2019-11-01/exports.md#querysortingconfiguration)
* [ResourceTags](~/microsoft.costmanagement/2019-11-01/exports.md#resourcetags)

Updated:

* [Microsoft.CostManagement/exports](~/microsoft.costmanagement/2019-11-01/exports.md#microsoft.costmanagement/exports): Added property 'eTag'
* [Microsoft.CostManagement/exports](~/microsoft.costmanagement/2019-11-01/exports.md#microsoft.costmanagement/exports): Removed property 'tags'


## 2019-10-01

No properties added, updated or removed.

## 2019-09-01

No properties added, updated or removed.

## 2019-01-01

Oldest version tracked in change log