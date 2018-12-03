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
    public interface IAccountsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List account transactions
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to see every transaction that belongs to a specific account. The default from_date is 90 days prior to the request, and the default to_date is 5 days from the time of the request.&lt;br&gt; The from_date and to_date parameters can optionally be appended to the request. 
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="fromDate">Filter transactions from this date. (optional)</param>
        /// <param name="toDate">Filter transactions to this date. (optional)</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Transactions</returns>
        Transactions ListAccountTransactions (string accountGuid, string userGuid, string fromDate = null, string toDate = null, int? page = null, int? recordsPerPage = null);

        /// <summary>
        /// List account transactions
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to see every transaction that belongs to a specific account. The default from_date is 90 days prior to the request, and the default to_date is 5 days from the time of the request.&lt;br&gt; The from_date and to_date parameters can optionally be appended to the request. 
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="fromDate">Filter transactions from this date. (optional)</param>
        /// <param name="toDate">Filter transactions to this date. (optional)</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>ApiResponse of Transactions</returns>
        ApiResponse<Transactions> ListAccountTransactionsWithHttpInfo (string accountGuid, string userGuid, string fromDate = null, string toDate = null, int? page = null, int? recordsPerPage = null);
        /// <summary>
        /// List accounts for a user
        /// </summary>
        /// <remarks>
        /// Use this endpoint to view information about every account that belongs to a user. You&#39;ll need the user&#39;s GUID to access this list. The information will include the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the account balance, the date the account was started, etc.
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Accounts</returns>
        Accounts ListUserAccounts (string userGuid, int? page = null, int? recordsPerPage = null);

        /// <summary>
        /// List accounts for a user
        /// </summary>
        /// <remarks>
        /// Use this endpoint to view information about every account that belongs to a user. You&#39;ll need the user&#39;s GUID to access this list. The information will include the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the account balance, the date the account was started, etc.
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>ApiResponse of Accounts</returns>
        ApiResponse<Accounts> ListUserAccountsWithHttpInfo (string userGuid, int? page = null, int? recordsPerPage = null);
        /// <summary>
        /// Read an account
        /// </summary>
        /// <remarks>
        /// Reading an account allows you to get information about a specific account that belongs to a user. That includes the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the balance, the date the account was started, and much more.&lt;br&gt; There are two endpoints for reading an account. Both will return the same information.&lt;br&gt; It&#39;s important to remember that balance and available_balance will normally be positive numbers — for all account types. But this should be interpreted differently for debt accounts and asset accounts.&lt;br&gt; An asset account, e.g., CHECKING, SAVINGS, or INVESTMENT, will have a positive balance unless it is in an overdraft condition, in which case the balance will be negative.&lt;br&gt; On the other hand, a debt account, e.g., CREDIT CARD, LOAN, MORTGAGE, would have a positivebalance when the user owes money on the account. It would have a negative balance if the account has been overpaid. 
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Account</returns>
        Account ReadAccount (string accountGuid, string userGuid);

        /// <summary>
        /// Read an account
        /// </summary>
        /// <remarks>
        /// Reading an account allows you to get information about a specific account that belongs to a user. That includes the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the balance, the date the account was started, and much more.&lt;br&gt; There are two endpoints for reading an account. Both will return the same information.&lt;br&gt; It&#39;s important to remember that balance and available_balance will normally be positive numbers — for all account types. But this should be interpreted differently for debt accounts and asset accounts.&lt;br&gt; An asset account, e.g., CHECKING, SAVINGS, or INVESTMENT, will have a positive balance unless it is in an overdraft condition, in which case the balance will be negative.&lt;br&gt; On the other hand, a debt account, e.g., CREDIT CARD, LOAN, MORTGAGE, would have a positivebalance when the user owes money on the account. It would have a negative balance if the account has been overpaid. 
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of Account</returns>
        ApiResponse<Account> ReadAccountWithHttpInfo (string accountGuid, string userGuid);
        /// <summary>
        /// Read an account
        /// </summary>
        /// <remarks>
        /// Reading an account allows you to get information about a specific account that belongs to a user. That includes the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the balance, the date the account was started, and much more.&lt;br&gt; There are two endpoints for reading an account. Both will return the same information.&lt;br&gt; It&#39;s important to remember that balance and available_balance will normally be positive numbers — for all account types. But this should be interpreted differently for debt accounts and asset accounts.&lt;br&gt; An asset account, e.g., CHECKING, SAVINGS, or INVESTMENT, will have a positive balance unless it is in an overdraft condition, in which case the balance will be negative.&lt;br&gt; On the other hand, a debt account, e.g., CREDIT CARD, LOAN, MORTGAGE, would have a positivebalance when the user owes money on the account. It would have a negative balance if the account has been overpaid. 
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Account</returns>
        Account ReadAccountByMemberGUID (string accountGuid, string memberGuid, string userGuid);

        /// <summary>
        /// Read an account
        /// </summary>
        /// <remarks>
        /// Reading an account allows you to get information about a specific account that belongs to a user. That includes the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the balance, the date the account was started, and much more.&lt;br&gt; There are two endpoints for reading an account. Both will return the same information.&lt;br&gt; It&#39;s important to remember that balance and available_balance will normally be positive numbers — for all account types. But this should be interpreted differently for debt accounts and asset accounts.&lt;br&gt; An asset account, e.g., CHECKING, SAVINGS, or INVESTMENT, will have a positive balance unless it is in an overdraft condition, in which case the balance will be negative.&lt;br&gt; On the other hand, a debt account, e.g., CREDIT CARD, LOAN, MORTGAGE, would have a positivebalance when the user owes money on the account. It would have a negative balance if the account has been overpaid. 
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of Account</returns>
        ApiResponse<Account> ReadAccountByMemberGUIDWithHttpInfo (string accountGuid, string memberGuid, string userGuid);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// List account transactions
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to see every transaction that belongs to a specific account. The default from_date is 90 days prior to the request, and the default to_date is 5 days from the time of the request.&lt;br&gt; The from_date and to_date parameters can optionally be appended to the request. 
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="fromDate">Filter transactions from this date. (optional)</param>
        /// <param name="toDate">Filter transactions to this date. (optional)</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of Transactions</returns>
        System.Threading.Tasks.Task<Transactions> ListAccountTransactionsAsync (string accountGuid, string userGuid, string fromDate = null, string toDate = null, int? page = null, int? recordsPerPage = null);

        /// <summary>
        /// List account transactions
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to see every transaction that belongs to a specific account. The default from_date is 90 days prior to the request, and the default to_date is 5 days from the time of the request.&lt;br&gt; The from_date and to_date parameters can optionally be appended to the request. 
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="fromDate">Filter transactions from this date. (optional)</param>
        /// <param name="toDate">Filter transactions to this date. (optional)</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of ApiResponse (Transactions)</returns>
        System.Threading.Tasks.Task<ApiResponse<Transactions>> ListAccountTransactionsAsyncWithHttpInfo (string accountGuid, string userGuid, string fromDate = null, string toDate = null, int? page = null, int? recordsPerPage = null);
        /// <summary>
        /// List accounts for a user
        /// </summary>
        /// <remarks>
        /// Use this endpoint to view information about every account that belongs to a user. You&#39;ll need the user&#39;s GUID to access this list. The information will include the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the account balance, the date the account was started, etc.
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of Accounts</returns>
        System.Threading.Tasks.Task<Accounts> ListUserAccountsAsync (string userGuid, int? page = null, int? recordsPerPage = null);

        /// <summary>
        /// List accounts for a user
        /// </summary>
        /// <remarks>
        /// Use this endpoint to view information about every account that belongs to a user. You&#39;ll need the user&#39;s GUID to access this list. The information will include the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the account balance, the date the account was started, etc.
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of ApiResponse (Accounts)</returns>
        System.Threading.Tasks.Task<ApiResponse<Accounts>> ListUserAccountsAsyncWithHttpInfo (string userGuid, int? page = null, int? recordsPerPage = null);
        /// <summary>
        /// Read an account
        /// </summary>
        /// <remarks>
        /// Reading an account allows you to get information about a specific account that belongs to a user. That includes the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the balance, the date the account was started, and much more.&lt;br&gt; There are two endpoints for reading an account. Both will return the same information.&lt;br&gt; It&#39;s important to remember that balance and available_balance will normally be positive numbers — for all account types. But this should be interpreted differently for debt accounts and asset accounts.&lt;br&gt; An asset account, e.g., CHECKING, SAVINGS, or INVESTMENT, will have a positive balance unless it is in an overdraft condition, in which case the balance will be negative.&lt;br&gt; On the other hand, a debt account, e.g., CREDIT CARD, LOAN, MORTGAGE, would have a positivebalance when the user owes money on the account. It would have a negative balance if the account has been overpaid. 
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of Account</returns>
        System.Threading.Tasks.Task<Account> ReadAccountAsync (string accountGuid, string userGuid);

        /// <summary>
        /// Read an account
        /// </summary>
        /// <remarks>
        /// Reading an account allows you to get information about a specific account that belongs to a user. That includes the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the balance, the date the account was started, and much more.&lt;br&gt; There are two endpoints for reading an account. Both will return the same information.&lt;br&gt; It&#39;s important to remember that balance and available_balance will normally be positive numbers — for all account types. But this should be interpreted differently for debt accounts and asset accounts.&lt;br&gt; An asset account, e.g., CHECKING, SAVINGS, or INVESTMENT, will have a positive balance unless it is in an overdraft condition, in which case the balance will be negative.&lt;br&gt; On the other hand, a debt account, e.g., CREDIT CARD, LOAN, MORTGAGE, would have a positivebalance when the user owes money on the account. It would have a negative balance if the account has been overpaid. 
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse (Account)</returns>
        System.Threading.Tasks.Task<ApiResponse<Account>> ReadAccountAsyncWithHttpInfo (string accountGuid, string userGuid);
        /// <summary>
        /// Read an account
        /// </summary>
        /// <remarks>
        /// Reading an account allows you to get information about a specific account that belongs to a user. That includes the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the balance, the date the account was started, and much more.&lt;br&gt; There are two endpoints for reading an account. Both will return the same information.&lt;br&gt; It&#39;s important to remember that balance and available_balance will normally be positive numbers — for all account types. But this should be interpreted differently for debt accounts and asset accounts.&lt;br&gt; An asset account, e.g., CHECKING, SAVINGS, or INVESTMENT, will have a positive balance unless it is in an overdraft condition, in which case the balance will be negative.&lt;br&gt; On the other hand, a debt account, e.g., CREDIT CARD, LOAN, MORTGAGE, would have a positivebalance when the user owes money on the account. It would have a negative balance if the account has been overpaid. 
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of Account</returns>
        System.Threading.Tasks.Task<Account> ReadAccountByMemberGUIDAsync (string accountGuid, string memberGuid, string userGuid);

        /// <summary>
        /// Read an account
        /// </summary>
        /// <remarks>
        /// Reading an account allows you to get information about a specific account that belongs to a user. That includes the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the balance, the date the account was started, and much more.&lt;br&gt; There are two endpoints for reading an account. Both will return the same information.&lt;br&gt; It&#39;s important to remember that balance and available_balance will normally be positive numbers — for all account types. But this should be interpreted differently for debt accounts and asset accounts.&lt;br&gt; An asset account, e.g., CHECKING, SAVINGS, or INVESTMENT, will have a positive balance unless it is in an overdraft condition, in which case the balance will be negative.&lt;br&gt; On the other hand, a debt account, e.g., CREDIT CARD, LOAN, MORTGAGE, would have a positivebalance when the user owes money on the account. It would have a negative balance if the account has been overpaid. 
        /// </remarks>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse (Account)</returns>
        System.Threading.Tasks.Task<ApiResponse<Account>> ReadAccountByMemberGUIDAsyncWithHttpInfo (string accountGuid, string memberGuid, string userGuid);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccountsApi : IAccountsApi
    {
        private atrium.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountsApi(String basePath)
        {
            this.Configuration = new atrium.Client.Configuration { BasePath = basePath };

            ExceptionFactory = atrium.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccountsApi(atrium.Client.Configuration configuration = null)
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
        /// List account transactions This endpoint allows you to see every transaction that belongs to a specific account. The default from_date is 90 days prior to the request, and the default to_date is 5 days from the time of the request.&lt;br&gt; The from_date and to_date parameters can optionally be appended to the request. 
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="fromDate">Filter transactions from this date. (optional)</param>
        /// <param name="toDate">Filter transactions to this date. (optional)</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Transactions</returns>
        public Transactions ListAccountTransactions (string accountGuid, string userGuid, string fromDate = null, string toDate = null, int? page = null, int? recordsPerPage = null)
        {
             ApiResponse<Transactions> localVarResponse = ListAccountTransactionsWithHttpInfo(accountGuid, userGuid, fromDate, toDate, page, recordsPerPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List account transactions This endpoint allows you to see every transaction that belongs to a specific account. The default from_date is 90 days prior to the request, and the default to_date is 5 days from the time of the request.&lt;br&gt; The from_date and to_date parameters can optionally be appended to the request. 
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="fromDate">Filter transactions from this date. (optional)</param>
        /// <param name="toDate">Filter transactions to this date. (optional)</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>ApiResponse of Transactions</returns>
        public ApiResponse< Transactions > ListAccountTransactionsWithHttpInfo (string accountGuid, string userGuid, string fromDate = null, string toDate = null, int? page = null, int? recordsPerPage = null)
        {
            // verify the required parameter 'accountGuid' is set
            if (accountGuid == null)
                throw new ApiException(400, "Missing required parameter 'accountGuid' when calling AccountsApi->ListAccountTransactions");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling AccountsApi->ListAccountTransactions");

            var localVarPath = "/users/{user_guid}/accounts/{account_guid}/transactions";
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
            if (fromDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "from_date", fromDate)); // query parameter
            if (toDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "to_date", toDate)); // query parameter
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
                Exception exception = ExceptionFactory("ListAccountTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transactions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transactions) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Transactions)));
        }

        /// <summary>
        /// List account transactions This endpoint allows you to see every transaction that belongs to a specific account. The default from_date is 90 days prior to the request, and the default to_date is 5 days from the time of the request.&lt;br&gt; The from_date and to_date parameters can optionally be appended to the request. 
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="fromDate">Filter transactions from this date. (optional)</param>
        /// <param name="toDate">Filter transactions to this date. (optional)</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of Transactions</returns>
        public async System.Threading.Tasks.Task<Transactions> ListAccountTransactionsAsync (string accountGuid, string userGuid, string fromDate = null, string toDate = null, int? page = null, int? recordsPerPage = null)
        {
             ApiResponse<Transactions> localVarResponse = await ListAccountTransactionsAsyncWithHttpInfo(accountGuid, userGuid, fromDate, toDate, page, recordsPerPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List account transactions This endpoint allows you to see every transaction that belongs to a specific account. The default from_date is 90 days prior to the request, and the default to_date is 5 days from the time of the request.&lt;br&gt; The from_date and to_date parameters can optionally be appended to the request. 
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="fromDate">Filter transactions from this date. (optional)</param>
        /// <param name="toDate">Filter transactions to this date. (optional)</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of ApiResponse (Transactions)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Transactions>> ListAccountTransactionsAsyncWithHttpInfo (string accountGuid, string userGuid, string fromDate = null, string toDate = null, int? page = null, int? recordsPerPage = null)
        {
            // verify the required parameter 'accountGuid' is set
            if (accountGuid == null)
                throw new ApiException(400, "Missing required parameter 'accountGuid' when calling AccountsApi->ListAccountTransactions");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling AccountsApi->ListAccountTransactions");

            var localVarPath = "/users/{user_guid}/accounts/{account_guid}/transactions";
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
            if (fromDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "from_date", fromDate)); // query parameter
            if (toDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "to_date", toDate)); // query parameter
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
                Exception exception = ExceptionFactory("ListAccountTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transactions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transactions) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Transactions)));
        }

        /// <summary>
        /// List accounts for a user Use this endpoint to view information about every account that belongs to a user. You&#39;ll need the user&#39;s GUID to access this list. The information will include the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the account balance, the date the account was started, etc.
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Accounts</returns>
        public Accounts ListUserAccounts (string userGuid, int? page = null, int? recordsPerPage = null)
        {
             ApiResponse<Accounts> localVarResponse = ListUserAccountsWithHttpInfo(userGuid, page, recordsPerPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List accounts for a user Use this endpoint to view information about every account that belongs to a user. You&#39;ll need the user&#39;s GUID to access this list. The information will include the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the account balance, the date the account was started, etc.
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>ApiResponse of Accounts</returns>
        public ApiResponse< Accounts > ListUserAccountsWithHttpInfo (string userGuid, int? page = null, int? recordsPerPage = null)
        {
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling AccountsApi->ListUserAccounts");

            var localVarPath = "/users/{user_guid}/accounts";
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
                Exception exception = ExceptionFactory("ListUserAccounts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Accounts>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Accounts) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Accounts)));
        }

        /// <summary>
        /// List accounts for a user Use this endpoint to view information about every account that belongs to a user. You&#39;ll need the user&#39;s GUID to access this list. The information will include the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the account balance, the date the account was started, etc.
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of Accounts</returns>
        public async System.Threading.Tasks.Task<Accounts> ListUserAccountsAsync (string userGuid, int? page = null, int? recordsPerPage = null)
        {
             ApiResponse<Accounts> localVarResponse = await ListUserAccountsAsyncWithHttpInfo(userGuid, page, recordsPerPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List accounts for a user Use this endpoint to view information about every account that belongs to a user. You&#39;ll need the user&#39;s GUID to access this list. The information will include the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the account balance, the date the account was started, etc.
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <param name="page">Specify current page. (optional)</param>
        /// <param name="recordsPerPage">Specify records per page. (optional)</param>
        /// <returns>Task of ApiResponse (Accounts)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Accounts>> ListUserAccountsAsyncWithHttpInfo (string userGuid, int? page = null, int? recordsPerPage = null)
        {
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling AccountsApi->ListUserAccounts");

            var localVarPath = "/users/{user_guid}/accounts";
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
                Exception exception = ExceptionFactory("ListUserAccounts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Accounts>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Accounts) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Accounts)));
        }

        /// <summary>
        /// Read an account Reading an account allows you to get information about a specific account that belongs to a user. That includes the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the balance, the date the account was started, and much more.&lt;br&gt; There are two endpoints for reading an account. Both will return the same information.&lt;br&gt; It&#39;s important to remember that balance and available_balance will normally be positive numbers — for all account types. But this should be interpreted differently for debt accounts and asset accounts.&lt;br&gt; An asset account, e.g., CHECKING, SAVINGS, or INVESTMENT, will have a positive balance unless it is in an overdraft condition, in which case the balance will be negative.&lt;br&gt; On the other hand, a debt account, e.g., CREDIT CARD, LOAN, MORTGAGE, would have a positivebalance when the user owes money on the account. It would have a negative balance if the account has been overpaid. 
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Account</returns>
        public Account ReadAccount (string accountGuid, string userGuid)
        {
             ApiResponse<Account> localVarResponse = ReadAccountWithHttpInfo(accountGuid, userGuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read an account Reading an account allows you to get information about a specific account that belongs to a user. That includes the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the balance, the date the account was started, and much more.&lt;br&gt; There are two endpoints for reading an account. Both will return the same information.&lt;br&gt; It&#39;s important to remember that balance and available_balance will normally be positive numbers — for all account types. But this should be interpreted differently for debt accounts and asset accounts.&lt;br&gt; An asset account, e.g., CHECKING, SAVINGS, or INVESTMENT, will have a positive balance unless it is in an overdraft condition, in which case the balance will be negative.&lt;br&gt; On the other hand, a debt account, e.g., CREDIT CARD, LOAN, MORTGAGE, would have a positivebalance when the user owes money on the account. It would have a negative balance if the account has been overpaid. 
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of Account</returns>
        public ApiResponse< Account > ReadAccountWithHttpInfo (string accountGuid, string userGuid)
        {
            // verify the required parameter 'accountGuid' is set
            if (accountGuid == null)
                throw new ApiException(400, "Missing required parameter 'accountGuid' when calling AccountsApi->ReadAccount");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling AccountsApi->ReadAccount");

            var localVarPath = "/users/{user_guid}/accounts/{account_guid}";
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
                Exception exception = ExceptionFactory("ReadAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Account>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Account) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Account)));
        }

        /// <summary>
        /// Read an account Reading an account allows you to get information about a specific account that belongs to a user. That includes the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the balance, the date the account was started, and much more.&lt;br&gt; There are two endpoints for reading an account. Both will return the same information.&lt;br&gt; It&#39;s important to remember that balance and available_balance will normally be positive numbers — for all account types. But this should be interpreted differently for debt accounts and asset accounts.&lt;br&gt; An asset account, e.g., CHECKING, SAVINGS, or INVESTMENT, will have a positive balance unless it is in an overdraft condition, in which case the balance will be negative.&lt;br&gt; On the other hand, a debt account, e.g., CREDIT CARD, LOAN, MORTGAGE, would have a positivebalance when the user owes money on the account. It would have a negative balance if the account has been overpaid. 
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of Account</returns>
        public async System.Threading.Tasks.Task<Account> ReadAccountAsync (string accountGuid, string userGuid)
        {
             ApiResponse<Account> localVarResponse = await ReadAccountAsyncWithHttpInfo(accountGuid, userGuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read an account Reading an account allows you to get information about a specific account that belongs to a user. That includes the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the balance, the date the account was started, and much more.&lt;br&gt; There are two endpoints for reading an account. Both will return the same information.&lt;br&gt; It&#39;s important to remember that balance and available_balance will normally be positive numbers — for all account types. But this should be interpreted differently for debt accounts and asset accounts.&lt;br&gt; An asset account, e.g., CHECKING, SAVINGS, or INVESTMENT, will have a positive balance unless it is in an overdraft condition, in which case the balance will be negative.&lt;br&gt; On the other hand, a debt account, e.g., CREDIT CARD, LOAN, MORTGAGE, would have a positivebalance when the user owes money on the account. It would have a negative balance if the account has been overpaid. 
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse (Account)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Account>> ReadAccountAsyncWithHttpInfo (string accountGuid, string userGuid)
        {
            // verify the required parameter 'accountGuid' is set
            if (accountGuid == null)
                throw new ApiException(400, "Missing required parameter 'accountGuid' when calling AccountsApi->ReadAccount");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling AccountsApi->ReadAccount");

            var localVarPath = "/users/{user_guid}/accounts/{account_guid}";
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
                Exception exception = ExceptionFactory("ReadAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Account>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Account) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Account)));
        }

        /// <summary>
        /// Read an account Reading an account allows you to get information about a specific account that belongs to a user. That includes the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the balance, the date the account was started, and much more.&lt;br&gt; There are two endpoints for reading an account. Both will return the same information.&lt;br&gt; It&#39;s important to remember that balance and available_balance will normally be positive numbers — for all account types. But this should be interpreted differently for debt accounts and asset accounts.&lt;br&gt; An asset account, e.g., CHECKING, SAVINGS, or INVESTMENT, will have a positive balance unless it is in an overdraft condition, in which case the balance will be negative.&lt;br&gt; On the other hand, a debt account, e.g., CREDIT CARD, LOAN, MORTGAGE, would have a positivebalance when the user owes money on the account. It would have a negative balance if the account has been overpaid. 
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Account</returns>
        public Account ReadAccountByMemberGUID (string accountGuid, string memberGuid, string userGuid)
        {
             ApiResponse<Account> localVarResponse = ReadAccountByMemberGUIDWithHttpInfo(accountGuid, memberGuid, userGuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read an account Reading an account allows you to get information about a specific account that belongs to a user. That includes the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the balance, the date the account was started, and much more.&lt;br&gt; There are two endpoints for reading an account. Both will return the same information.&lt;br&gt; It&#39;s important to remember that balance and available_balance will normally be positive numbers — for all account types. But this should be interpreted differently for debt accounts and asset accounts.&lt;br&gt; An asset account, e.g., CHECKING, SAVINGS, or INVESTMENT, will have a positive balance unless it is in an overdraft condition, in which case the balance will be negative.&lt;br&gt; On the other hand, a debt account, e.g., CREDIT CARD, LOAN, MORTGAGE, would have a positivebalance when the user owes money on the account. It would have a negative balance if the account has been overpaid. 
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>ApiResponse of Account</returns>
        public ApiResponse< Account > ReadAccountByMemberGUIDWithHttpInfo (string accountGuid, string memberGuid, string userGuid)
        {
            // verify the required parameter 'accountGuid' is set
            if (accountGuid == null)
                throw new ApiException(400, "Missing required parameter 'accountGuid' when calling AccountsApi->ReadAccountByMemberGUID");
            // verify the required parameter 'memberGuid' is set
            if (memberGuid == null)
                throw new ApiException(400, "Missing required parameter 'memberGuid' when calling AccountsApi->ReadAccountByMemberGUID");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling AccountsApi->ReadAccountByMemberGUID");

            var localVarPath = "/users/{user_guid}/members/{member_guid}/accounts/{account_guid}";
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
                Exception exception = ExceptionFactory("ReadAccountByMemberGUID", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Account>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Account) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Account)));
        }

        /// <summary>
        /// Read an account Reading an account allows you to get information about a specific account that belongs to a user. That includes the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the balance, the date the account was started, and much more.&lt;br&gt; There are two endpoints for reading an account. Both will return the same information.&lt;br&gt; It&#39;s important to remember that balance and available_balance will normally be positive numbers — for all account types. But this should be interpreted differently for debt accounts and asset accounts.&lt;br&gt; An asset account, e.g., CHECKING, SAVINGS, or INVESTMENT, will have a positive balance unless it is in an overdraft condition, in which case the balance will be negative.&lt;br&gt; On the other hand, a debt account, e.g., CREDIT CARD, LOAN, MORTGAGE, would have a positivebalance when the user owes money on the account. It would have a negative balance if the account has been overpaid. 
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of Account</returns>
        public async System.Threading.Tasks.Task<Account> ReadAccountByMemberGUIDAsync (string accountGuid, string memberGuid, string userGuid)
        {
             ApiResponse<Account> localVarResponse = await ReadAccountByMemberGUIDAsyncWithHttpInfo(accountGuid, memberGuid, userGuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read an account Reading an account allows you to get information about a specific account that belongs to a user. That includes the account type — e.g., CHECKING, MONEY_MARKET, or PROPERTY — the balance, the date the account was started, and much more.&lt;br&gt; There are two endpoints for reading an account. Both will return the same information.&lt;br&gt; It&#39;s important to remember that balance and available_balance will normally be positive numbers — for all account types. But this should be interpreted differently for debt accounts and asset accounts.&lt;br&gt; An asset account, e.g., CHECKING, SAVINGS, or INVESTMENT, will have a positive balance unless it is in an overdraft condition, in which case the balance will be negative.&lt;br&gt; On the other hand, a debt account, e.g., CREDIT CARD, LOAN, MORTGAGE, would have a positivebalance when the user owes money on the account. It would have a negative balance if the account has been overpaid. 
        /// </summary>
        /// <exception cref="atrium.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountGuid">The unique identifier for an &#x60;account&#x60;.</param>
        /// <param name="memberGuid">The unique identifier for a &#x60;member&#x60;.</param>
        /// <param name="userGuid">The unique identifier for a &#x60;user&#x60;.</param>
        /// <returns>Task of ApiResponse (Account)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Account>> ReadAccountByMemberGUIDAsyncWithHttpInfo (string accountGuid, string memberGuid, string userGuid)
        {
            // verify the required parameter 'accountGuid' is set
            if (accountGuid == null)
                throw new ApiException(400, "Missing required parameter 'accountGuid' when calling AccountsApi->ReadAccountByMemberGUID");
            // verify the required parameter 'memberGuid' is set
            if (memberGuid == null)
                throw new ApiException(400, "Missing required parameter 'memberGuid' when calling AccountsApi->ReadAccountByMemberGUID");
            // verify the required parameter 'userGuid' is set
            if (userGuid == null)
                throw new ApiException(400, "Missing required parameter 'userGuid' when calling AccountsApi->ReadAccountByMemberGUID");

            var localVarPath = "/users/{user_guid}/members/{member_guid}/accounts/{account_guid}";
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
                Exception exception = ExceptionFactory("ReadAccountByMemberGUID", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Account>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Account) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Account)));
        }

    }
}
