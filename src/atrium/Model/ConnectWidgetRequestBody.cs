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
    /// ConnectWidgetRequestBody
    /// </summary>
    [DataContract]
    public partial class ConnectWidgetRequestBody :  IEquatable<ConnectWidgetRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectWidgetRequestBody" /> class.
        /// </summary>
        /// <param name="isMobileWebview">isMobileWebview.</param>
        /// <param name="currentInstitutionCode">currentInstitutionCode.</param>
        /// <param name="currentMemberGuid">currentMemberGuid.</param>
        /// <param name="updateCredentials">updateCredentials.</param>
        public ConnectWidgetRequestBody(bool? isMobileWebview = default(bool?), string currentInstitutionCode = default(string), string currentMemberGuid = default(string), bool? updateCredentials = default(bool?))
        {
            this.IsMobileWebview = isMobileWebview;
            this.CurrentInstitutionCode = currentInstitutionCode;
            this.CurrentMemberGuid = currentMemberGuid;
            this.UpdateCredentials = updateCredentials;
        }
        
        /// <summary>
        /// Gets or Sets IsMobileWebview
        /// </summary>
        [DataMember(Name="is_mobile_webview", EmitDefaultValue=false)]
        public bool? IsMobileWebview { get; set; }

        /// <summary>
        /// Gets or Sets CurrentInstitutionCode
        /// </summary>
        [DataMember(Name="current_institution_code", EmitDefaultValue=false)]
        public string CurrentInstitutionCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrentMemberGuid
        /// </summary>
        [DataMember(Name="current_member_guid", EmitDefaultValue=false)]
        public string CurrentMemberGuid { get; set; }

        /// <summary>
        /// Gets or Sets UpdateCredentials
        /// </summary>
        [DataMember(Name="update_credentials", EmitDefaultValue=false)]
        public bool? UpdateCredentials { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectWidgetRequestBody {\n");
            sb.Append("  IsMobileWebview: ").Append(IsMobileWebview).Append("\n");
            sb.Append("  CurrentInstitutionCode: ").Append(CurrentInstitutionCode).Append("\n");
            sb.Append("  CurrentMemberGuid: ").Append(CurrentMemberGuid).Append("\n");
            sb.Append("  UpdateCredentials: ").Append(UpdateCredentials).Append("\n");
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
            return this.Equals(input as ConnectWidgetRequestBody);
        }

        /// <summary>
        /// Returns true if ConnectWidgetRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectWidgetRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectWidgetRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsMobileWebview == input.IsMobileWebview ||
                    (this.IsMobileWebview != null &&
                    this.IsMobileWebview.Equals(input.IsMobileWebview))
                ) && 
                (
                    this.CurrentInstitutionCode == input.CurrentInstitutionCode ||
                    (this.CurrentInstitutionCode != null &&
                    this.CurrentInstitutionCode.Equals(input.CurrentInstitutionCode))
                ) && 
                (
                    this.CurrentMemberGuid == input.CurrentMemberGuid ||
                    (this.CurrentMemberGuid != null &&
                    this.CurrentMemberGuid.Equals(input.CurrentMemberGuid))
                ) && 
                (
                    this.UpdateCredentials == input.UpdateCredentials ||
                    (this.UpdateCredentials != null &&
                    this.UpdateCredentials.Equals(input.UpdateCredentials))
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
                if (this.IsMobileWebview != null)
                    hashCode = hashCode * 59 + this.IsMobileWebview.GetHashCode();
                if (this.CurrentInstitutionCode != null)
                    hashCode = hashCode * 59 + this.CurrentInstitutionCode.GetHashCode();
                if (this.CurrentMemberGuid != null)
                    hashCode = hashCode * 59 + this.CurrentMemberGuid.GetHashCode();
                if (this.UpdateCredentials != null)
                    hashCode = hashCode * 59 + this.UpdateCredentials.GetHashCode();
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
