---
title: GroupsApi
---
## PureCloudPlatform.Client.V2.Api.GroupsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteGroup**](GroupsApi.html#deletegroup) | **Delete** /api/v2/groups/{groupId} | Delete group |
| [**DeleteGroupDynamicsettings**](GroupsApi.html#deletegroupdynamicsettings) | **Delete** /api/v2/groups/{groupId}/dynamicsettings | Remove dynamic group definition |
| [**DeleteGroupMembers**](GroupsApi.html#deletegroupmembers) | **Delete** /api/v2/groups/{groupId}/members | Remove members |
| [**GetFieldconfig**](GroupsApi.html#getfieldconfig) | **Get** /api/v2/fieldconfig | Fetch field config for an entity type |
| [**GetGroup**](GroupsApi.html#getgroup) | **Get** /api/v2/groups/{groupId} | Get group |
| [**GetGroupDynamicsettings**](GroupsApi.html#getgroupdynamicsettings) | **Get** /api/v2/groups/{groupId}/dynamicsettings | Get dynamic group definition |
| [**GetGroupIndividuals**](GroupsApi.html#getgroupindividuals) | **Get** /api/v2/groups/{groupId}/individuals | Get all individuals associated with the group |
| [**GetGroupMembers**](GroupsApi.html#getgroupmembers) | **Get** /api/v2/groups/{groupId}/members | Get group members, includes individuals, owners, and dynamically included people |
| [**GetGroupProfile**](GroupsApi.html#getgroupprofile) | **Get** /api/v2/groups/{groupId}/profile | Get group profile |
| [**GetGroups**](GroupsApi.html#getgroups) | **Get** /api/v2/groups | Get a group list |
| [**GetGroupsSearch**](GroupsApi.html#getgroupssearch) | **Get** /api/v2/groups/search | Search groups using the q64 value returned from a previous search |
| [**GetProfilesGroups**](GroupsApi.html#getprofilesgroups) | **Get** /api/v2/profiles/groups | Get group profile listing |
| [**PostGroupMembers**](GroupsApi.html#postgroupmembers) | **Post** /api/v2/groups/{groupId}/members | Add members |
| [**PostGroups**](GroupsApi.html#postgroups) | **Post** /api/v2/groups | Create a group |
| [**PostGroupsDynamicsettingsPreview**](GroupsApi.html#postgroupsdynamicsettingspreview) | **Post** /api/v2/groups/dynamicsettings/preview | Preview the number of users selected for a dynamic group definition query |
| [**PostGroupsSearch**](GroupsApi.html#postgroupssearch) | **Post** /api/v2/groups/search | Search groups |
| [**PutGroup**](GroupsApi.html#putgroup) | **Put** /api/v2/groups/{groupId} | Update group |
| [**PutGroupDynamicsettings**](GroupsApi.html#putgroupdynamicsettings) | **Put** /api/v2/groups/{groupId}/dynamicsettings | Create / Update dynamic group definition |
{: class="table table-striped"}

<a name="deletegroup"></a>

## void DeleteGroup (string groupId)



Delete group

Requires ANY permissions: 

* directory:group:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteGroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID

            try
            { 
                // Delete group
                apiInstance.DeleteGroup(groupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletegroupdynamicsettings"></a>

## void DeleteGroupDynamicsettings (string groupId)



Remove dynamic group definition

DeleteGroupDynamicsettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* directory:group:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteGroupDynamicsettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID

            try
            { 
                // Remove dynamic group definition
                apiInstance.DeleteGroupDynamicsettings(groupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroupDynamicsettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletegroupmembers"></a>

## **Object** DeleteGroupMembers (string groupId, string ids)



Remove members

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
    public class DeleteGroupMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID
            var ids = ids_example;  // string | Comma separated list of userIds to remove

            try
            { 
                // Remove members
                Object result = apiInstance.DeleteGroupMembers(groupId, ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroupMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **ids** | **string**| Comma separated list of userIds to remove |  |
{: class="table table-striped"}

### Return type

**Object**

<a name="getfieldconfig"></a>

## [**FieldConfig**](FieldConfig.html) GetFieldconfig (string type)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Fetch field config for an entity type

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
    public class GetFieldconfigExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var type = type_example;  // string | Field type

            try
            { 
                // Fetch field config for an entity type
                FieldConfig result = apiInstance.GetFieldconfig(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetFieldconfig: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | **string**| Field type | <br />**Values**: person, group, org |
{: class="table table-striped"}

### Return type

[**FieldConfig**](FieldConfig.html)

<a name="getgroup"></a>

## [**Group**](Group.html) GetGroup (string groupId)



Get group

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
    public class GetGroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID

            try
            { 
                // Get group
                Group result = apiInstance.GetGroup(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
{: class="table table-striped"}

### Return type

[**Group**](Group.html)

<a name="getgroupdynamicsettings"></a>

## [**DynamicGroupDefinition**](DynamicGroupDefinition.html) GetGroupDynamicsettings (string groupId)



Get dynamic group definition

GetGroupDynamicsettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* directory:group:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGroupDynamicsettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID

            try
            { 
                // Get dynamic group definition
                DynamicGroupDefinition result = apiInstance.GetGroupDynamicsettings(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupDynamicsettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
{: class="table table-striped"}

### Return type

[**DynamicGroupDefinition**](DynamicGroupDefinition.html)

<a name="getgroupindividuals"></a>

## [**UserEntityListing**](UserEntityListing.html) GetGroupIndividuals (string groupId)



Get all individuals associated with the group

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
    public class GetGroupIndividualsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID

            try
            { 
                // Get all individuals associated with the group
                UserEntityListing result = apiInstance.GetGroupIndividuals(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupIndividuals: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
{: class="table table-striped"}

### Return type

[**UserEntityListing**](UserEntityListing.html)

<a name="getgroupmembers"></a>

## [**UserEntityListing**](UserEntityListing.html) GetGroupMembers (string groupId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)



Get group members, includes individuals, owners, and dynamically included people

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
    public class GetGroupMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get group members, includes individuals, owners, and dynamically included people
                UserEntityListing result = apiInstance.GetGroupMembers(groupId, pageSize, pageNumber, sortOrder, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, integrationPresence, conversationSummary, outOfOffice, geolocation, station, authorization, lasttokenissued, authorization.unusedRoles, team, workPlanBidRanks, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography, dateLastLogin |
{: class="table table-striped"}

### Return type

[**UserEntityListing**](UserEntityListing.html)

<a name="getgroupprofile"></a>

## [**GroupProfile**](GroupProfile.html) GetGroupProfile (string groupId, string fields = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get group profile

This api is deprecated. Use /api/v2/groups instead

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
    public class GetGroupProfileExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | groupId
            var fields = fields_example;  // string | Comma separated fields to return.  Allowable values can be found by querying /api/v2/fieldconfig?type=group and using the key for the elements returned by the fieldList (optional) 

            try
            { 
                // Get group profile
                GroupProfile result = apiInstance.GetGroupProfile(groupId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| groupId |  |
| **fields** | **string**| Comma separated fields to return.  Allowable values can be found by querying /api/v2/fieldconfig?type&#x3D;group and using the key for the elements returned by the fieldList | [optional]  |
{: class="table table-striped"}

### Return type

[**GroupProfile**](GroupProfile.html)

<a name="getgroups"></a>

## [**GroupEntityListing**](GroupEntityListing.html) GetGroups (int? pageSize = null, int? pageNumber = null, List<string> id = null, List<string> jabberId = null, string sortOrder = null)



Get a group list

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
    public class GetGroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var id = new List<string>(); // List<string> | id (optional) 
            var jabberId = new List<string>(); // List<string> | A list of jabberIds to fetch by bulk (cannot be used with the \"id\" parameter) (optional) 
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)

            try
            { 
                // Get a group list
                GroupEntityListing result = apiInstance.GetGroups(pageSize, pageNumber, id, jabberId, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroups: " + e.Message );
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
| **id** | [**List<string>**](string.html)| id | [optional]  |
| **jabberId** | [**List<string>**](string.html)| A list of jabberIds to fetch by bulk (cannot be used with the \&quot;id\&quot; parameter) | [optional]  |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**GroupEntityListing**](GroupEntityListing.html)

<a name="getgroupssearch"></a>

## [**GroupsSearchResponse**](GroupsSearchResponse.html) GetGroupsSearch (string q64, List<string> expand = null)



Search groups using the q64 value returned from a previous search

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
    public class GetGroupsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | expand (optional) 

            try
            { 
                // Search groups using the q64 value returned from a previous search
                GroupsSearchResponse result = apiInstance.GetGroupsSearch(q64, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string.html)| expand | [optional]  |
{: class="table table-striped"}

### Return type

[**GroupsSearchResponse**](GroupsSearchResponse.html)

<a name="getprofilesgroups"></a>

## [**GroupProfileEntityListing**](GroupProfileEntityListing.html) GetProfilesGroups (int? pageSize = null, int? pageNumber = null, List<string> id = null, List<string> jabberId = null, string sortOrder = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get group profile listing

This api is deprecated. Use /api/v2/groups instead.

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
    public class GetProfilesGroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var id = new List<string>(); // List<string> | id (optional) 
            var jabberId = new List<string>(); // List<string> | A list of jabberIds to fetch by bulk (cannot be used with the \"id\" parameter) (optional) 
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)

            try
            { 
                // Get group profile listing
                GroupProfileEntityListing result = apiInstance.GetProfilesGroups(pageSize, pageNumber, id, jabberId, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetProfilesGroups: " + e.Message );
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
| **id** | [**List<string>**](string.html)| id | [optional]  |
| **jabberId** | [**List<string>**](string.html)| A list of jabberIds to fetch by bulk (cannot be used with the \&quot;id\&quot; parameter) | [optional]  |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**GroupProfileEntityListing**](GroupProfileEntityListing.html)

<a name="postgroupmembers"></a>

## **Object** PostGroupMembers (string groupId, GroupMembersUpdate body)



Add members

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
    public class PostGroupMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID
            var body = new GroupMembersUpdate(); // GroupMembersUpdate | Add members

            try
            { 
                // Add members
                Object result = apiInstance.PostGroupMembers(groupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostGroupMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **body** | [**GroupMembersUpdate**](GroupMembersUpdate.html)| Add members |  |
{: class="table table-striped"}

### Return type

**Object**

<a name="postgroups"></a>

## [**Group**](Group.html) PostGroups (GroupCreate body)



Create a group

Requires ANY permissions: 

* directory:group:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var body = new GroupCreate(); // GroupCreate | Group

            try
            { 
                // Create a group
                Group result = apiInstance.PostGroups(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GroupCreate**](GroupCreate.html)| Group |  |
{: class="table table-striped"}

### Return type

[**Group**](Group.html)

<a name="postgroupsdynamicsettingspreview"></a>

## [**DynamicGroupQueryPreview**](DynamicGroupQueryPreview.html) PostGroupsDynamicsettingsPreview (DynamicGroupQuery body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Preview the number of users selected for a dynamic group definition query

PostGroupsDynamicsettingsPreview is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* directory:group:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGroupsDynamicsettingsPreviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var body = new DynamicGroupQuery(); // DynamicGroupQuery | Group query to preview

            try
            { 
                // Preview the number of users selected for a dynamic group definition query
                DynamicGroupQueryPreview result = apiInstance.PostGroupsDynamicsettingsPreview(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostGroupsDynamicsettingsPreview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DynamicGroupQuery**](DynamicGroupQuery.html)| Group query to preview |  |
{: class="table table-striped"}

### Return type

[**DynamicGroupQueryPreview**](DynamicGroupQueryPreview.html)

<a name="postgroupssearch"></a>

## [**GroupsSearchResponse**](GroupsSearchResponse.html) PostGroupsSearch (GroupSearchRequest body)



Search groups

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
    public class PostGroupsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var body = new GroupSearchRequest(); // GroupSearchRequest | Search request options

            try
            { 
                // Search groups
                GroupsSearchResponse result = apiInstance.PostGroupsSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostGroupsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GroupSearchRequest**](GroupSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**GroupsSearchResponse**](GroupsSearchResponse.html)

<a name="putgroup"></a>

## [**Group**](Group.html) PutGroup (string groupId, GroupUpdate body = null)



Update group

Requires ANY permissions: 

* directory:group:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutGroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID
            var body = new GroupUpdate(); // GroupUpdate | Group (optional) 

            try
            { 
                // Update group
                Group result = apiInstance.PutGroup(groupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PutGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **body** | [**GroupUpdate**](GroupUpdate.html)| Group | [optional]  |
{: class="table table-striped"}

### Return type

[**Group**](Group.html)

<a name="putgroupdynamicsettings"></a>

## void PutGroupDynamicsettings (string groupId, DynamicGroupQuery body)



Create / Update dynamic group definition

PutGroupDynamicsettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* directory:group:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutGroupDynamicsettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID
            var body = new DynamicGroupQuery(); // DynamicGroupQuery | Create/Update dynamic groups

            try
            { 
                // Create / Update dynamic group definition
                apiInstance.PutGroupDynamicsettings(groupId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PutGroupDynamicsettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **body** | [**DynamicGroupQuery**](DynamicGroupQuery.html)| Create/Update dynamic groups |  |
{: class="table table-striped"}

### Return type

void (empty response body)

