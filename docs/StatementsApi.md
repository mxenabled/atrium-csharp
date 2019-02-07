# Atrium.Api.StatementsApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**FetchStatements**](StatementsApi.md#fetchstatements) | **POST** /users/{user_guid}/members/{member_guid}/fetch_statements | Fetch statements
[**ListMemberStatements**](StatementsApi.md#listmemberstatements) | **GET** /users/{user_guid}/members/{member_guid}/statements | List member statements


<a name="fetchstatements"></a>
# **FetchStatements**
> MemberResponseBody FetchStatements (string memberGuid, string userGuid)

Fetch statements

The fetch statements endpoint begins fetching statements for a member.

### Example
```csharp
using System;
using Atrium.Api;
using Atrium.Model;

namespace Example
{
    public class FetchStatementsExample
    {
        public void main()
        {
            var client = new AtriumClient("YOUR_API_KEY", "YOUR_CLIENT_ID");

            var memberGuid = "MBR-123";  // string | The unique identifier for a `member`.
            var userGuid = "USR-123";  // string | The unique identifier for a `user`.

            try
            {
                // Fetch statements
                MemberResponseBody response = client.statements.FetchStatements(memberGuid, userGuid);
                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling StatementsApi.FetchStatements: " + e.Message );
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

[**MemberResponseBody**](MemberResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmemberstatements"></a>
# **ListMemberStatements**
> StatementsResponseBody ListMemberStatements (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null)

List member statements

Certain institutions in Atrium allow developers to access account statements associated with a particular `member`. Use this endpoint to get an array of available statements.  Before this endpoint can be used, `fetch_statements` should be performed on the relevant `member`. 

### Example
```csharp
using System;
using Atrium.Api;
using Atrium.Model;

namespace Example
{
    public class ListMemberStatementsExample
    {
        public void main()
        {
            var client = new AtriumClient("YOUR_API_KEY", "YOUR_CLIENT_ID");

            var memberGuid = "MBR-123";  // string | The unique identifier for a `member`.
            var userGuid = "USR-123";  // string | The unique identifier for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 12;  // int? | Specify records per page. (optional) 

            try
            {
                // List member statements
                StatementsResponseBody response = client.statements.ListMemberStatements(memberGuid, userGuid, page, recordsPerPage);
                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling StatementsApi.ListMemberStatements: " + e.Message );
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
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**StatementsResponseBody**](StatementsResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

