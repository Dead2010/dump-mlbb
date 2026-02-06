// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public interface ISubsystemDescriptor
{}

// Namespace: UnityEngine
internal interface ISubsystemDescriptorImpl
{
	// Properties
	public abstract IntPtr ptr { set; }

	// Methods

	// RVA: -1
	public abstract Void set_ptr(IntPtr value) { }

}

// Namespace: UnityEngine
public abstract class IntegratedSubsystemDescriptor
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	private IntPtr UnityEngine.ISubsystemDescriptorImpl.ptr { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C7EEB4
	private Void UnityEngine.ISubsystemDescriptorImpl.set_ptr(IntPtr value) { }

	// RVA: 0xFFFFFFFF75C7EEBC
	protected Void .ctor() { }

}

// Namespace: UnityEngine
public abstract class SubsystemDescriptor
{
	// Fields
	private String <id>k__BackingField; // 0x10

	// Properties
	public String id { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C7FAF4
	public String get_id() { }

	// RVA: 0xFFFFFFFF75C7FAFC
	protected Void .ctor() { }

}

// Namespace: UnityEngine
public class IntegratedSubsystemDescriptor<T0>
{
	// Methods

	// RVA: -1
	public Void .ctor() { }

}

// Namespace: UnityEngine
internal static class Internal_SubsystemInstances
{
	// Fields
	internal static List<T0> s_IntegratedSubsystemInstances; // 0x0
	internal static List<T0> s_StandaloneSubsystemInstances; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75C7F468
	internal static Void Internal_InitializeManagedInstance(IntPtr ptr, IntegratedSubsystem inst) { }

	// RVA: 0xFFFFFFFF75C7F52C
	internal static Void Internal_ClearManagedInstances() { }

	// RVA: 0xFFFFFFFF75C7F6E0
	internal static Void Internal_RemoveInstanceByPtr(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF75C7F898
	internal static IntegratedSubsystem Internal_GetInstanceByPtr(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF75C7FA44
	private static Void .cctor() { }

}

// Namespace: UnityEngine
internal static class Internal_SubsystemDescriptors
{
	// Fields
	internal static List<T0> s_IntegratedSubsystemDescriptors; // 0x0
	internal static List<T0> s_StandaloneSubsystemDescriptors; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75C7EEC4
	internal static Boolean Internal_AddDescriptor(SubsystemDescriptor descriptor) { }

	// RVA: 0xFFFFFFFF75C7F0CC
	internal static Void Internal_InitializeManagedDescriptor(IntPtr ptr, ISubsystemDescriptorImpl desc) { }

	// RVA: 0xFFFFFFFF75C7F1D0
	internal static Void Internal_ClearManagedDescriptors() { }

	// RVA: 0xFFFFFFFF75C7F3A0
	private static Void .cctor() { }

}

// Namespace: UnityEngine
public static class SubsystemManager
{
	// Fields
	private static Action reloadSubsytemsStarted; // 0x0
	private static Action reloadSubsytemsCompleted; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75C7FB04
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C7F08C
	internal static Void ReportSingleSubsystemAnalytics(String id) { }

	// RVA: 0xFFFFFFFF75C7FB38
	internal static Void StaticConstructScriptingClassMap() { }

	// RVA: 0xFFFFFFFF75C7FB6C
	private static Void Internal_ReloadSubsystemsStarted() { }

	// RVA: 0xFFFFFFFF75C7FBE0
	private static Void Internal_ReloadSubsystemsCompleted() { }

}

// Namespace: UnityEngine
public interface ISubsystem
{}

// Namespace: UnityEngine
public class IntegratedSubsystem
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal ISubsystemDescriptor m_subsystemDescriptor; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75C7EE5C
	internal Void SetHandle(IntegratedSubsystem inst) { }

	// RVA: 0xFFFFFFFF75C7EEAC
	public Void .ctor() { }

}

// Namespace: UnityEngine
public class IntegratedSubsystem<T0>
{
	// Methods

	// RVA: -1
	public Void .ctor() { }

}


