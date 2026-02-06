// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.XR
public static class InputTracking
{
	// Fields
	private static Action<T0> trackingAcquired; // 0x0
	private static Action<T0> trackingLost; // 0x8
	private static Action<T0> nodeAdded; // 0x10
	private static Action<T0> nodeRemoved; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75CA9610
	private static Void InvokeTrackingEvent(TrackingStateEventType eventType, XRNode nodeType, Int64 uniqueID, Boolean tracked) { }

	// RVA: 0xFFFFFFFF75CA9818
	private static Void .cctor() { }

}

// Namespace: 
private enum TrackingStateEventType
{
	// Fields
	public Int32 value__; // 0x10
	public const TrackingStateEventType NodeAdded = 0;
	public const TrackingStateEventType NodeRemoved = 1;
	public const TrackingStateEventType TrackingAcquired = 2;
	public const TrackingStateEventType TrackingLost = 3;
}

// Namespace: UnityEngine.XR
public enum XRNode
{
	// Fields
	public Int32 value__; // 0x10
	public const XRNode LeftEye = 0;
	public const XRNode RightEye = 1;
	public const XRNode CenterEye = 2;
	public const XRNode Head = 3;
	public const XRNode LeftHand = 4;
	public const XRNode RightHand = 5;
	public const XRNode GameController = 6;
	public const XRNode TrackingReference = 7;
	public const XRNode HardwareTracker = 8;
}

// Namespace: UnityEngine.XR
internal enum AvailableTrackingData
{
	// Fields
	public Int32 value__; // 0x10
	public const AvailableTrackingData None = 0;
	public const AvailableTrackingData PositionAvailable = 1;
	public const AvailableTrackingData RotationAvailable = 2;
	public const AvailableTrackingData VelocityAvailable = 4;
	public const AvailableTrackingData AngularVelocityAvailable = 8;
	public const AvailableTrackingData AccelerationAvailable = 16;
	public const AvailableTrackingData AngularAccelerationAvailable = 32;
}

// Namespace: UnityEngine.XR
public struct XRNodeState
{
	// Fields
	private XRNode m_Type; // 0x10
	private AvailableTrackingData m_AvailableFields; // 0x14
	private Vector3 m_Position; // 0x18
	private Quaternion m_Rotation; // 0x24
	private Vector3 m_Velocity; // 0x34
	private Vector3 m_AngularVelocity; // 0x40
	private Vector3 m_Acceleration; // 0x4C
	private Vector3 m_AngularAcceleration; // 0x58
	private Int32 m_Tracked; // 0x64
	private UInt64 m_UniqueID; // 0x68

	// Properties
	public UInt64 uniqueID { set; }
	public XRNode nodeType { set; }
	public Boolean tracked { set; }

	// Methods

	// RVA: 0xFFFFFFFF71154174
	public Void set_uniqueID(UInt64 value) { }

	// RVA: 0xFFFFFFFF7115417C
	public Void set_nodeType(XRNode value) { }

	// RVA: 0xFFFFFFFF71154184
	public Void set_tracked(Boolean value) { }

}

// Namespace: UnityEngine.XR
internal enum InputFeatureType
{
	// Fields
	public UInt32 value__; // 0x10
	public const InputFeatureType Custom = 0;
	public const InputFeatureType Binary = 1;
	public const InputFeatureType DiscreteStates = 2;
	public const InputFeatureType Axis1D = 3;
	public const InputFeatureType Axis2D = 4;
	public const InputFeatureType Axis3D = 5;
	public const InputFeatureType Rotation = 6;
	public const InputFeatureType Hand = 7;
	public const InputFeatureType Bone = 8;
	public const InputFeatureType Eyes = 9;
	public const InputFeatureType kUnityXRInputFeatureTypeInvalid = 4294967295;
}

// Namespace: UnityEngine.XR
internal enum ConnectionChangeType
{
	// Fields
	public UInt32 value__; // 0x10
	public const ConnectionChangeType Connected = 0;
	public const ConnectionChangeType Disconnected = 1;
	public const ConnectionChangeType ConfigChange = 2;
}

// Namespace: UnityEngine.XR
public struct InputFeatureUsage
{
	// Fields
	internal String m_Name; // 0x10
	internal InputFeatureType m_InternalType; // 0x18

	// Properties
	public String name { get; }
	internal InputFeatureType internalType { get; }

	// Methods

