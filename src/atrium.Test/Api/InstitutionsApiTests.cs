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
    ///  Class for testing InstitutionsApi
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class InstitutionsApiTests
    {
        private InstitutionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InstitutionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InstitutionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InstitutionsApi
            //Assert.IsInstanceOfType(typeof(InstitutionsApi), instance, "instance is a InstitutionsApi");
        }

        
        /// <summary>
        /// Test ListInstitutions
        /// </summary>
        [Test]
        public void ListInstitutionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //int? page = null;
            //int? recordsPerPage = null;
            //var response = instance.ListInstitutions(name, page, recordsPerPage);
            //Assert.IsInstanceOf<Institutions> (response, "response is Institutions");
        }
        
        /// <summary>
        /// Test ReadInstitution
        /// </summary>
        [Test]
        public void ReadInstitutionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string institutionCode = null;
            //var response = instance.ReadInstitution(institutionCode);
            //Assert.IsInstanceOf<Institution> (response, "response is Institution");
        }
        
        /// <summary>
        /// Test ReadInstitutionCredentials
        /// </summary>
        [Test]
        public void ReadInstitutionCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string institutionCode = null;
            //var response = instance.ReadInstitutionCredentials(institutionCode);
            //Assert.IsInstanceOf<Credentials> (response, "response is Credentials");
        }
        
    }

}
