// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.TextCore
public struct FaceInfo
{
	// Fields
	private Int32 m_FaceIndex; // 0x10
	private String m_FamilyName; // 0x18
	private String m_StyleName; // 0x20
	private Int32 m_PointSize; // 0x28
	private Single m_Scale; // 0x2C
	private Single m_LineHeight; // 0x30
	private Single m_AscentLine; // 0x34
	private Single m_CapLine; // 0x38
	private Single m_MeanLine; // 0x3C
	private Single m_Baseline; // 0x40
	private Single m_DescentLine; // 0x44
	private Single m_SuperscriptOffset; // 0x48
	private Single m_SuperscriptSize; // 0x4C
	private Single m_SubscriptOffset; // 0x50
	private Single m_SubscriptSize; // 0x54
	private Single m_UnderlineOffset; // 0x58
	private Single m_UnderlineThickness; // 0x5C
	private Single m_StrikethroughOffset; // 0x60
	private Single m_StrikethroughThickness; // 0x64
	private Single m_TabWidth; // 0x68

	// Properties
	public String familyName { set; }
	public String styleName { set; }
	public Int32 pointSize { get; set; }
	public Single scale { get; set; }
	public Single lineHeight { get; set; }
	public Single ascentLine { get; set; }
	public Single capLine { get; set; }
	public Single meanLine { get; set; }
	public Single baseline { get; set; }
	public Single descentLine { get; set; }
	public Single superscriptOffset { get; set; }
	public Single superscriptSize { get; set; }
	public Single subscriptOffset { get; set; }
	public Single subscriptSize { get; set; }
	public Single underlineOffset { get; set; }
	public Single underlineThickness { get; set; }
	public Single strikethroughOffset { get; set; }
	public Single strikethroughThickness { set; }
	public Single tabWidth { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF71152A6C
	public Void set_familyName(String value) { }

	// RVA: 0xFFFFFFFF71152A74
	public Void set_styleName(String value) { }

	// RVA: 0xFFFFFFFF71152A7C
	public Int32 get_pointSize() { }

	// RVA: 0xFFFFFFFF71152A84
	public Void set_pointSize(Int32 value) { }

	// RVA: 0xFFFFFFFF71152A8C
	public Single get_scale() { }

	// RVA: 0xFFFFFFFF71152A94
	public Void set_scale(Single value) { }

	// RVA: 0xFFFFFFFF71152A9C
	public Single get_lineHeight() { }

	// RVA: 0xFFFFFFFF71152AA4
	public Void set_lineHeight(Single value) { }

	// RVA: 0xFFFFFFFF71152AAC
	public Single get_ascentLine() { }

	// RVA: 0xFFFFFFFF71152AB4
	public Void set_ascentLine(Single value) { }

	// RVA: 0xFFFFFFFF71152ABC
	public Single get_capLine() { }

	// RVA: 0xFFFFFFFF71152AC4
	public Void set_capLine(Single value) { }

	// RVA: 0xFFFFFFFF71152ACC
	public Single get_meanLine() { }

	// RVA: 0xFFFFFFFF71152AD4
	public Void set_meanLine(Single value) { }

	// RVA: 0xFFFFFFFF71152ADC
	public Single get_baseline() { }

	// RVA: 0xFFFFFFFF71152AE4
	public Void set_baseline(Single value) { }

	// RVA: 0xFFFFFFFF71152AEC
	public Single get_descentLine() { }

	// RVA: 0xFFFFFFFF71152AF4
	public Void set_descentLine(Single value) { }

	// RVA: 0xFFFFFFFF71152AFC
	public Single get_superscriptOffset() { }

	// RVA: 0xFFFFFFFF71152B04
	public Void set_superscriptOffset(Single value) { }

	// RVA: 0xFFFFFFFF71152B0C
	public Single get_superscriptSize() { }

	// RVA: 0xFFFFFFFF71152B14
	public Void set_superscriptSize(Single value) { }

	// RVA: 0xFFFFFFFF71152B1C
	public Single get_subscriptOffset() { }

	// RVA: 0xFFFFFFFF71152B24
	public Void set_subscriptOffset(Single value) { }

	// RVA: 0xFFFFFFFF71152B2C
	public Single get_subscriptSize() { }

	// RVA: 0xFFFFFFFF71152B34
	public Void set_subscriptSize(Single value) { }

	// RVA: 0xFFFFFFFF71152B3C
	public Single get_underlineOffset() { }

	// RVA: 0xFFFFFFFF71152B44
	public Void set_underlineOffset(Single value) { }

	// RVA: 0xFFFFFFFF71152B4C
	public Single get_underlineThickness() { }

	// RVA: 0xFFFFFFFF71152B54
	public Void set_underlineThickness(Single value) { }

	// RVA: 0xFFFFFFFF71152B5C
	public Single get_strikethroughOffset() { }

	// RVA: 0xFFFFFFFF71152B64
	public Void set_strikethroughOffset(Single value) { }

	// RVA: 0xFFFFFFFF71152B6C
	public Void set_strikethroughThickness(Single value) { }

	// RVA: 0xFFFFFFFF71152B74
	public Single get_tabWidth() { }

	// RVA: 0xFFFFFFFF71152B7C
	public Void set_tabWidth(Single value) { }

}

// Namespace: UnityEngine.TextCore
public struct GlyphRect
{
	// Fields
	private Int32 m_X; // 0x10
	private Int32 m_Y; // 0x14
	private Int32 m_Width; // 0x18
	private Int32 m_Height; // 0x1C
	private static readonly GlyphRect s_ZeroGlyphRect; // 0x0

