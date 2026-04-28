#nullable enable

namespace Mureka
{
    public partial interface ISongsClient
    {
        /// <summary>
        /// Recognize lyrics and timings from an uploaded song
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mureka.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mureka.RecognizeSongResponse> RecognizeSongAsync(

            global::Mureka.RecognizeSongRequest request,
            global::Mureka.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recognize lyrics and timings from an uploaded song
        /// </summary>
        /// <param name="uploadAudioId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mureka.RecognizeSongResponse> RecognizeSongAsync(
            string uploadAudioId,
            global::Mureka.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}