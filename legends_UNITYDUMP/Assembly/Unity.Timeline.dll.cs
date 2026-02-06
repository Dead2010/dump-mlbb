// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Timeline
internal class AnimationOutputWeightProcessor
{
	// Fields
	private AnimationPlayableOutput m_Output; // 0x10
	private readonly List<T0> m_Mixers; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75BC0B10
	public Void .ctor(AnimationPlayableOutput output) { }

	// RVA: 0xFFFFFFFF75BC0BD4
	private Void FindMixers() { }

	// RVA: 0xFFFFFFFF75BC0CB0
	private Void FindMixers(Playable parent, Int32 port, Playable node) { }

	// RVA: 0xFFFFFFFF75BC0EBC
	public Void Evaluate() { }

}

// Namespace: 
private struct WeightInfo
{
	// Fields
	public Playable mixer; // 0x10
	public Playable parentMixer; // 0x20
	public Int32 port; // 0x30
}

// Namespace: UnityEngine.Timeline
public sealed class CreateAnimationClipDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75BC9540
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75BC1714
	public virtual AnimationClip Invoke(String gameObjectName, String clipName) { }

	// RVA: 0xFFFFFFFF75BC9584
	public virtual IAsyncResult BeginInvoke(String gameObjectName, String clipName, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BC95E0
	public virtual AnimationClip EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine.Timeline
public class AnimationPlayableAsset
{
	// Fields
	public static CreateAnimationClipDelegate LoadAnimationAction; // 0x0
	private String m_GameObjectName; // 0x18
	private String m_ClipPath; // 0x20
	public Boolean m_isLoad; // 0x28
	private AnimationClip m_Clip; // 0x30
	private Vector3 m_Position; // 0x38
	private Vector3 m_EulerAngles; // 0x44
	private Boolean m_UseTrackMatchFields; // 0x50
	private MatchTargetFields m_MatchTargetFields; // 0x54
	private Boolean m_RemoveStartOffset; // 0x58
	private Boolean m_ApplyFootIK; // 0x59
	private LoopMode m_Loop; // 0x5C
	private AppliedOffsetMode <appliedOffsetMode>k__BackingField; // 0x60
	private static readonly Int32 k_LatestVersion; // 0x8
	private Int32 m_Version; // 0x64
	private Quaternion m_Rotation; // 0x68

	// Properties
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	public Vector3 eulerAngles { get; set; }
	public Boolean useTrackMatchFields { get; set; }
	public MatchTargetFields matchTargetFields { get; set; }
	public Boolean removeStartOffset { get; set; }
	public Boolean applyFootIK { get; set; }
	public LoopMode loop { get; set; }
	internal Boolean hasRootTransforms { get; }
	internal AppliedOffsetMode appliedOffsetMode { get; set; }
	public AnimationClip clip { get; set; }
	public override Double duration { get; }
	public override IEnumerable<T0> outputs { get; }
	public ClipCaps clipCaps { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BC117C
	public Vector3 get_position() { }

	// RVA: 0xFFFFFFFF75BC1188
	public Void set_position(Vector3 value) { }

	// RVA: 0xFFFFFFFF75BC1194
	public Quaternion get_rotation() { }

	// RVA: 0xFFFFFFFF75BC11E8
	public Void set_rotation(Quaternion value) { }

	// RVA: 0xFFFFFFFF75BC1228
	public Vector3 get_eulerAngles() { }

	// RVA: 0xFFFFFFFF75BC1234
	public Void set_eulerAngles(Vector3 value) { }

	// RVA: 0xFFFFFFFF75BC1240
	public Boolean get_useTrackMatchFields() { }

	// RVA: 0xFFFFFFFF75BC1248
	public Void set_useTrackMatchFields(Boolean value) { }

	// RVA: 0xFFFFFFFF75BC1250
	public MatchTargetFields get_matchTargetFields() { }

	// RVA: 0xFFFFFFFF75BC1258
	public Void set_matchTargetFields(MatchTargetFields value) { }

	// RVA: 0xFFFFFFFF75BC1260
	public Boolean get_removeStartOffset() { }

	// RVA: 0xFFFFFFFF75BC1268
	public Void set_removeStartOffset(Boolean value) { }

	// RVA: 0xFFFFFFFF75BC1270
	public Boolean get_applyFootIK() { }

	// RVA: 0xFFFFFFFF75BC1278
	public Void set_applyFootIK(Boolean value) { }

	// RVA: 0xFFFFFFFF75BC1280
	public LoopMode get_loop() { }

	// RVA: 0xFFFFFFFF75BC1288
	public Void set_loop(LoopMode value) { }

	// RVA: 0xFFFFFFFF75BC1290
	internal Boolean get_hasRootTransforms() { }

	// RVA: 0xFFFFFFFF75BC1370
	internal AppliedOffsetMode get_appliedOffsetMode() { }

	// RVA: 0xFFFFFFFF75BC1378
	internal Void set_appliedOffsetMode(AppliedOffsetMode value) { }

	// RVA: 0xFFFFFFFF75BC1380
	public AnimationClip get_clip() { }

	// RVA: 0xFFFFFFFF75BC1388
	public Void set_clip(AnimationClip value) { }

	// RVA: 0xFFFFFFFF75BC142C
	public override Double get_duration() { }

	// RVA: 0xFFFFFFFF75BC15E8
	public override IEnumerable<T0> get_outputs() { }

	// RVA: 0xFFFFFFFF75BC169C
	public Void UpdateAnimationClip() { }

	// RVA: 0xFFFFFFFF75BC1AE4
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0xFFFFFFFF75BC1BB0
	internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, Boolean removeStartOffset, AppliedOffsetMode mode, Boolean applyFootIK, LoopMode loop) { }

	// RVA: 0xFFFFFFFF75BC1F60
	private static Boolean ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip) { }

	// RVA: 0xFFFFFFFF75BC1F4C
	private static Boolean ShouldApplyScaleRemove(AppliedOffsetMode mode) { }

	// RVA: 0xFFFFFFFF75BC1FAC
	public ClipCaps get_clipCaps() { }

	// RVA: 0xFFFFFFFF75BC2030
	public Void ResetOffsets() { }

	// RVA: 0xFFFFFFFF75BC2088
	public Void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0xFFFFFFFF75BC12E8
	internal static Boolean HasRootTransforms(AnimationClip clip) { }

	// RVA: 0xFFFFFFFF75BC2140
	private Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0xFFFFFFFF75BC2188
	private Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0xFFFFFFFF75BC2200
	private Void OnUpgradeFromVersion(Int32 oldVersion) { }

	// RVA: 0xFFFFFFFF75BC227C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BC2344
	private static Void .cctor() { }

}

// Namespace: 
public enum LoopMode
{
	// Fields
	public Int32 value__; // 0x10
	public const LoopMode UseSourceAsset = 0;
	public const LoopMode On = 1;
	public const LoopMode Off = 2;
}

// Namespace: 
private static class AnimationPlayableAssetUpgrade
{
	// Methods

	// RVA: 0xFFFFFFFF75BC2244
	public static Void ConvertRotationToEuler(AnimationPlayableAsset asset) { }

}

// Namespace: 
private sealed class <get_outputs>d__49
{
	// Fields
	private Int32 <>1__state; // 0x10
	private PlayableBinding <>2__current; // 0x18
	private Int32 <>l__initialThreadId; // 0x38
	public AnimationPlayableAsset <>4__this; // 0x40

	// Properties
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BC1670
	public Void .ctor(Int32 <>1__state) { }

	// RVA: 0xFFFFFFFF75BC235C
	private Void System.IDisposable.Dispose() { }

	// RVA: 0xFFFFFFFF75BC2360
	private Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75BC2404
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

	// RVA: 0xFFFFFFFF75BC2414
	private Void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xFFFFFFFF75BC2468
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xFFFFFFFF75BC249C
	private IEnumerator<T0> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

	// RVA: 0xFFFFFFFF75BC2548
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.Timeline
public enum MatchTargetFields
{
	// Fields
	public Int32 value__; // 0x10
	public const MatchTargetFields PositionX = 1;
	public const MatchTargetFields PositionY = 2;
	public const MatchTargetFields PositionZ = 4;
	public const MatchTargetFields RotationX = 8;
	public const MatchTargetFields RotationY = 16;
	public const MatchTargetFields RotationZ = 32;
}

// Namespace: UnityEngine.Timeline
public enum TrackOffset
{
	// Fields
	public Int32 value__; // 0x10
	public const TrackOffset ApplyTransformOffsets = 0;
	public const TrackOffset ApplySceneOffsets = 1;
	public const TrackOffset Auto = 2;
}

// Namespace: UnityEngine.Timeline
internal enum AppliedOffsetMode
{
	// Fields
	public Int32 value__; // 0x10
	public const AppliedOffsetMode NoRootTransform = 0;
	public const AppliedOffsetMode TransformOffset = 1;
	public const AppliedOffsetMode SceneOffset = 2;
	public const AppliedOffsetMode TransformOffsetLegacy = 3;
	public const AppliedOffsetMode SceneOffsetLegacy = 4;
	public const AppliedOffsetMode SceneOffsetEditor = 5;
	public const AppliedOffsetMode SceneOffsetLegacyEditor = 6;
}

// Namespace: UnityEngine.Timeline
internal static class MatchTargetFieldConstants
{
	// Fields
	public static MatchTargetFields All; // 0x0
	public static MatchTargetFields None; // 0x4
	public static MatchTargetFields Position; // 0x8
	public static MatchTargetFields Rotation; // 0xC

	// Methods

	// RVA: 0xFFFFFFFF75BCB1E8
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Timeline
public class AnimationTrack
{
	// Fields
	private const String k_DefaultInfiniteClipName = "Recorded";
	private const String k_DefaultRecordableClipName = "Recorded";
	private ClipExtrapolation m_InfiniteClipPreExtrapolation; // 0xA0
	private ClipExtrapolation m_InfiniteClipPostExtrapolation; // 0xA4
	private Vector3 m_InfiniteClipOffsetPosition; // 0xA8
	private Vector3 m_InfiniteClipOffsetEulerAngles; // 0xB4
	private Double m_InfiniteClipTimeOffset; // 0xC0
	private Boolean m_InfiniteClipRemoveOffset; // 0xC8
	private Boolean m_InfiniteClipApplyFootIK; // 0xC9
	private LoopMode mInfiniteClipLoop; // 0xCC
	private MatchTargetFields m_MatchTargetFields; // 0xD0
	private Vector3 m_Position; // 0xD4
	private Vector3 m_EulerAngles; // 0xE0
	private AvatarMask m_AvatarMask; // 0xF0
	private Boolean m_ApplyAvatarMask; // 0xF8
	private TrackOffset m_TrackOffset; // 0xFC
	private AnimationClip m_InfiniteClip; // 0x100
	private static readonly Queue<T0> s_CachedQueue; // 0x0
	private Quaternion m_OpenClipOffsetRotation; // 0x108
	private Quaternion m_Rotation; // 0x118
	private Boolean m_ApplyOffsets; // 0x128

