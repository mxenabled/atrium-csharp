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
using atrium.Client;
using atrium.Model;

namespace atrium.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInstitutionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List institutions
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to see what institutions are available for connection. Information returned will include the institution_code assigned to a particular institution, URLs for the financial institution&#39;s logo, and the URL for its website.&lt;br&gt; This endpoint takes an optional query string, name&#x3D;{string}. This will list only institutions in which the appended string appears. 
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">This will list only institutions in which the appended string appears. (optional)</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Institutions</returns>
        Institutions ListInstitutions (string name = null, int? page = null, int? recordsPerPage = null);

        /// <summary>
        /// List institutions
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to see what institutions are available for connection. Information returned will include the institution_code assigned to a particular institution, URLs for the financial institution&#39;s logo, and the URL for its website.&lt;br&gt; This endpoint takes an optional query string, name&#x3D;{string}. This will list only institutions in which the appended string appears. 
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">This will list only institutions in which the appended string appears. (optional)</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>ApiResponse of Institutions</returns>
        ApiResponse<Institutions> ListInstitutionsWithHttpInfo (string name = null, int? page = null, int? recordsPerPage = null);
        /// <summary>
        /// Read institution
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to see information for a specific institution.
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutionCode">The institution_code of the institution.</param>
        /// <returns>Institution</returns>
        Institution ReadInstitution (string institutionCode);

        /// <summary>
        /// Read institution
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to see information for a specific institution.
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutionCode">The institution_code of the institution.</param>
        /// <returns>ApiResponse of Institution</returns>
        ApiResponse<Institution> ReadInstitutionWithHttpInfo (string institutionCode);
        /// <summary>
        /// Read institution credentials
        /// </summary>
        /// <remarks>
        /// Use this endpoint to see which credentials will be needed to create a member for a specific institution.
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutionCode">The institution_code of the institution.</param>
        /// <returns>Credentials</returns>
        Credentials ReadInstitutionCredentials (string institutionCode);

        /// <summary>
        /// Read institution credentials
        /// </summary>
        /// <remarks>
        /// Use this endpoint to see which credentials will be needed to create a member for a specific institution.
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutionCode">The institution_code of the institution.</param>
        /// <returns>ApiResponse of Credentials</returns>
        ApiResponse<Credentials> ReadInstitutionCredentialsWithHttpInfo (string institutionCode);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// List institutions
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to see what institutions are available for connection. Information returned will include the institution_code assigned to a particular institution, URLs for the financial institution&#39;s logo, and the URL for its website.&lt;br&gt; This endpoint takes an optional query string, name&#x3D;{string}. This will list only institutions in which the appended string appears. 
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">This will list only institutions in which the appended string appears. (optional)</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of Institutions</returns>
        System.Threading.Tasks.Task<Institutions> ListInstitutionsAsync (string name = null, int? page = null, int? recordsPerPage = null);

        /// <summary>
        /// List institutions
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to see what institutions are available for connection. Information returned will include the institution_code assigned to a particular institution, URLs for the financial institution&#39;s logo, and the URL for its website.&lt;br&gt; This endpoint takes an optional query string, name&#x3D;{string}. This will list only institutions in which the appended string appears. 
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">This will list only institutions in which the appended string appears. (optional)</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of ApiResponse (Institutions)</returns>
        System.Threading.Tasks.Task<ApiResponse<Institutions>> ListInstitutionsAsyncWithHttpInfo (string name = null, int? page = null, int? recordsPerPage = null);
        /// <summary>
        /// Read institution
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to see information for a specific institution.
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutionCode">The institution_code of the institution.</param>
        /// <returns>Task of Institution</returns>
        System.Threading.Tasks.Task<Institution> ReadInstitutionAsync (string institutionCode);

        /// <summary>
        /// Read institution
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to see information for a specific institution.
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutionCode">The institution_code of the institution.</param>
        /// <returns>Task of ApiResponse (Institution)</returns>
        System.Threading.Tasks.Task<ApiResponse<Institution>> ReadInstitutionAsyncWithHttpInfo (string institutionCode);
        /// <summary>
        /// Read institution credentials
        /// </summary>
        /// <remarks>
        /// Use this endpoint to see which credentials will be needed to create a member for a specific institution.
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutionCode">The institution_code of the institution.</param>
        /// <returns>Task of Credentials</returns>
        System.Threading.Tasks.Task<Credentials> ReadInstitutionCredentialsAsync (string institutionCode);

        /// <summary>
        /// Read institution credentials
        /// </summary>
        /// <remarks>
        /// Use this endpoint to see which credentials will be needed to create a member for a specific institution.
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutionCode">The institution_code of the institution.</param>
        /// <returns>Task of ApiResponse (Credentials)</returns>
        System.Threading.Tasks.Task<ApiResponse<Credentials>> ReadInstitutionCredentialsAsyncWithHttpInfo (string institutionCode);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InstitutionsApi : IInstitutionsApi
    {
        private atrium.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InstitutionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InstitutionsApi(String basePath)
        {
            this.Configuration = new atrium.Client.Configuration { BasePath = basePath };

            ExceptionFactory = atrium.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstitutionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InstitutionsApi(atrium.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = atrium.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = atrium.Client.Configuration.DefaultExceptionFactory;
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
        public atrium.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public atrium.Client.ExceptionFactory ExceptionFactory
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
        /// List institutions This endpoint allows you to see what institutions are available for connection. Information returned will include the institution_code assigned to a particular institution, URLs for the financial institution&#39;s logo, and the URL for its website.&lt;br&gt; This endpoint takes an optional query string, name&#x3D;{string}. This will list only institutions in which the appended string appears. 
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">This will list only institutions in which the appended string appears. (optional)</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Institutions</returns>
        public Institutions ListInstitutions (string name = null, int? page = null, int? recordsPerPage = null)
        {
             ApiResponse<Institutions> localVarResponse = ListInstitutionsWithHttpInfo(name, page, recordsPerPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List institutions This endpoint allows you to see what institutions are available for connection. Information returned will include the institution_code assigned to a particular institution, URLs for the financial institution&#39;s logo, and the URL for its website.&lt;br&gt; This endpoint takes an optional query string, name&#x3D;{string}. This will list only institutions in which the appended string appears. 
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">This will list only institutions in which the appended string appears. (optional)</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>ApiResponse of Institutions</returns>
        public ApiResponse< Institutions > ListInstitutionsWithHttpInfo (string name = null, int? page = null, int? recordsPerPage = null)
        {

            var localVarPath = "/institutions";
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

            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
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
                Exception exception = ExceptionFactory("ListInstitutions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Institutions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Institutions) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Institutions)));
        }

        /// <summary>
        /// List institutions This endpoint allows you to see what institutions are available for connection. Information returned will include the institution_code assigned to a particular institution, URLs for the financial institution&#39;s logo, and the URL for its website.&lt;br&gt; This endpoint takes an optional query string, name&#x3D;{string}. This will list only institutions in which the appended string appears. 
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">This will list only institutions in which the appended string appears. (optional)</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of Institutions</returns>
        public async System.Threading.Tasks.Task<Institutions> ListInstitutionsAsync (string name = null, int? page = null, int? recordsPerPage = null)
        {
             ApiResponse<Institutions> localVarResponse = await ListInstitutionsAsyncWithHttpInfo(name, page, recordsPerPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List institutions This endpoint allows you to see what institutions are available for connection. Information returned will include the institution_code assigned to a particular institution, URLs for the financial institution&#39;s logo, and the URL for its website.&lt;br&gt; This endpoint takes an optional query string, name&#x3D;{string}. This will list only institutions in which the appended string appears. 
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">This will list only institutions in which the appended string appears. (optional)</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of ApiResponse (Institutions)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Institutions>> ListInstitutionsAsyncWithHttpInfo (string name = null, int? page = null, int? recordsPerPage = null)
        {

            var localVarPath = "/institutions";
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

            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
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
                Exception exception = ExceptionFactory("ListInstitutions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Institutions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Institutions) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Institutions)));
        }

        /// <summary>
        /// Read institution This endpoint allows you to see information for a specific institution.
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutionCode">The institution_code of the institution.</param>
        /// <returns>Institution</returns>
        public Institution ReadInstitution (string institutionCode)
        {
             ApiResponse<Institution> localVarResponse = ReadInstitutionWithHttpInfo(institutionCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read institution This endpoint allows you to see information for a specific institution.
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutionCode">The institution_code of the institution.</param>
        /// <returns>ApiResponse of Institution</returns>
        public ApiResponse< Institution > ReadInstitutionWithHttpInfo (string institutionCode)
        {
            // verify the required parameter 'institutionCode' is set
            if (institutionCode == null)
                throw new ApiException(400, "Missing required parameter 'institutionCode' when calling InstitutionsApi->ReadInstitution");

            var localVarPath = "/institutions/{institution_code}";
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

            if (institutionCode != null) localVarPathParams.Add("institution_code", this.Configuration.ApiClient.ParameterToString(institutionCode)); // path parameter

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
                Exception exception = ExceptionFactory("ReadInstitution", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Institution>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Institution) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Institution)));
        }

        /// <summary>
        /// Read institution This endpoint allows you to see information for a specific institution.
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutionCode">The institution_code of the institution.</param>
        /// <returns>Task of Institution</returns>
        public async System.Threading.Tasks.Task<Institution> ReadInstitutionAsync (string institutionCode)
        {
             ApiResponse<Institution> localVarResponse = await ReadInstitutionAsyncWithHttpInfo(institutionCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read institution This endpoint allows you to see information for a specific institution.
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutionCode">The institution_code of the institution.</param>
        /// <returns>Task of ApiResponse (Institution)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Institution>> ReadInstitutionAsyncWithHttpInfo (string institutionCode)
        {
            // verify the required parameter 'institutionCode' is set
            if (institutionCode == null)
                throw new ApiException(400, "Missing required parameter 'institutionCode' when calling InstitutionsApi->ReadInstitution");

            var localVarPath = "/institutions/{institution_code}";
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

            if (institutionCode != null) localVarPathParams.Add("institution_code", this.Configuration.ApiClient.ParameterToString(institutionCode)); // path parameter

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
                Exception exception = ExceptionFactory("ReadInstitution", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Institution>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Institution) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Institution)));
        }

        /// <summary>
        /// Read institution credentials Use this endpoint to see which credentials will be needed to create a member for a specific institution.
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutionCode">The institution_code of the institution.</param>
        /// <returns>Credentials</returns>
        public Credentials ReadInstitutionCredentials (string institutionCode)
        {
             ApiResponse<Credentials> localVarResponse = ReadInstitutionCredentialsWithHttpInfo(institutionCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read institution credentials Use this endpoint to see which credentials will be needed to create a member for a specific institution.
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutionCode">The institution_code of the institution.</param>
        /// <returns>ApiResponse of Credentials</returns>
        public ApiResponse< Credentials > ReadInstitutionCredentialsWithHttpInfo (string institutionCode)
        {
            // verify the required parameter 'institutionCode' is set
            if (institutionCode == null)
                throw new ApiException(400, "Missing required parameter 'institutionCode' when calling InstitutionsApi->ReadInstitutionCredentials");

            var localVarPath = "/institutions/{institution_code}/credentials";
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

            if (institutionCode != null) localVarPathParams.Add("institution_code", this.Configuration.ApiClient.ParameterToString(institutionCode)); // path parameter

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
                Exception exception = ExceptionFactory("ReadInstitutionCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Credentials>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Credentials) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Credentials)));
        }

        /// <summary>
        /// Read institution credentials Use this endpoint to see which credentials will be needed to create a member for a specific institution.
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutionCode">The institution_code of the institution.</param>
        /// <returns>Task of Credentials</returns>
        public async System.Threading.Tasks.Task<Credentials> ReadInstitutionCredentialsAsync (string institutionCode)
        {
             ApiResponse<Credentials> localVarResponse = await ReadInstitutionCredentialsAsyncWithHttpInfo(institutionCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read institution credentials Use this endpoint to see which credentials will be needed to create a member for a specific institution.
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutionCode">The institution_code of the institution.</param>
        /// <returns>Task of ApiResponse (Credentials)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Credentials>> ReadInstitutionCredentialsAsyncWithHttpInfo (string institutionCode)
        {
            // verify the required parameter 'institutionCode' is set
            if (institutionCode == null)
                throw new ApiException(400, "Missing required parameter 'institutionCode' when calling InstitutionsApi->ReadInstitutionCredentials");

            var localVarPath = "/institutions/{institution_code}/credentials";
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

            if (institutionCode != null) localVarPathParams.Add("institution_code", this.Configuration.ApiClient.ParameterToString(institutionCode)); // path parameter

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
                Exception exception = ExceptionFactory("ReadInstitutionCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Credentials>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Credentials) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Credentials)));
        }

    }
}
