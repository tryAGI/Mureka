
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecognizeSongData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public long? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics_sections")]
        public global::System.Collections.Generic.IList<global::Mureka.LyricsSection>? LyricsSections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognizeSongData" /> class.
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="lyricsSections"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecognizeSongData(
            long? duration,
            global::System.Collections.Generic.IList<global::Mureka.LyricsSection>? lyricsSections)
        {
            this.Duration = duration;
            this.LyricsSections = lyricsSections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognizeSongData" /> class.
        /// </summary>
        public RecognizeSongData()
        {
        }
    }
}