	// RVA: 0xFFFFFFFF71153EE4
	public String get_name() { }

	// RVA: 0xFFFFFFFF71153EEC
	internal InputFeatureType get_internalType() { }

	// RVA: 0xFFFFFFFF71153EF4
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF71153EFC
	public Boolean Equals(InputFeatureUsage other) { }

	// RVA: 0xFFFFFFFF71153F38
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine.XR
public struct InputDevice
{
	// Fields
	private UInt64 m_DeviceId; // 0x10
	private Boolean m_Initialized; // 0x18

	// Properties
	private UInt64 deviceId { get; }

	// Methods

	// RVA: 0xFFFFFFFF71153DA8
	internal Void .ctor(UInt64 deviceId) { }

	// RVA: 0xFFFFFFFF71153DB8
	private UInt64 get_deviceId() { }

	// RVA: 0xFFFFFFFF71153DD0
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF71153DD8
	public Boolean Equals(InputDevice other) { }

	// RVA: 0xFFFFFFFF71153E00
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine.XR
public struct Hand
{
	// Fields
	private UInt64 m_DeviceId; // 0x10
	private UInt32 m_FeatureIndex; // 0x18

	// Properties
	internal UInt64 deviceId { get; }
	internal UInt32 featureIndex { get; }

	// Methods

	// RVA: 0xFFFFFFFF71153CE4
	internal UInt64 get_deviceId() { }

	// RVA: 0xFFFFFFFF71153CEC
	internal UInt32 get_featureIndex() { }

	// RVA: 0xFFFFFFFF71153CF4
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF71153CFC
	public Boolean Equals(Hand other) { }

	// RVA: 0xFFFFFFFF71153D20
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine.XR
public struct Eyes
{
	// Fields
	private UInt64 m_DeviceId; // 0x10
	private UInt32 m_FeatureIndex; // 0x18

	// Properties
	internal UInt64 deviceId { get; }
	internal UInt32 featureIndex { get; }

	// Methods

	// RVA: 0xFFFFFFFF71153C54
	internal UInt64 get_deviceId() { }

	// RVA: 0xFFFFFFFF71153C5C
	internal UInt32 get_featureIndex() { }

	// RVA: 0xFFFFFFFF71153C64
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF71153C6C
	public Boolean Equals(Eyes other) { }

	// RVA: 0xFFFFFFFF71153C90
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine.XR
public struct Bone
{
	// Fields
	private UInt64 m_DeviceId; // 0x10
	private UInt32 m_FeatureIndex; // 0x18

	// Properties
	internal UInt64 deviceId { get; }
	internal UInt32 featureIndex { get; }

	// Methods

	// RVA: 0xFFFFFFFF71153BC4
	internal UInt64 get_deviceId() { }

	// RVA: 0xFFFFFFFF71153BCC
	internal UInt32 get_featureIndex() { }

	// RVA: 0xFFFFFFFF71153BD4
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF71153BDC
	public Boolean Equals(Bone other) { }

	// RVA: 0xFFFFFFFF71153C00
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine.XR
public class InputDevices
{
	// Fields
	private static Action<T0> deviceConnected; // 0x0
	private static Action<T0> deviceDisconnected; // 0x8
	private static Action<T0> deviceConfigChanged; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75CA9410
	private static Void InvokeConnectionEvent(UInt64 deviceId, ConnectionChangeType change) { }

}

// Namespace: UnityEngine.XR
public class XRDisplaySubsystem
{
	// Fields
	private static Action<T0> displayFocusChanged; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75CA9D6C
	private static Void InvokeDisplayFocusChanged(Boolean focus) { }

	// RVA: 0xFFFFFFFF75CA9DD4
	public Void .ctor() { }

}

// Namespace: 
public struct XRRenderPass
{
	// Fields
	private IntPtr displaySubsystemInstance; // 0x10
	public Int32 renderPassIndex; // 0x18
	public RenderTargetIdentifier renderTarget; // 0x20
	public RenderTextureDescriptor renderTargetDesc; // 0x48
	public Boolean shouldFillOutDepth; // 0x98
	public Int32 cullingPassIndex; // 0x9C
}

// Namespace: 
public struct XRMirrorViewBlitDesc
{
	// Fields
	private IntPtr displaySubsystemInstance; // 0x10
	public Boolean nativeBlitAvailable; // 0x18
	public Boolean nativeBlitInvalidStates; // 0x19
	public Int32 blitParamsCount; // 0x1C
}

// Namespace: UnityEngine.XR
public class XRDisplaySubsystemDescriptor
{
	// Methods

