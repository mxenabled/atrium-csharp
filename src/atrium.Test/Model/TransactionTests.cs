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
    ///  Class for testing Transaction
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TransactionTests
    {
        // TODO uncomment below to declare an instance variable for Transaction
        //private Transaction instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Transaction
            //instance = new Transaction();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Transaction
        /// </summary>
        [Test]
        public void TransactionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Transaction
            //Assert.IsInstanceOfType<Transaction> (instance, "variable 'instance' is a Transaction");
        }


        /// <summary>
        /// Test the property 'AccountGuid'
        /// </summary>
        [Test]
        public void AccountGuidTest()
        {
            // TODO unit test for the property 'AccountGuid'
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
        /// Test the property 'Category'
        /// </summary>
        [Test]
        public void CategoryTest()
        {
            // TODO unit test for the property 'Category'
        }
        /// <summary>
        /// Test the property 'CheckNumber'
        /// </summary>
        [Test]
        public void CheckNumberTest()
        {
            // TODO unit test for the property 'CheckNumber'
        }
        /// <summary>
        /// Test the property 'CheckNumberString'
        /// </summary>
        [Test]
        public void CheckNumberStringTest()
        {
            // TODO unit test for the property 'CheckNumberString'
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
        /// Test the property 'CurrencyCode'
        /// </summary>
        [Test]
        public void CurrencyCodeTest()
        {
            // TODO unit test for the property 'CurrencyCode'
        }
        /// <summary>
        /// Test the property 'Date'
        /// </summary>
        [Test]
        public void DateTest()
        {
            // TODO unit test for the property 'Date'
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
        /// Test the property 'Guid'
        /// </summary>
        [Test]
        public void GuidTest()
        {
            // TODO unit test for the property 'Guid'
        }
        /// <summary>
        /// Test the property 'IsBillPay'
        /// </summary>
        [Test]
        public void IsBillPayTest()
        {
            // TODO unit test for the property 'IsBillPay'
        }
        /// <summary>
        /// Test the property 'IsDirectDeposit'
        /// </summary>
        [Test]
        public void IsDirectDepositTest()
        {
            // TODO unit test for the property 'IsDirectDeposit'
        }
        /// <summary>
        /// Test the property 'IsExpense'
        /// </summary>
        [Test]
        public void IsExpenseTest()
        {
            // TODO unit test for the property 'IsExpense'
        }
        /// <summary>
        /// Test the property 'IsFee'
        /// </summary>
        [Test]
        public void IsFeeTest()
        {
            // TODO unit test for the property 'IsFee'
        }
        /// <summary>
        /// Test the property 'IsIncome'
        /// </summary>
        [Test]
        public void IsIncomeTest()
        {
            // TODO unit test for the property 'IsIncome'
        }
        /// <summary>
        /// Test the property 'IsInternational'
        /// </summary>
        [Test]
        public void IsInternationalTest()
        {
            // TODO unit test for the property 'IsInternational'
        }
        /// <summary>
        /// Test the property 'IsOverdraftFee'
        /// </summary>
        [Test]
        public void IsOverdraftFeeTest()
        {
            // TODO unit test for the property 'IsOverdraftFee'
        }
        /// <summary>
        /// Test the property 'IsPayrollAdvance'
        /// </summary>
        [Test]
        public void IsPayrollAdvanceTest()
        {
            // TODO unit test for the property 'IsPayrollAdvance'
        }
        /// <summary>
        /// Test the property 'IsSubscription'
        /// </summary>
        [Test]
        public void IsSubscriptionTest()
        {
            // TODO unit test for the property 'IsSubscription'
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
        /// Test the property 'MemberGuid'
        /// </summary>
        [Test]
        public void MemberGuidTest()
        {
            // TODO unit test for the property 'MemberGuid'
        }
        /// <summary>
        /// Test the property 'Memo'
        /// </summary>
        [Test]
        public void MemoTest()
        {
            // TODO unit test for the property 'Memo'
        }
        /// <summary>
        /// Test the property 'MerchantCategoryCode'
        /// </summary>
        [Test]
        public void MerchantCategoryCodeTest()
        {
            // TODO unit test for the property 'MerchantCategoryCode'
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
        /// Test the property 'OriginalDescription'
        /// </summary>
        [Test]
        public void OriginalDescriptionTest()
        {
            // TODO unit test for the property 'OriginalDescription'
        }
        /// <summary>
        /// Test the property 'PostedAt'
        /// </summary>
        [Test]
        public void PostedAtTest()
        {
            // TODO unit test for the property 'PostedAt'
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
        /// Test the property 'TopLevelCategory'
        /// </summary>
        [Test]
        public void TopLevelCategoryTest()
        {
            // TODO unit test for the property 'TopLevelCategory'
        }
        /// <summary>
        /// Test the property 'TransactedAt'
        /// </summary>
        [Test]
        public void TransactedAtTest()
        {
            // TODO unit test for the property 'TransactedAt'
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
