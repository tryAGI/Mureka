
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SongChoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flac_url")]
        public string? FlacUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_url")]
        public string? StreamUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="SongChoice" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="flacUrl"></param>
        /// <param name="streamUrl"></param>
        /// <param name="duration"></param>
        /// <param name="lyricsSections"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SongChoice(
            int? index,
            string? id,
            string? url,
            string? flacUrl,
            string? streamUrl,
            long? duration,
            global::System.Collections.Generic.IList<global::Mureka.LyricsSection>? lyricsSections)
        {
            this.Index = index;
            this.Id = id;
            this.Url = url;
            this.FlacUrl = flacUrl;
            this.StreamUrl = streamUrl;
            this.Duration = duration;
            this.LyricsSections = lyricsSections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SongChoice" /> class.
        /// </summary>
        public SongChoice()
        {
        }
    }
}