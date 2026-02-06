// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class Consts
{
	// Fields
	public const String MonoVersion = "5.11.0.0";
	public const String MonoCompany = "Mono development team";
	public const String MonoProduct = "Mono Common Language Infrastructure";
	public const String MonoCopyright = "(c) Various Mono authors";
	public const Int32 MonoCorlibVersion = 1051100001;
	public const String FxVersion = "4.0.0.0";
	public const String FxFileVersion = "4.6.57.0";
	public const String EnvironmentVersion = "4.0.30319.42000";
	public const String VsVersion = "0.0.0.0";
	public const String VsFileVersion = "11.0.0.0";
	private const String PublicKeyToken = "b77a5c561934e089";
	public const String AssemblyI18N = "I18N, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
	public const String AssemblyMicrosoft_JScript = "Microsoft.JScript, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const String AssemblyMicrosoft_VisualStudio = "Microsoft.VisualStudio, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const String AssemblyMicrosoft_VisualStudio_Web = "Microsoft.VisualStudio.Web, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const String AssemblyMicrosoft_VSDesigner = "Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const String AssemblyMono_Http = "Mono.Http, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
	public const String AssemblyMono_Posix = "Mono.Posix, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
	public const String AssemblyMono_Security = "Mono.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
	public const String AssemblyMono_Messaging_RabbitMQ = "Mono.Messaging.RabbitMQ, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
	public const String AssemblyCorlib = "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const String AssemblySystem = "System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const String AssemblySystem_Data = "System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const String AssemblySystem_Design = "System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const String AssemblySystem_DirectoryServices = "System.DirectoryServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const String AssemblySystem_Drawing = "System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const String AssemblySystem_Drawing_Design = "System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const String AssemblySystem_Messaging = "System.Messaging, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const String AssemblySystem_Security = "System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const String AssemblySystem_ServiceProcess = "System.ServiceProcess, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const String AssemblySystem_Web = "System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const String AssemblySystem_Windows_Forms = "System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const String AssemblySystem_2_0 = "System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const String AssemblySystemCore_3_5 = "System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const String AssemblySystem_Core = "System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const String WindowsBase_3_0 = "WindowsBase, Version=3.0.0.0, PublicKeyToken=31bf3856ad364e35";
	public const String AssemblyWindowsBase = "WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
	public const String AssemblyPresentationCore_3_5 = "PresentationCore, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
	public const String AssemblyPresentationCore_4_0 = "PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
	public const String AssemblyPresentationFramework_3_5 = "PresentationFramework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
	public const String AssemblySystemServiceModel_3_0 = "System.ServiceModel, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
}

// Namespace: I18N.Common
public abstract class ByteEncoding
{
	// Fields
	protected Char[] toChars; // 0x40
	protected String encodingName; // 0x48
	protected String bodyName; // 0x50
	protected String headerName; // 0x58
	protected String webName; // 0x60
	protected Boolean isBrowserDisplay; // 0x68
	protected Boolean isBrowserSave; // 0x69
	protected Boolean isMailNewsDisplay; // 0x6A
	protected Boolean isMailNewsSave; // 0x6B
	protected Int32 windowsCodePage; // 0x6C
	private static Byte[] isNormalized; // 0x0
	private static Byte[] isNormalizedComputed; // 0x8
	private static Byte[] normalization_bytes; // 0x10

	// Properties
	public override Boolean IsSingleByte { get; }
	public override String BodyName { get; }
	public override String EncodingName { get; }
	public override String HeaderName { get; }
	public override Boolean IsBrowserDisplay { get; }
	public override Boolean IsBrowserSave { get; }
	public override Boolean IsMailNewsDisplay { get; }
	public override Boolean IsMailNewsSave { get; }
	public override String WebName { get; }
	public override Int32 WindowsCodePage { get; }

	// Methods

	// RVA: 0xFFFFFFFF759B4180
	protected Void .ctor(Int32 codePage, Char[] toChars, String encodingName, String bodyName, String headerName, String webName, Boolean isBrowserDisplay, Boolean isBrowserSave, Boolean isMailNewsDisplay, Boolean isMailNewsSave, Int32 windowsCodePage) { }

	// RVA: 0xFFFFFFFF759B42D0
	public override Boolean IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0xFFFFFFFF759B46D0
	public override Boolean get_IsSingleByte() { }

