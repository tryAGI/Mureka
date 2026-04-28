
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateInstrumentalRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mureka.JsonConverters.GenerateInstrumentalRequestModelJsonConverter))]
        public global::Mureka.GenerateInstrumentalRequestModel? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

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
        /// Initializes a new instance of the <see cref="GenerateInstrumentalRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="model"></param>
        /// <param name="n"></param>
        /// <param name="instrumentalId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateInstrumentalRequest(
            string? prompt,
            global::Mureka.GenerateInstrumentalRequestModel? model,
            int? n,
            string? instrumentalId)
        {
            this.Prompt = prompt;
            this.Model = model;
            this.N = n;
            this.InstrumentalId = instrumentalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateInstrumentalRequest" /> class.
        /// </summary>
        public GenerateInstrumentalRequest()
        {
        }
    }
}