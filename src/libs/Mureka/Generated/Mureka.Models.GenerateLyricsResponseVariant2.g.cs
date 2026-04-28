
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateLyricsResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resp_data")]
        public global::Mureka.GenerateLyricsData? RespData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateLyricsResponseVariant2" /> class.
        /// </summary>
        /// <param name="respData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateLyricsResponseVariant2(
            global::Mureka.GenerateLyricsData? respData)
        {
            this.RespData = respData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateLyricsResponseVariant2" /> class.
        /// </summary>
        public GenerateLyricsResponseVariant2()
        {
        }
    }
}