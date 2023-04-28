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
    /// RecordingSettings
    /// </summary>
    [DataContract]
    public partial class RecordingSettings :  IEquatable<RecordingSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingSettings" /> class.
        /// </summary>
        /// <param name="MaxSimultaneousStreams">Maximum number of simultaneous screen recording streams.</param>
        /// <param name="MaxConfigurableScreenRecordingStreams">Upper limit that maxSimultaneousStreams can be configured.</param>
        /// <param name="RegionalRecordingStorageEnabled">Store call recordings in the region where they are intended to be recorded, otherwise in the organization's home region.</param>
        public RecordingSettings(int? MaxSimultaneousStreams = null, int? MaxConfigurableScreenRecordingStreams = null, bool? RegionalRecordingStorageEnabled = null)
        {
            this.MaxSimultaneousStreams = MaxSimultaneousStreams;
            this.MaxConfigurableScreenRecordingStreams = MaxConfigurableScreenRecordingStreams;
            this.RegionalRecordingStorageEnabled = RegionalRecordingStorageEnabled;
            
        }
        


        /// <summary>
        /// Maximum number of simultaneous screen recording streams
        /// </summary>
        /// <value>Maximum number of simultaneous screen recording streams</value>
        [DataMember(Name="maxSimultaneousStreams", EmitDefaultValue=false)]
        public int? MaxSimultaneousStreams { get; set; }



        /// <summary>
        /// Upper limit that maxSimultaneousStreams can be configured
        /// </summary>
        /// <value>Upper limit that maxSimultaneousStreams can be configured</value>
        [DataMember(Name="maxConfigurableScreenRecordingStreams", EmitDefaultValue=false)]
        public int? MaxConfigurableScreenRecordingStreams { get; set; }



        /// <summary>
        /// Store call recordings in the region where they are intended to be recorded, otherwise in the organization's home region
        /// </summary>
        /// <value>Store call recordings in the region where they are intended to be recorded, otherwise in the organization's home region</value>
        [DataMember(Name="regionalRecordingStorageEnabled", EmitDefaultValue=false)]
        public bool? RegionalRecordingStorageEnabled { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingSettings {\n");

            sb.Append("  MaxSimultaneousStreams: ").Append(MaxSimultaneousStreams).Append("\n");
            sb.Append("  MaxConfigurableScreenRecordingStreams: ").Append(MaxConfigurableScreenRecordingStreams).Append("\n");
            sb.Append("  RegionalRecordingStorageEnabled: ").Append(RegionalRecordingStorageEnabled).Append("\n");
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
            return this.Equals(obj as RecordingSettings);
        }

        /// <summary>
        /// Returns true if RecordingSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MaxSimultaneousStreams == other.MaxSimultaneousStreams ||
                    this.MaxSimultaneousStreams != null &&
                    this.MaxSimultaneousStreams.Equals(other.MaxSimultaneousStreams)
                ) &&
                (
                    this.MaxConfigurableScreenRecordingStreams == other.MaxConfigurableScreenRecordingStreams ||
                    this.MaxConfigurableScreenRecordingStreams != null &&
                    this.MaxConfigurableScreenRecordingStreams.Equals(other.MaxConfigurableScreenRecordingStreams)
                ) &&
                (
                    this.RegionalRecordingStorageEnabled == other.RegionalRecordingStorageEnabled ||
                    this.RegionalRecordingStorageEnabled != null &&
                    this.RegionalRecordingStorageEnabled.Equals(other.RegionalRecordingStorageEnabled)
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
                if (this.MaxSimultaneousStreams != null)
                    hash = hash * 59 + this.MaxSimultaneousStreams.GetHashCode();

                if (this.MaxConfigurableScreenRecordingStreams != null)
                    hash = hash * 59 + this.MaxConfigurableScreenRecordingStreams.GetHashCode();

                if (this.RegionalRecordingStorageEnabled != null)
                    hash = hash * 59 + this.RegionalRecordingStorageEnabled.GetHashCode();

                return hash;
            }
        }
    }

}
