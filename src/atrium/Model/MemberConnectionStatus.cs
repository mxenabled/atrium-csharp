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
    /// MemberConnectionStatus
    /// </summary>
    [DataContract]
    public partial class MemberConnectionStatus :  IEquatable<MemberConnectionStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberConnectionStatus" /> class.
        /// </summary>
        /// <param name="challenges">challenges.</param>
        public MemberConnectionStatus(List<Challenge> challenges = default(List<Challenge>))
        {
            this.Challenges = challenges;
        }
        
        /// <summary>
        /// Gets or Sets AggregatedAt
        /// </summary>
        [DataMember(Name="aggregated_at", EmitDefaultValue=false)]
        public string AggregatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets Challenges
        /// </summary>
        [DataMember(Name="challenges", EmitDefaultValue=false)]
        public List<Challenge> Challenges { get; set; }

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
        /// Gets or Sets HasProcessedAccounts
        /// </summary>
        [DataMember(Name="has_processed_accounts", EmitDefaultValue=false)]
        public bool? HasProcessedAccounts { get; private set; }

        /// <summary>
        /// Gets or Sets HasProcessedTransactions
        /// </summary>
        [DataMember(Name="has_processed_transactions", EmitDefaultValue=false)]
        public bool? HasProcessedTransactions { get; private set; }

        /// <summary>
        /// Gets or Sets IsBeingAggregated
        /// </summary>
        [DataMember(Name="is_being_aggregated", EmitDefaultValue=false)]
        public bool? IsBeingAggregated { get; private set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberConnectionStatus {\n");
            sb.Append("  AggregatedAt: ").Append(AggregatedAt).Append("\n");
            sb.Append("  Challenges: ").Append(Challenges).Append("\n");
            sb.Append("  ConnectionStatus: ").Append(ConnectionStatus).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  HasProcessedAccounts: ").Append(HasProcessedAccounts).Append("\n");
            sb.Append("  HasProcessedTransactions: ").Append(HasProcessedTransactions).Append("\n");
            sb.Append("  IsBeingAggregated: ").Append(IsBeingAggregated).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SuccessfullyAggregatedAt: ").Append(SuccessfullyAggregatedAt).Append("\n");
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
            return this.Equals(input as MemberConnectionStatus);
        }

        /// <summary>
        /// Returns true if MemberConnectionStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of MemberConnectionStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemberConnectionStatus input)
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
                    this.Challenges == input.Challenges ||
                    this.Challenges != null &&
                    this.Challenges.SequenceEqual(input.Challenges)
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
                    this.HasProcessedAccounts == input.HasProcessedAccounts ||
                    (this.HasProcessedAccounts != null &&
                    this.HasProcessedAccounts.Equals(input.HasProcessedAccounts))
                ) && 
                (
                    this.HasProcessedTransactions == input.HasProcessedTransactions ||
                    (this.HasProcessedTransactions != null &&
                    this.HasProcessedTransactions.Equals(input.HasProcessedTransactions))
                ) && 
                (
                    this.IsBeingAggregated == input.IsBeingAggregated ||
                    (this.IsBeingAggregated != null &&
                    this.IsBeingAggregated.Equals(input.IsBeingAggregated))
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
                if (this.Challenges != null)
                    hashCode = hashCode * 59 + this.Challenges.GetHashCode();
                if (this.ConnectionStatus != null)
                    hashCode = hashCode * 59 + this.ConnectionStatus.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.HasProcessedAccounts != null)
                    hashCode = hashCode * 59 + this.HasProcessedAccounts.GetHashCode();
                if (this.HasProcessedTransactions != null)
                    hashCode = hashCode * 59 + this.HasProcessedTransactions.GetHashCode();
                if (this.IsBeingAggregated != null)
                    hashCode = hashCode * 59 + this.IsBeingAggregated.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SuccessfullyAggregatedAt != null)
                    hashCode = hashCode * 59 + this.SuccessfullyAggregatedAt.GetHashCode();
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
