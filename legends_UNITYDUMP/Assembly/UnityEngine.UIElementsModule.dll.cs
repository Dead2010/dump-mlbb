// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Yoga
internal sealed class BaselineFunction
{
	// Methods

	// RVA: 0xFFFFFFFF75C9D5C0
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75C9D5D4
	public virtual Single Invoke(YogaNode node, Single width, Single height) { }

	// RVA: 0xFFFFFFFF75C9DA04
	public virtual IAsyncResult BeginInvoke(YogaNode node, Single width, Single height, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75C9DAA8
	public virtual Single EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine.Yoga
internal sealed class MeasureFunction
{
	// Methods

	// RVA: 0xFFFFFFFF75C9DAD4
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75C9DAE8
	public virtual YogaSize Invoke(YogaNode node, Single width, YogaMeasureMode widthMode, Single height, YogaMeasureMode heightMode) { }

	// RVA: 0xFFFFFFFF75C9DF58
	public virtual IAsyncResult BeginInvoke(YogaNode node, Single width, YogaMeasureMode widthMode, Single height, YogaMeasureMode heightMode, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75C9E058
	public virtual YogaSize EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine.Yoga
internal enum YogaMeasureMode
{
	// Fields
	public Int32 value__; // 0x10
	public const YogaMeasureMode Undefined = 0;
	public const YogaMeasureMode Exactly = 1;
	public const YogaMeasureMode AtMost = 2;
}

// Namespace: UnityEngine.Yoga
internal static class Native
{
	// Methods

	// RVA: 0xFFFFFFFF75C9E084
	public static Void YGNodeMeasureInvoke(YogaNode node, Single width, YogaMeasureMode widthMode, Single height, YogaMeasureMode heightMode, IntPtr returnValueAddress) { }

	// RVA: 0xFFFFFFFF75C9E1A4
	public static Void YGNodeBaselineInvoke(YogaNode node, Single width, Single height, IntPtr returnValueAddress) { }

	// RVA: 0xFFFFFFFF75C9E294
	public static Single YGNodeLayoutGetLeft(IntPtr node) { }

	// RVA: 0xFFFFFFFF75C9E2D4
	public static Single YGNodeLayoutGetTop(IntPtr node) { }

	// RVA: 0xFFFFFFFF75C9E314
	public static Single YGNodeLayoutGetWidth(IntPtr node) { }

	// RVA: 0xFFFFFFFF75C9E354
	public static Single YGNodeLayoutGetHeight(IntPtr node) { }

}

// Namespace: UnityEngine.Yoga
internal class YogaNode
{
	// Fields
	internal IntPtr _ygNode; // 0x10
	private MeasureFunction _measureFunction; // 0x18
	private BaselineFunction _baselineFunction; // 0x20

	// Properties
	public Single LayoutX { get; }
	public Single LayoutY { get; }
	public Single LayoutWidth { get; }
	public Single LayoutHeight { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C9BE10
	public Single get_LayoutX() { }

	// RVA: 0xFFFFFFFF75C9BE50
	public Single get_LayoutY() { }

	// RVA: 0xFFFFFFFF75C9BE90
	public Single get_LayoutWidth() { }

	// RVA: 0xFFFFFFFF75C9BED0
	public Single get_LayoutHeight() { }

	// RVA: 0xFFFFFFFF75C9E0EC
	public static YogaSize MeasureInternal(YogaNode node, Single width, YogaMeasureMode widthMode, Single height, YogaMeasureMode heightMode) { }

	// RVA: 0xFFFFFFFF75C9E1F4
	public static Single BaselineInternal(YogaNode node, Single width, Single height) { }

}

// Namespace: UnityEngine.Yoga
internal struct YogaSize
{
	// Fields
	public Single width; // 0x10
	public Single height; // 0x14
}

// Namespace: UnityEngine.UIElements
internal enum DispatchMode
{
	// Fields
	public Int32 value__; // 0x10
	public const DispatchMode Default = 1;
	public const DispatchMode Queued = 1;
	public const DispatchMode Immediate = 2;
}

// Namespace: UnityEngine.UIElements
public struct EventDispatcherGate
{
	// Fields
	private readonly EventDispatcher m_Dispatcher; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF71153228
	public Void .ctor(EventDispatcher d) { }

	// RVA: 0xFFFFFFFF71153230
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF7115324C
	public Boolean Equals(EventDispatcherGate other) { }

	// RVA: 0xFFFFFFFF71153258
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF71153260
	public override Int32 GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
public sealed class EventDispatcher
{
	// Fields
	private List<T0> m_DispatchingStrategies; // 0x10
	private static readonly ObjectPool<T0> k_EventQueuePool; // 0x0
	private Queue<T0> m_Queue; // 0x18
	private readonly PointerDispatchState <pointerState>k__BackingField; // 0x20
	private UInt32 m_GateCount; // 0x28
	private Stack<T0> m_DispatchContexts; // 0x30
	private Boolean m_Immediate; // 0x38

	// Properties
	internal PointerDispatchState pointerState { get; }
	private Boolean dispatchImmediately { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C8CC28
	internal PointerDispatchState get_pointerState() { }

	// RVA: 0xFFFFFFFF75C8CC30
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75C8D090
	private Boolean get_dispatchImmediately() { }

	// RVA: 0xFFFFFFFF75C87518
	internal Void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode) { }

	// RVA: 0xFFFFFFFF75C8D3D8
	internal Void CloseGate() { }

	// RVA: 0xFFFFFFFF75C8D3E8
	internal Void OpenGate() { }

	// RVA: 0xFFFFFFFF75C8D458
	private Void ProcessEventQueue() { }

	// RVA: 0xFFFFFFFF75C8D0B0
	private Void ProcessEvent(EventBase evt, IPanel panel) { }

	// RVA: 0xFFFFFFFF75C8D7C0
	private Void ApplyDispatchingStrategies(EventBase evt, IPanel panel, Boolean imguiEventIsInitiallyUsed) { }

	// RVA: 0xFFFFFFFF75C8DA78
	private static Void .cctor() { }

}

// Namespace: 
private struct EventRecord
{
	// Fields
	public EventBase m_Event; // 0x10
	public IPanel m_Panel; // 0x18
}

// Namespace: 
private struct DispatchContext
{
	// Fields
	public UInt32 m_GateCount; // 0x10
	public Queue<T0> m_Queue; // 0x18
}

// Namespace: UnityEngine.UIElements
public abstract class Focusable
{
	// Fields
	private Boolean <focusable>k__BackingField; // 0x18
	internal Boolean isIMGUIContainer; // 0x19

	// Properties
	public abstract FocusController focusController { get; }
	public Boolean focusable { get; }
	public virtual Boolean canGrabFocus { get; }

	// Methods

	// RVA: -1
	public abstract FocusController get_focusController() { }

	// RVA: 0xFFFFFFFF75C8EB28
	public Boolean get_focusable() { }

	// RVA: 0xFFFFFFFF75C8EB30
	public virtual Boolean get_canGrabFocus() { }

}

// Namespace: UnityEngine.UIElements
public class FocusChangeDirection
{
	// Fields
	private static readonly FocusChangeDirection <unspecified>k__BackingField; // 0x0
	private static readonly FocusChangeDirection <none>k__BackingField; // 0x8
	private static readonly FocusChangeDirection <lastValue>k__BackingField; // 0x10
	private readonly Int32 m_Value; // 0x10

	// Properties
	public static FocusChangeDirection unspecified { get; }
	public static FocusChangeDirection none { get; }
	protected static FocusChangeDirection lastValue { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C8DBF4
	public static FocusChangeDirection get_unspecified() { }

	// RVA: 0xFFFFFFFF75C8DC54
	public static FocusChangeDirection get_none() { }

	// RVA: 0xFFFFFFFF75C8DCB4
	protected static FocusChangeDirection get_lastValue() { }

	// RVA: 0xFFFFFFFF75C8DD14
	protected Void .ctor(Int32 value) { }

	// RVA: 0xFFFFFFFF75C8DD40
	public static Int32 op_Implicit(FocusChangeDirection fcd) { }

	// RVA: 0xFFFFFFFF75C8DD4C
	private static Void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IFocusRing
{
	// Methods

	// RVA: -1
	public abstract FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	// RVA: -1
	public abstract Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

}

// Namespace: UnityEngine.UIElements
public class FocusController
{
	// Fields
	private readonly IFocusRing <focusRing>k__BackingField; // 0x10
	private List<T0> m_FocusedElements; // 0x18
	private Int32 <imguiKeyboardControl>k__BackingField; // 0x20

	// Properties
	private IFocusRing focusRing { get; }
	internal Int32 imguiKeyboardControl { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C8DE2C
	private IFocusRing get_focusRing() { }

	// RVA: 0xFFFFFFFF75C89060
	internal Focusable GetLeafFocusedElement() { }

	// RVA: 0xFFFFFFFF75C88854
	internal Void DoFocusChange(Focusable f) { }

	// RVA: 0xFFFFFFFF75C8DE54
	private Void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction) { }

	// RVA: 0xFFFFFFFF75C8DF84
	private Void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction) { }

	// RVA: 0xFFFFFFFF75C8E0B4
	private Void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction) { }

	// RVA: 0xFFFFFFFF75C8E1E4
	private Void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction) { }

	// RVA: 0xFFFFFFFF75C8E314
	private Void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction) { }

	// RVA: 0xFFFFFFFF75C8E5B0
	internal Focusable SwitchFocusOnEvent(EventBase e) { }

	// RVA: 0xFFFFFFFF75C8E7A8
	internal Int32 get_imguiKeyboardControl() { }

	// RVA: 0xFFFFFFFF75C8E7B0
	internal Void set_imguiKeyboardControl(Int32 value) { }

	// RVA: 0xFFFFFFFF75C8E7B8
	internal Void SyncIMGUIFocus(Int32 imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, Boolean forceSwitch) { }

}

// Namespace: 
private struct FocusedElement
{
	// Fields
	public VisualElement m_SubTreeRoot; // 0x10
	public Focusable m_FocusedElement; // 0x18
}

// Namespace: UnityEngine.UIElements
public class IMGUIContainer
{
	// Fields
	private Action m_OnGUIHandler; // 0x158
	private ObjectGUIState m_ObjectGUIState; // 0x160
	internal Boolean useOwnerObjectGUIState; // 0x168
	private Rect <lastWorldClip>k__BackingField; // 0x16C
	private LayoutCache m_Cache; // 0x180
	private Rect m_CachedClippingRect; // 0x188
	private Matrix4x4 m_CachedTransform; // 0x198
	private ContextType <contextType>k__BackingField; // 0x1D8
	private Boolean lostFocus; // 0x1DC
	private Boolean receivedFocus; // 0x1DD
	private FocusChangeDirection focusChangeDirection; // 0x1E0
	private Boolean hasFocusableControls; // 0x1E8
	private Int32 newKeyboardFocusControlID; // 0x1EC
	private Boolean <focusOnlyIfHasFocusableControls>k__BackingField; // 0x1F0
	public static readonly String ussClassName; // 0x0
	private GUIGlobals m_GUIGlobals; // 0x1F4

	// Properties
	public Action onGUIHandler { get; }
	internal ObjectGUIState guiState { get; }
	internal Rect lastWorldClip { get; }
	private LayoutCache cache { get; }
	private Single layoutMeasuredWidth { get; }
	private Single layoutMeasuredHeight { get; }
	public ContextType contextType { get; }
	internal Boolean focusOnlyIfHasFocusableControls { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C8EB38
	public Action get_onGUIHandler() { }

	// RVA: 0xFFFFFFFF75C8EB40
	internal ObjectGUIState get_guiState() { }

	// RVA: 0xFFFFFFFF75C8EBE4
	internal Rect get_lastWorldClip() { }

	// RVA: 0xFFFFFFFF75C8EBF8
	private LayoutCache get_cache() { }

	// RVA: 0xFFFFFFFF75C8EC4C
	private Single get_layoutMeasuredWidth() { }

	// RVA: 0xFFFFFFFF75C8EC9C
	private Single get_layoutMeasuredHeight() { }

	// RVA: 0xFFFFFFFF75C8ECEC
	public ContextType get_contextType() { }

	// RVA: 0xFFFFFFFF75C8ECF4
	internal Boolean get_focusOnlyIfHasFocusableControls() { }

	// RVA: 0xFFFFFFFF75C8ECFC
	private Void SaveGlobals() { }

	// RVA: 0xFFFFFFFF75C8EDE4
	private Void RestoreGlobals() { }

	// RVA: 0xFFFFFFFF75C8EEDC
	private Void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, Boolean isComputingLayout, Rect layoutSize, Action onGUIHandler, Boolean canAffectFocus) { }

	// RVA: 0xFFFFFFFF75C90044
	public Void MarkDirtyLayout() { }

	// RVA: 0xFFFFFFFF75C89130
	internal Boolean SendEventToIMGUI(EventBase evt, Boolean canAffectFocus) { }

	// RVA: 0xFFFFFFFF75C90068
	internal Boolean HandleIMGUIEvent(Event e, Boolean canAffectFocus) { }

	// RVA: 0xFFFFFFFF75C90074
	internal Boolean HandleIMGUIEvent(Event e, Action onGUIHandler, Boolean canAffectFocus) { }

	// RVA: 0xFFFFFFFF75C902C8
	private Boolean HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, Boolean canAffectFocus) { }

	// RVA: 0xFFFFFFFF75C90140
	private static Void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect) { }

	// RVA: 0xFFFFFFFF75C90878
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75C908CC
	protected virtual Void Dispose(Boolean disposeManaged) { }

	// RVA: 0xFFFFFFFF75C908E4
	private static Void .cctor() { }

}

// Namespace: 
private struct GUIGlobals
{
	// Fields
	public Matrix4x4 matrix; // 0x10
	public Color color; // 0x50
	public Color contentColor; // 0x60
	public Color backgroundColor; // 0x70
	public Boolean enabled; // 0x80
	public Boolean changed; // 0x81
	public Int32 displayIndex; // 0x84
}

// Namespace: UnityEngine.UIElements
public interface ITransform
{
	// Properties
	public abstract Matrix4x4 matrix { get; }

	// Methods

	// RVA: -1
	public abstract Matrix4x4 get_matrix() { }

}

// Namespace: UnityEngine.UIElements
public static class MouseCaptureController
{
	// Fields
	private static Boolean m_IsMouseCapturedWarningEmitted; // 0x0
	private static Boolean m_ReleaseMouseWarningEmitted; // 0x1

	// Methods

	// RVA: 0xFFFFFFFF75C906A0
	public static Boolean HasMouseCapture(IEventHandler handler) { }

	// RVA: 0xFFFFFFFF75C91224
	public static Void CaptureMouse(IEventHandler handler) { }

	// RVA: 0xFFFFFFFF75C913FC
	public static Void ReleaseMouse(IEventHandler handler) { }

	// RVA: 0xFFFFFFFF75C91500
	private static Void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class ObjectPool<T0>
{
	// Fields
	private readonly Stack<T0> m_Stack; // 0x0
	private Int32 m_MaxSize; // 0x0

	// Properties
	public Int32 maxSize { get; set; }

	// Methods

	// RVA: -1
	public Int32 get_maxSize() { }

	// RVA: -1
	public Void set_maxSize(Int32 value) { }

	// RVA: -1
	public Void .ctor(Int32 maxSize) { }

	// RVA: -1
	public Int32 Size() { }

	// RVA: -1
	public T Get() { }

	// RVA: -1
	public Void Release(T element) { }

}

// Namespace: UnityEngine.UIElements
public enum ContextType
{
	// Fields
	public Int32 value__; // 0x10
	public const ContextType Player = 0;
	public const ContextType Editor = 1;
}

// Namespace: UnityEngine.UIElements
internal enum VersionChangeType
{
	// Fields
	public Int32 value__; // 0x10
	public const VersionChangeType Bindings = 1;
	public const VersionChangeType ViewData = 2;
	public const VersionChangeType Hierarchy = 4;
	public const VersionChangeType Layout = 8;
	public const VersionChangeType StyleSheet = 16;
	public const VersionChangeType Styles = 32;
	public const VersionChangeType Overflow = 64;
	public const VersionChangeType BorderRadius = 128;
	public const VersionChangeType BorderWidth = 256;
	public const VersionChangeType Transform = 512;
	public const VersionChangeType Size = 1024;
	public const VersionChangeType Repaint = 2048;
	public const VersionChangeType Opacity = 4096;
}

// Namespace: UnityEngine.UIElements
internal class RepaintData
{
	// Fields
	private Matrix4x4 <currentOffset>k__BackingField; // 0x10
	private Event <repaintEvent>k__BackingField; // 0x50

	// Properties
	public Matrix4x4 currentOffset { get; }
	public Event repaintEvent { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C97488
	public Matrix4x4 get_currentOffset() { }

	// RVA: 0xFFFFFFFF75C9749C
	public Void set_repaintEvent(Event value) { }

}

// Namespace: UnityEngine.UIElements
public interface IPanel
{
	// Properties
	public abstract VisualElement visualTree { get; }
	public abstract EventDispatcher dispatcher { get; }
	public abstract ContextType contextType { get; }
	public abstract FocusController focusController { get; }

	// Methods

	// RVA: -1
	public abstract VisualElement get_visualTree() { }

	// RVA: -1
	public abstract EventDispatcher get_dispatcher() { }

	// RVA: -1
	public abstract ContextType get_contextType() { }

	// RVA: -1
	public abstract FocusController get_focusController() { }

}

// Namespace: UnityEngine.UIElements
internal abstract class BaseVisualElementPanel
{
	// Fields
	private Single m_PixelsPerPoint; // 0x10
	private Boolean <duringLayoutPhase>k__BackingField; // 0x14
	private RepaintData <repaintData>k__BackingField; // 0x18
	private Boolean <disposed>k__BackingField; // 0x20
	internal ElementUnderPointer m_TopElementUnderPointers; // 0x28

	// Properties
	public abstract EventInterests IMGUIEventInterests { get; }
	public abstract ScriptableObject ownerObject { get; }
	public abstract Int32 IMGUIContainersCount { get; }
	public abstract IMGUIContainer rootIMGUIContainer { get; }
	public abstract FocusController focusController { get; }
	internal Single pixelsPerPoint { set; }
	internal Boolean duringLayoutPhase { get; }
	internal abstract UInt32 version { get; }
	internal virtual RepaintData repaintData { get; }
	public abstract VisualElement visualTree { get; }
	public abstract EventDispatcher dispatcher { get; }
	public abstract ContextType contextType { get; }
	internal Boolean disposed { get; set; }

	// Methods

	// RVA: -1
	public abstract EventInterests get_IMGUIEventInterests() { }

	// RVA: -1
	public abstract ScriptableObject get_ownerObject() { }

	// RVA: -1
	public abstract Int32 get_IMGUIContainersCount() { }

	// RVA: -1
	public abstract IMGUIContainer get_rootIMGUIContainer() { }

	// RVA: -1
	public abstract FocusController get_focusController() { }

	// RVA: 0xFFFFFFFF75C871F4
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75C87248
	protected virtual Void Dispose(Boolean disposing) { }

	// RVA: -1
	public abstract Void Repaint(Event e) { }

	// RVA: -1
	public abstract Void ValidateLayout() { }

	// RVA: 0xFFFFFFFF75C8739C
	internal Void set_pixelsPerPoint(Single value) { }

	// RVA: 0xFFFFFFFF75C87468
	internal Boolean get_duringLayoutPhase() { }

	// RVA: -1
	internal abstract UInt32 get_version() { }

	// RVA: -1
	internal abstract Void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag) { }

	// RVA: 0xFFFFFFFF75C87470
	internal virtual RepaintData get_repaintData() { }

	// RVA: -1
	public abstract VisualElement get_visualTree() { }

	// RVA: -1
	public abstract EventDispatcher get_dispatcher() { }

	// RVA: 0xFFFFFFFF75C87478
	internal Void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	// RVA: -1
	public abstract ContextType get_contextType() { }

	// RVA: -1
	public abstract VisualElement Pick(Vector2 point) { }

	// RVA: 0xFFFFFFFF75C8769C
	internal Boolean get_disposed() { }

	// RVA: 0xFFFFFFFF75C876A4
	private Void set_disposed(Boolean value) { }

	// RVA: 0xFFFFFFFF75C876AC
	internal VisualElement GetTopElementUnderPointer(Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C87704
	internal Void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

	// RVA: 0xFFFFFFFF75C8772C
	internal Void ClearCachedElementUnderPointer(EventBase triggerEvent) { }

	// RVA: 0xFFFFFFFF75C8775C
	internal Void CommitElementUnderPointers() { }

}

// Namespace: UnityEngine.UIElements
internal class Panel
{
	// Fields
	private VisualElement m_RootContainer; // 0x30
	private VisualTreeUpdater m_VisualTreeUpdater; // 0x38
	private UInt32 m_Version; // 0x40
	private UInt32 m_RepaintVersion; // 0x44
	private ProfilerMarker m_MarkerUpdate; // 0x48
	private static ProfilerMarker s_MarkerPickAll; // 0x0
	private EventDispatcher <dispatcher>k__BackingField; // 0x50
	private ScriptableObject <ownerObject>k__BackingField; // 0x58
	private ContextType <contextType>k__BackingField; // 0x60
	private FocusController <focusController>k__BackingField; // 0x68
	private EventInterests <IMGUIEventInterests>k__BackingField; // 0x70
	private Int32 <IMGUIContainersCount>k__BackingField; // 0x74
	private IMGUIContainer <rootIMGUIContainer>k__BackingField; // 0x78
	private Boolean m_ValidatingLayout; // 0x80

	// Properties
	public override VisualElement visualTree { get; }
	public override EventDispatcher dispatcher { get; }
	public override ScriptableObject ownerObject { get; }
	public override ContextType contextType { get; }
	public override FocusController focusController { get; }
	public override EventInterests IMGUIEventInterests { get; }
	public override Int32 IMGUIContainersCount { get; }
	public override IMGUIContainer rootIMGUIContainer { get; }
	internal override UInt32 version { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C9322C
	public override VisualElement get_visualTree() { }

	// RVA: 0xFFFFFFFF75C93234
	public override EventDispatcher get_dispatcher() { }

	// RVA: 0xFFFFFFFF75C9323C
	public override ScriptableObject get_ownerObject() { }

	// RVA: 0xFFFFFFFF75C93244
	public override ContextType get_contextType() { }

	// RVA: 0xFFFFFFFF75C9324C
	public override FocusController get_focusController() { }

	// RVA: 0xFFFFFFFF75C93254
	public override EventInterests get_IMGUIEventInterests() { }

	// RVA: 0xFFFFFFFF75C9325C
	public override Int32 get_IMGUIContainersCount() { }

	// RVA: 0xFFFFFFFF75C93264
	public override IMGUIContainer get_rootIMGUIContainer() { }

	// RVA: 0xFFFFFFFF75C9326C
	internal override UInt32 get_version() { }

	// RVA: 0xFFFFFFFF75C93274
	private static VisualElement PickAll(VisualElement root, Vector2 point, List<T0> picked) { }

	// RVA: 0xFFFFFFFF75C932F8
	private static VisualElement PerformPick(VisualElement root, Vector2 point, List<T0> picked) { }

	// RVA: 0xFFFFFFFF75C9372C
	public override VisualElement Pick(Vector2 point) { }

	// RVA: 0xFFFFFFFF75C938B4
	public override Void ValidateLayout() { }

	// RVA: 0xFFFFFFFF75C93A90
	private Void UpdateForRepaint() { }

	// RVA: 0xFFFFFFFF75C93AEC
	public override Void Repaint(Event e) { }

	// RVA: 0xFFFFFFFF75C93C64
	internal override Void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0xFFFFFFFF75C9407C
	private static Void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class RuntimePanel
{
	// Fields
	internal RenderTexture targetTexture; // 0x88
}

// Namespace: UnityEngine.UIElements
public static class PointerCaptureHelper
{
	// Methods

	// RVA: 0xFFFFFFFF75C94BA8
	private static PointerDispatchState GetStateFor(IEventHandler handler) { }

	// RVA: 0xFFFFFFFF75C911E8
	public static Boolean HasPointerCapture(IEventHandler handler, Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C912EC
	public static Void CapturePointer(IEventHandler handler, Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C914C4
	public static Void ReleasePointer(IEventHandler handler, Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C91D80
	public static IEventHandler GetCapturingElement(IPanel panel, Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C94514
	public static Void ReleasePointer(IPanel panel, Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C94EF4
	internal static Void ActivateCompatibilityMouseEvents(IPanel panel, Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C95008
	internal static Void PreventCompatibilityMouseEvents(IPanel panel, Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C945E8
	internal static Boolean ShouldSendCompatibilityMouseEvents(IPanel panel, IPointerEvent evt) { }

	// RVA: 0xFFFFFFFF75C91328
	internal static Void ProcessPointerCapture(IPanel panel, Int32 pointerId) { }

}

// Namespace: UnityEngine.UIElements
internal class PointerDispatchState
{
	// Fields
	private IEventHandler[] m_PendingPointerCapture; // 0x10
	private IEventHandler[] m_PointerCapture; // 0x18
	private Boolean[] m_ShouldSendCompatibilityMouseEvents; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75C8CF70
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C95D54
	internal Void Reset() { }

	// RVA: 0xFFFFFFFF75C94E78
	public IEventHandler GetCapturingElement(Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C94CA0
	public Boolean HasPointerCapture(IEventHandler handler, Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C94CE4
	public Void CapturePointer(IEventHandler handler, Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C94EB4
	public Void ReleasePointer(Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C94E18
	public Void ReleasePointer(IEventHandler handler, Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C9525C
	public Void ProcessPointerCapture(Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C94FC8
	public Void ActivateCompatibilityMouseEvents(Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C950DC
	public Void PreventCompatibilityMouseEvents(Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C95118
	public Boolean ShouldSendCompatibilityMouseEvents(IPointerEvent evt) { }

}

// Namespace: UnityEngine.UIElements
public enum Overflow
{
	// Fields
	public Int32 value__; // 0x10
	public const Overflow Visible = 0;
	public const Overflow Hidden = 1;
}

// Namespace: UnityEngine.UIElements
public enum Visibility
{
	// Fields
	public Int32 value__; // 0x10
	public const Visibility Visible = 0;
	public const Visibility Hidden = 1;
}

// Namespace: UnityEngine.UIElements
public enum DisplayStyle
{
	// Fields
	public Int32 value__; // 0x10
	public const DisplayStyle Flex = 0;
	public const DisplayStyle None = 1;
}

// Namespace: UnityEngine.UIElements
internal static class UIElementsRuntimeUtility
{
	// Fields
	private static EventDispatcher s_RuntimeDispatcher; // 0x0
	private static Boolean s_RegisteredPlayerloopCallback; // 0x8
	private static List<T0> panelsIteration; // 0x10
	internal static readonly String s_RepaintProfilerMarkerName; // 0x18
	private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75C9A410
	public static Void RepaintOverlayPanels() { }

	// RVA: 0xFFFFFFFF75C9A82C
	private static Void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class UIElementsUtility
{
	// Fields
	private static Stack<T0> s_ContainerStack; // 0x0
	private static Dictionary<T0, T1> s_UIElementsCache; // 0x8
	private static Event s_EventInstance; // 0x10
	internal static Color editorPlayModeTintColor; // 0x18
	internal static readonly String s_RepaintProfilerMarkerName; // 0x28
	internal static readonly String s_EventProfilerMarkerName; // 0x30
	private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x38
	private static readonly ProfilerMarker s_EventProfilerMarker; // 0x40

	// Methods

	// RVA: 0xFFFFFFFF75C9A938
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C9ADDC
	internal static Void MakeCurrentIMGUIContainerDirty() { }

	// RVA: 0xFFFFFFFF75C9AEA0
	private static Void TakeCapture() { }

	// RVA: 0xFFFFFFFF75C9B008
	private static Void ReleaseCapture() { }

	// RVA: 0xFFFFFFFF75C9B00C
	private static Boolean ProcessEvent(Int32 instanceID, IntPtr nativeEventPtr) { }

	// RVA: 0xFFFFFFFF75C87318
	public static Void RemoveCachedPanel(Int32 instanceID) { }

	// RVA: 0xFFFFFFFF75C9B498
	private static Void CleanupRoots() { }

	// RVA: 0xFFFFFFFF75C9B524
	private static Boolean EndContainerGUIFromException(Exception exception) { }

	// RVA: 0xFFFFFFFF75C8FCA8
	internal static Void BeginContainerGUI(LayoutCache cache, Event evt, IMGUIContainer container) { }

	// RVA: 0xFFFFFFFF75C8FE54
	internal static Void EndContainerGUI(Event evt, Rect layoutSize) { }

	// RVA: 0xFFFFFFFF75C9B5DC
	internal static EventBase CreateEvent(Event systemEvent) { }

	// RVA: 0xFFFFFFFF75C9B654
	internal static EventBase CreateEvent(Event systemEvent, EventType eventType) { }

	// RVA: 0xFFFFFFFF75C9B12C
	private static Boolean DoDispatch(BaseVisualElementPanel panel) { }

	// RVA: 0xFFFFFFFF75C9A700
	internal static Void GetAllPanels(List<T0> panels, ContextType contextType) { }

	// RVA: 0xFFFFFFFF75C9B9C4
	internal static Enumerator GetPanelsIterator() { }

}

// Namespace: UnityEngine.UIElements
internal enum PseudoStates
{
	// Fields
	public Int32 value__; // 0x10
	public const PseudoStates Active = 1;
	public const PseudoStates Hover = 2;
	public const PseudoStates Checked = 8;
	public const PseudoStates Disabled = 32;
	public const PseudoStates Focus = 64;
	public const PseudoStates Root = 128;
}

// Namespace: UnityEngine.UIElements
public enum PickingMode
{
	// Fields
	public Int32 value__; // 0x10
	public const PickingMode Position = 0;
	public const PickingMode Ignore = 1;
}

// Namespace: UnityEngine.UIElements
internal static class VisualElementListPool
{
	// Fields
	private static ObjectPool<T0> pool; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75C9D250
	public static List<T0> Get(Int32 initialCapacity) { }

	// RVA: 0xFFFFFFFF75C9D32C
	public static Void Release(List<T0> elements) { }

	// RVA: 0xFFFFFFFF75C9D3D0
	private static Void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public class VisualElement
{
	// Fields
	private Boolean <isCompositeRoot>k__BackingField; // 0x1A
	private static List<T0> s_EmptyClassList; // 0x0
	internal static readonly PropertyName userDataPropertyKey; // 0x8
	public static readonly String disabledUssClassName; // 0x10
	private Vector3 m_Position; // 0x1C
	private Quaternion m_Rotation; // 0x28
	private Vector3 m_Scale; // 0x38
	private Boolean <isLayoutManual>k__BackingField; // 0x44
	private Rect m_Layout; // 0x48
	internal Boolean isBoundingBoxDirty; // 0x58
	private Rect m_BoundingBox; // 0x5C
	internal Boolean isWorldBoundingBoxDirty; // 0x6C
	private Rect m_WorldBoundingBox; // 0x70
	private Boolean <isWorldTransformDirty>k__BackingField; // 0x80
	private Boolean <isWorldTransformInverseDirty>k__BackingField; // 0x81
	private Matrix4x4 m_WorldTransformCache; // 0x84
	private Matrix4x4 m_WorldTransformInverseCache; // 0xC4
	private static readonly Rect s_InfiniteRect; // 0x18
	private PseudoStates m_PseudoStates; // 0x104
	private PickingMode <pickingMode>k__BackingField; // 0x108
	private YogaNode <yogaNode>k__BackingField; // 0x110
	internal VisualElementStylesData m_Style; // 0x118
	private InheritedStylesData m_InheritedStylesData; // 0x120
	private ComputedStyle <computedStyle>k__BackingField; // 0x128
	internal Int32 imguiContainerDescendantCount; // 0x130
	private Hierarchy <hierarchy>k__BackingField; // 0x138
	private VisualElement m_PhysicalParent; // 0x140
	private static readonly List<T0> s_EmptyList; // 0x28
	private List<T0> m_Children; // 0x148
	private BaseVisualElementPanel <elementPanel>k__BackingField; // 0x150

	// Properties
	internal Boolean isCompositeRoot { get; }
	public override FocusController focusController { get; }
	public ITransform transform { get; }
	private Matrix4x4 UnityEngine.UIElements.ITransform.matrix { get; }
	internal Boolean isLayoutManual { get; }
	public Rect layout { get; }
	internal Rect boundingBox { get; }
	internal Rect worldBoundingBox { get; }
	public Rect worldBound { get; }
	internal Rect rect { get; }
	internal Boolean isWorldTransformDirty { get; set; }
	internal Boolean isWorldTransformInverseDirty { get; set; }
	public Matrix4x4 worldTransform { get; }
	internal Matrix4x4 worldTransformInverse { get; }
	internal PseudoStates pseudoStates { get; }
	public PickingMode pickingMode { get; }
	internal YogaNode yogaNode { get; }
	internal VisualElementStylesData specifiedStyle { get; }
	internal InheritedStylesData inheritedStyle { get; }
	internal ComputedStyle computedStyle { get; }
	public Boolean enabledInHierarchy { get; }
	public Boolean visible { get; }
	public Hierarchy hierarchy { get; }
	internal BaseVisualElementPanel elementPanel { get; }
	public IPanel panel { get; }
	public IResolvedStyle resolvedStyle { get; }
	private Visibility UnityEngine.UIElements.IResolvedStyle.visibility { get; }
	private DisplayStyle UnityEngine.UIElements.IResolvedStyle.display { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C9BC88
	internal Boolean get_isCompositeRoot() { }

	// RVA: 0xFFFFFFFF75C9BC90
	public override FocusController get_focusController() { }

	// RVA: 0xFFFFFFFF75C9BD44
	public ITransform get_transform() { }

	// RVA: 0xFFFFFFFF75C9BD48
	private Matrix4x4 UnityEngine.UIElements.ITransform.get_matrix() { }

	// RVA: 0xFFFFFFFF75C9BE08
	internal Boolean get_isLayoutManual() { }

	// RVA: 0xFFFFFFFF75C9055C
	public Rect get_layout() { }

	// RVA: 0xFFFFFFFF75C9BF10
	internal static Rect TransformAlignedRect(Matrix4x4 lhc, Rect rect) { }

	// RVA: 0xFFFFFFFF75C9C0C0
	internal static Vector2 MultiplyMatrix44Point2(Matrix4x4 lhs, Vector2 point) { }

	// RVA: 0xFFFFFFFF75C9C0E4
	internal Rect get_boundingBox() { }

	// RVA: 0xFFFFFFFF75C935B8
	internal Rect get_worldBoundingBox() { }

	// RVA: 0xFFFFFFFF75C9C120
	internal Void UpdateBoundingBox() { }

	// RVA: 0xFFFFFFFF75C9C3F8
	internal Void UpdateWorldBoundingBox() { }

	// RVA: 0xFFFFFFFF75C90754
	public Rect get_worldBound() { }

	// RVA: 0xFFFFFFFF75C9C4DC
	internal Rect get_rect() { }

	// RVA: 0xFFFFFFFF75C9C58C
	internal Boolean get_isWorldTransformDirty() { }

	// RVA: 0xFFFFFFFF75C9C594
	internal Void set_isWorldTransformDirty(Boolean value) { }

	// RVA: 0xFFFFFFFF75C9C59C
	internal Boolean get_isWorldTransformInverseDirty() { }

	// RVA: 0xFFFFFFFF75C9C5A4
	internal Void set_isWorldTransformInverseDirty(Boolean value) { }

	// RVA: 0xFFFFFFFF75C9082C
	public Matrix4x4 get_worldTransform() { }

	// RVA: 0xFFFFFFFF75C9C88C
	internal Matrix4x4 get_worldTransformInverse() { }

	// RVA: 0xFFFFFFFF75C9C5AC
	private Void UpdateWorldTransform() { }

	// RVA: 0xFFFFFFFF75C9C92C
	internal PseudoStates get_pseudoStates() { }

	// RVA: 0xFFFFFFFF75C9C934
	public PickingMode get_pickingMode() { }

	// RVA: 0xFFFFFFFF75C9C93C
	internal YogaNode get_yogaNode() { }

	// RVA: 0xFFFFFFFF75C89C90
	internal VisualElementStylesData get_specifiedStyle() { }

	// RVA: 0xFFFFFFFF75C89CB8
	internal InheritedStylesData get_inheritedStyle() { }

	// RVA: 0xFFFFFFFF75C9C944
	internal ComputedStyle get_computedStyle() { }

	// RVA: 0xFFFFFFFF75C9C94C
	public sealed override Void SendEvent(EventBase e) { }

	// RVA: 0xFFFFFFFF75C87444
	internal Void IncrementVersion(VersionChangeType changeType) { }

	// RVA: 0xFFFFFFFF75C9371C
	public Boolean get_enabledInHierarchy() { }

	// RVA: 0xFFFFFFFF75C93670
	public Boolean get_visible() { }

	// RVA: 0xFFFFFFFF75C9C960
	public virtual Boolean ContainsPoint(Vector2 localPoint) { }

	// RVA: 0xFFFFFFFF75C9C9A8
	public Hierarchy get_hierarchy() { }

	// RVA: 0xFFFFFFFF75C935FC
	internal Boolean ShouldClip() { }

	// RVA: 0xFFFFFFFF75C9C9B0
	internal BaseVisualElementPanel get_elementPanel() { }

	// RVA: 0xFFFFFFFF75C8FCA0
	public IPanel get_panel() { }

	// RVA: 0xFFFFFFFF75C8E54C
	internal VisualElement RetargetElement(VisualElement retargetAgainst) { }

	// RVA: 0xFFFFFFFF75C935B4
	public IResolvedStyle get_resolvedStyle() { }

	// RVA: 0xFFFFFFFF75C9C9B8
	private Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }

	// RVA: 0xFFFFFFFF75C9CA24
	private DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }

	// RVA: 0xFFFFFFFF75C9CA90
	private static Void .cctor() { }

}

// Namespace: 
public struct Hierarchy
{
	// Fields
	private readonly VisualElement m_Owner; // 0x10

	// Properties
	public VisualElement parent { get; }
	public Int32 childCount { get; }
	public VisualElement Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF7115383C
	public VisualElement get_parent() { }

	// RVA: 0xFFFFFFFF7115385C
	public Int32 get_childCount() { }

	// RVA: 0xFFFFFFFF71153864
	public VisualElement get_Item(Int32 key) { }

	// RVA: 0xFFFFFFFF7115386C
	public Boolean Equals(Hierarchy other) { }

	// RVA: 0xFFFFFFFF7115387C
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF71153884
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75C9CBE8
	public static Boolean op_Equality(Hierarchy x, Hierarchy y) { }

}

// Namespace: UnityEngine.UIElements
public static class VisualElementExtensions
{
	// Methods

	// RVA: 0xFFFFFFFF75C8BC9C
	public static Vector2 WorldToLocal(VisualElement ele, Vector2 p) { }

	// RVA: 0xFFFFFFFF75C9CC90
	public static Rect WorldToLocal(VisualElement ele, Rect r) { }

	// RVA: 0xFFFFFFFF75C9CE18
	public static Rect LocalToWorld(VisualElement ele, Rect r) { }

	// RVA: 0xFFFFFFFF75C9C568
	public static Rect ChangeCoordinatesTo(VisualElement src, VisualElement dest, Rect rect) { }

}

// Namespace: UnityEngine.UIElements
public class VisualElementFocusChangeDirection
{
	// Fields
	private static readonly VisualElementFocusChangeDirection s_Left; // 0x0
	private static readonly VisualElementFocusChangeDirection s_Right; // 0x8

	// Properties
	public static FocusChangeDirection left { get; }
	public static FocusChangeDirection right { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C9CFB0
	public static FocusChangeDirection get_left() { }

	// RVA: 0xFFFFFFFF75C9D010
	public static FocusChangeDirection get_right() { }

	// RVA: 0xFFFFFFFF75C9D070
	protected Void .ctor(Int32 value) { }

	// RVA: 0xFFFFFFFF75C9D0E4
	private static Void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal enum VisualTreeUpdatePhase
{
	// Fields
	public Int32 value__; // 0x10
	public const VisualTreeUpdatePhase ViewData = 0;
	public const VisualTreeUpdatePhase Bindings = 1;
	public const VisualTreeUpdatePhase Animation = 2;
	public const VisualTreeUpdatePhase Styles = 3;
	public const VisualTreeUpdatePhase Layout = 4;
	public const VisualTreeUpdatePhase TransformClip = 5;
	public const VisualTreeUpdatePhase Repaint = 6;
	public const VisualTreeUpdatePhase Count = 7;
}

// Namespace: UnityEngine.UIElements
internal sealed class VisualTreeUpdater
{
	// Fields
	private UpdaterArray m_UpdaterArray; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C93914
	public Void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

	// RVA: 0xFFFFFFFF75C93C8C
	public Void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

}

// Namespace: 
private class UpdaterArray
{
	// Fields
	private IVisualTreeUpdater[] m_VisualTreeUpdaters; // 0x10

	// Properties
	public IVisualTreeUpdater Item { get; }
	public IVisualTreeUpdater Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C9D454
	public IVisualTreeUpdater get_Item(VisualTreeUpdatePhase phase) { }

	// RVA: 0xFFFFFFFF75C9D490
	public IVisualTreeUpdater get_Item(Int32 index) { }

}

// Namespace: UnityEngine.UIElements
internal interface IVisualTreeUpdater
{
	// Properties
	public abstract ProfilerMarker profilerMarker { get; }

	// Methods

	// RVA: -1
	public abstract ProfilerMarker get_profilerMarker() { }

	// RVA: -1
	public abstract Void Update() { }

	// RVA: -1
	public abstract Void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

}

// Namespace: UnityEngine.UIElements
public abstract class PointerCaptureEventBase<T0>
{
	// Fields
	private IEventHandler <relatedTarget>k__BackingField; // 0x0
	private Int32 <pointerId>k__BackingField; // 0x0

	// Properties
	private IEventHandler relatedTarget { set; }
	private Int32 pointerId { set; }

	// Methods

	// RVA: -1
	private Void set_relatedTarget(IEventHandler value) { }

	// RVA: -1
	private Void set_pointerId(Int32 value) { }

	// RVA: -1
	protected override Void Init() { }

	// RVA: -1
	private Void LocalInit() { }

	// RVA: -1
	public static T GetPooled(IEventHandler target, IEventHandler relatedTarget, Int32 pointerId) { }

	// RVA: -1
	protected Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class PointerCaptureOutEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C95A1C
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class PointerCaptureEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C94B60
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class MouseCaptureEventBase<T0>
{
	// Methods

	// RVA: -1
	protected override Void Init() { }

	// RVA: -1
	protected Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class MouseCaptureOutEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C91EA0
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class MouseCaptureEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C91E58
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class CommandEventDispatchingStrategy
{
	// Methods

	// RVA: 0xFFFFFFFF75C88D1C
	public Boolean CanDispatchEvent(EventBase evt) { }

	// RVA: 0xFFFFFFFF75C88D70
	public Void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0xFFFFFFFF75C89C68
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public interface ICommandEvent
{}

// Namespace: UnityEngine.UIElements
public abstract class CommandEventBase<T0>
{
	// Fields
	private String m_CommandName; // 0x0

	// Properties
	protected String commandName { set; }

	// Methods

	// RVA: -1
	protected Void set_commandName(String value) { }

	// RVA: -1
	protected override Void Init() { }

	// RVA: -1
	private Void LocalInit() { }

	// RVA: -1
	public static T GetPooled(Event systemEvent) { }

	// RVA: -1
	protected Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class ValidateCommandEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C9BC40
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class ExecuteCommandEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C8DBAC
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class DefaultDispatchingStrategy
{
	// Methods

	// RVA: 0xFFFFFFFF75C89EA8
	public Boolean CanDispatchEvent(EventBase evt) { }

	// RVA: 0xFFFFFFFF75C89F20
	public Void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0xFFFFFFFF75C8A12C
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class DragAndDropEventBase<T0>
{
	// Methods

	// RVA: -1
	protected Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class DragExitedEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C8A1E8
	protected override Void Init() { }

	// RVA: 0xFFFFFFFF75C8A23C
	private Void LocalInit() { }

	// RVA: 0xFFFFFFFF75C8A248
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C8A29C
	public static DragExitedEvent GetPooled(Event systemEvent) { }

	// RVA: 0xFFFFFFFF75C8A450
	protected internal override Void PostDispatch(IPanel panel) { }

}

// Namespace: UnityEngine.UIElements
public class DragEnterEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C8A134
	protected override Void Init() { }

	// RVA: 0xFFFFFFFF75C8A188
	private Void LocalInit() { }

	// RVA: 0xFFFFFFFF75C8A194
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class DragLeaveEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C8A5A4
	protected override Void Init() { }

	// RVA: 0xFFFFFFFF75C8A5F8
	private Void LocalInit() { }

	// RVA: 0xFFFFFFFF75C8A604
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class DragUpdatedEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C8A6A0
	public static DragUpdatedEvent GetPooled(Event systemEvent) { }

	// RVA: 0xFFFFFFFF75C8A870
	protected internal override Void PostDispatch(IPanel panel) { }

	// RVA: 0xFFFFFFFF75C8A9C4
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class DragPerformEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C8A658
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class ElementUnderPointer
{
	// Fields
	private VisualElement[] m_PendingTopElementUnderPointer; // 0x10
	private VisualElement[] m_TopElementUnderPointer; // 0x18
	private IPointerEvent[] m_TriggerPointerEvent; // 0x20
	private IMouseEvent[] m_TriggerMouseEvent; // 0x28
	private Vector2[] m_PickingPointerPositions; // 0x30
	private Boolean[] m_IsPickingPointerTemporaries; // 0x38

	// Methods

	// RVA: 0xFFFFFFFF75C8AA0C
	internal VisualElement GetTopElementUnderPointer(Int32 pointerId, out Vector2 pickPosition, out Boolean isTemporary) { }

	// RVA: 0xFFFFFFFF75C876C8
	internal VisualElement GetTopElementUnderPointer(Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C8AA8C
	private Vector2 GetEventPointerPosition(EventBase triggerEvent) { }

	// RVA: 0xFFFFFFFF75C87754
	internal Void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

	// RVA: 0xFFFFFFFF75C87724
	internal Void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

	// RVA: 0xFFFFFFFF75C8AC74
	private Void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent, Boolean temporary) { }

	// RVA: 0xFFFFFFFF75C87798
	internal Void CommitElementUnderPointers(EventDispatcher dispatcher) { }

}

// Namespace: UnityEngine.UIElements
public abstract class EventBase
{
	// Fields
	private static Int64 s_LastTypeId; // 0x0
	private static UInt64 s_NextEventId; // 0x8
	private Int64 <timestamp>k__BackingField; // 0x10
	private UInt64 <eventId>k__BackingField; // 0x18
	private UInt64 <triggerEventId>k__BackingField; // 0x20
	private EventPropagation <propagation>k__BackingField; // 0x28
	private PropagationPaths m_Path; // 0x30
	private LifeCycleStatus <lifeCycleStatus>k__BackingField; // 0x38
	private IEventHandler <leafTarget>k__BackingField; // 0x40
	private IEventHandler m_Target; // 0x48
	private readonly List<T0> <skipElements>k__BackingField; // 0x50
	private PropagationPhase <propagationPhase>k__BackingField; // 0x58
	private IEventHandler m_CurrentTarget; // 0x60
	private Event m_ImguiEvent; // 0x68
	private Vector2 <originalMousePosition>k__BackingField; // 0x70

	// Properties
	public virtual Int64 eventTypeId { get; }
	private Int64 timestamp { set; }
	internal UInt64 eventId { get; set; }
	private UInt64 triggerEventId { set; }
	internal EventPropagation propagation { get; set; }
	internal PropagationPaths path { get; set; }
	private LifeCycleStatus lifeCycleStatus { get; set; }
	public Boolean bubbles { get; }
	public Boolean tricklesDown { get; }
	internal IEventHandler leafTarget { get; set; }
	public IEventHandler target { get; set; }
	internal List<T0> skipElements { get; }
	public Boolean isPropagationStopped { get; set; }
	public Boolean isImmediatePropagationStopped { get; set; }
	public Boolean isDefaultPrevented { get; set; }
	public PropagationPhase propagationPhase { get; set; }
	public virtual IEventHandler currentTarget { get; set; }
	public Boolean dispatch { get; set; }
	private Boolean dispatched { get; set; }
	internal Boolean processed { get; set; }
	internal Boolean stopDispatch { get; set; }
	internal Boolean propagateToIMGUI { get; set; }
	private Boolean imguiEventIsValid { get; set; }
	public Event imguiEvent { get; set; }
	public Vector2 originalMousePosition { get; set; }
	protected Boolean pooled { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C8B5D8
	protected static Int64 RegisterEventType() { }

	// RVA: 0xFFFFFFFF75C8B640
	public virtual Int64 get_eventTypeId() { }

	// RVA: 0xFFFFFFFF75C8B648
	private Void set_timestamp(Int64 value) { }

	// RVA: 0xFFFFFFFF75C8B650
	internal UInt64 get_eventId() { }

	// RVA: 0xFFFFFFFF75C8B658
	private Void set_eventId(UInt64 value) { }

	// RVA: 0xFFFFFFFF75C8B660
	private Void set_triggerEventId(UInt64 value) { }

	// RVA: 0xFFFFFFFF75C8B668
	internal Void SetTriggerEventId(UInt64 id) { }

	// RVA: 0xFFFFFFFF75C8B670
	internal EventPropagation get_propagation() { }

	// RVA: 0xFFFFFFFF75C8B678
	internal Void set_propagation(EventPropagation value) { }

	// RVA: 0xFFFFFFFF75C8B680
	internal PropagationPaths get_path() { }

	// RVA: 0xFFFFFFFF75C8B8FC
	internal Void set_path(PropagationPaths value) { }

	// RVA: 0xFFFFFFFF75C8BA70
	private LifeCycleStatus get_lifeCycleStatus() { }

	// RVA: 0xFFFFFFFF75C8BA78
	private Void set_lifeCycleStatus(LifeCycleStatus value) { }

	// RVA: 0xFFFFFFFF75C8BA80
	protected virtual Void PreDispatch() { }

	// RVA: 0xFFFFFFFF75C88844
	protected internal virtual Void PreDispatch(IPanel panel) { }

	// RVA: 0xFFFFFFFF75C8BA84
	protected virtual Void PostDispatch() { }

	// RVA: 0xFFFFFFFF75C8BA88
	protected internal virtual Void PostDispatch(IPanel panel) { }

	// RVA: 0xFFFFFFFF75C8B770
	public Boolean get_bubbles() { }

	// RVA: 0xFFFFFFFF75C8B764
	public Boolean get_tricklesDown() { }

	// RVA: 0xFFFFFFFF75C8BAE0
	internal IEventHandler get_leafTarget() { }

	// RVA: 0xFFFFFFFF75C8BAE8
	private Void set_leafTarget(IEventHandler value) { }

	// RVA: 0xFFFFFFFF75C8A124
	public IEventHandler get_target() { }

	// RVA: 0xFFFFFFFF75C89438
	public Void set_target(IEventHandler value) { }

	// RVA: 0xFFFFFFFF75C8BAF0
	internal List<T0> get_skipElements() { }

	// RVA: 0xFFFFFFFF75C890D0
	internal Boolean Skip(IEventHandler h) { }

	// RVA: 0xFFFFFFFF75C88AF0
	public Boolean get_isPropagationStopped() { }

	// RVA: 0xFFFFFFFF75C8BAF8
	private Void set_isPropagationStopped(Boolean value) { }

	// RVA: 0xFFFFFFFF75C891F4
	public Void StopPropagation() { }

	// RVA: 0xFFFFFFFF75C8BB0C
	public Boolean get_isImmediatePropagationStopped() { }

	// RVA: 0xFFFFFFFF75C8BB18
	private Void set_isImmediatePropagationStopped(Boolean value) { }

	// RVA: 0xFFFFFFFF75C8BB38
	public Void StopImmediatePropagation() { }

	// RVA: 0xFFFFFFFF75C88C70
	public Boolean get_isDefaultPrevented() { }

	// RVA: 0xFFFFFFFF75C8BB48
	private Void set_isDefaultPrevented(Boolean value) { }

	// RVA: 0xFFFFFFFF75C89204
	public Void PreventDefault() { }

	// RVA: 0xFFFFFFFF75C8BB68
	public PropagationPhase get_propagationPhase() { }

	// RVA: 0xFFFFFFFF75C8BB70
	internal Void set_propagationPhase(PropagationPhase value) { }

	// RVA: 0xFFFFFFFF75C8BB78
	public virtual IEventHandler get_currentTarget() { }

	// RVA: 0xFFFFFFFF75C8BB80
	internal virtual Void set_currentTarget(IEventHandler value) { }

	// RVA: 0xFFFFFFFF75C8BD84
	public Boolean get_dispatch() { }

	// RVA: 0xFFFFFFFF75C8BD90
	internal Void set_dispatch(Boolean value) { }

	// RVA: 0xFFFFFFFF75C8BDD0
	internal Void MarkReceivedByDispatcher() { }

	// RVA: 0xFFFFFFFF75C8BE50
	private Boolean get_dispatched() { }

	// RVA: 0xFFFFFFFF75C8BDB0
	private Void set_dispatched(Boolean value) { }

	// RVA: 0xFFFFFFFF75C8BE5C
	internal Boolean get_processed() { }

	// RVA: 0xFFFFFFFF75C8BAC0
	private Void set_processed(Boolean value) { }

	// RVA: 0xFFFFFFFF75C8BE68
	internal Boolean get_stopDispatch() { }

	// RVA: 0xFFFFFFFF75C89C48
	internal Void set_stopDispatch(Boolean value) { }

	// RVA: 0xFFFFFFFF75C8921C
	internal Boolean get_propagateToIMGUI() { }

	// RVA: 0xFFFFFFFF75C89C28
	internal Void set_propagateToIMGUI(Boolean value) { }

	// RVA: 0xFFFFFFFF75C8BE74
	private Boolean get_imguiEventIsValid() { }

	// RVA: 0xFFFFFFFF75C8BE80
	private Void set_imguiEventIsValid(Boolean value) { }

	// RVA: 0xFFFFFFFF75C8BC84
	public Event get_imguiEvent() { }

	// RVA: 0xFFFFFFFF75C8BEA0
	protected Void set_imguiEvent(Event value) { }

	// RVA: 0xFFFFFFFF75C8BF48
	public Vector2 get_originalMousePosition() { }

	// RVA: 0xFFFFFFFF75C8BF50
	private Void set_originalMousePosition(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C8BF58
	protected virtual Void Init() { }

	// RVA: 0xFFFFFFFF75C8BF5C
	private Void LocalInit() { }

	// RVA: 0xFFFFFFFF75C8C1CC
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF75C8C260
	protected Boolean get_pooled() { }

	// RVA: 0xFFFFFFFF75C8C1AC
	protected Void set_pooled(Boolean value) { }

	// RVA: -1
	internal abstract Void Acquire() { }

	// RVA: -1
	public abstract Void Dispose() { }

	// RVA: 0xFFFFFFFF75C8C26C
	private static Void .cctor() { }

}

// Namespace: 
internal enum EventPropagation
{
	// Fields
	public Int32 value__; // 0x10
	public const EventPropagation None = 0;
	public const EventPropagation Bubbles = 1;
	public const EventPropagation TricklesDown = 2;
	public const EventPropagation Cancellable = 4;
}

// Namespace: 
private enum LifeCycleStatus
{
	// Fields
	public Int32 value__; // 0x10
	public const LifeCycleStatus None = 0;
	public const LifeCycleStatus PropagationStopped = 1;
	public const LifeCycleStatus ImmediatePropagationStopped = 2;
	public const LifeCycleStatus DefaultPrevented = 4;
	public const LifeCycleStatus Dispatching = 8;
	public const LifeCycleStatus Pooled = 16;
	public const LifeCycleStatus IMGUIEventIsValid = 32;
	public const LifeCycleStatus StopDispatch = 64;
	public const LifeCycleStatus PropagateToIMGUI = 128;
	public const LifeCycleStatus Dispatched = 512;
	public const LifeCycleStatus Processed = 1024;
}

// Namespace: UnityEngine.UIElements
public abstract class EventBase<T0>
{
	// Fields
	private static readonly Int64 s_TypeId; // 0x0
	private static readonly ObjectPool<T0> s_Pool; // 0x0
	private Int32 m_RefCount; // 0x0

	// Properties
	public override Int64 eventTypeId { get; }

	// Methods

	// RVA: -1
	protected Void .ctor() { }

	// RVA: -1
	public static Int64 TypeId() { }

	// RVA: -1
	protected override Void Init() { }

	// RVA: -1
	public static T GetPooled() { }

	// RVA: -1
	internal static T GetPooled(EventBase e) { }

	// RVA: -1
	private static Void ReleasePooled(T evt) { }

	// RVA: -1
	internal override Void Acquire() { }

	// RVA: -1
	public sealed override Void Dispose() { }

	// RVA: -1
	public override Int64 get_eventTypeId() { }

	// RVA: -1
	private static Void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal abstract class EventCallbackFunctorBase
{
	// Fields
	private CallbackPhase <phase>k__BackingField; // 0x10

	// Properties
	public CallbackPhase phase { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C8C2B4
	public CallbackPhase get_phase() { }

	// RVA: -1
	public abstract Void Invoke(EventBase evt) { }

}

// Namespace: UnityEngine.UIElements
internal enum CallbackPhase
{
	// Fields
	public Int32 value__; // 0x10
	public const CallbackPhase TargetAndBubbleUp = 1;
	public const CallbackPhase TrickleDownAndTarget = 2;
}

// Namespace: UnityEngine.UIElements
internal class EventCallbackListPool
{
	// Fields
	private readonly Stack<T0> m_Stack; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C8C67C
	public EventCallbackList Get(EventCallbackList initializer) { }

	// RVA: 0xFFFFFFFF75C8C744
	public Void Release(EventCallbackList element) { }

	// RVA: 0xFFFFFFFF75C8C7B0
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class EventCallbackList
{
	// Fields
	private List<T0> m_List; // 0x10
	private Int32 <trickleDownCallbackCount>k__BackingField; // 0x18
	private Int32 <bubbleUpCallbackCount>k__BackingField; // 0x1C

	// Properties
	public Int32 trickleDownCallbackCount { get; set; }
	public Int32 bubbleUpCallbackCount { get; set; }
	public Int32 Count { get; }
	public EventCallbackFunctorBase Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C8C2BC
	public Int32 get_trickleDownCallbackCount() { }

	// RVA: 0xFFFFFFFF75C8C2C4
	private Void set_trickleDownCallbackCount(Int32 value) { }

	// RVA: 0xFFFFFFFF75C8C2CC
	public Int32 get_bubbleUpCallbackCount() { }

	// RVA: 0xFFFFFFFF75C8C2D4
	private Void set_bubbleUpCallbackCount(Int32 value) { }

	// RVA: 0xFFFFFFFF75C8C2DC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C8C360
	public Void .ctor(EventCallbackList source) { }

	// RVA: 0xFFFFFFFF75C8C400
	public Void AddRange(EventCallbackList list) { }

	// RVA: 0xFFFFFFFF75C8C564
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75C8C5B0
	public EventCallbackFunctorBase get_Item(Int32 i) { }

	// RVA: 0xFFFFFFFF75C8C624
	public Void Clear() { }

}

// Namespace: UnityEngine.UIElements
internal class EventCallbackRegistry
{
	// Fields
	private static readonly EventCallbackListPool s_ListPool; // 0x0
	private EventCallbackList m_Callbacks; // 0x10
	private EventCallbackList m_TemporaryCallbacks; // 0x18
	private Int32 m_IsInvoking; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75C8C82C
	private static EventCallbackList GetCallbackList(EventCallbackList initializer) { }

	// RVA: 0xFFFFFFFF75C8C89C
	private static Void ReleaseCallbackList(EventCallbackList toRelease) { }

	// RVA: 0xFFFFFFFF75C88AFC
	public Void InvokeCallbacks(EventBase evt) { }

	// RVA: 0xFFFFFFFF75C88CAC
	public Boolean HasTrickleDownHandlers() { }

	// RVA: 0xFFFFFFFF75C88CF4
	public Boolean HasBubbleHandlers() { }

	// RVA: 0xFFFFFFFF75C8C90C
	private static Void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IEventHandler
{
	// Methods

	// RVA: -1
	public abstract Void SendEvent(EventBase e) { }

	// RVA: -1
	public abstract Void HandleEvent(EventBase evt) { }

}

// Namespace: UnityEngine.UIElements
public abstract class CallbackEventHandler
{
	// Fields
	private EventCallbackRegistry m_CallbackRegistry; // 0x10

	// Methods

	// RVA: -1
	public abstract Void SendEvent(EventBase e) { }

	// RVA: 0xFFFFFFFF75C889D8
	internal Void HandleEventAtTargetPhase(EventBase evt) { }

	// RVA: 0xFFFFFFFF75C88A34
	public virtual Void HandleEvent(EventBase evt) { }

	// RVA: 0xFFFFFFFF75C88C84
	public Boolean HasTrickleDownHandlers() { }

	// RVA: 0xFFFFFFFF75C88CCC
	public Boolean HasBubbleUpHandlers() { }

	// RVA: 0xFFFFFFFF75C88D14
	protected virtual Void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0xFFFFFFFF75C88D18
	protected virtual Void ExecuteDefaultAction(EventBase evt) { }

}

// Namespace: UnityEngine.UIElements
public abstract class FocusEventBase<T0>
{
	// Fields
	private Focusable <relatedTarget>k__BackingField; // 0x0
	private FocusChangeDirection <direction>k__BackingField; // 0x0
	private FocusController <focusController>k__BackingField; // 0x0

	// Properties
	public Focusable relatedTarget { get; set; }
	private FocusChangeDirection direction { set; }
	protected FocusController focusController { get; set; }

	// Methods

	// RVA: -1
	public Focusable get_relatedTarget() { }

	// RVA: -1
	private Void set_relatedTarget(Focusable value) { }

	// RVA: -1
	private Void set_direction(FocusChangeDirection value) { }

	// RVA: -1
	protected FocusController get_focusController() { }

	// RVA: -1
	private Void set_focusController(FocusController value) { }

	// RVA: -1
	protected override Void Init() { }

	// RVA: -1
	private Void LocalInit() { }

	// RVA: -1
	public static T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController) { }

	// RVA: -1
	protected Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class FocusOutEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C8EA74
	protected override Void Init() { }

	// RVA: 0xFFFFFFFF75C8EAC8
	private Void LocalInit() { }

	// RVA: 0xFFFFFFFF75C8EAD4
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class BlurEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C887C4
	protected internal override Void PreDispatch(IPanel panel) { }

	// RVA: 0xFFFFFFFF75C88990
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class FocusInEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C8E9C0
	protected override Void Init() { }

	// RVA: 0xFFFFFFFF75C8EA14
	private Void LocalInit() { }

	// RVA: 0xFFFFFFFF75C8EA20
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class FocusEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C8E8D0
	protected internal override Void PreDispatch(IPanel panel) { }

	// RVA: 0xFFFFFFFF75C8E978
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public enum PropagationPhase
{
	// Fields
	public Int32 value__; // 0x10
	public const PropagationPhase None = 0;
	public const PropagationPhase TrickleDown = 1;
	public const PropagationPhase AtTarget = 2;
	public const PropagationPhase DefaultActionAtTarget = 5;
	public const PropagationPhase BubbleUp = 3;
	public const PropagationPhase DefaultAction = 4;
}

// Namespace: UnityEngine.UIElements
internal interface IEventDispatchingStrategy
{
	// Methods

	// RVA: -1
	public abstract Boolean CanDispatchEvent(EventBase evt) { }

	// RVA: -1
	public abstract Void DispatchEvent(EventBase evt, IPanel panel) { }

}

// Namespace: UnityEngine.UIElements
internal static class EventDispatchUtilities
{
	// Methods

	// RVA: 0xFFFFFFFF75C89480
	public static Void PropagateEvent(EventBase evt) { }

	// RVA: 0xFFFFFFFF75C89228
	internal static Void PropagateToIMGUIContainer(VisualElement root, EventBase evt) { }

	// RVA: 0xFFFFFFFF75C8CA50
	public static Void ExecuteDefaultAction(EventBase evt, IPanel panel) { }

}

// Namespace: UnityEngine.UIElements
internal class IMGUIEventDispatchingStrategy
{
	// Methods

	// RVA: 0xFFFFFFFF75C90AA4
	public Boolean CanDispatchEvent(EventBase evt) { }

	// RVA: 0xFFFFFFFF75C90B1C
	public Void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0xFFFFFFFF75C8D088
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class KeyboardEventDispatchingStrategy
{
	// Methods

	// RVA: 0xFFFFFFFF75C90C84
	public Boolean CanDispatchEvent(EventBase evt) { }

	// RVA: 0xFFFFFFFF75C90CD8
	public Void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0xFFFFFFFF75C8D070
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IKeyboardEvent
{}

// Namespace: UnityEngine.UIElements
public abstract class KeyboardEventBase<T0>
{
	// Fields
	private EventModifiers <modifiers>k__BackingField; // 0x0
	private Char <character>k__BackingField; // 0x0
	private KeyCode <keyCode>k__BackingField; // 0x0

	// Properties
	protected EventModifiers modifiers { set; }
	protected Char character { set; }
	protected KeyCode keyCode { set; }

	// Methods

	// RVA: -1
	protected Void set_modifiers(EventModifiers value) { }

	// RVA: -1
	protected Void set_character(Char value) { }

	// RVA: -1
	protected Void set_keyCode(KeyCode value) { }

	// RVA: -1
	protected override Void Init() { }

	// RVA: -1
	private Void LocalInit() { }

	// RVA: -1
	public static T GetPooled(Char c, KeyCode keyCode, EventModifiers modifiers) { }

	// RVA: -1
	public static T GetPooled(Event systemEvent) { }

	// RVA: -1
	protected Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class KeyDownEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C90BF4
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class KeyUpEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C90C3C
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class MouseCaptureDispatchingStrategy
{
	// Methods

	// RVA: 0xFFFFFFFF75C91548
	public Boolean CanDispatchEvent(EventBase evt) { }

	// RVA: 0xFFFFFFFF75C915C4
	public Void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0xFFFFFFFF75C8D068
	public Void .ctor() { }

}

// Namespace: 
private enum EventBehavior
{
	// Fields
	public Int32 value__; // 0x10
	public const EventBehavior None = 0;
	public const EventBehavior IsCapturable = 1;
	public const EventBehavior IsSentExclusivelyToCapturingElement = 2;
}

// Namespace: UnityEngine.UIElements
internal class MouseEventDispatchingStrategy
{
	// Methods

	// RVA: 0xFFFFFFFF75C92390
	public Boolean CanDispatchEvent(EventBase evt) { }

	// RVA: 0xFFFFFFFF75C923E4
	public Void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0xFFFFFFFF75C8D080
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IMouseEvent
{
	// Properties
	public abstract EventModifiers modifiers { get; }
	public abstract Vector2 mousePosition { get; }
	public abstract Vector2 mouseDelta { get; }
	public abstract Int32 clickCount { get; }
	public abstract Int32 button { get; }
	public abstract Int32 pressedButtons { get; }

	// Methods

	// RVA: -1
	public abstract EventModifiers get_modifiers() { }

	// RVA: -1
	public abstract Vector2 get_mousePosition() { }

	// RVA: -1
	public abstract Vector2 get_mouseDelta() { }

	// RVA: -1
	public abstract Int32 get_clickCount() { }

	// RVA: -1
	public abstract Int32 get_button() { }

	// RVA: -1
	public abstract Int32 get_pressedButtons() { }

}

// Namespace: UnityEngine.UIElements
internal interface IMouseEventInternal
{
	// Properties
	public abstract Boolean triggeredByOS { get; set; }
	public abstract Boolean recomputeTopElementUnderMouse { get; set; }
	public abstract IPointerEvent sourcePointerEvent { get; set; }

	// Methods

	// RVA: -1
	public abstract Boolean get_triggeredByOS() { }

	// RVA: -1
	public abstract Void set_triggeredByOS(Boolean value) { }

	// RVA: -1
	public abstract Boolean get_recomputeTopElementUnderMouse() { }

	// RVA: -1
	public abstract Void set_recomputeTopElementUnderMouse(Boolean value) { }

	// RVA: -1
	public abstract IPointerEvent get_sourcePointerEvent() { }

	// RVA: -1
	public abstract Void set_sourcePointerEvent(IPointerEvent value) { }

}

// Namespace: UnityEngine.UIElements
public abstract class MouseEventBase<T0>
{
	// Fields
	private EventModifiers <modifiers>k__BackingField; // 0x0
	private Vector2 <mousePosition>k__BackingField; // 0x0
	private Vector2 <localMousePosition>k__BackingField; // 0x0
	private Vector2 <mouseDelta>k__BackingField; // 0x0
	private Int32 <clickCount>k__BackingField; // 0x0
	private Int32 <button>k__BackingField; // 0x0
	private Int32 <pressedButtons>k__BackingField; // 0x0
	private Boolean <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField; // 0x0
	private Boolean <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField; // 0x0
	private IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField; // 0x0

	// Properties
	public EventModifiers modifiers { get; set; }
	public Vector2 mousePosition { get; set; }
	internal Vector2 localMousePosition { set; }
	public Vector2 mouseDelta { get; set; }
	public Int32 clickCount { get; set; }
	public Int32 button { get; set; }
	public Int32 pressedButtons { get; set; }
	private Boolean UnityEngine.UIElements.IMouseEventInternal.triggeredByOS { get; set; }
	private Boolean UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse { get; set; }
	private IPointerEvent UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent { get; set; }
	public override IEventHandler currentTarget { get; set; }

	// Methods

	// RVA: -1
	public EventModifiers get_modifiers() { }

	// RVA: -1
	protected Void set_modifiers(EventModifiers value) { }

	// RVA: -1
	public Vector2 get_mousePosition() { }

	// RVA: -1
	protected Void set_mousePosition(Vector2 value) { }

	// RVA: -1
	internal Void set_localMousePosition(Vector2 value) { }

	// RVA: -1
	public Vector2 get_mouseDelta() { }

	// RVA: -1
	protected Void set_mouseDelta(Vector2 value) { }

	// RVA: -1
	public Int32 get_clickCount() { }

	// RVA: -1
	protected Void set_clickCount(Int32 value) { }

	// RVA: -1
	public Int32 get_button() { }

	// RVA: -1
	protected Void set_button(Int32 value) { }

	// RVA: -1
	public Int32 get_pressedButtons() { }

	// RVA: -1
	protected Void set_pressedButtons(Int32 value) { }

	// RVA: -1
	private Boolean UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS() { }

	// RVA: -1
	private Void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(Boolean value) { }

	// RVA: -1
	private Boolean UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse() { }

	// RVA: -1
	private Void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(Boolean value) { }

	// RVA: -1
	private IPointerEvent UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent() { }

	// RVA: -1
	private Void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(IPointerEvent value) { }

	// RVA: -1
	protected override Void Init() { }

	// RVA: -1
	private Void LocalInit() { }

	// RVA: -1
	public override IEventHandler get_currentTarget() { }

	// RVA: -1
	internal override Void set_currentTarget(IEventHandler value) { }

	// RVA: -1
	protected internal override Void PreDispatch(IPanel panel) { }

	// RVA: -1
	protected internal override Void PostDispatch(IPanel panel) { }

	// RVA: -1
	public static T GetPooled(Event systemEvent) { }

	// RVA: -1
	internal static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition, Boolean recomputeTopElementUnderMouse) { }

	// RVA: -1
	public static T GetPooled(IMouseEvent triggerEvent) { }

	// RVA: -1
	protected static T GetPooled(IPointerEvent pointerEvent) { }

	// RVA: -1
	protected Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class MouseDownEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C91EE8
	private static MouseDownEvent MakeFromPointerEvent(IPointerEvent pointerEvent) { }

	// RVA: 0xFFFFFFFF75C92084
	internal static MouseDownEvent GetPooled(PointerDownEvent pointerEvent) { }

	// RVA: 0xFFFFFFFF75C92088
	internal static MouseDownEvent GetPooled(PointerMoveEvent pointerEvent) { }

	// RVA: 0xFFFFFFFF75C9208C
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class MouseUpEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C9303C
	private static MouseUpEvent MakeFromPointerEvent(IPointerEvent pointerEvent) { }

	// RVA: 0xFFFFFFFF75C931D8
	internal static MouseUpEvent GetPooled(PointerUpEvent pointerEvent) { }

	// RVA: 0xFFFFFFFF75C931DC
	internal static MouseUpEvent GetPooled(PointerMoveEvent pointerEvent) { }

	// RVA: 0xFFFFFFFF75C931E0
	internal static MouseUpEvent GetPooled(PointerCancelEvent pointerEvent) { }

	// RVA: 0xFFFFFFFF75C931E4
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class MouseMoveEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C92F1C
	internal static MouseMoveEvent GetPooled(PointerMoveEvent pointerEvent) { }

	// RVA: 0xFFFFFFFF75C92F64
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class ContextClickEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C89E60
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class WheelEvent
{
	// Fields
	private Vector3 <delta>k__BackingField; // 0xB0

	// Properties
	private Vector3 delta { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C9D4CC
	private Void set_delta(Vector3 value) { }

	// RVA: 0xFFFFFFFF75C9B90C
	public static WheelEvent GetPooled(Event systemEvent) { }

	// RVA: 0xFFFFFFFF75C9D4D8
	protected override Void Init() { }

	// RVA: 0xFFFFFFFF75C9D528
	private Void LocalInit() { }

	// RVA: 0xFFFFFFFF75C9D570
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class MouseEnterEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C920D4
	protected override Void Init() { }

	// RVA: 0xFFFFFFFF75C92128
	private Void LocalInit() { }

	// RVA: 0xFFFFFFFF75C92134
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class MouseLeaveEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C92A8C
	protected override Void Init() { }

	// RVA: 0xFFFFFFFF75C92AE0
	private Void LocalInit() { }

	// RVA: 0xFFFFFFFF75C92AEC
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class MouseEnterWindowEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C92188
	protected override Void Init() { }

	// RVA: 0xFFFFFFFF75C921DC
	private Void LocalInit() { }

	// RVA: 0xFFFFFFFF75C921E8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C9223C
	protected internal override Void PostDispatch(IPanel panel) { }

}

// Namespace: UnityEngine.UIElements
public class MouseLeaveWindowEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C92B40
	protected override Void Init() { }

	// RVA: 0xFFFFFFFF75C92B90
	private Void LocalInit() { }

	// RVA: 0xFFFFFFFF75C92C38
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C92C88
	public static MouseLeaveWindowEvent GetPooled(Event systemEvent) { }

	// RVA: 0xFFFFFFFF75C92DC8
	protected internal override Void PostDispatch(IPanel panel) { }

}

// Namespace: UnityEngine.UIElements
public class MouseOverEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C92FF4
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class MouseOutEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C92FAC
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class MouseEventsHelper
{
	// Methods

	// RVA: -1
	internal static Void SendEnterLeave(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) { }

	// RVA: 0xFFFFFFFF75C8B340
	internal static Void SendMouseOverMouseOut(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) { }

}

// Namespace: UnityEngine.UIElements
internal static class PointerEventsHelper
{
	// Methods

	// RVA: -1
	internal static Void SendEnterLeave(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C8B0C0
	internal static Void SendOverOut(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, Int32 pointerId) { }

}

// Namespace: UnityEngine.UIElements
internal class PointerCaptureDispatchingStrategy
{
	// Methods

	// RVA: 0xFFFFFFFF75C946EC
	public Boolean CanDispatchEvent(EventBase evt) { }

	// RVA: 0xFFFFFFFF75C94740
	public Void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0xFFFFFFFF75C8D060
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class PointerDeviceState
{
	// Fields
	private static Vector2[] m_Positions; // 0x0
	private static IPanel[] m_Panels; // 0x8
	private static Int32[] m_PressedButtons; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C95A64
	public static Void SavePointerPosition(Int32 pointerId, Vector2 position, IPanel panel) { }

	// RVA: 0xFFFFFFFF75C8A78C
	public static Void PressButton(Int32 pointerId, Int32 buttonId) { }

	// RVA: 0xFFFFFFFF75C8A36C
	public static Void ReleaseButton(Int32 pointerId, Int32 buttonId) { }

	// RVA: 0xFFFFFFFF75C92D3C
	public static Void ReleaseAllButtons(Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C8B034
	public static Vector2 GetPointerPosition(Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C95B30
	public static Int32 GetPressedButtons(Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C95BBC
	internal static Boolean HasAdditionalPressedButtons(Int32 pointerId, Int32 exceptButtonId) { }

	// RVA: 0xFFFFFFFF75C95C64
	private static Void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class PointerEventDispatchingStrategy
{
	// Methods

	// RVA: 0xFFFFFFFF75C96200
	public Boolean CanDispatchEvent(EventBase evt) { }

	// RVA: 0xFFFFFFFF75C96254
	public virtual Void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0xFFFFFFFF75C8D078
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public static class PointerType
{
	// Fields
	public static readonly String mouse; // 0x0
	public static readonly String touch; // 0x8
	public static readonly String pen; // 0x10
	public static readonly String unknown; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75C96DD4
	internal static String GetPointerType(Int32 pointerId) { }

	// RVA: 0xFFFFFFFF75C944A8
	internal static Boolean IsDirectManipulationDevice(String pointerType) { }

	// RVA: 0xFFFFFFFF75C96E94
	private static Void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public static class PointerId
{
	// Fields
	public static readonly Int32 maxPointers; // 0x0
	public static readonly Int32 invalidPointerId; // 0x4
	public static readonly Int32 mousePointerId; // 0x8
	public static readonly Int32 touchPointerIdBase; // 0xC
	public static readonly Int32 touchPointerCount; // 0x10
	public static readonly Int32 penPointerIdBase; // 0x14
	public static readonly Int32 penPointerCount; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75C96688
	private static Void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IPointerEvent
{
	// Properties
	public abstract Int32 pointerId { get; }
	public abstract String pointerType { get; }
	public abstract Boolean isPrimary { get; }
	public abstract Int32 button { get; }
	public abstract Int32 pressedButtons { get; }
	public abstract Vector3 position { get; }
	public abstract Vector3 localPosition { get; }
	public abstract Vector3 deltaPosition { get; }
	public abstract Single deltaTime { get; }
	public abstract Int32 clickCount { get; }
	public abstract Single pressure { get; }
	public abstract Single tangentialPressure { get; }
	public abstract Single altitudeAngle { get; }
	public abstract Single azimuthAngle { get; }
	public abstract Single twist { get; }
	public abstract Vector2 radius { get; }
	public abstract Vector2 radiusVariance { get; }
	public abstract EventModifiers modifiers { get; }

	// Methods

	// RVA: -1
	public abstract Int32 get_pointerId() { }

	// RVA: -1
	public abstract String get_pointerType() { }

	// RVA: -1
	public abstract Boolean get_isPrimary() { }

	// RVA: -1
	public abstract Int32 get_button() { }

	// RVA: -1
	public abstract Int32 get_pressedButtons() { }

	// RVA: -1
	public abstract Vector3 get_position() { }

	// RVA: -1
	public abstract Vector3 get_localPosition() { }

	// RVA: -1
	public abstract Vector3 get_deltaPosition() { }

	// RVA: -1
	public abstract Single get_deltaTime() { }

	// RVA: -1
	public abstract Int32 get_clickCount() { }

	// RVA: -1
	public abstract Single get_pressure() { }

	// RVA: -1
	public abstract Single get_tangentialPressure() { }

	// RVA: -1
	public abstract Single get_altitudeAngle() { }

	// RVA: -1
	public abstract Single get_azimuthAngle() { }

	// RVA: -1
	public abstract Single get_twist() { }

	// RVA: -1
	public abstract Vector2 get_radius() { }

	// RVA: -1
	public abstract Vector2 get_radiusVariance() { }

	// RVA: -1
	public abstract EventModifiers get_modifiers() { }

}

// Namespace: UnityEngine.UIElements
internal interface IPointerEventInternal
{
	// Properties
	public abstract Boolean triggeredByOS { get; set; }
	public abstract Boolean recomputeTopElementUnderPointer { get; set; }

	// Methods

	// RVA: -1
	public abstract Boolean get_triggeredByOS() { }

	// RVA: -1
	public abstract Void set_triggeredByOS(Boolean value) { }

	// RVA: -1
	public abstract Boolean get_recomputeTopElementUnderPointer() { }

	// RVA: -1
	public abstract Void set_recomputeTopElementUnderPointer(Boolean value) { }

}

// Namespace: UnityEngine.UIElements
public abstract class PointerEventBase<T0>
{
	// Fields
	private Int32 <pointerId>k__BackingField; // 0x0
	private String <pointerType>k__BackingField; // 0x0
	private Boolean <isPrimary>k__BackingField; // 0x0
	private Int32 <button>k__BackingField; // 0x0
	private Int32 <pressedButtons>k__BackingField; // 0x0
	private Vector3 <position>k__BackingField; // 0x0
	private Vector3 <localPosition>k__BackingField; // 0x0
	private Vector3 <deltaPosition>k__BackingField; // 0x0
	private Single <deltaTime>k__BackingField; // 0x0
	private Int32 <clickCount>k__BackingField; // 0x0
	private Single <pressure>k__BackingField; // 0x0
	private Single <tangentialPressure>k__BackingField; // 0x0
	private Single <altitudeAngle>k__BackingField; // 0x0
	private Single <azimuthAngle>k__BackingField; // 0x0
	private Single <twist>k__BackingField; // 0x0
	private Vector2 <radius>k__BackingField; // 0x0
	private Vector2 <radiusVariance>k__BackingField; // 0x0
	private EventModifiers <modifiers>k__BackingField; // 0x0
	private Boolean <UnityEngine.UIElements.IPointerEventInternal.triggeredByOS>k__BackingField; // 0x0
	private Boolean <UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer>k__BackingField; // 0x0

	// Properties
	public Int32 pointerId { get; set; }
	public String pointerType { get; set; }
	public Boolean isPrimary { get; set; }
	public Int32 button { get; set; }
	public Int32 pressedButtons { get; set; }
	public Vector3 position { get; set; }
	public Vector3 localPosition { get; set; }
	public Vector3 deltaPosition { get; set; }
	public Single deltaTime { get; set; }
	public Int32 clickCount { get; set; }
	public Single pressure { get; set; }
	public Single tangentialPressure { get; set; }
	public Single altitudeAngle { get; set; }
	public Single azimuthAngle { get; set; }
	public Single twist { get; set; }
	public Vector2 radius { get; set; }
	public Vector2 radiusVariance { get; set; }
	public EventModifiers modifiers { get; set; }
	private Boolean UnityEngine.UIElements.IPointerEventInternal.triggeredByOS { get; set; }
	private Boolean UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer { get; set; }
	public override IEventHandler currentTarget { get; set; }

	// Methods

	// RVA: -1
	public Int32 get_pointerId() { }

	// RVA: -1
	protected Void set_pointerId(Int32 value) { }

	// RVA: -1
	public String get_pointerType() { }

	// RVA: -1
	protected Void set_pointerType(String value) { }

	// RVA: -1
	public Boolean get_isPrimary() { }

	// RVA: -1
	protected Void set_isPrimary(Boolean value) { }

	// RVA: -1
	public Int32 get_button() { }

	// RVA: -1
	protected Void set_button(Int32 value) { }

	// RVA: -1
	public Int32 get_pressedButtons() { }

	// RVA: -1
	protected Void set_pressedButtons(Int32 value) { }

	// RVA: -1
	public Vector3 get_position() { }

	// RVA: -1
	protected Void set_position(Vector3 value) { }

	// RVA: -1
	public Vector3 get_localPosition() { }

	// RVA: -1
	protected Void set_localPosition(Vector3 value) { }

	// RVA: -1
	public Vector3 get_deltaPosition() { }

	// RVA: -1
	protected Void set_deltaPosition(Vector3 value) { }

	// RVA: -1
	public Single get_deltaTime() { }

	// RVA: -1
	protected Void set_deltaTime(Single value) { }

	// RVA: -1
	public Int32 get_clickCount() { }

	// RVA: -1
	protected Void set_clickCount(Int32 value) { }

	// RVA: -1
	public Single get_pressure() { }

	// RVA: -1
	protected Void set_pressure(Single value) { }

	// RVA: -1
	public Single get_tangentialPressure() { }

	// RVA: -1
	protected Void set_tangentialPressure(Single value) { }

	// RVA: -1
	public Single get_altitudeAngle() { }

	// RVA: -1
	protected Void set_altitudeAngle(Single value) { }

	// RVA: -1
	public Single get_azimuthAngle() { }

	// RVA: -1
	protected Void set_azimuthAngle(Single value) { }

	// RVA: -1
	public Single get_twist() { }

	// RVA: -1
	protected Void set_twist(Single value) { }

	// RVA: -1
	public Vector2 get_radius() { }

	// RVA: -1
	protected Void set_radius(Vector2 value) { }

	// RVA: -1
	public Vector2 get_radiusVariance() { }

	// RVA: -1
	protected Void set_radiusVariance(Vector2 value) { }

	// RVA: -1
	public EventModifiers get_modifiers() { }

	// RVA: -1
	protected Void set_modifiers(EventModifiers value) { }

	// RVA: -1
	private Boolean UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS() { }

	// RVA: -1
	private Void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(Boolean value) { }

	// RVA: -1
	private Boolean UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer() { }

	// RVA: -1
	private Void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(Boolean value) { }

	// RVA: -1
	protected override Void Init() { }

	// RVA: -1
	private Void LocalInit() { }

	// RVA: -1
	public override IEventHandler get_currentTarget() { }

	// RVA: -1
	internal override Void set_currentTarget(IEventHandler value) { }

	// RVA: -1
	private static Boolean IsMouse(Event systemEvent) { }

	// RVA: -1
	public static T GetPooled(Event systemEvent) { }

	// RVA: -1
	internal static T GetPooled(IPointerEvent triggerEvent, Vector2 position, Int32 pointerId) { }

	// RVA: -1
	public static T GetPooled(IPointerEvent triggerEvent) { }

	// RVA: -1
	protected internal override Void PreDispatch(IPanel panel) { }

	// RVA: -1
	protected internal override Void PostDispatch(IPanel panel) { }

	// RVA: -1
	protected Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerDownEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C95E1C
	protected override Void Init() { }

	// RVA: 0xFFFFFFFF75C95E6C
	private Void LocalInit() { }

	// RVA: 0xFFFFFFFF75C95F0C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C95F5C
	protected internal override Void PostDispatch(IPanel panel) { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerMoveEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C967A0
	protected override Void Init() { }

	// RVA: 0xFFFFFFFF75C967F0
	private Void LocalInit() { }

	// RVA: 0xFFFFFFFF75C96890
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C968E0
	protected internal override Void PostDispatch(IPanel panel) { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerUpEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C96F50
	protected override Void Init() { }

	// RVA: 0xFFFFFFFF75C96FA0
	private Void LocalInit() { }

	// RVA: 0xFFFFFFFF75C97040
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C97090
	protected internal override Void PostDispatch(IPanel panel) { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerCancelEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C940E4
	protected override Void Init() { }

	// RVA: 0xFFFFFFFF75C94134
	private Void LocalInit() { }

	// RVA: 0xFFFFFFFF75C941DC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C9422C
	protected internal override Void PostDispatch(IPanel panel) { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerEnterEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C9614C
	protected override Void Init() { }

	// RVA: 0xFFFFFFFF75C961A0
	private Void LocalInit() { }

	// RVA: 0xFFFFFFFF75C961AC
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerLeaveEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C966EC
	protected override Void Init() { }

	// RVA: 0xFFFFFFFF75C96740
	private Void LocalInit() { }

	// RVA: 0xFFFFFFFF75C9674C
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerOverEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C96D8C
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerOutEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C96D44
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class PropagationPaths
{
	// Fields
	private static readonly ObjectPool<T0> s_Pool; // 0x0
	public readonly List<T0> trickleDownPath; // 0x10
	public readonly List<T0> targetElements; // 0x18
	public readonly List<T0> bubbleUpPath; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75C9732C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C8B988
	internal static PropagationPaths Copy(PropagationPaths paths) { }

	// RVA: 0xFFFFFFFF75C8B77C
	public static PropagationPaths Build(VisualElement elem, Type pathTypesRequested) { }

	// RVA: 0xFFFFFFFF75C8C0E8
	public Void Release() { }

	// RVA: 0xFFFFFFFF75C97404
	private static Void .cctor() { }

}

// Namespace: 
public enum Type
{
	// Fields
	public Int32 value__; // 0x10
	public const Type None = 0;
	public const Type TrickleDown = 1;
	public const Type BubbleUp = 2;
}

// Namespace: UnityEngine.UIElements
public class IMGUIEvent
{
	// Methods

	// RVA: 0xFFFFFFFF75C90940
	public static IMGUIEvent GetPooled(Event systemEvent) { }

	// RVA: 0xFFFFFFFF75C909C8
	protected override Void Init() { }

	// RVA: 0xFFFFFFFF75C90A1C
	private Void LocalInit() { }

	// RVA: 0xFFFFFFFF75C90A28
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal struct EventDebuggerLogIMGUICall
{
	// Methods

	// RVA: 0xFFFFFFFF7115316C
	public Void .ctor(EventBase evt) { }

	// RVA: 0xFFFFFFFF71153170
	public Void Dispose() { }

}

// Namespace: UnityEngine.UIElements
internal struct EventDebuggerLogExecuteDefaultAction
{
	// Methods

	// RVA: 0xFFFFFFFF71153164
	public Void .ctor(EventBase evt) { }

	// RVA: 0xFFFFFFFF71153168
	public Void Dispose() { }

}

// Namespace: UnityEngine.UIElements
internal class EventDebugger
{
	// Methods

	// RVA: 0xFFFFFFFF75C8B8F8
	public static Void LogPropagationPaths(EventBase evt, PropagationPaths paths) { }

}

// Namespace: UnityEngine.UIElements
internal struct ComputedStyle
{
	// Fields
	private VisualElement m_Element; // 0x10

	// Properties
	private VisualElementStylesData stylesData { get; }
	private InheritedStylesData inheritedStylesData { get; }
	public StyleEnum<T0> overflow { get; }
	public StyleEnum<T0> display { get; }
	public StyleEnum<T0> visibility { get; }

	// Methods

	// RVA: 0xFFFFFFFF711530D0
	private VisualElementStylesData get_stylesData() { }

	// RVA: 0xFFFFFFFF711530F0
	private InheritedStylesData get_inheritedStylesData() { }

	// RVA: 0xFFFFFFFF71153110
	public StyleEnum<T0> get_overflow() { }

	// RVA: 0xFFFFFFFF7115312C
	public StyleEnum<T0> get_display() { }

	// RVA: 0xFFFFFFFF71153148
	public StyleEnum<T0> get_visibility() { }

}

// Namespace: UnityEngine.UIElements
public interface IResolvedStyle
{
	// Properties
	public abstract Visibility visibility { get; }
	public abstract DisplayStyle display { get; }

	// Methods

	// RVA: -1
	public abstract Visibility get_visibility() { }

	// RVA: -1
	public abstract DisplayStyle get_display() { }

}

// Namespace: UnityEngine.UIElements
public enum LengthUnit
{
	// Fields
	public Int32 value__; // 0x10
	public const LengthUnit Pixel = 0;
	public const LengthUnit Percent = 1;
}

// Namespace: UnityEngine.UIElements
public struct Length
{
	// Fields
	private Single m_Value; // 0x10
	private LengthUnit m_Unit; // 0x14

	// Properties
	public Single value { get; }
	public LengthUnit unit { get; }

	// Methods

	// RVA: 0xFFFFFFFF7115334C
	public Single get_value() { }

	// RVA: 0xFFFFFFFF71153354
	public LengthUnit get_unit() { }

	// RVA: 0xFFFFFFFF7115335C
	public Void .ctor(Single value) { }

	// RVA: 0xFFFFFFFF71153368
	public Void .ctor(Single value, LengthUnit unit) { }

	// RVA: 0xFFFFFFFF75C90FB8
	public static Boolean op_Equality(Length lhs, Length rhs) { }

	// RVA: 0xFFFFFFFF71153374
	public Boolean Equals(Length other) { }

	// RVA: 0xFFFFFFFF71153394
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7115339C
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF711533EC
	public override String ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleColor
{
	// Fields
	private StyleKeyword m_Keyword; // 0x10
	private Color m_Value; // 0x14
	private Int32 m_Specificity; // 0x24

	// Properties
	public Color value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0xFFFFFFFF711533F4
	public Color get_value() { }

	// RVA: 0xFFFFFFFF71153410
	public StyleKeyword get_keyword() { }

	// RVA: 0xFFFFFFFF71153418
	public Void .ctor(Color v) { }

	// RVA: 0xFFFFFFFF7115342C
	internal Void .ctor(Color v, StyleKeyword keyword) { }

	// RVA: 0xFFFFFFFF75C974F0
	public static Boolean op_Equality(StyleColor lhs, StyleColor rhs) { }

	// RVA: 0xFFFFFFFF75C97520
	public static StyleColor op_Implicit(Color v) { }

	// RVA: 0xFFFFFFFF71153440
	public Boolean Equals(StyleColor other) { }

	// RVA: 0xFFFFFFFF71153474
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF7115347C
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF711534E8
	public override String ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleEnum<T0>
{
	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private T m_Value; // 0x0
	private Int32 m_Specificity; // 0x0

	// Properties
	public T value { get; }
	internal Int32 specificity { set; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: -1
	public T get_value() { }

	// RVA: -1
	internal Void set_specificity(Int32 value) { }

	// RVA: -1
	public StyleKeyword get_keyword() { }

	// RVA: -1
	internal Void .ctor(T v, StyleKeyword keyword) { }

	// RVA: -1
	public static Boolean op_Equality(StyleEnum<T0> lhs, StyleEnum<T0> rhs) { }

	// RVA: -1
	public Boolean Equals(StyleEnum<T0> other) { }

	// RVA: -1
	public override Boolean Equals(Object obj) { }

	// RVA: -1
	public override Int32 GetHashCode() { }

	// RVA: -1
	public override String ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleFloat
{
	// Fields
	private StyleKeyword m_Keyword; // 0x10
	private Single m_Value; // 0x14
	private Int32 m_Specificity; // 0x18

	// Properties
	public Single value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0xFFFFFFFF711534F0
	public Single get_value() { }

	// RVA: 0xFFFFFFFF71153508
	public StyleKeyword get_keyword() { }

	// RVA: 0xFFFFFFFF71153510
	public Void .ctor(Single v) { }

	// RVA: 0xFFFFFFFF71153520
	internal Void .ctor(Single v, StyleKeyword keyword) { }

	// RVA: 0xFFFFFFFF75C97728
	public static Boolean op_Equality(StyleFloat lhs, StyleFloat rhs) { }

	// RVA: 0xFFFFFFFF75C97748
	public static StyleFloat op_Implicit(Single v) { }

	// RVA: 0xFFFFFFFF71153530
	public Boolean Equals(StyleFloat other) { }

	// RVA: 0xFFFFFFFF71153550
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF71153558
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF711535C4
	public override String ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleFont
{
	// Fields
	private StyleKeyword m_Keyword; // 0x10
	private Font m_Value; // 0x18
	private Int32 m_Specificity; // 0x20

	// Properties
	public Font value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0xFFFFFFFF71153608
	public Font get_value() { }

	// RVA: 0xFFFFFFFF71153620
	public StyleKeyword get_keyword() { }

	// RVA: 0xFFFFFFFF75C97908
	public static Boolean op_Equality(StyleFont lhs, StyleFont rhs) { }

	// RVA: 0xFFFFFFFF71153628
	public Boolean Equals(StyleFont other) { }

	// RVA: 0xFFFFFFFF7115368C
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF71153694
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7115369C
	public override String ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleInt
{
	// Fields
	private StyleKeyword m_Keyword; // 0x10
	private Int32 m_Value; // 0x14
	private Int32 m_Specificity; // 0x18

	// Properties
	public Int32 value { get; }
	internal Int32 specificity { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0xFFFFFFFF711536A4
	public Int32 get_value() { }

	// RVA: 0xFFFFFFFF711536BC
	internal Int32 get_specificity() { }

	// RVA: 0xFFFFFFFF711536C4
	public StyleKeyword get_keyword() { }

	// RVA: 0xFFFFFFFF711536CC
	public Void .ctor(Int32 v) { }

	// RVA: 0xFFFFFFFF711536D8
	internal Void .ctor(Int32 v, StyleKeyword keyword) { }

	// RVA: 0xFFFFFFFF75C97BDC
	public static Boolean op_Equality(StyleInt lhs, StyleInt rhs) { }

	// RVA: 0xFFFFFFFF75C97BE8
	public static StyleInt op_Implicit(Int32 v) { }

	// RVA: 0xFFFFFFFF711536E4
	public Boolean Equals(StyleInt other) { }

	// RVA: 0xFFFFFFFF711536F4
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF711536FC
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF71153768
	public override String ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleLength
{
	// Fields
	private StyleKeyword m_Keyword; // 0x10
	private Length m_Value; // 0x14
	private Int32 m_Specificity; // 0x1C

	// Properties
	public Length value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0xFFFFFFFF71153770
	public Length get_value() { }

	// RVA: 0xFFFFFFFF71153788
	public StyleKeyword get_keyword() { }

	// RVA: 0xFFFFFFFF71153790
	internal Void .ctor(Length v, StyleKeyword keyword) { }

	// RVA: 0xFFFFFFFF75C97D98
	public static Boolean op_Equality(StyleLength lhs, StyleLength rhs) { }

	// RVA: 0xFFFFFFFF711537A0
	public Boolean Equals(StyleLength other) { }

	// RVA: 0xFFFFFFFF711537E8
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF711537F0
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF711537F8
	public override String ToString() { }

}

// Namespace: UnityEngine.UIElements
internal interface IStyleValue<T0>
{
	// Properties
	public abstract T value { get; }
	public abstract StyleKeyword keyword { get; }

	// Methods

	// RVA: -1
	public abstract T get_value() { }

	// RVA: -1
	public abstract StyleKeyword get_keyword() { }

}

// Namespace: UnityEngine.UIElements
public enum StyleKeyword
{
	// Fields
	public Int32 value__; // 0x10
	public const StyleKeyword Undefined = 0;
	public const StyleKeyword Null = 1;
	public const StyleKeyword Auto = 2;
	public const StyleKeyword None = 3;
	public const StyleKeyword Initial = 4;
}

// Namespace: UnityEngine.UIElements
internal static class StyleValueExtensions
{
	// Methods

	// RVA: -1
	internal static StyleEnum<T0> ToStyleEnum(StyleInt styleInt, T value) { }

	// RVA: 0xFFFFFFFF75C9A360
	internal static StyleLength ToStyleLength(StyleValue styleValue) { }

	// RVA: 0xFFFFFFFF75C9A36C
	internal static StyleFloat ToStyleFloat(StyleValue styleValue) { }

	// RVA: -1
	internal static String DebugString(IStyleValue<T0> styleValue) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class Utility
{
	// Fields
	private static Action<T0> GraphicsResourcesRecreate; // 0x0
	private static Action EngineUpdate; // 0x8
	private static Action FlushPendingResources; // 0x10
	private static ProfilerMarker s_MarkerRaiseEngineUpdate; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75C9BA70
	internal static Void RaiseGraphicsResourcesRecreate(Boolean recreate) { }

	// RVA: 0xFFFFFFFF75C9BAF0
	internal static Void RaiseEngineUpdate() { }

	// RVA: 0xFFFFFFFF75C9BB64
	internal static Void RaiseFlushPendingResources() { }

	// RVA: 0xFFFFFFFF75C9BBD8
	private static Void .cctor() { }

}

// Namespace: 
public class GPUBuffer<T0>
{
	// Fields
	private IntPtr buffer; // 0x0
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal class InheritedStylesData
{
	// Fields
	public static readonly InheritedStylesData none; // 0x0
	public StyleColor color; // 0x10
	public StyleFont font; // 0x28
	public StyleLength fontSize; // 0x40
	public StyleInt unityFontStyle; // 0x50
	public StyleInt unityTextAlign; // 0x5C
	public StyleInt visibility; // 0x68
	public StyleInt whiteSpace; // 0x74

	// Methods

	// RVA: 0xFFFFFFFF75C97FC8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C9815C
	public Boolean Equals(InheritedStylesData other) { }

	// RVA: 0xFFFFFFFF75C9829C
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75C98334
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75C984CC
	private static Void .cctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal class StyleValuePropertyReader
{
	// Methods

	// RVA: 0xFFFFFFFF75C9A004
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSheetCache
{
	// Fields
	private static SheetHandleKeyComparer s_Comparer; // 0x0
	private static Dictionary<T0, T1> s_EnumToIntCache; // 0x8
	private static Dictionary<T0, T1> s_RulePropertyIDsCache; // 0x10
	private static Dictionary<T0, T1> s_NameToIDCache; // 0x18
	private static StyleValue[] s_InitialStyleValues; // 0x20
	private static Dictionary<T0, T1> s_DeprecatedNames; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75C98528
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C9807C
	internal static StyleValue GetInitialValue(StylePropertyID propertyId) { }

}

// Namespace: 
private struct SheetHandleKey
{
	// Fields
	public readonly Int32 sheetInstanceID; // 0x10
	public readonly Int32 index; // 0x14
}

// Namespace: 
private class SheetHandleKeyComparer
{
	// Methods

	// RVA: 0xFFFFFFFF75C99FAC
	public Boolean Equals(SheetHandleKey x, SheetHandleKey y) { }

	// RVA: 0xFFFFFFFF75C99FB8
	public Int32 GetHashCode(SheetHandleKey key) { }

	// RVA: 0xFFFFFFFF75C99F48
	public Void .ctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct StyleValue
{
	// Fields
	public StylePropertyID id; // 0x10
	public StyleKeyword keyword; // 0x14
	public Single number; // 0x18
	public Length length; // 0x18
	public Color color; // 0x18
	public GCHandle resource; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75C99F98
	public static StyleValue Create(StylePropertyID id) { }

	// RVA: 0xFFFFFFFF75C99F7C
	public static StyleValue Create(StylePropertyID id, StyleKeyword keyword) { }

	// RVA: 0xFFFFFFFF75C99F50
	public static StyleValue Create(StylePropertyID id, Single number) { }

	// RVA: 0xFFFFFFFF75C99F64
	public static StyleValue Create(StylePropertyID id, Int32 number) { }

	// RVA: 0xFFFFFFFF75C99F88
	public static StyleValue Create(StylePropertyID id, Color color) { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal enum StylePropertyID
{
	// Fields
	public Int32 value__; // 0x10
	public const StylePropertyID Unknown = 4294967295;
	public const StylePropertyID MarginLeft = 0;
	public const StylePropertyID MarginTop = 1;
	public const StylePropertyID MarginRight = 2;
	public const StylePropertyID MarginBottom = 3;
	public const StylePropertyID PaddingLeft = 4;
	public const StylePropertyID PaddingTop = 5;
	public const StylePropertyID PaddingRight = 6;
	public const StylePropertyID PaddingBottom = 7;
	public const StylePropertyID Position = 8;
	public const StylePropertyID PositionLeft = 9;
	public const StylePropertyID PositionTop = 10;
	public const StylePropertyID PositionRight = 11;
	public const StylePropertyID PositionBottom = 12;
	public const StylePropertyID Width = 13;
	public const StylePropertyID Height = 14;
	public const StylePropertyID MinWidth = 15;
	public const StylePropertyID MinHeight = 16;
	public const StylePropertyID MaxWidth = 17;
	public const StylePropertyID MaxHeight = 18;
	public const StylePropertyID FlexBasis = 19;
	public const StylePropertyID FlexGrow = 20;
	public const StylePropertyID FlexShrink = 21;
	public const StylePropertyID BorderLeftColor = 22;
	public const StylePropertyID BorderTopColor = 23;
	public const StylePropertyID BorderRightColor = 24;
	public const StylePropertyID BorderBottomColor = 25;
	public const StylePropertyID BorderLeftWidth = 26;
	public const StylePropertyID BorderTopWidth = 27;
	public const StylePropertyID BorderRightWidth = 28;
	public const StylePropertyID BorderBottomWidth = 29;
	public const StylePropertyID BorderTopLeftRadius = 30;
	public const StylePropertyID BorderTopRightRadius = 31;
	public const StylePropertyID BorderBottomRightRadius = 32;
	public const StylePropertyID BorderBottomLeftRadius = 33;
	public const StylePropertyID FlexDirection = 34;
	public const StylePropertyID FlexWrap = 35;
	public const StylePropertyID JustifyContent = 36;
	public const StylePropertyID AlignContent = 37;
	public const StylePropertyID AlignSelf = 38;
	public const StylePropertyID AlignItems = 39;
	public const StylePropertyID UnityTextAlign = 40;
	public const StylePropertyID WhiteSpace = 41;
	public const StylePropertyID Font = 42;
	public const StylePropertyID FontSize = 43;
	public const StylePropertyID FontStyleAndWeight = 44;
	public const StylePropertyID BackgroundScaleMode = 45;
	public const StylePropertyID Visibility = 46;
	public const StylePropertyID Overflow = 47;
	public const StylePropertyID OverflowClipBox = 48;
	public const StylePropertyID Display = 49;
	public const StylePropertyID BackgroundImage = 50;
	public const StylePropertyID Color = 51;
	public const StylePropertyID BackgroundColor = 52;
	public const StylePropertyID BackgroundImageTintColor = 53;
	public const StylePropertyID SliceLeft = 54;
	public const StylePropertyID SliceTop = 55;
	public const StylePropertyID SliceRight = 56;
	public const StylePropertyID SliceBottom = 57;
	public const StylePropertyID Opacity = 58;
	public const StylePropertyID BorderColor = 59;
	public const StylePropertyID BorderRadius = 60;
	public const StylePropertyID BorderWidth = 61;
	public const StylePropertyID Flex = 62;
	public const StylePropertyID Margin = 63;
	public const StylePropertyID Padding = 64;
	public const StylePropertyID Cursor = 65;
	public const StylePropertyID Custom = 66;
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal class VisualElementStylesData
{
	// Fields
	private static StyleValuePropertyReader s_StyleValuePropertyReader; // 0x0
	public static readonly VisualElementStylesData none; // 0x8
	internal readonly Boolean isShared; // 0x10
	internal StyleLength width; // 0x14
	internal StyleLength height; // 0x24
	internal StyleLength maxWidth; // 0x34
	internal StyleLength maxHeight; // 0x44
	internal StyleLength minWidth; // 0x54
	internal StyleLength minHeight; // 0x64
	internal StyleLength flexBasis; // 0x74
	internal StyleFloat flexShrink; // 0x84
	internal StyleFloat flexGrow; // 0x90
	internal StyleInt overflow; // 0x9C
	internal StyleLength left; // 0xA8
	internal StyleLength top; // 0xB8
	internal StyleLength right; // 0xC8
	internal StyleLength bottom; // 0xD8
	internal StyleInt alignSelf; // 0xE8
	internal StyleColor color; // 0xF4
	internal StyleColor unityBackgroundImageTintColor; // 0x10C
	internal StyleInt alignItems; // 0x124
	internal StyleInt alignContent; // 0x130
	internal StyleColor borderLeftColor; // 0x13C
	internal StyleColor borderTopColor; // 0x154
	internal StyleColor borderRightColor; // 0x16C
	internal StyleColor borderBottomColor; // 0x184
	internal StyleFloat opacity; // 0x19C
	internal StyleInt visibility; // 0x1A8
	internal StyleInt display; // 0x1B4
	internal Single dpiScaling; // 0x1C0

	// Methods

	// RVA: 0xFFFFFFFF75C9A00C
	public Void .ctor(Boolean isShared) { }

	// RVA: 0xFFFFFFFF75C9A378
	private static Void .cctor() { }

}


