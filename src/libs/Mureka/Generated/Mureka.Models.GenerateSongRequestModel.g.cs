
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateSongRequestModel
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
        /// <summary>
        /// 
        /// </summary>
        MurekaO1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateSongRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateSongRequestModel value)
        {
            return value switch
            {
                GenerateSongRequestModel.Auto => "auto",
                GenerateSongRequestModel.Mureka6 => "mureka-6",
                GenerateSongRequestModel.Mureka75 => "mureka-7.5",
                GenerateSongRequestModel.MurekaO1 => "mureka-o1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateSongRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GenerateSongRequestModel.Auto,
                "mureka-6" => GenerateSongRequestModel.Mureka6,
                "mureka-7.5" => GenerateSongRequestModel.Mureka75,
                "mureka-o1" => GenerateSongRequestModel.MurekaO1,
                _ => null,
            };
        }
    }
}