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
    /// EmailConversation
    /// </summary>
    [DataContract]
    public partial class EmailConversation :  IEquatable<EmailConversation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailConversation" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Participants">The list of participants involved in the conversation..</param>
        /// <param name="OtherMediaUris">The list of other media channels involved in the conversation..</param>
        /// <param name="RecentTransfers">The list of the most recent 20 transfer commands applied to this conversation..</param>
        public EmailConversation(string Name = null, List<EmailMediaParticipant> Participants = null, List<string> OtherMediaUris = null, List<TransferResponse> RecentTransfers = null)
        {
            this.Name = Name;
            this.Participants = Participants;
            this.OtherMediaUris = OtherMediaUris;
            this.RecentTransfers = RecentTransfers;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The list of participants involved in the conversation.
        /// </summary>
        /// <value>The list of participants involved in the conversation.</value>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<EmailMediaParticipant> Participants { get; set; }



        /// <summary>
        /// The list of other media channels involved in the conversation.
        /// </summary>
        /// <value>The list of other media channels involved in the conversation.</value>
        [DataMember(Name="otherMediaUris", EmitDefaultValue=false)]
        public List<string> OtherMediaUris { get; set; }



        /// <summary>
        /// The list of the most recent 20 transfer commands applied to this conversation.
        /// </summary>
        /// <value>The list of the most recent 20 transfer commands applied to this conversation.</value>
        [DataMember(Name="recentTransfers", EmitDefaultValue=false)]
        public List<TransferResponse> RecentTransfers { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailConversation {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            sb.Append("  OtherMediaUris: ").Append(OtherMediaUris).Append("\n");
            sb.Append("  RecentTransfers: ").Append(RecentTransfers).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as EmailConversation);
        }

        /// <summary>
        /// Returns true if EmailConversation instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailConversation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailConversation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Participants == other.Participants ||
                    this.Participants != null &&
                    this.Participants.SequenceEqual(other.Participants)
                ) &&
                (
                    this.OtherMediaUris == other.OtherMediaUris ||
                    this.OtherMediaUris != null &&
                    this.OtherMediaUris.SequenceEqual(other.OtherMediaUris)
                ) &&
                (
                    this.RecentTransfers == other.RecentTransfers ||
                    this.RecentTransfers != null &&
                    this.RecentTransfers.SequenceEqual(other.RecentTransfers)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();

                if (this.OtherMediaUris != null)
                    hash = hash * 59 + this.OtherMediaUris.GetHashCode();

                if (this.RecentTransfers != null)
                    hash = hash * 59 + this.RecentTransfers.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
