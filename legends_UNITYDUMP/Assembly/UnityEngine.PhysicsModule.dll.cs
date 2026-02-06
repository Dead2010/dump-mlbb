// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public enum RigidbodyConstraints
{
	// Fields
	public Int32 value__; // 0x10
	public const RigidbodyConstraints None = 0;
	public const RigidbodyConstraints FreezePositionX = 2;
	public const RigidbodyConstraints FreezePositionY = 4;
	public const RigidbodyConstraints FreezePositionZ = 8;
	public const RigidbodyConstraints FreezeRotationX = 16;
	public const RigidbodyConstraints FreezeRotationY = 32;
	public const RigidbodyConstraints FreezeRotationZ = 64;
	public const RigidbodyConstraints FreezePosition = 14;
	public const RigidbodyConstraints FreezeRotation = 112;
	public const RigidbodyConstraints FreezeAll = 126;
}

// Namespace: UnityEngine
public enum ForceMode
{
	// Fields
	public Int32 value__; // 0x10
	public const ForceMode Force = 0;
	public const ForceMode Acceleration = 5;
	public const ForceMode Impulse = 1;
	public const ForceMode VelocityChange = 2;
}

// Namespace: UnityEngine
public enum MeshColliderCookingOptions
{
	// Fields
	public Int32 value__; // 0x10
	public const MeshColliderCookingOptions None = 0;
	public const MeshColliderCookingOptions InflateConvexMesh = 1;
	public const MeshColliderCookingOptions CookForFasterSimulation = 2;
	public const MeshColliderCookingOptions EnableMeshCleaning = 4;
	public const MeshColliderCookingOptions WeldColocatedVertices = 8;
	public const MeshColliderCookingOptions UseFastMidphase = 16;
}

// Namespace: UnityEngine
public enum RigidbodyInterpolation
{
	// Fields
	public Int32 value__; // 0x10
	public const RigidbodyInterpolation None = 0;
	public const RigidbodyInterpolation Interpolate = 1;
	public const RigidbodyInterpolation Extrapolate = 2;
}

// Namespace: UnityEngine
public class ControllerColliderHit
{
	// Fields
	internal CharacterController m_Controller; // 0x10
	internal Collider m_Collider; // 0x18
	internal Vector3 m_Point; // 0x20
	internal Vector3 m_Normal; // 0x2C
	internal Vector3 m_MoveDirection; // 0x38
	internal Single m_MoveLength; // 0x44
	internal Int32 m_Push; // 0x48
}

// Namespace: UnityEngine
public class Collision
{
	// Fields
	internal Vector3 m_Impulse; // 0x10
	internal Vector3 m_RelativeVelocity; // 0x1C
	internal Rigidbody m_Rigidbody; // 0x28
	internal Collider m_Collider; // 0x30
	internal Int32 m_ContactCount; // 0x38
	internal ContactPoint[] m_ReusedContacts; // 0x40
	internal ContactPoint[] m_LegacyContacts; // 0x48

	// Properties
	public GameObject gameObject { get; }
	public ContactPoint[] contacts { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C78770
	public GameObject get_gameObject() { }

	// RVA: 0xFFFFFFFF75C787A4
	public ContactPoint[] get_contacts() { }

}

// Namespace: UnityEngine
public enum CollisionFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const CollisionFlags None = 0;
	public const CollisionFlags Sides = 1;
	public const CollisionFlags Above = 2;
	public const CollisionFlags Below = 4;
	public const CollisionFlags CollidedSides = 1;
	public const CollisionFlags CollidedAbove = 2;
	public const CollisionFlags CollidedBelow = 4;
}

// Namespace: UnityEngine
public enum QueryTriggerInteraction
{
	// Fields
	public Int32 value__; // 0x10
	public const QueryTriggerInteraction UseGlobal = 0;
	public const QueryTriggerInteraction Ignore = 1;
	public const QueryTriggerInteraction Collide = 2;
}

// Namespace: UnityEngine
public enum CollisionDetectionMode
{
	// Fields
	public Int32 value__; // 0x10
	public const CollisionDetectionMode Discrete = 0;
	public const CollisionDetectionMode Continuous = 1;
	public const CollisionDetectionMode ContinuousDynamic = 2;
	public const CollisionDetectionMode ContinuousSpeculative = 3;
}

// Namespace: UnityEngine
public class PhysicMaterial
{
	// Methods

	// RVA: 0xFFFFFFFF75C78A08
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C78AA4
	private static Void Internal_CreateDynamicsMaterial(PhysicMaterial mat, String name) { }

}

// Namespace: UnityEngine
public struct RaycastHit
{
	// Fields
	internal Vector3 m_Point; // 0x10
	internal Vector3 m_Normal; // 0x1C
	internal UInt32 m_FaceID; // 0x28
	internal Single m_Distance; // 0x2C
	internal Vector2 m_UV; // 0x30
	internal Int32 m_Collider; // 0x38

	// Properties
	public Collider collider { get; }
	public Vector3 point { get; set; }
	public Vector3 normal { get; set; }
	public Vector3 barycentricCoordinate { get; set; }
	public Single distance { get; set; }
	public Int32 triangleIndex { get; }
	public Vector2 textureCoord { get; }
	public Vector2 textureCoord2 { get; }
	public Transform transform { get; }
	public Rigidbody rigidbody { get; }
	public Vector2 lightmapCoord { get; }