	// Properties
	public Int32 x { get; }
	public Int32 y { get; }
	public Int32 width { get; }
	public Int32 height { get; }
	public static GlyphRect zero { get; }

	// Methods

	// RVA: 0xFFFFFFFF71152C6C
	public Int32 get_x() { }

	// RVA: 0xFFFFFFFF71152C74
	public Int32 get_y() { }

	// RVA: 0xFFFFFFFF71152C7C
	public Int32 get_width() { }

	// RVA: 0xFFFFFFFF71152C84
	public Int32 get_height() { }

	// RVA: 0xFFFFFFFF75C82E7C
	public static GlyphRect get_zero() { }

	// RVA: 0xFFFFFFFF71152C8C
	public Void .ctor(Int32 x, Int32 y, Int32 width, Int32 height) { }

	// RVA: 0xFFFFFFFF71152C98
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF71152CA0
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF71152CA8
	public Boolean Equals(GlyphRect other) { }

	// RVA: 0xFFFFFFFF75C83068
	private static Void .cctor() { }

}

// Namespace: UnityEngine.TextCore
public struct GlyphMetrics
{
	// Fields
	private Single m_Width; // 0x10
	private Single m_Height; // 0x14
	private Single m_HorizontalBearingX; // 0x18
	private Single m_HorizontalBearingY; // 0x1C
	private Single m_HorizontalAdvance; // 0x20

	// Properties
	public Single width { get; }
	public Single height { get; }
	public Single horizontalBearingX { get; }
	public Single horizontalBearingY { get; }
	public Single horizontalAdvance { get; }

	// Methods

	// RVA: 0xFFFFFFFF71152BF0
	public Single get_width() { }

	// RVA: 0xFFFFFFFF71152BF8
	public Single get_height() { }

	// RVA: 0xFFFFFFFF71152C00
	public Single get_horizontalBearingX() { }

	// RVA: 0xFFFFFFFF71152C08
	public Single get_horizontalBearingY() { }

	// RVA: 0xFFFFFFFF71152C10
	public Single get_horizontalAdvance() { }

	// RVA: 0xFFFFFFFF71152C18
	public Void .ctor(Single width, Single height, Single bearingX, Single bearingY, Single advance) { }

	// RVA: 0xFFFFFFFF71152C28
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF71152C30
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF71152C38
	public Boolean Equals(GlyphMetrics other) { }

}

// Namespace: UnityEngine.TextCore
public class Glyph
{
	// Fields
	private UInt32 m_Index; // 0x10
	private GlyphMetrics m_Metrics; // 0x14
	private GlyphRect m_GlyphRect; // 0x28
	private Single m_Scale; // 0x38
	private Int32 m_AtlasIndex; // 0x3C

