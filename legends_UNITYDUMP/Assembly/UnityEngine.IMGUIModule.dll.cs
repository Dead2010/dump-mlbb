// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public sealed class Event
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private static Event s_Current; // 0x0
	private static Event s_MasterEvent; // 0x8

	// Properties
	public EventType rawType { get; }
	public Vector2 mousePosition { get; set; }
	public Vector2 delta { get; }
	public PointerType pointerType { get; }
	public Int32 button { get; }
	public EventModifiers modifiers { get; set; }
	public Single pressure { get; }
	public Int32 clickCount { get; }
	public Char character { get; set; }
	public KeyCode keyCode { get; set; }
	public Int32 displayIndex { get; set; }
	public EventType type { get; set; }
	public String commandName { get; set; }
	public Boolean shift { get; }
	public Boolean control { get; }
	public Boolean alt { get; }
	public Boolean command { get; }
	public static Event current { get; set; }
	public Boolean isKey { get; }
	public Boolean isMouse { get; }
	internal Boolean isDirectManipulationDevice { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C4D200
	public EventType get_rawType() { }

	// RVA: 0xFFFFFFFF75C4D240
	public Vector2 get_mousePosition() { }

	// RVA: 0xFFFFFFFF75C4D2E8
	public Void set_mousePosition(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C4D38C
	public Vector2 get_delta() { }

	// RVA: 0xFFFFFFFF75C4D434
	public PointerType get_pointerType() { }

	// RVA: 0xFFFFFFFF75C4D474
	public Int32 get_button() { }

	// RVA: 0xFFFFFFFF75C4D4B4
	public EventModifiers get_modifiers() { }

	// RVA: 0xFFFFFFFF75C4D4F4
	public Void set_modifiers(EventModifiers value) { }

	// RVA: 0xFFFFFFFF75C4D544
	public Single get_pressure() { }

	// RVA: 0xFFFFFFFF75C4D584
	public Int32 get_clickCount() { }

	// RVA: 0xFFFFFFFF75C4D5C4
	public Char get_character() { }

	// RVA: 0xFFFFFFFF75C4D604
	public Void set_character(Char value) { }

	// RVA: 0xFFFFFFFF75C4D654
	public KeyCode get_keyCode() { }

	// RVA: 0xFFFFFFFF75C4D694
	public Void set_keyCode(KeyCode value) { }

	// RVA: 0xFFFFFFFF75C4D6E4
	public Int32 get_displayIndex() { }

	// RVA: 0xFFFFFFFF75C4D724
	public Void set_displayIndex(Int32 value) { }

	// RVA: 0xFFFFFFFF75C4D774
	public EventType get_type() { }

	// RVA: 0xFFFFFFFF75C4D7B4
	public Void set_type(EventType value) { }

	// RVA: 0xFFFFFFFF75C4D804
	public String get_commandName() { }

	// RVA: 0xFFFFFFFF75C4D844
	public Void set_commandName(String value) { }

	// RVA: 0xFFFFFFFF75C4D894
	private Void Internal_Use() { }

	// RVA: 0xFFFFFFFF75C4D8D4
	private static IntPtr Internal_Create(Int32 displayIndex) { }

	// RVA: 0xFFFFFFFF75C4D914
	private static Void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF75C4D954
	public EventType GetTypeForControl(Int32 controlID) { }

	// RVA: 0xFFFFFFFF75C4D9A4
	internal Void CopyFromPtr(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF75C4D9F4
	public static Boolean PopEvent(Event outEvent) { }

	// RVA: 0xFFFFFFFF75C4DA34
	private static Void Internal_SetNativeEvent(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF723CE358
	internal static Void Internal_MakeMasterEventCurrent(Int32 displayIndex) { }

	// RVA: 0xFFFFFFFF75C4DAC8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C4DA74
	public Void .ctor(Int32 displayIndex) { }

	// RVA: 0xFFFFFFFF75C4DB10
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75C4DBCC
	internal Void CopyFrom(Event e) { }

	// RVA: 0xFFFFFFFF75C4DC4C
	public Boolean get_shift() { }

	// RVA: 0xFFFFFFFF75C4DC94
	public Boolean get_control() { }

	// RVA: 0xFFFFFFFF75C4DCDC
	public Boolean get_alt() { }

	// RVA: 0xFFFFFFFF75C4DD24
	public Boolean get_command() { }

	// RVA: 0xFFFFFFFF75C4DD6C
	public static Event get_current() { }

	// RVA: 0xFFFFFFFF75C4DD80
	public static Void set_current(Event value) { }

	// RVA: 0xFFFFFFFF75C4DE00
	public Boolean get_isKey() { }

	// RVA: 0xFFFFFFFF75C4DE50
	public Boolean get_isMouse() { }

	// RVA: 0xFFFFFFFF75C4DEC0
	internal Boolean get_isDirectManipulationDevice() { }

	// RVA: 0xFFFFFFFF75C4DF44
	public static Event KeyboardEvent(String key) { }

	// RVA: 0xFFFFFFFF75C4FAD4
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75C4FBF4
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75C4FE74
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75C50558
	public Void Use() { }

	// RVA: 0xFFFFFFFF75C4D298
	private Void get_mousePosition_Injected(out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C4D33C
	private Void set_mousePosition_Injected(ref Vector2 value) { }

	// RVA: 0xFFFFFFFF75C4D3E4
	private Void get_delta_Injected(out Vector2 ret) { }

}

// Namespace: UnityEngine
public enum EventType
{
	// Fields
	public Int32 value__; // 0x10
	public const EventType MouseDown = 0;
	public const EventType MouseUp = 1;
	public const EventType MouseMove = 2;
	public const EventType MouseDrag = 3;
	public const EventType KeyDown = 4;
	public const EventType KeyUp = 5;
	public const EventType ScrollWheel = 6;
	public const EventType Repaint = 7;
	public const EventType Layout = 8;
	public const EventType DragUpdated = 9;
	public const EventType DragPerform = 10;
	public const EventType DragExited = 15;
	public const EventType Ignore = 11;
	public const EventType Used = 12;
	public const EventType ValidateCommand = 13;
	public const EventType ExecuteCommand = 14;
	public const EventType ContextClick = 16;
	public const EventType MouseEnterWindow = 20;
	public const EventType MouseLeaveWindow = 21;
	public const EventType mouseDown = 0;
	public const EventType mouseUp = 1;
	public const EventType mouseMove = 2;
	public const EventType mouseDrag = 3;
	public const EventType keyDown = 4;
	public const EventType keyUp = 5;
	public const EventType scrollWheel = 6;
	public const EventType repaint = 7;
	public const EventType layout = 8;
	public const EventType dragUpdated = 9;
	public const EventType dragPerform = 10;
	public const EventType ignore = 11;
	public const EventType used = 12;
}

// Namespace: UnityEngine
public enum EventModifiers
{
	// Fields
	public Int32 value__; // 0x10
	public const EventModifiers None = 0;
	public const EventModifiers Shift = 1;
	public const EventModifiers Control = 2;
	public const EventModifiers Alt = 4;
	public const EventModifiers Command = 8;
	public const EventModifiers Numeric = 16;
	public const EventModifiers CapsLock = 32;
	public const EventModifiers FunctionKey = 64;
}

// Namespace: UnityEngine
public enum PointerType
{
	// Fields
	public Int32 value__; // 0x10
	public const PointerType Mouse = 0;
	public const PointerType Touch = 1;
	public const PointerType Pen = 2;
}

// Namespace: UnityEngine
internal struct EventInterests
{
	// Fields
	private Boolean <wantsMouseMove>k__BackingField; // 0x10
	private Boolean <wantsMouseEnterLeaveWindow>k__BackingField; // 0x11

	// Properties
	public Boolean wantsMouseMove { get; }
	public Boolean wantsMouseEnterLeaveWindow { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114F3A4
	public Boolean get_wantsMouseMove() { }

	// RVA: 0xFFFFFFFF7114F3AC
	public Boolean get_wantsMouseEnterLeaveWindow() { }

	// RVA: 0xFFFFFFFF7114F3B4
	public Boolean WantsEvent(EventType type) { }

}

// Namespace: UnityEngine
public class GUI
{
	// Fields
	private static Int32 s_ScrollControlId; // 0x0
	private static Int32 s_HotTextField; // 0x4
	private static readonly Int32 s_BoxHash; // 0x8
	private static readonly Int32 s_ButonHash; // 0xC
	private static readonly Int32 s_RepeatButtonHash; // 0x10
	private static readonly Int32 s_ToggleHash; // 0x14
	private static readonly Int32 s_ButtonGridHash; // 0x18
	private static readonly Int32 s_SliderHash; // 0x1C
	private static readonly Int32 s_BeginGroupHash; // 0x20
	private static readonly Int32 s_ScrollviewHash; // 0x24
	private static Int32 <scrollTroughSide>k__BackingField; // 0x28
	private static DateTime <nextScrollStepTime>k__BackingField; // 0x30
	private static GUISkin s_Skin; // 0x38
	private static GenericStack <scrollViewStates>k__BackingField; // 0x40

	// Properties
	public static Color color { get; set; }
	public static Color backgroundColor { get; set; }
	public static Color contentColor { get; set; }
	public static Boolean changed { get; set; }
	public static Boolean enabled { get; set; }
	public static Int32 depth { set; }
	internal static Boolean usePageScrollbars { get; }
	internal static Material blendMaterial { get; }
	internal static Material blitMaterial { get; }
	internal static Material roundedRectMaterial { get; }
	internal static Material roundedRectWithColorPerBorderMaterial { get; }
	internal static Int32 scrollTroughSide { get; set; }
	internal static DateTime nextScrollStepTime { get; set; }
	public static GUISkin skin { get; set; }
	public static Matrix4x4 matrix { get; set; }
	internal static GenericStack scrollViewStates { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C507DC
	public static Color get_color() { }

	// RVA: 0xFFFFFFFF723CE4A4
	public static Void set_color(Color value) { }

	// RVA: 0xFFFFFFFF75C508CC
	public static Color get_backgroundColor() { }

	// RVA: 0xFFFFFFFF75C5097C
	public static Void set_backgroundColor(Color value) { }

	// RVA: 0xFFFFFFFF75C50A28
	public static Color get_contentColor() { }

	// RVA: 0xFFFFFFFF75C50AD8
	public static Void set_contentColor(Color value) { }

	// RVA: 0xFFFFFFFF75C50B84
	public static Boolean get_changed() { }

	// RVA: 0xFFFFFFFF75C50BB8
	public static Void set_changed(Boolean value) { }

	// RVA: 0xFFFFFFFF75C50BF8
	public static Boolean get_enabled() { }

	// RVA: 0xFFFFFFFF75C50C2C
	public static Void set_enabled(Boolean value) { }

	// RVA: 0xFFFFFFFF75C50C6C
	public static Void set_depth(Int32 value) { }

	// RVA: 0xFFFFFFFF75C50CAC
	internal static Boolean get_usePageScrollbars() { }

	// RVA: 0xFFFFFFFF75C50CE0
	internal static Material get_blendMaterial() { }

	// RVA: 0xFFFFFFFF75C50D14
	internal static Material get_blitMaterial() { }

	// RVA: 0xFFFFFFFF75C50D48
	internal static Material get_roundedRectMaterial() { }

	// RVA: 0xFFFFFFFF75C50D7C
	internal static Material get_roundedRectWithColorPerBorderMaterial() { }

	// RVA: 0xFFFFFFFF75C50DB0
	internal static Void GrabMouseControl(Int32 id) { }

	// RVA: 0xFFFFFFFF75C50DF0
	internal static Boolean HasMouseControl(Int32 id) { }

	// RVA: 0xFFFFFFFF75C50E30
	internal static Void ReleaseMouseControl() { }

	// RVA: 0xFFFFFFFF75C50E64
	public static Void SetNextControlName(String name) { }

	// RVA: 0xFFFFFFFF75C50EA4
	internal static Void InternalRepaintEditorWindow() { }

	// RVA: 0xFFFFFFFF723CE51C
	private static Rect Internal_DoWindow(Int32 id, Int32 instanceID, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, Object skin, Boolean forceRectOnLayout) { }

	// RVA: 0xFFFFFFFF723CE614
	public static Void DragWindow(Rect position) { }

	// RVA: 0xFFFFFFFF75C50FB8
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C511B8
	internal static Int32 get_scrollTroughSide() { }

	// RVA: 0xFFFFFFFF75C511F8
	internal static Void set_scrollTroughSide(Int32 value) { }

	// RVA: 0xFFFFFFFF75C5123C
	internal static DateTime get_nextScrollStepTime() { }

	// RVA: 0xFFFFFFFF75C5127C
	internal static Void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0xFFFFFFFF723CE68C
	public static Void set_skin(GUISkin value) { }

	// RVA: 0xFFFFFFFF723CE908
	public static GUISkin get_skin() { }

	// RVA: 0xFFFFFFFF723CE7A0
	internal static Void DoSetSkin(GUISkin newSkin) { }

	// RVA: 0xFFFFFFFF75C512C0
	public static Matrix4x4 get_matrix() { }

	// RVA: 0xFFFFFFFF75C51390
	public static Void set_matrix(Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75C51428
	public static Void Label(Rect position, String text) { }

	// RVA: 0xFFFFFFFF723CEC84
	public static Void Label(Rect position, String text, GUIStyle style) { }

	// RVA: 0xFFFFFFFF723CEBA4
	public static Void Label(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0xFFFFFFFF75C514DC
	public static Void DrawTexture(Rect position, Texture image) { }

	// RVA: 0xFFFFFFFF75C5154C
	public static Void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

	// RVA: 0xFFFFFFFF75C515C4
	public static Void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, Boolean alphaBlend) { }

	// RVA: 0xFFFFFFFF75C5164C
	public static Void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, Boolean alphaBlend, Single imageAspect) { }

	// RVA: 0xFFFFFFFF75C516FC
	public static Void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, Boolean alphaBlend, Single imageAspect, Color color, Single borderWidth, Single borderRadius) { }

	// RVA: 0xFFFFFFFF75C51804
	public static Void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, Boolean alphaBlend, Single imageAspect, Color color, Vector4 borderWidths, Single borderRadius) { }

	// RVA: 0xFFFFFFFF75C51928
	public static Void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, Boolean alphaBlend, Single imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

	// RVA: 0xFFFFFFFF75C51A00
	internal static Void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, Boolean alphaBlend, Single imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, Boolean drawSmoothCorners) { }

	// RVA: 0xFFFFFFFF75C51B00
	internal static Void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, Boolean alphaBlend, Single imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, Boolean drawSmoothCorners) { }

	// RVA: 0xFFFFFFFF75C52038
	internal static Boolean CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, Single imageAspect, ref Rect outScreenRect, ref Rect outSourceRect) { }

	// RVA: 0xFFFFFFFF723CEFDC
	public static Void Box(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0xFFFFFFFF723CF394
	public static Boolean Button(Rect position, String text) { }

	// RVA: 0xFFFFFFFF75C522AC
	public static Boolean Button(Rect position, String text, GUIStyle style) { }

	// RVA: 0xFFFFFFFF723CF53C
	public static Boolean Button(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0xFFFFFFFF723CF620
	internal static Boolean Button(Rect position, Int32 id, GUIContent content, GUIStyle style) { }

	// RVA: 0xFFFFFFFF75C523B0
	private static Boolean DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType) { }

	// RVA: 0xFFFFFFFF75C527E8
	public static String TextField(Rect position, String text) { }

	// RVA: 0xFFFFFFFF75C529F4
	internal static String PasswordFieldGetStrToShow(String password, Char maskChar) { }

	// RVA: 0xFFFFFFFF75C5294C
	internal static Void DoTextField(Rect position, Int32 id, GUIContent content, Boolean multiline, Int32 maxLength, GUIStyle style) { }

	// RVA: 0xFFFFFFFF75C52AD4
	internal static Void DoTextField(Rect position, Int32 id, GUIContent content, Boolean multiline, Int32 maxLength, GUIStyle style, String secureText) { }

	// RVA: 0xFFFFFFFF75C52B7C
	internal static Void DoTextField(Rect position, Int32 id, GUIContent content, Boolean multiline, Int32 maxLength, GUIStyle style, String secureText, Char maskChar) { }

	// RVA: 0xFFFFFFFF75C5338C
	private static Void HandleTextFieldEventForTouchscreen(Rect position, Int32 id, GUIContent content, Boolean multiline, Int32 maxLength, GUIStyle style, String secureText, Char maskChar, TextEditor editor) { }

	// RVA: 0xFFFFFFFF75C53828
	private static Void HandleTextFieldEventForDesktop(Rect position, Int32 id, GUIContent content, Boolean multiline, Int32 maxLength, GUIStyle style, TextEditor editor) { }

	// RVA: 0xFFFFFFFF75C5308C
	private static Void HandleTextFieldEventForDesktopWithForcedKeyboard(Rect position, Int32 id, GUIContent content, Boolean multiline, Int32 maxLength, GUIStyle style, String secureText, TextEditor editor) { }

	// RVA: 0xFFFFFFFF75C54FE4
	public static Boolean Toggle(Rect position, Boolean value, String text) { }

	// RVA: 0xFFFFFFFF75C550A8
	public static Boolean Toggle(Rect position, Boolean value, GUIContent content, GUIStyle style) { }

	// RVA: 0xFFFFFFFF75C552A0
	public static Int32 SelectionGrid(Rect position, Int32 selected, GUIContent[] contents, Int32 xCount, GUIStyle style) { }

	// RVA: 0xFFFFFFFF75C56040
	internal static Int32 CalcTotalHorizSpacing(Int32 xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle) { }

	// RVA: 0xFFFFFFFF723CF8DC
	private static Boolean DoControl(Rect position, Int32 id, Boolean on, Boolean hover, GUIContent content, GUIStyle style) { }

	// RVA: 0xFFFFFFFF723CEDB8
	private static Void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0xFFFFFFFF75C55188
	internal static Boolean DoToggle(Rect position, Int32 id, Boolean value, GUIContent content, GUIStyle style) { }

	// RVA: 0xFFFFFFFF723CF708
	internal static Boolean DoButton(Rect position, Int32 id, GUIContent content, GUIStyle style) { }

	// RVA: 0xFFFFFFFF75C5538C
	private static Int32 DoButtonGrid(Rect position, Int32 selected, GUIContent[] contents, String[] controlNames, Int32 xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, ToolbarButtonSize buttonSize, Boolean[] contentsEnabled) { }

	// RVA: 0xFFFFFFFF75C565CC
	private static Rect[] CalcMouseRects(Rect position, GUIContent[] contents, Int32 xCount, Single elemWidth, Single elemHeight, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, Boolean addBorders, ToolbarButtonSize buttonSize) { }

	// RVA: 0xFFFFFFFF75C56AAC
	public static Single HorizontalSlider(Rect position, Single value, Single leftValue, Single rightValue, GUIStyle slider, GUIStyle thumb) { }

	// RVA: 0xFFFFFFFF75C56B58
	public static Single Slider(Rect position, Single value, Single size, Single start, Single end, GUIStyle slider, GUIStyle thumb, Boolean horiz, Int32 id, GUIStyle thumbExtent) { }

	// RVA: 0xFFFFFFFF75C56E18
	public static Single HorizontalScrollbar(Rect position, Single value, Single size, Single leftValue, Single rightValue, GUIStyle style) { }

	// RVA: 0xFFFFFFFF75C57834
	internal static Boolean ScrollerRepeatButton(Int32 scrollerID, Rect rect, GUIStyle style) { }

	// RVA: 0xFFFFFFFF75C57A54
	public static Single VerticalScrollbar(Rect position, Single value, Single size, Single topValue, Single bottomValue, GUIStyle style) { }

	// RVA: 0xFFFFFFFF75C57260
	internal static Single Scroller(Rect position, Single value, Single size, Single leftValue, Single rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, Boolean horiz) { }

	// RVA: 0xFFFFFFFF75C57BD8
	public static Void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0xFFFFFFFF75C57C88
	internal static Void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	// RVA: 0xFFFFFFFF75C57EF8
	public static Void EndGroup() { }

	// RVA: 0xFFFFFFFF75C57F64
	internal static GenericStack get_scrollViewStates() { }

	// RVA: 0xFFFFFFFF75C57FA4
	public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, Boolean alwaysShowHorizontal, Boolean alwaysShowVertical) { }

	// RVA: 0xFFFFFFFF75C58090
	internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, Boolean alwaysShowHorizontal, Boolean alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background) { }

	// RVA: 0xFFFFFFFF75C58F38
	public static Void EndScrollView() { }

	// RVA: 0xFFFFFFFF75C58F68
	public static Void EndScrollView(Boolean handleScrollWheel) { }

	// RVA: 0xFFFFFFFF723CFD80
	public static Rect Window(Int32 id, Rect clientRect, WindowFunction func, String text) { }

	// RVA: 0xFFFFFFFF723CFF2C
	private static Rect DoWindow(Int32 id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, Boolean forceRectOnLayout) { }

	// RVA: 0xFFFFFFFF723D0080
	internal static Void CallWindowDelegate(WindowFunction func, Int32 id, Int32 instanceID, GUISkin _skin, Int32 forceRect, Single width, Single height, GUIStyle style) { }

	// RVA: 0xFFFFFFFF75C5936C
	public static Void DragWindow() { }

	// RVA: 0xFFFFFFFF75C5084C
	private static Void get_color_Injected(out Color ret) { }

	// RVA: 0xFFFFFFFF75C5088C
	private static Void set_color_Injected(ref Color value) { }

	// RVA: 0xFFFFFFFF75C5093C
	private static Void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0xFFFFFFFF75C509E8
	private static Void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0xFFFFFFFF75C50A98
	private static Void get_contentColor_Injected(out Color ret) { }

	// RVA: 0xFFFFFFFF75C50B44
	private static Void set_contentColor_Injected(ref Color value) { }

	// RVA: 0xFFFFFFFF75C50ED8
	private static Void Internal_DoWindow_Injected(Int32 id, Int32 instanceID, ref Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, Object skin, Boolean forceRectOnLayout, out Rect ret) { }

	// RVA: 0xFFFFFFFF75C50F78
	private static Void DragWindow_Injected(ref Rect position) { }

}

