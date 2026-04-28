
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateInstrumentalRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Mureka6,
        /// <summary>
        /// 
        /// </summary>
        Mureka75,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateInstrumentalRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateInstrumentalRequestModel value)
        {
            return value switch
            {
                GenerateInstrumentalRequestModel.Auto => "auto",
                GenerateInstrumentalRequestModel.Mureka6 => "mureka-6",
                GenerateInstrumentalRequestModel.Mureka75 => "mureka-7.5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateInstrumentalRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GenerateInstrumentalRequestModel.Auto,
                "mureka-6" => GenerateInstrumentalRequestModel.Mureka6,
                "mureka-7.5" => GenerateInstrumentalRequestModel.Mureka75,
                _ => null,
            };
        }
    }
}