	// Properties
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	public Vector3 eulerAngles { get; set; }
	public Boolean applyOffsets { get; set; }
	public TrackOffset trackOffset { get; set; }
	public MatchTargetFields matchTargetFields { get; set; }
	public AnimationClip infiniteClip { get; set; }
	internal Boolean infiniteClipRemoveOffset { get; set; }
	public AvatarMask avatarMask { get; set; }
	public Boolean applyAvatarMask { get; set; }
	public override IEnumerable<T0> outputs { get; }
	public Boolean inClipMode { get; }
	public Vector3 infiniteClipOffsetPosition { get; set; }
	public Quaternion infiniteClipOffsetRotation { get; set; }
	public Vector3 infiniteClipOffsetEulerAngles { get; set; }
	internal Boolean infiniteClipApplyFootIK { get; set; }
	internal Double infiniteClipTimeOffset { get; set; }
	public ClipExtrapolation infiniteClipPreExtrapolation { get; set; }
	public ClipExtrapolation infiniteClipPostExtrapolation { get; set; }
	internal LoopMode infiniteClipLoop { get; set; }
	public Vector3 openClipOffsetPosition { get; set; }
	public Quaternion openClipOffsetRotation { get; set; }
	public Vector3 openClipOffsetEulerAngles { get; set; }
	public ClipExtrapolation openClipPreExtrapolation { get; set; }
	public ClipExtrapolation openClipPostExtrapolation { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75BC254C
	public Vector3 get_position() { }

	// RVA: 0xFFFFFFFF75BC2558
	public Void set_position(Vector3 value) { }

	// RVA: 0xFFFFFFFF75BC2564
	public Quaternion get_rotation() { }

	// RVA: 0xFFFFFFFF75BC25B8
	public Void set_rotation(Quaternion value) { }

	// RVA: 0xFFFFFFFF75BC25F8
	public Vector3 get_eulerAngles() { }

	// RVA: 0xFFFFFFFF75BC2604
	public Void set_eulerAngles(Vector3 value) { }

	// RVA: 0xFFFFFFFF75BC2610
	public Boolean get_applyOffsets() { }

	// RVA: 0xFFFFFFFF75BC2618
	public Void set_applyOffsets(Boolean value) { }

	// RVA: 0xFFFFFFFF75BC261C
	public TrackOffset get_trackOffset() { }

	// RVA: 0xFFFFFFFF75BC2624
	public Void set_trackOffset(TrackOffset value) { }

	// RVA: 0xFFFFFFFF75BC262C
	public MatchTargetFields get_matchTargetFields() { }

	// RVA: 0xFFFFFFFF75BC2634
	public Void set_matchTargetFields(MatchTargetFields value) { }

	// RVA: 0xFFFFFFFF75BC268C
	public AnimationClip get_infiniteClip() { }

	// RVA: 0xFFFFFFFF75BC2694
	internal Void set_infiniteClip(AnimationClip value) { }

	// RVA: 0xFFFFFFFF75BC26CC
	internal Boolean get_infiniteClipRemoveOffset() { }

	// RVA: 0xFFFFFFFF75BC26D4
	internal Void set_infiniteClipRemoveOffset(Boolean value) { }

	// RVA: 0xFFFFFFFF75BC26DC
	public AvatarMask get_avatarMask() { }

	// RVA: 0xFFFFFFFF75BC26E4
	public Void set_avatarMask(AvatarMask value) { }

	// RVA: 0xFFFFFFFF75BC271C
	public Boolean get_applyAvatarMask() { }

	// RVA: 0xFFFFFFFF75BC2724
	public Void set_applyAvatarMask(Boolean value) { }

	// RVA: 0xFFFFFFFF75BC272C
	internal override Boolean CanCompileClips() { }

	// RVA: 0xFFFFFFFF75BC2788
	public override IEnumerable<T0> get_outputs() { }

	// RVA: 0xFFFFFFFF75BC281C
	public Boolean get_inClipMode() { }

	// RVA: 0xFFFFFFFF75BC285C
	public Vector3 get_infiniteClipOffsetPosition() { }

	// RVA: 0xFFFFFFFF75BC2868
	public Void set_infiniteClipOffsetPosition(Vector3 value) { }

	// RVA: 0xFFFFFFFF75BC2874
	public Quaternion get_infiniteClipOffsetRotation() { }

	// RVA: 0xFFFFFFFF75BC28C8
	public Void set_infiniteClipOffsetRotation(Quaternion value) { }

	// RVA: 0xFFFFFFFF75BC2908
	public Vector3 get_infiniteClipOffsetEulerAngles() { }

	// RVA: 0xFFFFFFFF75BC2914
	public Void set_infiniteClipOffsetEulerAngles(Vector3 value) { }

	// RVA: 0xFFFFFFFF75BC2920
	internal Boolean get_infiniteClipApplyFootIK() { }

	// RVA: 0xFFFFFFFF75BC2928
	internal Void set_infiniteClipApplyFootIK(Boolean value) { }

	// RVA: 0xFFFFFFFF75BC2930
	internal Double get_infiniteClipTimeOffset() { }

	// RVA: 0xFFFFFFFF75BC2938
	internal Void set_infiniteClipTimeOffset(Double value) { }

	// RVA: 0xFFFFFFFF75BC2940
	public ClipExtrapolation get_infiniteClipPreExtrapolation() { }

	// RVA: 0xFFFFFFFF75BC2948
	public Void set_infiniteClipPreExtrapolation(ClipExtrapolation value) { }

	// RVA: 0xFFFFFFFF75BC2950
	public ClipExtrapolation get_infiniteClipPostExtrapolation() { }

	// RVA: 0xFFFFFFFF75BC2958
	public Void set_infiniteClipPostExtrapolation(ClipExtrapolation value) { }

	// RVA: 0xFFFFFFFF75BC2960
	internal LoopMode get_infiniteClipLoop() { }

	// RVA: 0xFFFFFFFF75BC2968
	internal Void set_infiniteClipLoop(LoopMode value) { }

	// RVA: 0xFFFFFFFF75BC2970
	private Void ResetOffsets() { }

	// RVA: 0xFFFFFFFF75BC29CC
	public TimelineClip CreateClip(AnimationClip clip) { }

	// RVA: 0xFFFFFFFF75BC2C24
	public Void CreateInfiniteClip(String infiniteClipName) { }

	// RVA: 0xFFFFFFFF75BC2E4C
	public TimelineClip CreateRecordableClip(String animClipName) { }

	// RVA: 0xFFFFFFFF75BC3090
	protected override Void OnCreateClip(TimelineClip clip) { }

	// RVA: 0xFFFFFFFF75BC314C
	protected internal override Int32 CalculateItemsHash() { }

	// RVA: 0xFFFFFFFF75BC29C8
	internal Void UpdateClipOffsets() { }

	// RVA: 0xFFFFFFFF75BC31D0
	private Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<T0> tree, AppliedOffsetMode mode) { }

	// RVA: 0xFFFFFFFF75BC3B6C
	private Playable UnityEngine.Timeline.ILayerable.CreateLayerMixer(PlayableGraph graph, GameObject go, Int32 inputCount) { }

	// RVA: 0xFFFFFFFF75BC3B9C
	internal override Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<T0> tree) { }

	// RVA: 0xFFFFFFFF75BC4720
	private Int32 GetDefaultBlendCount() { }

	// RVA: 0xFFFFFFFF75BC4B04
	private Void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, Boolean requireOffset) { }

	// RVA: 0xFFFFFFFF75BC4B18
	private Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot) { }

	// RVA: 0xFFFFFFFF75BC4A7C
	private Boolean RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject) { }

	// RVA: 0xFFFFFFFF75BC4B08
	private static Boolean UsesAbsoluteMotion(AppliedOffsetMode mode) { }

	// RVA: 0xFFFFFFFF75BC4D54
	private Boolean HasController(GameObject gameObject) { }

	// RVA: 0xFFFFFFFF75BC4C70
	internal Animator GetBinding(PlayableDirector director) { }

	// RVA: 0xFFFFFFFF75BC4728
	private static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, Int32 inputCount) { }

	// RVA: 0xFFFFFFFF75BC47A0
	private Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<T0> tree, AppliedOffsetMode mode) { }

	// RVA: 0xFFFFFFFF75BC39C8
	private Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode) { }

	// RVA: 0xFFFFFFFF75BC4DE4
	internal override Void GetEvaluationTime(out Double outStart, out Double outDuration) { }

	// RVA: 0xFFFFFFFF75BC4E64
	internal override Void GetSequenceTime(out Double outStart, out Double outDuration) { }

	// RVA: 0xFFFFFFFF75BC2A4C
	private Void AssignAnimationClip(TimelineClip clip, AnimationClip animClip) { }

	// RVA: 0xFFFFFFFF75BC5074
	public override Void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0xFFFFFFFF75BC5078
	private Void GetAnimationClips(List<T0> animClips) { }

	// RVA: 0xFFFFFFFF75BC46AC
	private AppliedOffsetMode GetOffsetMode(GameObject go, Boolean animatesRootTransform) { }

	// RVA: 0xFFFFFFFF75BC44D0
	private Boolean IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode) { }

	// RVA: 0xFFFFFFFF75BC438C
	private Transform GetGenericRootNode(GameObject gameObject) { }

	// RVA: 0xFFFFFFFF75BC369C
	internal Boolean AnimatesRootTransform() { }

	// RVA: 0xFFFFFFFF75BC53A4
	private static Transform FindInHierarchyBreadthFirst(Transform t, String name) { }

	// RVA: 0xFFFFFFFF75BC5568
	public Vector3 get_openClipOffsetPosition() { }

	// RVA: 0xFFFFFFFF75BC5574
	public Void set_openClipOffsetPosition(Vector3 value) { }

	// RVA: 0xFFFFFFFF75BC5580
	public Quaternion get_openClipOffsetRotation() { }

	// RVA: 0xFFFFFFFF75BC5584
	public Void set_openClipOffsetRotation(Quaternion value) { }

	// RVA: 0xFFFFFFFF75BC55C4
	public Vector3 get_openClipOffsetEulerAngles() { }

	// RVA: 0xFFFFFFFF75BC55D0
	public Void set_openClipOffsetEulerAngles(Vector3 value) { }

	// RVA: 0xFFFFFFFF75BC55DC
	public ClipExtrapolation get_openClipPreExtrapolation() { }

	// RVA: 0xFFFFFFFF75BC55E4
	public Void set_openClipPreExtrapolation(ClipExtrapolation value) { }

	// RVA: 0xFFFFFFFF75BC55EC
	public ClipExtrapolation get_openClipPostExtrapolation() { }

	// RVA: 0xFFFFFFFF75BC55F4
	public Void set_openClipPostExtrapolation(ClipExtrapolation value) { }

	// RVA: 0xFFFFFFFF75BC55FC
	internal override Void OnUpgradeFromVersion(Int32 oldVersion) { }

	// RVA: 0xFFFFFFFF75BC576C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BC58A0
	private static Void .cctor() { }

}

// Namespace: 
private static class AnimationTrackUpgrade
{
	// Methods

	// RVA: 0xFFFFFFFF75BC5650
	public static Void ConvertRotationsToEuler(AnimationTrack track) { }

	// RVA: 0xFFFFFFFF75BC569C
	public static Void ConvertRootMotion(AnimationTrack track) { }

	// RVA: 0xFFFFFFFF75BC5710
	public static Void ConvertInfiniteTrack(AnimationTrack track) { }

}

// Namespace: 
private sealed class <get_outputs>d__49
{
	// Fields
	private Int32 <>1__state; // 0x10
	private PlayableBinding <>2__current; // 0x18
	private Int32 <>l__initialThreadId; // 0x38
	public AnimationTrack <>4__this; // 0x40

	// Properties
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BC27F0
	public Void .ctor(Int32 <>1__state) { }

	// RVA: 0xFFFFFFFF75BC5900
	private Void System.IDisposable.Dispose() { }

	// RVA: 0xFFFFFFFF723A9F28
	private Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75BC5904
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

	// RVA: 0xFFFFFFFF75BC5914
	private Void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xFFFFFFFF75BC5968
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xFFFFFFFF75BC599C
	private IEnumerator<T0> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

	// RVA: 0xFFFFFFFF75BC5A28
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.Timeline
internal interface ICurvesOwner
{
	// Properties
	public abstract String defaultCurvesName { get; }
	public abstract Object asset { get; }
	public abstract Object assetOwner { get; }
	public abstract TrackAsset targetTrack { get; }

	// Methods

	// RVA: -1
	public abstract String get_defaultCurvesName() { }

	// RVA: -1
	public abstract Object get_asset() { }

	// RVA: -1
	public abstract Object get_assetOwner() { }

