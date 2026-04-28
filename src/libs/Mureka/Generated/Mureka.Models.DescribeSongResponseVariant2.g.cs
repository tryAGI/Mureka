
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DescribeSongResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resp_data")]
        public global::Mureka.DescribeSongData? RespData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeSongResponseVariant2" /> class.
        /// </summary>
        /// <param name="respData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DescribeSongResponseVariant2(
            global::Mureka.DescribeSongData? respData)
        {
            this.RespData = respData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeSongResponseVariant2" /> class.
        /// </summary>
        public DescribeSongResponseVariant2()
        {
        }
    }
}