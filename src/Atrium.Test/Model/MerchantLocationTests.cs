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
    ///  Class for testing MerchantLocation
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MerchantLocationTests
    {
        // TODO uncomment below to declare an instance variable for MerchantLocation
        //private MerchantLocation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MerchantLocation
            //instance = new MerchantLocation();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MerchantLocation
        /// </summary>
        [Test]
        public void MerchantLocationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MerchantLocation
            //Assert.IsInstanceOfType<MerchantLocation> (instance, "variable 'instance' is a MerchantLocation");
        }


        /// <summary>
        /// Test the property 'City'
        /// </summary>
        [Test]
        public void CityTest()
        {
            // TODO unit test for the property 'City'
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
        /// Test the property 'Latitude'
        /// </summary>
        [Test]
        public void LatitudeTest()
        {
            // TODO unit test for the property 'Latitude'
        }
        /// <summary>
        /// Test the property 'Longitude'
        /// </summary>
        [Test]
        public void LongitudeTest()
        {
            // TODO unit test for the property 'Longitude'
        }
        /// <summary>
        /// Test the property 'MerchantGuid'
        /// </summary>
        [Test]
        public void MerchantGuidTest()
        {
            // TODO unit test for the property 'MerchantGuid'
        }
        /// <summary>
        /// Test the property 'PhoneNumber'
        /// </summary>
        [Test]
        public void PhoneNumberTest()
        {
            // TODO unit test for the property 'PhoneNumber'
        }
        /// <summary>
        /// Test the property 'PostalCode'
        /// </summary>
        [Test]
        public void PostalCodeTest()
        {
            // TODO unit test for the property 'PostalCode'
        }
        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'StoreNumber'
        /// </summary>
        [Test]
        public void StoreNumberTest()
        {
            // TODO unit test for the property 'StoreNumber'
        }
        /// <summary>
        /// Test the property 'StreetAddress'
        /// </summary>
        [Test]
        public void StreetAddressTest()
        {
            // TODO unit test for the property 'StreetAddress'
        }

    }

}
