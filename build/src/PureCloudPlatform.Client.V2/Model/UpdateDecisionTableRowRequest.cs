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
    /// UpdateDecisionTableRowRequest
    /// </summary>
    [DataContract]
    public partial class UpdateDecisionTableRowRequest :  IEquatable<UpdateDecisionTableRowRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDecisionTableRowRequest" /> class.
        /// </summary>
        /// <param name="Inputs">The updated input values of the row. The key for this map is the column ID the row value relates. Column IDs are available from the decision table entity.</param>
        /// <param name="Outputs">The updated output values of the row. The key for this map is the column ID the row value relates. Column IDs are available from the decision table entity.</param>
        public UpdateDecisionTableRowRequest(Dictionary<string, DecisionTableRowParameterValue> Inputs = null, Dictionary<string, DecisionTableRowParameterValue> Outputs = null)
        {
            this.Inputs = Inputs;
            this.Outputs = Outputs;
            
        }
        


        /// <summary>
        /// The updated input values of the row. The key for this map is the column ID the row value relates. Column IDs are available from the decision table entity
        /// </summary>
        /// <value>The updated input values of the row. The key for this map is the column ID the row value relates. Column IDs are available from the decision table entity</value>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        public Dictionary<string, DecisionTableRowParameterValue> Inputs { get; set; }



        /// <summary>
        /// The updated output values of the row. The key for this map is the column ID the row value relates. Column IDs are available from the decision table entity
        /// </summary>
        /// <value>The updated output values of the row. The key for this map is the column ID the row value relates. Column IDs are available from the decision table entity</value>
        [DataMember(Name="outputs", EmitDefaultValue=false)]
        public Dictionary<string, DecisionTableRowParameterValue> Outputs { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDecisionTableRowRequest {\n");

            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
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
            return this.Equals(obj as UpdateDecisionTableRowRequest);
        }

        /// <summary>
        /// Returns true if UpdateDecisionTableRowRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateDecisionTableRowRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateDecisionTableRowRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Inputs == other.Inputs ||
                    this.Inputs != null &&
                    this.Inputs.SequenceEqual(other.Inputs)
                ) &&
                (
                    this.Outputs == other.Outputs ||
                    this.Outputs != null &&
                    this.Outputs.SequenceEqual(other.Outputs)
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
                if (this.Inputs != null)
                    hash = hash * 59 + this.Inputs.GetHashCode();

                if (this.Outputs != null)
                    hash = hash * 59 + this.Outputs.GetHashCode();

                return hash;
            }
        }
    }

}