	// RVA: 0xFFFFFFFF75CA9E1C
	public Void .ctor() { }

}

// Namespace: UnityEngine.XR
public class XRInputSubsystem
{
	// Fields
	private Action<T0> trackingOriginUpdated; // 0x20
	private Action<T0> boundaryChanged; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75CA9E64
	private static Void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

	// RVA: 0xFFFFFFFF75CA9F34
	private static Void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	// RVA: 0xFFFFFFFF75CAA004
	public Void .ctor() { }

}

// Namespace: UnityEngine.XR
public class XRInputSubsystemDescriptor
{
	// Methods

	// RVA: 0xFFFFFFFF75CAA04C
	public Void .ctor() { }

}

// Namespace: UnityEngine.XR
public struct MeshId
{
	// Fields
	private static MeshId s_InvalidId; // 0x0
	private UInt64 m_SubId1; // 0x10
	private UInt64 m_SubId2; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF71153FEC
	public override String ToString() { }

	// RVA: 0xFFFFFFFF71153FF4
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF71154030
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF71154038
	public Boolean Equals(MeshId other) { }

	// RVA: 0xFFFFFFFF75CA9D24
	private static Void .cctor() { }

}

// Namespace: UnityEngine.XR
public enum MeshGenerationStatus
{
	// Fields
	public Int32 value__; // 0x10
	public const MeshGenerationStatus Success = 0;
	public const MeshGenerationStatus InvalidMeshId = 1;
	public const MeshGenerationStatus GenerationAlreadyInProgress = 2;
	public const MeshGenerationStatus Canceled = 3;
	public const MeshGenerationStatus UnknownError = 4;
}

// Namespace: UnityEngine.XR
internal static class HashCodeHelper
{
	// Methods

	// RVA: 0xFFFFFFFF75CA92D8
	public static Int32 Combine(Int32 hash1, Int32 hash2) { }

}

// Namespace: UnityEngine.XR
public struct MeshGenerationResult
{
	// Fields
	private readonly MeshId <MeshId>k__BackingField; // 0x10
	private readonly Mesh <Mesh>k__BackingField; // 0x20
	private readonly MeshCollider <MeshCollider>k__BackingField; // 0x28
	private readonly MeshGenerationStatus <Status>k__BackingField; // 0x30
	private readonly MeshVertexAttributes <Attributes>k__BackingField; // 0x34

	// Properties
	public MeshId MeshId { get; }
	public Mesh Mesh { get; }
	public MeshCollider MeshCollider { get; }
	public MeshGenerationStatus Status { get; }
	public MeshVertexAttributes Attributes { get; }

	// Methods

	// RVA: 0xFFFFFFFF71153F7C
	public MeshId get_MeshId() { }

	// RVA: 0xFFFFFFFF71153F88
	public Mesh get_Mesh() { }

	// RVA: 0xFFFFFFFF71153F90
	public MeshCollider get_MeshCollider() { }

	// RVA: 0xFFFFFFFF71153F98
	public MeshGenerationStatus get_Status() { }

	// RVA: 0xFFFFFFFF71153FA0
	public MeshVertexAttributes get_Attributes() { }

	// RVA: 0xFFFFFFFF71153FA8
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF71153FB0
	public Boolean Equals(MeshGenerationResult other) { }

	// RVA: 0xFFFFFFFF71153FE4
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine.XR
public enum MeshVertexAttributes
{
	// Fields
	public Int32 value__; // 0x10
	public const MeshVertexAttributes None = 0;
	public const MeshVertexAttributes Normals = 1;
	public const MeshVertexAttributes Tangents = 2;
	public const MeshVertexAttributes UVs = 4;
	public const MeshVertexAttributes Colors = 8;
}

// Namespace: UnityEngine.XR
public class XRMeshSubsystem
{
	// Methods

	// RVA: 0xFFFFFFFF75CAA094
	private Void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<T0> onMeshGenerationComplete) { }

	// RVA: 0xFFFFFFFF75CAA10C
	public Void .ctor() { }

}

// Namespace: UnityEngine.XR
public class XRMeshSubsystemDescriptor
{
	// Methods

	// RVA: 0xFFFFFFFF75CAA154
	public Void .ctor() { }

}


