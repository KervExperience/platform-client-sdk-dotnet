---
title: KnowledgeDocumentView
---
## ININ.PureCloudApi.Model.KnowledgeDocumentView

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DocumentVariationId** | **string** | The variation of the viewed document. | |
| **DocumentVersionId** | **string** | The version of the viewed document. | |
| **SearchId** | **string** | The search that surfaced the viewed document. | [optional] |
| **QueryType** | **string** | The type of the query that surfaced the document. | [optional] |
| **Application** | [**KnowledgeSearchClientApplication**](KnowledgeSearchClientApplication.html) | The client application from which the document was viewed. | |
| **SessionId** | **string** | The unique identifier of the knowledge session in which the document was viewed. | [optional] |
| **ConversationContext** | [**KnowledgeConversationContext**](KnowledgeConversationContext.html) | Conversation context information if the document was viewed in the context of a conversation. | [optional] |
{: class="table table-striped"}


