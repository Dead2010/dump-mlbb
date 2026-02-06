// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public sealed class SharedBetweenAnimatorsAttribute
{}

// Namespace: UnityEngine
public abstract class StateMachineBehaviour
{
	// Methods

	// RVA: 0xFFFFFFFF75BE88B8
	public virtual Void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF75BE88BC
	public virtual Void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF75BE88C0
	public virtual Void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF75BE88C4
	public virtual Void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF75BE88C8
	public virtual Void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF75BE88CC
	public virtual Void OnStateMachineEnter(Animator animator, Int32 stateMachinePathHash) { }

	// RVA: 0xFFFFFFFF75BE88D0
	public virtual Void OnStateMachineExit(Animator animator, Int32 stateMachinePathHash) { }

	// RVA: 0xFFFFFFFF75BE88D4
	public virtual Void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, Int32 layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0xFFFFFFFF75BE88D8
	public virtual Void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, Int32 layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0xFFFFFFFF75BE88DC
	public virtual Void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, Int32 layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0xFFFFFFFF75BE88E0
	public virtual Void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, Int32 layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0xFFFFFFFF75BE88E4
	public virtual Void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, Int32 layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0xFFFFFFFF75BE88E8
	public virtual Void OnStateMachineEnter(Animator animator, Int32 stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0xFFFFFFFF75BE88EC
	public virtual Void OnStateMachineExit(Animator animator, Int32 stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0xFFFFFFFF75BE88F0
	protected Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AnimationClip
{
	// Properties
	public Single length { get; }
	public Single frameRate { get; set; }
	public WrapMode wrapMode { get; set; }
	public Bounds localBounds { get; set; }
	public Boolean legacy { get; set; }
	public Boolean humanMotion { get; }
	public Boolean empty { get; }
	public Boolean hasGenericRootTransform { get; }
	public Boolean hasMotionFloatCurves { get; }
	public Boolean hasMotionCurves { get; }
	public Boolean hasRootCurves { get; }
	internal Boolean hasRootMotion { get; }
	public AnimationEvent[] events { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75BDE4E0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BDE564
	private static Void Internal_CreateAnimationClip(AnimationClip self) { }

	// RVA: 0xFFFFFFFF723B3910
	public Void SampleAnimation(GameObject go, Single time) { }

	// RVA: 0xFFFFFFFF75BDE5E4
	internal static Void SampleAnimation(GameObject go, AnimationClip clip, Single inTime, WrapMode wrapMode) { }

	// RVA: 0xFFFFFFFF723B39A8
	public Single get_length() { }

	// RVA: 0xFFFFFFFF75BDE64C
	public Single get_frameRate() { }

	// RVA: 0xFFFFFFFF75BDE68C
	public Void set_frameRate(Single value) { }

	// RVA: 0xFFFFFFFF75BDE6DC
	public Void SetCurve(String relativePath, Type type, String propertyName, AnimationCurve curve) { }

	// RVA: 0xFFFFFFFF75BDE74C
	public Void EnsureQuaternionContinuity() { }

	// RVA: 0xFFFFFFFF75BDE78C
	public Void ClearCurves() { }

	// RVA: 0xFFFFFFFF75BDE5A4
	public WrapMode get_wrapMode() { }

	// RVA: 0xFFFFFFFF75BDE7CC
	public Void set_wrapMode(WrapMode value) { }

	// RVA: 0xFFFFFFFF75BDE81C
	public Bounds get_localBounds() { }

	// RVA: 0xFFFFFFFF75BDE8E0
	public Void set_localBounds(Bounds value) { }

	// RVA: 0xFFFFFFFF75BDE980
	public Boolean get_legacy() { }

	// RVA: 0xFFFFFFFF75BDE9C0
	public Void set_legacy(Boolean value) { }

	// RVA: 0xFFFFFFFF75BDEA10
	public Boolean get_humanMotion() { }

	// RVA: 0xFFFFFFFF75BDEA50
	public Boolean get_empty() { }

	// RVA: 0xFFFFFFFF75BDEA90
	public Boolean get_hasGenericRootTransform() { }

	// RVA: 0xFFFFFFFF75BDEAD0
	public Boolean get_hasMotionFloatCurves() { }

	// RVA: 0xFFFFFFFF75BDEB10
	public Boolean get_hasMotionCurves() { }

	// RVA: 0xFFFFFFFF75BDEB50
	public Boolean get_hasRootCurves() { }

	// RVA: 0xFFFFFFFF75BDEB90
	internal Boolean get_hasRootMotion() { }

	// RVA: 0xFFFFFFFF723B39FC
	public Void AddEvent(AnimationEvent evt) { }

	// RVA: 0xFFFFFFFF75BDEBD0
	internal Void AddEventInternal(Object evt) { }

	// RVA: 0xFFFFFFFF723B3A80
	public AnimationEvent[] get_events() { }

	// RVA: 0xFFFFFFFF75BDEC60
	public Void set_events(AnimationEvent[] value) { }

	// RVA: 0xFFFFFFFF75BDECB4
	internal Void SetEventsInternal(Array value) { }

	// RVA: 0xFFFFFFFF75BDEC20
	internal Array GetEventsInternal() { }

	// RVA: 0xFFFFFFFF75BDE890
	private Void get_localBounds_Injected(out Bounds ret) { }

	// RVA: 0xFFFFFFFF75BDE930
	private Void set_localBounds_Injected(ref Bounds value) { }

}

// Namespace: UnityEngine
public enum AvatarTarget
{
	// Fields
	public Int32 value__; // 0x10
	public const AvatarTarget Root = 0;
	public const AvatarTarget Body = 1;
	public const AvatarTarget LeftFoot = 2;
	public const AvatarTarget RightFoot = 3;
	public const AvatarTarget LeftHand = 4;
	public const AvatarTarget RightHand = 5;
}

// Namespace: UnityEngine
public enum AvatarIKGoal
{
	// Fields
	public Int32 value__; // 0x10
	public const AvatarIKGoal LeftFoot = 0;
	public const AvatarIKGoal RightFoot = 1;
	public const AvatarIKGoal LeftHand = 2;
	public const AvatarIKGoal RightHand = 3;
}

// Namespace: UnityEngine
public enum AvatarIKHint
{
	// Fields
	public Int32 value__; // 0x10
	public const AvatarIKHint LeftKnee = 0;
	public const AvatarIKHint RightKnee = 1;
	public const AvatarIKHint LeftElbow = 2;
	public const AvatarIKHint RightElbow = 3;
}

// Namespace: UnityEngine
public enum AnimatorControllerParameterType
{
	// Fields
	public Int32 value__; // 0x10
	public const AnimatorControllerParameterType Float = 1;
	public const AnimatorControllerParameterType Int = 3;
	public const AnimatorControllerParameterType Bool = 4;
	public const AnimatorControllerParameterType Trigger = 9;
}

// Namespace: UnityEngine
internal enum StateInfoIndex
{
	// Fields
	public Int32 value__; // 0x10
	public const StateInfoIndex CurrentState = 0;
	public const StateInfoIndex NextState = 1;
	public const StateInfoIndex ExitState = 2;
	public const StateInfoIndex InterruptedState = 3;
}

// Namespace: UnityEngine
public enum AnimatorRecorderMode
{
	// Fields
	public Int32 value__; // 0x10
	public const AnimatorRecorderMode Offline = 0;
	public const AnimatorRecorderMode Playback = 1;
	public const AnimatorRecorderMode Record = 2;
}

// Namespace: UnityEngine
public enum AnimatorCullingMode
{
	// Fields
	public Int32 value__; // 0x10
	public const AnimatorCullingMode AlwaysAnimate = 0;
	public const AnimatorCullingMode CullUpdateTransforms = 1;
	public const AnimatorCullingMode CullCompletely = 2;
}

// Namespace: UnityEngine
public enum AnimatorUpdateMode
{
	// Fields
	public Int32 value__; // 0x10
	public const AnimatorUpdateMode Normal = 0;
	public const AnimatorUpdateMode AnimatePhysics = 1;
	public const AnimatorUpdateMode UnscaledTime = 2;
}

// Namespace: UnityEngine
public struct AnimatorClipInfo
{
	// Fields
	private Int32 m_ClipInstanceID; // 0x10
	private Single m_Weight; // 0x14

	// Properties
	public AnimationClip clip { get; }
	public Single weight { get; }

	// Methods

	// RVA: 0xFFFFFFFF71149D18
	public AnimationClip get_clip() { }

	// RVA: 0xFFFFFFFF71149D6C
	public Single get_weight() { }

	// RVA: 0xFFFFFFFF75BE6D70
	private static AnimationClip InstanceIDToAnimationClipPPtr(Int32 instanceID) { }

}

// Namespace: UnityEngine
public struct AnimatorStateInfo
{
	// Fields
	private Int32 m_Name; // 0x10
	private Int32 m_Path; // 0x14
	private Int32 m_FullPath; // 0x18
	private Single m_NormalizedTime; // 0x1C
	private Single m_Length; // 0x20
	private Single m_Speed; // 0x24
	private Single m_SpeedMultiplier; // 0x28
	private Int32 m_Tag; // 0x2C
	private Int32 m_Loop; // 0x30

	// Properties
	public Int32 fullPathHash { get; }
	public Int32 shortNameHash { get; }
	public Single normalizedTime { get; }
	public Single length { get; }
	public Single speed { get; }
	public Single speedMultiplier { get; }
	public Int32 tagHash { get; }
	public Boolean loop { get; }

	// Methods

	// RVA: 0xFFFFFFFF71149E60
	public Boolean IsName(String name) { }

	// RVA: 0xFFFFFFFF71149EDC
	public Int32 get_fullPathHash() { }

	// RVA: 0xFFFFFFFF71149EE4
	public Int32 get_shortNameHash() { }

	// RVA: 0xFFFFFFFF71149EEC
	public Single get_normalizedTime() { }

	// RVA: 0xFFFFFFFF71149EF4
	public Single get_length() { }

	// RVA: 0xFFFFFFFF71149EFC
	public Single get_speed() { }

	// RVA: 0xFFFFFFFF71149F04
	public Single get_speedMultiplier() { }

	// RVA: 0xFFFFFFFF71149F0C
	public Int32 get_tagHash() { }

	// RVA: 0xFFFFFFFF71149F14
	public Boolean IsTag(String tag) { }

	// RVA: 0xFFFFFFFF71149F70
	public Boolean get_loop() { }

}

// Namespace: UnityEngine
public struct AnimatorTransitionInfo
{
	// Fields
	private Int32 m_FullPath; // 0x10
	private Int32 m_UserName; // 0x14
	private Int32 m_Name; // 0x18
	private Boolean m_HasFixedDuration; // 0x1C
	private Single m_Duration; // 0x20
	private Single m_NormalizedTime; // 0x24
	private Boolean m_AnyState; // 0x28
	private Int32 m_TransitionType; // 0x2C

	// Methods

	// RVA: 0xFFFFFFFF71149FEC
	public Boolean IsName(String name) { }

}

// Namespace: UnityEngine
public struct MatchTargetWeightMask
{
	// Fields
	private Vector3 m_PositionXYZWeight; // 0x10
	private Single m_RotationWeight; // 0x1C
}

// Namespace: UnityEngine
public class Animator
{
	// Properties
	public Boolean isOptimizable { get; }
	public Boolean isHuman { get; }
	public Boolean hasRootMotion { get; }
	internal Boolean isRootPositionOrRotationControlledByCurves { get; }
	public Single humanScale { get; }
	public Boolean isInitialized { get; }
	public Vector3 deltaPosition { get; }
	public Quaternion deltaRotation { get; }
	public Vector3 velocity { get; }
	public Vector3 angularVelocity { get; }
	public Vector3 rootPosition { get; set; }
	public Quaternion rootRotation { get; set; }
	public Boolean applyRootMotion { get; set; }
	public Boolean linearVelocityBlending { get; set; }
	public Boolean animatePhysics { get; set; }
	public AnimatorUpdateMode updateMode { get; set; }
	public Boolean hasTransformHierarchy { get; }
	internal Boolean allowConstantClipSamplingOptimization { get; set; }
	public Single gravityWeight { get; }
	public Vector3 bodyPosition { get; set; }
	internal Vector3 bodyPositionInternal { get; set; }
	public Quaternion bodyRotation { get; set; }
	internal Quaternion bodyRotationInternal { get; set; }
	public Boolean stabilizeFeet { get; set; }
	public Int32 layerCount { get; }
	public AnimatorControllerParameter[] parameters { get; }
	public Int32 parameterCount { get; }
	public Single feetPivotActive { get; set; }
	public Single pivotWeight { get; }
	public Vector3 pivotPosition { get; }
	public Boolean isMatchingTarget { get; }
	public Single speed { get; set; }
	public Vector3 targetPosition { get; }
	public Quaternion targetRotation { get; }
	internal Transform avatarRoot { get; }
	public AnimatorCullingMode cullingMode { get; set; }
	public Single playbackTime { get; set; }
	public Single recorderStartTime { get; set; }
	public Single recorderStopTime { get; set; }
	public AnimatorRecorderMode recorderMode { get; }
	public RuntimeAnimatorController runtimeAnimatorController { get; set; }
	public Boolean hasBoundPlayables { get; }
	public Avatar avatar { get; set; }
	public PlayableGraph playableGraph { get; }
	public Boolean layersAffectMassCenter { get; set; }
	public Single leftFeetBottomHeight { get; }
	public Single rightFeetBottomHeight { get; }
	internal Boolean supportsOnAnimatorMove { get; }
	public Boolean logWarnings { get; set; }
	public Boolean fireEvents { get; set; }
	public Boolean keepAnimatorControllerStateOnDisable { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75BE18A0
	public Boolean get_isOptimizable() { }

	// RVA: 0xFFFFFFFF75BE18E0
	public Boolean get_isHuman() { }

	// RVA: 0xFFFFFFFF75BE1920
	public Boolean get_hasRootMotion() { }

	// RVA: 0xFFFFFFFF75BE1960
	internal Boolean get_isRootPositionOrRotationControlledByCurves() { }

	// RVA: 0xFFFFFFFF75BE19A0
	public Single get_humanScale() { }

	// RVA: 0xFFFFFFFF723B3F98
	public Boolean get_isInitialized() { }

	// RVA: 0xFFFFFFFF723B4010
	public Single GetFloat(String name) { }

	// RVA: 0xFFFFFFFF75BE1A30
	public Single GetFloat(Int32 id) { }

	// RVA: 0xFFFFFFFF723B4064
	public Void SetFloat(String name, Single value) { }

	// RVA: 0xFFFFFFFF75BE1B30
	public Void SetFloat(String name, Single value, Single dampTime, Single deltaTime) { }

	// RVA: 0xFFFFFFFF75BE1C20
	public Void SetFloat(Int32 id, Single value) { }

	// RVA: 0xFFFFFFFF75BE1CE0
	public Void SetFloat(Int32 id, Single value, Single dampTime, Single deltaTime) { }

	// RVA: 0xFFFFFFFF723B40C8
	public Boolean GetBool(String name) { }

	// RVA: 0xFFFFFFFF75BE1E20
	public Boolean GetBool(Int32 id) { }

	// RVA: 0xFFFFFFFF75BE1EC0
	public Void SetBool(String name, Boolean value) { }

	// RVA: 0xFFFFFFFF75BE1F70
	public Void SetBool(Int32 id, Boolean value) { }

	// RVA: 0xFFFFFFFF75BE2020
	public Int32 GetInteger(String name) { }

	// RVA: 0xFFFFFFFF75BE20C4
	public Int32 GetInteger(Int32 id) { }

	// RVA: 0xFFFFFFFF723B411C
	public Void SetInteger(String name, Int32 value) { }

	// RVA: 0xFFFFFFFF75BE21BC
	public Void SetInteger(Int32 id, Int32 value) { }

	// RVA: 0xFFFFFFFF75BE226C
	public Void SetTrigger(String name) { }

	// RVA: 0xFFFFFFFF75BE2310
	public Void SetTrigger(Int32 id) { }

	// RVA: 0xFFFFFFFF723B4180
	public Void ResetTrigger(String name) { }

	// RVA: 0xFFFFFFFF75BE2400
	public Void ResetTrigger(Int32 id) { }

	// RVA: 0xFFFFFFFF75BE24A0
	public Boolean IsParameterControlledByCurve(String name) { }

	// RVA: 0xFFFFFFFF75BE2540
	public Boolean IsParameterControlledByCurve(Int32 id) { }

	// RVA: 0xFFFFFFFF75BE25E0
	public Vector3 get_deltaPosition() { }

	// RVA: 0xFFFFFFFF75BE2690
	public Quaternion get_deltaRotation() { }

	// RVA: 0xFFFFFFFF75BE273C
	public Vector3 get_velocity() { }

	// RVA: 0xFFFFFFFF75BE27EC
	public Vector3 get_angularVelocity() { }

	// RVA: 0xFFFFFFFF75BE289C
	public Vector3 get_rootPosition() { }

	// RVA: 0xFFFFFFFF75BE294C
	public Void set_rootPosition(Vector3 value) { }

	// RVA: 0xFFFFFFFF75BE29F4
	public Quaternion get_rootRotation() { }

	// RVA: 0xFFFFFFFF75BE2AA0
	public Void set_rootRotation(Quaternion value) { }

	// RVA: 0xFFFFFFFF723B41D4
	public Boolean get_applyRootMotion() { }

	// RVA: 0xFFFFFFFF723B4218
	public Void set_applyRootMotion(Boolean value) { }

	// RVA: 0xFFFFFFFF75BE2B48
	public Boolean get_linearVelocityBlending() { }

	// RVA: 0xFFFFFFFF75BE2B88
	public Void set_linearVelocityBlending(Boolean value) { }

	// RVA: 0xFFFFFFFF75BE2BD8
	public Boolean get_animatePhysics() { }

	// RVA: 0xFFFFFFFF75BE2C64
	public Void set_animatePhysics(Boolean value) { }

	// RVA: 0xFFFFFFFF75BE2C24
	public AnimatorUpdateMode get_updateMode() { }

	// RVA: 0xFFFFFFFF75BE2CBC
	public Void set_updateMode(AnimatorUpdateMode value) { }

	// RVA: 0xFFFFFFFF75BE2D0C
	public Boolean get_hasTransformHierarchy() { }

	// RVA: 0xFFFFFFFF75BE2D4C
	internal Boolean get_allowConstantClipSamplingOptimization() { }

	// RVA: 0xFFFFFFFF75BE2D8C
	internal Void set_allowConstantClipSamplingOptimization(Boolean value) { }

	// RVA: 0xFFFFFFFF75BE2DDC
	public Single get_gravityWeight() { }

	// RVA: 0xFFFFFFFF75BE2E1C
	public Vector3 get_bodyPosition() { }

	// RVA: 0xFFFFFFFF75BE2F68
	public Void set_bodyPosition(Vector3 value) { }

	// RVA: 0xFFFFFFFF75BE2F08
	internal Vector3 get_bodyPositionInternal() { }

	// RVA: 0xFFFFFFFF75BE2FE0
	internal Void set_bodyPositionInternal(Vector3 value) { }

	// RVA: 0xFFFFFFFF75BE30D8
	public Quaternion get_bodyRotation() { }

	// RVA: 0xFFFFFFFF75BE3158
	public Void set_bodyRotation(Quaternion value) { }

	// RVA: 0xFFFFFFFF75BE30FC
	internal Quaternion get_bodyRotationInternal() { }

	// RVA: 0xFFFFFFFF75BE31D4
	internal Void set_bodyRotationInternal(Quaternion value) { }

	// RVA: 0xFFFFFFFF75BE32CC
	public Vector3 GetIKPosition(AvatarIKGoal goal) { }

	// RVA: 0xFFFFFFFF75BE32F8
	private Vector3 GetGoalPosition(AvatarIKGoal goal) { }

	// RVA: 0xFFFFFFFF75BE33C0
	public Void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0xFFFFFFFF75BE3448
	private Void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0xFFFFFFFF75BE3508
	public Quaternion GetIKRotation(AvatarIKGoal goal) { }

	// RVA: 0xFFFFFFFF75BE3534
	private Quaternion GetGoalRotation(AvatarIKGoal goal) { }

	// RVA: 0xFFFFFFFF75BE35F8
	public Void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0xFFFFFFFF75BE3684
	private Void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0xFFFFFFFF75BE3744
	public Single GetIKPositionWeight(AvatarIKGoal goal) { }

	// RVA: 0xFFFFFFFF75BE3798
	private Single GetGoalWeightPosition(AvatarIKGoal goal) { }

	// RVA: 0xFFFFFFFF75BE37E8
	public Void SetIKPositionWeight(AvatarIKGoal goal, Single value) { }

	// RVA: 0xFFFFFFFF75BE384C
	private Void SetGoalWeightPosition(AvatarIKGoal goal, Single value) { }

	// RVA: 0xFFFFFFFF75BE38AC
	public Single GetIKRotationWeight(AvatarIKGoal goal) { }

	// RVA: 0xFFFFFFFF75BE3900
	private Single GetGoalWeightRotation(AvatarIKGoal goal) { }

	// RVA: 0xFFFFFFFF75BE3950
	public Void SetIKRotationWeight(AvatarIKGoal goal, Single value) { }

	// RVA: 0xFFFFFFFF75BE39B4
	private Void SetGoalWeightRotation(AvatarIKGoal goal, Single value) { }

	// RVA: 0xFFFFFFFF75BE3A14
	public Vector3 GetIKHintPosition(AvatarIKHint hint) { }

	// RVA: 0xFFFFFFFF75BE3A40
	private Vector3 GetHintPosition(AvatarIKHint hint) { }

	// RVA: 0xFFFFFFFF75BE3B08
	public Void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0xFFFFFFFF75BE3B90
	private Void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0xFFFFFFFF75BE3C50
	public Single GetIKHintPositionWeight(AvatarIKHint hint) { }

	// RVA: 0xFFFFFFFF75BE3CA4
	private Single GetHintWeightPosition(AvatarIKHint hint) { }

	// RVA: 0xFFFFFFFF75BE3CF4
	public Void SetIKHintPositionWeight(AvatarIKHint hint, Single value) { }

	// RVA: 0xFFFFFFFF75BE3D58
	private Void SetHintWeightPosition(AvatarIKHint hint, Single value) { }

	// RVA: 0xFFFFFFFF75BE3DB8
	public Void SetLookAtPosition(Vector3 lookAtPosition) { }

	// RVA: 0xFFFFFFFF75BE3E30
	private Void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	// RVA: 0xFFFFFFFF75BE3ED8
	public Void SetLookAtWeight(Single weight) { }

	// RVA: 0xFFFFFFFF75BE3FBC
	public Void SetLookAtWeight(Single weight, Single bodyWeight) { }

	// RVA: 0xFFFFFFFF75BE4024
	public Void SetLookAtWeight(Single weight, Single bodyWeight, Single headWeight) { }

	// RVA: 0xFFFFFFFF75BE4098
	public Void SetLookAtWeight(Single weight, Single bodyWeight, Single headWeight, Single eyesWeight) { }

	// RVA: 0xFFFFFFFF75BE4110
	public Void SetLookAtWeight(Single weight, Single bodyWeight, Single headWeight, Single eyesWeight, Single clampWeight) { }

	// RVA: 0xFFFFFFFF75BE3F3C
	private Void SetLookAtWeightInternal(Single weight, Single bodyWeight, Single headWeight, Single eyesWeight, Single clampWeight) { }

	// RVA: 0xFFFFFFFF75BE4194
	public Void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation) { }

	// RVA: 0xFFFFFFFF75BE428C
	private Void SetBoneLocalRotationInternal(Int32 humanBoneId, Quaternion rotation) { }

	// RVA: 0xFFFFFFFF75BE434C
	private ScriptableObject GetBehaviour(Type type) { }

	// RVA: -1
	public T GetBehaviour() { }

	// RVA: -1
	private static T[] ConvertStateMachineBehaviour(ScriptableObject[] rawObjects) { }

	// RVA: -1
	public T[] GetBehaviours() { }

	// RVA: 0xFFFFFFFF75BE439C
	internal ScriptableObject[] InternalGetBehaviours(Type type) { }

	// RVA: 0xFFFFFFFF75BE43EC
	public StateMachineBehaviour[] GetBehaviours(Int32 fullPathHash, Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF75BE44BC
	internal ScriptableObject[] InternalGetBehavioursByKey(Int32 fullPathHash, Int32 layerIndex, Type type) { }

	// RVA: 0xFFFFFFFF75BE4524
	public Boolean get_stabilizeFeet() { }

	// RVA: 0xFFFFFFFF75BE4564
	public Void set_stabilizeFeet(Boolean value) { }

	// RVA: 0xFFFFFFFF723B4274
	public Int32 get_layerCount() { }

	// RVA: 0xFFFFFFFF75BE45B4
	public String GetLayerName(Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF75BE4604
	public Int32 GetLayerIndex(String layerName) { }

	// RVA: 0xFFFFFFFF75BE4654
	public Single GetLayerWeight(Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF723B42B8
	public Void SetLayerWeight(Int32 layerIndex, Single weight) { }

	// RVA: 0xFFFFFFFF75BE46A4
	private Void GetAnimatorStateInfo(Int32 layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	// RVA: 0xFFFFFFFF75BE470C
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF75BE4794
	public AnimatorStateInfo GetNextAnimatorStateInfo(Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF75BE4818
	private Void GetAnimatorTransitionInfo(Int32 layerIndex, out AnimatorTransitionInfo info) { }

	// RVA: 0xFFFFFFFF75BE4870
	public AnimatorTransitionInfo GetAnimatorTransitionInfo(Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF75BE48E4
	internal Int32 GetAnimatorClipInfoCount(Int32 layerIndex, Boolean current) { }

	// RVA: 0xFFFFFFFF75BE493C
	public Int32 GetCurrentAnimatorClipInfoCount(Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF75BE4990
	public Int32 GetNextAnimatorClipInfoCount(Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF723B431C
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF75BE49E4
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF75BE4A34
	public Void GetCurrentAnimatorClipInfo(Int32 layerIndex, List<T0> clips) { }

	// RVA: 0xFFFFFFFF75BE4AF0
	private Void GetAnimatorClipInfoInternal(Int32 layerIndex, Boolean isCurrent, Object clips) { }

	// RVA: 0xFFFFFFFF75BE4B58
	public Void GetNextAnimatorClipInfo(Int32 layerIndex, List<T0> clips) { }

	// RVA: 0xFFFFFFFF75BE4C14
	public Boolean IsInTransition(Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF723B4370
	public AnimatorControllerParameter[] get_parameters() { }

	// RVA: 0xFFFFFFFF75BE4C64
	public Int32 get_parameterCount() { }

	// RVA: 0xFFFFFFFF75BE4CA4
	public AnimatorControllerParameter GetParameter(Int32 index) { }

	// RVA: 0xFFFFFFFF75BE4DF8
	public Single get_feetPivotActive() { }

	// RVA: 0xFFFFFFFF75BE4E38
	public Void set_feetPivotActive(Single value) { }

	// RVA: 0xFFFFFFFF75BE4E88
	public Single get_pivotWeight() { }

	// RVA: 0xFFFFFFFF75BE4EC8
	public Vector3 get_pivotPosition() { }

	// RVA: 0xFFFFFFFF75BE4F78
	private Void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, Int32 targetBodyPart, MatchTargetWeightMask weightMask, Single startNormalizedTime, Single targetNormalizedTime, Boolean completeMatch) { }

	// RVA: 0xFFFFFFFF75BE50AC
	public Void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, Single startNormalizedTime) { }

	// RVA: 0xFFFFFFFF75BE50E4
	public Void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, Single startNormalizedTime, Single targetNormalizedTime) { }

	// RVA: 0xFFFFFFFF75BE50FC
	public Void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, Single startNormalizedTime, Single targetNormalizedTime, Boolean completeMatch) { }

	// RVA: 0xFFFFFFFF75BE5110
	public Void InterruptMatchTarget() { }

	// RVA: 0xFFFFFFFF75BE5154
	public Void InterruptMatchTarget(Boolean completeMatch) { }

	// RVA: 0xFFFFFFFF75BE51A4
	public Boolean get_isMatchingTarget() { }

	// RVA: 0xFFFFFFFF723B43B4
	public Single get_speed() { }

	// RVA: 0xFFFFFFFF723B4408
	public Void set_speed(Single value) { }

	// RVA: 0xFFFFFFFF75BE51E4
	public Void ForceStateNormalizedTime(Single normalizedTime) { }

	// RVA: 0xFFFFFFFF75BE52A4
	public Void CrossFadeInFixedTime(String stateName, Single fixedTransitionDuration) { }

	// RVA: 0xFFFFFFFF75BE5410
	public Void CrossFadeInFixedTime(String stateName, Single fixedTransitionDuration, Int32 layer) { }

	// RVA: 0xFFFFFFFF75BE54AC
	public Void CrossFadeInFixedTime(String stateName, Single fixedTransitionDuration, Int32 layer, Single fixedTimeOffset) { }

	// RVA: 0xFFFFFFFF75BE554C
	public Void CrossFadeInFixedTime(String stateName, Single fixedTransitionDuration, Int32 layer, Single fixedTimeOffset, Single normalizedTransitionTime) { }

	// RVA: 0xFFFFFFFF75BE55F8
	public Void CrossFadeInFixedTime(Int32 stateHashName, Single fixedTransitionDuration, Int32 layer, Single fixedTimeOffset) { }

	// RVA: 0xFFFFFFFF75BE566C
	public Void CrossFadeInFixedTime(Int32 stateHashName, Single fixedTransitionDuration, Int32 layer) { }

	// RVA: 0xFFFFFFFF75BE56DC
	public Void CrossFadeInFixedTime(Int32 stateHashName, Single fixedTransitionDuration) { }

	// RVA: 0xFFFFFFFF75BE5390
	public Void CrossFadeInFixedTime(Int32 stateHashName, Single fixedTransitionDuration, Int32 layer, Single fixedTimeOffset, Single normalizedTransitionTime) { }

	// RVA: 0xFFFFFFFF75BE5748
	public Void WriteDefaultValues() { }

	// RVA: 0xFFFFFFFF75BE5788
	public Void CrossFade(String stateName, Single normalizedTransitionDuration, Int32 layer, Single normalizedTimeOffset) { }

	// RVA: 0xFFFFFFFF75BE583C
	public Void CrossFade(String stateName, Single normalizedTransitionDuration, Int32 layer) { }

	// RVA: 0xFFFFFFFF75BE584C
	public Void CrossFade(String stateName, Single normalizedTransitionDuration) { }

	// RVA: 0xFFFFFFFF75BE5790
	public Void CrossFade(String stateName, Single normalizedTransitionDuration, Int32 layer, Single normalizedTimeOffset, Single normalizedTransitionTime) { }

	// RVA: 0xFFFFFFFF75BE5860
	public Void CrossFade(Int32 stateHashName, Single normalizedTransitionDuration, Int32 layer, Single normalizedTimeOffset, Single normalizedTransitionTime) { }

	// RVA: 0xFFFFFFFF75BE58E0
	public Void CrossFade(Int32 stateHashName, Single normalizedTransitionDuration, Int32 layer, Single normalizedTimeOffset) { }

	// RVA: 0xFFFFFFFF75BE5954
	public Void CrossFade(Int32 stateHashName, Single normalizedTransitionDuration, Int32 layer) { }

	// RVA: 0xFFFFFFFF75BE59C8
	public Void CrossFade(Int32 stateHashName, Single normalizedTransitionDuration) { }

	// RVA: 0xFFFFFFFF75BE5A38
	public Void PlayInFixedTime(String stateName, Int32 layer) { }

	// RVA: 0xFFFFFFFF75BE5AD8
	public Void PlayInFixedTime(String stateName) { }

	// RVA: 0xFFFFFFFF75BE5A44
	public Void PlayInFixedTime(String stateName, Int32 layer, Single fixedTime) { }

	// RVA: 0xFFFFFFFF75BE5AE8
	public Void PlayInFixedTime(Int32 stateNameHash, Int32 layer, Single fixedTime) { }

	// RVA: 0xFFFFFFFF75BE5B50
	public Void PlayInFixedTime(Int32 stateNameHash, Int32 layer) { }

	// RVA: 0xFFFFFFFF75BE5BB0
	public Void PlayInFixedTime(Int32 stateNameHash) { }

	// RVA: 0xFFFFFFFF75BE5C0C
	public Void Play(String stateName, Int32 layer) { }

	// RVA: 0xFFFFFFFF75BE5C18
	public Void Play(String stateName) { }

	// RVA: 0xFFFFFFFF723B4464
	public Void Play(String stateName, Int32 layer, Single normalizedTime) { }

	// RVA: 0xFFFFFFFF75BE523C
	public Void Play(Int32 stateNameHash, Int32 layer, Single normalizedTime) { }

	// RVA: 0xFFFFFFFF75BE5C28
	public Void Play(Int32 stateNameHash, Int32 layer) { }

	// RVA: 0xFFFFFFFF75BE5C88
	public Void Play(Int32 stateNameHash) { }

	// RVA: 0xFFFFFFFF75BE5CE4
	public Void SetTarget(AvatarTarget targetIndex, Single targetNormalizedTime) { }

	// RVA: 0xFFFFFFFF75BE5D44
	public Vector3 get_targetPosition() { }

	// RVA: 0xFFFFFFFF75BE5DF4
	public Quaternion get_targetRotation() { }

	// RVA: 0xFFFFFFFF75BE5EA0
	public Boolean IsControlled(Transform transform) { }

	// RVA: 0xFFFFFFFF75BE5EA8
	internal Boolean IsBoneTransform(Transform transform) { }

	// RVA: 0xFFFFFFFF75BE5EF8
	internal Transform get_avatarRoot() { }

	// RVA: 0xFFFFFFFF75BE5F38
	public Transform GetBoneTransform(HumanBodyBones humanBoneId) { }

	// RVA: 0xFFFFFFFF75BE6058
	internal Transform GetBoneTransformInternal(Int32 humanBoneId) { }

	// RVA: 0xFFFFFFFF75BE60A8
	public AnimatorCullingMode get_cullingMode() { }

	// RVA: 0xFFFFFFFF723B4500
	public Void set_cullingMode(AnimatorCullingMode value) { }

	// RVA: 0xFFFFFFFF75BE60E8
	public Void StartPlayback() { }

	// RVA: 0xFFFFFFFF75BE6128
	public Void StopPlayback() { }

	// RVA: 0xFFFFFFFF75BE6168
	public Single get_playbackTime() { }

	// RVA: 0xFFFFFFFF75BE61A8
	public Void set_playbackTime(Single value) { }

	// RVA: 0xFFFFFFFF75BE61F8
	public Void StartRecording(Int32 frameCount) { }

	// RVA: 0xFFFFFFFF75BE6248
	public Void StopRecording() { }

	// RVA: 0xFFFFFFFF75BE6288
	public Single get_recorderStartTime() { }

	// RVA: 0xFFFFFFFF75BE6308
	public Void set_recorderStartTime(Single value) { }

	// RVA: 0xFFFFFFFF75BE62C8
	private Single GetRecorderStartTime() { }

	// RVA: 0xFFFFFFFF75BE630C
	public Single get_recorderStopTime() { }

	// RVA: 0xFFFFFFFF75BE638C
	public Void set_recorderStopTime(Single value) { }

	// RVA: 0xFFFFFFFF75BE634C
	private Single GetRecorderStopTime() { }

	// RVA: 0xFFFFFFFF75BE6390
	public AnimatorRecorderMode get_recorderMode() { }

	// RVA: 0xFFFFFFFF723B455C
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0xFFFFFFFF75BE63D0
	public Void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	// RVA: 0xFFFFFFFF75BE6424
	public Boolean get_hasBoundPlayables() { }

	// RVA: 0xFFFFFFFF75BE6464
	internal Void ClearInternalControllerPlayable() { }

	// RVA: 0xFFFFFFFF75BE64A4
	public Boolean HasState(Int32 layerIndex, Int32 stateID) { }

	// RVA: 0xFFFFFFFF75BE533C
	public static Int32 StringToHash(String name) { }

	// RVA: 0xFFFFFFFF75BE64FC
	public Avatar get_avatar() { }

	// RVA: 0xFFFFFFFF75BE653C
	public Void set_avatar(Avatar value) { }

	// RVA: 0xFFFFFFFF75BE658C
	internal String GetStats() { }

	// RVA: 0xFFFFFFFF75BE65CC
	public PlayableGraph get_playableGraph() { }

	// RVA: 0xFFFFFFFF75BE6624
	private Void GetCurrentGraph(ref PlayableGraph graph) { }

	// RVA: 0xFFFFFFFF75BE2E40
	private Void CheckIfInIKPass() { }

	// RVA: 0xFFFFFFFF75BE66B4
	private Boolean IsInIKPass() { }

	// RVA: 0xFFFFFFFF75BE1AD0
	private Void SetFloatString(String name, Single value) { }

	// RVA: 0xFFFFFFFF75BE1C80
	private Void SetFloatID(Int32 id, Single value) { }

	// RVA: 0xFFFFFFFF75BE19E0
	private Single GetFloatString(String name) { }

	// RVA: 0xFFFFFFFF75BE1A80
	private Single GetFloatID(Int32 id) { }

	// RVA: 0xFFFFFFFF75BE1F18
	private Void SetBoolString(String name, Boolean value) { }

	// RVA: 0xFFFFFFFF75BE1FC8
	private Void SetBoolID(Int32 id, Boolean value) { }

	// RVA: 0xFFFFFFFF75BE1DD0
	private Boolean GetBoolString(String name) { }

	// RVA: 0xFFFFFFFF75BE1E70
	private Boolean GetBoolID(Int32 id) { }

	// RVA: 0xFFFFFFFF75BE2164
	private Void SetIntegerString(String name, Int32 value) { }

	// RVA: 0xFFFFFFFF75BE2214
	private Void SetIntegerID(Int32 id, Int32 value) { }

	// RVA: 0xFFFFFFFF75BE2074
	private Int32 GetIntegerString(String name) { }

	// RVA: 0xFFFFFFFF75BE2114
	private Int32 GetIntegerID(Int32 id) { }

	// RVA: 0xFFFFFFFF75BE22C0
	private Void SetTriggerString(String name) { }

	// RVA: 0xFFFFFFFF75BE2360
	private Void SetTriggerID(Int32 id) { }

	// RVA: 0xFFFFFFFF75BE23B0
	private Void ResetTriggerString(String name) { }

	// RVA: 0xFFFFFFFF75BE2450
	private Void ResetTriggerID(Int32 id) { }

	// RVA: 0xFFFFFFFF75BE24F0
	private Boolean IsParameterControlledByCurveString(String name) { }

	// RVA: 0xFFFFFFFF75BE2590
	private Boolean IsParameterControlledByCurveID(Int32 id) { }

	// RVA: 0xFFFFFFFF75BE1BA8
	private Void SetFloatStringDamp(String name, Single value, Single dampTime, Single deltaTime) { }

	// RVA: 0xFFFFFFFF75BE1D58
	private Void SetFloatIDDamp(Int32 id, Single value, Single dampTime, Single deltaTime) { }

	// RVA: 0xFFFFFFFF75BE66F4
	public Boolean get_layersAffectMassCenter() { }

	// RVA: 0xFFFFFFFF75BE6734
	public Void set_layersAffectMassCenter(Boolean value) { }

	// RVA: 0xFFFFFFFF75BE6784
	public Single get_leftFeetBottomHeight() { }

	// RVA: 0xFFFFFFFF75BE67C4
	public Single get_rightFeetBottomHeight() { }

	// RVA: 0xFFFFFFFF75BE6804
	internal Boolean get_supportsOnAnimatorMove() { }

	// RVA: 0xFFFFFFFF75BE6844
	internal Void OnUpdateModeChanged() { }

	// RVA: 0xFFFFFFFF75BE6884
	internal Void OnCullingModeChanged() { }

	// RVA: 0xFFFFFFFF75BE68C4
	internal Void WriteDefaultPose() { }

	// RVA: 0xFFFFFFFF723B45B0
	public Void Update(Single deltaTime) { }

	// RVA: 0xFFFFFFFF723B4604
	public Void Rebind() { }

	// RVA: 0xFFFFFFFF75BE6904
	private Void Rebind(Boolean writeDefaultValues) { }

	// RVA: 0xFFFFFFFF75BE6954
	public Void ApplyBuiltinRootMotion() { }

	// RVA: 0xFFFFFFFF75BE6994
	internal Void EvaluateController() { }

	// RVA: 0xFFFFFFFF75BE69D8
	private Void EvaluateController(Single deltaTime) { }

	// RVA: 0xFFFFFFFF75BE6A28
	internal String GetCurrentStateName(Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF75BE6AD4
	internal String GetNextStateName(Int32 layerIndex) { }

	// RVA: 0xFFFFFFFF75BE6A7C
	private String GetAnimatorStateName(Int32 layerIndex, Boolean current) { }

	// RVA: 0xFFFFFFFF75BE6B28
	internal String ResolveHash(Int32 hash) { }

	// RVA: 0xFFFFFFFF75BE6674
	public Boolean get_logWarnings() { }

	// RVA: 0xFFFFFFFF723B464C
	public Void set_logWarnings(Boolean value) { }

	// RVA: 0xFFFFFFFF75BE6B78
	public Boolean get_fireEvents() { }

	// RVA: 0xFFFFFFFF75BE6BB8
	public Void set_fireEvents(Boolean value) { }

	// RVA: 0xFFFFFFFF75BE6C08
	public Boolean get_keepAnimatorControllerStateOnDisable() { }

	// RVA: 0xFFFFFFFF75BE6C48
	public Void set_keepAnimatorControllerStateOnDisable(Boolean value) { }

	// RVA: 0xFFFFFFFF75BE6C98
	public Vector3 GetVector(String name) { }

	// RVA: 0xFFFFFFFF75BE6CC8
	public Vector3 GetVector(Int32 id) { }

	// RVA: 0xFFFFFFFF75BE6CF8
	public Void SetVector(String name, Vector3 value) { }

	// RVA: 0xFFFFFFFF75BE6CFC
	public Void SetVector(Int32 id, Vector3 value) { }

	// RVA: 0xFFFFFFFF75BE6D00
	public Quaternion GetQuaternion(String name) { }

	// RVA: 0xFFFFFFFF75BE6D30
	public Quaternion GetQuaternion(Int32 id) { }

	// RVA: 0xFFFFFFFF75BE6D60
	public Void SetQuaternion(String name, Quaternion value) { }

	// RVA: 0xFFFFFFFF75BE6D64
	public Void SetQuaternion(Int32 id, Quaternion value) { }

	// RVA: 0xFFFFFFFF75BE6D68
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BE2640
	private Void get_deltaPosition_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75BE26EC
	private Void get_deltaRotation_Injected(out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75BE279C
	private Void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75BE284C
	private Void get_angularVelocity_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75BE28FC
	private Void get_rootPosition_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75BE29A4
	private Void set_rootPosition_Injected(ref Vector3 value) { }

	// RVA: 0xFFFFFFFF75BE2A50
	private Void get_rootRotation_Injected(out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75BE2AF8
	private Void set_rootRotation_Injected(ref Quaternion value) { }

	// RVA: 0xFFFFFFFF75BE3038
	private Void get_bodyPositionInternal_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75BE3088
	private Void set_bodyPositionInternal_Injected(ref Vector3 value) { }

	// RVA: 0xFFFFFFFF75BE322C
	private Void get_bodyRotationInternal_Injected(out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75BE327C
	private Void set_bodyRotationInternal_Injected(ref Quaternion value) { }

	// RVA: 0xFFFFFFFF75BE3368
	private Void GetGoalPosition_Injected(AvatarIKGoal goal, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75BE34B0
	private Void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) { }

	// RVA: 0xFFFFFFFF75BE35A0
	private Void GetGoalRotation_Injected(AvatarIKGoal goal, out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75BE36EC
	private Void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) { }

	// RVA: 0xFFFFFFFF75BE3AB0
	private Void GetHintPosition_Injected(AvatarIKHint hint, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75BE3BF8
	private Void SetHintPosition_Injected(AvatarIKHint hint, ref Vector3 hintPosition) { }

	// RVA: 0xFFFFFFFF75BE3E88
	private Void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) { }

	// RVA: 0xFFFFFFFF75BE42F4
	private Void SetBoneLocalRotationInternal_Injected(Int32 humanBoneId, ref Quaternion rotation) { }

	// RVA: 0xFFFFFFFF75BE4F28
	private Void get_pivotPosition_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75BE5014
	private Void MatchTarget_Injected(ref Vector3 matchPosition, ref Quaternion matchRotation, Int32 targetBodyPart, ref MatchTargetWeightMask weightMask, Single startNormalizedTime, Single targetNormalizedTime, Boolean completeMatch) { }

	// RVA: 0xFFFFFFFF75BE5DA4
	private Void get_targetPosition_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75BE5E50
	private Void get_targetRotation_Injected(out Quaternion ret) { }

}

// Namespace: UnityEngine
public class AnimatorControllerParameter
{
	// Fields
	internal String m_Name; // 0x10
	internal AnimatorControllerParameterType m_Type; // 0x18
	internal Single m_DefaultFloat; // 0x1C
	internal Int32 m_DefaultInt; // 0x20
	internal Boolean m_DefaultBool; // 0x24

	// Properties
	public String name { get; }
	public AnimatorControllerParameterType type { get; }

	// Methods

	// RVA: 0xFFFFFFFF723B46F8
	public String get_name() { }

	// RVA: 0xFFFFFFFF75BE6DB8
	public AnimatorControllerParameterType get_type() { }

	// RVA: 0xFFFFFFFF75BE6DC0
	public override Boolean Equals(Object o) { }

	// RVA: 0xFFFFFFFF75BE6EA4
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75BE6ECC
	public Void .ctor() { }

}

// Namespace: UnityEngine
public class AnimationClipPair
{
	// Fields
	public AnimationClip originalClip; // 0x10
	public AnimationClip overrideClip; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75BDED04
	public Void .ctor() { }

}

// Namespace: UnityEngine
public class AnimatorOverrideController
{
	// Fields
	internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	// Properties
	public RuntimeAnimatorController runtimeAnimatorController { get; set; }
	public Int32 overridesCount { get; }
	public AnimationClipPair[] clips { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BE6F0C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BE700C
	public Void .ctor(RuntimeAnimatorController controller) { }

	// RVA: 0xFFFFFFFF75BE6FBC
	private static Void Internal_Create(AnimatorOverrideController self, RuntimeAnimatorController controller) { }

	// RVA: 0xFFFFFFFF75BE7084
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0xFFFFFFFF75BE70C4
	public Void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	// RVA: 0xFFFFFFFF75BE7114
	private Void SetClip(AnimationClip originalClip, AnimationClip overrideClip, Boolean notify) { }

	// RVA: 0xFFFFFFFF75BE717C
	private Void SendNotification() { }

	// RVA: 0xFFFFFFFF75BE71BC
	private AnimationClip GetOriginalClip(Int32 index) { }

	// RVA: 0xFFFFFFFF75BE720C
	private AnimationClip GetOverrideClip(AnimationClip originalClip) { }

	// RVA: 0xFFFFFFFF75BE725C
	public Int32 get_overridesCount() { }

	// RVA: 0xFFFFFFFF75BE729C
	public Void GetOverrides(List<T0> overrides) { }

	// RVA: 0xFFFFFFFF75BE74A4
	public Void ApplyOverrides(IList<T0> overrides) { }

	// RVA: 0xFFFFFFFF75BE7718
	public AnimationClipPair[] get_clips() { }

	// RVA: 0xFFFFFFFF75BE78E0
	internal static Void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

}

// Namespace: 
internal sealed class OnOverrideControllerDirtyCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75BE7B04
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75BE7908
	public virtual Void Invoke() { }

	// RVA: 0xFFFFFFFF75BE7B48
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BE7BA0
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine
public enum HumanBodyBones
{
	// Fields
	public Int32 value__; // 0x10
	public const HumanBodyBones Hips = 0;
	public const HumanBodyBones LeftUpperLeg = 1;
	public const HumanBodyBones RightUpperLeg = 2;
	public const HumanBodyBones LeftLowerLeg = 3;
	public const HumanBodyBones RightLowerLeg = 4;
	public const HumanBodyBones LeftFoot = 5;
	public const HumanBodyBones RightFoot = 6;
	public const HumanBodyBones Spine = 7;
	public const HumanBodyBones Chest = 8;
	public const HumanBodyBones UpperChest = 54;
	public const HumanBodyBones Neck = 9;
	public const HumanBodyBones Head = 10;
	public const HumanBodyBones LeftShoulder = 11;
	public const HumanBodyBones RightShoulder = 12;
	public const HumanBodyBones LeftUpperArm = 13;
	public const HumanBodyBones RightUpperArm = 14;
	public const HumanBodyBones LeftLowerArm = 15;
	public const HumanBodyBones RightLowerArm = 16;
	public const HumanBodyBones LeftHand = 17;
	public const HumanBodyBones RightHand = 18;
	public const HumanBodyBones LeftToes = 19;
	public const HumanBodyBones RightToes = 20;
	public const HumanBodyBones LeftEye = 21;
	public const HumanBodyBones RightEye = 22;
	public const HumanBodyBones Jaw = 23;
	public const HumanBodyBones LeftThumbProximal = 24;
	public const HumanBodyBones LeftThumbIntermediate = 25;
	public const HumanBodyBones LeftThumbDistal = 26;
	public const HumanBodyBones LeftIndexProximal = 27;
	public const HumanBodyBones LeftIndexIntermediate = 28;
	public const HumanBodyBones LeftIndexDistal = 29;
	public const HumanBodyBones LeftMiddleProximal = 30;
	public const HumanBodyBones LeftMiddleIntermediate = 31;
	public const HumanBodyBones LeftMiddleDistal = 32;
	public const HumanBodyBones LeftRingProximal = 33;
	public const HumanBodyBones LeftRingIntermediate = 34;
	public const HumanBodyBones LeftRingDistal = 35;
	public const HumanBodyBones LeftLittleProximal = 36;
	public const HumanBodyBones LeftLittleIntermediate = 37;
	public const HumanBodyBones LeftLittleDistal = 38;
	public const HumanBodyBones RightThumbProximal = 39;
	public const HumanBodyBones RightThumbIntermediate = 40;
	public const HumanBodyBones RightThumbDistal = 41;
	public const HumanBodyBones RightIndexProximal = 42;
	public const HumanBodyBones RightIndexIntermediate = 43;
	public const HumanBodyBones RightIndexDistal = 44;
	public const HumanBodyBones RightMiddleProximal = 45;
	public const HumanBodyBones RightMiddleIntermediate = 46;
	public const HumanBodyBones RightMiddleDistal = 47;
	public const HumanBodyBones RightRingProximal = 48;
	public const HumanBodyBones RightRingIntermediate = 49;
	public const HumanBodyBones RightRingDistal = 50;
	public const HumanBodyBones RightLittleProximal = 51;
	public const HumanBodyBones RightLittleIntermediate = 52;
	public const HumanBodyBones RightLittleDistal = 53;
	public const HumanBodyBones LastBone = 55;
}

// Namespace: UnityEngine
public class Avatar
{
	// Properties
	public Boolean isValid { get; }
	public Boolean isHuman { get; }
	public HumanDescription humanDescription { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BE7D64
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF75BE7DA4
	public Boolean get_isValid() { }

	// RVA: 0xFFFFFFFF75BE7DE4
	public Boolean get_isHuman() { }

	// RVA: 0xFFFFFFFF75BE7E24
	public HumanDescription get_humanDescription() { }

	// RVA: 0xFFFFFFFF75BE7EEC
	internal Void SetMuscleMinMax(Int32 muscleId, Single min, Single max) { }

	// RVA: 0xFFFFFFFF75BE7F54
	internal Void SetParameter(Int32 parameterId, Single value) { }

	// RVA: 0xFFFFFFFF75BE7FB4
	internal Single GetAxisLength(Int32 humanId) { }

	// RVA: 0xFFFFFFFF75BE8080
	internal Quaternion GetPreRotation(Int32 humanId) { }

	// RVA: 0xFFFFFFFF75BE8144
	internal Quaternion GetPostRotation(Int32 humanId) { }

	// RVA: 0xFFFFFFFF75BE8208
	internal Quaternion GetZYPostQ(Int32 humanId, Quaternion parentQ, Quaternion q) { }

	// RVA: 0xFFFFFFFF75BE8344
	internal Quaternion GetZYRoll(Int32 humanId, Vector3 uvw) { }

	// RVA: 0xFFFFFFFF75BE843C
	internal Vector3 GetLimitSign(Int32 humanId) { }

	// RVA: 0xFFFFFFFF75BE8030
	internal Single Internal_GetAxisLength(Int32 humanId) { }

	// RVA: 0xFFFFFFFF75BE80D8
	internal Quaternion Internal_GetPreRotation(Int32 humanId) { }

	// RVA: 0xFFFFFFFF75BE819C
	internal Quaternion Internal_GetPostRotation(Int32 humanId) { }

	// RVA: 0xFFFFFFFF75BE82C0
	internal Quaternion Internal_GetZYPostQ(Int32 humanId, Quaternion parentQ, Quaternion q) { }

	// RVA: 0xFFFFFFFF75BE83C4
	internal Quaternion Internal_GetZYRoll(Int32 humanId, Vector3 uvw) { }

	// RVA: 0xFFFFFFFF75BE8494
	internal Vector3 Internal_GetLimitSign(Int32 humanId) { }

	// RVA: 0xFFFFFFFF75BE7E9C
	private Void get_humanDescription_Injected(out HumanDescription ret) { }

	// RVA: 0xFFFFFFFF75BE8504
	private Void Internal_GetPreRotation_Injected(Int32 humanId, out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75BE855C
	private Void Internal_GetPostRotation_Injected(Int32 humanId, out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75BE85B4
	private Void Internal_GetZYPostQ_Injected(Int32 humanId, ref Quaternion parentQ, ref Quaternion q, out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75BE8624
	private Void Internal_GetZYRoll_Injected(Int32 humanId, ref Vector3 uvw, out Quaternion ret) { }

	// RVA: 0xFFFFFFFF75BE868C
	private Void Internal_GetLimitSign_Injected(Int32 humanId, out Vector3 ret) { }

}

// Namespace: UnityEngine
public struct SkeletonBone
{
	// Fields
	public String name; // 0x10
	internal String parentName; // 0x18
	public Vector3 position; // 0x20
	public Quaternion rotation; // 0x2C
	public Vector3 scale; // 0x3C
}

// Namespace: UnityEngine
public struct HumanLimit
{
	// Fields
	private Vector3 m_Min; // 0x10
	private Vector3 m_Max; // 0x1C
	private Vector3 m_Center; // 0x28
	private Single m_AxisLength; // 0x34
	private Int32 m_UseDefaultValues; // 0x38
}

// Namespace: UnityEngine
public struct HumanBone
{
	// Fields
	private String m_BoneName; // 0x10
	private String m_HumanName; // 0x18
	public HumanLimit limit; // 0x20
}

// Namespace: UnityEngine
public struct HumanDescription
{
	// Fields
	public HumanBone[] human; // 0x10
	public SkeletonBone[] skeleton; // 0x18
	internal Single m_ArmTwist; // 0x20
	internal Single m_ForeArmTwist; // 0x24
	internal Single m_UpperLegTwist; // 0x28
	internal Single m_LegTwist; // 0x2C
	internal Single m_ArmStretch; // 0x30
	internal Single m_LegStretch; // 0x34
	internal Single m_FeetSpacing; // 0x38
	internal Single m_GlobalScale; // 0x3C
	internal String m_RootMotionBoneName; // 0x40
	internal Boolean m_HasTranslationDoF; // 0x48
	internal Boolean m_HasExtraRoot; // 0x49
	internal Boolean m_SkeletonHasParents; // 0x4A
}

// Namespace: UnityEngine
public enum AvatarMaskBodyPart
{
	// Fields
	public Int32 value__; // 0x10
	public const AvatarMaskBodyPart Root = 0;
	public const AvatarMaskBodyPart Body = 1;
	public const AvatarMaskBodyPart Head = 2;
	public const AvatarMaskBodyPart LeftLeg = 3;
	public const AvatarMaskBodyPart RightLeg = 4;
	public const AvatarMaskBodyPart LeftArm = 5;
	public const AvatarMaskBodyPart RightArm = 6;
	public const AvatarMaskBodyPart LeftFingers = 7;
	public const AvatarMaskBodyPart RightFingers = 8;
	public const AvatarMaskBodyPart LeftFootIK = 9;
	public const AvatarMaskBodyPart RightFootIK = 10;
	public const AvatarMaskBodyPart LeftHandIK = 11;
	public const AvatarMaskBodyPart RightHandIK = 12;
	public const AvatarMaskBodyPart LastBodyPart = 13;
}

// Namespace: UnityEngine
public sealed class AvatarMask
{
	// Properties
	public Int32 transformCount { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BE86E4
	public Boolean GetHumanoidBodyPartActive(AvatarMaskBodyPart index) { }

	// RVA: 0xFFFFFFFF75BE8734
	public Int32 get_transformCount() { }

	// RVA: 0xFFFFFFFF75BE8774
	public String GetTransformPath(Int32 index) { }

	// RVA: 0xFFFFFFFF75BE87C4
	private Single GetTransformWeight(Int32 index) { }

	// RVA: 0xFFFFFFFF75BE8814
	public Boolean GetTransformActive(Int32 index) { }

}

// Namespace: UnityEngine
public class HumanTrait
{
	// Methods

	// RVA: 0xFFFFFFFF75BE424C
	internal static Int32 GetBoneIndexFromMono(Int32 humanId) { }

}

// Namespace: UnityEngine
public class Motion
{
	// Fields
	private readonly Boolean <isAnimatorMotion>k__BackingField; // 0x18

	// Properties
	public Boolean isLooping { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BDE524
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF75BE8874
	public Boolean get_isLooping() { }

}

// Namespace: UnityEngine
public class RuntimeAnimatorController
{
	// Properties
	public AnimationClip[] animationClips { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BE6F74
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF723B4708
	public AnimationClip[] get_animationClips() { }

}

// Namespace: UnityEngine
internal enum AnimationEventSource
{
	// Fields
	public Int32 value__; // 0x10
	public const AnimationEventSource NoSource = 0;
	public const AnimationEventSource Legacy = 1;
	public const AnimationEventSource Animator = 2;
}

// Namespace: UnityEngine
public sealed class AnimationEvent
{
	// Fields
	internal Single m_Time; // 0x10
	internal String m_FunctionName; // 0x18
	internal String m_StringParameter; // 0x20
	internal Object m_ObjectReferenceParameter; // 0x28
	internal Single m_FloatParameter; // 0x30
	internal Int32 m_IntParameter; // 0x34
	internal Int32 m_MessageOptions; // 0x38
	internal AnimationEventSource m_Source; // 0x3C
	internal AnimationState m_StateSender; // 0x40
	internal AnimatorStateInfo m_AnimatorStateInfo; // 0x48
	internal AnimatorClipInfo m_AnimatorClipInfo; // 0x6C

	// Properties
	public String stringParameter { get; set; }
	public String functionName { get; set; }
	public Single time { set; }

	// Methods

	// RVA: 0xFFFFFFFF723B3AF0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BDED08
	public String get_stringParameter() { }

	// RVA: 0xFFFFFFFF723B3B9C
	public Void set_stringParameter(String value) { }

	// RVA: 0xFFFFFFFF75BDED10
	public String get_functionName() { }

	// RVA: 0xFFFFFFFF723B3BD4
	public Void set_functionName(String value) { }

	// RVA: 0xFFFFFFFF723B3C0C
	public Void set_time(Single value) { }

}

// Namespace: UnityEngine
public enum PlayMode
{
	// Fields
	public Int32 value__; // 0x10
	public const PlayMode StopSameLayer = 0;
	public const PlayMode StopAll = 4;
}

// Namespace: UnityEngine
public enum QueueMode
{
	// Fields
	public Int32 value__; // 0x10
	public const QueueMode CompleteOthers = 0;
	public const QueueMode PlayNow = 2;
}

// Namespace: UnityEngine
public enum AnimationPlayMode
{
	// Fields
	public Int32 value__; // 0x10
	public const AnimationPlayMode Stop = 0;
	public const AnimationPlayMode Queue = 1;
	public const AnimationPlayMode Mix = 2;
}

// Namespace: UnityEngine
public enum AnimationCullingType
{
	// Fields
	public Int32 value__; // 0x10
	public const AnimationCullingType AlwaysAnimate = 0;
	public const AnimationCullingType BasedOnRenderers = 1;
	public const AnimationCullingType BasedOnClipBounds = 2;
	public const AnimationCullingType BasedOnUserBounds = 3;
}

// Namespace: UnityEngine
public sealed class Animation
{
	// Properties
	public AnimationClip clip { get; set; }
	public Boolean playAutomatically { get; set; }
	public WrapMode wrapMode { get; set; }
	public Boolean isPlaying { get; }
	public AnimationState Item { get; }
	public Boolean animatePhysics { get; set; }
	public Boolean animateOnlyIfVisible { get; set; }
	public AnimationCullingType cullingType { get; set; }
	public Bounds localBounds { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF723B3128
	public AnimationClip get_clip() { }

	// RVA: 0xFFFFFFFF723B317C
	public Void set_clip(AnimationClip value) { }

	// RVA: 0xFFFFFFFF723B31D0
	public Boolean get_playAutomatically() { }

	// RVA: 0xFFFFFFFF723B3224
	public Void set_playAutomatically(Boolean value) { }

	// RVA: 0xFFFFFFFF75BDD5C0
	public WrapMode get_wrapMode() { }

	// RVA: 0xFFFFFFFF723B3278
	public Void set_wrapMode(WrapMode value) { }

	// RVA: 0xFFFFFFFF723B32D4
	public Void Stop() { }

	// RVA: 0xFFFFFFFF75BDD600
	private static Void INTERNAL_CALL_Stop(Animation self) { }

	// RVA: 0xFFFFFFFF75BDD640
	public Void Stop(String name) { }

	// RVA: 0xFFFFFFFF75BDD690
	private Void Internal_StopByName(String name) { }

	// RVA: 0xFFFFFFFF75BDD6E0
	public Void Rewind(String name) { }

	// RVA: 0xFFFFFFFF75BDD730
	private Void Internal_RewindByName(String name) { }

	// RVA: 0xFFFFFFFF75BDD780
	public Void Rewind() { }

	// RVA: 0xFFFFFFFF75BDD7C4
	private static Void INTERNAL_CALL_Rewind(Animation self) { }

	// RVA: 0xFFFFFFFF723B3328
	public Void Sample() { }

	// RVA: 0xFFFFFFFF75BDD804
	private static Void INTERNAL_CALL_Sample(Animation self) { }

	// RVA: 0xFFFFFFFF723B336C
	public Boolean get_isPlaying() { }

	// RVA: 0xFFFFFFFF723B33C0
	public Boolean IsPlaying(String name) { }

	// RVA: 0xFFFFFFFF723B3414
	public AnimationState get_Item(String name) { }

	// RVA: 0xFFFFFFFF723B3468
	public Boolean Play() { }

	// RVA: 0xFFFFFFFF75BDD894
	public Boolean Play(PlayMode mode) { }

	// RVA: 0xFFFFFFFF75BDD934
	public Boolean Play(String animation, PlayMode mode) { }

	// RVA: 0xFFFFFFFF723B34C0
	public Boolean Play(String animation) { }

	// RVA: 0xFFFFFFFF723B3518
	public Void CrossFade(String animation, Single fadeLength, PlayMode mode) { }

	// RVA: 0xFFFFFFFF723B3584
	public Void CrossFade(String animation, Single fadeLength) { }

	// RVA: 0xFFFFFFFF75BDD98C
	public Void CrossFade(String animation) { }

	// RVA: 0xFFFFFFFF75BDD9EC
	public Void Blend(String animation, Single targetWeight, Single fadeLength) { }

	// RVA: 0xFFFFFFFF75BDDA54
	public Void Blend(String animation, Single targetWeight) { }

	// RVA: 0xFFFFFFFF75BDDABC
	public Void Blend(String animation) { }

	// RVA: 0xFFFFFFFF723B35EC
	public AnimationState CrossFadeQueued(String animation, Single fadeLength, QueueMode queue, PlayMode mode) { }

	// RVA: 0xFFFFFFFF75BDDB18
	public AnimationState CrossFadeQueued(String animation, Single fadeLength, QueueMode queue) { }

	// RVA: 0xFFFFFFFF75BDDB88
	public AnimationState CrossFadeQueued(String animation, Single fadeLength) { }

	// RVA: 0xFFFFFFFF75BDDBF0
	public AnimationState CrossFadeQueued(String animation) { }

	// RVA: 0xFFFFFFFF75BDDC50
	public AnimationState PlayQueued(String animation, QueueMode queue, PlayMode mode) { }

	// RVA: 0xFFFFFFFF75BDDCB8
	public AnimationState PlayQueued(String animation, QueueMode queue) { }

	// RVA: 0xFFFFFFFF75BDDD14
	public AnimationState PlayQueued(String animation) { }

	// RVA: 0xFFFFFFFF75BDDD6C
	public Void AddClip(AnimationClip clip, String newName) { }

	// RVA: 0xFFFFFFFF75BDDE48
	public Void AddClip(AnimationClip clip, String newName, Int32 firstFrame, Int32 lastFrame, Boolean addLoopFrame) { }

	// RVA: 0xFFFFFFFF75BDDDD4
	public Void AddClip(AnimationClip clip, String newName, Int32 firstFrame, Int32 lastFrame) { }

	// RVA: 0xFFFFFFFF75BDDEC8
	public Void RemoveClip(AnimationClip clip) { }

	// RVA: 0xFFFFFFFF75BDDF18
	public Void RemoveClip(String clipName) { }

	// RVA: 0xFFFFFFFF75BDDFB8
	public Int32 GetClipCount() { }

	// RVA: 0xFFFFFFFF75BDDF68
	private Void RemoveClip2(String clipName) { }

	// RVA: 0xFFFFFFFF75BDD8E4
	private Boolean PlayDefaultAnimation(PlayMode mode) { }

	// RVA: 0xFFFFFFFF75BDDFFC
	public Boolean Play(AnimationPlayMode mode) { }

	// RVA: 0xFFFFFFFF75BDE04C
	public Boolean Play(String animation, AnimationPlayMode mode) { }

	// RVA: 0xFFFFFFFF75BDE0A4
	public Void SyncLayer(Int32 layer) { }

	// RVA: 0xFFFFFFFF75BDE0F4
	private static Void INTERNAL_CALL_SyncLayer(Animation self, Int32 layer) { }

	// RVA: 0xFFFFFFFF723B3660
	public IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75BDD844
	internal AnimationState GetState(String name) { }

	// RVA: 0xFFFFFFFF75BDE184
	internal AnimationState GetStateAtIndex(Int32 index) { }

	// RVA: 0xFFFFFFFF75BDE1D4
	internal Int32 GetStateCount() { }

	// RVA: 0xFFFFFFFF723B36BC
	public AnimationClip GetClip(String name) { }

	// RVA: 0xFFFFFFFF75BDE214
	public Boolean get_animatePhysics() { }

	// RVA: 0xFFFFFFFF75BDE254
	public Void set_animatePhysics(Boolean value) { }

	// RVA: 0xFFFFFFFF75BDE2A4
	public Boolean get_animateOnlyIfVisible() { }

	// RVA: 0xFFFFFFFF75BDE2E4
	public Void set_animateOnlyIfVisible(Boolean value) { }

	// RVA: 0xFFFFFFFF75BDE334
	public AnimationCullingType get_cullingType() { }

	// RVA: 0xFFFFFFFF723B37BC
	public Void set_cullingType(AnimationCullingType value) { }

	// RVA: 0xFFFFFFFF75BDE374
	public Bounds get_localBounds() { }

	// RVA: 0xFFFFFFFF75BDE438
	public Void set_localBounds(Bounds value) { }

	// RVA: 0xFFFFFFFF75BDE3E8
	private Void INTERNAL_get_localBounds(out Bounds value) { }

	// RVA: 0xFFFFFFFF75BDE488
	private Void INTERNAL_set_localBounds(ref Bounds value) { }

	// RVA: 0xFFFFFFFF75BDE4D8
	public Void .ctor() { }

}

// Namespace: 
private sealed class Enumerator
{
	// Fields
	private Animation m_Outer; // 0x10
	private Int32 m_CurrentIndex; // 0x18

	// Properties
	public Object Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BDE144
	internal Void .ctor(Animation outer) { }

	// RVA: 0xFFFFFFFF723B3818
	public Object get_Current() { }

	// RVA: 0xFFFFFFFF723B3888
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF723B3904
	public Void Reset() { }

}

// Namespace: UnityEngine
public sealed class AnimationState
{
	// Properties
	public Boolean enabled { set; }
	public Single weight { get; set; }
	public WrapMode wrapMode { get; set; }
	public Single time { get; set; }
	public Single normalizedTime { get; set; }
	public Single speed { get; set; }
	public Single length { get; }
	public Int32 layer { get; set; }
	public AnimationClip clip { get; }
	public String name { get; }

	// Methods

	// RVA: 0xFFFFFFFF723B3C14
	public Void set_enabled(Boolean value) { }

	// RVA: 0xFFFFFFFF75BDED18
	public Single get_weight() { }

	// RVA: 0xFFFFFFFF723B3C68
	public Void set_weight(Single value) { }

	// RVA: 0xFFFFFFFF723B3CBC
	public WrapMode get_wrapMode() { }

	// RVA: 0xFFFFFFFF75BDED58
	public Void set_wrapMode(WrapMode value) { }

	// RVA: 0xFFFFFFFF723B3D10
	public Single get_time() { }

	// RVA: 0xFFFFFFFF723B3D54
	public Void set_time(Single value) { }

	// RVA: 0xFFFFFFFF75BDEDAC
	public Single get_normalizedTime() { }

	// RVA: 0xFFFFFFFF723B3DA8
	public Void set_normalizedTime(Single value) { }

	// RVA: 0xFFFFFFFF723B3DFC
	public Single get_speed() { }

	// RVA: 0xFFFFFFFF723B3E50
	public Void set_speed(Single value) { }

	// RVA: 0xFFFFFFFF723B3EAC
	public Single get_length() { }

	// RVA: 0xFFFFFFFF75BDEDF0
	public Int32 get_layer() { }

	// RVA: 0xFFFFFFFF75BDEE34
	public Void set_layer(Int32 value) { }

	// RVA: 0xFFFFFFFF723B3768
	public AnimationClip get_clip() { }

	// RVA: 0xFFFFFFFF75BDEE84
	public Void AddMixingTransform(Transform mix, Boolean recursive) { }

	// RVA: 0xFFFFFFFF723B3EF0
	public String get_name() { }

	// RVA: 0xFFFFFFFF75BDEEDC
	public Void .ctor() { }

}

// Namespace: UnityEngine.Animations
public static class AnimationPlayableBinding
{
	// Methods

	// RVA: 0xFFFFFFFF75BE097C
	public static PlayableBinding Create(String name, Object key) { }

	// RVA: 0xFFFFFFFF75BE0A60
	private static PlayableOutput CreateAnimationOutput(PlayableGraph graph, String name) { }

}

// Namespace: UnityEngine.Animations
public class NotKeyableAttribute
{}

// Namespace: UnityEngine.Animations
public struct AnimationClipPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75BDEEE4
	public static AnimationClipPlayable Create(PlayableGraph graph, AnimationClip clip) { }

	// RVA: 0xFFFFFFFF75BDEF20
	private static PlayableHandle CreateHandle(PlayableGraph graph, AnimationClip clip) { }

	// RVA: 0xFFFFFFFF71149A60
	internal Void .ctor(PlayableHandle handle) { }

	// RVA: 0xFFFFFFFF71149A68
	public PlayableHandle GetHandle() { }

	// RVA: 0xFFFFFFFF75BDF0F0
	public static Playable op_Implicit(AnimationClipPlayable playable) { }

	// RVA: 0xFFFFFFFF71149A74
	public Boolean Equals(AnimationClipPlayable other) { }

	// RVA: 0xFFFFFFFF71149A7C
	public Void SetApplyFootIK(Boolean value) { }

	// RVA: 0xFFFFFFFF71149ACC
	internal Void SetRemoveStartOffset(Boolean value) { }

	// RVA: 0xFFFFFFFF71149B1C
	internal Void SetOverrideLoopTime(Boolean value) { }

	// RVA: 0xFFFFFFFF71149B6C
	internal Void SetLoopTime(Boolean value) { }

	// RVA: 0xFFFFFFFF75BDF080
	private static Boolean CreateHandleInternal(PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle) { }

	// RVA: 0xFFFFFFFF75BDF1D0
	private static Void SetApplyFootIKInternal(ref PlayableHandle handle, Boolean value) { }

	// RVA: 0xFFFFFFFF75BDF270
	private static Void SetRemoveStartOffsetInternal(ref PlayableHandle handle, Boolean value) { }

	// RVA: 0xFFFFFFFF75BDF310
	private static Void SetOverrideLoopTimeInternal(ref PlayableHandle handle, Boolean value) { }

	// RVA: 0xFFFFFFFF75BDF3B0
	private static Void SetLoopTimeInternal(ref PlayableHandle handle, Boolean value) { }

	// RVA: 0xFFFFFFFF75BDF400
	private static Boolean CreateHandleInternal_Injected(ref PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle) { }

}

// Namespace: UnityEngine.Animations
public struct AnimationHumanStream
{
	// Fields
	private IntPtr stream; // 0x10
}

// Namespace: UnityEngine.Animations
public struct AnimationLayerMixerPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75BDF458
	public static AnimationLayerMixerPlayable Create(PlayableGraph graph, Int32 inputCount) { }

	// RVA: 0xFFFFFFFF75BDF4F8
	private static PlayableHandle CreateHandle(PlayableGraph graph, Int32 inputCount) { }

	// RVA: 0xFFFFFFFF71149BBC
	internal Void .ctor(PlayableHandle handle) { }

	// RVA: 0xFFFFFFFF71149BC4
	public PlayableHandle GetHandle() { }

	// RVA: 0xFFFFFFFF75BDF71C
	public static Playable op_Implicit(AnimationLayerMixerPlayable playable) { }

	// RVA: 0xFFFFFFFF71149BD0
	public Boolean Equals(AnimationLayerMixerPlayable other) { }

	// RVA: 0xFFFFFFFF71149BD8
	public Void SetLayerMaskFromAvatarMask(UInt32 layerIndex, AvatarMask mask) { }

	// RVA: 0xFFFFFFFF75BDF680
	private static Boolean CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	// RVA: 0xFFFFFFFF75BDF958
	private static Void SetLayerMaskFromAvatarMaskInternal(ref PlayableHandle handle, UInt32 layerIndex, AvatarMask mask) { }

	// RVA: 0xFFFFFFFF75BDFA00
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75BDF9B0
	private static Boolean CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) { }

}

// Namespace: UnityEngine.Animations
public struct AnimationMixerPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75BDFA94
	public static AnimationMixerPlayable Create(PlayableGraph graph, Int32 inputCount, Boolean normalizeWeights) { }

	// RVA: 0xFFFFFFFF75BDFB44
	private static PlayableHandle CreateHandle(PlayableGraph graph, Int32 inputCount, Boolean normalizeWeights) { }

	// RVA: 0xFFFFFFFF71149BE0
	internal Void .ctor(PlayableHandle handle) { }

	// RVA: 0xFFFFFFFF71149BE8
	public PlayableHandle GetHandle() { }

	// RVA: 0xFFFFFFFF75BDFD88
	public static Playable op_Implicit(AnimationMixerPlayable playable) { }

	// RVA: 0xFFFFFFFF71149BF4
	public Boolean Equals(AnimationMixerPlayable other) { }

	// RVA: 0xFFFFFFFF75BDFCDC
	private static Boolean CreateHandleInternal(PlayableGraph graph, Boolean normalizeWeights, ref PlayableHandle handle) { }

	// RVA: 0xFFFFFFFF75BDFE70
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75BDFE18
	private static Boolean CreateHandleInternal_Injected(ref PlayableGraph graph, Boolean normalizeWeights, ref PlayableHandle handle) { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationMotionXToDeltaPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75BDFF04
	public static AnimationMotionXToDeltaPlayable Create(PlayableGraph graph) { }

	// RVA: 0xFFFFFFFF75BDFF9C
	private static PlayableHandle CreateHandle(PlayableGraph graph) { }

	// RVA: 0xFFFFFFFF71149BFC
	private Void .ctor(PlayableHandle handle) { }

	// RVA: 0xFFFFFFFF71149C04
	public PlayableHandle GetHandle() { }

	// RVA: 0xFFFFFFFF75BE01BC
	public static Playable op_Implicit(AnimationMotionXToDeltaPlayable playable) { }

	// RVA: 0xFFFFFFFF71149C10
	public Boolean Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0xFFFFFFFF71149C18
	public Void SetAbsoluteMotion(Boolean value) { }

	// RVA: 0xFFFFFFFF75BE0120
	private static Boolean CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	// RVA: 0xFFFFFFFF75BE02D8
	private static Void SetAbsoluteMotionInternal(ref PlayableHandle handle, Boolean value) { }

	// RVA: 0xFFFFFFFF75BE0378
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75BE0328
	private static Boolean CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationOffsetPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75BE040C
	public static AnimationOffsetPlayable Create(PlayableGraph graph, Vector3 position, Quaternion rotation, Int32 inputCount) { }

	// RVA: 0xFFFFFFFF75BE0504
	private static PlayableHandle CreateHandle(PlayableGraph graph, Vector3 position, Quaternion rotation, Int32 inputCount) { }

	// RVA: 0xFFFFFFFF71149C20
	internal Void .ctor(PlayableHandle handle) { }

	// RVA: 0xFFFFFFFF71149C28
	public PlayableHandle GetHandle() { }

	// RVA: 0xFFFFFFFF75BE0798
	public static Playable op_Implicit(AnimationOffsetPlayable playable) { }

	// RVA: 0xFFFFFFFF71149C34
	public Boolean Equals(AnimationOffsetPlayable other) { }

	// RVA: 0xFFFFFFFF75BE06E4
	private static Boolean CreateHandleInternal(PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle) { }

	// RVA: 0xFFFFFFFF75BE08E8
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75BE0880
	private static Boolean CreateHandleInternal_Injected(ref PlayableGraph graph, ref Vector3 position, ref Quaternion rotation, ref PlayableHandle handle) { }

}

// Namespace: UnityEngine.Animations
public static class AnimationPlayableExtensions
{
	// Methods

	// RVA: -1
	public static Void SetAnimatedProperties(U playable, AnimationClip clip) { }

	// RVA: 0xFFFFFFFF723B3F44
	internal static Void SetAnimatedPropertiesInternal(ref PlayableHandle playable, AnimationClip animatedProperties) { }

}

// Namespace: UnityEngine.Animations
internal static class AnimationPlayableGraphExtensions
{
	// Methods

	// RVA: 0xFFFFFFFF75BE0B8C
	internal static Boolean InternalCreateAnimationOutput(ref PlayableGraph graph, String name, out PlayableOutputHandle handle) { }

}

// Namespace: UnityEngine.Animations
public struct AnimationPlayableOutput
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x10

	// Properties
	public static AnimationPlayableOutput Null { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BE0AA4
	public static AnimationPlayableOutput Create(PlayableGraph graph, String name, Animator target) { }

	// RVA: 0xFFFFFFFF71149C3C
	internal Void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0xFFFFFFFF75BE0BE4
	public static AnimationPlayableOutput get_Null() { }

	// RVA: 0xFFFFFFFF71149C44
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0xFFFFFFFF75BE0B58
	public static PlayableOutput op_Implicit(AnimationPlayableOutput output) { }

	// RVA: 0xFFFFFFFF75BE0D58
	public static AnimationPlayableOutput op_Explicit(PlayableOutput output) { }

	// RVA: 0xFFFFFFFF71149C50
	public Void SetTarget(Animator value) { }

	// RVA: 0xFFFFFFFF75BE0DA0
	private static Void InternalSetTarget(ref PlayableOutputHandle handle, Animator target) { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationPosePlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationPosePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF71149CA0
	internal Void .ctor(PlayableHandle handle) { }

	// RVA: 0xFFFFFFFF71149CA8
	public PlayableHandle GetHandle() { }

	// RVA: 0xFFFFFFFF71149CB4
	public Boolean Equals(AnimationPosePlayable other) { }

	// RVA: 0xFFFFFFFF75BE0F6C
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationRemoveScalePlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75BE1000
	public static AnimationRemoveScalePlayable Create(PlayableGraph graph, Int32 inputCount) { }

	// RVA: 0xFFFFFFFF75BE10A0
	private static PlayableHandle CreateHandle(PlayableGraph graph, Int32 inputCount) { }

	// RVA: 0xFFFFFFFF71149CBC
	internal Void .ctor(PlayableHandle handle) { }

	// RVA: 0xFFFFFFFF71149CC4
	public PlayableHandle GetHandle() { }

	// RVA: 0xFFFFFFFF75BE12C4
	public static Playable op_Implicit(AnimationRemoveScalePlayable playable) { }

	// RVA: 0xFFFFFFFF71149CD0
	public Boolean Equals(AnimationRemoveScalePlayable other) { }

	// RVA: 0xFFFFFFFF75BE1228
	private static Boolean CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	// RVA: 0xFFFFFFFF75BE13FC
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75BE13AC
	private static Boolean CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) { }

}

// Namespace: UnityEngine.Animations
public struct AnimationScriptPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationScriptPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF71149CD8
	internal Void .ctor(PlayableHandle handle) { }

	// RVA: 0xFFFFFFFF71149CE0
	public PlayableHandle GetHandle() { }

	// RVA: 0xFFFFFFFF71149CEC
	public Boolean Equals(AnimationScriptPlayable other) { }

	// RVA: 0xFFFFFFFF75BE15B4
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Animations
public struct AnimationStream
{
	// Fields
	private UInt32 m_AnimatorBindingsVersion; // 0x10
	private IntPtr constant; // 0x18
	private IntPtr input; // 0x20
	private IntPtr output; // 0x28
	private IntPtr workspace; // 0x30
	private IntPtr inputStreamAccessor; // 0x38
	private IntPtr animationHandleBinder; // 0x40
}

// Namespace: UnityEngine.Animations
public struct AnimatorControllerPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimatorControllerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF71149CF4
	internal Void .ctor(PlayableHandle handle) { }

	// RVA: 0xFFFFFFFF71149CFC
	public PlayableHandle GetHandle() { }

	// RVA: 0xFFFFFFFF71149D08
	public Void SetHandle(PlayableHandle handle) { }

	// RVA: 0xFFFFFFFF71149D10
	public Boolean Equals(AnimatorControllerPlayable other) { }

	// RVA: 0xFFFFFFFF75BE180C
	private static Void .cctor() { }

}


