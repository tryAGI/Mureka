#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FileUploadResponse : global::System.IEquatable<FileUploadResponse>
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
        public global::Mureka.FileUploadResponseVariant2? FileUploadResponseVariant2 { get; init; }
#else
        public global::Mureka.FileUploadResponseVariant2? FileUploadResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileUploadResponseVariant2))]
#endif
        public bool IsFileUploadResponseVariant2 => FileUploadResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileUploadResponse(global::Mureka.BaseResponse value) => new FileUploadResponse((global::Mureka.BaseResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mureka.BaseResponse?(FileUploadResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public FileUploadResponse(global::Mureka.BaseResponse? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileUploadResponse(global::Mureka.FileUploadResponseVariant2 value) => new FileUploadResponse((global::Mureka.FileUploadResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mureka.FileUploadResponseVariant2?(FileUploadResponse @this) => @this.FileUploadResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public FileUploadResponse(global::Mureka.FileUploadResponseVariant2? value)
        {
            FileUploadResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FileUploadResponse(
            global::Mureka.BaseResponse? @base,
            global::Mureka.FileUploadResponseVariant2? fileUploadResponseVariant2
            )
        {
            Base = @base;
            FileUploadResponseVariant2 = fileUploadResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FileUploadResponseVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            FileUploadResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsFileUploadResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mureka.BaseResponse?, TResult>? @base = null,
            global::System.Func<global::Mureka.FileUploadResponseVariant2?, TResult>? fileUploadResponseVariant2 = null,
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
            else if (IsFileUploadResponseVariant2 && fileUploadResponseVariant2 != null)
            {
                return fileUploadResponseVariant2(FileUploadResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mureka.BaseResponse?>? @base = null,
            global::System.Action<global::Mureka.FileUploadResponseVariant2?>? fileUploadResponseVariant2 = null,
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
            else if (IsFileUploadResponseVariant2)
            {
                fileUploadResponseVariant2?.Invoke(FileUploadResponseVariant2!);
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
                FileUploadResponseVariant2,
                typeof(global::Mureka.FileUploadResponseVariant2),
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
        public bool Equals(FileUploadResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mureka.BaseResponse?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Mureka.FileUploadResponseVariant2?>.Default.Equals(FileUploadResponseVariant2, other.FileUploadResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FileUploadResponse obj1, FileUploadResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FileUploadResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FileUploadResponse obj1, FileUploadResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FileUploadResponse o && Equals(o);
        }
    }
}
