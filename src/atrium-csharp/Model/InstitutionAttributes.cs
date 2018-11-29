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
    /// InstitutionAttributes
    /// </summary>
    [DataContract]
    public partial class InstitutionAttributes :  IEquatable<InstitutionAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstitutionAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public InstitutionAttributes()
        {
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; private set; }

        /// <summary>
        /// Gets or Sets MediumLogoUrl
        /// </summary>
        [DataMember(Name="medium_logo_url", EmitDefaultValue=false)]
        public string MediumLogoUrl { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets SmallLogoUrl
        /// </summary>
        [DataMember(Name="small_logo_url", EmitDefaultValue=false)]
        public string SmallLogoUrl { get; private set; }

        /// <summary>
        /// Gets or Sets SupportsAccountIdentification
        /// </summary>
        [DataMember(Name="supports_account_identification", EmitDefaultValue=false)]
        public bool? SupportsAccountIdentification { get; private set; }

        /// <summary>
        /// Gets or Sets SupportsAccountVerification
        /// </summary>
        [DataMember(Name="supports_account_verification", EmitDefaultValue=false)]
        public bool? SupportsAccountVerification { get; private set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstitutionAttributes {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  MediumLogoUrl: ").Append(MediumLogoUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SmallLogoUrl: ").Append(SmallLogoUrl).Append("\n");
            sb.Append("  SupportsAccountIdentification: ").Append(SupportsAccountIdentification).Append("\n");
            sb.Append("  SupportsAccountVerification: ").Append(SupportsAccountVerification).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as InstitutionAttributes);
        }

        /// <summary>
        /// Returns true if InstitutionAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of InstitutionAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstitutionAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.MediumLogoUrl == input.MediumLogoUrl ||
                    (this.MediumLogoUrl != null &&
                    this.MediumLogoUrl.Equals(input.MediumLogoUrl))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SmallLogoUrl == input.SmallLogoUrl ||
                    (this.SmallLogoUrl != null &&
                    this.SmallLogoUrl.Equals(input.SmallLogoUrl))
                ) && 
                (
                    this.SupportsAccountIdentification == input.SupportsAccountIdentification ||
                    (this.SupportsAccountIdentification != null &&
                    this.SupportsAccountIdentification.Equals(input.SupportsAccountIdentification))
                ) && 
                (
                    this.SupportsAccountVerification == input.SupportsAccountVerification ||
                    (this.SupportsAccountVerification != null &&
                    this.SupportsAccountVerification.Equals(input.SupportsAccountVerification))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.MediumLogoUrl != null)
                    hashCode = hashCode * 59 + this.MediumLogoUrl.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SmallLogoUrl != null)
                    hashCode = hashCode * 59 + this.SmallLogoUrl.GetHashCode();
                if (this.SupportsAccountIdentification != null)
                    hashCode = hashCode * 59 + this.SupportsAccountIdentification.GetHashCode();
                if (this.SupportsAccountVerification != null)
                    hashCode = hashCode * 59 + this.SupportsAccountVerification.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
