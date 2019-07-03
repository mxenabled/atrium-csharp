# Atrium.Api.TransactionsApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**CleanseAndCategorizeTransactions**](TransactionsApi.md#cleanseandcategorizetransactions) | **POST** /transactions/cleanse_and_categorize | Categorize transactions
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
using Atrium.Api;
using Atrium.Model;

namespace Example
{
    public class CleanseAndCategorizeTransactionsExample
    {
        public void main()
        {
            var client = new AtriumClient("YOUR_API_KEY", "YOUR_CLIENT_ID");

            var body = new TransactionsCleanseAndCategorizeRequestBody(); // TransactionsCleanseAndCategorizeRequestBody | User object to be created with optional parameters (amount, type) amd required parameters (description, identifier)

            try
            {
                // Categorize transactions
                TransactionsCleanseAndCategorizeResponseBody response = client.transactions.CleanseAndCategorizeTransactions(body);
                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling TransactionsApi.CleanseAndCategorizeTransactions: " + e.Message );
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
using Atrium.Api;
using Atrium.Model;

namespace Example
{
    public class ListUserTransactionsExample
    {
        public void main()
        {
            var client = new AtriumClient("YOUR_API_KEY", "YOUR_CLIENT_ID");

            var userGuid = "USR-123";  // string | The unique identifier for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var fromDate = "2016-09-20";  // string | Filter transactions from this date. (optional) 
            var recordsPerPage = 12;  // int? | Specify records per page. (optional) 
            var toDate = "2016-10-20";  // string | Filter transactions to this date. (optional) 

            try
            {
                // List transactions for a user
                TransactionsResponseBody response = client.transactions.ListUserTransactions(userGuid, page, fromDate, recordsPerPage, toDate);
                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling TransactionsApi.ListUserTransactions: " + e.Message );
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
using Atrium.Api;
using Atrium.Model;

namespace Example
{
    public class ReadTransactionExample
    {
        public void main()
        {
            var client = new AtriumClient("YOUR_API_KEY", "YOUR_CLIENT_ID");

            var transactionGuid = "TRN-123";  // string | The unique identifier for a `transaction`.
            var userGuid = "USR-123";  // string | The unique identifier for a `user`.

            try
            {
                // Read a transaction
                TransactionResponseBody response = client.transactions.ReadTransaction(transactionGuid, userGuid);
                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling TransactionsApi.ReadTransaction: " + e.Message );
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

