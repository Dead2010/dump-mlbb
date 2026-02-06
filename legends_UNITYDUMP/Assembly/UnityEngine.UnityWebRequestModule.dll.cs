// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngineInternal
internal static class WebRequestUtils
{
	// Fields
	private static Regex domainRegex; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75CA5FF4
	internal static String RedirectTo(String baseUri, String redirectUri) { }

	// RVA: 0xFFFFFFFF723D6ADC
	internal static String MakeInitialUrl(String targetUrl, String localUrl) { }

	// RVA: 0xFFFFFFFF723D6FA0
	internal static String MakeUriString(Uri targetUri, String targetUrl, Boolean prependProtocol) { }

	// RVA: 0xFFFFFFFF75CA60C0
	private static String URLDecode(String encoded) { }

	// RVA: 0xFFFFFFFF75CA6164
	private static Void .cctor() { }

}

// Namespace: UnityEngine
public class WWWForm
{
	// Properties
	internal static Encoding DefaultEncoding { get; }

	// Methods

	// RVA: 0xFFFFFFFF75CA5548
	internal static Encoding get_DefaultEncoding() { }

}

// Namespace: UnityEngine
internal class WWWTranscoder
{
	// Fields
	private static Byte[] ucHexChars; // 0x0
	private static Byte[] lcHexChars; // 0x8
	private static Byte urlEscapeChar; // 0x10
	private static Byte[] urlSpace; // 0x18
	private static Byte[] dataSpace; // 0x20
	private static Byte[] urlForbidden; // 0x28
	private static Byte qpEscapeChar; // 0x30
	private static Byte[] qpSpace; // 0x38
	private static Byte[] qpForbidden; // 0x40

	// Methods

	// RVA: 0xFFFFFFFF75CA5550
	private static Byte Hex2Byte(Byte[] b, Int32 offset) { }

	// RVA: 0xFFFFFFFF75CA5608
	private static Byte[] Byte2Hex(Byte b, Byte[] hexChars) { }

	// RVA: 0xFFFFFFFF75CA50C8
	public static Byte[] URLEncode(Byte[] toEncode) { }

	// RVA: 0xFFFFFFFF75CA4E50
	public static String DataEncode(String toEncode, Encoding e) { }

	// RVA: 0xFFFFFFFF75CA5684
	public static Byte[] Encode(Byte[] input, Byte escapeChar, Byte[] space, Byte[] forbidden, Boolean uppercase) { }

	// RVA: 0xFFFFFFFF75CA59E4
	private static Boolean ByteArrayContains(Byte[] array, Byte b) { }

	// RVA: 0xFFFFFFFF75CA5254
	public static Byte[] URLDecode(Byte[] toEncode) { }

	// RVA: 0xFFFFFFFF75CA5CFC
	private static Boolean ByteSubArrayEquals(Byte[] array, Int32 index, Byte[] comperand) { }

	// RVA: 0xFFFFFFFF75CA5A60
	public static Byte[] Decode(Byte[] input, Byte escapeChar, Byte[] space) { }

	// RVA: 0xFFFFFFFF75CA5D98
	private static Void .cctor() { }

}

// Namespace: UnityEngine.Networking
public class UnityWebRequestAsyncOperation
{
	// Fields
	private UnityWebRequest <webRequest>k__BackingField; // 0x20

	// Properties
	internal UnityWebRequest webRequest { set; }

	// Methods

	// RVA: 0xFFFFFFFF75CA52C0
	internal Void set_webRequest(UnityWebRequest value) { }

	// RVA: 0xFFFFFFFF75CA52F8
	public Void .ctor() { }

}

