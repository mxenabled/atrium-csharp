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
    ///  Class for testing UserAttributes
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UserAttributesTests
    {
        // TODO uncomment below to declare an instance variable for UserAttributes
        //private UserAttributes instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of UserAttributes
            //instance = new UserAttributes();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserAttributes
        /// </summary>
        [Test]
        public void UserAttributesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" UserAttributes
            //Assert.IsInstanceOfType<UserAttributes> (instance, "variable 'instance' is a UserAttributes");
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
        /// Test the property 'Identifier'
        /// </summary>
        [Test]
        public void IdentifierTest()
        {
            // TODO unit test for the property 'Identifier'
        }
        /// <summary>
        /// Test the property 'IsDisabled'
        /// </summary>
        [Test]
        public void IsDisabledTest()
        {
            // TODO unit test for the property 'IsDisabled'
        }
        /// <summary>
        /// Test the property 'Metadata'
        /// </summary>
        [Test]
        public void MetadataTest()
        {
            // TODO unit test for the property 'Metadata'
        }

    }

}
