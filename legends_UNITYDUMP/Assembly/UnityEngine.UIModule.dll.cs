// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public interface ICanvasRaycastFilter
{
	// Methods

	// RVA: -1
	public abstract Boolean IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

// Namespace: UnityEngine
public sealed class CanvasGroup
{
	// Properties
	public Single alpha { get; set; }
	public Boolean interactable { get; }
	public Boolean blocksRaycasts { get; }
	public Boolean ignoreParentGroups { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C9F468
	public Single get_alpha() { }

	// RVA: 0xFFFFFFFF75C9F4A8
	public Void set_alpha(Single value) { }

	// RVA: 0xFFFFFFFF75C9F4F8
	public Boolean get_interactable() { }

	// RVA: 0xFFFFFFFF75C9F538
	public Boolean get_blocksRaycasts() { }

	// RVA: 0xFFFFFFFF75C9F578
	public Boolean get_ignoreParentGroups() { }

	// RVA: 0xFFFFFFFF75C9F5B8
	public Boolean IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

// Namespace: UnityEngine
public sealed class CanvasRenderer
{
	// Fields
	private Boolean <isMask>k__BackingField; // 0x18

	// Properties
	public Boolean hasPopInstruction { get; set; }
	public Int32 materialCount { get; set; }
	public Int32 popMaterialCount { get; set; }
	public Int32 absoluteDepth { get; }
	public Boolean hasMoved { get; }
	public Boolean cullTransparentMesh { get; set; }
	public Boolean hasRectClipping { get; }
	public Int32 relativeDepth { get; }
	public Boolean cull { get; set; }
	public Boolean isMask { get; set; }
	public Vector2 clippingSoftness { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C9F5F8
	public Boolean get_hasPopInstruction() { }

	// RVA: 0xFFFFFFFF75C9F638
	public Void set_hasPopInstruction(Boolean value) { }

	// RVA: 0xFFFFFFFF75C9F688
	public Int32 get_materialCount() { }

	// RVA: 0xFFFFFFFF75C9F6C8
	public Void set_materialCount(Int32 value) { }

	// RVA: 0xFFFFFFFF75C9F718
	public Int32 get_popMaterialCount() { }

	// RVA: 0xFFFFFFFF75C9F758
	public Void set_popMaterialCount(Int32 value) { }

	// RVA: 0xFFFFFFFF75C9F7A8
	public Int32 get_absoluteDepth() { }

	// RVA: 0xFFFFFFFF75C9F7E8
	public Boolean get_hasMoved() { }

	// RVA: 0xFFFFFFFF75C9F828
	public Boolean get_cullTransparentMesh() { }

	// RVA: 0xFFFFFFFF75C9F868
	public Void set_cullTransparentMesh(Boolean value) { }

	// RVA: 0xFFFFFFFF75C9F8B8
	public Boolean get_hasRectClipping() { }

	// RVA: 0xFFFFFFFF75C9F8F8
	public Int32 get_relativeDepth() { }

	// RVA: 0xFFFFFFFF75C9F938
	public Boolean get_cull() { }

	// RVA: 0xFFFFFFFF75C9F978
	public Void set_cull(Boolean value) { }

	// RVA: 0xFFFFFFFF75C9F9C8
	public Boolean get_isMask() { }

	// RVA: 0xFFFFFFFF75C9F9D0
	public Void set_isMask(Boolean value) { }

	// RVA: 0xFFFFFFFF75C9F9D8
	public Void SetColor(Color color) { }

	// RVA: 0xFFFFFFFF75C9FA80
	public Color GetColor() { }

	// RVA: 0xFFFFFFFF75C9FB2C
	public Void EnableRectClipping(Rect rect) { }

	// RVA: 0xFFFFFFFF75C9FBD4
	public Vector2 get_clippingSoftness() { }

	// RVA: 0xFFFFFFFF75C9FC7C
	public Void set_clippingSoftness(Vector2 value) { }

	// RVA: 0xFFFFFFFF75C9FD20
	public Void DisableRectClipping() { }

	// RVA: 0xFFFFFFFF75C9FD60
	public Void SetMaterial(Material material, Int32 index) { }

	// RVA: 0xFFFFFFFF75C9FDB8
	public Material GetMaterial(Int32 index) { }

	// RVA: 0xFFFFFFFF75C9FE08
	public Void SetPopMaterial(Material material, Int32 index) { }

	// RVA: 0xFFFFFFFF75C9FE60
	public Material GetPopMaterial(Int32 index) { }

	// RVA: 0xFFFFFFFF75C9FEB0
	public Void SetTexture(Texture texture) { }

	// RVA: 0xFFFFFFFF75C9FF00
	public Void SetAlphaTexture(Texture texture) { }

	// RVA: 0xFFFFFFFF75C9FF50
	public Void SetMesh(Mesh mesh) { }

	// RVA: 0xFFFFFFFF75C9FFA0
	public Void Clear() { }

	// RVA: 0xFFFFFFFF75C9FFE0
	public Single GetAlpha() { }

	// RVA: 0xFFFFFFFF75C9FFF8
	public Void SetAlpha(Single alpha) { }

	// RVA: 0xFFFFFFFF75CA0060
	public Single GetInheritedAlpha() { }

	// RVA: 0xFFFFFFFF75CA00A0
	public Void SetMaterial(Material material, Texture texture) { }

	// RVA: 0xFFFFFFFF75CA01B4
	public Material GetMaterial() { }

	// RVA: 0xFFFFFFFF75CA01F8
	public static Void SplitUIVertexStreams(List<T0> verts, List<T0> positions, List<T0> colors, List<T0> uv0S, List<T0> uv1S, List<T0> normals, List<T0> tangents, List<T0> indices) { }

	// RVA: 0xFFFFFFFF75CA02B0
	public static Void SplitUIVertexStreams(List<T0> verts, List<T0> positions, List<T0> colors, List<T0> uv0S, List<T0> uv1S, List<T0> uv2S, List<T0> uv3S, List<T0> normals, List<T0> tangents, List<T0> indices) { }

	// RVA: 0xFFFFFFFF75CA047C
	public static Void CreateUIVertexStream(List<T0> verts, List<T0> positions, List<T0> colors, List<T0> uv0S, List<T0> uv1S, List<T0> normals, List<T0> tangents, List<T0> indices) { }

	// RVA: 0xFFFFFFFF75CA054C
	public static Void CreateUIVertexStream(List<T0> verts, List<T0> positions, List<T0> colors, List<T0> uv0S, List<T0> uv1S, List<T0> uv2S, List<T0> uv3S, List<T0> normals, List<T0> tangents, List<T0> indices) { }

	// RVA: 0xFFFFFFFF75CA0694
	public static Void AddUIVertexStream(List<T0> verts, List<T0> positions, List<T0> colors, List<T0> uv0S, List<T0> uv1S, List<T0> normals, List<T0> tangents) { }

	// RVA: 0xFFFFFFFF75CA0768
	public static Void AddUIVertexStream(List<T0> verts, List<T0> positions, List<T0> colors, List<T0> uv0S, List<T0> uv1S, List<T0> uv2S, List<T0> uv3S, List<T0> normals, List<T0> tangents) { }

	// RVA: 0xFFFFFFFF75CA0808
	public Void SetVertices(List<T0> vertices) { }

	// RVA: 0xFFFFFFFF75CA0880
	public Void SetVertices(UIVertex[] vertices, Int32 size) { }

	// RVA: 0xFFFFFFFF75CA042C
	private static Void SplitIndicesStreamsInternal(Object verts, Object indices) { }

	// RVA: 0xFFFFFFFF75CA038C
	private static Void SplitUIVertexStreamsInternal(Object verts, Object positions, Object colors, Object uv0S, Object uv1S, Object uv2S, Object uv3S, Object normals, Object tangents) { }

	// RVA: 0xFFFFFFFF75CA05F0
	private static Void CreateUIVertexStreamInternal(Object verts, Object positions, Object colors, Object uv0S, Object uv1S, Object uv2S, Object uv3S, Object normals, Object tangents, Object indices) { }

	// RVA: 0xFFFFFFFF75CA0D08
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C9FA30
	private Void SetColor_Injected(ref Color color) { }

	// RVA: 0xFFFFFFFF75C9FADC
	private Void GetColor_Injected(out Color ret) { }

	// RVA: 0xFFFFFFFF75C9FB84
	private Void EnableRectClipping_Injected(ref Rect rect) { }

	// RVA: 0xFFFFFFFF75C9FC2C
	private Void get_clippingSoftness_Injected(out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75C9FCD0
	private Void set_clippingSoftness_Injected(ref Vector2 value) { }

}

// Namespace: UnityEngine
public sealed class RectTransformUtility
{
	// Fields
	private static readonly Vector3[] s_Corners; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75CA0D10
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0xFFFFFFFF75CA0E24
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0xFFFFFFFF75CA0F24
	private static Boolean PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) { }

	// RVA: 0xFFFFFFFF75CA1038
	public static Boolean RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint) { }

	// RVA: 0xFFFFFFFF75CA10B0
	public static Boolean RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0xFFFFFFFF75CA1188
	public static Boolean RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) { }

	// RVA: 0xFFFFFFFF75CA123C
	public static Boolean ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0xFFFFFFFF75CA1588
	public static Boolean ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) { }

	// RVA: 0xFFFFFFFF75CA1444
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0xFFFFFFFF75CA1684
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0xFFFFFFFF75CA1714
	public static Void FlipLayoutOnAxis(RectTransform rect, Int32 axis, Boolean keepPositioning, Boolean recursive) { }

	// RVA: 0xFFFFFFFF75CA1950
	public static Void FlipLayoutAxes(RectTransform rect, Boolean keepPositioning, Boolean recursive) { }

	// RVA: 0xFFFFFFFF75CA1B98
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0xFFFFFFFF75CA1BD0
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75CA0DBC
	private static Void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret) { }

	// RVA: 0xFFFFFFFF75CA0ECC
	private static Void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret) { }

	// RVA: 0xFFFFFFFF75CA0FD0
	private static Boolean PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam, ref Vector4 offset) { }

}

