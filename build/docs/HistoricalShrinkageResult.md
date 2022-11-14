---
title: HistoricalShrinkageResult
---
## ININ.PureCloudApi.Model.HistoricalShrinkageResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **DateTime?** | Beginning of the date range that was queried, in ISO-8601 format | [optional] |
| **EndDate** | **DateTime?** | End of the date range that was queried, in ISO-8601 format. If it was not set, end date will be set to the queried time | [optional] |
| **TotalScheduledDurationSeconds** | **int?** | Total duration in seconds for which agents in the management unit are scheduled | [optional] |
| **TotalLoggedInDurationSeconds** | **int?** | Total duration in seconds for which agents in the management unit are actually logged-in | [optional] |
| **AggregatedShrinkage** | [**HistoricalShrinkageAggregateResponse**](HistoricalShrinkageAggregateResponse.html) | Aggregated shrinkage data for all the activity categories | [optional] |
| **ShrinkageForActivityCategories** | [**List&lt;HistoricalShrinkageActivityCategoryResponse&gt;**](HistoricalShrinkageActivityCategoryResponse.html) | Shrinkage for activity categories | [optional] |
{: class="table table-striped"}


