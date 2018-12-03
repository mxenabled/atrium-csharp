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
    ///  Class for testing AccountNumberAttributes
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AccountNumberAttributesTests
    {
        // TODO uncomment below to declare an instance variable for AccountNumberAttributes
        //private AccountNumberAttributes instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of AccountNumberAttributes
            //instance = new AccountNumberAttributes();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountNumberAttributes
        /// </summary>
        [Test]
        public void AccountNumberAttributesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AccountNumberAttributes
            //Assert.IsInstanceOfType<AccountNumberAttributes> (instance, "variable 'instance' is a AccountNumberAttributes");
        }


        /// <summary>
        /// Test the property 'AccountGuid'
        /// </summary>
        [Test]
        public void AccountGuidTest()
        {
            // TODO unit test for the property 'AccountGuid'
        }
        /// <summary>
        /// Test the property 'AccountNumber'
        /// </summary>
        [Test]
        public void AccountNumberTest()
        {
            // TODO unit test for the property 'AccountNumber'
        }
        /// <summary>
        /// Test the property 'MemberGuid'
        /// </summary>
        [Test]
        public void MemberGuidTest()
        {
            // TODO unit test for the property 'MemberGuid'
        }
        /// <summary>
        /// Test the property 'RoutingNumber'
        /// </summary>
        [Test]
        public void RoutingNumberTest()
        {
            // TODO unit test for the property 'RoutingNumber'
        }
        /// <summary>
        /// Test the property 'UserGuid'
        /// </summary>
        [Test]
        public void UserGuidTest()
        {
            // TODO unit test for the property 'UserGuid'
        }

    }

}
