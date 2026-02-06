// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public class AssetBundle
{
	// Properties
	public Object mainAsset { get; }
	public Boolean isStreamedSceneAssetBundle { get; }
	public static UInt32 memoryBudgetKB { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75BE88F8
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF723B474C
	public Object get_mainAsset() { }

	// RVA: 0xFFFFFFFF75BE8938
	internal static Object returnMainAsset(AssetBundle bundle) { }

	// RVA: 0xFFFFFFFF75BE8978
	public static Void UnloadAllAssetBundles(Boolean unloadAllObjects) { }

	// RVA: 0xFFFFFFFF75BE89B8
	internal static AssetBundle[] GetAllLoadedAssetBundles_Native() { }

	// RVA: 0xFFFFFFFF75BE89EC
	public static IEnumerable<T0> GetAllLoadedAssetBundles() { }

	// RVA: 0xFFFFFFFF75BE8A20
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(String path, UInt32 crc, UInt64 offset) { }

	// RVA: 0xFFFFFFFF723B47A0
	public static AssetBundleCreateRequest LoadFromFileAsync(String path) { }

	// RVA: 0xFFFFFFFF75BE8A78
	public static AssetBundleCreateRequest LoadFromFileAsync(String path, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75BE8ACC
	public static AssetBundleCreateRequest LoadFromFileAsync(String path, UInt32 crc, UInt64 offset) { }

	// RVA: 0xFFFFFFFF75BE8B24
	internal static AssetBundle LoadFromFile_Internal(String path, UInt32 crc, UInt64 offset) { }

	// RVA: 0xFFFFFFFF723B47FC
	public static AssetBundle LoadFromFile(String path) { }

	// RVA: 0xFFFFFFFF75BE8B7C
	public static AssetBundle LoadFromFile(String path, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75BE8BD0
	public static AssetBundle LoadFromFile(String path, UInt32 crc, UInt64 offset) { }

	// RVA: 0xFFFFFFFF75BE8C28
	internal static AssetBundleCreateRequest LoadFromMemoryAsync_Internal(Byte[] binary, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75BE8C78
	public static AssetBundleCreateRequest LoadFromMemoryAsync(Byte[] binary) { }

	// RVA: 0xFFFFFFFF75BE8CBC
	public static AssetBundleCreateRequest LoadFromMemoryAsync(Byte[] binary, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75BE8D0C
	internal static AssetBundle LoadFromMemory_Internal(Byte[] binary, UInt32 crc) { }

	// RVA: 0xFFFFFFFF723B4848
	public static AssetBundle LoadFromMemory(Byte[] binary) { }

	// RVA: 0xFFFFFFFF75BE8D5C
	public static AssetBundle LoadFromMemory(Byte[] binary, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75BE8DAC
	internal static Void ValidateLoadFromStream(Stream stream) { }

	// RVA: 0xFFFFFFFF75BE8EC0
	public static AssetBundleCreateRequest LoadFromStreamAsync(Stream stream, UInt32 crc, UInt32 managedReadBufferSize) { }

	// RVA: 0xFFFFFFFF75BE8F74
	public static AssetBundleCreateRequest LoadFromStreamAsync(Stream stream, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75BE8FCC
	public static AssetBundleCreateRequest LoadFromStreamAsync(Stream stream) { }

	// RVA: 0xFFFFFFFF75BE9018
	public static AssetBundle LoadFromStream(Stream stream, UInt32 crc, UInt32 managedReadBufferSize) { }

	// RVA: 0xFFFFFFFF75BE90CC
	public static AssetBundle LoadFromStream(Stream stream, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75BE9124
	public static AssetBundle LoadFromStream(Stream stream) { }

	// RVA: 0xFFFFFFFF75BE8F1C
	internal static AssetBundleCreateRequest LoadFromStreamAsyncInternal(Stream stream, UInt32 crc, UInt32 managedReadBufferSize) { }

	// RVA: 0xFFFFFFFF75BE9074
	internal static AssetBundle LoadFromStreamInternal(Stream stream, UInt32 crc, UInt32 managedReadBufferSize) { }

	// RVA: 0xFFFFFFFF75BE9170
	public Boolean get_isStreamedSceneAssetBundle() { }

	// RVA: 0xFFFFFFFF75BE91B0
	internal static Void SetAssetBundleKey(String password, Boolean isEncrypt) { }

	// RVA: 0xFFFFFFFF75BE9200
	public static Void SetAssetBundleDecryptKey(String password) { }

	// RVA: 0xFFFFFFFF723B4890
	public Boolean Contains(String name) { }

	// RVA: 0xFFFFFFFF75BE9244
	public Object Load(String name) { }

	// RVA: -1
	public Object Load(String name) { }

	// RVA: 0xFFFFFFFF75BE924C
	private Object Load(String name, Type type) { }

	// RVA: 0xFFFFFFFF75BE9254
	private AssetBundleRequest LoadAsync(String name, Type type) { }

	// RVA: 0xFFFFFFFF75BE925C
	private Object[] LoadAll(Type type) { }

	// RVA: 0xFFFFFFFF75BE9264
	public Object[] LoadAll() { }

	// RVA: -1
	public T[] LoadAll() { }

	// RVA: 0xFFFFFFFF723B48E4
	public Object LoadAsset(String name) { }

	// RVA: -1
	public T LoadAsset(String name) { }

	// RVA: 0xFFFFFFFF723B4954
	public Object LoadAsset(String name, Type type) { }

	// RVA: 0xFFFFFFFF75BE926C
	private Object LoadAsset_Internal(String name, Type type) { }

	// RVA: 0xFFFFFFFF75BE92C4
	public AssetBundleRequest LoadAssetAsync(String name) { }

	// RVA: -1
	public AssetBundleRequest LoadAssetAsync(String name) { }

	// RVA: 0xFFFFFFFF75BE9328
	public AssetBundleRequest LoadAssetAsync(String name, Type type) { }

	// RVA: 0xFFFFFFFF75BE9478
	public Object[] LoadAssetWithSubAssets(String name) { }

	// RVA: -1
	internal static T[] ConvertObjects(Object[] rawObjects) { }

	// RVA: -1
	public T[] LoadAssetWithSubAssets(String name) { }

	// RVA: 0xFFFFFFFF75BE94DC
	public Object[] LoadAssetWithSubAssets(String name, Type type) { }

	// RVA: 0xFFFFFFFF75BE962C
	public AssetBundleRequest LoadAssetWithSubAssetsAsync(String name) { }

	// RVA: -1
	public AssetBundleRequest LoadAssetWithSubAssetsAsync(String name) { }

	// RVA: 0xFFFFFFFF75BE9690
	public AssetBundleRequest LoadAssetWithSubAssetsAsync(String name, Type type) { }

	// RVA: 0xFFFFFFFF75BE97E0
	public Object[] LoadAllAssets() { }

	// RVA: -1
	public T[] LoadAllAssets() { }

	// RVA: 0xFFFFFFFF723B4A2C
	public Object[] LoadAllAssets(Type type) { }

	// RVA: 0xFFFFFFFF75BE9834
	public AssetBundleRequest LoadAllAssetsAsync() { }

	// RVA: -1
	public AssetBundleRequest LoadAllAssetsAsync() { }

	// RVA: 0xFFFFFFFF75BE9888
	public AssetBundleRequest LoadAllAssetsAsync(Type type) { }

	// RVA: 0xFFFFFFFF75BE9938
	public String[] AllAssetNames() { }

	// RVA: 0xFFFFFFFF75BE9420
	private AssetBundleRequest LoadAssetAsync_Internal(String name, Type type) { }

	// RVA: 0xFFFFFFFF723B4AE4
	public Void Unload(Boolean unloadAllLoadedObjects) { }

	// RVA: 0xFFFFFFFF75BE9978
	public String[] GetAllAssetNames() { }

	// RVA: 0xFFFFFFFF75BE99B8
	public String[] GetAllScenePaths() { }

	// RVA: 0xFFFFFFFF75BE95D4
	internal Object[] LoadAssetWithSubAssets_Internal(String name, Type type) { }

	// RVA: 0xFFFFFFFF75BE9788
	private AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(String name, Type type) { }

	// RVA: 0xFFFFFFFF75BE99F8
	public static AssetBundleRecompressOperation RecompressAssetBundleAsync(String inputPath, String outputPath, BuildCompression method, UInt32 expectedCRC, ThreadPriority priority) { }

	// RVA: 0xFFFFFFFF75BE9A74
	internal static AssetBundleRecompressOperation RecompressAssetBundleAsync_Internal(String inputPath, String outputPath, BuildCompression method, UInt32 expectedCRC, ThreadPriority priority) { }

	// RVA: 0xFFFFFFFF75BE9B60
	public static Void EnableStreamd2017AssetBundle(Boolean enable) { }

	// RVA: 0xFFFFFFFF75BE9BA0
	public static Void DisableStreamed2017AssetBundleClass(String className) { }

	// RVA: 0xFFFFFFFF75BE9BE0
	public static UInt32 get_memoryBudgetKB() { }

	// RVA: 0xFFFFFFFF75BE9C44
	public static Void set_memoryBudgetKB(UInt32 value) { }

	// RVA: 0xFFFFFFFF75BE9AF0
	private static AssetBundleRecompressOperation RecompressAssetBundleAsync_Internal_Injected(String inputPath, String outputPath, ref BuildCompression method, UInt32 expectedCRC, ThreadPriority priority) { }

}

// Namespace: UnityEngine
public class AssetBundleCreateRequest
{
	// Properties
	public AssetBundle assetBundle { get; }

	// Methods

	// RVA: 0xFFFFFFFF723B4B40
	public AssetBundle get_assetBundle() { }

	// RVA: 0xFFFFFFFF75BE9D9C
	public Void .ctor() { }

}

// Namespace: UnityEngine
internal static class AssetBundleLoadingCache
{
	// Properties
	internal static UInt32 maxBlocksPerFile { get; set; }
	internal static UInt32 blockCount { get; set; }
	internal static UInt32 blockSize { get; }
	internal static UInt32 memoryBudgetKB { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75BE9DA4
	internal static UInt32 get_maxBlocksPerFile() { }

	// RVA: 0xFFFFFFFF75BE9DD8
	internal static Void set_maxBlocksPerFile(UInt32 value) { }

	// RVA: 0xFFFFFFFF75BE9E18
	internal static UInt32 get_blockCount() { }

	// RVA: 0xFFFFFFFF75BE9E4C
	internal static Void set_blockCount(UInt32 value) { }

	// RVA: 0xFFFFFFFF75BE9E8C
	internal static UInt32 get_blockSize() { }

	// RVA: 0xFFFFFFFF75BE9BE4
	internal static UInt32 get_memoryBudgetKB() { }

	// RVA: 0xFFFFFFFF75BE9C48
	internal static Void set_memoryBudgetKB(UInt32 value) { }

}

// Namespace: UnityEngine
public class AssetBundleRecompressOperation
{
	// Methods

	// RVA: 0xFFFFFFFF75BE9EC0
	public Void .ctor() { }

}

// Namespace: UnityEngine
public class AssetBundleRequest
{
	// Properties
	public Object asset { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BE9EC8
	public Object get_asset() { }

	// RVA: 0xFFFFFFFF75BE9F08
	public Void .ctor() { }

}

// Namespace: UnityEngine
public enum CompressionType
{
	// Fields
	public Int32 value__; // 0x10
	public const CompressionType None = 0;
	public const CompressionType Lzma = 1;
	public const CompressionType Lz4 = 2;
	public const CompressionType Lz4HC = 3;
}

// Namespace: UnityEngine
public enum CompressionLevel
{
	// Fields
	public Int32 value__; // 0x10
	public const CompressionLevel None = 0;
	public const CompressionLevel Fastest = 1;
	public const CompressionLevel Fast = 2;
	public const CompressionLevel Normal = 3;
	public const CompressionLevel High = 4;
	public const CompressionLevel Maximum = 5;
}

// Namespace: UnityEngine
public struct BuildCompression
{
	// Fields
	public static readonly BuildCompression Uncompressed; // 0x0
	public static readonly BuildCompression LZ4; // 0x10
	public static readonly BuildCompression LZMA; // 0x20
	public static readonly BuildCompression UncompressedRuntime; // 0x30
	public static readonly BuildCompression LZ4Runtime; // 0x40
	private CompressionType _compression; // 0x10
	private CompressionLevel _level; // 0x14
	private UInt32 _blockSize; // 0x18
	private Boolean _enableProtect; // 0x1C

	// Properties
	private CompressionType compression { set; }
	private CompressionLevel level { set; }
	private UInt32 blockSize { set; }
	private Boolean enableProtect { set; }

	// Methods

	// RVA: 0xFFFFFFFF7114A860
	private Void set_compression(CompressionType value) { }

	// RVA: 0xFFFFFFFF7114A868
	private Void set_level(CompressionLevel value) { }

	// RVA: 0xFFFFFFFF7114A870
	private Void set_blockSize(UInt32 value) { }

	// RVA: 0xFFFFFFFF7114A878
	private Void set_enableProtect(Boolean value) { }

	// RVA: 0xFFFFFFFF7114A880
	private Void .ctor(CompressionType in_compression, CompressionLevel in_level, UInt32 in_blockSize) { }

	// RVA: 0xFFFFFFFF75BE9F48
	private static Void .cctor() { }

}


