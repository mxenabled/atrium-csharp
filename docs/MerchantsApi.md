# Atrium.Api.MerchantsApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListMerchantLocations**](MerchantsApi.md#listmerchantlocations) | **GET** /merchants/{merchant_guid}/merchant_locations | List merchant locations
[**ListMerchants**](MerchantsApi.md#listmerchants) | **GET** /merchants | List merchants
[**ReadMerchant**](MerchantsApi.md#readmerchant) | **GET** /merchants/{merchant_guid} | Read merchant
[**ReadMerchantLocation**](MerchantsApi.md#readmerchantlocation) | **GET** /merchants/{merchant_guid}/merchant_locations/{merchant_location_guid} | Read merchant location


<a name="listmerchantlocations"></a>
# **ListMerchantLocations**
> MerchantLocationsResponseBody ListMerchantLocations (string merchantGuid, int? page = null, int? recordsPerPage = null)

List merchant locations

Returns a list of all the merchant locations associated with a merchant, including physical location, latitude, longitude, etc.

### Example
```csharp
using System;
using Atrium.Api;
using Atrium.Model;

namespace Example
{
    public class ListMerchantLocationsExample
    {
        public void main()
        {
            var client = new AtriumClient("YOUR_API_KEY", "YOUR_CLIENT_ID", "https://vestibule.mx.com");

            var merchantGuid = "MCH-123";  // string | The unique identifier for a `merchant`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 12;  // int? | Specify records per page. (optional) 

            try
            {
                // List merchant locations
                MerchantLocationsResponseBody response = client.merchants.ListMerchantLocations(merchantGuid, page, recordsPerPage);
                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling MerchantsApi.ListMerchantLocations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantGuid** | **string**| The unique identifier for a &#x60;merchant&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**MerchantLocationsResponseBody**](MerchantLocationsResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmerchants"></a>
# **ListMerchants**
> MerchantsResponseBody ListMerchants (int? page = null, int? recordsPerPage = null)

List merchants

Returns a list of merchnants.

### Example
```csharp
using System;
using Atrium.Api;
using Atrium.Model;

namespace Example
{
    public class ListMerchantsExample
    {
        public void main()
        {
            var client = new AtriumClient("YOUR_API_KEY", "YOUR_CLIENT_ID", "https://vestibule.mx.com");

            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 12;  // int? | Specify records per page. (optional) 

            try
            {
                // List merchants
                MerchantsResponseBody response = client.merchants.ListMerchants(page, recordsPerPage);
                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling MerchantsApi.ListMerchants: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**MerchantsResponseBody**](MerchantsResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
            var client = new AtriumClient("YOUR_API_KEY", "YOUR_CLIENT_ID", "https://vestibule.mx.com");

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

<a name="readmerchantlocation"></a>
# **ReadMerchantLocation**
> MerchantLocationResponseBody ReadMerchantLocation (string merchantGuid, string merchantLocationGuid)

Read merchant location

Retuns a specific location associated with a merchant, including physical location, latitude, longitude, etc.

### Example
```csharp
using System;
using Atrium.Api;
using Atrium.Model;

namespace Example
{
    public class ReadMerchantLocationExample
    {
        public void main()
        {
            var client = new AtriumClient("YOUR_API_KEY", "YOUR_CLIENT_ID", "https://vestibule.mx.com");

            var merchantGuid = "MCH-123";  // string | The unique identifier for a `merchant`.
            var merchantLocationGuid = "MCL-123";  // string | The unique identifier for a `merchant_location`.

            try
            {
                // Read merchant location
                MerchantLocationResponseBody response = client.merchants.ReadMerchantLocation(merchantGuid, merchantLocationGuid);
                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling MerchantsApi.ReadMerchantLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantGuid** | **string**| The unique identifier for a &#x60;merchant&#x60;. | 
 **merchantLocationGuid** | **string**| The unique identifier for a &#x60;merchant_location&#x60;. | 

### Return type

[**MerchantLocationResponseBody**](MerchantLocationResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