// Namespace: UnityEngine.Networking
public class UnityWebRequest
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal DownloadHandler m_DownloadHandler; // 0x18
	internal UploadHandler m_UploadHandler; // 0x20
	internal CertificateHandler m_CertificateHandler; // 0x28
	internal Uri m_Uri; // 0x30
	public const String kHttpVerbGET = "GET";
	public const String kHttpVerbHEAD = "HEAD";
	public const String kHttpVerbPOST = "POST";
	public const String kHttpVerbPUT = "PUT";
	public const String kHttpVerbCREATE = "CREATE";
	public const String kHttpVerbDELETE = "DELETE";
	private Boolean <disposeCertificateHandlerOnDispose>k__BackingField; // 0x38
	private Boolean <disposeDownloadHandlerOnDispose>k__BackingField; // 0x39
	private Boolean <disposeUploadHandlerOnDispose>k__BackingField; // 0x3A

	// Properties
	public Boolean disposeCertificateHandlerOnDispose { get; set; }
	public Boolean disposeDownloadHandlerOnDispose { get; set; }
	public Boolean disposeUploadHandlerOnDispose { get; set; }
	public String method { set; }
	public String error { get; }
	public String url { get; set; }
	public Uri uri { get; }
	public Int64 responseCode { get; }
	public Single uploadProgress { get; }
	public Boolean isModifiable { get; }
	public Boolean isDone { get; }
	public Boolean isNetworkError { get; }
	public Boolean isHttpError { get; }
	public Single downloadProgress { get; }
	public UInt64 uploadedBytes { get; }
	public UInt64 downloadedBytes { get; }
	public Boolean chunkedTransfer { set; }
	public UploadHandler uploadHandler { get; set; }
	public DownloadHandler downloadHandler { get; set; }
	public CertificateHandler certificateHandler { get; }
	public Int32 timeout { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75CA38C8
	private static String GetWebErrorString(UnityWebRequestError err) { }

	// RVA: 0xFFFFFFFF75CA3908
	internal static String GetHTTPStatusString(Int64 responseCode) { }

	// RVA: 0xFFFFFFFF75CA3948
	public Boolean get_disposeCertificateHandlerOnDispose() { }

	// RVA: 0xFFFFFFFF75CA3950
	public Void set_disposeCertificateHandlerOnDispose(Boolean value) { }

	// RVA: 0xFFFFFFFF75CA3958
	public Boolean get_disposeDownloadHandlerOnDispose() { }

	// RVA: 0xFFFFFFFF75CA3960
	public Void set_disposeDownloadHandlerOnDispose(Boolean value) { }

	// RVA: 0xFFFFFFFF75CA3968
	public Boolean get_disposeUploadHandlerOnDispose() { }

	// RVA: 0xFFFFFFFF75CA3970
	public Void set_disposeUploadHandlerOnDispose(Boolean value) { }

	// RVA: 0xFFFFFFFF75CA3978
	internal static IntPtr Create() { }

	// RVA: 0xFFFFFFFF75CA39AC
	private Void Release() { }

	// RVA: 0xFFFFFFFF723D6450
	internal Void InternalDestroy() { }

	// RVA: 0xFFFFFFFF75CA3A2C
	private Void InternalSetDefaults() { }

	// RVA: 0xFFFFFFFF75CA3A40
	public Void .ctor(String url, String method) { }

	// RVA: 0xFFFFFFFF75CA3ABC
	public Void .ctor(String url, String method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0xFFFFFFFF75CA3C70
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF723D67C8
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF723D6768
	private Void DisposeHandlers() { }

	// RVA: 0xFFFFFFFF75CA3D34
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	// RVA: 0xFFFFFFFF723D691C
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	// RVA: 0xFFFFFFFF75CA39EC
	public Void Abort() { }

	// RVA: 0xFFFFFFFF75CA3D74
	private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType) { }

	// RVA: 0xFFFFFFFF723D6994
	internal Void InternalSetMethod(UnityWebRequestMethod methodType) { }

	// RVA: 0xFFFFFFFF75CA3E04
	private UnityWebRequestError SetCustomMethod(String customMethodName) { }

	// RVA: 0xFFFFFFFF75CA3E54
	internal Void InternalSetCustomMethod(String customMethodName) { }

	// RVA: 0xFFFFFFFF723D6534
	public Void set_method(String value) { }

	// RVA: 0xFFFFFFFF75CA3F5C
	private UnityWebRequestError GetError() { }

	// RVA: 0xFFFFFFFF75CA3F9C
	public String get_error() { }

	// RVA: 0xFFFFFFFF75CA41FC
	public String get_url() { }

	// RVA: 0xFFFFFFFF723D64D0
	public Void set_url(String value) { }

	// RVA: 0xFFFFFFFF75CA427C
	public Uri get_uri() { }

	// RVA: 0xFFFFFFFF75CA423C
	private String GetUrl() { }

	// RVA: 0xFFFFFFFF75CA42E4
	private UnityWebRequestError SetUrl(String url) { }

	// RVA: 0xFFFFFFFF723D6E6C
	private Void InternalSetUrl(String url) { }

	// RVA: 0xFFFFFFFF75CA41B8
	public Int64 get_responseCode() { }

	// RVA: 0xFFFFFFFF75CA4334
	private Single GetUploadProgress() { }

	// RVA: 0xFFFFFFFF75CA4374
	private Boolean IsExecuting() { }

	// RVA: 0xFFFFFFFF75CA43B4
	public Single get_uploadProgress() { }

	// RVA: 0xFFFFFFFF75CA3DC4
	public Boolean get_isModifiable() { }

	// RVA: 0xFFFFFFFF723D6F5C
	public Boolean get_isDone() { }

	// RVA: 0xFFFFFFFF723D6A88
	public Boolean get_isNetworkError() { }

	// RVA: 0xFFFFFFFF75CA4164
	public Boolean get_isHttpError() { }

	// RVA: 0xFFFFFFFF75CA445C
	private Single GetDownloadProgress() { }

	// RVA: 0xFFFFFFFF75CA449C
	public Single get_downloadProgress() { }

	// RVA: 0xFFFFFFFF75CA4544
	public UInt64 get_uploadedBytes() { }

	// RVA: 0xFFFFFFFF75CA4584
	public UInt64 get_downloadedBytes() { }

	// RVA: 0xFFFFFFFF75CA45C8
	private UnityWebRequestError SetChunked(Boolean chunked) { }

	// RVA: 0xFFFFFFFF75CA4618
	public Void set_chunkedTransfer(Boolean value) { }

	// RVA: 0xFFFFFFFF75CA472C
	internal UnityWebRequestError InternalSetRequestHeader(String name, String value) { }

	// RVA: 0xFFFFFFFF75CA4784
	public Void SetRequestHeader(String name, String value) { }

	// RVA: 0xFFFFFFFF75CA4908
	public String GetResponseHeader(String name) { }

	// RVA: 0xFFFFFFFF75CA4958
	private UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0xFFFFFFFF75CA3D24
	public UploadHandler get_uploadHandler() { }

	// RVA: 0xFFFFFFFF723D6654
	public Void set_uploadHandler(UploadHandler value) { }

	// RVA: 0xFFFFFFFF75CA49A8
	private UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0xFFFFFFFF75CA3D1C
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0xFFFFFFFF75CA3B5C
	public Void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0xFFFFFFFF75CA3D2C
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0xFFFFFFFF75CA49F8
	private Int32 GetTimeoutMsec() { }

	// RVA: 0xFFFFFFFF75CA4A38
	private UnityWebRequestError SetTimeoutMsec(Int32 timeout) { }

	// RVA: 0xFFFFFFFF75CA4A88
	public Int32 get_timeout() { }

	// RVA: 0xFFFFFFFF75CA4AE4
	public Void set_timeout(Int32 value) { }

	// RVA: 0xFFFFFFFF75CA4C10
	public static UnityWebRequest Get(String uri) { }

	// RVA: 0xFFFFFFFF75CA4CA0
	public static UnityWebRequest Post(String uri, String postData) { }

	// RVA: 0xFFFFFFFF75CA4CF8
	private static Void SetupPost(UnityWebRequest request, String postData) { }

	// RVA: 0xFFFFFFFF75CA4FF0
	public static String EscapeURL(String s, Encoding e) { }

	// RVA: 0xFFFFFFFF75CA513C
	public static String UnEscapeURL(String s) { }

	// RVA: 0xFFFFFFFF75CA5168
	public static String UnEscapeURL(String s, Encoding e) { }

}

