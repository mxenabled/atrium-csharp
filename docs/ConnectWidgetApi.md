# atrium-csharp.Api.ConnectWidgetApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetConnectWidget**](ConnectWidgetApi.md#getconnectwidget) | **POST** /users/{user_guid}/connect_widget_url | Embedding in a website


<a name="getconnectwidget"></a>
# **GetConnectWidget**
> ConnectWidget GetConnectWidget (string userGuid, ConnectWidgetRequestBody body)

Embedding in a website

This endpoint will return a URL for an embeddable version of MX Connect.

### Example
```csharp
using System;
using System.Diagnostics;
using atrium-csharp.Api;
using atrium-csharp.Client;
using atrium-csharp.Model;

namespace Example
{
    public class GetConnectWidgetExample
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

            var apiInstance = new ConnectWidgetApi();
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.
            var body = new ConnectWidgetRequestBody(); // ConnectWidgetRequestBody | Optional config options for WebView (is_mobile_webview, current_institution_code, current_member_guid, update_credentials)

            try
            {
                // Embedding in a website
                ConnectWidget result = apiInstance.GetConnectWidget(userGuid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectWidgetApi.GetConnectWidget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 
 **body** | [**ConnectWidgetRequestBody**](ConnectWidgetRequestBody.md)| Optional config options for WebView (is_mobile_webview, current_institution_code, current_member_guid, update_credentials) | 

### Return type

[**ConnectWidget**](ConnectWidget.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
