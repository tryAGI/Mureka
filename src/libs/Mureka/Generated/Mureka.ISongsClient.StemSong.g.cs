#nullable enable

namespace Mureka
{
    public partial interface ISongsClient
    {
        /// <summary>
        /// Separate a song into stems
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mureka.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mureka.StemSongResponse> StemSongAsync(

            global::Mureka.StemSongRequest request,
            global::Mureka.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Separate a song into stems
        /// </summary>
        /// <param name="url"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mureka.StemSongResponse> StemSongAsync(
            string url,
            global::Mureka.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}