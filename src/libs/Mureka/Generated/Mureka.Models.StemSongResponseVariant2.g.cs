
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StemSongResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resp_data")]
        public global::Mureka.StemSongData? RespData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StemSongResponseVariant2" /> class.
        /// </summary>
        /// <param name="respData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StemSongResponseVariant2(
            global::Mureka.StemSongData? respData)
        {
            this.RespData = respData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StemSongResponseVariant2" /> class.
        /// </summary>
        public StemSongResponseVariant2()
        {
        }
    }
}