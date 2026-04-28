
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Mureka.JsonConverters.FilePurposeJsonConverter),

            typeof(global::Mureka.JsonConverters.FilePurposeNullableJsonConverter),

            typeof(global::Mureka.JsonConverters.GenerateSongRequestModelJsonConverter),

            typeof(global::Mureka.JsonConverters.GenerateSongRequestModelNullableJsonConverter),

            typeof(global::Mureka.JsonConverters.GenerateInstrumentalRequestModelJsonConverter),

            typeof(global::Mureka.JsonConverters.GenerateInstrumentalRequestModelNullableJsonConverter),

            typeof(global::Mureka.JsonConverters.FileUploadResponseJsonConverter),

            typeof(global::Mureka.JsonConverters.GenerateLyricsResponseJsonConverter),

            typeof(global::Mureka.JsonConverters.ExtendLyricsResponseJsonConverter),

            typeof(global::Mureka.JsonConverters.TaskResponseJsonConverter),

            typeof(global::Mureka.JsonConverters.SongTaskResponseJsonConverter),

            typeof(global::Mureka.JsonConverters.RecognizeSongResponseJsonConverter),

            typeof(global::Mureka.JsonConverters.DescribeSongResponseJsonConverter),

            typeof(global::Mureka.JsonConverters.StemSongResponseJsonConverter),

            typeof(global::Mureka.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.FilePurpose), TypeInfoPropertyName = "FilePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.FileUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.FileUploadData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.FileUploadResponse), TypeInfoPropertyName = "FileUploadResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.BaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.FileUploadResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.GenerateLyricsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.GenerateLyricsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.GenerateLyricsResponse), TypeInfoPropertyName = "GenerateLyricsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.GenerateLyricsResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.ExtendLyricsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.ExtendLyricsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.ExtendLyricsResponse), TypeInfoPropertyName = "ExtendLyricsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.ExtendLyricsResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.GenerateSongRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.GenerateSongRequestModel), TypeInfoPropertyName = "GenerateSongRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.GenerateInstrumentalRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.GenerateInstrumentalRequestModel), TypeInfoPropertyName = "GenerateInstrumentalRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.ExtendSongRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.RecognizeSongRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.DescribeSongRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.StemSongRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.TaskData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mureka.SongChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.SongChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.TaskResponse), TypeInfoPropertyName = "TaskResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.TaskResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.SongTaskResponse), TypeInfoPropertyName = "SongTaskResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.SongTaskResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mureka.LyricsSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.LyricsSection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mureka.LyricsLine>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.LyricsLine))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mureka.LyricsWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.LyricsWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.RecognizeSongData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.RecognizeSongResponse), TypeInfoPropertyName = "RecognizeSongResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.RecognizeSongResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.DescribeSongData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.DescribeSongResponse), TypeInfoPropertyName = "DescribeSongResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.DescribeSongResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.StemSongData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.StemSongResponse), TypeInfoPropertyName = "StemSongResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mureka.StemSongResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mureka.SongChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mureka.LyricsSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mureka.LyricsLine>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mureka.LyricsWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}