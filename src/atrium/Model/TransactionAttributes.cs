/* 
 * MX API
 *
 * The MX Atrium API supports over 48,000 data connections to thousands of financial institutions. It provides secure access to your users' accounts and transactions with industry-leading cleansing, categorization, and classification.  Atrium is designed according to resource-oriented REST architecture and responds with JSON bodies and HTTP response codes.  Use Atrium's development environment, vestibule.mx.com, to quickly get up and running. The development environment limits are 100 users, 25 members per user, and access to the top 15 institutions. Contact MX to purchase production access. 
 *
 * OpenAPI spec version: 0.1
 * 
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using DateConverter = atrium.Client.DateConverter;

namespace atrium.Model
{
    /// <summary>
    /// TransactionAttributes
    /// </summary>
    [DataContract]
    public partial class TransactionAttributes :  IEquatable<TransactionAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TransactionAttributes()
        {
        }
        
        /// <summary>
        /// Gets or Sets AccountGuid
        /// </summary>
        [DataMember(Name="account_guid", EmitDefaultValue=false)]
        public string AccountGuid { get; private set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; private set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; private set; }

        /// <summary>
        /// Gets or Sets CheckNumber
        /// </summary>
        [DataMember(Name="check_number", EmitDefaultValue=false)]
        public int? CheckNumber { get; private set; }

        /// <summary>
        /// Gets or Sets CheckNumberString
        /// </summary>
        [DataMember(Name="check_number_string", EmitDefaultValue=false)]
        public string CheckNumberString { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; private set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; private set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; private set; }

        /// <summary>
        /// Gets or Sets IsBillPay
        /// </summary>
        [DataMember(Name="is_bill_pay", EmitDefaultValue=false)]
        public bool? IsBillPay { get; private set; }

        /// <summary>
        /// Gets or Sets IsDirectDeposit
        /// </summary>
        [DataMember(Name="is_direct_deposit", EmitDefaultValue=false)]
        public bool? IsDirectDeposit { get; private set; }

        /// <summary>
        /// Gets or Sets IsExpense
        /// </summary>
        [DataMember(Name="is_expense", EmitDefaultValue=false)]
        public bool? IsExpense { get; private set; }

        /// <summary>
        /// Gets or Sets IsFee
        /// </summary>
        [DataMember(Name="is_fee", EmitDefaultValue=false)]
        public bool? IsFee { get; private set; }

        /// <summary>
        /// Gets or Sets IsIncome
        /// </summary>
        [DataMember(Name="is_income", EmitDefaultValue=false)]
        public bool? IsIncome { get; private set; }

        /// <summary>
        /// Gets or Sets IsInternational
        /// </summary>
        [DataMember(Name="is_international", EmitDefaultValue=false)]
        public bool? IsInternational { get; private set; }

        /// <summary>
        /// Gets or Sets IsOverdraftFee
        /// </summary>
        [DataMember(Name="is_overdraft_fee", EmitDefaultValue=false)]
        public bool? IsOverdraftFee { get; private set; }

        /// <summary>
        /// Gets or Sets IsPayrollAdvance
        /// </summary>
        [DataMember(Name="is_payroll_advance", EmitDefaultValue=false)]
        public bool? IsPayrollAdvance { get; private set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public decimal? Latitude { get; private set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public decimal? Longitude { get; private set; }

        /// <summary>
        /// Gets or Sets MemberGuid
        /// </summary>
        [DataMember(Name="member_guid", EmitDefaultValue=false)]
        public string MemberGuid { get; private set; }

        /// <summary>
        /// Gets or Sets Memo
        /// </summary>
        [DataMember(Name="memo", EmitDefaultValue=false)]
        public string Memo { get; private set; }

        /// <summary>
        /// Gets or Sets MerchantCategoryCode
        /// </summary>
        [DataMember(Name="merchant_category_code", EmitDefaultValue=false)]
        public int? MerchantCategoryCode { get; private set; }

        /// <summary>
        /// Gets or Sets OriginalDescription
        /// </summary>
        [DataMember(Name="original_description", EmitDefaultValue=false)]
        public string OriginalDescription { get; private set; }

        /// <summary>
        /// Gets or Sets PostedAt
        /// </summary>
        [DataMember(Name="posted_at", EmitDefaultValue=false)]
        public string PostedAt { get; private set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }

        /// <summary>
        /// Gets or Sets TopLevelCategory
        /// </summary>
        [DataMember(Name="top_level_category", EmitDefaultValue=false)]
        public string TopLevelCategory { get; private set; }

        /// <summary>
        /// Gets or Sets TransactedAt
        /// </summary>
        [DataMember(Name="transacted_at", EmitDefaultValue=false)]
        public string TransactedAt { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets UserGuid
        /// </summary>
        [DataMember(Name="user_guid", EmitDefaultValue=false)]
        public string UserGuid { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionAttributes {\n");
            sb.Append("  AccountGuid: ").Append(AccountGuid).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  CheckNumber: ").Append(CheckNumber).Append("\n");
            sb.Append("  CheckNumberString: ").Append(CheckNumberString).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  IsBillPay: ").Append(IsBillPay).Append("\n");
            sb.Append("  IsDirectDeposit: ").Append(IsDirectDeposit).Append("\n");
            sb.Append("  IsExpense: ").Append(IsExpense).Append("\n");
            sb.Append("  IsFee: ").Append(IsFee).Append("\n");
            sb.Append("  IsIncome: ").Append(IsIncome).Append("\n");
            sb.Append("  IsInternational: ").Append(IsInternational).Append("\n");
            sb.Append("  IsOverdraftFee: ").Append(IsOverdraftFee).Append("\n");
            sb.Append("  IsPayrollAdvance: ").Append(IsPayrollAdvance).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  MemberGuid: ").Append(MemberGuid).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  MerchantCategoryCode: ").Append(MerchantCategoryCode).Append("\n");
            sb.Append("  OriginalDescription: ").Append(OriginalDescription).Append("\n");
            sb.Append("  PostedAt: ").Append(PostedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TopLevelCategory: ").Append(TopLevelCategory).Append("\n");
            sb.Append("  TransactedAt: ").Append(TransactedAt).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  UserGuid: ").Append(UserGuid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransactionAttributes);
        }

        /// <summary>
        /// Returns true if TransactionAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountGuid == input.AccountGuid ||
                    (this.AccountGuid != null &&
                    this.AccountGuid.Equals(input.AccountGuid))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.CheckNumber == input.CheckNumber ||
                    (this.CheckNumber != null &&
                    this.CheckNumber.Equals(input.CheckNumber))
                ) && 
                (
                    this.CheckNumberString == input.CheckNumberString ||
                    (this.CheckNumberString != null &&
                    this.CheckNumberString.Equals(input.CheckNumberString))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.IsBillPay == input.IsBillPay ||
                    (this.IsBillPay != null &&
                    this.IsBillPay.Equals(input.IsBillPay))
                ) && 
                (
                    this.IsDirectDeposit == input.IsDirectDeposit ||
                    (this.IsDirectDeposit != null &&
                    this.IsDirectDeposit.Equals(input.IsDirectDeposit))
                ) && 
                (
                    this.IsExpense == input.IsExpense ||
                    (this.IsExpense != null &&
                    this.IsExpense.Equals(input.IsExpense))
                ) && 
                (
                    this.IsFee == input.IsFee ||
                    (this.IsFee != null &&
                    this.IsFee.Equals(input.IsFee))
                ) && 
                (
                    this.IsIncome == input.IsIncome ||
                    (this.IsIncome != null &&
                    this.IsIncome.Equals(input.IsIncome))
                ) && 
                (
                    this.IsInternational == input.IsInternational ||
                    (this.IsInternational != null &&
                    this.IsInternational.Equals(input.IsInternational))
                ) && 
                (
                    this.IsOverdraftFee == input.IsOverdraftFee ||
                    (this.IsOverdraftFee != null &&
                    this.IsOverdraftFee.Equals(input.IsOverdraftFee))
                ) && 
                (
                    this.IsPayrollAdvance == input.IsPayrollAdvance ||
                    (this.IsPayrollAdvance != null &&
                    this.IsPayrollAdvance.Equals(input.IsPayrollAdvance))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.MemberGuid == input.MemberGuid ||
                    (this.MemberGuid != null &&
                    this.MemberGuid.Equals(input.MemberGuid))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.MerchantCategoryCode == input.MerchantCategoryCode ||
                    (this.MerchantCategoryCode != null &&
                    this.MerchantCategoryCode.Equals(input.MerchantCategoryCode))
                ) && 
                (
                    this.OriginalDescription == input.OriginalDescription ||
                    (this.OriginalDescription != null &&
                    this.OriginalDescription.Equals(input.OriginalDescription))
                ) && 
                (
                    this.PostedAt == input.PostedAt ||
                    (this.PostedAt != null &&
                    this.PostedAt.Equals(input.PostedAt))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TopLevelCategory == input.TopLevelCategory ||
                    (this.TopLevelCategory != null &&
                    this.TopLevelCategory.Equals(input.TopLevelCategory))
                ) && 
                (
                    this.TransactedAt == input.TransactedAt ||
                    (this.TransactedAt != null &&
                    this.TransactedAt.Equals(input.TransactedAt))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.UserGuid == input.UserGuid ||
                    (this.UserGuid != null &&
                    this.UserGuid.Equals(input.UserGuid))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AccountGuid != null)
                    hashCode = hashCode * 59 + this.AccountGuid.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.CheckNumber != null)
                    hashCode = hashCode * 59 + this.CheckNumber.GetHashCode();
                if (this.CheckNumberString != null)
                    hashCode = hashCode * 59 + this.CheckNumberString.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.IsBillPay != null)
                    hashCode = hashCode * 59 + this.IsBillPay.GetHashCode();
                if (this.IsDirectDeposit != null)
                    hashCode = hashCode * 59 + this.IsDirectDeposit.GetHashCode();
                if (this.IsExpense != null)
                    hashCode = hashCode * 59 + this.IsExpense.GetHashCode();
                if (this.IsFee != null)
                    hashCode = hashCode * 59 + this.IsFee.GetHashCode();
                if (this.IsIncome != null)
                    hashCode = hashCode * 59 + this.IsIncome.GetHashCode();
                if (this.IsInternational != null)
                    hashCode = hashCode * 59 + this.IsInternational.GetHashCode();
                if (this.IsOverdraftFee != null)
                    hashCode = hashCode * 59 + this.IsOverdraftFee.GetHashCode();
                if (this.IsPayrollAdvance != null)
                    hashCode = hashCode * 59 + this.IsPayrollAdvance.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.MemberGuid != null)
                    hashCode = hashCode * 59 + this.MemberGuid.GetHashCode();
                if (this.Memo != null)
                    hashCode = hashCode * 59 + this.Memo.GetHashCode();
                if (this.MerchantCategoryCode != null)
                    hashCode = hashCode * 59 + this.MerchantCategoryCode.GetHashCode();
                if (this.OriginalDescription != null)
                    hashCode = hashCode * 59 + this.OriginalDescription.GetHashCode();
                if (this.PostedAt != null)
                    hashCode = hashCode * 59 + this.PostedAt.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TopLevelCategory != null)
                    hashCode = hashCode * 59 + this.TopLevelCategory.GetHashCode();
                if (this.TransactedAt != null)
                    hashCode = hashCode * 59 + this.TransactedAt.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.UserGuid != null)
                    hashCode = hashCode * 59 + this.UserGuid.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
