// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngineInternal.Input
internal sealed class NativeUpdateCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75C6C304
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75C6C00C
	public virtual Void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer) { }

	// RVA: 0xFFFFFFFF75C6C318
	public virtual IAsyncResult BeginInvoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75C6C3D4
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngineInternal.Input
internal struct NativeInputEventBuffer
{
	// Fields
	public Void* eventBuffer; // 0x10
	public Int32 eventCount; // 0x18
	public Int32 sizeInBytes; // 0x1C
	public Int32 capacityInBytes; // 0x20
}

// Namespace: UnityEngineInternal.Input
internal enum NativeInputUpdateType
{
	// Fields
	public Int32 value__; // 0x10
	public const NativeInputUpdateType Dynamic = 1;
	public const NativeInputUpdateType Fixed = 2;
	public const NativeInputUpdateType BeforeRender = 4;
	public const NativeInputUpdateType Editor = 8;
	public const NativeInputUpdateType IgnoreFocus = 2147483648;
}

// Namespace: UnityEngineInternal.Input
internal class NativeInputSystem
{
	// Fields
	public static NativeUpdateCallback onUpdate; // 0x0
	public static Action<T0> onBeforeUpdate; // 0x8
	public static Func<T0, T1> onShouldRunUpdate; // 0x10
	private static Action<T0, T1> s_OnDeviceDiscoveredCallback; // 0x18

	// Properties
	internal static Boolean hasDeviceDiscoveredCallback { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C6BF90
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF723D4A90
	internal static Void NotifyBeforeUpdate(NativeInputUpdateType updateType) { }

	// RVA: 0xFFFFFFFF723D4B08
	internal static Void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) { }

	// RVA: 0xFFFFFFFF75C6C290
	internal static Void NotifyDeviceDiscovered(Int32 deviceId, String deviceDescriptor) { }

	// RVA: 0xFFFFFFFF723D4B90
	internal static Void ShouldRunUpdate(NativeInputUpdateType updateType, out Boolean retval) { }

	// RVA: 0xFFFFFFFF75C6BFCC
	internal static Void set_hasDeviceDiscoveredCallback(Boolean value) { }

}


