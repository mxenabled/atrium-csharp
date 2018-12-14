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
    ///  Class for testing TransactionResponseBody
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TransactionResponseBodyTests
    {
        // TODO uncomment below to declare an instance variable for TransactionResponseBody
        //private TransactionResponseBody instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TransactionResponseBody
            //instance = new TransactionResponseBody();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TransactionResponseBody
        /// </summary>
        [Test]
        public void TransactionResponseBodyInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TransactionResponseBody
            //Assert.IsInstanceOfType<TransactionResponseBody> (instance, "variable 'instance' is a TransactionResponseBody");
        }


        /// <summary>
        /// Test the property 'Transaction'
        /// </summary>
        [Test]
        public void TransactionTest()
        {
            // TODO unit test for the property 'Transaction'
        }

    }

}
