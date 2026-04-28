#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct StemSongResponse : global::System.IEquatable<StemSongResponse>
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
        public global::Mureka.StemSongResponseVariant2? StemSongResponseVariant2 { get; init; }
#else
        public global::Mureka.StemSongResponseVariant2? StemSongResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StemSongResponseVariant2))]
#endif
        public bool IsStemSongResponseVariant2 => StemSongResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StemSongResponse(global::Mureka.BaseResponse value) => new StemSongResponse((global::Mureka.BaseResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mureka.BaseResponse?(StemSongResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public StemSongResponse(global::Mureka.BaseResponse? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StemSongResponse(global::Mureka.StemSongResponseVariant2 value) => new StemSongResponse((global::Mureka.StemSongResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mureka.StemSongResponseVariant2?(StemSongResponse @this) => @this.StemSongResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StemSongResponse(global::Mureka.StemSongResponseVariant2? value)
        {
            StemSongResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StemSongResponse(
            global::Mureka.BaseResponse? @base,
            global::Mureka.StemSongResponseVariant2? stemSongResponseVariant2
            )
        {
            Base = @base;
            StemSongResponseVariant2 = stemSongResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StemSongResponseVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            StemSongResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsStemSongResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mureka.BaseResponse?, TResult>? @base = null,
            global::System.Func<global::Mureka.StemSongResponseVariant2?, TResult>? stemSongResponseVariant2 = null,
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
            else if (IsStemSongResponseVariant2 && stemSongResponseVariant2 != null)
            {
                return stemSongResponseVariant2(StemSongResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mureka.BaseResponse?>? @base = null,
            global::System.Action<global::Mureka.StemSongResponseVariant2?>? stemSongResponseVariant2 = null,
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
            else if (IsStemSongResponseVariant2)
            {
                stemSongResponseVariant2?.Invoke(StemSongResponseVariant2!);
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
                StemSongResponseVariant2,
                typeof(global::Mureka.StemSongResponseVariant2),
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
        public bool Equals(StemSongResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mureka.BaseResponse?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Mureka.StemSongResponseVariant2?>.Default.Equals(StemSongResponseVariant2, other.StemSongResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StemSongResponse obj1, StemSongResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StemSongResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StemSongResponse obj1, StemSongResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StemSongResponse o && Equals(o);
        }
    }
}
