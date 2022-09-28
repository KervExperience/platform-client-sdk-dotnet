---
title: WebDeploymentsApi
---
## PureCloudPlatform.Client.V2.Api.WebDeploymentsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteWebdeploymentsConfiguration**](WebDeploymentsApi.html#deletewebdeploymentsconfiguration) | **DELETE** /api/v2/webdeployments/configurations/{configurationId} | Delete all versions of a configuration |
| [**DeleteWebdeploymentsDeployment**](WebDeploymentsApi.html#deletewebdeploymentsdeployment) | **DELETE** /api/v2/webdeployments/deployments/{deploymentId} | Delete a deployment |
| [**GetWebdeploymentsConfigurationVersion**](WebDeploymentsApi.html#getwebdeploymentsconfigurationversion) | **GET** /api/v2/webdeployments/configurations/{configurationId}/versions/{versionId} | Get a configuration version |
| [**GetWebdeploymentsConfigurationVersions**](WebDeploymentsApi.html#getwebdeploymentsconfigurationversions) | **GET** /api/v2/webdeployments/configurations/{configurationId}/versions | Get the versions of a configuration |
| [**GetWebdeploymentsConfigurationVersionsDraft**](WebDeploymentsApi.html#getwebdeploymentsconfigurationversionsdraft) | **GET** /api/v2/webdeployments/configurations/{configurationId}/versions/draft | Get the configuration draft |
| [**GetWebdeploymentsConfigurations**](WebDeploymentsApi.html#getwebdeploymentsconfigurations) | **GET** /api/v2/webdeployments/configurations | View configuration drafts |
| [**GetWebdeploymentsDeployment**](WebDeploymentsApi.html#getwebdeploymentsdeployment) | **GET** /api/v2/webdeployments/deployments/{deploymentId} | Get a deployment |
| [**GetWebdeploymentsDeploymentConfigurations**](WebDeploymentsApi.html#getwebdeploymentsdeploymentconfigurations) | **GET** /api/v2/webdeployments/deployments/{deploymentId}/configurations | Get active configuration for a given deployment |
| [**GetWebdeploymentsDeployments**](WebDeploymentsApi.html#getwebdeploymentsdeployments) | **GET** /api/v2/webdeployments/deployments | Get deployments |
| [**PostWebdeploymentsConfigurationVersionsDraftPublish**](WebDeploymentsApi.html#postwebdeploymentsconfigurationversionsdraftpublish) | **POST** /api/v2/webdeployments/configurations/{configurationId}/versions/draft/publish | Publish the configuration draft and create a new version |
| [**PostWebdeploymentsConfigurations**](WebDeploymentsApi.html#postwebdeploymentsconfigurations) | **POST** /api/v2/webdeployments/configurations | Create a configuration draft |
| [**PostWebdeploymentsDeployments**](WebDeploymentsApi.html#postwebdeploymentsdeployments) | **POST** /api/v2/webdeployments/deployments | Create a deployment |
| [**PutWebdeploymentsConfigurationVersionsDraft**](WebDeploymentsApi.html#putwebdeploymentsconfigurationversionsdraft) | **PUT** /api/v2/webdeployments/configurations/{configurationId}/versions/draft | Update the configuration draft |
| [**PutWebdeploymentsDeployment**](WebDeploymentsApi.html#putwebdeploymentsdeployment) | **PUT** /api/v2/webdeployments/deployments/{deploymentId} | Update a deployment |
{: class="table table-striped"}

<a name="deletewebdeploymentsconfiguration"></a>

## void DeleteWebdeploymentsConfiguration (string configurationId)



Delete all versions of a configuration



Requires ALL permissions: 

* webDeployments:configuration:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWebdeploymentsConfigurationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var configurationId = configurationId_example;  // string | The configuration version ID

            try
            { 
                // Delete all versions of a configuration
                apiInstance.DeleteWebdeploymentsConfiguration(configurationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.DeleteWebdeploymentsConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **configurationId** | **string**| The configuration version ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletewebdeploymentsdeployment"></a>

## void DeleteWebdeploymentsDeployment (string deploymentId)



Delete a deployment



Requires ALL permissions: 

* webDeployments:deployment:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWebdeploymentsDeploymentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var deploymentId = deploymentId_example;  // string | The deployment ID

            try
            { 
                // Delete a deployment
                apiInstance.DeleteWebdeploymentsDeployment(deploymentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.DeleteWebdeploymentsDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| The deployment ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getwebdeploymentsconfigurationversion"></a>

## [**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion.html) GetWebdeploymentsConfigurationVersion (string configurationId, string versionId)



Get a configuration version



Requires ALL permissions: 

* webDeployments:configuration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebdeploymentsConfigurationVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var configurationId = configurationId_example;  // string | The configuration version ID
            var versionId = versionId_example;  // string | The version of the configuration to get

            try
            { 
                // Get a configuration version
                WebDeploymentConfigurationVersion result = apiInstance.GetWebdeploymentsConfigurationVersion(configurationId, versionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.GetWebdeploymentsConfigurationVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **configurationId** | **string**| The configuration version ID |  |
| **versionId** | **string**| The version of the configuration to get |  |
{: class="table table-striped"}

### Return type

[**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion.html)

<a name="getwebdeploymentsconfigurationversions"></a>

## [**WebDeploymentConfigurationVersionEntityListing**](WebDeploymentConfigurationVersionEntityListing.html) GetWebdeploymentsConfigurationVersions (string configurationId)



Get the versions of a configuration

This returns the 50 most recent versions for this configuration



Requires ALL permissions: 

* webDeployments:configuration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebdeploymentsConfigurationVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var configurationId = configurationId_example;  // string | The configuration version ID

            try
            { 
                // Get the versions of a configuration
                WebDeploymentConfigurationVersionEntityListing result = apiInstance.GetWebdeploymentsConfigurationVersions(configurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.GetWebdeploymentsConfigurationVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **configurationId** | **string**| The configuration version ID |  |
{: class="table table-striped"}

### Return type

[**WebDeploymentConfigurationVersionEntityListing**](WebDeploymentConfigurationVersionEntityListing.html)

<a name="getwebdeploymentsconfigurationversionsdraft"></a>

## [**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion.html) GetWebdeploymentsConfigurationVersionsDraft (string configurationId)



Get the configuration draft



Requires ALL permissions: 

* webDeployments:configuration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebdeploymentsConfigurationVersionsDraftExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var configurationId = configurationId_example;  // string | The configuration version ID

            try
            { 
                // Get the configuration draft
                WebDeploymentConfigurationVersion result = apiInstance.GetWebdeploymentsConfigurationVersionsDraft(configurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.GetWebdeploymentsConfigurationVersionsDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **configurationId** | **string**| The configuration version ID |  |
{: class="table table-striped"}

### Return type

[**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion.html)

<a name="getwebdeploymentsconfigurations"></a>

## [**WebDeploymentConfigurationVersionEntityListing**](WebDeploymentConfigurationVersionEntityListing.html) GetWebdeploymentsConfigurations (bool? showOnlyPublished = null)



View configuration drafts



Requires ALL permissions: 

* webDeployments:configuration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebdeploymentsConfigurationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var showOnlyPublished = true;  // bool? | Get only configuration drafts with published versions (optional)  (default to false)

            try
            { 
                // View configuration drafts
                WebDeploymentConfigurationVersionEntityListing result = apiInstance.GetWebdeploymentsConfigurations(showOnlyPublished);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.GetWebdeploymentsConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **showOnlyPublished** | **bool?**| Get only configuration drafts with published versions | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**WebDeploymentConfigurationVersionEntityListing**](WebDeploymentConfigurationVersionEntityListing.html)

<a name="getwebdeploymentsdeployment"></a>

## [**WebDeployment**](WebDeployment.html) GetWebdeploymentsDeployment (string deploymentId)



Get a deployment



Requires ALL permissions: 

* webDeployments:deployment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebdeploymentsDeploymentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var deploymentId = deploymentId_example;  // string | The deployment ID

            try
            { 
                // Get a deployment
                WebDeployment result = apiInstance.GetWebdeploymentsDeployment(deploymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.GetWebdeploymentsDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| The deployment ID |  |
{: class="table table-striped"}

### Return type

[**WebDeployment**](WebDeployment.html)

<a name="getwebdeploymentsdeploymentconfigurations"></a>

## [**WebDeploymentActiveConfigurationOnDeployment**](WebDeploymentActiveConfigurationOnDeployment.html) GetWebdeploymentsDeploymentConfigurations (string deploymentId, string type = null)



Get active configuration for a given deployment



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
    public class GetWebdeploymentsDeploymentConfigurationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var deploymentId = deploymentId_example;  // string | The deployment ID
            var type = type_example;  // string | Get active configuration on a deployment (optional) 

            try
            { 
                // Get active configuration for a given deployment
                WebDeploymentActiveConfigurationOnDeployment result = apiInstance.GetWebdeploymentsDeploymentConfigurations(deploymentId, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.GetWebdeploymentsDeploymentConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| The deployment ID |  |
| **type** | **string**| Get active configuration on a deployment | [optional]  |
{: class="table table-striped"}

### Return type

[**WebDeploymentActiveConfigurationOnDeployment**](WebDeploymentActiveConfigurationOnDeployment.html)

<a name="getwebdeploymentsdeployments"></a>

## [**WebDeploymentEntityListing**](WebDeploymentEntityListing.html) GetWebdeploymentsDeployments (List<string> expand = null)



Get deployments



Requires ALL permissions: 

* webDeployments:deployment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebdeploymentsDeploymentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var expand = new List<string>(); // List<string> | The specified entity attributes will be filled. Comma separated values expected. Valid values: (optional) 

            try
            { 
                // Get deployments
                WebDeploymentEntityListing result = apiInstance.GetWebdeploymentsDeployments(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.GetWebdeploymentsDeployments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.html)| The specified entity attributes will be filled. Comma separated values expected. Valid values: | [optional] <br />**Values**: Configuration |
{: class="table table-striped"}

### Return type

[**WebDeploymentEntityListing**](WebDeploymentEntityListing.html)

<a name="postwebdeploymentsconfigurationversionsdraftpublish"></a>

## [**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion.html) PostWebdeploymentsConfigurationVersionsDraftPublish (string configurationId)



Publish the configuration draft and create a new version



Requires ALL permissions: 

* webDeployments:configuration:edit
* webDeployments:configuration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWebdeploymentsConfigurationVersionsDraftPublishExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var configurationId = configurationId_example;  // string | The configuration version ID

            try
            { 
                // Publish the configuration draft and create a new version
                WebDeploymentConfigurationVersion result = apiInstance.PostWebdeploymentsConfigurationVersionsDraftPublish(configurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.PostWebdeploymentsConfigurationVersionsDraftPublish: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **configurationId** | **string**| The configuration version ID |  |
{: class="table table-striped"}

### Return type

[**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion.html)

<a name="postwebdeploymentsconfigurations"></a>

## [**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion.html) PostWebdeploymentsConfigurations (WebDeploymentConfigurationVersion configurationVersion)



Create a configuration draft



Requires ALL permissions: 

* webDeployments:configuration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWebdeploymentsConfigurationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var configurationVersion = new WebDeploymentConfigurationVersion(); // WebDeploymentConfigurationVersion | 

            try
            { 
                // Create a configuration draft
                WebDeploymentConfigurationVersion result = apiInstance.PostWebdeploymentsConfigurations(configurationVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.PostWebdeploymentsConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **configurationVersion** | [**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion.html)|  |  |
{: class="table table-striped"}

### Return type

[**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion.html)

<a name="postwebdeploymentsdeployments"></a>

## [**WebDeployment**](WebDeployment.html) PostWebdeploymentsDeployments (WebDeployment deployment)



Create a deployment



Requires ALL permissions: 

* webDeployments:deployment:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWebdeploymentsDeploymentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var deployment = new WebDeployment(); // WebDeployment | 

            try
            { 
                // Create a deployment
                WebDeployment result = apiInstance.PostWebdeploymentsDeployments(deployment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.PostWebdeploymentsDeployments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deployment** | [**WebDeployment**](WebDeployment.html)|  |  |
{: class="table table-striped"}

### Return type

[**WebDeployment**](WebDeployment.html)

<a name="putwebdeploymentsconfigurationversionsdraft"></a>

## [**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion.html) PutWebdeploymentsConfigurationVersionsDraft (string configurationId, WebDeploymentConfigurationVersion configurationVersion)



Update the configuration draft



Requires ALL permissions: 

* webDeployments:configuration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutWebdeploymentsConfigurationVersionsDraftExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var configurationId = configurationId_example;  // string | The configuration version ID
            var configurationVersion = new WebDeploymentConfigurationVersion(); // WebDeploymentConfigurationVersion | 

            try
            { 
                // Update the configuration draft
                WebDeploymentConfigurationVersion result = apiInstance.PutWebdeploymentsConfigurationVersionsDraft(configurationId, configurationVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.PutWebdeploymentsConfigurationVersionsDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **configurationId** | **string**| The configuration version ID |  |
| **configurationVersion** | [**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion.html)|  |  |
{: class="table table-striped"}

### Return type

[**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion.html)

<a name="putwebdeploymentsdeployment"></a>

## [**WebDeployment**](WebDeployment.html) PutWebdeploymentsDeployment (string deploymentId, WebDeployment deployment)



Update a deployment



Requires ALL permissions: 

* webDeployments:deployment:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutWebdeploymentsDeploymentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var deploymentId = deploymentId_example;  // string | The deployment ID
            var deployment = new WebDeployment(); // WebDeployment | 

            try
            { 
                // Update a deployment
                WebDeployment result = apiInstance.PutWebdeploymentsDeployment(deploymentId, deployment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.PutWebdeploymentsDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| The deployment ID |  |
| **deployment** | [**WebDeployment**](WebDeployment.html)|  |  |
{: class="table table-striped"}

### Return type

[**WebDeployment**](WebDeployment.html)

