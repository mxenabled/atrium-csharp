# atrium-csharp.Api.InstitutionsApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListInstitutions**](InstitutionsApi.md#listinstitutions) | **GET** /institutions | List institutions
[**ReadInstitution**](InstitutionsApi.md#readinstitution) | **GET** /institutions/{institution_code} | Read institution
[**ReadInstitutionCredentials**](InstitutionsApi.md#readinstitutioncredentials) | **GET** /institutions/{institution_code}/credentials | Read institution credentials


<a name="listinstitutions"></a>
# **ListInstitutions**
> Institutions ListInstitutions (string name = null, int? page = null, int? recordsPerPage = null)

List institutions

This endpoint allows you to see what institutions are available for connection. Information returned will include the institution_code assigned to a particular institution, URLs for the financial institution's logo, and the URL for its website.<br> This endpoint takes an optional query string, name={string}. This will list only institutions in which the appended string appears. 

### Example
```csharp
using System;
using System.Diagnostics;
using atrium-csharp.Api;
using atrium-csharp.Client;
using atrium-csharp.Model;

namespace Example
{
    public class ListInstitutionsExample
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

            var apiInstance = new InstitutionsApi();
            var name = name_example;  // string | This will list only institutions in which the appended string appears. (optional) 
            var page = 12;  // int? | Specify current page. (optional) 
            var recordsPerPage = 12;  // int? | Specify records per page. (optional) 

            try
            {
                // List institutions
                Institutions result = apiInstance.ListInstitutions(name, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstitutionsApi.ListInstitutions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| This will list only institutions in which the appended string appears. | [optional] 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**Institutions**](Institutions.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinstitution"></a>
# **ReadInstitution**
> Institution ReadInstitution (string institutionCode)

Read institution

This endpoint allows you to see information for a specific institution.

### Example
```csharp
using System;
using System.Diagnostics;
using atrium-csharp.Api;
using atrium-csharp.Client;
using atrium-csharp.Model;

namespace Example
{
    public class ReadInstitutionExample
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

            var apiInstance = new InstitutionsApi();
            var institutionCode = institutionCode_example;  // string | The institution_code of the institution.

            try
            {
                // Read institution
                Institution result = apiInstance.ReadInstitution(institutionCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstitutionsApi.ReadInstitution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **institutionCode** | **string**| The institution_code of the institution. | 

### Return type

[**Institution**](Institution.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinstitutioncredentials"></a>
# **ReadInstitutionCredentials**
> Credentials ReadInstitutionCredentials (string institutionCode)

Read institution credentials

Use this endpoint to see which credentials will be needed to create a member for a specific institution.

### Example
```csharp
using System;
using System.Diagnostics;
using atrium-csharp.Api;
using atrium-csharp.Client;
using atrium-csharp.Model;

namespace Example
{
    public class ReadInstitutionCredentialsExample
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

            var apiInstance = new InstitutionsApi();
            var institutionCode = institutionCode_example;  // string | The institution_code of the institution.

            try
            {
                // Read institution credentials
                Credentials result = apiInstance.ReadInstitutionCredentials(institutionCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstitutionsApi.ReadInstitutionCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **institutionCode** | **string**| The institution_code of the institution. | 

### Return type

[**Credentials**](Credentials.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

