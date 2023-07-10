---
title: LanguagesApi
---
## PureCloudPlatform.Client.V2.Api.LanguagesApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteLanguage**](LanguagesApi.html#deletelanguage) | **Delete** /api/v2/languages/{languageId} | Delete Language (Deprecated) |
| [**GetLanguage**](LanguagesApi.html#getlanguage) | **Get** /api/v2/languages/{languageId} | Get Language (Deprecated) |
| [**GetLanguages**](LanguagesApi.html#getlanguages) | **Get** /api/v2/languages | Get the list of supported languages. (Deprecated) |
| [**GetLanguagesTranslations**](LanguagesApi.html#getlanguagestranslations) | **Get** /api/v2/languages/translations | Get all available languages for translation |
| [**GetLanguagesTranslationsBuiltin**](LanguagesApi.html#getlanguagestranslationsbuiltin) | **Get** /api/v2/languages/translations/builtin | Get the builtin translation for a language |
| [**GetLanguagesTranslationsOrganization**](LanguagesApi.html#getlanguagestranslationsorganization) | **Get** /api/v2/languages/translations/organization | Get effective translation for an organization by language |
| [**GetLanguagesTranslationsUser**](LanguagesApi.html#getlanguagestranslationsuser) | **Get** /api/v2/languages/translations/users/{userId} | Get effective language translation for a user |
| [**PostLanguages**](LanguagesApi.html#postlanguages) | **Post** /api/v2/languages | Create Language (Deprecated) |
{: class="table table-striped"}

<a name="deletelanguage"></a>

## void DeleteLanguage (string languageId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Delete Language (Deprecated)

This endpoint is deprecated. Please see the Routing API (DELETE /api/v2/routing/languages/{languageId})

Requires ANY permissions: 

* routing:skill:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteLanguageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguagesApi();
            var languageId = languageId_example;  // string | Language ID

            try
            { 
                // Delete Language (Deprecated)
                apiInstance.DeleteLanguage(languageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.DeleteLanguage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **languageId** | **string**| Language ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getlanguage"></a>

## [**Language**](Language.html) GetLanguage (string languageId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get Language (Deprecated)

This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages/{languageId})

Requires ANY permissions: 

* routing:skill:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLanguageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguagesApi();
            var languageId = languageId_example;  // string | Language ID

            try
            { 
                // Get Language (Deprecated)
                Language result = apiInstance.GetLanguage(languageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.GetLanguage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **languageId** | **string**| Language ID |  |
{: class="table table-striped"}

### Return type

[**Language**](Language.html)

<a name="getlanguages"></a>

## [**LanguageEntityListing**](LanguageEntityListing.html) GetLanguages (int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get the list of supported languages. (Deprecated)

This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages)

Requires ANY permissions: 

* routing:skill:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLanguagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguagesApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)
            var name = name_example;  // string | Name (optional) 

            try
            { 
                // Get the list of supported languages. (Deprecated)
                LanguageEntityListing result = apiInstance.GetLanguages(pageSize, pageNumber, sortOrder, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.GetLanguages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |
| **name** | **string**| Name | [optional]  |
{: class="table table-striped"}

### Return type

[**LanguageEntityListing**](LanguageEntityListing.html)

<a name="getlanguagestranslations"></a>

## [**AvailableTranslations**](AvailableTranslations.html) GetLanguagesTranslations ()



Get all available languages for translation

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
    public class GetLanguagesTranslationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguagesApi();

            try
            { 
                // Get all available languages for translation
                AvailableTranslations result = apiInstance.GetLanguagesTranslations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.GetLanguagesTranslations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**AvailableTranslations**](AvailableTranslations.html)

<a name="getlanguagestranslationsbuiltin"></a>

## **Dictionary&lt;string, Object&gt;** GetLanguagesTranslationsBuiltin (string language)



Get the builtin translation for a language

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
    public class GetLanguagesTranslationsBuiltinExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguagesApi();
            var language = language_example;  // string | The language of the builtin translation to retrieve

            try
            { 
                // Get the builtin translation for a language
                Dictionary<string, Object> result = apiInstance.GetLanguagesTranslationsBuiltin(language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.GetLanguagesTranslationsBuiltin: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **language** | **string**| The language of the builtin translation to retrieve |  |
{: class="table table-striped"}

### Return type

**Dictionary<string, Object>**

<a name="getlanguagestranslationsorganization"></a>

## **Dictionary&lt;string, Object&gt;** GetLanguagesTranslationsOrganization (string language)



Get effective translation for an organization by language

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
    public class GetLanguagesTranslationsOrganizationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguagesApi();
            var language = language_example;  // string | The language of the translation to retrieve for the organization

            try
            { 
                // Get effective translation for an organization by language
                Dictionary<string, Object> result = apiInstance.GetLanguagesTranslationsOrganization(language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.GetLanguagesTranslationsOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **language** | **string**| The language of the translation to retrieve for the organization |  |
{: class="table table-striped"}

### Return type

**Dictionary<string, Object>**

<a name="getlanguagestranslationsuser"></a>

## **Dictionary&lt;string, Object&gt;** GetLanguagesTranslationsUser (string userId)



Get effective language translation for a user

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
    public class GetLanguagesTranslationsUserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguagesApi();
            var userId = userId_example;  // string | The user id

            try
            { 
                // Get effective language translation for a user
                Dictionary<string, Object> result = apiInstance.GetLanguagesTranslationsUser(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.GetLanguagesTranslationsUser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| The user id |  |
{: class="table table-striped"}

### Return type

**Dictionary<string, Object>**

<a name="postlanguages"></a>

## [**Language**](Language.html) PostLanguages (Language body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Create Language (Deprecated)

This endpoint is deprecated. Please see the Routing API. (POST /api/v2/routing/languages

Requires ANY permissions: 

* routing:skill:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLanguagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguagesApi();
            var body = new Language(); // Language | Language

            try
            { 
                // Create Language (Deprecated)
                Language result = apiInstance.PostLanguages(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.PostLanguages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Language**](Language.html)| Language |  |
{: class="table table-striped"}

### Return type

[**Language**](Language.html)

