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
using DateConverter = Atrium.Client.DateConverter;

namespace Atrium.Model
{
    /// <summary>
    /// Account
    /// </summary>
    [DataContract]
    public partial class Account :  IEquatable<Account>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="cashBalance">cashBalance.</param>
        /// <param name="cashSurrenderValue">cashSurrenderValue.</param>
        /// <param name="deathBenefit">deathBenefit.</param>
        /// <param name="holdingsValue">holdingsValue.</param>
        /// <param name="loanAmount">loanAmount.</param>
        public Account(decimal? cashBalance = default(decimal?), decimal? cashSurrenderValue = default(decimal?), decimal? deathBenefit = default(decimal?), decimal? holdingsValue = default(decimal?), decimal? loanAmount = default(decimal?))
        {
            this.CashBalance = cashBalance;
            this.CashSurrenderValue = cashSurrenderValue;
            this.DeathBenefit = deathBenefit;
            this.HoldingsValue = holdingsValue;
            this.LoanAmount = loanAmount;
        }
        
        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="account_number", EmitDefaultValue=false)]
        public string AccountNumber { get; private set; }

        /// <summary>
        /// Gets or Sets Apr
        /// </summary>
        [DataMember(Name="apr", EmitDefaultValue=false)]
        public decimal? Apr { get; private set; }

        /// <summary>
        /// Gets or Sets Apy
        /// </summary>
        [DataMember(Name="apy", EmitDefaultValue=false)]
        public decimal? Apy { get; private set; }

        /// <summary>
        /// Gets or Sets AvailableBalance
        /// </summary>
        [DataMember(Name="available_balance", EmitDefaultValue=false)]
        public decimal? AvailableBalance { get; private set; }

        /// <summary>
        /// Gets or Sets AvailableCredit
        /// </summary>
        [DataMember(Name="available_credit", EmitDefaultValue=false)]
        public decimal? AvailableCredit { get; private set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public decimal? Balance { get; private set; }

        /// <summary>
        /// Gets or Sets CashBalance
        /// </summary>
        [DataMember(Name="cash_balance", EmitDefaultValue=false)]
        public decimal? CashBalance { get; set; }

        /// <summary>
        /// Gets or Sets CashSurrenderValue
        /// </summary>
        [DataMember(Name="cash_surrender_value", EmitDefaultValue=false)]
        public decimal? CashSurrenderValue { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets CreditLimit
        /// </summary>
        [DataMember(Name="credit_limit", EmitDefaultValue=false)]
        public decimal? CreditLimit { get; private set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; private set; }

        /// <summary>
        /// Gets or Sets DayPaymentIsDue
        /// </summary>
        [DataMember(Name="day_payment_is_due", EmitDefaultValue=false)]
        public int? DayPaymentIsDue { get; private set; }

        /// <summary>
        /// Gets or Sets DeathBenefit
        /// </summary>
        [DataMember(Name="death_benefit", EmitDefaultValue=false)]
        public decimal? DeathBenefit { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; private set; }

        /// <summary>
        /// Gets or Sets HoldingsValue
        /// </summary>
        [DataMember(Name="holdings_value", EmitDefaultValue=false)]
        public decimal? HoldingsValue { get; set; }

        /// <summary>
        /// Gets or Sets InstitutionCode
        /// </summary>
        [DataMember(Name="institution_code", EmitDefaultValue=false)]
        public string InstitutionCode { get; private set; }

        /// <summary>
        /// Gets or Sets InterestRate
        /// </summary>
        [DataMember(Name="interest_rate", EmitDefaultValue=false)]
        public decimal? InterestRate { get; private set; }

        /// <summary>
        /// Gets or Sets IsClosed
        /// </summary>
        [DataMember(Name="is_closed", EmitDefaultValue=false)]
        public bool? IsClosed { get; private set; }

        /// <summary>
        /// Gets or Sets LastPayment
        /// </summary>
        [DataMember(Name="last_payment", EmitDefaultValue=false)]
        public decimal? LastPayment { get; private set; }

        /// <summary>
        /// Gets or Sets LoanAmount
        /// </summary>
        [DataMember(Name="loan_amount", EmitDefaultValue=false)]
        public decimal? LoanAmount { get; set; }

        /// <summary>
        /// Gets or Sets MaturesOn
        /// </summary>
        [DataMember(Name="matures_on", EmitDefaultValue=false)]
        public string MaturesOn { get; private set; }

        /// <summary>
        /// Gets or Sets MemberGuid
        /// </summary>
        [DataMember(Name="member_guid", EmitDefaultValue=false)]
        public string MemberGuid { get; private set; }

        /// <summary>
        /// Gets or Sets MinimumBalance
        /// </summary>
        [DataMember(Name="minimum_balance", EmitDefaultValue=false)]
        public decimal? MinimumBalance { get; private set; }

        /// <summary>
        /// Gets or Sets MinimumPayment
        /// </summary>
        [DataMember(Name="minimum_payment", EmitDefaultValue=false)]
        public decimal? MinimumPayment { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets OriginalBalance
        /// </summary>
        [DataMember(Name="original_balance", EmitDefaultValue=false)]
        public decimal? OriginalBalance { get; private set; }

        /// <summary>
        /// Gets or Sets PaymentDueAt
        /// </summary>
        [DataMember(Name="payment_due_at", EmitDefaultValue=false)]
        public string PaymentDueAt { get; private set; }

        /// <summary>
        /// Gets or Sets PayoffBalance
        /// </summary>
        [DataMember(Name="payoff_balance", EmitDefaultValue=false)]
        public decimal? PayoffBalance { get; private set; }

        /// <summary>
        /// Gets or Sets StartedOn
        /// </summary>
        [DataMember(Name="started_on", EmitDefaultValue=false)]
        public string StartedOn { get; private set; }

        /// <summary>
        /// Gets or Sets Subtype
        /// </summary>
        [DataMember(Name="subtype", EmitDefaultValue=false)]
        public string Subtype { get; private set; }

        /// <summary>
        /// Gets or Sets TotalAccountValue
        /// </summary>
        [DataMember(Name="total_account_value", EmitDefaultValue=false)]
        public decimal? TotalAccountValue { get; private set; }

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
            sb.Append("class Account {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Apr: ").Append(Apr).Append("\n");
            sb.Append("  Apy: ").Append(Apy).Append("\n");
            sb.Append("  AvailableBalance: ").Append(AvailableBalance).Append("\n");
            sb.Append("  AvailableCredit: ").Append(AvailableCredit).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  CashBalance: ").Append(CashBalance).Append("\n");
            sb.Append("  CashSurrenderValue: ").Append(CashSurrenderValue).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreditLimit: ").Append(CreditLimit).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  DayPaymentIsDue: ").Append(DayPaymentIsDue).Append("\n");
            sb.Append("  DeathBenefit: ").Append(DeathBenefit).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  HoldingsValue: ").Append(HoldingsValue).Append("\n");
            sb.Append("  InstitutionCode: ").Append(InstitutionCode).Append("\n");
            sb.Append("  InterestRate: ").Append(InterestRate).Append("\n");
            sb.Append("  IsClosed: ").Append(IsClosed).Append("\n");
            sb.Append("  LastPayment: ").Append(LastPayment).Append("\n");
            sb.Append("  LoanAmount: ").Append(LoanAmount).Append("\n");
            sb.Append("  MaturesOn: ").Append(MaturesOn).Append("\n");
            sb.Append("  MemberGuid: ").Append(MemberGuid).Append("\n");
            sb.Append("  MinimumBalance: ").Append(MinimumBalance).Append("\n");
            sb.Append("  MinimumPayment: ").Append(MinimumPayment).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OriginalBalance: ").Append(OriginalBalance).Append("\n");
            sb.Append("  PaymentDueAt: ").Append(PaymentDueAt).Append("\n");
            sb.Append("  PayoffBalance: ").Append(PayoffBalance).Append("\n");
            sb.Append("  StartedOn: ").Append(StartedOn).Append("\n");
            sb.Append("  Subtype: ").Append(Subtype).Append("\n");
            sb.Append("  TotalAccountValue: ").Append(TotalAccountValue).Append("\n");
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
            return this.Equals(input as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="input">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.Apr == input.Apr ||
                    (this.Apr != null &&
                    this.Apr.Equals(input.Apr))
                ) && 
                (
                    this.Apy == input.Apy ||
                    (this.Apy != null &&
                    this.Apy.Equals(input.Apy))
                ) && 
                (
                    this.AvailableBalance == input.AvailableBalance ||
                    (this.AvailableBalance != null &&
                    this.AvailableBalance.Equals(input.AvailableBalance))
                ) && 
                (
                    this.AvailableCredit == input.AvailableCredit ||
                    (this.AvailableCredit != null &&
                    this.AvailableCredit.Equals(input.AvailableCredit))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.CashBalance == input.CashBalance ||
                    (this.CashBalance != null &&
                    this.CashBalance.Equals(input.CashBalance))
                ) && 
                (
                    this.CashSurrenderValue == input.CashSurrenderValue ||
                    (this.CashSurrenderValue != null &&
                    this.CashSurrenderValue.Equals(input.CashSurrenderValue))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CreditLimit == input.CreditLimit ||
                    (this.CreditLimit != null &&
                    this.CreditLimit.Equals(input.CreditLimit))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.DayPaymentIsDue == input.DayPaymentIsDue ||
                    (this.DayPaymentIsDue != null &&
                    this.DayPaymentIsDue.Equals(input.DayPaymentIsDue))
                ) && 
                (
                    this.DeathBenefit == input.DeathBenefit ||
                    (this.DeathBenefit != null &&
                    this.DeathBenefit.Equals(input.DeathBenefit))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.HoldingsValue == input.HoldingsValue ||
                    (this.HoldingsValue != null &&
                    this.HoldingsValue.Equals(input.HoldingsValue))
                ) && 
                (
                    this.InstitutionCode == input.InstitutionCode ||
                    (this.InstitutionCode != null &&
                    this.InstitutionCode.Equals(input.InstitutionCode))
                ) && 
                (
                    this.InterestRate == input.InterestRate ||
                    (this.InterestRate != null &&
                    this.InterestRate.Equals(input.InterestRate))
                ) && 
                (
                    this.IsClosed == input.IsClosed ||
                    (this.IsClosed != null &&
                    this.IsClosed.Equals(input.IsClosed))
                ) && 
                (
                    this.LastPayment == input.LastPayment ||
                    (this.LastPayment != null &&
                    this.LastPayment.Equals(input.LastPayment))
                ) && 
                (
                    this.LoanAmount == input.LoanAmount ||
                    (this.LoanAmount != null &&
                    this.LoanAmount.Equals(input.LoanAmount))
                ) && 
                (
                    this.MaturesOn == input.MaturesOn ||
                    (this.MaturesOn != null &&
                    this.MaturesOn.Equals(input.MaturesOn))
                ) && 
                (
                    this.MemberGuid == input.MemberGuid ||
                    (this.MemberGuid != null &&
                    this.MemberGuid.Equals(input.MemberGuid))
                ) && 
                (
                    this.MinimumBalance == input.MinimumBalance ||
                    (this.MinimumBalance != null &&
                    this.MinimumBalance.Equals(input.MinimumBalance))
                ) && 
                (
                    this.MinimumPayment == input.MinimumPayment ||
                    (this.MinimumPayment != null &&
                    this.MinimumPayment.Equals(input.MinimumPayment))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OriginalBalance == input.OriginalBalance ||
                    (this.OriginalBalance != null &&
                    this.OriginalBalance.Equals(input.OriginalBalance))
                ) && 
                (
                    this.PaymentDueAt == input.PaymentDueAt ||
                    (this.PaymentDueAt != null &&
                    this.PaymentDueAt.Equals(input.PaymentDueAt))
                ) && 
                (
                    this.PayoffBalance == input.PayoffBalance ||
                    (this.PayoffBalance != null &&
                    this.PayoffBalance.Equals(input.PayoffBalance))
                ) && 
                (
                    this.StartedOn == input.StartedOn ||
                    (this.StartedOn != null &&
                    this.StartedOn.Equals(input.StartedOn))
                ) && 
                (
                    this.Subtype == input.Subtype ||
                    (this.Subtype != null &&
                    this.Subtype.Equals(input.Subtype))
                ) && 
                (
                    this.TotalAccountValue == input.TotalAccountValue ||
                    (this.TotalAccountValue != null &&
                    this.TotalAccountValue.Equals(input.TotalAccountValue))
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
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.Apr != null)
                    hashCode = hashCode * 59 + this.Apr.GetHashCode();
                if (this.Apy != null)
                    hashCode = hashCode * 59 + this.Apy.GetHashCode();
                if (this.AvailableBalance != null)
                    hashCode = hashCode * 59 + this.AvailableBalance.GetHashCode();
                if (this.AvailableCredit != null)
                    hashCode = hashCode * 59 + this.AvailableCredit.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.CashBalance != null)
                    hashCode = hashCode * 59 + this.CashBalance.GetHashCode();
                if (this.CashSurrenderValue != null)
                    hashCode = hashCode * 59 + this.CashSurrenderValue.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreditLimit != null)
                    hashCode = hashCode * 59 + this.CreditLimit.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.DayPaymentIsDue != null)
                    hashCode = hashCode * 59 + this.DayPaymentIsDue.GetHashCode();
                if (this.DeathBenefit != null)
                    hashCode = hashCode * 59 + this.DeathBenefit.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.HoldingsValue != null)
                    hashCode = hashCode * 59 + this.HoldingsValue.GetHashCode();
                if (this.InstitutionCode != null)
                    hashCode = hashCode * 59 + this.InstitutionCode.GetHashCode();
                if (this.InterestRate != null)
                    hashCode = hashCode * 59 + this.InterestRate.GetHashCode();
                if (this.IsClosed != null)
                    hashCode = hashCode * 59 + this.IsClosed.GetHashCode();
                if (this.LastPayment != null)
                    hashCode = hashCode * 59 + this.LastPayment.GetHashCode();
                if (this.LoanAmount != null)
                    hashCode = hashCode * 59 + this.LoanAmount.GetHashCode();
                if (this.MaturesOn != null)
                    hashCode = hashCode * 59 + this.MaturesOn.GetHashCode();
                if (this.MemberGuid != null)
                    hashCode = hashCode * 59 + this.MemberGuid.GetHashCode();
                if (this.MinimumBalance != null)
                    hashCode = hashCode * 59 + this.MinimumBalance.GetHashCode();
                if (this.MinimumPayment != null)
                    hashCode = hashCode * 59 + this.MinimumPayment.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OriginalBalance != null)
                    hashCode = hashCode * 59 + this.OriginalBalance.GetHashCode();
                if (this.PaymentDueAt != null)
                    hashCode = hashCode * 59 + this.PaymentDueAt.GetHashCode();
                if (this.PayoffBalance != null)
                    hashCode = hashCode * 59 + this.PayoffBalance.GetHashCode();
                if (this.StartedOn != null)
                    hashCode = hashCode * 59 + this.StartedOn.GetHashCode();
                if (this.Subtype != null)
                    hashCode = hashCode * 59 + this.Subtype.GetHashCode();
                if (this.TotalAccountValue != null)
                    hashCode = hashCode * 59 + this.TotalAccountValue.GetHashCode();
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
