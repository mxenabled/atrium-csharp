# Atrium.Api.MerchantsApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReadMerchant**](MerchantsApi.md#readmerchant) | **GET** /merchants/{merchant_guid} | Read merchant


<a name="readmerchant"></a>
# **ReadMerchant**
> MerchantResponseBody ReadMerchant (string merchantGuid)

Read merchant

Returns information about a particular merchant, such as a logo, name, and website.

### Example
```csharp
using System;
using Atrium.Api;
using Atrium.Model;

namespace Example
{
    public class ReadMerchantExample
    {
        public void main()
        {
            var client = new AtriumClient("YOUR_API_KEY", "YOUR_CLIENT_ID");

            var merchantGuid = "MCH-123";  // string | The unique identifier for a `merchant`.

            try
            {
                // Read merchant
                MerchantResponseBody response = client.merchants.ReadMerchant(merchantGuid);
                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling MerchantsApi.ReadMerchant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantGuid** | **string**| The unique identifier for a &#x60;merchant&#x60;. | 

### Return type

[**MerchantResponseBody**](MerchantResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

