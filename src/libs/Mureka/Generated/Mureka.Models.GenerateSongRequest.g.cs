
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateSongRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lyrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mureka.JsonConverters.GenerateSongRequestModelJsonConverter))]
        public global::Mureka.GenerateSongRequestModel? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_id")]
        public string? ReferenceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vocal_id")]
        public string? VocalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("melody_id")]
        public string? MelodyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instrumental_id")]
        public string? InstrumentalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSongRequest" /> class.
        /// </summary>
        /// <param name="lyrics"></param>
        /// <param name="model"></param>
        /// <param name="n"></param>
        /// <param name="prompt"></param>
        /// <param name="referenceId"></param>
        /// <param name="vocalId"></param>
        /// <param name="melodyId"></param>
        /// <param name="instrumentalId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateSongRequest(
            string lyrics,
            global::Mureka.GenerateSongRequestModel? model,
            int? n,
            string? prompt,
            string? referenceId,
            string? vocalId,
            string? melodyId,
            string? instrumentalId)
        {
            this.Lyrics = lyrics ?? throw new global::System.ArgumentNullException(nameof(lyrics));
            this.Model = model;
            this.N = n;
            this.Prompt = prompt;
            this.ReferenceId = referenceId;
            this.VocalId = vocalId;
            this.MelodyId = melodyId;
            this.InstrumentalId = instrumentalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSongRequest" /> class.
        /// </summary>
        public GenerateSongRequest()
        {
        }
    }
}