// Namespace: 
internal class <Module>
{}

// Namespace: AOT
public class MonoPInvokeCallbackAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75BEDD40
	public Void .ctor(Type type) { }

}

// Namespace: UnityEngineInternal
internal enum LightmapType
{
	// Fields
	public Int32 value__; // 0x10
	public const LightmapType NoLightmap = 4294967295;
	public const LightmapType StaticLightmap = 0;
	public const LightmapType DynamicLightmap = 1;
}

// Namespace: UnityEngineInternal
public struct MathfInternal
{
	// Fields
	public static Single FloatMinNormal; // 0x0
	public static Single FloatMinDenormal; // 0x4
	public static Boolean IsFlushToZeroEnabled; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75C48B2C
	private static Void .cctor() { }

}

// Namespace: UnityEngineInternal
public enum TypeInferenceRules
{
	// Fields
	public Int32 value__; // 0x10
	public const TypeInferenceRules TypeReferencedByFirstArgument = 0;
	public const TypeInferenceRules TypeReferencedBySecondArgument = 1;
	public const TypeInferenceRules ArrayOfTypeReferencedByFirstArgument = 2;
	public const TypeInferenceRules TypeOfFirstArgument = 3;
}

// Namespace: UnityEngineInternal
public class TypeInferenceRuleAttribute
{
	// Fields
	private readonly String _rule; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C48B60
	public Void .ctor(TypeInferenceRules rule) { }

	// RVA: 0xFFFFFFFF75C48C24
	public Void .ctor(String rule) { }

	// RVA: 0xFFFFFFFF75C48C68
	public override String ToString() { }

}

// Namespace: UnityEngineInternal
public class GenericStack
{
	// Methods

	// RVA: 0xFFFFFFFF723CDF38
	public Void .ctor() { }

}

// Namespace: Unity.Profiling
public struct ProfilerMarker
{
	// Fields
	internal readonly IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114ABE4
	public Void .ctor(String name) { }

	// RVA: 0xFFFFFFFF7114AC3C
	public AutoScope Auto() { }

	// RVA: 0xFFFFFFFF75BEE748
	internal static IntPtr Internal_Create(String name, UInt16 flags) { }

	// RVA: 0xFFFFFFFF75BEE7E0
	internal static Void Internal_Begin(IntPtr markerPtr) { }

	// RVA: 0xFFFFFFFF75BEE820
	internal static Void Internal_End(IntPtr markerPtr) { }

}

// Namespace: 
public struct AutoScope
{
	// Fields
	internal readonly IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114AC84
	internal Void .ctor(IntPtr markerPtr) { }

	// RVA: 0xFFFFFFFF7114ACC8
	public Void Dispose() { }

}

// Namespace: Unity.Jobs
public interface IJobParallelFor
{
	// Methods

	// RVA: -1
	public abstract Void Execute(Int32 index) { }

}

// Namespace: Unity.Jobs
public static class IJobParallelForExtensions
{
	// Methods

	// RVA: -1
	public static JobHandle Schedule(T jobData, Int32 arrayLength, Int32 innerloopBatchCount, JobHandle dependsOn) { }

}

// Namespace: 
internal struct ParallelForJobStruct<T0>
{
	// Fields
	public static IntPtr jobReflectionData; // 0x0

	// Methods

	// RVA: -1
	public static IntPtr Initialize() { }

	// RVA: -1
	public static Void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, Int32 jobIndex) { }

}

// Namespace: 
public sealed class ExecuteJobFunction
{
	// Methods

	// RVA: -1
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: -1
	public virtual Void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, Int32 jobIndex) { }

	// RVA: -1
	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, Int32 jobIndex, AsyncCallback callback, Object object) { }

	// RVA: -1
	public virtual Void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }

}

// Namespace: Unity.Jobs
public struct JobHandle
{
	// Fields
	internal IntPtr jobGroup; // 0x10
	internal Int32 version; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF7114AB68
	public Void Complete() { }

	// RVA: 0xFFFFFFFF723B4D70
	public static Void ScheduleBatchedJobs() { }

	// RVA: 0xFFFFFFFF75BEE1F4
	private static Void ScheduleBatchedJobsAndComplete(ref JobHandle job) { }

	// RVA: 0xFFFFFFFF75BEE234
	public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1) { }

	// RVA: 0xFFFFFFFF75BEE294
	private static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1) { }

	// RVA: 0xFFFFFFFF75BEE2FC
	private static Void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret) { }

}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public sealed class JobProducerTypeAttribute
{
	// Fields
	private readonly Type <ProducerType>k__BackingField; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75BEE354
	public Void .ctor(Type producerType) { }

}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public struct JobRanges
{
	// Fields
	internal Int32 BatchSize; // 0x10
	internal Int32 NumJobs; // 0x14
	public Int32 TotalIterationCount; // 0x18
	internal Int32 NumPhases; // 0x1C
	internal IntPtr StartEndIndex; // 0x20
	internal IntPtr PhaseData; // 0x28
}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public enum ScheduleMode
{
	// Fields
	public Int32 value__; // 0x10
	public const ScheduleMode Run = 0;
	public const ScheduleMode Batched = 1;
}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public enum JobType
{
	// Fields
	public Int32 value__; // 0x10
	public const JobType Single = 0;
	public const JobType ParallelFor = 1;
}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public static class JobsUtility
{
	// Properties
	public static Int32 JobWorkerMaximumCount { get; }
	public static Int32 JobWorkerCount { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF723B4DAC
	public static Void GetJobRange(ref JobRanges ranges, Int32 jobIndex, out Int32 beginIndex, out Int32 endIndex) { }

	// RVA: 0xFFFFFFFF723B4DD0
	public static Boolean GetWorkStealingRange(ref JobRanges ranges, Int32 jobIndex, out Int32 beginIndex, out Int32 endIndex) { }

	// RVA: 0xFFFFFFFF723B4E34
	public static JobHandle ScheduleParallelFor(ref JobScheduleParameters parameters, Int32 arrayLength, Int32 innerloopBatchCount) { }

	// RVA: 0xFFFFFFFF723B4EA0
	public static JobHandle ScheduleParallelForTransform(ref JobScheduleParameters parameters, IntPtr transfromAccesssArray) { }

	// RVA: 0xFFFFFFFF75BEE458
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, JobType jobType, Object managedJobFunction0, Object managedJobFunction1, Object managedJobFunction2) { }

	// RVA: 0xFFFFFFFF75BEE4D8
	public static IntPtr CreateJobReflectionData(Type type, JobType jobType, Object managedJobFunction0, Object managedJobFunction1, Object managedJobFunction2) { }

	// RVA: 0xFFFFFFFF75BEE550
	private static Int32 GetJobQueueWorkerThreadCount() { }

	// RVA: 0xFFFFFFFF75BEE584
	private static Void SetJobQueueMaximumActiveThreadCount(Int32 count) { }

	// RVA: 0xFFFFFFFF75BEE5C4
	public static Int32 get_JobWorkerMaximumCount() { }

	// RVA: 0xFFFFFFFF723B4F04
	public static Int32 get_JobWorkerCount() { }

	// RVA: 0xFFFFFFFF75BEE5FC
	public static Void set_JobWorkerCount(Int32 value) { }

	// RVA: 0xFFFFFFFF75BEE398
	private static Void ScheduleParallelFor_Injected(ref JobScheduleParameters parameters, Int32 arrayLength, Int32 innerloopBatchCount, out JobHandle ret) { }

	// RVA: 0xFFFFFFFF75BEE400
	private static Void ScheduleParallelForTransform_Injected(ref JobScheduleParameters parameters, IntPtr transfromAccesssArray, out JobHandle ret) { }

}

// Namespace: 
public struct JobScheduleParameters
{
	// Fields
	public JobHandle Dependency; // 0x10
	public Int32 ScheduleMode; // 0x20
	public IntPtr ReflectionData; // 0x28
	public IntPtr JobDataPtr; // 0x30

	// Methods

	// RVA: 0xFFFFFFFF7114ABD4
	public Void .ctor(Void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode) { }

}

// Namespace: Unity.Collections
public sealed class ReadOnlyAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75BEE1EC
	public Void .ctor() { }

}

// Namespace: Unity.Collections
public sealed class WriteOnlyAttribute
{}

// Namespace: Unity.Collections
public sealed class DeallocateOnJobCompletionAttribute
{}

// Namespace: Unity.Collections
public sealed class NativeFixedLengthAttribute
{}

// Namespace: Unity.Collections
public sealed class NativeMatchesParallelForLengthAttribute
{}

// Namespace: Unity.Collections
public sealed class NativeDisableParallelForRestrictionAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75BEE198
	public Void .ctor() { }

}

// Namespace: Unity.Collections
public enum Allocator
{
	// Fields
	public Int32 value__; // 0x10
	public const Allocator Invalid = 0;
	public const Allocator None = 1;
	public const Allocator Temp = 2;
	public const Allocator TempJob = 3;
	public const Allocator Persistent = 4;
	public const Allocator AudioKernel = 5;
}

// Namespace: Unity.Collections
public static class NativeLeakDetection
{
	// Fields
	private static Int32 s_NativeLeakDetectionMode; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75BEE1A0
	private static Void Initialize() { }

}

// Namespace: Unity.Collections
public enum NativeArrayOptions
{
	// Fields
	public Int32 value__; // 0x10
	public const NativeArrayOptions UninitializedMemory = 0;
	public const NativeArrayOptions ClearMemory = 1;
}

// Namespace: Unity.Collections
public struct NativeArray<T0>
{
	// Fields
	internal Void* m_Buffer; // 0x0
	internal Int32 m_Length; // 0x0
	internal Allocator m_AllocatorLabel; // 0x0

	// Properties
	public Int32 Length { get; }
	public T Item { get; set; }
	public Boolean IsCreated { get; }

	// Methods

	// RVA: -1
	public Void .ctor(Int32 length, Allocator allocator, NativeArrayOptions options) { }

	// RVA: -1
	private static Void Allocate(Int32 length, Allocator allocator, out NativeArray<T0> array) { }

	// RVA: -1
	public Int32 get_Length() { }

	// RVA: -1
	public T get_Item(Int32 index) { }

	// RVA: -1
	public Void set_Item(Int32 index, T value) { }

	// RVA: -1
	public Boolean get_IsCreated() { }

	// RVA: -1
	private Void Deallocate() { }

	// RVA: -1
	public Void Dispose() { }

	// RVA: -1
	public Enumerator GetEnumerator() { }

	// RVA: -1
	private IEnumerator<T0> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: -1
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: -1
	public Boolean Equals(NativeArray<T0> other) { }

	// RVA: -1
	public override Boolean Equals(Object obj) { }

	// RVA: -1
	public override Int32 GetHashCode() { }

	// RVA: -1
	public static Void Copy(NativeArray<T0> src, NativeArray<T0> dst, Int32 length) { }

	// RVA: -1
	public static Void Copy(NativeArray<T0> src, Int32 srcIndex, NativeArray<T0> dst, Int32 dstIndex, Int32 length) { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private NativeArray<T0> m_Array; // 0x0
	private Int32 m_Index; // 0x0

	// Properties
	public T Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1
	public Void .ctor(ref NativeArray<T0> array) { }

	// RVA: -1
	public Void Dispose() { }

	// RVA: -1
	public Boolean MoveNext() { }

	// RVA: -1
	public Void Reset() { }

	// RVA: -1
	public T get_Current() { }

	// RVA: -1
	private Object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: Unity.Collections
internal sealed class NativeArrayDebugView<T0>
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75BEDDA0
	public Void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerIsReadOnlyAttribute
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerIsAtomicWriteOnlyAttribute
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerSupportsMinMaxWriteRestrictionAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75BEDDB8
	public Void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerSupportsDeallocateOnJobCompletionAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75BEDDA8
	public Void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerSupportsDeferredConvertListToArray
{
	// Methods

	// RVA: 0xFFFFFFFF75BEDDB0
	public Void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeSetThreadIndexAttribute
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerNeedsThreadIndexAttribute
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
public class WriteAccessRequiredAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75BEE190
	public Void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeDisableUnsafePtrRestrictionAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75BEDDC0
	public Void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeDisableContainerSafetyRestrictionAttribute
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeSetClassTypeToNullOnScheduleAttribute
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
public static class NativeArrayUnsafeUtility
{
	// Methods

	// RVA: -1
	public static NativeArray<T0> ConvertExistingDataToNativeArray(Void* dataPointer, Int32 length, Allocator allocator) { }

	// RVA: -1
	public static Void* GetUnsafePtr(NativeArray<T0> nativeArray) { }

	// RVA: -1
	public static Void* GetUnsafeReadOnlyPtr(NativeArray<T0> nativeArray) { }

	// RVA: -1
	public static Void* GetUnsafeBufferPointerWithoutChecks(NativeArray<T0> nativeArray) { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public static class UnsafeUtility
{
	// Methods

	// RVA: -1
	public static Boolean IsBlittable() { }

	// RVA: 0xFFFFFFFF723B4B94
	public static Void* Malloc(Int64 size, Int32 alignment, Allocator allocator) { }

	// RVA: 0xFFFFFFFF723B4BF0
	public static Void Free(Void* memory, Allocator allocator) { }

	// RVA: 0xFFFFFFFF75BEDDC8
	public static Void MemCpy(Void* destination, Void* source, Int64 size) { }

	// RVA: 0xFFFFFFFF723B4C4C
	public static Void MemMove(Void* destination, Void* source, Int64 size) { }

	// RVA: 0xFFFFFFFF75BEDE20
	public static Void MemSet(Void* destination, Byte value, Int64 size) { }

	// RVA: 0xFFFFFFFF723B4CA8
	public static Void MemClear(Void* destination, Int64 size) { }

	// RVA: 0xFFFFFFFF75BEDE78
	public static Int32 SizeOf(Type type) { }

	// RVA: 0xFFFFFFFF75BEDEB8
	public static Boolean IsBlittable(Type type) { }

	// RVA: 0xFFFFFFFF75BEDEF8
	private static Boolean IsBlittableValueType(Type t) { }

	// RVA: 0xFFFFFFFF75BEDF58
	private static String GetReasonForTypeNonBlittableImpl(Type t, String name) { }

	// RVA: 0xFFFFFFFF75BEE100
	internal static Boolean IsArrayBlittable(Array arr) { }

	// RVA: -1
	internal static Boolean IsGenericListBlittable() { }

	// RVA: 0xFFFFFFFF75BEE134
	internal static String GetReasonForArrayNonBlittable(Array arr) { }

	// RVA: -1
	internal static String GetReasonForGenericListNonBlittable() { }

	// RVA: -1
	public static Int32 AlignOf() { }

	// RVA: -1
	public static Void CopyPtrToStructure(Void* ptr, out T output) { }

	// RVA: -1
	private static Void InternalCopyPtrToStructure(Void* ptr, out T output) { }

	// RVA: -1
	public static T ReadArrayElement(Void* source, Int32 index) { }

	// RVA: -1
	public static Void WriteArrayElement(Void* destination, Int32 index, T value) { }

	// RVA: -1
	public static Void* AddressOf(ref T output) { }

	// RVA: -1
	public static Int32 SizeOf() { }

	// RVA: -1
	public static Int32 EnumToInt(T enumValue) { }

	// RVA: -1
	private static Void InternalEnumToInt(ref T enumValue, ref Int32 intValue) { }

}

// Namespace: 
private struct AlignOfHelper<T0>
{
	// Fields
	public Byte dummy; // 0x0
	public T data; // 0x0
}

// Namespace: Unity.Burst.LowLevel
internal static class BurstCompilerService
{
	// Methods

	// RVA: 0xFFFFFFFF75BEDD48
	public static Void* GetOrCreateSharedMemory(ref Hash128 key, UInt32 size_of, UInt32 alignment) { }

}

// Namespace: UnityEngine
public enum SendMessageOptions
{
	// Fields
	public Int32 value__; // 0x10
	public const SendMessageOptions RequireReceiver = 0;
	public const SendMessageOptions DontRequireReceiver = 1;
}

// Namespace: UnityEngine
public enum PrimitiveType
{
	// Fields
	public Int32 value__; // 0x10
	public const PrimitiveType Sphere = 0;
	public const PrimitiveType Capsule = 1;
	public const PrimitiveType Cylinder = 2;
	public const PrimitiveType Cube = 3;
	public const PrimitiveType Plane = 4;
	public const PrimitiveType Quad = 5;
}

// Namespace: UnityEngine
public enum Space
{
	// Fields
	public Int32 value__; // 0x10
	public const Space World = 0;
	public const Space Self = 1;
}

// Namespace: UnityEngine
public enum RuntimePlatform
{
	// Fields
	public Int32 value__; // 0x10
	public const RuntimePlatform OSXEditor = 0;
	public const RuntimePlatform OSXPlayer = 1;
	public const RuntimePlatform WindowsPlayer = 2;
	public const RuntimePlatform OSXWebPlayer = 3;
	public const RuntimePlatform OSXDashboardPlayer = 4;
	public const RuntimePlatform WindowsWebPlayer = 5;
	public const RuntimePlatform WindowsEditor = 7;
	public const RuntimePlatform IPhonePlayer = 8;
	public const RuntimePlatform XBOX360 = 10;
	public const RuntimePlatform PS3 = 9;
	public const RuntimePlatform Android = 11;
	public const RuntimePlatform NaCl = 12;
	public const RuntimePlatform FlashPlayer = 15;
	public const RuntimePlatform LinuxPlayer = 13;
	public const RuntimePlatform LinuxEditor = 16;
	public const RuntimePlatform WebGLPlayer = 17;
	public const RuntimePlatform MetroPlayerX86 = 18;
	public const RuntimePlatform WSAPlayerX86 = 18;
	public const RuntimePlatform MetroPlayerX64 = 19;
	public const RuntimePlatform WSAPlayerX64 = 19;
	public const RuntimePlatform MetroPlayerARM = 20;
	public const RuntimePlatform WSAPlayerARM = 20;
	public const RuntimePlatform WP8Player = 21;
	public const RuntimePlatform BlackBerryPlayer = 22;
	public const RuntimePlatform TizenPlayer = 23;
	public const RuntimePlatform PSP2 = 24;
	public const RuntimePlatform PS4 = 25;
	public const RuntimePlatform PSM = 26;
	public const RuntimePlatform XboxOne = 27;
	public const RuntimePlatform SamsungTVPlayer = 28;
	public const RuntimePlatform WiiU = 30;
	public const RuntimePlatform tvOS = 31;
	public const RuntimePlatform Switch = 32;
	public const RuntimePlatform Lumin = 33;
	public const RuntimePlatform Stadia = 34;
	public const RuntimePlatform CloudRendering = 35;
	public const RuntimePlatform GameCoreScarlett = 36;
	public const RuntimePlatform GameCoreXboxSeries = 36;
	public const RuntimePlatform GameCoreXboxOne = 37;
	public const RuntimePlatform PS5 = 38;
}

// Namespace: UnityEngine
public enum SystemLanguage
{
	// Fields
	public Int32 value__; // 0x10
	public const SystemLanguage Afrikaans = 0;
	public const SystemLanguage Arabic = 1;
	public const SystemLanguage Basque = 2;
	public const SystemLanguage Belarusian = 3;
	public const SystemLanguage Bulgarian = 4;
	public const SystemLanguage Catalan = 5;
	public const SystemLanguage Chinese = 6;
	public const SystemLanguage Czech = 7;
	public const SystemLanguage Danish = 8;
	public const SystemLanguage Dutch = 9;
	public const SystemLanguage English = 10;
	public const SystemLanguage Estonian = 11;
	public const SystemLanguage Faroese = 12;
	public const SystemLanguage Finnish = 13;
	public const SystemLanguage French = 14;
	public const SystemLanguage German = 15;
	public const SystemLanguage Greek = 16;
	public const SystemLanguage Hebrew = 17;
	public const SystemLanguage Icelandic = 19;
	public const SystemLanguage Indonesian = 20;
	public const SystemLanguage Italian = 21;
	public const SystemLanguage Japanese = 22;
	public const SystemLanguage Korean = 23;
	public const SystemLanguage Latvian = 24;
	public const SystemLanguage Lithuanian = 25;
	public const SystemLanguage Norwegian = 26;
	public const SystemLanguage Polish = 27;
	public const SystemLanguage Portuguese = 28;
	public const SystemLanguage Romanian = 29;
	public const SystemLanguage Russian = 30;
	public const SystemLanguage SerboCroatian = 31;
	public const SystemLanguage Slovak = 32;
	public const SystemLanguage Slovenian = 33;
	public const SystemLanguage Spanish = 34;
	public const SystemLanguage Swedish = 35;
	public const SystemLanguage Thai = 36;
	public const SystemLanguage Turkish = 37;
	public const SystemLanguage Ukrainian = 38;
	public const SystemLanguage Vietnamese = 39;
	public const SystemLanguage ChineseSimplified = 40;
	public const SystemLanguage ChineseTraditional = 41;
	public const SystemLanguage Unknown = 42;
	public const SystemLanguage Hungarian = 18;
}

// Namespace: UnityEngine
public enum LogType
{
	// Fields
	public Int32 value__; // 0x10
	public const LogType Error = 0;
	public const LogType Assert = 1;
	public const LogType Warning = 2;
	public const LogType Log = 3;
	public const LogType Exception = 4;
}

// Namespace: UnityEngine
public enum LogOption
{
	// Fields
	public Int32 value__; // 0x10
	public const LogOption None = 0;
	public const LogOption NoStacktrace = 1;
}

// Namespace: UnityEngine
public enum ThreadPriority
{
	// Fields
	public Int32 value__; // 0x10
	public const ThreadPriority Low = 0;
	public const ThreadPriority BelowNormal = 1;
	public const ThreadPriority Normal = 2;
	public const ThreadPriority High = 4;
}

// Namespace: UnityEngine
public struct SortingLayer
{
	// Fields
	private Int32 m_Id; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C380CC
	public static Int32 GetLayerValueFromID(Int32 id) { }

}

// Namespace: UnityEngine
public enum WeightedMode
{
	// Fields
	public Int32 value__; // 0x10
	public const WeightedMode None = 0;
	public const WeightedMode In = 1;
	public const WeightedMode Out = 2;
	public const WeightedMode Both = 3;
}

// Namespace: UnityEngine
public struct Keyframe
{
	// Fields
	private Single m_Time; // 0x10
	private Single m_Value; // 0x14
	private Single m_InTangent; // 0x18
	private Single m_OutTangent; // 0x1C
	private Int32 m_WeightedMode; // 0x20
	private Single m_InWeight; // 0x24
	private Single m_OutWeight; // 0x28

	// Properties
	public Single time { get; set; }
	public Single value { get; set; }
	public Single inTangent { get; set; }
	public Single outTangent { get; set; }
	public Single inWeight { get; set; }
	public Single outWeight { get; set; }
	public WeightedMode weightedMode { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF7114C184
	public Void .ctor(Single time, Single value) { }

	// RVA: 0xFFFFFFFF7114C194
	public Void .ctor(Single time, Single value, Single inTangent, Single outTangent) { }

	// RVA: 0xFFFFFFFF7114C1A8
	public Void .ctor(Single time, Single value, Single inTangent, Single outTangent, Single inWeight, Single outWeight) { }

	// RVA: 0xFFFFFFFF7114C1C0
	public Single get_time() { }

	// RVA: 0xFFFFFFFF7114C1C8
	public Void set_time(Single value) { }

	// RVA: 0xFFFFFFFF7114C1D0
	public Single get_value() { }

	// RVA: 0xFFFFFFFF7114C1D8
	public Void set_value(Single value) { }

	// RVA: 0xFFFFFFFF7114C1E0
	public Single get_inTangent() { }

	// RVA: 0xFFFFFFFF7114C1E8
	public Void set_inTangent(Single value) { }

	// RVA: 0xFFFFFFFF7114C1F0
	public Single get_outTangent() { }

	// RVA: 0xFFFFFFFF7114C1F8
	public Void set_outTangent(Single value) { }

	// RVA: 0xFFFFFFFF7114C200
	public Single get_inWeight() { }

	// RVA: 0xFFFFFFFF7114C208
	public Void set_inWeight(Single value) { }

	// RVA: 0xFFFFFFFF7114C210
	public Single get_outWeight() { }

	// RVA: 0xFFFFFFFF7114C218
	public Void set_outWeight(Single value) { }

	// RVA: 0xFFFFFFFF7114C220
	public WeightedMode get_weightedMode() { }

	// RVA: 0xFFFFFFFF7114C228
	public Void set_weightedMode(WeightedMode value) { }

}

// Namespace: UnityEngine
public enum WrapMode
{
	// Fields
	public Int32 value__; // 0x10
	public const WrapMode Once = 1;
	public const WrapMode Loop = 2;
	public const WrapMode PingPong = 4;
	public const WrapMode Default = 0;
	public const WrapMode ClampForever = 8;
	public const WrapMode Clamp = 1;
}

// Namespace: UnityEngine
public class AnimationCurve
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public Keyframe[] keys { get; set; }
	public Keyframe Item { get; }
	public Int32 length { get; }
	public WrapMode preWrapMode { get; set; }
	public WrapMode postWrapMode { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75BEE988
	private static Void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF75BEE9C8
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	// RVA: 0xFFFFFFFF75BEEA08
	private Boolean Internal_Equals(IntPtr other) { }

	// RVA: 0xFFFFFFFF723B4F4C
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF723B4FBC
	public Single Evaluate(Single time) { }

	// RVA: 0xFFFFFFFF723B5018
	public Keyframe[] get_keys() { }

	// RVA: 0xFFFFFFFF75BEEA98
	public Void set_keys(Keyframe[] value) { }

	// RVA: 0xFFFFFFFF75BEEB3C
	public Int32 AddKey(Single time, Single value) { }

	// RVA: 0xFFFFFFFF75BEEB94
	public Int32 AddKey(Keyframe key) { }

	// RVA: 0xFFFFFFFF75BEEBF4
	private Int32 AddKey_Internal(Keyframe key) { }

	// RVA: 0xFFFFFFFF75BEEC94
	public Int32 MoveKey(Int32 index, Keyframe key) { }

	// RVA: 0xFFFFFFFF75BEED44
	public Void RemoveKey(Int32 index) { }

	// RVA: 0xFFFFFFFF75BEED94
	public Keyframe get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF75BEEE94
	public Int32 get_length() { }

	// RVA: 0xFFFFFFFF75BEEAEC
	private Void SetKeys(Keyframe[] keys) { }

	// RVA: 0xFFFFFFFF75BEEE14
	private Keyframe GetKey(Int32 index) { }

	// RVA: 0xFFFFFFFF75BEEA58
	private Keyframe[] GetKeys() { }

	// RVA: 0xFFFFFFFF75BEEF2C
	public Void SmoothTangents(Int32 index, Single weight) { }

	// RVA: 0xFFFFFFFF75BEEF8C
	public static AnimationCurve Constant(Single timeStart, Single timeEnd, Single value) { }

	// RVA: 0xFFFFFFFF723B506C
	public static AnimationCurve Linear(Single timeStart, Single valueStart, Single timeEnd, Single valueEnd) { }

	// RVA: 0xFFFFFFFF75BEEF9C
	public static AnimationCurve EaseInOut(Single timeStart, Single valueStart, Single timeEnd, Single valueEnd) { }

	// RVA: 0xFFFFFFFF75BEF0DC
	public WrapMode get_preWrapMode() { }

	// RVA: 0xFFFFFFFF75BEF11C
	public Void set_preWrapMode(WrapMode value) { }

	// RVA: 0xFFFFFFFF75BEF16C
	public WrapMode get_postWrapMode() { }

	// RVA: 0xFFFFFFFF75BEF1AC
	public Void set_postWrapMode(WrapMode value) { }

	// RVA: 0xFFFFFFFF723B51CC
	public Void .ctor(Keyframe[] keys) { }

	// RVA: 0xFFFFFFFF723B522C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BEF1FC
	public override Boolean Equals(Object o) { }

	// RVA: 0xFFFFFFFF75BEF2B0
	public Boolean Equals(AnimationCurve other) { }

	// RVA: 0xFFFFFFFF75BEF35C
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75BEEC44
	private Int32 AddKey_Internal_Injected(ref Keyframe key) { }

	// RVA: 0xFFFFFFFF75BEECEC
	private Int32 MoveKey_Injected(Int32 index, ref Keyframe key) { }

	// RVA: 0xFFFFFFFF75BEEED4
	private Void GetKey_Injected(Int32 index, out Keyframe ret) { }

}

// Namespace: UnityEngine
public class Application
{
	// Fields
	private static CreateGPUProgramCallback onCreateGPUProgram; // 0x0
	private static FinishGPUProgramCallback onFinishGPUProgram; // 0x8
	private static PathRenewCallback pathRenew; // 0x10
	private static LowMemoryCallback lowMemory; // 0x18
	private static LogCallback s_LogCallbackHandler; // 0x20
	private static LogCallback s_LogCallbackHandlerThreaded; // 0x28
	internal static AdvertisingIdentifierCallback OnAdvertisingIdentifierCallback; // 0x30
	private static Action<T0> focusChanged; // 0x38
	private static Action<T0> deepLinkActivated; // 0x40
	private static Func<T0> wantsToQuit; // 0x48
	private static Action quitting; // 0x50
	private static LogCallback s_RegisterLogCallbackDeprecated; // 0x58

	// Properties
	public static Boolean isLoadingLevel { get; }
	public static Int32 streamedBytes { get; }
	public static Boolean webSecurityEnabled { get; }
	public static Boolean isPlaying { get; }
	public static Boolean isFocused { get; }
	public static String buildGUID { get; }
	public static Boolean runInBackground { get; set; }
	public static Boolean isBatchMode { get; }
	internal static Boolean isTestRun { get; }
	internal static Boolean isHumanControllingUs { get; }
	public static String dataPath { get; }
	public static String streamingAssetsPath { get; }
	public static String persistentDataPath { get; }
	public static String temporaryCachePath { get; }
	public static String absoluteURL { get; }
	public static String unityVersion { get; }
	public static String version { get; }
	public static String installerName { get; }
	public static String identifier { get; }
	public static ApplicationInstallMode installMode { get; }
	public static ApplicationSandboxType sandboxType { get; }
	public static String productName { get; }
	public static String companyName { get; }
	public static String cloudProjectId { get; }
	public static Int32 targetFrameRate { get; set; }
	public static StackTraceLogType stackTraceLogType { get; set; }
	public static String consoleLogPath { get; }
	public static ThreadPriority backgroundLoadingPriority { get; set; }
	public static Boolean genuine { get; }
	public static Boolean genuineCheckAvailable { get; }
	internal static Boolean submitAnalytics { get; }
	public static Boolean isShowingSplashScreen { get; }
	public static RuntimePlatform platform { get; }
	public static Boolean isMobilePlatform { get; }
	public static Boolean isConsolePlatform { get; }
	public static SystemLanguage systemLanguage { get; }
	public static NetworkReachability internetReachability { get; }
	public static Boolean isPlayer { get; }
	public static Int32 levelCount { get; }
	public static Int32 loadedLevel { get; }
	public static String loadedLevelName { get; }
	public static Boolean isEditor { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BEF368
	public static Void Quit(Int32 exitCode) { }

	// RVA: 0xFFFFFFFF75BEF3A8
	public static Void Quit() { }

	// RVA: 0xFFFFFFFF75BEF3E4
	public static Void CancelQuit() { }

	// RVA: 0xFFFFFFFF75BEF418
	public static Void Unload() { }

	// RVA: 0xFFFFFFFF75BEF44C
	public static Boolean get_isLoadingLevel() { }

	// RVA: 0xFFFFFFFF75BEF480
	public static Single GetStreamProgressForLevel(Int32 levelIndex) { }

	// RVA: 0xFFFFFFFF75BEF4DC
	public static Single GetStreamProgressForLevel(String levelName) { }

	// RVA: 0xFFFFFFFF75BEF4E4
	public static Int32 get_streamedBytes() { }

	// RVA: 0xFFFFFFFF75BEF4EC
	public static Boolean get_webSecurityEnabled() { }

	// RVA: 0xFFFFFFFF75BEF4F4
	public static Boolean CanStreamedLevelBeLoaded(Int32 levelIndex) { }

	// RVA: 0xFFFFFFFF75BEF548
	public static Boolean CanStreamedLevelBeLoaded(String levelName) { }

	// RVA: 0xFFFFFFFF723B527C
	public static Boolean get_isPlaying() { }

	// RVA: 0xFFFFFFFF75BEF588
	public static Boolean IsPlaying(Object obj) { }

	// RVA: 0xFFFFFFFF75BEF5C8
	public static Boolean get_isFocused() { }

	// RVA: 0xFFFFFFFF75BEF5FC
	public static String[] GetBuildTags() { }

	// RVA: 0xFFFFFFFF75BEF630
	public static Void SetBuildTags(String[] buildTags) { }

	// RVA: 0xFFFFFFFF75BEF670
	public static String get_buildGUID() { }

	// RVA: 0xFFFFFFFF75BEF6A4
	public static Boolean get_runInBackground() { }

	// RVA: 0xFFFFFFFF75BEF6D8
	public static Void set_runInBackground(Boolean value) { }

	// RVA: 0xFFFFFFFF75BEF718
	public static Boolean HasProLicense() { }

	// RVA: 0xFFFFFFFF75BEF74C
	public static Boolean get_isBatchMode() { }

	// RVA: 0xFFFFFFFF75BEF780
	internal static Boolean get_isTestRun() { }

	// RVA: 0xFFFFFFFF75BEF7B4
	internal static Boolean get_isHumanControllingUs() { }

	// RVA: 0xFFFFFFFF75BEF7E8
	internal static Boolean HasARGV(String name) { }

	// RVA: 0xFFFFFFFF75BEF828
	internal static String GetMTInfo(Int32 i) { }

	// RVA: 0xFFFFFFFF723B52B8
	internal static String GetValueForARGV(String name) { }

	// RVA: 0xFFFFFFFF723B52FC
	public static String get_dataPath() { }

	// RVA: 0xFFFFFFFF75BEF868
	public static String get_streamingAssetsPath() { }

	// RVA: 0xFFFFFFFF723B5334
	public static String get_persistentDataPath() { }

	// RVA: 0xFFFFFFFF75BEF8A0
	public static String get_temporaryCachePath() { }

	// RVA: 0xFFFFFFFF75BEF8D4
	public static String get_absoluteURL() { }

	// RVA: 0xFFFFFFFF75BEF908
	public static Void ExternalEval(String script) { }

	// RVA: 0xFFFFFFFF75BEF988
	private static Void Internal_ExternalCall(String script) { }

	// RVA: 0xFFFFFFFF75BEF9C8
	public static String get_unityVersion() { }

	// RVA: 0xFFFFFFFF75BEF9FC
	public static String get_version() { }

	// RVA: 0xFFFFFFFF75BEFA30
	public static String get_installerName() { }

	// RVA: 0xFFFFFFFF723B536C
	public static String get_identifier() { }

	// RVA: 0xFFFFFFFF75BEFA64
	public static ApplicationInstallMode get_installMode() { }

	// RVA: 0xFFFFFFFF75BEFA98
	public static ApplicationSandboxType get_sandboxType() { }

	// RVA: 0xFFFFFFFF75BEFACC
	public static String get_productName() { }

	// RVA: 0xFFFFFFFF75BEFB00
	public static String get_companyName() { }

	// RVA: 0xFFFFFFFF75BEFB34
	public static String get_cloudProjectId() { }

	// RVA: 0xFFFFFFFF75BEFB68
	public static Boolean RequestAdvertisingIdentifierAsync(AdvertisingIdentifierCallback delegateMethod) { }

	// RVA: 0xFFFFFFFF75BEFBA8
	public static Void OpenURL(String url) { }

	// RVA: 0xFFFFFFFF75BEFBE8
	public static Void ForceCrash(Int32 mode) { }

	// RVA: 0xFFFFFFFF723B53A4
	public static Int32 get_targetFrameRate() { }

	// RVA: 0xFFFFFFFF723B53E0
	public static Void set_targetFrameRate(Int32 value) { }

	// RVA: 0xFFFFFFFF75BEFC68
	private static Void SetLogCallbackDefined(Boolean defined) { }

	// RVA: 0xFFFFFFFF75BEFCA8
	public static StackTraceLogType get_stackTraceLogType() { }

	// RVA: 0xFFFFFFFF75BEFCDC
	public static Void set_stackTraceLogType(StackTraceLogType value) { }

	// RVA: 0xFFFFFFFF75BEFD1C
	public static StackTraceLogType GetStackTraceLogType(LogType logType) { }

	// RVA: 0xFFFFFFFF75BEFD5C
	public static Void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType) { }

	// RVA: 0xFFFFFFFF75BEFDAC
	public static String get_consoleLogPath() { }

	// RVA: 0xFFFFFFFF75BEFDE0
	public static ThreadPriority get_backgroundLoadingPriority() { }

	// RVA: 0xFFFFFFFF723B5424
	public static Void set_backgroundLoadingPriority(ThreadPriority value) { }

	// RVA: 0xFFFFFFFF75BEFE14
	public static Boolean get_genuine() { }

	// RVA: 0xFFFFFFFF75BEFE48
	public static Boolean get_genuineCheckAvailable() { }

	// RVA: 0xFFFFFFFF75BEFE7C
	public static AsyncOperation RequestUserAuthorization(UserAuthorization mode) { }

	// RVA: 0xFFFFFFFF75BEFEBC
	public static Boolean HasUserAuthorization(UserAuthorization mode) { }

	// RVA: 0xFFFFFFFF75BEFEFC
	internal static Boolean get_submitAnalytics() { }

	// RVA: 0xFFFFFFFF75BEFF30
	public static Boolean get_isShowingSplashScreen() { }

	// RVA: 0xFFFFFFFF723B5468
	public static RuntimePlatform get_platform() { }

	// RVA: 0xFFFFFFFF75BEFF4C
	public static Boolean get_isMobilePlatform() { }

	// RVA: 0xFFFFFFFF75BEFFBC
	public static Boolean get_isConsolePlatform() { }

	// RVA: 0xFFFFFFFF75BF0020
	public static SystemLanguage get_systemLanguage() { }

	// RVA: 0xFFFFFFFF723B54A0
	public static NetworkReachability get_internetReachability() { }

	// RVA: 0xFFFFFFFF75BF0058
	public static Void add_onCreateGPUProgram(CreateGPUProgramCallback value) { }

	// RVA: 0xFFFFFFFF75BF00FC
	public static Void remove_onCreateGPUProgram(CreateGPUProgramCallback value) { }

	// RVA: 0xFFFFFFFF75BF01A0
	public static Void add_onFinishGPUProgram(FinishGPUProgramCallback value) { }

	// RVA: 0xFFFFFFFF723B54D8
	public static Void remove_onFinishGPUProgram(FinishGPUProgramCallback value) { }

	// RVA: 0xFFFFFFFF75BF0248
	public static Void add_pathRenew(PathRenewCallback value) { }

	// RVA: 0xFFFFFFFF75BF02F0
	public static Void remove_pathRenew(PathRenewCallback value) { }

	// RVA: 0xFFFFFFFF75BF0398
	internal static Void OnCreateGPUProgram(String shaderName, String passName, String m_VariantDescription) { }

	// RVA: 0xFFFFFFFF723B557C
	internal static Void OnFinishGPUProgram(String shaderName, String passName, String m_VariantDescription, Int32 passType, Int32 compilePath, Double compileTime) { }

	// RVA: 0xFFFFFFFF75BF07AC
	internal static Void PathRenew() { }

	// RVA: 0xFFFFFFFF75BF09C4
	public static Void add_lowMemory(LowMemoryCallback value) { }

	// RVA: 0xFFFFFFFF75BF0A6C
	public static Void remove_lowMemory(LowMemoryCallback value) { }

	// RVA: 0xFFFFFFFF75BF0B14
	internal static Void CallLowMemory() { }

	// RVA: 0xFFFFFFFF75BF0D2C
	public static Void add_logMessageReceived(LogCallback value) { }

	// RVA: 0xFFFFFFFF75BF0DC0
	public static Void remove_logMessageReceived(LogCallback value) { }

	// RVA: 0xFFFFFFFF75BF0E34
	public static Void add_logMessageReceivedThreaded(LogCallback value) { }

	// RVA: 0xFFFFFFFF75BF0EC8
	public static Void remove_logMessageReceivedThreaded(LogCallback value) { }

	// RVA: 0xFFFFFFFF723B5A00
	private static Void CallLogCallback(String logString, String stackTrace, LogType type, Boolean invokedOnMainThread) { }

	// RVA: 0xFFFFFFFF75BF0F3C
	internal static Void InvokeOnAdvertisingIdentifierCallback(String advertisingId, Boolean trackingEnabled) { }

	// RVA: 0xFFFFFFFF75BF13D4
	private static String ObjectToJSString(Object o) { }

	// RVA: 0xFFFFFFFF75BF193C
	public static Void ExternalCall(String functionName, Object[] args) { }

	// RVA: 0xFFFFFFFF75BF1980
	private static String BuildInvocationForArguments(String functionName, Object[] args) { }

	// RVA: 0xFFFFFFFF75BF1AD8
	public static Boolean get_isPlayer() { }

	// RVA: 0xFFFFFFFF75BF1AE0
	public static Void DontDestroyOnLoad(Object o) { }

	// RVA: 0xFFFFFFFF75BF1B38
	public static Void CaptureScreenshot(String filename, Int32 superSize) { }

	// RVA: 0xFFFFFFFF75BF1BA0
	public static Void CaptureScreenshot(String filename) { }

	// RVA: 0xFFFFFFFF75BF1C08
	public static Void add_onBeforeRender(UnityAction value) { }

	// RVA: 0xFFFFFFFF75BF1F3C
	public static Void remove_onBeforeRender(UnityAction value) { }

	// RVA: 0xFFFFFFFF75BF2218
	public static Void add_focusChanged(Action<T0> value) { }

	// RVA: 0xFFFFFFFF75BF22C0
	public static Void remove_focusChanged(Action<T0> value) { }

	// RVA: 0xFFFFFFFF75BF2368
	public static Void add_deepLinkActivated(Action<T0> value) { }

	// RVA: 0xFFFFFFFF75BF2410
	public static Void remove_deepLinkActivated(Action<T0> value) { }

	// RVA: 0xFFFFFFFF75BF24B8
	public static Void add_wantsToQuit(Func<T0> value) { }

	// RVA: 0xFFFFFFFF75BF2560
	public static Void remove_wantsToQuit(Func<T0> value) { }

	// RVA: 0xFFFFFFFF75BF2608
	public static Void add_quitting(Action value) { }

	// RVA: 0xFFFFFFFF75BF26B0
	public static Void remove_quitting(Action value) { }

	// RVA: 0xFFFFFFFF75BF2750
	private static Boolean Internal_ApplicationWantsToQuit() { }

	// RVA: 0xFFFFFFFF75BF29A8
	private static Void Internal_ApplicationQuit() { }

	// RVA: 0xFFFFFFFF723B5E48
	internal static Void InvokeOnBeforeRender() { }

	// RVA: 0xFFFFFFFF75BF29C8
	internal static Void InvokeFocusChanged(Boolean focus) { }

	// RVA: 0xFFFFFFFF75BF29F0
	internal static Void InvokeDeepLinkActivated(String url) { }

	// RVA: 0xFFFFFFFF75BF2A18
	public static Void RegisterLogCallback(LogCallback handler) { }

	// RVA: 0xFFFFFFFF75BF2AE4
	public static Void RegisterLogCallbackThreaded(LogCallback handler) { }

	// RVA: 0xFFFFFFFF75BF2A20
	private static Void RegisterLogCallback(LogCallback handler, Boolean threaded) { }

	// RVA: 0xFFFFFFFF75BF2AEC
	public static Int32 get_levelCount() { }

	// RVA: 0xFFFFFFFF75BF2B1C
	public static Int32 get_loadedLevel() { }

	// RVA: 0xFFFFFFFF75BF2B68
	public static String get_loadedLevelName() { }

	// RVA: 0xFFFFFFFF75BF2BB4
	public static Void LoadLevel(Int32 index) { }

	// RVA: 0xFFFFFFFF75BF2BF8
	public static Void LoadLevel(String name) { }

	// RVA: 0xFFFFFFFF75BF2C3C
	public static Void LoadLevelAdditive(Int32 index) { }

	// RVA: 0xFFFFFFFF75BF2C80
	public static Void LoadLevelAdditive(String name) { }

	// RVA: 0xFFFFFFFF75BF2CC4
	public static AsyncOperation LoadLevelAsync(Int32 index) { }

	// RVA: 0xFFFFFFFF75BF2D08
	public static AsyncOperation LoadLevelAsync(String levelName) { }

	// RVA: 0xFFFFFFFF75BF2D4C
	public static AsyncOperation LoadLevelAdditiveAsync(Int32 index) { }

	// RVA: 0xFFFFFFFF75BF2D90
	public static AsyncOperation LoadLevelAdditiveAsync(String levelName) { }

	// RVA: 0xFFFFFFFF75BF2DD4
	public static Boolean UnloadLevel(Int32 index) { }

	// RVA: 0xFFFFFFFF75BF2E14
	public static Boolean UnloadLevel(String scenePath) { }

	// RVA: 0xFFFFFFFF75BF2E54
	internal static Void SwapBufferCB() { }

	// RVA: 0xFFFFFFFF723B5E40
	public static Boolean get_isEditor() { }

	// RVA: 0xFFFFFFFF75BF2E58
	public Void .ctor() { }

}

// Namespace: 
public sealed class AdvertisingIdentifierCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75BF2E5C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75BF0F70
	public virtual Void Invoke(String advertisingId, Boolean trackingEnabled, String errorMsg) { }

	// RVA: 0xFFFFFFFF75BF2EA0
	public virtual IAsyncResult BeginInvoke(String advertisingId, Boolean trackingEnabled, String errorMsg, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BF2F38
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class CreateGPUProgramCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75BF2F44
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75BF03C0
	public virtual Void Invoke(String shaderName, String passName, String m_VariantDescription) { }

	// RVA: 0xFFFFFFFF75BF2F88
	public virtual IAsyncResult BeginInvoke(String shaderName, String passName, String m_VariantDescription, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BF2FE4
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class FinishGPUProgramCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75BF2FF0
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF723B55AC
	public virtual Void Invoke(String shaderName, String passName, String m_VariantDescription, Int32 passType, Int32 compilePath, Double compileTime) { }

	// RVA: 0xFFFFFFFF75BF3034
	public virtual IAsyncResult BeginInvoke(String shaderName, String passName, String m_VariantDescription, Int32 passType, Int32 compilePath, Double compileTime, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BF30F4
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class PathRenewCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75BF32BC
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75BF07C8
	public virtual Void Invoke() { }

	// RVA: 0xFFFFFFFF75BF3300
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BF3358
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class LowMemoryCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75BF3214
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75BF0B30
	public virtual Void Invoke() { }

	// RVA: 0xFFFFFFFF75BF3258
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BF32B0
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class LogCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75BF3100
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF723B5A80
	public virtual Void Invoke(String condition, String stackTrace, LogType type) { }

	// RVA: 0xFFFFFFFF75BF3144
	public virtual IAsyncResult BeginInvoke(String condition, String stackTrace, LogType type, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BF3208
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine
public enum StackTraceLogType
{
	// Fields
	public Int32 value__; // 0x10
	public const StackTraceLogType None = 0;
	public const StackTraceLogType ScriptOnly = 1;
	public const StackTraceLogType Full = 2;
}

// Namespace: UnityEngine
public enum NetworkReachability
{
	// Fields
	public Int32 value__; // 0x10
	public const NetworkReachability NotReachable = 0;
	public const NetworkReachability ReachableViaCarrierDataNetwork = 1;
	public const NetworkReachability ReachableViaLocalAreaNetwork = 2;
}

// Namespace: UnityEngine
public enum UserAuthorization
{
	// Fields
	public Int32 value__; // 0x10
	public const UserAuthorization WebCam = 1;
	public const UserAuthorization Microphone = 2;
}

// Namespace: UnityEngine
public enum ApplicationInstallMode
{
	// Fields
	public Int32 value__; // 0x10
	public const ApplicationInstallMode Unknown = 0;
	public const ApplicationInstallMode Store = 1;
	public const ApplicationInstallMode DeveloperBuild = 2;
	public const ApplicationInstallMode Adhoc = 3;
	public const ApplicationInstallMode Enterprise = 4;
	public const ApplicationInstallMode Editor = 5;
}

// Namespace: UnityEngine
public enum ApplicationSandboxType
{
	// Fields
	public Int32 value__; // 0x10
	public const ApplicationSandboxType Unknown = 0;
	public const ApplicationSandboxType NotSandboxed = 1;
	public const ApplicationSandboxType Sandboxed = 2;
	public const ApplicationSandboxType SandboxBroken = 3;
}

// Namespace: UnityEngine
internal class BootConfigData
{
	// Fields
	private IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75BF4B70
	private static BootConfigData WrapBootConfigData(IntPtr nativeHandle) { }

	// RVA: 0xFFFFFFFF75BF4BC8
	private Void .ctor(IntPtr nativeHandle) { }

}

// Namespace: UnityEngine
public struct CachedAssetBundle
{
	// Fields
	private String m_Name; // 0x10
	private Hash128 m_Hash; // 0x18

	// Properties
	public String name { get; }
	public Hash128 hash { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114B548
	public Void .ctor(String name, Hash128 hash) { }

	// RVA: 0xFFFFFFFF7114B594
	public String get_name() { }

	// RVA: 0xFFFFFFFF7114B59C
	public Hash128 get_hash() { }

}

// Namespace: UnityEngine
public sealed class Caching
{
	// Properties
	public static Boolean ready { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BF56B8
	public static Boolean get_ready() { }

	// RVA: 0xFFFFFFFF75BF56F0
	public static Boolean ClearCache() { }

}

// Namespace: UnityEngine
public sealed class Camera
{
	// Fields
	public static CameraCallback onPreCull; // 0x0
	public static CameraCallback onPreRender; // 0x8
	public static CameraCallback onPostRender; // 0x10

	// Properties
	public Single nearClipPlane { get; set; }
	public Single farClipPlane { get; set; }
	public Single fieldOfView { get; set; }
	public RenderingPath renderingPath { get; set; }
	public RenderingPath actualRenderingPath { get; }
	public Boolean allowHDR { get; set; }
	public Boolean allowMSAA { get; set; }
	public Boolean allowDynamicResolution { get; set; }
	public Boolean forceIntoRenderTexture { get; set; }
	public Single orthographicSize { get; set; }
	public Boolean orthographic { get; set; }
	public OpaqueSortMode opaqueSortMode { get; set; }
	public TransparencySortMode transparencySortMode { get; set; }
	public Vector3 transparencySortAxis { get; set; }
	public Single depth { get; set; }
	public Single aspect { get; set; }
	public Vector3 velocity { get; }
	public Int32 cullingMask { get; set; }
	public Int32 eventMask { get; set; }
	public Boolean layerCullSpherical { get; set; }
	public CameraType cameraType { get; set; }
	public UInt64 overrideSceneCullingMask { get; set; }
	public Single[] layerCullDistances { get; set; }
	internal static Int32 PreviewCullingLayer { get; }
	public Boolean useOcclusionCulling { get; set; }
	public Matrix4x4 cullingMatrix { get; set; }
	public Color backgroundColor { get; set; }
	public CameraClearFlags clearFlags { get; set; }
	public DepthTextureMode depthTextureMode { get; set; }
	public Boolean clearStencilAfterLightingPass { get; set; }
	internal ProjectionMatrixMode projectionMatrixMode { get; }
	public Boolean usePhysicalProperties { get; set; }
	public Vector2 sensorSize { get; set; }
	public Vector2 lensShift { get; set; }
	public Single focalLength { get; set; }
	public GateFitMode gateFit { get; set; }
	public Rect rect { get; set; }
	public Rect pixelRect { get; set; }
	public Int32 pixelWidth { get; }
	public Int32 pixelHeight { get; }
	public Int32 scaledPixelWidth { get; }
	public Int32 scaledPixelHeight { get; }
	public RenderTexture targetTexture { get; set; }
	public RenderTexture activeTexture { get; }
	public Int32 targetDisplay { get; set; }
	public Matrix4x4 cameraToWorldMatrix { get; }
	public Matrix4x4 worldToCameraMatrix { get; set; }
	public Matrix4x4 projectionMatrix { get; set; }
	public Matrix4x4 nonJitteredProjectionMatrix { get; set; }
	public Boolean useJitteredProjectionMatrixForTransparentRendering { get; set; }
	public Matrix4x4 previousViewProjectionMatrix { get; }
	public static Camera main { get; }
	public static Camera current { get; }
	public Scene scene { get; set; }
	public Boolean stereoEnabled { get; }
	public Single stereoSeparation { get; set; }
	public Single stereoConvergence { get; set; }
	public Boolean areVRStereoViewMatricesWithinSingleCullTolerance { get; }
	public StereoTargetEyeMask stereoTargetEye { get; set; }
	public MonoOrStereoscopicEye stereoActiveEye { get; }
	public static Int32 allCamerasCount { get; }
	public static Camera[] allCameras { get; }
	public Int32 commandBufferCount { get; }

	// Methods

	// RVA: 0xFFFFFFFF723B6B20
	public Single get_nearClipPlane() { }

	// RVA: 0xFFFFFFFF723B6B64
	public Void set_nearClipPlane(Single value) { }

	// RVA: 0xFFFFFFFF723B6BB8
	public Single get_farClipPlane() { }

	// RVA: 0xFFFFFFFF723B6BFC
	public Void set_farClipPlane(Single value) { }

	// RVA: 0xFFFFFFFF723B6C50
	public Single get_fieldOfView() { }

	// RVA: 0xFFFFFFFF723B6C94
	public Void set_fieldOfView(Single value) { }

	// RVA: 0xFFFFFFFF723B6CE8
	public RenderingPath get_renderingPath() { }

	// RVA: 0xFFFFFFFF723B6D2C
	public Void set_renderingPath(RenderingPath value) { }

	// RVA: 0xFFFFFFFF75BF5724
	public RenderingPath get_actualRenderingPath() { }

	// RVA: 0xFFFFFFFF75BF5764
	public Void Reset() { }

	// RVA: 0xFFFFFFFF75BF57A4
	public Boolean get_allowHDR() { }

	// RVA: 0xFFFFFFFF723B6D88
	public Void set_allowHDR(Boolean value) { }

	// RVA: 0xFFFFFFFF75BF57E8
	public Boolean get_allowMSAA() { }

	// RVA: 0xFFFFFFFF723B6DDC
	public Void set_allowMSAA(Boolean value) { }

	// RVA: 0xFFFFFFFF75BF5828
	public Boolean get_allowDynamicResolution() { }

	// RVA: 0xFFFFFFFF75BF5868
	public Void set_allowDynamicResolution(Boolean value) { }

	// RVA: 0xFFFFFFFF75BF58B8
	public Boolean get_forceIntoRenderTexture() { }

	// RVA: 0xFFFFFFFF75BF58F8
	public Void set_forceIntoRenderTexture(Boolean value) { }

	// RVA: 0xFFFFFFFF723B6E30
	public Single get_orthographicSize() { }

	// RVA: 0xFFFFFFFF723B6E84
	public Void set_orthographicSize(Single value) { }

	// RVA: 0xFFFFFFFF723B6ED8
	public Boolean get_orthographic() { }

	// RVA: 0xFFFFFFFF723B6F2C
	public Void set_orthographic(Boolean value) { }

	// RVA: 0xFFFFFFFF75BF5948
	public OpaqueSortMode get_opaqueSortMode() { }

	// RVA: 0xFFFFFFFF75BF5988
	public Void set_opaqueSortMode(OpaqueSortMode value) { }

	// RVA: 0xFFFFFFFF75BF59D8
	public TransparencySortMode get_transparencySortMode() { }

	// RVA: 0xFFFFFFFF75BF5A18
	public Void set_transparencySortMode(TransparencySortMode value) { }

	// RVA: 0xFFFFFFFF75BF5A68
	public Vector3 get_transparencySortAxis() { }

	// RVA: 0xFFFFFFFF75BF5B18
	public Void set_transparencySortAxis(Vector3 value) { }

	// RVA: 0xFFFFFFFF75BF5BC0
	public Void ResetTransparencySortSettings() { }

	// RVA: 0xFFFFFFFF723B6F80
	public Single get_depth() { }

	// RVA: 0xFFFFFFFF75BF5C00
	public Void set_depth(Single value) { }

	// RVA: 0xFFFFFFFF723B6FD4
	public Single get_aspect() { }

	// RVA: 0xFFFFFFFF723B7018
	public Void set_aspect(Single value) { }

	// RVA: 0xFFFFFFFF75BF5C54
	public Void ResetAspect() { }

	// RVA: 0xFFFFFFFF75BF5C94
	public Vector3 get_velocity() { }

	// RVA: 0xFFFFFFFF723B706C
	public Int32 get_cullingMask() { }

	// RVA: 0xFFFFFFFF723B70C0
	public Void set_cullingMask(Int32 value) { }

	// RVA: 0xFFFFFFFF75BF5D44
	public Int32 get_eventMask() { }

	// RVA: 0xFFFFFFFF75BF5D84
	public Void set_eventMask(Int32 value) { }

	// RVA: 0xFFFFFFFF75BF5DD8
	public Boolean get_layerCullSpherical() { }

	// RVA: 0xFFFFFFFF75BF5E18
	public Void set_layerCullSpherical(Boolean value) { }

	// RVA: 0xFFFFFFFF75BF5E68
	public CameraType get_cameraType() { }

	// RVA: 0xFFFFFFFF75BF5EA8
	public Void set_cameraType(CameraType value) { }

	// RVA: 0xFFFFFFFF75BF5EF8
	public UInt64 get_overrideSceneCullingMask() { }

	// RVA: 0xFFFFFFFF75BF5F38
	public Void set_overrideSceneCullingMask(UInt64 value) { }

	// RVA: 0xFFFFFFFF75BF5F88
	private Single[] GetLayerCullDistances() { }

	// RVA: 0xFFFFFFFF75BF5FC8
	private Void SetLayerCullDistances(Single[] d) { }

	// RVA: 0xFFFFFFFF75BF6018
	public Single[] get_layerCullDistances() { }

	// RVA: 0xFFFFFFFF75BF6058
	public Void set_layerCullDistances(Single[] value) { }

	// RVA: 0xFFFFFFFF75BF6118
	internal static Int32 get_PreviewCullingLayer() { }

	// RVA: 0xFFFFFFFF75BF614C
	public Boolean get_useOcclusionCulling() { }

	// RVA: 0xFFFFFFFF75BF618C
	public Void set_useOcclusionCulling(Boolean value) { }

	// RVA: 0xFFFFFFFF75BF61E0
	public Matrix4x4 get_cullingMatrix() { }

	// RVA: 0xFFFFFFFF75BF62A8
	public Void set_cullingMatrix(Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75BF6348
	public Void ResetCullingMatrix() { }

	// RVA: 0xFFFFFFFF723B7114
	public Color get_backgroundColor() { }

	// RVA: 0xFFFFFFFF723B717C
	public Void set_backgroundColor(Color value) { }

	// RVA: 0xFFFFFFFF723B71D8
	public CameraClearFlags get_clearFlags() { }

	// RVA: 0xFFFFFFFF723B722C
	public Void set_clearFlags(CameraClearFlags value) { }

	// RVA: 0xFFFFFFFF75BF6428
	public DepthTextureMode get_depthTextureMode() { }

	// RVA: 0xFFFFFFFF723B7280
	public Void set_depthTextureMode(DepthTextureMode value) { }

	// RVA: 0xFFFFFFFF75BF6468
	public Boolean get_clearStencilAfterLightingPass() { }

	// RVA: 0xFFFFFFFF75BF64A8
	public Void set_clearStencilAfterLightingPass(Boolean value) { }

	// RVA: 0xFFFFFFFF75BF64F8
	public Void SetReplacementShader(Shader shader, String replacementTag) { }

	// RVA: 0xFFFFFFFF75BF6554
	public Void ResetReplacementShader() { }

	// RVA: 0xFFFFFFFF75BF6594
	internal ProjectionMatrixMode get_projectionMatrixMode() { }

	// RVA: 0xFFFFFFFF75BF65D4
	public Boolean get_usePhysicalProperties() { }

	// RVA: 0xFFFFFFFF75BF6614
	public Void set_usePhysicalProperties(Boolean value) { }

	// RVA: 0xFFFFFFFF75BF6664
	public Vector2 get_sensorSize() { }

	// RVA: 0xFFFFFFFF75BF670C
	public Void set_sensorSize(Vector2 value) { }

	// RVA: 0xFFFFFFFF75BF67B0
	public Vector2 get_lensShift() { }

	// RVA: 0xFFFFFFFF75BF6858
	public Void set_lensShift(Vector2 value) { }

	// RVA: 0xFFFFFFFF75BF68FC
	public Single get_focalLength() { }

	// RVA: 0xFFFFFFFF75BF693C
	public Void set_focalLength(Single value) { }

	// RVA: 0xFFFFFFFF75BF698C
	public GateFitMode get_gateFit() { }

	// RVA: 0xFFFFFFFF75BF69CC
	public Void set_gateFit(GateFitMode value) { }

	// RVA: 0xFFFFFFFF75BF6A1C
	public Single GetGateFittedFieldOfView() { }

	// RVA: 0xFFFFFFFF75BF6A5C
	public Vector2 GetGateFittedLensShift() { }

	// RVA: 0xFFFFFFFF75BF6B04
	internal Vector3 GetLocalSpaceAim() { }

	// RVA: 0xFFFFFFFF723B72D4
	public Rect get_rect() { }

	// RVA: 0xFFFFFFFF723B733C
	public Void set_rect(Rect value) { }

	// RVA: 0xFFFFFFFF75BF6C54
	public Rect get_pixelRect() { }

	// RVA: 0xFFFFFFFF75BF6D04
	public Void set_pixelRect(Rect value) { }

	// RVA: 0xFFFFFFFF723B7398
	public Int32 get_pixelWidth() { }

	// RVA: 0xFFFFFFFF723B73DC
	public Int32 get_pixelHeight() { }

	// RVA: 0xFFFFFFFF75BF6DAC
	public Int32 get_scaledPixelWidth() { }

	// RVA: 0xFFFFFFFF75BF6DEC
	public Int32 get_scaledPixelHeight() { }

	// RVA: 0xFFFFFFFF723B7420
	public RenderTexture get_targetTexture() { }

	// RVA: 0xFFFFFFFF723B7474
	public Void set_targetTexture(RenderTexture value) { }

	// RVA: 0xFFFFFFFF75BF6E2C
	public RenderTexture get_activeTexture() { }

	// RVA: 0xFFFFFFFF723B74C8
	public Int32 get_targetDisplay() { }

	// RVA: 0xFFFFFFFF75BF6E6C
	public Void set_targetDisplay(Int32 value) { }

	// RVA: 0xFFFFFFFF75BF6EBC
	private Void SetTargetBuffersImpl(RenderBuffer color, RenderBuffer depth) { }

	// RVA: 0xFFFFFFFF75BF6F70
	public Void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { }

	// RVA: 0xFFFFFFFF75BF6FCC
	private Void SetTargetBuffersMRTImpl(RenderBuffer[] color, RenderBuffer depth) { }

	// RVA: 0xFFFFFFFF75BF7088
	public Void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer) { }

	// RVA: 0xFFFFFFFF75BF70EC
	internal String[] GetCameraBufferWarnings() { }

	// RVA: 0xFFFFFFFF75BF712C
	public Matrix4x4 get_cameraToWorldMatrix() { }

	// RVA: 0xFFFFFFFF723B751C
	public Matrix4x4 get_worldToCameraMatrix() { }

	// RVA: 0xFFFFFFFF723B75E8
	public Void set_worldToCameraMatrix(Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF723B7680
	public Matrix4x4 get_projectionMatrix() { }

	// RVA: 0xFFFFFFFF723B76FC
	public Void set_projectionMatrix(Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75BF7380
	public Matrix4x4 get_nonJitteredProjectionMatrix() { }

	// RVA: 0xFFFFFFFF75BF7448
	public Void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75BF74E8
	public Boolean get_useJitteredProjectionMatrixForTransparentRendering() { }

	// RVA: 0xFFFFFFFF75BF7528
	public Void set_useJitteredProjectionMatrixForTransparentRendering(Boolean value) { }

	// RVA: 0xFFFFFFFF75BF7578
	public Matrix4x4 get_previousViewProjectionMatrix() { }

	// RVA: 0xFFFFFFFF75BF7640
	public Void ResetWorldToCameraMatrix() { }

	// RVA: 0xFFFFFFFF723B7750
	public Void ResetProjectionMatrix() { }

	// RVA: 0xFFFFFFFF75BF7680
	public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane) { }

	// RVA: 0xFFFFFFFF723B7794
	public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0xFFFFFFFF723B7818
	public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0xFFFFFFFF75BF782C
	public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0xFFFFFFFF723B789C
	public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0xFFFFFFFF723B7920
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	// RVA: 0xFFFFFFFF723B79D0
	public Vector3 WorldToViewportPoint(Vector3 position) { }

	// RVA: 0xFFFFFFFF75BF7978
	public Vector3 ViewportToWorldPoint(Vector3 position) { }

	// RVA: 0xFFFFFFFF723B7A80
	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	// RVA: 0xFFFFFFFF75BF79CC
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	// RVA: 0xFFFFFFFF75BF7AC8
	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	// RVA: 0xFFFFFFFF75BF7BC0
	internal Vector2 GetFrustumPlaneSizeAt(Single distance) { }

	// RVA: 0xFFFFFFFF75BF7C88
	private Ray ViewportPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0xFFFFFFFF75BF7D74
	public Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0xFFFFFFFF75BF7E4C
	public Ray ViewportPointToRay(Vector3 pos) { }

	// RVA: 0xFFFFFFFF75BF7EE8
	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0xFFFFFFFF75BF7FD4
	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0xFFFFFFFF75BF809C
	public Ray ScreenPointToRay(Vector3 pos) { }

	// RVA: 0xFFFFFFFF75BF8138
	private Void CalculateFrustumCornersInternal(Rect viewport, Single z, MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	// RVA: 0xFFFFFFFF75BF8230
	public Void CalculateFrustumCorners(Rect viewport, Single z, MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	// RVA: 0xFFFFFFFF75BF8374
	private static Void CalculateProjectionMatrixFromPhysicalPropertiesInternal(out Matrix4x4 output, Single focalLength, Vector2 sensorSize, Vector2 lensShift, Single nearClip, Single farClip, Single gateAspect, GateFitMode gateFitMode) { }

	// RVA: 0xFFFFFFFF75BF84A8
	public static Void CalculateProjectionMatrixFromPhysicalProperties(out Matrix4x4 output, Single focalLength, Vector2 sensorSize, Vector2 lensShift, Single nearClip, Single farClip, GateFitParameters gateFitParameters) { }

	// RVA: 0xFFFFFFFF75BF8544
	public static Single FocalLengthToFieldOfView(Single focalLength, Single sensorSize) { }

	// RVA: 0xFFFFFFFF75BF8590
	public static Single FieldOfViewToFocalLength(Single fieldOfView, Single sensorSize) { }

	// RVA: 0xFFFFFFFF75BF85DC
	public static Single HorizontalToVerticalFieldOfView(Single horizontalFieldOfView, Single aspectRatio) { }

	// RVA: 0xFFFFFFFF75BF8628
	public static Single VerticalToHorizontalFieldOfView(Single verticalFieldOfView, Single aspectRatio) { }

	// RVA: 0xFFFFFFFF723B7B30
	public static Camera get_main() { }

	// RVA: 0xFFFFFFFF75BF8674
	public static Camera get_current() { }

	// RVA: 0xFFFFFFFF75BF86A8
	public Scene get_scene() { }

	// RVA: 0xFFFFFFFF75BF8750
	public Void set_scene(Scene value) { }

	// RVA: 0xFFFFFFFF723B7B6C
	public Boolean get_stereoEnabled() { }

	// RVA: 0xFFFFFFFF75BF87F4
	public Single get_stereoSeparation() { }

	// RVA: 0xFFFFFFFF75BF8834
	public Void set_stereoSeparation(Single value) { }

	// RVA: 0xFFFFFFFF75BF8884
	public Single get_stereoConvergence() { }

	// RVA: 0xFFFFFFFF75BF88C4
	public Void set_stereoConvergence(Single value) { }

	// RVA: 0xFFFFFFFF75BF8914
	public Boolean get_areVRStereoViewMatricesWithinSingleCullTolerance() { }

	// RVA: 0xFFFFFFFF75BF8954
	public StereoTargetEyeMask get_stereoTargetEye() { }

	// RVA: 0xFFFFFFFF75BF8994
	public Void set_stereoTargetEye(StereoTargetEyeMask value) { }

	// RVA: 0xFFFFFFFF75BF89E4
	public MonoOrStereoscopicEye get_stereoActiveEye() { }

	// RVA: 0xFFFFFFFF75BF8A24
	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye) { }

	// RVA: 0xFFFFFFFF75BF8AFC
	public Matrix4x4 GetStereoViewMatrix(StereoscopicEye eye) { }

	// RVA: 0xFFFFFFFF75BF8BD4
	public Void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye) { }

	// RVA: 0xFFFFFFFF75BF8C24
	public Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye) { }

	// RVA: 0xFFFFFFFF75BF8CFC
	public Void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0xFFFFFFFF75BF8DAC
	public Void ResetStereoProjectionMatrices() { }

	// RVA: 0xFFFFFFFF75BF8DEC
	public Void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0xFFFFFFFF75BF8E9C
	public Void ResetStereoViewMatrices() { }

	// RVA: 0xFFFFFFFF75BF8EDC
	private static Int32 GetAllCamerasCount() { }

	// RVA: 0xFFFFFFFF75BF8F10
	private static Int32 GetAllCamerasImpl([Out] Camera[] cam) { }

	// RVA: 0xFFFFFFFF723B7BC0
	public static Int32 get_allCamerasCount() { }

	// RVA: 0xFFFFFFFF723B7BFC
	public static Camera[] get_allCameras() { }

	// RVA: 0xFFFFFFFF723B7C80
	public static Int32 GetAllCameras(Camera[] cameras) { }

	// RVA: 0xFFFFFFFF75BF8F50
	private Boolean RenderToCubemapImpl(Texture tex, Int32 faceMask) { }

	// RVA: 0xFFFFFFFF75BF8FA8
	public Boolean RenderToCubemap(Cubemap cubemap, Int32 faceMask) { }

	// RVA: 0xFFFFFFFF75BF9000
	public Boolean RenderToCubemap(Cubemap cubemap) { }

	// RVA: 0xFFFFFFFF75BF9054
	public Boolean RenderToCubemap(RenderTexture cubemap, Int32 faceMask) { }

	// RVA: 0xFFFFFFFF75BF90AC
	public Boolean RenderToCubemap(RenderTexture cubemap) { }

	// RVA: 0xFFFFFFFF75BF9100
	private Boolean RenderToCubemapEyeImpl(RenderTexture cubemap, Int32 faceMask, MonoOrStereoscopicEye stereoEye) { }

	// RVA: 0xFFFFFFFF75BF9168
	public Boolean RenderToCubemap(RenderTexture cubemap, Int32 faceMask, MonoOrStereoscopicEye stereoEye) { }

	// RVA: 0xFFFFFFFF723B7D80
	public Void Render() { }

	// RVA: 0xFFFFFFFF75BF91D0
	public Void RenderWithShader(Shader shader, String replacementTag) { }

	// RVA: 0xFFFFFFFF75BF9228
	public Void RenderDontRestore() { }

	// RVA: 0xFFFFFFFF75BF9268
	public static Void SetupCurrent(Camera cur) { }

	// RVA: 0xFFFFFFFF75BF92A8
	public Void CopyFrom(Camera other) { }

	// RVA: 0xFFFFFFFF75BF92F8
	public Int32 get_commandBufferCount() { }

	// RVA: 0xFFFFFFFF75BF9338
	public Void RemoveCommandBuffers(CameraEvent evt) { }

	// RVA: 0xFFFFFFFF75BF9388
	public Void RemoveAllCommandBuffers() { }

	// RVA: 0xFFFFFFFF75BF93C8
	private Void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0xFFFFFFFF75BF9420
	private Void AddCommandBufferAsyncImpl(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	// RVA: 0xFFFFFFFF75BF9488
	private Void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0xFFFFFFFF723B7DD4
	public Void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0xFFFFFFFF75BF94E0
	public Void AddCommandBufferAsync(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	// RVA: 0xFFFFFFFF723B7F10
	public Void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0xFFFFFFFF75BF9624
	public CommandBuffer[] GetCommandBuffers(CameraEvent evt) { }

	// RVA: 0xFFFFFFFF723B804C
	private static Void FireOnPreCull(Camera cam) { }

	// RVA: 0xFFFFFFFF723B83F0
	private static Void FireOnPreRender(Camera cam) { }

	// RVA: 0xFFFFFFFF723B8410
	private static Void FireOnPostRender(Camera cam) { }

	// RVA: 0xFFFFFFFF75BF9674
	internal Void OnlyUsedForTesting1() { }

	// RVA: 0xFFFFFFFF75BF9678
	internal Void OnlyUsedForTesting2() { }

	// RVA: 0xFFFFFFFF75BF967C
	public Boolean TryGetCullingParameters(out ScriptableCullingParameters cullingParameters) { }

	// RVA: 0xFFFFFFFF75BF973C
	public Boolean TryGetCullingParameters(Boolean stereoAware, out ScriptableCullingParameters cullingParameters) { }

	// RVA: 0xFFFFFFFF75BF96D4
	private static Boolean GetCullingParameters_Internal(Camera camera, Boolean stereoAware, out ScriptableCullingParameters cullingParameters, Int32 managedCullingParametersSize) { }

	// RVA: 0xFFFFFFFF75BF9798
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BF5AC8
	private Void get_transparencySortAxis_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75BF5B70
	private Void set_transparencySortAxis_Injected(ref Vector3 value) { }

	// RVA: 0xFFFFFFFF75BF5CF4
	private Void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75BF6258
	private Void get_cullingMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75BF62F8
	private Void set_cullingMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75BF6388
	private Void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0xFFFFFFFF75BF63D8
	private Void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0xFFFFFFFF75BF66BC
	private Void get_sensorSize_Injected(out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75BF6760
	private Void set_sensorSize_Injected(ref Vector2 value) { }

	// RVA: 0xFFFFFFFF75BF6808
	private Void get_lensShift_Injected(out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75BF68AC
	private Void set_lensShift_Injected(ref Vector2 value) { }

	// RVA: 0xFFFFFFFF75BF6AB4
	private Void GetGateFittedLensShift_Injected(out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75BF6B64
	private Void GetLocalSpaceAim_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75BF6BB4
	private Void get_rect_Injected(out Rect ret) { }

	// RVA: 0xFFFFFFFF75BF6C04
	private Void set_rect_Injected(ref Rect value) { }

	// RVA: 0xFFFFFFFF75BF6CB4
	private Void get_pixelRect_Injected(out Rect ret) { }

	// RVA: 0xFFFFFFFF75BF6D5C
	private Void set_pixelRect_Injected(ref Rect value) { }

	// RVA: 0xFFFFFFFF75BF6F18
	private Void SetTargetBuffersImpl_Injected(ref RenderBuffer color, ref RenderBuffer depth) { }

	// RVA: 0xFFFFFFFF75BF7030
	private Void SetTargetBuffersMRTImpl_Injected(RenderBuffer[] color, ref RenderBuffer depth) { }

	// RVA: 0xFFFFFFFF75BF71F0
	private Void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75BF7240
	private Void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75BF7290
	private Void set_worldToCameraMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75BF72E0
	private Void get_projectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75BF7330
	private Void set_projectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75BF73F8
	private Void get_nonJitteredProjectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75BF7498
	private Void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75BF75F0
	private Void get_previousViewProjectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75BF7704
	private Void CalculateObliqueMatrix_Injected(ref Vector4 clipPlane, out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75BF775C
	private Void WorldToScreenPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75BF77C4
	private Void WorldToViewportPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75BF78A8
	private Void ViewportToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75BF7910
	private Void ScreenToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75BF7A70
	private Void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75BF7B68
	private Void ViewportToScreenPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75BF7C28
	private Void GetFrustumPlaneSizeAt_Injected(Single distance, out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75BF7D0C
	private Void ViewportPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0xFFFFFFFF75BF7F6C
	private Void ScreenPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0xFFFFFFFF75BF81B8
	private Void CalculateFrustumCornersInternal_Injected(ref Rect viewport, Single z, MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	// RVA: 0xFFFFFFFF75BF8410
	private static Void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out Matrix4x4 output, Single focalLength, ref Vector2 sensorSize, ref Vector2 lensShift, Single nearClip, Single farClip, Single gateAspect, GateFitMode gateFitMode) { }

	// RVA: 0xFFFFFFFF75BF8700
	private Void get_scene_Injected(out Scene ret) { }

	// RVA: 0xFFFFFFFF75BF87A4
	private Void set_scene_Injected(ref Scene value) { }

	// RVA: 0xFFFFFFFF75BF8AA4
	private Void GetStereoNonJitteredProjectionMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75BF8B7C
	private Void GetStereoViewMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75BF8CA4
	private Void GetStereoProjectionMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75BF8D54
	private Void SetStereoProjectionMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix) { }

	// RVA: 0xFFFFFFFF75BF8E44
	private Void SetStereoViewMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix) { }

}

// Namespace: 
internal enum ProjectionMatrixMode
{
	// Fields
	public Int32 value__; // 0x10
	public const ProjectionMatrixMode Explicit = 0;
	public const ProjectionMatrixMode Implicit = 1;
	public const ProjectionMatrixMode PhysicalPropertiesBased = 2;
}

// Namespace: 
public enum GateFitMode
{
	// Fields
	public Int32 value__; // 0x10
	public const GateFitMode Vertical = 1;
	public const GateFitMode Horizontal = 2;
	public const GateFitMode Fill = 3;
	public const GateFitMode Overscan = 4;
	public const GateFitMode None = 0;
}

// Namespace: 
public struct GateFitParameters
{
	// Fields
	private GateFitMode <mode>k__BackingField; // 0x10
	private Single <aspect>k__BackingField; // 0x14

	// Properties
	public GateFitMode mode { get; }
	public Single aspect { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114B5A8
	public GateFitMode get_mode() { }

	// RVA: 0xFFFFFFFF7114B5B0
	public Single get_aspect() { }

}

// Namespace: 
public enum StereoscopicEye
{
	// Fields
	public Int32 value__; // 0x10
	public const StereoscopicEye Left = 0;
	public const StereoscopicEye Right = 1;
}

// Namespace: 
public enum MonoOrStereoscopicEye
{
	// Fields
	public Int32 value__; // 0x10
	public const MonoOrStereoscopicEye Left = 0;
	public const MonoOrStereoscopicEye Right = 1;
	public const MonoOrStereoscopicEye Mono = 2;
}

// Namespace: 
public sealed class CameraCallback
{
	// Methods

	// RVA: 0xFFFFFFFF723B8430
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF723B806C
	public virtual Void Invoke(Camera cam) { }

	// RVA: 0xFFFFFFFF75BF97B8
	public virtual IAsyncResult BeginInvoke(Camera cam, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BF9808
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine
public struct CullingGroupEvent
{
	// Fields
	private Int32 m_Index; // 0x10
	private Byte m_PrevState; // 0x14
	private Byte m_ThisState; // 0x15
}

// Namespace: UnityEngine
public class CullingGroup
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private StateChanged m_OnStateChanged; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75BFC7E4
	private static Void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, Int32 count) { }

}

// Namespace: 
public sealed class StateChanged
{
	// Methods

	// RVA: 0xFFFFFFFF75BFCA98
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75BFC840
	public virtual Void Invoke(CullingGroupEvent sphere) { }

	// RVA: 0xFFFFFFFF75BFCADC
	public virtual IAsyncResult BeginInvoke(CullingGroupEvent sphere, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BFCB8C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine
public class FlareLayer
{
	// Methods

	// RVA: 0xFFFFFFFF75C02E9C
	internal Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class ReflectionProbe
{
	// Fields
	private static Action<T0, T1> reflectionProbeChanged; // 0x0
	private static Action<T0> defaultReflectionSet; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75C24C48
	private static Void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbeEvent probeEvent) { }

	// RVA: 0xFFFFFFFF723C6570
	private static Void CallSetDefaultReflection(Cubemap defaultReflectionCubemap) { }

}

// Namespace: 
public enum ReflectionProbeEvent
{
	// Fields
	public Int32 value__; // 0x10
	public const ReflectionProbeEvent ReflectionProbeAdded = 0;
	public const ReflectionProbeEvent ReflectionProbeRemoved = 1;
}

// Namespace: UnityEngine
internal sealed class DebugLogHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75BFE764
	internal static Void Internal_Log(LogType level, LogOption options, String msg, Object obj) { }

	// RVA: 0xFFFFFFFF75BFE7CC
	internal static Void Internal_LogException(Exception exception, Object obj) { }

	// RVA: 0xFFFFFFFF723B95FC
	public Void LogFormat(LogType logType, Object context, String format, Object[] args) { }

	// RVA: 0xFFFFFFFF75BFD73C
	public Void LogFormat(LogType logType, LogOption logOptions, Object context, String format, Object[] args) { }

	// RVA: 0xFFFFFFFF75BFE81C
	public Void LogException(Exception exception, Object context) { }

	// RVA: 0xFFFFFFFF75BFE760
	public Void .ctor() { }

}

// Namespace: UnityEngine
public class Debug
{
	// Fields
	internal static readonly ILogger s_DefaultLogger; // 0x0
	internal static ILogger s_Logger; // 0x8

	// Properties
	public static ILogger unityLogger { get; }
	public static Boolean developerConsoleVisible { get; set; }
	public static Boolean isDebugBuild { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BFCBD0
	public static ILogger get_unityLogger() { }

	// RVA: 0xFFFFFFFF75BFCC10
	public static Void DrawLine(Vector3 start, Vector3 end, Color color, Single duration) { }

	// RVA: 0xFFFFFFFF75BFCD44
	public static Void DrawLine(Vector3 start, Vector3 end, Color color) { }

	// RVA: 0xFFFFFFFF75BFCDDC
	public static Void DrawLine(Vector3 start, Vector3 end) { }

	// RVA: 0xFFFFFFFF75BFCCA8
	public static Void DrawLine(Vector3 start, Vector3 end, Color color, Single duration, Boolean depthTest) { }

	// RVA: 0xFFFFFFFF75BFCEE4
	public static Void DrawRay(Vector3 start, Vector3 dir, Color color, Single duration) { }

	// RVA: 0xFFFFFFFF75BFD05C
	public static Void DrawRay(Vector3 start, Vector3 dir, Color color) { }

	// RVA: 0xFFFFFFFF75BFD0F4
	public static Void DrawRay(Vector3 start, Vector3 dir) { }

	// RVA: 0xFFFFFFFF75BFCF7C
	public static Void DrawRay(Vector3 start, Vector3 dir, Color color, Single duration, Boolean depthTest) { }

	// RVA: 0xFFFFFFFF75BFD184
	public static Void Break() { }

	// RVA: 0xFFFFFFFF75BFD1B8
	public static Void DebugBreak() { }

	// RVA: 0xFFFFFFFF723B94B8
	public static Int32 ExtractStackTraceNoAlloc(Byte* buffer, Int32 bufferMax, String projectFolder) { }

	// RVA: 0xFFFFFFFF723B9514
	public static Void Log(Object message) { }

	// RVA: 0xFFFFFFFF75BFD1EC
	public static Void Log(Object message, Object context) { }

	// RVA: 0xFFFFFFFF75BFD2CC
	public static Void LogFormat(String format, Object[] args) { }

	// RVA: 0xFFFFFFFF75BFD3C0
	public static Void LogFormat(Object context, String format, Object[] args) { }

	// RVA: 0xFFFFFFFF75BFD4A4
	public static Void LogFormat(LogType logType, LogOption logOptions, Object context, String format, Object[] args) { }

	// RVA: 0xFFFFFFFF75BFD7B4
	public static Void LogError(Object message) { }

	// RVA: 0xFFFFFFFF75BFD89C
	public static Void LogError(Object message, Object context) { }

	// RVA: 0xFFFFFFFF75BFD97C
	public static Void LogErrorFormat(String format, Object[] args) { }

	// RVA: 0xFFFFFFFF75BFDA5C
	public static Void LogErrorFormat(Object context, String format, Object[] args) { }

	// RVA: 0xFFFFFFFF75BFDB40
	public static Void ClearDeveloperConsole() { }

	// RVA: 0xFFFFFFFF75BFDB74
	public static Boolean get_developerConsoleVisible() { }

	// RVA: 0xFFFFFFFF75BFDBA8
	public static Void set_developerConsoleVisible(Boolean value) { }

	// RVA: 0xFFFFFFFF75BF28BC
	public static Void LogException(Exception exception) { }

	// RVA: 0xFFFFFFFF75BFDBE8
	public static Void LogException(Exception exception, Object context) { }

	// RVA: 0xFFFFFFFF723B9344
	public static Void LogWarning(Object message) { }

	// RVA: 0xFFFFFFFF75BFDCC4
	public static Void LogWarning(Object message, Object context) { }

	// RVA: 0xFFFFFFFF75BFDDA4
	public static Void LogWarningFormat(String format, Object[] args) { }

	// RVA: 0xFFFFFFFF75BFDE84
	public static Void LogWarningFormat(Object context, String format, Object[] args) { }

	// RVA: 0xFFFFFFFF75BFDF68
	public static Void Assert(Boolean condition) { }

	// RVA: 0xFFFFFFFF75BFE070
	public static Void Assert(Boolean condition, String message) { }

	// RVA: 0xFFFFFFFF75BF3484
	public static Void LogAssertion(Object message) { }

	// RVA: 0xFFFFFFFF75BFE150
	public static Boolean get_isDebugBuild() { }

	// RVA: 0xFFFFFFFF75BFE188
	internal static Boolean CallOverridenDebugHandler(Exception exception, Object obj) { }

	// RVA: 0xFFFFFFFF75BFE4EC
	internal static Boolean IsLoggingEnabled() { }

	// RVA: 0xFFFFFFFF75BFE694
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BFE698
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75BFCE6C
	private static Void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, Single duration, Boolean depthTest) { }

}

// Namespace: UnityEngine
public struct ExposedReference<T0>
{
	// Fields
	public PropertyName exposedName; // 0x0
	public Object defaultValue; // 0x0

	// Methods

	// RVA: -1
	public T Resolve(IExposedPropertyTable resolver) { }

}

// Namespace: UnityEngine
public interface IExposedPropertyTable
{
	// Methods

	// RVA: -1
	public abstract Object GetReferenceValue(PropertyName id, out Boolean idValid) { }

}

// Namespace: UnityEngine
public struct Bounds
{
	// Fields
	private Vector3 m_Center; // 0x10
	private Vector3 m_Extents; // 0x1C

	// Properties
	public Vector3 center { get; set; }
	public Vector3 size { get; set; }
	public Vector3 extents { get; set; }
	public Vector3 min { get; set; }
	public Vector3 max { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF7114B164
	public Void .ctor(Vector3 center, Vector3 size) { }

	// RVA: 0xFFFFFFFF7114B16C
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114B174
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF7114B17C
	public Boolean Equals(Bounds other) { }

	// RVA: 0xFFFFFFFF7114B1B0
	public Vector3 get_center() { }

	// RVA: 0xFFFFFFFF7114B1BC
	public Void set_center(Vector3 value) { }

	// RVA: 0xFFFFFFFF7114B1C8
	public Vector3 get_size() { }

	// RVA: 0xFFFFFFFF7114B1D0
	public Void set_size(Vector3 value) { }

	// RVA: 0xFFFFFFFF7114B1D8
	public Vector3 get_extents() { }

	// RVA: 0xFFFFFFFF7114B1E4
	public Void set_extents(Vector3 value) { }

	// RVA: 0xFFFFFFFF7114B1F0
	public Vector3 get_min() { }

	// RVA: 0xFFFFFFFF7114B1F8
	public Void set_min(Vector3 value) { }

	// RVA: 0xFFFFFFFF7114B254
	public Vector3 get_max() { }

	// RVA: 0xFFFFFFFF7114B25C
	public Void set_max(Vector3 value) { }

	// RVA: 0xFFFFFFFF75BF4E20
	public static Boolean op_Equality(Bounds lhs, Bounds rhs) { }

	// RVA: 0xFFFFFFFF75BF4ED4
	public static Boolean op_Inequality(Bounds lhs, Bounds rhs) { }

	// RVA: 0xFFFFFFFF7114B2AC
	public Void SetMinMax(Vector3 min, Vector3 max) { }

	// RVA: 0xFFFFFFFF7114B2B4
	public Void Encapsulate(Vector3 point) { }

	// RVA: 0xFFFFFFFF7114B2BC
	public Void Encapsulate(Bounds bounds) { }

	// RVA: 0xFFFFFFFF7114B2F0
	public Void Expand(Single amount) { }

	// RVA: 0xFFFFFFFF7114B2F8
	public Void Expand(Vector3 amount) { }

	// RVA: 0xFFFFFFFF7114B300
	public Boolean Intersects(Bounds bounds) { }

	// RVA: 0xFFFFFFFF7114B334
	public Boolean IntersectRay(Ray ray) { }

	// RVA: 0xFFFFFFFF7114B368
	public Boolean IntersectRay(Ray ray, out Single distance) { }

	// RVA: 0xFFFFFFFF7114B3DC
	public override String ToString() { }

	// RVA: 0xFFFFFFFF7114B3E4
	public String ToString(String format) { }

	// RVA: 0xFFFFFFFF7114B3EC
	public Boolean Contains(Vector3 point) { }

	// RVA: 0xFFFFFFFF7114B444
	public Single SqrDistance(Vector3 point) { }

	// RVA: 0xFFFFFFFF75BF5178
	private static Boolean IntersectRayAABB(Ray ray, Bounds bounds, out Single dist) { }

	// RVA: 0xFFFFFFFF7114B49C
	public Vector3 ClosestPoint(Vector3 point) { }

	// RVA: 0xFFFFFFFF75BF5448
	private static Boolean Contains_Injected(ref Bounds _unity_self, ref Vector3 point) { }

	// RVA: 0xFFFFFFFF75BF54F0
	private static Single SqrDistance_Injected(ref Bounds _unity_self, ref Vector3 point) { }

	// RVA: 0xFFFFFFFF75BF5540
	private static Boolean IntersectRayAABB_Injected(ref Ray ray, ref Bounds bounds, out Single dist) { }

	// RVA: 0xFFFFFFFF75BF5604
	private static Void ClosestPoint_Injected(ref Bounds _unity_self, ref Vector3 point, out Vector3 ret) { }

}

// Namespace: UnityEngine
public sealed class GeometryUtility
{
	// Methods

	// RVA: 0xFFFFFFFF75C03F0C
	public static Plane[] CalculateFrustumPlanes(Camera camera) { }

	// RVA: 0xFFFFFFFF723BA1CC
	public static Void CalculateFrustumPlanes(Camera camera, Plane[] planes) { }

	// RVA: 0xFFFFFFFF75C03F6C
	public static Void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Plane[] planes) { }

	// RVA: 0xFFFFFFFF75C040CC
	public static Boolean TestPlanesAABB(Plane[] planes, Bounds bounds) { }

	// RVA: 0xFFFFFFFF75C0407C
	private static Void Internal_ExtractPlanes([Out] Plane[] planes, Matrix4x4 worldToProjectionMatrix) { }

	// RVA: 0xFFFFFFFF75C0411C
	private static Boolean TestPlanesAABB_Injected(Plane[] planes, ref Bounds bounds) { }

	// RVA: 0xFFFFFFFF75C0416C
	private static Void Internal_ExtractPlanes_Injected([Out] Plane[] planes, ref Matrix4x4 worldToProjectionMatrix) { }

}

// Namespace: UnityEngine
public struct Plane
{
	// Fields
	internal const Int32 size = 16;
	private Vector3 m_Normal; // 0x10
	private Single m_Distance; // 0x1C

	// Properties
	public Vector3 normal { get; set; }
	public Single distance { get; set; }
	public Plane flipped { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114C56C
	public Vector3 get_normal() { }

	// RVA: 0xFFFFFFFF7114C578
	public Void set_normal(Vector3 value) { }

	// RVA: 0xFFFFFFFF7114C584
	public Single get_distance() { }

	// RVA: 0xFFFFFFFF7114C58C
	public Void set_distance(Single value) { }

	// RVA: 0xFFFFFFFF7114C594
	public Void .ctor(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0xFFFFFFFF7114C59C
	public Void .ctor(Vector3 inNormal, Single d) { }

	// RVA: 0xFFFFFFFF7114C5A4
	public Void .ctor(Vector3 a, Vector3 b, Vector3 c) { }

	// RVA: 0xFFFFFFFF7114C5BC
	public Void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0xFFFFFFFF7114C5C4
	public Void Set3Points(Vector3 a, Vector3 b, Vector3 c) { }

	// RVA: 0xFFFFFFFF7114C5DC
	public Void Flip() { }

	// RVA: 0xFFFFFFFF7114C5E4
	public Plane get_flipped() { }

	// RVA: 0xFFFFFFFF7114C5EC
	public Void Translate(Vector3 translation) { }

	// RVA: 0xFFFFFFFF75C1C98C
	public static Plane Translate(Plane plane, Vector3 translation) { }

	// RVA: 0xFFFFFFFF7114C5F4
	public Vector3 ClosestPointOnPlane(Vector3 point) { }

	// RVA: 0xFFFFFFFF7114C5FC
	public Single GetDistanceToPoint(Vector3 point) { }

	// RVA: 0xFFFFFFFF7114C604
	public Boolean GetSide(Vector3 point) { }

	// RVA: 0xFFFFFFFF7114C60C
	public Boolean SameSide(Vector3 inPt0, Vector3 inPt1) { }

	// RVA: 0xFFFFFFFF7114C614
	public Boolean Raycast(Ray ray, out Single enter) { }

	// RVA: 0xFFFFFFFF7114C648
	public override String ToString() { }

	// RVA: 0xFFFFFFFF7114C650
	public String ToString(String format) { }

}

// Namespace: UnityEngine
public struct Ray
{
	// Fields
	private Vector3 m_Origin; // 0x10
	private Vector3 m_Direction; // 0x1C

	// Properties
	public Vector3 origin { get; set; }
	public Vector3 direction { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF7114CFB8
	public Void .ctor(Vector3 origin, Vector3 direction) { }

	// RVA: 0xFFFFFFFF7114D000
	public Vector3 get_origin() { }

	// RVA: 0xFFFFFFFF7114D00C
	public Void set_origin(Vector3 value) { }

	// RVA: 0xFFFFFFFF7114D018
	public Vector3 get_direction() { }

	// RVA: 0xFFFFFFFF7114D024
	public Void set_direction(Vector3 value) { }

	// RVA: 0xFFFFFFFF7114D064
	public Vector3 GetPoint(Single distance) { }

	// RVA: 0xFFFFFFFF7114D06C
	public override String ToString() { }

}

// Namespace: UnityEngine
public struct Ray2D
{
	// Fields
	private Vector2 m_Origin; // 0x10
	private Vector2 m_Direction; // 0x18

	// Properties
	public Vector2 origin { get; set; }
	public Vector2 direction { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF7114D074
	public Vector2 get_origin() { }

	// RVA: 0xFFFFFFFF7114D07C
	public Void set_origin(Vector2 value) { }

	// RVA: 0xFFFFFFFF7114D084
	public Vector2 get_direction() { }

	// RVA: 0xFFFFFFFF7114D08C
	public Void set_direction(Vector2 value) { }

	// RVA: 0xFFFFFFFF7114D0C4
	public override String ToString() { }

}

// Namespace: UnityEngine
public struct Rect
{
	// Fields
	private Single m_XMin; // 0x10
	private Single m_YMin; // 0x14
	private Single m_Width; // 0x18
	private Single m_Height; // 0x1C

	// Properties
	public static Rect zero { get; }
	public Single x { get; set; }
	public Single y { get; set; }
	public Vector2 position { get; set; }
	public Vector2 center { get; set; }
	public Vector2 min { get; set; }
	public Vector2 max { get; set; }
	public Single width { get; set; }
	public Single height { get; set; }
	public Vector2 size { get; set; }
	public Single xMin { get; set; }
	public Single yMin { get; set; }
	public Single xMax { get; set; }
	public Single yMax { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF7114D0CC
	public Void .ctor(Single x, Single y, Single width, Single height) { }

	// RVA: 0xFFFFFFFF7114D0D8
	public Void .ctor(Vector2 position, Vector2 size) { }

	// RVA: 0xFFFFFFFF7114D0E4
	public Void .ctor(Rect source) { }

	// RVA: 0xFFFFFFFF75C21A24
	public static Rect get_zero() { }

	// RVA: 0xFFFFFFFF75C21A38
	public static Rect MinMaxRect(Single xmin, Single ymin, Single xmax, Single ymax) { }

	// RVA: 0xFFFFFFFF7114D0F0
	public Void Set(Single x, Single y, Single width, Single height) { }

	// RVA: 0xFFFFFFFF7114D0FC
	public Single get_x() { }

	// RVA: 0xFFFFFFFF7114D104
	public Void set_x(Single value) { }

	// RVA: 0xFFFFFFFF7114D10C
	public Single get_y() { }

	// RVA: 0xFFFFFFFF7114D114
	public Void set_y(Single value) { }

	// RVA: 0xFFFFFFFF7114D11C
	public Vector2 get_position() { }

	// RVA: 0xFFFFFFFF7114D124
	public Void set_position(Vector2 value) { }

	// RVA: 0xFFFFFFFF7114D12C
	public Vector2 get_center() { }

	// RVA: 0xFFFFFFFF7114D144
	public Void set_center(Vector2 value) { }

	// RVA: 0xFFFFFFFF7114D160
	public Vector2 get_min() { }

	// RVA: 0xFFFFFFFF7114D168
	public Void set_min(Vector2 value) { }

	// RVA: 0xFFFFFFFF7114D184
	public Vector2 get_max() { }

	// RVA: 0xFFFFFFFF7114D198
	public Void set_max(Vector2 value) { }

	// RVA: 0xFFFFFFFF7114D1AC
	public Single get_width() { }

	// RVA: 0xFFFFFFFF7114D1B4
	public Void set_width(Single value) { }

	// RVA: 0xFFFFFFFF7114D1BC
	public Single get_height() { }

	// RVA: 0xFFFFFFFF7114D1C4
	public Void set_height(Single value) { }

	// RVA: 0xFFFFFFFF7114D1CC
	public Vector2 get_size() { }

	// RVA: 0xFFFFFFFF7114D1D4
	public Void set_size(Vector2 value) { }

	// RVA: 0xFFFFFFFF7114D1DC
	public Single get_xMin() { }

	// RVA: 0xFFFFFFFF7114D1E4
	public Void set_xMin(Single value) { }

	// RVA: 0xFFFFFFFF7114D200
	public Single get_yMin() { }

	// RVA: 0xFFFFFFFF7114D208
	public Void set_yMin(Single value) { }

	// RVA: 0xFFFFFFFF7114D224
	public Single get_xMax() { }

	// RVA: 0xFFFFFFFF7114D234
	public Void set_xMax(Single value) { }

	// RVA: 0xFFFFFFFF7114D244
	public Single get_yMax() { }

	// RVA: 0xFFFFFFFF7114D254
	public Void set_yMax(Single value) { }

	// RVA: 0xFFFFFFFF7114D264
	public Boolean Contains(Vector2 point) { }

	// RVA: 0xFFFFFFFF7114D2A8
	public Boolean Contains(Vector3 point) { }

	// RVA: 0xFFFFFFFF7114D2EC
	public Boolean Contains(Vector3 point, Boolean allowInverse) { }

	// RVA: 0xFFFFFFFF75C21BD8
	private static Rect OrderMinMax(Rect rect) { }

	// RVA: 0xFFFFFFFF7114D2F4
	public Boolean Overlaps(Rect other) { }

	// RVA: 0xFFFFFFFF7114D340
	public Boolean Overlaps(Rect other, Boolean allowInverse) { }

	// RVA: 0xFFFFFFFF75C21C94
	public static Vector2 NormalizedToPoint(Rect rectangle, Vector2 normalizedRectCoordinates) { }

	// RVA: 0xFFFFFFFF75C21D24
	public static Vector2 PointToNormalized(Rect rectangle, Vector2 point) { }

	// RVA: 0xFFFFFFFF723C6330
	public static Boolean op_Inequality(Rect lhs, Rect rhs) { }

	// RVA: 0xFFFFFFFF723C6354
	public static Boolean op_Equality(Rect lhs, Rect rhs) { }

	// RVA: 0xFFFFFFFF7114D348
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114D350
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF7114D358
	public Boolean Equals(Rect other) { }

	// RVA: 0xFFFFFFFF7114D360
	public override String ToString() { }

	// RVA: 0xFFFFFFFF7114D368
	public String ToString(String format) { }

}

// Namespace: UnityEngine
public struct RectInt
{
	// Fields
	private Int32 m_XMin; // 0x10
	private Int32 m_YMin; // 0x14
	private Int32 m_Width; // 0x18
	private Int32 m_Height; // 0x1C

	// Properties
	public Int32 x { get; }
	public Int32 y { get; }
	public Int32 width { get; }
	public Int32 height { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114D370
	public Int32 get_x() { }

	// RVA: 0xFFFFFFFF7114D378
	public Int32 get_y() { }

	// RVA: 0xFFFFFFFF7114D380
	public Int32 get_width() { }

	// RVA: 0xFFFFFFFF7114D388
	public Int32 get_height() { }

	// RVA: 0xFFFFFFFF7114D390
	public override String ToString() { }

	// RVA: 0xFFFFFFFF7114D398
	public Boolean Equals(RectInt other) { }

}

// Namespace: UnityEngine
public class RectOffset
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly Object m_SourceStyle; // 0x18

	// Properties
	public Int32 left { get; set; }
	public Int32 right { get; set; }
	public Int32 top { get; set; }
	public Int32 bottom { get; set; }
	public Int32 horizontal { get; }
	public Int32 vertical { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C22438
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C224AC
	internal Void .ctor(Object sourceStyle, IntPtr source) { }

	// RVA: 0xFFFFFFFF75C224F4
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75C225A8
	public Void .ctor(Int32 left, Int32 right, Int32 top, Int32 bottom) { }

	// RVA: 0xFFFFFFFF75C227F4
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75C22540
	private Void Destroy() { }

	// RVA: 0xFFFFFFFF75C22478
	private static IntPtr InternalCreate() { }

	// RVA: 0xFFFFFFFF75C229BC
	private static Void InternalDestroy(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF723C6378
	public Int32 get_left() { }

	// RVA: 0xFFFFFFFF75C226B4
	public Void set_left(Int32 value) { }

	// RVA: 0xFFFFFFFF723C63CC
	public Int32 get_right() { }

	// RVA: 0xFFFFFFFF75C22704
	public Void set_right(Int32 value) { }

	// RVA: 0xFFFFFFFF723C6420
	public Int32 get_top() { }

	// RVA: 0xFFFFFFFF75C22754
	public Void set_top(Int32 value) { }

	// RVA: 0xFFFFFFFF723C6474
	public Int32 get_bottom() { }

	// RVA: 0xFFFFFFFF75C227A4
	public Void set_bottom(Int32 value) { }

	// RVA: 0xFFFFFFFF723C64C8
	public Int32 get_horizontal() { }

	// RVA: 0xFFFFFFFF723C651C
	public Int32 get_vertical() { }

	// RVA: 0xFFFFFFFF75C229FC
	public Rect Add(Rect rect) { }

	// RVA: 0xFFFFFFFF75C22ABC
	public Rect Remove(Rect rect) { }

	// RVA: 0xFFFFFFFF75C22A64
	private Void Add_Injected(ref Rect rect, out Rect ret) { }

	// RVA: 0xFFFFFFFF75C22B24
	private Void Remove_Injected(ref Rect rect, out Rect ret) { }

}

// Namespace: UnityEngine
public sealed class Gizmos
{
	// Properties
	public static Color color { set; }
	public static Matrix4x4 matrix { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C041BC
	public static Void DrawLine(Vector3 from, Vector3 to) { }

	// RVA: 0xFFFFFFFF75C04268
	public static Void DrawWireSphere(Vector3 center, Single radius) { }

	// RVA: 0xFFFFFFFF75C04318
	public static Void DrawSphere(Vector3 center, Single radius) { }

	// RVA: 0xFFFFFFFF75C043C8
	public static Void DrawWireCube(Vector3 center, Vector3 size) { }

	// RVA: 0xFFFFFFFF75C04474
	public static Void DrawCube(Vector3 center, Vector3 size) { }

	// RVA: 0xFFFFFFFF75C04520
	public static Void DrawIcon(Vector3 center, String name, Boolean allowScaling) { }

	// RVA: 0xFFFFFFFF75C04534
	public static Void DrawIcon(Vector3 center, String name, Boolean allowScaling, Color tint) { }

	// RVA: 0xFFFFFFFF75C04610
	public static Void set_color(Color value) { }

	// RVA: 0xFFFFFFFF75C046A0
	public static Void set_matrix(Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75C04720
	public static Void DrawIcon(Vector3 center, String name) { }

	// RVA: 0xFFFFFFFF75C04218
	private static Void DrawLine_Injected(ref Vector3 from, ref Vector3 to) { }

	// RVA: 0xFFFFFFFF75C042C8
	private static Void DrawWireSphere_Injected(ref Vector3 center, Single radius) { }

	// RVA: 0xFFFFFFFF75C04378
	private static Void DrawSphere_Injected(ref Vector3 center, Single radius) { }

	// RVA: 0xFFFFFFFF75C04424
	private static Void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0xFFFFFFFF75C044D0
	private static Void DrawCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0xFFFFFFFF75C045A8
	private static Void DrawIcon_Injected(ref Vector3 center, String name, Boolean allowScaling, ref Color tint) { }

	// RVA: 0xFFFFFFFF75C04660
	private static Void set_color_Injected(ref Color value) { }

	// RVA: 0xFFFFFFFF75C046E0
	private static Void set_matrix_Injected(ref Matrix4x4 value) { }

}

// Namespace: UnityEngine
public class BeforeRenderOrderAttribute
{
	// Fields
	private Int32 <order>k__BackingField; // 0x10

	// Properties
	public Int32 order { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BF47D4
	public Int32 get_order() { }

}

// Namespace: UnityEngine
internal static class BeforeRenderHelper
{
	// Fields
	private static List<T0> s_OrderBlocks; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75BF446C
	private static Int32 GetUpdateOrder(UnityAction callback) { }

	// RVA: 0xFFFFFFFF75BF1C44
	public static Void RegisterCallback(UnityAction callback) { }

	// RVA: 0xFFFFFFFF75BF1F78
	public static Void UnregisterCallback(UnityAction callback) { }

	// RVA: 0xFFFFFFFF723B5E78
	public static Void Invoke() { }

	// RVA: 0xFFFFFFFF75BF4778
	private static Void .cctor() { }

}

// Namespace: 
private struct OrderBlock
{
	// Fields
	internal Int32 order; // 0x10
	internal UnityAction callback; // 0x18
}

// Namespace: UnityEngine
public class Display
{
	// Fields
	internal IntPtr nativeDisplay; // 0x10
	public static Display[] displays; // 0x0
	private static Display _mainDisplay; // 0x8
	private static DisplaysUpdatedDelegate onDisplaysUpdated; // 0x10

	// Properties
	public Int32 renderingWidth { get; }
	public Int32 renderingHeight { get; }
	public Int32 systemWidth { get; }
	public Int32 systemHeight { get; }
	public RenderBuffer colorBuffer { get; }
	public static Display main { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BFE8F4
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75BFE934
	internal Void .ctor(IntPtr nativeDisplay) { }

	// RVA: 0xFFFFFFFF75BFE93C
	public Int32 get_renderingWidth() { }

	// RVA: 0xFFFFFFFF75BFEA0C
	public Int32 get_renderingHeight() { }

	// RVA: 0xFFFFFFFF75BFEA84
	public Int32 get_systemWidth() { }

	// RVA: 0xFFFFFFFF75BFEB54
	public Int32 get_systemHeight() { }

	// RVA: 0xFFFFFFFF75BFEBCC
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0xFFFFFFFF75BFECA0
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	// RVA: 0xFFFFFFFF75BFEDC4
	public static Display get_main() { }

	// RVA: 0xFFFFFFFF75BFEE04
	private static Void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	// RVA: 0xFFFFFFFF75BFEF4C
	private static Void FireDisplaysUpdated() { }

	// RVA: 0xFFFFFFFF75BFEAFC
	private static Void GetSystemExtImpl(IntPtr nativeDisplay, out Int32 w, out Int32 h) { }

	// RVA: 0xFFFFFFFF75BFE9B4
	private static Void GetRenderingExtImpl(IntPtr nativeDisplay, out Int32 w, out Int32 h) { }

	// RVA: 0xFFFFFFFF75BFEC48
	private static Void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth) { }

	// RVA: 0xFFFFFFFF75BFED5C
	private static Int32 RelativeMouseAtImpl(Int32 x, Int32 y, out Int32 rx, out Int32 ry) { }

	// RVA: 0xFFFFFFFF75BFF1A0
	private static Void .cctor() { }

}

// Namespace: 
public sealed class DisplaysUpdatedDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75BFF2A8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75BFEFA4
	public virtual Void Invoke() { }

	// RVA: 0xFFFFFFFF75BFF2EC
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BFF344
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine
internal enum EnabledOrientation
{
	// Fields
	public Int32 value__; // 0x10
	public const EnabledOrientation kAutorotateToPortrait = 1;
	public const EnabledOrientation kAutorotateToPortraitUpsideDown = 2;
	public const EnabledOrientation kAutorotateToLandscapeLeft = 4;
	public const EnabledOrientation kAutorotateToLandscapeRight = 8;
}

// Namespace: UnityEngine
public enum FullScreenMode
{
	// Fields
	public Int32 value__; // 0x10
	public const FullScreenMode ExclusiveFullScreen = 0;
	public const FullScreenMode FullScreenWindow = 1;
	public const FullScreenMode MaximizedWindow = 2;
	public const FullScreenMode Windowed = 3;
}

// Namespace: UnityEngine
public sealed class Screen
{
	// Properties
	public static Int32 width { get; }
	public static Int32 height { get; }
	public static Single dpi { get; }
	public static ScreenOrientation orientation { get; set; }
	public static Int32 sleepTimeout { get; set; }
	public static Boolean autorotateToPortrait { get; set; }
	public static Boolean autorotateToPortraitUpsideDown { get; set; }
	public static Boolean autorotateToLandscapeLeft { get; set; }
	public static Boolean autorotateToLandscapeRight { get; set; }
	public static Resolution currentResolution { get; }
	public static Boolean fullScreen { get; set; }
	public static FullScreenMode fullScreenMode { get; set; }
	public static Rect safeArea { get; }
	public static Rect[] cutouts { get; }
	public static Resolution[] resolutions { get; }
	public static Single brightness { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF723C9280
	public static Int32 get_width() { }

	// RVA: 0xFFFFFFFF723C92BC
	public static Int32 get_height() { }

	// RVA: 0xFFFFFFFF723C92F8
	public static Single get_dpi() { }

	// RVA: 0xFFFFFFFF75C33E84
	private static Void RequestOrientation(ScreenOrientation orient) { }

	// RVA: 0xFFFFFFFF75C33EC4
	private static ScreenOrientation GetScreenOrientation() { }

	// RVA: 0xFFFFFFFF75C33EF8
	public static ScreenOrientation get_orientation() { }

	// RVA: 0xFFFFFFFF75C33F2C
	public static Void set_orientation(ScreenOrientation value) { }

	// RVA: 0xFFFFFFFF75C33FC4
	public static Int32 get_sleepTimeout() { }

	// RVA: 0xFFFFFFFF75C33FF8
	public static Void set_sleepTimeout(Int32 value) { }

	// RVA: 0xFFFFFFFF75C34038
	private static Boolean IsOrientationEnabled(EnabledOrientation orient) { }

	// RVA: 0xFFFFFFFF75C34078
	private static Void SetOrientationEnabled(EnabledOrientation orient, Boolean enabled) { }

	// RVA: 0xFFFFFFFF75C340C8
	public static Boolean get_autorotateToPortrait() { }

	// RVA: 0xFFFFFFFF75C34104
	public static Void set_autorotateToPortrait(Boolean value) { }

	// RVA: 0xFFFFFFFF75C3415C
	public static Boolean get_autorotateToPortraitUpsideDown() { }

	// RVA: 0xFFFFFFFF75C34198
	public static Void set_autorotateToPortraitUpsideDown(Boolean value) { }

	// RVA: 0xFFFFFFFF75C341F0
	public static Boolean get_autorotateToLandscapeLeft() { }

	// RVA: 0xFFFFFFFF75C3422C
	public static Void set_autorotateToLandscapeLeft(Boolean value) { }

	// RVA: 0xFFFFFFFF75C34270
	public static Boolean get_autorotateToLandscapeRight() { }

	// RVA: 0xFFFFFFFF75C342AC
	public static Void set_autorotateToLandscapeRight(Boolean value) { }

	// RVA: 0xFFFFFFFF723C9330
	public static Resolution get_currentResolution() { }

	// RVA: 0xFFFFFFFF75C34344
	public static Boolean get_fullScreen() { }

	// RVA: 0xFFFFFFFF75C34378
	public static Void set_fullScreen(Boolean value) { }

	// RVA: 0xFFFFFFFF75C343B8
	public static FullScreenMode get_fullScreenMode() { }

	// RVA: 0xFFFFFFFF75C343EC
	public static Void set_fullScreenMode(FullScreenMode value) { }

	// RVA: 0xFFFFFFFF75C3442C
	public static Rect get_safeArea() { }

	// RVA: 0xFFFFFFFF75C344C0
	public static Rect[] get_cutouts() { }

	// RVA: 0xFFFFFFFF75C344F4
	public static Void SetResolution(Int32 width, Int32 height, FullScreenMode fullscreenMode, Int32 preferredRefreshRate) { }

	// RVA: 0xFFFFFFFF75C3455C
	public static Void SetResolution(Int32 width, Int32 height, FullScreenMode fullscreenMode) { }

	// RVA: 0xFFFFFFFF75C345B8
	public static Void SetResolution(Int32 width, Int32 height, Boolean fullscreen, Int32 preferredRefreshRate) { }

	// RVA: 0xFFFFFFFF75C34640
	public static Void SetResolution(Int32 width, Int32 height, Boolean fullscreen) { }

	// RVA: 0xFFFFFFFF75C34648
	public static Resolution[] get_resolutions() { }

	// RVA: 0xFFFFFFFF75C3467C
	public static Single get_brightness() { }

	// RVA: 0xFFFFFFFF75C346B0
	public static Void set_brightness(Single value) { }

	// RVA: 0xFFFFFFFF75C346F4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C34304
	private static Void get_currentResolution_Injected(out Resolution ret) { }

	// RVA: 0xFFFFFFFF75C34480
	private static Void get_safeArea_Injected(out Rect ret) { }

}

// Namespace: UnityEngine
public struct RenderBuffer
{
	// Fields
	internal Int32 m_RenderTextureInstanceID; // 0x10
	internal IntPtr m_BufferPtr; // 0x18
}

// Namespace: UnityEngine
public enum ComputeBufferMode
{
	// Fields
	public Int32 value__; // 0x10
	public const ComputeBufferMode Immutable = 0;
	public const ComputeBufferMode Dynamic = 1;
	public const ComputeBufferMode Circular = 2;
	public const ComputeBufferMode StreamOut = 3;
	public const ComputeBufferMode SubUpdates = 4;
}

// Namespace: UnityEngine
public class Graphics
{
	// Fields
	internal static readonly Int32 kMaxDrawMeshInstanceCount; // 0x0

	// Properties
	public static GraphicsTier activeTier { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C04A68
	private static Int32 Internal_GetMaxDrawMeshInstanceCount() { }

	// RVA: 0xFFFFFFFF75C04A9C
	public static GraphicsTier get_activeTier() { }

	// RVA: 0xFFFFFFFF75C04AD0
	private static Void CopyTexture_Region(Texture src, Int32 srcElement, Int32 srcMip, Int32 srcX, Int32 srcY, Int32 srcWidth, Int32 srcHeight, Texture dst, Int32 dstElement, Int32 dstMip, Int32 dstX, Int32 dstY) { }

	// RVA: 0xFFFFFFFF75C04B84
	private static Void Internal_DrawMeshNow1(Mesh mesh, Int32 subsetIndex, Vector3 position, Quaternion rotation) { }

	// RVA: 0xFFFFFFFF75C04C7C
	internal static Void Internal_DrawTexture(ref Internal_DrawTextureArguments args) { }

	// RVA: 0xFFFFFFFF723BA534
	private static Void Internal_DrawMesh(Mesh mesh, Int32 submeshIndex, Matrix4x4 matrix, Material material, Int32 layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, Boolean receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0xFFFFFFFF75C04D80
	private static Void Internal_DrawMeshInstanced(Mesh mesh, Int32 submeshIndex, Material material, Matrix4x4[] matrices, Int32 count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, Boolean receiveShadows, Int32 layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0xFFFFFFFF75C04E3C
	private static Void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, Int32 pass, Boolean setRT) { }

	// RVA: 0xFFFFFFFF75C04EAC
	private static Void Internal_BlitMultiTap4(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	// RVA: 0xFFFFFFFF75C04F14
	private static Void Blit2(Texture source, RenderTexture dest) { }

	// RVA: 0xFFFFFFFF75C04F64
	public static Void ExecuteCommandBuffer(CommandBuffer buffer) { }

	// RVA: 0xFFFFFFFF75C04FA4
	public static Void CopyTexture(Texture src, Int32 srcElement, Int32 srcMip, Int32 srcX, Int32 srcY, Int32 srcWidth, Int32 srcHeight, Texture dst, Int32 dstElement, Int32 dstMip, Int32 dstX, Int32 dstY) { }

	// RVA: 0xFFFFFFFF75C050A0
	private static Void DrawTextureImpl(Rect screenRect, Texture texture, Rect sourceRect, Int32 leftBorder, Int32 rightBorder, Int32 topBorder, Int32 bottomBorder, Color color, Material mat, Int32 pass) { }

	// RVA: 0xFFFFFFFF75C05190
	public static Void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, Int32 leftBorder, Int32 rightBorder, Int32 topBorder, Int32 bottomBorder, Color color, Material mat, Int32 pass) { }

	// RVA: 0xFFFFFFFF75C0527C
	public static Void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, Int32 leftBorder, Int32 rightBorder, Int32 topBorder, Int32 bottomBorder, Material mat, Int32 pass) { }

	// RVA: 0xFFFFFFFF75C0537C
	public static Void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation, Int32 materialIndex) { }

	// RVA: 0xFFFFFFFF75C05488
	public static Void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation) { }

	// RVA: 0xFFFFFFFF723BA674
	public static Void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, Int32 layer, Camera camera, Int32 submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, Boolean receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0xFFFFFFFF723BA8D0
	public static Void DrawMeshInstanced(Mesh mesh, Int32 submeshIndex, Material material, Matrix4x4[] matrices, Int32 count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, Boolean receiveShadows, Int32 layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0xFFFFFFFF75C05520
	public static Void Blit(Texture source, RenderTexture dest) { }

	// RVA: 0xFFFFFFFF75C0558C
	public static Void Blit(Texture source, RenderTexture dest, Material mat, Int32 pass) { }

	// RVA: 0xFFFFFFFF75C05614
	public static Void Blit(Texture source, RenderTexture dest, Material mat) { }

	// RVA: 0xFFFFFFFF75C0566C
	public static Void BlitMultiTap(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	// RVA: 0xFFFFFFFF723BB310
	public static Void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, Int32 layer) { }

	// RVA: 0xFFFFFFFF723BB3A0
	public static Void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, Int32 layer, Camera camera, Int32 submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, Boolean receiveShadows, Transform probeAnchor, Boolean useLightProbes) { }

	// RVA: 0xFFFFFFFF75C05770
	public static Void DrawMeshInstanced(Mesh mesh, Int32 submeshIndex, Material material, Matrix4x4[] matrices, Int32 count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, Boolean receiveShadows, Int32 layer, Camera camera, LightProbeUsage lightProbeUsage) { }

	// RVA: 0xFFFFFFFF75C0582C
	public static Void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, Int32 leftBorder, Int32 rightBorder, Int32 topBorder, Int32 bottomBorder, Color color, Material mat) { }

	// RVA: 0xFFFFFFFF75C0590C
	public static Void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, Int32 leftBorder, Int32 rightBorder, Int32 topBorder, Int32 bottomBorder) { }

	// RVA: 0xFFFFFFFF75C059E0
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C04C14
	private static Void Internal_DrawMeshNow1_Injected(Mesh mesh, Int32 subsetIndex, ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0xFFFFFFFF75C04CBC
	private static Void Internal_DrawMesh_Injected(Mesh mesh, Int32 submeshIndex, ref Matrix4x4 matrix, Material material, Int32 layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, Boolean receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

}

// Namespace: UnityEngine
public sealed class GL
{
	// Properties
	public static Boolean invertCulling { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C02EBC
	public static Void Vertex3(Single x, Single y, Single z) { }

	// RVA: 0xFFFFFFFF75C02F18
	public static Void TexCoord3(Single x, Single y, Single z) { }

	// RVA: 0xFFFFFFFF75C02F74
	public static Void TexCoord2(Single x, Single y) { }

	// RVA: 0xFFFFFFFF723B9934
	public static Boolean get_invertCulling() { }

	// RVA: 0xFFFFFFFF723B9970
	public static Void set_invertCulling(Boolean value) { }

	// RVA: 0xFFFFFFFF75C02FC4
	public static Void MultMatrix(Matrix4x4 m) { }

	// RVA: 0xFFFFFFFF75C03044
	public static Void PushMatrix() { }

	// RVA: 0xFFFFFFFF75C03078
	public static Void PopMatrix() { }

	// RVA: 0xFFFFFFFF75C030AC
	public static Void LoadOrtho() { }

	// RVA: 0xFFFFFFFF75C030E0
	public static Void InvalidateState() { }

	// RVA: 0xFFFFFFFF723B99C4
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, Boolean renderIntoTexture) { }

	// RVA: 0xFFFFFFFF75C0316C
	private static Void GLLoadPixelMatrixScript(Single left, Single right, Single bottom, Single top) { }

	// RVA: 0xFFFFFFFF75C031D0
	public static Void LoadPixelMatrix(Single left, Single right, Single bottom, Single top) { }

	// RVA: 0xFFFFFFFF75C03234
	private static Void GLIssuePluginEvent(IntPtr callback, Int32 eventID) { }

	// RVA: 0xFFFFFFFF75C03284
	public static Void IssuePluginEvent(IntPtr callback, Int32 eventID) { }

	// RVA: 0xFFFFFFFF75C0333C
	public static Void Begin(Int32 mode) { }

	// RVA: 0xFFFFFFFF75C0337C
	public static Void End() { }

	// RVA: 0xFFFFFFFF75C033B0
	private static Void GLClear(Boolean clearDepth, Boolean clearColor, Color backgroundColor, Single depth) { }

	// RVA: 0xFFFFFFFF75C03490
	public static Void Clear(Boolean clearDepth, Boolean clearColor, Color backgroundColor) { }

	// RVA: 0xFFFFFFFF75C03004
	private static Void MultMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0xFFFFFFFF75C03114
	private static Void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, Boolean renderIntoTexture, out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75C03428
	private static Void GLClear_Injected(Boolean clearDepth, Boolean clearColor, ref Color backgroundColor, Single depth) { }

}

// Namespace: UnityEngine
public sealed class LightmapData
{
	// Fields
	internal Texture2D m_Light; // 0x10
	internal Texture2D m_Dir; // 0x18
	internal Texture2D m_ShadowMask; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75C0A3F8
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class LightmapSettings
{
	// Properties
	public static LightmapData[] lightmaps { get; set; }
	public static LightmapsMode lightmapsMode { get; set; }
	public static LightProbes lightProbes { get; set; }
	public static LightmapsModeLegacy lightmapsModeLegacy { get; set; }
	public static ColorSpace bakedColorSpace { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C0A3FC
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF75C0A41C
	public static LightmapData[] get_lightmaps() { }

	// RVA: 0xFFFFFFFF75C0A450
	public static Void set_lightmaps(LightmapData[] value) { }

	// RVA: 0xFFFFFFFF75C0A490
	public static LightmapsMode get_lightmapsMode() { }

	// RVA: 0xFFFFFFFF75C0A4C4
	public static Void set_lightmapsMode(LightmapsMode value) { }

	// RVA: 0xFFFFFFFF75C0A504
	public static LightProbes get_lightProbes() { }

	// RVA: 0xFFFFFFFF75C0A538
	public static Void set_lightProbes(LightProbes value) { }

	// RVA: 0xFFFFFFFF75C0A578
	internal static Void Reset() { }

	// RVA: 0xFFFFFFFF75C0A5AC
	public static LightmapsModeLegacy get_lightmapsModeLegacy() { }

	// RVA: 0xFFFFFFFF75C0A5B4
	public static Void set_lightmapsModeLegacy(LightmapsModeLegacy value) { }

	// RVA: 0xFFFFFFFF75C0A5B8
	public static ColorSpace get_bakedColorSpace() { }

	// RVA: 0xFFFFFFFF75C0A5C0
	public static Void set_bakedColorSpace(ColorSpace value) { }

}

// Namespace: UnityEngine
public sealed class LightProbes
{
	// Fields
	private static Action tetrahedralizationCompleted; // 0x0
	private static Action needsRetetrahedralization; // 0x8

	// Properties
	public Vector3[] positions { get; }
	public SphericalHarmonicsL2[] bakedProbes { get; set; }
	public Int32 count { get; }
	public Int32 cellCount { get; }
	public Single[] coefficients { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C09810
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF75C09830
	public static Void add_tetrahedralizationCompleted(Action value) { }

	// RVA: 0xFFFFFFFF75C098E8
	public static Void remove_tetrahedralizationCompleted(Action value) { }

	// RVA: 0xFFFFFFFF75C099A0
	private static Void Internal_CallTetrahedralizationCompletedFunction() { }

	// RVA: 0xFFFFFFFF75C09A0C
	public static Void add_needsRetetrahedralization(Action value) { }

	// RVA: 0xFFFFFFFF75C09AC8
	public static Void remove_needsRetetrahedralization(Action value) { }

	// RVA: 0xFFFFFFFF75C09B84
	private static Void Internal_CallNeedsRetetrahedralizationFunction() { }

	// RVA: 0xFFFFFFFF75C09BF0
	public static Void Tetrahedralize() { }

	// RVA: 0xFFFFFFFF75C09C24
	public static Void TetrahedralizeAsync() { }

	// RVA: 0xFFFFFFFF75C09C58
	public static Void GetInterpolatedProbe(Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe) { }

	// RVA: 0xFFFFFFFF75C09D18
	internal static Boolean AreLightProbesAllowed(Renderer renderer) { }

	// RVA: 0xFFFFFFFF75C09D58
	public static Void CalculateInterpolatedLightAndOcclusionProbes(Vector3[] positions, SphericalHarmonicsL2[] lightProbes, Vector4[] occlusionProbes) { }

	// RVA: 0xFFFFFFFF75C09F6C
	public static Void CalculateInterpolatedLightAndOcclusionProbes(List<T0> positions, List<T0> lightProbes, List<T0> occlusionProbes) { }

	// RVA: 0xFFFFFFFF75C09F04
	internal static Void CalculateInterpolatedLightAndOcclusionProbes_Internal(Vector3[] positions, Int32 positionsCount, SphericalHarmonicsL2[] lightProbes, Vector4[] occlusionProbes) { }

	// RVA: 0xFFFFFFFF75C0A25C
	public Vector3[] get_positions() { }

	// RVA: 0xFFFFFFFF75C0A29C
	public SphericalHarmonicsL2[] get_bakedProbes() { }

	// RVA: 0xFFFFFFFF75C0A2DC
	public Void set_bakedProbes(SphericalHarmonicsL2[] value) { }

	// RVA: 0xFFFFFFFF75C0A32C
	public Int32 get_count() { }

	// RVA: 0xFFFFFFFF75C0A36C
	public Int32 get_cellCount() { }

	// RVA: 0xFFFFFFFF75C0A3AC
	internal static Int32 GetCount() { }

	// RVA: 0xFFFFFFFF75C0A3E0
	public Void GetInterpolatedLightProbe(Vector3 position, Renderer renderer, Single[] coefficients) { }

	// RVA: 0xFFFFFFFF75C0A3E4
	public Single[] get_coefficients() { }

	// RVA: 0xFFFFFFFF75C0A3F4
	public Void set_coefficients(Single[] value) { }

	// RVA: 0xFFFFFFFF75C09CC0
	private static Void GetInterpolatedProbe_Injected(ref Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe) { }

}

// Namespace: UnityEngine
public struct Resolution
{
	// Fields
	private Int32 m_Width; // 0x10
	private Int32 m_Height; // 0x14
	private Int32 m_RefreshRate; // 0x18

	// Properties
	public Int32 width { get; }
	public Int32 height { get; }
	public Int32 refreshRate { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114E7C8
	public Int32 get_width() { }

	// RVA: 0xFFFFFFFF7114E7D0
	public Int32 get_height() { }

	// RVA: 0xFFFFFFFF7114E7D8
	public Int32 get_refreshRate() { }

	// RVA: 0xFFFFFFFF7114E7E0
	public override String ToString() { }

}

// Namespace: UnityEngine
internal struct Internal_DrawTextureArguments
{
	// Fields
	public Rect screenRect; // 0x10
	public Rect sourceRect; // 0x20
	public Int32 leftBorder; // 0x30
	public Int32 rightBorder; // 0x34
	public Int32 topBorder; // 0x38
	public Int32 bottomBorder; // 0x3C
	public Color leftBorderColor; // 0x40
	public Color rightBorderColor; // 0x50
	public Color topBorderColor; // 0x60
	public Color bottomBorderColor; // 0x70
	public Color color; // 0x80
	public Vector4 borderWidths; // 0x90
	public Vector4 cornerRadiuses; // 0xA0
	public Boolean smoothCorners; // 0xB0
	public Int32 pass; // 0xB4
	public Texture texture; // 0xB8
	public Material mat; // 0xC0
}

// Namespace: UnityEngine
public sealed class QualitySettings
{
	// Properties
	public static Int32 pixelLightCount { get; set; }
	public static ShadowQuality shadows { get; set; }
	public static ShadowProjection shadowProjection { get; set; }
	public static Int32 shadowCascades { get; set; }
	public static Single shadowDistance { get; set; }
	public static ShadowResolution shadowResolution { get; set; }
	public static ShadowmaskMode shadowmaskMode { set; }
	public static Single shadowNearPlaneOffset { set; }
	public static Vector3 shadowCascade4Split { set; }
	public static Int32 vSyncCount { get; }
	public static Int32 antiAliasing { get; set; }
	public static Int32 asyncUploadBufferSize { set; }
	public static SkinWeights skinWeights { get; }
	public static ColorSpace desiredColorSpace { get; }
	public static ColorSpace activeColorSpace { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C20264
	public static Void SetQualityLevel(Int32 index) { }

	// RVA: 0xFFFFFFFF723C4CE0
	public static Int32 get_pixelLightCount() { }

	// RVA: 0xFFFFFFFF723C4D18
	public static Void set_pixelLightCount(Int32 value) { }

	// RVA: 0xFFFFFFFF75C202F8
	public static ShadowQuality get_shadows() { }

	// RVA: 0xFFFFFFFF723C4D5C
	public static Void set_shadows(ShadowQuality value) { }

	// RVA: 0xFFFFFFFF75C2032C
	public static ShadowProjection get_shadowProjection() { }

	// RVA: 0xFFFFFFFF723C4DA0
	public static Void set_shadowProjection(ShadowProjection value) { }

	// RVA: 0xFFFFFFFF75C20360
	public static Int32 get_shadowCascades() { }

	// RVA: 0xFFFFFFFF723C4DE4
	public static Void set_shadowCascades(Int32 value) { }

	// RVA: 0xFFFFFFFF75C20394
	public static Single get_shadowDistance() { }

	// RVA: 0xFFFFFFFF723C4E28
	public static Void set_shadowDistance(Single value) { }

	// RVA: 0xFFFFFFFF75C203C8
	public static ShadowResolution get_shadowResolution() { }

	// RVA: 0xFFFFFFFF723C4E70
	public static Void set_shadowResolution(ShadowResolution value) { }

	// RVA: 0xFFFFFFFF723C4EB4
	public static Void set_shadowmaskMode(ShadowmaskMode value) { }

	// RVA: 0xFFFFFFFF723C4EF8
	public static Void set_shadowNearPlaneOffset(Single value) { }

	// RVA: 0xFFFFFFFF75C203FC
	public static Void set_shadowCascade4Split(Vector3 value) { }

	// RVA: 0xFFFFFFFF75C2048C
	public static Int32 get_vSyncCount() { }

	// RVA: 0xFFFFFFFF75C204C0
	public static Int32 get_antiAliasing() { }

	// RVA: 0xFFFFFFFF75C204F4
	public static Void set_antiAliasing(Int32 value) { }

	// RVA: 0xFFFFFFFF75C20534
	public static Void set_asyncUploadBufferSize(Int32 value) { }

	// RVA: 0xFFFFFFFF75C20574
	public static SkinWeights get_skinWeights() { }

	// RVA: 0xFFFFFFFF75C202A8
	public static Void SetQualityLevel(Int32 index, Boolean applyExpensiveChanges) { }

	// RVA: 0xFFFFFFFF75C205A8
	public static ColorSpace get_desiredColorSpace() { }

	// RVA: 0xFFFFFFFF723C4F40
	public static ColorSpace get_activeColorSpace() { }

	// RVA: 0xFFFFFFFF75C2044C
	private static Void set_shadowCascade4Split_Injected(ref Vector3 value) { }

}

// Namespace: UnityEngine
public sealed class ImageEffectAllowedInSceneView
{
	// Methods

	// RVA: 0xFFFFFFFF75C05ECC
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class ImageEffectOpaque
{
	// Methods

	// RVA: 0xFFFFFFFF75C05ED4
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class ImageEffectUsesCommandBuffer
{
	// Methods

	// RVA: 0xFFFFFFFF75C05EDC
	public Void .ctor() { }

}

// Namespace: UnityEngine
public enum LightmapsModeLegacy
{
	// Fields
	public Int32 value__; // 0x10
	public const LightmapsModeLegacy Single = 0;
	public const LightmapsModeLegacy Dual = 1;
	public const LightmapsModeLegacy Directional = 2;
}

// Namespace: UnityEngine
public sealed class TrailRenderer
{
	// Properties
	public Int32 numPositions { get; }
	public Single time { get; set; }
	public Single startWidth { get; set; }
	public Single endWidth { get; set; }
	public Single widthMultiplier { get; set; }
	public Boolean autodestruct { get; set; }
	public Boolean emitting { get; set; }
	public Int32 numCornerVertices { get; set; }
	public Int32 numCapVertices { get; set; }
	public Single minVertexDistance { get; set; }
	public Color startColor { get; set; }
	public Color endColor { get; set; }
	public Int32 positionCount { get; }
	public Single shadowBias { get; set; }
	public Boolean generateLightingData { get; set; }
	public LineTextureMode textureMode { get; set; }
	public LineAlignment alignment { get; set; }
	public AnimationCurve widthCurve { get; set; }
	public Gradient colorGradient { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C41B48
	public Int32 get_numPositions() { }

	// RVA: 0xFFFFFFFF723CAA58
	public Single get_time() { }

	// RVA: 0xFFFFFFFF723CAA9C
	public Void set_time(Single value) { }

	// RVA: 0xFFFFFFFF75C41BC8
	public Single get_startWidth() { }

	// RVA: 0xFFFFFFFF75C41C08
	public Void set_startWidth(Single value) { }

	// RVA: 0xFFFFFFFF75C41C58
	public Single get_endWidth() { }

	// RVA: 0xFFFFFFFF75C41C98
	public Void set_endWidth(Single value) { }

	// RVA: 0xFFFFFFFF75C41CE8
	public Single get_widthMultiplier() { }

	// RVA: 0xFFFFFFFF75C41D28
	public Void set_widthMultiplier(Single value) { }

	// RVA: 0xFFFFFFFF75C41D78
	public Boolean get_autodestruct() { }

	// RVA: 0xFFFFFFFF75C41DB8
	public Void set_autodestruct(Boolean value) { }

	// RVA: 0xFFFFFFFF75C41E08
	public Boolean get_emitting() { }

	// RVA: 0xFFFFFFFF75C41E48
	public Void set_emitting(Boolean value) { }

	// RVA: 0xFFFFFFFF75C41E98
	public Int32 get_numCornerVertices() { }

	// RVA: 0xFFFFFFFF75C41ED8
	public Void set_numCornerVertices(Int32 value) { }

	// RVA: 0xFFFFFFFF75C41F28
	public Int32 get_numCapVertices() { }

	// RVA: 0xFFFFFFFF75C41F68
	public Void set_numCapVertices(Int32 value) { }

	// RVA: 0xFFFFFFFF75C41FB8
	public Single get_minVertexDistance() { }

	// RVA: 0xFFFFFFFF75C41FF8
	public Void set_minVertexDistance(Single value) { }

	// RVA: 0xFFFFFFFF75C42048
	public Color get_startColor() { }

	// RVA: 0xFFFFFFFF75C420F4
	public Void set_startColor(Color value) { }

	// RVA: 0xFFFFFFFF75C4219C
	public Color get_endColor() { }

	// RVA: 0xFFFFFFFF75C42248
	public Void set_endColor(Color value) { }

	// RVA: 0xFFFFFFFF75C41B88
	public Int32 get_positionCount() { }

	// RVA: 0xFFFFFFFF75C422F0
	public Void SetPosition(Int32 index, Vector3 position) { }

	// RVA: 0xFFFFFFFF75C423B0
	public Vector3 GetPosition(Int32 index) { }

	// RVA: 0xFFFFFFFF75C42478
	public Single get_shadowBias() { }

	// RVA: 0xFFFFFFFF75C424B8
	public Void set_shadowBias(Single value) { }

	// RVA: 0xFFFFFFFF75C42508
	public Boolean get_generateLightingData() { }

	// RVA: 0xFFFFFFFF75C42548
	public Void set_generateLightingData(Boolean value) { }

	// RVA: 0xFFFFFFFF75C42598
	public LineTextureMode get_textureMode() { }

	// RVA: 0xFFFFFFFF75C425D8
	public Void set_textureMode(LineTextureMode value) { }

	// RVA: 0xFFFFFFFF75C42628
	public LineAlignment get_alignment() { }

	// RVA: 0xFFFFFFFF75C42668
	public Void set_alignment(LineAlignment value) { }

	// RVA: 0xFFFFFFFF723CAAF8
	public Void Clear() { }

	// RVA: 0xFFFFFFFF75C426B8
	public Void BakeMesh(Mesh mesh, Boolean useTransform) { }

	// RVA: 0xFFFFFFFF75C42728
	public Void BakeMesh(Mesh mesh, Camera camera, Boolean useTransform) { }

	// RVA: 0xFFFFFFFF75C42790
	public AnimationCurve get_widthCurve() { }

	// RVA: 0xFFFFFFFF75C42810
	public Void set_widthCurve(AnimationCurve value) { }

	// RVA: 0xFFFFFFFF75C428B0
	public Gradient get_colorGradient() { }

	// RVA: 0xFFFFFFFF75C42930
	public Void set_colorGradient(Gradient value) { }

	// RVA: 0xFFFFFFFF75C427D0
	private AnimationCurve GetWidthCurveCopy() { }

	// RVA: 0xFFFFFFFF75C42860
	private Void SetWidthCurve(AnimationCurve curve) { }

	// RVA: 0xFFFFFFFF75C428F0
	private Gradient GetColorGradientCopy() { }

	// RVA: 0xFFFFFFFF75C42980
	private Void SetColorGradient(Gradient curve) { }

	// RVA: 0xFFFFFFFF75C429D0
	public Int32 GetPositions([Out] Vector3[] positions) { }

	// RVA: 0xFFFFFFFF75C42A20
	public Void SetPositions(Vector3[] positions) { }

	// RVA: 0xFFFFFFFF75C42A70
	public Void AddPosition(Vector3 position) { }

	// RVA: 0xFFFFFFFF75C42B18
	public Void AddPositions(Vector3[] positions) { }

	// RVA: 0xFFFFFFFF75C42B68
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C420A4
	private Void get_startColor_Injected(out Color ret) { }

	// RVA: 0xFFFFFFFF75C4214C
	private Void set_startColor_Injected(ref Color value) { }

	// RVA: 0xFFFFFFFF75C421F8
	private Void get_endColor_Injected(out Color ret) { }

	// RVA: 0xFFFFFFFF75C422A0
	private Void set_endColor_Injected(ref Color value) { }

	// RVA: 0xFFFFFFFF75C42358
	private Void SetPosition_Injected(Int32 index, ref Vector3 position) { }

	// RVA: 0xFFFFFFFF75C42420
	private Void GetPosition_Injected(Int32 index, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C42AC8
	private Void AddPosition_Injected(ref Vector3 position) { }

}

// Namespace: UnityEngine
public sealed class LineRenderer
{
	// Properties
	public Int32 numPositions { get; set; }
	public Single startWidth { get; set; }
	public Single endWidth { get; set; }
	public Single widthMultiplier { get; set; }
	public Int32 numCornerVertices { get; set; }
	public Int32 numCapVertices { get; set; }
	public Boolean useWorldSpace { get; set; }
	public Boolean loop { get; set; }
	public Color startColor { get; set; }
	public Color endColor { get; set; }
	public Int32 positionCount { get; set; }
	public Single shadowBias { get; set; }
	public Boolean generateLightingData { get; set; }
	public LineTextureMode textureMode { get; set; }
	public LineAlignment alignment { get; set; }
	public AnimationCurve widthCurve { get; set; }
	public Gradient colorGradient { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C0A5C4
	public Void SetWidth(Single start, Single end) { }

	// RVA: 0xFFFFFFFF75C0A6E4
	public Void SetColors(Color start, Color end) { }

	// RVA: 0xFFFFFFFF75C0A840
	public Void SetVertexCount(Int32 count) { }

	// RVA: 0xFFFFFFFF75C0A890
	public Int32 get_numPositions() { }

	// RVA: 0xFFFFFFFF75C0A910
	public Void set_numPositions(Int32 value) { }

	// RVA: 0xFFFFFFFF75C0A960
	public Single get_startWidth() { }

	// RVA: 0xFFFFFFFF75C0A644
	public Void set_startWidth(Single value) { }

	// RVA: 0xFFFFFFFF75C0A9A0
	public Single get_endWidth() { }

	// RVA: 0xFFFFFFFF75C0A694
	public Void set_endWidth(Single value) { }

	// RVA: 0xFFFFFFFF75C0A9E0
	public Single get_widthMultiplier() { }

	// RVA: 0xFFFFFFFF75C0AA20
	public Void set_widthMultiplier(Single value) { }

	// RVA: 0xFFFFFFFF75C0AA74
	public Int32 get_numCornerVertices() { }

	// RVA: 0xFFFFFFFF75C0AAB4
	public Void set_numCornerVertices(Int32 value) { }

	// RVA: 0xFFFFFFFF75C0AB08
	public Int32 get_numCapVertices() { }

	// RVA: 0xFFFFFFFF75C0AB48
	public Void set_numCapVertices(Int32 value) { }

	// RVA: 0xFFFFFFFF75C0AB98
	public Boolean get_useWorldSpace() { }

	// RVA: 0xFFFFFFFF75C0ABD8
	public Void set_useWorldSpace(Boolean value) { }

	// RVA: 0xFFFFFFFF75C0AC28
	public Boolean get_loop() { }

	// RVA: 0xFFFFFFFF75C0AC68
	public Void set_loop(Boolean value) { }

	// RVA: 0xFFFFFFFF75C0ACB8
	public Color get_startColor() { }

	// RVA: 0xFFFFFFFF75C0A790
	public Void set_startColor(Color value) { }

	// RVA: 0xFFFFFFFF75C0ADB4
	public Color get_endColor() { }

	// RVA: 0xFFFFFFFF75C0A7E8
	public Void set_endColor(Color value) { }

	// RVA: 0xFFFFFFFF75C0A8D0
	public Int32 get_positionCount() { }

	// RVA: 0xFFFFFFFF723BCE74
	public Void set_positionCount(Int32 value) { }

	// RVA: 0xFFFFFFFF75C0AEB0
	public Void SetPosition(Int32 index, Vector3 position) { }

	// RVA: 0xFFFFFFFF75C0AF70
	public Vector3 GetPosition(Int32 index) { }

	// RVA: 0xFFFFFFFF75C0B038
	public Single get_shadowBias() { }

	// RVA: 0xFFFFFFFF75C0B078
	public Void set_shadowBias(Single value) { }

	// RVA: 0xFFFFFFFF75C0B0C8
	public Boolean get_generateLightingData() { }

	// RVA: 0xFFFFFFFF75C0B108
	public Void set_generateLightingData(Boolean value) { }

	// RVA: 0xFFFFFFFF75C0B158
	public LineTextureMode get_textureMode() { }

	// RVA: 0xFFFFFFFF75C0B198
	public Void set_textureMode(LineTextureMode value) { }

	// RVA: 0xFFFFFFFF75C0B1EC
	public LineAlignment get_alignment() { }

	// RVA: 0xFFFFFFFF75C0B22C
	public Void set_alignment(LineAlignment value) { }

	// RVA: 0xFFFFFFFF75C0B280
	public Void Simplify(Single tolerance) { }

	// RVA: 0xFFFFFFFF75C0B2D0
	public Void BakeMesh(Mesh mesh, Boolean useTransform) { }

	// RVA: 0xFFFFFFFF75C0B340
	public Void BakeMesh(Mesh mesh, Camera camera, Boolean useTransform) { }

	// RVA: 0xFFFFFFFF75C0B3A8
	public AnimationCurve get_widthCurve() { }

	// RVA: 0xFFFFFFFF75C0B428
	public Void set_widthCurve(AnimationCurve value) { }

	// RVA: 0xFFFFFFFF75C0B4CC
	public Gradient get_colorGradient() { }

	// RVA: 0xFFFFFFFF723BCED0
	public Void set_colorGradient(Gradient value) { }

	// RVA: 0xFFFFFFFF75C0B3E8
	private AnimationCurve GetWidthCurveCopy() { }

	// RVA: 0xFFFFFFFF75C0B47C
	private Void SetWidthCurve(AnimationCurve curve) { }

	// RVA: 0xFFFFFFFF75C0B50C
	private Gradient GetColorGradientCopy() { }

	// RVA: 0xFFFFFFFF75C0B54C
	private Void SetColorGradient(Gradient curve) { }

	// RVA: 0xFFFFFFFF75C0B59C
	public Int32 GetPositions([Out] Vector3[] positions) { }

	// RVA: 0xFFFFFFFF723BCF24
	public Void SetPositions(Vector3[] positions) { }

	// RVA: 0xFFFFFFFF75C0B5EC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C0AD14
	private Void get_startColor_Injected(out Color ret) { }

	// RVA: 0xFFFFFFFF75C0AD64
	private Void set_startColor_Injected(ref Color value) { }

	// RVA: 0xFFFFFFFF75C0AE10
	private Void get_endColor_Injected(out Color ret) { }

	// RVA: 0xFFFFFFFF75C0AE60
	private Void set_endColor_Injected(ref Color value) { }

	// RVA: 0xFFFFFFFF75C0AF18
	private Void SetPosition_Injected(Int32 index, ref Vector3 position) { }

	// RVA: 0xFFFFFFFF75C0AFE0
	private Void GetPosition_Injected(Int32 index, out Vector3 ret) { }

}

// Namespace: UnityEngine
public sealed class MaterialPropertyBlock
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C0FC9C
	private Single GetFloatImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C0FCEC
	private Color GetColorImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C0FDB0
	private Texture GetTextureImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C0FE00
	private Void SetFloatImpl(Int32 name, Single value) { }

	// RVA: 0xFFFFFFFF75C0FE60
	private Void SetVectorImpl(Int32 name, Vector4 value) { }

	// RVA: 0xFFFFFFFF75C0FF20
	private Void SetColorImpl(Int32 name, Color value) { }

	// RVA: 0xFFFFFFFF75C0FFE0
	private Void SetTextureImpl(Int32 name, Texture value) { }

	// RVA: 0xFFFFFFFF75C10038
	private Void SetBufferImpl(Int32 name, ComputeBuffer value) { }

	// RVA: 0xFFFFFFFF75C10090
	private Void SetVectorArrayImpl(Int32 name, Vector4[] values, Int32 count) { }

	// RVA: 0xFFFFFFFF75C100F8
	private static IntPtr CreateImpl() { }

	// RVA: 0xFFFFFFFF75C1012C
	private static Void DestroyImpl(IntPtr mpb) { }

	// RVA: 0xFFFFFFFF75C1016C
	private Void Clear(Boolean keepMemory) { }

	// RVA: 0xFFFFFFFF75C101BC
	public Void Clear() { }

	// RVA: 0xFFFFFFFF75C10200
	private Void SetVectorArray(Int32 name, Vector4[] values, Int32 count) { }

	// RVA: 0xFFFFFFFF75C10324
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C10364
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75C103A8
	private Void Dispose() { }

	// RVA: 0xFFFFFFFF75C10424
	public Void SetFloat(String name, Single value) { }

	// RVA: 0xFFFFFFFF75C104B8
	public Void SetFloat(Int32 nameID, Single value) { }

	// RVA: 0xFFFFFFFF75C10518
	public Void SetInt(String name, Int32 value) { }

	// RVA: 0xFFFFFFFF75C105A4
	public Void SetVector(Int32 nameID, Vector4 value) { }

	// RVA: 0xFFFFFFFF75C1060C
	public Void SetColor(String name, Color value) { }

	// RVA: 0xFFFFFFFF75C106C8
	public Void SetColor(Int32 nameID, Color value) { }

	// RVA: 0xFFFFFFFF75C10730
	public Void SetBuffer(String name, ComputeBuffer value) { }

	// RVA: 0xFFFFFFFF75C107BC
	public Void SetTexture(String name, Texture value) { }

	// RVA: 0xFFFFFFFF75C10848
	public Void SetTexture(Int32 nameID, Texture value) { }

	// RVA: 0xFFFFFFFF75C108A0
	public Void SetVectorArray(Int32 nameID, Vector4[] values) { }

	// RVA: 0xFFFFFFFF75C108BC
	public Single GetFloat(String name) { }

	// RVA: 0xFFFFFFFF75C10940
	public Single GetFloat(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C10990
	public Int32 GetInt(String name) { }

	// RVA: 0xFFFFFFFF75C10A34
	public Color GetColor(String name) { }

	// RVA: 0xFFFFFFFF75C10A98
	public Texture GetTexture(String name) { }

	// RVA: 0xFFFFFFFF75C0FD58
	private Void GetColorImpl_Injected(Int32 name, out Color ret) { }

	// RVA: 0xFFFFFFFF75C0FEC8
	private Void SetVectorImpl_Injected(Int32 name, ref Vector4 value) { }

	// RVA: 0xFFFFFFFF75C0FF88
	private Void SetColorImpl_Injected(Int32 name, ref Color value) { }

}

// Namespace: UnityEngine
public class Renderer
{
	// Properties
	public Bounds bounds { get; }
	public Boolean enabled { get; set; }
	public Boolean isVisible { get; }
	public ShadowCastingMode shadowCastingMode { get; set; }
	public Boolean receiveShadows { get; set; }
	public Boolean forceRenderingOff { get; set; }
	public MotionVectorGenerationMode motionVectorGenerationMode { get; set; }
	public LightProbeUsage lightProbeUsage { get; set; }
	public ReflectionProbeUsage reflectionProbeUsage { get; set; }
	public UInt32 renderingLayerMask { get; set; }
	public Int32 rendererPriority { get; set; }
	public RayTracingMode rayTracingMode { get; set; }
	public String sortingLayerName { get; set; }
	public Int32 sortingLayerID { get; set; }
	public Int32 sortingOrder { get; set; }
	public Boolean allowOcclusionWhenDynamic { get; set; }
	internal Transform staticBatchRootTransform { set; }
	internal Int32 staticBatchIndex { get; }
	public Boolean isPartOfStaticBatch { get; }
	public Matrix4x4 worldToLocalMatrix { get; }
	public Matrix4x4 localToWorldMatrix { get; }
	public GameObject lightProbeProxyVolumeOverride { get; set; }
	public Transform probeAnchor { get; set; }
	public Int32 lightmapIndex { get; set; }
	public Int32 realtimeLightmapIndex { get; set; }
	public Vector4 lightmapScaleOffset { get; set; }
	public Vector4 realtimeLightmapScaleOffset { get; set; }
	public Material[] materials { get; set; }
	public Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material[] sharedMaterials { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C27D38
	public Bounds get_bounds() { }

	// RVA: 0xFFFFFFFF75C27DFC
	private Void SetStaticLightmapST(Vector4 st) { }

	// RVA: 0xFFFFFFFF75C27EA4
	private Material GetMaterial() { }

	// RVA: 0xFFFFFFFF75C27EE4
	private Material GetSharedMaterial() { }

	// RVA: 0xFFFFFFFF75C27F24
	private Void SetMaterial(Material m) { }

	// RVA: 0xFFFFFFFF75C27F74
	private Material[] GetMaterialArray() { }

	// RVA: 0xFFFFFFFF75C27FB4
	private Void CopyMaterialArray([Out] Material[] m) { }

	// RVA: 0xFFFFFFFF75C28004
	private Void CopySharedMaterialArray([Out] Material[] m) { }

	// RVA: 0xFFFFFFFF75C28054
	private Void SetMaterialArray(Material[] m) { }

	// RVA: 0xFFFFFFFF75C280A4
	internal Void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0xFFFFFFFF75C280F4
	internal Void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	// RVA: 0xFFFFFFFF75C28144
	internal Void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, Int32 materialIndex) { }

	// RVA: 0xFFFFFFFF75C2819C
	internal Void Internal_GetPropertyBlockMaterialIndex(MaterialPropertyBlock dest, Int32 materialIndex) { }

	// RVA: 0xFFFFFFFF75C281F4
	public Boolean HasPropertyBlock() { }

	// RVA: 0xFFFFFFFF75C28234
	public Void SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0xFFFFFFFF75C28284
	public Void SetPropertyBlock(MaterialPropertyBlock properties, Int32 materialIndex) { }

	// RVA: 0xFFFFFFFF75C282DC
	public Void GetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0xFFFFFFFF75C2832C
	public Void GetPropertyBlock(MaterialPropertyBlock properties, Int32 materialIndex) { }

	// RVA: 0xFFFFFFFF75C28384
	private Void GetClosestReflectionProbesInternal(Object result) { }

	// RVA: 0xFFFFFFFF723C6E88
	public Boolean get_enabled() { }

	// RVA: 0xFFFFFFFF723C6ECC
	public Void set_enabled(Boolean value) { }

	// RVA: 0xFFFFFFFF723C6F28
	public Boolean get_isVisible() { }

	// RVA: 0xFFFFFFFF75C283D4
	public ShadowCastingMode get_shadowCastingMode() { }

	// RVA: 0xFFFFFFFF75C28414
	public Void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0xFFFFFFFF75C28468
	public Boolean get_receiveShadows() { }

	// RVA: 0xFFFFFFFF75C284A8
	public Void set_receiveShadows(Boolean value) { }

	// RVA: 0xFFFFFFFF75C284FC
	public Boolean get_forceRenderingOff() { }

	// RVA: 0xFFFFFFFF75C2853C
	public Void set_forceRenderingOff(Boolean value) { }

	// RVA: 0xFFFFFFFF75C2858C
	public MotionVectorGenerationMode get_motionVectorGenerationMode() { }

	// RVA: 0xFFFFFFFF75C285CC
	public Void set_motionVectorGenerationMode(MotionVectorGenerationMode value) { }

	// RVA: 0xFFFFFFFF75C28620
	public LightProbeUsage get_lightProbeUsage() { }

	// RVA: 0xFFFFFFFF75C28660
	public Void set_lightProbeUsage(LightProbeUsage value) { }

	// RVA: 0xFFFFFFFF75C286B0
	public ReflectionProbeUsage get_reflectionProbeUsage() { }

	// RVA: 0xFFFFFFFF75C286F0
	public Void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	// RVA: 0xFFFFFFFF75C28740
	public UInt32 get_renderingLayerMask() { }

	// RVA: 0xFFFFFFFF75C28780
	public Void set_renderingLayerMask(UInt32 value) { }

	// RVA: 0xFFFFFFFF75C287D0
	public Int32 get_rendererPriority() { }

	// RVA: 0xFFFFFFFF75C28810
	public Void set_rendererPriority(Int32 value) { }

	// RVA: 0xFFFFFFFF75C28860
	public RayTracingMode get_rayTracingMode() { }

	// RVA: 0xFFFFFFFF75C288A0
	public Void set_rayTracingMode(RayTracingMode value) { }

	// RVA: 0xFFFFFFFF75C288F0
	public String get_sortingLayerName() { }

	// RVA: 0xFFFFFFFF75C28930
	public Void set_sortingLayerName(String value) { }

	// RVA: 0xFFFFFFFF75C28984
	public Int32 get_sortingLayerID() { }

	// RVA: 0xFFFFFFFF75C289C4
	public Void set_sortingLayerID(Int32 value) { }

	// RVA: 0xFFFFFFFF723C6FA0
	public Int32 get_sortingOrder() { }

	// RVA: 0xFFFFFFFF723C6FF4
	public Void set_sortingOrder(Int32 value) { }

	// RVA: 0xFFFFFFFF75C28A14
	public Boolean get_allowOcclusionWhenDynamic() { }

	// RVA: 0xFFFFFFFF75C28A54
	public Void set_allowOcclusionWhenDynamic(Boolean value) { }

	// RVA: 0xFFFFFFFF75C28AA4
	internal Void set_staticBatchRootTransform(Transform value) { }

	// RVA: 0xFFFFFFFF75C28AF4
	internal Int32 get_staticBatchIndex() { }

	// RVA: 0xFFFFFFFF75C28B34
	internal Void SetStaticBatchInfo(Int32 firstSubMesh, Int32 subMeshCount) { }

	// RVA: 0xFFFFFFFF75C28B8C
	public Boolean get_isPartOfStaticBatch() { }

	// RVA: 0xFFFFFFFF75C28BCC
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0xFFFFFFFF75C28C94
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0xFFFFFFFF75C28D5C
	public GameObject get_lightProbeProxyVolumeOverride() { }

	// RVA: 0xFFFFFFFF75C28D9C
	public Void set_lightProbeProxyVolumeOverride(GameObject value) { }

	// RVA: 0xFFFFFFFF75C28DEC
	public Transform get_probeAnchor() { }

	// RVA: 0xFFFFFFFF75C28E2C
	public Void set_probeAnchor(Transform value) { }

	// RVA: 0xFFFFFFFF75C28E7C
	private Int32 GetLightmapIndex(LightmapType lt) { }

	// RVA: 0xFFFFFFFF75C28ECC
	private Void SetLightmapIndex(Int32 index, LightmapType lt) { }

	// RVA: 0xFFFFFFFF75C28F24
	private Vector4 GetLightmapST(LightmapType lt) { }

	// RVA: 0xFFFFFFFF75C28FE8
	private Void SetLightmapST(Vector4 st, LightmapType lt) { }

	// RVA: 0xFFFFFFFF75C290A8
	public Int32 get_lightmapIndex() { }

	// RVA: 0xFFFFFFFF75C290EC
	public Void set_lightmapIndex(Int32 value) { }

	// RVA: 0xFFFFFFFF75C29140
	public Int32 get_realtimeLightmapIndex() { }

	// RVA: 0xFFFFFFFF75C29184
	public Void set_realtimeLightmapIndex(Int32 value) { }

	// RVA: 0xFFFFFFFF75C291D8
	public Vector4 get_lightmapScaleOffset() { }

	// RVA: 0xFFFFFFFF75C291E0
	public Void set_lightmapScaleOffset(Vector4 value) { }

	// RVA: 0xFFFFFFFF75C29238
	public Vector4 get_realtimeLightmapScaleOffset() { }

	// RVA: 0xFFFFFFFF75C29240
	public Void set_realtimeLightmapScaleOffset(Vector4 value) { }

	// RVA: 0xFFFFFFFF75C2929C
	private Int32 GetMaterialCount() { }

	// RVA: 0xFFFFFFFF75C292DC
	private Material[] GetSharedMaterialArray() { }

	// RVA: 0xFFFFFFFF723C7050
	public Material[] get_materials() { }

	// RVA: 0xFFFFFFFF75C2931C
	public Void set_materials(Material[] value) { }

	// RVA: 0xFFFFFFFF723C70A4
	public Material get_material() { }

	// RVA: 0xFFFFFFFF723C70F8
	public Void set_material(Material value) { }

	// RVA: 0xFFFFFFFF723C714C
	public Material get_sharedMaterial() { }

	// RVA: 0xFFFFFFFF723C71A0
	public Void set_sharedMaterial(Material value) { }

	// RVA: 0xFFFFFFFF723C71F4
	public Material[] get_sharedMaterials() { }

	// RVA: 0xFFFFFFFF723C7248
	public Void set_sharedMaterials(Material[] value) { }

	// RVA: 0xFFFFFFFF723C729C
	public Void GetMaterials(List<T0> m) { }

	// RVA: 0xFFFFFFFF723C7448
	public Void GetSharedMaterials(List<T0> m) { }

	// RVA: 0xFFFFFFFF75C29370
	public Void GetClosestReflectionProbes(List<T0> result) { }

	// RVA: 0xFFFFFFFF75C293C0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C27DAC
	private Void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0xFFFFFFFF75C27E54
	private Void SetStaticLightmapST_Injected(ref Vector4 st) { }

	// RVA: 0xFFFFFFFF75C28C44
	private Void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75C28D0C
	private Void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75C28F90
	private Void GetLightmapST_Injected(LightmapType lt, out Vector4 ret) { }

	// RVA: 0xFFFFFFFF75C29050
	private Void SetLightmapST_Injected(ref Vector4 st, LightmapType lt) { }

}

// Namespace: UnityEngine
public sealed class RenderSettings
{
	// Properties
	public static Single ambientSkyboxAmount { get; set; }
	public static Boolean fog { get; set; }
	public static Single fogStartDistance { get; set; }
	public static Single fogEndDistance { get; set; }
	public static FogMode fogMode { get; set; }
	public static Color fogColor { get; set; }
	public static Single fogDensity { get; set; }
	public static AmbientMode ambientMode { get; set; }
	public static Color ambientSkyColor { get; set; }
	public static Color ambientEquatorColor { get; set; }
	public static Color ambientGroundColor { get; set; }
	public static Single ambientIntensity { get; set; }
	public static Color ambientLight { get; set; }
	public static Color subtractiveShadowColor { get; set; }
	public static Material skybox { get; set; }
	public static Light sun { get; set; }
	public static SphericalHarmonicsL2 ambientProbe { get; set; }
	public static Cubemap customReflection { get; set; }
	public static Single reflectionIntensity { get; set; }
	public static Int32 reflectionBounces { get; set; }
	public static DefaultReflectionMode defaultReflectionMode { get; set; }
	public static Int32 defaultReflectionResolution { get; set; }
	public static Single haloStrength { get; set; }
	public static Single flareStrength { get; set; }
	public static Single flareFadeSpeed { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C24CD0
	public static Single get_ambientSkyboxAmount() { }

	// RVA: 0xFFFFFFFF75C24D38
	public static Void set_ambientSkyboxAmount(Single value) { }

	// RVA: 0xFFFFFFFF75C24DC0
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF75C24DE0
	public static Boolean get_fog() { }

	// RVA: 0xFFFFFFFF723C6598
	public static Void set_fog(Boolean value) { }

	// RVA: 0xFFFFFFFF75C24E14
	public static Single get_fogStartDistance() { }

	// RVA: 0xFFFFFFFF75C24E48
	public static Void set_fogStartDistance(Single value) { }

	// RVA: 0xFFFFFFFF75C24E8C
	public static Single get_fogEndDistance() { }

	// RVA: 0xFFFFFFFF75C24EC0
	public static Void set_fogEndDistance(Single value) { }

	// RVA: 0xFFFFFFFF75C24F04
	public static FogMode get_fogMode() { }

	// RVA: 0xFFFFFFFF75C24F38
	public static Void set_fogMode(FogMode value) { }

	// RVA: 0xFFFFFFFF75C24F78
	public static Color get_fogColor() { }

	// RVA: 0xFFFFFFFF75C2500C
	public static Void set_fogColor(Color value) { }

	// RVA: 0xFFFFFFFF75C2509C
	public static Single get_fogDensity() { }

	// RVA: 0xFFFFFFFF75C250D0
	public static Void set_fogDensity(Single value) { }

	// RVA: 0xFFFFFFFF75C25114
	public static AmbientMode get_ambientMode() { }

	// RVA: 0xFFFFFFFF75C25148
	public static Void set_ambientMode(AmbientMode value) { }

	// RVA: 0xFFFFFFFF75C25188
	public static Color get_ambientSkyColor() { }

	// RVA: 0xFFFFFFFF75C2521C
	public static Void set_ambientSkyColor(Color value) { }

	// RVA: 0xFFFFFFFF75C252AC
	public static Color get_ambientEquatorColor() { }

	// RVA: 0xFFFFFFFF75C25340
	public static Void set_ambientEquatorColor(Color value) { }

	// RVA: 0xFFFFFFFF75C253D0
	public static Color get_ambientGroundColor() { }

	// RVA: 0xFFFFFFFF75C25464
	public static Void set_ambientGroundColor(Color value) { }

	// RVA: 0xFFFFFFFF75C24D04
	public static Single get_ambientIntensity() { }

	// RVA: 0xFFFFFFFF75C24D7C
	public static Void set_ambientIntensity(Single value) { }

	// RVA: 0xFFFFFFFF75C254F4
	public static Color get_ambientLight() { }

	// RVA: 0xFFFFFFFF75C25588
	public static Void set_ambientLight(Color value) { }

	// RVA: 0xFFFFFFFF75C25618
	public static Color get_subtractiveShadowColor() { }

	// RVA: 0xFFFFFFFF75C256AC
	public static Void set_subtractiveShadowColor(Color value) { }

	// RVA: 0xFFFFFFFF723C65DC
	public static Material get_skybox() { }

	// RVA: 0xFFFFFFFF75C2573C
	public static Void set_skybox(Material value) { }

	// RVA: 0xFFFFFFFF75C2577C
	public static Light get_sun() { }

	// RVA: 0xFFFFFFFF75C257B0
	public static Void set_sun(Light value) { }

	// RVA: 0xFFFFFFFF75C257F0
	public static SphericalHarmonicsL2 get_ambientProbe() { }

	// RVA: 0xFFFFFFFF75C258B0
	public static Void set_ambientProbe(SphericalHarmonicsL2 value) { }

	// RVA: 0xFFFFFFFF75C25930
	public static Cubemap get_customReflection() { }

	// RVA: 0xFFFFFFFF75C25964
	public static Void set_customReflection(Cubemap value) { }

	// RVA: 0xFFFFFFFF75C259A4
	public static Single get_reflectionIntensity() { }

	// RVA: 0xFFFFFFFF75C259D8
	public static Void set_reflectionIntensity(Single value) { }

	// RVA: 0xFFFFFFFF75C25A1C
	public static Int32 get_reflectionBounces() { }

	// RVA: 0xFFFFFFFF75C25A50
	public static Void set_reflectionBounces(Int32 value) { }

	// RVA: 0xFFFFFFFF75C25A90
	public static DefaultReflectionMode get_defaultReflectionMode() { }

	// RVA: 0xFFFFFFFF75C25AC4
	public static Void set_defaultReflectionMode(DefaultReflectionMode value) { }

	// RVA: 0xFFFFFFFF75C25B04
	public static Int32 get_defaultReflectionResolution() { }

	// RVA: 0xFFFFFFFF75C25B38
	public static Void set_defaultReflectionResolution(Int32 value) { }

	// RVA: 0xFFFFFFFF75C25B78
	public static Single get_haloStrength() { }

	// RVA: 0xFFFFFFFF75C25BAC
	public static Void set_haloStrength(Single value) { }

	// RVA: 0xFFFFFFFF75C25BF0
	public static Single get_flareStrength() { }

	// RVA: 0xFFFFFFFF75C25C24
	public static Void set_flareStrength(Single value) { }

	// RVA: 0xFFFFFFFF75C25C68
	public static Single get_flareFadeSpeed() { }

	// RVA: 0xFFFFFFFF75C25C9C
	public static Void set_flareFadeSpeed(Single value) { }

	// RVA: 0xFFFFFFFF75C25CE0
	internal static Object GetRenderSettings() { }

	// RVA: 0xFFFFFFFF75C25D14
	internal static Void Reset() { }

	// RVA: 0xFFFFFFFF75C24FCC
	private static Void get_fogColor_Injected(out Color ret) { }

	// RVA: 0xFFFFFFFF75C2505C
	private static Void set_fogColor_Injected(ref Color value) { }

	// RVA: 0xFFFFFFFF75C251DC
	private static Void get_ambientSkyColor_Injected(out Color ret) { }

	// RVA: 0xFFFFFFFF75C2526C
	private static Void set_ambientSkyColor_Injected(ref Color value) { }

	// RVA: 0xFFFFFFFF75C25300
	private static Void get_ambientEquatorColor_Injected(out Color ret) { }

	// RVA: 0xFFFFFFFF75C25390
	private static Void set_ambientEquatorColor_Injected(ref Color value) { }

	// RVA: 0xFFFFFFFF75C25424
	private static Void get_ambientGroundColor_Injected(out Color ret) { }

	// RVA: 0xFFFFFFFF75C254B4
	private static Void set_ambientGroundColor_Injected(ref Color value) { }

	// RVA: 0xFFFFFFFF75C25548
	private static Void get_ambientLight_Injected(out Color ret) { }

	// RVA: 0xFFFFFFFF75C255D8
	private static Void set_ambientLight_Injected(ref Color value) { }

	// RVA: 0xFFFFFFFF75C2566C
	private static Void get_subtractiveShadowColor_Injected(out Color ret) { }

	// RVA: 0xFFFFFFFF75C256FC
	private static Void set_subtractiveShadowColor_Injected(ref Color value) { }

	// RVA: 0xFFFFFFFF75C25870
	private static Void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret) { }

	// RVA: 0xFFFFFFFF75C258F0
	private static Void set_ambientProbe_Injected(ref SphericalHarmonicsL2 value) { }

}

// Namespace: UnityEngine
public sealed class Shader
{
	// Properties
	public Int32 maximumLOD { get; set; }
	public static Int32 globalMaximumLOD { get; set; }
	public Boolean isSupported { get; }
	public static String globalRenderPipeline { get; set; }
	public Int32 renderQueue { get; }
	internal DisableBatchingType disableBatching { get; }
	public Int32 passCount { get; }

	// Methods

	// RVA: 0xFFFFFFFF723C9460
	public static Shader Find(String name) { }

	// RVA: 0xFFFFFFFF723C94B4
	public Int32 get_maximumLOD() { }

	// RVA: 0xFFFFFFFF723C94F8
	public Void set_maximumLOD(Int32 value) { }

	// RVA: 0xFFFFFFFF75C34A40
	public static Int32 get_globalMaximumLOD() { }

	// RVA: 0xFFFFFFFF75C34A74
	public static Void set_globalMaximumLOD(Int32 value) { }

	// RVA: 0xFFFFFFFF75C34AB4
	public Boolean get_isSupported() { }

	// RVA: 0xFFFFFFFF75C34AF4
	public static String get_globalRenderPipeline() { }

	// RVA: 0xFFFFFFFF75C34B28
	public static Void set_globalRenderPipeline(String value) { }

	// RVA: 0xFFFFFFFF723C954C
	public static Void EnableKeyword(String keyword) { }

	// RVA: 0xFFFFFFFF723C9590
	public static Void DisableKeyword(String keyword) { }

	// RVA: 0xFFFFFFFF75C34B68
	public static Boolean IsKeywordEnabled(String keyword) { }

	// RVA: 0xFFFFFFFF75C34BA8
	public static Void SetShaderLabGlobalShaderTime(Single time) { }

	// RVA: 0xFFFFFFFF75C34BEC
	public Int32 get_renderQueue() { }

	// RVA: 0xFFFFFFFF75C34C2C
	internal DisableBatchingType get_disableBatching() { }

	// RVA: 0xFFFFFFFF75C34C6C
	public static Void WarmupAllShaders() { }

	// RVA: 0xFFFFFFFF75C30870
	internal static Int32 TagToID(String name) { }

	// RVA: 0xFFFFFFFF723C7FC0
	public static Int32 PropertyToID(String name) { }

	// RVA: 0xFFFFFFFF75C34CA0
	public Shader GetDependency(String name) { }

	// RVA: 0xFFFFFFFF75C34CF0
	public Int32 get_passCount() { }

	// RVA: 0xFFFFFFFF75C34D30
	public ShaderTagId FindPassTagValue(Int32 passIndex, ShaderTagId tagName) { }

	// RVA: 0xFFFFFFFF75C34E18
	private Int32 Internal_FindPassTagValue(Int32 passIndex, Int32 tagName) { }

	// RVA: 0xFFFFFFFF75C34E70
	private static Void SetGlobalFloatImpl(Int32 name, Single value) { }

	// RVA: 0xFFFFFFFF75C34EC0
	private static Void SetGlobalVectorImpl(Int32 name, Vector4 value) { }

	// RVA: 0xFFFFFFFF75C34F68
	private static Void SetGlobalMatrixImpl(Int32 name, Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75C35008
	private static Void SetGlobalTextureImpl(Int32 name, Texture value) { }

	// RVA: 0xFFFFFFFF75C35058
	private static Void SetGlobalRenderTextureImpl(Int32 name, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0xFFFFFFFF75C350B0
	private static Void SetGlobalBufferImpl(Int32 name, ComputeBuffer value) { }

	// RVA: 0xFFFFFFFF75C35100
	private static Void SetGlobalConstantBufferImpl(Int32 name, ComputeBuffer value, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75C35168
	private static Single GetGlobalFloatImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C351A8
	private static Vector4 GetGlobalVectorImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C35254
	private static Matrix4x4 GetGlobalMatrixImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C3531C
	private static Texture GetGlobalTextureImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C3535C
	private static Void SetGlobalFloatArrayImpl(Int32 name, Single[] values, Int32 count) { }

	// RVA: 0xFFFFFFFF75C353B4
	private static Void SetGlobalVectorArrayImpl(Int32 name, Vector4[] values, Int32 count) { }

	// RVA: 0xFFFFFFFF75C3540C
	private static Void SetGlobalMatrixArrayImpl(Int32 name, Matrix4x4[] values, Int32 count) { }

	// RVA: 0xFFFFFFFF75C35464
	private static Single[] GetGlobalFloatArrayImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C354A4
	private static Vector4[] GetGlobalVectorArrayImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C354E4
	private static Matrix4x4[] GetGlobalMatrixArrayImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C35524
	private static Int32 GetGlobalFloatArrayCountImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C35564
	private static Int32 GetGlobalVectorArrayCountImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C355A4
	private static Int32 GetGlobalMatrixArrayCountImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C355E4
	private static Void ExtractGlobalFloatArrayImpl(Int32 name, [Out] Single[] val) { }

	// RVA: 0xFFFFFFFF75C35634
	private static Void ExtractGlobalVectorArrayImpl(Int32 name, [Out] Vector4[] val) { }

	// RVA: 0xFFFFFFFF75C35684
	private static Void ExtractGlobalMatrixArrayImpl(Int32 name, [Out] Matrix4x4[] val) { }

	// RVA: 0xFFFFFFFF75C356D4
	private static Void SetGlobalFloatArray(Int32 name, Single[] values, Int32 count) { }

	// RVA: 0xFFFFFFFF723C95E4
	private static Void SetGlobalVectorArray(Int32 name, Vector4[] values, Int32 count) { }

	// RVA: 0xFFFFFFFF75C357E8
	private static Void SetGlobalMatrixArray(Int32 name, Matrix4x4[] values, Int32 count) { }

	// RVA: 0xFFFFFFFF75C358FC
	private static Void ExtractGlobalFloatArray(Int32 name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C35A7C
	private static Void ExtractGlobalVectorArray(Int32 name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C35C3C
	private static Void ExtractGlobalMatrixArray(Int32 name, List<T0> values) { }

	// RVA: 0xFFFFFFFF723C9710
	public static Void SetGlobalFloat(String name, Single value) { }

	// RVA: 0xFFFFFFFF723C97AC
	public static Void SetGlobalFloat(Int32 nameID, Single value) { }

	// RVA: 0xFFFFFFFF75C35DFC
	public static Void SetGlobalInt(String name, Int32 value) { }

	// RVA: 0xFFFFFFFF723C9808
	public static Void SetGlobalInt(Int32 nameID, Int32 value) { }

	// RVA: 0xFFFFFFFF723C9860
	public static Void SetGlobalVector(String name, Vector4 value) { }

	// RVA: 0xFFFFFFFF723C991C
	public static Void SetGlobalVector(Int32 nameID, Vector4 value) { }

	// RVA: 0xFFFFFFFF75C35E78
	public static Void SetGlobalColor(String name, Color value) { }

	// RVA: 0xFFFFFFFF75C35F34
	public static Void SetGlobalColor(Int32 nameID, Color value) { }

	// RVA: 0xFFFFFFFF723C9980
	public static Void SetGlobalMatrix(String name, Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75C35F94
	public static Void SetGlobalMatrix(Int32 nameID, Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF723C9A24
	public static Void SetGlobalTexture(String name, Texture value) { }

	// RVA: 0xFFFFFFFF723C9AB8
	public static Void SetGlobalTexture(Int32 nameID, Texture value) { }

	// RVA: 0xFFFFFFFF75C35FF4
	public static Void SetGlobalTexture(String name, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0xFFFFFFFF75C36078
	public static Void SetGlobalTexture(Int32 nameID, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0xFFFFFFFF75C360D0
	public static Void SetGlobalBuffer(String name, ComputeBuffer value) { }

	// RVA: 0xFFFFFFFF75C3614C
	public static Void SetGlobalBuffer(Int32 nameID, ComputeBuffer value) { }

	// RVA: 0xFFFFFFFF75C3619C
	public static Void SetGlobalConstantBuffer(Int32 nameID, ComputeBuffer value, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75C36204
	public static Void SetGlobalFloatArray(String name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C362A8
	public static Void SetGlobalFloatArray(Int32 nameID, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C36320
	public static Void SetGlobalFloatArray(String name, Single[] values) { }

	// RVA: 0xFFFFFFFF75C36380
	public static Void SetGlobalFloatArray(Int32 nameID, Single[] values) { }

	// RVA: 0xFFFFFFFF75C3639C
	public static Void SetGlobalVectorArray(String name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C36440
	public static Void SetGlobalVectorArray(Int32 nameID, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C364B8
	public static Void SetGlobalVectorArray(String name, Vector4[] values) { }

	// RVA: 0xFFFFFFFF723C9B14
	public static Void SetGlobalVectorArray(Int32 nameID, Vector4[] values) { }

	// RVA: 0xFFFFFFFF75C36518
	public static Void SetGlobalMatrixArray(String name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C365E0
	public static Void SetGlobalMatrixArray(Int32 nameID, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C3667C
	public static Void SetGlobalMatrixArray(String name, Matrix4x4[] values) { }

	// RVA: 0xFFFFFFFF75C366DC
	public static Void SetGlobalMatrixArray(Int32 nameID, Matrix4x4[] values) { }

	// RVA: 0xFFFFFFFF75C366F8
	public static Single GetGlobalFloat(String name) { }

	// RVA: 0xFFFFFFFF75C36764
	public static Single GetGlobalFloat(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C367A4
	public static Int32 GetGlobalInt(String name) { }

	// RVA: 0xFFFFFFFF75C36830
	public static Int32 GetGlobalInt(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C36890
	public static Vector4 GetGlobalVector(String name) { }

	// RVA: 0xFFFFFFFF75C368D4
	public static Vector4 GetGlobalVector(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C368D8
	public static Color GetGlobalColor(String name) { }

	// RVA: 0xFFFFFFFF75C36924
	public static Color GetGlobalColor(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C3693C
	public static Matrix4x4 GetGlobalMatrix(String name) { }

	// RVA: 0xFFFFFFFF75C369E0
	public static Matrix4x4 GetGlobalMatrix(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C36A58
	public static Texture GetGlobalTexture(String name) { }

	// RVA: 0xFFFFFFFF75C36AC4
	public static Texture GetGlobalTexture(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C36B04
	public static Single[] GetGlobalFloatArray(String name) { }

	// RVA: 0xFFFFFFFF75C36B48
	public static Single[] GetGlobalFloatArray(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C36BC4
	public static Vector4[] GetGlobalVectorArray(String name) { }

	// RVA: 0xFFFFFFFF75C36C08
	public static Vector4[] GetGlobalVectorArray(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C36C84
	public static Matrix4x4[] GetGlobalMatrixArray(String name) { }

	// RVA: 0xFFFFFFFF75C36CC8
	public static Matrix4x4[] GetGlobalMatrixArray(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C36D44
	public static Void GetGlobalFloatArray(String name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C36D98
	public static Void GetGlobalFloatArray(Int32 nameID, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C36D9C
	public static Void GetGlobalVectorArray(String name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C36DF0
	public static Void GetGlobalVectorArray(Int32 nameID, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C36DF4
	public static Void GetGlobalMatrixArray(String name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C36E48
	public static Void GetGlobalMatrixArray(Int32 nameID, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C36E4C
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF75C36E6C
	private static String GetPropertyName(Shader shader, Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C36EBC
	private static Int32 GetPropertyNameId(Shader shader, Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C36F0C
	private static ShaderPropertyType GetPropertyType(Shader shader, Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C36F5C
	private static String GetPropertyDescription(Shader shader, Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C36FAC
	private static ShaderPropertyFlags GetPropertyFlags(Shader shader, Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C36FFC
	private static String[] GetPropertyAttributes(Shader shader, Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C3704C
	private static Vector4 GetPropertyDefaultValue(Shader shader, Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C37110
	private static TextureDimension GetPropertyTextureDimension(Shader shader, Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C37160
	private static String GetPropertyTextureDefaultName(Shader shader, Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C371B0
	private static Void CheckPropertyIndex(Shader s, Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C37270
	public Int32 GetPropertyCount() { }

	// RVA: 0xFFFFFFFF75C372B0
	public Int32 FindPropertyIndex(String propertyName) { }

	// RVA: 0xFFFFFFFF75C37300
	public String GetPropertyName(Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C37354
	public Int32 GetPropertyNameId(Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C373A8
	public ShaderPropertyType GetPropertyType(Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C373FC
	public String GetPropertyDescription(Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C37450
	public ShaderPropertyFlags GetPropertyFlags(Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C374A4
	public String[] GetPropertyAttributes(Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C374F8
	public Single GetPropertyDefaultFloatValue(Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C375CC
	public Vector4 GetPropertyDefaultVectorValue(Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C37678
	public Vector2 GetPropertyRangeLimits(Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C3776C
	public TextureDimension GetPropertyTextureDimension(Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C37838
	public String GetPropertyTextureDefaultName(Int32 propertyIndex) { }

	// RVA: 0xFFFFFFFF75C34F18
	private static Void SetGlobalVectorImpl_Injected(Int32 name, ref Vector4 value) { }

	// RVA: 0xFFFFFFFF75C34FB8
	private static Void SetGlobalMatrixImpl_Injected(Int32 name, ref Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75C35204
	private static Void GetGlobalVectorImpl_Injected(Int32 name, out Vector4 ret) { }

	// RVA: 0xFFFFFFFF75C352CC
	private static Void GetGlobalMatrixImpl_Injected(Int32 name, out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75C370B8
	private static Void GetPropertyDefaultValue_Injected(Shader shader, Int32 propertyIndex, out Vector4 ret) { }

}

// Namespace: UnityEngine
public class Material
{
	// Properties
	public Shader shader { get; set; }
	public Color color { get; set; }
	public Texture mainTexture { get; set; }
	public Vector2 mainTextureOffset { get; set; }
	public Vector2 mainTextureScale { get; set; }
	public Int32 renderQueue { get; set; }
	public MaterialGlobalIlluminationFlags globalIlluminationFlags { get; set; }
	public Boolean doubleSidedGI { get; set; }
	public Boolean enableInstancing { get; set; }
	public Int32 passCount { get; }
	public String[] shaderKeywords { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C0C184
	private static Void CreateWithShader(Material self, Shader shader) { }

	// RVA: 0xFFFFFFFF75C0C1D4
	private static Void CreateWithMaterial(Material self, Material source) { }

	// RVA: 0xFFFFFFFF75C0C224
	private static Void CreateWithString(Material self) { }

	// RVA: 0xFFFFFFFF723BD988
	public Void .ctor(Shader shader) { }

	// RVA: 0xFFFFFFFF723BD9FC
	public Void .ctor(Material source) { }

	// RVA: 0xFFFFFFFF75C0C264
	public Void .ctor(String contents) { }

	// RVA: 0xFFFFFFFF723BC000
	public Shader get_shader() { }

	// RVA: 0xFFFFFFFF723BDA70
	public Void set_shader(Shader value) { }

	// RVA: 0xFFFFFFFF723BDAC4
	public Color get_color() { }

	// RVA: 0xFFFFFFFF723BDC6C
	public Void set_color(Color value) { }

	// RVA: 0xFFFFFFFF723BDE78
	public Texture get_mainTexture() { }

	// RVA: 0xFFFFFFFF723BE018
	public Void set_mainTexture(Texture value) { }

	// RVA: 0xFFFFFFFF75C0C3CC
	public Vector2 get_mainTextureOffset() { }

	// RVA: 0xFFFFFFFF723BE22C
	public Void set_mainTextureOffset(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C0C584
	public Vector2 get_mainTextureScale() { }

	// RVA: 0xFFFFFFFF723BE3BC
	public Void set_mainTextureScale(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C0C2C0
	private Int32 GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	// RVA: 0xFFFFFFFF723BE54C
	public Boolean HasProperty(Int32 nameID) { }

	// RVA: 0xFFFFFFFF723BE5A8
	public Boolean HasProperty(String name) { }

	// RVA: 0xFFFFFFFF723BE63C
	public Int32 get_renderQueue() { }

	// RVA: 0xFFFFFFFF723BE690
	public Void set_renderQueue(Int32 value) { }

	// RVA: 0xFFFFFFFF723BE6EC
	public Void EnableKeyword(String keyword) { }

	// RVA: 0xFFFFFFFF723BE740
	public Void DisableKeyword(String keyword) { }

	// RVA: 0xFFFFFFFF75C0C724
	public Boolean IsKeywordEnabled(String keyword) { }

	// RVA: 0xFFFFFFFF75C0C774
	public MaterialGlobalIlluminationFlags get_globalIlluminationFlags() { }

	// RVA: 0xFFFFFFFF75C0C7B4
	public Void set_globalIlluminationFlags(MaterialGlobalIlluminationFlags value) { }

	// RVA: 0xFFFFFFFF75C0C804
	public Boolean get_doubleSidedGI() { }

	// RVA: 0xFFFFFFFF75C0C844
	public Void set_doubleSidedGI(Boolean value) { }

	// RVA: 0xFFFFFFFF75C0C894
	public Boolean get_enableInstancing() { }

	// RVA: 0xFFFFFFFF75C0C8D4
	public Void set_enableInstancing(Boolean value) { }

	// RVA: 0xFFFFFFFF75C0C924
	public Int32 get_passCount() { }

	// RVA: 0xFFFFFFFF75C0C964
	public Void SetShaderPassEnabled(String passName, Boolean enabled) { }

	// RVA: 0xFFFFFFFF75C0C9BC
	public Boolean GetShaderPassEnabled(String passName) { }

	// RVA: 0xFFFFFFFF75C0CA0C
	public String GetPassName(Int32 pass) { }

	// RVA: 0xFFFFFFFF75C0CA5C
	public Int32 FindPass(String passName) { }

	// RVA: 0xFFFFFFFF75C0CAAC
	public Void SetOverrideTag(String tag, String val) { }

	// RVA: 0xFFFFFFFF75C0CB04
	private String GetTagImpl(String tag, Boolean currentSubShaderOnly, String defaultValue) { }

	// RVA: 0xFFFFFFFF75C0CB6C
	public String GetTag(String tag, Boolean searchFallbacks, String defaultValue) { }

	// RVA: 0xFFFFFFFF75C0CBD4
	public String GetTag(String tag, Boolean searchFallbacks) { }

	// RVA: 0xFFFFFFFF75C0CC40
	public Void Lerp(Material start, Material end, Single t) { }

	// RVA: 0xFFFFFFFF75C0CCA8
	public Boolean SetPass(Int32 pass) { }

	// RVA: 0xFFFFFFFF723BE794
	public Void CopyPropertiesFromMaterial(Material mat) { }

	// RVA: 0xFFFFFFFF75C0CCF8
	private String[] GetShaderKeywords() { }

	// RVA: 0xFFFFFFFF75C0CD38
	private Void SetShaderKeywords(String[] names) { }

	// RVA: 0xFFFFFFFF723BE7E8
	public String[] get_shaderKeywords() { }

	// RVA: 0xFFFFFFFF75C0CD88
	public Void set_shaderKeywords(String[] value) { }

	// RVA: 0xFFFFFFFF75C0CDD8
	public Int32 ComputeCRC() { }

	// RVA: 0xFFFFFFFF75C0CE18
	public String[] GetTexturePropertyNames() { }

	// RVA: 0xFFFFFFFF75C0CE58
	public Int32[] GetTexturePropertyNameIDs() { }

	// RVA: 0xFFFFFFFF75C0CE98
	private Void GetTexturePropertyNamesInternal(Object outNames) { }

	// RVA: 0xFFFFFFFF75C0CEE8
	private Void GetTexturePropertyNameIDsInternal(Object outNames) { }

	// RVA: 0xFFFFFFFF75C0CF38
	public Void GetTexturePropertyNames(List<T0> outNames) { }

	// RVA: 0xFFFFFFFF75C0CF88
	public Void GetTexturePropertyNameIDs(List<T0> outNames) { }

	// RVA: 0xFFFFFFFF75C0CFD8
	private Void SetFloatImpl(Int32 name, Single value) { }

	// RVA: 0xFFFFFFFF75C0D038
	private Void SetColorImpl(Int32 name, Color value) { }

	// RVA: 0xFFFFFFFF75C0D0F8
	private Void SetMatrixImpl(Int32 name, Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75C0D1A8
	private Void SetTextureImpl(Int32 name, Texture value) { }

	// RVA: 0xFFFFFFFF75C0D200
	private Void SetRenderTextureImpl(Int32 name, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0xFFFFFFFF75C0D268
	private Void SetBufferImpl(Int32 name, ComputeBuffer value) { }

	// RVA: 0xFFFFFFFF75C0D2C0
	private Void SetConstantBufferImpl(Int32 name, ComputeBuffer value, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75C0D330
	private Single GetFloatImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF723BE83C
	private Color GetColorImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C0D3D8
	private Matrix4x4 GetMatrixImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C0D4B0
	private Texture GetTextureImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C0D500
	private Void SetFloatArrayImpl(Int32 name, Single[] values, Int32 count) { }

	// RVA: 0xFFFFFFFF75C0D568
	private Void SetVectorArrayImpl(Int32 name, Vector4[] values, Int32 count) { }

	// RVA: 0xFFFFFFFF75C0D5D0
	private Void SetColorArrayImpl(Int32 name, Color[] values, Int32 count) { }

	// RVA: 0xFFFFFFFF75C0D638
	private Void SetMatrixArrayImpl(Int32 name, Matrix4x4[] values, Int32 count) { }

	// RVA: 0xFFFFFFFF75C0D6A0
	private Single[] GetFloatArrayImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C0D6F0
	private Vector4[] GetVectorArrayImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C0D740
	private Color[] GetColorArrayImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C0D790
	private Matrix4x4[] GetMatrixArrayImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C0D7E0
	private Int32 GetFloatArrayCountImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C0D830
	private Int32 GetVectorArrayCountImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C0D880
	private Int32 GetColorArrayCountImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C0D8D0
	private Int32 GetMatrixArrayCountImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C0D920
	private Void ExtractFloatArrayImpl(Int32 name, [Out] Single[] val) { }

	// RVA: 0xFFFFFFFF75C0D978
	private Void ExtractVectorArrayImpl(Int32 name, [Out] Vector4[] val) { }

	// RVA: 0xFFFFFFFF75C0D9D0
	private Void ExtractColorArrayImpl(Int32 name, [Out] Color[] val) { }

	// RVA: 0xFFFFFFFF75C0DA28
	private Void ExtractMatrixArrayImpl(Int32 name, [Out] Matrix4x4[] val) { }

	// RVA: 0xFFFFFFFF75C0DA80
	private Vector4 GetTextureScaleAndOffsetImpl(Int32 name) { }

	// RVA: 0xFFFFFFFF75C0DB48
	private Void SetTextureOffsetImpl(Int32 name, Vector2 offset) { }

	// RVA: 0xFFFFFFFF75C0DC04
	private Void SetTextureScaleImpl(Int32 name, Vector2 scale) { }

	// RVA: 0xFFFFFFFF75C0DCC0
	private Void SetFloatArray(Int32 name, Single[] values, Int32 count) { }

	// RVA: 0xFFFFFFFF75C0DDE4
	private Void SetVectorArray(Int32 name, Vector4[] values, Int32 count) { }

	// RVA: 0xFFFFFFFF75C0DF08
	private Void SetColorArray(Int32 name, Color[] values, Int32 count) { }

	// RVA: 0xFFFFFFFF75C0E02C
	private Void SetMatrixArray(Int32 name, Matrix4x4[] values, Int32 count) { }

	// RVA: 0xFFFFFFFF75C0E150
	private Void ExtractFloatArray(Int32 name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C0E2E4
	private Void ExtractVectorArray(Int32 name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C0E4B8
	private Void ExtractColorArray(Int32 name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C0E664
	private Void ExtractMatrixArray(Int32 name, List<T0> values) { }

	// RVA: 0xFFFFFFFF723BE900
	public Void SetFloat(String name, Single value) { }

	// RVA: 0xFFFFFFFF75C0E838
	public Void SetFloat(Int32 nameID, Single value) { }

	// RVA: 0xFFFFFFFF723BE9A4
	public Void SetInt(String name, Int32 value) { }

	// RVA: 0xFFFFFFFF75C0E898
	public Void SetInt(Int32 nameID, Int32 value) { }

	// RVA: 0xFFFFFFFF723BDDB4
	public Void SetColor(String name, Color value) { }

	// RVA: 0xFFFFFFFF75C0C314
	public Void SetColor(Int32 nameID, Color value) { }

	// RVA: 0xFFFFFFFF723BEA48
	public Void SetVector(String name, Vector4 value) { }

	// RVA: 0xFFFFFFFF723BEB24
	public Void SetVector(Int32 nameID, Vector4 value) { }

	// RVA: 0xFFFFFFFF75C0E8F0
	public Void SetMatrix(String name, Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75C0E998
	public Void SetMatrix(Int32 nameID, Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF723BE188
	public Void SetTexture(String name, Texture value) { }

	// RVA: 0xFFFFFFFF723BE12C
	public Void SetTexture(Int32 nameID, Texture value) { }

	// RVA: 0xFFFFFFFF75C0EA08
	public Void SetTexture(String name, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0xFFFFFFFF75C0EAA4
	public Void SetTexture(Int32 nameID, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0xFFFFFFFF75C0EB0C
	public Void SetBuffer(String name, ComputeBuffer value) { }

	// RVA: 0xFFFFFFFF75C0EB98
	public Void SetBuffer(Int32 nameID, ComputeBuffer value) { }

	// RVA: 0xFFFFFFFF75C0EBF0
	public Void SetConstantBuffer(String name, ComputeBuffer value, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75C0EC94
	public Void SetConstantBuffer(Int32 nameID, ComputeBuffer value, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75C0ED04
	public Void SetFloatArray(String name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C0EDBC
	public Void SetFloatArray(Int32 nameID, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C0EE44
	public Void SetFloatArray(String name, Single[] values) { }

	// RVA: 0xFFFFFFFF75C0EEC4
	public Void SetFloatArray(Int32 nameID, Single[] values) { }

	// RVA: 0xFFFFFFFF75C0EEE0
	public Void SetColorArray(String name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C0EFB4
	public Void SetColorArray(Int32 nameID, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C0F058
	public Void SetColorArray(String name, Color[] values) { }

	// RVA: 0xFFFFFFFF75C0F0D8
	public Void SetColorArray(Int32 nameID, Color[] values) { }

	// RVA: 0xFFFFFFFF75C0F0F4
	public Void SetVectorArray(String name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C0F1AC
	public Void SetVectorArray(Int32 nameID, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C0F234
	public Void SetVectorArray(String name, Vector4[] values) { }

	// RVA: 0xFFFFFFFF75C0F2B4
	public Void SetVectorArray(Int32 nameID, Vector4[] values) { }

	// RVA: 0xFFFFFFFF75C0F2D0
	public Void SetMatrixArray(String name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C0F3A4
	public Void SetMatrixArray(Int32 nameID, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C0F448
	public Void SetMatrixArray(String name, Matrix4x4[] values) { }

	// RVA: 0xFFFFFFFF75C0F4C8
	public Void SetMatrixArray(Int32 nameID, Matrix4x4[] values) { }

	// RVA: 0xFFFFFFFF723BEB9C
	public Single GetFloat(String name) { }

	// RVA: 0xFFFFFFFF75C0F4E4
	public Single GetFloat(Int32 nameID) { }

	// RVA: 0xFFFFFFFF723BEC30
	public Int32 GetInt(String name) { }

	// RVA: 0xFFFFFFFF75C0F534
	public Int32 GetInt(Int32 nameID) { }

	// RVA: 0xFFFFFFFF723BDBC4
	public Color GetColor(String name) { }

	// RVA: 0xFFFFFFFF75C0C310
	public Color GetColor(Int32 nameID) { }

	// RVA: 0xFFFFFFFF723BECE4
	public Vector4 GetVector(String name) { }

	// RVA: 0xFFFFFFFF75C0F5A4
	public Vector4 GetVector(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C0F5A8
	public Matrix4x4 GetMatrix(String name) { }

	// RVA: 0xFFFFFFFF75C0F65C
	public Matrix4x4 GetMatrix(Int32 nameID) { }

	// RVA: 0xFFFFFFFF723BDF84
	public Texture GetTexture(String name) { }

	// RVA: 0xFFFFFFFF75C0C37C
	public Texture GetTexture(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C0F6DC
	public Single[] GetFloatArray(String name) { }

	// RVA: 0xFFFFFFFF75C0F740
	public Single[] GetFloatArray(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C0F7D4
	public Color[] GetColorArray(String name) { }

	// RVA: 0xFFFFFFFF75C0F838
	public Color[] GetColorArray(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C0F8CC
	public Vector4[] GetVectorArray(String name) { }

	// RVA: 0xFFFFFFFF75C0F930
	public Vector4[] GetVectorArray(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C0F9C4
	public Matrix4x4[] GetMatrixArray(String name) { }

	// RVA: 0xFFFFFFFF75C0FA28
	public Matrix4x4[] GetMatrixArray(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C0FABC
	public Void GetFloatArray(String name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C0FB30
	public Void GetFloatArray(Int32 nameID, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C0FB34
	public Void GetColorArray(String name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C0FBA8
	public Void GetColorArray(Int32 nameID, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C0FBAC
	public Void GetVectorArray(String name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C0FC20
	public Void GetVectorArray(Int32 nameID, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C0FC24
	public Void GetMatrixArray(String name, List<T0> values) { }

	// RVA: 0xFFFFFFFF75C0FC98
	public Void GetMatrixArray(Int32 nameID, List<T0> values) { }

	// RVA: 0xFFFFFFFF723BE310
	public Void SetTextureOffset(String name, Vector2 value) { }

	// RVA: 0xFFFFFFFF75C0C520
	public Void SetTextureOffset(Int32 nameID, Vector2 value) { }

	// RVA: 0xFFFFFFFF723BE4A0
	public Void SetTextureScale(String name, Vector2 value) { }

	// RVA: 0xFFFFFFFF75C0C6C0
	public Void SetTextureScale(Int32 nameID, Vector2 value) { }

	// RVA: 0xFFFFFFFF75C0C49C
	public Vector2 GetTextureOffset(String name) { }

	// RVA: 0xFFFFFFFF75C0C464
	public Vector2 GetTextureOffset(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C0C644
	public Vector2 GetTextureScale(String name) { }

	// RVA: 0xFFFFFFFF75C0C614
	public Vector2 GetTextureScale(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C0D0A0
	private Void SetColorImpl_Injected(Int32 name, ref Color value) { }

	// RVA: 0xFFFFFFFF75C0D150
	private Void SetMatrixImpl_Injected(Int32 name, ref Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75C0D380
	private Void GetColorImpl_Injected(Int32 name, out Color ret) { }

	// RVA: 0xFFFFFFFF75C0D458
	private Void GetMatrixImpl_Injected(Int32 name, out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75C0DAF0
	private Void GetTextureScaleAndOffsetImpl_Injected(Int32 name, out Vector4 ret) { }

	// RVA: 0xFFFFFFFF75C0DBAC
	private Void SetTextureOffsetImpl_Injected(Int32 name, ref Vector2 offset) { }

	// RVA: 0xFFFFFFFF75C0DC68
	private Void SetTextureScaleImpl_Injected(Int32 name, ref Vector2 scale) { }

}

// Namespace: UnityEngine
public sealed class Flare
{
	// Methods

	// RVA: 0xFFFFFFFF75C02E00
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C02E5C
	private static Void Internal_Create(Flare self) { }

}

// Namespace: UnityEngine
public struct LightBakingOutput
{
	// Fields
	public Int32 probeOcclusionLightIndex; // 0x10
	public Int32 occlusionMaskChannel; // 0x14
	public LightmapBakeType lightmapBakeType; // 0x18
	public MixedLightingMode mixedLightingMode; // 0x1C
	public Boolean isBaked; // 0x20
}

// Namespace: UnityEngine
public enum LightShadowCasterMode
{
	// Fields
	public Int32 value__; // 0x10
	public const LightShadowCasterMode Default = 0;
	public const LightShadowCasterMode NonLightmappedOnly = 1;
	public const LightShadowCasterMode Everything = 2;
}

// Namespace: UnityEngine
public sealed class Light
{
	// Fields
	private Int32 m_BakedIndex; // 0x18

	// Properties
	public LightType type { get; set; }
	public LightShape shape { get; set; }
	public Single spotAngle { get; set; }
	public Single innerSpotAngle { get; set; }
	public Color color { get; set; }
	public Single colorTemperature { get; set; }
	public Boolean useColorTemperature { get; set; }
	public Single intensity { get; set; }
	public Single bounceIntensity { get; set; }
	public Boolean useBoundingSphereOverride { get; set; }
	public Vector4 boundingSphereOverride { get; set; }
	public Int32 shadowCustomResolution { get; set; }
	public Single shadowBias { get; set; }
	public Single shadowNormalBias { get; set; }
	public Single shadowNearPlane { get; set; }
	public Boolean useShadowMatrixOverride { get; set; }
	public Matrix4x4 shadowMatrixOverride { get; set; }
	public Single range { get; set; }
	public Flare flare { get; set; }
	public LightBakingOutput bakingOutput { get; set; }
	public Int32 cullingMask { get; set; }
	public Int32 renderingLayerMask { get; set; }
	public LightShadowCasterMode lightShadowCasterMode { get; set; }
	public LightShadows shadows { get; set; }
	public Single shadowStrength { get; set; }
	public LightShadowResolution shadowResolution { get; set; }
	public Single shadowSoftness { get; set; }
	public Single shadowSoftnessFade { get; set; }
	public Single[] layerShadowCullDistances { get; set; }
	public Single cookieSize { get; set; }
	public Texture cookie { get; set; }
	public LightRenderMode renderMode { get; set; }
	public Int32 bakedIndex { get; set; }
	public Int32 commandBufferCount { get; }
	public static Int32 pixelLightCount { get; set; }
	public Single shadowConstantBias { get; set; }
	public Single shadowObjectSizeBias { get; set; }
	public Boolean attenuate { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF723BC7C0
	public LightType get_type() { }

	// RVA: 0xFFFFFFFF75C08580
	public Void set_type(LightType value) { }

	// RVA: 0xFFFFFFFF75C085D0
	public LightShape get_shape() { }

	// RVA: 0xFFFFFFFF75C08610
	public Void set_shape(LightShape value) { }

	// RVA: 0xFFFFFFFF723BC814
	public Single get_spotAngle() { }

	// RVA: 0xFFFFFFFF75C08660
	public Void set_spotAngle(Single value) { }

	// RVA: 0xFFFFFFFF723BC868
	public Single get_innerSpotAngle() { }

	// RVA: 0xFFFFFFFF75C086B0
	public Void set_innerSpotAngle(Single value) { }

	// RVA: 0xFFFFFFFF723BC8BC
	public Color get_color() { }

	// RVA: 0xFFFFFFFF75C08750
	public Void set_color(Color value) { }

	// RVA: 0xFFFFFFFF75C087F8
	public Single get_colorTemperature() { }

	// RVA: 0xFFFFFFFF75C08838
	public Void set_colorTemperature(Single value) { }

	// RVA: 0xFFFFFFFF75C08888
	public Boolean get_useColorTemperature() { }

	// RVA: 0xFFFFFFFF75C088C8
	public Void set_useColorTemperature(Boolean value) { }

	// RVA: 0xFFFFFFFF723BC924
	public Single get_intensity() { }

	// RVA: 0xFFFFFFFF723BC978
	public Void set_intensity(Single value) { }

	// RVA: 0xFFFFFFFF75C08918
	public Single get_bounceIntensity() { }

	// RVA: 0xFFFFFFFF75C08958
	public Void set_bounceIntensity(Single value) { }

	// RVA: 0xFFFFFFFF75C089A8
	public Boolean get_useBoundingSphereOverride() { }

	// RVA: 0xFFFFFFFF75C089E8
	public Void set_useBoundingSphereOverride(Boolean value) { }

	// RVA: 0xFFFFFFFF75C08A38
	public Vector4 get_boundingSphereOverride() { }

	// RVA: 0xFFFFFFFF75C08AE4
	public Void set_boundingSphereOverride(Vector4 value) { }

	// RVA: 0xFFFFFFFF75C08B8C
	public Int32 get_shadowCustomResolution() { }

	// RVA: 0xFFFFFFFF723BC9CC
	public Void set_shadowCustomResolution(Int32 value) { }

	// RVA: 0xFFFFFFFF723BCA28
	public Single get_shadowBias() { }

	// RVA: 0xFFFFFFFF723BCA7C
	public Void set_shadowBias(Single value) { }

	// RVA: 0xFFFFFFFF723BCAD8
	public Single get_shadowNormalBias() { }

	// RVA: 0xFFFFFFFF723BCB2C
	public Void set_shadowNormalBias(Single value) { }

	// RVA: 0xFFFFFFFF75C08BCC
	public Single get_shadowNearPlane() { }

	// RVA: 0xFFFFFFFF75C08C0C
	public Void set_shadowNearPlane(Single value) { }

	// RVA: 0xFFFFFFFF75C08C5C
	public Boolean get_useShadowMatrixOverride() { }

	// RVA: 0xFFFFFFFF75C08C9C
	public Void set_useShadowMatrixOverride(Boolean value) { }

	// RVA: 0xFFFFFFFF75C08CEC
	public Matrix4x4 get_shadowMatrixOverride() { }

	// RVA: 0xFFFFFFFF75C08DB4
	public Void set_shadowMatrixOverride(Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF723BCB88
	public Single get_range() { }

	// RVA: 0xFFFFFFFF75C08E54
	public Void set_range(Single value) { }

	// RVA: 0xFFFFFFFF75C08EA4
	public Flare get_flare() { }

	// RVA: 0xFFFFFFFF75C08EE4
	public Void set_flare(Flare value) { }

	// RVA: 0xFFFFFFFF75C08F34
	public LightBakingOutput get_bakingOutput() { }

	// RVA: 0xFFFFFFFF75C08FF8
	public Void set_bakingOutput(LightBakingOutput value) { }

	// RVA: 0xFFFFFFFF75C09098
	public Int32 get_cullingMask() { }

	// RVA: 0xFFFFFFFF723BCBDC
	public Void set_cullingMask(Int32 value) { }

	// RVA: 0xFFFFFFFF75C090D8
	public Int32 get_renderingLayerMask() { }

	// RVA: 0xFFFFFFFF75C09118
	public Void set_renderingLayerMask(Int32 value) { }

	// RVA: 0xFFFFFFFF75C09168
	public LightShadowCasterMode get_lightShadowCasterMode() { }

	// RVA: 0xFFFFFFFF75C091A8
	public Void set_lightShadowCasterMode(LightShadowCasterMode value) { }

	// RVA: 0xFFFFFFFF75C091F8
	public Void Reset() { }

	// RVA: 0xFFFFFFFF723BCC30
	public LightShadows get_shadows() { }

	// RVA: 0xFFFFFFFF723BCC84
	public Void set_shadows(LightShadows value) { }

	// RVA: 0xFFFFFFFF723BCCE0
	public Single get_shadowStrength() { }

	// RVA: 0xFFFFFFFF75C09238
	public Void set_shadowStrength(Single value) { }

	// RVA: 0xFFFFFFFF75C09288
	public LightShadowResolution get_shadowResolution() { }

	// RVA: 0xFFFFFFFF723BCD34
	public Void set_shadowResolution(LightShadowResolution value) { }

	// RVA: 0xFFFFFFFF75C092C8
	public Single get_shadowSoftness() { }

	// RVA: 0xFFFFFFFF75C092D0
	public Void set_shadowSoftness(Single value) { }

	// RVA: 0xFFFFFFFF75C092D4
	public Single get_shadowSoftnessFade() { }

	// RVA: 0xFFFFFFFF75C092DC
	public Void set_shadowSoftnessFade(Single value) { }

	// RVA: 0xFFFFFFFF75C092E0
	public Single[] get_layerShadowCullDistances() { }

	// RVA: 0xFFFFFFFF75C09320
	public Void set_layerShadowCullDistances(Single[] value) { }

	// RVA: 0xFFFFFFFF75C09370
	public Single get_cookieSize() { }

	// RVA: 0xFFFFFFFF75C093B0
	public Void set_cookieSize(Single value) { }

	// RVA: 0xFFFFFFFF75C09400
	public Texture get_cookie() { }

	// RVA: 0xFFFFFFFF75C09440
	public Void set_cookie(Texture value) { }

	// RVA: 0xFFFFFFFF75C09490
	public LightRenderMode get_renderMode() { }

	// RVA: 0xFFFFFFFF75C094D0
	public Void set_renderMode(LightRenderMode value) { }

	// RVA: 0xFFFFFFFF75C09520
	public Int32 get_bakedIndex() { }

	// RVA: 0xFFFFFFFF75C09528
	public Void set_bakedIndex(Int32 value) { }

	// RVA: 0xFFFFFFFF723BCD88
	public Void AddCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	// RVA: 0xFFFFFFFF75C09530
	public Void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask) { }

	// RVA: 0xFFFFFFFF75C09598
	public Void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	// RVA: 0xFFFFFFFF75C09604
	public Void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask, ComputeQueueType queueType) { }

	// RVA: 0xFFFFFFFF75C09674
	public Void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	// RVA: 0xFFFFFFFF75C096CC
	public Void RemoveCommandBuffers(LightEvent evt) { }

	// RVA: 0xFFFFFFFF723BCDE8
	public Void RemoveAllCommandBuffers() { }

	// RVA: 0xFFFFFFFF75C0971C
	public CommandBuffer[] GetCommandBuffers(LightEvent evt) { }

	// RVA: 0xFFFFFFFF723BCE2C
	public Int32 get_commandBufferCount() { }

	// RVA: 0xFFFFFFFF75C0976C
	public static Int32 get_pixelLightCount() { }

	// RVA: 0xFFFFFFFF75C09774
	public static Void set_pixelLightCount(Int32 value) { }

	// RVA: 0xFFFFFFFF75C0977C
	public static Light[] GetLights(LightType type, Int32 layer) { }

	// RVA: 0xFFFFFFFF75C097CC
	public Single get_shadowConstantBias() { }

	// RVA: 0xFFFFFFFF75C097D4
	public Void set_shadowConstantBias(Single value) { }

	// RVA: 0xFFFFFFFF75C097D8
	public Single get_shadowObjectSizeBias() { }

	// RVA: 0xFFFFFFFF75C097E0
	public Void set_shadowObjectSizeBias(Single value) { }

	// RVA: 0xFFFFFFFF75C097E4
	public Boolean get_attenuate() { }

	// RVA: 0xFFFFFFFF75C097EC
	public Void set_attenuate(Boolean value) { }

	// RVA: 0xFFFFFFFF75C097F0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C08700
	private Void get_color_Injected(out Color ret) { }

	// RVA: 0xFFFFFFFF75C087A8
	private Void set_color_Injected(ref Color value) { }

	// RVA: 0xFFFFFFFF75C08A94
	private Void get_boundingSphereOverride_Injected(out Vector4 ret) { }

	// RVA: 0xFFFFFFFF75C08B3C
	private Void set_boundingSphereOverride_Injected(ref Vector4 value) { }

	// RVA: 0xFFFFFFFF75C08D64
	private Void get_shadowMatrixOverride_Injected(out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75C08E04
	private Void set_shadowMatrixOverride_Injected(ref Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75C08FA8
	private Void get_bakingOutput_Injected(out LightBakingOutput ret) { }

	// RVA: 0xFFFFFFFF75C09048
	private Void set_bakingOutput_Injected(ref LightBakingOutput value) { }

}

// Namespace: UnityEngine
public sealed class Skybox
{
	// Properties
	public Material material { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C3803C
	public Material get_material() { }

	// RVA: 0xFFFFFFFF75C3807C
	public Void set_material(Material value) { }

}

// Namespace: UnityEngine
public sealed class MeshFilter
{
	// Properties
	public Mesh sharedMesh { get; set; }
	public Mesh mesh { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C18DD4
	private Void DontStripMeshFilter() { }

	// RVA: 0xFFFFFFFF75C071CC
	public Mesh get_sharedMesh() { }

	// RVA: 0xFFFFFFFF75C079F0
	public Void set_sharedMesh(Mesh value) { }

	// RVA: 0xFFFFFFFF723C1FD0
	public Mesh get_mesh() { }

	// RVA: 0xFFFFFFFF723C2014
	public Void set_mesh(Mesh value) { }

	// RVA: 0xFFFFFFFF75C18DD8
	public Void .ctor() { }

}

// Namespace: UnityEngine
public enum RenderingPath
{
	// Fields
	public Int32 value__; // 0x10
	public const RenderingPath UsePlayerSettings = 4294967295;
	public const RenderingPath VertexLit = 0;
	public const RenderingPath Forward = 1;
	public const RenderingPath DeferredLighting = 2;
	public const RenderingPath DeferredShading = 3;
}

// Namespace: UnityEngine
public enum TransparencySortMode
{
	// Fields
	public Int32 value__; // 0x10
	public const TransparencySortMode Default = 0;
	public const TransparencySortMode Perspective = 1;
	public const TransparencySortMode Orthographic = 2;
	public const TransparencySortMode CustomAxis = 3;
}

// Namespace: UnityEngine
public enum StereoTargetEyeMask
{
	// Fields
	public Int32 value__; // 0x10
	public const StereoTargetEyeMask None = 0;
	public const StereoTargetEyeMask Left = 1;
	public const StereoTargetEyeMask Right = 2;
	public const StereoTargetEyeMask Both = 3;
}

// Namespace: UnityEngine
public enum CameraType
{
	// Fields
	public Int32 value__; // 0x10
	public const CameraType Game = 1;
	public const CameraType SceneView = 2;
	public const CameraType Preview = 4;
	public const CameraType VR = 8;
	public const CameraType Reflection = 16;
}

// Namespace: UnityEngine
public enum ComputeBufferType
{
	// Fields
	public Int32 value__; // 0x10
	public const ComputeBufferType Default = 0;
	public const ComputeBufferType Raw = 1;
	public const ComputeBufferType Append = 2;
	public const ComputeBufferType Counter = 4;
	public const ComputeBufferType Constant = 8;
	public const ComputeBufferType Structured = 16;
	public const ComputeBufferType DrawIndirect = 256;
	public const ComputeBufferType IndirectArguments = 256;
	public const ComputeBufferType GPUMemory = 512;
}

// Namespace: UnityEngine
public enum LightType
{
	// Fields
	public Int32 value__; // 0x10
	public const LightType Spot = 0;
	public const LightType Directional = 1;
	public const LightType Point = 2;
	public const LightType Area = 3;
	public const LightType Rectangle = 3;
	public const LightType Disc = 4;
}

// Namespace: UnityEngine
public enum LightShape
{
	// Fields
	public Int32 value__; // 0x10
	public const LightShape Cone = 0;
	public const LightShape Pyramid = 1;
	public const LightShape Box = 2;
}

// Namespace: UnityEngine
public enum LightRenderMode
{
	// Fields
	public Int32 value__; // 0x10
	public const LightRenderMode Auto = 0;
	public const LightRenderMode ForcePixel = 1;
	public const LightRenderMode ForceVertex = 2;
}

// Namespace: UnityEngine
public enum LightShadows
{
	// Fields
	public Int32 value__; // 0x10
	public const LightShadows None = 0;
	public const LightShadows Hard = 1;
	public const LightShadows Soft = 2;
}

// Namespace: UnityEngine
public enum FogMode
{
	// Fields
	public Int32 value__; // 0x10
	public const FogMode Linear = 1;
	public const FogMode Exponential = 2;
	public const FogMode ExponentialSquared = 3;
}

// Namespace: UnityEngine
public enum LightmapBakeType
{
	// Fields
	public Int32 value__; // 0x10
	public const LightmapBakeType Realtime = 4;
	public const LightmapBakeType Baked = 2;
	public const LightmapBakeType Mixed = 1;
}

// Namespace: UnityEngine
public enum MixedLightingMode
{
	// Fields
	public Int32 value__; // 0x10
	public const MixedLightingMode IndirectOnly = 0;
	public const MixedLightingMode Shadowmask = 2;
	public const MixedLightingMode Subtractive = 1;
}

// Namespace: UnityEngine
public enum ShadowProjection
{
	// Fields
	public Int32 value__; // 0x10
	public const ShadowProjection CloseFit = 0;
	public const ShadowProjection StableFit = 1;
}

// Namespace: UnityEngine
public enum ShadowQuality
{
	// Fields
	public Int32 value__; // 0x10
	public const ShadowQuality Disable = 0;
	public const ShadowQuality HardOnly = 1;
	public const ShadowQuality All = 2;
}

// Namespace: UnityEngine
public enum ShadowResolution
{
	// Fields
	public Int32 value__; // 0x10
	public const ShadowResolution Low = 0;
	public const ShadowResolution Medium = 1;
	public const ShadowResolution High = 2;
	public const ShadowResolution VeryHigh = 3;
}

// Namespace: UnityEngine
public enum ShadowmaskMode
{
	// Fields
	public Int32 value__; // 0x10
	public const ShadowmaskMode Shadowmask = 0;
	public const ShadowmaskMode DistanceShadowmask = 1;
}

// Namespace: UnityEngine
public enum CameraClearFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const CameraClearFlags Skybox = 1;
	public const CameraClearFlags Color = 2;
	public const CameraClearFlags SolidColor = 2;
	public const CameraClearFlags Depth = 3;
	public const CameraClearFlags Nothing = 4;
}

// Namespace: UnityEngine
public enum DepthTextureMode
{
	// Fields
	public Int32 value__; // 0x10
	public const DepthTextureMode None = 0;
	public const DepthTextureMode Depth = 1;
	public const DepthTextureMode DepthNormals = 2;
	public const DepthTextureMode MotionVectors = 4;
}

// Namespace: UnityEngine
public enum SkinWeights
{
	// Fields
	public Int32 value__; // 0x10
	public const SkinWeights OneBone = 1;
	public const SkinWeights TwoBones = 2;
	public const SkinWeights FourBones = 4;
	public const SkinWeights Unlimited = 255;
}

// Namespace: UnityEngine
public enum MeshTopology
{
	// Fields
	public Int32 value__; // 0x10
	public const MeshTopology Triangles = 0;
	public const MeshTopology Quads = 2;
	public const MeshTopology Lines = 3;
	public const MeshTopology LineStrip = 4;
	public const MeshTopology Points = 5;
}

// Namespace: UnityEngine
public enum SkinQuality
{
	// Fields
	public Int32 value__; // 0x10
	public const SkinQuality Auto = 0;
	public const SkinQuality Bone1 = 1;
	public const SkinQuality Bone2 = 2;
	public const SkinQuality Bone4 = 4;
}

// Namespace: UnityEngine
public enum ColorSpace
{
	// Fields
	public Int32 value__; // 0x10
	public const ColorSpace Uninitialized = 4294967295;
	public const ColorSpace Gamma = 0;
	public const ColorSpace Linear = 1;
}

// Namespace: UnityEngine
public enum ScreenOrientation
{
	// Fields
	public Int32 value__; // 0x10
	public const ScreenOrientation Unknown = 0;
	public const ScreenOrientation Portrait = 1;
	public const ScreenOrientation PortraitUpsideDown = 2;
	public const ScreenOrientation LandscapeLeft = 3;
	public const ScreenOrientation LandscapeRight = 4;
	public const ScreenOrientation AutoRotation = 5;
	public const ScreenOrientation Landscape = 3;
}

// Namespace: UnityEngine
public enum FilterMode
{
	// Fields
	public Int32 value__; // 0x10
	public const FilterMode Point = 0;
	public const FilterMode Bilinear = 1;
	public const FilterMode Trilinear = 2;
}

// Namespace: UnityEngine
public enum TextureWrapMode
{
	// Fields
	public Int32 value__; // 0x10
	public const TextureWrapMode Repeat = 0;
	public const TextureWrapMode Clamp = 1;
	public const TextureWrapMode Mirror = 2;
	public const TextureWrapMode MirrorOnce = 3;
}

// Namespace: UnityEngine
public enum NPOTSupport
{
	// Fields
	public Int32 value__; // 0x10
	public const NPOTSupport None = 0;
	public const NPOTSupport Restricted = 1;
	public const NPOTSupport Full = 2;
}

// Namespace: UnityEngine
public enum TextureFormat
{
	// Fields
	public Int32 value__; // 0x10
	public const TextureFormat Alpha8 = 1;
	public const TextureFormat ARGB4444 = 2;
	public const TextureFormat RGB24 = 3;
	public const TextureFormat RGBA32 = 4;
	public const TextureFormat ARGB32 = 5;
	public const TextureFormat RGB565 = 7;
	public const TextureFormat R16 = 9;
	public const TextureFormat DXT1 = 10;
	public const TextureFormat DXT5 = 12;
	public const TextureFormat RGBA4444 = 13;
	public const TextureFormat BGRA32 = 14;
	public const TextureFormat RHalf = 15;
	public const TextureFormat RGHalf = 16;
	public const TextureFormat RGBAHalf = 17;
	public const TextureFormat RFloat = 18;
	public const TextureFormat RGFloat = 19;
	public const TextureFormat RGBAFloat = 20;
	public const TextureFormat YUY2 = 21;
	public const TextureFormat RGB9e5Float = 22;
	public const TextureFormat BC4 = 26;
	public const TextureFormat BC5 = 27;
	public const TextureFormat BC6H = 24;
	public const TextureFormat BC7 = 25;
	public const TextureFormat PVRTC_RGB2 = 30;
	public const TextureFormat PVRTC_RGBA2 = 31;
	public const TextureFormat PVRTC_RGB4 = 32;
	public const TextureFormat PVRTC_RGBA4 = 33;
	public const TextureFormat ETC_RGB4 = 34;
	public const TextureFormat EAC_R = 41;
	public const TextureFormat EAC_R_SIGNED = 42;
	public const TextureFormat EAC_RG = 43;
	public const TextureFormat EAC_RG_SIGNED = 44;
	public const TextureFormat ETC2_RGB = 45;
	public const TextureFormat ETC2_RGBA1 = 46;
	public const TextureFormat ETC2_RGBA8 = 47;
	public const TextureFormat ASTC_4x4 = 48;
	public const TextureFormat ASTC_5x5 = 49;
	public const TextureFormat ASTC_6x6 = 50;
	public const TextureFormat ASTC_8x8 = 51;
	public const TextureFormat ASTC_10x10 = 52;
	public const TextureFormat ASTC_12x12 = 53;
	public const TextureFormat ETC_RGB4_3DS = 60;
	public const TextureFormat ETC_RGBA8_3DS = 61;
	public const TextureFormat RG16 = 62;
	public const TextureFormat R8 = 63;
	public const TextureFormat ASTC_HDR_4x4 = 66;
	public const TextureFormat ASTC_HDR_5x5 = 67;
	public const TextureFormat ASTC_HDR_6x6 = 68;
	public const TextureFormat ASTC_HDR_8x8 = 69;
	public const TextureFormat ASTC_HDR_10x10 = 70;
	public const TextureFormat ASTC_HDR_12x12 = 71;
	public const TextureFormat RG32 = 72;
	public const TextureFormat RGB48 = 73;
	public const TextureFormat RGBA64 = 74;
	public const TextureFormat ASTC_RGB_4x4 = 48;
	public const TextureFormat ASTC_RGB_5x5 = 49;
	public const TextureFormat ASTC_RGB_6x6 = 50;
	public const TextureFormat ASTC_RGB_8x8 = 51;
	public const TextureFormat ASTC_RGB_10x10 = 52;
	public const TextureFormat ASTC_RGB_12x12 = 53;
	public const TextureFormat ASTC_RGBA_4x4 = 54;
	public const TextureFormat ASTC_RGBA_5x5 = 55;
	public const TextureFormat ASTC_RGBA_6x6 = 56;
	public const TextureFormat ASTC_RGBA_8x8 = 57;
	public const TextureFormat ASTC_RGBA_10x10 = 58;
	public const TextureFormat ASTC_RGBA_12x12 = 59;
}

// Namespace: UnityEngine
public enum CubemapFace
{
	// Fields
	public Int32 value__; // 0x10
	public const CubemapFace Unknown = 4294967295;
	public const CubemapFace PositiveX = 0;
	public const CubemapFace NegativeX = 1;
	public const CubemapFace PositiveY = 2;
	public const CubemapFace NegativeY = 3;
	public const CubemapFace PositiveZ = 4;
	public const CubemapFace NegativeZ = 5;
}

// Namespace: UnityEngine
public enum RenderTextureFormat
{
	// Fields
	public Int32 value__; // 0x10
	public const RenderTextureFormat ARGB32 = 0;
	public const RenderTextureFormat Depth = 1;
	public const RenderTextureFormat ARGBHalf = 2;
	public const RenderTextureFormat Shadowmap = 3;
	public const RenderTextureFormat RGB565 = 4;
	public const RenderTextureFormat ARGB4444 = 5;
	public const RenderTextureFormat ARGB1555 = 6;
	public const RenderTextureFormat Default = 7;
	public const RenderTextureFormat ARGB2101010 = 8;
	public const RenderTextureFormat DefaultHDR = 9;
	public const RenderTextureFormat ARGB64 = 10;
	public const RenderTextureFormat ARGBFloat = 11;
	public const RenderTextureFormat RGFloat = 12;
	public const RenderTextureFormat RGHalf = 13;
	public const RenderTextureFormat RFloat = 14;
	public const RenderTextureFormat RHalf = 15;
	public const RenderTextureFormat R8 = 16;
	public const RenderTextureFormat ARGBInt = 17;
	public const RenderTextureFormat RGInt = 18;
	public const RenderTextureFormat RInt = 19;
	public const RenderTextureFormat BGRA32 = 20;
	public const RenderTextureFormat RGB111110Float = 22;
	public const RenderTextureFormat RG32 = 23;
	public const RenderTextureFormat RGBAUShort = 24;
	public const RenderTextureFormat RG16 = 25;
	public const RenderTextureFormat BGRA10101010_XR = 26;
	public const RenderTextureFormat BGR101010_XR = 27;
	public const RenderTextureFormat R16 = 28;
}

// Namespace: UnityEngine
public enum VRTextureUsage
{
	// Fields
	public Int32 value__; // 0x10
	public const VRTextureUsage None = 0;
	public const VRTextureUsage OneEye = 1;
	public const VRTextureUsage TwoEyes = 2;
	public const VRTextureUsage DeviceSpecific = 3;
}

// Namespace: UnityEngine
public enum RenderTextureCreationFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const RenderTextureCreationFlags MipMap = 1;
	public const RenderTextureCreationFlags AutoGenerateMips = 2;
	public const RenderTextureCreationFlags SRGB = 4;
	public const RenderTextureCreationFlags EyeTexture = 8;
	public const RenderTextureCreationFlags EnableRandomWrite = 16;
	public const RenderTextureCreationFlags CreatedFromScript = 32;
	public const RenderTextureCreationFlags AllowVerticalFlip = 128;
	public const RenderTextureCreationFlags NoResolvedColorSurface = 256;
	public const RenderTextureCreationFlags DynamicallyScalable = 1024;
	public const RenderTextureCreationFlags BindMS = 2048;
}

// Namespace: UnityEngine
public enum RenderTextureReadWrite
{
	// Fields
	public Int32 value__; // 0x10
	public const RenderTextureReadWrite Default = 0;
	public const RenderTextureReadWrite Linear = 1;
	public const RenderTextureReadWrite sRGB = 2;
}

// Namespace: UnityEngine
public enum RenderTextureMemoryless
{
	// Fields
	public Int32 value__; // 0x10
	public const RenderTextureMemoryless None = 0;
	public const RenderTextureMemoryless Color = 1;
	public const RenderTextureMemoryless Depth = 2;
	public const RenderTextureMemoryless MSAA = 4;
}

// Namespace: UnityEngine
public enum LightmapsMode
{
	// Fields
	public Int32 value__; // 0x10
	public const LightmapsMode NonDirectional = 0;
	public const LightmapsMode CombinedDirectional = 1;
}

// Namespace: UnityEngine
public enum MaterialGlobalIlluminationFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const MaterialGlobalIlluminationFlags None = 0;
	public const MaterialGlobalIlluminationFlags RealtimeEmissive = 1;
	public const MaterialGlobalIlluminationFlags BakedEmissive = 2;
	public const MaterialGlobalIlluminationFlags EmissiveIsBlack = 4;
	public const MaterialGlobalIlluminationFlags AnyEmissive = 3;
}

// Namespace: UnityEngine
public sealed class LightProbeProxyVolume
{}

// Namespace: UnityEngine
public enum MotionVectorGenerationMode
{
	// Fields
	public Int32 value__; // 0x10
	public const MotionVectorGenerationMode Camera = 0;
	public const MotionVectorGenerationMode Object = 1;
	public const MotionVectorGenerationMode ForceNoMotion = 2;
}

// Namespace: UnityEngine
public enum LineTextureMode
{
	// Fields
	public Int32 value__; // 0x10
	public const LineTextureMode Stretch = 0;
	public const LineTextureMode Tile = 1;
	public const LineTextureMode DistributePerSegment = 2;
	public const LineTextureMode RepeatPerSegment = 3;
}

// Namespace: UnityEngine
public enum LineAlignment
{
	// Fields
	public Int32 value__; // 0x10
	public const LineAlignment View = 0;
	public const LineAlignment Local = 1;
	public const LineAlignment TransformZ = 1;
}

// Namespace: UnityEngine
public class SkinnedMeshRenderer
{
	// Properties
	public SkinQuality quality { get; set; }
	public Boolean updateWhenOffscreen { get; set; }
	public Boolean forceMatrixRecalculationPerRender { get; set; }
	public Transform rootBone { get; set; }
	public Transform[] bones { get; set; }
	public Mesh sharedMesh { get; set; }
	public Boolean skinnedMotionVectors { get; set; }
	public Bounds localBounds { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C37904
	public SkinQuality get_quality() { }

	// RVA: 0xFFFFFFFF75C37944
	public Void set_quality(SkinQuality value) { }

	// RVA: 0xFFFFFFFF75C37994
	public Boolean get_updateWhenOffscreen() { }

	// RVA: 0xFFFFFFFF75C379D4
	public Void set_updateWhenOffscreen(Boolean value) { }

	// RVA: 0xFFFFFFFF75C37A24
	public Boolean get_forceMatrixRecalculationPerRender() { }

	// RVA: 0xFFFFFFFF75C37A64
	public Void set_forceMatrixRecalculationPerRender(Boolean value) { }

	// RVA: 0xFFFFFFFF75C37AB4
	public Transform get_rootBone() { }

	// RVA: 0xFFFFFFFF75C37AF4
	public Void set_rootBone(Transform value) { }

	// RVA: 0xFFFFFFFF75C37B44
	public Transform[] get_bones() { }

	// RVA: 0xFFFFFFFF75C37B88
	public Void set_bones(Transform[] value) { }

	// RVA: 0xFFFFFFFF75C37BD8
	public Mesh get_sharedMesh() { }

	// RVA: 0xFFFFFFFF75C37C18
	public Void set_sharedMesh(Mesh value) { }

	// RVA: 0xFFFFFFFF75C37C68
	public Boolean get_skinnedMotionVectors() { }

	// RVA: 0xFFFFFFFF75C37CA8
	public Void set_skinnedMotionVectors(Boolean value) { }

	// RVA: 0xFFFFFFFF75C37CF8
	public Single GetBlendShapeWeight(Int32 index) { }

	// RVA: 0xFFFFFFFF75C37D48
	public Void SetBlendShapeWeight(Int32 index, Single value) { }

	// RVA: 0xFFFFFFFF75C37DAC
	public Void BakeMesh(Mesh mesh) { }

	// RVA: 0xFFFFFFFF75C37DFC
	private Bounds GetLocalAABB() { }

	// RVA: 0xFFFFFFFF75C37EC0
	private Void SetLocalAABB(Bounds b) { }

	// RVA: 0xFFFFFFFF75C37F60
	public Bounds get_localBounds() { }

	// RVA: 0xFFFFFFFF75C37FD4
	public Void set_localBounds(Bounds value) { }

	// RVA: 0xFFFFFFFF75C38034
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C37E70
	private Void GetLocalAABB_Injected(out Bounds ret) { }

	// RVA: 0xFFFFFFFF75C37F10
	private Void SetLocalAABB_Injected(ref Bounds b) { }

}

// Namespace: UnityEngine
public class MeshRenderer
{
	// Properties
	public Mesh additionalVertexStreams { get; set; }
	public Int32 subMeshStartIndex { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C18DE0
	private Void DontStripMeshRenderer() { }

	// RVA: 0xFFFFFFFF75C0720C
	public Mesh get_additionalVertexStreams() { }

	// RVA: 0xFFFFFFFF75C07A40
	public Void set_additionalVertexStreams(Mesh value) { }

	// RVA: 0xFFFFFFFF75C18DE4
	public Int32 get_subMeshStartIndex() { }

	// RVA: 0xFFFFFFFF75C18E24
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class Mesh
{
	// Properties
	public IndexFormat indexFormat { get; set; }
	public Int32 vertexBufferCount { get; }
	public Int32 blendShapeCount { get; }
	public Matrix4x4[] bindposes { get; set; }
	public Boolean isReadable { get; }
	internal Boolean canAccess { get; }
	public Int32 vertexCount { get; }
	public Int32 subMeshCount { get; set; }
	public Bounds bounds { get; set; }
	public Vector3[] vertices { get; set; }
	public Vector3[] normals { get; set; }
	public Vector4[] tangents { get; set; }
	public Vector2[] uv { get; set; }
	public Vector2[] uv2 { get; set; }
	public Vector2[] uv3 { get; set; }
	public Vector2[] uv4 { get; set; }
	public Vector2[] uv5 { get; set; }
	public Vector2[] uv6 { get; set; }
	public Vector2[] uv7 { get; set; }
	public Vector2[] uv8 { get; set; }
	public Color[] colors { get; set; }
	public Color32[] colors32 { get; set; }
	public Int32 vertexAttributeCount { get; }
	public Int32[] triangles { get; set; }
	public BoneWeight[] boneWeights { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C13340
	private static Void Internal_Create(Mesh mono) { }

	// RVA: 0xFFFFFFFF723C03EC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C13380
	internal static Mesh FromInstanceID(Int32 id) { }

	// RVA: 0xFFFFFFFF75C133C0
	public IndexFormat get_indexFormat() { }

	// RVA: 0xFFFFFFFF75C13400
	public Void set_indexFormat(IndexFormat value) { }

	// RVA: 0xFFFFFFFF75C13450
	public Void SetIndexBufferParams(Int32 indexCount, IndexFormat format) { }

	// RVA: 0xFFFFFFFF75C134A8
	private Void InternalSetIndexBufferData(IntPtr data, Int32 dataStart, Int32 meshBufferStart, Int32 count, Int32 elemSize, MeshUpdateFlags flags) { }

	// RVA: 0xFFFFFFFF75C13530
	private Void InternalSetIndexBufferDataFromArray(Array data, Int32 dataStart, Int32 meshBufferStart, Int32 count, Int32 elemSize, MeshUpdateFlags flags) { }

	// RVA: 0xFFFFFFFF75C135B8
	public Void SetVertexBufferParams(Int32 vertexCount, VertexAttributeDescriptor[] attributes) { }

	// RVA: 0xFFFFFFFF75C13610
	private Void InternalSetVertexBufferData(Int32 stream, IntPtr data, Int32 dataStart, Int32 meshBufferStart, Int32 count, Int32 elemSize, MeshUpdateFlags flags) { }

	// RVA: 0xFFFFFFFF75C136A8
	private Void InternalSetVertexBufferDataFromArray(Int32 stream, Array data, Int32 dataStart, Int32 meshBufferStart, Int32 count, Int32 elemSize, MeshUpdateFlags flags) { }

	// RVA: 0xFFFFFFFF75C13740
	private Array GetVertexAttributesAlloc() { }

	// RVA: 0xFFFFFFFF75C13780
	private Int32 GetVertexAttributesArray(VertexAttributeDescriptor[] attributes) { }

	// RVA: 0xFFFFFFFF75C137D0
	private Int32 GetVertexAttributesList(List<T0> attributes) { }

	// RVA: 0xFFFFFFFF75C13820
	private Int32 GetVertexAttributeCountImpl() { }

	// RVA: 0xFFFFFFFF75C13860
	public VertexAttributeDescriptor GetVertexAttribute(Int32 index) { }

	// RVA: 0xFFFFFFFF75C13934
	private UInt32 GetIndexStartImpl(Int32 submesh) { }

	// RVA: 0xFFFFFFFF75C13984
	private UInt32 GetIndexCountImpl(Int32 submesh) { }

	// RVA: 0xFFFFFFFF75C139D4
	private UInt32 GetTrianglesCountImpl(Int32 submesh) { }

	// RVA: 0xFFFFFFFF75C13A24
	private UInt32 GetBaseVertexImpl(Int32 submesh) { }

	// RVA: 0xFFFFFFFF75C13A74
	private Int32[] GetTrianglesImpl(Int32 submesh, Boolean applyBaseVertex) { }

	// RVA: 0xFFFFFFFF75C13ACC
	private Int32[] GetIndicesImpl(Int32 submesh, Boolean applyBaseVertex) { }

	// RVA: 0xFFFFFFFF75C13B24
	private Void SetIndicesImpl(Int32 submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, Int32 arrayStart, Int32 arraySize, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF75C13BC4
	private Void SetIndicesNativeArrayImpl(Int32 submesh, MeshTopology topology, IndexFormat indicesFormat, IntPtr indices, Int32 arrayStart, Int32 arraySize, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF75C13C64
	private Void GetTrianglesNonAllocImpl([Out] Int32[] values, Int32 submesh, Boolean applyBaseVertex) { }

	// RVA: 0xFFFFFFFF75C13CCC
	private Void GetTrianglesNonAllocImpl16([Out] UInt16[] values, Int32 submesh, Boolean applyBaseVertex) { }

	// RVA: 0xFFFFFFFF75C13D34
	private Void GetIndicesNonAllocImpl([Out] Int32[] values, Int32 submesh, Boolean applyBaseVertex) { }

	// RVA: 0xFFFFFFFF75C13D9C
	private Void GetIndicesNonAllocImpl16([Out] UInt16[] values, Int32 submesh, Boolean applyBaseVertex) { }

	// RVA: 0xFFFFFFFF75C13E04
	private Void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	// RVA: 0xFFFFFFFF723C046C
	public Boolean HasVertexAttribute(VertexAttribute attr) { }

	// RVA: 0xFFFFFFFF75C13E54
	public Int32 GetVertexAttributeDimension(VertexAttribute attr) { }

	// RVA: 0xFFFFFFFF75C13EA4
	public VertexAttributeFormat GetVertexAttributeFormat(VertexAttribute attr) { }

	// RVA: 0xFFFFFFFF75C13EF4
	private Void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, Int32 dim, Array values, Int32 arraySize, Int32 valuesStart, Int32 valuesCount) { }

	// RVA: 0xFFFFFFFF75C13F8C
	private Void SetNativeArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, Int32 dim, IntPtr values, Int32 arraySize, Int32 valuesStart, Int32 valuesCount) { }

	// RVA: 0xFFFFFFFF723C04C8
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, Int32 dim) { }

	// RVA: 0xFFFFFFFF75C14024
	private Void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, Int32 dim, Array values) { }

	// RVA: 0xFFFFFFFF75C14094
	public Int32 get_vertexBufferCount() { }

	// RVA: 0xFFFFFFFF75C140D4
	public IntPtr GetNativeVertexBufferPtr(Int32 index) { }

	// RVA: 0xFFFFFFFF75C14124
	public IntPtr GetNativeIndexBufferPtr() { }

	// RVA: 0xFFFFFFFF75C14164
	public Int32 get_blendShapeCount() { }

	// RVA: 0xFFFFFFFF75C141A4
	public Void ClearBlendShapes() { }

	// RVA: 0xFFFFFFFF75C141E4
	public String GetBlendShapeName(Int32 shapeIndex) { }

	// RVA: 0xFFFFFFFF75C14234
	public Int32 GetBlendShapeIndex(String blendShapeName) { }

	// RVA: 0xFFFFFFFF75C14284
	public Int32 GetBlendShapeFrameCount(Int32 shapeIndex) { }

	// RVA: 0xFFFFFFFF75C142D4
	public Single GetBlendShapeFrameWeight(Int32 shapeIndex, Int32 frameIndex) { }

	// RVA: 0xFFFFFFFF75C1432C
	public Void GetBlendShapeFrameVertices(Int32 shapeIndex, Int32 frameIndex, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) { }

	// RVA: 0xFFFFFFFF75C143AC
	public Void AddBlendShapeFrame(String shapeName, Single frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) { }

	// RVA: 0xFFFFFFFF75C1442C
	private Boolean HasBoneWeights() { }

	// RVA: 0xFFFFFFFF75C1446C
	private BoneWeight[] GetBoneWeightsImpl() { }

	// RVA: 0xFFFFFFFF75C144AC
	private Void SetBoneWeightsImpl(BoneWeight[] weights) { }

	// RVA: 0xFFFFFFFF75C144FC
	public Void SetBoneWeights(NativeArray<T0> bonesPerVertex, NativeArray<T0> weights) { }

	// RVA: 0xFFFFFFFF75C145F8
	private Void InternalSetBoneWeights(IntPtr bonesPerVertex, Int32 bonesPerVertexSize, IntPtr weights, Int32 weightsSize) { }

	// RVA: 0xFFFFFFFF75C14668
	public NativeArray<T0> GetAllBoneWeights() { }

	// RVA: 0xFFFFFFFF75C147A0
	public NativeArray<T0> GetBonesPerVertex() { }

	// RVA: 0xFFFFFFFF75C14760
	private Int32 GetAllBoneWeightsArraySize() { }

	// RVA: 0xFFFFFFFF75C14720
	private IntPtr GetAllBoneWeightsArray() { }

	// RVA: 0xFFFFFFFF75C14888
	private IntPtr GetBonesPerVertexArray() { }

	// RVA: 0xFFFFFFFF75C148C8
	private Int32 GetBindposeCount() { }

	// RVA: 0xFFFFFFFF75C14908
	public Matrix4x4[] get_bindposes() { }

	// RVA: 0xFFFFFFFF75C14948
	public Void set_bindposes(Matrix4x4[] value) { }

	// RVA: 0xFFFFFFFF75C14998
	private Void GetBoneWeightsNonAllocImpl([Out] BoneWeight[] values) { }

	// RVA: 0xFFFFFFFF75C149E8
	private Void GetBindposesNonAllocImpl([Out] Matrix4x4[] values) { }

	// RVA: 0xFFFFFFFF75C14A38
	public Boolean get_isReadable() { }

	// RVA: 0xFFFFFFFF723BBD78
	internal Boolean get_canAccess() { }

	// RVA: 0xFFFFFFFF723BBDCC
	public Int32 get_vertexCount() { }

	// RVA: 0xFFFFFFFF75C079B0
	public Int32 get_subMeshCount() { }

	// RVA: 0xFFFFFFFF75C14A78
	public Void set_subMeshCount(Int32 value) { }

	// RVA: 0xFFFFFFFF75C14AC8
	public Void SetSubMesh(Int32 index, SubMeshDescriptor desc, MeshUpdateFlags flags) { }

	// RVA: 0xFFFFFFFF75C14B98
	public SubMeshDescriptor GetSubMesh(Int32 index) { }

	// RVA: 0xFFFFFFFF75C14C70
	public Bounds get_bounds() { }

	// RVA: 0xFFFFFFFF75C14D34
	public Void set_bounds(Bounds value) { }

	// RVA: 0xFFFFFFFF75C14DD4
	private Void ClearImpl(Boolean keepVertexLayout) { }

	// RVA: 0xFFFFFFFF75C14E24
	private Void RecalculateBoundsImpl() { }

	// RVA: 0xFFFFFFFF75C14E64
	private Void RecalculateNormalsImpl() { }

	// RVA: 0xFFFFFFFF75C14EA4
	private Void RecalculateTangentsImpl() { }

	// RVA: 0xFFFFFFFF75C14EE4
	private Void MarkDynamicImpl() { }

	// RVA: 0xFFFFFFFF75C14F24
	public Void MarkModified() { }

	// RVA: 0xFFFFFFFF75C14F64
	private Void UploadMeshDataImpl(Boolean markNoLongerReadable) { }

	// RVA: 0xFFFFFFFF75C14FB4
	private MeshTopology GetTopologyImpl(Int32 submesh) { }

	// RVA: 0xFFFFFFFF75C15004
	public Single GetUVDistributionMetric(Int32 uvSetIndex) { }

	// RVA: 0xFFFFFFFF75C15054
	private Void CombineMeshesImpl(CombineInstance[] combine, Boolean mergeSubMeshes, Boolean useMatrices, Boolean hasLightmapData) { }

	// RVA: 0xFFFFFFFF75C150C4
	private Void OptimizeImpl() { }

	// RVA: 0xFFFFFFFF75C15104
	private Void OptimizeIndexBuffersImpl() { }

	// RVA: 0xFFFFFFFF75C15144
	private Void OptimizeReorderVertexBufferImpl() { }

	// RVA: 0xFFFFFFFF723C0534
	internal VertexAttribute GetUVChannel(Int32 uvIndex) { }

	// RVA: 0xFFFFFFFF723C0588
	internal static Int32 DefaultDimensionForChannel(VertexAttribute channel) { }

	// RVA: -1
	private T[] GetAllocArrayFromChannel(VertexAttribute channel, VertexAttributeFormat format, Int32 dim) { }

	// RVA: -1
	private T[] GetAllocArrayFromChannel(VertexAttribute channel) { }

	// RVA: 0xFFFFFFFF723C0604
	private Void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, Int32 dim, Array values, Int32 valuesArrayLength, Int32 valuesStart, Int32 valuesCount) { }

	// RVA: 0xFFFFFFFF75C15184
	private Void SetSizedNativeArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, Int32 dim, IntPtr values, Int32 valuesArrayLength, Int32 valuesStart, Int32 valuesCount) { }

	// RVA: -1
	private Void SetArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, Int32 dim, T[] values) { }

	// RVA: -1
	private Void SetArrayForChannel(VertexAttribute channel, T[] values) { }

	// RVA: -1
	private Void SetListForChannel(VertexAttribute channel, VertexAttributeFormat format, Int32 dim, List<T0> values, Int32 start, Int32 length) { }

	// RVA: -1
	private Void SetListForChannel(VertexAttribute channel, List<T0> values, Int32 start, Int32 length) { }

	// RVA: -1
	private Void GetListForChannel(List<T0> buffer, Int32 capacity, VertexAttribute channel, Int32 dim) { }

	// RVA: -1
	private Void GetListForChannel(List<T0> buffer, Int32 capacity, VertexAttribute channel, Int32 dim, VertexAttributeFormat channelType) { }

	// RVA: 0xFFFFFFFF75C153E0
	public Vector3[] get_vertices() { }

	// RVA: 0xFFFFFFFF723C0858
	public Void set_vertices(Vector3[] value) { }

	// RVA: 0xFFFFFFFF75C15440
	public Vector3[] get_normals() { }

	// RVA: 0xFFFFFFFF723C0914
	public Void set_normals(Vector3[] value) { }

	// RVA: 0xFFFFFFFF75C154A0
	public Vector4[] get_tangents() { }

	// RVA: 0xFFFFFFFF75C15500
	public Void set_tangents(Vector4[] value) { }

	// RVA: 0xFFFFFFFF723C09D0
	public Vector2[] get_uv() { }

	// RVA: 0xFFFFFFFF723C09F4
	public Void set_uv(Vector2[] value) { }

	// RVA: 0xFFFFFFFF75C15514
	public Vector2[] get_uv2() { }

	// RVA: 0xFFFFFFFF723C0AB0
	public Void set_uv2(Vector2[] value) { }

	// RVA: 0xFFFFFFFF75C15538
	public Vector2[] get_uv3() { }

	// RVA: 0xFFFFFFFF75C1555C
	public Void set_uv3(Vector2[] value) { }

	// RVA: 0xFFFFFFFF75C15570
	public Vector2[] get_uv4() { }

	// RVA: 0xFFFFFFFF75C15594
	public Void set_uv4(Vector2[] value) { }

	// RVA: 0xFFFFFFFF75C155A8
	public Vector2[] get_uv5() { }

	// RVA: 0xFFFFFFFF75C155CC
	public Void set_uv5(Vector2[] value) { }

	// RVA: 0xFFFFFFFF75C155E0
	public Vector2[] get_uv6() { }

	// RVA: 0xFFFFFFFF75C15604
	public Void set_uv6(Vector2[] value) { }

	// RVA: 0xFFFFFFFF75C15618
	public Vector2[] get_uv7() { }

	// RVA: 0xFFFFFFFF75C1563C
	public Void set_uv7(Vector2[] value) { }

	// RVA: 0xFFFFFFFF75C15650
	public Vector2[] get_uv8() { }

	// RVA: 0xFFFFFFFF75C15674
	public Void set_uv8(Vector2[] value) { }

	// RVA: 0xFFFFFFFF75C15688
	public Color[] get_colors() { }

	// RVA: 0xFFFFFFFF723C0B6C
	public Void set_colors(Color[] value) { }

	// RVA: 0xFFFFFFFF75C156E8
	public Color32[] get_colors32() { }

	// RVA: 0xFFFFFFFF75C15750
	public Void set_colors32(Color32[] value) { }

	// RVA: 0xFFFFFFFF75C1576C
	public Void GetVertices(List<T0> vertices) { }

	// RVA: 0xFFFFFFFF723C0C64
	public Void SetVertices(List<T0> inVertices) { }

	// RVA: 0xFFFFFFFF75C15864
	public Void SetVertices(List<T0> inVertices, Int32 start, Int32 length) { }

	// RVA: 0xFFFFFFFF75C158E4
	public Void SetVertices(Vector3[] inVertices) { }

	// RVA: 0xFFFFFFFF75C15964
	public Void SetVertices(Vector3[] inVertices, Int32 start, Int32 length) { }

	// RVA: -1
	public Void SetVertices(NativeArray<T0> inVertices) { }

	// RVA: -1
	public Void SetVertices(NativeArray<T0> inVertices, Int32 start, Int32 length) { }

	// RVA: 0xFFFFFFFF75C159D8
	public Void GetNormals(List<T0> normals) { }

	// RVA: 0xFFFFFFFF723C0E34
	public Void SetNormals(List<T0> inNormals) { }

	// RVA: 0xFFFFFFFF75C15AD0
	public Void SetNormals(List<T0> inNormals, Int32 start, Int32 length) { }

	// RVA: 0xFFFFFFFF75C15B50
	public Void SetNormals(Vector3[] inNormals) { }

	// RVA: 0xFFFFFFFF75C15BD0
	public Void SetNormals(Vector3[] inNormals, Int32 start, Int32 length) { }

	// RVA: -1
	public Void SetNormals(NativeArray<T0> inNormals) { }

	// RVA: -1
	public Void SetNormals(NativeArray<T0> inNormals, Int32 start, Int32 length) { }

	// RVA: 0xFFFFFFFF75C15C44
	public Void GetTangents(List<T0> tangents) { }

	// RVA: 0xFFFFFFFF723C0F68
	public Void SetTangents(List<T0> inTangents) { }

	// RVA: 0xFFFFFFFF75C15D3C
	public Void SetTangents(List<T0> inTangents, Int32 start, Int32 length) { }

	// RVA: 0xFFFFFFFF75C15DBC
	public Void SetTangents(Vector4[] inTangents) { }

	// RVA: 0xFFFFFFFF75C15E3C
	public Void SetTangents(Vector4[] inTangents, Int32 start, Int32 length) { }

	// RVA: -1
	public Void SetTangents(NativeArray<T0> inTangents) { }

	// RVA: -1
	public Void SetTangents(NativeArray<T0> inTangents, Int32 start, Int32 length) { }

	// RVA: 0xFFFFFFFF75C15EB0
	public Void GetColors(List<T0> colors) { }

	// RVA: 0xFFFFFFFF723C109C
	public Void SetColors(List<T0> inColors) { }

	// RVA: 0xFFFFFFFF75C15FA8
	public Void SetColors(List<T0> inColors, Int32 start, Int32 length) { }

	// RVA: 0xFFFFFFFF75C16028
	public Void SetColors(Color[] inColors) { }

	// RVA: 0xFFFFFFFF75C160A8
	public Void SetColors(Color[] inColors, Int32 start, Int32 length) { }

	// RVA: 0xFFFFFFFF75C1611C
	public Void GetColors(List<T0> colors) { }

	// RVA: 0xFFFFFFFF75C16218
	public Void SetColors(List<T0> inColors) { }

	// RVA: 0xFFFFFFFF75C162D8
	public Void SetColors(List<T0> inColors, Int32 start, Int32 length) { }

	// RVA: 0xFFFFFFFF75C16360
	public Void SetColors(Color32[] inColors) { }

	// RVA: 0xFFFFFFFF75C163E0
	public Void SetColors(Color32[] inColors, Int32 start, Int32 length) { }

	// RVA: -1
	public Void SetColors(NativeArray<T0> inColors) { }

	// RVA: -1
	public Void SetColors(NativeArray<T0> inColors, Int32 start, Int32 length) { }

	// RVA: -1
	private Void SetUvsImpl(Int32 uvIndex, Int32 dim, List<T0> uvs, Int32 start, Int32 length) { }

	// RVA: 0xFFFFFFFF75C16454
	public Void SetUVs(Int32 channel, List<T0> uvs) { }

	// RVA: 0xFFFFFFFF75C165A4
	public Void SetUVs(Int32 channel, List<T0> uvs) { }

	// RVA: 0xFFFFFFFF723C11D0
	public Void SetUVs(Int32 channel, List<T0> uvs) { }

	// RVA: 0xFFFFFFFF75C16514
	public Void SetUVs(Int32 channel, List<T0> uvs, Int32 start, Int32 length) { }

	// RVA: 0xFFFFFFFF75C1667C
	public Void SetUVs(Int32 channel, List<T0> uvs, Int32 start, Int32 length) { }

	// RVA: 0xFFFFFFFF75C1670C
	public Void SetUVs(Int32 channel, List<T0> uvs, Int32 start, Int32 length) { }

	// RVA: 0xFFFFFFFF75C1679C
	private Void SetUvsImpl(Int32 uvIndex, Int32 dim, Array uvs, Int32 arrayStart, Int32 arraySize) { }

	// RVA: 0xFFFFFFFF75C168B0
	public Void SetUVs(Int32 channel, Vector2[] uvs) { }

	// RVA: 0xFFFFFFFF75C16920
	public Void SetUVs(Int32 channel, Vector3[] uvs) { }

	// RVA: 0xFFFFFFFF75C16990
	public Void SetUVs(Int32 channel, Vector4[] uvs) { }

	// RVA: 0xFFFFFFFF75C1690C
	public Void SetUVs(Int32 channel, Vector2[] uvs, Int32 start, Int32 length) { }

	// RVA: 0xFFFFFFFF75C1697C
	public Void SetUVs(Int32 channel, Vector3[] uvs, Int32 start, Int32 length) { }

	// RVA: 0xFFFFFFFF75C169EC
	public Void SetUVs(Int32 channel, Vector4[] uvs, Int32 start, Int32 length) { }

	// RVA: -1
	public Void SetUVs(Int32 channel, NativeArray<T0> uvs) { }

	// RVA: -1
	public Void SetUVs(Int32 channel, NativeArray<T0> uvs, Int32 start, Int32 length) { }

	// RVA: -1
	private Void GetUVsImpl(Int32 uvIndex, List<T0> uvs, Int32 dim) { }

	// RVA: 0xFFFFFFFF723C1320
	public Void GetUVs(Int32 channel, List<T0> uvs) { }

	// RVA: 0xFFFFFFFF75C16A00
	public Void GetUVs(Int32 channel, List<T0> uvs) { }

	// RVA: 0xFFFFFFFF75C16A78
	public Void GetUVs(Int32 channel, List<T0> uvs) { }

	// RVA: 0xFFFFFFFF75C16AF0
	public Int32 get_vertexAttributeCount() { }

	// RVA: 0xFFFFFFFF75C16B30
	public VertexAttributeDescriptor[] GetVertexAttributes() { }

	// RVA: 0xFFFFFFFF75C16BD4
	public Int32 GetVertexAttributes(VertexAttributeDescriptor[] attributes) { }

	// RVA: 0xFFFFFFFF75C16C24
	public Int32 GetVertexAttributes(List<T0> attributes) { }

	// RVA: -1
	public Void SetVertexBufferData(NativeArray<T0> data, Int32 dataStart, Int32 meshBufferStart, Int32 count, Int32 stream, MeshUpdateFlags flags) { }

	// RVA: -1
	public Void SetVertexBufferData(T[] data, Int32 dataStart, Int32 meshBufferStart, Int32 count, Int32 stream, MeshUpdateFlags flags) { }

	// RVA: -1
	public Void SetVertexBufferData(List<T0> data, Int32 dataStart, Int32 meshBufferStart, Int32 count, Int32 stream, MeshUpdateFlags flags) { }

	// RVA: 0xFFFFFFFF75C16C74
	private Void PrintErrorCantAccessIndices() { }

	// RVA: 0xFFFFFFFF723C1330
	private Boolean CheckCanAccessSubmesh(Int32 submesh, Boolean errorAboutTriangles) { }

	// RVA: 0xFFFFFFFF75C16CF4
	private Boolean CheckCanAccessSubmeshTriangles(Int32 submesh) { }

	// RVA: 0xFFFFFFFF75C16CFC
	private Boolean CheckCanAccessSubmeshIndices(Int32 submesh) { }

	// RVA: 0xFFFFFFFF75C16D04
	public Int32[] get_triangles() { }

	// RVA: 0xFFFFFFFF723C1480
	public Void set_triangles(Int32[] value) { }

	// RVA: 0xFFFFFFFF75C16D98
	public Int32[] GetTriangles(Int32 submesh) { }

	// RVA: 0xFFFFFFFF75C16DA0
	public Int32[] GetTriangles(Int32 submesh, Boolean applyBaseVertex) { }

	// RVA: 0xFFFFFFFF75C16E20
	public Void GetTriangles(List<T0> triangles, Int32 submesh) { }

	// RVA: 0xFFFFFFFF75C16E28
	public Void GetTriangles(List<T0> triangles, Int32 submesh, Boolean applyBaseVertex) { }

	// RVA: 0xFFFFFFFF75C16FF4
	public Void GetTriangles(List<T0> triangles, Int32 submesh, Boolean applyBaseVertex) { }

	// RVA: 0xFFFFFFFF75C171C0
	public Int32[] GetIndices(Int32 submesh) { }

	// RVA: 0xFFFFFFFF75C171C8
	public Int32[] GetIndices(Int32 submesh, Boolean applyBaseVertex) { }

	// RVA: 0xFFFFFFFF75C17248
	public Void GetIndices(List<T0> indices, Int32 submesh) { }

	// RVA: 0xFFFFFFFF75C17250
	public Void GetIndices(List<T0> indices, Int32 submesh, Boolean applyBaseVertex) { }

	// RVA: 0xFFFFFFFF75C174DC
	public Void GetIndices(List<T0> indices, Int32 submesh, Boolean applyBaseVertex) { }

	// RVA: -1
	public Void SetIndexBufferData(NativeArray<T0> data, Int32 dataStart, Int32 meshBufferStart, Int32 count, MeshUpdateFlags flags) { }

	// RVA: -1
	public Void SetIndexBufferData(T[] data, Int32 dataStart, Int32 meshBufferStart, Int32 count, MeshUpdateFlags flags) { }

	// RVA: -1
	public Void SetIndexBufferData(List<T0> data, Int32 dataStart, Int32 meshBufferStart, Int32 count, MeshUpdateFlags flags) { }

	// RVA: 0xFFFFFFFF75C17688
	public UInt32 GetIndexStart(Int32 submesh) { }

	// RVA: 0xFFFFFFFF75C173FC
	public UInt32 GetIndexCount(Int32 submesh) { }

	// RVA: 0xFFFFFFFF75C17768
	public UInt32 GetBaseVertex(Int32 submesh) { }

	// RVA: 0xFFFFFFFF723C16D0
	private Void CheckIndicesArrayRange(Int32 valuesLength, Int32 start, Int32 length) { }

	// RVA: 0xFFFFFFFF723C161C
	private Void SetTrianglesImpl(Int32 submesh, IndexFormat indicesFormat, Array triangles, Int32 trianglesArrayLength, Int32 start, Int32 length, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF75C17848
	public Void SetTriangles(Int32[] triangles, Int32 submesh) { }

	// RVA: 0xFFFFFFFF75C17918
	public Void SetTriangles(Int32[] triangles, Int32 submesh, Boolean calculateBounds) { }

	// RVA: 0xFFFFFFFF75C178A8
	public Void SetTriangles(Int32[] triangles, Int32 submesh, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF75C1797C
	public Void SetTriangles(Int32[] triangles, Int32 trianglesStart, Int32 trianglesLength, Int32 submesh, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF75C17A20
	public Void SetTriangles(UInt16[] triangles, Int32 submesh, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF75C17A90
	public Void SetTriangles(UInt16[] triangles, Int32 trianglesStart, Int32 trianglesLength, Int32 submesh, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF75C17B34
	public Void SetTriangles(List<T0> triangles, Int32 submesh) { }

	// RVA: 0xFFFFFFFF723C18D4
	public Void SetTriangles(List<T0> triangles, Int32 submesh, Boolean calculateBounds) { }

	// RVA: 0xFFFFFFFF723C1818
	public Void SetTriangles(List<T0> triangles, Int32 submesh, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF723C1984
	public Void SetTriangles(List<T0> triangles, Int32 trianglesStart, Int32 trianglesLength, Int32 submesh, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF75C17B40
	public Void SetTriangles(List<T0> triangles, Int32 submesh, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF75C17BDC
	public Void SetTriangles(List<T0> triangles, Int32 trianglesStart, Int32 trianglesLength, Int32 submesh, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF723C1AD8
	public Void SetIndices(Int32[] indices, MeshTopology topology, Int32 submesh) { }

	// RVA: 0xFFFFFFFF75C17D60
	public Void SetIndices(Int32[] indices, MeshTopology topology, Int32 submesh, Boolean calculateBounds) { }

	// RVA: 0xFFFFFFFF75C17CDC
	public Void SetIndices(Int32[] indices, MeshTopology topology, Int32 submesh, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF723C1C68
	public Void SetIndices(Int32[] indices, Int32 indicesStart, Int32 indicesLength, MeshTopology topology, Int32 submesh, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF75C17DE0
	public Void SetIndices(UInt16[] indices, MeshTopology topology, Int32 submesh, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF75C17E64
	public Void SetIndices(UInt16[] indices, Int32 indicesStart, Int32 indicesLength, MeshTopology topology, Int32 submesh, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: -1
	public Void SetIndices(NativeArray<T0> indices, MeshTopology topology, Int32 submesh, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: -1
	public Void SetIndices(NativeArray<T0> indices, Int32 indicesStart, Int32 indicesLength, MeshTopology topology, Int32 submesh, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF75C17F54
	public Void SetIndices(List<T0> indices, MeshTopology topology, Int32 submesh, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF75C1801C
	public Void SetIndices(List<T0> indices, Int32 indicesStart, Int32 indicesLength, MeshTopology topology, Int32 submesh, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF75C18178
	public Void SetIndices(List<T0> indices, MeshTopology topology, Int32 submesh, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF75C18228
	public Void SetIndices(List<T0> indices, Int32 indicesStart, Int32 indicesLength, MeshTopology topology, Int32 submesh, Boolean calculateBounds, Int32 baseVertex) { }

	// RVA: 0xFFFFFFFF75C1836C
	public Void GetBindposes(List<T0> bindposes) { }

	// RVA: 0xFFFFFFFF75C184B8
	public Void GetBoneWeights(List<T0> boneWeights) { }

	// RVA: 0xFFFFFFFF75C18634
	public BoneWeight[] get_boneWeights() { }

	// RVA: 0xFFFFFFFF75C18674
	public Void set_boneWeights(BoneWeight[] value) { }

	// RVA: 0xFFFFFFFF723C1D60
	public Void Clear(Boolean keepVertexLayout) { }

	// RVA: 0xFFFFFFFF723C1DBC
	public Void Clear() { }

	// RVA: 0xFFFFFFFF723C1E14
	public Void RecalculateBounds() { }

	// RVA: 0xFFFFFFFF75C186C4
	public Void RecalculateNormals() { }

	// RVA: 0xFFFFFFFF75C187A0
	public Void RecalculateTangents() { }

	// RVA: 0xFFFFFFFF723C1EE0
	public Void MarkDynamic() { }

	// RVA: 0xFFFFFFFF75C1887C
	public Void UploadMeshData(Boolean markNoLongerReadable) { }

	// RVA: 0xFFFFFFFF75C18908
	public Void Optimize() { }

	// RVA: 0xFFFFFFFF75C189E4
	public Void OptimizeIndexBuffers() { }

	// RVA: 0xFFFFFFFF75C18AC0
	public Void OptimizeReorderVertexBuffer() { }

	// RVA: 0xFFFFFFFF75C18B9C
	public MeshTopology GetTopology(Int32 submesh) { }

	// RVA: 0xFFFFFFFF75C18CA8
	public Void CombineMeshes(CombineInstance[] combine, Boolean mergeSubMeshes, Boolean useMatrices, Boolean hasLightmapData) { }

	// RVA: 0xFFFFFFFF723C1F60
	public Void CombineMeshes(CombineInstance[] combine, Boolean mergeSubMeshes, Boolean useMatrices) { }

	// RVA: 0xFFFFFFFF75C18D18
	public Void CombineMeshes(CombineInstance[] combine, Boolean mergeSubMeshes) { }

	// RVA: 0xFFFFFFFF75C18D78
	public Void CombineMeshes(CombineInstance[] combine) { }

	// RVA: 0xFFFFFFFF75C138DC
	private Void GetVertexAttribute_Injected(Int32 index, out VertexAttributeDescriptor ret) { }

	// RVA: 0xFFFFFFFF75C14B30
	private Void SetSubMesh_Injected(Int32 index, ref SubMeshDescriptor desc, MeshUpdateFlags flags) { }

	// RVA: 0xFFFFFFFF75C14C18
	private Void GetSubMesh_Injected(Int32 index, out SubMeshDescriptor ret) { }

	// RVA: 0xFFFFFFFF75C14CE4
	private Void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0xFFFFFFFF75C14D84
	private Void set_bounds_Injected(ref Bounds value) { }

}

// Namespace: UnityEngine
internal struct StaticBatchingHelper
{
	// Methods

	// RVA: 0xFFFFFFFF75C3AA9C
	internal static Mesh InternalCombineVertices(MeshInstance[] meshes, String meshName) { }

	// RVA: 0xFFFFFFFF75C3AAEC
	internal static Void InternalCombineIndices(SubMeshInstance[] submeshes, Mesh combinedMesh) { }

}

// Namespace: UnityEngine
public struct BoneWeight
{
	// Fields
	private Single m_Weight0; // 0x10
	private Single m_Weight1; // 0x14
	private Single m_Weight2; // 0x18
	private Single m_Weight3; // 0x1C
	private Int32 m_BoneIndex0; // 0x20
	private Int32 m_BoneIndex1; // 0x24
	private Int32 m_BoneIndex2; // 0x28
	private Int32 m_BoneIndex3; // 0x2C

	// Properties
	public Single weight0 { get; }
	public Single weight1 { get; }
	public Single weight2 { get; }
	public Single weight3 { get; }
	public Int32 boneIndex0 { get; }
	public Int32 boneIndex1 { get; }
	public Int32 boneIndex2 { get; }
	public Int32 boneIndex3 { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114B07C
	public Single get_weight0() { }

	// RVA: 0xFFFFFFFF7114B084
	public Single get_weight1() { }

	// RVA: 0xFFFFFFFF7114B08C
	public Single get_weight2() { }

	// RVA: 0xFFFFFFFF7114B094
	public Single get_weight3() { }

	// RVA: 0xFFFFFFFF7114B09C
	public Int32 get_boneIndex0() { }

	// RVA: 0xFFFFFFFF7114B0A4
	public Int32 get_boneIndex1() { }

	// RVA: 0xFFFFFFFF7114B0AC
	public Int32 get_boneIndex2() { }

	// RVA: 0xFFFFFFFF7114B0B4
	public Int32 get_boneIndex3() { }

	// RVA: 0xFFFFFFFF7114B0BC
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114B0C4
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF7114B0CC
	public Boolean Equals(BoneWeight other) { }

}

// Namespace: UnityEngine
public struct BoneWeight1
{
	// Fields
	private Single m_Weight; // 0x10
	private Int32 m_BoneIndex; // 0x14

	// Properties
	public Single weight { get; }
	public Int32 boneIndex { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114B0F8
	public Single get_weight() { }

	// RVA: 0xFFFFFFFF7114B100
	public Int32 get_boneIndex() { }

	// RVA: 0xFFFFFFFF7114B108
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF7114B110
	public Boolean Equals(BoneWeight1 other) { }

	// RVA: 0xFFFFFFFF7114B118
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine
public struct CombineInstance
{
	// Fields
	private Int32 m_MeshInstanceID; // 0x10
	private Int32 m_SubMeshIndex; // 0x14
	private Matrix4x4 m_Transform; // 0x18
	private Vector4 m_LightmapScaleOffset; // 0x58
	private Vector4 m_RealtimeLightmapScaleOffset; // 0x68

	// Properties
	public Mesh mesh { set; }
	public Int32 subMeshIndex { set; }
	public Matrix4x4 transform { set; }

	// Methods

	// RVA: 0xFFFFFFFF7114B698
	public Void set_mesh(Mesh value) { }

	// RVA: 0xFFFFFFFF7114B6D8
	public Void set_subMeshIndex(Int32 value) { }

	// RVA: 0xFFFFFFFF7114B6E0
	public Void set_transform(Matrix4x4 value) { }

}

// Namespace: UnityEngine
public class Texture
{
	// Fields
	public static readonly Int32 GenerateAllMips; // 0x0

	// Properties
	public virtual GraphicsFormat graphicsFormat { get; }
	public virtual Int32 width { get; set; }
	public virtual Int32 height { get; set; }
	public virtual TextureDimension dimension { get; }
	public virtual Boolean isReadable { get; }
	public TextureWrapMode wrapMode { get; set; }
	public TextureWrapMode wrapModeU { get; set; }
	public TextureWrapMode wrapModeV { get; set; }
	public TextureWrapMode wrapModeW { get; set; }
	public FilterMode filterMode { get; set; }
	public Int32 anisoLevel { get; set; }
	public Single mipMapBias { set; }
	public Vector2 texelSize { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C3D018
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF75C3D060
	public virtual GraphicsFormat get_graphicsFormat() { }

	// RVA: 0xFFFFFFFF75C3D068
	private Int32 GetDataWidth() { }

	// RVA: 0xFFFFFFFF75C3D0A8
	private Int32 GetDataHeight() { }

	// RVA: 0xFFFFFFFF75C3D0E8
	private TextureDimension GetDimension() { }

	// RVA: 0xFFFFFFFF723CA624
	public virtual Int32 get_width() { }

	// RVA: 0xFFFFFFFF75C3D128
	public virtual Void set_width(Int32 value) { }

	// RVA: 0xFFFFFFFF723CA678
	public virtual Int32 get_height() { }

	// RVA: 0xFFFFFFFF75C3D17C
	public virtual Void set_height(Int32 value) { }

	// RVA: 0xFFFFFFFF75C3D1D0
	public virtual TextureDimension get_dimension() { }

	// RVA: 0xFFFFFFFF75C3D210
	public virtual Boolean get_isReadable() { }

	// RVA: 0xFFFFFFFF75C3D250
	public TextureWrapMode get_wrapMode() { }

	// RVA: 0xFFFFFFFF723CA6CC
	public Void set_wrapMode(TextureWrapMode value) { }

	// RVA: 0xFFFFFFFF75C3D290
	public TextureWrapMode get_wrapModeU() { }

	// RVA: 0xFFFFFFFF75C3D2D0
	public Void set_wrapModeU(TextureWrapMode value) { }

	// RVA: 0xFFFFFFFF75C3D320
	public TextureWrapMode get_wrapModeV() { }

	// RVA: 0xFFFFFFFF75C3D360
	public Void set_wrapModeV(TextureWrapMode value) { }

	// RVA: 0xFFFFFFFF75C3D3B0
	public TextureWrapMode get_wrapModeW() { }

	// RVA: 0xFFFFFFFF75C3D3F0
	public Void set_wrapModeW(TextureWrapMode value) { }

	// RVA: 0xFFFFFFFF75C3D440
	public FilterMode get_filterMode() { }

	// RVA: 0xFFFFFFFF723CA720
	public Void set_filterMode(FilterMode value) { }

	// RVA: 0xFFFFFFFF75C3D480
	public Int32 get_anisoLevel() { }

	// RVA: 0xFFFFFFFF75C3D4C0
	public Void set_anisoLevel(Int32 value) { }

	// RVA: 0xFFFFFFFF75C3D510
	public Void set_mipMapBias(Single value) { }

	// RVA: 0xFFFFFFFF75C3D560
	public Vector2 get_texelSize() { }

	// RVA: 0xFFFFFFFF75C3D608
	internal Boolean ValidateFormat(TextureFormat format) { }

	// RVA: 0xFFFFFFFF75C3D72C
	internal Boolean ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0xFFFFFFFF75C3D868
	internal UnityException CreateNonReadableException(Texture t) { }

	// RVA: 0xFFFFFFFF75C3D944
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C3D5B8
	private Void get_texelSize_Injected(out Vector2 ret) { }

}

// Namespace: UnityEngine
public sealed class Texture2D
{
	// Properties
	public TextureFormat format { get; }
	public static Texture2D whiteTexture { get; }
	public static Texture2D blackTexture { get; }
	public static Texture2D redTexture { get; }
	public static Texture2D grayTexture { get; }
	public static Texture2D linearGrayTexture { get; }
	public static Texture2D normalTexture { get; }
	public override Boolean isReadable { get; }
	internal Boolean isPreProcessed { get; }
	public Boolean streamingMipmaps { get; }
	public Int32 streamingMipmapsPriority { get; }
	public Int32 requestedMipmapLevel { get; set; }
	public Int32 minimumMipmapLevel { get; set; }
	internal Boolean loadAllMips { get; set; }
	public Int32 calculatedMipmapLevel { get; }
	public Int32 desiredMipmapLevel { get; }
	public Int32 loadingMipmapLevel { get; }
	public Int32 loadedMipmapLevel { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C3D95C
	public TextureFormat get_format() { }

	// RVA: 0xFFFFFFFF75C3D99C
	public static Texture2D get_whiteTexture() { }

	// RVA: 0xFFFFFFFF75C3D9D0
	public static Texture2D get_blackTexture() { }

	// RVA: 0xFFFFFFFF75C3DA04
	public static Texture2D get_redTexture() { }

	// RVA: 0xFFFFFFFF75C3DA38
	public static Texture2D get_grayTexture() { }

	// RVA: 0xFFFFFFFF75C3DA6C
	public static Texture2D get_linearGrayTexture() { }

	// RVA: 0xFFFFFFFF75C3DAA0
	public static Texture2D get_normalTexture() { }

	// RVA: 0xFFFFFFFF75C3DAD4
	public Void Compress(Boolean highQuality) { }

	// RVA: 0xFFFFFFFF75C3DB24
	private static Boolean Internal_CreateImpl(Texture2D mono, Int32 w, Int32 h, Int32 mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0xFFFFFFFF75C3DBAC
	private static Void Internal_Create(Texture2D mono, Int32 w, Int32 h, Int32 mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0xFFFFFFFF75C3DC68
	public override Boolean get_isReadable() { }

	// RVA: 0xFFFFFFFF75C3DCAC
	private Void ApplyImpl(Boolean updateMipmaps, Boolean makeNoLongerReadable) { }

	// RVA: 0xFFFFFFFF75C3DD04
	private Boolean ResizeImpl(Int32 width, Int32 height) { }

	// RVA: 0xFFFFFFFF75C3DD5C
	private Void SetPixelImpl(Int32 image, Int32 x, Int32 y, Color color) { }

	// RVA: 0xFFFFFFFF75C3DE4C
	private Color GetPixelImpl(Int32 image, Int32 x, Int32 y) { }

	// RVA: 0xFFFFFFFF75C3DF40
	private Color GetPixelBilinearImpl(Int32 image, Single u, Single v) { }

	// RVA: 0xFFFFFFFF75C3E034
	private Boolean ResizeWithFormatImpl(Int32 width, Int32 height, TextureFormat format, Boolean hasMipMap) { }

	// RVA: 0xFFFFFFFF75C3E0A4
	private Void ReadPixelsImpl(Rect source, Int32 destX, Int32 destY, Boolean recalculateMipMaps) { }

	// RVA: 0xFFFFFFFF75C3E194
	private Void SetPixelsImpl(Int32 x, Int32 y, Int32 w, Int32 h, Color[] pixel, Int32 miplevel, Int32 frame) { }

	// RVA: 0xFFFFFFFF75C3E22C
	private Boolean LoadRawTextureDataImpl(IntPtr data, Int32 size) { }

	// RVA: 0xFFFFFFFF75C3E284
	private Boolean LoadRawTextureDataImplArray(Byte[] data) { }

	// RVA: 0xFFFFFFFF75C3E2D4
	private Boolean SetPixelDataImplArray(Array data, Int32 mipLevel, Int32 elementSize, Int32 dataArraySize, Int32 sourceDataStartIndex) { }

	// RVA: 0xFFFFFFFF75C3E354
	private Boolean SetPixelDataImpl(IntPtr data, Int32 mipLevel, Int32 elementSize, Int32 dataArraySize, Int32 sourceDataStartIndex) { }

	// RVA: 0xFFFFFFFF75C3E3D4
	private IntPtr GetWritableImageData(Int32 frame) { }

	// RVA: 0xFFFFFFFF75C3E424
	private Int64 GetRawImageDataSize() { }

	// RVA: 0xFFFFFFFF75C3E464
	private static Void GenerateAtlasImpl(Vector2[] sizes, Int32 padding, Int32 atlasSize, [Out] Rect[] rect) { }

	// RVA: 0xFFFFFFFF75C3E4CC
	internal Boolean get_isPreProcessed() { }

	// RVA: 0xFFFFFFFF75C3E50C
	public Boolean get_streamingMipmaps() { }

	// RVA: 0xFFFFFFFF75C3E54C
	public Int32 get_streamingMipmapsPriority() { }

	// RVA: 0xFFFFFFFF75C3E58C
	public Int32 get_requestedMipmapLevel() { }

	// RVA: 0xFFFFFFFF75C3E5CC
	public Void set_requestedMipmapLevel(Int32 value) { }

	// RVA: 0xFFFFFFFF75C3E61C
	public Int32 get_minimumMipmapLevel() { }

	// RVA: 0xFFFFFFFF75C3E65C
	public Void set_minimumMipmapLevel(Int32 value) { }

	// RVA: 0xFFFFFFFF75C3E6AC
	internal Boolean get_loadAllMips() { }

	// RVA: 0xFFFFFFFF75C3E6EC
	internal Void set_loadAllMips(Boolean value) { }

	// RVA: 0xFFFFFFFF75C3E73C
	public Int32 get_calculatedMipmapLevel() { }

	// RVA: 0xFFFFFFFF75C3E77C
	public Int32 get_desiredMipmapLevel() { }

	// RVA: 0xFFFFFFFF75C3E7BC
	public Int32 get_loadingMipmapLevel() { }

	// RVA: 0xFFFFFFFF75C3E7FC
	public Int32 get_loadedMipmapLevel() { }

	// RVA: 0xFFFFFFFF75C3E83C
	public Void ClearRequestedMipmapLevel() { }

	// RVA: 0xFFFFFFFF75C3E87C
	public Boolean IsRequestedMipmapLevelLoaded() { }

	// RVA: 0xFFFFFFFF75C3E8BC
	public Void ClearMinimumMipmapLevel() { }

	// RVA: 0xFFFFFFFF75C3E8FC
	public Void UpdateExternalTexture(IntPtr nativeTex) { }

	// RVA: 0xFFFFFFFF75C3E94C
	private Void SetAllPixels32(Color32[] colors, Int32 miplevel) { }

	// RVA: 0xFFFFFFFF75C3E9A4
	private Void SetBlockOfPixels32(Int32 x, Int32 y, Int32 blockWidth, Int32 blockHeight, Color32[] colors, Int32 miplevel) { }

	// RVA: 0xFFFFFFFF75C3EA2C
	public Byte[] GetRawTextureData() { }

	// RVA: 0xFFFFFFFF75C3EA6C
	public Color[] GetPixels(Int32 x, Int32 y, Int32 blockWidth, Int32 blockHeight, Int32 miplevel) { }

	// RVA: 0xFFFFFFFF75C3EAEC
	public Color[] GetPixels(Int32 x, Int32 y, Int32 blockWidth, Int32 blockHeight) { }

	// RVA: 0xFFFFFFFF75C3EB60
	public Color32[] GetPixels32(Int32 miplevel) { }

	// RVA: 0xFFFFFFFF75C3EBB0
	public Color32[] GetPixels32() { }

	// RVA: 0xFFFFFFFF75C3EBF4
	public Rect[] PackTextures(Texture2D[] textures, Int32 padding, Int32 maximumAtlasSize, Boolean makeNoLongerReadable) { }

	// RVA: 0xFFFFFFFF75C3EC64
	public Rect[] PackTextures(Texture2D[] textures, Int32 padding, Int32 maximumAtlasSize) { }

	// RVA: 0xFFFFFFFF75C3ECD0
	public Rect[] PackTextures(Texture2D[] textures, Int32 padding) { }

	// RVA: 0xFFFFFFFF75C3ED30
	internal Void .ctor(Int32 width, Int32 height, GraphicsFormat format, TextureCreationFlags flags, Int32 mipCount, IntPtr nativeTex) { }

	// RVA: 0xFFFFFFFF75C3EDE8
	public Void .ctor(Int32 width, Int32 height, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0xFFFFFFFF75C3EE60
	public Void .ctor(Int32 width, Int32 height, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0xFFFFFFFF75C3EEDC
	public Void .ctor(Int32 width, Int32 height, GraphicsFormat format, Int32 mipCount, TextureCreationFlags flags) { }

	// RVA: 0xFFFFFFFF75C3EEF0
	internal Void .ctor(Int32 width, Int32 height, TextureFormat textureFormat, Int32 mipCount, Boolean linear, IntPtr nativeTex) { }

	// RVA: 0xFFFFFFFF75C3EFD8
	public Void .ctor(Int32 width, Int32 height, TextureFormat textureFormat, Int32 mipCount, Boolean linear) { }

	// RVA: 0xFFFFFFFF75C3EFE0
	public Void .ctor(Int32 width, Int32 height, TextureFormat textureFormat, Boolean mipChain, Boolean linear) { }

	// RVA: 0xFFFFFFFF75C3F004
	public Void .ctor(Int32 width, Int32 height, TextureFormat textureFormat, Boolean mipChain) { }

	// RVA: 0xFFFFFFFF75C3F02C
	public Void .ctor(Int32 width, Int32 height) { }

	// RVA: 0xFFFFFFFF75C3F098
	public static Texture2D CreateExternalTexture(Int32 width, Int32 height, TextureFormat format, Boolean mipChain, Boolean linear, IntPtr nativeTex) { }

	// RVA: 0xFFFFFFFF75C3F17C
	public Void SetPixel(Int32 x, Int32 y, Color color) { }

	// RVA: 0xFFFFFFFF75C3F264
	public Void SetPixel(Int32 x, Int32 y, Color color, Int32 mipLevel) { }

	// RVA: 0xFFFFFFFF75C3F350
	public Void SetPixels(Int32 x, Int32 y, Int32 blockWidth, Int32 blockHeight, Color[] colors, Int32 miplevel) { }

	// RVA: 0xFFFFFFFF75C3F428
	public Void SetPixels(Int32 x, Int32 y, Int32 blockWidth, Int32 blockHeight, Color[] colors) { }

	// RVA: 0xFFFFFFFF75C3F430
	public Void SetPixels(Color[] colors, Int32 miplevel) { }

	// RVA: 0xFFFFFFFF75C3F4B0
	public Void SetPixels(Color[] colors) { }

	// RVA: 0xFFFFFFFF75C3F51C
	public Color GetPixel(Int32 x, Int32 y) { }

	// RVA: 0xFFFFFFFF75C3F580
	public Color GetPixel(Int32 x, Int32 y, Int32 mipLevel) { }

	// RVA: 0xFFFFFFFF75C3F614
	public Color GetPixelBilinear(Single u, Single v) { }

	// RVA: 0xFFFFFFFF75C3F69C
	public Color GetPixelBilinear(Single u, Single v, Int32 mipLevel) { }

	// RVA: 0xFFFFFFFF75C3F730
	public Void LoadRawTextureData(IntPtr data, Int32 size) { }

	// RVA: 0xFFFFFFFF75C3F864
	public Void LoadRawTextureData(Byte[] data) { }

	// RVA: -1
	public Void LoadRawTextureData(NativeArray<T0> data) { }

	// RVA: -1
	public Void SetPixelData(T[] data, Int32 mipLevel, Int32 sourceDataStartIndex) { }

	// RVA: -1
	public Void SetPixelData(NativeArray<T0> data, Int32 mipLevel, Int32 sourceDataStartIndex) { }

	// RVA: -1
	public NativeArray<T0> GetRawTextureData() { }

	// RVA: 0xFFFFFFFF75C3F994
	public Void Apply(Boolean updateMipmaps, Boolean makeNoLongerReadable) { }

	// RVA: 0xFFFFFFFF75C3FA14
	public Void Apply(Boolean updateMipmaps) { }

	// RVA: 0xFFFFFFFF75C3FA1C
	public Void Apply() { }

	// RVA: 0xFFFFFFFF75C3FA28
	public Boolean Resize(Int32 width, Int32 height) { }

	// RVA: 0xFFFFFFFF75C3FACC
	public Boolean Resize(Int32 width, Int32 height, TextureFormat format, Boolean hasMipMap) { }

	// RVA: 0xFFFFFFFF75C3FB88
	public Void ReadPixels(Rect source, Int32 destX, Int32 destY, Boolean recalculateMipMaps) { }

	// RVA: 0xFFFFFFFF75C3FC50
	public Void ReadPixels(Rect source, Int32 destX, Int32 destY) { }

	// RVA: 0xFFFFFFFF75C3FC58
	public static Boolean GenerateAtlas(Vector2[] sizes, Int32 padding, Int32 atlasSize, List<T0> results) { }

	// RVA: 0xFFFFFFFF75C3FE2C
	public Void SetPixels32(Color32[] colors, Int32 miplevel) { }

	// RVA: 0xFFFFFFFF75C3FE84
	public Void SetPixels32(Color32[] colors) { }

	// RVA: 0xFFFFFFFF75C3FED8
	public Void SetPixels32(Int32 x, Int32 y, Int32 blockWidth, Int32 blockHeight, Color32[] colors, Int32 miplevel) { }

	// RVA: 0xFFFFFFFF75C3FF60
	public Void SetPixels32(Int32 x, Int32 y, Int32 blockWidth, Int32 blockHeight, Color32[] colors) { }

	// RVA: 0xFFFFFFFF75C3FFE4
	public Color[] GetPixels(Int32 miplevel) { }

	// RVA: 0xFFFFFFFF75C40088
	public Color[] GetPixels() { }

	// RVA: 0xFFFFFFFF75C3DDDC
	private Void SetPixelImpl_Injected(Int32 image, Int32 x, Int32 y, ref Color color) { }

	// RVA: 0xFFFFFFFF75C3DED0
	private Void GetPixelImpl_Injected(Int32 image, Int32 x, Int32 y, out Color ret) { }

	// RVA: 0xFFFFFFFF75C3DFC4
	private Void GetPixelBilinearImpl_Injected(Int32 image, Single u, Single v, out Color ret) { }

	// RVA: 0xFFFFFFFF75C3E124
	private Void ReadPixelsImpl_Injected(ref Rect source, Int32 destX, Int32 destY, Boolean recalculateMipMaps) { }

}

// Namespace: UnityEngine
public sealed class Cubemap
{
	// Properties
	public override Boolean isReadable { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BFBD28
	private static Boolean Internal_CreateImpl(Cubemap mono, Int32 ext, Int32 mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0xFFFFFFFF75BFBDA8
	private static Void Internal_Create(Cubemap mono, Int32 ext, Int32 mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0xFFFFFFFF75BFBE80
	private Void ApplyImpl(Boolean updateMipmaps, Boolean makeNoLongerReadable) { }

	// RVA: 0xFFFFFFFF75BFBED8
	public override Boolean get_isReadable() { }

	// RVA: 0xFFFFFFFF75BFBF18
	public Color[] GetPixels(CubemapFace face, Int32 miplevel) { }

	// RVA: 0xFFFFFFFF75BFBF70
	public Void SetPixels(Color[] colors, CubemapFace face, Int32 miplevel) { }

	// RVA: 0xFFFFFFFF75BFBFD8
	public Void .ctor(Int32 width, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0xFFFFFFFF75BFC020
	public Void .ctor(Int32 width, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0xFFFFFFFF75BFC0CC
	public Void .ctor(Int32 width, TextureFormat format, Int32 mipCount) { }

	// RVA: 0xFFFFFFFF75BFC1A8
	public Void .ctor(Int32 width, GraphicsFormat format, TextureCreationFlags flags, Int32 mipCount) { }

	// RVA: 0xFFFFFFFF75BFC0D4
	internal Void .ctor(Int32 width, TextureFormat textureFormat, Int32 mipCount, IntPtr nativeTex) { }

	// RVA: 0xFFFFFFFF75BFC2A8
	internal Void .ctor(Int32 width, TextureFormat textureFormat, Boolean mipChain, IntPtr nativeTex) { }

	// RVA: 0xFFFFFFFF75BFC2C8
	public Void .ctor(Int32 width, TextureFormat textureFormat, Boolean mipChain) { }

	// RVA: 0xFFFFFFFF75BFC2EC
	public Void Apply(Boolean updateMipmaps, Boolean makeNoLongerReadable) { }

	// RVA: 0xFFFFFFFF75BFC398
	public Void Apply(Boolean updateMipmaps) { }

}

// Namespace: UnityEngine
public sealed class Texture3D
{
	// Properties
	public override Boolean isReadable { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C4062C
	public override Boolean get_isReadable() { }

	// RVA: 0xFFFFFFFF75C4066C
	private static Boolean Internal_CreateImpl(Texture3D mono, Int32 w, Int32 h, Int32 d, Int32 mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0xFFFFFFFF75C406F4
	private static Void Internal_Create(Texture3D mono, Int32 w, Int32 h, Int32 d, Int32 mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0xFFFFFFFF75C407D0
	public Void .ctor(Int32 width, Int32 height, Int32 depth, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0xFFFFFFFF75C40858
	public Void .ctor(Int32 width, Int32 height, Int32 depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0xFFFFFFFF75C408E0
	public Void .ctor(Int32 width, Int32 height, Int32 depth, GraphicsFormat format, TextureCreationFlags flags, Int32 mipCount) { }

	// RVA: 0xFFFFFFFF75C40998
	public Void .ctor(Int32 width, Int32 height, Int32 depth, TextureFormat textureFormat, Int32 mipCount) { }

	// RVA: 0xFFFFFFFF75C40A78
	public Void .ctor(Int32 width, Int32 height, Int32 depth, TextureFormat textureFormat, Boolean mipChain) { }

}

// Namespace: UnityEngine
public sealed class Texture2DArray
{
	// Properties
	public static Int32 allSlices { get; }
	public override Boolean isReadable { get; }

	// Methods

	// RVA: 0xFFFFFFFF723CA774
	public static Int32 get_allSlices() { }

	// RVA: 0xFFFFFFFF75C40090
	public override Boolean get_isReadable() { }

	// RVA: 0xFFFFFFFF75C400D0
	private static Boolean Internal_CreateImpl(Texture2DArray mono, Int32 w, Int32 h, Int32 d, Int32 mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0xFFFFFFFF75C40158
	private static Void Internal_Create(Texture2DArray mono, Int32 w, Int32 h, Int32 d, Int32 mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0xFFFFFFFF75C40240
	private Void ApplyImpl(Boolean updateMipmaps, Boolean makeNoLongerReadable) { }

	// RVA: 0xFFFFFFFF75C40298
	public Void .ctor(Int32 width, Int32 height, Int32 depth, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0xFFFFFFFF75C40320
	public Void .ctor(Int32 width, Int32 height, Int32 depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0xFFFFFFFF75C403A8
	public Void .ctor(Int32 width, Int32 height, Int32 depth, GraphicsFormat format, TextureCreationFlags flags, Int32 mipCount) { }

	// RVA: 0xFFFFFFFF75C40460
	public Void .ctor(Int32 width, Int32 height, Int32 depth, TextureFormat textureFormat, Int32 mipCount, Boolean linear) { }

	// RVA: 0xFFFFFFFF75C40544
	public Void .ctor(Int32 width, Int32 height, Int32 depth, TextureFormat textureFormat, Boolean mipChain, Boolean linear) { }

	// RVA: 0xFFFFFFFF75C40564
	public Void .ctor(Int32 width, Int32 height, Int32 depth, TextureFormat textureFormat, Boolean mipChain) { }

	// RVA: 0xFFFFFFFF75C40588
	public Void Apply(Boolean updateMipmaps, Boolean makeNoLongerReadable) { }

}

// Namespace: UnityEngine
public sealed class CubemapArray
{
	// Properties
	public override Boolean isReadable { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BFC3A0
	public override Boolean get_isReadable() { }

	// RVA: 0xFFFFFFFF75BFC3E0
	private static Boolean Internal_CreateImpl(CubemapArray mono, Int32 ext, Int32 count, Int32 mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0xFFFFFFFF75BFC460
	private static Void Internal_Create(CubemapArray mono, Int32 ext, Int32 count, Int32 mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0xFFFFFFFF75BFC544
	public Void .ctor(Int32 width, Int32 cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0xFFFFFFFF75BFC594
	public Void .ctor(Int32 width, Int32 cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0xFFFFFFFF75BFC60C
	public Void .ctor(Int32 width, Int32 cubemapCount, GraphicsFormat format, TextureCreationFlags flags, Int32 mipCount) { }

	// RVA: 0xFFFFFFFF75BFC6B8
	public Void .ctor(Int32 width, Int32 cubemapCount, TextureFormat textureFormat, Int32 mipCount, Boolean linear) { }

	// RVA: 0xFFFFFFFF75BFC7A0
	public Void .ctor(Int32 width, Int32 cubemapCount, TextureFormat textureFormat, Boolean mipChain, Boolean linear) { }

	// RVA: 0xFFFFFFFF75BFC7C0
	public Void .ctor(Int32 width, Int32 cubemapCount, TextureFormat textureFormat, Boolean mipChain) { }

}

// Namespace: UnityEngine
public class RenderTexture
{
	// Properties
	public override Int32 width { get; set; }
	public override Int32 height { get; set; }
	public override TextureDimension dimension { get; }
	public GraphicsFormat graphicsFormat { get; set; }
	public Boolean useMipMap { get; set; }
	public RenderTextureFormat format { get; }
	public Boolean autoGenerateMips { set; }
	public Int32 antiAliasing { get; set; }
	public Boolean isPowerOfTwo { set; }
	public static RenderTexture active { get; set; }
	public RenderBuffer colorBuffer { get; }
	public RenderBuffer depthBuffer { get; }
	public Int32 depth { get; set; }
	public RenderTextureDescriptor descriptor { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C25D48
	public override Int32 get_width() { }

	// RVA: 0xFFFFFFFF75C25D8C
	public override Void set_width(Int32 value) { }

	// RVA: 0xFFFFFFFF75C25DE0
	public override Int32 get_height() { }

	// RVA: 0xFFFFFFFF75C25E24
	public override Void set_height(Int32 value) { }

	// RVA: 0xFFFFFFFF75C25E78
	public override TextureDimension get_dimension() { }

	// RVA: 0xFFFFFFFF75C25EB8
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0xFFFFFFFF75C25EF8
	public Void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0xFFFFFFFF75C25F48
	public Boolean get_useMipMap() { }

	// RVA: 0xFFFFFFFF75C25F88
	public Void set_useMipMap(Boolean value) { }

	// RVA: 0xFFFFFFFF75C25FD8
	public RenderTextureFormat get_format() { }

	// RVA: 0xFFFFFFFF75C2604C
	public Void set_autoGenerateMips(Boolean value) { }

	// RVA: 0xFFFFFFFF75C2609C
	public Int32 get_antiAliasing() { }

	// RVA: 0xFFFFFFFF75C260DC
	public Void set_antiAliasing(Int32 value) { }

	// RVA: 0xFFFFFFFF75C2612C
	public Void set_isPowerOfTwo(Boolean value) { }

	// RVA: 0xFFFFFFFF75C26130
	private static RenderTexture GetActive() { }

	// RVA: 0xFFFFFFFF75C26164
	private static Void SetActive(RenderTexture rt) { }

	// RVA: 0xFFFFFFFF75C261A4
	public static RenderTexture get_active() { }

	// RVA: 0xFFFFFFFF75C261D8
	public static Void set_active(RenderTexture value) { }

	// RVA: 0xFFFFFFFF75C26218
	private RenderBuffer GetColorBuffer() { }

	// RVA: 0xFFFFFFFF75C262C0
	private RenderBuffer GetDepthBuffer() { }

	// RVA: 0xFFFFFFFF75C26368
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0xFFFFFFFF75C263C0
	public RenderBuffer get_depthBuffer() { }

	// RVA: 0xFFFFFFFF75C26418
	public Void DiscardContents(Boolean discardColor, Boolean discardDepth) { }

	// RVA: 0xFFFFFFFF75C26470
	public Void DiscardContents() { }

	// RVA: 0xFFFFFFFF75C264B8
	public Boolean Create() { }

	// RVA: 0xFFFFFFFF75C264F8
	public Void Release() { }

	// RVA: 0xFFFFFFFF75C26538
	public Boolean IsCreated() { }

	// RVA: 0xFFFFFFFF75C26578
	internal Void SetSRGBReadWrite(Boolean srgb) { }

	// RVA: 0xFFFFFFFF75C265C8
	private static Void Internal_Create(RenderTexture rt) { }

	// RVA: 0xFFFFFFFF75C26608
	private Void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	// RVA: 0xFFFFFFFF75C266A8
	private RenderTextureDescriptor GetDescriptor() { }

	// RVA: 0xFFFFFFFF75C2677C
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	// RVA: 0xFFFFFFFF75C267FC
	public static Void ReleaseTemporary(RenderTexture temp) { }

	// RVA: 0xFFFFFFFF75C26840
	public Int32 get_depth() { }

	// RVA: 0xFFFFFFFF75C26880
	public Void set_depth(Int32 value) { }

	// RVA: 0xFFFFFFFF75C268D0
	protected internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75C26910
	public Void .ctor(RenderTextureDescriptor desc) { }

	// RVA: 0xFFFFFFFF75C26C90
	public Void .ctor(RenderTexture textureToCopy) { }

	// RVA: 0xFFFFFFFF75C26EDC
	public Void .ctor(Int32 width, Int32 height, Int32 depth, DefaultFormat format) { }

	// RVA: 0xFFFFFFFF75C26F58
	public Void .ctor(Int32 width, Int32 height, Int32 depth, GraphicsFormat format) { }

	// RVA: 0xFFFFFFFF75C27104
	public Void .ctor(Int32 width, Int32 height, Int32 depth, GraphicsFormat format, Int32 mipCount) { }

	// RVA: 0xFFFFFFFF75C273D0
	public Void .ctor(Int32 width, Int32 height, Int32 depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0xFFFFFFFF75C27420
	public Void .ctor(Int32 width, Int32 height, Int32 depth, RenderTextureFormat format) { }

	// RVA: 0xFFFFFFFF75C27470
	public Void .ctor(Int32 width, Int32 height, Int32 depth) { }

	// RVA: 0xFFFFFFFF75C274C0
	public Void .ctor(Int32 width, Int32 height, Int32 depth, RenderTextureFormat format, Int32 mipCount) { }

	// RVA: 0xFFFFFFFF75C26E58
	public RenderTextureDescriptor get_descriptor() { }

	// RVA: 0xFFFFFFFF75C27344
	public Void set_descriptor(RenderTextureDescriptor value) { }

	// RVA: 0xFFFFFFFF75C269F4
	private static Void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

	// RVA: 0xFFFFFFFF723C66F8
	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	// RVA: 0xFFFFFFFF75C27528
	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	// RVA: 0xFFFFFFFF75C275DC
	private static RenderTexture GetTemporaryImpl(Int32 width, Int32 height, Int32 depthBuffer, GraphicsFormat format, Int32 antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, Boolean useDynamicScale) { }

	// RVA: 0xFFFFFFFF75C2769C
	public static RenderTexture GetTemporary(Int32 width, Int32 height, Int32 depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, Int32 antiAliasing) { }

	// RVA: 0xFFFFFFFF75C2773C
	public static RenderTexture GetTemporary(Int32 width, Int32 height, Int32 depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0xFFFFFFFF75C277DC
	public static RenderTexture GetTemporary(Int32 width, Int32 height, Int32 depthBuffer, RenderTextureFormat format) { }

	// RVA: 0xFFFFFFFF75C2787C
	public static RenderTexture GetTemporary(Int32 width, Int32 height, Int32 depthBuffer) { }

	// RVA: 0xFFFFFFFF75C2791C
	public static RenderTexture GetTemporary(Int32 width, Int32 height) { }

	// RVA: 0xFFFFFFFF75C26270
	private Void GetColorBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0xFFFFFFFF75C26318
	private Void GetDepthBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0xFFFFFFFF75C26658
	private Void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	// RVA: 0xFFFFFFFF75C2672C
	private Void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	// RVA: 0xFFFFFFFF75C267BC
	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }

}

// Namespace: UnityEngine
public struct VrrData
{
	// Fields
	public Int32 enable; // 0x10
	public IntPtr qualityW; // 0x18
	public IntPtr qualityH; // 0x20
}

// Namespace: UnityEngine
public struct RenderTextureDescriptor
{
	// Fields
	private Int32 <width>k__BackingField; // 0x10
	private Int32 <height>k__BackingField; // 0x14
	private Int32 <msaaSamples>k__BackingField; // 0x18
	private Int32 <volumeDepth>k__BackingField; // 0x1C
	private Int32 <mipCount>k__BackingField; // 0x20
	private GraphicsFormat _graphicsFormat; // 0x24
	private GraphicsFormat <stencilFormat>k__BackingField; // 0x28
	private Int32 _depthBufferBits; // 0x2C
	private static Int32[] depthFormatBits; // 0x0
	private TextureDimension <dimension>k__BackingField; // 0x30
	private ShadowSamplingMode <shadowSamplingMode>k__BackingField; // 0x34
	private VRTextureUsage <vrUsage>k__BackingField; // 0x38
	private RenderTextureCreationFlags _flags; // 0x3C
	private RenderTextureMemoryless <memoryless>k__BackingField; // 0x40
	private readonly VrrData <vrr>k__BackingField; // 0x48

	// Properties
	public Int32 width { get; set; }
	public Int32 height { get; set; }
	public Int32 msaaSamples { get; set; }
	public Int32 volumeDepth { get; set; }
	public Int32 mipCount { set; }
	public GraphicsFormat graphicsFormat { get; set; }
	public RenderTextureFormat colorFormat { get; set; }
	public Boolean sRGB { get; set; }
	public Int32 depthBufferBits { get; set; }
	public TextureDimension dimension { set; }
	public ShadowSamplingMode shadowSamplingMode { set; }
	public VRTextureUsage vrUsage { set; }
	public RenderTextureMemoryless memoryless { set; }
	public Boolean useMipMap { set; }
	public Boolean autoGenerateMips { set; }
	public Boolean enableRandomWrite { set; }
	public Boolean bindMS { set; }
	internal Boolean createdFromScript { set; }
	public Boolean useDynamicScale { set; }

	// Methods

	// RVA: 0xFFFFFFFF7114D554
	public Int32 get_width() { }

	// RVA: 0xFFFFFFFF7114D55C
	public Void set_width(Int32 value) { }

	// RVA: 0xFFFFFFFF7114D564
	public Int32 get_height() { }

	// RVA: 0xFFFFFFFF7114D56C
	public Void set_height(Int32 value) { }

	// RVA: 0xFFFFFFFF7114D574
	public Int32 get_msaaSamples() { }

	// RVA: 0xFFFFFFFF7114D57C
	public Void set_msaaSamples(Int32 value) { }

	// RVA: 0xFFFFFFFF7114D584
	public Int32 get_volumeDepth() { }

	// RVA: 0xFFFFFFFF7114D58C
	public Void set_volumeDepth(Int32 value) { }

	// RVA: 0xFFFFFFFF7114D594
	public Void set_mipCount(Int32 value) { }

	// RVA: 0xFFFFFFFF7114D59C
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0xFFFFFFFF7114D5A4
	public Void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0xFFFFFFFF7114D620
	public RenderTextureFormat get_colorFormat() { }

	// RVA: 0xFFFFFFFF7114D664
	public Void set_colorFormat(RenderTextureFormat value) { }

	// RVA: 0xFFFFFFFF7114D66C
	public Boolean get_sRGB() { }

	// RVA: 0xFFFFFFFF7114D6C4
	public Void set_sRGB(Boolean value) { }

	// RVA: 0xFFFFFFFF7114D6CC
	public Int32 get_depthBufferBits() { }

	// RVA: 0xFFFFFFFF7114D6D4
	public Void set_depthBufferBits(Int32 value) { }

	// RVA: 0xFFFFFFFF7114D700
	public Void set_dimension(TextureDimension value) { }

	// RVA: 0xFFFFFFFF7114D708
	public Void set_shadowSamplingMode(ShadowSamplingMode value) { }

	// RVA: 0xFFFFFFFF7114D710
	public Void set_vrUsage(VRTextureUsage value) { }

	// RVA: 0xFFFFFFFF7114D718
	public Void set_memoryless(RenderTextureMemoryless value) { }

	// RVA: 0xFFFFFFFF7114D720
	public Void .ctor(Int32 width, Int32 height, RenderTextureFormat colorFormat) { }

	// RVA: 0xFFFFFFFF7114D7D8
	public Void .ctor(Int32 width, Int32 height, RenderTextureFormat colorFormat, Int32 depthBufferBits) { }

	// RVA: 0xFFFFFFFF7114D894
	public Void .ctor(Int32 width, Int32 height, GraphicsFormat colorFormat, Int32 depthBufferBits) { }

	// RVA: 0xFFFFFFFF7114D89C
	public Void .ctor(Int32 width, Int32 height, GraphicsFormat colorFormat, Int32 depthBufferBits, Int32 mipCount) { }

	// RVA: 0xFFFFFFFF7114D8A4
	private Void SetOrClearRenderTextureCreationFlag(Boolean value, RenderTextureCreationFlags flag) { }

	// RVA: 0xFFFFFFFF7114D8C0
	public Void set_useMipMap(Boolean value) { }

	// RVA: 0xFFFFFFFF7114D8D4
	public Void set_autoGenerateMips(Boolean value) { }

	// RVA: 0xFFFFFFFF7114D8F4
	public Void set_enableRandomWrite(Boolean value) { }

	// RVA: 0xFFFFFFFF7114D914
	public Void set_bindMS(Boolean value) { }

	// RVA: 0xFFFFFFFF7114D934
	internal Void set_createdFromScript(Boolean value) { }

	// RVA: 0xFFFFFFFF7114D954
	public Void set_useDynamicScale(Boolean value) { }

	// RVA: 0xFFFFFFFF75C27CAC
	private static Void .cctor() { }

}

// Namespace: UnityEngine
public class Handheld
{
	// Methods

	// RVA: 0xFFFFFFFF75C05A28
	public static Void Vibrate() { }

}

// Namespace: UnityEngine
public struct Hash128
{
	// Fields
	private UInt32 m_u32_0; // 0x10
	private UInt32 m_u32_1; // 0x14
	private UInt32 m_u32_2; // 0x18
	private UInt32 m_u32_3; // 0x1C

	// Methods

	// RVA: 0xFFFFFFFF7114BC1C
	public Void .ctor(UInt32 u32_0, UInt32 u32_1, UInt32 u32_2, UInt32 u32_3) { }

	// RVA: 0xFFFFFFFF7114BC28
	public Void .ctor(UInt64 u64_0, UInt64 u64_1) { }

	// RVA: 0xFFFFFFFF7114BC48
	public Int32 CompareTo(Hash128 rhs) { }

	// RVA: 0xFFFFFFFF7114BC50
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75C05BDC
	internal static String Internal_Hash128ToString(Hash128 hash128) { }

	// RVA: 0xFFFFFFFF7114BCA0
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7114BCA8
	public Boolean Equals(Hash128 obj) { }

	// RVA: 0xFFFFFFFF7114BCD8
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114BCE0
	public Int32 CompareTo(Object obj) { }

	// RVA: 0xFFFFFFFF75C05D00
	public static Boolean op_Equality(Hash128 hash1, Hash128 hash2) { }

	// RVA: 0xFFFFFFFF75C05B00
	public static Boolean op_LessThan(Hash128 x, Hash128 y) { }

	// RVA: 0xFFFFFFFF75C05B40
	public static Boolean op_GreaterThan(Hash128 x, Hash128 y) { }

	// RVA: 0xFFFFFFFF75C05C28
	private static String Internal_Hash128ToString_Injected(ref Hash128 hash128) { }

}

// Namespace: UnityEngine
public enum CursorLockMode
{
	// Fields
	public Int32 value__; // 0x10
	public const CursorLockMode None = 0;
	public const CursorLockMode Locked = 1;
	public const CursorLockMode Confined = 2;
}

// Namespace: UnityEngine
public class Cursor
{
	// Properties
	public static CursorLockMode lockState { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BFCB98
	public static CursorLockMode get_lockState() { }

}

// Namespace: UnityEngine
public enum KeyCode
{
	// Fields
	public Int32 value__; // 0x10
	public const KeyCode None = 0;
	public const KeyCode Backspace = 8;
	public const KeyCode Delete = 127;
	public const KeyCode Tab = 9;
	public const KeyCode Clear = 12;
	public const KeyCode Return = 13;
	public const KeyCode Pause = 19;
	public const KeyCode Escape = 27;
	public const KeyCode Space = 32;
	public const KeyCode Keypad0 = 256;
	public const KeyCode Keypad1 = 257;
	public const KeyCode Keypad2 = 258;
	public const KeyCode Keypad3 = 259;
	public const KeyCode Keypad4 = 260;
	public const KeyCode Keypad5 = 261;
	public const KeyCode Keypad6 = 262;
	public const KeyCode Keypad7 = 263;
	public const KeyCode Keypad8 = 264;
	public const KeyCode Keypad9 = 265;
	public const KeyCode KeypadPeriod = 266;
	public const KeyCode KeypadDivide = 267;
	public const KeyCode KeypadMultiply = 268;
	public const KeyCode KeypadMinus = 269;
	public const KeyCode KeypadPlus = 270;
	public const KeyCode KeypadEnter = 271;
	public const KeyCode KeypadEquals = 272;
	public const KeyCode UpArrow = 273;
	public const KeyCode DownArrow = 274;
	public const KeyCode RightArrow = 275;
	public const KeyCode LeftArrow = 276;
	public const KeyCode Insert = 277;
	public const KeyCode Home = 278;
	public const KeyCode End = 279;
	public const KeyCode PageUp = 280;
	public const KeyCode PageDown = 281;
	public const KeyCode F1 = 282;
	public const KeyCode F2 = 283;
	public const KeyCode F3 = 284;
	public const KeyCode F4 = 285;
	public const KeyCode F5 = 286;
	public const KeyCode F6 = 287;
	public const KeyCode F7 = 288;
	public const KeyCode F8 = 289;
	public const KeyCode F9 = 290;
	public const KeyCode F10 = 291;
	public const KeyCode F11 = 292;
	public const KeyCode F12 = 293;
	public const KeyCode F13 = 294;
	public const KeyCode F14 = 295;
	public const KeyCode F15 = 296;
	public const KeyCode Alpha0 = 48;
	public const KeyCode Alpha1 = 49;
	public const KeyCode Alpha2 = 50;
	public const KeyCode Alpha3 = 51;
	public const KeyCode Alpha4 = 52;
	public const KeyCode Alpha5 = 53;
	public const KeyCode Alpha6 = 54;
	public const KeyCode Alpha7 = 55;
	public const KeyCode Alpha8 = 56;
	public const KeyCode Alpha9 = 57;
	public const KeyCode Exclaim = 33;
	public const KeyCode DoubleQuote = 34;
	public const KeyCode Hash = 35;
	public const KeyCode Dollar = 36;
	public const KeyCode Percent = 37;
	public const KeyCode Ampersand = 38;
	public const KeyCode Quote = 39;
	public const KeyCode LeftParen = 40;
	public const KeyCode RightParen = 41;
	public const KeyCode Asterisk = 42;
	public const KeyCode Plus = 43;
	public const KeyCode Comma = 44;
	public const KeyCode Minus = 45;
	public const KeyCode Period = 46;
	public const KeyCode Slash = 47;
	public const KeyCode Colon = 58;
	public const KeyCode Semicolon = 59;
	public const KeyCode Less = 60;
	public const KeyCode Equals = 61;
	public const KeyCode Greater = 62;
	public const KeyCode Question = 63;
	public const KeyCode At = 64;
	public const KeyCode LeftBracket = 91;
	public const KeyCode Backslash = 92;
	public const KeyCode RightBracket = 93;
	public const KeyCode Caret = 94;
	public const KeyCode Underscore = 95;
	public const KeyCode BackQuote = 96;
	public const KeyCode A = 97;
	public const KeyCode B = 98;
	public const KeyCode C = 99;
	public const KeyCode D = 100;
	public const KeyCode E = 101;
	public const KeyCode F = 102;
	public const KeyCode G = 103;
	public const KeyCode H = 104;
	public const KeyCode I = 105;
	public const KeyCode J = 106;
	public const KeyCode K = 107;
	public const KeyCode L = 108;
	public const KeyCode M = 109;
	public const KeyCode N = 110;
	public const KeyCode O = 111;
	public const KeyCode P = 112;
	public const KeyCode Q = 113;
	public const KeyCode R = 114;
	public const KeyCode S = 115;
	public const KeyCode T = 116;
	public const KeyCode U = 117;
	public const KeyCode V = 118;
	public const KeyCode W = 119;
	public const KeyCode X = 120;
	public const KeyCode Y = 121;
	public const KeyCode Z = 122;
	public const KeyCode LeftCurlyBracket = 123;
	public const KeyCode Pipe = 124;
	public const KeyCode RightCurlyBracket = 125;
	public const KeyCode Tilde = 126;
	public const KeyCode Numlock = 300;
	public const KeyCode CapsLock = 301;
	public const KeyCode ScrollLock = 302;
	public const KeyCode RightShift = 303;
	public const KeyCode LeftShift = 304;
	public const KeyCode RightControl = 305;
	public const KeyCode LeftControl = 306;
	public const KeyCode RightAlt = 307;
	public const KeyCode LeftAlt = 308;
	public const KeyCode LeftCommand = 310;
	public const KeyCode LeftApple = 310;
	public const KeyCode LeftWindows = 311;
	public const KeyCode RightCommand = 309;
	public const KeyCode RightApple = 309;
	public const KeyCode RightWindows = 312;
	public const KeyCode AltGr = 313;
	public const KeyCode Help = 315;
	public const KeyCode Print = 316;
	public const KeyCode SysReq = 317;
	public const KeyCode Break = 318;
	public const KeyCode Menu = 319;
	public const KeyCode Mouse0 = 323;
	public const KeyCode Mouse1 = 324;
	public const KeyCode Mouse2 = 325;
	public const KeyCode Mouse3 = 326;
	public const KeyCode Mouse4 = 327;
	public const KeyCode Mouse5 = 328;
	public const KeyCode Mouse6 = 329;
	public const KeyCode JoystickButton0 = 330;
	public const KeyCode JoystickButton1 = 331;
	public const KeyCode JoystickButton2 = 332;
	public const KeyCode JoystickButton3 = 333;
	public const KeyCode JoystickButton4 = 334;
	public const KeyCode JoystickButton5 = 335;
	public const KeyCode JoystickButton6 = 336;
	public const KeyCode JoystickButton7 = 337;
	public const KeyCode JoystickButton8 = 338;
	public const KeyCode JoystickButton9 = 339;
	public const KeyCode JoystickButton10 = 340;
	public const KeyCode JoystickButton11 = 341;
	public const KeyCode JoystickButton12 = 342;
	public const KeyCode JoystickButton13 = 343;
	public const KeyCode JoystickButton14 = 344;
	public const KeyCode JoystickButton15 = 345;
	public const KeyCode JoystickButton16 = 346;
	public const KeyCode JoystickButton17 = 347;
	public const KeyCode JoystickButton18 = 348;
	public const KeyCode JoystickButton19 = 349;
	public const KeyCode Joystick1Button0 = 350;
	public const KeyCode Joystick1Button1 = 351;
	public const KeyCode Joystick1Button2 = 352;
	public const KeyCode Joystick1Button3 = 353;
	public const KeyCode Joystick1Button4 = 354;
	public const KeyCode Joystick1Button5 = 355;
	public const KeyCode Joystick1Button6 = 356;
	public const KeyCode Joystick1Button7 = 357;
	public const KeyCode Joystick1Button8 = 358;
	public const KeyCode Joystick1Button9 = 359;
	public const KeyCode Joystick1Button10 = 360;
	public const KeyCode Joystick1Button11 = 361;
	public const KeyCode Joystick1Button12 = 362;
	public const KeyCode Joystick1Button13 = 363;
	public const KeyCode Joystick1Button14 = 364;
	public const KeyCode Joystick1Button15 = 365;
	public const KeyCode Joystick1Button16 = 366;
	public const KeyCode Joystick1Button17 = 367;
	public const KeyCode Joystick1Button18 = 368;
	public const KeyCode Joystick1Button19 = 369;
	public const KeyCode Joystick2Button0 = 370;
	public const KeyCode Joystick2Button1 = 371;
	public const KeyCode Joystick2Button2 = 372;
	public const KeyCode Joystick2Button3 = 373;
	public const KeyCode Joystick2Button4 = 374;
	public const KeyCode Joystick2Button5 = 375;
	public const KeyCode Joystick2Button6 = 376;
	public const KeyCode Joystick2Button7 = 377;
	public const KeyCode Joystick2Button8 = 378;
	public const KeyCode Joystick2Button9 = 379;
	public const KeyCode Joystick2Button10 = 380;
	public const KeyCode Joystick2Button11 = 381;
	public const KeyCode Joystick2Button12 = 382;
	public const KeyCode Joystick2Button13 = 383;
	public const KeyCode Joystick2Button14 = 384;
	public const KeyCode Joystick2Button15 = 385;
	public const KeyCode Joystick2Button16 = 386;
	public const KeyCode Joystick2Button17 = 387;
	public const KeyCode Joystick2Button18 = 388;
	public const KeyCode Joystick2Button19 = 389;
	public const KeyCode Joystick3Button0 = 390;
	public const KeyCode Joystick3Button1 = 391;
	public const KeyCode Joystick3Button2 = 392;
	public const KeyCode Joystick3Button3 = 393;
	public const KeyCode Joystick3Button4 = 394;
	public const KeyCode Joystick3Button5 = 395;
	public const KeyCode Joystick3Button6 = 396;
	public const KeyCode Joystick3Button7 = 397;
	public const KeyCode Joystick3Button8 = 398;
	public const KeyCode Joystick3Button9 = 399;
	public const KeyCode Joystick3Button10 = 400;
	public const KeyCode Joystick3Button11 = 401;
	public const KeyCode Joystick3Button12 = 402;
	public const KeyCode Joystick3Button13 = 403;
	public const KeyCode Joystick3Button14 = 404;
	public const KeyCode Joystick3Button15 = 405;
	public const KeyCode Joystick3Button16 = 406;
	public const KeyCode Joystick3Button17 = 407;
	public const KeyCode Joystick3Button18 = 408;
	public const KeyCode Joystick3Button19 = 409;
	public const KeyCode Joystick4Button0 = 410;
	public const KeyCode Joystick4Button1 = 411;
	public const KeyCode Joystick4Button2 = 412;
	public const KeyCode Joystick4Button3 = 413;
	public const KeyCode Joystick4Button4 = 414;
	public const KeyCode Joystick4Button5 = 415;
	public const KeyCode Joystick4Button6 = 416;
	public const KeyCode Joystick4Button7 = 417;
	public const KeyCode Joystick4Button8 = 418;
	public const KeyCode Joystick4Button9 = 419;
	public const KeyCode Joystick4Button10 = 420;
	public const KeyCode Joystick4Button11 = 421;
	public const KeyCode Joystick4Button12 = 422;
	public const KeyCode Joystick4Button13 = 423;
	public const KeyCode Joystick4Button14 = 424;
	public const KeyCode Joystick4Button15 = 425;
	public const KeyCode Joystick4Button16 = 426;
	public const KeyCode Joystick4Button17 = 427;
	public const KeyCode Joystick4Button18 = 428;
	public const KeyCode Joystick4Button19 = 429;
	public const KeyCode Joystick5Button0 = 430;
	public const KeyCode Joystick5Button1 = 431;
	public const KeyCode Joystick5Button2 = 432;
	public const KeyCode Joystick5Button3 = 433;
	public const KeyCode Joystick5Button4 = 434;
	public const KeyCode Joystick5Button5 = 435;
	public const KeyCode Joystick5Button6 = 436;
	public const KeyCode Joystick5Button7 = 437;
	public const KeyCode Joystick5Button8 = 438;
	public const KeyCode Joystick5Button9 = 439;
	public const KeyCode Joystick5Button10 = 440;
	public const KeyCode Joystick5Button11 = 441;
	public const KeyCode Joystick5Button12 = 442;
	public const KeyCode Joystick5Button13 = 443;
	public const KeyCode Joystick5Button14 = 444;
	public const KeyCode Joystick5Button15 = 445;
	public const KeyCode Joystick5Button16 = 446;
	public const KeyCode Joystick5Button17 = 447;
	public const KeyCode Joystick5Button18 = 448;
	public const KeyCode Joystick5Button19 = 449;
	public const KeyCode Joystick6Button0 = 450;
	public const KeyCode Joystick6Button1 = 451;
	public const KeyCode Joystick6Button2 = 452;
	public const KeyCode Joystick6Button3 = 453;
	public const KeyCode Joystick6Button4 = 454;
	public const KeyCode Joystick6Button5 = 455;
	public const KeyCode Joystick6Button6 = 456;
	public const KeyCode Joystick6Button7 = 457;
	public const KeyCode Joystick6Button8 = 458;
	public const KeyCode Joystick6Button9 = 459;
	public const KeyCode Joystick6Button10 = 460;
	public const KeyCode Joystick6Button11 = 461;
	public const KeyCode Joystick6Button12 = 462;
	public const KeyCode Joystick6Button13 = 463;
	public const KeyCode Joystick6Button14 = 464;
	public const KeyCode Joystick6Button15 = 465;
	public const KeyCode Joystick6Button16 = 466;
	public const KeyCode Joystick6Button17 = 467;
	public const KeyCode Joystick6Button18 = 468;
	public const KeyCode Joystick6Button19 = 469;
	public const KeyCode Joystick7Button0 = 470;
	public const KeyCode Joystick7Button1 = 471;
	public const KeyCode Joystick7Button2 = 472;
	public const KeyCode Joystick7Button3 = 473;
	public const KeyCode Joystick7Button4 = 474;
	public const KeyCode Joystick7Button5 = 475;
	public const KeyCode Joystick7Button6 = 476;
	public const KeyCode Joystick7Button7 = 477;
	public const KeyCode Joystick7Button8 = 478;
	public const KeyCode Joystick7Button9 = 479;
	public const KeyCode Joystick7Button10 = 480;
	public const KeyCode Joystick7Button11 = 481;
	public const KeyCode Joystick7Button12 = 482;
	public const KeyCode Joystick7Button13 = 483;
	public const KeyCode Joystick7Button14 = 484;
	public const KeyCode Joystick7Button15 = 485;
	public const KeyCode Joystick7Button16 = 486;
	public const KeyCode Joystick7Button17 = 487;
	public const KeyCode Joystick7Button18 = 488;
	public const KeyCode Joystick7Button19 = 489;
	public const KeyCode Joystick8Button0 = 490;
	public const KeyCode Joystick8Button1 = 491;
	public const KeyCode Joystick8Button2 = 492;
	public const KeyCode Joystick8Button3 = 493;
	public const KeyCode Joystick8Button4 = 494;
	public const KeyCode Joystick8Button5 = 495;
	public const KeyCode Joystick8Button6 = 496;
	public const KeyCode Joystick8Button7 = 497;
	public const KeyCode Joystick8Button8 = 498;
	public const KeyCode Joystick8Button9 = 499;
	public const KeyCode Joystick8Button10 = 500;
	public const KeyCode Joystick8Button11 = 501;
	public const KeyCode Joystick8Button12 = 502;
	public const KeyCode Joystick8Button13 = 503;
	public const KeyCode Joystick8Button14 = 504;
	public const KeyCode Joystick8Button15 = 505;
	public const KeyCode Joystick8Button16 = 506;
	public const KeyCode Joystick8Button17 = 507;
	public const KeyCode Joystick8Button18 = 508;
	public const KeyCode Joystick8Button19 = 509;
}

// Namespace: UnityEngine
public interface ILogHandler
{
	// Methods

	// RVA: -1
	public abstract Void LogFormat(LogType logType, Object context, String format, Object[] args) { }

	// RVA: -1
	public abstract Void LogException(Exception exception, Object context) { }

}

// Namespace: UnityEngine
public interface ILogger
{
	// Properties
	public abstract ILogHandler logHandler { get; }
	public abstract Boolean logEnabled { get; }
	public abstract LogType filterLogType { set; }

	// Methods

	// RVA: -1
	public abstract ILogHandler get_logHandler() { }

	// RVA: -1
	public abstract Boolean get_logEnabled() { }

	// RVA: -1
	public abstract Void set_filterLogType(LogType value) { }

	// RVA: -1
	public abstract Boolean IsLogTypeAllowed(LogType logType) { }

	// RVA: -1
	public abstract Void Log(LogType logType, Object message) { }

	// RVA: -1
	public abstract Void Log(LogType logType, Object message, Object context) { }

	// RVA: -1
	public abstract Void LogError(String tag, Object message) { }

	// RVA: -1
	public abstract Void LogFormat(LogType logType, String format, Object[] args) { }

}

// Namespace: UnityEngine
public class Logger
{
	// Fields
	private ILogHandler <logHandler>k__BackingField; // 0x10
	private Boolean <logEnabled>k__BackingField; // 0x18
	private LogType <filterLogType>k__BackingField; // 0x1C

	// Properties
	public ILogHandler logHandler { get; set; }
	public Boolean logEnabled { get; set; }
	public LogType filterLogType { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C0B5F4
	public Void .ctor(ILogHandler logHandler) { }

	// RVA: 0xFFFFFFFF75C0B63C
	public ILogHandler get_logHandler() { }

	// RVA: 0xFFFFFFFF75C0B644
	public Void set_logHandler(ILogHandler value) { }

	// RVA: 0xFFFFFFFF75C0B67C
	public Boolean get_logEnabled() { }

	// RVA: 0xFFFFFFFF75C0B684
	public Void set_logEnabled(Boolean value) { }

	// RVA: 0xFFFFFFFF75C0B68C
	public LogType get_filterLogType() { }

	// RVA: 0xFFFFFFFF75C0B694
	public Void set_filterLogType(LogType value) { }

	// RVA: 0xFFFFFFFF75C0B69C
	public Boolean IsLogTypeAllowed(LogType logType) { }

	// RVA: 0xFFFFFFFF723BCF78
	private static String GetString(Object message) { }

	// RVA: 0xFFFFFFFF723BD078
	public Void Log(LogType logType, Object message) { }

	// RVA: 0xFFFFFFFF75C0B6D0
	public Void Log(LogType logType, Object message, Object context) { }

	// RVA: 0xFFFFFFFF75C0B7F0
	public Void LogError(String tag, Object message) { }

	// RVA: 0xFFFFFFFF75C0B944
	public Void LogException(Exception exception, Object context) { }

	// RVA: 0xFFFFFFFF75C0B9EC
	public Void LogFormat(LogType logType, String format, Object[] args) { }

	// RVA: 0xFFFFFFFF75C0BABC
	public Void LogFormat(LogType logType, Object context, String format, Object[] args) { }

}

// Namespace: UnityEngine
internal class UnityLogWriter
{
	// Methods

	// RVA: 0xFFFFFFFF75C450E0
	public static Void WriteStringToUnityLog(String s) { }

	// RVA: 0xFFFFFFFF75C45128
	private static Void WriteStringToUnityLogImpl(String s) { }

	// RVA: 0xFFFFFFFF75C45168
	public static Void Init() { }

	// RVA: 0xFFFFFFFF75C45228
	public override Void Write(Char value) { }

	// RVA: 0xFFFFFFFF75C45288
	public override Void Write(String s) { }

	// RVA: 0xFFFFFFFF75C452D0
	public override Void Write(Char[] buffer, Int32 index, Int32 count) { }

	// RVA: 0xFFFFFFFF75C451E8
	public Void .ctor() { }

}

// Namespace: UnityEngine
public struct Color
{
	// Fields
	public Single r; // 0x10
	public Single g; // 0x14
	public Single b; // 0x18
	public Single a; // 0x1C

	// Properties
	public static Color red { get; }
	public static Color green { get; }
	public static Color blue { get; }
	public static Color white { get; }
	public static Color black { get; }
	public static Color yellow { get; }
	public static Color cyan { get; }
	public static Color magenta { get; }
	public static Color gray { get; }
	public static Color grey { get; }
	public static Color clear { get; }
	public Single grayscale { get; }
	public Color linear { get; }
	public Color gamma { get; }
	public Single maxColorComponent { get; }
	public Single Item { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF7114B5B8
	public Void .ctor(Single r, Single g, Single b, Single a) { }

	// RVA: 0xFFFFFFFF7114B5C4
	public Void .ctor(Single r, Single g, Single b) { }

	// RVA: 0xFFFFFFFF7114B5D8
	public override String ToString() { }

	// RVA: 0xFFFFFFFF7114B5E0
	public String ToString(String format) { }

	// RVA: 0xFFFFFFFF7114B5E8
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114B5F0
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF7114B5F8
	public Boolean Equals(Color other) { }

	// RVA: 0xFFFFFFFF723B84EC
	public static Color op_Addition(Color a, Color b) { }

	// RVA: 0xFFFFFFFF723B8500
	public static Color op_Subtraction(Color a, Color b) { }

	// RVA: 0xFFFFFFFF723B8514
	public static Color op_Multiply(Color a, Color b) { }

	// RVA: 0xFFFFFFFF75BF9C08
	public static Color op_Multiply(Color a, Single b) { }

	// RVA: 0xFFFFFFFF723B8528
	public static Color op_Multiply(Single b, Color a) { }

	// RVA: 0xFFFFFFFF723B8540
	public static Color op_Division(Color a, Single b) { }

	// RVA: 0xFFFFFFFF723B8554
	public static Boolean op_Equality(Color lhs, Color rhs) { }

	// RVA: 0xFFFFFFFF723B85F8
	public static Boolean op_Inequality(Color lhs, Color rhs) { }

	// RVA: 0xFFFFFFFF723B86A0
	public static Color Lerp(Color a, Color b, Single t) { }

	// RVA: 0xFFFFFFFF75BF9C1C
	public static Color LerpUnclamped(Color a, Color b, Single t) { }

	// RVA: 0xFFFFFFFF7114B600
	internal Color RGBMultiplied(Single multiplier) { }

	// RVA: 0xFFFFFFFF723B875C
	public static Color get_red() { }

	// RVA: 0xFFFFFFFF723B8770
	public static Color get_green() { }

	// RVA: 0xFFFFFFFF75BF9C70
	public static Color get_blue() { }

	// RVA: 0xFFFFFFFF723B8784
	public static Color get_white() { }

	// RVA: 0xFFFFFFFF723B8798
	public static Color get_black() { }

	// RVA: 0xFFFFFFFF723B87AC
	public static Color get_yellow() { }

	// RVA: 0xFFFFFFFF75BF9C84
	public static Color get_cyan() { }

	// RVA: 0xFFFFFFFF75BF9C98
	public static Color get_magenta() { }

	// RVA: 0xFFFFFFFF75BF9CAC
	public static Color get_gray() { }

	// RVA: 0xFFFFFFFF723B87D0
	public static Color get_grey() { }

	// RVA: 0xFFFFFFFF723B87E4
	public static Color get_clear() { }

	// RVA: 0xFFFFFFFF7114B61C
	public Single get_grayscale() { }

	// RVA: 0xFFFFFFFF7114B654
	public Color get_linear() { }

	// RVA: 0xFFFFFFFF7114B65C
	public Color get_gamma() { }

	// RVA: 0xFFFFFFFF7114B664
	public Single get_maxColorComponent() { }

	// RVA: 0xFFFFFFFF723B84E8
	public static Vector4 op_Implicit(Color c) { }

	// RVA: 0xFFFFFFFF723B87F8
	public static Color op_Implicit(Vector4 v) { }

	// RVA: 0xFFFFFFFF7114B66C
	public Single get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF7114B674
	public Void set_Item(Int32 index, Single value) { }

	// RVA: 0xFFFFFFFF75BF9F64
	public static Void RGBToHSV(Color rgbColor, out Single H, out Single S, out Single V) { }

	// RVA: 0xFFFFFFFF75BFA074
	private static Void RGBToHSVHelper(Single offset, Single dominantcolor, Single colorone, Single colortwo, out Single H, out Single S, out Single V) { }

	// RVA: 0xFFFFFFFF75BFA0E4
	public static Color HSVToRGB(Single H, Single S, Single V) { }

	// RVA: 0xFFFFFFFF75BFA0EC
	public static Color HSVToRGB(Single H, Single S, Single V, Boolean hdr) { }

}

// Namespace: UnityEngine
public struct Color32
{
	// Fields
	private Int32 rgba; // 0x10
	public Byte r; // 0x10
	public Byte g; // 0x11
	public Byte b; // 0x12
	public Byte a; // 0x13

	// Methods

	// RVA: 0xFFFFFFFF7114B67C
	public Void .ctor(Byte r, Byte g, Byte b, Byte a) { }

	// RVA: 0xFFFFFFFF723B891C
	public static Color32 op_Implicit(Color c) { }

	// RVA: 0xFFFFFFFF723B8E1C
	public static Color op_Implicit(Color32 c) { }

	// RVA: 0xFFFFFFFF75BFA2AC
	public static Color32 Lerp(Color32 a, Color32 b, Single t) { }

	// RVA: 0xFFFFFFFF7114B690
	public override String ToString() { }

}

// Namespace: UnityEngine
public class ColorUtility
{
	// Methods

	// RVA: 0xFFFFFFFF75BFA55C
	internal static Boolean DoTryParseHtmlColor(String htmlString, out Color32 color) { }

	// RVA: 0xFFFFFFFF723B8E58
	public static Boolean TryParseHtmlString(String htmlString, out Color color) { }

	// RVA: 0xFFFFFFFF75BFA5AC
	public static String ToHtmlStringRGB(Color color) { }

	// RVA: 0xFFFFFFFF75BFA74C
	public static String ToHtmlStringRGBA(Color color) { }

}

// Namespace: UnityEngine
public struct GradientColorKey
{
	// Fields
	public Color color; // 0x10
	public Single time; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF7114BC0C
	public Void .ctor(Color col, Single time) { }

}

// Namespace: UnityEngine
public struct GradientAlphaKey
{
	// Fields
	public Single alpha; // 0x10
	public Single time; // 0x14

	// Methods

	// RVA: 0xFFFFFFFF7114BC04
	public Void .ctor(Single alpha, Single time) { }

}

// Namespace: UnityEngine
public class Gradient
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public GradientColorKey[] colorKeys { get; }
	public GradientAlphaKey[] alphaKeys { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C04738
	private static IntPtr Init() { }

	// RVA: 0xFFFFFFFF75C0476C
	private Void Cleanup() { }

	// RVA: 0xFFFFFFFF75C047AC
	private Boolean Internal_Equals(IntPtr other) { }

	// RVA: 0xFFFFFFFF723BA39C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF723BA3E0
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF723BA450
	public Color Evaluate(Single time) { }

	// RVA: 0xFFFFFFFF75C0485C
	public GradientColorKey[] get_colorKeys() { }

	// RVA: 0xFFFFFFFF75C0489C
	public GradientAlphaKey[] get_alphaKeys() { }

	// RVA: 0xFFFFFFFF723BA4C0
	public Void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys) { }

	// RVA: 0xFFFFFFFF75C048DC
	public override Boolean Equals(Object o) { }

	// RVA: 0xFFFFFFFF75C049B0
	public Boolean Equals(Gradient other) { }

	// RVA: 0xFFFFFFFF75C04A5C
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75C047FC
	private Void Evaluate_Injected(Single time, out Color ret) { }

}

// Namespace: UnityEngine
public struct FrustumPlanes
{
	// Fields
	public Single left; // 0x10
	public Single right; // 0x14
	public Single bottom; // 0x18
	public Single top; // 0x1C
	public Single zNear; // 0x20
	public Single zFar; // 0x24
}

// Namespace: UnityEngine
public struct Matrix4x4
{
	// Fields
	public Single m00; // 0x10
	public Single m10; // 0x14
	public Single m20; // 0x18
	public Single m30; // 0x1C
	public Single m01; // 0x20
	public Single m11; // 0x24
	public Single m21; // 0x28
	public Single m31; // 0x2C
	public Single m02; // 0x30
	public Single m12; // 0x34
	public Single m22; // 0x38
	public Single m32; // 0x3C
	public Single m03; // 0x40
	public Single m13; // 0x44
	public Single m23; // 0x48
	public Single m33; // 0x4C
	private static readonly Matrix4x4 zeroMatrix; // 0x0
	private static readonly Matrix4x4 identityMatrix; // 0x40

	// Properties
	public Quaternion rotation { get; }
	public Vector3 lossyScale { get; }
	public Boolean isIdentity { get; }
	public Single determinant { get; }
	public FrustumPlanes decomposeProjection { get; }
	public Matrix4x4 inverse { get; }
	public Matrix4x4 transpose { get; }
	public Int32 Item { set; }
	public Single Item { get; set; }
	public static Matrix4x4 zero { get; }
	public static Matrix4x4 identity { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114C348
	private Quaternion GetRotation() { }

	// RVA: 0xFFFFFFFF7114C350
	private Vector3 GetLossyScale() { }

	// RVA: 0xFFFFFFFF7114C358
	private Boolean IsIdentity() { }

	// RVA: 0xFFFFFFFF7114C360
	private Single GetDeterminant() { }

	// RVA: 0xFFFFFFFF7114C368
	private FrustumPlanes DecomposeProjection() { }

	// RVA: 0xFFFFFFFF7114C370
	public Quaternion get_rotation() { }

	// RVA: 0xFFFFFFFF7114C378
	public Vector3 get_lossyScale() { }

	// RVA: 0xFFFFFFFF7114C380
	public Boolean get_isIdentity() { }

	// RVA: 0xFFFFFFFF7114C388
	public Single get_determinant() { }

	// RVA: 0xFFFFFFFF7114C390
	public FrustumPlanes get_decomposeProjection() { }

	// RVA: 0xFFFFFFFF7114C3D0
	public Boolean ValidTRS() { }

	// RVA: 0xFFFFFFFF75C11D20
	public static Single Determinant(Matrix4x4 m) { }

	// RVA: 0xFFFFFFFF75C11D24
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	// RVA: 0xFFFFFFFF7114C3D8
	public Void SetTRS(Vector3 pos, Quaternion q, Vector3 s) { }

	// RVA: 0xFFFFFFFF75C11EF4
	public static Boolean Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result) { }

	// RVA: 0xFFFFFFFF723BF6C8
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	// RVA: 0xFFFFFFFF7114C3F0
	public Matrix4x4 get_inverse() { }

	// RVA: 0xFFFFFFFF75C12000
	public static Matrix4x4 Transpose(Matrix4x4 m) { }

	// RVA: 0xFFFFFFFF7114C3F8
	public Matrix4x4 get_transpose() { }

	// RVA: 0xFFFFFFFF75C1216C
	public static Matrix4x4 Ortho(Single left, Single right, Single bottom, Single top, Single zNear, Single zFar) { }

	// RVA: 0xFFFFFFFF75C122C0
	public static Matrix4x4 Perspective(Single fov, Single aspect, Single zNear, Single zFar) { }

	// RVA: 0xFFFFFFFF723BF860
	public static Matrix4x4 LookAt(Vector3 from, Vector3 to, Vector3 up) { }

	// RVA: 0xFFFFFFFF75C1244C
	public static Matrix4x4 Frustum(Single left, Single right, Single bottom, Single top, Single zNear, Single zFar) { }

	// RVA: 0xFFFFFFFF75C125A0
	public static Matrix4x4 Frustum(FrustumPlanes fp) { }

	// RVA: 0xFFFFFFFF7114C400
	public Void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	// RVA: 0xFFFFFFFF7114C41C
	public Void set_Item(Int32 row, Int32 column, Single value) { }

	// RVA: 0xFFFFFFFF7114C428
	public Single get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF7114C430
	public Void set_Item(Int32 index, Single value) { }

	// RVA: 0xFFFFFFFF7114C438
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114C440
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF7114C448
	public Boolean Equals(Matrix4x4 other) { }

	// RVA: 0xFFFFFFFF723BBEDC
	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0xFFFFFFFF723BFD24
	public static Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	// RVA: 0xFFFFFFFF75C12794
	public static Boolean op_Equality(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0xFFFFFFFF75C12964
	public static Boolean op_Inequality(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0xFFFFFFFF7114C47C
	public Vector4 GetColumn(Int32 index) { }

	// RVA: 0xFFFFFFFF7114C484
	public Vector4 GetRow(Int32 index) { }

	// RVA: 0xFFFFFFFF7114C48C
	public Void SetColumn(Int32 index, Vector4 column) { }

	// RVA: 0xFFFFFFFF7114C494
	public Void SetRow(Int32 index, Vector4 row) { }

	// RVA: 0xFFFFFFFF7114C49C
	public Vector3 MultiplyPoint(Vector3 point) { }

	// RVA: 0xFFFFFFFF7114C4A4
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	// RVA: 0xFFFFFFFF7114C4AC
	public Vector3 MultiplyVector(Vector3 vector) { }

	// RVA: 0xFFFFFFFF7114C4F8
	public Plane TransformPlane(Plane plane) { }

	// RVA: 0xFFFFFFFF75C12B5C
	public static Matrix4x4 Scale(Vector3 vector) { }

	// RVA: 0xFFFFFFFF723C0354
	public static Matrix4x4 Translate(Vector3 vector) { }

	// RVA: 0xFFFFFFFF75C12B88
	public static Matrix4x4 Rotate(Quaternion q) { }

	// RVA: 0xFFFFFFFF723C0388
	public static Matrix4x4 get_zero() { }

	// RVA: 0xFFFFFFFF723BBD14
	public static Matrix4x4 get_identity() { }

	// RVA: 0xFFFFFFFF7114C500
	public override String ToString() { }

	// RVA: 0xFFFFFFFF7114C508
	public String ToString(String format) { }

	// RVA: 0xFFFFFFFF7114C510
	private String ToInvariantString(String format, Single val) { }

	// RVA: 0xFFFFFFFF75C132FC
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C11904
	private static Void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75C119D0
	private static Void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C11A7C
	private static Boolean IsIdentity_Injected(ref Matrix4x4 _unity_self) { }

	// RVA: 0xFFFFFFFF75C11B18
	private static Single GetDeterminant_Injected(ref Matrix4x4 _unity_self) { }

	// RVA: 0xFFFFFFFF75C11BE8
	private static Void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret) { }

	// RVA: 0xFFFFFFFF75C11CE0
	private static Boolean ValidTRS_Injected(ref Matrix4x4 _unity_self) { }

	// RVA: 0xFFFFFFFF75C11DD4
	private static Void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75C11F60
	private static Boolean Inverse3DAffine_Injected(ref Matrix4x4 input, ref Matrix4x4 result) { }

	// RVA: 0xFFFFFFFF75C11FB0
	private static Void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75C12094
	private static Void Transpose_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75C12238
	private static Void Ortho_Injected(Single left, Single right, Single bottom, Single top, Single zNear, Single zFar, out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75C12374
	private static Void Perspective_Injected(Single fov, Single aspect, Single zNear, Single zFar, out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75C123E4
	private static Void LookAt_Injected(ref Vector3 from, ref Vector3 to, ref Vector3 up, out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75C12518
	private static Void Frustum_Injected(Single left, Single right, Single bottom, Single top, Single zNear, Single zFar, out Matrix4x4 ret) { }

}

// Namespace: UnityEngine
public struct Vector3
{
	// Fields
	public const Single kEpsilon = 925353388;
	public const Single kEpsilonNormalSqrt = 646978941;
	public Single x; // 0x10
	public Single y; // 0x14
	public Single z; // 0x18
	private static readonly Vector3 zeroVector; // 0x0
	private static readonly Vector3 oneVector; // 0xC
	private static readonly Vector3 upVector; // 0x18
	private static readonly Vector3 downVector; // 0x24
	private static readonly Vector3 leftVector; // 0x30
	private static readonly Vector3 rightVector; // 0x3C
	private static readonly Vector3 forwardVector; // 0x48
	private static readonly Vector3 backVector; // 0x54
	private static readonly Vector3 positiveInfinityVector; // 0x60
	private static readonly Vector3 negativeInfinityVector; // 0x6C

	// Properties
	public Single Item { get; set; }
	public Vector3 normalized { get; }
	public Single magnitude { get; }
	public Single sqrMagnitude { get; }
	public static Vector3 zero { get; }
	public static Vector3 one { get; }
	public static Vector3 forward { get; }
	public static Vector3 back { get; }
	public static Vector3 up { get; }
	public static Vector3 down { get; }
	public static Vector3 left { get; }
	public static Vector3 right { get; }
	public static Vector3 positiveInfinity { get; }
	public static Vector3 negativeInfinity { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C46D1C
	public static Vector3 Slerp(Vector3 a, Vector3 b, Single t) { }

	// RVA: 0xFFFFFFFF75C46E20
	public static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, Single t) { }

	// RVA: 0xFFFFFFFF75C46F24
	private static Void OrthoNormalize2(ref Vector3 a, ref Vector3 b) { }

	// RVA: 0xFFFFFFFF75C46F74
	public static Void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent) { }

	// RVA: 0xFFFFFFFF75C46FE0
	private static Void OrthoNormalize3(ref Vector3 a, ref Vector3 b, ref Vector3 c) { }

	// RVA: 0xFFFFFFFF75C47038
	public static Void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent, ref Vector3 binormal) { }

	// RVA: 0xFFFFFFFF75C470AC
	public static Vector3 RotateTowards(Vector3 current, Vector3 target, Single maxRadiansDelta, Single maxMagnitudeDelta) { }

	// RVA: 0xFFFFFFFF723CCBE8
	public static Vector3 Lerp(Vector3 a, Vector3 b, Single t) { }

	// RVA: 0xFFFFFFFF75C471C0
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, Single t) { }

	// RVA: 0xFFFFFFFF75C471E8
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, Single maxDistanceDelta) { }

	// RVA: 0xFFFFFFFF723CCC88
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, Single smoothTime, Single maxSpeed) { }

	// RVA: 0xFFFFFFFF723CCD74
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, Single smoothTime) { }

	// RVA: 0xFFFFFFFF75C472B8
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, Single smoothTime, Single maxSpeed, Single deltaTime) { }

	// RVA: 0xFFFFFFFF7114EE98
	public Single get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF7114EEA0
	public Void set_Item(Int32 index, Single value) { }

	// RVA: 0xFFFFFFFF7114EEA8
	public Void .ctor(Single x, Single y, Single z) { }

	// RVA: 0xFFFFFFFF7114EEB4
	public Void .ctor(Single x, Single y) { }

	// RVA: 0xFFFFFFFF7114EEC0
	public Void Set(Single newX, Single newY, Single newZ) { }

	// RVA: 0xFFFFFFFF723CD008
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	// RVA: 0xFFFFFFFF7114EECC
	public Void Scale(Vector3 scale) { }

	// RVA: 0xFFFFFFFF723CD018
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0xFFFFFFFF7114EEEC
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114EF2C
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF7114EF34
	public Boolean Equals(Vector3 other) { }

	// RVA: 0xFFFFFFFF75C47604
	public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

	// RVA: 0xFFFFFFFF723CD090
	public static Vector3 Normalize(Vector3 value) { }

	// RVA: 0xFFFFFFFF7114EF64
	public Void Normalize() { }

	// RVA: 0xFFFFFFFF7114EF6C
	public Vector3 get_normalized() { }

	// RVA: 0xFFFFFFFF723CD078
	public static Single Dot(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0xFFFFFFFF75C476F4
	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	// RVA: 0xFFFFFFFF75C477D8
	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) { }

	// RVA: 0xFFFFFFFF723CD430
	public static Single Angle(Vector3 from, Vector3 to) { }

	// RVA: 0xFFFFFFFF723CD5CC
	public static Single SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	// RVA: 0xFFFFFFFF723CD6D4
	public static Single Distance(Vector3 a, Vector3 b) { }

	// RVA: 0xFFFFFFFF75C478CC
	public static Vector3 ClampMagnitude(Vector3 vector, Single maxLength) { }

	// RVA: 0xFFFFFFFF75C47694
	public static Single Magnitude(Vector3 vector) { }

	// RVA: 0xFFFFFFFF7114EF74
	public Single get_magnitude() { }

	// RVA: 0xFFFFFFFF723CD7C0
	public static Single SqrMagnitude(Vector3 vector) { }

	// RVA: 0xFFFFFFFF7114EF7C
	public Single get_sqrMagnitude() { }

	// RVA: 0xFFFFFFFF723CD7D8
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0xFFFFFFFF723CD850
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0xFFFFFFFF723CD194
	public static Vector3 get_zero() { }

	// RVA: 0xFFFFFFFF723CD8C8
	public static Vector3 get_one() { }

	// RVA: 0xFFFFFFFF723CB898
	public static Vector3 get_forward() { }

	// RVA: 0xFFFFFFFF723CD914
	public static Vector3 get_back() { }

	// RVA: 0xFFFFFFFF723CB67C
	public static Vector3 get_up() { }

	// RVA: 0xFFFFFFFF723CD960
	public static Vector3 get_down() { }

	// RVA: 0xFFFFFFFF723CD9AC
	public static Vector3 get_left() { }

	// RVA: 0xFFFFFFFF723CB460
	public static Vector3 get_right() { }

	// RVA: 0xFFFFFFFF723CD9F8
	public static Vector3 get_positiveInfinity() { }

	// RVA: 0xFFFFFFFF75C47968
	public static Vector3 get_negativeInfinity() { }

	// RVA: 0xFFFFFFFF723CBDC4
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	// RVA: 0xFFFFFFFF723CBE8C
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	// RVA: 0xFFFFFFFF723CDA44
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	// RVA: 0xFFFFFFFF723CDA54
	public static Vector3 op_Multiply(Vector3 a, Single d) { }

	// RVA: 0xFFFFFFFF723CDA64
	public static Vector3 op_Multiply(Single d, Vector3 a) { }

	// RVA: 0xFFFFFFFF723CD184
	public static Vector3 op_Division(Vector3 a, Single d) { }

	// RVA: 0xFFFFFFFF723CDA78
	public static Boolean op_Equality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0xFFFFFFFF723CDAB0
	public static Boolean op_Inequality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0xFFFFFFFF7114EF9C
	public override String ToString() { }

	// RVA: 0xFFFFFFFF7114EFA4
	public String ToString(String format) { }

	// RVA: 0xFFFFFFFF75C47C24
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C46DB8
	private static Void Slerp_Injected(ref Vector3 a, ref Vector3 b, Single t, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C46EBC
	private static Void SlerpUnclamped_Injected(ref Vector3 a, ref Vector3 b, Single t, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C47150
	private static Void RotateTowards_Injected(ref Vector3 current, ref Vector3 target, Single maxRadiansDelta, Single maxMagnitudeDelta, out Vector3 ret) { }

}

// Namespace: UnityEngine
public struct Quaternion
{
	// Fields
	public Single x; // 0x10
	public Single y; // 0x14
	public Single z; // 0x18
	public Single w; // 0x1C
	private static readonly Quaternion identityQuaternion; // 0x0
	public const Single kEpsilon = 897988541;

	// Properties
	public Single Item { get; set; }
	public static Quaternion identity { get; }
	public Vector3 eulerAngles { get; set; }
	public Quaternion normalized { get; }

	// Methods

	// RVA: 0xFFFFFFFF723C4F7C
	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	// RVA: 0xFFFFFFFF723C5010
	public static Quaternion Inverse(Quaternion rotation) { }

	// RVA: 0xFFFFFFFF75C20684
	public static Quaternion Slerp(Quaternion a, Quaternion b, Single t) { }

	// RVA: 0xFFFFFFFF723C5094
	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, Single t) { }

	// RVA: 0xFFFFFFFF723C5134
	public static Quaternion Lerp(Quaternion a, Quaternion b, Single t) { }

	// RVA: 0xFFFFFFFF75C2085C
	public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, Single t) { }

	// RVA: 0xFFFFFFFF723C51D4
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	// RVA: 0xFFFFFFFF723C525C
	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	// RVA: 0xFFFFFFFF75C209FC
	private static Void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out Single angle) { }

	// RVA: 0xFFFFFFFF723C52E8
	public static Quaternion AngleAxis(Single angle, Vector3 axis) { }

	// RVA: 0xFFFFFFFF723C5380
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	// RVA: 0xFFFFFFFF723C5414
	public static Quaternion LookRotation(Vector3 forward) { }

	// RVA: 0xFFFFFFFF7114CF14
	public Single get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF7114CF1C
	public Void set_Item(Int32 index, Single value) { }

	// RVA: 0xFFFFFFFF7114CF24
	public Void .ctor(Single x, Single y, Single z, Single w) { }

	// RVA: 0xFFFFFFFF7114CF30
	public Void Set(Single newX, Single newY, Single newZ, Single newW) { }

	// RVA: 0xFFFFFFFF723C5574
	public static Quaternion get_identity() { }

	// RVA: 0xFFFFFFFF723C55C0
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0xFFFFFFFF723C5640
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	// RVA: 0xFFFFFFFF75C20D28
	private static Boolean IsEqualUsingDot(Single dot) { }

	// RVA: 0xFFFFFFFF723C56E4
	public static Boolean op_Equality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0xFFFFFFFF723C577C
	public static Boolean op_Inequality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0xFFFFFFFF75C20D3C
	public static Single Dot(Quaternion a, Quaternion b) { }

	// RVA: 0xFFFFFFFF7114CF3C
	public Void SetLookRotation(Vector3 view) { }

	// RVA: 0xFFFFFFFF7114CF44
	public Void SetLookRotation(Vector3 view, Vector3 up) { }

	// RVA: 0xFFFFFFFF723C59E4
	public static Single Angle(Quaternion a, Quaternion b) { }

	// RVA: 0xFFFFFFFF75C20D5C
	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	// RVA: 0xFFFFFFFF7114CF4C
	public Vector3 get_eulerAngles() { }

	// RVA: 0xFFFFFFFF7114CF54
	public Void set_eulerAngles(Vector3 value) { }

	// RVA: 0xFFFFFFFF723C5CB8
	public static Quaternion Euler(Single x, Single y, Single z) { }

	// RVA: 0xFFFFFFFF723C5DCC
	public static Quaternion Euler(Vector3 euler) { }

	// RVA: 0xFFFFFFFF7114CF5C
	public Void ToAngleAxis(out Single angle, out Vector3 axis) { }

	// RVA: 0xFFFFFFFF7114CF64
	public Void SetFromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	// RVA: 0xFFFFFFFF723C5EE0
	public static Quaternion RotateTowards(Quaternion from, Quaternion to, Single maxDegreesDelta) { }

	// RVA: 0xFFFFFFFF75C20F94
	public static Quaternion Normalize(Quaternion q) { }

	// RVA: 0xFFFFFFFF7114CF6C
	public Void Normalize() { }

	// RVA: 0xFFFFFFFF7114CF74
	public Quaternion get_normalized() { }

	// RVA: 0xFFFFFFFF7114CF7C
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114CF84
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF7114CF8C
	public Boolean Equals(Quaternion other) { }

	// RVA: 0xFFFFFFFF7114CF94
	public override String ToString() { }

	// RVA: 0xFFFFFFFF7114CF9C
	public String ToString(String format) { }

	// RVA: 0xFFFFFFFF75C2155C
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C205DC
	private static Void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75C20634
	private static Void Inverse_Injected(ref Quaternion rotation, out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75C20724
	private static Void Slerp_Injected(ref Quaternion a, ref Quaternion b, Single t, out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75C2078C
	private static Void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, Single t, out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75C207F4
	private static Void Lerp_Injected(ref Quaternion a, ref Quaternion b, Single t, out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75C208F4
	private static Void LerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, Single t, out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75C2095C
	private static Void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75C209AC
	private static Void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C20A80
	private static Void Internal_ToAxisAngleRad_Injected(ref Quaternion q, out Vector3 axis, out Single angle) { }

	// RVA: 0xFFFFFFFF75C20AD8
	private static Void AngleAxis_Injected(Single angle, ref Vector3 axis, out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75C20B38
	private static Void LookRotation_Injected(ref Vector3 forward, ref Vector3 upwards, out Quaternion ret) { }

}

// Namespace: UnityEngine
public struct Mathf
{
	// Fields
	public static readonly Single Epsilon; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75C10B1C
	public static Int32 ClosestPowerOfTwo(Int32 value) { }

	// RVA: 0xFFFFFFFF75C10B5C
	public static Boolean IsPowerOfTwo(Int32 value) { }

	// RVA: 0xFFFFFFFF75C10B9C
	public static Int32 NextPowerOfTwo(Int32 value) { }

	// RVA: 0xFFFFFFFF75C10BDC
	public static Single GammaToLinearSpace(Single value) { }

	// RVA: 0xFFFFFFFF75C10C20
	public static Single LinearToGammaSpace(Single value) { }

	// RVA: 0xFFFFFFFF75C10C64
	public static Color CorrelatedColorTemperatureToRGB(Single kelvin) { }

	// RVA: 0xFFFFFFFF75C10D34
	public static UInt16 FloatToHalf(Single val) { }

	// RVA: 0xFFFFFFFF75C10D78
	public static Single HalfToFloat(UInt16 val) { }

	// RVA: 0xFFFFFFFF75C10DB8
	public static Single PerlinNoise(Single x, Single y) { }

	// RVA: 0xFFFFFFFF75C10E04
	public static Single Sin(Single f) { }

	// RVA: 0xFFFFFFFF75C10E48
	public static Single Cos(Single f) { }

	// RVA: 0xFFFFFFFF75C10E8C
	public static Single Tan(Single f) { }

	// RVA: 0xFFFFFFFF75C10ED0
	public static Single Asin(Single f) { }

	// RVA: 0xFFFFFFFF75C10F14
	public static Single Acos(Single f) { }

	// RVA: 0xFFFFFFFF75C10F58
	public static Single Atan(Single f) { }

	// RVA: 0xFFFFFFFF75C10F9C
	public static Single Atan2(Single y, Single x) { }

	// RVA: 0xFFFFFFFF75C10FE8
	public static Single Sqrt(Single f) { }

	// RVA: 0xFFFFFFFF75C11024
	public static Single Abs(Single f) { }

	// RVA: 0xFFFFFFFF723BED8C
	public static Int32 Abs(Int32 value) { }

	// RVA: 0xFFFFFFFF723BEDD8
	public static Single Min(Single a, Single b) { }

	// RVA: 0xFFFFFFFF723BEDE4
	public static Single Min(Single[] values) { }

	// RVA: 0xFFFFFFFF723BEE8C
	public static Int32 Min(Int32 a, Int32 b) { }

	// RVA: 0xFFFFFFFF75C11060
	public static Int32 Min(Int32[] values) { }

	// RVA: 0xFFFFFFFF723BEE98
	public static Single Max(Single a, Single b) { }

	// RVA: 0xFFFFFFFF723BEEA4
	public static Single Max(Single[] values) { }

	// RVA: 0xFFFFFFFF723BEF4C
	public static Int32 Max(Int32 a, Int32 b) { }

	// RVA: 0xFFFFFFFF75C110B8
	public static Int32 Max(Int32[] values) { }

	// RVA: 0xFFFFFFFF75C11110
	public static Single Pow(Single f, Single p) { }

	// RVA: 0xFFFFFFFF75C11160
	public static Single Exp(Single power) { }

	// RVA: 0xFFFFFFFF75C111A4
	public static Single Log(Single f, Single p) { }

	// RVA: 0xFFFFFFFF75C111F4
	public static Single Log(Single f) { }

	// RVA: 0xFFFFFFFF75C11238
	public static Single Log10(Single f) { }

	// RVA: 0xFFFFFFFF75C1127C
	public static Single Ceil(Single f) { }

	// RVA: 0xFFFFFFFF75C112B8
	public static Single Floor(Single f) { }

	// RVA: 0xFFFFFFFF75C112F4
	public static Single Round(Single f) { }

	// RVA: 0xFFFFFFFF723BEF58
	public static Int32 CeilToInt(Single f) { }

	// RVA: 0xFFFFFFFF723BEFB8
	public static Int32 FloorToInt(Single f) { }

	// RVA: 0xFFFFFFFF723BF018
	public static Int32 RoundToInt(Single f) { }

	// RVA: 0xFFFFFFFF723BF0E4
	public static Single Sign(Single f) { }

	// RVA: 0xFFFFFFFF723BF0F8
	public static Single Clamp(Single value, Single min, Single max) { }

	// RVA: 0xFFFFFFFF723BF10C
	public static Int32 Clamp(Int32 value, Int32 min, Int32 max) { }

	// RVA: 0xFFFFFFFF723BF120
	public static Single Clamp01(Single value) { }

	// RVA: 0xFFFFFFFF723BF13C
	public static Single Lerp(Single a, Single b, Single t) { }

	// RVA: 0xFFFFFFFF75C113A8
	public static Single LerpUnclamped(Single a, Single b, Single t) { }

	// RVA: 0xFFFFFFFF75C113B8
	public static Single LerpAngle(Single a, Single b, Single t) { }

	// RVA: 0xFFFFFFFF75C114EC
	public static Single MoveTowards(Single current, Single target, Single maxDelta) { }

	// RVA: 0xFFFFFFFF75C11554
	public static Single MoveTowardsAngle(Single current, Single target, Single maxDelta) { }

	// RVA: 0xFFFFFFFF723BF25C
	public static Single SmoothStep(Single from, Single to, Single t) { }

	// RVA: 0xFFFFFFFF75C115FC
	public static Single Gamma(Single value, Single absmax, Single gamma) { }

	// RVA: 0xFFFFFFFF723BF2E8
	public static Boolean Approximately(Single a, Single b) { }

	// RVA: 0xFFFFFFFF723BF37C
	public static Single SmoothDamp(Single current, Single target, ref Single currentVelocity, Single smoothTime) { }

	// RVA: 0xFFFFFFFF723BF510
	public static Single SmoothDamp(Single current, Single target, ref Single currentVelocity, Single smoothTime, Single maxSpeed, Single deltaTime) { }

	// RVA: 0xFFFFFFFF75C1166C
	public static Single SmoothDampAngle(Single current, Single target, ref Single currentVelocity, Single smoothTime) { }

	// RVA: 0xFFFFFFFF75C11708
	public static Single SmoothDampAngle(Single current, Single target, ref Single currentVelocity, Single smoothTime, Single maxSpeed, Single deltaTime) { }

	// RVA: 0xFFFFFFFF75C1148C
	public static Single Repeat(Single t, Single length) { }

	// RVA: 0xFFFFFFFF75C11790
	public static Single PingPong(Single t, Single length) { }

	// RVA: 0xFFFFFFFF723BF64C
	public static Single InverseLerp(Single a, Single b, Single value) { }

	// RVA: 0xFFFFFFFF723BF1A8
	public static Single DeltaAngle(Single current, Single target) { }

	// RVA: 0xFFFFFFFF75C11820
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C10CE4
	private static Void CorrelatedColorTemperatureToRGB_Injected(Single kelvin, out Color ret) { }

}

// Namespace: UnityEngine
public struct Vector2
{
	// Fields
	public Single x; // 0x10
	public Single y; // 0x14
	private static readonly Vector2 zeroVector; // 0x0
	private static readonly Vector2 oneVector; // 0x8
	private static readonly Vector2 upVector; // 0x10
	private static readonly Vector2 downVector; // 0x18
	private static readonly Vector2 leftVector; // 0x20
	private static readonly Vector2 rightVector; // 0x28
	private static readonly Vector2 positiveInfinityVector; // 0x30
	private static readonly Vector2 negativeInfinityVector; // 0x38
	public const Single kEpsilon = 925353388;
	public const Single kEpsilonNormalSqrt = 646978941;

	// Properties
	public Single Item { get; set; }
	public Vector2 normalized { get; }
	public Single magnitude { get; }
	public Single sqrMagnitude { get; }
	public static Vector2 zero { get; }
	public static Vector2 one { get; }
	public static Vector2 up { get; }
	public static Vector2 down { get; }
	public static Vector2 left { get; }
	public static Vector2 right { get; }
	public static Vector2 positiveInfinity { get; }
	public static Vector2 negativeInfinity { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114ECC8
	public Single get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF7114ECD0
	public Void set_Item(Int32 index, Single value) { }

	// RVA: 0xFFFFFFFF7114ECD8
	public Void .ctor(Single x, Single y) { }

	// RVA: 0xFFFFFFFF7114ECE0
	public Void Set(Single newX, Single newY) { }

	// RVA: 0xFFFFFFFF75C45D04
	public static Vector2 Lerp(Vector2 a, Vector2 b, Single t) { }

	// RVA: 0xFFFFFFFF75C45D8C
	public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, Single t) { }

	// RVA: 0xFFFFFFFF75C45DA8
	public static Vector2 MoveTowards(Vector2 current, Vector2 target, Single maxDistanceDelta) { }

	// RVA: 0xFFFFFFFF75C45E4C
	public static Vector2 Scale(Vector2 a, Vector2 b) { }

	// RVA: 0xFFFFFFFF7114ECE8
	public Void Scale(Vector2 scale) { }

	// RVA: 0xFFFFFFFF7114ECFC
	public Void Normalize() { }

	// RVA: 0xFFFFFFFF7114ED04
	public Vector2 get_normalized() { }

	// RVA: 0xFFFFFFFF7114ED30
	public override String ToString() { }

	// RVA: 0xFFFFFFFF7114ED38
	public String ToString(String format) { }

	// RVA: 0xFFFFFFFF7114ED40
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114ED68
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF7114ED70
	public Boolean Equals(Vector2 other) { }

	// RVA: 0xFFFFFFFF75C460BC
	public static Vector2 Reflect(Vector2 inDirection, Vector2 inNormal) { }

	// RVA: 0xFFFFFFFF75C4613C
	public static Vector2 Perpendicular(Vector2 inDirection) { }

	// RVA: 0xFFFFFFFF75C4612C
	public static Single Dot(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0xFFFFFFFF7114ED94
	public Single get_magnitude() { }

	// RVA: 0xFFFFFFFF7114EDDC
	public Single get_sqrMagnitude() { }

	// RVA: 0xFFFFFFFF75C46160
	public static Single Angle(Vector2 from, Vector2 to) { }

	// RVA: 0xFFFFFFFF75C462A8
	public static Single SignedAngle(Vector2 from, Vector2 to) { }

	// RVA: 0xFFFFFFFF75C46348
	public static Single Distance(Vector2 a, Vector2 b) { }

	// RVA: 0xFFFFFFFF75C463AC
	public static Vector2 ClampMagnitude(Vector2 vector, Single maxLength) { }

	// RVA: 0xFFFFFFFF75C46428
	public static Single SqrMagnitude(Vector2 a) { }

	// RVA: 0xFFFFFFFF7114EDF0
	public Single SqrMagnitude() { }

	// RVA: 0xFFFFFFFF75C4644C
	public static Vector2 Min(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0xFFFFFFFF75C464A8
	public static Vector2 Max(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0xFFFFFFFF75C46504
	public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, Single smoothTime, Single maxSpeed) { }

	// RVA: 0xFFFFFFFF75C4679C
	public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, Single smoothTime) { }

	// RVA: 0xFFFFFFFF75C465B8
	public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, Single smoothTime, Single maxSpeed, Single deltaTime) { }

	// RVA: 0xFFFFFFFF723CCACC
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	// RVA: 0xFFFFFFFF723CCAD8
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	// RVA: 0xFFFFFFFF75C46848
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	// RVA: 0xFFFFFFFF75C46854
	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	// RVA: 0xFFFFFFFF75C46860
	public static Vector2 op_UnaryNegation(Vector2 a) { }

	// RVA: 0xFFFFFFFF723CCAE4
	public static Vector2 op_Multiply(Vector2 a, Single d) { }

	// RVA: 0xFFFFFFFF75C4686C
	public static Vector2 op_Multiply(Single d, Vector2 a) { }

	// RVA: 0xFFFFFFFF723CC9E4
	public static Vector2 op_Division(Vector2 a, Single d) { }

	// RVA: 0xFFFFFFFF723CCAF0
	public static Boolean op_Equality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0xFFFFFFFF723CCB1C
	public static Boolean op_Inequality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0xFFFFFFFF723CCB94
	public static Vector2 op_Implicit(Vector3 v) { }

	// RVA: 0xFFFFFFFF723CCB98
	public static Vector3 op_Implicit(Vector2 v) { }

	// RVA: 0xFFFFFFFF723C9BB8
	public static Vector2 get_zero() { }

	// RVA: 0xFFFFFFFF723CCBA0
	public static Vector2 get_one() { }

	// RVA: 0xFFFFFFFF75C4687C
	public static Vector2 get_up() { }

	// RVA: 0xFFFFFFFF75C468BC
	public static Vector2 get_down() { }

	// RVA: 0xFFFFFFFF75C468FC
	public static Vector2 get_left() { }

	// RVA: 0xFFFFFFFF75C4693C
	public static Vector2 get_right() { }

	// RVA: 0xFFFFFFFF75C4697C
	public static Vector2 get_positiveInfinity() { }

	// RVA: 0xFFFFFFFF75C469BC
	public static Vector2 get_negativeInfinity() { }

	// RVA: 0xFFFFFFFF75C469FC
	private static Void .cctor() { }

}

// Namespace: UnityEngine
public struct Vector2Int
{
	// Fields
	private Int32 m_X; // 0x10
	private Int32 m_Y; // 0x14
	private static readonly Vector2Int s_Zero; // 0x0
	private static readonly Vector2Int s_One; // 0x8
	private static readonly Vector2Int s_Up; // 0x10
	private static readonly Vector2Int s_Down; // 0x18
	private static readonly Vector2Int s_Left; // 0x20
	private static readonly Vector2Int s_Right; // 0x28

	// Properties
	public Int32 x { get; set; }
	public Int32 y { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF7114EE04
	public Int32 get_x() { }

	// RVA: 0xFFFFFFFF7114EE0C
	public Void set_x(Int32 value) { }

	// RVA: 0xFFFFFFFF7114EE14
	public Int32 get_y() { }

	// RVA: 0xFFFFFFFF7114EE1C
	public Void set_y(Int32 value) { }

	// RVA: 0xFFFFFFFF7114EE24
	public Void .ctor(Int32 x, Int32 y) { }

	// RVA: 0xFFFFFFFF75C46A5C
	public static Vector2 op_Implicit(Vector2Int v) { }

	// RVA: 0xFFFFFFFF7114EE2C
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF7114EE34
	public Boolean Equals(Vector2Int other) { }

	// RVA: 0xFFFFFFFF7114EE3C
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114EE90
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75C46C84
	private static Void .cctor() { }

}

// Namespace: UnityEngine
public struct Vector3Int
{
	// Fields
	private Int32 m_X; // 0x10
	private Int32 m_Y; // 0x14
	private Int32 m_Z; // 0x18
	private static readonly Vector3Int s_Zero; // 0x0
	private static readonly Vector3Int s_One; // 0xC
	private static readonly Vector3Int s_Up; // 0x18
	private static readonly Vector3Int s_Down; // 0x24
	private static readonly Vector3Int s_Left; // 0x30
	private static readonly Vector3Int s_Right; // 0x3C

	// Properties
	public Int32 x { get; }
	public Int32 y { get; }
	public Int32 z { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114EFAC
	public Int32 get_x() { }

	// RVA: 0xFFFFFFFF7114EFB4
	public Int32 get_y() { }

	// RVA: 0xFFFFFFFF7114EFBC
	public Int32 get_z() { }

	// RVA: 0xFFFFFFFF7114EFC4
	public Void .ctor(Int32 x, Int32 y, Int32 z) { }

	// RVA: 0xFFFFFFFF75C47CA0
	public static Boolean op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	// RVA: 0xFFFFFFFF7114EFD0
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF7114EFD8
	public Boolean Equals(Vector3Int other) { }

	// RVA: 0xFFFFFFFF7114EFE4
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114EFEC
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75C47F90
	private static Void .cctor() { }

}

// Namespace: UnityEngine
public struct Vector4
{
	// Fields
	public const Single kEpsilon = 925353388;
	public Single x; // 0x10
	public Single y; // 0x14
	public Single z; // 0x18
	public Single w; // 0x1C
	private static readonly Vector4 zeroVector; // 0x0
	private static readonly Vector4 oneVector; // 0x10
	private static readonly Vector4 positiveInfinityVector; // 0x20
	private static readonly Vector4 negativeInfinityVector; // 0x30

	// Properties
	public Single Item { get; set; }
	public Single magnitude { get; }
	public Single sqrMagnitude { get; }
	public static Vector4 zero { get; }
	public static Vector4 one { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114EFF4
	public Single get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF7114EFFC
	public Void set_Item(Int32 index, Single value) { }

	// RVA: 0xFFFFFFFF7114F004
	public Void .ctor(Single x, Single y, Single z, Single w) { }

	// RVA: 0xFFFFFFFF7114F010
	public Void Set(Single newX, Single newY, Single newZ, Single newW) { }

	// RVA: 0xFFFFFFFF75C48040
	public static Vector4 Lerp(Vector4 a, Vector4 b, Single t) { }

	// RVA: 0xFFFFFFFF7114F01C
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114F024
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF7114F02C
	public Boolean Equals(Vector4 other) { }

	// RVA: 0xFFFFFFFF723CDD34
	public static Single Dot(Vector4 a, Vector4 b) { }

	// RVA: 0xFFFFFFFF7114F068
	public Single get_magnitude() { }

	// RVA: 0xFFFFFFFF7114F070
	public Single get_sqrMagnitude() { }

	// RVA: 0xFFFFFFFF723C9C00
	public static Vector4 get_zero() { }

	// RVA: 0xFFFFFFFF75C48270
	public static Vector4 get_one() { }

	// RVA: 0xFFFFFFFF75C482B4
	public static Vector4 op_Addition(Vector4 a, Vector4 b) { }

	// RVA: 0xFFFFFFFF75C482C8
	public static Vector4 op_Subtraction(Vector4 a, Vector4 b) { }

	// RVA: 0xFFFFFFFF723CDD54
	public static Vector4 op_Multiply(Vector4 a, Single d) { }

	// RVA: 0xFFFFFFFF75C482DC
	public static Vector4 op_Division(Vector4 a, Single d) { }

	// RVA: 0xFFFFFFFF723CDD68
	public static Boolean op_Equality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0xFFFFFFFF723CDDAC
	public static Boolean op_Inequality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0xFFFFFFFF723CDE54
	public static Vector4 op_Implicit(Vector3 v) { }

	// RVA: 0xFFFFFFFF75C482F0
	public static Vector3 op_Implicit(Vector4 v) { }

	// RVA: 0xFFFFFFFF723CDE5C
	public static Vector4 op_Implicit(Vector2 v) { }

	// RVA: 0xFFFFFFFF75C482F4
	public static Vector2 op_Implicit(Vector4 v) { }

	// RVA: 0xFFFFFFFF7114F078
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75C48430
	private static Void .cctor() { }

}

// Namespace: UnityEngine
public sealed class Ping
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public Boolean isDone { get; }
	public Int32 time { get; }
	public String ip { get; }

	// Methods

	// RVA: 0xFFFFFFFF723C2AA8
	public Void .ctor(String address) { }

	// RVA: 0xFFFFFFFF723C2B00
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF723C2B84
	public Void DestroyPing() { }

	// RVA: 0xFFFFFFFF75C1C448
	private static Void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF75C1C408
	private static IntPtr Internal_Create(String address) { }

	// RVA: 0xFFFFFFFF723C2BE0
	public Boolean get_isDone() { }

	// RVA: 0xFFFFFFFF75C1C488
	private Boolean Internal_IsDone() { }

	// RVA: 0xFFFFFFFF723C2C50
	public Int32 get_time() { }

	// RVA: 0xFFFFFFFF75C1C4C8
	public String get_ip() { }

}

// Namespace: UnityEngine
internal interface IPlayerEditorConnectionNative
{
	// Methods

	// RVA: -1
	public abstract Void Initialize() { }

	// RVA: -1
	public abstract Void DisconnectAll() { }

	// RVA: -1
	public abstract Void SendMessage(Guid messageId, Byte[] data, Int32 playerId) { }

	// RVA: -1
	public abstract Boolean TrySendMessage(Guid messageId, Byte[] data, Int32 playerId) { }

	// RVA: -1
	public abstract Void Poll() { }

	// RVA: -1
	public abstract Void RegisterInternal(Guid messageId) { }

	// RVA: -1
	public abstract Void UnregisterInternal(Guid messageId) { }

	// RVA: -1
	public abstract Boolean IsConnected() { }

}

// Namespace: UnityEngine
internal class PlayerConnectionInternal
{
	// Methods

	// RVA: 0xFFFFFFFF75C1EDDC
	private Void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, Byte[] data, Int32 playerId) { }

	// RVA: 0xFFFFFFFF75C1EF58
	private Boolean UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, Byte[] data, Int32 playerId) { }

	// RVA: 0xFFFFFFFF75C1F0D4
	private Void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	// RVA: 0xFFFFFFFF75C1F13C
	private Void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	// RVA: 0xFFFFFFFF75C1F1E0
	private Void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	// RVA: 0xFFFFFFFF75C1F284
	private Void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	// RVA: 0xFFFFFFFF75C1F2EC
	private Boolean UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	// RVA: 0xFFFFFFFF75C1F354
	private Void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	// RVA: 0xFFFFFFFF75C1F320
	private static Boolean IsConnected() { }

	// RVA: 0xFFFFFFFF75C1F2B8
	private static Void Initialize() { }

	// RVA: 0xFFFFFFFF75C1F1A0
	private static Void RegisterInternal(String messageId) { }

	// RVA: 0xFFFFFFFF75C1F244
	private static Void UnregisterInternal(String messageId) { }

	// RVA: 0xFFFFFFFF75C1EF00
	private static Void SendMessage(String messageId, Byte[] data, Int32 playerId) { }

	// RVA: 0xFFFFFFFF75C1F07C
	private static Boolean TrySendMessage(String messageId, Byte[] data, Int32 playerId) { }

	// RVA: 0xFFFFFFFF75C1F108
	private static Void PollInternal() { }

	// RVA: 0xFFFFFFFF75C1F388
	private static Void DisconnectAll() { }

	// RVA: 0xFFFFFFFF75C1F3BC
	public Void .ctor() { }

}

// Namespace: UnityEngine
public class PlayerPrefsException
{
	// Methods

	// RVA: 0xFFFFFFFF75C1F4B0
	public Void .ctor(String error) { }

}

// Namespace: UnityEngine
public class PlayerPrefs
{
	// Methods

	// RVA: 0xFFFFFFFF75C1F3C0
	private static Boolean TrySetInt(String key, Int32 value) { }

	// RVA: 0xFFFFFFFF75C1F410
	private static Boolean TrySetFloat(String key, Single value) { }

	// RVA: 0xFFFFFFFF75C1F460
	private static Boolean TrySetSetString(String key, String value) { }

	// RVA: 0xFFFFFFFF723C4814
	public static Void SetInt(String key, Int32 value) { }

	// RVA: 0xFFFFFFFF723C48A0
	public static Int32 GetInt(String key, Int32 defaultValue) { }

	// RVA: 0xFFFFFFFF723C48FC
	public static Int32 GetInt(String key) { }

	// RVA: 0xFFFFFFFF723C4954
	public static Void SetFloat(String key, Single value) { }

	// RVA: 0xFFFFFFFF723C49DC
	public static Single GetFloat(String key, Single defaultValue) { }

	// RVA: 0xFFFFFFFF75C1F4F8
	public static Single GetFloat(String key) { }

	// RVA: 0xFFFFFFFF723C4A30
	public static Void SetString(String key, String value) { }

	// RVA: 0xFFFFFFFF723C4AB8
	public static String GetString(String key, String defaultValue) { }

	// RVA: 0xFFFFFFFF723C4B0C
	public static String GetString(String key) { }

	// RVA: 0xFFFFFFFF723C4B68
	public static Boolean HasKey(String key) { }

	// RVA: 0xFFFFFFFF723C4BBC
	public static Void DeleteKey(String key) { }

	// RVA: 0xFFFFFFFF75C1F550
	public static Void DeleteAll() { }

	// RVA: 0xFFFFFFFF723C4C00
	public static Void Save() { }

	// RVA: 0xFFFFFFFF75C1F584
	public Void .ctor() { }

}

// Namespace: UnityEngine
public abstract class PropertyAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75C20020
	protected Void .ctor() { }

}

// Namespace: UnityEngine
public class InspectorNameAttribute
{
	// Fields
	public readonly String displayName; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C05EE4
	public Void .ctor(String displayName) { }

}

// Namespace: UnityEngine
public class TooltipAttribute
{
	// Fields
	public readonly String tooltip; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C40F8C
	public Void .ctor(String tooltip) { }

}

// Namespace: UnityEngine
public class SpaceAttribute
{
	// Fields
	public readonly Single height; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C3810C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C38138
	public Void .ctor(Single height) { }

}

// Namespace: UnityEngine
public class HeaderAttribute
{
	// Fields
	public readonly String header; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C05E3C
	public Void .ctor(String header) { }

}

// Namespace: UnityEngine
public sealed class RangeAttribute
{
	// Fields
	public readonly Single min; // 0x10
	public readonly Single max; // 0x14

	// Methods

	// RVA: 0xFFFFFFFF75C216D4
	public Void .ctor(Single min, Single max) { }

}

// Namespace: UnityEngine
public sealed class MultilineAttribute
{
	// Fields
	public readonly Int32 lines; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C19700
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C1972C
	public Void .ctor(Int32 lines) { }

}

// Namespace: UnityEngine
public sealed class TextAreaAttribute
{
	// Fields
	public readonly Int32 minLines; // 0x10
	public readonly Int32 maxLines; // 0x14

	// Methods

	// RVA: 0xFFFFFFFF75C3CEA4
	public Void .ctor(Int32 minLines, Int32 maxLines) { }

}

// Namespace: UnityEngine
public sealed class ColorUsageAttribute
{
	// Fields
	public readonly Boolean showAlpha; // 0x10
	public readonly Boolean hdr; // 0x11
	public readonly Single minBrightness; // 0x14
	public readonly Single maxBrightness; // 0x18
	public readonly Single minExposureValue; // 0x1C
	public readonly Single maxExposureValue; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75BFA50C
	public Void .ctor(Boolean showAlpha, Boolean hdr) { }

}

// Namespace: UnityEngine
internal class PropertyNameUtils
{
	// Methods

	// RVA: 0xFFFFFFFF75C20090
	public static PropertyName PropertyNameFromString(String name) { }

	// RVA: 0xFFFFFFFF75C20214
	private static Void PropertyNameFromString_Injected(String name, out PropertyName ret) { }

}

// Namespace: UnityEngine
public struct PropertyName
{
	// Fields
	internal Int32 id; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114CE7C
	public Void .ctor(String name) { }

	// RVA: 0xFFFFFFFF7114CEE4
	public Void .ctor(PropertyName other) { }

	// RVA: 0xFFFFFFFF75C200F0
	public static Boolean op_Equality(PropertyName lhs, PropertyName rhs) { }

	// RVA: 0xFFFFFFFF7114CEEC
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114CEF4
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF7114CEFC
	public Boolean Equals(PropertyName other) { }

	// RVA: 0xFFFFFFFF7114CF0C
	public override String ToString() { }

}

// Namespace: UnityEngine
public sealed class Random
{
	// Properties
	public static Int32 seed { set; }
	public static Single value { get; }
	public static Vector3 onUnitSphere { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C21578
	public static Void set_seed(Int32 value) { }

	// RVA: 0xFFFFFFFF723C60C0
	public static Single Range(Single min, Single max) { }

	// RVA: 0xFFFFFFFF723C6110
	public static Int32 Range(Int32 min, Int32 max) { }

	// RVA: 0xFFFFFFFF75C215B8
	private static Int32 RandomRangeInt(Int32 min, Int32 max) { }

	// RVA: 0xFFFFFFFF75C21608
	public static Single get_value() { }

	// RVA: 0xFFFFFFFF75C2163C
	public static Vector3 get_onUnitSphere() { }

	// RVA: 0xFFFFFFFF75C21694
	private static Void get_onUnitSphere_Injected(out Vector3 ret) { }

}

// Namespace: UnityEngine
public class ResourceRequest
{
	// Fields
	internal String m_Path; // 0x20
	internal Type m_Type; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75C31EB8
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class Resources
{
	// Methods

	// RVA: -1
	internal static T[] ConvertObjects(Object[] rawObjects) { }

	// RVA: 0xFFFFFFFF75C31EC0
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: -1
	public static T[] FindObjectsOfTypeAll() { }

	// RVA: 0xFFFFFFFF75C31F00
	public static Object Load(String path) { }

	// RVA: -1
	public static T Load(String path) { }

	// RVA: 0xFFFFFFFF75C31F80
	public static Object Load(String path, Type systemTypeInstance) { }

	// RVA: 0xFFFFFFFF75C31FD0
	public static ResourceRequest LoadAsync(String path) { }

	// RVA: 0xFFFFFFFF75C32024
	public static ResourceRequest LoadAsync(String path, Type type) { }

	// RVA: 0xFFFFFFFF75C320C0
	internal static ResourceRequest LoadAsyncInternal(String path, Type type) { }

	// RVA: 0xFFFFFFFF75C32110
	public static Object[] LoadAll(String path, Type systemTypeInstance) { }

	// RVA: 0xFFFFFFFF75C32160
	public static Object[] LoadAll(String path) { }

	// RVA: -1
	public static T[] LoadAll(String path) { }

	// RVA: 0xFFFFFFFF75C321E0
	public static Object GetBuiltinResource(Type type, String path) { }

	// RVA: -1
	public static T GetBuiltinResource(String path) { }

	// RVA: 0xFFFFFFFF723C8F7C
	public static Void UnloadAsset(Object assetToUnload) { }

	// RVA: 0xFFFFFFFF723C8FC0
	public static AsyncOperation UnloadUnusedAssets() { }

	// RVA: 0xFFFFFFFF75C32230
	public Void .ctor() { }

}

// Namespace: UnityEngine
public class AsyncOperation
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private Action<T0> m_completeCallback; // 0x18

	// Properties
	public Boolean isDone { get; }
	public Single progress { get; }
	public Int32 priority { get; set; }
	public Boolean allowSceneActivation { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75BF3B20
	private static Void InternalDestroy(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF723B5F7C
	public Boolean get_isDone() { }

	// RVA: 0xFFFFFFFF75BF3B60
	public Single get_progress() { }

	// RVA: 0xFFFFFFFF75BF3BA4
	public Int32 get_priority() { }

	// RVA: 0xFFFFFFFF75BF3BE4
	public Void set_priority(Int32 value) { }

	// RVA: 0xFFFFFFFF75BF3C34
	public Boolean get_allowSceneActivation() { }

	// RVA: 0xFFFFFFFF75BF3C74
	public Void set_allowSceneActivation(Boolean value) { }

	// RVA: 0xFFFFFFFF723B5FD0
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF723B6040
	internal Void InvokeCompletionEvent() { }

	// RVA: 0xFFFFFFFF723B6094
	public Void add_completed(Action<T0> value) { }

	// RVA: 0xFFFFFFFF75BF3CC4
	public Void remove_completed(Action<T0> value) { }

	// RVA: 0xFFFFFFFF75BF3D58
	public Void .ctor() { }

}

// Namespace: UnityEngine
internal class AttributeHelperEngine
{
	// Fields
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; // 0x0
	public static ExecuteInEditMode[] _executeInEditModeArray; // 0x8
	public static RequireComponent[] _requireComponentArray; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75BF3D60
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	// RVA: 0xFFFFFFFF75BF3E50
	private static Type[] GetRequiredComponents(Type klass) { }

	// RVA: 0xFFFFFFFF75BF4134
	private static Int32 GetExecuteMode(Type klass) { }

	// RVA: 0xFFFFFFFF75BF4220
	private static Int32 CheckIsEditorScript(Type klass) { }

	// RVA: 0xFFFFFFFF75BF42F4
	private static Int32 GetDefaultExecutionOrderFor(Type klass) { }

	// RVA: -1
	private static T GetCustomAttributeOfType(Type klass) { }

	// RVA: 0xFFFFFFFF75BF4378
	private static Void .cctor() { }

}

// Namespace: UnityEngine
public sealed class DisallowMultipleComponent
{
	// Methods

	// RVA: 0xFFFFFFFF75BFE8EC
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class RequireComponent
{
	// Fields
	public Type m_Type0; // 0x10
	public Type m_Type1; // 0x18
	public Type m_Type2; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75C31CFC
	public Void .ctor(Type requiredComponent) { }

	// RVA: 0xFFFFFFFF75C31D40
	public Void .ctor(Type requiredComponent, Type requiredComponent2) { }

}

// Namespace: UnityEngine
public sealed class AddComponentMenu
{
	// Fields
	private String m_AddComponentMenu; // 0x10
	private Int32 m_Ordering; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75BEE8E4
	public Void .ctor(String menuName) { }

	// RVA: 0xFFFFFFFF75BEE934
	public Void .ctor(String menuName, Int32 order) { }

}

// Namespace: UnityEngine
public sealed class CreateAssetMenuAttribute
{
	// Fields
	private String <menuName>k__BackingField; // 0x10
	private String <fileName>k__BackingField; // 0x18
	private Int32 <order>k__BackingField; // 0x20

	// Properties
	public String menuName { set; }
	public String fileName { set; }
	public Int32 order { set; }

	// Methods

	// RVA: 0xFFFFFFFF75BFBCA8
	public Void set_menuName(String value) { }

	// RVA: 0xFFFFFFFF75BFBCE0
	public Void set_fileName(String value) { }

	// RVA: 0xFFFFFFFF75BFBD18
	public Void set_order(Int32 value) { }

	// RVA: 0xFFFFFFFF75BFBD20
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class ContextMenu
{
	// Fields
	public readonly String menuItem; // 0x10
	public readonly Boolean validate; // 0x18
	public readonly Int32 priority; // 0x1C

	// Methods

	// RVA: 0xFFFFFFFF75BFBB40
	public Void .ctor(String itemName) { }

	// RVA: 0xFFFFFFFF75BFBB9C
	public Void .ctor(String itemName, Boolean isValidateFunction) { }

	// RVA: 0xFFFFFFFF75BFBBFC
	public Void .ctor(String itemName, Boolean isValidateFunction, Int32 priority) { }

}

// Namespace: UnityEngine
public sealed class ExecuteInEditMode
{
	// Methods

	// RVA: 0xFFFFFFFF75C011E4
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class ExecuteAlways
{
	// Methods

	// RVA: 0xFFFFFFFF75C011DC
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class HideInInspector
{
	// Methods

	// RVA: 0xFFFFFFFF75C05EC4
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class HelpURLAttribute
{
	// Fields
	internal readonly String m_Url; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C05E80
	public Void .ctor(String url) { }

}

// Namespace: UnityEngine
public class DefaultExecutionOrder
{
	// Fields
	private Int32 m_Order; // 0x10

	// Properties
	public Int32 order { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BFE8C0
	public Void .ctor(Int32 order) { }

	// RVA: 0xFFFFFFFF75BF4370
	public Int32 get_order() { }

}

// Namespace: UnityEngine
public class AssemblyIsEditorAssembly
{}

// Namespace: UnityEngine
public class ExcludeFromPresetAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75C011D4
	public Void .ctor() { }

}

// Namespace: UnityEngine
public class Behaviour
{
	// Properties
	public Boolean enabled { get; set; }
	public Boolean isActiveAndEnabled { get; }

	// Methods

	// RVA: 0xFFFFFFFF723B6188
	public Boolean get_enabled() { }

	// RVA: 0xFFFFFFFF723B6200
	public Void set_enabled(Boolean value) { }

	// RVA: 0xFFFFFFFF723B6280
	public Boolean get_isActiveAndEnabled() { }

	// RVA: 0xFFFFFFFF723B62D4
	public Void .ctor() { }

}

// Namespace: UnityEngine
internal struct CastHelper<T0>
{
	// Fields
	public T t; // 0x0
	public IntPtr onePointerFurtherThanT; // 0x0
}

// Namespace: UnityEngine
internal static class ClassLibraryInitializer
{
	// Methods

	// RVA: 0xFFFFFFFF75BF9824
	private static Void Init() { }

}

// Namespace: UnityEngine
public class Component
{
	// Properties
	public Transform transform { get; }
	public GameObject gameObject { get; }
	public String tag { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF723B9000
	public Transform get_transform() { }

	// RVA: 0xFFFFFFFF723B9054
	public GameObject get_gameObject() { }

	// RVA: 0xFFFFFFFF75BFA944
	public Component GetComponent(Type type) { }

	// RVA: 0xFFFFFFFF723B90A8
	internal Void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: -1
	public T GetComponent() { }

	// RVA: 0xFFFFFFFF75BFAA18
	public Boolean TryGetComponent(Type type, out Component component) { }

	// RVA: -1
	public Boolean TryGetComponent(out T component) { }

	// RVA: 0xFFFFFFFF723B9104
	public Component GetComponent(String type) { }

	// RVA: 0xFFFFFFFF723B9158
	public Component GetComponentInChildren(Type t, Boolean includeInactive) { }

	// RVA: 0xFFFFFFFF75BFAB08
	public Component GetComponentInChildren(Type t) { }

	// RVA: -1
	public T GetComponentInChildren(Boolean includeInactive) { }

	// RVA: -1
	public T GetComponentInChildren() { }

	// RVA: 0xFFFFFFFF75BFAB10
	public Component[] GetComponentsInChildren(Type t, Boolean includeInactive) { }

	// RVA: 0xFFFFFFFF75BFAC08
	public Component[] GetComponentsInChildren(Type t) { }

	// RVA: -1
	public T[] GetComponentsInChildren(Boolean includeInactive) { }

	// RVA: -1
	public Void GetComponentsInChildren(Boolean includeInactive, List<T0> result) { }

	// RVA: -1
	public T[] GetComponentsInChildren() { }

	// RVA: -1
	public Void GetComponentsInChildren(List<T0> results) { }

	// RVA: 0xFFFFFFFF723B9254
	public Component GetComponentInParent(Type t) { }

	// RVA: -1
	public T GetComponentInParent() { }

	// RVA: 0xFFFFFFFF75BFACB8
	public Component[] GetComponentsInParent(Type t, Boolean includeInactive) { }

	// RVA: 0xFFFFFFFF75BFADB0
	public Component[] GetComponentsInParent(Type t) { }

	// RVA: -1
	public T[] GetComponentsInParent(Boolean includeInactive) { }

	// RVA: -1
	public Void GetComponentsInParent(Boolean includeInactive, List<T0> results) { }

	// RVA: -1
	public T[] GetComponentsInParent() { }

	// RVA: 0xFFFFFFFF75BFADB8
	public Component[] GetComponents(Type type) { }

	// RVA: 0xFFFFFFFF75BFAEAC
	private Void GetComponentsForListInternal(Type searchType, Object resultList) { }

	// RVA: 0xFFFFFFFF75BFAF04
	public Void GetComponents(Type type, List<T0> results) { }

	// RVA: -1
	public Void GetComponents(List<T0> results) { }

	// RVA: 0xFFFFFFFF75BFAF5C
	public String get_tag() { }

	// RVA: 0xFFFFFFFF75BFB010
	public Void set_tag(String value) { }

	// RVA: -1
	public T[] GetComponents() { }

	// RVA: 0xFFFFFFFF75BFB094
	public Boolean CompareTag(String tag) { }

	// RVA: 0xFFFFFFFF75BFB168
	public Void SendMessageUpwards(String methodName, Object value, SendMessageOptions options) { }

	// RVA: 0xFFFFFFFF75BFB1D0
	public Void SendMessageUpwards(String methodName, Object value) { }

	// RVA: 0xFFFFFFFF75BFB22C
	public Void SendMessageUpwards(String methodName) { }

	// RVA: 0xFFFFFFFF75BFB284
	public Void SendMessageUpwards(String methodName, SendMessageOptions options) { }

	// RVA: 0xFFFFFFFF75BFB2E0
	public Void SendMessage(String methodName, Object value) { }

	// RVA: 0xFFFFFFFF75BFB3A4
	public Void SendMessage(String methodName) { }

	// RVA: 0xFFFFFFFF75BFB33C
	public Void SendMessage(String methodName, Object value, SendMessageOptions options) { }

	// RVA: 0xFFFFFFFF75BFB3FC
	public Void SendMessage(String methodName, SendMessageOptions options) { }

	// RVA: 0xFFFFFFFF75BFB458
	public Void BroadcastMessage(String methodName, Object parameter, SendMessageOptions options) { }

	// RVA: 0xFFFFFFFF75BFB4C0
	public Void BroadcastMessage(String methodName, Object parameter) { }

	// RVA: 0xFFFFFFFF75BFB51C
	public Void BroadcastMessage(String methodName) { }

	// RVA: 0xFFFFFFFF75BFB574
	public Void BroadcastMessage(String methodName, SendMessageOptions options) { }

	// RVA: 0xFFFFFFFF723B62F4
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class Coroutine
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75BFBC60
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF723B942C
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75BFBC68
	private static Void ReleaseCoroutine(IntPtr ptr) { }

}

// Namespace: UnityEngine
internal class SetupCoroutine
{
	// Methods

	// RVA: 0xFFFFFFFF723C9390
	public static Void InvokeMoveNext(IEnumerator enumerator, IntPtr returnValueAddress) { }

	// RVA: 0xFFFFFFFF75C34980
	public static Object InvokeMember(Object behaviour, String name, Object variable) { }

}

// Namespace: UnityEngine
public abstract class CustomYieldInstruction
{
	// Properties
	public abstract Boolean keepWaiting { get; }
	public Object Current { get; }

	// Methods

	// RVA: -1
	public abstract Boolean get_keepWaiting() { }

	// RVA: 0xFFFFFFFF723B949C
	public Object get_Current() { }

	// RVA: 0xFFFFFFFF723B94A4
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75BFCBCC
	public Void Reset() { }

	// RVA: 0xFFFFFFFF723B94B4
	protected Void .ctor() { }

}

// Namespace: UnityEngine
public class ExcludeFromObjectFactoryAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75C011CC
	public Void .ctor() { }

}

// Namespace: UnityEngine
internal sealed class ExtensionOfNativeClassAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75C02DF8
	public Void .ctor() { }

}

// Namespace: UnityEngine
internal class FailedToLoadScriptObject
{}

// Namespace: UnityEngine
public sealed class GameObject
{
	// Properties
	public Transform transform { get; }
	public Int32 layer { get; set; }
	public Boolean active { get; set; }
	public Boolean activeSelf { get; }
	public Boolean activeInHierarchy { get; }
	public Boolean isStatic { get; set; }
	internal Boolean isStaticBatchable { get; }
	public String tag { get; set; }
	public Scene scene { get; }
	public UInt64 sceneCullingMask { get; }
	public GameObject gameObject { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C034FC
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	// RVA: -1
	public T GetComponent() { }

	// RVA: 0xFFFFFFFF75BFA9C8
	public Component GetComponent(Type type) { }

	// RVA: 0xFFFFFFFF723B9A48
	internal Void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0xFFFFFFFF75C0353C
	public static GameObject FindGameObjectsWithInstanceID(Int32 instanceID) { }

	// RVA: 0xFFFFFFFF75C0357C
	internal Component GetComponentByName(String type) { }

	// RVA: 0xFFFFFFFF723B9AA4
	public Component GetComponent(String type) { }

	// RVA: 0xFFFFFFFF723B91F0
	public Component GetComponentInChildren(Type type, Boolean includeInactive) { }

	// RVA: 0xFFFFFFFF75C035CC
	public Component GetComponentInChildren(Type type) { }

	// RVA: -1
	public T GetComponentInChildren() { }

	// RVA: -1
	public T GetComponentInChildren(Boolean includeInactive) { }

	// RVA: 0xFFFFFFFF75BFAC68
	public Component GetComponentInParent(Type type) { }

	// RVA: -1
	public T GetComponentInParent() { }

	// RVA: 0xFFFFFFFF723B9AF8
	private Array GetComponentsInternal(Type type, Boolean useSearchTypeAsArrayReturnType, Boolean recursive, Boolean includeInactive, Boolean reverse, Object resultList) { }

	// RVA: 0xFFFFFFFF75BFAE14
	public Component[] GetComponents(Type type) { }

	// RVA: -1
	public T[] GetComponents() { }

	// RVA: 0xFFFFFFFF75C03620
	public Void GetComponents(Type type, List<T0> results) { }

	// RVA: -1
	public Void GetComponents(List<T0> results) { }

	// RVA: 0xFFFFFFFF75C03688
	public Component[] GetComponentsInChildren(Type type) { }

	// RVA: 0xFFFFFFFF75BFAB74
	public Component[] GetComponentsInChildren(Type type, Boolean includeInactive) { }

	// RVA: -1
	public T[] GetComponentsInChildren(Boolean includeInactive) { }

	// RVA: -1
	public Void GetComponentsInChildren(Boolean includeInactive, List<T0> results) { }

	// RVA: -1
	public T[] GetComponentsInChildren() { }

	// RVA: -1
	public Void GetComponentsInChildren(List<T0> results) { }

	// RVA: 0xFFFFFFFF75C03690
	public Component[] GetComponentsInParent(Type type) { }

	// RVA: 0xFFFFFFFF75BFAD1C
	public Component[] GetComponentsInParent(Type type, Boolean includeInactive) { }

	// RVA: -1
	public Void GetComponentsInParent(Boolean includeInactive, List<T0> results) { }

	// RVA: -1
	public T[] GetComponentsInParent(Boolean includeInactive) { }

	// RVA: -1
	public T[] GetComponentsInParent() { }

	// RVA: -1
	public Boolean TryGetComponent(out T component) { }

	// RVA: 0xFFFFFFFF75BFAA7C
	public Boolean TryGetComponent(Type type, out Component component) { }

	// RVA: 0xFFFFFFFF75C03698
	internal Component TryGetComponentInternal(Type type) { }

	// RVA: 0xFFFFFFFF723B9B6C
	internal Void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0xFFFFFFFF75C036E8
	public static GameObject FindWithTag(String tag) { }

	// RVA: 0xFFFFFFFF75C03728
	public Void SendMessageUpwards(String methodName, SendMessageOptions options) { }

	// RVA: 0xFFFFFFFF723B9C0C
	public Void SendMessage(String methodName, SendMessageOptions options) { }

	// RVA: 0xFFFFFFFF75C03858
	public Void BroadcastMessage(String methodName, SendMessageOptions options) { }

	// RVA: 0xFFFFFFFF75C0391C
	internal Component AddComponentInternal(String className) { }

	// RVA: 0xFFFFFFFF75C0396C
	private Component Internal_AddComponentWithType(Type componentType) { }

	// RVA: 0xFFFFFFFF723B9C78
	public Component AddComponent(Type componentType) { }

	// RVA: -1
	public T AddComponent() { }

	// RVA: 0xFFFFFFFF723B9CCC
	public Transform get_transform() { }

	// RVA: 0xFFFFFFFF723B9D20
	public Int32 get_layer() { }

	// RVA: 0xFFFFFFFF723B9D98
	public Void set_layer(Int32 value) { }

	// RVA: 0xFFFFFFFF723B9E18
	public Boolean get_active() { }

	// RVA: 0xFFFFFFFF75C039BC
	public Void set_active(Boolean value) { }

	// RVA: 0xFFFFFFFF723B9E5C
	public Void SetActive(Boolean value) { }

	// RVA: 0xFFFFFFFF723B9EDC
	public Boolean get_activeSelf() { }

	// RVA: 0xFFFFFFFF723B9F54
	public Boolean get_activeInHierarchy() { }

	// RVA: 0xFFFFFFFF75C03A0C
	public Void SetActiveRecursively(Boolean state) { }

	// RVA: 0xFFFFFFFF75C03A5C
	public Boolean get_isStatic() { }

	// RVA: 0xFFFFFFFF723B9FCC
	public Void set_isStatic(Boolean value) { }

	// RVA: 0xFFFFFFFF75C03A9C
	internal Boolean get_isStaticBatchable() { }

	// RVA: 0xFFFFFFFF75BFAFD0
	public String get_tag() { }

	// RVA: 0xFFFFFFFF723B92F0
	public Void set_tag(String value) { }

	// RVA: 0xFFFFFFFF75BFB118
	public Boolean CompareTag(String tag) { }

	// RVA: 0xFFFFFFFF723B9BC8
	public static GameObject FindGameObjectWithTag(String tag) { }

	// RVA: 0xFFFFFFFF75C03ADC
	public static GameObject[] FindGameObjectsWithTag(String tag) { }

	// RVA: 0xFFFFFFFF75C03784
	public Void SendMessageUpwards(String methodName, Object value, SendMessageOptions options) { }

	// RVA: 0xFFFFFFFF75C03B1C
	public Void SendMessageUpwards(String methodName, Object value) { }

	// RVA: 0xFFFFFFFF75C03B78
	public Void SendMessageUpwards(String methodName) { }

	// RVA: 0xFFFFFFFF75C037EC
	public Void SendMessage(String methodName, Object value, SendMessageOptions options) { }

	// RVA: 0xFFFFFFFF723BA020
	public Void SendMessage(String methodName, Object value) { }

	// RVA: 0xFFFFFFFF75C03BD0
	public Void SendMessage(String methodName) { }

	// RVA: 0xFFFFFFFF75C038B4
	public Void BroadcastMessage(String methodName, Object parameter, SendMessageOptions options) { }

	// RVA: 0xFFFFFFFF75C03C28
	public Void BroadcastMessage(String methodName, Object parameter) { }

	// RVA: 0xFFFFFFFF75C03C84
	public Void BroadcastMessage(String methodName) { }

	// RVA: 0xFFFFFFFF723BA080
	public Void .ctor(String name) { }

	// RVA: 0xFFFFFFFF723BA100
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C03D2C
	public Void .ctor(String name, Type[] components) { }

	// RVA: 0xFFFFFFFF75C03CDC
	private static Void Internal_CreateGameObject(GameObject self, String name) { }

	// RVA: 0xFFFFFFFF723BA184
	public static GameObject Find(String name) { }

	// RVA: 0xFFFFFFFF75C03E24
	public Scene get_scene() { }

	// RVA: 0xFFFFFFFF75C03ECC
	public UInt64 get_sceneCullingMask() { }

	// RVA: 0xFFFFFFFF723BA1C8
	public GameObject get_gameObject() { }

	// RVA: 0xFFFFFFFF75C03E7C
	private Void get_scene_Injected(out Scene ret) { }

}

// Namespace: UnityEngine
public struct LayerMask
{
	// Fields
	private Int32 m_Mask; // 0x10

	// Properties
	public Int32 value { get; }

	// Methods

	// RVA: 0xFFFFFFFF723BC718
	public static Int32 op_Implicit(LayerMask mask) { }

	// RVA: 0xFFFFFFFF723BC71C
	public static LayerMask op_Implicit(Int32 intVal) { }

	// RVA: 0xFFFFFFFF7114C230
	public Int32 get_value() { }

	// RVA: 0xFFFFFFFF723BC728
	public static String LayerToName(Int32 layer) { }

	// RVA: 0xFFFFFFFF723BC76C
	public static Int32 NameToLayer(String layerName) { }

	// RVA: 0xFFFFFFFF75C08474
	public static Int32 GetMask(String[] layerNames) { }

}

// Namespace: UnityEngine
internal static class ManagedStreamHelpers
{
	// Methods

	// RVA: 0xFFFFFFFF75C0BE34
	internal static Void ValidateLoadFromStream(Stream stream) { }

	// RVA: 0xFFFFFFFF75C0BF48
	internal static Void ManagedStreamRead(Byte[] buffer, Int32 offset, Int32 count, Stream stream, IntPtr returnValueAddress) { }

	// RVA: 0xFFFFFFFF75C0C014
	internal static Void ManagedStreamSeek(Int64 offset, UInt32 origin, Stream stream, IntPtr returnValueAddress) { }

	// RVA: 0xFFFFFFFF75C0C0D8
	internal static Void ManagedStreamLength(Stream stream, IntPtr returnValueAddress) { }

}

// Namespace: UnityEngine
public class MonoBehaviour
{
	// Properties
	public Boolean useGUILayout { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C18E2C
	public Boolean IsInvoking() { }

	// RVA: 0xFFFFFFFF75C18EAC
	public Void CancelInvoke() { }

	// RVA: 0xFFFFFFFF75C18F2C
	public Void Invoke(String methodName, Single time) { }

	// RVA: 0xFFFFFFFF75C18FFC
	public Void InvokeRepeating(String methodName, Single time, Single repeatRate) { }

	// RVA: 0xFFFFFFFF75C190D8
	public Void CancelInvoke(String methodName) { }

	// RVA: 0xFFFFFFFF75C19178
	public Boolean IsInvoking(String methodName) { }

	// RVA: 0xFFFFFFFF75C19218
	public Coroutine StartCoroutine(String methodName) { }

	// RVA: 0xFFFFFFFF75C19220
	public Coroutine StartCoroutine(String methodName, Object value) { }

	// RVA: 0xFFFFFFFF723C2068
	public Coroutine StartCoroutine(IEnumerator routine) { }

	// RVA: 0xFFFFFFFF75C1941C
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	// RVA: 0xFFFFFFFF75C19420
	public Void StopCoroutine(IEnumerator routine) { }

	// RVA: 0xFFFFFFFF723C214C
	public Void StopCoroutine(Coroutine routine) { }

	// RVA: 0xFFFFFFFF75C195A0
	public Void StopCoroutine(String methodName) { }

	// RVA: 0xFFFFFFFF723C2230
	public Void StopAllCoroutines() { }

	// RVA: 0xFFFFFFFF75C195F0
	public Boolean get_useGUILayout() { }

	// RVA: 0xFFFFFFFF75C19630
	public Void set_useGUILayout(Boolean value) { }

	// RVA: 0xFFFFFFFF75C19680
	public static Void print(Object message) { }

	// RVA: 0xFFFFFFFF75C18EEC
	private static Void Internal_CancelInvokeAll(MonoBehaviour self) { }

	// RVA: 0xFFFFFFFF75C18E6C
	private static Boolean Internal_IsInvokingAll(MonoBehaviour self) { }

	// RVA: 0xFFFFFFFF75C18F94
	private static Void InvokeDelayed(MonoBehaviour self, String methodName, Single time, Single repeatRate) { }

	// RVA: 0xFFFFFFFF75C19128
	private static Void CancelInvoke(MonoBehaviour self, String methodName) { }

	// RVA: 0xFFFFFFFF75C191C8
	private static Boolean IsInvoking(MonoBehaviour self, String methodName) { }

	// RVA: 0xFFFFFFFF75C19334
	private static Boolean IsObjectMonoBehaviour(Object obj) { }

	// RVA: 0xFFFFFFFF75C19374
	private Coroutine StartCoroutineManaged(String methodName, Object value) { }

	// RVA: 0xFFFFFFFF75C193CC
	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	// RVA: 0xFFFFFFFF75C19550
	private Void StopCoroutineManaged(Coroutine routine) { }

	// RVA: 0xFFFFFFFF75C19500
	private Void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	// RVA: 0xFFFFFFFF75C196C0
	internal String GetScriptClassName() { }

	// RVA: 0xFFFFFFFF723C2274
	public Void .ctor() { }

}

// Namespace: UnityEngine
internal sealed class NoAllocHelpers
{
	// Methods

	// RVA: -1
	public static Void ResizeList(List<T0> list, Int32 size) { }

	// RVA: -1
	public static Void EnsureListElemCount(List<T0> list, Int32 count) { }

	// RVA: 0xFFFFFFFF723C0D98
	public static Int32 SafeLength(Array values) { }

	// RVA: -1
	public static Int32 SafeLength(List<T0> values) { }

	// RVA: -1
	public static T[] ExtractArrayFromListT(List<T0> list) { }

	// RVA: 0xFFFFFFFF723C23F8
	internal static Void Internal_ResizeList(Object list, Int32 size) { }

	// RVA: 0xFFFFFFFF723BE8AC
	public static Array ExtractArrayFromList(Object list) { }

}

// Namespace: UnityEngine
public struct RangeInt
{
	// Fields
	public Int32 start; // 0x10
	public Int32 length; // 0x14

	// Properties
	public Int32 end { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114CFA4
	public Int32 get_end() { }

	// RVA: 0xFFFFFFFF7114CFB0
	public Void .ctor(Int32 start, Int32 length) { }

}

// Namespace: UnityEngine
public enum RuntimeInitializeLoadType
{
	// Fields
	public Int32 value__; // 0x10
	public const RuntimeInitializeLoadType AfterSceneLoad = 0;
	public const RuntimeInitializeLoadType BeforeSceneLoad = 1;
	public const RuntimeInitializeLoadType AfterAssembliesLoaded = 2;
	public const RuntimeInitializeLoadType BeforeSplashScreen = 3;
	public const RuntimeInitializeLoadType SubsystemRegistration = 4;
}

// Namespace: UnityEngine
public class RuntimeInitializeOnLoadMethodAttribute
{
	// Fields
	private RuntimeInitializeLoadType m_LoadType; // 0x10

	// Properties
	private RuntimeInitializeLoadType loadType { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C32234
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C3226C
	public Void .ctor(RuntimeInitializeLoadType loadType) { }

	// RVA: 0xFFFFFFFF75C32264
	private Void set_loadType(RuntimeInitializeLoadType value) { }

}

// Namespace: UnityEngine
public class ScriptableObject
{
	// Methods

	// RVA: 0xFFFFFFFF723C868C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C34738
	public static ScriptableObject CreateInstance(Type type) { }

	// RVA: -1
	public static T CreateInstance() { }

	// RVA: 0xFFFFFFFF75C346F8
	private static Void CreateScriptableObject(ScriptableObject self) { }

	// RVA: 0xFFFFFFFF75C3477C
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, Boolean applyDefaultsAndReset) { }

}

// Namespace: UnityEngine
internal class ScriptingUtility
{
	// Methods

	// RVA: 0xFFFFFFFF75C3491C
	private static Boolean IsManagedCodeWorking() { }

}

// Namespace: 
private struct TestClass
{
	// Fields
	public Int32 value; // 0x10
}

// Namespace: UnityEngine
public class SelectionBaseAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75C34924
	public Void .ctor() { }

}

// Namespace: UnityEngine
public static class StackTraceUtility
{
	// Fields
	private static String projectFolder; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75C3A5FC
	internal static Void SetProjectFolder(String folder) { }

	// RVA: 0xFFFFFFFF723C9C4C
	public static String ExtractStackTrace() { }

	// RVA: 0xFFFFFFFF75C3A6C8
	internal static Void ExtractStringFromExceptionInternal(Object exceptiono, out String message, out String stackTrace) { }

	// RVA: 0xFFFFFFFF723C9DAC
	internal static String ExtractFormattedStackTrace(StackTrace stackTrace) { }

	// RVA: 0xFFFFFFFF75C3AA54
	private static Void .cctor() { }

}

// Namespace: UnityEngine
public class UnityException
{
	// Methods

	// RVA: 0xFFFFFFFF75C45008
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C3D8EC
	public Void .ctor(String message) { }

	// RVA: 0xFFFFFFFF75C45080
	protected Void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: UnityEngine
public class TextAsset
{
	// Properties
	public String text { get; }
	public Byte[] bytes { get; }

	// Methods

	// RVA: 0xFFFFFFFF723CA59C
	public String get_text() { }

	// RVA: 0xFFFFFFFF723CA5E0
	public Byte[] get_bytes() { }

	// RVA: 0xFFFFFFFF75C3CEDC
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75C3CF1C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C3CFBC
	public Void .ctor(String text) { }

	// RVA: 0xFFFFFFFF75C3CF28
	internal Void .ctor(CreateOptions options, String text) { }

	// RVA: 0xFFFFFFFF75C3CFC8
	private static Void Internal_CreateInstance(TextAsset self, String text) { }

}

// Namespace: 
internal enum CreateOptions
{
	// Fields
	public Int32 value__; // 0x10
	public const CreateOptions None = 0;
	public const CreateOptions CreateNativeObject = 1;
}

// Namespace: UnityEngine
public class TrackedReference
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C41AB4
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF723CA98C
	public static Boolean op_Equality(TrackedReference x, TrackedReference y) { }

	// RVA: 0xFFFFFFFF723CA9E4
	public static Boolean op_Inequality(TrackedReference x, TrackedReference y) { }

	// RVA: 0xFFFFFFFF75C41AB8
	public override Boolean Equals(Object o) { }

	// RVA: 0xFFFFFFFF723CAA3C
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF723CAA44
	public static Boolean op_Implicit(TrackedReference exists) { }

}

// Namespace: UnityEngine
internal sealed class UnhandledExceptionHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75C44D6C
	private static Void RegisterUECatcher() { }

	// RVA: 0xFFFFFFFF75C44DE8
	private static Void HandleUnhandledException(Object sender, UnhandledExceptionEventArgs args) { }

	// RVA: 0xFFFFFFFF75C44F24
	private static Void PrintException(String title, Exception e) { }

	// RVA: 0xFFFFFFFF75C44FB0
	private static Void iOSNativeUnhandledExceptionHandler(String managedExceptionType, String managedExceptionMessage, String managedExceptionStack) { }

}

// Namespace: UnityEngine
public enum HideFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const HideFlags None = 0;
	public const HideFlags HideInHierarchy = 1;
	public const HideFlags HideInInspector = 2;
	public const HideFlags DontSaveInEditor = 4;
	public const HideFlags NotEditable = 8;
	public const HideFlags DontSaveInBuild = 16;
	public const HideFlags DontUnloadUnusedAsset = 32;
	public const HideFlags DontSave = 52;
	public const HideFlags HideAndDontSave = 61;
}

// Namespace: UnityEngine
public class Object
{
	// Fields
	private IntPtr m_CachedPtr; // 0x10
	internal static Int32 OffsetOfInstanceIDInCPlusPlusObject; // 0x0
	private const String objectIsNullMessage = "The Object you want to instantiate is null.";
	private const String cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";

	// Properties
	public String name { get; set; }
	public HideFlags hideFlags { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF723BBE20
	public Int32 GetInstanceID() { }

	// RVA: 0xFFFFFFFF723C2454
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF723C2468
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF75C1B970
	public static Boolean op_Implicit(Object exists) { }

	// RVA: 0xFFFFFFFF723C25A8
	private static Boolean CompareBaseObjects(Object lhs, Object rhs) { }

	// RVA: 0xFFFFFFFF75C1B9B8
	private static Boolean IsNativeObjectAlive(Object o) { }

	// RVA: 0xFFFFFFFF75C1B9DC
	private IntPtr GetCachedPtr() { }

	// RVA: 0xFFFFFFFF723BBF80
	public String get_name() { }

	// RVA: 0xFFFFFFFF723C264C
	public Void set_name(String value) { }

	// RVA: 0xFFFFFFFF75C1BA74
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) { }

	// RVA: 0xFFFFFFFF75C1BC80
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: 0xFFFFFFFF723C2710
	public static Object Instantiate(Object original) { }

	// RVA: 0xFFFFFFFF75C1BE8C
	public static Object Instantiate(Object original, Transform parent) { }

	// RVA: 0xFFFFFFFF75C1BED4
	public static Object Instantiate(Object original, Transform parent, Boolean instantiateInWorldSpace) { }

	// RVA: -1
	public static T Instantiate(T original) { }

	// RVA: -1
	public static T Instantiate(T original, Vector3 position, Quaternion rotation) { }

	// RVA: -1
	public static T Instantiate(T original, Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: -1
	public static T Instantiate(T original, Transform parent) { }

	// RVA: -1
	public static T Instantiate(T original, Transform parent, Boolean worldPositionStays) { }

	// RVA: 0xFFFFFFFF723C2850
	public static Void Destroy(Object obj, Single t) { }

	// RVA: 0xFFFFFFFF723C28AC
	public static Void Destroy(Object obj) { }

	// RVA: 0xFFFFFFFF723C2930
	public static Void DestroyImmediate(Object obj, Boolean allowDestroyingAssets) { }

	// RVA: 0xFFFFFFFF723C298C
	public static Void DestroyImmediate(Object obj) { }

	// RVA: 0xFFFFFFFF75C06078
	public static Object[] FindObjectsOfType(Type type) { }

	// RVA: 0xFFFFFFFF723C2A10
	public static Void DontDestroyOnLoad(Object target) { }

	// RVA: 0xFFFFFFFF75C1C058
	public HideFlags get_hideFlags() { }

	// RVA: 0xFFFFFFFF723C239C
	public Void set_hideFlags(HideFlags value) { }

	// RVA: 0xFFFFFFFF75C1C098
	public static Void DestroyObject(Object obj, Single t) { }

	// RVA: 0xFFFFFFFF75C1C104
	public static Void DestroyObject(Object obj) { }

	// RVA: -1
	public static T[] FindObjectsOfType() { }

	// RVA: -1
	public static T FindObjectOfType() { }

	// RVA: 0xFFFFFFFF723C26CC
	private static Void CheckNullArgument(Object arg, String message) { }

	// RVA: 0xFFFFFFFF75C1C164
	public static Object FindObjectOfType(Type type) { }

	// RVA: 0xFFFFFFFF75C1C204
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75C1C2A0
	public static Boolean op_Equality(Object x, Object y) { }

	// RVA: 0xFFFFFFFF75C1C2E4
	public static Boolean op_Inequality(Object x, Object y) { }

	// RVA: 0xFFFFFFFF75C1B93C
	private static Int32 GetOffsetOfInstanceIDInCPlusPlusObject() { }

	// RVA: 0xFFFFFFFF723C27FC
	private static Object Internal_CloneSingle(Object data) { }

	// RVA: 0xFFFFFFFF75C1C000
	private static Object Internal_CloneSingleWithParent(Object data, Transform parent, Boolean worldPositionStays) { }

	// RVA: 0xFFFFFFFF75C1BC00
	private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) { }

	// RVA: 0xFFFFFFFF75C1BDFC
	private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot) { }

	// RVA: 0xFFFFFFFF75C1C260
	private static String ToString(Object obj) { }

	// RVA: 0xFFFFFFFF75C1B9E4
	private static String GetName(Object obj) { }

	// RVA: 0xFFFFFFFF75C1BA24
	private static Void SetName(Object obj, String name) { }

	// RVA: 0xFFFFFFFF723C2A64
	internal static Object FindObjectFromInstanceID(Int32 instanceID) { }

	// RVA: 0xFFFFFFFF723BCE70
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C1C3F0
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C1C330
	private static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot) { }

	// RVA: 0xFFFFFFFF75C1C388
	private static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot) { }

}

// Namespace: UnityEngine
internal sealed class UnitySynchronizationContext
{
	// Fields
	private readonly List<T0> m_AsyncWorkQueue; // 0x18
	private readonly List<T0> m_CurrentFrameWork; // 0x20
	private readonly Int32 m_MainThreadID; // 0x28
	private Int32 m_TrackedCount; // 0x2C

	// Methods

	// RVA: 0xFFFFFFFF75C4531C
	private Void .ctor(Int32 mainThreadID) { }

	// RVA: 0xFFFFFFFF75C453D0
	private Void .ctor(List<T0> queue, Int32 mainThreadID) { }

	// RVA: 0xFFFFFFFF75C45470
	public override Void Send(SendOrPostCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75C457DC
	public override Void OperationStarted() { }

	// RVA: 0xFFFFFFFF75C457E8
	public override Void OperationCompleted() { }

	// RVA: 0xFFFFFFFF75C457F4
	public override Void Post(SendOrPostCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75C45920
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0xFFFFFFFF723CC718
	private Void Exec() { }

	// RVA: 0xFFFFFFFF75C45A5C
	private Boolean HasPendingTasks() { }

	// RVA: 0xFFFFFFFF75C45A94
	private static Void InitializeSynchronizationContext() { }

	// RVA: 0xFFFFFFFF723CC86C
	private static Void ExecuteTasks() { }

	// RVA: 0xFFFFFFFF75C45AE8
	private static Boolean ExecutePendingTasks(Int64 millisecondsTimeout) { }

}

// Namespace: 
private struct WorkRequest
{
	// Fields
	private readonly SendOrPostCallback m_DelagateCallback; // 0x10
	private readonly Object m_DelagateState; // 0x18
	private readonly ManualResetEvent m_WaitHandle; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF7114EC3C
	public Void .ctor(SendOrPostCallback callback, Object state, ManualResetEvent waitHandle) { }

	// RVA: 0xFFFFFFFF7114ECC0
	public Void Invoke() { }

}

// Namespace: UnityEngine
public sealed class WaitForEndOfFrame
{
	// Methods

	// RVA: 0xFFFFFFFF723CDE68
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class WaitForFixedUpdate
{
	// Methods

	// RVA: 0xFFFFFFFF723CDE70
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class WaitForSeconds
{
	// Fields
	internal Single m_Seconds; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF723CDE74
	public Void .ctor(Single seconds) { }

}

// Namespace: UnityEngine
public class WaitForSecondsRealtime
{
	// Fields
	private Single <waitTime>k__BackingField; // 0x10
	private Single m_WaitUntilTime; // 0x14

	// Properties
	public Single waitTime { get; set; }
	public override Boolean keepWaiting { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C4845C
	public Single get_waitTime() { }

	// RVA: 0xFFFFFFFF75C48464
	public Void set_waitTime(Single value) { }

	// RVA: 0xFFFFFFFF723CDE7C
	public override Boolean get_keepWaiting() { }

	// RVA: 0xFFFFFFFF75C4846C
	public Void .ctor(Single time) { }

}

// Namespace: UnityEngine
public sealed class WaitUntil
{
	// Fields
	private Func<T0> m_Predicate; // 0x10

	// Properties
	public override Boolean keepWaiting { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C484A8
	public override Boolean get_keepWaiting() { }

	// RVA: 0xFFFFFFFF75C484D4
	public Void .ctor(Func<T0> predicate) { }

}

// Namespace: UnityEngine
public class YieldInstruction
{
	// Methods

	// RVA: 0xFFFFFFFF723CDE6C
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class SerializePrivateVariables
{}

// Namespace: UnityEngine
public sealed class SerializeField
{
	// Methods

	// RVA: 0xFFFFFFFF75C34970
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class SerializeReference
{
	// Methods

	// RVA: 0xFFFFFFFF75C34978
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class PreferBinarySerialization
{}

// Namespace: UnityEngine
public interface ISerializationCallbackReceiver
{
	// Methods

	// RVA: -1
	public abstract Void OnBeforeSerialize() { }

	// RVA: -1
	public abstract Void OnAfterDeserialize() { }

}

// Namespace: UnityEngine
public sealed class ComputeBuffer
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75BFB5D0
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75BFB6D0
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75BFB618
	private Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75BFB758
	private static IntPtr InitBuffer(Int32 count, Int32 stride, ComputeBufferType type, ComputeBufferMode usage) { }

	// RVA: 0xFFFFFFFF75BFB718
	private static Void DestroyBuffer(ComputeBuffer buf) { }

	// RVA: 0xFFFFFFFF75BFB7C0
	public Void .ctor(Int32 count, Int32 stride, ComputeBufferType type) { }

	// RVA: 0xFFFFFFFF75BFB7C8
	internal Void .ctor(Int32 count, Int32 stride, ComputeBufferType type, ComputeBufferMode usage, Int32 stackDepth) { }

	// RVA: 0xFFFFFFFF75BFB8EC
	public Void SetData(Array data) { }

	// RVA: 0xFFFFFFFF75BFBA70
	private Void InternalSetData(Array data, Int32 managedBufferStartIndex, Int32 computeBufferStartIndex, Int32 count, Int32 elemSize) { }

}

// Namespace: UnityEngine
public sealed class ComputeShader
{
	// Methods

	// RVA: 0xFFFFFFFF75BFBAF0
	public Int32 FindKernel(String name) { }

}

// Namespace: UnityEngine
internal enum DisableBatchingType
{
	// Fields
	public Int32 value__; // 0x10
	public const DisableBatchingType False = 0;
	public const DisableBatchingType True = 1;
	public const DisableBatchingType WhenLODFading = 2;
}

// Namespace: UnityEngine
public sealed class ShaderVariantCollection
{
	// Properties
	public Boolean isWarmedUp { get; }

	// Methods

	// RVA: 0xFFFFFFFF723C9B30
	public Boolean get_isWarmedUp() { }

	// RVA: 0xFFFFFFFF723C9B74
	public Void WarmUp() { }

}

// Namespace: UnityEngine
public sealed class StaticBatchingUtility
{
	// Methods

	// RVA: 0xFFFFFFFF75C3AB3C
	public static Void Combine(GameObject staticBatchRoot) { }

	// RVA: 0xFFFFFFFF75C3AB48
	public static Void Combine(GameObject[] gos, GameObject staticBatchRoot) { }

}

// Namespace: UnityEngine
internal class InternalStaticBatchingUtility
{
	// Methods

	// RVA: 0xFFFFFFFF75C06068
	public static Void CombineRoot(GameObject staticBatchRoot, StaticBatcherGOSorter sorter) { }

	// RVA: 0xFFFFFFFF723BB468
	public static Void Combine(GameObject staticBatchRoot, Boolean combineOnlyStatic, Boolean isEditorPostprocessScene, StaticBatcherGOSorter sorter) { }

	// RVA: 0xFFFFFFFF75C06F60
	public static GameObject[] SortGameObjectsForStaticbatching(GameObject[] gos, StaticBatcherGOSorter sorter) { }

	// RVA: 0xFFFFFFFF75C060B8
	public static Void CombineGameObjects(GameObject[] gos, GameObject staticBatchRoot, Boolean isEditorPostprocessScene, StaticBatcherGOSorter sorter) { }

	// RVA: 0xFFFFFFFF75C0724C
	private static Void MakeBatch(List<T0> meshes, Transform staticBatchRootTransform, Int32 batchIndex) { }

}

// Namespace: 
public class StaticBatcherGOSorter
{
	// Methods

	// RVA: 0xFFFFFFFF75C07DA4
	public virtual Int64 GetMaterialId(Renderer renderer) { }

	// RVA: 0xFFFFFFFF75C07D44
	public Int32 GetLightmapIndex(Renderer renderer) { }

	// RVA: 0xFFFFFFFF75C07BEC
	public static Renderer GetRenderer(GameObject go) { }

	// RVA: 0xFFFFFFFF75C07E08
	public virtual Int64 GetRendererId(Renderer renderer) { }

	// RVA: 0xFFFFFFFF75C071C8
	public Void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public StaticBatcherGOSorter sorter; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C071C4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C07BAC
	internal Int64 <SortGameObjectsForStaticbatching>b__0(GameObject x) { }

	// RVA: 0xFFFFFFFF75C07CF4
	internal Int32 <SortGameObjectsForStaticbatching>b__1(GameObject y) { }

	// RVA: 0xFFFFFFFF75C07D64
	internal Int64 <SortGameObjectsForStaticbatching>b__2(GameObject z) { }

}

// Namespace: 
private sealed class <>c
{
	// Fields
	public static readonly <>c <>9; // 0x0
	public static Func<T0, T1> <>9__5_0; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75C07A90
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C07B08
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C07B0C
	internal Boolean <CombineGameObjects>b__5_0(Material m) { }

}

// Namespace: UnityEngine
internal class MeshSubsetCombineUtility
{}

// Namespace: 
public struct MeshInstance
{
	// Fields
	public Int32 meshInstanceID; // 0x10
	public Int32 rendererInstanceID; // 0x14
	public Int32 additionalVertexStreamsMeshInstanceID; // 0x18
	public Matrix4x4 transform; // 0x1C
	public Vector4 lightmapScaleOffset; // 0x5C
	public Vector4 realtimeLightmapScaleOffset; // 0x6C
}

// Namespace: 
public struct SubMeshInstance
{
	// Fields
	public Int32 meshInstanceID; // 0x10
	public Int32 vertexOffset; // 0x14
	public Int32 gameObjectInstanceID; // 0x18
	public Int32 subMeshIndex; // 0x1C
	public Matrix4x4 transform; // 0x20
}

// Namespace: 
public struct MeshContainer
{
	// Fields
	public GameObject gameObject; // 0x10
	public MeshInstance instance; // 0x18
	public List<T0> subMeshInstances; // 0x88
}

// Namespace: UnityEngine
internal class LowerResBlitTexture
{
	// Methods

	// RVA: 0xFFFFFFFF75C0BE30
	internal Void LowerResBlitTextureDontStripMe() { }

}

// Namespace: UnityEngine
internal class PreloadData
{
	// Methods

	// RVA: 0xFFFFFFFF75C1F588
	internal Void PreloadDataDontStripMe() { }

}

// Namespace: UnityEngine
public enum BatteryStatus
{
	// Fields
	public Int32 value__; // 0x10
	public const BatteryStatus Unknown = 0;
	public const BatteryStatus Charging = 1;
	public const BatteryStatus Discharging = 2;
	public const BatteryStatus NotCharging = 3;
	public const BatteryStatus Full = 4;
}

// Namespace: UnityEngine
public enum OperatingSystemFamily
{
	// Fields
	public Int32 value__; // 0x10
	public const OperatingSystemFamily Other = 0;
	public const OperatingSystemFamily MacOSX = 1;
	public const OperatingSystemFamily Windows = 2;
	public const OperatingSystemFamily Linux = 3;
}

// Namespace: UnityEngine
public enum DeviceType
{
	// Fields
	public Int32 value__; // 0x10
	public const DeviceType Unknown = 0;
	public const DeviceType Handheld = 1;
	public const DeviceType Console = 2;
	public const DeviceType Desktop = 3;
}

// Namespace: UnityEngine
public sealed class SystemInfo
{
	// Properties
	public static Single batteryLevel { get; }
	public static BatteryStatus batteryStatus { get; }
	public static String operatingSystem { get; }
	public static OperatingSystemFamily operatingSystemFamily { get; }
	public static String processorType { get; }
	public static Int32 processorFrequency { get; }
	public static Int32 processorCount { get; }
	public static Int32 systemMemorySize { get; }
	public static String deviceUniqueIdentifier { get; }
	public static String deviceName { get; }
	public static String deviceModel { get; }
	public static Boolean supportsAccelerometer { get; }
	public static Boolean supportsGyroscope { get; }
	public static Boolean supportsLocationService { get; }
	public static Boolean supportsVibration { get; }
	public static Boolean supportsAudio { get; }
	public static DeviceType deviceType { get; }
	public static Int32 graphicsMemorySize { get; }
	public static String graphicsDeviceName { get; }
	public static String graphicsDeviceVendor { get; }
	public static Int32 graphicsDeviceID { get; }
	public static Int32 graphicsDeviceVendorID { get; }
	public static GraphicsDeviceType graphicsDeviceType { get; }
	public static Boolean graphicsUVStartsAtTop { get; }
	public static String graphicsDeviceVersion { get; }
	public static Int32 graphicsShaderLevel { get; }
	public static Boolean graphicsMultiThreaded { get; }
	public static RenderingThreadingMode renderingThreadingMode { get; }
	public static Boolean hasHiddenSurfaceRemovalOnGPU { get; }
	public static Boolean hasDynamicUniformArrayIndexingInFragmentShaders { get; }
	public static Boolean supportsShadows { get; }
	public static Boolean supportsRawShadowDepthSampling { get; }
	public static Boolean supportsRenderTextures { get; }
	public static Boolean supportsMotionVectors { get; }
	public static Boolean supportsImageEffects { get; }
	public static Boolean supports3DTextures { get; }
	public static Boolean supports2DArrayTextures { get; }
	public static Boolean supports3DRenderTextures { get; }
	public static Boolean supportsCubemapArrayTextures { get; }
	public static CopyTextureSupport copyTextureSupport { get; }
	public static Boolean supportsComputeShaders { get; }
	public static Boolean supportsGeometryShaders { get; }
	public static Boolean supportsTessellationShaders { get; }
	public static Boolean supportsInstancing { get; }
	public static Boolean supportsHardwareQuadTopology { get; }
	public static Boolean supports32bitsIndexBuffer { get; }
	public static Boolean supportsSparseTextures { get; }
	public static Int32 supportedRenderTargetCount { get; }
	public static Boolean supportsSeparatedRenderTargetsBlend { get; }
	public static Int32 supportedRandomWriteTargetCount { get; }
	public static Int32 supportsMultisampledTextures { get; }
	public static Boolean supportsMultisampleAutoResolve { get; }
	public static Int32 supportsTextureWrapMirrorOnce { get; }
	public static Boolean usesReversedZBuffer { get; }
	public static NPOTSupport npotSupport { get; }
	public static Int32 maxTextureSize { get; }
	public static Int32 maxCubemapSize { get; }
	public static Int32 maxComputeBufferInputsVertex { get; }
	public static Int32 maxComputeBufferInputsFragment { get; }
	public static Int32 maxComputeBufferInputsGeometry { get; }
	public static Int32 maxComputeBufferInputsDomain { get; }
	public static Int32 maxComputeBufferInputsHull { get; }
	public static Int32 maxComputeBufferInputsCompute { get; }
	public static Int32 maxComputeWorkGroupSize { get; }
	public static Int32 maxComputeWorkGroupSizeX { get; }
	public static Int32 maxComputeWorkGroupSizeY { get; }
	public static Int32 maxComputeWorkGroupSizeZ { get; }
	public static Boolean supportsAsyncCompute { get; }
	public static Boolean supportsGraphicsFence { get; }
	public static Boolean supportsAsyncGPUReadback { get; }
	public static Boolean supportsRayTracing { get; }
	public static Boolean supportsSetConstantBuffer { get; }
	public static Boolean hasMipMaxLevel { get; }
	public static Boolean supportsMipStreaming { get; }
	public static Boolean usesLoadStoreActions { get; }
	public static Boolean minConstantBufferOffsetAlignment { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C3AC14
	public static Single get_batteryLevel() { }

	// RVA: 0xFFFFFFFF75C3AC7C
	public static BatteryStatus get_batteryStatus() { }

	// RVA: 0xFFFFFFFF723CA3E8
	public static String get_operatingSystem() { }

	// RVA: 0xFFFFFFFF75C3AD18
	public static OperatingSystemFamily get_operatingSystemFamily() { }

	// RVA: 0xFFFFFFFF75C3AD80
	public static String get_processorType() { }

	// RVA: 0xFFFFFFFF75C3ADEC
	public static Int32 get_processorFrequency() { }

	// RVA: 0xFFFFFFFF75C3AE54
	public static Int32 get_processorCount() { }

	// RVA: 0xFFFFFFFF723CA420
	public static Int32 get_systemMemorySize() { }

	// RVA: 0xFFFFFFFF75C3AEF4
	public static String get_deviceUniqueIdentifier() { }

	// RVA: 0xFFFFFFFF75C3AF5C
	public static String get_deviceName() { }

	// RVA: 0xFFFFFFFF723CA458
	public static String get_deviceModel() { }

	// RVA: 0xFFFFFFFF75C3AFFC
	public static Boolean get_supportsAccelerometer() { }

	// RVA: 0xFFFFFFFF75C3B064
	public static Boolean get_supportsGyroscope() { }

	// RVA: 0xFFFFFFFF75C3B0D0
	public static Boolean get_supportsLocationService() { }

	// RVA: 0xFFFFFFFF75C3B138
	public static Boolean get_supportsVibration() { }

	// RVA: 0xFFFFFFFF75C3B1A0
	public static Boolean get_supportsAudio() { }

	// RVA: 0xFFFFFFFF75C3B208
	public static DeviceType get_deviceType() { }

	// RVA: 0xFFFFFFFF75C3B270
	public static Int32 get_graphicsMemorySize() { }

	// RVA: 0xFFFFFFFF723CA490
	public static String get_graphicsDeviceName() { }

	// RVA: 0xFFFFFFFF75C3B30C
	public static String get_graphicsDeviceVendor() { }

	// RVA: 0xFFFFFFFF75C3B374
	public static Int32 get_graphicsDeviceID() { }

	// RVA: 0xFFFFFFFF75C3B3DC
	public static Int32 get_graphicsDeviceVendorID() { }

	// RVA: 0xFFFFFFFF723CA4C8
	public static GraphicsDeviceType get_graphicsDeviceType() { }

	// RVA: 0xFFFFFFFF75C3B478
	public static Boolean get_graphicsUVStartsAtTop() { }

	// RVA: 0xFFFFFFFF75C3B4E0
	public static String get_graphicsDeviceVersion() { }

	// RVA: 0xFFFFFFFF75C3B54C
	public static Int32 get_graphicsShaderLevel() { }

	// RVA: 0xFFFFFFFF75C3B5B4
	public static Boolean get_graphicsMultiThreaded() { }

	// RVA: 0xFFFFFFFF75C3B61C
	public static RenderingThreadingMode get_renderingThreadingMode() { }

	// RVA: 0xFFFFFFFF75C3B684
	public static Boolean get_hasHiddenSurfaceRemovalOnGPU() { }

	// RVA: 0xFFFFFFFF75C3B6EC
	public static Boolean get_hasDynamicUniformArrayIndexingInFragmentShaders() { }

	// RVA: 0xFFFFFFFF75C3B754
	public static Boolean get_supportsShadows() { }

	// RVA: 0xFFFFFFFF75C3B7BC
	public static Boolean get_supportsRawShadowDepthSampling() { }

	// RVA: 0xFFFFFFFF75C3B824
	public static Boolean get_supportsRenderTextures() { }

	// RVA: 0xFFFFFFFF75C3B82C
	public static Boolean get_supportsMotionVectors() { }

	// RVA: 0xFFFFFFFF75C3B894
	public static Boolean get_supportsImageEffects() { }

	// RVA: 0xFFFFFFFF75C3B89C
	public static Boolean get_supports3DTextures() { }

	// RVA: 0xFFFFFFFF75C3B904
	public static Boolean get_supports2DArrayTextures() { }

	// RVA: 0xFFFFFFFF75C3B96C
	public static Boolean get_supports3DRenderTextures() { }

	// RVA: 0xFFFFFFFF75C3B9D4
	public static Boolean get_supportsCubemapArrayTextures() { }

	// RVA: 0xFFFFFFFF75C3BA3C
	public static CopyTextureSupport get_copyTextureSupport() { }

	// RVA: 0xFFFFFFFF75C3BAA4
	public static Boolean get_supportsComputeShaders() { }

	// RVA: 0xFFFFFFFF75C3BB10
	public static Boolean get_supportsGeometryShaders() { }

	// RVA: 0xFFFFFFFF75C3BB78
	public static Boolean get_supportsTessellationShaders() { }

	// RVA: 0xFFFFFFFF75C3BBE0
	public static Boolean get_supportsInstancing() { }

	// RVA: 0xFFFFFFFF75C3BC48
	public static Boolean get_supportsHardwareQuadTopology() { }

	// RVA: 0xFFFFFFFF75C3BCB0
	public static Boolean get_supports32bitsIndexBuffer() { }

	// RVA: 0xFFFFFFFF75C3BD18
	public static Boolean get_supportsSparseTextures() { }

	// RVA: 0xFFFFFFFF75C3BD80
	public static Int32 get_supportedRenderTargetCount() { }

	// RVA: 0xFFFFFFFF75C3BDE8
	public static Boolean get_supportsSeparatedRenderTargetsBlend() { }

	// RVA: 0xFFFFFFFF75C3BE50
	public static Int32 get_supportedRandomWriteTargetCount() { }

	// RVA: 0xFFFFFFFF75C3BEB8
	public static Int32 get_supportsMultisampledTextures() { }

	// RVA: 0xFFFFFFFF75C3BF20
	public static Boolean get_supportsMultisampleAutoResolve() { }

	// RVA: 0xFFFFFFFF75C3BF88
	public static Int32 get_supportsTextureWrapMirrorOnce() { }

	// RVA: 0xFFFFFFFF75C3BFF0
	public static Boolean get_usesReversedZBuffer() { }

	// RVA: 0xFFFFFFFF75C3C058
	private static Boolean IsValidEnumValue(Enum value) { }

	// RVA: 0xFFFFFFFF75C3C0C0
	public static Boolean SupportsRenderTextureFormat(RenderTextureFormat format) { }

	// RVA: 0xFFFFFFFF75C3C1E8
	public static Boolean SupportsBlendingOnRenderTextureFormat(RenderTextureFormat format) { }

	// RVA: 0xFFFFFFFF75C3C310
	public static Boolean SupportsTextureFormat(TextureFormat format) { }

	// RVA: 0xFFFFFFFF75C3C3E8
	public static Boolean SupportsVertexAttributeFormat(VertexAttributeFormat format, Int32 dimension) { }

	// RVA: 0xFFFFFFFF75C3C55C
	public static NPOTSupport get_npotSupport() { }

	// RVA: 0xFFFFFFFF75C3C5C4
	public static Int32 get_maxTextureSize() { }

	// RVA: 0xFFFFFFFF75C3C62C
	public static Int32 get_maxCubemapSize() { }

	// RVA: 0xFFFFFFFF75C3C694
	public static Int32 get_maxComputeBufferInputsVertex() { }

	// RVA: 0xFFFFFFFF75C3C6FC
	public static Int32 get_maxComputeBufferInputsFragment() { }

	// RVA: 0xFFFFFFFF75C3C764
	public static Int32 get_maxComputeBufferInputsGeometry() { }

	// RVA: 0xFFFFFFFF75C3C7CC
	public static Int32 get_maxComputeBufferInputsDomain() { }

	// RVA: 0xFFFFFFFF75C3C834
	public static Int32 get_maxComputeBufferInputsHull() { }

	// RVA: 0xFFFFFFFF75C3C89C
	public static Int32 get_maxComputeBufferInputsCompute() { }

	// RVA: 0xFFFFFFFF75C3C904
	public static Int32 get_maxComputeWorkGroupSize() { }

	// RVA: 0xFFFFFFFF75C3C96C
	public static Int32 get_maxComputeWorkGroupSizeX() { }

	// RVA: 0xFFFFFFFF75C3C9D4
	public static Int32 get_maxComputeWorkGroupSizeY() { }

	// RVA: 0xFFFFFFFF75C3CA3C
	public static Int32 get_maxComputeWorkGroupSizeZ() { }

	// RVA: 0xFFFFFFFF75C3CAA4
	public static Boolean get_supportsAsyncCompute() { }

	// RVA: 0xFFFFFFFF75C3CB0C
	public static Boolean get_supportsGraphicsFence() { }

	// RVA: 0xFFFFFFFF75C3CB74
	public static Boolean get_supportsAsyncGPUReadback() { }

	// RVA: 0xFFFFFFFF75C3CBDC
	public static Boolean get_supportsRayTracing() { }

	// RVA: 0xFFFFFFFF75C3CC44
	public static Boolean get_supportsSetConstantBuffer() { }

	// RVA: 0xFFFFFFFF75C3CCAC
	public static Boolean get_hasMipMaxLevel() { }

	// RVA: 0xFFFFFFFF75C3CD14
	public static Boolean get_supportsMipStreaming() { }

	// RVA: 0xFFFFFFFF75C3CD7C
	public static Boolean get_usesLoadStoreActions() { }

	// RVA: 0xFFFFFFFF75C3AC48
	private static Single GetBatteryLevel() { }

	// RVA: 0xFFFFFFFF75C3ACB0
	private static BatteryStatus GetBatteryStatus() { }

	// RVA: 0xFFFFFFFF75C3ACE4
	private static String GetOperatingSystem() { }

	// RVA: 0xFFFFFFFF75C3AD4C
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	// RVA: 0xFFFFFFFF75C3ADB8
	private static String GetProcessorType() { }

	// RVA: 0xFFFFFFFF75C3AE20
	private static Int32 GetProcessorFrequencyMHz() { }

	// RVA: 0xFFFFFFFF75C3AE8C
	private static Int32 GetProcessorCount() { }

	// RVA: 0xFFFFFFFF75C3AEC0
	private static Int32 GetPhysicalMemoryMB() { }

	// RVA: 0xFFFFFFFF75C3AF28
	private static String GetDeviceUniqueIdentifier() { }

	// RVA: 0xFFFFFFFF75C3AF94
	private static String GetDeviceName() { }

	// RVA: 0xFFFFFFFF75C3AFC8
	private static String GetDeviceModel() { }

	// RVA: 0xFFFFFFFF75C3B030
	private static Boolean SupportsAccelerometer() { }

	// RVA: 0xFFFFFFFF75C3B09C
	private static Boolean IsGyroAvailable() { }

	// RVA: 0xFFFFFFFF75C3B104
	private static Boolean SupportsLocationService() { }

	// RVA: 0xFFFFFFFF75C3B16C
	private static Boolean SupportsVibration() { }

	// RVA: 0xFFFFFFFF75C3B1D4
	private static Boolean SupportsAudio() { }

	// RVA: 0xFFFFFFFF75C3B23C
	private static DeviceType GetDeviceType() { }

	// RVA: 0xFFFFFFFF75C3B2A4
	private static Int32 GetGraphicsMemorySize() { }

	// RVA: 0xFFFFFFFF75C3B2D8
	private static String GetGraphicsDeviceName() { }

	// RVA: 0xFFFFFFFF75C3B340
	private static String GetGraphicsDeviceVendor() { }

	// RVA: 0xFFFFFFFF75C3B3A8
	private static Int32 GetGraphicsDeviceID() { }

	// RVA: 0xFFFFFFFF75C3B410
	private static Int32 GetGraphicsDeviceVendorID() { }

	// RVA: 0xFFFFFFFF75C3B444
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	// RVA: 0xFFFFFFFF75C3B4AC
	private static Boolean GetGraphicsUVStartsAtTop() { }

	// RVA: 0xFFFFFFFF75C3B518
	private static String GetGraphicsDeviceVersion() { }

	// RVA: 0xFFFFFFFF75C3B580
	private static Int32 GetGraphicsShaderLevel() { }

	// RVA: 0xFFFFFFFF75C3B5E8
	private static Boolean GetGraphicsMultiThreaded() { }

	// RVA: 0xFFFFFFFF75C3B650
	private static RenderingThreadingMode GetRenderingThreadingMode() { }

	// RVA: 0xFFFFFFFF75C3B6B8
	private static Boolean HasHiddenSurfaceRemovalOnGPU() { }

	// RVA: 0xFFFFFFFF75C3B720
	private static Boolean HasDynamicUniformArrayIndexingInFragmentShaders() { }

	// RVA: 0xFFFFFFFF75C3B788
	private static Boolean SupportsShadows() { }

	// RVA: 0xFFFFFFFF75C3B7F0
	private static Boolean SupportsRawShadowDepthSampling() { }

	// RVA: 0xFFFFFFFF75C3B860
	private static Boolean SupportsMotionVectors() { }

	// RVA: 0xFFFFFFFF75C3B8D0
	private static Boolean Supports3DTextures() { }

	// RVA: 0xFFFFFFFF75C3B938
	private static Boolean Supports2DArrayTextures() { }

	// RVA: 0xFFFFFFFF75C3B9A0
	private static Boolean Supports3DRenderTextures() { }

	// RVA: 0xFFFFFFFF75C3BA08
	private static Boolean SupportsCubemapArrayTextures() { }

	// RVA: 0xFFFFFFFF75C3BA70
	private static CopyTextureSupport GetCopyTextureSupport() { }

	// RVA: 0xFFFFFFFF75C3BADC
	private static Boolean SupportsComputeShaders() { }

	// RVA: 0xFFFFFFFF75C3BB44
	private static Boolean SupportsGeometryShaders() { }

	// RVA: 0xFFFFFFFF75C3BBAC
	private static Boolean SupportsTessellationShaders() { }

	// RVA: 0xFFFFFFFF75C3BC14
	private static Boolean SupportsInstancing() { }

	// RVA: 0xFFFFFFFF75C3BC7C
	private static Boolean SupportsHardwareQuadTopology() { }

	// RVA: 0xFFFFFFFF75C3BCE4
	private static Boolean Supports32bitsIndexBuffer() { }

	// RVA: 0xFFFFFFFF75C3BD4C
	private static Boolean SupportsSparseTextures() { }

	// RVA: 0xFFFFFFFF75C3BDB4
	private static Int32 SupportedRenderTargetCount() { }

	// RVA: 0xFFFFFFFF75C3BE1C
	private static Boolean SupportsSeparatedRenderTargetsBlend() { }

	// RVA: 0xFFFFFFFF75C3BE84
	private static Int32 SupportedRandomWriteTargetCount() { }

	// RVA: 0xFFFFFFFF75C3C6C8
	private static Int32 MaxComputeBufferInputsVertex() { }

	// RVA: 0xFFFFFFFF75C3C730
	private static Int32 MaxComputeBufferInputsFragment() { }

	// RVA: 0xFFFFFFFF75C3C798
	private static Int32 MaxComputeBufferInputsGeometry() { }

	// RVA: 0xFFFFFFFF75C3C800
	private static Int32 MaxComputeBufferInputsDomain() { }

	// RVA: 0xFFFFFFFF75C3C868
	private static Int32 MaxComputeBufferInputsHull() { }

	// RVA: 0xFFFFFFFF75C3C8D0
	private static Int32 MaxComputeBufferInputsCompute() { }

	// RVA: 0xFFFFFFFF75C3BEEC
	private static Int32 SupportsMultisampledTextures() { }

	// RVA: 0xFFFFFFFF75C3BF54
	private static Boolean SupportsMultisampleAutoResolve() { }

	// RVA: 0xFFFFFFFF75C3BFBC
	private static Int32 SupportsTextureWrapMirrorOnce() { }

	// RVA: 0xFFFFFFFF75C3C024
	private static Boolean UsesReversedZBuffer() { }

	// RVA: 0xFFFFFFFF75C3C1A8
	private static Boolean HasRenderTextureNative(RenderTextureFormat format) { }

	// RVA: 0xFFFFFFFF75C3C2D0
	private static Boolean SupportsBlendingOnRenderTextureFormatNative(RenderTextureFormat format) { }

	// RVA: 0xFFFFFFFF75C3C3A8
	private static Boolean SupportsTextureFormatNative(TextureFormat format) { }

	// RVA: 0xFFFFFFFF75C3C50C
	private static Boolean SupportsVertexAttributeFormatNative(VertexAttributeFormat format, Int32 dimension) { }

	// RVA: 0xFFFFFFFF75C3C590
	private static NPOTSupport GetNPOTSupport() { }

	// RVA: 0xFFFFFFFF75C3C5F8
	private static Int32 GetMaxTextureSize() { }

	// RVA: 0xFFFFFFFF75C3C660
	private static Int32 GetMaxCubemapSize() { }

	// RVA: 0xFFFFFFFF75C3C938
	private static Int32 GetMaxComputeWorkGroupSize() { }

	// RVA: 0xFFFFFFFF75C3C9A0
	private static Int32 GetMaxComputeWorkGroupSizeX() { }

	// RVA: 0xFFFFFFFF75C3CA08
	private static Int32 GetMaxComputeWorkGroupSizeY() { }

	// RVA: 0xFFFFFFFF75C3CA70
	private static Int32 GetMaxComputeWorkGroupSizeZ() { }

	// RVA: 0xFFFFFFFF75C3CAD8
	private static Boolean SupportsAsyncCompute() { }

	// RVA: 0xFFFFFFFF75C3CB40
	private static Boolean SupportsGPUFence() { }

	// RVA: 0xFFFFFFFF75C3CBA8
	private static Boolean SupportsAsyncGPUReadback() { }

	// RVA: 0xFFFFFFFF75C3CC10
	private static Boolean SupportsRayTracing() { }

	// RVA: 0xFFFFFFFF75C3CC78
	private static Boolean SupportsSetConstantBuffer() { }

	// RVA: 0xFFFFFFFF75C3CCE0
	private static Boolean HasMipMaxLevel() { }

	// RVA: 0xFFFFFFFF75C3CD48
	private static Boolean SupportsMipStreaming() { }

	// RVA: 0xFFFFFFFF75C3CDE4
	public static Boolean IsFormatSupported(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0xFFFFFFFF723CA504
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0xFFFFFFFF723CA558
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

	// RVA: 0xFFFFFFFF75C3CDB0
	private static Boolean UsesLoadStoreActions() { }

	// RVA: 0xFFFFFFFF75C3CE38
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C3CE3C
	public static Boolean get_minConstantBufferOffsetAlignment() { }

}

// Namespace: UnityEngine
internal class SystemClock
{
	// Fields
	private static readonly DateTime s_Epoch; // 0x0

	// Properties
	public static DateTime now { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C3AB58
	public static DateTime get_now() { }

	// RVA: 0xFFFFFFFF75C3AB88
	private static Void .cctor() { }

}

// Namespace: UnityEngine
public class Time
{
	// Properties
	public static Single time { get; }
	public static Single timeSinceLevelLoad { get; }
	public static Single deltaTime { get; }
	public static Single fixedTime { get; }
	public static Single unscaledTime { get; }
	public static Single fixedUnscaledTime { get; }
	public static Single unscaledDeltaTime { get; }
	public static Single fixedUnscaledDeltaTime { get; }
	public static Single fixedDeltaTime { get; set; }
	public static Single maximumDeltaTime { get; set; }
	public static Single smoothDeltaTime { get; }
	public static Single maximumParticleDeltaTime { get; set; }
	public static Single timeScale { get; set; }
	public static Int32 frameCount { get; }
	public static Int32 renderedFrameCount { get; }
	public static Single realtimeSinceStartup { get; }
	public static Single captureDeltaTime { get; set; }
	public static Int32 captureFramerate { get; set; }
	public static Boolean inFixedTimeStep { get; }

	// Methods

	// RVA: 0xFFFFFFFF723CA7AC
	public static Single get_time() { }

	// RVA: 0xFFFFFFFF75C40A98
	public static Single get_timeSinceLevelLoad() { }

	// RVA: 0xFFFFFFFF723CA7E8
	public static Single get_deltaTime() { }

	// RVA: 0xFFFFFFFF75C40ACC
	public static Single get_fixedTime() { }

	// RVA: 0xFFFFFFFF723CA824
	public static Single get_unscaledTime() { }

	// RVA: 0xFFFFFFFF75C40B00
	public static Single get_fixedUnscaledTime() { }

	// RVA: 0xFFFFFFFF723CA860
	public static Single get_unscaledDeltaTime() { }

	// RVA: 0xFFFFFFFF75C40B34
	public static Single get_fixedUnscaledDeltaTime() { }

	// RVA: 0xFFFFFFFF723CA89C
	public static Single get_fixedDeltaTime() { }

	// RVA: 0xFFFFFFFF75C40B68
	public static Void set_fixedDeltaTime(Single value) { }

	// RVA: 0xFFFFFFFF75C40BB0
	public static Single get_maximumDeltaTime() { }

	// RVA: 0xFFFFFFFF75C40BE4
	public static Void set_maximumDeltaTime(Single value) { }

	// RVA: 0xFFFFFFFF75C40C28
	public static Single get_smoothDeltaTime() { }

	// RVA: 0xFFFFFFFF75C40C5C
	public static Single get_maximumParticleDeltaTime() { }

	// RVA: 0xFFFFFFFF75C40C90
	public static Void set_maximumParticleDeltaTime(Single value) { }

	// RVA: 0xFFFFFFFF723CA8D8
	public static Single get_timeScale() { }

	// RVA: 0xFFFFFFFF75C40CD4
	public static Void set_timeScale(Single value) { }

	// RVA: 0xFFFFFFFF723CA914
	public static Int32 get_frameCount() { }

	// RVA: 0xFFFFFFFF75C40D1C
	public static Int32 get_renderedFrameCount() { }

	// RVA: 0xFFFFFFFF723CA950
	public static Single get_realtimeSinceStartup() { }

	// RVA: 0xFFFFFFFF75C40D50
	public static Single get_captureDeltaTime() { }

	// RVA: 0xFFFFFFFF75C40D84
	public static Void set_captureDeltaTime(Single value) { }

	// RVA: 0xFFFFFFFF75C40DC8
	public static Int32 get_captureFramerate() { }

	// RVA: 0xFFFFFFFF75C40EFC
	public static Void set_captureFramerate(Int32 value) { }

	// RVA: 0xFFFFFFFF75C40F54
	public static Boolean get_inFixedTimeStep() { }

	// RVA: 0xFFFFFFFF75C40F88
	public Void .ctor() { }

}

// Namespace: UnityEngine
internal struct TouchScreenKeyboard_InternalConstructorHelperArguments
{
	// Fields
	public UInt32 keyboardType; // 0x10
	public UInt32 autocorrection; // 0x14
	public UInt32 multiline; // 0x18
	public UInt32 secure; // 0x1C
	public UInt32 alert; // 0x20
	public Int32 characterLimit; // 0x24
}

// Namespace: UnityEngine
public class TouchScreenKeyboard
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private static Boolean <disableInPlaceEditing>k__BackingField; // 0x0

	// Properties
	public static Boolean isSupported { get; }
	internal static Boolean disableInPlaceEditing { get; }
	public static Boolean isInPlaceEditingAllowed { get; }
	internal static Boolean isRequiredToForceOpen { get; }
	public String text { get; set; }
	public static Boolean hideInput { set; }
	public Boolean active { get; set; }
	public Boolean done { get; }
	public Boolean wasCanceled { get; }
	public Status status { get; }
	public Int32 characterLimit { set; }
	public Boolean canGetSelection { get; }
	public Boolean canSetSelection { get; }
	public RangeInt selection { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C40FD0
	private static Void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF75C41010
	private Void Destroy() { }

	// RVA: 0xFFFFFFFF75C4109C
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75C41104
	public Void .ctor(String text, TouchScreenKeyboardType keyboardType, Boolean autocorrection, Boolean multiline, Boolean secure, Boolean alert, String textPlaceholder, Int32 characterLimit) { }

	// RVA: 0xFFFFFFFF75C41254
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, String text, String textPlaceholder) { }

	// RVA: 0xFFFFFFFF75C412AC
	public static Boolean get_isSupported() { }

	// RVA: 0xFFFFFFFF75C41310
	internal static Boolean get_disableInPlaceEditing() { }

	// RVA: 0xFFFFFFFF75C41368
	public static Boolean get_isInPlaceEditingAllowed() { }

	// RVA: 0xFFFFFFFF75C413B8
	internal static Boolean get_isRequiredToForceOpen() { }

	// RVA: 0xFFFFFFFF75C413EC
	private static Boolean IsRequiredToForceOpen() { }

	// RVA: 0xFFFFFFFF75C41420
	public static TouchScreenKeyboard Open(String text, TouchScreenKeyboardType keyboardType, Boolean autocorrection, Boolean multiline, Boolean secure, Boolean alert, String textPlaceholder, Int32 characterLimit) { }

	// RVA: 0xFFFFFFFF75C414E8
	public static TouchScreenKeyboard Open(String text, TouchScreenKeyboardType keyboardType, Boolean autocorrection, Boolean multiline, Boolean secure, Boolean alert, String textPlaceholder) { }

	// RVA: 0xFFFFFFFF75C41508
	public static TouchScreenKeyboard Open(String text, TouchScreenKeyboardType keyboardType, Boolean autocorrection, Boolean multiline, Boolean secure) { }

	// RVA: 0xFFFFFFFF75C41534
	public String get_text() { }

	// RVA: 0xFFFFFFFF75C41578
	public Void set_text(String value) { }

	// RVA: 0xFFFFFFFF75C415C8
	public static Void set_hideInput(Boolean value) { }

	// RVA: 0xFFFFFFFF75C41608
	public Boolean get_active() { }

	// RVA: 0xFFFFFFFF75C4164C
	public Void set_active(Boolean value) { }

	// RVA: 0xFFFFFFFF75C4169C
	private static Boolean GetDone(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF75C416DC
	public Boolean get_done() { }

	// RVA: 0xFFFFFFFF75C41720
	private static Boolean GetWasCanceled(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF75C41760
	public Boolean get_wasCanceled() { }

	// RVA: 0xFFFFFFFF75C417A0
	public Status get_status() { }

	// RVA: 0xFFFFFFFF75C417E0
	public Void set_characterLimit(Int32 value) { }

	// RVA: 0xFFFFFFFF75C41830
	public Boolean get_canGetSelection() { }

	// RVA: 0xFFFFFFFF75C41870
	public Boolean get_canSetSelection() { }

	// RVA: 0xFFFFFFFF75C418B0
	public RangeInt get_selection() { }

	// RVA: 0xFFFFFFFF75C41958
	public Void set_selection(RangeInt value) { }

	// RVA: 0xFFFFFFFF75C41908
	private static Void GetSelection(out Int32 start, out Int32 length) { }

	// RVA: 0xFFFFFFFF75C41A64
	private static Void SetSelection(Int32 start, Int32 length) { }

}

// Namespace: 
public enum Status
{
	// Fields
	public Int32 value__; // 0x10
	public const Status Visible = 0;
	public const Status Done = 1;
	public const Status Canceled = 2;
	public const Status LostFocus = 3;
}

// Namespace: UnityEngine
public enum TouchScreenKeyboardType
{
	// Fields
	public Int32 value__; // 0x10
	public const TouchScreenKeyboardType Default = 0;
	public const TouchScreenKeyboardType ASCIICapable = 1;
	public const TouchScreenKeyboardType NumbersAndPunctuation = 2;
	public const TouchScreenKeyboardType URL = 3;
	public const TouchScreenKeyboardType NumberPad = 4;
	public const TouchScreenKeyboardType PhonePad = 5;
	public const TouchScreenKeyboardType NamePhonePad = 6;
	public const TouchScreenKeyboardType EmailAddress = 7;
	public const TouchScreenKeyboardType NintendoNetworkAccount = 8;
	public const TouchScreenKeyboardType Social = 9;
	public const TouchScreenKeyboardType Search = 10;
	public const TouchScreenKeyboardType DecimalPad = 11;
}

// Namespace: UnityEngine
public enum DrivenTransformProperties
{
	// Fields
	public Int32 value__; // 0x10
	public const DrivenTransformProperties None = 0;
	public const DrivenTransformProperties All = 4294967295;
	public const DrivenTransformProperties AnchoredPositionX = 2;
	public const DrivenTransformProperties AnchoredPositionY = 4;
	public const DrivenTransformProperties AnchoredPositionZ = 8;
	public const DrivenTransformProperties Rotation = 16;
	public const DrivenTransformProperties ScaleX = 32;
	public const DrivenTransformProperties ScaleY = 64;
	public const DrivenTransformProperties ScaleZ = 128;
	public const DrivenTransformProperties AnchorMinX = 256;
	public const DrivenTransformProperties AnchorMinY = 512;
	public const DrivenTransformProperties AnchorMaxX = 1024;
	public const DrivenTransformProperties AnchorMaxY = 2048;
	public const DrivenTransformProperties SizeDeltaX = 4096;
	public const DrivenTransformProperties SizeDeltaY = 8192;
	public const DrivenTransformProperties PivotX = 16384;
	public const DrivenTransformProperties PivotY = 32768;
	public const DrivenTransformProperties AnchoredPosition = 6;
	public const DrivenTransformProperties AnchoredPosition3D = 14;
	public const DrivenTransformProperties Scale = 224;
	public const DrivenTransformProperties AnchorMin = 768;
	public const DrivenTransformProperties AnchorMax = 3072;
	public const DrivenTransformProperties Anchors = 3840;
	public const DrivenTransformProperties SizeDelta = 12288;
	public const DrivenTransformProperties Pivot = 49152;
}

// Namespace: UnityEngine
public struct DrivenRectTransformTracker
{
	// Methods

	// RVA: 0xFFFFFFFF7114B7E0
	public Void Add(Object driver, RectTransform rectTransform, DrivenTransformProperties drivenProperties) { }

	// RVA: 0xFFFFFFFF7114B7E4
	public Void Clear() { }

}

// Namespace: UnityEngine
public sealed class RectTransform
{
	// Fields
	private static ReapplyDrivenProperties reapplyDrivenProperties; // 0x0

	// Properties
	public Rect rect { get; }
	public Vector2 anchorMin { get; set; }
	public Vector2 anchorMax { get; set; }
	public Vector2 anchoredPosition { get; set; }
	public Vector2 sizeDelta { get; set; }
	public Vector2 pivot { get; set; }
	public Vector3 anchoredPosition3D { get; set; }
	public Vector2 offsetMin { get; set; }
	public Vector2 offsetMax { get; set; }
	internal Object drivenByObject { get; set; }
	internal DrivenTransformProperties drivenProperties { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C22B7C
	public static Void add_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	// RVA: 0xFFFFFFFF75C22C50
	public static Void remove_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	// RVA: 0xFFFFFFFF75C22D24
	public Rect get_rect() { }

	// RVA: 0xFFFFFFFF75C22DD0
	public Vector2 get_anchorMin() { }

	// RVA: 0xFFFFFFFF75C22E78
	public Void set_anchorMin(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C22F1C
	public Vector2 get_anchorMax() { }

	// RVA: 0xFFFFFFFF75C22FC4
	public Void set_anchorMax(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C23068
	public Vector2 get_anchoredPosition() { }

	// RVA: 0xFFFFFFFF75C23110
	public Void set_anchoredPosition(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C231B4
	public Vector2 get_sizeDelta() { }

	// RVA: 0xFFFFFFFF75C2325C
	public Void set_sizeDelta(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C23300
	public Vector2 get_pivot() { }

	// RVA: 0xFFFFFFFF75C233A8
	public Void set_pivot(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C2344C
	public Vector3 get_anchoredPosition3D() { }

	// RVA: 0xFFFFFFFF75C234C0
	public Void set_anchoredPosition3D(Vector3 value) { }

	// RVA: 0xFFFFFFFF75C2353C
	public Vector2 get_offsetMin() { }

	// RVA: 0xFFFFFFFF75C23660
	public Void set_offsetMin(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C2390C
	public Vector2 get_offsetMax() { }

	// RVA: 0xFFFFFFFF75C23A50
	public Void set_offsetMax(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C23CF4
	internal Object get_drivenByObject() { }

	// RVA: 0xFFFFFFFF75C23D34
	internal Void set_drivenByObject(Object value) { }

	// RVA: 0xFFFFFFFF75C23D84
	internal DrivenTransformProperties get_drivenProperties() { }

	// RVA: 0xFFFFFFFF75C23DC4
	internal Void set_drivenProperties(DrivenTransformProperties value) { }

	// RVA: 0xFFFFFFFF75C23E14
	public Void ForceUpdateRectTransforms() { }

	// RVA: 0xFFFFFFFF75C23E54
	public Void GetLocalCorners(Vector3[] fourCornersArray) { }

	// RVA: 0xFFFFFFFF75C23F40
	public Void GetWorldCorners(Vector3[] fourCornersArray) { }

	// RVA: 0xFFFFFFFF75C240DC
	public Void SetInsetAndSizeFromParentEdge(Edge edge, Single inset, Single size) { }

	// RVA: 0xFFFFFFFF75C243FC
	public Void SetSizeWithCurrentAnchors(Axis axis, Single size) { }

	// RVA: 0xFFFFFFFF75C245E8
	internal static Void SendReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0xFFFFFFFF75C24998
	internal Rect GetRectInParentSpace() { }

	// RVA: 0xFFFFFFFF75C2457C
	private Vector2 GetParentSize() { }

	// RVA: 0xFFFFFFFF75C24BA0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C22D80
	private Void get_rect_Injected(out Rect ret) { }

	// RVA: 0xFFFFFFFF75C22E28
	private Void get_anchorMin_Injected(out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C22ECC
	private Void set_anchorMin_Injected(ref Vector2 value) { }

	// RVA: 0xFFFFFFFF75C22F74
	private Void get_anchorMax_Injected(out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C23018
	private Void set_anchorMax_Injected(ref Vector2 value) { }

	// RVA: 0xFFFFFFFF75C230C0
	private Void get_anchoredPosition_Injected(out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C23164
	private Void set_anchoredPosition_Injected(ref Vector2 value) { }

	// RVA: 0xFFFFFFFF75C2320C
	private Void get_sizeDelta_Injected(out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C232B0
	private Void set_sizeDelta_Injected(ref Vector2 value) { }

	// RVA: 0xFFFFFFFF75C23358
	private Void get_pivot_Injected(out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C233FC
	private Void set_pivot_Injected(ref Vector2 value) { }

}

// Namespace: 
public enum Edge
{
	// Fields
	public Int32 value__; // 0x10
	public const Edge Left = 0;
	public const Edge Right = 1;
	public const Edge Top = 2;
	public const Edge Bottom = 3;
}

// Namespace: 
public enum Axis
{
	// Fields
	public Int32 value__; // 0x10
	public const Axis Horizontal = 0;
	public const Axis Vertical = 1;
}

// Namespace: 
public sealed class ReapplyDrivenProperties
{
	// Methods

	// RVA: 0xFFFFFFFF75C24BA8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75C24608
	public virtual Void Invoke(RectTransform driven) { }

	// RVA: 0xFFFFFFFF75C24BEC
	public virtual IAsyncResult BeginInvoke(RectTransform driven, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75C24C3C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine
internal enum RotationOrder
{
	// Fields
	public Int32 value__; // 0x10
	public const RotationOrder OrderXYZ = 0;
	public const RotationOrder OrderXZY = 1;
	public const RotationOrder OrderYZX = 2;
	public const RotationOrder OrderYXZ = 3;
	public const RotationOrder OrderZXY = 4;
	public const RotationOrder OrderZYX = 5;
}

// Namespace: UnityEngine
public class Transform
{
	// Properties
	public Vector3 position { get; set; }
	public Vector3 localPosition { get; set; }
	public Vector3 eulerAngles { get; set; }
	public Vector3 localEulerAngles { get; set; }
	public Vector3 right { get; set; }
	public Vector3 up { get; set; }
	public Vector3 forward { get; set; }
	public Quaternion rotation { get; set; }
	public Quaternion localRotation { get; set; }
	internal RotationOrder rotationOrder { get; set; }
	public Vector3 localScale { get; set; }
	public Transform parent { get; set; }
	internal Transform parentInternal { get; set; }
	public Matrix4x4 worldToLocalMatrix { get; }
	public Matrix4x4 localToWorldMatrix { get; }
	public Transform root { get; }
	public Int32 childCount { get; }
	public Vector3 lossyScale { get; }
	public Boolean hasChanged { get; set; }
	public Int32 hierarchyCapacity { get; set; }
	public Int32 hierarchyCount { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C42B70
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF723CAB4C
	public Vector3 get_position() { }

	// RVA: 0xFFFFFFFF723CABE8
	public Void set_position(Vector3 value) { }

	// RVA: 0xFFFFFFFF723CAC6C
	public Vector3 get_localPosition() { }

	// RVA: 0xFFFFFFFF723CAD24
	public Void set_localPosition(Vector3 value) { }

	// RVA: 0xFFFFFFFF75C42CB8
	internal Vector3 GetLocalEulerAngles(RotationOrder order) { }

	// RVA: 0xFFFFFFFF75C42D80
	internal Void SetLocalEulerAngles(Vector3 euler, RotationOrder order) { }

	// RVA: 0xFFFFFFFF75C42E40
	internal Void SetLocalEulerHint(Vector3 euler) { }

	// RVA: 0xFFFFFFFF723CADC0
	public Vector3 get_eulerAngles() { }

	// RVA: 0xFFFFFFFF723CAEEC
	public Void set_eulerAngles(Vector3 value) { }

	// RVA: 0xFFFFFFFF723CB028
	public Vector3 get_localEulerAngles() { }

	// RVA: 0xFFFFFFFF723CB154
	public Void set_localEulerAngles(Vector3 value) { }

	// RVA: 0xFFFFFFFF723CB290
	public Vector3 get_right() { }

	// RVA: 0xFFFFFFFF75C42EE8
	public Void set_right(Vector3 value) { }

	// RVA: 0xFFFFFFFF723CB4AC
	public Vector3 get_up() { }

	// RVA: 0xFFFFFFFF75C42F94
	public Void set_up(Vector3 value) { }

	// RVA: 0xFFFFFFFF723CB6C8
	public Vector3 get_forward() { }

	// RVA: 0xFFFFFFFF723CB8E4
	public Void set_forward(Vector3 value) { }

	// RVA: 0xFFFFFFFF723CAE5C
	public Quaternion get_rotation() { }

	// RVA: 0xFFFFFFFF723CAFA4
	public Void set_rotation(Quaternion value) { }

	// RVA: 0xFFFFFFFF723CB0C4
	public Quaternion get_localRotation() { }

	// RVA: 0xFFFFFFFF723CB20C
	public Void set_localRotation(Quaternion value) { }

	// RVA: 0xFFFFFFFF75C43180
	internal RotationOrder get_rotationOrder() { }

	// RVA: 0xFFFFFFFF75C43200
	internal Void set_rotationOrder(RotationOrder value) { }

	// RVA: 0xFFFFFFFF75C431C0
	internal Int32 GetRotationOrderInternal() { }

	// RVA: 0xFFFFFFFF75C43250
	internal Void SetRotationOrderInternal(RotationOrder rotationOrder) { }

	// RVA: 0xFFFFFFFF723CB99C
	public Vector3 get_localScale() { }

	// RVA: 0xFFFFFFFF723CBA38
	public Void set_localScale(Vector3 value) { }

	// RVA: 0xFFFFFFFF723CBABC
	public Transform get_parent() { }

	// RVA: 0xFFFFFFFF723CBB10
	public Void set_parent(Transform value) { }

	// RVA: 0xFFFFFFFF75C43340
	internal Transform get_parentInternal() { }

	// RVA: 0xFFFFFFFF75C43380
	internal Void set_parentInternal(Transform value) { }

	// RVA: 0xFFFFFFFF75C433D4
	private Transform GetParent() { }

	// RVA: 0xFFFFFFFF723CBBC0
	public Void SetParent(Transform p) { }

	// RVA: 0xFFFFFFFF723CBC18
	public Void SetParent(Transform parent, Boolean worldPositionStays) { }

	// RVA: 0xFFFFFFFF723CBC7C
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0xFFFFFFFF723CBD20
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0xFFFFFFFF75C434B4
	public Void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	// RVA: 0xFFFFFFFF75C43570
	public Void Translate(Vector3 translation, Space relativeTo) { }

	// RVA: 0xFFFFFFFF75C43640
	public Void Translate(Vector3 translation) { }

	// RVA: 0xFFFFFFFF75C43648
	public Void Translate(Single x, Single y, Single z, Space relativeTo) { }

	// RVA: 0xFFFFFFFF75C4364C
	public Void Translate(Single x, Single y, Single z) { }

	// RVA: 0xFFFFFFFF75C43654
	public Void Translate(Vector3 translation, Transform relativeTo) { }

	// RVA: 0xFFFFFFFF75C43744
	public Void Translate(Single x, Single y, Single z, Transform relativeTo) { }

	// RVA: 0xFFFFFFFF75C43748
	public Void Rotate(Vector3 eulers, Space relativeTo) { }

	// RVA: 0xFFFFFFFF75C438C4
	public Void Rotate(Vector3 eulers) { }

	// RVA: 0xFFFFFFFF75C438CC
	public Void Rotate(Single xAngle, Single yAngle, Single zAngle, Space relativeTo) { }

	// RVA: 0xFFFFFFFF75C438D0
	public Void Rotate(Single xAngle, Single yAngle, Single zAngle) { }

	// RVA: 0xFFFFFFFF75C438D8
	internal Void RotateAroundInternal(Vector3 axis, Single angle) { }

	// RVA: 0xFFFFFFFF75C439A0
	public Void Rotate(Vector3 axis, Single angle, Space relativeTo) { }

	// RVA: 0xFFFFFFFF75C43A6C
	public Void Rotate(Vector3 axis, Single angle) { }

	// RVA: 0xFFFFFFFF75C43A74
	public Void RotateAround(Vector3 point, Vector3 axis, Single angle) { }

	// RVA: 0xFFFFFFFF75C43BD4
	public Void LookAt(Transform target, Vector3 worldUp) { }

	// RVA: 0xFFFFFFFF75C43CCC
	public Void LookAt(Transform target) { }

	// RVA: 0xFFFFFFFF75C43C68
	public Void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0xFFFFFFFF723CBE9C
	public Void LookAt(Vector3 worldPosition) { }

	// RVA: 0xFFFFFFFF75C43D80
	private Void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0xFFFFFFFF723CBDD4
	public Vector3 TransformDirection(Vector3 direction) { }

	// RVA: 0xFFFFFFFF75C43E94
	public Vector3 TransformDirection(Single x, Single y, Single z) { }

	// RVA: 0xFFFFFFFF723CBF7C
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	// RVA: 0xFFFFFFFF75C43EF0
	public Vector3 InverseTransformDirection(Single x, Single y, Single z) { }

	// RVA: 0xFFFFFFFF75C43EF4
	public Vector3 TransformVector(Vector3 vector) { }

	// RVA: 0xFFFFFFFF75C43FEC
	public Vector3 TransformVector(Single x, Single y, Single z) { }

	// RVA: 0xFFFFFFFF75C43FF0
	public Vector3 InverseTransformVector(Vector3 vector) { }

	// RVA: 0xFFFFFFFF75C440E8
	public Vector3 InverseTransformVector(Single x, Single y, Single z) { }

	// RVA: 0xFFFFFFFF723CC020
	public Vector3 TransformPoint(Vector3 position) { }

	// RVA: 0xFFFFFFFF723CC0CC
	public Vector3 TransformPoint(Single x, Single y, Single z) { }

	// RVA: 0xFFFFFFFF723CC178
	public Vector3 InverseTransformPoint(Vector3 position) { }

	// RVA: 0xFFFFFFFF75C4419C
	public Vector3 InverseTransformPoint(Single x, Single y, Single z) { }

	// RVA: 0xFFFFFFFF75C441A0
	public Transform get_root() { }

	// RVA: 0xFFFFFFFF75C441E4
	private Transform GetRoot() { }

	// RVA: 0xFFFFFFFF723CC224
	public Int32 get_childCount() { }

	// RVA: 0xFFFFFFFF75C44224
	public Void DetachChildren() { }

	// RVA: 0xFFFFFFFF723CC278
	public Void SetAsFirstSibling() { }

	// RVA: 0xFFFFFFFF723CC2BC
	public Void SetAsLastSibling() { }

	// RVA: 0xFFFFFFFF723CC300
	public Void SetSiblingIndex(Int32 index) { }

	// RVA: 0xFFFFFFFF75C44264
	public Int32 GetSiblingIndex() { }

	// RVA: 0xFFFFFFFF75C442A4
	private static Transform FindRelativeTransformWithPath(Transform transform, String path, Boolean isActiveOnly) { }

	// RVA: 0xFFFFFFFF723CC354
	public Transform Find(String n) { }

	// RVA: 0xFFFFFFFF75C442FC
	internal Void SendTransformChangedScale() { }

	// RVA: 0xFFFFFFFF723CC3DC
	public Vector3 get_lossyScale() { }

	// RVA: 0xFFFFFFFF75C4438C
	public Boolean IsChildOf(Transform parent) { }

	// RVA: 0xFFFFFFFF723CC478
	public Boolean get_hasChanged() { }

	// RVA: 0xFFFFFFFF723CC4F0
	public Void set_hasChanged(Boolean value) { }

	// RVA: 0xFFFFFFFF75C443DC
	public Transform FindChild(String n) { }

	// RVA: 0xFFFFFFFF723CC574
	public IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75C44420
	public Void RotateAround(Vector3 axis, Single angle) { }

	// RVA: 0xFFFFFFFF75C444E8
	public Void RotateAroundLocal(Vector3 axis, Single angle) { }

	// RVA: 0xFFFFFFFF723CC5D0
	public Transform GetChild(Int32 index) { }

	// RVA: 0xFFFFFFFF75C445B0
	public Int32 GetChildCount() { }

	// RVA: 0xFFFFFFFF75C445F0
	public Int32 get_hierarchyCapacity() { }

	// RVA: 0xFFFFFFFF75C44670
	public Void set_hierarchyCapacity(Int32 value) { }

	// RVA: 0xFFFFFFFF75C44630
	private Int32 internal_getHierarchyCapacity() { }

	// RVA: 0xFFFFFFFF75C446C0
	private Void internal_setHierarchyCapacity(Int32 value) { }

	// RVA: 0xFFFFFFFF75C44710
	public Int32 get_hierarchyCount() { }

	// RVA: 0xFFFFFFFF75C44750
	private Int32 internal_getHierarchyCount() { }

	// RVA: 0xFFFFFFFF75C44790
	internal Boolean IsNonUniformScaleTransform() { }

	// RVA: 0xFFFFFFFF75C42B78
	private Void get_position_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C42BC8
	private Void set_position_Injected(ref Vector3 value) { }

	// RVA: 0xFFFFFFFF75C42C18
	private Void get_localPosition_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C42C68
	private Void set_localPosition_Injected(ref Vector3 value) { }

	// RVA: 0xFFFFFFFF75C42D28
	private Void GetLocalEulerAngles_Injected(RotationOrder order, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C42DE8
	private Void SetLocalEulerAngles_Injected(ref Vector3 euler, RotationOrder order) { }

	// RVA: 0xFFFFFFFF75C42E98
	private Void SetLocalEulerHint_Injected(ref Vector3 euler) { }

	// RVA: 0xFFFFFFFF75C43040
	private Void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75C43090
	private Void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0xFFFFFFFF75C430E0
	private Void get_localRotation_Injected(out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75C43130
	private Void set_localRotation_Injected(ref Quaternion value) { }

	// RVA: 0xFFFFFFFF75C432A0
	private Void get_localScale_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C432F0
	private Void set_localScale_Injected(ref Vector3 value) { }

	// RVA: 0xFFFFFFFF75C43414
	private Void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75C43464
	private Void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75C43518
	private Void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0xFFFFFFFF75C43940
	private Void RotateAroundInternal_Injected(ref Vector3 axis, Single angle) { }

	// RVA: 0xFFFFFFFF75C43DE4
	private Void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp) { }

	// RVA: 0xFFFFFFFF75C43E3C
	private Void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C43E98
	private Void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C43F94
	private Void TransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C44090
	private Void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C440EC
	private Void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C44144
	private Void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C4433C
	private Void get_lossyScale_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C44488
	private Void RotateAround_Injected(ref Vector3 axis, Single angle) { }

	// RVA: 0xFFFFFFFF75C44550
	private Void RotateAroundLocal_Injected(ref Vector3 axis, Single angle) { }

}

// Namespace: 
private class Enumerator
{
	// Fields
	private Transform outer; // 0x10
	private Int32 currentIndex; // 0x18

	// Properties
	public Object Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C443E0
	internal Void .ctor(Transform outer) { }

	// RVA: 0xFFFFFFFF723CC62C
	public Object get_Current() { }

	// RVA: 0xFFFFFFFF723CC69C
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75C447D0
	public Void Reset() { }

}

// Namespace: UnityEngine
public enum SpriteDrawMode
{
	// Fields
	public Int32 value__; // 0x10
	public const SpriteDrawMode Simple = 0;
	public const SpriteDrawMode Sliced = 1;
	public const SpriteDrawMode Tiled = 2;
}

// Namespace: UnityEngine
public enum SpriteTileMode
{
	// Fields
	public Int32 value__; // 0x10
	public const SpriteTileMode Continuous = 0;
	public const SpriteTileMode Adaptive = 1;
}

// Namespace: UnityEngine
public enum SpriteMaskInteraction
{
	// Fields
	public Int32 value__; // 0x10
	public const SpriteMaskInteraction None = 0;
	public const SpriteMaskInteraction VisibleInsideMask = 1;
	public const SpriteMaskInteraction VisibleOutsideMask = 2;
}

// Namespace: UnityEngine
public sealed class SpriteRenderer
{
	// Properties
	internal Boolean shouldSupportTiling { get; }
	public Sprite sprite { get; set; }
	public SpriteDrawMode drawMode { get; set; }
	public Vector2 size { get; set; }
	public Single adaptiveModeThreshold { get; set; }
	public SpriteTileMode tileMode { get; set; }
	public Color color { get; set; }
	public SpriteMaskInteraction maskInteraction { get; set; }
	public Boolean flipX { get; set; }
	public Boolean flipY { get; set; }
	public SpriteSortPoint spriteSortPoint { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C39C84
	internal Boolean get_shouldSupportTiling() { }

	// RVA: 0xFFFFFFFF75C39CC4
	public Sprite get_sprite() { }

	// RVA: 0xFFFFFFFF75C39D04
	public Void set_sprite(Sprite value) { }

	// RVA: 0xFFFFFFFF75C39D54
	public SpriteDrawMode get_drawMode() { }

	// RVA: 0xFFFFFFFF75C39D94
	public Void set_drawMode(SpriteDrawMode value) { }

	// RVA: 0xFFFFFFFF75C39DE4
	public Vector2 get_size() { }

	// RVA: 0xFFFFFFFF75C39E8C
	public Void set_size(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C39F30
	public Single get_adaptiveModeThreshold() { }

	// RVA: 0xFFFFFFFF75C39F70
	public Void set_adaptiveModeThreshold(Single value) { }

	// RVA: 0xFFFFFFFF75C39FC0
	public SpriteTileMode get_tileMode() { }

	// RVA: 0xFFFFFFFF75C3A000
	public Void set_tileMode(SpriteTileMode value) { }

	// RVA: 0xFFFFFFFF75C3A050
	public Color get_color() { }

	// RVA: 0xFFFFFFFF75C3A0FC
	public Void set_color(Color value) { }

	// RVA: 0xFFFFFFFF75C3A1A4
	public SpriteMaskInteraction get_maskInteraction() { }

	// RVA: 0xFFFFFFFF75C3A1E4
	public Void set_maskInteraction(SpriteMaskInteraction value) { }

	// RVA: 0xFFFFFFFF75C3A234
	public Boolean get_flipX() { }

	// RVA: 0xFFFFFFFF75C3A274
	public Void set_flipX(Boolean value) { }

	// RVA: 0xFFFFFFFF75C3A2C4
	public Boolean get_flipY() { }

	// RVA: 0xFFFFFFFF75C3A304
	public Void set_flipY(Boolean value) { }

	// RVA: 0xFFFFFFFF75C3A354
	public SpriteSortPoint get_spriteSortPoint() { }

	// RVA: 0xFFFFFFFF75C3A394
	public Void set_spriteSortPoint(SpriteSortPoint value) { }

	// RVA: 0xFFFFFFFF75C3A3E4
	internal Bounds Internal_GetSpriteBounds(SpriteDrawMode mode) { }

	// RVA: 0xFFFFFFFF75C3A4B8
	internal Bounds GetSpriteBounds() { }

	// RVA: 0xFFFFFFFF75C3A55C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C39E3C
	private Void get_size_Injected(out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C39EE0
	private Void set_size_Injected(ref Vector2 value) { }

	// RVA: 0xFFFFFFFF75C3A0AC
	private Void get_color_Injected(out Color ret) { }

	// RVA: 0xFFFFFFFF75C3A154
	private Void set_color_Injected(ref Color value) { }

	// RVA: 0xFFFFFFFF75C3A460
	private Void Internal_GetSpriteBounds_Injected(SpriteDrawMode mode, out Bounds ret) { }

}

// Namespace: UnityEngine
public enum SpriteMeshType
{
	// Fields
	public Int32 value__; // 0x10
	public const SpriteMeshType FullRect = 0;
	public const SpriteMeshType Tight = 1;
}

// Namespace: UnityEngine
public enum SpritePackingMode
{
	// Fields
	public Int32 value__; // 0x10
	public const SpritePackingMode Tight = 0;
	public const SpritePackingMode Rectangle = 1;
}

// Namespace: UnityEngine
public enum SpritePackingRotation
{
	// Fields
	public Int32 value__; // 0x10
	public const SpritePackingRotation None = 0;
	public const SpritePackingRotation FlipHorizontal = 1;
	public const SpritePackingRotation FlipVertical = 2;
	public const SpritePackingRotation Rotate180 = 3;
	public const SpritePackingRotation Any = 15;
}

// Namespace: UnityEngine
public enum SpriteSortPoint
{
	// Fields
	public Int32 value__; // 0x10
	public const SpriteSortPoint Center = 0;
	public const SpriteSortPoint Pivot = 1;
}

// Namespace: UnityEngine
public sealed class Sprite
{
	// Properties
	public Bounds bounds { get; }
	public Rect rect { get; }
	public Vector4 border { get; }
	public Texture2D texture { get; }
	public Single pixelsPerUnit { get; }
	public Single spriteAtlasTextureScale { get; }
	public Texture2D associatedAlphaSplitTexture { get; }
	public Vector2 pivot { get; }
	public Boolean packed { get; }
	public SpritePackingMode packingMode { get; }
	public SpritePackingRotation packingRotation { get; }
	public Rect textureRect { get; }
	public Vector2 textureRectOffset { get; set; }
	public Vector2[] vertices { get; }
	public UInt16[] triangles { get; }
	public Vector2[] uv { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C3816C
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF75C381AC
	internal Int32 GetPackingMode() { }

	// RVA: 0xFFFFFFFF75C381EC
	internal Int32 GetPackingRotation() { }

	// RVA: 0xFFFFFFFF75C3822C
	internal Int32 GetPacked() { }

	// RVA: 0xFFFFFFFF75C3826C
	internal Rect GetTextureRect() { }

	// RVA: 0xFFFFFFFF75C38318
	internal Vector2 GetTextureRectOffset() { }

	// RVA: 0xFFFFFFFF75C383C0
	internal Void SetTextureRectOffset(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C38464
	internal Vector4 GetInnerUVs() { }

	// RVA: 0xFFFFFFFF75C38510
	internal Vector4 GetOuterUVs() { }

	// RVA: 0xFFFFFFFF75C385BC
	internal Vector4 GetPadding() { }

	// RVA: 0xFFFFFFFF75C38668
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, Single pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border, Boolean generateFallbackPhysicsShape) { }

	// RVA: 0xFFFFFFFF75C387A4
	public static Sprite CreateSpriteWithTextureBorder(Texture2D texture, Rect rect, Vector4 textureBorder, Vector2 pivot, Single pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border, Boolean generateFallbackPhysicsShape) { }

	// RVA: 0xFFFFFFFF75C38900
	public Bounds get_bounds() { }

	// RVA: 0xFFFFFFFF75C389C4
	public Rect get_rect() { }

	// RVA: 0xFFFFFFFF75C38A70
	public Vector4 get_border() { }

	// RVA: 0xFFFFFFFF75C38B1C
	public Texture2D get_texture() { }

	// RVA: 0xFFFFFFFF75C38B5C
	public Single get_pixelsPerUnit() { }

	// RVA: 0xFFFFFFFF75C38B9C
	public Single get_spriteAtlasTextureScale() { }

	// RVA: 0xFFFFFFFF75C38BDC
	public Texture2D get_associatedAlphaSplitTexture() { }

	// RVA: 0xFFFFFFFF75C38C1C
	public Vector2 get_pivot() { }

	// RVA: 0xFFFFFFFF75C38CC4
	public Boolean get_packed() { }

	// RVA: 0xFFFFFFFF75C38D10
	public SpritePackingMode get_packingMode() { }

	// RVA: 0xFFFFFFFF75C38D50
	public SpritePackingRotation get_packingRotation() { }

	// RVA: 0xFFFFFFFF75C38D90
	public Rect get_textureRect() { }

	// RVA: 0xFFFFFFFF75C38E20
	public Vector2 get_textureRectOffset() { }

	// RVA: 0xFFFFFFFF75C38F20
	public Void set_textureRectOffset(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C38F74
	public Vector2[] get_vertices() { }

	// RVA: 0xFFFFFFFF75C38FB4
	public UInt16[] get_triangles() { }

	// RVA: 0xFFFFFFFF75C38FF4
	public Vector2[] get_uv() { }

	// RVA: 0xFFFFFFFF75C39034
	public Int32 GetPhysicsShapeCount() { }

	// RVA: 0xFFFFFFFF75C39074
	public Int32 GetPhysicsShapePointCount(Int32 shapeIdx) { }

	// RVA: 0xFFFFFFFF75C391A8
	private Int32 Internal_GetPhysicsShapePointCount(Int32 shapeIdx) { }

	// RVA: 0xFFFFFFFF75C391F8
	public Int32 GetPhysicsShape(Int32 shapeIdx, List<T0> physicsShape) { }

	// RVA: 0xFFFFFFFF75C39344
	private static Void GetPhysicsShapeImpl(Sprite sprite, Int32 shapeIdx, List<T0> physicsShape) { }

	// RVA: 0xFFFFFFFF75C3939C
	public Void OverridePhysicsShape(IList<T0> physicsShapes) { }

	// RVA: 0xFFFFFFFF75C3978C
	private static Void OverridePhysicsShapeCount(Sprite sprite, Int32 physicsShapeCount) { }

	// RVA: 0xFFFFFFFF75C397DC
	private static Void OverridePhysicsShape(Sprite sprite, Vector2[] physicsShape, Int32 idx) { }

	// RVA: 0xFFFFFFFF75C39834
	public Void OverrideGeometry(Vector2[] vertices, UInt16[] triangles) { }

	// RVA: 0xFFFFFFFF75C3988C
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, Single pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border, Boolean generateFallbackPhysicsShape) { }

	// RVA: 0xFFFFFFFF75C39B84
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, Single pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border) { }

	// RVA: 0xFFFFFFFF75C39B94
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, Single pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType) { }

	// RVA: 0xFFFFFFFF75C39C5C
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, Single pixelsPerUnit, UInt32 extrude) { }

	// RVA: 0xFFFFFFFF75C39C64
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, Single pixelsPerUnit) { }

	// RVA: 0xFFFFFFFF75C39C70
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	// RVA: 0xFFFFFFFF75C382C8
	private Void GetTextureRect_Injected(out Rect ret) { }

	// RVA: 0xFFFFFFFF75C38370
	private Void GetTextureRectOffset_Injected(out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C38414
	private Void SetTextureRectOffset_Injected(ref Vector2 value) { }

	// RVA: 0xFFFFFFFF75C384C0
	private Void GetInnerUVs_Injected(out Vector4 ret) { }

	// RVA: 0xFFFFFFFF75C3856C
	private Void GetOuterUVs_Injected(out Vector4 ret) { }

	// RVA: 0xFFFFFFFF75C38618
	private Void GetPadding_Injected(out Vector4 ret) { }

	// RVA: 0xFFFFFFFF75C3870C
	private static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, Single pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, ref Vector4 border, Boolean generateFallbackPhysicsShape) { }

	// RVA: 0xFFFFFFFF75C38858
	private static Sprite CreateSpriteWithTextureBorder_Injected(Texture2D texture, ref Rect rect, ref Vector4 textureBorder, ref Vector2 pivot, Single pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, ref Vector4 border, Boolean generateFallbackPhysicsShape) { }

	// RVA: 0xFFFFFFFF75C38974
	private Void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0xFFFFFFFF75C38A20
	private Void get_rect_Injected(out Rect ret) { }

	// RVA: 0xFFFFFFFF75C38ACC
	private Void get_border_Injected(out Vector4 ret) { }

	// RVA: 0xFFFFFFFF75C38C74
	private Void get_pivot_Injected(out Vector2 ret) { }

}

// Namespace: UnityEngine._Scripting.APIUpdating
internal class APIUpdaterRuntimeHelpers
{
	// Methods

	// RVA: 0xFFFFFFFF75C48518
	internal static Boolean GetMovedFromAttributeDataForType(Type sourceType, out String assembly, out String nsp, out String klass) { }

	// RVA: 0xFFFFFFFF75C486E4
	internal static Boolean GetObsoleteTypeRedirection(Type sourceType, out String assemblyName, out String nsp, out String className) { }

}

// Namespace: UnityEngine.Sprites
public sealed class DataUtility
{
	// Methods

	// RVA: 0xFFFFFFFF75C3A564
	public static Vector4 GetInnerUV(Sprite sprite) { }

	// RVA: 0xFFFFFFFF75C3A578
	public static Vector4 GetOuterUV(Sprite sprite) { }

	// RVA: 0xFFFFFFFF75C3A58C
	public static Vector4 GetPadding(Sprite sprite) { }

	// RVA: 0xFFFFFFFF75C3A5A0
	public static Vector2 GetMinSize(Sprite sprite) { }

}

// Namespace: UnityEngine.U2D
public struct SpriteBone
{
	// Fields
	private String m_Name; // 0x10
	private Vector3 m_Position; // 0x18
	private Quaternion m_Rotation; // 0x24
	private Single m_Length; // 0x34
	private Int32 m_ParentId; // 0x38
}

// Namespace: UnityEngine.U2D
public class SpriteAtlasManager
{
	// Fields
	private static Action<T0, T1> atlasRequested; // 0x0
	private static Action<T0> atlasRegistered; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75C4490C
	private static Boolean RequestAtlas(String tag) { }

	// RVA: 0xFFFFFFFF75C44A14
	public static Void add_atlasRegistered(Action<T0> value) { }

	// RVA: 0xFFFFFFFF75C44B04
	public static Void remove_atlasRegistered(Action<T0> value) { }

	// RVA: 0xFFFFFFFF75C44BF4
	private static Void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	// RVA: 0xFFFFFFFF75C44C9C
	internal static Void Register(SpriteAtlas spriteAtlas) { }

	// RVA: 0xFFFFFFFF75C44CDC
	private static Void .cctor() { }

}

// Namespace: UnityEngine.U2D
public class SpriteAtlas
{
	// Properties
	public Int32 spriteCount { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C447DC
	public Int32 get_spriteCount() { }

	// RVA: 0xFFFFFFFF75C4481C
	public Boolean CanBindTo(Sprite sprite) { }

	// RVA: 0xFFFFFFFF75C4486C
	public Int32 GetSprites(Sprite[] sprites) { }

	// RVA: 0xFFFFFFFF75C448BC
	private Int32 GetSpritesScripting(Sprite[] sprites) { }

}

// Namespace: UnityEngine.Profiling
public sealed class Profiler
{
	// Properties
	public static Boolean enabled { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C1FB18
	public static Boolean get_enabled() { }

	// RVA: 0xFFFFFFFF75C1FB4C
	public static Int32 GetRuntimeMemorySize(Object o) { }

	// RVA: 0xFFFFFFFF75C1FB90
	public static Int64 GetRuntimeMemorySizeLong(Object o) { }

	// RVA: 0xFFFFFFFF75C1FBD0
	public static Int64 GetMonoHeapSizeLong() { }

	// RVA: 0xFFFFFFFF723C4C38
	public static Int64 GetMonoUsedSizeLong() { }

	// RVA: 0xFFFFFFFF723C4C70
	public static Int64 GetTotalAllocatedMemoryLong() { }

	// RVA: 0xFFFFFFFF723C4CA8
	public static Int64 GetTotalReservedMemoryLong() { }

}

// Namespace: UnityEngine.Profiling
public sealed class Recorder
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal static Recorder s_InvalidRecorder; // 0x0

	// Properties
	public Boolean isValid { get; }
	public Boolean enabled { set; }
	public Int64 elapsedNanoseconds { get; }
	public Int32 sampleBlockCount { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C1FC04
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75C1FC08
	internal Void .ctor(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF75C1FC10
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75C1FCF8
	public static Recorder Get(String samplerName) { }

	// RVA: 0xFFFFFFFF75C1FD80
	private static IntPtr GetInternal(String samplerName) { }

	// RVA: 0xFFFFFFFF75C1FDC0
	public Boolean get_isValid() { }

	// RVA: 0xFFFFFFFF75C1FCB8
	private static Void DisposeNative(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF75C1FDD0
	public Void set_enabled(Boolean value) { }

	// RVA: 0xFFFFFFFF75C1FE44
	private Void SetEnabled(Boolean enabled) { }

	// RVA: 0xFFFFFFFF75C1FE94
	public Int64 get_elapsedNanoseconds() { }

	// RVA: 0xFFFFFFFF75C1FEF8
	private Int64 GetElapsedNanoseconds() { }

	// RVA: 0xFFFFFFFF75C1FF38
	public Int32 get_sampleBlockCount() { }

	// RVA: 0xFFFFFFFF75C1FF98
	private Int32 GetSampleBlockCount() { }

	// RVA: 0xFFFFFFFF75C1FFD8
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Profiling.Experimental
public struct DebugScreenCapture
{
	// Fields
	private NativeArray<T0> <rawImageDataReference>k__BackingField; // 0x10
	private TextureFormat <imageFormat>k__BackingField; // 0x20
	private Int32 <width>k__BackingField; // 0x24
	private Int32 <height>k__BackingField; // 0x28

	// Properties
	public NativeArray<T0> rawImageDataReference { set; }
	public TextureFormat imageFormat { set; }
	public Int32 width { set; }
	public Int32 height { set; }

	// Methods

	// RVA: 0xFFFFFFFF7114CE40
	public Void set_rawImageDataReference(NativeArray<T0> value) { }

	// RVA: 0xFFFFFFFF7114CE48
	public Void set_imageFormat(TextureFormat value) { }

	// RVA: 0xFFFFFFFF7114CE50
	public Void set_width(Int32 value) { }

	// RVA: 0xFFFFFFFF7114CE58
	public Void set_height(Int32 value) { }

}

// Namespace: UnityEngine.Profiling.Memory.Experimental
public class MetaData
{
	// Fields
	public String content; // 0x10
	public String platform; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75C1F7CC
	public Void .ctor() { }

}

// Namespace: UnityEngine.Profiling.Memory.Experimental
public sealed class MemoryProfiler
{
	// Fields
	private static Action<T0, T1> m_SnapshotFinished; // 0x0
	private static Action<T0, T1, T2> m_SaveScreenshotToDisk; // 0x8
	private static Action<T0> createMetaData; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C1F5AC
	private static Byte[] PrepareMetadata() { }

	// RVA: 0xFFFFFFFF75C1F7D0
	internal static Int32 WriteIntToByteArray(Byte[] array, Int32 offset, Int32 value) { }

	// RVA: 0xFFFFFFFF75C1F870
	internal static Int32 WriteStringToByteArray(Byte[] array, Int32 offset, String value) { }

	// RVA: 0xFFFFFFFF75C1F924
	private static Void FinalizeSnapshot(String path, Boolean result) { }

	// RVA: 0xFFFFFFFF75C1F9CC
	private static Void SaveScreenshotToDisk(String path, Boolean result, IntPtr pixelsPtr, Int32 pixelsCount, TextureFormat format, Int32 width, Int32 height) { }

}

// Namespace: UnityEngine.Jobs
public interface IJobParallelForTransform
{
	// Methods

	// RVA: -1
	public abstract Void Execute(Int32 index, TransformAccess transform) { }

}

// Namespace: UnityEngine.Jobs
public static class IJobParallelForTransformExtensions
{
	// Methods

	// RVA: -1
	public static JobHandle Schedule(T jobData, TransformAccessArray transforms, JobHandle dependsOn) { }

}

// Namespace: 
internal struct TransformParallelForLoopStruct<T0>
{
	// Fields
	public static IntPtr jobReflectionData; // 0x0

	// Methods

	// RVA: -1
	public static IntPtr Initialize() { }

	// RVA: -1
	public static Void Execute(ref T jobData, IntPtr jobData2, IntPtr bufferRangePatchData, ref JobRanges ranges, Int32 jobIndex) { }

}

// Namespace: 
public sealed class ExecuteJobFunction
{
	// Methods

	// RVA: -1
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: -1
	public virtual Void Invoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, Int32 jobIndex) { }

	// RVA: -1
	public virtual IAsyncResult BeginInvoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, Int32 jobIndex, AsyncCallback callback, Object object) { }

	// RVA: -1
	public virtual Void EndInvoke(ref T jobData, ref JobRanges ranges, IAsyncResult result) { }

}

// Namespace: UnityEngine.Jobs
public struct TransformAccess
{
	// Fields
	private IntPtr hierarchy; // 0x10
	private Int32 index; // 0x18

	// Properties
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	public Vector3 localPosition { get; set; }
	public Quaternion localRotation { get; set; }
	public Vector3 localScale { set; }
	public Matrix4x4 worldToLocalMatrix { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114BD24
	public Vector3 get_position() { }

	// RVA: 0xFFFFFFFF7114BD2C
	public Void set_position(Vector3 value) { }

	// RVA: 0xFFFFFFFF7114BD84
	public Quaternion get_rotation() { }

	// RVA: 0xFFFFFFFF7114BD8C
	public Void set_rotation(Quaternion value) { }

	// RVA: 0xFFFFFFFF7114BDE4
	public Vector3 get_localPosition() { }

	// RVA: 0xFFFFFFFF7114BDEC
	public Void set_localPosition(Vector3 value) { }

	// RVA: 0xFFFFFFFF7114BE44
	public Quaternion get_localRotation() { }

	// RVA: 0xFFFFFFFF7114BE4C
	public Void set_localRotation(Quaternion value) { }

	// RVA: 0xFFFFFFFF7114BEA4
	public Void set_localScale(Vector3 value) { }

	// RVA: 0xFFFFFFFF7114BEFC
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0xFFFFFFFF75C07E40
	private static Void GetPosition(ref TransformAccess access, out Vector3 p) { }

	// RVA: 0xFFFFFFFF75C07E90
	private static Void SetPosition(ref TransformAccess access, ref Vector3 p) { }

	// RVA: 0xFFFFFFFF75C07EE0
	private static Void GetRotation(ref TransformAccess access, out Quaternion r) { }

	// RVA: 0xFFFFFFFF75C07F30
	private static Void SetRotation(ref TransformAccess access, ref Quaternion r) { }

	// RVA: 0xFFFFFFFF75C07F80
	private static Void GetLocalPosition(ref TransformAccess access, out Vector3 p) { }

	// RVA: 0xFFFFFFFF75C07FD0
	private static Void SetLocalPosition(ref TransformAccess access, ref Vector3 p) { }

	// RVA: 0xFFFFFFFF75C08020
	private static Void GetLocalRotation(ref TransformAccess access, out Quaternion r) { }

	// RVA: 0xFFFFFFFF75C08070
	private static Void SetLocalRotation(ref TransformAccess access, ref Quaternion r) { }

	// RVA: 0xFFFFFFFF75C080C0
	private static Void SetLocalScale(ref TransformAccess access, ref Vector3 r) { }

	// RVA: 0xFFFFFFFF75C08110
	private static Void GetWorldToLocalMatrix(ref TransformAccess access, out Matrix4x4 m) { }

}

// Namespace: UnityEngine.Jobs
public struct TransformAccessArray
{
	// Fields
	private IntPtr m_TransformArray; // 0x10

	// Properties
	public Boolean isCreated { get; }
	public Transform Item { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF7114BF74
	public Void .ctor(Int32 capacity, Int32 desiredJobCount) { }

	// RVA: 0xFFFFFFFF75C08160
	public static Void Allocate(Int32 capacity, Int32 desiredJobCount, out TransformAccessArray array) { }

	// RVA: 0xFFFFFFFF7114BFD0
	public Boolean get_isCreated() { }

	// RVA: 0xFFFFFFFF7114BFE0
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF7114C034
	internal IntPtr GetTransformAccessArrayForSchedule() { }

	// RVA: 0xFFFFFFFF7114C03C
	public Transform get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF7114C08C
	public Void set_Item(Int32 index, Transform value) { }

	// RVA: 0xFFFFFFFF7114C0E4
	public Void Add(Transform transform) { }

	// RVA: 0xFFFFFFFF7114C134
	public Void RemoveAtSwapBack(Int32 index) { }

	// RVA: 0xFFFFFFFF75C081BC
	private static IntPtr Create(Int32 capacity, Int32 desiredJobCount) { }

	// RVA: 0xFFFFFFFF75C0821C
	private static Void DestroyTransformAccessArray(IntPtr transformArray) { }

	// RVA: 0xFFFFFFFF75C08304
	private static Void Add(IntPtr transformArrayIntPtr, Transform transform) { }

	// RVA: 0xFFFFFFFF75C083A4
	private static Void RemoveAtSwapBack(IntPtr transformArrayIntPtr, Int32 index) { }

	// RVA: 0xFFFFFFFF723BC644
	internal static IntPtr GetSortedTransformAccess(IntPtr transformArrayIntPtr) { }

	// RVA: 0xFFFFFFFF723BC698
	internal static IntPtr GetSortedToUserIndex(IntPtr transformArrayIntPtr) { }

	// RVA: 0xFFFFFFFF75C0825C
	internal static Transform GetTransform(IntPtr transformArrayIntPtr, Int32 index) { }

	// RVA: 0xFFFFFFFF75C082AC
	internal static Void SetTransform(IntPtr transformArrayIntPtr, Int32 index, Transform transform) { }

}

// Namespace: UnityEngine.iOS
public enum DeviceGeneration
{
	// Fields
	public Int32 value__; // 0x10
	public const DeviceGeneration Unknown = 0;
	public const DeviceGeneration iPhone = 1;
	public const DeviceGeneration iPhone3G = 2;
	public const DeviceGeneration iPhone3GS = 3;
	public const DeviceGeneration iPodTouch1Gen = 4;
	public const DeviceGeneration iPodTouch2Gen = 5;
	public const DeviceGeneration iPodTouch3Gen = 6;
	public const DeviceGeneration iPad1Gen = 7;
	public const DeviceGeneration iPhone4 = 8;
	public const DeviceGeneration iPodTouch4Gen = 9;
	public const DeviceGeneration iPad2Gen = 10;
	public const DeviceGeneration iPhone4S = 11;
	public const DeviceGeneration iPad3Gen = 12;
	public const DeviceGeneration iPhone5 = 13;
	public const DeviceGeneration iPodTouch5Gen = 14;
	public const DeviceGeneration iPadMini1Gen = 15;
	public const DeviceGeneration iPad4Gen = 16;
	public const DeviceGeneration iPhone5C = 17;
	public const DeviceGeneration iPhone5S = 18;
	public const DeviceGeneration iPadAir1 = 19;
	public const DeviceGeneration iPadMini2Gen = 20;
	public const DeviceGeneration iPhone6 = 21;
	public const DeviceGeneration iPhone6Plus = 22;
	public const DeviceGeneration iPadMini3Gen = 23;
	public const DeviceGeneration iPadAir2 = 24;
	public const DeviceGeneration iPhone6S = 25;
	public const DeviceGeneration iPhone6SPlus = 26;
	public const DeviceGeneration iPadPro1Gen = 27;
	public const DeviceGeneration iPadMini4Gen = 28;
	public const DeviceGeneration iPhoneSE1Gen = 29;
	public const DeviceGeneration iPadPro10Inch1Gen = 30;
	public const DeviceGeneration iPhone7 = 31;
	public const DeviceGeneration iPhone7Plus = 32;
	public const DeviceGeneration iPodTouch6Gen = 33;
	public const DeviceGeneration iPad5Gen = 34;
	public const DeviceGeneration iPadPro2Gen = 35;
	public const DeviceGeneration iPadPro10Inch2Gen = 36;
	public const DeviceGeneration iPhone8 = 37;
	public const DeviceGeneration iPhone8Plus = 38;
	public const DeviceGeneration iPhoneX = 39;
	public const DeviceGeneration iPhoneXS = 40;
	public const DeviceGeneration iPhoneXSMax = 41;
	public const DeviceGeneration iPhoneXR = 42;
	public const DeviceGeneration iPadPro11Inch = 43;
	public const DeviceGeneration iPadPro3Gen = 44;
	public const DeviceGeneration iPad6Gen = 45;
	public const DeviceGeneration iPadAir3Gen = 46;
	public const DeviceGeneration iPadMini5Gen = 47;
	public const DeviceGeneration iPhone11 = 48;
	public const DeviceGeneration iPhone11Pro = 49;
	public const DeviceGeneration iPhone11ProMax = 50;
	public const DeviceGeneration iPodTouch7Gen = 51;
	public const DeviceGeneration iPad7Gen = 52;
	public const DeviceGeneration iPhoneSE2Gen = 53;
	public const DeviceGeneration iPadPro11Inch2Gen = 54;
	public const DeviceGeneration iPadPro4Gen = 55;
	public const DeviceGeneration iPhone12Mini = 56;
	public const DeviceGeneration iPhone12 = 57;
	public const DeviceGeneration iPhone12Pro = 58;
	public const DeviceGeneration iPhone12ProMax = 59;
	public const DeviceGeneration iPad8Gen = 60;
	public const DeviceGeneration iPadAir4Gen = 61;
	public const DeviceGeneration iPad9Gen = 62;
	public const DeviceGeneration iPadMini6Gen = 63;
	public const DeviceGeneration iPhone13 = 64;
	public const DeviceGeneration iPhone13Mini = 65;
	public const DeviceGeneration iPhone13Pro = 66;
	public const DeviceGeneration iPhone13ProMax = 67;
	public const DeviceGeneration iPadPro5Gen = 68;
	public const DeviceGeneration iPadPro11Inch3Gen = 69;
	public const DeviceGeneration iPhoneUnknown = 10001;
	public const DeviceGeneration iPadUnknown = 10002;
	public const DeviceGeneration iPodTouchUnknown = 10003;
}

// Namespace: UnityEngine.iOS
public sealed class Device
{
	// Properties
	public static DeviceGeneration generation { get; }
	public static String vendorIdentifier { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C48A20
	public static DeviceGeneration get_generation() { }

	// RVA: 0xFFFFFFFF75C48A58
	public static String get_vendorIdentifier() { }

}

// Namespace: UnityEngine.iOS
public sealed class LocalNotification
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private static Int64 m_NSReferenceDateTicks; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75C48A8C
	private static Void .cctor() { }

}

// Namespace: UnityEngine.iOS
public sealed class RemoteNotification
{
	// Fields
	private IntPtr m_Ptr; // 0x10
}

// Namespace: UnityEngine.Events
public enum PersistentListenerMode
{
	// Fields
	public Int32 value__; // 0x10
	public const PersistentListenerMode EventDefined = 0;
	public const PersistentListenerMode Void = 1;
	public const PersistentListenerMode Object = 2;
	public const PersistentListenerMode Int = 3;
	public const PersistentListenerMode Float = 4;
	public const PersistentListenerMode String = 5;
	public const PersistentListenerMode Bool = 6;
}

// Namespace: UnityEngine.Events
internal class ArgumentCache
{
	// Fields
	private Object m_ObjectArgument; // 0x10
	private String m_ObjectArgumentAssemblyTypeName; // 0x18
	private Int32 m_IntArgument; // 0x20
	private Single m_FloatArgument; // 0x24
	private String m_StringArgument; // 0x28
	private Boolean m_BoolArgument; // 0x30

	// Properties
	public Object unityObjectArgument { get; }
	public String unityObjectArgumentAssemblyTypeName { get; }
	public Int32 intArgument { get; }
	public Single floatArgument { get; }
	public String stringArgument { get; }
	public Boolean boolArgument { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BFF358
	public Object get_unityObjectArgument() { }

	// RVA: 0xFFFFFFFF75BFF360
	public String get_unityObjectArgumentAssemblyTypeName() { }

	// RVA: 0xFFFFFFFF75BFF368
	public Int32 get_intArgument() { }

	// RVA: 0xFFFFFFFF75BFF370
	public Single get_floatArgument() { }

	// RVA: 0xFFFFFFFF75BFF378
	public String get_stringArgument() { }

	// RVA: 0xFFFFFFFF75BFF380
	public Boolean get_boolArgument() { }

	// RVA: 0xFFFFFFFF75BFF388
	private Void TidyAssemblyTypeName() { }

	// RVA: 0xFFFFFFFF75BFF5A0
	public Void OnBeforeSerialize() { }

	// RVA: 0xFFFFFFFF75BFF5A4
	public Void OnAfterDeserialize() { }

	// RVA: 0xFFFFFFFF75BFF5A8
	public Void .ctor() { }

}

// Namespace: UnityEngine.Events
internal abstract class BaseInvokableCall
{
	// Methods

	// RVA: 0xFFFFFFFF75BFF5AC
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF75BFF5B0
	protected Void .ctor(Object target, MethodInfo function) { }

	// RVA: -1
	public abstract Void Invoke(Object[] args) { }

	// RVA: -1
	protected static Void ThrowOnInvalidArg(Object arg) { }

	// RVA: 0xFFFFFFFF75BFF64C
	protected static Boolean AllowInvoke(Delegate delegate) { }

	// RVA: -1
	public abstract Boolean Find(Object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCall
{
	// Fields
	private UnityAction Delegate; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75BFF6B0
	private Void add_Delegate(UnityAction value) { }

	// RVA: 0xFFFFFFFF75BFF764
	private Void remove_Delegate(UnityAction value) { }

	// RVA: 0xFFFFFFFF75BFF818
	public Void .ctor(Object target, MethodInfo theFunction) { }

	// RVA: 0xFFFFFFFF75BFF8DC
	public Void .ctor(UnityAction action) { }

	// RVA: 0xFFFFFFFF75BFF8E0
	public override Void Invoke(Object[] args) { }

	// RVA: 0xFFFFFFFF75BFF920
	public Void Invoke() { }

	// RVA: 0xFFFFFFFF75BFF960
	public override Boolean Find(Object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCall<T0>
{
	// Fields
	private UnityAction<T0> Delegate; // 0x0

	// Methods

	// RVA: -1
	protected Void add_Delegate(UnityAction<T0> value) { }

	// RVA: -1
	protected Void remove_Delegate(UnityAction<T0> value) { }

	// RVA: -1
	public Void .ctor(Object target, MethodInfo theFunction) { }

	// RVA: -1
	public Void .ctor(UnityAction<T0> action) { }

	// RVA: -1
	public override Void Invoke(Object[] args) { }

	// RVA: -1
	public virtual Void Invoke(T1 args0) { }

	// RVA: -1
	public override Boolean Find(Object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCall<T0, T1>
{
	// Fields
	private UnityAction<T0, T1> Delegate; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor(Object target, MethodInfo theFunction) { }

	// RVA: -1
	public override Void Invoke(Object[] args) { }

	// RVA: -1
	public Void Invoke(T1 args0, T2 args1) { }

	// RVA: -1
	public override Boolean Find(Object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCall<T0, T1, T2>
{
	// Fields
	private UnityAction<T0, T1, T2> Delegate; // 0x0

	// Methods

	// RVA: -1
	protected Void add_Delegate(UnityAction<T0, T1, T2> value) { }

	// RVA: -1
	protected Void remove_Delegate(UnityAction<T0, T1, T2> value) { }

	// RVA: -1
	public Void .ctor(Object target, MethodInfo theFunction) { }

	// RVA: -1
	public Void .ctor(UnityAction<T0, T1, T2> action) { }

	// RVA: -1
	public override Void Invoke(Object[] args) { }

	// RVA: -1
	public Void Invoke(T1 args0, T2 args1, T3 args2) { }

	// RVA: -1
	public override Boolean Find(Object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCall<T0, T1, T2, T3>
{
	// Fields
	private UnityAction<T0, T1, T2, T3> Delegate; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor(Object target, MethodInfo theFunction) { }

	// RVA: -1
	public override Void Invoke(Object[] args) { }

	// RVA: -1
	public override Boolean Find(Object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class CachedInvokableCall<T0>
{
	// Fields
	private readonly T m_Arg1; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor(Object target, MethodInfo theFunction, T argument) { }

	// RVA: -1
	public override Void Invoke(Object[] args) { }

	// RVA: -1
	public override Void Invoke(T arg0) { }

}

// Namespace: UnityEngine.Events
public enum UnityEventCallState
{
	// Fields
	public Int32 value__; // 0x10
	public const UnityEventCallState Off = 0;
	public const UnityEventCallState EditorAndRuntime = 1;
	public const UnityEventCallState RuntimeOnly = 2;
}

// Namespace: UnityEngine.Events
internal class PersistentCall
{
	// Fields
	private Object m_Target; // 0x10
	private String m_MethodName; // 0x18
	private PersistentListenerMode m_Mode; // 0x20
	private ArgumentCache m_Arguments; // 0x28
	private UnityEventCallState m_CallState; // 0x30

	// Properties
	public Object target { get; }
	public String methodName { get; }
	public PersistentListenerMode mode { get; }
	public ArgumentCache arguments { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BFFE78
	public Object get_target() { }

	// RVA: 0xFFFFFFFF75BFFE80
	public String get_methodName() { }

	// RVA: 0xFFFFFFFF75BFFE88
	public PersistentListenerMode get_mode() { }

	// RVA: 0xFFFFFFFF75BFFE90
	public ArgumentCache get_arguments() { }

	// RVA: 0xFFFFFFFF75BFFE98
	public Boolean IsValid() { }

	// RVA: 0xFFFFFFFF75BFFED0
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	// RVA: 0xFFFFFFFF75C0023C
	private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments) { }

	// RVA: 0xFFFFFFFF75C0054C
	public Void .ctor() { }

}

// Namespace: UnityEngine.Events
internal class PersistentCallGroup
{
	// Fields
	private List<T0> m_Calls; // 0x10

	// Properties
	public Int32 Count { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C005BC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C0063C
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75C00688
	public Void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCallList
{
	// Fields
	private readonly List<T0> m_PersistentCalls; // 0x10
	private readonly List<T0> m_RuntimeCalls; // 0x18
	private readonly List<T0> m_ExecutingCalls; // 0x20
	private Boolean m_NeedsUpdate; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75BFF9C0
	public Void AddPersistentInvokableCall(BaseInvokableCall call) { }

	// RVA: 0xFFFFFFFF75BFFA2C
	public Void AddListener(BaseInvokableCall call) { }

	// RVA: 0xFFFFFFFF75BFFA98
	public Void RemoveListener(Object targetObj, MethodInfo method) { }

	// RVA: 0xFFFFFFFF75BFFC38
	public Void Clear() { }

	// RVA: 0xFFFFFFFF75BFFC94
	public Void ClearPersistent() { }

	// RVA: 0xFFFFFFFF75BFFCF0
	public List<T0> PrepareInvoke() { }

	// RVA: 0xFFFFFFFF75BFFD80
	public Void .ctor() { }

}

// Namespace: UnityEngine.Events
public abstract class UnityEventBase
{
	// Fields
	private InvokableCallList m_Calls; // 0x10
	private PersistentCallGroup m_PersistentCalls; // 0x18
	private Boolean m_CallsDirty; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75C008D4
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF75C00E30
	private Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0xFFFFFFFF75C00E34
	private Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: -1
	protected abstract MethodInfo FindMethod_Impl(String name, Object targetObj) { }

	// RVA: -1
	internal abstract BaseInvokableCall GetDelegate(Object target, MethodInfo theFunction) { }

	// RVA: 0xFFFFFFFF75C00154
	internal MethodInfo FindMethod(PersistentCall call) { }

	// RVA: 0xFFFFFFFF75C00E9C
	internal MethodInfo FindMethod(String name, Object listener, PersistentListenerMode mode, Type argumentType) { }

	// RVA: 0xFFFFFFFF75C01098
	public Int32 GetPersistentEventCount() { }

	// RVA: 0xFFFFFFFF75C00E68
	private Void DirtyPersistentCalls() { }

	// RVA: 0xFFFFFFFF75C010E8
	private Void RebuildPersistentCallsIfNeeded() { }

	// RVA: 0xFFFFFFFF75C00A1C
	internal Void AddCall(BaseInvokableCall call) { }

	// RVA: 0xFFFFFFFF75C00A7C
	protected Void RemoveListener(Object targetObj, MethodInfo method) { }

	// RVA: 0xFFFFFFFF75C0112C
	public Void RemoveAllListeners() { }

	// RVA: 0xFFFFFFFF75C00E04
	internal List<T0> PrepareInvoke() { }

	// RVA: 0xFFFFFFFF75C01148
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75C00AD4
	public static MethodInfo GetValidMethodInfo(Object obj, String functionName, Type[] argumentTypes) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction
{
	// Methods

	// RVA: 0xFFFFFFFF75C007F0
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75BF457C
	public virtual Void Invoke() { }

	// RVA: 0xFFFFFFFF75C00834
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75C0088C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine.Events
public class UnityEvent
{
	// Fields
	private Object[] m_InvokeArray; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75C00898
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C00990
	public Void AddListener(UnityAction call) { }

	// RVA: 0xFFFFFFFF75C00A38
	public Void RemoveListener(UnityAction call) { }

	// RVA: 0xFFFFFFFF75C00A98
	protected override MethodInfo FindMethod_Impl(String name, Object targetObj) { }

	// RVA: 0xFFFFFFFF75C00C64
	internal override BaseInvokableCall GetDelegate(Object target, MethodInfo theFunction) { }

	// RVA: 0xFFFFFFFF75C009C4
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	// RVA: 0xFFFFFFFF75C00CCC
	public Void Invoke() { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0>
{
	// Methods

	// RVA: -1
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: -1
	public virtual Void Invoke(T0 arg0) { }

	// RVA: -1
	public virtual IAsyncResult BeginInvoke(T0 arg0, AsyncCallback callback, Object object) { }

	// RVA: -1
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine.Events
public abstract class UnityEvent<T0>
{
	// Fields
	private Object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	public Void AddListener(UnityAction<T0> call) { }

	// RVA: -1
	public Void RemoveListener(UnityAction<T0> call) { }

	// RVA: -1
	protected override MethodInfo FindMethod_Impl(String name, Object targetObj) { }

	// RVA: -1
	internal override BaseInvokableCall GetDelegate(Object target, MethodInfo theFunction) { }

	// RVA: -1
	private static BaseInvokableCall GetDelegate(UnityAction<T0> action) { }

	// RVA: -1
	public Void Invoke(T0 arg0) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1>
{
	// Methods

	// RVA: -1
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: -1
	public virtual Void Invoke(T0 arg0, T1 arg1) { }

	// RVA: -1
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, AsyncCallback callback, Object object) { }

	// RVA: -1
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine.Events
public abstract class UnityEvent<T0, T1>
{
	// Fields
	private Object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	protected override MethodInfo FindMethod_Impl(String name, Object targetObj) { }

	// RVA: -1
	internal override BaseInvokableCall GetDelegate(Object target, MethodInfo theFunction) { }

	// RVA: -1
	public Void Invoke(T0 arg0, T1 arg1) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2>
{
	// Methods

	// RVA: -1
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: -1
	public virtual Void Invoke(T0 arg0, T1 arg1, T2 arg2) { }

	// RVA: -1
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, AsyncCallback callback, Object object) { }

	// RVA: -1
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine.Events
public abstract class UnityEvent<T0, T1, T2>
{
	// Fields
	private Object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	public Void AddListener(UnityAction<T0, T1, T2> call) { }

	// RVA: -1
	public Void RemoveListener(UnityAction<T0, T1, T2> call) { }

	// RVA: -1
	protected override MethodInfo FindMethod_Impl(String name, Object targetObj) { }

	// RVA: -1
	internal override BaseInvokableCall GetDelegate(Object target, MethodInfo theFunction) { }

	// RVA: -1
	private static BaseInvokableCall GetDelegate(UnityAction<T0, T1, T2> action) { }

	// RVA: -1
	public Void Invoke(T0 arg0, T1 arg1, T2 arg2) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2, T3>
{
	// Methods

	// RVA: -1
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: -1
	public virtual Void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

	// RVA: -1
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, Object object) { }

	// RVA: -1
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine.Events
public abstract class UnityEvent<T0, T1, T2, T3>
{
	// Fields
	private Object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	protected override MethodInfo FindMethod_Impl(String name, Object targetObj) { }

	// RVA: -1
	internal override BaseInvokableCall GetDelegate(Object target, MethodInfo theFunction) { }

}

// Namespace: UnityEngine.Serialization
public class FormerlySerializedAsAttribute
{
	// Fields
	private String m_oldName; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C3492C
	public Void .ctor(String oldName) { }

}

// Namespace: UnityEngine.Scripting
public class PreserveAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75C3225C
	public Void .ctor() { }

}

// Namespace: UnityEngine.Scripting.APIUpdating
internal struct MovedFromAttributeData
{
	// Fields
	public String className; // 0x10
	public String nameSpace; // 0x18
	public String assembly; // 0x20
	public Boolean classHasChanged; // 0x28
	public Boolean nameSpaceHasChanged; // 0x29
	public Boolean assemblyHasChanged; // 0x2A
	public Boolean autoUdpateAPI; // 0x2B

	// Methods

	// RVA: 0xFFFFFFFF7114EAF8
	public Void Set(Boolean autoUpdateAPI, String sourceNamespace, String sourceAssembly, String sourceClassName) { }

}

// Namespace: UnityEngine.Scripting.APIUpdating
public class MovedFromAttribute
{
	// Fields
	internal MovedFromAttributeData data; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C347CC
	public Void .ctor(Boolean autoUpdateAPI, String sourceNamespace, String sourceAssembly, String sourceClassName) { }

	// RVA: 0xFFFFFFFF75C348E0
	public Void .ctor(String sourceNamespace) { }

}

// Namespace: UnityEngine.SceneManagement
public struct Scene
{
	// Fields
	private Int32 m_Handle; // 0x10

	// Properties
	public Int32 handle { get; }
	public String name { get; }
	public Boolean isLoaded { get; }
	public Int32 buildIndex { get; }
	public Int32 rootCount { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C322A8
	private static Boolean IsValidInternal(Int32 sceneHandle) { }

	// RVA: 0xFFFFFFFF75C322E8
	private static String GetNameInternal(Int32 sceneHandle) { }

	// RVA: 0xFFFFFFFF75C32328
	private static Boolean GetIsLoadedInternal(Int32 sceneHandle) { }

	// RVA: 0xFFFFFFFF75C32368
	private static Int32 GetBuildIndexInternal(Int32 sceneHandle) { }

	// RVA: 0xFFFFFFFF75C323A8
	private static Int32 GetRootCountInternal(Int32 sceneHandle) { }

	// RVA: 0xFFFFFFFF75C323E8
	private static Void GetRootGameObjectsInternal(Int32 sceneHandle, Object resultRootList) { }

	// RVA: 0xFFFFFFFF7114E834
	public Int32 get_handle() { }

	// RVA: 0xFFFFFFFF7114E83C
	public Boolean IsValid() { }

	// RVA: 0xFFFFFFFF7114E87C
	public String get_name() { }

	// RVA: 0xFFFFFFFF7114E8BC
	public Boolean get_isLoaded() { }

	// RVA: 0xFFFFFFFF7114E8FC
	public Int32 get_buildIndex() { }

	// RVA: 0xFFFFFFFF7114E93C
	public Int32 get_rootCount() { }

	// RVA: 0xFFFFFFFF7114E97C
	public GameObject[] GetRootGameObjects() { }

	// RVA: 0xFFFFFFFF7114E984
	public Void GetRootGameObjects(List<T0> rootGameObjects) { }

	// RVA: 0xFFFFFFFF7114E98C
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114E994
	public override Boolean Equals(Object other) { }

}

// Namespace: UnityEngine.SceneManagement
internal static class SceneManagerAPIInternal
{
	// Methods

	// RVA: 0xFFFFFFFF75C32EE8
	public static AsyncOperation LoadSceneAsyncNameIndexInternal(String sceneName, Int32 sceneBuildIndex, LoadSceneParameters parameters, Boolean mustCompleteNextFrame) { }

	// RVA: 0xFFFFFFFF75C3300C
	public static AsyncOperation UnloadSceneNameIndexInternal(String sceneName, Int32 sceneBuildIndex, Boolean immediately, UnloadSceneOptions options, out Boolean outSuccess) { }

	// RVA: 0xFFFFFFFF75C33E1C
	private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(String sceneName, Int32 sceneBuildIndex, ref LoadSceneParameters parameters, Boolean mustCompleteNextFrame) { }

}

// Namespace: UnityEngine.SceneManagement
public class SceneManager
{
	// Fields
	internal static Boolean s_AllowLoadScene; // 0x0
	private static UnityAction<T0, T1> sceneLoaded; // 0x8
	private static UnityAction<T0> sceneUnloaded; // 0x10
	private static UnityAction<T0, T1> activeSceneChanged; // 0x18

	// Properties
	public static Int32 sceneCount { get; }
	public static Int32 sceneCountInBuildSettings { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C3287C
	public static Int32 get_sceneCount() { }

	// RVA: 0xFFFFFFFF75C328B0
	public static Int32 get_sceneCountInBuildSettings() { }

	// RVA: 0xFFFFFFFF75C328E4
	public static Scene GetActiveScene() { }

	// RVA: 0xFFFFFFFF75C32998
	public static Boolean SetActiveScene(Scene scene) { }

	// RVA: 0xFFFFFFFF75C32A40
	public static Scene GetSceneByPath(String scenePath) { }

	// RVA: 0xFFFFFFFF75C32B04
	public static Scene GetSceneByName(String name) { }

	// RVA: 0xFFFFFFFF75C32BC8
	public static Scene GetSceneByBuildIndex(Int32 buildIndex) { }

	// RVA: 0xFFFFFFFF75C32C8C
	public static Scene GetSceneAt(Int32 index) { }

	// RVA: 0xFFFFFFFF75C32D58
	public static Scene CreateScene(String sceneName, CreateSceneParameters parameters) { }

	// RVA: 0xFFFFFFFF75C32E28
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options) { }

	// RVA: 0xFFFFFFFF723C903C
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(String sceneName, Int32 sceneBuildIndex, LoadSceneParameters parameters, Boolean mustCompleteNextFrame) { }

	// RVA: 0xFFFFFFFF75C32F54
	private static AsyncOperation UnloadSceneNameIndexInternal(String sceneName, Int32 sceneBuildIndex, Boolean immediately, UnloadSceneOptions options, out Boolean outSuccess) { }

	// RVA: 0xFFFFFFFF75C3307C
	public static Void MergeScenes(Scene sourceScene, Scene destinationScene) { }

	// RVA: 0xFFFFFFFF75C33138
	public static Void MoveGameObjectToScene(GameObject go, Scene scene) { }

	// RVA: 0xFFFFFFFF75C331F8
	public static Void add_sceneLoaded(UnityAction<T0, T1> value) { }

	// RVA: 0xFFFFFFFF75C332BC
	public static Void remove_sceneLoaded(UnityAction<T0, T1> value) { }

	// RVA: 0xFFFFFFFF75C3337C
	public static Void add_sceneUnloaded(UnityAction<T0> value) { }

	// RVA: 0xFFFFFFFF75C3346C
	public static Void remove_sceneUnloaded(UnityAction<T0> value) { }

	// RVA: 0xFFFFFFFF75C3355C
	public static Void add_activeSceneChanged(UnityAction<T0, T1> value) { }

	// RVA: 0xFFFFFFFF75C33650
	public static Void remove_activeSceneChanged(UnityAction<T0, T1> value) { }

	// RVA: 0xFFFFFFFF75C33744
	public static Scene CreateScene(String sceneName) { }

	// RVA: 0xFFFFFFFF75C33784
	public static Void LoadScene(String sceneName, LoadSceneMode mode) { }

	// RVA: 0xFFFFFFFF75C33854
	public static Void LoadScene(String sceneName) { }

	// RVA: 0xFFFFFFFF75C337C8
	public static Scene LoadScene(String sceneName, LoadSceneParameters parameters) { }

	// RVA: 0xFFFFFFFF75C33894
	public static Void LoadScene(Int32 sceneBuildIndex, LoadSceneMode mode) { }

	// RVA: 0xFFFFFFFF75C3394C
	public static Void LoadScene(Int32 sceneBuildIndex) { }

	// RVA: 0xFFFFFFFF75C338D8
	public static Scene LoadScene(Int32 sceneBuildIndex, LoadSceneParameters parameters) { }

	// RVA: 0xFFFFFFFF75C3398C
	public static AsyncOperation LoadSceneAsync(Int32 sceneBuildIndex, LoadSceneMode mode) { }

	// RVA: 0xFFFFFFFF75C33A1C
	public static AsyncOperation LoadSceneAsync(Int32 sceneBuildIndex) { }

	// RVA: 0xFFFFFFFF75C339D0
	public static AsyncOperation LoadSceneAsync(Int32 sceneBuildIndex, LoadSceneParameters parameters) { }

	// RVA: 0xFFFFFFFF75C33A5C
	public static AsyncOperation LoadSceneAsync(String sceneName, LoadSceneMode mode) { }

	// RVA: 0xFFFFFFFF75C33AF0
	public static AsyncOperation LoadSceneAsync(String sceneName) { }

	// RVA: 0xFFFFFFFF75C33AA0
	public static AsyncOperation LoadSceneAsync(String sceneName, LoadSceneParameters parameters) { }

	// RVA: 0xFFFFFFFF75C33B38
	public static Boolean UnloadScene(Int32 sceneBuildIndex) { }

	// RVA: 0xFFFFFFFF75C33B9C
	public static Boolean UnloadScene(String sceneName) { }

	// RVA: 0xFFFFFFFF75C33BFC
	public static AsyncOperation UnloadSceneAsync(Int32 sceneBuildIndex) { }

	// RVA: 0xFFFFFFFF75C33C5C
	public static AsyncOperation UnloadSceneAsync(String sceneName) { }

	// RVA: 0xFFFFFFFF75C33CB8
	public static AsyncOperation UnloadSceneAsync(Scene scene) { }

	// RVA: 0xFFFFFFFF75C33CF8
	public static AsyncOperation UnloadSceneAsync(Int32 sceneBuildIndex, UnloadSceneOptions options) { }

	// RVA: 0xFFFFFFFF75C33D5C
	public static AsyncOperation UnloadSceneAsync(String sceneName, UnloadSceneOptions options) { }

	// RVA: 0xFFFFFFFF75C33DBC
	public static AsyncOperation UnloadSceneAsync(Scene scene, UnloadSceneOptions options) { }

	// RVA: 0xFFFFFFFF723C90EC
	private static Void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0xFFFFFFFF723C9178
	private static Void Internal_SceneUnloaded(Scene scene) { }

	// RVA: 0xFFFFFFFF723C91F8
	private static Void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	// RVA: 0xFFFFFFFF75C33E00
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C33E04
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C32958
	private static Void GetActiveScene_Injected(out Scene ret) { }

	// RVA: 0xFFFFFFFF75C32A00
	private static Boolean SetActiveScene_Injected(ref Scene scene) { }

	// RVA: 0xFFFFFFFF75C32AB4
	private static Void GetSceneByPath_Injected(String scenePath, out Scene ret) { }

	// RVA: 0xFFFFFFFF75C32B78
	private static Void GetSceneByName_Injected(String name, out Scene ret) { }

	// RVA: 0xFFFFFFFF75C32C3C
	private static Void GetSceneByBuildIndex_Injected(Int32 buildIndex, out Scene ret) { }

	// RVA: 0xFFFFFFFF75C32D08
	private static Void GetSceneAt_Injected(Int32 index, out Scene ret) { }

	// RVA: 0xFFFFFFFF75C32DD0
	private static Void CreateScene_Injected(String sceneName, ref CreateSceneParameters parameters, out Scene ret) { }

	// RVA: 0xFFFFFFFF75C32E98
	private static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options) { }

	// RVA: 0xFFFFFFFF75C330E8
	private static Void MergeScenes_Injected(ref Scene sourceScene, ref Scene destinationScene) { }

	// RVA: 0xFFFFFFFF75C331A8
	private static Void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene) { }

}

// Namespace: UnityEngine.SceneManagement
public enum LoadSceneMode
{
	// Fields
	public Int32 value__; // 0x10
	public const LoadSceneMode Single = 0;
	public const LoadSceneMode Additive = 1;
}

// Namespace: UnityEngine.SceneManagement
public enum LocalPhysicsMode
{
	// Fields
	public Int32 value__; // 0x10
	public const LocalPhysicsMode None = 0;
	public const LocalPhysicsMode Physics2D = 1;
	public const LocalPhysicsMode Physics3D = 2;
}

// Namespace: UnityEngine.SceneManagement
public struct LoadSceneParameters
{
	// Fields
	private LoadSceneMode m_LoadSceneMode; // 0x10
	private LocalPhysicsMode m_LocalPhysicsMode; // 0x14

	// Methods

	// RVA: 0xFFFFFFFF7114E82C
	public Void .ctor(LoadSceneMode mode) { }

}

// Namespace: UnityEngine.SceneManagement
public struct CreateSceneParameters
{
	// Fields
	private LocalPhysicsMode m_LocalPhysicsMode; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114E824
	public Void .ctor(LocalPhysicsMode physicsMode) { }

}

// Namespace: UnityEngine.SceneManagement
public enum UnloadSceneOptions
{
	// Fields
	public Int32 value__; // 0x10
	public const UnloadSceneOptions None = 0;
	public const UnloadSceneOptions UnloadAllEmbeddedSceneObjects = 1;
}

// Namespace: UnityEngine.LowLevel
internal struct PlayerLoopSystemInternal
{
	// Fields
	public Type type; // 0x10
	public UpdateFunction updateDelegate; // 0x18
	public IntPtr updateFunction; // 0x20
	public IntPtr loopConditionFunction; // 0x28
	public Int32 numSubSystems; // 0x30
}

// Namespace: UnityEngine.LowLevel
public struct PlayerLoopSystem
{
	// Fields
	public Type type; // 0x10
	public PlayerLoopSystem[] subSystemList; // 0x18
	public UpdateFunction updateDelegate; // 0x20
	public IntPtr updateFunction; // 0x28
	public IntPtr loopConditionFunction; // 0x30
}

// Namespace: 
public sealed class UpdateFunction
{
	// Methods

	// RVA: 0xFFFFFFFF75C0BD88
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF723BD61C
	public virtual Void Invoke() { }

	// RVA: 0xFFFFFFFF75C0BDCC
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75C0BE24
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine.LowLevel
public class PlayerLoop
{
	// Methods

	// RVA: 0xFFFFFFFF75C0BBA0
	public static PlayerLoopSystem GetCurrentPlayerLoop() { }

	// RVA: 0xFFFFFFFF75C0BC44
	public static Void SetPlayerLoop(PlayerLoopSystem loop) { }

	// RVA: 0xFFFFFFFF723BD40C
	private static Int32 PlayerLoopSystemToInternal(PlayerLoopSystem sys, ref List<T0> internalSys) { }

	// RVA: 0xFFFFFFFF723BD18C
	private static PlayerLoopSystem InternalToPlayerLoopSystem(PlayerLoopSystemInternal[] internalSys, ref Int32 offset) { }

	// RVA: 0xFFFFFFFF75C0BC10
	private static PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal() { }

	// RVA: 0xFFFFFFFF75C0BD48
	private static Void SetPlayerLoopInternal(PlayerLoopSystemInternal[] loop) { }

}

// Namespace: UnityEngine.PlayerLoop
public struct Initialization
{}

// Namespace: 
public struct PlayerUpdateTime
{}

// Namespace: 
public struct DirectorSampleTime
{}

// Namespace: 
public struct AsyncUploadTimeSlicedUpdate
{}

// Namespace: 
public struct SynchronizeState
{}

// Namespace: 
public struct SynchronizeInputs
{}

// Namespace: 
public struct XREarlyUpdate
{}

// Namespace: UnityEngine.PlayerLoop
public struct EarlyUpdate
{}

// Namespace: 
public struct PollPlayerConnection
{}

// Namespace: 
public struct ProfilerStartFrame
{}

// Namespace: 
public struct PollHtcsPlayerConnection
{}

// Namespace: 
public struct GpuTimestamp
{}

// Namespace: 
public struct AnalyticsCoreStatsUpdate
{}

// Namespace: 
public struct UnityWebRequestUpdate
{}

// Namespace: 
public struct UpdateStreamingManager
{}

// Namespace: 
public struct ExecuteMainThreadJobs
{}

// Namespace: 
public struct ProcessMouseInWindow
{}

// Namespace: 
public struct ClearIntermediateRenderers
{}

// Namespace: 
public struct ClearLines
{}

// Namespace: 
public struct PresentBeforeUpdate
{}

// Namespace: 
public struct ResetFrameStatsAfterPresent
{}

// Namespace: 
public struct UpdateAsyncReadbackManager
{}

// Namespace: 
public struct UpdateTextureStreamingManager
{}

// Namespace: 
public struct UpdatePreloading
{}

// Namespace: 
public struct RendererNotifyInvisible
{}

// Namespace: 
public struct PlayerCleanupCachedData
{}

// Namespace: 
public struct UpdateMainGameViewRect
{}

// Namespace: 
public struct UpdateCanvasRectTransform
{}

// Namespace: 
public struct UpdateInputManager
{}

// Namespace: 
public struct ProcessRemoteInput
{}

// Namespace: 
public struct XRUpdate
{}

// Namespace: 
public struct ScriptRunDelayedStartupFrame
{}

// Namespace: 
public struct UpdateKinect
{}

// Namespace: 
public struct DeliverIosPlatformEvents
{}

// Namespace: 
public struct DispatchEventQueueEvents
{}

// Namespace: 
public struct PhysicsResetInterpolatedTransformPosition
{}

// Namespace: 
public struct SpriteAtlasManagerUpdate
{}

// Namespace: 
public struct TangoUpdate
{}

// Namespace: 
public struct PerformanceAnalyticsUpdate
{}

// Namespace: UnityEngine.PlayerLoop
public struct FixedUpdate
{}

// Namespace: 
public struct ClearLines
{}

// Namespace: 
public struct DirectorFixedSampleTime
{}

// Namespace: 
public struct AudioFixedUpdate
{}

// Namespace: 
public struct ScriptRunBehaviourFixedUpdate
{}

// Namespace: 
public struct DirectorFixedUpdate
{}

// Namespace: 
public struct LegacyFixedAnimationUpdate
{}

// Namespace: 
public struct XRFixedUpdate
{}

// Namespace: 
public struct PhysicsFixedUpdate
{}

// Namespace: 
public struct Physics2DFixedUpdate
{}

// Namespace: 
private struct PhysicsClothFixedUpdate
{}

// Namespace: 
public struct DirectorFixedUpdatePostPhysics
{}

// Namespace: 
public struct ScriptRunDelayedFixedFrameRate
{}

// Namespace: 
public struct NewInputFixedUpdate
{}

// Namespace: UnityEngine.PlayerLoop
public struct PreUpdate
{}

// Namespace: 
public struct PhysicsUpdate
{}

// Namespace: 
public struct Physics2DUpdate
{}

// Namespace: 
public struct CheckTexFieldInput
{}

// Namespace: 
public struct IMGUISendQueuedEvents
{}

// Namespace: 
public struct SendMouseEvents
{}

// Namespace: 
public struct AIUpdate
{}

// Namespace: 
public struct WindUpdate
{}

// Namespace: 
public struct UpdateVideo
{}

// Namespace: 
public struct NewInputUpdate
{}

// Namespace: UnityEngine.PlayerLoop
public struct Update
{}

// Namespace: 
public struct ScriptRunBehaviourUpdate
{}

// Namespace: 
public struct DirectorUpdate
{}

// Namespace: 
public struct ScriptRunDelayedDynamicFrameRate
{}

// Namespace: 
public struct ScriptRunDelayedTasks
{}

// Namespace: UnityEngine.PlayerLoop
public struct PreLateUpdate
{}

// Namespace: 
public struct AIUpdatePostScript
{}

// Namespace: 
public struct DirectorUpdateAnimationBegin
{}

// Namespace: 
public struct LegacyAnimationUpdate
{}

// Namespace: 
public struct DirectorUpdateAnimationEnd
{}

// Namespace: 
public struct DirectorDeferredEvaluate
{}

// Namespace: 
public struct UpdateNetworkManager
{}

// Namespace: 
public struct UpdateMasterServerInterface
{}

// Namespace: 
public struct UNetUpdate
{}

// Namespace: 
public struct EndGraphicsJobsAfterScriptUpdate
{}

// Namespace: 
public struct ParticleSystemBeginUpdateAll
{}

// Namespace: 
public struct ScriptRunBehaviourLateUpdate
{}

// Namespace: 
public struct ConstraintManagerUpdate
{}

// Namespace: UnityEngine.PlayerLoop
public struct PostLateUpdate
{}

// Namespace: 
public struct PlayerSendFrameStarted
{}

// Namespace: 
public struct UpdateRectTransform
{}

// Namespace: 
public struct UpdateCanvasRectTransform
{}

// Namespace: 
public struct PlayerUpdateCanvases
{}

// Namespace: 
public struct UpdateAudio
{}

// Namespace: 
public struct UpdateVideo
{}

// Namespace: 
public struct DirectorLateUpdate
{}

// Namespace: 
public struct ScriptRunDelayedDynamicFrameRate
{}

// Namespace: 
public struct VFXUpdate
{}

// Namespace: 
public struct ParticleSystemEndUpdateAll
{}

// Namespace: 
public struct EndGraphicsJobsAfterScriptLateUpdate
{}

// Namespace: 
public struct UpdateSubstance
{}

// Namespace: 
public struct UpdateCustomRenderTextures
{}

// Namespace: 
public struct UpdateAllRenderers
{}

// Namespace: 
public struct EnlightenRuntimeUpdate
{}

// Namespace: 
public struct UpdateAllSkinnedMeshes
{}

// Namespace: 
public struct ProcessWebSendMessages
{}

// Namespace: 
public struct SortingGroupsUpdate
{}

// Namespace: 
public struct UpdateVideoTextures
{}

// Namespace: 
public struct DirectorRenderImage
{}

// Namespace: 
public struct PlayerEmitCanvasGeometry
{}

// Namespace: 
public struct FinishFrameRendering
{}

// Namespace: 
public struct BatchModeUpdate
{}

// Namespace: 
public struct PlayerSendFrameComplete
{}

// Namespace: 
public struct UpdateCaptureScreenshot
{}

// Namespace: 
public struct PresentAfterDraw
{}

// Namespace: 
public struct ClearImmediateRenderers
{}

// Namespace: 
public struct XRPostPresent
{}

// Namespace: 
public struct UpdateResolution
{}

// Namespace: 
public struct InputEndFrame
{}

// Namespace: 
public struct GUIClearEvents
{}

// Namespace: 
public struct ShaderHandleErrors
{}

// Namespace: 
public struct ResetInputAxis
{}

// Namespace: 
public struct ThreadedLoadingDebug
{}

// Namespace: 
public struct ProfilerSynchronizeStats
{}

// Namespace: 
public struct MemoryFrameMaintenance
{}

// Namespace: 
public struct ExecuteGameCenterCallbacks
{}

// Namespace: 
public struct ProfilerEndFrame
{}

// Namespace: 
public struct PlayerSendFramePostPresent
{}

// Namespace: 
public struct PhysicsSkinnedClothBeginUpdate
{}

// Namespace: 
public struct PhysicsSkinnedClothFinishUpdate
{}

// Namespace: 
public struct TriggerEndOfFrameCallbacks
{}

// Namespace: UnityEngine.Networking.PlayerConnection
public class MessageEventArgs
{
	// Fields
	public Int32 playerId; // 0x10
	public Byte[] data; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75C19758
	public Void .ctor() { }

}

// Namespace: UnityEngine.Networking.PlayerConnection
public class PlayerConnection
{
	// Fields
	internal static IPlayerEditorConnectionNative connectionNative; // 0x0
	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; // 0x18
	private List<T0> m_connectedPlayers; // 0x20
	private Boolean m_IsInitilized; // 0x28
	private static PlayerConnection s_Instance; // 0x8

	// Properties
	public static PlayerConnection instance { get; }
	public Boolean isConnected { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C1975C
	public static PlayerConnection get_instance() { }

	// RVA: 0xFFFFFFFF75C197CC
	public Boolean get_isConnected() { }

	// RVA: 0xFFFFFFFF723C2294
	private static PlayerConnection CreateInstance() { }

	// RVA: 0xFFFFFFFF75C19924
	public Void OnEnable() { }

	// RVA: 0xFFFFFFFF75C19884
	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	// RVA: 0xFFFFFFFF75C19A08
	public Void Register(Guid messageId, UnityAction<T0> callback) { }

	// RVA: 0xFFFFFFFF75C19F18
	public Void Unregister(Guid messageId, UnityAction<T0> callback) { }

	// RVA: 0xFFFFFFFF75C1A2E8
	public Void RegisterConnection(UnityAction<T0> callback) { }

	// RVA: 0xFFFFFFFF75C1A430
	public Void RegisterDisconnection(UnityAction<T0> callback) { }

	// RVA: 0xFFFFFFFF75C1A4A4
	public Void UnregisterConnection(UnityAction<T0> callback) { }

	// RVA: 0xFFFFFFFF75C1A518
	public Void UnregisterDisconnection(UnityAction<T0> callback) { }

	// RVA: 0xFFFFFFFF75C1A58C
	public Void Send(Guid messageId, Byte[] data) { }

	// RVA: 0xFFFFFFFF75C1A708
	public Boolean TrySend(Guid messageId, Byte[] data) { }

	// RVA: 0xFFFFFFFF75C1A884
	public Boolean BlockUntilRecvMsg(Guid messageId, Int32 timeout) { }

	// RVA: 0xFFFFFFFF75C1AACC
	public Void DisconnectAll() { }

	// RVA: 0xFFFFFFFF75C1AB84
	private static Void MessageCallbackInternal(IntPtr data, UInt64 size, UInt64 guid, String messageId) { }

	// RVA: 0xFFFFFFFF75C1B118
	private static Void ConnectedCallbackInternal(Int32 playerId) { }

	// RVA: 0xFFFFFFFF75C1B1AC
	private static Void DisconnectedCallback(Int32 playerId) { }

	// RVA: 0xFFFFFFFF75C1B240
	public Void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass12_0
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C19CAC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C1B498
	internal Boolean <Register>b__0(MessageTypeSubscribers x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C1A114
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C1B54C
	internal Boolean <Unregister>b__0(MessageTypeSubscribers x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass20_0
{
	// Fields
	public Boolean msgReceived; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C1AAC8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C1B5D0
	internal Void <BlockUntilRecvMsg>b__0(MessageEventArgs args) { }

}

// Namespace: UnityEngine.Networking.PlayerConnection
internal class PlayerEditorConnectionEvents
{
	// Fields
	public List<T0> messageTypeSubscribers; // 0x10
	public ConnectionChangeEvent connectionEvent; // 0x18
	public ConnectionChangeEvent disconnectionEvent; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75C1AC88
	public Void InvokeMessageIdSubscribers(Guid messageId, Byte[] data, Int32 playerId) { }

	// RVA: 0xFFFFFFFF75C19CB0
	public UnityEvent<T0> AddAndCreate(Guid messageId) { }

	// RVA: 0xFFFFFFFF75C1A118
	public Void UnregisterManagedCallback(Guid messageId, UnityAction<T0> callback) { }

	// RVA: 0xFFFFFFFF75C1B304
	public Void .ctor() { }

}

// Namespace: 
public class MessageEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C1B6F4
	public Void .ctor() { }

}

// Namespace: 
public class ConnectionChangeEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C1B754
	public Void .ctor() { }

}

// Namespace: 
public class MessageTypeSubscribers
{
	// Fields
	private String m_messageTypeId; // 0x10
	public Int32 subscriberCount; // 0x18
	public MessageEvent messageCallback; // 0x20

	// Properties
	public Guid MessageTypeId { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C1B51C
	public Guid get_MessageTypeId() { }

	// RVA: 0xFFFFFFFF75C1B6A8
	public Void set_MessageTypeId(Guid value) { }

	// RVA: 0xFFFFFFFF75C1B5E4
	public Void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C1B5DC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C1B7B0
	internal Boolean <InvokeMessageIdSubscribers>b__0(MessageTypeSubscribers x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C1B5E0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C1B834
	internal Boolean <AddAndCreate>b__0(MessageTypeSubscribers x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C1B750
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C1B8B8
	internal Boolean <UnregisterManagedCallback>b__0(MessageTypeSubscribers x) { }

}

// Namespace: UnityEngine.Internal
public class DefaultValueAttribute
{
	// Fields
	private Object DefaultValue; // 0x10

	// Properties
	public Object Value { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C05F28
	public Void .ctor(String value) { }

	// RVA: 0xFFFFFFFF75C05F6C
	public Object get_Value() { }

	// RVA: 0xFFFFFFFF75C05F74
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75C06038
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine.Internal
public class ExcludeFromDocsAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75C06060
	public Void .ctor() { }

}

// Namespace: UnityEngine.Rendering
public enum IndexFormat
{
	// Fields
	public Int32 value__; // 0x10
	public const IndexFormat UInt16 = 0;
	public const IndexFormat UInt32 = 1;
}

// Namespace: UnityEngine.Rendering
public enum MeshUpdateFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const MeshUpdateFlags Default = 0;
	public const MeshUpdateFlags DontValidateIndices = 1;
	public const MeshUpdateFlags DontResetBoneBounds = 2;
	public const MeshUpdateFlags DontNotifyMeshUsers = 4;
	public const MeshUpdateFlags DontRecalculateBounds = 8;
}

// Namespace: UnityEngine.Rendering
public enum VertexAttributeFormat
{
	// Fields
	public Int32 value__; // 0x10
	public const VertexAttributeFormat Float32 = 0;
	public const VertexAttributeFormat Float16 = 1;
	public const VertexAttributeFormat UNorm8 = 2;
	public const VertexAttributeFormat SNorm8 = 3;
	public const VertexAttributeFormat UNorm16 = 4;
	public const VertexAttributeFormat SNorm16 = 5;
	public const VertexAttributeFormat UInt8 = 6;
	public const VertexAttributeFormat SInt8 = 7;
	public const VertexAttributeFormat UInt16 = 8;
	public const VertexAttributeFormat SInt16 = 9;
	public const VertexAttributeFormat UInt32 = 10;
	public const VertexAttributeFormat SInt32 = 11;
}

// Namespace: UnityEngine.Rendering
public enum VertexAttribute
{
	// Fields
	public Int32 value__; // 0x10
	public const VertexAttribute Position = 0;
	public const VertexAttribute Normal = 1;
	public const VertexAttribute Tangent = 2;
	public const VertexAttribute Color = 3;
	public const VertexAttribute TexCoord0 = 4;
	public const VertexAttribute TexCoord1 = 5;
	public const VertexAttribute TexCoord2 = 6;
	public const VertexAttribute TexCoord3 = 7;
	public const VertexAttribute TexCoord4 = 8;
	public const VertexAttribute TexCoord5 = 9;
	public const VertexAttribute TexCoord6 = 10;
	public const VertexAttribute TexCoord7 = 11;
	public const VertexAttribute BlendWeight = 12;
	public const VertexAttribute BlendIndices = 13;
}

// Namespace: UnityEngine.Rendering
public enum OpaqueSortMode
{
	// Fields
	public Int32 value__; // 0x10
	public const OpaqueSortMode Default = 0;
	public const OpaqueSortMode FrontToBack = 1;
	public const OpaqueSortMode NoDistanceSort = 2;
}

// Namespace: UnityEngine.Rendering
public enum RenderBufferLoadAction
{
	// Fields
	public Int32 value__; // 0x10
	public const RenderBufferLoadAction Load = 0;
	public const RenderBufferLoadAction Clear = 1;
	public const RenderBufferLoadAction DontCare = 2;
}

// Namespace: UnityEngine.Rendering
public enum RenderBufferStoreAction
{
	// Fields
	public Int32 value__; // 0x10
	public const RenderBufferStoreAction Store = 0;
	public const RenderBufferStoreAction Resolve = 1;
	public const RenderBufferStoreAction StoreAndResolve = 2;
	public const RenderBufferStoreAction DontCare = 3;
}

// Namespace: UnityEngine.Rendering
public enum CompareFunction
{
	// Fields
	public Int32 value__; // 0x10
	public const CompareFunction Disabled = 0;
	public const CompareFunction Never = 1;
	public const CompareFunction Less = 2;
	public const CompareFunction Equal = 3;
	public const CompareFunction LessEqual = 4;
	public const CompareFunction Greater = 5;
	public const CompareFunction NotEqual = 6;
	public const CompareFunction GreaterEqual = 7;
	public const CompareFunction Always = 8;
}

// Namespace: UnityEngine.Rendering
public enum CullMode
{
	// Fields
	public Int32 value__; // 0x10
	public const CullMode Off = 0;
	public const CullMode Front = 1;
	public const CullMode Back = 2;
}

// Namespace: UnityEngine.Rendering
public enum ColorWriteMask
{
	// Fields
	public Int32 value__; // 0x10
	public const ColorWriteMask Alpha = 1;
	public const ColorWriteMask Blue = 2;
	public const ColorWriteMask Green = 4;
	public const ColorWriteMask Red = 8;
	public const ColorWriteMask All = 15;
}

// Namespace: UnityEngine.Rendering
public enum StencilOp
{
	// Fields
	public Int32 value__; // 0x10
	public const StencilOp Keep = 0;
	public const StencilOp Zero = 1;
	public const StencilOp Replace = 2;
	public const StencilOp IncrementSaturate = 3;
	public const StencilOp DecrementSaturate = 4;
	public const StencilOp Invert = 5;
	public const StencilOp IncrementWrap = 6;
	public const StencilOp DecrementWrap = 7;
}

// Namespace: UnityEngine.Rendering
public enum AmbientMode
{
	// Fields
	public Int32 value__; // 0x10
	public const AmbientMode Skybox = 0;
	public const AmbientMode Trilight = 1;
	public const AmbientMode Flat = 3;
	public const AmbientMode Custom = 4;
}

// Namespace: UnityEngine.Rendering
public enum DefaultReflectionMode
{
	// Fields
	public Int32 value__; // 0x10
	public const DefaultReflectionMode Skybox = 0;
	public const DefaultReflectionMode Custom = 1;
}

// Namespace: UnityEngine.Rendering
public enum CameraEvent
{
	// Fields
	public Int32 value__; // 0x10
	public const CameraEvent BeforeDepthTexture = 0;
	public const CameraEvent AfterDepthTexture = 1;
	public const CameraEvent BeforeDepthNormalsTexture = 2;
	public const CameraEvent AfterDepthNormalsTexture = 3;
	public const CameraEvent BeforeGBuffer = 4;
	public const CameraEvent AfterGBuffer = 5;
	public const CameraEvent BeforeLighting = 6;
	public const CameraEvent AfterLighting = 7;
	public const CameraEvent BeforeFinalPass = 8;
	public const CameraEvent AfterFinalPass = 9;
	public const CameraEvent BeforeForwardOpaque = 10;
	public const CameraEvent AfterForwardOpaque = 11;
	public const CameraEvent BeforeImageEffectsOpaque = 12;
	public const CameraEvent AfterImageEffectsOpaque = 13;
	public const CameraEvent BeforeSkybox = 14;
	public const CameraEvent AfterSkybox = 15;
	public const CameraEvent BeforeForwardAlpha = 16;
	public const CameraEvent AfterForwardAlpha = 17;
	public const CameraEvent BeforeImageEffects = 18;
	public const CameraEvent AfterImageEffects = 19;
	public const CameraEvent AfterEverything = 20;
	public const CameraEvent BeforeReflections = 21;
	public const CameraEvent AfterReflections = 22;
	public const CameraEvent BeforeHaloAndLensFlares = 23;
	public const CameraEvent AfterHaloAndLensFlares = 24;
}

// Namespace: UnityEngine.Rendering
internal static class CameraEventUtils
{
	// Methods

	// RVA: 0xFFFFFFFF723C75F4
	public static Boolean IsValid(CameraEvent value) { }

}

// Namespace: UnityEngine.Rendering
public enum LightEvent
{
	// Fields
	public Int32 value__; // 0x10
	public const LightEvent BeforeShadowMap = 0;
	public const LightEvent AfterShadowMap = 1;
	public const LightEvent BeforeScreenspaceMask = 2;
	public const LightEvent AfterScreenspaceMask = 3;
	public const LightEvent BeforeShadowMapPass = 4;
	public const LightEvent AfterShadowMapPass = 5;
}

// Namespace: UnityEngine.Rendering
public enum ShadowMapPass
{
	// Fields
	public Int32 value__; // 0x10
	public const ShadowMapPass PointlightPositiveX = 1;
	public const ShadowMapPass PointlightNegativeX = 2;
	public const ShadowMapPass PointlightPositiveY = 4;
	public const ShadowMapPass PointlightNegativeY = 8;
	public const ShadowMapPass PointlightPositiveZ = 16;
	public const ShadowMapPass PointlightNegativeZ = 32;
	public const ShadowMapPass DirectionalCascade0 = 64;
	public const ShadowMapPass DirectionalCascade1 = 128;
	public const ShadowMapPass DirectionalCascade2 = 256;
	public const ShadowMapPass DirectionalCascade3 = 512;
	public const ShadowMapPass Spotlight = 1024;
	public const ShadowMapPass Pointlight = 63;
	public const ShadowMapPass Directional = 960;
	public const ShadowMapPass All = 2047;
}

// Namespace: UnityEngine.Rendering
public enum BuiltinRenderTextureType
{
	// Fields
	public Int32 value__; // 0x10
	public const BuiltinRenderTextureType PropertyName = 4294967292;
	public const BuiltinRenderTextureType BufferPtr = 4294967293;
	public const BuiltinRenderTextureType RenderTexture = 4294967294;
	public const BuiltinRenderTextureType BindableTexture = 4294967295;
	public const BuiltinRenderTextureType None = 0;
	public const BuiltinRenderTextureType CurrentActive = 1;
	public const BuiltinRenderTextureType CameraTarget = 2;
	public const BuiltinRenderTextureType Depth = 3;
	public const BuiltinRenderTextureType DepthNormals = 4;
	public const BuiltinRenderTextureType ResolvedDepth = 5;
	public const BuiltinRenderTextureType PrepassNormalsSpec = 7;
	public const BuiltinRenderTextureType PrepassLight = 8;
	public const BuiltinRenderTextureType PrepassLightSpec = 9;
	public const BuiltinRenderTextureType GBuffer0 = 10;
	public const BuiltinRenderTextureType GBuffer1 = 11;
	public const BuiltinRenderTextureType GBuffer2 = 12;
	public const BuiltinRenderTextureType GBuffer3 = 13;
	public const BuiltinRenderTextureType Reflections = 14;
	public const BuiltinRenderTextureType MotionVectors = 15;
	public const BuiltinRenderTextureType GBuffer4 = 16;
	public const BuiltinRenderTextureType GBuffer5 = 17;
	public const BuiltinRenderTextureType GBuffer6 = 18;
	public const BuiltinRenderTextureType GBuffer7 = 19;
}

// Namespace: UnityEngine.Rendering
public enum PassType
{
	// Fields
	public Int32 value__; // 0x10
	public const PassType Normal = 0;
	public const PassType Vertex = 1;
	public const PassType VertexLM = 2;
	public const PassType VertexLMRGBM = 3;
	public const PassType ForwardBase = 4;
	public const PassType ForwardAdd = 5;
	public const PassType LightPrePassBase = 6;
	public const PassType LightPrePassFinal = 7;
	public const PassType ShadowCaster = 8;
	public const PassType Deferred = 10;
	public const PassType Meta = 11;
	public const PassType MotionVectors = 12;
	public const PassType ScriptableRenderPipeline = 13;
	public const PassType ScriptableRenderPipelineDefaultUnlit = 14;
}

// Namespace: UnityEngine.Rendering
public enum ShadowCastingMode
{
	// Fields
	public Int32 value__; // 0x10
	public const ShadowCastingMode Off = 0;
	public const ShadowCastingMode On = 1;
	public const ShadowCastingMode TwoSided = 2;
	public const ShadowCastingMode ShadowsOnly = 3;
}

// Namespace: UnityEngine.Rendering
public enum LightShadowResolution
{
	// Fields
	public Int32 value__; // 0x10
	public const LightShadowResolution FromQualitySettings = 4294967295;
	public const LightShadowResolution Low = 0;
	public const LightShadowResolution Medium = 1;
	public const LightShadowResolution High = 2;
	public const LightShadowResolution VeryHigh = 3;
}

// Namespace: UnityEngine.Rendering
public enum GraphicsDeviceType
{
	// Fields
	public Int32 value__; // 0x10
	public const GraphicsDeviceType OpenGL2 = 0;
	public const GraphicsDeviceType Direct3D9 = 1;
	public const GraphicsDeviceType Direct3D11 = 2;
	public const GraphicsDeviceType PlayStation3 = 3;
	public const GraphicsDeviceType Null = 4;
	public const GraphicsDeviceType Xbox360 = 6;
	public const GraphicsDeviceType OpenGLES2 = 8;
	public const GraphicsDeviceType OpenGLES3 = 11;
	public const GraphicsDeviceType PlayStationVita = 12;
	public const GraphicsDeviceType PlayStation4 = 13;
	public const GraphicsDeviceType XboxOne = 14;
	public const GraphicsDeviceType PlayStationMobile = 15;
	public const GraphicsDeviceType Metal = 16;
	public const GraphicsDeviceType OpenGLCore = 17;
	public const GraphicsDeviceType Direct3D12 = 18;
	public const GraphicsDeviceType N3DS = 19;
	public const GraphicsDeviceType Vulkan = 21;
	public const GraphicsDeviceType Switch = 22;
	public const GraphicsDeviceType XboxOneD3D12 = 23;
	public const GraphicsDeviceType GameCoreXboxOne = 24;
	public const GraphicsDeviceType GameCoreScarlett = 25;
	public const GraphicsDeviceType GameCoreXboxSeries = 25;
	public const GraphicsDeviceType PlayStation5 = 26;
}

// Namespace: UnityEngine.Rendering
public enum GraphicsTier
{
	// Fields
	public Int32 value__; // 0x10
	public const GraphicsTier Tier1 = 0;
	public const GraphicsTier Tier2 = 1;
	public const GraphicsTier Tier3 = 2;
}

// Namespace: UnityEngine.Rendering
public struct SubMeshDescriptor
{
	// Fields
	private Bounds <bounds>k__BackingField; // 0x10
	private MeshTopology <topology>k__BackingField; // 0x28
	private Int32 <indexStart>k__BackingField; // 0x2C
	private Int32 <indexCount>k__BackingField; // 0x30
	private Int32 <baseVertex>k__BackingField; // 0x34
	private Int32 <firstVertex>k__BackingField; // 0x38
	private Int32 <vertexCount>k__BackingField; // 0x3C

	// Properties
	public Bounds bounds { get; set; }
	public MeshTopology topology { get; set; }
	public Int32 indexStart { get; set; }
	public Int32 indexCount { get; set; }
	public Int32 baseVertex { get; set; }
	public Int32 firstVertex { get; set; }
	public Int32 vertexCount { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF7114E640
	public Void .ctor(Int32 indexStart, Int32 indexCount, MeshTopology topology) { }

	// RVA: 0xFFFFFFFF7114E658
	public Bounds get_bounds() { }

	// RVA: 0xFFFFFFFF7114E66C
	public Void set_bounds(Bounds value) { }

	// RVA: 0xFFFFFFFF7114E680
	public MeshTopology get_topology() { }

	// RVA: 0xFFFFFFFF7114E688
	public Void set_topology(MeshTopology value) { }

	// RVA: 0xFFFFFFFF7114E690
	public Int32 get_indexStart() { }

	// RVA: 0xFFFFFFFF7114E698
	public Void set_indexStart(Int32 value) { }

	// RVA: 0xFFFFFFFF7114E6A0
	public Int32 get_indexCount() { }

	// RVA: 0xFFFFFFFF7114E6A8
	public Void set_indexCount(Int32 value) { }

	// RVA: 0xFFFFFFFF7114E6B0
	public Int32 get_baseVertex() { }

	// RVA: 0xFFFFFFFF7114E6B8
	public Void set_baseVertex(Int32 value) { }

	// RVA: 0xFFFFFFFF7114E6C0
	public Int32 get_firstVertex() { }

	// RVA: 0xFFFFFFFF7114E6C8
	public Void set_firstVertex(Int32 value) { }

	// RVA: 0xFFFFFFFF7114E6D0
	public Int32 get_vertexCount() { }

	// RVA: 0xFFFFFFFF7114E6D8
	public Void set_vertexCount(Int32 value) { }

	// RVA: 0xFFFFFFFF7114E6E0
	public override String ToString() { }

}

// Namespace: UnityEngine.Rendering
public struct VertexAttributeDescriptor
{
	// Fields
	private VertexAttribute <attribute>k__BackingField; // 0x10
	private VertexAttributeFormat <format>k__BackingField; // 0x14
	private Int32 <dimension>k__BackingField; // 0x18
	private Int32 <stream>k__BackingField; // 0x1C
	private Int32 <inputSlotClass>k__BackingField; // 0x20
	private Int32 <instanceDataStepRate>k__BackingField; // 0x24

	// Properties
	public VertexAttribute attribute { get; set; }
	public VertexAttributeFormat format { get; set; }
	public Int32 dimension { get; set; }
	public Int32 stream { get; set; }
	public Int32 inputSlotClass { set; }
	public Int32 instanceDataStepRate { set; }

	// Methods

	// RVA: 0xFFFFFFFF7114E6E8
	public VertexAttribute get_attribute() { }

	// RVA: 0xFFFFFFFF7114E6F0
	public Void set_attribute(VertexAttribute value) { }

	// RVA: 0xFFFFFFFF7114E6F8
	public VertexAttributeFormat get_format() { }

	// RVA: 0xFFFFFFFF7114E700
	public Void set_format(VertexAttributeFormat value) { }

	// RVA: 0xFFFFFFFF7114E708
	public Int32 get_dimension() { }

	// RVA: 0xFFFFFFFF7114E710
	public Void set_dimension(Int32 value) { }

	// RVA: 0xFFFFFFFF7114E718
	public Int32 get_stream() { }

	// RVA: 0xFFFFFFFF7114E720
	public Void set_stream(Int32 value) { }

	// RVA: 0xFFFFFFFF7114E728
	public Void set_inputSlotClass(Int32 value) { }

	// RVA: 0xFFFFFFFF7114E730
	public Void set_instanceDataStepRate(Int32 value) { }

	// RVA: 0xFFFFFFFF7114E738
	public Void .ctor(VertexAttribute attribute, VertexAttributeFormat format, Int32 dimension, Int32 stream, Int32 inputSlotClass, Int32 instanceDataStepRate) { }

	// RVA: 0xFFFFFFFF7114E748
	public override String ToString() { }

	// RVA: 0xFFFFFFFF7114E750
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114E774
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF7114E77C
	public Boolean Equals(VertexAttributeDescriptor other) { }

}

// Namespace: UnityEngine.Rendering
public struct RenderTargetIdentifier
{
	// Fields
	private BuiltinRenderTextureType m_Type; // 0x10
	private Int32 m_NameID; // 0x14
	private Int32 m_InstanceID; // 0x18
	private IntPtr m_BufferPointer; // 0x20
	private Int32 m_MipLevel; // 0x28
	private CubemapFace m_CubeFace; // 0x2C
	private Int32 m_DepthSlice; // 0x30

	// Methods

	// RVA: 0xFFFFFFFF7114E0CC
	public Void .ctor(BuiltinRenderTextureType type) { }

	// RVA: 0xFFFFFFFF7114E0EC
	public Void .ctor(Int32 nameID) { }

	// RVA: 0xFFFFFFFF7114E10C
	public Void .ctor(RenderTargetIdentifier renderTargetIdentifier, Int32 mipLevel, CubemapFace cubeFace, Int32 depthSlice) { }

	// RVA: 0xFFFFFFFF7114E130
	public Void .ctor(Texture tex) { }

	// RVA: 0xFFFFFFFF7114E138
	public Void .ctor(RenderBuffer buf, Int32 mipLevel, CubemapFace cubeFace, Int32 depthSlice) { }

	// RVA: 0xFFFFFFFF723C8B48
	public static RenderTargetIdentifier op_Implicit(BuiltinRenderTextureType type) { }

	// RVA: 0xFFFFFFFF723C8B68
	public static RenderTargetIdentifier op_Implicit(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C2FBE8
	public static RenderTargetIdentifier op_Implicit(Texture tex) { }

	// RVA: 0xFFFFFFFF75C2FC34
	public static RenderTargetIdentifier op_Implicit(RenderBuffer buf) { }

	// RVA: 0xFFFFFFFF7114E158
	public override String ToString() { }

	// RVA: 0xFFFFFFFF7114E160
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114E1BC
	public Boolean Equals(RenderTargetIdentifier rhs) { }

	// RVA: 0xFFFFFFFF7114E1F0
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF723C8C04
	public static Boolean op_Equality(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs) { }

}

// Namespace: UnityEngine.Rendering
public enum ReflectionProbeUsage
{
	// Fields
	public Int32 value__; // 0x10
	public const ReflectionProbeUsage Off = 0;
	public const ReflectionProbeUsage BlendProbes = 1;
	public const ReflectionProbeUsage BlendProbesAndSkybox = 2;
	public const ReflectionProbeUsage Simple = 3;
}

// Namespace: UnityEngine.Rendering
public struct ReflectionProbeBlendInfo
{
	// Fields
	public ReflectionProbe probe; // 0x10
	public Single weight; // 0x18
}

// Namespace: UnityEngine.Rendering
public enum ShadowSamplingMode
{
	// Fields
	public Int32 value__; // 0x10
	public const ShadowSamplingMode CompareDepths = 0;
	public const ShadowSamplingMode RawDepth = 1;
	public const ShadowSamplingMode None = 2;
}

// Namespace: UnityEngine.Rendering
public enum LightProbeUsage
{
	// Fields
	public Int32 value__; // 0x10
	public const LightProbeUsage Off = 0;
	public const LightProbeUsage BlendProbes = 1;
	public const LightProbeUsage UseProxyVolume = 2;
	public const LightProbeUsage CustomProvided = 4;
}

// Namespace: UnityEngine.Rendering
public enum TextureDimension
{
	// Fields
	public Int32 value__; // 0x10
	public const TextureDimension Unknown = 4294967295;
	public const TextureDimension None = 0;
	public const TextureDimension Any = 1;
	public const TextureDimension Tex2D = 2;
	public const TextureDimension Tex3D = 3;
	public const TextureDimension Cube = 4;
	public const TextureDimension Tex2DArray = 5;
	public const TextureDimension CubeArray = 6;
}

// Namespace: UnityEngine.Rendering
public enum CopyTextureSupport
{
	// Fields
	public Int32 value__; // 0x10
	public const CopyTextureSupport None = 0;
	public const CopyTextureSupport Basic = 1;
	public const CopyTextureSupport Copy3D = 2;
	public const CopyTextureSupport DifferentTypes = 4;
	public const CopyTextureSupport TextureToRT = 8;
	public const CopyTextureSupport RTToTexture = 16;
}

// Namespace: UnityEngine.Rendering
public enum ComputeQueueType
{
	// Fields
	public Int32 value__; // 0x10
	public const ComputeQueueType Default = 0;
	public const ComputeQueueType Background = 1;
	public const ComputeQueueType Urgent = 2;
}

// Namespace: UnityEngine.Rendering
public enum CommandBufferExecutionFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const CommandBufferExecutionFlags None = 0;
	public const CommandBufferExecutionFlags AsyncCompute = 2;
}

// Namespace: UnityEngine.Rendering
public enum RenderTextureSubElement
{
	// Fields
	public Int32 value__; // 0x10
	public const RenderTextureSubElement Color = 0;
	public const RenderTextureSubElement Depth = 1;
	public const RenderTextureSubElement Stencil = 2;
	public const RenderTextureSubElement Default = 3;
}

// Namespace: UnityEngine.Rendering
public enum RenderingThreadingMode
{
	// Fields
	public Int32 value__; // 0x10
	public const RenderingThreadingMode Direct = 0;
	public const RenderingThreadingMode SingleThreaded = 1;
	public const RenderingThreadingMode MultiThreaded = 2;
	public const RenderingThreadingMode LegacyJobified = 3;
	public const RenderingThreadingMode NativeGraphicsJobs = 4;
	public const RenderingThreadingMode NativeGraphicsJobsWithoutRenderThread = 5;
}

// Namespace: UnityEngine.Rendering
public sealed class GraphicsSettings
{
	// Properties
	public static Boolean lightsUseLinearIntensity { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C2E16C
	public static Boolean get_lightsUseLinearIntensity() { }

	// RVA: 0xFFFFFFFF75C2E1A0
	internal static Boolean AllowEnlightenSupportForUpgradedProject() { }

}

// Namespace: UnityEngine.Rendering
public class OnDemandRendering
{
	// Fields
	private static Int32 m_RenderFrameInterval; // 0x0

	// Properties
	public static Int32 renderFrameInterval { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C2E370
	public static Int32 get_renderFrameInterval() { }

	// RVA: 0xFFFFFFFF723C8610
	internal static Void GetRenderFrameInterval(out Int32 frameInterval) { }

	// RVA: 0xFFFFFFFF75C2E3B0
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public class CommandBuffer
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public String name { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C2B894
	private static IntPtr InitBuffer() { }

	// RVA: 0xFFFFFFFF75C2B8C8
	private Void ReleaseBuffer() { }

	// RVA: 0xFFFFFFFF723C7600
	public Void set_name(String value) { }

	// RVA: 0xFFFFFFFF723C7654
	public Void Clear() { }

	// RVA: 0xFFFFFFFF75C2B908
	private Void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, Int32 submeshIndex, Int32 shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0xFFFFFFFF75C2BA18
	private Void Internal_DrawRenderer(Renderer renderer, Material material, Int32 submeshIndex, Int32 shaderPass) { }

	// RVA: 0xFFFFFFFF75C2BA88
	private Void Internal_DrawMeshInstanced(Mesh mesh, Int32 submeshIndex, Material material, Int32 shaderPass, Matrix4x4[] matrices, Int32 count, MaterialPropertyBlock properties) { }

	// RVA: 0xFFFFFFFF723C76A8
	public Void SetViewport(Rect pixelRect) { }

	// RVA: 0xFFFFFFFF75C2BB70
	private Void CopyTexture_Internal(ref RenderTargetIdentifier src, Int32 srcElement, Int32 srcMip, Int32 srcX, Int32 srcY, Int32 srcWidth, Int32 srcHeight, ref RenderTargetIdentifier dst, Int32 dstElement, Int32 dstMip, Int32 dstX, Int32 dstY, Int32 mode) { }

	// RVA: 0xFFFFFFFF75C2BC24
	private Void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, Int32 pass, Vector2 scale, Vector2 offset, Int32 sourceDepthSlice, Int32 destDepthSlice) { }

	// RVA: 0xFFFFFFFF75C2BD68
	private Void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, Int32 pass, Vector2 scale, Vector2 offset, Int32 sourceDepthSlice, Int32 destDepthSlice) { }

	// RVA: 0xFFFFFFFF75C2BEAC
	public Void GetTemporaryRT(Int32 nameID, Int32 width, Int32 height, Int32 depthBuffer, FilterMode filter, GraphicsFormat format, Int32 antiAliasing, Boolean enableRandomWrite, RenderTextureMemoryless memorylessMode, Boolean useDynamicScale) { }

	// RVA: 0xFFFFFFFF75C2BF68
	public Void GetTemporaryRT(Int32 nameID, Int32 width, Int32 height, Int32 depthBuffer, FilterMode filter, GraphicsFormat format, Int32 antiAliasing, Boolean enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0xFFFFFFFF75C2C018
	public Void GetTemporaryRT(Int32 nameID, Int32 width, Int32 height, Int32 depthBuffer, FilterMode filter, GraphicsFormat format, Int32 antiAliasing) { }

	// RVA: 0xFFFFFFFF75C2C0C8
	public Void GetTemporaryRT(Int32 nameID, Int32 width, Int32 height, Int32 depthBuffer, FilterMode filter, GraphicsFormat format) { }

	// RVA: 0xFFFFFFFF75C2C16C
	public Void GetTemporaryRT(Int32 nameID, Int32 width, Int32 height, Int32 depthBuffer, FilterMode filter, RenderTextureFormat format) { }

	// RVA: 0xFFFFFFFF723C7704
	public Void GetTemporaryRT(Int32 nameID, Int32 width, Int32 height, Int32 depthBuffer, FilterMode filter) { }

	// RVA: 0xFFFFFFFF75C2C224
	private Void GetTemporaryRTWithDescriptor(Int32 nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0xFFFFFFFF723C77DC
	public Void GetTemporaryRT(Int32 nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0xFFFFFFFF75C2C2F4
	public Void GetTemporaryRT(Int32 nameID, RenderTextureDescriptor desc) { }

	// RVA: 0xFFFFFFFF723C7860
	public Void ReleaseTemporaryRT(Int32 nameID) { }

	// RVA: 0xFFFFFFFF75C2C370
	public Void ClearRenderTarget(Boolean clearDepth, Boolean clearColor, Color backgroundColor, Single depth) { }

	// RVA: 0xFFFFFFFF723C78BC
	public Void ClearRenderTarget(Boolean clearDepth, Boolean clearColor, Color backgroundColor) { }

	// RVA: 0xFFFFFFFF75C2C4C0
	public Void SetGlobalFloat(Int32 nameID, Single value) { }

	// RVA: 0xFFFFFFFF75C2C520
	public Void SetGlobalVector(Int32 nameID, Vector4 value) { }

	// RVA: 0xFFFFFFFF723C7988
	public Void SetGlobalMatrix(Int32 nameID, Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75C2C638
	public Void EnableShaderKeyword(String keyword) { }

	// RVA: 0xFFFFFFFF75C2C688
	public Void DisableShaderKeyword(String keyword) { }

	// RVA: 0xFFFFFFFF75C2C6D8
	public Void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	// RVA: 0xFFFFFFFF75C2C468
	private Boolean ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	// RVA: 0xFFFFFFFF75C2C788
	private Void SetGlobalTexture_Impl(Int32 nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	// RVA: 0xFFFFFFFF75C2C7F0
	public Void BeginSample(String name) { }

	// RVA: 0xFFFFFFFF75C2C840
	public Void EndSample(String name) { }

	// RVA: 0xFFFFFFFF75C2C890
	public Void SetRenderTarget(RenderTargetIdentifier rt) { }

	// RVA: 0xFFFFFFFF723C79E4
	public Void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0xFFFFFFFF75C2C9BC
	public Void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0xFFFFFFFF75C2C93C
	private Void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0xFFFFFFFF75C2CB18
	private Void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0xFFFFFFFF723C7B28
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF723C7B9C
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75C2CCA8
	private Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF723C7C28
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C2CCF0
	public IntPtr GetNativePtr() { }

	// RVA: 0xFFFFFFFF723C7C6C
	public Void Release() { }

	// RVA: 0xFFFFFFFF75C2CCF8
	public Void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, Int32 submeshIndex, Int32 shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0xFFFFFFFF75C2CF24
	public Void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, Int32 submeshIndex, Int32 shaderPass) { }

	// RVA: 0xFFFFFFFF75C2CF58
	public Void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, Int32 submeshIndex) { }

	// RVA: 0xFFFFFFFF75C2CF90
	public Void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material) { }

	// RVA: 0xFFFFFFFF75C2CFCC
	public Void DrawRenderer(Renderer renderer, Material material, Int32 submeshIndex, Int32 shaderPass) { }

	// RVA: 0xFFFFFFFF75C2D1A0
	public Void DrawMeshInstanced(Mesh mesh, Int32 submeshIndex, Material material, Int32 shaderPass, Matrix4x4[] matrices, Int32 count, MaterialPropertyBlock properties) { }

	// RVA: 0xFFFFFFFF75C2D50C
	public Void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst) { }

	// RVA: 0xFFFFFFFF75C2D598
	public Void Blit(Texture source, RenderTargetIdentifier dest) { }

	// RVA: 0xFFFFFFFF723C7CF8
	public Void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest) { }

	// RVA: 0xFFFFFFFF75C2D684
	public Void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Vector2 scale, Vector2 offset) { }

	// RVA: 0xFFFFFFFF723C7DE8
	public Void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, Int32 pass) { }

	// RVA: 0xFFFFFFFF723C7EE8
	public Void SetGlobalFloat(String name, Single value) { }

	// RVA: 0xFFFFFFFF723C8014
	public Void SetGlobalVector(String name, Vector4 value) { }

	// RVA: 0xFFFFFFFF723C80F8
	public Void SetGlobalMatrix(String name, Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF723C81C8
	public Void SetGlobalTexture(String name, RenderTargetIdentifier value) { }

	// RVA: 0xFFFFFFFF75C2D7F0
	public Void SetGlobalTexture(Int32 nameID, RenderTargetIdentifier value) { }

	// RVA: 0xFFFFFFFF75C2D788
	public Void SetGlobalTexture(Int32 nameID, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	// RVA: 0xFFFFFFFF75C2B990
	private Void Internal_DrawMesh_Injected(Mesh mesh, ref Matrix4x4 matrix, Material material, Int32 submeshIndex, Int32 shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0xFFFFFFFF75C2BB20
	private Void SetViewport_Injected(ref Rect pixelRect) { }

	// RVA: 0xFFFFFFFF75C2BCC8
	private Void Blit_Texture_Injected(Texture source, ref RenderTargetIdentifier dest, Material mat, Int32 pass, ref Vector2 scale, ref Vector2 offset, Int32 sourceDepthSlice, Int32 destDepthSlice) { }

	// RVA: 0xFFFFFFFF75C2BE0C
	private Void Blit_Identifier_Injected(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, Int32 pass, ref Vector2 scale, ref Vector2 offset, Int32 sourceDepthSlice, Int32 destDepthSlice) { }

	// RVA: 0xFFFFFFFF75C2C28C
	private Void GetTemporaryRTWithDescriptor_Injected(Int32 nameID, ref RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0xFFFFFFFF75C2C3F0
	private Void ClearRenderTarget_Injected(Boolean clearDepth, Boolean clearColor, ref Color backgroundColor, Single depth) { }

	// RVA: 0xFFFFFFFF75C2C588
	private Void SetGlobalVector_Injected(Int32 nameID, ref Vector4 value) { }

	// RVA: 0xFFFFFFFF75C2C5E0
	private Void SetGlobalMatrix_Injected(Int32 nameID, ref Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75C2C730
	private Void SetViewProjectionMatrices_Injected(ref Matrix4x4 view, ref Matrix4x4 proj) { }

	// RVA: 0xFFFFFFFF75C2CBA0
	private Void SetRenderTargetSingle_Internal_Injected(ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0xFFFFFFFF75C2CC20
	private Void SetRenderTargetColorDepth_Internal_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

}

// Namespace: UnityEngine.Rendering
public class SplashScreen
{
	// Properties
	public static Boolean isFinished { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C3103C
	public static Boolean get_isFinished() { }

}

// Namespace: UnityEngine.Rendering
public struct SphericalHarmonicsL2
{
	// Fields
	private Single shr0; // 0x10
	private Single shr1; // 0x14
	private Single shr2; // 0x18
	private Single shr3; // 0x1C
	private Single shr4; // 0x20
	private Single shr5; // 0x24
	private Single shr6; // 0x28
	private Single shr7; // 0x2C
	private Single shr8; // 0x30
	private Single shg0; // 0x34
	private Single shg1; // 0x38
	private Single shg2; // 0x3C
	private Single shg3; // 0x40
	private Single shg4; // 0x44
	private Single shg5; // 0x48
	private Single shg6; // 0x4C
	private Single shg7; // 0x50
	private Single shg8; // 0x54
	private Single shb0; // 0x58
	private Single shb1; // 0x5C
	private Single shb2; // 0x60
	private Single shb3; // 0x64
	private Single shb4; // 0x68
	private Single shb5; // 0x6C
	private Single shb6; // 0x70
	private Single shb7; // 0x74
	private Single shb8; // 0x78

	// Methods

	// RVA: 0xFFFFFFFF7114E5B0
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114E5B8
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF7114E5C0
	public Boolean Equals(SphericalHarmonicsL2 other) { }

	// RVA: 0xFFFFFFFF75C30E80
	public static Boolean op_Equality(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs) { }

}

// Namespace: UnityEngine.Rendering
public struct BlendState
{
	// Fields
	private RenderTargetBlendState m_BlendState0; // 0x10
	private RenderTargetBlendState m_BlendState1; // 0x18
	private RenderTargetBlendState m_BlendState2; // 0x20
	private RenderTargetBlendState m_BlendState3; // 0x28
	private RenderTargetBlendState m_BlendState4; // 0x30
	private RenderTargetBlendState m_BlendState5; // 0x38
	private RenderTargetBlendState m_BlendState6; // 0x40
	private RenderTargetBlendState m_BlendState7; // 0x48
	private Byte m_SeparateMRTBlendStates; // 0x50
	private Byte m_AlphaToMask; // 0x51
	private Int16 m_Padding; // 0x52

	// Methods

	// RVA: 0xFFFFFFFF7114DAD4
	public Boolean Equals(BlendState other) { }

	// RVA: 0xFFFFFFFF7114DB10
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7114DB18
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
internal struct CoreCameraValues
{
	// Fields
	private Int32 filterMode; // 0x10
	private UInt32 cullingMask; // 0x14
	private Int32 instanceID; // 0x18
	private Int32 renderImmediateObjects; // 0x1C

	// Methods

	// RVA: 0xFFFFFFFF7114DBA8
	public Boolean Equals(CoreCameraValues other) { }

	// RVA: 0xFFFFFFFF7114DBEC
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7114DBF4
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public struct CameraProperties
{
	// Fields
	private Rect screenRect; // 0x10
	private Vector3 viewDir; // 0x20
	private Single projectionNear; // 0x2C
	private Single projectionFar; // 0x30
	private Single cameraNear; // 0x34
	private Single cameraFar; // 0x38
	private Single cameraAspect; // 0x3C
	private Matrix4x4 cameraToWorld; // 0x40
	private Matrix4x4 actualWorldToClip; // 0x80
	private Matrix4x4 cameraClipToWorld; // 0xC0
	private Matrix4x4 cameraWorldToClip; // 0x100
	private Matrix4x4 implicitProjection; // 0x140
	private Matrix4x4 stereoWorldToClipLeft; // 0x180
	private Matrix4x4 stereoWorldToClipRight; // 0x1C0
	private Matrix4x4 worldToCamera; // 0x200
	private Vector3 up; // 0x240
	private Vector3 right; // 0x24C
	private Vector3 transformDirection; // 0x258
	private Vector3 cameraEuler; // 0x264
	private Vector3 velocity; // 0x270
	private Single farPlaneWorldSpaceLength; // 0x27C
	private UInt32 rendererCount; // 0x280
	internal <m_ShadowCullPlanes>e__FixedBuffer m_ShadowCullPlanes; // 0x284
	internal <m_CameraCullPlanes>e__FixedBuffer m_CameraCullPlanes; // 0x2E4
	private Single baseFarDistance; // 0x344
	private Vector3 shadowCullCenter; // 0x348
	internal <layerCullDistances>e__FixedBuffer layerCullDistances; // 0x354
	private Int32 layerCullSpherical; // 0x3D4
	private CoreCameraValues coreCameraValues; // 0x3D8
	private UInt32 cameraType; // 0x3E8
	private Int32 projectionIsOblique; // 0x3EC
	private Int32 isImplicitProjectionMatrix; // 0x3F0

	// Methods

	// RVA: 0xFFFFFFFF7114DB20
	public Plane GetShadowCullingPlane(Int32 index) { }

	// RVA: 0xFFFFFFFF7114DB28
	public Plane GetCameraCullingPlane(Int32 index) { }

	// RVA: 0xFFFFFFFF7114DB30
	public Boolean Equals(CameraProperties other) { }

	// RVA: 0xFFFFFFFF7114DB98
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7114DBA0
	public override Int32 GetHashCode() { }

}

// Namespace: 
public struct <m_ShadowCullPlanes>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: 
public struct <m_CameraCullPlanes>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: 
public struct <layerCullDistances>e__FixedBuffer
{
	// Fields
	public Single FixedElementField; // 0x10
}

// Namespace: UnityEngine.Rendering
public enum CullingOptions
{
	// Fields
	public Int32 value__; // 0x10
	public const CullingOptions None = 0;
	public const CullingOptions ForceEvenIfCameraIsNotActive = 1;
	public const CullingOptions OcclusionCull = 2;
	public const CullingOptions NeedsLighting = 4;
	public const CullingOptions NeedsReflectionProbes = 8;
	public const CullingOptions Stereo = 16;
	public const CullingOptions DisablePerObjectCulling = 32;
	public const CullingOptions ShadowCasters = 64;
}

// Namespace: UnityEngine.Rendering
public struct ScriptableCullingParameters
{
	// Fields
	private Int32 m_IsOrthographic; // 0x10
	private LODParameters m_LODParameters; // 0x14
	public static readonly Int32 maximumCullingPlaneCount; // 0x0
	internal <m_CullingPlanes>e__FixedBuffer m_CullingPlanes; // 0x30
	private Int32 m_CullingPlaneCount; // 0xD0
	private UInt32 m_CullingMask; // 0xD4
	private UInt64 m_SceneMask; // 0xD8
	public static readonly Int32 layerCount; // 0x4
	internal <m_LayerFarCullDistances>e__FixedBuffer m_LayerFarCullDistances; // 0xE0
	private Int32 m_LayerCull; // 0x160
	private Matrix4x4 m_CullingMatrix; // 0x164
	private Vector3 m_Origin; // 0x1A4
	private Single m_ShadowDistance; // 0x1B0
	private CullingOptions m_CullingOptions; // 0x1B4
	private ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria; // 0x1B8
	private CameraProperties m_CameraProperties; // 0x1BC
	private Single m_AccurateOcclusionThreshold; // 0x5A0
	private Int32 m_MaximumPortalCullingJobs; // 0x5A4
	private Matrix4x4 m_StereoViewMatrix; // 0x5A8
	private Matrix4x4 m_StereoProjectionMatrix; // 0x5E8
	private Single m_StereoSeparationDistance; // 0x628
	private Int32 m_maximumVisibleLights; // 0x62C

	// Properties
	public Int32 cullingPlaneCount { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114E1F8
	public Int32 get_cullingPlaneCount() { }

	// RVA: 0xFFFFFFFF7114E200
	public Single GetLayerCullingDistance(Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF7114E208
	public Plane GetCullingPlane(Int32 index) { }

	// RVA: 0xFFFFFFFF7114E210
	public Boolean Equals(ScriptableCullingParameters other) { }

	// RVA: 0xFFFFFFFF7114E278
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7114E280
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75C305A0
	private static Void .cctor() { }

}

// Namespace: 
public struct <m_CullingPlanes>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: 
public struct <m_LayerFarCullDistances>e__FixedBuffer
{
	// Fields
	public Single FixedElementField; // 0x10
}

// Namespace: UnityEngine.Rendering
public struct DepthState
{
	// Fields
	private Byte m_WriteEnabled; // 0x10
	private SByte m_CompareFunction; // 0x11

	// Methods

	// RVA: 0xFFFFFFFF7114DC1C
	public Boolean Equals(DepthState other) { }

	// RVA: 0xFFFFFFFF7114DC44
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7114DC4C
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
internal enum DrawRendererFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const DrawRendererFlags None = 0;
	public const DrawRendererFlags EnableDynamicBatching = 1;
	public const DrawRendererFlags EnableInstancing = 2;
}

// Namespace: UnityEngine.Rendering
public struct DrawingSettings
{
	// Fields
	public static readonly Int32 maxShaderPasses; // 0x0
	private SortingSettings m_SortingSettings; // 0x10
	internal <shaderPassNames>e__FixedBuffer shaderPassNames; // 0xF0
	private PerObjectData m_PerObjectData; // 0x130
	private DrawRendererFlags m_Flags; // 0x134
	private Int32 m_OverrideMaterialInstanceId; // 0x138
	private Int32 m_OverrideMaterialPassIndex; // 0x13C
	private Int32 m_MainLightIndex; // 0x140
	private Int32 m_UseSrpBatcher; // 0x144

	// Properties
	public PerObjectData perObjectData { set; }
	public Boolean enableDynamicBatching { set; }
	public Boolean enableInstancing { set; }

	// Methods

	// RVA: 0xFFFFFFFF7114DC90
	public Void .ctor(ShaderTagId shaderPassName, SortingSettings sortingSettings) { }

	// RVA: 0xFFFFFFFF7114DCF0
	public Void set_perObjectData(PerObjectData value) { }

	// RVA: 0xFFFFFFFF7114DCF8
	public Void set_enableDynamicBatching(Boolean value) { }

	// RVA: 0xFFFFFFFF7114DD0C
	public Void set_enableInstancing(Boolean value) { }

	// RVA: 0xFFFFFFFF7114DD2C
	public ShaderTagId GetShaderPassName(Int32 index) { }

	// RVA: 0xFFFFFFFF7114DD34
	public Void SetShaderPassName(Int32 index, ShaderTagId shaderPassName) { }

	// RVA: 0xFFFFFFFF7114DD40
	public Boolean Equals(DrawingSettings other) { }

	// RVA: 0xFFFFFFFF7114DDA8
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7114DDB0
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75C2DF6C
	private static Void .cctor() { }

}

// Namespace: 
public struct <shaderPassNames>e__FixedBuffer
{
	// Fields
	public Int32 FixedElementField; // 0x10
}

// Namespace: UnityEngine.Rendering
public struct FilteringSettings
{
	// Fields
	private RenderQueueRange m_RenderQueueRange; // 0x10
	private Int32 m_LayerMask; // 0x18
	private UInt32 m_RenderingLayerMask; // 0x1C
	private Int32 m_ExcludeMotionVectorObjects; // 0x20
	private SortingLayerRange m_SortingLayerRange; // 0x24

	// Properties
	public Int32 layerMask { set; }

	// Methods

	// RVA: 0xFFFFFFFF7114DE14
	public Void .ctor(Nullable<T0> renderQueueRange, Int32 layerMask, UInt32 renderingLayerMask, Int32 excludeMotionVectorObjects) { }

	// RVA: 0xFFFFFFFF7114DE20
	public Void set_layerMask(Int32 value) { }

	// RVA: 0xFFFFFFFF7114DE28
	public Boolean Equals(FilteringSettings other) { }

	// RVA: 0xFFFFFFFF7114DE84
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7114DE8C
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public struct LODParameters
{
	// Fields
	private Int32 m_IsOrthographic; // 0x10
	private Vector3 m_CameraPosition; // 0x14
	private Single m_FieldOfView; // 0x20
	private Single m_OrthoSize; // 0x24
	private Int32 m_CameraPixelHeight; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF7114DEC0
	public Boolean Equals(LODParameters other) { }

	// RVA: 0xFFFFFFFF7114DEF4
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7114DEFC
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public enum PerObjectData
{
	// Fields
	public Int32 value__; // 0x10
	public const PerObjectData None = 0;
	public const PerObjectData LightProbe = 1;
	public const PerObjectData ReflectionProbes = 2;
	public const PerObjectData LightProbeProxyVolume = 4;
	public const PerObjectData Lightmaps = 8;
	public const PerObjectData LightData = 16;
	public const PerObjectData MotionVectors = 32;
	public const PerObjectData LightIndices = 64;
	public const PerObjectData ReflectionProbeData = 128;
	public const PerObjectData OcclusionProbe = 256;
	public const PerObjectData OcclusionProbeProxyVolume = 512;
	public const PerObjectData ShadowMask = 1024;
}

// Namespace: UnityEngine.Rendering
public struct RasterState
{
	// Fields
	public static readonly RasterState defaultValue; // 0x0
	private CullMode m_CullingMode; // 0x10
	private Int32 m_OffsetUnits; // 0x14
	private Single m_OffsetFactor; // 0x18
	private Byte m_DepthClip; // 0x1C
	private Byte m_Padding1; // 0x1D
	private Byte m_Padding2; // 0x1E
	private Byte m_Padding3; // 0x1F

	// Methods

	// RVA: 0xFFFFFFFF7114DF04
	public Void .ctor(CullMode cullingMode, Int32 offsetUnits, Single offsetFactor, Boolean depthClip) { }

	// RVA: 0xFFFFFFFF7114DF0C
	public Boolean Equals(RasterState other) { }

	// RVA: 0xFFFFFFFF7114DF74
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7114DF7C
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75C2E5AC
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public enum ReflectionProbeSortingCriteria
{
	// Fields
	public Int32 value__; // 0x10
	public const ReflectionProbeSortingCriteria None = 0;
	public const ReflectionProbeSortingCriteria Importance = 1;
	public const ReflectionProbeSortingCriteria Size = 2;
	public const ReflectionProbeSortingCriteria ImportanceThenSize = 3;
}

// Namespace: UnityEngine.Rendering
public abstract class RenderPipeline
{
	// Fields
	private Boolean <disposed>k__BackingField; // 0x10

	// Properties
	public Boolean disposed { get; set; }

	// Methods

	// RVA: -1
	protected abstract Void Render(ScriptableRenderContext context, Camera[] cameras) { }

	// RVA: 0xFFFFFFFF75C2E634
	internal Void InternalRender(ScriptableRenderContext context, Camera[] cameras) { }

	// RVA: 0xFFFFFFFF75C2E6F0
	public Boolean get_disposed() { }

	// RVA: 0xFFFFFFFF75C2E6F8
	private Void set_disposed(Boolean value) { }

	// RVA: 0xFFFFFFFF75C2E700
	internal Void Dispose() { }

	// RVA: 0xFFFFFFFF75C2E760
	protected virtual Void Dispose(Boolean disposing) { }

}

// Namespace: UnityEngine.Rendering
public abstract class RenderPipelineAsset
{
	// Properties
	public virtual String[] renderingLayerMaskNames { get; }
	public virtual Material defaultMaterial { get; }
	public virtual Shader autodeskInteractiveShader { get; }
	public virtual Shader autodeskInteractiveTransparentShader { get; }
	public virtual Shader autodeskInteractiveMaskedShader { get; }
	public virtual Shader terrainDetailLitShader { get; }
	public virtual Shader terrainDetailGrassShader { get; }
	public virtual Shader terrainDetailGrassBillboardShader { get; }
	public virtual Material defaultParticleMaterial { get; }
	public virtual Material defaultLineMaterial { get; }
	public virtual Material defaultTerrainMaterial { get; }
	public virtual Material defaultUIMaterial { get; }
	public virtual Material defaultUIOverdrawMaterial { get; }
	public virtual Material defaultUIETC1SupportedMaterial { get; }
	public virtual Material default2DMaterial { get; }
	public virtual Shader defaultShader { get; }
	public virtual Shader defaultSpeedTree7Shader { get; }
	public virtual Shader defaultSpeedTree8Shader { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C2E764
	internal RenderPipeline InternalCreatePipeline() { }

	// RVA: 0xFFFFFFFF75C2EA40
	public virtual String[] get_renderingLayerMaskNames() { }

	// RVA: 0xFFFFFFFF75C2EA48
	public virtual Material get_defaultMaterial() { }

	// RVA: 0xFFFFFFFF75C2EA50
	public virtual Shader get_autodeskInteractiveShader() { }

	// RVA: 0xFFFFFFFF75C2EA58
	public virtual Shader get_autodeskInteractiveTransparentShader() { }

	// RVA: 0xFFFFFFFF75C2EA60
	public virtual Shader get_autodeskInteractiveMaskedShader() { }

	// RVA: 0xFFFFFFFF75C2EA68
	public virtual Shader get_terrainDetailLitShader() { }

	// RVA: 0xFFFFFFFF75C2EA70
	public virtual Shader get_terrainDetailGrassShader() { }

	// RVA: 0xFFFFFFFF75C2EA78
	public virtual Shader get_terrainDetailGrassBillboardShader() { }

	// RVA: 0xFFFFFFFF75C2EA80
	public virtual Material get_defaultParticleMaterial() { }

	// RVA: 0xFFFFFFFF75C2EA88
	public virtual Material get_defaultLineMaterial() { }

	// RVA: 0xFFFFFFFF75C2EA90
	public virtual Material get_defaultTerrainMaterial() { }

	// RVA: 0xFFFFFFFF75C2EA98
	public virtual Material get_defaultUIMaterial() { }

	// RVA: 0xFFFFFFFF75C2EAA0
	public virtual Material get_defaultUIOverdrawMaterial() { }

	// RVA: 0xFFFFFFFF75C2EAA8
	public virtual Material get_defaultUIETC1SupportedMaterial() { }

	// RVA: 0xFFFFFFFF75C2EAB0
	public virtual Material get_default2DMaterial() { }

	// RVA: 0xFFFFFFFF75C2EAB8
	public virtual Shader get_defaultShader() { }

	// RVA: 0xFFFFFFFF75C2EAC0
	public virtual Shader get_defaultSpeedTree7Shader() { }

	// RVA: 0xFFFFFFFF75C2EAC8
	public virtual Shader get_defaultSpeedTree8Shader() { }

	// RVA: -1
	protected abstract RenderPipeline CreatePipeline() { }

	// RVA: 0xFFFFFFFF75C2EAD0
	protected virtual Void OnValidate() { }

	// RVA: 0xFFFFFFFF75C2F038
	protected virtual Void OnDisable() { }

	// RVA: 0xFFFFFFFF75C2F09C
	protected Void .ctor() { }

}

// Namespace: UnityEngine.Rendering
public static class RenderPipelineManager
{
	// Fields
	internal static RenderPipelineAsset s_CurrentPipelineAsset; // 0x0
	private static Camera[] s_Cameras; // 0x8
	private static Int32 s_CameraCapacity; // 0x10
	private static RenderPipeline <currentPipeline>k__BackingField; // 0x18
	private static Action<T0, T1> beginCameraRendering; // 0x20

	// Properties
	public static RenderPipeline currentPipeline { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C2F0A0
	public static RenderPipeline get_currentPipeline() { }

	// RVA: 0xFFFFFFFF75C2F110
	private static Void set_currentPipeline(RenderPipeline value) { }

	// RVA: 0xFFFFFFFF723C86F0
	public static Void add_beginCameraRendering(Action<T0, T1> value) { }

	// RVA: 0xFFFFFFFF723C8808
	public static Void remove_beginCameraRendering(Action<T0, T1> value) { }

	// RVA: 0xFFFFFFFF75C2EB94
	internal static Void CleanupRenderPipeline() { }

	// RVA: 0xFFFFFFFF723C8920
	private static Void GetCameras(ScriptableRenderContext context) { }

	// RVA: 0xFFFFFFFF75C2F310
	private static Void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr) { }

	// RVA: 0xFFFFFFFF75C2EE28
	internal static Void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0xFFFFFFFF75C2F498
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct RenderQueueRange
{
	// Fields
	private Int32 m_LowerBound; // 0x10
	private Int32 m_UpperBound; // 0x14
	private const Int32 k_MinimumBound = 0;
	public static readonly Int32 minimumBound; // 0x0
	private const Int32 k_MaximumBound = 5000;
	public static readonly Int32 maximumBound; // 0x4

	// Properties
	public static RenderQueueRange all { get; }
	public static RenderQueueRange opaque { get; }
	public static RenderQueueRange transparent { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C2DFC8
	public static RenderQueueRange get_all() { }

	// RVA: 0xFFFFFFFF723C8B2C
	public static RenderQueueRange get_opaque() { }

	// RVA: 0xFFFFFFFF723C8B34
	public static RenderQueueRange get_transparent() { }

	// RVA: 0xFFFFFFFF7114E014
	public Boolean Equals(RenderQueueRange other) { }

	// RVA: 0xFFFFFFFF7114E03C
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7114E044
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75C2F5C0
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct RenderStateBlock
{
	// Fields
	private BlendState m_BlendState; // 0x10
	private RasterState m_RasterState; // 0x54
	private DepthState m_DepthState; // 0x64
	private StencilState m_StencilState; // 0x66
	private Int32 m_StencilReference; // 0x74
	private RenderStateMask m_Mask; // 0x78

	// Properties
	public RenderStateMask mask { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114E058
	public RenderStateMask get_mask() { }

	// RVA: 0xFFFFFFFF7114E060
	public Boolean Equals(RenderStateBlock other) { }

	// RVA: 0xFFFFFFFF7114E0A4
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7114E0AC
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public enum RenderStateMask
{
	// Fields
	public Int32 value__; // 0x10
	public const RenderStateMask Nothing = 0;
	public const RenderStateMask Blend = 1;
	public const RenderStateMask Raster = 2;
	public const RenderStateMask Depth = 4;
	public const RenderStateMask Stencil = 8;
	public const RenderStateMask Everything = 15;
}

// Namespace: UnityEngine.Rendering
public struct RenderTargetBlendState
{
	// Fields
	private Byte m_WriteMask; // 0x10
	private Byte m_SourceColorBlendMode; // 0x11
	private Byte m_DestinationColorBlendMode; // 0x12
	private Byte m_SourceAlphaBlendMode; // 0x13
	private Byte m_DestinationAlphaBlendMode; // 0x14
	private Byte m_ColorBlendOperation; // 0x15
	private Byte m_AlphaBlendOperation; // 0x16
	private Byte m_Padding; // 0x17

	// Methods

	// RVA: 0xFFFFFFFF7114E0B4
	public Boolean Equals(RenderTargetBlendState other) { }

	// RVA: 0xFFFFFFFF7114E0BC
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7114E0C4
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public struct ScriptableRenderContext
{
	// Fields
	private IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C30600
	internal static Void InitializeSortSettings(Camera camera, out SortingSettings sortingSettings) { }

	// RVA: 0xFFFFFFFF7114E288
	private Int32 GetNumberOfCameras_Internal() { }

	// RVA: 0xFFFFFFFF7114E2C8
	private Camera GetCamera_Internal(Int32 index) { }

	// RVA: 0xFFFFFFFF7114E318
	internal Void .ctor(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF7114E320
	internal Int32 GetNumberOfCameras() { }

	// RVA: 0xFFFFFFFF7114E360
	internal Camera GetCamera(Int32 index) { }

	// RVA: 0xFFFFFFFF7114E3B0
	public Boolean Equals(ScriptableRenderContext other) { }

	// RVA: 0xFFFFFFFF7114E3F8
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7114E400
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75C30690
	private static Int32 GetNumberOfCameras_Internal_Injected(ref ScriptableRenderContext _unity_self) { }

	// RVA: 0xFFFFFFFF75C30720
	private static Camera GetCamera_Internal_Injected(ref ScriptableRenderContext _unity_self, Int32 index) { }

}

// Namespace: UnityEngine.Rendering
public struct ShaderTagId
{
	// Fields
	public static readonly ShaderTagId none; // 0x0
	private Int32 m_Id; // 0x10

	// Properties
	internal Int32 id { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF7114E40C
	public Void .ctor(String name) { }

	// RVA: 0xFFFFFFFF7114E460
	internal Int32 get_id() { }

	// RVA: 0xFFFFFFFF7114E468
	internal Void set_id(Int32 value) { }

	// RVA: 0xFFFFFFFF7114E470
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7114E478
	public Boolean Equals(ShaderTagId other) { }

	// RVA: 0xFFFFFFFF7114E488
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75C30964
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public enum SortingCriteria
{
	// Fields
	public Int32 value__; // 0x10
	public const SortingCriteria None = 0;
	public const SortingCriteria SortingLayer = 1;
	public const SortingCriteria RenderQueue = 2;
	public const SortingCriteria BackToFront = 4;
	public const SortingCriteria QuantizedFrontToBack = 8;
	public const SortingCriteria OptimizeStateChanges = 16;
	public const SortingCriteria CanvasOrder = 32;
	public const SortingCriteria RendererPriority = 64;
	public const SortingCriteria CommonOpaque = 59;
	public const SortingCriteria CommonTransparent = 23;
}

// Namespace: UnityEngine.Rendering
public struct SortingLayerRange
{
	// Fields
	private Int16 m_LowerBound; // 0x10
	private Int16 m_UpperBound; // 0x12

	// Properties
	public static SortingLayerRange all { get; }

	// Methods

	// RVA: 0xFFFFFFFF723C8600
	public static SortingLayerRange get_all() { }

	// RVA: 0xFFFFFFFF7114E4B0
	public Boolean Equals(SortingLayerRange other) { }

	// RVA: 0xFFFFFFFF7114E4D4
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7114E4DC
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public enum DistanceMetric
{
	// Fields
	public Int32 value__; // 0x10
	public const DistanceMetric Perspective = 0;
	public const DistanceMetric Orthographic = 1;
	public const DistanceMetric CustomAxis = 2;
}

// Namespace: UnityEngine.Rendering
public struct SortingSettings
{
	// Fields
	private Matrix4x4 m_WorldToCameraMatrix; // 0x10
	private Vector3 m_CameraPosition; // 0x50
	private Vector3 m_CustomAxis; // 0x5C
	private SortingCriteria m_Criteria; // 0x68
	private DistanceMetric m_DistanceMetric; // 0x6C
	private Matrix4x4 m_PreviousVPMatrix; // 0x70
	private Matrix4x4 m_NonJitteredVPMatrix; // 0xB0

	// Properties
	public SortingCriteria criteria { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF7114E4E4
	public Void .ctor(Camera camera) { }

	// RVA: 0xFFFFFFFF7114E534
	public SortingCriteria get_criteria() { }

	// RVA: 0xFFFFFFFF7114E53C
	public Void set_criteria(SortingCriteria value) { }

	// RVA: 0xFFFFFFFF7114E544
	public Boolean Equals(SortingSettings other) { }

	// RVA: 0xFFFFFFFF7114E5A0
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7114E5A8
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public struct StencilState
{
	// Fields
	private Byte m_Enabled; // 0x10
	private Byte m_ReadMask; // 0x11
	private Byte m_WriteMask; // 0x12
	private Byte m_Padding; // 0x13
	private Byte m_CompareFunctionFront; // 0x14
	private Byte m_PassOperationFront; // 0x15
	private Byte m_FailOperationFront; // 0x16
	private Byte m_ZFailOperationFront; // 0x17
	private Byte m_CompareFunctionBack; // 0x18
	private Byte m_PassOperationBack; // 0x19
	private Byte m_FailOperationBack; // 0x1A
	private Byte m_ZFailOperationBack; // 0x1B

	// Methods

	// RVA: 0xFFFFFFFF7114E624
	public Boolean Equals(StencilState other) { }

	// RVA: 0xFFFFFFFF7114E630
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7114E638
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public class SupportedRenderingFeatures
{
	// Fields
	private static SupportedRenderingFeatures s_Active; // 0x0
	private ReflectionProbeModes <reflectionProbeModes>k__BackingField; // 0x10
	private LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField; // 0x14
	private LightmapMixedBakeModes <mixedLightingModes>k__BackingField; // 0x18
	private LightmapBakeType <lightmapBakeTypes>k__BackingField; // 0x1C
	private LightmapsMode <lightmapsModes>k__BackingField; // 0x20
	private Boolean <enlighten>k__BackingField; // 0x24
	private Boolean <lightProbeProxyVolumes>k__BackingField; // 0x25
	private Boolean <motionVectors>k__BackingField; // 0x26
	private Boolean <receiveShadows>k__BackingField; // 0x27
	private Boolean <reflectionProbes>k__BackingField; // 0x28
	private Boolean <rendererPriority>k__BackingField; // 0x29
	private Boolean <terrainDetailUnsupported>k__BackingField; // 0x2A
	private Boolean <overridesEnvironmentLighting>k__BackingField; // 0x2B
	private Boolean <overridesFog>k__BackingField; // 0x2C
	private Boolean <overridesOtherLightingSettings>k__BackingField; // 0x2D
	private Boolean <editableMaterialRenderQueue>k__BackingField; // 0x2E
	private Boolean <overridesLODBias>k__BackingField; // 0x2F
	private Boolean <overridesMaximumLODLevel>k__BackingField; // 0x30
	private Boolean <autoAmbientProbeBaking>k__BackingField; // 0x31
	private Boolean <autoDefaultReflectionProbeBaking>k__BackingField; // 0x32

	// Properties
	public static SupportedRenderingFeatures active { get; set; }
	public LightmapMixedBakeModes defaultMixedLightingModes { get; }
	public LightmapMixedBakeModes mixedLightingModes { get; }
	public LightmapBakeType lightmapBakeTypes { get; }
	public LightmapsMode lightmapsModes { get; }
	public Boolean enlighten { get; }
	public Boolean autoAmbientProbeBaking { get; }
	public Boolean autoDefaultReflectionProbeBaking { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C3139C
	public static SupportedRenderingFeatures get_active() { }

	// RVA: 0xFFFFFFFF75C2F1E8
	public static Void set_active(SupportedRenderingFeatures value) { }

	// RVA: 0xFFFFFFFF75C31484
	public LightmapMixedBakeModes get_defaultMixedLightingModes() { }

	// RVA: 0xFFFFFFFF75C3148C
	public LightmapMixedBakeModes get_mixedLightingModes() { }

	// RVA: 0xFFFFFFFF75C31494
	public LightmapBakeType get_lightmapBakeTypes() { }

	// RVA: 0xFFFFFFFF75C3149C
	public LightmapsMode get_lightmapsModes() { }

	// RVA: 0xFFFFFFFF75C314A4
	public Boolean get_enlighten() { }

	// RVA: 0xFFFFFFFF75C314AC
	public Boolean get_autoAmbientProbeBaking() { }

	// RVA: 0xFFFFFFFF75C314B4
	public Boolean get_autoDefaultReflectionProbeBaking() { }

	// RVA: 0xFFFFFFFF75C314BC
	internal static Void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr) { }

	// RVA: 0xFFFFFFFF75C315A8
	internal static Boolean IsMixedLightingModeSupported(MixedLightingMode mixedMode) { }

	// RVA: 0xFFFFFFFF75C31634
	internal static Void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr) { }

	// RVA: 0xFFFFFFFF75C31710
	internal static Boolean IsLightmapBakeTypeSupported(LightmapBakeType bakeType) { }

	// RVA: 0xFFFFFFFF723C8D34
	internal static Void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr) { }

	// RVA: 0xFFFFFFFF75C3179C
	internal static Void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr) { }

	// RVA: 0xFFFFFFFF723C8E68
	internal static Void IsLightmapperSupportedByRef(Int32 lightmapper, IntPtr isSupportedPtr) { }

	// RVA: 0xFFFFFFFF75C3182C
	internal static Void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr) { }

	// RVA: 0xFFFFFFFF75C318B0
	internal static Void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr) { }

	// RVA: 0xFFFFFFFF75C31934
	internal static Void FallbackLightmapperByRef(IntPtr lightmapperPtr) { }

	// RVA: 0xFFFFFFFF75C2F1A8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C31940
	private static Void .cctor() { }

}

// Namespace: 
public enum ReflectionProbeModes
{
	// Fields
	public Int32 value__; // 0x10
	public const ReflectionProbeModes None = 0;
	public const ReflectionProbeModes Rotation = 1;
}

// Namespace: 
public enum LightmapMixedBakeModes
{
	// Fields
	public Int32 value__; // 0x10
	public const LightmapMixedBakeModes None = 0;
	public const LightmapMixedBakeModes IndirectOnly = 1;
	public const LightmapMixedBakeModes Subtractive = 2;
	public const LightmapMixedBakeModes Shadowmask = 4;
}

// Namespace: UnityEngine.Rendering
public struct BatchVisibility
{
	// Fields
	public readonly Int32 offset; // 0x10
	public readonly Int32 instancesCount; // 0x14
	public Int32 visibleCount; // 0x18
}

// Namespace: UnityEngine.Rendering
public struct BatchCullingContext
{
	// Fields
	public readonly NativeArray<T0> cullingPlanes; // 0x10
	public NativeArray<T0> batchVisibility; // 0x20
	public NativeArray<T0> visibleIndices; // 0x30
	public readonly LODParameters lodParameters; // 0x40

	// Methods

	// RVA: 0xFFFFFFFF7114D974
	public Void .ctor(NativeArray<T0> inCullingPlanes, NativeArray<T0> inOutBatchVisibility, NativeArray<T0> outVisibleIndices, LODParameters inLodParameters) { }

}

// Namespace: UnityEngine.Rendering
internal struct BatchRendererCullingOutput
{
	// Fields
	public JobHandle cullingJobsFence; // 0x10
	public Plane* cullingPlanes; // 0x20
	public BatchVisibility* batchVisibility; // 0x28
	public Int32* visibleIndices; // 0x30
	public Int32 cullingPlanesCount; // 0x38
	public Int32 batchVisibilityCount; // 0x3C
	public Int32 visibleIndicesCount; // 0x40
}

// Namespace: UnityEngine.Rendering
public class BatchRendererGroup
{
	// Fields
	private IntPtr m_GroupHandle; // 0x10
	private OnPerformCulling m_PerformCulling; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75C293F0
	private static Void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters) { }

}

// Namespace: 
public sealed class OnPerformCulling
{
	// Methods

	// RVA: 0xFFFFFFFF75C29B8C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75C29578
	public virtual JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext) { }

	// RVA: 0xFFFFFFFF75C29BD0
	public virtual IAsyncResult BeginInvoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75C29CA8
	public virtual JobHandle EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine.Rendering
public enum ShaderPropertyType
{
	// Fields
	public Int32 value__; // 0x10
	public const ShaderPropertyType Color = 0;
	public const ShaderPropertyType Vector = 1;
	public const ShaderPropertyType Float = 2;
	public const ShaderPropertyType Range = 3;
	public const ShaderPropertyType Texture = 4;
}

// Namespace: UnityEngine.Rendering
public enum ShaderPropertyFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const ShaderPropertyFlags None = 0;
	public const ShaderPropertyFlags HideInInspector = 1;
	public const ShaderPropertyFlags PerRendererData = 2;
	public const ShaderPropertyFlags NoScaleOffset = 4;
	public const ShaderPropertyFlags Normal = 8;
	public const ShaderPropertyFlags HDR = 16;
	public const ShaderPropertyFlags Gamma = 32;
	public const ShaderPropertyFlags NonModifiableTextureData = 64;
	public const ShaderPropertyFlags MainTexture = 128;
	public const ShaderPropertyFlags MainColor = 256;
}

// Namespace: UnityEngine.Playables
public struct FrameData
{
	// Fields
	internal UInt64 m_FrameID; // 0x10
	internal Double m_DeltaTime; // 0x18
	internal Single m_Weight; // 0x20
	internal Single m_EffectiveWeight; // 0x24
	internal Double m_EffectiveParentDelay; // 0x28
	internal Single m_EffectiveParentSpeed; // 0x30
	internal Single m_EffectiveSpeed; // 0x34
	internal Flags m_Flags; // 0x38
	internal PlayableOutput m_Output; // 0x40

	// Properties
	public Single deltaTime { get; }
	public Single effectiveParentSpeed { get; }
	public Single effectiveSpeed { get; }
	public EvaluationType evaluationType { get; }
	public Boolean timeLooped { get; }
	public Boolean timeHeld { get; }
	public PlayableOutput output { get; }
	public PlayState effectivePlayState { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114C658
	private Boolean HasFlags(Flags flag) { }

	// RVA: 0xFFFFFFFF7114C668
	public Single get_deltaTime() { }

	// RVA: 0xFFFFFFFF7114C674
	public Single get_effectiveParentSpeed() { }

	// RVA: 0xFFFFFFFF7114C67C
	public Single get_effectiveSpeed() { }

	// RVA: 0xFFFFFFFF7114C684
	public EvaluationType get_evaluationType() { }

	// RVA: 0xFFFFFFFF7114C694
	public Boolean get_timeLooped() { }

	// RVA: 0xFFFFFFFF7114C6A0
	public Boolean get_timeHeld() { }

	// RVA: 0xFFFFFFFF7114C6AC
	public PlayableOutput get_output() { }

	// RVA: 0xFFFFFFFF7114C6B8
	public PlayState get_effectivePlayState() { }

}

// Namespace: 
internal enum Flags
{
	// Fields
	public Int32 value__; // 0x10
	public const Flags Evaluate = 1;
	public const Flags SeekOccured = 2;
	public const Flags Loop = 4;
	public const Flags Hold = 8;
	public const Flags EffectivePlayStateDelayed = 16;
	public const Flags EffectivePlayStatePlaying = 32;
}

// Namespace: 
public enum EvaluationType
{
	// Fields
	public Int32 value__; // 0x10
	public const EvaluationType Evaluate = 0;
	public const EvaluationType Playback = 1;
}

// Namespace: UnityEngine.Playables
public interface INotification
{}

// Namespace: UnityEngine.Playables
public interface INotificationReceiver
{
	// Methods

	// RVA: -1
	public abstract Void OnNotify(Playable origin, INotification notification, Object context) { }

}

// Namespace: UnityEngine.Playables
public interface IPlayable
{
	// Methods

	// RVA: -1
	public abstract PlayableHandle GetHandle() { }

}

// Namespace: UnityEngine.Playables
public interface IPlayableBehaviour
{
	// Methods

	// RVA: -1
	public abstract Void OnGraphStart(Playable playable) { }

	// RVA: -1
	public abstract Void OnGraphStop(Playable playable) { }

	// RVA: -1
	public abstract Void OnPlayableCreate(Playable playable) { }

	// RVA: -1
	public abstract Void OnPlayableDestroy(Playable playable) { }

	// RVA: -1
	public abstract Void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: -1
	public abstract Void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: -1
	public abstract Void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: -1
	public abstract Void ProcessFrame(Playable playable, FrameData info, Object playerData) { }

}

// Namespace: UnityEngine.Playables
public interface IPlayableOutput
{
	// Methods

	// RVA: -1
	public abstract PlayableOutputHandle GetHandle() { }

}

// Namespace: UnityEngine.Playables
public enum DirectorWrapMode
{
	// Fields
	public Int32 value__; // 0x10
	public const DirectorWrapMode Hold = 0;
	public const DirectorWrapMode Loop = 1;
	public const DirectorWrapMode None = 2;
}

// Namespace: UnityEngine.Playables
public struct Playable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly Playable m_NullPlayable; // 0x0

	// Properties
	public static Playable Null { get; }

	// Methods

	// RVA: 0xFFFFFFFF723C2E4C
	public static Playable get_Null() { }

	// RVA: 0xFFFFFFFF723C2E94
	public static Playable Create(PlayableGraph graph, Int32 inputCount) { }

	// RVA: 0xFFFFFFFF7114C6D0
	internal Void .ctor(PlayableHandle handle) { }

	// RVA: 0xFFFFFFFF7114C6D8
	public PlayableHandle GetHandle() { }

	// RVA: 0xFFFFFFFF7114C6E4
	public Type GetPlayableType() { }

	// RVA: 0xFFFFFFFF7114C70C
	public Boolean Equals(Playable other) { }

	// RVA: 0xFFFFFFFF75C1D158
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Playables
public interface IPlayableAsset
{
	// Properties
	public abstract Double duration { get; }

	// Methods

	// RVA: -1
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: -1
	public abstract Double get_duration() { }

}

// Namespace: UnityEngine.Playables
public abstract class PlayableAsset
{
	// Properties
	public virtual Double duration { get; }
	public virtual IEnumerable<T0> outputs { get; }

	// Methods

	// RVA: -1
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0xFFFFFFFF75C1D214
	public virtual Double get_duration() { }

	// RVA: 0xFFFFFFFF75C1D254
	public virtual IEnumerable<T0> get_outputs() { }

	// RVA: 0xFFFFFFFF723C302C
	internal static Void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	// RVA: 0xFFFFFFFF723C30B0
	internal static Void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

	// RVA: 0xFFFFFFFF723C30E8
	protected Void .ctor() { }

}

// Namespace: UnityEngine.Playables
public abstract class PlayableBehaviour
{
	// Methods

	// RVA: 0xFFFFFFFF723C314C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C1D294
	public virtual Void OnGraphStart(Playable playable) { }

	// RVA: 0xFFFFFFFF75C1D298
	public virtual Void OnGraphStop(Playable playable) { }

	// RVA: 0xFFFFFFFF75C1D29C
	public virtual Void OnPlayableCreate(Playable playable) { }

	// RVA: 0xFFFFFFFF75C1D2A0
	public virtual Void OnPlayableDestroy(Playable playable) { }

	// RVA: 0xFFFFFFFF75C1D2A4
	public virtual Void OnBehaviourDelay(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75C1D2A8
	public virtual Void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF723C3150
	public virtual Void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75C1D2AC
	public virtual Void PrepareData(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75C1D2B0
	public virtual Void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75C1D2B4
	public virtual Void ProcessFrame(Playable playable, FrameData info, Object playerData) { }

	// RVA: 0xFFFFFFFF75C1D2B8
	public virtual Object Clone() { }

}

// Namespace: UnityEngine.Playables
public struct PlayableBinding
{
	// Fields
	private String m_StreamName; // 0x10
	private Object m_SourceObject; // 0x18
	private Type m_SourceBindingType; // 0x20
	private CreateOutputMethod m_CreateOutputMethod; // 0x28
	public static readonly PlayableBinding[] None; // 0x0
	public static readonly Double DefaultDuration; // 0x8

	// Properties
	public String streamName { get; }
	public Object sourceObject { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114C750
	public String get_streamName() { }

	// RVA: 0xFFFFFFFF7114C758
	public Object get_sourceObject() { }

	// RVA: 0xFFFFFFFF7114C760
	internal PlayableOutput CreateOutput(PlayableGraph graph) { }

	// RVA: 0xFFFFFFFF723C3474
	internal static PlayableBinding CreateInternal(String name, Object sourceObject, Type sourceType, CreateOutputMethod createFunction) { }

	// RVA: 0xFFFFFFFF75C1D300
	private static Void .cctor() { }

}

// Namespace: 
internal sealed class CreateOutputMethod
{
	// Methods

	// RVA: 0xFFFFFFFF75C1D35C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF723C31DC
	public virtual PlayableOutput Invoke(PlayableGraph graph, String name) { }

	// RVA: 0xFFFFFFFF75C1D3A0
	public virtual IAsyncResult BeginInvoke(PlayableGraph graph, String name, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75C1D46C
	public virtual PlayableOutput EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine.Playables
public enum PlayableTraversalMode
{
	// Fields
	public Int32 value__; // 0x10
	public const PlayableTraversalMode Mix = 0;
	public const PlayableTraversalMode Passthrough = 1;
}

// Namespace: UnityEngine.Playables
public static class PlayableExtensions
{
	// Methods

	// RVA: -1
	public static Boolean IsValid(U playable) { }

	// RVA: -1
	public static PlayableGraph GetGraph(U playable) { }

	// RVA: -1
	public static PlayState GetPlayState(U playable) { }

	// RVA: -1
	public static Void Play(U playable) { }

	// RVA: -1
	public static Void Pause(U playable) { }

	// RVA: -1
	public static Void SetSpeed(U playable, Double value) { }

	// RVA: -1
	public static Double GetSpeed(U playable) { }

	// RVA: -1
	public static Void SetDuration(U playable, Double value) { }

	// RVA: -1
	public static Double GetDuration(U playable) { }

	// RVA: -1
	public static Void SetTime(U playable, Double value) { }

	// RVA: -1
	public static Double GetTime(U playable) { }

	// RVA: -1
	public static Double GetPreviousTime(U playable) { }

	// RVA: -1
	public static Boolean IsDone(U playable) { }

	// RVA: -1
	public static Void SetPropagateSetTime(U playable, Boolean value) { }

	// RVA: -1
	public static Void SetInputCount(U playable, Int32 value) { }

	// RVA: -1
	public static Int32 GetInputCount(U playable) { }

	// RVA: -1
	public static Playable GetInput(U playable, Int32 inputPort) { }

	// RVA: -1
	public static Void SetInputWeight(U playable, Int32 inputIndex, Single weight) { }

	// RVA: -1
	public static Void SetInputWeight(U playable, V input, Single weight) { }

	// RVA: -1
	public static Single GetInputWeight(U playable, Int32 inputIndex) { }

	// RVA: -1
	public static Void SetTraversalMode(U playable, PlayableTraversalMode mode) { }

	// RVA: -1
	internal static DirectorWrapMode GetTimeWrapMode(U playable) { }

	// RVA: -1
	internal static Void SetTimeWrapMode(U playable, DirectorWrapMode value) { }

}

// Namespace: UnityEngine.Playables
public enum DirectorUpdateMode
{
	// Fields
	public Int32 value__; // 0x10
	public const DirectorUpdateMode DSPClock = 0;
	public const DirectorUpdateMode GameTime = 1;
	public const DirectorUpdateMode UnscaledGameTime = 2;
	public const DirectorUpdateMode Manual = 3;
}

// Namespace: UnityEngine.Playables
public struct PlayableGraph
{
	// Fields
	internal IntPtr m_Handle; // 0x10
	internal UInt32 m_Version; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF7114C7CC
	public Playable GetRootPlayable(Int32 index) { }

	// RVA: -1
	public Boolean Connect(U source, Int32 sourceOutputPort, V destination, Int32 destinationInputPort) { }

	// RVA: 0xFFFFFFFF7114C834
	public Void Evaluate() { }

	// RVA: 0xFFFFFFFF7114C878
	public Boolean IsValid() { }

	// RVA: 0xFFFFFFFF7114C8B8
	public Boolean IsPlaying() { }

	// RVA: 0xFFFFFFFF7114C8F8
	public Void Evaluate(Single deltaTime) { }

	// RVA: 0xFFFFFFFF7114C948
	public IExposedPropertyTable GetResolver() { }

	// RVA: 0xFFFFFFFF7114C988
	public Int32 GetPlayableCount() { }

	// RVA: 0xFFFFFFFF7114C9C8
	public Int32 GetRootPlayableCount() { }

	// RVA: 0xFFFFFFFF7114CA08
	internal PlayableHandle CreatePlayableHandle() { }

	// RVA: 0xFFFFFFFF7114CA60
	internal Boolean CreateScriptOutputInternal(String name, out PlayableOutputHandle handle) { }

	// RVA: 0xFFFFFFFF7114CAB8
	internal PlayableHandle GetRootPlayableInternal(Int32 index) { }

	// RVA: 0xFFFFFFFF7114CB20
	private Boolean ConnectInternal(PlayableHandle source, Int32 sourceOutputPort, PlayableHandle destination, Int32 destinationInputPort) { }

	// RVA: 0xFFFFFFFF75C1D600
	private static Boolean IsValid_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0xFFFFFFFF75C1D680
	private static Boolean IsPlaying_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0xFFFFFFFF75C1D6C0
	private static Void Evaluate_Injected(ref PlayableGraph _unity_self, Single deltaTime) { }

	// RVA: 0xFFFFFFFF75C1D750
	private static IExposedPropertyTable GetResolver_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0xFFFFFFFF75C1D790
	private static Int32 GetPlayableCount_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0xFFFFFFFF75C1D810
	private static Int32 GetRootPlayableCount_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0xFFFFFFFF75C1D850
	private static Void CreatePlayableHandle_Injected(ref PlayableGraph _unity_self, out PlayableHandle ret) { }

	// RVA: 0xFFFFFFFF75C1D8F8
	private static Boolean CreateScriptOutputInternal_Injected(ref PlayableGraph _unity_self, String name, out PlayableOutputHandle handle) { }

	// RVA: 0xFFFFFFFF75C1D950
	private static Void GetRootPlayableInternal_Injected(ref PlayableGraph _unity_self, Int32 index, out PlayableHandle ret) { }

	// RVA: 0xFFFFFFFF75C1D9A8
	private static Boolean ConnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle source, Int32 sourceOutputPort, ref PlayableHandle destination, Int32 destinationInputPort) { }

}

// Namespace: UnityEngine.Playables
public enum PlayState
{
	// Fields
	public Int32 value__; // 0x10
	public const PlayState Paused = 0;
	public const PlayState Playing = 1;
	public const PlayState Delayed = 2;
}

// Namespace: UnityEngine.Playables
public struct PlayableHandle
{
	// Fields
	internal IntPtr m_Handle; // 0x10
	internal UInt32 m_Version; // 0x18
	private static readonly PlayableHandle m_Null; // 0x0

	// Properties
	public static PlayableHandle Null { get; }

	// Methods

	// RVA: -1
	internal T GetObject() { }

	// RVA: -1
	internal Boolean IsPlayableOfType() { }

	// RVA: 0xFFFFFFFF75C1D1CC
	public static PlayableHandle get_Null() { }

	// RVA: 0xFFFFFFFF7114CB94
	internal Playable GetInput(Int32 inputPort) { }

	// RVA: 0xFFFFFFFF7114CB9C
	internal Boolean SetInputWeight(Int32 inputIndex, Single weight) { }

	// RVA: 0xFFFFFFFF7114CBE8
	internal Single GetInputWeight(Int32 inputIndex) { }

	// RVA: 0xFFFFFFFF75C1D100
	public static Boolean op_Equality(PlayableHandle x, PlayableHandle y) { }

	// RVA: 0xFFFFFFFF7114CC1C
	public override Boolean Equals(Object p) { }

	// RVA: 0xFFFFFFFF7114CC24
	public Boolean Equals(PlayableHandle other) { }

	// RVA: 0xFFFFFFFF7114CC2C
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75C1DB58
	internal static Boolean CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	// RVA: 0xFFFFFFFF7114CC68
	internal Boolean CheckInputBounds(Int32 inputIndex) { }

	// RVA: 0xFFFFFFFF7114CC88
	internal Boolean CheckInputBounds(Int32 inputIndex, Boolean acceptAny) { }

	// RVA: 0xFFFFFFFF7114CCA4
	internal Boolean IsValid() { }

	// RVA: 0xFFFFFFFF7114CCAC
	internal Type GetPlayableType() { }

	// RVA: 0xFFFFFFFF7114CCB4
	internal Void SetScriptInstance(Object scriptInstance) { }

	// RVA: 0xFFFFFFFF7114CCBC
	internal PlayState GetPlayState() { }

	// RVA: 0xFFFFFFFF7114CCC4
	internal Void Play() { }

	// RVA: 0xFFFFFFFF7114CCCC
	internal Void Pause() { }

	// RVA: 0xFFFFFFFF7114CCD4
	internal Double GetSpeed() { }

	// RVA: 0xFFFFFFFF7114CCDC
	internal Void SetSpeed(Double value) { }

	// RVA: 0xFFFFFFFF7114CCE4
	internal Double GetTime() { }

	// RVA: 0xFFFFFFFF7114CCEC
	internal Void SetTime(Double value) { }

	// RVA: 0xFFFFFFFF7114CCF4
	internal Boolean IsDone() { }

	// RVA: 0xFFFFFFFF7114CCFC
	internal Double GetDuration() { }

	// RVA: 0xFFFFFFFF7114CD04
	internal Void SetDuration(Double value) { }

	// RVA: 0xFFFFFFFF7114CD0C
	internal Void SetPropagateSetTime(Boolean value) { }

	// RVA: 0xFFFFFFFF7114CD14
	internal PlayableGraph GetGraph() { }

	// RVA: 0xFFFFFFFF7114CD1C
	internal Int32 GetInputCount() { }

	// RVA: 0xFFFFFFFF7114CD24
	internal Void SetInputCount(Int32 value) { }

	// RVA: 0xFFFFFFFF7114CD2C
	internal Void SetInputWeight(PlayableHandle input, Single weight) { }

	// RVA: 0xFFFFFFFF7114CD34
	internal Double GetPreviousTime() { }

	// RVA: 0xFFFFFFFF7114CD3C
	internal Void SetTraversalMode(PlayableTraversalMode mode) { }

	// RVA: 0xFFFFFFFF7114CD44
	internal DirectorWrapMode GetTimeWrapMode() { }

	// RVA: 0xFFFFFFFF7114CD4C
	internal Void SetTimeWrapMode(DirectorWrapMode mode) { }

	// RVA: 0xFFFFFFFF7114CD54
	private Object GetScriptInstance() { }

	// RVA: 0xFFFFFFFF7114CD5C
	private PlayableHandle GetInputHandle(Int32 index) { }

	// RVA: 0xFFFFFFFF7114CD64
	private Void SetInputWeightFromIndex(Int32 index, Single weight) { }

	// RVA: 0xFFFFFFFF7114CD6C
	private Single GetInputWeightFromIndex(Int32 index) { }

	// RVA: 0xFFFFFFFF75C1E610
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C1DC48
	private static Boolean IsValid_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0xFFFFFFFF75C1DC88
	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0xFFFFFFFF75C1DCC8
	private static Void SetScriptInstance_Injected(ref PlayableHandle _unity_self, Object scriptInstance) { }

	// RVA: 0xFFFFFFFF75C1DD18
	private static PlayState GetPlayState_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0xFFFFFFFF75C1DD58
	private static Void Play_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0xFFFFFFFF75C1DD98
	private static Void Pause_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0xFFFFFFFF75C1DE34
	private static Double GetSpeed_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0xFFFFFFFF75C1DE74
	private static Void SetSpeed_Injected(ref PlayableHandle _unity_self, Double value) { }

	// RVA: 0xFFFFFFFF75C1DEC4
	private static Double GetTime_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0xFFFFFFFF75C1DF04
	private static Void SetTime_Injected(ref PlayableHandle _unity_self, Double value) { }

	// RVA: 0xFFFFFFFF75C1DFB0
	private static Boolean IsDone_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0xFFFFFFFF75C1DFF0
	private static Double GetDuration_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0xFFFFFFFF75C1E030
	private static Void SetDuration_Injected(ref PlayableHandle _unity_self, Double value) { }

	// RVA: 0xFFFFFFFF75C1E080
	private static Void SetPropagateSetTime_Injected(ref PlayableHandle _unity_self, Boolean value) { }

	// RVA: 0xFFFFFFFF75C1E144
	private static Void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret) { }

	// RVA: 0xFFFFFFFF75C1E194
	private static Int32 GetInputCount_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0xFFFFFFFF75C1E1D4
	private static Void SetInputCount_Injected(ref PlayableHandle _unity_self, Int32 value) { }

	// RVA: 0xFFFFFFFF75C1E224
	private static Void SetInputWeight_Injected(ref PlayableHandle _unity_self, ref PlayableHandle input, Single weight) { }

	// RVA: 0xFFFFFFFF75C1E2E0
	private static Double GetPreviousTime_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0xFFFFFFFF75C1E320
	private static Void SetTraversalMode_Injected(ref PlayableHandle _unity_self, PlayableTraversalMode mode) { }

	// RVA: 0xFFFFFFFF75C1E3CC
	private static DirectorWrapMode GetTimeWrapMode_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0xFFFFFFFF75C1E478
	private static Void SetTimeWrapMode_Injected(ref PlayableHandle _unity_self, DirectorWrapMode mode) { }

	// RVA: 0xFFFFFFFF75C1E4C8
	private static Object GetScriptInstance_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0xFFFFFFFF75C1E508
	private static Void GetInputHandle_Injected(ref PlayableHandle _unity_self, Int32 index, out PlayableHandle ret) { }

	// RVA: 0xFFFFFFFF75C1E560
	private static Void SetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, Int32 index, Single weight) { }

	// RVA: 0xFFFFFFFF75C1E5C0
	private static Single GetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, Int32 index) { }

}

// Namespace: UnityEngine.Playables
public struct PlayableOutput
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x10
	private static readonly PlayableOutput m_NullPlayableOutput; // 0x0

	// Properties
	public static PlayableOutput Null { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C1D2C0
	public static PlayableOutput get_Null() { }

	// RVA: 0xFFFFFFFF7114CD74
	internal Void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0xFFFFFFFF7114CD7C
	public PlayableOutputHandle GetHandle() { }

	// RVA: -1
	public Boolean IsPlayableOutputOfType() { }

	// RVA: 0xFFFFFFFF7114CD88
	public Boolean Equals(PlayableOutput other) { }

	// RVA: 0xFFFFFFFF75C1E6DC
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Playables
public static class PlayableOutputExtensions
{
	// Methods

	// RVA: -1
	public static Void SetReferenceObject(U output, Object value) { }

	// RVA: -1
	public static Void SetUserData(U output, Object value) { }

	// RVA: -1
	public static Playable GetSourcePlayable(U output) { }

	// RVA: -1
	public static Void SetSourcePlayable(U output, V value, Int32 port) { }

	// RVA: -1
	public static Int32 GetSourceOutputPort(U output) { }

	// RVA: -1
	public static Void SetWeight(U output, Single value) { }

	// RVA: -1
	public static Void PushNotification(U output, Playable origin, INotification notification, Object context) { }

	// RVA: -1
	public static Void AddNotificationReceiver(U output, INotificationReceiver receiver) { }

}

// Namespace: UnityEngine.Playables
public struct PlayableOutputHandle
{
	// Fields
	internal IntPtr m_Handle; // 0x10
	internal UInt32 m_Version; // 0x18
	private static readonly PlayableOutputHandle m_Null; // 0x0

	// Properties
	public static PlayableOutputHandle Null { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C1E748
	public static PlayableOutputHandle get_Null() { }

	// RVA: -1
	internal Boolean IsPlayableOutputOfType() { }

	// RVA: 0xFFFFFFFF7114CD90
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75C1E684
	public static Boolean op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0xFFFFFFFF7114CDCC
	public override Boolean Equals(Object p) { }

	// RVA: 0xFFFFFFFF7114CDD4
	public Boolean Equals(PlayableOutputHandle other) { }

	// RVA: 0xFFFFFFFF75C1E7C0
	internal static Boolean CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0xFFFFFFFF7114CDDC
	internal Boolean IsValid() { }

	// RVA: 0xFFFFFFFF7114CDE4
	internal Type GetPlayableOutputType() { }

	// RVA: 0xFFFFFFFF7114CDEC
	internal Void SetReferenceObject(Object target) { }

	// RVA: 0xFFFFFFFF7114CDF4
	internal Void SetUserData(Object target) { }

	// RVA: 0xFFFFFFFF7114CDFC
	internal PlayableHandle GetSourcePlayable() { }

	// RVA: 0xFFFFFFFF7114CE04
	internal Void SetSourcePlayable(PlayableHandle target, Int32 port) { }

	// RVA: 0xFFFFFFFF7114CE0C
	internal Int32 GetSourceOutputPort() { }

	// RVA: 0xFFFFFFFF7114CE14
	internal Void SetWeight(Single weight) { }

	// RVA: 0xFFFFFFFF7114CE1C
	internal Void PushNotification(PlayableHandle origin, INotification notification, Object context) { }

	// RVA: 0xFFFFFFFF7114CE24
	internal Void AddNotificationReceiver(INotificationReceiver receiver) { }

	// RVA: 0xFFFFFFFF75C1EDB8
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C1E878
	private static Boolean IsValid_Injected(ref PlayableOutputHandle _unity_self) { }

	// RVA: 0xFFFFFFFF75C1E8B8
	private static Type GetPlayableOutputType_Injected(ref PlayableOutputHandle _unity_self) { }

	// RVA: 0xFFFFFFFF75C1E8F8
	private static Void SetReferenceObject_Injected(ref PlayableOutputHandle _unity_self, Object target) { }

	// RVA: 0xFFFFFFFF75C1E9B4
	private static Void SetUserData_Injected(ref PlayableOutputHandle _unity_self, Object target) { }

	// RVA: 0xFFFFFFFF75C1EA78
	private static Void GetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, out PlayableHandle ret) { }

	// RVA: 0xFFFFFFFF75C1EAC8
	private static Void SetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle target, Int32 port) { }

	// RVA: 0xFFFFFFFF75C1EB7C
	private static Int32 GetSourceOutputPort_Injected(ref PlayableOutputHandle _unity_self) { }

	// RVA: 0xFFFFFFFF75C1EBBC
	private static Void SetWeight_Injected(ref PlayableOutputHandle _unity_self, Single weight) { }

	// RVA: 0xFFFFFFFF75C1EC94
	private static Void PushNotification_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle origin, INotification notification, Object context) { }

	// RVA: 0xFFFFFFFF75C1ED68
	private static Void AddNotificationReceiver_Injected(ref PlayableOutputHandle _unity_self, INotificationReceiver receiver) { }

}

// Namespace: UnityEngine.Playables
public struct ScriptPlayable<T0>
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly ScriptPlayable<T0> m_NullPlayable; // 0x0

	// Properties
	public static ScriptPlayable<T0> Null { get; }

	// Methods

	// RVA: -1
	public static ScriptPlayable<T0> get_Null() { }

	// RVA: -1
	public static ScriptPlayable<T0> Create(PlayableGraph graph, Int32 inputCount) { }

	// RVA: -1
	public static ScriptPlayable<T0> Create(PlayableGraph graph, T template, Int32 inputCount) { }

	// RVA: -1
	private static PlayableHandle CreateHandle(PlayableGraph graph, T template, Int32 inputCount) { }

	// RVA: -1
	private static Object CreateScriptInstance() { }

	// RVA: -1
	private static Object CloneScriptInstance(IPlayableBehaviour source) { }

	// RVA: -1
	private static Object CloneScriptInstanceFromEngineObject(Object source) { }

	// RVA: -1
	private static Object CloneScriptInstanceFromIClonable(ICloneable source) { }

	// RVA: -1
	internal Void .ctor(PlayableHandle handle) { }

	// RVA: -1
	public PlayableHandle GetHandle() { }

	// RVA: -1
	public T GetBehaviour() { }

	// RVA: -1
	public static Playable op_Implicit(ScriptPlayable<T0> playable) { }

	// RVA: -1
	public Boolean Equals(ScriptPlayable<T0> other) { }

	// RVA: -1
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Playables
public static class ScriptPlayableBinding
{
	// Methods

	// RVA: 0xFFFFFFFF723C423C
	public static PlayableBinding Create(String name, Object key, Type type) { }

	// RVA: 0xFFFFFFFF723C42EC
	private static PlayableOutput CreateScriptOutput(PlayableGraph graph, String name) { }

}

// Namespace: UnityEngine.Playables
public struct ScriptPlayableOutput
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x10

	// Properties
	public static ScriptPlayableOutput Null { get; }

	// Methods

	// RVA: 0xFFFFFFFF723C42F0
	public static ScriptPlayableOutput Create(PlayableGraph graph, String name) { }

	// RVA: 0xFFFFFFFF7114CE2C
	internal Void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0xFFFFFFFF723C450C
	public static ScriptPlayableOutput get_Null() { }

	// RVA: 0xFFFFFFFF7114CE34
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0xFFFFFFFF75C1EDCC
	public static PlayableOutput op_Implicit(ScriptPlayableOutput output) { }

}

// Namespace: UnityEngine.Diagnostics
public enum ForcedCrashCategory
{
	// Fields
	public Int32 value__; // 0x10
	public const ForcedCrashCategory AccessViolation = 0;
	public const ForcedCrashCategory FatalError = 1;
	public const ForcedCrashCategory Abort = 2;
	public const ForcedCrashCategory PureVirtualFunction = 3;
}

// Namespace: UnityEngine.Diagnostics
public static class Utils
{
	// Methods

	// RVA: 0xFFFFFFFF75BEFC28
	public static Void ForceCrash(ForcedCrashCategory crashCategory) { }

}

// Namespace: UnityEngine.Experimental.U2D
internal struct SpriteIntermediateRendererInfo
{
	// Fields
	public Int32 SpriteID; // 0x10
	public Int32 TextureID; // 0x14
	public Int32 MaterialID; // 0x18
	public Color Color; // 0x1C
	public Matrix4x4 Transform; // 0x2C
	public Bounds Bounds; // 0x6C
	public Int32 Layer; // 0x84
	public Int32 SortingLayer; // 0x88
	public Int32 SortingOrder; // 0x8C
	public UInt64 SceneCullingMask; // 0x90
	public IntPtr IndexData; // 0x98
	public IntPtr VertexData; // 0xA0
	public Int32 IndexCount; // 0xA8
	public Int32 VertexCount; // 0xAC
	public Int32 ShaderChannelMask; // 0xB0
}

// Namespace: UnityEngine.Experimental.U2D
internal class SpriteRendererGroup
{}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum LightType
{
	// Fields
	public Byte value__; // 0x10
	public const LightType Directional = 0;
	public const LightType Point = 1;
	public const LightType Spot = 2;
	public const LightType Rectangle = 3;
	public const LightType Disc = 4;
	public const LightType SpotPyramidShape = 5;
	public const LightType SpotBoxShape = 6;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum LightMode
{
	// Fields
	public Byte value__; // 0x10
	public const LightMode Realtime = 0;
	public const LightMode Mixed = 1;
	public const LightMode Baked = 2;
	public const LightMode Unknown = 3;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum FalloffType
{
	// Fields
	public Byte value__; // 0x10
	public const FalloffType InverseSquared = 0;
	public const FalloffType InverseSquaredNoRangeAttenuation = 1;
	public const FalloffType Linear = 2;
	public const FalloffType Legacy = 3;
	public const FalloffType Undefined = 4;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum AngularFalloffType
{
	// Fields
	public Byte value__; // 0x10
	public const AngularFalloffType LUT = 0;
	public const AngularFalloffType AnalyticAndInnerAngle = 1;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct LinearColor
{
	// Fields
	private Single m_red; // 0x10
	private Single m_green; // 0x14
	private Single m_blue; // 0x18
	private Single m_intensity; // 0x1C

	// Methods

	// RVA: 0xFFFFFFFF75C01554
	public static LinearColor Convert(Color color, Single intensity) { }

	// RVA: 0xFFFFFFFF75C02918
	public static LinearColor Black() { }

}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct DirectionalLight
{
	// Fields
	public Int32 instanceID; // 0x10
	public Boolean shadow; // 0x14
	public LightMode mode; // 0x15
	public Vector3 direction; // 0x18
	public LinearColor color; // 0x24
	public LinearColor indirectColor; // 0x34
	public Single penumbraWidthRadian; // 0x44
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct PointLight
{
	// Fields
	public Int32 instanceID; // 0x10
	public Boolean shadow; // 0x14
	public LightMode mode; // 0x15
	public Vector3 position; // 0x18
	public LinearColor color; // 0x24
	public LinearColor indirectColor; // 0x34
	public Single range; // 0x44
	public Single sphereRadius; // 0x48
	public FalloffType falloff; // 0x4C
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct SpotLight
{
	// Fields
	public Int32 instanceID; // 0x10
	public Boolean shadow; // 0x14
	public LightMode mode; // 0x15
	public Vector3 position; // 0x18
	public Quaternion orientation; // 0x24
	public LinearColor color; // 0x34
	public LinearColor indirectColor; // 0x44
	public Single range; // 0x54
	public Single sphereRadius; // 0x58
	public Single coneAngle; // 0x5C
	public Single innerConeAngle; // 0x60
	public FalloffType falloff; // 0x64
	public AngularFalloffType angularFalloff; // 0x65
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct RectangleLight
{
	// Fields
	public Int32 instanceID; // 0x10
	public Boolean shadow; // 0x14
	public LightMode mode; // 0x15
	public Vector3 position; // 0x18
	public Quaternion orientation; // 0x24
	public LinearColor color; // 0x34
	public LinearColor indirectColor; // 0x44
	public Single range; // 0x54
	public Single width; // 0x58
	public Single height; // 0x5C
	public FalloffType falloff; // 0x60
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct DiscLight
{
	// Fields
	public Int32 instanceID; // 0x10
	public Boolean shadow; // 0x14
	public LightMode mode; // 0x15
	public Vector3 position; // 0x18
	public Quaternion orientation; // 0x24
	public LinearColor color; // 0x34
	public LinearColor indirectColor; // 0x44
	public Single range; // 0x54
	public Single radius; // 0x58
	public FalloffType falloff; // 0x5C
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct LightDataGI
{
	// Fields
	public Int32 instanceID; // 0x10
	public LinearColor color; // 0x14
	public LinearColor indirectColor; // 0x24
	public Quaternion orientation; // 0x34
	public Vector3 position; // 0x44
	public Single range; // 0x50
	public Single coneAngle; // 0x54
	public Single innerConeAngle; // 0x58
	public Single shape0; // 0x5C
	public Single shape1; // 0x60
	public LightType type; // 0x64
	public LightMode mode; // 0x65
	public Byte shadow; // 0x66
	public FalloffType falloff; // 0x67

	// Methods

	// RVA: 0xFFFFFFFF7114B92C
	public Void Init(ref DirectionalLight light) { }

	// RVA: 0xFFFFFFFF7114B934
	public Void Init(ref PointLight light) { }

	// RVA: 0xFFFFFFFF7114B93C
	public Void Init(ref SpotLight light) { }

	// RVA: 0xFFFFFFFF7114B944
	public Void Init(ref RectangleLight light) { }

	// RVA: 0xFFFFFFFF7114B94C
	public Void Init(ref DiscLight light) { }

	// RVA: 0xFFFFFFFF7114B954
	public Void InitNoBake(Int32 lightInstanceID) { }

}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class LightmapperUtils
{
	// Methods

	// RVA: 0xFFFFFFFF75C014D0
	public static LinearColor ExtractIndirect(Light l) { }

	// RVA: 0xFFFFFFFF75C0163C
	public static Single ExtractInnerCone(Light l) { }

	// RVA: 0xFFFFFFFF75C016BC
	public static Void Extract(Light l, ref DirectionalLight dir) { }

	// RVA: 0xFFFFFFFF75C017BC
	public static Void Extract(Light l, ref PointLight point) { }

	// RVA: 0xFFFFFFFF75C018D4
	public static Void Extract(Light l, ref SpotLight spot) { }

	// RVA: 0xFFFFFFFF75C01A48
	public static Void Extract(Light l, ref RectangleLight rect) { }

	// RVA: 0xFFFFFFFF75C01B94
	public static Void Extract(Light l, ref DiscLight disc) { }

}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class Lightmapping
{
	// Fields
	private static readonly RequestLightsDelegate s_DefaultDelegate; // 0x0
	private static RequestLightsDelegate s_RequestLightsDelegate; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75C01CE0
	public static Void SetDelegate(RequestLightsDelegate del) { }

	// RVA: 0xFFFFFFFF75C01D84
	public static RequestLightsDelegate GetDelegate() { }

	// RVA: 0xFFFFFFFF75C01DE4
	public static Void ResetDelegate() { }

	// RVA: 0xFFFFFFFF75C01E60
	internal static Void RequestLights(Light[] lights, IntPtr outLightsPtr, Int32 outLightsCount) { }

	// RVA: 0xFFFFFFFF75C02348
	private static Void .cctor() { }

}

// Namespace: 
public sealed class RequestLightsDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75C02464
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75C01F14
	public virtual Void Invoke(Light[] requests, NativeArray<T0> lightsOutput) { }

	// RVA: 0xFFFFFFFF75C0284C
	public virtual IAsyncResult BeginInvoke(Light[] requests, NativeArray<T0> lightsOutput, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75C0290C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class <>c
{
	// Fields
	public static readonly <>c <>9; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75C024A8
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C02510
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C02514
	internal Void <.cctor>b__7_0(Light[] requests, NativeArray<T0> lightsOutput) { }

}

// Namespace: UnityEngine.Experimental.Playables
public struct CameraPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114BB78
	public PlayableHandle GetHandle() { }

	// RVA: 0xFFFFFFFF7114BB84
	public Boolean Equals(CameraPlayable other) { }

}

// Namespace: UnityEngine.Experimental.Playables
public struct MaterialEffectPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114BB8C
	public PlayableHandle GetHandle() { }

	// RVA: 0xFFFFFFFF7114BB98
	public Boolean Equals(MaterialEffectPlayable other) { }

}

// Namespace: UnityEngine.Experimental.Playables
public struct TextureMixerPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114BBA0
	public PlayableHandle GetHandle() { }

	// RVA: 0xFFFFFFFF7114BBAC
	public Boolean Equals(TextureMixerPlayable other) { }

}

// Namespace: UnityEngine.Experimental.Playables
public struct TexturePlayableOutput
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114BBB4
	public PlayableOutputHandle GetHandle() { }

}

// Namespace: UnityEngine.Experimental.Rendering
internal class BuiltinRuntimeReflectionSystem
{
	// Methods

	// RVA: 0xFFFFFFFF723B96E8
	public Boolean TickRealtimeProbes() { }

	// RVA: 0xFFFFFFFF75C02AA4
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75C02AA8
	private Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75C02A70
	private static Boolean BuiltinUpdate() { }

	// RVA: 0xFFFFFFFF75C02AAC
	private static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New() { }

	// RVA: 0xFFFFFFFF75C02AB8
	public Void .ctor() { }

}

// Namespace: UnityEngine.Experimental.Rendering
public interface IScriptableRuntimeReflectionSystem
{
	// Methods

	// RVA: -1
	public abstract Boolean TickRealtimeProbes() { }

}

// Namespace: UnityEngine.Experimental.Rendering
public static class ScriptableRuntimeReflectionSystemSettings
{
	// Fields
	private static ScriptableRuntimeReflectionSystemWrapper s_Instance; // 0x0

	// Properties
	private static IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system { set; }
	private static ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C02BDC
	private static Void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(IScriptableRuntimeReflectionSystem value) { }

	// RVA: 0xFFFFFFFF75C02CEC
	private static ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance() { }

	// RVA: 0xFFFFFFFF75C02D34
	private static Void ScriptingDirtyReflectionSystemInstance() { }

	// RVA: 0xFFFFFFFF75C02D68
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Experimental.Rendering
internal class ScriptableRuntimeReflectionSystemWrapper
{
	// Fields
	private IScriptableRuntimeReflectionSystem <implementation>k__BackingField; // 0x10

	// Properties
	internal IScriptableRuntimeReflectionSystem implementation { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C02DB8
	internal IScriptableRuntimeReflectionSystem get_implementation() { }

	// RVA: 0xFFFFFFFF75C02DC0
	internal Void set_implementation(IScriptableRuntimeReflectionSystem value) { }

	// RVA: 0xFFFFFFFF723B98A0
	private Void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(out Boolean result) { }

	// RVA: 0xFFFFFFFF75C02DB4
	public Void .ctor() { }

}

// Namespace: UnityEngine.Experimental.Rendering
public enum TextureCreationFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const TextureCreationFlags None = 0;
	public const TextureCreationFlags MipChain = 1;
	public const TextureCreationFlags Crunch = 64;
}

// Namespace: UnityEngine.Experimental.Rendering
public enum FormatUsage
{
	// Fields
	public Int32 value__; // 0x10
	public const FormatUsage Sample = 0;
	public const FormatUsage Linear = 1;
	public const FormatUsage Sparse = 2;
	public const FormatUsage Render = 4;
	public const FormatUsage Blend = 5;
	public const FormatUsage GetPixels = 6;
	public const FormatUsage SetPixels = 7;
	public const FormatUsage SetPixels32 = 8;
	public const FormatUsage ReadPixels = 9;
	public const FormatUsage LoadStore = 10;
	public const FormatUsage MSAA2x = 11;
	public const FormatUsage MSAA4x = 12;
	public const FormatUsage MSAA8x = 13;
	public const FormatUsage StencilSampling = 15;
}

// Namespace: UnityEngine.Experimental.Rendering
public enum DefaultFormat
{
	// Fields
	public Int32 value__; // 0x10
	public const DefaultFormat LDR = 0;
	public const DefaultFormat HDR = 1;
}

// Namespace: UnityEngine.Experimental.Rendering
public enum GraphicsFormat
{
	// Fields
	public Int32 value__; // 0x10
	public const GraphicsFormat None = 0;
	public const GraphicsFormat R8_SRGB = 1;
	public const GraphicsFormat R8G8_SRGB = 2;
	public const GraphicsFormat R8G8B8_SRGB = 3;
	public const GraphicsFormat R8G8B8A8_SRGB = 4;
	public const GraphicsFormat R8_UNorm = 5;
	public const GraphicsFormat R8G8_UNorm = 6;
	public const GraphicsFormat R8G8B8_UNorm = 7;
	public const GraphicsFormat R8G8B8A8_UNorm = 8;
	public const GraphicsFormat R8_SNorm = 9;
	public const GraphicsFormat R8G8_SNorm = 10;
	public const GraphicsFormat R8G8B8_SNorm = 11;
	public const GraphicsFormat R8G8B8A8_SNorm = 12;
	public const GraphicsFormat R8_UInt = 13;
	public const GraphicsFormat R8G8_UInt = 14;
	public const GraphicsFormat R8G8B8_UInt = 15;
	public const GraphicsFormat R8G8B8A8_UInt = 16;
	public const GraphicsFormat R8_SInt = 17;
	public const GraphicsFormat R8G8_SInt = 18;
	public const GraphicsFormat R8G8B8_SInt = 19;
	public const GraphicsFormat R8G8B8A8_SInt = 20;
	public const GraphicsFormat R16_UNorm = 21;
	public const GraphicsFormat R16G16_UNorm = 22;
	public const GraphicsFormat R16G16B16_UNorm = 23;
	public const GraphicsFormat R16G16B16A16_UNorm = 24;
	public const GraphicsFormat R16_SNorm = 25;
	public const GraphicsFormat R16G16_SNorm = 26;
	public const GraphicsFormat R16G16B16_SNorm = 27;
	public const GraphicsFormat R16G16B16A16_SNorm = 28;
	public const GraphicsFormat R16_UInt = 29;
	public const GraphicsFormat R16G16_UInt = 30;
	public const GraphicsFormat R16G16B16_UInt = 31;
	public const GraphicsFormat R16G16B16A16_UInt = 32;
	public const GraphicsFormat R16_SInt = 33;
	public const GraphicsFormat R16G16_SInt = 34;
	public const GraphicsFormat R16G16B16_SInt = 35;
	public const GraphicsFormat R16G16B16A16_SInt = 36;
	public const GraphicsFormat R32_UInt = 37;
	public const GraphicsFormat R32G32_UInt = 38;
	public const GraphicsFormat R32G32B32_UInt = 39;
	public const GraphicsFormat R32G32B32A32_UInt = 40;
	public const GraphicsFormat R32_SInt = 41;
	public const GraphicsFormat R32G32_SInt = 42;
	public const GraphicsFormat R32G32B32_SInt = 43;
	public const GraphicsFormat R32G32B32A32_SInt = 44;
	public const GraphicsFormat R16_SFloat = 45;
	public const GraphicsFormat R16G16_SFloat = 46;
	public const GraphicsFormat R16G16B16_SFloat = 47;
	public const GraphicsFormat R16G16B16A16_SFloat = 48;
	public const GraphicsFormat R32_SFloat = 49;
	public const GraphicsFormat R32G32_SFloat = 50;
	public const GraphicsFormat R32G32B32_SFloat = 51;
	public const GraphicsFormat R32G32B32A32_SFloat = 52;
	public const GraphicsFormat B8G8R8_SRGB = 56;
	public const GraphicsFormat B8G8R8A8_SRGB = 57;
	public const GraphicsFormat B8G8R8_UNorm = 58;
	public const GraphicsFormat B8G8R8A8_UNorm = 59;
	public const GraphicsFormat B8G8R8_SNorm = 60;
	public const GraphicsFormat B8G8R8A8_SNorm = 61;
	public const GraphicsFormat B8G8R8_UInt = 62;
	public const GraphicsFormat B8G8R8A8_UInt = 63;
	public const GraphicsFormat B8G8R8_SInt = 64;
	public const GraphicsFormat B8G8R8A8_SInt = 65;
	public const GraphicsFormat R4G4B4A4_UNormPack16 = 66;
	public const GraphicsFormat B4G4R4A4_UNormPack16 = 67;
	public const GraphicsFormat R5G6B5_UNormPack16 = 68;
	public const GraphicsFormat B5G6R5_UNormPack16 = 69;
	public const GraphicsFormat R5G5B5A1_UNormPack16 = 70;
	public const GraphicsFormat B5G5R5A1_UNormPack16 = 71;
	public const GraphicsFormat A1R5G5B5_UNormPack16 = 72;
	public const GraphicsFormat E5B9G9R9_UFloatPack32 = 73;
	public const GraphicsFormat B10G11R11_UFloatPack32 = 74;
	public const GraphicsFormat A2B10G10R10_UNormPack32 = 75;
	public const GraphicsFormat A2B10G10R10_UIntPack32 = 76;
	public const GraphicsFormat A2B10G10R10_SIntPack32 = 77;
	public const GraphicsFormat A2R10G10B10_UNormPack32 = 78;
	public const GraphicsFormat A2R10G10B10_UIntPack32 = 79;
	public const GraphicsFormat A2R10G10B10_SIntPack32 = 80;
	public const GraphicsFormat A2R10G10B10_XRSRGBPack32 = 81;
	public const GraphicsFormat A2R10G10B10_XRUNormPack32 = 82;
	public const GraphicsFormat R10G10B10_XRSRGBPack32 = 83;
	public const GraphicsFormat R10G10B10_XRUNormPack32 = 84;
	public const GraphicsFormat A10R10G10B10_XRSRGBPack32 = 85;
	public const GraphicsFormat A10R10G10B10_XRUNormPack32 = 86;
	public const GraphicsFormat RGB_DXT1_SRGB = 96;
	public const GraphicsFormat RGBA_DXT1_SRGB = 96;
	public const GraphicsFormat RGB_DXT1_UNorm = 97;
	public const GraphicsFormat RGBA_DXT1_UNorm = 97;
	public const GraphicsFormat RGBA_DXT3_SRGB = 98;
	public const GraphicsFormat RGBA_DXT3_UNorm = 99;
	public const GraphicsFormat RGBA_DXT5_SRGB = 100;
	public const GraphicsFormat RGBA_DXT5_UNorm = 101;
	public const GraphicsFormat R_BC4_UNorm = 102;
	public const GraphicsFormat R_BC4_SNorm = 103;
	public const GraphicsFormat RG_BC5_UNorm = 104;
	public const GraphicsFormat RG_BC5_SNorm = 105;
	public const GraphicsFormat RGB_BC6H_UFloat = 106;
	public const GraphicsFormat RGB_BC6H_SFloat = 107;
	public const GraphicsFormat RGBA_BC7_SRGB = 108;
	public const GraphicsFormat RGBA_BC7_UNorm = 109;
	public const GraphicsFormat RGB_PVRTC_2Bpp_SRGB = 110;
	public const GraphicsFormat RGB_PVRTC_2Bpp_UNorm = 111;
	public const GraphicsFormat RGB_PVRTC_4Bpp_SRGB = 112;
	public const GraphicsFormat RGB_PVRTC_4Bpp_UNorm = 113;
	public const GraphicsFormat RGBA_PVRTC_2Bpp_SRGB = 114;
	public const GraphicsFormat RGBA_PVRTC_2Bpp_UNorm = 115;
	public const GraphicsFormat RGBA_PVRTC_4Bpp_SRGB = 116;
	public const GraphicsFormat RGBA_PVRTC_4Bpp_UNorm = 117;
	public const GraphicsFormat RGB_ETC_UNorm = 118;
	public const GraphicsFormat RGB_ETC2_SRGB = 119;
	public const GraphicsFormat RGB_ETC2_UNorm = 120;
	public const GraphicsFormat RGB_A1_ETC2_SRGB = 121;
	public const GraphicsFormat RGB_A1_ETC2_UNorm = 122;
	public const GraphicsFormat RGBA_ETC2_SRGB = 123;
	public const GraphicsFormat RGBA_ETC2_UNorm = 124;
	public const GraphicsFormat R_EAC_UNorm = 125;
	public const GraphicsFormat R_EAC_SNorm = 126;
	public const GraphicsFormat RG_EAC_UNorm = 127;
	public const GraphicsFormat RG_EAC_SNorm = 128;
	public const GraphicsFormat RGBA_ASTC4X4_SRGB = 129;
	public const GraphicsFormat RGBA_ASTC4X4_UNorm = 130;
	public const GraphicsFormat RGBA_ASTC5X5_SRGB = 131;
	public const GraphicsFormat RGBA_ASTC5X5_UNorm = 132;
	public const GraphicsFormat RGBA_ASTC6X6_SRGB = 133;
	public const GraphicsFormat RGBA_ASTC6X6_UNorm = 134;
	public const GraphicsFormat RGBA_ASTC8X8_SRGB = 135;
	public const GraphicsFormat RGBA_ASTC8X8_UNorm = 136;
	public const GraphicsFormat RGBA_ASTC10X10_SRGB = 137;
	public const GraphicsFormat RGBA_ASTC10X10_UNorm = 138;
	public const GraphicsFormat RGBA_ASTC12X12_SRGB = 139;
	public const GraphicsFormat RGBA_ASTC12X12_UNorm = 140;
}

// Namespace: UnityEngine.Experimental.Rendering
public enum RayTracingMode
{
	// Fields
	public Int32 value__; // 0x10
	public const RayTracingMode Off = 0;
	public const RayTracingMode Static = 1;
	public const RayTracingMode DynamicTransform = 2;
	public const RayTracingMode DynamicGeometry = 3;
}

// Namespace: UnityEngine.Experimental.Rendering
public class GraphicsFormatUtility
{
	// Methods

	// RVA: 0xFFFFFFFF75C02ABC
	internal static GraphicsFormat GetFormat(Texture texture) { }

	// RVA: 0xFFFFFFFF75BFC250
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, Boolean isSRGB) { }

	// RVA: 0xFFFFFFFF75C02AFC
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, Boolean isSRGB) { }

	// RVA: 0xFFFFFFFF723B9724
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, Boolean isSRGB) { }

	// RVA: 0xFFFFFFFF75C02B4C
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, Boolean isSRGB) { }

	// RVA: 0xFFFFFFFF723B9778
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0xFFFFFFFF723B9808
	public static Boolean IsSRGBFormat(GraphicsFormat format) { }

	// RVA: 0xFFFFFFFF723B985C
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	// RVA: 0xFFFFFFFF75C02B9C
	internal static Boolean IsCompressedTextureFormat(TextureFormat format) { }

	// RVA: 0xFFFFFFFF75BFC2A0
	public static Boolean IsCrunchFormat(TextureFormat format) { }

}

// Namespace: UnityEngine.Assertions
public static class Assert
{
	// Fields
	public static Boolean raiseExceptions; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75BF3364
	private static Void Fail(String message, String userMessage) { }

	// RVA: -1
	public static Void AreEqual(T expected, T actual, String message) { }

	// RVA: -1
	public static Void AreEqual(T expected, T actual, String message, IEqualityComparer<T0> comparer) { }

	// RVA: 0xFFFFFFFF75BF35CC
	public static Void AreEqual(Object expected, Object actual, String message) { }

	// RVA: 0xFFFFFFFF75BF3838
	public static Void AreEqual(Int32 expected, Int32 actual) { }

	// RVA: 0xFFFFFFFF75BF38D4
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Assertions
public class AssertionException
{
	// Fields
	private String m_UserMessage; // 0x88

	// Properties
	public override String Message { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BF3554
	public Void .ctor(String message, String userMessage) { }

	// RVA: 0xFFFFFFFF75BF3920
	public override String get_Message() { }

}

// Namespace: UnityEngine.Assertions
internal class AssertionMessageUtil
{
	// Methods

	// RVA: 0xFFFFFFFF75BF3988
	public static String GetMessage(String failureMessage) { }

	// RVA: 0xFFFFFFFF75BF3A30
	public static String GetMessage(String failureMessage, String expected) { }

	// RVA: 0xFFFFFFFF75BF3690
	public static String GetEqualityMessage(Object actual, Object expected, Boolean expectEqual) { }

}