	// RVA: 0xFFFFFFFF759B46D8
	public override Int32 GetByteCount(String s) { }

	// RVA: 0xFFFFFFFF759B474C
	public override Int32 GetByteCountImpl(Char* chars, Int32 count) { }

	// RVA: -1
	protected abstract Void ToBytes(Char* chars, Int32 charCount, Byte* bytes, Int32 byteCount) { }

	// RVA: 0xFFFFFFFF759B4754
	protected virtual Void ToBytes(Char[] chars, Int32 charIndex, Int32 charCount, Byte[] bytes, Int32 byteIndex) { }

	// RVA: 0xFFFFFFFF759B4AF8
	public override Int32 GetBytesImpl(Char* chars, Int32 charCount, Byte* bytes, Int32 byteCount) { }

	// RVA: 0xFFFFFFFF759B4B28
	public override Int32 GetCharCount(Byte[] bytes, Int32 index, Int32 count) { }

	// RVA: 0xFFFFFFFF759B4C38
	public override Int32 GetChars(Byte[] bytes, Int32 byteIndex, Int32 byteCount, Char[] chars, Int32 charIndex) { }

	// RVA: 0xFFFFFFFF759B4E7C
	public override Int32 GetMaxByteCount(Int32 charCount) { }

	// RVA: 0xFFFFFFFF759B4F10
	public override Int32 GetMaxCharCount(Int32 byteCount) { }

	// RVA: 0xFFFFFFFF7235691C
	public override String GetString(Byte[] bytes, Int32 index, Int32 count) { }

	// RVA: 0xFFFFFFFF759B4FA4
	public override String GetString(Byte[] bytes) { }

	// RVA: 0xFFFFFFFF759B503C
	public override String get_BodyName() { }

	// RVA: 0xFFFFFFFF759B5044
	public override String get_EncodingName() { }

	// RVA: 0xFFFFFFFF759B504C
	public override String get_HeaderName() { }

	// RVA: 0xFFFFFFFF759B5054
	public override Boolean get_IsBrowserDisplay() { }

	// RVA: 0xFFFFFFFF759B505C
	public override Boolean get_IsBrowserSave() { }

	// RVA: 0xFFFFFFFF759B5064
	public override Boolean get_IsMailNewsDisplay() { }

	// RVA: 0xFFFFFFFF759B506C
	public override Boolean get_IsMailNewsSave() { }

	// RVA: 0xFFFFFFFF759B5074
	public override String get_WebName() { }

	// RVA: 0xFFFFFFFF759B507C
	public override Int32 get_WindowsCodePage() { }

}

// Namespace: I18N.Common
public abstract class ByteSafeEncoding
{
	// Fields
	protected Char[] toChars; // 0x40
	protected String encodingName; // 0x48
	protected String bodyName; // 0x50
	protected String headerName; // 0x58
	protected String webName; // 0x60
	protected Boolean isBrowserDisplay; // 0x68
	protected Boolean isBrowserSave; // 0x69
	protected Boolean isMailNewsDisplay; // 0x6A
	protected Boolean isMailNewsSave; // 0x6B
	protected Int32 windowsCodePage; // 0x6C
	private static Byte[] isNormalized; // 0x0
	private static Byte[] isNormalizedComputed; // 0x8
	private static Byte[] normalization_bytes; // 0x10

	// Properties
	public override Boolean IsSingleByte { get; }
	public override String BodyName { get; }
	public override String EncodingName { get; }
	public override String HeaderName { get; }
	public override Boolean IsBrowserDisplay { get; }
	public override Boolean IsBrowserSave { get; }
	public override Boolean IsMailNewsDisplay { get; }
	public override Boolean IsMailNewsSave { get; }
	public override String WebName { get; }
	public override Int32 WindowsCodePage { get; }

	// Methods

	// RVA: 0xFFFFFFFF759B5084
	protected Void .ctor(Int32 codePage, Char[] toChars, String encodingName, String bodyName, String headerName, String webName, Boolean isBrowserDisplay, Boolean isBrowserSave, Boolean isMailNewsDisplay, Boolean isMailNewsSave, Int32 windowsCodePage) { }

	// RVA: 0xFFFFFFFF759B5200
	public override Boolean IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0xFFFFFFFF759B5600
	public override Boolean get_IsSingleByte() { }

