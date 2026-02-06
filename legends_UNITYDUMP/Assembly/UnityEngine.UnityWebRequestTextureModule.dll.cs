// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Networking
public static class UnityWebRequestTexture
{
	// Methods

	// RVA: 0xFFFFFFFF75CA6468
	public static UnityWebRequest GetTexture(String uri) { }

	// RVA: 0xFFFFFFFF75CA6470
	public static UnityWebRequest GetTexture(String uri, Boolean nonReadable) { }

}

// Namespace: UnityEngine.Networking
public sealed class DownloadHandlerTexture
{
	// Fields
	private Texture2D mTexture; // 0x18
	private Boolean mHasTexture; // 0x20
	private Boolean mNonReadable; // 0x21

	// Properties
	public Texture2D texture { get; }

	// Methods

	// RVA: 0xFFFFFFFF75CA61C4
	private static IntPtr Create(DownloadHandlerTexture obj, Boolean readable) { }

	// RVA: 0xFFFFFFFF75CA6214
	private Void InternalCreateTexture(Boolean readable) { }

	// RVA: 0xFFFFFFFF75CA626C
	public Void .ctor(Boolean readable) { }

	// RVA: 0xFFFFFFFF75CA62D4
	protected override Byte[] GetData() { }

	// RVA: 0xFFFFFFFF75CA62DC
	public Texture2D get_texture() { }

	// RVA: 0xFFFFFFFF75CA62E0
	private Texture2D InternalGetTexture() { }

	// RVA: 0xFFFFFFFF75CA63D4
	private Texture2D InternalGetTextureNative() { }

	// RVA: 0xFFFFFFFF75CA6414
	public static Texture2D GetContent(UnityWebRequest www) { }

}


