
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtendLyricsResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resp_data")]
        public global::Mureka.ExtendLyricsData? RespData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendLyricsResponseVariant2" /> class.
        /// </summary>
        /// <param name="respData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtendLyricsResponseVariant2(
            global::Mureka.ExtendLyricsData? respData)
        {
            this.RespData = respData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendLyricsResponseVariant2" /> class.
        /// </summary>
        public ExtendLyricsResponseVariant2()
        {
        }
    }
}