	// RVA: -1
	public abstract TrackAsset get_targetTrack() { }

}

// Namespace: UnityEngine.Timeline
public class TimelineClip
{
	// Fields
	private const Int32 k_LatestVersion = 1;
	private Int32 m_Version; // 0x10
	public static readonly ClipCaps kDefaultClipCaps; // 0x0
	public static readonly Single kDefaultClipDurationInSeconds; // 0x4
	public static readonly Double kTimeScaleMin; // 0x8
	public static readonly Double kTimeScaleMax; // 0x10
	internal static readonly String kDefaultCurvesName; // 0x18
	internal static readonly Double kMinDuration; // 0x20
	internal static readonly Double kMaxTimeValue; // 0x28
	private Double m_Start; // 0x18
	private Double m_ClipIn; // 0x20
	private Object m_Asset; // 0x28
	private Double m_Duration; // 0x30
	private Double m_TimeScale; // 0x38
	private TrackAsset m_ParentTrack; // 0x40
	private Double m_EaseInDuration; // 0x48
	private Double m_EaseOutDuration; // 0x50
	private Double m_BlendInDuration; // 0x58
	private Double m_BlendOutDuration; // 0x60
	private AnimationCurve m_MixInCurve; // 0x68
	private AnimationCurve m_MixOutCurve; // 0x70
	private BlendCurveMode m_BlendInCurveMode; // 0x78
	private BlendCurveMode m_BlendOutCurveMode; // 0x7C
	private List<T0> m_ExposedParameterNames; // 0x80
	private AnimationClip m_AnimationCurves; // 0x88
	private Boolean m_Recordable; // 0x90
	private ClipExtrapolation m_PostExtrapolationMode; // 0x94
	private ClipExtrapolation m_PreExtrapolationMode; // 0x98
	private Double m_PostExtrapolationTime; // 0xA0
	private Double m_PreExtrapolationTime; // 0xA8
	private String m_DisplayName; // 0xB0

	// Properties
	public Double timeScale { get; }
	public Double start { get; set; }
	public Double duration { get; set; }
	public Double end { get; }
	public Double clipIn { get; }
	public String displayName { get; set; }
	public AnimationClip curves { get; }
	private String UnityEngine.Timeline.ICurvesOwner.defaultCurvesName { get; }
	public Object asset { get; set; }
	private Object UnityEngine.Timeline.ICurvesOwner.assetOwner { get; }
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack { get; }
	public Double easeInDuration { get; }
	public Double easeOutDuration { get; }
	public Double blendInDuration { get; }
	public Double blendOutDuration { get; }
	public Boolean hasBlendIn { get; }
	public Boolean hasBlendOut { get; }
	public AnimationCurve mixInCurve { get; set; }
	public Double mixInDuration { get; }
	public AnimationCurve mixOutCurve { get; set; }
	public Double mixOutTime { get; }
	public Double mixOutDuration { get; }
	public Boolean recordable { get; set; }
	public ClipCaps clipCaps { get; }
	public AnimationClip animationClip { get; }
	public ClipExtrapolation postExtrapolationMode { get; set; }
	public ClipExtrapolation preExtrapolationMode { get; set; }
	public Double extrapolatedStart { get; }
	public Double extrapolatedDuration { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BCF1DC
	private Void UpgradeToLatestVersion() { }

	// RVA: 0xFFFFFFFF75BCF258
	internal Void .ctor(TrackAsset parent) { }

	// RVA: 0xFFFFFFFF723ADC88
	public Double get_timeScale() { }

	// RVA: 0xFFFFFFFF75BCF328
	public Double get_start() { }

	// RVA: 0xFFFFFFFF75BC2F5C
	public Void set_start(Double value) { }

	// RVA: 0xFFFFFFFF75BCF450
	public Double get_duration() { }

	// RVA: 0xFFFFFFFF75BC3004
	public Void set_duration(Double value) { }

	// RVA: 0xFFFFFFFF723AA780
	public Double get_end() { }

	// RVA: 0xFFFFFFFF75BCBE70
	public Double get_clipIn() { }

	// RVA: 0xFFFFFFFF75BCF458
	public String get_displayName() { }

	// RVA: 0xFFFFFFFF75BCF460
	public Void set_displayName(String value) { }

	// RVA: 0xFFFFFFFF75BCF498
	public AnimationClip get_curves() { }

	// RVA: 0xFFFFFFFF75BCF4A0
	private String UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName() { }

	// RVA: 0xFFFFFFFF75BCF4E0
	public Object get_asset() { }

	// RVA: 0xFFFFFFFF75BCF4E8
	public Void set_asset(Object value) { }

	// RVA: 0xFFFFFFFF75BCF520
	private Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner() { }

	// RVA: 0xFFFFFFFF75BCF528
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack() { }

	// RVA: 0xFFFFFFFF75BCF530
	public TrackAsset GetParentTrack() { }

	// RVA: 0xFFFFFFFF75BCF26C
	internal Void SetParentTrack_Internal(TrackAsset newParentTrack) { }

	// RVA: 0xFFFFFFFF723ADD38
	public Double get_easeInDuration() { }

	// RVA: 0xFFFFFFFF723ADE5C
	public Double get_easeOutDuration() { }

	// RVA: 0xFFFFFFFF75BCF650
	public Double get_blendInDuration() { }

	// RVA: 0xFFFFFFFF75BCF67C
	public Double get_blendOutDuration() { }

	// RVA: 0xFFFFFFFF75BCF618
	public Boolean get_hasBlendIn() { }

	// RVA: 0xFFFFFFFF75BCF5E0
	public Boolean get_hasBlendOut() { }

	// RVA: 0xFFFFFFFF75BCF6A8
	public AnimationCurve get_mixInCurve() { }

	// RVA: 0xFFFFFFFF75BCF744
	public Void set_mixInCurve(AnimationCurve value) { }

	// RVA: 0xFFFFFFFF723ADF80
	public Double get_mixInDuration() { }

	// RVA: 0xFFFFFFFF75BCF77C
	public AnimationCurve get_mixOutCurve() { }

	// RVA: 0xFFFFFFFF75BCF818
	public Void set_mixOutCurve(AnimationCurve value) { }

	// RVA: 0xFFFFFFFF75BCF850
	public Double get_mixOutTime() { }

	// RVA: 0xFFFFFFFF723ADFD4
	public Double get_mixOutDuration() { }

	// RVA: 0xFFFFFFFF75BCF888
	public Boolean get_recordable() { }

	// RVA: 0xFFFFFFFF75BCF890
	internal Void set_recordable(Boolean value) { }

	// RVA: 0xFFFFFFFF723AC590
	public ClipCaps get_clipCaps() { }

	// RVA: 0xFFFFFFFF723AE028
	internal Int32 Hash() { }

	// RVA: 0xFFFFFFFF723ABAF4
	public Single EvaluateMixOut(Double time) { }

	// RVA: 0xFFFFFFFF723AB9EC
	public Single EvaluateMixIn(Double time) { }

	// RVA: 0xFFFFFFFF75BCF72C
	private static AnimationCurve GetDefaultMixInCurve() { }

	// RVA: 0xFFFFFFFF75BCF800
	private static AnimationCurve GetDefaultMixOutCurve() { }

	// RVA: 0xFFFFFFFF723ABC20
	public Double ToLocalTime(Double time) { }

	// RVA: 0xFFFFFFFF75BCF978
	public AnimationClip get_animationClip() { }

	// RVA: 0xFFFFFFFF75BCF334
	private static Double SanitizeTimeValue(Double value, Double defaultValue) { }

	// RVA: 0xFFFFFFFF75BCA430
	public ClipExtrapolation get_postExtrapolationMode() { }

	// RVA: 0xFFFFFFFF75BC3114
	internal Void set_postExtrapolationMode(ClipExtrapolation value) { }

	// RVA: 0xFFFFFFFF75BCF9C8
	public ClipExtrapolation get_preExtrapolationMode() { }

	// RVA: 0xFFFFFFFF75BC30DC
	internal Void set_preExtrapolationMode(ClipExtrapolation value) { }

	// RVA: 0xFFFFFFFF75BCF9F8
	internal Void SetPostExtrapolationTime(Double time) { }

	// RVA: 0xFFFFFFFF75BCFA00
	internal Void SetPreExtrapolationTime(Double time) { }

	// RVA: 0xFFFFFFFF75BCBEC4
	public Boolean IsPreExtrapolatedTime(Double sequenceTime) { }

	// RVA: 0xFFFFFFFF75BCBF20
	public Boolean IsPostExtrapolatedTime(Double sequenceTime) { }

	// RVA: 0xFFFFFFFF75BCBDC4
	public Double get_extrapolatedStart() { }

	// RVA: 0xFFFFFFFF723AB310
	public Double get_extrapolatedDuration() { }

	// RVA: 0xFFFFFFFF75BCF898
	private static Double GetExtrapolatedTime(Double time, ClipExtrapolation mode, Double duration) { }

	// RVA: 0xFFFFFFFF75BCFA08
	private Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0xFFFFFFFF723AE0A8
	private Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0xFFFFFFFF75BCFA14
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75BCF330
	private Void UpdateDirty(Double oldValue, Double newValue) { }

	// RVA: 0xFFFFFFFF75BCFB74
	private static Void .cctor() { }

}

// Namespace: 
private static class TimelineClipUpgrade
{
	// Methods

	// RVA: 0xFFFFFFFF75BCF218
	public static Void UpgradeClipInFromGlobalToLocal(TimelineClip clip) { }

}

// Namespace: 
public enum ClipExtrapolation
{
	// Fields
	public Int32 value__; // 0x10
	public const ClipExtrapolation None = 0;
	public const ClipExtrapolation Hold = 1;
	public const ClipExtrapolation Loop = 2;
	public const ClipExtrapolation PingPong = 3;
	public const ClipExtrapolation Continue = 4;
}

// Namespace: 
public enum BlendCurveMode
{
	// Fields
	public Int32 value__; // 0x10
	public const BlendCurveMode Auto = 0;
	public const BlendCurveMode Manual = 1;
}

// Namespace: UnityEngine.Timeline
public class TimelineAsset
{
	// Fields
	private const Int32 k_LatestVersion = 0;
	private Int32 m_Version; // 0x18
	private List<T0> m_Tracks; // 0x20
	private Double m_FixedDuration; // 0x28
	private TrackAsset[] m_CacheOutputTracks; // 0x30
	private List<T0> m_CacheRootTracks; // 0x38
	private TrackAsset[] m_CacheFlattenedTracks; // 0x40
	private EditorSettings m_EditorSettings; // 0x48
	private DurationMode m_DurationMode; // 0x50
	private MarkerTrack m_MarkerTrack; // 0x58

