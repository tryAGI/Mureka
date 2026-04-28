#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mureka
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TaskResponse : global::System.IEquatable<TaskResponse>
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
        public global::Mureka.TaskResponseVariant2? TaskResponseVariant2 { get; init; }
#else
        public global::Mureka.TaskResponseVariant2? TaskResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TaskResponseVariant2))]
#endif
        public bool IsTaskResponseVariant2 => TaskResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TaskResponse(global::Mureka.BaseResponse value) => new TaskResponse((global::Mureka.BaseResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mureka.BaseResponse?(TaskResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public TaskResponse(global::Mureka.BaseResponse? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TaskResponse(global::Mureka.TaskResponseVariant2 value) => new TaskResponse((global::Mureka.TaskResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mureka.TaskResponseVariant2?(TaskResponse @this) => @this.TaskResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TaskResponse(global::Mureka.TaskResponseVariant2? value)
        {
            TaskResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TaskResponse(
            global::Mureka.BaseResponse? @base,
            global::Mureka.TaskResponseVariant2? taskResponseVariant2
            )
        {
            Base = @base;
            TaskResponseVariant2 = taskResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TaskResponseVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            TaskResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsTaskResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mureka.BaseResponse?, TResult>? @base = null,
            global::System.Func<global::Mureka.TaskResponseVariant2?, TResult>? taskResponseVariant2 = null,
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
            else if (IsTaskResponseVariant2 && taskResponseVariant2 != null)
            {
                return taskResponseVariant2(TaskResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mureka.BaseResponse?>? @base = null,
            global::System.Action<global::Mureka.TaskResponseVariant2?>? taskResponseVariant2 = null,
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
            else if (IsTaskResponseVariant2)
            {
                taskResponseVariant2?.Invoke(TaskResponseVariant2!);
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
                TaskResponseVariant2,
                typeof(global::Mureka.TaskResponseVariant2),
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
        public bool Equals(TaskResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mureka.BaseResponse?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Mureka.TaskResponseVariant2?>.Default.Equals(TaskResponseVariant2, other.TaskResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TaskResponse obj1, TaskResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TaskResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TaskResponse obj1, TaskResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TaskResponse o && Equals(o);
        }
    }
}
