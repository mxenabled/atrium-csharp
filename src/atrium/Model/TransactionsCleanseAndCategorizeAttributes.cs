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
    /// TransactionsCleanseAndCategorizeAttributes
    /// </summary>
    [DataContract]
    public partial class TransactionsCleanseAndCategorizeAttributes :  IEquatable<TransactionsCleanseAndCategorizeAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsCleanseAndCategorizeAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TransactionsCleanseAndCategorizeAttributes()
        {
        }
        
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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }

        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public string Identifier { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionsCleanseAndCategorizeAttributes {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsBillPay: ").Append(IsBillPay).Append("\n");
            sb.Append("  IsDirectDeposit: ").Append(IsDirectDeposit).Append("\n");
            sb.Append("  IsExpense: ").Append(IsExpense).Append("\n");
            sb.Append("  IsFee: ").Append(IsFee).Append("\n");
            sb.Append("  IsIncome: ").Append(IsIncome).Append("\n");
            sb.Append("  IsInternational: ").Append(IsInternational).Append("\n");
            sb.Append("  IsOverdraftFee: ").Append(IsOverdraftFee).Append("\n");
            sb.Append("  IsPayrollAdvance: ").Append(IsPayrollAdvance).Append("\n");
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
            return this.Equals(input as TransactionsCleanseAndCategorizeAttributes);
        }

        /// <summary>
        /// Returns true if TransactionsCleanseAndCategorizeAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionsCleanseAndCategorizeAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionsCleanseAndCategorizeAttributes input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
