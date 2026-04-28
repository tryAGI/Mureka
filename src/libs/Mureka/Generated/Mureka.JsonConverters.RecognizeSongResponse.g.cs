#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mureka.JsonConverters
{
    /// <inheritdoc />
    public class RecognizeSongResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mureka.RecognizeSongResponse>
    {
        /// <inheritdoc />
        public override global::Mureka.RecognizeSongResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("code")) __score0++;
            if (__jsonProps.Contains("code_msg")) __score0++;
            if (__jsonProps.Contains("message")) __score0++;
            if (__jsonProps.Contains("trace_id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("resp_data")) __score1++;
            if (__jsonProps.Contains("resp_data.duration")) __score1++;
            if (__jsonProps.Contains("resp_data.lyrics_sections")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Mureka.BaseResponse? @base = default;
            global::Mureka.RecognizeSongResponseVariant2? recognizeSongResponseVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mureka.BaseResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mureka.BaseResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mureka.BaseResponse).Name}");
                        @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mureka.RecognizeSongResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mureka.RecognizeSongResponseVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mureka.RecognizeSongResponseVariant2).Name}");
                        recognizeSongResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && recognizeSongResponseVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mureka.BaseResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mureka.BaseResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mureka.BaseResponse).Name}");
                    @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mureka.RecognizeSongResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mureka.RecognizeSongResponseVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mureka.RecognizeSongResponseVariant2).Name}");
                    recognizeSongResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Mureka.RecognizeSongResponse(
                @base,

                recognizeSongResponseVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mureka.RecognizeSongResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mureka.BaseResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mureka.BaseResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mureka.BaseResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base!, typeInfo);
            }
            else if (value.IsRecognizeSongResponseVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mureka.RecognizeSongResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mureka.RecognizeSongResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mureka.RecognizeSongResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RecognizeSongResponseVariant2!, typeInfo);
            }
        }
    }
}