// Namespace: 
public enum ToolbarButtonSize
{
	// Fields
	public Int32 value__; // 0x10
	public const ToolbarButtonSize Fixed = 0;
	public const ToolbarButtonSize FitToContents = 1;
}

// Namespace: 
public sealed class WindowFunction
{
	// Methods

	// RVA: 0xFFFFFFFF75C593AC
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF723D0BE0
	public virtual Void Invoke(Int32 id) { }

	// RVA: 0xFFFFFFFF75C593F0
	public virtual IAsyncResult BeginInvoke(Int32 id, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75C59480
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine
public sealed class GUIClip
{
	// Properties
	public static Rect visibleRect { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C56484
	public static Rect get_visibleRect() { }

	// RVA: 0xFFFFFFFF75C594CC
	internal static Void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, Boolean resetOffset) { }

	// RVA: 0xFFFFFFFF75C57F30
	internal static Void Internal_Pop() { }

	// RVA: 0xFFFFFFFF75C5959C
	internal static Int32 Internal_GetCount() { }

	// RVA: 0xFFFFFFFF75C595D0
	private static Vector2 Unclip_Vector2(Vector2 pos) { }

	// RVA: 0xFFFFFFFF75C51328
	internal static Matrix4x4 GetMatrix() { }

	// RVA: 0xFFFFFFFF75C513E8
	internal static Void SetMatrix(Matrix4x4 m) { }

	// RVA: 0xFFFFFFFF75C596F8
	internal static Void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0xFFFFFFFF75C597A0
	internal static Void Internal_PopParentClip() { }

	// RVA: 0xFFFFFFFF75C57EF4
	internal static Void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, Boolean resetOffset) { }

	// RVA: 0xFFFFFFFF75C59330
	internal static Void Pop() { }

	// RVA: 0xFFFFFFFF75C597D4
	public static Vector2 Unclip(Vector2 pos) { }

	// RVA: 0xFFFFFFFF75C5948C
	private static Void get_visibleRect_Injected(out Rect ret) { }

	// RVA: 0xFFFFFFFF75C59534
	private static Void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, Boolean resetOffset) { }

