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
    /// ConnectWidgetAttributes
    /// </summary>
    [DataContract]
    public partial class ConnectWidgetAttributes :  IEquatable<ConnectWidgetAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectWidgetAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ConnectWidgetAttributes()
        {
        }
        
        /// <summary>
        /// Gets or Sets ConnectWidgetUrl
        /// </summary>
        [DataMember(Name="connect_widget_url", EmitDefaultValue=false)]
        public string ConnectWidgetUrl { get; private set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectWidgetAttributes {\n");
            sb.Append("  ConnectWidgetUrl: ").Append(ConnectWidgetUrl).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
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
            return this.Equals(input as ConnectWidgetAttributes);
        }

        /// <summary>
        /// Returns true if ConnectWidgetAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectWidgetAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectWidgetAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConnectWidgetUrl == input.ConnectWidgetUrl ||
                    (this.ConnectWidgetUrl != null &&
                    this.ConnectWidgetUrl.Equals(input.ConnectWidgetUrl))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
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
                if (this.ConnectWidgetUrl != null)
                    hashCode = hashCode * 59 + this.ConnectWidgetUrl.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
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
