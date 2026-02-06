// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public enum TouchPhase
{
	// Fields
	public Int32 value__; // 0x10
	public const TouchPhase Began = 0;
	public const TouchPhase Moved = 1;
	public const TouchPhase Stationary = 2;
	public const TouchPhase Ended = 3;
	public const TouchPhase Canceled = 4;
}

// Namespace: UnityEngine
public enum IMECompositionMode
{
	// Fields
	public Int32 value__; // 0x10
	public const IMECompositionMode Auto = 0;
	public const IMECompositionMode On = 1;
	public const IMECompositionMode Off = 2;
}

// Namespace: UnityEngine
public enum TouchType
{
	// Fields
	public Int32 value__; // 0x10
	public const TouchType Direct = 0;
	public const TouchType Indirect = 1;
	public const TouchType Stylus = 2;
}

// Namespace: UnityEngine
public struct Touch
{
	// Fields
	private Int32 m_FingerId; // 0x10
	private Vector2 m_Position; // 0x14
	private Vector2 m_RawPosition; // 0x1C
	private Vector2 m_PositionDelta; // 0x24
	private Single m_TimeDelta; // 0x2C
	private Int32 m_TapCount; // 0x30
	private TouchPhase m_Phase; // 0x34
	private TouchType m_Type; // 0x38
	private Single m_Pressure; // 0x3C
	private Single m_maximumPossiblePressure; // 0x40
	private Single m_Radius; // 0x44
	private Single m_RadiusVariance; // 0x48
	private Single m_AltitudeAngle; // 0x4C
	private Single m_AzimuthAngle; // 0x50

	// Properties
	public Int32 fingerId { get; }
	public Vector2 position { get; }
	public Vector2 rawPosition { get; }
	public Vector2 deltaPosition { get; }
	public Single deltaTime { get; }
	public Int32 tapCount { get; }
	public TouchPhase phase { get; }
	public TouchType type { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114F7E4
	public Int32 get_fingerId() { }

	// RVA: 0xFFFFFFFF7114F7EC
	public Vector2 get_position() { }

	// RVA: 0xFFFFFFFF7114F7F4
	public Vector2 get_rawPosition() { }

	// RVA: 0xFFFFFFFF7114F7FC
	public Vector2 get_deltaPosition() { }

	// RVA: 0xFFFFFFFF7114F804
	public Single get_deltaTime() { }

	// RVA: 0xFFFFFFFF7114F80C
	public Int32 get_tapCount() { }

	// RVA: 0xFFFFFFFF7114F814
	public TouchPhase get_phase() { }

	// RVA: 0xFFFFFFFF7114F81C
	public TouchType get_type() { }

}

// Namespace: UnityEngine
public enum DeviceOrientation
{
	// Fields
	public Int32 value__; // 0x10
	public const DeviceOrientation Unknown = 0;
	public const DeviceOrientation Portrait = 1;
	public const DeviceOrientation PortraitUpsideDown = 2;
	public const DeviceOrientation LandscapeLeft = 3;
	public const DeviceOrientation LandscapeRight = 4;
	public const DeviceOrientation FaceUp = 5;
	public const DeviceOrientation FaceDown = 6;
}

// Namespace: UnityEngine
public struct AccelerationEvent
{
	// Fields
	internal Single x; // 0x10
	internal Single y; // 0x14
	internal Single z; // 0x18
	internal Single m_TimeDelta; // 0x1C
}

// Namespace: UnityEngine
public class Gyroscope
{
	// Fields
	private Int32 m_GyroIndex; // 0x10

