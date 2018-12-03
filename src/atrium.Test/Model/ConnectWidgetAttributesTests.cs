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
using atrium.Api;
using atrium.Model;
using atrium.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace atrium.Test
{
    /// <summary>
    ///  Class for testing ConnectWidgetAttributes
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ConnectWidgetAttributesTests
    {
        // TODO uncomment below to declare an instance variable for ConnectWidgetAttributes
        //private ConnectWidgetAttributes instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ConnectWidgetAttributes
            //instance = new ConnectWidgetAttributes();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConnectWidgetAttributes
        /// </summary>
        [Test]
        public void ConnectWidgetAttributesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ConnectWidgetAttributes
            //Assert.IsInstanceOfType<ConnectWidgetAttributes> (instance, "variable 'instance' is a ConnectWidgetAttributes");
        }


        /// <summary>
        /// Test the property 'ConnectWidgetUrl'
        /// </summary>
        [Test]
        public void ConnectWidgetUrlTest()
        {
            // TODO unit test for the property 'ConnectWidgetUrl'
        }
        /// <summary>
        /// Test the property 'Guid'
        /// </summary>
        [Test]
        public void GuidTest()
        {
            // TODO unit test for the property 'Guid'
        }

    }

}
