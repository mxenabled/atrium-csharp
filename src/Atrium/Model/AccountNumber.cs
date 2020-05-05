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
    /// AccountNumber
    /// </summary>
    [DataContract]
    public partial class AccountNumber :  IEquatable<AccountNumber>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountNumber" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public AccountNumber()
        {
        }
        
        /// <summary>
        /// Gets or Sets AccountGuid
        /// </summary>
        [DataMember(Name="account_guid", EmitDefaultValue=false)]
        public string AccountGuid { get; private set; }

        /// <summary>
        /// Gets or Sets _AccountNumber
        /// </summary>
        [DataMember(Name="account_number", EmitDefaultValue=false)]
        public string _AccountNumber { get; private set; }

        /// <summary>
        /// Gets or Sets InstitutionNumber
        /// </summary>
        [DataMember(Name="institution_number", EmitDefaultValue=false)]
        public string InstitutionNumber { get; private set; }

        /// <summary>
        /// Gets or Sets MemberGuid
        /// </summary>
        [DataMember(Name="member_guid", EmitDefaultValue=false)]
        public string MemberGuid { get; private set; }

        /// <summary>
        /// Gets or Sets RoutingNumber
        /// </summary>
        [DataMember(Name="routing_number", EmitDefaultValue=false)]
        public string RoutingNumber { get; private set; }

        /// <summary>
        /// Gets or Sets TransitNumber
        /// </summary>
        [DataMember(Name="transit_number", EmitDefaultValue=false)]
        public string TransitNumber { get; private set; }

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
            sb.Append("class AccountNumber {\n");
            sb.Append("  AccountGuid: ").Append(AccountGuid).Append("\n");
            sb.Append("  _AccountNumber: ").Append(_AccountNumber).Append("\n");
            sb.Append("  InstitutionNumber: ").Append(InstitutionNumber).Append("\n");
            sb.Append("  MemberGuid: ").Append(MemberGuid).Append("\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
            sb.Append("  TransitNumber: ").Append(TransitNumber).Append("\n");
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
            return this.Equals(input as AccountNumber);
        }

        /// <summary>
        /// Returns true if AccountNumber instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountNumber input)
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
                    this._AccountNumber == input._AccountNumber ||
                    (this._AccountNumber != null &&
                    this._AccountNumber.Equals(input._AccountNumber))
                ) && 
                (
                    this.InstitutionNumber == input.InstitutionNumber ||
                    (this.InstitutionNumber != null &&
                    this.InstitutionNumber.Equals(input.InstitutionNumber))
                ) && 
                (
                    this.MemberGuid == input.MemberGuid ||
                    (this.MemberGuid != null &&
                    this.MemberGuid.Equals(input.MemberGuid))
                ) && 
                (
                    this.RoutingNumber == input.RoutingNumber ||
                    (this.RoutingNumber != null &&
                    this.RoutingNumber.Equals(input.RoutingNumber))
                ) && 
                (
                    this.TransitNumber == input.TransitNumber ||
                    (this.TransitNumber != null &&
                    this.TransitNumber.Equals(input.TransitNumber))
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
                if (this._AccountNumber != null)
                    hashCode = hashCode * 59 + this._AccountNumber.GetHashCode();
                if (this.InstitutionNumber != null)
                    hashCode = hashCode * 59 + this.InstitutionNumber.GetHashCode();
                if (this.MemberGuid != null)
                    hashCode = hashCode * 59 + this.MemberGuid.GetHashCode();
                if (this.RoutingNumber != null)
                    hashCode = hashCode * 59 + this.RoutingNumber.GetHashCode();
                if (this.TransitNumber != null)
                    hashCode = hashCode * 59 + this.TransitNumber.GetHashCode();
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
