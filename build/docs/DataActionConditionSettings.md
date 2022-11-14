---
title: DataActionConditionSettings
---
## ININ.PureCloudApi.Model.DataActionConditionSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DataActionId** | **string** | The Data Action Id to use for this condition. | |
| **ContactIdField** | **string** | The input field from the data action that the contactId will be passed into. | |
| **DataNotFoundResolution** | **bool?** | The result of this condition if the data action returns a result indicating there was no data. | |
| **Predicates** | [**List&lt;DigitalDataActionConditionPredicate&gt;**](DigitalDataActionConditionPredicate.html) | A list of predicates defining the comparisons to use for this condition. | [optional] |
| **ContactColumnToDataActionFieldMappings** | [**List&lt;DataActionContactColumnFieldMapping&gt;**](DataActionContactColumnFieldMapping.html) | A list of mappings defining which contact data fields will be passed to which data action input fields. | [optional] |
{: class="table table-striped"}


