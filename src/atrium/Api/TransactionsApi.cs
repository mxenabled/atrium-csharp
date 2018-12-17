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
    public interface ITransactionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Categorize transactions
        /// </summary>
        /// <remarks>
        /// Use this endpoint to categorize, cleanse, and classify transactions. These transactions are not persisted or stored on the MX platform.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User object to be created with optional parameters (amount, type) amd required parameters (description, identifier)</param>
        /// <returns>TransactionsCleanseAndCategorizeResponseBody</returns>
        TransactionsCleanseAndCategorizeResponseBody CleanseAndCategorizeTransactions (TransactionsCleanseAndCategorizeRequestBody body);

        /// <summary>
        /// Categorize transactions
        /// </summary>
        /// <remarks>
        /// Use this endpoint to categorize, cleanse, and classify transactions. These transactions are not persisted or stored on the MX platform.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User object to be created with optional parameters (amount, type) amd required parameters (description, identifier)</param>
        /// <returns>ApiResponse of TransactionsCleanseAndCategorizeResponseBody</returns>
        ApiResponse<TransactionsCleanseAndCategorizeResponseBody> CleanseAndCategorizeTransactionsWithHttpInfo (TransactionsCleanseAndCategorizeRequestBody body);
        /// <summary>
        /// List transactions for a user
        /// </summary>
        /// <remarks>
        /// Use this endpoint to get all transactions that belong to a specific user, across all the user&#39;s members and accounts.&lt;br&gt; This endpoint accepts optional query parameters, from_date and to_date, which filter transactions according to the date they were posted. If no values are given, from_date will default to 90 days prior to the request, and to_date will default to 5 days from the time of the request. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="fromDate">Filter transactions from this date. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <param name="toDate">Filter transactions to this date. (optional)</param>
        /// <returns>TransactionsResponseBody</returns>
        TransactionsResponseBody ListUserTransactions (string userGuid, int? page = null, string fromDate = null, int? recordsPerPage = null, string toDate = null);

        /// <summary>
        /// List transactions for a user
        /// </summary>
        /// <remarks>
        /// Use this endpoint to get all transactions that belong to a specific user, across all the user&#39;s members and accounts.&lt;br&gt; This endpoint accepts optional query parameters, from_date and to_date, which filter transactions according to the date they were posted. If no values are given, from_date will default to 90 days prior to the request, and to_date will default to 5 days from the time of the request. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="fromDate">Filter transactions from this date. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <param name="toDate">Filter transactions to this date. (optional)</param>
        /// <returns>ApiResponse of TransactionsResponseBody</returns>
        ApiResponse<TransactionsResponseBody> ListUserTransactionsWithHttpInfo (string userGuid, int? page = null, string fromDate = null, int? recordsPerPage = null, string toDate = null);
        /// <summary>
        /// Read a transaction
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to view information about a specific transaction that belongs to a user.&lt;br&gt;
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionGuid">The unique identifier for a &#x60;transaction&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>TransactionResponseBody</returns>
        TransactionResponseBody ReadTransaction (string transactionGuid, string userGuid);

        /// <summary>
        /// Read a transaction
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to view information about a specific transaction that belongs to a user.&lt;br&gt;
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionGuid">The unique identifier for a &#x60;transaction&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of TransactionResponseBody</returns>
        ApiResponse<TransactionResponseBody> ReadTransactionWithHttpInfo (string transactionGuid, string userGuid);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Categorize transactions
        /// </summary>
        /// <remarks>
        /// Use this endpoint to categorize, cleanse, and classify transactions. These transactions are not persisted or stored on the MX platform.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User object to be created with optional parameters (amount, type) amd required parameters (description, identifier)</param>
        /// <returns>Task of TransactionsCleanseAndCategorizeResponseBody</returns>
        System.Threading.Tasks.Task<TransactionsCleanseAndCategorizeResponseBody> CleanseAndCategorizeTransactionsAsync (TransactionsCleanseAndCategorizeRequestBody body);

        /// <summary>
        /// Categorize transactions
        /// </summary>
        /// <remarks>
        /// Use this endpoint to categorize, cleanse, and classify transactions. These transactions are not persisted or stored on the MX platform.
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User object to be created with optional parameters (amount, type) amd required parameters (description, identifier)</param>
        /// <returns>Task of ApiResponse (TransactionsCleanseAndCategorizeResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransactionsCleanseAndCategorizeResponseBody>> CleanseAndCategorizeTransactionsAsyncWithHttpInfo (TransactionsCleanseAndCategorizeRequestBody body);
        /// <summary>
        /// List transactions for a user
        /// </summary>
        /// <remarks>
        /// Use this endpoint to get all transactions that belong to a specific user, across all the user&#39;s members and accounts.&lt;br&gt; This endpoint accepts optional query parameters, from_date and to_date, which filter transactions according to the date they were posted. If no values are given, from_date will default to 90 days prior to the request, and to_date will default to 5 days from the time of the request. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="fromDate">Filter transactions from this date. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <param name="toDate">Filter transactions to this date. (optional)</param>
        /// <returns>Task of TransactionsResponseBody</returns>
        System.Threading.Tasks.Task<TransactionsResponseBody> ListUserTransactionsAsync (string userGuid, int? page = null, string fromDate = null, int? recordsPerPage = null, string toDate = null);

        /// <summary>
        /// List transactions for a user
        /// </summary>
        /// <remarks>
        /// Use this endpoint to get all transactions that belong to a specific user, across all the user&#39;s members and accounts.&lt;br&gt; This endpoint accepts optional query parameters, from_date and to_date, which filter transactions according to the date they were posted. If no values are given, from_date will default to 90 days prior to the request, and to_date will default to 5 days from the time of the request. 
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="fromDate">Filter transactions from this date. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <param name="toDate">Filter transactions to this date. (optional)</param>
        /// <returns>Task of ApiResponse (TransactionsResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransactionsResponseBody>> ListUserTransactionsAsyncWithHttpInfo (string userGuid, int? page = null, string fromDate = null, int? recordsPerPage = null, string toDate = null);
        /// <summary>
        /// Read a transaction
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to view information about a specific transaction that belongs to a user.&lt;br&gt;
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionGuid">The unique identifier for a &#x60;transaction&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of TransactionResponseBody</returns>
        System.Threading.Tasks.Task<TransactionResponseBody> ReadTransactionAsync (string transactionGuid, string userGuid);

        /// <summary>
        /// Read a transaction
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to view information about a specific transaction that belongs to a user.&lt;br&gt;
        /// </remarks>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionGuid">The unique identifier for a &#x60;transaction&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse (TransactionResponseBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransactionResponseBody>> ReadTransactionAsyncWithHttpInfo (string transactionGuid, string userGuid);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TransactionsApi : ITransactionsApi
    {
        private Atrium.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionsApi(String basePath)
        {
            this.Configuration = new Atrium.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Atrium.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionsApi(Atrium.Client.Configuration configuration = null)
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
        /// Categorize transactions Use this endpoint to categorize, cleanse, and classify transactions. These transactions are not persisted or stored on the MX platform.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User object to be created with optional parameters (amount, type) amd required parameters (description, identifier)</param>
        /// <returns>TransactionsCleanseAndCategorizeResponseBody</returns>
        public TransactionsCleanseAndCategorizeResponseBody CleanseAndCategorizeTransactions (TransactionsCleanseAndCategorizeRequestBody body)
        {
             ApiResponse<TransactionsCleanseAndCategorizeResponseBody> localVarResponse = CleanseAndCategorizeTransactionsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Categorize transactions Use this endpoint to categorize, cleanse, and classify transactions. These transactions are not persisted or stored on the MX platform.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User object to be created with optional parameters (amount, type) amd required parameters (description, identifier)</param>
        /// <returns>ApiResponse of TransactionsCleanseAndCategorizeResponseBody</returns>
        public ApiResponse< TransactionsCleanseAndCategorizeResponseBody > CleanseAndCategorizeTransactionsWithHttpInfo (TransactionsCleanseAndCategorizeRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TransactionsApi->CleanseAndCategorizeTransactions");

            var localVarPath = "/cleanse_and_categorize";
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
                Exception exception = ExceptionFactory("CleanseAndCategorizeTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionsCleanseAndCategorizeResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionsCleanseAndCategorizeResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionsCleanseAndCategorizeResponseBody)));
        }

        /// <summary>
        /// Categorize transactions Use this endpoint to categorize, cleanse, and classify transactions. These transactions are not persisted or stored on the MX platform.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User object to be created with optional parameters (amount, type) amd required parameters (description, identifier)</param>
        /// <returns>Task of TransactionsCleanseAndCategorizeResponseBody</returns>
        public async System.Threading.Tasks.Task<TransactionsCleanseAndCategorizeResponseBody> CleanseAndCategorizeTransactionsAsync (TransactionsCleanseAndCategorizeRequestBody body)
        {
             ApiResponse<TransactionsCleanseAndCategorizeResponseBody> localVarResponse = await CleanseAndCategorizeTransactionsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Categorize transactions Use this endpoint to categorize, cleanse, and classify transactions. These transactions are not persisted or stored on the MX platform.
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User object to be created with optional parameters (amount, type) amd required parameters (description, identifier)</param>
        /// <returns>Task of ApiResponse (TransactionsCleanseAndCategorizeResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransactionsCleanseAndCategorizeResponseBody>> CleanseAndCategorizeTransactionsAsyncWithHttpInfo (TransactionsCleanseAndCategorizeRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TransactionsApi->CleanseAndCategorizeTransactions");

            var localVarPath = "/cleanse_and_categorize";
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
                Exception exception = ExceptionFactory("CleanseAndCategorizeTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionsCleanseAndCategorizeResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionsCleanseAndCategorizeResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionsCleanseAndCategorizeResponseBody)));
        }

        /// <summary>
        /// List transactions for a user Use this endpoint to get all transactions that belong to a specific user, across all the user&#39;s members and accounts.&lt;br&gt; This endpoint accepts optional query parameters, from_date and to_date, which filter transactions according to the date they were posted. If no values are given, from_date will default to 90 days prior to the request, and to_date will default to 5 days from the time of the request. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="fromDate">Filter transactions from this date. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <param name="toDate">Filter transactions to this date. (optional)</param>
        /// <returns>TransactionsResponseBody</returns>
        public TransactionsResponseBody ListUserTransactions (string userGuid, int? page = null, string fromDate = null, int? recordsPerPage = null, string toDate = null)
        {
             ApiResponse<TransactionsResponseBody> localVarResponse = ListUserTransactionsWithHttpInfo(userGuid, page, fromDate, recordsPerPage, toDate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List transactions for a user Use this endpoint to get all transactions that belong to a specific user, across all the user&#39;s members and accounts.&lt;br&gt; This endpoint accepts optional query parameters, from_date and to_date, which filter transactions according to the date they were posted. If no values are given, from_date will default to 90 days prior to the request, and to_date will default to 5 days from the time of the request. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="fromDate">Filter transactions from this date. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <param name="toDate">Filter transactions to this date. (optional)</param>
        /// <returns>ApiResponse of TransactionsResponseBody</returns>
        public ApiResponse< TransactionsResponseBody > ListUserTransactionsWithHttpInfo (string userGuid, int? page = null, string fromDate = null, int? recordsPerPage = null, string toDate = null)
        {
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling TransactionsApi->ListUserTransactions");

            var localVarPath = "/users/{user_guid}/transactions";
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
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (fromDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "from_date", fromDate)); // query parameter
            if (recordsPerPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "records_per_page", recordsPerPage)); // query parameter
            if (toDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "to_date", toDate)); // query parameter

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
                Exception exception = ExceptionFactory("ListUserTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionsResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionsResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionsResponseBody)));
        }

        /// <summary>
        /// List transactions for a user Use this endpoint to get all transactions that belong to a specific user, across all the user&#39;s members and accounts.&lt;br&gt; This endpoint accepts optional query parameters, from_date and to_date, which filter transactions according to the date they were posted. If no values are given, from_date will default to 90 days prior to the request, and to_date will default to 5 days from the time of the request. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="fromDate">Filter transactions from this date. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <param name="toDate">Filter transactions to this date. (optional)</param>
        /// <returns>Task of TransactionsResponseBody</returns>
        public async System.Threading.Tasks.Task<TransactionsResponseBody> ListUserTransactionsAsync (string userGuid, int? page = null, string fromDate = null, int? recordsPerPage = null, string toDate = null)
        {
             ApiResponse<TransactionsResponseBody> localVarResponse = await ListUserTransactionsAsyncWithHttpInfo(userGuid, page, fromDate, recordsPerPage, toDate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List transactions for a user Use this endpoint to get all transactions that belong to a specific user, across all the user&#39;s members and accounts.&lt;br&gt; This endpoint accepts optional query parameters, from_date and to_date, which filter transactions according to the date they were posted. If no values are given, from_date will default to 90 days prior to the request, and to_date will default to 5 days from the time of the request. 
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="fromDate">Filter transactions from this date. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <param name="toDate">Filter transactions to this date. (optional)</param>
        /// <returns>Task of ApiResponse (TransactionsResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransactionsResponseBody>> ListUserTransactionsAsyncWithHttpInfo (string userGuid, int? page = null, string fromDate = null, int? recordsPerPage = null, string toDate = null)
        {
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling TransactionsApi->ListUserTransactions");

            var localVarPath = "/users/{user_guid}/transactions";
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
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (fromDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "from_date", fromDate)); // query parameter
            if (recordsPerPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "records_per_page", recordsPerPage)); // query parameter
            if (toDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "to_date", toDate)); // query parameter

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
                Exception exception = ExceptionFactory("ListUserTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionsResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionsResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionsResponseBody)));
        }

        /// <summary>
        /// Read a transaction This endpoint allows you to view information about a specific transaction that belongs to a user.&lt;br&gt;
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionGuid">The unique identifier for a &#x60;transaction&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>TransactionResponseBody</returns>
        public TransactionResponseBody ReadTransaction (string transactionGuid, string userGuid)
        {
             ApiResponse<TransactionResponseBody> localVarResponse = ReadTransactionWithHttpInfo(transactionGuid, userGuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read a transaction This endpoint allows you to view information about a specific transaction that belongs to a user.&lt;br&gt;
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionGuid">The unique identifier for a &#x60;transaction&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of TransactionResponseBody</returns>
        public ApiResponse< TransactionResponseBody > ReadTransactionWithHttpInfo (string transactionGuid, string userGuid)
        {
            // verify the required parameter 'transactionGuid' is set
            if (transactionGuid == null)
                throw new ApiException(400, "Missing required parameter 'transactionGuid' when calling TransactionsApi->ReadTransaction");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling TransactionsApi->ReadTransaction");

            var localVarPath = "/users/{user_guid}/transactions/{transaction_guid}";
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

            if (transactionGuid != null) localVarPathParams.Add("transaction_guid", this.Configuration.ApiClient.ParameterToString(transactionGuid)); // path parameter
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
                Exception exception = ExceptionFactory("ReadTransaction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionResponseBody)));
        }

        /// <summary>
        /// Read a transaction This endpoint allows you to view information about a specific transaction that belongs to a user.&lt;br&gt;
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionGuid">The unique identifier for a &#x60;transaction&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of TransactionResponseBody</returns>
        public async System.Threading.Tasks.Task<TransactionResponseBody> ReadTransactionAsync (string transactionGuid, string userGuid)
        {
             ApiResponse<TransactionResponseBody> localVarResponse = await ReadTransactionAsyncWithHttpInfo(transactionGuid, userGuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read a transaction This endpoint allows you to view information about a specific transaction that belongs to a user.&lt;br&gt;
        /// </summary>
        /// <exception cref="Atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionGuid">The unique identifier for a &#x60;transaction&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse (TransactionResponseBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransactionResponseBody>> ReadTransactionAsyncWithHttpInfo (string transactionGuid, string userGuid)
        {
            // verify the required parameter 'transactionGuid' is set
            if (transactionGuid == null)
                throw new ApiException(400, "Missing required parameter 'transactionGuid' when calling TransactionsApi->ReadTransaction");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling TransactionsApi->ReadTransaction");

            var localVarPath = "/users/{user_guid}/transactions/{transaction_guid}";
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

            if (transactionGuid != null) localVarPathParams.Add("transaction_guid", this.Configuration.ApiClient.ParameterToString(transactionGuid)); // path parameter
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
                Exception exception = ExceptionFactory("ReadTransaction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionResponseBody>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionResponseBody)));
        }

    }
}
