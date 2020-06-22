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
        /// List merchant locations
        /// </summary>
        /// <remarks>
        /// Returns a list of all the merchant locations associated with a merchant, including physical location, latitude, longitude, etc.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <returns>MerchantLocationsResponseBody</returns>
        MerchantLocationsResponseBody ListMerchantLocations (string merchantGuid);

        /// <summary>
        /// List merchant locations
        /// </summary>
        /// <remarks>
        /// Returns a list of all the merchant locations associated with a merchant, including physical location, latitude, longitude, etc.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <returns>ApiResponse of MerchantLocationsResponseBody</returns>
        ApiResponse<MerchantLocationsResponseBody> ListMerchantLocationsWithHttpInfo (string merchantGuid);
        /// <summary>
        /// List merchants
        /// </summary>
        /// <remarks>
        /// Returns a list of merchnants.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MerchantsResponseBody</returns>
        MerchantsResponseBody ListMerchants ();

        /// <summary>
        /// List merchants
        /// </summary>
        /// <remarks>
        /// Returns a list of merchnants.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MerchantsResponseBody</returns>
        ApiResponse<MerchantsResponseBody> ListMerchantsWithHttpInfo ();
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
        /// <summary>
        /// Read merchant location
        /// </summary>
        /// <remarks>
        /// Retuns a specific location associated with a merchant, including physical location, latitude, longitude, etc.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <param name="merchantLocationGuid">The unique identifier for a &#x60;merchant_location&#x60;.</param>
        /// <returns>MerchantLocationResponseBody</returns>
        MerchantLocationResponseBody ReadMerchantLocation (string merchantGuid, string merchantLocationGuid);

        /// <summary>
        /// Read merchant location
        /// </summary>
        /// <remarks>
        /// Retuns a specific location associated with a merchant, including physical location, latitude, longitude, etc.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <param name="merchantLocationGuid">The unique identifier for a &#x60;merchant_location&#x60;.</param>
        /// <returns>ApiResponse of MerchantLocationResponseBody</returns>
        ApiResponse<MerchantLocationResponseBody> ReadMerchantLocationWithHttpInfo (string merchantGuid, string merchantLocationGuid);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// List merchant locations
        /// </summary>
        /// <remarks>
        /// Returns a list of all the merchant locations associated with a merchant, including physical location, latitude, longitude, etc.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <returns>Task of MerchantLocationsResponseBody</returns>
        System.Threading.Tasks.Task<MerchantLocationsResponseBody> ListMerchantLocationsAsync (string merchantGuid);

        /// <summary>
        /// List merchant locations
        /// </summary>
        /// <remarks>
        /// Returns a list of all the merchant locations associated with a merchant, including physical location, latitude, longitude, etc.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <returns>Task of ApiResponse (MerchantLocationsResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<MerchantLocationsResponseBody>> ListMerchantLocationsAsyncWithHttpInfo (string merchantGuid);
        /// <summary>
        /// List merchants
        /// </summary>
        /// <remarks>
        /// Returns a list of merchnants.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MerchantsResponseBody</returns>
        System.Threading.Tasks.Task<MerchantsResponseBody> ListMerchantsAsync ();

        /// <summary>
        /// List merchants
        /// </summary>
        /// <remarks>
        /// Returns a list of merchnants.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MerchantsResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<MerchantsResponseBody>> ListMerchantsAsyncWithHttpInfo ();
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
        /// <summary>
        /// Read merchant location
        /// </summary>
        /// <remarks>
        /// Retuns a specific location associated with a merchant, including physical location, latitude, longitude, etc.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <param name="merchantLocationGuid">The unique identifier for a &#x60;merchant_location&#x60;.</param>
        /// <returns>Task of MerchantLocationResponseBody</returns>
        System.Threading.Tasks.Task<MerchantLocationResponseBody> ReadMerchantLocationAsync (string merchantGuid, string merchantLocationGuid);

        /// <summary>
        /// Read merchant location
        /// </summary>
        /// <remarks>
        /// Retuns a specific location associated with a merchant, including physical location, latitude, longitude, etc.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <param name="merchantLocationGuid">The unique identifier for a &#x60;merchant_location&#x60;.</param>
        /// <returns>Task of ApiResponse (MerchantLocationResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<MerchantLocationResponseBody>> ReadMerchantLocationAsyncWithHttpInfo (string merchantGuid, string merchantLocationGuid);
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
        public MerchantsApi(String apiKey, String clientID, String basePath)
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
        /// List merchant locations Returns a list of all the merchant locations associated with a merchant, including physical location, latitude, longitude, etc.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <returns>MerchantLocationsResponseBody</returns>
        public MerchantLocationsResponseBody ListMerchantLocations (string merchantGuid)
        {
             ApiResponse<MerchantLocationsResponseBody> localVarResponse = ListMerchantLocationsWithHttpInfo(merchantGuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List merchant locations Returns a list of all the merchant locations associated with a merchant, including physical location, latitude, longitude, etc.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <returns>ApiResponse of MerchantLocationsResponseBody</returns>
        public ApiResponse< MerchantLocationsResponseBody > ListMerchantLocationsWithHttpInfo (string merchantGuid)
        {
            // verify the required parameter 'merchantGuid' is set
            if (merchantGuid == null)
                throw new ApiException(400, "Missing required parameter 'merchantGuid' when calling MerchantsApi->ListMerchantLocations");

            var localVarPath = "/merchants/{merchant_guid}/merchant_locations";
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
                Exception exception = ExceptionFactory("ListMerchantLocations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MerchantLocationsResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MerchantLocationsResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MerchantLocationsResponseBody)));
        }

        /// <summary>
        /// List merchant locations Returns a list of all the merchant locations associated with a merchant, including physical location, latitude, longitude, etc.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <returns>Task of MerchantLocationsResponseBody</returns>
        public async System.Threading.Tasks.Task<MerchantLocationsResponseBody> ListMerchantLocationsAsync (string merchantGuid)
        {
             ApiResponse<MerchantLocationsResponseBody> localVarResponse = await ListMerchantLocationsAsyncWithHttpInfo(merchantGuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List merchant locations Returns a list of all the merchant locations associated with a merchant, including physical location, latitude, longitude, etc.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <returns>Task of ApiResponse (MerchantLocationsResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MerchantLocationsResponseBody>> ListMerchantLocationsAsyncWithHttpInfo (string merchantGuid)
        {
            // verify the required parameter 'merchantGuid' is set
            if (merchantGuid == null)
                throw new ApiException(400, "Missing required parameter 'merchantGuid' when calling MerchantsApi->ListMerchantLocations");

            var localVarPath = "/merchants/{merchant_guid}/merchant_locations";
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
                Exception exception = ExceptionFactory("ListMerchantLocations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MerchantLocationsResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MerchantLocationsResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MerchantLocationsResponseBody)));
        }

        /// <summary>
        /// List merchants Returns a list of merchnants.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MerchantsResponseBody</returns>
        public MerchantsResponseBody ListMerchants ()
        {
             ApiResponse<MerchantsResponseBody> localVarResponse = ListMerchantsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List merchants Returns a list of merchnants.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MerchantsResponseBody</returns>
        public ApiResponse< MerchantsResponseBody > ListMerchantsWithHttpInfo ()
        {

            var localVarPath = "/merchants";
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
                Exception exception = ExceptionFactory("ListMerchants", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MerchantsResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MerchantsResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MerchantsResponseBody)));
        }

        /// <summary>
        /// List merchants Returns a list of merchnants.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MerchantsResponseBody</returns>
        public async System.Threading.Tasks.Task<MerchantsResponseBody> ListMerchantsAsync ()
        {
             ApiResponse<MerchantsResponseBody> localVarResponse = await ListMerchantsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List merchants Returns a list of merchnants.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MerchantsResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MerchantsResponseBody>> ListMerchantsAsyncWithHttpInfo ()
        {

            var localVarPath = "/merchants";
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
                Exception exception = ExceptionFactory("ListMerchants", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MerchantsResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MerchantsResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MerchantsResponseBody)));
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

        /// <summary>
        /// Read merchant location Retuns a specific location associated with a merchant, including physical location, latitude, longitude, etc.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <param name="merchantLocationGuid">The unique identifier for a &#x60;merchant_location&#x60;.</param>
        /// <returns>MerchantLocationResponseBody</returns>
        public MerchantLocationResponseBody ReadMerchantLocation (string merchantGuid, string merchantLocationGuid)
        {
             ApiResponse<MerchantLocationResponseBody> localVarResponse = ReadMerchantLocationWithHttpInfo(merchantGuid, merchantLocationGuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read merchant location Retuns a specific location associated with a merchant, including physical location, latitude, longitude, etc.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <param name="merchantLocationGuid">The unique identifier for a &#x60;merchant_location&#x60;.</param>
        /// <returns>ApiResponse of MerchantLocationResponseBody</returns>
        public ApiResponse< MerchantLocationResponseBody > ReadMerchantLocationWithHttpInfo (string merchantGuid, string merchantLocationGuid)
        {
            // verify the required parameter 'merchantGuid' is set
            if (merchantGuid == null)
                throw new ApiException(400, "Missing required parameter 'merchantGuid' when calling MerchantsApi->ReadMerchantLocation");
            // verify the required parameter 'merchantLocationGuid' is set
            if (merchantLocationGuid == null)
                throw new ApiException(400, "Missing required parameter 'merchantLocationGuid' when calling MerchantsApi->ReadMerchantLocation");

            var localVarPath = "/merchants/{merchant_guid}/merchant_locations/{merchant_location_guid}";
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
            if (merchantLocationGuid != null) localVarPathParams.Add("merchant_location_guid", this.Configuration.ApiClient.ParameterToString(merchantLocationGuid)); // path parameter

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
                Exception exception = ExceptionFactory("ReadMerchantLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MerchantLocationResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MerchantLocationResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MerchantLocationResponseBody)));
        }

        /// <summary>
        /// Read merchant location Retuns a specific location associated with a merchant, including physical location, latitude, longitude, etc.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <param name="merchantLocationGuid">The unique identifier for a &#x60;merchant_location&#x60;.</param>
        /// <returns>Task of MerchantLocationResponseBody</returns>
        public async System.Threading.Tasks.Task<MerchantLocationResponseBody> ReadMerchantLocationAsync (string merchantGuid, string merchantLocationGuid)
        {
             ApiResponse<MerchantLocationResponseBody> localVarResponse = await ReadMerchantLocationAsyncWithHttpInfo(merchantGuid, merchantLocationGuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read merchant location Retuns a specific location associated with a merchant, including physical location, latitude, longitude, etc.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantGuid">The unique identifier for a &#x60;merchant&#x60;.</param>
        /// <param name="merchantLocationGuid">The unique identifier for a &#x60;merchant_location&#x60;.</param>
        /// <returns>Task of ApiResponse (MerchantLocationResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MerchantLocationResponseBody>> ReadMerchantLocationAsyncWithHttpInfo (string merchantGuid, string merchantLocationGuid)
        {
            // verify the required parameter 'merchantGuid' is set
            if (merchantGuid == null)
                throw new ApiException(400, "Missing required parameter 'merchantGuid' when calling MerchantsApi->ReadMerchantLocation");
            // verify the required parameter 'merchantLocationGuid' is set
            if (merchantLocationGuid == null)
                throw new ApiException(400, "Missing required parameter 'merchantLocationGuid' when calling MerchantsApi->ReadMerchantLocation");

            var localVarPath = "/merchants/{merchant_guid}/merchant_locations/{merchant_location_guid}";
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
            if (merchantLocationGuid != null) localVarPathParams.Add("merchant_location_guid", this.Configuration.ApiClient.ParameterToString(merchantLocationGuid)); // path parameter

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
                Exception exception = ExceptionFactory("ReadMerchantLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MerchantLocationResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MerchantLocationResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MerchantLocationResponseBody)));
        }

    }
}