	// Properties
	public EditorSettings editorSettings { get; }
	public override Double duration { get; }
	public Double fixedDuration { get; set; }
	public DurationMode durationMode { get; set; }
	public override IEnumerable<T0> outputs { get; }
	public ClipCaps clipCaps { get; }
	public Int32 outputTrackCount { get; }
	public Int32 rootTrackCount { get; }
	internal TrackAsset[] flattenedTracks { get; }
	public MarkerTrack markerTrack { get; }
	internal List<T0> trackObjects { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BCCF00
	private Void UpgradeToLatestVersion() { }

	// RVA: 0xFFFFFFFF75BCCF04
	public EditorSettings get_editorSettings() { }

	// RVA: 0xFFFFFFFF723AC100
	public override Double get_duration() { }

	// RVA: 0xFFFFFFFF75BCCF0C
	public Double get_fixedDuration() { }

	// RVA: 0xFFFFFFFF75BCCF98
	public Void set_fixedDuration(Double value) { }

	// RVA: 0xFFFFFFFF75BCD014
	public DurationMode get_durationMode() { }

	// RVA: 0xFFFFFFFF75BCD01C
	public Void set_durationMode(DurationMode value) { }

	// RVA: 0xFFFFFFFF75BCD024
	public override IEnumerable<T0> get_outputs() { }

	// RVA: 0xFFFFFFFF75BCD0B8
	public ClipCaps get_clipCaps() { }

	// RVA: 0xFFFFFFFF75BCD4DC
	public Int32 get_outputTrackCount() { }

	// RVA: 0xFFFFFFFF75BCD50C
	public Int32 get_rootTrackCount() { }

	// RVA: 0xFFFFFFFF75BCD53C
	private Void OnValidate() { }

	// RVA: 0xFFFFFFFF75BCD61C
	public TrackAsset GetRootTrack(Int32 index) { }

	// RVA: 0xFFFFFFFF75BCD4B8
	public IEnumerable<T0> GetRootTracks() { }

	// RVA: 0xFFFFFFFF75BCD66C
	public TrackAsset GetOutputTrack(Int32 index) { }

	// RVA: 0xFFFFFFFF75BCD6BC
	public IEnumerable<T0> GetOutputTracks() { }

	// RVA: 0xFFFFFFFF75BCD570
	private static Double GetValidFrameRate(Double frameRate) { }

	// RVA: 0xFFFFFFFF723ACAC0
	private Void UpdateRootTrackCache() { }

	// RVA: 0xFFFFFFFF723AC660
	private Void UpdateOutputTrackCache() { }

	// RVA: 0xFFFFFFFF723ACE0C
	internal TrackAsset[] get_flattenedTracks() { }

	// RVA: 0xFFFFFFFF75BCD6E0
	public MarkerTrack get_markerTrack() { }

	// RVA: 0xFFFFFFFF75BCD6E8
	internal List<T0> get_trackObjects() { }

	// RVA: 0xFFFFFFFF75BCD6F0
	internal Void AddTrackInternal(TrackAsset track) { }

	// RVA: 0xFFFFFFFF75BCD838
	internal Void RemoveTrack(TrackAsset track) { }

	// RVA: 0xFFFFFFFF723AD148
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0xFFFFFFFF75BCD9D8
	private Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0xFFFFFFFF75BCD9E0
	private Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0xFFFFFFFF723AD458
	private Void __internalAwake() { }

	// RVA: 0xFFFFFFFF75BC8E20
	public Void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0xFFFFFFFF75BCDA50
	public Void CreateMarkerTrack() { }

	// RVA: 0xFFFFFFFF75BCD7C8
	internal Void Invalidate() { }

	// RVA: 0xFFFFFFFF75BCDB68
	internal Void UpdateFixedDurationWithItemsDuration() { }

	// RVA: 0xFFFFFFFF723AC1E8
	private DiscreteTime CalculateItemsDuration() { }

	// RVA: 0xFFFFFFFF723ACEFC
	private static Void AddSubTracksRecursive(TrackAsset track, ref List<T0> allTracks) { }

	// RVA: 0xFFFFFFFF75BCDBE0
	public TrackAsset CreateTrack(Type type, TrackAsset parent, String name) { }

	// RVA: -1
	public T CreateTrack(TrackAsset parent, String trackName) { }

	// RVA: -1
	public T CreateTrack(String trackName) { }

	// RVA: -1
	public T CreateTrack() { }

	// RVA: 0xFFFFFFFF75BCE5E8
	public Boolean DeleteClip(TimelineClip clip) { }

	// RVA: 0xFFFFFFFF75BCE838
	public Boolean DeleteTrack(TrackAsset track) { }

	// RVA: 0xFFFFFFFF75BCECE8
	internal Void MoveLastTrackBefore(TrackAsset asset) { }

	// RVA: 0xFFFFFFFF75BCE3E0
	private TrackAsset AllocateTrack(TrackAsset trackAssetParent, String trackName, Type trackType) { }

	// RVA: 0xFFFFFFFF75BCEC58
	private Void DeleteRecordedAnimation(TrackAsset track) { }

	// RVA: 0xFFFFFFFF75BCE718
	private Void DeleteRecordedAnimation(TimelineClip clip) { }

	// RVA: 0xFFFFFFFF75BCEF18
	public Void .ctor() { }

}

// Namespace: 
public enum DurationMode
{
	// Fields
	public Int32 value__; // 0x10
	public const DurationMode BasedOnClips = 0;
	public const DurationMode FixedLength = 1;
}

// Namespace: 
public class EditorSettings
{
	// Fields
	internal static readonly Double kMinFrameRate; // 0x0
	internal static readonly Double kMaxFrameRate; // 0x8
	internal static readonly Double kDefaultFrameRate; // 0x10
	private Double m_Framerate; // 0x10
	private Boolean m_ScenePreview; // 0x18

	// Properties
	public Double frameRate { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75BCF178
	public Double get_frameRate() { }

	// RVA: 0xFFFFFFFF75BCD5F8
	public Void set_frameRate(Double value) { }

	// RVA: 0xFFFFFFFF75BCEF74
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BCF180
	private static Void .cctor() { }

}

// Namespace: 
private sealed class <get_outputs>d__27
{
	// Fields
	private Int32 <>1__state; // 0x10
	private PlayableBinding <>2__current; // 0x18
	private Int32 <>l__initialThreadId; // 0x38
	public TimelineAsset <>4__this; // 0x40
	private IEnumerator<T0> <>7__wrap1; // 0x48
	private IEnumerator<T0> <>7__wrap2; // 0x50

	// Properties
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BCD08C
	public Void .ctor(Int32 <>1__state) { }

	// RVA: 0xFFFFFFFF75BCEFDC
	private Void System.IDisposable.Dispose() { }

	// RVA: 0xFFFFFFFF723AD7B0
	private Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF723AD71C
	private Void <>m__Finally1() { }

	// RVA: 0xFFFFFFFF723AD688
	private Void <>m__Finally2() { }

	// RVA: 0xFFFFFFFF723ADC78
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

	// RVA: 0xFFFFFFFF75BCF060
	private Void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xFFFFFFFF75BCF0B4
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xFFFFFFFF75BCF0E8
	private IEnumerator<T0> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

	// RVA: 0xFFFFFFFF75BCF174
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.Timeline
public abstract class TrackAsset
{
	// Fields
	private const Int32 k_LatestVersion = 3;
	private Int32 m_Version; // 0x18
	internal AnimationClip m_AnimClip; // 0x20
	private static TransientBuildData s_BuildData; // 0x0
	internal const String kDefaultCurvesName = "Track Parameters";
	private static Action<T0, T1, T2> OnClipPlayableCreate; // 0x18
	private static Action<T0, T1, T2> OnTrackAnimationPlayableCreate; // 0x20
	private Boolean m_Locked; // 0x28
	private Boolean m_Muted; // 0x29
	private String m_CustomPlayableFullTypename; // 0x30
	private AnimationClip m_Curves; // 0x38
	private PlayableAsset m_Parent; // 0x40
	private List<T0> m_Children; // 0x48
	private Int32 m_ItemsHash; // 0x50
	private TimelineClip[] m_ClipsCache; // 0x58
	private DiscreteTime m_Start; // 0x60
	private DiscreteTime m_End; // 0x68
	private Boolean m_CacheSorted; // 0x70
	private Nullable<T0> m_SupportsNotifications; // 0x71
	private static TrackAsset[] s_EmptyCache; // 0x28
	private IEnumerable<T0> m_ChildTrackCache; // 0x78
	private static Dictionary<T0, T1> s_TrackBindingTypeAttributeCache; // 0x30
	protected internal List<T0> m_Clips; // 0x80
	private MarkerList m_Markers; // 0x88

	// Properties
	public Double start { get; }
	public Double end { get; }
	public sealed override Double duration { get; }
	public Boolean muted { get; set; }
	public Boolean mutedInHierarchy { get; }
	public TimelineAsset timelineAsset { get; }
	public PlayableAsset parent { get; set; }
	internal TimelineClip[] clips { get; }
	public virtual Boolean isEmpty { get; }
	public Boolean hasClips { get; }
	public Boolean hasCurves { get; }
	public Boolean isSubTrack { get; }
	public override IEnumerable<T0> outputs { get; }
	internal String customPlayableTypename { get; set; }
	public AnimationClip curves { get; set; }
	private String UnityEngine.Timeline.ICurvesOwner.defaultCurvesName { get; }
	private Object UnityEngine.Timeline.ICurvesOwner.asset { get; }
	private Object UnityEngine.Timeline.ICurvesOwner.assetOwner { get; }
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack { get; }
	internal List<T0> subTracksObjects { get; }
	public Boolean locked { get; set; }
	public Boolean lockedInHierarchy { get; }
	public Boolean supportsNotifications { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BCFD44
	protected virtual Void OnBeforeTrackSerialize() { }

	// RVA: 0xFFFFFFFF723B0490
	protected virtual Void OnAfterTrackDeserialize() { }

	// RVA: 0xFFFFFFFF75BCFD48
	internal virtual Void OnUpgradeFromVersion(Int32 oldVersion) { }

	// RVA: 0xFFFFFFFF75BCFD4C
	private Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0xFFFFFFFF723B0494
	private Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0xFFFFFFFF75BCFE5C
	private Void UpgradeToLatestVersion() { }

	// RVA: 0xFFFFFFFF75BCFE88
	internal static Void add_OnClipPlayableCreate(Action<T0, T1, T2> value) { }

	// RVA: 0xFFFFFFFF75BCFF4C
	internal static Void remove_OnClipPlayableCreate(Action<T0, T1, T2> value) { }

	// RVA: 0xFFFFFFFF75BD0010
	internal static Void add_OnTrackAnimationPlayableCreate(Action<T0, T1, T2> value) { }

	// RVA: 0xFFFFFFFF75BD00D4
	internal static Void remove_OnTrackAnimationPlayableCreate(Action<T0, T1, T2> value) { }

	// RVA: 0xFFFFFFFF75BD0198
	public Double get_start() { }

	// RVA: 0xFFFFFFFF723AD618
	public Double get_end() { }

	// RVA: 0xFFFFFFFF75BD0204
	public sealed override Double get_duration() { }

	// RVA: 0xFFFFFFFF75BD027C
	public Boolean get_muted() { }

	// RVA: 0xFFFFFFFF75BD0284
	public Void set_muted(Boolean value) { }

	// RVA: 0xFFFFFFFF723AD568
	public Boolean get_mutedInHierarchy() { }

	// RVA: 0xFFFFFFFF723AA9A4
	public TimelineAsset get_timelineAsset() { }

	// RVA: 0xFFFFFFFF75BD028C
	public PlayableAsset get_parent() { }

	// RVA: 0xFFFFFFFF75BD0294
	internal Void set_parent(PlayableAsset value) { }

	// RVA: 0xFFFFFFFF723A9DA4
	public IEnumerable<T0> GetClips() { }

	// RVA: 0xFFFFFFFF723A973C
	internal TimelineClip[] get_clips() { }

	// RVA: 0xFFFFFFFF75BD02CC
	public virtual Boolean get_isEmpty() { }

	// RVA: 0xFFFFFFFF75BD0340
	public Boolean get_hasClips() { }

	// RVA: 0xFFFFFFFF723B0B98
	public Boolean get_hasCurves() { }

	// RVA: 0xFFFFFFFF723A9854
	public Boolean get_isSubTrack() { }

	// RVA: 0xFFFFFFFF723AAA7C
	public override IEnumerable<T0> get_outputs() { }

	// RVA: 0xFFFFFFFF75BC4688
	public IEnumerable<T0> GetChildTracks() { }

	// RVA: 0xFFFFFFFF75BD03C0
	internal String get_customPlayableTypename() { }

	// RVA: 0xFFFFFFFF75BD03C8
	internal Void set_customPlayableTypename(String value) { }

	// RVA: 0xFFFFFFFF75BD0400
	public AnimationClip get_curves() { }

	// RVA: 0xFFFFFFFF75BD0408
	internal Void set_curves(AnimationClip value) { }

	// RVA: 0xFFFFFFFF75BD0440
	private String UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName() { }

	// RVA: 0xFFFFFFFF75BD0480
	private Object UnityEngine.Timeline.ICurvesOwner.get_asset() { }

	// RVA: 0xFFFFFFFF75BD0484
	private Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner() { }

	// RVA: 0xFFFFFFFF75BD0488
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack() { }

	// RVA: 0xFFFFFFFF75BD048C
	internal List<T0> get_subTracksObjects() { }

	// RVA: 0xFFFFFFFF75BD0494
	public Boolean get_locked() { }

	// RVA: 0xFFFFFFFF75BD049C
	public Void set_locked(Boolean value) { }

	// RVA: 0xFFFFFFFF75BD04A4
	public Boolean get_lockedInHierarchy() { }

	// RVA: 0xFFFFFFFF723AAA30
	public Boolean get_supportsNotifications() { }

	// RVA: 0xFFFFFFFF723B0D30
	private Void __internalAwake() { }

	// RVA: 0xFFFFFFFF75BD0540
	public Void CreateCurves(String curvesClipName) { }

	// RVA: 0xFFFFFFFF723B0E00
	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, Int32 inputCount) { }

