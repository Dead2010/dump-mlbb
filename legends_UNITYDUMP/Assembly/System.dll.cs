// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class SR
{
	// Methods

	// RVA: 0xFFFFFFFF75B08854
	internal static String GetString(String name, Object[] args) { }

	// RVA: 0xFFFFFFFF75B088A4
	internal static String GetString(CultureInfo culture, String name, Object[] args) { }

	// RVA: 0xFFFFFFFF72372010
	internal static String GetString(String name) { }

	// RVA: 0xFFFFFFFF75B088AC
	internal static String Format(String resourceFormat, Object[] args) { }

	// RVA: 0xFFFFFFFF75B08910
	internal static String Format(String resourceFormat, Object p1) { }

	// RVA: 0xFFFFFFFF75B08960
	internal static String Format(String resourceFormat, Object p1, Object p2) { }

}

// Namespace: Mono.Util
internal sealed class MonoPInvokeCallbackAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75B0884C
	public Void .ctor(Type t) { }

}

// Namespace: Mono.Unity
internal static class CertHelper
{
	// Methods

	// RVA: 0xFFFFFFFF75AFCC40
	public static Void AddCertificatesToNativeChain(unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75AFCD6C
	public static Void AddCertificateToNativeChain(unitytls_x509list* nativeCertificateChain, X509Certificate certificate, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75AFD254
	public static X509CertificateCollection NativeChainToManagedCollection(unitytls_x509list_ref nativeCertificateChain, unitytls_errorstate* errorState) { }

}

// Namespace: Mono.Unity
internal static class Debug
{
	// Methods

	// RVA: 0xFFFFFFFF75AFD950
	public static Void CheckAndThrow(unitytls_errorstate errorState, String context, AlertDescription defaultAlert) { }

	// RVA: 0xFFFFFFFF75AFDA2C
	public static Void CheckAndThrow(unitytls_errorstate errorState, unitytls_x509verify_result verifyResult, String context, AlertDescription defaultAlert) { }

}

// Namespace: Mono.Unity
internal static class UnityTls
{
	// Fields
	private static unitytls_interface_struct marshalledInterface; // 0x0

	// Properties
	public static Boolean IsSupported { get; }
	public static unitytls_interface_struct NativeInterface { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AFDF34
	private static IntPtr GetUnityTlsInterface() { }

	// RVA: 0xFFFFFFFF75AFC05C
	public static Boolean get_IsSupported() { }

	// RVA: 0xFFFFFFFF75AFCF18
	public static unitytls_interface_struct get_NativeInterface() { }

}

// Namespace: 
public enum unitytls_error_code
{
	// Fields
	public UInt32 value__; // 0x10
	public const unitytls_error_code UNITYTLS_SUCCESS = 0;
	public const unitytls_error_code UNITYTLS_INVALID_ARGUMENT = 1;
	public const unitytls_error_code UNITYTLS_INVALID_FORMAT = 2;
	public const unitytls_error_code UNITYTLS_INVALID_PASSWORD = 3;
	public const unitytls_error_code UNITYTLS_INVALID_STATE = 4;
	public const unitytls_error_code UNITYTLS_BUFFER_OVERFLOW = 5;
	public const unitytls_error_code UNITYTLS_OUT_OF_MEMORY = 6;
	public const unitytls_error_code UNITYTLS_INTERNAL_ERROR = 7;
	public const unitytls_error_code UNITYTLS_NOT_SUPPORTED = 8;
	public const unitytls_error_code UNITYTLS_ENTROPY_SOURCE_FAILED = 9;
	public const unitytls_error_code UNITYTLS_STREAM_CLOSED = 10;
	public const unitytls_error_code UNITYTLS_USER_CUSTOM_ERROR_START = 1048576;
	public const unitytls_error_code UNITYTLS_USER_WOULD_BLOCK = 1048577;
	public const unitytls_error_code UNITYTLS_USER_READ_FAILED = 1048578;
	public const unitytls_error_code UNITYTLS_USER_WRITE_FAILED = 1048579;
	public const unitytls_error_code UNITYTLS_USER_UNKNOWN_ERROR = 1048580;
	public const unitytls_error_code UNITYTLS_USER_CUSTOM_ERROR_END = 2097152;
}

// Namespace: 
public struct unitytls_errorstate
{
	// Fields
	private UInt32 magic; // 0x10
	public unitytls_error_code code; // 0x14
	private UInt64 reserved; // 0x18
}

// Namespace: 
public struct unitytls_key
{}

// Namespace: 
public struct unitytls_key_ref
{
	// Fields
	public UInt64 handle; // 0x10
}

// Namespace: 
public struct unitytls_x509_ref
{
	// Fields
	public UInt64 handle; // 0x10
}

// Namespace: 
public struct unitytls_x509list
{}

// Namespace: 
public struct unitytls_x509list_ref
{
	// Fields
	public UInt64 handle; // 0x10
}

// Namespace: 
public enum unitytls_x509verify_result
{
	// Fields
	public UInt32 value__; // 0x10
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_SUCCESS = 0;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_NOT_DONE = 2147483648;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FATAL_ERROR = 4294967295;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_REVOKED = 2;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 65536;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 131072;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 262144;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 524288;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 1048576;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 2097152;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 4194304;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 8388608;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 134217728;
}

// Namespace: 
public sealed class unitytls_x509verify_callback
{
	// Methods

	// RVA: 0xFFFFFFFF75B05130
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B05174
	public virtual unitytls_x509verify_result Invoke(Void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B053F4
	public virtual IAsyncResult BeginInvoke(Void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B054DC
	public virtual unitytls_x509verify_result EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public struct unitytls_tlsctx
{}

// Namespace: 
public struct unitytls_x509name
{}

// Namespace: 
public enum unitytls_ciphersuite
{
	// Fields
	public UInt32 value__; // 0x10
	public const unitytls_ciphersuite UNITYTLS_CIPHERSUITE_INVALID = 16777215;
}

// Namespace: 
public enum unitytls_protocol
{
	// Fields
	public UInt32 value__; // 0x10
	public const unitytls_protocol UNITYTLS_PROTOCOL_TLS_1_0 = 0;
	public const unitytls_protocol UNITYTLS_PROTOCOL_TLS_1_1 = 1;
	public const unitytls_protocol UNITYTLS_PROTOCOL_TLS_1_2 = 2;
	public const unitytls_protocol UNITYTLS_PROTOCOL_INVALID = 3;
}

// Namespace: 
public struct unitytls_tlsctx_protocolrange
{
	// Fields
	public unitytls_protocol min; // 0x10
	public unitytls_protocol max; // 0x14
}

// Namespace: 
public sealed class unitytls_tlsctx_write_callback
{
	// Methods

	// RVA: 0xFFFFFFFF75B04A10
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B04A54
	public virtual IntPtr Invoke(Void* userData, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B04CD4
	public virtual IAsyncResult BeginInvoke(Void* userData, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B04D6C
	public virtual IntPtr EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_read_callback
{
	// Methods

	// RVA: 0xFFFFFFFF75B0432C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B04370
	public virtual IntPtr Invoke(Void* userData, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B045F0
	public virtual IAsyncResult BeginInvoke(Void* userData, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B04688
	public virtual IntPtr EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_trace_callback
{
	// Methods

	// RVA: 0xFFFFFFFF75B046B0
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B046F4
	public virtual Void Invoke(Void* userData, unitytls_tlsctx* ctx, Byte* traceMessage, IntPtr traceMessageLen) { }

	// RVA: 0xFFFFFFFF75B04970
	public virtual IAsyncResult BeginInvoke(Void* userData, unitytls_tlsctx* ctx, Byte* traceMessage, IntPtr traceMessageLen, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B04A04
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_certificate_callback
{
	// Methods

	// RVA: 0xFFFFFFFF75B03F1C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B03F60
	public virtual Void Invoke(Void* userData, unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B0425C
	public virtual IAsyncResult BeginInvoke(Void* userData, unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B04320
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_x509verify_callback
{
	// Methods

	// RVA: 0xFFFFFFFF75B04D94
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B04DD8
	public virtual unitytls_x509verify_result Invoke(Void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B05044
	public virtual IAsyncResult BeginInvoke(Void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B05108
	public virtual unitytls_x509verify_result EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public struct unitytls_tlsctx_callbacks
{
	// Fields
	public unitytls_tlsctx_read_callback read; // 0x10
	public unitytls_tlsctx_write_callback write; // 0x18
	public Void* data; // 0x20
}

// Namespace: 
public class unitytls_interface_struct
{
	// Fields
	public readonly UInt64 UNITYTLS_INVALID_HANDLE; // 0x10
	public readonly unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT; // 0x18
	public unitytls_errorstate_create_t unitytls_errorstate_create; // 0x20
	public unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error; // 0x28
	public unitytls_key_get_ref_t unitytls_key_get_ref; // 0x30
	public unitytls_key_parse_der_t unitytls_key_parse_der; // 0x38
	public unitytls_key_parse_pem_t unitytls_key_parse_pem; // 0x40
	public unitytls_key_free_t unitytls_key_free; // 0x48
	public unitytls_x509_export_der_t unitytls_x509_export_der; // 0x50
	public unitytls_x509list_get_ref_t unitytls_x509list_get_ref; // 0x58
	public unitytls_x509list_get_x509_t unitytls_x509list_get_x509; // 0x60
	public unitytls_x509list_create_t unitytls_x509list_create; // 0x68
	public unitytls_x509list_append_t unitytls_x509list_append; // 0x70
	public unitytls_x509list_append_der_t unitytls_x509list_append_der; // 0x78
	public unitytls_x509list_append_der_t unitytls_x509list_append_pem; // 0x80
	public unitytls_x509list_free_t unitytls_x509list_free; // 0x88
	public unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca; // 0x90
	public unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca; // 0x98
	public unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server; // 0xA0
	public unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client; // 0xA8
	public unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication; // 0xB0
	public unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback; // 0xB8
	public unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback; // 0xC0
	public unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback; // 0xC8
	public unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites; // 0xD0
	public unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite; // 0xD8
	public unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol; // 0xE0
	public unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake; // 0xE8
	public unitytls_tlsctx_read_t unitytls_tlsctx_read; // 0xF0
	public unitytls_tlsctx_write_t unitytls_tlsctx_write; // 0xF8
	public unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close; // 0x100
	public unitytls_tlsctx_free_t unitytls_tlsctx_free; // 0x108
	public unitytls_random_generate_bytes_t unitytls_random_generate_bytes; // 0x110

	// Methods

	// RVA: 0xFFFFFFFF75AFDF38
	public Void .ctor() { }

}

// Namespace: 
public sealed class unitytls_errorstate_create_t
{
	// Methods

	// RVA: 0xFFFFFFFF75AFDF3C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75AFDF80
	public virtual unitytls_errorstate Invoke() { }

	// RVA: 0xFFFFFFFF75AFE184
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75AFE1DC
	public virtual unitytls_errorstate EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_errorstate_raise_error_t
{
	// Methods

	// RVA: 0xFFFFFFFF75AFE208
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75AFE24C
	public virtual Void Invoke(unitytls_errorstate* errorState, unitytls_error_code errorCode) { }

	// RVA: 0xFFFFFFFF75AFE49C
	public virtual IAsyncResult BeginInvoke(unitytls_errorstate* errorState, unitytls_error_code errorCode, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75AFE55C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_key_get_ref_t
{
	// Methods

	// RVA: 0xFFFFFFFF75AFE844
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75AFE888
	public virtual unitytls_key_ref Invoke(unitytls_key* key, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75AFEADC
	public virtual IAsyncResult BeginInvoke(unitytls_key* key, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75AFEB38
	public virtual unitytls_key_ref EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_key_parse_der_t
{
	// Methods

	// RVA: 0xFFFFFFFF75AFEB60
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75AFEBA4
	public virtual unitytls_key* Invoke(Byte* buffer, IntPtr bufferLen, Byte* password, IntPtr passwordLen, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75AFEE48
	public virtual IAsyncResult BeginInvoke(Byte* buffer, IntPtr bufferLen, Byte* password, IntPtr passwordLen, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75AFEEFC
	public virtual unitytls_key* EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_key_parse_pem_t
{
	// Methods

	// RVA: 0xFFFFFFFF75AFEF08
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75AFEF4C
	public virtual unitytls_key* Invoke(Byte* buffer, IntPtr bufferLen, Byte* password, IntPtr passwordLen, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75AFF1F0
	public virtual IAsyncResult BeginInvoke(Byte* buffer, IntPtr bufferLen, Byte* password, IntPtr passwordLen, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75AFF2A4
	public virtual unitytls_key* EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_key_free_t
{
	// Methods

	// RVA: 0xFFFFFFFF75AFE568
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75AFE5AC
	public virtual Void Invoke(unitytls_key* key) { }

	// RVA: 0xFFFFFFFF75AFE7E8
	public virtual IAsyncResult BeginInvoke(unitytls_key* key, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75AFE838
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_x509_export_der_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B026B4
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75AFD6AC
	public virtual IntPtr Invoke(unitytls_x509_ref cert, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B026F8
	public virtual IAsyncResult BeginInvoke(unitytls_x509_ref cert, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B027CC
	public virtual IntPtr EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_x509list_get_ref_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B03214
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B03258
	public virtual unitytls_x509list_ref Invoke(unitytls_x509list* list, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B034AC
	public virtual IAsyncResult BeginInvoke(unitytls_x509list* list, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B03508
	public virtual unitytls_x509list_ref EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_x509list_get_x509_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B03530
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75AFD420
	public virtual unitytls_x509_ref Invoke(unitytls_x509list_ref list, IntPtr index, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B03574
	public virtual IAsyncResult BeginInvoke(unitytls_x509list_ref list, IntPtr index, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B03644
	public virtual unitytls_x509_ref EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_x509list_create_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B02C58
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B02C9C
	public virtual unitytls_x509list* Invoke(unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B02EDC
	public virtual IAsyncResult BeginInvoke(unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B02F2C
	public virtual unitytls_x509list* EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_x509list_append_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B028DC
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B02920
	public virtual Void Invoke(unitytls_x509list* list, unitytls_x509_ref cert, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B02B88
	public virtual IAsyncResult BeginInvoke(unitytls_x509list* list, unitytls_x509_ref cert, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B02C4C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_x509list_append_der_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B027F4
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75AFCFD8
	public virtual Void Invoke(unitytls_x509list* list, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B02838
	public virtual IAsyncResult BeginInvoke(unitytls_x509list* list, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B028D0
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_x509list_free_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B02F38
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B02F7C
	public virtual Void Invoke(unitytls_x509list* list) { }

	// RVA: 0xFFFFFFFF75B031B8
	public virtual IAsyncResult BeginInvoke(unitytls_x509list* list, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B03208
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_x509verify_default_ca_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B0366C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B036B0
	public virtual unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, Byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B0398C
	public virtual IAsyncResult BeginInvoke(unitytls_x509list_ref chain, Byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B03A74
	public virtual unitytls_x509verify_result EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_x509verify_explicit_ca_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B03A9C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B03AE0
	public virtual unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, unitytls_x509list_ref trustCA, Byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B03DFC
	public virtual IAsyncResult BeginInvoke(unitytls_x509list_ref chain, unitytls_x509list_ref trustCA, Byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B03EF4
	public virtual unitytls_x509verify_result EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_create_server_t
{
	// Methods

	// RVA: 0xFFFFFFFF75AFFB08
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75AFFB4C
	public virtual unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, UInt64 certChain, UInt64 leafCertificateKey, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75AFFF08
	public virtual IAsyncResult BeginInvoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, UInt64 certChain, UInt64 leafCertificateKey, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B00010
	public virtual unitytls_tlsctx* EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_create_client_t
{
	// Methods

	// RVA: 0xFFFFFFFF75AFF5FC
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75AFF640
	public virtual unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, Byte* cn, IntPtr cnLen, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75AFF9FC
	public virtual IAsyncResult BeginInvoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, Byte* cn, IntPtr cnLen, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75AFFAFC
	public virtual unitytls_tlsctx* EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_server_require_client_authentication_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B012CC
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B01310
	public virtual Void Invoke(unitytls_tlsctx* ctx, unitytls_x509list_ref clientAuthCAList, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B01578
	public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, unitytls_x509list_ref clientAuthCAList, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B0163C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_certificate_callback_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B01648
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B0168C
	public virtual Void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_certificate_callback cb, Void* userData, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B01908
	public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, unitytls_tlsctx_certificate_callback cb, Void* userData, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B01968
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_trace_callback_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B01CD8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B01D1C
	public virtual Void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_trace_callback cb, Void* userData, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B01F98
	public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, unitytls_tlsctx_trace_callback cb, Void* userData, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B01FF8
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_x509verify_callback_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B02004
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B02048
	public virtual Void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B022C4
	public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, unitytls_tlsctx_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B02324
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_supported_ciphersuites_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B01974
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B019B8
	public virtual Void Invoke(unitytls_tlsctx* ctx, unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B01C34
	public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B01CCC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_get_ciphersuite_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B002F8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B0033C
	public virtual unitytls_ciphersuite Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B00590
	public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B005EC
	public virtual unitytls_ciphersuite EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_get_protocol_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B00614
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B00658
	public virtual unitytls_protocol Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B008AC
	public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B00908
	public virtual unitytls_protocol EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_process_handshake_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B00C2C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B00C70
	public virtual unitytls_x509verify_result Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B00EC4
	public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B00F20
	public virtual unitytls_x509verify_result EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_read_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B00F48
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B00F8C
	public virtual IntPtr Invoke(unitytls_tlsctx* ctx, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B0120C
	public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B012A4
	public virtual IntPtr EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_write_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B02330
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B02374
	public virtual IntPtr Invoke(unitytls_tlsctx* ctx, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B025F4
	public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B0268C
	public virtual IntPtr EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_notify_close_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B00930
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B00974
	public virtual Void Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B00BC4
	public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B00C20
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_free_t
{
	// Methods

	// RVA: 0xFFFFFFFF75B0001C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B00060
	public virtual Void Invoke(unitytls_tlsctx* ctx) { }

	// RVA: 0xFFFFFFFF75B0029C
	public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B002EC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class unitytls_random_generate_bytes_t
{
	// Methods

	// RVA: 0xFFFFFFFF75AFF2B0
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75AFF2F4
	public virtual Void Invoke(Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75AFF55C
	public virtual IAsyncResult BeginInvoke(Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75AFF5F0
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Mono.Unity
internal class UnityTlsContext
{
	// Fields
	private unitytls_tlsctx* tlsContext; // 0x58
	private unitytls_x509list* requestedClientCertChain; // 0x60
	private unitytls_key* requestedClientKey; // 0x68
	private unitytls_tlsctx_read_callback readCallback; // 0x70
	private unitytls_tlsctx_write_callback writeCallback; // 0x78
	private unitytls_tlsctx_certificate_callback certificateCallback; // 0x80
	private unitytls_tlsctx_x509verify_callback verifyCallback; // 0x88
	private X509Certificate localClientCertificate; // 0x90
	private X509Certificate remoteCertificate; // 0x98
	private MonoTlsConnectionInfo connectioninfo; // 0xA0
	private Boolean isAuthenticated; // 0xA8
	private Boolean hasContext; // 0xA9
	private Boolean closedGraceful; // 0xAA
	private Byte[] writeBuffer; // 0xB0
	private Byte[] readBuffer; // 0xB8
	private GCHandle handle; // 0xC0
	private Exception lastException; // 0xC8

	// Properties
	public override Boolean IsAuthenticated { get; }
	internal override X509Certificate LocalClientCertificate { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B0582C
	public Void .ctor(MobileAuthenticatedStream parent, Boolean serverMode, String targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, Boolean askForClientCert) { }

	// RVA: 0xFFFFFFFF75B061F4
	private static Void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, unitytls_errorstate* errorState, out unitytls_x509list* nativeCertChain, out unitytls_key* nativeKey) { }

	// RVA: 0xFFFFFFFF75B064F4
	public override Boolean get_IsAuthenticated() { }

	// RVA: 0xFFFFFFFF75B064FC
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0xFFFFFFFF75B06504
	public override ValueTuple<T0, T1> Read(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF75B066B8
	public override ValueTuple<T0, T1> Write(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF75B06858
	public override Void Shutdown() { }

	// RVA: 0xFFFFFFFF75B06914
	protected override Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75B06A38
	public override Void StartHandshake() { }

	// RVA: 0xFFFFFFFF75B06B80
	public override Boolean ProcessHandshake() { }

	// RVA: 0xFFFFFFFF75B06CF4
	public override Void FinishHandshake() { }

	// RVA: 0xFFFFFFFF75B05504
	private static IntPtr WriteCallback(Void* userData, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B06E34
	private IntPtr WriteCallback(Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B055D4
	private static IntPtr ReadCallback(Void* userData, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B07130
	private IntPtr ReadCallback(Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B056A4
	private static unitytls_x509verify_result VerifyCallback(Void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B076B0
	private unitytls_x509verify_result VerifyCallback(unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B05764
	private static Void CertificateCallback(Void* userData, unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

	// RVA: 0xFFFFFFFF75B07820
	private Void CertificateCallback(unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

}

// Namespace: Mono.Unity
internal static class UnityTlsConversions
{
	// Methods

	// RVA: 0xFFFFFFFF75B05FAC
	public static unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	// RVA: 0xFFFFFFFF75B060D0
	public static unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	// RVA: 0xFFFFFFFF75B06E14
	public static TlsProtocols ConvertProtocolVersion(unitytls_protocol protocol) { }

	// RVA: 0xFFFFFFFF75AFDB64
	public static AlertDescription VerifyResultToAlertDescription(unitytls_x509verify_result verifyResult, AlertDescription defaultAlert) { }

	// RVA: 0xFFFFFFFF75B07FC8
	public static MonoSslPolicyErrors VerifyResultToPolicyErrror(unitytls_x509verify_result verifyResult) { }

}

// Namespace: Mono.Unity
internal class UnityTlsProvider
{
	// Properties
	public override String Name { get; }
	public override Guid ID { get; }
	public override Boolean SupportsSslStream { get; }
	public override Boolean SupportsMonoExtensions { get; }
	public override Boolean SupportsConnectionInfo { get; }
	internal override Boolean SupportsCleanShutdown { get; }
	public override SslProtocols SupportedProtocols { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B08088
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF75B080C8
	public override Guid get_ID() { }

	// RVA: 0xFFFFFFFF75B08128
	public override Boolean get_SupportsSslStream() { }

	// RVA: 0xFFFFFFFF75B08130
	public override Boolean get_SupportsMonoExtensions() { }

	// RVA: 0xFFFFFFFF75B08138
	public override Boolean get_SupportsConnectionInfo() { }

	// RVA: 0xFFFFFFFF75B08140
	internal override Boolean get_SupportsCleanShutdown() { }

	// RVA: 0xFFFFFFFF75B08148
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0xFFFFFFFF75B08150
	public override IMonoSslStream CreateSslStream(Stream innerStream, Boolean leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0xFFFFFFFF75B08168
	internal override IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, Boolean leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0xFFFFFFFF75B0828C
	internal override Boolean ValidateCertificate(ICertificateValidator2 validator, String targetHost, Boolean serverMode, X509CertificateCollection certificates, Boolean wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref Int32 status11) { }

	// RVA: 0xFFFFFFFF75B0879C
	public Void .ctor() { }

}

// Namespace: Mono.Unity
internal class UnityTlsStream
{
	// Methods

	// RVA: 0xFFFFFFFF75B081F0
	public Void .ctor(Stream innerStream, Boolean leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MonoTlsProvider provider) { }

	// RVA: 0xFFFFFFFF75B087A4
	protected override MobileTlsContext CreateContext(Boolean serverMode, String targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, Boolean askForClientCert) { }

}

// Namespace: Mono.Net
internal class CFObject
{
	// Fields
	private IntPtr <Handle>k__BackingField; // 0x10

	// Properties
	public IntPtr Handle { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75AF0B20
	public static extern IntPtr dlopen(String path, Int32 mode) { }

	// RVA: 0xFFFFFFFF75AF33B0
	private static extern IntPtr dlsym(IntPtr handle, String symbol) { }

	// RVA: 0xFFFFFFFF75AF0BCC
	public static extern Void dlclose(IntPtr handle) { }

	// RVA: 0xFFFFFFFF75AF0BC8
	public static IntPtr GetIndirect(IntPtr handle, String symbol) { }

	// RVA: 0xFFFFFFFF75AF345C
	public static IntPtr GetCFObjectHandle(IntPtr handle, String symbol) { }

	// RVA: 0xFFFFFFFF75AF0A48
	public Void .ctor(IntPtr handle, Boolean own) { }

	// RVA: 0xFFFFFFFF75AF34B8
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75AF3530
	public IntPtr get_Handle() { }

	// RVA: 0xFFFFFFFF75AF3538
	private Void set_Handle(IntPtr value) { }

	// RVA: 0xFFFFFFFF75AF3540
	internal static extern IntPtr CFRetain(IntPtr handle) { }

	// RVA: 0xFFFFFFFF75AF34B0
	private Void Retain() { }

	// RVA: 0xFFFFFFFF75AF35BC
	internal static extern Void CFRelease(IntPtr handle) { }

	// RVA: 0xFFFFFFFF75AF363C
	private Void Release() { }

	// RVA: 0xFFFFFFFF75AF3644
	protected virtual Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75AF1BE4
	public Void Dispose() { }

}

// Namespace: Mono.Net
internal class CFArray
{
	// Fields
	private static readonly IntPtr kCFTypeArrayCallbacks; // 0x0

	// Properties
	public Int32 Count { get; }
	public IntPtr Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AF0A34
	public Void .ctor(IntPtr handle, Boolean own) { }

	// RVA: 0xFFFFFFFF75AF0A5C
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75AF0C4C
	private static extern IntPtr CFArrayGetCount(IntPtr handle) { }

	// RVA: 0xFFFFFFFF75AF0CCC
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75AF0D34
	private static extern IntPtr CFArrayGetValueAtIndex(IntPtr handle, IntPtr index) { }

	// RVA: 0xFFFFFFFF75AF0DC4
	public IntPtr get_Item(Int32 index) { }

}

// Namespace: Mono.Net
internal class CFNumber
{
	// Methods

	// RVA: 0xFFFFFFFF75AF32BC
	private static extern Boolean CFNumberGetValue(IntPtr handle, IntPtr type, out Int32 value) { }

	// RVA: 0xFFFFFFFF75AF335C
	public static Int32 AsInt32(IntPtr handle) { }

}

// Namespace: Mono.Net
internal struct CFRange
{
	// Fields
	public IntPtr Location; // 0x10
	public IntPtr Length; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF71146180
	public Void .ctor(Int32 loc, Int32 len) { }

}

// Namespace: Mono.Net
internal struct CFStreamClientContext
{
	// Fields
	public IntPtr Version; // 0x10
	public IntPtr Info; // 0x18
	public IntPtr Retain; // 0x20
	public IntPtr Release; // 0x28
	public IntPtr CopyDescription; // 0x30
}

// Namespace: Mono.Net
internal class CFString
{
	// Fields
	private String str; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75AF3F58
	public Void .ctor(IntPtr handle, Boolean own) { }

	// RVA: 0xFFFFFFFF75AF3F6C
	private static extern IntPtr CFStringCreateWithCharacters(IntPtr alloc, IntPtr chars, IntPtr length) { }

	// RVA: 0xFFFFFFFF75AF207C
	public static CFString Create(String value) { }

	// RVA: 0xFFFFFFFF75AF4004
	private static extern IntPtr CFStringGetLength(IntPtr handle) { }

	// RVA: 0xFFFFFFFF75AF4084
	private static extern IntPtr CFStringGetCharactersPtr(IntPtr handle) { }

	// RVA: 0xFFFFFFFF75AF4104
	private static extern IntPtr CFStringGetCharacters(IntPtr handle, CFRange range, IntPtr buffer) { }

	// RVA: 0xFFFFFFFF75AF39BC
	public static String AsString(IntPtr handle) { }

	// RVA: 0xFFFFFFFF75AF41AC
	public override String ToString() { }

}

// Namespace: Mono.Net
internal class CFDictionary
{
	// Fields
	private static readonly IntPtr KeyCallbacks; // 0x0
	private static readonly IntPtr ValueCallbacks; // 0x8

	// Properties
	public IntPtr Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AF0E44
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75AF0F34
	public Void .ctor(IntPtr handle, Boolean own) { }

	// RVA: 0xFFFFFFFF75AF0F48
	private static extern IntPtr CFDictionaryGetValue(IntPtr handle, IntPtr key) { }

	// RVA: 0xFFFFFFFF75AF0FD8
	public IntPtr GetValue(IntPtr key) { }

	// RVA: 0xFFFFFFFF75AF1048
	public IntPtr get_Item(IntPtr key) { }

}

// Namespace: Mono.Net
internal class CFUrl
{
	// Methods

	// RVA: 0xFFFFFFFF75AF41FC
	public Void .ctor(IntPtr handle, Boolean own) { }

	// RVA: 0xFFFFFFFF75AF4210
	private static extern IntPtr CFURLCreateWithString(IntPtr allocator, IntPtr str, IntPtr baseURL) { }

	// RVA: 0xFFFFFFFF75AF1D5C
	public static CFUrl Create(String absolute) { }

}

// Namespace: Mono.Net
internal class CFRunLoop
{
	// Properties
	public static CFRunLoop CurrentRunLoop { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AF3C84
	private static extern Void CFRunLoopAddSource(IntPtr rl, IntPtr source, IntPtr mode) { }

	// RVA: 0xFFFFFFFF75AF3D1C
	private static extern Void CFRunLoopRemoveSource(IntPtr rl, IntPtr source, IntPtr mode) { }

	// RVA: 0xFFFFFFFF75AF3DB4
	private static extern Int32 CFRunLoopRunInMode(IntPtr mode, Double seconds, Boolean returnAfterSourceHandled) { }

	// RVA: 0xFFFFFFFF75AF3E54
	private static extern IntPtr CFRunLoopGetCurrent() { }

	// RVA: 0xFFFFFFFF75AF3EC4
	private static extern Void CFRunLoopStop(IntPtr rl) { }

	// RVA: 0xFFFFFFFF75AF3F44
	public Void .ctor(IntPtr handle, Boolean own) { }

	// RVA: 0xFFFFFFFF75AF1FD8
	public static CFRunLoop get_CurrentRunLoop() { }

	// RVA: 0xFFFFFFFF75AF2114
	public Void AddSource(IntPtr source, CFString mode) { }

	// RVA: 0xFFFFFFFF75AF2154
	public Void RemoveSource(IntPtr source, CFString mode) { }

	// RVA: 0xFFFFFFFF75AF2134
	public Int32 RunInMode(CFString mode, Double seconds, Boolean returnAfterSourceHandled) { }

	// RVA: 0xFFFFFFFF75AF2834
	public Void Stop() { }

}

// Namespace: Mono.Net
internal enum CFProxyType
{
	// Fields
	public Int32 value__; // 0x10
	public const CFProxyType None = 0;
	public const CFProxyType AutoConfigurationUrl = 1;
	public const CFProxyType AutoConfigurationJavaScript = 2;
	public const CFProxyType FTP = 3;
	public const CFProxyType HTTP = 4;
	public const CFProxyType HTTPS = 5;
	public const CFProxyType SOCKS = 6;
}

// Namespace: Mono.Net
internal class CFProxy
{
	// Fields
	private static IntPtr kCFProxyAutoConfigurationJavaScriptKey; // 0x0
	private static IntPtr kCFProxyAutoConfigurationURLKey; // 0x8
	private static IntPtr kCFProxyHostNameKey; // 0x10
	private static IntPtr kCFProxyPasswordKey; // 0x18
	private static IntPtr kCFProxyPortNumberKey; // 0x20
	private static IntPtr kCFProxyTypeKey; // 0x28
	private static IntPtr kCFProxyUsernameKey; // 0x30
	private static IntPtr kCFProxyTypeAutoConfigurationURL; // 0x38
	private static IntPtr kCFProxyTypeAutoConfigurationJavaScript; // 0x40
	private static IntPtr kCFProxyTypeFTP; // 0x48
	private static IntPtr kCFProxyTypeHTTP; // 0x50
	private static IntPtr kCFProxyTypeHTTPS; // 0x58
	private static IntPtr kCFProxyTypeSOCKS; // 0x60
	private CFDictionary settings; // 0x10

	// Properties
	public IntPtr AutoConfigurationJavaScript { get; }
	public IntPtr AutoConfigurationUrl { get; }
	public String HostName { get; }
	public String Password { get; }
	public Int32 Port { get; }
	public CFProxyType ProxyType { get; }
	public String Username { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AF3684
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75AF1BAC
	internal Void .ctor(CFDictionary settings) { }

	// RVA: 0xFFFFFFFF75AF38E8
	private static CFProxyType CFProxyTypeToEnum(IntPtr type) { }

	// RVA: 0xFFFFFFFF75AF318C
	public IntPtr get_AutoConfigurationJavaScript() { }

	// RVA: 0xFFFFFFFF75AF3210
	public IntPtr get_AutoConfigurationUrl() { }

	// RVA: 0xFFFFFFFF75AF2ED4
	public String get_HostName() { }

	// RVA: 0xFFFFFFFF75AF2E4C
	public String get_Password() { }

	// RVA: 0xFFFFFFFF75AF2F5C
	public Int32 get_Port() { }

	// RVA: 0xFFFFFFFF75AF2D3C
	public CFProxyType get_ProxyType() { }

	// RVA: 0xFFFFFFFF75AF2DC4
	public String get_Username() { }

}

// Namespace: Mono.Net
internal class CFProxySettings
{
	// Fields
	private static IntPtr kCFNetworkProxiesHTTPEnable; // 0x0
	private static IntPtr kCFNetworkProxiesHTTPPort; // 0x8
	private static IntPtr kCFNetworkProxiesHTTPProxy; // 0x10
	private static IntPtr kCFNetworkProxiesProxyAutoConfigEnable; // 0x18
	private static IntPtr kCFNetworkProxiesProxyAutoConfigJavaScript; // 0x20
	private static IntPtr kCFNetworkProxiesProxyAutoConfigURLString; // 0x28
	private CFDictionary settings; // 0x10

	// Properties
	public CFDictionary Dictionary { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AF3AF0
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75AF25A0
	public Void .ctor(CFDictionary settings) { }

	// RVA: 0xFFFFFFFF75AF3C3C
	public CFDictionary get_Dictionary() { }

}

// Namespace: Mono.Net
internal static class CFNetwork
{
	// Fields
	private static Object lock_obj; // 0x0
	private static Queue<T0> get_proxy_queue; // 0x8
	private static AutoResetEvent proxy_event; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75AF104C
	private static extern IntPtr CFNetworkCopyProxiesForAutoConfigurationScriptSequential(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0xFFFFFFFF75AF10E4
	private static extern IntPtr CFNetworkExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, IntPtr targetURL, CFProxyAutoConfigurationResultCallback cb, ref CFStreamClientContext clientContext) { }

	// RVA: 0xFFFFFFFF75AF1194
	private static Void CFNetworkCopyProxiesForAutoConfigurationScriptThread() { }

	// RVA: 0xFFFFFFFF75AF1574
	private static IntPtr CFNetworkCopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0xFFFFFFFF75AF1910
	private static CFArray CopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0xFFFFFFFF75AF19B0
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0xFFFFFFFF75AF1C38
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, Uri targetUri) { }

	// RVA: 0xFFFFFFFF75AF1E00
	public static CFProxy[] ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetURL) { }

	// RVA: 0xFFFFFFFF75AF2174
	private static extern IntPtr CFNetworkCopyProxiesForURL(IntPtr url, IntPtr proxySettings) { }

	// RVA: 0xFFFFFFFF75AF2204
	private static CFArray CopyProxiesForURL(CFUrl url, CFDictionary proxySettings) { }

	// RVA: 0xFFFFFFFF75AF22A0
	public static CFProxy[] GetProxiesForURL(CFUrl url, CFProxySettings proxySettings) { }

	// RVA: 0xFFFFFFFF75AF24A8
	public static CFProxy[] GetProxiesForUri(Uri uri, CFProxySettings proxySettings) { }

	// RVA: 0xFFFFFFFF72371B90
	private static extern IntPtr CFNetworkCopySystemProxySettings() { }

	// RVA: 0xFFFFFFFF72371A7C
	public static CFProxySettings GetSystemProxySettings() { }

	// RVA: 0xFFFFFFFF75AF25D8
	public static IWebProxy GetDefaultProxy() { }

	// RVA: 0xFFFFFFFF75AF261C
	private static Void .cctor() { }

}

// Namespace: 
private class GetProxyData
{
	// Fields
	public IntPtr script; // 0x10
	public IntPtr targetUri; // 0x18
	public IntPtr error; // 0x20
	public IntPtr result; // 0x28
	public ManualResetEvent evt; // 0x30

	// Methods

	// RVA: 0xFFFFFFFF75AF3294
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75AF18BC
	public Void .ctor() { }

}

// Namespace: 
private sealed class CFProxyAutoConfigurationResultCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75AF2038
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75AF283C
	public virtual Void Invoke(IntPtr client, IntPtr proxyList, IntPtr error) { }

	// RVA: 0xFFFFFFFF75AF2ABC
	public virtual IAsyncResult BeginInvoke(IntPtr client, IntPtr proxyList, IntPtr error, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75AF2B70
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private class CFWebProxy
{
	// Fields
	private ICredentials credentials; // 0x10
	private Boolean userSpecified; // 0x18

	// Properties
	public ICredentials Credentials { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AF2618
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AF2B7C
	public ICredentials get_Credentials() { }

	// RVA: 0xFFFFFFFF75AF2B84
	private static Uri GetProxyUri(CFProxy proxy, out NetworkCredential credentials) { }

	// RVA: 0xFFFFFFFF75AF2FE4
	private static Uri GetProxyUriFromScript(IntPtr script, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0xFFFFFFFF75AF3130
	private static Uri ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0xFFFFFFFF75AF3040
	private static Uri SelectProxy(CFProxy[] proxies, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0xFFFFFFFF72371C00
	public Uri GetProxy(Uri targetUri) { }

	// RVA: 0xFFFFFFFF72371F1C
	public Boolean IsBypassed(Uri targetUri) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0
{
	// Fields
	public CFProxy[] proxies; // 0x10
	public CFRunLoop runLoop; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75AF1FD4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AF2668
	internal Void <ExecuteProxyAutoConfigurationURL>b__0(IntPtr client, IntPtr proxyList, IntPtr error) { }

}

// Namespace: Mono.Net.Security
internal class BufferOffsetSize
{
	// Fields
	public Byte[] Buffer; // 0x10
	public Int32 Offset; // 0x18
	public Int32 Size; // 0x1C
	public Int32 TotalBytes; // 0x20
	public Boolean Complete; // 0x24

	// Properties
	public Int32 EndOffset { get; }
	public Int32 Remaining { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AF636C
	public Int32 get_EndOffset() { }

	// RVA: 0xFFFFFFFF75AF6378
	public Int32 get_Remaining() { }

	// RVA: 0xFFFFFFFF75AF5F00
	public Void .ctor(Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75AF63A4
	public override String ToString() { }

}

// Namespace: Mono.Net.Security
internal class BufferOffsetSize2
{
	// Fields
	public readonly Int32 InitialSize; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75AF6438
	public Void .ctor(Int32 size) { }

	// RVA: 0xFFFFFFFF75AF647C
	public Void Reset() { }

	// RVA: 0xFFFFFFFF75AF64F4
	public Void MakeRoom(Int32 size) { }

	// RVA: 0xFFFFFFFF75AF6590
	public Void AppendData(Byte[] buffer, Int32 offset, Int32 size) { }

}

// Namespace: Mono.Net.Security
internal enum AsyncOperationStatus
{
	// Fields
	public Int32 value__; // 0x10
	public const AsyncOperationStatus Initialize = 0;
	public const AsyncOperationStatus Continue = 1;
	public const AsyncOperationStatus ReadDone = 2;
	public const AsyncOperationStatus Complete = 3;
}

// Namespace: Mono.Net.Security
internal class AsyncProtocolResult
{
	// Fields
	private readonly Int32 <UserResult>k__BackingField; // 0x10
	private readonly ExceptionDispatchInfo <Error>k__BackingField; // 0x18

	// Properties
	public Int32 UserResult { get; }
	public ExceptionDispatchInfo Error { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AF5E18
	public Int32 get_UserResult() { }

	// RVA: 0xFFFFFFFF75AF5E20
	public ExceptionDispatchInfo get_Error() { }

	// RVA: 0xFFFFFFFF75AF5C18
	public Void .ctor(Int32 result) { }

	// RVA: 0xFFFFFFFF75AF5D88
	public Void .ctor(ExceptionDispatchInfo error) { }

}

// Namespace: Mono.Net.Security
internal abstract class AsyncProtocolRequest
{
	// Fields
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x10
	private readonly Boolean <RunSynchronously>k__BackingField; // 0x18
	private Int32 <UserResult>k__BackingField; // 0x1C
	private Int32 Started; // 0x20
	private Int32 RequestedSize; // 0x24
	private Int32 WriteRequested; // 0x28
	private readonly Object locker; // 0x30

	// Properties
	public MobileAuthenticatedStream Parent { get; }
	public Boolean RunSynchronously { get; }
	public String Name { get; }
	public Int32 UserResult { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75AF4514
	public MobileAuthenticatedStream get_Parent() { }

	// RVA: 0xFFFFFFFF75AF451C
	public Boolean get_RunSynchronously() { }

	// RVA: 0xFFFFFFFF75AF4524
	public String get_Name() { }

	// RVA: 0xFFFFFFFF75AF4550
	public Int32 get_UserResult() { }

	// RVA: 0xFFFFFFFF75AF4558
	protected Void set_UserResult(Int32 value) { }

	// RVA: 0xFFFFFFFF75AF42AC
	public Void .ctor(MobileAuthenticatedStream parent, Boolean sync) { }

	// RVA: 0xFFFFFFFF75AF4560
	internal Void RequestRead(Int32 size) { }

	// RVA: 0xFFFFFFFF75AF45F8
	internal Void RequestWrite() { }

	// RVA: 0xFFFFFFFF75AF4604
	internal Task<T0> StartOperation(CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75AF475C
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75AF48AC
	private Task<T0> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status) { }

	// RVA: 0xFFFFFFFF75AF4A10
	public override String ToString() { }

}

// Namespace: 
private struct <StartOperation>d__23
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder<T0> <>t__builder; // 0x18
	public AsyncProtocolRequest <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0xFFFFFFFF71146234
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF7114623C
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <ProcessOperation>d__24
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public CancellationToken cancellationToken; // 0x30
	public AsyncProtocolRequest <>4__this; // 0x38
	private AsyncOperationStatus <status>5__1; // 0x40
	private AsyncOperationStatus <newStatus>5__2; // 0x44
	private ConfiguredTaskAwaiter <>u__1; // 0x48
	private ConfiguredTaskAwaiter <>u__2; // 0x58

	// Methods

	// RVA: 0xFFFFFFFF71146220
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF71146228
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <InnerRead>d__25
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder<T0> <>t__builder; // 0x18
	public AsyncProtocolRequest <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private Int32 <requestedSize>5__1; // 0x40
	private Nullable<T0> <totalRead>5__2; // 0x44
	private ConfiguredTaskAwaiter <>u__1; // 0x50

	// Methods

	// RVA: 0xFFFFFFFF711461C0
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF711461C8
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Mono.Net.Security
internal class AsyncHandshakeRequest
{
	// Methods

	// RVA: 0xFFFFFFFF75AF42A8
	public Void .ctor(MobileAuthenticatedStream parent, Boolean sync) { }

	// RVA: 0xFFFFFFFF75AF4320
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

// Namespace: Mono.Net.Security
internal abstract class AsyncReadOrWriteRequest
{
	// Fields
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; // 0x38
	private Int32 <CurrentSize>k__BackingField; // 0x40

	// Properties
	protected BufferOffsetSize UserBuffer { get; }
	protected Int32 CurrentSize { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75AF5E28
	protected BufferOffsetSize get_UserBuffer() { }

	// RVA: 0xFFFFFFFF75AF5E30
	protected Int32 get_CurrentSize() { }

	// RVA: 0xFFFFFFFF75AF5E38
	protected Void set_CurrentSize(Int32 value) { }

	// RVA: 0xFFFFFFFF75AF5E40
	public Void .ctor(MobileAuthenticatedStream parent, Boolean sync, Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75AF6008
	public override String ToString() { }

}

// Namespace: Mono.Net.Security
internal class AsyncReadRequest
{
	// Methods

	// RVA: 0xFFFFFFFF75AF607C
	public Void .ctor(MobileAuthenticatedStream parent, Boolean sync, Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75AF6080
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

// Namespace: Mono.Net.Security
internal class AsyncWriteRequest
{
	// Methods

	// RVA: 0xFFFFFFFF75AF61F0
	public Void .ctor(MobileAuthenticatedStream parent, Boolean sync, Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75AF61F4
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

// Namespace: Mono.Net.Security
internal sealed class ServerCertValidationCallbackWrapper
{
	// Methods

	// RVA: 0xFFFFFFFF75AFC984
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75AF7528
	public virtual Boolean Invoke(ServerCertValidationCallback callback, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

	// RVA: 0xFFFFFFFF75AFC9C8
	public virtual IAsyncResult BeginInvoke(ServerCertValidationCallback callback, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors, AsyncCallback __callback, Object object) { }

	// RVA: 0xFFFFFFFF75AFCA9C
	public virtual Boolean EndInvoke(IAsyncResult result) { }

}

// Namespace: Mono.Net.Security
internal class ChainValidationHelper
{
	// Fields
	private readonly Object sender; // 0x10
	private readonly MonoTlsSettings settings; // 0x18
	private readonly MonoTlsProvider provider; // 0x20
	private readonly ServerCertValidationCallback certValidationCallback; // 0x28
	private readonly LocalCertSelectionCallback certSelectionCallback; // 0x30
	private readonly ServerCertValidationCallbackWrapper callbackWrapper; // 0x38
	private readonly MonoTlsStream tlsStream; // 0x40
	private readonly HttpWebRequest request; // 0x48

	// Properties
	public MonoTlsSettings Settings { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AF65F4
	internal static ICertificateValidator GetInternalValidator(MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0xFFFFFFFF75AF69CC
	internal static ChainValidationHelper Create(MonoTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream) { }

	// RVA: 0xFFFFFFFF75AF6694
	private Void .ctor(MonoTlsProvider provider, MonoTlsSettings settings, Boolean cloneSettings, MonoTlsStream stream, ServerCertValidationCallbackWrapper callbackWrapper) { }

	// RVA: 0xFFFFFFFF75AF6C84
	private static X509Certificate DefaultSelectionCallback(String targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

	// RVA: 0xFFFFFFFF75AF6CD0
	public MonoTlsSettings get_Settings() { }

	// RVA: 0xFFFFFFFF75AF6CD8
	public Boolean SelectClientCertificate(String targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers, out X509Certificate clientCertificate) { }

	// RVA: 0xFFFFFFFF75AF6D30
	public ValidationResult ValidateCertificate(String host, Boolean serverMode, X509CertificateCollection certs) { }

	// RVA: 0xFFFFFFFF75AF6F24
	public ValidationResult ValidateCertificate(String host, Boolean serverMode, X509Certificate leaf, X509Chain chain) { }

	// RVA: 0xFFFFFFFF75AF6E8C
	private ValidationResult ValidateChain(String host, Boolean server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0xFFFFFFFF75AF70C4
	private ValidationResult ValidateChain(String host, Boolean server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

}

// Namespace: Mono.Net.Security
internal abstract class MobileAuthenticatedStream
{
	// Fields
	private MobileTlsContext xobileTlsContext; // 0x38
	private ExceptionDispatchInfo lastException; // 0x40
	private AsyncProtocolRequest asyncHandshakeRequest; // 0x48
	private AsyncProtocolRequest asyncReadRequest; // 0x50
	private AsyncProtocolRequest asyncWriteRequest; // 0x58
	private BufferOffsetSize2 readBuffer; // 0x60
	private BufferOffsetSize2 writeBuffer; // 0x68
	private Object ioLock; // 0x70
	private Int32 closeRequested; // 0x78
	private Boolean shutdown; // 0x7C
	private static Int32 uniqueNameInteger; // 0x0
	private readonly SslStream <SslStream>k__BackingField; // 0x80
	private readonly MonoTlsSettings <Settings>k__BackingField; // 0x88
	private readonly MonoTlsProvider <Provider>k__BackingField; // 0x90
	private static Int32 nextId; // 0x4
	internal readonly Int32 ID; // 0x98

	// Properties
	public MonoTlsSettings Settings { get; }
	public MonoTlsProvider Provider { get; }
	public AuthenticatedStream AuthenticatedStream { get; }
	public override Boolean IsAuthenticated { get; }
	public X509Certificate InternalLocalCertificate { get; }
	public override Boolean CanRead { get; }
	public override Boolean CanWrite { get; }
	public override Boolean CanSeek { get; }
	public override Int64 Length { get; }
	public override Int64 Position { get; set; }
	public override Int32 ReadTimeout { get; set; }
	public override Int32 WriteTimeout { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AF7940
	public Void .ctor(Stream innerStream, Boolean leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MonoTlsProvider provider) { }

	// RVA: 0xFFFFFFFF75AF7B2C
	public MonoTlsSettings get_Settings() { }

	// RVA: 0xFFFFFFFF75AF7B34
	public MonoTlsProvider get_Provider() { }

	// RVA: 0xFFFFFFFF75AF7B3C
	internal Void CheckThrow(Boolean authSuccessCheck, Boolean shutdownCheck) { }

	// RVA: 0xFFFFFFFF75AF5C20
	internal static Exception GetSSPIException(Exception e) { }

	// RVA: 0xFFFFFFFF75AF7C24
	internal static Exception GetIOException(Exception e, String message) { }

	// RVA: 0xFFFFFFFF75AF5D44
	internal ExceptionDispatchInfo SetException(Exception e) { }

	// RVA: 0xFFFFFFFF75AF7D44
	public Void AuthenticateAsClient(String targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, Boolean checkCertificateRevocation) { }

	// RVA: 0xFFFFFFFF75AF7F4C
	public Task AuthenticateAsClientAsync(String targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, Boolean checkCertificateRevocation) { }

	// RVA: 0xFFFFFFFF75AF7F84
	public AuthenticatedStream get_AuthenticatedStream() { }

	// RVA: 0xFFFFFFFF75AF7D88
	private Task ProcessAuthentication(Boolean runSynchronously, Boolean serverMode, String targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, Boolean clientCertRequired) { }

	// RVA: -1
	protected abstract MobileTlsContext CreateContext(Boolean serverMode, String targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, Boolean askForClientCert) { }

	// RVA: 0xFFFFFFFF75AF7F88
	public override IAsyncResult BeginRead(Byte[] buffer, Int32 offset, Int32 count, AsyncCallback asyncCallback, Object asyncState) { }

	// RVA: 0xFFFFFFFF75AF81FC
	public override Int32 EndRead(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75AF8244
	public override IAsyncResult BeginWrite(Byte[] buffer, Int32 offset, Int32 count, AsyncCallback asyncCallback, Object asyncState) { }

	// RVA: 0xFFFFFFFF75AF8324
	public override Void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75AF8330
	public override Int32 Read(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF75AF8410
	public override Void Write(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF75AF84E0
	public override Task<T0> ReadAsync(Byte[] buffer, Int32 offset, Int32 count, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75AF8574
	public override Task WriteAsync(Byte[] buffer, Int32 offset, Int32 count, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75AF8068
	private Task<T0> StartOperation(OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75AF8608
	internal Int32 InternalRead(Byte[] buffer, Int32 offset, Int32 size, out Boolean outWantMore) { }

	// RVA: 0xFFFFFFFF75AF8758
	private ValueTuple<T0, T1> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75AF88C0
	internal Boolean InternalWrite(Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75AF8A00
	private Boolean InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75AF4F0C
	internal Task<T0> InnerRead(Boolean sync, Int32 requestedSize, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75AF572C
	internal Task InnerWrite(Boolean sync, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75AF433C
	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status) { }

	// RVA: 0xFFFFFFFF75AF60FC
	internal ValueTuple<T0, T1> ProcessRead(BufferOffsetSize userBuffer) { }

	// RVA: 0xFFFFFFFF75AF6278
	internal ValueTuple<T0, T1> ProcessWrite(BufferOffsetSize userBuffer) { }

	// RVA: 0xFFFFFFFF75AF8B70
	public override Boolean get_IsAuthenticated() { }

	// RVA: 0xFFFFFFFF75AF8C30
	protected override Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75AF8DFC
	public override Void Flush() { }

	// RVA: 0xFFFFFFFF75AF8E24
	public X509Certificate get_InternalLocalCertificate() { }

	// RVA: 0xFFFFFFFF75AF8F00
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xFFFFFFFF75AF8F54
	public override Void SetLength(Int64 value) { }

	// RVA: 0xFFFFFFFF75AF8F7C
	public override Boolean get_CanRead() { }

	// RVA: 0xFFFFFFFF75AF8FD0
	public override Boolean get_CanWrite() { }

	// RVA: 0xFFFFFFFF75AF903C
	public override Boolean get_CanSeek() { }

	// RVA: 0xFFFFFFFF75AF9044
	public override Int64 get_Length() { }

	// RVA: 0xFFFFFFFF75AF906C
	public override Int64 get_Position() { }

	// RVA: 0xFFFFFFFF75AF9094
	public override Void set_Position(Int64 value) { }

	// RVA: 0xFFFFFFFF75AF90E8
	public override Int32 get_ReadTimeout() { }

	// RVA: 0xFFFFFFFF75AF9110
	public override Void set_ReadTimeout(Int32 value) { }

	// RVA: 0xFFFFFFFF75AF9138
	public override Int32 get_WriteTimeout() { }

	// RVA: 0xFFFFFFFF75AF9160
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75AF91AC
	private Void <InnerWrite>b__67_0() { }

}

// Namespace: 
private enum OperationType
{
	// Fields
	public Int32 value__; // 0x10
	public const OperationType Read = 0;
	public const OperationType Write = 1;
	public const OperationType Shutdown = 2;
}

// Namespace: 
private struct <ProcessAuthentication>d__47
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public Boolean serverMode; // 0x30
	public X509Certificate serverCertificate; // 0x38
	public String targetHost; // 0x40
	public MobileAuthenticatedStream <>4__this; // 0x48
	public Boolean runSynchronously; // 0x50
	public SslProtocols enabledProtocols; // 0x54
	public X509CertificateCollection clientCertificates; // 0x58
	public Boolean clientCertRequired; // 0x60
	private ConfiguredTaskAwaiter <>u__1; // 0x68

	// Methods

	// RVA: 0xFFFFFFFF71146308
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF71146310
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <StartOperation>d__58
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder<T0> <>t__builder; // 0x18
	public MobileAuthenticatedStream <>4__this; // 0x30
	public OperationType type; // 0x38
	public AsyncProtocolRequest asyncRequest; // 0x40
	public CancellationToken cancellationToken; // 0x48
	private ConfiguredTaskAwaiter <>u__1; // 0x50

	// Methods

	// RVA: 0xFFFFFFFF7114631C
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF71146324
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private sealed class <>c__DisplayClass66_0
{
	// Fields
	public MobileAuthenticatedStream <>4__this; // 0x10
	public Int32 len; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75AF91E4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AF91E8
	internal Int32 <InnerRead>b__0() { }

}

// Namespace: 
private struct <InnerRead>d__66
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder<T0> <>t__builder; // 0x18
	public MobileAuthenticatedStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	public Int32 requestedSize; // 0x40
	public Boolean sync; // 0x44
	private ConfiguredTaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0xFFFFFFFF71146294
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF7114629C
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <InnerWrite>d__67
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public CancellationToken cancellationToken; // 0x30
	public MobileAuthenticatedStream <>4__this; // 0x38
	public Boolean sync; // 0x40
	private ConfiguredTaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0xFFFFFFFF711462F4
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF711462FC
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Mono.Net.Security
internal abstract class MobileTlsContext
{
	// Fields
	private MobileAuthenticatedStream parent; // 0x10
	private Boolean serverMode; // 0x18
	private String targetHost; // 0x20
	private String serverName; // 0x28
	private SslProtocols enabledProtocols; // 0x30
	private X509Certificate serverCertificate; // 0x38
	private X509CertificateCollection clientCertificates; // 0x40
	private Boolean askForClientCert; // 0x48
	private ICertificateValidator2 certificateValidator; // 0x50

	// Properties
	internal MobileAuthenticatedStream Parent { get; }
	public MonoTlsSettings Settings { get; }
	public abstract Boolean IsAuthenticated { get; }
	public Boolean IsServer { get; }
	protected String TargetHost { get; }
	protected String ServerName { get; }
	protected X509CertificateCollection ClientCertificates { get; }
	internal X509Certificate LocalServerCertificate { get; }
	internal abstract X509Certificate LocalClientCertificate { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AFAD6C
	public Void .ctor(MobileAuthenticatedStream parent, Boolean serverMode, String targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, Boolean askForClientCert) { }

	// RVA: 0xFFFFFFFF75AFAF38
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0xFFFFFFFF75AFAF40
	public MonoTlsSettings get_Settings() { }

	// RVA: -1
	public abstract Boolean get_IsAuthenticated() { }

	// RVA: 0xFFFFFFFF75AFAF60
	public Boolean get_IsServer() { }

	// RVA: 0xFFFFFFFF75AFAF68
	protected String get_TargetHost() { }

	// RVA: 0xFFFFFFFF75AFAF70
	protected String get_ServerName() { }

	// RVA: 0xFFFFFFFF75AFAF78
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: -1
	public abstract Void StartHandshake() { }

	// RVA: -1
	public abstract Boolean ProcessHandshake() { }

	// RVA: -1
	public abstract Void FinishHandshake() { }

	// RVA: 0xFFFFFFFF75AFAF80
	internal X509Certificate get_LocalServerCertificate() { }

	// RVA: -1
	internal abstract X509Certificate get_LocalClientCertificate() { }

	// RVA: -1
	public abstract ValueTuple<T0, T1> Read(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: -1
	public abstract ValueTuple<T0, T1> Write(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: -1
	public abstract Void Shutdown() { }

	// RVA: 0xFFFFFFFF75AFAF88
	protected Boolean ValidateCertificate(X509Certificate leaf, X509Chain chain) { }

	// RVA: 0xFFFFFFFF75AFB084
	protected Boolean ValidateCertificate(X509CertificateCollection certificates) { }

	// RVA: 0xFFFFFFFF75AFB174
	protected X509Certificate SelectClientCertificate(X509Certificate serverCertificate, String[] acceptableIssuers) { }

	// RVA: 0xFFFFFFFF75AF8DA8
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75AFB2E0
	protected virtual Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75AFB2E4
	protected override Void Finalize() { }

}

// Namespace: Mono.Net.Security
internal static class MonoTlsProviderFactory
{
	// Fields
	private static Object locker; // 0x0
	private static Boolean initialized; // 0x8
	private static MonoTlsProvider defaultProvider; // 0x10
	private static Dictionary<T0, T1> providerRegistration; // 0x18
	private static Dictionary<T0, T1> providerCache; // 0x20
	internal static readonly Guid UnityTlsId; // 0x28
	internal static readonly Guid AppleTlsId; // 0x38
	internal static readonly Guid BtlsId; // 0x48
	internal static readonly Guid LegacyId; // 0x58

	// Methods

	// RVA: 0xFFFFFFFF75AFB35C
	internal static MonoTlsProvider GetProviderInternal() { }

	// RVA: 0xFFFFFFFF75AFB43C
	internal static Void InitializeInternal() { }

	// RVA: 0xFFFFFFFF75AFBB5C
	private static MonoTlsProvider LookupProvider(String name, Boolean throwOnError) { }

	// RVA: 0xFFFFFFFF75AFB734
	private static Void InitializeProviderRegistration() { }

	// RVA: 0xFFFFFFFF75AFBAC0
	private static MonoTlsProvider CreateDefaultProviderImpl() { }

	// RVA: 0xFFFFFFFF75AF6A6C
	internal static MonoTlsProvider GetProvider() { }

	// RVA: 0xFFFFFFFF75AFC078
	private static Void .cctor() { }

}

// Namespace: Mono.Net.Security
internal class MonoTlsStream
{
	// Fields
	private readonly MonoTlsProvider provider; // 0x10
	private readonly NetworkStream networkStream; // 0x18
	private readonly HttpWebRequest request; // 0x20
	private readonly MonoTlsSettings settings; // 0x28
	private IMonoSslStream sslStream; // 0x30
	private WebExceptionStatus status; // 0x38
	private Boolean <CertificateValidationFailed>k__BackingField; // 0x3C

	// Properties
	internal HttpWebRequest Request { get; }
	internal WebExceptionStatus ExceptionStatus { get; }
	internal Boolean CertificateValidationFailed { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75AFC1B8
	internal HttpWebRequest get_Request() { }

	// RVA: 0xFFFFFFFF75AFC1C0
	internal WebExceptionStatus get_ExceptionStatus() { }

	// RVA: 0xFFFFFFFF75AFC1C8
	internal Boolean get_CertificateValidationFailed() { }

	// RVA: 0xFFFFFFFF75AFC1D0
	internal Void set_CertificateValidationFailed(Boolean value) { }

	// RVA: 0xFFFFFFFF75AFC1D8
	public Void .ctor(HttpWebRequest request, NetworkStream networkStream) { }

	// RVA: 0xFFFFFFFF75AFC2DC
	internal Stream CreateStream(Byte[] buffer) { }

}

// Namespace: Mono.Net.Security
internal static class NoReflectionHelper
{
	// Methods

	// RVA: 0xFFFFFFFF75AFC82C
	internal static Object GetInternalValidator(Object provider, Object settings) { }

	// RVA: 0xFFFFFFFF75AFC8E4
	internal static Object GetProvider() { }

}

// Namespace: Mono.Net.Security
internal static class SystemCertificateValidator
{
	// Fields
	private static Boolean is_macosx; // 0x0
	private static X509KeyUsageFlags s_flags; // 0x4

	// Methods

	// RVA: 0xFFFFFFFF75AFCAC4
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75AFCB5C
	public static X509Chain CreateX509Chain(X509CertificateCollection certs) { }

	// RVA: 0xFFFFFFFF75AF7938
	internal static Boolean NeedsChain(MonoTlsSettings settings) { }

}

// Namespace: Mono.Net.Security.Private
internal static class CallbackHelpers
{
	// Methods

	// RVA: 0xFFFFFFFF75AF6B10
	internal static RemoteCertificateValidationCallback MonoToPublic(MonoRemoteCertificateValidationCallback callback) { }

	// RVA: 0xFFFFFFFF75AF6BC4
	internal static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public MonoRemoteCertificateValidationCallback callback; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75AFC938
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AFC940
	internal Boolean <MonoToPublic>b__0(Object t, X509Certificate c, X509Chain ch, SslPolicyErrors e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public MonoLocalCertificateSelectionCallback callback; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75AFC93C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AFC964
	internal X509Certificate <MonoToInternal>b__0(String t, X509CertificateCollection lc, X509Certificate rc, String[] ai) { }

}

// Namespace: Mono.Http
internal class NtlmSession
{
	// Fields
	private MessageBase message; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75AF0A30
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AF0480
	public Authorization Authenticate(String challenge, WebRequest webRequest, ICredentials credentials) { }

}

// Namespace: Mono.Http
internal class NtlmClient
{
	// Fields
	private static readonly ConditionalWeakTable<T0, T1> cache; // 0x0

	// Properties
	public String AuthenticationType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AF0188
	public Authorization Authenticate(String challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xFFFFFFFF75AF08D8
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xFFFFFFFF75AF08E0
	public String get_AuthenticationType() { }

	// RVA: 0xFFFFFFFF75AF08EC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AF08F0
	private static Void .cctor() { }

}

// Namespace: 
private sealed class <>c
{
	// Fields
	public static readonly <>c <>9; // 0x0
	public static CreateValueCallback <>9__1_0; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75AF0984
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75AF09EC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AF09F0
	internal NtlmSession <Authenticate>b__1_0(HttpWebRequest x) { }

}

// Namespace: Microsoft.Win32
internal static class NativeMethods
{
	// Methods

	// RVA: 0xFFFFFFFF75AEFCF0
	public static Boolean DuplicateHandle(HandleRef hSourceProcessHandle, SafeHandle hSourceHandle, HandleRef hTargetProcess, out SafeWaitHandle targetHandle, Int32 dwDesiredAccess, Boolean bInheritHandle, Int32 dwOptions) { }

	// RVA: 0xFFFFFFFF75AEFEA0
	public static Boolean DuplicateHandle(HandleRef hSourceProcessHandle, HandleRef hSourceHandle, HandleRef hTargetProcess, out SafeProcessHandle targetHandle, Int32 dwDesiredAccess, Boolean bInheritHandle, Int32 dwOptions) { }

	// RVA: 0xFFFFFFFF75AEFFFC
	public static IntPtr GetCurrentProcess() { }

	// RVA: 0xFFFFFFFF75AF0000
	public static Boolean GetExitCodeProcess(IntPtr processHandle, out Int32 exitCode) { }

	// RVA: 0xFFFFFFFF75AF0004
	public static Boolean GetExitCodeProcess(SafeProcessHandle processHandle, out Int32 exitCode) { }

	// RVA: 0xFFFFFFFF75AF00CC
	public static Int32 GetCurrentProcessId() { }

	// RVA: 0xFFFFFFFF75AF00D0
	public static Boolean CloseProcess(IntPtr handle) { }

}

// Namespace: Microsoft.Win32.SafeHandles
public sealed class SafeProcessHandle
{
	// Fields
	internal static SafeProcessHandle InvalidHandle; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75AF00D4
	internal Void .ctor(IntPtr handle) { }

	// RVA: 0xFFFFFFFF75AEFFCC
	public Void .ctor(IntPtr existingHandle, Boolean ownsHandle) { }

	// RVA: 0xFFFFFFFF75AF0104
	protected override Boolean ReleaseHandle() { }

	// RVA: 0xFFFFFFFF75AF010C
	private static Void .cctor() { }

}

// Namespace: System
internal static class StringExtensions
{
	// Methods

	// RVA: 0xFFFFFFFF75B923DC
	internal static String SubstringTrim(String value, Int32 startIndex) { }

	// RVA: 0xFFFFFFFF75B92294
	internal static String SubstringTrim(String value, Int32 startIndex, Int32 length) { }

}

// Namespace: System
public class UriBuilder
{
	// Fields
	private Boolean _changed; // 0x10
	private String _fragment; // 0x18
	private String _host; // 0x20
	private String _password; // 0x28
	private String _path; // 0x30
	private Int32 _port; // 0x38
	private String _query; // 0x40
	private String _scheme; // 0x48
	private String _schemeDelimiter; // 0x50
	private Uri _uri; // 0x58
	private String _username; // 0x60

	// Properties
	public String Host { set; }
	public String Path { set; }
	public String Query { set; }
	public String Scheme { set; }
	public Uri Uri { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BB990C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BB9A98
	public Void .ctor(Uri uri) { }

	// RVA: 0xFFFFFFFF75BB9C8C
	private Void Init(Uri uri) { }

	// RVA: 0xFFFFFFFF75BBA0C0
	public Void set_Host(String value) { }

	// RVA: 0xFFFFFFFF75BBA180
	public Void set_Path(String value) { }

	// RVA: 0xFFFFFFFF75BBA214
	public Void set_Query(String value) { }

	// RVA: 0xFFFFFFFF75BBA2B8
	public Void set_Scheme(String value) { }

	// RVA: 0xFFFFFFFF75BBA3FC
	public Uri get_Uri() { }

	// RVA: 0xFFFFFFFF75BBA490
	public override Boolean Equals(Object rparam) { }

	// RVA: 0xFFFFFFFF75BBA4F8
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75BB9EB0
	private Void SetFieldsFromUri(Uri uri) { }

	// RVA: 0xFFFFFFFF75BBA520
	public override String ToString() { }

}

// Namespace: System
internal static class SecurityUtils
{
	// Methods

	// RVA: 0xFFFFFFFF75BA5478
	private static Void DemandReflectionAccess(Type type) { }

	// RVA: 0xFFFFFFFF75BA547C
	private static Boolean HasReflectionPermission(Type type) { }

	// RVA: 0xFFFFFFFF75BA5484
	internal static Object SecureCreateInstance(Type type) { }

	// RVA: 0xFFFFFFFF75BA5490
	internal static Object SecureCreateInstance(Type type, Object[] args, Boolean allowNonPublic) { }

	// RVA: 0xFFFFFFFF75BA557C
	internal static Object SecureCreateInstance(Type type, Object[] args) { }

	// RVA: 0xFFFFFFFF75BA5584
	internal static Object SecureConstructorInvoke(Type type, Type[] argTypes, Object[] args, Boolean allowNonPublic) { }

	// RVA: 0xFFFFFFFF75BA558C
	internal static Object SecureConstructorInvoke(Type type, Type[] argTypes, Object[] args, Boolean allowNonPublic, BindingFlags extraFlags) { }

}

// Namespace: System
internal class InvariantComparer
{
	// Fields
	private CompareInfo m_compareInfo; // 0x10
	internal static readonly InvariantComparer Default; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75B413AC
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75B41420
	public Int32 Compare(Object a, Object b) { }

	// RVA: 0xFFFFFFFF75B414DC
	private static Void .cctor() { }

}

// Namespace: System
internal static class IriHelper
{
	// Methods

	// RVA: 0xFFFFFFFF75B4155C
	internal static Boolean CheckIriUnicodeRange(Char unicode, Boolean isQuery) { }

	// RVA: 0xFFFFFFFF75B415A4
	internal static Boolean CheckIriUnicodeRange(Char highSurr, Char lowSurr, ref Boolean surrogatePair, Boolean isQuery) { }

	// RVA: 0xFFFFFFFF75B41B18
	internal static Boolean CheckIsReserved(Char ch, UriComponents component) { }

	// RVA: 0xFFFFFFFF75B41C40
	internal static String EscapeUnescapeIri(Char* pInput, Int32 start, Int32 end, UriComponents component) { }

}

// Namespace: System
public class Uri
{
	// Fields
	public static readonly String UriSchemeFile; // 0x0
	public static readonly String UriSchemeFtp; // 0x8
	public static readonly String UriSchemeGopher; // 0x10
	public static readonly String UriSchemeHttp; // 0x18
	public static readonly String UriSchemeHttps; // 0x20
	internal static readonly String UriSchemeWs; // 0x28
	internal static readonly String UriSchemeWss; // 0x30
	public static readonly String UriSchemeMailto; // 0x38
	public static readonly String UriSchemeNews; // 0x40
	public static readonly String UriSchemeNntp; // 0x48
	public static readonly String UriSchemeNetTcp; // 0x50
	public static readonly String UriSchemeNetPipe; // 0x58
	public static readonly String SchemeDelimiter; // 0x60
	private const Int32 c_Max16BitUtf8SequenceLength = 12;
	internal const Int32 c_MaxUriBufferSize = 65520;
	private const Int32 c_MaxUriSchemeName = 1024;
	private String m_String; // 0x10
	private String m_originalUnicodeString; // 0x18
	private UriParser m_Syntax; // 0x20
	private String m_DnsSafeHost; // 0x28
	private Flags m_Flags; // 0x30
	private UriInfo m_Info; // 0x38
	private Boolean m_iriParsing; // 0x40
	private static Boolean s_ConfigInitialized; // 0x68
	private static Boolean s_ConfigInitializing; // 0x69
	private static UriIdnScope s_IdnScope; // 0x6C
	private static Boolean s_IriParsing; // 0x70
	private static Boolean useDotNetRelativeOrAbsolute; // 0x71
	private const UriKind DotNetRelativeOrAbsolute = 300;
	internal static readonly Boolean IsWindowsFileSystem; // 0x72
	private static Object s_initLock; // 0x78
	private const UriFormat V1ToStringUnescape = 32767;
	internal const Char c_DummyChar = 65535;
	internal const Char c_EOL = 65534;
	internal static readonly Char[] HexLowerChars; // 0x80
	private static readonly Char[] _WSchars; // 0x88

	// Properties
	private Boolean IsImplicitFile { get; }
	private Boolean IsUncOrDosPath { get; }
	private Boolean IsDosPath { get; }
	private Boolean IsUncPath { get; }
	private Flags HostType { get; }
	private UriParser Syntax { get; }
	private Boolean IsNotAbsoluteUri { get; }
	private Boolean AllowIdn { get; }
	internal Boolean UserDrivenParsing { get; }
	private UInt16 SecuredPathIndex { get; }
	public String AbsolutePath { get; }
	private String PrivateAbsolutePath { get; }
	public String AbsoluteUri { get; }
	public String LocalPath { get; }
	public String Authority { get; }
	public UriHostNameType HostNameType { get; }
	public Boolean IsDefaultPort { get; }
	public Boolean IsFile { get; }
	public Boolean IsLoopback { get; }
	public String PathAndQuery { get; }
	public Boolean IsUnc { get; }
	public String Host { get; }
	private static Object InitializeLock { get; }
	public Int32 Port { get; }
	public String Query { get; }
	public String Fragment { get; }
	public String Scheme { get; }
	private Boolean OriginalStringSwitched { get; }
	public String OriginalString { get; }
	public String DnsSafeHost { get; }
	public String IdnHost { get; }
	public Boolean IsAbsoluteUri { get; }
	public Boolean UserEscaped { get; }
	public String UserInfo { get; }
	internal Boolean HasAuthority { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BB5B08
	private Boolean get_IsImplicitFile() { }

	// RVA: 0xFFFFFFFF75BB5B14
	private Boolean get_IsUncOrDosPath() { }

	// RVA: 0xFFFFFFFF75BB5B24
	private Boolean get_IsDosPath() { }

	// RVA: 0xFFFFFFFF75BB5B30
	private Boolean get_IsUncPath() { }

	// RVA: 0xFFFFFFFF75BB5B3C
	private Flags get_HostType() { }

	// RVA: 0xFFFFFFFF75BB5B48
	private UriParser get_Syntax() { }

	// RVA: 0xFFFFFFFF75BB5B50
	private Boolean get_IsNotAbsoluteUri() { }

	// RVA: 0xFFFFFFFF7239D318
	internal static Boolean IriParsingStatic(UriParser syntax) { }

	// RVA: 0xFFFFFFFF7239D3C0
	private Boolean get_AllowIdn() { }

	// RVA: 0xFFFFFFFF7239D464
	private Boolean AllowIdnStatic(UriParser syntax, Flags flags) { }

	// RVA: 0xFFFFFFFF75BB5B7C
	private Boolean IsIntranet(String schemeHost) { }

	// RVA: 0xFFFFFFFF75BB5B84
	internal Boolean get_UserDrivenParsing() { }

	// RVA: 0xFFFFFFFF75BB5B90
	private Void SetUserDrivenParsing() { }

	// RVA: 0xFFFFFFFF75BB5BA4
	private UInt16 get_SecuredPathIndex() { }

	// RVA: 0xFFFFFFFF75BB5B60
	private Boolean NotAny(Flags flags) { }

	// RVA: 0xFFFFFFFF75BB5BFC
	private Boolean InFact(Flags flags) { }

	// RVA: 0xFFFFFFFF75BB5B70
	private static Boolean StaticNotAny(Flags allFlags, Flags checkFlags) { }

	// RVA: 0xFFFFFFFF75BB5C0C
	private static Boolean StaticInFact(Flags allFlags, Flags checkFlags) { }

	// RVA: 0xFFFFFFFF75BB5C18
	private UriInfo EnsureUriInfo() { }

	// RVA: 0xFFFFFFFF75BB5C48
	private Void EnsureParseRemaining() { }

	// RVA: 0xFFFFFFFF7239E82C
	private Void EnsureHostString(Boolean allowDnsOptimization) { }

	// RVA: 0xFFFFFFFF7239ECD8
	public Void .ctor(String uriString) { }

	// RVA: 0xFFFFFFFF75BB5C58
	public Void .ctor(String uriString, UriKind uriKind) { }

	// RVA: 0xFFFFFFFF75BB5CE8
	public Void .ctor(Uri baseUri, String relativeUri) { }

	// RVA: 0xFFFFFFFF7239EF18
	private Void CreateUri(Uri baseUri, String relativeUri, Boolean dontEscape) { }

	// RVA: 0xFFFFFFFF7239F938
	public Void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0xFFFFFFFF75BB5F68
	private static ParsingError GetCombinedString(Uri baseUri, String relativeStr, Boolean dontEscape, ref String result) { }

	// RVA: 0xFFFFFFFF75BB61AC
	private static UriFormatException GetException(ParsingError err) { }

	// RVA: 0xFFFFFFFF75BB6328
	protected Void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75BB641C
	private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75BB6420
	protected Void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75BB64F8
	public String get_AbsolutePath() { }

	// RVA: 0xFFFFFFFF75BB65A0
	private String get_PrivateAbsolutePath() { }

	// RVA: 0xFFFFFFFF75BB6654
	public String get_AbsoluteUri() { }

	// RVA: 0xFFFFFFFF75BB6740
	public String get_LocalPath() { }

	// RVA: 0xFFFFFFFF723A0BB4
	public String get_Authority() { }

	// RVA: 0xFFFFFFFF723A0C40
	public UriHostNameType get_HostNameType() { }

	// RVA: 0xFFFFFFFF75BB6DDC
	public Boolean get_IsDefaultPort() { }

	// RVA: 0xFFFFFFFF723A0D24
	public Boolean get_IsFile() { }

	// RVA: 0xFFFFFFFF75BB6E88
	public Boolean get_IsLoopback() { }

	// RVA: 0xFFFFFFFF75BB6EF0
	public String get_PathAndQuery() { }

	// RVA: 0xFFFFFFFF75BB6F9C
	public Boolean get_IsUnc() { }

	// RVA: 0xFFFFFFFF75BB701C
	public String get_Host() { }

	// RVA: 0xFFFFFFFF75BB7078
	private static Boolean StaticIsFile(UriParser syntax) { }

	// RVA: 0xFFFFFFFF75BB70A0
	private static Object get_InitializeLock() { }

	// RVA: 0xFFFFFFFF75BB711C
	private static Void InitializeUriConfig() { }

	// RVA: 0xFFFFFFFF75BB67C0
	private String GetLocalPath() { }

	// RVA: 0xFFFFFFFF75BB72FC
	public Int32 get_Port() { }

	// RVA: 0xFFFFFFFF75BB73AC
	public String get_Query() { }

	// RVA: 0xFFFFFFFF75BB74BC
	public String get_Fragment() { }

	// RVA: 0xFFFFFFFF723A1234
	public String get_Scheme() { }

	// RVA: 0xFFFFFFFF75BB75CC
	private Boolean get_OriginalStringSwitched() { }

	// RVA: 0xFFFFFFFF7239FD94
	public String get_OriginalString() { }

	// RVA: 0xFFFFFFFF75BB7620
	public String get_DnsSafeHost() { }

	// RVA: 0xFFFFFFFF75BB783C
	public String get_IdnHost() { }

	// RVA: 0xFFFFFFFF75BB5DB0
	public Boolean get_IsAbsoluteUri() { }

	// RVA: 0xFFFFFFFF75BB787C
	public Boolean get_UserEscaped() { }

	// RVA: 0xFFFFFFFF75BB7888
	public String get_UserInfo() { }

	// RVA: 0xFFFFFFFF75BB790C
	public String GetLeftPart(UriPartial part) { }

	// RVA: 0xFFFFFFFF75BB7A68
	internal static Boolean IsGenDelim(Char ch) { }

	// RVA: 0xFFFFFFFF75BB7A8C
	public static Boolean CheckSchemeName(String schemeName) { }

	// RVA: 0xFFFFFFFF723A128C
	public static Boolean IsHexDigit(Char character) { }

	// RVA: 0xFFFFFFFF723A12B8
	public static Int32 FromHex(Char digit) { }

	// RVA: 0xFFFFFFFF75BB7C34
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75BB7DF0
	public override String ToString() { }

	// RVA: 0xFFFFFFFF723A1570
	public static Boolean op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0xFFFFFFFF7239F8EC
	public static Boolean op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0xFFFFFFFF723A15AC
	public override Boolean Equals(Object comparand) { }

	// RVA: 0xFFFFFFFF75BB7F84
	private static Boolean CheckForColonInFirstPathSegment(String uriString) { }

	// RVA: 0xFFFFFFFF75BB8020
	internal static String InternalEscapeString(String rawString) { }

	// RVA: 0xFFFFFFFF723A1CAC
	private static ParsingError ParseScheme(String uriString, ref Flags flags, ref UriParser syntax) { }

	// RVA: 0xFFFFFFFF75BB80D4
	internal UriFormatException ParseMinimal() { }

	// RVA: 0xFFFFFFFF723A2298
	private ParsingError PrivateParseMinimal() { }

	// RVA: 0xFFFFFFFF723A3764
	private Void PrivateParseMinimalIri(String newHost, UInt16 idx) { }

	// RVA: 0xFFFFFFFF7239D504
	private Void CreateUriInfo(Flags cF) { }

	// RVA: 0xFFFFFFFF7239E890
	private Void CreateHostString() { }

	// RVA: 0xFFFFFFFF723A3E4C
	private static String CreateHostStringHelper(String str, UInt16 idx, UInt16 end, ref Flags flags, ref String scopeId) { }

	// RVA: 0xFFFFFFFF723A3934
	private Void GetHostViaCustomSyntax() { }

	// RVA: 0xFFFFFFFF75BB64F4
	internal String GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0xFFFFFFFF723A4604
	private String GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0xFFFFFFFF75BB7228
	private String GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0xFFFFFFFF723A4CC8
	private String ReCreateParts(UriComponents parts, UInt16 nonCanonical, UriFormat formatAs) { }

	// RVA: 0xFFFFFFFF723A46DC
	private String GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0xFFFFFFFF7239DAE8
	private Void ParseRemaining() { }

	// RVA: 0xFFFFFFFF723A1D68
	private static UInt16 ParseSchemeCheckImplicitFile(Char* uriString, UInt16 length, ref ParsingError err, ref Flags flags, ref UriParser syntax) { }

	// RVA: 0xFFFFFFFF75BB8174
	private static Boolean CheckKnownSchemes(Int64* lptr, UInt16 nChars, ref UriParser syntax) { }

	// RVA: 0xFFFFFFFF7239FC50
	private static ParsingError CheckSchemeSyntax(Char* ptr, UInt16 length, ref UriParser syntax) { }

	// RVA: 0xFFFFFFFF723A288C
	private UInt16 CheckAuthorityHelper(Char* pString, UInt16 idx, UInt16 length, ref ParsingError err, ref Flags flags, UriParser syntax, ref String newHost) { }

	// RVA: 0xFFFFFFFF723A6384
	private Void CheckAuthorityHelperHandleDnsIri(Char* pString, UInt16 start, Int32 end, Int32 startInput, Boolean iriParsing, Boolean hasUnicode, UriParser syntax, String userInfoString, ref Flags flags, ref Boolean justNormalized, ref String newHost, ref ParsingError err) { }

	// RVA: 0xFFFFFFFF75BB86B8
	private Void CheckAuthorityHelperHandleAnyHostIri(Char* pString, Int32 startInput, Int32 end, Boolean iriParsing, Boolean hasUnicode, UriParser syntax, ref Flags flags, ref String newHost, ref ParsingError err) { }

	// RVA: 0xFFFFFFFF723A62A8
	private Void FindEndOfComponent(String input, ref UInt16 idx, UInt16 end, Char delim) { }

	// RVA: 0xFFFFFFFF723A67BC
	private Void FindEndOfComponent(Char* str, ref UInt16 idx, UInt16 end, Char delim) { }

	// RVA: 0xFFFFFFFF723A3FBC
	private Check CheckCanonical(Char* str, ref UInt16 idx, UInt16 end, Char delim) { }

	// RVA: 0xFFFFFFFF723A5B7C
	private Char[] GetCanonicalPath(Char[] dest, ref Int32 pos, UriFormat formatAs) { }

	// RVA: 0xFFFFFFFF75BB8AE8
	private static Void UnescapeOnly(Char* pch, Int32 start, ref Int32 end, Char ch1, Char ch2, Char ch3) { }

	// RVA: 0xFFFFFFFF723A0DB0
	private static Char[] Compress(Char[] dest, UInt16 start, ref Int32 destLength, UriParser syntax) { }

	// RVA: 0xFFFFFFFF75BB7D78
	internal static Int32 CalculateCaseInsensitiveHashCode(String text) { }

	// RVA: 0xFFFFFFFF7239FE64
	private static String CombineUri(Uri basePart, String relativePart, UriFormat uriFormat) { }

	// RVA: 0xFFFFFFFF75BB8CB8
	internal Boolean get_HasAuthority() { }

	// RVA: 0xFFFFFFFF75BB8138
	private static Boolean IsLWS(Char ch) { }

	// RVA: 0xFFFFFFFF75BB7BD0
	private static Boolean IsAsciiLetter(Char character) { }

	// RVA: 0xFFFFFFFF75BB7BE4
	internal static Boolean IsAsciiLetterOrDigit(Char character) { }

	// RVA: 0xFFFFFFFF75BB8CC4
	internal static Boolean IsBidiControlCharacter(Char ch) { }

	// RVA: 0xFFFFFFFF75BB89B4
	internal static String StripBidiControlCharacter(Char* strToClean, Int32 start, Int32 length) { }

	// RVA: 0xFFFFFFFF7239ED24
	private Void CreateThis(String uri, Boolean dontEscape, UriKind uriKind) { }

	// RVA: 0xFFFFFFFF723A688C
	private Void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	// RVA: 0xFFFFFFFF723A6F84
	private Boolean CheckForConfigLoad(String data) { }

	// RVA: 0xFFFFFFFF723A704C
	private Boolean CheckForUnicode(String data) { }

	// RVA: 0xFFFFFFFF723A716C
	private Boolean CheckForEscapedUnreserved(String data) { }

	// RVA: 0xFFFFFFFF75BB7EC8
	public static Boolean TryCreate(String uriString, UriKind uriKind, out Uri result) { }

	// RVA: 0xFFFFFFFF75BB8F80
	public static Boolean TryCreate(Uri baseUri, String relativeUri, out Uri result) { }

	// RVA: 0xFFFFFFFF723A7384
	public static Boolean TryCreate(Uri baseUri, Uri relativeUri, out Uri result) { }

	// RVA: 0xFFFFFFFF723A449C
	public String GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0xFFFFFFFF723A7578
	public Boolean IsWellFormedOriginalString() { }

	// RVA: 0xFFFFFFFF723A7AFC
	public static Boolean IsWellFormedUriString(String uriString, UriKind uriKind) { }

	// RVA: 0xFFFFFFFF723A75A4
	internal Boolean InternalIsWellFormedOriginalString() { }

	// RVA: 0xFFFFFFFF723A7BA4
	public static String UnescapeDataString(String stringToUnescape) { }

	// RVA: 0xFFFFFFFF75BB925C
	public static String EscapeUriString(String stringToEscape) { }

	// RVA: 0xFFFFFFFF75BB9370
	public static String EscapeDataString(String stringToEscape) { }

	// RVA: 0xFFFFFFFF75BB8154
	internal String EscapeUnescapeIri(String input, Int32 start, Int32 end, UriComponents component) { }

	// RVA: 0xFFFFFFFF75BB9484
	private Void .ctor(Flags flags, UriParser uriParser, String uri) { }

	// RVA: 0xFFFFFFFF75BB8CE8
	internal static Uri CreateHelper(String uriString, Boolean dontEscape, UriKind uriKind, ref UriFormatException e) { }

	// RVA: 0xFFFFFFFF7239F150
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref String newUriString, ref Boolean userEscaped, out UriFormatException e) { }

	// RVA: 0xFFFFFFFF75BB9048
	private String GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0xFFFFFFFF723A1374
	internal String GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0xFFFFFFFF75BB5DC0
	private Void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0xFFFFFFFF75BB94EC
	private static Void .cctor() { }

}

// Namespace: 
private enum Flags
{
	// Fields
	public UInt64 value__; // 0x10
	public const Flags Zero = 0;
	public const Flags SchemeNotCanonical = 1;
	public const Flags UserNotCanonical = 2;
	public const Flags HostNotCanonical = 4;
	public const Flags PortNotCanonical = 8;
	public const Flags PathNotCanonical = 16;
	public const Flags QueryNotCanonical = 32;
	public const Flags FragmentNotCanonical = 64;
	public const Flags CannotDisplayCanonical = 127;
	public const Flags E_UserNotCanonical = 128;
	public const Flags E_HostNotCanonical = 256;
	public const Flags E_PortNotCanonical = 512;
	public const Flags E_PathNotCanonical = 1024;
	public const Flags E_QueryNotCanonical = 2048;
	public const Flags E_FragmentNotCanonical = 4096;
	public const Flags E_CannotDisplayCanonical = 8064;
	public const Flags ShouldBeCompressed = 8192;
	public const Flags FirstSlashAbsent = 16384;
	public const Flags BackslashInPath = 32768;
	public const Flags IndexMask = 65535;
	public const Flags HostTypeMask = 458752;
	public const Flags HostNotParsed = 0;
	public const Flags IPv6HostType = 65536;
	public const Flags IPv4HostType = 131072;
	public const Flags DnsHostType = 196608;
	public const Flags UncHostType = 262144;
	public const Flags BasicHostType = 327680;
	public const Flags UnusedHostType = 393216;
	public const Flags UnknownHostType = 458752;
	public const Flags UserEscaped = 524288;
	public const Flags AuthorityFound = 1048576;
	public const Flags HasUserInfo = 2097152;
	public const Flags LoopbackHost = 4194304;
	public const Flags NotDefaultPort = 8388608;
	public const Flags UserDrivenParsing = 16777216;
	public const Flags CanonicalDnsHost = 33554432;
	public const Flags ErrorOrParsingRecursion = 67108864;
	public const Flags DosPath = 134217728;
	public const Flags UncPath = 268435456;
	public const Flags ImplicitFile = 536870912;
	public const Flags MinimalUriInfoSet = 1073741824;
	public const Flags AllUriInfoSet = 2147483648;
	public const Flags IdnHost = 4294967296;
	public const Flags HasUnicode = 8589934592;
	public const Flags HostUnicodeNormalized = 17179869184;
	public const Flags RestUnicodeNormalized = 34359738368;
	public const Flags UnicodeHost = 68719476736;
	public const Flags IntranetUri = 137438953472;
	public const Flags UseOrigUncdStrOffset = 274877906944;
	public const Flags UserIriCanonical = 549755813888;
	public const Flags PathIriCanonical = 1099511627776;
	public const Flags QueryIriCanonical = 2199023255552;
	public const Flags FragmentIriCanonical = 4398046511104;
	public const Flags IriCanonical = 8246337208320;
	public const Flags CompressedSlashes = 17592186044416;
}

// Namespace: 
private class UriInfo
{
	// Fields
	public String Host; // 0x10
	public String ScopeId; // 0x18
	public String String; // 0x20
	public Offset Offset; // 0x28
	public String DnsSafeHost; // 0x38
	public MoreInfo MoreInfo; // 0x40

	// Methods

	// RVA: 0xFFFFFFFF75BB9908
	public Void .ctor() { }

}

// Namespace: 
private struct Offset
{
	// Fields
	public UInt16 Scheme; // 0x10
	public UInt16 User; // 0x12
	public UInt16 Host; // 0x14
	public UInt16 PortValue; // 0x16
	public UInt16 Path; // 0x18
	public UInt16 Query; // 0x1A
	public UInt16 Fragment; // 0x1C
	public UInt16 End; // 0x1E
}

// Namespace: 
private class MoreInfo
{
	// Fields
	public String Path; // 0x10
	public String Query; // 0x18
	public String Fragment; // 0x20
	public String AbsoluteUri; // 0x28
	public Int32 Hash; // 0x30
	public String RemoteUrl; // 0x38

	// Methods

	// RVA: 0xFFFFFFFF75BB9904
	public Void .ctor() { }

}

// Namespace: 
private enum Check
{
	// Fields
	public Int32 value__; // 0x10
	public const Check None = 0;
	public const Check EscapedCanonical = 1;
	public const Check DisplayCanonical = 2;
	public const Check DotSlashAttn = 4;
	public const Check DotSlashEscaped = 128;
	public const Check BackslashInPath = 16;
	public const Check ReservedFound = 32;
	public const Check NotIriCanonical = 64;
	public const Check FoundNonAscii = 8;
}

// Namespace: System
public class UriFormatException
{
	// Methods

	// RVA: 0xFFFFFFFF75BBAA94
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BBA980
	public Void .ctor(String textString) { }

	// RVA: 0xFFFFFFFF75BBAA9C
	protected Void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75BBAAA4
	private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

// Namespace: System
public enum UriPartial
{
	// Fields
	public Int32 value__; // 0x10
	public const UriPartial Scheme = 0;
	public const UriPartial Authority = 1;
	public const UriPartial Path = 2;
	public const UriPartial Query = 3;
}

// Namespace: System
public enum UriKind
{
	// Fields
	public Int32 value__; // 0x10
	public const UriKind RelativeOrAbsolute = 0;
	public const UriKind Absolute = 1;
	public const UriKind Relative = 2;
}

// Namespace: System
public enum UriComponents
{
	// Fields
	public Int32 value__; // 0x10
	public const UriComponents Scheme = 1;
	public const UriComponents UserInfo = 2;
	public const UriComponents Host = 4;
	public const UriComponents Port = 8;
	public const UriComponents Path = 16;
	public const UriComponents Query = 32;
	public const UriComponents Fragment = 64;
	public const UriComponents StrongPort = 128;
	public const UriComponents NormalizedHost = 256;
	public const UriComponents KeepDelimiter = 1073741824;
	public const UriComponents SerializationInfoString = 2147483648;
	public const UriComponents AbsoluteUri = 127;
	public const UriComponents HostAndPort = 132;
	public const UriComponents StrongAuthority = 134;
	public const UriComponents SchemeAndServer = 13;
	public const UriComponents HttpRequestUrl = 61;
	public const UriComponents PathAndQuery = 48;
}

// Namespace: System
public enum UriFormat
{
	// Fields
	public Int32 value__; // 0x10
	public const UriFormat UriEscaped = 1;
	public const UriFormat Unescaped = 2;
	public const UriFormat SafeUnescaped = 3;
}

// Namespace: System
public enum UriIdnScope
{
	// Fields
	public Int32 value__; // 0x10
	public const UriIdnScope None = 0;
	public const UriIdnScope AllExceptIntranet = 1;
	public const UriIdnScope All = 2;
}

// Namespace: System
internal enum ParsingError
{
	// Fields
	public Int32 value__; // 0x10
	public const ParsingError None = 0;
	public const ParsingError BadFormat = 1;
	public const ParsingError BadScheme = 2;
	public const ParsingError BadAuthority = 3;
	public const ParsingError EmptyUriString = 4;
	public const ParsingError LastRelativeUriOkErrIndex = 4;
	public const ParsingError SchemeLimit = 5;
	public const ParsingError SizeLimit = 6;
	public const ParsingError MustRootedPath = 7;
	public const ParsingError BadHostName = 8;
	public const ParsingError NonEmptyHost = 9;
	public const ParsingError BadPort = 10;
	public const ParsingError BadAuthorityTerminator = 11;
	public const ParsingError CannotCreateRelative = 12;
}

// Namespace: System
internal enum UnescapeMode
{
	// Fields
	public Int32 value__; // 0x10
	public const UnescapeMode CopyOnly = 0;
	public const UnescapeMode Escape = 1;
	public const UnescapeMode Unescape = 2;
	public const UnescapeMode EscapeUnescape = 3;
	public const UnescapeMode V1ToStringFlag = 4;
	public const UnescapeMode UnescapeAll = 8;
	public const UnescapeMode UnescapeAllOrThrow = 24;
}

// Namespace: System
internal static class UriHelper
{
	// Fields
	private static readonly Char[] HexUpperChars; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75BBAAAC
	internal static Char[] EscapeString(String input, Int32 start, Int32 end, Char[] dest, ref Int32 destPos, Boolean isUriString, Char force1, Char force2, Char rsvd) { }

	// RVA: 0xFFFFFFFF75BBAFCC
	private static Char[] EnsureDestinationSize(Char* pStr, Char[] dest, Int32 currentInputPos, Int16 charsToAdd, Int16 minReallocateChars, ref Int32 destPos, Int32 prevInputPos) { }

	// RVA: 0xFFFFFFFF723A7FB4
	internal static Char[] UnescapeString(String input, Int32 start, Int32 end, Char[] dest, ref Int32 destPosition, Char rsvd1, Char rsvd2, Char rsvd3, UnescapeMode unescapeMode, UriParser syntax, Boolean isQuery) { }

	// RVA: 0xFFFFFFFF723A8060
	internal static Char[] UnescapeString(Char* pStr, Int32 start, Int32 end, Char[] dest, ref Int32 destPosition, Char rsvd1, Char rsvd2, Char rsvd3, UnescapeMode unescapeMode, UriParser syntax, Boolean isQuery) { }

	// RVA: 0xFFFFFFFF723A8B00
	internal static Void MatchUTF8Sequence(Char* pDest, Char[] dest, ref Int32 destOffset, Char[] unescapedChars, Int32 charCount, Byte[] bytes, Int32 byteCount, Boolean isQuery, Boolean iriParsing) { }

	// RVA: 0xFFFFFFFF75BBB0D8
	internal static Void EscapeAsciiChar(Char ch, Char[] to, ref Int32 pos) { }

	// RVA: 0xFFFFFFFF723A7D1C
	internal static Char EscapedAscii(Char digit, Char next) { }

	// RVA: 0xFFFFFFFF75BBB2EC
	internal static Boolean IsNotSafeForUnescape(Char ch) { }

	// RVA: 0xFFFFFFFF75BBB1D4
	private static Boolean IsReservedUnreservedOrHash(Char c) { }

	// RVA: 0xFFFFFFFF723A7DB8
	internal static Boolean IsUnreserved(Char c) { }

	// RVA: 0xFFFFFFFF723A9098
	internal static Boolean Is3986Unreserved(Char c) { }

	// RVA: 0xFFFFFFFF75BBB39C
	private static Void .cctor() { }

}

// Namespace: System
public enum UriHostNameType
{
	// Fields
	public Int32 value__; // 0x10
	public const UriHostNameType Unknown = 0;
	public const UriHostNameType Basic = 1;
	public const UriHostNameType Dns = 2;
	public const UriHostNameType IPv4 = 3;
	public const UriHostNameType IPv6 = 4;
}

// Namespace: System
public abstract class UriParser
{
	// Fields
	private const UriSyntaxFlags SchemeOnlyFlags = 16;
	private static readonly Dictionary<T0, T1> m_Table; // 0x0
	private static Dictionary<T0, T1> m_TempTable; // 0x8
	private UriSyntaxFlags m_Flags; // 0x10
	private UriSyntaxFlags m_UpdatableFlags; // 0x14
	private Boolean m_UpdatableFlagsUsed; // 0x18
	private const UriSyntaxFlags c_UpdatableFlags = 33554432;
	private Int32 m_Port; // 0x1C
	private String m_Scheme; // 0x20
	internal const Int32 NoDefaultPort = 4294967295;
	private const Int32 c_InitialTableSize = 25;
	internal static UriParser HttpUri; // 0x10
	internal static UriParser HttpsUri; // 0x18
	internal static UriParser WsUri; // 0x20
	internal static UriParser WssUri; // 0x28
	internal static UriParser FtpUri; // 0x30
	internal static UriParser FileUri; // 0x38
	internal static UriParser GopherUri; // 0x40
	internal static UriParser NntpUri; // 0x48
	internal static UriParser NewsUri; // 0x50
	internal static UriParser MailToUri; // 0x58
	internal static UriParser UuidUri; // 0x60
	internal static UriParser TelnetUri; // 0x68
	internal static UriParser LdapUri; // 0x70
	internal static UriParser NetTcpUri; // 0x78
	internal static UriParser NetPipeUri; // 0x80
	internal static UriParser VsMacrosUri; // 0x88
	private static readonly UriQuirksVersion s_QuirksVersion; // 0x90
	private const Int32 c_MaxCapacity = 512;
	private const UriSyntaxFlags UnknownV1SyntaxFlags = 351342590;
	private static readonly UriSyntaxFlags HttpSyntaxFlags; // 0x94
	private const UriSyntaxFlags FtpSyntaxFlags = 367005533;
	private static readonly UriSyntaxFlags FileSyntaxFlags; // 0x98
	private const UriSyntaxFlags VsmacrosSyntaxFlags = 399519697;
	private const UriSyntaxFlags GopherSyntaxFlags = 337645405;
	private const UriSyntaxFlags NewsSyntaxFlags = 268435536;
	private const UriSyntaxFlags NntpSyntaxFlags = 337645405;
	private const UriSyntaxFlags TelnetSyntaxFlags = 337645405;
	private const UriSyntaxFlags LdapSyntaxFlags = 337645565;
	private const UriSyntaxFlags MailtoSyntaxFlags = 335564796;
	private const UriSyntaxFlags NetPipeSyntaxFlags = 400559729;
	private const UriSyntaxFlags NetTcpSyntaxFlags = 400559737;

	// Properties
	internal String SchemeName { get; }
	internal Int32 DefaultPort { get; }
	internal static Boolean ShouldUseLegacyV2Quirks { get; }
	internal UriSyntaxFlags Flags { get; }
	internal Boolean IsSimple { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BBB400
	internal String get_SchemeName() { }

	// RVA: 0xFFFFFFFF75BBB408
	internal Int32 get_DefaultPort() { }

	// RVA: 0xFFFFFFFF75BBB410
	protected virtual UriParser OnNewUri() { }

	// RVA: 0xFFFFFFFF75BBB414
	protected virtual Void InitializeAndValidate(Uri uri, out UriFormatException parsingError) { }

	// RVA: 0xFFFFFFFF723A91B4
	protected virtual String Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError) { }

	// RVA: 0xFFFFFFFF75BBB460
	protected virtual String GetComponents(Uri uri, UriComponents components, UriFormat format) { }

	// RVA: 0xFFFFFFFF75BBB62C
	protected virtual Boolean IsWellFormedOriginalString(Uri uri) { }

	// RVA: 0xFFFFFFFF75BBB354
	internal static Boolean get_ShouldUseLegacyV2Quirks() { }

	// RVA: 0xFFFFFFFF75BBB648
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75BBBED4
	internal UriSyntaxFlags get_Flags() { }

	// RVA: 0xFFFFFFFF75BBAA60
	internal Boolean NotAny(UriSyntaxFlags flags) { }

	// RVA: 0xFFFFFFFF75BBAA2C
	internal Boolean InFact(UriSyntaxFlags flags) { }

	// RVA: 0xFFFFFFFF75BBBF14
	internal Boolean IsAllSet(UriSyntaxFlags flags) { }

	// RVA: 0xFFFFFFFF75BBBEDC
	private Boolean IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

	// RVA: 0xFFFFFFFF75BBBF48
	internal Void .ctor(UriSyntaxFlags flags) { }

	// RVA: 0xFFFFFFFF723A94EC
	internal static UriParser FindOrFetchAsUnknownV1Syntax(String lwrCaseScheme) { }

	// RVA: 0xFFFFFFFF75BBA988
	internal static UriParser GetSyntax(String lwrCaseScheme) { }

	// RVA: 0xFFFFFFFF75BBBF94
	internal Boolean get_IsSimple() { }

	// RVA: 0xFFFFFFFF75BBBFA0
	internal UriParser InternalOnNewUri() { }

	// RVA: 0xFFFFFFFF75BBC01C
	internal Void InternalValidate(Uri thisUri, out UriFormatException parsingError) { }

	// RVA: 0xFFFFFFFF75BBC02C
	internal String InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError) { }

	// RVA: 0xFFFFFFFF75BBC03C
	internal String InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0xFFFFFFFF75BBC04C
	internal Boolean InternalIsWellFormedOriginalString(Uri thisUri) { }

}

// Namespace: 
private enum UriQuirksVersion
{
	// Fields
	public Int32 value__; // 0x10
	public const UriQuirksVersion V2 = 2;
	public const UriQuirksVersion V3 = 3;
}

// Namespace: 
private class BuiltInUriParser
{
	// Methods

	// RVA: 0xFFFFFFFF75BBBE38
	internal Void .ctor(String lwrCaseScheme, Int32 defaultPort, UriSyntaxFlags syntaxFlags) { }

}

// Namespace: System
internal class DomainNameHelper
{
	// Methods

	// RVA: 0xFFFFFFFF72376798
	internal static String ParseCanonicalName(String str, Int32 start, Int32 end, ref Boolean loopback) { }

	// RVA: 0xFFFFFFFF75B3D24C
	internal static Boolean IsValid(Char* name, UInt16 pos, ref Int32 returnedEnd, ref Boolean notCanonical, Boolean notImplicitFile) { }

	// RVA: 0xFFFFFFFF723768FC
	internal static Boolean IsValidByIri(Char* name, UInt16 pos, ref Int32 returnedEnd, ref Boolean notCanonical, Boolean notImplicitFile) { }

	// RVA: 0xFFFFFFFF75B3D450
	internal static String IdnEquivalent(String hostname) { }

	// RVA: 0xFFFFFFFF75B3D4A4
	internal static String IdnEquivalent(Char* hostname, Int32 start, Int32 end, ref Boolean allAscii, ref Boolean atLeastOneValidIdn) { }

	// RVA: 0xFFFFFFFF75B3D7A8
	internal static String IdnEquivalent(Char* hostname, Int32 start, Int32 end, ref Boolean allAscii, ref String bidiStrippedHost) { }

	// RVA: 0xFFFFFFFF75B3DA14
	private static Boolean IsIdnAce(String input, Int32 index) { }

	// RVA: 0xFFFFFFFF75B3D9C8
	private static Boolean IsIdnAce(Char* input, Int32 index) { }

	// RVA: 0xFFFFFFFF75B3DAA0
	internal static String UnicodeEquivalent(String idnHost, Char* hostname, Int32 start, Int32 end) { }

	// RVA: 0xFFFFFFFF75B3DBC0
	internal static String UnicodeEquivalent(Char* hostname, Int32 start, Int32 end, ref Boolean allAscii, ref Boolean atLeastOneValidIdn) { }

	// RVA: 0xFFFFFFFF75B3D3C4
	private static Boolean IsASCIILetterOrDigit(Char character, ref Boolean notCanonical) { }

	// RVA: 0xFFFFFFFF75B3D400
	private static Boolean IsValidDomainLabelCharacter(Char character, ref Boolean notCanonical) { }

}

// Namespace: System
internal static class IPv4AddressHelper
{
	// Methods

	// RVA: 0xFFFFFFFF75B40604
	internal static String ParseCanonicalName(String str, Int32 start, Int32 end, ref Boolean isLoopback) { }

	// RVA: 0xFFFFFFFF75B40800
	internal static Int32 ParseHostNumber(String str, Int32 start, Int32 end) { }

	// RVA: 0xFFFFFFFF75B409E4
	internal static Boolean IsValid(Char* name, Int32 start, ref Int32 end, Boolean allowIPv6, Boolean notImplicitFile, Boolean unknownScheme) { }

	// RVA: 0xFFFFFFFF75B40A10
	internal static Boolean IsValidCanonical(Char* name, Int32 start, ref Int32 end, Boolean allowIPv6, Boolean notImplicitFile) { }

	// RVA: 0xFFFFFFFF72377DDC
	internal static Int64 ParseNonCanonical(Char* name, Int32 start, ref Int32 end, Boolean notImplicitFile) { }

	// RVA: 0xFFFFFFFF75B40790
	private static Boolean Parse(String name, Byte* numbers, Int32 start, Int32 end) { }

	// RVA: 0xFFFFFFFF75B40834
	private static Boolean ParseCanonical(String name, Byte* numbers, Int32 start, Int32 end) { }

}

// Namespace: System
internal static class IPv6AddressHelper
{
	// Methods

	// RVA: 0xFFFFFFFF75B40B68
	internal static String ParseCanonicalName(String str, Int32 start, ref Boolean isLoopback, ref String scopeId) { }

	// RVA: 0xFFFFFFFF75B40BF0
	internal static String CreateCanonicalName(UInt16* numbers) { }

	// RVA: 0xFFFFFFFF75B41190
	private static KeyValuePair<T0, T1> FindCompressionRange(UInt16* numbers) { }

	// RVA: 0xFFFFFFFF75B4130C
	private static Boolean ShouldHaveIpv4Embedded(UInt16* numbers) { }

	// RVA: 0xFFFFFFFF72378814
	private static Boolean InternalIsValid(Char* name, Int32 start, ref Int32 end, Boolean validateStrictAddress) { }

	// RVA: 0xFFFFFFFF75B4139C
	internal static Boolean IsValid(Char* name, Int32 start, ref Int32 end) { }

	// RVA: 0xFFFFFFFF75B413A4
	internal static Boolean IsValidStrict(Char* name, Int32 start, ref Int32 end) { }

	// RVA: 0xFFFFFFFF72378164
	internal static Boolean Parse(String address, UInt16* numbers, Int32 start, ref String scopeId) { }

}

// Namespace: System
internal class UncNameHelper
{
	// Methods

	// RVA: 0xFFFFFFFF75BB582C
	internal static String ParseCanonicalName(String str, Int32 start, Int32 end, ref Boolean loopback) { }

	// RVA: 0xFFFFFFFF75BB5834
	internal static Boolean IsValid(Char* name, UInt16 start, ref Int32 returnedEnd, Boolean notImplicitFile) { }

}

// Namespace: System
internal enum UriSyntaxFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const UriSyntaxFlags None = 0;
	public const UriSyntaxFlags MustHaveAuthority = 1;
	public const UriSyntaxFlags OptionalAuthority = 2;
	public const UriSyntaxFlags MayHaveUserInfo = 4;
	public const UriSyntaxFlags MayHavePort = 8;
	public const UriSyntaxFlags MayHavePath = 16;
	public const UriSyntaxFlags MayHaveQuery = 32;
	public const UriSyntaxFlags MayHaveFragment = 64;
	public const UriSyntaxFlags AllowEmptyHost = 128;
	public const UriSyntaxFlags AllowUncHost = 256;
	public const UriSyntaxFlags AllowDnsHost = 512;
	public const UriSyntaxFlags AllowIPv4Host = 1024;
	public const UriSyntaxFlags AllowIPv6Host = 2048;
	public const UriSyntaxFlags AllowAnInternetHost = 3584;
	public const UriSyntaxFlags AllowAnyOtherHost = 4096;
	public const UriSyntaxFlags FileLikeUri = 8192;
	public const UriSyntaxFlags MailToLikeUri = 16384;
	public const UriSyntaxFlags V1_UnknownUri = 65536;
	public const UriSyntaxFlags SimpleUserSyntax = 131072;
	public const UriSyntaxFlags BuiltInSyntax = 262144;
	public const UriSyntaxFlags ParserSchemeOnly = 524288;
	public const UriSyntaxFlags AllowDOSPath = 1048576;
	public const UriSyntaxFlags PathIsRooted = 2097152;
	public const UriSyntaxFlags ConvertPathSlashes = 4194304;
	public const UriSyntaxFlags CompressPath = 8388608;
	public const UriSyntaxFlags CanonicalizeAsFilePath = 16777216;
	public const UriSyntaxFlags UnEscapeDotsAndSlashes = 33554432;
	public const UriSyntaxFlags AllowIdn = 67108864;
	public const UriSyntaxFlags AllowIriParsing = 268435456;
}

// Namespace: System
internal static class LocalAppContextSwitches
{
	// Fields
	public static readonly Boolean MemberDescriptorEqualsReturnsFalseIfEquivalent; // 0x0
}

// Namespace: System
internal enum IOOperation
{
	// Fields
	public Int32 value__; // 0x10
	public const IOOperation Read = 1;
	public const IOOperation Write = 2;
}

// Namespace: System
internal sealed class IOAsyncCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75B40438
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF723778B8
	public virtual Void Invoke(IOAsyncResult ioares) { }

	// RVA: 0xFFFFFFFF75B4047C
	public virtual IAsyncResult BeginInvoke(IOAsyncResult ioares, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B404CC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: System
internal abstract class IOAsyncResult
{
	// Fields
	private AsyncCallback async_callback; // 0x10
	private Object async_state; // 0x18
	private ManualResetEvent wait_handle; // 0x20
	private Boolean completed_synchronously; // 0x28
	private Boolean completed; // 0x29

	// Properties
	public AsyncCallback AsyncCallback { get; }
	public Object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public Boolean CompletedSynchronously { get; set; }
	public Boolean IsCompleted { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF72377C3C
	protected Void .ctor(AsyncCallback async_callback, Object async_state) { }

	// RVA: 0xFFFFFFFF75B404D8
	public AsyncCallback get_AsyncCallback() { }

	// RVA: 0xFFFFFFFF72377CA0
	public Object get_AsyncState() { }

	// RVA: 0xFFFFFFFF75B404E0
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0xFFFFFFFF75B405C0
	public Boolean get_CompletedSynchronously() { }

	// RVA: 0xFFFFFFFF75B405C8
	protected Void set_CompletedSynchronously(Boolean value) { }

	// RVA: 0xFFFFFFFF75B405D0
	public Boolean get_IsCompleted() { }

	// RVA: 0xFFFFFFFF72377CA8
	protected Void set_IsCompleted(Boolean value) { }

	// RVA: -1
	internal abstract Void CompleteDisposed() { }

}

// Namespace: System
internal class IOSelectorJob
{
	// Fields
	private IOOperation operation; // 0x10
	private IOAsyncCallback callback; // 0x18
	private IOAsyncResult state; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF72377D50
	public Void .ctor(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	// RVA: 0xFFFFFFFF72377DB8
	private Void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0xFFFFFFFF75B405D8
	private Void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0xFFFFFFFF75B405DC
	public Void MarkDisposed() { }

}

// Namespace: System
internal static class IOSelector
{
	// Methods

	// RVA: 0xFFFFFFFF72377D4C
	public static Void Add(IntPtr handle, IOSelectorJob job) { }

}

// Namespace: System
internal static class Platform
{
	// Fields
	private static Boolean checkedOS; // 0x0
	private static Boolean isMacOS; // 0x1
	private static Boolean isFreeBSD; // 0x2

	// Properties
	public static Boolean IsMacOS { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B9322C
	private static extern Int32 uname(IntPtr buf) { }

	// RVA: 0xFFFFFFFF75B932AC
	private static Void CheckOS() { }

	// RVA: 0xFFFFFFFF75B93464
	public static Boolean get_IsMacOS() { }

}

// Namespace: System
public class UriTypeConverter
{
	// Methods

	// RVA: 0xFFFFFFFF75BBC05C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BBC064
	private Boolean CanConvert(Type type) { }

	// RVA: 0xFFFFFFFF75BBC110
	public override Boolean CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0xFFFFFFFF75BBC1BC
	public override Boolean CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xFFFFFFFF75BBC21C
	public override Object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, Object value) { }

	// RVA: 0xFFFFFFFF75BBC39C
	public override Object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, Object value, Type destinationType) { }

}

// Namespace: System.Timers
public sealed class ElapsedEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75BB4660
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75BB46A4
	public virtual Void Invoke(Object sender, ElapsedEventArgs e) { }

	// RVA: 0xFFFFFFFF75BB4A70
	public virtual IAsyncResult BeginInvoke(Object sender, ElapsedEventArgs e, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BB4ACC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Timers
public class Timer
{
	// Fields
	private Double interval; // 0x28
	private Boolean enabled; // 0x30
	private Boolean initializing; // 0x31
	private Boolean delayedEnable; // 0x32
	private ElapsedEventHandler onIntervalElapsed; // 0x38
	private Boolean autoReset; // 0x40
	private ISynchronizeInvoke synchronizingObject; // 0x48
	private Boolean disposed; // 0x50
	private Timer timer; // 0x58
	private TimerCallback callback; // 0x60
	private Object cookie; // 0x68

	// Properties
	public Boolean AutoReset { set; }
	public Boolean Enabled { set; }
	public override ISite Site { get; }
	public ISynchronizeInvoke SynchronizingObject { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BB4AD8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BB4BA0
	public Void .ctor(Double interval) { }

	// RVA: 0xFFFFFFFF75BB4E78
	public Void set_AutoReset(Boolean value) { }

	// RVA: 0xFFFFFFFF75BB4F20
	public Void set_Enabled(Boolean value) { }

	// RVA: 0xFFFFFFFF75BB4CB8
	private static Int32 CalculateRoundedInterval(Double interval, Boolean argumentCheck) { }

	// RVA: 0xFFFFFFFF75BB4ED8
	private Void UpdateTimer() { }

	// RVA: 0xFFFFFFFF75BB513C
	public Void add_Elapsed(ElapsedEventHandler value) { }

	// RVA: 0xFFFFFFFF75BB51D0
	public Void remove_Elapsed(ElapsedEventHandler value) { }

	// RVA: 0xFFFFFFFF75BB5264
	public override ISite get_Site() { }

	// RVA: 0xFFFFFFFF75BB526C
	public ISynchronizeInvoke get_SynchronizingObject() { }

	// RVA: 0xFFFFFFFF75BB5410
	public Void Close() { }

	// RVA: 0xFFFFFFFF75BB5460
	protected override Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75BB5498
	public Void Stop() { }

	// RVA: 0xFFFFFFFF75BB54A0
	private Void MyTimerCallback(Object state) { }

}

// Namespace: System.Timers
public class TimersDescriptionAttribute
{
	// Fields
	private Boolean replaced; // 0x18

	// Properties
	public override String Description { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BB5760
	public Void .ctor(String description) { }

	// RVA: 0xFFFFFFFF75BB57D0
	public override String get_Description() { }

}

// Namespace: System.Timers
public class ElapsedEventArgs
{
	// Fields
	private DateTime time; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75BB45EC
	internal Void .ctor(DateTime time) { }

}

// Namespace: System.Text.RegularExpressions
public class Regex
{
	// Fields
	protected internal String pattern; // 0x10
	protected internal RegexRunnerFactory factory; // 0x18
	protected internal RegexOptions roptions; // 0x20
	private static readonly TimeSpan MaximumMatchTimeout; // 0x0
	public static readonly TimeSpan InfiniteMatchTimeout; // 0x8
	protected internal TimeSpan internalMatchTimeout; // 0x28
	private const String DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT";
	internal static readonly TimeSpan FallbackDefaultMatchTimeout; // 0x10
	internal static readonly TimeSpan DefaultMatchTimeout; // 0x18
	protected internal Hashtable caps; // 0x30
	protected internal Hashtable capnames; // 0x38
	protected internal String[] capslist; // 0x40
	protected internal Int32 capsize; // 0x48
	internal ExclusiveReference runnerref; // 0x50
	internal SharedReference replref; // 0x58
	internal RegexCode code; // 0x60
	internal Boolean refsInitialized; // 0x68
	internal static LinkedList<T0> livecode; // 0x20
	internal static Int32 cacheSize; // 0x28
	internal const Int32 MaxOptionShift = 10;

	// Properties
	public RegexOptions Options { get; }
	public TimeSpan MatchTimeout { get; }
	public Boolean RightToLeft { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BA7A64
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF75BA7AAC
	public Void .ctor(String pattern) { }

	// RVA: 0xFFFFFFFF75BA7B10
	public Void .ctor(String pattern, RegexOptions options) { }

	// RVA: 0xFFFFFFFF723917D8
	private Void .ctor(String pattern, RegexOptions options, TimeSpan matchTimeout, Boolean useCache) { }

	// RVA: 0xFFFFFFFF75BA80C8
	protected Void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF75BA81F0
	private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0xFFFFFFFF72391CC0
	protected internal static Void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0xFFFFFFFF75BA82BC
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0xFFFFFFFF75BA8490
	public static String Escape(String str) { }

	// RVA: 0xFFFFFFFF75BA86FC
	public RegexOptions get_Options() { }

	// RVA: 0xFFFFFFFF75BA8704
	public TimeSpan get_MatchTimeout() { }

	// RVA: 0xFFFFFFFF723920A0
	public Boolean get_RightToLeft() { }

	// RVA: 0xFFFFFFFF75BA8718
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75BA6360
	public String GroupNameFromNumber(Int32 i) { }

	// RVA: 0xFFFFFFFF75BA6228
	public Int32 GroupNumberFromName(String name) { }

	// RVA: 0xFFFFFFFF723920AC
	public static Boolean IsMatch(String input, String pattern) { }

	// RVA: 0xFFFFFFFF75BA8720
	public static Boolean IsMatch(String input, String pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0xFFFFFFFF72392180
	public Boolean IsMatch(String input) { }

	// RVA: 0xFFFFFFFF723921F8
	public Boolean IsMatch(String input, Int32 startat) { }

	// RVA: 0xFFFFFFFF75BA8784
	public static Match Match(String input, String pattern) { }

	// RVA: 0xFFFFFFFF75BA8860
	public static Match Match(String input, String pattern, RegexOptions options) { }

	// RVA: 0xFFFFFFFF75BA87FC
	public static Match Match(String input, String pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0xFFFFFFFF72392268
	public Match Match(String input) { }

	// RVA: 0xFFFFFFFF7239230C
	public Match Match(String input, Int32 startat) { }

	// RVA: 0xFFFFFFFF72392370
	public static MatchCollection Matches(String input, String pattern) { }

	// RVA: 0xFFFFFFFF75BA88E0
	public static MatchCollection Matches(String input, String pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0xFFFFFFFF72392458
	public MatchCollection Matches(String input) { }

	// RVA: 0xFFFFFFFF723924F8
	public MatchCollection Matches(String input, Int32 startat) { }

	// RVA: 0xFFFFFFFF75BA8944
	public static String Replace(String input, String pattern, String replacement) { }

	// RVA: 0xFFFFFFFF75BA89C8
	public static String Replace(String input, String pattern, String replacement, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0xFFFFFFFF72392590
	public String Replace(String input, String replacement) { }

	// RVA: 0xFFFFFFFF723925F4
	public String Replace(String input, String replacement, Int32 count, Int32 startat) { }

	// RVA: 0xFFFFFFFF75BA8A34
	public static String Replace(String input, String pattern, MatchEvaluator evaluator) { }

	// RVA: 0xFFFFFFFF75BA8AB8
	public static String Replace(String input, String pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0xFFFFFFFF75BA8B24
	public String Replace(String input, MatchEvaluator evaluator) { }

	// RVA: 0xFFFFFFFF75BA8BC8
	public String Replace(String input, MatchEvaluator evaluator, Int32 count, Int32 startat) { }

	// RVA: 0xFFFFFFFF75BA8FB8
	public static String[] Split(String input, String pattern) { }

	// RVA: 0xFFFFFFFF75BA9090
	public static String[] Split(String input, String pattern, RegexOptions options) { }

	// RVA: 0xFFFFFFFF75BA902C
	public static String[] Split(String input, String pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0xFFFFFFFF75BA9110
	public String[] Split(String input) { }

	// RVA: 0xFFFFFFFF75BA91AC
	public String[] Split(String input, Int32 count, Int32 startat) { }

	// RVA: 0xFFFFFFFF75BA7D18
	protected Void InitializeReferences() { }

	// RVA: 0xFFFFFFFF72390DE4
	internal Match Run(Boolean quick, Int32 prevlen, String input, Int32 beginning, Int32 length, Int32 startat) { }

	// RVA: 0xFFFFFFFF72391DBC
	private static CachedCodeEntry LookupCachedAndUpdate(String key) { }

	// RVA: 0xFFFFFFFF75BA7DD0
	private CachedCodeEntry CacheCode(String key) { }

	// RVA: 0xFFFFFFFF75BA870C
	protected Boolean UseOptionR() { }

	// RVA: 0xFFFFFFFF75BA96CC
	internal Boolean UseOptionInvariant() { }

	// RVA: 0xFFFFFFFF75BA97D0
	private static Void .cctor() { }

}

// Namespace: System.Text.RegularExpressions
public sealed class MatchEvaluator
{
	// Methods

	// RVA: 0xFFFFFFFF75BA74B8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75BA74FC
	public virtual String Invoke(Match match) { }

	// RVA: 0xFFFFFFFF75BA7890
	public virtual IAsyncResult BeginInvoke(Match match, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BA78E0
	public virtual String EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class CachedCodeEntry
{
	// Fields
	internal String _key; // 0x10
	internal RegexCode _code; // 0x18
	internal Hashtable _caps; // 0x20
	internal Hashtable _capnames; // 0x28
	internal String[] _capslist; // 0x30
	internal Int32 _capsize; // 0x38
	internal RegexRunnerFactory _factory; // 0x40
	internal ExclusiveReference _runnerref; // 0x48
	internal SharedReference _replref; // 0x50

	// Methods

	// RVA: 0xFFFFFFFF75BA56F0
	internal Void .ctor(String key, Hashtable capnames, String[] capslist, RegexCode code, Hashtable caps, Int32 capsize, ExclusiveReference runner, SharedReference repl) { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class ExclusiveReference
{
	// Fields
	private RegexRunner _ref; // 0x10
	private Object _obj; // 0x18
	private Int32 _locked; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF72390704
	internal Object Get() { }

	// RVA: 0xFFFFFFFF7239078C
	internal Void Release(Object obj) { }

	// RVA: 0xFFFFFFFF75BA5EC4
	public Void .ctor() { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class SharedReference
{
	// Fields
	private WeakReference _ref; // 0x10
	private Int32 _locked; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF72391094
	internal Object Get() { }

	// RVA: 0xFFFFFFFF75BA6B40
	internal Void Cache(Object obj) { }

	// RVA: 0xFFFFFFFF75BA9678
	public Void .ctor() { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexBoyerMoore
{
	// Fields
	internal Int32[] _positive; // 0x10
	internal Int32[] _negativeASCII; // 0x18
	internal Int32[][] _negativeUnicode; // 0x20
	internal String _pattern; // 0x28
	internal Int32 _lowASCII; // 0x30
	internal Int32 _highASCII; // 0x34
	internal Boolean _rightToLeft; // 0x38
	internal Boolean _caseInsensitive; // 0x39
	internal CultureInfo _culture; // 0x40
	internal const Int32 infinite = 2147483647;

	// Methods

	// RVA: 0xFFFFFFFF72392E20
	internal Void .ctor(String pattern, Boolean caseInsensitive, Boolean rightToLeft, CultureInfo culture) { }

	// RVA: 0xFFFFFFFF723933FC
	private Boolean MatchPattern(String text, Int32 index) { }

	// RVA: 0xFFFFFFFF72393544
	internal Boolean IsMatch(String text, Int32 index, Int32 beglimit, Int32 endlimit) { }

	// RVA: 0xFFFFFFFF723935B4
	internal Int32 Scan(String text, Int32 index, Int32 beglimit, Int32 endlimit) { }

	// RVA: 0xFFFFFFFF75BA98C0
	public override String ToString() { }

}

// Namespace: System.Text.RegularExpressions
public class Capture
{
	// Fields
	internal String _text; // 0x10
	internal Int32 _index; // 0x18
	internal Int32 _length; // 0x1C

	// Properties
	public Int32 Index { get; }
	public Int32 Length { get; }
	public String Value { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BA5820
	internal Void .ctor(String text, Int32 i, Int32 l) { }

	// RVA: 0xFFFFFFFF75BA586C
	public Int32 get_Index() { }

	// RVA: 0xFFFFFFFF75BA5874
	public Int32 get_Length() { }

	// RVA: 0xFFFFFFFF75BA587C
	public String get_Value() { }

	// RVA: 0xFFFFFFFF75BA58A4
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75BA58CC
	internal String GetOriginalString() { }

	// RVA: 0xFFFFFFFF75BA58D4
	internal String GetLeftSubstring() { }

	// RVA: 0xFFFFFFFF75BA5900
	internal String GetRightSubstring() { }

	// RVA: 0xFFFFFFFF75BA5934
	internal Void .ctor() { }

}

// Namespace: System.Text.RegularExpressions
public class CaptureCollection
{
	// Fields
	internal Group _group; // 0x10
	internal Int32 _capcount; // 0x18
	internal Capture[] _captures; // 0x20

	// Properties
	public Object SyncRoot { get; }
	public Boolean IsSynchronized { get; }
	public Int32 Count { get; }
	public Capture Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BA596C
	internal Void .ctor(Group group) { }

	// RVA: 0xFFFFFFFF75BA59B8
	public Object get_SyncRoot() { }

	// RVA: 0xFFFFFFFF75BA59C0
	public Boolean get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75BA59C8
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75BA59D0
	public Capture get_Item(Int32 i) { }

	// RVA: 0xFFFFFFFF75BA5C24
	public Void CopyTo(Array array, Int32 arrayIndex) { }

	// RVA: 0xFFFFFFFF75BA5CF0
	public IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75BA59D4
	internal Capture GetCapture(Int32 i) { }

	// RVA: 0xFFFFFFFF75BA5D64
	internal Void .ctor() { }

}

// Namespace: System.Text.RegularExpressions
internal class CaptureEnumerator
{
	// Fields
	internal CaptureCollection _rcc; // 0x10
	internal Int32 _curindex; // 0x18

	// Properties
	public Object Current { get; }
	public Capture Capture { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BA5D9C
	internal Void .ctor(CaptureCollection rcc) { }

	// RVA: 0xFFFFFFFF75BA5DDC
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75BA5E20
	public Object get_Current() { }

	// RVA: 0xFFFFFFFF75BA5E24
	public Capture get_Capture() { }

	// RVA: 0xFFFFFFFF75BA5EB8
	public Void Reset() { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexCharClass
{
	// Fields
	private List<T0> _rangelist; // 0x10
	private StringBuilder _categories; // 0x18
	private Boolean _canonical; // 0x20
	private Boolean _negate; // 0x21
	private RegexCharClass _subtractor; // 0x28
	private static readonly String InternalRegexIgnoreCase; // 0x0
	private static readonly String Space; // 0x8
	private static readonly String NotSpace; // 0x10
	private static readonly String Word; // 0x18
	private static readonly String NotWord; // 0x20
	internal static readonly String SpaceClass; // 0x28
	internal static readonly String NotSpaceClass; // 0x30
	internal static readonly String WordClass; // 0x38
	internal static readonly String NotWordClass; // 0x40
	internal static readonly String DigitClass; // 0x48
	internal static readonly String NotDigitClass; // 0x50
	private static Dictionary<T0, T1> _definedCategories; // 0x58
	private static readonly String[,] _propTable; // 0x60
	private static readonly LowerCaseMapping[] _lcTable; // 0x68

	// Properties
	internal Boolean CanMerge { get; }
	internal Boolean Negate { set; }

	// Methods

	// RVA: 0xFFFFFFFF75BA98C8
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF72393A40
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75BADC44
	private Void .ctor(Boolean negate, List<T0> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	// RVA: 0xFFFFFFFF75BADCE4
	internal Boolean get_CanMerge() { }

	// RVA: 0xFFFFFFFF75BADD04
	internal Void set_Negate(Boolean value) { }

	// RVA: 0xFFFFFFFF75BADD0C
	internal Void AddChar(Char c) { }

	// RVA: 0xFFFFFFFF75BADD14
	internal Void AddCharClass(RegexCharClass cc) { }

	// RVA: 0xFFFFFFFF75BADE80
	private Void AddSet(String set) { }

	// RVA: 0xFFFFFFFF75BAE044
	internal Void AddSubtraction(RegexCharClass sub) { }

	// RVA: 0xFFFFFFFF72393B64
	internal Void AddRange(Char first, Char last) { }

	// RVA: 0xFFFFFFFF75BAE07C
	internal Void AddCategoryFromName(String categoryName, Boolean invert, Boolean caseInsensitive, String pattern) { }

	// RVA: 0xFFFFFFFF75BAE498
	private Void AddCategory(String category) { }

	// RVA: 0xFFFFFFFF75BAE4B8
	internal Void AddLowercase(CultureInfo culture) { }

	// RVA: 0xFFFFFFFF75BAE5A4
	private Void AddLowercaseRange(Char chMin, Char chMax, CultureInfo culture) { }

	// RVA: 0xFFFFFFFF75BAE7AC
	internal Void AddWord(Boolean ecma, Boolean negate) { }

	// RVA: 0xFFFFFFFF75BAE8A8
	internal Void AddSpace(Boolean ecma, Boolean negate) { }

	// RVA: 0xFFFFFFFF75BAE9A4
	internal Void AddDigit(Boolean ecma, Boolean negate, String pattern) { }

	// RVA: 0xFFFFFFFF75BAEA54
	internal static Char SingletonChar(String set) { }

	// RVA: 0xFFFFFFFF75BAEA70
	internal static Boolean IsMergeable(String charClass) { }

	// RVA: 0xFFFFFFFF72393C8C
	internal static Boolean IsEmpty(String charClass) { }

	// RVA: 0xFFFFFFFF72393D48
	internal static Boolean IsSingleton(String set) { }

	// RVA: 0xFFFFFFFF75BAEB64
	internal static Boolean IsSingletonInverse(String set) { }

	// RVA: 0xFFFFFFFF75BAEB04
	private static Boolean IsSubtraction(String charClass) { }

	// RVA: 0xFFFFFFFF75BAEADC
	internal static Boolean IsNegated(String set) { }

	// RVA: 0xFFFFFFFF75BAEC48
	internal static Boolean IsECMAWordChar(Char ch) { }

	// RVA: 0xFFFFFFFF75BAECAC
	internal static Boolean IsWordChar(Char ch) { }

	// RVA: 0xFFFFFFFF72393E50
	internal static Boolean CharInClass(Char ch, String set) { }

	// RVA: 0xFFFFFFFF72393EA0
	internal static Boolean CharInClassRecursive(Char ch, String set, Int32 start) { }

	// RVA: 0xFFFFFFFF723940B8
	private static Boolean CharInClassInternal(Char ch, String set, Int32 start, Int32 mySetLength, Int32 myCategoryLength) { }

	// RVA: 0xFFFFFFFF723941B0
	private static Boolean CharInCategory(Char ch, String set, Int32 start, Int32 mySetLength, Int32 myCategoryLength) { }

	// RVA: 0xFFFFFFFF723944C4
	private static Boolean CharInCategoryGroup(Char ch, UnicodeCategory chcategory, String category, ref Int32 i) { }

	// RVA: 0xFFFFFFFF75BADB94
	private static String NegateCategory(String category) { }

	// RVA: 0xFFFFFFFF75BAED0C
	internal static RegexCharClass Parse(String charClass) { }

	// RVA: 0xFFFFFFFF75BAED54
	private static RegexCharClass ParseRecursive(String charClass, Int32 start) { }

	// RVA: 0xFFFFFFFF75BADE24
	private Int32 RangeCount() { }

	// RVA: 0xFFFFFFFF72394590
	internal String ToStringClass() { }

	// RVA: 0xFFFFFFFF75BADE44
	private SingleRange GetRangeAt(Int32 i) { }

	// RVA: 0xFFFFFFFF75BAEF18
	private Void Canonicalize() { }

	// RVA: 0xFFFFFFFF75BAE1E8
	private static String SetFromProperty(String capname, Boolean invert, String pattern) { }

}

// Namespace: 
private struct LowerCaseMapping
{
	// Fields
	internal Char _chMin; // 0x10
	internal Char _chMax; // 0x12
	internal Int32 _lcOp; // 0x14
	internal Int32 _data; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF71148990
	internal Void .ctor(Char chMin, Char chMax, Int32 lcOp, Int32 data) { }

}

// Namespace: 
private sealed class SingleRangeComparer
{
	// Methods

	// RVA: 0xFFFFFFFF75BAF08C
	public Int32 Compare(SingleRange x, SingleRange y) { }

	// RVA: 0xFFFFFFFF75BAF088
	public Void .ctor() { }

}

// Namespace: 
private sealed class SingleRange
{
	// Fields
	internal Char _first; // 0x10
	internal Char _last; // 0x12

	// Methods

	// RVA: 0xFFFFFFFF75BAE038
	internal Void .ctor(Char first, Char last) { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexCode
{
	// Fields
	internal const Int32 Onerep = 0;
	internal const Int32 Notonerep = 1;
	internal const Int32 Setrep = 2;
	internal const Int32 Oneloop = 3;
	internal const Int32 Notoneloop = 4;
	internal const Int32 Setloop = 5;
	internal const Int32 Onelazy = 6;
	internal const Int32 Notonelazy = 7;
	internal const Int32 Setlazy = 8;
	internal const Int32 One = 9;
	internal const Int32 Notone = 10;
	internal const Int32 Set = 11;
	internal const Int32 Multi = 12;
	internal const Int32 Ref = 13;
	internal const Int32 Bol = 14;
	internal const Int32 Eol = 15;
	internal const Int32 Boundary = 16;
	internal const Int32 Nonboundary = 17;
	internal const Int32 Beginning = 18;
	internal const Int32 Start = 19;
	internal const Int32 EndZ = 20;
	internal const Int32 End = 21;
	internal const Int32 Nothing = 22;
	internal const Int32 Lazybranch = 23;
	internal const Int32 Branchmark = 24;
	internal const Int32 Lazybranchmark = 25;
	internal const Int32 Nullcount = 26;
	internal const Int32 Setcount = 27;
	internal const Int32 Branchcount = 28;
	internal const Int32 Lazybranchcount = 29;
	internal const Int32 Nullmark = 30;
	internal const Int32 Setmark = 31;
	internal const Int32 Capturemark = 32;
	internal const Int32 Getmark = 33;
	internal const Int32 Setjump = 34;
	internal const Int32 Backjump = 35;
	internal const Int32 Forejump = 36;
	internal const Int32 Testref = 37;
	internal const Int32 Goto = 38;
	internal const Int32 Prune = 39;
	internal const Int32 Stop = 40;
	internal const Int32 ECMABoundary = 41;
	internal const Int32 NonECMABoundary = 42;
	internal const Int32 Mask = 63;
	internal const Int32 Rtl = 64;
	internal const Int32 Back = 128;
	internal const Int32 Back2 = 256;
	internal const Int32 Ci = 512;
	internal Int32[] _codes; // 0x10
	internal String[] _strings; // 0x18
	internal Int32 _trackcount; // 0x20
	internal Hashtable _caps; // 0x28
	internal Int32 _capsize; // 0x30
	internal RegexPrefix _fcPrefix; // 0x38
	internal RegexBoyerMoore _bmPrefix; // 0x40
	internal Int32 _anchors; // 0x48
	internal Boolean _rightToLeft; // 0x4C

	// Methods

	// RVA: 0xFFFFFFFF75BAF0BC
	internal Void .ctor(Int32[] codes, List<T0> stringlist, Int32 trackcount, Hashtable caps, Int32 capsize, RegexBoyerMoore bmPrefix, RegexPrefix fcPrefix, Int32 anchors, Boolean rightToLeft) { }

	// RVA: 0xFFFFFFFF72394870
	internal static Boolean OpcodeBacktracks(Int32 Op) { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexFCD
{
	// Fields
	private Int32[] _intStack; // 0x10
	private Int32 _intDepth; // 0x18
	private RegexFC[] _fcStack; // 0x20
	private Int32 _fcDepth; // 0x28
	private Boolean _skipAllChildren; // 0x2C
	private Boolean _skipchild; // 0x2D
	private Boolean _failed; // 0x2E

	// Methods

	// RVA: 0xFFFFFFFF75BAF480
	internal static RegexPrefix FirstChars(RegexTree t) { }

	// RVA: 0xFFFFFFFF723949FC
	internal static RegexPrefix Prefix(RegexTree tree) { }

	// RVA: 0xFFFFFFFF72394C38
	internal static Int32 Anchors(RegexTree tree) { }

	// RVA: 0xFFFFFFFF75BAF688
	private static Int32 AnchorFromType(Int32 type) { }

	// RVA: 0xFFFFFFFF75BAF578
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF72394D90
	private Void PushInt(Int32 I) { }

	// RVA: 0xFFFFFFFF75BAF6F8
	private Boolean IntIsEmpty() { }

	// RVA: 0xFFFFFFFF72394E68
	private Int32 PopInt() { }

	// RVA: 0xFFFFFFFF75BAF708
	private Void PushFC(RegexFC fc) { }

	// RVA: 0xFFFFFFFF75BAF80C
	private Boolean FCIsEmpty() { }

	// RVA: 0xFFFFFFFF75BAF81C
	private RegexFC PopFC() { }

	// RVA: 0xFFFFFFFF75BAF864
	private RegexFC TopFC() { }

	// RVA: 0xFFFFFFFF72394894
	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	// RVA: 0xFFFFFFFF75BAF8A8
	private Void SkipChild() { }

	// RVA: 0xFFFFFFFF72394EB0
	private Void CalculateFC(Int32 NodeType, RegexNode node, Int32 CurIndex) { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexFC
{
	// Fields
	internal RegexCharClass _cc; // 0x10
	internal Boolean _nullable; // 0x18
	internal Boolean _caseInsensitive; // 0x19

	// Methods

	// RVA: 0xFFFFFFFF75BAF1E8
	internal Void .ctor(Boolean nullable) { }

	// RVA: 0xFFFFFFFF75BAF244
	internal Void .ctor(Char ch, Boolean not, Boolean nullable, Boolean caseInsensitive) { }

	// RVA: 0xFFFFFFFF75BAF31C
	internal Void .ctor(String charClass, Boolean nullable, Boolean caseInsensitive) { }

	// RVA: 0xFFFFFFFF75BAF39C
	internal Boolean AddFC(RegexFC fc, Boolean concatenate) { }

	// RVA: 0xFFFFFFFF75BAF438
	internal String GetFirstChars(CultureInfo culture) { }

	// RVA: 0xFFFFFFFF75BAF478
	internal Boolean IsCaseInsensitive() { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexPrefix
{
	// Fields
	internal String _prefix; // 0x10
	internal Boolean _caseInsensitive; // 0x18
	internal static RegexPrefix _empty; // 0x0

	// Properties
	internal String Prefix { get; }
	internal Boolean CaseInsensitive { get; }
	internal static RegexPrefix Empty { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BAF5EC
	internal Void .ctor(String prefix, Boolean ci) { }

	// RVA: 0xFFFFFFFF75BB40D4
	internal String get_Prefix() { }

	// RVA: 0xFFFFFFFF75BB40DC
	internal Boolean get_CaseInsensitive() { }

	// RVA: 0xFFFFFFFF75BB40E4
	internal static RegexPrefix get_Empty() { }

	// RVA: 0xFFFFFFFF75BB4124
	private static Void .cctor() { }

}

// Namespace: System.Text.RegularExpressions
public class Group
{
	// Fields
	internal static Group _emptygroup; // 0x0
	internal Int32[] _caps; // 0x20
	internal Int32 _capcount; // 0x28
	internal CaptureCollection _capcoll; // 0x30
	internal String _name; // 0x38

	// Properties
	public Boolean Success { get; }
	public CaptureCollection Captures { get; }

	// Methods

	// RVA: 0xFFFFFFFF723908A4
	internal Void .ctor(String text, Int32[] caps, Int32 capcount, String name) { }

	// RVA: 0xFFFFFFFF723909A0
	public Boolean get_Success() { }

	// RVA: 0xFFFFFFFF75BA5EC8
	public CaptureCollection get_Captures() { }

	// RVA: 0xFFFFFFFF75BA5F54
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75BA5FFC
	internal Void .ctor() { }

}

// Namespace: System.Text.RegularExpressions
public class GroupCollection
{
	// Fields
	internal Match _match; // 0x10
	internal Hashtable _captureMap; // 0x18
	internal Group[] _groups; // 0x20

	// Properties
	public Object SyncRoot { get; }
	public Boolean IsSynchronized { get; }
	public Int32 Count { get; }
	public Group Item { get; }
	public Group Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BA6034
	internal Void .ctor(Match match, Hashtable caps) { }

	// RVA: 0xFFFFFFFF75BA6098
	public Object get_SyncRoot() { }

	// RVA: 0xFFFFFFFF75BA60A0
	public Boolean get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75BA60A8
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75BA60D0
	public Group get_Item(Int32 groupnum) { }

	// RVA: 0xFFFFFFFF75BA61B8
	public Group get_Item(String groupname) { }

	// RVA: 0xFFFFFFFF75BA60D4
	internal Group GetGroup(Int32 groupnum) { }

	// RVA: 0xFFFFFFFF723909B0
	internal Group GetGroupImpl(Int32 groupnum) { }

	// RVA: 0xFFFFFFFF75BA6470
	public Void CopyTo(Array array, Int32 arrayIndex) { }

	// RVA: 0xFFFFFFFF75BA654C
	public IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75BA6608
	internal Void .ctor() { }

}

// Namespace: System.Text.RegularExpressions
internal class GroupEnumerator
{
	// Fields
	internal GroupCollection _rgc; // 0x10
	internal Int32 _curindex; // 0x18

	// Properties
	public Object Current { get; }
	public Capture Capture { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BA65C8
	internal Void .ctor(GroupCollection rgc) { }

	// RVA: 0xFFFFFFFF75BA6640
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75BA6694
	public Object get_Current() { }

	// RVA: 0xFFFFFFFF75BA6698
	public Capture get_Capture() { }

	// RVA: 0xFFFFFFFF75BA6738
	public Void Reset() { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexInterpreter
{
	// Fields
	internal Int32 runoperator; // 0x80
	internal Int32[] runcodes; // 0x88
	internal Int32 runcodepos; // 0x90
	internal String[] runstrings; // 0x98
	internal RegexCode runcode; // 0xA0
	internal RegexPrefix runfcPrefix; // 0xA8
	internal RegexBoyerMoore runbmPrefix; // 0xB0
	internal Int32 runanchors; // 0xB8
	internal Boolean runrtl; // 0xBC
	internal Boolean runci; // 0xBD
	internal CultureInfo runculture; // 0xC0

	// Methods

	// RVA: 0xFFFFFFFF75BA96D8
	internal Void .ctor(RegexCode code, CultureInfo culture) { }

	// RVA: 0xFFFFFFFF75BAF8B8
	protected override Void InitTrackCount() { }

	// RVA: 0xFFFFFFFF75BAF8DC
	private Void Advance() { }

	// RVA: 0xFFFFFFFF723952AC
	private Void Advance(Int32 i) { }

	// RVA: 0xFFFFFFFF72395314
	private Void Goto(Int32 newpos) { }

	// RVA: 0xFFFFFFFF75BAF904
	private Void Textto(Int32 newpos) { }

	// RVA: 0xFFFFFFFF75BAF90C
	private Void Trackto(Int32 newpos) { }

	// RVA: 0xFFFFFFFF75BAF934
	private Int32 Textstart() { }

	// RVA: 0xFFFFFFFF75BAF93C
	private Int32 Textpos() { }

	// RVA: 0xFFFFFFFF75BAF944
	private Int32 Trackpos() { }

	// RVA: 0xFFFFFFFF72395434
	private Void TrackPush() { }

	// RVA: 0xFFFFFFFF72395480
	private Void TrackPush(Int32 I1) { }

	// RVA: 0xFFFFFFFF723954E8
	private Void TrackPush(Int32 I1, Int32 I2) { }

	// RVA: 0xFFFFFFFF75BAF96C
	private Void TrackPush(Int32 I1, Int32 I2, Int32 I3) { }

	// RVA: 0xFFFFFFFF75BAFA0C
	private Void TrackPush2(Int32 I1) { }

	// RVA: 0xFFFFFFFF75BAFA78
	private Void TrackPush2(Int32 I1, Int32 I2) { }

	// RVA: 0xFFFFFFFF7239556C
	private Void Backtrack() { }

	// RVA: 0xFFFFFFFF75BAF8E4
	private Void SetOperator(Int32 op) { }

	// RVA: 0xFFFFFFFF75BAFB00
	private Void TrackPop() { }

	// RVA: 0xFFFFFFFF75BAFB10
	private Void TrackPop(Int32 framesize) { }

	// RVA: 0xFFFFFFFF723956A0
	private Int32 TrackPeek() { }

	// RVA: 0xFFFFFFFF723956E4
	private Int32 TrackPeek(Int32 i) { }

	// RVA: 0xFFFFFFFF7239572C
	private Void StackPush(Int32 I1) { }

	// RVA: 0xFFFFFFFF75BAFB20
	private Void StackPush(Int32 I1, Int32 I2) { }

	// RVA: 0xFFFFFFFF75BAFB84
	private Void StackPop() { }

	// RVA: 0xFFFFFFFF75BAFB94
	private Void StackPop(Int32 framesize) { }

	// RVA: 0xFFFFFFFF72395774
	private Int32 StackPeek() { }

	// RVA: 0xFFFFFFFF75BAFBA4
	private Int32 StackPeek(Int32 i) { }

	// RVA: 0xFFFFFFFF75BAFBEC
	private Int32 Operator() { }

	// RVA: 0xFFFFFFFF723957B8
	private Int32 Operand(Int32 i) { }

	// RVA: 0xFFFFFFFF75BAFBF4
	private Int32 Leftchars() { }

	// RVA: 0xFFFFFFFF75BAFC04
	private Int32 Rightchars() { }

	// RVA: 0xFFFFFFFF75BAFC14
	private Int32 Bump() { }

	// RVA: 0xFFFFFFFF75BAFC28
	private Int32 Forwardchars() { }

	// RVA: 0xFFFFFFFF72395800
	private Char Forwardcharnext() { }

	// RVA: 0xFFFFFFFF723958C8
	private Boolean Stringmatch(String str) { }

	// RVA: 0xFFFFFFFF75BAFC54
	private Boolean Refmatch(Int32 index, Int32 len) { }

	// RVA: 0xFFFFFFFF75BAFDBC
	private Void Backwardnext() { }

	// RVA: 0xFFFFFFFF75BAFDEC
	private Char CharAt(Int32 j) { }

	// RVA: 0xFFFFFFFF72395ABC
	protected override Boolean FindFirstChar() { }

	// RVA: 0xFFFFFFFF72395EF8
	protected override Void Go() { }

}

// Namespace: System.Text.RegularExpressions
public class Match
{
	// Fields
	internal static Match _empty; // 0x0
	internal GroupCollection _groupcoll; // 0x40
	internal Regex _regex; // 0x48
	internal Int32 _textbeg; // 0x50
	internal Int32 _textpos; // 0x54
	internal Int32 _textend; // 0x58
	internal Int32 _textstart; // 0x5C
	internal Int32[][] _matches; // 0x60
	internal Int32[] _matchcount; // 0x68
	internal Boolean _balancing; // 0x70

	// Properties
	public static Match Empty { get; }
	public virtual GroupCollection Groups { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BA6744
	public static Match get_Empty() { }

	// RVA: 0xFFFFFFFF72390B84
	internal Void .ctor(Regex regex, Int32 capcount, String text, Int32 begpos, Int32 len, Int32 startpos) { }

	// RVA: 0xFFFFFFFF72390D40
	internal virtual Void Reset(Regex regex, String text, Int32 textbeg, Int32 textend, Int32 textstart) { }

	// RVA: 0xFFFFFFFF75BA6784
	public virtual GroupCollection get_Groups() { }

	// RVA: 0xFFFFFFFF75BA683C
	public Match NextMatch() { }

	// RVA: 0xFFFFFFFF75BA686C
	public virtual String Result(String replacement) { }

	// RVA: 0xFFFFFFFF75BA6C0C
	internal virtual String GroupToStringImpl(Int32 groupnum) { }

	// RVA: 0xFFFFFFFF75BA6CC4
	internal String LastGroupToStringImpl() { }

	// RVA: 0xFFFFFFFF7239110C
	internal virtual Void AddMatch(Int32 cap, Int32 start, Int32 len) { }

	// RVA: 0xFFFFFFFF75BA6CF4
	internal virtual Void BalanceMatch(Int32 cap) { }

	// RVA: 0xFFFFFFFF72391334
	internal virtual Void RemoveMatch(Int32 cap) { }

	// RVA: 0xFFFFFFFF75BA6DD4
	internal virtual Boolean IsMatched(Int32 cap) { }

	// RVA: 0xFFFFFFFF75BA6E70
	internal virtual Int32 MatchIndex(Int32 cap) { }

	// RVA: 0xFFFFFFFF75BA6F0C
	internal virtual Int32 MatchLength(Int32 cap) { }

	// RVA: 0xFFFFFFFF72391378
	internal virtual Void Tidy(Int32 textpos) { }

	// RVA: 0xFFFFFFFF75BA6FA8
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75BA702C
	internal Void .ctor() { }

}

// Namespace: System.Text.RegularExpressions
internal class MatchSparse
{
	// Fields
	internal Hashtable _caps; // 0x78

	// Properties
	public override GroupCollection Groups { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BA78EC
	internal Void .ctor(Regex regex, Hashtable caps, Int32 capcount, String text, Int32 begpos, Int32 len, Int32 startpos) { }

	// RVA: 0xFFFFFFFF75BA79A0
	public override GroupCollection get_Groups() { }

}

// Namespace: System.Text.RegularExpressions
public class MatchCollection
{
	// Fields
	internal Regex _regex; // 0x10
	internal ArrayList _matches; // 0x18
	internal Boolean _done; // 0x20
	internal String _input; // 0x28
	internal Int32 _beginning; // 0x30
	internal Int32 _length; // 0x34
	internal Int32 _startat; // 0x38
	internal Int32 _prevlen; // 0x3C
	private static Int32 infinite; // 0x0

	// Properties
	public Int32 Count { get; }
	public Object SyncRoot { get; }
	public Boolean IsSynchronized { get; }
	public virtual Match Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF723914E4
	internal Void .ctor(Regex regex, String input, Int32 beginning, Int32 length, Int32 startat) { }

	// RVA: 0xFFFFFFFF7239162C
	internal Match GetMatch(Int32 i) { }

	// RVA: 0xFFFFFFFF72391764
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75BA7064
	public Object get_SyncRoot() { }

	// RVA: 0xFFFFFFFF75BA7068
	public Boolean get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75BA7070
	public virtual Match get_Item(Int32 i) { }

	// RVA: 0xFFFFFFFF75BA7104
	public Void CopyTo(Array array, Int32 arrayIndex) { }

	// RVA: 0xFFFFFFFF75BA7288
	public IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75BA7334
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75BA734C
	internal Void .ctor() { }

}

// Namespace: System.Text.RegularExpressions
internal class MatchEnumerator
{
	// Fields
	internal MatchCollection _matchcoll; // 0x10
	internal Match _match; // 0x18
	internal Int32 _curindex; // 0x20
	internal Boolean _done; // 0x24

	// Properties
	public Object Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BA72FC
	internal Void .ctor(MatchCollection matchcoll) { }

	// RVA: 0xFFFFFFFF75BA7384
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75BA73FC
	public Object get_Current() { }

	// RVA: 0xFFFFFFFF75BA7478
	public Void Reset() { }

}

// Namespace: System.Text.RegularExpressions
public class RegexMatchTimeoutException
{
	// Fields
	private String regexInput; // 0x88
	private String regexPattern; // 0x90
	private TimeSpan matchTimeout; // 0x98

	// Methods

	// RVA: 0xFFFFFFFF75BB016C
	public Void .ctor(String regexInput, String regexPattern, TimeSpan matchTimeout) { }

	// RVA: 0xFFFFFFFF75BB02A8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BB0394
	protected Void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF75BB04DC
	private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0xFFFFFFFF75BB0300
	private Void Init() { }

	// RVA: 0xFFFFFFFF75BB0240
	private Void Init(String input, String pattern, TimeSpan timeout) { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexNode
{
	// Fields
	internal Int32 _type; // 0x10
	internal List<T0> _children; // 0x18
	internal String _str; // 0x20
	internal Char _ch; // 0x28
	internal Int32 _m; // 0x2C
	internal Int32 _n; // 0x30
	internal RegexOptions _options; // 0x34
	internal RegexNode _next; // 0x38

	// Methods

	// RVA: 0xFFFFFFFF75BB05B0
	internal Void .ctor(Int32 type, RegexOptions options) { }

	// RVA: 0xFFFFFFFF75BB05BC
	internal Void .ctor(Int32 type, RegexOptions options, Char ch) { }

	// RVA: 0xFFFFFFFF75BB05CC
	internal Void .ctor(Int32 type, RegexOptions options, String str) { }

	// RVA: 0xFFFFFFFF75BB060C
	internal Void .ctor(Int32 type, RegexOptions options, Int32 m) { }

	// RVA: 0xFFFFFFFF75BB061C
	internal Void .ctor(Int32 type, RegexOptions options, Int32 m, Int32 n) { }

	// RVA: 0xFFFFFFFF7239886C
	internal Boolean UseOptionR() { }

	// RVA: 0xFFFFFFFF75BB062C
	internal RegexNode ReverseLeft() { }

	// RVA: 0xFFFFFFFF75BB067C
	internal Void MakeRep(Int32 type, Int32 min, Int32 max) { }

	// RVA: 0xFFFFFFFF72398878
	internal RegexNode Reduce() { }

	// RVA: 0xFFFFFFFF72399158
	internal RegexNode StripEnation(Int32 emptyType) { }

	// RVA: 0xFFFFFFFF75BB07AC
	internal RegexNode ReduceGroup() { }

	// RVA: 0xFFFFFFFF75BB0694
	internal RegexNode ReduceRep() { }

	// RVA: 0xFFFFFFFF7239903C
	internal RegexNode ReduceSet() { }

	// RVA: 0xFFFFFFFF723988D8
	internal RegexNode ReduceAlternation() { }

	// RVA: 0xFFFFFFFF72398CCC
	internal RegexNode ReduceConcatenation() { }

	// RVA: 0xFFFFFFFF723991B0
	internal RegexNode MakeQuantifier(Boolean lazy, Int32 min, Int32 max) { }

	// RVA: 0xFFFFFFFF7239928C
	internal Void AddChild(RegexNode newChild) { }

	// RVA: 0xFFFFFFFF75BAF64C
	internal RegexNode Child(Int32 i) { }

	// RVA: 0xFFFFFFFF75BAF634
	internal Int32 ChildCount() { }

	// RVA: 0xFFFFFFFF75BB07F4
	internal Int32 Type() { }

}

// Namespace: System.Text.RegularExpressions
public enum RegexOptions
{
	// Fields
	public Int32 value__; // 0x10
	public const RegexOptions None = 0;
	public const RegexOptions IgnoreCase = 1;
	public const RegexOptions Multiline = 2;
	public const RegexOptions ExplicitCapture = 4;
	public const RegexOptions Compiled = 8;
	public const RegexOptions Singleline = 16;
	public const RegexOptions IgnorePatternWhitespace = 32;
	public const RegexOptions RightToLeft = 64;
	public const RegexOptions ECMAScript = 256;
	public const RegexOptions CultureInvariant = 512;
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexParser
{
	// Fields
	internal RegexNode _stack; // 0x10
	internal RegexNode _group; // 0x18
	internal RegexNode _alternation; // 0x20
	internal RegexNode _concatenation; // 0x28
	internal RegexNode _unit; // 0x30
	internal String _pattern; // 0x38
	internal Int32 _currentPos; // 0x40
	internal CultureInfo _culture; // 0x48
	internal Int32 _autocap; // 0x50
	internal Int32 _capcount; // 0x54
	internal Int32 _captop; // 0x58
	internal Int32 _capsize; // 0x5C
	internal Hashtable _caps; // 0x60
	internal Hashtable _capnames; // 0x68
	internal Int32[] _capnumlist; // 0x70
	internal List<T0> _capnamelist; // 0x78
	internal RegexOptions _options; // 0x80
	internal List<T0> _optionsStack; // 0x88
	internal Boolean _ignoreNextParen; // 0x90
	internal static readonly Byte[] _category; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75BA7B80
	internal static RegexTree Parse(String re, RegexOptions op) { }

	// RVA: 0xFFFFFFFF75BA69EC
	internal static RegexReplacement ParseReplacement(String rep, Hashtable caps, Int32 capsize, Hashtable capnames, RegexOptions op) { }

	// RVA: 0xFFFFFFFF75BA8520
	internal static String Escape(String input) { }

	// RVA: 0xFFFFFFFF72399420
	private Void .ctor(CultureInfo culture) { }

	// RVA: 0xFFFFFFFF75BB07FC
	internal Void SetPattern(String Re) { }

	// RVA: 0xFFFFFFFF75BB084C
	internal Void Reset(RegexOptions topopts) { }

	// RVA: 0xFFFFFFFF723998A0
	internal RegexNode ScanRegex() { }

	// RVA: 0xFFFFFFFF75BB0A20
	internal RegexNode ScanReplacement() { }

	// RVA: 0xFFFFFFFF75BB1354
	internal RegexCharClass ScanCharClass(Boolean caseInsensitive) { }

	// RVA: 0xFFFFFFFF7239ADDC
	internal RegexCharClass ScanCharClass(Boolean caseInsensitive, Boolean scanOnly) { }

	// RVA: 0xFFFFFFFF75BB140C
	internal RegexNode ScanGroupOpen() { }

	// RVA: 0xFFFFFFFF7239A204
	internal Void ScanBlank() { }

	// RVA: 0xFFFFFFFF7239A85C
	internal RegexNode ScanBackslash() { }

	// RVA: 0xFFFFFFFF75BB2FA4
	internal RegexNode ScanBasicBackslash() { }

	// RVA: 0xFFFFFFFF75BB2508
	internal RegexNode ScanDollar() { }

	// RVA: 0xFFFFFFFF75BB2BDC
	internal String ScanCapname() { }

	// RVA: 0xFFFFFFFF75BB34F0
	internal Char ScanOctal() { }

	// RVA: 0xFFFFFFFF75BB2450
	internal Int32 ScanDecimal() { }

	// RVA: 0xFFFFFFFF75BB35A0
	internal Char ScanHex(Int32 c) { }

	// RVA: 0xFFFFFFFF75BB36B4
	internal static Int32 HexDigit(Char ch) { }

	// RVA: 0xFFFFFFFF75BB36E4
	internal Char ScanControl() { }

	// RVA: 0xFFFFFFFF75BB37B8
	internal Boolean IsOnlyTopOption(RegexOptions option) { }

	// RVA: 0xFFFFFFFF75BB2DA8
	internal Void ScanOptions() { }

	// RVA: 0xFFFFFFFF75BB2A34
	internal Char ScanCharEscape() { }

	// RVA: 0xFFFFFFFF75BB28B8
	internal String ParseProperty() { }

	// RVA: 0xFFFFFFFF75BB2F18
	internal Int32 TypeFromCode(Char ch) { }

	// RVA: 0xFFFFFFFF75BB37D8
	internal static RegexOptions OptionFromCode(Char ch) { }

	// RVA: 0xFFFFFFFF72399534
	internal Void CountCaptures() { }

	// RVA: 0xFFFFFFFF75BB3838
	internal Void NoteCaptureSlot(Int32 i, Int32 pos) { }

	// RVA: 0xFFFFFFFF75BB3940
	internal Void NoteCaptureName(String name, Int32 pos) { }

	// RVA: 0xFFFFFFFF75BB09B4
	internal Void NoteCaptures(Hashtable caps, Int32 capsize, Hashtable capnames) { }

	// RVA: 0xFFFFFFFF75BB3A60
	internal Void AssignNameSlots() { }

	// RVA: 0xFFFFFFFF75BB2D54
	internal Int32 CaptureSlotFromName(String capname) { }

	// RVA: 0xFFFFFFFF75BB2CC8
	internal Boolean IsCaptureSlot(Int32 i) { }

	// RVA: 0xFFFFFFFF75BB2D38
	internal Boolean IsCaptureName(String capname) { }

	// RVA: 0xFFFFFFFF75BB2CBC
	internal Boolean UseOptionN() { }

	// RVA: 0xFFFFFFFF75BB1348
	internal Boolean UseOptionI() { }

	// RVA: 0xFFFFFFFF75BB22F0
	internal Boolean UseOptionM() { }

	// RVA: 0xFFFFFFFF75BB235C
	internal Boolean UseOptionS() { }

	// RVA: 0xFFFFFFFF75BB0F88
	internal Boolean UseOptionX() { }

	// RVA: 0xFFFFFFFF75BB28AC
	internal Boolean UseOptionE() { }

	// RVA: 0xFFFFFFFF7239A724
	internal static Boolean IsSpecial(Char ch) { }

	// RVA: 0xFFFFFFFF75BB0FF4
	internal static Boolean IsStopperX(Char ch) { }

	// RVA: 0xFFFFFFFF7239A7C0
	internal static Boolean IsQuantifier(Char ch) { }

	// RVA: 0xFFFFFFFF7239A574
	internal Boolean IsTrueQuantifier() { }

	// RVA: 0xFFFFFFFF75BB2E94
	internal static Boolean IsSpace(Char ch) { }

	// RVA: 0xFFFFFFFF75BB0E54
	internal static Boolean IsMetachar(Char ch) { }

	// RVA: 0xFFFFFFFF75BB1078
	internal Void AddConcatenate(Int32 pos, Int32 cch, Boolean isReplacement) { }

	// RVA: 0xFFFFFFFF75BB1D74
	internal Void PushGroup() { }

	// RVA: 0xFFFFFFFF75BB2178
	internal Void PopGroup() { }

	// RVA: 0xFFFFFFFF75BB1F3C
	internal Boolean EmptyStack() { }

	// RVA: 0xFFFFFFFF75BB0ED8
	internal Void StartGroup(RegexNode openGroup) { }

	// RVA: 0xFFFFFFFF75BB1E30
	internal Void AddAlternate() { }

	// RVA: 0xFFFFFFFF7239AD34
	internal Void AddConcatenate() { }

	// RVA: 0xFFFFFFFF7239AD80
	internal Void AddConcatenate(Boolean lazy, Int32 min, Int32 max) { }

	// RVA: 0xFFFFFFFF75BB4020
	internal RegexNode Unit() { }

	// RVA: 0xFFFFFFFF75BB12A0
	internal Void AddUnitOne(Char ch) { }

	// RVA: 0xFFFFFFFF75BB2368
	internal Void AddUnitNotone(Char ch) { }

	// RVA: 0xFFFFFFFF75BB135C
	internal Void AddUnitSet(String cc) { }

	// RVA: 0xFFFFFFFF75BB4028
	internal Void AddUnitNode(RegexNode node) { }

	// RVA: 0xFFFFFFFF75BB22FC
	internal Void AddUnitType(Int32 type) { }

	// RVA: 0xFFFFFFFF75BB201C
	internal Void AddGroup() { }

	// RVA: 0xFFFFFFFF75BB13E0
	internal Void PushOptions() { }

	// RVA: 0xFFFFFFFF75BB22A4
	internal Void PopOptions() { }

	// RVA: 0xFFFFFFFF75BB3918
	internal Boolean EmptyOptionsStack() { }

	// RVA: 0xFFFFFFFF75BB1D48
	internal Void PopKeepOptions() { }

	// RVA: 0xFFFFFFFF75BB1F4C
	internal ArgumentException MakeException(String message) { }

	// RVA: 0xFFFFFFFF75BB4060
	internal Int32 Textpos() { }

	// RVA: 0xFFFFFFFF75BB4068
	internal Void Textto(Int32 pos) { }

	// RVA: 0xFFFFFFFF75BB2420
	internal Char MoveRightGetChar() { }

	// RVA: 0xFFFFFFFF75BB0F94
	internal Void MoveRight() { }

	// RVA: 0xFFFFFFFF75BB2CAC
	internal Void MoveRight(Int32 i) { }

	// RVA: 0xFFFFFFFF75BB2410
	internal Void MoveLeft() { }

	// RVA: 0xFFFFFFFF75BB1280
	internal Char CharAt(Int32 i) { }

	// RVA: 0xFFFFFFFF75BB0FCC
	internal Char RightChar() { }

	// RVA: 0xFFFFFFFF75BB2C80
	internal Char RightChar(Int32 i) { }

	// RVA: 0xFFFFFFFF75BB0FA4
	internal Int32 CharsRight() { }

	// RVA: 0xFFFFFFFF75BB4070
	private static Void .cctor() { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexReplacement
{
	// Fields
	internal String _rep; // 0x10
	internal List<T0> _strings; // 0x18
	internal List<T0> _rules; // 0x20

	// Properties
	internal String Pattern { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BB0B64
	internal Void .ctor(String rep, RegexNode concat, Hashtable _caps) { }

	// RVA: 0xFFFFFFFF7239B3B0
	private Void ReplacementImpl(StringBuilder sb, Match match) { }

	// RVA: 0xFFFFFFFF7239B530
	private Void ReplacementImplRTL(List<T0> al, Match match) { }

	// RVA: 0xFFFFFFFF75BB41AC
	internal String get_Pattern() { }

	// RVA: 0xFFFFFFFF75BA6BAC
	internal String Replacement(Match match) { }

	// RVA: 0xFFFFFFFF723927C0
	internal String Replace(Regex regex, String input, Int32 count, Int32 startat) { }

	// RVA: 0xFFFFFFFF75BA8C6C
	internal static String Replace(MatchEvaluator evaluator, Regex regex, String input, Int32 count, Int32 startat) { }

	// RVA: 0xFFFFFFFF75BA9248
	internal static String[] Split(Regex regex, String input, Int32 count, Int32 startat) { }

}

// Namespace: System.Text.RegularExpressions
public abstract class RegexRunner
{
	// Fields
	protected internal Int32 runtextbeg; // 0x10
	protected internal Int32 runtextend; // 0x14
	protected internal Int32 runtextstart; // 0x18
	protected internal String runtext; // 0x20
	protected internal Int32 runtextpos; // 0x28
	protected internal Int32[] runtrack; // 0x30
	protected internal Int32 runtrackpos; // 0x38
	protected internal Int32[] runstack; // 0x40
	protected internal Int32 runstackpos; // 0x48
	protected internal Int32[] runcrawl; // 0x50
	protected internal Int32 runcrawlpos; // 0x58
	protected internal Int32 runtrackcount; // 0x5C
	protected internal Match runmatch; // 0x60
	protected internal Regex runregex; // 0x68
	private Int32 timeout; // 0x70
	private Boolean ignoreTimeout; // 0x74
	private Int32 timeoutOccursAt; // 0x78
	private const Int32 TimeoutCheckFrequency = 1000;
	private Int32 timeoutChecksToSkip; // 0x7C

	// Methods

	// RVA: 0xFFFFFFFF75BAF8B4
	protected internal Void .ctor() { }

	// RVA: 0xFFFFFFFF72392A90
	protected internal Match Scan(Regex regex, String text, Int32 textbeg, Int32 textend, Int32 textstart, Int32 prevlen, Boolean quick, TimeSpan timeout) { }

	// RVA: 0xFFFFFFFF75BB41B4
	private Void StartTimeoutWatch() { }

	// RVA: 0xFFFFFFFF72398750
	protected Void CheckTimeout() { }

	// RVA: 0xFFFFFFFF75BB41F4
	private Void DoCheckTimeout() { }

	// RVA: -1
	protected abstract Void Go() { }

	// RVA: -1
	protected abstract Boolean FindFirstChar() { }

	// RVA: -1
	protected abstract Void InitTrackCount() { }

	// RVA: 0xFFFFFFFF7239B770
	private Void InitMatch() { }

	// RVA: 0xFFFFFFFF7239B970
	private Match TidyMatch(Boolean quick) { }

	// RVA: 0xFFFFFFFF723953DC
	protected Void EnsureStorage() { }

	// RVA: 0xFFFFFFFF75BAFF74
	protected Boolean IsBoundary(Int32 index, Int32 startpos, Int32 endpos) { }

	// RVA: 0xFFFFFFFF75BB0048
	protected Boolean IsECMABoundary(Int32 index, Int32 startpos, Int32 endpos) { }

	// RVA: 0xFFFFFFFF75BB4374
	protected Void DoubleTrack() { }

	// RVA: 0xFFFFFFFF75BB42D8
	protected Void DoubleStack() { }

	// RVA: 0xFFFFFFFF75BB4410
	protected Void DoubleCrawl() { }

	// RVA: 0xFFFFFFFF7239B9E4
	protected Void Crawl(Int32 i) { }

	// RVA: 0xFFFFFFFF7239BA54
	protected Int32 Popcrawl() { }

	// RVA: 0xFFFFFFFF75BAFF4C
	protected Int32 Crawlpos() { }

	// RVA: 0xFFFFFFFF72398778
	protected Void Capture(Int32 capnum, Int32 start, Int32 end) { }

	// RVA: 0xFFFFFFFF75BAFE34
	protected Void TransferCapture(Int32 capnum, Int32 uncapnum, Int32 start, Int32 end) { }

	// RVA: 0xFFFFFFFF72398810
	protected Void Uncapture() { }

	// RVA: 0xFFFFFFFF75BAFE0C
	protected Boolean IsMatched(Int32 cap) { }

	// RVA: 0xFFFFFFFF75BB011C
	protected Int32 MatchIndex(Int32 cap) { }

	// RVA: 0xFFFFFFFF75BB0144
	protected Int32 MatchLength(Int32 cap) { }

}

// Namespace: System.Text.RegularExpressions
public abstract class RegexRunnerFactory
{
	// Methods

	// RVA: -1
	protected internal abstract RegexRunner CreateInstance() { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexTree
{
	// Fields
	internal RegexNode _root; // 0x10
	internal Hashtable _caps; // 0x18
	internal Int32[] _capnumlist; // 0x20
	internal Hashtable _capnames; // 0x28
	internal String[] _capslist; // 0x30
	internal RegexOptions _options; // 0x38
	internal Int32 _captop; // 0x3C

	// Methods

	// RVA: 0xFFFFFFFF75BB08D8
	internal Void .ctor(RegexNode root, Hashtable caps, Int32[] capnumlist, Int32 captop, Hashtable capnames, String[] capslist, RegexOptions opts) { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexWriter
{
	// Fields
	internal Int32[] _intStack; // 0x10
	internal Int32 _depth; // 0x18
	internal Int32[] _emitted; // 0x20
	internal Int32 _curpos; // 0x28
	internal Dictionary<T0, T1> _stringhash; // 0x30
	internal List<T0> _stringtable; // 0x38
	internal Boolean _counting; // 0x40
	internal Int32 _count; // 0x44
	internal Int32 _trackcount; // 0x48
	internal Hashtable _caps; // 0x50

	// Methods

	// RVA: 0xFFFFFFFF75BA7CE0
	internal static RegexCode Write(RegexTree t) { }

	// RVA: 0xFFFFFFFF75BB44AC
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF7239BF30
	internal Void PushInt(Int32 I) { }

	// RVA: 0xFFFFFFFF75BB4598
	internal Boolean EmptyStack() { }

	// RVA: 0xFFFFFFFF7239C008
	internal Int32 PopInt() { }

	// RVA: 0xFFFFFFFF75BB45A8
	internal Int32 CurPos() { }

	// RVA: 0xFFFFFFFF7239C050
	internal Void PatchJump(Int32 Offset, Int32 jumpDest) { }

	// RVA: 0xFFFFFFFF7239C090
	internal Void Emit(Int32 op) { }

	// RVA: 0xFFFFFFFF7239C128
	internal Void Emit(Int32 op, Int32 opd1) { }

	// RVA: 0xFFFFFFFF7239C1DC
	internal Void Emit(Int32 op, Int32 opd1, Int32 opd2) { }

	// RVA: 0xFFFFFFFF7239C2AC
	internal Int32 StringCode(String str) { }

	// RVA: 0xFFFFFFFF75BB45B0
	internal ArgumentException MakeException(String message) { }

	// RVA: 0xFFFFFFFF7239C430
	internal Int32 MapCapnum(Int32 capnum) { }

	// RVA: 0xFFFFFFFF7239BA9C
	internal RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	// RVA: 0xFFFFFFFF7239C4BC
	internal Void EmitFragment(Int32 nodetype, RegexNode node, Int32 CurIndex) { }

}

// Namespace: System.Diagnostics
public class BooleanSwitch
{
	// Methods

	// RVA: 0xFFFFFFFF75B3ACBC
	public Void .ctor(String displayName, String description) { }

}

// Namespace: System.Diagnostics
public abstract class Switch
{
	// Fields
	private readonly String description; // 0x10
	private readonly String displayName; // 0x18
	private String switchValueString; // 0x20
	private String defaultValue; // 0x28
	private static List<T0> switches; // 0x0
	private static Int32 s_LastCollectionCount; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75B3AD50
	protected Void .ctor(String displayName, String description) { }

	// RVA: 0xFFFFFFFF75B3CAE4
	protected Void .ctor(String displayName, String description, String defaultSwitchValue) { }

	// RVA: 0xFFFFFFFF75B3CD0C
	private static Void _pruneCachedSwitches() { }

	// RVA: 0xFFFFFFFF75B3D044
	private static Void .cctor() { }

}

// Namespace: System.Diagnostics
public sealed class SwitchLevelAttribute
{
	// Fields
	private Type type; // 0x10

	// Properties
	public Type SwitchLevelType { set; }

	// Methods

	// RVA: 0xFFFFFFFF75B3D0D0
	public Void .ctor(Type switchLevelType) { }

	// RVA: 0xFFFFFFFF75B3D100
	public Void set_SwitchLevelType(Type value) { }

}

// Namespace: System.Diagnostics
public enum TraceLevel
{
	// Fields
	public Int32 value__; // 0x10
	public const TraceLevel Off = 0;
	public const TraceLevel Error = 1;
	public const TraceLevel Warning = 2;
	public const TraceLevel Info = 3;
	public const TraceLevel Verbose = 4;
}

// Namespace: System.Diagnostics
public class TraceSwitch
{
	// Methods

	// RVA: 0xFFFFFFFF75B3D1B8
	public Void .ctor(String displayName, String description) { }

}

// Namespace: System.Diagnostics
internal class AsyncStreamReader
{
	// Fields
	private Stream stream; // 0x10
	private Encoding encoding; // 0x18
	private Decoder decoder; // 0x20
	private Byte[] byteBuffer; // 0x28
	private Char[] charBuffer; // 0x30
	private Boolean cancelOperation; // 0x38
	private ManualResetEvent eofEvent; // 0x40
	private Object syncObject; // 0x48

	// Methods

	// RVA: 0xFFFFFFFF75B3AB24
	public virtual Void Close() { }

	// RVA: 0xFFFFFFFF75B3AB38
	protected virtual Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75B3ACB0
	internal Void CancelOperation() { }

}

// Namespace: System.Diagnostics
public class Process
{
	// Fields
	private Boolean haveProcessId; // 0x28
	private Int32 processId; // 0x2C
	private Boolean haveProcessHandle; // 0x30
	private SafeProcessHandle m_processHandle; // 0x38
	private Boolean isRemoteMachine; // 0x40
	private String machineName; // 0x48
	private Int32 m_processAccess; // 0x50
	private ProcessThreadCollection threads; // 0x58
	private ProcessModuleCollection modules; // 0x60
	private Boolean haveWorkingSetLimits; // 0x68
	private Boolean havePriorityClass; // 0x69
	private Boolean watchForExit; // 0x6A
	private Boolean watchingForExit; // 0x6B
	private EventHandler onExited; // 0x70
	private Boolean exited; // 0x78
	private Int32 exitCode; // 0x7C
	private Boolean signaled; // 0x80
	private Boolean haveExitTime; // 0x81
	private Boolean raisedOnExited; // 0x82
	private RegisteredWaitHandle registeredWaitHandle; // 0x88
	private WaitHandle waitHandle; // 0x90
	private ISynchronizeInvoke synchronizingObject; // 0x98
	private StreamReader standardOutput; // 0xA0
	private StreamWriter standardInput; // 0xA8
	private StreamReader standardError; // 0xB0
	private Boolean disposed; // 0xB8
	private StreamReadMode outputStreamReadMode; // 0xBC
	private StreamReadMode errorStreamReadMode; // 0xC0
	private StreamReadMode inputStreamReadMode; // 0xC4
	internal AsyncStreamReader output; // 0xC8
	internal AsyncStreamReader error; // 0xD0
	private String process_name; // 0xD8

	// Properties
	private Boolean Associated { get; }
	public Boolean HasExited { get; }
	public ISynchronizeInvoke SynchronizingObject { get; }
	public String ProcessName { get; }
	public ProcessThreadCollection Threads { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B3AE5C
	private Void .ctor(String machineName, Boolean isRemoteMachine, Int32 processId, ProcessInfo processInfo) { }

	// RVA: 0xFFFFFFFF75B3AF28
	private Boolean get_Associated() { }

	// RVA: 0xFFFFFFFF75B3AF48
	public Boolean get_HasExited() { }

	// RVA: 0xFFFFFFFF75B3BBA4
	public ISynchronizeInvoke get_SynchronizingObject() { }

	// RVA: 0xFFFFFFFF75B3BAD4
	private Void ReleaseProcessHandle(SafeProcessHandle handle) { }

	// RVA: 0xFFFFFFFF75B3BD70
	protected override Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75B3BDC8
	public Void Close() { }

	// RVA: 0xFFFFFFFF75B3B278
	private Void EnsureState(State state) { }

	// RVA: 0xFFFFFFFF75B3C17C
	public static Process GetCurrentProcess() { }

	// RVA: 0xFFFFFFFF75B3C1F8
	protected Void OnExited() { }

	// RVA: 0xFFFFFFFF75B3B400
	private SafeProcessHandle GetProcessHandle(Int32 access, Boolean throwIfExited) { }

	// RVA: 0xFFFFFFFF75B3C444
	private SafeProcessHandle GetProcessHandle(Int32 access) { }

	// RVA: 0xFFFFFFFF75B3C11C
	public Void Refresh() { }

	// RVA: 0xFFFFFFFF75B3C00C
	private Void StopWatchingForExit() { }

	// RVA: 0xFFFFFFFF75B3C44C
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75B3C790
	private static Int64 GetProcessData(Int32 pid, Int32 data_type, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B3C794
	private static String ProcessName_internal(IntPtr handle) { }

	// RVA: 0xFFFFFFFF75B3C798
	private static String ProcessName_internal(SafeProcessHandle handle) { }

	// RVA: 0xFFFFFFFF75B3C5C0
	public String get_ProcessName() { }

	// RVA: 0xFFFFFFFF75B3C858
	public ProcessThreadCollection get_Threads() { }

	// RVA: 0xFFFFFFFF75B3BAFC
	private Void RaiseOnExited() { }

}

// Namespace: 
private enum StreamReadMode
{
	// Fields
	public Int32 value__; // 0x10
	public const StreamReadMode undefined = 0;
	public const StreamReadMode syncMode = 1;
	public const StreamReadMode asyncMode = 2;
}

// Namespace: 
private enum State
{
	// Fields
	public Int32 value__; // 0x10
	public const State HaveId = 1;
	public const State IsLocal = 2;
	public const State IsNt = 4;
	public const State HaveProcessInfo = 8;
	public const State Exited = 16;
	public const State Associated = 32;
	public const State IsWin2k = 64;
	public const State HaveNtProcessInfo = 12;
}

// Namespace: System.Diagnostics
internal class ProcessInfo
{}

// Namespace: System.Diagnostics
public class ProcessModuleCollection
{}

// Namespace: System.Diagnostics
public class ProcessThreadCollection
{
	// Methods

	// RVA: 0xFFFFFFFF75B3C950
	public Void .ctor(ProcessThread[] processThreads) { }

}

// Namespace: System.Diagnostics
internal class ProcessWaitHandle
{
	// Methods

	// RVA: 0xFFFFFFFF75B3B9A0
	internal Void .ctor(SafeProcessHandle processHandle) { }

}

// Namespace: System.Diagnostics
public class MonitoringDescriptionAttribute
{
	// Properties
	public override String Description { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B3ADD4
	public Void .ctor(String description) { }

	// RVA: 0xFFFFFFFF75B3AE54
	public override String get_Description() { }

}

// Namespace: System.Diagnostics
public class ProcessThread
{
	// Properties
	public Int32 Id { get; }
	public ThreadPriorityLevel PriorityLevel { get; }
	public ThreadState ThreadState { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B3C99C
	public Int32 get_Id() { }

	// RVA: 0xFFFFFFFF75B3C9A4
	public ThreadPriorityLevel get_PriorityLevel() { }

	// RVA: 0xFFFFFFFF75B3C9AC
	public ThreadState get_ThreadState() { }

}

// Namespace: System.Diagnostics
public class Stopwatch
{
	// Fields
	public static readonly Int64 Frequency; // 0x0
	public static readonly Boolean IsHighResolution; // 0x8
	private Int64 elapsed; // 0x10
	private Int64 started; // 0x18
	private Boolean is_running; // 0x20

	// Properties
	public TimeSpan Elapsed { get; }
	public Int64 ElapsedMilliseconds { get; }
	public Int64 ElapsedTicks { get; }
	public Boolean IsRunning { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B3C9B4
	public static Int64 GetTimestamp() { }

	// RVA: 0xFFFFFFFF75B3C9B8
	public static Stopwatch StartNew() { }

	// RVA: 0xFFFFFFFF72376408
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B3C9E8
	public TimeSpan get_Elapsed() { }

	// RVA: 0xFFFFFFFF72376510
	public Int64 get_ElapsedMilliseconds() { }

	// RVA: 0xFFFFFFFF723764B4
	public Int64 get_ElapsedTicks() { }

	// RVA: 0xFFFFFFFF75B3CAB8
	public Boolean get_IsRunning() { }

	// RVA: 0xFFFFFFFF72376624
	public Void Reset() { }

	// RVA: 0xFFFFFFFF7237640C
	public Void Start() { }

	// RVA: 0xFFFFFFFF72376630
	public Void Stop() { }

	// RVA: 0xFFFFFFFF723766F8
	public Void Restart() { }

	// RVA: 0xFFFFFFFF75B3CAC0
	private static Void .cctor() { }

}

// Namespace: System.Diagnostics
public enum ThreadPriorityLevel
{
	// Fields
	public Int32 value__; // 0x10
	public const ThreadPriorityLevel AboveNormal = 1;
	public const ThreadPriorityLevel BelowNormal = 4294967295;
	public const ThreadPriorityLevel Highest = 2;
	public const ThreadPriorityLevel Idle = 4294967281;
	public const ThreadPriorityLevel Lowest = 4294967294;
	public const ThreadPriorityLevel Normal = 0;
	public const ThreadPriorityLevel TimeCritical = 15;
}

// Namespace: System.Diagnostics
public enum ThreadState
{
	// Fields
	public Int32 value__; // 0x10
	public const ThreadState Initialized = 0;
	public const ThreadState Ready = 1;
	public const ThreadState Running = 2;
	public const ThreadState Standby = 3;
	public const ThreadState Terminated = 4;
	public const ThreadState Transition = 6;
	public const ThreadState Unknown = 7;
	public const ThreadState Wait = 5;
}

// Namespace: System.Diagnostics.CodeAnalysis
public sealed class ExcludeFromCodeCoverageAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75B3AD5C
	public Void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class AmbientValueAttribute
{
	// Fields
	private readonly Object value; // 0x10

	// Properties
	public Object Value { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B0E6B0
	public Object get_Value() { }

}

// Namespace: System.ComponentModel
public class ArrayConverter
{
	// Methods

	// RVA: 0xFFFFFFFF75B0E6B8
	public override Object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, Object value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75B0E968
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, Object value, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B0EC7C
	public override Boolean GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0xFFFFFFFF75B0EC84
	public Void .ctor() { }

}

// Namespace: 
private class ArrayPropertyDescriptor
{
	// Fields
	private Int32 index; // 0x90

	// Methods

	// RVA: 0xFFFFFFFF75B0EB10
	public Void .ctor(Type arrayType, Type elementType, Int32 index) { }

}

// Namespace: System.ComponentModel
internal class ArraySubsetEnumerator
{
	// Fields
	private Array array; // 0x10
	private Int32 total; // 0x18
	private Int32 current; // 0x1C

	// Properties
	public Object Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B0ED00
	public Void .ctor(Array array, Int32 count) { }

	// RVA: 0xFFFFFFFF75B0ED4C
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75B0ED70
	public Void Reset() { }

	// RVA: 0xFFFFFFFF75B0ED7C
	public Object get_Current() { }

}

// Namespace: System.ComponentModel
public sealed class AsyncOperation
{
	// Fields
	private SynchronizationContext syncContext; // 0x10
	private Object userSuppliedState; // 0x18
	private Boolean alreadyCompleted; // 0x20

	// Properties
	public Object UserSuppliedState { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B0EDFC
	public Object get_UserSuppliedState() { }

	// RVA: 0xFFFFFFFF75B0EE04
	public Void Post(SendOrPostCallback d, Object arg) { }

	// RVA: 0xFFFFFFFF75B0EE5C
	private Void VerifyNotCompleted() { }

	// RVA: 0xFFFFFFFF75B0EEEC
	private Void VerifyDelegateNotNull(SendOrPostCallback d) { }

}

// Namespace: System.ComponentModel
public class AttributeCollection
{
	// Fields
	public static readonly AttributeCollection Empty; // 0x0
	private static Hashtable _defaultAttributes; // 0x8
	private Attribute[] _attributes; // 0x10
	private static Object internalSyncObject; // 0x10
	private AttributeEntry[] _foundAttributeTypes; // 0x18
	private Int32 _index; // 0x20

	// Properties
	protected virtual Attribute[] Attributes { get; }
	public Int32 Count { get; }
	public virtual Attribute Item { get; }
	public virtual Attribute Item { get; }
	private Int32 System.Collections.ICollection.Count { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B0EF80
	public Void .ctor(Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF72373CA0
	protected virtual Attribute[] get_Attributes() { }

	// RVA: 0xFFFFFFFF75B0F080
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75B0F0AC
	public virtual Attribute get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF75B0F100
	public virtual Attribute get_Item(Type attributeType) { }

	// RVA: 0xFFFFFFFF75B0FB54
	public Boolean Contains(Attribute attribute) { }

	// RVA: 0xFFFFFFFF75B0F6F8
	protected Attribute GetDefaultAttribute(Type attributeType) { }

	// RVA: 0xFFFFFFFF75B0FCA0
	public IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B0FCCC
	private Int32 System.Collections.ICollection.get_Count() { }

	// RVA: 0xFFFFFFFF75B0FCF8
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75B0FD00
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xFFFFFFFF75B0FD08
	public Void CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF75B0FD7C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B0FDA8
	private static Void .cctor() { }

}

// Namespace: 
private struct AttributeEntry
{
	// Fields
	public Type type; // 0x10
	public Int32 index; // 0x18
}

// Namespace: System.ComponentModel
public class AttributeProviderAttribute
{
	// Fields
	private String _typeName; // 0x10
	private String _propertyName; // 0x18

	// Properties
	public String TypeName { get; }
	public String PropertyName { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B0FE54
	public String get_TypeName() { }

	// RVA: 0xFFFFFFFF75B0FE5C
	public String get_PropertyName() { }

}

// Namespace: System.ComponentModel
public class BooleanConverter
{
	// Fields
	private static StandardValuesCollection values; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75B1054C
	public override Boolean CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0xFFFFFFFF72374070
	public override Object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, Object value) { }

	// RVA: 0xFFFFFFFF75B105B4
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0xFFFFFFFF75B1078C
	public override Boolean GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0xFFFFFFFF75B10794
	public override Boolean GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0xFFFFFFFF75B1079C
	public Void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class BrowsableAttribute
{
	// Fields
	public static readonly BrowsableAttribute Yes; // 0x0
	public static readonly BrowsableAttribute No; // 0x8
	public static readonly BrowsableAttribute Default; // 0x10
	private Boolean browsable; // 0x10

	// Properties
	public Boolean Browsable { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B107A0
	public Void .ctor(Boolean browsable) { }

	// RVA: 0xFFFFFFFF75B107D4
	public Boolean get_Browsable() { }

	// RVA: 0xFFFFFFFF75B107DC
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75B10870
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75B1087C
	public override Boolean IsDefaultAttribute() { }

	// RVA: 0xFFFFFFFF75B108F0
	private static Void .cctor() { }

}

// Namespace: System.ComponentModel
public class ByteConverter
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B109DC
	internal override Type get_TargetType() { }

	// RVA: 0xFFFFFFFF75B10A20
	internal override Object FromString(String value, Int32 radix) { }

	// RVA: 0xFFFFFFFF75B10A88
	internal override Object FromString(String value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B10AC4
	internal override Object FromString(String value, CultureInfo culture) { }

	// RVA: 0xFFFFFFFF75B10B00
	internal override String ToString(Object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B10B7C
	public Void .ctor() { }

}

// Namespace: System.ComponentModel
public class CategoryAttribute
{
	// Fields
	private static CategoryAttribute defAttr; // 0x0
	private Boolean localized; // 0x10
	private String categoryValue; // 0x18

	// Properties
	public static CategoryAttribute Default { get; }
	public String Category { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B10B80
	public static CategoryAttribute get_Default() { }

	// RVA: 0xFFFFFFFF75B10C1C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B10C94
	public Void .ctor(String category) { }

	// RVA: 0xFFFFFFFF75B10CE4
	public String get_Category() { }

	// RVA: 0xFFFFFFFF75B10D4C
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75B10E48
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75B10E70
	protected virtual String GetLocalizedString(String value) { }

	// RVA: 0xFFFFFFFF75B111AC
	public override Boolean IsDefaultAttribute() { }

}

// Namespace: System.ComponentModel
public class CharConverter
{}

// Namespace: System.ComponentModel
public class CollectionConverter
{
	// Methods

	// RVA: 0xFFFFFFFF75B0E84C
	public override Object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, Object value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75B111EC
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, Object value, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B111F4
	public override Boolean GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0xFFFFFFFF75B0EC88
	public Void .ctor() { }

}

// Namespace: System.ComponentModel
public class Component
{
	// Fields
	private static readonly Object EventDisposed; // 0x0
	private ISite site; // 0x18
	private EventHandlerList events; // 0x20

	// Properties
	protected virtual Boolean CanRaiseEvents { get; }
	internal Boolean CanRaiseEventsInternal { get; }
	public virtual ISite Site { get; }
	protected Boolean DesignMode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B111FC
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75B11274
	protected virtual Boolean get_CanRaiseEvents() { }

	// RVA: 0xFFFFFFFF75B1127C
	internal Boolean get_CanRaiseEventsInternal() { }

	// RVA: 0xFFFFFFFF75B1128C
	public virtual ISite get_Site() { }

	// RVA: 0xFFFFFFFF75B11294
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75B112E8
	protected virtual Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75B11618
	protected virtual Object GetService(Type service) { }

	// RVA: 0xFFFFFFFF75B116DC
	protected Boolean get_DesignMode() { }

	// RVA: 0xFFFFFFFF75B11790
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75B118B0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B118B8
	private static Void .cctor() { }

}

// Namespace: System.ComponentModel
public class ComponentCollection
{}

// Namespace: System.ComponentModel
public class ComponentConverter
{}

// Namespace: System.ComponentModel
public class CultureInfoConverter
{}

// Namespace: System.ComponentModel
public abstract class CustomTypeDescriptor
{
	// Fields
	private ICustomTypeDescriptor _parent; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75B11924
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF75B11928
	protected Void .ctor(ICustomTypeDescriptor parent) { }

	// RVA: 0xFFFFFFFF75B11960
	public virtual AttributeCollection GetAttributes() { }

	// RVA: 0xFFFFFFFF75B11A40
	public virtual String GetClassName() { }

	// RVA: 0xFFFFFFFF75B11AF4
	public virtual String GetComponentName() { }

	// RVA: 0xFFFFFFFF75B11BA8
	public virtual TypeConverter GetConverter() { }

	// RVA: 0xFFFFFFFF75B11C6C
	public virtual EventDescriptor GetDefaultEvent() { }

	// RVA: 0xFFFFFFFF75B11D20
	public virtual PropertyDescriptor GetDefaultProperty() { }

	// RVA: 0xFFFFFFFF75B11DD4
	public virtual Object GetEditor(Type editorBaseType) { }

	// RVA: 0xFFFFFFFF75B11E9C
	public virtual EventDescriptorCollection GetEvents() { }

	// RVA: 0xFFFFFFFF75B11F80
	public virtual EventDescriptorCollection GetEvents(Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B12078
	public virtual PropertyDescriptorCollection GetProperties() { }

	// RVA: 0xFFFFFFFF75B1215C
	public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

}

// Namespace: System.ComponentModel
public class DateTimeConverter
{}

// Namespace: System.ComponentModel
public class DateTimeOffsetConverter
{}

// Namespace: System.ComponentModel
public class DecimalConverter
{
	// Properties
	internal override Boolean AllowHex { get; }
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B12254
	internal override Boolean get_AllowHex() { }

	// RVA: 0xFFFFFFFF75B1225C
	internal override Type get_TargetType() { }

	// RVA: 0xFFFFFFFF75B122A0
	public override Boolean CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xFFFFFFFF75B12328
	public override Object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, Object value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75B1257C
	internal override Object FromString(String value, Int32 radix) { }

	// RVA: 0xFFFFFFFF75B12608
	internal override Object FromString(String value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B12678
	internal override Object FromString(String value, CultureInfo culture) { }

	// RVA: 0xFFFFFFFF75B126E4
	internal override String ToString(Object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B12760
	public Void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class DefaultEventAttribute
{
	// Fields
	private readonly String name; // 0x10
	public static readonly DefaultEventAttribute Default; // 0x0

	// Properties
	public String Name { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B12764
	public Void .ctor(String name) { }

	// RVA: 0xFFFFFFFF75B127A8
	public String get_Name() { }

	// RVA: 0xFFFFFFFF75B127B0
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75B12830
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75B12838
	private static Void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class DefaultPropertyAttribute
{
	// Fields
	private readonly String name; // 0x10
	public static readonly DefaultPropertyAttribute Default; // 0x0

	// Properties
	public String Name { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B128D4
	public Void .ctor(String name) { }

	// RVA: 0xFFFFFFFF75B12918
	public String get_Name() { }

	// RVA: 0xFFFFFFFF75B12920
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75B129A0
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75B129A8
	private static Void .cctor() { }

}

// Namespace: System.ComponentModel
public class DefaultValueAttribute
{
	// Fields
	private Object value; // 0x10

	// Properties
	public virtual Object Value { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B12A44
	public Void .ctor(Boolean value) { }

	// RVA: 0xFFFFFFFF75B12AA0
	public Void .ctor(String value) { }

	// RVA: 0xFFFFFFFF75B12AE4
	public Void .ctor(Object value) { }

	// RVA: 0xFFFFFFFF75B12B28
	public virtual Object get_Value() { }

	// RVA: 0xFFFFFFFF75B12B30
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75B12C50
	public override Int32 GetHashCode() { }

}

// Namespace: System.ComponentModel
internal sealed class DelegatingTypeDescriptionProvider
{
	// Fields
	private Type _type; // 0x20

	// Properties
	internal TypeDescriptionProvider Provider { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B12C58
	internal Void .ctor(Type type) { }

	// RVA: 0xFFFFFFFF75B12C94
	internal TypeDescriptionProvider get_Provider() { }

	// RVA: 0xFFFFFFFF75B12D54
	public override Object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, Object[] args) { }

	// RVA: 0xFFFFFFFF75B12DA4
	public override IDictionary GetCache(Object instance) { }

	// RVA: 0xFFFFFFFF75B12DD4
	public override String GetFullComponentName(Object component) { }

	// RVA: 0xFFFFFFFF75B12E04
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(Object instance) { }

	// RVA: 0xFFFFFFFF75B12E34
	protected internal override IExtenderProvider[] GetExtenderProviders(Object instance) { }

	// RVA: 0xFFFFFFFF75B12E64
	public override Type GetReflectionType(Type objectType, Object instance) { }

	// RVA: 0xFFFFFFFF75B12E9C
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, Object instance) { }

}

// Namespace: System.ComponentModel
public class DescriptionAttribute
{
	// Fields
	public static readonly DescriptionAttribute Default; // 0x0
	private String description; // 0x10

	// Properties
	public virtual String Description { get; }
	protected String DescriptionValue { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B12ED4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B12F24
	public Void .ctor(String description) { }

	// RVA: 0xFFFFFFFF75B12F68
	public virtual String get_Description() { }

	// RVA: 0xFFFFFFFF75B12F70
	protected String get_DescriptionValue() { }

	// RVA: 0xFFFFFFFF75B12F78
	protected Void set_DescriptionValue(String value) { }

	// RVA: 0xFFFFFFFF75B12FB0
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75B13084
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75B130B8
	public override Boolean IsDefaultAttribute() { }

	// RVA: 0xFFFFFFFF75B1312C
	private static Void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class DesignOnlyAttribute
{
	// Fields
	private Boolean isDesignOnly; // 0x10
	public static readonly DesignOnlyAttribute Yes; // 0x0
	public static readonly DesignOnlyAttribute No; // 0x8
	public static readonly DesignOnlyAttribute Default; // 0x10

	// Properties
	public Boolean IsDesignOnly { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B13A88
	public Void .ctor(Boolean isDesignOnly) { }

	// RVA: 0xFFFFFFFF75B13AB4
	public Boolean get_IsDesignOnly() { }

	// RVA: 0xFFFFFFFF75B13ABC
	public override Boolean IsDefaultAttribute() { }

	// RVA: 0xFFFFFFFF75B13B44
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75B13BD8
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75B13BE4
	private static Void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class DesignerAttribute
{
	// Fields
	private readonly String designerTypeName; // 0x10
	private readonly String designerBaseTypeName; // 0x18
	private String typeId; // 0x20

	// Properties
	public String DesignerBaseTypeName { get; }
	public String DesignerTypeName { get; }
	public override Object TypeId { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B13CC8
	public Void .ctor(String designerTypeName) { }

	// RVA: 0xFFFFFFFF75B13DD8
	public Void .ctor(String designerTypeName, Type designerBaseType) { }

	// RVA: 0xFFFFFFFF75B13E9C
	public String get_DesignerBaseTypeName() { }

	// RVA: 0xFFFFFFFF75B13EA4
	public String get_DesignerTypeName() { }

	// RVA: 0xFFFFFFFF75B13EAC
	public override Object get_TypeId() { }

	// RVA: 0xFFFFFFFF75B13F64
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75B14008
	public override Int32 GetHashCode() { }

}

// Namespace: System.ComponentModel
public sealed class DesignerCategoryAttribute
{
	// Fields
	private String category; // 0x10
	private String typeId; // 0x18
	public static readonly DesignerCategoryAttribute Component; // 0x0
	public static readonly DesignerCategoryAttribute Default; // 0x8
	public static readonly DesignerCategoryAttribute Form; // 0x10
	public static readonly DesignerCategoryAttribute Generic; // 0x18

	// Properties
	public String Category { get; }
	public override Object TypeId { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B14060
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B140B0
	public Void .ctor(String category) { }

	// RVA: 0xFFFFFFFF75B140F4
	public String get_Category() { }

	// RVA: 0xFFFFFFFF75B140FC
	public override Object get_TypeId() { }

	// RVA: 0xFFFFFFFF75B14174
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75B14204
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75B1422C
	public override Boolean IsDefaultAttribute() { }

	// RVA: 0xFFFFFFFF75B142AC
	private static Void .cctor() { }

}

// Namespace: System.ComponentModel
public enum DesignerSerializationVisibility
{
	// Fields
	public Int32 value__; // 0x10
	public const DesignerSerializationVisibility Hidden = 0;
	public const DesignerSerializationVisibility Visible = 1;
	public const DesignerSerializationVisibility Content = 2;
}

// Namespace: System.ComponentModel
public sealed class DesignerSerializationVisibilityAttribute
{
	// Fields
	public static readonly DesignerSerializationVisibilityAttribute Content; // 0x0
	public static readonly DesignerSerializationVisibilityAttribute Hidden; // 0x8
	public static readonly DesignerSerializationVisibilityAttribute Visible; // 0x10
	public static readonly DesignerSerializationVisibilityAttribute Default; // 0x18
	private DesignerSerializationVisibility visibility; // 0x10

	// Properties
	public DesignerSerializationVisibility Visibility { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B14478
	public Void .ctor(DesignerSerializationVisibility visibility) { }

	// RVA: 0xFFFFFFFF75B144A4
	public DesignerSerializationVisibility get_Visibility() { }

	// RVA: 0xFFFFFFFF75B144AC
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75B14534
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75B1453C
	public override Boolean IsDefaultAttribute() { }

	// RVA: 0xFFFFFFFF75B145B0
	private static Void .cctor() { }

}

// Namespace: System.ComponentModel
public class DisplayNameAttribute
{
	// Fields
	public static readonly DisplayNameAttribute Default; // 0x0
	private String _displayName; // 0x10

	// Properties
	public virtual String DisplayName { get; }
	protected String DisplayNameValue { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B146D0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B14720
	public Void .ctor(String displayName) { }

	// RVA: 0xFFFFFFFF75B14764
	public virtual String get_DisplayName() { }

	// RVA: 0xFFFFFFFF75B1476C
	protected String get_DisplayNameValue() { }

	// RVA: 0xFFFFFFFF75B14774
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75B14848
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75B1487C
	public override Boolean IsDefaultAttribute() { }

	// RVA: 0xFFFFFFFF75B148F0
	private static Void .cctor() { }

}

// Namespace: System.ComponentModel
public class DoubleConverter
{
	// Properties
	internal override Boolean AllowHex { get; }
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0xFFFFFFFF72374250
	internal override Boolean get_AllowHex() { }

	// RVA: 0xFFFFFFFF75B1499C
	internal override Type get_TargetType() { }

	// RVA: 0xFFFFFFFF75B149E0
	internal override Object FromString(String value, Int32 radix) { }

	// RVA: 0xFFFFFFFF72374258
	internal override Object FromString(String value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B14A6C
	internal override Object FromString(String value, CultureInfo culture) { }

	// RVA: 0xFFFFFFFF75B14AD8
	internal override String ToString(Object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B14B54
	public Void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class EditorAttribute
{
	// Fields
	private String baseTypeName; // 0x10
	private String typeName; // 0x18

	// Properties
	public String EditorBaseTypeName { get; }
	public String EditorTypeName { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B14B58
	public String get_EditorBaseTypeName() { }

	// RVA: 0xFFFFFFFF75B14B60
	public String get_EditorTypeName() { }

}

// Namespace: System.ComponentModel
public sealed class EditorBrowsableAttribute
{
	// Fields
	private EditorBrowsableState browsableState; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75B14B68
	public Void .ctor(EditorBrowsableState state) { }

	// RVA: 0xFFFFFFFF75B14B94
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75B14C1C
	public override Int32 GetHashCode() { }

}

// Namespace: System.ComponentModel
public enum EditorBrowsableState
{
	// Fields
	public Int32 value__; // 0x10
	public const EditorBrowsableState Always = 0;
	public const EditorBrowsableState Never = 1;
	public const EditorBrowsableState Advanced = 2;
}

// Namespace: System.ComponentModel
public class EnumConverter
{
	// Fields
	private StandardValuesCollection values; // 0x10
	private Type type; // 0x18

	// Properties
	protected Type EnumType { get; }
	protected StandardValuesCollection Values { get; set; }
	protected virtual IComparer Comparer { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B14C24
	public Void .ctor(Type type) { }

	// RVA: 0xFFFFFFFF75B14C5C
	protected Type get_EnumType() { }

	// RVA: 0xFFFFFFFF75B14C64
	protected StandardValuesCollection get_Values() { }

	// RVA: 0xFFFFFFFF75B14C6C
	protected Void set_Values(StandardValuesCollection value) { }

	// RVA: 0xFFFFFFFF75B14CA4
	public override Boolean CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0xFFFFFFFF75B14D44
	public override Boolean CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xFFFFFFFF75B14DF0
	protected virtual IComparer get_Comparer() { }

	// RVA: 0xFFFFFFFF75B14E50
	public override Object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, Object value) { }

	// RVA: 0xFFFFFFFF75B152CC
	public override Object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, Object value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75B15DD8
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0xFFFFFFFF75B16190
	public override Boolean GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0xFFFFFFFF75B16204
	public override Boolean GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0xFFFFFFFF75B1620C
	public override Boolean IsValid(ITypeDescriptorContext context, Object value) { }

}

// Namespace: System.ComponentModel
public abstract class EventDescriptor
{
	// Properties
	public abstract Type EventType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B16254
	protected Void .ctor(String name, Attribute[] attrs) { }

	// RVA: 0xFFFFFFFF75B16444
	protected Void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: -1
	public abstract Type get_EventType() { }

}

// Namespace: System.ComponentModel
public class EventDescriptorCollection
{
	// Fields
	private EventDescriptor[] events; // 0x10
	private String[] namedSort; // 0x18
	private IComparer comparer; // 0x20
	private Boolean eventsOwned; // 0x28
	private Boolean needSort; // 0x29
	private Int32 eventCount; // 0x2C
	private Boolean readOnly; // 0x30
	public static readonly EventDescriptorCollection Empty; // 0x0

	// Properties
	public Int32 Count { get; }
	public virtual EventDescriptor Item { get; }
	public virtual EventDescriptor Item { get; }
	private Int32 System.Collections.ICollection.Count { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }
	private Object System.Collections.IList.Item { get; set; }
	private Boolean System.Collections.IList.IsReadOnly { get; }
	private Boolean System.Collections.IList.IsFixedSize { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B16818
	public Void .ctor(EventDescriptor[] events) { }

	// RVA: 0xFFFFFFFF75B168D4
	public Void .ctor(EventDescriptor[] events, Boolean readOnly) { }

	// RVA: 0xFFFFFFFF75B168FC
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75B16904
	public virtual EventDescriptor get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF75B16A80
	public virtual EventDescriptor get_Item(String name) { }

	// RVA: 0xFFFFFFFF75B16A94
	public Int32 Add(EventDescriptor value) { }

	// RVA: 0xFFFFFFFF75B16C80
	public Void Clear() { }

	// RVA: 0xFFFFFFFF75B16CF0
	public Boolean Contains(EventDescriptor value) { }

	// RVA: 0xFFFFFFFF75B16D6C
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF75B169B4
	private Void EnsureEventsOwned() { }

	// RVA: 0xFFFFFFFF75B16B70
	private Void EnsureSize(Int32 sizeNeeded) { }

	// RVA: 0xFFFFFFFF75B17070
	public virtual EventDescriptor Find(String name, Boolean ignoreCase) { }

	// RVA: 0xFFFFFFFF75B16D0C
	public Int32 IndexOf(EventDescriptor value) { }

	// RVA: 0xFFFFFFFF75B17190
	public Void Insert(Int32 index, EventDescriptor value) { }

	// RVA: 0xFFFFFFFF75B17294
	public Void Remove(EventDescriptor value) { }

	// RVA: 0xFFFFFFFF75B17338
	public Void RemoveAt(Int32 index) { }

	// RVA: 0xFFFFFFFF75B1743C
	public IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B16DB4
	protected Void InternalSort(String[] names) { }

	// RVA: 0xFFFFFFFF75B174EC
	protected Void InternalSort(IComparer sorter) { }

	// RVA: 0xFFFFFFFF75B17668
	private Int32 System.Collections.ICollection.get_Count() { }

	// RVA: 0xFFFFFFFF75B17670
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75B17678
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xFFFFFFFF75B17680
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B17684
	private Object System.Collections.IList.get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF75B17694
	private Void System.Collections.IList.set_Item(Int32 index, Object value) { }

	// RVA: 0xFFFFFFFF75B177D8
	private Int32 System.Collections.IList.Add(Object value) { }

	// RVA: 0xFFFFFFFF75B17864
	private Void System.Collections.IList.Clear() { }

	// RVA: 0xFFFFFFFF75B17868
	private Boolean System.Collections.IList.Contains(Object value) { }

	// RVA: 0xFFFFFFFF75B17900
	private Int32 System.Collections.IList.IndexOf(Object value) { }

	// RVA: 0xFFFFFFFF75B1798C
	private Void System.Collections.IList.Insert(Int32 index, Object value) { }

	// RVA: 0xFFFFFFFF75B17A20
	private Void System.Collections.IList.Remove(Object value) { }

	// RVA: 0xFFFFFFFF75B17AAC
	private Void System.Collections.IList.RemoveAt(Int32 index) { }

	// RVA: 0xFFFFFFFF75B17AB0
	private Boolean System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF75B17AB8
	private Boolean System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xFFFFFFFF75B17AC0
	private static Void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class EventHandlerList
{
	// Fields
	private ListEntry head; // 0x10
	private Component parent; // 0x18

	// Properties
	public Delegate Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B115B4
	public Delegate get_Item(Object key) { }

	// RVA: 0xFFFFFFFF75B17B3C
	private ListEntry Find(Object key) { }

}

// Namespace: 
private sealed class ListEntry
{
	// Fields
	internal ListEntry next; // 0x10
	internal Object key; // 0x18
	internal Delegate handler; // 0x20
}

// Namespace: System.ComponentModel
internal sealed class ExtendedPropertyDescriptor
{
	// Fields
	private readonly ReflectPropertyDescriptor extenderInfo; // 0x80
	private readonly IExtenderProvider provider; // 0x88

	// Properties
	public override Type ComponentType { get; }
	public override Boolean IsReadOnly { get; }
	public override Type PropertyType { get; }
	public override String DisplayName { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B17B54
	public Void .ctor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B17DDC
	public Void .ctor(PropertyDescriptor extender, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B17F34
	public override Type get_ComponentType() { }

	// RVA: 0xFFFFFFFF75B17F5C
	public override Boolean get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF75B1804C
	public override Type get_PropertyType() { }

	// RVA: 0xFFFFFFFF75B18084
	public override String get_DisplayName() { }

}

// Namespace: System.ComponentModel
public sealed class ExtenderProvidedPropertyAttribute
{
	// Fields
	private PropertyDescriptor extenderProperty; // 0x10
	private IExtenderProvider provider; // 0x18
	private Type receiverType; // 0x20

	// Properties
	public PropertyDescriptor ExtenderProperty { get; }
	public IExtenderProvider Provider { get; }
	public Type ReceiverType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B17D18
	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	// RVA: 0xFFFFFFFF75B184D0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B184D8
	public PropertyDescriptor get_ExtenderProperty() { }

	// RVA: 0xFFFFFFFF75B184E0
	public IExtenderProvider get_Provider() { }

	// RVA: 0xFFFFFFFF75B184E8
	public Type get_ReceiverType() { }

	// RVA: 0xFFFFFFFF75B184F0
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75B185D0
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75B185D8
	public override Boolean IsDefaultAttribute() { }

}

// Namespace: System.ComponentModel
public class GuidConverter
{}

// Namespace: System.ComponentModel
public interface IComNativeDescriptorHandler
{
	// Methods

	// RVA: -1
	public abstract AttributeCollection GetAttributes(Object component) { }

	// RVA: -1
	public abstract String GetClassName(Object component) { }

	// RVA: -1
	public abstract TypeConverter GetConverter(Object component) { }

	// RVA: -1
	public abstract EventDescriptor GetDefaultEvent(Object component) { }

	// RVA: -1
	public abstract PropertyDescriptor GetDefaultProperty(Object component) { }

	// RVA: -1
	public abstract Object GetEditor(Object component, Type baseEditorType) { }

	// RVA: -1
	public abstract EventDescriptorCollection GetEvents(Object component) { }

	// RVA: -1
	public abstract EventDescriptorCollection GetEvents(Object component, Attribute[] attributes) { }

	// RVA: -1
	public abstract PropertyDescriptorCollection GetProperties(Object component, Attribute[] attributes) { }

}

// Namespace: System.ComponentModel
public interface IComponent
{
	// Properties
	public abstract ISite Site { get; }

	// Methods

	// RVA: -1
	public abstract ISite get_Site() { }

}

// Namespace: System.ComponentModel
public interface IContainer
{
	// Properties
	public abstract ComponentCollection Components { get; }

	// Methods

	// RVA: -1
	public abstract ComponentCollection get_Components() { }

	// RVA: -1
	public abstract Void Remove(IComponent component) { }

}

// Namespace: System.ComponentModel
public interface ICustomTypeDescriptor
{
	// Methods

	// RVA: -1
	public abstract AttributeCollection GetAttributes() { }

	// RVA: -1
	public abstract String GetClassName() { }

	// RVA: -1
	public abstract String GetComponentName() { }

	// RVA: -1
	public abstract TypeConverter GetConverter() { }

	// RVA: -1
	public abstract EventDescriptor GetDefaultEvent() { }

	// RVA: -1
	public abstract PropertyDescriptor GetDefaultProperty() { }

	// RVA: -1
	public abstract Object GetEditor(Type editorBaseType) { }

	// RVA: -1
	public abstract EventDescriptorCollection GetEvents() { }

	// RVA: -1
	public abstract EventDescriptorCollection GetEvents(Attribute[] attributes) { }

	// RVA: -1
	public abstract PropertyDescriptorCollection GetProperties() { }

	// RVA: -1
	public abstract PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

}

// Namespace: System.ComponentModel
public interface IExtenderProvider
{
	// Methods

	// RVA: -1
	public abstract Boolean CanExtend(Object extendee) { }

}

// Namespace: System.ComponentModel
public interface INestedSite
{
	// Properties
	public abstract String FullName { get; }

	// Methods

	// RVA: -1
	public abstract String get_FullName() { }

}

// Namespace: System.ComponentModel
public interface ISite
{
	// Properties
	public abstract IContainer Container { get; }
	public abstract Boolean DesignMode { get; }
	public abstract String Name { get; }

	// Methods

	// RVA: -1
	public abstract IContainer get_Container() { }

	// RVA: -1
	public abstract Boolean get_DesignMode() { }

	// RVA: -1
	public abstract String get_Name() { }

}

// Namespace: System.ComponentModel
public interface ISynchronizeInvoke
{
	// Properties
	public abstract Boolean InvokeRequired { get; }

	// Methods

	// RVA: -1
	public abstract Boolean get_InvokeRequired() { }

	// RVA: -1
	public abstract IAsyncResult BeginInvoke(Delegate method, Object[] args) { }

}

// Namespace: System.ComponentModel
public interface ITypeDescriptorContext
{}

// Namespace: System.ComponentModel
public class Int16Converter
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B18618
	internal override Type get_TargetType() { }

	// RVA: 0xFFFFFFFF75B1865C
	internal override Object FromString(String value, Int32 radix) { }

	// RVA: 0xFFFFFFFF75B186C4
	internal override Object FromString(String value, CultureInfo culture) { }

	// RVA: 0xFFFFFFFF75B18700
	internal override Object FromString(String value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B1873C
	internal override String ToString(Object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B187B8
	public Void .ctor() { }

}

// Namespace: System.ComponentModel
public class Int32Converter
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B187BC
	internal override Type get_TargetType() { }

	// RVA: 0xFFFFFFFF75B18800
	internal override Object FromString(String value, Int32 radix) { }

	// RVA: 0xFFFFFFFF72374328
	internal override Object FromString(String value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B18868
	internal override Object FromString(String value, CultureInfo culture) { }

	// RVA: 0xFFFFFFFF75B188A4
	internal override String ToString(Object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B18920
	public Void .ctor() { }

}

// Namespace: System.ComponentModel
public class Int64Converter
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B18924
	internal override Type get_TargetType() { }

	// RVA: 0xFFFFFFFF75B18968
	internal override Object FromString(String value, Int32 radix) { }

	// RVA: 0xFFFFFFFF75B189D0
	internal override Object FromString(String value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B18A0C
	internal override Object FromString(String value, CultureInfo culture) { }

	// RVA: 0xFFFFFFFF75B18A48
	internal override String ToString(Object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B18AC4
	public Void .ctor() { }

}

// Namespace: System.ComponentModel
public abstract class MemberDescriptor
{
	// Fields
	private String name; // 0x10
	private String displayName; // 0x18
	private Int32 nameHash; // 0x20
	private AttributeCollection attributeCollection; // 0x28
	private Attribute[] attributes; // 0x30
	private Attribute[] originalAttributes; // 0x38
	private Boolean attributesFiltered; // 0x40
	private Boolean attributesFilled; // 0x41
	private Int32 metadataVersion; // 0x44
	private String category; // 0x48
	private String description; // 0x50
	private Object lockCookie; // 0x58

	// Properties
	protected virtual Attribute[] AttributeArray { get; set; }
	public virtual AttributeCollection Attributes { get; }
	public virtual String Name { get; }
	protected virtual Int32 NameHashCode { get; }
	public virtual String DisplayName { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B16258
	protected Void .ctor(String name, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B16448
	protected Void .ctor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	// RVA: 0xFFFFFFFF75B18AC8
	protected virtual Attribute[] get_AttributeArray() { }

	// RVA: 0xFFFFFFFF75B19240
	protected virtual Void set_AttributeArray(Attribute[] value) { }

	// RVA: 0xFFFFFFFF75B19320
	public virtual AttributeCollection get_Attributes() { }

	// RVA: 0xFFFFFFFF75B193F8
	public virtual String get_Name() { }

	// RVA: 0xFFFFFFFF75B19410
	protected virtual Int32 get_NameHashCode() { }

	// RVA: 0xFFFFFFFF75B1829C
	public virtual String get_DisplayName() { }

	// RVA: 0xFFFFFFFF75B18AF4
	private Void CheckAttributesValid() { }

	// RVA: 0xFFFFFFFF75B19418
	protected virtual AttributeCollection CreateAttributeCollection() { }

	// RVA: 0xFFFFFFFF75B19488
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75B196D0
	protected virtual Void FillAttributes(IList attributeList) { }

	// RVA: 0xFFFFFFFF75B18BD0
	private Void FilterAttributesIfNeeded() { }

	// RVA: 0xFFFFFFFF75B197A0
	protected static MethodInfo FindMethod(Type componentClass, String name, Type[] args, Type returnType) { }

	// RVA: 0xFFFFFFFF75B197A8
	protected static MethodInfo FindMethod(Type componentClass, String name, Type[] args, Type returnType, Boolean publicOnly) { }

	// RVA: 0xFFFFFFFF75B19850
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75B183C4
	protected static ISite GetSite(Object component) { }

}

// Namespace: System.ComponentModel
public class NullableConverter
{}

// Namespace: System.ComponentModel
public class ProgressChangedEventArgs
{
	// Fields
	private readonly Int32 progressPercentage; // 0x10
	private readonly Object userState; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75B19858
	public Void .ctor(Int32 progressPercentage, Object userState) { }

}

// Namespace: System.ComponentModel
public abstract class PropertyDescriptor
{
	// Fields
	private TypeConverter converter; // 0x60
	private Object[] editors; // 0x68
	private Type[] editorTypes; // 0x70
	private Int32 editorCount; // 0x78

	// Properties
	public abstract Type ComponentType { get; }
	public abstract Boolean IsReadOnly { get; }
	public abstract Type PropertyType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B198F0
	protected Void .ctor(String name, Attribute[] attrs) { }

	// RVA: 0xFFFFFFFF75B17D14
	protected Void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: -1
	public abstract Type get_ComponentType() { }

	// RVA: -1
	public abstract Boolean get_IsReadOnly() { }

	// RVA: -1
	public abstract Type get_PropertyType() { }

	// RVA: 0xFFFFFFFF75B198F4
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75B19ADC
	protected override Void FillAttributes(IList attributeList) { }

	// RVA: 0xFFFFFFFF75B19B64
	public override Int32 GetHashCode() { }

}

// Namespace: System.ComponentModel
public class PropertyDescriptorCollection
{
	// Fields
	public static readonly PropertyDescriptorCollection Empty; // 0x0
	private IDictionary cachedFoundProperties; // 0x10
	private Boolean cachedIgnoreCase; // 0x18
	private PropertyDescriptor[] properties; // 0x20
	private Int32 propCount; // 0x28
	private String[] namedSort; // 0x30
	private IComparer comparer; // 0x38
	private Boolean propsOwned; // 0x40
	private Boolean needSort; // 0x41
	private Boolean readOnly; // 0x42

	// Properties
	public Int32 Count { get; }
	public virtual PropertyDescriptor Item { get; }
	public virtual PropertyDescriptor Item { get; }
	private Int32 System.Collections.ICollection.Count { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }
	private Boolean System.Collections.IDictionary.IsFixedSize { get; }
	private Boolean System.Collections.IDictionary.IsReadOnly { get; }
	private Object System.Collections.IDictionary.Item { get; set; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private Boolean System.Collections.IList.IsReadOnly { get; }
	private Boolean System.Collections.IList.IsFixedSize { get; }
	private Object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B0EBCC
	public Void .ctor(PropertyDescriptor[] properties) { }

	// RVA: 0xFFFFFFFF75B19BC4
	public Void .ctor(PropertyDescriptor[] properties, Boolean readOnly) { }

	// RVA: 0xFFFFFFFF75B19BEC
	private Void .ctor(PropertyDescriptor[] properties, Int32 propCount, String[] namedSort, IComparer comparer) { }

	// RVA: 0xFFFFFFFF75B19CC0
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75B19CC8
	public virtual PropertyDescriptor get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF75B19E44
	public virtual PropertyDescriptor get_Item(String name) { }

	// RVA: 0xFFFFFFFF75B19E58
	public Int32 Add(PropertyDescriptor value) { }

	// RVA: 0xFFFFFFFF75B1A044
	public Void Clear() { }

	// RVA: 0xFFFFFFFF75B1A0D0
	public Boolean Contains(PropertyDescriptor value) { }

	// RVA: 0xFFFFFFFF75B1A14C
	public Void CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF75B19D78
	private Void EnsurePropsOwned() { }

	// RVA: 0xFFFFFFFF75B19F34
	private Void EnsureSize(Int32 sizeNeeded) { }

	// RVA: 0xFFFFFFFF75B1A450
	public virtual PropertyDescriptor Find(String name, Boolean ignoreCase) { }

	// RVA: 0xFFFFFFFF75B1A0EC
	public Int32 IndexOf(PropertyDescriptor value) { }

	// RVA: 0xFFFFFFFF75B1A8E8
	public Void Insert(Int32 index, PropertyDescriptor value) { }

	// RVA: 0xFFFFFFFF75B1A9EC
	public Void Remove(PropertyDescriptor value) { }

	// RVA: 0xFFFFFFFF75B1AA90
	public Void RemoveAt(Int32 index) { }

	// RVA: 0xFFFFFFFF75B1AB94
	public virtual PropertyDescriptorCollection Sort(String[] names) { }

	// RVA: 0xFFFFFFFF75B1A194
	protected Void InternalSort(String[] names) { }

	// RVA: 0xFFFFFFFF75B1AC18
	protected Void InternalSort(IComparer sorter) { }

	// RVA: 0xFFFFFFFF75B1ACA0
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B1AD34
	private Int32 System.Collections.ICollection.get_Count() { }

	// RVA: 0xFFFFFFFF75B1AD3C
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75B1AD44
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xFFFFFFFF75B1AD4C
	private Void System.Collections.IDictionary.Add(Object key, Object value) { }

	// RVA: 0xFFFFFFFF75B1AE0C
	private Void System.Collections.IDictionary.Clear() { }

	// RVA: 0xFFFFFFFF75B1AE10
	private Boolean System.Collections.IDictionary.Contains(Object key) { }

	// RVA: 0xFFFFFFFF75B1AE60
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B1AF1C
	private Boolean System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0xFFFFFFFF75B1AF24
	private Boolean System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF75B1AF2C
	private Object System.Collections.IDictionary.get_Item(Object key) { }

	// RVA: 0xFFFFFFFF75B1AF5C
	private Void System.Collections.IDictionary.set_Item(Object key, Object value) { }

	// RVA: 0xFFFFFFFF75B1B2A8
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0xFFFFFFFF75B1B37C
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0xFFFFFFFF75B1B448
	private Void System.Collections.IDictionary.Remove(Object key) { }

	// RVA: 0xFFFFFFFF75B1B504
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B1B514
	private Int32 System.Collections.IList.Add(Object value) { }

	// RVA: 0xFFFFFFFF75B1B5A0
	private Void System.Collections.IList.Clear() { }

	// RVA: 0xFFFFFFFF75B1B5A4
	private Boolean System.Collections.IList.Contains(Object value) { }

	// RVA: 0xFFFFFFFF75B1B63C
	private Int32 System.Collections.IList.IndexOf(Object value) { }

	// RVA: 0xFFFFFFFF75B1B6C8
	private Void System.Collections.IList.Insert(Int32 index, Object value) { }

	// RVA: 0xFFFFFFFF75B1B75C
	private Boolean System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF75B1B764
	private Boolean System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xFFFFFFFF75B1B76C
	private Void System.Collections.IList.Remove(Object value) { }

	// RVA: 0xFFFFFFFF75B1B7F8
	private Void System.Collections.IList.RemoveAt(Int32 index) { }

	// RVA: 0xFFFFFFFF75B1B7FC
	private Object System.Collections.IList.get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF75B1B80C
	private Void System.Collections.IList.set_Item(Int32 index, Object value) { }

	// RVA: 0xFFFFFFFF75B1B9A4
	private static Void .cctor() { }

}

// Namespace: 
private class PropertyDescriptorEnumerator
{
	// Fields
	private PropertyDescriptorCollection owner; // 0x10
	private Int32 index; // 0x18

	// Properties
	public Object Current { get; }
	public DictionaryEntry Entry { get; }
	public Object Key { get; }
	public Object Value { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B1AEDC
	public Void .ctor(PropertyDescriptorCollection owner) { }

	// RVA: 0xFFFFFFFF75B1BA20
	public Object get_Current() { }

	// RVA: 0xFFFFFFFF75B1BA80
	public DictionaryEntry get_Entry() { }

	// RVA: 0xFFFFFFFF75B1BAF8
	public Object get_Key() { }

	// RVA: 0xFFFFFFFF75B1BB3C
	public Object get_Value() { }

	// RVA: 0xFFFFFFFF75B1BB80
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75B1BBC0
	public Void Reset() { }

}

// Namespace: System.ComponentModel
public sealed class ProvidePropertyAttribute
{
	// Fields
	private readonly String propertyName; // 0x10
	private readonly String receiverTypeName; // 0x18

	// Properties
	public String PropertyName { get; }
	public String ReceiverTypeName { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B1BBCC
	public String get_PropertyName() { }

	// RVA: 0xFFFFFFFF75B1BBD4
	public String get_ReceiverTypeName() { }

}

// Namespace: System.ComponentModel
public sealed class ReadOnlyAttribute
{
	// Fields
	private Boolean isReadOnly; // 0x10
	public static readonly ReadOnlyAttribute Yes; // 0x0
	public static readonly ReadOnlyAttribute No; // 0x8
	public static readonly ReadOnlyAttribute Default; // 0x10

	// Properties
	public Boolean IsReadOnly { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B1BBDC
	public Void .ctor(Boolean isReadOnly) { }

	// RVA: 0xFFFFFFFF75B1BC08
	public Boolean get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF75B1BC10
	public override Boolean Equals(Object value) { }

	// RVA: 0xFFFFFFFF75B1BCA4
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75B1BCAC
	public override Boolean IsDefaultAttribute() { }

	// RVA: 0xFFFFFFFF75B1BD34
	private static Void .cctor() { }

}

// Namespace: System.ComponentModel
public class ReferenceConverter
{
	// Fields
	private static readonly String none; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75B1BE18
	private static Void .cctor() { }

}

// Namespace: System.ComponentModel
internal sealed class ReflectEventDescriptor
{
	// Fields
	private Type type; // 0x60
	private readonly Type componentClass; // 0x68
	private MethodInfo addMethod; // 0x70
	private MethodInfo removeMethod; // 0x78
	private EventInfo realEvent; // 0x80
	private Boolean filledMethods; // 0x88

	// Properties
	public override Type EventType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B1BE94
	public Void .ctor(Type componentClass, String name, Type type, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B1C04C
	public Void .ctor(Type componentClass, EventInfo eventInfo) { }

	// RVA: 0xFFFFFFFF75B1C1B4
	public Void .ctor(Type componentType, EventDescriptor oldReflectEventDescriptor, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B1C2D0
	public override Type get_EventType() { }

	// RVA: 0xFFFFFFFF75B1C7B8
	protected override Void FillAttributes(IList attributes) { }

	// RVA: 0xFFFFFFFF75B1C820
	private Void FillEventInfoAttribute(EventInfo realEventInfo, IList attributes) { }

	// RVA: 0xFFFFFFFF75B1C2F4
	private Void FillMethods() { }

	// RVA: 0xFFFFFFFF75B1CAFC
	private Void FillSingleMethodAttribute(MethodInfo realMethodInfo, IList attributes) { }

}

// Namespace: System.ComponentModel
internal sealed class ReflectPropertyDescriptor
{
	// Fields
	private static readonly Type[] argsNone; // 0x0
	private static readonly Object noValue; // 0x8
	private static TraceSwitch PropDescCreateSwitch; // 0x10
	private static TraceSwitch PropDescUsageSwitch; // 0x18
	private static readonly Int32 BitDefaultValueQueried; // 0x20
	private static readonly Int32 BitGetQueried; // 0x24
	private static readonly Int32 BitSetQueried; // 0x28
	private static readonly Int32 BitShouldSerializeQueried; // 0x2C
	private static readonly Int32 BitResetQueried; // 0x30
	private static readonly Int32 BitChangedQueried; // 0x34
	private static readonly Int32 BitIPropChangedQueried; // 0x38
	private static readonly Int32 BitReadOnlyChecked; // 0x3C
	private static readonly Int32 BitAmbientValueQueried; // 0x40
	private static readonly Int32 BitSetOnDemand; // 0x44
	private BitVector32 state; // 0x7C
	private Type componentClass; // 0x80
	private Type type; // 0x88
	private Object defaultValue; // 0x90
	private Object ambientValue; // 0x98
	private PropertyInfo propInfo; // 0xA0
	private MethodInfo getMethod; // 0xA8
	private MethodInfo setMethod; // 0xB0
	private MethodInfo shouldSerializeMethod; // 0xB8
	private MethodInfo resetMethod; // 0xC0
	private Type receiverType; // 0xC8

	// Properties
	public override Type ComponentType { get; }
	private Boolean IsExtender { get; }
	public override Boolean IsReadOnly { get; }
	public override Type PropertyType { get; }
	private MethodInfo SetMethodValue { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B1D0E4
	public Void .ctor(Type componentClass, String name, Type type, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B1D360
	public Void .ctor(Type componentClass, String name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0xFFFFFFFF75B1D4F0
	public Void .ctor(Type componentClass, String name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0xFFFFFFFF75B1D610
	public Void .ctor(Type componentClass, PropertyDescriptor oldReflectPropertyDescriptor, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B1DB08
	public override Type get_ComponentType() { }

	// RVA: 0xFFFFFFFF75B1DB10
	private Boolean get_IsExtender() { }

	// RVA: 0xFFFFFFFF75B1DB50
	public override Boolean get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF75B1E0B4
	public override Type get_PropertyType() { }

	// RVA: 0xFFFFFFFF75B1DC48
	private MethodInfo get_SetMethodValue() { }

	// RVA: 0xFFFFFFFF75B1E0BC
	internal Type ExtenderGetReceiverType() { }

	// RVA: 0xFFFFFFFF75B18074
	internal Type ExtenderGetType(IExtenderProvider provider) { }

	// RVA: 0xFFFFFFFF75B1E0C4
	protected override Void FillAttributes(IList attributes) { }

	// RVA: 0xFFFFFFFF75B1EB64
	private static Void .cctor() { }

}

// Namespace: System.ComponentModel
internal sealed class ReflectTypeDescriptionProvider
{
	// Fields
	private Hashtable _typeData; // 0x20
	private static Type[] _typeConstructor; // 0x0
	private static Hashtable _editorTables; // 0x8
	private static Hashtable _intrinsicTypeConverters; // 0x10
	private static Object _intrinsicReferenceKey; // 0x18
	private static Object _intrinsicNullableKey; // 0x20
	private static Object _dictionaryKey; // 0x28
	private static Hashtable _propertyCache; // 0x30
	private static Hashtable _eventCache; // 0x38
	private static Hashtable _attributeCache; // 0x40
	private static Hashtable _extendedPropertyCache; // 0x48
	private static readonly Guid _extenderProviderKey; // 0x50
	private static readonly Guid _extenderPropertiesKey; // 0x60
	private static readonly Guid _extenderProviderPropertiesKey; // 0x70
	private static readonly Type[] _skipInterfaceAttributeList; // 0x80
	private static Object _internalSyncObject; // 0x88

	// Properties
	private static Hashtable IntrinsicTypeConverters { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B1ED94
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75B1ED98
	private static Hashtable get_IntrinsicTypeConverters() { }

	// RVA: 0xFFFFFFFF75B1F644
	internal static Void AddEditorTable(Type editorBaseType, Hashtable table) { }

	// RVA: 0xFFFFFFFF75B1F844
	public override Object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, Object[] args) { }

	// RVA: 0xFFFFFFFF75B1F9BC
	private static Object CreateInstance(Type objectType, Type callingType) { }

	// RVA: 0xFFFFFFFF75B1FAA4
	internal AttributeCollection GetAttributes(Type type) { }

	// RVA: 0xFFFFFFFF75B1FAC4
	public override IDictionary GetCache(Object instance) { }

	// RVA: 0xFFFFFFFF75B1FDF8
	internal String GetClassName(Type type) { }

	// RVA: 0xFFFFFFFF75B1FE54
	internal String GetComponentName(Type type, Object instance) { }

	// RVA: 0xFFFFFFFF72374B38
	internal TypeConverter GetConverter(Type type, Object instance) { }

	// RVA: 0xFFFFFFFF75B20040
	internal EventDescriptor GetDefaultEvent(Type type, Object instance) { }

	// RVA: 0xFFFFFFFF75B20220
	internal PropertyDescriptor GetDefaultProperty(Type type, Object instance) { }

	// RVA: 0xFFFFFFFF75B20400
	internal Object GetEditor(Type type, Object instance, Type editorBaseType) { }

	// RVA: 0xFFFFFFFF75B20A3C
	private static Hashtable GetEditorTable(Type editorBaseType) { }

	// RVA: 0xFFFFFFFF75B20DCC
	internal EventDescriptorCollection GetEvents(Type type) { }

	// RVA: 0xFFFFFFFF75B210A4
	internal AttributeCollection GetExtendedAttributes(Object instance) { }

	// RVA: 0xFFFFFFFF75B21104
	internal String GetExtendedClassName(Object instance) { }

	// RVA: 0xFFFFFFFF75B2113C
	internal String GetExtendedComponentName(Object instance) { }

	// RVA: 0xFFFFFFFF75B2117C
	internal TypeConverter GetExtendedConverter(Object instance) { }

	// RVA: 0xFFFFFFFF75B211BC
	internal EventDescriptor GetExtendedDefaultEvent(Object instance) { }

	// RVA: 0xFFFFFFFF75B211C4
	internal PropertyDescriptor GetExtendedDefaultProperty(Object instance) { }

	// RVA: 0xFFFFFFFF75B211CC
	internal Object GetExtendedEditor(Object instance, Type editorBaseType) { }

	// RVA: 0xFFFFFFFF75B2121C
	internal EventDescriptorCollection GetExtendedEvents(Object instance) { }

	// RVA: 0xFFFFFFFF75B2127C
	internal PropertyDescriptorCollection GetExtendedProperties(Object instance) { }

	// RVA: 0xFFFFFFFF75B2250C
	protected internal override IExtenderProvider[] GetExtenderProviders(Object instance) { }

	// RVA: 0xFFFFFFFF75B2298C
	private static IExtenderProvider[] GetExtenders(ICollection components, Object instance, IDictionary cache) { }

	// RVA: 0xFFFFFFFF75B233F8
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(Object instance) { }

	// RVA: 0xFFFFFFFF75B23400
	public override String GetFullComponentName(Object component) { }

	// RVA: 0xFFFFFFFF75B235CC
	internal Type[] GetPopulatedTypes(Module module) { }

	// RVA: 0xFFFFFFFF75B23A04
	internal PropertyDescriptorCollection GetProperties(Type type) { }

	// RVA: 0xFFFFFFFF75B23CDC
	public override Type GetReflectionType(Type objectType, Object instance) { }

	// RVA: 0xFFFFFFFF7237437C
	private ReflectedTypeData GetTypeData(Type type, Boolean createIfNeeded) { }

	// RVA: 0xFFFFFFFF75B23D1C
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, Object instance) { }

	// RVA: 0xFFFFFFFF75B23D24
	private static Type GetTypeFromName(String typeName) { }

	// RVA: 0xFFFFFFFF75B23DF4
	internal Boolean IsPopulated(Type type) { }

	// RVA: 0xFFFFFFFF75B23E28
	private static Attribute[] ReflectGetAttributes(Type type) { }

	// RVA: 0xFFFFFFFF75B1CDBC
	internal static Attribute[] ReflectGetAttributes(MemberInfo member) { }

	// RVA: 0xFFFFFFFF75B24154
	private static EventDescriptor[] ReflectGetEvents(Type type) { }

	// RVA: 0xFFFFFFFF75B217E4
	private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	// RVA: 0xFFFFFFFF75B24714
	private static PropertyDescriptor[] ReflectGetProperties(Type type) { }

	// RVA: 0xFFFFFFFF75B24C54
	internal Void Refresh(Type type) { }

	// RVA: 0xFFFFFFFF75B24D40
	private static Object SearchIntrinsicTable(Hashtable table, Type callingType) { }

	// RVA: 0xFFFFFFFF75B255AC
	private static Void .cctor() { }

}

// Namespace: 
private class ReflectedTypeData
{
	// Fields
	private Type _type; // 0x10
	private AttributeCollection _attributes; // 0x18
	private EventDescriptorCollection _events; // 0x20
	private PropertyDescriptorCollection _properties; // 0x28
	private TypeConverter _converter; // 0x30
	private Object[] _editors; // 0x38
	private Type[] _editorTypes; // 0x40
	private Int32 _editorCount; // 0x48

	// Properties
	internal Boolean IsPopulated { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B23CE4
	internal Void .ctor(Type type) { }

	// RVA: 0xFFFFFFFF75B239E8
	internal Boolean get_IsPopulated() { }

	// RVA: 0xFFFFFFFF723745D4
	internal AttributeCollection GetAttributes() { }

	// RVA: 0xFFFFFFFF75B1FE2C
	internal String GetClassName(Object instance) { }

	// RVA: 0xFFFFFFFF75B1FE84
	internal String GetComponentName(Object instance) { }

	// RVA: 0xFFFFFFFF72374B68
	internal TypeConverter GetConverter(Object instance) { }

	// RVA: 0xFFFFFFFF75B20070
	internal EventDescriptor GetDefaultEvent(Object instance) { }

	// RVA: 0xFFFFFFFF75B20250
	internal PropertyDescriptor GetDefaultProperty(Object instance) { }

	// RVA: 0xFFFFFFFF75B20438
	internal Object GetEditor(Object instance, Type editorBaseType) { }

	// RVA: 0xFFFFFFFF75B25D5C
	private static EditorAttribute GetEditorAttribute(AttributeCollection attributes, Type editorBaseType) { }

	// RVA: 0xFFFFFFFF75B20DEC
	internal EventDescriptorCollection GetEvents() { }

	// RVA: 0xFFFFFFFF75B23A24
	internal PropertyDescriptorCollection GetProperties() { }

	// RVA: 0xFFFFFFFF75B258C8
	private Type GetTypeFromName(String typeName) { }

	// RVA: 0xFFFFFFFF75B24C78
	internal Void Refresh() { }

}

// Namespace: System.ComponentModel
public class RefreshEventArgs
{
	// Fields
	private Object componentChanged; // 0x10
	private Type typeChanged; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75B260B8
	public Void .ctor(Object componentChanged) { }

	// RVA: 0xFFFFFFFF75B26178
	public Void .ctor(Type typeChanged) { }

}

// Namespace: System.ComponentModel
public sealed class RefreshEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75B26208
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B2624C
	public virtual Void Invoke(RefreshEventArgs e) { }

	// RVA: 0xFFFFFFFF75B265DC
	public virtual IAsyncResult BeginInvoke(RefreshEventArgs e, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B2662C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public class SByteConverter
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B26638
	internal override Type get_TargetType() { }

	// RVA: 0xFFFFFFFF75B2667C
	internal override Object FromString(String value, Int32 radix) { }

	// RVA: 0xFFFFFFFF75B266E4
	internal override Object FromString(String value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B26720
	internal override Object FromString(String value, CultureInfo culture) { }

	// RVA: 0xFFFFFFFF75B2675C
	internal override String ToString(Object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B267D8
	public Void .ctor() { }

}

// Namespace: System.ComponentModel
public class SingleConverter
{
	// Properties
	internal override Boolean AllowHex { get; }
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B267DC
	internal override Boolean get_AllowHex() { }

	// RVA: 0xFFFFFFFF75B267E4
	internal override Type get_TargetType() { }

	// RVA: 0xFFFFFFFF75B26828
	internal override Object FromString(String value, Int32 radix) { }

	// RVA: 0xFFFFFFFF75B268B4
	internal override Object FromString(String value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B268F0
	internal override Object FromString(String value, CultureInfo culture) { }

	// RVA: 0xFFFFFFFF75B2692C
	internal override String ToString(Object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B269A8
	public Void .ctor() { }

}

// Namespace: System.ComponentModel
public class StringConverter
{
	// Methods

	// RVA: 0xFFFFFFFF75B269AC
	public override Boolean CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0xFFFFFFFF75B26A14
	public override Object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, Object value) { }

	// RVA: 0xFFFFFFFF75B26A44
	public Void .ctor() { }

}

// Namespace: System.ComponentModel
public class TimeSpanConverter
{
	// Methods

	// RVA: 0xFFFFFFFF75B26A48
	public override Boolean CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0xFFFFFFFF75B26AB0
	public override Boolean CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xFFFFFFFF75B26B38
	public override Object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, Object value) { }

	// RVA: 0xFFFFFFFF75B26D20
	public override Object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, Object value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75B26F48
	public Void .ctor() { }

}

// Namespace: System.ComponentModel
public class TypeConverter
{
	// Fields
	private const String s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
	private static Boolean useCompatibleTypeConversion; // 0x0

	// Properties
	private static Boolean UseCompatibleTypeConversion { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B26F4C
	private static Boolean get_UseCompatibleTypeConversion() { }

	// RVA: 0xFFFFFFFF75B26F98
	public Boolean CanConvertFrom(Type sourceType) { }

	// RVA: 0xFFFFFFFF75B0FFD4
	public virtual Boolean CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0xFFFFFFFF75B26FB0
	public Boolean CanConvertTo(Type destinationType) { }

	// RVA: 0xFFFFFFFF75B104F0
	public virtual Boolean CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xFFFFFFFF75B26FC8
	public Object ConvertFrom(Object value) { }

	// RVA: 0xFFFFFFFF75B10048
	public virtual Object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, Object value) { }

	// RVA: 0xFFFFFFFF75B27158
	public Object ConvertFromInvariantString(String text) { }

	// RVA: 0xFFFFFFFF75B271C8
	public Object ConvertFromInvariantString(ITypeDescriptorContext context, String text) { }

	// RVA: 0xFFFFFFFF72374FD0
	public Object ConvertFromString(String text) { }

	// RVA: 0xFFFFFFFF75B27234
	public Object ConvertFromString(ITypeDescriptorContext context, String text) { }

	// RVA: 0xFFFFFFFF75B271B8
	public Object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, String text) { }

	// RVA: 0xFFFFFFFF75B272A0
	public Object ConvertTo(Object value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75B102DC
	public virtual Object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, Object value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75B27420
	public String ConvertToInvariantString(Object value) { }

	// RVA: 0xFFFFFFFF75B15D78
	public String ConvertToInvariantString(ITypeDescriptorContext context, Object value) { }

	// RVA: 0xFFFFFFFF75B2751C
	public String ConvertToString(Object value) { }

	// RVA: 0xFFFFFFFF75B275DC
	public String ConvertToString(ITypeDescriptorContext context, Object value) { }

	// RVA: 0xFFFFFFFF75B27474
	public String ConvertToString(ITypeDescriptorContext context, CultureInfo culture, Object value) { }

	// RVA: 0xFFFFFFFF75B276A8
	public Object CreateInstance(IDictionary propertyValues) { }

	// RVA: 0xFFFFFFFF75B276C0
	public virtual Object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0xFFFFFFFF75B27028
	protected Exception GetConvertFromException(Object value) { }

	// RVA: 0xFFFFFFFF75B272C0
	protected Exception GetConvertToException(Object value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75B276C8
	public Boolean GetCreateInstanceSupported() { }

	// RVA: 0xFFFFFFFF75B276DC
	public virtual Boolean GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0xFFFFFFFF75B276E4
	public PropertyDescriptorCollection GetProperties(Object value) { }

	// RVA: 0xFFFFFFFF75B276F0
	public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, Object value) { }

	// RVA: 0xFFFFFFFF75B277B8
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, Object value, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B277C0
	public Boolean GetPropertiesSupported() { }

	// RVA: 0xFFFFFFFF75B277D4
	public virtual Boolean GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0xFFFFFFFF75B277DC
	public ICollection GetStandardValues() { }

	// RVA: 0xFFFFFFFF75B277F0
	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0xFFFFFFFF75B277F8
	public Boolean GetStandardValuesExclusive() { }

	// RVA: 0xFFFFFFFF75B2780C
	public virtual Boolean GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0xFFFFFFFF75B27814
	public Boolean GetStandardValuesSupported() { }

	// RVA: 0xFFFFFFFF75B27828
	public virtual Boolean GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0xFFFFFFFF75B27830
	public Boolean IsValid(Object value) { }

	// RVA: 0xFFFFFFFF75B27848
	public virtual Boolean IsValid(ITypeDescriptorContext context, Object value) { }

	// RVA: 0xFFFFFFFF75B279A8
	protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, String[] names) { }

	// RVA: 0xFFFFFFFF75B10548
	public Void .ctor() { }

	// RVA: -1
	private static Void .cctor() { }

}

// Namespace: 
protected abstract class SimplePropertyDescriptor
{
	// Fields
	private Type componentType; // 0x80
	private Type propertyType; // 0x88

	// Properties
	public override Type ComponentType { get; }
	public override Boolean IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B0EC8C
	protected Void .ctor(Type componentType, String name, Type propertyType, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B279EC
	public override Type get_ComponentType() { }

	// RVA: 0xFFFFFFFF75B279F4
	public override Boolean get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF75B27A7C
	public override Type get_PropertyType() { }

}

// Namespace: 
public class StandardValuesCollection
{
	// Fields
	private ICollection values; // 0x10
	private Array valueArray; // 0x18

	// Properties
	public Int32 Count { get; }
	private Int32 System.Collections.ICollection.Count { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B106E0
	public Void .ctor(ICollection values) { }

	// RVA: 0xFFFFFFFF75B27A84
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75B27B24
	public Void CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF75B27BBC
	public IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B27C3C
	private Int32 System.Collections.ICollection.get_Count() { }

	// RVA: 0xFFFFFFFF75B27C40
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75B27C48
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xFFFFFFFF75B27C50
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF75B27C54
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.ComponentModel
public sealed class TypeConverterAttribute
{
	// Fields
	private String typeName; // 0x10
	public static readonly TypeConverterAttribute Default; // 0x0

	// Properties
	public String ConverterTypeName { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B27C58
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B27CA8
	public Void .ctor(Type type) { }

	// RVA: 0xFFFFFFFF75B27D08
	public String get_ConverterTypeName() { }

	// RVA: 0xFFFFFFFF75B27D10
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75B27D90
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75B27DB8
	private static Void .cctor() { }

}

// Namespace: System.ComponentModel
public abstract class TypeDescriptionProvider
{
	// Fields
	private TypeDescriptionProvider _parent; // 0x10
	private EmptyCustomTypeDescriptor _emptyDescriptor; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75B12C90
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF75B27E64
	protected Void .ctor(TypeDescriptionProvider parent) { }

	// RVA: 0xFFFFFFFF75B27E9C
	public virtual Object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, Object[] args) { }

	// RVA: 0xFFFFFFFF75B27F98
	public virtual IDictionary GetCache(Object instance) { }

	// RVA: 0xFFFFFFFF75B27FB4
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(Object instance) { }

	// RVA: 0xFFFFFFFF75B2805C
	protected internal virtual IExtenderProvider[] GetExtenderProviders(Object instance) { }

	// RVA: 0xFFFFFFFF75B28118
	public virtual String GetFullComponentName(Object component) { }

	// RVA: 0xFFFFFFFF75B282A0
	public Type GetReflectionType(Type objectType) { }

	// RVA: 0xFFFFFFFF75B282B4
	public Type GetReflectionType(Object instance) { }

	// RVA: 0xFFFFFFFF75B28354
	public virtual Type GetReflectionType(Type objectType, Object instance) { }

	// RVA: 0xFFFFFFFF75B28374
	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	// RVA: 0xFFFFFFFF75B28200
	public ICustomTypeDescriptor GetTypeDescriptor(Object instance) { }

	// RVA: 0xFFFFFFFF75B28388
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, Object instance) { }

}

// Namespace: 
private sealed class EmptyCustomTypeDescriptor
{
	// Methods

	// RVA: 0xFFFFFFFF75B28058
	public Void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class TypeDescriptionProviderAttribute
{
	// Fields
	private String _typeName; // 0x10

	// Properties
	public String TypeName { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B28434
	public Void .ctor(String typeName) { }

	// RVA: 0xFFFFFFFF75B284E8
	public String get_TypeName() { }

}

// Namespace: System.ComponentModel
public sealed class TypeDescriptor
{
	// Fields
	private static WeakHashtable _providerTable; // 0x0
	private static Hashtable _providerTypeTable; // 0x8
	private static Hashtable _defaultProviders; // 0x10
	private static WeakHashtable _associationTable; // 0x18
	private static Int32 _metadataVersion; // 0x20
	private static Int32 _collisionIndex; // 0x24
	private static BooleanSwitch TraceDescriptor; // 0x28
	private const Int32 PIPELINE_ATTRIBUTES = 0;
	private const Int32 PIPELINE_PROPERTIES = 1;
	private const Int32 PIPELINE_EVENTS = 2;
	private static readonly Guid[] _pipelineInitializeKeys; // 0x30
	private static readonly Guid[] _pipelineMergeKeys; // 0x38
	private static readonly Guid[] _pipelineFilterKeys; // 0x40
	private static readonly Guid[] _pipelineAttributeFilterKeys; // 0x48
	private static Object _internalSyncObject; // 0x50
	private static RefreshEventHandler Refreshed; // 0x58

	// Properties
	public static IComNativeDescriptorHandler ComNativeDescriptorHandler { get; set; }
	public static Type ComObjectType { get; }
	public static Type InterfaceType { get; }
	internal static Int32 MetadataVersion { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B284F0
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF75B284F4
	public static IComNativeDescriptorHandler get_ComNativeDescriptorHandler() { }

	// RVA: 0xFFFFFFFF75B285FC
	public static Void set_ComNativeDescriptorHandler(IComNativeDescriptorHandler value) { }

	// RVA: 0xFFFFFFFF75B28598
	public static Type get_ComObjectType() { }

	// RVA: 0xFFFFFFFF72375054
	public static Type get_InterfaceType() { }

	// RVA: 0xFFFFFFFF75B28900
	internal static Int32 get_MetadataVersion() { }

	// RVA: 0xFFFFFFFF75B28960
	public static Void add_Refreshed(RefreshEventHandler value) { }

	// RVA: 0xFFFFFFFF75B28A30
	public static Void remove_Refreshed(RefreshEventHandler value) { }

	// RVA: 0xFFFFFFFF75B28B00
	public static TypeDescriptionProvider AddAttributes(Type type, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B28CF0
	public static TypeDescriptionProvider AddAttributes(Object instance, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B290F0
	public static Void AddEditorTable(Type editorBaseType, Hashtable table) { }

	// RVA: 0xFFFFFFFF75B286D8
	public static Void AddProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0xFFFFFFFF75B28EA8
	public static Void AddProvider(TypeDescriptionProvider provider, Object instance) { }

	// RVA: 0xFFFFFFFF75B29EA8
	public static Void AddProviderTransparent(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0xFFFFFFFF75B29F9C
	public static Void AddProviderTransparent(TypeDescriptionProvider provider, Object instance) { }

	// RVA: 0xFFFFFFFF72375530
	private static Void CheckDefaultProvider(Type type) { }

	// RVA: 0xFFFFFFFF75B2A074
	public static Void CreateAssociation(Object primary, Object secondary) { }

	// RVA: 0xFFFFFFFF75B2A754
	public static IDesigner CreateDesigner(IComponent component, Type designerBaseType) { }

	// RVA: 0xFFFFFFFF75B2AB60
	public static EventDescriptor CreateEvent(Type componentType, String name, Type type, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B2ABE0
	public static EventDescriptor CreateEvent(Type componentType, EventDescriptor oldEventDescriptor, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B2AC50
	public static Object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, Object[] args) { }

	// RVA: 0xFFFFFFFF75B2AED8
	public static PropertyDescriptor CreateProperty(Type componentType, String name, Type type, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B2AF58
	public static PropertyDescriptor CreateProperty(Type componentType, PropertyDescriptor oldPropertyDescriptor, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B2B0CC
	private static Void DebugValidate(Type type, AttributeCollection attributes, AttributeCollection debugAttributes) { }

	// RVA: 0xFFFFFFFF75B2B0D0
	private static Void DebugValidate(AttributeCollection attributes, AttributeCollection debugAttributes) { }

	// RVA: 0xFFFFFFFF75B2B0D4
	private static Void DebugValidate(AttributeCollection attributes, Type type) { }

	// RVA: 0xFFFFFFFF75B2B0D8
	private static Void DebugValidate(AttributeCollection attributes, Object instance, Boolean noCustomTypeDesc) { }

	// RVA: 0xFFFFFFFF75B2B0DC
	private static Void DebugValidate(TypeConverter converter, Type type) { }

	// RVA: 0xFFFFFFFF75B2B0E0
	private static Void DebugValidate(TypeConverter converter, Object instance, Boolean noCustomTypeDesc) { }

	// RVA: 0xFFFFFFFF75B2B0E4
	private static Void DebugValidate(EventDescriptorCollection events, Type type, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B2B0E8
	private static Void DebugValidate(EventDescriptorCollection events, Object instance, Attribute[] attributes, Boolean noCustomTypeDesc) { }

	// RVA: 0xFFFFFFFF75B2B0EC
	private static Void DebugValidate(PropertyDescriptorCollection properties, Type type, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B2B0F0
	private static Void DebugValidate(PropertyDescriptorCollection properties, Object instance, Attribute[] attributes, Boolean noCustomTypeDesc) { }

	// RVA: 0xFFFFFFFF75B2B0F4
	private static ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B2B4D8
	public static Object GetAssociation(Type type, Object primary) { }

	// RVA: 0xFFFFFFFF75B1EA1C
	public static AttributeCollection GetAttributes(Type componentType) { }

	// RVA: 0xFFFFFFFF75B25868
	public static AttributeCollection GetAttributes(Object component) { }

	// RVA: 0xFFFFFFFF75B2BB00
	public static AttributeCollection GetAttributes(Object component, Boolean noCustomTypeDesc) { }

	// RVA: 0xFFFFFFFF75B2176C
	internal static IDictionary GetCache(Object instance) { }

	// RVA: 0xFFFFFFFF75B2F2F4
	public static String GetClassName(Object component) { }

	// RVA: 0xFFFFFFFF75B2F354
	public static String GetClassName(Object component, Boolean noCustomTypeDesc) { }

	// RVA: 0xFFFFFFFF75B2F43C
	public static String GetClassName(Type componentType) { }

	// RVA: 0xFFFFFFFF75B2356C
	public static String GetComponentName(Object component) { }

	// RVA: 0xFFFFFFFF75B2F528
	public static String GetComponentName(Object component, Boolean noCustomTypeDesc) { }

	// RVA: 0xFFFFFFFF75B2F610
	public static TypeConverter GetConverter(Object component) { }

	// RVA: 0xFFFFFFFF75B2F670
	public static TypeConverter GetConverter(Object component, Boolean noCustomTypeDesc) { }

	// RVA: 0xFFFFFFFF72375BDC
	public static TypeConverter GetConverter(Type type) { }

	// RVA: 0xFFFFFFFF75B2F758
	public static EventDescriptor GetDefaultEvent(Type componentType) { }

	// RVA: 0xFFFFFFFF75B2F878
	public static EventDescriptor GetDefaultEvent(Object component) { }

	// RVA: 0xFFFFFFFF75B2F8D8
	public static EventDescriptor GetDefaultEvent(Object component, Boolean noCustomTypeDesc) { }

	// RVA: 0xFFFFFFFF75B2F9D8
	public static PropertyDescriptor GetDefaultProperty(Type componentType) { }

	// RVA: 0xFFFFFFFF75B2FAF8
	public static PropertyDescriptor GetDefaultProperty(Object component) { }

	// RVA: 0xFFFFFFFF75B2FB58
	public static PropertyDescriptor GetDefaultProperty(Object component, Boolean noCustomTypeDesc) { }

	// RVA: 0xFFFFFFFF72375AB4
	internal static ICustomTypeDescriptor GetDescriptor(Type type, String typeName) { }

	// RVA: 0xFFFFFFFF75B2BEB8
	internal static ICustomTypeDescriptor GetDescriptor(Object component, Boolean noCustomTypeDesc) { }

	// RVA: 0xFFFFFFFF75B2C09C
	internal static ICustomTypeDescriptor GetExtendedDescriptor(Object component) { }

	// RVA: 0xFFFFFFFF75B2FC58
	public static Object GetEditor(Object component, Type editorBaseType) { }

	// RVA: 0xFFFFFFFF75B2FCC8
	public static Object GetEditor(Object component, Type editorBaseType, Boolean noCustomTypeDesc) { }

	// RVA: 0xFFFFFFFF75B2FE20
	public static Object GetEditor(Type type, Type editorBaseType) { }

	// RVA: 0xFFFFFFFF75B25A6C
	public static EventDescriptorCollection GetEvents(Type componentType) { }

	// RVA: 0xFFFFFFFF75B2FF78
	public static EventDescriptorCollection GetEvents(Type componentType, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B25A08
	public static EventDescriptorCollection GetEvents(Object component) { }

	// RVA: 0xFFFFFFFF75B305FC
	public static EventDescriptorCollection GetEvents(Object component, Boolean noCustomTypeDesc) { }

	// RVA: 0xFFFFFFFF75B3066C
	public static EventDescriptorCollection GetEvents(Object component, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B3017C
	public static EventDescriptorCollection GetEvents(Object component, Attribute[] attributes, Boolean noCustomTypeDesc) { }

	// RVA: 0xFFFFFFFF75B30CF0
	private static String GetExtenderCollisionSuffix(MemberDescriptor member) { }

	// RVA: 0xFFFFFFFF75B31000
	public static String GetFullComponentName(Object component) { }

	// RVA: 0xFFFFFFFF72375CC4
	private static Type GetNodeForBaseType(Type searchType) { }

	// RVA: 0xFFFFFFFF75B25C14
	public static PropertyDescriptorCollection GetProperties(Type componentType) { }

	// RVA: 0xFFFFFFFF75B310C4
	public static PropertyDescriptorCollection GetProperties(Type componentType, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B25BB4
	public static PropertyDescriptorCollection GetProperties(Object component) { }

	// RVA: 0xFFFFFFFF75B312C8
	public static PropertyDescriptorCollection GetProperties(Object component, Boolean noCustomTypeDesc) { }

	// RVA: 0xFFFFFFFF75B31980
	public static PropertyDescriptorCollection GetProperties(Object component, Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B319F0
	public static PropertyDescriptorCollection GetProperties(Object component, Attribute[] attributes, Boolean noCustomTypeDesc) { }

	// RVA: 0xFFFFFFFF75B3133C
	private static PropertyDescriptorCollection GetPropertiesImpl(Object component, Attribute[] attributes, Boolean noCustomTypeDesc, Boolean noAttributes) { }

	// RVA: 0xFFFFFFFF75B28C34
	public static TypeDescriptionProvider GetProvider(Type type) { }

	// RVA: 0xFFFFFFFF75B28E08
	public static TypeDescriptionProvider GetProvider(Object instance) { }

	// RVA: 0xFFFFFFFF75B12CF4
	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	// RVA: 0xFFFFFFFF75B0FBC8
	public static Type GetReflectionType(Type type) { }

	// RVA: 0xFFFFFFFF75B31A68
	public static Type GetReflectionType(Object instance) { }

	// RVA: 0xFFFFFFFF72374FEC
	private static TypeDescriptionNode NodeFor(Type type) { }

	// RVA: 0xFFFFFFFF723750C8
	private static TypeDescriptionNode NodeFor(Type type, Boolean createDelegator) { }

	// RVA: 0xFFFFFFFF75B2F294
	private static TypeDescriptionNode NodeFor(Object instance) { }

	// RVA: 0xFFFFFFFF75B2961C
	private static TypeDescriptionNode NodeFor(Object instance, Boolean createDelegator) { }

	// RVA: 0xFFFFFFFF75B31B14
	private static Void NodeRemove(Object key, TypeDescriptionProvider provider) { }

	// RVA: 0xFFFFFFFF75B306DC
	private static ICollection PipelineAttributeFilter(Int32 pipelineType, ICollection members, Attribute[] filter, Object instance, IDictionary cache) { }

	// RVA: 0xFFFFFFFF75B2D268
	private static ICollection PipelineFilter(Int32 pipelineType, ICollection members, Object instance, IDictionary cache) { }

	// RVA: 0xFFFFFFFF75B2EB7C
	private static ICollection PipelineInitialize(Int32 pipelineType, ICollection members, IDictionary cache) { }

	// RVA: 0xFFFFFFFF75B2C160
	private static ICollection PipelineMerge(Int32 pipelineType, ICollection primary, ICollection secondary, Object instance, IDictionary cache) { }

	// RVA: 0xFFFFFFFF75B31E68
	private static Void RaiseRefresh(Object component) { }

	// RVA: 0xFFFFFFFF75B31F18
	private static Void RaiseRefresh(Type type) { }

	// RVA: 0xFFFFFFFF75B31FC8
	public static Void Refresh(Object component) { }

	// RVA: 0xFFFFFFFF75B29778
	private static Void Refresh(Object component, Boolean refreshReflectionProvider) { }

	// RVA: 0xFFFFFFFF75B2915C
	public static Void Refresh(Type type) { }

	// RVA: 0xFFFFFFFF75B32028
	public static Void Refresh(Module module) { }

	// RVA: 0xFFFFFFFF75B3280C
	public static Void Refresh(Assembly assembly) { }

	// RVA: 0xFFFFFFFF75B328D8
	public static Void RemoveAssociation(Object primary, Object secondary) { }

	// RVA: 0xFFFFFFFF75B32C20
	public static Void RemoveAssociations(Object primary) { }

	// RVA: 0xFFFFFFFF75B32CF4
	public static Void RemoveProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0xFFFFFFFF75B32DF0
	public static Void RemoveProvider(TypeDescriptionProvider provider, Object instance) { }

	// RVA: 0xFFFFFFFF75B32ED0
	public static Void RemoveProviderTransparent(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0xFFFFFFFF75B32FC4
	public static Void RemoveProviderTransparent(TypeDescriptionProvider provider, Object instance) { }

	// RVA: 0xFFFFFFFF75B2B434
	private static Boolean ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	// RVA: 0xFFFFFFFF75B17574
	public static Void SortDescriptorArray(IList infos) { }

	// RVA: 0xFFFFFFFF75B3309C
	internal static Void Trace(String message, Object[] args) { }

	// RVA: 0xFFFFFFFF75B330A0
	private static Void .cctor() { }

}

// Namespace: 
private sealed class AttributeProvider
{
	// Fields
	private Attribute[] _attrs; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75B33494
	internal Void .ctor(TypeDescriptionProvider existingProvider, Attribute[] attrs) { }

	// RVA: 0xFFFFFFFF75B334D8
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, Object instance) { }

}

// Namespace: 
private class AttributeTypeDescriptor
{
	// Fields
	private Attribute[] _attributeArray; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75B33594
	internal Void .ctor(Attribute[] attrs, ICustomTypeDescriptor parent) { }

	// RVA: 0xFFFFFFFF75B335DC
	public override AttributeCollection GetAttributes() { }

}

// Namespace: 
private sealed class ComNativeDescriptionProvider
{
	// Fields
	private IComNativeDescriptorHandler _handler; // 0x20

	// Properties
	internal IComNativeDescriptorHandler Handler { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B33860
	internal Void .ctor(IComNativeDescriptorHandler handler) { }

	// RVA: 0xFFFFFFFF75B338A4
	internal IComNativeDescriptorHandler get_Handler() { }

	// RVA: 0xFFFFFFFF75B338AC
	internal Void set_Handler(IComNativeDescriptorHandler value) { }

	// RVA: 0xFFFFFFFF75B338E4
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, Object instance) { }

}

// Namespace: 
private sealed class ComNativeTypeDescriptor
{
	// Fields
	private IComNativeDescriptorHandler _handler; // 0x10
	private Object _instance; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75B33A48
	internal Void .ctor(IComNativeDescriptorHandler handler, Object instance) { }

	// RVA: 0xFFFFFFFF75B33AAC
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xFFFFFFFF75B33B70
	private String System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xFFFFFFFF75B33C38
	private String System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xFFFFFFFF75B33C40
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xFFFFFFFF75B33D08
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xFFFFFFFF75B33DD0
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xFFFFFFFF75B33E98
	private Object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xFFFFFFFF75B33F68
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xFFFFFFFF75B34030
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B34100
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xFFFFFFFF75B341CC
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

}

// Namespace: 
private sealed class AttributeFilterCacheItem
{
	// Fields
	private Attribute[] _filter; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75B333B8
	internal Void .ctor(Attribute[] filter, ICollection filteredMembers) { }

	// RVA: 0xFFFFFFFF75B3341C
	internal Boolean IsValid(Attribute[] filter) { }

}

// Namespace: 
private sealed class FilterCacheItem
{
	// Fields
	private ITypeDescriptorFilterService _filterService; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75B3429C
	internal Void .ctor(ITypeDescriptorFilterService filterService, ICollection filteredMembers) { }

	// RVA: 0xFFFFFFFF75B34300
	internal Boolean IsValid(ITypeDescriptorFilterService filterService) { }

}

// Namespace: 
private interface IUnimplemented
{}

// Namespace: 
private sealed class MemberDescriptorComparer
{
	// Fields
	public static readonly MemberDescriptorComparer Instance; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75B34310
	public Int32 Compare(Object left, Object right) { }

	// RVA: 0xFFFFFFFF75B34440
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B34444
	private static Void .cctor() { }

}

// Namespace: 
private sealed class MergedTypeDescriptor
{
	// Fields
	private ICustomTypeDescriptor _primary; // 0x10
	private ICustomTypeDescriptor _secondary; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75B344BC
	internal Void .ctor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) { }

	// RVA: 0xFFFFFFFF75B34520
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xFFFFFFFF75B34654
	private String System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xFFFFFFFF75B34790
	private String System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xFFFFFFFF75B348CC
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xFFFFFFFF75B34A08
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xFFFFFFFF75B34B44
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xFFFFFFFF75B34C80
	private Object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xFFFFFFFF75B34E30
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xFFFFFFFF75B34F6C
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF75B350B4
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xFFFFFFFF75B351F0
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

}

// Namespace: 
private sealed class TypeDescriptionNode
{
	// Fields
	internal TypeDescriptionNode Next; // 0x20
	internal TypeDescriptionProvider Provider; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75B35338
	internal Void .ctor(TypeDescriptionProvider provider) { }

	// RVA: 0xFFFFFFFF75B3537C
	public override Object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, Object[] args) { }

	// RVA: 0xFFFFFFFF75B35500
	public override IDictionary GetCache(Object instance) { }

	// RVA: 0xFFFFFFFF75B35598
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(Object instance) { }

	// RVA: 0xFFFFFFFF75B356D8
	protected internal override IExtenderProvider[] GetExtenderProviders(Object instance) { }

	// RVA: 0xFFFFFFFF75B35770
	public override String GetFullComponentName(Object component) { }

	// RVA: 0xFFFFFFFF75B35814
	public override Type GetReflectionType(Type objectType, Object instance) { }

	// RVA: 0xFFFFFFFF72375E20
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, Object instance) { }

}

// Namespace: 
private struct DefaultExtendedTypeDescriptor
{
	// Fields
	private TypeDescriptionNode _node; // 0x10
	private Object _instance; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF711475D4
	internal Void .ctor(TypeDescriptionNode node, Object instance) { }

	// RVA: 0xFFFFFFFF71147638
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xFFFFFFFF71147640
	private String System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xFFFFFFFF71147648
	private String System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xFFFFFFFF71147650
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xFFFFFFFF71147658
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xFFFFFFFF71147660
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xFFFFFFFF71147668
	private Object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xFFFFFFFF71147670
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xFFFFFFFF71147678
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF71147680
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xFFFFFFFF71147688
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

}

// Namespace: 
private struct DefaultTypeDescriptor
{
	// Fields
	private TypeDescriptionNode _node; // 0x10
	private Type _objectType; // 0x18
	private Object _instance; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF711476CC
	internal Void .ctor(TypeDescriptionNode node, Type objectType, Object instance) { }

	// RVA: 0xFFFFFFFF71147750
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xFFFFFFFF71147758
	private String System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xFFFFFFFF71147760
	private String System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xFFFFFFFF70C5A6A8
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xFFFFFFFF71147768
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xFFFFFFFF71147770
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xFFFFFFFF71147778
	private Object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xFFFFFFFF71147780
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xFFFFFFFF71147788
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xFFFFFFFF71147790
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xFFFFFFFF71147798
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

}

// Namespace: 
private sealed class TypeDescriptorComObject
{}

// Namespace: 
private sealed class TypeDescriptorInterface
{}

// Namespace: System.ComponentModel
public class UInt16Converter
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B38978
	internal override Type get_TargetType() { }

	// RVA: 0xFFFFFFFF75B389BC
	internal override Object FromString(String value, Int32 radix) { }

	// RVA: 0xFFFFFFFF75B38A24
	internal override Object FromString(String value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B38A60
	internal override Object FromString(String value, CultureInfo culture) { }

	// RVA: 0xFFFFFFFF75B38A9C
	internal override String ToString(Object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B38B18
	public Void .ctor() { }

}

// Namespace: System.ComponentModel
public class UInt32Converter
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B38B20
	internal override Type get_TargetType() { }

	// RVA: 0xFFFFFFFF75B38B64
	internal override Object FromString(String value, Int32 radix) { }

	// RVA: 0xFFFFFFFF75B38BCC
	internal override Object FromString(String value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B38C08
	internal override Object FromString(String value, CultureInfo culture) { }

	// RVA: 0xFFFFFFFF75B38C44
	internal override String ToString(Object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B38CC0
	public Void .ctor() { }

}

// Namespace: System.ComponentModel
public class UInt64Converter
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B38CC8
	internal override Type get_TargetType() { }

	// RVA: 0xFFFFFFFF75B38D0C
	internal override Object FromString(String value, Int32 radix) { }

	// RVA: 0xFFFFFFFF75B38D74
	internal override Object FromString(String value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B38DB0
	internal override Object FromString(String value, CultureInfo culture) { }

	// RVA: 0xFFFFFFFF75B38DEC
	internal override String ToString(Object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B38E68
	public Void .ctor() { }

}

// Namespace: System.ComponentModel
public class Win32Exception
{
	// Fields
	private readonly Int32 nativeErrorCode; // 0x88
	private static Boolean s_ErrorMessagesInitialized; // 0x0
	private static Dictionary<T0, T1> s_ErrorMessage; // 0x8

	// Properties
	public Int32 NativeErrorCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B397A8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF72376294
	public Void .ctor(Int32 error) { }

	// RVA: 0xFFFFFFFF75B397F0
	public Void .ctor(Int32 error, String message) { }

	// RVA: 0xFFFFFFFF75B39820
	public Void .ctor(String message) { }

	// RVA: 0xFFFFFFFF75B39884
	public Void .ctor(String message, Exception innerException) { }

	// RVA: 0xFFFFFFFF75B398D0
	protected Void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF75B39960
	public Int32 get_NativeErrorCode() { }

	// RVA: 0xFFFFFFFF75B39968
	public override Void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF72376328
	internal static String GetErrorMessage(Int32 error) { }

	// RVA: 0xFFFFFFFF75B39A38
	private static Void InitializeErrorMessages() { }

	// RVA: 0xFFFFFFFF75B3AABC
	private static Void .cctor() { }

}

// Namespace: System.ComponentModel
public abstract class BaseNumberConverter
{
	// Properties
	internal virtual Boolean AllowHex { get; }
	internal abstract Type TargetType { get; }

	// Methods

	// RVA: 0xFFFFFFFF72373CA8
	internal virtual Boolean get_AllowHex() { }

	// RVA: -1
	internal abstract Type get_TargetType() { }

	// RVA: -1
	internal abstract Object FromString(String value, Int32 radix) { }

	// RVA: -1
	internal abstract Object FromString(String value, NumberFormatInfo formatInfo) { }

	// RVA: -1
	internal abstract Object FromString(String value, CultureInfo culture) { }

	// RVA: 0xFFFFFFFF75B0FE64
	internal virtual Exception FromStringError(String failedText, Exception innerException) { }

	// RVA: -1
	internal abstract String ToString(Object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xFFFFFFFF75B0FF6C
	public override Boolean CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0xFFFFFFFF72373CB0
	public override Object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, Object value) { }

	// RVA: 0xFFFFFFFF75B100C4
	public override Object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, Object value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75B104AC
	public override Boolean CanConvertTo(ITypeDescriptorContext context, Type t) { }

	// RVA: 0xFFFFFFFF75B10544
	protected Void .ctor() { }

}

// Namespace: System.ComponentModel
internal sealed class WeakHashtable
{
	// Fields
	private static IEqualityComparer _comparer; // 0x0
	private Int64 _lastGlobalMem; // 0x50
	private Int32 _lastHashCount; // 0x58

	// Methods

	// RVA: 0xFFFFFFFF75B38E70
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75B38EF8
	public override Void Clear() { }

	// RVA: 0xFFFFFFFF75B38F00
	public override Void Remove(Object key) { }

	// RVA: 0xFFFFFFFF75B38F08
	public Void SetWeak(Object key, Object value) { }

	// RVA: 0xFFFFFFFF75B38FA4
	private Void ScavengeKeys() { }

	// RVA: 0xFFFFFFFF75B39518
	private static Void .cctor() { }

}

// Namespace: 
private class WeakKeyComparer
{
	// Methods

	// RVA: 0xFFFFFFFF75B3965C
	private Boolean System.Collections.IEqualityComparer.Equals(Object x, Object y) { }

	// RVA: 0xFFFFFFFF7237626C
	private Int32 System.Collections.IEqualityComparer.GetHashCode(Object obj) { }

	// RVA: 0xFFFFFFFF75B395BC
	public Void .ctor() { }

}

// Namespace: 
private sealed class EqualityWeakReference
{
	// Fields
	private Int32 _hashCode; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75B394D0
	internal Void .ctor(Object o) { }

	// RVA: 0xFFFFFFFF75B395C0
	public override Boolean Equals(Object o) { }

	// RVA: 0xFFFFFFFF75B39654
	public override Int32 GetHashCode() { }

}

// Namespace: System.ComponentModel.Design
public interface IDesigner
{}

// Namespace: System.ComponentModel.Design
public interface IDesignerHost
{
	// Properties
	public abstract IComponent RootComponent { get; }

	// Methods

	// RVA: -1
	public abstract IComponent get_RootComponent() { }

	// RVA: -1
	public abstract IDesigner GetDesigner(IComponent component) { }

}

// Namespace: System.ComponentModel.Design
public interface IDictionaryService
{
	// Methods

	// RVA: -1
	public abstract Object GetValue(Object key) { }

	// RVA: -1
	public abstract Void SetValue(Object key, Object value) { }

}

// Namespace: System.ComponentModel.Design
public interface IExtenderListService
{
	// Methods

	// RVA: -1
	public abstract IExtenderProvider[] GetExtenderProviders() { }

}

// Namespace: System.ComponentModel.Design
public interface IRootDesigner
{}

// Namespace: System.ComponentModel.Design
public interface ITypeDescriptorFilterService
{
	// Methods

	// RVA: -1
	public abstract Boolean FilterAttributes(IComponent component, IDictionary attributes) { }

	// RVA: -1
	public abstract Boolean FilterEvents(IComponent component, IDictionary events) { }

	// RVA: -1
	public abstract Boolean FilterProperties(IComponent component, IDictionary properties) { }

}

// Namespace: System.ComponentModel.Design
public interface ITypeResolutionService
{
	// Methods

	// RVA: -1
	public abstract Type GetType(String name) { }

}

// Namespace: System.ComponentModel.Design.Serialization
public sealed class InstanceDescriptor
{
	// Fields
	private MemberInfo member; // 0x10
	private ICollection arguments; // 0x18
	private Boolean isComplete; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75B12574
	public Void .ctor(MemberInfo member, ICollection arguments) { }

	// RVA: 0xFFFFFFFF75B131D8
	public Void .ctor(MemberInfo member, ICollection arguments, Boolean isComplete) { }

	// RVA: 0xFFFFFFFF75B13668
	public Object Invoke() { }

}

// Namespace: System.ComponentModel.Design.Serialization
public sealed class RootDesignerSerializerAttribute
{
	// Fields
	private Boolean reloadable; // 0x10
	private String serializerTypeName; // 0x18
	private String serializerBaseTypeName; // 0x20
	private String typeId; // 0x28

	// Properties
	public override Object TypeId { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B13954
	public Void .ctor(String serializerTypeName, String baseSerializerTypeName, Boolean reloadable) { }

	// RVA: 0xFFFFFFFF75B139D0
	public override Object get_TypeId() { }

}

// Namespace: System.Security.Authentication
public class AuthenticationException
{
	// Methods

	// RVA: 0xFFFFFFFF75B93550
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B9359C
	public Void .ctor(String message, Exception innerException) { }

	// RVA: 0xFFFFFFFF75B935A4
	protected Void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

// Namespace: System.Security.Authentication
public enum SslProtocols
{
	// Fields
	public Int32 value__; // 0x10
	public const SslProtocols None = 0;
	public const SslProtocols Ssl2 = 12;
	public const SslProtocols Ssl3 = 48;
	public const SslProtocols Tls = 192;
	public const SslProtocols Tls11 = 768;
	public const SslProtocols Tls12 = 3072;
	public const SslProtocols Default = 240;
}

// Namespace: System.Security.Cryptography
public enum OidGroup
{
	// Fields
	public Int32 value__; // 0x10
	public const OidGroup All = 0;
	public const OidGroup HashAlgorithm = 1;
	public const OidGroup EncryptionAlgorithm = 2;
	public const OidGroup PublicKeyAlgorithm = 3;
	public const OidGroup SignatureAlgorithm = 4;
	public const OidGroup Attribute = 5;
	public const OidGroup ExtensionOrAttribute = 6;
	public const OidGroup EnhancedKeyUsage = 7;
	public const OidGroup Policy = 8;
	public const OidGroup Template = 9;
	public const OidGroup KeyDerivationFunction = 10;
}

// Namespace: System.Security.Cryptography
public sealed class Oid
{
	// Fields
	private String m_value; // 0x10
	private String m_friendlyName; // 0x18
	private OidGroup m_group; // 0x20

	// Properties
	public String Value { get; set; }
	public String FriendlyName { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B96378
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B9367C
	public Void .ctor(String oid) { }

	// RVA: 0xFFFFFFFF7238CC50
	internal Void .ctor(String oid, OidGroup group, Boolean lookupFriendlyName) { }

	// RVA: 0xFFFFFFFF75B963CC
	public Void .ctor(String value, String friendlyName) { }

	// RVA: 0xFFFFFFFF75B93870
	public Void .ctor(Oid oid) { }

	// RVA: 0xFFFFFFFF75B96430
	public String get_Value() { }

	// RVA: 0xFFFFFFFF75B96438
	public Void set_Value(String value) { }

	// RVA: 0xFFFFFFFF7238CCEC
	public String get_FriendlyName() { }

}

// Namespace: System.Security.Cryptography
public sealed class OidCollection
{
	// Fields
	private ArrayList m_list; // 0x10

	// Properties
	public Oid Item { get; }
	public Int32 Count { get; }
	public Boolean IsSynchronized { get; }
	public Object SyncRoot { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B96470
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B964C0
	public Int32 Add(Oid oid) { }

	// RVA: 0xFFFFFFFF75B964E8
	public Oid get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF75B96578
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75B965A0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B9666C
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF75B96834
	public Boolean get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75B9683C
	public Object get_SyncRoot() { }

}

// Namespace: System.Security.Cryptography
public sealed class OidEnumerator
{
	// Fields
	private OidCollection m_oids; // 0x10
	private Int32 m_current; // 0x18

	// Properties
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B9662C
	internal Void .ctor(OidCollection oids) { }

	// RVA: 0xFFFFFFFF75B96840
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xFFFFFFFF75B96864
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75B968C8
	public Void Reset() { }

}

// Namespace: System.Security.Cryptography
internal static class CAPI
{
	// Methods

	// RVA: 0xFFFFFFFF75B94FC4
	public static String CryptFindOIDInfoNameFromKey(String key, OidGroup oidGroup) { }

	// RVA: 0xFFFFFFFF75B95AAC
	public static String CryptFindOIDInfoKeyFromName(String name, OidGroup oidGroup) { }

}

// Namespace: System.Security.Cryptography
internal enum AsnDecodeStatus
{
	// Fields
	public Int32 value__; // 0x10
	public const AsnDecodeStatus NotDecoded = 4294967295;
	public const AsnDecodeStatus Ok = 0;
	public const AsnDecodeStatus BadAsn = 1;
	public const AsnDecodeStatus BadTag = 2;
	public const AsnDecodeStatus BadLength = 3;
	public const AsnDecodeStatus InformationNotAvailable = 4;
}

// Namespace: System.Security.Cryptography
public class AsnEncodedData
{
	// Fields
	internal Oid _oid; // 0x10
	internal Byte[] _raw; // 0x18

	// Properties
	public Oid Oid { get; set; }
	public Byte[] RawData { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B935AC
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF75B935B0
	public Void .ctor(String oid, Byte[] rawData) { }

	// RVA: 0xFFFFFFFF75B9379C
	public Void .ctor(Oid oid, Byte[] rawData) { }

	// RVA: 0xFFFFFFFF75B93868
	public Oid get_Oid() { }

	// RVA: 0xFFFFFFFF75B937C8
	public Void set_Oid(Oid value) { }

	// RVA: 0xFFFFFFFF75B93940
	public Byte[] get_RawData() { }

	// RVA: 0xFFFFFFFF75B936CC
	public Void set_RawData(Byte[] value) { }

	// RVA: 0xFFFFFFFF75B93948
	public virtual Void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0xFFFFFFFF75B93A74
	public virtual String Format(Boolean multiLine) { }

	// RVA: 0xFFFFFFFF75B93B9C
	internal virtual String ToString(Boolean multiLine) { }

	// RVA: 0xFFFFFFFF75B93AB0
	internal String Default(Boolean multiLine) { }

	// RVA: 0xFFFFFFFF75B93D58
	internal String BasicConstraintsExtension(Boolean multiLine) { }

	// RVA: 0xFFFFFFFF75B93E68
	internal String EnhancedKeyUsageExtension(Boolean multiLine) { }

	// RVA: 0xFFFFFFFF75B93F78
	internal String KeyUsageExtension(Boolean multiLine) { }

	// RVA: 0xFFFFFFFF75B94088
	internal String SubjectKeyIdentifierExtension(Boolean multiLine) { }

	// RVA: 0xFFFFFFFF75B94198
	internal String SubjectAltName(Boolean multiLine) { }

	// RVA: 0xFFFFFFFF75B947B4
	internal String NetscapeCertType(Boolean multiLine) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public enum OpenFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const OpenFlags ReadOnly = 0;
	public const OpenFlags ReadWrite = 1;
	public const OpenFlags MaxAllowed = 2;
	public const OpenFlags OpenExistingOnly = 4;
	public const OpenFlags IncludeArchived = 8;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum StoreLocation
{
	// Fields
	public Int32 value__; // 0x10
	public const StoreLocation CurrentUser = 1;
	public const StoreLocation LocalMachine = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum StoreName
{
	// Fields
	public Int32 value__; // 0x10
	public const StoreName AddressBook = 1;
	public const StoreName AuthRoot = 2;
	public const StoreName CertificateAuthority = 3;
	public const StoreName Disallowed = 4;
	public const StoreName My = 5;
	public const StoreName Root = 6;
	public const StoreName TrustedPeople = 7;
	public const StoreName TrustedPublisher = 8;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X500DistinguishedNameFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const X500DistinguishedNameFlags None = 0;
	public const X500DistinguishedNameFlags Reversed = 1;
	public const X500DistinguishedNameFlags UseSemicolons = 16;
	public const X500DistinguishedNameFlags DoNotUsePlusSign = 32;
	public const X500DistinguishedNameFlags DoNotUseQuotes = 64;
	public const X500DistinguishedNameFlags UseCommas = 128;
	public const X500DistinguishedNameFlags UseNewLines = 256;
	public const X500DistinguishedNameFlags UseUTF8Encoding = 4096;
	public const X500DistinguishedNameFlags UseT61Encoding = 8192;
	public const X500DistinguishedNameFlags ForceUTF8Encoding = 16384;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509ChainStatusFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const X509ChainStatusFlags NoError = 0;
	public const X509ChainStatusFlags NotTimeValid = 1;
	public const X509ChainStatusFlags NotTimeNested = 2;
	public const X509ChainStatusFlags Revoked = 4;
	public const X509ChainStatusFlags NotSignatureValid = 8;
	public const X509ChainStatusFlags NotValidForUsage = 16;
	public const X509ChainStatusFlags UntrustedRoot = 32;
	public const X509ChainStatusFlags RevocationStatusUnknown = 64;
	public const X509ChainStatusFlags Cyclic = 128;
	public const X509ChainStatusFlags InvalidExtension = 256;
	public const X509ChainStatusFlags InvalidPolicyConstraints = 512;
	public const X509ChainStatusFlags InvalidBasicConstraints = 1024;
	public const X509ChainStatusFlags InvalidNameConstraints = 2048;
	public const X509ChainStatusFlags HasNotSupportedNameConstraint = 4096;
	public const X509ChainStatusFlags HasNotDefinedNameConstraint = 8192;
	public const X509ChainStatusFlags HasNotPermittedNameConstraint = 16384;
	public const X509ChainStatusFlags HasExcludedNameConstraint = 32768;
	public const X509ChainStatusFlags PartialChain = 65536;
	public const X509ChainStatusFlags CtlNotTimeValid = 131072;
	public const X509ChainStatusFlags CtlNotSignatureValid = 262144;
	public const X509ChainStatusFlags CtlNotValidForUsage = 524288;
	public const X509ChainStatusFlags OfflineRevocation = 16777216;
	public const X509ChainStatusFlags NoIssuanceChainPolicy = 33554432;
	public const X509ChainStatusFlags ExplicitDistrust = 67108864;
	public const X509ChainStatusFlags HasNotSupportedCriticalExtension = 134217728;
	public const X509ChainStatusFlags HasWeakSignature = 1048576;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509FindType
{
	// Fields
	public Int32 value__; // 0x10
	public const X509FindType FindByThumbprint = 0;
	public const X509FindType FindBySubjectName = 1;
	public const X509FindType FindBySubjectDistinguishedName = 2;
	public const X509FindType FindByIssuerName = 3;
	public const X509FindType FindByIssuerDistinguishedName = 4;
	public const X509FindType FindBySerialNumber = 5;
	public const X509FindType FindByTimeValid = 6;
	public const X509FindType FindByTimeNotYetValid = 7;
	public const X509FindType FindByTimeExpired = 8;
	public const X509FindType FindByTemplateName = 9;
	public const X509FindType FindByApplicationPolicy = 10;
	public const X509FindType FindByCertificatePolicy = 11;
	public const X509FindType FindByExtension = 12;
	public const X509FindType FindByKeyUsage = 13;
	public const X509FindType FindBySubjectKeyIdentifier = 14;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509KeyUsageFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const X509KeyUsageFlags None = 0;
	public const X509KeyUsageFlags EncipherOnly = 1;
	public const X509KeyUsageFlags CrlSign = 2;
	public const X509KeyUsageFlags KeyCertSign = 4;
	public const X509KeyUsageFlags KeyAgreement = 8;
	public const X509KeyUsageFlags DataEncipherment = 16;
	public const X509KeyUsageFlags KeyEncipherment = 32;
	public const X509KeyUsageFlags NonRepudiation = 64;
	public const X509KeyUsageFlags DigitalSignature = 128;
	public const X509KeyUsageFlags DecipherOnly = 32768;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509NameType
{
	// Fields
	public Int32 value__; // 0x10
	public const X509NameType SimpleName = 0;
	public const X509NameType EmailName = 1;
	public const X509NameType UpnName = 2;
	public const X509NameType DnsName = 3;
	public const X509NameType DnsFromAlternativeName = 4;
	public const X509NameType UrlName = 5;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509RevocationFlag
{
	// Fields
	public Int32 value__; // 0x10
	public const X509RevocationFlag EndCertificateOnly = 0;
	public const X509RevocationFlag EntireChain = 1;
	public const X509RevocationFlag ExcludeRoot = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509RevocationMode
{
	// Fields
	public Int32 value__; // 0x10
	public const X509RevocationMode NoCheck = 0;
	public const X509RevocationMode Online = 1;
	public const X509RevocationMode Offline = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509SubjectKeyIdentifierHashAlgorithm
{
	// Fields
	public Int32 value__; // 0x10
	public const X509SubjectKeyIdentifierHashAlgorithm Sha1 = 0;
	public const X509SubjectKeyIdentifierHashAlgorithm ShortSha1 = 1;
	public const X509SubjectKeyIdentifierHashAlgorithm CapiSha1 = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509VerificationFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const X509VerificationFlags NoFlag = 0;
	public const X509VerificationFlags IgnoreNotTimeValid = 1;
	public const X509VerificationFlags IgnoreCtlNotTimeValid = 2;
	public const X509VerificationFlags IgnoreNotTimeNested = 4;
	public const X509VerificationFlags IgnoreInvalidBasicConstraints = 8;
	public const X509VerificationFlags AllowUnknownCertificateAuthority = 16;
	public const X509VerificationFlags IgnoreWrongUsage = 32;
	public const X509VerificationFlags IgnoreInvalidName = 64;
	public const X509VerificationFlags IgnoreInvalidPolicy = 128;
	public const X509VerificationFlags IgnoreEndRevocationUnknown = 256;
	public const X509VerificationFlags IgnoreCtlSignerRevocationUnknown = 512;
	public const X509VerificationFlags IgnoreCertificateAuthorityRevocationUnknown = 1024;
	public const X509VerificationFlags IgnoreRootRevocationUnknown = 2048;
	public const X509VerificationFlags AllFlags = 4095;
}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509Utils
{
	// Methods

	// RVA: 0xFFFFFFFF75BA535C
	internal static String FindOidInfo(UInt32 keyType, String keyValue, OidGroup oidGroup) { }

	// RVA: 0xFFFFFFFF75B9637C
	internal static String FindOidInfoWithFallback(UInt32 key, String value, OidGroup group) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class PublicKey
{
	// Fields
	private AsymmetricAlgorithm _key; // 0x10
	private AsnEncodedData _keyValue; // 0x18
	private AsnEncodedData _params; // 0x20
	private Oid _oid; // 0x28
	private static Byte[] Empty; // 0x0

	// Properties
	public AsnEncodedData EncodedKeyValue { get; }
	public AsnEncodedData EncodedParameters { get; }
	public AsymmetricAlgorithm Key { get; }
	public Oid Oid { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B968D4
	internal Void .ctor(X509Certificate certificate) { }

	// RVA: 0xFFFFFFFF75B96E04
	public AsnEncodedData get_EncodedKeyValue() { }

	// RVA: 0xFFFFFFFF75B96E0C
	public AsnEncodedData get_EncodedParameters() { }

	// RVA: 0xFFFFFFFF75B96E14
	public AsymmetricAlgorithm get_Key() { }

	// RVA: 0xFFFFFFFF75B97840
	public Oid get_Oid() { }

	// RVA: 0xFFFFFFFF75B97848
	private static Byte[] GetUnsignedBigInteger(Byte[] integer) { }

	// RVA: 0xFFFFFFFF75B9738C
	internal static DSA DecodeDSA(Byte[] rawPublicKey, Byte[] rawParameters) { }

	// RVA: 0xFFFFFFFF75B96FE0
	internal static RSA DecodeRSA(Byte[] rawPublicKey) { }

	// RVA: 0xFFFFFFFF75B978CC
	private static Void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X500DistinguishedName
{
	// Fields
	private String name; // 0x20
	private Byte[] canonEncoding; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75B9794C
	public Void .ctor(Byte[] encodedDistinguishedName) { }

	// RVA: 0xFFFFFFFF75B97B84
	public String Decode(X500DistinguishedNameFlags flag) { }

	// RVA: 0xFFFFFFFF75B97D64
	public override String Format(Boolean multiLine) { }

	// RVA: 0xFFFFFFFF75B97CEC
	private static String GetSeparator(X500DistinguishedNameFlags flag) { }

	// RVA: 0xFFFFFFFF75B97A60
	private Void DecodeRawData() { }

	// RVA: 0xFFFFFFFF75B97DD4
	private static String Canonize(String s) { }

	// RVA: 0xFFFFFFFF75B98004
	internal static Boolean AreEqual(X500DistinguishedName name1, X500DistinguishedName name2) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509BasicConstraintsExtension
{
	// Fields
	internal const String oid = "2.5.29.19";
	internal const String friendlyName = "Basic Constraints";
	private Boolean _certificateAuthority; // 0x21
	private Boolean _hasPathLengthConstraint; // 0x22
	private Int32 _pathLengthConstraint; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Properties
	public Boolean CertificateAuthority { get; }
	public Boolean HasPathLengthConstraint { get; }
	public Int32 PathLengthConstraint { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B981B8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B94B14
	public Void .ctor(AsnEncodedData encodedBasicConstraints, Boolean critical) { }

	// RVA: 0xFFFFFFFF75B9848C
	public Void .ctor(Boolean certificateAuthority, Boolean hasPathLengthConstraint, Int32 pathLengthConstraint, Boolean critical) { }

	// RVA: 0xFFFFFFFF75B98734
	public Boolean get_CertificateAuthority() { }

	// RVA: 0xFFFFFFFF75B987C0
	public Boolean get_HasPathLengthConstraint() { }

	// RVA: 0xFFFFFFFF75B9884C
	public Int32 get_PathLengthConstraint() { }

	// RVA: 0xFFFFFFFF75B988D8
	public override Void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0xFFFFFFFF75B982A0
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0xFFFFFFFF75B985FC
	internal Byte[] Encode() { }

	// RVA: 0xFFFFFFFF75B98ADC
	internal override String ToString(Boolean multiLine) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Certificate2
{
	// Fields
	private String friendlyName; // 0x30
	private static Byte[] signedData; // 0x0

	// Properties
	internal X509Certificate2Impl Impl { get; }
	public X509ExtensionCollection Extensions { get; }
	public X500DistinguishedName IssuerName { get; }
	public DateTime NotAfter { get; }
	public DateTime NotBefore { get; }
	public AsymmetricAlgorithm PrivateKey { get; set; }
	public PublicKey PublicKey { get; }
	public String SerialNumber { get; }
	public Oid SignatureAlgorithm { get; }
	public X500DistinguishedName SubjectName { get; }
	public String Thumbprint { get; }
	public Int32 Version { get; }
	internal X509Certificate MonoCertificate { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B98E00
	internal X509Certificate2Impl get_Impl() { }

	// RVA: 0xFFFFFFFF75B98EB4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B98EFC
	public Void .ctor(Byte[] rawData) { }

	// RVA: 0xFFFFFFFF75B98F6C
	public Void .ctor(X509Certificate certificate) { }

	// RVA: 0xFFFFFFFF75B990E4
	protected Void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF75B9915C
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0xFFFFFFFF75B99184
	public X500DistinguishedName get_IssuerName() { }

	// RVA: 0xFFFFFFFF75B991AC
	public DateTime get_NotAfter() { }

	// RVA: 0xFFFFFFFF75B991F0
	public DateTime get_NotBefore() { }

	// RVA: 0xFFFFFFFF75B99234
	public AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0xFFFFFFFF75B9925C
	public Void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0xFFFFFFFF75B99294
	public PublicKey get_PublicKey() { }

	// RVA: 0xFFFFFFFF75B992BC
	public String get_SerialNumber() { }

	// RVA: 0xFFFFFFFF75B992CC
	public Oid get_SignatureAlgorithm() { }

	// RVA: 0xFFFFFFFF75B992F4
	public X500DistinguishedName get_SubjectName() { }

	// RVA: 0xFFFFFFFF75B9931C
	public String get_Thumbprint() { }

	// RVA: 0xFFFFFFFF75B9932C
	public Int32 get_Version() { }

	// RVA: 0xFFFFFFFF75B99354
	public String GetNameInfo(X509NameType nameType, Boolean forIssuer) { }

	// RVA: 0xFFFFFFFF75B99394
	public override Void Import(Byte[] rawData, String password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0xFFFFFFFF75B9948C
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75B994DC
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75B99548
	public override String ToString(Boolean verbose) { }

	// RVA: 0xFFFFFFFF75B99AA8
	private static Void AppendBuffer(StringBuilder sb, Byte[] buffer) { }

	// RVA: 0xFFFFFFFF75B99B80
	public Boolean Verify() { }

	// RVA: 0xFFFFFFFF75B99BB8
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0xFFFFFFFF75B99CB0
	private static Void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Certificate2Collection
{
	// Fields
	private static String[] newline_split; // 0x0

	// Properties
	public X509Certificate2 Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B99D50
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B99D58
	public Void .ctor(X509Certificate2Collection certificates) { }

	// RVA: 0xFFFFFFFF75B99E34
	public X509Certificate2 get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF75B99F84
	public Int32 Add(X509Certificate2 certificate) { }

	// RVA: 0xFFFFFFFF75B99D88
	public Void AddRange(X509Certificate2Collection certificates) { }

	// RVA: 0xFFFFFFFF75B9A030
	public Boolean Contains(X509Certificate2 certificate) { }

	// RVA: 0xFFFFFFFF7238CDB0
	public X509Certificate2Collection Find(X509FindType findType, Object findValue, Boolean validOnly) { }

	// RVA: 0xFFFFFFFF75B9A87C
	public X509Certificate2Enumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B9A990
	private static Void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509Certificate2Enumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509Certificate2 Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B9A8EC
	internal Void .ctor(X509Certificate2Collection collection) { }

	// RVA: 0xFFFFFFFF75B9AA44
	public X509Certificate2 get_Current() { }

	// RVA: 0xFFFFFFFF75B9AB40
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75B9ABC0
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xFFFFFFFF75B9AC44
	private Boolean System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0xFFFFFFFF75B9ACC4
	private Void System.Collections.IEnumerator.Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509Certificate2Impl
{
	// Properties
	public abstract X509ExtensionCollection Extensions { get; }
	public abstract X500DistinguishedName IssuerName { get; }
	public abstract AsymmetricAlgorithm PrivateKey { get; set; }
	public abstract PublicKey PublicKey { get; }
	public abstract Oid SignatureAlgorithm { get; }
	public abstract X500DistinguishedName SubjectName { get; }
	public abstract Int32 Version { get; }
	internal abstract X509CertificateImplCollection IntermediateCertificates { get; }
	internal abstract X509Certificate2Impl FallbackImpl { get; }

	// Methods

	// RVA: -1
	public abstract X509ExtensionCollection get_Extensions() { }

	// RVA: -1
	public abstract X500DistinguishedName get_IssuerName() { }

	// RVA: -1
	public abstract AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: -1
	public abstract Void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: -1
	public abstract PublicKey get_PublicKey() { }

	// RVA: -1
	public abstract Oid get_SignatureAlgorithm() { }

	// RVA: -1
	public abstract X500DistinguishedName get_SubjectName() { }

	// RVA: -1
	public abstract Int32 get_Version() { }

	// RVA: -1
	internal abstract X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: -1
	internal abstract X509Certificate2Impl get_FallbackImpl() { }

	// RVA: -1
	public abstract String GetNameInfo(X509NameType nameType, Boolean forIssuer) { }

	// RVA: -1
	public abstract Void Import(Byte[] rawData, String password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: -1
	public abstract Boolean Verify(X509Certificate2 thisCertificate) { }

	// RVA: -1
	public abstract Void Reset() { }

	// RVA: 0xFFFFFFFF75B9AD48
	protected Void .ctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509Certificate2ImplMono
{
	// Fields
	private Boolean _archived; // 0x18
	private X509ExtensionCollection _extensions; // 0x20
	private PublicKey _publicKey; // 0x28
	private X500DistinguishedName issuer_name; // 0x30
	private X500DistinguishedName subject_name; // 0x38
	private Oid signature_algorithm; // 0x40
	private X509CertificateImplCollection intermediateCerts; // 0x48
	private X509Certificate _cert; // 0x50
	private static String empty_error; // 0x0
	private static Byte[] commonName; // 0x8
	private static Byte[] email; // 0x10
	private static Byte[] signedData; // 0x18

	// Properties
	public override Boolean IsValid { get; }
	public override X509ExtensionCollection Extensions { get; }
	public override X500DistinguishedName IssuerName { get; }
	public override AsymmetricAlgorithm PrivateKey { get; set; }
	public override PublicKey PublicKey { get; }
	public override Oid SignatureAlgorithm { get; }
	public override X500DistinguishedName SubjectName { get; }
	public override Int32 Version { get; }
	internal override X509CertificateImplCollection IntermediateCertificates { get; }
	internal X509Certificate MonoCertificate { get; }
	internal override X509Certificate2Impl FallbackImpl { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B9AD50
	public override Boolean get_IsValid() { }

	// RVA: 0xFFFFFFFF75B9AD60
	private Void .ctor(X509Certificate cert) { }

	// RVA: 0xFFFFFFFF75B9ADA4
	private Void .ctor(X509Certificate2ImplMono other) { }

	// RVA: 0xFFFFFFFF75B9AE98
	public override X509CertificateImpl Clone() { }

	// RVA: 0xFFFFFFFF75B9AF14
	public override String GetIssuerName(Boolean legacyV1Mode) { }

	// RVA: 0xFFFFFFFF75B9AFF0
	public override String GetSubjectName(Boolean legacyV1Mode) { }

	// RVA: 0xFFFFFFFF75B9B0CC
	public override Byte[] GetRawCertData() { }

	// RVA: 0xFFFFFFFF75B9B108
	protected override Byte[] GetCertHash(Boolean lazy) { }

	// RVA: 0xFFFFFFFF75B9B164
	public override DateTime GetValidFrom() { }

	// RVA: 0xFFFFFFFF75B9B1A0
	public override DateTime GetValidUntil() { }

	// RVA: 0xFFFFFFFF75B9B1DC
	public override Boolean Equals(X509CertificateImpl other, out Boolean result) { }

	// RVA: 0xFFFFFFFF75B9B1E8
	public override Byte[] GetSerialNumber() { }

	// RVA: 0xFFFFFFFF75B9B224
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B9B264
	public override X509ExtensionCollection get_Extensions() { }

	// RVA: 0xFFFFFFFF75B9B9FC
	public override X500DistinguishedName get_IssuerName() { }

	// RVA: 0xFFFFFFFF75B9BB3C
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0xFFFFFFFF75B9BE98
	public override Void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0xFFFFFFFF75B9C06C
	public override PublicKey get_PublicKey() { }

	// RVA: 0xFFFFFFFF75B9C23C
	public override Oid get_SignatureAlgorithm() { }

	// RVA: 0xFFFFFFFF75B9C3A0
	public override X500DistinguishedName get_SubjectName() { }

	// RVA: 0xFFFFFFFF75B9C4E0
	public override Int32 get_Version() { }

	// RVA: 0xFFFFFFFF75B9C5A4
	public override String GetNameInfo(X509NameType nameType, Boolean forIssuer) { }

	// RVA: 0xFFFFFFFF75B9C84C
	private ASN1 Find(Byte[] oid, ASN1 dn) { }

	// RVA: 0xFFFFFFFF75B9C978
	private String GetValueAsString(ASN1 pair) { }

	// RVA: 0xFFFFFFFF75B9CAFC
	private X509Certificate ImportPkcs12(Byte[] rawData, String password) { }

	// RVA: 0xFFFFFFFF75B9D348
	public override Void Import(Byte[] rawData, String password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0xFFFFFFFF75B9D5DC
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75B9D720
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75B9D78C
	public override String ToString(Boolean verbose) { }

	// RVA: 0xFFFFFFFF75B9DE20
	private static Void AppendBuffer(StringBuilder sb, Byte[] buffer) { }

	// RVA: 0xFFFFFFFF75B9DEF8
	public override Boolean Verify(X509Certificate2 thisCertificate) { }

	// RVA: 0xFFFFFFFF75B9E090
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0xFFFFFFFF75B9E098
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0xFFFFFFFF75B9E0A0
	internal override X509Certificate2Impl get_FallbackImpl() { }

	// RVA: 0xFFFFFFFF75B9E0A4
	private static Void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509CertificateCollection
{
	// Properties
	public X509Certificate Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B87A9C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B9E21C
	public Void .ctor(X509CertificateCollection value) { }

	// RVA: 0xFFFFFFFF75B9E344
	public X509Certificate get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF75B9E3FC
	public Int32 Add(X509Certificate value) { }

	// RVA: 0xFFFFFFFF75B9E24C
	public Void AddRange(X509CertificateCollection value) { }

	// RVA: 0xFFFFFFFF75B9E49C
	public X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B9E5B0
	public override Int32 GetHashCode() { }

}

// Namespace: 
public class X509CertificateEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509Certificate Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B9E50C
	public Void .ctor(X509CertificateCollection mappings) { }

	// RVA: 0xFFFFFFFF75B9E5DC
	public X509Certificate get_Current() { }

	// RVA: 0xFFFFFFFF75B9E6D8
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xFFFFFFFF75B9E75C
	private Boolean System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0xFFFFFFFF75B9E7DC
	private Void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xFFFFFFFF75B9E860
	public Boolean MoveNext() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509CertificateImplCollection
{
	// Fields
	private List<T0> list; // 0x10

	// Properties
	public Int32 Count { get; }
	public X509CertificateImpl Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B9D208
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B9E8E0
	private Void .ctor(X509CertificateImplCollection other) { }

	// RVA: 0xFFFFFFFF75B9EAF4
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75B9EB58
	public X509CertificateImpl get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF75B9D2B0
	public Void Add(X509CertificateImpl impl, Boolean takeOwnership) { }

	// RVA: 0xFFFFFFFF75B9AE28
	public X509CertificateImplCollection Clone() { }

	// RVA: 0xFFFFFFFF75B9D6CC
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75B9EBDC
	protected virtual Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75B9EDC8
	protected override Void Finalize() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Chain
{
	// Fields
	private X509ChainImpl impl; // 0x10

	// Properties
	internal X509ChainImpl Impl { get; }
	public X509ChainPolicy ChainPolicy { get; set; }
	public X509ChainStatus[] ChainStatus { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B9EE40
	internal X509ChainImpl get_Impl() { }

	// RVA: 0xFFFFFFFF75B9EED0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B9EF10
	public Void .ctor(Boolean useMachineContext) { }

	// RVA: 0xFFFFFFFF75B9EFC0
	public X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0xFFFFFFFF75B9EFFC
	public Void set_ChainPolicy(X509ChainPolicy value) { }

	// RVA: 0xFFFFFFFF75B9F040
	public X509ChainStatus[] get_ChainStatus() { }

	// RVA: 0xFFFFFFFF75B9E04C
	public Boolean Build(X509Certificate2 certificate) { }

	// RVA: 0xFFFFFFFF75B9DFCC
	public static X509Chain Create() { }

	// RVA: 0xFFFFFFFF75B9F07C
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75B9F0D0
	protected virtual Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75B9F168
	protected override Void Finalize() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509ChainElement
{
	// Fields
	private X509Certificate2 certificate; // 0x10
	private X509ChainStatus[] status; // 0x18
	private String info; // 0x20
	private X509ChainStatusFlags compressed_status_flags; // 0x28

	// Properties
	public X509Certificate2 Certificate { get; }
	public X509ChainStatus[] ChainElementStatus { get; }
	internal X509ChainStatusFlags StatusFlags { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B9F1E0
	internal Void .ctor(X509Certificate2 certificate) { }

	// RVA: 0xFFFFFFFF75B9F244
	public X509Certificate2 get_Certificate() { }

	// RVA: 0xFFFFFFFF75B9F24C
	public X509ChainStatus[] get_ChainElementStatus() { }

	// RVA: 0xFFFFFFFF75B9F254
	internal X509ChainStatusFlags get_StatusFlags() { }

	// RVA: 0xFFFFFFFF75B9F25C
	internal Void set_StatusFlags(X509ChainStatusFlags value) { }

	// RVA: 0xFFFFFFFF75B9F264
	private Int32 Count(X509ChainStatusFlags flags) { }

	// RVA: 0xFFFFFFFF75B9F31C
	private Void Set(X509ChainStatus[] status, ref Int32 position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

	// RVA: 0xFFFFFFFF75B9F558
	internal Void UncompressFlags() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainElementCollection
{
	// Fields
	private ArrayList _list; // 0x10

	// Properties
	public Int32 Count { get; }
	public Boolean IsSynchronized { get; }
	public X509ChainElement Item { get; }
	public Object SyncRoot { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B9F888
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75B9F8D8
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75B9F900
	public Boolean get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75B9F928
	public X509ChainElement get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF75B9F9D8
	public Object get_SyncRoot() { }

	// RVA: 0xFFFFFFFF75B9FA00
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF75B9FA28
	public X509ChainElementEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B9FB40
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B9FBB4
	internal Void Add(X509Certificate2 certificate) { }

	// RVA: 0xFFFFFFFF75B9FC84
	internal Void Clear() { }

	// RVA: 0xFFFFFFFF75B9FCAC
	internal Boolean Contains(X509Certificate2 certificate) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainElementEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509ChainElement Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B9FA9C
	internal Void .ctor(IEnumerable enumerable) { }

	// RVA: 0xFFFFFFFF75B9FDBC
	public X509ChainElement get_Current() { }

	// RVA: 0xFFFFFFFF75B9FEB8
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xFFFFFFFF75B9FF3C
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75B9FFBC
	public Void Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509ChainImpl
{
	// Properties
	public abstract Boolean IsValid { get; }
	public abstract X509ChainPolicy ChainPolicy { get; set; }
	public abstract X509ChainStatus[] ChainStatus { get; }

	// Methods

	// RVA: -1
	public abstract Boolean get_IsValid() { }

	// RVA: -1
	public abstract X509ChainPolicy get_ChainPolicy() { }

	// RVA: -1
	public abstract Void set_ChainPolicy(X509ChainPolicy value) { }

	// RVA: -1
	public abstract X509ChainStatus[] get_ChainStatus() { }

	// RVA: -1
	public abstract Boolean Build(X509Certificate2 certificate) { }

	// RVA: -1
	public abstract Void Reset() { }

	// RVA: 0xFFFFFFFF75B9F114
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75BA0040
	protected virtual Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75BA0044
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75BA00BC
	protected Void .ctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509ChainImplMono
{
	// Fields
	private StoreLocation location; // 0x10
	private X509ChainElementCollection elements; // 0x18
	private X509ChainPolicy policy; // 0x20
	private X509ChainStatus[] status; // 0x28
	private static X509ChainStatus[] Empty; // 0x0
	private Int32 max_path_length; // 0x30
	private X500DistinguishedName working_issuer_name; // 0x38
	private AsymmetricAlgorithm working_public_key; // 0x40
	private X509ChainElement bce_restriction; // 0x48
	private X509Certificate2Collection roots; // 0x50
	private X509Certificate2Collection cas; // 0x58
	private X509Store root_store; // 0x60
	private X509Store ca_store; // 0x68
	private X509Store user_root_store; // 0x70
	private X509Store user_ca_store; // 0x78
	private X509Certificate2Collection collection; // 0x80

	// Properties
	public override Boolean IsValid { get; }
	public override X509ChainPolicy ChainPolicy { get; set; }
	public override X509ChainStatus[] ChainStatus { get; }
	private X509Certificate2Collection Roots { get; }
	private X509Certificate2Collection CertificateAuthorities { get; }
	private X509Store LMRootStore { get; }
	private X509Store UserRootStore { get; }
	private X509Store LMCAStore { get; }
	private X509Store UserCAStore { get; }
	private X509Certificate2Collection CertificateCollection { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BA00C0
	public Void .ctor(Boolean useMachineContext) { }

	// RVA: 0xFFFFFFFF75BA01C0
	public override Boolean get_IsValid() { }

	// RVA: 0xFFFFFFFF75BA01C8
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0xFFFFFFFF75BA01D0
	public override Void set_ChainPolicy(X509ChainPolicy value) { }

	// RVA: 0xFFFFFFFF75BA0208
	public override X509ChainStatus[] get_ChainStatus() { }

	// RVA: 0xFFFFFFFF75BA0294
	public override Boolean Build(X509Certificate2 certificate) { }

	// RVA: 0xFFFFFFFF75BA0994
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75BA0C4C
	private X509Certificate2Collection get_Roots() { }

	// RVA: 0xFFFFFFFF75BA1028
	private X509Certificate2Collection get_CertificateAuthorities() { }

	// RVA: 0xFFFFFFFF75BA0D38
	private X509Store get_LMRootStore() { }

	// RVA: 0xFFFFFFFF75BA0E5C
	private X509Store get_UserRootStore() { }

	// RVA: 0xFFFFFFFF75BA1114
	private X509Store get_LMCAStore() { }

	// RVA: 0xFFFFFFFF75BA1238
	private X509Store get_UserCAStore() { }

	// RVA: 0xFFFFFFFF75BA14D4
	private X509Certificate2Collection get_CertificateCollection() { }

	// RVA: 0xFFFFFFFF75BA0868
	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	// RVA: 0xFFFFFFFF75BA16FC
	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	// RVA: 0xFFFFFFFF75BA15D4
	private X509Certificate2 FindParent(X509Certificate2 certificate) { }

	// RVA: 0xFFFFFFFF7238EBBC
	private Boolean IsChainComplete(X509Certificate2 certificate) { }

	// RVA: 0xFFFFFFFF75BA1960
	private Boolean IsSelfIssued(X509Certificate2 certificate) { }

	// RVA: 0xFFFFFFFF7238E250
	private Void ValidateChain(X509ChainStatusFlags flag) { }

	// RVA: 0xFFFFFFFF7238EE08
	private Void Process(Int32 n) { }

	// RVA: 0xFFFFFFFF7238F138
	private Void PrepareForNextCertificate(Int32 n) { }

	// RVA: 0xFFFFFFFF75BA1BA8
	private Void WrapUp() { }

	// RVA: 0xFFFFFFFF7238F4E8
	private Void ProcessCertificateExtensions(X509ChainElement element) { }

	// RVA: 0xFFFFFFFF75BA1C38
	private Boolean IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	// RVA: 0xFFFFFFFF7238ECC0
	private String GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0xFFFFFFFF75BA18B0
	private static String GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0xFFFFFFFF75BA1FAC
	private static String GetAuthorityKeyIdentifier(X509Crl crl) { }

	// RVA: 0xFFFFFFFF75BA1E74
	private static String GetAuthorityKeyIdentifier(X509Extension ext) { }

	// RVA: 0xFFFFFFFF75BA19AC
	private Void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	// RVA: 0xFFFFFFFF75BA2050
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, Int32 ca, Boolean online) { }

	// RVA: 0xFFFFFFFF7238F6CC
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, Boolean online) { }

	// RVA: 0xFFFFFFFF75BA2740
	private static X509Crl CheckCrls(String subject, String ski, X509Store store) { }

	// RVA: 0xFFFFFFFF7238F98C
	private X509Crl FindCrl(X509Certificate2 caCertificate) { }

	// RVA: 0xFFFFFFFF75BA2414
	private Boolean ProcessCrlExtensions(X509Crl crl) { }

	// RVA: 0xFFFFFFFF75BA211C
	private Boolean ProcessCrlEntryExtensions(X509CrlEntry entry) { }

	// RVA: 0xFFFFFFFF75BA2ACC
	private static Void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainPolicy
{
	// Fields
	private OidCollection apps; // 0x10
	private OidCollection cert; // 0x18
	private X509CertificateCollection store; // 0x20
	private X509Certificate2Collection store2; // 0x28
	private X509RevocationFlag rflag; // 0x30
	private X509RevocationMode mode; // 0x34
	private TimeSpan timeout; // 0x38
	private X509VerificationFlags vflags; // 0x40
	private DateTime vtime; // 0x48

	// Properties
	public X509Certificate2Collection ExtraStore { get; }
	public X509RevocationFlag RevocationFlag { get; set; }
	public X509RevocationMode RevocationMode { get; set; }
	public TimeSpan UrlRetrievalTimeout { set; }
	public X509VerificationFlags VerificationFlags { get; set; }
	public DateTime VerificationTime { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BA01BC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75BA2CA4
	internal Void .ctor(X509CertificateCollection store) { }

	// RVA: 0xFFFFFFFF7238E964
	public X509Certificate2Collection get_ExtraStore() { }

	// RVA: 0xFFFFFFFF75BA2CE0
	public X509RevocationFlag get_RevocationFlag() { }

	// RVA: 0xFFFFFFFF75BA2CE8
	public Void set_RevocationFlag(X509RevocationFlag value) { }

	// RVA: 0xFFFFFFFF75BA2D78
	public X509RevocationMode get_RevocationMode() { }

	// RVA: 0xFFFFFFFF75BA2D80
	public Void set_RevocationMode(X509RevocationMode value) { }

	// RVA: 0xFFFFFFFF75BA2E10
	public Void set_UrlRetrievalTimeout(TimeSpan value) { }

	// RVA: 0xFFFFFFFF75BA2E18
	public X509VerificationFlags get_VerificationFlags() { }

	// RVA: 0xFFFFFFFF75BA2E20
	public Void set_VerificationFlags(X509VerificationFlags value) { }

	// RVA: 0xFFFFFFFF75BA2EB0
	public DateTime get_VerificationTime() { }

	// RVA: 0xFFFFFFFF75BA2B74
	public Void Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public struct X509ChainStatus
{
	// Fields
	private X509ChainStatusFlags status; // 0x10
	private String info; // 0x18

	// Properties
	public X509ChainStatusFlags Status { get; set; }
	public String StatusInformation { set; }

	// Methods

	// RVA: 0xFFFFFFFF711488C8
	internal Void .ctor(X509ChainStatusFlags flag) { }

	// RVA: 0xFFFFFFFF7114890C
	public X509ChainStatusFlags get_Status() { }

	// RVA: 0xFFFFFFFF71148914
	public Void set_Status(X509ChainStatusFlags value) { }

	// RVA: 0xFFFFFFFF7114891C
	public Void set_StatusInformation(String value) { }

	// RVA: 0xFFFFFFFF75B9F3C0
	internal static String GetInformation(X509ChainStatusFlags flags) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509EnhancedKeyUsageExtension
{
	// Fields
	private OidCollection _enhKeyUsage; // 0x28
	private AsnDecodeStatus _status; // 0x30

	// Methods

	// RVA: 0xFFFFFFFF75B94C40
	public Void .ctor(AsnEncodedData encodedEnhancedKeyUsages, Boolean critical) { }

	// RVA: 0xFFFFFFFF75BA2F00
	public override Void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0xFFFFFFFF7238FB00
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0xFFFFFFFF7239005C
	internal override String ToString(Boolean multiLine) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Extension
{
	// Fields
	private Boolean _critical; // 0x20

	// Properties
	public Boolean Critical { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B9829C
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF75BA3110
	public Void .ctor(String oid, Byte[] rawData, Boolean critical) { }

	// RVA: 0xFFFFFFFF75BA3138
	public Boolean get_Critical() { }

	// RVA: 0xFFFFFFFF75BA3140
	public Void set_Critical(Boolean value) { }

	// RVA: 0xFFFFFFFF75BA3148
	public override Void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0xFFFFFFFF75B98D14
	internal String FormatUnkownData(Byte[] data) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ExtensionCollection
{
	// Fields
	private static Byte[] Empty; // 0x0
	private ArrayList _list; // 0x10

	// Properties
	public Int32 Count { get; }
	public Boolean IsSynchronized { get; }
	public Object SyncRoot { get; }
	public X509Extension Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B9B384
	internal Void .ctor(X509Certificate cert) { }

	// RVA: 0xFFFFFFFF75B9A7C8
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75BA3270
	public Boolean get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75BA3298
	public Object get_SyncRoot() { }

	// RVA: 0xFFFFFFFF75B9A380
	public X509Extension get_Item(String oid) { }

	// RVA: 0xFFFFFFFF75BA329C
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF75BA1C84
	public X509ExtensionEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75BA3404
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFFFFFFFF75BA3478
	private static Void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ExtensionEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509Extension Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BA33AC
	internal Void .ctor(ArrayList list) { }

	// RVA: 0xFFFFFFFF75BA1CF8
	public X509Extension get_Current() { }

	// RVA: 0xFFFFFFFF75BA34F8
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xFFFFFFFF75BA1DF4
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75BA357C
	public Void Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal static class X509Helper2
{
	// Methods

	// RVA: 0xFFFFFFFF75BA3600
	internal static Void Initialize() { }

	// RVA: 0xFFFFFFFF75B98EAC
	internal static Void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	// RVA: 0xFFFFFFFF75B993D0
	internal static X509Certificate2Impl Import(Byte[] rawData, String password, X509KeyStorageFlags keyStorageFlags, Boolean disableProvider) { }

	// RVA: 0xFFFFFFFF75B98FD8
	internal static X509Certificate2Impl Import(X509Certificate cert, Boolean disableProvider) { }

	// RVA: 0xFFFFFFFF75B99BBC
	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	// RVA: 0xFFFFFFFF75B9EF50
	internal static X509ChainImpl CreateChainImpl(Boolean useMachineContext) { }

	// RVA: 0xFFFFFFFF75BA365C
	public static Boolean IsValid(X509ChainImpl impl) { }

	// RVA: 0xFFFFFFFF75B9EE68
	internal static Void ThrowIfContextInvalid(X509ChainImpl impl) { }

	// RVA: 0xFFFFFFFF75BA3674
	internal static Exception GetInvalidChainContextException() { }

}

// Namespace: 
private class MyNativeHelper
{
	// Methods

	// RVA: 0xFFFFFFFF75BA36D4
	public X509CertificateImpl Import(X509Certificate cert) { }

	// RVA: 0xFFFFFFFF75BA3658
	public Void .ctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509KeyUsageExtension
{
	// Fields
	internal const String oid = "2.5.29.15";
	internal const String friendlyName = "Key Usage";
	internal const X509KeyUsageFlags all = 33023;
	private X509KeyUsageFlags _keyUsages; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Properties
	public X509KeyUsageFlags KeyUsages { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BA36E0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B94D6C
	public Void .ctor(AsnEncodedData encodedKeyUsage, Boolean critical) { }

	// RVA: 0xFFFFFFFF75BA39A0
	public Void .ctor(X509KeyUsageFlags keyUsages, Boolean critical) { }

	// RVA: 0xFFFFFFFF75B9A7F0
	public X509KeyUsageFlags get_KeyUsages() { }

	// RVA: 0xFFFFFFFF75BA3BF0
	public override Void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0xFFFFFFFF75BA3AB4
	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	// RVA: 0xFFFFFFFF75BA37C4
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0xFFFFFFFF75BA3AC4
	internal Byte[] Encode() { }

	// RVA: 0xFFFFFFFF75BA3DF4
	internal override String ToString(Boolean multiLine) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509Store
{
	// Fields
	private String _name; // 0x10
	private StoreLocation _location; // 0x18
	private X509Certificate2Collection list; // 0x20
	private OpenFlags _flags; // 0x28
	private X509Store store; // 0x30

	// Properties
	public X509Certificate2Collection Certificates { get; }
	private X509Stores Factory { get; }
	internal X509Store Store { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BA135C
	public Void .ctor(StoreName storeName, StoreLocation storeLocation) { }

	// RVA: 0xFFFFFFFF75BA0F80
	public X509Certificate2Collection get_Certificates() { }

	// RVA: 0xFFFFFFFF75BA42D4
	private X509Stores get_Factory() { }

	// RVA: 0xFFFFFFFF75BA42F0
	internal X509Store get_Store() { }

	// RVA: 0xFFFFFFFF75BA0BFC
	public Void Close() { }

	// RVA: 0xFFFFFFFF75BA42F8
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF7238E3D4
	public Void Open(OpenFlags flags) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509SubjectKeyIdentifierExtension
{
	// Fields
	internal const String oid = "2.5.29.14";
	internal const String friendlyName = "Subject Key Identifier";
	private Byte[] _subjectKeyIdentifier; // 0x28
	private String _ski; // 0x30
	private AsnDecodeStatus _status; // 0x38

	// Properties
	public String SubjectKeyIdentifier { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BA4348
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B94E98
	public Void .ctor(AsnEncodedData encodedSubjectKeyIdentifier, Boolean critical) { }

	// RVA: 0xFFFFFFFF75BA45C0
	public Void .ctor(Byte[] subjectKeyIdentifier, Boolean critical) { }

	// RVA: 0xFFFFFFFF75BA481C
	public Void .ctor(String subjectKeyIdentifier, Boolean critical) { }

	// RVA: 0xFFFFFFFF75BA4A98
	public Void .ctor(PublicKey key, Boolean critical) { }

	// RVA: 0xFFFFFFFF75BA4AA4
	public Void .ctor(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, Boolean critical) { }

	// RVA: 0xFFFFFFFF75B9A710
	public String get_SubjectKeyIdentifier() { }

	// RVA: 0xFFFFFFFF75BA4E8C
	public override Void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0xFFFFFFFF75BA5090
	internal static Byte FromHexChar(Char c) { }

	// RVA: 0xFFFFFFFF75BA50D0
	internal static Byte FromHexChars(Char c1, Char c2) { }

	// RVA: 0xFFFFFFFF75BA49C0
	internal static Byte[] FromHex(String hex) { }

	// RVA: 0xFFFFFFFF75BA442C
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0xFFFFFFFF75BA4794
	internal Byte[] Encode() { }

	// RVA: 0xFFFFFFFF75BA5168
	internal override String ToString(Boolean multiLine) { }

}

// Namespace: System.CodeDom.Compiler
public sealed class GeneratedCodeAttribute
{
	// Fields
	private readonly String tool; // 0x10
	private readonly String version; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75B08B04
	public Void .ctor(String tool, String version) { }

}

// Namespace: System.IO.Compression
public enum CompressionLevel
{
	// Fields
	public Int32 value__; // 0x10
	public const CompressionLevel Optimal = 0;
	public const CompressionLevel Fastest = 1;
	public const CompressionLevel NoCompression = 2;
}

// Namespace: System.IO.Compression
public enum CompressionMode
{
	// Fields
	public Int32 value__; // 0x10
	public const CompressionMode Decompress = 0;
	public const CompressionMode Compress = 1;
}

// Namespace: System.IO.Compression
public class GZipStream
{
	// Fields
	private DeflateStream _deflateStream; // 0x28

	// Properties
	public override Boolean CanRead { get; }
	public override Boolean CanWrite { get; }
	public override Boolean CanSeek { get; }
	public override Int64 Length { get; }
	public override Int64 Position { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF723776E4
	public Void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0xFFFFFFFF72377774
	public Void .ctor(Stream stream, CompressionMode mode, Boolean leaveOpen) { }

	// RVA: 0xFFFFFFFF75B3FEA0
	public override Boolean get_CanRead() { }

	// RVA: 0xFFFFFFFF75B3FEBC
	public override Boolean get_CanWrite() { }

	// RVA: 0xFFFFFFFF75B3FED8
	public override Boolean get_CanSeek() { }

	// RVA: 0xFFFFFFFF75B3FEF4
	public override Int64 get_Length() { }

	// RVA: 0xFFFFFFFF75B3FF5C
	public override Int64 get_Position() { }

	// RVA: 0xFFFFFFFF75B3FFC4
	public override Void set_Position(Int64 value) { }

	// RVA: 0xFFFFFFFF75B4002C
	public override Void Flush() { }

	// RVA: 0xFFFFFFFF75B40070
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xFFFFFFFF75B400D8
	public override Void SetLength(Int64 value) { }

	// RVA: 0xFFFFFFFF75B40140
	public override Int32 ReadByte() { }

	// RVA: 0xFFFFFFFF75B40168
	public override IAsyncResult BeginRead(Byte[] array, Int32 offset, Int32 count, AsyncCallback asyncCallback, Object asyncState) { }

	// RVA: 0xFFFFFFFF75B40234
	public override Int32 EndRead(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B4027C
	public override Int32 Read(Byte[] array, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF75B402A4
	public override IAsyncResult BeginWrite(Byte[] array, Int32 offset, Int32 count, AsyncCallback asyncCallback, Object asyncState) { }

	// RVA: 0xFFFFFFFF75B40370
	public override Void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF72377814
	public override Void Write(Byte[] array, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF7237783C
	protected override Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75B4037C
	public override Task<T0> ReadAsync(Byte[] array, Int32 offset, Int32 count, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B403A4
	public override Task WriteAsync(Byte[] array, Int32 offset, Int32 count, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B40054
	private Void CheckDeflateStream() { }

	// RVA: 0xFFFFFFFF75B403CC
	private static Void ThrowStreamClosedException() { }

}

// Namespace: System.IO.Compression
public class DeflateStream
{
	// Fields
	private Stream base_stream; // 0x28
	private CompressionMode mode; // 0x30
	private Boolean leaveOpen; // 0x34
	private Boolean disposed; // 0x35
	private DeflateStreamNative native; // 0x38

	// Properties
	public override Boolean CanRead { get; }
	public override Boolean CanSeek { get; }
	public override Boolean CanWrite { get; }
	public override Int64 Length { get; }
	public override Int64 Position { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B3E06C
	public Void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0xFFFFFFFF75B3E078
	internal Void .ctor(Stream stream, CompressionMode mode, Boolean leaveOpen, Int32 windowsBits) { }

	// RVA: 0xFFFFFFFF72376B10
	internal Void .ctor(Stream compressedStream, CompressionMode mode, Boolean leaveOpen, Boolean gzip) { }

	// RVA: 0xFFFFFFFF75B3E080
	public Void .ctor(Stream stream, CompressionLevel compressionLevel, Boolean leaveOpen) { }

	// RVA: 0xFFFFFFFF75B3E08C
	internal Void .ctor(Stream stream, CompressionLevel compressionLevel, Boolean leaveOpen, Boolean gzip) { }

	// RVA: 0xFFFFFFFF72376DC0
	protected override Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75B3E094
	private Int32 ReadInternal(Byte[] array, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF75B3E154
	public override Int32 Read(Byte[] array, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF72376F54
	private Void WriteInternal(Byte[] array, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF723770DC
	public override Void Write(Byte[] array, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF75B3E34C
	public override Void Flush() { }

	// RVA: 0xFFFFFFFF75B3E464
	public override IAsyncResult BeginRead(Byte[] array, Int32 offset, Int32 count, AsyncCallback asyncCallback, Object asyncState) { }

	// RVA: 0xFFFFFFFF75B3E7A0
	public override IAsyncResult BeginWrite(Byte[] array, Int32 offset, Int32 count, AsyncCallback asyncCallback, Object asyncState) { }

	// RVA: 0xFFFFFFFF75B3EADC
	public override Int32 EndRead(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B3EC24
	public override Void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B3ED50
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xFFFFFFFF75B3EDA4
	public override Void SetLength(Int64 value) { }

	// RVA: 0xFFFFFFFF75B3EDF8
	public override Boolean get_CanRead() { }

	// RVA: 0xFFFFFFFF75B3EE3C
	public override Boolean get_CanSeek() { }

	// RVA: 0xFFFFFFFF72377268
	public override Boolean get_CanWrite() { }

	// RVA: 0xFFFFFFFF75B3EE44
	public override Int64 get_Length() { }

	// RVA: 0xFFFFFFFF75B3EE98
	public override Int64 get_Position() { }

	// RVA: 0xFFFFFFFF75B3EEEC
	public override Void set_Position(Int64 value) { }

}

// Namespace: 
private sealed class ReadMethod
{
	// Methods

	// RVA: 0xFFFFFFFF75B3E6B8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B3EF40
	public virtual Int32 Invoke(Byte[] array, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF75B3E6FC
	public virtual IAsyncResult BeginInvoke(Byte[] array, Int32 offset, Int32 count, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B3EBF8
	public virtual Int32 EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class WriteMethod
{
	// Methods

	// RVA: 0xFFFFFFFF75B3E9F4
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B3F388
	public virtual Void Invoke(Byte[] array, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF75B3EA38
	public virtual IAsyncResult BeginInvoke(Byte[] array, Int32 offset, Int32 count, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B3ED44
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.IO.Compression
internal class DeflateStreamNative
{
	// Fields
	private UnmanagedReadOrWrite feeder; // 0x10
	private Stream base_stream; // 0x18
	private SafeDeflateStreamHandle z_stream; // 0x20
	private GCHandle data; // 0x28
	private Boolean disposed; // 0x2C
	private Byte[] io_buffer; // 0x30

	// Methods

	// RVA: 0xFFFFFFFF75B3F860
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF72376C48
	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, Boolean gzip) { }

	// RVA: 0xFFFFFFFF75B3F8A8
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF72376E40
	public Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75B3E418
	public Void Flush() { }

	// RVA: 0xFFFFFFFF75B3E0E4
	public Int32 ReadZStream(IntPtr buffer, Int32 length) { }

	// RVA: 0xFFFFFFFF75B3E32C
	public Void WriteZStream(IntPtr buffer, Int32 length) { }

	// RVA: 0xFFFFFFFF75B3F7CC
	private static Int32 UnmanagedRead(IntPtr buffer, Int32 length, IntPtr data) { }

	// RVA: 0xFFFFFFFF75B3FA14
	private Int32 UnmanagedRead(IntPtr buffer, Int32 length) { }

	// RVA: 0xFFFFFFFF723772B0
	private static Int32 UnmanagedWrite(IntPtr buffer, Int32 length, IntPtr data) { }

	// RVA: 0xFFFFFFFF723774F4
	private Int32 UnmanagedWrite(IntPtr buffer, Int32 length) { }

	// RVA: 0xFFFFFFFF723773B0
	private static Void CheckResult(Int32 result, String where) { }

	// RVA: 0xFFFFFFFF72377344
	private static extern SafeDeflateStreamHandle CreateZStream(CompressionMode compress, Boolean gzip, UnmanagedReadOrWrite feeder, IntPtr data) { }

	// RVA: 0xFFFFFFFF75B3FB30
	private static extern Int32 CloseZStream(IntPtr stream) { }

	// RVA: 0xFFFFFFFF75B3F91C
	private static extern Int32 Flush(SafeDeflateStreamHandle stream) { }

	// RVA: 0xFFFFFFFF75B3F98C
	private static extern Int32 ReadZStream(SafeDeflateStreamHandle stream, IntPtr buffer, Int32 length) { }

	// RVA: 0xFFFFFFFF7237746C
	private static extern Int32 WriteZStream(SafeDeflateStreamHandle stream, IntPtr buffer, Int32 length) { }

}

// Namespace: 
private sealed class UnmanagedReadOrWrite
{
	// Methods

	// RVA: 0xFFFFFFFF75B3F864
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B3FB34
	public virtual Int32 Invoke(IntPtr buffer, Int32 length, IntPtr data) { }

	// RVA: 0xFFFFFFFF75B3FDB8
	public virtual IAsyncResult BeginInvoke(IntPtr buffer, Int32 length, IntPtr data, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B3FE74
	public virtual Int32 EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class SafeDeflateStreamHandle
{
	// Properties
	public override Boolean IsInvalid { get; }

	// Methods

	// RVA: 0xFFFFFFFF723776B8
	public override Boolean get_IsInvalid() { }

	// RVA: 0xFFFFFFFF75B3FB18
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF723776C8
	protected override Boolean ReleaseHandle() { }

}

// Namespace: System.Buffers
internal abstract class ArrayPool<T0>
{
	// Fields
	private static ArrayPool<T0> s_sharedInstance; // 0x0

	// Properties
	public static ArrayPool<T0> Shared { get; }

	// Methods

	// RVA: -1
	public static ArrayPool<T0> get_Shared() { }

	// RVA: -1
	private static ArrayPool<T0> EnsureSharedCreated() { }

	// RVA: -1
	public static ArrayPool<T0> Create() { }

	// RVA: -1
	public abstract T[] Rent(Int32 minimumLength) { }

	// RVA: -1
	public abstract Void Return(T[] array, Boolean clearArray) { }

	// RVA: -1
	protected Void .ctor() { }

}

// Namespace: System.Buffers
internal sealed class ArrayPoolEventSource
{
	// Fields
	internal static readonly ArrayPoolEventSource Log; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75B089C0
	internal Void BufferRented(Int32 bufferId, Int32 bufferSize, Int32 poolId, Int32 bucketId) { }

	// RVA: 0xFFFFFFFF75B089C4
	internal Void BufferAllocated(Int32 bufferId, Int32 bufferSize, Int32 poolId, Int32 bucketId, BufferAllocatedReason reason) { }

	// RVA: 0xFFFFFFFF75B089C8
	internal Void BufferReturned(Int32 bufferId, Int32 bufferSize, Int32 poolId) { }

	// RVA: 0xFFFFFFFF75B089CC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B08A0C
	private static Void .cctor() { }

}

// Namespace: 
internal enum BufferAllocatedReason
{
	// Fields
	public Int32 value__; // 0x10
	public const BufferAllocatedReason Pooled = 0;
	public const BufferAllocatedReason OverMaximumSize = 1;
	public const BufferAllocatedReason PoolExhausted = 2;
}

// Namespace: System.Buffers
internal sealed class DefaultArrayPool<T0>
{
	// Fields
	private static T[] s_emptyArray; // 0x0
	private readonly Bucket[] _buckets; // 0x0

	// Properties
	private Int32 Id { get; }

	// Methods

	// RVA: -1
	internal Void .ctor() { }

	// RVA: -1
	internal Void .ctor(Int32 maxArrayLength, Int32 maxArraysPerBucket) { }

	// RVA: -1
	private Int32 get_Id() { }

	// RVA: -1
	public override T[] Rent(Int32 minimumLength) { }

	// RVA: -1
	public override Void Return(T[] array, Boolean clearArray) { }

}

// Namespace: 
private sealed class Bucket
{
	// Fields
	internal readonly Int32 _bufferLength; // 0x0
	private readonly T[][] _buffers; // 0x0
	private readonly Int32 _poolId; // 0x0
	private SpinLock _lock; // 0x0
	private Int32 _index; // 0x0

	// Properties
	internal Int32 Id { get; }

	// Methods

	// RVA: -1
	internal Void .ctor(Int32 bufferLength, Int32 numberOfBuffers, Int32 poolId) { }

	// RVA: -1
	internal Int32 get_Id() { }

	// RVA: -1
	internal T[] Rent() { }

	// RVA: -1
	internal Void Return(T[] array) { }

}

// Namespace: System.Buffers
internal static class Utilities
{
	// Methods

	// RVA: 0xFFFFFFFF75B08A7C
	internal static Int32 SelectBucketIndex(Int32 bufferSize) { }

	// RVA: 0xFFFFFFFF75B08AF8
	internal static Int32 GetMaxSizeForBucket(Int32 binIndex) { }

}

// Namespace: System.Net
internal sealed class NetEventSource
{
	// Fields
	public static readonly NetEventSource Log; // 0x0

	// Properties
	public static Boolean IsEnabled { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B66958
	public static Void Enter(Object thisOrContextObject, FormattableString formattableString, String memberName) { }

	// RVA: 0xFFFFFFFF75B66EF8
	private Void Enter(String thisOrContextObject, String memberName, String parameters) { }

	// RVA: 0xFFFFFFFF75B66EFC
	public static Void Exit(Object thisOrContextObject, FormattableString formattableString, String memberName) { }

	// RVA: 0xFFFFFFFF75B66FA4
	private Void Exit(String thisOrContextObject, String memberName, String result) { }

	// RVA: 0xFFFFFFFF75B66FA8
	public static Void Error(Object thisOrContextObject, Object message, String memberName) { }

	// RVA: 0xFFFFFFFF75B67420
	private Void ErrorMessage(String thisOrContextObject, String memberName, String message) { }

	// RVA: 0xFFFFFFFF75B66A00
	public static Boolean get_IsEnabled() { }

	// RVA: 0xFFFFFFFF75B66A7C
	public static String IdOf(Object value) { }

	// RVA: 0xFFFFFFFF75B67424
	public static Int32 GetHashCode(Object value) { }

	// RVA: 0xFFFFFFFF75B6705C
	public static Object Format(Object value) { }

	// RVA: 0xFFFFFFFF75B66B78
	private static String Format(FormattableString s) { }

	// RVA: 0xFFFFFFFF75B6743C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B6747C
	private static Void .cctor() { }

}

// Namespace: System.Net
public enum SecurityProtocolType
{
	// Fields
	public Int32 value__; // 0x10
	public const SecurityProtocolType SystemDefault = 0;
	public const SecurityProtocolType Ssl3 = 48;
	public const SecurityProtocolType Tls = 192;
	public const SecurityProtocolType Tls11 = 768;
	public const SecurityProtocolType Tls12 = 3072;
}

// Namespace: System.Net
public class Authorization
{
	// Fields
	private String m_Message; // 0x10
	private Boolean m_Complete; // 0x18
	internal String ModuleAuthenticationType; // 0x20

	// Properties
	public String Message { get; }
	public Boolean Complete { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B430D8
	public Void .ctor(String token) { }

	// RVA: 0xFFFFFFFF75B43144
	public Void .ctor(String token, Boolean finished) { }

	// RVA: 0xFFFFFFFF75B431B8
	public String get_Message() { }

	// RVA: 0xFFFFFFFF75B431C0
	public Boolean get_Complete() { }

}

// Namespace: System.Net
public class CredentialCache
{
	// Properties
	public static ICredentials DefaultCredentials { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B4C838
	public static ICredentials get_DefaultCredentials() { }

}

// Namespace: System.Net
internal class SystemNetworkCredential
{
	// Fields
	internal static readonly SystemNetworkCredential defaultCredential; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75B776D4
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF75B776F4
	private static Void .cctor() { }

}

// Namespace: System.Net
public abstract class EndPoint
{
	// Properties
	public virtual AddressFamily AddressFamily { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B4F78C
	public virtual AddressFamily get_AddressFamily() { }

	// RVA: 0xFFFFFFFF75B4F834
	public virtual SocketAddress Serialize() { }

	// RVA: 0xFFFFFFFF75B4F8DC
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0xFFFFFFFF75B4F918
	protected Void .ctor() { }

}

// Namespace: System.Net
public enum FtpStatusCode
{
	// Fields
	public Int32 value__; // 0x10
	public const FtpStatusCode Undefined = 0;
	public const FtpStatusCode RestartMarker = 110;
	public const FtpStatusCode ServiceTemporarilyNotAvailable = 120;
	public const FtpStatusCode DataAlreadyOpen = 125;
	public const FtpStatusCode OpeningData = 150;
	public const FtpStatusCode CommandOK = 200;
	public const FtpStatusCode CommandExtraneous = 202;
	public const FtpStatusCode DirectoryStatus = 212;
	public const FtpStatusCode FileStatus = 213;
	public const FtpStatusCode SystemType = 215;
	public const FtpStatusCode SendUserCommand = 220;
	public const FtpStatusCode ClosingControl = 221;
	public const FtpStatusCode ClosingData = 226;
	public const FtpStatusCode EnteringPassive = 227;
	public const FtpStatusCode LoggedInProceed = 230;
	public const FtpStatusCode ServerWantsSecureSession = 234;
	public const FtpStatusCode FileActionOK = 250;
	public const FtpStatusCode PathnameCreated = 257;
	public const FtpStatusCode SendPasswordCommand = 331;
	public const FtpStatusCode NeedLoginAccount = 332;
	public const FtpStatusCode FileCommandPending = 350;
	public const FtpStatusCode ServiceNotAvailable = 421;
	public const FtpStatusCode CantOpenData = 425;
	public const FtpStatusCode ConnectionClosed = 426;
	public const FtpStatusCode ActionNotTakenFileUnavailableOrBusy = 450;
	public const FtpStatusCode ActionAbortedLocalProcessingError = 451;
	public const FtpStatusCode ActionNotTakenInsufficientSpace = 452;
	public const FtpStatusCode CommandSyntaxError = 500;
	public const FtpStatusCode ArgumentSyntaxError = 501;
	public const FtpStatusCode CommandNotImplemented = 502;
	public const FtpStatusCode BadCommandSequence = 503;
	public const FtpStatusCode NotLoggedIn = 530;
	public const FtpStatusCode AccountNeeded = 532;
	public const FtpStatusCode ActionNotTakenFileUnavailable = 550;
	public const FtpStatusCode ActionAbortedUnknownPageType = 551;
	public const FtpStatusCode FileActionAborted = 552;
	public const FtpStatusCode ActionNotTakenFilenameNotAllowed = 553;
}

// Namespace: System.Net
public class GlobalProxySelection
{
	// Properties
	public static IWebProxy Select { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B54FF4
	public static IWebProxy get_Select() { }

	// RVA: 0xFFFFFFFF75B5B7CC
	public static IWebProxy GetEmptyWebProxy() { }

}

// Namespace: System.Net
public enum HttpRequestHeader
{
	// Fields
	public Int32 value__; // 0x10
	public const HttpRequestHeader CacheControl = 0;
	public const HttpRequestHeader Connection = 1;
	public const HttpRequestHeader Date = 2;
	public const HttpRequestHeader KeepAlive = 3;
	public const HttpRequestHeader Pragma = 4;
	public const HttpRequestHeader Trailer = 5;
	public const HttpRequestHeader TransferEncoding = 6;
	public const HttpRequestHeader Upgrade = 7;
	public const HttpRequestHeader Via = 8;
	public const HttpRequestHeader Warning = 9;
	public const HttpRequestHeader Allow = 10;
	public const HttpRequestHeader ContentLength = 11;
	public const HttpRequestHeader ContentType = 12;
	public const HttpRequestHeader ContentEncoding = 13;
	public const HttpRequestHeader ContentLanguage = 14;
	public const HttpRequestHeader ContentLocation = 15;
	public const HttpRequestHeader ContentMd5 = 16;
	public const HttpRequestHeader ContentRange = 17;
	public const HttpRequestHeader Expires = 18;
	public const HttpRequestHeader LastModified = 19;
	public const HttpRequestHeader Accept = 20;
	public const HttpRequestHeader AcceptCharset = 21;
	public const HttpRequestHeader AcceptEncoding = 22;
	public const HttpRequestHeader AcceptLanguage = 23;
	public const HttpRequestHeader Authorization = 24;
	public const HttpRequestHeader Cookie = 25;
	public const HttpRequestHeader Expect = 26;
	public const HttpRequestHeader From = 27;
	public const HttpRequestHeader Host = 28;
	public const HttpRequestHeader IfMatch = 29;
	public const HttpRequestHeader IfModifiedSince = 30;
	public const HttpRequestHeader IfNoneMatch = 31;
	public const HttpRequestHeader IfRange = 32;
	public const HttpRequestHeader IfUnmodifiedSince = 33;
	public const HttpRequestHeader MaxForwards = 34;
	public const HttpRequestHeader ProxyAuthorization = 35;
	public const HttpRequestHeader Referer = 36;
	public const HttpRequestHeader Range = 37;
	public const HttpRequestHeader Te = 38;
	public const HttpRequestHeader Translate = 39;
	public const HttpRequestHeader UserAgent = 40;
}

// Namespace: System.Net
public enum HttpStatusCode
{
	// Fields
	public Int32 value__; // 0x10
	public const HttpStatusCode Continue = 100;
	public const HttpStatusCode SwitchingProtocols = 101;
	public const HttpStatusCode OK = 200;
	public const HttpStatusCode Created = 201;
	public const HttpStatusCode Accepted = 202;
	public const HttpStatusCode NonAuthoritativeInformation = 203;
	public const HttpStatusCode NoContent = 204;
	public const HttpStatusCode ResetContent = 205;
	public const HttpStatusCode PartialContent = 206;
	public const HttpStatusCode MultipleChoices = 300;
	public const HttpStatusCode Ambiguous = 300;
	public const HttpStatusCode MovedPermanently = 301;
	public const HttpStatusCode Moved = 301;
	public const HttpStatusCode Found = 302;
	public const HttpStatusCode Redirect = 302;
	public const HttpStatusCode SeeOther = 303;
	public const HttpStatusCode RedirectMethod = 303;
	public const HttpStatusCode NotModified = 304;
	public const HttpStatusCode UseProxy = 305;
	public const HttpStatusCode Unused = 306;
	public const HttpStatusCode TemporaryRedirect = 307;
	public const HttpStatusCode RedirectKeepVerb = 307;
	public const HttpStatusCode BadRequest = 400;
	public const HttpStatusCode Unauthorized = 401;
	public const HttpStatusCode PaymentRequired = 402;
	public const HttpStatusCode Forbidden = 403;
	public const HttpStatusCode NotFound = 404;
	public const HttpStatusCode MethodNotAllowed = 405;
	public const HttpStatusCode NotAcceptable = 406;
	public const HttpStatusCode ProxyAuthenticationRequired = 407;
	public const HttpStatusCode RequestTimeout = 408;
	public const HttpStatusCode Conflict = 409;
	public const HttpStatusCode Gone = 410;
	public const HttpStatusCode LengthRequired = 411;
	public const HttpStatusCode PreconditionFailed = 412;
	public const HttpStatusCode RequestEntityTooLarge = 413;
	public const HttpStatusCode RequestUriTooLong = 414;
	public const HttpStatusCode UnsupportedMediaType = 415;
	public const HttpStatusCode RequestedRangeNotSatisfiable = 416;
	public const HttpStatusCode ExpectationFailed = 417;
	public const HttpStatusCode UpgradeRequired = 426;
	public const HttpStatusCode InternalServerError = 500;
	public const HttpStatusCode NotImplemented = 501;
	public const HttpStatusCode BadGateway = 502;
	public const HttpStatusCode ServiceUnavailable = 503;
	public const HttpStatusCode GatewayTimeout = 504;
	public const HttpStatusCode HttpVersionNotSupported = 505;
}

// Namespace: System.Net
public class HttpVersion
{
	// Fields
	public static readonly Version Version10; // 0x0
	public static readonly Version Version11; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75B5C51C
	private static Void .cctor() { }

}

// Namespace: System.Net
public interface IAuthenticationModule
{
	// Properties
	public abstract String AuthenticationType { get; }

	// Methods

	// RVA: -1
	public abstract Authorization Authenticate(String challenge, WebRequest request, ICredentials credentials) { }

	// RVA: -1
	public abstract Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: -1
	public abstract String get_AuthenticationType() { }

}

// Namespace: System.Net
public interface ICertificatePolicy
{
	// Methods

	// RVA: -1
	public abstract Boolean CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, Int32 certificateProblem) { }

}

// Namespace: System.Net
public interface ICredentials
{
	// Methods

	// RVA: -1
	public abstract NetworkCredential GetCredential(Uri uri, String authType) { }

}

// Namespace: System.Net
public class IPAddress
{
	// Fields
	public static readonly IPAddress Any; // 0x0
	public static readonly IPAddress Loopback; // 0x8
	public static readonly IPAddress Broadcast; // 0x10
	public static readonly IPAddress None; // 0x18
	internal const Int64 LoopbackMask = 255;
	internal Int64 m_Address; // 0x10
	internal String m_ToString; // 0x18
	public static readonly IPAddress IPv6Any; // 0x20
	public static readonly IPAddress IPv6Loopback; // 0x28
	public static readonly IPAddress IPv6None; // 0x30
	private AddressFamily m_Family; // 0x20
	private UInt16[] m_Numbers; // 0x28
	private Int64 m_ScopeId; // 0x30
	private Int32 m_HashCode; // 0x38
	internal const Int32 IPv4AddressBytes = 4;
	internal const Int32 IPv6AddressBytes = 16;
	internal const Int32 NumberOfLabels = 8;

	// Properties
	public Int64 Address { get; }
	public AddressFamily AddressFamily { get; }
	public Int64 ScopeId { get; }
	internal Boolean IsBroadcast { get; }

	// Methods

	// RVA: 0xFFFFFFFF7237CDC0
	public Void .ctor(Int64 newAddress) { }

	// RVA: 0xFFFFFFFF75B62EF4
	public Void .ctor(Byte[] address, Int64 scopeid) { }

	// RVA: 0xFFFFFFFF75B630E0
	private Void .ctor(UInt16[] address, UInt32 scopeid) { }

	// RVA: 0xFFFFFFFF75B63168
	public Void .ctor(Byte[] address) { }

	// RVA: 0xFFFFFFFF75B633C8
	internal Void .ctor(Int32 newAddress) { }

	// RVA: 0xFFFFFFFF7237BFB4
	public static Boolean TryParse(String ipString, out IPAddress address) { }

	// RVA: 0xFFFFFFFF7237D128
	public static IPAddress Parse(String ipString) { }

	// RVA: 0xFFFFFFFF7237CE58
	private static IPAddress InternalParse(String ipString, Boolean tryParse) { }

	// RVA: 0xFFFFFFFF75B6342C
	public Int64 get_Address() { }

	// RVA: 0xFFFFFFFF75B5A5C0
	public Byte[] GetAddressBytes() { }

	// RVA: 0xFFFFFFFF75B634A4
	public AddressFamily get_AddressFamily() { }

	// RVA: 0xFFFFFFFF75B634AC
	public Int64 get_ScopeId() { }

	// RVA: 0xFFFFFFFF75B63524
	public override String ToString() { }

	// RVA: 0xFFFFFFFF7237D170
	public static Int32 HostToNetworkOrder(Int32 host) { }

	// RVA: 0xFFFFFFFF75B63B1C
	public static Int16 HostToNetworkOrder(Int16 host) { }

	// RVA: 0xFFFFFFFF7237D1B8
	public static Int32 NetworkToHostOrder(Int32 network) { }

	// RVA: 0xFFFFFFFF75B63B28
	public static Boolean IsLoopback(IPAddress address) { }

	// RVA: 0xFFFFFFFF75B63C2C
	internal Boolean get_IsBroadcast() { }

	// RVA: 0xFFFFFFFF7237D22C
	internal Boolean Equals(Object comparandObj, Boolean compareScopeId) { }

	// RVA: 0xFFFFFFFF7237D3E0
	public override Boolean Equals(Object comparand) { }

	// RVA: 0xFFFFFFFF75B63C98
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75B63D4C
	public IPAddress MapToIPv6() { }

	// RVA: 0xFFFFFFFF75B63DD0
	public IPAddress MapToIPv4() { }

	// RVA: 0xFFFFFFFF75B63E5C
	private static Void .cctor() { }

}

// Namespace: System.Net
public class IPEndPoint
{
	// Fields
	public const Int32 MinPort = 0;
	public const Int32 MaxPort = 65535;
	private IPAddress m_Address; // 0x10
	private Int32 m_Port; // 0x18
	internal const Int32 AnyPort = 0;
	internal static IPEndPoint Any; // 0x0
	internal static IPEndPoint IPv6Any; // 0x8

	// Properties
	public override AddressFamily AddressFamily { get; }
	public IPAddress Address { get; }
	public Int32 Port { get; }

	// Methods

	// RVA: 0xFFFFFFFF7237D3E8
	public override AddressFamily get_AddressFamily() { }

	// RVA: 0xFFFFFFFF75B640C0
	public Void .ctor(Int64 address, Int32 port) { }

	// RVA: 0xFFFFFFFF7237A124
	public Void .ctor(IPAddress address, Int32 port) { }

	// RVA: 0xFFFFFFFF75B6419C
	public IPAddress get_Address() { }

	// RVA: 0xFFFFFFFF75B641A4
	public Int32 get_Port() { }

	// RVA: 0xFFFFFFFF75B641AC
	public override String ToString() { }

	// RVA: 0xFFFFFFFF7237D408
	public override SocketAddress Serialize() { }

	// RVA: 0xFFFFFFFF7237D4F0
	public override EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0xFFFFFFFF75B64278
	public override Boolean Equals(Object comparand) { }

	// RVA: 0xFFFFFFFF75B64344
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75B64384
	private static Void .cctor() { }

}

// Namespace: System.Net
public class IPHostEntry
{
	// Fields
	private String hostName; // 0x10
	private String[] aliases; // 0x18
	private IPAddress[] addressList; // 0x20
	internal Boolean isTrustedHost; // 0x28

	// Properties
	public String HostName { get; set; }
	public String[] Aliases { set; }
	public IPAddress[] AddressList { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B64458
	public String get_HostName() { }

	// RVA: 0xFFFFFFFF75B64460
	public Void set_HostName(String value) { }

	// RVA: 0xFFFFFFFF75B64498
	public Void set_Aliases(String[] value) { }

	// RVA: 0xFFFFFFFF75B644D0
	public IPAddress[] get_AddressList() { }

	// RVA: 0xFFFFFFFF75B644D8
	public Void set_AddressList(IPAddress[] value) { }

	// RVA: 0xFFFFFFFF75B64510
	public Void .ctor() { }

}

// Namespace: System.Net
public interface IWebRequestCreate
{
	// Methods

	// RVA: -1
	public abstract WebRequest Create(Uri uri) { }

}

// Namespace: System.Net
internal class InternalException
{
	// Methods

	// RVA: 0xFFFFFFFF75B646B8
	internal Void .ctor() { }

}

// Namespace: System.Net
internal static class NclUtilities
{
	// Fields
	private static IPAddress[] _LocalAddresses; // 0x0
	private static Object _LocalAddressesLock; // 0x8
	internal static String _LocalDomainName; // 0x10

	// Properties
	internal static IPAddress[] LocalAddresses { get; }
	private static Object LocalAddressesLock { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B6682C
	internal static Boolean IsAddressLocal(IPAddress ipAddress) { }

	// RVA: 0xFFFFFFFF7237DDDC
	private static IPHostEntry GetLocalHost() { }

	// RVA: 0xFFFFFFFF7237D898
	internal static IPAddress[] get_LocalAddresses() { }

	// RVA: 0xFFFFFFFF75B668C8
	private static Object get_LocalAddressesLock() { }

}

// Namespace: System.Net
internal static class ValidationHelper
{
	// Fields
	public static String[] EmptyArray; // 0x0
	internal static readonly Char[] InvalidMethodChars; // 0x8
	internal static readonly Char[] InvalidParamChars; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75B792A4
	public static String MakeStringNull(String stringValue) { }

	// RVA: 0xFFFFFFFF72384C60
	public static Boolean IsBlankString(String stringValue) { }

	// RVA: 0xFFFFFFFF72382D4C
	public static Boolean ValidateTcpPort(Int32 port) { }

	// RVA: 0xFFFFFFFF75B792B8
	private static Void .cctor() { }

}

// Namespace: System.Net
internal static class ExceptionHelper
{
	// Properties
	internal static NotImplementedException MethodNotImplementedException { get; }
	internal static NotImplementedException PropertyNotImplementedException { get; }
	internal static WebException RequestAbortedException { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B4F870
	internal static NotImplementedException get_MethodNotImplementedException() { }

	// RVA: 0xFFFFFFFF75B4F7C8
	internal static NotImplementedException get_PropertyNotImplementedException() { }

	// RVA: 0xFFFFFFFF75B4F91C
	internal static WebException get_RequestAbortedException() { }

}

// Namespace: System.Net
internal class WebRequestPrefixElement
{
	// Fields
	public String Prefix; // 0x10
	internal IWebRequestCreate creator; // 0x18
	internal Type creatorType; // 0x20

	// Properties
	public IWebRequestCreate Creator { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B85CDC
	public IWebRequestCreate get_Creator() { }

	// RVA: 0xFFFFFFFF75B86AA4
	public Void set_Creator(IWebRequestCreate value) { }

	// RVA: 0xFFFFFFFF75B86078
	public Void .ctor(String P, IWebRequestCreate C) { }

}

// Namespace: System.Net
public sealed class HttpContinueDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75B5BF7C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B5BFC0
	public virtual Void Invoke(Int32 StatusCode, WebHeaderCollection httpHeaders) { }

	// RVA: 0xFFFFFFFF75B5C230
	public virtual IAsyncResult BeginInvoke(Int32 StatusCode, WebHeaderCollection httpHeaders, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B5C2C4
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Net
internal class KnownHttpVerb
{
	// Fields
	internal String Name; // 0x10
	internal Boolean RequireContentBody; // 0x18
	internal Boolean ContentBodyNotAllowed; // 0x19
	internal Boolean ConnectRequest; // 0x1A
	internal Boolean ExpectNoContentResponse; // 0x1B
	private static ListDictionary NamedHeaders; // 0x0
	internal static KnownHttpVerb Get; // 0x8
	internal static KnownHttpVerb Connect; // 0x10
	internal static KnownHttpVerb Head; // 0x18
	internal static KnownHttpVerb Put; // 0x20
	internal static KnownHttpVerb Post; // 0x28
	internal static KnownHttpVerb MkCol; // 0x30

	// Methods

	// RVA: 0xFFFFFFFF75B646C0
	internal Void .ctor(String name, Boolean requireContentBody, Boolean contentBodyNotAllowed, Boolean connectRequest, Boolean expectNoContentResponse) { }

	// RVA: 0xFFFFFFFF75B64728
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75B64AB4
	public static KnownHttpVerb Parse(String name) { }

}

// Namespace: System.Net
public class NetworkCredential
{
	// Fields
	private String m_domain; // 0x10
	private String m_userName; // 0x18
	private SecureString m_password; // 0x20

	// Properties
	public String UserName { get; set; }
	public String Password { get; set; }
	public String Domain { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B67574
	public Void .ctor(String userName, String password) { }

	// RVA: 0xFFFFFFFF75B67588
	public Void .ctor(String userName, String password, String domain) { }

	// RVA: 0xFFFFFFFF75B5AFF0
	public String get_UserName() { }

	// RVA: 0xFFFFFFFF75B67654
	public Void set_UserName(String value) { }

	// RVA: 0xFFFFFFFF75B5AFF8
	public String get_Password() { }

	// RVA: 0xFFFFFFFF75B676A8
	public Void set_Password(String value) { }

	// RVA: 0xFFFFFFFF75B5B004
	public String get_Domain() { }

	// RVA: 0xFFFFFFFF75B676EC
	public Void set_Domain(String value) { }

	// RVA: 0xFFFFFFFF75B6774C
	internal String InternalGetUserName() { }

	// RVA: 0xFFFFFFFF75B67740
	internal String InternalGetPassword() { }

	// RVA: 0xFFFFFFFF75B67754
	internal String InternalGetDomain() { }

	// RVA: 0xFFFFFFFF75B6775C
	public NetworkCredential GetCredential(Uri uri, String authType) { }

}

// Namespace: System.Net
public class ProtocolViolationException
{
	// Methods

	// RVA: 0xFFFFFFFF75B54380
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B53CD8
	public Void .ctor(String message) { }

	// RVA: 0xFFFFFFFF75B69F44
	protected Void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B69F4C
	private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B69F54
	public override Void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

// Namespace: System.Net
public class SocketAddress
{
	// Fields
	internal Int32 m_Size; // 0x10
	internal Byte[] m_Buffer; // 0x18
	private Boolean m_changed; // 0x20
	private Int32 m_hash; // 0x24

	// Properties
	public AddressFamily Family { get; }
	public Int32 Size { get; }
	public Byte Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF7237D7DC
	public AddressFamily get_Family() { }

	// RVA: 0xFFFFFFFF75B6D458
	public Int32 get_Size() { }

	// RVA: 0xFFFFFFFF75B6D460
	public Byte get_Item(Int32 offset) { }

	// RVA: 0xFFFFFFFF7237F37C
	public Void .ctor(AddressFamily family, Int32 size) { }

	// RVA: 0xFFFFFFFF7237F448
	internal Void .ctor(IPAddress ipAddress) { }

	// RVA: 0xFFFFFFFF7237D48C
	internal Void .ctor(IPAddress ipaddress, Int32 port) { }

	// RVA: 0xFFFFFFFF7237F650
	internal IPAddress GetIPAddress() { }

	// RVA: 0xFFFFFFFF7237D818
	internal IPEndPoint GetIPEndPoint() { }

	// RVA: 0xFFFFFFFF75B6D50C
	public override Boolean Equals(Object comparand) { }

	// RVA: 0xFFFFFFFF75B6D5D4
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75B6D724
	public override String ToString() { }

}

// Namespace: System.Net
public class WebException
{
	// Fields
	private WebExceptionStatus m_Status; // 0x88
	private WebResponse m_Response; // 0x90
	private WebExceptionInternalStatus m_InternalStatus; // 0x98

	// Properties
	public WebExceptionStatus Status { get; }
	public WebResponse Response { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B830C0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B830D0
	public Void .ctor(String message) { }

	// RVA: 0xFFFFFFFF75B7A540
	public Void .ctor(String message, Exception innerException) { }

	// RVA: 0xFFFFFFFF75B7BFA4
	public Void .ctor(String message, WebExceptionStatus status) { }

	// RVA: 0xFFFFFFFF75B829D0
	internal Void .ctor(String message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	// RVA: 0xFFFFFFFF75B7EBC8
	public Void .ctor(String message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0xFFFFFFFF75B830FC
	internal Void .ctor(String message, String data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0xFFFFFFFF75B830E4
	internal Void .ctor(String message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0xFFFFFFFF75B831E8
	internal Void .ctor(String message, String data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0xFFFFFFFF75B832D0
	protected Void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B832E0
	private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B832F0
	public override Void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B832F8
	public WebExceptionStatus get_Status() { }

	// RVA: 0xFFFFFFFF75B83300
	public WebResponse get_Response() { }

}

// Namespace: System.Net
internal enum WebExceptionInternalStatus
{
	// Fields
	public Int32 value__; // 0x10
	public const WebExceptionInternalStatus RequestFatal = 0;
	public const WebExceptionInternalStatus ServicePointFatal = 1;
	public const WebExceptionInternalStatus Recoverable = 2;
	public const WebExceptionInternalStatus Isolated = 3;
}

// Namespace: System.Net
public enum WebExceptionStatus
{
	// Fields
	public Int32 value__; // 0x10
	public const WebExceptionStatus Success = 0;
	public const WebExceptionStatus NameResolutionFailure = 1;
	public const WebExceptionStatus ConnectFailure = 2;
	public const WebExceptionStatus ReceiveFailure = 3;
	public const WebExceptionStatus SendFailure = 4;
	public const WebExceptionStatus PipelineFailure = 5;
	public const WebExceptionStatus RequestCanceled = 6;
	public const WebExceptionStatus ProtocolError = 7;
	public const WebExceptionStatus ConnectionClosed = 8;
	public const WebExceptionStatus TrustFailure = 9;
	public const WebExceptionStatus SecureChannelFailure = 10;
	public const WebExceptionStatus ServerProtocolViolation = 11;
	public const WebExceptionStatus KeepAliveFailure = 12;
	public const WebExceptionStatus Pending = 13;
	public const WebExceptionStatus Timeout = 14;
	public const WebExceptionStatus ProxyNameResolutionFailure = 15;
	public const WebExceptionStatus UnknownError = 16;
	public const WebExceptionStatus MessageLengthLimitExceeded = 17;
	public const WebExceptionStatus CacheEntryNotFound = 18;
	public const WebExceptionStatus RequestProhibitedByCachePolicy = 19;
	public const WebExceptionStatus RequestProhibitedByProxy = 20;
}

// Namespace: System.Net
internal static class WebExceptionMapping
{
	// Fields
	private static readonly String[] s_Mapping; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75B83308
	internal static String GetWebStatusString(WebExceptionStatus status) { }

	// RVA: 0xFFFFFFFF75B834D8
	private static Void .cctor() { }

}

// Namespace: System.Net
internal enum WebHeaderCollectionType
{
	// Fields
	public UInt16 value__; // 0x10
	public const WebHeaderCollectionType Unknown = 0;
	public const WebHeaderCollectionType WebRequest = 1;
	public const WebHeaderCollectionType WebResponse = 2;
	public const WebHeaderCollectionType HttpWebRequest = 3;
	public const WebHeaderCollectionType HttpWebResponse = 4;
	public const WebHeaderCollectionType HttpListenerRequest = 5;
	public const WebHeaderCollectionType HttpListenerResponse = 6;
	public const WebHeaderCollectionType FtpWebRequest = 7;
	public const WebHeaderCollectionType FtpWebResponse = 8;
	public const WebHeaderCollectionType FileWebRequest = 9;
	public const WebHeaderCollectionType FileWebResponse = 10;
}

// Namespace: System.Net
public class WebHeaderCollection
{
	// Fields
	private static readonly HeaderInfoTable HInfo; // 0x0
	private String[] m_CommonHeaders; // 0x68
	private Int32 m_NumCommonHeaders; // 0x70
	private static readonly String[] s_CommonHeaderNames; // 0x8
	private static readonly SByte[] s_CommonHeaderHints; // 0x10
	private NameValueCollection m_InnerCollection; // 0x78
	private WebHeaderCollectionType m_Type; // 0x80
	private static readonly Char[] HttpTrimCharacters; // 0x18
	private static RfcChar[] RfcCharMap; // 0x20

	// Properties
	private NameValueCollection InnerCollection { get; }
	private Boolean AllowHttpRequestHeader { get; }
	public override Int32 Count { get; }
	public override KeysCollection Keys { get; }
	public override String[] AllKeys { get; }

	// Methods

	// RVA: 0xFFFFFFFF72389E58
	private Void NormalizeCommonHeaders() { }

	// RVA: 0xFFFFFFFF72389F6C
	private NameValueCollection get_InnerCollection() { }

	// RVA: 0xFFFFFFFF723867C4
	internal static Boolean AllowMultiValues(String name) { }

	// RVA: 0xFFFFFFFF75B83558
	private Boolean get_AllowHttpRequestHeader() { }

	// RVA: 0xFFFFFFFF75B83598
	public Void Remove(HttpRequestHeader header) { }

	// RVA: 0xFFFFFFFF72386860
	internal Void AddInternal(String name, String value) { }

	// RVA: 0xFFFFFFFF75B836A4
	internal Void ChangeInternal(String name, String value) { }

	// RVA: 0xFFFFFFFF72384D58
	internal Void RemoveInternal(String name) { }

	// RVA: 0xFFFFFFFF75B83704
	internal Void CheckUpdate(String name, String value) { }

	// RVA: 0xFFFFFFFF7238A004
	internal static String CheckBadChars(String name, Boolean isHeaderValue) { }

	// RVA: 0xFFFFFFFF75B83764
	internal static Boolean IsValidToken(String token) { }

	// RVA: 0xFFFFFFFF7238A300
	internal static Boolean ContainsNonAsciiChars(String token) { }

	// RVA: 0xFFFFFFFF75B83844
	internal Void ThrowOnRestrictedHeader(String headerName) { }

	// RVA: 0xFFFFFFFF75B839A4
	public override Void Add(String name, String value) { }

	// RVA: 0xFFFFFFFF72384E48
	public Void Add(String header) { }

	// RVA: 0xFFFFFFFF7238A350
	public override Void Set(String name, String value) { }

	// RVA: 0xFFFFFFFF7238695C
	internal Void SetInternal(String name, String value) { }

	// RVA: 0xFFFFFFFF7238A694
	public override Void Remove(String name) { }

	// RVA: 0xFFFFFFFF75B83B20
	public override String[] GetValues(String header) { }

	// RVA: 0xFFFFFFFF75B83CDC
	public override String ToString() { }

	// RVA: 0xFFFFFFFF7238A898
	internal static String GetAsString(NameValueCollection cc, Boolean winInetCompat, Boolean forTrace) { }

	// RVA: 0xFFFFFFFF72384DF8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B83D28
	internal Void .ctor(WebHeaderCollectionType type) { }

	// RVA: 0xFFFFFFFF75B83DF4
	protected Void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B83FB8
	public override Void OnDeserialization(Object sender) { }

	// RVA: 0xFFFFFFFF75B83FBC
	public override Void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B84144
	private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF7238AC28
	public override String Get(String name) { }

	// RVA: 0xFFFFFFFF75B84154
	public override IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF7238AF58
	public override Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75B841DC
	public override KeysCollection get_Keys() { }

	// RVA: 0xFFFFFFFF75B84218
	internal override Boolean InternalHasKeys() { }

	// RVA: 0xFFFFFFFF7238AF94
	public override String Get(Int32 index) { }

	// RVA: 0xFFFFFFFF7238B048
	public override String GetKey(Int32 index) { }

	// RVA: 0xFFFFFFFF75B84250
	public override String[] get_AllKeys() { }

	// RVA: 0xFFFFFFFF75B8428C
	private static Void .cctor() { }

}

// Namespace: 
private enum RfcChar
{
	// Fields
	public Byte value__; // 0x10
	public const RfcChar High = 0;
	public const RfcChar Reg = 1;
	public const RfcChar Ctl = 2;
	public const RfcChar CR = 3;
	public const RfcChar LF = 4;
	public const RfcChar WS = 5;
	public const RfcChar Colon = 6;
	public const RfcChar Delim = 7;
}

// Namespace: System.Net
internal class CaseInsensitiveAscii
{
	// Fields
	internal static readonly CaseInsensitiveAscii StaticInstance; // 0x0
	internal static readonly Byte[] AsciiToLower; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF72378B74
	public Int32 GetHashCode(Object myObject) { }

	// RVA: 0xFFFFFFFF75B43D78
	public Int32 Compare(Object firstObject, Object secondObject) { }

	// RVA: 0xFFFFFFFF72378C90
	private Int32 FastGetHashCode(String myString) { }

	// RVA: 0xFFFFFFFF72378D98
	public Boolean Equals(Object firstObject, Object secondObject) { }

	// RVA: 0xFFFFFFFF75B43EE0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B43EE4
	private static Void .cctor() { }

}

// Namespace: System.Net
public abstract class WebRequest
{
	// Fields
	private static ArrayList s_PrefixList; // 0x0
	private static Object s_InternalSyncObject; // 0x8
	private static Queue s_DefaultTimerQueue; // 0x10
	private AuthenticationLevel m_AuthenticationLevel; // 0x18
	private TokenImpersonationLevel m_ImpersonationLevel; // 0x1C
	private RequestCachePolicy m_CachePolicy; // 0x20
	private RequestCacheProtocol m_CacheProtocol; // 0x28
	private RequestCacheBinding m_CacheBinding; // 0x30
	private static DesignerWebRequestCreate webRequestCreate; // 0x18
	private static IWebProxy s_DefaultWebProxy; // 0x20
	private static Boolean s_DefaultWebProxyInitialized; // 0x28

	// Properties
	private static Object InternalSyncObject { get; }
	internal static ArrayList PrefixList { get; }
	public virtual RequestCachePolicy CachePolicy { set; }
	public virtual String Method { get; set; }
	public virtual Uri RequestUri { get; }
	public virtual WebHeaderCollection Headers { get; set; }
	public virtual Int64 ContentLength { get; set; }
	public virtual String ContentType { get; set; }
	public virtual ICredentials Credentials { get; set; }
	public virtual IWebProxy Proxy { get; set; }
	public virtual Int32 Timeout { get; set; }
	internal RequestCacheProtocol CacheProtocol { get; set; }
	internal static IWebProxy InternalDefaultWebProxy { get; }
	public static IWebProxy DefaultWebProxy { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B85B54
	private static Object get_InternalSyncObject() { }

	// RVA: 0xFFFFFFFF7238B0FC
	private static WebRequest Create(Uri requestUri, Boolean useUriBase) { }

	// RVA: 0xFFFFFFFF75B7D168
	public static WebRequest Create(String requestUriString) { }

	// RVA: 0xFFFFFFFF75B7989C
	public static WebRequest Create(Uri requestUri) { }

	// RVA: 0xFFFFFFFF75B85BD0
	internal static ArrayList get_PrefixList() { }

	// RVA: 0xFFFFFFFF75B85E58
	private static ArrayList PopulatePrefixList() { }

	// RVA: 0xFFFFFFFF75B860DC
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF75B8610C
	protected Void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B86114
	private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B86124
	protected virtual Void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B86128
	public virtual Void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0xFFFFFFFF75B8612C
	private Void InternalSetCachePolicy(RequestCachePolicy policy) { }

	// RVA: 0xFFFFFFFF75B8622C
	public virtual String get_Method() { }

	// RVA: 0xFFFFFFFF75B8626C
	public virtual Void set_Method(String value) { }

	// RVA: 0xFFFFFFFF75B862AC
	public virtual Uri get_RequestUri() { }

	// RVA: 0xFFFFFFFF75B862EC
	public virtual WebHeaderCollection get_Headers() { }

	// RVA: 0xFFFFFFFF75B8632C
	public virtual Void set_Headers(WebHeaderCollection value) { }

	// RVA: 0xFFFFFFFF75B8636C
	public virtual Int64 get_ContentLength() { }

	// RVA: 0xFFFFFFFF75B863AC
	public virtual Void set_ContentLength(Int64 value) { }

	// RVA: 0xFFFFFFFF75B863EC
	public virtual String get_ContentType() { }

	// RVA: 0xFFFFFFFF75B8642C
	public virtual Void set_ContentType(String value) { }

	// RVA: 0xFFFFFFFF75B8646C
	public virtual ICredentials get_Credentials() { }

	// RVA: 0xFFFFFFFF75B864AC
	public virtual Void set_Credentials(ICredentials value) { }

	// RVA: 0xFFFFFFFF75B864EC
	public virtual IWebProxy get_Proxy() { }

	// RVA: 0xFFFFFFFF75B8652C
	public virtual Void set_Proxy(IWebProxy value) { }

	// RVA: 0xFFFFFFFF75B8656C
	public virtual Int32 get_Timeout() { }

	// RVA: 0xFFFFFFFF75B865AC
	public virtual Void set_Timeout(Int32 value) { }

	// RVA: 0xFFFFFFFF75B865EC
	public virtual Stream GetRequestStream() { }

	// RVA: 0xFFFFFFFF75B8662C
	public virtual WebResponse GetResponse() { }

	// RVA: 0xFFFFFFFF75B8666C
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75B866AC
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B866EC
	public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75B8672C
	public virtual Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B8676C
	public virtual Void Abort() { }

	// RVA: 0xFFFFFFFF75B867AC
	internal RequestCacheProtocol get_CacheProtocol() { }

	// RVA: 0xFFFFFFFF75B867B4
	internal Void set_CacheProtocol(RequestCacheProtocol value) { }

	// RVA: 0xFFFFFFFF75B867EC
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	// RVA: 0xFFFFFFFF75B86940
	public static IWebProxy get_DefaultWebProxy() { }

	// RVA: 0xFFFFFFFF75B86970
	private static Void .cctor() { }

}

// Namespace: 
internal class DesignerWebRequestCreate
{
	// Methods

	// RVA: 0xFFFFFFFF75B86A08
	public WebRequest Create(Uri uri) { }

	// RVA: 0xFFFFFFFF75B86A04
	public Void .ctor() { }

}

// Namespace: 
internal class WebProxyWrapperOpaque
{
	// Fields
	protected readonly WebProxy webProxy; // 0x10

	// Properties
	public ICredentials Credentials { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B86A4C
	public Uri GetProxy(Uri destination) { }

	// RVA: 0xFFFFFFFF75B86A68
	public Boolean IsBypassed(Uri host) { }

	// RVA: 0xFFFFFFFF75B86A84
	public ICredentials get_Credentials() { }

}

// Namespace: 
internal class WebProxyWrapper
{
	// Properties
	internal WebProxy WebProxy { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B86A44
	internal WebProxy get_WebProxy() { }

}

// Namespace: System.Net
public abstract class WebResponse
{
	// Properties
	public virtual Int64 ContentLength { get; }
	public virtual Uri ResponseUri { get; }
	public virtual WebHeaderCollection Headers { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B86ADC
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF75B86AE4
	protected Void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B86AEC
	private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B86AFC
	protected virtual Void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B86B00
	public virtual Void Close() { }

	// RVA: 0xFFFFFFFF75B86B04
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75B86B5C
	protected virtual Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75B86BFC
	public virtual Int64 get_ContentLength() { }

	// RVA: 0xFFFFFFFF75B86C3C
	public virtual Stream GetResponseStream() { }

	// RVA: 0xFFFFFFFF75B86C7C
	public virtual Uri get_ResponseUri() { }

	// RVA: 0xFFFFFFFF75B86CBC
	public virtual WebHeaderCollection get_Headers() { }

}

// Namespace: System.Net
public static class WebUtility
{
	// Fields
	private static readonly Char[] _htmlEntityEndingChars; // 0x0
	private static UnicodeDecodingConformance _htmlDecodeConformance; // 0x8
	private static UnicodeEncodingConformance _htmlEncodeConformance; // 0xC

	// Methods

	// RVA: 0xFFFFFFFF75B92AF8
	private static Byte[] UrlEncode(Byte[] bytes, Int32 offset, Int32 count, Boolean alwaysCreateNewReturnValue) { }

	// RVA: 0xFFFFFFFF75B92BD0
	private static Byte[] UrlEncode(Byte[] bytes, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF75B9309C
	public static String UrlEncode(String value) { }

	// RVA: 0xFFFFFFFF75B93080
	private static Char IntToHex(Int32 n) { }

	// RVA: 0xFFFFFFFF75B93030
	private static Boolean IsUrlSafeChar(Char ch) { }

	// RVA: 0xFFFFFFFF75B92F40
	private static Boolean ValidateUrlEncodingParameters(Byte[] bytes, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF75B93184
	private static Void .cctor() { }

}

// Namespace: System.Net
internal class BufferOffsetSize
{
	// Fields
	internal Byte[] Buffer; // 0x10
	internal Int32 Offset; // 0x18
	internal Int32 Size; // 0x1C

	// Methods

	// RVA: 0xFFFFFFFF75B43B98
	internal Void .ctor(Byte[] buffer, Int32 offset, Int32 size, Boolean copyBuffer) { }

}

// Namespace: System.Net
internal sealed class HeaderParser
{
	// Methods

	// RVA: 0xFFFFFFFF75B5BAF8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B5BB40
	public virtual String[] Invoke(String value) { }

	// RVA: 0xFFFFFFFF75B5BED4
	public virtual IAsyncResult BeginInvoke(String value, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B5BF24
	public virtual String[] EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Net
internal class HeaderInfo
{
	// Fields
	internal readonly Boolean IsRequestRestricted; // 0x10
	internal readonly Boolean IsResponseRestricted; // 0x11
	internal readonly HeaderParser Parser; // 0x18
	internal readonly String HeaderName; // 0x20
	internal readonly Boolean AllowMultiValues; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75B5B830
	internal Void .ctor(String name, Boolean requestRestricted, Boolean responseRestricted, Boolean multi, HeaderParser p) { }

}

// Namespace: System.Net
internal class HeaderInfoTable
{
	// Fields
	private static Hashtable HeaderHashTable; // 0x0
	private static HeaderInfo UnknownHeaderInfo; // 0x8
	private static HeaderParser SingleParser; // 0x10
	private static HeaderParser MultiParser; // 0x18

	// Properties
	internal HeaderInfo Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B5B8B0
	private static String[] ParseSingleValue(String value) { }

	// RVA: 0xFFFFFFFF75B5B908
	private static String[] ParseMultiValue(String value) { }

	// RVA: 0xFFFFFFFF7237A1F4
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF7237BDAC
	internal HeaderInfo get_Item(String name) { }

	// RVA: 0xFFFFFFFF75B5BB3C
	public Void .ctor() { }

}

// Namespace: System.Net
internal enum CloseExState
{
	// Fields
	public Int32 value__; // 0x10
	public const CloseExState Normal = 0;
	public const CloseExState Abort = 1;
	public const CloseExState Silent = 2;
}

// Namespace: System.Net
internal interface ICloseEx
{
	// Methods

	// RVA: -1
	public abstract Void CloseEx(CloseExState closeState) { }

}

// Namespace: System.Net
internal class LazyAsyncResult
{
	// Fields
	private static ThreadContext t_ThreadContext; // 0xFFFFFFFFFFFFFFFF
	private Object m_AsyncObject; // 0x10
	private Object m_AsyncState; // 0x18
	private AsyncCallback m_AsyncCallback; // 0x20
	private Object m_Result; // 0x28
	private Int32 m_IntCompleted; // 0x30
	private Boolean m_UserEvent; // 0x34
	private Object m_Event; // 0x38

	// Properties
	private static ThreadContext CurrentThreadContext { get; }
	internal Object AsyncObject { get; }
	public Object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public Boolean CompletedSynchronously { get; }
	public Boolean IsCompleted { get; }
	internal Boolean InternalPeekCompleted { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B64BA4
	private static ThreadContext get_CurrentThreadContext() { }

	// RVA: 0xFFFFFFFF75B64C94
	internal Void .ctor(Object myObject, Object myState, AsyncCallback myCallBack) { }

	// RVA: 0xFFFFFFFF75B64D5C
	internal Object get_AsyncObject() { }

	// RVA: 0xFFFFFFFF75B64D64
	public Object get_AsyncState() { }

	// RVA: 0xFFFFFFFF75B64D6C
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0xFFFFFFFF75B64E04
	private Boolean LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	// RVA: 0xFFFFFFFF75B65014
	public Boolean get_CompletedSynchronously() { }

	// RVA: 0xFFFFFFFF75B6504C
	public Boolean get_IsCompleted() { }

	// RVA: 0xFFFFFFFF75B65004
	internal Boolean get_InternalPeekCompleted() { }

	// RVA: 0xFFFFFFFF75B65084
	protected Void ProtectedInvokeCallback(Object result, IntPtr userToken) { }

	// RVA: 0xFFFFFFFF75B65250
	internal Void InvokeCallback(Object result) { }

	// RVA: 0xFFFFFFFF75B65258
	protected virtual Void Complete(IntPtr userToken) { }

	// RVA: 0xFFFFFFFF75B65380
	private Void WorkerThreadComplete(Object state) { }

	// RVA: 0xFFFFFFFF75B653FC
	protected virtual Void Cleanup() { }

	// RVA: 0xFFFFFFFF75B65400
	internal Object InternalWaitForCompletion() { }

	// RVA: 0xFFFFFFFF75B65408
	private Object WaitForCompletion(Boolean snap) { }

}

// Namespace: 
private class ThreadContext
{
	// Fields
	internal Int32 m_NestedIOCount; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75B64C90
	public Void .ctor() { }

}

// Namespace: System.Net
internal class NetRes
{
	// Methods

	// RVA: 0xFFFFFFFF75B53310
	public static String GetWebStatusString(String Res, WebExceptionStatus Status) { }

	// RVA: 0xFFFFFFFF75B674FC
	public static String GetWebStatusString(WebExceptionStatus Status) { }

}

// Namespace: System.Net
internal class ScatterGatherBuffers
{
	// Fields
	private MemoryChunk headChunk; // 0x10
	private MemoryChunk currentChunk; // 0x18
	private Int32 nextChunkLength; // 0x20
	private Int32 totalLength; // 0x24
	private Int32 chunkCount; // 0x28

	// Properties
	private Boolean Empty { get; }
	internal Int32 Length { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B69F5C
	internal Void .ctor(Int64 totalSize) { }

	// RVA: 0xFFFFFFFF75B6A0A4
	internal BufferOffsetSize[] GetBuffers() { }

	// RVA: 0xFFFFFFFF75B6A1DC
	private Boolean get_Empty() { }

	// RVA: 0xFFFFFFFF75B6A1FC
	internal Int32 get_Length() { }

	// RVA: 0xFFFFFFFF75B6A204
	internal Void Write(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF75B69FB4
	private MemoryChunk AllocateMemoryChunk(Int32 newSize) { }

}

// Namespace: 
private class MemoryChunk
{
	// Fields
	internal Byte[] Buffer; // 0x10
	internal Int32 FreeOffset; // 0x18
	internal MemoryChunk Next; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75B6A330
	internal Void .ctor(Int32 bufferSize) { }

}

// Namespace: System.Net
internal static class TimerThread
{
	// Fields
	private static LinkedList<T0> s_Queues; // 0x0
	private static LinkedList<T0> s_NewQueues; // 0x8
	private static Int32 s_ThreadState; // 0x10
	private static AutoResetEvent s_ThreadReadyEvent; // 0x18
	private static ManualResetEvent s_ThreadShutdownEvent; // 0x20
	private static WaitHandle[] s_ThreadEvents; // 0x28
	private static Hashtable s_QueuesCache; // 0x30

	// Methods

	// RVA: 0xFFFFFFFF75B77790
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75B779B4
	internal static Queue CreateQueue(Int32 durationMilliseconds) { }

	// RVA: 0xFFFFFFFF75B77BDC
	private static Void StopTimerThread() { }

	// RVA: 0xFFFFFFFF75B77C64
	private static Void OnDomainUnload(Object sender, EventArgs e) { }

}

// Namespace: 
internal abstract class Queue
{
	// Fields
	private readonly Int32 m_DurationMilliseconds; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75B7823C
	internal Void .ctor(Int32 durationMilliseconds) { }

}

// Namespace: 
internal abstract class Timer
{
	// Fields
	private readonly Int32 m_StartTimeMilliseconds; // 0x10
	private readonly Int32 m_DurationMilliseconds; // 0x14

	// Methods

	// RVA: 0xFFFFFFFF75B78244
	internal Void .ctor(Int32 durationMilliseconds) { }

	// RVA: -1
	internal abstract Boolean Cancel() { }

	// RVA: 0xFFFFFFFF75B78270
	public Void Dispose() { }

}

// Namespace: 
internal sealed class Callback
{
	// Methods

	// RVA: 0xFFFFFFFF75B77D10
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B77D54
	public virtual Void Invoke(Timer timer, Int32 timeNoticed, Object context) { }

	// RVA: 0xFFFFFFFF75B78198
	public virtual IAsyncResult BeginInvoke(Timer timer, Int32 timeNoticed, Object context, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B78230
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private class TimerQueue
{
	// Fields
	private readonly TimerNode m_Timers; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75B77B38
	internal Void .ctor(Int32 durationMilliseconds) { }

}

// Namespace: 
private class InfiniteTimerQueue
{
	// Methods

	// RVA: 0xFFFFFFFF75B77B2C
	internal Void .ctor() { }

}

// Namespace: 
private class TimerNode
{
	// Fields
	private TimerState m_TimerState; // 0x18
	private Callback m_Callback; // 0x20
	private Object m_Context; // 0x28
	private Object m_QueueLock; // 0x30
	private TimerNode next; // 0x38
	private TimerNode prev; // 0x40

	// Properties
	internal TimerNode Next { get; set; }
	internal TimerNode Prev { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B78280
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75B782B4
	internal TimerNode get_Next() { }

	// RVA: 0xFFFFFFFF75B782BC
	internal Void set_Next(TimerNode value) { }

	// RVA: 0xFFFFFFFF75B782F4
	internal TimerNode get_Prev() { }

	// RVA: 0xFFFFFFFF75B782FC
	internal Void set_Prev(TimerNode value) { }

	// RVA: 0xFFFFFFFF75B78334
	internal override Boolean Cancel() { }

}

// Namespace: 
private enum TimerState
{
	// Fields
	public Int32 value__; // 0x10
	public const TimerState Ready = 0;
	public const TimerState Fired = 1;
	public const TimerState Cancelled = 2;
	public const TimerState Sentinel = 3;
}

// Namespace: System.Net
internal sealed class EmptyWebProxy
{
	// Fields
	private ICredentials m_credentials; // 0x10

	// Properties
	public ICredentials Credentials { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B4F770
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B4F774
	public Uri GetProxy(Uri uri) { }

	// RVA: 0xFFFFFFFF75B4F77C
	public Boolean IsBypassed(Uri uri) { }

	// RVA: 0xFFFFFFFF75B4F784
	public ICredentials get_Credentials() { }

}

// Namespace: System.Net
internal enum CookieVariant
{
	// Fields
	public Int32 value__; // 0x10
	public const CookieVariant Unknown = 0;
	public const CookieVariant Plain = 1;
	public const CookieVariant Rfc2109 = 2;
	public const CookieVariant Rfc2965 = 3;
	public const CookieVariant Default = 2;
}

// Namespace: System.Net
public sealed class Cookie
{
	// Fields
	internal static readonly Char[] PortSplitDelimiters; // 0x0
	internal static readonly Char[] Reserved2Name; // 0x8
	internal static readonly Char[] Reserved2Value; // 0x10
	private static Comparer staticComparer; // 0x18
	private String m_comment; // 0x10
	private Uri m_commentUri; // 0x18
	private CookieVariant m_cookieVariant; // 0x20
	private Boolean m_discard; // 0x24
	private String m_domain; // 0x28
	private Boolean m_domain_implicit; // 0x30
	private DateTime m_expires; // 0x38
	private String m_name; // 0x40
	private String m_path; // 0x48
	private Boolean m_path_implicit; // 0x50
	private String m_port; // 0x58
	private Boolean m_port_implicit; // 0x60
	private Int32[] m_port_list; // 0x68
	private Boolean m_secure; // 0x70
	private Boolean m_httpOnly; // 0x71
	private DateTime m_timeStamp; // 0x78
	private String m_value; // 0x80
	private Int32 m_version; // 0x88
	private String m_domainKey; // 0x90
	internal Boolean IsQuotedVersion; // 0x98
	internal Boolean IsQuotedDomain; // 0x99

	// Properties
	public String Comment { get; set; }
	public Uri CommentUri { set; }
	public Boolean HttpOnly { set; }
	public Boolean Discard { set; }
	public String Domain { get; set; }
	private String _Domain { get; }
	public Boolean Expired { get; }
	public DateTime Expires { set; }
	public String Name { get; }
	public String Path { get; set; }
	private String _Path { get; }
	internal Boolean Plain { get; }
	public String Port { set; }
	internal Int32[] PortList { get; }
	private String _Port { get; }
	public Boolean Secure { get; set; }
	public String Value { get; set; }
	internal CookieVariant Variant { get; }
	internal String DomainKey { get; }
	public Int32 Version { get; set; }
	private String _Version { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B44CE8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B44E78
	public String get_Comment() { }

	// RVA: 0xFFFFFFFF75B44E80
	public Void set_Comment(String value) { }

	// RVA: 0xFFFFFFFF75B44ECC
	public Void set_CommentUri(Uri value) { }

	// RVA: 0xFFFFFFFF75B44F04
	public Void set_HttpOnly(Boolean value) { }

	// RVA: 0xFFFFFFFF75B44F0C
	public Void set_Discard(Boolean value) { }

	// RVA: 0xFFFFFFFF75B44F14
	public String get_Domain() { }

	// RVA: 0xFFFFFFFF75B44F1C
	public Void set_Domain(String value) { }

	// RVA: 0xFFFFFFFF75B44FA8
	private String get__Domain() { }

	// RVA: 0xFFFFFFFF75B45078
	public Boolean get_Expired() { }

	// RVA: 0xFFFFFFFF75B4510C
	public Void set_Expires(DateTime value) { }

	// RVA: 0xFFFFFFFF75B45114
	public String get_Name() { }

	// RVA: 0xFFFFFFFF75B4511C
	internal Boolean InternalSetName(String value) { }

	// RVA: 0xFFFFFFFF75B45240
	public String get_Path() { }

	// RVA: 0xFFFFFFFF75B45248
	public Void set_Path(String value) { }

	// RVA: 0xFFFFFFFF75B452A0
	private String get__Path() { }

	// RVA: 0xFFFFFFFF75B45068
	internal Boolean get_Plain() { }

	// RVA: 0xFFFFFFFF75B4532C
	private static Boolean IsDomainEqualToHost(String domain, String host) { }

	// RVA: 0xFFFFFFFF75B45390
	internal Boolean VerifySetDefaults(CookieVariant variant, Uri uri, Boolean isLocalDomain, String localDomain, Boolean set_default, Boolean isThrow) { }

	// RVA: 0xFFFFFFFF75B45BD4
	private static Boolean DomainCharsTest(String name) { }

	// RVA: 0xFFFFFFFF75B45D0C
	public Void set_Port(String value) { }

	// RVA: 0xFFFFFFFF75B46008
	internal Int32[] get_PortList() { }

	// RVA: 0xFFFFFFFF75B46010
	private String get__Port() { }

	// RVA: 0xFFFFFFFF75B460BC
	public Boolean get_Secure() { }

	// RVA: 0xFFFFFFFF75B460C4
	public Void set_Secure(Boolean value) { }

	// RVA: 0xFFFFFFFF75B460CC
	public String get_Value() { }

	// RVA: 0xFFFFFFFF75B460D4
	public Void set_Value(String value) { }

	// RVA: 0xFFFFFFFF75B46128
	internal CookieVariant get_Variant() { }

	// RVA: 0xFFFFFFFF75B46130
	internal String get_DomainKey() { }

	// RVA: 0xFFFFFFFF75B4614C
	public Int32 get_Version() { }

	// RVA: 0xFFFFFFFF75B46154
	public Void set_Version(Int32 value) { }

	// RVA: 0xFFFFFFFF75B461EC
	private String get__Version() { }

	// RVA: 0xFFFFFFFF75B462E0
	internal static IComparer GetComparer() { }

	// RVA: 0xFFFFFFFF75B46350
	public override Boolean Equals(Object comparand) { }

	// RVA: 0xFFFFFFFF75B46438
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75B465FC
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75B468C0
	private static Void .cctor() { }

}

// Namespace: System.Net
internal enum CookieToken
{
	// Fields
	public Int32 value__; // 0x10
	public const CookieToken Nothing = 0;
	public const CookieToken NameValuePair = 1;
	public const CookieToken Attribute = 2;
	public const CookieToken EndToken = 3;
	public const CookieToken EndCookie = 4;
	public const CookieToken End = 5;
	public const CookieToken Equals = 6;
	public const CookieToken Comment = 7;
	public const CookieToken CommentUrl = 8;
	public const CookieToken CookieName = 9;
	public const CookieToken Discard = 10;
	public const CookieToken Domain = 11;
	public const CookieToken Expires = 12;
	public const CookieToken MaxAge = 13;
	public const CookieToken Path = 14;
	public const CookieToken Port = 15;
	public const CookieToken Secure = 16;
	public const CookieToken HttpOnly = 17;
	public const CookieToken Unknown = 18;
	public const CookieToken Version = 19;
}

// Namespace: System.Net
internal class CookieTokenizer
{
	// Fields
	private Boolean m_eofCookie; // 0x10
	private Int32 m_index; // 0x14
	private Int32 m_length; // 0x18
	private String m_name; // 0x20
	private Boolean m_quoted; // 0x28
	private Int32 m_start; // 0x2C
	private CookieToken m_token; // 0x30
	private Int32 m_tokenLength; // 0x34
	private String m_tokenStream; // 0x38
	private String m_value; // 0x40
	private static RecognizedAttribute[] RecognizedAttributes; // 0x0
	private static RecognizedAttribute[] RecognizedServerAttributes; // 0x8

	// Properties
	internal Boolean EndOfCookie { get; set; }
	internal Boolean Eof { get; }
	internal String Name { get; set; }
	internal Boolean Quoted { get; set; }
	internal CookieToken Token { get; set; }
	internal String Value { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B4B9C8
	internal Void .ctor(String tokenStream) { }

	// RVA: 0xFFFFFFFF75B4BBDC
	internal Boolean get_EndOfCookie() { }

	// RVA: 0xFFFFFFFF75B4BBE4
	internal Void set_EndOfCookie(Boolean value) { }

	// RVA: 0xFFFFFFFF75B4BBCC
	internal Boolean get_Eof() { }

	// RVA: 0xFFFFFFFF75B4BBEC
	internal String get_Name() { }

	// RVA: 0xFFFFFFFF75B4BBF4
	internal Void set_Name(String value) { }

	// RVA: 0xFFFFFFFF75B4BC2C
	internal Boolean get_Quoted() { }

	// RVA: 0xFFFFFFFF75B4BC34
	internal Void set_Quoted(Boolean value) { }

	// RVA: 0xFFFFFFFF75B4BC3C
	internal CookieToken get_Token() { }

	// RVA: 0xFFFFFFFF75B4BC44
	internal Void set_Token(CookieToken value) { }

	// RVA: 0xFFFFFFFF75B4BC4C
	internal String get_Value() { }

	// RVA: 0xFFFFFFFF75B4BC54
	internal Void set_Value(String value) { }

	// RVA: 0xFFFFFFFF75B4BC8C
	internal String Extract() { }

	// RVA: 0xFFFFFFFF75B4BCF8
	internal CookieToken FindNext(Boolean ignoreComma, Boolean ignoreEquals) { }

	// RVA: 0xFFFFFFFF75B4BA10
	internal CookieToken Next(Boolean first, Boolean parseResponseCookies) { }

	// RVA: 0xFFFFFFFF75B4BF48
	internal Void Reset() { }

	// RVA: 0xFFFFFFFF75B4BFD8
	internal CookieToken TokenFromName(Boolean parseResponseCookies) { }

	// RVA: 0xFFFFFFFF75B4C1D8
	private static Void .cctor() { }

}

// Namespace: 
private struct RecognizedAttribute
{
	// Fields
	private String m_name; // 0x10
	private CookieToken m_token; // 0x18

	// Properties
	internal CookieToken Token { get; }

	// Methods

	// RVA: 0xFFFFFFFF711479D4
	internal Void .ctor(String name, CookieToken token) { }

	// RVA: 0xFFFFFFFF71147A1C
	internal CookieToken get_Token() { }

	// RVA: 0xFFFFFFFF71147A24
	internal Boolean IsEqualTo(String value) { }

}

// Namespace: System.Net
internal class CookieParser
{
	// Fields
	private CookieTokenizer m_tokenizer; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75B4A240
	internal Void .ctor(String cookieString) { }

	// RVA: 0xFFFFFFFF75B4A2D0
	internal Cookie Get() { }

	// RVA: 0xFFFFFFFF75B45C70
	internal static String CheckQuoted(String value) { }

}

// Namespace: System.Net
internal class Comparer
{
	// Methods

	// RVA: 0xFFFFFFFF75B43F7C
	private Int32 System.Collections.IComparer.Compare(Object ol, Object or) { }

	// RVA: 0xFFFFFFFF75B44070
	public Void .ctor() { }

}

// Namespace: System.Net
public class CookieCollection
{
	// Fields
	internal Int32 m_version; // 0x10
	private ArrayList m_list; // 0x18
	private DateTime m_TimeStamp; // 0x20
	private Boolean m_has_other_versions; // 0x28
	private Boolean m_IsReadOnly; // 0x29

	// Properties
	public Cookie Item { get; }
	public Int32 Count { get; }
	public Boolean IsSynchronized { get; }
	public Object SyncRoot { get; }
	internal Boolean IsOtherVersionSeen { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B46A44
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B46AD0
	public Cookie get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF75B46BC0
	public Void Add(Cookie cookie) { }

	// RVA: 0xFFFFFFFF75B47068
	public Void Add(CookieCollection cookies) { }

	// RVA: 0xFFFFFFFF75B47348
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75B47370
	public Boolean get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75B47378
	public Object get_SyncRoot() { }

	// RVA: 0xFFFFFFFF75B4737C
	public Void CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF75B473A4
	internal DateTime TimeStamp(Stamp how) { }

	// RVA: 0xFFFFFFFF75B47460
	internal Boolean get_IsOtherVersionSeen() { }

	// RVA: 0xFFFFFFFF75B47468
	internal Int32 InternalAdd(Cookie cookie, Boolean isStrict) { }

	// RVA: 0xFFFFFFFF75B46CAC
	internal Int32 IndexOf(Cookie cookie) { }

	// RVA: 0xFFFFFFFF75B47888
	internal Void RemoveAt(Int32 idx) { }

	// RVA: 0xFFFFFFFF75B472D8
	public IEnumerator GetEnumerator() { }

}

// Namespace: 
internal enum Stamp
{
	// Fields
	public Int32 value__; // 0x10
	public const Stamp Check = 0;
	public const Stamp Set = 1;
	public const Stamp SetToUnused = 2;
	public const Stamp SetToMaxUsed = 3;
}

// Namespace: 
private class CookieCollectionEnumerator
{
	// Fields
	private CookieCollection m_cookies; // 0x10
	private Int32 m_count; // 0x18
	private Int32 m_index; // 0x1C
	private Int32 m_version; // 0x20

	// Properties
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B478B0
	internal Void .ctor(CookieCollection cookies) { }

	// RVA: 0xFFFFFFFF75B47928
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xFFFFFFFF75B479E0
	private Boolean System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0xFFFFFFFF75B47A90
	private Void System.Collections.IEnumerator.Reset() { }

}

// Namespace: System.Net
internal struct HeaderVariantInfo
{
	// Fields
	private String m_name; // 0x10
	private CookieVariant m_variant; // 0x18

	// Properties
	internal String Name { get; }
	internal CookieVariant Variant { get; }

	// Methods

	// RVA: 0xFFFFFFFF71147BFC
	internal Void .ctor(String name, CookieVariant variant) { }

	// RVA: 0xFFFFFFFF71147C44
	internal String get_Name() { }

	// RVA: 0xFFFFFFFF71147C4C
	internal CookieVariant get_Variant() { }

}

// Namespace: System.Net
public class CookieContainer
{
	// Fields
	private static readonly HeaderVariantInfo[] HeaderInfo; // 0x0
	private Hashtable m_domainTable; // 0x10
	private Int32 m_maxCookieSize; // 0x18
	private Int32 m_maxCookies; // 0x1C
	private Int32 m_maxCookiesPerDomain; // 0x20
	private Int32 m_count; // 0x24
	private String m_fqdnMyDomain; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75B47A9C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B47B94
	private Void AddRemoveDomain(String key, PathList value) { }

	// RVA: 0xFFFFFFFF75B47C78
	internal Void Add(Cookie cookie, Boolean throwOnError) { }

	// RVA: 0xFFFFFFFF75B48430
	private Boolean AgeCookies(String domain) { }

	// RVA: 0xFFFFFFFF75B49600
	private Int32 ExpireCollection(CookieCollection cc) { }

	// RVA: 0xFFFFFFFF75B49758
	internal Boolean IsLocalDomain(String host) { }

	// RVA: 0xFFFFFFFF75B49BE0
	internal CookieCollection CookieCutter(Uri uri, String headerName, String setCookieHeader, Boolean isThrow) { }

	// RVA: 0xFFFFFFFF75B4A82C
	internal CookieCollection InternalGetCookies(Uri uri) { }

	// RVA: 0xFFFFFFFF75B4AAFC
	private Void BuildCookieCollectionFromDomainMatches(Uri uri, Boolean isSecure, Int32 port, CookieCollection cookies, List<T0> domainAttribute, Boolean matchOnlyPlainCookie) { }

	// RVA: 0xFFFFFFFF75B4B2B0
	private Void MergeUpdateCollections(CookieCollection destination, CookieCollection source, Int32 port, Boolean isSecure, Boolean isPlainOnly) { }

	// RVA: 0xFFFFFFFF75B4B498
	public String GetCookieHeader(Uri uri) { }

	// RVA: 0xFFFFFFFF75B4B568
	internal String GetCookieHeader(Uri uri, out String optCookie2) { }

	// RVA: 0xFFFFFFFF75B4B884
	private static Void .cctor() { }

}

// Namespace: System.Net
internal class PathList
{
	// Fields
	private SortedList m_list; // 0x10

	// Properties
	public Int32 Count { get; }
	public ICollection Values { get; }
	public Object Item { get; set; }
	public Object SyncRoot { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B69798
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B69874
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75B6989C
	public Int32 GetCookiesCount() { }

	// RVA: 0xFFFFFFFF75B69C38
	public ICollection get_Values() { }

	// RVA: 0xFFFFFFFF75B69C60
	public Object get_Item(String s) { }

	// RVA: 0xFFFFFFFF75B69C88
	public Void set_Item(String s, Object value) { }

	// RVA: 0xFFFFFFFF75B69D5C
	public IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B69C10
	public Object get_SyncRoot() { }

}

// Namespace: 
private class PathListComparer
{
	// Fields
	internal static readonly PathListComparer StaticInstance; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75B69D84
	private Int32 System.Collections.IComparer.Compare(Object ol, Object or) { }

	// RVA: 0xFFFFFFFF75B69EC8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B69ECC
	private static Void .cctor() { }

}

// Namespace: System.Net
public class CookieException
{
	// Methods

	// RVA: 0xFFFFFFFF75B4B9A8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B45BCC
	internal Void .ctor(String message) { }

	// RVA: 0xFFFFFFFF75B495F8
	internal Void .ctor(String message, Exception inner) { }

	// RVA: 0xFFFFFFFF75B4B9B0
	protected Void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B4B9B8
	private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B4B9C0
	public override Void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

// Namespace: System.Net
public class FileWebRequest
{
	// Fields
	private static WaitCallback s_GetRequestStreamCallback; // 0x0
	private static WaitCallback s_GetResponseCallback; // 0x8
	private String m_connectionGroupName; // 0x38
	private Int64 m_contentLength; // 0x40
	private ICredentials m_credentials; // 0x48
	private FileAccess m_fileAccess; // 0x50
	private WebHeaderCollection m_headers; // 0x58
	private String m_method; // 0x60
	private IWebProxy m_proxy; // 0x68
	private ManualResetEvent m_readerEvent; // 0x70
	private Boolean m_readPending; // 0x78
	private WebResponse m_response; // 0x80
	private Stream m_stream; // 0x88
	private Boolean m_syncHint; // 0x90
	private Int32 m_timeout; // 0x94
	private Uri m_uri; // 0x98
	private Boolean m_writePending; // 0xA0
	private Boolean m_writing; // 0xA1
	private LazyAsyncResult m_WriteAResult; // 0xA8
	private LazyAsyncResult m_ReadAResult; // 0xB0
	private Int32 m_Aborted; // 0xB8

	// Properties
	internal Boolean Aborted { get; }
	public override Int64 ContentLength { get; set; }
	public override String ContentType { get; set; }
	public override ICredentials Credentials { get; set; }
	public override WebHeaderCollection Headers { get; }
	public override String Method { get; set; }
	public override IWebProxy Proxy { get; set; }
	public override Int32 Timeout { get; set; }
	public override Uri RequestUri { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B4F998
	internal Void .ctor(Uri uri) { }

	// RVA: 0xFFFFFFFF75B4FB1C
	protected Void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B4FE70
	private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B4FE80
	protected override Void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B500D0
	internal Boolean get_Aborted() { }

	// RVA: 0xFFFFFFFF75B500E0
	public override Int64 get_ContentLength() { }

	// RVA: 0xFFFFFFFF75B500E8
	public override Void set_ContentLength(Int64 value) { }

	// RVA: 0xFFFFFFFF75B5018C
	public override String get_ContentType() { }

	// RVA: 0xFFFFFFFF75B501B4
	public override Void set_ContentType(String value) { }

	// RVA: 0xFFFFFFFF75B501E0
	public override ICredentials get_Credentials() { }

	// RVA: 0xFFFFFFFF75B501E8
	public override Void set_Credentials(ICredentials value) { }

	// RVA: 0xFFFFFFFF75B50220
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0xFFFFFFFF75B50228
	public override String get_Method() { }

	// RVA: 0xFFFFFFFF75B50230
	public override Void set_Method(String value) { }

	// RVA: 0xFFFFFFFF75B50318
	public override IWebProxy get_Proxy() { }

	// RVA: 0xFFFFFFFF75B50320
	public override Void set_Proxy(IWebProxy value) { }

	// RVA: 0xFFFFFFFF75B50358
	public override Int32 get_Timeout() { }

	// RVA: 0xFFFFFFFF75B50360
	public override Void set_Timeout(Int32 value) { }

	// RVA: 0xFFFFFFFF75B50408
	public override Uri get_RequestUri() { }

	// RVA: 0xFFFFFFFF75B50410
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75B50844
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75B507B0
	private Boolean CanGetRequestStream() { }

	// RVA: 0xFFFFFFFF75B50B18
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B50D94
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B51034
	public override Stream GetRequestStream() { }

	// RVA: 0xFFFFFFFF75B51384
	public override WebResponse GetResponse() { }

	// RVA: 0xFFFFFFFF75B516DC
	private static Void GetRequestStreamCallback(Object state) { }

	// RVA: 0xFFFFFFFF75B5193C
	private static Void GetResponseCallback(Object state) { }

	// RVA: 0xFFFFFFFF75B51C50
	internal Void UnblockReader() { }

	// RVA: 0xFFFFFFFF723792FC
	public override Void Abort() { }

	// RVA: 0xFFFFFFFF75B51CE8
	private static Void .cctor() { }

}

// Namespace: System.Net
internal class FileWebRequestCreator
{
	// Methods

	// RVA: 0xFFFFFFFF75B51DE0
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75B51DE4
	public WebRequest Create(Uri uri) { }

}

// Namespace: System.Net
internal sealed class FileWebStream
{
	// Fields
	private FileWebRequest m_request; // 0x70

	// Methods

	// RVA: 0xFFFFFFFF75B52944
	public Void .ctor(FileWebRequest request, String path, FileMode mode, FileAccess access, FileShare sharing) { }

	// RVA: 0xFFFFFFFF75B52168
	public Void .ctor(FileWebRequest request, String path, FileMode mode, FileAccess access, FileShare sharing, Int32 length, Boolean async) { }

	// RVA: 0xFFFFFFFF75B529E0
	protected override Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75B52A64
	private Void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0xFFFFFFFF75B52AA4
	public override Int32 Read(Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75B52CC0
	public override Void Write(Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75B52E38
	public override IAsyncResult BeginRead(Byte[] buffer, Int32 offset, Int32 size, AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75B52FC8
	public override Int32 EndRead(IAsyncResult ar) { }

	// RVA: 0xFFFFFFFF75B530A4
	public override IAsyncResult BeginWrite(Byte[] buffer, Int32 offset, Int32 size, AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75B53234
	public override Void EndWrite(IAsyncResult ar) { }

	// RVA: 0xFFFFFFFF75B52C1C
	private Void CheckError() { }

}

// Namespace: System.Net
public class FileWebResponse
{
	// Fields
	private Boolean m_closed; // 0x18
	private Int64 m_contentLength; // 0x20
	private FileAccess m_fileAccess; // 0x28
	private WebHeaderCollection m_headers; // 0x30
	private Stream m_stream; // 0x38
	private Uri m_uri; // 0x40

	// Properties
	public override Int64 ContentLength { get; }
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B51E58
	internal Void .ctor(FileWebRequest request, Uri uri, FileAccess access, Boolean asyncHint) { }

	// RVA: 0xFFFFFFFF75B52220
	protected Void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B52418
	private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B52428
	protected override Void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B525AC
	public override Int64 get_ContentLength() { }

	// RVA: 0xFFFFFFFF75B5266C
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0xFFFFFFFF75B52690
	public override Uri get_ResponseUri() { }

	// RVA: 0xFFFFFFFF75B525D0
	private Void CheckDisposed() { }

	// RVA: 0xFFFFFFFF75B526B4
	public override Void Close() { }

	// RVA: 0xFFFFFFFF75B52768
	private Void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0xFFFFFFFF75B528F8
	public override Stream GetResponseStream() { }

}

// Namespace: System.Net
public interface IWebProxy
{
	// Properties
	public abstract ICredentials Credentials { get; }

	// Methods

	// RVA: -1
	public abstract Uri GetProxy(Uri destination) { }

	// RVA: -1
	public abstract Boolean IsBypassed(Uri host) { }

	// RVA: -1
	public abstract ICredentials get_Credentials() { }

}

// Namespace: System.Net
public class WebClient
{
	// Fields
	private Uri m_baseAddress; // 0x28
	private ICredentials m_credentials; // 0x30
	private WebHeaderCollection m_headers; // 0x38
	private NameValueCollection m_requestParameters; // 0x40
	private WebResponse m_WebResponse; // 0x48
	private WebRequest m_WebRequest; // 0x50
	private Encoding m_Encoding; // 0x58
	private String m_Method; // 0x60
	private Int64 m_ContentLength; // 0x68
	private Boolean m_Cancelled; // 0x70
	private ProgressData m_Progress; // 0x78
	private IWebProxy m_Proxy; // 0x80
	private Boolean m_ProxySet; // 0x88
	private RequestCachePolicy m_CachePolicy; // 0x90
	private Int32 m_CallNesting; // 0x98
	private SendOrPostCallback reportDownloadProgressChanged; // 0xA0
	private SendOrPostCallback reportUploadProgressChanged; // 0xA8

	// Properties
	public Encoding Encoding { get; }
	public ICredentials Credentials { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B7951C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B7964C
	private Void ClearWebClientState() { }

	// RVA: 0xFFFFFFFF75B79768
	private Void CompleteWebClientState() { }

	// RVA: 0xFFFFFFFF75B79788
	public Encoding get_Encoding() { }

	// RVA: 0xFFFFFFFF75B79790
	public ICredentials get_Credentials() { }

	// RVA: 0xFFFFFFFF75B79798
	protected virtual WebRequest GetWebRequest(Uri address) { }

	// RVA: 0xFFFFFFFF75B79D8C
	protected virtual WebResponse GetWebResponse(WebRequest request) { }

	// RVA: 0xFFFFFFFF75B79DE8
	protected virtual WebResponse GetWebResponse(WebRequest request, IAsyncResult result) { }

	// RVA: 0xFFFFFFFF75B79E48
	private Byte[] DownloadDataInternal(Uri address, out WebRequest request) { }

	// RVA: 0xFFFFFFFF75B7A680
	public String DownloadString(String address) { }

	// RVA: 0xFFFFFFFF75B7A804
	public String DownloadString(Uri address) { }

	// RVA: 0xFFFFFFFF75B7A550
	private static Void AbortRequest(WebRequest request) { }

	// RVA: 0xFFFFFFFF75B79970
	private Void CopyHeadersTo(WebRequest request) { }

	// RVA: 0xFFFFFFFF75B7A710
	private Uri GetUri(String path) { }

	// RVA: 0xFFFFFFFF75B7A08C
	private Uri GetUri(Uri address) { }

	// RVA: 0xFFFFFFFF75B7AE98
	private static Void DownloadBitsResponseCallback(IAsyncResult result) { }

	// RVA: 0xFFFFFFFF75B7B508
	private static Void DownloadBitsReadCallback(IAsyncResult result) { }

	// RVA: 0xFFFFFFFF75B7B608
	private static Void DownloadBitsReadCallbackState(DownloadBitsState state, IAsyncResult result) { }

	// RVA: 0xFFFFFFFF75B7A3A8
	private Byte[] DownloadBits(WebRequest request, Stream writeStream, CompletionDelegate completionDelegate, AsyncOperation asyncOp) { }

	// RVA: 0xFFFFFFFF75B7BD4C
	private Boolean ByteArrayHasPrefix(Byte[] prefix, Byte[] byteArray) { }

	// RVA: 0xFFFFFFFF75B7A930
	private String GetStringUsingEncoding(WebRequest request, Byte[] data) { }

	// RVA: 0xFFFFFFFF75B7975C
	private Boolean AnotherCallInProgress(Int32 callNesting) { }

	// RVA: 0xFFFFFFFF75B7BDD8
	private Void PostProgressChanged(AsyncOperation asyncOp, ProgressData progress) { }

}

// Namespace: 
private class ProgressData
{
	// Fields
	internal Int64 BytesSent; // 0x10
	internal Int64 TotalBytesToSend; // 0x18
	internal Int64 BytesReceived; // 0x20
	internal Int64 TotalBytesToReceive; // 0x28
	internal Boolean HasUploadPhase; // 0x30

	// Methods

	// RVA: 0xFFFFFFFF75B79774
	internal Void Reset() { }

}

// Namespace: 
private class DownloadBitsState
{
	// Fields
	internal WebClient WebClient; // 0x10
	internal Stream WriteStream; // 0x18
	internal Byte[] InnerBuffer; // 0x20
	internal AsyncOperation AsyncOp; // 0x28
	internal WebRequest Request; // 0x30
	internal CompletionDelegate CompletionDelegate; // 0x38
	internal Stream ReadStream; // 0x40
	internal ScatterGatherBuffers SgBuffers; // 0x48
	internal Int64 ContentLength; // 0x50
	internal Int64 Length; // 0x58
	internal ProgressData Progress; // 0x60

	// Properties
	internal Boolean Async { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B7BC40
	internal Void .ctor(WebRequest request, Stream writeStream, CompletionDelegate completionDelegate, AsyncOperation asyncOp, ProgressData progress, WebClient webClient) { }

	// RVA: 0xFFFFFFFF75B7BD3C
	internal Boolean get_Async() { }

	// RVA: 0xFFFFFFFF75B7B200
	internal Int32 SetResponse(WebResponse response) { }

	// RVA: 0xFFFFFFFF75B7B968
	internal Boolean RetrieveBytes(ref Int32 bytesRetrieved) { }

	// RVA: 0xFFFFFFFF75B7BBEC
	internal Void Close() { }

}

// Namespace: System.Net
internal sealed class CompletionDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75B44074
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B440B8
	public virtual Void Invoke(Byte[] responseBytes, Exception exception, Object State) { }

	// RVA: 0xFFFFFFFF75B444A4
	public virtual IAsyncResult BeginInvoke(Byte[] responseBytes, Exception exception, Object State, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B44500
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Net
public class DownloadProgressChangedEventArgs
{
	// Fields
	private Int64 m_BytesReceived; // 0x20
	private Int64 m_TotalBytesToReceive; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75B4F738
	internal Void .ctor(Int32 progressPercentage, Object userToken, Int64 bytesReceived, Int64 totalBytesToReceive) { }

}

// Namespace: System.Net
public class UploadProgressChangedEventArgs
{
	// Fields
	private Int64 m_BytesReceived; // 0x20
	private Int64 m_TotalBytesToReceive; // 0x28
	private Int64 m_BytesSent; // 0x30
	private Int64 m_TotalBytesToSend; // 0x38

	// Methods

	// RVA: 0xFFFFFFFF75B79258
	internal Void .ctor(Int32 progressPercentage, Object userToken, Int64 bytesSent, Int64 totalBytesToSend, Int64 bytesReceived, Int64 totalBytesToReceive) { }

}

// Namespace: System.Net
public class WebProxy
{
	// Fields
	private Boolean _UseRegistry; // 0x10
	private Boolean _BypassOnLocal; // 0x11
	private Boolean m_EnableAutoproxy; // 0x12
	private Uri _ProxyAddress; // 0x18
	private ArrayList _BypassList; // 0x20
	private ICredentials _Credentials; // 0x28
	private Regex[] _RegExBypassList; // 0x30
	private Hashtable _ProxyHostAddresses; // 0x38
	private AutoWebProxyScriptEngine m_ScriptEngine; // 0x40

	// Properties
	public ICredentials Credentials { get; }
	public Boolean UseDefaultCredentials { get; set; }
	internal AutoWebProxyScriptEngine ScriptEngine { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B8469C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B846FC
	public Void .ctor(Uri Address, Boolean BypassOnLocal, String[] BypassList, ICredentials Credentials) { }

	// RVA: 0xFFFFFFFF75B84A28
	public ICredentials get_Credentials() { }

	// RVA: 0xFFFFFFFF75B84A30
	public Boolean get_UseDefaultCredentials() { }

	// RVA: 0xFFFFFFFF75B84AC4
	public Void set_UseDefaultCredentials(Boolean value) { }

	// RVA: 0xFFFFFFFF75B84B78
	public Uri GetProxy(Uri destination) { }

	// RVA: 0xFFFFFFFF75B847C4
	private Void UpdateRegExList(Boolean canThrow) { }

	// RVA: 0xFFFFFFFF75B84F68
	private Boolean IsMatchInBypassList(Uri input) { }

	// RVA: 0xFFFFFFFF75B850C4
	private Boolean IsLocal(Uri host) { }

	// RVA: 0xFFFFFFFF75B851E4
	private Boolean IsLocalInProxyHash(Uri host) { }

	// RVA: 0xFFFFFFFF75B852B0
	public Boolean IsBypassed(Uri host) { }

	// RVA: 0xFFFFFFFF75B84EA8
	private Boolean IsBypassedManual(Uri host) { }

	// RVA: 0xFFFFFFFF75B8543C
	protected Void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B85730
	private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B85740
	protected virtual Void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B85854
	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	// RVA: 0xFFFFFFFF75B8585C
	public static IWebProxy CreateDefaultProxy() { }

	// RVA: 0xFFFFFFFF75B858B0
	internal Void .ctor(Boolean enableAutoproxy) { }

	// RVA: 0xFFFFFFFF75B85724
	internal Void UnsafeUpdateFromRegistry() { }

	// RVA: 0xFFFFFFFF75B84CE8
	private Boolean GetProxyAuto(Uri destination, out Uri proxyUri) { }

	// RVA: 0xFFFFFFFF75B8536C
	private Boolean IsBypassedAuto(Uri destination, out Boolean isBypassed) { }

	// RVA: 0xFFFFFFFF75B858C0
	private static Boolean AreAllBypassed(IEnumerable<T0> proxies, Boolean checkFirstOnly) { }

	// RVA: 0xFFFFFFFF75B85AF0
	private static Uri ProxyUri(String proxyName) { }

}

// Namespace: System.Net
internal class AutoWebProxyScriptEngine
{
	// Methods

	// RVA: 0xFFFFFFFF75B431C8
	public Boolean GetProxies(Uri destination, out IList<T0> proxyList) { }

	// RVA: 0xFFFFFFFF75B43200
	public Boolean GetProxies(Uri destination, out IList<T0> proxyList, ref Int32 syncStatus) { }

}

// Namespace: System.Net
internal static class UnsafeNclNativeMethods
{}

// Namespace: 
internal static class HttpApi
{
	// Fields
	private static String[] m_Strings; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75B78534
	private static Void .cctor() { }

}

// Namespace: 
internal static class HTTP_REQUEST_HEADER_ID
{
	// Fields
	private static String[] m_Strings; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75B789F4
	internal static String ToString(Int32 position) { }

	// RVA: 0xFFFFFFFF75B78A98
	private static Void .cctor() { }

}

// Namespace: 
internal static class SecureStringHelper
{
	// Methods

	// RVA: 0xFFFFFFFF75B790C4
	internal static String CreateString(SecureString secureString) { }

	// RVA: 0xFFFFFFFF75B791B8
	internal static SecureString CreateSecureString(String plainString) { }

}

// Namespace: System.Net
internal static class Logging
{
	// Fields
	internal static readonly Boolean On; // 0x0
}

// Namespace: System.Net
internal class ServerCertValidationCallback
{
	// Fields
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
	private readonly ExecutionContext m_Context; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75B6C1E8
	internal Void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	// RVA: 0xFFFFFFFF75B6C260
	internal Void Callback(Object state) { }

	// RVA: 0xFFFFFFFF75B6C314
	internal Boolean Invoke(Object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

// Namespace: 
private class CallbackContext
{
	// Fields
	internal readonly Object request; // 0x10
	internal readonly X509Certificate certificate; // 0x18
	internal readonly X509Chain chain; // 0x20
	internal readonly SslPolicyErrors sslPolicyErrors; // 0x28
	internal Boolean result; // 0x2C

	// Methods

	// RVA: 0xFFFFFFFF75B6C458
	internal Void .ctor(Object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

// Namespace: System.Net
public class AuthenticationManager
{
	// Fields
	private static ArrayList modules; // 0x0
	private static Object locker; // 0x8
	private static ICredentialPolicy credential_policy; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75B42340
	private static Void EnsureModules() { }

	// RVA: 0xFFFFFFFF75B42584
	public static Authorization Authenticate(String challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0xFFFFFFFF75B426B4
	private static Authorization DoAuthenticate(String challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0xFFFFFFFF75B42B4C
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0xFFFFFFFF75B4303C
	private static Void .cctor() { }

}

// Namespace: System.Net
internal class BasicClient
{
	// Properties
	public String AuthenticationType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B43238
	public Authorization Authenticate(String challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xFFFFFFFF75B435D8
	private static Byte[] GetBytes(String str) { }

	// RVA: 0xFFFFFFFF75B432E4
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xFFFFFFFF75B43668
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xFFFFFFFF75B43674
	public String get_AuthenticationType() { }

	// RVA: 0xFFFFFFFF75B42580
	public Void .ctor() { }

}

// Namespace: System.Net
public sealed class BindIPEndPoint
{
	// Methods

	// RVA: 0xFFFFFFFF75B436B4
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B436F8
	public virtual IPEndPoint Invoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, Int32 retryCount) { }

	// RVA: 0xFFFFFFFF75B43AF8
	public virtual IAsyncResult BeginInvoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, Int32 retryCount, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B43B8C
	public virtual IPEndPoint EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Net
public enum DecompressionMethods
{
	// Fields
	public Int32 value__; // 0x10
	public const DecompressionMethods None = 0;
	public const DecompressionMethods GZip = 1;
	public const DecompressionMethods Deflate = 2;
}

// Namespace: System.Net
internal class DefaultCertificatePolicy
{}

// Namespace: System.Net
internal class DigestHeaderParser
{
	// Fields
	private String header; // 0x10
	private Int32 length; // 0x18
	private Int32 pos; // 0x1C
	private static String[] keywords; // 0x0
	private String[] values; // 0x20

	// Properties
	public String Realm { get; }
	public String Opaque { get; }
	public String Nonce { get; }
	public String Algorithm { get; }
	public String QOP { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B4DC34
	public Void .ctor(String header) { }

	// RVA: 0xFFFFFFFF75B4DD18
	public String get_Realm() { }

	// RVA: 0xFFFFFFFF75B4DD4C
	public String get_Opaque() { }

	// RVA: 0xFFFFFFFF75B4DD84
	public String get_Nonce() { }

	// RVA: 0xFFFFFFFF75B4DDBC
	public String get_Algorithm() { }

	// RVA: 0xFFFFFFFF75B4DDF4
	public String get_QOP() { }

	// RVA: 0xFFFFFFFF75B4DE2C
	public Boolean Parse() { }

	// RVA: 0xFFFFFFFF75B4E1CC
	private Void SkipWhitespace() { }

	// RVA: 0xFFFFFFFF75B4E258
	private String GetKey() { }

	// RVA: 0xFFFFFFFF75B4DFF8
	private Boolean GetKeywordAndValue(out String key, out String value) { }

	// RVA: 0xFFFFFFFF75B4E2E8
	private static Void .cctor() { }

}

// Namespace: System.Net
internal class DigestSession
{
	// Fields
	private static RandomNumberGenerator rng; // 0x0
	private DateTime lastUse; // 0x10
	private Int32 _nc; // 0x18
	private HashAlgorithm hash; // 0x20
	private DigestHeaderParser parser; // 0x28
	private String _cnonce; // 0x30

	// Properties
	public String Algorithm { get; }
	public String Realm { get; }
	public String Nonce { get; }
	public String Opaque { get; }
	public String QOP { get; }
	public String CNonce { get; }
	public DateTime LastUse { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B4E468
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75B4D354
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B4E4E0
	public String get_Algorithm() { }

	// RVA: 0xFFFFFFFF75B4E4FC
	public String get_Realm() { }

	// RVA: 0xFFFFFFFF75B4D4B0
	public String get_Nonce() { }

	// RVA: 0xFFFFFFFF75B4E518
	public String get_Opaque() { }

	// RVA: 0xFFFFFFFF75B4E534
	public String get_QOP() { }

	// RVA: 0xFFFFFFFF75B4E550
	public String get_CNonce() { }

	// RVA: 0xFFFFFFFF75B4D3A0
	public Boolean Parse(String challenge) { }

	// RVA: 0xFFFFFFFF75B4E664
	private String HashToHexString(String toBeHashed) { }

	// RVA: 0xFFFFFFFF75B4E774
	private String HA1(String username, String password) { }

	// RVA: 0xFFFFFFFF75B4E888
	private String HA2(HttpWebRequest webRequest) { }

	// RVA: 0xFFFFFFFF75B4E95C
	private String Response(String username, String password, HttpWebRequest webRequest) { }

	// RVA: 0xFFFFFFFF75B4D4CC
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xFFFFFFFF75B4EA94
	public DateTime get_LastUse() { }

}

// Namespace: System.Net
internal class DigestClient
{
	// Fields
	private static readonly Hashtable cache; // 0x0

	// Properties
	private static Hashtable Cache { get; }
	public String AuthenticationType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B4C8A8
	private static Hashtable get_Cache() { }

	// RVA: 0xFFFFFFFF75B4C9C8
	private static Void CheckExpired(Int32 count) { }

	// RVA: 0xFFFFFFFF75B4D0D0
	public Authorization Authenticate(String challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xFFFFFFFF75B4D9C4
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xFFFFFFFF75B4DB60
	public String get_AuthenticationType() { }

	// RVA: 0xFFFFFFFF75B4257C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B4DBA0
	private static Void .cctor() { }

}

// Namespace: System.Net
public static class Dns
{
	// Methods

	// RVA: 0xFFFFFFFF75B4EA9C
	public static IAsyncResult BeginGetHostAddresses(String hostNameOrAddress, AsyncCallback requestCallback, Object state) { }

	// RVA: 0xFFFFFFFF75B4EC7C
	public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B4ED48
	private static Boolean GetHostByName_internal(String host, out String h_name, out String[] h_aliases, out String[] h_addr_list, Int32 hint) { }

	// RVA: 0xFFFFFFFF75B4ED4C
	private static Boolean GetHostByAddr_internal(String addr, out String h_name, out String[] h_aliases, out String[] h_addr_list, Int32 hint) { }

	// RVA: 0xFFFFFFFF75B4ED50
	private static Boolean GetHostName_internal(out String h_name) { }

	// RVA: 0xFFFFFFFF75B4ED54
	private static Void Error_11001(String hostName) { }

	// RVA: 0xFFFFFFFF72378F54
	private static IPHostEntry hostent_to_IPHostEntry(String originalHostName, String h_name, String[] h_aliases, String[] h_addrlist) { }

	// RVA: 0xFFFFFFFF75B4EDA8
	private static IPHostEntry GetHostByAddressFromString(String address, Boolean parse) { }

	// RVA: 0xFFFFFFFF75B4EE88
	public static IPHostEntry GetHostEntry(String hostNameOrAddress) { }

	// RVA: 0xFFFFFFFF75B4EF90
	public static IPHostEntry GetHostEntry(IPAddress address) { }

	// RVA: 0xFFFFFFFF75B4F0D4
	public static IPAddress[] GetHostAddresses(String hostNameOrAddress) { }

	// RVA: 0xFFFFFFFF75B4F018
	public static IPHostEntry GetHostByName(String hostName) { }

	// RVA: 0xFFFFFFFF75B4F20C
	public static String GetHostName() { }

	// RVA: 0xFFFFFFFF75B4F240
	public static Task<T0> GetHostAddressesAsync(String hostNameOrAddress) { }

}

// Namespace: 
private sealed class GetHostAddressesCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75B4EBE8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B4F3A4
	public virtual IPAddress[] Invoke(String hostName) { }

	// RVA: 0xFFFFFFFF75B4EC2C
	public virtual IAsyncResult BeginInvoke(String hostName, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B4ED3C
	public virtual IPAddress[] EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Net
internal class FtpAsyncResult
{
	// Fields
	private FtpWebResponse response; // 0x10
	private ManualResetEvent waitHandle; // 0x18
	private Exception exception; // 0x20
	private AsyncCallback callback; // 0x28
	private Stream stream; // 0x30
	private Object state; // 0x38
	private Boolean completed; // 0x40
	private Boolean synch; // 0x41
	private Object locker; // 0x48

	// Properties
	public Object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public Boolean CompletedSynchronously { get; }
	public Boolean IsCompleted { get; }
	internal Boolean GotException { get; }
	internal Exception Exception { get; }
	internal FtpWebResponse Response { get; }
	internal Stream Stream { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B533C4
	public Void .ctor(AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75B53454
	public Object get_AsyncState() { }

	// RVA: 0xFFFFFFFF75B5345C
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0xFFFFFFFF75B53530
	public Boolean get_CompletedSynchronously() { }

	// RVA: 0xFFFFFFFF75B53538
	public Boolean get_IsCompleted() { }

	// RVA: 0xFFFFFFFF75B535D4
	internal Boolean get_GotException() { }

	// RVA: 0xFFFFFFFF75B535E4
	internal Exception get_Exception() { }

	// RVA: 0xFFFFFFFF75B535EC
	internal FtpWebResponse get_Response() { }

	// RVA: 0xFFFFFFFF75B535F4
	internal Stream get_Stream() { }

	// RVA: 0xFFFFFFFF75B535FC
	internal Void set_Stream(Stream value) { }

	// RVA: 0xFFFFFFFF75B53634
	internal Boolean WaitUntilComplete(Int32 timeout, Boolean exitContext) { }

	// RVA: 0xFFFFFFFF75B536A0
	internal Void SetCompleted(Boolean synch, Exception exc, FtpWebResponse response) { }

	// RVA: 0xFFFFFFFF75B53838
	internal Void SetCompleted(Boolean synch, FtpWebResponse response) { }

	// RVA: 0xFFFFFFFF75B53844
	internal Void SetCompleted(Boolean synch, Exception exc) { }

	// RVA: 0xFFFFFFFF75B53794
	internal Void DoCallback() { }

}

// Namespace: System.Net
internal class FtpDataStream
{
	// Fields
	private FtpWebRequest request; // 0x28
	private Stream networkStream; // 0x30
	private Boolean disposed; // 0x38
	private Boolean isRead; // 0x39
	private Int32 totalRead; // 0x3C

	// Properties
	public override Boolean CanRead { get; }
	public override Boolean CanWrite { get; }
	public override Boolean CanSeek { get; }
	public override Int64 Length { get; }
	public override Int64 Position { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B5384C
	internal Void .ctor(FtpWebRequest request, Stream stream, Boolean isRead) { }

	// RVA: 0xFFFFFFFF75B53940
	public override Boolean get_CanRead() { }

	// RVA: 0xFFFFFFFF75B53948
	public override Boolean get_CanWrite() { }

	// RVA: 0xFFFFFFFF75B53958
	public override Boolean get_CanSeek() { }

	// RVA: 0xFFFFFFFF75B53960
	public override Int64 get_Length() { }

	// RVA: 0xFFFFFFFF75B539B4
	public override Int64 get_Position() { }

	// RVA: 0xFFFFFFFF75B53A08
	public override Void set_Position(Int64 value) { }

	// RVA: 0xFFFFFFFF75B53A5C
	public override Void Close() { }

	// RVA: 0xFFFFFFFF75B53A70
	public override Void Flush() { }

	// RVA: 0xFFFFFFFF75B53A74
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xFFFFFFFF75B53AC8
	public override Void SetLength(Int64 value) { }

	// RVA: 0xFFFFFFFF75B53B1C
	private Int32 ReadInternal(Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75B53DB4
	public override IAsyncResult BeginRead(Byte[] buffer, Int32 offset, Int32 size, AsyncCallback cb, Object state) { }

	// RVA: 0xFFFFFFFF75B54050
	public override Int32 EndRead(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B541A8
	public override Int32 Read(Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF7237998C
	private Void WriteInternal(Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF72379AB4
	public override IAsyncResult BeginWrite(Byte[] buffer, Int32 offset, Int32 size, AsyncCallback cb, Object state) { }

	// RVA: 0xFFFFFFFF72379D6C
	public override Void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF72379EB8
	public override Void Write(Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75B543D8
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75B54450
	private Void System.IDisposable.Dispose() { }

	// RVA: 0xFFFFFFFF75B544A8
	protected override Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF723798EC
	private Void CheckDisposed() { }

}

// Namespace: 
private sealed class WriteDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75B54388
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B549B4
	public virtual Void Invoke(Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF72379CC8
	public virtual IAsyncResult BeginInvoke(Byte[] buffer, Int32 offset, Int32 size, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B543CC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class ReadDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75B53F68
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B5456C
	public virtual Int32 Invoke(Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75B53FAC
	public virtual IAsyncResult BeginInvoke(Byte[] buffer, Int32 offset, Int32 size, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B5417C
	public virtual Int32 EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Net
internal class FtpRequestCreator
{
	// Methods

	// RVA: 0xFFFFFFFF75B54DF8
	public WebRequest Create(Uri uri) { }

	// RVA: 0xFFFFFFFF75B54FA4
	public Void .ctor() { }

}

// Namespace: System.Net
internal class FtpStatus
{
	// Fields
	private readonly FtpStatusCode statusCode; // 0x10
	private readonly String statusDescription; // 0x18

	// Properties
	public FtpStatusCode StatusCode { get; }
	public String StatusDescription { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B54FA8
	public Void .ctor(FtpStatusCode statusCode, String statusDescription) { }

	// RVA: 0xFFFFFFFF75B54FE4
	public FtpStatusCode get_StatusCode() { }

	// RVA: 0xFFFFFFFF75B54FEC
	public String get_StatusDescription() { }

}

// Namespace: System.Net
public sealed class FtpWebRequest
{
	// Fields
	private Uri requestUri; // 0x38
	private String file_name; // 0x40
	private ServicePoint servicePoint; // 0x48
	private Stream origDataStream; // 0x50
	private Stream dataStream; // 0x58
	private Stream controlStream; // 0x60
	private StreamReader controlReader; // 0x68
	private NetworkCredential credentials; // 0x70
	private IPHostEntry hostEntry; // 0x78
	private IPEndPoint localEndPoint; // 0x80
	private IPEndPoint remoteEndPoint; // 0x88
	private IWebProxy proxy; // 0x90
	private Int32 timeout; // 0x98
	private Int32 rwTimeout; // 0x9C
	private Int64 offset; // 0xA0
	private Boolean binary; // 0xA8
	private Boolean enableSsl; // 0xA9
	private Boolean usePassive; // 0xAA
	private Boolean keepAlive; // 0xAB
	private String method; // 0xB0
	private String renameTo; // 0xB8
	private Object locker; // 0xC0
	private RequestState requestState; // 0xC8
	private FtpAsyncResult asyncResult; // 0xD0
	private FtpWebResponse ftpResponse; // 0xD8
	private Stream requestStream; // 0xE0
	private String initial_path; // 0xE8
	private static readonly String[] supportedCommands; // 0x0
	private Encoding dataEncoding; // 0xF0

	// Properties
	public override String ContentType { get; set; }
	public override Int64 ContentLength { get; set; }
	public override ICredentials Credentials { get; set; }
	public Boolean EnableSsl { get; }
	public override WebHeaderCollection Headers { get; set; }
	public Boolean KeepAlive { set; }
	public override String Method { get; set; }
	public override IWebProxy Proxy { get; set; }
	public Int32 ReadWriteTimeout { get; }
	public String RenameTo { set; }
	public override Uri RequestUri { get; }
	public ServicePoint ServicePoint { get; }
	public Boolean UsePassive { set; }
	public Boolean UseBinary { set; }
	public override Int32 Timeout { get; set; }
	private String DataType { get; }
	private RequestState State { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B54E68
	internal Void .ctor(Uri uri) { }

	// RVA: 0xFFFFFFFF75B550AC
	private static Exception GetMustImplement() { }

	// RVA: 0xFFFFFFFF75B550E0
	public override String get_ContentType() { }

	// RVA: 0xFFFFFFFF75B55134
	public override Void set_ContentType(String value) { }

	// RVA: 0xFFFFFFFF75B55188
	public override Int64 get_ContentLength() { }

	// RVA: 0xFFFFFFFF75B55190
	public override Void set_ContentLength(Int64 value) { }

	// RVA: 0xFFFFFFFF75B55194
	public override ICredentials get_Credentials() { }

	// RVA: 0xFFFFFFFF75B5519C
	public override Void set_Credentials(ICredentials value) { }

	// RVA: 0xFFFFFFFF75B55328
	public Boolean get_EnableSsl() { }

	// RVA: 0xFFFFFFFF75B55330
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0xFFFFFFFF75B553A4
	public override Void set_Headers(WebHeaderCollection value) { }

	// RVA: 0xFFFFFFFF75B55418
	public Void set_KeepAlive(Boolean value) { }

	// RVA: 0xFFFFFFFF75B5541C
	public override String get_Method() { }

	// RVA: 0xFFFFFFFF75B55424
	public override Void set_Method(String value) { }

	// RVA: 0xFFFFFFFF75B55594
	public override IWebProxy get_Proxy() { }

	// RVA: 0xFFFFFFFF75B5559C
	public override Void set_Proxy(IWebProxy value) { }

	// RVA: 0xFFFFFFFF75B555DC
	public Int32 get_ReadWriteTimeout() { }

	// RVA: 0xFFFFFFFF75B555E4
	public Void set_RenameTo(String value) { }

	// RVA: 0xFFFFFFFF75B556B0
	public override Uri get_RequestUri() { }

	// RVA: 0xFFFFFFFF75B556B8
	public ServicePoint get_ServicePoint() { }

	// RVA: 0xFFFFFFFF75B55744
	public Void set_UsePassive(Boolean value) { }

	// RVA: 0xFFFFFFFF75B5576C
	public Void set_UseBinary(Boolean value) { }

	// RVA: 0xFFFFFFFF75B55794
	public override Int32 get_Timeout() { }

	// RVA: 0xFFFFFFFF75B5579C
	public override Void set_Timeout(Int32 value) { }

	// RVA: 0xFFFFFFFF75B55820
	private String get_DataType() { }

	// RVA: 0xFFFFFFFF7237A090
	private RequestState get_State() { }

	// RVA: 0xFFFFFFFF75B55844
	private Void set_State(RequestState value) { }

	// RVA: 0xFFFFFFFF75B5596C
	public override Void Abort() { }

	// RVA: 0xFFFFFFFF75B55F5C
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75B56190
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B5631C
	public override WebResponse GetResponse() { }

	// RVA: 0xFFFFFFFF75B56364
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75B565FC
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B567F8
	public override Stream GetRequestStream() { }

	// RVA: 0xFFFFFFFF75B556BC
	private ServicePoint GetServicePoint() { }

	// RVA: 0xFFFFFFFF75B56DB0
	private Void ResolveHost() { }

	// RVA: 0xFFFFFFFF75B57328
	private Void ProcessRequest() { }

	// RVA: 0xFFFFFFFF75B57FC4
	private Void SetType() { }

	// RVA: 0xFFFFFFFF75B581AC
	private String GetRemoteFolderPath(Uri uri) { }

	// RVA: 0xFFFFFFFF75B58380
	private Void CWDAndSetFileName(Uri uri) { }

	// RVA: 0xFFFFFFFF75B57718
	private Void ProcessMethod() { }

	// RVA: 0xFFFFFFFF75B591B0
	private Void CloseControlConnection() { }

	// RVA: 0xFFFFFFFF75B53CE0
	internal Void CloseDataConnection() { }

	// RVA: 0xFFFFFFFF75B5930C
	private Void CloseConnection() { }

	// RVA: 0xFFFFFFFF75B58BE4
	private Void ProcessSimpleMethod() { }

	// RVA: 0xFFFFFFFF75B58B00
	private Void UploadData() { }

	// RVA: 0xFFFFFFFF75B58A3C
	private Void DownloadData() { }

	// RVA: 0xFFFFFFFF75B552A0
	private Void CheckRequestStarted() { }

	// RVA: 0xFFFFFFFF75B58500
	private Void OpenControlConnection() { }

	// RVA: 0xFFFFFFFF75B59E08
	private static String GetInitialPath(FtpStatus status) { }

	// RVA: 0xFFFFFFFF75B59F78
	private Socket SetupPassiveConnection(String statusDescription, Boolean ipv6) { }

	// RVA: 0xFFFFFFFF75B5A130
	private Int32 GetPortV4(String responseString) { }

	// RVA: 0xFFFFFFFF75B5A350
	private Int32 GetPortV6(String responseString) { }

	// RVA: 0xFFFFFFFF75B5A4CC
	private String FormatAddress(IPAddress address, Int32 Port) { }

	// RVA: 0xFFFFFFFF75B5A824
	private String FormatAddressV6(IPAddress address, Int32 port) { }

	// RVA: 0xFFFFFFFF75B580C4
	private Exception CreateExceptionFromResponse(FtpStatus status) { }

	// RVA: 0xFFFFFFFF75B53D30
	internal Void SetTransferCompleted() { }

	// RVA: 0xFFFFFFFF75B5A92C
	internal Void OperationCompleted() { }

	// RVA: 0xFFFFFFFF75B57C60
	private Void SetCompleteWithError(Exception exc) { }

	// RVA: 0xFFFFFFFF75B5A93C
	private Socket InitDataConnection() { }

	// RVA: 0xFFFFFFFF75B59360
	private Void OpenDataConnection() { }

	// RVA: 0xFFFFFFFF75B599E0
	private Void Authenticate() { }

	// RVA: 0xFFFFFFFF75B580B4
	private FtpStatus SendCommand(String command, String[] parameters) { }

	// RVA: 0xFFFFFFFF75B55B70
	private FtpStatus SendCommand(Boolean waitResponse, String command, String[] parameters) { }

	// RVA: 0xFFFFFFFF75B5B0EC
	internal static FtpStatus ServiceNotAvailable() { }

	// RVA: 0xFFFFFFFF75B57CB0
	internal FtpStatus GetResponseStatus() { }

	// RVA: 0xFFFFFFFF75B5B00C
	private Void InitiateSecureConnection(ref Stream stream) { }

	// RVA: 0xFFFFFFFF75B5AE08
	internal Boolean ChangeToSSLSocket(ref Stream stream) { }

	// RVA: 0xFFFFFFFF75B55D88
	private Boolean InFinalState() { }

	// RVA: 0xFFFFFFFF75B57C7C
	private Boolean InProgress() { }

	// RVA: 0xFFFFFFFF723797EC
	internal Void CheckIfAborted() { }

	// RVA: 0xFFFFFFFF75B558E4
	private Void CheckFinalState() { }

	// RVA: 0xFFFFFFFF75B5B194
	private static Void .cctor() { }

}

// Namespace: 
private enum RequestState
{
	// Fields
	public Int32 value__; // 0x10
	public const RequestState Before = 0;
	public const RequestState Scheduled = 1;
	public const RequestState Connecting = 2;
	public const RequestState Authenticating = 3;
	public const RequestState OpeningData = 4;
	public const RequestState TransferInProgress = 5;
	public const RequestState Finished = 6;
	public const RequestState Aborted = 7;
	public const RequestState Error = 8;
}

// Namespace: System.Net
public class FtpWebResponse
{
	// Fields
	private Stream stream; // 0x18
	private Uri uri; // 0x20
	private FtpStatusCode statusCode; // 0x28
	private DateTime lastModified; // 0x30
	private String bannerMessage; // 0x38
	private String welcomeMessage; // 0x40
	private String exitMessage; // 0x48
	private String statusDescription; // 0x50
	private String method; // 0x58
	private Boolean disposed; // 0x60
	private FtpWebRequest request; // 0x68
	internal Int64 contentLength; // 0x70

	// Properties
	public override Int64 ContentLength { get; }
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	internal DateTime LastModified { set; }
	internal String BannerMessage { set; }
	internal String WelcomeMessage { set; }
	public FtpStatusCode StatusCode { get; set; }
	internal Stream Stream { set; }

	// Methods

	// RVA: 0xFFFFFFFF75B575C4
	internal Void .ctor(FtpWebRequest request, Uri uri, String method, Boolean keepAlive) { }

	// RVA: 0xFFFFFFFF75B55DD8
	internal Void .ctor(FtpWebRequest request, Uri uri, String method, FtpStatusCode statusCode, String statusDescription) { }

	// RVA: 0xFFFFFFFF75B5A908
	internal Void .ctor(FtpWebRequest request, Uri uri, String method, FtpStatus status) { }

	// RVA: 0xFFFFFFFF75B5B494
	public override Int64 get_ContentLength() { }

	// RVA: 0xFFFFFFFF75B5B49C
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0xFFFFFFFF75B5B4D0
	public override Uri get_ResponseUri() { }

	// RVA: 0xFFFFFFFF75B5B4D8
	internal Void set_LastModified(DateTime value) { }

	// RVA: 0xFFFFFFFF75B5B4E0
	internal Void set_BannerMessage(String value) { }

	// RVA: 0xFFFFFFFF75B5B518
	internal Void set_WelcomeMessage(String value) { }

	// RVA: 0xFFFFFFFF75B5B550
	public FtpStatusCode get_StatusCode() { }

	// RVA: 0xFFFFFFFF75B5B558
	internal Void set_StatusCode(FtpStatusCode value) { }

	// RVA: 0xFFFFFFFF75B5B560
	public override Void Close() { }

	// RVA: 0xFFFFFFFF75B5B63C
	public override Stream GetResponseStream() { }

	// RVA: 0xFFFFFFFF75B5B794
	internal Void set_Stream(Stream value) { }

	// RVA: 0xFFFFFFFF75B572DC
	internal Void UpdateStatus(FtpStatus status) { }

	// RVA: 0xFFFFFFFF75B5B6F8
	private Void CheckDisposed() { }

	// RVA: 0xFFFFFFFF75B57FB4
	internal Boolean IsFinal() { }

}

// Namespace: System.Net
internal class HttpRequestCreator
{
	// Methods

	// RVA: 0xFFFFFFFF75B5C2D0
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75B5C2D4
	public WebRequest Create(Uri uri) { }

}

// Namespace: System.Net
public class HttpWebRequest
{
	// Fields
	private Uri requestUri; // 0x38
	private Uri actualUri; // 0x40
	private Boolean hostChanged; // 0x48
	private Boolean allowAutoRedirect; // 0x49
	private Boolean allowBuffering; // 0x4A
	private X509CertificateCollection certificates; // 0x50
	private String connectionGroup; // 0x58
	private Boolean haveContentLength; // 0x60
	private Int64 contentLength; // 0x68
	private HttpContinueDelegate continueDelegate; // 0x70
	private CookieContainer cookieContainer; // 0x78
	private ICredentials credentials; // 0x80
	private Boolean haveResponse; // 0x88
	private Boolean haveRequest; // 0x89
	private Boolean requestSent; // 0x8A
	private WebHeaderCollection webHeaders; // 0x90
	private Boolean keepAlive; // 0x98
	private Int32 maxAutoRedirect; // 0x9C
	private String mediaType; // 0xA0
	private String method; // 0xA8
	private String initialMethod; // 0xB0
	private Boolean pipelined; // 0xB8
	private Boolean preAuthenticate; // 0xB9
	private Boolean usedPreAuth; // 0xBA
	private Version version; // 0xC0
	private Boolean force_version; // 0xC8
	private Version actualVersion; // 0xD0
	private IWebProxy proxy; // 0xD8
	private Boolean sendChunked; // 0xE0
	private ServicePoint servicePoint; // 0xE8
	private Int32 timeout; // 0xF0
	private WebConnectionStream writeStream; // 0xF8
	private HttpWebResponse webResponse; // 0x100
	private WebAsyncResult asyncWrite; // 0x108
	private WebAsyncResult asyncRead; // 0x110
	private EventHandler abortHandler; // 0x118
	private Int32 aborted; // 0x120
	private Boolean gotRequestStream; // 0x124
	private Int32 redirects; // 0x128
	private Boolean expectContinue; // 0x12C
	private Byte[] bodyBuffer; // 0x130
	private Int32 bodyBufferLength; // 0x138
	private Boolean getResponseCalled; // 0x13C
	private Exception saved_exc; // 0x140
	private Object locker; // 0x148
	private Boolean finished_reading; // 0x150
	internal WebConnection WebConnection; // 0x158
	private DecompressionMethods auto_decomp; // 0x160
	private static Int32 defaultMaxResponseHeadersLength; // 0x0
	private Int32 readWriteTimeout; // 0x164
	private MonoTlsProvider tlsProvider; // 0x168
	private MonoTlsSettings tlsSettings; // 0x170
	private ServerCertValidationCallback certValidationCallback; // 0x178
	private AuthorizationState auth_state; // 0x180
	private AuthorizationState proxy_auth_state; // 0x190
	private String host; // 0x1A0
	internal Action<T0> ResendContentFactory; // 0x1A8
	private Boolean <ThrowOnError>k__BackingField; // 0x1B0
	private Boolean unsafe_auth_blah; // 0x1B1
	private Boolean <ReuseConnection>k__BackingField; // 0x1B2
	internal WebConnection StoredConnection; // 0x1B8

	// Properties
	public String Accept { set; }
	public Uri Address { get; set; }
	public virtual Boolean AllowAutoRedirect { set; }
	public virtual Boolean AllowWriteStreamBuffering { get; }
	public DecompressionMethods AutomaticDecompression { get; }
	internal Boolean InternalAllowBuffering { get; }
	private Boolean MethodWithBuffer { get; }
	internal MonoTlsProvider TlsProvider { get; }
	internal MonoTlsSettings TlsSettings { get; }
	public X509CertificateCollection ClientCertificates { get; }
	public String Connection { set; }
	public override Int64 ContentLength { get; set; }
	internal Int64 InternalContentLength { set; }
	internal Boolean ThrowOnError { get; set; }
	public override String ContentType { get; set; }
	public override ICredentials Credentials { get; set; }
	public String Expect { set; }
	public override WebHeaderCollection Headers { get; set; }
	public String Host { get; set; }
	public Boolean KeepAlive { get; set; }
	public Int32 ReadWriteTimeout { get; set; }
	public override String Method { get; set; }
	public Version ProtocolVersion { get; set; }
	public override IWebProxy Proxy { get; set; }
	public String Referer { set; }
	public override Uri RequestUri { get; }
	public Boolean SendChunked { get; }
	public ServicePoint ServicePoint { get; }
	internal ServicePoint ServicePointNoLock { get; }
	public override Int32 Timeout { get; set; }
	public String TransferEncoding { get; }
	public String UserAgent { set; }
	public Boolean UnsafeAuthenticatedConnectionSharing { get; }
	internal Boolean ExpectContinue { get; set; }
	internal Uri AuthUri { get; }
	internal Boolean ProxyQuery { get; }
	internal ServerCertValidationCallback ServerCertValidationCallback { get; }
	internal Boolean FinishedReading { get; set; }
	internal Boolean Aborted { get; }
	internal Boolean ReuseConnection { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B5C5C4
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75B5C30C
	public Void .ctor(Uri uri) { }

	// RVA: 0xFFFFFFFF75B5C68C
	protected Void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B5C5DC
	private Void ResetAuthorization() { }

	// RVA: 0xFFFFFFFF75B5CE14
	private Void SetSpecialHeaders(String HeaderName, String value) { }

	// RVA: 0xFFFFFFFF75B5CEB8
	public Void set_Accept(String value) { }

	// RVA: 0xFFFFFFFF75B5CF3C
	public Uri get_Address() { }

	// RVA: 0xFFFFFFFF75B5CF44
	internal Void set_Address(Uri value) { }

	// RVA: 0xFFFFFFFF75B5CF7C
	public virtual Void set_AllowAutoRedirect(Boolean value) { }

	// RVA: 0xFFFFFFFF75B5CF84
	public virtual Boolean get_AllowWriteStreamBuffering() { }

	// RVA: 0xFFFFFFFF75B5CF8C
	public DecompressionMethods get_AutomaticDecompression() { }

	// RVA: 0xFFFFFFFF75B5CF94
	internal Boolean get_InternalAllowBuffering() { }

	// RVA: 0xFFFFFFFF7237BE60
	private Boolean get_MethodWithBuffer() { }

	// RVA: 0xFFFFFFFF75B5CFA8
	internal MonoTlsProvider get_TlsProvider() { }

	// RVA: 0xFFFFFFFF75B5CFB0
	internal MonoTlsSettings get_TlsSettings() { }

	// RVA: 0xFFFFFFFF75B5CFB8
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0xFFFFFFFF75B5D050
	public Void set_Connection(String value) { }

	// RVA: 0xFFFFFFFF7237BFAC
	public override Int64 get_ContentLength() { }

	// RVA: 0xFFFFFFFF75B5D19C
	public override Void set_ContentLength(Int64 value) { }

	// RVA: 0xFFFFFFFF75B5D208
	internal Void set_InternalContentLength(Int64 value) { }

	// RVA: 0xFFFFFFFF75B5D210
	internal Boolean get_ThrowOnError() { }

	// RVA: 0xFFFFFFFF75B5D218
	internal Void set_ThrowOnError(Boolean value) { }

	// RVA: 0xFFFFFFFF75B5D220
	public override String get_ContentType() { }

	// RVA: 0xFFFFFFFF75B5D248
	public override Void set_ContentType(String value) { }

	// RVA: 0xFFFFFFFF75B5D258
	public override ICredentials get_Credentials() { }

	// RVA: 0xFFFFFFFF75B5D260
	public override Void set_Credentials(ICredentials value) { }

	// RVA: 0xFFFFFFFF75B5D298
	public Void set_Expect(String value) { }

	// RVA: 0xFFFFFFFF75B5D3A8
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0xFFFFFFFF75B5D3B0
	public override Void set_Headers(WebHeaderCollection value) { }

	// RVA: 0xFFFFFFFF75B5D4A8
	public String get_Host() { }

	// RVA: 0xFFFFFFFF75B5D4DC
	public Void set_Host(String value) { }

	// RVA: 0xFFFFFFFF75B5D60C
	private static Boolean CheckValidHost(String scheme, String val) { }

	// RVA: 0xFFFFFFFF75B5D714
	public Boolean get_KeepAlive() { }

	// RVA: 0xFFFFFFFF75B5D71C
	public Void set_KeepAlive(Boolean value) { }

	// RVA: 0xFFFFFFFF75B5D724
	public Int32 get_ReadWriteTimeout() { }

	// RVA: 0xFFFFFFFF75B5D72C
	public Void set_ReadWriteTimeout(Int32 value) { }

	// RVA: 0xFFFFFFFF7237C030
	public override String get_Method() { }

	// RVA: 0xFFFFFFFF75B5D7FC
	public override Void set_Method(String value) { }

	// RVA: 0xFFFFFFFF75B5D970
	public Version get_ProtocolVersion() { }

	// RVA: 0xFFFFFFFF75B5D978
	public Void set_ProtocolVersion(Version value) { }

	// RVA: 0xFFFFFFFF7237C038
	public override IWebProxy get_Proxy() { }

	// RVA: 0xFFFFFFFF75B5DA8C
	public override Void set_Proxy(IWebProxy value) { }

	// RVA: 0xFFFFFFFF75B5DAF4
	public Void set_Referer(String value) { }

	// RVA: 0xFFFFFFFF75B5DB70
	public override Uri get_RequestUri() { }

	// RVA: 0xFFFFFFFF75B5DB78
	public Boolean get_SendChunked() { }

	// RVA: 0xFFFFFFFF75B5DB80
	public ServicePoint get_ServicePoint() { }

	// RVA: 0xFFFFFFFF75B5DB84
	internal ServicePoint get_ServicePointNoLock() { }

	// RVA: 0xFFFFFFFF75B5DB8C
	public override Int32 get_Timeout() { }

	// RVA: 0xFFFFFFFF75B5DB94
	public override Void set_Timeout(Int32 value) { }

	// RVA: 0xFFFFFFFF75B5DBE8
	public String get_TransferEncoding() { }

	// RVA: 0xFFFFFFFF75B5DC10
	public Void set_UserAgent(String value) { }

	// RVA: 0xFFFFFFFF75B5DC3C
	public Boolean get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0xFFFFFFFF75B5DC44
	internal Boolean get_ExpectContinue() { }

	// RVA: 0xFFFFFFFF75B5DC4C
	internal Void set_ExpectContinue(Boolean value) { }

	// RVA: 0xFFFFFFFF75B5DC54
	internal Uri get_AuthUri() { }

	// RVA: 0xFFFFFFFF75B5DC5C
	internal Boolean get_ProxyQuery() { }

	// RVA: 0xFFFFFFFF75B5DC94
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0xFFFFFFFF7237C040
	internal ServicePoint GetServicePoint() { }

	// RVA: 0xFFFFFFFF75B5DC9C
	public Void AddRange(Int32 range) { }

	// RVA: 0xFFFFFFFF75B5DED4
	public Void AddRange(Int32 from, Int32 to) { }

	// RVA: 0xFFFFFFFF75B5E0E4
	public Void AddRange(Int64 range) { }

	// RVA: 0xFFFFFFFF75B5E0F4
	public Void AddRange(Int64 from, Int64 to) { }

	// RVA: 0xFFFFFFFF75B5DCB0
	public Void AddRange(String rangeSpecifier, Int64 range) { }

	// RVA: 0xFFFFFFFF75B5DEF0
	public Void AddRange(String rangeSpecifier, Int64 from, Int64 to) { }

	// RVA: 0xFFFFFFFF75B5E108
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75B5E6DC
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B5E808
	public override Stream GetRequestStream() { }

	// RVA: 0xFFFFFFFF75B5EA00
	private Boolean CheckIfForceWrite(SimpleAsyncResult result) { }

	// RVA: 0xFFFFFFFF75B5EB5C
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75B5EF00
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B5F018
	public override WebResponse GetResponse() { }

	// RVA: 0xFFFFFFFF75B5F0A0
	internal Boolean get_FinishedReading() { }

	// RVA: 0xFFFFFFFF75B5F0A8
	internal Void set_FinishedReading(Boolean value) { }

	// RVA: 0xFFFFFFFF7237C174
	internal Boolean get_Aborted() { }

	// RVA: 0xFFFFFFFF75B5F0B0
	public override Void Abort() { }

	// RVA: 0xFFFFFFFF75B5F574
	private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B5F584
	protected override Void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B5CEEC
	private Void CheckRequestStarted() { }

	// RVA: 0xFFFFFFFF75B5F960
	internal Void DoContinueDelegate(Int32 statusCode, WebHeaderCollection headers) { }

	// RVA: 0xFFFFFFFF75B5F970
	private Void RewriteRedirectToGet() { }

	// RVA: 0xFFFFFFFF75B5F9D0
	private Boolean Redirect(WebAsyncResult result, HttpStatusCode code, WebResponse response) { }

	// RVA: 0xFFFFFFFF75B5FE3C
	private String GetHeaders() { }

	// RVA: 0xFFFFFFFF75B603BC
	private Void DoPreAuthenticate() { }

	// RVA: 0xFFFFFFFF75B605B8
	internal Void SetWriteStreamError(WebExceptionStatus status, Exception exc) { }

	// RVA: 0xFFFFFFFF75B6078C
	internal Byte[] GetRequestHeaders() { }

	// RVA: 0xFFFFFFFF75B60A70
	internal Void SetWriteStream(WebConnectionStream stream) { }

	// RVA: 0xFFFFFFFF75B60B7C
	private Void SetWriteStreamInner(SimpleAsyncCallback callback) { }

	// RVA: 0xFFFFFFFF75B60BD4
	private Void SetWriteStreamError(Exception exc) { }

	// RVA: 0xFFFFFFFF75B60C1C
	internal Void SetResponseError(WebExceptionStatus status, Exception e, String where) { }

	// RVA: 0xFFFFFFFF75B60E88
	private Void CheckSendError(WebConnectionData data) { }

	// RVA: 0xFFFFFFFF75B61050
	private Boolean HandleNtlmAuth(WebAsyncResult r) { }

	// RVA: 0xFFFFFFFF75B61298
	internal Void SetResponseData(WebConnectionData data) { }

	// RVA: 0xFFFFFFFF75B61DC0
	private Boolean CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0xFFFFFFFF7237C500
	private Boolean CheckFinalStatus(WebAsyncResult result) { }

	// RVA: 0xFFFFFFFF75B62118
	internal Boolean get_ReuseConnection() { }

	// RVA: 0xFFFFFFFF75B62120
	internal Void set_ReuseConnection(Boolean value) { }

	// RVA: 0xFFFFFFFF75B62128
	private Void <SetWriteStream>b__258_0(SimpleAsyncResult result) { }

	// RVA: 0xFFFFFFFF7237CD2C
	private Void <SetWriteStream>b__258_1(SimpleAsyncResult inner) { }

	// RVA: 0xFFFFFFFF75B621E8
	private Boolean <SetWriteStreamInner>b__259_0(SimpleAsyncResult result) { }

	// RVA: 0xFFFFFFFF75B622B8
	public Void .ctor() { }

}

// Namespace: 
private enum NtlmAuthState
{
	// Fields
	public Int32 value__; // 0x10
	public const NtlmAuthState None = 0;
	public const NtlmAuthState Challenge = 1;
	public const NtlmAuthState Response = 2;
}

// Namespace: 
private struct AuthorizationState
{
	// Fields
	private readonly HttpWebRequest request; // 0x10
	private readonly Boolean isProxy; // 0x18
	private Boolean isCompleted; // 0x19
	private NtlmAuthState ntlm_auth_state; // 0x1C

	// Properties
	public Boolean IsCompleted { get; }
	public NtlmAuthState NtlmAuthState { get; }
	public Boolean IsNtlmAuthenticated { get; }

	// Methods

	// RVA: 0xFFFFFFFF71147D38
	public Boolean get_IsCompleted() { }

	// RVA: 0xFFFFFFFF71147D40
	public NtlmAuthState get_NtlmAuthState() { }

	// RVA: 0xFFFFFFFF71147D48
	public Boolean get_IsNtlmAuthenticated() { }

	// RVA: 0xFFFFFFFF71147D68
	public Void .ctor(HttpWebRequest request, Boolean isProxy) { }

	// RVA: 0xFFFFFFFF71147DB8
	public Boolean CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0xFFFFFFFF71147DC0
	public Void Reset() { }

	// RVA: 0xFFFFFFFF71147DC8
	public override String ToString() { }

}

// Namespace: 
private sealed class <>c__DisplayClass238_0
{
	// Fields
	public WebAsyncResult aread; // 0x10
	public HttpWebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75B5EDF4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B622F0
	internal Void <BeginGetResponse>b__0(SimpleAsyncResult inner) { }

}

// Namespace: System.Net
public class HttpWebResponse
{
	// Fields
	private Uri uri; // 0x18
	private WebHeaderCollection webHeaders; // 0x20
	private CookieCollection cookieCollection; // 0x28
	private String method; // 0x30
	private Version version; // 0x38
	private HttpStatusCode statusCode; // 0x40
	private String statusDescription; // 0x48
	private Int64 contentLength; // 0x50
	private String contentType; // 0x58
	private CookieContainer cookie_container; // 0x60
	private Boolean disposed; // 0x68
	private Stream stream; // 0x70

	// Properties
	public override Int64 ContentLength { get; }
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	public virtual HttpStatusCode StatusCode { get; }
	public virtual String StatusDescription { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B61A9C
	internal Void .ctor(Uri uri, String method, WebConnectionData data, CookieContainer container) { }

	// RVA: 0xFFFFFFFF75B627E4
	protected Void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B62B58
	public override Int64 get_ContentLength() { }

	// RVA: 0xFFFFFFFF75B62B60
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0xFFFFFFFF75B62B68
	public override Uri get_ResponseUri() { }

	// RVA: 0xFFFFFFFF75B62C00
	public virtual HttpStatusCode get_StatusCode() { }

	// RVA: 0xFFFFFFFF75B62C08
	public virtual String get_StatusDescription() { }

	// RVA: 0xFFFFFFFF75B60F84
	internal Void ReadAll() { }

	// RVA: 0xFFFFFFFF75B62C2C
	public override Stream GetResponseStream() { }

	// RVA: 0xFFFFFFFF75B62CA4
	private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B62CB4
	protected override Void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B62E3C
	public override Void Close() { }

	// RVA: 0xFFFFFFFF75B62E94
	private Void System.IDisposable.Dispose() { }

	// RVA: 0xFFFFFFFF75B62EA8
	protected override Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75B62B8C
	private Void CheckDisposed() { }

	// RVA: 0xFFFFFFFF75B625DC
	private Void FillCookies() { }

	// RVA: 0xFFFFFFFF75B62EBC
	public Void .ctor() { }

}

// Namespace: System.Net
public interface ICredentialPolicy
{}

// Namespace: System.Net
internal struct IPv6AddressFormatter
{
	// Fields
	private UInt16[] address; // 0x10
	private Int64 scopeId; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF71147E80
	public Void .ctor(UInt16[] addr, Int64 scopeId) { }

	// RVA: 0xFFFFFFFF75B6451C
	private static UInt16 SwapUShort(UInt16 number) { }

	// RVA: 0xFFFFFFFF71147EC8
	private UInt32 AsIPv4Int() { }

	// RVA: 0xFFFFFFFF71147ED0
	private Boolean IsIPv4Compatible() { }

	// RVA: 0xFFFFFFFF71147ED8
	private Boolean IsIPv4Mapped() { }

	// RVA: 0xFFFFFFFF71147EE0
	public override String ToString() { }

}

// Namespace: System.Net
internal interface IWebConnectionState
{
	// Properties
	public abstract WebConnectionGroup Group { get; }

	// Methods

	// RVA: -1
	public abstract WebConnectionGroup get_Group() { }

	// RVA: -1
	public abstract Boolean TrySetBusy() { }

	// RVA: -1
	public abstract Void SetIdle() { }

}

// Namespace: System.Net
internal class MonoChunkStream
{
	// Fields
	internal WebHeaderCollection headers; // 0x10
	private Int32 chunkSize; // 0x18
	private Int32 chunkRead; // 0x1C
	private Int32 totalWritten; // 0x20
	private State state; // 0x24
	private StringBuilder saved; // 0x28
	private Boolean sawCR; // 0x30
	private Boolean gotit; // 0x31
	private Int32 trailerState; // 0x34
	private ArrayList chunks; // 0x38

	// Properties
	public Boolean WantMore { get; }
	public Boolean DataAvailable { get; }
	public Int32 ChunkLeft { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B656CC
	public Void .ctor(Byte[] buffer, Int32 offset, Int32 size, WebHeaderCollection headers) { }

	// RVA: 0xFFFFFFFF75B65730
	public Void .ctor(WebHeaderCollection headers) { }

	// RVA: 0xFFFFFFFF75B65814
	public Void ResetBuffer() { }

	// RVA: 0xFFFFFFFF75B65848
	public Void WriteAndReadBack(Byte[] buffer, Int32 offset, Int32 size, ref Int32 read) { }

	// RVA: 0xFFFFFFFF75B658D0
	public Int32 Read(Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75B658D4
	private Int32 ReadFromChunks(Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75B657E4
	public Void Write(Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75B65C18
	private Void InternalWrite(Byte[] buffer, ref Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75B665F0
	public Boolean get_WantMore() { }

	// RVA: 0xFFFFFFFF75B66614
	public Boolean get_DataAvailable() { }

	// RVA: 0xFFFFFFFF75B66724
	public Int32 get_ChunkLeft() { }

	// RVA: 0xFFFFFFFF75B66078
	private State ReadBody(Byte[] buffer, ref Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75B65D64
	private State GetChunkSize(Byte[] buffer, ref Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75B667D0
	private static String RemoveChunkExtension(String input) { }

	// RVA: 0xFFFFFFFF75B661C4
	private State ReadCRLF(Byte[] buffer, ref Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75B662D4
	private State ReadTrailer(Byte[] buffer, ref Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75B66768
	private static Void ThrowProtocolViolation(String message) { }

}

// Namespace: 
private enum State
{
	// Fields
	public Int32 value__; // 0x10
	public const State None = 0;
	public const State PartialSize = 1;
	public const State Body = 2;
	public const State BodyFinished = 3;
	public const State Trailer = 4;
}

// Namespace: 
private class Chunk
{
	// Fields
	public Byte[] Bytes; // 0x10
	public Int32 Offset; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75B66730
	public Void .ctor(Byte[] chunk) { }

	// RVA: 0xFFFFFFFF75B65BB4
	public Int32 Read(Byte[] buffer, Int32 offset, Int32 size) { }

}

// Namespace: System.Net
internal class NtlmClient
{
	// Fields
	private IAuthenticationModule authObject; // 0x10

	// Properties
	public String AuthenticationType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B69608
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B69694
	public Authorization Authenticate(String challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xFFFFFFFF75B69784
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xFFFFFFFF75B6978C
	public String get_AuthenticationType() { }

}

// Namespace: System.Net
public class ServicePoint
{
	// Fields
	private readonly Uri uri; // 0x10
	private Int32 connectionLimit; // 0x18
	private Int32 maxIdleTime; // 0x1C
	private Int32 currentConnections; // 0x20
	private DateTime idleSince; // 0x28
	private DateTime lastDnsResolve; // 0x30
	private Version protocolVersion; // 0x38
	private IPHostEntry host; // 0x40
	private Boolean usesProxy; // 0x48
	private Dictionary<T0, T1> groups; // 0x50
	private Boolean sendContinue; // 0x58
	private Boolean useConnect; // 0x59
	private Object hostE; // 0x60
	private Boolean useNagle; // 0x68
	private BindIPEndPoint endPointCallback; // 0x70
	private Boolean tcp_keepalive; // 0x78
	private Int32 tcp_keepalive_time; // 0x7C
	private Int32 tcp_keepalive_interval; // 0x80
	private Timer idleTimer; // 0x88
	private Object m_ServerCertificateOrBytes; // 0x90
	private Object m_ClientCertificateOrBytes; // 0x98

	// Properties
	public Uri Address { get; }
	public BindIPEndPoint BindIPEndPointDelegate { set; }
	public Int32 ConnectionLimit { get; set; }
	public virtual Version ProtocolVersion { get; }
	public Boolean Expect100Continue { set; }
	public Boolean UseNagleAlgorithm { get; set; }
	internal Boolean SendContinue { get; set; }
	internal Boolean UsesProxy { get; set; }
	internal Boolean UseConnect { get; set; }
	private Boolean HasTimedOut { get; }
	internal IPHostEntry HostEntry { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B6C4E8
	internal Void .ctor(Uri uri, Int32 connectionLimit, Int32 maxIdleTime) { }

	// RVA: 0xFFFFFFFF75B6C5A0
	public Uri get_Address() { }

	// RVA: 0xFFFFFFFF75B6C5A8
	public Void set_BindIPEndPointDelegate(BindIPEndPoint value) { }

	// RVA: 0xFFFFFFFF75B6C5E0
	public Int32 get_ConnectionLimit() { }

	// RVA: 0xFFFFFFFF75B6C5E8
	public Void set_ConnectionLimit(Int32 value) { }

	// RVA: 0xFFFFFFFF7237DDF8
	public virtual Version get_ProtocolVersion() { }

	// RVA: 0xFFFFFFFF75B6C664
	public Void set_Expect100Continue(Boolean value) { }

	// RVA: 0xFFFFFFFF75B6C66C
	public Boolean get_UseNagleAlgorithm() { }

	// RVA: 0xFFFFFFFF75B6C674
	public Void set_UseNagleAlgorithm(Boolean value) { }

	// RVA: 0xFFFFFFFF75B602F8
	internal Boolean get_SendContinue() { }

	// RVA: 0xFFFFFFFF75B6C67C
	internal Void set_SendContinue(Boolean value) { }

	// RVA: 0xFFFFFFFF75B6C684
	public Void SetTcpKeepAlive(Boolean enabled, Int32 keepAliveTime, Int32 keepAliveInterval) { }

	// RVA: 0xFFFFFFFF75B6C70C
	internal Void KeepAliveSetup(Socket socket) { }

	// RVA: 0xFFFFFFFF75B6C7B0
	private static Void PutBytes(Byte[] bytes, UInt32 v, Int32 offset) { }

	// RVA: 0xFFFFFFFF75B6C8E4
	internal Boolean get_UsesProxy() { }

	// RVA: 0xFFFFFFFF75B6C8EC
	internal Void set_UsesProxy(Boolean value) { }

	// RVA: 0xFFFFFFFF75B6C8F4
	internal Boolean get_UseConnect() { }

	// RVA: 0xFFFFFFFF75B6C8FC
	internal Void set_UseConnect(Boolean value) { }

	// RVA: 0xFFFFFFFF75B6C904
	private WebConnectionGroup GetConnectionGroup(String name) { }

	// RVA: 0xFFFFFFFF75B6CA2C
	private Void RemoveConnectionGroup(WebConnectionGroup group) { }

	// RVA: 0xFFFFFFFF7237DE00
	private Boolean CheckAvailableForRecycling(out DateTime outIdleSince) { }

	// RVA: 0xFFFFFFFF7237EA0C
	private Void IdleTimerCallback(Object obj) { }

	// RVA: 0xFFFFFFFF75B6CB08
	private Boolean get_HasTimedOut() { }

	// RVA: 0xFFFFFFFF75B56EF8
	internal IPHostEntry get_HostEntry() { }

	// RVA: 0xFFFFFFFF75B6CC1C
	internal Void SetVersion(Version version) { }

	// RVA: 0xFFFFFFFF75B5E528
	internal EventHandler SendRequest(HttpWebRequest request, String groupName) { }

	// RVA: 0xFFFFFFFF75B6CC54
	public Boolean CloseConnectionGroup(String connectionGroupName) { }

	// RVA: 0xFFFFFFFF75B6CD1C
	internal Void UpdateServerCertificate(X509Certificate certificate) { }

	// RVA: 0xFFFFFFFF75B6CD78
	internal Void UpdateClientCertificate(X509Certificate certificate) { }

	// RVA: 0xFFFFFFFF75B5979C
	internal Boolean CallEndPointDelegate(Socket sock, IPEndPoint remote) { }

	// RVA: 0xFFFFFFFF75B6CDD4
	private Void <GetConnectionGroup>b__66_0(Object s, EventArgs e) { }

}

// Namespace: System.Net
public class ServicePointManager
{
	// Fields
	private static HybridDictionary servicePoints; // 0x0
	private static ICertificatePolicy policy; // 0x8
	private static Int32 defaultConnectionLimit; // 0x10
	private static Int32 maxServicePointIdleTime; // 0x14
	private static Int32 maxServicePoints; // 0x18
	private static Int32 dnsRefreshTimeout; // 0x1C
	private static Boolean _checkCRL; // 0x20
	private static SecurityProtocolType _securityProtocol; // 0x24
	private static Boolean expectContinue; // 0x28
	private static Boolean useNagle; // 0x29
	private static ServerCertValidationCallback server_cert_cb; // 0x30
	private static Boolean tcp_keepalive; // 0x38
	private static Int32 tcp_keepalive_time; // 0x3C
	private static Int32 tcp_keepalive_interval; // 0x40

	// Properties
	public static Boolean CheckCertificateRevocationList { get; }
	public static Int32 DnsRefreshTimeout { get; }
	public static SecurityProtocolType SecurityProtocol { get; set; }
	internal static ServerCertValidationCallback ServerCertValidationCallback { get; }
	public static RemoteCertificateValidationCallback ServerCertificateValidationCallback { set; }

	// Methods

	// RVA: 0xFFFFFFFF75B6CDE4
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75B6CE68
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	// RVA: 0xFFFFFFFF75B6CEA8
	public static Boolean get_CheckCertificateRevocationList() { }

	// RVA: 0xFFFFFFFF75B6CEE8
	public static Int32 get_DnsRefreshTimeout() { }

	// RVA: 0xFFFFFFFF75B6CF28
	public static SecurityProtocolType get_SecurityProtocol() { }

	// RVA: 0xFFFFFFFF75B6CF68
	public static Void set_SecurityProtocol(SecurityProtocolType value) { }

	// RVA: 0xFFFFFFFF75B6CFAC
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0xFFFFFFFF75B6CFEC
	public static Void set_ServerCertificateValidationCallback(RemoteCertificateValidationCallback value) { }

	// RVA: 0xFFFFFFFF75B56840
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

}

// Namespace: 
private class SPKey
{
	// Fields
	private Uri uri; // 0x10
	private Uri proxy; // 0x18
	private Boolean use_connect; // 0x20

	// Properties
	public Boolean UsesProxy { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B6D0D0
	public Void .ctor(Uri uri, Uri proxy, Boolean use_connect) { }

	// RVA: 0xFFFFFFFF7237EA30
	public Boolean get_UsesProxy() { }

	// RVA: 0xFFFFFFFF75B6D138
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7237EA7C
	public override Boolean Equals(Object obj) { }

}

// Namespace: System.Net
internal sealed class SimpleAsyncCallback
{
	// Methods

	// RVA: 0xFFFFFFFF7237C1A0
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7237EB74
	public virtual Void Invoke(SimpleAsyncResult result) { }

	// RVA: 0xFFFFFFFF75B6D1DC
	public virtual IAsyncResult BeginInvoke(SimpleAsyncResult result, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B6D22C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Net
internal class SimpleAsyncResult
{
	// Fields
	private ManualResetEvent handle; // 0x10
	private Boolean synch; // 0x18
	private Boolean isCompleted; // 0x19
	private readonly SimpleAsyncCallback cb; // 0x20
	private Object state; // 0x28
	private Boolean callbackDone; // 0x30
	private Exception exc; // 0x38
	private Object locker; // 0x40
	private Nullable<T0> user_read_synch; // 0x48

	// Properties
	public Object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public Boolean CompletedSynchronously { get; }
	internal Boolean CompletedSynchronouslyPeek { get; }
	public Boolean IsCompleted { get; }
	internal Boolean GotException { get; }
	internal Exception Exception { get; }

	// Methods

	// RVA: 0xFFFFFFFF7237EEF8
	private Void .ctor(SimpleAsyncCallback cb) { }

	// RVA: 0xFFFFFFFF7237EF68
	protected Void .ctor(AsyncCallback cb, Object state) { }

	// RVA: 0xFFFFFFFF7237C3A0
	public static Void Run(Func<T0, T1> func, SimpleAsyncCallback callback) { }

	// RVA: 0xFFFFFFFF75B5EDF8
	public static Void RunWithLock(Object locker, Func<T0, T1> func, SimpleAsyncCallback callback) { }

	// RVA: 0xFFFFFFFF75B6D240
	protected Void Reset_internal() { }

	// RVA: 0xFFFFFFFF75B5F52C
	internal Void SetCompleted(Boolean synch, Exception e) { }

	// RVA: 0xFFFFFFFF7237F08C
	internal Void SetCompleted(Boolean synch) { }

	// RVA: 0xFFFFFFFF7237F0D8
	private Void SetCompleted_internal(Boolean synch, Exception e) { }

	// RVA: 0xFFFFFFFF75B6D324
	protected Void SetCompleted_internal(Boolean synch) { }

	// RVA: 0xFFFFFFFF75B6D300
	private Void DoCallback_private() { }

	// RVA: 0xFFFFFFFF7237F1FC
	protected Void DoCallback_internal() { }

	// RVA: 0xFFFFFFFF75B5E7BC
	internal Void WaitUntilComplete() { }

	// RVA: 0xFFFFFFFF7237C1E4
	internal Boolean WaitUntilComplete(Int32 timeout, Boolean exitContext) { }

	// RVA: 0xFFFFFFFF7237F330
	public Object get_AsyncState() { }

	// RVA: 0xFFFFFFFF7237F220
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0xFFFFFFFF7237F338
	public Boolean get_CompletedSynchronously() { }

	// RVA: 0xFFFFFFFF75B6D32C
	internal Boolean get_CompletedSynchronouslyPeek() { }

	// RVA: 0xFFFFFFFF7237C2EC
	public Boolean get_IsCompleted() { }

	// RVA: 0xFFFFFFFF7237C2DC
	internal Boolean get_GotException() { }

	// RVA: 0xFFFFFFFF75B6D334
	internal Exception get_Exception() { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public AsyncCallback cb; // 0x10
	public SimpleAsyncResult <>4__this; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75B6D238
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF7237F360
	internal Void <.ctor>b__0(SimpleAsyncResult result) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0
{
	// Fields
	public Func<T0, T1> func; // 0x10
	public Object locker; // 0x18
	public SimpleAsyncCallback callback; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75B6D23C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B6D33C
	internal Boolean <RunWithLock>b__0(SimpleAsyncResult inner) { }

	// RVA: 0xFFFFFFFF75B6D388
	internal Void <RunWithLock>b__1(SimpleAsyncResult inner) { }

}

// Namespace: System.Net
internal class WebAsyncResult
{
	// Fields
	private Int32 nbytes; // 0x4C
	private IAsyncResult innerAsyncResult; // 0x50
	private HttpWebResponse response; // 0x58
	private Stream writeStream; // 0x60
	private Byte[] buffer; // 0x68
	private Int32 offset; // 0x70
	private Int32 size; // 0x74
	public Boolean EndCalled; // 0x78
	public Boolean AsyncWriteAll; // 0x79
	public HttpWebRequest AsyncObject; // 0x80

	// Properties
	internal Int32 NBytes { get; set; }
	internal IAsyncResult InnerAsyncResult { get; set; }
	internal Stream WriteStream { get; }
	internal HttpWebResponse Response { get; }
	internal Byte[] Buffer { get; }
	internal Int32 Offset { get; }
	internal Int32 Size { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B79398
	public Void .ctor(AsyncCallback cb, Object state) { }

	// RVA: 0xFFFFFFFF72384C7C
	public Void .ctor(HttpWebRequest request, AsyncCallback cb, Object state) { }

	// RVA: 0xFFFFFFFF72384CC8
	public Void .ctor(AsyncCallback cb, Object state, Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75B793A0
	internal Void Reset() { }

	// RVA: 0xFFFFFFFF72384D28
	internal Void SetCompleted(Boolean synch, Int32 nbytes) { }

	// RVA: 0xFFFFFFFF75B79404
	internal Void SetCompleted(Boolean synch, Stream writeStream) { }

	// RVA: 0xFFFFFFFF75B79454
	internal Void SetCompleted(Boolean synch, HttpWebResponse response) { }

	// RVA: 0xFFFFFFFF72384D34
	internal Void DoCallback() { }

	// RVA: 0xFFFFFFFF75B794A4
	internal Int32 get_NBytes() { }

	// RVA: 0xFFFFFFFF75B794AC
	internal Void set_NBytes(Int32 value) { }

	// RVA: 0xFFFFFFFF75B794B4
	internal IAsyncResult get_InnerAsyncResult() { }

	// RVA: 0xFFFFFFFF75B794BC
	internal Void set_InnerAsyncResult(IAsyncResult value) { }

	// RVA: 0xFFFFFFFF75B794F4
	internal Stream get_WriteStream() { }

	// RVA: 0xFFFFFFFF75B794FC
	internal HttpWebResponse get_Response() { }

	// RVA: 0xFFFFFFFF75B79504
	internal Byte[] get_Buffer() { }

	// RVA: 0xFFFFFFFF75B7950C
	internal Int32 get_Offset() { }

	// RVA: 0xFFFFFFFF75B79514
	internal Int32 get_Size() { }

}

// Namespace: System.Net
internal enum ReadState
{
	// Fields
	public Int32 value__; // 0x10
	public const ReadState None = 0;
	public const ReadState Status = 1;
	public const ReadState Headers = 2;
	public const ReadState Content = 3;
	public const ReadState Aborted = 4;
}

// Namespace: System.Net
internal class WebConnection
{
	// Fields
	private ServicePoint sPoint; // 0x10
	private Stream nstream; // 0x18
	internal Socket socket; // 0x20
	private Object socketLock; // 0x28
	private IWebConnectionState state; // 0x30
	private WebExceptionStatus status; // 0x38
	private Boolean keepAlive; // 0x3C
	private Byte[] buffer; // 0x40
	private EventHandler abortHandler; // 0x48
	private AbortHelper abortHelper; // 0x50
	internal WebConnectionData Data; // 0x58
	private Boolean chunkedRead; // 0x60
	private MonoChunkStream chunkStream; // 0x68
	private Queue queue; // 0x70
	private Boolean reused; // 0x78
	private Int32 position; // 0x7C
	private HttpWebRequest priority_request; // 0x80
	private NetworkCredential ntlm_credentials; // 0x88
	private Boolean ntlm_authenticated; // 0x90
	private Boolean unsafe_sharing; // 0x91
	private NtlmAuthState connect_ntlm_auth_state; // 0x94
	private HttpWebRequest connect_request; // 0x98
	private Exception connect_exception; // 0xA0
	private MonoTlsStream tlsStream; // 0xA8

	// Properties
	internal HttpWebRequest PriorityRequest { set; }
	internal Boolean NtlmAuthenticated { get; set; }
	internal NetworkCredential NtlmCredential { get; set; }
	internal Boolean UnsafeAuthenticatedConnectionSharing { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B7BFB8
	public Void .ctor(IWebConnectionState wcs, ServicePoint sPoint) { }

	// RVA: 0xFFFFFFFF75B7C1BC
	private Boolean CanReuse() { }

	// RVA: 0xFFFFFFFF75B7C1E8
	private Void Connect(HttpWebRequest request) { }

	// RVA: 0xFFFFFFFF75B7C954
	private Boolean CreateTunnel(HttpWebRequest request, Uri connectUri, Stream stream, out Byte[] buffer) { }

	// RVA: 0xFFFFFFFF75B7D1FC
	private WebHeaderCollection ReadHeaders(Stream stream, out Byte[] retBuffer, out Int32 status) { }

	// RVA: 0xFFFFFFFF75B7DD54
	private Void FlushContents(Stream stream, Int32 contentLength) { }

	// RVA: 0xFFFFFFFF75B7DDCC
	private Boolean CreateStream(HttpWebRequest request) { }

	// RVA: 0xFFFFFFFF75B7DB1C
	private Void HandleError(WebExceptionStatus st, Exception e, String where) { }

	// RVA: 0xFFFFFFFF72385498
	private Void ReadDone(IAsyncResult result) { }

	// RVA: 0xFFFFFFFF75B7E78C
	private static Boolean ExpectContent(Int32 statusCode, String method) { }

	// RVA: 0xFFFFFFFF72386664
	internal Void InitRead() { }

	// RVA: 0xFFFFFFFF72385B00
	private static Int32 GetResponse(WebConnectionData data, ServicePoint sPoint, Byte[] buffer, Int32 max) { }

	// RVA: 0xFFFFFFFF75B7E87C
	private Void InitConnection(HttpWebRequest request) { }

	// RVA: 0xFFFFFFFF75B7ED74
	internal EventHandler SendRequest(HttpWebRequest request) { }

	// RVA: 0xFFFFFFFF75B7EF88
	private Void SendNext() { }

	// RVA: 0xFFFFFFFF75B7F0D8
	internal Void NextRead() { }

	// RVA: 0xFFFFFFFF72385288
	private static Boolean ReadLine(Byte[] buffer, ref Int32 start, Int32 max, ref String output) { }

	// RVA: 0xFFFFFFFF72386BDC
	internal IAsyncResult BeginRead(HttpWebRequest request, Byte[] buffer, Int32 offset, Int32 size, AsyncCallback cb, Object state) { }

	// RVA: 0xFFFFFFFF72386FD4
	internal Int32 EndRead(HttpWebRequest request, IAsyncResult result) { }

	// RVA: 0xFFFFFFFF75B7F444
	private Int32 EnsureRead(Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75B7C89C
	private Boolean CompleteChunkedRead() { }

	// RVA: 0xFFFFFFFF723875B0
	internal IAsyncResult BeginWrite(HttpWebRequest request, Byte[] buffer, Int32 offset, Int32 size, AsyncCallback cb, Object state) { }

	// RVA: 0xFFFFFFFF72387A20
	internal Boolean EndWrite(HttpWebRequest request, Boolean throwOnError, IAsyncResult result) { }

	// RVA: 0xFFFFFFFF75B7F55C
	internal Int32 Read(HttpWebRequest request, Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75B7FA48
	internal Boolean Write(HttpWebRequest request, Byte[] buffer, Int32 offset, Int32 size, ref String err_msg) { }

	// RVA: 0xFFFFFFFF75B7E068
	internal Void Close(Boolean sendNext) { }

	// RVA: 0xFFFFFFFF75B7FDE8
	private Void Abort(Object sender, EventArgs args) { }

	// RVA: 0xFFFFFFFF75B7FDA8
	internal Void ResetNtlm() { }

	// RVA: 0xFFFFFFFF75B801B8
	internal Void set_PriorityRequest(HttpWebRequest value) { }

	// RVA: 0xFFFFFFFF75B801F0
	internal Boolean get_NtlmAuthenticated() { }

	// RVA: 0xFFFFFFFF75B801F8
	internal Void set_NtlmAuthenticated(Boolean value) { }

	// RVA: 0xFFFFFFFF75B80200
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0xFFFFFFFF75B80208
	internal Void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0xFFFFFFFF75B80240
	internal Boolean get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0xFFFFFFFF75B80248
	internal Void set_UnsafeAuthenticatedConnectionSharing(Boolean value) { }

	// RVA: 0xFFFFFFFF75B80250
	private Void <SendRequest>b__41_0(Object o) { }

}

// Namespace: 
private enum NtlmAuthState
{
	// Fields
	public Int32 value__; // 0x10
	public const NtlmAuthState None = 0;
	public const NtlmAuthState Challenge = 1;
	public const NtlmAuthState Response = 2;
}

// Namespace: 
private class AbortHelper
{
	// Fields
	public WebConnection Connection; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75B80324
	public Void Abort(Object sender, EventArgs args) { }

	// RVA: 0xFFFFFFFF75B7C1B8
	public Void .ctor() { }

}

// Namespace: System.Net
internal class WebConnectionData
{
	// Fields
	private HttpWebRequest _request; // 0x10
	public Int32 StatusCode; // 0x18
	public String StatusDescription; // 0x20
	public WebHeaderCollection Headers; // 0x28
	public Version Version; // 0x30
	public Version ProxyVersion; // 0x38
	public Stream stream; // 0x40
	public String[] Challenge; // 0x48
	private ReadState _readState; // 0x50

	// Properties
	public HttpWebRequest request { get; set; }
	public ReadState ReadState { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF72384DF0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B7EB90
	public Void .ctor(HttpWebRequest request) { }

	// RVA: 0xFFFFFFFF75B8038C
	public HttpWebRequest get_request() { }

	// RVA: 0xFFFFFFFF75B80394
	public Void set_request(HttpWebRequest value) { }

	// RVA: 0xFFFFFFFF75B803CC
	public ReadState get_ReadState() { }

	// RVA: 0xFFFFFFFF72386554
	public Void set_ReadState(ReadState value) { }

}

// Namespace: System.Net
internal class WebConnectionGroup
{
	// Fields
	private ServicePoint sPoint; // 0x10
	private String name; // 0x18
	private LinkedList<T0> connections; // 0x20
	private Queue queue; // 0x28
	private Boolean closing; // 0x30
	private EventHandler ConnectionClosed; // 0x38

	// Properties
	public String Name { get; }
	internal Queue Queue { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B803D4
	public Void .ctor(ServicePoint sPoint, String name) { }

	// RVA: 0xFFFFFFFF75B804A4
	public Void add_ConnectionClosed(EventHandler value) { }

	// RVA: 0xFFFFFFFF75B80538
	public Void remove_ConnectionClosed(EventHandler value) { }

	// RVA: 0xFFFFFFFF75B805CC
	private Void OnConnectionClosed() { }

	// RVA: 0xFFFFFFFF75B805E8
	public Void Close() { }

	// RVA: 0xFFFFFFFF75B80928
	public WebConnection GetConnection(HttpWebRequest request, out Boolean created) { }

	// RVA: 0xFFFFFFFF75B80AD0
	private static Void PrepareSharingNtlm(WebConnection cnc, HttpWebRequest request) { }

	// RVA: 0xFFFFFFFF75B80DF4
	private ConnectionState FindIdleConnection() { }

	// RVA: 0xFFFFFFFF75B809D8
	private WebConnection CreateOrReuseConnection(HttpWebRequest request, out Boolean created) { }

	// RVA: 0xFFFFFFFF75B80FBC
	public String get_Name() { }

	// RVA: 0xFFFFFFFF75B80FC4
	internal Queue get_Queue() { }

	// RVA: 0xFFFFFFFF72387DCC
	internal Boolean TryRecycle(TimeSpan maxIdleTime, ref DateTime idleSince) { }

}

// Namespace: 
private class ConnectionState
{
	// Fields
	private WebConnection <Connection>k__BackingField; // 0x10
	private WebConnectionGroup <Group>k__BackingField; // 0x18
	private Boolean busy; // 0x20
	private DateTime idleSince; // 0x28

	// Properties
	public WebConnection Connection { get; set; }
	public WebConnectionGroup Group { get; set; }
	public ServicePoint ServicePoint { get; }
	public Boolean Busy { get; }
	public DateTime IdleSince { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B80FCC
	public WebConnection get_Connection() { }

	// RVA: 0xFFFFFFFF75B80FD4
	private Void set_Connection(WebConnection value) { }

	// RVA: 0xFFFFFFFF75B8100C
	public WebConnectionGroup get_Group() { }

	// RVA: 0xFFFFFFFF75B81014
	private Void set_Group(WebConnectionGroup value) { }

	// RVA: 0xFFFFFFFF75B8104C
	public ServicePoint get_ServicePoint() { }

	// RVA: 0xFFFFFFFF75B8106C
	public Boolean get_Busy() { }

	// RVA: 0xFFFFFFFF75B81074
	public DateTime get_IdleSince() { }

	// RVA: 0xFFFFFFFF75B8107C
	public Boolean TrySetBusy() { }

	// RVA: 0xFFFFFFFF7238845C
	public Void SetIdle() { }

	// RVA: 0xFFFFFFFF75B80F04
	public Void .ctor(WebConnectionGroup group) { }

}

// Namespace: System.Net
internal class WebConnectionStream
{
	// Fields
	private static Byte[] crlf; // 0x0
	private Boolean isRead; // 0x28
	private WebConnection cnc; // 0x30
	private HttpWebRequest request; // 0x38
	private Byte[] readBuffer; // 0x40
	private Int32 readBufferOffset; // 0x48
	private Int32 readBufferSize; // 0x4C
	private Int32 stream_length; // 0x50
	private Int64 contentLength; // 0x58
	private Int64 totalRead; // 0x60
	internal Int64 totalWritten; // 0x68
	private Boolean nextReadCalled; // 0x70
	private Int32 pendingReads; // 0x74
	private Int32 pendingWrites; // 0x78
	private ManualResetEvent pending; // 0x80
	private Boolean allowBuffering; // 0x88
	private Boolean sendChunked; // 0x89
	private MemoryStream writeBuffer; // 0x90
	private Boolean requestWritten; // 0x98
	private Byte[] headers; // 0xA0
	private Boolean disposed; // 0xA8
	private Boolean headersSent; // 0xA9
	private Object locker; // 0xB0
	private Boolean initRead; // 0xB8
	private Boolean read_eof; // 0xB9
	private Boolean complete_request_written; // 0xBA
	private Int32 read_timeout; // 0xBC
	private Int32 write_timeout; // 0xC0
	private AsyncCallback cb_wrapper; // 0xC8
	internal Boolean IgnoreIOErrors; // 0xD0
	private Boolean <GetResponseOnClose>k__BackingField; // 0xD1

	// Properties
	internal WebConnection Connection { get; }
	public override Int32 ReadTimeout { get; set; }
	public override Int32 WriteTimeout { get; }
	internal Boolean CompleteRequestWritten { get; }
	internal Boolean SendChunked { set; }
	internal Byte[] ReadBuffer { set; }
	internal Int32 ReadBufferOffset { set; }
	internal Int32 ReadBufferSize { set; }
	internal Byte[] WriteBuffer { get; }
	internal Int32 WriteBufferLength { get; }
	internal Boolean RequestWritten { get; }
	internal Boolean GetResponseOnClose { get; }
	public override Boolean CanSeek { get; }
	public override Boolean CanRead { get; }
	public override Boolean CanWrite { get; }
	public override Int64 Length { get; }
	public override Int64 Position { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B7E45C
	public Void .ctor(WebConnection cnc, WebConnectionData data) { }

	// RVA: 0xFFFFFFFF75B7EBDC
	public Void .ctor(WebConnection cnc, HttpWebRequest request) { }

	// RVA: 0xFFFFFFFF75B816BC
	private Boolean CheckAuthHeader(String headerName) { }

	// RVA: 0xFFFFFFFF75B811B4
	private Boolean IsNtlmAuth() { }

	// RVA: 0xFFFFFFFF75B7E7E0
	internal Void CheckResponseInBuffer() { }

	// RVA: 0xFFFFFFFF75B8171C
	internal WebConnection get_Connection() { }

	// RVA: 0xFFFFFFFF723885BC
	public override Int32 get_ReadTimeout() { }

	// RVA: 0xFFFFFFFF723885C4
	public override Void set_ReadTimeout(Int32 value) { }

	// RVA: 0xFFFFFFFF75B81724
	public override Int32 get_WriteTimeout() { }

	// RVA: 0xFFFFFFFF75B8172C
	internal Boolean get_CompleteRequestWritten() { }

	// RVA: 0xFFFFFFFF75B81734
	internal Void set_SendChunked(Boolean value) { }

	// RVA: 0xFFFFFFFF75B8173C
	internal Void set_ReadBuffer(Byte[] value) { }

	// RVA: 0xFFFFFFFF75B81774
	internal Void set_ReadBufferOffset(Int32 value) { }

	// RVA: 0xFFFFFFFF75B8177C
	internal Void set_ReadBufferSize(Int32 value) { }

	// RVA: 0xFFFFFFFF75B81784
	internal Byte[] get_WriteBuffer() { }

	// RVA: 0xFFFFFFFF72388618
	internal Int32 get_WriteBufferLength() { }

	// RVA: 0xFFFFFFFF75B7E834
	internal Void ForceCompletion() { }

	// RVA: 0xFFFFFFFF75B817AC
	internal Void CheckComplete() { }

	// RVA: 0xFFFFFFFF75B812BC
	internal Void ReadAll() { }

	// RVA: 0xFFFFFFFF75B817F4
	private Void WriteCallbackWrapper(IAsyncResult r) { }

	// RVA: 0xFFFFFFFF7238864C
	private Void ReadCallbackWrapper(IAsyncResult r) { }

	// RVA: 0xFFFFFFFF7238885C
	public override Int32 Read(Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF72388974
	public override IAsyncResult BeginRead(Byte[] buffer, Int32 offset, Int32 size, AsyncCallback cb, Object state) { }

	// RVA: 0xFFFFFFFF72388CD4
	public override Int32 EndRead(IAsyncResult r) { }

	// RVA: 0xFFFFFFFF75B81A50
	private Void WriteAsyncCB(IAsyncResult r) { }

	// RVA: 0xFFFFFFFF75B81D68
	public override IAsyncResult BeginWrite(Byte[] buffer, Int32 offset, Int32 size, AsyncCallback cb, Object state) { }

	// RVA: 0xFFFFFFFF75B82444
	private Void CheckWriteOverflow(Int64 contentLength, Int64 totalWritten, Int64 size) { }

	// RVA: 0xFFFFFFFF75B824C0
	public override Void EndWrite(IAsyncResult r) { }

	// RVA: 0xFFFFFFFF75B82670
	public override Void Write(Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75B82790
	public override Void Flush() { }

	// RVA: 0xFFFFFFFF72389078
	internal Void SetHeadersAsync(Boolean setInternalLength, SimpleAsyncCallback callback) { }

	// RVA: 0xFFFFFFFF72389128
	private Boolean SetHeadersAsync(SimpleAsyncResult result, Boolean setInternalLength) { }

	// RVA: 0xFFFFFFFF75B8279C
	internal Boolean get_RequestWritten() { }

	// RVA: 0xFFFFFFFF75B827A4
	internal Boolean WriteRequestAsync(SimpleAsyncResult result) { }

	// RVA: 0xFFFFFFFF75B829BC
	internal Void InternalClose() { }

	// RVA: 0xFFFFFFFF75B829C8
	internal Boolean get_GetResponseOnClose() { }

	// RVA: 0xFFFFFFFF72389B48
	public override Void Close() { }

	// RVA: 0xFFFFFFFF75B81D30
	internal Void KillBuffer() { }

	// RVA: 0xFFFFFFFF75B829EC
	public override Int64 Seek(Int64 a, SeekOrigin b) { }

	// RVA: 0xFFFFFFFF75B82A40
	public override Void SetLength(Int64 a) { }

	// RVA: 0xFFFFFFFF75B82A94
	public override Boolean get_CanSeek() { }

	// RVA: 0xFFFFFFFF75B82A9C
	public override Boolean get_CanRead() { }

	// RVA: 0xFFFFFFFF75B82ABC
	public override Boolean get_CanWrite() { }

	// RVA: 0xFFFFFFFF75B82ADC
	public override Int64 get_Length() { }

	// RVA: 0xFFFFFFFF75B82B4C
	public override Int64 get_Position() { }

	// RVA: 0xFFFFFFFF75B82BA0
	public override Void set_Position(Int64 value) { }

	// RVA: 0xFFFFFFFF75B82BF4
	private static Void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass75_0
{
	// Fields
	public WebConnectionStream <>4__this; // 0x10
	public Boolean setInternalLength; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75B82794
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF72389E34
	internal Boolean <SetHeadersAsync>b__0(SimpleAsyncResult r) { }

}

// Namespace: 
private sealed class <>c__DisplayClass76_0
{
	// Fields
	public WebConnectionStream <>4__this; // 0x10
	public SimpleAsyncResult result; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75B82798
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B82C4C
	internal Void <SetHeadersAsync>b__0(IAsyncResult r) { }

}

// Namespace: 
private sealed class <>c__DisplayClass80_0
{
	// Fields
	public SimpleAsyncResult result; // 0x10
	public WebConnectionStream <>4__this; // 0x18
	public Int32 length; // 0x20
	public Byte[] bytes; // 0x28
	public AsyncCallback <>9__1; // 0x30

	// Methods

	// RVA: 0xFFFFFFFF75B829B8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B82E20
	internal Void <WriteRequestAsync>b__0(SimpleAsyncResult inner) { }

	// RVA: 0xFFFFFFFF75B82FAC
	internal Void <WriteRequestAsync>b__1(IAsyncResult r) { }

}

// Namespace: System.Net.Sockets
public class SocketException
{
	// Fields
	private EndPoint m_EndPoint; // 0x90

	// Properties
	public override String Message { get; }
	public SocketError SocketErrorCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B75A94
	private static Int32 WSAGetLastError_internal() { }

	// RVA: 0xFFFFFFFF75B6E3F8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B75A98
	internal Void .ctor(Int32 error, String message) { }

	// RVA: 0xFFFFFFFF75B6E364
	public Void .ctor(Int32 errorCode) { }

	// RVA: 0xFFFFFFFF72381B6C
	internal Void .ctor(SocketError socketError) { }

	// RVA: 0xFFFFFFFF75B75AF0
	protected Void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFFFFFFF75B75B50
	public override String get_Message() { }

	// RVA: 0xFFFFFFFF75B73AF4
	public SocketError get_SocketErrorCode() { }

}

// Namespace: System.Net.Sockets
public enum AddressFamily
{
	// Fields
	public Int32 value__; // 0x10
	public const AddressFamily Unknown = 4294967295;
	public const AddressFamily Unspecified = 0;
	public const AddressFamily Unix = 1;
	public const AddressFamily InterNetwork = 2;
	public const AddressFamily ImpLink = 3;
	public const AddressFamily Pup = 4;
	public const AddressFamily Chaos = 5;
	public const AddressFamily NS = 6;
	public const AddressFamily Ipx = 6;
	public const AddressFamily Iso = 7;
	public const AddressFamily Osi = 7;
	public const AddressFamily Ecma = 8;
	public const AddressFamily DataKit = 9;
	public const AddressFamily Ccitt = 10;
	public const AddressFamily Sna = 11;
	public const AddressFamily DecNet = 12;
	public const AddressFamily DataLink = 13;
	public const AddressFamily Lat = 14;
	public const AddressFamily HyperChannel = 15;
	public const AddressFamily AppleTalk = 16;
	public const AddressFamily NetBios = 17;
	public const AddressFamily VoiceView = 18;
	public const AddressFamily FireFox = 19;
	public const AddressFamily Banyan = 21;
	public const AddressFamily Atm = 22;
	public const AddressFamily InterNetworkV6 = 23;
	public const AddressFamily Cluster = 24;
	public const AddressFamily Ieee12844 = 25;
	public const AddressFamily Irda = 26;
	public const AddressFamily NetworkDesigners = 28;
	public const AddressFamily Max = 29;
}

// Namespace: System.Net.Sockets
public enum IOControlCode
{
	// Fields
	public Int64 value__; // 0x10
	public const IOControlCode AsyncIO = 2147772029;
	public const IOControlCode NonBlockingIO = 2147772030;
	public const IOControlCode DataToRead = 1074030207;
	public const IOControlCode OobDataRead = 1074033415;
	public const IOControlCode AssociateHandle = 2281701377;
	public const IOControlCode EnableCircularQueuing = 671088642;
	public const IOControlCode Flush = 671088644;
	public const IOControlCode GetBroadcastAddress = 1207959557;
	public const IOControlCode GetExtensionFunctionPointer = 3355443206;
	public const IOControlCode GetQos = 3355443207;
	public const IOControlCode GetGroupQos = 3355443208;
	public const IOControlCode MultipointLoopback = 2281701385;
	public const IOControlCode MulticastScope = 2281701386;
	public const IOControlCode SetQos = 2281701387;
	public const IOControlCode SetGroupQos = 2281701388;
	public const IOControlCode TranslateHandle = 3355443213;
	public const IOControlCode RoutingInterfaceQuery = 3355443220;
	public const IOControlCode RoutingInterfaceChange = 2281701397;
	public const IOControlCode AddressListQuery = 1207959574;
	public const IOControlCode AddressListChange = 671088663;
	public const IOControlCode QueryTargetPnpHandle = 1207959576;
	public const IOControlCode NamespaceChange = 2281701401;
	public const IOControlCode AddressListSort = 3355443225;
	public const IOControlCode ReceiveAll = 2550136833;
	public const IOControlCode ReceiveAllMulticast = 2550136834;
	public const IOControlCode ReceiveAllIgmpMulticast = 2550136835;
	public const IOControlCode KeepAliveValues = 2550136836;
	public const IOControlCode AbsorbRouterAlert = 2550136837;
	public const IOControlCode UnicastInterface = 2550136838;
	public const IOControlCode LimitBroadcasts = 2550136839;
	public const IOControlCode BindToInterface = 2550136840;
	public const IOControlCode MulticastInterface = 2550136841;
	public const IOControlCode AddMulticastGroupOnInterface = 2550136842;
	public const IOControlCode DeleteMulticastGroupFromInterface = 2550136843;
}

// Namespace: System.Net.Sockets
public enum IPProtectionLevel
{
	// Fields
	public Int32 value__; // 0x10
	public const IPProtectionLevel Unspecified = 4294967295;
	public const IPProtectionLevel Unrestricted = 10;
	public const IPProtectionLevel EdgeRestricted = 20;
	public const IPProtectionLevel Restricted = 30;
}

// Namespace: System.Net.Sockets
public class LingerOption
{
	// Fields
	private Boolean enabled; // 0x10
	private Int32 lingerTime; // 0x14

	// Properties
	public Boolean Enabled { set; }
	public Int32 LingerTime { set; }

	// Methods

	// RVA: 0xFFFFFFFF75B6D9C4
	public Void .ctor(Boolean enable, Int32 seconds) { }

	// RVA: 0xFFFFFFFF75B6D9D0
	public Void set_Enabled(Boolean value) { }

	// RVA: 0xFFFFFFFF75B6D9D8
	public Void set_LingerTime(Int32 value) { }

}

// Namespace: System.Net.Sockets
public class MulticastOption
{}

// Namespace: System.Net.Sockets
public class NetworkStream
{
	// Fields
	private Socket m_StreamSocket; // 0x28
	private Boolean m_Readable; // 0x30
	private Boolean m_Writeable; // 0x31
	private Boolean m_OwnsSocket; // 0x32
	private Int32 m_CloseTimeout; // 0x34
	private Boolean m_CleanedUp; // 0x38
	private Int32 m_CurrentReadTimeout; // 0x3C
	private Int32 m_CurrentWriteTimeout; // 0x40

	// Properties
	public override Boolean CanRead { get; }
	public override Boolean CanSeek { get; }
	public override Boolean CanWrite { get; }
	public override Int32 ReadTimeout { get; set; }
	public override Int32 WriteTimeout { get; }
	public override Int64 Length { get; }
	public override Int64 Position { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B59928
	public Void .ctor(Socket socket) { }

	// RVA: 0xFFFFFFFF75B5AD64
	public Void .ctor(Socket socket, Boolean ownsSocket) { }

	// RVA: 0xFFFFFFFF7237F830
	public override Boolean get_CanRead() { }

	// RVA: 0xFFFFFFFF75B6DAC4
	public override Boolean get_CanSeek() { }

	// RVA: 0xFFFFFFFF7237F838
	public override Boolean get_CanWrite() { }

	// RVA: 0xFFFFFFFF75B6DACC
	public override Int32 get_ReadTimeout() { }

	// RVA: 0xFFFFFFFF75B6DB2C
	public override Void set_ReadTimeout(Int32 value) { }

	// RVA: 0xFFFFFFFF75B6DC8C
	public override Int32 get_WriteTimeout() { }

	// RVA: 0xFFFFFFFF75B6DCEC
	public override Int64 get_Length() { }

	// RVA: 0xFFFFFFFF75B6DD58
	public override Int64 get_Position() { }

	// RVA: 0xFFFFFFFF75B6DDC4
	public override Void set_Position(Int64 value) { }

	// RVA: 0xFFFFFFFF75B6DE30
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xFFFFFFFF75B6D9E0
	internal Void InitNetworkStream(Socket socket, FileAccess Access) { }

	// RVA: 0xFFFFFFFF75B6DE9C
	public override Int32 Read([In] [Out] Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF7237F840
	public override Void Write(Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF75B6E1E4
	protected override Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75B6E26C
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF7237FBCC
	public override IAsyncResult BeginRead(Byte[] buffer, Int32 offset, Int32 size, AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF7237FF48
	public override Int32 EndRead(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF723801E4
	public override IAsyncResult BeginWrite(Byte[] buffer, Int32 offset, Int32 size, AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF72380560
	public override Void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B6E2E4
	public override Void Flush() { }

	// RVA: 0xFFFFFFFF75B6E2E8
	public override Void SetLength(Int64 value) { }

	// RVA: 0xFFFFFFFF75B6DBDC
	internal Void SetSocketTimeoutOption(SocketShutdown mode, Int32 timeout, Boolean silent) { }

}

// Namespace: System.Net.Sockets
public enum ProtocolType
{
	// Fields
	public Int32 value__; // 0x10
	public const ProtocolType IP = 0;
	public const ProtocolType IPv6HopByHopOptions = 0;
	public const ProtocolType Icmp = 1;
	public const ProtocolType Igmp = 2;
	public const ProtocolType Ggp = 3;
	public const ProtocolType IPv4 = 4;
	public const ProtocolType Tcp = 6;
	public const ProtocolType Pup = 12;
	public const ProtocolType Udp = 17;
	public const ProtocolType Idp = 22;
	public const ProtocolType IPv6 = 41;
	public const ProtocolType IPv6RoutingHeader = 43;
	public const ProtocolType IPv6FragmentHeader = 44;
	public const ProtocolType IPSecEncapsulatingSecurityPayload = 50;
	public const ProtocolType IPSecAuthenticationHeader = 51;
	public const ProtocolType IcmpV6 = 58;
	public const ProtocolType IPv6NoNextHeader = 59;
	public const ProtocolType IPv6DestinationOptions = 60;
	public const ProtocolType ND = 77;
	public const ProtocolType Raw = 255;
	public const ProtocolType Unspecified = 0;
	public const ProtocolType Ipx = 1000;
	public const ProtocolType Spx = 1256;
	public const ProtocolType SpxII = 1257;
	public const ProtocolType Unknown = 4294967295;
}

// Namespace: System.Net.Sockets
public enum SelectMode
{
	// Fields
	public Int32 value__; // 0x10
	public const SelectMode SelectRead = 0;
	public const SelectMode SelectWrite = 1;
	public const SelectMode SelectError = 2;
}

// Namespace: System.Net.Sockets
public class Socket
{
	// Fields
	private static Object s_InternalSyncObject; // 0x0
	internal static Boolean s_SupportsIPv4; // 0x8
	internal static Boolean s_SupportsIPv6; // 0x9
	internal static Boolean s_OSSupportsIPv6; // 0xA
	internal static Boolean s_Initialized; // 0xB
	private static Boolean s_LoggingEnabled; // 0xC
	internal static Boolean s_PerfCountersEnabled; // 0xD
	internal const Int32 DefaultCloseTimeout = 4294967295;
	private const Int32 SOCKET_CLOSED_CODE = 10004;
	private const String TIMEOUT_EXCEPTION_MSG = "A connection attempt failed because the connected party did not properly respondafter a period of time, or established connection failed because connected host has failed to respond";
	private Boolean is_closed; // 0x10
	private Boolean is_listening; // 0x11
	private Boolean useOverlappedIO; // 0x12
	private Int32 linger_timeout; // 0x14
	private AddressFamily addressFamily; // 0x18
	private SocketType socketType; // 0x1C
	private ProtocolType protocolType; // 0x20
	internal SafeSocketHandle m_Handle; // 0x28
	internal EndPoint seed_endpoint; // 0x30
	internal SemaphoreSlim ReadSem; // 0x38
	internal SemaphoreSlim WriteSem; // 0x40
	internal Boolean is_blocking; // 0x48
	internal Boolean is_bound; // 0x49
	internal Boolean is_connected; // 0x4A
	private Int32 m_IntCleanedUp; // 0x4C
	internal Boolean connect_in_progress; // 0x50
	private static AsyncCallback AcceptAsyncCallback; // 0x10
	private static IOAsyncCallback BeginAcceptCallback; // 0x18
	private static IOAsyncCallback BeginAcceptReceiveCallback; // 0x20
	private static AsyncCallback ConnectAsyncCallback; // 0x28
	private static IOAsyncCallback BeginConnectCallback; // 0x30
	private static AsyncCallback DisconnectAsyncCallback; // 0x38
	private static IOAsyncCallback BeginDisconnectCallback; // 0x40
	private static AsyncCallback ReceiveAsyncCallback; // 0x48
	private static IOAsyncCallback BeginReceiveCallback; // 0x50
	private static IOAsyncCallback BeginReceiveGenericCallback; // 0x58
	private static AsyncCallback ReceiveFromAsyncCallback; // 0x60
	private static IOAsyncCallback BeginReceiveFromCallback; // 0x68
	private static AsyncCallback SendAsyncCallback; // 0x70
	private static IOAsyncCallback BeginSendGenericCallback; // 0x78
	private static AsyncCallback SendToAsyncCallback; // 0x80

	// Properties
	public static Boolean SupportsIPv4 { get; }
	public static Boolean OSSupportsIPv4 { get; }
	public static Boolean SupportsIPv6 { get; }
	public static Boolean OSSupportsIPv6 { get; }
	public IntPtr Handle { get; }
	public AddressFamily AddressFamily { get; }
	public SocketType SocketType { get; }
	public ProtocolType ProtocolType { get; }
	public Int32 ReceiveTimeout { set; }
	public Int32 SendTimeout { set; }
	public Boolean DontFragment { set; }
	public Boolean DualMode { get; set; }
	private Boolean IsDualMode { get; }
	private static Object InternalSyncObject { get; }
	internal Boolean CleanedUp { get; }
	public Int32 Available { get; }
	public EndPoint LocalEndPoint { get; }
	public Boolean Blocking { get; set; }
	public Boolean Connected { get; }
	public Boolean NoDelay { set; }
	public EndPoint RemoteEndPoint { get; }
	internal static Int32 FamilyHint { get; }

	// Methods

	// RVA: 0xFFFFFFFF7238127C
	public Void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0xFFFFFFFF75B6E530
	public static Boolean get_SupportsIPv4() { }

	// RVA: 0xFFFFFFFF75B6E57C
	public static Boolean get_OSSupportsIPv4() { }

	// RVA: 0xFFFFFFFF75B6E5C8
	public static Boolean get_SupportsIPv6() { }

	// RVA: 0xFFFFFFFF75B6E614
	public static Boolean get_OSSupportsIPv6() { }

	// RVA: 0xFFFFFFFF75B6E660
	public IntPtr get_Handle() { }

	// RVA: 0xFFFFFFFF75B6E680
	public AddressFamily get_AddressFamily() { }

	// RVA: 0xFFFFFFFF75B6E688
	public SocketType get_SocketType() { }

	// RVA: 0xFFFFFFFF75B6E690
	public ProtocolType get_ProtocolType() { }

	// RVA: 0xFFFFFFFF72381838
	public Void set_ReceiveTimeout(Int32 value) { }

	// RVA: 0xFFFFFFFF72381A14
	public Void set_SendTimeout(Int32 value) { }

	// RVA: 0xFFFFFFFF72381AAC
	public Void set_DontFragment(Boolean value) { }

	// RVA: 0xFFFFFFFF75B6E698
	public Boolean get_DualMode() { }

	// RVA: 0xFFFFFFFF75B6E8A4
	public Void set_DualMode(Boolean value) { }

	// RVA: 0xFFFFFFFF75B6E93C
	private Boolean get_IsDualMode() { }

	// RVA: 0xFFFFFFFF75B6E954
	internal Boolean CanTryAddressFamily(AddressFamily family) { }

	// RVA: 0xFFFFFFFF75B6E98C
	public Int32 Send(Byte[] buffer, Int32 size, SocketFlags socketFlags) { }

	// RVA: 0xFFFFFFFF75B6E99C
	public Int32 Send(IList<T0> buffers, SocketFlags socketFlags) { }

	// RVA: 0xFFFFFFFF72381B10
	public Int32 Send(Byte[] buffer, Int32 offset, Int32 size, SocketFlags socketFlags) { }

	// RVA: 0xFFFFFFFF72381DD8
	public Int32 SendTo(Byte[] buffer, Int32 size, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0xFFFFFFFF75B6EFCC
	public Int32 Receive(Byte[] buffer, Int32 offset, Int32 size, SocketFlags socketFlags) { }

	// RVA: 0xFFFFFFFF723821AC
	public Int32 Receive(IList<T0> buffers, SocketFlags socketFlags) { }

	// RVA: 0xFFFFFFFF72382B88
	public Int32 ReceiveFrom(Byte[] buffer, Int32 size, SocketFlags socketFlags, ref EndPoint remoteEP) { }

	// RVA: 0xFFFFFFFF75B6F028
	public Int32 ReceiveFrom(Byte[] buffer, SocketFlags socketFlags, ref EndPoint remoteEP) { }

	// RVA: 0xFFFFFFFF75B6F068
	public Int32 IOControl(IOControlCode ioControlCode, Byte[] optionInValue, Byte[] optionOutValue) { }

	// RVA: 0xFFFFFFFF75B6E444
	public Void SetIPProtectionLevel(IPProtectionLevel level) { }

	// RVA: 0xFFFFFFFF75B6F1D4
	public IAsyncResult BeginConnect(IPAddress address, Int32 port, AsyncCallback requestCallback, Object state) { }

	// RVA: 0xFFFFFFFF72382D58
	public IAsyncResult BeginSend(Byte[] buffer, Int32 offset, Int32 size, SocketFlags socketFlags, AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF72383080
	public Int32 EndSend(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF72383244
	public IAsyncResult BeginReceive(Byte[] buffer, Int32 offset, Int32 size, SocketFlags socketFlags, AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF72383504
	public Int32 EndReceive(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B6F50C
	private static Object get_InternalSyncObject() { }

	// RVA: 0xFFFFFFFF75B6F3BC
	internal Boolean get_CleanedUp() { }

	// RVA: 0xFFFFFFFF72381574
	internal static Void InitializeSockets() { }

	// RVA: 0xFFFFFFFF723836C8
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75B6F5C0
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75B6F638
	internal Void InternalShutdown(SocketShutdown how) { }

	// RVA: 0xFFFFFFFF75B6F780
	internal Void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, Int32 optionValue, Boolean silent) { }

	// RVA: 0xFFFFFFFF75B6F8C0
	internal Void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	// RVA: 0xFFFFFFFF72381754
	private Void SocketDefaults() { }

	// RVA: 0xFFFFFFFF75B6E3F4
	private IntPtr Socket_internal(AddressFamily family, SocketType type, ProtocolType proto, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B6F9C8
	public Int32 get_Available() { }

	// RVA: 0xFFFFFFFF75B6FA5C
	private static Int32 Available_internal(SafeSocketHandle safeHandle, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B6FB4C
	private static Int32 Available_internal(IntPtr socket, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B6FB50
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0xFFFFFFFF75B6FC48
	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, Int32 family, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B6FD40
	private static SocketAddress LocalEndPoint_internal(IntPtr socket, Int32 family, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B6FD44
	public Boolean get_Blocking() { }

	// RVA: 0xFFFFFFFF75B6FD4C
	public Void set_Blocking(Boolean value) { }

	// RVA: 0xFFFFFFFF75B6FDF0
	private static Void Blocking_internal(SafeSocketHandle safeHandle, Boolean block, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B6E354
	internal static Void Blocking_internal(IntPtr socket, Boolean block, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B6FECC
	public Boolean get_Connected() { }

	// RVA: 0xFFFFFFFF7238382C
	public Void set_NoDelay(Boolean value) { }

	// RVA: 0xFFFFFFFF75B6FED4
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0xFFFFFFFF75B6FFC8
	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, Int32 family, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B700BC
	private static SocketAddress RemoteEndPoint_internal(IntPtr socket, Int32 family, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B700C0
	public static Void Select(IList checkRead, IList checkWrite, IList checkError, Int32 microSeconds) { }

	// RVA: 0xFFFFFFFF75B70700
	private static Void AddSockets(List<T0> sockets, IList list, String name) { }

	// RVA: 0xFFFFFFFF75B70A28
	private static Void Select_internal(ref Socket[] sockets, Int32 microSeconds, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B70A2C
	public Boolean Poll(Int32 microSeconds, SelectMode mode) { }

	// RVA: 0xFFFFFFFF75B70B74
	private static Boolean Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, Int32 timeout, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B70C7C
	private static Boolean Poll_internal(IntPtr socket, SelectMode mode, Int32 timeout, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B70C80
	public Socket Accept() { }

	// RVA: 0xFFFFFFFF75B70E9C
	internal Void Accept(Socket acceptSocket) { }

	// RVA: 0xFFFFFFFF75B70FD8
	public Socket EndAccept(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B71004
	public Socket EndAccept(out Byte[] buffer, out Int32 bytesTransferred, IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B70DBC
	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out Int32 error, Boolean blocking) { }

	// RVA: 0xFFFFFFFF75B710E0
	private static IntPtr Accept_internal(IntPtr sock, out Int32 error, Boolean blocking) { }

	// RVA: 0xFFFFFFFF75B710E4
	public Void Bind(EndPoint localEP) { }

	// RVA: 0xFFFFFFFF75B712D4
	private static Void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B713B0
	private static Void Bind_internal(IntPtr sock, SocketAddress sa, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B713B4
	public Void Listen(Int32 backlog) { }

	// RVA: 0xFFFFFFFF75B71478
	private static Void Listen_internal(SafeSocketHandle safeHandle, Int32 backlog, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B71554
	private static Void Listen_internal(IntPtr sock, Int32 backlog, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B71558
	public Void Connect(EndPoint remoteEP) { }

	// RVA: 0xFFFFFFFF75B71920
	public IAsyncResult BeginConnect(String host, Int32 port, AsyncCallback requestCallback, Object state) { }

	// RVA: 0xFFFFFFFF75B6F3CC
	public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75B71A48
	public IAsyncResult BeginConnect(IPAddress[] addresses, Int32 port, AsyncCallback requestCallback, Object state) { }

	// RVA: 0xFFFFFFFF75B71FE4
	private static Void BeginMConnect(SocketAsyncResult sockares) { }

	// RVA: 0xFFFFFFFF75B71C6C
	private static Void BeginSConnect(SocketAsyncResult sockares) { }

	// RVA: 0xFFFFFFFF75B721F4
	public Void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B71848
	private static Void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out Int32 error, Boolean blocking) { }

	// RVA: 0xFFFFFFFF75B72294
	private static Void Connect_internal(IntPtr sock, SocketAddress sa, out Int32 error, Boolean blocking) { }

	// RVA: 0xFFFFFFFF75B72298
	public Void Disconnect(Boolean reuseSocket) { }

	// RVA: 0xFFFFFFFF75B72474
	public Void EndDisconnect(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B7239C
	private static Void Disconnect_internal(SafeSocketHandle safeHandle, Boolean reuse, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B72514
	private static Void Disconnect_internal(IntPtr sock, Boolean reuse, out Int32 error) { }

	// RVA: 0xFFFFFFFF72382028
	public Int32 Receive(Byte[] buffer, Int32 offset, Int32 size, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0xFFFFFFFF723822E8
	public Int32 Receive(IList<T0> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0xFFFFFFFF723832B0
	public IAsyncResult BeginReceive(Byte[] buffer, Int32 offset, Int32 size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF72383560
	public Int32 EndReceive(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0xFFFFFFFF75B72518
	private static Int32 Receive_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, Int32 count, SocketFlags flags, out Int32 error, Boolean blocking) { }

	// RVA: 0xFFFFFFFF75B7264C
	private static Int32 Receive_internal(IntPtr sock, WSABUF* bufarray, Int32 count, SocketFlags flags, out Int32 error, Boolean blocking) { }

	// RVA: 0xFFFFFFFF72383C9C
	private static Int32 Receive_internal(SafeSocketHandle safeHandle, Byte* buffer, Int32 count, SocketFlags flags, out Int32 error, Boolean blocking) { }

	// RVA: 0xFFFFFFFF75B72650
	private static Int32 Receive_internal(IntPtr sock, Byte* buffer, Int32 count, SocketFlags flags, out Int32 error, Boolean blocking) { }

	// RVA: 0xFFFFFFFF72382B9C
	public Int32 ReceiveFrom(Byte[] buffer, Int32 offset, Int32 size, SocketFlags socketFlags, ref EndPoint remoteEP) { }

	// RVA: 0xFFFFFFFF72383EF0
	internal Int32 ReceiveFrom(Byte[] buffer, Int32 offset, Int32 size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	// RVA: 0xFFFFFFFF75B72654
	public IAsyncResult BeginReceiveFrom(Byte[] buffer, Int32 offset, Int32 size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75B72834
	public Int32 EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint) { }

	// RVA: 0xFFFFFFFF72384084
	private static Int32 ReceiveFrom_internal(SafeSocketHandle safeHandle, Byte* buffer, Int32 count, SocketFlags flags, ref SocketAddress sockaddr, out Int32 error, Boolean blocking) { }

	// RVA: 0xFFFFFFFF75B7294C
	private static Int32 ReceiveFrom_internal(IntPtr sock, Byte* buffer, Int32 count, SocketFlags flags, ref SocketAddress sockaddr, out Int32 error, Boolean blocking) { }

	// RVA: 0xFFFFFFFF72381C1C
	public Int32 Send(Byte[] buffer, Int32 offset, Int32 size, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0xFFFFFFFF75B6EA38
	public Int32 Send(IList<T0> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0xFFFFFFFF72382DC4
	public IAsyncResult BeginSend(Byte[] buffer, Int32 offset, Int32 size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF72384264
	private static Void BeginSendCallback(SocketAsyncResult sockares, Int32 sent_so_far) { }

	// RVA: 0xFFFFFFFF723830DC
	public Int32 EndSend(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0xFFFFFFFF75B72950
	private static Int32 Send_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, Int32 count, SocketFlags flags, out Int32 error, Boolean blocking) { }

	// RVA: 0xFFFFFFFF75B72A80
	private static Int32 Send_internal(IntPtr sock, WSABUF* bufarray, Int32 count, SocketFlags flags, out Int32 error, Boolean blocking) { }

	// RVA: 0xFFFFFFFF72384178
	private static Int32 Send_internal(SafeSocketHandle safeHandle, Byte* buffer, Int32 count, SocketFlags flags, out Int32 error, Boolean blocking) { }

	// RVA: 0xFFFFFFFF75B72A84
	private static Int32 Send_internal(IntPtr sock, Byte* buffer, Int32 count, SocketFlags flags, out Int32 error, Boolean blocking) { }

	// RVA: 0xFFFFFFFF72381DEC
	public Int32 SendTo(Byte[] buffer, Int32 offset, Int32 size, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0xFFFFFFFF75B72A88
	public IAsyncResult BeginSendTo(Byte[] buffer, Int32 offset, Int32 size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75B72C78
	private static Void BeginSendToCallback(SocketAsyncResult sockares, Int32 sent_so_far) { }

	// RVA: 0xFFFFFFFF75B72E8C
	public Int32 EndSendTo(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF723844D4
	private static Int32 SendTo_internal(SafeSocketHandle safeHandle, Byte* buffer, Int32 count, SocketFlags flags, SocketAddress sa, out Int32 error, Boolean blocking) { }

	// RVA: 0xFFFFFFFF75B72F34
	private static Int32 SendTo_internal(IntPtr sock, Byte* buffer, Int32 count, SocketFlags flags, SocketAddress sa, out Int32 error, Boolean blocking) { }

	// RVA: 0xFFFFFFFF75B6E75C
	public Object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	// RVA: 0xFFFFFFFF75B72F38
	private static Void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out Object obj_val, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B7302C
	private static Void GetSocketOption_obj_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out Object obj_val, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B73030
	public Void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, Boolean optionValue) { }

	// RVA: 0xFFFFFFFF723818D0
	public Void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, Int32 optionValue) { }

	// RVA: 0xFFFFFFFF72383720
	private static Void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, Object obj_val, Byte[] byte_val, Int32 int_val, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B73034
	private static Void SetSocketOption_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, Object obj_val, Byte[] byte_val, Int32 int_val, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B6F06C
	public Int32 IOControl(Int32 ioControlCode, Byte[] optionInValue, Byte[] optionOutValue) { }

	// RVA: 0xFFFFFFFF75B73038
	private static Int32 IOControl_internal(SafeSocketHandle safeHandle, Int32 ioctl_code, Byte[] input, Byte[] output, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B73144
	private static Int32 IOControl_internal(IntPtr sock, Int32 ioctl_code, Byte[] input, Byte[] output, out Int32 error) { }

	// RVA: 0xFFFFFFFF7238479C
	public Void Close() { }

	// RVA: 0xFFFFFFFF75B73148
	public Void Close(Int32 timeout) { }

	// RVA: 0xFFFFFFFF75B6E360
	internal static Void Close_internal(IntPtr socket, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B73150
	public Void Shutdown(SocketShutdown how) { }

	// RVA: 0xFFFFFFFF75B6F6A4
	private static Void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out Int32 error) { }

	// RVA: 0xFFFFFFFF75B6E358
	internal static Void Shutdown_internal(IntPtr socket, SocketShutdown how, out Int32 error) { }

	// RVA: 0xFFFFFFFF72384814
	protected virtual Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF72384890
	private Void Linger(IntPtr handle) { }

	// RVA: 0xFFFFFFFF723838EC
	private Void ThrowIfDisposedAndClosed() { }

	// RVA: 0xFFFFFFFF72383B78
	private Void ThrowIfBufferNull(Byte[] buffer) { }

	// RVA: 0xFFFFFFFF72383BBC
	private Void ThrowIfBufferOutOfRange(Byte[] buffer, Int32 offset, Int32 size) { }

	// RVA: 0xFFFFFFFF7238396C
	private Void ThrowIfUdp() { }

	// RVA: 0xFFFFFFFF723839B8
	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, String methodName, String argName) { }

	// RVA: 0xFFFFFFFF72383D88
	private Void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	// RVA: 0xFFFFFFFF75B7122C
	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	// RVA: 0xFFFFFFFF75B6E35C
	internal static Void cancel_blocking_socket_operation(Thread thread) { }

	// RVA: 0xFFFFFFFF75B73220
	internal static Int32 get_FamilyHint() { }

	// RVA: 0xFFFFFFFF75B73278
	private static Boolean IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0xFFFFFFFF75B6F584
	private static Boolean IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0xFFFFFFFF75B7327C
	private static Void .cctor() { }

}

// Namespace: 
private struct WSABUF
{
	// Fields
	public Int32 len; // 0x10
	public IntPtr buf; // 0x18
}

// Namespace: 
private sealed class <>c
{
	// Fields
	public static readonly <>c <>9; // 0x0
	public static IOAsyncCallback <>9__241_0; // 0x8
	public static IOAsyncCallback <>9__253_0; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75B7374C
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75B73794
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF723849AC
	internal Void <BeginSend>b__241_0(IOAsyncResult s) { }

	// RVA: 0xFFFFFFFF75B73798
	internal Void <BeginSendTo>b__253_0(IOAsyncResult s) { }

	// RVA: 0xFFFFFFFF75B737F8
	internal Void <.cctor>b__309_0(IAsyncResult ares) { }

	// RVA: 0xFFFFFFFF75B73B10
	internal Void <.cctor>b__309_1(IOAsyncResult ares) { }

	// RVA: 0xFFFFFFFF75B73C7C
	internal Void <.cctor>b__309_2(IOAsyncResult ares) { }

	// RVA: 0xFFFFFFFF75B73F14
	internal Void <.cctor>b__309_3(IAsyncResult ares) { }

	// RVA: 0xFFFFFFFF75B7416C
	internal Void <.cctor>b__309_4(IOAsyncResult ares) { }

	// RVA: 0xFFFFFFFF75B743F4
	internal Void <.cctor>b__309_5(IAsyncResult ares) { }

	// RVA: 0xFFFFFFFF75B7464C
	internal Void <.cctor>b__309_6(IOAsyncResult ares) { }

	// RVA: 0xFFFFFFFF75B7491C
	internal Void <.cctor>b__309_7(IAsyncResult ares) { }

	// RVA: 0xFFFFFFFF72384A14
	internal Void <.cctor>b__309_8(IOAsyncResult ares) { }

	// RVA: 0xFFFFFFFF75B74B80
	internal Void <.cctor>b__309_9(IOAsyncResult ares) { }

	// RVA: 0xFFFFFFFF75B74D00
	internal Void <.cctor>b__309_10(IAsyncResult ares) { }

	// RVA: 0xFFFFFFFF75B74F68
	internal Void <.cctor>b__309_11(IOAsyncResult ares) { }

	// RVA: 0xFFFFFFFF75B75200
	internal Void <.cctor>b__309_12(IAsyncResult ares) { }

	// RVA: 0xFFFFFFFF75B75464
	internal Void <.cctor>b__309_13(IOAsyncResult ares) { }

	// RVA: 0xFFFFFFFF75B755E4
	internal Void <.cctor>b__309_14(IAsyncResult ares) { }

}

// Namespace: 
private sealed class <>c__DisplayClass242_0
{
	// Fields
	public Int32 sent_so_far; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75B72A38
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B75848
	internal Void <BeginSendCallback>b__0(IOAsyncResult s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass254_0
{
	// Fields
	public Int32 sent_so_far; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75B72E88
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B758B0
	internal Void <BeginSendToCallback>b__0(IOAsyncResult s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass298_0
{
	// Fields
	public Socket <>4__this; // 0x10
	public IOSelectorJob job; // 0x18
	public IntPtr handle; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75B7321C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF72384BD8
	internal Void <QueueIOSelectorJob>b__0(Task t) { }

}

// Namespace: System.Net.Sockets
public enum SocketError
{
	// Fields
	public Int32 value__; // 0x10
	public const SocketError Success = 0;
	public const SocketError SocketError = 4294967295;
	public const SocketError Interrupted = 10004;
	public const SocketError AccessDenied = 10013;
	public const SocketError Fault = 10014;
	public const SocketError InvalidArgument = 10022;
	public const SocketError TooManyOpenSockets = 10024;
	public const SocketError WouldBlock = 10035;
	public const SocketError InProgress = 10036;
	public const SocketError AlreadyInProgress = 10037;
	public const SocketError NotSocket = 10038;
	public const SocketError DestinationAddressRequired = 10039;
	public const SocketError MessageSize = 10040;
	public const SocketError ProtocolType = 10041;
	public const SocketError ProtocolOption = 10042;
	public const SocketError ProtocolNotSupported = 10043;
	public const SocketError SocketNotSupported = 10044;
	public const SocketError OperationNotSupported = 10045;
	public const SocketError ProtocolFamilyNotSupported = 10046;
	public const SocketError AddressFamilyNotSupported = 10047;
	public const SocketError AddressAlreadyInUse = 10048;
	public const SocketError AddressNotAvailable = 10049;
	public const SocketError NetworkDown = 10050;
	public const SocketError NetworkUnreachable = 10051;
	public const SocketError NetworkReset = 10052;
	public const SocketError ConnectionAborted = 10053;
	public const SocketError ConnectionReset = 10054;
	public const SocketError NoBufferSpaceAvailable = 10055;
	public const SocketError IsConnected = 10056;
	public const SocketError NotConnected = 10057;
	public const SocketError Shutdown = 10058;
	public const SocketError TimedOut = 10060;
	public const SocketError ConnectionRefused = 10061;
	public const SocketError HostDown = 10064;
	public const SocketError HostUnreachable = 10065;
	public const SocketError ProcessLimit = 10067;
	public const SocketError SystemNotReady = 10091;
	public const SocketError VersionNotSupported = 10092;
	public const SocketError NotInitialized = 10093;
	public const SocketError Disconnecting = 10101;
	public const SocketError TypeNotFound = 10109;
	public const SocketError HostNotFound = 11001;
	public const SocketError TryAgain = 11002;
	public const SocketError NoRecovery = 11003;
	public const SocketError NoData = 11004;
	public const SocketError IOPending = 997;
	public const SocketError OperationAborted = 995;
}

// Namespace: System.Net.Sockets
public enum SocketFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const SocketFlags None = 0;
	public const SocketFlags OutOfBand = 1;
	public const SocketFlags Peek = 2;
	public const SocketFlags DontRoute = 4;
	public const SocketFlags MaxIOVectorLength = 16;
	public const SocketFlags Truncated = 256;
	public const SocketFlags ControlDataTruncated = 512;
	public const SocketFlags Broadcast = 1024;
	public const SocketFlags Multicast = 2048;
	public const SocketFlags Partial = 32768;
}

// Namespace: System.Net.Sockets
public enum SocketOptionLevel
{
	// Fields
	public Int32 value__; // 0x10
	public const SocketOptionLevel Socket = 65535;
	public const SocketOptionLevel IP = 0;
	public const SocketOptionLevel IPv6 = 41;
	public const SocketOptionLevel Tcp = 6;
	public const SocketOptionLevel Udp = 17;
}

// Namespace: System.Net.Sockets
public enum SocketOptionName
{
	// Fields
	public Int32 value__; // 0x10
	public const SocketOptionName Debug = 1;
	public const SocketOptionName AcceptConnection = 2;
	public const SocketOptionName ReuseAddress = 4;
	public const SocketOptionName KeepAlive = 8;
	public const SocketOptionName DontRoute = 16;
	public const SocketOptionName Broadcast = 32;
	public const SocketOptionName UseLoopback = 64;
	public const SocketOptionName Linger = 128;
	public const SocketOptionName OutOfBandInline = 256;
	public const SocketOptionName DontLinger = 4294967167;
	public const SocketOptionName ExclusiveAddressUse = 4294967291;
	public const SocketOptionName SendBuffer = 4097;
	public const SocketOptionName ReceiveBuffer = 4098;
	public const SocketOptionName SendLowWater = 4099;
	public const SocketOptionName ReceiveLowWater = 4100;
	public const SocketOptionName SendTimeout = 4101;
	public const SocketOptionName ReceiveTimeout = 4102;
	public const SocketOptionName Error = 4103;
	public const SocketOptionName Type = 4104;
	public const SocketOptionName ReuseUnicastPort = 12295;
	public const SocketOptionName MaxConnections = 2147483647;
	public const SocketOptionName IPOptions = 1;
	public const SocketOptionName HeaderIncluded = 2;
	public const SocketOptionName TypeOfService = 3;
	public const SocketOptionName IpTimeToLive = 4;
	public const SocketOptionName MulticastInterface = 9;
	public const SocketOptionName MulticastTimeToLive = 10;
	public const SocketOptionName MulticastLoopback = 11;
	public const SocketOptionName AddMembership = 12;
	public const SocketOptionName DropMembership = 13;
	public const SocketOptionName DontFragment = 14;
	public const SocketOptionName AddSourceMembership = 15;
	public const SocketOptionName DropSourceMembership = 16;
	public const SocketOptionName BlockSource = 17;
	public const SocketOptionName UnblockSource = 18;
	public const SocketOptionName PacketInformation = 19;
	public const SocketOptionName HopLimit = 21;
	public const SocketOptionName IPProtectionLevel = 23;
	public const SocketOptionName IPv6Only = 27;
	public const SocketOptionName NoDelay = 1;
	public const SocketOptionName BsdUrgent = 2;
	public const SocketOptionName Expedited = 2;
	public const SocketOptionName NoChecksum = 1;
	public const SocketOptionName ChecksumCoverage = 20;
	public const SocketOptionName UpdateAcceptContext = 28683;
	public const SocketOptionName UpdateConnectContext = 28688;
}

// Namespace: System.Net.Sockets
public enum SocketShutdown
{
	// Fields
	public Int32 value__; // 0x10
	public const SocketShutdown Receive = 0;
	public const SocketShutdown Send = 1;
	public const SocketShutdown Both = 2;
}

// Namespace: System.Net.Sockets
public enum SocketType
{
	// Fields
	public Int32 value__; // 0x10
	public const SocketType Stream = 1;
	public const SocketType Dgram = 2;
	public const SocketType Raw = 3;
	public const SocketType Rdm = 4;
	public const SocketType Seqpacket = 5;
	public const SocketType Unknown = 4294967295;
}

// Namespace: System.Net.Sockets
public class TcpClient
{
	// Fields
	private Socket m_ClientSocket; // 0x10
	private Boolean m_Active; // 0x18
	private NetworkStream m_DataStream; // 0x20
	private AddressFamily m_Family; // 0x28
	private Boolean m_CleanedUp; // 0x2C

	// Properties
	public Socket Client { get; set; }
	public Boolean Connected { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B75FE8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B75FF0
	public Void .ctor(AddressFamily family) { }

	// RVA: 0xFFFFFFFF75B76190
	public Socket get_Client() { }

	// RVA: 0xFFFFFFFF75B76198
	public Void set_Client(Socket value) { }

	// RVA: 0xFFFFFFFF75B761D0
	public Boolean get_Connected() { }

	// RVA: 0xFFFFFFFF75B761F0
	public Void Connect(IPAddress address, Int32 port) { }

	// RVA: 0xFFFFFFFF75B76340
	public Void Connect(IPEndPoint remoteEP) { }

	// RVA: 0xFFFFFFFF75B76438
	public NetworkStream GetStream() { }

	// RVA: 0xFFFFFFFF75B76560
	public Void Close() { }

	// RVA: 0xFFFFFFFF75B765D8
	protected virtual Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75B76710
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75B76724
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75B76128
	private Void initialize() { }

}

// Namespace: System.Net.Sockets
public class UdpClient
{
	// Fields
	private const Int32 MaxUDPSize = 65536;
	private Socket m_ClientSocket; // 0x10
	private Boolean m_Active; // 0x18
	private Byte[] m_Buffer; // 0x20
	private AddressFamily m_Family; // 0x28
	private Boolean m_CleanedUp; // 0x2C
	private Boolean m_IsBroadcast; // 0x2D

	// Properties
	public Socket Client { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B7679C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B767A4
	public Void .ctor(AddressFamily family) { }

	// RVA: 0xFFFFFFFF75B76970
	public Void .ctor(Int32 port) { }

	// RVA: 0xFFFFFFFF75B76978
	public Void .ctor(Int32 port, AddressFamily family) { }

	// RVA: 0xFFFFFFFF75B76B78
	public Void .ctor(IPEndPoint localEP) { }

	// RVA: 0xFFFFFFFF75B76C8C
	public Socket get_Client() { }

	// RVA: 0xFFFFFFFF75B76C94
	public Void set_Client(Socket value) { }

	// RVA: 0xFFFFFFFF75B76CCC
	public Void Close() { }

	// RVA: 0xFFFFFFFF75B76CE0
	private Void FreeResources() { }

	// RVA: 0xFFFFFFFF75B76D50
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75B76D64
	protected virtual Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75B76DB4
	private Void CheckForBroadcast(IPAddress ipAddress) { }

	// RVA: 0xFFFFFFFF75B76E20
	public Int32 Send(Byte[] dgram, Int32 bytes, IPEndPoint endPoint) { }

	// RVA: 0xFFFFFFFF75B76FB4
	public IAsyncResult BeginSend(Byte[] datagram, Int32 bytes, IPEndPoint endPoint, AsyncCallback requestCallback, Object state) { }

	// RVA: 0xFFFFFFFF75B771B0
	public Byte[] Receive(ref IPEndPoint remoteEP) { }

	// RVA: 0xFFFFFFFF75B773AC
	public IAsyncResult BeginReceive(AsyncCallback requestCallback, Object state) { }

	// RVA: 0xFFFFFFFF75B774E4
	public Byte[] EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP) { }

	// RVA: 0xFFFFFFFF75B76908
	private Void createClientSocket() { }

}

// Namespace: System.Net.Sockets
internal sealed class SafeSocketHandle
{
	// Fields
	private List<T0> blocking_threads; // 0x20
	private Dictionary<T0, T1> threads_stacktraces; // 0x28
	private Boolean in_cleanup; // 0x30
	private const Int32 SOCKET_CLOSED = 10004;
	private const Int32 ABORT_RETRIES = 10;
	private static Boolean THROW_ON_ABORT_RETRIES; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF723807FC
	public Void .ctor(IntPtr preexistingHandle, Boolean ownsHandle) { }

	// RVA: 0xFFFFFFFF72380894
	protected override Boolean ReleaseHandle() { }

	// RVA: 0xFFFFFFFF72380D30
	public Void RegisterForBlockingSyscall() { }

	// RVA: 0xFFFFFFFF723810B8
	public Void UnRegisterForBlockingSyscall() { }

	// RVA: 0xFFFFFFFF75B6E3B4
	private static Void .cctor() { }

}

// Namespace: System.Net.Sockets
public class SocketAsyncEventArgs
{
	// Fields
	private Boolean disposed; // 0x10
	internal Int32 in_progress; // 0x14
	internal EndPoint remote_ep; // 0x18
	internal Socket current_socket; // 0x20
	private Socket <AcceptSocket>k__BackingField; // 0x28
	private Int32 <BytesTransferred>k__BackingField; // 0x30
	private SocketError <SocketError>k__BackingField; // 0x34
	private EventHandler<T0> Completed; // 0x38

	// Properties
	public Socket AcceptSocket { get; set; }
	internal Int32 BytesTransferred { set; }
	public SocketError SocketError { set; }

	// Methods

	// RVA: 0xFFFFFFFF75B75914
	public Socket get_AcceptSocket() { }

	// RVA: 0xFFFFFFFF75B7591C
	public Void set_AcceptSocket(Socket value) { }

	// RVA: 0xFFFFFFFF75B75954
	internal Void set_BytesTransferred(Int32 value) { }

	// RVA: 0xFFFFFFFF75B7595C
	public Void set_SocketError(SocketError value) { }

	// RVA: 0xFFFFFFFF75B75964
	private Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75B75978
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75B73AFC
	internal Void Complete() { }

	// RVA: 0xFFFFFFFF75B759C4
	protected virtual Void OnCompleted(SocketAsyncEventArgs e) { }

}

// Namespace: System.Net.Sockets
internal sealed class SocketAsyncResult
{
	// Fields
	public Socket socket; // 0x30
	public SocketOperation operation; // 0x38
	private Exception DelayedException; // 0x40
	public EndPoint EndPoint; // 0x48
	public Byte[] Buffer; // 0x50
	public Int32 Offset; // 0x58
	public Int32 Size; // 0x5C
	public SocketFlags SockFlags; // 0x60
	public Socket AcceptSocket; // 0x68
	public IPAddress[] Addresses; // 0x70
	public Int32 Port; // 0x78
	public IList<T0> Buffers; // 0x80
	public Boolean ReuseSocket; // 0x88
	public Int32 CurrentAddress; // 0x8C
	public Socket AcceptedSocket; // 0x90
	public Int32 Total; // 0x98
	internal Int32 error; // 0x9C
	public Int32 EndCalled; // 0xA0

	// Properties
	public IntPtr Handle { get; }
	public SocketError ErrorCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B721C4
	public IntPtr get_Handle() { }

	// RVA: 0xFFFFFFFF75B71C10
	public Void .ctor(Socket socket, AsyncCallback callback, Object state, SocketOperation operation) { }

	// RVA: 0xFFFFFFFF75B72600
	public SocketError get_ErrorCode() { }

	// RVA: 0xFFFFFFFF72383AEC
	public Void CheckIfThrowDelayedException() { }

	// RVA: 0xFFFFFFFF75B75A44
	internal override Void CompleteDisposed() { }

	// RVA: 0xFFFFFFFF723845C8
	public Void Complete() { }

	// RVA: 0xFFFFFFFF75B721BC
	public Void Complete(Boolean synch) { }

	// RVA: 0xFFFFFFFF75B72A78
	public Void Complete(Int32 total) { }

	// RVA: 0xFFFFFFFF75B72170
	public Void Complete(Exception e, Boolean synch) { }

	// RVA: 0xFFFFFFFF75B72A3C
	public Void Complete(Exception e) { }

	// RVA: 0xFFFFFFFF75B73C40
	public Void Complete(Socket s) { }

	// RVA: 0xFFFFFFFF75B73EC8
	public Void Complete(Socket s, Int32 total) { }

}

// Namespace: 
private sealed class <>c
{
	// Fields
	public static readonly <>c <>9; // 0x0
	public static WaitCallback <>9__27_0; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75B75A48
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75B75A90
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF72384C1C
	internal Void <Complete>b__27_0(Object state) { }

}

// Namespace: System.Net.Sockets
internal enum SocketOperation
{
	// Fields
	public Int32 value__; // 0x10
	public const SocketOperation Accept = 0;
	public const SocketOperation Connect = 1;
	public const SocketOperation Receive = 2;
	public const SocketOperation ReceiveFrom = 3;
	public const SocketOperation Send = 4;
	public const SocketOperation SendTo = 5;
	public const SocketOperation RecvJustCallback = 6;
	public const SocketOperation SendJustCallback = 7;
	public const SocketOperation Disconnect = 8;
	public const SocketOperation AcceptReceive = 9;
	public const SocketOperation ReceiveGeneric = 10;
	public const SocketOperation SendGeneric = 11;
}

// Namespace: System.Net.Sockets
public static class SocketTaskExtensions
{
	// Methods

	// RVA: 0xFFFFFFFF75B75BEC
	public static Task ConnectAsync(Socket socket, IPAddress address, Int32 port) { }

}

// Namespace: 
private sealed class <>c
{
	// Fields
	public static readonly <>c <>9; // 0x0
	public static Func<T0, T1, T2, T3, T4> <>9__3_0; // 0x8
	public static Action<T0> <>9__3_1; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75B75E4C
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75B75EC4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B75EC8
	internal IAsyncResult <ConnectAsync>b__3_0(IPAddress targetAddress, Int32 targetPort, AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75B75F20
	internal Void <ConnectAsync>b__3_1(IAsyncResult asyncResult) { }

}

// Namespace: System.Net.Security
public abstract class AuthenticatedStream
{
	// Fields
	private Stream _InnerStream; // 0x28
	private Boolean _LeaveStreamOpen; // 0x30

	// Properties
	protected Stream InnerStream { get; }
	public abstract Boolean IsAuthenticated { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B6A374
	protected Void .ctor(Stream innerStream, Boolean leaveInnerStreamOpen) { }

	// RVA: 0xFFFFFFFF75B6A4C8
	protected Stream get_InnerStream() { }

	// RVA: 0xFFFFFFFF75B6A4D0
	protected override Void Dispose(Boolean disposing) { }

	// RVA: -1
	public abstract Boolean get_IsAuthenticated() { }

}

// Namespace: System.Net.Security
public enum AuthenticationLevel
{
	// Fields
	public Int32 value__; // 0x10
	public const AuthenticationLevel None = 0;
	public const AuthenticationLevel MutualAuthRequested = 1;
	public const AuthenticationLevel MutualAuthRequired = 2;
}

// Namespace: System.Net.Security
public sealed class RemoteCertificateValidationCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75B6AA50
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B6AA94
	public virtual Boolean Invoke(Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	// RVA: 0xFFFFFFFF75B6AEA4
	public virtual IAsyncResult BeginInvoke(Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B6AF88
	public virtual Boolean EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Net.Security
public enum SslPolicyErrors
{
	// Fields
	public Int32 value__; // 0x10
	public const SslPolicyErrors None = 0;
	public const SslPolicyErrors RemoteCertificateNotAvailable = 1;
	public const SslPolicyErrors RemoteCertificateNameMismatch = 2;
	public const SslPolicyErrors RemoteCertificateChainErrors = 4;
}

// Namespace: System.Net.Security
internal sealed class LocalCertSelectionCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75B6A590
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75B6A5D4
	public virtual X509Certificate Invoke(String targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

	// RVA: 0xFFFFFFFF75B6A9E4
	public virtual IAsyncResult BeginInvoke(String targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75B6AA44
	public virtual X509Certificate EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Net.Security
public class SslStream
{
	// Fields
	private MonoTlsProvider provider; // 0x38
	private IMonoSslStream impl; // 0x40

	// Properties
	internal IMonoSslStream Impl { get; }
	public override Boolean IsAuthenticated { get; }
	public override Boolean CanSeek { get; }
	public override Boolean CanRead { get; }
	public override Boolean CanWrite { get; }
	public override Int32 ReadTimeout { get; set; }
	public override Int32 WriteTimeout { get; }
	public override Int64 Length { get; }
	public override Int64 Position { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B6AFB4
	internal IMonoSslStream get_Impl() { }

	// RVA: 0xFFFFFFFF75B6B058
	private static MonoTlsProvider GetProvider() { }

	// RVA: 0xFFFFFFFF75B6B060
	public Void .ctor(Stream innerStream) { }

	// RVA: 0xFFFFFFFF75B6B068
	public Void .ctor(Stream innerStream, Boolean leaveInnerStreamOpen) { }

	// RVA: 0xFFFFFFFF75B6B108
	internal Void .ctor(Stream innerStream, Boolean leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0xFFFFFFFF75B6B1B4
	internal static IMonoSslStream CreateMonoSslStream(Stream innerStream, Boolean leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0xFFFFFFFF75B6B24C
	public virtual Task AuthenticateAsClientAsync(String targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, Boolean checkCertificateRevocation) { }

	// RVA: 0xFFFFFFFF75B6B344
	public override Boolean get_IsAuthenticated() { }

	// RVA: 0xFFFFFFFF75B6B40C
	public override Boolean get_CanSeek() { }

	// RVA: 0xFFFFFFFF75B6B414
	public override Boolean get_CanRead() { }

	// RVA: 0xFFFFFFFF75B6B4E4
	public override Boolean get_CanWrite() { }

	// RVA: 0xFFFFFFFF75B6B5B4
	public override Int32 get_ReadTimeout() { }

	// RVA: 0xFFFFFFFF75B6B67C
	public override Void set_ReadTimeout(Int32 value) { }

	// RVA: 0xFFFFFFFF75B6B74C
	public override Int32 get_WriteTimeout() { }

	// RVA: 0xFFFFFFFF75B6B814
	public override Int64 get_Length() { }

	// RVA: 0xFFFFFFFF75B6B8DC
	public override Int64 get_Position() { }

	// RVA: 0xFFFFFFFF75B6B9A4
	public override Void set_Position(Int64 value) { }

	// RVA: 0xFFFFFFFF75B6BA10
	public override Void SetLength(Int64 value) { }

	// RVA: 0xFFFFFFFF75B6BAE0
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xFFFFFFFF75B6BB4C
	public override Void Flush() { }

	// RVA: 0xFFFFFFFF75B6AFD8
	private Void CheckDisposed() { }

	// RVA: 0xFFFFFFFF75B6BB74
	protected override Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75B6BC78
	public override Int32 Read(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF75B6BD60
	public override Void Write(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF75B6BE48
	public override IAsyncResult BeginRead(Byte[] buffer, Int32 offset, Int32 count, AsyncCallback asyncCallback, Object asyncState) { }

	// RVA: 0xFFFFFFFF75B6BF48
	public override Int32 EndRead(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75B6C018
	public override IAsyncResult BeginWrite(Byte[] buffer, Int32 offset, Int32 count, AsyncCallback asyncCallback, Object asyncState) { }

	// RVA: 0xFFFFFFFF75B6C118
	public override Void EndWrite(IAsyncResult asyncResult) { }

}

// Namespace: System.Net.NetworkInformation
public abstract class IPGlobalProperties
{
	// Fields
	private static readonly Boolean <PlatformNeedsLibCWorkaround>k__BackingField; // 0x0

	// Properties
	private static Boolean PlatformNeedsLibCWorkaround { get; }
	public abstract String DomainName { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B67A68
	private static Boolean get_PlatformNeedsLibCWorkaround() { }

	// RVA: 0xFFFFFFFF75B67AC0
	public static IPGlobalProperties GetIPGlobalProperties() { }

	// RVA: 0xFFFFFFFF75B67D70
	internal static IPGlobalProperties InternalGetIPGlobalProperties() { }

	// RVA: -1
	public abstract IPEndPoint[] GetActiveUdpListeners() { }

	// RVA: -1
	public abstract IPEndPoint[] GetActiveTcpListeners() { }

	// RVA: -1
	public abstract String get_DomainName() { }

	// RVA: 0xFFFFFFFF75B67A64
	protected Void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
public class NetworkInformationException
{
	// Methods

	// RVA: 0xFFFFFFFF75B679F4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B6837C
	protected Void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

// Namespace: System.Net.NetworkInformation
public enum NetworkInterfaceComponent
{
	// Fields
	public Int32 value__; // 0x10
	public const NetworkInterfaceComponent IPv4 = 0;
	public const NetworkInterfaceComponent IPv6 = 1;
}

// Namespace: System.Net.NetworkInformation
public enum TcpState
{
	// Fields
	public Int32 value__; // 0x10
	public const TcpState Unknown = 0;
	public const TcpState Closed = 1;
	public const TcpState Listen = 2;
	public const TcpState SynSent = 3;
	public const TcpState SynReceived = 4;
	public const TcpState Established = 5;
	public const TcpState FinWait1 = 6;
	public const TcpState FinWait2 = 7;
	public const TcpState CloseWait = 8;
	public const TcpState Closing = 9;
	public const TcpState LastAck = 10;
	public const TcpState TimeWait = 11;
	public const TcpState DeleteTcb = 12;
}

// Namespace: System.Net.NetworkInformation
public enum NetBiosNodeType
{
	// Fields
	public Int32 value__; // 0x10
	public const NetBiosNodeType Unknown = 0;
	public const NetBiosNodeType Broadcast = 1;
	public const NetBiosNodeType Peer2Peer = 2;
	public const NetBiosNodeType Mixed = 4;
	public const NetBiosNodeType Hybrid = 8;
}

// Namespace: System.Net.NetworkInformation
internal abstract class CommonUnixIPGlobalProperties
{
	// Properties
	public override String DomainName { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B67760
	private static extern Int32 getdomainname(Byte[] name, Int32 len) { }

	// RVA: 0xFFFFFFFF75B677F8
	public override String get_DomainName() { }

	// RVA: 0xFFFFFFFF75B67A60
	protected Void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
internal class UnixIPGlobalProperties
{
	// Methods

	// RVA: 0xFFFFFFFF75B683DC
	public override IPEndPoint[] GetActiveTcpListeners() { }

	// RVA: 0xFFFFFFFF75B68410
	public override IPEndPoint[] GetActiveUdpListeners() { }

	// RVA: 0xFFFFFFFF75B67D68
	public Void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
internal sealed class UnixNoLibCIPGlobalProperties
{
	// Properties
	public override String DomainName { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B68464
	public override String get_DomainName() { }

	// RVA: 0xFFFFFFFF75B67BA0
	public Void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
internal class MibIPGlobalProperties
{
	// Fields
	public readonly String StatisticsFile; // 0x10
	public readonly String StatisticsFileIPv6; // 0x18
	public readonly String TcpFile; // 0x20
	public readonly String Tcp6File; // 0x28
	public readonly String UdpFile; // 0x30
	public readonly String Udp6File; // 0x38
	private static readonly Char[] wsChars; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75B67BA4
	public Void .ctor(String procDir) { }

	// RVA: 0xFFFFFFFF75B67D74
	private Exception CreateException(String file, String msg) { }

	// RVA: 0xFFFFFFFF75B67E00
	private IPEndPoint[] GetLocalAddresses(List<T0> list) { }

	// RVA: 0xFFFFFFFF75B67F10
	private IPEndPoint ToEndpoint(String s) { }

	// RVA: 0xFFFFFFFF75B68064
	private Void GetRows(String file, List<T0> list) { }

	// RVA: 0xFFFFFFFF75B68278
	public override IPEndPoint[] GetActiveTcpListeners() { }

	// RVA: 0xFFFFFFFF75B682CC
	public override IPEndPoint[] GetActiveUdpListeners() { }

	// RVA: 0xFFFFFFFF75B68320
	private static Void .cctor() { }

}

// Namespace: System.Net.NetworkInformation
internal class Win32IPGlobalProperties
{
	// Properties
	public override String DomainName { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B68478
	private Void FillTcpTable(out List<T0> tab4, out List<T0> tab6) { }

	// RVA: 0xFFFFFFFF75B689D4
	private Boolean IsListenerState(TcpState state) { }

	// RVA: 0xFFFFFFFF75B689EC
	public override IPEndPoint[] GetActiveTcpListeners() { }

	// RVA: 0xFFFFFFFF75B68DA0
	public override IPEndPoint[] GetActiveUdpListeners() { }

	// RVA: 0xFFFFFFFF75B69384
	public override String get_DomainName() { }

	// RVA: 0xFFFFFFFF75B68890
	private static extern Int32 GetTcpTable(Byte[] pTcpTable, ref Int32 pdwSize, Boolean bOrder) { }

	// RVA: 0xFFFFFFFF75B68934
	private static extern Int32 GetTcp6Table(Byte[] TcpTable, ref Int32 SizePointer, Boolean Order) { }

	// RVA: 0xFFFFFFFF75B6917C
	private static extern Int32 GetUdpTable(Byte[] pUdpTable, ref Int32 pdwSize, Boolean bOrder) { }

	// RVA: 0xFFFFFFFF75B69270
	private static extern Int32 GetUdp6Table(Byte[] Udp6Table, ref Int32 SizePointer, Boolean Order) { }

	// RVA: 0xFFFFFFFF75B694F0
	private static extern UInt16 ntohs(UInt16 netshort) { }

	// RVA: 0xFFFFFFFF75B67D6C
	public Void .ctor() { }

}

// Namespace: 
private struct Win32_IN6_ADDR
{
	// Fields
	public Byte[] Bytes; // 0x10
}

// Namespace: 
private class Win32_MIB_TCPROW
{
	// Fields
	public TcpState State; // 0x10
	public UInt32 LocalAddr; // 0x14
	public UInt32 LocalPort; // 0x18
	public UInt32 RemoteAddr; // 0x1C
	public UInt32 RemotePort; // 0x20

	// Properties
	public IPEndPoint LocalEndPoint { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B68CDC
	public IPEndPoint get_LocalEndPoint() { }

	// RVA: 0xFFFFFFFF75B68930
	public Void .ctor() { }

}

// Namespace: 
private class Win32_MIB_TCP6ROW
{
	// Fields
	public TcpState State; // 0x10
	public Win32_IN6_ADDR LocalAddr; // 0x18
	public UInt32 LocalScopeId; // 0x20
	public UInt32 LocalPort; // 0x24
	public Win32_IN6_ADDR RemoteAddr; // 0x28
	public UInt32 RemoteScopeId; // 0x30
	public UInt32 RemotePort; // 0x34

	// Properties
	public IPEndPoint LocalEndPoint { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B68D2C
	public IPEndPoint get_LocalEndPoint() { }

	// RVA: 0xFFFFFFFF75B689D0
	public Void .ctor() { }

}

// Namespace: 
private class Win32_MIB_UDPROW
{
	// Fields
	public UInt32 LocalAddr; // 0x10
	public UInt32 LocalPort; // 0x14

	// Properties
	public IPEndPoint LocalEndPoint { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B69220
	public IPEndPoint get_LocalEndPoint() { }

	// RVA: 0xFFFFFFFF75B6921C
	public Void .ctor() { }

}

// Namespace: 
private class Win32_MIB_UDP6ROW
{
	// Fields
	public Win32_IN6_ADDR LocalAddr; // 0x10
	public UInt32 LocalScopeId; // 0x18
	public UInt32 LocalPort; // 0x1C

	// Properties
	public IPEndPoint LocalEndPoint { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B69310
	public IPEndPoint get_LocalEndPoint() { }

	// RVA: 0xFFFFFFFF75B6930C
	public Void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
internal class Win32NetworkInterface
{
	// Fields
	private static Win32_FIXED_INFO fixedInfo; // 0x0
	private static Boolean initialized; // 0x58

	// Properties
	public static Win32_FIXED_INFO FixedInfo { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B69570
	private static extern Int32 GetNetworkParams(IntPtr ptr, ref Int32 size) { }

	// RVA: 0xFFFFFFFF75B693A8
	public static Win32_FIXED_INFO get_FixedInfo() { }

}

// Namespace: System.Net.NetworkInformation
internal struct Win32_FIXED_INFO
{
	// Fields
	public String HostName; // 0x10
	public String DomainName; // 0x18
	public IntPtr CurrentDnsServer; // 0x20
	public Win32_IP_ADDR_STRING DnsServerList; // 0x28
	public NetBiosNodeType NodeType; // 0x48
	public String ScopeId; // 0x50
	public UInt32 EnableRouting; // 0x58
	public UInt32 EnableProxy; // 0x5C
	public UInt32 EnableDns; // 0x60
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_IP_ADDR_STRING
{
	// Fields
	public IntPtr Next; // 0x10
	public String IpAddress; // 0x18
	public String IpMask; // 0x20
	public UInt32 Context; // 0x28
}

// Namespace: System.Net.Configuration
internal sealed class DefaultProxySectionInternal
{
	// Fields
	private IWebProxy webProxy; // 0x10
	private static Object classSyncObject; // 0x0

	// Properties
	internal static Object ClassSyncObject { get; }
	internal IWebProxy WebProxy { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B44694
	private static IWebProxy GetDefaultProxy_UsingOldMonoCode() { }

	// RVA: 0xFFFFFFFF75B4469C
	private static IWebProxy GetSystemWebProxy() { }

	// RVA: 0xFFFFFFFF75B446A4
	internal static Object get_ClassSyncObject() { }

	// RVA: 0xFFFFFFFF75B44700
	internal static DefaultProxySectionInternal GetSection() { }

	// RVA: 0xFFFFFFFF75B447CC
	internal IWebProxy get_WebProxy() { }

	// RVA: 0xFFFFFFFF75B447C8
	public Void .ctor() { }

}

// Namespace: System.Net.Configuration
public enum UnicodeDecodingConformance
{
	// Fields
	public Int32 value__; // 0x10
	public const UnicodeDecodingConformance Auto = 0;
	public const UnicodeDecodingConformance Strict = 1;
	public const UnicodeDecodingConformance Compat = 2;
	public const UnicodeDecodingConformance Loose = 3;
}

// Namespace: System.Net.Configuration
public enum UnicodeEncodingConformance
{
	// Fields
	public Int32 value__; // 0x10
	public const UnicodeEncodingConformance Auto = 0;
	public const UnicodeEncodingConformance Strict = 1;
	public const UnicodeEncodingConformance Compat = 2;
}

// Namespace: System.Net.Configuration
internal sealed class SettingsSectionInternal
{
	// Fields
	private static readonly SettingsSectionInternal instance; // 0x0
	internal readonly Boolean HttpListenerUnescapeRequestUrl; // 0x10
	internal readonly IPProtectionLevel IPProtectionLevel; // 0x14

	// Properties
	internal static SettingsSectionInternal Section { get; }
	internal Boolean Ipv6Enabled { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B44AAC
	internal static SettingsSectionInternal get_Section() { }

	// RVA: 0xFFFFFFFF75B44AEC
	internal Boolean get_Ipv6Enabled() { }

	// RVA: 0xFFFFFFFF75B44AF4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B44B08
	private static Void .cctor() { }

}

// Namespace: System.Net.Cache
internal abstract class RequestCache
{
	// Fields
	internal static readonly Char[] LineSplits; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75B43C2C
	private static Void .cctor() { }

}

// Namespace: System.Net.Cache
internal class RequestCacheValidator
{
	// Methods

	// RVA: 0xFFFFFFFF75B43D24
	public Object CreateValidator() { }

}

// Namespace: System.Net.Cache
internal class RequestCacheBinding
{
	// Fields
	private RequestCache m_RequestCache; // 0x10
	private RequestCacheValidator m_CacheValidator; // 0x18

	// Properties
	internal RequestCache Cache { get; }
	internal RequestCacheValidator Validator { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B43CB8
	internal RequestCache get_Cache() { }

	// RVA: 0xFFFFFFFF75B43CC0
	internal RequestCacheValidator get_Validator() { }

}

// Namespace: System.Net.Cache
public enum RequestCacheLevel
{
	// Fields
	public Int32 value__; // 0x10
	public const RequestCacheLevel Default = 0;
	public const RequestCacheLevel BypassCache = 1;
	public const RequestCacheLevel CacheOnly = 2;
	public const RequestCacheLevel CacheIfAvailable = 3;
	public const RequestCacheLevel Revalidate = 4;
	public const RequestCacheLevel Reload = 5;
	public const RequestCacheLevel NoCacheNoStore = 6;
}

// Namespace: System.Net.Cache
public class RequestCachePolicy
{
	// Fields
	private RequestCacheLevel m_Level; // 0x10

	// Properties
	public RequestCacheLevel Level { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B43CC8
	public RequestCacheLevel get_Level() { }

}

// Namespace: System.Net.Cache
internal class RequestCacheProtocol
{
	// Methods

	// RVA: 0xFFFFFFFF75B43CD0
	public Void .ctor(Object arg1, Object arg2) { }

}

// Namespace: System.Net.WebSockets
internal sealed class ManagedWebSocket
{
	// Fields
	private static readonly RandomNumberGenerator s_random; // 0x0
	private static readonly UTF8Encoding s_textEncoding; // 0x8
	private static readonly WebSocketState[] s_validSendStates; // 0x10
	private static readonly WebSocketState[] s_validReceiveStates; // 0x18
	private static readonly WebSocketState[] s_validCloseOutputStates; // 0x20
	private static readonly WebSocketState[] s_validCloseStates; // 0x28
	private readonly Stream _stream; // 0x10
	private readonly Boolean _isServer; // 0x18
	private readonly String _subprotocol; // 0x20
	private readonly Timer _keepAliveTimer; // 0x28
	private readonly CancellationTokenSource _abortSource; // 0x30
	private Byte[] _receiveBuffer; // 0x38
	private readonly Boolean _receiveBufferFromPool; // 0x40
	private readonly Utf8MessageState _utf8TextState; // 0x48
	private readonly SemaphoreSlim _sendFrameAsyncLock; // 0x50
	private WebSocketState _state; // 0x58
	private Boolean _disposed; // 0x5C
	private Boolean _sentCloseFrame; // 0x5D
	private Boolean _receivedCloseFrame; // 0x5E
	private Nullable<T0> _closeStatus; // 0x60
	private String _closeStatusDescription; // 0x68
	private MessageHeader _lastReceiveHeader; // 0x70
	private Int32 _receiveBufferOffset; // 0x88
	private Int32 _receiveBufferCount; // 0x8C
	private Int32 _receivedMaskOffsetOffset; // 0x90
	private Byte[] _sendBuffer; // 0x98
	private Boolean _lastSendWasFragment; // 0xA0
	private Task _lastSendAsync; // 0xA8
	private Task<T0> _lastReceiveAsync; // 0xB0

	// Properties
	private Object StateUpdateLock { get; }
	private Object ReceiveAsyncLock { get; }
	public override WebSocketState State { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B87AE4
	public static ManagedWebSocket CreateFromConnectedStream(Stream stream, Boolean isServer, String subprotocol, TimeSpan keepAliveInterval, Int32 receiveBufferSize, Nullable<T0> receiveBuffer) { }

	// RVA: 0xFFFFFFFF75B88118
	private Object get_StateUpdateLock() { }

	// RVA: 0xFFFFFFFF75B88120
	private Object get_ReceiveAsyncLock() { }

	// RVA: 0xFFFFFFFF75B87BA4
	private Void .ctor(Stream stream, Boolean isServer, String subprotocol, TimeSpan keepAliveInterval, Int32 receiveBufferSize, Nullable<T0> receiveBuffer) { }

	// RVA: 0xFFFFFFFF75B88130
	public override Void Dispose() { }

	// RVA: 0xFFFFFFFF75B881B8
	private Void DisposeCore() { }

	// RVA: 0xFFFFFFFF75B8832C
	public override WebSocketState get_State() { }

	// RVA: 0xFFFFFFFF75B88334
	public override Task SendAsync(ArraySegment<T0> buffer, WebSocketMessageType messageType, Boolean endOfMessage, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B88AFC
	public override Task<T0> ReceiveAsync(ArraySegment<T0> buffer, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B88FC4
	public override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, String statusDescription, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B894C8
	public override Void Abort() { }

	// RVA: 0xFFFFFFFF75B88A50
	private Task SendFrameAsync(MessageOpcode opcode, Boolean endOfMessage, ArraySegment<T0> payloadBuffer, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B89508
	private Task SendFrameLockAcquiredNonCancelableAsync(MessageOpcode opcode, Boolean endOfMessage, ArraySegment<T0> payloadBuffer) { }

	// RVA: 0xFFFFFFFF75B89A74
	private Task SendFrameFallbackAsync(MessageOpcode opcode, Boolean endOfMessage, ArraySegment<T0> payloadBuffer, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B89C2C
	private Int32 WriteFrameToSendBuffer(MessageOpcode opcode, Boolean endOfMessage, ArraySegment<T0> payloadBuffer) { }

	// RVA: 0xFFFFFFFF75B8A388
	private Void SendKeepAliveFrameAsync() { }

	// RVA: 0xFFFFFFFF75B8A134
	private static Int32 WriteHeader(MessageOpcode opcode, Byte[] sendBuffer, ArraySegment<T0> payload, Boolean endOfMessage, Boolean useMask) { }

	// RVA: 0xFFFFFFFF75B8A630
	private static Void WriteRandomMask(Byte[] buffer, Int32 offset) { }

	// RVA: 0xFFFFFFFF75B88DE0
	private Task<T0> ReceiveAsyncPrivate(ArraySegment<T0> payloadBuffer, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B8A6D0
	private Task<T0> HandleReceivedCloseAsync(MessageHeader header, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B8A888
	private Task HandleReceivedPingPongAsync(MessageHeader header, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B8AA18
	private static Boolean IsValidCloseStatus(WebSocketCloseStatus closeStatus) { }

	// RVA: 0xFFFFFFFF75B8AA4C
	private Task CloseWithReceiveErrorAndThrowAsync(WebSocketCloseStatus closeStatus, WebSocketError error, CancellationToken cancellationToken, Exception innerException) { }

	// RVA: 0xFFFFFFFF75B8AC00
	private Boolean TryParseMessageHeaderFromReceiveBuffer(out MessageHeader resultHeader) { }

	// RVA: 0xFFFFFFFF75B89324
	private Task SendCloseFrameAsync(WebSocketCloseStatus closeStatus, String closeStatusDescription, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B8AE54
	private Void ConsumeFromBuffer(Int32 count) { }

	// RVA: 0xFFFFFFFF75B8AEB0
	private Task EnsureBufferContainsAsync(Int32 minimumRequiredBytes, CancellationToken cancellationToken, Boolean throwOnPrematureClosure) { }

	// RVA: 0xFFFFFFFF75B8A010
	private Void AllocateSendBuffer(Int32 minLength) { }

	// RVA: 0xFFFFFFFF75B89EEC
	private Void ReleaseSendBuffer() { }

	// RVA: 0xFFFFFFFF75B8AE68
	private static Int32 CombineMaskBytes(Byte[] buffer, Int32 maskOffset) { }

	// RVA: 0xFFFFFFFF75B8A2D4
	private static Int32 ApplyMask(Byte[] toMask, Int32 toMaskOffset, Byte[] mask, Int32 maskOffset, Int32 maskOffsetIndex, Int64 count) { }

	// RVA: 0xFFFFFFFF75B8B030
	private static Int32 ApplyMask(Byte[] toMask, Int32 toMaskOffset, Int32 mask, Int32 maskIndex, Int64 count) { }

	// RVA: 0xFFFFFFFF75B8898C
	private Void ThrowIfOperationInProgress(Task operationTask, String methodName) { }

	// RVA: 0xFFFFFFFF75B89E70
	private static Exception CreateOperationCanceledException(Exception innerException, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B8B0DC
	private static Boolean TryValidateUtf8(ArraySegment<T0> arraySegment, Boolean endOfMessage, Utf8MessageState state) { }

	// RVA: 0xFFFFFFFF75B8B36C
	private static Void .cctor() { }

}

// Namespace: 
private sealed class Utf8MessageState
{
	// Fields
	internal Boolean SequenceInProgress; // 0x10
	internal Int32 AdditionalBytesExpected; // 0x14
	internal Int32 ExpectedValueMin; // 0x18
	internal Int32 CurrentDecodeBits; // 0x1C

	// Methods

	// RVA: 0xFFFFFFFF75B88128
	public Void .ctor() { }

}

// Namespace: 
private enum MessageOpcode
{
	// Fields
	public Byte value__; // 0x10
	public const MessageOpcode Continuation = 0;
	public const MessageOpcode Text = 1;
	public const MessageOpcode Binary = 2;
	public const MessageOpcode Close = 8;
	public const MessageOpcode Ping = 9;
	public const MessageOpcode Pong = 10;
}

// Namespace: 
private struct MessageHeader
{
	// Fields
	internal MessageOpcode Opcode; // 0x10
	internal Boolean Fin; // 0x11
	internal Int64 PayloadLength; // 0x18
	internal Int32 Mask; // 0x20
}

// Namespace: 
private sealed class <>c
{
	// Fields
	public static readonly <>c <>9; // 0x0
	public static Action<T0> <>9__37_0; // 0x8
	public static TimerCallback <>9__37_1; // 0x10
	public static Action<T0, T1> <>9__54_0; // 0x18
	public static Action<T0> <>9__55_0; // 0x20
	public static Action<T0> <>9__57_0; // 0x28
	public static Action<T0> <>9__60_0; // 0x30

	// Methods

	// RVA: 0xFFFFFFFF75B8B548
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75B8B5C0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B8B5C4
	internal Void <.ctor>b__37_0(Object s) { }

	// RVA: 0xFFFFFFFF75B8B6D4
	internal Void <.ctor>b__37_1(Object s) { }

	// RVA: 0xFFFFFFFF75B8B74C
	internal Void <SendFrameLockAcquiredNonCancelableAsync>b__54_0(Task t, Object s) { }

	// RVA: 0xFFFFFFFF75B8B930
	internal Void <SendFrameFallbackAsync>b__55_0(Object s) { }

	// RVA: 0xFFFFFFFF75B8B9B4
	internal Void <SendKeepAliveFrameAsync>b__57_0(Task p) { }

	// RVA: 0xFFFFFFFF75B8B9D0
	internal Void <ReceiveAsyncPrivate>b__60_0(Object s) { }

}

// Namespace: 
private struct <SendFrameFallbackAsync>d__55
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public ManagedWebSocket <>4__this; // 0x30
	public MessageOpcode opcode; // 0x38
	public Boolean endOfMessage; // 0x39
	public ArraySegment<T0> payloadBuffer; // 0x40
	public CancellationToken cancellationToken; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58
	private CancellationTokenRegistration <>7__wrap1; // 0x68

	// Methods

	// RVA: 0xFFFFFFFF711486BC
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF711486C4
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <ReceiveAsyncPrivate>d__60
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder<T0> <>t__builder; // 0x18
	public CancellationToken cancellationToken; // 0x30
	public ManagedWebSocket <>4__this; // 0x38
	private MessageHeader <header>5__1; // 0x40
	public ArraySegment<T0> payloadBuffer; // 0x58
	private Int32 <bytesToRead>5__2; // 0x68
	private Int32 <bytesToCopy>5__3; // 0x6C
	private CancellationTokenRegistration <registration>5__4; // 0x70
	private ConfiguredTaskAwaiter <>u__1; // 0x88
	private ConfiguredTaskAwaiter <>u__2; // 0x98

	// Methods

	// RVA: 0xFFFFFFFF7114863C
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF71148644
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <HandleReceivedCloseAsync>d__61
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder<T0> <>t__builder; // 0x18
	public ManagedWebSocket <>4__this; // 0x30
	public MessageHeader header; // 0x38
	public CancellationToken cancellationToken; // 0x50
	private WebSocketCloseStatus <closeStatus>5__1; // 0x58
	private String <closeStatusDescription>5__2; // 0x60
	private ConfiguredTaskAwaiter <>u__1; // 0x68

	// Methods

	// RVA: 0xFFFFFFFF711485BC
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF711485C4
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <HandleReceivedPingPongAsync>d__62
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public MessageHeader header; // 0x30
	public ManagedWebSocket <>4__this; // 0x48
	public CancellationToken cancellationToken; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58

	// Methods

	// RVA: 0xFFFFFFFF71148628
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF71148630
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <CloseWithReceiveErrorAndThrowAsync>d__64
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public ManagedWebSocket <>4__this; // 0x30
	public WebSocketCloseStatus closeStatus; // 0x38
	public CancellationToken cancellationToken; // 0x40
	public WebSocketError error; // 0x48
	public Exception innerException; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58

	// Methods

	// RVA: 0xFFFFFFFF71148594
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF7114859C
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <SendCloseFrameAsync>d__67
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public String closeStatusDescription; // 0x30
	public WebSocketCloseStatus closeStatus; // 0x38
	public ManagedWebSocket <>4__this; // 0x40
	public CancellationToken cancellationToken; // 0x48
	private Byte[] <buffer>5__1; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58

	// Methods

	// RVA: 0xFFFFFFFF711486A8
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF711486B0
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <EnsureBufferContainsAsync>d__69
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public ManagedWebSocket <>4__this; // 0x30
	public Int32 minimumRequiredBytes; // 0x38
	public CancellationToken cancellationToken; // 0x40
	public Boolean throwOnPrematureClosure; // 0x48
	private ConfiguredTaskAwaiter <>u__1; // 0x50

	// Methods

	// RVA: 0xFFFFFFFF711485A8
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF711485B0
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net.WebSockets
internal static class WebSocketValidate
{
	// Methods

	// RVA: 0xFFFFFFFF75B887C0
	internal static Void ThrowIfInvalidState(WebSocketState currentState, Boolean isDisposed, WebSocketState[] validStates) { }

	// RVA: 0xFFFFFFFF75B8F18C
	internal static Void ValidateSubprotocol(String subProtocol) { }

	// RVA: 0xFFFFFFFF75B8913C
	internal static Void ValidateCloseStatus(WebSocketCloseStatus closeStatus, String statusDescription) { }

	// RVA: 0xFFFFFFFF75B88648
	internal static Void ValidateArraySegment(ArraySegment<T0> arraySegment, String parameterName) { }

}

// Namespace: System.Net.WebSockets
public sealed class ClientWebSocket
{
	// Fields
	private readonly ClientWebSocketOptions _options; // 0x10
	private WebSocketHandle _innerWebSocket; // 0x18
	private Int32 _state; // 0x20

	// Properties
	public override WebSocketState State { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B86CFC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF7238B30C
	public override WebSocketState get_State() { }

	// RVA: 0xFFFFFFFF75B86E68
	public Task ConnectAsync(Uri uri, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B870A0
	private Task ConnectAsyncCore(Uri uri, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF7238B3E4
	public override Task SendAsync(ArraySegment<T0> buffer, WebSocketMessageType messageType, Boolean endOfMessage, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF7238B45C
	public override Task<T0> ReceiveAsync(ArraySegment<T0> buffer, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF7238B4BC
	public override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, String statusDescription, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF7238B51C
	public override Void Abort() { }

	// RVA: 0xFFFFFFFF7238B5DC
	public override Void Dispose() { }

	// RVA: 0xFFFFFFFF75B87230
	private Void ThrowIfNotConnected() { }

}

// Namespace: 
private enum InternalState
{
	// Fields
	public Int32 value__; // 0x10
	public const InternalState Created = 0;
	public const InternalState Connecting = 1;
	public const InternalState Connected = 2;
	public const InternalState Disposed = 3;
}

// Namespace: 
private struct <ConnectAsyncCore>d__16
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public ClientWebSocket <>4__this; // 0x30
	public Uri uri; // 0x38
	public CancellationToken cancellationToken; // 0x40
	private ConfiguredTaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0xFFFFFFFF71148580
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF71148588
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net.WebSockets
public sealed class ClientWebSocketOptions
{
	// Fields
	private Boolean _isReadOnly; // 0x10
	private readonly List<T0> _requestedSubProtocols; // 0x18
	private readonly WebHeaderCollection _requestHeaders; // 0x20
	private TimeSpan _keepAliveInterval; // 0x28
	private X509CertificateCollection _clientCertificates; // 0x30
	private CookieContainer _cookies; // 0x38
	private Int32 _receiveBufferSize; // 0x40
	private Int32 _sendBufferSize; // 0x44
	private Nullable<T0> _buffer; // 0x48

	// Properties
	internal WebHeaderCollection RequestHeaders { get; }
	internal List<T0> RequestedSubProtocols { get; }
	public X509CertificateCollection ClientCertificates { get; }
	public CookieContainer Cookies { get; }
	public TimeSpan KeepAliveInterval { get; }
	internal Int32 ReceiveBufferSize { get; }
	internal Int32 SendBufferSize { get; }
	internal Nullable<T0> Buffer { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B8791C
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75B879F4
	internal WebHeaderCollection get_RequestHeaders() { }

	// RVA: 0xFFFFFFFF75B879FC
	internal List<T0> get_RequestedSubProtocols() { }

	// RVA: 0xFFFFFFFF75B87A04
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0xFFFFFFFF75B87AA4
	public CookieContainer get_Cookies() { }

	// RVA: 0xFFFFFFFF75B87AAC
	public TimeSpan get_KeepAliveInterval() { }

	// RVA: 0xFFFFFFFF75B87AB4
	internal Int32 get_ReceiveBufferSize() { }

	// RVA: 0xFFFFFFFF75B87ABC
	internal Int32 get_SendBufferSize() { }

	// RVA: 0xFFFFFFFF75B87AC4
	internal Nullable<T0> get_Buffer() { }

	// RVA: 0xFFFFFFFF75B87AD8
	internal Void SetToReadOnly() { }

}

// Namespace: System.Net.WebSockets
internal sealed class WebSocketHandle
{
	// Fields
	private static StringBuilder t_cachedStringBuilder; // 0xFFFFFFFFFFFFFFFF
	private static readonly Encoding s_defaultHttpEncoding; // 0x0
	private readonly CancellationTokenSource _abortSource; // 0x10
	private WebSocketState _state; // 0x18
	private WebSocket _webSocket; // 0x20

	// Properties
	public WebSocketState State { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B876DC
	public static WebSocketHandle Create() { }

	// RVA: 0xFFFFFFFF75B8F834
	public static Boolean IsValid(WebSocketHandle handle) { }

	// RVA: 0xFFFFFFFF75B8F840
	public WebSocketState get_State() { }

	// RVA: 0xFFFFFFFF75B8F864
	public static Void CheckPlatformSupport() { }

	// RVA: 0xFFFFFFFF75B8F868
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75B8F88C
	public Void Abort() { }

	// RVA: 0xFFFFFFFF75B8F8DC
	public Task SendAsync(ArraySegment<T0> buffer, WebSocketMessageType messageType, Boolean endOfMessage, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B8F904
	public Task<T0> ReceiveAsync(ArraySegment<T0> buffer, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B8F92C
	public Task CloseOutputAsync(WebSocketCloseStatus closeStatus, String statusDescription, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B8773C
	public Task ConnectAsyncCore(Uri uri, CancellationToken cancellationToken, ClientWebSocketOptions options) { }

	// RVA: 0xFFFFFFFF75B8F954
	private Task<T0> ConnectSocketAsync(String host, Int32 port, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B8FB38
	private static Byte[] BuildRequestHeader(Uri uri, ClientWebSocketOptions options, String secKey) { }

	// RVA: 0xFFFFFFFF75B901F0
	private static KeyValuePair<T0, T1> CreateSecKeyAndSecWebSocketAccept() { }

	// RVA: 0xFFFFFFFF75B903F8
	private Task<T0> ParseAndValidateConnectResponseAsync(Stream stream, ClientWebSocketOptions options, String expectedSecWebSocketAccept, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B905D8
	private static Void ValidateAndTrackHeader(String targetHeaderName, String targetHeaderValue, String foundHeaderName, String foundHeaderValue, ref Boolean foundHeader) { }

	// RVA: 0xFFFFFFFF75B90724
	private static Task<T0> ReadResponseHeaderLineAsync(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B8F7A4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B90894
	private static Void .cctor() { }

}

// Namespace: 
private sealed class <>c
{
	// Fields
	public static readonly <>c <>9; // 0x0
	public static Action<T0> <>9__24_0; // 0x8
	public static Action<T0> <>9__25_0; // 0x10
	public static Action<T0> <>9__25_1; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75B90910
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75B90988
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B9098C
	internal Void <ConnectAsyncCore>b__24_0(Object s) { }

	// RVA: 0xFFFFFFFF75B90A04
	internal Void <ConnectSocketAsync>b__25_0(Object s) { }

	// RVA: 0xFFFFFFFF75B90A60
	internal Void <ConnectSocketAsync>b__25_1(Object s) { }

}

// Namespace: 
private struct <ConnectAsyncCore>d__24
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public CancellationToken cancellationToken; // 0x30
	public WebSocketHandle <>4__this; // 0x38
	public Uri uri; // 0x40
	public ClientWebSocketOptions options; // 0x48
	private SslStream <sslStream>5__1; // 0x50
	private Stream <stream>5__2; // 0x58
	private KeyValuePair<T0, T1> <secKeyAndSecWebSocketAccept>5__3; // 0x60
	private CancellationTokenRegistration <registration>5__4; // 0x70
	private ConfiguredTaskAwaiter <>u__1; // 0x88
	private ConfiguredTaskAwaiter <>u__2; // 0x98
	private ConfiguredTaskAwaiter <>u__3; // 0xA8

	// Methods

	// RVA: 0xFFFFFFFF711486D0
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF711486D8
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <ConnectSocketAsync>d__25
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder<T0> <>t__builder; // 0x18
	public String host; // 0x30
	public CancellationToken cancellationToken; // 0x38
	public WebSocketHandle <>4__this; // 0x40
	public Int32 port; // 0x48
	private Socket <socket>5__1; // 0x50
	private ExceptionDispatchInfo <lastException>5__2; // 0x58
	private ConfiguredTaskAwaiter <>u__1; // 0x60
	private IPAddress[] <>7__wrap1; // 0x70
	private Int32 <>7__wrap2; // 0x78
	private CancellationTokenRegistration <>7__wrap3; // 0x80
	private CancellationTokenRegistration <>7__wrap4; // 0x98
	private ConfiguredTaskAwaiter <>u__2; // 0xB0

	// Methods

	// RVA: 0xFFFFFFFF711486E4
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF711486EC
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private sealed class <>c__DisplayClass28_0
{
	// Fields
	public String headerValue; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75B90ABC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B90AC0
	internal Boolean <ParseAndValidateConnectResponseAsync>b__0(String requested) { }

}

// Namespace: 
private struct <ParseAndValidateConnectResponseAsync>d__28
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder<T0> <>t__builder; // 0x18
	public Stream stream; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private String <line>5__1; // 0x40
	private Boolean <foundConnection>5__2; // 0x48
	private Boolean <foundUpgrade>5__3; // 0x49
	public String expectedSecWebSocketAccept; // 0x50
	private Boolean <foundSecWebSocketAccept>5__4; // 0x58
	public ClientWebSocketOptions options; // 0x60
	private String <subprotocol>5__5; // 0x68
	private ConfiguredTaskAwaiter <>u__1; // 0x70

	// Methods

	// RVA: 0xFFFFFFFF71148750
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF71148758
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <ReadResponseHeaderLineAsync>d__30
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder<T0> <>t__builder; // 0x18
	private Byte[] <arr>5__1; // 0x30
	private Char <prevChar>5__2; // 0x38
	private StringBuilder <sb>5__3; // 0x40
	public Stream stream; // 0x48
	public CancellationToken cancellationToken; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58

	// Methods

	// RVA: 0xFFFFFFFF711487BC
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF711487C4
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net.WebSockets
public abstract class WebSocket
{
	// Properties
	public abstract WebSocketState State { get; }
	public static TimeSpan DefaultKeepAliveInterval { get; }

	// Methods

	// RVA: -1
	public abstract WebSocketState get_State() { }

	// RVA: -1
	public abstract Void Abort() { }

	// RVA: -1
	public abstract Task CloseOutputAsync(WebSocketCloseStatus closeStatus, String statusDescription, CancellationToken cancellationToken) { }

	// RVA: -1
	public abstract Void Dispose() { }

	// RVA: -1
	public abstract Task<T0> ReceiveAsync(ArraySegment<T0> buffer, CancellationToken cancellationToken) { }

	// RVA: -1
	public abstract Task SendAsync(ArraySegment<T0> buffer, WebSocketMessageType messageType, Boolean endOfMessage, CancellationToken cancellationToken) { }

	// RVA: 0xFFFFFFFF75B879C0
	public static TimeSpan get_DefaultKeepAliveInterval() { }

	// RVA: 0xFFFFFFFF75B8EDC4
	public static WebSocket CreateClientWebSocket(Stream innerStream, String subProtocol, Int32 receiveBufferSize, Int32 sendBufferSize, TimeSpan keepAliveInterval, Boolean useZeroMaskingKey, ArraySegment<T0> internalBuffer) { }

	// RVA: 0xFFFFFFFF75B8812C
	protected Void .ctor() { }

}

// Namespace: System.Net.WebSockets
public enum WebSocketCloseStatus
{
	// Fields
	public Int32 value__; // 0x10
	public const WebSocketCloseStatus NormalClosure = 1000;
	public const WebSocketCloseStatus EndpointUnavailable = 1001;
	public const WebSocketCloseStatus ProtocolError = 1002;
	public const WebSocketCloseStatus InvalidMessageType = 1003;
	public const WebSocketCloseStatus Empty = 1005;
	public const WebSocketCloseStatus InvalidPayloadData = 1007;
	public const WebSocketCloseStatus PolicyViolation = 1008;
	public const WebSocketCloseStatus MessageTooBig = 1009;
	public const WebSocketCloseStatus MandatoryExtension = 1010;
	public const WebSocketCloseStatus InternalServerError = 1011;
}

// Namespace: System.Net.WebSockets
public enum WebSocketError
{
	// Fields
	public Int32 value__; // 0x10
	public const WebSocketError Success = 0;
	public const WebSocketError InvalidMessageType = 1;
	public const WebSocketError Faulted = 2;
	public const WebSocketError NativeError = 3;
	public const WebSocketError NotAWebSocket = 4;
	public const WebSocketError UnsupportedVersion = 5;
	public const WebSocketError UnsupportedProtocol = 6;
	public const WebSocketError HeaderError = 7;
	public const WebSocketError ConnectionClosedPrematurely = 8;
	public const WebSocketError InvalidState = 9;
}

// Namespace: System.Net.WebSockets
public sealed class WebSocketException
{
	// Fields
	private readonly WebSocketError _webSocketErrorCode; // 0x8C

	// Properties
	public WebSocketError WebSocketErrorCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B8F3BC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B8C070
	public Void .ctor(WebSocketError error) { }

	// RVA: 0xFFFFFFFF75B8F618
	public Void .ctor(WebSocketError error, String message) { }

	// RVA: 0xFFFFFFFF75B89E2C
	public Void .ctor(WebSocketError error, Exception innerException) { }

	// RVA: 0xFFFFFFFF75B8F674
	public Void .ctor(WebSocketError error, String message, Exception innerException) { }

	// RVA: 0xFFFFFFFF75B8F404
	public Void .ctor(Int32 nativeError) { }

	// RVA: 0xFFFFFFFF75B8F6F4
	public Void .ctor(String message) { }

	// RVA: 0xFFFFFFFF75B8F73C
	public Void .ctor(String message, Exception innerException) { }

	// RVA: 0xFFFFFFFF75B8F794
	public override Void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF75B8F79C
	public WebSocketError get_WebSocketErrorCode() { }

	// RVA: 0xFFFFFFFF75B8F470
	private static String GetErrorMessage(WebSocketError error) { }

	// RVA: 0xFFFFFFFF75B8F6E4
	private Void SetErrorCodeOnError(Int32 nativeError) { }

	// RVA: 0xFFFFFFFF75B8F6D8
	private static Boolean Succeeded(Int32 hr) { }

}

// Namespace: System.Net.WebSockets
public enum WebSocketMessageType
{
	// Fields
	public Int32 value__; // 0x10
	public const WebSocketMessageType Text = 0;
	public const WebSocketMessageType Binary = 1;
	public const WebSocketMessageType Close = 2;
}

// Namespace: System.Net.WebSockets
public class WebSocketReceiveResult
{
	// Fields
	private readonly Int32 <Count>k__BackingField; // 0x10
	private readonly Boolean <EndOfMessage>k__BackingField; // 0x14
	private readonly WebSocketMessageType <MessageType>k__BackingField; // 0x18
	private readonly Nullable<T0> <CloseStatus>k__BackingField; // 0x1C
	private readonly String <CloseStatusDescription>k__BackingField; // 0x28

	// Properties
	public Int32 Count { get; }
	public Boolean EndOfMessage { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B8DEF4
	public Void .ctor(Int32 count, WebSocketMessageType messageType, Boolean endOfMessage) { }

	// RVA: 0xFFFFFFFF75B8C988
	public Void .ctor(Int32 count, WebSocketMessageType messageType, Boolean endOfMessage, Nullable<T0> closeStatus, String closeStatusDescription) { }

	// RVA: 0xFFFFFFFF75B92AE8
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75B92AF0
	public Boolean get_EndOfMessage() { }

}

// Namespace: System.Net.WebSockets
public enum WebSocketState
{
	// Fields
	public Int32 value__; // 0x10
	public const WebSocketState None = 0;
	public const WebSocketState Connecting = 1;
	public const WebSocketState Open = 2;
	public const WebSocketState CloseSent = 3;
	public const WebSocketState CloseReceived = 4;
	public const WebSocketState Closed = 5;
	public const WebSocketState Aborted = 6;
}

// Namespace: System.Collections.Specialized
public struct BitVector32
{
	// Fields
	private UInt32 data; // 0x10

	// Properties
	public Boolean Item { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF711474F8
	public Boolean get_Item(Int32 bit) { }

	// RVA: 0xFFFFFFFF71147508
	public Void set_Item(Int32 bit, Boolean value) { }

	// RVA: 0xFFFFFFFF75B08C38
	public static Int32 CreateMask() { }

	// RVA: 0xFFFFFFFF75B08C80
	public static Int32 CreateMask(Int32 previous) { }

	// RVA: 0xFFFFFFFF71147524
	public override Boolean Equals(Object o) { }

	// RVA: 0xFFFFFFFF7114752C
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75B08DFC
	public static String ToString(BitVector32 value) { }

	// RVA: 0xFFFFFFFF71147534
	public override String ToString() { }

}

// Namespace: System.Collections.Specialized
public class HybridDictionary
{
	// Fields
	private ListDictionary list; // 0x10
	private Hashtable hashtable; // 0x18
	private Boolean caseInsensitive; // 0x20

	// Properties
	public Object Item { get; set; }
	private ListDictionary List { get; }
	public Int32 Count { get; }
	public ICollection Keys { get; }
	public Boolean IsReadOnly { get; }
	public Boolean IsFixedSize { get; }
	public Boolean IsSynchronized { get; }
	public Object SyncRoot { get; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B093E4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B093E8
	public Void .ctor(Boolean caseInsensitive) { }

	// RVA: 0xFFFFFFFF75B093F0
	public Object get_Item(Object key) { }

	// RVA: 0xFFFFFFFF75B09484
	public Void set_Item(Object key, Object value) { }

	// RVA: 0xFFFFFFFF75B09870
	private ListDictionary get_List() { }

	// RVA: 0xFFFFFFFF75B095C0
	private Void ChangeOver() { }

	// RVA: 0xFFFFFFFF75B09940
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75B09974
	public ICollection get_Keys() { }

	// RVA: 0xFFFFFFFF75B09A64
	public Boolean get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF75B09A6C
	public Boolean get_IsFixedSize() { }

	// RVA: 0xFFFFFFFF75B09A74
	public Boolean get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75B09A7C
	public Object get_SyncRoot() { }

	// RVA: 0xFFFFFFFF75B09A80
	public ICollection get_Values() { }

	// RVA: 0xFFFFFFFF75B09B10
	public Void Add(Object key, Object value) { }

	// RVA: 0xFFFFFFFF75B09E48
	public Void Clear() { }

	// RVA: 0xFFFFFFFF75B09F38
	public Boolean Contains(Object key) { }

	// RVA: 0xFFFFFFFF75B0A158
	public Void CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF75B0A334
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B0A448
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B0A55C
	public Void Remove(Object key) { }

}

// Namespace: System.Collections.Specialized
public interface IOrderedDictionary
{
	// Methods

	// RVA: -1
	public abstract IDictionaryEnumerator GetEnumerator() { }

}

// Namespace: System.Collections.Specialized
public class ListDictionary
{
	// Fields
	private DictionaryNode head; // 0x10
	private Int32 version; // 0x18
	private Int32 count; // 0x1C
	private IComparer comparer; // 0x20
	private Object _syncRoot; // 0x28

	// Properties
	public Object Item { get; set; }
	public Int32 Count { get; }
	public ICollection Keys { get; }
	public Boolean IsReadOnly { get; }
	public Boolean IsFixedSize { get; }
	public Boolean IsSynchronized { get; }
	public Object SyncRoot { get; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0xFFFFFFFF72372444
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B09838
	public Void .ctor(IComparer comparer) { }

	// RVA: 0xFFFFFFFF72372014
	public Object get_Item(Object key) { }

	// RVA: 0xFFFFFFFF72372178
	public Void set_Item(Object key, Object value) { }

	// RVA: 0xFFFFFFFF75B0A7E4
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75B09A08
	public ICollection get_Keys() { }

	// RVA: 0xFFFFFFFF75B0A834
	public Boolean get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF75B0A83C
	public Boolean get_IsFixedSize() { }

	// RVA: 0xFFFFFFFF75B0A844
	public Boolean get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75B0A84C
	public Object get_SyncRoot() { }

	// RVA: 0xFFFFFFFF723723EC
	public ICollection get_Values() { }

	// RVA: 0xFFFFFFFF75B09C60
	public Void Add(Object key, Object value) { }

	// RVA: 0xFFFFFFFF75B09EF0
	public Void Clear() { }

	// RVA: 0xFFFFFFFF75B0A008
	public Boolean Contains(Object key) { }

	// RVA: 0xFFFFFFFF75B0A1BC
	public Void CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF72372364
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B0A894
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B0A628
	public Void Remove(Object key) { }

}

// Namespace: 
private class NodeEnumerator
{
	// Fields
	private ListDictionary list; // 0x10
	private DictionaryNode current; // 0x18
	private Int32 version; // 0x20
	private Boolean start; // 0x24

	// Properties
	public Object Current { get; }
	public DictionaryEntry Entry { get; }
	public Object Key { get; }
	public Object Value { get; }

	// Methods

	// RVA: 0xFFFFFFFF72372448
	public Void .ctor(ListDictionary list) { }

	// RVA: 0xFFFFFFFF75B0A8CC
	public Object get_Current() { }

	// RVA: 0xFFFFFFFF75B0A92C
	public DictionaryEntry get_Entry() { }

	// RVA: 0xFFFFFFFF723724C4
	public Object get_Key() { }

	// RVA: 0xFFFFFFFF7237251C
	public Object get_Value() { }

	// RVA: 0xFFFFFFFF72372574
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF72372644
	public Void Reset() { }

}

// Namespace: 
private class NodeKeyValueCollection
{
	// Fields
	private ListDictionary list; // 0x10
	private Boolean isKeys; // 0x18

	// Properties
	private Int32 System.Collections.ICollection.Count { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B0A7EC
	public Void .ctor(ListDictionary list, Boolean isKeys) { }

	// RVA: 0xFFFFFFFF75B0A9C4
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF75B0AAD4
	private Int32 System.Collections.ICollection.get_Count() { }

	// RVA: 0xFFFFFFFF75B0AB10
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75B0AB18
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xFFFFFFFF723726D4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
private class NodeKeyValueEnumerator
{
	// Fields
	private ListDictionary list; // 0x10
	private DictionaryNode current; // 0x18
	private Int32 version; // 0x20
	private Boolean isKeys; // 0x24
	private Boolean start; // 0x25

	// Properties
	public Object Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF72372764
	public Void .ctor(ListDictionary list, Boolean isKeys) { }

	// RVA: 0xFFFFFFFF723727E8
	public Object get_Current() { }

	// RVA: 0xFFFFFFFF72372854
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75B0AB34
	public Void Reset() { }

}

// Namespace: 
private class DictionaryNode
{
	// Fields
	public Object key; // 0x10
	public Object value; // 0x18
	public DictionaryNode next; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75B0A7E0
	public Void .ctor() { }

}

// Namespace: System.Collections.Specialized
public abstract class NameObjectCollectionBase
{
	// Fields
	private Boolean _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectEntry _nullKeyEntry; // 0x30
	private KeysCollection _keys; // 0x38
	private SerializationInfo _serializationInfo; // 0x40
	private Int32 _version; // 0x48
	private Object _syncRoot; // 0x50
	private static StringComparer defaultComparer; // 0x0

	// Properties
	protected Boolean IsReadOnly { get; }
	public virtual Int32 Count { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	public virtual KeysCollection Keys { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B0ABE4
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF72372924
	protected Void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0xFFFFFFFF72372BB8
	protected Void .ctor(Int32 capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0xFFFFFFFF72372D78
	internal Void .ctor(DBNull dummy) { }

	// RVA: 0xFFFFFFFF75B0AC2C
	protected Void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF75B0AC64
	public virtual Void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF75B0B16C
	public virtual Void OnDeserialization(Object sender) { }

	// RVA: 0xFFFFFFFF72372AF4
	private Void Reset() { }

	// RVA: 0xFFFFFFFF72372CA8
	private Void Reset(Int32 capacity) { }

	// RVA: 0xFFFFFFFF72372ED4
	private NameObjectEntry FindEntry(String key) { }

	// RVA: 0xFFFFFFFF75B0B874
	protected Boolean get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF75B0B87C
	protected Boolean BaseHasKeys() { }

	// RVA: 0xFFFFFFFF72372D7C
	protected Void BaseAdd(String name, Object value) { }

	// RVA: 0xFFFFFFFF72372F4C
	protected Void BaseRemove(String name) { }

	// RVA: 0xFFFFFFFF723731F4
	protected Object BaseGet(String name) { }

	// RVA: 0xFFFFFFFF72373278
	protected Void BaseSet(String name, Object value) { }

	// RVA: 0xFFFFFFFF72373398
	protected Object BaseGet(Int32 index) { }

	// RVA: 0xFFFFFFFF7237318C
	protected String BaseGetKey(Int32 index) { }

	// RVA: 0xFFFFFFFF75B0B8B4
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF72373400
	public virtual Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75B0B910
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF75B0BBEC
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xFFFFFFFF75B0BC34
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75B0BC3C
	protected String[] BaseGetAllKeys() { }

	// RVA: 0xFFFFFFFF75B0BD00
	public virtual KeysCollection get_Keys() { }

	// RVA: 0xFFFFFFFF75B0BD8C
	private static Void .cctor() { }

}

// Namespace: 
internal class NameObjectEntry
{
	// Fields
	internal String Key; // 0x10
	internal Object Value; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF72373428
	internal Void .ctor(String name, Object value) { }

}

// Namespace: 
internal class NameObjectKeysEnumerator
{
	// Fields
	private Int32 _pos; // 0x10
	private NameObjectCollectionBase _coll; // 0x18
	private Int32 _version; // 0x20

	// Properties
	public Object Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B0BEA4
	internal Void .ctor(NameObjectCollectionBase coll) { }

	// RVA: 0xFFFFFFFF75B0C2C4
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75B0C3B4
	public Void Reset() { }

	// RVA: 0xFFFFFFFF75B0C454
	public Object get_Current() { }

}

// Namespace: 
public class KeysCollection
{
	// Fields
	private NameObjectCollectionBase _coll; // 0x10

	// Properties
	public Int32 Count { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B0BE10
	internal Void .ctor(NameObjectCollectionBase coll) { }

	// RVA: 0xFFFFFFFF75B0BE48
	public IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B0BEF8
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75B0BF20
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF75B0C200
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xFFFFFFFF75B0C284
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75B0C28C
	internal Void .ctor() { }

}

// Namespace: System.Collections.Specialized
internal class CompatibleComparer
{
	// Fields
	private IComparer _comparer; // 0x10
	private static IComparer defaultComparer; // 0x0
	private IHashCodeProvider _hcp; // 0x18
	private static IHashCodeProvider defaultHashProvider; // 0x8

	// Properties
	public IComparer Comparer { get; }
	public IHashCodeProvider HashCodeProvider { get; }
	public static IComparer DefaultComparer { get; }
	public static IHashCodeProvider DefaultHashCodeProvider { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B08EF0
	internal Void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0xFFFFFFFF75B08F54
	public Boolean Equals(Object a, Object b) { }

	// RVA: 0xFFFFFFFF75B09130
	public Int32 GetHashCode(Object obj) { }

	// RVA: 0xFFFFFFFF75B09234
	public IComparer get_Comparer() { }

	// RVA: 0xFFFFFFFF75B0923C
	public IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0xFFFFFFFF75B09244
	public static IComparer get_DefaultComparer() { }

	// RVA: 0xFFFFFFFF75B09314
	public static IHashCodeProvider get_DefaultHashCodeProvider() { }

}

// Namespace: System.Collections.Specialized
public class NameValueCollection
{
	// Fields
	private String[] _all; // 0x58
	private String[] _allKeys; // 0x60

	// Properties
	public String Item { get; set; }
	public String Item { get; }
	public virtual String[] AllKeys { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B0C508
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B0C548
	public Void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0xFFFFFFFF7237348C
	public Void .ctor(Int32 capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0xFFFFFFFF723734E4
	internal Void .ctor(DBNull dummy) { }

	// RVA: 0xFFFFFFFF75B0C590
	protected Void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF72373504
	protected Void InvalidateCachedArrays() { }

	// RVA: 0xFFFFFFFF72373558
	private static String GetAsOneString(ArrayList list) { }

	// RVA: 0xFFFFFFFF75B0C5F0
	private static String[] GetAsStringArray(ArrayList list) { }

	// RVA: 0xFFFFFFFF75B0C674
	public Boolean HasKeys() { }

	// RVA: 0xFFFFFFFF75B0C684
	internal virtual Boolean InternalHasKeys() { }

	// RVA: 0xFFFFFFFF723736D4
	public virtual Void Add(String name, String value) { }

	// RVA: 0xFFFFFFFF723738D4
	public virtual String Get(String name) { }

	// RVA: 0xFFFFFFFF75B0C68C
	public virtual String[] GetValues(String name) { }

	// RVA: 0xFFFFFFFF72373988
	public virtual Void Set(String name, String value) { }

	// RVA: 0xFFFFFFFF72373AA0
	public virtual Void Remove(String name) { }

	// RVA: 0xFFFFFFFF72373B0C
	public String get_Item(String name) { }

	// RVA: 0xFFFFFFFF75B0C6DC
	public Void set_Item(String name, String value) { }

	// RVA: 0xFFFFFFFF72373B1C
	public virtual String Get(Int32 index) { }

	// RVA: 0xFFFFFFFF72373BB8
	public virtual String GetKey(Int32 index) { }

	// RVA: 0xFFFFFFFF75B0C6EC
	public String get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF75B0C6FC
	public virtual String[] get_AllKeys() { }

}

// Namespace: System.Collections.Specialized
public class OrderedDictionary
{
	// Fields
	private ArrayList _objectsArray; // 0x10
	private Hashtable _objectsTable; // 0x18
	private Int32 _initialCapacity; // 0x20
	private IEqualityComparer _comparer; // 0x28
	private Boolean _readOnly; // 0x30
	private Object _syncRoot; // 0x38
	private SerializationInfo _siInfo; // 0x40

	// Properties
	public Int32 Count { get; }
	private Boolean System.Collections.IDictionary.IsFixedSize { get; }
	public Boolean IsReadOnly { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	public ICollection Keys { get; }
	private ArrayList objectsArray { get; }
	private Hashtable objectsTable { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }
	public Object Item { get; set; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B0C750
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B0C78C
	public Void .ctor(Int32 capacity) { }

	// RVA: 0xFFFFFFFF75B0C7C8
	public Void .ctor(Int32 capacity, IEqualityComparer comparer) { }

	// RVA: 0xFFFFFFFF75B0C804
	protected Void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF75B0C83C
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75B0C8D4
	private Boolean System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0xFFFFFFFF75B0C8DC
	public Boolean get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF75B0C8E4
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75B0C8EC
	public ICollection get_Keys() { }

	// RVA: 0xFFFFFFFF75B0C864
	private ArrayList get_objectsArray() { }

	// RVA: 0xFFFFFFFF72373C20
	private Hashtable get_objectsTable() { }

	// RVA: 0xFFFFFFFF75B0C9BC
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xFFFFFFFF75B0CA04
	public Object get_Item(Object key) { }

	// RVA: 0xFFFFFFFF75B0CA3C
	public Void set_Item(Object key, Object value) { }

	// RVA: 0xFFFFFFFF75B0CE84
	public ICollection get_Values() { }

	// RVA: 0xFFFFFFFF75B0CD4C
	public Void Add(Object key, Object value) { }

	// RVA: 0xFFFFFFFF75B0CF0C
	public Void Clear() { }

	// RVA: 0xFFFFFFFF75B0CFD4
	public Boolean Contains(Object key) { }

	// RVA: 0xFFFFFFFF75B0D00C
	public Void CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF75B0CBC8
	private Int32 IndexOfKey(Object key) { }

	// RVA: 0xFFFFFFFF75B0D04C
	protected virtual Void OnDeserialization(Object sender) { }

	// RVA: 0xFFFFFFFF75B0D44C
	public Void Remove(Object key) { }

	// RVA: 0xFFFFFFFF75B0D580
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B0D650
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B0D6B8
	public virtual Void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF75B0D860
	private Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(Object sender) { }

}

// Namespace: 
private class OrderedDictionaryEnumerator
{
	// Fields
	private Int32 _objectReturnType; // 0x10
	private IEnumerator arrayEnumerator; // 0x18

	// Properties
	public Object Current { get; }
	public DictionaryEntry Entry { get; }
	public Object Key { get; }
	public Object Value { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B0D5E8
	internal Void .ctor(ArrayList array, Int32 objectReturnType) { }

	// RVA: 0xFFFFFFFF75B0D870
	public Object get_Current() { }

	// RVA: 0xFFFFFFFF75B0DA1C
	public DictionaryEntry get_Entry() { }

	// RVA: 0xFFFFFFFF75B0DBA4
	public Object get_Key() { }

	// RVA: 0xFFFFFFFF75B0DC7C
	public Object get_Value() { }

	// RVA: 0xFFFFFFFF75B0DD54
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75B0DDD4
	public Void Reset() { }

}

// Namespace: 
private class OrderedDictionaryKeyValueCollection
{
	// Fields
	private ArrayList _objects; // 0x10
	private Boolean isKeys; // 0x18

	// Properties
	private Int32 System.Collections.ICollection.Count { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B0C974
	public Void .ctor(ArrayList array, Boolean isKeys) { }

	// RVA: 0xFFFFFFFF75B0DE58
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF75B0E15C
	private Int32 System.Collections.ICollection.get_Count() { }

	// RVA: 0xFFFFFFFF75B0E184
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75B0E18C
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xFFFFFFFF75B0E1B4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Collections.Specialized
public class StringCollection
{
	// Fields
	private ArrayList data; // 0x10

	// Properties
	public String Item { get; set; }
	public Int32 Count { get; }
	private Boolean System.Collections.IList.IsReadOnly { get; }
	private Boolean System.Collections.IList.IsFixedSize { get; }
	public Boolean IsSynchronized { get; }
	public Object SyncRoot { get; }
	private Object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75B0E22C
	public String get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF75B0E274
	public Void set_Item(Int32 index, String value) { }

	// RVA: 0xFFFFFFFF75B0E29C
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75B0E2C4
	private Boolean System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF75B0E2CC
	private Boolean System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xFFFFFFFF75B0E2D4
	public Int32 Add(String value) { }

	// RVA: 0xFFFFFFFF75B0E2FC
	public Void Clear() { }

	// RVA: 0xFFFFFFFF75B0E324
	public Boolean Contains(String value) { }

	// RVA: 0xFFFFFFFF75B0E34C
	public Void CopyTo(String[] array, Int32 index) { }

	// RVA: 0xFFFFFFFF75B0E374
	public Int32 IndexOf(String value) { }

	// RVA: 0xFFFFFFFF75B0E39C
	public Void Insert(Int32 index, String value) { }

	// RVA: 0xFFFFFFFF75B0E3C4
	public Boolean get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75B0E3CC
	public Void Remove(String value) { }

	// RVA: 0xFFFFFFFF75B0E3F4
	public Void RemoveAt(Int32 index) { }

	// RVA: 0xFFFFFFFF75B0E41C
	public Object get_SyncRoot() { }

	// RVA: 0xFFFFFFFF75B0E444
	private Object System.Collections.IList.get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF75B0E448
	private Void System.Collections.IList.set_Item(Int32 index, Object value) { }

	// RVA: 0xFFFFFFFF75B0E494
	private Int32 System.Collections.IList.Add(Object value) { }

	// RVA: 0xFFFFFFFF75B0E4E0
	private Boolean System.Collections.IList.Contains(Object value) { }

	// RVA: 0xFFFFFFFF75B0E52C
	private Int32 System.Collections.IList.IndexOf(Object value) { }

	// RVA: 0xFFFFFFFF75B0E578
	private Void System.Collections.IList.Insert(Int32 index, Object value) { }

	// RVA: 0xFFFFFFFF75B0E5C4
	private Void System.Collections.IList.Remove(Object value) { }

	// RVA: 0xFFFFFFFF75B0E610
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF75B0E638
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFFFFFFFF75B0E660
	public Void .ctor() { }

}

// Namespace: System.Collections.Generic
internal sealed class ICollectionDebugView<T0>
{}

// Namespace: System.Collections.Generic
internal sealed class IDictionaryDebugView<T0, T1>
{}

// Namespace: System.Collections.Generic
internal sealed class DictionaryKeyCollectionDebugView<T0, T1>
{}

// Namespace: System.Collections.Generic
internal sealed class DictionaryValueCollectionDebugView<T0, T1>
{}

// Namespace: System.Collections.Generic
public class LinkedList<T0>
{
	// Fields
	internal LinkedListNode<T0> head; // 0x0
	internal Int32 count; // 0x0
	internal Int32 version; // 0x0
	private Object _syncRoot; // 0x0
	private SerializationInfo _siInfo; // 0x0
	private const String VersionName = "Version";
	private const String CountName = "Count";
	private const String ValuesName = "Data";

	// Properties
	public Int32 Count { get; }
	public LinkedListNode<T0> First { get; }
	public LinkedListNode<T0> Last { get; }
	private Boolean System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	protected Void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: -1
	public Int32 get_Count() { }

	// RVA: -1
	public LinkedListNode<T0> get_First() { }

	// RVA: -1
	public LinkedListNode<T0> get_Last() { }

	// RVA: -1
	private Boolean System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	// RVA: -1
	private Void System.Collections.Generic.ICollection<T>.Add(T value) { }

	// RVA: -1
	public Void AddAfter(LinkedListNode<T0> node, LinkedListNode<T0> newNode) { }

	// RVA: -1
	public Void AddBefore(LinkedListNode<T0> node, LinkedListNode<T0> newNode) { }

	// RVA: -1
	public LinkedListNode<T0> AddFirst(T value) { }

	// RVA: -1
	public Void AddFirst(LinkedListNode<T0> node) { }

	// RVA: -1
	public LinkedListNode<T0> AddLast(T value) { }

	// RVA: -1
	public Void AddLast(LinkedListNode<T0> node) { }

	// RVA: -1
	public Void Clear() { }

	// RVA: -1
	public Boolean Contains(T value) { }

	// RVA: -1
	public Void CopyTo(T[] array, Int32 index) { }

	// RVA: -1
	public LinkedListNode<T0> Find(T value) { }

	// RVA: -1
	public Enumerator GetEnumerator() { }

	// RVA: -1
	private IEnumerator<T0> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: -1
	public Boolean Remove(T value) { }

	// RVA: -1
	public Void Remove(LinkedListNode<T0> node) { }

	// RVA: -1
	public Void RemoveFirst() { }

	// RVA: -1
	public Void RemoveLast() { }

	// RVA: -1
	public virtual Void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: -1
	public virtual Void OnDeserialization(Object sender) { }

	// RVA: -1
	private Void InternalInsertNodeBefore(LinkedListNode<T0> node, LinkedListNode<T0> newNode) { }

	// RVA: -1
	private Void InternalInsertNodeToEmptyList(LinkedListNode<T0> newNode) { }

	// RVA: -1
	internal Void InternalRemoveNode(LinkedListNode<T0> node) { }

	// RVA: -1
	internal Void ValidateNewNode(LinkedListNode<T0> node) { }

	// RVA: -1
	internal Void ValidateNode(LinkedListNode<T0> node) { }

	// RVA: -1
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: -1
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: -1
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: -1
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private LinkedList<T0> _list; // 0x0
	private LinkedListNode<T0> _node; // 0x0
	private Int32 _version; // 0x0
	private T _current; // 0x0
	private Int32 _index; // 0x0

	// Properties
	public T Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1
	internal Void .ctor(LinkedList<T0> list) { }

	// RVA: -1
	private Void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: -1
	public T get_Current() { }

	// RVA: -1
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: -1
	public Boolean MoveNext() { }

	// RVA: -1
	private Void System.Collections.IEnumerator.Reset() { }

	// RVA: -1
	public Void Dispose() { }

	// RVA: -1
	private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: -1
	private Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(Object sender) { }

}

// Namespace: System.Collections.Generic
public sealed class LinkedListNode<T0>
{
	// Fields
	internal LinkedList<T0> list; // 0x0
	internal LinkedListNode<T0> next; // 0x0
	internal LinkedListNode<T0> prev; // 0x0
	internal T item; // 0x0

	// Properties
	public LinkedList<T0> List { get; }
	public LinkedListNode<T0> Next { get; }
	public LinkedListNode<T0> Previous { get; }
	public T Value { get; set; }

	// Methods

	// RVA: -1
	public Void .ctor(T value) { }

	// RVA: -1
	internal Void .ctor(LinkedList<T0> list, T value) { }

	// RVA: -1
	public LinkedList<T0> get_List() { }

	// RVA: -1
	public LinkedListNode<T0> get_Next() { }

	// RVA: -1
	public LinkedListNode<T0> get_Previous() { }

	// RVA: -1
	public T get_Value() { }

	// RVA: -1
	public Void set_Value(T value) { }

	// RVA: -1
	internal Void Invalidate() { }

}

// Namespace: System.Collections.Generic
public class Queue<T0>
{
	// Fields
	private T[] _array; // 0x0
	private Int32 _head; // 0x0
	private Int32 _tail; // 0x0
	private Int32 _size; // 0x0
	private Int32 _version; // 0x0
	private Object _syncRoot; // 0x0
	private const Int32 MinimumGrow = 4;
	private const Int32 GrowFactor = 200;

	// Properties
	public Int32 Count { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	public Void .ctor(Int32 capacity) { }

	// RVA: -1
	public Int32 get_Count() { }

	// RVA: -1
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: -1
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: -1
	public Void Clear() { }

	// RVA: -1
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: -1
	public Void Enqueue(T item) { }

	// RVA: -1
	public Enumerator GetEnumerator() { }

	// RVA: -1
	private IEnumerator<T0> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: -1
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: -1
	public T Dequeue() { }

	// RVA: -1
	public T Peek() { }

	// RVA: -1
	public Boolean Contains(T item) { }

	// RVA: -1
	public T[] ToArray() { }

	// RVA: -1
	private Void SetCapacity(Int32 capacity) { }

	// RVA: -1
	private Void MoveNext(ref Int32 index) { }

	// RVA: -1
	private Void ThrowForEmptyQueue() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private readonly Queue<T0> _q; // 0x0
	private readonly Int32 _version; // 0x0
	private Int32 _index; // 0x0
	private T _currentElement; // 0x0

	// Properties
	public T Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1
	internal Void .ctor(Queue<T0> q) { }

	// RVA: -1
	public Void Dispose() { }

	// RVA: -1
	public Boolean MoveNext() { }

	// RVA: -1
	public T get_Current() { }

	// RVA: -1
	private Void ThrowEnumerationNotStartedOrEnded() { }

	// RVA: -1
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: -1
	private Void System.Collections.IEnumerator.Reset() { }

}

// Namespace: System.Collections.Generic
internal sealed class QueueDebugView<T0>
{}

// Namespace: System.Collections.Generic
public class SortedDictionary<T0, T1>
{
	// Fields
	private KeyCollection _keys; // 0x0
	private ValueCollection _values; // 0x0
	private TreeSet<T0> _set; // 0x0

	// Properties
	private Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	public TValue Item { get; set; }
	public Int32 Count { get; }
	public KeyCollection Keys { get; }
	private ICollection<T0> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private IEnumerable<T0> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	public ValueCollection Values { get; }
	private ICollection<T0> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	private IEnumerable<T0> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
	private Boolean System.Collections.IDictionary.IsFixedSize { get; }
	private Boolean System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private Object System.Collections.IDictionary.Item { get; set; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	public Void .ctor(IComparer<T0> comparer) { }

	// RVA: -1
	private Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<T0, T1> keyValuePair) { }

	// RVA: -1
	private Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<T0, T1> keyValuePair) { }

	// RVA: -1
	private Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<T0, T1> keyValuePair) { }

	// RVA: -1
	private Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	// RVA: -1
	public TValue get_Item(TKey key) { }

	// RVA: -1
	public Void set_Item(TKey key, TValue value) { }

	// RVA: -1
	public Int32 get_Count() { }

	// RVA: -1
	public KeyCollection get_Keys() { }

	// RVA: -1
	private ICollection<T0> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	// RVA: -1
	private IEnumerable<T0> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	// RVA: -1
	public ValueCollection get_Values() { }

	// RVA: -1
	private ICollection<T0> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	// RVA: -1
	private IEnumerable<T0> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	// RVA: -1
	public Void Add(TKey key, TValue value) { }

	// RVA: -1
	public Void Clear() { }

	// RVA: -1
	public Boolean ContainsKey(TKey key) { }

	// RVA: -1
	public Boolean ContainsValue(TValue value) { }

	// RVA: -1
	public Void CopyTo(KeyValuePair`2<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44> array, Int32 index) { }

	// RVA: -1
	public Enumerator GetEnumerator() { }

	// RVA: -1
	private IEnumerator<T0> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	// RVA: -1
	public Boolean Remove(TKey key) { }

	// RVA: -1
	public Boolean TryGetValue(TKey key, out TValue value) { }

	// RVA: -1
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: -1
	private Boolean System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: -1
	private Boolean System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: -1
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: -1
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: -1
	private Object System.Collections.IDictionary.get_Item(Object key) { }

	// RVA: -1
	private Void System.Collections.IDictionary.set_Item(Object key, Object value) { }

	// RVA: -1
	private Void System.Collections.IDictionary.Add(Object key, Object value) { }

	// RVA: -1
	private Boolean System.Collections.IDictionary.Contains(Object key) { }

	// RVA: -1
	private static Boolean IsCompatibleKey(Object key) { }

	// RVA: -1
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: -1
	private Void System.Collections.IDictionary.Remove(Object key) { }

	// RVA: -1
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: -1
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: -1
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _treeEnum; // 0x0
	private Int32 _getEnumeratorRetType; // 0x0

	// Properties
	public KeyValuePair<T0, T1> Current { get; }
	internal Boolean NotStartedOrEnded { get; }
	private Object System.Collections.IEnumerator.Current { get; }
	private Object System.Collections.IDictionaryEnumerator.Key { get; }
	private Object System.Collections.IDictionaryEnumerator.Value { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }

	// Methods

	// RVA: -1
	internal Void .ctor(SortedDictionary<T0, T1> dictionary, Int32 getEnumeratorRetType) { }

	// RVA: -1
	public Boolean MoveNext() { }

	// RVA: -1
	public Void Dispose() { }

	// RVA: -1
	public KeyValuePair<T0, T1> get_Current() { }

	// RVA: -1
	internal Boolean get_NotStartedOrEnded() { }

	// RVA: -1
	internal Void Reset() { }

	// RVA: -1
	private Void System.Collections.IEnumerator.Reset() { }

	// RVA: -1
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: -1
	private Object System.Collections.IDictionaryEnumerator.get_Key() { }

	// RVA: -1
	private Object System.Collections.IDictionaryEnumerator.get_Value() { }

	// RVA: -1
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

}

// Namespace: 
public sealed class KeyCollection
{
	// Fields
	private SortedDictionary<T0, T1> _dictionary; // 0x0

	// Properties
	public Int32 Count { get; }
	private Boolean System.Collections.Generic.ICollection<TKey>.IsReadOnly { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1
	public Void .ctor(SortedDictionary<T0, T1> dictionary) { }

	// RVA: -1
	private IEnumerator<T0> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }

	// RVA: -1
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: -1
	public Void CopyTo(TKey[] array, Int32 index) { }

	// RVA: -1
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: -1
	public Int32 get_Count() { }

	// RVA: -1
	private Boolean System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

	// RVA: -1
	private Void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

	// RVA: -1
	private Void System.Collections.Generic.ICollection<TKey>.Clear() { }

	// RVA: -1
	private Boolean System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

	// RVA: -1
	private Boolean System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

	// RVA: -1
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: -1
	private Object System.Collections.ICollection.get_SyncRoot() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _dictEnum; // 0x0

	// Properties
	public TKey Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1
	internal Void .ctor(SortedDictionary<T0, T1> dictionary) { }

	// RVA: -1
	public Void Dispose() { }

	// RVA: -1
	public Boolean MoveNext() { }

	// RVA: -1
	public TKey get_Current() { }

	// RVA: -1
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: -1
	private Void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public TKey[] array; // 0x0
	public Int32 index; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	internal Boolean <CopyTo>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public Int32 index; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_1
{
	// Fields
	public Object[] objects; // 0x0
	public <>c__DisplayClass6_0 CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	internal Boolean <System.Collections.ICollection.CopyTo>b__0(Node node) { }

}

// Namespace: 
public sealed class ValueCollection
{
	// Fields
	private SortedDictionary<T0, T1> _dictionary; // 0x0

	// Properties
	public Int32 Count { get; }
	private Boolean System.Collections.Generic.ICollection<TValue>.IsReadOnly { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1
	public Void .ctor(SortedDictionary<T0, T1> dictionary) { }

	// RVA: -1
	private IEnumerator<T0> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

	// RVA: -1
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: -1
	public Void CopyTo(TValue[] array, Int32 index) { }

	// RVA: -1
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: -1
	public Int32 get_Count() { }

	// RVA: -1
	private Boolean System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

	// RVA: -1
	private Void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

	// RVA: -1
	private Void System.Collections.Generic.ICollection<TValue>.Clear() { }

	// RVA: -1
	private Boolean System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

	// RVA: -1
	private Boolean System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

	// RVA: -1
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: -1
	private Object System.Collections.ICollection.get_SyncRoot() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _dictEnum; // 0x0

	// Properties
	public TValue Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1
	internal Void .ctor(SortedDictionary<T0, T1> dictionary) { }

	// RVA: -1
	public Void Dispose() { }

	// RVA: -1
	public Boolean MoveNext() { }

	// RVA: -1
	public TValue get_Current() { }

	// RVA: -1
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: -1
	private Void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public TValue[] array; // 0x0
	public Int32 index; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	internal Boolean <CopyTo>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public Int32 index; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_1
{
	// Fields
	public Object[] objects; // 0x0
	public <>c__DisplayClass6_0 CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	internal Boolean <System.Collections.ICollection.CopyTo>b__0(Node node) { }

}

// Namespace: 
internal sealed class KeyValuePairComparer
{
	// Fields
	internal IComparer<T0> keyComparer; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor(IComparer<T0> keyComparer) { }

	// RVA: -1
	public override Int32 Compare(KeyValuePair<T0, T1> x, KeyValuePair<T0, T1> y) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public Boolean found; // 0x0
	public TValue value; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	internal Boolean <ContainsValue>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_1
{
	// Fields
	public EqualityComparer<T0> valueComparer; // 0x0
	public <>c__DisplayClass34_0 CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	internal Boolean <ContainsValue>b__1(Node node) { }

}

// Namespace: System.Collections.Generic
internal sealed class TreeSet<T0>
{
	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	public Void .ctor(IComparer<T0> comparer) { }

	// RVA: -1
	public Void .ctor(SerializationInfo siInfo, StreamingContext context) { }

	// RVA: -1
	internal override Boolean AddIfNotPresent(T item) { }

}

// Namespace: System.Collections.Generic
public class SortedList<T0, T1>
{
	// Fields
	private TKey[] keys; // 0x0
	private TValue[] values; // 0x0
	private Int32 _size; // 0x0
	private Int32 version; // 0x0
	private IComparer<T0> comparer; // 0x0
	private KeyList keyList; // 0x0
	private ValueList valueList; // 0x0
	private Object _syncRoot; // 0x0
	private const Int32 DefaultCapacity = 4;
	private const Int32 MaxArrayLength = 2146435071;

	// Properties
	public Int32 Capacity { set; }
	public Int32 Count { get; }
	private ICollection<T0> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private IEnumerable<T0> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	private ICollection<T0> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private IEnumerable<T0> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
	private Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private Boolean System.Collections.IDictionary.IsReadOnly { get; }
	private Boolean System.Collections.IDictionary.IsFixedSize { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }
	public TValue Item { get; set; }
	private Object System.Collections.IDictionary.Item { get; set; }

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	public Void .ctor(Int32 capacity) { }

	// RVA: -1
	public Void Add(TKey key, TValue value) { }

	// RVA: -1
	private Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<T0, T1> keyValuePair) { }

	// RVA: -1
	private Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<T0, T1> keyValuePair) { }

	// RVA: -1
	private Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<T0, T1> keyValuePair) { }

	// RVA: -1
	public Void set_Capacity(Int32 value) { }

	// RVA: -1
	private Void System.Collections.IDictionary.Add(Object key, Object value) { }

	// RVA: -1
	public Int32 get_Count() { }

	// RVA: -1
	private ICollection<T0> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	// RVA: -1
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: -1
	private IEnumerable<T0> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	// RVA: -1
	private ICollection<T0> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	// RVA: -1
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: -1
	private IEnumerable<T0> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	// RVA: -1
	private KeyList GetKeyListHelper() { }

	// RVA: -1
	private ValueList GetValueListHelper() { }

	// RVA: -1
	private Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	// RVA: -1
	private Boolean System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: -1
	private Boolean System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: -1
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: -1
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: -1
	public Void Clear() { }

	// RVA: -1
	private Boolean System.Collections.IDictionary.Contains(Object key) { }

	// RVA: -1
	public Boolean ContainsKey(TKey key) { }

	// RVA: -1
	public Boolean ContainsValue(TValue value) { }

	// RVA: -1
	private Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair`2<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44> array, Int32 arrayIndex) { }

	// RVA: -1
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: -1
	private Void EnsureCapacity(Int32 min) { }

	// RVA: -1
	private TValue GetByIndex(Int32 index) { }

	// RVA: -1
	private IEnumerator<T0> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	// RVA: -1
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: -1
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: -1
	private TKey GetKey(Int32 index) { }

	// RVA: -1
	public TValue get_Item(TKey key) { }

	// RVA: -1
	public Void set_Item(TKey key, TValue value) { }

	// RVA: -1
	private Object System.Collections.IDictionary.get_Item(Object key) { }

	// RVA: -1
	private Void System.Collections.IDictionary.set_Item(Object key, Object value) { }

	// RVA: -1
	public Int32 IndexOfKey(TKey key) { }

	// RVA: -1
	public Int32 IndexOfValue(TValue value) { }

	// RVA: -1
	private Void Insert(Int32 index, TKey key, TValue value) { }

	// RVA: -1
	public Boolean TryGetValue(TKey key, out TValue value) { }

	// RVA: -1
	public Void RemoveAt(Int32 index) { }

	// RVA: -1
	public Boolean Remove(TKey key) { }

	// RVA: -1
	private Void System.Collections.IDictionary.Remove(Object key) { }

	// RVA: -1
	private static Boolean IsCompatibleKey(Object key) { }

}

// Namespace: 
private struct Enumerator
{
	// Fields
	private SortedList<T0, T1> _sortedList; // 0x0
	private TKey _key; // 0x0
	private TValue _value; // 0x0
	private Int32 _index; // 0x0
	private Int32 _version; // 0x0
	private Int32 _getEnumeratorRetType; // 0x0

	// Properties
	private Object System.Collections.IDictionaryEnumerator.Key { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }
	public KeyValuePair<T0, T1> Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }
	private Object System.Collections.IDictionaryEnumerator.Value { get; }

	// Methods

	// RVA: -1
	internal Void .ctor(SortedList<T0, T1> sortedList, Int32 getEnumeratorRetType) { }

	// RVA: -1
	public Void Dispose() { }

	// RVA: -1
	private Object System.Collections.IDictionaryEnumerator.get_Key() { }

	// RVA: -1
	public Boolean MoveNext() { }

	// RVA: -1
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

	// RVA: -1
	public KeyValuePair<T0, T1> get_Current() { }

	// RVA: -1
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: -1
	private Object System.Collections.IDictionaryEnumerator.get_Value() { }

	// RVA: -1
	private Void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
private sealed class SortedListKeyEnumerator
{
	// Fields
	private SortedList<T0, T1> _sortedList; // 0x0
	private Int32 _index; // 0x0
	private Int32 _version; // 0x0
	private TKey _currentKey; // 0x0

	// Properties
	public TKey Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1
	internal Void .ctor(SortedList<T0, T1> sortedList) { }

	// RVA: -1
	public Void Dispose() { }

	// RVA: -1
	public Boolean MoveNext() { }

	// RVA: -1
	public TKey get_Current() { }

	// RVA: -1
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: -1
	private Void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
private sealed class SortedListValueEnumerator
{
	// Fields
	private SortedList<T0, T1> _sortedList; // 0x0
	private Int32 _index; // 0x0
	private Int32 _version; // 0x0
	private TValue _currentValue; // 0x0

	// Properties
	public TValue Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1
	internal Void .ctor(SortedList<T0, T1> sortedList) { }

	// RVA: -1
	public Void Dispose() { }

	// RVA: -1
	public Boolean MoveNext() { }

	// RVA: -1
	public TValue get_Current() { }

	// RVA: -1
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: -1
	private Void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
private sealed class KeyList
{
	// Fields
	private SortedList<T0, T1> _dict; // 0x0

	// Properties
	public Int32 Count { get; }
	public Boolean IsReadOnly { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }
	public TKey Item { get; set; }

	// Methods

	// RVA: -1
	internal Void .ctor(SortedList<T0, T1> dictionary) { }

	// RVA: -1
	public Int32 get_Count() { }

	// RVA: -1
	public Boolean get_IsReadOnly() { }

	// RVA: -1
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: -1
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: -1
	public Void Add(TKey key) { }

	// RVA: -1
	public Void Clear() { }

	// RVA: -1
	public Boolean Contains(TKey key) { }

	// RVA: -1
	public Void CopyTo(TKey[] array, Int32 arrayIndex) { }

	// RVA: -1
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 arrayIndex) { }

	// RVA: -1
	public Void Insert(Int32 index, TKey value) { }

	// RVA: -1
	public TKey get_Item(Int32 index) { }

	// RVA: -1
	public Void set_Item(Int32 index, TKey value) { }

	// RVA: -1
	public IEnumerator<T0> GetEnumerator() { }

	// RVA: -1
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: -1
	public Int32 IndexOf(TKey key) { }

	// RVA: -1
	public Boolean Remove(TKey key) { }

	// RVA: -1
	public Void RemoveAt(Int32 index) { }

}

// Namespace: 
private sealed class ValueList
{
	// Fields
	private SortedList<T0, T1> _dict; // 0x0

	// Properties
	public Int32 Count { get; }
	public Boolean IsReadOnly { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }
	public TValue Item { get; set; }

	// Methods

	// RVA: -1
	internal Void .ctor(SortedList<T0, T1> dictionary) { }

	// RVA: -1
	public Int32 get_Count() { }

	// RVA: -1
	public Boolean get_IsReadOnly() { }

	// RVA: -1
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: -1
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: -1
	public Void Add(TValue key) { }

	// RVA: -1
	public Void Clear() { }

	// RVA: -1
	public Boolean Contains(TValue value) { }

	// RVA: -1
	public Void CopyTo(TValue[] array, Int32 arrayIndex) { }

	// RVA: -1
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: -1
	public Void Insert(Int32 index, TValue value) { }

	// RVA: -1
	public TValue get_Item(Int32 index) { }

	// RVA: -1
	public Void set_Item(Int32 index, TValue value) { }

	// RVA: -1
	public IEnumerator<T0> GetEnumerator() { }

	// RVA: -1
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: -1
	public Int32 IndexOf(TValue value) { }

	// RVA: -1
	public Boolean Remove(TValue value) { }

	// RVA: -1
	public Void RemoveAt(Int32 index) { }

}

// Namespace: System.Collections.Generic
public class SortedSet<T0>
{
	// Fields
	private Node root; // 0x0
	private IComparer<T0> comparer; // 0x0
	private Int32 count; // 0x0
	private Int32 version; // 0x0
	private Object _syncRoot; // 0x0
	private SerializationInfo siInfo; // 0x0

	// Properties
	public Int32 Count { get; }
	private Boolean System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	public Void .ctor(IComparer<T0> comparer) { }

	// RVA: -1
	protected Void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: -1
	internal virtual Boolean InOrderTreeWalk(TreeWalkPredicate<T0> action) { }

	// RVA: -1
	public Int32 get_Count() { }

	// RVA: -1
	private Boolean System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	// RVA: -1
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: -1
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: -1
	internal virtual Void VersionCheck() { }

	// RVA: -1
	internal virtual Boolean IsWithinRange(T item) { }

	// RVA: -1
	public Boolean Add(T item) { }

	// RVA: -1
	private Void System.Collections.Generic.ICollection<T>.Add(T item) { }

	// RVA: -1
	internal virtual Boolean AddIfNotPresent(T item) { }

	// RVA: -1
	public Boolean Remove(T item) { }

	// RVA: -1
	internal virtual Boolean DoRemove(T item) { }

	// RVA: -1
	public virtual Void Clear() { }

	// RVA: -1
	public virtual Boolean Contains(T item) { }

	// RVA: -1
	public Void CopyTo(T[] array, Int32 index) { }

	// RVA: -1
	public Void CopyTo(T[] array, Int32 index, Int32 count) { }

	// RVA: -1
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: -1
	public Enumerator GetEnumerator() { }

	// RVA: -1
	private IEnumerator<T0> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: -1
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: -1
	private Void InsertionBalance(Node current, ref Node parent, Node grandParent, Node greatGrandParent) { }

	// RVA: -1
	private Void ReplaceChildOrRoot(Node parent, Node child, Node newChild) { }

	// RVA: -1
	private Void ReplaceNode(Node match, Node parentOfMatch, Node successor, Node parentOfSuccessor) { }

	// RVA: -1
	internal virtual Node FindNode(T item) { }

	// RVA: -1
	internal Void UpdateVersion() { }

	// RVA: -1
	private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: -1
	protected virtual Void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: -1
	private Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(Object sender) { }

	// RVA: -1
	protected virtual Void OnDeserialization(Object sender) { }

	// RVA: -1
	private static Int32 Log2(Int32 value) { }

}

// Namespace: 
internal sealed class Node
{
	// Fields
	private T <Item>k__BackingField; // 0x0
	private Node <Left>k__BackingField; // 0x0
	private Node <Right>k__BackingField; // 0x0
	private NodeColor <Color>k__BackingField; // 0x0

	// Properties
	public T Item { get; set; }
	public Node Left { get; set; }
	public Node Right { get; set; }
	public NodeColor Color { get; set; }
	public Boolean IsBlack { get; }
	public Boolean IsRed { get; }
	public Boolean Is2Node { get; }
	public Boolean Is4Node { get; }

	// Methods

	// RVA: -1
	public Void .ctor(T item, NodeColor color) { }

	// RVA: -1
	public static Boolean IsNonNullRed(Node node) { }

	// RVA: -1
	public static Boolean IsNullOrBlack(Node node) { }

	// RVA: -1
	public T get_Item() { }

	// RVA: -1
	public Void set_Item(T value) { }

	// RVA: -1
	public Node get_Left() { }

	// RVA: -1
	public Void set_Left(Node value) { }

	// RVA: -1
	public Node get_Right() { }

	// RVA: -1
	public Void set_Right(Node value) { }

	// RVA: -1
	public NodeColor get_Color() { }

	// RVA: -1
	public Void set_Color(NodeColor value) { }

	// RVA: -1
	public Boolean get_IsBlack() { }

	// RVA: -1
	public Boolean get_IsRed() { }

	// RVA: -1
	public Boolean get_Is2Node() { }

	// RVA: -1
	public Boolean get_Is4Node() { }

	// RVA: -1
	public Void ColorBlack() { }

	// RVA: -1
	public Void ColorRed() { }

	// RVA: -1
	public TreeRotation GetRotation(Node current, Node sibling) { }

	// RVA: -1
	public Node GetSibling(Node node) { }

	// RVA: -1
	public Void Split4Node() { }

	// RVA: -1
	public Node Rotate(TreeRotation rotation) { }

	// RVA: -1
	public Node RotateLeft() { }

	// RVA: -1
	public Node RotateLeftRight() { }

	// RVA: -1
	public Node RotateRight() { }

	// RVA: -1
	public Node RotateRightLeft() { }

	// RVA: -1
	public Void Merge2Nodes() { }

	// RVA: -1
	public Void ReplaceChild(Node child, Node newChild) { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private static readonly Node s_dummyNode; // 0x0
	private SortedSet<T0> _tree; // 0x0
	private Int32 _version; // 0x0
	private Stack<T0> _stack; // 0x0
	private Node _current; // 0x0
	private Boolean _reverse; // 0x0

	// Properties
	public T Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }
	internal Boolean NotStartedOrEnded { get; }

	// Methods

	// RVA: -1
	internal Void .ctor(SortedSet<T0> set) { }

	// RVA: -1
	internal Void .ctor(SortedSet<T0> set, Boolean reverse) { }

	// RVA: -1
	private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: -1
	private Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(Object sender) { }

	// RVA: -1
	private Void Initialize() { }

	// RVA: -1
	public Boolean MoveNext() { }

	// RVA: -1
	public Void Dispose() { }

	// RVA: -1
	public T get_Current() { }

	// RVA: -1
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: -1
	internal Boolean get_NotStartedOrEnded() { }

	// RVA: -1
	internal Void Reset() { }

	// RVA: -1
	private Void System.Collections.IEnumerator.Reset() { }

	// RVA: -1
	private static Void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass52_0
{
	// Fields
	public Int32 index; // 0x0
	public Int32 count; // 0x0
	public T[] array; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	internal Boolean <CopyTo>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0
{
	// Fields
	public Int32 index; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_1
{
	// Fields
	public Object[] objects; // 0x0
	public <>c__DisplayClass53_0 CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	internal Boolean <System.Collections.ICollection.CopyTo>b__0(Node node) { }

}

// Namespace: System.Collections.Generic
internal enum NodeColor
{
	// Fields
	public Byte value__; // 0x10
	public const NodeColor Black = 0;
	public const NodeColor Red = 1;
}

// Namespace: System.Collections.Generic
internal sealed class TreeWalkPredicate<T0>
{
	// Methods

	// RVA: -1
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: -1
	public virtual Boolean Invoke(Node node) { }

	// RVA: -1
	public virtual IAsyncResult BeginInvoke(Node node, AsyncCallback callback, Object object) { }

	// RVA: -1
	public virtual Boolean EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Collections.Generic
internal enum TreeRotation
{
	// Fields
	public Byte value__; // 0x10
	public const TreeRotation Left = 0;
	public const TreeRotation LeftRight = 1;
	public const TreeRotation Right = 2;
	public const TreeRotation RightLeft = 3;
}

// Namespace: System.Collections.Generic
public class Stack<T0>
{
	// Fields
	private T[] _array; // 0x0
	private Int32 _size; // 0x0
	private Int32 _version; // 0x0
	private Object _syncRoot; // 0x0
	private const Int32 DefaultCapacity = 4;

	// Properties
	public Int32 Count { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	public Void .ctor(Int32 capacity) { }

	// RVA: -1
	public Int32 get_Count() { }

	// RVA: -1
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: -1
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: -1
	public Void Clear() { }

	// RVA: -1
	public Boolean Contains(T item) { }

	// RVA: -1
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 arrayIndex) { }

	// RVA: -1
	public Enumerator GetEnumerator() { }

	// RVA: -1
	private IEnumerator<T0> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: -1
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: -1
	public T Peek() { }

	// RVA: -1
	public T Pop() { }

	// RVA: -1
	public Void Push(T item) { }

	// RVA: -1
	public T[] ToArray() { }

	// RVA: -1
	private Void ThrowForEmptyStack() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private readonly Stack<T0> _stack; // 0x0
	private readonly Int32 _version; // 0x0
	private Int32 _index; // 0x0
	private T _currentElement; // 0x0

	// Properties
	public T Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1
	internal Void .ctor(Stack<T0> stack) { }

	// RVA: -1
	public Void Dispose() { }

	// RVA: -1
	public Boolean MoveNext() { }

	// RVA: -1
	public T get_Current() { }

	// RVA: -1
	private Void ThrowEnumerationNotStartedOrEnded() { }

	// RVA: -1
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: -1
	private Void System.Collections.IEnumerator.Reset() { }

}

// Namespace: System.Collections.Generic
internal sealed class StackDebugView<T0>
{}

// Namespace: System.Collections.Generic
public interface ISet<T0>
{}

// Namespace: System.Collections.Concurrent
public class ConcurrentBag<T0>
{
	// Fields
	private ThreadLocal<T0> _locals; // 0x0
	private WorkStealingQueue _workStealingQueues; // 0x0

	// Properties
	public Int32 Count { get; }
	private Int32 DangerousCount { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }
	private Object GlobalQueuesLock { get; }

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	public Void Add(T item) { }

	// RVA: -1
	public Boolean TryTake(out T result) { }

	// RVA: -1
	private WorkStealingQueue GetCurrentThreadWorkStealingQueue(Boolean forceCreate) { }

	// RVA: -1
	private WorkStealingQueue CreateWorkStealingQueueForCurrentThread() { }

	// RVA: -1
	private WorkStealingQueue GetUnownedWorkStealingQueue() { }

	// RVA: -1
	private Boolean TrySteal(out T result, Boolean take) { }

	// RVA: -1
	private Boolean TryStealFromTo(WorkStealingQueue startInclusive, WorkStealingQueue endExclusive, out T result, Boolean take) { }

	// RVA: -1
	public Void CopyTo(T[] array, Int32 index) { }

	// RVA: -1
	private Int32 CopyFromEachQueueToArray(T[] array, Int32 index) { }

	// RVA: -1
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: -1
	public T[] ToArray() { }

	// RVA: -1
	public IEnumerator<T0> GetEnumerator() { }

	// RVA: -1
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: -1
	public Int32 get_Count() { }

	// RVA: -1
	private Int32 get_DangerousCount() { }

	// RVA: -1
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: -1
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: -1
	private Object get_GlobalQueuesLock() { }

	// RVA: -1
	private Void FreezeBag(ref Boolean lockTaken) { }

	// RVA: -1
	private Void UnfreezeBag(Boolean lockTaken) { }

}

// Namespace: 
private sealed class WorkStealingQueue
{
	// Fields
	private Int32 _headIndex; // 0x0
	private Int32 _tailIndex; // 0x0
	private T[] _array; // 0x0
	private Int32 _mask; // 0x0
	private Int32 _addTakeCount; // 0x0
	private Int32 _stealCount; // 0x0
	internal Int32 _currentOp; // 0x0
	internal Boolean _frozen; // 0x0
	internal readonly WorkStealingQueue _nextQueue; // 0x0
	internal readonly Int32 _ownerThreadId; // 0x0

	// Properties
	internal Int32 DangerousCount { get; }

	// Methods

	// RVA: -1
	internal Void .ctor(WorkStealingQueue nextQueue) { }

	// RVA: -1
	internal Void LocalPush(T item) { }

	// RVA: -1
	internal Boolean TryLocalPop(out T result) { }

	// RVA: -1
	internal Boolean TrySteal(out T result, Boolean take) { }

	// RVA: -1
	internal Int32 DangerousCopyTo(T[] array, Int32 arrayIndex) { }

	// RVA: -1
	internal Int32 get_DangerousCount() { }

}

// Namespace: 
private sealed class Enumerator
{
	// Fields
	private readonly T[] _array; // 0x0
	private T _current; // 0x0
	private Int32 _index; // 0x0

	// Properties
	public T Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1
	public Void .ctor(T[] array) { }

	// RVA: -1
	public Boolean MoveNext() { }

	// RVA: -1
	public T get_Current() { }

	// RVA: -1
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: -1
	public Void Reset() { }

	// RVA: -1
	public Void Dispose() { }

}

// Namespace: System.Collections.Concurrent
internal sealed class CDSCollectionETWBCLProvider
{
	// Fields
	public static CDSCollectionETWBCLProvider Log; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75B08B74
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF75B08BB4
	public Void ConcurrentBag_TryTakeSteals() { }

	// RVA: 0xFFFFFFFF75B08BB8
	public Void ConcurrentBag_TryPeekSteals() { }

	// RVA: 0xFFFFFFFF75B08BBC
	private static Void .cctor() { }

}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=14 0283A6AF88802AB45989B29549915BEA0F6CD515; // 0x0
	internal static readonly Int64 03F4297FCC30D0FD5E420E5D26E7FA711167C7EF; // 0x10
	internal static readonly __StaticArrayInitTypeSize=9 1A39764B112685485A5BA7B2880D878B858C1A7A; // 0x18
	internal static readonly __StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD; // 0x21
	internal static readonly __StaticArrayInitTypeSize=12 3AF058944BC1070D164143C7635654884348D0E1; // 0x24
	internal static readonly __StaticArrayInitTypeSize=12 3BE77BF818331C2D8400FFFFF9FADD3F16AD89AC; // 0x30
	internal static readonly __StaticArrayInitTypeSize=10 53437C3B2572EDB9B8640C3195DF3BC2729C5EA1; // 0x3C
	internal static readonly __StaticArrayInitTypeSize=32 59F5BD34B6C013DEACC784F69C67E95150033A84; // 0x46
	internal static readonly __StaticArrayInitTypeSize=6 5BC3486B05BA8CF4689C7BDB198B3F477BB4E20C; // 0x66
	internal static readonly __StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D; // 0x6C
	internal static readonly __StaticArrayInitTypeSize=128 6F3AD3DC3AF8047587C4C9D696EB68A01FEF796E; // 0x75
	internal static readonly __StaticArrayInitTypeSize=6 8821BF2BDFF225D177372C9F3E0A8286EE241FF4; // 0xF5
	internal static readonly __StaticArrayInitTypeSize=44 8E0EF3D67A3EB1863224EE3CACB424BC2F8CFBA3; // 0xFB
	internal static readonly Int64 98A44A6F8606AE6F23FE230286C1D6FBCC407226; // 0x128
	internal static readonly __StaticArrayInitTypeSize=32 C02C28AFEBE998F767E4AF43E3BE8F5E9FA11536; // 0x130
	internal static readonly __StaticArrayInitTypeSize=128 CCEEADA43268372341F81AE0C9208C6856441C04; // 0x150
	internal static readonly Int64 E5BC1BAFADE1862DD6E0B9FB632BFAA6C3873A78; // 0x1D0
	internal static readonly __StaticArrayInitTypeSize=32 EC5842B3154E1AF94500B57220EB9F684BCCC42A; // 0x1D8
	internal static readonly __StaticArrayInitTypeSize=256 EEAFE8C6E1AB017237567305EE925C976CDB6458; // 0x1F8

	// Methods

	// RVA: 0xFFFFFFFF75AEFC74
	internal static UInt32 ComputeStringHash(String s) { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=3
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=6
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=9
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=10
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=12
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=14
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=32
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=44
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=128
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=256
{}

// Namespace: System.Configuration
public interface IConfigurationSectionHandler
{}

// Namespace: System.Net.Configuration
public sealed class BypassElement
{}

// Namespace: System.Net.Configuration
public sealed class BypassElementCollection
{
	// Methods

	// RVA: 0xFFFFFFFF75B4450C
	public Void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementElement
{}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementElementCollection
{
	// Methods

	// RVA: 0xFFFFFFFF75B44544
	public Void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementSection
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B4457C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B445B4
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class DefaultProxySection
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B445EC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B44624
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0xFFFFFFFF75B4465C
	protected override Void Reset(ConfigurationElement parentElement) { }

}

// Namespace: System.Net.Configuration
public sealed class ProxyElement
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B4495C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B44994
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class HttpWebRequestElement
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B447D4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B4480C
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class Ipv6Element
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B44844
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B4487C
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class NetSectionGroup
{
	// Methods

	// RVA: 0xFFFFFFFF75B448B4
	public Void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class SettingsSection
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B44A3C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B44A74
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class PerformanceCountersElement
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B448EC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B44924
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class ServicePointManagerElement
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B449CC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B44A04
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class SocketElement
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B44B60
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B44B98
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class WebProxyScriptElement
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B44BD0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B44C08
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class WebRequestModulesSection
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75B44C78
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B44CB0
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class WebRequestModuleElementCollection
{
	// Methods

	// RVA: 0xFFFFFFFF75B44C40
	public Void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class WebRequestModuleElement
{}

// Namespace: System.Diagnostics
public class DiagnosticsConfigurationHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75B3AD64
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75B3AD9C
	public virtual Object Create(Object parent, Object configContext, XmlNode section) { }

}

// Namespace: Unity
internal sealed class ThrowStub
{
	// Methods

	// RVA: 0xFFFFFFFF75BBC550
	public static Void ThrowNotSupportedException() { }

}


