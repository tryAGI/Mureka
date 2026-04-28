#nullable enable

namespace Mureka
{
    public partial interface ISongsClient
    {
        /// <summary>
        /// Extend an existing song
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mureka.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mureka.TaskResponse> ExtendSongAsync(

            global::Mureka.ExtendSongRequest request,
            global::Mureka.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Extend an existing song
        /// </summary>
        /// <param name="songId"></param>
        /// <param name="uploadAudioId"></param>
        /// <param name="lyrics"></param>
        /// <param name="extendAt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mureka.TaskResponse> ExtendSongAsync(
            long extendAt,
            string? songId = default,
            string? uploadAudioId = default,
            string? lyrics = default,
            global::Mureka.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}