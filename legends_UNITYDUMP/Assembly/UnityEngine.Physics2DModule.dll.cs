// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public struct PhysicsScene2D
{
	// Fields
	private Int32 m_Handle; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF711525B0
	public override String ToString() { }

	// RVA: 0xFFFFFFFF711525B8
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF711525C0
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF711525C8
	public Boolean Equals(PhysicsScene2D other) { }

	// RVA: 0xFFFFFFFF711525D8
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, Single distance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF711525E0
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, Single distance, ContactFilter2D contactFilter) { }

	// RVA: 0xFFFFFFFF75C764F8
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, Single distance, ContactFilter2D contactFilter) { }

	// RVA: 0xFFFFFFFF71152638
	public Int32 Raycast(Vector2 origin, Vector2 direction, Single distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0xFFFFFFFF75C76618
	private static Int32 RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, Single distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0xFFFFFFFF7115266C
	public Int32 Raycast(Vector2 origin, Vector2 direction, Single distance, ContactFilter2D contactFilter, List<T0> results) { }

	// RVA: 0xFFFFFFFF75C7671C
	private static Int32 RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, Single distance, ContactFilter2D contactFilter, List<T0> results) { }

	// RVA: 0xFFFFFFFF711526A0
	public Int32 GetRayIntersection(Ray ray, Single distance, RaycastHit2D[] results, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C76820
	private static Int32 GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, Single distance, Int32 layerMask, RaycastHit2D[] results) { }

	// RVA: 0xFFFFFFFF711526D4
	public Collider2D OverlapPoint(Vector2 point, ContactFilter2D contactFilter) { }

	// RVA: 0xFFFFFFFF75C7692C
	private static Collider2D OverlapPoint_Internal(PhysicsScene2D physicsScene, Vector2 point, ContactFilter2D contactFilter) { }

	// RVA: 0xFFFFFFFF75C76598
	private static Void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, Single distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	// RVA: 0xFFFFFFFF75C7669C
	private static Int32 RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, Single distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0xFFFFFFFF75C767A0
	private static Int32 RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, Single distance, ref ContactFilter2D contactFilter, List<T0> results) { }

	// RVA: 0xFFFFFFFF75C768AC
	private static Int32 GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, Single distance, Int32 layerMask, RaycastHit2D[] results) { }

	// RVA: 0xFFFFFFFF75C76988
	private static Collider2D OverlapPoint_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref ContactFilter2D contactFilter) { }

}

// Namespace: UnityEngine
public class Physics2D
{
	// Fields
	private static List<T0> m_LastDisabledRigidbody2D; // 0x0

	// Properties
	public static PhysicsScene2D defaultPhysicsScene { get; }
	public static Vector2 gravity { get; }
	public static Boolean queriesHitTriggers { get; }
	public static Boolean autoSyncTransforms { set; }
	public static Boolean autoSimulation { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C74F70
	public static PhysicsScene2D get_defaultPhysicsScene() { }

	// RVA: 0xFFFFFFFF75C74F78
	public static Vector2 get_gravity() { }

	// RVA: 0xFFFFFFFF75C74EFC
	public static Boolean get_queriesHitTriggers() { }

	// RVA: 0xFFFFFFFF75C75044
	public static Void set_autoSyncTransforms(Boolean value) { }

	// RVA: 0xFFFFFFFF75C75084
	public static Void set_autoSimulation(Boolean value) { }

	// RVA: 0xFFFFFFFF75C750C4
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	// RVA: 0xFFFFFFFF75C75234
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, Single distance) { }

