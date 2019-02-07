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
    /// Statement
    /// </summary>
    [DataContract]
    public partial class Statement :  IEquatable<Statement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Statement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Statement()
        {
        }
        
        /// <summary>
        /// The unique identifier for the &#x60;account&#x60; associated with the &#x60;statement&#x60;. Defined by MX.
        /// </summary>
        /// <value>The unique identifier for the &#x60;account&#x60; associated with the &#x60;statement&#x60;. Defined by MX.</value>
        [DataMember(Name="account_guid", EmitDefaultValue=false)]
        public string AccountGuid { get; private set; }

        /// <summary>
        /// The date and time the &#x60;statement&#x60; was created.
        /// </summary>
        /// <value>The date and time the &#x60;statement&#x60; was created.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; private set; }

        /// <summary>
        /// The unique identifier for the &#x60;statement&#x60;. Defined by MX.
        /// </summary>
        /// <value>The unique identifier for the &#x60;statement&#x60;. Defined by MX.</value>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; private set; }

        /// <summary>
        /// The unique identifier for the &#x60;member&#x60; associated with the &#x60;statement&#x60;.  Defined by MX.
        /// </summary>
        /// <value>The unique identifier for the &#x60;member&#x60; associated with the &#x60;statement&#x60;.  Defined by MX.</value>
        [DataMember(Name="member_guid", EmitDefaultValue=false)]
        public string MemberGuid { get; private set; }

        /// <summary>
        /// A URI for accessing the byte payload of the &#x60;statement&#x60;.
        /// </summary>
        /// <value>A URI for accessing the byte payload of the &#x60;statement&#x60;.</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; private set; }

        /// <summary>
        /// The unique identifier for the &#x60;user&#x60; associated with the &#x60;statement&#x60;.  Defined by MX.
        /// </summary>
        /// <value>The unique identifier for the &#x60;user&#x60; associated with the &#x60;statement&#x60;.  Defined by MX.</value>
        [DataMember(Name="user_guid", EmitDefaultValue=false)]
        public string UserGuid { get; private set; }

        /// <summary>
        /// The date and time at which the &#x60;statement&#x60; was last updated.
        /// </summary>
        /// <value>The date and time at which the &#x60;statement&#x60; was last updated.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Statement {\n");
            sb.Append("  AccountGuid: ").Append(AccountGuid).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  MemberGuid: ").Append(MemberGuid).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  UserGuid: ").Append(UserGuid).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as Statement);
        }

        /// <summary>
        /// Returns true if Statement instances are equal
        /// </summary>
        /// <param name="input">Instance of Statement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Statement input)
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
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.MemberGuid == input.MemberGuid ||
                    (this.MemberGuid != null &&
                    this.MemberGuid.Equals(input.MemberGuid))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.UserGuid == input.UserGuid ||
                    (this.UserGuid != null &&
                    this.UserGuid.Equals(input.UserGuid))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.MemberGuid != null)
                    hashCode = hashCode * 59 + this.MemberGuid.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.UserGuid != null)
                    hashCode = hashCode * 59 + this.UserGuid.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