	// RVA: 0xFFFFFFFF759B5608
	public override Int32 GetByteCount(String s) { }

	// RVA: 0xFFFFFFFF759B567C
	public override Int32 GetByteCount(Char[] chars, Int32 index, Int32 count) { }

	// RVA: 0xFFFFFFFF759B5684
	public override Int32 GetByteCount(Char* chars, Int32 count) { }

	// RVA: -1
	protected abstract Void ToBytes(Char[] chars, Int32 charIndex, Int32 charCount, Byte[] bytes, Int32 byteIndex) { }

	// RVA: 0xFFFFFFFF759B568C
	protected virtual Void ToBytes(String s, Int32 charIndex, Int32 charCount, Byte[] bytes, Int32 byteIndex) { }

	// RVA: 0xFFFFFFFF759B572C
	public override Int32 GetBytes(Char[] chars, Int32 charIndex, Int32 charCount, Byte[] bytes, Int32 byteIndex) { }

	// RVA: 0xFFFFFFFF759B5920
	public override Int32 GetBytes(String s, Int32 charIndex, Int32 charCount, Byte[] bytes, Int32 byteIndex) { }

	// RVA: 0xFFFFFFFF759B5B2C
	public override Byte[] GetBytes(String s) { }

	// RVA: 0xFFFFFFFF759B5BD8
	public override Int32 GetCharCount(Byte[] bytes, Int32 index, Int32 count) { }

	// RVA: 0xFFFFFFFF759B5CE8
	public override Int32 GetChars(Byte[] bytes, Int32 byteIndex, Int32 byteCount, Char[] chars, Int32 charIndex) { }

	// RVA: 0xFFFFFFFF759B5F2C
	public override Int32 GetMaxByteCount(Int32 charCount) { }

	// RVA: 0xFFFFFFFF759B5FC0
	public override Int32 GetMaxCharCount(Int32 byteCount) { }

	// RVA: 0xFFFFFFFF759B6054
	public override String GetString(Byte[] bytes, Int32 index, Int32 count) { }

	// RVA: 0xFFFFFFFF759B61F8
	public override String GetString(Byte[] bytes) { }

	// RVA: 0xFFFFFFFF759B6290
	public override String get_BodyName() { }

	// RVA: 0xFFFFFFFF759B6298
	public override String get_EncodingName() { }

	// RVA: 0xFFFFFFFF759B62A0
	public override String get_HeaderName() { }

	// RVA: 0xFFFFFFFF759B62A8
	public override Boolean get_IsBrowserDisplay() { }

	// RVA: 0xFFFFFFFF759B62B0
	public override Boolean get_IsBrowserSave() { }

	// RVA: 0xFFFFFFFF759B62B8
	public override Boolean get_IsMailNewsDisplay() { }

	// RVA: 0xFFFFFFFF759B62C0
	public override Boolean get_IsMailNewsSave() { }

	// RVA: 0xFFFFFFFF759B62C8
	public override String get_WebName() { }

	// RVA: 0xFFFFFFFF759B62D0
	public override Int32 get_WindowsCodePage() { }

}

// Namespace: I18N.Common
public class ReferenceSourceDefaultEncoder
{
	// Fields
	private Encoding m_encoding; // 0x20
	private Boolean m_hasInitializedEncoding; // 0x28
	internal Char charLeftOver; // 0x2A

	// Methods

	// RVA: 0xFFFFFFFF759B9BD4
	public Void .ctor(Encoding encoding) { }

	// RVA: 0xFFFFFFFF759BA478
	internal Void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF759BA69C
	public Object GetRealObject(StreamingContext context) { }

	// RVA: 0xFFFFFFFF759BA6D4
	public override Int32 GetByteCount(Char[] chars, Int32 index, Int32 count, Boolean flush) { }

	// RVA: 0xFFFFFFFF759BA6FC
	public override Int32 GetByteCount(Char* chars, Int32 count, Boolean flush) { }

	// RVA: 0xFFFFFFFF759BA724
	public override Int32 GetBytes(Char[] chars, Int32 charIndex, Int32 charCount, Byte[] bytes, Int32 byteIndex, Boolean flush) { }

	// RVA: 0xFFFFFFFF759BA74C
	public override Int32 GetBytes(Char* chars, Int32 charCount, Byte* bytes, Int32 byteCount, Boolean flush) { }

}

