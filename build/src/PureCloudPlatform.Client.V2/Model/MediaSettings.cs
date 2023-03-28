using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// MediaSettings
    /// </summary>
    [DataContract]
    public partial class MediaSettings :  IEquatable<MediaSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaSettings" /> class.
        /// </summary>
        /// <param name="EnableAutoAnswer">Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings..</param>
        /// <param name="AlertingTimeoutSeconds">AlertingTimeoutSeconds.</param>
        /// <param name="ServiceLevel">ServiceLevel.</param>
        /// <param name="SubTypeSettings">Map of media subtype to media subtype specific settings..</param>
        public MediaSettings(bool? EnableAutoAnswer = null, int? AlertingTimeoutSeconds = null, ServiceLevel ServiceLevel = null, Dictionary<string, BaseMediaSettings> SubTypeSettings = null)
        {
            this.EnableAutoAnswer = EnableAutoAnswer;
            this.AlertingTimeoutSeconds = AlertingTimeoutSeconds;
            this.ServiceLevel = ServiceLevel;
            this.SubTypeSettings = SubTypeSettings;
            
        }
        


        /// <summary>
        /// Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings.
        /// </summary>
        /// <value>Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings.</value>
        [DataMember(Name="enableAutoAnswer", EmitDefaultValue=false)]
        public bool? EnableAutoAnswer { get; set; }



        /// <summary>
        /// Gets or Sets AlertingTimeoutSeconds
        /// </summary>
        [DataMember(Name="alertingTimeoutSeconds", EmitDefaultValue=false)]
        public int? AlertingTimeoutSeconds { get; set; }



        /// <summary>
        /// Gets or Sets ServiceLevel
        /// </summary>
        [DataMember(Name="serviceLevel", EmitDefaultValue=false)]
        public ServiceLevel ServiceLevel { get; set; }



        /// <summary>
        /// Map of media subtype to media subtype specific settings.
        /// </summary>
        /// <value>Map of media subtype to media subtype specific settings.</value>
        [DataMember(Name="subTypeSettings", EmitDefaultValue=false)]
        public Dictionary<string, BaseMediaSettings> SubTypeSettings { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaSettings {\n");

            sb.Append("  EnableAutoAnswer: ").Append(EnableAutoAnswer).Append("\n");
            sb.Append("  AlertingTimeoutSeconds: ").Append(AlertingTimeoutSeconds).Append("\n");
            sb.Append("  ServiceLevel: ").Append(ServiceLevel).Append("\n");
            sb.Append("  SubTypeSettings: ").Append(SubTypeSettings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as MediaSettings);
        }

        /// <summary>
        /// Returns true if MediaSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EnableAutoAnswer == other.EnableAutoAnswer ||
                    this.EnableAutoAnswer != null &&
                    this.EnableAutoAnswer.Equals(other.EnableAutoAnswer)
                ) &&
                (
                    this.AlertingTimeoutSeconds == other.AlertingTimeoutSeconds ||
                    this.AlertingTimeoutSeconds != null &&
                    this.AlertingTimeoutSeconds.Equals(other.AlertingTimeoutSeconds)
                ) &&
                (
                    this.ServiceLevel == other.ServiceLevel ||
                    this.ServiceLevel != null &&
                    this.ServiceLevel.Equals(other.ServiceLevel)
                ) &&
                (
                    this.SubTypeSettings == other.SubTypeSettings ||
                    this.SubTypeSettings != null &&
                    this.SubTypeSettings.SequenceEqual(other.SubTypeSettings)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.EnableAutoAnswer != null)
                    hash = hash * 59 + this.EnableAutoAnswer.GetHashCode();

                if (this.AlertingTimeoutSeconds != null)
                    hash = hash * 59 + this.AlertingTimeoutSeconds.GetHashCode();

                if (this.ServiceLevel != null)
                    hash = hash * 59 + this.ServiceLevel.GetHashCode();

                if (this.SubTypeSettings != null)
                    hash = hash * 59 + this.SubTypeSettings.GetHashCode();

                return hash;
            }
        }
    }

}
