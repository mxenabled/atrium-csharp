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
    /// Holding
    /// </summary>
    [DataContract]
    public partial class Holding :  IEquatable<Holding>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Holding" /> class.
        /// </summary>
        /// <param name="guid">guid.</param>
        public Holding(string guid = default(string))
        {
            this.Guid = guid;
        }
        
        /// <summary>
        /// Gets or Sets AccountGuid
        /// </summary>
        [DataMember(Name="account_guid", EmitDefaultValue=false)]
        public string AccountGuid { get; private set; }

        /// <summary>
        /// Gets or Sets CostBasis
        /// </summary>
        [DataMember(Name="cost_basis", EmitDefaultValue=false)]
        public decimal? CostBasis { get; private set; }

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
        /// Gets or Sets Cusip
        /// </summary>
        [DataMember(Name="cusip", EmitDefaultValue=false)]
        public string Cusip { get; private set; }

        /// <summary>
        /// Gets or Sets DailyChange
        /// </summary>
        [DataMember(Name="daily_change", EmitDefaultValue=false)]
        public decimal? DailyChange { get; private set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets HoldingType
        /// </summary>
        [DataMember(Name="holding_type", EmitDefaultValue=false)]
        public string HoldingType { get; private set; }

        /// <summary>
        /// Gets or Sets MarketValue
        /// </summary>
        [DataMember(Name="market_value", EmitDefaultValue=false)]
        public decimal? MarketValue { get; private set; }

        /// <summary>
        /// Gets or Sets MemberGuid
        /// </summary>
        [DataMember(Name="member_guid", EmitDefaultValue=false)]
        public string MemberGuid { get; private set; }

        /// <summary>
        /// Gets or Sets PurchasePrice
        /// </summary>
        [DataMember(Name="purchase_price", EmitDefaultValue=false)]
        public decimal? PurchasePrice { get; private set; }

        /// <summary>
        /// Gets or Sets Shares
        /// </summary>
        [DataMember(Name="shares", EmitDefaultValue=false)]
        public decimal? Shares { get; private set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; private set; }

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
            sb.Append("class Holding {\n");
            sb.Append("  AccountGuid: ").Append(AccountGuid).Append("\n");
            sb.Append("  CostBasis: ").Append(CostBasis).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Cusip: ").Append(Cusip).Append("\n");
            sb.Append("  DailyChange: ").Append(DailyChange).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  HoldingType: ").Append(HoldingType).Append("\n");
            sb.Append("  MarketValue: ").Append(MarketValue).Append("\n");
            sb.Append("  MemberGuid: ").Append(MemberGuid).Append("\n");
            sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
            sb.Append("  Shares: ").Append(Shares).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
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
            return this.Equals(input as Holding);
        }

        /// <summary>
        /// Returns true if Holding instances are equal
        /// </summary>
        /// <param name="input">Instance of Holding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Holding input)
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
                    this.CostBasis == input.CostBasis ||
                    (this.CostBasis != null &&
                    this.CostBasis.Equals(input.CostBasis))
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
                    this.Cusip == input.Cusip ||
                    (this.Cusip != null &&
                    this.Cusip.Equals(input.Cusip))
                ) && 
                (
                    this.DailyChange == input.DailyChange ||
                    (this.DailyChange != null &&
                    this.DailyChange.Equals(input.DailyChange))
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
                    this.HoldingType == input.HoldingType ||
                    (this.HoldingType != null &&
                    this.HoldingType.Equals(input.HoldingType))
                ) && 
                (
                    this.MarketValue == input.MarketValue ||
                    (this.MarketValue != null &&
                    this.MarketValue.Equals(input.MarketValue))
                ) && 
                (
                    this.MemberGuid == input.MemberGuid ||
                    (this.MemberGuid != null &&
                    this.MemberGuid.Equals(input.MemberGuid))
                ) && 
                (
                    this.PurchasePrice == input.PurchasePrice ||
                    (this.PurchasePrice != null &&
                    this.PurchasePrice.Equals(input.PurchasePrice))
                ) && 
                (
                    this.Shares == input.Shares ||
                    (this.Shares != null &&
                    this.Shares.Equals(input.Shares))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
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
                if (this.CostBasis != null)
                    hashCode = hashCode * 59 + this.CostBasis.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.Cusip != null)
                    hashCode = hashCode * 59 + this.Cusip.GetHashCode();
                if (this.DailyChange != null)
                    hashCode = hashCode * 59 + this.DailyChange.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.HoldingType != null)
                    hashCode = hashCode * 59 + this.HoldingType.GetHashCode();
                if (this.MarketValue != null)
                    hashCode = hashCode * 59 + this.MarketValue.GetHashCode();
                if (this.MemberGuid != null)
                    hashCode = hashCode * 59 + this.MemberGuid.GetHashCode();
                if (this.PurchasePrice != null)
                    hashCode = hashCode * 59 + this.PurchasePrice.GetHashCode();
                if (this.Shares != null)
                    hashCode = hashCode * 59 + this.Shares.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
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
