# Atrium.Api.TransactionsApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**CleanseAndCategorizeTransactions**](TransactionsApi.md#cleanseandcategorizetransactions) | **POST** /cleanse_and_categorize | Categorize transactions
[**ListUserTransactions**](TransactionsApi.md#listusertransactions) | **GET** /users/{user_guid}/transactions | List transactions for a user
[**ReadTransaction**](TransactionsApi.md#readtransaction) | **GET** /users/{user_guid}/transactions/{transaction_guid} | Read a transaction


<a name="cleanseandcategorizetransactions"></a>
# **CleanseAndCategorizeTransactions**
> TransactionsCleanseAndCategorizeResponseBody CleanseAndCategorizeTransactions (TransactionsCleanseAndCategorizeRequestBody body)

Categorize transactions

Use this endpoint to categorize, cleanse, and classify transactions. These transactions are not persisted or stored on the MX platform.

### Example
```csharp
using System;
using System.Diagnostics;
using Atrium.Api;
using Atrium.Client;
using Atrium.Model;

namespace Example
{
    public class CleanseAndCategorizeTransactionsExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new TransactionsApi();
            var body = new TransactionsCleanseAndCategorizeRequestBody(); // TransactionsCleanseAndCategorizeRequestBody | User object to be created with optional parameters (amount, type) amd required parameters (description, identifier)

            try
            {
                // Categorize transactions
                TransactionsCleanseAndCategorizeResponseBody result = apiInstance.CleanseAndCategorizeTransactions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.CleanseAndCategorizeTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionsCleanseAndCategorizeRequestBody**](TransactionsCleanseAndCategorizeRequestBody.md)| User object to be created with optional parameters (amount, type) amd required parameters (description, identifier) | 

### Return type

[**TransactionsCleanseAndCategorizeResponseBody**](TransactionsCleanseAndCategorizeResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listusertransactions"></a>
# **ListUserTransactions**
> TransactionsResponseBody ListUserTransactions (string userGuid, int? page = null, string fromDate = null, int? recordsPerPage = null, string toDate = null)

List transactions for a user

Use this endpoint to get all transactions that belong to a specific user, across all the user's members and accounts.<br> This endpoint accepts optional query parameters, from_date and to_date, which filter transactions according to the date they were posted. If no values are given, from_date will default to 90 days prior to the request, and to_date will default to 5 days from the time of the request. 

### Example
```csharp
using System;
using System.Diagnostics;
using Atrium.Api;
using Atrium.Client;
using Atrium.Model;

namespace Example
{
    public class ListUserTransactionsExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new TransactionsApi();
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.
            var page = 12;  // int? | Specify current page. (optional) 
            var fromDate = fromDate_example;  // string | Filter transactions from this date. (optional) 
            var recordsPerPage = 12;  // int? | Specify records per page. (optional) 
            var toDate = toDate_example;  // string | Filter transactions to this date. (optional) 

            try
            {
                // List transactions for a user
                TransactionsResponseBody result = apiInstance.ListUserTransactions(userGuid, page, fromDate, recordsPerPage, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.ListUserTransactions: " + e.Message );
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
 **fromDate** | **string**| Filter transactions from this date. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 
 **toDate** | **string**| Filter transactions to this date. | [optional] 

### Return type

[**TransactionsResponseBody**](TransactionsResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readtransaction"></a>
# **ReadTransaction**
> TransactionResponseBody ReadTransaction (string transactionGuid, string userGuid)

Read a transaction

This endpoint allows you to view information about a specific transaction that belongs to a user.<br>

### Example
```csharp
using System;
using System.Diagnostics;
using Atrium.Api;
using Atrium.Client;
using Atrium.Model;

namespace Example
{
    public class ReadTransactionExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new TransactionsApi();
            var transactionGuid = transactionGuid_example;  // string | The unique identifier for a `transaction`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.

            try
            {
                // Read a transaction
                TransactionResponseBody result = apiInstance.ReadTransaction(transactionGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.ReadTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionGuid** | **string**| The unique identifier for a &#x60;transaction&#x60;. | 
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 

### Return type

[**TransactionResponseBody**](TransactionResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

