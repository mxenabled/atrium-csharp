/* 
 * MX API
 *
 * The MX Atrium API supports over 48,000 data connections to thousands of financial institutions. It provides secure access to your users' accounts and transactions with industry-leading cleansing, categorization, and classification.  Atrium is designed according to resource-oriented REST architecture and responds with JSON bodies and HTTP response codes.  Use Atrium's development environment, vestibule.mx.com, to quickly get up and running. The development environment limits are 100 users, 25 members per user, and access to the top 15 institutions. Contact MX to purchase production access. 
 *
 * OpenAPI spec version: 0.1
 * 
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Atrium.Client;
using Atrium.Api;
using Atrium.Model;

namespace Atrium.Test
{
    /// <summary>
    ///  Class for testing AccountsApi
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AccountsApiTests
    {
        private AccountsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AccountsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AccountsApi
            //Assert.IsInstanceOfType(typeof(AccountsApi), instance, "instance is a AccountsApi");
        }

        
        /// <summary>
        /// Test ListAccountTransactions
        /// </summary>
        [Test]
        public void ListAccountTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountGuid = null;
            //string userGuid = null;
            //string fromDate = null;
            //string toDate = null;
            //int? page = null;
            //int? recordsPerPage = null;
            //var response = instance.ListAccountTransactions(accountGuid, userGuid, fromDate, toDate, page, recordsPerPage);
            //Assert.IsInstanceOf<Transactions> (response, "response is Transactions");
        }
        
        /// <summary>
        /// Test ListUserAccounts
        /// </summary>
        [Test]
        public void ListUserAccountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //int? page = null;
            //int? recordsPerPage = null;
            //var response = instance.ListUserAccounts(userGuid, page, recordsPerPage);
            //Assert.IsInstanceOf<Accounts> (response, "response is Accounts");
        }
        
        /// <summary>
        /// Test ReadAccount
        /// </summary>
        [Test]
        public void ReadAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountGuid = null;
            //string userGuid = null;
            //var response = instance.ReadAccount(accountGuid, userGuid);
            //Assert.IsInstanceOf<Account> (response, "response is Account");
        }
        
        /// <summary>
        /// Test ReadAccountByMemberGUID
        /// </summary>
        [Test]
        public void ReadAccountByMemberGUIDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountGuid = null;
            //string memberGuid = null;
            //string userGuid = null;
            //var response = instance.ReadAccountByMemberGUID(accountGuid, memberGuid, userGuid);
            //Assert.IsInstanceOf<Account> (response, "response is Account");
        }
        
    }

}