// Namespace: 
internal enum UnityWebRequestMethod
{
	// Fields
	public Int32 value__; // 0x10
	public const UnityWebRequestMethod Get = 0;
	public const UnityWebRequestMethod Post = 1;
	public const UnityWebRequestMethod Put = 2;
	public const UnityWebRequestMethod Head = 3;
	public const UnityWebRequestMethod Custom = 4;
}

// Namespace: 
internal enum UnityWebRequestError
{
	// Fields
	public Int32 value__; // 0x10
	public const UnityWebRequestError OK = 0;
	public const UnityWebRequestError Unknown = 1;
	public const UnityWebRequestError SDKError = 2;
	public const UnityWebRequestError UnsupportedProtocol = 3;
	public const UnityWebRequestError MalformattedUrl = 4;
	public const UnityWebRequestError CannotResolveProxy = 5;
	public const UnityWebRequestError CannotResolveHost = 6;
	public const UnityWebRequestError CannotConnectToHost = 7;
	public const UnityWebRequestError AccessDenied = 8;
	public const UnityWebRequestError GenericHttpError = 9;
	public const UnityWebRequestError WriteError = 10;
	public const UnityWebRequestError ReadError = 11;
	public const UnityWebRequestError OutOfMemory = 12;
	public const UnityWebRequestError Timeout = 13;
	public const UnityWebRequestError HTTPPostError = 14;
	public const UnityWebRequestError SSLCannotConnect = 15;
	public const UnityWebRequestError Aborted = 16;
	public const UnityWebRequestError TooManyRedirects = 17;
	public const UnityWebRequestError ReceivedNoData = 18;
	public const UnityWebRequestError SSLNotSupported = 19;
	public const UnityWebRequestError FailedToSendData = 20;
	public const UnityWebRequestError FailedToReceiveData = 21;
	public const UnityWebRequestError SSLCertificateError = 22;
	public const UnityWebRequestError SSLCipherNotAvailable = 23;
	public const UnityWebRequestError SSLCACertError = 24;
	public const UnityWebRequestError UnrecognizedContentEncoding = 25;
	public const UnityWebRequestError LoginFailed = 26;
	public const UnityWebRequestError SSLShutdownFailed = 27;
	public const UnityWebRequestError NoInternetConnection = 28;
}