	// Properties
	public UInt32 index { get; set; }
	public GlyphMetrics metrics { get; set; }
	public GlyphRect glyphRect { get; set; }
	public Single scale { get; set; }
	public Int32 atlasIndex { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C82B18
	public UInt32 get_index() { }

	// RVA: 0xFFFFFFFF75C82B20
	public Void set_index(UInt32 value) { }

	// RVA: 0xFFFFFFFF75C82B28
	public GlyphMetrics get_metrics() { }

	// RVA: 0xFFFFFFFF75C82B3C
	public Void set_metrics(GlyphMetrics value) { }

	// RVA: 0xFFFFFFFF75C82B50
	public GlyphRect get_glyphRect() { }

	// RVA: 0xFFFFFFFF75C82B5C
	public Void set_glyphRect(GlyphRect value) { }

	// RVA: 0xFFFFFFFF75C82B64
	public Single get_scale() { }

	// RVA: 0xFFFFFFFF75C82B6C
	public Void set_scale(Single value) { }

	// RVA: 0xFFFFFFFF75C82B74
	public Int32 get_atlasIndex() { }

	// RVA: 0xFFFFFFFF75C82B7C
	public Void set_atlasIndex(Int32 value) { }

	// RVA: 0xFFFFFFFF75C82B84
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C82BB8
	internal Void .ctor(GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0xFFFFFFFF75C82C10
	public Void .ctor(UInt32 index, GlyphMetrics metrics, GlyphRect glyphRect, Single scale, Int32 atlasIndex) { }

}

// Namespace: UnityEngine.TextCore.LowLevel
public enum FontFeatureLookupFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const FontFeatureLookupFlags None = 0;
	public const FontFeatureLookupFlags IgnoreLigatures = 4;
	public const FontFeatureLookupFlags IgnoreSpacingAdjustments = 256;
}

// Namespace: UnityEngine.TextCore.LowLevel
public struct GlyphValueRecord
{
	// Fields
	private Single m_XPlacement; // 0x10
	private Single m_YPlacement; // 0x14
	private Single m_XAdvance; // 0x18
	private Single m_YAdvance; // 0x1C

	// Properties
	public Single xPlacement { get; }
	public Single yPlacement { get; }
	public Single xAdvance { get; }
	public Single yAdvance { get; }

	// Methods

	// RVA: 0xFFFFFFFF71152CEC
	public Single get_xPlacement() { }

	// RVA: 0xFFFFFFFF71152CF4
	public Single get_yPlacement() { }

	// RVA: 0xFFFFFFFF71152CFC
	public Single get_xAdvance() { }

	// RVA: 0xFFFFFFFF71152D04
	public Single get_yAdvance() { }

	// RVA: 0xFFFFFFFF71152D0C
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF71152D14
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF71152D1C
	public Boolean Equals(GlyphValueRecord other) { }

}

// Namespace: UnityEngine.TextCore.LowLevel
public struct GlyphAdjustmentRecord
{
	// Fields
	private UInt32 m_GlyphIndex; // 0x10
	private GlyphValueRecord m_GlyphValueRecord; // 0x14

	// Properties
	public UInt32 glyphIndex { get; }
	public GlyphValueRecord glyphValueRecord { get; }

	// Methods

	// RVA: 0xFFFFFFFF71152CB0
	public UInt32 get_glyphIndex() { }

	// RVA: 0xFFFFFFFF71152CB8
	public GlyphValueRecord get_glyphValueRecord() { }

}

// Namespace: UnityEngine.TextCore.LowLevel
public struct GlyphPairAdjustmentRecord
{
	// Fields
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
	private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38

	// Properties
	public GlyphAdjustmentRecord firstAdjustmentRecord { get; }
	public GlyphAdjustmentRecord secondAdjustmentRecord { get; }

	// Methods

