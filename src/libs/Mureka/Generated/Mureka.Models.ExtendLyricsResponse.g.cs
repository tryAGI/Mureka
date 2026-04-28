#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ExtendLyricsResponse : global::System.IEquatable<ExtendLyricsResponse>
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
        public global::Mureka.ExtendLyricsResponseVariant2? ExtendLyricsResponseVariant2 { get; init; }
#else
        public global::Mureka.ExtendLyricsResponseVariant2? ExtendLyricsResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExtendLyricsResponseVariant2))]
#endif
        public bool IsExtendLyricsResponseVariant2 => ExtendLyricsResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExtendLyricsResponse(global::Mureka.BaseResponse value) => new ExtendLyricsResponse((global::Mureka.BaseResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mureka.BaseResponse?(ExtendLyricsResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ExtendLyricsResponse(global::Mureka.BaseResponse? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExtendLyricsResponse(global::Mureka.ExtendLyricsResponseVariant2 value) => new ExtendLyricsResponse((global::Mureka.ExtendLyricsResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mureka.ExtendLyricsResponseVariant2?(ExtendLyricsResponse @this) => @this.ExtendLyricsResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ExtendLyricsResponse(global::Mureka.ExtendLyricsResponseVariant2? value)
        {
            ExtendLyricsResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExtendLyricsResponse(
            global::Mureka.BaseResponse? @base,
            global::Mureka.ExtendLyricsResponseVariant2? extendLyricsResponseVariant2
            )
        {
            Base = @base;
            ExtendLyricsResponseVariant2 = extendLyricsResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ExtendLyricsResponseVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ExtendLyricsResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsExtendLyricsResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mureka.BaseResponse?, TResult>? @base = null,
            global::System.Func<global::Mureka.ExtendLyricsResponseVariant2?, TResult>? extendLyricsResponseVariant2 = null,
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
            else if (IsExtendLyricsResponseVariant2 && extendLyricsResponseVariant2 != null)
            {
                return extendLyricsResponseVariant2(ExtendLyricsResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mureka.BaseResponse?>? @base = null,
            global::System.Action<global::Mureka.ExtendLyricsResponseVariant2?>? extendLyricsResponseVariant2 = null,
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
            else if (IsExtendLyricsResponseVariant2)
            {
                extendLyricsResponseVariant2?.Invoke(ExtendLyricsResponseVariant2!);
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
                ExtendLyricsResponseVariant2,
                typeof(global::Mureka.ExtendLyricsResponseVariant2),
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
        public bool Equals(ExtendLyricsResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mureka.BaseResponse?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Mureka.ExtendLyricsResponseVariant2?>.Default.Equals(ExtendLyricsResponseVariant2, other.ExtendLyricsResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ExtendLyricsResponse obj1, ExtendLyricsResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExtendLyricsResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ExtendLyricsResponse obj1, ExtendLyricsResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExtendLyricsResponse o && Equals(o);
        }
    }
}