	// RVA: 0xFFFFFFFF75BD05E4
	public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0xFFFFFFFF75BD0614
	public TimelineClip CreateDefaultClip() { }

	// RVA: -1
	public TimelineClip CreateClip() { }

	// RVA: 0xFFFFFFFF75BD08B4
	public Boolean DeleteClip(TimelineClip clip) { }

	// RVA: 0xFFFFFFFF75BD0990
	public IMarker CreateMarker(Type type, Double time) { }

	// RVA: -1
	public T CreateMarker(Double time) { }

	// RVA: 0xFFFFFFFF75BD099C
	public Boolean DeleteMarker(IMarker marker) { }

	// RVA: 0xFFFFFFFF75BCFE60
	public IEnumerable<T0> GetMarkers() { }

	// RVA: 0xFFFFFFFF75BD0360
	public Int32 GetMarkerCount() { }

	// RVA: 0xFFFFFFFF75BD09A4
	public IMarker GetMarker(Int32 idx) { }

	// RVA: 0xFFFFFFFF75BD09AC
	internal TimelineClip CreateClip(Type requestedType) { }

	// RVA: 0xFFFFFFFF75BD0880
	internal TimelineClip CreateAndAddNewClipOfType(Type requestedType) { }

	// RVA: 0xFFFFFFFF75BD0CE4
	internal TimelineClip CreateClipOfType(Type requestedType) { }

	// RVA: 0xFFFFFFFF75BD111C
	internal TimelineClip CreateClipFromPlayableAsset(IPlayableAsset asset) { }

	// RVA: 0xFFFFFFFF75BD0E90
	private TimelineClip CreateClipFromAsset(ScriptableObject playableAsset) { }

	// RVA: 0xFFFFFFFF75BD15E4
	internal IEnumerable<T0> GetMarkersRaw() { }

	// RVA: 0xFFFFFFFF75BD15EC
	internal Void ClearMarkers() { }

	// RVA: 0xFFFFFFFF75BD15F4
	internal Void AddMarker(ScriptableObject e) { }

	// RVA: 0xFFFFFFFF75BD15FC
	internal Boolean DeleteMarkerRaw(ScriptableObject marker) { }

	// RVA: 0xFFFFFFFF723B0EEC
	private Int32 GetTimeRangeHash() { }

	// RVA: 0xFFFFFFFF75BCF538
	internal Void AddClip(TimelineClip newClip) { }

	// RVA: 0xFFFFFFFF723B116C
	private Playable CreateNotificationsPlayable(PlayableGraph graph, Playable mixerPlayable, GameObject go, Playable timelinePlayable) { }

	// RVA: 0xFFFFFFFF723AF7E4
	internal Playable CreatePlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<T0> tree, Playable timelinePlayable) { }

	// RVA: 0xFFFFFFFF723B1A1C
	internal virtual Playable CompileClips(PlayableGraph graph, GameObject go, IList<T0> timelineClips, IntervalTree<T0> tree) { }

	// RVA: 0xFFFFFFFF723B2044
	private Void GatherCompilableTracks(IList<T0> tracks) { }

	// RVA: 0xFFFFFFFF723B1454
	private Void GatherNotifications(List<T0> markers) { }

	// RVA: 0xFFFFFFFF723B22FC
	internal virtual Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<T0> tree) { }

	// RVA: 0xFFFFFFFF723B1F18
	internal Void ConfigureTrackAnimation(IntervalTree<T0> tree, GameObject go, Playable blend) { }

	// RVA: 0xFFFFFFFF723AE994
	internal Void SortClips() { }

	// RVA: 0xFFFFFFFF75BD163C
	internal Void ClearClipsInternal() { }

	// RVA: 0xFFFFFFFF75BD16B8
	internal Void ClearSubTracksInternal() { }

	// RVA: 0xFFFFFFFF75BCF448
	internal Void OnClipMove() { }

	// RVA: 0xFFFFFFFF75BD1330
	internal TimelineClip CreateNewClipContainerInternal() { }

	// RVA: 0xFFFFFFFF75BCEE7C
	internal Void AddChild(TrackAsset child) { }

	// RVA: 0xFFFFFFFF75BD1718
	internal Void MoveLastTrackBefore(TrackAsset asset) { }

	// RVA: 0xFFFFFFFF75BCD944
	internal Boolean RemoveSubTrack(TrackAsset child) { }

	// RVA: 0xFFFFFFFF75BCE7B4
	internal Void RemoveClip(TimelineClip clip) { }

	// RVA: 0xFFFFFFFF723A9AD8
	internal virtual Void GetEvaluationTime(out Double outStart, out Double outDuration) { }

	// RVA: 0xFFFFFFFF723A9D94
	internal virtual Void GetSequenceTime(out Double outStart, out Double outDuration) { }

	// RVA: 0xFFFFFFFF75BD18D4
	public virtual Void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0xFFFFFFFF75BD1E44
	internal GameObject GetGameObjectBinding(PlayableDirector director) { }

	// RVA: 0xFFFFFFFF75BD0ADC
	internal Boolean ValidateClipType(Type clipType) { }

	// RVA: 0xFFFFFFFF75BD1EDC
	protected virtual Void OnCreateClip(TimelineClip clip) { }

	// RVA: 0xFFFFFFFF723B09D8
	private Void UpdateDuration() { }

	// RVA: 0xFFFFFFFF723A99B8
	protected internal virtual Int32 CalculateItemsHash() { }

	// RVA: 0xFFFFFFFF723B29B0
	protected virtual Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip) { }

	// RVA: 0xFFFFFFFF723B0898
	internal Void Invalidate() { }

	// RVA: 0xFFFFFFFF75BC4F38
	internal Double GetNotificationDuration() { }

	// RVA: 0xFFFFFFFF723B2C84
	internal virtual Boolean CanCompileClips() { }

	// RVA: 0xFFFFFFFF723B2CD8
	public virtual Boolean CanCreateTrackMixer() { }

	// RVA: 0xFFFFFFFF723AE5B0
	internal Boolean IsCompilable() { }

	// RVA: 0xFFFFFFFF723B0BD0
	private Void UpdateChildTrackCache() { }

	// RVA: 0xFFFFFFFF75BD1EE0
	internal virtual Int32 Hash() { }

	// RVA: 0xFFFFFFFF723B2774
	private Int32 GetClipsHash() { }

	// RVA: 0xFFFFFFFF723A9908
	protected static Int32 GetAnimationClipHash(AnimationClip clip) { }

	// RVA: 0xFFFFFFFF75BD18AC
	private Boolean HasNotifications() { }

	// RVA: 0xFFFFFFFF75BD1604
	private Boolean CanCompileNotifications() { }

	// RVA: 0xFFFFFFFF723B16EC
	private Boolean CanCreateMixerRecursive() { }

	// RVA: 0xFFFFFFFF723A9DA8
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF75BD1F28
	private static Void .cctor() { }

}

// Namespace: 
private struct TransientBuildData
{
	// Fields
	public List<T0> trackList; // 0x10
	public List<T0> clipList; // 0x18
	public List<T0> markerList; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75BD2000
	public static TransientBuildData Create() { }

	// RVA: 0xFFFFFFFF71149838
	public Void Clear() { }

}

// Namespace: 
private sealed class <get_outputs>d__65
{
	// Fields
	private Int32 <>1__state; // 0x10
	private PlayableBinding <>2__current; // 0x18
	private Int32 <>l__initialThreadId; // 0x38
	public TrackAsset <>4__this; // 0x40

	// Properties
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BD0394
	public Void .ctor(Int32 <>1__state) { }

	// RVA: 0xFFFFFFFF723B2D88
	private Void System.IDisposable.Dispose() { }

	// RVA: 0xFFFFFFFF723B2D8C
	private Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF723B300C
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

	// RVA: 0xFFFFFFFF75BD2134
	private Void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xFFFFFFFF75BD2188
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xFFFFFFFF723B301C
	private IEnumerator<T0> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

	// RVA: 0xFFFFFFFF75BD21BC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
private sealed class <>c
{
	// Fields
	public static readonly <>c <>9; // 0x0
	public static Comparison<T0> <>9__121_0; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75BD20E8
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75BD2130
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF723B2CE8
	internal Int32 <SortClips>b__121_0(TimelineClip clip1, TimelineClip clip2) { }

}

// Namespace: UnityEngine.Timeline
public class TrackColorAttribute
{
	// Fields
	private Color m_Color; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75BD22AC
	public Void .ctor(Single r, Single g, Single b) { }

}

// Namespace: UnityEngine.Timeline
public enum ClipCaps
{
	// Fields
	public Int32 value__; // 0x10
	public const ClipCaps None = 0;
	public const ClipCaps Looping = 1;
	public const ClipCaps Extrapolation = 2;
	public const ClipCaps ClipIn = 4;
	public const ClipCaps SpeedMultiplier = 8;
	public const ClipCaps Blending = 16;
	public const ClipCaps AutoScale = 40;
	public const ClipCaps All = 4294967295;
}

// Namespace: UnityEngine.Timeline
internal static class TimelineClipCapsExtensions
{
	// Methods

	// RVA: 0xFFFFFFFF75BCA2F8
	public static Boolean SupportsExtrapolation(TimelineClip clip) { }

	// RVA: 0xFFFFFFFF75BCF31C
	public static Boolean HasAny(ClipCaps caps, ClipCaps flags) { }

}

// Namespace: UnityEngine.Timeline
public class ControlPlayableAsset
{
	// Fields
	private const Int32 k_MaxRandInt = 10000;
	private static readonly List<T0> k_EmptyDirectorsList; // 0x0
	private static readonly List<T0> k_EmptyParticlesList; // 0x8
	private static readonly HashSet<T0> s_SubEmitterCollector; // 0x10
	public ExposedReference<T0> sourceGameObject; // 0x18
	public GameObject prefabGameObject; // 0x28
	public Boolean updateParticle; // 0x30
	public UInt32 particleRandomSeed; // 0x34
	public Boolean updateDirector; // 0x38
	public Boolean updateITimeControl; // 0x39
	public Boolean searchHierarchy; // 0x3A
	public Boolean active; // 0x3B
	public PostPlaybackState postPlayback; // 0x3C
	private PlayableAsset m_ControlDirectorAsset; // 0x40
	private Double m_Duration; // 0x48
	private Boolean m_SupportLoop; // 0x50
	private static HashSet<T0> s_ProcessedDirectors; // 0x18
	private static HashSet<T0> s_CreatedPrefabs; // 0x20
	private Boolean <controllingDirectors>k__BackingField; // 0x51
	private Boolean <controllingParticles>k__BackingField; // 0x52