	// Methods

	// RVA: 0xFFFFFFFF7115282C
	public Collider get_collider() { }

	// RVA: 0xFFFFFFFF71152834
	public Vector3 get_point() { }

	// RVA: 0xFFFFFFFF71152840
	public Void set_point(Vector3 value) { }

	// RVA: 0xFFFFFFFF7115284C
	public Vector3 get_normal() { }

	// RVA: 0xFFFFFFFF71152858
	public Void set_normal(Vector3 value) { }

	// RVA: 0xFFFFFFFF71152864
	public Vector3 get_barycentricCoordinate() { }

	// RVA: 0xFFFFFFFF711528A8
	public Void set_barycentricCoordinate(Vector3 value) { }

	// RVA: 0xFFFFFFFF711528B0
	public Single get_distance() { }

	// RVA: 0xFFFFFFFF711528B8
	public Void set_distance(Single value) { }

	// RVA: 0xFFFFFFFF711528C0
	public Int32 get_triangleIndex() { }

	// RVA: 0xFFFFFFFF75C7B0A0
	private static Vector2 CalculateRaycastTexCoord(Collider collider, Vector2 uv, Vector3 pos, UInt32 face, Int32 textcoord) { }

	// RVA: 0xFFFFFFFF711528C8
	public Vector2 get_textureCoord() { }

	// RVA: 0xFFFFFFFF711528D0
	public Vector2 get_textureCoord2() { }

	// RVA: 0xFFFFFFFF711528D8
	public Transform get_transform() { }

	// RVA: 0xFFFFFFFF711528E0
	public Rigidbody get_rigidbody() { }

	// RVA: 0xFFFFFFFF711528E8
	public Vector2 get_lightmapCoord() { }

	// RVA: 0xFFFFFFFF75C7B124
	private static Void CalculateRaycastTexCoord_Injected(Collider collider, ref Vector2 uv, ref Vector3 pos, UInt32 face, Int32 textcoord, out Vector2 ret) { }

}

