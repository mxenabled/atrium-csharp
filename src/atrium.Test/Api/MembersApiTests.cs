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
    ///  Class for testing MembersApi
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MembersApiTests
    {
        private MembersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MembersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MembersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MembersApi
            //Assert.IsInstanceOfType(typeof(MembersApi), instance, "instance is a MembersApi");
        }

        
        /// <summary>
        /// Test AggregateMember
        /// </summary>
        [Test]
        public void AggregateMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //string type = null;
            //var response = instance.AggregateMember(memberGuid, userGuid, type);
            //Assert.IsInstanceOf<MemberResponseBody> (response, "response is MemberResponseBody");
        }
        
        /// <summary>
        /// Test CreateMember
        /// </summary>
        [Test]
        public void CreateMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //MemberCreateRequestBody body = null;
            //var response = instance.CreateMember(userGuid, body);
            //Assert.IsInstanceOf<MemberResponseBody> (response, "response is MemberResponseBody");
        }
        
        /// <summary>
        /// Test DeleteMember
        /// </summary>
        [Test]
        public void DeleteMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //instance.DeleteMember(memberGuid, userGuid);
            
        }
        
        /// <summary>
        /// Test ListMemberAccounts
        /// </summary>
        [Test]
        public void ListMemberAccountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //int? page = null;
            //int? recordsPerPage = null;
            //var response = instance.ListMemberAccounts(memberGuid, userGuid, page, recordsPerPage);
            //Assert.IsInstanceOf<AccountsResponseBody> (response, "response is AccountsResponseBody");
        }
        
        /// <summary>
        /// Test ListMemberCredentials
        /// </summary>
        [Test]
        public void ListMemberCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //var response = instance.ListMemberCredentials(memberGuid, userGuid);
            //Assert.IsInstanceOf<CredentialsResponseBody> (response, "response is CredentialsResponseBody");
        }
        
        /// <summary>
        /// Test ListMemberMFAChallenges
        /// </summary>
        [Test]
        public void ListMemberMFAChallengesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //var response = instance.ListMemberMFAChallenges(memberGuid, userGuid);
            //Assert.IsInstanceOf<ChallengesResponseBody> (response, "response is ChallengesResponseBody");
        }
        
        /// <summary>
        /// Test ListMemberStatements
        /// </summary>
        [Test]
        public void ListMemberStatementsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //int? page = null;
            //int? recordsPerPage = null;
            //var response = instance.ListMemberStatements(memberGuid, userGuid, page, recordsPerPage);
            //Assert.IsInstanceOf<StatementsResponseBody> (response, "response is StatementsResponseBody");
        }
        
        /// <summary>
        /// Test ListMemberTransactions
        /// </summary>
        [Test]
        public void ListMemberTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //string fromDate = null;
            //string toDate = null;
            //int? page = null;
            //int? recordsPerPage = null;
            //var response = instance.ListMemberTransactions(memberGuid, userGuid, fromDate, toDate, page, recordsPerPage);
            //Assert.IsInstanceOf<TransactionsResponseBody> (response, "response is TransactionsResponseBody");
        }
        
        /// <summary>
        /// Test ListMembers
        /// </summary>
        [Test]
        public void ListMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //int? page = null;
            //int? recordsPerPage = null;
            //var response = instance.ListMembers(userGuid, page, recordsPerPage);
            //Assert.IsInstanceOf<MembersResponseBody> (response, "response is MembersResponseBody");
        }
        
        /// <summary>
        /// Test ReadMember
        /// </summary>
        [Test]
        public void ReadMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //var response = instance.ReadMember(memberGuid, userGuid);
            //Assert.IsInstanceOf<MemberResponseBody> (response, "response is MemberResponseBody");
        }
        
        /// <summary>
        /// Test ReadMemberStatus
        /// </summary>
        [Test]
        public void ReadMemberStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //var response = instance.ReadMemberStatus(memberGuid, userGuid);
            //Assert.IsInstanceOf<MemberConnectionStatusResponseBody> (response, "response is MemberConnectionStatusResponseBody");
        }
        
        /// <summary>
        /// Test ResumeMember
        /// </summary>
        [Test]
        public void ResumeMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //MemberResumeRequestBody body = null;
            //var response = instance.ResumeMember(memberGuid, userGuid, body);
            //Assert.IsInstanceOf<MemberResponseBody> (response, "response is MemberResponseBody");
        }
        
        /// <summary>
        /// Test UpdateMember
        /// </summary>
        [Test]
        public void UpdateMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberGuid = null;
            //string userGuid = null;
            //MemberUpdateRequestBody body = null;
            //var response = instance.UpdateMember(memberGuid, userGuid, body);
            //Assert.IsInstanceOf<MemberResponseBody> (response, "response is MemberResponseBody");
        }
        
    }

}