	// RVA: 0xFFFFFFFF71152CC4
	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0xFFFFFFFF71152CD8
	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

}

// Namespace: UnityEngine.TextCore.LowLevel
public enum GlyphLoadFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const GlyphLoadFlags LOAD_DEFAULT = 0;
	public const GlyphLoadFlags LOAD_NO_SCALE = 1;
	public const GlyphLoadFlags LOAD_NO_HINTING = 2;
	public const GlyphLoadFlags LOAD_RENDER = 4;
	public const GlyphLoadFlags LOAD_NO_BITMAP = 8;
	public const GlyphLoadFlags LOAD_FORCE_AUTOHINT = 32;
	public const GlyphLoadFlags LOAD_MONOCHROME = 4096;
	public const GlyphLoadFlags LOAD_NO_AUTOHINT = 32768;
	public const GlyphLoadFlags LOAD_COMPUTE_METRICS = 2097152;
	public const GlyphLoadFlags LOAD_BITMAP_METRICS_ONLY = 4194304;
}

// Namespace: UnityEngine.TextCore.LowLevel
public enum FontEngineError
{
	// Fields
	public Int32 value__; // 0x10
	public const FontEngineError Success = 0;
	public const FontEngineError Invalid_File_Path = 1;
	public const FontEngineError Invalid_File_Format = 2;
	public const FontEngineError Invalid_File_Structure = 3;
	public const FontEngineError Invalid_File = 4;
	public const FontEngineError Invalid_Table = 8;
	public const FontEngineError Invalid_Glyph_Index = 16;
	public const FontEngineError Invalid_Character_Code = 17;
	public const FontEngineError Invalid_Pixel_Size = 23;
	public const FontEngineError Invalid_Library = 33;
	public const FontEngineError Invalid_Face = 35;
	public const FontEngineError Invalid_Library_or_Face = 41;
	public const FontEngineError Atlas_Generation_Cancelled = 100;
	public const FontEngineError Invalid_SharedTextureData = 101;
}

// Namespace: UnityEngine.TextCore.LowLevel
public enum GlyphRenderMode
{
	// Fields
	public Int32 value__; // 0x10
	public const GlyphRenderMode SMOOTH_HINTED = 4121;
	public const GlyphRenderMode SMOOTH = 4117;
	public const GlyphRenderMode RASTER_HINTED = 4122;
	public const GlyphRenderMode RASTER = 4118;
	public const GlyphRenderMode SDF = 4134;
	public const GlyphRenderMode SDF8 = 8230;
	public const GlyphRenderMode SDF16 = 16422;
	public const GlyphRenderMode SDF32 = 32806;
	public const GlyphRenderMode SDFAA_HINTED = 4169;
	public const GlyphRenderMode SDFAA = 4165;
}

// Namespace: UnityEngine.TextCore.LowLevel
public enum GlyphPackingMode
{
	// Fields
	public Int32 value__; // 0x10
	public const GlyphPackingMode BestShortSideFit = 0;
	public const GlyphPackingMode BestLongSideFit = 1;
	public const GlyphPackingMode BestAreaFit = 2;
	public const GlyphPackingMode BottomLeftRule = 3;
	public const GlyphPackingMode ContactPointRule = 4;
}

// Namespace: UnityEngine.TextCore.LowLevel
public sealed class FontEngine
{
	// Fields
	private static Glyph[] s_Glyphs; // 0x0
	private static UInt32[] s_GlyphIndexes_MarshallingArray_A; // 0x8
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN; // 0x10
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT; // 0x18
	private static GlyphRect[] s_FreeGlyphRects; // 0x20
	private static GlyphRect[] s_UsedGlyphRects; // 0x28
	private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray; // 0x30
	private static Dictionary<T0, T1> s_GlyphLookupDictionary; // 0x38

	// Methods

	// RVA: 0xFFFFFFFF75C830B0
	public static FontEngineError InitializeFontEngine() { }

	// RVA: 0xFFFFFFFF75C83120
	private static Int32 InitializeFontEngine_Internal() { }

