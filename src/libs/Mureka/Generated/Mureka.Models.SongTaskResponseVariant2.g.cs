
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SongTaskResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resp_data")]
        public global::Mureka.TaskData? RespData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Mureka.TaskData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SongTaskResponseVariant2" /> class.
        /// </summary>
        /// <param name="respData"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SongTaskResponseVariant2(
            global::Mureka.TaskData? respData,
            global::Mureka.TaskData? data)
        {
            this.RespData = respData;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SongTaskResponseVariant2" /> class.
        /// </summary>
        public SongTaskResponseVariant2()
        {
        }
    }
}