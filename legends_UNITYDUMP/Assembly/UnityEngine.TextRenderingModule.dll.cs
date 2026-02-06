// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public enum FontStyle
{
	// Fields
	public Int32 value__; // 0x10
	public const FontStyle Normal = 0;
	public const FontStyle Bold = 1;
	public const FontStyle Italic = 2;
	public const FontStyle BoldAndItalic = 3;
}

// Namespace: UnityEngine
internal enum TextGenerationError
{
	// Fields
	public Int32 value__; // 0x10
	public const TextGenerationError None = 0;
	public const TextGenerationError CustomSizeOnNonDynamicFont = 1;
	public const TextGenerationError CustomStyleOnNonDynamicFont = 2;
	public const TextGenerationError NoFont = 4;
}

// Namespace: UnityEngine
public struct TextGenerationSettings
{
	// Fields
	public Font font; // 0x10
	public Color color; // 0x18
	public Int32 fontSize; // 0x28
	public Single lineSpacing; // 0x2C
	public Boolean richText; // 0x30
	public Single scaleFactor; // 0x34
	public FontStyle fontStyle; // 0x38
	public TextAnchor textAnchor; // 0x3C
	public Boolean alignByGeometry; // 0x40
	public Boolean resizeTextForBestFit; // 0x41
	public Int32 resizeTextMinSize; // 0x44
	public Int32 resizeTextMaxSize; // 0x48
	public Boolean updateBounds; // 0x4C
	public VerticalWrapMode verticalOverflow; // 0x50
	public HorizontalWrapMode horizontalOverflow; // 0x54
	public Vector2 generationExtents; // 0x58
	public Vector2 pivot; // 0x60
	public Boolean generateOutOfBounds; // 0x68

	// Methods

	// RVA: 0xFFFFFFFF71152F54
	private Boolean CompareColors(Color left, Color right) { }

	// RVA: 0xFFFFFFFF71152F58
	private Boolean CompareVector2(Vector2 left, Vector2 right) { }

	// RVA: 0xFFFFFFFF71152F5C
	public Boolean Equals(TextGenerationSettings other) { }

}

