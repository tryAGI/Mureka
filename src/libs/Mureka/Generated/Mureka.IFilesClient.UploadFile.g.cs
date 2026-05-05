#nullable enable

namespace Mureka
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload an audio or reference file
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mureka.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mureka.FileUploadResponse> UploadFileAsync(

            global::Mureka.FileUploadRequest request,
            global::Mureka.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload an audio or reference file
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mureka.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mureka.AutoSDKHttpResponse<global::Mureka.FileUploadResponse>> UploadFileAsResponseAsync(

            global::Mureka.FileUploadRequest request,
            global::Mureka.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload an audio or reference file
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="purpose"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mureka.FileUploadResponse> UploadFileAsync(
            byte[] file,
            string filename,
            global::Mureka.FilePurpose purpose,
            global::Mureka.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload an audio or reference file
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="purpose"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mureka.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mureka.FileUploadResponse> UploadFileAsync(
            global::System.IO.Stream file,
            string filename,
            global::Mureka.FilePurpose purpose,
            global::Mureka.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload an audio or reference file
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="purpose"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mureka.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mureka.AutoSDKHttpResponse<global::Mureka.FileUploadResponse>> UploadFileAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::Mureka.FilePurpose purpose,
            global::Mureka.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}