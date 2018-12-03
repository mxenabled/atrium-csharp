# atrium.Api.VerificationApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListAccountNumbers**](VerificationApi.md#listaccountnumbers) | **GET** /users/{user_guid}/members/{member_guid}/account_numbers | Read account numbers
[**ListAccountNumbersByAccount**](VerificationApi.md#listaccountnumbersbyaccount) | **GET** /users/{user_guid}/accounts/{account_guid}/account_numbers | Read account numbers by account GUID
[**VerifyMember**](VerificationApi.md#verifymember) | **POST** /users/{user_guid}/members/{member_guid}/verify | Verify


<a name="listaccountnumbers"></a>
# **ListAccountNumbers**
> AccountNumbers ListAccountNumbers (string memberGuid, string userGuid)

Read account numbers

Use this endpoint to check whether account and routing numbers are available for accounts associated with a particular member. It returns the account_numbers object, which contains account and routing number data for each account associated with the member.

### Example
```csharp
using System;
using System.Diagnostics;
using atrium.Api;
using atrium.Client;
using atrium.Model;

namespace Example
{
    public class ListAccountNumbersExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("MX-API-Key", "Bearer");
            // Configure API key authorization: clientID
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("MX-Client-ID", "Bearer");

            var apiInstance = new VerificationApi();
            var memberGuid = memberGuid_example;  // string | The unique identifier for a `member`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.

            try
            {
                // Read account numbers
                AccountNumbers result = apiInstance.ListAccountNumbers(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.ListAccountNumbers: " + e.Message );
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

[**AccountNumbers**](AccountNumbers.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaccountnumbersbyaccount"></a>
# **ListAccountNumbersByAccount**
> AccountNumbers ListAccountNumbersByAccount (string accountGuid, string userGuid)

Read account numbers by account GUID

Use this endpoint to check whether account and routing numbers are available for a specific account. It returns the account_numbers object, which contains account and routing number data.

### Example
```csharp
using System;
using System.Diagnostics;
using atrium.Api;
using atrium.Client;
using atrium.Model;

namespace Example
{
    public class ListAccountNumbersByAccountExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("MX-API-Key", "Bearer");
            // Configure API key authorization: clientID
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("MX-Client-ID", "Bearer");

            var apiInstance = new VerificationApi();
            var accountGuid = accountGuid_example;  // string | The unique identifier for an `account`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.

            try
            {
                // Read account numbers by account GUID
                AccountNumbers result = apiInstance.ListAccountNumbersByAccount(accountGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.ListAccountNumbersByAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountGuid** | **string**| The unique identifier for an &#x60;account&#x60;. | 
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 

### Return type

[**AccountNumbers**](AccountNumbers.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifymember"></a>
# **VerifyMember**
> Member VerifyMember (string memberGuid, string userGuid)

Verify

The verify endpoint begins a verification process for a member.

### Example
```csharp
using System;
using System.Diagnostics;
using atrium.Api;
using atrium.Client;
using atrium.Model;

namespace Example
{
    public class VerifyMemberExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("MX-API-Key", "Bearer");
            // Configure API key authorization: clientID
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("MX-Client-ID", "Bearer");

            var apiInstance = new VerificationApi();
            var memberGuid = memberGuid_example;  // string | The unique identifier for a `member`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.

            try
            {
                // Verify
                Member result = apiInstance.VerifyMember(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.VerifyMember: " + e.Message );
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

