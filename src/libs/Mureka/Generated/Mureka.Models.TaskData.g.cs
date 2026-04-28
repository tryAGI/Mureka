
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public long? FinishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_reason")]
        public string? FailedReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermarked")]
        public bool? Watermarked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public int? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::Mureka.SongChoice>? Choices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskData" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="taskId"></param>
        /// <param name="createdAt"></param>
        /// <param name="finishedAt"></param>
        /// <param name="model"></param>
        /// <param name="status"></param>
        /// <param name="failedReason"></param>
        /// <param name="watermarked"></param>
        /// <param name="progress"></param>
        /// <param name="choices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskData(
            string? id,
            string? taskId,
            long? createdAt,
            long? finishedAt,
            string? model,
            string? status,
            string? failedReason,
            bool? watermarked,
            int? progress,
            global::System.Collections.Generic.IList<global::Mureka.SongChoice>? choices)
        {
            this.Id = id;
            this.TaskId = taskId;
            this.CreatedAt = createdAt;
            this.FinishedAt = finishedAt;
            this.Model = model;
            this.Status = status;
            this.FailedReason = failedReason;
            this.Watermarked = watermarked;
            this.Progress = progress;
            this.Choices = choices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskData" /> class.
        /// </summary>
        public TaskData()
        {
        }
    }
}