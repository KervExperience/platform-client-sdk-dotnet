---
title: GenericEventAction
---
## ININ.PureCloudApi.Model.GenericEventAction

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | ID of the action. | |
| **State** | **string** | Current state of the action (e.g. qualified, succeeded, errored). | |
| **MediaType** | **string** | The media type used to deliver the action (e.g. email, webhook). | |
| **Prompt** | **string** | Prompt of the action to be displayed/sent to the visitor. | |
| **MediaAddress** | **string** | Address of the media type used to deliver the action (e.g. email address, webhook URL). | [optional] |
| **CreatedDate** | **DateTime?** | Timestamp indicating when the action was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
{: class="table table-striped"}


