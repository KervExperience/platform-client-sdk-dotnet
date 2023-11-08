---
title: AppEventResponseSession
---
## ININ.PureCloudApi.Model.AppEventResponseSession

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **DurationInSeconds** | **int?** | Indicates how long the customer has been in the app within this session. | [optional] |
| **EventCount** | **int?** | The count of all events recorded during this session. | [optional] |
| **ScreenviewCount** | **int?** | The count of all screen views recorded during this session. | [optional] |
| **Referrer** | [**Referrer**](Referrer.html) | The referrer of the first event in the app session. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **CreatedDate** | **DateTime?** | UTC timestamp of the session&#39;s first event, that is when the session starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
{: class="table table-striped"}


