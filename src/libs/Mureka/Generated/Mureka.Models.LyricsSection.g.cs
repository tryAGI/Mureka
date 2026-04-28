
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LyricsSection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section_type")]
        public string? SectionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public long? Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public long? End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines")]
        public global::System.Collections.Generic.IList<global::Mureka.LyricsLine>? Lines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LyricsSection" /> class.
        /// </summary>
        /// <param name="sectionType"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="lines"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LyricsSection(
            string? sectionType,
            long? start,
            long? end,
            global::System.Collections.Generic.IList<global::Mureka.LyricsLine>? lines)
        {
            this.SectionType = sectionType;
            this.Start = start;
            this.End = end;
            this.Lines = lines;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LyricsSection" /> class.
        /// </summary>
        public LyricsSection()
        {
        }
    }
}