	// Properties
	public Vector3 gravity { get; }
	public Boolean enabled { get; set; }
	public Single updateInterval { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C69E80
	internal Void .ctor(Int32 index) { }

	// RVA: 0xFFFFFFFF723D4788
	private static Vector3 gravity_Internal(Int32 idx) { }

	// RVA: 0xFFFFFFFF75C69EFC
	private static Boolean getEnabled_Internal(Int32 idx) { }

	// RVA: 0xFFFFFFFF75C69F3C
	private static Void setEnabled_Internal(Int32 idx, Boolean enabled) { }

	// RVA: 0xFFFFFFFF75C69F8C
	private static Void setUpdateInterval_Internal(Int32 idx, Single interval) { }

	// RVA: 0xFFFFFFFF723D47EC
	public Vector3 get_gravity() { }

	// RVA: 0xFFFFFFFF75C69FDC
	public Boolean get_enabled() { }

	// RVA: 0xFFFFFFFF723D4850
	public Void set_enabled(Boolean value) { }

	// RVA: 0xFFFFFFFF75C6A020
	public Void set_updateInterval(Single value) { }

	// RVA: 0xFFFFFFFF75C69EAC
	private static Void gravity_Internal_Injected(Int32 idx, out Vector3 ret) { }

}

// Namespace: UnityEngine
public class LocationService
{
	// Methods

	// RVA: 0xFFFFFFFF75C6AE60
	public Void .ctor() { }

}

// Namespace: UnityEngine
public class Compass
{
	// Methods

	// RVA: 0xFFFFFFFF75C69E78
	public Void .ctor() { }

}

// Namespace: UnityEngine
internal class CameraRaycastHelper
{
	// Methods

	// RVA: 0xFFFFFFFF75C69CD8
	internal static GameObject RaycastTry(Camera cam, Ray ray, Single distance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C69DA8
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, Single distance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C69D40
	private static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, Single distance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C69E10
	private static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, Single distance, Int32 layerMask) { }

}

// Namespace: UnityEngine
public class Input
{
	// Fields
	private static LocationService locationServiceInstance; // 0x0
	private static Compass compassInstance; // 0x8
	private static Gyroscope s_MainGyro; // 0x10
	private static Boolean s_isMouseEventSkipRaycast; // 0x18

