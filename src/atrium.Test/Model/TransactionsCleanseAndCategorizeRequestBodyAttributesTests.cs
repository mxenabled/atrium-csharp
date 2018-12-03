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
    ///  Class for testing TransactionsCleanseAndCategorizeRequestBodyAttributes
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TransactionsCleanseAndCategorizeRequestBodyAttributesTests
    {
        // TODO uncomment below to declare an instance variable for TransactionsCleanseAndCategorizeRequestBodyAttributes
        //private TransactionsCleanseAndCategorizeRequestBodyAttributes instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TransactionsCleanseAndCategorizeRequestBodyAttributes
            //instance = new TransactionsCleanseAndCategorizeRequestBodyAttributes();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TransactionsCleanseAndCategorizeRequestBodyAttributes
        /// </summary>
        [Test]
        public void TransactionsCleanseAndCategorizeRequestBodyAttributesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TransactionsCleanseAndCategorizeRequestBodyAttributes
            //Assert.IsInstanceOfType<TransactionsCleanseAndCategorizeRequestBodyAttributes> (instance, "variable 'instance' is a TransactionsCleanseAndCategorizeRequestBodyAttributes");
        }


        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Test]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
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
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }

    }

}
