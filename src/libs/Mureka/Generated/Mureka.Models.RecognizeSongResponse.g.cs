#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RecognizeSongResponse : global::System.IEquatable<RecognizeSongResponse>
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
        public global::Mureka.RecognizeSongResponseVariant2? RecognizeSongResponseVariant2 { get; init; }
#else
        public global::Mureka.RecognizeSongResponseVariant2? RecognizeSongResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RecognizeSongResponseVariant2))]
#endif
        public bool IsRecognizeSongResponseVariant2 => RecognizeSongResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecognizeSongResponse(global::Mureka.BaseResponse value) => new RecognizeSongResponse((global::Mureka.BaseResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mureka.BaseResponse?(RecognizeSongResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public RecognizeSongResponse(global::Mureka.BaseResponse? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecognizeSongResponse(global::Mureka.RecognizeSongResponseVariant2 value) => new RecognizeSongResponse((global::Mureka.RecognizeSongResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mureka.RecognizeSongResponseVariant2?(RecognizeSongResponse @this) => @this.RecognizeSongResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RecognizeSongResponse(global::Mureka.RecognizeSongResponseVariant2? value)
        {
            RecognizeSongResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RecognizeSongResponse(
            global::Mureka.BaseResponse? @base,
            global::Mureka.RecognizeSongResponseVariant2? recognizeSongResponseVariant2
            )
        {
            Base = @base;
            RecognizeSongResponseVariant2 = recognizeSongResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RecognizeSongResponseVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            RecognizeSongResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsRecognizeSongResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mureka.BaseResponse?, TResult>? @base = null,
            global::System.Func<global::Mureka.RecognizeSongResponseVariant2?, TResult>? recognizeSongResponseVariant2 = null,
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
            else if (IsRecognizeSongResponseVariant2 && recognizeSongResponseVariant2 != null)
            {
                return recognizeSongResponseVariant2(RecognizeSongResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mureka.BaseResponse?>? @base = null,
            global::System.Action<global::Mureka.RecognizeSongResponseVariant2?>? recognizeSongResponseVariant2 = null,
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
            else if (IsRecognizeSongResponseVariant2)
            {
                recognizeSongResponseVariant2?.Invoke(RecognizeSongResponseVariant2!);
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
                RecognizeSongResponseVariant2,
                typeof(global::Mureka.RecognizeSongResponseVariant2),
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
        public bool Equals(RecognizeSongResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mureka.BaseResponse?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Mureka.RecognizeSongResponseVariant2?>.Default.Equals(RecognizeSongResponseVariant2, other.RecognizeSongResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RecognizeSongResponse obj1, RecognizeSongResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RecognizeSongResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RecognizeSongResponse obj1, RecognizeSongResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RecognizeSongResponse o && Equals(o);
        }
    }
}
