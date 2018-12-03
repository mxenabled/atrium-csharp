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
    /// MemberResumeRequestBodyAttributes
    /// </summary>
    [DataContract]
    public partial class MemberResumeRequestBodyAttributes :  IEquatable<MemberResumeRequestBodyAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberResumeRequestBodyAttributes" /> class.
        /// </summary>
        /// <param name="challenges">challenges.</param>
        public MemberResumeRequestBodyAttributes(List<CredentialResponseAttributes> challenges = default(List<CredentialResponseAttributes>))
        {
            this.Challenges = challenges;
        }
        
        /// <summary>
        /// Gets or Sets Challenges
        /// </summary>
        [DataMember(Name="challenges", EmitDefaultValue=false)]
        public List<CredentialResponseAttributes> Challenges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberResumeRequestBodyAttributes {\n");
            sb.Append("  Challenges: ").Append(Challenges).Append("\n");
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
            return this.Equals(input as MemberResumeRequestBodyAttributes);
        }

        /// <summary>
        /// Returns true if MemberResumeRequestBodyAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of MemberResumeRequestBodyAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemberResumeRequestBodyAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Challenges == input.Challenges ||
                    this.Challenges != null &&
                    this.Challenges.SequenceEqual(input.Challenges)
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
                if (this.Challenges != null)
                    hashCode = hashCode * 59 + this.Challenges.GetHashCode();
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
