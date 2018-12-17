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
    ///  Class for testing AccountNumber
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AccountNumberTests
    {
        // TODO uncomment below to declare an instance variable for AccountNumber
        //private AccountNumber instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of AccountNumber
            //instance = new AccountNumber();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountNumber
        /// </summary>
        [Test]
        public void AccountNumberInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AccountNumber
            //Assert.IsInstanceOfType<AccountNumber> (instance, "variable 'instance' is a AccountNumber");
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
        /// Test the property '_AccountNumber'
        /// </summary>
        [Test]
        public void _AccountNumberTest()
        {
            // TODO unit test for the property '_AccountNumber'
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
