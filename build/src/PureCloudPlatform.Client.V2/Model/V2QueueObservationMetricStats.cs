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
    /// V2QueueObservationMetricStats
    /// </summary>
    [DataContract]
    public partial class V2QueueObservationMetricStats :  IEquatable<V2QueueObservationMetricStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2QueueObservationMetricStats" /> class.
        /// </summary>
        /// <param name="Count">The total number of ongoing observations for this metric and media type.</param>
        /// <param name="CalculatedMetricValue">Calculated metric value.</param>
        public V2QueueObservationMetricStats(long? Count = null, long? CalculatedMetricValue = null)
        {
            this.Count = Count;
            this.CalculatedMetricValue = CalculatedMetricValue;
            
        }
        


        /// <summary>
        /// The total number of ongoing observations for this metric and media type
        /// </summary>
        /// <value>The total number of ongoing observations for this metric and media type</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }



        /// <summary>
        /// Calculated metric value
        /// </summary>
        /// <value>Calculated metric value</value>
        [DataMember(Name="calculatedMetricValue", EmitDefaultValue=false)]
        public long? CalculatedMetricValue { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2QueueObservationMetricStats {\n");

            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  CalculatedMetricValue: ").Append(CalculatedMetricValue).Append("\n");
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
            return this.Equals(obj as V2QueueObservationMetricStats);
        }

        /// <summary>
        /// Returns true if V2QueueObservationMetricStats instances are equal
        /// </summary>
        /// <param name="other">Instance of V2QueueObservationMetricStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2QueueObservationMetricStats other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) &&
                (
                    this.CalculatedMetricValue == other.CalculatedMetricValue ||
                    this.CalculatedMetricValue != null &&
                    this.CalculatedMetricValue.Equals(other.CalculatedMetricValue)
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
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                if (this.CalculatedMetricValue != null)
                    hash = hash * 59 + this.CalculatedMetricValue.GetHashCode();

                return hash;
            }
        }
    }

}
