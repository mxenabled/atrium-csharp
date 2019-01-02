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
    public interface IHoldingsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List holdings
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read all holdings associated with a specific user.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>HoldingsResponseBody</returns>
        HoldingsResponseBody ListHoldings (string userGuid);

        /// <summary>
        /// List holdings
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read all holdings associated with a specific user.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of HoldingsResponseBody</returns>
        ApiResponse<HoldingsResponseBody> ListHoldingsWithHttpInfo (string userGuid);
        /// <summary>
        /// List holdings by account
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read all holdings associated with a specific account.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>HoldingsResponseBody</returns>
        HoldingsResponseBody ListHoldingsByAccount (string accountGuid, string userGuid);

        /// <summary>
        /// List holdings by account
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read all holdings associated with a specific account.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of HoldingsResponseBody</returns>
        ApiResponse<HoldingsResponseBody> ListHoldingsByAccountWithHttpInfo (string accountGuid, string userGuid);
        /// <summary>
        /// List holdings by member
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read all holdings associated with a specific member.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>HoldingsResponseBody</returns>
        HoldingsResponseBody ListHoldingsByMember (string memberGuid, string userGuid);

        /// <summary>
        /// List holdings by member
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read all holdings associated with a specific member.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of HoldingsResponseBody</returns>
        ApiResponse<HoldingsResponseBody> ListHoldingsByMemberWithHttpInfo (string memberGuid, string userGuid);
        /// <summary>
        /// Read holding
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read the attributes of a specific holding.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="holdingGuid">The unique identifier for a &#x60;holding&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>HoldingResponseBody</returns>
        HoldingResponseBody ReadHolding (string holdingGuid, string userGuid);

        /// <summary>
        /// Read holding
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read the attributes of a specific holding.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="holdingGuid">The unique identifier for a &#x60;holding&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of HoldingResponseBody</returns>
        ApiResponse<HoldingResponseBody> ReadHoldingWithHttpInfo (string holdingGuid, string userGuid);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// List holdings
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read all holdings associated with a specific user.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of HoldingsResponseBody</returns>
        System.Threading.Tasks.Task<HoldingsResponseBody> ListHoldingsAsync (string userGuid);

        /// <summary>
        /// List holdings
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read all holdings associated with a specific user.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse (HoldingsResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<HoldingsResponseBody>> ListHoldingsAsyncWithHttpInfo (string userGuid);
        /// <summary>
        /// List holdings by account
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read all holdings associated with a specific account.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of HoldingsResponseBody</returns>
        System.Threading.Tasks.Task<HoldingsResponseBody> ListHoldingsByAccountAsync (string accountGuid, string userGuid);

        /// <summary>
        /// List holdings by account
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read all holdings associated with a specific account.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse (HoldingsResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<HoldingsResponseBody>> ListHoldingsByAccountAsyncWithHttpInfo (string accountGuid, string userGuid);
        /// <summary>
        /// List holdings by member
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read all holdings associated with a specific member.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of HoldingsResponseBody</returns>
        System.Threading.Tasks.Task<HoldingsResponseBody> ListHoldingsByMemberAsync (string memberGuid, string userGuid);

        /// <summary>
        /// List holdings by member
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read all holdings associated with a specific member.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse (HoldingsResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<HoldingsResponseBody>> ListHoldingsByMemberAsyncWithHttpInfo (string memberGuid, string userGuid);
        /// <summary>
        /// Read holding
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read the attributes of a specific holding.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="holdingGuid">The unique identifier for a &#x60;holding&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of HoldingResponseBody</returns>
        System.Threading.Tasks.Task<HoldingResponseBody> ReadHoldingAsync (string holdingGuid, string userGuid);

        /// <summary>
        /// Read holding
        /// </summary>
        /// <remarks>
        /// Use this endpoint to read the attributes of a specific holding.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="holdingGuid">The unique identifier for a &#x60;holding&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse (HoldingResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<HoldingResponseBody>> ReadHoldingAsyncWithHttpInfo (string holdingGuid, string userGuid);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class HoldingsApi : IHoldingsApi
    {
        private Atrium.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="HoldingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HoldingsApi(String basePath)
        {
            this.Configuration = new Atrium.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Atrium.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HoldingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public HoldingsApi(Atrium.Client.Configuration configuration = null)
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
        /// List holdings Use this endpoint to read all holdings associated with a specific user.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>HoldingsResponseBody</returns>
        public HoldingsResponseBody ListHoldings (string userGuid)
        {
             ApiResponse<HoldingsResponseBody> localVarResponse = ListHoldingsWithHttpInfo(userGuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List holdings Use this endpoint to read all holdings associated with a specific user.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of HoldingsResponseBody</returns>
        public ApiResponse< HoldingsResponseBody > ListHoldingsWithHttpInfo (string userGuid)
        {
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling HoldingsApi->ListHoldings");

            var localVarPath = "/users/{user_guid}/holdings";
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
                Exception exception = ExceptionFactory("ListHoldings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<HoldingsResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HoldingsResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(HoldingsResponseBody)));
        }

        /// <summary>
        /// List holdings Use this endpoint to read all holdings associated with a specific user.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of HoldingsResponseBody</returns>
        public async System.Threading.Tasks.Task<HoldingsResponseBody> ListHoldingsAsync (string userGuid)
        {
             ApiResponse<HoldingsResponseBody> localVarResponse = await ListHoldingsAsyncWithHttpInfo(userGuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List holdings Use this endpoint to read all holdings associated with a specific user.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse (HoldingsResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HoldingsResponseBody>> ListHoldingsAsyncWithHttpInfo (string userGuid)
        {
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling HoldingsApi->ListHoldings");

            var localVarPath = "/users/{user_guid}/holdings";
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
                Exception exception = ExceptionFactory("ListHoldings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<HoldingsResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HoldingsResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(HoldingsResponseBody)));
        }

        /// <summary>
        /// List holdings by account Use this endpoint to read all holdings associated with a specific account.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>HoldingsResponseBody</returns>
        public HoldingsResponseBody ListHoldingsByAccount (string accountGuid, string userGuid)
        {
             ApiResponse<HoldingsResponseBody> localVarResponse = ListHoldingsByAccountWithHttpInfo(accountGuid, userGuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List holdings by account Use this endpoint to read all holdings associated with a specific account.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of HoldingsResponseBody</returns>
        public ApiResponse< HoldingsResponseBody > ListHoldingsByAccountWithHttpInfo (string accountGuid, string userGuid)
        {
            // verify the required parameter 'accountGuid' is set
            if (accountGuid == null)
                throw new ApiException(400, "Missing required parameter 'accountGuid' when calling HoldingsApi->ListHoldingsByAccount");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling HoldingsApi->ListHoldingsByAccount");

            var localVarPath = "/users/{user_guid}/accounts/{account_guid}/holdings";
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

            if (accountGuid != null) localVarPathParams.Add("account_guid", this.Configuration.ApiClient.ParameterToString(accountGuid)); // path parameter
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
                Exception exception = ExceptionFactory("ListHoldingsByAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<HoldingsResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HoldingsResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(HoldingsResponseBody)));
        }

        /// <summary>
        /// List holdings by account Use this endpoint to read all holdings associated with a specific account.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of HoldingsResponseBody</returns>
        public async System.Threading.Tasks.Task<HoldingsResponseBody> ListHoldingsByAccountAsync (string accountGuid, string userGuid)
        {
             ApiResponse<HoldingsResponseBody> localVarResponse = await ListHoldingsByAccountAsyncWithHttpInfo(accountGuid, userGuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List holdings by account Use this endpoint to read all holdings associated with a specific account.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse (HoldingsResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HoldingsResponseBody>> ListHoldingsByAccountAsyncWithHttpInfo (string accountGuid, string userGuid)
        {
            // verify the required parameter 'accountGuid' is set
            if (accountGuid == null)
                throw new ApiException(400, "Missing required parameter 'accountGuid' when calling HoldingsApi->ListHoldingsByAccount");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling HoldingsApi->ListHoldingsByAccount");

            var localVarPath = "/users/{user_guid}/accounts/{account_guid}/holdings";
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

            if (accountGuid != null) localVarPathParams.Add("account_guid", this.Configuration.ApiClient.ParameterToString(accountGuid)); // path parameter
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
                Exception exception = ExceptionFactory("ListHoldingsByAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<HoldingsResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HoldingsResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(HoldingsResponseBody)));
        }

        /// <summary>
        /// List holdings by member Use this endpoint to read all holdings associated with a specific member.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>HoldingsResponseBody</returns>
        public HoldingsResponseBody ListHoldingsByMember (string memberGuid, string userGuid)
        {
             ApiResponse<HoldingsResponseBody> localVarResponse = ListHoldingsByMemberWithHttpInfo(memberGuid, userGuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List holdings by member Use this endpoint to read all holdings associated with a specific member.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of HoldingsResponseBody</returns>
        public ApiResponse< HoldingsResponseBody > ListHoldingsByMemberWithHttpInfo (string memberGuid, string userGuid)
        {
            // verify the required parameter 'memberGuid' is set
            if (memberGuid == null)
                throw new ApiException(400, "Missing required parameter 'memberGuid' when calling HoldingsApi->ListHoldingsByMember");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling HoldingsApi->ListHoldingsByMember");

            var localVarPath = "/users/{user_guid}/members/{member_guid}/holdings";
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

            if (memberGuid != null) localVarPathParams.Add("member_guid", this.Configuration.ApiClient.ParameterToString(memberGuid)); // path parameter
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
                Exception exception = ExceptionFactory("ListHoldingsByMember", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<HoldingsResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HoldingsResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(HoldingsResponseBody)));
        }

        /// <summary>
        /// List holdings by member Use this endpoint to read all holdings associated with a specific member.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of HoldingsResponseBody</returns>
        public async System.Threading.Tasks.Task<HoldingsResponseBody> ListHoldingsByMemberAsync (string memberGuid, string userGuid)
        {
             ApiResponse<HoldingsResponseBody> localVarResponse = await ListHoldingsByMemberAsyncWithHttpInfo(memberGuid, userGuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List holdings by member Use this endpoint to read all holdings associated with a specific member.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse (HoldingsResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HoldingsResponseBody>> ListHoldingsByMemberAsyncWithHttpInfo (string memberGuid, string userGuid)
        {
            // verify the required parameter 'memberGuid' is set
            if (memberGuid == null)
                throw new ApiException(400, "Missing required parameter 'memberGuid' when calling HoldingsApi->ListHoldingsByMember");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling HoldingsApi->ListHoldingsByMember");

            var localVarPath = "/users/{user_guid}/members/{member_guid}/holdings";
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

            if (memberGuid != null) localVarPathParams.Add("member_guid", this.Configuration.ApiClient.ParameterToString(memberGuid)); // path parameter
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
                Exception exception = ExceptionFactory("ListHoldingsByMember", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<HoldingsResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HoldingsResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(HoldingsResponseBody)));
        }

        /// <summary>
        /// Read holding Use this endpoint to read the attributes of a specific holding.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="holdingGuid">The unique identifier for a &#x60;holding&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>HoldingResponseBody</returns>
        public HoldingResponseBody ReadHolding (string holdingGuid, string userGuid)
        {
             ApiResponse<HoldingResponseBody> localVarResponse = ReadHoldingWithHttpInfo(holdingGuid, userGuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read holding Use this endpoint to read the attributes of a specific holding.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="holdingGuid">The unique identifier for a &#x60;holding&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of HoldingResponseBody</returns>
        public ApiResponse< HoldingResponseBody > ReadHoldingWithHttpInfo (string holdingGuid, string userGuid)
        {
            // verify the required parameter 'holdingGuid' is set
            if (holdingGuid == null)
                throw new ApiException(400, "Missing required parameter 'holdingGuid' when calling HoldingsApi->ReadHolding");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling HoldingsApi->ReadHolding");

            var localVarPath = "/users/{user_guid}/holdings/{holding_guid}";
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

            if (holdingGuid != null) localVarPathParams.Add("holding_guid", this.Configuration.ApiClient.ParameterToString(holdingGuid)); // path parameter
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
                Exception exception = ExceptionFactory("ReadHolding", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<HoldingResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HoldingResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(HoldingResponseBody)));
        }

        /// <summary>
        /// Read holding Use this endpoint to read the attributes of a specific holding.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="holdingGuid">The unique identifier for a &#x60;holding&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of HoldingResponseBody</returns>
        public async System.Threading.Tasks.Task<HoldingResponseBody> ReadHoldingAsync (string holdingGuid, string userGuid)
        {
             ApiResponse<HoldingResponseBody> localVarResponse = await ReadHoldingAsyncWithHttpInfo(holdingGuid, userGuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read holding Use this endpoint to read the attributes of a specific holding.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="holdingGuid">The unique identifier for a &#x60;holding&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse (HoldingResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HoldingResponseBody>> ReadHoldingAsyncWithHttpInfo (string holdingGuid, string userGuid)
        {
            // verify the required parameter 'holdingGuid' is set
            if (holdingGuid == null)
                throw new ApiException(400, "Missing required parameter 'holdingGuid' when calling HoldingsApi->ReadHolding");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling HoldingsApi->ReadHolding");

            var localVarPath = "/users/{user_guid}/holdings/{holding_guid}";
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

            if (holdingGuid != null) localVarPathParams.Add("holding_guid", this.Configuration.ApiClient.ParameterToString(holdingGuid)); // path parameter
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
                Exception exception = ExceptionFactory("ReadHolding", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<HoldingResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HoldingResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(HoldingResponseBody)));
        }

    }
}
