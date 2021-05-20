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
    /// Member
    /// </summary>
    [DataContract]
    public partial class Member :  IEquatable<Member>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Member" /> class.
        /// </summary>
        /// <param name="identifier">identifier.</param>
        /// <param name="institutionCode">institutionCode.</param>
        /// <param name="metadata">metadata.</param>
        public Member(string identifier = default(string), string institutionCode = default(string), string metadata = default(string))
        {
            this.Identifier = identifier;
            this.InstitutionCode = institutionCode;
            this.Metadata = metadata;
        }
        
        /// <summary>
        /// Gets or Sets AggregatedAt
        /// </summary>
        [DataMember(Name="aggregated_at", EmitDefaultValue=false)]
        public string AggregatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets ConnectionStatus
        /// </summary>
        [DataMember(Name="connection_status", EmitDefaultValue=false)]
        public string ConnectionStatus { get; private set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; private set; }

        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or Sets InstitutionCode
        /// </summary>
        [DataMember(Name="institution_code", EmitDefaultValue=false)]
        public string InstitutionCode { get; set; }

        /// <summary>
        /// Gets or Sets IsBeingAggregated
        /// </summary>
        [DataMember(Name="is_being_aggregated", EmitDefaultValue=false)]
        public bool? IsBeingAggregated { get; private set; }

        /// <summary>
        /// Gets or Sets IsOauth
        /// </summary>
        [DataMember(Name="is_oauth", EmitDefaultValue=false)]
        public bool? IsOauth { get; private set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets OauthWindowUri
        /// </summary>
        [DataMember(Name="oauth_window_uri", EmitDefaultValue=false)]
        public string OauthWindowUri { get; private set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }

        /// <summary>
        /// Gets or Sets SuccessfullyAggregatedAt
        /// </summary>
        [DataMember(Name="successfully_aggregated_at", EmitDefaultValue=false)]
        public string SuccessfullyAggregatedAt { get; private set; }

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
            sb.Append("class Member {\n");
            sb.Append("  AggregatedAt: ").Append(AggregatedAt).Append("\n");
            sb.Append("  ConnectionStatus: ").Append(ConnectionStatus).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  InstitutionCode: ").Append(InstitutionCode).Append("\n");
            sb.Append("  IsBeingAggregated: ").Append(IsBeingAggregated).Append("\n");
            sb.Append("  IsOauth: ").Append(IsOauth).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OauthWindowUri: ").Append(OauthWindowUri).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SuccessfullyAggregatedAt: ").Append(SuccessfullyAggregatedAt).Append("\n");
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
            return this.Equals(input as Member);
        }

        /// <summary>
        /// Returns true if Member instances are equal
        /// </summary>
        /// <param name="input">Instance of Member to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Member input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AggregatedAt == input.AggregatedAt ||
                    (this.AggregatedAt != null &&
                    this.AggregatedAt.Equals(input.AggregatedAt))
                ) && 
                (
                    this.ConnectionStatus == input.ConnectionStatus ||
                    (this.ConnectionStatus != null &&
                    this.ConnectionStatus.Equals(input.ConnectionStatus))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.InstitutionCode == input.InstitutionCode ||
                    (this.InstitutionCode != null &&
                    this.InstitutionCode.Equals(input.InstitutionCode))
                ) && 
                (
                    this.IsBeingAggregated == input.IsBeingAggregated ||
                    (this.IsBeingAggregated != null &&
                    this.IsBeingAggregated.Equals(input.IsBeingAggregated))
                ) && 
                (
                    this.IsOauth == input.IsOauth ||
                    (this.IsOauth != null &&
                    this.IsOauth.Equals(input.IsOauth))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OauthWindowUri == input.OauthWindowUri ||
                    (this.OauthWindowUri != null &&
                    this.OauthWindowUri.Equals(input.OauthWindowUri))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SuccessfullyAggregatedAt == input.SuccessfullyAggregatedAt ||
                    (this.SuccessfullyAggregatedAt != null &&
                    this.SuccessfullyAggregatedAt.Equals(input.SuccessfullyAggregatedAt))
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
                if (this.AggregatedAt != null)
                    hashCode = hashCode * 59 + this.AggregatedAt.GetHashCode();
                if (this.ConnectionStatus != null)
                    hashCode = hashCode * 59 + this.ConnectionStatus.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.InstitutionCode != null)
                    hashCode = hashCode * 59 + this.InstitutionCode.GetHashCode();
                if (this.IsBeingAggregated != null)
                    hashCode = hashCode * 59 + this.IsBeingAggregated.GetHashCode();
                if (this.IsOauth != null)
                    hashCode = hashCode * 59 + this.IsOauth.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OauthWindowUri != null)
                    hashCode = hashCode * 59 + this.OauthWindowUri.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SuccessfullyAggregatedAt != null)
                    hashCode = hashCode * 59 + this.SuccessfullyAggregatedAt.GetHashCode();
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
