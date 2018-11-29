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

using atrium-csharp.Client;
using atrium-csharp.Api;
using atrium-csharp.Model;

namespace atrium-csharp.Test
{
    /// <summary>
    ///  Class for testing TransactionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TransactionsApiTests
    {
        private TransactionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TransactionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TransactionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TransactionsApi
            //Assert.IsInstanceOfType(typeof(TransactionsApi), instance, "instance is a TransactionsApi");
        }

        
        /// <summary>
        /// Test CleanseAndCategorizeTransactions
        /// </summary>
        [Test]
        public void CleanseAndCategorizeTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TransactionsCleanseAndCategorizeRequestBody body = null;
            //var response = instance.CleanseAndCategorizeTransactions(body);
            //Assert.IsInstanceOf<TransactionsCleanseAndCategorize> (response, "response is TransactionsCleanseAndCategorize");
        }
        
        /// <summary>
        /// Test ListUserTransactions
        /// </summary>
        [Test]
        public void ListUserTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //int? page = null;
            //string fromDate = null;
            //int? recordsPerPage = null;
            //string toDate = null;
            //var response = instance.ListUserTransactions(userGuid, page, fromDate, recordsPerPage, toDate);
            //Assert.IsInstanceOf<Transactions> (response, "response is Transactions");
        }
        
        /// <summary>
        /// Test ReadTransaction
        /// </summary>
        [Test]
        public void ReadTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string transactionGuid = null;
            //string userGuid = null;
            //var response = instance.ReadTransaction(transactionGuid, userGuid);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
    }

}
