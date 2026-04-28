
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public int? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_msg")]
        public string? CodeMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseResponse" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="codeMsg"></param>
        /// <param name="message"></param>
        /// <param name="traceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseResponse(
            int? code,
            string? codeMsg,
            string? message,
            string? traceId)
        {
            this.Code = code;
            this.CodeMsg = codeMsg;
            this.Message = message;
            this.TraceId = traceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseResponse" /> class.
        /// </summary>
        public BaseResponse()
        {
        }
    }
}