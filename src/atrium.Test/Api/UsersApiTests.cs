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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UsersApiTests
    {
        private UsersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UsersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UsersApi
            //Assert.IsInstanceOfType(typeof(UsersApi), instance, "instance is a UsersApi");
        }

        
        /// <summary>
        /// Test CreateUser
        /// </summary>
        [Test]
        public void CreateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserCreateRequestBody body = null;
            //var response = instance.CreateUser(body);
            //Assert.IsInstanceOf<UserResponseBody> (response, "response is UserResponseBody");
        }
        
        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Test]
        public void DeleteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //instance.DeleteUser(userGuid);
            
        }
        
        /// <summary>
        /// Test ListUsers
        /// </summary>
        [Test]
        public void ListUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? recordsPerPage = null;
            //var response = instance.ListUsers(page, recordsPerPage);
            //Assert.IsInstanceOf<UsersResponseBody> (response, "response is UsersResponseBody");
        }
        
        /// <summary>
        /// Test ReadUser
        /// </summary>
        [Test]
        public void ReadUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //var response = instance.ReadUser(userGuid);
            //Assert.IsInstanceOf<UserResponseBody> (response, "response is UserResponseBody");
        }
        
        /// <summary>
        /// Test UpdateUser
        /// </summary>
        [Test]
        public void UpdateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGuid = null;
            //UserUpdateRequestBody body = null;
            //var response = instance.UpdateUser(userGuid, body);
            //Assert.IsInstanceOf<UserResponseBody> (response, "response is UserResponseBody");
        }
        
    }

}