	// Properties
	public static Boolean simulateMouseWithTouches { get; set; }
	public static Boolean anyKey { get; }
	public static Boolean anyKeyDown { get; }
	public static String inputString { get; }
	public static Vector3 mousePosition { get; }
	public static Vector2 mouseScrollDelta { get; }
	public static IMECompositionMode imeCompositionMode { get; set; }
	public static String compositionString { get; }
	public static Boolean imeIsSelected { get; }
	public static Vector2 compositionCursorPos { get; set; }
	public static Boolean mousePresent { get; }
	public static Int32 touchCount { get; }
	public static Boolean touchPressureSupported { get; }
	public static Boolean stylusTouchSupported { get; }
	public static Boolean touchSupported { get; }
	public static Boolean multiTouchEnabled { get; set; }
	public static DeviceOrientation deviceOrientation { get; }
	public static Vector3 acceleration { get; }
	public static Boolean compensateSensors { get; set; }
	public static Int32 accelerationEventCount { get; }
	public static Boolean backButtonLeavesApp { get; set; }
	public static LocationService location { get; }
	public static Compass compass { get; }
	public static Gyroscope gyro { get; }
	public static Boolean isMouseEventSkipRaycast { get; set; }
	public static Touch[] touches { get; }
	public static AccelerationEvent[] accelerationEvents { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C6A074
	private static Boolean GetKeyInt(KeyCode key) { }

	// RVA: 0xFFFFFFFF75C6A0B4
	private static Boolean GetKeyString(String name) { }

	// RVA: 0xFFFFFFFF75C6A0F4
	private static Boolean GetKeyUpInt(KeyCode key) { }

	// RVA: 0xFFFFFFFF75C6A134
	private static Boolean GetKeyUpString(String name) { }

	// RVA: 0xFFFFFFFF75C6A174
	private static Boolean GetKeyDownInt(KeyCode key) { }

	// RVA: 0xFFFFFFFF75C6A1B4
	private static Boolean GetKeyDownString(String name) { }

	// RVA: 0xFFFFFFFF75C6A1F4
	public static Single GetAxis(String axisName) { }

	// RVA: 0xFFFFFFFF75C6A234
	public static Single GetAxisRaw(String axisName) { }

	// RVA: 0xFFFFFFFF75C6A274
	public static Boolean GetButton(String buttonName) { }

	// RVA: 0xFFFFFFFF75C6A2B4
	public static Boolean GetButtonDown(String buttonName) { }

	// RVA: 0xFFFFFFFF75C6A2F4
	public static Boolean GetButtonUp(String buttonName) { }

	// RVA: 0xFFFFFFFF75C6A334
	public static Boolean GetMouseButton(Int32 button) { }

	// RVA: 0xFFFFFFFF75C6A374
	public static Boolean GetMouseButtonDown(Int32 button) { }

	// RVA: 0xFFFFFFFF75C6A3B4
	public static Boolean GetMouseButtonUp(Int32 button) { }

	// RVA: 0xFFFFFFFF75C6A3F4
	public static Void ResetInputAxes() { }

	// RVA: 0xFFFFFFFF75C6A428
	public static String[] GetJoystickNames() { }

	// RVA: 0xFFFFFFFF75C6A45C
	public static Touch GetTouch(Int32 index) { }

	// RVA: 0xFFFFFFFF75C6A534
	public static AccelerationEvent GetAccelerationEvent(Int32 index) { }

	// RVA: 0xFFFFFFFF75C6A5E0
	public static Boolean GetKey(KeyCode key) { }

	// RVA: 0xFFFFFFFF75C6A620
	public static Boolean GetKey(String name) { }

	// RVA: 0xFFFFFFFF723D48A4
	public static Boolean GetKeyUp(KeyCode key) { }

	// RVA: 0xFFFFFFFF75C6A660
	public static Boolean GetKeyUp(String name) { }

	// RVA: 0xFFFFFFFF723D48F8
	public static Boolean GetKeyDown(KeyCode key) { }

	// RVA: 0xFFFFFFFF75C6A6A0
	public static Boolean GetKeyDown(String name) { }

	// RVA: 0xFFFFFFFF75C6A6E0
	public static Boolean get_simulateMouseWithTouches() { }

	// RVA: 0xFFFFFFFF75C6A714
	public static Void set_simulateMouseWithTouches(Boolean value) { }

	// RVA: 0xFFFFFFFF75C6A754
	public static Boolean get_anyKey() { }

	// RVA: 0xFFFFFFFF723D494C
	public static Boolean get_anyKeyDown() { }

	// RVA: 0xFFFFFFFF75C6A788
	public static String get_inputString() { }

	// RVA: 0xFFFFFFFF75C6A7BC
	public static Vector3 get_mousePosition() { }

	// RVA: 0xFFFFFFFF75C6A858
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0xFFFFFFFF75C6A8E8
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0xFFFFFFFF75C6A91C
	public static Void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0xFFFFFFFF723D4984
	public static String get_compositionString() { }

	// RVA: 0xFFFFFFFF75C6A95C
	public static Boolean get_imeIsSelected() { }

	// RVA: 0xFFFFFFFF75C6A990
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0xFFFFFFFF75C6AA20
	public static Void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C6AAAC
	public static Boolean get_mousePresent() { }

	// RVA: 0xFFFFFFFF723D49BC
	public static Int32 get_touchCount() { }

	// RVA: 0xFFFFFFFF75C6AAE0
	public static Boolean get_touchPressureSupported() { }

	// RVA: 0xFFFFFFFF75C6AB14
	public static Boolean get_stylusTouchSupported() { }

	// RVA: 0xFFFFFFFF75C6AB48
	public static Boolean get_touchSupported() { }

	// RVA: 0xFFFFFFFF75C6AB7C
	public static Boolean get_multiTouchEnabled() { }

	// RVA: 0xFFFFFFFF75C6ABB4
	public static Void set_multiTouchEnabled(Boolean value) { }

	// RVA: 0xFFFFFFFF75C6ABF4
	public static DeviceOrientation get_deviceOrientation() { }

	// RVA: 0xFFFFFFFF75C6AC28
	public static Vector3 get_acceleration() { }

	// RVA: 0xFFFFFFFF75C6ACC0
	public static Boolean get_compensateSensors() { }

	// RVA: 0xFFFFFFFF75C6ACF4
	public static Void set_compensateSensors(Boolean value) { }

	// RVA: 0xFFFFFFFF75C6AD34
	public static Int32 get_accelerationEventCount() { }

	// RVA: 0xFFFFFFFF75C6AD68
	public static Boolean get_backButtonLeavesApp() { }

	// RVA: 0xFFFFFFFF75C6AD9C
	public static Void set_backButtonLeavesApp(Boolean value) { }

	// RVA: 0xFFFFFFFF75C6ADDC
	public static LocationService get_location() { }

	// RVA: 0xFFFFFFFF75C6AE68
	public static Compass get_compass() { }

	// RVA: 0xFFFFFFFF75C6AEEC
	private static Int32 GetGyroInternal() { }

	// RVA: 0xFFFFFFFF723D49F8
	public static Gyroscope get_gyro() { }

	// RVA: 0xFFFFFFFF75C6AF20
	public static Boolean get_isMouseEventSkipRaycast() { }

	// RVA: 0xFFFFFFFF75C6AF34
	public static Void set_isMouseEventSkipRaycast(Boolean value) { }

	// RVA: 0xFFFFFFFF75C6AF48
	public static Touch[] get_touches() { }

	// RVA: 0xFFFFFFFF75C6B080
	public static AccelerationEvent[] get_accelerationEvents() { }

	// RVA: 0xFFFFFFFF75C6B148
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C6A4E4
	private static Void GetTouch_Injected(Int32 index, out Touch ret) { }

	// RVA: 0xFFFFFFFF75C6A590
	private static Void GetAccelerationEvent_Injected(Int32 index, out AccelerationEvent ret) { }

	// RVA: 0xFFFFFFFF75C6A818
	private static Void get_mousePosition_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C6A8A8
	private static Void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C6A9E0
	private static Void get_compositionCursorPos_Injected(out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C6AA6C
	private static Void set_compositionCursorPos_Injected(ref Vector2 value) { }

	// RVA: 0xFFFFFFFF75C6AC80
	private static Void get_acceleration_Injected(out Vector3 ret) { }

}

// Namespace: UnityEngine
internal class SendMouseEvents
{
	// Fields
	private static Boolean s_MouseUsed; // 0x0
	private static readonly HitInfo[] m_LastHit; // 0x8
	private static readonly HitInfo[] m_MouseDownHit; // 0x10
	private static readonly HitInfo[] m_CurrentHit; // 0x18
	private static Camera[] m_Cameras; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75C6B150
	private static Void SetMouseMoved() { }

	// RVA: 0xFFFFFFFF75C6B1C0
	private static Void DoSendMouseEvents(Int32 skipRTCameras) { }

	// RVA: 0xFFFFFFFF75C6B9A0
	private static Void SendEvents(Int32 i, HitInfo hit) { }

	// RVA: 0xFFFFFFFF75C6BE9C
	private static Void .cctor() { }

}

// Namespace: 
private struct HitInfo
{
	// Fields
	public GameObject target; // 0x10
	public Camera camera; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF7114F7BC
	public Void SendMessage(String name) { }

	// RVA: 0xFFFFFFFF75C6BDD4
	public static Boolean op_Implicit(HitInfo exists) { }

	// RVA: 0xFFFFFFFF75C6BE28
	public static Boolean Compare(HitInfo lhs, HitInfo rhs) { }

}