	// Properties
	internal Boolean controllingDirectors { get; set; }
	public Boolean controllingParticles { get; set; }
	public override Double duration { get; }
	public ClipCaps clipCaps { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BC5A2C
	internal Boolean get_controllingDirectors() { }

	// RVA: 0xFFFFFFFF75BC5A34
	private Void set_controllingDirectors(Boolean value) { }

	// RVA: 0xFFFFFFFF75BC5A3C
	public Boolean get_controllingParticles() { }

	// RVA: 0xFFFFFFFF75BC5A44
	protected Void set_controllingParticles(Boolean value) { }

	// RVA: 0xFFFFFFFF75BC5A4C
	public virtual Void OnEnable() { }

	// RVA: 0xFFFFFFFF75BC5A84
	public override Double get_duration() { }

	// RVA: 0xFFFFFFFF75BC5A8C
	public ClipCaps get_clipCaps() { }

	// RVA: 0xFFFFFFFF75BC5AA0
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0xFFFFFFFF75BC73C0
	private static Playable ConnectPlayablesToMixer(PlayableGraph graph, List<T0> playables) { }

	// RVA: 0xFFFFFFFF75BC6B70
	private Void CreateActivationPlayable(GameObject root, PlayableGraph graph, List<T0> outplayables) { }

	// RVA: 0xFFFFFFFF75BC75D4
	protected virtual Void SearchHierarchyAndConnectParticleSystem(IEnumerable<T0> particleSystems, PlayableGraph graph, List<T0> outplayables) { }

	// RVA: 0xFFFFFFFF75BC6C84
	private Void SearchHierarchyAndConnectDirector(IEnumerable<T0> directors, PlayableGraph graph, List<T0> outplayables, Boolean disableSelfReferences) { }

	// RVA: 0xFFFFFFFF75BC7084
	private static Void SearchHierarchyAndConnectControlableScripts(IEnumerable<T0> controlableScripts, PlayableGraph graph, List<T0> outplayables) { }

	// RVA: 0xFFFFFFFF75BC7554
	private static Void ConnectMixerAndPlayable(PlayableGraph graph, Playable mixer, Playable playable, Int32 portIndex) { }

	// RVA: -1
	internal IList<T0> GetComponent(GameObject gameObject) { }

	// RVA: 0xFFFFFFFF75BC6FFC
	internal static IEnumerable<T0> GetControlableScripts(GameObject root) { }

	// RVA: 0xFFFFFFFF75BC6354
	internal Void UpdateDurationAndLoopFlag(IList<T0> directors, IList<T0> particleSystems) { }

	// RVA: 0xFFFFFFFF75BC6240
	private IList<T0> GetControllableParticleSystems(GameObject go) { }

	// RVA: 0xFFFFFFFF75BC7CAC
	private static Void GetControllableParticleSystems(Transform t, ICollection<T0> roots, HashSet<T0> subEmitters) { }

	// RVA: 0xFFFFFFFF75BC7E68
	private static Void CacheSubEmitters(ParticleSystem ps, HashSet<T0> subEmitters) { }

	// RVA: 0xFFFFFFFF75BC7F30
	public Void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0xFFFFFFFF75BC814C
	internal static Void PreviewParticles(IPropertyCollector driver, IEnumerable<T0> particles) { }

	// RVA: 0xFFFFFFFF75BC8508
	internal static Void PreviewActivation(IPropertyCollector driver, IEnumerable<T0> objects) { }

	// RVA: 0xFFFFFFFF75BC87EC
	internal static Void PreviewTimeControl(IPropertyCollector driver, PlayableDirector director, IEnumerable<T0> scripts) { }

	// RVA: 0xFFFFFFFF75BC8B7C
	internal static Void PreviewDirectors(IPropertyCollector driver, IEnumerable<T0> directors) { }

	// RVA: 0xFFFFFFFF75BC9078
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BC90E4
	private static Void .cctor() { }

}

// Namespace: 
private sealed class <GetControlableScripts>d__39
{
	// Fields
	private Int32 <>1__state; // 0x10
	private MonoBehaviour <>2__current; // 0x18
	private Int32 <>l__initialThreadId; // 0x20
	private GameObject root; // 0x28
	public GameObject <>3__root; // 0x30
	private MonoBehaviour[] <>7__wrap1; // 0x38
	private Int32 <>7__wrap2; // 0x40

	// Properties
	private MonoBehaviour System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour>.Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BC7C2C
	public Void .ctor(Int32 <>1__state) { }

	// RVA: 0xFFFFFFFF75BC92A0
	private Void System.IDisposable.Dispose() { }

	// RVA: 0xFFFFFFFF75BC92A4
	private Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75BC93F0
	private MonoBehaviour System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour>.get_Current() { }

	// RVA: 0xFFFFFFFF75BC93F8
	private Void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xFFFFFFFF75BC944C
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xFFFFFFFF75BC9454
	private IEnumerator<T0> System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour>.GetEnumerator() { }

	// RVA: 0xFFFFFFFF75BC9500
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.Timeline
public class ControlTrack
{
	// Methods

	// RVA: 0xFFFFFFFF75BC9504
	public Void .ctor() { }

}

// Namespace: UnityEngine.Timeline
internal struct DiscreteTime
{
	// Fields
	private const Double k_Tick = 4427486594234968593;
	public static readonly DiscreteTime kMaxTime; // 0x0
	private readonly Int64 m_DiscreteTime; // 0x10

