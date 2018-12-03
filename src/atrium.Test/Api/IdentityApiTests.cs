/* 
 * MX API
 *
 * The MX Atrium API supports over 48,000 data connections to thousands of financial institutions. It provides secure access to your users' accounts and transactions with industry-leading cleansing, categorization, and classification.  Atrium is designed according to resource-oriented REST architecture and responds with JSON bodies and HTTP response codes.  Use Atrium's development environment, vestibule.mx.com, to quickly get up and running. The development environment limits are 100 users, 25 members per user, and access to the top 15 institutions. Contact MX to purchase production access. 
 *
 * OpenAPI spec version: 0.1
 * 
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using atrium.Client;
using atrium.Api;
using atrium.Model;

namespace atrium.Test
{
    /// <summary>
    ///  Class for testing IdentityApi
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class IdentityApiTests
    {
        private IdentityApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new IdentityApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IdentityApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' IdentityApi
            //Assert.IsInstanceOfType(typeof(IdentityApi), instance, "instance is a IdentityApi");
        }

        
        /// <summary>
        /// Test IdentifyMember
        /// </summary>
        [Test]
        public void IdentifyMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //var response = instance.IdentifyMember(memberGuid, userGuid);
            //Assert.IsInstanceOf<Member> (response, "response is Member");
        }
        
        /// <summary>
        /// Test ListAccountOwners
        /// </summary>
        [Test]
        public void ListAccountOwnersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //var response = instance.ListAccountOwners(memberGuid, userGuid);
            //Assert.IsInstanceOf<AccountOwners> (response, "response is AccountOwners");
        }
        
    }

}