// Namespace: I18N.Common
public sealed class Handlers
{
	// Fields
	public static readonly String[] List; // 0x0
	private static Dictionary<T0, T1> aliases; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF759B62D8
	public static String GetAlias(String name) { }

	// RVA: 0xFFFFFFFF759B635C
	private static Void BuildHash() { }

	// RVA: 0xFFFFFFFF759B703C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759B7044
	private static Void .cctor() { }

}

// Namespace: I18N.Common
public class Manager
{
	// Fields
	private static Manager manager; // 0x0
	private Hashtable handlers; // 0x10
	private Hashtable active; // 0x18
	private Hashtable assemblies; // 0x20
	private static readonly Object lockobj; // 0x8
	private const String hex = "0123456789abcdef";

	// Properties
	public static Manager PrimaryManager { get; }

	// Methods

	// RVA: 0xFFFFFFFF759B7E04
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF759B8100
	public static Manager get_PrimaryManager() { }

	// RVA: 0xFFFFFFFF759B81FC
	private static String Normalize(String name) { }

	// RVA: 0xFFFFFFFF759B8264
	public Encoding GetEncoding(Int32 codePage) { }

	// RVA: 0xFFFFFFFF759B878C
	public Encoding GetEncoding(String name) { }

	// RVA: 0xFFFFFFFF759B8A08
	public CultureInfo GetCulture(Int32 culture, Boolean useUserOverride) { }

	// RVA: 0xFFFFFFFF759B8BC0
	public CultureInfo GetCulture(String name, Boolean useUserOverride) { }

	// RVA: 0xFFFFFFFF759B82F4
	internal Object Instantiate(String name) { }

	// RVA: 0xFFFFFFFF759B7ED4
	private Void LoadClassList() { }

	// RVA: 0xFFFFFFFF72356AA0
	private Void LoadInternalClasses() { }

	// RVA: 0xFFFFFFFF759B8CF4
	private static Void .cctor() { }

}

// Namespace: I18N.Common
public abstract class MonoEncoding
{
	// Fields
	private readonly Int32 win_code_page; // 0x38

	// Properties
	public override Int32 WindowsCodePage { get; }

	// Methods

	// RVA: 0xFFFFFFFF759B42A8
	public Void .ctor(Int32 codePage) { }

	// RVA: 0xFFFFFFFF759B9440
	public Void .ctor(Int32 codePage, Int32 windowsCodePage) { }

	// RVA: 0xFFFFFFFF759B946C
	public override Int32 get_WindowsCodePage() { }

	// RVA: 0xFFFFFFFF759B9484
	protected virtual Int32 GetBytesInternal(Char* chars, Int32 charCount, Byte* bytes, Int32 byteCount, Boolean flush, Object state) { }

	// RVA: 0xFFFFFFFF759B91CC
	public Void HandleFallback(ref EncoderFallbackBuffer buffer, Char* chars, ref Int32 charIndex, ref Int32 charCount, Byte* bytes, ref Int32 byteIndex, ref Int32 byteCount, Object state) { }

	// RVA: 0xFFFFFFFF759B94EC
	public Void HandleFallback(ref EncoderFallbackBuffer buffer, Char* chars, ref Int32 charIndex, ref Int32 charCount, Byte* bytes, ref Int32 byteIndex, ref Int32 byteCount) { }

	// RVA: 0xFFFFFFFF759B950C
	public override Int32 GetByteCount(Char[] chars, Int32 index, Int32 count) { }

	// RVA: 0xFFFFFFFF759B967C
	public override Int32 GetBytes(Char[] chars, Int32 charIndex, Int32 charCount, Byte[] bytes, Int32 byteIndex) { }

	// RVA: 0xFFFFFFFF759B98B8
	public override Int32 GetBytes(String s, Int32 charIndex, Int32 charCount, Byte[] bytes, Int32 byteIndex) { }

	// RVA: 0xFFFFFFFF759B9B04
	public override Int32 GetByteCount(Char* chars, Int32 count) { }

	// RVA: 0xFFFFFFFF759B9B14
	public override Int32 GetBytes(Char* chars, Int32 charCount, Byte* bytes, Int32 byteCount) { }

	// RVA: -1
	public abstract Int32 GetByteCountImpl(Char* chars, Int32 charCount) { }

	// RVA: -1
	public abstract Int32 GetBytesImpl(Char* chars, Int32 charCount, Byte* bytes, Int32 byteCount) { }