	// Properties
	public static Double tickValue { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BCA090
	public static Double get_tickValue() { }

	// RVA: 0xFFFFFFFF7114958C
	private Void .ctor(Int64 time) { }

	// RVA: 0xFFFFFFFF71149594
	public Void .ctor(Double time) { }

	// RVA: 0xFFFFFFFF7114959C
	public Void .ctor(Int32 time) { }

	// RVA: 0xFFFFFFFF711495A4
	public DiscreteTime OneTickBefore() { }

	// RVA: 0xFFFFFFFF711495B0
	public DiscreteTime OneTickAfter() { }

	// RVA: 0xFFFFFFFF75BCA154
	public static DiscreteTime FromTicks(Int64 ticks) { }

	// RVA: 0xFFFFFFFF711495BC
	public Int32 CompareTo(Object obj) { }

	// RVA: 0xFFFFFFFF711495C4
	public Boolean Equals(DiscreteTime other) { }

	// RVA: 0xFFFFFFFF711495D4
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF723AA08C
	private static Int64 DoubleToDiscreteTime(Double time) { }

	// RVA: 0xFFFFFFFF723AA11C
	private static Int64 IntToDiscreteTime(Int32 time) { }

	// RVA: 0xFFFFFFFF75BCA224
	private static Double ToDouble(Int64 time) { }

	// RVA: 0xFFFFFFFF75BC7C64
	public static Double op_Explicit(DiscreteTime b) { }

	// RVA: 0xFFFFFFFF723A9FCC
	public static DiscreteTime op_Explicit(Double time) { }

	// RVA: 0xFFFFFFFF723AA1DC
	public static DiscreteTime op_Implicit(Int32 time) { }

	// RVA: 0xFFFFFFFF75BCA238
	public static Boolean op_Equality(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0xFFFFFFFF75BCA244
	public static Boolean op_Inequality(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0xFFFFFFFF75BCA288
	public static Boolean op_LessThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0xFFFFFFFF75BCA294
	public static Boolean op_GreaterThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0xFFFFFFFF75BCA2A0
	public static DiscreteTime op_Subtraction(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0xFFFFFFFF71149630
	public override String ToString() { }

	// RVA: 0xFFFFFFFF7114965C
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF723AA2C0
	public static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0xFFFFFFFF723AA30C
	public static Int64 GetNearestTick(Double time) { }

	// RVA: 0xFFFFFFFF75BCA2E0
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Timeline
internal class InfiniteRuntimeClip
{
	// Fields
	private Playable m_Playable; // 0x18
	private static readonly Int64 kIntervalEnd; // 0x0

	// Properties
	public override Int64 intervalStart { get; }
	public override Int64 intervalEnd { get; }
	public override Boolean enable { set; }

	// Methods

	// RVA: 0xFFFFFFFF75BC4DDC
	public Void .ctor(Playable playable) { }

	// RVA: 0xFFFFFFFF75BCA71C
	public override Int64 get_intervalStart() { }

	// RVA: 0xFFFFFFFF75BCA724
	public override Int64 get_intervalEnd() { }

	// RVA: 0xFFFFFFFF75BCA764
	public override Void set_enable(Boolean value) { }

	// RVA: 0xFFFFFFFF75BCA790
	public override Void EvaluateAt(Double localTime, FrameData frameData) { }

	// RVA: 0xFFFFFFFF75BCA7A4
	public override Void DisableAt(Double localTime, Double rootDuration, FrameData frameData) { }

	// RVA: 0xFFFFFFFF75BCA7E8
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Timeline
internal interface IInterval
{
	// Properties
	public abstract Int64 intervalStart { get; }
	public abstract Int64 intervalEnd { get; }

	// Methods

	// RVA: -1
	public abstract Int64 get_intervalStart() { }

	// RVA: -1
	public abstract Int64 get_intervalEnd() { }

}

// Namespace: UnityEngine.Timeline
internal struct IntervalTreeNode
{
	// Fields
	public Int64 center; // 0x10
	public Int32 first; // 0x18
	public Int32 last; // 0x1C
	public Int32 left; // 0x20
	public Int32 right; // 0x24
}

// Namespace: UnityEngine.Timeline
internal class IntervalTree<T0>
{
	// Fields
	private readonly List<T0> m_Entries; // 0x0
	private readonly List<T0> m_Nodes; // 0x0
	private Boolean <dirty>k__BackingField; // 0x0

	// Properties
	public Boolean dirty { get; set; }

	// Methods

	// RVA: -1
	public Boolean get_dirty() { }

	// RVA: -1
	internal Void set_dirty(Boolean value) { }

	// RVA: -1
	public Void Add(T item) { }

	// RVA: -1
	public Void IntersectsWith(Int64 value, List<T0> results) { }

	// RVA: -1
	private Void Query(IntervalTreeNode intervalTreeNode, Int64 value, List<T0> results) { }

	// RVA: -1
	private Void Rebuild() { }

	// RVA: -1
	private Int32 Rebuild(Int32 start, Int32 end) { }

	// RVA: -1
	public Void .ctor() { }

}

// Namespace: 
internal struct Entry
{
	// Fields
	public Int64 intervalStart; // 0x0
	public Int64 intervalEnd; // 0x0
	public T item; // 0x0
}

// Namespace: UnityEngine.Timeline
internal class RuntimeClip
{
	// Fields
	private TimelineClip m_Clip; // 0x18
	private Playable m_Playable; // 0x20
	private Playable m_ParentMixer; // 0x30

	// Properties
	public override Double start { get; }
	public override Double duration { get; }
	public TimelineClip clip { get; }
	public Playable mixer { get; }
	public Playable playable { get; }
	public override Boolean enable { set; }

	// Methods

	// RVA: 0xFFFFFFFF723AB214
	public override Double get_start() { }

	// RVA: 0xFFFFFFFF723AB248
	public override Double get_duration() { }

	// RVA: 0xFFFFFFFF75BC362C
	public Void .ctor(TimelineClip clip, Playable clipPlayable, Playable parentMixer) { }

	// RVA: 0xFFFFFFFF75BCBDE0
	private Void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer) { }

	// RVA: 0xFFFFFFFF75BCBE50
	public TimelineClip get_clip() { }

	// RVA: 0xFFFFFFFF75BCBE58
	public Playable get_mixer() { }

	// RVA: 0xFFFFFFFF75BCBE64
	public Playable get_playable() { }

	// RVA: 0xFFFFFFFF723AB3CC
	public override Void set_enable(Boolean value) { }

	// RVA: 0xFFFFFFFF75BCBE9C
	public Void SetTime(Double time) { }

	// RVA: 0xFFFFFFFF75BCBEB0
	public Void SetDuration(Double duration) { }

	// RVA: 0xFFFFFFFF723AB638
	public override Void EvaluateAt(Double localTime, FrameData frameData) { }

	// RVA: 0xFFFFFFFF723ABD2C
	public override Void DisableAt(Double localTime, Double rootDuration, FrameData frameData) { }

}

// Namespace: UnityEngine.Timeline
internal abstract class RuntimeClipBase
{
	// Properties
	public abstract Double start { get; }
	public abstract Double duration { get; }
	public override Int64 intervalStart { get; }
	public override Int64 intervalEnd { get; }

	// Methods

	// RVA: -1
	public abstract Double get_start() { }

	// RVA: -1
	public abstract Double get_duration() { }

	// RVA: 0xFFFFFFFF723ABF00
	public override Int64 get_intervalStart() { }

	// RVA: 0xFFFFFFFF723ABFEC
	public override Int64 get_intervalEnd() { }

	// RVA: 0xFFFFFFFF75BCBDDC
	protected Void .ctor() { }

}

// Namespace: UnityEngine.Timeline
internal abstract class RuntimeElement
{
	// Fields
	private Int32 <intervalBit>k__BackingField; // 0x10

	// Properties
	public abstract Int64 intervalStart { get; }
	public abstract Int64 intervalEnd { get; }
	public Int32 intervalBit { get; set; }
	public abstract Boolean enable { set; }

	// Methods

	// RVA: -1
	public abstract Int64 get_intervalStart() { }

	// RVA: -1
	public abstract Int64 get_intervalEnd() { }

	// RVA: 0xFFFFFFFF75BCBF84
	public Int32 get_intervalBit() { }

	// RVA: 0xFFFFFFFF75BCBF8C
	public Void set_intervalBit(Int32 value) { }

	// RVA: -1
	public abstract Void set_enable(Boolean value) { }

	// RVA: -1
	public abstract Void EvaluateAt(Double localTime, FrameData frameData) { }

	// RVA: -1
	public abstract Void DisableAt(Double localTime, Double rootDuration, FrameData frameData) { }

	// RVA: 0xFFFFFFFF75BCA718
	protected Void .ctor() { }

}

// Namespace: UnityEngine.Timeline
public interface IMarker
{
	// Properties
	public abstract Double time { get; set; }
	public abstract TrackAsset parent { get; }

	// Methods

	// RVA: -1
	public abstract Double get_time() { }

	// RVA: -1
	public abstract Void set_time(Double value) { }

	// RVA: -1
	public abstract TrackAsset get_parent() { }

	// RVA: -1
	public abstract Void Initialize(TrackAsset parent) { }

}

// Namespace: UnityEngine.Timeline
public interface INotificationOptionProvider
{
	// Properties
	public abstract NotificationFlags flags { get; }

	// Methods

	// RVA: -1
	public abstract NotificationFlags get_flags() { }

}

// Namespace: UnityEngine.Timeline
internal struct MarkerList
{
	// Fields
	private List<T0> m_Objects; // 0x10
	private List<T0> m_Cache; // 0x18
	private Boolean m_CacheDirty; // 0x20
	private Boolean m_HasNotifications; // 0x21

	// Properties
	public List<T0> markers { get; }
	public Int32 Count { get; }
	public IMarker Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF711496A4
	public List<T0> get_markers() { }

	// RVA: 0xFFFFFFFF711496CC
	public Void .ctor(Int32 capacity) { }

	// RVA: 0xFFFFFFFF711496D4
	public Void Add(ScriptableObject item) { }

	// RVA: 0xFFFFFFFF711496DC
	public Boolean Remove(IMarker item) { }

	// RVA: 0xFFFFFFFF711496E4
	public Boolean Remove(ScriptableObject item, TimelineAsset timelineAsset, PlayableAsset thingToDirty) { }

	// RVA: 0xFFFFFFFF711496EC
	public Void Clear() { }

	// RVA: 0xFFFFFFFF711496F4
	public IEnumerable<T0> GetMarkers() { }

	// RVA: 0xFFFFFFFF7114971C
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF71149750
	public IMarker get_Item(Int32 idx) { }

	// RVA: 0xFFFFFFFF71149758
	public List<T0> GetRawMarkerList() { }

	// RVA: 0xFFFFFFFF71149760
	public IMarker CreateMarker(Type type, Double time, TrackAsset owner) { }

	// RVA: 0xFFFFFFFF71149768
	public Boolean HasNotifications() { }

	// RVA: 0xFFFFFFFF71149790
	private Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0xFFFFFFFF70C5A7F4
	private Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0xFFFFFFFF71149794
	private Void BuildCache() { }

}

// Namespace: UnityEngine.Timeline
public class MarkerTrack
{
	// Properties
	public override IEnumerable<T0> outputs { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BCB05C
	public override IEnumerable<T0> get_outputs() { }

	// RVA: 0xFFFFFFFF75BCB1AC
	public Void .ctor() { }

}

// Namespace: UnityEngine.Timeline
public class GroupTrack
{
	// Properties
	public override IEnumerable<T0> outputs { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BCA574
	internal override Boolean CanCompileClips() { }

	// RVA: 0xFFFFFFFF75BCA57C
	public override IEnumerable<T0> get_outputs() { }

	// RVA: 0xFFFFFFFF75BCA5BC
	public Void .ctor() { }

}

// Namespace: UnityEngine.Timeline
public interface ILayerable
{
	// Methods

	// RVA: -1
	public abstract Playable CreateLayerMixer(PlayableGraph graph, GameObject go, Int32 inputCount) { }

}

// Namespace: UnityEngine.Timeline
public class ActivationControlPlayable
{
	// Fields
	public GameObject gameObject; // 0x10
	public PostPlaybackState postPlayback; // 0x18
	private InitialState m_InitialState; // 0x1C

	// Methods

	// RVA: 0xFFFFFFFF75BC0890
	public static ScriptPlayable<T0> Create(PlayableGraph graph, GameObject gameObject, PostPlaybackState postPlaybackState) { }

	// RVA: 0xFFFFFFFF75BC09C4
	public override Void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75BC09E4
	public override Void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75BC0A40
	public override Void ProcessFrame(Playable playable, FrameData info, Object userData) { }

	// RVA: 0xFFFFFFFF75BC0A60
	public override Void OnGraphStart(Playable playable) { }

	// RVA: 0xFFFFFFFF75BC0AAC
	public override Void OnPlayableDestroy(Playable playable) { }

	// RVA: 0xFFFFFFFF75BC0B04
	public Void .ctor() { }

}

// Namespace: 
public enum PostPlaybackState
{
	// Fields
	public Int32 value__; // 0x10
	public const PostPlaybackState Active = 0;
	public const PostPlaybackState Inactive = 1;
	public const PostPlaybackState Revert = 2;
}

// Namespace: 
private enum InitialState
{
	// Fields
	public Int32 value__; // 0x10
	public const InitialState Unset = 0;
	public const InitialState Active = 1;
	public const InitialState Inactive = 2;
}

// Namespace: UnityEngine.Timeline
public class DirectorControlPlayable
{
	// Fields
	public PlayableDirector director; // 0x10
	private Boolean m_SyncTime; // 0x18
	private Double m_AssetDuration; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75BC7A00
	public static ScriptPlayable<T0> Create(PlayableGraph graph, PlayableDirector director) { }

	// RVA: 0xFFFFFFFF75BC95EC
	public override Void OnPlayableDestroy(Playable playable) { }

	// RVA: 0xFFFFFFFF75BC9640
	public override Void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75BC9BB0
	public override Void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75BC9C20
	public override Void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75BC9CA0
	public override Void ProcessFrame(Playable playable, FrameData info, Object playerData) { }

	// RVA: 0xFFFFFFFF75BC98C8
	private Void SyncSpeed(Double speed) { }

	// RVA: 0xFFFFFFFF75BC99E0
	private Void SyncStart(PlayableGraph graph, Double time) { }

	// RVA: 0xFFFFFFFF75BC9A98
	private Void SyncStop(PlayableGraph graph, Double time) { }

	// RVA: 0xFFFFFFFF75BC97DC
	private Boolean DetectDiscontinuity(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75BC9DA8
	private Boolean DetectOutOfSync(Playable playable) { }

	// RVA: 0xFFFFFFFF75BC9EBC
	private Void UpdateTime(Playable playable) { }

	// RVA: 0xFFFFFFFF75BCA09C
	public Void .ctor() { }

}

// Namespace: UnityEngine.Timeline
public interface ITimeControl
{
	// Methods

	// RVA: -1
	public abstract Void SetTime(Double time) { }

	// RVA: -1
	public abstract Void OnControlTimeStart() { }

	// RVA: -1
	public abstract Void OnControlTimeStop() { }

}

// Namespace: UnityEngine.Timeline
public enum NotificationFlags
{
	// Fields
	public Int16 value__; // 0x10
	public const NotificationFlags TriggerInEditMode = 1;
	public const NotificationFlags Retroactive = 2;
	public const NotificationFlags TriggerOnce = 4;
}

// Namespace: UnityEngine.Timeline
public class ParticleControlPlayable
{
	// Fields
	private Single m_LastPlayableTime; // 0x10
	private Single m_LastParticleTime; // 0x14
	private UInt32 m_RandomSeed; // 0x18
	private ParticleSystem <particleSystem>k__BackingField; // 0x20

	// Properties
	public ParticleSystem particleSystem { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75BC78E4
	public static ScriptPlayable<T0> Create(PlayableGraph graph, ParticleSystem component, UInt32 randomSeed) { }

	// RVA: 0xFFFFFFFF75BCB448
	public ParticleSystem get_particleSystem() { }

	// RVA: 0xFFFFFFFF75BCB450
	private Void set_particleSystem(ParticleSystem value) { }

	// RVA: 0xFFFFFFFF75BCB3C8
	public Void Initialize(ParticleSystem ps, UInt32 randomSeed) { }

	// RVA: 0xFFFFFFFF75BCB488
	private static Void SetRandomSeed(ParticleSystem particleSystem, UInt32 randomSeed) { }

	// RVA: 0xFFFFFFFF75BCB584
	public override Void PrepareFrame(Playable playable, FrameData data) { }

	// RVA: 0xFFFFFFFF75BCB76C
	public override Void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75BCB778
	public override Void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75BCB6A4
	private Void Simulate(Single time, Boolean restart) { }

	// RVA: 0xFFFFFFFF75BCB784
	public Void .ctor() { }

}

// Namespace: UnityEngine.Timeline
public class PrefabControlPlayable
{
	// Fields
	private GameObject m_Instance; // 0x10

	// Properties
	public GameObject prefabInstance { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BC6124
	public static ScriptPlayable<T0> Create(PlayableGraph graph, GameObject prefabGameObject, Transform parentTransform) { }

	// RVA: 0xFFFFFFFF75BCBA48
	public GameObject get_prefabInstance() { }

	// RVA: 0xFFFFFFFF75BCB844
	public GameObject Initialize(GameObject prefabGameObject, Transform parentTransform) { }

	// RVA: 0xFFFFFFFF75BCBCB0
	public override Void OnPlayableDestroy(Playable playable) { }

	// RVA: 0xFFFFFFFF75BCBD44
	public override Void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75BCBD64
	public override Void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75BCBA50
	private static Void SetHideFlagsRecursive(GameObject gameObject) { }

	// RVA: 0xFFFFFFFF75BCBDC0
	public Void .ctor() { }

}

// Namespace: UnityEngine.Timeline
public class TimeControlPlayable
{
	// Fields
	private ITimeControl m_timeControl; // 0x10
	private Boolean m_started; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75BC7B20
	public static ScriptPlayable<T0> Create(PlayableGraph graph, ITimeControl timeControl) { }

	// RVA: 0xFFFFFFFF75BCBFE8
	public Void Initialize(ITimeControl timeControl) { }

	// RVA: 0xFFFFFFFF75BCC020
	public override Void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75BCC108
	public override Void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75BCC1C4
	public override Void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75BCC278
	public Void .ctor() { }

}

// Namespace: UnityEngine.Timeline
public class TimeNotificationBehaviour
{
	// Fields
	private readonly List<T0> m_Notifications; // 0x10
	private Double m_PreviousTime; // 0x18
	private Boolean m_NeedSortNotifications; // 0x20
	private Playable m_TimeSource; // 0x28

	// Properties
	public Playable timeSource { set; }

	// Methods

	// RVA: 0xFFFFFFFF75BCC27C
	public Void set_timeSource(Playable value) { }

	// RVA: 0xFFFFFFFF75BCB20C
	public static ScriptPlayable<T0> Create(PlayableGraph graph, Double duration, DirectorWrapMode loopMode) { }

	// RVA: 0xFFFFFFFF75BCB30C
	public Void AddNotification(Double time, INotification payload, NotificationFlags flags) { }

	// RVA: 0xFFFFFFFF75BCC284
	public override Void OnGraphStart(Playable playable) { }

	// RVA: 0xFFFFFFFF75BCC528
	public override Void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75BCC794
	public override Void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF75BCC3FC
	private Void SortNotifications() { }

	// RVA: 0xFFFFFFFF75BCCD88
	private static Boolean CanRestoreNotification(NotificationEntry e, FrameData info, Double currentTime, Double previousTime) { }

	// RVA: 0xFFFFFFFF75BCCB5C
	private Void TriggerNotificationsInRange(Double start, Double end, FrameData info, Playable playable, Boolean checkState) { }

	// RVA: 0xFFFFFFFF75BCCA98
	private Void SyncDurationWithExternalSource(Playable playable) { }

	// RVA: 0xFFFFFFFF75BCC70C
	private static Void Trigger_internal(Playable playable, PlayableOutput output, ref NotificationEntry e) { }

	// RVA: 0xFFFFFFFF75BCCDC0
	private static Void Restore_internal(ref NotificationEntry e) { }

	// RVA: 0xFFFFFFFF75BCCDE0
	public Void .ctor() { }

}

// Namespace: 
private struct NotificationEntry
{
	// Fields
	public Double time; // 0x10
	public INotification payload; // 0x18
	public Boolean notificationFired; // 0x20
	public NotificationFlags flags; // 0x22

	// Properties
	public Boolean triggerInEditor { get; }
	public Boolean prewarm { get; }
	public Boolean triggerOnce { get; }

	// Methods

	// RVA: 0xFFFFFFFF711497D8
	public Boolean get_triggerInEditor() { }

	// RVA: 0xFFFFFFFF711497E4
	public Boolean get_prewarm() { }

	// RVA: 0xFFFFFFFF711497F0
	public Boolean get_triggerOnce() { }

}

// Namespace: 
private sealed class <>c
{
	// Fields
	public static readonly <>c <>9; // 0x0
	public static Comparison<T0> <>9__12_0; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75BCCE60
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75BCCEC8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BCCECC
	internal Int32 <SortNotifications>b__12_0(NotificationEntry x, NotificationEntry y) { }

}

// Namespace: UnityEngine.Timeline
public class PlayableTrack
{
	// Methods

	// RVA: 0xFFFFFFFF75BCB79C
	protected override Void OnCreateClip(TimelineClip clip) { }

	// RVA: 0xFFFFFFFF75BCB808
	public Void .ctor() { }

}

// Namespace: UnityEngine.Timeline
public class TrackClipTypeAttribute
{
	// Fields
	public readonly Type inspectedType; // 0x10
	public readonly Boolean allowAutoCreate; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75BD2214
	public Void .ctor(Type clipClass) { }

	// RVA: 0xFFFFFFFF75BD2268
	public Void .ctor(Type clipClass, Boolean allowAutoCreate) { }

}

// Namespace: UnityEngine.Timeline
public class NotKeyableAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75BCB204
	public Void .ctor() { }

}

// Namespace: UnityEngine.Timeline
public enum TrackBindingFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const TrackBindingFlags None = 0;
	public const TrackBindingFlags AllowCreateComponent = 1;
	public const TrackBindingFlags All = 1;
}

// Namespace: UnityEngine.Timeline
public class TrackBindingTypeAttribute
{
	// Fields
	public readonly Type type; // 0x10
	public readonly TrackBindingFlags flags; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75BD21C0
	public Void .ctor(Type type) { }

}

// Namespace: UnityEngine.Timeline
internal class SupportsChildTracksAttribute
{
	// Fields
	public readonly Type childType; // 0x10
	public readonly Int32 levels; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75BCBF94
	public Void .ctor(Type childType, Int32 levels) { }

}

// Namespace: UnityEngine.Timeline
internal class IgnoreOnPlayableTrackAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75BCA710
	public Void .ctor() { }

}

// Namespace: UnityEngine.Timeline
internal class FrameRateFieldAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75BCA56C
	public Void .ctor() { }

}

// Namespace: UnityEngine.Timeline
public class HideInMenuAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75BCA708
	public Void .ctor() { }

}

// Namespace: UnityEngine.Timeline
public interface ITimelineClipAsset
{
	// Properties
	public abstract ClipCaps clipCaps { get; }

	// Methods

	// RVA: -1
	public abstract ClipCaps get_clipCaps() { }

}

// Namespace: UnityEngine.Timeline
internal interface ITimelineEvaluateCallback
{
	// Methods

	// RVA: -1
	public abstract Void Evaluate() { }

}

// Namespace: UnityEngine.Timeline
public class TimelinePlayable
{
	// Fields
	private IntervalTree<T0> m_IntervalTree; // 0x10
	private List<T0> m_ActiveClips; // 0x18
	private List<T0> m_CurrentListOfActiveClips; // 0x20
	private Int32 m_ActiveBit; // 0x28
	private List<T0> m_EvaluateCallbacks; // 0x30
	private Dictionary<T0, T1> m_PlayableCache; // 0x38
	internal static Boolean muteAudioScrubbing; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF723AD2C8
	public static ScriptPlayable<T0> Create(PlayableGraph graph, IEnumerable<T0> tracks, GameObject go, Boolean autoRebalance, Boolean createOutputs) { }

	// RVA: 0xFFFFFFFF723AE0E4
	public Void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<T0> tracks, GameObject go, Boolean autoRebalance, Boolean createOutputs) { }

	// RVA: 0xFFFFFFFF723AE2DC
	private Void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<T0> tracks, GameObject go, Boolean createOutputs) { }

	// RVA: 0xFFFFFFFF723AF060
	private Void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, Int32 port) { }

	// RVA: 0xFFFFFFFF75BCFC64
	private Void EvaluateWeightsForAnimationPlayableOutput(TrackAsset track, AnimationPlayableOutput animOutput) { }

	// RVA: 0xFFFFFFFF723AEA74
	private Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, Boolean createOutputs) { }

	// RVA: 0xFFFFFFFF723AFB0C
	public override Void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0xFFFFFFFF723AFB3C
	private Void Evaluate(Playable playable, FrameData frameData) { }

	// RVA: 0xFFFFFFFF75BCFCF4
	private Void CacheTrack(TrackAsset track, Playable playable, Int32 port, Playable parent) { }

	// RVA: 0xFFFFFFFF723B0370
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BCFD2C
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Timeline
internal static class Extrapolation
{
	// Fields
	internal static readonly Double kMinExtrapolationTime; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF723AA3CC
	internal static Void CalculateExtrapolationTimes(TrackAsset asset) { }

	// RVA: 0xFFFFFFFF75BCA314
	private static TimelineClip[] SortClipsByStartTime(TimelineClip[] clips) { }

	// RVA: 0xFFFFFFFF75BCA460
	private static Void .cctor() { }

}

// Namespace: 
private sealed class <>c
{
	// Fields
	public static readonly <>c <>9; // 0x0
	public static Comparison<T0> <>9__2_0; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75BCA4C4
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75BCA52C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BCA530
	internal Int32 <SortClipsByStartTime>b__2_0(TimelineClip clip1, TimelineClip clip2) { }

}

// Namespace: UnityEngine.Timeline
internal static class HashUtility
{
	// Methods

	// RVA: 0xFFFFFFFF75BC31B4
	public static Int32 CombineHash(Int32 h1, Int32 h2) { }

	// RVA: 0xFFFFFFFF75BCA5F8
	public static Int32 CombineHash(Int32 h1, Int32 h2, Int32 h3) { }

	// RVA: 0xFFFFFFFF75BCA624
	public static Int32 CombineHash(Int32 h1, Int32 h2, Int32 h3, Int32 h4) { }

	// RVA: 0xFFFFFFFF75BCA660
	public static Int32 CombineHash(Int32 h1, Int32 h2, Int32 h3, Int32 h4, Int32 h5) { }

	// RVA: 0xFFFFFFFF75BCA6AC
	public static Int32 CombineHash(Int32 h1, Int32 h2, Int32 h3, Int32 h4, Int32 h5, Int32 h6) { }

}

// Namespace: UnityEngine.Timeline
public interface IPropertyCollector
{
	// Methods

	// RVA: -1
	public abstract Void PushActiveGameObject(GameObject gameObject) { }

	// RVA: -1
	public abstract Void PopActiveGameObject() { }

	// RVA: -1
	public abstract Void AddFromClip(AnimationClip clip) { }

	// RVA: -1
	public abstract Void AddFromName(GameObject obj, String name) { }

	// RVA: -1
	public abstract Void AddFromName(GameObject obj, String name) { }

	// RVA: -1
	public abstract Void AddFromComponent(GameObject obj, Component component) { }

	// RVA: -1
	public abstract Void AddObjectProperties(Object obj, AnimationClip clip) { }

}

// Namespace: UnityEngine.Timeline
public interface IPropertyPreview
{
	// Methods

	// RVA: -1
	public abstract Void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

}

// Namespace: UnityEngine.Timeline
internal static class NotificationUtilities
{
	// Methods

	// RVA: 0xFFFFFFFF723AAB3C
	public static ScriptPlayable<T0> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<T0> markers, Double duration, DirectorWrapMode extrapolationMode) { }

	// RVA: 0xFFFFFFFF723AB0AC
	public static Boolean TrackTypeSupportsNotifications(Type type) { }

}

// Namespace: UnityEngine.Timeline
internal static class TimeUtility
{
	// Fields
	public static readonly Double kTimeEpsilon; // 0x0
	public static readonly Double kFrameRateEpsilon; // 0x8
	public static readonly Double k_MaxTimelineDurationInSeconds; // 0x10
	public static readonly Double kFrameRateRounding; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75BC1494
	public static Double GetAnimationClipLength(AnimationClip clip) { }

