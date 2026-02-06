// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public static class RemoteSettings
{
	// Fields
	private static UpdatedEventHandler Updated; // 0x0
	private static Action BeforeFetchFromServer; // 0x8
	private static Action<T0, T1, T2> Completed; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75CA2540
	internal static Void RemoteSettingsUpdated(Boolean wasLastUpdatedFromServer) { }

	// RVA: 0xFFFFFFFF75CA2794
	internal static Void RemoteSettingsBeforeFetchFromServer() { }

	// RVA: 0xFFFFFFFF75CA27F0
	internal static Void RemoteSettingsUpdateCompleted(Boolean wasLastUpdatedFromServer, Boolean settingsChanged, Int32 response) { }

}

// Namespace: 
public sealed class UpdatedEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75CA2880
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75CA2598
	public virtual Void Invoke() { }

	// RVA: 0xFFFFFFFF75CA2894
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75CA28EC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine
public class RemoteConfigSettings
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private Action<T0> Updated; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75CA2510
	internal static Void RemoteConfigSettingsUpdated(RemoteConfigSettings rcs, Boolean wasLastUpdatedFromServer) { }

}

// Namespace: UnityEngine
internal static class RemoteConfigSettingsHelper
{}

// Namespace: 
internal enum Tag
{
	// Fields
	public Int32 value__; // 0x10
	public const Tag kUnknown = 0;
	public const Tag kIntVal = 1;
	public const Tag kInt64Val = 2;
	public const Tag kUInt64Val = 3;
	public const Tag kDoubleVal = 4;
	public const Tag kBoolVal = 5;
	public const Tag kStringVal = 6;
	public const Tag kArrayVal = 7;
	public const Tag kMixedArrayVal = 8;
	public const Tag kMapVal = 9;
	public const Tag kMaxTags = 10;
}

// Namespace: UnityEngine.Analytics
public class ContinuousEvent
{}

// Namespace: UnityEngine.Analytics
public enum AnalyticsSessionState
{
	// Fields
	public Int32 value__; // 0x10
	public const AnalyticsSessionState kSessionStopped = 0;
	public const AnalyticsSessionState kSessionStarted = 1;
	public const AnalyticsSessionState kSessionPaused = 2;
	public const AnalyticsSessionState kSessionResumed = 3;
}

// Namespace: UnityEngine.Analytics
public static class AnalyticsSessionInfo
{
	// Fields
	private static SessionStateChanged sessionStateChanged; // 0x0
	private static IdentityTokenChanged identityTokenChanged; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75CA1CFC
	internal static Void CallSessionStateChanged(AnalyticsSessionState sessionState, Int64 sessionId, Int64 sessionElapsedTime, Boolean sessionChanged) { }

	// RVA: 0xFFFFFFFF75CA1FE0
	internal static Void CallIdentityTokenChanged(String token) { }

}

// Namespace: 
public sealed class SessionStateChanged
{
	// Methods

	// RVA: 0xFFFFFFFF75CA2400
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75CA1D28
	public virtual Void Invoke(AnalyticsSessionState sessionState, Int64 sessionId, Int64 sessionElapsedTime, Boolean sessionChanged) { }

	// RVA: 0xFFFFFFFF75CA2414
	public virtual IAsyncResult BeginInvoke(AnalyticsSessionState sessionState, Int64 sessionId, Int64 sessionElapsedTime, Boolean sessionChanged, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75CA2504
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class IdentityTokenChanged
{
	// Methods

	// RVA: 0xFFFFFFFF75CA2390
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75CA2000
	public virtual Void Invoke(String token) { }

	// RVA: 0xFFFFFFFF75CA23A4
	public virtual IAsyncResult BeginInvoke(String token, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75CA23F4
	public virtual Void EndInvoke(IAsyncResult result) { }

}


