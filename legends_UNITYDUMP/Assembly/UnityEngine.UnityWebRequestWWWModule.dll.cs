// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public class WWW
{
	// Fields
	private ThreadPriority <threadPriority>k__BackingField; // 0x10
	private UnityWebRequest _uwr; // 0x18
	private AssetBundle _assetBundle; // 0x20
	private Dictionary<T0, T1> _responseHeaders; // 0x28

	// Properties
	public AssetBundle assetBundle { get; }
	public Byte[] bytes { get; }
	public String error { get; }
	public Boolean isDone { get; }
	public Single progress { get; }
	public String text { get; }
	public Texture2D texture { get; }
	public String url { get; }
	public override Boolean keepWaiting { get; }

	// Methods

	// RVA: 0xFFFFFFFF75CA6500
	public static String EscapeURL(String s) { }

	// RVA: 0xFFFFFFFF75CA6530
	public static String EscapeURL(String s, Encoding e) { }

	// RVA: 0xFFFFFFFF75CA6538
	public static String UnEscapeURL(String s) { }

	// RVA: 0xFFFFFFFF75CA6568
	public static String UnEscapeURL(String s, Encoding e) { }

	// RVA: 0xFFFFFFFF75CA6570
	public static WWW LoadFromCacheOrDownload(String url, Int32 version) { }

	// RVA: 0xFFFFFFFF75CA6578
	public static WWW LoadFromCacheOrDownload(String url, Int32 version, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75CA6604
	public static WWW LoadFromCacheOrDownload(String url, Hash128 hash, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75CA6724
	public Void .ctor(String url) { }

	// RVA: 0xFFFFFFFF75CA6778
	public Void .ctor(String url, Byte[] postData) { }

	// RVA: 0xFFFFFFFF75CA666C
	internal Void .ctor(String url, String name, Hash128 hash, UInt32 crc) { }

	// RVA: 0xFFFFFFFF75CA6890
	public AssetBundle get_assetBundle() { }

	// RVA: 0xFFFFFFFF75CA6A7C
	public Byte[] get_bytes() { }

	// RVA: 0xFFFFFFFF75CA6AE4
	public String get_error() { }

	// RVA: 0xFFFFFFFF75CA6BEC
	public Boolean get_isDone() { }

	// RVA: 0xFFFFFFFF75CA6C38
	public Single get_progress() { }

	// RVA: 0xFFFFFFFF75CA6C68
	public String get_text() { }

	// RVA: 0xFFFFFFFF75CA6CCC
	private Texture2D CreateTextureFromDownloadedData(Boolean markNonReadable) { }

	// RVA: 0xFFFFFFFF75CA6D9C
	public Texture2D get_texture() { }

	// RVA: 0xFFFFFFFF75CA6DA4
	public Void LoadImageIntoTexture(Texture2D texture) { }

	// RVA: 0xFFFFFFFF75CA6EB4
	public String get_url() { }

	// RVA: 0xFFFFFFFF723D72B0
	public override Boolean get_keepWaiting() { }

	// RVA: 0xFFFFFFFF75CA6ED4
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75CA6950
	private Boolean WaitUntilDoneIfPossible() { }

}


