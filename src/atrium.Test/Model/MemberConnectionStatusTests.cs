/* 
 * MX API
 *
 * The MX Atrium API supports over 48,000 data connections to thousands of financial institutions. It provides secure access to your users' accounts and transactions with industry-leading cleansing, categorization, and classification.  Atrium is designed according to resource-oriented REST architecture and responds with JSON bodies and HTTP response codes.  Use Atrium's development environment, vestibule.mx.com, to quickly get up and running. The development environment limits are 100 users, 25 members per user, and access to the top 15 institutions. Contact MX to purchase production access. 
 *
 * OpenAPI spec version: 0.1
 * 
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Atrium.Api;
using Atrium.Model;
using Atrium.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Atrium.Test
{
    /// <summary>
    ///  Class for testing MemberConnectionStatus
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MemberConnectionStatusTests
    {
        // TODO uncomment below to declare an instance variable for MemberConnectionStatus
        //private MemberConnectionStatus instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MemberConnectionStatus
            //instance = new MemberConnectionStatus();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MemberConnectionStatus
        /// </summary>
        [Test]
        public void MemberConnectionStatusInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MemberConnectionStatus
            //Assert.IsInstanceOfType<MemberConnectionStatus> (instance, "variable 'instance' is a MemberConnectionStatus");
        }


        /// <summary>
        /// Test the property 'AggregatedAt'
        /// </summary>
        [Test]
        public void AggregatedAtTest()
        {
            // TODO unit test for the property 'AggregatedAt'
        }
        /// <summary>
        /// Test the property 'Challenges'
        /// </summary>
        [Test]
        public void ChallengesTest()
        {
            // TODO unit test for the property 'Challenges'
        }
        /// <summary>
        /// Test the property 'ConnectionStatus'
        /// </summary>
        [Test]
        public void ConnectionStatusTest()
        {
            // TODO unit test for the property 'ConnectionStatus'
        }
        /// <summary>
        /// Test the property 'Guid'
        /// </summary>
        [Test]
        public void GuidTest()
        {
            // TODO unit test for the property 'Guid'
        }
        /// <summary>
        /// Test the property 'HasProcessedAccounts'
        /// </summary>
        [Test]
        public void HasProcessedAccountsTest()
        {
            // TODO unit test for the property 'HasProcessedAccounts'
        }
        /// <summary>
        /// Test the property 'HasProcessedTransactions'
        /// </summary>
        [Test]
        public void HasProcessedTransactionsTest()
        {
            // TODO unit test for the property 'HasProcessedTransactions'
        }
        /// <summary>
        /// Test the property 'IsAuthenticated'
        /// </summary>
        [Test]
        public void IsAuthenticatedTest()
        {
            // TODO unit test for the property 'IsAuthenticated'
        }
        /// <summary>
        /// Test the property 'IsBeingAggregated'
        /// </summary>
        [Test]
        public void IsBeingAggregatedTest()
        {
            // TODO unit test for the property 'IsBeingAggregated'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'SuccessfullyAggregatedAt'
        /// </summary>
        [Test]
        public void SuccessfullyAggregatedAtTest()
        {
            // TODO unit test for the property 'SuccessfullyAggregatedAt'
        }

    }

}
