# atrium-csharp.Api.UsersApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUser**](UsersApi.md#createuser) | **POST** /users | Create user
[**DeleteUser**](UsersApi.md#deleteuser) | **DELETE** /users/{user_guid} | Delete user
[**ListUsers**](UsersApi.md#listusers) | **GET** /users | List users
[**ReadUser**](UsersApi.md#readuser) | **GET** /users/{user_guid} | Read user
[**UpdateUser**](UsersApi.md#updateuser) | **PUT** /users/{user_guid} | Update user


<a name="createuser"></a>
# **CreateUser**
> User CreateUser (UserCreateRequestBody body)

Create user

Call this endpoint to create a new user. Atrium will respond with the newly-created user object if successful. This endpoint accepts several parameters: identifier, metadata, and is_disabled.<br> Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user's data until they are no longer disabled. Users who are disabled for the entirety of an Atrium billing period will not be factored into that month's bill. 

### Example
```csharp
using System;
using System.Diagnostics;
using atrium-csharp.Api;
using atrium-csharp.Client;
using atrium-csharp.Model;

namespace Example
{
    public class CreateUserExample
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

            var apiInstance = new UsersApi();
            var body = new UserCreateRequestBody(); // UserCreateRequestBody | User object to be created with optional parameters (identifier, is_disabled, metadata)

            try
            {
                // Create user
                User result = apiInstance.CreateUser(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.CreateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserCreateRequestBody**](UserCreateRequestBody.md)| User object to be created with optional parameters (identifier, is_disabled, metadata) | 

### Return type

[**User**](User.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (string userGuid)

Delete user

Calling this endpoint will permanently delete a user from Atrium. If successful, the API will respond with Status: 204 No Content. 

### Example
```csharp
using System;
using System.Diagnostics;
using atrium-csharp.Api;
using atrium-csharp.Client;
using atrium-csharp.Model;

namespace Example
{
    public class DeleteUserExample
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

            var apiInstance = new UsersApi();
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.

            try
            {
                // Delete user
                apiInstance.DeleteUser(userGuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUser: " + e.Message );
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

void (empty response body)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listusers"></a>
# **ListUsers**
> Users ListUsers (int? page = null, int? recordsPerPage = null)

List users

Use this endpoint to list every user you've created in Atrium.

### Example
```csharp
using System;
using System.Diagnostics;
using atrium-csharp.Api;
using atrium-csharp.Client;
using atrium-csharp.Model;

namespace Example
{
    public class ListUsersExample
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

            var apiInstance = new UsersApi();
            var page = 12;  // int? | Specify current page. (optional) 
            var recordsPerPage = 12;  // int? | Specify records per page. (optional) 

            try
            {
                // List users
                Users result = apiInstance.ListUsers(page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ListUsers: " + e.Message );
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

[**Users**](Users.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readuser"></a>
# **ReadUser**
> User ReadUser (string userGuid)

Read user

Use this endpoint to read the attributes of a specific user.

### Example
```csharp
using System;
using System.Diagnostics;
using atrium-csharp.Api;
using atrium-csharp.Client;
using atrium-csharp.Model;

namespace Example
{
    public class ReadUserExample
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

            var apiInstance = new UsersApi();
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.

            try
            {
                // Read user
                User result = apiInstance.ReadUser(userGuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ReadUser: " + e.Message );
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

[**User**](User.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> User UpdateUser (string userGuid, UserUpdateRequestBody body = null)

Update user

Use this endpoint to update the attributes of a specific user. Atrium will respond with the updated user object.<br> Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user's data until they are no longer disabled. Users who are disabled for the entirety of an Atrium billing period will not be factored into that month's bill.<br> To disable a user, update it and set the is_disabled parameter to true. Set it to false to re-enable the user. 

### Example
```csharp
using System;
using System.Diagnostics;
using atrium-csharp.Api;
using atrium-csharp.Client;
using atrium-csharp.Model;

namespace Example
{
    public class UpdateUserExample
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

            var apiInstance = new UsersApi();
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.
            var body = new UserUpdateRequestBody(); // UserUpdateRequestBody | User object to be updated with optional parameters (identifier, is_disabled, metadata) (optional) 

            try
            {
                // Update user
                User result = apiInstance.UpdateUser(userGuid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 
 **body** | [**UserUpdateRequestBody**](UserUpdateRequestBody.md)| User object to be updated with optional parameters (identifier, is_disabled, metadata) | [optional] 

### Return type

[**User**](User.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