	// RVA: 0xFFFFFFFF75C59628
	private static Void Unclip_Vector2_Injected(ref Vector2 pos, out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C59678
	private static Void GetMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0xFFFFFFFF75C596B8
	private static Void SetMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0xFFFFFFFF75C59750
	private static Void Internal_PushParentClip_Injected(ref Matrix4x4 objectTransform, ref Rect clipRect) { }

}

// Namespace: 
internal struct ParentClipScope
{
	// Fields
	private Boolean m_Disposed; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114F420
	public Void .ctor(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0xFFFFFFFF7114F488
	public Void Dispose() { }

}

// Namespace: UnityEngine
public class GUIContent
{
	// Fields
	private String m_Text; // 0x10
	private Texture m_Image; // 0x18
	private String m_Tooltip; // 0x20
	private static readonly GUIContent s_Text; // 0x0
	private static readonly GUIContent s_Image; // 0x8
	private static readonly GUIContent s_TextImage; // 0x10
	public static GUIContent none; // 0x18

	// Properties
	public String text { get; set; }
	public Texture image { set; }
	public String tooltip { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C529EC
	public String get_text() { }

	// RVA: 0xFFFFFFFF75C52E78
	public Void set_text(String value) { }

	// RVA: 0xFFFFFFFF75C59890
	public Void set_image(Texture value) { }

	// RVA: 0xFFFFFFFF75C5647C
	public String get_tooltip() { }

	// RVA: 0xFFFFFFFF75C598C8
	public Void set_tooltip(String value) { }

	// RVA: 0xFFFFFFFF75C59900
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C5997C
	public Void .ctor(String text) { }

	// RVA: 0xFFFFFFFF75C59994
	public Void .ctor(String text, Texture image, String tooltip) { }

	// RVA: 0xFFFFFFFF75C59A74
	public Void .ctor(GUIContent src) { }

	// RVA: 0xFFFFFFFF723CEAF4
	internal static GUIContent Temp(String t) { }

	// RVA: 0xFFFFFFFF723D104C
	internal static Void ClearStaticCache() { }

	// RVA: 0xFFFFFFFF75C59B54
	internal static GUIContent[] Temp(String[] texts) { }

	// RVA: 0xFFFFFFFF75C59C5C
	private static Void .cctor() { }

}

// Namespace: UnityEngine
public enum ScaleMode
{
	// Fields
	public Int32 value__; // 0x10
	public const ScaleMode StretchToFill = 0;
	public const ScaleMode ScaleAndCrop = 1;
	public const ScaleMode ScaleToFit = 2;
}

// Namespace: UnityEngine
public enum FocusType
{
	// Fields
	public Int32 value__; // 0x10
	public const FocusType Native = 0;
	public const FocusType Keyboard = 1;
	public const FocusType Passive = 2;
}

// Namespace: UnityEngine
public class GUILayout
{
	// Methods

