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
using DateConverter = atrium-csharp.Client.DateConverter;

namespace atrium-csharp.Model
{
    /// <summary>
    /// AccountNumbers
    /// </summary>
    [DataContract]
    public partial class AccountNumbers :  IEquatable<AccountNumbers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountNumbers" /> class.
        /// </summary>
        /// <param name="accountNumbers">accountNumbers.</param>
        public AccountNumbers(List<AccountNumberAttributes> accountNumbers = default(List<AccountNumberAttributes>))
        {
            this._AccountNumbers = accountNumbers;
        }
        
        /// <summary>
        /// Gets or Sets _AccountNumbers
        /// </summary>
        [DataMember(Name="account_numbers", EmitDefaultValue=false)]
        public List<AccountNumberAttributes> _AccountNumbers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountNumbers {\n");
            sb.Append("  _AccountNumbers: ").Append(_AccountNumbers).Append("\n");
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
            return this.Equals(input as AccountNumbers);
        }

        /// <summary>
        /// Returns true if AccountNumbers instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountNumbers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountNumbers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._AccountNumbers == input._AccountNumbers ||
                    this._AccountNumbers != null &&
                    this._AccountNumbers.SequenceEqual(input._AccountNumbers)
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
                if (this._AccountNumbers != null)
                    hashCode = hashCode * 59 + this._AccountNumbers.GetHashCode();
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
