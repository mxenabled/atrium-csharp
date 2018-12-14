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
    ///  Class for testing Member
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MemberTests
    {
        // TODO uncomment below to declare an instance variable for Member
        //private Member instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Member
            //instance = new Member();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Member
        /// </summary>
        [Test]
        public void MemberInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Member
            //Assert.IsInstanceOfType<Member> (instance, "variable 'instance' is a Member");
        }


        /// <summary>
        /// Test the property 'AggregatedAt'
        /// </summary>
        [Test]
        public void AggregatedAtTest()
        {
            // TODO unit test for the property 'AggregatedAt'
        }
        /// <summary>
        /// Test the property 'ConnectionStatus'
        /// </summary>
        [Test]
        public void ConnectionStatusTest()
        {
            // TODO unit test for the property 'ConnectionStatus'
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
        /// Test the property 'InstitutionCode'
        /// </summary>
        [Test]
        public void InstitutionCodeTest()
        {
            // TODO unit test for the property 'InstitutionCode'
        }
        /// <summary>
        /// Test the property 'IsBeingAggregated'
        /// </summary>
        [Test]
        public void IsBeingAggregatedTest()
        {
            // TODO unit test for the property 'IsBeingAggregated'
        }
        /// <summary>
        /// Test the property 'Metadata'
        /// </summary>
        [Test]
        public void MetadataTest()
        {
            // TODO unit test for the property 'Metadata'
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
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'SuccessfullyAggregatedAt'
        /// </summary>
        [Test]
        public void SuccessfullyAggregatedAtTest()
        {
            // TODO unit test for the property 'SuccessfullyAggregatedAt'
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
