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
    /// KnowledgeDocumentChunkResponse
    /// </summary>
    [DataContract]
    public partial class KnowledgeDocumentChunkResponse :  IEquatable<KnowledgeDocumentChunkResponse>
    {
        /// <summary>
        /// The type of the query that initiates the chunks search.
        /// </summary>
        /// <value>The type of the query that initiates the chunks search.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum QueryTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Autosearch for "AutoSearch"
            /// </summary>
            [EnumMember(Value = "AutoSearch")]
            Autosearch,
            
            /// <summary>
            /// Enum Manualsearch for "ManualSearch"
            /// </summary>
            [EnumMember(Value = "ManualSearch")]
            Manualsearch,
            
            /// <summary>
            /// Enum Suggestion for "Suggestion"
            /// </summary>
            [EnumMember(Value = "Suggestion")]
            Suggestion
        }
        /// <summary>
        /// The type of the query that initiates the chunks search.
        /// </summary>
        /// <value>The type of the query that initiates the chunks search.</value>
        [DataMember(Name="queryType", EmitDefaultValue=false)]
        public QueryTypeEnum? QueryType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentChunkResponse" /> class.
        /// </summary>
        /// <param name="Query">Query to search chunks in the knowledge base..</param>
        /// <param name="PageSize">Page size of the returned results..</param>
        /// <param name="PageNumber">Page number of the returned results..</param>
        /// <param name="QueryType">The type of the query that initiates the chunks search..</param>
        /// <param name="PreprocessQuery">Indicates whether the chunks search query should be preprocessed..</param>
        /// <param name="ConfidenceThreshold">The confidence threshold for the chunk results. If applied, the returned results will have an equal or higher chunk confidence than the threshold..</param>
        /// <param name="Results">Chunks matching the search query..</param>
        /// <param name="Application">The client application details from which chunks search happened..</param>
        /// <param name="ConversationContext">Conversation context information if the chunks search is initiated in the context of a conversation..</param>
        public KnowledgeDocumentChunkResponse(string Query = null, int? PageSize = null, int? PageNumber = null, QueryTypeEnum? QueryType = null, bool? PreprocessQuery = null, float? ConfidenceThreshold = null, List<DocumentChunkBlock> Results = null, KnowledgeSearchClientApplication Application = null, KnowledgeConversationContextResponse ConversationContext = null)
        {
            this.Query = Query;
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            this.QueryType = QueryType;
            this.PreprocessQuery = PreprocessQuery;
            this.ConfidenceThreshold = ConfidenceThreshold;
            this.Results = Results;
            this.Application = Application;
            this.ConversationContext = ConversationContext;
            
        }
        


        /// <summary>
        /// Query to search chunks in the knowledge base.
        /// </summary>
        /// <value>Query to search chunks in the knowledge base.</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }



        /// <summary>
        /// The total number of chunks matching the query.
        /// </summary>
        /// <value>The total number of chunks matching the query.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; private set; }



        /// <summary>
        /// Number of pages returned in the result calculated according to the pageSize and the total
        /// </summary>
        /// <value>Number of pages returned in the result calculated according to the pageSize and the total</value>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; private set; }



        /// <summary>
        /// Page size of the returned results.
        /// </summary>
        /// <value>Page size of the returned results.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }



        /// <summary>
        /// Page number of the returned results.
        /// </summary>
        /// <value>Page number of the returned results.</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }





        /// <summary>
        /// The globally unique identifier for the chunks search.
        /// </summary>
        /// <value>The globally unique identifier for the chunks search.</value>
        [DataMember(Name="searchId", EmitDefaultValue=false)]
        public string SearchId { get; private set; }



        /// <summary>
        /// Indicates whether the chunks search query should be preprocessed.
        /// </summary>
        /// <value>Indicates whether the chunks search query should be preprocessed.</value>
        [DataMember(Name="preprocessQuery", EmitDefaultValue=false)]
        public bool? PreprocessQuery { get; set; }



        /// <summary>
        /// The confidence threshold for the chunk results. If applied, the returned results will have an equal or higher chunk confidence than the threshold.
        /// </summary>
        /// <value>The confidence threshold for the chunk results. If applied, the returned results will have an equal or higher chunk confidence than the threshold.</value>
        [DataMember(Name="confidenceThreshold", EmitDefaultValue=false)]
        public float? ConfidenceThreshold { get; set; }



        /// <summary>
        /// Chunks matching the search query.
        /// </summary>
        /// <value>Chunks matching the search query.</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<DocumentChunkBlock> Results { get; set; }



        /// <summary>
        /// The client application details from which chunks search happened.
        /// </summary>
        /// <value>The client application details from which chunks search happened.</value>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public KnowledgeSearchClientApplication Application { get; set; }



        /// <summary>
        /// Conversation context information if the chunks search is initiated in the context of a conversation.
        /// </summary>
        /// <value>Conversation context information if the chunks search is initiated in the context of a conversation.</value>
        [DataMember(Name="conversationContext", EmitDefaultValue=false)]
        public KnowledgeConversationContextResponse ConversationContext { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeDocumentChunkResponse {\n");

            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  QueryType: ").Append(QueryType).Append("\n");
            sb.Append("  SearchId: ").Append(SearchId).Append("\n");
            sb.Append("  PreprocessQuery: ").Append(PreprocessQuery).Append("\n");
            sb.Append("  ConfidenceThreshold: ").Append(ConfidenceThreshold).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  ConversationContext: ").Append(ConversationContext).Append("\n");
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
            return this.Equals(obj as KnowledgeDocumentChunkResponse);
        }

        /// <summary>
        /// Returns true if KnowledgeDocumentChunkResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeDocumentChunkResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeDocumentChunkResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
                ) &&
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) &&
                (
                    this.PageCount == other.PageCount ||
                    this.PageCount != null &&
                    this.PageCount.Equals(other.PageCount)
                ) &&
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) &&
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) &&
                (
                    this.QueryType == other.QueryType ||
                    this.QueryType != null &&
                    this.QueryType.Equals(other.QueryType)
                ) &&
                (
                    this.SearchId == other.SearchId ||
                    this.SearchId != null &&
                    this.SearchId.Equals(other.SearchId)
                ) &&
                (
                    this.PreprocessQuery == other.PreprocessQuery ||
                    this.PreprocessQuery != null &&
                    this.PreprocessQuery.Equals(other.PreprocessQuery)
                ) &&
                (
                    this.ConfidenceThreshold == other.ConfidenceThreshold ||
                    this.ConfidenceThreshold != null &&
                    this.ConfidenceThreshold.Equals(other.ConfidenceThreshold)
                ) &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
                ) &&
                (
                    this.Application == other.Application ||
                    this.Application != null &&
                    this.Application.Equals(other.Application)
                ) &&
                (
                    this.ConversationContext == other.ConversationContext ||
                    this.ConversationContext != null &&
                    this.ConversationContext.Equals(other.ConversationContext)
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
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();

                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();

                if (this.PageCount != null)
                    hash = hash * 59 + this.PageCount.GetHashCode();

                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();

                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();

                if (this.QueryType != null)
                    hash = hash * 59 + this.QueryType.GetHashCode();

                if (this.SearchId != null)
                    hash = hash * 59 + this.SearchId.GetHashCode();

                if (this.PreprocessQuery != null)
                    hash = hash * 59 + this.PreprocessQuery.GetHashCode();

                if (this.ConfidenceThreshold != null)
                    hash = hash * 59 + this.ConfidenceThreshold.GetHashCode();

                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();

                if (this.Application != null)
                    hash = hash * 59 + this.Application.GetHashCode();

                if (this.ConversationContext != null)
                    hash = hash * 59 + this.ConversationContext.GetHashCode();

                return hash;
            }
        }
    }

}
