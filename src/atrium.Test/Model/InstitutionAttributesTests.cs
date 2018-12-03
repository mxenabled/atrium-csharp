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
    ///  Class for testing InstitutionAttributes
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class InstitutionAttributesTests
    {
        // TODO uncomment below to declare an instance variable for InstitutionAttributes
        //private InstitutionAttributes instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InstitutionAttributes
            //instance = new InstitutionAttributes();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InstitutionAttributes
        /// </summary>
        [Test]
        public void InstitutionAttributesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InstitutionAttributes
            //Assert.IsInstanceOfType<InstitutionAttributes> (instance, "variable 'instance' is a InstitutionAttributes");
        }


        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Test]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }
        /// <summary>
        /// Test the property 'MediumLogoUrl'
        /// </summary>
        [Test]
        public void MediumLogoUrlTest()
        {
            // TODO unit test for the property 'MediumLogoUrl'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'SmallLogoUrl'
        /// </summary>
        [Test]
        public void SmallLogoUrlTest()
        {
            // TODO unit test for the property 'SmallLogoUrl'
        }
        /// <summary>
        /// Test the property 'SupportsAccountIdentification'
        /// </summary>
        [Test]
        public void SupportsAccountIdentificationTest()
        {
            // TODO unit test for the property 'SupportsAccountIdentification'
        }
        /// <summary>
        /// Test the property 'SupportsAccountVerification'
        /// </summary>
        [Test]
        public void SupportsAccountVerificationTest()
        {
            // TODO unit test for the property 'SupportsAccountVerification'
        }
        /// <summary>
        /// Test the property 'Url'
        /// </summary>
        [Test]
        public void UrlTest()
        {
            // TODO unit test for the property 'Url'
        }

    }

}
