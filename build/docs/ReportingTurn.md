---
title: ReportingTurn
---
## ININ.PureCloudApi.Model.ReportingTurn

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UserInput** | **string** | The chosen user input associated with this reporting turn. | [optional] |
| **BotPrompts** | **List&lt;string&gt;** | The bot prompts associated with this reporting turn. | [optional] |
| **SessionId** | **string** | The bot session ID that this reporting turn is grouped under. | [optional] |
| **AskAction** | [**ReportingTurnAction**](ReportingTurnAction.html) | The bot flow &#39;ask&#39; action associated with this reporting turn (e.g. AskForIntent). | [optional] |
| **Intent** | [**ReportingTurnIntent**](ReportingTurnIntent.html) | The intent and associated slots detected during this reporting turn. | [optional] |
| **Knowledge** | [**ReportingTurnKnowledge**](ReportingTurnKnowledge.html) | The knowledge data captured during this reporting turn. | [optional] |
| **KnowledgeBaseEvents** | [**ReportingTurnKnowledgeEvents**](ReportingTurnKnowledgeEvents.html) | The knowledge data captured during this reporting turn. | [optional] |
| **DateCreated** | **DateTime?** | Timestamp indicating when the original turn was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateCompleted** | **DateTime?** | Timestamp indicating when the original turn was completed. Note: The &#39;interval&#39; query param uses this timestamp to filter the output. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **AskActionResult** | **string** | Result of the bot flow &#39;ask&#39; action. | [optional] |
| **SessionEndDetails** | [**SessionEndDetails**](SessionEndDetails.html) | The details related to end of bot flow session. | [optional] |
| **Conversation** | [**AddressableEntityRef**](AddressableEntityRef.html) | The conversation details, across potentially multiple Bot Flow sessions. | [optional] |
{: class="table table-striped"}


