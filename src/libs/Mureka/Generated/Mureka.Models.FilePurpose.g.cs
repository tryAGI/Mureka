
#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilePurpose
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Instrumental,
        /// <summary>
        /// 
        /// </summary>
        Melody,
        /// <summary>
        /// 
        /// </summary>
        Reference,
        /// <summary>
        /// 
        /// </summary>
        Vocal,
        /// <summary>
        /// 
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilePurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilePurpose value)
        {
            return value switch
            {
                FilePurpose.Audio => "audio",
                FilePurpose.Instrumental => "instrumental",
                FilePurpose.Melody => "melody",
                FilePurpose.Reference => "reference",
                FilePurpose.Vocal => "vocal",
                FilePurpose.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilePurpose? ToEnum(string value)
        {
            return value switch
            {
                "audio" => FilePurpose.Audio,
                "instrumental" => FilePurpose.Instrumental,
                "melody" => FilePurpose.Melody,
                "reference" => FilePurpose.Reference,
                "vocal" => FilePurpose.Vocal,
                "voice" => FilePurpose.Voice,
                _ => null,
            };
        }
    }
}