	// RVA: 0xFFFFFFFF75BCCEDC
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Timeline
internal static class TimelineCreateUtilities
{
	// Methods

	// RVA: 0xFFFFFFFF75BCE084
	public static String GenerateUniqueActorName(List<T0> tracks, String name) { }

	// RVA: 0xFFFFFFFF75BCAFB4
	public static Void SaveAssetIntoObject(Object childAsset, Object masterAsset) { }

	// RVA: 0xFFFFFFFF75BC2D14
	public static AnimationClip CreateAnimationClipForTrack(String name, TrackAsset track, Boolean isLegacy) { }

	// RVA: 0xFFFFFFFF75BCDE6C
	public static Boolean ValidateParentTrack(TrackAsset parent, Type childType) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public String name; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75BCFBE4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BCFBEC
	internal Boolean <GenerateUniqueActorName>b__0(ScriptableObject x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_1
{
	// Fields
	public String result; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75BCFBE8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BCFC28
	internal Boolean <GenerateUniqueActorName>b__1(ScriptableObject x) { }

}

// Namespace: UnityEngine.Timeline
internal static class TimelineUndo
{
	// Methods

	// RVA: 0xFFFFFFFF75BCAB74
	public static Void PushDestroyUndo(TimelineAsset timeline, Object thingToDirty, Object objectToDestroy) { }

}

// Namespace: UnityEngine.Timeline
internal static class WeightUtility
{
	// Methods

	// RVA: 0xFFFFFFFF75BC0FEC
	public static Single NormalizeMixer(Playable mixer) { }

}


