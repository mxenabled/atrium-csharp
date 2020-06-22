/* 
 * MX API
 *
 * The MX Atrium API supports over 48,000 data connections to thousands of financial institutions. It provides secure access to your users' accounts and transactions with industry-leading cleansing, categorization, and classification.  Atrium is designed according to resource-oriented REST architecture and responds with JSON bodies and HTTP response codes.  Use Atrium's development environment, vestibule.mx.com, to quickly get up and running. The development environment limits are 100 users, 25 members per user, and access to the top 15 institutions. Contact MX to purchase production access. 
 *
 * OpenAPI spec version: 0.1
 * 
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Atrium.Client;
using Atrium.Model;

namespace Atrium.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create user
        /// </summary>
        /// <remarks>
        /// Call this endpoint to create a new user. Atrium will respond with the newly-created user object if successful. This endpoint accepts several parameters: identifier, metadata, and is_disabled.&lt;br&gt; Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user&#39;s data until they are no longer disabled. Users who are disabled for the entirety of an Atrium billing period will not be factored into that month&#39;s bill. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User object to be created with optional parameters (identifier, is_disabled, metadata)</param>
        /// <returns>UserResponseBody</returns>
        UserResponseBody CreateUser (UserCreateRequestBody body);

        /// <summary>
        /// Create user
        /// </summary>
        /// <remarks>
        /// Call this endpoint to create a new user. Atrium will respond with the newly-created user object if successful. This endpoint accepts several parameters: identifier, metadata, and is_disabled.&lt;br&gt; Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user&#39;s data until they are no longer disabled. Users who are disabled for the entirety of an Atrium billing period will not be factored into that month&#39;s bill. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User object to be created with optional parameters (identifier, is_disabled, metadata)</param>
        /// <returns>ApiResponse of UserResponseBody</returns>
        ApiResponse<UserResponseBody> CreateUserWithHttpInfo (UserCreateRequestBody body);
        /// <summary>
        /// Delete user
        /// </summary>
        /// <remarks>
        /// Calling this endpoint will permanently delete a user from Atrium. If successful, the API will respond with Status: 204 No Content. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns></returns>
        void DeleteUser (string userGuid);

        /// <summary>
        /// Delete user
        /// </summary>
        /// <remarks>
        /// Calling this endpoint will permanently delete a user from Atrium. If successful, the API will respond with Status: 204 No Content. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteUserWithHttpInfo (string userGuid);
        /// <summary>
        /// List users
        /// </summary>
        /// <remarks>
        /// Use this endpoint to list every user you&#39;ve created in Atrium.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>UsersResponseBody</returns>
        UsersResponseBody ListUsers (int? page = null, int? recordsPerPage = null);

        /// <summary>
        /// List users
        /// </summary>
        /// <remarks>
        /// Use this endpoint to list every user you&#39;ve created in Atrium.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>ApiResponse of UsersResponseBody</returns>
        ApiResponse<UsersResponseBody> ListUsersWithHttpInfo (int? page = null, int? recordsPerPage = null);
        /// <summary>
        /// Read user
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read the attributes of a specific user.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>UserResponseBody</returns>
        UserResponseBody ReadUser (string userGuid);

        /// <summary>
        /// Read user
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read the attributes of a specific user.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of UserResponseBody</returns>
        ApiResponse<UserResponseBody> ReadUserWithHttpInfo (string userGuid);
        /// <summary>
        /// Update user
        /// </summary>
        /// <remarks>
        /// Use this endpoint to update the attributes of a specific user. Atrium will respond with the updated user object.&lt;br&gt; Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user&#39;s data until they are no longer disabled. Users who are disabled for the entirety of an Atrium billing period will not be factored into that month&#39;s bill.&lt;br&gt; To disable a user, update it and set the is_disabled parameter to true. Set it to false to re-enable the user. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="body">User object to be updated with optional parameters (identifier, is_disabled, metadata) (optional)</param>
        /// <returns>UserResponseBody</returns>
        UserResponseBody UpdateUser (string userGuid, UserUpdateRequestBody body = null);

        /// <summary>
        /// Update user
        /// </summary>
        /// <remarks>
        /// Use this endpoint to update the attributes of a specific user. Atrium will respond with the updated user object.&lt;br&gt; Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user&#39;s data until they are no longer disabled. Users who are disabled for the entirety of an Atrium billing period will not be factored into that month&#39;s bill.&lt;br&gt; To disable a user, update it and set the is_disabled parameter to true. Set it to false to re-enable the user. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="body">User object to be updated with optional parameters (identifier, is_disabled, metadata) (optional)</param>
        /// <returns>ApiResponse of UserResponseBody</returns>
        ApiResponse<UserResponseBody> UpdateUserWithHttpInfo (string userGuid, UserUpdateRequestBody body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create user
        /// </summary>
        /// <remarks>
        /// Call this endpoint to create a new user. Atrium will respond with the newly-created user object if successful. This endpoint accepts several parameters: identifier, metadata, and is_disabled.&lt;br&gt; Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user&#39;s data until they are no longer disabled. Users who are disabled for the entirety of an Atrium billing period will not be factored into that month&#39;s bill. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User object to be created with optional parameters (identifier, is_disabled, metadata)</param>
        /// <returns>Task of UserResponseBody</returns>
        System.Threading.Tasks.Task<UserResponseBody> CreateUserAsync (UserCreateRequestBody body);

        /// <summary>
        /// Create user
        /// </summary>
        /// <remarks>
        /// Call this endpoint to create a new user. Atrium will respond with the newly-created user object if successful. This endpoint accepts several parameters: identifier, metadata, and is_disabled.&lt;br&gt; Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user&#39;s data until they are no longer disabled. Users who are disabled for the entirety of an Atrium billing period will not be factored into that month&#39;s bill. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User object to be created with optional parameters (identifier, is_disabled, metadata)</param>
        /// <returns>Task of ApiResponse (UserResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserResponseBody>> CreateUserAsyncWithHttpInfo (UserCreateRequestBody body);
        /// <summary>
        /// Delete user
        /// </summary>
        /// <remarks>
        /// Calling this endpoint will permanently delete a user from Atrium. If successful, the API will respond with Status: 204 No Content. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteUserAsync (string userGuid);

        /// <summary>
        /// Delete user
        /// </summary>
        /// <remarks>
        /// Calling this endpoint will permanently delete a user from Atrium. If successful, the API will respond with Status: 204 No Content. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserAsyncWithHttpInfo (string userGuid);
        /// <summary>
        /// List users
        /// </summary>
        /// <remarks>
        /// Use this endpoint to list every user you&#39;ve created in Atrium.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of UsersResponseBody</returns>
        System.Threading.Tasks.Task<UsersResponseBody> ListUsersAsync (int? page = null, int? recordsPerPage = null);

        /// <summary>
        /// List users
        /// </summary>
        /// <remarks>
        /// Use this endpoint to list every user you&#39;ve created in Atrium.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of ApiResponse (UsersResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsersResponseBody>> ListUsersAsyncWithHttpInfo (int? page = null, int? recordsPerPage = null);
        /// <summary>
        /// Read user
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read the attributes of a specific user.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of UserResponseBody</returns>
        System.Threading.Tasks.Task<UserResponseBody> ReadUserAsync (string userGuid);

        /// <summary>
        /// Read user
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read the attributes of a specific user.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse (UserResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserResponseBody>> ReadUserAsyncWithHttpInfo (string userGuid);
        /// <summary>
        /// Update user
        /// </summary>
        /// <remarks>
        /// Use this endpoint to update the attributes of a specific user. Atrium will respond with the updated user object.&lt;br&gt; Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user&#39;s data until they are no longer disabled. Users who are disabled for the entirety of an Atrium billing period will not be factored into that month&#39;s bill.&lt;br&gt; To disable a user, update it and set the is_disabled parameter to true. Set it to false to re-enable the user. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="body">User object to be updated with optional parameters (identifier, is_disabled, metadata) (optional)</param>
        /// <returns>Task of UserResponseBody</returns>
        System.Threading.Tasks.Task<UserResponseBody> UpdateUserAsync (string userGuid, UserUpdateRequestBody body = null);

        /// <summary>
        /// Update user
        /// </summary>
        /// <remarks>
        /// Use this endpoint to update the attributes of a specific user. Atrium will respond with the updated user object.&lt;br&gt; Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user&#39;s data until they are no longer disabled. Users who are disabled for the entirety of an Atrium billing period will not be factored into that month&#39;s bill.&lt;br&gt; To disable a user, update it and set the is_disabled parameter to true. Set it to false to re-enable the user. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="body">User object to be updated with optional parameters (identifier, is_disabled, metadata) (optional)</param>
        /// <returns>Task of ApiResponse (UserResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserResponseBody>> UpdateUserAsyncWithHttpInfo (string userGuid, UserUpdateRequestBody body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UsersApi : IUsersApi
    {
        private Atrium.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String apiKey, String clientID, String basePath)
        {
            this.Configuration = new Atrium.Client.Configuration {
              BasePath = basePath,
              ApiKey = {
                {"MX-API-Key", apiKey},
                {"MX-Client-ID", clientID}
              }
            };

            ExceptionFactory = Atrium.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersApi(Atrium.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Atrium.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Atrium.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Atrium.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Atrium.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Create user Call this endpoint to create a new user. Atrium will respond with the newly-created user object if successful. This endpoint accepts several parameters: identifier, metadata, and is_disabled.&lt;br&gt; Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user&#39;s data until they are no longer disabled. Users who are disabled for the entirety of an Atrium billing period will not be factored into that month&#39;s bill. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User object to be created with optional parameters (identifier, is_disabled, metadata)</param>
        /// <returns>UserResponseBody</returns>
        public UserResponseBody CreateUser (UserCreateRequestBody body)
        {
             ApiResponse<UserResponseBody> localVarResponse = CreateUserWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create user Call this endpoint to create a new user. Atrium will respond with the newly-created user object if successful. This endpoint accepts several parameters: identifier, metadata, and is_disabled.&lt;br&gt; Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user&#39;s data until they are no longer disabled. Users who are disabled for the entirety of an Atrium billing period will not be factored into that month&#39;s bill. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User object to be created with optional parameters (identifier, is_disabled, metadata)</param>
        /// <returns>ApiResponse of UserResponseBody</returns>
        public ApiResponse< UserResponseBody > CreateUserWithHttpInfo (UserCreateRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->CreateUser");

            var localVarPath = "/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.mx.atrium.v1+json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-API-Key")))
            {
                localVarHeaderParams["MX-API-Key"] = this.Configuration.GetApiKeyWithPrefix("MX-API-Key");
            }
            // authentication (clientID) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-Client-ID")))
            {
                localVarHeaderParams["MX-Client-ID"] = this.Configuration.GetApiKeyWithPrefix("MX-Client-ID");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserResponseBody)));
        }

        /// <summary>
        /// Create user Call this endpoint to create a new user. Atrium will respond with the newly-created user object if successful. This endpoint accepts several parameters: identifier, metadata, and is_disabled.&lt;br&gt; Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user&#39;s data until they are no longer disabled. Users who are disabled for the entirety of an Atrium billing period will not be factored into that month&#39;s bill. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User object to be created with optional parameters (identifier, is_disabled, metadata)</param>
        /// <returns>Task of UserResponseBody</returns>
        public async System.Threading.Tasks.Task<UserResponseBody> CreateUserAsync (UserCreateRequestBody body)
        {
             ApiResponse<UserResponseBody> localVarResponse = await CreateUserAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create user Call this endpoint to create a new user. Atrium will respond with the newly-created user object if successful. This endpoint accepts several parameters: identifier, metadata, and is_disabled.&lt;br&gt; Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user&#39;s data until they are no longer disabled. Users who are disabled for the entirety of an Atrium billing period will not be factored into that month&#39;s bill. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User object to be created with optional parameters (identifier, is_disabled, metadata)</param>
        /// <returns>Task of ApiResponse (UserResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserResponseBody>> CreateUserAsyncWithHttpInfo (UserCreateRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->CreateUser");

            var localVarPath = "/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.mx.atrium.v1+json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-API-Key")))
            {
                localVarHeaderParams["MX-API-Key"] = this.Configuration.GetApiKeyWithPrefix("MX-API-Key");
            }
            // authentication (clientID) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-Client-ID")))
            {
                localVarHeaderParams["MX-Client-ID"] = this.Configuration.GetApiKeyWithPrefix("MX-Client-ID");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserResponseBody)));
        }

        /// <summary>
        /// Delete user Calling this endpoint will permanently delete a user from Atrium. If successful, the API will respond with Status: 204 No Content. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns></returns>
        public void DeleteUser (string userGuid)
        {
             DeleteUserWithHttpInfo(userGuid);
        }

        /// <summary>
        /// Delete user Calling this endpoint will permanently delete a user from Atrium. If successful, the API will respond with Status: 204 No Content. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteUserWithHttpInfo (string userGuid)
        {
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling UsersApi->DeleteUser");

            var localVarPath = "/users/{user_guid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.mx.atrium.v1+json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userGuid != null) localVarPathParams.Add("user_guid", this.Configuration.ApiClient.ParameterToString(userGuid)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-API-Key")))
            {
                localVarHeaderParams["MX-API-Key"] = this.Configuration.GetApiKeyWithPrefix("MX-API-Key");
            }
            // authentication (clientID) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-Client-ID")))
            {
                localVarHeaderParams["MX-Client-ID"] = this.Configuration.GetApiKeyWithPrefix("MX-Client-ID");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete user Calling this endpoint will permanently delete a user from Atrium. If successful, the API will respond with Status: 204 No Content. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteUserAsync (string userGuid)
        {
             await DeleteUserAsyncWithHttpInfo(userGuid);

        }

        /// <summary>
        /// Delete user Calling this endpoint will permanently delete a user from Atrium. If successful, the API will respond with Status: 204 No Content. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserAsyncWithHttpInfo (string userGuid)
        {
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling UsersApi->DeleteUser");

            var localVarPath = "/users/{user_guid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.mx.atrium.v1+json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userGuid != null) localVarPathParams.Add("user_guid", this.Configuration.ApiClient.ParameterToString(userGuid)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-API-Key")))
            {
                localVarHeaderParams["MX-API-Key"] = this.Configuration.GetApiKeyWithPrefix("MX-API-Key");
            }
            // authentication (clientID) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-Client-ID")))
            {
                localVarHeaderParams["MX-Client-ID"] = this.Configuration.GetApiKeyWithPrefix("MX-Client-ID");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// List users Use this endpoint to list every user you&#39;ve created in Atrium.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>UsersResponseBody</returns>
        public UsersResponseBody ListUsers (int? page = null, int? recordsPerPage = null)
        {
             ApiResponse<UsersResponseBody> localVarResponse = ListUsersWithHttpInfo(page, recordsPerPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List users Use this endpoint to list every user you&#39;ve created in Atrium.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>ApiResponse of UsersResponseBody</returns>
        public ApiResponse< UsersResponseBody > ListUsersWithHttpInfo (int? page = null, int? recordsPerPage = null)
        {

            var localVarPath = "/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.mx.atrium.v1+json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (recordsPerPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "records_per_page", recordsPerPage)); // query parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-API-Key")))
            {
                localVarHeaderParams["MX-API-Key"] = this.Configuration.GetApiKeyWithPrefix("MX-API-Key");
            }
            // authentication (clientID) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-Client-ID")))
            {
                localVarHeaderParams["MX-Client-ID"] = this.Configuration.GetApiKeyWithPrefix("MX-Client-ID");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListUsers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UsersResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsersResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersResponseBody)));
        }

        /// <summary>
        /// List users Use this endpoint to list every user you&#39;ve created in Atrium.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of UsersResponseBody</returns>
        public async System.Threading.Tasks.Task<UsersResponseBody> ListUsersAsync (int? page = null, int? recordsPerPage = null)
        {
             ApiResponse<UsersResponseBody> localVarResponse = await ListUsersAsyncWithHttpInfo(page, recordsPerPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List users Use this endpoint to list every user you&#39;ve created in Atrium.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of ApiResponse (UsersResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsersResponseBody>> ListUsersAsyncWithHttpInfo (int? page = null, int? recordsPerPage = null)
        {

            var localVarPath = "/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.mx.atrium.v1+json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (recordsPerPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "records_per_page", recordsPerPage)); // query parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-API-Key")))
            {
                localVarHeaderParams["MX-API-Key"] = this.Configuration.GetApiKeyWithPrefix("MX-API-Key");
            }
            // authentication (clientID) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-Client-ID")))
            {
                localVarHeaderParams["MX-Client-ID"] = this.Configuration.GetApiKeyWithPrefix("MX-Client-ID");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListUsers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UsersResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsersResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersResponseBody)));
        }

        /// <summary>
        /// Read user Use this endpoint to read the attributes of a specific user.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>UserResponseBody</returns>
        public UserResponseBody ReadUser (string userGuid)
        {
             ApiResponse<UserResponseBody> localVarResponse = ReadUserWithHttpInfo(userGuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read user Use this endpoint to read the attributes of a specific user.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of UserResponseBody</returns>
        public ApiResponse< UserResponseBody > ReadUserWithHttpInfo (string userGuid)
        {
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling UsersApi->ReadUser");

            var localVarPath = "/users/{user_guid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.mx.atrium.v1+json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userGuid != null) localVarPathParams.Add("user_guid", this.Configuration.ApiClient.ParameterToString(userGuid)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-API-Key")))
            {
                localVarHeaderParams["MX-API-Key"] = this.Configuration.GetApiKeyWithPrefix("MX-API-Key");
            }
            // authentication (clientID) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-Client-ID")))
            {
                localVarHeaderParams["MX-Client-ID"] = this.Configuration.GetApiKeyWithPrefix("MX-Client-ID");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReadUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserResponseBody)));
        }

        /// <summary>
        /// Read user Use this endpoint to read the attributes of a specific user.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of UserResponseBody</returns>
        public async System.Threading.Tasks.Task<UserResponseBody> ReadUserAsync (string userGuid)
        {
             ApiResponse<UserResponseBody> localVarResponse = await ReadUserAsyncWithHttpInfo(userGuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read user Use this endpoint to read the attributes of a specific user.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse (UserResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserResponseBody>> ReadUserAsyncWithHttpInfo (string userGuid)
        {
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling UsersApi->ReadUser");

            var localVarPath = "/users/{user_guid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.mx.atrium.v1+json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userGuid != null) localVarPathParams.Add("user_guid", this.Configuration.ApiClient.ParameterToString(userGuid)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-API-Key")))
            {
                localVarHeaderParams["MX-API-Key"] = this.Configuration.GetApiKeyWithPrefix("MX-API-Key");
            }
            // authentication (clientID) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-Client-ID")))
            {
                localVarHeaderParams["MX-Client-ID"] = this.Configuration.GetApiKeyWithPrefix("MX-Client-ID");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReadUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserResponseBody)));
        }

        /// <summary>
        /// Update user Use this endpoint to update the attributes of a specific user. Atrium will respond with the updated user object.&lt;br&gt; Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user&#39;s data until they are no longer disabled. Users who are disabled for the entirety of an Atrium billing period will not be factored into that month&#39;s bill.&lt;br&gt; To disable a user, update it and set the is_disabled parameter to true. Set it to false to re-enable the user. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="body">User object to be updated with optional parameters (identifier, is_disabled, metadata) (optional)</param>
        /// <returns>UserResponseBody</returns>
        public UserResponseBody UpdateUser (string userGuid, UserUpdateRequestBody body = null)
        {
             ApiResponse<UserResponseBody> localVarResponse = UpdateUserWithHttpInfo(userGuid, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update user Use this endpoint to update the attributes of a specific user. Atrium will respond with the updated user object.&lt;br&gt; Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user&#39;s data until they are no longer disabled. Users who are disabled for the entirety of an Atrium billing period will not be factored into that month&#39;s bill.&lt;br&gt; To disable a user, update it and set the is_disabled parameter to true. Set it to false to re-enable the user. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="body">User object to be updated with optional parameters (identifier, is_disabled, metadata) (optional)</param>
        /// <returns>ApiResponse of UserResponseBody</returns>
        public ApiResponse< UserResponseBody > UpdateUserWithHttpInfo (string userGuid, UserUpdateRequestBody body = null)
        {
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling UsersApi->UpdateUser");

            var localVarPath = "/users/{user_guid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.mx.atrium.v1+json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userGuid != null) localVarPathParams.Add("user_guid", this.Configuration.ApiClient.ParameterToString(userGuid)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-API-Key")))
            {
                localVarHeaderParams["MX-API-Key"] = this.Configuration.GetApiKeyWithPrefix("MX-API-Key");
            }
            // authentication (clientID) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-Client-ID")))
            {
                localVarHeaderParams["MX-Client-ID"] = this.Configuration.GetApiKeyWithPrefix("MX-Client-ID");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserResponseBody)));
        }

        /// <summary>
        /// Update user Use this endpoint to update the attributes of a specific user. Atrium will respond with the updated user object.&lt;br&gt; Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user&#39;s data until they are no longer disabled. Users who are disabled for the entirety of an Atrium billing period will not be factored into that month&#39;s bill.&lt;br&gt; To disable a user, update it and set the is_disabled parameter to true. Set it to false to re-enable the user. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="body">User object to be updated with optional parameters (identifier, is_disabled, metadata) (optional)</param>
        /// <returns>Task of UserResponseBody</returns>
        public async System.Threading.Tasks.Task<UserResponseBody> UpdateUserAsync (string userGuid, UserUpdateRequestBody body = null)
        {
             ApiResponse<UserResponseBody> localVarResponse = await UpdateUserAsyncWithHttpInfo(userGuid, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update user Use this endpoint to update the attributes of a specific user. Atrium will respond with the updated user object.&lt;br&gt; Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user&#39;s data until they are no longer disabled. Users who are disabled for the entirety of an Atrium billing period will not be factored into that month&#39;s bill.&lt;br&gt; To disable a user, update it and set the is_disabled parameter to true. Set it to false to re-enable the user. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="body">User object to be updated with optional parameters (identifier, is_disabled, metadata) (optional)</param>
        /// <returns>Task of ApiResponse (UserResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserResponseBody>> UpdateUserAsyncWithHttpInfo (string userGuid, UserUpdateRequestBody body = null)
        {
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling UsersApi->UpdateUser");

            var localVarPath = "/users/{user_guid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.mx.atrium.v1+json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userGuid != null) localVarPathParams.Add("user_guid", this.Configuration.ApiClient.ParameterToString(userGuid)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-API-Key")))
            {
                localVarHeaderParams["MX-API-Key"] = this.Configuration.GetApiKeyWithPrefix("MX-API-Key");
            }
            // authentication (clientID) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("MX-Client-ID")))
            {
                localVarHeaderParams["MX-Client-ID"] = this.Configuration.GetApiKeyWithPrefix("MX-Client-ID");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserResponseBody)));
        }

    }
}
