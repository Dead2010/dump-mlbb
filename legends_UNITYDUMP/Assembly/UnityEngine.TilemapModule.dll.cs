// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Tilemaps
public class ITilemap
{
	// Fields
	internal static ITilemap s_Instance; // 0x0
	internal Tilemap m_Tilemap; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C86C3C
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75C86C44
	public Void RefreshTile(Vector3Int position) { }

	// RVA: 0xFFFFFFFF75C86CFC
	private static ITilemap CreateInstance() { }

}

// Namespace: UnityEngine.Tilemaps
public class Tile
{
	// Fields
	private Sprite m_Sprite; // 0x18
	private Color m_Color; // 0x20
	private Matrix4x4 m_Transform; // 0x30
	private GameObject m_InstancedGameObject; // 0x70
	private TileFlags m_Flags; // 0x78
	private ColliderType m_ColliderType; // 0x7C

	// Properties
	public Sprite sprite { get; set; }
	public Color color { get; set; }
	public Matrix4x4 transform { get; set; }
	public GameObject gameObject { get; set; }
	public TileFlags flags { get; set; }
	public ColliderType colliderType { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C86D6C
	public Sprite get_sprite() { }

	// RVA: 0xFFFFFFFF75C86D74
	public Void set_sprite(Sprite value) { }

	// RVA: 0xFFFFFFFF75C86D7C
	public Color get_color() { }

	// RVA: 0xFFFFFFFF75C86D88
	public Void set_color(Color value) { }

	// RVA: 0xFFFFFFFF75C86D94
	public Matrix4x4 get_transform() { }

	// RVA: 0xFFFFFFFF75C86DA8
	public Void set_transform(Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF75C86DBC
	public GameObject get_gameObject() { }

	// RVA: 0xFFFFFFFF75C86DC4
	public Void set_gameObject(GameObject value) { }

	// RVA: 0xFFFFFFFF75C86DCC
	public TileFlags get_flags() { }

	// RVA: 0xFFFFFFFF75C86DD4
	public Void set_flags(TileFlags value) { }

	// RVA: 0xFFFFFFFF75C86DDC
	public ColliderType get_colliderType() { }

	// RVA: 0xFFFFFFFF75C86DE4
	public Void set_colliderType(ColliderType value) { }

	// RVA: 0xFFFFFFFF75C86DEC
	public override Void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0xFFFFFFFF75C86E9C
	public Void .ctor() { }

}

// Namespace: 
public enum ColliderType
{
	// Fields
	public Int32 value__; // 0x10
	public const ColliderType None = 0;
	public const ColliderType Sprite = 1;
	public const ColliderType Grid = 2;
}

// Namespace: UnityEngine.Tilemaps
public abstract class TileBase
{
	// Methods

	// RVA: 0xFFFFFFFF75C86F24
	public virtual Void RefreshTile(Vector3Int position, ITilemap tilemap) { }

	// RVA: 0xFFFFFFFF75C86F40
	public virtual Void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0xFFFFFFFF75C86F44
	private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap) { }

	// RVA: 0xFFFFFFFF75C86FB4
	public virtual Boolean GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData) { }

	// RVA: 0xFFFFFFFF75C86FBC
	private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap) { }

	// RVA: 0xFFFFFFFF75C86FF4
	public virtual Boolean StartUp(Vector3Int position, ITilemap tilemap, GameObject go) { }

	// RVA: 0xFFFFFFFF75C86F1C
	protected Void .ctor() { }

}

// Namespace: UnityEngine.Tilemaps
public sealed class Tilemap
{
	// Methods

	// RVA: 0xFFFFFFFF75C86CA4
	public Void RefreshTile(Vector3Int position) { }

	// RVA: 0xFFFFFFFF75C86FFC
	private Void RefreshTile_Injected(ref Vector3Int position) { }

}

// Namespace: UnityEngine.Tilemaps
public enum TileFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const TileFlags None = 0;
	public const TileFlags LockColor = 1;
	public const TileFlags LockTransform = 2;
	public const TileFlags InstantiateGameObjectRuntimeOnly = 4;
	public const TileFlags LockAll = 3;
}

// Namespace: UnityEngine.Tilemaps
public sealed class TilemapRenderer
{
	// Methods

	// RVA: 0xFFFFFFFF75C8704C
	internal Void RegisterSpriteAtlasRegistered() { }

	// RVA: 0xFFFFFFFF75C870F8
	internal Void UnregisterSpriteAtlasRegistered() { }

	// RVA: 0xFFFFFFFF75C871A4
	internal Void OnSpriteAtlasRegistered(SpriteAtlas atlas) { }

}

// Namespace: UnityEngine.Tilemaps
public struct TileData
{
	// Fields
	private Sprite m_Sprite; // 0x10
	private Color m_Color; // 0x18
	private Matrix4x4 m_Transform; // 0x28
	private GameObject m_GameObject; // 0x68
	private TileFlags m_Flags; // 0x70
	private ColliderType m_ColliderType; // 0x74

	// Properties
	public Sprite sprite { set; }
	public Color color { set; }
	public Matrix4x4 transform { set; }
	public GameObject gameObject { set; }
	public TileFlags flags { set; }
	public ColliderType colliderType { set; }

	// Methods

	// RVA: 0xFFFFFFFF7115304C
	public Void set_sprite(Sprite value) { }

	// RVA: 0xFFFFFFFF71153054
	public Void set_color(Color value) { }

	// RVA: 0xFFFFFFFF71153060
	public Void set_transform(Matrix4x4 value) { }

	// RVA: 0xFFFFFFFF7115307C
	public Void set_gameObject(GameObject value) { }

	// RVA: 0xFFFFFFFF71153084
	public Void set_flags(TileFlags value) { }

	// RVA: 0xFFFFFFFF7115308C
	public Void set_colliderType(ColliderType value) { }

}

// Namespace: UnityEngine.Tilemaps
public struct TileAnimationData
{
	// Fields
	private Sprite[] m_AnimatedSprites; // 0x10
	private Single m_AnimationSpeed; // 0x18
	private Single m_AnimationStartTime; // 0x1C
}


