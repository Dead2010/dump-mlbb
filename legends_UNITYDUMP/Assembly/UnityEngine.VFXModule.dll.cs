// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.VFX
public sealed class VFXEventAttribute
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private Boolean m_Owner; // 0x18
	private VisualEffectAsset m_VfxAsset; // 0x20
}

// Namespace: UnityEngine.VFX
internal class VFXExpressionMesh
{}

// Namespace: UnityEngine.VFX
internal class VFXExpressionNoise
{}

// Namespace: UnityEngine.VFX
public class VFXExpressionValues
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75CA6F18
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF75CA6F20
	internal static VFXExpressionValues CreateExpressionValuesWrapper(IntPtr ptr) { }

}

// Namespace: UnityEngine.VFX
public static class VFXManager
{}

// Namespace: UnityEngine.VFX
public abstract class VFXSpawnerCallbacks
{
	// Methods

	// RVA: -1
	public abstract Void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	// RVA: -1
	public abstract Void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	// RVA: -1
	public abstract Void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	// RVA: 0xFFFFFFFF75CA6F7C
	protected Void .ctor() { }

}

// Namespace: UnityEngine.VFX
public sealed class VFXSpawnerState
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private Boolean m_Owner; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75CA6F84
	internal Void .ctor(IntPtr ptr, Boolean owner) { }

	// RVA: 0xFFFFFFFF75CA6FC0
	internal static VFXSpawnerState CreateSpawnerStateWrapper() { }

	// RVA: 0xFFFFFFFF75CA701C
	internal Void SetWrapValue(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF75CA70AC
	private Void Release() { }

	// RVA: 0xFFFFFFFF75CA715C
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75CA71C4
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75CA711C
	private static Void Internal_Destroy(IntPtr ptr) { }

}

// Namespace: UnityEngine.VFX
public abstract class VisualEffectObject
{}

// Namespace: UnityEngine.VFX
public class VisualEffectAsset
{
	// Fields
	public static readonly Int32 PlayEventID; // 0x0
	public static readonly Int32 StopEventID; // 0x4

	// Methods

	// RVA: 0xFFFFFFFF75CA7208
	private static Void .cctor() { }

}

// Namespace: UnityEngine.VFX
public class VisualEffect
{}


