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
    ///  Class for testing HoldingsApi
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class HoldingsApiTests
    {
        private HoldingsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new HoldingsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HoldingsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' HoldingsApi
            //Assert.IsInstanceOfType(typeof(HoldingsApi), instance, "instance is a HoldingsApi");
        }

        
        /// <summary>
        /// Test ListHoldings
        /// </summary>
        [Test]
        public void ListHoldingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //var response = instance.ListHoldings(userGuid);
            //Assert.IsInstanceOf<HoldingsResponseBody> (response, "response is HoldingsResponseBody");
        }
        
        /// <summary>
        /// Test ListHoldingsByAccount
        /// </summary>
        [Test]
        public void ListHoldingsByAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountGuid = null;
            //string userGuid = null;
            //var response = instance.ListHoldingsByAccount(accountGuid, userGuid);
            //Assert.IsInstanceOf<HoldingsResponseBody> (response, "response is HoldingsResponseBody");
        }
        
        /// <summary>
        /// Test ListHoldingsByMember
        /// </summary>
        [Test]
        public void ListHoldingsByMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //var response = instance.ListHoldingsByMember(memberGuid, userGuid);
            //Assert.IsInstanceOf<HoldingsResponseBody> (response, "response is HoldingsResponseBody");
        }
        
        /// <summary>
        /// Test ReadHolding
        /// </summary>
        [Test]
        public void ReadHoldingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string holdingGuid = null;
            //string userGuid = null;
            //var response = instance.ReadHolding(holdingGuid, userGuid);
            //Assert.IsInstanceOf<HoldingResponseBody> (response, "response is HoldingResponseBody");
        }
        
    }

}