	// RVA: 0xFFFFFFFF759B9B24
	public override Encoder GetEncoder() { }

}

// Namespace: I18N.Common
public abstract class MonoEncoder
{
	// Fields
	private MonoEncoding encoding; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF759B8D38
	public Void .ctor(MonoEncoding encoding) { }

	// RVA: 0xFFFFFFFF759B8D6C
	public override Int32 GetByteCount(Char[] chars, Int32 index, Int32 count, Boolean refresh) { }

	// RVA: 0xFFFFFFFF759B8EE4
	public override Int32 GetBytes(Char[] chars, Int32 charIndex, Int32 charCount, Byte[] bytes, Int32 byteIndex, Boolean flush) { }

	// RVA: -1
	public abstract Int32 GetByteCountImpl(Char* chars, Int32 charCount, Boolean refresh) { }

	// RVA: -1
	public abstract Int32 GetBytesImpl(Char* chars, Int32 charCount, Byte* bytes, Int32 byteCount, Boolean refresh) { }

	// RVA: 0xFFFFFFFF759B9128
	public override Int32 GetBytes(Char* chars, Int32 charCount, Byte* bytes, Int32 byteCount, Boolean flush) { }

	// RVA: 0xFFFFFFFF759B9138
	public Void HandleFallback(Char* chars, ref Int32 charIndex, ref Int32 charCount, Byte* bytes, ref Int32 byteIndex, ref Int32 byteCount, Object state) { }

}

// Namespace: I18N.Common
public class MonoEncodingDefaultEncoder
{
	// Methods

	// RVA: 0xFFFFFFFF759B9B94
	public Void .ctor(Encoding encoding) { }

	// RVA: 0xFFFFFFFF759B9C14
	public override Void Convert(Char* chars, Int32 charCount, Byte* bytes, Int32 byteCount, Boolean flush, out Int32 charsUsed, out Int32 bytesUsed, out Boolean completed) { }

	// RVA: 0xFFFFFFFF759B9E0C
	public override Void Convert(Char[] chars, Int32 charIndex, Int32 charCount, Byte[] bytes, Int32 byteIndex, Int32 byteCount, Boolean flush, out Int32 charsUsed, out Int32 bytesUsed, out Boolean completed) { }

	// RVA: 0xFFFFFFFF759B9D18
	private Void CheckArguments(Char* chars, Int32 charCount, Byte* bytes, Int32 byteCount) { }

}

// Namespace: I18N.Common
public abstract class MonoSafeEncoding
{
	// Fields
	private readonly Int32 win_code_page; // 0x38

	// Properties
	public override Int32 WindowsCodePage { get; }

	// Methods

	// RVA: 0xFFFFFFFF759B51D8
	public Void .ctor(Int32 codePage) { }

	// RVA: 0xFFFFFFFF759BA3CC
	public Void .ctor(Int32 codePage, Int32 windowsCodePage) { }

	// RVA: 0xFFFFFFFF759BA3F8
	public override Int32 get_WindowsCodePage() { }

	// RVA: 0xFFFFFFFF759BA410
	protected virtual Int32 GetBytesInternal(Char[] chars, Int32 charIndex, Int32 charCount, Byte[] bytes, Int32 byteIndex, Boolean flush, Object state) { }

	// RVA: 0xFFFFFFFF759BA110
	public Void HandleFallback(ref EncoderFallbackBuffer buffer, Char[] chars, ref Int32 charIndex, ref Int32 charCount, Byte[] bytes, ref Int32 byteIndex, ref Int32 byteCount, Object state) { }

}

// Namespace: I18N.Common
public abstract class MonoSafeEncoder
{
	// Fields
	private MonoSafeEncoding encoding; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF759BA048
	public Void .ctor(MonoSafeEncoding encoding) { }

	// RVA: 0xFFFFFFFF759BA07C
	public Void HandleFallback(Char[] chars, ref Int32 charIndex, ref Int32 charCount, Byte[] bytes, ref Int32 byteIndex, ref Int32 byteCount, Object state) { }

}

// Namespace: I18N.Common
public sealed class Strings
{
	// Methods

	// RVA: 0xFFFFFFFF759B4910
	public static String GetString(String tag) { }

	// RVA: 0xFFFFFFFF759BA774
	public Void .ctor() { }

}


