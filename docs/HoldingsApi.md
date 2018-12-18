# Atrium.Api.HoldingsApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListHoldings**](HoldingsApi.md#listholdings) | **GET** /users/{user_guid}/holdings | List holdings
[**ListHoldingsByAccount**](HoldingsApi.md#listholdingsbyaccount) | **GET** /users/{user_guid}/accounts/{account_guid}/holdings | List holdings by account
[**ListHoldingsByMember**](HoldingsApi.md#listholdingsbymember) | **GET** /users/{user_guid}/members/{member_guid}/holdings | List holdings by member
[**ReadHolding**](HoldingsApi.md#readholding) | **GET** /users/{user_guid}/holdings/{holding_guid} | Read holding


<a name="listholdings"></a>
# **ListHoldings**
> HoldingsResponseBody ListHoldings (string userGuid)

List holdings

Use this endpoint to read all holdings associated with a specific user.

### Example
```csharp
using System;
using Atrium.Api;
using Atrium.Model;

namespace Example
{
    public class ListHoldingsExample
    {
        public void main()
        {
            var client = new AtriumClient("YOUR_API_KEY", "YOUR_CLIENT_ID");

            var userGuid = "USR-123";  // string | The unique identifier for a `user`.

            try
            {
                // List holdings
                HoldingsResponseBody response = client.holdings.ListHoldings(userGuid);
                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling HoldingsApi.ListHoldings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 

### Return type

[**HoldingsResponseBody**](HoldingsResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listholdingsbyaccount"></a>
# **ListHoldingsByAccount**
> HoldingsResponseBody ListHoldingsByAccount (string accountGuid, string userGuid)

List holdings by account

Use this endpoint to read all holdings associated with a specific account.

### Example
```csharp
using System;
using Atrium.Api;
using Atrium.Model;

namespace Example
{
    public class ListHoldingsByAccountExample
    {
        public void main()
        {
            var client = new AtriumClient("YOUR_API_KEY", "YOUR_CLIENT_ID");

            var accountGuid = "ACT-123";  // string | The unique identifier for an `account`.
            var userGuid = "USR-123";  // string | The unique identifier for a `user`.

            try
            {
                // List holdings by account
                HoldingsResponseBody response = client.holdings.ListHoldingsByAccount(accountGuid, userGuid);
                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling HoldingsApi.ListHoldingsByAccount: " + e.Message );
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

[**HoldingsResponseBody**](HoldingsResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listholdingsbymember"></a>
# **ListHoldingsByMember**
> HoldingsResponseBody ListHoldingsByMember (string memberGuid, string userGuid)

List holdings by member

Use this endpoint to read all holdings associated with a specific member.

### Example
```csharp
using System;
using Atrium.Api;
using Atrium.Model;

namespace Example
{
    public class ListHoldingsByMemberExample
    {
        public void main()
        {
            var client = new AtriumClient("YOUR_API_KEY", "YOUR_CLIENT_ID");

            var memberGuid = "MBR-123";  // string | The unique identifier for a `member`.
            var userGuid = "USR-123";  // string | The unique identifier for a `user`.

            try
            {
                // List holdings by member
                HoldingsResponseBody response = client.holdings.ListHoldingsByMember(memberGuid, userGuid);
                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling HoldingsApi.ListHoldingsByMember: " + e.Message );
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

[**HoldingsResponseBody**](HoldingsResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readholding"></a>
# **ReadHolding**
> HoldingResponseBody ReadHolding (string holdingGuid, string userGuid)

Read holding

Use this endpoint to read the attributes of a specific holding.

### Example
```csharp
using System;
using Atrium.Api;
using Atrium.Model;

namespace Example
{
    public class ReadHoldingExample
    {
        public void main()
        {
            var client = new AtriumClient("YOUR_API_KEY", "YOUR_CLIENT_ID");

            var holdingGuid = "HOL-123";  // string | The unique identifier for a `holding`.
            var userGuid = "USR-123";  // string | The unique identifier for a `user`.

            try
            {
                // Read holding
                HoldingResponseBody response = client.holdings.ReadHolding(holdingGuid, userGuid);
                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling HoldingsApi.ReadHolding: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **holdingGuid** | **string**| The unique identifier for a &#x60;holding&#x60;. | 
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 

### Return type

[**HoldingResponseBody**](HoldingResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

