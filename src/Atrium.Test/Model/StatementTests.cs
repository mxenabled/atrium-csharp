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
    ///  Class for testing Statement
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class StatementTests
    {
        // TODO uncomment below to declare an instance variable for Statement
        //private Statement instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Statement
            //instance = new Statement();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Statement
        /// </summary>
        [Test]
        public void StatementInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Statement
            //Assert.IsInstanceOfType<Statement> (instance, "variable 'instance' is a Statement");
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
        /// Test the property 'CreatedAt'
        /// </summary>
        [Test]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
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
        /// Test the property 'MemberGuid'
        /// </summary>
        [Test]
        public void MemberGuidTest()
        {
            // TODO unit test for the property 'MemberGuid'
        }
        /// <summary>
        /// Test the property 'Uri'
        /// </summary>
        [Test]
        public void UriTest()
        {
            // TODO unit test for the property 'Uri'
        }
        /// <summary>
        /// Test the property 'UserGuid'
        /// </summary>
        [Test]
        public void UserGuidTest()
        {
            // TODO unit test for the property 'UserGuid'
        }
        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Test]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
        }

    }

}