	// RVA: 0xFFFFFFFF75C75304
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, Single distance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C75460
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, Single distance, Int32 layerMask, Single minDepth) { }

	// RVA: 0xFFFFFFFF75C75564
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, Single distance, Int32 layerMask, Single minDepth, Single maxDepth) { }

	// RVA: 0xFFFFFFFF75C75670
	public static Int32 Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0xFFFFFFFF75C757C4
	public static Int32 Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, Single distance) { }

	// RVA: 0xFFFFFFFF75C75894
	public static Int32 Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<T0> results, Single distance) { }

	// RVA: 0xFFFFFFFF75C759F0
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	// RVA: 0xFFFFFFFF75C75B5C
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, Single distance) { }

	// RVA: 0xFFFFFFFF75C75C10
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, Single distance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C75AA4
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, Single distance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C75D48
	public static Int32 GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	// RVA: 0xFFFFFFFF75C75E74
	public static Int32 GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, Single distance) { }

	// RVA: 0xFFFFFFFF75C75F18
	public static Int32 GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, Single distance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C75FC0
	public static Collider2D OverlapPoint(Vector2 point, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C76100
	public static Collider2D[] OverlapPointAll(Vector2 point) { }

	// RVA: 0xFFFFFFFF75C76244
	public static Collider2D[] OverlapPointAll(Vector2 point, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C761AC
	private static Collider2D[] OverlapPointAll_Internal(PhysicsScene2D physicsScene, Vector2 point, ContactFilter2D contactFilter) { }

	// RVA: 0xFFFFFFFF75C7634C
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C75004
	private static Void get_gravity_Injected(out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C75CD0
	private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, Single distance, Int32 layerMask) { }

	// RVA: 0xFFFFFFFF75C762F4
	private static Collider2D[] OverlapPointAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref ContactFilter2D contactFilter) { }

}

// Namespace: UnityEngine
public enum RigidbodyType2D
{
	// Fields
	public Int32 value__; // 0x10
	public const RigidbodyType2D Dynamic = 0;
	public const RigidbodyType2D Kinematic = 1;
	public const RigidbodyType2D Static = 2;
}

// Namespace: UnityEngine
public struct ContactFilter2D
{
	// Fields
	public Boolean useTriggers; // 0x10
	public Boolean useLayerMask; // 0x11
	public Boolean useDepth; // 0x12
	public Boolean useOutsideDepth; // 0x13
	public Boolean useNormalAngle; // 0x14
	public Boolean useOutsideNormalAngle; // 0x15
	public LayerMask layerMask; // 0x18
	public Single minDepth; // 0x1C
	public Single maxDepth; // 0x20
	public Single minNormalAngle; // 0x24
	public Single maxNormalAngle; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF71152514
	private Void CheckConsistency() { }

	// RVA: 0xFFFFFFFF71152554
	public Void SetLayerMask(LayerMask layerMask) { }

	// RVA: 0xFFFFFFFF71152564
	public Void SetDepth(Single minDepth, Single maxDepth) { }

	// RVA: 0xFFFFFFFF75C74DFC
	internal static ContactFilter2D CreateLegacyFilter(Int32 layerMask, Single minDepth, Single maxDepth) { }

	// RVA: 0xFFFFFFFF75C74D60
	private static Void CheckConsistency_Injected(ref ContactFilter2D _unity_self) { }

}

// Namespace: UnityEngine
public class Collision2D
{
	// Fields
	internal Int32 m_Collider; // 0x10
	internal Int32 m_OtherCollider; // 0x14
	internal Int32 m_Rigidbody; // 0x18
	internal Int32 m_OtherRigidbody; // 0x1C
	internal Vector2 m_RelativeVelocity; // 0x20
	internal Int32 m_Enabled; // 0x28
	internal Int32 m_ContactCount; // 0x2C
	internal ContactPoint2D[] m_ReusedContacts; // 0x30
	internal ContactPoint2D[] m_LegacyContacts; // 0x38
}

// Namespace: UnityEngine
public struct ContactPoint2D
{
	// Fields
	private Vector2 m_Point; // 0x10
	private Vector2 m_Normal; // 0x18
	private Vector2 m_RelativeVelocity; // 0x20
	private Single m_Separation; // 0x28
	private Single m_NormalImpulse; // 0x2C
	private Single m_TangentImpulse; // 0x30
	private Int32 m_Collider; // 0x34
	private Int32 m_OtherCollider; // 0x38
	private Int32 m_Rigidbody; // 0x3C
	private Int32 m_OtherRigidbody; // 0x40
	private Int32 m_Enabled; // 0x44
}

// Namespace: UnityEngine
public struct RaycastHit2D
{
	// Fields
	private Vector2 m_Centroid; // 0x10
	private Vector2 m_Point; // 0x18
	private Vector2 m_Normal; // 0x20
	private Single m_Distance; // 0x28
	private Single m_Fraction; // 0x2C
	private Int32 m_Collider; // 0x30

	// Properties
	public Vector2 point { get; }
	public Vector2 normal { get; }
	public Single distance { get; }
	public Collider2D collider { get; }

