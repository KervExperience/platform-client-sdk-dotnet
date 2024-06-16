---
title: SpeechTextAnalyticsApi
---
## PureCloudPlatform.Client.V2.Api.SpeechTextAnalyticsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteSpeechandtextanalyticsCategory**](SpeechTextAnalyticsApi.html#deletespeechandtextanalyticscategory) | **Delete** /api/v2/speechandtextanalytics/categories/{categoryId} | Delete a Speech &amp; Text Analytics category by ID |
| [**DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId**](SpeechTextAnalyticsApi.html#deletespeechandtextanalyticsdictionaryfeedbackdictionaryfeedbackid) | **Delete** /api/v2/speechandtextanalytics/dictionaryfeedback/{dictionaryFeedbackId} | Delete a Speech &amp; Text Analytics DictionaryFeedback by Id |
| [**DeleteSpeechandtextanalyticsProgram**](SpeechTextAnalyticsApi.html#deletespeechandtextanalyticsprogram) | **Delete** /api/v2/speechandtextanalytics/programs/{programId} | Delete a Speech &amp; Text Analytics program by id |
| [**DeleteSpeechandtextanalyticsSentimentfeedback**](SpeechTextAnalyticsApi.html#deletespeechandtextanalyticssentimentfeedback) | **Delete** /api/v2/speechandtextanalytics/sentimentfeedback | Delete All Speech &amp; Text Analytics SentimentFeedback |
| [**DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackId**](SpeechTextAnalyticsApi.html#deletespeechandtextanalyticssentimentfeedbacksentimentfeedbackid) | **Delete** /api/v2/speechandtextanalytics/sentimentfeedback/{sentimentFeedbackId} | Delete a Speech &amp; Text Analytics SentimentFeedback by Id |
| [**DeleteSpeechandtextanalyticsTopic**](SpeechTextAnalyticsApi.html#deletespeechandtextanalyticstopic) | **Delete** /api/v2/speechandtextanalytics/topics/{topicId} | Delete a Speech &amp; Text Analytics topic by id |
| [**GetSpeechandtextanalyticsCategories**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticscategories) | **Get** /api/v2/speechandtextanalytics/categories | Get the list of Speech and Text Analytics categories |
| [**GetSpeechandtextanalyticsCategory**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticscategory) | **Get** /api/v2/speechandtextanalytics/categories/{categoryId} | Get a Speech &amp; Text Analytics Category by ID |
| [**GetSpeechandtextanalyticsConversation**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticsconversation) | **Get** /api/v2/speechandtextanalytics/conversations/{conversationId} | Get Speech and Text Analytics for a specific conversation |
| [**GetSpeechandtextanalyticsConversationCategories**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticsconversationcategories) | **Get** /api/v2/speechandtextanalytics/conversations/{conversationId}/categories | Get the list of detected Speech and Text Analytics categories of conversation |
| [**GetSpeechandtextanalyticsConversationCommunicationTranscripturl**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticsconversationcommunicationtranscripturl) | **Get** /api/v2/speechandtextanalytics/conversations/{conversationId}/communications/{communicationId}/transcripturl | Get the pre-signed S3 URL for the transcript of a specific communication of a conversation |
| [**GetSpeechandtextanalyticsConversationCommunicationTranscripturls**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticsconversationcommunicationtranscripturls) | **Get** /api/v2/speechandtextanalytics/conversations/{conversationId}/communications/{communicationId}/transcripturls | Get the list of pre-signed S3 URL for the transcripts of a specific communication of a conversation |
| [**GetSpeechandtextanalyticsDictionaryfeedback**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticsdictionaryfeedback) | **Get** /api/v2/speechandtextanalytics/dictionaryfeedback | Get the list of Speech &amp; Text Analytics dictionary feedbacks |
| [**GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticsdictionaryfeedbackdictionaryfeedbackid) | **Get** /api/v2/speechandtextanalytics/dictionaryfeedback/{dictionaryFeedbackId} | Get a Speech &amp; Text Analytics dictionary feedback by id |
| [**GetSpeechandtextanalyticsProgram**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticsprogram) | **Get** /api/v2/speechandtextanalytics/programs/{programId} | Get a Speech &amp; Text Analytics program by id |
| [**GetSpeechandtextanalyticsProgramMappings**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticsprogrammappings) | **Get** /api/v2/speechandtextanalytics/programs/{programId}/mappings | Get Speech &amp; Text Analytics program mappings to queues and flows by id |
| [**GetSpeechandtextanalyticsProgramTranscriptionengines**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticsprogramtranscriptionengines) | **Get** /api/v2/speechandtextanalytics/programs/{programId}/transcriptionengines | Get transcription engine settings of a program |
| [**GetSpeechandtextanalyticsPrograms**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticsprograms) | **Get** /api/v2/speechandtextanalytics/programs | Get the list of Speech &amp; Text Analytics programs |
| [**GetSpeechandtextanalyticsProgramsGeneralJob**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticsprogramsgeneraljob) | **Get** /api/v2/speechandtextanalytics/programs/general/jobs/{jobId} | Get a Speech &amp; Text Analytics general program job by id |
| [**GetSpeechandtextanalyticsProgramsMappings**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticsprogramsmappings) | **Get** /api/v2/speechandtextanalytics/programs/mappings | Get the list of Speech &amp; Text Analytics programs mappings to queues and flows |
| [**GetSpeechandtextanalyticsProgramsPublishjob**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticsprogramspublishjob) | **Get** /api/v2/speechandtextanalytics/programs/publishjobs/{jobId} | Get a Speech &amp; Text Analytics publish programs job by id |
| [**GetSpeechandtextanalyticsProgramsTranscriptionenginesDialects**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticsprogramstranscriptionenginesdialects) | **Get** /api/v2/speechandtextanalytics/programs/transcriptionengines/dialects | Get supported dialects for each transcription engine |
| [**GetSpeechandtextanalyticsProgramsUnpublished**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticsprogramsunpublished) | **Get** /api/v2/speechandtextanalytics/programs/unpublished | Get the list of Speech &amp; Text Analytics unpublished programs |
| [**GetSpeechandtextanalyticsSentimentDialects**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticssentimentdialects) | **Get** /api/v2/speechandtextanalytics/sentiment/dialects | Get the list of Speech &amp; Text Analytics sentiment supported dialects |
| [**GetSpeechandtextanalyticsSentimentfeedback**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticssentimentfeedback) | **Get** /api/v2/speechandtextanalytics/sentimentfeedback | Get the list of Speech &amp; Text Analytics SentimentFeedback |
| [**GetSpeechandtextanalyticsSettings**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticssettings) | **Get** /api/v2/speechandtextanalytics/settings | Get Speech And Text Analytics Settings |
| [**GetSpeechandtextanalyticsTopic**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticstopic) | **Get** /api/v2/speechandtextanalytics/topics/{topicId} | Get a Speech &amp; Text Analytics topic by id |
| [**GetSpeechandtextanalyticsTopics**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticstopics) | **Get** /api/v2/speechandtextanalytics/topics | Get the list of Speech &amp; Text Analytics topics |
| [**GetSpeechandtextanalyticsTopicsDialects**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticstopicsdialects) | **Get** /api/v2/speechandtextanalytics/topics/dialects | Get list of supported Speech &amp; Text Analytics topics dialects |
| [**GetSpeechandtextanalyticsTopicsGeneral**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticstopicsgeneral) | **Get** /api/v2/speechandtextanalytics/topics/general | Get the Speech &amp; Text Analytics general topics for a given dialect |
| [**GetSpeechandtextanalyticsTopicsGeneralStatus**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticstopicsgeneralstatus) | **Get** /api/v2/speechandtextanalytics/topics/general/status | Get the list of general topics from the org and the system with their current status |
| [**GetSpeechandtextanalyticsTopicsPublishjob**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticstopicspublishjob) | **Get** /api/v2/speechandtextanalytics/topics/publishjobs/{jobId} | Get a Speech &amp; Text Analytics publish topics job by id |
| [**PatchSpeechandtextanalyticsSettings**](SpeechTextAnalyticsApi.html#patchspeechandtextanalyticssettings) | **Patch** /api/v2/speechandtextanalytics/settings | Patch Speech And Text Analytics Settings |
| [**PostSpeechandtextanalyticsCategories**](SpeechTextAnalyticsApi.html#postspeechandtextanalyticscategories) | **Post** /api/v2/speechandtextanalytics/categories | Create new Speech &amp; Text Analytics category |
| [**PostSpeechandtextanalyticsDictionaryfeedback**](SpeechTextAnalyticsApi.html#postspeechandtextanalyticsdictionaryfeedback) | **Post** /api/v2/speechandtextanalytics/dictionaryfeedback | Create a Speech &amp; Text Analytics DictionaryFeedback |
| [**PostSpeechandtextanalyticsPrograms**](SpeechTextAnalyticsApi.html#postspeechandtextanalyticsprograms) | **Post** /api/v2/speechandtextanalytics/programs | Create new Speech &amp; Text Analytics program |
| [**PostSpeechandtextanalyticsProgramsGeneralJobs**](SpeechTextAnalyticsApi.html#postspeechandtextanalyticsprogramsgeneraljobs) | **Post** /api/v2/speechandtextanalytics/programs/general/jobs | Create new Speech &amp; Text Analytics general program job |
| [**PostSpeechandtextanalyticsProgramsPublishjobs**](SpeechTextAnalyticsApi.html#postspeechandtextanalyticsprogramspublishjobs) | **Post** /api/v2/speechandtextanalytics/programs/publishjobs | Create new Speech &amp; Text Analytics publish programs job |
| [**PostSpeechandtextanalyticsSentimentfeedback**](SpeechTextAnalyticsApi.html#postspeechandtextanalyticssentimentfeedback) | **Post** /api/v2/speechandtextanalytics/sentimentfeedback | Create a Speech &amp; Text Analytics SentimentFeedback |
| [**PostSpeechandtextanalyticsTopics**](SpeechTextAnalyticsApi.html#postspeechandtextanalyticstopics) | **Post** /api/v2/speechandtextanalytics/topics | Create new Speech &amp; Text Analytics topic |
| [**PostSpeechandtextanalyticsTopicsPublishjobs**](SpeechTextAnalyticsApi.html#postspeechandtextanalyticstopicspublishjobs) | **Post** /api/v2/speechandtextanalytics/topics/publishjobs | Create new Speech &amp; Text Analytics publish topics job |
| [**PostSpeechandtextanalyticsTranscriptsSearch**](SpeechTextAnalyticsApi.html#postspeechandtextanalyticstranscriptssearch) | **Post** /api/v2/speechandtextanalytics/transcripts/search | Search resources. |
| [**PutSpeechandtextanalyticsCategory**](SpeechTextAnalyticsApi.html#putspeechandtextanalyticscategory) | **Put** /api/v2/speechandtextanalytics/categories/{categoryId} | Update a Speech &amp; Text Analytics category by ID |
| [**PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId**](SpeechTextAnalyticsApi.html#putspeechandtextanalyticsdictionaryfeedbackdictionaryfeedbackid) | **Put** /api/v2/speechandtextanalytics/dictionaryfeedback/{dictionaryFeedbackId} | Update existing Speech &amp; Text Analytics dictionary feedback by id |
| [**PutSpeechandtextanalyticsProgram**](SpeechTextAnalyticsApi.html#putspeechandtextanalyticsprogram) | **Put** /api/v2/speechandtextanalytics/programs/{programId} | Update existing Speech &amp; Text Analytics program |
| [**PutSpeechandtextanalyticsProgramMappings**](SpeechTextAnalyticsApi.html#putspeechandtextanalyticsprogrammappings) | **Put** /api/v2/speechandtextanalytics/programs/{programId}/mappings | Set Speech &amp; Text Analytics program mappings to queues and flows |
| [**PutSpeechandtextanalyticsProgramTranscriptionengines**](SpeechTextAnalyticsApi.html#putspeechandtextanalyticsprogramtranscriptionengines) | **Put** /api/v2/speechandtextanalytics/programs/{programId}/transcriptionengines | Update transcription engine settings of a program |
| [**PutSpeechandtextanalyticsSettings**](SpeechTextAnalyticsApi.html#putspeechandtextanalyticssettings) | **Put** /api/v2/speechandtextanalytics/settings | Update Speech And Text Analytics Settings |
| [**PutSpeechandtextanalyticsTopic**](SpeechTextAnalyticsApi.html#putspeechandtextanalyticstopic) | **Put** /api/v2/speechandtextanalytics/topics/{topicId} | Update existing Speech &amp; Text Analytics topic |
{: class="table table-striped"}

<a name="deletespeechandtextanalyticscategory"></a>

## void DeleteSpeechandtextanalyticsCategory (string categoryId)



Delete a Speech & Text Analytics category by ID

Requires ALL permissions: 

* speechAndTextAnalytics:category:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSpeechandtextanalyticsCategoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var categoryId = categoryId_example;  // string | The id of the category

            try
            { 
                // Delete a Speech & Text Analytics category by ID
                apiInstance.DeleteSpeechandtextanalyticsCategory(categoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.DeleteSpeechandtextanalyticsCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **categoryId** | **string**| The id of the category |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletespeechandtextanalyticsdictionaryfeedbackdictionaryfeedbackid"></a>

## void DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId (string dictionaryFeedbackId)



Delete a Speech & Text Analytics DictionaryFeedback by Id

Requires ALL permissions: 

* speechAndTextAnalytics:dictionaryterm:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var dictionaryFeedbackId = dictionaryFeedbackId_example;  // string | The Id of the Dictionary Feedback

            try
            { 
                // Delete a Speech & Text Analytics DictionaryFeedback by Id
                apiInstance.DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId(dictionaryFeedbackId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dictionaryFeedbackId** | **string**| The Id of the Dictionary Feedback |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletespeechandtextanalyticsprogram"></a>

## void DeleteSpeechandtextanalyticsProgram (string programId, bool? forceDelete = null)



Delete a Speech & Text Analytics program by id

Requires ALL permissions: 

* speechAndTextAnalytics:program:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSpeechandtextanalyticsProgramExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var programId = programId_example;  // string | The id of the program
            var forceDelete = forceDelete_example;  // bool? | Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. (optional)  (default to false)

            try
            { 
                // Delete a Speech & Text Analytics program by id
                apiInstance.DeleteSpeechandtextanalyticsProgram(programId, forceDelete);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.DeleteSpeechandtextanalyticsProgram: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **programId** | **string**| The id of the program |  |
| **forceDelete** | **bool?**| Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. | [optional] [default to false]<br />**Values**: true, false |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletespeechandtextanalyticssentimentfeedback"></a>

## void DeleteSpeechandtextanalyticsSentimentfeedback ()



Delete All Speech & Text Analytics SentimentFeedback

Requires ALL permissions: 

* speechAndTextAnalytics:feedback:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSpeechandtextanalyticsSentimentfeedbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();

            try
            { 
                // Delete All Speech & Text Analytics SentimentFeedback
                apiInstance.DeleteSpeechandtextanalyticsSentimentfeedback();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.DeleteSpeechandtextanalyticsSentimentfeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

void (empty response body)

<a name="deletespeechandtextanalyticssentimentfeedbacksentimentfeedbackid"></a>

## void DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackId (string sentimentFeedbackId)



Delete a Speech & Text Analytics SentimentFeedback by Id

Requires ALL permissions: 

* speechAndTextAnalytics:feedback:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var sentimentFeedbackId = sentimentFeedbackId_example;  // string | The Id of the SentimentFeedback

            try
            { 
                // Delete a Speech & Text Analytics SentimentFeedback by Id
                apiInstance.DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackId(sentimentFeedbackId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sentimentFeedbackId** | **string**| The Id of the SentimentFeedback |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletespeechandtextanalyticstopic"></a>

## void DeleteSpeechandtextanalyticsTopic (string topicId)



Delete a Speech & Text Analytics topic by id

Requires ALL permissions: 

* speechAndTextAnalytics:topic:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSpeechandtextanalyticsTopicExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var topicId = topicId_example;  // string | The id of the topic

            try
            { 
                // Delete a Speech & Text Analytics topic by id
                apiInstance.DeleteSpeechandtextanalyticsTopic(topicId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.DeleteSpeechandtextanalyticsTopic: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| The id of the topic |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getspeechandtextanalyticscategories"></a>

## [**CategoriesEntityListing**](CategoriesEntityListing.html) GetSpeechandtextanalyticsCategories (int? pageSize = null, int? pageNumber = null, string name = null, string sortOrder = null, string sortBy = null, List<string> ids = null)



Get the list of Speech and Text Analytics categories

Requires ALL permissions: 

* speechAndTextAnalytics:category:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsCategoriesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var pageSize = 56;  // int? | The page size for the listing. The max that will be returned is 50. (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number for the listing (optional)  (default to 1)
            var name = name_example;  // string | The category name filter applied to the listing (optional) 
            var sortOrder = sortOrder_example;  // string | The sort order for the listing (optional)  (default to asc)
            var sortBy = sortBy_example;  // string | The field to sort by for the listing (optional)  (default to name)
            var ids = new List<string>(); // List<string> | Comma separated Category IDs to filter by. Cannot be used with other filters. Maximum of 50 IDs allowed. (optional) 

            try
            { 
                // Get the list of Speech and Text Analytics categories
                CategoriesEntityListing result = apiInstance.GetSpeechandtextanalyticsCategories(pageSize, pageNumber, name, sortOrder, sortBy, ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The page size for the listing. The max that will be returned is 50. | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number for the listing | [optional] [default to 1] |
| **name** | **string**| The category name filter applied to the listing | [optional]  |
| **sortOrder** | **string**| The sort order for the listing | [optional] [default to asc]<br />**Values**: asc, desc |
| **sortBy** | **string**| The field to sort by for the listing | [optional] [default to name]<br />**Values**: name, description |
| **ids** | [**List<string>**](string.html)| Comma separated Category IDs to filter by. Cannot be used with other filters. Maximum of 50 IDs allowed. | [optional]  |
{: class="table table-striped"}

### Return type

[**CategoriesEntityListing**](CategoriesEntityListing.html)

<a name="getspeechandtextanalyticscategory"></a>

## [**StaCategory**](StaCategory.html) GetSpeechandtextanalyticsCategory (string categoryId)



Get a Speech & Text Analytics Category by ID

Requires ALL permissions: 

* speechAndTextAnalytics:category:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsCategoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var categoryId = categoryId_example;  // string | The id of the category

            try
            { 
                // Get a Speech & Text Analytics Category by ID
                StaCategory result = apiInstance.GetSpeechandtextanalyticsCategory(categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **categoryId** | **string**| The id of the category |  |
{: class="table table-striped"}

### Return type

[**StaCategory**](StaCategory.html)

<a name="getspeechandtextanalyticsconversation"></a>

## [**ConversationMetrics**](ConversationMetrics.html) GetSpeechandtextanalyticsConversation (string conversationId)



Get Speech and Text Analytics for a specific conversation

Requires ALL permissions: 

* recording:recording:view
* speechAndTextAnalytics:data:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsConversationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var conversationId = conversationId_example;  // string | Conversation Id

            try
            { 
                // Get Speech and Text Analytics for a specific conversation
                ConversationMetrics result = apiInstance.GetSpeechandtextanalyticsConversation(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsConversation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation Id |  |
{: class="table table-striped"}

### Return type

[**ConversationMetrics**](ConversationMetrics.html)

<a name="getspeechandtextanalyticsconversationcategories"></a>

## [**ConversationCategoriesEntityListing**](ConversationCategoriesEntityListing.html) GetSpeechandtextanalyticsConversationCategories (string conversationId, int? pageSize = null, int? pageNumber = null)



Get the list of detected Speech and Text Analytics categories of conversation

Requires ALL permissions: 

* speechAndTextAnalytics:data:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsConversationCategoriesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var conversationId = conversationId_example;  // string | The id of the conversation
            var pageSize = 56;  // int? | The page size for the listing. The max that will be returned is 50. (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number for the listing (optional)  (default to 1)

            try
            { 
                // Get the list of detected Speech and Text Analytics categories of conversation
                ConversationCategoriesEntityListing result = apiInstance.GetSpeechandtextanalyticsConversationCategories(conversationId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsConversationCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| The id of the conversation |  |
| **pageSize** | **int?**| The page size for the listing. The max that will be returned is 50. | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number for the listing | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**ConversationCategoriesEntityListing**](ConversationCategoriesEntityListing.html)

<a name="getspeechandtextanalyticsconversationcommunicationtranscripturl"></a>

## [**TranscriptUrl**](TranscriptUrl.html) GetSpeechandtextanalyticsConversationCommunicationTranscripturl (string conversationId, string communicationId)



Get the pre-signed S3 URL for the transcript of a specific communication of a conversation

Requires ALL permissions: 

* recording:recording:view
* speechAndTextAnalytics:data:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsConversationCommunicationTranscripturlExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var communicationId = communicationId_example;  // string | Communication ID

            try
            { 
                // Get the pre-signed S3 URL for the transcript of a specific communication of a conversation
                TranscriptUrl result = apiInstance.GetSpeechandtextanalyticsConversationCommunicationTranscripturl(conversationId, communicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsConversationCommunicationTranscripturl: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **communicationId** | **string**| Communication ID |  |
{: class="table table-striped"}

### Return type

[**TranscriptUrl**](TranscriptUrl.html)

<a name="getspeechandtextanalyticsconversationcommunicationtranscripturls"></a>

## [**TranscriptUrls**](TranscriptUrls.html) GetSpeechandtextanalyticsConversationCommunicationTranscripturls (string conversationId, string communicationId)



Get the list of pre-signed S3 URL for the transcripts of a specific communication of a conversation

Requires ANY permissions: 

* recording:recording:view
* recording:recordingSegment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsConversationCommunicationTranscripturlsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var communicationId = communicationId_example;  // string | Communication ID

            try
            { 
                // Get the list of pre-signed S3 URL for the transcripts of a specific communication of a conversation
                TranscriptUrls result = apiInstance.GetSpeechandtextanalyticsConversationCommunicationTranscripturls(conversationId, communicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsConversationCommunicationTranscripturls: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **communicationId** | **string**| Communication ID |  |
{: class="table table-striped"}

### Return type

[**TranscriptUrls**](TranscriptUrls.html)

<a name="getspeechandtextanalyticsdictionaryfeedback"></a>

## [**DictionaryFeedbackEntityListing**](DictionaryFeedbackEntityListing.html) GetSpeechandtextanalyticsDictionaryfeedback (string dialect = null, string nextPage = null, int? pageSize = null)



Get the list of Speech & Text Analytics dictionary feedbacks

Requires ALL permissions: 

* speechAndTextAnalytics:dictionaryterm:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsDictionaryfeedbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var dialect = en-US;  // string | The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional) 
            var nextPage = nextPage_example;  // string | The key for listing the next page (optional) 
            var pageSize = 56;  // int? | The page size for the listing (optional)  (default to 500)

            try
            { 
                // Get the list of Speech & Text Analytics dictionary feedbacks
                DictionaryFeedbackEntityListing result = apiInstance.GetSpeechandtextanalyticsDictionaryfeedback(dialect, nextPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsDictionaryfeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dialect** | **string**| The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard | [optional]  |
| **nextPage** | **string**| The key for listing the next page | [optional]  |
| **pageSize** | **int?**| The page size for the listing | [optional] [default to 500] |
{: class="table table-striped"}

### Return type

[**DictionaryFeedbackEntityListing**](DictionaryFeedbackEntityListing.html)

<a name="getspeechandtextanalyticsdictionaryfeedbackdictionaryfeedbackid"></a>

## [**DictionaryFeedback**](DictionaryFeedback.html) GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId (string dictionaryFeedbackId)



Get a Speech & Text Analytics dictionary feedback by id

Requires ALL permissions: 

* speechAndTextAnalytics:dictionaryterm:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var dictionaryFeedbackId = dictionaryFeedbackId_example;  // string | The Id of the Dictionary Feedback

            try
            { 
                // Get a Speech & Text Analytics dictionary feedback by id
                DictionaryFeedback result = apiInstance.GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId(dictionaryFeedbackId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dictionaryFeedbackId** | **string**| The Id of the Dictionary Feedback |  |
{: class="table table-striped"}

### Return type

[**DictionaryFeedback**](DictionaryFeedback.html)

<a name="getspeechandtextanalyticsprogram"></a>

## [**Program**](Program.html) GetSpeechandtextanalyticsProgram (string programId)



Get a Speech & Text Analytics program by id

Requires ALL permissions: 

* speechAndTextAnalytics:program:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var programId = programId_example;  // string | The id of the program

            try
            { 
                // Get a Speech & Text Analytics program by id
                Program result = apiInstance.GetSpeechandtextanalyticsProgram(programId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsProgram: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **programId** | **string**| The id of the program |  |
{: class="table table-striped"}

### Return type

[**Program**](Program.html)

<a name="getspeechandtextanalyticsprogrammappings"></a>

## [**ProgramMappings**](ProgramMappings.html) GetSpeechandtextanalyticsProgramMappings (string programId)



Get Speech & Text Analytics program mappings to queues and flows by id

Requires ALL permissions: 

* speechAndTextAnalytics:program:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramMappingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var programId = programId_example;  // string | The id of the program

            try
            { 
                // Get Speech & Text Analytics program mappings to queues and flows by id
                ProgramMappings result = apiInstance.GetSpeechandtextanalyticsProgramMappings(programId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsProgramMappings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **programId** | **string**| The id of the program |  |
{: class="table table-striped"}

### Return type

[**ProgramMappings**](ProgramMappings.html)

<a name="getspeechandtextanalyticsprogramtranscriptionengines"></a>

## [**ProgramTranscriptionEngines**](ProgramTranscriptionEngines.html) GetSpeechandtextanalyticsProgramTranscriptionengines (string programId)



Get transcription engine settings of a program

Requires ALL permissions: 

* speechAndTextAnalytics:program:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramTranscriptionenginesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var programId = programId_example;  // string | The id of the program

            try
            { 
                // Get transcription engine settings of a program
                ProgramTranscriptionEngines result = apiInstance.GetSpeechandtextanalyticsProgramTranscriptionengines(programId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsProgramTranscriptionengines: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **programId** | **string**| The id of the program |  |
{: class="table table-striped"}

### Return type

[**ProgramTranscriptionEngines**](ProgramTranscriptionEngines.html)

<a name="getspeechandtextanalyticsprograms"></a>

## [**ProgramsEntityListing**](ProgramsEntityListing.html) GetSpeechandtextanalyticsPrograms (string nextPage = null, int? pageSize = null, string state = null)



Get the list of Speech & Text Analytics programs

Requires ALL permissions: 

* speechAndTextAnalytics:program:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var nextPage = nextPage_example;  // string | The key for listing the next page (optional) 
            var pageSize = 56;  // int? | The page size for the listing (optional)  (default to 20)
            var state = state_example;  // string | Program state. Defaults to Latest (optional) 

            try
            { 
                // Get the list of Speech & Text Analytics programs
                ProgramsEntityListing result = apiInstance.GetSpeechandtextanalyticsPrograms(nextPage, pageSize, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsPrograms: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **nextPage** | **string**| The key for listing the next page | [optional]  |
| **pageSize** | **int?**| The page size for the listing | [optional] [default to 20] |
| **state** | **string**| Program state. Defaults to Latest | [optional] <br />**Values**: Latest, Published |
{: class="table table-striped"}

### Return type

[**ProgramsEntityListing**](ProgramsEntityListing.html)

<a name="getspeechandtextanalyticsprogramsgeneraljob"></a>

## [**GeneralProgramJob**](GeneralProgramJob.html) GetSpeechandtextanalyticsProgramsGeneralJob (string jobId)



Get a Speech & Text Analytics general program job by id

Requires ALL permissions: 

* speechAndTextAnalytics:program:add
* speechAndTextAnalytics:program:edit
* speechAndTextAnalytics:topic:add
* speechAndTextAnalytics:topic:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramsGeneralJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var jobId = jobId_example;  // string | The id of the publish programs job

            try
            { 
                // Get a Speech & Text Analytics general program job by id
                GeneralProgramJob result = apiInstance.GetSpeechandtextanalyticsProgramsGeneralJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsProgramsGeneralJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The id of the publish programs job |  |
{: class="table table-striped"}

### Return type

[**GeneralProgramJob**](GeneralProgramJob.html)

<a name="getspeechandtextanalyticsprogramsmappings"></a>

## [**ProgramsMappingsEntityListing**](ProgramsMappingsEntityListing.html) GetSpeechandtextanalyticsProgramsMappings (string nextPage = null, int? pageSize = null)



Get the list of Speech & Text Analytics programs mappings to queues and flows

Requires ALL permissions: 

* speechAndTextAnalytics:program:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramsMappingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var nextPage = nextPage_example;  // string | The key for listing the next page (optional) 
            var pageSize = 56;  // int? | The page size for the listing (optional)  (default to 20)

            try
            { 
                // Get the list of Speech & Text Analytics programs mappings to queues and flows
                ProgramsMappingsEntityListing result = apiInstance.GetSpeechandtextanalyticsProgramsMappings(nextPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsProgramsMappings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **nextPage** | **string**| The key for listing the next page | [optional]  |
| **pageSize** | **int?**| The page size for the listing | [optional] [default to 20] |
{: class="table table-striped"}

### Return type

[**ProgramsMappingsEntityListing**](ProgramsMappingsEntityListing.html)

<a name="getspeechandtextanalyticsprogramspublishjob"></a>

## [**ProgramJob**](ProgramJob.html) GetSpeechandtextanalyticsProgramsPublishjob (string jobId)



Get a Speech & Text Analytics publish programs job by id

Requires ALL permissions: 

* speechAndTextAnalytics:program:publish

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramsPublishjobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var jobId = jobId_example;  // string | The id of the publish programs job

            try
            { 
                // Get a Speech & Text Analytics publish programs job by id
                ProgramJob result = apiInstance.GetSpeechandtextanalyticsProgramsPublishjob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsProgramsPublishjob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The id of the publish programs job |  |
{: class="table table-striped"}

### Return type

[**ProgramJob**](ProgramJob.html)

<a name="getspeechandtextanalyticsprogramstranscriptionenginesdialects"></a>

## [**SupportedDialectsEntityListing**](SupportedDialectsEntityListing.html) GetSpeechandtextanalyticsProgramsTranscriptionenginesDialects ()



Get supported dialects for each transcription engine

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramsTranscriptionenginesDialectsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();

            try
            { 
                // Get supported dialects for each transcription engine
                SupportedDialectsEntityListing result = apiInstance.GetSpeechandtextanalyticsProgramsTranscriptionenginesDialects();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsProgramsTranscriptionenginesDialects: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**SupportedDialectsEntityListing**](SupportedDialectsEntityListing.html)

<a name="getspeechandtextanalyticsprogramsunpublished"></a>

## [**UnpublishedProgramsEntityListing**](UnpublishedProgramsEntityListing.html) GetSpeechandtextanalyticsProgramsUnpublished (string nextPage = null, int? pageSize = null)



Get the list of Speech & Text Analytics unpublished programs

Requires ALL permissions: 

* speechAndTextAnalytics:program:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramsUnpublishedExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var nextPage = nextPage_example;  // string | The key for listing the next page (optional) 
            var pageSize = 56;  // int? | The page size for the listing (optional)  (default to 20)

            try
            { 
                // Get the list of Speech & Text Analytics unpublished programs
                UnpublishedProgramsEntityListing result = apiInstance.GetSpeechandtextanalyticsProgramsUnpublished(nextPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsProgramsUnpublished: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **nextPage** | **string**| The key for listing the next page | [optional]  |
| **pageSize** | **int?**| The page size for the listing | [optional] [default to 20] |
{: class="table table-striped"}

### Return type

[**UnpublishedProgramsEntityListing**](UnpublishedProgramsEntityListing.html)

<a name="getspeechandtextanalyticssentimentdialects"></a>

## [**EntityListing**](EntityListing.html) GetSpeechandtextanalyticsSentimentDialects ()



Get the list of Speech & Text Analytics sentiment supported dialects

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsSentimentDialectsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();

            try
            { 
                // Get the list of Speech & Text Analytics sentiment supported dialects
                EntityListing result = apiInstance.GetSpeechandtextanalyticsSentimentDialects();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsSentimentDialects: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**EntityListing**](EntityListing.html)

<a name="getspeechandtextanalyticssentimentfeedback"></a>

## [**SentimentFeedbackEntityListing**](SentimentFeedbackEntityListing.html) GetSpeechandtextanalyticsSentimentfeedback (string dialect = null)



Get the list of Speech & Text Analytics SentimentFeedback

Requires ALL permissions: 

* speechAndTextAnalytics:feedback:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsSentimentfeedbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var dialect = en-US;  // string | The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional) 

            try
            { 
                // Get the list of Speech & Text Analytics SentimentFeedback
                SentimentFeedbackEntityListing result = apiInstance.GetSpeechandtextanalyticsSentimentfeedback(dialect);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsSentimentfeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dialect** | **string**| The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard | [optional]  |
{: class="table table-striped"}

### Return type

[**SentimentFeedbackEntityListing**](SentimentFeedbackEntityListing.html)

<a name="getspeechandtextanalyticssettings"></a>

## [**SpeechTextAnalyticsSettingsResponse**](SpeechTextAnalyticsSettingsResponse.html) GetSpeechandtextanalyticsSettings ()



Get Speech And Text Analytics Settings

Requires ALL permissions: 

* speechAndTextAnalytics:settings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();

            try
            { 
                // Get Speech And Text Analytics Settings
                SpeechTextAnalyticsSettingsResponse result = apiInstance.GetSpeechandtextanalyticsSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**SpeechTextAnalyticsSettingsResponse**](SpeechTextAnalyticsSettingsResponse.html)

<a name="getspeechandtextanalyticstopic"></a>

## [**Topic**](Topic.html) GetSpeechandtextanalyticsTopic (string topicId)



Get a Speech & Text Analytics topic by id

Requires ALL permissions: 

* speechAndTextAnalytics:topic:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsTopicExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var topicId = topicId_example;  // string | The id of the topic

            try
            { 
                // Get a Speech & Text Analytics topic by id
                Topic result = apiInstance.GetSpeechandtextanalyticsTopic(topicId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsTopic: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| The id of the topic |  |
{: class="table table-striped"}

### Return type

[**Topic**](Topic.html)

<a name="getspeechandtextanalyticstopics"></a>

## [**TopicsEntityListing**](TopicsEntityListing.html) GetSpeechandtextanalyticsTopics (string nextPage = null, int? pageSize = null, string state = null, string name = null, List<string> ids = null, List<string> dialects = null, string sortBy = null, string sortOrder = null)



Get the list of Speech & Text Analytics topics

Requires ALL permissions: 

* speechAndTextAnalytics:topic:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsTopicsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var nextPage = nextPage_example;  // string | The key for listing the next page (optional) 
            var pageSize = 56;  // int? | The page size for the listing. The max that will be returned is 500. (optional)  (default to 20)
            var state = state_example;  // string | Topic state. Defaults to latest (optional) 
            var name = name_example;  // string | Case insensitive partial name to filter by (optional) 
            var ids = new List<string>(); // List<string> | Comma separated Topic IDs to filter by. Cannot be used with other filters. Maximum of 50 IDs allowed. (optional) 
            var dialects = new List<string>(); // List<string> | Comma separated dialect strings to filter by. Maximum of 15 dialects allowed. (optional) 
            var sortBy = sortBy_example;  // string | Sort results by. Defaults to name (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order. Defaults to asc (optional) 

            try
            { 
                // Get the list of Speech & Text Analytics topics
                TopicsEntityListing result = apiInstance.GetSpeechandtextanalyticsTopics(nextPage, pageSize, state, name, ids, dialects, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsTopics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **nextPage** | **string**| The key for listing the next page | [optional]  |
| **pageSize** | **int?**| The page size for the listing. The max that will be returned is 500. | [optional] [default to 20] |
| **state** | **string**| Topic state. Defaults to latest | [optional] <br />**Values**: latest, published |
| **name** | **string**| Case insensitive partial name to filter by | [optional]  |
| **ids** | [**List<string>**](string.html)| Comma separated Topic IDs to filter by. Cannot be used with other filters. Maximum of 50 IDs allowed. | [optional]  |
| **dialects** | [**List<string>**](string.html)| Comma separated dialect strings to filter by. Maximum of 15 dialects allowed. | [optional] <br />**Values**: en-US, es-US, en-AU, en-GB, en-ZA, es-ES, en-IN, fr-FR, fr-CA, it-IT, de-DE, pt-BR, pl-PL, pt-PT, nl-NL, ko-KR |
| **sortBy** | **string**| Sort results by. Defaults to name | [optional] <br />**Values**: name |
| **sortOrder** | **string**| Sort order. Defaults to asc | [optional] <br />**Values**: asc, desc |
{: class="table table-striped"}

### Return type

[**TopicsEntityListing**](TopicsEntityListing.html)

<a name="getspeechandtextanalyticstopicsdialects"></a>

## [**EntityListing**](EntityListing.html) GetSpeechandtextanalyticsTopicsDialects ()



Get list of supported Speech & Text Analytics topics dialects

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsTopicsDialectsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();

            try
            { 
                // Get list of supported Speech & Text Analytics topics dialects
                EntityListing result = apiInstance.GetSpeechandtextanalyticsTopicsDialects();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsTopicsDialects: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**EntityListing**](EntityListing.html)

<a name="getspeechandtextanalyticstopicsgeneral"></a>

## [**GeneralTopicsEntityListing**](GeneralTopicsEntityListing.html) GetSpeechandtextanalyticsTopicsGeneral (string dialect = null)



Get the Speech & Text Analytics general topics for a given dialect

Requires ALL permissions: 

* speechAndTextAnalytics:topic:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsTopicsGeneralExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var dialect = dialect_example;  // string | The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional) 

            try
            { 
                // Get the Speech & Text Analytics general topics for a given dialect
                GeneralTopicsEntityListing result = apiInstance.GetSpeechandtextanalyticsTopicsGeneral(dialect);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsTopicsGeneral: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dialect** | **string**| The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard | [optional] <br />**Values**: ar-001, ar-AE, ar-BH, ar-EG, ar-IL, ar-SA, ar-TN, da-DK, de-CH, de-DE, en-AU, en-GB, en-HK, en-IE, en-IN, en-NZ, en-SG, en-US, en-ZA, es-ES, es-US, fi-FI, fr-CA, fr-FR, he-IL, it-IT, ja-JP, ko-KR, nb-NO, nl-NL, pl-PL, pt-BR, pt-PT, sv-SE |
{: class="table table-striped"}

### Return type

[**GeneralTopicsEntityListing**](GeneralTopicsEntityListing.html)

<a name="getspeechandtextanalyticstopicsgeneralstatus"></a>

## [**UnifiedGeneralTopicEntityListing**](UnifiedGeneralTopicEntityListing.html) GetSpeechandtextanalyticsTopicsGeneralStatus (string dialect = null)



Get the list of general topics from the org and the system with their current status

Requires ALL permissions: 

* speechAndTextAnalytics:topic:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsTopicsGeneralStatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var dialect = dialect_example;  // string | The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional) 

            try
            { 
                // Get the list of general topics from the org and the system with their current status
                UnifiedGeneralTopicEntityListing result = apiInstance.GetSpeechandtextanalyticsTopicsGeneralStatus(dialect);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsTopicsGeneralStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dialect** | **string**| The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard | [optional] <br />**Values**: ar-001, ar-AE, ar-BH, ar-EG, ar-IL, ar-SA, ar-TN, da-DK, de-CH, de-DE, en-AU, en-GB, en-HK, en-IE, en-IN, en-NZ, en-SG, en-US, en-ZA, es-ES, es-US, fi-FI, fr-CA, fr-FR, he-IL, it-IT, ja-JP, ko-KR, nb-NO, nl-NL, pl-PL, pt-BR, pt-PT, sv-SE |
{: class="table table-striped"}

### Return type

[**UnifiedGeneralTopicEntityListing**](UnifiedGeneralTopicEntityListing.html)

<a name="getspeechandtextanalyticstopicspublishjob"></a>

## [**TopicJob**](TopicJob.html) GetSpeechandtextanalyticsTopicsPublishjob (string jobId)



Get a Speech & Text Analytics publish topics job by id

Requires ALL permissions: 

* speechAndTextAnalytics:topic:publish

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsTopicsPublishjobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var jobId = jobId_example;  // string | The id of the publish topics job

            try
            { 
                // Get a Speech & Text Analytics publish topics job by id
                TopicJob result = apiInstance.GetSpeechandtextanalyticsTopicsPublishjob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsTopicsPublishjob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The id of the publish topics job |  |
{: class="table table-striped"}

### Return type

[**TopicJob**](TopicJob.html)

<a name="patchspeechandtextanalyticssettings"></a>

## [**SpeechTextAnalyticsSettingsResponse**](SpeechTextAnalyticsSettingsResponse.html) PatchSpeechandtextanalyticsSettings (SpeechTextAnalyticsSettingsRequest body)



Patch Speech And Text Analytics Settings

Requires ALL permissions: 

* speechAndTextAnalytics:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchSpeechandtextanalyticsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new SpeechTextAnalyticsSettingsRequest(); // SpeechTextAnalyticsSettingsRequest | Speech And Text Analytics Settings

            try
            { 
                // Patch Speech And Text Analytics Settings
                SpeechTextAnalyticsSettingsResponse result = apiInstance.PatchSpeechandtextanalyticsSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PatchSpeechandtextanalyticsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SpeechTextAnalyticsSettingsRequest**](SpeechTextAnalyticsSettingsRequest.html)| Speech And Text Analytics Settings |  |
{: class="table table-striped"}

### Return type

[**SpeechTextAnalyticsSettingsResponse**](SpeechTextAnalyticsSettingsResponse.html)

<a name="postspeechandtextanalyticscategories"></a>

## [**StaCategory**](StaCategory.html) PostSpeechandtextanalyticsCategories (CategoryRequest body)



Create new Speech & Text Analytics category

Requires ALL permissions: 

* speechAndTextAnalytics:category:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsCategoriesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new CategoryRequest(); // CategoryRequest | The category to create

            try
            { 
                // Create new Speech & Text Analytics category
                StaCategory result = apiInstance.PostSpeechandtextanalyticsCategories(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CategoryRequest**](CategoryRequest.html)| The category to create |  |
{: class="table table-striped"}

### Return type

[**StaCategory**](StaCategory.html)

<a name="postspeechandtextanalyticsdictionaryfeedback"></a>

## [**DictionaryFeedback**](DictionaryFeedback.html) PostSpeechandtextanalyticsDictionaryfeedback (DictionaryFeedback body)



Create a Speech & Text Analytics DictionaryFeedback

Requires ALL permissions: 

* speechAndTextAnalytics:dictionaryterm:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsDictionaryfeedbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new DictionaryFeedback(); // DictionaryFeedback | The DictionaryFeedback to create

            try
            { 
                // Create a Speech & Text Analytics DictionaryFeedback
                DictionaryFeedback result = apiInstance.PostSpeechandtextanalyticsDictionaryfeedback(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsDictionaryfeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DictionaryFeedback**](DictionaryFeedback.html)| The DictionaryFeedback to create |  |
{: class="table table-striped"}

### Return type

[**DictionaryFeedback**](DictionaryFeedback.html)

<a name="postspeechandtextanalyticsprograms"></a>

## [**Program**](Program.html) PostSpeechandtextanalyticsPrograms (ProgramRequest body)



Create new Speech & Text Analytics program

Requires ALL permissions: 

* speechAndTextAnalytics:program:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsProgramsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new ProgramRequest(); // ProgramRequest | The program to create

            try
            { 
                // Create new Speech & Text Analytics program
                Program result = apiInstance.PostSpeechandtextanalyticsPrograms(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsPrograms: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ProgramRequest**](ProgramRequest.html)| The program to create |  |
{: class="table table-striped"}

### Return type

[**Program**](Program.html)

<a name="postspeechandtextanalyticsprogramsgeneraljobs"></a>

## [**GeneralProgramJob**](GeneralProgramJob.html) PostSpeechandtextanalyticsProgramsGeneralJobs (GeneralProgramJobRequest body)



Create new Speech & Text Analytics general program job

Requires ALL permissions: 

* speechAndTextAnalytics:program:add
* speechAndTextAnalytics:program:edit
* speechAndTextAnalytics:topic:add
* speechAndTextAnalytics:topic:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsProgramsGeneralJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new GeneralProgramJobRequest(); // GeneralProgramJobRequest | The general programs job to create

            try
            { 
                // Create new Speech & Text Analytics general program job
                GeneralProgramJob result = apiInstance.PostSpeechandtextanalyticsProgramsGeneralJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsProgramsGeneralJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GeneralProgramJobRequest**](GeneralProgramJobRequest.html)| The general programs job to create |  |
{: class="table table-striped"}

### Return type

[**GeneralProgramJob**](GeneralProgramJob.html)

<a name="postspeechandtextanalyticsprogramspublishjobs"></a>

## [**ProgramJob**](ProgramJob.html) PostSpeechandtextanalyticsProgramsPublishjobs (ProgramJobRequest body)



Create new Speech & Text Analytics publish programs job

Requires ALL permissions: 

* speechAndTextAnalytics:program:publish

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsProgramsPublishjobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new ProgramJobRequest(); // ProgramJobRequest | The publish programs job to create

            try
            { 
                // Create new Speech & Text Analytics publish programs job
                ProgramJob result = apiInstance.PostSpeechandtextanalyticsProgramsPublishjobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsProgramsPublishjobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ProgramJobRequest**](ProgramJobRequest.html)| The publish programs job to create |  |
{: class="table table-striped"}

### Return type

[**ProgramJob**](ProgramJob.html)

<a name="postspeechandtextanalyticssentimentfeedback"></a>

## [**SentimentFeedback**](SentimentFeedback.html) PostSpeechandtextanalyticsSentimentfeedback (SentimentFeedback body)



Create a Speech & Text Analytics SentimentFeedback

Requires ALL permissions: 

* speechAndTextAnalytics:feedback:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsSentimentfeedbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new SentimentFeedback(); // SentimentFeedback | The SentimentFeedback to create

            try
            { 
                // Create a Speech & Text Analytics SentimentFeedback
                SentimentFeedback result = apiInstance.PostSpeechandtextanalyticsSentimentfeedback(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsSentimentfeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SentimentFeedback**](SentimentFeedback.html)| The SentimentFeedback to create |  |
{: class="table table-striped"}

### Return type

[**SentimentFeedback**](SentimentFeedback.html)

<a name="postspeechandtextanalyticstopics"></a>

## [**Topic**](Topic.html) PostSpeechandtextanalyticsTopics (TopicRequest body)



Create new Speech & Text Analytics topic

Requires ALL permissions: 

* speechAndTextAnalytics:topic:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsTopicsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new TopicRequest(); // TopicRequest | The topic to create

            try
            { 
                // Create new Speech & Text Analytics topic
                Topic result = apiInstance.PostSpeechandtextanalyticsTopics(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsTopics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TopicRequest**](TopicRequest.html)| The topic to create |  |
{: class="table table-striped"}

### Return type

[**Topic**](Topic.html)

<a name="postspeechandtextanalyticstopicspublishjobs"></a>

## [**TopicJob**](TopicJob.html) PostSpeechandtextanalyticsTopicsPublishjobs (TopicJobRequest body)



Create new Speech & Text Analytics publish topics job

Requires ALL permissions: 

* speechAndTextAnalytics:topic:publish

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsTopicsPublishjobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new TopicJobRequest(); // TopicJobRequest | The publish topics job to create

            try
            { 
                // Create new Speech & Text Analytics publish topics job
                TopicJob result = apiInstance.PostSpeechandtextanalyticsTopicsPublishjobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsTopicsPublishjobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TopicJobRequest**](TopicJobRequest.html)| The publish topics job to create |  |
{: class="table table-striped"}

### Return type

[**TopicJob**](TopicJob.html)

<a name="postspeechandtextanalyticstranscriptssearch"></a>

## [**JsonSearchResponse**](JsonSearchResponse.html) PostSpeechandtextanalyticsTranscriptsSearch (TranscriptSearchRequest body)



Search resources.

Requires ANY permissions: 

* analytics:conversationDetail:view
* recording:recording:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsTranscriptsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new TranscriptSearchRequest(); // TranscriptSearchRequest | Search request options

            try
            { 
                // Search resources.
                JsonSearchResponse result = apiInstance.PostSpeechandtextanalyticsTranscriptsSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsTranscriptsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TranscriptSearchRequest**](TranscriptSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**JsonSearchResponse**](JsonSearchResponse.html)

<a name="putspeechandtextanalyticscategory"></a>

## [**StaCategory**](StaCategory.html) PutSpeechandtextanalyticsCategory (string categoryId, CategoryRequest body)



Update a Speech & Text Analytics category by ID

Requires ALL permissions: 

* speechAndTextAnalytics:category:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSpeechandtextanalyticsCategoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var categoryId = categoryId_example;  // string | The id of the category
            var body = new CategoryRequest(); // CategoryRequest | The updated category

            try
            { 
                // Update a Speech & Text Analytics category by ID
                StaCategory result = apiInstance.PutSpeechandtextanalyticsCategory(categoryId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PutSpeechandtextanalyticsCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **categoryId** | **string**| The id of the category |  |
| **body** | [**CategoryRequest**](CategoryRequest.html)| The updated category |  |
{: class="table table-striped"}

### Return type

[**StaCategory**](StaCategory.html)

<a name="putspeechandtextanalyticsdictionaryfeedbackdictionaryfeedbackid"></a>

## [**DictionaryFeedback**](DictionaryFeedback.html) PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId (string dictionaryFeedbackId, DictionaryFeedback body = null)



Update existing Speech & Text Analytics dictionary feedback by id

Requires ALL permissions: 

* speechAndTextAnalytics:dictionaryterm:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var dictionaryFeedbackId = dictionaryFeedbackId_example;  // string | The Id of the Dictionary Feedback
            var body = new DictionaryFeedback(); // DictionaryFeedback |  (optional) 

            try
            { 
                // Update existing Speech & Text Analytics dictionary feedback by id
                DictionaryFeedback result = apiInstance.PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId(dictionaryFeedbackId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dictionaryFeedbackId** | **string**| The Id of the Dictionary Feedback |  |
| **body** | [**DictionaryFeedback**](DictionaryFeedback.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DictionaryFeedback**](DictionaryFeedback.html)

<a name="putspeechandtextanalyticsprogram"></a>

## [**Program**](Program.html) PutSpeechandtextanalyticsProgram (string programId, ProgramRequest body)



Update existing Speech & Text Analytics program

Requires ALL permissions: 

* speechAndTextAnalytics:program:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSpeechandtextanalyticsProgramExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var programId = programId_example;  // string | The id of the program
            var body = new ProgramRequest(); // ProgramRequest | The program to update

            try
            { 
                // Update existing Speech & Text Analytics program
                Program result = apiInstance.PutSpeechandtextanalyticsProgram(programId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PutSpeechandtextanalyticsProgram: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **programId** | **string**| The id of the program |  |
| **body** | [**ProgramRequest**](ProgramRequest.html)| The program to update |  |
{: class="table table-striped"}

### Return type

[**Program**](Program.html)

<a name="putspeechandtextanalyticsprogrammappings"></a>

## [**ProgramMappings**](ProgramMappings.html) PutSpeechandtextanalyticsProgramMappings (string programId, ProgramMappingsRequest body)



Set Speech & Text Analytics program mappings to queues and flows

Requires ALL permissions: 

* speechAndTextAnalytics:program:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSpeechandtextanalyticsProgramMappingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var programId = programId_example;  // string | The id of the program
            var body = new ProgramMappingsRequest(); // ProgramMappingsRequest | The program to set mappings for

            try
            { 
                // Set Speech & Text Analytics program mappings to queues and flows
                ProgramMappings result = apiInstance.PutSpeechandtextanalyticsProgramMappings(programId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PutSpeechandtextanalyticsProgramMappings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **programId** | **string**| The id of the program |  |
| **body** | [**ProgramMappingsRequest**](ProgramMappingsRequest.html)| The program to set mappings for |  |
{: class="table table-striped"}

### Return type

[**ProgramMappings**](ProgramMappings.html)

<a name="putspeechandtextanalyticsprogramtranscriptionengines"></a>

## [**ProgramTranscriptionEngines**](ProgramTranscriptionEngines.html) PutSpeechandtextanalyticsProgramTranscriptionengines (string programId, TranscriptionEnginesRequest body)



Update transcription engine settings of a program

Requires ALL permissions: 

* speechAndTextAnalytics:program:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSpeechandtextanalyticsProgramTranscriptionenginesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var programId = programId_example;  // string | The id of the program
            var body = new TranscriptionEnginesRequest(); // TranscriptionEnginesRequest | Program transcription engine setting

            try
            { 
                // Update transcription engine settings of a program
                ProgramTranscriptionEngines result = apiInstance.PutSpeechandtextanalyticsProgramTranscriptionengines(programId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PutSpeechandtextanalyticsProgramTranscriptionengines: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **programId** | **string**| The id of the program |  |
| **body** | [**TranscriptionEnginesRequest**](TranscriptionEnginesRequest.html)| Program transcription engine setting |  |
{: class="table table-striped"}

### Return type

[**ProgramTranscriptionEngines**](ProgramTranscriptionEngines.html)

<a name="putspeechandtextanalyticssettings"></a>

## [**SpeechTextAnalyticsSettingsResponse**](SpeechTextAnalyticsSettingsResponse.html) PutSpeechandtextanalyticsSettings (SpeechTextAnalyticsSettingsRequest body)



Update Speech And Text Analytics Settings

Requires ALL permissions: 

* speechAndTextAnalytics:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSpeechandtextanalyticsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new SpeechTextAnalyticsSettingsRequest(); // SpeechTextAnalyticsSettingsRequest | Speech And Text Analytics Settings

            try
            { 
                // Update Speech And Text Analytics Settings
                SpeechTextAnalyticsSettingsResponse result = apiInstance.PutSpeechandtextanalyticsSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PutSpeechandtextanalyticsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SpeechTextAnalyticsSettingsRequest**](SpeechTextAnalyticsSettingsRequest.html)| Speech And Text Analytics Settings |  |
{: class="table table-striped"}

### Return type

[**SpeechTextAnalyticsSettingsResponse**](SpeechTextAnalyticsSettingsResponse.html)

<a name="putspeechandtextanalyticstopic"></a>

## [**Topic**](Topic.html) PutSpeechandtextanalyticsTopic (string topicId, TopicRequest body)



Update existing Speech & Text Analytics topic

Requires ALL permissions: 

* speechAndTextAnalytics:topic:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSpeechandtextanalyticsTopicExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var topicId = topicId_example;  // string | The id of the topic
            var body = new TopicRequest(); // TopicRequest | The topic to update

            try
            { 
                // Update existing Speech & Text Analytics topic
                Topic result = apiInstance.PutSpeechandtextanalyticsTopic(topicId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PutSpeechandtextanalyticsTopic: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| The id of the topic |  |
| **body** | [**TopicRequest**](TopicRequest.html)| The topic to update |  |
{: class="table table-striped"}

### Return type

[**Topic**](Topic.html)

