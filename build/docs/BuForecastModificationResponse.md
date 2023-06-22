---
title: BuForecastModificationResponse
---
## ININ.PureCloudApi.Model.BuForecastModificationResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The type of the modification | |
| **StartIntervalIndex** | **int?** | The number of intervals past referenceStartDate representing the first interval to which this modification applies | [optional] |
| **EndIntervalIndex** | **int?** | The number of intervals past referenceStartDate representing the last interval to which this modification applies | [optional] |
| **Metric** | **string** | The metric to which this modification applies | |
| **LegacyMetric** | **string** | The legacy metric to which this modification applies if applicable | [optional] |
| **Value** | **double?** | The value of the modification | [optional] |
| **Values** | [**List&lt;WfmForecastModificationIntervalOffsetValue&gt;**](WfmForecastModificationIntervalOffsetValue.html) | The list of modification values. Only applicable for grid-type modifications | |
| **DisplayGranularity** | **string** | The client side display granularity of the modification, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H | |
| **Granularity** | **string** | The actual granularity of the modification as stored behind the scenes, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H | |
| **Enabled** | **bool?** | Whether the modification is enabled for the forecast | |
| **PlanningGroupIds** | **List&lt;string&gt;** | The IDs of the planning groups to which this forecast modification applies | |
{: class="table table-striped"}


