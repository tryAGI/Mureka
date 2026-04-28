
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecognizeSongRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_audio_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadAudioId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognizeSongRequest" /> class.
        /// </summary>
        /// <param name="uploadAudioId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecognizeSongRequest(
            string uploadAudioId)
        {
            this.UploadAudioId = uploadAudioId ?? throw new global::System.ArgumentNullException(nameof(uploadAudioId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognizeSongRequest" /> class.
        /// </summary>
        public RecognizeSongRequest()
        {
        }
    }
}