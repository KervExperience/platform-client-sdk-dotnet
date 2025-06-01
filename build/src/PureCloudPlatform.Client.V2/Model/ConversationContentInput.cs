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
    /// Single or multiline text input component.
    /// </summary>
    [DataContract]
    public partial class ConversationContentInput :  IEquatable<ConversationContentInput>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationContentInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentInput" /> class.
        /// </summary>
        /// <param name="Id">Unique identifier for the input.</param>
        /// <param name="Title">The main text displayed for the input field(s)..</param>
        /// <param name="Subtitle">Additional text providing more details about the input field(s)..</param>
        /// <param name="PlaceholderText">Placeholder text for input field(s)..</param>
        /// <param name="IsRequired">Whether the input field(s) are required to be filled in. (required).</param>
        /// <param name="IsMultipleLine">Whether the input should allow multiple lines of text. (required).</param>
        public ConversationContentInput(string Id = null, string Title = null, string Subtitle = null, string PlaceholderText = null, bool? IsRequired = null, bool? IsMultipleLine = null)
        {
            this.Id = Id;
            this.Title = Title;
            this.Subtitle = Subtitle;
            this.PlaceholderText = PlaceholderText;
            this.IsRequired = IsRequired;
            this.IsMultipleLine = IsMultipleLine;
            
        }
        


        /// <summary>
        /// Unique identifier for the input
        /// </summary>
        /// <value>Unique identifier for the input</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The main text displayed for the input field(s).
        /// </summary>
        /// <value>The main text displayed for the input field(s).</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// Additional text providing more details about the input field(s).
        /// </summary>
        /// <value>Additional text providing more details about the input field(s).</value>
        [DataMember(Name="subtitle", EmitDefaultValue=false)]
        public string Subtitle { get; set; }



        /// <summary>
        /// Placeholder text for input field(s).
        /// </summary>
        /// <value>Placeholder text for input field(s).</value>
        [DataMember(Name="placeholderText", EmitDefaultValue=false)]
        public string PlaceholderText { get; set; }



        /// <summary>
        /// Whether the input field(s) are required to be filled in.
        /// </summary>
        /// <value>Whether the input field(s) are required to be filled in.</value>
        [DataMember(Name="isRequired", EmitDefaultValue=false)]
        public bool? IsRequired { get; set; }



        /// <summary>
        /// Whether the input should allow multiple lines of text.
        /// </summary>
        /// <value>Whether the input should allow multiple lines of text.</value>
        [DataMember(Name="isMultipleLine", EmitDefaultValue=false)]
        public bool? IsMultipleLine { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationContentInput {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  PlaceholderText: ").Append(PlaceholderText).Append("\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  IsMultipleLine: ").Append(IsMultipleLine).Append("\n");
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
            return this.Equals(obj as ConversationContentInput);
        }

        /// <summary>
        /// Returns true if ConversationContentInput instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationContentInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationContentInput other)
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
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Subtitle == other.Subtitle ||
                    this.Subtitle != null &&
                    this.Subtitle.Equals(other.Subtitle)
                ) &&
                (
                    this.PlaceholderText == other.PlaceholderText ||
                    this.PlaceholderText != null &&
                    this.PlaceholderText.Equals(other.PlaceholderText)
                ) &&
                (
                    this.IsRequired == other.IsRequired ||
                    this.IsRequired != null &&
                    this.IsRequired.Equals(other.IsRequired)
                ) &&
                (
                    this.IsMultipleLine == other.IsMultipleLine ||
                    this.IsMultipleLine != null &&
                    this.IsMultipleLine.Equals(other.IsMultipleLine)
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

                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Subtitle != null)
                    hash = hash * 59 + this.Subtitle.GetHashCode();

                if (this.PlaceholderText != null)
                    hash = hash * 59 + this.PlaceholderText.GetHashCode();

                if (this.IsRequired != null)
                    hash = hash * 59 + this.IsRequired.GetHashCode();

                if (this.IsMultipleLine != null)
                    hash = hash * 59 + this.IsMultipleLine.GetHashCode();

                return hash;
            }
        }
    }

}