	// RVA: 0xFFFFFFFF75C83154
	public static FontEngineError LoadFontFace(Font font, Int32 pointSize) { }

	// RVA: 0xFFFFFFFF75C831E0
	private static Int32 LoadFontFace_With_Size_FromFont_Internal(Font font, Int32 pointSize) { }

	// RVA: 0xFFFFFFFF75C83230
	public static FaceInfo GetFaceInfo() { }

	// RVA: 0xFFFFFFFF75C832E0
	private static Int32 GetFaceInfo_Internal(ref FaceInfo faceInfo) { }

	// RVA: 0xFFFFFFFF75C83320
	internal static UInt32 GetGlyphIndex(UInt32 unicode) { }

	// RVA: 0xFFFFFFFF75C83360
	public static Boolean TryGetGlyphWithUnicodeValue(UInt32 unicode, GlyphLoadFlags flags, out Glyph glyph) { }

	// RVA: 0xFFFFFFFF75C834AC
	private static Boolean TryGetGlyphWithUnicodeValue_Internal(UInt32 unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0xFFFFFFFF75C83504
	public static Boolean TryGetGlyphWithIndexValue(UInt32 glyphIndex, GlyphLoadFlags flags, out Glyph glyph) { }

	// RVA: 0xFFFFFFFF75C83650
	private static Boolean TryGetGlyphWithIndexValue_Internal(UInt32 glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0xFFFFFFFF75C836A8
	internal static Boolean TryAddGlyphToTexture(UInt32 glyphIndex, Int32 padding, GlyphPackingMode packingMode, List<T0> freeGlyphRects, List<T0> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph) { }

	// RVA: 0xFFFFFFFF75C83AFC
	private static Boolean TryAddGlyphToTexture_Internal(UInt32 glyphIndex, Int32 padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref Int32 freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref Int32 usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph) { }

	// RVA: 0xFFFFFFFF75C83BA0
	internal static Boolean TryAddGlyphsToTexture(List<T0> glyphIndexes, Int32 padding, GlyphPackingMode packingMode, List<T0> freeGlyphRects, List<T0> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs) { }

	// RVA: 0xFFFFFFFF75C842A4
	private static Boolean TryAddGlyphsToTexture_Internal(UInt32[] glyphIndex, Int32 padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref Int32 freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref Int32 usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] GlyphMarshallingStruct[] glyphs, ref Int32 glyphCount) { }

	// RVA: 0xFFFFFFFF75C84358
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(UInt32[] glyphIndexes) { }

	// RVA: 0xFFFFFFFF75C84534
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(List<T0> glyphIndexes, out Int32 recordCount) { }

	// RVA: 0xFFFFFFFF75C844A4
	private static Int32 PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexes(UInt32[] glyphIndexes, out Int32 recordCount) { }

	// RVA: 0xFFFFFFFF75C844F4
	private static Int32 GetGlyphPairAdjustmentRecordsFromMarshallingArray([Out] GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords) { }

	// RVA: -1
	private static Void GenericListToMarshallingArray(ref List<T0> srcList, ref T[] dstArray) { }

	// RVA: -1
	private static Void SetMarshallingArraySize(ref T[] marshallingArray, Int32 recordCount) { }

	// RVA: 0xFFFFFFFF75C846B4
	internal static Void ResetAtlasTexture(Texture2D texture) { }

	// RVA: 0xFFFFFFFF75C846F4
	private static Void .cctor() { }

}

// Namespace: UnityEngine.TextCore.LowLevel
internal struct FontEngineUtilities
{
	// Methods

	// RVA: 0xFFFFFFFF75C84290
	internal static Int32 MaxValue(Int32 a, Int32 b, Int32 c) { }

}

// Namespace: UnityEngine.TextCore.LowLevel
internal struct GlyphMarshallingStruct
{
	// Fields
	public UInt32 index; // 0x10
	public GlyphMetrics metrics; // 0x14
	public GlyphRect glyphRect; // 0x28
	public Single scale; // 0x38
	public Int32 atlasIndex; // 0x3C
}


