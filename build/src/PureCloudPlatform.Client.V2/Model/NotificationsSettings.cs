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
    /// Notification settings that handles messenger notifications
    /// </summary>
    [DataContract]
    public partial class NotificationsSettings :  IEquatable<NotificationsSettings>
    {
        /// <summary>
        /// The notification content type settings for messenger
        /// </summary>
        /// <value>The notification content type settings for messenger</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NotificationContentTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Includemessagescontent for "IncludeMessagesContent"
            /// </summary>
            [EnumMember(Value = "IncludeMessagesContent")]
            Includemessagescontent,
            
            /// <summary>
            /// Enum Excludemessagescontent for "ExcludeMessagesContent"
            /// </summary>
            [EnumMember(Value = "ExcludeMessagesContent")]
            Excludemessagescontent
        }
        /// <summary>
        /// The notification content type settings for messenger
        /// </summary>
        /// <value>The notification content type settings for messenger</value>
        [DataMember(Name="notificationContentType", EmitDefaultValue=false)]
        public NotificationContentTypeEnum? NotificationContentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationsSettings" /> class.
        /// </summary>
        /// <param name="Enabled">The toggle to enable or disable notifications.</param>
        /// <param name="NotificationContentType">The notification content type settings for messenger.</param>
        public NotificationsSettings(bool? Enabled = null, NotificationContentTypeEnum? NotificationContentType = null)
        {
            this.Enabled = Enabled;
            this.NotificationContentType = NotificationContentType;
            
        }
        


        /// <summary>
        /// The toggle to enable or disable notifications
        /// </summary>
        /// <value>The toggle to enable or disable notifications</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationsSettings {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  NotificationContentType: ").Append(NotificationContentType).Append("\n");
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
            return this.Equals(obj as NotificationsSettings);
        }

        /// <summary>
        /// Returns true if NotificationsSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of NotificationsSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationsSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.NotificationContentType == other.NotificationContentType ||
                    this.NotificationContentType != null &&
                    this.NotificationContentType.Equals(other.NotificationContentType)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.NotificationContentType != null)
                    hash = hash * 59 + this.NotificationContentType.GetHashCode();

                return hash;
            }
        }
    }

}