// Namespace: UnityEngine
public class Rigidbody
{
	// Properties
	public Vector3 velocity { get; set; }
	public Vector3 angularVelocity { get; set; }
	public Single drag { get; set; }
	public Single angularDrag { get; set; }
	public Single mass { get; set; }
	public Boolean useGravity { get; set; }
	public Single maxDepenetrationVelocity { get; set; }
	public Boolean isKinematic { get; set; }
	public Boolean freezeRotation { get; set; }
	public RigidbodyConstraints constraints { get; set; }
	public CollisionDetectionMode collisionDetectionMode { get; set; }
	public Vector3 centerOfMass { get; set; }
	public Vector3 worldCenterOfMass { get; }
	public Quaternion inertiaTensorRotation { get; set; }
	public Vector3 inertiaTensor { get; set; }
	public Boolean detectCollisions { get; set; }
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	public RigidbodyInterpolation interpolation { get; set; }
	public Int32 solverIterations { get; set; }
	public Single sleepThreshold { get; set; }
	public Single maxAngularVelocity { get; set; }
	public Int32 solverVelocityIterations { get; set; }
	public Single sleepVelocity { get; set; }
	public Single sleepAngularVelocity { get; set; }
	public Boolean useConeFriction { get; set; }
	public Int32 solverIterationCount { get; set; }
	public Int32 solverVelocityIterationCount { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C7B388
	public Vector3 get_velocity() { }

	// RVA: 0xFFFFFFFF75C7B438
	public Void set_velocity(Vector3 value) { }

	// RVA: 0xFFFFFFFF75C7B4E0
	public Vector3 get_angularVelocity() { }

	// RVA: 0xFFFFFFFF75C7B590
	public Void set_angularVelocity(Vector3 value) { }

	// RVA: 0xFFFFFFFF75C7B638
	public Single get_drag() { }

	// RVA: 0xFFFFFFFF75C7B678
	public Void set_drag(Single value) { }

	// RVA: 0xFFFFFFFF75C7B6C8
	public Single get_angularDrag() { }

	// RVA: 0xFFFFFFFF75C7B708
	public Void set_angularDrag(Single value) { }

	// RVA: 0xFFFFFFFF75C7B758
	public Single get_mass() { }

	// RVA: 0xFFFFFFFF75C7B798
	public Void set_mass(Single value) { }

	// RVA: 0xFFFFFFFF75C7B7E8
	public Void SetDensity(Single density) { }

	// RVA: 0xFFFFFFFF75C7B838
	public Boolean get_useGravity() { }

	// RVA: 0xFFFFFFFF75C7B878
	public Void set_useGravity(Boolean value) { }

	// RVA: 0xFFFFFFFF75C7B8C8
	public Single get_maxDepenetrationVelocity() { }

	// RVA: 0xFFFFFFFF75C7B908
	public Void set_maxDepenetrationVelocity(Single value) { }

	// RVA: 0xFFFFFFFF75C7B958
	public Boolean get_isKinematic() { }

	// RVA: 0xFFFFFFFF75C7B998
	public Void set_isKinematic(Boolean value) { }

	// RVA: 0xFFFFFFFF75C7B9E8
	public Boolean get_freezeRotation() { }

	// RVA: 0xFFFFFFFF75C7BA28
	public Void set_freezeRotation(Boolean value) { }

	// RVA: 0xFFFFFFFF75C7BA78
	public RigidbodyConstraints get_constraints() { }

	// RVA: 0xFFFFFFFF75C7BAB8
	public Void set_constraints(RigidbodyConstraints value) { }

	// RVA: 0xFFFFFFFF75C7BB08
	public CollisionDetectionMode get_collisionDetectionMode() { }

	// RVA: 0xFFFFFFFF75C7BB48
	public Void set_collisionDetectionMode(CollisionDetectionMode value) { }

	// RVA: 0xFFFFFFFF75C7BB98
	public Vector3 get_centerOfMass() { }

	// RVA: 0xFFFFFFFF75C7BC48
	public Void set_centerOfMass(Vector3 value) { }

	// RVA: 0xFFFFFFFF75C7BCF0
	public Vector3 get_worldCenterOfMass() { }

	// RVA: 0xFFFFFFFF75C7BDA0
	public Quaternion get_inertiaTensorRotation() { }

	// RVA: 0xFFFFFFFF75C7BE4C
	public Void set_inertiaTensorRotation(Quaternion value) { }

	// RVA: 0xFFFFFFFF75C7BEF4
	public Vector3 get_inertiaTensor() { }

	// RVA: 0xFFFFFFFF75C7BFA4
	public Void set_inertiaTensor(Vector3 value) { }

	// RVA: 0xFFFFFFFF75C7C04C
	public Boolean get_detectCollisions() { }

	// RVA: 0xFFFFFFFF75C7C08C
	public Void set_detectCollisions(Boolean value) { }

	// RVA: 0xFFFFFFFF75C7C0DC
	public Vector3 get_position() { }

	// RVA: 0xFFFFFFFF75C7C18C
	public Void set_position(Vector3 value) { }

	// RVA: 0xFFFFFFFF75C7C234
	public Quaternion get_rotation() { }

	// RVA: 0xFFFFFFFF75C7C2E0
	public Void set_rotation(Quaternion value) { }

	// RVA: 0xFFFFFFFF75C7C388
	public RigidbodyInterpolation get_interpolation() { }

	// RVA: 0xFFFFFFFF75C7C3C8
	public Void set_interpolation(RigidbodyInterpolation value) { }

	// RVA: 0xFFFFFFFF75C7C418
	public Int32 get_solverIterations() { }

	// RVA: 0xFFFFFFFF75C7C458
	public Void set_solverIterations(Int32 value) { }

	// RVA: 0xFFFFFFFF75C7C4A8
	public Single get_sleepThreshold() { }

	// RVA: 0xFFFFFFFF75C7C4E8
	public Void set_sleepThreshold(Single value) { }

	// RVA: 0xFFFFFFFF75C7C538
	public Single get_maxAngularVelocity() { }

	// RVA: 0xFFFFFFFF75C7C578
	public Void set_maxAngularVelocity(Single value) { }

	// RVA: 0xFFFFFFFF75C7C5C8
	public Void MovePosition(Vector3 position) { }

	// RVA: 0xFFFFFFFF75C7C670
	public Void MoveRotation(Quaternion rot) { }

	// RVA: 0xFFFFFFFF75C7C718
	public Void Sleep() { }

	// RVA: 0xFFFFFFFF75C7C758
	public Boolean IsSleeping() { }

	// RVA: 0xFFFFFFFF75C7C798
	public Void WakeUp() { }

	// RVA: 0xFFFFFFFF75C7C7D8
	public Void ResetCenterOfMass() { }

	// RVA: 0xFFFFFFFF75C7C818
	public Void ResetInertiaTensor() { }

	// RVA: 0xFFFFFFFF75C7C858
	public Vector3 GetRelativePointVelocity(Vector3 relativePoint) { }

	// RVA: 0xFFFFFFFF75C7C91C
	public Vector3 GetPointVelocity(Vector3 worldPoint) { }

	// RVA: 0xFFFFFFFF75C7C9E0
	public Int32 get_solverVelocityIterations() { }

	// RVA: 0xFFFFFFFF75C7CA20
	public Void set_solverVelocityIterations(Int32 value) { }

	// RVA: 0xFFFFFFFF75C7CA70
	public Single get_sleepVelocity() { }

	// RVA: 0xFFFFFFFF75C7CAB0
	public Void set_sleepVelocity(Single value) { }

	// RVA: 0xFFFFFFFF75C7CB00
	public Single get_sleepAngularVelocity() { }

	// RVA: 0xFFFFFFFF75C7CB40
	public Void set_sleepAngularVelocity(Single value) { }

	// RVA: 0xFFFFFFFF75C7CB90
	public Void SetMaxAngularVelocity(Single a) { }

	// RVA: 0xFFFFFFFF75C7CBE0
	public Boolean get_useConeFriction() { }

	// RVA: 0xFFFFFFFF75C7CBE8
	public Void set_useConeFriction(Boolean value) { }

	// RVA: 0xFFFFFFFF75C7CBEC
	public Int32 get_solverIterationCount() { }

	// RVA: 0xFFFFFFFF75C7CC2C
	public Void set_solverIterationCount(Int32 value) { }

	// RVA: 0xFFFFFFFF75C7CC7C
	public Int32 get_solverVelocityIterationCount() { }

	// RVA: 0xFFFFFFFF75C7CCBC
	public Void set_solverVelocityIterationCount(Int32 value) { }

	// RVA: 0xFFFFFFFF75C7CD0C
	public Void AddForce(Vector3 force, ForceMode mode) { }

	// RVA: 0xFFFFFFFF75C7CDCC
	public Void AddForce(Vector3 force) { }

	// RVA: 0xFFFFFFFF75C7CE28
	public Void AddForce(Single x, Single y, Single z, ForceMode mode) { }

	// RVA: 0xFFFFFFFF75C7CEAC
	public Void AddForce(Single x, Single y, Single z) { }

	// RVA: 0xFFFFFFFF75C7CF24
	public Void AddRelativeForce(Vector3 force, ForceMode mode) { }

	// RVA: 0xFFFFFFFF75C7CFE4
	public Void AddRelativeForce(Vector3 force) { }

	// RVA: 0xFFFFFFFF75C7D040
	public Void AddRelativeForce(Single x, Single y, Single z, ForceMode mode) { }

	// RVA: 0xFFFFFFFF75C7D0C4
	public Void AddRelativeForce(Single x, Single y, Single z) { }

	// RVA: 0xFFFFFFFF75C7D13C
	public Void AddTorque(Vector3 torque, ForceMode mode) { }

	// RVA: 0xFFFFFFFF75C7D1FC
	public Void AddTorque(Vector3 torque) { }

	// RVA: 0xFFFFFFFF75C7D258
	public Void AddTorque(Single x, Single y, Single z, ForceMode mode) { }

	// RVA: 0xFFFFFFFF75C7D2DC
	public Void AddTorque(Single x, Single y, Single z) { }

	// RVA: 0xFFFFFFFF75C7D354
	public Void AddRelativeTorque(Vector3 torque, ForceMode mode) { }

	// RVA: 0xFFFFFFFF75C7D414
	public Void AddRelativeTorque(Vector3 torque) { }

	// RVA: 0xFFFFFFFF75C7D470
	public Void AddRelativeTorque(Single x, Single y, Single z, ForceMode mode) { }

	// RVA: 0xFFFFFFFF75C7D4F4
	public Void AddRelativeTorque(Single x, Single y, Single z) { }

	// RVA: 0xFFFFFFFF75C7D4FC
	public Void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }

