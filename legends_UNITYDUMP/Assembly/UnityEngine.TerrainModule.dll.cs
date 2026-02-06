// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public sealed class Terrain
{
	// Properties
	public TerrainData terrainData { get; }
	public Boolean allowAutoConnect { get; }
	public Int32 groupingID { get; }
	public static Terrain[] activeTerrains { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C81684
	public TerrainData get_terrainData() { }

	// RVA: 0xFFFFFFFF75C80A9C
	public Boolean get_allowAutoConnect() { }

	// RVA: 0xFFFFFFFF75C80EBC
	public Int32 get_groupingID() { }

	// RVA: 0xFFFFFFFF75C80ADC
	public Void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

	// RVA: 0xFFFFFFFF75C80974
	public static Terrain[] get_activeTerrains() { }

	// RVA: 0xFFFFFFFF75C82654
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class TerrainData
{
	// Fields
	internal static readonly Int32 k_MaximumResolution; // 0x0
	internal static readonly Int32 k_MinimumDetailResolutionPerPatch; // 0x4
	internal static readonly Int32 k_MaximumDetailResolutionPerPatch; // 0x8
	internal static readonly Int32 k_MaximumDetailPatchCount; // 0xC
	internal static readonly Int32 k_MaximumDetailsPerRes; // 0x10
	internal static readonly Int32 k_MinimumAlphamapResolution; // 0x14
	internal static readonly Int32 k_MaximumAlphamapResolution; // 0x18
	internal static readonly Int32 k_MinimumBaseMapResolution; // 0x1C
	internal static readonly Int32 k_MaximumBaseMapResolution; // 0x20

	// Properties
	public Vector3 size { get; }
	internal Terrain[] users { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C8265C
	private static Int32 GetBoundaryValue(BoundaryValueType type) { }

	// RVA: 0xFFFFFFFF75C8269C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C82740
	private static Void Internal_Create(TerrainData terrainData) { }

	// RVA: 0xFFFFFFFF75C816C4
	public Vector3 get_size() { }

	// RVA: 0xFFFFFFFF75C827D0
	internal Single GetAlphamapResolutionInternal() { }

	// RVA: 0xFFFFFFFF75C7FD48
	internal Terrain[] get_users() { }

	// RVA: 0xFFFFFFFF75C82810
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75C82780
	private Void get_size_Injected(out Vector3 ret) { }

}

// Namespace: 
private enum BoundaryValueType
{
	// Fields
	public Int32 value__; // 0x10
	public const BoundaryValueType MaxHeightmapRes = 0;
	public const BoundaryValueType MinDetailResPerPatch = 1;
	public const BoundaryValueType MaxDetailResPerPatch = 2;
	public const BoundaryValueType MaxDetailPatchCount = 3;
	public const BoundaryValueType MaxDetailsPerRes = 4;
	public const BoundaryValueType MinAlphamapRes = 5;
	public const BoundaryValueType MaxAlphamapRes = 6;
	public const BoundaryValueType MinBaseMapRes = 7;
	public const BoundaryValueType MaxBaseMapRes = 8;
}

// Namespace: UnityEngine.Experimental.TerrainAPI
public static class TerrainCallbacks
{
	// Fields
	private static HeightmapChangedCallback heightmapChanged; // 0x0
	private static TextureChangedCallback textureChanged; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75C7FC54
	internal static Void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, Boolean synched) { }

	// RVA: 0xFFFFFFFF75C801E0
	internal static Void InvokeTextureChangedCallback(TerrainData terrainData, String textureName, RectInt texelRegion, Boolean synched) { }

}

// Namespace: 
public sealed class HeightmapChangedCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75C80714
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75C7FD88
	public virtual Void Invoke(Terrain terrain, RectInt heightRegion, Boolean synched) { }

	// RVA: 0xFFFFFFFF75C80728
	public virtual IAsyncResult BeginInvoke(Terrain terrain, RectInt heightRegion, Boolean synched, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75C80800
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class TextureChangedCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75C8080C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75C802DC
	public virtual Void Invoke(Terrain terrain, String textureName, RectInt texelRegion, Boolean synched) { }

	// RVA: 0xFFFFFFFF75C80820
	public virtual IAsyncResult BeginInvoke(Terrain terrain, String textureName, RectInt texelRegion, Boolean synched, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75C808FC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine.Experimental.TerrainAPI
public static class TerrainUtility
{
	// Methods

	// RVA: 0xFFFFFFFF75C80908
	internal static Boolean HasValidTerrains() { }

	// RVA: 0xFFFFFFFF75C809A8
	internal static Void ClearConnectivity() { }

	// RVA: 0xFFFFFFFF75C80B4C
	internal static TerrainGroups CollectTerrains(Boolean onlyAutoConnectedTerrains) { }

	// RVA: 0xFFFFFFFF75C81180
	public static Void AutoConnect() { }

}

// Namespace: 
public class TerrainMap
{
	// Fields
	private Vector3 m_patchSize; // 0x10
	public ErrorCode m_errorCode; // 0x1C
	public Dictionary<T0, T1> m_terrainTiles; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75C81508
	public Terrain GetTerrain(Int32 tileX, Int32 tileZ) { }

	// RVA: 0xFFFFFFFF75C80F10
	public static TerrainMap CreateFromPlacement(Terrain originTerrain, TerrainFilter filter, Boolean fullValidation) { }

	// RVA: 0xFFFFFFFF75C81724
	public static TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, TerrainFilter filter, Boolean fullValidation) { }

	// RVA: 0xFFFFFFFF75C8198C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C81F58
	private Void AddTerrainInternal(Int32 x, Int32 z, Terrain terrain) { }

	// RVA: 0xFFFFFFFF75C81DA0
	private Boolean TryToAddTerrain(Int32 tileX, Int32 tileZ, Terrain terrain) { }

	// RVA: 0xFFFFFFFF75C820DC
	private Void ValidateTerrain(Int32 tileX, Int32 tileZ) { }

	// RVA: 0xFFFFFFFF75C81E3C
	private ErrorCode Validate() { }

}

// Namespace: 
public sealed class TerrainFilter
{
	// Methods

	// RVA: 0xFFFFFFFF75C80EFC
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75C81A0C
	public virtual Boolean Invoke(Terrain terrain) { }

	// RVA: 0xFFFFFFFF75C825D8
	public virtual IAsyncResult BeginInvoke(Terrain terrain, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75C82628
	public virtual Boolean EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public struct TileCoord
{
	// Fields
	public readonly Int32 tileX; // 0x10
	public readonly Int32 tileZ; // 0x14

	// Methods

	// RVA: 0xFFFFFFFF71152948
	public Void .ctor(Int32 tileX, Int32 tileZ) { }

}

// Namespace: 
public enum ErrorCode
{
	// Fields
	public Int32 value__; // 0x10
	public const ErrorCode OK = 0;
	public const ErrorCode Overlapping = 1;
	public const ErrorCode SizeMismatch = 4;
	public const ErrorCode EdgeAlignmentMismatch = 8;
}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Int32 groupID; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C8167C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C82574
	internal Boolean <CreateFromPlacement>b__0(Terrain x) { }

}

// Namespace: 
public class TerrainGroups
{
	// Methods

	// RVA: 0xFFFFFFFF75C80E6C
	public Void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Boolean onlyAutoConnectedTerrains; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C80E64
	public Void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_1
{
	// Fields
	public Terrain t; // 0x10
	public <>c__DisplayClass4_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75C80EB4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C81588
	internal Boolean <CollectTerrains>b__0(Terrain x) { }

}


