#nullable enable

namespace Mureka
{
    public partial interface IInstrumentalsClient
    {
        /// <summary>
        /// Generate instrumental music
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mureka.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mureka.TaskResponse> GenerateInstrumentalAsync(

            global::Mureka.GenerateInstrumentalRequest request,
            global::Mureka.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate instrumental music
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="model"></param>
        /// <param name="n"></param>
        /// <param name="instrumentalId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mureka.TaskResponse> GenerateInstrumentalAsync(
            string? prompt = default,
            global::Mureka.GenerateInstrumentalRequestModel? model = default,
            int? n = default,
            string? instrumentalId = default,
            global::Mureka.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}