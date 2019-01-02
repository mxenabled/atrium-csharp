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
    public interface IMerchantsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Read merchant
        /// </summary>
        /// <remarks>
        /// Returns information about a particular merchant, such as a logo, name, and website.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <returns>MerchantResponseBody</returns>
        MerchantResponseBody ReadMerchant (string merchantGuid);

        /// <summary>
        /// Read merchant
        /// </summary>
        /// <remarks>
        /// Returns information about a particular merchant, such as a logo, name, and website.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <returns>ApiResponse of MerchantResponseBody</returns>
        ApiResponse<MerchantResponseBody> ReadMerchantWithHttpInfo (string merchantGuid);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Read merchant
        /// </summary>
        /// <remarks>
        /// Returns information about a particular merchant, such as a logo, name, and website.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <returns>Task of MerchantResponseBody</returns>
        System.Threading.Tasks.Task<MerchantResponseBody> ReadMerchantAsync (string merchantGuid);

        /// <summary>
        /// Read merchant
        /// </summary>
        /// <remarks>
        /// Returns information about a particular merchant, such as a logo, name, and website.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <returns>Task of ApiResponse (MerchantResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<MerchantResponseBody>> ReadMerchantAsyncWithHttpInfo (string merchantGuid);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MerchantsApi : IMerchantsApi
    {
        private Atrium.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MerchantsApi(String basePath)
        {
            this.Configuration = new Atrium.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Atrium.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MerchantsApi(Atrium.Client.Configuration configuration = null)
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
        /// Read merchant Returns information about a particular merchant, such as a logo, name, and website.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <returns>MerchantResponseBody</returns>
        public MerchantResponseBody ReadMerchant (string merchantGuid)
        {
             ApiResponse<MerchantResponseBody> localVarResponse = ReadMerchantWithHttpInfo(merchantGuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read merchant Returns information about a particular merchant, such as a logo, name, and website.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <returns>ApiResponse of MerchantResponseBody</returns>
        public ApiResponse< MerchantResponseBody > ReadMerchantWithHttpInfo (string merchantGuid)
        {
            // verify the required parameter 'merchantGuid' is set
            if (merchantGuid == null)
                throw new ApiException(400, "Missing required parameter 'merchantGuid' when calling MerchantsApi->ReadMerchant");

            var localVarPath = "/merchants/{merchant_guid}";
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

            if (merchantGuid != null) localVarPathParams.Add("merchant_guid", this.Configuration.ApiClient.ParameterToString(merchantGuid)); // path parameter

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
                Exception exception = ExceptionFactory("ReadMerchant", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MerchantResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MerchantResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MerchantResponseBody)));
        }

        /// <summary>
        /// Read merchant Returns information about a particular merchant, such as a logo, name, and website.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <returns>Task of MerchantResponseBody</returns>
        public async System.Threading.Tasks.Task<MerchantResponseBody> ReadMerchantAsync (string merchantGuid)
        {
             ApiResponse<MerchantResponseBody> localVarResponse = await ReadMerchantAsyncWithHttpInfo(merchantGuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read merchant Returns information about a particular merchant, such as a logo, name, and website.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <returns>Task of ApiResponse (MerchantResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MerchantResponseBody>> ReadMerchantAsyncWithHttpInfo (string merchantGuid)
        {
            // verify the required parameter 'merchantGuid' is set
            if (merchantGuid == null)
                throw new ApiException(400, "Missing required parameter 'merchantGuid' when calling MerchantsApi->ReadMerchant");

            var localVarPath = "/merchants/{merchant_guid}";
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

            if (merchantGuid != null) localVarPathParams.Add("merchant_guid", this.Configuration.ApiClient.ParameterToString(merchantGuid)); // path parameter

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
                Exception exception = ExceptionFactory("ReadMerchant", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MerchantResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MerchantResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MerchantResponseBody)));
        }

    }
}
