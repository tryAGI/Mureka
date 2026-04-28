#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GenerateLyricsResponse : global::System.IEquatable<GenerateLyricsResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mureka.BaseResponse? Base { get; init; }
#else
        public global::Mureka.BaseResponse? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mureka.GenerateLyricsResponseVariant2? GenerateLyricsResponseVariant2 { get; init; }
#else
        public global::Mureka.GenerateLyricsResponseVariant2? GenerateLyricsResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerateLyricsResponseVariant2))]
#endif
        public bool IsGenerateLyricsResponseVariant2 => GenerateLyricsResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateLyricsResponse(global::Mureka.BaseResponse value) => new GenerateLyricsResponse((global::Mureka.BaseResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mureka.BaseResponse?(GenerateLyricsResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public GenerateLyricsResponse(global::Mureka.BaseResponse? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateLyricsResponse(global::Mureka.GenerateLyricsResponseVariant2 value) => new GenerateLyricsResponse((global::Mureka.GenerateLyricsResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mureka.GenerateLyricsResponseVariant2?(GenerateLyricsResponse @this) => @this.GenerateLyricsResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GenerateLyricsResponse(global::Mureka.GenerateLyricsResponseVariant2? value)
        {
            GenerateLyricsResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GenerateLyricsResponse(
            global::Mureka.BaseResponse? @base,
            global::Mureka.GenerateLyricsResponseVariant2? generateLyricsResponseVariant2
            )
        {
            Base = @base;
            GenerateLyricsResponseVariant2 = generateLyricsResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GenerateLyricsResponseVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            GenerateLyricsResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsGenerateLyricsResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mureka.BaseResponse?, TResult>? @base = null,
            global::System.Func<global::Mureka.GenerateLyricsResponseVariant2?, TResult>? generateLyricsResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsGenerateLyricsResponseVariant2 && generateLyricsResponseVariant2 != null)
            {
                return generateLyricsResponseVariant2(GenerateLyricsResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mureka.BaseResponse?>? @base = null,
            global::System.Action<global::Mureka.GenerateLyricsResponseVariant2?>? generateLyricsResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsGenerateLyricsResponseVariant2)
            {
                generateLyricsResponseVariant2?.Invoke(GenerateLyricsResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Mureka.BaseResponse),
                GenerateLyricsResponseVariant2,
                typeof(global::Mureka.GenerateLyricsResponseVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(GenerateLyricsResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mureka.BaseResponse?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Mureka.GenerateLyricsResponseVariant2?>.Default.Equals(GenerateLyricsResponseVariant2, other.GenerateLyricsResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GenerateLyricsResponse obj1, GenerateLyricsResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GenerateLyricsResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GenerateLyricsResponse obj1, GenerateLyricsResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GenerateLyricsResponse o && Equals(o);
        }
    }
}
