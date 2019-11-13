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
    ///  Class for testing ConnectWidgetRequestBody
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ConnectWidgetRequestBodyTests
    {
        // TODO uncomment below to declare an instance variable for ConnectWidgetRequestBody
        //private ConnectWidgetRequestBody instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ConnectWidgetRequestBody
            //instance = new ConnectWidgetRequestBody();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConnectWidgetRequestBody
        /// </summary>
        [Test]
        public void ConnectWidgetRequestBodyInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ConnectWidgetRequestBody
            //Assert.IsInstanceOfType<ConnectWidgetRequestBody> (instance, "variable 'instance' is a ConnectWidgetRequestBody");
        }


        /// <summary>
        /// Test the property 'IsMobileWebview'
        /// </summary>
        [Test]
        public void IsMobileWebviewTest()
        {
            // TODO unit test for the property 'IsMobileWebview'
        }
        /// <summary>
        /// Test the property 'CurrentInstitutionCode'
        /// </summary>
        [Test]
        public void CurrentInstitutionCodeTest()
        {
            // TODO unit test for the property 'CurrentInstitutionCode'
        }
        /// <summary>
        /// Test the property 'CurrentMemberGuid'
        /// </summary>
        [Test]
        public void CurrentMemberGuidTest()
        {
            // TODO unit test for the property 'CurrentMemberGuid'
        }
        /// <summary>
        /// Test the property 'DisableInstitutionSearch'
        /// </summary>
        [Test]
        public void DisableInstitutionSearchTest()
        {
            // TODO unit test for the property 'DisableInstitutionSearch'
        }
        /// <summary>
        /// Test the property 'Mode'
        /// </summary>
        [Test]
        public void ModeTest()
        {
            // TODO unit test for the property 'Mode'
        }
        /// <summary>
        /// Test the property 'UiMessageVersion'
        /// </summary>
        [Test]
        public void UiMessageVersionTest()
        {
            // TODO unit test for the property 'UiMessageVersion'
        }
        /// <summary>
        /// Test the property 'UpdateCredentials'
        /// </summary>
        [Test]
        public void UpdateCredentialsTest()
        {
            // TODO unit test for the property 'UpdateCredentials'
        }

    }

}
