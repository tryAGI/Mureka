#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DescribeSongResponse : global::System.IEquatable<DescribeSongResponse>
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
        public global::Mureka.DescribeSongResponseVariant2? DescribeSongResponseVariant2 { get; init; }
#else
        public global::Mureka.DescribeSongResponseVariant2? DescribeSongResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DescribeSongResponseVariant2))]
#endif
        public bool IsDescribeSongResponseVariant2 => DescribeSongResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DescribeSongResponse(global::Mureka.BaseResponse value) => new DescribeSongResponse((global::Mureka.BaseResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mureka.BaseResponse?(DescribeSongResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public DescribeSongResponse(global::Mureka.BaseResponse? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DescribeSongResponse(global::Mureka.DescribeSongResponseVariant2 value) => new DescribeSongResponse((global::Mureka.DescribeSongResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mureka.DescribeSongResponseVariant2?(DescribeSongResponse @this) => @this.DescribeSongResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DescribeSongResponse(global::Mureka.DescribeSongResponseVariant2? value)
        {
            DescribeSongResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DescribeSongResponse(
            global::Mureka.BaseResponse? @base,
            global::Mureka.DescribeSongResponseVariant2? describeSongResponseVariant2
            )
        {
            Base = @base;
            DescribeSongResponseVariant2 = describeSongResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DescribeSongResponseVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            DescribeSongResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsDescribeSongResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mureka.BaseResponse?, TResult>? @base = null,
            global::System.Func<global::Mureka.DescribeSongResponseVariant2?, TResult>? describeSongResponseVariant2 = null,
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
            else if (IsDescribeSongResponseVariant2 && describeSongResponseVariant2 != null)
            {
                return describeSongResponseVariant2(DescribeSongResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mureka.BaseResponse?>? @base = null,
            global::System.Action<global::Mureka.DescribeSongResponseVariant2?>? describeSongResponseVariant2 = null,
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
            else if (IsDescribeSongResponseVariant2)
            {
                describeSongResponseVariant2?.Invoke(DescribeSongResponseVariant2!);
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
                DescribeSongResponseVariant2,
                typeof(global::Mureka.DescribeSongResponseVariant2),
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
        public bool Equals(DescribeSongResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mureka.BaseResponse?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Mureka.DescribeSongResponseVariant2?>.Default.Equals(DescribeSongResponseVariant2, other.DescribeSongResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DescribeSongResponse obj1, DescribeSongResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DescribeSongResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DescribeSongResponse obj1, DescribeSongResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DescribeSongResponse o && Equals(o);
        }
    }
}