	// RVA: 0xFFFFFFFF75C5A844
	public static Void Label(String text, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5A96C
	public static Void Label(String text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5A8C0
	private static Void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5AA18
	public static Void Box(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5AA1C
	private static Void DoBox(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5AAC8
	public static Boolean Button(String text, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5ABF0
	public static Boolean Button(String text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5AB44
	private static Boolean DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5AC48
	public static String TextArea(String text, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5ACAC
	private static String DoTextField(String text, Int32 maxLength, Boolean multiline, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5AE64
	public static Int32 SelectionGrid(Int32 selected, String[] texts, Int32 xCount, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5AEF8
	public static Int32 SelectionGrid(Int32 selected, GUIContent[] contents, Int32 xCount, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5AF98
	public static Single HorizontalSlider(Single value, Single leftValue, Single rightValue, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5B028
	private static Single DoHorizontalSlider(Single value, Single leftValue, Single rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5B148
	public static Void Space(Single pixels) { }

	// RVA: 0xFFFFFFFF75C5B3F0
	public static Void FlexibleSpace() { }

	// RVA: 0xFFFFFFFF75C5B674
	public static Void BeginHorizontal(GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5B854
	public static Void BeginHorizontal(GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5B6E4
	public static Void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5BB58
	public static Void EndHorizontal() { }

	// RVA: 0xFFFFFFFF75C5BD14
	public static Void BeginVertical(GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5BEF8
	public static Void BeginVertical(GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5BD84
	public static Void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5BF50
	public static Void EndVertical() { }

	// RVA: 0xFFFFFFFF75C5BF7C
	public static Void BeginArea(Rect screenRect, GUIStyle style) { }

	// RVA: 0xFFFFFFFF75C5BFF4
	public static Void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	// RVA: 0xFFFFFFFF75C5C478
	public static Void EndArea() { }

	// RVA: 0xFFFFFFFF75C5C5D8
	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5C8A4
	public static Vector2 BeginScrollView(Vector2 scrollPosition, Boolean alwaysShowHorizontal, Boolean alwaysShowVertical, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5C664
	public static Vector2 BeginScrollView(Vector2 scrollPosition, Boolean alwaysShowHorizontal, Boolean alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5C940
	public static Void EndScrollView() { }

	// RVA: 0xFFFFFFFF75C5C948
	internal static Void EndScrollView(Boolean handleScrollWheel) { }

	// RVA: 0xFFFFFFFF723D085C
	public static GUILayoutOption Width(Single width) { }

	// RVA: 0xFFFFFFFF75C5C9E0
	public static GUILayoutOption MaxWidth(Single maxWidth) { }

	// RVA: 0xFFFFFFFF723D08D0
	public static GUILayoutOption Height(Single height) { }

	// RVA: 0xFFFFFFFF75C5B5FC
	public static GUILayoutOption ExpandWidth(Boolean expand) { }

	// RVA: 0xFFFFFFFF75C5B584
	public static GUILayoutOption ExpandHeight(Boolean expand) { }

}

// Namespace: UnityEngine
public sealed class GUILayoutOption
{
	// Fields
	internal Type type; // 0x10
	internal Object value; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75C5C9A4
	internal Void .ctor(Type type, Object value) { }

}

// Namespace: 
internal enum Type
{
	// Fields
	public Int32 value__; // 0x10
	public const Type fixedWidth = 0;
	public const Type fixedHeight = 1;
	public const Type minWidth = 2;
	public const Type maxWidth = 3;
	public const Type minHeight = 4;
	public const Type maxHeight = 5;
	public const Type stretchWidth = 6;
	public const Type stretchHeight = 7;
	public const Type alignStart = 8;
	public const Type alignMiddle = 9;
	public const Type alignEnd = 10;
	public const Type alignJustify = 11;
	public const Type equalSize = 12;
	public const Type spacing = 13;
}

// Namespace: UnityEngine
public class GUILayoutUtility
{
	// Fields
	private static readonly Dictionary<T0, T1> s_StoredLayouts; // 0x0
	private static readonly Dictionary<T0, T1> s_StoredWindows; // 0x8
	internal static LayoutCache current; // 0x10
	internal static readonly Rect kDummyRect; // 0x18
	private static GUIStyle s_SpaceStyle; // 0x28

	// Properties
	internal static GUIStyle spaceStyle { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C5D6F0
	private static Rect Internal_GetWindowRect(Int32 windowID) { }

	// RVA: 0xFFFFFFFF75C5D7B8
	private static Void Internal_MoveWindow(Int32 windowID, Rect r) { }

	// RVA: 0xFFFFFFFF723D03E4
	internal static LayoutCache SelectIDList(Int32 instanceID, Boolean isWindow) { }

	// RVA: 0xFFFFFFFF723D3CBC
	internal static Void Begin(Int32 instanceID) { }

	// RVA: 0xFFFFFFFF75C5D87C
	internal static Void BeginContainer(LayoutCache cache) { }

	// RVA: 0xFFFFFFFF723D0948
	internal static Void BeginWindow(Int32 windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF723D0E40
	internal static Void Layout() { }

	// RVA: 0xFFFFFFFF75C5DA4C
	internal static Void LayoutFromEditorWindow() { }

	// RVA: 0xFFFFFFFF75C5DC28
	internal static Void LayoutFromContainer(Single w, Single h) { }

	// RVA: 0xFFFFFFFF723D3EC0
	internal static Void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0xFFFFFFFF723D3FD8
	private static Void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0xFFFFFFFF75C5DD70
	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	// RVA: 0xFFFFFFFF75C5B8AC
	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	// RVA: 0xFFFFFFFF75C5BB84
	internal static Void EndLayoutGroup() { }

	// RVA: 0xFFFFFFFF75C5C1EC
	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	// RVA: 0xFFFFFFFF75C5A9C4
	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5DE9C
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5E324
	public static Rect GetRect(Single width, Single height) { }

	// RVA: 0xFFFFFFFF75C5B38C
	public static Rect GetRect(Single width, Single height, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5E3A4
	private static Rect DoGetRect(Single minWidth, Single maxWidth, Single minHeight, Single maxHeight, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5B2C0
	internal static GUIStyle get_spaceStyle() { }

	// RVA: 0xFFFFFFFF75C5E60C
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C5D768
	private static Void Internal_GetWindowRect_Injected(Int32 windowID, out Rect ret) { }

	// RVA: 0xFFFFFFFF75C5D82C
	private static Void Internal_MoveWindow_Injected(Int32 windowID, ref Rect r) { }

}

// Namespace: 
internal sealed class LayoutCache
{
	// Fields
	internal GUILayoutGroup topLevel; // 0x10
	internal GenericStack layoutGroups; // 0x18
	internal GUILayoutGroup windows; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF723D3BC0
	internal Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class GUISettings
{
	// Fields
	private Boolean m_DoubleClickSelectsWord; // 0x10
	private Boolean m_TripleClickSelectsLine; // 0x11
	private Color m_CursorColor; // 0x14
	private Single m_CursorFlashSpeed; // 0x24
	private Color m_SelectionColor; // 0x28

	// Properties
	public Boolean doubleClickSelectsWord { get; }
	public Boolean tripleClickSelectsLine { get; }
	public Color cursorColor { get; }
	public Single cursorFlashSpeed { get; }
	public Color selectionColor { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C5EC28
	private static Single Internal_GetCursorFlashSpeed() { }

	// RVA: 0xFFFFFFFF75C541C8
	public Boolean get_doubleClickSelectsWord() { }

	// RVA: 0xFFFFFFFF75C5432C
	public Boolean get_tripleClickSelectsLine() { }

	// RVA: 0xFFFFFFFF75C5EC5C
	public Color get_cursorColor() { }

	// RVA: 0xFFFFFFFF75C5EC68
	public Single get_cursorFlashSpeed() { }

	// RVA: 0xFFFFFFFF75C5ECB4
	public Color get_selectionColor() { }

	// RVA: 0xFFFFFFFF75C5ECC0
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class GUISkin
{
	// Fields
	private Font m_Font; // 0x18
	private GUIStyle m_box; // 0x20
	private GUIStyle m_button; // 0x28
	private GUIStyle m_toggle; // 0x30
	private GUIStyle m_label; // 0x38
	private GUIStyle m_textField; // 0x40
	private GUIStyle m_textArea; // 0x48
	private GUIStyle m_window; // 0x50
	private GUIStyle m_horizontalSlider; // 0x58
	private GUIStyle m_horizontalSliderThumb; // 0x60
	private GUIStyle m_horizontalSliderThumbExtent; // 0x68
	private GUIStyle m_verticalSlider; // 0x70
	private GUIStyle m_verticalSliderThumb; // 0x78
	private GUIStyle m_verticalSliderThumbExtent; // 0x80
	private GUIStyle m_horizontalScrollbar; // 0x88
	private GUIStyle m_horizontalScrollbarThumb; // 0x90
	private GUIStyle m_horizontalScrollbarLeftButton; // 0x98
	private GUIStyle m_horizontalScrollbarRightButton; // 0xA0
	private GUIStyle m_verticalScrollbar; // 0xA8
	private GUIStyle m_verticalScrollbarThumb; // 0xB0
	private GUIStyle m_verticalScrollbarUpButton; // 0xB8
	private GUIStyle m_verticalScrollbarDownButton; // 0xC0
	private GUIStyle m_ScrollView; // 0xC8
	internal GUIStyle[] m_CustomStyles; // 0xD0
	private GUISettings m_Settings; // 0xD8
	internal static GUIStyle ms_Error; // 0x0
	private Dictionary<T0, T1> m_Styles; // 0xE0
	internal static SkinChangedDelegate m_SkinChanged; // 0x8
	internal static GUISkin current; // 0x10

	// Properties
	public Font font { get; set; }
	public GUIStyle box { get; set; }
	public GUIStyle label { get; set; }
	public GUIStyle textField { get; set; }
	public GUIStyle textArea { get; set; }
	public GUIStyle button { get; set; }
	public GUIStyle toggle { get; set; }
	public GUIStyle window { get; set; }
	public GUIStyle horizontalSlider { get; set; }
	public GUIStyle horizontalSliderThumb { get; set; }
	internal GUIStyle horizontalSliderThumbExtent { get; set; }
	public GUIStyle verticalSlider { get; set; }
	public GUIStyle verticalSliderThumb { get; set; }
	internal GUIStyle verticalSliderThumbExtent { get; set; }
	public GUIStyle horizontalScrollbar { get; set; }
	public GUIStyle horizontalScrollbarThumb { get; set; }
	public GUIStyle horizontalScrollbarLeftButton { get; set; }
	public GUIStyle horizontalScrollbarRightButton { get; set; }
	public GUIStyle verticalScrollbar { get; set; }
	public GUIStyle verticalScrollbarThumb { get; set; }
	public GUIStyle verticalScrollbarUpButton { get; set; }
	public GUIStyle verticalScrollbarDownButton { get; set; }
	public GUIStyle scrollView { get; set; }
	public GUIStyle[] customStyles { get; set; }
	public GUISettings settings { get; }
	internal static GUIStyle error { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C5ED28
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C5EDD4
	internal Void OnEnable() { }

	// RVA: 0xFFFFFFFF75C5EE30
	internal static Void CleanupRoots() { }

	// RVA: 0xFFFFFFFF75C54974
	public Font get_font() { }

	// RVA: 0xFFFFFFFF75C5EE90
	public Void set_font(Font value) { }

	// RVA: 0xFFFFFFFF75C5EF98
	public GUIStyle get_box() { }

	// RVA: 0xFFFFFFFF75C5EFA0
	public Void set_box(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C514D4
	public GUIStyle get_label() { }

	// RVA: 0xFFFFFFFF75C5EFDC
	public Void set_label(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C52944
	public GUIStyle get_textField() { }

	// RVA: 0xFFFFFFFF75C5F018
	public Void set_textField(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C5ACA4
	public GUIStyle get_textArea() { }

	// RVA: 0xFFFFFFFF75C5F054
	public Void set_textArea(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C522A4
	public GUIStyle get_button() { }

	// RVA: 0xFFFFFFFF75C5F090
	public Void set_button(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C550A0
	public GUIStyle get_toggle() { }

	// RVA: 0xFFFFFFFF75C5F0CC
	public Void set_toggle(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C59364
	public GUIStyle get_window() { }

	// RVA: 0xFFFFFFFF75C5F108
	public Void set_window(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C5B018
	public GUIStyle get_horizontalSlider() { }

	// RVA: 0xFFFFFFFF75C5F144
	public Void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C5B020
	public GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0xFFFFFFFF75C5F180
	public Void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C5F1BC
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0xFFFFFFFF75C5F1C4
	internal Void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C5F200
	public GUIStyle get_verticalSlider() { }

	// RVA: 0xFFFFFFFF75C5F208
	public Void set_verticalSlider(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C5F244
	public GUIStyle get_verticalSliderThumb() { }

	// RVA: 0xFFFFFFFF75C5F24C
	public Void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C5F288
	internal GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0xFFFFFFFF75C5F290
	internal Void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C58078
	public GUIStyle get_horizontalScrollbar() { }

	// RVA: 0xFFFFFFFF75C5F2CC
	public Void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C5F308
	public GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0xFFFFFFFF75C5F310
	public Void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C5F34C
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0xFFFFFFFF75C5F354
	public Void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C5F390
	public GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0xFFFFFFFF75C5F398
	public Void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C58080
	public GUIStyle get_verticalScrollbar() { }

	// RVA: 0xFFFFFFFF75C5F3D4
	public Void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C5F410
	public GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0xFFFFFFFF75C5F418
	public Void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C5F454
	public GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0xFFFFFFFF75C5F45C
	public Void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C5F498
	public GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0xFFFFFFFF75C5F4A0
	public Void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C58088
	public GUIStyle get_scrollView() { }

	// RVA: 0xFFFFFFFF75C5F4DC
	public Void set_scrollView(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C5F518
	public GUIStyle[] get_customStyles() { }

	// RVA: 0xFFFFFFFF75C5F520
	public Void set_customStyles(GUIStyle[] value) { }

	// RVA: 0xFFFFFFFF75C541C0
	public GUISettings get_settings() { }

	// RVA: 0xFFFFFFFF75C5F55C
	internal static GUIStyle get_error() { }

	// RVA: 0xFFFFFFFF75C5EDD8
	internal Void Apply() { }

	// RVA: 0xFFFFFFFF75C5F660
	private Void BuildStyleCache() { }

	// RVA: 0xFFFFFFFF75C57014
	public GUIStyle GetStyle(String styleName) { }

	// RVA: 0xFFFFFFFF75C60290
	public GUIStyle FindStyle(String styleName) { }

	// RVA: 0xFFFFFFFF723CEA28
	internal Void MakeCurrent() { }

	// RVA: 0xFFFFFFFF75C604F4
	public IEnumerator GetEnumerator() { }

}

// Namespace: 
internal sealed class SkinChangedDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75C605AC
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75C602F8
	public virtual Void Invoke() { }

	// RVA: 0xFFFFFFFF75C605F0
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75C60648
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine
internal class GUIStateObjects
{
	// Fields
	private static Dictionary<T0, T1> s_StateCache; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75C60654
	internal static Object GetStateObject(Type t, Int32 controlID) { }

	// RVA: 0xFFFFFFFF75C6073C
	private static Void .cctor() { }

}

// Namespace: UnityEngine
public sealed class GUIStyleState
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	// Properties
	public Texture2D background { get; set; }
	public Color textColor { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C62384
	public Texture2D get_background() { }

	// RVA: 0xFFFFFFFF75C623C4
	public Void set_background(Texture2D value) { }

	// RVA: 0xFFFFFFFF75C6022C
	public Void set_textColor(Color value) { }

	// RVA: 0xFFFFFFFF75C62464
	private static IntPtr Init() { }

	// RVA: 0xFFFFFFFF75C62498
	private Void Cleanup() { }

	// RVA: 0xFFFFFFFF75C624D8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C62518
	private Void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0xFFFFFFFF75C619A0
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0xFFFFFFFF75C62560
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75C62414
	private Void set_textColor_Injected(ref Color value) { }

}

// Namespace: UnityEngine
public sealed class GUIStyle
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private GUIStyleState m_Normal; // 0x18
	private GUIStyleState m_Hover; // 0x20
	private GUIStyleState m_Active; // 0x28
	private GUIStyleState m_Focused; // 0x30
	private GUIStyleState m_OnNormal; // 0x38
	private GUIStyleState m_OnHover; // 0x40
	private GUIStyleState m_OnActive; // 0x48
	private GUIStyleState m_OnFocused; // 0x50
	private RectOffset m_Border; // 0x58
	private RectOffset m_Padding; // 0x60
	private RectOffset m_Margin; // 0x68
	private RectOffset m_Overflow; // 0x70
	private String m_Name; // 0x78
	internal static Boolean showKeyboardFocus; // 0x0
	private static GUIStyle s_None; // 0x8

	// Properties
	internal String rawName { get; set; }
	public Font font { get; }
	public ImagePosition imagePosition { get; }
	public TextAnchor alignment { set; }
	public Boolean wordWrap { get; }
	public Vector2 contentOffset { get; set; }
	public Single fixedWidth { get; }
	public Single fixedHeight { get; }
	public Boolean stretchWidth { get; set; }
	public Boolean stretchHeight { get; set; }
	public Int32 fontSize { set; }
	public Boolean richText { set; }
	internal Vector2 Internal_clipOffset { set; }
	public String name { get; set; }
	public GUIStyleState normal { get; set; }
	public RectOffset margin { get; }
	public RectOffset padding { get; }
	public Single lineHeight { get; }
	public static GUIStyle none { get; }
	public Boolean isHeightDependantOnWidth { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C607B8
	internal String get_rawName() { }

	// RVA: 0xFFFFFFFF75C607F8
	internal Void set_rawName(String value) { }

	// RVA: 0xFFFFFFFF75C54934
	public Font get_font() { }

	// RVA: 0xFFFFFFFF75C60848
	public ImagePosition get_imagePosition() { }

	// RVA: 0xFFFFFFFF75C60888
	public Void set_alignment(TextAnchor value) { }

	// RVA: 0xFFFFFFFF75C608D8
	public Boolean get_wordWrap() { }

	// RVA: 0xFFFFFFFF75C60918
	public Vector2 get_contentOffset() { }

	// RVA: 0xFFFFFFFF75C609C0
	public Void set_contentOffset(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C5654C
	public Single get_fixedWidth() { }

	// RVA: 0xFFFFFFFF75C5658C
	public Single get_fixedHeight() { }

	// RVA: 0xFFFFFFFF75C5CDE8
	public Boolean get_stretchWidth() { }

	// RVA: 0xFFFFFFFF75C5E5BC
	public Void set_stretchWidth(Boolean value) { }

	// RVA: 0xFFFFFFFF75C5CE28
	public Boolean get_stretchHeight() { }

	// RVA: 0xFFFFFFFF75C60128
	public Void set_stretchHeight(Boolean value) { }

	// RVA: 0xFFFFFFFF75C60A64
	public Void set_fontSize(Int32 value) { }

	// RVA: 0xFFFFFFFF75C60AB4
	public Void set_richText(Boolean value) { }

	// RVA: 0xFFFFFFFF75C60B04
	internal Void set_Internal_clipOffset(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C60BA8
	private static IntPtr Internal_Create(GUIStyle self) { }

	// RVA: 0xFFFFFFFF75C60BE8
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	// RVA: 0xFFFFFFFF75C60C38
	private static Void Internal_Destroy(IntPtr self) { }

	// RVA: 0xFFFFFFFF75C60C78
	private IntPtr GetStyleStatePtr(Int32 idx) { }

	// RVA: 0xFFFFFFFF75C60CC8
	private Void AssignStyleState(Int32 idx, IntPtr srcStyleState) { }

	// RVA: 0xFFFFFFFF75C60D20
	private IntPtr GetRectOffsetPtr(Int32 idx) { }

	// RVA: 0xFFFFFFFF75C60D70
	private static Single Internal_GetLineHeight(IntPtr target) { }

	// RVA: 0xFFFFFFFF75C60DB0
	private Void Internal_Draw(Rect screenRect, GUIContent content, Boolean isHover, Boolean isActive, Boolean on, Boolean hasKeyboardFocus) { }

	// RVA: 0xFFFFFFFF75C60ED0
	private Void Internal_Draw2(Rect position, GUIContent content, Int32 controlID, Boolean on) { }

	// RVA: 0xFFFFFFFF75C60FC0
	private Void Internal_DrawCursor(Rect position, GUIContent content, Int32 pos, Color cursorColor) { }

	// RVA: 0xFFFFFFFF75C610AC
	private Void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, Boolean isHover, Boolean isActive, Boolean on, Boolean hasKeyboardFocus, Boolean drawSelectionAsComposition, Int32 cursorFirst, Int32 cursorLast, Color cursorColor, Color selectionColor) { }

	// RVA: 0xFFFFFFFF75C61224
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, Int32 cursorStringIndex) { }

	// RVA: 0xFFFFFFFF75C61310
	internal Int32 Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0xFFFFFFFF75C613E8
	internal String Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, Int32 selectIndex, Int32 cursorIndex) { }

	// RVA: 0xFFFFFFFF75C614D8
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	// RVA: 0xFFFFFFFF75C61598
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	// RVA: 0xFFFFFFFF75C61670
	private Single Internal_CalcHeight(GUIContent content, Single width) { }

	// RVA: 0xFFFFFFFF75C616D0
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	// RVA: 0xFFFFFFFF75C564D8
	internal static Void SetMouseTooltip(String tooltip, Rect screenRect) { }

	// RVA: 0xFFFFFFFF75C617E0
	private static Single Internal_GetCursorFlashOffset() { }

	// RVA: 0xFFFFFFFF75C5EF58
	internal static Void SetDefaultFont(Font font) { }

	// RVA: 0xFFFFFFFF75C5E550
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C61814
	public Void .ctor(GUIStyle other) { }

	// RVA: 0xFFFFFFFF75C618C8
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75C56F9C
	public String get_name() { }

	// RVA: 0xFFFFFFFF75C5F5F0
	public Void set_name(String value) { }

	// RVA: 0xFFFFFFFF75C60178
	public GUIStyleState get_normal() { }

	// RVA: 0xFFFFFFFF75C619FC
	public Void set_normal(GUIStyleState value) { }

	// RVA: 0xFFFFFFFF723CF82C
	public RectOffset get_margin() { }

	// RVA: 0xFFFFFFFF723D2180
	public RectOffset get_padding() { }

	// RVA: 0xFFFFFFFF75C61A58
	public Single get_lineHeight() { }

	// RVA: 0xFFFFFFFF75C58E5C
	public Void Draw(Rect position, Boolean isHover, Boolean isActive, Boolean on, Boolean hasKeyboardFocus) { }

	// RVA: 0xFFFFFFFF75C563E4
	public Void Draw(Rect position, GUIContent content, Boolean isHover, Boolean isActive, Boolean on, Boolean hasKeyboardFocus) { }

	// RVA: 0xFFFFFFFF75C57EE0
	public Void Draw(Rect position, GUIContent content, Int32 controlID) { }

	// RVA: 0xFFFFFFFF75C54128
	public Void Draw(Rect position, GUIContent content, Int32 controlID, Boolean on) { }

	// RVA: 0xFFFFFFFF723CF200
	public Void Draw(Rect position, GUIContent content, Int32 controlID, Boolean on, Boolean hover) { }

	// RVA: 0xFFFFFFFF723D41E4
	private Void Draw(Rect position, GUIContent content, Int32 controlId, Boolean isHover, Boolean isActive, Boolean on, Boolean hasKeyboardFocus) { }

	// RVA: 0xFFFFFFFF75C61B64
	public Void DrawCursor(Rect position, GUIContent content, Int32 controlID, Int32 character) { }

	// RVA: 0xFFFFFFFF75C61D40
	internal Void DrawWithTextSelection(Rect position, GUIContent content, Boolean isActive, Boolean hasKeyboardFocus, Int32 firstSelectedCharacter, Int32 lastSelectedCharacter, Boolean drawSelectionAsComposition, Color selectionColor) { }

	// RVA: 0xFFFFFFFF75C61FA4
	internal Void DrawWithTextSelection(Rect position, GUIContent content, Int32 controlID, Int32 firstSelectedCharacter, Int32 lastSelectedCharacter, Boolean drawSelectionAsComposition) { }

	// RVA: 0xFFFFFFFF75C620F8
	public Void DrawWithTextSelection(Rect position, GUIContent content, Int32 controlID, Int32 firstSelectedCharacter, Int32 lastSelectedCharacter) { }

	// RVA: 0xFFFFFFFF75C62100
	public static GUIStyle op_Implicit(String str) { }

	// RVA: 0xFFFFFFFF723CFCF4
	public static GUIStyle get_none() { }

	// RVA: 0xFFFFFFFF75C62194
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, Int32 cursorStringIndex) { }

	// RVA: 0xFFFFFFFF75C62198
	public Int32 GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0xFFFFFFFF75C56A18
	public Vector2 CalcSize(GUIContent content) { }

	// RVA: 0xFFFFFFFF75C5E320
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	// RVA: 0xFFFFFFFF75C62208
	public Single CalcHeight(GUIContent content, Single width) { }

	// RVA: 0xFFFFFFFF75C5E1B4
	public Boolean get_isHeightDependantOnWidth() { }

	// RVA: 0xFFFFFFFF75C62268
	public Void CalcMinMaxWidth(GUIContent content, out Single minWidth, out Single maxWidth) { }

	// RVA: 0xFFFFFFFF75C622E8
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75C6236C
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C60970
	private Void get_contentOffset_Injected(out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C60A14
	private Void set_contentOffset_Injected(ref Vector2 value) { }

	// RVA: 0xFFFFFFFF75C60B58
	private Void set_Internal_clipOffset_Injected(ref Vector2 value) { }

	// RVA: 0xFFFFFFFF75C60E48
	private Void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, Boolean isHover, Boolean isActive, Boolean on, Boolean hasKeyboardFocus) { }

	// RVA: 0xFFFFFFFF75C60F50
	private Void Internal_Draw2_Injected(ref Rect position, GUIContent content, Int32 controlID, Boolean on) { }

	// RVA: 0xFFFFFFFF75C6103C
	private Void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, Int32 pos, ref Color cursorColor) { }

	// RVA: 0xFFFFFFFF75C6117C
	private Void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, Boolean isHover, Boolean isActive, Boolean on, Boolean hasKeyboardFocus, Boolean drawSelectionAsComposition, Int32 cursorFirst, Int32 cursorLast, ref Color cursorColor, ref Color selectionColor) { }

	// RVA: 0xFFFFFFFF75C612A0
	private Void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, Int32 cursorStringIndex, out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C61380
	private Int32 Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition) { }

	// RVA: 0xFFFFFFFF75C61468
	private String Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, Int32 selectIndex, Int32 cursorIndex) { }

	// RVA: 0xFFFFFFFF75C61540
	private Void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C61608
	private Void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C61738
	private Void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C61790
	private static Void SetMouseTooltip_Injected(String tooltip, ref Rect screenRect) { }

}

// Namespace: UnityEngine
public enum ImagePosition
{
	// Fields
	public Int32 value__; // 0x10
	public const ImagePosition ImageLeft = 0;
	public const ImagePosition ImageAbove = 1;
	public const ImagePosition ImageOnly = 2;
	public const ImagePosition TextOnly = 3;
}

// Namespace: UnityEngine
public class GUITargetAttribute
{
	// Fields
	internal Int32 displayMask; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF723D4354
	private static Int32 GetGUITargetAttrValue(Type klass, String methodName) { }

}

// Namespace: UnityEngine
public class GUIUtility
{
	// Fields
	internal static Int32 s_SkinMode; // 0x0
	internal static Int32 s_OriginalID; // 0x4
	internal static Action takeCapture; // 0x8
	internal static Action releaseCapture; // 0x10
	internal static Func<T0, T1, T2> processEvent; // 0x18
	internal static Action cleanupRoots; // 0x20
	internal static Func<T0, T1> endContainerGUIFromException; // 0x28
	internal static Action guiChanged; // 0x30
	private static Boolean <guiIsExiting>k__BackingField; // 0x38
	internal static Func<T0> s_HasCurrentWindowKeyFocusFunc; // 0x40

	// Properties
	internal static Single pixelsPerPoint { get; }
	internal static Int32 guiDepth { get; }
	internal static Boolean mouseUsed { set; }
	internal static Boolean textFieldInput { set; }
	public static String systemCopyBuffer { get; set; }
	internal static String compositionString { get; }
	internal static Vector2 compositionCursorPos { set; }
	internal static Boolean guiIsExiting { set; }
	public static Int32 hotControl { get; set; }
	public static Int32 keyboardControl { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C5DA18
	internal static Single get_pixelsPerPoint() { }

	// RVA: 0xFFFFFFFF75C62600
	internal static Int32 get_guiDepth() { }

	// RVA: 0xFFFFFFFF75C569D8
	internal static Void set_mouseUsed(Boolean value) { }

	// RVA: 0xFFFFFFFF75C54FA4
	internal static Void set_textFieldInput(Boolean value) { }

	// RVA: 0xFFFFFFFF75C62634
	public static String get_systemCopyBuffer() { }

	// RVA: 0xFFFFFFFF75C62668
	public static Void set_systemCopyBuffer(String value) { }

	// RVA: 0xFFFFFFFF75C52348
	public static Int32 GetControlID(Int32 hint, FocusType focusType, Rect rect) { }

	// RVA: 0xFFFFFFFF75C62700
	internal static Void BeginContainerFromOwner(ScriptableObject owner) { }

	// RVA: 0xFFFFFFFF75C62740
	internal static Void BeginContainer(ObjectGUIState objectGUIState) { }

	// RVA: 0xFFFFFFFF75C62780
	internal static Void Internal_EndContainer() { }

	// RVA: 0xFFFFFFFF75C627B4
	internal static Int32 CheckForTabEvent(Event evt) { }

	// RVA: 0xFFFFFFFF75C627F4
	internal static Void SetKeyboardControlToFirstControlId() { }

	// RVA: 0xFFFFFFFF75C62828
	internal static Void SetKeyboardControlToLastControlId() { }

	// RVA: 0xFFFFFFFF75C6285C
	internal static Boolean HasFocusableControls() { }

	// RVA: 0xFFFFFFFF75C62890
	internal static Boolean OwnsId(Int32 id) { }

	// RVA: 0xFFFFFFFF75C628D0
	public static Rect AlignRectToDevice(Rect rect, out Int32 widthInPixels, out Int32 heightInPixels) { }

	// RVA: 0xFFFFFFFF75C549BC
	internal static String get_compositionString() { }

	// RVA: 0xFFFFFFFF75C629B0
	internal static Void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C62A3C
	private static Int32 Internal_GetHotControl() { }

	// RVA: 0xFFFFFFFF75C62A70
	private static Int32 Internal_GetKeyboardControl() { }

	// RVA: 0xFFFFFFFF75C62AA4
	private static Void Internal_SetHotControl(Int32 value) { }

	// RVA: 0xFFFFFFFF75C62AE4
	private static Void Internal_SetKeyboardControl(Int32 value) { }

	// RVA: 0xFFFFFFFF75C62B24
	private static Object Internal_GetDefaultSkin(Int32 skinMode) { }

	// RVA: 0xFFFFFFFF75C62B64
	private static Void Internal_ExitGUI() { }

	// RVA: 0xFFFFFFFF75C62B98
	private static Void MarkGUIChanged() { }

	// RVA: 0xFFFFFFFF75C5AE58
	public static Int32 GetControlID(FocusType focus) { }

	// RVA: 0xFFFFFFFF75C528E8
	public static Int32 GetControlID(FocusType focus, Rect position) { }

	// RVA: 0xFFFFFFFF75C52234
	public static Int32 GetControlID(Int32 hint, FocusType focus) { }

	// RVA: 0xFFFFFFFF75C52EB0
	public static Object GetStateObject(Type t, Int32 controlID) { }

	// RVA: 0xFFFFFFFF75C62BB8
	internal static Void set_guiIsExiting(Boolean value) { }

	// RVA: 0xFFFFFFFF75C527B4
	public static Int32 get_hotControl() { }

	// RVA: 0xFFFFFFFF75C52774
	public static Void set_hotControl(Int32 value) { }

	// RVA: 0xFFFFFFFF75C62BCC
	internal static Void TakeCapture() { }

	// RVA: 0xFFFFFFFF75C62BEC
	internal static Void RemoveCapture() { }

	// RVA: 0xFFFFFFFF75C540B4
	public static Int32 get_keyboardControl() { }

	// RVA: 0xFFFFFFFF75C540E8
	public static Void set_keyboardControl(Int32 value) { }

	// RVA: 0xFFFFFFFF723D42D4
	internal static Boolean HasKeyFocus(Int32 controlID) { }

	// RVA: 0xFFFFFFFF75C62C0C
	public static Void ExitGUI() { }

	// RVA: 0xFFFFFFFF723CE9A8
	internal static GUISkin GetDefaultSkin() { }

	// RVA: 0xFFFFFFFF75C62C68
	internal static Boolean ProcessEvent(Int32 instanceID, IntPtr nativeEventPtr) { }

	// RVA: 0xFFFFFFFF75C62CE4
	internal static Void EndContainer() { }

	// RVA: 0xFFFFFFFF723D44E0
	internal static Void BeginGUI(Int32 skinMode, Int32 instanceID, Int32 useGUILayout) { }

	// RVA: 0xFFFFFFFF723D4604
	internal static Void EndGUI(Int32 layoutType) { }

	// RVA: 0xFFFFFFFF75C62D38
	internal static Boolean EndGUIFromException(Exception exception) { }

	// RVA: 0xFFFFFFFF75C62D7C
	internal static Boolean EndContainerGUIFromException(Exception exception) { }

	// RVA: 0xFFFFFFFF723D4548
	internal static Void ResetGlobalState() { }

	// RVA: 0xFFFFFFFF75C62DE4
	internal static Boolean IsExitGUIException(Exception exception) { }

	// RVA: 0xFFFFFFFF75C62D78
	internal static Boolean ShouldRethrowException(Exception exception) { }

	// RVA: 0xFFFFFFFF723CE72C
	internal static Void CheckOnGUI() { }

	// RVA: 0xFFFFFFFF75C62E60
	public static Void ScaleAroundPivot(Vector2 scale, Vector2 pivotPoint) { }

	// RVA: 0xFFFFFFFF75C56A80
	public static Rect AlignRectToDevice(Rect rect) { }

	// RVA: 0xFFFFFFFF75C6312C
	internal static Boolean HitTest(Rect rect, Vector2 point, Int32 offset) { }

	// RVA: 0xFFFFFFFF75C631DC
	internal static Boolean HitTest(Rect rect, Vector2 point, Boolean isDirectManipulationDevice) { }

	// RVA: 0xFFFFFFFF75C5632C
	internal static Boolean HitTest(Rect rect, Event evt) { }

	// RVA: 0xFFFFFFFF75C626A8
	private static Int32 GetControlID_Injected(Int32 hint, FocusType focusType, ref Rect rect) { }

	// RVA: 0xFFFFFFFF75C62948
	private static Void AlignRectToDevice_Injected(ref Rect rect, out Int32 widthInPixels, out Int32 heightInPixels, out Rect ret) { }

	// RVA: 0xFFFFFFFF75C629FC
	private static Void set_compositionCursorPos_Injected(ref Vector2 value) { }

}

// Namespace: UnityEngine
public sealed class ExitGUIException
{
	// Methods

	// RVA: 0xFFFFFFFF75C50724
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C5077C
	internal Void .ctor(String message) { }

}

// Namespace: UnityEngine
public class GUILayoutEntry
{
	// Fields
	public Single minWidth; // 0x10
	public Single maxWidth; // 0x14
	public Single minHeight; // 0x18
	public Single maxHeight; // 0x1C
	public Rect rect; // 0x20
	public Int32 stretchWidth; // 0x30
	public Int32 stretchHeight; // 0x34
	public Boolean consideredForMargin; // 0x38
	private GUIStyle m_Style; // 0x40
	internal static Rect kDummyRect; // 0x0
	protected static Int32 indent; // 0x10

	// Properties
	public GUIStyle style { get; set; }
	public virtual Int32 marginLeft { get; }
	public virtual Int32 marginRight { get; }
	public virtual Int32 marginTop { get; }
	public virtual Int32 marginBottom { get; }
	public Int32 marginHorizontal { get; }
	public Int32 marginVertical { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C5CA58
	public GUIStyle get_style() { }

	// RVA: 0xFFFFFFFF75C5CA60
	public Void set_style(GUIStyle value) { }

	// RVA: 0xFFFFFFFF75C5CAB8
	public virtual Int32 get_marginLeft() { }

	// RVA: 0xFFFFFFFF75C5CB20
	public virtual Int32 get_marginRight() { }

	// RVA: 0xFFFFFFFF75C5CB88
	public virtual Int32 get_marginTop() { }

	// RVA: 0xFFFFFFFF75C5CBF0
	public virtual Int32 get_marginBottom() { }

	// RVA: 0xFFFFFFFF75C5CC58
	public Int32 get_marginHorizontal() { }

	// RVA: 0xFFFFFFFF75C5CCA0
	public Int32 get_marginVertical() { }

	// RVA: 0xFFFFFFFF723D1198
	public Void .ctor(Single _minWidth, Single _maxWidth, Single _minHeight, Single _maxHeight, GUIStyle _style) { }

	// RVA: 0xFFFFFFFF75C5CCE8
	public Void .ctor(Single _minWidth, Single _maxWidth, Single _minHeight, Single _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5CDC8
	public virtual Void CalcWidth() { }

	// RVA: 0xFFFFFFFF75C5CDCC
	public virtual Void CalcHeight() { }

	// RVA: 0xFFFFFFFF75C5CDD0
	public virtual Void SetHorizontal(Single x, Single width) { }

	// RVA: 0xFFFFFFFF75C5CDDC
	public virtual Void SetVertical(Single y, Single height) { }

	// RVA: 0xFFFFFFFF723D12D4
	protected virtual Void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0xFFFFFFFF723D1418
	public virtual Void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5CE68
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75C5D380
	private static Void .cctor() { }

}

// Namespace: UnityEngine
internal sealed class GUIGridSizer
{
	// Fields
	private readonly Int32 m_Count; // 0x48
	private readonly Int32 m_XCount; // 0x4C
	private readonly Single m_MinButtonWidth; // 0x50
	private readonly Single m_MaxButtonWidth; // 0x54
	private readonly Single m_MinButtonHeight; // 0x58
	private readonly Single m_MaxButtonHeight; // 0x5C

	// Properties
	private Int32 rows { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C59D64
	public static Rect GetRect(GUIContent[] contents, Int32 xCount, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C59EF8
	private Void .ctor(GUIContent[] contents, Int32 xCount, GUIStyle buttonStyle, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C5A82C
	private Int32 get_rows() { }

}

// Namespace: UnityEngine
internal sealed class GUIWordWrapSizer
{
	// Fields
	private readonly GUIContent m_Content; // 0x48
	private readonly Single m_ForcedMinHeight; // 0x50
	private readonly Single m_ForcedMaxHeight; // 0x54

	// Methods

	// RVA: 0xFFFFFFFF75C5E264
	public Void .ctor(GUIStyle style, GUIContent content, GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF75C631E4
	public override Void CalcWidth() { }

	// RVA: 0xFFFFFFFF75C632C0
	public override Void CalcHeight() { }

}

// Namespace: UnityEngine
public class GUILayoutGroup
{
	// Fields
	public List<T0> entries; // 0x48
	public Boolean isVertical; // 0x50
	public Boolean resetCoords; // 0x51
	public Single spacing; // 0x54
	public Boolean sameSize; // 0x58
	public Boolean isWindow; // 0x59
	public Int32 windowID; // 0x5C
	private Int32 m_Cursor; // 0x60
	protected Int32 m_StretchableCountX; // 0x64
	protected Int32 m_StretchableCountY; // 0x68
	protected Boolean m_UserSpecifiedWidth; // 0x6C
	protected Boolean m_UserSpecifiedHeight; // 0x6D
	protected Single m_ChildMinWidth; // 0x70
	protected Single m_ChildMaxWidth; // 0x74
	protected Single m_ChildMinHeight; // 0x78
	protected Single m_ChildMaxHeight; // 0x7C
	protected Int32 m_MarginLeft; // 0x80
	protected Int32 m_MarginRight; // 0x84
	protected Int32 m_MarginTop; // 0x88
	protected Int32 m_MarginBottom; // 0x8C
	private static readonly GUILayoutEntry none; // 0x0

	// Properties
	public override Int32 marginLeft { get; }
	public override Int32 marginRight { get; }
	public override Int32 marginTop { get; }
	public override Int32 marginBottom { get; }

	// Methods

	// RVA: 0xFFFFFFFF723D1670
	public override Int32 get_marginLeft() { }

	// RVA: 0xFFFFFFFF723D1678
	public override Int32 get_marginRight() { }

	// RVA: 0xFFFFFFFF75C5D3A0
	public override Int32 get_marginTop() { }

	// RVA: 0xFFFFFFFF75C5D3A8
	public override Int32 get_marginBottom() { }

	// RVA: 0xFFFFFFFF723D1680
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF723D17CC
	public override Void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0xFFFFFFFF723D189C
	protected override Void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0xFFFFFFFF75C5D3B0
	public Void ResetCursor() { }

	// RVA: 0xFFFFFFFF75C5A5CC
	public GUILayoutEntry GetNext() { }

	// RVA: 0xFFFFFFFF75C5A56C
	public Void Add(GUILayoutEntry e) { }

	// RVA: 0xFFFFFFFF723D1A14
	public override Void CalcWidth() { }

	// RVA: 0xFFFFFFFF723D2234
	public override Void SetHorizontal(Single x, Single width) { }

	// RVA: 0xFFFFFFFF723D2C28
	public override Void CalcHeight() { }

	// RVA: 0xFFFFFFFF723D3318
	public override Void SetVertical(Single y, Single height) { }

	// RVA: 0xFFFFFFFF75C5D3B8
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75C5D660
	private static Void .cctor() { }

}

// Namespace: UnityEngine
internal sealed class GUIScrollGroup
{
	// Fields
	public Single calcMinWidth; // 0x90
	public Single calcMaxWidth; // 0x94
	public Single calcMinHeight; // 0x98
	public Single calcMaxHeight; // 0x9C
	public Single clientWidth; // 0xA0
	public Single clientHeight; // 0xA4
	public Boolean allowHorizontalScroll; // 0xA8
	public Boolean allowVerticalScroll; // 0xA9
	public Boolean needsHorizontalScrollbar; // 0xAA
	public Boolean needsVerticalScrollbar; // 0xAB
	public GUIStyle horizontalScrollbar; // 0xB0
	public GUIStyle verticalScrollbar; // 0xB8

	// Methods

	// RVA: 0xFFFFFFFF75C5E6F0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C5E734
	public override Void CalcWidth() { }

	// RVA: 0xFFFFFFFF75C5E7B0
	public override Void SetHorizontal(Single x, Single width) { }

	// RVA: 0xFFFFFFFF75C5E8E0
	public override Void CalcHeight() { }

	// RVA: 0xFFFFFFFF75C5EA00
	public override Void SetVertical(Single y, Single height) { }

}

// Namespace: UnityEngine
internal class ObjectGUIState
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C63368
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C633DC
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75C63488
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75C63420
	private Void Destroy() { }

	// RVA: 0xFFFFFFFF75C633A8
	private static IntPtr Internal_Create() { }

	// RVA: 0xFFFFFFFF75C634F0
	private static Void Internal_Destroy(IntPtr ptr) { }

}

// Namespace: UnityEngine
internal class ScrollViewState
{
	// Fields
	public Rect position; // 0x10
	public Rect visibleRect; // 0x20
	public Rect viewRect; // 0x30
	public Vector2 scrollPosition; // 0x40
	public Boolean apply; // 0x48

	// Methods

	// RVA: 0xFFFFFFFF75C63530
	public Void .ctor() { }

}

// Namespace: UnityEngine
internal class SliderState
{
	// Fields
	public Single dragStartPos; // 0x10
	public Single dragStartValue; // 0x14
	public Boolean isDragging; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75C64C5C
	public Void .ctor() { }

}

// Namespace: UnityEngine
internal struct SliderHandler
{
	// Fields
	private readonly Rect position; // 0x10
	private readonly Single currentValue; // 0x20
	private readonly Single size; // 0x24
	private readonly Single start; // 0x28
	private readonly Single end; // 0x2C
	private readonly GUIStyle slider; // 0x30
	private readonly GUIStyle thumb; // 0x38
	private readonly GUIStyle thumbExtent; // 0x40
	private readonly Boolean horiz; // 0x48
	private readonly Int32 id; // 0x4C

	// Methods

	// RVA: 0xFFFFFFFF7114F5D4
	public Void .ctor(Rect position, Single currentValue, Single size, Single start, Single end, GUIStyle slider, GUIStyle thumb, Boolean horiz, Int32 id, GUIStyle thumbExtent) { }

	// RVA: 0xFFFFFFFF7114F67C
	public Single Handle() { }

	// RVA: 0xFFFFFFFF7114F684
	private Single OnMouseDown() { }

	// RVA: 0xFFFFFFFF7114F68C
	private Single OnMouseDrag() { }

	// RVA: 0xFFFFFFFF7114F694
	private Single OnMouseUp() { }

	// RVA: 0xFFFFFFFF7114F69C
	private Single OnRepaint() { }

	// RVA: 0xFFFFFFFF7114F6A4
	private EventType CurrentEventType() { }

	// RVA: 0xFFFFFFFF7114F6AC
	private Int32 CurrentScrollTroughSide() { }

	// RVA: 0xFFFFFFFF7114F6B4
	private Boolean IsEmptySlider() { }

	// RVA: 0xFFFFFFFF7114F6C4
	private Boolean SupportsPageMovements() { }

	// RVA: 0xFFFFFFFF7114F6CC
	private Single PageMovementValue() { }

	// RVA: 0xFFFFFFFF7114F6D4
	private Single PageUpMovementBound() { }

	// RVA: 0xFFFFFFFF7114F6DC
	private Event CurrentEvent() { }

	// RVA: 0xFFFFFFFF7114F6F0
	private Single ValueForCurrentMousePosition() { }

	// RVA: 0xFFFFFFFF7114F6F8
	private Single Clamp(Single value) { }

	// RVA: 0xFFFFFFFF7114F700
	private Rect ThumbSelectionRect() { }

	// RVA: 0xFFFFFFFF7114F708
	private Void StartDraggingWithValue(Single dragStartValue) { }

	// RVA: 0xFFFFFFFF7114F710
	private SliderState SliderState() { }

	// RVA: 0xFFFFFFFF7114F718
	private Rect ThumbExtRect() { }

	// RVA: 0xFFFFFFFF7114F720
	private Rect ThumbRect() { }

	// RVA: 0xFFFFFFFF7114F738
	private Rect VerticalThumbRect() { }

	// RVA: 0xFFFFFFFF7114F740
	private Rect HorizontalThumbRect() { }

	// RVA: 0xFFFFFFFF7114F748
	private Single ClampedCurrentValue() { }

	// RVA: 0xFFFFFFFF7114F758
	private Single MousePosition() { }

	// RVA: 0xFFFFFFFF7114F760
	private Single ValuesPerPixel() { }

	// RVA: 0xFFFFFFFF7114F768
	private Single ThumbSize() { }

	// RVA: 0xFFFFFFFF7114F770
	private Single MaxValue() { }

	// RVA: 0xFFFFFFFF7114F778
	private Single MinValue() { }

}

// Namespace: UnityEngine
public class TextEditor
{
	// Fields
	public TouchScreenKeyboard keyboardOnScreen; // 0x10
	public Int32 controlID; // 0x18
	public GUIStyle style; // 0x20
	public Boolean multiline; // 0x28
	public Boolean hasHorizontalCursorPos; // 0x29
	public Boolean isPasswordField; // 0x2A
	internal Boolean m_HasFocus; // 0x2B
	public Vector2 scrollOffset; // 0x2C
	private GUIContent m_Content; // 0x38
	private Rect m_Position; // 0x40
	private Int32 m_CursorIndex; // 0x50
	private Int32 m_SelectIndex; // 0x54
	private Boolean m_RevealCursor; // 0x58
	public Vector2 graphicalCursorPos; // 0x5C
	public Vector2 graphicalSelectCursorPos; // 0x64
	private Boolean m_MouseDragSelectsWholeWords; // 0x6C
	private Int32 m_DblClickInitPos; // 0x70
	private DblClickSnapping m_DblClickSnap; // 0x74
	private Boolean m_bJustSelected; // 0x75
	private Int32 m_iAltCursorPos; // 0x78
	private String oldText; // 0x80
	private Int32 oldPos; // 0x88
	private Int32 oldSelectPos; // 0x8C
	private static Dictionary<T0, T1> s_Keyactions; // 0x0

	// Properties
	public GUIContent content { get; set; }
	public String text { get; set; }
	public Rect position { get; set; }
	internal virtual Rect localPosition { get; }
	public Int32 cursorIndex { get; set; }
	public Int32 selectIndex { get; set; }
	public Boolean hasSelection { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C64C60
	public GUIContent get_content() { }

	// RVA: 0xFFFFFFFF75C64C68
	public Void set_content(GUIContent value) { }

	// RVA: 0xFFFFFFFF75C54914
	public String get_text() { }

	// RVA: 0xFFFFFFFF75C52F1C
	public Void set_text(String value) { }

	// RVA: 0xFFFFFFFF75C64CE8
	public Rect get_position() { }

	// RVA: 0xFFFFFFFF75C52FD4
	public Void set_position(Rect value) { }

	// RVA: 0xFFFFFFFF75C65168
	internal virtual Rect get_localPosition() { }

	// RVA: 0xFFFFFFFF75C65174
	public Int32 get_cursorIndex() { }

	// RVA: 0xFFFFFFFF75C6517C
	public Void set_cursorIndex(Int32 value) { }

	// RVA: 0xFFFFFFFF75C651E8
	public Int32 get_selectIndex() { }

	// RVA: 0xFFFFFFFF75C651F0
	public Void set_selectIndex(Int32 value) { }

	// RVA: 0xFFFFFFFF75C65254
	private Void ClearCursorPos() { }

	// RVA: 0xFFFFFFFF75C65264
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C65360
	public Void OnFocus() { }

	// RVA: 0xFFFFFFFF75C654D4
	public Void OnLostFocus() { }

	// RVA: 0xFFFFFFFF75C6551C
	private Void GrabGraphicalCursorPos() { }

	// RVA: 0xFFFFFFFF75C5490C
	public Boolean HandleKeyEvent(Event e) { }

	// RVA: 0xFFFFFFFF75C655A4
	internal Boolean HandleKeyEvent(Event e, Boolean textIsReadOnly) { }

	// RVA: 0xFFFFFFFF75C664A8
	public Boolean DeleteLineBack() { }

	// RVA: 0xFFFFFFFF75C6679C
	public Boolean DeleteWordBack() { }

	// RVA: 0xFFFFFFFF75C66988
	public Boolean DeleteWordForward() { }

	// RVA: 0xFFFFFFFF75C66BAC
	public Boolean Delete() { }

	// RVA: 0xFFFFFFFF75C66CF0
	public Boolean Backspace() { }

	// RVA: 0xFFFFFFFF75C65418
	public Void SelectAll() { }

	// RVA: 0xFFFFFFFF75C66EBC
	public Void SelectNone() { }

	// RVA: 0xFFFFFFFF75C665E8
	public Boolean get_hasSelection() { }

	// RVA: 0xFFFFFFFF75C665F8
	public Boolean DeleteSelection() { }

	// RVA: 0xFFFFFFFF75C549F0
	public Void ReplaceSelection(String replace) { }

	// RVA: 0xFFFFFFFF75C5497C
	public Void Insert(Char c) { }

	// RVA: 0xFFFFFFFF75C66F24
	public Void MoveRight() { }

	// RVA: 0xFFFFFFFF75C67054
	public Void MoveLeft() { }

	// RVA: 0xFFFFFFFF75C6717C
	public Void MoveUp() { }

	// RVA: 0xFFFFFFFF75C67338
	public Void MoveDown() { }

	// RVA: 0xFFFFFFFF75C6751C
	public Void MoveLineStart() { }

	// RVA: 0xFFFFFFFF75C67660
	public Void MoveLineEnd() { }

	// RVA: 0xFFFFFFFF75C677CC
	public Void MoveGraphicalLineStart() { }

	// RVA: 0xFFFFFFFF75C679A8
	public Void MoveGraphicalLineEnd() { }

	// RVA: 0xFFFFFFFF75C67B7C
	public Void MoveTextStart() { }

	// RVA: 0xFFFFFFFF75C67C20
	public Void MoveTextEnd() { }

	// RVA: 0xFFFFFFFF75C67CDC
	private Int32 IndexOfEndOfLine(Int32 startIndex) { }

	// RVA: 0xFFFFFFFF75C67D38
	public Void MoveParagraphForward() { }

	// RVA: 0xFFFFFFFF75C67E64
	public Void MoveParagraphBackward() { }

	// RVA: 0xFFFFFFFF75C5413C
	public Void MoveCursorToPosition(Vector2 cursorPosition) { }

	// RVA: 0xFFFFFFFF75C67FD0
	protected internal Void MoveCursorToPosition_Internal(Vector2 cursorPosition, Boolean shift) { }

	// RVA: 0xFFFFFFFF75C54444
	public Void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0xFFFFFFFF75C682A0
	public Void SelectLeft() { }

	// RVA: 0xFFFFFFFF75C683A8
	public Void SelectRight() { }

	// RVA: 0xFFFFFFFF75C684B0
	public Void SelectUp() { }

	// RVA: 0xFFFFFFFF75C68598
	public Void SelectDown() { }

	// RVA: 0xFFFFFFFF75C68694
	public Void SelectTextEnd() { }

	// RVA: 0xFFFFFFFF75C68718
	public Void SelectTextStart() { }

	// RVA: 0xFFFFFFFF75C5431C
	public Void MouseDragSelectsWholeWords(Boolean on) { }

	// RVA: 0xFFFFFFFF75C54314
	public Void DblClickSnap(DblClickSnapping snapping) { }

	// RVA: 0xFFFFFFFF75C678A0
	private Int32 GetGraphicalLineStart(Int32 p) { }

	// RVA: 0xFFFFFFFF75C67A7C
	private Int32 GetGraphicalLineEnd(Int32 p) { }

	// RVA: 0xFFFFFFFF75C68784
	private Int32 FindNextSeperator(Int32 startPos) { }

	// RVA: 0xFFFFFFFF75C688E0
	private Int32 FindPrevSeperator(Int32 startPos) { }

	// RVA: 0xFFFFFFFF75C6897C
	public Void MoveWordRight() { }

	// RVA: 0xFFFFFFFF75C68A88
	public Void MoveToStartOfNextWord() { }

	// RVA: 0xFFFFFFFF75C68B7C
	public Void MoveToEndOfPreviousWord() { }

	// RVA: 0xFFFFFFFF75C68C70
	public Void SelectToStartOfNextWord() { }

	// RVA: 0xFFFFFFFF75C68CF4
	public Void SelectToEndOfPreviousWord() { }

	// RVA: 0xFFFFFFFF75C68828
	private CharacterType ClassifyChar(Int32 index) { }

	// RVA: 0xFFFFFFFF75C66A18
	public Int32 FindStartOfNextWord(Int32 p) { }

	// RVA: 0xFFFFFFFF75C668B8
	private Int32 FindEndOfPreviousWord(Int32 p) { }

	// RVA: 0xFFFFFFFF75C68D78
	public Void MoveWordLeft() { }

	// RVA: 0xFFFFFFFF75C68E7C
	public Void SelectWordRight() { }

	// RVA: 0xFFFFFFFF75C68FE0
	public Void SelectWordLeft() { }

	// RVA: 0xFFFFFFFF75C69144
	public Void ExpandSelectGraphicalLineStart() { }

	// RVA: 0xFFFFFFFF75C69258
	public Void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0xFFFFFFFF75C6936C
	public Void SelectGraphicalLineStart() { }

	// RVA: 0xFFFFFFFF75C693F0
	public Void SelectGraphicalLineEnd() { }

	// RVA: 0xFFFFFFFF75C69474
	public Void SelectParagraphForward() { }

	// RVA: 0xFFFFFFFF75C69578
	public Void SelectParagraphBackward() { }

	// RVA: 0xFFFFFFFF75C541D0
	public Void SelectCurrentWord() { }

	// RVA: 0xFFFFFFFF75C68170
	private Int32 FindEndOfClassification(Int32 p, Direction dir) { }

	// RVA: 0xFFFFFFFF75C54334
	public Void SelectCurrentParagraph() { }

	// RVA: 0xFFFFFFFF75C54014
	public Void UpdateScrollOffsetIfNeeded(Event evt) { }

	// RVA: 0xFFFFFFFF75C64CF4
	internal Void UpdateScrollOffset() { }

	// RVA: 0xFFFFFFFF75C54AF0
	public Void DrawCursor(String newText) { }

	// RVA: 0xFFFFFFFF75C66114
	private Boolean PerformOperation(TextEditOp operation, Boolean textIsReadOnly) { }

	// RVA: 0xFFFFFFFF75C52F84
	public Void SaveBackup() { }

	// RVA: 0xFFFFFFFF75C696F0
	public Boolean Cut() { }

	// RVA: 0xFFFFFFFF75C6972C
	public Void Copy() { }

	// RVA: 0xFFFFFFFF75C69894
	private static String ReplaceNewlinesWithSpaces(String value) { }

	// RVA: 0xFFFFFFFF75C6980C
	public Boolean Paste() { }

	// RVA: 0xFFFFFFFF75C6991C
	private static Void MapKey(String key, TextEditOp action) { }

	// RVA: 0xFFFFFFFF75C6572C
	private Void InitKeyActions() { }

	// RVA: 0xFFFFFFFF75C5307C
	public Void DetectFocusChange() { }

	// RVA: 0xFFFFFFFF75C699A4
	internal virtual Void OnDetectFocusChange() { }

	// RVA: 0xFFFFFFFF75C69A4C
	internal virtual Void OnCursorIndexChange() { }

	// RVA: 0xFFFFFFFF75C69A50
	internal virtual Void OnSelectIndexChange() { }

	// RVA: 0xFFFFFFFF75C69A54
	private Void ClampTextIndex(ref Int32 index) { }

	// RVA: 0xFFFFFFFF75C64CA0
	private Void EnsureValidCodePointIndex(ref Int32 index) { }

	// RVA: 0xFFFFFFFF75C69AC8
	private Boolean IsValidCodePointIndex(Int32 index) { }

	// RVA: 0xFFFFFFFF75C66E1C
	private Int32 PreviousCodePointIndex(Int32 index) { }

	// RVA: 0xFFFFFFFF75C66C4C
	private Int32 NextCodePointIndex(Int32 index) { }

}

// Namespace: 
public enum DblClickSnapping
{
	// Fields
	public Byte value__; // 0x10
	public const DblClickSnapping WORDS = 0;
	public const DblClickSnapping PARAGRAPHS = 1;
}

// Namespace: 
private enum CharacterType
{
	// Fields
	public Int32 value__; // 0x10
	public const CharacterType LetterLike = 0;
	public const CharacterType Symbol = 1;
	public const CharacterType Symbol2 = 2;
	public const CharacterType WhiteSpace = 3;
}

// Namespace: 
private enum Direction
{
	// Fields
	public Int32 value__; // 0x10
	public const Direction Forward = 0;
	public const Direction Backward = 1;
}

// Namespace: 
private enum TextEditOp
{
	// Fields
	public Int32 value__; // 0x10
	public const TextEditOp MoveLeft = 0;
	public const TextEditOp MoveRight = 1;
	public const TextEditOp MoveUp = 2;
	public const TextEditOp MoveDown = 3;
	public const TextEditOp MoveLineStart = 4;
	public const TextEditOp MoveLineEnd = 5;
	public const TextEditOp MoveTextStart = 6;
	public const TextEditOp MoveTextEnd = 7;
	public const TextEditOp MovePageUp = 8;
	public const TextEditOp MovePageDown = 9;
	public const TextEditOp MoveGraphicalLineStart = 10;
	public const TextEditOp MoveGraphicalLineEnd = 11;
	public const TextEditOp MoveWordLeft = 12;
	public const TextEditOp MoveWordRight = 13;
	public const TextEditOp MoveParagraphForward = 14;
	public const TextEditOp MoveParagraphBackward = 15;
	public const TextEditOp MoveToStartOfNextWord = 16;
	public const TextEditOp MoveToEndOfPreviousWord = 17;
	public const TextEditOp SelectLeft = 18;
	public const TextEditOp SelectRight = 19;
	public const TextEditOp SelectUp = 20;
	public const TextEditOp SelectDown = 21;
	public const TextEditOp SelectTextStart = 22;
	public const TextEditOp SelectTextEnd = 23;
	public const TextEditOp SelectPageUp = 24;
	public const TextEditOp SelectPageDown = 25;
	public const TextEditOp ExpandSelectGraphicalLineStart = 26;
	public const TextEditOp ExpandSelectGraphicalLineEnd = 27;
	public const TextEditOp SelectGraphicalLineStart = 28;
	public const TextEditOp SelectGraphicalLineEnd = 29;
	public const TextEditOp SelectWordLeft = 30;
	public const TextEditOp SelectWordRight = 31;
	public const TextEditOp SelectToEndOfPreviousWord = 32;
	public const TextEditOp SelectToStartOfNextWord = 33;
	public const TextEditOp SelectParagraphBackward = 34;
	public const TextEditOp SelectParagraphForward = 35;
	public const TextEditOp Delete = 36;
	public const TextEditOp Backspace = 37;
	public const TextEditOp DeleteWordBack = 38;
	public const TextEditOp DeleteWordForward = 39;
	public const TextEditOp DeleteLineBack = 40;
	public const TextEditOp Cut = 41;
	public const TextEditOp Copy = 42;
	public const TextEditOp Paste = 43;
	public const TextEditOp SelectAll = 44;
	public const TextEditOp SelectNone = 45;
	public const TextEditOp ScrollStart = 46;
	public const TextEditOp ScrollEnd = 47;
	public const TextEditOp ScrollPageUp = 48;
	public const TextEditOp ScrollPageDown = 49;
}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Methods

	// RVA: 0xFFFFFFFF75C4D184
	internal static UInt32 ComputeStringHash(String s) { }

}


