# Atrium.Api.AccountsApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListAccountTransactions**](AccountsApi.md#listaccounttransactions) | **GET** /users/{user_guid}/accounts/{account_guid}/transactions | List account transactions
[**ListUserAccounts**](AccountsApi.md#listuseraccounts) | **GET** /users/{user_guid}/accounts | List accounts for a user
[**ReadAccount**](AccountsApi.md#readaccount) | **GET** /users/{user_guid}/accounts/{account_guid} | Read an account
[**ReadAccountByMemberGUID**](AccountsApi.md#readaccountbymemberguid) | **GET** /users/{user_guid}/members/{member_guid}/accounts/{account_guid} | Read an account


<a name="listaccounttransactions"></a>
# **ListAccountTransactions**
> TransactionsResponseBody ListAccountTransactions (string accountGuid, string userGuid, string fromDate = null, string toDate = null, int? page = null, int? recordsPerPage = null)

List account transactions

This endpoint allows you to see every transaction that belongs to a specific account. The default from_date is 90 days prior to the request, and the default to_date is 5 days from the time of the request.<br> The from_date and to_date parameters can optionally be appended to the request. 

### Example
```csharp
using System;
using System.Diagnostics;
using Atrium.Api;
using Atrium.Client;
using Atrium.Model;

namespace Example
{
    public class ListAccountTransactionsExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new AccountsApi();
            var accountGuid = accountGuid_example;  // string | The unique identifier for an `account`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.
            var fromDate = fromDate_example;  // string | Filter transactions from this date. (optional) 
            var toDate = toDate_example;  // string | Filter transactions to this date. (optional) 
            var page = 12;  // int? | Specify current page. (optional) 
            var recordsPerPage = 12;  // int? | Specify records per page. (optional) 

            try
            {
                // List account transactions
                TransactionsResponseBody result = apiInstance.ListAccountTransactions(accountGuid, userGuid, fromDate, toDate, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ListAccountTransactions: " + e.Message );
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
 **fromDate** | **string**| Filter transactions from this date. | [optional] 
 **toDate** | **string**| Filter transactions to this date. | [optional] 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**TransactionsResponseBody**](TransactionsResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listuseraccounts"></a>
# **ListUserAccounts**
> AccountsResponseBody ListUserAccounts (string userGuid, int? page = null, int? recordsPerPage = null)

List accounts for a user

Use this endpoint to view information about every account that belongs to a user. You'll need the user's GUID to access this list. The information will include the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the account balance, the date the account was started, etc.

### Example
```csharp
using System;
using System.Diagnostics;
using Atrium.Api;
using Atrium.Client;
using Atrium.Model;

namespace Example
{
    public class ListUserAccountsExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new AccountsApi();
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.
            var page = 12;  // int? | Specify current page. (optional) 
            var recordsPerPage = 12;  // int? | Specify records per page. (optional) 

            try
            {
                // List accounts for a user
                AccountsResponseBody result = apiInstance.ListUserAccounts(userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ListUserAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**AccountsResponseBody**](AccountsResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readaccount"></a>
# **ReadAccount**
> AccountResponseBody ReadAccount (string accountGuid, string userGuid)

Read an account

Reading an account allows you to get information about a specific account that belongs to a user. That includes the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the balance, the date the account was started, and much more.<br> There are two endpoints for reading an account. Both will return the same information.<br> It's important to remember that balance and available_balance will normally be positive numbers — for all account types. But this should be interpreted differently for debt accounts and asset accounts.<br> An asset account, e.g., CHECKING, SAVINGS, or INVESTMENT, will have a positive balance unless it is in an overdraft condition, in which case the balance will be negative.<br> On the other hand, a debt account, e.g., CREDIT CARD, LOAN, MORTGAGE, would have a positivebalance when the user owes money on the account. It would have a negative balance if the account has been overpaid. 

### Example
```csharp
using System;
using System.Diagnostics;
using Atrium.Api;
using Atrium.Client;
using Atrium.Model;

namespace Example
{
    public class ReadAccountExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new AccountsApi();
            var accountGuid = accountGuid_example;  // string | The unique identifier for an `account`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.

            try
            {
                // Read an account
                AccountResponseBody result = apiInstance.ReadAccount(accountGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ReadAccount: " + e.Message );
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

[**AccountResponseBody**](AccountResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readaccountbymemberguid"></a>
# **ReadAccountByMemberGUID**
> AccountResponseBody ReadAccountByMemberGUID (string accountGuid, string memberGuid, string userGuid)

Read an account

Reading an account allows you to get information about a specific account that belongs to a user. That includes the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the balance, the date the account was started, and much more.<br> There are two endpoints for reading an account. Both will return the same information.<br> It's important to remember that balance and available_balance will normally be positive numbers — for all account types. But this should be interpreted differently for debt accounts and asset accounts.<br> An asset account, e.g., CHECKING, SAVINGS, or INVESTMENT, will have a positive balance unless it is in an overdraft condition, in which case the balance will be negative.<br> On the other hand, a debt account, e.g., CREDIT CARD, LOAN, MORTGAGE, would have a positivebalance when the user owes money on the account. It would have a negative balance if the account has been overpaid. 

### Example
```csharp
using System;
using System.Diagnostics;
using Atrium.Api;
using Atrium.Client;
using Atrium.Model;

namespace Example
{
    public class ReadAccountByMemberGUIDExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new AccountsApi();
            var accountGuid = accountGuid_example;  // string | The unique identifier for an `account`.
            var memberGuid = memberGuid_example;  // string | The unique identifier for a `member`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.

            try
            {
                // Read an account
                AccountResponseBody result = apiInstance.ReadAccountByMemberGUID(accountGuid, memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ReadAccountByMemberGUID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountGuid** | **string**| The unique identifier for an &#x60;account&#x60;. | 
 **memberGuid** | **string**| The unique identifier for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 

### Return type

[**AccountResponseBody**](AccountResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

