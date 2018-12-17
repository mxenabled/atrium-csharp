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

using Atrium.Client;
using Atrium.Api;
using Atrium.Model;

namespace Atrium.Test
{
    /// <summary>
    ///  Class for testing VerificationApi
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class VerificationApiTests
    {
        private VerificationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VerificationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VerificationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' VerificationApi
            //Assert.IsInstanceOfType(typeof(VerificationApi), instance, "instance is a VerificationApi");
        }

        
        /// <summary>
        /// Test ListAccountNumbers
        /// </summary>
        [Test]
        public void ListAccountNumbersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //var response = instance.ListAccountNumbers(memberGuid, userGuid);
            //Assert.IsInstanceOf<AccountNumbersResponseBody> (response, "response is AccountNumbersResponseBody");
        }
        
        /// <summary>
        /// Test ListAccountNumbersByAccount
        /// </summary>
        [Test]
        public void ListAccountNumbersByAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountGuid = null;
            //string userGuid = null;
            //var response = instance.ListAccountNumbersByAccount(accountGuid, userGuid);
            //Assert.IsInstanceOf<AccountNumbersResponseBody> (response, "response is AccountNumbersResponseBody");
        }
        
        /// <summary>
        /// Test VerifyMember
        /// </summary>
        [Test]
        public void VerifyMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //var response = instance.VerifyMember(memberGuid, userGuid);
            //Assert.IsInstanceOf<MemberResponseBody> (response, "response is MemberResponseBody");
        }
        
    }

}
