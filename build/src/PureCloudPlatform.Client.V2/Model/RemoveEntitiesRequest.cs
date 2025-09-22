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
    /// RemoveEntitiesRequest
    /// </summary>
    [DataContract]
    public partial class RemoveEntitiesRequest :  IEquatable<RemoveEntitiesRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveEntitiesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RemoveEntitiesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveEntitiesRequest" /> class.
        /// </summary>
        /// <param name="Entities">List of entities to be removed (required).</param>
        public RemoveEntitiesRequest(List<RemoveEntity> Entities = null)
        {
            this.Entities = Entities;
            
        }
        


        /// <summary>
        /// List of entities to be removed
        /// </summary>
        /// <value>List of entities to be removed</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<RemoveEntity> Entities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoveEntitiesRequest {\n");

            sb.Append("  Entities: ").Append(Entities).Append("\n");
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
            return this.Equals(obj as RemoveEntitiesRequest);
        }

        /// <summary>
        /// Returns true if RemoveEntitiesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RemoveEntitiesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoveEntitiesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
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
                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                return hash;
            }
        }
    }

}
