#nullable enable

namespace Mureka
{
    public partial interface ISongsClient
    {
        /// <summary>
        /// Generate a complete song
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mureka.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mureka.TaskResponse> GenerateSongAsync(

            global::Mureka.GenerateSongRequest request,
            global::Mureka.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a complete song
        /// </summary>
        /// <param name="lyrics"></param>
        /// <param name="model"></param>
        /// <param name="n"></param>
        /// <param name="prompt"></param>
        /// <param name="referenceId"></param>
        /// <param name="vocalId"></param>
        /// <param name="melodyId"></param>
        /// <param name="instrumentalId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mureka.TaskResponse> GenerateSongAsync(
            string lyrics,
            global::Mureka.GenerateSongRequestModel? model = default,
            int? n = default,
            string? prompt = default,
            string? referenceId = default,
            string? vocalId = default,
            string? melodyId = default,
            string? instrumentalId = default,
            global::Mureka.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}