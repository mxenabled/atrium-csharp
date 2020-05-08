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
    /// MemberCreateRequest
    /// </summary>
    [DataContract]
    public partial class MemberCreateRequest :  IEquatable<MemberCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MemberCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberCreateRequest" /> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="isOauth">isOauth.</param>
        /// <param name="institutionCode">institutionCode (required).</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="referralSource">referralSource.</param>
        /// <param name="skipAggregation">skipAggregation.</param>
        /// <param name="uiMessageWebviewUrlScheme">uiMessageWebviewUrlScheme.</param>
        public MemberCreateRequest(List<CredentialRequest> credentials = default(List<CredentialRequest>), string identifier = default(string), bool? isOauth = default(bool?), string institutionCode = default(string), string metadata = default(string), string referralSource = default(string), bool? skipAggregation = default(bool?), string uiMessageWebviewUrlScheme = default(string))
        {
            // to ensure "institutionCode" is required (not null)
            if (institutionCode == null)
            {
                throw new InvalidDataException("institutionCode is a required property for MemberCreateRequest and cannot be null");
            }
            else
            {
                this.InstitutionCode = institutionCode;
            }
            this.Credentials = credentials;
            this.Identifier = identifier;
            this.IsOauth = isOauth;
            this.Metadata = metadata;
            this.ReferralSource = referralSource;
            this.SkipAggregation = skipAggregation;
            this.UiMessageWebviewUrlScheme = uiMessageWebviewUrlScheme;
        }
        
        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public List<CredentialRequest> Credentials { get; set; }

        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or Sets IsOauth
        /// </summary>
        [DataMember(Name="is_oauth", EmitDefaultValue=false)]
        public bool? IsOauth { get; set; }

        /// <summary>
        /// Gets or Sets InstitutionCode
        /// </summary>
        [DataMember(Name="institution_code", EmitDefaultValue=false)]
        public string InstitutionCode { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// Gets or Sets ReferralSource
        /// </summary>
        [DataMember(Name="referral_source", EmitDefaultValue=false)]
        public string ReferralSource { get; set; }

        /// <summary>
        /// Gets or Sets SkipAggregation
        /// </summary>
        [DataMember(Name="skip_aggregation", EmitDefaultValue=false)]
        public bool? SkipAggregation { get; set; }

        /// <summary>
        /// Gets or Sets UiMessageWebviewUrlScheme
        /// </summary>
        [DataMember(Name="ui_message_webview_url_scheme", EmitDefaultValue=false)]
        public string UiMessageWebviewUrlScheme { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberCreateRequest {\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  IsOauth: ").Append(IsOauth).Append("\n");
            sb.Append("  InstitutionCode: ").Append(InstitutionCode).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  ReferralSource: ").Append(ReferralSource).Append("\n");
            sb.Append("  SkipAggregation: ").Append(SkipAggregation).Append("\n");
            sb.Append("  UiMessageWebviewUrlScheme: ").Append(UiMessageWebviewUrlScheme).Append("\n");
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
            return this.Equals(input as MemberCreateRequest);
        }

        /// <summary>
        /// Returns true if MemberCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MemberCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemberCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Credentials == input.Credentials ||
                    this.Credentials != null &&
                    this.Credentials.SequenceEqual(input.Credentials)
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.IsOauth == input.IsOauth ||
                    (this.IsOauth != null &&
                    this.IsOauth.Equals(input.IsOauth))
                ) && 
                (
                    this.InstitutionCode == input.InstitutionCode ||
                    (this.InstitutionCode != null &&
                    this.InstitutionCode.Equals(input.InstitutionCode))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.ReferralSource == input.ReferralSource ||
                    (this.ReferralSource != null &&
                    this.ReferralSource.Equals(input.ReferralSource))
                ) && 
                (
                    this.SkipAggregation == input.SkipAggregation ||
                    (this.SkipAggregation != null &&
                    this.SkipAggregation.Equals(input.SkipAggregation))
                ) && 
                (
                    this.UiMessageWebviewUrlScheme == input.UiMessageWebviewUrlScheme ||
                    (this.UiMessageWebviewUrlScheme != null &&
                    this.UiMessageWebviewUrlScheme.Equals(input.UiMessageWebviewUrlScheme))
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
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.IsOauth != null)
                    hashCode = hashCode * 59 + this.IsOauth.GetHashCode();
                if (this.InstitutionCode != null)
                    hashCode = hashCode * 59 + this.InstitutionCode.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.ReferralSource != null)
                    hashCode = hashCode * 59 + this.ReferralSource.GetHashCode();
                if (this.SkipAggregation != null)
                    hashCode = hashCode * 59 + this.SkipAggregation.GetHashCode();
                if (this.UiMessageWebviewUrlScheme != null)
                    hashCode = hashCode * 59 + this.UiMessageWebviewUrlScheme.GetHashCode();
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