// Namespace: UnityEngine
public sealed class TextGenerator
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private String m_LastString; // 0x18
	private TextGenerationSettings m_LastSettings; // 0x20
	private Boolean m_HasGenerated; // 0x80
	private TextGenerationError m_LastValid; // 0x84
	private readonly List<T0> m_Verts; // 0x88
	private readonly List<T0> m_Characters; // 0x90
	private readonly List<T0> m_Lines; // 0x98
	private Boolean m_CachedVerts; // 0xA0
	private Boolean m_CachedCharacters; // 0xA1
	private Boolean m_CachedLines; // 0xA2

	// Properties
	public Int32 characterCountVisible { get; }
	public IList<T0> verts { get; }
	public IList<T0> characters { get; }
	public IList<T0> lines { get; }
	public Rect rectExtents { get; }
	public Int32 characterCount { get; }
	public Int32 lineCount { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C85390
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C85398
	public Void .ctor(Int32 initialCapacity) { }

	// RVA: 0xFFFFFFFF75C85510
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75C855D4
	private Void System.IDisposable.Dispose() { }

	// RVA: 0xFFFFFFFF75C8567C
	public Int32 get_characterCountVisible() { }

	// RVA: 0xFFFFFFFF75C85704
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0xFFFFFFFF75C858C8
	public Void Invalidate() { }

	// RVA: 0xFFFFFFFF75C858D0
	public Void GetCharacters(List<T0> characters) { }

	// RVA: 0xFFFFFFFF75C85970
	public Void GetLines(List<T0> lines) { }

	// RVA: 0xFFFFFFFF75C85A10
	public Void GetVertices(List<T0> vertices) { }

	// RVA: 0xFFFFFFFF75C85AB0
	public Single GetPreferredWidth(String str, TextGenerationSettings settings) { }

	// RVA: 0xFFFFFFFF75C85BAC
	public Single GetPreferredHeight(String str, TextGenerationSettings settings) { }

	// RVA: 0xFFFFFFFF75C85C08
	public Boolean PopulateWithErrors(String str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0xFFFFFFFF75C85B10
	public Boolean Populate(String str, TextGenerationSettings settings) { }

	// RVA: 0xFFFFFFFF75C85D5C
	private TextGenerationError PopulateWithError(String str, TextGenerationSettings settings) { }

	// RVA: 0xFFFFFFFF75C85E08
	private TextGenerationError PopulateAlways(String str, TextGenerationSettings settings) { }

	// RVA: 0xFFFFFFFF75C860B4
	public IList<T0> get_verts() { }

	// RVA: 0xFFFFFFFF75C86120
	public IList<T0> get_characters() { }

	// RVA: 0xFFFFFFFF75C8618C
	public IList<T0> get_lines() { }

	// RVA: 0xFFFFFFFF75C85B50
	public Rect get_rectExtents() { }

	// RVA: 0xFFFFFFFF75C856C4
	public Int32 get_characterCount() { }

	// RVA: 0xFFFFFFFF75C86248
	public Int32 get_lineCount() { }

	// RVA: 0xFFFFFFFF75C854DC
	private static IntPtr Internal_Create() { }

	// RVA: 0xFFFFFFFF75C8563C
	private static Void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF75C86288
	internal Boolean Populate_Internal(String str, Font font, Color color, Int32 fontSize, Single scaleFactor, Single lineSpacing, FontStyle style, Boolean richText, Boolean resizeTextForBestFit, Int32 resizeTextMinSize, Int32 resizeTextMaxSize, Int32 verticalOverFlow, Int32 horizontalOverflow, Boolean updateBounds, TextAnchor anchor, Single extentsX, Single extentsY, Single pivotX, Single pivotY, Boolean generateOutOfBounds, Boolean alignByGeometry, out UInt32 error) { }

	// RVA: 0xFFFFFFFF75C85F44
	internal Boolean Populate_Internal(String str, Font font, Color color, Int32 fontSize, Single scaleFactor, Single lineSpacing, FontStyle style, Boolean richText, Boolean resizeTextForBestFit, Int32 resizeTextMinSize, Int32 resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, Boolean updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, Boolean generateOutOfBounds, Boolean alignByGeometry, out TextGenerationError error) { }

	// RVA: 0xFFFFFFFF75C85A60
	private Void GetVerticesInternal(Object vertices) { }

	// RVA: 0xFFFFFFFF75C85920
	private Void GetCharactersInternal(Object characters) { }

	// RVA: 0xFFFFFFFF75C859C0
	private Void GetLinesInternal(Object lines) { }

	// RVA: 0xFFFFFFFF75C861F8
	private Void get_rectExtents_Injected(out Rect ret) { }

	// RVA: 0xFFFFFFFF75C863C8
	private Boolean Populate_Internal_Injected(String str, Font font, ref Color color, Int32 fontSize, Single scaleFactor, Single lineSpacing, FontStyle style, Boolean richText, Boolean resizeTextForBestFit, Int32 resizeTextMinSize, Int32 resizeTextMaxSize, Int32 verticalOverFlow, Int32 horizontalOverflow, Boolean updateBounds, TextAnchor anchor, Single extentsX, Single extentsY, Single pivotX, Single pivotY, Boolean generateOutOfBounds, Boolean alignByGeometry, out UInt32 error) { }

}

// Namespace: UnityEngine
public enum TextAlignment
{
	// Fields
	public Int32 value__; // 0x10
	public const TextAlignment Left = 0;
	public const TextAlignment Center = 1;
	public const TextAlignment Right = 2;
}

// Namespace: UnityEngine
public enum TextAnchor
{
	// Fields
	public Int32 value__; // 0x10
	public const TextAnchor UpperLeft = 0;
	public const TextAnchor UpperCenter = 1;
	public const TextAnchor UpperRight = 2;
	public const TextAnchor MiddleLeft = 3;
	public const TextAnchor MiddleCenter = 4;
	public const TextAnchor MiddleRight = 5;
	public const TextAnchor LowerLeft = 6;
	public const TextAnchor LowerCenter = 7;
	public const TextAnchor LowerRight = 8;
}

// Namespace: UnityEngine
public enum HorizontalWrapMode
{
	// Fields
	public Int32 value__; // 0x10
	public const HorizontalWrapMode Wrap = 0;
	public const HorizontalWrapMode Overflow = 1;
}

// Namespace: UnityEngine
public enum VerticalWrapMode
{
	// Fields
	public Int32 value__; // 0x10
	public const VerticalWrapMode Truncate = 0;
	public const VerticalWrapMode Overflow = 1;
}

// Namespace: UnityEngine
public sealed class TextMesh
{
	// Properties
	public String text { get; set; }
	public Font font { get; set; }
	public Int32 fontSize { get; set; }
	public FontStyle fontStyle { get; set; }
	public Single offsetZ { get; set; }
	public TextAlignment alignment { get; set; }
	public TextAnchor anchor { get; set; }
	public Single characterSize { get; set; }
	public Single lineSpacing { get; set; }
	public Single tabSize { get; set; }
	public Boolean richText { get; set; }
	public Color color { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C864CC
	public String get_text() { }

	// RVA: 0xFFFFFFFF723D61E8
	public Void set_text(String value) { }

	// RVA: 0xFFFFFFFF723D623C
	public Font get_font() { }

	// RVA: 0xFFFFFFFF75C8650C
	public Void set_font(Font value) { }

	// RVA: 0xFFFFFFFF723D6280
	public Int32 get_fontSize() { }

	// RVA: 0xFFFFFFFF75C8655C
	public Void set_fontSize(Int32 value) { }

	// RVA: 0xFFFFFFFF723D62C4
	public FontStyle get_fontStyle() { }

	// RVA: 0xFFFFFFFF75C865AC
	public Void set_fontStyle(FontStyle value) { }

	// RVA: 0xFFFFFFFF75C865FC
	public Single get_offsetZ() { }

	// RVA: 0xFFFFFFFF75C8663C
	public Void set_offsetZ(Single value) { }

	// RVA: 0xFFFFFFFF75C8668C
	public TextAlignment get_alignment() { }

	// RVA: 0xFFFFFFFF75C866CC
	public Void set_alignment(TextAlignment value) { }

	// RVA: 0xFFFFFFFF75C8671C
	public TextAnchor get_anchor() { }

	// RVA: 0xFFFFFFFF75C8675C
	public Void set_anchor(TextAnchor value) { }

	// RVA: 0xFFFFFFFF75C867AC
	public Single get_characterSize() { }

	// RVA: 0xFFFFFFFF75C867EC
	public Void set_characterSize(Single value) { }

	// RVA: 0xFFFFFFFF75C86840
	public Single get_lineSpacing() { }

	// RVA: 0xFFFFFFFF75C86880
	public Void set_lineSpacing(Single value) { }

	// RVA: 0xFFFFFFFF75C868D0
	public Single get_tabSize() { }

	// RVA: 0xFFFFFFFF75C86910
	public Void set_tabSize(Single value) { }

	// RVA: 0xFFFFFFFF75C86960
	public Boolean get_richText() { }

	// RVA: 0xFFFFFFFF75C869A0
	public Void set_richText(Boolean value) { }

	// RVA: 0xFFFFFFFF723D6308
	public Color get_color() { }

	// RVA: 0xFFFFFFFF723D6368
	public Void set_color(Color value) { }

	// RVA: 0xFFFFFFFF75C86A90
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C869F0
	private Void get_color_Injected(out Color ret) { }

	// RVA: 0xFFFFFFFF75C86A40
	private Void set_color_Injected(ref Color value) { }

}

// Namespace: UnityEngine
public struct CharacterInfo
{
	// Fields
	public Int32 index; // 0x10
	public Rect uv; // 0x14
	public Rect vert; // 0x24
	public Single width; // 0x34
	public Int32 size; // 0x38
	public FontStyle style; // 0x3C
	public Boolean flipped; // 0x40

	// Properties
	public Int32 advance { get; }
	public Int32 glyphWidth { get; }
	public Int32 minY { get; }
	public Int32 maxY { get; }
	public Int32 minX { get; }
	public Int32 maxX { get; }
	internal Vector2 uvBottomLeftUnFlipped { get; }
	internal Vector2 uvBottomRightUnFlipped { get; }
	internal Vector2 uvTopRightUnFlipped { get; }
	internal Vector2 uvTopLeftUnFlipped { get; }
	public Vector2 uvBottomLeft { get; }
	public Vector2 uvBottomRight { get; }
	public Vector2 uvTopRight { get; }
	public Vector2 uvTopLeft { get; }

	// Methods

	// RVA: 0xFFFFFFFF71152D98
	public Int32 get_advance() { }

	// RVA: 0xFFFFFFFF71152DA0
	public Int32 get_glyphWidth() { }

	// RVA: 0xFFFFFFFF71152DC4
	public Int32 get_minY() { }

	// RVA: 0xFFFFFFFF71152DF0
	public Int32 get_maxY() { }

	// RVA: 0xFFFFFFFF71152E14
	public Int32 get_minX() { }

	// RVA: 0xFFFFFFFF71152E38
	public Int32 get_maxX() { }

	// RVA: 0xFFFFFFFF71152E64
	internal Vector2 get_uvBottomLeftUnFlipped() { }

	// RVA: 0xFFFFFFFF71152E6C
	internal Vector2 get_uvBottomRightUnFlipped() { }

	// RVA: 0xFFFFFFFF71152E7C
	internal Vector2 get_uvTopRightUnFlipped() { }

	// RVA: 0xFFFFFFFF71152E90
	internal Vector2 get_uvTopLeftUnFlipped() { }

	// RVA: 0xFFFFFFFF71152EA0
	public Vector2 get_uvBottomLeft() { }

	// RVA: 0xFFFFFFFF71152EA8
	public Vector2 get_uvBottomRight() { }

	// RVA: 0xFFFFFFFF71152ED0
	public Vector2 get_uvTopRight() { }

	// RVA: 0xFFFFFFFF71152EE4
	public Vector2 get_uvTopLeft() { }

}

// Namespace: UnityEngine
public struct UICharInfo
{
	// Fields
	public Vector2 cursorPos; // 0x10
	public Single charWidth; // 0x18
}

// Namespace: UnityEngine
public struct UILineInfo
{
	// Fields
	public Int32 startCharIdx; // 0x10
	public Int32 height; // 0x14
	public Single topY; // 0x18
	public Single leading; // 0x1C
}

// Namespace: UnityEngine
public struct UIVertex
{
	// Fields
	public Vector3 position; // 0x10
	public Vector3 normal; // 0x1C
	public Vector4 tangent; // 0x28
	public Color32 color; // 0x38
	public Vector2 uv0; // 0x3C
	public Vector2 uv1; // 0x44
	public Vector2 uv2; // 0x4C
	public Vector2 uv3; // 0x54
	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector4 s_DefaultTangent; // 0x4
	public static UIVertex simpleVert; // 0x14

	// Methods

	// RVA: 0xFFFFFFFF75C86A98
	private static Void .cctor() { }

}

// Namespace: UnityEngine
public sealed class Font
{
	// Fields
	private static Action<T0> textureRebuilt; // 0x0
	private FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	// Properties
	public Material material { get; }
	public String[] fontNames { get; }
	public Boolean dynamic { get; }
	public Int32 fontSize { get; }
	public CharacterInfo[] characterInfo { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C84A58
	public static Void add_textureRebuilt(Action<T0> value) { }

	// RVA: 0xFFFFFFFF75C84AE0
	public static Void remove_textureRebuilt(Action<T0> value) { }

	// RVA: 0xFFFFFFFF723D5FF8
	public Material get_material() { }

	// RVA: 0xFFFFFFFF75C84B68
	public String[] get_fontNames() { }

	// RVA: 0xFFFFFFFF75C84BA8
	public Boolean get_dynamic() { }

	// RVA: 0xFFFFFFFF75C84BE8
	public Int32 get_fontSize() { }

	// RVA: 0xFFFFFFFF75C84C28
	public CharacterInfo[] get_characterInfo() { }

	// RVA: 0xFFFFFFFF75C84C68
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF723D604C
	internal static Void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0xFFFFFFFF75C84F20
	public Boolean HasCharacter(Char c) { }

	// RVA: 0xFFFFFFFF75C84F70
	private Boolean HasCharacter(Int32 c) { }

	// RVA: 0xFFFFFFFF75C84CD4
	private static Void Internal_CreateFont(Font self, String name) { }

	// RVA: 0xFFFFFFFF723D60A8
	public Boolean GetCharacterInfo(Char ch, out CharacterInfo info, Int32 size, FontStyle style) { }

	// RVA: 0xFFFFFFFF723D6114
	public Boolean GetCharacterInfo(Char ch, out CharacterInfo info, Int32 size) { }

	// RVA: 0xFFFFFFFF723D617C
	public Void RequestCharactersInTexture(String characters, Int32 size, FontStyle style) { }

}

// Namespace: 
public sealed class FontTextureRebuildCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75C84FC0
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75C84D24
	public virtual Void Invoke() { }

	// RVA: 0xFFFFFFFF75C84FD4
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75C8502C
	public virtual Void EndInvoke(IAsyncResult result) { }

}


