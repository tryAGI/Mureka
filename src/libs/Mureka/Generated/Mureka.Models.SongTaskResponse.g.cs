#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SongTaskResponse : global::System.IEquatable<SongTaskResponse>
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
        public global::Mureka.SongTaskResponseVariant2? SongTaskResponseVariant2 { get; init; }
#else
        public global::Mureka.SongTaskResponseVariant2? SongTaskResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SongTaskResponseVariant2))]
#endif
        public bool IsSongTaskResponseVariant2 => SongTaskResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SongTaskResponse(global::Mureka.BaseResponse value) => new SongTaskResponse((global::Mureka.BaseResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mureka.BaseResponse?(SongTaskResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SongTaskResponse(global::Mureka.BaseResponse? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SongTaskResponse(global::Mureka.SongTaskResponseVariant2 value) => new SongTaskResponse((global::Mureka.SongTaskResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mureka.SongTaskResponseVariant2?(SongTaskResponse @this) => @this.SongTaskResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SongTaskResponse(global::Mureka.SongTaskResponseVariant2? value)
        {
            SongTaskResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SongTaskResponse(
            global::Mureka.BaseResponse? @base,
            global::Mureka.SongTaskResponseVariant2? songTaskResponseVariant2
            )
        {
            Base = @base;
            SongTaskResponseVariant2 = songTaskResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SongTaskResponseVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SongTaskResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSongTaskResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mureka.BaseResponse?, TResult>? @base = null,
            global::System.Func<global::Mureka.SongTaskResponseVariant2?, TResult>? songTaskResponseVariant2 = null,
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
            else if (IsSongTaskResponseVariant2 && songTaskResponseVariant2 != null)
            {
                return songTaskResponseVariant2(SongTaskResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mureka.BaseResponse?>? @base = null,
            global::System.Action<global::Mureka.SongTaskResponseVariant2?>? songTaskResponseVariant2 = null,
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
            else if (IsSongTaskResponseVariant2)
            {
                songTaskResponseVariant2?.Invoke(SongTaskResponseVariant2!);
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
                SongTaskResponseVariant2,
                typeof(global::Mureka.SongTaskResponseVariant2),
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
        public bool Equals(SongTaskResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mureka.BaseResponse?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Mureka.SongTaskResponseVariant2?>.Default.Equals(SongTaskResponseVariant2, other.SongTaskResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SongTaskResponse obj1, SongTaskResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SongTaskResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SongTaskResponse obj1, SongTaskResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SongTaskResponse o && Equals(o);
        }
    }
}
