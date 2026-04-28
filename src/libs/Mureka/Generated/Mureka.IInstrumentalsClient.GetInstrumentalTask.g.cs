#nullable enable

namespace Mureka
{
    public partial interface IInstrumentalsClient
    {
        /// <summary>
        /// Query an instrumental generation task
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mureka.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mureka.SongTaskResponse> GetInstrumentalTaskAsync(
            string taskId,
            global::Mureka.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}