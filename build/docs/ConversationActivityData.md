---
title: ConversationActivityData
---
## ININ.PureCloudApi.Model.ConversationActivityData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Group** | **Dictionary&lt;string, string&gt;** | A mapping from grouping dimension to value | [optional] |
| **Data** | [**List&lt;ConversationActivityMetricValue&gt;**](ConversationActivityMetricValue.html) | Data for metrics | [optional] |
| **Truncated** | **bool?** | Flag for a truncated list of entities. If truncated, the first half of the list of entities will contain the oldest entities and the second half the newest entities. | [optional] |
| **Entities** | [**List&lt;ConversationActivityEntityData&gt;**](ConversationActivityEntityData.html) | Details for active entities | [optional] |
{: class="table table-striped"}


