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
    /// ConnectWidgetRequestBody
    /// </summary>
    [DataContract]
    public partial class ConnectWidgetRequestBody :  IEquatable<ConnectWidgetRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectWidgetRequestBody" /> class.
        /// </summary>
        /// <param name="isMobileWebview">isMobileWebview.</param>
        /// <param name="colorScheme">colorScheme.</param>
        /// <param name="currentInstitutionCode">currentInstitutionCode.</param>
        /// <param name="currentMemberGuid">currentMemberGuid.</param>
        /// <param name="disableInstitutionSearch">disableInstitutionSearch.</param>
        /// <param name="includeTransactions">includeTransactions.</param>
        /// <param name="mode">mode.</param>
        /// <param name="uiMessageVersion">uiMessageVersion.</param>
        /// <param name="uiMessageWebviewUrlScheme">uiMessageWebviewUrlScheme.</param>
        /// <param name="updateCredentials">updateCredentials.</param>
        /// <param name="waitForFullAggregation">waitForFullAggregation.</param>
        public ConnectWidgetRequestBody(bool? isMobileWebview = default(bool?), string colorScheme = default(string), string currentInstitutionCode = default(string), string currentMemberGuid = default(string), bool? disableInstitutionSearch = default(bool?), bool? includeTransactions = default(bool?), string mode = default(string), decimal? uiMessageVersion = default(decimal?), string uiMessageWebviewUrlScheme = default(string), bool? updateCredentials = default(bool?), bool? waitForFullAggregation = default(bool?))
        {
            this.IsMobileWebview = isMobileWebview;
            this.ColorScheme = colorScheme;
            this.CurrentInstitutionCode = currentInstitutionCode;
            this.CurrentMemberGuid = currentMemberGuid;
            this.DisableInstitutionSearch = disableInstitutionSearch;
            this.IncludeTransactions = includeTransactions;
            this.Mode = mode;
            this.UiMessageVersion = uiMessageVersion;
            this.UiMessageWebviewUrlScheme = uiMessageWebviewUrlScheme;
            this.UpdateCredentials = updateCredentials;
            this.WaitForFullAggregation = waitForFullAggregation;
        }
        
        /// <summary>
        /// Gets or Sets IsMobileWebview
        /// </summary>
        [DataMember(Name="is_mobile_webview", EmitDefaultValue=false)]
        public bool? IsMobileWebview { get; set; }

        /// <summary>
        /// Gets or Sets ColorScheme
        /// </summary>
        [DataMember(Name="color_scheme", EmitDefaultValue=false)]
        public string ColorScheme { get; set; }

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
        /// Gets or Sets DisableInstitutionSearch
        /// </summary>
        [DataMember(Name="disable_institution_search", EmitDefaultValue=false)]
        public bool? DisableInstitutionSearch { get; set; }

        /// <summary>
        /// Gets or Sets IncludeTransactions
        /// </summary>
        [DataMember(Name="include_transactions", EmitDefaultValue=false)]
        public bool? IncludeTransactions { get; set; }

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or Sets UiMessageVersion
        /// </summary>
        [DataMember(Name="ui_message_version", EmitDefaultValue=false)]
        public decimal? UiMessageVersion { get; set; }

        /// <summary>
        /// Gets or Sets UiMessageWebviewUrlScheme
        /// </summary>
        [DataMember(Name="ui_message_webview_url_scheme", EmitDefaultValue=false)]
        public string UiMessageWebviewUrlScheme { get; set; }

        /// <summary>
        /// Gets or Sets UpdateCredentials
        /// </summary>
        [DataMember(Name="update_credentials", EmitDefaultValue=false)]
        public bool? UpdateCredentials { get; set; }

        /// <summary>
        /// Gets or Sets WaitForFullAggregation
        /// </summary>
        [DataMember(Name="wait_for_full_aggregation", EmitDefaultValue=false)]
        public bool? WaitForFullAggregation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectWidgetRequestBody {\n");
            sb.Append("  IsMobileWebview: ").Append(IsMobileWebview).Append("\n");
            sb.Append("  ColorScheme: ").Append(ColorScheme).Append("\n");
            sb.Append("  CurrentInstitutionCode: ").Append(CurrentInstitutionCode).Append("\n");
            sb.Append("  CurrentMemberGuid: ").Append(CurrentMemberGuid).Append("\n");
            sb.Append("  DisableInstitutionSearch: ").Append(DisableInstitutionSearch).Append("\n");
            sb.Append("  IncludeTransactions: ").Append(IncludeTransactions).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  UiMessageVersion: ").Append(UiMessageVersion).Append("\n");
            sb.Append("  UiMessageWebviewUrlScheme: ").Append(UiMessageWebviewUrlScheme).Append("\n");
            sb.Append("  UpdateCredentials: ").Append(UpdateCredentials).Append("\n");
            sb.Append("  WaitForFullAggregation: ").Append(WaitForFullAggregation).Append("\n");
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
                    this.ColorScheme == input.ColorScheme ||
                    (this.ColorScheme != null &&
                    this.ColorScheme.Equals(input.ColorScheme))
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
                    this.DisableInstitutionSearch == input.DisableInstitutionSearch ||
                    (this.DisableInstitutionSearch != null &&
                    this.DisableInstitutionSearch.Equals(input.DisableInstitutionSearch))
                ) && 
                (
                    this.IncludeTransactions == input.IncludeTransactions ||
                    (this.IncludeTransactions != null &&
                    this.IncludeTransactions.Equals(input.IncludeTransactions))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.UiMessageVersion == input.UiMessageVersion ||
                    (this.UiMessageVersion != null &&
                    this.UiMessageVersion.Equals(input.UiMessageVersion))
                ) && 
                (
                    this.UiMessageWebviewUrlScheme == input.UiMessageWebviewUrlScheme ||
                    (this.UiMessageWebviewUrlScheme != null &&
                    this.UiMessageWebviewUrlScheme.Equals(input.UiMessageWebviewUrlScheme))
                ) && 
                (
                    this.UpdateCredentials == input.UpdateCredentials ||
                    (this.UpdateCredentials != null &&
                    this.UpdateCredentials.Equals(input.UpdateCredentials))
                ) && 
                (
                    this.WaitForFullAggregation == input.WaitForFullAggregation ||
                    (this.WaitForFullAggregation != null &&
                    this.WaitForFullAggregation.Equals(input.WaitForFullAggregation))
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
                if (this.ColorScheme != null)
                    hashCode = hashCode * 59 + this.ColorScheme.GetHashCode();
                if (this.CurrentInstitutionCode != null)
                    hashCode = hashCode * 59 + this.CurrentInstitutionCode.GetHashCode();
                if (this.CurrentMemberGuid != null)
                    hashCode = hashCode * 59 + this.CurrentMemberGuid.GetHashCode();
                if (this.DisableInstitutionSearch != null)
                    hashCode = hashCode * 59 + this.DisableInstitutionSearch.GetHashCode();
                if (this.IncludeTransactions != null)
                    hashCode = hashCode * 59 + this.IncludeTransactions.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.UiMessageVersion != null)
                    hashCode = hashCode * 59 + this.UiMessageVersion.GetHashCode();
                if (this.UiMessageWebviewUrlScheme != null)
                    hashCode = hashCode * 59 + this.UiMessageWebviewUrlScheme.GetHashCode();
                if (this.UpdateCredentials != null)
                    hashCode = hashCode * 59 + this.UpdateCredentials.GetHashCode();
                if (this.WaitForFullAggregation != null)
                    hashCode = hashCode * 59 + this.WaitForFullAggregation.GetHashCode();
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