	// RVA: 0xFFFFFFFF75C7D5D8
	public Void AddForceAtPosition(Vector3 force, Vector3 position) { }

	// RVA: 0xFFFFFFFF75C7D640
	public Void AddExplosionForce(Single explosionForce, Vector3 explosionPosition, Single explosionRadius, Single upwardsModifier, ForceMode mode) { }

	// RVA: 0xFFFFFFFF75C7D750
	public Void AddExplosionForce(Single explosionForce, Vector3 explosionPosition, Single explosionRadius, Single upwardsModifier) { }

	// RVA: 0xFFFFFFFF75C7D7D4
	public Void AddExplosionForce(Single explosionForce, Vector3 explosionPosition, Single explosionRadius) { }

	// RVA: 0xFFFFFFFF75C7D84C
	private Void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref Single distance) { }

	// RVA: 0xFFFFFFFF75C7D924
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0xFFFFFFFF75C7D9D8
	private RaycastHit SweepTest(Vector3 direction, Single maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref Boolean hasHit) { }

	// RVA: 0xFFFFFFFF75C7DB04
	public Boolean SweepTest(Vector3 direction, out RaycastHit hitInfo, Single maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C7DC44
	public Boolean SweepTest(Vector3 direction, out RaycastHit hitInfo, Single maxDistance) { }

	// RVA: 0xFFFFFFFF75C7DC4C
	public Boolean SweepTest(Vector3 direction, out RaycastHit hitInfo) { }

	// RVA: 0xFFFFFFFF75C7DC5C
	private RaycastHit[] Internal_SweepTestAll(Vector3 direction, Single maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C7DD3C
	public RaycastHit[] SweepTestAll(Vector3 direction, Single maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C7DE4C
	public RaycastHit[] SweepTestAll(Vector3 direction, Single maxDistance) { }

	// RVA: 0xFFFFFFFF75C7DE54
	public RaycastHit[] SweepTestAll(Vector3 direction) { }

	// RVA: 0xFFFFFFFF75C7DE64
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C7B3E8
	private Void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C7B490
	private Void set_velocity_Injected(ref Vector3 value) { }

	// RVA: 0xFFFFFFFF75C7B540
	private Void get_angularVelocity_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C7B5E8
	private Void set_angularVelocity_Injected(ref Vector3 value) { }

	// RVA: 0xFFFFFFFF75C7BBF8
	private Void get_centerOfMass_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C7BCA0
	private Void set_centerOfMass_Injected(ref Vector3 value) { }

	// RVA: 0xFFFFFFFF75C7BD50
	private Void get_worldCenterOfMass_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C7BDFC
	private Void get_inertiaTensorRotation_Injected(out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75C7BEA4
	private Void set_inertiaTensorRotation_Injected(ref Quaternion value) { }

	// RVA: 0xFFFFFFFF75C7BF54
	private Void get_inertiaTensor_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C7BFFC
	private Void set_inertiaTensor_Injected(ref Vector3 value) { }

	// RVA: 0xFFFFFFFF75C7C13C
	private Void get_position_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C7C1E4
	private Void set_position_Injected(ref Vector3 value) { }

	// RVA: 0xFFFFFFFF75C7C290
	private Void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75C7C338
	private Void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0xFFFFFFFF75C7C620
	private Void MovePosition_Injected(ref Vector3 position) { }

	// RVA: 0xFFFFFFFF75C7C6C8
	private Void MoveRotation_Injected(ref Quaternion rot) { }

	// RVA: 0xFFFFFFFF75C7C8C4
	private Void GetRelativePointVelocity_Injected(ref Vector3 relativePoint, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C7C988
	private Void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C7CD74
	private Void AddForce_Injected(ref Vector3 force, ForceMode mode) { }

	// RVA: 0xFFFFFFFF75C7CF8C
	private Void AddRelativeForce_Injected(ref Vector3 force, ForceMode mode) { }

	// RVA: 0xFFFFFFFF75C7D1A4
	private Void AddTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	// RVA: 0xFFFFFFFF75C7D3BC
	private Void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	// RVA: 0xFFFFFFFF75C7D570
	private Void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode) { }

	// RVA: 0xFFFFFFFF75C7D6D0
	private Void AddExplosionForce_Injected(Single explosionForce, ref Vector3 explosionPosition, Single explosionRadius, Single upwardsModifier, ForceMode mode) { }

	// RVA: 0xFFFFFFFF75C7D8BC
	private Void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref Single distance) { }

	// RVA: 0xFFFFFFFF75C7DA84
	private Void SweepTest_Injected(ref Vector3 direction, Single maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref Boolean hasHit, out RaycastHit ret) { }

	// RVA: 0xFFFFFFFF75C7DCD4
	private RaycastHit[] Internal_SweepTestAll_Injected(ref Vector3 direction, Single maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

}

// Namespace: UnityEngine
public class Collider
{
	// Properties
	public Boolean enabled { get; set; }
	public Rigidbody attachedRigidbody { get; }
	public Boolean isTrigger { get; set; }
	public Single contactOffset { get; set; }
	public Bounds bounds { get; }
	public PhysicMaterial sharedMaterial { get; set; }
	public PhysicMaterial material { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF723D588C
	public Boolean get_enabled() { }

	// RVA: 0xFFFFFFFF723D58E0
	public Void set_enabled(Boolean value) { }

	// RVA: 0xFFFFFFFF75C7800C
	public Rigidbody get_attachedRigidbody() { }

	// RVA: 0xFFFFFFFF75C7804C
	public Boolean get_isTrigger() { }

	// RVA: 0xFFFFFFFF75C7808C
	public Void set_isTrigger(Boolean value) { }

	// RVA: 0xFFFFFFFF75C780DC
	public Single get_contactOffset() { }

	// RVA: 0xFFFFFFFF75C7811C
	public Void set_contactOffset(Single value) { }

	// RVA: 0xFFFFFFFF75C7816C
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0xFFFFFFFF75C78230
	public Bounds get_bounds() { }

	// RVA: 0xFFFFFFFF75C782F4
	public PhysicMaterial get_sharedMaterial() { }

	// RVA: 0xFFFFFFFF75C78334
	public Void set_sharedMaterial(PhysicMaterial value) { }

	// RVA: 0xFFFFFFFF75C78384
	public PhysicMaterial get_material() { }

	// RVA: 0xFFFFFFFF75C783C4
	public Void set_material(PhysicMaterial value) { }

	// RVA: 0xFFFFFFFF75C78414
	private RaycastHit Raycast(Ray ray, Single maxDistance, ref Boolean hasHit) { }

	// RVA: 0xFFFFFFFF75C7852C
	public Boolean Raycast(Ray ray, out RaycastHit hitInfo, Single maxDistance) { }

	// RVA: 0xFFFFFFFF75C785E4
	private Void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref Single distance) { }

	// RVA: 0xFFFFFFFF75C786BC
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0xFFFFFFFF75C77494
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C781D8
	private Void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C782A4
	private Void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0xFFFFFFFF75C784B4
	private Void Raycast_Injected(ref Ray ray, Single maxDistance, ref Boolean hasHit, out RaycastHit ret) { }

	// RVA: 0xFFFFFFFF75C78654
	private Void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref Single distance) { }

}

// Namespace: UnityEngine
public class CharacterController
{
	// Properties
	public Vector3 velocity { get; }
	public Boolean isGrounded { get; }
	public CollisionFlags collisionFlags { get; }
	public Single radius { get; set; }
	public Single height { get; set; }
	public Vector3 center { get; set; }
	public Single slopeLimit { get; set; }
	public Single stepOffset { get; set; }
	public Single skinWidth { get; set; }
	public Single minMoveDistance { get; set; }
	public Boolean detectCollisions { get; set; }
	public Boolean enableOverlapRecovery { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C777AC
	public Boolean SimpleMove(Vector3 speed) { }

	// RVA: 0xFFFFFFFF75C77854
	public CollisionFlags Move(Vector3 motion) { }

	// RVA: 0xFFFFFFFF75C778FC
	public Vector3 get_velocity() { }

	// RVA: 0xFFFFFFFF75C779AC
	public Boolean get_isGrounded() { }

	// RVA: 0xFFFFFFFF75C779EC
	public CollisionFlags get_collisionFlags() { }

	// RVA: 0xFFFFFFFF75C77A2C
	public Single get_radius() { }

	// RVA: 0xFFFFFFFF75C77A6C
	public Void set_radius(Single value) { }

	// RVA: 0xFFFFFFFF75C77ABC
	public Single get_height() { }

	// RVA: 0xFFFFFFFF75C77AFC
	public Void set_height(Single value) { }

	// RVA: 0xFFFFFFFF75C77B4C
	public Vector3 get_center() { }

	// RVA: 0xFFFFFFFF75C77BFC
	public Void set_center(Vector3 value) { }

	// RVA: 0xFFFFFFFF75C77CA4
	public Single get_slopeLimit() { }

	// RVA: 0xFFFFFFFF75C77CE4
	public Void set_slopeLimit(Single value) { }

	// RVA: 0xFFFFFFFF75C77D34
	public Single get_stepOffset() { }

	// RVA: 0xFFFFFFFF75C77D74
	public Void set_stepOffset(Single value) { }

	// RVA: 0xFFFFFFFF75C77DC4
	public Single get_skinWidth() { }

	// RVA: 0xFFFFFFFF75C77E04
	public Void set_skinWidth(Single value) { }

	// RVA: 0xFFFFFFFF75C77E54
	public Single get_minMoveDistance() { }

	// RVA: 0xFFFFFFFF75C77E94
	public Void set_minMoveDistance(Single value) { }

	// RVA: 0xFFFFFFFF75C77EE4
	public Boolean get_detectCollisions() { }

	// RVA: 0xFFFFFFFF75C77F24
	public Void set_detectCollisions(Boolean value) { }

	// RVA: 0xFFFFFFFF75C77F74
	public Boolean get_enableOverlapRecovery() { }

	// RVA: 0xFFFFFFFF75C77FB4
	public Void set_enableOverlapRecovery(Boolean value) { }

	// RVA: 0xFFFFFFFF75C78004
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C77804
	private Boolean SimpleMove_Injected(ref Vector3 speed) { }

	// RVA: 0xFFFFFFFF75C778AC
	private CollisionFlags Move_Injected(ref Vector3 motion) { }

	// RVA: 0xFFFFFFFF75C7795C
	private Void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C77BAC
	private Void get_center_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C77C54
	private Void set_center_Injected(ref Vector3 value) { }

}

// Namespace: UnityEngine
public class MeshCollider
{
	// Properties
	public Mesh sharedMesh { get; set; }
	public Boolean convex { get; set; }
	public Boolean inflateMesh { get; set; }
	public MeshColliderCookingOptions cookingOptions { get; set; }
	public Single skinWidth { get; set; }
	public Boolean smoothSphereCollisions { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C7882C
	public Mesh get_sharedMesh() { }

	// RVA: 0xFFFFFFFF75C7886C
	public Void set_sharedMesh(Mesh value) { }

	// RVA: 0xFFFFFFFF75C788BC
	public Boolean get_convex() { }

	// RVA: 0xFFFFFFFF75C788FC
	public Void set_convex(Boolean value) { }

	// RVA: 0xFFFFFFFF75C7894C
	public Boolean get_inflateMesh() { }

	// RVA: 0xFFFFFFFF75C78954
	public Void set_inflateMesh(Boolean value) { }

	// RVA: 0xFFFFFFFF75C78958
	public MeshColliderCookingOptions get_cookingOptions() { }

	// RVA: 0xFFFFFFFF75C78998
	public Void set_cookingOptions(MeshColliderCookingOptions value) { }

	// RVA: 0xFFFFFFFF75C789E8
	public Single get_skinWidth() { }

	// RVA: 0xFFFFFFFF75C789F0
	public Void set_skinWidth(Single value) { }

	// RVA: 0xFFFFFFFF75C789F4
	public Boolean get_smoothSphereCollisions() { }

	// RVA: 0xFFFFFFFF75C789FC
	public Void set_smoothSphereCollisions(Boolean value) { }

	// RVA: 0xFFFFFFFF75C78A00
	public Void .ctor() { }

}

// Namespace: UnityEngine
public class CapsuleCollider
{
	// Properties
	public Vector3 center { get; set; }
	public Single radius { get; set; }
	public Single height { get; set; }
	public Int32 direction { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C7749C
	public Vector3 get_center() { }

	// RVA: 0xFFFFFFFF75C7754C
	public Void set_center(Vector3 value) { }

	// RVA: 0xFFFFFFFF75C775F4
	public Single get_radius() { }

	// RVA: 0xFFFFFFFF75C77634
	public Void set_radius(Single value) { }

	// RVA: 0xFFFFFFFF75C77684
	public Single get_height() { }

	// RVA: 0xFFFFFFFF75C776C4
	public Void set_height(Single value) { }

	// RVA: 0xFFFFFFFF75C77714
	public Int32 get_direction() { }

	// RVA: 0xFFFFFFFF75C77754
	public Void set_direction(Int32 value) { }

	// RVA: 0xFFFFFFFF75C777A4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C774FC
	private Void get_center_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C775A4
	private Void set_center_Injected(ref Vector3 value) { }

}

// Namespace: UnityEngine
public class BoxCollider
{
	// Properties
	public Vector3 center { get; set; }
	public Vector3 size { get; set; }
	public Vector3 extents { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C77188
	public Vector3 get_center() { }

	// RVA: 0xFFFFFFFF75C77238
	public Void set_center(Vector3 value) { }

	// RVA: 0xFFFFFFFF723D57CC
	public Vector3 get_size() { }

	// RVA: 0xFFFFFFFF723D5830
	public Void set_size(Vector3 value) { }

	// RVA: 0xFFFFFFFF75C77384
	public Vector3 get_extents() { }

	// RVA: 0xFFFFFFFF75C773E4
	public Void set_extents(Vector3 value) { }

	// RVA: 0xFFFFFFFF75C7748C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C771E8
	private Void get_center_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C77294
	private Void set_center_Injected(ref Vector3 value) { }

	// RVA: 0xFFFFFFFF75C772E4
	private Void get_size_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C77334
	private Void set_size_Injected(ref Vector3 value) { }

}

// Namespace: UnityEngine
public class SphereCollider
{
	// Properties
	public Vector3 center { get; set; }
	public Single radius { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C7DE6C
	public Vector3 get_center() { }

	// RVA: 0xFFFFFFFF75C7DF1C
	public Void set_center(Vector3 value) { }

	// RVA: 0xFFFFFFFF75C7DFC4
	public Single get_radius() { }

	// RVA: 0xFFFFFFFF75C7E004
	public Void set_radius(Single value) { }

	// RVA: 0xFFFFFFFF75C7E054
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C7DECC
	private Void get_center_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C7DF74
	private Void set_center_Injected(ref Vector3 value) { }

}

// Namespace: UnityEngine
public class ConstantForce
{}

// Namespace: UnityEngine
public class Joint
{}

// Namespace: UnityEngine
public class HingeJoint
{}

// Namespace: UnityEngine
public struct ContactPoint
{
	// Fields
	internal Vector3 m_Point; // 0x10
	internal Vector3 m_Normal; // 0x1C
	internal Int32 m_ThisColliderInstanceID; // 0x28
	internal Int32 m_OtherColliderInstanceID; // 0x2C
	internal Single m_Separation; // 0x30

	// Properties
	public Vector3 point { get; }

	// Methods

	// RVA: 0xFFFFFFFF7115279C
	public Vector3 get_point() { }

}

// Namespace: UnityEngine
public struct PhysicsScene
{
	// Fields
	private Int32 m_Handle; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF711527E4
	public override String ToString() { }

	// RVA: 0xFFFFFFFF711527EC
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF711527F4
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF711527FC
	public Boolean Equals(PhysicsScene other) { }

	// RVA: 0xFFFFFFFF7115280C
	public Boolean Raycast(Vector3 origin, Vector3 direction, Single maxDistance, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C7AA4C
	private static Boolean Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, Single maxDistance, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF71152814
	public Boolean Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, Single maxDistance, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C7AB40
	private static Boolean Internal_Raycast(PhysicsScene physicsScene, Ray ray, Single maxDistance, ref RaycastHit hit, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF7115281C
	public Int32 Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, Single maxDistance, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C7AC4C
	private static Int32 Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, Single maxDistance, Int32 mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C7AD58
	private static Boolean Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, Single radius, Vector3 direction, Single maxDistance, ref RaycastHit hitInfo, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C7AE8C
	private static Boolean Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, Single radius, Vector3 direction, out RaycastHit hitInfo, Single maxDistance, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF71152824
	public Boolean SphereCast(Vector3 origin, Single radius, Vector3 direction, out RaycastHit hitInfo, Single maxDistance, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C7AAC8
	private static Boolean Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, Single maxDistance, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C7ABCC
	private static Boolean Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, Single maxDistance, ref RaycastHit hit, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C7ACD8
	private static Int32 Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, Single maxDistance, Int32 mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C7ADF4
	private static Boolean Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, Single radius, ref Vector3 direction, Single maxDistance, ref RaycastHit hitInfo, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

}

// Namespace: UnityEngine
public class Physics
{
	// Properties
	public static Boolean queriesHitTriggers { get; }
	public static Boolean queriesHitBackfaces { get; }
	public static PhysicsScene defaultPhysicsScene { get; }
	public static Boolean autoSimulation { get; set; }
	public static Boolean autoSyncTransforms { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C78AF4
	public static Boolean get_queriesHitTriggers() { }

	// RVA: 0xFFFFFFFF75C78B28
	public static Boolean get_queriesHitBackfaces() { }

	// RVA: 0xFFFFFFFF75C78B5C
	public static PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0xFFFFFFFF75C78BEC
	public static Void IgnoreLayerCollision(Int32 layer1, Int32 layer2, Boolean ignore) { }

	// RVA: 0xFFFFFFFF75C78C44
	public static Boolean Raycast(Vector3 origin, Vector3 direction, Single maxDistance, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C78E38
	public static Boolean Raycast(Vector3 origin, Vector3 direction, Single maxDistance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C78EF8
	public static Boolean Raycast(Vector3 origin, Vector3 direction, Single maxDistance) { }

	// RVA: 0xFFFFFFFF75C78FB4
	public static Boolean Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0xFFFFFFFF75C79068
	public static Boolean Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, Single maxDistance, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF723D5A9C
	public static Boolean Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, Single maxDistance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C79144
	public static Boolean Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, Single maxDistance) { }

	// RVA: 0xFFFFFFFF75C79208
	public static Boolean Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	// RVA: 0xFFFFFFFF75C792C4
	public static Boolean Raycast(Ray ray, Single maxDistance, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C79390
	public static Boolean Raycast(Ray ray, Single maxDistance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C79458
	public static Boolean Raycast(Ray ray, Single maxDistance) { }

	// RVA: 0xFFFFFFFF75C79514
	public static Boolean Raycast(Ray ray) { }

	// RVA: 0xFFFFFFFF75C795D0
	public static Boolean Raycast(Ray ray, out RaycastHit hitInfo, Single maxDistance, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C796AC
	public static Boolean Raycast(Ray ray, out RaycastHit hitInfo, Single maxDistance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C79734
	public static Boolean Raycast(Ray ray, out RaycastHit hitInfo, Single maxDistance) { }

	// RVA: 0xFFFFFFFF75C79800
	public static Boolean Raycast(Ray ray, out RaycastHit hitInfo) { }

	// RVA: 0xFFFFFFFF75C798CC
	public static Boolean SphereCast(Vector3 origin, Single radius, Vector3 direction, out RaycastHit hitInfo, Single maxDistance, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C799A8
	public static Boolean SphereCast(Vector3 origin, Single radius, Vector3 direction, out RaycastHit hitInfo, Single maxDistance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C799B0
	public static Boolean SphereCast(Vector3 origin, Single radius, Vector3 direction, out RaycastHit hitInfo, Single maxDistance) { }

	// RVA: 0xFFFFFFFF75C799BC
	public static Boolean SphereCast(Ray ray, Single radius, out RaycastHit hitInfo, Single maxDistance, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C79A58
	public static Boolean SphereCast(Ray ray, Single radius, out RaycastHit hitInfo, Single maxDistance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C79A8C
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, Single maxDistance, Int32 mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C79B80
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, Single maxDistance, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C79D04
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, Single maxDistance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C79D0C
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, Single maxDistance) { }

	// RVA: 0xFFFFFFFF75C79D18
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0xFFFFFFFF75C79D2C
	public static RaycastHit[] RaycastAll(Ray ray, Single maxDistance, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C79DB0
	public static RaycastHit[] RaycastAll(Ray ray, Single maxDistance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C79E28
	public static RaycastHit[] RaycastAll(Ray ray, Single maxDistance) { }

	// RVA: 0xFFFFFFFF75C79E9C
	public static RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0xFFFFFFFF75C79F10
	public static Int32 RaycastNonAlloc(Ray ray, RaycastHit[] results, Single maxDistance, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C7A0E4
	public static Int32 RaycastNonAlloc(Ray ray, RaycastHit[] results, Single maxDistance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C7A1B8
	public static Int32 RaycastNonAlloc(Ray ray, RaycastHit[] results, Single maxDistance) { }

	// RVA: 0xFFFFFFFF75C7A284
	public static Int32 RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0xFFFFFFFF75C7A350
	public static Int32 RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, Single maxDistance, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C7A424
	public static Int32 RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, Single maxDistance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C7A4F4
	public static Int32 RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, Single maxDistance) { }

	// RVA: 0xFFFFFFFF75C7A5B8
	public static Int32 RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	// RVA: 0xFFFFFFFF75C7A674
	private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, Single radius, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C7A76C
	public static Collider[] OverlapSphere(Vector3 position, Single radius, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C7A830
	public static Collider[] OverlapSphere(Vector3 position, Single radius, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C7A838
	public static Boolean get_autoSimulation() { }

	// RVA: 0xFFFFFFFF75C7A86C
	public static Void set_autoSimulation(Boolean value) { }

	// RVA: 0xFFFFFFFF75C7A8AC
	public static Boolean get_autoSyncTransforms() { }

	// RVA: 0xFFFFFFFF75C7A8E0
	public static Void set_autoSyncTransforms(Boolean value) { }

	// RVA: 0xFFFFFFFF75C78BAC
	private static Void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	// RVA: 0xFFFFFFFF75C79B08
	private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, Single maxDistance, Int32 mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0xFFFFFFFF75C7A6F4
	private static Collider[] OverlapSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, Single radius, Int32 layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

}