// Namespace: UnityEngine.Networking
public class CertificateHandler
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75CA30A8
	private Void Release() { }

	// RVA: 0xFFFFFFFF75CA30E8
	protected virtual Boolean ValidateCertificate(Byte[] certificateData) { }

	// RVA: 0xFFFFFFFF75CA30F0
	internal Boolean ValidateCertificateNative(Byte[] certificateData) { }

	// RVA: 0xFFFFFFFF75CA3100
	public Void Dispose() { }

}

// Namespace: UnityEngine.Networking
public class DownloadHandler
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public Byte[] data { get; }
	public String text { get; }

	// Methods

	// RVA: 0xFFFFFFFF75CA3150
	private Void Release() { }

	// RVA: 0xFFFFFFFF75CA3190
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75CA3194
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF723D63FC
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75CA31FC
	public Byte[] get_data() { }

	// RVA: 0xFFFFFFFF75CA320C
	public String get_text() { }

	// RVA: 0xFFFFFFFF75CA321C
	protected virtual Byte[] GetData() { }

	// RVA: 0xFFFFFFFF75CA3224
	protected virtual String GetText() { }

	// RVA: 0xFFFFFFFF75CA329C
	private Encoding GetTextEncoder() { }

	// RVA: 0xFFFFFFFF75CA34C4
	private String GetContentType() { }

	// RVA: 0xFFFFFFFF75CA3504
	protected virtual Void ReceiveContentLengthHeader(UInt64 contentLength) { }

	// RVA: 0xFFFFFFFF75CA3514
	protected virtual Void ReceiveContentLength(Int32 contentLength) { }

	// RVA: -1
	protected static T GetCheckedDownloader(UnityWebRequest www) { }

	// RVA: 0xFFFFFFFF75CA3518
	internal static Byte[] InternalGetByteArray(DownloadHandler dh) { }

}

// Namespace: UnityEngine.Networking
public sealed class DownloadHandlerBuffer
{
	// Methods

	// RVA: 0xFFFFFFFF75CA356C
	private static IntPtr Create(DownloadHandlerBuffer obj) { }

	// RVA: 0xFFFFFFFF75CA35AC
	private Void InternalCreateBuffer() { }

	// RVA: 0xFFFFFFFF75CA35F4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75CA3640
	protected override Byte[] GetData() { }

	// RVA: 0xFFFFFFFF75CA3684
	private Byte[] InternalGetData() { }

	// RVA: 0xFFFFFFFF75CA36C4
	public static String GetContent(UnityWebRequest www) { }

}

// Namespace: UnityEngine.Networking
public sealed class DownloadHandlerFile
{
	// Methods

	// RVA: 0xFFFFFFFF75CA36F4
	private static IntPtr Create(DownloadHandlerFile obj, String path, Boolean append) { }

	// RVA: 0xFFFFFFFF75CA374C
	private Void InternalCreateVFS(String path, Boolean append) { }

	// RVA: 0xFFFFFFFF75CA37F0
	public Void .ctor(String path) { }

	// RVA: 0xFFFFFFFF75CA37F8
	protected override Byte[] GetData() { }

	// RVA: 0xFFFFFFFF75CA3860
	protected override String GetText() { }

}

// Namespace: UnityEngine.Networking
public class UploadHandler
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public String contentType { set; }

	// Methods

	// RVA: 0xFFFFFFFF75CA5300
	private Void Release() { }

	// RVA: 0xFFFFFFFF75CA5340
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75CA5344
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF723D68C8
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75CA4FE0
	public Void set_contentType(String value) { }

	// RVA: 0xFFFFFFFF75CA53AC
	internal virtual Void SetContentType(String newContentType) { }

	// RVA: 0xFFFFFFFF75CA53FC
	private Void InternalSetContentType(String newContentType) { }

}

// Namespace: UnityEngine.Networking
public sealed class UploadHandlerRaw
{
	// Methods

	// RVA: 0xFFFFFFFF75CA54F8
	private static IntPtr Create(UploadHandlerRaw self, Byte[] data) { }

	// RVA: 0xFFFFFFFF75CA4F20
	public Void .ctor(Byte[] data) { }

}

// Namespace: UnityEngine.Networking
public sealed class UploadHandlerFile
{
	// Methods

	// RVA: 0xFFFFFFFF75CA544C
	private static IntPtr Create(UploadHandlerFile self, String filePath) { }

	// RVA: 0xFFFFFFFF75CA549C
	public Void .ctor(String filePath) { }

}


