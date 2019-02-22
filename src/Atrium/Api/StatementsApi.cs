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
    public interface IStatementsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Download statement PDF
        /// </summary>
        /// <remarks>
        /// Use this endpoint to download a specified statement. The endpoint URL is the same as the URI given in each &#x60;statement&#x60; object. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="statementGuid">The unique identifier for an &#x60;statement&#x60;.</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream DownloadStatementPdf (string memberGuid, string userGuid, string statementGuid);

        /// <summary>
        /// Download statement PDF
        /// </summary>
        /// <remarks>
        /// Use this endpoint to download a specified statement. The endpoint URL is the same as the URI given in each &#x60;statement&#x60; object. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="statementGuid">The unique identifier for an &#x60;statement&#x60;.</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> DownloadStatementPdfWithHttpInfo (string memberGuid, string userGuid, string statementGuid);
        /// <summary>
        /// Fetch statements
        /// </summary>
        /// <remarks>
        /// The fetch statements endpoint begins fetching statements for a member.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>MemberResponseBody</returns>
        MemberResponseBody FetchStatements (string memberGuid, string userGuid);

        /// <summary>
        /// Fetch statements
        /// </summary>
        /// <remarks>
        /// The fetch statements endpoint begins fetching statements for a member.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of MemberResponseBody</returns>
        ApiResponse<MemberResponseBody> FetchStatementsWithHttpInfo (string memberGuid, string userGuid);
        /// <summary>
        /// List member statements
        /// </summary>
        /// <remarks>
        /// Certain institutions in Atrium allow developers to access account statements associated with a particular &#x60;member&#x60;. Use this endpoint to get an array of available statements.  Before this endpoint can be used, &#x60;fetch_statements&#x60; should be performed on the relevant &#x60;member&#x60;. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>StatementsResponseBody</returns>
        StatementsResponseBody ListMemberStatements (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null);

        /// <summary>
        /// List member statements
        /// </summary>
        /// <remarks>
        /// Certain institutions in Atrium allow developers to access account statements associated with a particular &#x60;member&#x60;. Use this endpoint to get an array of available statements.  Before this endpoint can be used, &#x60;fetch_statements&#x60; should be performed on the relevant &#x60;member&#x60;. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>ApiResponse of StatementsResponseBody</returns>
        ApiResponse<StatementsResponseBody> ListMemberStatementsWithHttpInfo (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null);
        /// <summary>
        /// Read statement JSON
        /// </summary>
        /// <remarks>
        /// Use this endpoint to download a specified statement. The endpoint URL is the same as the URI given in each &#x60;statement&#x60; object. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="statementGuid">The unique identifier for an &#x60;statement&#x60;.</param>
        /// <returns>StatementResponseBody</returns>
        StatementResponseBody ReadMemberStatement (string memberGuid, string userGuid, string statementGuid);

        /// <summary>
        /// Read statement JSON
        /// </summary>
        /// <remarks>
        /// Use this endpoint to download a specified statement. The endpoint URL is the same as the URI given in each &#x60;statement&#x60; object. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="statementGuid">The unique identifier for an &#x60;statement&#x60;.</param>
        /// <returns>ApiResponse of StatementResponseBody</returns>
        ApiResponse<StatementResponseBody> ReadMemberStatementWithHttpInfo (string memberGuid, string userGuid, string statementGuid);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Download statement PDF
        /// </summary>
        /// <remarks>
        /// Use this endpoint to download a specified statement. The endpoint URL is the same as the URI given in each &#x60;statement&#x60; object. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="statementGuid">The unique identifier for an &#x60;statement&#x60;.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> DownloadStatementPdfAsync (string memberGuid, string userGuid, string statementGuid);

        /// <summary>
        /// Download statement PDF
        /// </summary>
        /// <remarks>
        /// Use this endpoint to download a specified statement. The endpoint URL is the same as the URI given in each &#x60;statement&#x60; object. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="statementGuid">The unique identifier for an &#x60;statement&#x60;.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> DownloadStatementPdfAsyncWithHttpInfo (string memberGuid, string userGuid, string statementGuid);
        /// <summary>
        /// Fetch statements
        /// </summary>
        /// <remarks>
        /// The fetch statements endpoint begins fetching statements for a member.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of MemberResponseBody</returns>
        System.Threading.Tasks.Task<MemberResponseBody> FetchStatementsAsync (string memberGuid, string userGuid);

        /// <summary>
        /// Fetch statements
        /// </summary>
        /// <remarks>
        /// The fetch statements endpoint begins fetching statements for a member.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse (MemberResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<MemberResponseBody>> FetchStatementsAsyncWithHttpInfo (string memberGuid, string userGuid);
        /// <summary>
        /// List member statements
        /// </summary>
        /// <remarks>
        /// Certain institutions in Atrium allow developers to access account statements associated with a particular &#x60;member&#x60;. Use this endpoint to get an array of available statements.  Before this endpoint can be used, &#x60;fetch_statements&#x60; should be performed on the relevant &#x60;member&#x60;. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of StatementsResponseBody</returns>
        System.Threading.Tasks.Task<StatementsResponseBody> ListMemberStatementsAsync (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null);

        /// <summary>
        /// List member statements
        /// </summary>
        /// <remarks>
        /// Certain institutions in Atrium allow developers to access account statements associated with a particular &#x60;member&#x60;. Use this endpoint to get an array of available statements.  Before this endpoint can be used, &#x60;fetch_statements&#x60; should be performed on the relevant &#x60;member&#x60;. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of ApiResponse (StatementsResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatementsResponseBody>> ListMemberStatementsAsyncWithHttpInfo (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null);
        /// <summary>
        /// Read statement JSON
        /// </summary>
        /// <remarks>
        /// Use this endpoint to download a specified statement. The endpoint URL is the same as the URI given in each &#x60;statement&#x60; object. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="statementGuid">The unique identifier for an &#x60;statement&#x60;.</param>
        /// <returns>Task of StatementResponseBody</returns>
        System.Threading.Tasks.Task<StatementResponseBody> ReadMemberStatementAsync (string memberGuid, string userGuid, string statementGuid);

        /// <summary>
        /// Read statement JSON
        /// </summary>
        /// <remarks>
        /// Use this endpoint to download a specified statement. The endpoint URL is the same as the URI given in each &#x60;statement&#x60; object. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="statementGuid">The unique identifier for an &#x60;statement&#x60;.</param>
        /// <returns>Task of ApiResponse (StatementResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatementResponseBody>> ReadMemberStatementAsyncWithHttpInfo (string memberGuid, string userGuid, string statementGuid);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StatementsApi : IStatementsApi
    {
        private Atrium.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatementsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatementsApi(String basePath)
        {
            this.Configuration = new Atrium.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Atrium.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatementsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StatementsApi(Atrium.Client.Configuration configuration = null)
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
        /// Download statement PDF Use this endpoint to download a specified statement. The endpoint URL is the same as the URI given in each &#x60;statement&#x60; object. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="statementGuid">The unique identifier for an &#x60;statement&#x60;.</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream DownloadStatementPdf (string memberGuid, string userGuid, string statementGuid)
        {
             ApiResponse<System.IO.Stream> localVarResponse = DownloadStatementPdfWithHttpInfo(memberGuid, userGuid, statementGuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Download statement PDF Use this endpoint to download a specified statement. The endpoint URL is the same as the URI given in each &#x60;statement&#x60; object. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="statementGuid">The unique identifier for an &#x60;statement&#x60;.</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse< System.IO.Stream > DownloadStatementPdfWithHttpInfo (string memberGuid, string userGuid, string statementGuid)
        {
            // verify the required parameter 'memberGuid' is set
            if (memberGuid == null)
                throw new ApiException(400, "Missing required parameter 'memberGuid' when calling StatementsApi->DownloadStatementPdf");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling StatementsApi->DownloadStatementPdf");
            // verify the required parameter 'statementGuid' is set
            if (statementGuid == null)
                throw new ApiException(400, "Missing required parameter 'statementGuid' when calling StatementsApi->DownloadStatementPdf");

            var localVarPath = "/users/{user_guid}/members/{member_guid}/statements/{statement_guid}.pdf";
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
                "application/vnd.mx.atrium.v1+pdf"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (memberGuid != null) localVarPathParams.Add("member_guid", this.Configuration.ApiClient.ParameterToString(memberGuid)); // path parameter
            if (userGuid != null) localVarPathParams.Add("user_guid", this.Configuration.ApiClient.ParameterToString(userGuid)); // path parameter
            if (statementGuid != null) localVarPathParams.Add("statement_guid", this.Configuration.ApiClient.ParameterToString(statementGuid)); // path parameter

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
                Exception exception = ExceptionFactory("DownloadStatementPdf", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Download statement PDF Use this endpoint to download a specified statement. The endpoint URL is the same as the URI given in each &#x60;statement&#x60; object. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="statementGuid">The unique identifier for an &#x60;statement&#x60;.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> DownloadStatementPdfAsync (string memberGuid, string userGuid, string statementGuid)
        {
             ApiResponse<System.IO.Stream> localVarResponse = await DownloadStatementPdfAsyncWithHttpInfo(memberGuid, userGuid, statementGuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Download statement PDF Use this endpoint to download a specified statement. The endpoint URL is the same as the URI given in each &#x60;statement&#x60; object. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="statementGuid">The unique identifier for an &#x60;statement&#x60;.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> DownloadStatementPdfAsyncWithHttpInfo (string memberGuid, string userGuid, string statementGuid)
        {
            // verify the required parameter 'memberGuid' is set
            if (memberGuid == null)
                throw new ApiException(400, "Missing required parameter 'memberGuid' when calling StatementsApi->DownloadStatementPdf");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling StatementsApi->DownloadStatementPdf");
            // verify the required parameter 'statementGuid' is set
            if (statementGuid == null)
                throw new ApiException(400, "Missing required parameter 'statementGuid' when calling StatementsApi->DownloadStatementPdf");

            var localVarPath = "/users/{user_guid}/members/{member_guid}/statements/{statement_guid}.pdf";
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
                "application/vnd.mx.atrium.v1+pdf"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (memberGuid != null) localVarPathParams.Add("member_guid", this.Configuration.ApiClient.ParameterToString(memberGuid)); // path parameter
            if (userGuid != null) localVarPathParams.Add("user_guid", this.Configuration.ApiClient.ParameterToString(userGuid)); // path parameter
            if (statementGuid != null) localVarPathParams.Add("statement_guid", this.Configuration.ApiClient.ParameterToString(statementGuid)); // path parameter

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
                Exception exception = ExceptionFactory("DownloadStatementPdf", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Fetch statements The fetch statements endpoint begins fetching statements for a member.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>MemberResponseBody</returns>
        public MemberResponseBody FetchStatements (string memberGuid, string userGuid)
        {
             ApiResponse<MemberResponseBody> localVarResponse = FetchStatementsWithHttpInfo(memberGuid, userGuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch statements The fetch statements endpoint begins fetching statements for a member.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of MemberResponseBody</returns>
        public ApiResponse< MemberResponseBody > FetchStatementsWithHttpInfo (string memberGuid, string userGuid)
        {
            // verify the required parameter 'memberGuid' is set
            if (memberGuid == null)
                throw new ApiException(400, "Missing required parameter 'memberGuid' when calling StatementsApi->FetchStatements");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling StatementsApi->FetchStatements");

            var localVarPath = "/users/{user_guid}/members/{member_guid}/fetch_statements";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FetchStatements", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MemberResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MemberResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MemberResponseBody)));
        }

        /// <summary>
        /// Fetch statements The fetch statements endpoint begins fetching statements for a member.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of MemberResponseBody</returns>
        public async System.Threading.Tasks.Task<MemberResponseBody> FetchStatementsAsync (string memberGuid, string userGuid)
        {
             ApiResponse<MemberResponseBody> localVarResponse = await FetchStatementsAsyncWithHttpInfo(memberGuid, userGuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch statements The fetch statements endpoint begins fetching statements for a member.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse (MemberResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MemberResponseBody>> FetchStatementsAsyncWithHttpInfo (string memberGuid, string userGuid)
        {
            // verify the required parameter 'memberGuid' is set
            if (memberGuid == null)
                throw new ApiException(400, "Missing required parameter 'memberGuid' when calling StatementsApi->FetchStatements");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling StatementsApi->FetchStatements");

            var localVarPath = "/users/{user_guid}/members/{member_guid}/fetch_statements";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FetchStatements", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MemberResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MemberResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MemberResponseBody)));
        }

        /// <summary>
        /// List member statements Certain institutions in Atrium allow developers to access account statements associated with a particular &#x60;member&#x60;. Use this endpoint to get an array of available statements.  Before this endpoint can be used, &#x60;fetch_statements&#x60; should be performed on the relevant &#x60;member&#x60;. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>StatementsResponseBody</returns>
        public StatementsResponseBody ListMemberStatements (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null)
        {
             ApiResponse<StatementsResponseBody> localVarResponse = ListMemberStatementsWithHttpInfo(memberGuid, userGuid, page, recordsPerPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List member statements Certain institutions in Atrium allow developers to access account statements associated with a particular &#x60;member&#x60;. Use this endpoint to get an array of available statements.  Before this endpoint can be used, &#x60;fetch_statements&#x60; should be performed on the relevant &#x60;member&#x60;. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>ApiResponse of StatementsResponseBody</returns>
        public ApiResponse< StatementsResponseBody > ListMemberStatementsWithHttpInfo (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null)
        {
            // verify the required parameter 'memberGuid' is set
            if (memberGuid == null)
                throw new ApiException(400, "Missing required parameter 'memberGuid' when calling StatementsApi->ListMemberStatements");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling StatementsApi->ListMemberStatements");

            var localVarPath = "/users/{user_guid}/members/{member_guid}/statements";
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
                Exception exception = ExceptionFactory("ListMemberStatements", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StatementsResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatementsResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatementsResponseBody)));
        }

        /// <summary>
        /// List member statements Certain institutions in Atrium allow developers to access account statements associated with a particular &#x60;member&#x60;. Use this endpoint to get an array of available statements.  Before this endpoint can be used, &#x60;fetch_statements&#x60; should be performed on the relevant &#x60;member&#x60;. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of StatementsResponseBody</returns>
        public async System.Threading.Tasks.Task<StatementsResponseBody> ListMemberStatementsAsync (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null)
        {
             ApiResponse<StatementsResponseBody> localVarResponse = await ListMemberStatementsAsyncWithHttpInfo(memberGuid, userGuid, page, recordsPerPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List member statements Certain institutions in Atrium allow developers to access account statements associated with a particular &#x60;member&#x60;. Use this endpoint to get an array of available statements.  Before this endpoint can be used, &#x60;fetch_statements&#x60; should be performed on the relevant &#x60;member&#x60;. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of ApiResponse (StatementsResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatementsResponseBody>> ListMemberStatementsAsyncWithHttpInfo (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null)
        {
            // verify the required parameter 'memberGuid' is set
            if (memberGuid == null)
                throw new ApiException(400, "Missing required parameter 'memberGuid' when calling StatementsApi->ListMemberStatements");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling StatementsApi->ListMemberStatements");

            var localVarPath = "/users/{user_guid}/members/{member_guid}/statements";
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
                Exception exception = ExceptionFactory("ListMemberStatements", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StatementsResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatementsResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatementsResponseBody)));
        }

        /// <summary>
        /// Read statement JSON Use this endpoint to download a specified statement. The endpoint URL is the same as the URI given in each &#x60;statement&#x60; object. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="statementGuid">The unique identifier for an &#x60;statement&#x60;.</param>
        /// <returns>StatementResponseBody</returns>
        public StatementResponseBody ReadMemberStatement (string memberGuid, string userGuid, string statementGuid)
        {
             ApiResponse<StatementResponseBody> localVarResponse = ReadMemberStatementWithHttpInfo(memberGuid, userGuid, statementGuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read statement JSON Use this endpoint to download a specified statement. The endpoint URL is the same as the URI given in each &#x60;statement&#x60; object. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="statementGuid">The unique identifier for an &#x60;statement&#x60;.</param>
        /// <returns>ApiResponse of StatementResponseBody</returns>
        public ApiResponse< StatementResponseBody > ReadMemberStatementWithHttpInfo (string memberGuid, string userGuid, string statementGuid)
        {
            // verify the required parameter 'memberGuid' is set
            if (memberGuid == null)
                throw new ApiException(400, "Missing required parameter 'memberGuid' when calling StatementsApi->ReadMemberStatement");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling StatementsApi->ReadMemberStatement");
            // verify the required parameter 'statementGuid' is set
            if (statementGuid == null)
                throw new ApiException(400, "Missing required parameter 'statementGuid' when calling StatementsApi->ReadMemberStatement");

            var localVarPath = "/users/{user_guid}/members/{member_guid}/statements/{statement_guid}";
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
            if (statementGuid != null) localVarPathParams.Add("statement_guid", this.Configuration.ApiClient.ParameterToString(statementGuid)); // path parameter

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
                Exception exception = ExceptionFactory("ReadMemberStatement", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StatementResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatementResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatementResponseBody)));
        }

        /// <summary>
        /// Read statement JSON Use this endpoint to download a specified statement. The endpoint URL is the same as the URI given in each &#x60;statement&#x60; object. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="statementGuid">The unique identifier for an &#x60;statement&#x60;.</param>
        /// <returns>Task of StatementResponseBody</returns>
        public async System.Threading.Tasks.Task<StatementResponseBody> ReadMemberStatementAsync (string memberGuid, string userGuid, string statementGuid)
        {
             ApiResponse<StatementResponseBody> localVarResponse = await ReadMemberStatementAsyncWithHttpInfo(memberGuid, userGuid, statementGuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read statement JSON Use this endpoint to download a specified statement. The endpoint URL is the same as the URI given in each &#x60;statement&#x60; object. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="statementGuid">The unique identifier for an &#x60;statement&#x60;.</param>
        /// <returns>Task of ApiResponse (StatementResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatementResponseBody>> ReadMemberStatementAsyncWithHttpInfo (string memberGuid, string userGuid, string statementGuid)
        {
            // verify the required parameter 'memberGuid' is set
            if (memberGuid == null)
                throw new ApiException(400, "Missing required parameter 'memberGuid' when calling StatementsApi->ReadMemberStatement");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling StatementsApi->ReadMemberStatement");
            // verify the required parameter 'statementGuid' is set
            if (statementGuid == null)
                throw new ApiException(400, "Missing required parameter 'statementGuid' when calling StatementsApi->ReadMemberStatement");

            var localVarPath = "/users/{user_guid}/members/{member_guid}/statements/{statement_guid}";
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
            if (statementGuid != null) localVarPathParams.Add("statement_guid", this.Configuration.ApiClient.ParameterToString(statementGuid)); // path parameter

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
                Exception exception = ExceptionFactory("ReadMemberStatement", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StatementResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatementResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatementResponseBody)));
        }

    }
}
