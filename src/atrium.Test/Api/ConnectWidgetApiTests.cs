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
    ///  Class for testing ConnectWidgetApi
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ConnectWidgetApiTests
    {
        private ConnectWidgetApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConnectWidgetApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConnectWidgetApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ConnectWidgetApi
            //Assert.IsInstanceOfType(typeof(ConnectWidgetApi), instance, "instance is a ConnectWidgetApi");
        }

        
        /// <summary>
        /// Test GetConnectWidget
        /// </summary>
        [Test]
        public void GetConnectWidgetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //ConnectWidgetRequestBody body = null;
            //var response = instance.GetConnectWidget(userGuid, body);
            //Assert.IsInstanceOf<ConnectWidgetResponseBody> (response, "response is ConnectWidgetResponseBody");
        }
        
    }

}
