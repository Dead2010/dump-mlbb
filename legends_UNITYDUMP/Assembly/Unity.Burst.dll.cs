// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75BBC5B8
	public Void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class IsReadOnlyAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75BBC5C0
	public Void .ctor() { }

}

// Namespace: Unity.Burst
public class BurstCompileAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75BBC5C8
	public Void .ctor() { }

}

// Namespace: Unity.Burst
public static class BurstRuntime
{
	// Fields
	private static readonly NativeLogDelegate ManagedNativeLog; // 0x0

	// Methods

	// RVA: -1
	public static Int32 GetHashCode32() { }

	// RVA: 0xFFFFFFFF75BBC6D4
	public static Int32 GetHashCode32(Type type) { }

	// RVA: -1
	public static Int64 GetHashCode64() { }

	// RVA: 0xFFFFFFFF75BBC7AC
	public static Int64 GetHashCode64(Type type) { }

	// RVA: 0xFFFFFFFF75BBC728
	internal static Int32 HashStringWithFNV1A32(String text) { }

	// RVA: 0xFFFFFFFF723A96C8
	internal static Int64 HashStringWithFNV1A64(String text) { }

	// RVA: 0xFFFFFFFF75BBC800
	internal static Void Log(Byte* message, Int32 logType, Byte* fileName, Int32 lineNumber) { }

	// RVA: 0xFFFFFFFF75BBC5D0
	private static Void ManagedNativeLogImpl(Byte* message, Int32 logType, Byte* filename, Int32 lineNumber) { }

	// RVA: 0xFFFFFFFF75BBCB64
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75BBCC48
	internal static Void Initialize() { }

}

// Namespace: 
private struct HashCode32<T0>
{
	// Fields
	public static readonly Int32 Value; // 0x0

	// Methods

	// RVA: -1
	private static Void .cctor() { }

}

// Namespace: 
private struct HashCode64<T0>
{
	// Fields
	public static readonly Int64 Value; // 0x0

	// Methods

	// RVA: -1
	private static Void .cctor() { }

}

// Namespace: 
private sealed class NativeLogDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75BBCC34
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75BBC8E8
	public virtual Void Invoke(Byte* message, Int32 logType, Byte* filename, Int32 lineNumber) { }

	// RVA: 0xFFFFFFFF75BBCC7C
	public virtual IAsyncResult BeginInvoke(Byte* message, Int32 logType, Byte* filename, Int32 lineNumber, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BBCD2C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private class LogHelper
{
	// Fields
	public static readonly SharedStatic<T0> Instance; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75BBCC4C
	private static Void .cctor() { }

}

// Namespace: Unity.Burst
public struct FunctionPointer<T0>
{
	// Fields
	private readonly IntPtr _ptr; // 0x0

	// Properties
	public T Invoke { get; }
	public Boolean IsCreated { get; }

	// Methods

	// RVA: -1
	public Void .ctor(IntPtr ptr) { }

	// RVA: -1
	public T get_Invoke() { }

	// RVA: -1
	public Boolean get_IsCreated() { }

}

// Namespace: Unity.Burst
public struct SharedStatic<T0>
{
	// Fields
	private readonly Void* _buffer; // 0x0

	// Properties
	public T Data { get; }

	// Methods

	// RVA: -1
	private Void .ctor(Void* buffer) { }

	// RVA: -1
	public ref T get_Data() { }

	// RVA: -1
	public static SharedStatic<T0> GetOrCreate(UInt32 alignment) { }

}

// Namespace: Unity.Burst
internal static class SharedStatic
{
	// Fields
	private static readonly Dictionary<T0, T1> HashToType; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75BBCD38
	public static Void* GetOrCreateSharedStaticInternal(Int64 getHashCode64, Int64 getSubHashCode64, UInt32 sizeOf, UInt32 alignment) { }

	// RVA: 0xFFFFFFFF75BBCD8C
	private static Void .cctor() { }

}


