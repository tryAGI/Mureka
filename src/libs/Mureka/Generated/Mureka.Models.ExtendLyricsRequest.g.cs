
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtendLyricsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lyrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendLyricsRequest" /> class.
        /// </summary>
        /// <param name="lyrics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtendLyricsRequest(
            string lyrics)
        {
            this.Lyrics = lyrics ?? throw new global::System.ArgumentNullException(nameof(lyrics));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendLyricsRequest" /> class.
        /// </summary>
        public ExtendLyricsRequest()
        {
        }
    }
}