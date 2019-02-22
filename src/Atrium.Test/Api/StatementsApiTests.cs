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
    ///  Class for testing StatementsApi
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class StatementsApiTests
    {
        private StatementsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StatementsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StatementsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' StatementsApi
            //Assert.IsInstanceOfType(typeof(StatementsApi), instance, "instance is a StatementsApi");
        }

        
        /// <summary>
        /// Test DownloadStatementPdf
        /// </summary>
        [Test]
        public void DownloadStatementPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //string statementGuid = null;
            //var response = instance.DownloadStatementPdf(memberGuid, userGuid, statementGuid);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test FetchStatements
        /// </summary>
        [Test]
        public void FetchStatementsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //var response = instance.FetchStatements(memberGuid, userGuid);
            //Assert.IsInstanceOf<MemberResponseBody> (response, "response is MemberResponseBody");
        }
        
        /// <summary>
        /// Test ListMemberStatements
        /// </summary>
        [Test]
        public void ListMemberStatementsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //int? page = null;
            //int? recordsPerPage = null;
            //var response = instance.ListMemberStatements(memberGuid, userGuid, page, recordsPerPage);
            //Assert.IsInstanceOf<StatementsResponseBody> (response, "response is StatementsResponseBody");
        }
        
        /// <summary>
        /// Test ReadMemberStatement
        /// </summary>
        [Test]
        public void ReadMemberStatementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //string statementGuid = null;
            //var response = instance.ReadMemberStatement(memberGuid, userGuid, statementGuid);
            //Assert.IsInstanceOf<StatementResponseBody> (response, "response is StatementResponseBody");
        }
        
    }

}
