// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.XR
public static class XRDevice
{
	// Fields
	private static Action<T0> deviceLoaded; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75CA77B0
	private static Void InvokeDeviceLoaded(String loadedDeviceName) { }

	// RVA: 0xFFFFFFFF75CA7830
	private static Void .cctor() { }

}

// Namespace: UnityEngine.XR.WSA
public class WorldAnchor
{
	// Fields
	private OnTrackingChangedDelegate OnTrackingChanged; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75CA7294
	private static Void Internal_TriggerEventOnTrackingLost(WorldAnchor worldAnchor, Boolean located) { }

}

// Namespace: 
public sealed class OnTrackingChangedDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75CA76FC
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75CA72B8
	public virtual Void Invoke(WorldAnchor worldAnchor, Boolean located) { }

	// RVA: 0xFFFFFFFF75CA7710
	public virtual IAsyncResult BeginInvoke(WorldAnchor worldAnchor, Boolean located, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75CA77A4
	public virtual Void EndInvoke(IAsyncResult result) { }

}


