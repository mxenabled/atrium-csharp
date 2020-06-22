# Atrium.Api.InstitutionsApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListInstitutions**](InstitutionsApi.md#listinstitutions) | **GET** /institutions | List institutions
[**ReadInstitution**](InstitutionsApi.md#readinstitution) | **GET** /institutions/{institution_code} | Read institution
[**ReadInstitutionCredentials**](InstitutionsApi.md#readinstitutioncredentials) | **GET** /institutions/{institution_code}/credentials | Read institution credentials


<a name="listinstitutions"></a>
# **ListInstitutions**
> InstitutionsResponseBody ListInstitutions (string name = null, int? page = null, int? recordsPerPage = null, bool? supportsAccountIdentification = null, bool? supportsAccountStatement = null, bool? supportsAccountVerification = null, bool? supportsTransactionHistory = null)

List institutions

This endpoint allows you to see what institutions are available for connection. Information returned will include the institution_code assigned to a particular institution, URLs for the financial institution's logo, and the URL for its website.<br> This endpoint takes an optional query string, name={string}. This will list only institutions in which the appended string appears. 

### Example
```csharp
using System;
using Atrium.Api;
using Atrium.Model;

namespace Example
{
    public class ListInstitutionsExample
    {
        public void main()
        {
            var client = new AtriumClient("YOUR_API_KEY", "YOUR_CLIENT_ID", "https://vestibule.mx.com");

            var name = name_example;  // string | This will list only institutions in which the appended string appears. (optional) 
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 12;  // int? | Specify records per page. (optional) 
            var supportsAccountIdentification = true;  // bool? | Filter only institutions which support account identification. (optional) 
            var supportsAccountStatement = true;  // bool? | Filter only institutions which support account statements. (optional) 
            var supportsAccountVerification = true;  // bool? | Filter only institutions which support account verification. (optional) 
            var supportsTransactionHistory = true;  // bool? | Filter only institutions which support extended transaction history. (optional) 

            try
            {
                // List institutions
                InstitutionsResponseBody response = client.institutions.ListInstitutions(name, page, recordsPerPage, supportsAccountIdentification, supportsAccountStatement, supportsAccountVerification, supportsTransactionHistory);
                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling InstitutionsApi.ListInstitutions: " + e.Message );
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
 **supportsAccountIdentification** | **bool?**| Filter only institutions which support account identification. | [optional] 
 **supportsAccountStatement** | **bool?**| Filter only institutions which support account statements. | [optional] 
 **supportsAccountVerification** | **bool?**| Filter only institutions which support account verification. | [optional] 
 **supportsTransactionHistory** | **bool?**| Filter only institutions which support extended transaction history. | [optional] 

### Return type

[**InstitutionsResponseBody**](InstitutionsResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinstitution"></a>
# **ReadInstitution**
> InstitutionResponseBody ReadInstitution (string institutionCode)

Read institution

This endpoint allows you to see information for a specific institution.

### Example
```csharp
using System;
using Atrium.Api;
using Atrium.Model;

namespace Example
{
    public class ReadInstitutionExample
    {
        public void main()
        {
            var client = new AtriumClient("YOUR_API_KEY", "YOUR_CLIENT_ID", "https://vestibule.mx.com");

            var institutionCode = "example_institution_code";  // string | The institution_code of the institution.

            try
            {
                // Read institution
                InstitutionResponseBody response = client.institutions.ReadInstitution(institutionCode);
                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling InstitutionsApi.ReadInstitution: " + e.Message );
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

[**InstitutionResponseBody**](InstitutionResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinstitutioncredentials"></a>
# **ReadInstitutionCredentials**
> CredentialsResponseBody ReadInstitutionCredentials (string institutionCode)

Read institution credentials

Use this endpoint to see which credentials will be needed to create a member for a specific institution.

### Example
```csharp
using System;
using Atrium.Api;
using Atrium.Model;

namespace Example
{
    public class ReadInstitutionCredentialsExample
    {
        public void main()
        {
            var client = new AtriumClient("YOUR_API_KEY", "YOUR_CLIENT_ID", "https://vestibule.mx.com");

            var institutionCode = "example_institution_code";  // string | The institution_code of the institution.

            try
            {
                // Read institution credentials
                CredentialsResponseBody response = client.institutions.ReadInstitutionCredentials(institutionCode);
                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling InstitutionsApi.ReadInstitutionCredentials: " + e.Message );
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

[**CredentialsResponseBody**](CredentialsResponseBody.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

