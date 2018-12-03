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
    /// Challenges
    /// </summary>
    [DataContract]
    public partial class Challenges :  IEquatable<Challenges>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Challenges" /> class.
        /// </summary>
        /// <param name="challenges">challenges.</param>
        public Challenges(List<ChallengeAttributes> challenges = default(List<ChallengeAttributes>))
        {
            this._Challenges = challenges;
        }
        
        /// <summary>
        /// Gets or Sets _Challenges
        /// </summary>
        [DataMember(Name="challenges", EmitDefaultValue=false)]
        public List<ChallengeAttributes> _Challenges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Challenges {\n");
            sb.Append("  _Challenges: ").Append(_Challenges).Append("\n");
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
            return this.Equals(input as Challenges);
        }

        /// <summary>
        /// Returns true if Challenges instances are equal
        /// </summary>
        /// <param name="input">Instance of Challenges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Challenges input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Challenges == input._Challenges ||
                    this._Challenges != null &&
                    this._Challenges.SequenceEqual(input._Challenges)
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
                if (this._Challenges != null)
                    hashCode = hashCode * 59 + this._Challenges.GetHashCode();
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
