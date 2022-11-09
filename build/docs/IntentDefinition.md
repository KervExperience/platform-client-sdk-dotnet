---
title: IntentDefinition
---
## ININ.PureCloudApi.Model.IntentDefinition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | ID of the intent. | [optional] |
| **Name** | **string** | The name of the intent. | |
| **EntityTypeBindings** | [**List&lt;NamedEntityTypeBinding&gt;**](NamedEntityTypeBinding.html) | The bindings for the named entity types used in this intent.This field is mutually exclusive with entityNameReferences and entities | [optional] |
| **EntityNameReferences** | **List&lt;string&gt;** | The references for the named entity used in this intent.This field is mutually exclusive with entityTypeBindings | [optional] |
| **Utterances** | [**List&lt;NluUtterance&gt;**](NluUtterance.html) | The utterances that act as training phrases for the intent. | |
{: class="table table-striped"}


