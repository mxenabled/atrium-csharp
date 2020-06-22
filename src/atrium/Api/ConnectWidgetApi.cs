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
    public interface IConnectWidgetApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Embedding in a website
        /// </summary>
        /// <remarks>
        /// This endpoint will return a URL for an embeddable version of MX Connect.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="body">Optional config options for WebView (is_mobile_webview, current_institution_code, current_member_guid, update_credentials)</param>
        /// <returns>ConnectWidgetResponseBody</returns>
        ConnectWidgetResponseBody GetConnectWidget (string userGuid, ConnectWidgetRequestBody body);

        /// <summary>
        /// Embedding in a website
        /// </summary>
        /// <remarks>
        /// This endpoint will return a URL for an embeddable version of MX Connect.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="body">Optional config options for WebView (is_mobile_webview, current_institution_code, current_member_guid, update_credentials)</param>
        /// <returns>ApiResponse of ConnectWidgetResponseBody</returns>
        ApiResponse<ConnectWidgetResponseBody> GetConnectWidgetWithHttpInfo (string userGuid, ConnectWidgetRequestBody body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Embedding in a website
        /// </summary>
        /// <remarks>
        /// This endpoint will return a URL for an embeddable version of MX Connect.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="body">Optional config options for WebView (is_mobile_webview, current_institution_code, current_member_guid, update_credentials)</param>
        /// <returns>Task of ConnectWidgetResponseBody</returns>
        System.Threading.Tasks.Task<ConnectWidgetResponseBody> GetConnectWidgetAsync (string userGuid, ConnectWidgetRequestBody body);

        /// <summary>
        /// Embedding in a website
        /// </summary>
        /// <remarks>
        /// This endpoint will return a URL for an embeddable version of MX Connect.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="body">Optional config options for WebView (is_mobile_webview, current_institution_code, current_member_guid, update_credentials)</param>
        /// <returns>Task of ApiResponse (ConnectWidgetResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConnectWidgetResponseBody>> GetConnectWidgetAsyncWithHttpInfo (string userGuid, ConnectWidgetRequestBody body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ConnectWidgetApi : IConnectWidgetApi
    {
        private Atrium.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectWidgetApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectWidgetApi(String apiKey, String clientID, String basePath)
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
        /// Initializes a new instance of the <see cref="ConnectWidgetApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConnectWidgetApi(Atrium.Client.Configuration configuration = null)
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
        /// Embedding in a website This endpoint will return a URL for an embeddable version of MX Connect.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="body">Optional config options for WebView (is_mobile_webview, current_institution_code, current_member_guid, update_credentials)</param>
        /// <returns>ConnectWidgetResponseBody</returns>
        public ConnectWidgetResponseBody GetConnectWidget (string userGuid, ConnectWidgetRequestBody body)
        {
             ApiResponse<ConnectWidgetResponseBody> localVarResponse = GetConnectWidgetWithHttpInfo(userGuid, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Embedding in a website This endpoint will return a URL for an embeddable version of MX Connect.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="body">Optional config options for WebView (is_mobile_webview, current_institution_code, current_member_guid, update_credentials)</param>
        /// <returns>ApiResponse of ConnectWidgetResponseBody</returns>
        public ApiResponse< ConnectWidgetResponseBody > GetConnectWidgetWithHttpInfo (string userGuid, ConnectWidgetRequestBody body)
        {
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling ConnectWidgetApi->GetConnectWidget");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConnectWidgetApi->GetConnectWidget");

            var localVarPath = "/users/{user_guid}/connect_widget_url";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetConnectWidget", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ConnectWidgetResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConnectWidgetResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConnectWidgetResponseBody)));
        }

        /// <summary>
        /// Embedding in a website This endpoint will return a URL for an embeddable version of MX Connect.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="body">Optional config options for WebView (is_mobile_webview, current_institution_code, current_member_guid, update_credentials)</param>
        /// <returns>Task of ConnectWidgetResponseBody</returns>
        public async System.Threading.Tasks.Task<ConnectWidgetResponseBody> GetConnectWidgetAsync (string userGuid, ConnectWidgetRequestBody body)
        {
             ApiResponse<ConnectWidgetResponseBody> localVarResponse = await GetConnectWidgetAsyncWithHttpInfo(userGuid, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Embedding in a website This endpoint will return a URL for an embeddable version of MX Connect.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="body">Optional config options for WebView (is_mobile_webview, current_institution_code, current_member_guid, update_credentials)</param>
        /// <returns>Task of ApiResponse (ConnectWidgetResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConnectWidgetResponseBody>> GetConnectWidgetAsyncWithHttpInfo (string userGuid, ConnectWidgetRequestBody body)
        {
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling ConnectWidgetApi->GetConnectWidget");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConnectWidgetApi->GetConnectWidget");

            var localVarPath = "/users/{user_guid}/connect_widget_url";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetConnectWidget", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ConnectWidgetResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConnectWidgetResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConnectWidgetResponseBody)));
        }

    }
}
