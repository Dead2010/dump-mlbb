// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Networking
public static class UnityWebRequestAssetBundle
{
	// Methods

	// RVA: 0xFFFFFFFF75CA2E68
	public static UnityWebRequest GetAssetBundle(String uri, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75CA2EDC
	public static UnityWebRequest GetAssetBundle(String uri, UInt32 version, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75CA2F58
	public static UnityWebRequest GetAssetBundle(String uri, CachedAssetBundle cachedAssetBundle, UInt32 crc) { }

}

// Namespace: UnityEngine.Networking
public sealed class DownloadHandlerAssetBundle
{
	// Properties
	public AssetBundle assetBundle { get; }

	// Methods

	// RVA: 0xFFFFFFFF75CA28F8
	private static IntPtr Create(DownloadHandlerAssetBundle obj, String url, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75CA2950
	private static IntPtr CreateCached(DownloadHandlerAssetBundle obj, String url, String name, Hash128 hash, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75CA2A3C
	private Void InternalCreateAssetBundle(String url, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75CA2A9C
	private Void InternalCreateAssetBundleCached(String url, String name, Hash128 hash, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75CA2B1C
	public Void .ctor(String url, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75CA2B84
	public Void .ctor(String url, UInt32 version, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75CA2C38
	public Void .ctor(String url, CachedAssetBundle cachedBundle, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75CA2CDC
	protected override Byte[] GetData() { }

	// RVA: 0xFFFFFFFF75CA2D44
	protected override String GetText() { }

	// RVA: 0xFFFFFFFF75CA2DAC
	public AssetBundle get_assetBundle() { }

	// RVA: 0xFFFFFFFF75CA2DEC
	public static AssetBundle GetContent(UnityWebRequest www) { }

	// RVA: 0xFFFFFFFF75CA29CC
	private static IntPtr CreateCached_Injected(DownloadHandlerAssetBundle obj, String url, String name, ref Hash128 hash, UInt32 crc) { }

}


