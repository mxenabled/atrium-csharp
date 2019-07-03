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
    ///  Class for testing Account
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AccountTests
    {
        // TODO uncomment below to declare an instance variable for Account
        //private Account instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Account
            //instance = new Account();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Account
        /// </summary>
        [Test]
        public void AccountInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Account
            //Assert.IsInstanceOfType<Account> (instance, "variable 'instance' is a Account");
        }


        /// <summary>
        /// Test the property 'Apr'
        /// </summary>
        [Test]
        public void AprTest()
        {
            // TODO unit test for the property 'Apr'
        }
        /// <summary>
        /// Test the property 'Apy'
        /// </summary>
        [Test]
        public void ApyTest()
        {
            // TODO unit test for the property 'Apy'
        }
        /// <summary>
        /// Test the property 'AvailableBalance'
        /// </summary>
        [Test]
        public void AvailableBalanceTest()
        {
            // TODO unit test for the property 'AvailableBalance'
        }
        /// <summary>
        /// Test the property 'AvailableCredit'
        /// </summary>
        [Test]
        public void AvailableCreditTest()
        {
            // TODO unit test for the property 'AvailableCredit'
        }
        /// <summary>
        /// Test the property 'Balance'
        /// </summary>
        [Test]
        public void BalanceTest()
        {
            // TODO unit test for the property 'Balance'
        }
        /// <summary>
        /// Test the property 'CashBalance'
        /// </summary>
        [Test]
        public void CashBalanceTest()
        {
            // TODO unit test for the property 'CashBalance'
        }
        /// <summary>
        /// Test the property 'CashSurrenderValue'
        /// </summary>
        [Test]
        public void CashSurrenderValueTest()
        {
            // TODO unit test for the property 'CashSurrenderValue'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Test]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'CreditLimit'
        /// </summary>
        [Test]
        public void CreditLimitTest()
        {
            // TODO unit test for the property 'CreditLimit'
        }
        /// <summary>
        /// Test the property 'CurrencyCode'
        /// </summary>
        [Test]
        public void CurrencyCodeTest()
        {
            // TODO unit test for the property 'CurrencyCode'
        }
        /// <summary>
        /// Test the property 'DayPaymentIsDue'
        /// </summary>
        [Test]
        public void DayPaymentIsDueTest()
        {
            // TODO unit test for the property 'DayPaymentIsDue'
        }
        /// <summary>
        /// Test the property 'DeathBenefit'
        /// </summary>
        [Test]
        public void DeathBenefitTest()
        {
            // TODO unit test for the property 'DeathBenefit'
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
        /// Test the property 'HoldingsValue'
        /// </summary>
        [Test]
        public void HoldingsValueTest()
        {
            // TODO unit test for the property 'HoldingsValue'
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
        /// Test the property 'InterestRate'
        /// </summary>
        [Test]
        public void InterestRateTest()
        {
            // TODO unit test for the property 'InterestRate'
        }
        /// <summary>
        /// Test the property 'IsClosed'
        /// </summary>
        [Test]
        public void IsClosedTest()
        {
            // TODO unit test for the property 'IsClosed'
        }
        /// <summary>
        /// Test the property 'LastPayment'
        /// </summary>
        [Test]
        public void LastPaymentTest()
        {
            // TODO unit test for the property 'LastPayment'
        }
        /// <summary>
        /// Test the property 'LoanAmount'
        /// </summary>
        [Test]
        public void LoanAmountTest()
        {
            // TODO unit test for the property 'LoanAmount'
        }
        /// <summary>
        /// Test the property 'MaturesOn'
        /// </summary>
        [Test]
        public void MaturesOnTest()
        {
            // TODO unit test for the property 'MaturesOn'
        }
        /// <summary>
        /// Test the property 'MemberGuid'
        /// </summary>
        [Test]
        public void MemberGuidTest()
        {
            // TODO unit test for the property 'MemberGuid'
        }
        /// <summary>
        /// Test the property 'MinimumBalance'
        /// </summary>
        [Test]
        public void MinimumBalanceTest()
        {
            // TODO unit test for the property 'MinimumBalance'
        }
        /// <summary>
        /// Test the property 'MinimumPayment'
        /// </summary>
        [Test]
        public void MinimumPaymentTest()
        {
            // TODO unit test for the property 'MinimumPayment'
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
        /// Test the property 'OriginalBalance'
        /// </summary>
        [Test]
        public void OriginalBalanceTest()
        {
            // TODO unit test for the property 'OriginalBalance'
        }
        /// <summary>
        /// Test the property 'PaymentDueAt'
        /// </summary>
        [Test]
        public void PaymentDueAtTest()
        {
            // TODO unit test for the property 'PaymentDueAt'
        }
        /// <summary>
        /// Test the property 'PayoffBalance'
        /// </summary>
        [Test]
        public void PayoffBalanceTest()
        {
            // TODO unit test for the property 'PayoffBalance'
        }
        /// <summary>
        /// Test the property 'StartedOn'
        /// </summary>
        [Test]
        public void StartedOnTest()
        {
            // TODO unit test for the property 'StartedOn'
        }
        /// <summary>
        /// Test the property 'Subtype'
        /// </summary>
        [Test]
        public void SubtypeTest()
        {
            // TODO unit test for the property 'Subtype'
        }
        /// <summary>
        /// Test the property 'TotalAccountValue'
        /// </summary>
        [Test]
        public void TotalAccountValueTest()
        {
            // TODO unit test for the property 'TotalAccountValue'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Test]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
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
