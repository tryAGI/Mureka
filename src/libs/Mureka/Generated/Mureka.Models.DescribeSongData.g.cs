
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DescribeSongData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instrument")]
        public global::System.Collections.Generic.IList<string>? Instrument { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genres")]
        public global::System.Collections.Generic.IList<string>? Genres { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeSongData" /> class.
        /// </summary>
        /// <param name="instrument"></param>
        /// <param name="genres"></param>
        /// <param name="tags"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DescribeSongData(
            global::System.Collections.Generic.IList<string>? instrument,
            global::System.Collections.Generic.IList<string>? genres,
            global::System.Collections.Generic.IList<string>? tags,
            string? description)
        {
            this.Instrument = instrument;
            this.Genres = genres;
            this.Tags = tags;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeSongData" /> class.
        /// </summary>
        public DescribeSongData()
        {
        }
    }
}