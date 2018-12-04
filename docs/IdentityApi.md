# atrium.Api.IdentityApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**IdentifyMember**](IdentityApi.md#identifymember) | **POST** /users/{user_guid}/members/{member_guid}/identify | Identify
[**ListAccountOwners**](IdentityApi.md#listaccountowners) | **GET** /users/{user_guid}/members/{member_guid}/account_owners | List member account owners


<a name="identifymember"></a>
# **IdentifyMember**
> Member IdentifyMember (string memberGuid, string userGuid)

Identify

The identify endpoint begins an identification process for an already-existing member.

### Example
```csharp
using System;
using System.Diagnostics;
using atrium.Api;
using atrium.Client;
using atrium.Model;

namespace Example
{
    public class IdentifyMemberExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new IdentityApi();
            var memberGuid = memberGuid_example;  // string | The unique identifier for a `member`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.

            try
            {
                // Identify
                Member result = apiInstance.IdentifyMember(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityApi.IdentifyMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique identifier for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 

### Return type

[**Member**](Member.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaccountowners"></a>
# **ListAccountOwners**
> AccountOwners ListAccountOwners (string memberGuid, string userGuid)

List member account owners

This endpoint returns an array with information about every account associated with a particular member.

### Example
```csharp
using System;
using System.Diagnostics;
using atrium.Api;
using atrium.Client;
using atrium.Model;

namespace Example
{
    public class ListAccountOwnersExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new IdentityApi();
            var memberGuid = memberGuid_example;  // string | The unique identifier for a `member`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.

            try
            {
                // List member account owners
                AccountOwners result = apiInstance.ListAccountOwners(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityApi.ListAccountOwners: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique identifier for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 

### Return type

[**AccountOwners**](AccountOwners.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

