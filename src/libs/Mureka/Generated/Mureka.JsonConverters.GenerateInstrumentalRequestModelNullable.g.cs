#nullable enable

namespace Mureka.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerateInstrumentalRequestModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mureka.GenerateInstrumentalRequestModel?>
    {
        /// <inheritdoc />
        public override global::Mureka.GenerateInstrumentalRequestModel? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Mureka.GenerateInstrumentalRequestModelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mureka.GenerateInstrumentalRequestModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mureka.GenerateInstrumentalRequestModel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mureka.GenerateInstrumentalRequestModel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Mureka.GenerateInstrumentalRequestModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