// Namespace: UnityEngine
public enum RenderMode
{
	// Fields
	public Int32 value__; // 0x10
	public const RenderMode ScreenSpaceOverlay = 0;
	public const RenderMode ScreenSpaceCamera = 1;
	public const RenderMode WorldSpace = 2;
}

// Namespace: UnityEngine
public enum AdditionalCanvasShaderChannels
{
	// Fields
	public Int32 value__; // 0x10
	public const AdditionalCanvasShaderChannels None = 0;
	public const AdditionalCanvasShaderChannels TexCoord1 = 1;
	public const AdditionalCanvasShaderChannels TexCoord2 = 2;
	public const AdditionalCanvasShaderChannels TexCoord3 = 4;
	public const AdditionalCanvasShaderChannels Normal = 8;
	public const AdditionalCanvasShaderChannels Tangent = 16;
}

// Namespace: UnityEngine
public sealed class Canvas
{
	// Fields
	private static WillRenderCanvases preWillRenderCanvases; // 0x0
	private static WillRenderCanvases willRenderCanvases; // 0x8

	// Properties
	public RenderMode renderMode { get; set; }
	public Boolean isRootCanvas { get; }
	public Rect pixelRect { get; }
	public Single scaleFactor { get; set; }
	public Single referencePixelsPerUnit { get; set; }
	public Boolean overridePixelPerfect { get; set; }
	public Boolean pixelPerfect { get; set; }
	public Single planeDistance { get; set; }
	public Int32 renderOrder { get; }
	public Boolean overrideSorting { get; set; }
	public Int32 sortingOrder { get; set; }
	public Int32 targetDisplay { get; set; }
	public Int32 sortingLayerID { get; set; }
	public Int32 cachedSortingLayerValue { get; }
	public AdditionalCanvasShaderChannels additionalShaderChannels { get; set; }
	public String sortingLayerName { get; set; }
	public Canvas rootCanvas { get; }
	public Vector2 renderingDisplaySize { get; }
	public Camera worldCamera { get; set; }
	public Single normalizedSortingGridSize { get; set; }
	public Int32 sortingGridNormalizedSize { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C9E394
	public static Void add_preWillRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0xFFFFFFFF75C9E43C
	public static Void remove_preWillRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0xFFFFFFFF75C9E4E4
	public static Void add_willRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0xFFFFFFFF75C9E590
	public static Void remove_willRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0xFFFFFFFF75C9E63C
	public RenderMode get_renderMode() { }

	// RVA: 0xFFFFFFFF75C9E67C
	public Void set_renderMode(RenderMode value) { }

	// RVA: 0xFFFFFFFF75C9E6CC
	public Boolean get_isRootCanvas() { }

	// RVA: 0xFFFFFFFF75C9E70C
	public Rect get_pixelRect() { }

	// RVA: 0xFFFFFFFF75C9E7B8
	public Single get_scaleFactor() { }

	// RVA: 0xFFFFFFFF75C9E7F8
	public Void set_scaleFactor(Single value) { }

	// RVA: 0xFFFFFFFF75C9E848
	public Single get_referencePixelsPerUnit() { }

	// RVA: 0xFFFFFFFF75C9E888
	public Void set_referencePixelsPerUnit(Single value) { }

	// RVA: 0xFFFFFFFF75C9E8D8
	public Boolean get_overridePixelPerfect() { }

	// RVA: 0xFFFFFFFF75C9E918
	public Void set_overridePixelPerfect(Boolean value) { }

	// RVA: 0xFFFFFFFF75C9E968
	public Boolean get_pixelPerfect() { }

	// RVA: 0xFFFFFFFF75C9E9A8
	public Void set_pixelPerfect(Boolean value) { }

	// RVA: 0xFFFFFFFF75C9E9F8
	public Single get_planeDistance() { }

	// RVA: 0xFFFFFFFF75C9EA38
	public Void set_planeDistance(Single value) { }

	// RVA: 0xFFFFFFFF75C9EA88
	public Int32 get_renderOrder() { }

	// RVA: 0xFFFFFFFF75C9EAC8
	public Boolean get_overrideSorting() { }

	// RVA: 0xFFFFFFFF75C9EB08
	public Void set_overrideSorting(Boolean value) { }

	// RVA: 0xFFFFFFFF75C9EB58
	public Int32 get_sortingOrder() { }

	// RVA: 0xFFFFFFFF75C9EB98
	public Void set_sortingOrder(Int32 value) { }

	// RVA: 0xFFFFFFFF75C9EBE8
	public Int32 get_targetDisplay() { }

	// RVA: 0xFFFFFFFF75C9EC28
	public Void set_targetDisplay(Int32 value) { }

	// RVA: 0xFFFFFFFF75C9EC78
	public Int32 get_sortingLayerID() { }

	// RVA: 0xFFFFFFFF75C9ECB8
	public Void set_sortingLayerID(Int32 value) { }

	// RVA: 0xFFFFFFFF75C9ED08
	public Int32 get_cachedSortingLayerValue() { }

	// RVA: 0xFFFFFFFF75C9ED48
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0xFFFFFFFF75C9ED88
	public Void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0xFFFFFFFF75C9EDD8
	public String get_sortingLayerName() { }

	// RVA: 0xFFFFFFFF75C9EE18
	public Void set_sortingLayerName(String value) { }

	// RVA: 0xFFFFFFFF75C9EE68
	public Canvas get_rootCanvas() { }

	// RVA: 0xFFFFFFFF75C9EEA8
	public Vector2 get_renderingDisplaySize() { }

	// RVA: 0xFFFFFFFF75C9EF50
	public Camera get_worldCamera() { }

	// RVA: 0xFFFFFFFF75C9EF90
	public Void set_worldCamera(Camera value) { }

	// RVA: 0xFFFFFFFF75C9EFE0
	public Single get_normalizedSortingGridSize() { }

	// RVA: 0xFFFFFFFF75C9F020
	public Void set_normalizedSortingGridSize(Single value) { }

	// RVA: 0xFFFFFFFF75C9F070
	public Int32 get_sortingGridNormalizedSize() { }

	// RVA: 0xFFFFFFFF75C9F0B0
	public Void set_sortingGridNormalizedSize(Int32 value) { }

	// RVA: 0xFFFFFFFF75C9F100
	public static Material GetDefaultCanvasTextMaterial() { }

	// RVA: 0xFFFFFFFF75C9F134
	public static Material GetDefaultCanvasMaterial() { }

	// RVA: 0xFFFFFFFF75C9F168
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0xFFFFFFFF75C9F19C
	public static Void ForceUpdateCanvases() { }

	// RVA: 0xFFFFFFFF723D63C4
	private static Void SendPreWillRenderCanvases() { }

	// RVA: 0xFFFFFFFF723D63E0
	private static Void SendWillRenderCanvases() { }

	// RVA: 0xFFFFFFFF75C9F3E8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C9E768
	private Void get_pixelRect_Injected(out Rect ret) { }

	// RVA: 0xFFFFFFFF75C9EF00
	private Void get_renderingDisplaySize_Injected(out Vector2 ret) { }

}

// Namespace: 
public sealed class WillRenderCanvases
{
	// Methods

	// RVA: 0xFFFFFFFF75C9F3F0
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75C9F1EC
	public virtual Void Invoke() { }

	// RVA: 0xFFFFFFFF75C9F404
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75C9F45C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine
public static class UISystemProfilerApi
{
	// Methods

	// RVA: 0xFFFFFFFF75CA1C2C
	public static Void BeginSample(SampleType type) { }

	// RVA: 0xFFFFFFFF75CA1C6C
	public static Void EndSample(SampleType type) { }

	// RVA: 0xFFFFFFFF75CA1CAC
	public static Void AddMarker(String name, Object obj) { }

}

// Namespace: 
public enum SampleType
{
	// Fields
	public Int32 value__; // 0x10
	public const SampleType Layout = 0;
	public const SampleType Render = 1;
}


