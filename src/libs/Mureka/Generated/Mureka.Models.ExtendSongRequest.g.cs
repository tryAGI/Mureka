
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtendSongRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("song_id")]
        public string? SongId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_audio_id")]
        public string? UploadAudioId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics")]
        public string? Lyrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extend_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ExtendAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendSongRequest" /> class.
        /// </summary>
        /// <param name="extendAt"></param>
        /// <param name="songId"></param>
        /// <param name="uploadAudioId"></param>
        /// <param name="lyrics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtendSongRequest(
            long extendAt,
            string? songId,
            string? uploadAudioId,
            string? lyrics)
        {
            this.SongId = songId;
            this.UploadAudioId = uploadAudioId;
            this.Lyrics = lyrics;
            this.ExtendAt = extendAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendSongRequest" /> class.
        /// </summary>
        public ExtendSongRequest()
        {
        }
    }
}