	// Methods

	// RVA: 0xFFFFFFFF71152740
	public Vector2 get_point() { }

	// RVA: 0xFFFFFFFF71152748
	public Vector2 get_normal() { }

	// RVA: 0xFFFFFFFF71152750
	public Single get_distance() { }

	// RVA: 0xFFFFFFFF71152758
	public Collider2D get_collider() { }

}

// Namespace: UnityEngine
public sealed class Rigidbody2D
{
	// Properties
	public Vector2 position { get; set; }
	public Single rotation { get; set; }
	public Vector2 velocity { get; set; }
	public Single gravityScale { get; set; }
	public RigidbodyType2D bodyType { set; }
	public Boolean isKinematic { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C76BDC
	public Vector2 get_position() { }

	// RVA: 0xFFFFFFFF75C76C84
	public Void set_position(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C76D28
	public Single get_rotation() { }

	// RVA: 0xFFFFFFFF75C76D68
	public Void set_rotation(Single value) { }

	// RVA: 0xFFFFFFFF75C76DB8
	public Void MovePosition(Vector2 position) { }

	// RVA: 0xFFFFFFFF75C76E5C
	public Void MoveRotation(Single angle) { }

	// RVA: 0xFFFFFFFF75C76EAC
	private Void MoveRotation_Angle(Single angle) { }

	// RVA: 0xFFFFFFFF75C76EFC
	public Vector2 get_velocity() { }

	// RVA: 0xFFFFFFFF75C76FA4
	public Void set_velocity(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C77048
	public Single get_gravityScale() { }

	// RVA: 0xFFFFFFFF75C77088
	public Void set_gravityScale(Single value) { }

	// RVA: 0xFFFFFFFF75C770D8
	public Void set_bodyType(RigidbodyType2D value) { }

	// RVA: 0xFFFFFFFF75C77128
	public Void set_isKinematic(Boolean value) { }

	// RVA: 0xFFFFFFFF75C77180
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C76C34
	private Void get_position_Injected(out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C76CD8
	private Void set_position_Injected(ref Vector2 value) { }

	// RVA: 0xFFFFFFFF75C76E0C
	private Void MovePosition_Injected(ref Vector2 position) { }

	// RVA: 0xFFFFFFFF75C76F54
	private Void get_velocity_Injected(out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C76FF8
	private Void set_velocity_Injected(ref Vector2 value) { }

}

// Namespace: UnityEngine
public class Collider2D
{
	// Properties
	public Boolean isTrigger { set; }
	public Boolean usedByEffector { set; }
	public Boolean usedByComposite { set; }
	public Vector2 offset { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C74B84
	public Void set_isTrigger(Boolean value) { }

	// RVA: 0xFFFFFFFF75C74BD4
	public Void set_usedByEffector(Boolean value) { }

	// RVA: 0xFFFFFFFF75C74C24
	public Void set_usedByComposite(Boolean value) { }

	// RVA: 0xFFFFFFFF75C74C74
	public Void set_offset(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C74D18
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C74CC8
	private Void set_offset_Injected(ref Vector2 value) { }

}

// Namespace: UnityEngine
public sealed class BoxCollider2D
{
	// Properties
	public Vector2 size { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C74AE0
	public Void set_size(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C74B34
	private Void set_size_Injected(ref Vector2 value) { }

}

// Namespace: UnityEngine
public sealed class PolygonCollider2D
{
	// Methods

	// RVA: 0xFFFFFFFF75C769E0
	public Void SetPath(Int32 index, Vector2[] points) { }

	// RVA: 0xFFFFFFFF75C76AC8
	private Void SetPath_Internal(Int32 index, Vector2[] points) { }

}

// Namespace: UnityEngine
public class Joint2D
{
	// Properties
	public Rigidbody2D connectedBody { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C74F30
	public Rigidbody2D get_connectedBody() { }

}

// Namespace: UnityEngine
public class AnchoredJoint2D
{
	// Properties
	public Vector2 connectedAnchor { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C74A38
	public Vector2 get_connectedAnchor() { }

	// RVA: 0xFFFFFFFF75C74A90
	private Void get_connectedAnchor_Injected(out Vector2 ret) { }

}

// Namespace: UnityEngine
public sealed class HingeJoint2D
{}


