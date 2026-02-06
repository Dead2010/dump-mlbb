// Namespace: 
internal class <Module>
{}

// Namespace: 
public class AVProAOT
{
	// Methods

	// RVA: 0xFFFFFFFF75972E24
	public static String AVPGetVersion() { }

	// RVA: 0xFFFFFFFF75972E38
	public static IntPtr AVPGetRenderEventFunc() { }

	// RVA: 0xFFFFFFFF75972E40
	public static ErrorCode AVPPlayerGetLastError(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972E48
	public static Double AVPPlayerGetCurrentTime(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972E50
	public static Double AVPPlayerGetCurrentDate(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972E58
	public static Double AVPPlayerGetDuration(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972E60
	public static Int32 AVPPlayerGetFrameCount(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972E68
	public static Double AVPPlayerGetFrameRate(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972E70
	public static Int64 AVPPlayerGetFrameTimeStamp(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972E78
	public static Single AVPPlayerGetNominalFrameRate(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972E80
	public static Int32 AVPPlayerGetHandle(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972E88
	public static AVPPlayerStatus AVPPlayerGetStatus(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972E90
	public static Single AVPPlayerGetBufferingProgress(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972E98
	public static Int32 AVPPlayerGetBufferedTimeRangeCount(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972EA0
	public static Boolean AVPPlayerGetBufferedTimeRange(IntPtr player, Int32 index, out Single start, out Single end) { }

	// RVA: 0xFFFFFFFF75972EB0
	public static Int32 AVPPlayerGetSeekableTimeRanges(IntPtr player, [In] [Out] AVPPlayerTimeRange[] ranges, ref Int32 count) { }

	// RVA: 0xFFFFFFFF75972EB8
	public static Boolean AVPPlayerGetTextures(IntPtr player, [In] [Out] AVPPlayerTextureInfo[] textures, ref Int32 count) { }

	// RVA: 0xFFFFFFFF75972EC0
	public static Boolean AVPPlayerGetTextureTransform(IntPtr player, [In] [Out] Single[] transform) { }

	// RVA: 0xFFFFFFFF75972EC8
	public static Boolean AVPPlayerGetYpCbCrTransform(IntPtr player, ref Single transform) { }

	// RVA: 0xFFFFFFFF75972ED0
	public static Single AVPPlayerGetVolume(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972ED8
	public static Boolean AVPPlayerHasAudio(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972EE0
	public static Boolean AVPPlayerHasVideo(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972EE8
	public static Boolean AVPPlayerHasMetaData(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972EF0
	public static Boolean AVPPlayerIsLooping(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972EF8
	public static Void AVPPlayerSetLooping(IntPtr player, Boolean looping) { }

	// RVA: 0xFFFFFFFF75972EFC
	public static Boolean AVPPlayerIsMuted(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972F04
	public static Void AVPPlayerSetMuted(IntPtr player, Boolean muted) { }

	// RVA: 0xFFFFFFFF75972F08
	public static Void AVPPlayerSetVolume(IntPtr player, Single volume) { }

	// RVA: 0xFFFFFFFF75972F0C
	public static IntPtr AVPPlayerNew(Boolean useYuv) { }

	// RVA: 0xFFFFFFFF75972F14
	public static IntPtr AVPPlayerRelease(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972F1C
	public static Boolean AVPPlayerOpenFile(IntPtr player, String path) { }

	// RVA: 0xFFFFFFFF75972F24
	public static Boolean AVPPlayerOpenURL(IntPtr player, String url, String headers) { }

	// RVA: 0xFFFFFFFF75972F2C
	public static Void AVPPlayerClose(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972F30
	public static Void AVPPlayerPlay(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972F34
	public static Void AVPPlayerPause(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972F38
	public static Void AVPPlayerSeek(IntPtr player, Double time) { }

	// RVA: 0xFFFFFFFF75972F3C
	public static Void AVPPlayerSeekFast(IntPtr player, Double time) { }

	// RVA: 0xFFFFFFFF75972F40
	public static Void AVPPlayerSeekWithTolerance(IntPtr player, Double time, Double before, Double after) { }

	// RVA: 0xFFFFFFFF75972F44
	public static Single AVPPlayerGetPlaybackRate(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972F4C
	public static Void AVPPlayerSetPlaybackRate(IntPtr player, Single rate) { }

	// RVA: 0xFFFFFFFF75972F50
	public static Boolean AVPPlayerUpdate(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972F58
	public static Int32 AVPPlayerGetAudioTrackCount(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972F60
	public static String AVPPlayerGetAudioTrackId(IntPtr player, Int32 index) { }

	// RVA: 0xFFFFFFFF75972F74
	public static Int32 AVPPlayerGetCurrentAudioTrack(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972F7C
	public static String AVPPlayerGetCurrentAudioTrackId(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972F90
	public static Int32 AVPPlayerGetCurrentAudioTrackBitrate(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972F98
	public static Int32 AVPPlayerGetVideoTrackCount(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972FA0
	public static String AVPPlayerGetVideoTrackId(IntPtr player, Int32 index) { }

	// RVA: 0xFFFFFFFF75972FB4
	public static Int32 AVPPlayerGetCurrentVideoTrack(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972FBC
	public static String AVPPlayerGetCurrentVideoTrackId(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972FD0
	public static Int32 AVPPlayerGetCurrentVideoTrackBitrate(IntPtr player) { }

	// RVA: 0xFFFFFFFF75972FD8
	public static Void AVPPlayerSetAudioTrack(IntPtr player, Int32 track) { }

	// RVA: 0xFFFFFFFF75972FDC
	public static Void AVPPlayerSetVideoTrack(IntPtr player, Int32 track) { }

	// RVA: 0xFFFFFFFF75972FE0
	public static Int32 AVPPlayerExtractFrame(IntPtr player, [In] [Out] AVPPlayerTextureInfo[] textures, ref Int32 count, Double timeout) { }

	// RVA: 0xFFFFFFFF75972FE8
	public static Void AVPPlayerAddValueDidChangeObserver(IntPtr player, IntPtr self, IntPtr callback, String key, UInt32 flags) { }

	// RVA: 0xFFFFFFFF75972FEC
	public static Void AVPPlayerSetKeyServerURL(IntPtr player, String url) { }

	// RVA: 0xFFFFFFFF75972FF0
	public static Void AVPPlayerSetKeyServerAuthToken(IntPtr player, String token) { }

	// RVA: 0xFFFFFFFF75972FF4
	public static Void AVPPlayerSetDecryptionKeyBase64(IntPtr player, String key) { }

	// RVA: 0xFFFFFFFF75972FF8
	public static Void AVPPlayerSetDecryptionKey(IntPtr player, Byte[] key, Int32 len) { }

	// RVA: 0xFFFFFFFF75972FFC
	public static Void AVPlayerSetPlayWithoutBuffering(IntPtr player, Boolean playWithoutBuffering) { }

	// RVA: 0xFFFFFFFF75973000
	public static Void AVPPluginRegister() { }

	// RVA: 0xFFFFFFFF75973004
	public static Void AVPPluginInitialise(AVPPluginColorSpace colorSpace) { }

	// RVA: 0xFFFFFFFF75973008
	public static Void AVPPluginSetDebugLogFunction(IntPtr fn) { }

	// RVA: 0xFFFFFFFF7597300C
	public Void .ctor() { }

}

// Namespace: 
public enum ErrorCode
{
	// Fields
	public Int32 value__; // 0x10
	public const ErrorCode None = 0;
	public const ErrorCode LoadFailed = 100;
	public const ErrorCode DecodeFailed = 200;
}

// Namespace: 
public struct AVPPlayerTextureInfo
{
	// Fields
	public IntPtr native; // 0x10
	public Int32 width; // 0x18
	public Int32 height; // 0x1C
	public Int32 format; // 0x20
	public Int32 flipped; // 0x24
}

// Namespace: 
public struct AVPPlayerTimeRange
{
	// Fields
	public Double start; // 0x10
	public Double duration; // 0x18
}

// Namespace: 
public enum AVPPluginColorSpace
{
	// Fields
	public Int32 value__; // 0x10
	public const AVPPluginColorSpace Uninitialized = 0;
	public const AVPPluginColorSpace Gamma = 1;
	public const AVPPluginColorSpace Linear = 2;
}

// Namespace: 
public enum AVPPlayerStatus
{
	// Fields
	public Int32 value__; // 0x10
	public const AVPPlayerStatus Failed = 4294967295;
	public const AVPPlayerStatus Unknown = 0;
	public const AVPPlayerStatus ReadyToPlay = 1;
	public const AVPPlayerStatus Playing = 2;
	public const AVPPlayerStatus Finished = 3;
	public const AVPPlayerStatus Seeking = 4;
	public const AVPPlayerStatus Buffering = 5;
}

// Namespace: 
public class AdjustiOSLib
{
	// Methods

	// RVA: 0xFFFFFFFF75973014
	public static extern Void _AdjustSetEnabled(Int32 enabled) { }

	// RVA: 0xFFFFFFFF75973018
	public static extern Int32 _AdjustIsEnabled() { }

	// RVA: 0xFFFFFFFF7597301C
	public static extern Void _AdjustSetOfflineMode(Int32 enabled) { }

	// RVA: 0xFFFFFFFF75973020
	public static extern Void _AdjustSetDeviceToken(String deviceToken) { }

	// RVA: 0xFFFFFFFF75973048
	public static extern Void _AdjustAppWillOpenUrl(String url) { }

	// RVA: 0xFFFFFFFF75973070
	public static extern String _AdjustGetIdfa() { }

	// RVA: 0xFFFFFFFF759730A4
	public static extern String _AdjustGetAdid() { }

	// RVA: 0xFFFFFFFF759730D8
	public static extern String _AdjustGetSdkVersion() { }

	// RVA: 0xFFFFFFFF7597310C
	public static extern Void _AdjustGdprForgetMe() { }

	// RVA: 0xFFFFFFFF75973110
	public static extern Void _AdjustDisableThirdPartySharing() { }

	// RVA: 0xFFFFFFFF75973114
	public static extern String _AdjustGetAttribution() { }

	// RVA: 0xFFFFFFFF75973148
	public static extern Void _AdjustSendFirstPackages() { }

	// RVA: 0xFFFFFFFF7597314C
	public static extern Void _AdjustAddSessionPartnerParameter(String key, String value) { }

	// RVA: 0xFFFFFFFF75973194
	public static extern Void _AdjustAddSessionCallbackParameter(String key, String value) { }

	// RVA: 0xFFFFFFFF759731DC
	public static extern Void _AdjustRemoveSessionPartnerParameter(String key) { }

	// RVA: 0xFFFFFFFF75973204
	public static extern Void _AdjustRemoveSessionCallbackParameter(String key) { }

	// RVA: 0xFFFFFFFF7597322C
	public static extern Void _AdjustResetSessionPartnerParameters() { }

	// RVA: 0xFFFFFFFF75973230
	public static extern Void _AdjustResetSessionCallbackParameters() { }

	// RVA: 0xFFFFFFFF75973234
	public static extern Void _AdjustTrackAdRevenue(String source, String payload) { }

	// RVA: 0xFFFFFFFF7597327C
	public static extern Void _AdjustTrackAppStoreSubscription(String price, String currency, String transactionId, String receipt, String billingStore, String transactionDate, String salesRegion, String jsonCallbackParameters, String jsonPartnerParameters) { }

	// RVA: 0xFFFFFFFF759733B0
	public static Void _AdjustTrackThirdPartySharing(Int32 enabled, String jsonGranularOptions) { }

	// RVA: 0xFFFFFFFF759733B4
	public static extern Void _AdjustTrackMeasurementConsent(Int32 enabled) { }

	// RVA: 0xFFFFFFFF759733B8
	public static Void _AdjustSetTestOptions(String baseUrl, String gdprUrl, String subscriptionUrl, String extraPath, Int64 timerIntervalInMilliseconds, Int64 timerStartInMilliseconds, Int64 sessionIntervalInMilliseconds, Int64 subsessionIntervalInMilliseconds, Int32 teardown, Int32 deleteState, Int32 noBackoffWait, Int32 iAdFrameworkEnabled, Int32 adServicesFrameworkEnabled) { }

	// RVA: 0xFFFFFFFF759733BC
	public static extern Void _AdjustRequestTrackingAuthorizationWithCompletionHandler(String sceneName) { }

	// RVA: 0xFFFFFFFF759733E4
	public static extern Void _AdjustUpdateConversionValue(Int32 conversionValue) { }

	// RVA: 0xFFFFFFFF759733E8
	public static extern Int32 _AdjustGetAppTrackingAuthorizationStatus() { }

	// RVA: 0xFFFFFFFF759733EC
	public static extern Void _AdjustTrackSubsessionStart() { }

	// RVA: 0xFFFFFFFF759733F0
	public static extern Void _AdjustTrackSubsessionEnd() { }

	// RVA: 0xFFFFFFFF759733F4
	public Void .ctor() { }

}

// Namespace: 
public class BrowserPlguinLib
{
	// Methods

	// RVA: 0xFFFFFFFF75976DF0
	public static extern Void _IOS_RegisterBrowserHelper(String gameObjectName, String callbackFuncName) { }

	// RVA: 0xFFFFFFFF75976E38
	public static extern Void _IOS_BrowserOpen(String url) { }

	// RVA: 0xFFFFFFFF75976E60
	public Void .ctor() { }

}

// Namespace: 
public class DeeplinkManagerLib
{
	// Methods

	// RVA: 0xFFFFFFFF75977948
	public static extern String _GetDeepLinkURL() { }

	// RVA: 0xFFFFFFFF7597797C
	public Void .ctor() { }

}

// Namespace: 
public class GameEntryLib
{
	// Methods

	// RVA: 0xFFFFFFFF7597C584
	public static extern String _IOS_GetUnityVendorIdentifier() { }

	// RVA: 0xFFFFFFFF7597C5B8
	public static extern String MLSDK_IOS_AppInfo_GetChannel() { }

	// RVA: 0xFFFFFFFF7597C5EC
	public Void .ctor() { }

}

// Namespace: 
public class GameRTCiOSLib
{
	// Methods

	// RVA: 0xFFFFFFFF7597C5F4
	public static extern Void _rtcCreateEngine(String parametersJson, String callbackGameObjectName, String callbackMethodName) { }

	// RVA: 0xFFFFFFFF7597C660
	public static extern Int32 _rtcJoinRoom(String roomId, String userId, String token, Int32 roomType, Boolean enableRangeAudio, Boolean enableSpatialAudio, Int32 audioVolumeIndicationInterval, Int32 sceneType) { }

	// RVA: 0xFFFFFFFF7597C710
	public static extern Int32 _rtcLeaveRoom(String roomId) { }

	// RVA: 0xFFFFFFFF7597C744
	public static extern Int32 _rtcUpdateToken(String roomId, String newToken) { }

	// RVA: 0xFFFFFFFF7597C7A0
	public static extern Int32 _rtcEnableMicrophone(String roomId, Boolean enable) { }

	// RVA: 0xFFFFFFFF7597C7DC
	public static extern Int32 _rtcEnableAudioSend(String roomId, Boolean enable) { }

	// RVA: 0xFFFFFFFF7597C818
	public static extern Int32 _rtcEnableSpeakerphone(String roomId, Boolean enable) { }

	// RVA: 0xFFFFFFFF7597C854
	public static extern Int32 _rtcEnableAudioReceive(String roomId, String userId, Boolean enable) { }

	// RVA: 0xFFFFFFFF7597C8B8
	public static extern Int32 _rtcSetRecordingVolume(Int32 volume) { }

	// RVA: 0xFFFFFFFF7597C8BC
	public static extern Int32 _rtcSetPlaybackVolume(Int32 volume) { }

	// RVA: 0xFFFFFFFF7597C8C0
	public static extern Int32 _rtcSetRemoteAudioPlaybackVolume(String roomId, String userId, Int32 volume) { }

	// RVA: 0xFFFFFFFF7597C924
	public static extern Void _rtcSetAudioScenario(Int32 audioScenarioType) { }

	// RVA: 0xFFFFFFFF7597C928
	public static extern Void _rtcSetAudioProfile(Int32 audioProfile) { }

	// RVA: 0xFFFFFFFF7597C92C
	public static extern Int32 _rtcUpdateReceiveRange(String roomId, Int32 min, Int32 max) { }

	// RVA: 0xFFFFFFFF7597C978
	public static extern Int32 _rtcUpdatePosition(String roomId, Int32 x, Int32 y, Int32 z) { }

	// RVA: 0xFFFFFFFF7597C9CC
	public static extern Int32 _rtcUpdateOrientation(String roomId, Single x_axis_0, Single x_axis_1, Single x_axis_2, Single y_axis_0, Single y_axis_1, Single y_axis_2, Single z_axis_0, Single z_axis_1, Single z_axis_2) { }

	// RVA: 0xFFFFFFFF7597CA70
	public static extern Void _rtcSetVoiceChangerType(Int32 voiceChangerType) { }

	// RVA: 0xFFFFFFFF7597CA74
	public static extern Void _rtcSetVoiceReverbType(Int32 voiceReverbType) { }

	// RVA: 0xFFFFFFFF7597CA78
	public static extern Void _rtcEnableRequestAudioFocus(Boolean enable) { }

	// RVA: 0xFFFFFFFF7597CA7C
	public static extern Void _destroyEngine() { }

	// RVA: 0xFFFFFFFF7597CA80
	public Void .ctor() { }

}

// Namespace: 
public class GameSocketLib
{
	// Methods

	// RVA: 0xFFFFFFFF7597CAC4
	public static extern String GetRealIPAddress(String ipaddress) { }

	// RVA: 0xFFFFFFFF7597CB10
	public static extern Boolean IsIPV6Enviroment(String ipaddress) { }

	// RVA: 0xFFFFFFFF7597CB48
	public Void .ctor() { }

}

// Namespace: 
public class GameStartLib
{
	// Methods

	// RVA: 0xFFFFFFFF7597CB50
	public static extern String MLSDK_IOS_AppInfo_GetChannel() { }

	// RVA: 0xFFFFFFFF7597CB84
	public Void .ctor() { }

}

// Namespace: 
public class GumihoLib
{
	// Methods

	// RVA: 0xFFFFFFFF7597CB8C
	public static extern Void _Gumiho_SetSandbox(Boolean isSandbox) { }

	// RVA: 0xFFFFFFFF7597CB90
	public static extern Void _Gumiho_Init(String gameObjectName, String parametersJsonStr) { }

	// RVA: 0xFFFFFFFF7597CBD8
	public static extern Void _Gumiho_Init2(String gameObjectName, String parametersJsonStr) { }

	// RVA: 0xFFFFFFFF7597CC20
	public static extern Void _Gumiho_UpdateGameConfig(String parametersJsonStr) { }

	// RVA: 0xFFFFFFFF7597CC48
	public static extern Void _Gumiho_RegisterRNUnityNotificationListener() { }

	// RVA: 0xFFFFFFFF7597CC4C
	public static extern Void _Gumiho_OpenFaceVerify(String type) { }

	// RVA: 0xFFFFFFFF7597CC74
	public static extern Boolean _Gumiho_AppOpenMarketUrl(String url, String inGameId) { }

	// RVA: 0xFFFFFFFF7597CCD4
	public static extern Void _Gumiho_QueryActivityNotifyByType(String type) { }

	// RVA: 0xFFFFFFFF7597CCFC
	public static extern Void _Gumiho_OnShareEventCallback(String content) { }

	// RVA: 0xFFFFFFFF7597CD24
	public static extern Void _Gumiho_CloseAllPage() { }

	// RVA: 0xFFFFFFFF7597CD28
	public Void .ctor() { }

}

// Namespace: 
public class InAppPurchaseLib
{
	// Methods

	// RVA: 0xFFFFFFFF7598FF6C
	public static extern Boolean AppStore_hasStoreTransaction() { }

	// RVA: 0xFFFFFFFF7598FF88
	public static extern String AppStore_getStoreTransaction() { }

	// RVA: 0xFFFFFFFF7598FFBC
	public Void .ctor() { }

}

// Namespace: 
public class InetAddressLib
{
	// Methods

	// RVA: 0xFFFFFFFF7598FFC4
	public static extern Void _IOS_CheckInetAddressReachableAsync(String hostName, Int32 timeoutInMS, String gameObjectName, String gameObjectMethodName) { }

	// RVA: 0xFFFFFFFF75990038
	public Void .ctor() { }

}

// Namespace: 
public class LoadProcessLib
{
	// Methods

	// RVA: 0xFFFFFFFF759900FC
	public static extern Boolean _IOS_SendMail(String szAddress, String szExtraText) { }

	// RVA: 0xFFFFFFFF7599015C
	public Void .ctor() { }

}

// Namespace: 
public class LoginSocketLib
{
	// Methods

	// RVA: 0xFFFFFFFF759909A0
	public static extern String GetRealIPAddress(String ipaddress) { }

	// RVA: 0xFFFFFFFF759909EC
	public Void .ctor() { }

}

// Namespace: 
public class LuaFileUtilsLib
{
	// Methods

	// RVA: 0xFFFFFFFF75990ADC
	public static extern Boolean _IOS_IsStreamAssetsFileExit(String path) { }

	// RVA: 0xFFFFFFFF75990B14
	public static extern Int32 _IOS_ReadStreamAssetsFile(String path, out IntPtr data) { }

	// RVA: 0xFFFFFFFF75990B50
	public Void .ctor() { }

}

// Namespace: 
public class MCTManagerLib
{
	// Methods

	// RVA: 0xFFFFFFFF75993B9C
	public static extern Void _IOS_RegiesterMCTManager(String gameObjectName, String functionName) { }

	// RVA: 0xFFFFFFFF75993BE4
	public static extern Void _IOS_GetJWD() { }

	// RVA: 0xFFFFFFFF75993BE8
	public Void .ctor() { }

}

// Namespace: 
public class MediaUtilLib
{
	// Methods

	// RVA: 0xFFFFFFFF75994560
	public static extern Void SetFilepathResolution(String filepath) { }

	// RVA: 0xFFFFFFFF75994588
	public static extern Int32 GetVideoResolutionWidth() { }

	// RVA: 0xFFFFFFFF7599458C
	public static extern Int32 GetVideoResolutionHeight() { }

	// RVA: 0xFFFFFFFF75994590
	public Void .ctor() { }

}

// Namespace: 
public class MoontonAccountKitLib
{
	// Methods

	// RVA: 0xFFFFFFFF75994A20
	public static extern Void _IOS_ShowWebAccountKit(String gameObjectName, String baseURL, String paramsData, String lang, String playerID, String playerDevice) { }

	// RVA: 0xFFFFFFFF75994AE8
	public static extern Void _IOS_CloseWebAccountKit(String gameObjectName) { }

	// RVA: 0xFFFFFFFF75994B10
	public Void .ctor() { }

}

// Namespace: 
public class NativeVideoPlayerEntryLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599A984
	public static extern Void _IOS_PlayVideoByLocalPath(String gameObjectName, String localPath, Int32 skipTime) { }

	// RVA: 0xFFFFFFFF7599A9DC
	public static extern Void _IOS_RemoveVideoView() { }

	// RVA: 0xFFFFFFFF7599A9E0
	public Void .ctor() { }

}

// Namespace: 
public class NativeVideoPlayerLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599A9E8
	public static extern Void _IOS_PlayVideoByLocalPath(String gameObjectName, String localPath, Int32 skipTime) { }

	// RVA: 0xFFFFFFFF7599AA40
	public Void .ctor() { }

}

// Namespace: 
public class OpenIAB_iOSLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599ABC4
	public static extern Void AppStore_requestProducts(String[] skus, Int32 skusNumber) { }

	// RVA: 0xFFFFFFFF7599AC88
	public static extern Void AppStore_startPurchase(String sku, String developerPayload, Boolean use_NewReceipt) { }

	// RVA: 0xFFFFFFFF7599ACE0
	public static extern Void AppStore_restorePurchases() { }

	// RVA: 0xFFFFFFFF7599ACE4
	public static extern Boolean Inventory_hasPurchase(String sku) { }

	// RVA: 0xFFFFFFFF7599AD1C
	public static extern Void Inventory_query() { }

	// RVA: 0xFFFFFFFF7599AD20
	public static extern Void Inventory_removePurchase(String sku, String encodeString, Boolean use_NewReceipt) { }

	// RVA: 0xFFFFFFFF7599AD78
	public Void .ctor() { }

}

// Namespace: 
public class PerfsightSDKLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599AD80
	public static extern Void _PerfSight_Init(String parametersJsonStr) { }

	// RVA: 0xFFFFFFFF7599ADA8
	public static extern Void _PerfSight_Start(String scene, String extraJsonStr) { }

	// RVA: 0xFFFFFFFF7599ADF0
	public static extern Void _PerfSight_Stop(String scene) { }

	// RVA: 0xFFFFFFFF7599AE18
	public Void .ctor() { }

}

// Namespace: 
public class PermissionManagerPluginLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599AE60
	public static extern Void _RegisterPermissionHelper(String gameObjectName, String successFuncName, String failedFuncName) { }

	// RVA: 0xFFFFFFFF7599AECC
	public static extern Void _IOS_GetPermission(String permission) { }

	// RVA: 0xFFFFFFFF7599AEF4
	public Void .ctor() { }

}

// Namespace: 
public class PushNotifacationManagerLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599AEFC
	public static extern Void _IOS_InitPushNotifacation(String receiveObject) { }

	// RVA: 0xFFFFFFFF7599AF24
	public static extern Void _IOS_CreatePushNotifacation(String parameters) { }

	// RVA: 0xFFFFFFFF7599AF4C
	public static extern Void _IOS_RemovePushNotifacation(String name) { }

	// RVA: 0xFFFFFFFF7599AF74
	public static extern Void _IOS_RemoveVeryclosedNotifacation(Int32 seconds) { }

	// RVA: 0xFFFFFFFF7599AF78
	public static extern Void _IOS_RemoveAllPushNotifacation() { }

	// RVA: 0xFFFFFFFF7599AF7C
	public static extern String _IOS_GetLaunchNotification() { }

	// RVA: 0xFFFFFFFF7599AFB0
	public static extern String _IOS_GetLaunchExtras() { }

	// RVA: 0xFFFFFFFF7599AFE4
	public static extern String _IOS_GetDeviceToken() { }

	// RVA: 0xFFFFFFFF7599B018
	public static extern Void _IOS_RefreshLocalNotifacationBadgeNumber() { }

	// RVA: 0xFFFFFFFF7599B01C
	public Void .ctor() { }

}

// Namespace: 
public class ResPathMgrLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599B0C0
	public static extern Boolean _IOS_IsStreamAssetsFileExit(String path) { }

	// RVA: 0xFFFFFFFF7599B0F8
	public static extern Int32 _IOS_ReadStreamAssetsFile(String path, out IntPtr data) { }

	// RVA: 0xFFFFFFFF7599B134
	public Void .ctor() { }

}

// Namespace: 
public class ResourcesExtractReporterLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599B13C
	public static extern Int32 _IOS_GetCPUMaxFreq() { }

	// RVA: 0xFFFFFFFF7599B140
	public static extern String _IOS_GetChannel() { }

	// RVA: 0xFFFFFFFF7599B174
	public static extern String _IOS_GetClientVersion() { }

	// RVA: 0xFFFFFFFF7599B1A8
	public static extern String _IOS_GetEngineVersion() { }

	// RVA: 0xFFFFFFFF7599B1DC
	public static extern String _IOS_GetEngineInnerVersion() { }

	// RVA: 0xFFFFFFFF7599B210
	public static extern String _IOS_GetSevenZipVersion() { }

	// RVA: 0xFFFFFFFF7599B244
	public static extern Int32 _IOS_GetPackageSize() { }

	// RVA: 0xFFFFFFFF7599B248
	public static extern Int32 _IOS_GetAppSize() { }

	// RVA: 0xFFFFFFFF7599B24C
	public static extern Int32 _IOS_GetDataSize() { }

	// RVA: 0xFFFFFFFF7599B250
	public static extern Int32 _IOS_GetCacheSize() { }

	// RVA: 0xFFFFFFFF7599B254
	public Void .ctor() { }

}

// Namespace: 
public class SDKAppleIdLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599B74C
	public static extern Void _AppleIdManager_SetUp(String gameObjectName) { }

	// RVA: 0xFFFFFFFF7599B774
	public static extern Void _AppleIdManager_Login() { }

	// RVA: 0xFFFFFFFF7599B778
	public static extern Void _AppleIdManager_Logout() { }

	// RVA: 0xFFFFFFFF7599B77C
	public static extern String _AppleIdManager_GetValue(String key) { }

	// RVA: 0xFFFFFFFF7599B7C8
	public Void .ctor() { }

}

// Namespace: 
public class SDKBarrageLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599B7D0
	public static extern Void _IOS_Barrage_SetDebug(Boolean debug) { }

	// RVA: 0xFFFFFFFF7599B7D4
	public static extern Void _IOS_Barrage_Init(String gameObjectName, String parametersJson) { }

	// RVA: 0xFFFFFFFF7599B81C
	public static extern UInt64 _IOS_Barrage_CreateView(String parametersJson) { }

	// RVA: 0xFFFFFFFF7599B850
	public static extern Void _IOS_Barrage_Add(UInt64 instanceId, String parametersJson) { }

	// RVA: 0xFFFFFFFF7599B888
	public static extern Void _IOS_Barrage_DestroyView(UInt64 instanceId) { }

	// RVA: 0xFFFFFFFF7599B88C
	public Void .ctor() { }

}

// Namespace: 
public class SDKCommonLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599B894
	public static extern Boolean _IOS_IsStreamAssetsFileExit(String path) { }

	// RVA: 0xFFFFFFFF7599B8CC
	public static extern Int32 _IOS_ReadStreamAssetsFile(String path, out IntPtr ptr) { }

	// RVA: 0xFFFFFFFF7599B908
	public static extern Int64 _IOS_GetFreeDiskSpace() { }

	// RVA: 0xFFFFFFFF7599B90C
	public static extern String _IOS_GetCountry() { }

	// RVA: 0xFFFFFFFF7599B940
	public static extern String _IOS_GetSavedUDID() { }

	// RVA: 0xFFFFFFFF7599B974
	public static extern String _IOS_LazyGetAll() { }

	// RVA: 0xFFFFFFFF7599B9A8
	public static extern String _IOS_GetASIdentifierManager() { }

	// RVA: 0xFFFFFFFF7599B9DC
	public static extern Boolean _IOS_IsIOSBuildAvailable(Int32 version) { }

	// RVA: 0xFFFFFFFF7599B9F8
	public static extern String _IOS_GetScreenBrightness() { }

	// RVA: 0xFFFFFFFF7599BA2C
	public static extern String _IOS_GetIOSDeviceModel() { }

	// RVA: 0xFFFFFFFF7599BA60
	public static extern Void _IOS_CopyTextToClipboard(String copyText) { }

	// RVA: 0xFFFFFFFF7599BA88
	public static extern Int64 _IOS_GetTotalDiskSpace() { }

	// RVA: 0xFFFFFFFF7599BA8C
	public static extern Int64 _IOS_GetAvailableDiskSpace() { }

	// RVA: 0xFFFFFFFF7599BA90
	public static extern Boolean _IOS_IsInstallApp(String app) { }

	// RVA: 0xFFFFFFFF7599BAC8
	public static extern Int64 _IOS_GetPhysicalMemory() { }

	// RVA: 0xFFFFFFFF7599BACC
	public static extern Int64 _IOS_GetTaskUsedMemeory() { }

	// RVA: 0xFFFFFFFF7599BAD0
	public static extern Int64 _IOS_GetAvailableMemory() { }

	// RVA: 0xFFFFFFFF7599BAD4
	public static extern Void _IOS_ChangeSoundVolume(Single tVolume) { }

	// RVA: 0xFFFFFFFF7599BAD8
	public static extern Single _IOS_GetSoundVolume() { }

	// RVA: 0xFFFFFFFF7599BADC
	public static extern Single _IOS_GetBatteryLevel() { }

	// RVA: 0xFFFFFFFF7599BAE0
	public static extern String _IOS_GetBatteryState() { }

	// RVA: 0xFFFFFFFF7599BB14
	public static extern Boolean _IOS_GetBatteryChargingState() { }

	// RVA: 0xFFFFFFFF7599BB30
	public static extern Boolean _IOS_IsJailbroken() { }

	// RVA: 0xFFFFFFFF7599BB4C
	public static extern Boolean _IOS_IsGPUSupports(Int32 iGPUFamily) { }

	// RVA: 0xFFFFFFFF7599BB68
	public static extern String _IOS_GetIOSVersion() { }

	// RVA: 0xFFFFFFFF7599BB9C
	public static extern String _IOS_GetBuildVersion() { }

	// RVA: 0xFFFFFFFF7599BBD0
	public static extern Int32 _IOS_GetIDFAAuthStatus() { }

	// RVA: 0xFFFFFFFF7599BBD4
	public static extern String _IOS_GetIDFA() { }

	// RVA: 0xFFFFFFFF7599BC08
	public static extern String _IOS_GetUnityVendorIdentifier() { }

	// RVA: 0xFFFFFFFF7599BC3C
	public static extern String _IOS_GetCurrentLanguage() { }

	// RVA: 0xFFFFFFFF7599BC70
	public static extern String _IOS_GetDeviceName() { }

	// RVA: 0xFFFFFFFF7599BCA4
	public static extern String _IOS_GetApplicationState() { }

	// RVA: 0xFFFFFFFF7599BCD8
	public static extern Int64 _IOS_GetResidentMemory() { }

	// RVA: 0xFFFFFFFF7599BCDC
	public static extern Int64 _IOS_GetActiveMemory() { }

	// RVA: 0xFFFFFFFF7599BCE0
	public static extern Int64 _IOS_GetWireMemory() { }

	// RVA: 0xFFFFFFFF7599BCE4
	public static extern Boolean _IOS_IsIPhone() { }

	// RVA: 0xFFFFFFFF7599BD00
	public static extern Boolean _IOS_IsIPad() { }

	// RVA: 0xFFFFFFFF7599BD1C
	public static extern Boolean _IOS_IsRetina() { }

	// RVA: 0xFFFFFFFF7599BD38
	public static extern Boolean _IOS_IsAdvertisingTrackingEnabled() { }

	// RVA: 0xFFFFFFFF7599BD54
	public static extern Void _IOS_HttpVerify(String url, String hostName, String callbackGameObjectName, String callbackMethodName) { }

	// RVA: 0xFFFFFFFF7599BDDC
	public static extern String _IOS_UnitySystemName() { }

	// RVA: 0xFFFFFFFF7599BE10
	public static extern String _IOS_UnitySystemVersion() { }

	// RVA: 0xFFFFFFFF7599BE44
	public static extern String _IOS_GetBundleInfo() { }

	// RVA: 0xFFFFFFFF7599BE78
	public static extern String _IOS_ExceptionHandler_GetAppInfo() { }

	// RVA: 0xFFFFFFFF7599BEAC
	public static extern String _IOS_GetProvisionInfo() { }

	// RVA: 0xFFFFFFFF7599BEE0
	public static extern Boolean _IOS_GetNotificationEnabled() { }

	// RVA: 0xFFFFFFFF7599BEFC
	public static extern Void _IOS_GoToApplicationSettings() { }

	// RVA: 0xFFFFFFFF7599BF00
	public static extern Boolean _IOS_AddCalendar(UInt64 intPtr) { }

	// RVA: 0xFFFFFFFF7599BF1C
	public static extern Boolean _IOS_IsCalendarExist(UInt64 intPtr) { }

	// RVA: 0xFFFFFFFF7599BF38
	public static extern Boolean _IOS_DeleteCalendar(UInt64 intPtr) { }

	// RVA: 0xFFFFFFFF7599BF54
	public static extern Void _IOS_ExcludeFromBackup(String path, Boolean exclude) { }

	// RVA: 0xFFFFFFFF7599BF84
	public static extern Int32 _IOS_GetStatusBarOrientation() { }

	// RVA: 0xFFFFFFFF7599BF88
	public static extern Void _IOS_ChangeDeviceLandscape() { }

	// RVA: 0xFFFFFFFF7599BF8C
	public static extern Void _IOS_GetPackageTotalSize(String callbackGameObjectName) { }

	// RVA: 0xFFFFFFFF7599BFB4
	public static extern Void _IOS_RegisterNetworkStateChangedCallback(String callbackGameObjectName, String callbackMethodName) { }

	// RVA: 0xFFFFFFFF7599BFFC
	public static extern Int64 _IOS_GetGFXMemory() { }

	// RVA: 0xFFFFFFFF7599C000
	public static extern UInt64 _IOS_CreateNSDictionary() { }

	// RVA: 0xFFFFFFFF7599C004
	public static extern UInt64 _IOS_PutValueNSDictionary(UInt64 intPtr, String key, String value) { }

	// RVA: 0xFFFFFFFF7599C06C
	public static extern String _IOS_GetSignalStrength() { }

	// RVA: 0xFFFFFFFF7599C0A0
	public static extern String _IOS_GetNetworkType() { }

	// RVA: 0xFFFFFFFF7599C0D4
	public static extern Boolean _IOS_IsWifiConnected() { }

	// RVA: 0xFFFFFFFF7599C0F0
	public static extern Boolean _IOS_EnableMonoMemoryOptimize(Int32 size) { }

	// RVA: 0xFFFFFFFF7599C10C
	public static extern Boolean _IOS_EnableMonoAndLuaMemoryOptimize(Int32 size, Boolean enableMono, Boolean enableLua, EnableMmap cb) { }

	// RVA: 0xFFFFFFFF7599C15C
	public static extern Int64 _IOS_MonoMemoryUsage() { }

	// RVA: 0xFFFFFFFF7599C160
	public Void .ctor() { }

}

// Namespace: 
public sealed class EnableMmap
{
	// Methods

	// RVA: 0xFFFFFFFF7599C168
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7599C17C
	public virtual Int32 Invoke() { }

	// RVA: 0xFFFFFFFF7599C37C
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7599C3D4
	public virtual Int32 EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class SDKDNSLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599C400
	public static extern Void _DNS_Init(String parametersJsonStr) { }

	// RVA: 0xFFFFFFFF7599C428
	public static extern Void _DNS_SetPreResolveHosts(String hostNames, Int32 ipType) { }

	// RVA: 0xFFFFFFFF7599C458
	public static extern String _DNS_GetIpByHostAsync(String host, Int32 ipType) { }

	// RVA: 0xFFFFFFFF7599C4AC
	public static extern String _DNS_GetIpsByHostAsync(String host, Int32 ipType) { }

	// RVA: 0xFFFFFFFF7599C500
	public Void .ctor() { }

}

// Namespace: 
public class SDKElvaLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599C508
	public static extern Void MLSDK_IOS_Elva_Init(String loginCountry, String domain, String appId, String lanId, String gameObjectName) { }

	// RVA: 0xFFFFFFFF7599C5B4
	public static extern Void MLSDK_IOS_Elva_Init_With_Json(String paramsJson) { }

	// RVA: 0xFFFFFFFF7599C5DC
	public static extern Void MLSDK_IOS_Elva_Show(String paramsJson) { }

	// RVA: 0xFFFFFFFF7599C604
	public static extern String MLSDK_IOS_Elva_GetSDKVersion() { }

	// RVA: 0xFFFFFFFF7599C638
	public static extern Void MLSDK_IOS_Elva_Uninstall() { }

	// RVA: 0xFFFFFFFF7599C63C
	public Void .ctor() { }

}

// Namespace: 
public class SDKExceptionHandlerLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599C644
	public static extern Void _IOS_ExceptionHandler_SetDebug(Boolean debug) { }

	// RVA: 0xFFFFFFFF7599C648
	public static extern Void _IOS_ExceptionHandler_SetCatchException(Boolean value) { }

	// RVA: 0xFFFFFFFF7599C64C
	public static extern Void _IOS_ExceptionHandler_SetCatchSignal(Boolean value) { }

	// RVA: 0xFFFFFFFF7599C650
	public static extern Void _IOS_ExceptionHandler_RegisterCallback(String gameObjectName) { }

	// RVA: 0xFFFFFFFF7599C678
	public static extern Void _IOS_ExceptionHandler_SetContinue(Boolean isContinue) { }

	// RVA: 0xFFFFFFFF7599C67C
	public static extern Void _IOS_ExceptionHandler_SetShowAlert(Boolean showAlert) { }

	// RVA: 0xFFFFFFFF7599C680
	public static extern Void _IOS_ExceptionHandler_SetShowQuit(Boolean showQuit) { }

	// RVA: 0xFFFFFFFF7599C684
	public static extern Void _IOS_ExceptionHandler_SetShowContinue(Boolean showContinue) { }

	// RVA: 0xFFFFFFFF7599C688
	public static extern Void _IOS_ExceptionHandler_SetContinueTimeout(Int32 continueTimeout) { }

	// RVA: 0xFFFFFFFF7599C68C
	public static extern Void _IOS_ExceptionHandler_SetCleanupAfterContinue(Boolean value) { }

	// RVA: 0xFFFFFFFF7599C690
	public static extern Void _IOS_ExceptionHandler_SetRaiseException(Boolean value) { }

	// RVA: 0xFFFFFFFF7599C694
	public static extern Void _IOS_ExceptionHandler_Install() { }

	// RVA: 0xFFFFFFFF7599C698
	public static extern Void _IOS_ExceptionHandler_Uninstall() { }

	// RVA: 0xFFFFFFFF7599C69C
	public static extern Void _IOS_ExceptionHandler_InstallUncaughtExceptionAndSignalHandlerBeforeTerminate() { }

	// RVA: 0xFFFFFFFF7599C6A0
	public static extern String _IOS_ExceptionHandler_GetUncaughtException(Boolean isDelete) { }

	// RVA: 0xFFFFFFFF7599C6D4
	public static extern String _IOS_ExceptionHandler_GetCLSReport(Boolean isDelete) { }

	// RVA: 0xFFFFFFFF7599C708
	public static extern String _IOS_ExceptionHandler_GetCurrentDate() { }

	// RVA: 0xFFFFFFFF7599C73C
	public static extern String _IOS_ExceptionHandler_GetAppInfo() { }

	// RVA: 0xFFFFFFFF7599C770
	public static extern String _IOS_ExceptionHandler_GetDeviceInfo() { }

	// RVA: 0xFFFFFFFF7599C7A4
	public static extern String _IOS_ExceptionHandler_GetDeviceOSInfo() { }

	// RVA: 0xFFFFFFFF7599C7D8
	public static extern String _IOS_ExceptionHandler_GetOSInfo() { }

	// RVA: 0xFFFFFFFF7599C80C
	public static extern String _IOS_ExceptionHandler_GetDeviceModel() { }

	// RVA: 0xFFFFFFFF7599C840
	public static extern String _IOS_ExceptionHandler_GetDeviceName() { }

	// RVA: 0xFFFFFFFF7599C874
	public static extern String _IOS_ExceptionHandler_GetMemoryInfo() { }

	// RVA: 0xFFFFFFFF7599C8A8
	public static extern Single _IOS_ExceptionHandler_GetCPUUsage() { }

	// RVA: 0xFFFFFFFF7599C8AC
	public static extern String _IOS_ExceptionHandler_ApplicationState() { }

	// RVA: 0xFFFFFFFF7599C8E0
	public static extern Boolean _IOS_ExceptionHandler_RunningInForeground() { }

	// RVA: 0xFFFFFFFF7599C8FC
	public static extern Boolean _IOS_ExceptionHandler_RunningInBackground() { }

	// RVA: 0xFFFFFFFF7599C918
	public static extern Boolean _IOS_ExceptionHandler_IsDebugged() { }

	// RVA: 0xFFFFFFFF7599C934
	public static extern Void _IOS_ExceptionHandler_ThrowException() { }

	// RVA: 0xFFFFFFFF7599C938
	public Void .ctor() { }

}

// Namespace: 
public class SDKFabricLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599C940
	public static extern Void _IOS_Fabric_setUserIdentifier(String identifier) { }

	// RVA: 0xFFFFFFFF7599C968
	public static extern Void _IOS_Fabric_setUserName(String name) { }

	// RVA: 0xFFFFFFFF7599C990
	public static extern Void _IOS_Fabric_log(String log) { }

	// RVA: 0xFFFFFFFF7599C9B8
	public static extern String _IOS_Fabric_getUncaughtException(Boolean isDelete) { }

	// RVA: 0xFFFFFFFF7599C9EC
	public static extern String _IOS_Fabric_getCLSReport(Boolean isDelete) { }

	// RVA: 0xFFFFFFFF7599CA20
	public Void .ctor() { }

}

// Namespace: 
public class SDKFacebookLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599CA28
	public static extern Void _Facebook_Setup(String permission) { }

	// RVA: 0xFFFFFFFF7599CA50
	public static extern Void _Facebook_Login(String receiveGameObjectName) { }

	// RVA: 0xFFFFFFFF7599CA78
	public static extern Void _Facebook_Logout() { }

	// RVA: 0xFFFFFFFF7599CA7C
	public static extern String _Facebook_GetValue(String key) { }

	// RVA: 0xFFFFFFFF7599CAC8
	public static extern Void _Facebook_Invite(String paramsString) { }

	// RVA: 0xFFFFFFFF7599CAF0
	public static extern Void _Facebook_AskHelp(String paramsString) { }

	// RVA: 0xFFFFFFFF7599CB18
	public static extern Void _Facebook_ShareContent(String paramsString) { }

	// RVA: 0xFFFFFFFF7599CB40
	public static extern Void _Facebook_LogEvent(String paramsString) { }

	// RVA: 0xFFFFFFFF7599CB68
	public static extern Void _Facebook_SendGraphRequest(String httpMethod, String action, String paramsString) { }

	// RVA: 0xFFFFFFFF7599CBD4
	public static extern Void _Facebook_SendGameRequest(String paramsString) { }

	// RVA: 0xFFFFFFFF7599CBFC
	public static extern Boolean _IOS_IsIPhone() { }

	// RVA: 0xFFFFFFFF7599CC18
	public static extern Boolean _IOS_IsIPad() { }

	// RVA: 0xFFFFFFFF7599CC34
	public Void .ctor() { }

}

// Namespace: 
public class SDKGameCenterLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599CCCC
	public static extern Void _Gamecenter_Setup(String gameObjectName) { }

	// RVA: 0xFFFFFFFF7599CCF4
	public Void .ctor() { }

}

// Namespace: 
public class SDKImageHelperLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599CCFC
	public static extern Void _SetImageHelper(String gameObjectName) { }

	// RVA: 0xFFFFFFFF7599CD24
	public static extern Void _OpenCamera(String dir, Boolean bCropHD, Int32 iCropSize, Boolean bCouldEdit) { }

	// RVA: 0xFFFFFFFF7599CD6C
	public static extern Void _OpenAlbum(String dir, Boolean bCropHD, Int32 iCropSize, Boolean bCouldEdit, Boolean needAuthorization) { }

	// RVA: 0xFFFFFFFF7599CDC4
	public static extern Void _SaveImgToPhotosAlbum(String imgPath, String authTitle, String authMessage, String cancelText, String okText) { }

	// RVA: 0xFFFFFFFF7599CE70
	public static extern String _EncodeStringToQRImage(String data, Int32 imageSize) { }

	// RVA: 0xFFFFFFFF7599CEC4
	public static extern String _GetImageSizeWithFilePath(String imgPath) { }

	// RVA: 0xFFFFFFFF7599CF10
	public static extern Void TraceRt(String dest, Int32 ttl, String gameObjectName) { }

	// RVA: 0xFFFFFFFF7599CF68
	public static extern Void TraceStop(Boolean b) { }

	// RVA: 0xFFFFFFFF7599CF6C
	public static extern Void _IOS_BitmapFrameImage(String path, String filename, Double mtime) { }

	// RVA: 0xFFFFFFFF7599CFC4
	public static extern Void SaveVideoToCustomAssetCollection(String videoName, String collectionName, String gameObjectName) { }

	// RVA: 0xFFFFFFFF7599D030
	public Void .ctor() { }

}

// Namespace: 
public class SDKLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599D038
	public static extern Void _OpenOfficialCommunity_ios() { }

	// RVA: 0xFFFFFFFF7599D03C
	public static extern Boolean _IOS_OpenURL(String url) { }

	// RVA: 0xFFFFFFFF7599D074
	public static extern Void _IOS_RequestReview() { }

	// RVA: 0xFFFFFFFF7599D078
	public static extern Void _IOS_SetIsDownloadingRes(Boolean isDownloading, String paramsJson) { }

	// RVA: 0xFFFFFFFF7599D0B0
	public static extern Void _IOS_SetBackgroundDownloadSound(String filePath) { }

	// RVA: 0xFFFFFFFF7599D0D8
	public static extern Void _IOS_SetResDownloadCompletedPushInfo() { }

	// RVA: 0xFFFFFFFF7599D0DC
	public static extern Void _IOS_DeleteDeviceIdAndSavedUDID() { }

	// RVA: 0xFFFFFFFF7599D0E0
	public Void .ctor() { }

}

// Namespace: 
public class SDKPingLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599D0F0
	public static extern UInt64 _Ping_Start(String gameObjectName, String parametersJson) { }

	// RVA: 0xFFFFFFFF7599D14C
	public static extern Void _Ping_Stop(UInt64 pingPtr) { }

	// RVA: 0xFFFFFFFF7599D150
	public Void .ctor() { }

}

// Namespace: 
public class SDKQiniuLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599D158
	public static extern Void _Qiniu_Init(String paramsJson) { }

	// RVA: 0xFFFFFFFF7599D180
	public static extern Void _Qiniu_RegisterCallback(String gameObjectName, String paramsJson) { }

	// RVA: 0xFFFFFFFF7599D1C8
	public static extern Void _Qiniu_Upload(String paramsJson) { }

	// RVA: 0xFFFFFFFF7599D1F0
	public static extern Void _Qiniu_SetCancelled(Boolean cancelled) { }

	// RVA: 0xFFFFFFFF7599D1F4
	public Void .ctor() { }

}

// Namespace: 
public class SDKScreenshotListenerLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599D1FC
	public static extern Boolean _Screenshot_SetDebug(Boolean debug) { }

	// RVA: 0xFFFFFFFF7599D218
	public static extern Void _Screenshot_RegisterCallback(String gameObjectName, String paramsJson) { }

	// RVA: 0xFFFFFFFF7599D260
	public static extern Void _Screenshot_StartListen() { }

	// RVA: 0xFFFFFFFF7599D264
	public static extern Void _Screenshot_StopListen() { }

	// RVA: 0xFFFFFFFF7599D268
	public Void .ctor() { }

}

// Namespace: 
public class SDKTikTokLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599D270
	public static extern Void _IOS_TikTokInit(String gameObjectName) { }

	// RVA: 0xFFFFFFFF7599D298
	public static extern Void _IOS_ShareToTikTok(String paramsString) { }

	// RVA: 0xFFFFFFFF7599D2C0
	public static extern Boolean _IOS_IsTikTokInstall() { }

	// RVA: 0xFFFFFFFF7599D2DC
	public static extern Boolean _IOS_TikTokLogin() { }

	// RVA: 0xFFFFFFFF7599D2F8
	public static extern String _IOS_GetCodeVerifier() { }

	// RVA: 0xFFFFFFFF7599D32C
	public Void .ctor() { }

}

// Namespace: 
public class SDKWallpaperLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599D334
	public static extern Void _Wallpaper_RegisterCallback(String gameObjectName, String paramsJson) { }

	// RVA: 0xFFFFFFFF7599D37C
	public static extern Boolean _Wallpaper_SetDebug(Boolean debug) { }

	// RVA: 0xFFFFFFFF7599D398
	public static extern Boolean _Wallpaper_IsSupportLivePhoto() { }

	// RVA: 0xFFFFFFFF7599D3B4
	public static extern Void _Wallpaper_CreateLivePhoto(String paramsJson) { }

	// RVA: 0xFFFFFFFF7599D3DC
	public Void .ctor() { }

}

// Namespace: 
public class SdkInitLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599D49C
	public static extern Void _ApplicationListerner_Setup() { }

	// RVA: 0xFFFFFFFF7599D4A0
	public static extern Void _IOS_UnityBridgeRegisterCallback(MyUnitySendMessageFunc func) { }

	// RVA: 0xFFFFFFFF7599D4B4
	public static extern Void _Adjust_Init() { }

	// RVA: 0xFFFFFFFF7599D4B8
	public static extern Void _Adjust_AppWillOpenUrl() { }

	// RVA: 0xFFFFFFFF7599D4BC
	public static extern Void _RegiesterBatteryReceiver() { }

	// RVA: 0xFFFFFFFF7599D4C0
	public static extern Void _RegisterIOSOrientation(String gameObjectName) { }

	// RVA: 0xFFFFFFFF7599D4E8
	public Void .ctor() { }

}

// Namespace: 
public sealed class MyUnitySendMessageFunc
{
	// Methods

	// RVA: 0xFFFFFFFF7599D4F0
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7599D504
	public virtual Void Invoke(IntPtr gameObjectNamePtr, IntPtr methodNamePtr, IntPtr msgPtr) { }

	// RVA: 0xFFFFFFFF7599D784
	public virtual IAsyncResult BeginInvoke(IntPtr gameObjectNamePtr, IntPtr methodNamePtr, IntPtr msgPtr, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7599D838
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class ShareManagerLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599E1B8
	public static extern Boolean _IOS_SendTo(UInt64 intPtr) { }

	// RVA: 0xFFFFFFFF7599E1D4
	public static extern Void _IOS_SendToLine(String url, String imgUrl, Boolean isImg) { }

	// RVA: 0xFFFFFFFF7599E22C
	public static extern Void _IOS_SendToWhatsApp(String url, String imgUrl, Boolean isImg) { }

	// RVA: 0xFFFFFFFF7599E284
	public static extern Void _IOS_SendToInstagram(String url, String imgUrl, Boolean isImg) { }

	// RVA: 0xFFFFFFFF7599E2DC
	public static extern Void _IOS_SendToGamely(String url, String optionPara) { }

	// RVA: 0xFFFFFFFF7599E324
	public static extern Void _IOS_SendTextToTelegram(String url) { }

	// RVA: 0xFFFFFFFF7599E34C
	public static extern Void _IOS_SendTextToViber(String url) { }

	// RVA: 0xFFFFFFFF7599E374
	public Void .ctor() { }

}

// Namespace: 
public class SocialVNGLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599E384
	public static extern Void _IOS_VNGSetup(String mGameObjectName) { }

	// RVA: 0xFFFFFFFF7599E3AC
	public static extern Void _IOS_VNGLogin(Boolean bAutoLogin) { }

	// RVA: 0xFFFFFFFF7599E3B0
	public static extern Void _IOS_VNGLogout() { }

	// RVA: 0xFFFFFFFF7599E3B4
	public static extern String _IOS_VNGGetValue(String kKey) { }

	// RVA: 0xFFFFFFFF7599E400
	public static extern Boolean _IOS_VNGIsDeleteAccountEnable() { }

	// RVA: 0xFFFFFFFF7599E41C
	public static extern Void _IOS_VNGDeleteAccount() { }

	// RVA: 0xFFFFFFFF7599E420
	public Void .ctor() { }

}

// Namespace: 
public class SocketBaseLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599E428
	public static extern String GetRealIPAddress(String ipaddress) { }

	// RVA: 0xFFFFFFFF7599E474
	public static extern Boolean IsIPV6Enviroment(String ipaddress) { }

	// RVA: 0xFFFFFFFF7599E4AC
	public Void .ctor() { }

}

// Namespace: 
public class UniWebViewHelperLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599E764
	public static Int32 _IOS_GetScreenHeight() { }

	// RVA: 0xFFFFFFFF7599E76C
	public static Int32 _IOS_GetScreenWidth() { }

	// RVA: 0xFFFFFFFF7599E774
	public Void .ctor() { }

}

// Namespace: 
public class UniWebViewInterfaceLib
{
	// Fields
	public const String DllLib = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF7599E77C
	public static extern Void uv_connectMessageSender(UnitySendMessageDelegate sendMessageDelegate) { }

	// RVA: 0xFFFFFFFF7599E790
	public static extern Void uv_setLogLevel(Int32 level) { }

	// RVA: 0xFFFFFFFF7599E794
	public static extern Void uv_init(String name, Int32 x, Int32 y, Int32 width, Int32 height) { }

	// RVA: 0xFFFFFFFF7599E7EC
	public static extern Void uv_destroy(String name) { }

	// RVA: 0xFFFFFFFF7599E814
	public static extern Void uv_load(String name, String url, Boolean skipEncoding, String readAccessURL) { }

	// RVA: 0xFFFFFFFF7599E888
	public static extern Void uv_loadHTMLString(String name, String html, String baseUrl, Boolean skipEncoding) { }

	// RVA: 0xFFFFFFFF7599E8FC
	public static extern Void uv_reload(String name) { }

	// RVA: 0xFFFFFFFF7599E924
	public static extern Void uv_stop(String name) { }

	// RVA: 0xFFFFFFFF7599E94C
	public static extern String uv_getUrl(String name) { }

	// RVA: 0xFFFFFFFF7599E998
	public static extern Void uv_setFrame(String name, Int32 x, Int32 y, Int32 width, Int32 height) { }

	// RVA: 0xFFFFFFFF7599E9F0
	public static extern Void uv_setPosition(String name, Int32 x, Int32 y) { }

	// RVA: 0xFFFFFFFF7599EA30
	public static extern Void uv_setSize(String name, Int32 width, Int32 height) { }

	// RVA: 0xFFFFFFFF7599EA70
	public static extern Boolean uv_show(String name, Boolean fade, Int32 edge, Single duration, String identifier) { }

	// RVA: 0xFFFFFFFF7599EAF0
	public static extern Boolean uv_hide(String name, Boolean fade, Int32 edge, Single duration, String identifier) { }

	// RVA: 0xFFFFFFFF7599EB70
	public static extern Boolean uv_animateTo(String name, Int32 x, Int32 y, Int32 width, Int32 height, Single duration, Single delay, String identifier) { }

	// RVA: 0xFFFFFFFF7599EC10
	public static extern Void uv_addJavaScript(String name, String jsString, String identifier) { }

	// RVA: 0xFFFFFFFF7599EC7C
	public static extern Void uv_evaluateJavaScript(String name, String jsString, String identifier) { }

	// RVA: 0xFFFFFFFF7599ECE8
	public static extern Void uv_addUrlScheme(String name, String scheme) { }

	// RVA: 0xFFFFFFFF7599ED30
	public static extern Void uv_removeUrlScheme(String name, String scheme) { }

	// RVA: 0xFFFFFFFF7599ED78
	public static extern Void uv_addSslExceptionDomain(String name, String domain) { }

	// RVA: 0xFFFFFFFF7599EDC0
	public static extern Void uv_removeSslExceptionDomain(String name, String domain) { }

	// RVA: 0xFFFFFFFF7599EE08
	public static extern Void uv_setHeaderField(String name, String key, String value) { }

	// RVA: 0xFFFFFFFF7599EE74
	public static extern Void uv_setUserAgent(String name, String userAgent) { }

	// RVA: 0xFFFFFFFF7599EEBC
	public static extern String uv_getUserAgent(String name) { }

	// RVA: 0xFFFFFFFF7599EF08
	public static extern Void uv_setAllowAutoPlay(Boolean flag) { }

	// RVA: 0xFFFFFFFF7599EF0C
	public static extern Void uv_setAllowInlinePlay(Boolean flag) { }

	// RVA: 0xFFFFFFFF7599EF10
	public static extern Void uv_setAllowJavaScriptOpenWindow(Boolean flag) { }

	// RVA: 0xFFFFFFFF7599EF14
	public static extern Void uv_setJavaScriptEnabled(Boolean flag) { }

	// RVA: 0xFFFFFFFF7599EF18
	public static extern Void uv_cleanCache(String name) { }

	// RVA: 0xFFFFFFFF7599EF40
	public static extern Void uv_clearCookies() { }

	// RVA: 0xFFFFFFFF7599EF44
	public static extern Void uv_setCookie(String url, String cookie, Boolean skipEncoding) { }

	// RVA: 0xFFFFFFFF7599EF9C
	public static extern String uv_getCookie(String url, String key, Boolean skipEncoding) { }

	// RVA: 0xFFFFFFFF7599F010
	public static extern Void uv_clearHttpAuthUsernamePasswordHost(String host, String realm) { }

	// RVA: 0xFFFFFFFF7599F058
	public static extern Void uv_setBackgroundColor(String name, Single r, Single g, Single b, Single a) { }

	// RVA: 0xFFFFFFFF7599F0B0
	public static extern Void uv_setWebViewAlpha(String name, Single alpha) { }

	// RVA: 0xFFFFFFFF7599F0E8
	public static extern Single uv_getWebViewAlpha(String name) { }

	// RVA: 0xFFFFFFFF7599F124
	public static extern Void uv_setShowSpinnerWhileLoading(String name, Boolean show) { }

	// RVA: 0xFFFFFFFF7599F154
	public static extern Void uv_setSpinnerText(String name, String text) { }

	// RVA: 0xFFFFFFFF7599F19C
	public static extern Boolean uv_canGoBack(String name) { }

	// RVA: 0xFFFFFFFF7599F1D4
	public static extern Boolean uv_canGoForward(String name) { }

	// RVA: 0xFFFFFFFF7599F20C
	public static extern Void uv_goBack(String name) { }

	// RVA: 0xFFFFFFFF7599F234
	public static extern Void uv_goForward(String name) { }

	// RVA: 0xFFFFFFFF7599F25C
	public static extern Void uv_setOpenLinksInExternalBrowser(String name, Boolean flag) { }

	// RVA: 0xFFFFFFFF7599F28C
	public static extern Void uv_setHorizontalScrollBarEnabled(String name, Boolean enabled) { }

	// RVA: 0xFFFFFFFF7599F2BC
	public static extern Void uv_setVerticalScrollBarEnabled(String name, Boolean enabled) { }

	// RVA: 0xFFFFFFFF7599F2EC
	public static extern Void uv_setBouncesEnabled(String name, Boolean enabled) { }

	// RVA: 0xFFFFFFFF7599F31C
	public static extern Void uv_setZoomEnabled(String name, Boolean enabled) { }

	// RVA: 0xFFFFFFFF7599F34C
	public static extern Void uv_setShowToolbar(String name, Boolean show, Boolean animated, Boolean onTop, Boolean adjustInset) { }

	// RVA: 0xFFFFFFFF7599F3A4
	public static extern Void uv_setToolbarDoneButtonText(String name, String text) { }

	// RVA: 0xFFFFFFFF7599F3EC
	public static extern Void uv_setWindowUserResizeEnabled(String name, Boolean enabled) { }

	// RVA: 0xFFFFFFFF7599F41C
	public static extern Void uv_setWebContentsDebuggingEnabled(Boolean enabled) { }

	// RVA: 0xFFFFFFFF7599F420
	public static extern Void uv_setAllowFileAccessFromFileURLs(String name, Boolean flag) { }

	// RVA: 0xFFFFFFFF7599F450
	public static extern Void uv_setAllowHTTPAuthPopUpWindow(String name, Boolean flag) { }

	// RVA: 0xFFFFFFFF7599F480
	public static extern Void uv_print(String name) { }

	// RVA: 0xFFFFFFFF7599F4A8
	public static extern Void uv_setCalloutEnabled(String name, Boolean flag) { }

	// RVA: 0xFFFFFFFF7599F4D8
	public static extern Void uv_setDragInteractionEnabled(String name, Boolean flag) { }

	// RVA: 0xFFFFFFFF7599F508
	public static extern Boolean uv_addJavascriptInterface(String name) { }

	// RVA: 0xFFFFFFFF7599F540
	public static extern Void uv_removeJavascriptInterface(String name) { }

	// RVA: 0xFFFFFFFF7599F568
	public static extern Void uv_changePortrait(String name, Int32 statusBarOrientation) { }

	// RVA: 0xFFFFFFFF7599F598
	public static extern Void uv_changeLandscape(String name, Int32 statusBarOrientation) { }

	// RVA: 0xFFFFFFFF7599F5C8
	public static extern Void uv_refreshDeviceInfo(String name, String deviceInfo) { }

	// RVA: 0xFFFFFFFF7599F610
	public static extern String _IOS_GetDeviceName() { }

	// RVA: 0xFFFFFFFF7599F644
	public static extern Void uv_setJumpAble(String name, Boolean enabled) { }

	// RVA: 0xFFFFFFFF7599F674
	public Void .ctor() { }

}

// Namespace: 
public sealed class UnitySendMessageDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF7599F67C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7599F690
	public virtual Void Invoke(IntPtr objectName, IntPtr methodName, IntPtr parameter) { }

	// RVA: 0xFFFFFFFF7599F910
	public virtual IAsyncResult BeginInvoke(IntPtr objectName, IntPtr methodName, IntPtr parameter, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7599F9C4
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class UsercentricsIOSLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599FA58
	public static extern Void ucInitCMP(String initArgsJson) { }

	// RVA: 0xFFFFFFFF7599FA80
	public static extern Void ucShowFirstLayer(String bannerSettingsJson) { }

	// RVA: 0xFFFFFFFF7599FAA8
	public static extern Void ucShowSecondLayer(String bannerSettingsJson) { }

	// RVA: 0xFFFFFFFF7599FAD0
	public static extern String ucGetControllerId() { }

	// RVA: 0xFFFFFFFF7599FB04
	public static extern Void ucGetTCFData() { }

	// RVA: 0xFFFFFFFF7599FB08
	public static extern String ucGetUSPData() { }

	// RVA: 0xFFFFFFFF7599FB3C
	public static extern Void ucRestoreUserSession(String controllerId) { }

	// RVA: 0xFFFFFFFF7599FB64
	public static extern Void ucReset() { }

	// RVA: 0xFFFFFFFF7599FB68
	public static extern Void ucSubscribeOnConsentUpdated() { }

	// RVA: 0xFFFFFFFF7599FB6C
	public static extern Void ucDisposeOnConsentUpdatedSubscription() { }

	// RVA: 0xFFFFFFFF7599FB70
	public static extern Void ucSubscribeOnConsentMediation() { }

	// RVA: 0xFFFFFFFF7599FB74
	public static extern Void ucDisposeOnConsentMediationSubscription() { }

	// RVA: 0xFFFFFFFF7599FB78
	public static extern String ucGetFirstLayerSettings() { }

	// RVA: 0xFFFFFFFF7599FBAC
	public static extern Void ucAcceptAll() { }

	// RVA: 0xFFFFFFFF7599FBB0
	public static extern Void ucDenyAll() { }

	// RVA: 0xFFFFFFFF7599FBB4
	public static extern Void ucTrack(Int32 eventType) { }

	// RVA: 0xFFFFFFFF7599FBB8
	public static extern Void ucSetCmpId(Int32 cmpId) { }

	// RVA: 0xFFFFFFFF7599FBBC
	public static extern String ucGetCmpData() { }

	// RVA: 0xFFFFFFFF7599FBF0
	public static extern Void ucSetABTestingVariant(String variant) { }

	// RVA: 0xFFFFFFFF7599FC18
	public static extern String ucGetABTestingVariant() { }

	// RVA: 0xFFFFFFFF7599FC4C
	public static extern String ucGetAdditionalConsentModeData() { }

	// RVA: 0xFFFFFFFF7599FC80
	public static extern String ucGetConsents() { }

	// RVA: 0xFFFFFFFF7599FCB4
	public static extern String ucSetPurposesFlatlyNotAllowed(String purposes) { }

	// RVA: 0xFFFFFFFF7599FD00
	public static extern Void ucClearUserSession() { }

	// RVA: 0xFFFFFFFF7599FD04
	public Void .ctor() { }

}

// Namespace: 
public class ACInterfaceLib
{
	// Fields
	private const String DLL_NAME = "libmoba";
	private const String PLUG_DLL = "libplug";

	// Methods

	// RVA: 0xFFFFFFFF75972D94
	public static IntPtr PLUG_LibVersion() { }

	// RVA: 0xFFFFFFFF75972D9C
	public static IntPtr GetLocalSym(Int32 index, String info) { }

	// RVA: 0xFFFFFFFF75972DA4
	public static IntPtr OpenLib(Int32 index, String info) { }

	// RVA: 0xFFFFFFFF75972DAC
	public static IntPtr MDLib(UInt32 index, String info) { }

	// RVA: 0xFFFFFFFF75972DB4
	public static IntPtr MetEntry(UInt32 index, String info) { }

	// RVA: 0xFFFFFFFF75972DBC
	public static IntPtr MetEntry1(UInt32 index, String info) { }

	// RVA: 0xFFFFFFFF75972DC4
	public static IntPtr MetEntry2(UInt32 index, String info) { }

	// RVA: 0xFFFFFFFF75972DCC
	public static IntPtr MetEntry3(UInt32 index, String info) { }

	// RVA: 0xFFFFFFFF75972DD4
	public static IntPtr MalApp(String appInfo) { }

	// RVA: 0xFFFFFFFF75972DDC
	public static IntPtr CheckLib(String so, UInt32 offset, UInt32 size) { }

	// RVA: 0xFFFFFFFF75972DE4
	public static Int32 MemoryInit() { }

	// RVA: 0xFFFFFFFF75972DEC
	public static Int32 MemoryAlloc() { }

	// RVA: 0xFFFFFFFF75972DF4
	public static Int32 IsMainThread(String name) { }

	// RVA: 0xFFFFFFFF75972DFC
	public static UInt32 GetFileMaxOffset(String fname) { }

	// RVA: 0xFFFFFFFF75972E04
	public static Int32 SetThreadName(String name) { }

	// RVA: 0xFFFFFFFF75972E0C
	public static Int32 AISetThreadAffinity(UInt32 thread_affinity_mask) { }

	// RVA: 0xFFFFFFFF75972E14
	public static Boolean il2cpp_gc_is_incremental() { }

	// RVA: 0xFFFFFFFF75972E1C
	public Void .ctor() { }

}

// Namespace: 
public class BattleAHKLIb
{
	// Fields
	private const String DLL_NAME = "libmoba";

	// Methods

	// RVA: 0xFFFFFFFF75976DE0
	public static extern UInt32 GC_get_total_bytes() { }

	// RVA: 0xFFFFFFFF75976DE4
	public static extern Void GC_gcollect() { }

	// RVA: 0xFFFFFFFF75976DE8
	public Void .ctor() { }

}

// Namespace: 
public class ComFuncLib
{
	// Fields
	public const String MOBA_DLL_NAME = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF75976E68
	public static extern Int32 _IOS_ReadAssetsBytesExt(String path, ref IntPtr data, Int32 offset) { }

	// RVA: 0xFFFFFFFF75976EB4
	public static extern Int32 _IOS_ReleaseBytes(IntPtr data) { }

	// RVA: 0xFFFFFFFF75976EB8
	public static extern Int32 il2cpp_dense_hashtable_count() { }

	// RVA: 0xFFFFFFFF75976EBC
	public static extern Int32 il2cpp_dense_hashtable_size(Int32 index) { }

	// RVA: 0xFFFFFFFF75976EC0
	public static extern Int32 il2cpp_dense_hashtable_total_size() { }

	// RVA: 0xFFFFFFFF75976EC4
	public static extern String il2cpp_dense_hashtable_name(Int32 index) { }

	// RVA: 0xFFFFFFFF75976EF8
	public Void .ctor() { }

}

// Namespace: 
public class ConfFactLib
{
	// Fields
	public static XmlLoadDelegate xmlLoadDelegate; // 0x0
	public static BytesLoadDelegate bytesLoadDelegate; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75976FEC
	public static String XmlLoadForCppLib(String file) { }

	// RVA: 0xFFFFFFFF7597704C
	public static IntPtr BytesLoadForCppLib(String file) { }

	// RVA: 0xFFFFFFFF759777FC
	public Void .ctor() { }

}

// Namespace: 
public sealed class XmlLoadDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75977894
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF759770D4
	public virtual String Invoke(String filename) { }

	// RVA: 0xFFFFFFFF759778A8
	public virtual IAsyncResult BeginInvoke(String filename, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759778F8
	public virtual String EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class BytesLoadDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75977804
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75977468
	public virtual IntPtr Invoke(String filename) { }

	// RVA: 0xFFFFFFFF75977818
	public virtual IAsyncResult BeginInvoke(String filename, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75977868
	public virtual IntPtr EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class CppWrapLib
{
	// Fields
	public const String BATTLELOGIC_DLL_NAME = "battlelogic";

	// Methods

	// RVA: 0xFFFFFFFF75977904
	public static IntPtr BattleLogic_GetVersion() { }

	// RVA: 0xFFFFFFFF75977934
	public Void .ctor() { }

}

// Namespace: 
public class DataReportMgrLib
{
	// Methods

	// RVA: 0xFFFFFFFF7597793C
	public static extern UInt64 il2cpp_stats_get_value(Int32 stat) { }

	// RVA: 0xFFFFFFFF75977940
	public Void .ctor() { }

}

// Namespace: 
public class DeviceUtilLib
{
	// Methods

	// RVA: 0xFFFFFFFF75977984
	public static Int64 GetTotalBytesCpp() { }

	// RVA: 0xFFFFFFFF7597798C
	public static Int64 GetTotalAllocCpp() { }

	// RVA: 0xFFFFFFFF75977994
	public static Int64 GetHeapSizeCpp() { }

	// RVA: 0xFFFFFFFF7597799C
	public static Int32 GetGCCountCpp() { }

	// RVA: 0xFFFFFFFF759779A4
	public static extern Void _IOS_GetGFXMemorySummary(String gameObjectName, String methodName) { }

	// RVA: 0xFFFFFFFF759779EC
	public static extern Int64 il2cpp_gc_get_heap_size() { }

	// RVA: 0xFFFFFFFF759779F0
	public static extern Boolean il2cpp_gc_is_incremental() { }

	// RVA: 0xFFFFFFFF75977A0C
	public static extern Void _IOS_BlowDetector(Int32 maxAmplitude_IOS, Int32 frequency, Int32 timeout, String gameObjectName, String gameObjectMethodName) { }

	// RVA: 0xFFFFFFFF75977A80
	public static extern Boolean IOS_ScreenShot(String imagePath) { }

	// RVA: 0xFFFFFFFF75977AB8
	public static extern Void _IOS_RegisterIOSInterruptionCallback(String callbackGameObjectName, String callbackMethodName) { }

	// RVA: 0xFFFFFFFF75977B00
	public static Int32 GC_get_all_interior_pointers() { }

	// RVA: 0xFFFFFFFF75977B08
	public Void .ctor() { }

}

// Namespace: 
public class DynamicSOManagerLib
{
	// Fields
	public static FindPluginCallbackExt findPluginCallbackDelegate; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75977BFC
	public static String OnFindPluginCallbackExtLib(String libraryName) { }

	// RVA: 0xFFFFFFFF75978000
	public Void .ctor() { }

}

// Namespace: 
public sealed class FindPluginCallbackExt
{
	// Methods

	// RVA: 0xFFFFFFFF75978008
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75977C6C
	public virtual String Invoke(String libraryName) { }

	// RVA: 0xFFFFFFFF7597801C
	public virtual IAsyncResult BeginInvoke(String libraryName, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597806C
	public virtual String EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class GPSDKLib
{
	// Methods

	// RVA: 0xFFFFFFFF7597C45C
	public static extern Void GPSDKInit(String app_id, Int32 region, Boolean isSandbox, Boolean isUsePacketChannel) { }

	// RVA: 0xFFFFFFFF7597C4A4
	public static extern Void GPSDKSetUserInfo(Int32 account_type, String open_id, Int64 server_id, String role_id) { }

	// RVA: 0xFFFFFFFF7597C508
	public static extern Void GPSDKSetDeviceInfo(String device_id, String install_id) { }

	// RVA: 0xFFFFFFFF7597C550
	public static extern Void GPSDKReportInfo(String scene) { }

	// RVA: 0xFFFFFFFF7597C578
	public static extern Void GPSDKStartInterface() { }

	// RVA: 0xFFFFFFFF7597C57C
	public Void .ctor() { }

}

// Namespace: 
public class HashUtilLib
{
	// Fields
	private const String GAMECORE_DLL_NAME = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF7598F07C
	public static extern UInt32 moba_hash_string_32(String str) { }

	// RVA: 0xFFFFFFFF7598F0B0
	public static extern UInt64 moba_hash_string_64(String str) { }

	// RVA: 0xFFFFFFFF7598F0E4
	public static extern UInt64 moba_hash_string_64_h3(String str) { }

	// RVA: 0xFFFFFFFF7598F118
	public static extern UInt32 moba_hash_file_32(String filePath) { }

	// RVA: 0xFFFFFFFF7598F14C
	public static extern UInt64 moba_hash_file_64(String filePath) { }

	// RVA: 0xFFFFFFFF7598F180
	public static extern UInt64 moba_hash_file_64_h3(String filePath) { }

	// RVA: 0xFFFFFFFF7598F1B4
	public Void .ctor() { }

}

// Namespace: 
public class LibNativeGameCoreLib
{
	// Fields
	public const String GAMECORE_DLL_NAME = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF75990040
	public static extern IntPtr GAMECORE_LibBigVersion() { }

	// RVA: 0xFFFFFFFF75990044
	public static extern IntPtr GAMECORE_LibSmallVersion() { }

	// RVA: 0xFFFFFFFF75990048
	public static extern IntPtr GAMECORE_LibVersionString() { }

	// RVA: 0xFFFFFFFF7599004C
	public static extern Int32 SevenZip_CombineFiles(String rootPath, String xmlFilePath) { }

	// RVA: 0xFFFFFFFF759900A8
	public static extern Boolean login_library_setup(String persistPath) { }

	// RVA: 0xFFFFFFFF759900E0
	public Void .ctor() { }

}

// Namespace: 
public class LibNativeMobaLib
{
	// Fields
	public const String MOBA_DLL_NAME = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF759900E8
	public static extern IntPtr MOBA_LibBigVersion() { }

	// RVA: 0xFFFFFFFF759900EC
	public static extern IntPtr MOBA_LibSmallVersion() { }

	// RVA: 0xFFFFFFFF759900F0
	public static extern IntPtr MOBA_LibVersionString() { }

	// RVA: 0xFFFFFFFF759900F4
	public Void .ctor() { }

}

// Namespace: 
public class LoginCLibraryUtilsLib
{
	// Fields
	private const String LOGIN_DLL = "liblogin";

	// Methods

	// RVA: 0xFFFFFFFF75990308
	public static extern Int32 Login_Version() { }

	// RVA: 0xFFFFFFFF75990378
	public static extern Void Login_SetupPath(String streamAssetPath, String persistPath) { }

	// RVA: 0xFFFFFFFF75990430
	public static extern Void Login_Reset() { }

	// RVA: 0xFFFFFFFF759904A0
	public static extern Void Login_Start() { }

	// RVA: 0xFFFFFFFF75990510
	public static extern Void Login_Close() { }

	// RVA: 0xFFFFFFFF75990580
	public static extern Int32 Login_GetID(Int32 loginID) { }

	// RVA: 0xFFFFFFFF75990600
	public static extern Void Login_SetIps(String ips) { }

	// RVA: 0xFFFFFFFF7599068C
	public static extern Void Login_SetupAuthData(Int32 zoneID, Int32 loginID, Int32 osType, Int32 switchVersion, Int32 languageId, String accountName, String authKey, String clientVersion, String deviceInfo, String loginAccessToken, String productionType, String channel, String unityVersion, String serverIP, Int32 serverPort) { }

	// RVA: 0xFFFFFFFF75990830
	public static extern IntPtr Login_GetMessage(Int32 messageIndex, out Int32 length, out Int32 rspcode, out Int32 rspseq) { }

	// RVA: 0xFFFFFFFF759908D8
	public static extern IntPtr Login_GetMessage_V2(Int32 messageIndex, out Int32 length, out Int32 rspcode, out Int32 rspseq, IntPtr c2sData, Int32 size) { }

	// RVA: 0xFFFFFFFF75990998
	public Void .ctor() { }

}

// Namespace: 
public class MLlibAILocalServiceBBAI
{
	// Fields
	public const String MOBILE_BBAI_DLL_NAME = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF75993BF0
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75993C48
	public static extern Boolean LoadBBAISDK() { }

	// RVA: 0xFFFFFFFF75993C64
	public static extern Void UnloadBBAISDK() { }

	// RVA: 0xFFFFFFFF75993C68
	public static extern Boolean initTableDataBridge(Byte* byteStr, Int32 length) { }

	// RVA: 0xFFFFFFFF75993C84
	public static extern Int32 initTableDataLocalBridge(Byte* pathToBin, Int32 length) { }

	// RVA: 0xFFFFFFFF75993C88
	public static Boolean initTableData(Byte* byteStr, Int32 length) { }

	// RVA: 0xFFFFFFFF75993D00
	public static Int32 initTableDataLocal(Byte* pathToBin, Int32 length) { }

	// RVA: 0xFFFFFFFF75993D6C
	public static extern Boolean initFeatureBridge(Byte* byteStr, Int32 length, Byte* heroStr, Int32 heroLength) { }

	// RVA: 0xFFFFFFFF75993D88
	public static extern Int32 initFeatureLocalBridge(Byte* pathToBin, Int32 length, Byte* heroStr, Int32 heroLength) { }

	// RVA: 0xFFFFFFFF75993D8C
	public static Boolean initFeature(Byte* byteStr, Int32 length, Byte* heroStr, Int32 heroLength) { }

	// RVA: 0xFFFFFFFF75993E1C
	public static Int32 initFeatureLocal(Byte* pathToBin, Int32 length, Byte* heroStr, Int32 heroLength) { }

	// RVA: 0xFFFFFFFF75993EA0
	public static extern Boolean initModelBridge(Byte* byteStr, Int32 length) { }

	// RVA: 0xFFFFFFFF75993EBC
	public static extern Int32 initModelLocalBridge(Byte* pathToBin, Int32 length) { }

	// RVA: 0xFFFFFFFF75993EC0
	public static Boolean initModel(Byte* byteStr, Int32 length) { }

	// RVA: 0xFFFFFFFF75993F38
	public static Int32 initModelLocal(Byte* pathToBin, Int32 length) { }

	// RVA: 0xFFFFFFFF75993FA4
	public static extern Boolean initMapBridge(Byte* byteStr, Int32 length) { }

	// RVA: 0xFFFFFFFF75993FC0
	public static extern Int32 initMapLocalBridge(Byte* pathToBin, Int32 length) { }

	// RVA: 0xFFFFFFFF75993FC4
	public static Boolean initMap(Byte* byteStr, Int32 length) { }

	// RVA: 0xFFFFFFFF7599403C
	public static Int32 initMapLocal(Byte* pathToBin, Int32 length) { }

	// RVA: 0xFFFFFFFF759940A8
	public static extern Boolean initMasterBridge(Byte* byteStr, Int32 length) { }

	// RVA: 0xFFFFFFFF759940C4
	public static extern Int32 initMasterLocalBridge(Byte* pathToBin, Int32 length) { }

	// RVA: 0xFFFFFFFF759940C8
	public static Boolean initMaster(Byte* byteStr, Int32 length) { }

	// RVA: 0xFFFFFFFF75994140
	public static Int32 initMasterLocal(Byte* pathToBin, Int32 length) { }

	// RVA: 0xFFFFFFFF759941AC
	public static extern Boolean battleStartBridge(Byte* stateStart, Int32 length, Int32 threadNum) { }

	// RVA: 0xFFFFFFFF759941C8
	public static extern Boolean processBridge(Byte* state, Int32 stateLength, Byte* rsp, ref Int32 rspLength, ref Int32 nextFrame, ref Int32 flag) { }

	// RVA: 0xFFFFFFFF759941E4
	public static extern Boolean battleEndBridge() { }

	// RVA: 0xFFFFFFFF75994200
	public static Boolean battleStart(Byte* stateStart, Int32 length, Int32 threadNum) { }

	// RVA: 0xFFFFFFFF75994280
	public static Boolean process(Byte* state, Int32 stateLength, Byte* rsp, ref Int32 rspLength, ref Int32 nextFrame, ref Int32 flag) { }

	// RVA: 0xFFFFFFFF75994328
	public static Boolean battleEnd() { }

	// RVA: 0xFFFFFFFF75994388
	public static extern Int32 getVersionBridge() { }

	// RVA: 0xFFFFFFFF7599438C
	public static extern Boolean getVersionStrBridge(Byte* versionByte, ref Int32 length) { }

	// RVA: 0xFFFFFFFF759943A8
	public static extern Boolean getDebugLogBridge(Byte* ctx, ref Int32 length) { }

	// RVA: 0xFFFFFFFF75993BF4
	public static Int32 getVersion() { }

	// RVA: 0xFFFFFFFF759943C4
	public static Boolean getVersionStr(Byte* versionByte, ref Int32 length) { }

	// RVA: 0xFFFFFFFF7599443C
	public static Boolean getDebugLog(Byte* ctx, ref Int32 length) { }

	// RVA: 0xFFFFFFFF759944B4
	public Void .ctor() { }

}

// Namespace: 
public class MultiNetworkLib
{
	// Fields
	private const String MultiNetworkLibName = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF7599A578
	public static extern Int32 Ios_IL2CPPGetSocketFD(IntPtr handle) { }

	// RVA: 0xFFFFFFFF7599A57C
	public static Int32 IL2CPPGetSocketFD(IntPtr handle) { }

	// RVA: 0xFFFFFFFF7599A60C
	public static extern Int32 DualNetwork_Refresh() { }

	// RVA: 0xFFFFFFFF7599A610
	public static extern IntPtr DualNetwork_GetIP(Int32 iType) { }

	// RVA: 0xFFFFFFFF7599A614
	public static extern Int32 DualNetwork_BindSocketWithFD(Int32 iType, Int32 iFD) { }

	// RVA: 0xFFFFFFFF7599A618
	public static extern IntPtr DualNetwork_CheckLocalNet() { }

	// RVA: 0xFFFFFFFF7599A61C
	public static extern IntPtr DualNetwork_Check4GIPV6() { }

	// RVA: 0xFFFFFFFF7599A620
	public static extern String DualNetwork_GetIFAName(Int32 iType) { }

	// RVA: 0xFFFFFFFF7599A654
	public static extern String DualNetwork_GetAllIFAName() { }

	// RVA: 0xFFFFFFFF7599A688
	public Void .ctor() { }

}

// Namespace: 
public sealed class FunctionPointer_Void
{
	// Methods

	// RVA: 0xFFFFFFFF7599A690
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7599A6A4
	public virtual Void Invoke() { }

	// RVA: 0xFFFFFFFF7599A8A0
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7599A8F8
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class NativeUtilsLib
{
	// Fields
	public const String MOBA_DLL_NAME = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF7599A904
	public static extern Boolean _IOS_Default_IsStreamAssetsFileExit(String filePath) { }

	// RVA: 0xFFFFFFFF7599A93C
	public static extern Int32 _IOS_Default_ReadStreamAssetsFile(String filePath, ref IntPtr ptr) { }

	// RVA: 0xFFFFFFFF7599A978
	public static extern Void _IOS_Default_ReleaseBytes(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF7599A97C
	public Void .ctor() { }

}

// Namespace: 
public class NetCryptoUtilLib
{
	// Fields
	private const String GAMECORE_DLL_NAME = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF7599AA48
	public static extern Boolean aesencrypt(Byte[] data, UInt32 srcPos, UInt32 srcLen, String key, Byte[] dst, ref Int32 iDataSize) { }

	// RVA: 0xFFFFFFFF7599AAD0
	public static extern Boolean aesdecrypt(Byte[] data, UInt32 srcPos, UInt32 srcLen, String key, Byte[] dst, ref Int32 iDataSize) { }

	// RVA: 0xFFFFFFFF7599AB58
	public Void .ctor() { }

}

// Namespace: 
public class NetOptSocketPollLib
{
	// Fields
	private const String GAMECORE_DLL_NAME = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF7599AB60
	public static extern Void Socket_Opt_Poll(IntPtr fds, Int32 len, UInt64 timeoutMs) { }

	// RVA: 0xFFFFFFFF7599AB64
	public Void .ctor() { }

}

// Namespace: 
public class NetZstdUtilLib
{
	// Fields
	private const String GAMECORE_DLL_NAME = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF7599AB6C
	public static extern UInt32 ZSTDUtil_compressBound(UInt32 srcSize) { }

	// RVA: 0xFFFFFFFF7599AB70
	public static extern UInt32 ZSTDUtil_isError(UInt32 code) { }

	// RVA: 0xFFFFFFFF7599AB74
	public static extern UInt32 ZSTDUtil_getDecompressedSize(Byte[] src, UInt32 srcStartPos, UInt32 srcSize) { }

	// RVA: 0xFFFFFFFF7599AB84
	public static extern UInt32 ZSTDUtil_compress(Byte[] dst, UInt32 dstStartPos, UInt32 dstCapacity, Byte[] src, UInt32 srcStartPos, UInt32 srcSize, Int32 compressionLevel) { }

	// RVA: 0xFFFFFFFF7599ABA0
	public static extern UInt32 ZSTDUtil_decompress(Byte[] dst, UInt32 dstStartPos, UInt32 dstCapacity, Byte[] src, UInt32 srcStartPos, UInt32 compressedSize) { }

	// RVA: 0xFFFFFFFF7599ABBC
	public Void .ctor() { }

}

// Namespace: 
public class MarshalLib
{
	// Methods

	// RVA: 0xFFFFFFFF759944C4
	public static Void StructureToPtr(Object structure, IntPtr ptr, Boolean fDeleteOld) { }

	// RVA: 0xFFFFFFFF75994510
	public static Object PtrToStructure(IntPtr ptr, Type structureType) { }

	// RVA: 0xFFFFFFFF75994558
	public Void .ctor() { }

}

// Namespace: 
public class RakNetWrapperLib
{
	// Fields
	private const String RAKNET_LIB = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF7599B024
	public static Void RkN_Initialize() { }

	// RVA: 0xFFFFFFFF7599B028
	public static Void RkN_Initialize2(IntPtr pSettings) { }

	// RVA: 0xFFFFFFFF7599B02C
	public static Int32 RkN_CreatePeer() { }

	// RVA: 0xFFFFFFFF7599B034
	public static Int32 RkN_Startup(Int32 handle, String ip, UInt16 port, UInt32 maxConnections) { }

	// RVA: 0xFFFFFFFF7599B03C
	public static Void RkN_ReleaseClient(Int32 handle) { }

	// RVA: 0xFFFFFFFF7599B040
	public static IntPtr RkN_Receive(Int32 handle) { }

	// RVA: 0xFFFFFFFF7599B048
	public static UInt32 RkN_Send(Int32 handle, Byte[] data, Int32 length, Int32 priority, Int32 reliability, SByte orderingChannel, UInt64 guid, Boolean broadcast, Int32 forceReceiptNumber) { }

	// RVA: 0xFFFFFFFF7599B050
	public static UInt32 RkN_SendWithZip(Int32 handle, Byte[] data, Int32 length, Int32 priority, Int32 reliability, SByte orderingChannel, UInt64 guid, Boolean broadcast, Int32 forceReceiptNumber) { }

	// RVA: 0xFFFFFFFF7599B058
	public static Void RkN_Shutdown(Int32 handle, Int32 blockDuration, Byte orderingChannel, Int32 disconnectionNotificationPriority) { }

	// RVA: 0xFFFFFFFF7599B05C
	public static Void RkN_CloseConnection(Int32 handle, UInt64 guid, Boolean sendDisconnectionNotification, Byte orderingChannel, Int32 disconnectionNotificationPriority) { }

	// RVA: 0xFFFFFFFF7599B060
	public static Void RkN_SetMaximumIncomingConnections(Int32 handle, UInt16 numberAllowed) { }

	// RVA: 0xFFFFFFFF7599B064
	public static Int32 RkN_Connect(Int32 handle, String host, UInt16 port, UInt32 sendConnectionAttemptCount, UInt32 timeBetweenSendConnectionAttemptsMS, UInt32 timeoutTime) { }

	// RVA: 0xFFFFFFFF7599B06C
	public static Void RkN_Broadcast(Int32 handle, Byte[] data, Int32 length, Int32 priority, Int32 reliability, SByte orderingChannel, IntPtr pGUIDList, Int32 amount, Int32 forceReceiptNumber) { }

	// RVA: 0xFFFFFFFF7599B070
	public static Int32 RkN_GetAveragePing(Int32 handle, UInt64 guid) { }

	// RVA: 0xFFFFFFFF7599B078
	public static IntPtr RkN_ReceiveCycle(Int32 handle, Int32 packetRetrieveLimit) { }

	// RVA: 0xFFFFFFFF7599B080
	public static IntPtr RkN_ReceiveCycle2(Int32 handle, Int32 packetRetrieveLimit) { }

	// RVA: 0xFFFFFFFF7599B088
	public static Void RkN_ReleasePacketList(IntPtr packetList) { }

	// RVA: 0xFFFFFFFF7599B08C
	public static Void RkN_Uninitialize() { }

	// RVA: 0xFFFFFFFF7599B090
	public static Int32 RkN_GetConnectionState(Int32 handle, UInt64 guid) { }

	// RVA: 0xFFFFFFFF7599B098
	public static UInt32 RkN_GetNativeMemoryUsage() { }

	// RVA: 0xFFFFFFFF7599B0A0
	public static Void RkN_EnableZip(Boolean enable) { }

	// RVA: 0xFFFFFFFF7599B0A4
	public static Boolean RkN_IsZipEnabled() { }

	// RVA: 0xFFFFFFFF7599B0AC
	public static Void RkN_SetZipControlCode(Int32 iControlCode) { }

	// RVA: 0xFFFFFFFF7599B0B0
	public static Int32 RkN_GetZipControlCode() { }

	// RVA: 0xFFFFFFFF7599B0B8
	public Void .ctor() { }

}

// Namespace: 
public class RudpWrapperLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599B25C
	public Void .ctor() { }

}

// Namespace: 
public sealed class FunctionPointerRudpThreadStart
{
	// Methods

	// RVA: 0xFFFFFFFF7599B4D8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7599B4EC
	public virtual Void Invoke() { }

	// RVA: 0xFFFFFFFF7599B6E8
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7599B740
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class FunctionPointerNetEventNotifyCallback
{
	// Methods

	// RVA: 0xFFFFFFFF7599B264
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7599B278
	public virtual Void Invoke() { }

	// RVA: 0xFFFFFFFF7599B474
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7599B4CC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class SDKWifiDeviceScanLib
{
	// Fields
	private const String LUADLL = "libmoba";

	// Methods

	// RVA: 0xFFFFFFFF7599D3E4
	public static extern Void _IOS_InitWifiDeviceScan(String gameObjectName) { }

	// RVA: 0xFFFFFFFF7599D40C
	public static extern Void _IOS_StartScanDevice() { }

	// RVA: 0xFFFFFFFF7599D410
	public static extern String _IOS_GetNetworkType() { }

	// RVA: 0xFFFFFFFF7599D444
	public static extern String _IOS_GetSignalStrength() { }

	// RVA: 0xFFFFFFFF7599D478
	public static extern Boolean _IOS_IsWifiConnected() { }

	// RVA: 0xFFFFFFFF7599D494
	public Void .ctor() { }

}

// Namespace: 
public class SevenZipExtractorLib
{
	// Fields
	public const String MOBA_DLL_NAME = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF7599D844
	public static extern Void SevenZip_SetupCallback_OnStart(SevenZipCallback_VoidCallback cbOnStart) { }

	// RVA: 0xFFFFFFFF7599D858
	public static extern Void SevenZip_SetupCallback_OnGetFileNum(SevenZipCallback_IntCallback cbOnGetFileNum) { }

	// RVA: 0xFFFFFFFF7599D86C
	public static extern Void SevenZip_SetupCallback_OnProgress(SevenZipCallback_IntStringCallback cbOnProgress) { }

	// RVA: 0xFFFFFFFF7599D880
	public static extern Void SevenZip_SetupCallback_OnError(SevenZipCallback_IntStringCallback cbOnError) { }

	// RVA: 0xFFFFFFFF7599D894
	public static extern Void SevenZip_SetupCallback_OnSuccess(SevenZipCallback_VoidCallback cbOnSuccess) { }

	// RVA: 0xFFFFFFFF7599D8A8
	public static extern Void SevenZip_ExtractFile(String srcFile, String destDir, UInt32 inBufSize) { }

	// RVA: 0xFFFFFFFF7599D900
	public Void .ctor() { }

}

// Namespace: 
public sealed class SevenZipCallback_VoidCallback
{
	// Methods

	// RVA: 0xFFFFFFFF7599DF44
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7599DF58
	public virtual Void Invoke() { }

	// RVA: 0xFFFFFFFF7599E154
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7599E1AC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class SevenZipCallback_IntCallback
{
	// Methods

	// RVA: 0xFFFFFFFF7599D908
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7599D91C
	public virtual Void Invoke(Int32 iValue) { }

	// RVA: 0xFFFFFFFF7599DB70
	public virtual IAsyncResult BeginInvoke(Int32 iValue, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7599DC00
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class SevenZipCallback_IntStringCallback
{
	// Methods

	// RVA: 0xFFFFFFFF7599DC0C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7599DC20
	public virtual Void Invoke(Int32 iValue, IntPtr sValue) { }

	// RVA: 0xFFFFFFFF7599DE90
	public virtual IAsyncResult BeginInvoke(Int32 iValue, IntPtr sValue, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7599DF38
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class ShowStrategyCompLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599E37C
	public Void .ctor() { }

}

// Namespace: 
public struct _UdpEvent
{
	// Fields
	public UInt32 iPipeId; // 0x10
	private Int32 iEventType; // 0x14
	private Int32 iMsgType; // 0x18
	public String source_ip; // 0x20
}

// Namespace: 
public enum UdpEventType
{
	// Fields
	public Int32 value__; // 0x10
	public const UdpEventType UdpEventType_None = 0;
	public const UdpEventType UdpEventType_Connect_OK = 1;
	public const UdpEventType UdpEventType_Connect_Failed = 2;
	public const UdpEventType UdpEventType_Disconnect = 3;
	public const UdpEventType UdpEventType_Data = 4;
}

// Namespace: 
public enum UdpMessageType
{
	// Fields
	public Int32 value__; // 0x10
	public const UdpMessageType UdpMessageType_Reliable = 0;
	public const UdpMessageType UdpMessageType_Unreliable = 1;
}

// Namespace: 
public class UniUdpPlugin
{
	// Fields
	private const String LUADLL = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF7599E540
	public static extern Int32 mySum1(Byte[] a, String b) { }

	// RVA: 0xFFFFFFFF7599E58C
	public static extern Boolean mySum2(String a, Int32 b) { }

	// RVA: 0xFFFFFFFF7599E5CC
	public static extern Int32 InitPipeManager_C(Int32 loglevel, Boolean savelog, Int32 listenwaittime, Int32 connectinter, Int32 maxconnum, Int32 disconinter, Int32 maxdisconnum, Int32 flushwaittime) { }

	// RVA: 0xFFFFFFFF7599E5D0
	public static extern Int32 CreatePipe_C(String sip, Int32 iport, String sTcpIp, Int32 iTcpPort, String sdes, Byte[] rsip, Int32 imtu, Int32 idscp, Boolean bVerboseLog, Int32 iNoDelay, Int32 iSndWnd, Int32 iRcvWnd, Int32 iFastResend, Int32 iInitRTO, Int32 iMinRTO, Int32 iSSThresh, Int32 iDeadLink, Int32 iCheckAvailability, Boolean bUseTcpChannel) { }

	// RVA: 0xFFFFFFFF7599E6CC
	public static extern Int32 Destory_C() { }

	// RVA: 0xFFFFFFFF7599E6D0
	public static extern UInt64 GetUniqIdentifier_C() { }

	// RVA: 0xFFFFFFFF7599E6D4
	public static extern Int32 RandomSeed(Int32 seed) { }

	// RVA: 0xFFFFFFFF7599E6D8
	public static extern Int32 GetLog(Byte[] _log, Int32 _size) { }

	// RVA: 0xFFFFFFFF7599E6E8
	public static extern Int32 ClearLog() { }

	// RVA: 0xFFFFFFFF7599E6EC
	public static extern UInt64 GetRandom64() { }

	// RVA: 0xFFFFFFFF7599E6F0
	public static extern UInt32 GetRandom32() { }

	// RVA: 0xFFFFFFFF7599E6F4
	public static extern Int32 KCP_ReceiveCycle(Int32 handle) { }

	// RVA: 0xFFFFFFFF7599E6F8
	public static extern IntPtr KCP_GetReceiveData(Int32 iIndex, ref Int32 iDataSize, ref Int32 iPipeIndex, ref Int32 iEventType, ref Int32 iMsgType, ref UInt64 iClock, ref Int32 iFlag) { }

	// RVA: 0xFFFFFFFF7599E6FC
	public static extern Void KCP_ReceiveReleaseData() { }

	// RVA: 0xFFFFFFFF7599E700
	public static extern Int32 KCP_SendMsg(Int32 handle, Int32 relitype, Byte[] sendData, Int32 _size, Boolean bTcpOnly) { }

	// RVA: 0xFFFFFFFF7599E710
	public static extern Void KCP_EnableZip(Boolean bIsZip) { }

	// RVA: 0xFFFFFFFF7599E714
	public static extern Boolean KCP_IsZipEnabled() { }

	// RVA: 0xFFFFFFFF7599E730
	public static extern Void KCP_SetZipControlCode(Int32 iControlCode) { }

	// RVA: 0xFFFFFFFF7599E734
	public static extern Int32 KCP_GetZipControlCode() { }

	// RVA: 0xFFFFFFFF7599E738
	public static extern Int32 KCP_PipeClose(Int32 handle) { }

	// RVA: 0xFFFFFFFF7599E73C
	public static UInt64 KCP_GetMonotonicClockMS_C() { }

	// RVA: 0xFFFFFFFF7599E744
	public static extern Void EnableDualChannel() { }

	// RVA: 0xFFFFFFFF7599E748
	public static extern Void DisableDualChannel() { }

	// RVA: 0xFFFFFFFF7599E74C
	public static extern Int32 KCP_ReceiveCycleWithHandle(Int32 handle) { }

	// RVA: 0xFFFFFFFF7599E750
	public static extern Void KCP_SetCreateCSocketCallback(IntPtr fptr) { }

	// RVA: 0xFFFFFFFF7599E754
	public Void .ctor() { }

}

// Namespace: 
public class UniUdpPluginImp_Add
{
	// Methods

	// RVA: 0xFFFFFFFF7599E75C
	public Void .ctor() { }

}

// Namespace: 
public class Unity2017UpdateUtilsLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599F9D0
	public Void .ctor() { }

}

// Namespace: 
public class Unity5PatchManagerLib
{
	// Fields
	public const String MOBA_DLL_NAME = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF7599F9D8
	public static extern Int32 BSPatch_PatchFile(String sOldFilepath, String sNewFilePath, String sPatchFilePath) { }

	// RVA: 0xFFFFFFFF7599FA50
	public Void .ctor() { }

}

// Namespace: 
public class WorkerCSLib
{
	// Fields
	private const String GAMECORE_DLL_NAME = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF7599FD8C
	public static extern Int32 GCore_StartLogicThread(ThreadStartCpp threadStart, IntPtr param, Int32 prio, LogForCpp log, Int32 affinity) { }

	// RVA: 0xFFFFFFFF7599FDE8
	public static extern Int32 GCore_SetThreadAffinity(Int32 affinity) { }

	// RVA: 0xFFFFFFFF7599FDEC
	public static extern Int32 GCore_SetThreadAffinityThroughId(Int32 pid, Int32 affinity) { }

	// RVA: 0xFFFFFFFF7599FDF0
	public static extern Int32 GCore_GetThreadAffinity(Int32 tid) { }

	// RVA: 0xFFFFFFFF7599FDF4
	public static extern Int32 GCore_GetCurThreadAffinity() { }

	// RVA: 0xFFFFFFFF7599FDF8
	public static extern Int32 GCore_GetLogicThreadAffinity() { }

	// RVA: 0xFFFFFFFF7599FDFC
	public static extern Int32 GCore_GetLogicThreadId() { }

	// RVA: 0xFFFFFFFF7599FE00
	public static extern Int32 GCore_GetCurThreadId() { }

	// RVA: 0xFFFFFFFF7599FD0C
	public static Void StartDoSthByCpp(IntPtr wokerPtr) { }

	// RVA: 0xFFFFFFFF7599FD88
	public static Void DebugLog(String str) { }

	// RVA: 0xFFFFFFFF7599FE04
	public Void .ctor() { }

}

// Namespace: 
public sealed class ThreadStartCpp
{
	// Methods

	// RVA: 0xFFFFFFFF759A020C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF759A0220
	public virtual Void Invoke(IntPtr wokerPtr) { }

	// RVA: 0xFFFFFFFF759A0470
	public virtual IAsyncResult BeginInvoke(IntPtr wokerPtr, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759A0500
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class LogForCpp
{
	// Methods

	// RVA: 0xFFFFFFFF7599FE0C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7599FE20
	public virtual Void Invoke(String pRet) { }

	// RVA: 0xFFFFFFFF759A01B0
	public virtual IAsyncResult BeginInvoke(String pRet, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759A0200
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public static class ZstdUtilLib
{
	// Fields
	private const String GAMECORE_DLL_NAME = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF759A19C0
	public static extern UInt32 ZSTDUtil_compressBound(UInt32 srcSize) { }

	// RVA: 0xFFFFFFFF759A19C4
	public static extern UInt32 ZSTDUtil_isError(UInt32 code) { }

	// RVA: 0xFFFFFFFF759A19C8
	public static extern UInt32 ZSTDUtil_getDecompressedSize(Byte[] src, UInt32 srcStartPos, UInt32 srcSize) { }

	// RVA: 0xFFFFFFFF759A19D8
	public static extern UInt32 ZSTDUtil_compress(Byte[] dst, UInt32 dstStartPos, UInt32 dstCapacity, Byte[] src, UInt32 srcStartPos, UInt32 srcSize, Int32 compressionLevel) { }

	// RVA: 0xFFFFFFFF759A19F4
	public static extern UInt32 ZSTDUtil_decompress(Byte[] dst, UInt32 dstStartPos, UInt32 dstCapacity, Byte[] src, UInt32 srcStartPos, UInt32 compressedSize) { }

}

// Namespace: 
public static class LuaCppLoad
{
	// Fields
	private const String GAMECORE_DLL_NAME = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF759909F4
	public static extern Int32 lua_loader_reset() { }

	// RVA: 0xFFFFFFFF759909F8
	public static extern Int32 lua_loader_init() { }

	// RVA: 0xFFFFFFFF759909FC
	public static extern Int32 lua_loader_init_load_binary(Int32 index, Int32 luaBinaryCount, String luaBinaryPath) { }

	// RVA: 0xFFFFFFFF75990A50
	public static extern Int32 lua_loader_add_searchPath(String searchPath) { }

	// RVA: 0xFFFFFFFF75990A84
	public static extern Int32 lua_loader_require(IntPtr luaState, String luaPath, out Int32 size) { }

	// RVA: 0xFFFFFFFF75990AD8
	public static extern Int32 lua_loader_free_all_memory() { }

}

// Namespace: 
public class AnalyticsLib
{
	// Methods

	// RVA: 0xFFFFFFFF75976CB0
	public static extern String _IOS_GetMemoryInfo() { }

	// RVA: 0xFFFFFFFF75976CE4
	public static extern String _IOS_GetBatteryInfo() { }

	// RVA: 0xFFFFFFFF75976D18
	public static extern String _IOS_InitMemoryWarningReport(String gameObjectName, String funcName) { }

	// RVA: 0xFFFFFFFF75976D84
	public Void .ctor() { }

}

// Namespace: 
public class AppNotificationListenerLib
{
	// Methods

	// RVA: 0xFFFFFFFF75976D8C
	public static extern Void _IOS_RegisterNotificationListener(String gameObjectName, String methodName) { }

	// RVA: 0xFFFFFFFF75976DD4
	public static extern Void _IOS_UnregisterNotificationListener() { }

	// RVA: 0xFFFFFFFF75976DD8
	public Void .ctor() { }

}

// Namespace: 
public class GPMSDKLib
{
	// Methods

	// RVA: 0xFFFFFFFF7597C0DC
	public static extern Void _GPM_SetSandbox(Boolean isSandbox) { }

	// RVA: 0xFFFFFFFF7597C0E0
	public static extern Void _GPM_Init(String gameObjectName, String parametersJsonStr) { }

	// RVA: 0xFFFFFFFF7597C128
	public static extern Void _GPM_SetCommonParams(String parametersJsonStr) { }

	// RVA: 0xFFFFFFFF7597C150
	public static extern Void _GPM_AddTags(String parametersJsonStr) { }

	// RVA: 0xFFFFFFFF7597C178
	public static extern Void _GPM_AddCustomInfo(String parametersJsonStr) { }

	// RVA: 0xFFFFFFFF7597C1A0
	public static extern Void _GPM_AddLogs(String parametersJsonStr) { }

	// RVA: 0xFFFFFFFF7597C1C8
	public static extern Void _IOS_GPM_RegisterGetLuaStack(StringVoid getCrash) { }

	// RVA: 0xFFFFFFFF7597C1DC
	public Void .ctor() { }

}

// Namespace: 
public sealed class StringVoid
{
	// Methods

	// RVA: 0xFFFFFFFF7597C1E4
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597C1F8
	public virtual String Invoke() { }

	// RVA: 0xFFFFFFFF7597C3F8
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597C450
	public virtual String EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class SDKLocalTestLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599D0E8
	public Void .ctor() { }

}

// Namespace: 
public class GMVideoPlayerAOT
{
	// Fields
	private const String dllName = "__Internal";
	private static IOSStateChangeEventHandler OnIOSStateChangeEvent; // 0x0
	private static IOSTimeUpdateEventHandler OnIOSTimeUpdateEvent; // 0x8
	private static IOSFrameTextureEventHandler OnIOSFrameTextureEvent; // 0x10
	private static IOSBeginDraggingEventHandler OnIOSBeginDraggingEvent; // 0x18
	private static IOSEndDraggingEventHandler OnIOSEndDraggingEvent; // 0x20
	private static IOSViewModeChangeEventHandler OnIOSViewModeChangeEvent; // 0x28
	private static IOSCloseEventHandler OnIOSCloseEvent; // 0x30

	// Methods

	// RVA: 0xFFFFFFFF759786EC
	public static extern Void GMVideoPlayerSetConfig(String roleId, Int64 serverId) { }

	// RVA: 0xFFFFFFFF7597871C
	public static extern Void GMVideoPlayerSetUserData(IntPtr player, IntPtr userData) { }

	// RVA: 0xFFFFFFFF75978720
	public static extern IntPtr GMVideoPlayerUserData(IntPtr player) { }

	// RVA: 0xFFFFFFFF75978724
	public static extern Void GMVideoPlayerSetUrl(IntPtr player, String url) { }

	// RVA: 0xFFFFFFFF7597875C
	public static extern Void GMVideoPlayerSetData(IntPtr player, IntPtr bytes, Int32 size) { }

	// RVA: 0xFFFFFFFF75978760
	public static extern Void GMVideoPlayerSetUrlForBlade(IntPtr player, String url, Int32 skip) { }

	// RVA: 0xFFFFFFFF759787A8
	public static extern Single GMVideoPlayerVolume(IntPtr player) { }

	// RVA: 0xFFFFFFFF759787AC
	public static extern Void GMVideoPlayerSetVolume(IntPtr player, Single volume) { }

	// RVA: 0xFFFFFFFF759787B0
	public static extern Void GMVideoPlayerSetLooping(IntPtr player, Boolean looping) { }

	// RVA: 0xFFFFFFFF759787B4
	public static extern Void GMVideoPlayerSetRate(IntPtr player, Single rate) { }

	// RVA: 0xFFFFFFFF759787B8
	public static extern Void GMVideoPlayerSetContentMode(IntPtr player, Int32 contentMode) { }

	// RVA: 0xFFFFFFFF759787BC
	public static extern Void GMVideoPlayerSetStatusChangeCallback(IntPtr player, GMVideoPlayerStateChangeCallback callback) { }

	// RVA: 0xFFFFFFFF759787E8
	public static extern Void GMVideoPlayerSetTimeUpdateCallback(IntPtr player, GMVideoPlayerTimeUpdateCallback callback) { }

	// RVA: 0xFFFFFFFF75978814
	public static extern Void GMVideoPlayerPlay(IntPtr player) { }

	// RVA: 0xFFFFFFFF75978818
	public static extern Void GMVideoPlayerPause(IntPtr player) { }

	// RVA: 0xFFFFFFFF7597881C
	public static extern Void GMVideoPlayerStop(IntPtr player) { }

	// RVA: 0xFFFFFFFF75978820
	public static extern Void GMVideoPlayerRelease(IntPtr player) { }

	// RVA: 0xFFFFFFFF75978824
	public static extern Void GMVideoPlayerSeekTo(IntPtr player, Double seconds) { }

	// RVA: 0xFFFFFFFF75978828
	public static extern Double GMVideoPlayerGetCurrentTime(IntPtr player) { }

	// RVA: 0xFFFFFFFF7597882C
	public static extern Double GMVideoPlayerGetDuration(IntPtr player) { }

	// RVA: 0xFFFFFFFF75978830
	public static extern IntPtr GMVideoPlayerCreateForTexture(Int32 width, Int32 height) { }

	// RVA: 0xFFFFFFFF75978834
	public static extern IntPtr GMVideoPlayerGetCurrentFrameTexture(IntPtr player) { }

	// RVA: 0xFFFFFFFF75978838
	public static extern IntPtr GMVideoPlayerCreateForView() { }

	// RVA: 0xFFFFFFFF7597883C
	public static extern GMCGRect GMVideoPlayerFloatingFrame(IntPtr player) { }

	// RVA: 0xFFFFFFFF75978840
	public static extern Void GMVideoPlayerSetFloatingFrame(IntPtr player, GMCGRect frame) { }

	// RVA: 0xFFFFFFFF75978844
	public static extern Void GMVideoPlayerSetViewMode(IntPtr player, Int32 viewMode) { }

	// RVA: 0xFFFFFFFF75978848
	public static extern Void GMVideoPlayerShow(IntPtr player) { }

	// RVA: 0xFFFFFFFF7597884C
	public static extern Void GMVideoPlayerClose(IntPtr player) { }

	// RVA: 0xFFFFFFFF75978850
	public static extern Void GMVideoPlayerSetWindowChangeBtnHidden(IntPtr player, Boolean hidden) { }

	// RVA: 0xFFFFFFFF75978854
	public static extern Void GMVideoPlayerSetWindowChangeBtnPosition(IntPtr player, Single x, Single y) { }

	// RVA: 0xFFFFFFFF75978858
	public static extern Void GMVideoPlayerSetBeginDraggingCallback(IntPtr player, GMVideoPlayerBeginDraggingCallback callback) { }

	// RVA: 0xFFFFFFFF75978884
	public static extern Void GMVideoPlayerSetEndDraggingCallback(IntPtr player, GMVideoPlayerEndDraggingCallback callback) { }

	// RVA: 0xFFFFFFFF759788B0
	public static extern Void GMVideoPlayerSetViewModeChangeCallback(IntPtr player, GMVideoPlayerViewModeChangeCallback callback) { }

	// RVA: 0xFFFFFFFF759788DC
	public static extern Void GMVideoPlayerSetCloseCallback(IntPtr player, GMVideoPlayerCloseCallback callback) { }

	// RVA: 0xFFFFFFFF75978908
	public static extern Void GMVideoAVPlayerSetFrameTextureCallback(IntPtr player, GMVideoAVPlayerFrameTextureCallback callback) { }

	// RVA: 0xFFFFFFFF75978934
	public static Void add_OnIOSStateChangeEvent(IOSStateChangeEventHandler value) { }

	// RVA: 0xFFFFFFFF759789E8
	public static Void remove_OnIOSStateChangeEvent(IOSStateChangeEventHandler value) { }

	// RVA: 0xFFFFFFFF75978A9C
	public static Void add_OnIOSTimeUpdateEvent(IOSTimeUpdateEventHandler value) { }

	// RVA: 0xFFFFFFFF75978B54
	public static Void remove_OnIOSTimeUpdateEvent(IOSTimeUpdateEventHandler value) { }

	// RVA: 0xFFFFFFFF75978C0C
	public static Void add_OnIOSFrameTextureEvent(IOSFrameTextureEventHandler value) { }

	// RVA: 0xFFFFFFFF75978CC4
	public static Void remove_OnIOSFrameTextureEvent(IOSFrameTextureEventHandler value) { }

	// RVA: 0xFFFFFFFF75978D7C
	public static Void add_OnIOSBeginDraggingEvent(IOSBeginDraggingEventHandler value) { }

	// RVA: 0xFFFFFFFF75978E34
	public static Void remove_OnIOSBeginDraggingEvent(IOSBeginDraggingEventHandler value) { }

	// RVA: 0xFFFFFFFF75978EEC
	public static Void add_OnIOSEndDraggingEvent(IOSEndDraggingEventHandler value) { }

	// RVA: 0xFFFFFFFF75978FA4
	public static Void remove_OnIOSEndDraggingEvent(IOSEndDraggingEventHandler value) { }

	// RVA: 0xFFFFFFFF7597905C
	public static Void add_OnIOSViewModeChangeEvent(IOSViewModeChangeEventHandler value) { }

	// RVA: 0xFFFFFFFF75979114
	public static Void remove_OnIOSViewModeChangeEvent(IOSViewModeChangeEventHandler value) { }

	// RVA: 0xFFFFFFFF759791CC
	public static Void add_OnIOSCloseEvent(IOSCloseEventHandler value) { }

	// RVA: 0xFFFFFFFF75979284
	public static Void remove_OnIOSCloseEvent(IOSCloseEventHandler value) { }

	// RVA: 0xFFFFFFFF7597839C
	public static Void OnIOSStateChangeCallback(IntPtr player, Int32 state, Int32 errCode, String errMsg) { }

	// RVA: 0xFFFFFFFF7597842C
	public static Void OnIOSTimeUpdateCallback(IntPtr player, Double currentTime, Double duration, Double playableDuration) { }

	// RVA: 0xFFFFFFFF759784BC
	public static Void OnIOSFrameTextureCallback(IntPtr player, IntPtr texture, Double time) { }

	// RVA: 0xFFFFFFFF75978544
	public static Void OnIOSBeginDraggingCallback(IntPtr player) { }

	// RVA: 0xFFFFFFFF759785A4
	public static Void OnIOSEndDraggingCallback(IntPtr player) { }

	// RVA: 0xFFFFFFFF75978604
	public static Void OnIOSViewModeChangeCallback(IntPtr player, Int32 viewMode) { }

	// RVA: 0xFFFFFFFF75978678
	public static Void OnIOSCloseCallback(IntPtr player, Boolean fromUser) { }

	// RVA: 0xFFFFFFFF7597A470
	public Void .ctor() { }

}

// Namespace: 
public sealed class GMVideoPlayerStateChangeCallback
{
	// Methods

	// RVA: 0xFFFFFFFF7597B10C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597B120
	public virtual Void Invoke(IntPtr player, Int32 state, Int32 errCode, String errMsg) { }

	// RVA: 0xFFFFFFFF7597B3B8
	public virtual IAsyncResult BeginInvoke(IntPtr player, Int32 state, Int32 errCode, String errMsg, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597B47C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class GMVideoPlayerTimeUpdateCallback
{
	// Methods

	// RVA: 0xFFFFFFFF7597B488
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597B49C
	public virtual Void Invoke(IntPtr player, Double currentTime, Double duration, Double playableDuration) { }

	// RVA: 0xFFFFFFFF7597B738
	public virtual IAsyncResult BeginInvoke(IntPtr player, Double currentTime, Double duration, Double playableDuration, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597B804
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public struct GMCGRect
{
	// Fields
	public Double x; // 0x10
	public Double y; // 0x18
	public Double width; // 0x20
	public Double height; // 0x28
}

// Namespace: 
public sealed class GMVideoPlayerBeginDraggingCallback
{
	// Methods

	// RVA: 0xFFFFFFFF7597A7D8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597A7EC
	public virtual Void Invoke(IntPtr player) { }

	// RVA: 0xFFFFFFFF7597AA3C
	public virtual IAsyncResult BeginInvoke(IntPtr player, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597AACC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class GMVideoPlayerEndDraggingCallback
{
	// Methods

	// RVA: 0xFFFFFFFF7597AE0C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597AE20
	public virtual Void Invoke(IntPtr player) { }

	// RVA: 0xFFFFFFFF7597B070
	public virtual IAsyncResult BeginInvoke(IntPtr player, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597B100
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class GMVideoPlayerViewModeChangeCallback
{
	// Methods

	// RVA: 0xFFFFFFFF7597B810
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597B824
	public virtual Void Invoke(IntPtr player, Int32 viewMode) { }

	// RVA: 0xFFFFFFFF7597BA90
	public virtual IAsyncResult BeginInvoke(IntPtr player, Int32 viewMode, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597BB38
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class GMVideoPlayerCloseCallback
{
	// Methods

	// RVA: 0xFFFFFFFF7597AAD8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597AAEC
	public virtual Void Invoke(IntPtr player, Boolean fromUser) { }

	// RVA: 0xFFFFFFFF7597AD58
	public virtual IAsyncResult BeginInvoke(IntPtr player, Boolean fromUser, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597AE00
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class GMVideoAVPlayerFrameTextureCallback
{
	// Methods

	// RVA: 0xFFFFFFFF7597A478
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597A48C
	public virtual Void Invoke(IntPtr player, IntPtr texture, Double time) { }

	// RVA: 0xFFFFFFFF7597A714
	public virtual IAsyncResult BeginInvoke(IntPtr player, IntPtr texture, Double time, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597A7CC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class IOSStateChangeEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF7597BE44
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597933C
	public virtual Void Invoke(IntPtr player, Int32 state, Int32 errCode, String errMsg) { }

	// RVA: 0xFFFFFFFF7597BE58
	public virtual IAsyncResult BeginInvoke(IntPtr player, Int32 state, Int32 errCode, String errMsg, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597BF1C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class IOSTimeUpdateEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF7597BF28
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF759795D4
	public virtual Void Invoke(IntPtr player, Double currentTime, Double duration, Double playableDuration) { }

	// RVA: 0xFFFFFFFF7597BF3C
	public virtual IAsyncResult BeginInvoke(IntPtr player, Double currentTime, Double duration, Double playableDuration, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597C008
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class IOSFrameTextureEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF7597BD6C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75979870
	public virtual Void Invoke(IntPtr player, IntPtr texture, Double time) { }

	// RVA: 0xFFFFFFFF7597BD80
	public virtual IAsyncResult BeginInvoke(IntPtr player, IntPtr texture, Double time, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597BE38
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class IOSBeginDraggingEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF7597BB44
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75979AF8
	public virtual Void Invoke(IntPtr player) { }

	// RVA: 0xFFFFFFFF7597BB58
	public virtual IAsyncResult BeginInvoke(IntPtr player, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597BBE8
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class IOSEndDraggingEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF7597BCBC
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75979D48
	public virtual Void Invoke(IntPtr player) { }

	// RVA: 0xFFFFFFFF7597BCD0
	public virtual IAsyncResult BeginInvoke(IntPtr player, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597BD60
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class IOSViewModeChangeEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF7597C014
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75979F98
	public virtual Void Invoke(IntPtr player, Int32 viewMode) { }

	// RVA: 0xFFFFFFFF7597C028
	public virtual IAsyncResult BeginInvoke(IntPtr player, Int32 viewMode, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597C0D0
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class IOSCloseEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF7597BBF4
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597A204
	public virtual Void Invoke(IntPtr player, Boolean fromUser) { }

	// RVA: 0xFFFFFFFF7597BC08
	public virtual IAsyncResult BeginInvoke(IntPtr player, Boolean fromUser, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597BCB0
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class LogReportAOT
{
	// Fields
	private const String DLL_NAME = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF75990164
	public static extern Void MLSDK_LogReport_SetLoggable(Boolean value) { }

	// RVA: 0xFFFFFFFF75990168
	public static extern Void MLSDK_LogReport_SetLogcatEnabled(Boolean value, Int32 level) { }

	// RVA: 0xFFFFFFFF7599016C
	public static extern Void MLSDK_LogReport_SetLogFileEnabled(Boolean value) { }

	// RVA: 0xFFFFFFFF75990170
	public static extern Void MLSDK_LogReport_SetLogcatFileEnabled(Boolean value, Int32 level) { }

	// RVA: 0xFFFFFFFF75990174
	public static extern Void MLSDK_LogReport_SetPersistentDir(Int32 appId, String value) { }

	// RVA: 0xFFFFFFFF759901AC
	public static extern Void MLSDK_LogReport_SetEnvironment(Int32 appId, String jsonStr) { }

	// RVA: 0xFFFFFFFF759901E4
	public static extern Void MLSDK_LogReport_ChangeConfig(Int32 appId, String jsonStr) { }

	// RVA: 0xFFFFFFFF7599021C
	public static extern Boolean MLSDK_LogReport_Init(Int32 appId, String jsonStr) { }

	// RVA: 0xFFFFFFFF75990264
	public static extern Void MLSDK_LogReport_SetUserInfo(Int32 appId, String jsonStr) { }

	// RVA: 0xFFFFFFFF7599029C
	public static extern Boolean MLSDK_LogReport_Send(Int32 appId, String jsonStr) { }

	// RVA: 0xFFFFFFFF759902E4
	public static extern Void MLSDK_LogReport_ResumeSocket(Int32 appId) { }

	// RVA: 0xFFFFFFFF759902E8
	public static extern Void MLSDK_LogReport_CloseSocket(Int32 appId) { }

	// RVA: 0xFFFFFFFF759902EC
	public static extern Void MLSDK_LogReport_ResumeProcess(Int32 appId) { }

	// RVA: 0xFFFFFFFF759902F0
	public static extern Void MLSDK_LogReport_StopProcess(Int32 appId) { }

	// RVA: 0xFFFFFFFF759902F4
	public static extern Void MLSDK_LogReport_Shutdown(Int32 appId) { }

	// RVA: 0xFFFFFFFF759902F8
	public static extern Void MLSDK_LogReport_ShutdownAll() { }

	// RVA: 0xFFFFFFFF759902FC
	public static extern Void MLSDK_LogReport_TestSocketConnectLost(Int32 appId) { }

	// RVA: 0xFFFFFFFF75990300
	public Void .ctor() { }

}

// Namespace: 
public class PermissionHelperLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599AE20
	public static extern Boolean _IOS_IsPermissionGranted(String permission) { }

	// RVA: 0xFFFFFFFF7599AE58
	public Void .ctor() { }

}

// Namespace: 
public class SDKFireBaseLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599CC3C
	public static extern Void _FireBase_Init() { }

	// RVA: 0xFFFFFFFF7599CC40
	public static extern Void _FireBase_Event(String paramsString) { }

	// RVA: 0xFFFFFFFF7599CC68
	public static extern String _FireBase_AppInstanceID() { }

	// RVA: 0xFFFFFFFF7599CC9C
	public static extern Void _FireBase_Event_New(String paramsString) { }

	// RVA: 0xFFFFFFFF7599CCC4
	public Void .ctor() { }

}

// Namespace: 
public class ExtractTask
{
	// Fields
	public String _groupId; // 0x10
	public String _filePath; // 0x18
	public String _outputDir; // 0x20
	public String _fileName; // 0x28
	public Int64 _fileSize; // 0x30
	public DateTime _beginDateTime; // 0x38
	public Int32 _totalTime; // 0x40
	public IntPtr _callback; // 0x48
	public Int64 _totalFileCount; // 0x50
	public Int64 _currentFileCount; // 0x58
	public Int32 _errorCode; // 0x60
	public String _errorMessage; // 0x68

	// Methods

	// RVA: 0xFFFFFFFF75978078
	public Void .ctor(String groupId, String filePath, String outputDir) { }

	// RVA: 0xFFFFFFFF75978238
	public Boolean IsValid() { }

	// RVA: 0xFFFFFFFF7597828C
	public String GetGroupId() { }

	// RVA: 0xFFFFFFFF75978294
	public String GetFilePath() { }

	// RVA: 0xFFFFFFFF7597829C
	public String GetOutputDir() { }

	// RVA: 0xFFFFFFFF759782A4
	public String GetFileName() { }

	// RVA: 0xFFFFFFFF759782AC
	public Int64 GetFileSize() { }

	// RVA: 0xFFFFFFFF759782B4
	public DateTime GetBeginDateTime() { }

	// RVA: 0xFFFFFFFF759782BC
	public Int32 GetTotalTime() { }

	// RVA: 0xFFFFFFFF759782C4
	public Void SetEnd() { }

	// RVA: 0xFFFFFFFF75978344
	public Void SetCallback(IntPtr callback) { }

	// RVA: 0xFFFFFFFF7597834C
	public IntPtr GetCallback() { }

	// RVA: 0xFFFFFFFF75978354
	public Void SetTotalFileCount(Int64 totalFileCount) { }

	// RVA: 0xFFFFFFFF7597835C
	public Int64 GetTotalFileCount() { }

	// RVA: 0xFFFFFFFF75978364
	public Void AddCurrentFileCount() { }

	// RVA: 0xFFFFFFFF75978374
	public Int64 GetCurrentFileCount() { }

	// RVA: 0xFFFFFFFF7597837C
	public Void SetError(Int32 errorCode, String errorMessage) { }

	// RVA: 0xFFFFFFFF7597838C
	public Int32 GetErrorCode() { }

	// RVA: 0xFFFFFFFF75978394
	public String GetErrorMessage() { }

	// RVA: 0xFFFFFFFF75978184
	public Void Init() { }

}

// Namespace: 
public interface IMultiExtractListener
{
	// Methods

	// RVA: -1
	public abstract Void OnStart(ExtractTask task) { }

	// RVA: -1
	public abstract Void OnGetTotalFileCount(ExtractTask task) { }

	// RVA: -1
	public abstract Void OnProgress(ExtractTask task) { }

	// RVA: -1
	public abstract Void OnError(ExtractTask task) { }

	// RVA: -1
	public abstract Void OnSuccess(ExtractTask task) { }

}

// Namespace: 
public class MultiExtractManager
{
	// Fields
	public const String DLL_NAME = "__Internal";
	public static readonly String TAG; // 0x0
	public static Boolean sLogEnabled; // 0x8
	public static Dictionary<T0, T1> _managers; // 0x10
	public static Dictionary<T0, T1> _clearManagers; // 0x18
	public IMultiExtractListener _listener; // 0x10
	public String _groupId; // 0x18
	public Dictionary<T0, T1> _tasks; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF7599604C
	public static Void Clear(MultiExtractManager manager) { }

	// RVA: 0xFFFFFFFF75996514
	public Void .ctor(IMultiExtractListener listener) { }

	// RVA: 0xFFFFFFFF759968CC
	public String GetGroupId() { }

	// RVA: 0xFFFFFFFF759968D4
	public Boolean Extract(ExtractTask task) { }

	// RVA: 0xFFFFFFFF75996AAC
	public Boolean AddTask(ExtractTask task) { }

	// RVA: 0xFFFFFFFF7599734C
	public ExtractTask GetTask(String filePath) { }

	// RVA: 0xFFFFFFFF759977A0
	public ExtractTask RemoveTask(String filePath) { }

	// RVA: 0xFFFFFFFF75997E98
	public Void OnStart(ExtractTask task) { }

	// RVA: 0xFFFFFFFF75998150
	public Void OnGetTotalFileCount(ExtractTask task, Int64 totalFileCount) { }

	// RVA: 0xFFFFFFFF7599845C
	public Void OnProgress(ExtractTask task, String extractFilePath, Int64 extractFileSize) { }

	// RVA: 0xFFFFFFFF75998630
	public Void OnError(ExtractTask task, Int32 errorCode, String errorMessage) { }

	// RVA: 0xFFFFFFFF75998970
	public Void OnSuccess(ExtractTask task) { }

	// RVA: 0xFFFFFFFF759965D0
	public Void Init() { }

	// RVA: 0xFFFFFFFF75998C2C
	public static MultiExtractManager Get(String groupId) { }

	// RVA: 0xFFFFFFFF75998DCC
	public static MultiExtractManager GetClear(String groupId) { }

	// RVA: 0xFFFFFFFF75997054
	public static String MD5(String source) { }

	// RVA: 0xFFFFFFFF75998F6C
	public static Void OnExtract(Object obj) { }

	// RVA: 0xFFFFFFFF75999554
	public static String GetString(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF75994B18
	public static Void MultiExtract_Callback_OnStart(IntPtr groupIdPtr, IntPtr filePathPtr) { }

	// RVA: 0xFFFFFFFF75994EBC
	public static Void MultiExtract_Callback_OnGetTotalFileCount(IntPtr groupIdPtr, IntPtr filePathPtr, Int64 totalFileCount) { }

	// RVA: 0xFFFFFFFF75995270
	public static Void MultiExtract_Callback_OnProgress(IntPtr groupIdPtr, IntPtr filePathPtr, IntPtr extractFilePathPtr, Int64 extractFileSize) { }

	// RVA: 0xFFFFFFFF75995638
	public static Void MultiExtract_Callback_OnError(IntPtr groupIdPtr, IntPtr filePathPtr, Int32 errorCode, IntPtr errorMessagePtr) { }

	// RVA: 0xFFFFFFFF75995B64
	public static Void MultiExtract_Callback_OnSuccess(IntPtr groupIdPtr, IntPtr filePathPtr) { }

	// RVA: 0xFFFFFFFF759993E0
	public static extern IntPtr MultiExtract_CreateCallback(String groupId) { }

	// RVA: 0xFFFFFFFF7599970C
	public static extern Void MultiExtract_DestroyCallback(IntPtr callback) { }

	// RVA: 0xFFFFFFFF75999414
	public static extern Void MultiExtract_SetCallback_OnStart(IntPtr callback, MultiExtract_Callback_String funcPtr) { }

	// RVA: 0xFFFFFFFF75999440
	public static extern Void MultiExtract_SetCallback_OnGetTotalFileCount(IntPtr callback, MultiExtract_Callback_StringLong funcPtr) { }

	// RVA: 0xFFFFFFFF7599946C
	public static extern Void MultiExtract_SetCallback_OnProgress(IntPtr callback, MultiExtract_Callback_StringStringLong funcPtr) { }

	// RVA: 0xFFFFFFFF75999498
	public static extern Void MultiExtract_SetCallback_OnError(IntPtr callback, MultiExtract_Callback_StringIntString funcPtr) { }

	// RVA: 0xFFFFFFFF759994C4
	public static extern Void MultiExtract_SetCallback_OnSuccess(IntPtr callback, MultiExtract_Callback_String funcPtr) { }

	// RVA: 0xFFFFFFFF759994F0
	public static extern Void MultiExtract_ExtractFile(IntPtr callback, String filePath, String outputDir, UInt32 inBufSize) { }

	// RVA: 0xFFFFFFFF75999710
	private static Void .cctor() { }

}

// Namespace: 
public sealed class MultiExtract_Callback_String
{
	// Methods

	// RVA: 0xFFFFFFFF759997F0
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75999804
	public virtual Void Invoke(IntPtr groupIdPtr, IntPtr filePathPtr) { }

	// RVA: 0xFFFFFFFF75999A70
	public virtual IAsyncResult BeginInvoke(IntPtr groupIdPtr, IntPtr filePathPtr, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75999B10
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class MultiExtract_Callback_StringLong
{
	// Methods

	// RVA: 0xFFFFFFFF75999EA0
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75999EB4
	public virtual Void Invoke(IntPtr groupIdPtr, IntPtr filePathPtr, Int64 value) { }

	// RVA: 0xFFFFFFFF7599A134
	public virtual IAsyncResult BeginInvoke(IntPtr groupIdPtr, IntPtr filePathPtr, Int64 value, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7599A1EC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class MultiExtract_Callback_StringStringLong
{
	// Methods

	// RVA: 0xFFFFFFFF7599A1F8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7599A20C
	public virtual Void Invoke(IntPtr groupIdPtr, IntPtr filePathPtr, IntPtr ptr2, Int64 value) { }

	// RVA: 0xFFFFFFFF7599A4A4
	public virtual IAsyncResult BeginInvoke(IntPtr groupIdPtr, IntPtr filePathPtr, IntPtr ptr2, Int64 value, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7599A56C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class MultiExtract_Callback_StringIntString
{
	// Methods

	// RVA: 0xFFFFFFFF75999B1C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75999B30
	public virtual Void Invoke(IntPtr groupIdPtr, IntPtr filePathPtr, Int32 value, IntPtr ptr2) { }

	// RVA: 0xFFFFFFFF75999DC8
	public virtual IAsyncResult BeginInvoke(IntPtr groupIdPtr, IntPtr filePathPtr, Int32 value, IntPtr ptr2, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75999E94
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class IDFAAuthRequestPluginLib
{
	// Methods

	// RVA: 0xFFFFFFFF7598FF04
	public static extern Boolean _IOS_ShowRequestIDFAAuthInfo(String gameObjectName) { }

	// RVA: 0xFFFFFFFF7598FF3C
	public static extern Void _IOS_RequestIDFAAuth(String gameObjectName) { }

	// RVA: 0xFFFFFFFF7598FF64
	public Void .ctor() { }

}

// Namespace: 
public class ThirdpartAchievementLib
{
	// Methods

	// RVA: 0xFFFFFFFF7599E4B4
	public static extern Void _Gamecenter_ShowLeaderboard(String s) { }

	// RVA: 0xFFFFFFFF7599E4DC
	public static extern Void _Gamecenter_ShowAchievements() { }

	// RVA: 0xFFFFFFFF7599E4E0
	public static extern Void _Gamecenter_SubmitScore(String s, Int32 score) { }

	// RVA: 0xFFFFFFFF7599E510
	public static extern Void _Gamecenter_UnlockAchievement(String paramsData) { }

	// RVA: 0xFFFFFFFF7599E538
	public Void .ctor() { }

}

// Namespace: 
public class CommonDownloadMgrLib
{
	// Fields
	public static HttpLibDownloadProgressFunc httpLibDownloadProgress; // 0x0
	public static HttpLibBreakConditionFunc httpLibBreakCondition; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75976F00
	public static Void HttpLibDownloadProgressLib(Void* downloadMgr, Int64 bytes, Int64 allBytes) { }

	// RVA: 0xFFFFFFFF75976F80
	public static Int32 HttpLibBreakConditionLib(Void* downloadMgr) { }

	// RVA: 0xFFFFFFFF75976FE4
	public Void .ctor() { }

}

// Namespace: 
public class DownloadThreadDataLib
{
	// Fields
	public static HttpLibDownloadProgressFunc httpLibDownloadProgress; // 0x0
	public static HttpLibBreakConditionFunc httpLibBreakCondition; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75977B10
	public static Void HttpLibDownloadProgressLib(Void* downloadMgr, Int64 bytes, Int64 allBytes) { }

	// RVA: 0xFFFFFFFF75977B90
	public static Int32 HttpLibBreakConditionLib(Void* downloadMgr) { }

	// RVA: 0xFFFFFFFF75977BF4
	public Void .ctor() { }

}

// Namespace: 
public class GameServerConfigLib
{
	// Methods

	// RVA: 0xFFFFFFFF7597CA88
	public static extern String _IOS_GetASIdentifierManager() { }

	// RVA: 0xFFFFFFFF7597CABC
	public Void .ctor() { }

}

// Namespace: 
public struct HashData
{
	// Fields
	public UInt64 data1; // 0x10
	public UInt64 data2; // 0x18
	public UInt64 data3; // 0x20
	public UInt64 data4; // 0x28
}

// Namespace: 
public class HttpDownloadHelperLib
{
	// Fields
	private const String GAMECORE_DLL_NAME = "__Internal";
	public static LogForCpp debugLog; // 0x0
	public static LogForCpp debugError; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF7598F27C
	public static extern Int32 moba_http_download_file(Void* downloadMgr, String url, String filepath, HttpLibDownloadProgressFunc progressFunc, HttpLibBreakConditionFunc breakConditionFunc, Int32 rangeFrom, Int32 rangeTo) { }

	// RVA: 0xFFFFFFFF7598F328
	public static extern Int32 moba_set_http_download_logfun(LogForCpp log, LogForCpp error) { }

	// RVA: 0xFFFFFFFF7598F35C
	public static extern Int32 moba_split_file(String inputFile, String outFile, Int32 offset, Int32 length) { }

	// RVA: 0xFFFFFFFF7598F3C8
	public static extern Boolean moba_is_file_exist(String inputFile) { }

	// RVA: 0xFFFFFFFF7598F400
	public static extern Boolean moba_rename_file(String oldPath, String newPath) { }

	// RVA: 0xFFFFFFFF7598F460
	public static extern IntPtr moba_get_file_md5(String oldPath) { }

	// RVA: 0xFFFFFFFF7598F494
	public static extern Void moba_free_string_memory(IntPtr mem) { }

	// RVA: 0xFFFFFFFF7598F498
	public static extern Int64 moba_get_file_md5_simple(String inputFile) { }

	// RVA: 0xFFFFFFFF7598F4CC
	public static extern HashData moba_get_file_md5_data(String inputFile) { }

	// RVA: 0xFFFFFFFF7598F4FC
	public static extern Void moba_close_all_http_client() { }

	// RVA: 0xFFFFFFFF7598F1BC
	public static Void DebugLogLib(String str) { }

	// RVA: 0xFFFFFFFF7598F21C
	public static Void DebugErrorLib(String str) { }

	// RVA: 0xFFFFFFFF7598F890
	public Void .ctor() { }

}

// Namespace: 
public sealed class LogForCpp
{
	// Methods

	// RVA: 0xFFFFFFFF7598FE94
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7598F500
	public virtual Void Invoke(String pRet) { }

	// RVA: 0xFFFFFFFF7598FEA8
	public virtual IAsyncResult BeginInvoke(String pRet, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7598FEF8
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class HttpLibDownloadProgressFunc
{
	// Methods

	// RVA: 0xFFFFFFFF7598FB68
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7598FB7C
	public virtual Void Invoke(Void* downloadMgr, Int64 bytes, Int64 allBytes) { }

	// RVA: 0xFFFFFFFF7598FDE4
	public virtual IAsyncResult BeginInvoke(Void* downloadMgr, Int64 bytes, Int64 allBytes, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7598FE88
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class HttpLibBreakConditionFunc
{
	// Methods

	// RVA: 0xFFFFFFFF7598F898
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7598F8AC
	public virtual Int32 Invoke(Void* downloadMgr) { }

	// RVA: 0xFFFFFFFF7598FAEC
	public virtual IAsyncResult BeginInvoke(Void* downloadMgr, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7598FB3C
	public virtual Int32 EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class MonoGCInterfaceLib
{
	// Methods

	// RVA: 0xFFFFFFFF75994A0C
	public static Void GC_set_free_space_divisor(UInt64 v) { }

	// RVA: 0xFFFFFFFF75994A10
	public static UInt64 GC_get_free_space_divisor() { }

	// RVA: 0xFFFFFFFF75994A18
	public Void .ctor() { }

}

// Namespace: 
public class AkAudioInputManagerLib
{
	// Fields
	public static AudioSamplesInteropDelegate audioSamplesDelegate; // 0x0
	public static AudioFormatInteropDelegate audioFormatDelegate; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF759733FC
	public static Boolean ExternAudioSamplesDelegate(UInt32 playingID, Single[] samples, UInt32 channelIndex, UInt32 frames) { }

	// RVA: 0xFFFFFFFF7597348C
	public static Void ExternAudioFormatDelegate(UInt32 playingID, IntPtr format) { }

	// RVA: 0xFFFFFFFF75973A10
	public Void .ctor() { }

}

// Namespace: 
public sealed class AudioSamplesInteropDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75973AE0
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75973500
	public virtual Boolean Invoke(UInt32 playingID, [In] [Out] Single[] samples, UInt32 channelIndex, UInt32 frames) { }

	// RVA: 0xFFFFFFFF75973AF4
	public virtual IAsyncResult BeginInvoke(UInt32 playingID, [In] [Out] Single[] samples, UInt32 channelIndex, UInt32 frames, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75973BB4
	public virtual Boolean EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class AudioFormatInteropDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75973A18
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF759737A0
	public virtual Void Invoke(UInt32 playingID, IntPtr format) { }

	// RVA: 0xFFFFFFFF75973A2C
	public virtual IAsyncResult BeginInvoke(UInt32 playingID, IntPtr format, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75973AD4
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class AkLoggerLib
{
	// Methods

	// RVA: 0xFFFFFFFF759743E0
	public static Void WwiseInternalLogError(String message) { }

	// RVA: 0xFFFFFFFF75974468
	public Void .ctor() { }

}

// Namespace: 
public sealed class ErrorLoggerInteropDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75974470
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75974484
	public virtual Void Invoke(String message) { }

	// RVA: 0xFFFFFFFF75974814
	public virtual IAsyncResult BeginInvoke(String message, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75974864
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class AkSoundEnginePINVOKE
{
	// Methods

	// RVA: -1
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75974870
	public static extern UInt32 CSharp_AK_INVALID_PIPELINE_ID_get() { }

	// RVA: 0xFFFFFFFF75974874
	public static extern UInt64 CSharp_AK_INVALID_AUDIO_OBJECT_ID_get() { }

	// RVA: 0xFFFFFFFF75974878
	public static extern UInt32 CSharp_AK_SOUNDBANK_VERSION_get() { }

	// RVA: 0xFFFFFFFF7597487C
	public static extern Void CSharp_AkAudioSettings_uNumSamplesPerFrame_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974880
	public static extern UInt32 CSharp_AkAudioSettings_uNumSamplesPerFrame_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974884
	public static extern Void CSharp_AkAudioSettings_uNumSamplesPerSecond_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974888
	public static extern UInt32 CSharp_AkAudioSettings_uNumSamplesPerSecond_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597488C
	public static extern IntPtr CSharp_new_AkAudioSettings() { }

	// RVA: 0xFFFFFFFF75974890
	public static extern Void CSharp_delete_AkAudioSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974894
	public static extern Void CSharp_AkDeviceDescription_idDevice_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974898
	public static extern UInt32 CSharp_AkDeviceDescription_idDevice_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597489C
	public static extern Void CSharp_AkDeviceDescription_deviceName_set(IntPtr jarg1, String jarg2) { }

	// RVA: 0xFFFFFFFF759748D4
	public static extern IntPtr CSharp_AkDeviceDescription_deviceName_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759748D8
	public static extern Void CSharp_AkDeviceDescription_deviceStateMask_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF759748DC
	public static extern Int32 CSharp_AkDeviceDescription_deviceStateMask_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759748E0
	public static extern Void CSharp_AkDeviceDescription_isDefaultDevice_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF759748E4
	public static extern Boolean CSharp_AkDeviceDescription_isDefaultDevice_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974900
	public static extern Void CSharp_AkDeviceDescription_Clear(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974904
	public static extern Int32 CSharp_AkDeviceDescription_GetSizeOf() { }

	// RVA: 0xFFFFFFFF75974908
	public static extern Void CSharp_AkDeviceDescription_Clone(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF7597490C
	public static extern IntPtr CSharp_new_AkDeviceDescription() { }

	// RVA: 0xFFFFFFFF75974910
	public static extern Void CSharp_delete_AkDeviceDescription(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974914
	public static extern Vector3 CSharp_AkTransform_Position(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974918
	public static extern Vector3 CSharp_AkTransform_OrientationFront(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597491C
	public static extern Vector3 CSharp_AkTransform_OrientationTop(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974920
	public static extern Void CSharp_AkTransform_Set__SWIG_0(IntPtr jarg1, Vector3 jarg2, Vector3 jarg3, Vector3 jarg4) { }

	// RVA: 0xFFFFFFFF75974934
	public static extern Void CSharp_AkTransform_Set__SWIG_1(IntPtr jarg1, Single jarg2, Single jarg3, Single jarg4, Single jarg5, Single jarg6, Single jarg7, Single jarg8, Single jarg9, Single jarg10) { }

	// RVA: 0xFFFFFFFF75974940
	public static extern Void CSharp_AkTransform_SetPosition__SWIG_0(IntPtr jarg1, Vector3 jarg2) { }

	// RVA: 0xFFFFFFFF75974944
	public static extern Void CSharp_AkTransform_SetPosition__SWIG_1(IntPtr jarg1, Single jarg2, Single jarg3, Single jarg4) { }

	// RVA: 0xFFFFFFFF75974948
	public static extern Void CSharp_AkTransform_SetOrientation__SWIG_0(IntPtr jarg1, Vector3 jarg2, Vector3 jarg3) { }

	// RVA: 0xFFFFFFFF7597494C
	public static extern Void CSharp_AkTransform_SetOrientation__SWIG_1(IntPtr jarg1, Single jarg2, Single jarg3, Single jarg4, Single jarg5, Single jarg6, Single jarg7) { }

	// RVA: 0xFFFFFFFF75974950
	public static extern IntPtr CSharp_new_AkTransform() { }

	// RVA: 0xFFFFFFFF75974954
	public static extern Void CSharp_delete_AkTransform(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974958
	public static extern Void CSharp_AkObstructionOcclusionValues_occlusion_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF7597495C
	public static extern Single CSharp_AkObstructionOcclusionValues_occlusion_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974960
	public static extern Void CSharp_AkObstructionOcclusionValues_obstruction_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75974964
	public static extern Single CSharp_AkObstructionOcclusionValues_obstruction_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974968
	public static extern Void CSharp_AkObstructionOcclusionValues_Clear(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597496C
	public static extern Int32 CSharp_AkObstructionOcclusionValues_GetSizeOf() { }

	// RVA: 0xFFFFFFFF75974970
	public static extern Void CSharp_AkObstructionOcclusionValues_Clone(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974974
	public static extern IntPtr CSharp_new_AkObstructionOcclusionValues() { }

	// RVA: 0xFFFFFFFF75974978
	public static extern Void CSharp_delete_AkObstructionOcclusionValues(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597497C
	public static extern Void CSharp_AkChannelEmitter_position_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974980
	public static extern IntPtr CSharp_AkChannelEmitter_position_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974984
	public static extern Void CSharp_AkChannelEmitter_uInputChannels_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974988
	public static extern UInt32 CSharp_AkChannelEmitter_uInputChannels_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597498C
	public static extern Void CSharp_delete_AkChannelEmitter(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974990
	public static extern Void CSharp_AkAuxSendValue_listenerID_set(IntPtr jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF75974994
	public static extern UInt64 CSharp_AkAuxSendValue_listenerID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974998
	public static extern Void CSharp_AkAuxSendValue_auxBusID_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF7597499C
	public static extern UInt32 CSharp_AkAuxSendValue_auxBusID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759749A0
	public static extern Void CSharp_AkAuxSendValue_fControlValue_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF759749A4
	public static extern Single CSharp_AkAuxSendValue_fControlValue_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759749A8
	public static extern Void CSharp_AkAuxSendValue_Set(IntPtr jarg1, UInt64 jarg2, UInt32 jarg3, Single jarg4) { }

	// RVA: 0xFFFFFFFF759749AC
	public static extern Boolean CSharp_AkAuxSendValue_IsSame(IntPtr jarg1, UInt64 jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF759749C8
	public static extern Int32 CSharp_AkAuxSendValue_GetSizeOf() { }

	// RVA: 0xFFFFFFFF759749CC
	public static extern Void CSharp_delete_AkAuxSendValue(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759749D0
	public static extern IntPtr CSharp_new_AkRamp__SWIG_0() { }

	// RVA: 0xFFFFFFFF759749D4
	public static extern IntPtr CSharp_new_AkRamp__SWIG_1(Single jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF759749D8
	public static extern Void CSharp_AkRamp_fPrev_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF759749DC
	public static extern Single CSharp_AkRamp_fPrev_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759749E0
	public static extern Void CSharp_AkRamp_fNext_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF759749E4
	public static extern Single CSharp_AkRamp_fNext_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759749E8
	public static extern Void CSharp_delete_AkRamp(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759749EC
	public static extern UInt16 CSharp_AK_INT_get() { }

	// RVA: 0xFFFFFFFF759749F0
	public static extern UInt16 CSharp_AK_FLOAT_get() { }

	// RVA: 0xFFFFFFFF759749F4
	public static extern Byte CSharp_AK_INTERLEAVED_get() { }

	// RVA: 0xFFFFFFFF759749F8
	public static extern Byte CSharp_AK_NONINTERLEAVED_get() { }

	// RVA: 0xFFFFFFFF759749FC
	public static extern UInt32 CSharp_AK_LE_NATIVE_BITSPERSAMPLE_get() { }

	// RVA: 0xFFFFFFFF75974A00
	public static extern UInt32 CSharp_AK_LE_NATIVE_SAMPLETYPE_get() { }

	// RVA: 0xFFFFFFFF75974A04
	public static extern UInt32 CSharp_AK_LE_NATIVE_INTERLEAVE_get() { }

	// RVA: 0xFFFFFFFF75974A08
	public static extern Void CSharp_AkAudioFormat_uSampleRate_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974A0C
	public static extern UInt32 CSharp_AkAudioFormat_uSampleRate_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A10
	public static extern Void CSharp_AkAudioFormat_channelConfig_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974A14
	public static extern IntPtr CSharp_AkAudioFormat_channelConfig_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A18
	public static extern Void CSharp_AkAudioFormat_uBitsPerSample_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974A1C
	public static extern UInt32 CSharp_AkAudioFormat_uBitsPerSample_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A20
	public static extern Void CSharp_AkAudioFormat_uBlockAlign_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974A24
	public static extern UInt32 CSharp_AkAudioFormat_uBlockAlign_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A28
	public static extern Void CSharp_AkAudioFormat_uTypeID_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974A2C
	public static extern UInt32 CSharp_AkAudioFormat_uTypeID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A30
	public static extern Void CSharp_AkAudioFormat_uInterleaveID_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974A34
	public static extern UInt32 CSharp_AkAudioFormat_uInterleaveID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A38
	public static extern UInt32 CSharp_AkAudioFormat_GetNumChannels(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A3C
	public static extern UInt32 CSharp_AkAudioFormat_GetBitsPerSample(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A40
	public static extern UInt32 CSharp_AkAudioFormat_GetBlockAlign(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A44
	public static extern UInt32 CSharp_AkAudioFormat_GetTypeID(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A48
	public static extern UInt32 CSharp_AkAudioFormat_GetInterleaveID(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A4C
	public static extern Void CSharp_AkAudioFormat_SetAll(IntPtr jarg1, UInt32 jarg2, IntPtr jarg3, UInt32 jarg4, UInt32 jarg5, UInt32 jarg6, UInt32 jarg7) { }

	// RVA: 0xFFFFFFFF75974A50
	public static extern IntPtr CSharp_new_AkAudioFormat() { }

	// RVA: 0xFFFFFFFF75974A54
	public static extern Void CSharp_delete_AkAudioFormat(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A58
	public static extern IntPtr CSharp_new_Ak3dData() { }

	// RVA: 0xFFFFFFFF75974A5C
	public static extern Void CSharp_Ak3dData_xform_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974A60
	public static extern IntPtr CSharp_Ak3dData_xform_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A64
	public static extern Void CSharp_Ak3dData_spread_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75974A68
	public static extern Single CSharp_Ak3dData_spread_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A6C
	public static extern Void CSharp_Ak3dData_focus_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75974A70
	public static extern Single CSharp_Ak3dData_focus_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A74
	public static extern Void CSharp_Ak3dData_uEmitterChannelMask_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974A78
	public static extern UInt32 CSharp_Ak3dData_uEmitterChannelMask_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A7C
	public static extern Void CSharp_delete_Ak3dData(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A80
	public static extern IntPtr CSharp_new_AkBehavioralPositioningData() { }

	// RVA: 0xFFFFFFFF75974A84
	public static extern Void CSharp_AkBehavioralPositioningData_center_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75974A88
	public static extern Single CSharp_AkBehavioralPositioningData_center_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A8C
	public static extern Void CSharp_AkBehavioralPositioningData_panLR_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75974A90
	public static extern Single CSharp_AkBehavioralPositioningData_panLR_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A94
	public static extern Void CSharp_AkBehavioralPositioningData_panBF_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75974A98
	public static extern Single CSharp_AkBehavioralPositioningData_panBF_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974A9C
	public static extern Void CSharp_AkBehavioralPositioningData_panDU_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75974AA0
	public static extern Single CSharp_AkBehavioralPositioningData_panDU_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974AA4
	public static extern Void CSharp_AkBehavioralPositioningData_panSpatMix_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75974AA8
	public static extern Single CSharp_AkBehavioralPositioningData_panSpatMix_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974AAC
	public static extern Void CSharp_AkBehavioralPositioningData_spatMode_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75974AB0
	public static extern Int32 CSharp_AkBehavioralPositioningData_spatMode_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974AB4
	public static extern Void CSharp_AkBehavioralPositioningData_panType_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75974AB8
	public static extern Int32 CSharp_AkBehavioralPositioningData_panType_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974ABC
	public static extern Void CSharp_AkBehavioralPositioningData_enableHeightSpread_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF75974AC0
	public static extern Boolean CSharp_AkBehavioralPositioningData_enableHeightSpread_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974ADC
	public static extern Void CSharp_delete_AkBehavioralPositioningData(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974AE0
	public static extern Void CSharp_AkPositioningData_threeD_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974AE4
	public static extern IntPtr CSharp_AkPositioningData_threeD_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974AE8
	public static extern Void CSharp_AkPositioningData_behavioral_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974AEC
	public static extern IntPtr CSharp_AkPositioningData_behavioral_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974AF0
	public static extern IntPtr CSharp_new_AkPositioningData() { }

	// RVA: 0xFFFFFFFF75974AF4
	public static extern Void CSharp_delete_AkPositioningData(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974AF8
	public static extern Void CSharp_Ak3DAudioSinkCapabilities_channelConfig_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974AFC
	public static extern IntPtr CSharp_Ak3DAudioSinkCapabilities_channelConfig_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974B00
	public static extern Void CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974B04
	public static extern UInt32 CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974B08
	public static extern Void CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974B0C
	public static extern UInt32 CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974B10
	public static extern Void CSharp_Ak3DAudioSinkCapabilities_bPassthrough_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF75974B14
	public static extern Boolean CSharp_Ak3DAudioSinkCapabilities_bPassthrough_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974B30
	public static extern Void CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF75974B34
	public static extern Boolean CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974B50
	public static extern IntPtr CSharp_new_Ak3DAudioSinkCapabilities() { }

	// RVA: 0xFFFFFFFF75974B54
	public static extern Void CSharp_delete_Ak3DAudioSinkCapabilities(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974B58
	public static extern Void CSharp_AkIterator_pItem_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974B5C
	public static extern IntPtr CSharp_AkIterator_pItem_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974B60
	public static extern IntPtr CSharp_AkIterator_NextIter(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974B64
	public static extern IntPtr CSharp_AkIterator_PrevIter(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974B68
	public static extern IntPtr CSharp_AkIterator_GetItem(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974B6C
	public static extern Boolean CSharp_AkIterator_IsEqualTo(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974B88
	public static extern Boolean CSharp_AkIterator_IsDifferentFrom(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974BA4
	public static extern IntPtr CSharp_new_AkIterator() { }

	// RVA: 0xFFFFFFFF75974BA8
	public static extern Void CSharp_delete_AkIterator(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974BAC
	public static extern IntPtr CSharp_new_AkPlaylistItem__SWIG_0() { }

	// RVA: 0xFFFFFFFF75974BB0
	public static extern IntPtr CSharp_new_AkPlaylistItem__SWIG_1(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974BB4
	public static extern Void CSharp_delete_AkPlaylistItem(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974BB8
	public static extern IntPtr CSharp_AkPlaylistItem_Assign(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974BBC
	public static extern Boolean CSharp_AkPlaylistItem_IsEqualTo(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974BD8
	public static extern Int32 CSharp_AkPlaylistItem_SetExternalSources(IntPtr jarg1, UInt32 jarg2, IntPtr jarg3) { }

	// RVA: 0xFFFFFFFF75974BDC
	public static extern Void CSharp_AkPlaylistItem_audioNodeID_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974BE0
	public static extern UInt32 CSharp_AkPlaylistItem_audioNodeID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974BE4
	public static extern Void CSharp_AkPlaylistItem_msDelay_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75974BE8
	public static extern Int32 CSharp_AkPlaylistItem_msDelay_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974BEC
	public static extern Void CSharp_AkPlaylistItem_pCustomInfo_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974BF0
	public static extern IntPtr CSharp_AkPlaylistItem_pCustomInfo_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974BF4
	public static extern IntPtr CSharp_new_AkPlaylistArray() { }

	// RVA: 0xFFFFFFFF75974BF8
	public static extern Void CSharp_delete_AkPlaylistArray(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974BFC
	public static extern IntPtr CSharp_AkPlaylistArray_Begin(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974C00
	public static extern IntPtr CSharp_AkPlaylistArray_End(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974C04
	public static extern IntPtr CSharp_AkPlaylistArray_FindEx(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974C08
	public static extern IntPtr CSharp_AkPlaylistArray_Erase__SWIG_0(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974C0C
	public static extern Void CSharp_AkPlaylistArray_Erase__SWIG_1(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974C10
	public static extern IntPtr CSharp_AkPlaylistArray_EraseSwap__SWIG_0(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974C14
	public static extern Void CSharp_AkPlaylistArray_EraseSwap__SWIG_1(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974C18
	public static extern Boolean CSharp_AkPlaylistArray_IsGrowingAllowed(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974C34
	public static extern Int32 CSharp_AkPlaylistArray_Reserve(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974C38
	public static extern UInt32 CSharp_AkPlaylistArray_Reserved(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974C3C
	public static extern Void CSharp_AkPlaylistArray_Term(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974C40
	public static extern UInt32 CSharp_AkPlaylistArray_Length(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974C44
	public static extern IntPtr CSharp_AkPlaylistArray_Data(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974C48
	public static extern Boolean CSharp_AkPlaylistArray_IsEmpty(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974C64
	public static extern IntPtr CSharp_AkPlaylistArray_Exists(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974C68
	public static extern IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_0(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974C6C
	public static extern IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_1(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974C70
	public static extern IntPtr CSharp_AkPlaylistArray_Last(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974C74
	public static extern Void CSharp_AkPlaylistArray_RemoveLast(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974C78
	public static extern Int32 CSharp_AkPlaylistArray_Remove(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974C7C
	public static extern Int32 CSharp_AkPlaylistArray_RemoveSwap(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974C80
	public static extern Void CSharp_AkPlaylistArray_RemoveAll(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974C84
	public static extern IntPtr CSharp_AkPlaylistArray_ItemAtIndex(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974C88
	public static extern IntPtr CSharp_AkPlaylistArray_Insert(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974C8C
	public static extern Boolean CSharp_AkPlaylistArray_GrowArray__SWIG_0(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974CA8
	public static extern Boolean CSharp_AkPlaylistArray_GrowArray__SWIG_1(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974CC4
	public static extern Boolean CSharp_AkPlaylistArray_Resize(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974CE0
	public static extern Void CSharp_AkPlaylistArray_Transfer(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974CE4
	public static extern Int32 CSharp_AkPlaylistArray_Copy(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974CE8
	public static extern Int32 CSharp_AkPlaylist_Enqueue__SWIG_0(IntPtr jarg1, UInt32 jarg2, Int32 jarg3, IntPtr jarg4, UInt32 jarg5, IntPtr jarg6) { }

	// RVA: 0xFFFFFFFF75974CEC
	public static extern Int32 CSharp_AkPlaylist_Enqueue__SWIG_1(IntPtr jarg1, UInt32 jarg2, Int32 jarg3, IntPtr jarg4, UInt32 jarg5) { }

	// RVA: 0xFFFFFFFF75974CF0
	public static extern Int32 CSharp_AkPlaylist_Enqueue__SWIG_2(IntPtr jarg1, UInt32 jarg2, Int32 jarg3, IntPtr jarg4) { }

	// RVA: 0xFFFFFFFF75974CF4
	public static extern Int32 CSharp_AkPlaylist_Enqueue__SWIG_3(IntPtr jarg1, UInt32 jarg2, Int32 jarg3) { }

	// RVA: 0xFFFFFFFF75974CF8
	public static extern Int32 CSharp_AkPlaylist_Enqueue__SWIG_4(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974CFC
	public static extern IntPtr CSharp_new_AkPlaylist() { }

	// RVA: 0xFFFFFFFF75974D00
	public static extern Void CSharp_delete_AkPlaylist(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974D04
	public static extern UInt32 CSharp_DynamicSequenceOpen__SWIG_0(UInt64 jarg1, UInt32 jarg2, IntPtr jarg3, IntPtr jarg4, Int32 jarg5) { }

	// RVA: 0xFFFFFFFF75974D08
	public static extern UInt32 CSharp_DynamicSequenceOpen__SWIG_1(UInt64 jarg1, UInt32 jarg2, IntPtr jarg3, IntPtr jarg4) { }

	// RVA: 0xFFFFFFFF75974D0C
	public static extern UInt32 CSharp_DynamicSequenceOpen__SWIG_2(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF75974D10
	public static extern Int32 CSharp_DynamicSequenceClose(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75974D14
	public static extern Int32 CSharp_DynamicSequencePlay__SWIG_0(UInt32 jarg1, Int32 jarg2, Int32 jarg3) { }

	// RVA: 0xFFFFFFFF75974D18
	public static extern Int32 CSharp_DynamicSequencePlay__SWIG_1(UInt32 jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75974D1C
	public static extern Int32 CSharp_DynamicSequencePlay__SWIG_2(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75974D20
	public static extern Int32 CSharp_DynamicSequencePause__SWIG_0(UInt32 jarg1, Int32 jarg2, Int32 jarg3) { }

	// RVA: 0xFFFFFFFF75974D24
	public static extern Int32 CSharp_DynamicSequencePause__SWIG_1(UInt32 jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75974D28
	public static extern Int32 CSharp_DynamicSequencePause__SWIG_2(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75974D2C
	public static extern Int32 CSharp_DynamicSequenceResume__SWIG_0(UInt32 jarg1, Int32 jarg2, Int32 jarg3) { }

	// RVA: 0xFFFFFFFF75974D30
	public static extern Int32 CSharp_DynamicSequenceResume__SWIG_1(UInt32 jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75974D34
	public static extern Int32 CSharp_DynamicSequenceResume__SWIG_2(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75974D38
	public static extern Int32 CSharp_DynamicSequenceStop__SWIG_0(UInt32 jarg1, Int32 jarg2, Int32 jarg3) { }

	// RVA: 0xFFFFFFFF75974D3C
	public static extern Int32 CSharp_DynamicSequenceStop__SWIG_1(UInt32 jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75974D40
	public static extern Int32 CSharp_DynamicSequenceStop__SWIG_2(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75974D44
	public static extern Int32 CSharp_DynamicSequenceBreak(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75974D48
	public static extern Int32 CSharp_Seek__SWIG_0(UInt32 jarg1, Int32 jarg2, Boolean jarg3) { }

	// RVA: 0xFFFFFFFF75974D4C
	public static extern Int32 CSharp_Seek__SWIG_1(UInt32 jarg1, Single jarg2, Boolean jarg3) { }

	// RVA: 0xFFFFFFFF75974D50
	public static extern Int32 CSharp_DynamicSequenceGetPauseTimes(UInt32 jarg1, out UInt32 jarg2, out UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75974D54
	public static extern IntPtr CSharp_DynamicSequenceLockPlaylist(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75974D58
	public static extern Int32 CSharp_DynamicSequenceUnlockPlaylist(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75974D5C
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_0() { }

	// RVA: 0xFFFFFFFF75974D60
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_1(String jarg1, UInt32 jarg2, IntPtr jarg3, Int32 jarg4) { }

	// RVA: 0xFFFFFFFF75974DB4
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_2(String jarg1, UInt32 jarg2, IntPtr jarg3) { }

	// RVA: 0xFFFFFFFF75974E00
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_3(String jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974E3C
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_4(String jarg1) { }

	// RVA: 0xFFFFFFFF75974E70
	public static extern Void CSharp_AkOutputSettings_audioDeviceShareset_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974E74
	public static extern UInt32 CSharp_AkOutputSettings_audioDeviceShareset_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974E78
	public static extern Void CSharp_AkOutputSettings_idDevice_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974E7C
	public static extern UInt32 CSharp_AkOutputSettings_idDevice_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974E80
	public static extern Void CSharp_AkOutputSettings_ePanningRule_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75974E84
	public static extern Int32 CSharp_AkOutputSettings_ePanningRule_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974E88
	public static extern Void CSharp_AkOutputSettings_channelConfig_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974E8C
	public static extern IntPtr CSharp_AkOutputSettings_channelConfig_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974E90
	public static extern Void CSharp_delete_AkOutputSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974E94
	public static extern Void CSharp_AkTaskContext_uIdxThread_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974E98
	public static extern UInt32 CSharp_AkTaskContext_uIdxThread_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974E9C
	public static extern IntPtr CSharp_new_AkTaskContext() { }

	// RVA: 0xFFFFFFFF75974EA0
	public static extern Void CSharp_delete_AkTaskContext(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974EA4
	public static extern Void CSharp_AkInitSettings_uMaxNumPaths_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974EA8
	public static extern UInt32 CSharp_AkInitSettings_uMaxNumPaths_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974EAC
	public static extern Void CSharp_AkInitSettings_uCommandQueueSize_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974EB0
	public static extern UInt32 CSharp_AkInitSettings_uCommandQueueSize_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974EB4
	public static extern Void CSharp_AkInitSettings_bEnableGameSyncPreparation_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF75974EB8
	public static extern Boolean CSharp_AkInitSettings_bEnableGameSyncPreparation_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974ED4
	public static extern Void CSharp_AkInitSettings_uContinuousPlaybackLookAhead_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974ED8
	public static extern UInt32 CSharp_AkInitSettings_uContinuousPlaybackLookAhead_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974EDC
	public static extern Void CSharp_AkInitSettings_uNumSamplesPerFrame_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974EE0
	public static extern UInt32 CSharp_AkInitSettings_uNumSamplesPerFrame_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974EE4
	public static extern Void CSharp_AkInitSettings_uMonitorQueuePoolSize_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974EE8
	public static extern UInt32 CSharp_AkInitSettings_uMonitorQueuePoolSize_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974EEC
	public static extern Void CSharp_AkInitSettings_settingsMainOutput_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974EF0
	public static extern IntPtr CSharp_AkInitSettings_settingsMainOutput_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974EF4
	public static extern Void CSharp_AkInitSettings_uMaxHardwareTimeoutMs_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974EF8
	public static extern UInt32 CSharp_AkInitSettings_uMaxHardwareTimeoutMs_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974EFC
	public static extern Void CSharp_AkInitSettings_bUseSoundBankMgrThread_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF75974F00
	public static extern Boolean CSharp_AkInitSettings_bUseSoundBankMgrThread_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974F1C
	public static extern Void CSharp_AkInitSettings_bUseLEngineThread_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF75974F20
	public static extern Boolean CSharp_AkInitSettings_bUseLEngineThread_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974F3C
	public static extern Void CSharp_AkInitSettings_szPluginDLLPath_set(IntPtr jarg1, String jarg2) { }

	// RVA: 0xFFFFFFFF75974F74
	public static extern IntPtr CSharp_AkInitSettings_szPluginDLLPath_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974F78
	public static extern Void CSharp_AkInitSettings_eFloorPlane_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75974F7C
	public static extern Int32 CSharp_AkInitSettings_eFloorPlane_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974F80
	public static extern Void CSharp_AkInitSettings_fGameUnitsToMeters_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75974F84
	public static extern Single CSharp_AkInitSettings_fGameUnitsToMeters_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974F88
	public static extern Void CSharp_AkInitSettings_uBankReadBufferSize_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974F8C
	public static extern UInt32 CSharp_AkInitSettings_uBankReadBufferSize_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974F90
	public static extern Void CSharp_AkInitSettings_fDebugOutOfRangeLimit_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75974F94
	public static extern Single CSharp_AkInitSettings_fDebugOutOfRangeLimit_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974F98
	public static extern Void CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF75974F9C
	public static extern Boolean CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974FB8
	public static extern Void CSharp_delete_AkInitSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974FBC
	public static extern Void CSharp_AkSourceSettings_sourceID_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974FC0
	public static extern UInt32 CSharp_AkSourceSettings_sourceID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974FC4
	public static extern Void CSharp_AkSourceSettings_pMediaMemory_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974FC8
	public static extern IntPtr CSharp_AkSourceSettings_pMediaMemory_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974FCC
	public static extern Void CSharp_AkSourceSettings_uMediaSize_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75974FD0
	public static extern UInt32 CSharp_AkSourceSettings_uMediaSize_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974FD4
	public static extern Void CSharp_AkSourceSettings_Clear(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974FD8
	public static extern Int32 CSharp_AkSourceSettings_GetSizeOf() { }

	// RVA: 0xFFFFFFFF75974FDC
	public static extern Void CSharp_AkSourceSettings_Clone(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75974FE0
	public static extern IntPtr CSharp_new_AkSourceSettings() { }

	// RVA: 0xFFFFFFFF75974FE4
	public static extern Void CSharp_delete_AkSourceSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75974FE8
	public static extern Boolean CSharp_IsInitialized() { }

	// RVA: 0xFFFFFFFF75975004
	public static extern Int32 CSharp_GetAudioSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975008
	public static extern IntPtr CSharp_GetSpeakerConfiguration__SWIG_0(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF7597500C
	public static extern IntPtr CSharp_GetSpeakerConfiguration__SWIG_1() { }

	// RVA: 0xFFFFFFFF75975010
	public static extern Int32 CSharp_GetOutputDeviceConfiguration(UInt64 jarg1, IntPtr jarg2, IntPtr jarg3) { }

	// RVA: 0xFFFFFFFF75975014
	public static extern Int32 CSharp_GetPanningRule__SWIG_0(out Int32 jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF75975018
	public static extern Int32 CSharp_GetPanningRule__SWIG_1(out Int32 jarg1) { }

	// RVA: 0xFFFFFFFF7597501C
	public static extern Int32 CSharp_SetPanningRule__SWIG_0(Int32 jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF75975020
	public static extern Int32 CSharp_SetPanningRule__SWIG_1(Int32 jarg1) { }

	// RVA: 0xFFFFFFFF75975024
	public static extern Int32 CSharp_GetSpeakerAngles__SWIG_0([In] [Out] Single[] jarg1, ref UInt32 jarg2, out Single jarg3, UInt64 jarg4) { }

	// RVA: 0xFFFFFFFF75975034
	public static extern Int32 CSharp_GetSpeakerAngles__SWIG_1([In] [Out] Single[] jarg1, ref UInt32 jarg2, out Single jarg3) { }

	// RVA: 0xFFFFFFFF75975044
	public static extern Int32 CSharp_SetSpeakerAngles__SWIG_0([In] Single[] jarg1, UInt32 jarg2, Single jarg3, UInt64 jarg4) { }

	// RVA: 0xFFFFFFFF75975054
	public static extern Int32 CSharp_SetSpeakerAngles__SWIG_1([In] Single[] jarg1, UInt32 jarg2, Single jarg3) { }

	// RVA: 0xFFFFFFFF75975064
	public static extern Int32 CSharp_SetVolumeThreshold(Single jarg1) { }

	// RVA: 0xFFFFFFFF75975068
	public static extern Int32 CSharp_SetMaxNumVoicesLimit(UInt16 jarg1) { }

	// RVA: 0xFFFFFFFF7597506C
	public static extern Int32 CSharp_RenderAudio__SWIG_0(Boolean jarg1) { }

	// RVA: 0xFFFFFFFF75975070
	public static extern Int32 CSharp_RenderAudio__SWIG_1() { }

	// RVA: 0xFFFFFFFF75975074
	public static extern Int32 CSharp_RegisterPluginDLL__SWIG_0(String jarg1, String jarg2) { }

	// RVA: 0xFFFFFFFF759750D0
	public static extern Int32 CSharp_RegisterPluginDLL__SWIG_1(String jarg1) { }

	// RVA: 0xFFFFFFFF75975104
	public static extern UInt32 CSharp_GetIDFromString__SWIG_0(String jarg1) { }

	// RVA: 0xFFFFFFFF75975114
	public static extern UInt32 CSharp_PostEvent__SWIG_0(UInt32 jarg1, UInt64 jarg2, UInt32 jarg3, IntPtr jarg4, IntPtr jarg5, UInt32 jarg6, IntPtr jarg7, UInt32 jarg8) { }

	// RVA: 0xFFFFFFFF75975118
	public static extern UInt32 CSharp_PostEvent__SWIG_1(UInt32 jarg1, UInt64 jarg2, UInt32 jarg3, IntPtr jarg4, IntPtr jarg5, UInt32 jarg6, IntPtr jarg7) { }

	// RVA: 0xFFFFFFFF7597511C
	public static extern UInt32 CSharp_PostEvent__SWIG_2(UInt32 jarg1, UInt64 jarg2, UInt32 jarg3, IntPtr jarg4, IntPtr jarg5) { }

	// RVA: 0xFFFFFFFF75975120
	public static extern UInt32 CSharp_PostEvent__SWIG_3(UInt32 jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF75975124
	public static extern UInt32 CSharp_PostEvent__SWIG_4(String jarg1, UInt64 jarg2, UInt32 jarg3, IntPtr jarg4, IntPtr jarg5, UInt32 jarg6, IntPtr jarg7, UInt32 jarg8) { }

	// RVA: 0xFFFFFFFF75975134
	public static extern UInt32 CSharp_PostEvent__SWIG_5(String jarg1, UInt64 jarg2, UInt32 jarg3, IntPtr jarg4, IntPtr jarg5, UInt32 jarg6, IntPtr jarg7) { }

	// RVA: 0xFFFFFFFF75975144
	public static extern UInt32 CSharp_PostEvent__SWIG_6(String jarg1, UInt64 jarg2, UInt32 jarg3, IntPtr jarg4, IntPtr jarg5) { }

	// RVA: 0xFFFFFFFF75975154
	public static extern UInt32 CSharp_PostEvent__SWIG_7(String jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF75975164
	public static extern Int32 CSharp_ExecuteActionOnEvent__SWIG_0(UInt32 jarg1, Int32 jarg2, UInt64 jarg3, Int32 jarg4, Int32 jarg5, UInt32 jarg6) { }

	// RVA: 0xFFFFFFFF75975168
	public static extern Int32 CSharp_ExecuteActionOnEvent__SWIG_1(UInt32 jarg1, Int32 jarg2, UInt64 jarg3, Int32 jarg4, Int32 jarg5) { }

	// RVA: 0xFFFFFFFF7597516C
	public static extern Int32 CSharp_ExecuteActionOnEvent__SWIG_2(UInt32 jarg1, Int32 jarg2, UInt64 jarg3, Int32 jarg4) { }

	// RVA: 0xFFFFFFFF75975170
	public static extern Int32 CSharp_ExecuteActionOnEvent__SWIG_3(UInt32 jarg1, Int32 jarg2, UInt64 jarg3) { }

	// RVA: 0xFFFFFFFF75975174
	public static extern Int32 CSharp_ExecuteActionOnEvent__SWIG_4(UInt32 jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75975178
	public static extern Int32 CSharp_ExecuteActionOnEvent__SWIG_5(String jarg1, Int32 jarg2, UInt64 jarg3, Int32 jarg4, Int32 jarg5, UInt32 jarg6) { }

	// RVA: 0xFFFFFFFF75975188
	public static extern Int32 CSharp_ExecuteActionOnEvent__SWIG_6(String jarg1, Int32 jarg2, UInt64 jarg3, Int32 jarg4, Int32 jarg5) { }

	// RVA: 0xFFFFFFFF75975198
	public static extern Int32 CSharp_ExecuteActionOnEvent__SWIG_7(String jarg1, Int32 jarg2, UInt64 jarg3, Int32 jarg4) { }

	// RVA: 0xFFFFFFFF759751A8
	public static extern Int32 CSharp_ExecuteActionOnEvent__SWIG_8(String jarg1, Int32 jarg2, UInt64 jarg3) { }

	// RVA: 0xFFFFFFFF759751B8
	public static extern Int32 CSharp_ExecuteActionOnEvent__SWIG_9(String jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF759751C8
	public static extern UInt32 CSharp_PostMIDIOnEvent__SWIG_0(UInt32 jarg1, UInt64 jarg2, IntPtr jarg3, UInt16 jarg4, Boolean jarg5, UInt32 jarg6, IntPtr jarg7, IntPtr jarg8, UInt32 jarg9) { }

	// RVA: 0xFFFFFFFF759751D4
	public static extern UInt32 CSharp_PostMIDIOnEvent__SWIG_1(UInt32 jarg1, UInt64 jarg2, IntPtr jarg3, UInt16 jarg4, Boolean jarg5, UInt32 jarg6, IntPtr jarg7, IntPtr jarg8) { }

	// RVA: 0xFFFFFFFF759751D8
	public static extern UInt32 CSharp_PostMIDIOnEvent__SWIG_2(UInt32 jarg1, UInt64 jarg2, IntPtr jarg3, UInt16 jarg4, Boolean jarg5) { }

	// RVA: 0xFFFFFFFF759751DC
	public static extern UInt32 CSharp_PostMIDIOnEvent__SWIG_3(UInt32 jarg1, UInt64 jarg2, IntPtr jarg3, UInt16 jarg4) { }

	// RVA: 0xFFFFFFFF759751E0
	public static extern Int32 CSharp_StopMIDIOnEvent__SWIG_0(UInt32 jarg1, UInt64 jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF759751E4
	public static extern Int32 CSharp_StopMIDIOnEvent__SWIG_1(UInt32 jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF759751E8
	public static extern Int32 CSharp_StopMIDIOnEvent__SWIG_2(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF759751EC
	public static extern Int32 CSharp_StopMIDIOnEvent__SWIG_3() { }

	// RVA: 0xFFFFFFFF759751F0
	public static extern Int32 CSharp_PinEventInStreamCache__SWIG_0(UInt32 jarg1, SByte jarg2, SByte jarg3) { }

	// RVA: 0xFFFFFFFF759751F4
	public static extern Int32 CSharp_PinEventInStreamCache__SWIG_1(String jarg1, SByte jarg2, SByte jarg3) { }

	// RVA: 0xFFFFFFFF75975204
	public static extern Int32 CSharp_UnpinEventInStreamCache__SWIG_0(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975208
	public static extern Int32 CSharp_UnpinEventInStreamCache__SWIG_1(String jarg1) { }

	// RVA: 0xFFFFFFFF75975218
	public static extern Int32 CSharp_GetBufferStatusForPinnedEvent__SWIG_0(UInt32 jarg1, out Single jarg2, out Int32 jarg3) { }

	// RVA: 0xFFFFFFFF7597521C
	public static extern Int32 CSharp_GetBufferStatusForPinnedEvent__SWIG_1(String jarg1, out Single jarg2, out Int32 jarg3) { }

	// RVA: 0xFFFFFFFF75975268
	public static extern Int32 CSharp_SeekOnEvent__SWIG_0(UInt32 jarg1, UInt64 jarg2, Int32 jarg3, Boolean jarg4, UInt32 jarg5) { }

	// RVA: 0xFFFFFFFF7597526C
	public static extern Int32 CSharp_SeekOnEvent__SWIG_1(UInt32 jarg1, UInt64 jarg2, Int32 jarg3, Boolean jarg4) { }

	// RVA: 0xFFFFFFFF75975270
	public static extern Int32 CSharp_SeekOnEvent__SWIG_2(UInt32 jarg1, UInt64 jarg2, Int32 jarg3) { }

	// RVA: 0xFFFFFFFF75975274
	public static extern Int32 CSharp_SeekOnEvent__SWIG_3(String jarg1, UInt64 jarg2, Int32 jarg3, Boolean jarg4, UInt32 jarg5) { }

	// RVA: 0xFFFFFFFF75975284
	public static extern Int32 CSharp_SeekOnEvent__SWIG_4(String jarg1, UInt64 jarg2, Int32 jarg3, Boolean jarg4) { }

	// RVA: 0xFFFFFFFF75975294
	public static extern Int32 CSharp_SeekOnEvent__SWIG_5(String jarg1, UInt64 jarg2, Int32 jarg3) { }

	// RVA: 0xFFFFFFFF759752A4
	public static extern Int32 CSharp_SeekOnEvent__SWIG_9(UInt32 jarg1, UInt64 jarg2, Single jarg3, Boolean jarg4, UInt32 jarg5) { }

	// RVA: 0xFFFFFFFF759752A8
	public static extern Int32 CSharp_SeekOnEvent__SWIG_10(UInt32 jarg1, UInt64 jarg2, Single jarg3, Boolean jarg4) { }

	// RVA: 0xFFFFFFFF759752AC
	public static extern Int32 CSharp_SeekOnEvent__SWIG_11(UInt32 jarg1, UInt64 jarg2, Single jarg3) { }

	// RVA: 0xFFFFFFFF759752B0
	public static extern Int32 CSharp_SeekOnEvent__SWIG_12(String jarg1, UInt64 jarg2, Single jarg3, Boolean jarg4, UInt32 jarg5) { }

	// RVA: 0xFFFFFFFF759752C0
	public static extern Int32 CSharp_SeekOnEvent__SWIG_13(String jarg1, UInt64 jarg2, Single jarg3, Boolean jarg4) { }

	// RVA: 0xFFFFFFFF759752D0
	public static extern Int32 CSharp_SeekOnEvent__SWIG_14(String jarg1, UInt64 jarg2, Single jarg3) { }

	// RVA: 0xFFFFFFFF759752E0
	public static extern Void CSharp_CancelEventCallbackCookie(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759752E4
	public static extern Void CSharp_CancelEventCallbackGameObject(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF759752E8
	public static extern Void CSharp_CancelEventCallback(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF759752EC
	public static extern Int32 CSharp_GetSourcePlayPosition__SWIG_0(UInt32 jarg1, out Int32 jarg2, Boolean jarg3) { }

	// RVA: 0xFFFFFFFF759752F0
	public static extern Int32 CSharp_GetSourcePlayPosition__SWIG_1(UInt32 jarg1, out Int32 jarg2) { }

	// RVA: 0xFFFFFFFF759752F4
	public static extern Int32 CSharp_GetSourceStreamBuffering(UInt32 jarg1, out Int32 jarg2, out Int32 jarg3) { }

	// RVA: 0xFFFFFFFF759752F8
	public static extern Void CSharp_StopAll__SWIG_0(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF759752FC
	public static extern Void CSharp_StopAll__SWIG_1() { }

	// RVA: 0xFFFFFFFF75975300
	public static extern Void CSharp_StopPlayingID__SWIG_0(UInt32 jarg1, Int32 jarg2, Int32 jarg3) { }

	// RVA: 0xFFFFFFFF75975304
	public static extern Void CSharp_StopPlayingID__SWIG_1(UInt32 jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75975308
	public static extern Void CSharp_StopPlayingID__SWIG_2(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF7597530C
	public static extern Void CSharp_ExecuteActionOnPlayingID__SWIG_0(Int32 jarg1, UInt32 jarg2, Int32 jarg3, Int32 jarg4) { }

	// RVA: 0xFFFFFFFF75975310
	public static extern Void CSharp_ExecuteActionOnPlayingID__SWIG_1(Int32 jarg1, UInt32 jarg2, Int32 jarg3) { }

	// RVA: 0xFFFFFFFF75975314
	public static extern Void CSharp_ExecuteActionOnPlayingID__SWIG_2(Int32 jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975318
	public static extern Void CSharp_SetRandomSeed(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF7597531C
	public static extern Void CSharp_MuteBackgroundMusic(Boolean jarg1) { }

	// RVA: 0xFFFFFFFF75975320
	public static extern Boolean CSharp_GetBackgroundMusicMute() { }

	// RVA: 0xFFFFFFFF7597533C
	public static extern Int32 CSharp_SendPluginCustomGameData(UInt32 jarg1, UInt64 jarg2, Int32 jarg3, UInt32 jarg4, UInt32 jarg5, IntPtr jarg6, UInt32 jarg7) { }

	// RVA: 0xFFFFFFFF75975340
	public static extern Int32 CSharp_UnregisterAllGameObj() { }

	// RVA: 0xFFFFFFFF75975344
	public static extern Int32 CSharp_SetMultiplePositions__SWIG_0(UInt64 jarg1, IntPtr jarg2, UInt16 jarg3, Int32 jarg4) { }

	// RVA: 0xFFFFFFFF75975348
	public static extern Int32 CSharp_SetMultiplePositions__SWIG_1(UInt64 jarg1, IntPtr jarg2, UInt16 jarg3) { }

	// RVA: 0xFFFFFFFF7597534C
	public static extern Int32 CSharp_SetMultiplePositions__SWIG_2(UInt64 jarg1, IntPtr jarg2, UInt16 jarg3, Int32 jarg4) { }

	// RVA: 0xFFFFFFFF75975350
	public static extern Int32 CSharp_SetMultiplePositions__SWIG_3(UInt64 jarg1, IntPtr jarg2, UInt16 jarg3) { }

	// RVA: 0xFFFFFFFF75975354
	public static extern Int32 CSharp_SetScalingFactor(UInt64 jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75975358
	public static extern Int32 CSharp_ClearBanks() { }

	// RVA: 0xFFFFFFFF7597535C
	public static extern Int32 CSharp_SetBankLoadIOSettings(Single jarg1, SByte jarg2) { }

	// RVA: 0xFFFFFFFF75975360
	public static extern Int32 CSharp_LoadBank__SWIG_0(String jarg1, out UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975370
	public static extern Int32 CSharp_LoadBank__SWIG_2(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975374
	public static extern Int32 CSharp_LoadBankMemoryView__SWIG_0(IntPtr jarg1, UInt32 jarg2, out UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75975378
	public static extern Int32 CSharp_LoadBankMemoryCopy__SWIG_0(IntPtr jarg1, UInt32 jarg2, out UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF7597537C
	public static extern Int32 CSharp_LoadBank__SWIG_3(String jarg1, IntPtr jarg2, IntPtr jarg3, out UInt32 jarg4) { }

	// RVA: 0xFFFFFFFF7597538C
	public static extern Int32 CSharp_LoadBank__SWIG_5(UInt32 jarg1, IntPtr jarg2, IntPtr jarg3) { }

	// RVA: 0xFFFFFFFF75975390
	public static extern Int32 CSharp_LoadBankMemoryView__SWIG_1(IntPtr jarg1, UInt32 jarg2, IntPtr jarg3, IntPtr jarg4, out UInt32 jarg5) { }

	// RVA: 0xFFFFFFFF75975394
	public static extern Int32 CSharp_LoadBankMemoryCopy__SWIG_1(IntPtr jarg1, UInt32 jarg2, IntPtr jarg3, IntPtr jarg4, out UInt32 jarg5) { }

	// RVA: 0xFFFFFFFF75975398
	public static extern Int32 CSharp_UnloadBank__SWIG_0(String jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF759753A8
	public static extern Int32 CSharp_UnloadBank__SWIG_2(UInt32 jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF759753AC
	public static extern Int32 CSharp_UnloadBank__SWIG_3(String jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4) { }

	// RVA: 0xFFFFFFFF759753BC
	public static extern Int32 CSharp_UnloadBank__SWIG_5(UInt32 jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4) { }

	// RVA: 0xFFFFFFFF759753C0
	public static extern Void CSharp_CancelBankCallbackCookie(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759753C4
	public static extern Int32 CSharp_PrepareBank__SWIG_0(Int32 jarg1, String jarg2, Int32 jarg3) { }

	// RVA: 0xFFFFFFFF759753D4
	public static extern Int32 CSharp_PrepareBank__SWIG_1(Int32 jarg1, String jarg2) { }

	// RVA: 0xFFFFFFFF759753E4
	public static extern Int32 CSharp_PrepareBank__SWIG_4(Int32 jarg1, UInt32 jarg2, Int32 jarg3) { }

	// RVA: 0xFFFFFFFF759753E8
	public static extern Int32 CSharp_PrepareBank__SWIG_5(Int32 jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF759753EC
	public static extern Int32 CSharp_PrepareBank__SWIG_6(Int32 jarg1, String jarg2, IntPtr jarg3, IntPtr jarg4, Int32 jarg5) { }

	// RVA: 0xFFFFFFFF759753FC
	public static extern Int32 CSharp_PrepareBank__SWIG_7(Int32 jarg1, String jarg2, IntPtr jarg3, IntPtr jarg4) { }

	// RVA: 0xFFFFFFFF7597540C
	public static extern Int32 CSharp_PrepareBank__SWIG_10(Int32 jarg1, UInt32 jarg2, IntPtr jarg3, IntPtr jarg4, Int32 jarg5) { }

	// RVA: 0xFFFFFFFF75975410
	public static extern Int32 CSharp_PrepareBank__SWIG_11(Int32 jarg1, UInt32 jarg2, IntPtr jarg3, IntPtr jarg4) { }

	// RVA: 0xFFFFFFFF75975414
	public static extern Int32 CSharp_ClearPreparedEvents() { }

	// RVA: 0xFFFFFFFF75975418
	public static extern Int32 CSharp_PrepareEvent__SWIG_0(Int32 jarg1, IntPtr jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF7597541C
	public static extern Int32 CSharp_PrepareEvent__SWIG_1(Int32 jarg1, [In] UInt32[] jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF7597542C
	public static extern Int32 CSharp_PrepareEvent__SWIG_2(Int32 jarg1, IntPtr jarg2, UInt32 jarg3, IntPtr jarg4, IntPtr jarg5) { }

	// RVA: 0xFFFFFFFF75975430
	public static extern Int32 CSharp_PrepareEvent__SWIG_3(Int32 jarg1, [In] UInt32[] jarg2, UInt32 jarg3, IntPtr jarg4, IntPtr jarg5) { }

	// RVA: 0xFFFFFFFF75975440
	public static extern Int32 CSharp_SetMedia(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975444
	public static extern Int32 CSharp_UnsetMedia(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975448
	public static extern Int32 CSharp_PrepareGameSyncs__SWIG_0(Int32 jarg1, Int32 jarg2, String jarg3, IntPtr jarg4, UInt32 jarg5) { }

	// RVA: 0xFFFFFFFF75975458
	public static extern Int32 CSharp_PrepareGameSyncs__SWIG_1(Int32 jarg1, Int32 jarg2, UInt32 jarg3, [In] UInt32[] jarg4, UInt32 jarg5) { }

	// RVA: 0xFFFFFFFF75975468
	public static extern Int32 CSharp_PrepareGameSyncs__SWIG_2(Int32 jarg1, Int32 jarg2, String jarg3, IntPtr jarg4, UInt32 jarg5, IntPtr jarg6, IntPtr jarg7) { }

	// RVA: 0xFFFFFFFF75975478
	public static extern Int32 CSharp_PrepareGameSyncs__SWIG_3(Int32 jarg1, Int32 jarg2, UInt32 jarg3, [In] UInt32[] jarg4, UInt32 jarg5, IntPtr jarg6, IntPtr jarg7) { }

	// RVA: 0xFFFFFFFF75975488
	public static extern Int32 CSharp_AddListener(UInt64 jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF7597548C
	public static extern Int32 CSharp_RemoveListener(UInt64 jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF75975490
	public static extern Int32 CSharp_AddDefaultListener(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF75975494
	public static extern Int32 CSharp_RemoveDefaultListener(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF75975498
	public static extern Int32 CSharp_ResetListenersToDefault(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF7597549C
	public static extern Int32 CSharp_SetListenerSpatialization__SWIG_0(UInt64 jarg1, Boolean jarg2, IntPtr jarg3, [In] Single[] jarg4) { }

	// RVA: 0xFFFFFFFF759754AC
	public static extern Int32 CSharp_SetListenerSpatialization__SWIG_1(UInt64 jarg1, Boolean jarg2, IntPtr jarg3) { }

	// RVA: 0xFFFFFFFF759754B0
	public static extern Int32 CSharp_SetRTPCValue__SWIG_0(UInt32 jarg1, Single jarg2, UInt64 jarg3, Int32 jarg4, Int32 jarg5, Boolean jarg6) { }

	// RVA: 0xFFFFFFFF759754B4
	public static extern Int32 CSharp_SetRTPCValue__SWIG_1(UInt32 jarg1, Single jarg2, UInt64 jarg3, Int32 jarg4, Int32 jarg5) { }

	// RVA: 0xFFFFFFFF759754B8
	public static extern Int32 CSharp_SetRTPCValue__SWIG_2(UInt32 jarg1, Single jarg2, UInt64 jarg3, Int32 jarg4) { }

	// RVA: 0xFFFFFFFF759754BC
	public static extern Int32 CSharp_SetRTPCValue__SWIG_3(UInt32 jarg1, Single jarg2, UInt64 jarg3) { }

	// RVA: 0xFFFFFFFF759754C0
	public static extern Int32 CSharp_SetRTPCValue__SWIG_4(UInt32 jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF759754C4
	public static extern Int32 CSharp_SetRTPCValue__SWIG_5(String jarg1, Single jarg2, UInt64 jarg3, Int32 jarg4, Int32 jarg5, Boolean jarg6) { }

	// RVA: 0xFFFFFFFF759754D4
	public static extern Int32 CSharp_SetRTPCValue__SWIG_6(String jarg1, Single jarg2, UInt64 jarg3, Int32 jarg4, Int32 jarg5) { }

	// RVA: 0xFFFFFFFF759754E4
	public static extern Int32 CSharp_SetRTPCValue__SWIG_7(String jarg1, Single jarg2, UInt64 jarg3, Int32 jarg4) { }

	// RVA: 0xFFFFFFFF759754F4
	public static extern Int32 CSharp_SetRTPCValue__SWIG_8(String jarg1, Single jarg2, UInt64 jarg3) { }

	// RVA: 0xFFFFFFFF75975504
	public static extern Int32 CSharp_SetRTPCValue__SWIG_9(String jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75975514
	public static extern Int32 CSharp_SetRTPCValueByPlayingID__SWIG_0(UInt32 jarg1, Single jarg2, UInt32 jarg3, Int32 jarg4, Int32 jarg5, Boolean jarg6) { }

	// RVA: 0xFFFFFFFF75975518
	public static extern Int32 CSharp_SetRTPCValueByPlayingID__SWIG_1(UInt32 jarg1, Single jarg2, UInt32 jarg3, Int32 jarg4, Int32 jarg5) { }

	// RVA: 0xFFFFFFFF7597551C
	public static extern Int32 CSharp_SetRTPCValueByPlayingID__SWIG_2(UInt32 jarg1, Single jarg2, UInt32 jarg3, Int32 jarg4) { }

	// RVA: 0xFFFFFFFF75975520
	public static extern Int32 CSharp_SetRTPCValueByPlayingID__SWIG_3(UInt32 jarg1, Single jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75975524
	public static extern Int32 CSharp_SetRTPCValueByPlayingID__SWIG_4(String jarg1, Single jarg2, UInt32 jarg3, Int32 jarg4, Int32 jarg5, Boolean jarg6) { }

	// RVA: 0xFFFFFFFF75975534
	public static extern Int32 CSharp_SetRTPCValueByPlayingID__SWIG_5(String jarg1, Single jarg2, UInt32 jarg3, Int32 jarg4, Int32 jarg5) { }

	// RVA: 0xFFFFFFFF75975544
	public static extern Int32 CSharp_SetRTPCValueByPlayingID__SWIG_6(String jarg1, Single jarg2, UInt32 jarg3, Int32 jarg4) { }

	// RVA: 0xFFFFFFFF75975554
	public static extern Int32 CSharp_SetRTPCValueByPlayingID__SWIG_7(String jarg1, Single jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75975564
	public static extern Int32 CSharp_ResetRTPCValue__SWIG_0(UInt32 jarg1, UInt64 jarg2, Int32 jarg3, Int32 jarg4, Boolean jarg5) { }

	// RVA: 0xFFFFFFFF75975568
	public static extern Int32 CSharp_ResetRTPCValue__SWIG_1(UInt32 jarg1, UInt64 jarg2, Int32 jarg3, Int32 jarg4) { }

	// RVA: 0xFFFFFFFF7597556C
	public static extern Int32 CSharp_ResetRTPCValue__SWIG_2(UInt32 jarg1, UInt64 jarg2, Int32 jarg3) { }

	// RVA: 0xFFFFFFFF75975570
	public static extern Int32 CSharp_ResetRTPCValue__SWIG_3(UInt32 jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF75975574
	public static extern Int32 CSharp_ResetRTPCValue__SWIG_4(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975578
	public static extern Int32 CSharp_ResetRTPCValue__SWIG_5(String jarg1, UInt64 jarg2, Int32 jarg3, Int32 jarg4, Boolean jarg5) { }

	// RVA: 0xFFFFFFFF75975588
	public static extern Int32 CSharp_ResetRTPCValue__SWIG_6(String jarg1, UInt64 jarg2, Int32 jarg3, Int32 jarg4) { }

	// RVA: 0xFFFFFFFF75975598
	public static extern Int32 CSharp_ResetRTPCValue__SWIG_7(String jarg1, UInt64 jarg2, Int32 jarg3) { }

	// RVA: 0xFFFFFFFF759755A8
	public static extern Int32 CSharp_ResetRTPCValue__SWIG_8(String jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF759755B8
	public static extern Int32 CSharp_ResetRTPCValue__SWIG_9(String jarg1) { }

	// RVA: 0xFFFFFFFF759755C8
	public static extern Int32 CSharp_SetSwitch__SWIG_0(UInt32 jarg1, UInt32 jarg2, UInt64 jarg3) { }

	// RVA: 0xFFFFFFFF759755CC
	public static extern Int32 CSharp_SetSwitch__SWIG_1(String jarg1, String jarg2, UInt64 jarg3) { }

	// RVA: 0xFFFFFFFF759755E8
	public static extern Int32 CSharp_PostTrigger__SWIG_0(UInt32 jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF759755EC
	public static extern Int32 CSharp_PostTrigger__SWIG_1(String jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF759755FC
	public static extern Int32 CSharp_SetState__SWIG_0(UInt32 jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975600
	public static extern Int32 CSharp_SetState__SWIG_1(String jarg1, String jarg2) { }

	// RVA: 0xFFFFFFFF7597561C
	public static extern Int32 CSharp_SetGameObjectAuxSendValues(UInt64 jarg1, IntPtr jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75975620
	public static extern Int32 CSharp_SetGameObjectOutputBusVolume(UInt64 jarg1, UInt64 jarg2, Single jarg3) { }

	// RVA: 0xFFFFFFFF75975624
	public static extern Int32 CSharp_SetActorMixerEffect(UInt32 jarg1, UInt32 jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75975628
	public static extern Int32 CSharp_SetBusEffect__SWIG_0(UInt32 jarg1, UInt32 jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF7597562C
	public static extern Int32 CSharp_SetBusEffect__SWIG_1(String jarg1, UInt32 jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF7597563C
	public static extern Int32 CSharp_SetOutputDeviceEffect(UInt64 jarg1, UInt32 jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75975640
	public static extern Int32 CSharp_SetMixer__SWIG_0(UInt32 jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975644
	public static extern Int32 CSharp_SetMixer__SWIG_1(String jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975654
	public static extern Int32 CSharp_SetBusConfig__SWIG_0(UInt32 jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75975658
	public static extern Int32 CSharp_SetBusConfig__SWIG_1(String jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75975668
	public static extern Int32 CSharp_SetObjectObstructionAndOcclusion(UInt64 jarg1, UInt64 jarg2, Single jarg3, Single jarg4) { }

	// RVA: 0xFFFFFFFF7597566C
	public static extern Int32 CSharp_SetMultipleObstructionAndOcclusion(UInt64 jarg1, UInt64 jarg2, IntPtr jarg3, UInt32 jarg4) { }

	// RVA: 0xFFFFFFFF75975670
	public static extern Int32 CSharp_StartOutputCapture(String jarg1) { }

	// RVA: 0xFFFFFFFF759756A4
	public static extern Int32 CSharp_StopOutputCapture() { }

	// RVA: 0xFFFFFFFF759756A8
	public static extern Int32 CSharp_AddOutputCaptureMarker(String jarg1) { }

	// RVA: 0xFFFFFFFF759756DC
	public static extern UInt32 CSharp_GetSampleRate() { }

	// RVA: 0xFFFFFFFF759756E0
	public static extern Int32 CSharp_StartProfilerCapture(String jarg1) { }

	// RVA: 0xFFFFFFFF75975714
	public static extern Int32 CSharp_StopProfilerCapture() { }

	// RVA: 0xFFFFFFFF75975718
	public static extern Int32 CSharp_SetOfflineRenderingFrameTime(Single jarg1) { }

	// RVA: 0xFFFFFFFF7597571C
	public static extern Int32 CSharp_SetOfflineRendering(Boolean jarg1) { }

	// RVA: 0xFFFFFFFF75975720
	public static extern Int32 CSharp_RemoveOutput(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF75975724
	public static extern Int32 CSharp_ReplaceOutput__SWIG_0(IntPtr jarg1, UInt64 jarg2, out UInt64 jarg3) { }

	// RVA: 0xFFFFFFFF75975728
	public static extern Int32 CSharp_ReplaceOutput__SWIG_1(IntPtr jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF7597572C
	public static extern UInt64 CSharp_GetOutputID__SWIG_0(UInt32 jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975730
	public static extern UInt64 CSharp_GetOutputID__SWIG_1(String jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF7597576C
	public static extern Int32 CSharp_SetBusDevice__SWIG_0(UInt32 jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975770
	public static extern Int32 CSharp_SetBusDevice__SWIG_1(String jarg1, String jarg2) { }

	// RVA: 0xFFFFFFFF759757CC
	public static extern Int32 CSharp_GetDeviceList__SWIG_0(UInt32 jarg1, UInt32 jarg2, out UInt32 jarg3, IntPtr jarg4) { }

	// RVA: 0xFFFFFFFF759757D0
	public static extern Int32 CSharp_GetDeviceList__SWIG_1(UInt32 jarg1, out UInt32 jarg2, IntPtr jarg3) { }

	// RVA: 0xFFFFFFFF759757D4
	public static extern Int32 CSharp_SetOutputVolume(UInt64 jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF759757D8
	public static extern Int32 CSharp_GetDeviceSpatialAudioSupport(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF759757DC
	public static extern Int32 CSharp_Suspend__SWIG_0(Boolean jarg1) { }

	// RVA: 0xFFFFFFFF759757E0
	public static extern Int32 CSharp_Suspend__SWIG_1() { }

	// RVA: 0xFFFFFFFF759757E4
	public static extern Int32 CSharp_WakeupFromSuspend() { }

	// RVA: 0xFFFFFFFF759757E8
	public static extern UInt32 CSharp_GetBufferTick() { }

	// RVA: 0xFFFFFFFF759757EC
	public static extern UInt64 CSharp_GetSampleTick() { }

	// RVA: 0xFFFFFFFF759757F0
	public static extern Void CSharp_AkSegmentInfo_iCurrentPosition_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF759757F4
	public static extern Int32 CSharp_AkSegmentInfo_iCurrentPosition_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759757F8
	public static extern Void CSharp_AkSegmentInfo_iPreEntryDuration_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF759757FC
	public static extern Int32 CSharp_AkSegmentInfo_iPreEntryDuration_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975800
	public static extern Void CSharp_AkSegmentInfo_iActiveDuration_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75975804
	public static extern Int32 CSharp_AkSegmentInfo_iActiveDuration_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975808
	public static extern Void CSharp_AkSegmentInfo_iPostExitDuration_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF7597580C
	public static extern Int32 CSharp_AkSegmentInfo_iPostExitDuration_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975810
	public static extern Void CSharp_AkSegmentInfo_iRemainingLookAheadTime_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75975814
	public static extern Int32 CSharp_AkSegmentInfo_iRemainingLookAheadTime_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975818
	public static extern Void CSharp_AkSegmentInfo_fBeatDuration_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF7597581C
	public static extern Single CSharp_AkSegmentInfo_fBeatDuration_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975820
	public static extern Void CSharp_AkSegmentInfo_fBarDuration_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75975824
	public static extern Single CSharp_AkSegmentInfo_fBarDuration_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975828
	public static extern Void CSharp_AkSegmentInfo_fGridDuration_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF7597582C
	public static extern Single CSharp_AkSegmentInfo_fGridDuration_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975830
	public static extern Void CSharp_AkSegmentInfo_fGridOffset_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75975834
	public static extern Single CSharp_AkSegmentInfo_fGridOffset_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975838
	public static extern IntPtr CSharp_new_AkSegmentInfo() { }

	// RVA: 0xFFFFFFFF7597583C
	public static extern Void CSharp_delete_AkSegmentInfo(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975840
	public static extern Void CSharp_AkResourceMonitorDataSummary_totalCPU_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75975844
	public static extern Single CSharp_AkResourceMonitorDataSummary_totalCPU_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975848
	public static extern Void CSharp_AkResourceMonitorDataSummary_pluginCPU_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF7597584C
	public static extern Single CSharp_AkResourceMonitorDataSummary_pluginCPU_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975850
	public static extern Void CSharp_AkResourceMonitorDataSummary_physicalVoices_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975854
	public static extern UInt32 CSharp_AkResourceMonitorDataSummary_physicalVoices_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975858
	public static extern Void CSharp_AkResourceMonitorDataSummary_virtualVoices_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF7597585C
	public static extern UInt32 CSharp_AkResourceMonitorDataSummary_virtualVoices_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975860
	public static extern Void CSharp_AkResourceMonitorDataSummary_totalVoices_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975864
	public static extern UInt32 CSharp_AkResourceMonitorDataSummary_totalVoices_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975868
	public static extern Void CSharp_AkResourceMonitorDataSummary_nbActiveEvents_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF7597586C
	public static extern UInt32 CSharp_AkResourceMonitorDataSummary_nbActiveEvents_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975870
	public static extern IntPtr CSharp_new_AkResourceMonitorDataSummary() { }

	// RVA: 0xFFFFFFFF75975874
	public static extern Void CSharp_delete_AkResourceMonitorDataSummary(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975878
	public static extern Byte CSharp_AK_INVALID_MIDI_CHANNEL_get() { }

	// RVA: 0xFFFFFFFF7597587C
	public static extern Byte CSharp_AK_INVALID_MIDI_NOTE_get() { }

	// RVA: 0xFFFFFFFF75975880
	public static extern Void CSharp_AkMIDIEvent_byChan_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF75975884
	public static extern Byte CSharp_AkMIDIEvent_byChan_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975888
	public static extern Void CSharp_AkMIDIEvent_tGen_byParam1_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF7597588C
	public static extern Byte CSharp_AkMIDIEvent_tGen_byParam1_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975890
	public static extern Void CSharp_AkMIDIEvent_tGen_byParam2_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF75975894
	public static extern Byte CSharp_AkMIDIEvent_tGen_byParam2_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975898
	public static extern IntPtr CSharp_new_AkMIDIEvent_tGen() { }

	// RVA: 0xFFFFFFFF7597589C
	public static extern Void CSharp_delete_AkMIDIEvent_tGen(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759758A0
	public static extern Void CSharp_AkMIDIEvent_tNoteOnOff_byNote_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF759758A4
	public static extern Byte CSharp_AkMIDIEvent_tNoteOnOff_byNote_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759758A8
	public static extern Void CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF759758AC
	public static extern Byte CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759758B0
	public static extern IntPtr CSharp_new_AkMIDIEvent_tNoteOnOff() { }

	// RVA: 0xFFFFFFFF759758B4
	public static extern Void CSharp_delete_AkMIDIEvent_tNoteOnOff(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759758B8
	public static extern Void CSharp_AkMIDIEvent_tCc_byCc_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF759758BC
	public static extern Byte CSharp_AkMIDIEvent_tCc_byCc_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759758C0
	public static extern Void CSharp_AkMIDIEvent_tCc_byValue_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF759758C4
	public static extern Byte CSharp_AkMIDIEvent_tCc_byValue_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759758C8
	public static extern IntPtr CSharp_new_AkMIDIEvent_tCc() { }

	// RVA: 0xFFFFFFFF759758CC
	public static extern Void CSharp_delete_AkMIDIEvent_tCc(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759758D0
	public static extern Void CSharp_AkMIDIEvent_tPitchBend_byValueLsb_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF759758D4
	public static extern Byte CSharp_AkMIDIEvent_tPitchBend_byValueLsb_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759758D8
	public static extern Void CSharp_AkMIDIEvent_tPitchBend_byValueMsb_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF759758DC
	public static extern Byte CSharp_AkMIDIEvent_tPitchBend_byValueMsb_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759758E0
	public static extern IntPtr CSharp_new_AkMIDIEvent_tPitchBend() { }

	// RVA: 0xFFFFFFFF759758E4
	public static extern Void CSharp_delete_AkMIDIEvent_tPitchBend(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759758E8
	public static extern Void CSharp_AkMIDIEvent_tNoteAftertouch_byNote_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF759758EC
	public static extern Byte CSharp_AkMIDIEvent_tNoteAftertouch_byNote_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759758F0
	public static extern Void CSharp_AkMIDIEvent_tNoteAftertouch_byValue_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF759758F4
	public static extern Byte CSharp_AkMIDIEvent_tNoteAftertouch_byValue_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759758F8
	public static extern IntPtr CSharp_new_AkMIDIEvent_tNoteAftertouch() { }

	// RVA: 0xFFFFFFFF759758FC
	public static extern Void CSharp_delete_AkMIDIEvent_tNoteAftertouch(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975900
	public static extern Void CSharp_AkMIDIEvent_tChanAftertouch_byValue_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF75975904
	public static extern Byte CSharp_AkMIDIEvent_tChanAftertouch_byValue_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975908
	public static extern IntPtr CSharp_new_AkMIDIEvent_tChanAftertouch() { }

	// RVA: 0xFFFFFFFF7597590C
	public static extern Void CSharp_delete_AkMIDIEvent_tChanAftertouch(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975910
	public static extern Void CSharp_AkMIDIEvent_tProgramChange_byProgramNum_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF75975914
	public static extern Byte CSharp_AkMIDIEvent_tProgramChange_byProgramNum_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975918
	public static extern IntPtr CSharp_new_AkMIDIEvent_tProgramChange() { }

	// RVA: 0xFFFFFFFF7597591C
	public static extern Void CSharp_delete_AkMIDIEvent_tProgramChange(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975920
	public static extern Void CSharp_AkMIDIEvent_tWwiseCmd_uCmd_set(IntPtr jarg1, UInt16 jarg2) { }

	// RVA: 0xFFFFFFFF75975924
	public static extern UInt16 CSharp_AkMIDIEvent_tWwiseCmd_uCmd_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975928
	public static extern Void CSharp_AkMIDIEvent_tWwiseCmd_uArg_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF7597592C
	public static extern UInt32 CSharp_AkMIDIEvent_tWwiseCmd_uArg_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975930
	public static extern IntPtr CSharp_new_AkMIDIEvent_tWwiseCmd() { }

	// RVA: 0xFFFFFFFF75975934
	public static extern Void CSharp_delete_AkMIDIEvent_tWwiseCmd(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975938
	public static extern Void CSharp_AkMIDIEvent_Gen_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF7597593C
	public static extern IntPtr CSharp_AkMIDIEvent_Gen_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975940
	public static extern Void CSharp_AkMIDIEvent_Cc_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75975944
	public static extern IntPtr CSharp_AkMIDIEvent_Cc_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975948
	public static extern Void CSharp_AkMIDIEvent_NoteOnOff_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF7597594C
	public static extern IntPtr CSharp_AkMIDIEvent_NoteOnOff_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975950
	public static extern Void CSharp_AkMIDIEvent_PitchBend_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75975954
	public static extern IntPtr CSharp_AkMIDIEvent_PitchBend_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975958
	public static extern Void CSharp_AkMIDIEvent_NoteAftertouch_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF7597595C
	public static extern IntPtr CSharp_AkMIDIEvent_NoteAftertouch_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975960
	public static extern Void CSharp_AkMIDIEvent_ChanAftertouch_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75975964
	public static extern IntPtr CSharp_AkMIDIEvent_ChanAftertouch_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975968
	public static extern Void CSharp_AkMIDIEvent_ProgramChange_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF7597596C
	public static extern IntPtr CSharp_AkMIDIEvent_ProgramChange_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975970
	public static extern Void CSharp_AkMIDIEvent_WwiseCmd_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75975974
	public static extern IntPtr CSharp_AkMIDIEvent_WwiseCmd_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975978
	public static extern Void CSharp_AkMIDIEvent_byType_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF7597597C
	public static extern Int32 CSharp_AkMIDIEvent_byType_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975980
	public static extern Void CSharp_AkMIDIEvent_byOnOffNote_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF75975984
	public static extern Byte CSharp_AkMIDIEvent_byOnOffNote_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975988
	public static extern Void CSharp_AkMIDIEvent_byVelocity_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF7597598C
	public static extern Byte CSharp_AkMIDIEvent_byVelocity_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975990
	public static extern Void CSharp_AkMIDIEvent_byCc_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75975994
	public static extern Int32 CSharp_AkMIDIEvent_byCc_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975998
	public static extern Void CSharp_AkMIDIEvent_byCcValue_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF7597599C
	public static extern Byte CSharp_AkMIDIEvent_byCcValue_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759759A0
	public static extern Void CSharp_AkMIDIEvent_byValueLsb_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF759759A4
	public static extern Byte CSharp_AkMIDIEvent_byValueLsb_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759759A8
	public static extern Void CSharp_AkMIDIEvent_byValueMsb_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF759759AC
	public static extern Byte CSharp_AkMIDIEvent_byValueMsb_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759759B0
	public static extern Void CSharp_AkMIDIEvent_byAftertouchNote_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF759759B4
	public static extern Byte CSharp_AkMIDIEvent_byAftertouchNote_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759759B8
	public static extern Void CSharp_AkMIDIEvent_byNoteAftertouchValue_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF759759BC
	public static extern Byte CSharp_AkMIDIEvent_byNoteAftertouchValue_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759759C0
	public static extern Void CSharp_AkMIDIEvent_byChanAftertouchValue_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF759759C4
	public static extern Byte CSharp_AkMIDIEvent_byChanAftertouchValue_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759759C8
	public static extern Void CSharp_AkMIDIEvent_byProgramNum_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF759759CC
	public static extern Byte CSharp_AkMIDIEvent_byProgramNum_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759759D0
	public static extern Void CSharp_AkMIDIEvent_uCmd_set(IntPtr jarg1, UInt16 jarg2) { }

	// RVA: 0xFFFFFFFF759759D4
	public static extern UInt16 CSharp_AkMIDIEvent_uCmd_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759759D8
	public static extern Void CSharp_AkMIDIEvent_uArg_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF759759DC
	public static extern UInt32 CSharp_AkMIDIEvent_uArg_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759759E0
	public static extern IntPtr CSharp_new_AkMIDIEvent() { }

	// RVA: 0xFFFFFFFF759759E4
	public static extern Void CSharp_delete_AkMIDIEvent(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759759E8
	public static extern Void CSharp_AkMIDIPost_uOffset_set(IntPtr jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF759759EC
	public static extern UInt64 CSharp_AkMIDIPost_uOffset_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759759F0
	public static extern UInt32 CSharp_AkMIDIPost_PostOnEvent__SWIG_0(IntPtr jarg1, UInt32 jarg2, UInt64 jarg3, UInt32 jarg4) { }

	// RVA: 0xFFFFFFFF759759F4
	public static extern UInt32 CSharp_AkMIDIPost_PostOnEvent__SWIG_1(IntPtr jarg1, UInt32 jarg2, UInt64 jarg3, UInt32 jarg4, Boolean jarg5) { }

	// RVA: 0xFFFFFFFF759759F8
	public static extern UInt32 CSharp_AkMIDIPost_PostOnEvent__SWIG_2(IntPtr jarg1, UInt32 jarg2, UInt64 jarg3, UInt32 jarg4, Boolean jarg5, UInt32 jarg6, IntPtr jarg7, IntPtr jarg8) { }

	// RVA: 0xFFFFFFFF759759FC
	public static extern UInt32 CSharp_AkMIDIPost_PostOnEvent__SWIG_3(IntPtr jarg1, UInt32 jarg2, UInt64 jarg3, UInt32 jarg4, Boolean jarg5, UInt32 jarg6, IntPtr jarg7, IntPtr jarg8, UInt32 jarg9) { }

	// RVA: 0xFFFFFFFF75975A08
	public static extern Void CSharp_AkMIDIPost_Clone(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75975A0C
	public static extern Int32 CSharp_AkMIDIPost_GetSizeOf() { }

	// RVA: 0xFFFFFFFF75975A10
	public static extern IntPtr CSharp_new_AkMIDIPost() { }

	// RVA: 0xFFFFFFFF75975A14
	public static extern Void CSharp_delete_AkMIDIPost(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A18
	public static extern Void CSharp_AkMusicSettings_fStreamingLookAheadRatio_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75975A1C
	public static extern Single CSharp_AkMusicSettings_fStreamingLookAheadRatio_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A20
	public static extern Void CSharp_delete_AkMusicSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A24
	public static extern Int32 CSharp_GetPlayingSegmentInfo__SWIG_0(UInt32 jarg1, IntPtr jarg2, Boolean jarg3) { }

	// RVA: 0xFFFFFFFF75975A28
	public static extern Int32 CSharp_GetPlayingSegmentInfo__SWIG_1(UInt32 jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75975A2C
	public static extern IntPtr CSharp_AkSerializedCallbackHeader_pPackage_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A30
	public static extern UInt32 CSharp_AkSerializedCallbackHeader_eType_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A34
	public static extern IntPtr CSharp_AkSerializedCallbackHeader_GetData(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A38
	public static extern IntPtr CSharp_AkSerializedCallbackHeader_pNext_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A3C
	public static extern IntPtr CSharp_new_AkSerializedCallbackHeader() { }

	// RVA: 0xFFFFFFFF75975A40
	public static extern Void CSharp_delete_AkSerializedCallbackHeader(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A44
	public static extern IntPtr CSharp_AkCallbackInfo_pCookie_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A48
	public static extern UInt64 CSharp_AkCallbackInfo_gameObjID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A4C
	public static extern IntPtr CSharp_new_AkCallbackInfo() { }

	// RVA: 0xFFFFFFFF75975A50
	public static extern Void CSharp_delete_AkCallbackInfo(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A54
	public static extern UInt32 CSharp_AkEventCallbackInfo_playingID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A58
	public static extern UInt32 CSharp_AkEventCallbackInfo_eventID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A5C
	public static extern IntPtr CSharp_new_AkEventCallbackInfo() { }

	// RVA: 0xFFFFFFFF75975A60
	public static extern Void CSharp_delete_AkEventCallbackInfo(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A64
	public static extern Byte CSharp_AkMIDIEventCallbackInfo_byChan_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A68
	public static extern Byte CSharp_AkMIDIEventCallbackInfo_byParam1_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A6C
	public static extern Byte CSharp_AkMIDIEventCallbackInfo_byParam2_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A70
	public static extern Int32 CSharp_AkMIDIEventCallbackInfo_byType_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A74
	public static extern Byte CSharp_AkMIDIEventCallbackInfo_byOnOffNote_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A78
	public static extern Byte CSharp_AkMIDIEventCallbackInfo_byVelocity_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A7C
	public static extern Int32 CSharp_AkMIDIEventCallbackInfo_byCc_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A80
	public static extern Byte CSharp_AkMIDIEventCallbackInfo_byCcValue_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A84
	public static extern Byte CSharp_AkMIDIEventCallbackInfo_byValueLsb_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A88
	public static extern Byte CSharp_AkMIDIEventCallbackInfo_byValueMsb_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A8C
	public static extern Byte CSharp_AkMIDIEventCallbackInfo_byAftertouchNote_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A90
	public static extern Byte CSharp_AkMIDIEventCallbackInfo_byNoteAftertouchValue_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A94
	public static extern Byte CSharp_AkMIDIEventCallbackInfo_byChanAftertouchValue_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A98
	public static extern Byte CSharp_AkMIDIEventCallbackInfo_byProgramNum_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975A9C
	public static extern IntPtr CSharp_new_AkMIDIEventCallbackInfo() { }

	// RVA: 0xFFFFFFFF75975AA0
	public static extern Void CSharp_delete_AkMIDIEventCallbackInfo(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975AA4
	public static extern UInt32 CSharp_AkMarkerCallbackInfo_uIdentifier_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975AA8
	public static extern UInt32 CSharp_AkMarkerCallbackInfo_uPosition_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975AAC
	public static extern IntPtr CSharp_AkMarkerCallbackInfo_strLabel_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975AB0
	public static extern IntPtr CSharp_new_AkMarkerCallbackInfo() { }

	// RVA: 0xFFFFFFFF75975AB4
	public static extern Void CSharp_delete_AkMarkerCallbackInfo(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975AB8
	public static extern Single CSharp_AkDurationCallbackInfo_fDuration_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975ABC
	public static extern Single CSharp_AkDurationCallbackInfo_fEstimatedDuration_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975AC0
	public static extern UInt32 CSharp_AkDurationCallbackInfo_audioNodeID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975AC4
	public static extern UInt32 CSharp_AkDurationCallbackInfo_mediaID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975AC8
	public static extern Boolean CSharp_AkDurationCallbackInfo_bStreaming_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975AE4
	public static extern IntPtr CSharp_new_AkDurationCallbackInfo() { }

	// RVA: 0xFFFFFFFF75975AE8
	public static extern Void CSharp_delete_AkDurationCallbackInfo(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975AEC
	public static extern UInt32 CSharp_AkDynamicSequenceItemCallbackInfo_playingID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975AF0
	public static extern UInt32 CSharp_AkDynamicSequenceItemCallbackInfo_audioNodeID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975AF4
	public static extern IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_pCustomInfo_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975AF8
	public static extern IntPtr CSharp_new_AkDynamicSequenceItemCallbackInfo() { }

	// RVA: 0xFFFFFFFF75975AFC
	public static extern Void CSharp_delete_AkDynamicSequenceItemCallbackInfo(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B00
	public static extern UInt32 CSharp_AkMusicSyncCallbackInfo_playingID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B04
	public static extern Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iCurrentPosition_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B08
	public static extern Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPreEntryDuration_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B0C
	public static extern Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iActiveDuration_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B10
	public static extern Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPostExitDuration_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B14
	public static extern Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iRemainingLookAheadTime_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B18
	public static extern Single CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBeatDuration_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B1C
	public static extern Single CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBarDuration_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B20
	public static extern Single CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridDuration_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B24
	public static extern Single CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridOffset_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B28
	public static extern Int32 CSharp_AkMusicSyncCallbackInfo_musicSyncType_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B2C
	public static extern IntPtr CSharp_AkMusicSyncCallbackInfo_userCueName_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B30
	public static extern IntPtr CSharp_new_AkMusicSyncCallbackInfo() { }

	// RVA: 0xFFFFFFFF75975B34
	public static extern Void CSharp_delete_AkMusicSyncCallbackInfo(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B38
	public static extern UInt32 CSharp_AkMusicPlaylistCallbackInfo_playlistID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B3C
	public static extern UInt32 CSharp_AkMusicPlaylistCallbackInfo_uNumPlaylistItems_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B40
	public static extern UInt32 CSharp_AkMusicPlaylistCallbackInfo_uPlaylistSelection_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B44
	public static extern UInt32 CSharp_AkMusicPlaylistCallbackInfo_uPlaylistItemDone_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B48
	public static extern IntPtr CSharp_new_AkMusicPlaylistCallbackInfo() { }

	// RVA: 0xFFFFFFFF75975B4C
	public static extern Void CSharp_delete_AkMusicPlaylistCallbackInfo(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B50
	public static extern UInt32 CSharp_AkBankCallbackInfo_bankID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B54
	public static extern IntPtr CSharp_AkBankCallbackInfo_inMemoryBankPtr_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B58
	public static extern Int32 CSharp_AkBankCallbackInfo_loadResult_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B5C
	public static extern IntPtr CSharp_new_AkBankCallbackInfo() { }

	// RVA: 0xFFFFFFFF75975B60
	public static extern Void CSharp_delete_AkBankCallbackInfo(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B64
	public static extern Int32 CSharp_AkMonitoringCallbackInfo_errorCode_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B68
	public static extern Int32 CSharp_AkMonitoringCallbackInfo_errorLevel_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B6C
	public static extern UInt32 CSharp_AkMonitoringCallbackInfo_playingID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B70
	public static extern UInt64 CSharp_AkMonitoringCallbackInfo_gameObjID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B74
	public static extern IntPtr CSharp_AkMonitoringCallbackInfo_message_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B78
	public static extern IntPtr CSharp_new_AkMonitoringCallbackInfo() { }

	// RVA: 0xFFFFFFFF75975B7C
	public static extern Void CSharp_delete_AkMonitoringCallbackInfo(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B80
	public static extern Boolean CSharp_AkAudioInterruptionCallbackInfo_bEnterInterruption_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975B9C
	public static extern IntPtr CSharp_new_AkAudioInterruptionCallbackInfo() { }

	// RVA: 0xFFFFFFFF75975BA0
	public static extern Void CSharp_delete_AkAudioInterruptionCallbackInfo(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975BA4
	public static extern Boolean CSharp_AkAudioSourceChangeCallbackInfo_bOtherAudioPlaying_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975BC0
	public static extern IntPtr CSharp_new_AkAudioSourceChangeCallbackInfo() { }

	// RVA: 0xFFFFFFFF75975BC4
	public static extern Void CSharp_delete_AkAudioSourceChangeCallbackInfo(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975BC8
	public static extern Int32 CSharp_AkCallbackSerializer_Init() { }

	// RVA: 0xFFFFFFFF75975BCC
	public static extern Void CSharp_AkCallbackSerializer_Term() { }

	// RVA: 0xFFFFFFFF75975BD0
	public static extern IntPtr CSharp_AkCallbackSerializer_Lock() { }

	// RVA: 0xFFFFFFFF75975BD4
	public static extern Void CSharp_AkCallbackSerializer_Unlock() { }

	// RVA: 0xFFFFFFFF75975BD8
	public static extern Void CSharp_AkCallbackSerializer_SetLocalOutput(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975BDC
	public static extern Int32 CSharp_AkCallbackSerializer_AudioSourceChangeCallbackFunc(Boolean jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75975BE0
	public static extern IntPtr CSharp_new_AkCallbackSerializer() { }

	// RVA: 0xFFFFFFFF75975BE4
	public static extern Void CSharp_delete_AkCallbackSerializer(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975BE8
	public static extern Int32 CSharp_PostCode__SWIG_0(Int32 jarg1, Int32 jarg2, UInt32 jarg3, UInt64 jarg4, UInt32 jarg5, Boolean jarg6) { }

	// RVA: 0xFFFFFFFF75975BEC
	public static extern Int32 CSharp_PostCode__SWIG_1(Int32 jarg1, Int32 jarg2, UInt32 jarg3, UInt64 jarg4, UInt32 jarg5) { }

	// RVA: 0xFFFFFFFF75975BF0
	public static extern Int32 CSharp_PostCode__SWIG_2(Int32 jarg1, Int32 jarg2, UInt32 jarg3, UInt64 jarg4) { }

	// RVA: 0xFFFFFFFF75975BF4
	public static extern Int32 CSharp_PostCode__SWIG_3(Int32 jarg1, Int32 jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75975BF8
	public static extern Int32 CSharp_PostCode__SWIG_4(Int32 jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75975BFC
	public static extern Int32 CSharp_PostString__SWIG_0(String jarg1, Int32 jarg2, UInt32 jarg3, UInt64 jarg4, UInt32 jarg5, Boolean jarg6) { }

	// RVA: 0xFFFFFFFF75975C0C
	public static extern Int32 CSharp_PostString__SWIG_1(String jarg1, Int32 jarg2, UInt32 jarg3, UInt64 jarg4, UInt32 jarg5) { }

	// RVA: 0xFFFFFFFF75975C1C
	public static extern Int32 CSharp_PostString__SWIG_2(String jarg1, Int32 jarg2, UInt32 jarg3, UInt64 jarg4) { }

	// RVA: 0xFFFFFFFF75975C2C
	public static extern Int32 CSharp_PostString__SWIG_3(String jarg1, Int32 jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75975C3C
	public static extern Int32 CSharp_PostString__SWIG_4(String jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75975C4C
	public static extern Int32 CSharp_GetTimeStamp() { }

	// RVA: 0xFFFFFFFF75975C50
	public static extern Void CSharp_MonitorStreamMgrInit(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975C54
	public static extern Void CSharp_MonitorStreamingDeviceInit(UInt32 jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75975C58
	public static extern Void CSharp_MonitorStreamingDeviceDestroyed(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975C5C
	public static extern Void CSharp_MonitorStreamMgrTerm() { }

	// RVA: 0xFFFFFFFF75975C60
	public static extern UInt32 CSharp_GetNumNonZeroBits(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975C64
	public static extern UInt32 CSharp_GetNextPowerOfTwo(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975C68
	public static extern UInt32 CSharp_ROTL32(UInt32 jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975C6C
	public static extern UInt64 CSharp_ROTL64(UInt64 jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF75975C70
	public static extern Void CSharp_AkGetDefaultHighPriorityThreadProperties(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975C74
	public static extern UInt32 CSharp_ResolveDialogueEvent__SWIG_0(UInt32 jarg1, [In] UInt32[] jarg2, UInt32 jarg3, UInt32 jarg4) { }

	// RVA: 0xFFFFFFFF75975C84
	public static extern UInt32 CSharp_ResolveDialogueEvent__SWIG_1(UInt32 jarg1, [In] UInt32[] jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75975C94
	public static extern Int32 CSharp_GetDialogueEventCustomPropertyValue__SWIG_0(UInt32 jarg1, UInt32 jarg2, out Int32 jarg3) { }

	// RVA: 0xFFFFFFFF75975C98
	public static extern Int32 CSharp_GetDialogueEventCustomPropertyValue__SWIG_1(UInt32 jarg1, UInt32 jarg2, out Single jarg3) { }

	// RVA: 0xFFFFFFFF75975C9C
	public static extern Void CSharp_AkPositioningInfo_fCenterPct_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75975CA0
	public static extern Single CSharp_AkPositioningInfo_fCenterPct_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975CA4
	public static extern Void CSharp_AkPositioningInfo_pannerType_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75975CA8
	public static extern Int32 CSharp_AkPositioningInfo_pannerType_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975CAC
	public static extern Void CSharp_AkPositioningInfo_e3dPositioningType_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75975CB0
	public static extern Int32 CSharp_AkPositioningInfo_e3dPositioningType_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975CB4
	public static extern Void CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF75975CB8
	public static extern Boolean CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975CD4
	public static extern Void CSharp_AkPositioningInfo_e3DSpatializationMode_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75975CD8
	public static extern Int32 CSharp_AkPositioningInfo_e3DSpatializationMode_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975CDC
	public static extern Void CSharp_AkPositioningInfo_bEnableAttenuation_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF75975CE0
	public static extern Boolean CSharp_AkPositioningInfo_bEnableAttenuation_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975CFC
	public static extern Void CSharp_AkPositioningInfo_bUseConeAttenuation_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF75975D00
	public static extern Boolean CSharp_AkPositioningInfo_bUseConeAttenuation_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975D1C
	public static extern Void CSharp_AkPositioningInfo_fInnerAngle_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75975D20
	public static extern Single CSharp_AkPositioningInfo_fInnerAngle_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975D24
	public static extern Void CSharp_AkPositioningInfo_fOuterAngle_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75975D28
	public static extern Single CSharp_AkPositioningInfo_fOuterAngle_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975D2C
	public static extern Void CSharp_AkPositioningInfo_fConeMaxAttenuation_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75975D30
	public static extern Single CSharp_AkPositioningInfo_fConeMaxAttenuation_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975D34
	public static extern Void CSharp_AkPositioningInfo_LPFCone_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75975D38
	public static extern Single CSharp_AkPositioningInfo_LPFCone_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975D3C
	public static extern Void CSharp_AkPositioningInfo_HPFCone_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75975D40
	public static extern Single CSharp_AkPositioningInfo_HPFCone_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975D44
	public static extern Void CSharp_AkPositioningInfo_fMaxDistance_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75975D48
	public static extern Single CSharp_AkPositioningInfo_fMaxDistance_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975D4C
	public static extern Void CSharp_AkPositioningInfo_fVolDryAtMaxDist_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75975D50
	public static extern Single CSharp_AkPositioningInfo_fVolDryAtMaxDist_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975D54
	public static extern Void CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75975D58
	public static extern Single CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975D5C
	public static extern Void CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75975D60
	public static extern Single CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975D64
	public static extern Void CSharp_AkPositioningInfo_LPFValueAtMaxDist_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75975D68
	public static extern Single CSharp_AkPositioningInfo_LPFValueAtMaxDist_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975D6C
	public static extern Void CSharp_AkPositioningInfo_HPFValueAtMaxDist_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75975D70
	public static extern Single CSharp_AkPositioningInfo_HPFValueAtMaxDist_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975D74
	public static extern IntPtr CSharp_new_AkPositioningInfo() { }

	// RVA: 0xFFFFFFFF75975D78
	public static extern Void CSharp_delete_AkPositioningInfo(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975D7C
	public static extern Void CSharp_AkObjectInfo_objID_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975D80
	public static extern UInt32 CSharp_AkObjectInfo_objID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975D84
	public static extern Void CSharp_AkObjectInfo_parentID_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975D88
	public static extern UInt32 CSharp_AkObjectInfo_parentID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975D8C
	public static extern Void CSharp_AkObjectInfo_iDepth_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75975D90
	public static extern Int32 CSharp_AkObjectInfo_iDepth_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975D94
	public static extern Void CSharp_AkObjectInfo_Clear(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975D98
	public static extern Int32 CSharp_AkObjectInfo_GetSizeOf() { }

	// RVA: 0xFFFFFFFF75975D9C
	public static extern Void CSharp_AkObjectInfo_Clone(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75975DA0
	public static extern IntPtr CSharp_new_AkObjectInfo() { }

	// RVA: 0xFFFFFFFF75975DA4
	public static extern Void CSharp_delete_AkObjectInfo(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975DA8
	public static extern Int32 CSharp_GetPosition(UInt64 jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75975DAC
	public static extern Int32 CSharp_GetListenerPosition(UInt64 jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75975DB0
	public static extern Int32 CSharp_GetRTPCValue__SWIG_0(UInt32 jarg1, UInt64 jarg2, UInt32 jarg3, out Single jarg4, ref Int32 jarg5) { }

	// RVA: 0xFFFFFFFF75975DB4
	public static extern Int32 CSharp_GetRTPCValue__SWIG_1(String jarg1, UInt64 jarg2, UInt32 jarg3, out Single jarg4, ref Int32 jarg5) { }

	// RVA: 0xFFFFFFFF75975DC4
	public static extern Int32 CSharp_GetSwitch__SWIG_0(UInt32 jarg1, UInt64 jarg2, out UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75975DC8
	public static extern Int32 CSharp_GetSwitch__SWIG_1(String jarg1, UInt64 jarg2, out UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75975DD8
	public static extern Int32 CSharp_GetState__SWIG_0(UInt32 jarg1, out UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975DDC
	public static extern Int32 CSharp_GetState__SWIG_1(String jarg1, out UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975DEC
	public static extern Int32 CSharp_GetGameObjectAuxSendValues(UInt64 jarg1, IntPtr jarg2, ref UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75975DF0
	public static extern Int32 CSharp_GetGameObjectDryLevelValue(UInt64 jarg1, UInt64 jarg2, out Single jarg3) { }

	// RVA: 0xFFFFFFFF75975DF4
	public static extern Int32 CSharp_GetObjectObstructionAndOcclusion(UInt64 jarg1, UInt64 jarg2, out Single jarg3, out Single jarg4) { }

	// RVA: 0xFFFFFFFF75975DF8
	public static extern Int32 CSharp_QueryAudioObjectIDs__SWIG_0(UInt32 jarg1, ref UInt32 jarg2, IntPtr jarg3) { }

	// RVA: 0xFFFFFFFF75975DFC
	public static extern Int32 CSharp_QueryAudioObjectIDs__SWIG_1(String jarg1, ref UInt32 jarg2, IntPtr jarg3) { }

	// RVA: 0xFFFFFFFF75975E0C
	public static extern Int32 CSharp_GetPositioningInfo(UInt32 jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75975E10
	public static extern Boolean CSharp_GetIsGameObjectActive(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF75975E2C
	public static extern Single CSharp_GetMaxRadius(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF75975E30
	public static extern UInt32 CSharp_GetEventIDFromPlayingID(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975E34
	public static extern UInt64 CSharp_GetGameObjectFromPlayingID(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975E38
	public static extern Int32 CSharp_GetPlayingIDsFromGameObject(UInt64 jarg1, ref UInt32 jarg2, [Out] UInt32[] jarg3) { }

	// RVA: 0xFFFFFFFF75975EF8
	public static extern Int32 CSharp_GetCustomPropertyValue__SWIG_0(UInt32 jarg1, UInt32 jarg2, out Int32 jarg3) { }

	// RVA: 0xFFFFFFFF75975EFC
	public static extern Int32 CSharp_GetCustomPropertyValue__SWIG_1(UInt32 jarg1, UInt32 jarg2, out Single jarg3) { }

	// RVA: 0xFFFFFFFF75975F00
	public static extern Void CSharp_AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(ref UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975F04
	public static extern Void CSharp_AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(ref UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975F08
	public static extern Void CSharp_AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(ref UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975F0C
	public static extern Byte CSharp_ChannelMaskToNumChannels(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975F10
	public static extern UInt32 CSharp_ChannelMaskFromNumChannels(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975F14
	public static extern Byte CSharp_ChannelBitToIndex(UInt32 jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975F18
	public static extern Boolean CSharp_HasSurroundChannels(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975F34
	public static extern Boolean CSharp_HasStrictlyOnePairOfSurroundChannels(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975F50
	public static extern Boolean CSharp_HasSideAndRearChannels(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975F6C
	public static extern Boolean CSharp_HasHeightChannels(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975F88
	public static extern UInt32 CSharp_BackToSideChannels(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975F8C
	public static extern UInt32 CSharp_StdChannelIndexToDisplayIndex(Int32 jarg1, UInt32 jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75975F90
	public static extern Void CSharp_AkChannelConfig_uNumChannels_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975F94
	public static extern UInt32 CSharp_AkChannelConfig_uNumChannels_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975F98
	public static extern Void CSharp_AkChannelConfig_eConfigType_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975F9C
	public static extern UInt32 CSharp_AkChannelConfig_eConfigType_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975FA0
	public static extern Void CSharp_AkChannelConfig_uChannelMask_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975FA4
	public static extern UInt32 CSharp_AkChannelConfig_uChannelMask_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975FA8
	public static extern IntPtr CSharp_AkChannelConfig_Standard(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975FAC
	public static extern IntPtr CSharp_AkChannelConfig_Anonymous(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975FB0
	public static extern IntPtr CSharp_AkChannelConfig_Ambisonic(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75975FB4
	public static extern IntPtr CSharp_AkChannelConfig_Object() { }

	// RVA: 0xFFFFFFFF75975FB8
	public static extern IntPtr CSharp_new_AkChannelConfig__SWIG_0() { }

	// RVA: 0xFFFFFFFF75975FBC
	public static extern IntPtr CSharp_new_AkChannelConfig__SWIG_1(UInt32 jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975FC0
	public static extern Void CSharp_AkChannelConfig_Clear(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975FC4
	public static extern Void CSharp_AkChannelConfig_SetStandard(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975FC8
	public static extern Void CSharp_AkChannelConfig_SetStandardOrAnonymous(IntPtr jarg1, UInt32 jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75975FCC
	public static extern Void CSharp_AkChannelConfig_SetAnonymous(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975FD0
	public static extern Void CSharp_AkChannelConfig_SetAmbisonic(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75975FD4
	public static extern Void CSharp_AkChannelConfig_SetObject(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975FD8
	public static extern Void CSharp_AkChannelConfig_SetSameAsMainMix(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975FDC
	public static extern Void CSharp_AkChannelConfig_SetSameAsPassthrough(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975FE0
	public static extern Boolean CSharp_AkChannelConfig_IsValid(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75975FFC
	public static extern UInt32 CSharp_AkChannelConfig_Serialize(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976000
	public static extern Void CSharp_AkChannelConfig_Deserialize(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976004
	public static extern IntPtr CSharp_AkChannelConfig_RemoveLFE(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976008
	public static extern IntPtr CSharp_AkChannelConfig_RemoveCenter(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597600C
	public static extern Void CSharp_delete_AkChannelConfig(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976010
	public static extern IntPtr CSharp_new_AkImageSourceParams__SWIG_0() { }

	// RVA: 0xFFFFFFFF75976014
	public static extern IntPtr CSharp_new_AkImageSourceParams__SWIG_1(Vector3 jarg1, Single jarg2, Single jarg3) { }

	// RVA: 0xFFFFFFFF75976018
	public static extern Void CSharp_AkImageSourceParams_sourcePosition_set(IntPtr jarg1, Vector3 jarg2) { }

	// RVA: 0xFFFFFFFF7597601C
	public static extern Vector3 CSharp_AkImageSourceParams_sourcePosition_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976020
	public static extern Void CSharp_AkImageSourceParams_fDistanceScalingFactor_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75976024
	public static extern Single CSharp_AkImageSourceParams_fDistanceScalingFactor_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976028
	public static extern Void CSharp_AkImageSourceParams_fLevel_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF7597602C
	public static extern Single CSharp_AkImageSourceParams_fLevel_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976030
	public static extern Void CSharp_AkImageSourceParams_fDiffraction_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75976034
	public static extern Single CSharp_AkImageSourceParams_fDiffraction_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976038
	public static extern Void CSharp_AkImageSourceParams_uDiffractionEmitterSide_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF7597603C
	public static extern Byte CSharp_AkImageSourceParams_uDiffractionEmitterSide_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976040
	public static extern Void CSharp_AkImageSourceParams_uDiffractionListenerSide_set(IntPtr jarg1, Byte jarg2) { }

	// RVA: 0xFFFFFFFF75976044
	public static extern Byte CSharp_AkImageSourceParams_uDiffractionListenerSide_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976048
	public static extern Void CSharp_delete_AkImageSourceParams(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597604C
	public static extern Single CSharp_kDefaultMaxPathLength_get() { }

	// RVA: 0xFFFFFFFF75976050
	public static extern UInt32 CSharp_kDefaultDiffractionMaxEdges_get() { }

	// RVA: 0xFFFFFFFF75976054
	public static extern UInt32 CSharp_kDefaultDiffractionMaxPaths_get() { }

	// RVA: 0xFFFFFFFF75976058
	public static extern Single CSharp_kMaxDiffraction_get() { }

	// RVA: 0xFFFFFFFF7597605C
	public static extern UInt32 CSharp_kDiffractionMaxEdges_get() { }

	// RVA: 0xFFFFFFFF75976060
	public static extern UInt32 CSharp_kDiffractionMaxPaths_get() { }

	// RVA: 0xFFFFFFFF75976064
	public static extern UInt32 CSharp_kPortalToPortalDiffractionMaxPaths_get() { }

	// RVA: 0xFFFFFFFF75976068
	public static extern IntPtr CSharp_new_AkSpatialAudioInitSettings() { }

	// RVA: 0xFFFFFFFF7597606C
	public static extern Void CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976070
	public static extern UInt32 CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976074
	public static extern Void CSharp_AkSpatialAudioInitSettings_fMovementThreshold_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75976078
	public static extern Single CSharp_AkSpatialAudioInitSettings_fMovementThreshold_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597607C
	public static extern Void CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976080
	public static extern UInt32 CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976084
	public static extern Void CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976088
	public static extern UInt32 CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597608C
	public static extern Void CSharp_AkSpatialAudioInitSettings_fMaxPathLength_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75976090
	public static extern Single CSharp_AkSpatialAudioInitSettings_fMaxPathLength_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976094
	public static extern Void CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75976098
	public static extern Single CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597609C
	public static extern Void CSharp_AkSpatialAudioInitSettings_bEnableDiffractionOnReflection_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF759760A0
	public static extern Boolean CSharp_AkSpatialAudioInitSettings_bEnableDiffractionOnReflection_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759760BC
	public static extern Void CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF759760C0
	public static extern Boolean CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759760DC
	public static extern Void CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF759760E0
	public static extern Boolean CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759760FC
	public static extern Void CSharp_AkSpatialAudioInitSettings_bUseObstruction_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF75976100
	public static extern Boolean CSharp_AkSpatialAudioInitSettings_bUseObstruction_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597611C
	public static extern Void CSharp_AkSpatialAudioInitSettings_bUseOcclusion_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF75976120
	public static extern Boolean CSharp_AkSpatialAudioInitSettings_bUseOcclusion_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597613C
	public static extern Void CSharp_delete_AkSpatialAudioInitSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976140
	public static extern IntPtr CSharp_new_AkImageSourceSettings__SWIG_0() { }

	// RVA: 0xFFFFFFFF75976144
	public static extern IntPtr CSharp_new_AkImageSourceSettings__SWIG_1(Vector3 jarg1, Single jarg2, Single jarg3) { }

	// RVA: 0xFFFFFFFF75976148
	public static extern Void CSharp_delete_AkImageSourceSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597614C
	public static extern Void CSharp_AkImageSourceSettings_SetOneTexture(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976150
	public static extern Void CSharp_AkImageSourceSettings_SetName(IntPtr jarg1, String jarg2) { }

	// RVA: 0xFFFFFFFF75976188
	public static extern Void CSharp_AkImageSourceSettings_params__set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF7597618C
	public static extern IntPtr CSharp_AkImageSourceSettings_params__get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976190
	public static extern IntPtr CSharp_new_AkExtent__SWIG_0() { }

	// RVA: 0xFFFFFFFF75976194
	public static extern IntPtr CSharp_new_AkExtent__SWIG_1(Single jarg1, Single jarg2, Single jarg3) { }

	// RVA: 0xFFFFFFFF75976198
	public static extern Void CSharp_AkExtent_halfWidth_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF7597619C
	public static extern Single CSharp_AkExtent_halfWidth_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759761A0
	public static extern Void CSharp_AkExtent_halfHeight_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF759761A4
	public static extern Single CSharp_AkExtent_halfHeight_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759761A8
	public static extern Void CSharp_AkExtent_halfDepth_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF759761AC
	public static extern Single CSharp_AkExtent_halfDepth_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759761B0
	public static extern Void CSharp_delete_AkExtent(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759761B4
	public static extern IntPtr CSharp_new_AkTriangle__SWIG_0() { }

	// RVA: 0xFFFFFFFF759761B8
	public static extern IntPtr CSharp_new_AkTriangle__SWIG_1(UInt16 jarg1, UInt16 jarg2, UInt16 jarg3, UInt16 jarg4) { }

	// RVA: 0xFFFFFFFF759761BC
	public static extern Void CSharp_AkTriangle_point0_set(IntPtr jarg1, UInt16 jarg2) { }

	// RVA: 0xFFFFFFFF759761C0
	public static extern UInt16 CSharp_AkTriangle_point0_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759761C4
	public static extern Void CSharp_AkTriangle_point1_set(IntPtr jarg1, UInt16 jarg2) { }

	// RVA: 0xFFFFFFFF759761C8
	public static extern UInt16 CSharp_AkTriangle_point1_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759761CC
	public static extern Void CSharp_AkTriangle_point2_set(IntPtr jarg1, UInt16 jarg2) { }

	// RVA: 0xFFFFFFFF759761D0
	public static extern UInt16 CSharp_AkTriangle_point2_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759761D4
	public static extern Void CSharp_AkTriangle_surface_set(IntPtr jarg1, UInt16 jarg2) { }

	// RVA: 0xFFFFFFFF759761D8
	public static extern UInt16 CSharp_AkTriangle_surface_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759761DC
	public static extern Void CSharp_AkTriangle_Clear(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759761E0
	public static extern Int32 CSharp_AkTriangle_GetSizeOf() { }

	// RVA: 0xFFFFFFFF759761E4
	public static extern Void CSharp_AkTriangle_Clone(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF759761E8
	public static extern Void CSharp_delete_AkTriangle(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759761EC
	public static extern IntPtr CSharp_new_AkAcousticSurface() { }

	// RVA: 0xFFFFFFFF759761F0
	public static extern Void CSharp_AkAcousticSurface_textureID_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF759761F4
	public static extern UInt32 CSharp_AkAcousticSurface_textureID_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759761F8
	public static extern Void CSharp_AkAcousticSurface_transmissionLoss_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF759761FC
	public static extern Single CSharp_AkAcousticSurface_transmissionLoss_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976200
	public static extern Void CSharp_AkAcousticSurface_strName_set(IntPtr jarg1, String jarg2) { }

	// RVA: 0xFFFFFFFF75976238
	public static extern IntPtr CSharp_AkAcousticSurface_strName_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597623C
	public static extern Void CSharp_AkAcousticSurface_Clear(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976240
	public static extern Void CSharp_AkAcousticSurface_DeleteName(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976244
	public static extern Int32 CSharp_AkAcousticSurface_GetSizeOf() { }

	// RVA: 0xFFFFFFFF75976248
	public static extern Void CSharp_AkAcousticSurface_Clone(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF7597624C
	public static extern Void CSharp_delete_AkAcousticSurface(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976250
	public static extern Void CSharp_AkReflectionPathInfo_imageSource_set(IntPtr jarg1, Vector3 jarg2) { }

	// RVA: 0xFFFFFFFF75976254
	public static extern Vector3 CSharp_AkReflectionPathInfo_imageSource_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976258
	public static extern Void CSharp_AkReflectionPathInfo_numPathPoints_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF7597625C
	public static extern UInt32 CSharp_AkReflectionPathInfo_numPathPoints_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976260
	public static extern Void CSharp_AkReflectionPathInfo_numReflections_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976264
	public static extern UInt32 CSharp_AkReflectionPathInfo_numReflections_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976268
	public static extern Void CSharp_AkReflectionPathInfo_level_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF7597626C
	public static extern Single CSharp_AkReflectionPathInfo_level_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976270
	public static extern Void CSharp_AkReflectionPathInfo_isOccluded_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF75976274
	public static extern Boolean CSharp_AkReflectionPathInfo_isOccluded_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976290
	public static extern Int32 CSharp_AkReflectionPathInfo_GetSizeOf() { }

	// RVA: 0xFFFFFFFF75976294
	public static extern Vector3 CSharp_AkReflectionPathInfo_GetPathPoint(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976298
	public static extern IntPtr CSharp_AkReflectionPathInfo_GetAcousticSurface(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF7597629C
	public static extern Single CSharp_AkReflectionPathInfo_GetDiffraction(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF759762A0
	public static extern Void CSharp_AkReflectionPathInfo_Clone(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF759762A4
	public static extern IntPtr CSharp_new_AkReflectionPathInfo() { }

	// RVA: 0xFFFFFFFF759762A8
	public static extern Void CSharp_delete_AkReflectionPathInfo(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759762AC
	public static extern Void CSharp_AkDiffractionPathInfo_emitterPos_set(IntPtr jarg1, Vector3 jarg2) { }

	// RVA: 0xFFFFFFFF759762B0
	public static extern Vector3 CSharp_AkDiffractionPathInfo_emitterPos_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759762B4
	public static extern Void CSharp_AkDiffractionPathInfo_virtualPos_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF759762B8
	public static extern IntPtr CSharp_AkDiffractionPathInfo_virtualPos_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759762BC
	public static extern Void CSharp_AkDiffractionPathInfo_nodeCount_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF759762C0
	public static extern UInt32 CSharp_AkDiffractionPathInfo_nodeCount_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759762C4
	public static extern Void CSharp_AkDiffractionPathInfo_diffraction_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF759762C8
	public static extern Single CSharp_AkDiffractionPathInfo_diffraction_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759762CC
	public static extern Void CSharp_AkDiffractionPathInfo_transmissionLoss_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF759762D0
	public static extern Single CSharp_AkDiffractionPathInfo_transmissionLoss_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759762D4
	public static extern Void CSharp_AkDiffractionPathInfo_totLength_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF759762D8
	public static extern Single CSharp_AkDiffractionPathInfo_totLength_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759762DC
	public static extern Void CSharp_AkDiffractionPathInfo_obstructionValue_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF759762E0
	public static extern Single CSharp_AkDiffractionPathInfo_obstructionValue_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759762E4
	public static extern Int32 CSharp_AkDiffractionPathInfo_GetSizeOf() { }

	// RVA: 0xFFFFFFFF759762E8
	public static extern Vector3 CSharp_AkDiffractionPathInfo_GetNodes(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF759762EC
	public static extern Single CSharp_AkDiffractionPathInfo_GetAngles(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF759762F0
	public static extern UInt64 CSharp_AkDiffractionPathInfo_GetPortals(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF759762F4
	public static extern UInt64 CSharp_AkDiffractionPathInfo_GetRooms(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF759762F8
	public static extern Void CSharp_AkDiffractionPathInfo_Clone(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF759762FC
	public static extern IntPtr CSharp_new_AkDiffractionPathInfo() { }

	// RVA: 0xFFFFFFFF75976300
	public static extern Void CSharp_delete_AkDiffractionPathInfo(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976304
	public static extern IntPtr CSharp_new_AkRoomParams__SWIG_0() { }

	// RVA: 0xFFFFFFFF75976308
	public static extern IntPtr CSharp_new_AkRoomParams__SWIG_1(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597630C
	public static extern Void CSharp_AkRoomParams_Front_set(IntPtr jarg1, Vector3 jarg2) { }

	// RVA: 0xFFFFFFFF75976310
	public static extern Vector3 CSharp_AkRoomParams_Front_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976314
	public static extern Void CSharp_AkRoomParams_Up_set(IntPtr jarg1, Vector3 jarg2) { }

	// RVA: 0xFFFFFFFF75976318
	public static extern Vector3 CSharp_AkRoomParams_Up_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597631C
	public static extern Void CSharp_AkRoomParams_ReverbAuxBus_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976320
	public static extern UInt32 CSharp_AkRoomParams_ReverbAuxBus_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976324
	public static extern Void CSharp_AkRoomParams_ReverbLevel_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75976328
	public static extern Single CSharp_AkRoomParams_ReverbLevel_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597632C
	public static extern Void CSharp_AkRoomParams_TransmissionLoss_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75976330
	public static extern Single CSharp_AkRoomParams_TransmissionLoss_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976334
	public static extern Void CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75976338
	public static extern Single CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597633C
	public static extern Void CSharp_AkRoomParams_RoomGameObj_KeepRegistered_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF75976340
	public static extern Boolean CSharp_AkRoomParams_RoomGameObj_KeepRegistered_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597635C
	public static extern Void CSharp_delete_AkRoomParams(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976360
	public static extern Int32 CSharp_SetGameObjectRadius(UInt64 jarg1, Single jarg2, Single jarg3) { }

	// RVA: 0xFFFFFFFF75976364
	public static extern Int32 CSharp_SetImageSource(UInt32 jarg1, IntPtr jarg2, UInt32 jarg3, UInt64 jarg4, UInt64 jarg5) { }

	// RVA: 0xFFFFFFFF75976368
	public static extern Int32 CSharp_RemoveImageSource(UInt32 jarg1, UInt32 jarg2, UInt64 jarg3) { }

	// RVA: 0xFFFFFFFF7597636C
	public static extern Int32 CSharp_ClearImageSources__SWIG_0(UInt32 jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF75976370
	public static extern Int32 CSharp_ClearImageSources__SWIG_1(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75976374
	public static extern Int32 CSharp_ClearImageSources__SWIG_2() { }

	// RVA: 0xFFFFFFFF75976378
	public static extern Int32 CSharp_RemoveGeometry(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF7597637C
	public static extern Int32 CSharp_QueryReflectionPaths(UInt64 jarg1, UInt32 jarg2, ref Vector3 jarg3, ref Vector3 jarg4, IntPtr jarg5, out UInt32 jarg6) { }

	// RVA: 0xFFFFFFFF75976380
	public static extern Int32 CSharp_RemoveRoom(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF75976384
	public static extern Int32 CSharp_RemovePortal(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF75976388
	public static extern Int32 CSharp_SetGameObjectInRoom(UInt64 jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF7597638C
	public static extern Int32 CSharp_SetReflectionsOrder(UInt32 jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF75976390
	public static extern Int32 CSharp_SetNumberOfPrimaryRays(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF75976394
	public static extern Int32 CSharp_SetEarlyReflectionsAuxSend(UInt64 jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976398
	public static extern Int32 CSharp_SetEarlyReflectionsVolume(UInt64 jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF7597639C
	public static extern Int32 CSharp_SetPortalObstructionAndOcclusion(UInt64 jarg1, Single jarg2, Single jarg3) { }

	// RVA: 0xFFFFFFFF759763A0
	public static extern Int32 CSharp_SetGameObjectToPortalObstruction(UInt64 jarg1, UInt64 jarg2, Single jarg3) { }

	// RVA: 0xFFFFFFFF759763A4
	public static extern Int32 CSharp_SetPortalToPortalObstruction(UInt64 jarg1, UInt64 jarg2, Single jarg3) { }

	// RVA: 0xFFFFFFFF759763A8
	public static extern Int32 CSharp_QueryWetDiffraction(UInt64 jarg1, out Single jarg2) { }

	// RVA: 0xFFFFFFFF759763AC
	public static extern Int32 CSharp_QueryDiffractionPaths(UInt64 jarg1, UInt32 jarg2, ref Vector3 jarg3, ref Vector3 jarg4, IntPtr jarg5, out UInt32 jarg6) { }

	// RVA: 0xFFFFFFFF759763B0
	public static extern Int32 CSharp_ResetStochasticEngine() { }

	// RVA: 0xFFFFFFFF759763B4
	public static extern Void CSharp_AkAudioSessionProperties_eCategory_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF759763B8
	public static extern Int32 CSharp_AkAudioSessionProperties_eCategory_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759763BC
	public static extern Void CSharp_AkAudioSessionProperties_eCategoryOptions_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF759763C0
	public static extern Int32 CSharp_AkAudioSessionProperties_eCategoryOptions_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759763C4
	public static extern Void CSharp_AkAudioSessionProperties_eMode_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF759763C8
	public static extern Int32 CSharp_AkAudioSessionProperties_eMode_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759763CC
	public static extern Void CSharp_AkAudioSessionProperties_eSetActivateOptions_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF759763D0
	public static extern Int32 CSharp_AkAudioSessionProperties_eSetActivateOptions_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759763D4
	public static extern IntPtr CSharp_new_AkAudioSessionProperties() { }

	// RVA: 0xFFFFFFFF759763D8
	public static extern Void CSharp_delete_AkAudioSessionProperties(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759763DC
	public static extern Void CSharp_AkPlatformInitSettings_threadLEngine_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF759763E0
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadLEngine_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759763E4
	public static extern Void CSharp_AkPlatformInitSettings_threadOutputMgr_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF759763E8
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadOutputMgr_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759763EC
	public static extern Void CSharp_AkPlatformInitSettings_threadBankManager_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF759763F0
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadBankManager_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759763F4
	public static extern Void CSharp_AkPlatformInitSettings_threadMonitor_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF759763F8
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadMonitor_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759763FC
	public static extern Void CSharp_AkPlatformInitSettings_uSampleRate_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976400
	public static extern UInt32 CSharp_AkPlatformInitSettings_uSampleRate_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976404
	public static extern Void CSharp_AkPlatformInitSettings_uNumRefillsInVoice_set(IntPtr jarg1, UInt16 jarg2) { }

	// RVA: 0xFFFFFFFF75976408
	public static extern UInt16 CSharp_AkPlatformInitSettings_uNumRefillsInVoice_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597640C
	public static extern Void CSharp_AkPlatformInitSettings_audioSession_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75976410
	public static extern IntPtr CSharp_AkPlatformInitSettings_audioSession_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976414
	public static extern Void CSharp_delete_AkPlatformInitSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976418
	public static extern Void CSharp_delete_AkStreamMgrSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597641C
	public static extern Void CSharp_AkDeviceSettings_pIOMemory_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75976420
	public static extern IntPtr CSharp_AkDeviceSettings_pIOMemory_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976424
	public static extern Void CSharp_AkDeviceSettings_uIOMemorySize_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976428
	public static extern UInt32 CSharp_AkDeviceSettings_uIOMemorySize_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597642C
	public static extern Void CSharp_AkDeviceSettings_uIOMemoryAlignment_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976430
	public static extern UInt32 CSharp_AkDeviceSettings_uIOMemoryAlignment_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976434
	public static extern Void CSharp_AkDeviceSettings_ePoolAttributes_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976438
	public static extern UInt32 CSharp_AkDeviceSettings_ePoolAttributes_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597643C
	public static extern Void CSharp_AkDeviceSettings_uGranularity_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976440
	public static extern UInt32 CSharp_AkDeviceSettings_uGranularity_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976444
	public static extern Void CSharp_AkDeviceSettings_uSchedulerTypeFlags_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976448
	public static extern UInt32 CSharp_AkDeviceSettings_uSchedulerTypeFlags_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597644C
	public static extern Void CSharp_AkDeviceSettings_threadProperties_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75976450
	public static extern IntPtr CSharp_AkDeviceSettings_threadProperties_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976454
	public static extern Void CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_set(IntPtr jarg1, Single jarg2) { }

	// RVA: 0xFFFFFFFF75976458
	public static extern Single CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597645C
	public static extern Void CSharp_AkDeviceSettings_uMaxConcurrentIO_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976460
	public static extern UInt32 CSharp_AkDeviceSettings_uMaxConcurrentIO_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976464
	public static extern Void CSharp_AkDeviceSettings_bUseStreamCache_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF75976468
	public static extern Boolean CSharp_AkDeviceSettings_bUseStreamCache_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976484
	public static extern Void CSharp_AkDeviceSettings_uMaxCachePinnedBytes_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976488
	public static extern UInt32 CSharp_AkDeviceSettings_uMaxCachePinnedBytes_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597648C
	public static extern Void CSharp_delete_AkDeviceSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976490
	public static extern Void CSharp_AkThreadProperties_nPriority_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75976494
	public static extern Int32 CSharp_AkThreadProperties_nPriority_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976498
	public static extern Void CSharp_AkThreadProperties_uStackSize_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF7597649C
	public static extern UInt32 CSharp_AkThreadProperties_uStackSize_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759764A0
	public static extern Void CSharp_AkThreadProperties_uSchedPolicy_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF759764A4
	public static extern Int32 CSharp_AkThreadProperties_uSchedPolicy_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759764A8
	public static extern Void CSharp_AkThreadProperties_dwAffinityMask_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF759764AC
	public static extern UInt32 CSharp_AkThreadProperties_dwAffinityMask_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759764B0
	public static extern IntPtr CSharp_new_AkThreadProperties() { }

	// RVA: 0xFFFFFFFF759764B4
	public static extern Void CSharp_delete_AkThreadProperties(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759764B8
	public static extern Void CSharp_SetErrorLogger__SWIG_0(ErrorLoggerInteropDelegate jarg1) { }

	// RVA: 0xFFFFFFFF759764CC
	public static extern Void CSharp_SetErrorLogger__SWIG_1() { }

	// RVA: 0xFFFFFFFF759764D0
	public static extern Void CSharp_SetAudioInputCallbacks(AudioSamplesInteropDelegate jarg1, AudioFormatInteropDelegate jarg2) { }

	// RVA: 0xFFFFFFFF75976504
	public static extern Void CSharp_delete_AkUnityPlatformSpecificSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976508
	public static extern IntPtr CSharp_new_AkCommunicationSettings() { }

	// RVA: 0xFFFFFFFF7597650C
	public static extern Void CSharp_AkCommunicationSettings_uPoolSize_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976510
	public static extern UInt32 CSharp_AkCommunicationSettings_uPoolSize_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976514
	public static extern Void CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_set(IntPtr jarg1, UInt16 jarg2) { }

	// RVA: 0xFFFFFFFF75976518
	public static extern UInt16 CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597651C
	public static extern Void CSharp_AkCommunicationSettings_uCommandPort_set(IntPtr jarg1, UInt16 jarg2) { }

	// RVA: 0xFFFFFFFF75976520
	public static extern UInt16 CSharp_AkCommunicationSettings_uCommandPort_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976524
	public static extern Void CSharp_AkCommunicationSettings_uNotificationPort_set(IntPtr jarg1, UInt16 jarg2) { }

	// RVA: 0xFFFFFFFF75976528
	public static extern UInt16 CSharp_AkCommunicationSettings_uNotificationPort_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597652C
	public static extern Void CSharp_AkCommunicationSettings_commSystem_set(IntPtr jarg1, Int32 jarg2) { }

	// RVA: 0xFFFFFFFF75976530
	public static extern Int32 CSharp_AkCommunicationSettings_commSystem_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976534
	public static extern Void CSharp_AkCommunicationSettings_bInitSystemLib_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF75976538
	public static extern Boolean CSharp_AkCommunicationSettings_bInitSystemLib_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976554
	public static extern Void CSharp_AkCommunicationSettings_szAppNetworkName_set(IntPtr jarg1, String jarg2) { }

	// RVA: 0xFFFFFFFF7597658C
	public static extern IntPtr CSharp_AkCommunicationSettings_szAppNetworkName_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976590
	public static extern Void CSharp_delete_AkCommunicationSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976594
	public static extern IntPtr CSharp_new_AkInitializationSettings() { }

	// RVA: 0xFFFFFFFF75976598
	public static extern Void CSharp_delete_AkInitializationSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597659C
	public static extern Void CSharp_AkInitializationSettings_streamMgrSettings_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF759765A0
	public static extern IntPtr CSharp_AkInitializationSettings_streamMgrSettings_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759765A4
	public static extern Void CSharp_AkInitializationSettings_deviceSettings_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF759765A8
	public static extern IntPtr CSharp_AkInitializationSettings_deviceSettings_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759765AC
	public static extern Void CSharp_AkInitializationSettings_initSettings_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF759765B0
	public static extern IntPtr CSharp_AkInitializationSettings_initSettings_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759765B4
	public static extern Void CSharp_AkInitializationSettings_platformSettings_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF759765B8
	public static extern IntPtr CSharp_AkInitializationSettings_platformSettings_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759765BC
	public static extern Void CSharp_AkInitializationSettings_musicSettings_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF759765C0
	public static extern IntPtr CSharp_AkInitializationSettings_musicSettings_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759765C4
	public static extern Void CSharp_AkInitializationSettings_unityPlatformSpecificSettings_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF759765C8
	public static extern IntPtr CSharp_AkInitializationSettings_unityPlatformSpecificSettings_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759765CC
	public static extern Void CSharp_AkInitializationSettings_useAsyncOpen_set(IntPtr jarg1, Boolean jarg2) { }

	// RVA: 0xFFFFFFFF759765D0
	public static extern Boolean CSharp_AkInitializationSettings_useAsyncOpen_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759765EC
	public static extern Void CSharp_AkInitializationSettings_uMemAllocationSizeLimit_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF759765F0
	public static extern UInt32 CSharp_AkInitializationSettings_uMemAllocationSizeLimit_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759765F4
	public static extern Void CSharp_AkInitializationSettings_uMemDebugLevel_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF759765F8
	public static extern UInt32 CSharp_AkInitializationSettings_uMemDebugLevel_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759765FC
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_0() { }

	// RVA: 0xFFFFFFFF75976600
	public static extern Void CSharp_delete_AkExternalSourceInfo(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976604
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_1(IntPtr jarg1, UInt32 jarg2, UInt32 jarg3, UInt32 jarg4) { }

	// RVA: 0xFFFFFFFF75976608
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_2(String jarg1, UInt32 jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75976654
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_3(UInt32 jarg1, UInt32 jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75976658
	public static extern Void CSharp_AkExternalSourceInfo_Clear(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597665C
	public static extern Void CSharp_AkExternalSourceInfo_Clone(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF75976660
	public static extern Int32 CSharp_AkExternalSourceInfo_GetSizeOf() { }

	// RVA: 0xFFFFFFFF75976664
	public static extern Void CSharp_AkExternalSourceInfo_iExternalSrcCookie_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976668
	public static extern UInt32 CSharp_AkExternalSourceInfo_iExternalSrcCookie_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF7597666C
	public static extern Void CSharp_AkExternalSourceInfo_idCodec_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976670
	public static extern UInt32 CSharp_AkExternalSourceInfo_idCodec_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976674
	public static extern Void CSharp_AkExternalSourceInfo_szFile_set(IntPtr jarg1, String jarg2) { }

	// RVA: 0xFFFFFFFF759766AC
	public static extern IntPtr CSharp_AkExternalSourceInfo_szFile_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759766B0
	public static extern Void CSharp_AkExternalSourceInfo_pInMemory_set(IntPtr jarg1, IntPtr jarg2) { }

	// RVA: 0xFFFFFFFF759766B4
	public static extern IntPtr CSharp_AkExternalSourceInfo_pInMemory_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759766B8
	public static extern Void CSharp_AkExternalSourceInfo_uiMemorySize_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF759766BC
	public static extern UInt32 CSharp_AkExternalSourceInfo_uiMemorySize_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759766C0
	public static extern Void CSharp_AkExternalSourceInfo_idFile_set(IntPtr jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF759766C4
	public static extern UInt32 CSharp_AkExternalSourceInfo_idFile_get(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759766C8
	public static extern Int32 CSharp_Init(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759766CC
	public static extern Int32 CSharp_InitSpatialAudio(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759766D0
	public static extern Int32 CSharp_InitCommunication(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF759766D4
	public static extern Void CSharp_Term() { }

	// RVA: 0xFFFFFFFF759766D8
	public static extern Int32 CSharp_RegisterGameObjInternal(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF759766DC
	public static extern Int32 CSharp_UnregisterGameObjInternal(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF759766E0
	public static extern Int32 CSharp_RegisterGameObjInternal_WithName(UInt64 jarg1, String jarg2) { }

	// RVA: 0xFFFFFFFF759766F0
	public static extern Int32 CSharp_SetBasePath(String jarg1) { }

	// RVA: 0xFFFFFFFF75976700
	public static extern Int32 CSharp_SetCurrentLanguage(String jarg1) { }

	// RVA: 0xFFFFFFFF75976710
	public static extern Int32 CSharp_LoadFilePackage(String jarg1, out UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976720
	public static extern Int32 CSharp_AddBasePath(String jarg1) { }

	// RVA: 0xFFFFFFFF75976730
	public static extern Int32 CSharp_SetGameName(String jarg1) { }

	// RVA: 0xFFFFFFFF75976740
	public static extern Int32 CSharp_SetDecodedBankPath(String jarg1) { }

	// RVA: 0xFFFFFFFF75976750
	public static extern Int32 CSharp_LoadAndDecodeBank(String jarg1, Boolean jarg2, out UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75976760
	public static extern Int32 CSharp_LoadAndDecodeBankFromMemory(IntPtr jarg1, UInt32 jarg2, Boolean jarg3, String jarg4, Boolean jarg5, out UInt32 jarg6) { }

	// RVA: 0xFFFFFFFF75976770
	public static extern UInt32 CSharp_PostEventOnRoom__SWIG_0(String jarg1, UInt64 jarg2, UInt32 jarg3, IntPtr jarg4, IntPtr jarg5, UInt32 jarg6, IntPtr jarg7, UInt32 jarg8) { }

	// RVA: 0xFFFFFFFF75976780
	public static extern UInt32 CSharp_PostEventOnRoom__SWIG_1(String jarg1, UInt64 jarg2, UInt32 jarg3, IntPtr jarg4, IntPtr jarg5, UInt32 jarg6, IntPtr jarg7) { }

	// RVA: 0xFFFFFFFF75976790
	public static extern UInt32 CSharp_PostEventOnRoom__SWIG_2(String jarg1, UInt64 jarg2, UInt32 jarg3, IntPtr jarg4, IntPtr jarg5) { }

	// RVA: 0xFFFFFFFF759767A0
	public static extern UInt32 CSharp_PostEventOnRoom__SWIG_3(String jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF759767B0
	public static extern IntPtr CSharp_GetCurrentLanguage() { }

	// RVA: 0xFFFFFFFF759767B4
	public static extern Int32 CSharp_UnloadFilePackage(UInt32 jarg1) { }

	// RVA: 0xFFFFFFFF759767B8
	public static extern Int32 CSharp_UnloadAllFilePackages() { }

	// RVA: 0xFFFFFFFF759767BC
	public static extern Int32 CSharp_SetObjectPosition(UInt64 jarg1, Vector3 jarg2, Vector3 jarg3, Vector3 jarg4) { }

	// RVA: 0xFFFFFFFF759767D0
	public static extern Int32 CSharp_GetSourceMultiplePlayPositions__SWIG_0(UInt32 jarg1, [Out] UInt32[] jarg2, [Out] UInt32[] jarg3, [Out] Int32[] jarg4, ref UInt32 jarg5, Boolean jarg6) { }

	// RVA: 0xFFFFFFFF75976958
	public static extern Int32 CSharp_GetSourceMultiplePlayPositions__SWIG_1(UInt32 jarg1, [Out] UInt32[] jarg2, [Out] UInt32[] jarg3, [Out] Int32[] jarg4, ref UInt32 jarg5) { }

	// RVA: 0xFFFFFFFF75976AD8
	public static extern Int32 CSharp_SetListeners(UInt64 jarg1, UInt64[] jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75976AE8
	public static extern Int32 CSharp_SetDefaultListeners(UInt64[] jarg1, UInt32 jarg2) { }

	// RVA: 0xFFFFFFFF75976AF8
	public static extern Int32 CSharp_AddOutput__SWIG_0(IntPtr jarg1, out UInt64 jarg2, UInt64[] jarg3, UInt32 jarg4) { }

	// RVA: 0xFFFFFFFF75976B08
	public static extern Int32 CSharp_AddOutput__SWIG_1(IntPtr jarg1, out UInt64 jarg2, UInt64[] jarg3) { }

	// RVA: 0xFFFFFFFF75976B18
	public static extern Int32 CSharp_AddOutput__SWIG_2(IntPtr jarg1, out UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF75976B1C
	public static extern Int32 CSharp_AddOutput__SWIG_3(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976B20
	public static extern Void CSharp_GetDefaultStreamSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976B24
	public static extern Void CSharp_GetDefaultDeviceSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976B28
	public static extern Void CSharp_GetDefaultMusicSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976B2C
	public static extern Void CSharp_GetDefaultInitSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976B30
	public static extern Void CSharp_GetDefaultPlatformInitSettings(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976B34
	public static extern UInt32 CSharp_GetMajorMinorVersion() { }

	// RVA: 0xFFFFFFFF75976B38
	public static extern UInt32 CSharp_GetSubminorBuildVersion() { }

	// RVA: 0xFFFFFFFF75976B3C
	public static extern Void CSharp_StartResourceMonitoring() { }

	// RVA: 0xFFFFFFFF75976B40
	public static extern Void CSharp_StopResourceMonitoring() { }

	// RVA: 0xFFFFFFFF75976B44
	public static extern Void CSharp_GetResourceMonitorDataSummary(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976B48
	public static extern Void CSharp_StartDeviceCapture(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF75976B4C
	public static extern Void CSharp_StopDeviceCapture(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF75976B50
	public static extern Void CSharp_ClearCaptureData() { }

	// RVA: 0xFFFFFFFF75976B54
	public static extern UInt32 CSharp_UpdateCaptureSampleCount(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF75976B58
	public static extern UInt32 CSharp_GetCaptureSamples(UInt64 jarg1, [In] [Out] Single[] jarg2, UInt32 jarg3) { }

	// RVA: 0xFFFFFFFF75976B68
	public static extern Int32 CSharp_SetRoomPortal(UInt64 jarg1, UInt64 jarg2, UInt64 jarg3, IntPtr jarg4, IntPtr jarg5, Boolean jarg6, String jarg7) { }

	// RVA: 0xFFFFFFFF75976BEC
	public static extern Int32 CSharp_SetRoom(UInt64 jarg1, IntPtr jarg2, UInt64 jarg3, String jarg4) { }

	// RVA: 0xFFFFFFFF75976C48
	public static extern Int32 CSharp_RegisterSpatialAudioListener(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF75976C4C
	public static extern Int32 CSharp_UnregisterSpatialAudioListener(UInt64 jarg1) { }

	// RVA: 0xFFFFFFFF75976C50
	public static extern Int32 CSharp_SetGeometry(UInt64 jarg1, IntPtr jarg2, UInt32 jarg3, Vector3[] jarg4, UInt32 jarg5, IntPtr jarg6, UInt32 jarg7, UInt64 jarg8, Boolean jarg9, Boolean jarg10, Boolean jarg11) { }

	// RVA: 0xFFFFFFFF75976C74
	public static extern UInt32 CSharp_PostEventOnRoom__SWIG_4(UInt32 jarg1, UInt64 jarg2, UInt32 jarg3, IntPtr jarg4, IntPtr jarg5, UInt32 jarg6, IntPtr jarg7, UInt32 jarg8) { }

	// RVA: 0xFFFFFFFF75976C78
	public static extern UInt32 CSharp_PostEventOnRoom__SWIG_5(UInt32 jarg1, UInt64 jarg2, UInt32 jarg3, IntPtr jarg4, IntPtr jarg5, UInt32 jarg6, IntPtr jarg7) { }

	// RVA: 0xFFFFFFFF75976C7C
	public static extern UInt32 CSharp_PostEventOnRoom__SWIG_6(UInt32 jarg1, UInt64 jarg2, UInt32 jarg3, IntPtr jarg4, IntPtr jarg5) { }

	// RVA: 0xFFFFFFFF75976C80
	public static extern UInt32 CSharp_PostEventOnRoom__SWIG_7(UInt32 jarg1, UInt64 jarg2) { }

	// RVA: 0xFFFFFFFF75976C84
	public static extern IntPtr CSharp_AkPlaylist_SWIGUpcast(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976C88
	public static extern IntPtr CSharp_AkMIDIPost_SWIGUpcast(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976C8C
	public static extern IntPtr CSharp_AkEventCallbackInfo_SWIGUpcast(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976C90
	public static extern IntPtr CSharp_AkMIDIEventCallbackInfo_SWIGUpcast(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976C94
	public static extern IntPtr CSharp_AkMarkerCallbackInfo_SWIGUpcast(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976C98
	public static extern IntPtr CSharp_AkDurationCallbackInfo_SWIGUpcast(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976C9C
	public static extern IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_SWIGUpcast(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976CA0
	public static extern IntPtr CSharp_AkMusicSyncCallbackInfo_SWIGUpcast(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976CA4
	public static extern IntPtr CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast(IntPtr jarg1) { }

	// RVA: 0xFFFFFFFF75976CA8
	public Void .ctor() { }

}

// Namespace: 
public class AkLogger
{
	// Fields
	private static AkLogger ms_Instance; // 0x0
	private ErrorLoggerInteropDelegate errorLoggerDelegate; // 0x10

	// Properties
	public static AkLogger Instance { get; }

	// Methods

	// RVA: 0xFFFFFFFF75973C68
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF75973D24
	public static AkLogger get_Instance() { }

	// RVA: 0xFFFFFFFF75973D64
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75973E1C
	public Void Init() { }

	// RVA: 0xFFFFFFFF75973BE0
	public static Void WwiseInternalLogError(String message) { }

	// RVA: 0xFFFFFFFF75973E20
	public static Void Message(String message) { }

	// RVA: 0xFFFFFFFF75973EA8
	public static Void Warning(String message) { }

	// RVA: 0xFFFFFFFF75973F30
	public static Void Error(String message) { }

	// RVA: 0xFFFFFFFF75973FB8
	private static Void .cctor() { }

}

// Namespace: 
public sealed class ErrorLoggerInteropDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75973D10
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75973FF4
	public virtual Void Invoke(String message) { }

	// RVA: 0xFFFFFFFF75974384
	public virtual IAsyncResult BeginInvoke(String message, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759743D4
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: MUF.Luban.Lua
public static class LuaPlugins
{
	// Fields
	private const String LUAPLUGINSDLL = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF759944C0
	public static extern Int32 luaopen_sdpxlua(IntPtr L) { }

	// RVA: 0xFFFFFFFF759944BC
	public static Int32 LoadSdpLua(IntPtr L) { }

}

// Namespace: XLua
public class MonoPInvokeCallbackAttribute
{
	// Fields
	private Type type; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF759A198C
	public Void .ctor(Type t) { }

}

// Namespace: XLua
public enum LuaTypes
{
	// Fields
	public Int32 value__; // 0x10
	public const LuaTypes LUA_TNONE = 4294967295;
	public const LuaTypes LUA_TNIL = 0;
	public const LuaTypes LUA_TNUMBER = 3;
	public const LuaTypes LUA_TSTRING = 4;
	public const LuaTypes LUA_TBOOLEAN = 1;
	public const LuaTypes LUA_TTABLE = 5;
	public const LuaTypes LUA_TFUNCTION = 6;
	public const LuaTypes LUA_TUSERDATA = 7;
	public const LuaTypes LUA_TTHREAD = 8;
	public const LuaTypes LUA_TLIGHTUSERDATA = 2;
}

// Namespace: XLua
public enum LuaGCOptions
{
	// Fields
	public Int32 value__; // 0x10
	public const LuaGCOptions LUA_GCSTOP = 0;
	public const LuaGCOptions LUA_GCRESTART = 1;
	public const LuaGCOptions LUA_GCCOLLECT = 2;
	public const LuaGCOptions LUA_GCCOUNT = 3;
	public const LuaGCOptions LUA_GCCOUNTB = 4;
	public const LuaGCOptions LUA_GCSTEP = 5;
	public const LuaGCOptions LUA_GCSETPAUSE = 6;
	public const LuaGCOptions LUA_GCSETSTEPMUL = 7;
}

// Namespace: XLua
public sealed class LuaIndexes
{
	// Fields
	internal static Byte[] strBuff; // 0x0
	internal static Int32 _LUA_REGISTRYINDEX; // 0x8

	// Properties
	public static Int32 LUA_REGISTRYINDEX { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF759A07C0
	public static Int32 get_LUA_REGISTRYINDEX() { }

	// RVA: 0xFFFFFFFF759A18A8
	public static Void set_LUA_REGISTRYINDEX(Int32 value) { }

	// RVA: 0xFFFFFFFF759A1910
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759A1918
	private static Void .cctor() { }

}

// Namespace: XLua.LuaDLL
public sealed class lua_CSFunction
{
	// Methods

	// RVA: 0xFFFFFFFF759A1584
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF759A1598
	public virtual Int32 Invoke(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A17EC
	public virtual IAsyncResult BeginInvoke(IntPtr L, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759A187C
	public virtual Int32 EndInvoke(IAsyncResult result) { }

}

// Namespace: XLua.LuaDLL
public class Lua
{
	// Fields
	private const String LUADLL = "__Internal";

	// Methods

	// RVA: 0xFFFFFFFF759A050C
	public static extern IntPtr lua_tothread(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A0510
	public static extern Int32 xlua_get_lib_version() { }

	// RVA: 0xFFFFFFFF759A0514
	public static extern Int32 lua_gc(IntPtr L, LuaGCOptions what, Int32 data) { }

	// RVA: 0xFFFFFFFF759A0518
	public static extern IntPtr lua_getupvalue(IntPtr L, Int32 funcindex, Int32 n) { }

	// RVA: 0xFFFFFFFF759A051C
	public static extern IntPtr lua_setupvalue(IntPtr L, Int32 funcindex, Int32 n) { }

	// RVA: 0xFFFFFFFF759A0520
	public static extern Int32 lua_pushthread(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A0524
	public static Boolean lua_isfunction(IntPtr L, Int32 stackPos) { }

	// RVA: 0xFFFFFFFF759A0544
	public static Boolean lua_islightuserdata(IntPtr L, Int32 stackPos) { }

	// RVA: 0xFFFFFFFF759A0560
	public static Boolean lua_istable(IntPtr L, Int32 stackPos) { }

	// RVA: 0xFFFFFFFF759A057C
	public static Boolean lua_isthread(IntPtr L, Int32 stackPos) { }

	// RVA: 0xFFFFFFFF759A0598
	public static Int32 luaL_error(IntPtr L, String message) { }

	// RVA: 0xFFFFFFFF759A061C
	public static extern Int32 lua_setfenv(IntPtr L, Int32 stackPos) { }

	// RVA: 0xFFFFFFFF759A0620
	public static extern IntPtr luaL_newstate() { }

	// RVA: 0xFFFFFFFF759A0624
	public static extern Void lua_close(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A0628
	public static extern Void luaopen_xlua(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A062C
	public static extern Void luaL_openlibs(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A0630
	public static extern UInt32 xlua_objlen(IntPtr L, Int32 stackPos) { }

	// RVA: 0xFFFFFFFF759A0634
	public static extern Void lua_createtable(IntPtr L, Int32 narr, Int32 nrec) { }

	// RVA: 0xFFFFFFFF759A0638
	public static Void lua_newtable(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A0644
	public static extern Int32 xlua_getglobal(IntPtr L, String name) { }

	// RVA: 0xFFFFFFFF759A0688
	public static extern Int32 xlua_setglobal(IntPtr L, String name) { }

	// RVA: 0xFFFFFFFF759A06CC
	public static extern Void xlua_getloaders(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A06D0
	public static extern Void lua_settop(IntPtr L, Int32 newTop) { }

	// RVA: 0xFFFFFFFF759A06D4
	public static Void lua_pop(IntPtr L, Int32 amount) { }

	// RVA: 0xFFFFFFFF759A06DC
	public static extern Void lua_insert(IntPtr L, Int32 newTop) { }

	// RVA: 0xFFFFFFFF759A06E0
	public static extern Void lua_remove(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A06E4
	public static extern Int32 lua_rawget(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A06E8
	public static extern Void lua_rawset(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A06EC
	public static extern Int32 lua_setmetatable(IntPtr L, Int32 objIndex) { }

	// RVA: 0xFFFFFFFF759A06F0
	public static extern Int32 lua_rawequal(IntPtr L, Int32 index1, Int32 index2) { }

	// RVA: 0xFFFFFFFF759A06F4
	public static extern Void lua_pushvalue(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A06F8
	public static extern Void lua_pushcclosure(IntPtr L, IntPtr fn, Int32 n) { }

	// RVA: 0xFFFFFFFF759A06FC
	public static extern Void lua_replace(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A0700
	public static extern Int32 lua_gettop(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A0540
	public static extern LuaTypes lua_type(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A0704
	public static Boolean lua_isnil(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A0720
	public static extern Boolean lua_isnumber(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A073C
	public static Boolean lua_isboolean(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A0758
	public static extern Int32 luaL_ref(IntPtr L, Int32 registryIndex) { }

	// RVA: 0xFFFFFFFF759A075C
	public static Int32 luaL_ref(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A0828
	public static extern Void xlua_rawgeti(IntPtr L, Int32 tableIndex, Int64 index) { }

	// RVA: 0xFFFFFFFF759A082C
	public static extern Void xlua_rawseti(IntPtr L, Int32 tableIndex, Int64 index) { }

	// RVA: 0xFFFFFFFF759A0830
	public static Void lua_getref(IntPtr L, Int32 reference) { }

	// RVA: 0xFFFFFFFF759A08A4
	public static extern Int32 pcall_prepare(IntPtr L, Int32 error_func_ref, Int32 func_ref) { }

	// RVA: 0xFFFFFFFF759A08A8
	public static extern Void luaL_unref(IntPtr L, Int32 registryIndex, Int32 reference) { }

	// RVA: 0xFFFFFFFF759A08AC
	public static Void lua_unref(IntPtr L, Int32 reference) { }

	// RVA: 0xFFFFFFFF759A0920
	public static extern Boolean lua_isstring(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A093C
	public static extern Boolean lua_isinteger(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A0958
	public static extern Void lua_pushnil(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A095C
	public static Void lua_pushstdcallcfunction(IntPtr L, lua_CSFunction function, Int32 n) { }

	// RVA: 0xFFFFFFFF759A09E4
	public static extern Int32 xlua_upvalueindex(Int32 n) { }

	// RVA: 0xFFFFFFFF759A09E8
	public static extern Int32 lua_pcall(IntPtr L, Int32 nArgs, Int32 nResults, Int32 errfunc) { }

	// RVA: 0xFFFFFFFF759A09EC
	public static extern Double lua_tonumber(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A09F0
	public static extern Int32 xlua_tointeger(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A09F4
	public static extern UInt32 xlua_touint(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A09F8
	public static extern Boolean lua_toboolean(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A0A14
	public static extern IntPtr lua_topointer(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A0A18
	public static extern IntPtr lua_tolstring(IntPtr L, Int32 index, out IntPtr strLen) { }

	// RVA: 0xFFFFFFFF759A0A1C
	public static String lua_tostring(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A0B10
	public static extern IntPtr lua_atpanic(IntPtr L, lua_CSFunction panicf) { }

	// RVA: 0xFFFFFFFF759A0B3C
	public static extern Void lua_pushnumber(IntPtr L, Double number) { }

	// RVA: 0xFFFFFFFF759A0B40
	public static extern Void lua_pushboolean(IntPtr L, Boolean value) { }

	// RVA: 0xFFFFFFFF759A0B44
	public static extern Void xlua_pushinteger(IntPtr L, Int32 value) { }

	// RVA: 0xFFFFFFFF759A0B48
	public static extern Void xlua_pushuint(IntPtr L, UInt32 value) { }

	// RVA: 0xFFFFFFFF759A0B4C
	public static Void lua_pushstring(IntPtr L, String str) { }

	// RVA: 0xFFFFFFFF759A0C90
	public static extern Void xlua_pushlstring(IntPtr L, Byte[] str, Int32 size) { }

	// RVA: 0xFFFFFFFF759A0CA0
	public static extern Void xlua_pushlstring(IntPtr L, Byte* str, Int32 size) { }

	// RVA: 0xFFFFFFFF759A0CA4
	public static Void xlua_pushasciistring(IntPtr L, String str) { }

	// RVA: 0xFFFFFFFF759A0DC0
	public static Void lua_pushstring(IntPtr L, Byte[] str) { }

	// RVA: 0xFFFFFFFF759A0DD4
	public static Void lua_pushstring(IntPtr L, Byte[] str, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF759A0E14
	public static Byte[] lua_tobytes(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A0EDC
	public static extern Int32 luaL_newmetatable(IntPtr L, String meta) { }

	// RVA: 0xFFFFFFFF759A0F20
	public static extern Int32 xlua_pgettable(IntPtr L, Int32 idx) { }

	// RVA: 0xFFFFFFFF759A0F24
	public static extern Int32 xlua_psettable(IntPtr L, Int32 idx) { }

	// RVA: 0xFFFFFFFF759A0F28
	public static Void luaL_getmetatable(IntPtr L, String meta) { }

	// RVA: 0xFFFFFFFF759A0FA4
	public static extern Int32 xluaL_loadbuffer(IntPtr L, Byte[] buff, Int32 size, String name) { }

	// RVA: 0xFFFFFFFF759A1008
	public static Int32 luaL_loadbuffer(IntPtr L, String buff, String name) { }

	// RVA: 0xFFFFFFFF759A1094
	public static extern Int32 xlua_tocsobj_safe(IntPtr L, Int32 obj) { }

	// RVA: 0xFFFFFFFF759A1098
	public static extern Int32 xlua_tocsobj_fast(IntPtr L, Int32 obj) { }

	// RVA: 0xFFFFFFFF759A109C
	public static Int32 lua_error(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A10B8
	public static extern Boolean lua_checkstack(IntPtr L, Int32 extra) { }

	// RVA: 0xFFFFFFFF759A10D4
	public static extern Int32 lua_next(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759A10D8
	public static extern Void lua_pushlightuserdata(IntPtr L, IntPtr udata) { }

	// RVA: 0xFFFFFFFF759A10DC
	public static extern IntPtr xlua_tag() { }

	// RVA: 0xFFFFFFFF759A10E0
	public static extern Void luaL_where(IntPtr L, Int32 level) { }

	// RVA: 0xFFFFFFFF759A10E4
	public static extern Int32 xlua_tryget_cachedud(IntPtr L, Int32 key, Int32 cache_ref) { }

	// RVA: 0xFFFFFFFF759A10E8
	public static extern Void xlua_pushcsobj(IntPtr L, Int32 key, Int32 meta_ref, Boolean need_cache, Int32 cache_ref) { }

	// RVA: 0xFFFFFFFF759A10EC
	public static extern Int32 gen_obj_indexer(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A10F0
	public static extern Int32 gen_obj_newindexer(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A10F4
	public static extern Int32 gen_cls_indexer(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A10F8
	public static extern Int32 gen_cls_newindexer(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A10FC
	public static extern Int32 get_error_func_ref(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A1100
	public static extern Int32 load_error_func(IntPtr L, Int32 Ref) { }

	// RVA: 0xFFFFFFFF759A1104
	public static extern Int32 luaopen_i64lib(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A1108
	public static extern Int32 luaopen_socket_core(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A110C
	public static extern Void lua_pushint64(IntPtr L, Int64 n) { }

	// RVA: 0xFFFFFFFF759A1110
	public static extern Void lua_pushuint64(IntPtr L, UInt64 n) { }

	// RVA: 0xFFFFFFFF759A1114
	public static extern Boolean lua_isint64(IntPtr L, Int32 idx) { }

	// RVA: 0xFFFFFFFF759A1130
	public static extern Boolean lua_isuint64(IntPtr L, Int32 idx) { }

	// RVA: 0xFFFFFFFF759A114C
	public static extern Int64 lua_toint64(IntPtr L, Int32 idx) { }

	// RVA: 0xFFFFFFFF759A1150
	public static extern UInt64 lua_touint64(IntPtr L, Int32 idx) { }

	// RVA: 0xFFFFFFFF759A09E0
	public static extern Void xlua_push_csharp_function(IntPtr L, IntPtr fn, Int32 n) { }

	// RVA: 0xFFFFFFFF759A05D8
	public static extern Int32 xlua_csharp_str_error(IntPtr L, String message) { }

	// RVA: 0xFFFFFFFF759A10B4
	public static extern Int32 xlua_csharp_error(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A1154
	public static extern Boolean xlua_pack_int8_t(IntPtr buff, Int32 offset, Byte field) { }

	// RVA: 0xFFFFFFFF759A1170
	public static extern Boolean xlua_unpack_int8_t(IntPtr buff, Int32 offset, out Byte field) { }

	// RVA: 0xFFFFFFFF759A118C
	public static extern Boolean xlua_pack_int16_t(IntPtr buff, Int32 offset, Int16 field) { }

	// RVA: 0xFFFFFFFF759A11A8
	public static extern Boolean xlua_unpack_int16_t(IntPtr buff, Int32 offset, out Int16 field) { }

	// RVA: 0xFFFFFFFF759A11C4
	public static extern Boolean xlua_pack_int32_t(IntPtr buff, Int32 offset, Int32 field) { }

	// RVA: 0xFFFFFFFF759A11E0
	public static extern Boolean xlua_unpack_int32_t(IntPtr buff, Int32 offset, out Int32 field) { }

	// RVA: 0xFFFFFFFF759A11FC
	public static extern Boolean xlua_pack_int64_t(IntPtr buff, Int32 offset, Int64 field) { }

	// RVA: 0xFFFFFFFF759A1218
	public static extern Boolean xlua_unpack_int64_t(IntPtr buff, Int32 offset, out Int64 field) { }

	// RVA: 0xFFFFFFFF759A1234
	public static extern Boolean xlua_pack_float(IntPtr buff, Int32 offset, Single field) { }

	// RVA: 0xFFFFFFFF759A1250
	public static extern Boolean xlua_unpack_float(IntPtr buff, Int32 offset, out Single field) { }

	// RVA: 0xFFFFFFFF759A126C
	public static extern Boolean xlua_pack_double(IntPtr buff, Int32 offset, Double field) { }

	// RVA: 0xFFFFFFFF759A1288
	public static extern Boolean xlua_unpack_double(IntPtr buff, Int32 offset, out Double field) { }

	// RVA: 0xFFFFFFFF759A12A4
	public static extern IntPtr xlua_pushstruct(IntPtr L, UInt32 size, Int32 meta_ref) { }

	// RVA: 0xFFFFFFFF759A12A8
	public static extern Void xlua_pushcstable(IntPtr L, UInt32 field_count, Int32 meta_ref) { }

	// RVA: 0xFFFFFFFF759A12AC
	public static extern IntPtr lua_touserdata(IntPtr L, Int32 idx) { }

	// RVA: 0xFFFFFFFF759A12B0
	public static extern Int32 xlua_gettypeid(IntPtr L, Int32 idx) { }

	// RVA: 0xFFFFFFFF759A12B4
	public static extern Int32 xlua_get_registry_index() { }

	// RVA: 0xFFFFFFFF759A12B8
	public static extern Int32 xlua_pgettable_bypath(IntPtr L, Int32 idx, String path) { }

	// RVA: 0xFFFFFFFF759A130C
	public static extern Int32 xlua_psettable_bypath(IntPtr L, Int32 idx, String path) { }

	// RVA: 0xFFFFFFFF759A1360
	public static extern Boolean xlua_pack_float2(IntPtr buff, Int32 offset, Single f1, Single f2) { }

	// RVA: 0xFFFFFFFF759A137C
	public static extern Boolean xlua_unpack_float2(IntPtr buff, Int32 offset, out Single f1, out Single f2) { }

	// RVA: 0xFFFFFFFF759A1398
	public static extern Boolean xlua_pack_float3(IntPtr buff, Int32 offset, Single f1, Single f2, Single f3) { }

	// RVA: 0xFFFFFFFF759A13B4
	public static extern Boolean xlua_unpack_float3(IntPtr buff, Int32 offset, out Single f1, out Single f2, out Single f3) { }

	// RVA: 0xFFFFFFFF759A13D0
	public static extern Boolean xlua_pack_float4(IntPtr buff, Int32 offset, Single f1, Single f2, Single f3, Single f4) { }

	// RVA: 0xFFFFFFFF759A13EC
	public static extern Boolean xlua_unpack_float4(IntPtr buff, Int32 offset, out Single f1, out Single f2, out Single f3, out Single f4) { }

	// RVA: 0xFFFFFFFF759A1408
	public static extern Boolean xlua_pack_float5(IntPtr buff, Int32 offset, Single f1, Single f2, Single f3, Single f4, Single f5) { }

	// RVA: 0xFFFFFFFF759A1424
	public static extern Boolean xlua_unpack_float5(IntPtr buff, Int32 offset, out Single f1, out Single f2, out Single f3, out Single f4, out Single f5) { }

	// RVA: 0xFFFFFFFF759A1440
	public static extern Boolean xlua_pack_float6(IntPtr buff, Int32 offset, Single f1, Single f2, Single f3, Single f4, Single f5, Single f6) { }

	// RVA: 0xFFFFFFFF759A145C
	public static extern Boolean xlua_unpack_float6(IntPtr buff, Int32 offset, out Single f1, out Single f2, out Single f3, out Single f4, out Single f5, out Single f6) { }

	// RVA: 0xFFFFFFFF759A1478
	public static extern Boolean xlua_pack_decimal(IntPtr buff, Int32 offset, ref Decimal dec) { }

	// RVA: 0xFFFFFFFF759A1494
	public static extern Boolean xlua_unpack_decimal(IntPtr buff, Int32 offset, out Byte scale, out Byte sign, out Int32 hi32, out UInt64 lo64) { }

	// RVA: 0xFFFFFFFF759A14B0
	public static Boolean xlua_is_eq_str(IntPtr L, Int32 index, String str) { }

	// RVA: 0xFFFFFFFF759A1518
	public static extern Boolean xlua_is_eq_str(IntPtr L, Int32 index, String str, Int32 str_len) { }

	// RVA: 0xFFFFFFFF759A1578
	public static extern IntPtr xlua_gl(IntPtr L) { }

	// RVA: 0xFFFFFFFF759A157C
	public Void .ctor() { }

}

// Namespace: Hades
public class DownloadUtil
{
	// Methods

	// RVA: 0xFFFFFFFF759858FC
	public static String DictionaryToJson(Dictionary<T0, T1> dic) { }

	// RVA: 0xFFFFFFFF75985E7C
	public Void .ctor() { }

}

// Namespace: Hades
public enum ServerRegion
{
	// Fields
	public Int32 value__; // 0x10
	public const ServerRegion CN = 0;
	public const ServerRegion VA = 1;
	public const ServerRegion SG = 2;
}

// Namespace: Hades
public enum LogPriority
{
	// Fields
	public Int32 value__; // 0x10
	public const LogPriority VERBOSE = 0;
	public const LogPriority DEBUG = 1;
	public const LogPriority INFO = 2;
	public const LogPriority WARN = 3;
	public const LogPriority ERROR = 4;
}

// Namespace: Hades
public sealed class DownloadReportEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF759846DC
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF759846F0
	public virtual Void Invoke(String eventName, String eventParam) { }

	// RVA: 0xFFFFFFFF75984ABC
	public virtual IAsyncResult BeginInvoke(String eventName, String eventParam, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75984B18
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class DownloadStartEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75985C28
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597E558
	public virtual Void Invoke(DownloadInfo downloadInfo) { }

	// RVA: 0xFFFFFFFF75985C3C
	public virtual IAsyncResult BeginInvoke(DownloadInfo downloadInfo, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75985C8C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class DownloadPauseEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF759845FC
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597E8E8
	public virtual Void Invoke(DownloadInfo downloadInfo) { }

	// RVA: 0xFFFFFFFF75984610
	public virtual IAsyncResult BeginInvoke(DownloadInfo downloadInfo, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75984660
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class DownloadDeleteEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75980998
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597EC78
	public virtual Void Invoke(DownloadInfo downloadInfo) { }

	// RVA: 0xFFFFFFFF759809AC
	public virtual IAsyncResult BeginInvoke(DownloadInfo downloadInfo, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759809FC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class DownloadProgressEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF7598466C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597F008
	public virtual Void Invoke(DownloadInfo downloadInfo) { }

	// RVA: 0xFFFFFFFF75984680
	public virtual IAsyncResult BeginInvoke(DownloadInfo downloadInfo, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759846D0
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class DownloadSuccessEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75985C98
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597F398
	public virtual Void Invoke(DownloadInfo downloadInfo) { }

	// RVA: 0xFFFFFFFF75985CAC
	public virtual IAsyncResult BeginInvoke(DownloadInfo downloadInfo, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75985CFC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class DownloadFailedEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75980B60
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597F728
	public virtual Void Invoke(DownloadInfo downloadInfo) { }

	// RVA: 0xFFFFFFFF75980B74
	public virtual IAsyncResult BeginInvoke(DownloadInfo downloadInfo, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75980BC4
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class DownloadMultiStartEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75983068
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7598307C
	public virtual Void Invoke(DownloadMultiInfo downloadInfo) { }

	// RVA: 0xFFFFFFFF7598340C
	public virtual IAsyncResult BeginInvoke(DownloadMultiInfo downloadInfo, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7598345C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class DownloadMultiPauseEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75982868
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7598287C
	public virtual Void Invoke(DownloadMultiInfo downloadInfo) { }

	// RVA: 0xFFFFFFFF75982C0C
	public virtual IAsyncResult BeginInvoke(DownloadMultiInfo downloadInfo, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75982C5C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class DownloadMultiDeleteEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75982068
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7598207C
	public virtual Void Invoke(DownloadMultiInfo downloadInfo) { }

	// RVA: 0xFFFFFFFF7598240C
	public virtual IAsyncResult BeginInvoke(DownloadMultiInfo downloadInfo, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7598245C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class DownloadMultiProgressEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75982C68
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75982C7C
	public virtual Void Invoke(DownloadMultiInfo downloadInfo) { }

	// RVA: 0xFFFFFFFF7598300C
	public virtual IAsyncResult BeginInvoke(DownloadMultiInfo downloadInfo, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7598305C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class DownloadMultiSuccessEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75983468
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7598347C
	public virtual Void Invoke(DownloadMultiInfo downloadInfo) { }

	// RVA: 0xFFFFFFFF7598380C
	public virtual IAsyncResult BeginInvoke(DownloadMultiInfo downloadInfo, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7598385C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class DownloadMultiFailedEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75982468
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7598247C
	public virtual Void Invoke(DownloadMultiInfo downloadInfo) { }

	// RVA: 0xFFFFFFFF7598280C
	public virtual IAsyncResult BeginInvoke(DownloadMultiInfo downloadInfo, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7598285C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class DownloadBatchStartEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF7598054C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75980560
	public virtual Void Invoke(Int32 batchId) { }

	// RVA: 0xFFFFFFFF759807B4
	public virtual IAsyncResult BeginInvoke(Int32 batchId, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75980844
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class DownloadBatchProgressEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF759801F0
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75980204
	public virtual Void Invoke(Int32 batchId, Int64 curBytes, Int64 totalBytes) { }

	// RVA: 0xFFFFFFFF75980488
	public virtual IAsyncResult BeginInvoke(Int32 batchId, Int64 curBytes, Int64 totalBytes, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75980540
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class DownloadBatchEndEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF7597FEA0
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597FEB4
	public virtual Void Invoke(Int32 batchId, Int32 status, String errMsg) { }

	// RVA: 0xFFFFFFFF75980138
	public virtual IAsyncResult BeginInvoke(Int32 batchId, Int32 status, String errMsg, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759801E4
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public static class Download
{
	// Fields
	private static DownloadService _service; // 0x0

	// Properties
	public static IDownloadService Service { get; }

	// Methods

	// RVA: 0xFFFFFFFF7597D84C
	public static IDownloadService get_Service() { }

	// RVA: 0xFFFFFFFF7597D8AC
	private static Void .cctor() { }

}

// Namespace: Hades
public interface IDownloadBaseTask
{
	// Methods

	// RVA: -1
	public abstract Void add_DownloadStartEvent(DownloadStartEventHandler value) { }

	// RVA: -1
	public abstract Void remove_DownloadStartEvent(DownloadStartEventHandler value) { }

	// RVA: -1
	public abstract Void add_DownloadPauseEvent(DownloadPauseEventHandler value) { }

	// RVA: -1
	public abstract Void remove_DownloadPauseEvent(DownloadPauseEventHandler value) { }

	// RVA: -1
	public abstract Void add_DownloadDeleteEvent(DownloadDeleteEventHandler value) { }

	// RVA: -1
	public abstract Void remove_DownloadDeleteEvent(DownloadDeleteEventHandler value) { }

	// RVA: -1
	public abstract Void add_DownloadProgressEvent(DownloadProgressEventHandler value) { }

	// RVA: -1
	public abstract Void remove_DownloadProgressEvent(DownloadProgressEventHandler value) { }

	// RVA: -1
	public abstract Void add_DownloadSuccessEvent(DownloadSuccessEventHandler value) { }

	// RVA: -1
	public abstract Void remove_DownloadSuccessEvent(DownloadSuccessEventHandler value) { }

	// RVA: -1
	public abstract Void add_DownloadFailedEvent(DownloadFailedEventHandler value) { }

	// RVA: -1
	public abstract Void remove_DownloadFailedEvent(DownloadFailedEventHandler value) { }

	// RVA: -1
	public abstract Int32 GetTaskId() { }

	// RVA: -1
	public abstract Void Start() { }

	// RVA: -1
	public abstract Void Pause() { }

	// RVA: -1
	public abstract Void Cancel(Boolean deleteFile) { }

	// RVA: -1
	public abstract Boolean IsDownloading() { }

	// RVA: -1
	public abstract Void SetThrottleNetSpeed(Int64 throttleNetSpeed, Int32 throttleSmoothness, Boolean throttleOnlyForeground) { }

	// RVA: -1
	public abstract Void SetOnlyWifi(Boolean onlyWifi) { }

}

// Namespace: Hades
public interface IDownloadTask
{
	// Methods

	// RVA: -1
	public abstract DownloadInfo QueryDownloadInfo() { }

}

// Namespace: Hades
public interface IDownloadMultiTask
{
	// Methods

	// RVA: -1
	public abstract Void add_DownloadMultiStartEvent(DownloadMultiStartEventHandler value) { }

	// RVA: -1
	public abstract Void remove_DownloadMultiStartEvent(DownloadMultiStartEventHandler value) { }

	// RVA: -1
	public abstract Void add_DownloadMultiPauseEvent(DownloadMultiPauseEventHandler value) { }

	// RVA: -1
	public abstract Void remove_DownloadMultiPauseEvent(DownloadMultiPauseEventHandler value) { }

	// RVA: -1
	public abstract Void add_DownloadMultiDeleteEvent(DownloadMultiDeleteEventHandler value) { }

	// RVA: -1
	public abstract Void remove_DownloadMultiDeleteEvent(DownloadMultiDeleteEventHandler value) { }

	// RVA: -1
	public abstract Void add_DownloadMultiProgressEvent(DownloadMultiProgressEventHandler value) { }

	// RVA: -1
	public abstract Void remove_DownloadMultiProgressEvent(DownloadMultiProgressEventHandler value) { }

	// RVA: -1
	public abstract Void add_DownloadMultiSuccessEvent(DownloadMultiSuccessEventHandler value) { }

	// RVA: -1
	public abstract Void remove_DownloadMultiSuccessEvent(DownloadMultiSuccessEventHandler value) { }

	// RVA: -1
	public abstract Void add_DownloadMultiFailedEvent(DownloadMultiFailedEventHandler value) { }

	// RVA: -1
	public abstract Void remove_DownloadMultiFailedEvent(DownloadMultiFailedEventHandler value) { }

	// RVA: -1
	public abstract DownloadMultiInfo QueryDownloadInfo() { }

}

// Namespace: Hades
public interface IDownloadService
{
	// Methods

	// RVA: -1
	public abstract Void Init(DownloadDepend depend) { }

	// RVA: -1
	public abstract IDownloadTask CreateTask(DownloadTaskConfig config) { }

	// RVA: -1
	public abstract IDownloadMultiTask CreateMultiTask(DownloadMultiTaskConfig multiConfig) { }

	// RVA: -1
	public abstract Void SetLogLevel(LogPriority logLevel) { }

	// RVA: -1
	public abstract Void SetThrottleNetSpeed(Int32 throttleNetSpeed, Boolean throttleOnlyForeground, Int32 throttleSmoothness) { }

}

// Namespace: Hades
public enum DownloadStatus
{
	// Fields
	public Int32 value__; // 0x10
	public const DownloadStatus Idle = 0;
	public const DownloadStatus Prepare = 1;
	public const DownloadStatus Start = 2;
	public const DownloadStatus Connected = 3;
	public const DownloadStatus Progress = 4;
	public const DownloadStatus Retry = 5;
	public const DownloadStatus Failed = 4294967295;
	public const DownloadStatus Paused = 4294967294;
	public const DownloadStatus Succeed = 4294967293;
	public const DownloadStatus Canceled = 4294967292;
}

// Namespace: Hades
public class DownloadDepend
{
	// Fields
	public String appId; // 0x10
	public String appChannel; // 0x18
	public String deviceId; // 0x20
	public ServerRegion serverRegion; // 0x28
	public String downloadSetting; // 0x30
	public DownloadReportEventHandler reportEventHandler; // 0x38
	public String hadesSoPath; // 0x40

	// Methods

	// RVA: 0xFFFFFFFF75980A08
	public Boolean CheckParam() { }

	// RVA: 0xFFFFFFFF75980AE4
	public Void .ctor() { }

}

// Namespace: Hades
public class DownloadTaskConfig
{
	// Fields
	public String URL; // 0x10
	public String Md5; // 0x18
	public String SavePath; // 0x20
	public String Name; // 0x28
	public Int64 StartOffset; // 0x30
	public Int64 EndOffset; // 0x38
	public Int32 RetryCount; // 0x40
	public Int32 BackupHostRetryCount; // 0x44
	public List<T0> BackupHosts; // 0x48
	public Boolean OnlyWifi; // 0x50
	public Int64 ThrottleNetSpeed; // 0x58
	public Int32 ThrottleSmoothness; // 0x60
	public Boolean ThrottleOnlyForeground; // 0x64
	public Int64 ExpectFileLength; // 0x68
	public Boolean OverWrite; // 0x70
	public String DownloadSetting; // 0x78
	public Boolean ShowNotification; // 0x80
	public String NotificationName; // 0x88
	public Dictionary<T0, T1> RequestHeaders; // 0x90
	public Boolean AutoResume; // 0x98

	// Methods

	// RVA: 0xFFFFFFFF75985DBC
	public Void .ctor() { }

}

// Namespace: Hades
public class DownloadMultiTaskConfig
{
	// Fields
	public List<T0> TaskConfigs; // 0x10
	public Boolean ShowNotification; // 0x18
	public String NotificationName; // 0x20
	public Boolean AutoResume; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF7598456C
	public Void .ctor() { }

}

// Namespace: Hades
public class DownloadInfo
{
	// Fields
	public Int32 TaskId; // 0x10
	public DownloadStatus Status; // 0x14
	public String FileName; // 0x18
	public String FilePath; // 0x20
	public String Md5; // 0x28
	public String URL; // 0x30
	public String CurrentHost; // 0x38
	public Int64 DownloadedSize; // 0x40
	public Int64 TotalSize; // 0x48
	public Int32 TransientSpeed; // 0x50
	public Int32 ErrorCode; // 0x54
	public String ErrorMsg; // 0x58
	public Boolean ShowNotification; // 0x60
	public String NotificationName; // 0x68

	// Methods

	// RVA: 0xFFFFFFFF7597E300
	public Void .ctor() { }

}

// Namespace: Hades
public class DownloadMultiInfo
{
	// Fields
	public Int32 TaskId; // 0x10
	public DownloadStatus Status; // 0x14
	public Boolean ShowNotification; // 0x18
	public String NotificationName; // 0x20
	public Int64 DownloadedSize; // 0x28
	public Int64 TotalSize; // 0x30
	public Int32 TotalFilesCount; // 0x38
	public Int32 DownloadedFilesCount; // 0x3C
	public Int32 transientSpeed; // 0x40
	public Int32 failedId; // 0x44
	public Int32 ErrorCode; // 0x48
	public String ErrorMsg; // 0x50

	// Methods

	// RVA: 0xFFFFFFFF7597E308
	public Void .ctor() { }

}

// Namespace: Hades
public class DownloadBatchInfo
{
	// Fields
	public Int32 BatchId; // 0x10
	public DownloadStatus Status; // 0x14
	public Int32 Priority; // 0x18
	public Int64 DownloadedSize; // 0x20
	public Int64 TotalSize; // 0x28
	public Int32 ErrorCode; // 0x30
	public String ErrorMsg; // 0x38

	// Methods

	// RVA: 0xFFFFFFFF7597E310
	public Void .ctor() { }

}

// Namespace: Hades
public class HadesDownloadErrorCode
{
	// Fields
	public const Int32 kNoError = 0;
	public const Int32 kPause = 1;
	public const Int32 kInterrupt = 2;
	public const Int32 kNoStoragePermission = 4294466296;
	public const Int32 kInsufficientSpace = 4294466295;
	public const Int32 kSavePathCreateFailed = 4294466196;
	public const Int32 kTempFileNotExist = 4294466195;
	public const Int32 kTempToTargetFailed = 4294466194;
	public const Int32 kUnknownLocalIo = 4294465297;
	public const Int32 kUrlInvalid = 4294465296;
	public const Int32 kMd5Invalid = 4294465196;
	public const Int32 kUnknownCheck = 4294464297;
	public const Int32 kNetworkNotAvailable = 4294464296;
	public const Int32 kOnlyWifi = 4294464295;
	public const Int32 kHttpsError = 4294464196;
	public const Int32 kConnectTimeOut = 4294464096;
	public const Int32 kReadTimeOut = 4294464095;
	public const Int32 kUnknownHost = 4294464086;
	public const Int32 kUnknownNetworkError = 4294463297;
	public const Int32 kHttp200 = 4294463096;
	public const Int32 kHttp401 = 4294462895;
	public const Int32 kHttp403 = 4294462893;
	public const Int32 kHttp404 = 4294462892;
	public const Int32 kHttp416 = 4294462880;
	public const Int32 kHttp500 = 4294462796;
	public const Int32 kHttp501 = 4294462795;
	public const Int32 kHttpUnknownError = 4294462297;
	public const Int32 kUnKnown = 4294457297;

	// Methods

	// RVA: 0xFFFFFFFF75986CE8
	public Void .ctor() { }

}

// Namespace: Hades
public class DownloadCPPInfo
{
	// Fields
	public Int32 id; // 0x10
	public String url; // 0x18
	public String md5; // 0x20
	public String file_name; // 0x28
	public String save_path; // 0x30
	public Int32 transient_speed; // 0x38
	public DownloadStatus status; // 0x3C
	public Int32 err_code; // 0x40
	public String err_msg; // 0x48
	public String cur_host; // 0x50
	public Int64 cur_bytes; // 0x58
	public Int64 total_bytes; // 0x60
	public Boolean show_notification; // 0x68
	public String notification_name; // 0x70

	// Methods

	// RVA: 0xFFFFFFFF75980850
	public static DownloadCPPInfo FromString(String jsonString) { }

	// RVA: 0xFFFFFFFF75980990
	public Void .ctor() { }

}

// Namespace: Hades
public class DownloadMultiCPPInfo
{
	// Fields
	public Int32 id; // 0x10
	public DownloadStatus status; // 0x14
	public Int32 err_code; // 0x18
	public String err_msg; // 0x20
	public Int32 failed_id; // 0x28
	public Int64 cur_bytes; // 0x30
	public Int64 total_bytes; // 0x38
	public Int32 total_files_count; // 0x40
	public Int32 downloaded_files_count; // 0x44
	public Int32 transient_speed; // 0x48
	public Boolean show_notification; // 0x4C
	public String notification_name; // 0x50

	// Methods

	// RVA: 0xFFFFFFFF75981F20
	public static DownloadMultiCPPInfo FromString(String jsonString) { }

	// RVA: 0xFFFFFFFF75982060
	public Void .ctor() { }

}

// Namespace: Hades
public class DownloadBatchCPPInfo
{
	// Fields
	public Int32 batch_id; // 0x10
	public DownloadStatus status; // 0x14
	public Int32 priority; // 0x18
	public Int32 err_code; // 0x1C
	public String err_msg; // 0x20
	public Int64 cur_bytes; // 0x28
	public Int64 total_bytes; // 0x30

	// Methods

	// RVA: 0xFFFFFFFF7597FD58
	public static DownloadBatchCPPInfo FromString(String jsonString) { }

	// RVA: 0xFFFFFFFF7597FE98
	public Void .ctor() { }

}

// Namespace: Hades
public class DownloadInterface
{
	// Fields
	public static DownloadCallback downloadCallback; // 0x0
	public static DownloadEventCallback eventCallback; // 0x8
	private static List<T0> downloadCallbackActs; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75980DC0
	public static Int32 InitGMDownload(String initParams) { }

	// RVA: 0xFFFFFFFF75980DC8
	public static Int32 Hades_Downloader_InitWinDownload(String initParams) { }

	// RVA: 0xFFFFFFFF75980DD0
	public static Int32 Hades_Downloader_InitMacDownload(String initParams) { }

	// RVA: 0xFFFFFFFF75980DD8
	public static Void Hades_Downloader_UnityWinInit(Int32 type) { }

	// RVA: 0xFFFFFFFF75980DDC
	public static Void Hades_Downloader_Update() { }

	// RVA: 0xFFFFFFFF7597FB14
	public static Void Hades_Downloader_Start(Int32 id) { }

	// RVA: 0xFFFFFFFF7597FB74
	public static Void Hades_Downloader_Pause(Int32 id) { }

	// RVA: 0xFFFFFFFF7597FBD4
	public static Void Hades_Downloader_Cancel(Int32 id, Boolean deleteFile) { }

	// RVA: 0xFFFFFFFF7597FC30
	public static Boolean Hades_Downloader_IsDownloading(Int32 id) { }

	// RVA: 0xFFFFFFFF7597FD50
	public static Int32 Hades_Downloader_GetStatus(Int32 id) { }

	// RVA: 0xFFFFFFFF75980DE0
	public static Int32 Hades_Downloader_isDownloadingStatus(Int32 id, Int32 status) { }

	// RVA: 0xFFFFFFFF75980DE8
	public static Void Hades_Downloader_SetDownloadCallBack(DownloadCallback callback) { }

	// RVA: 0xFFFFFFFF75980DEC
	public static Void Hades_Downloader_SetDownloadEventCallBack(DownloadEventCallback callback) { }

	// RVA: 0xFFFFFFFF7597FC94
	public static Void Hades_Downloader_SetThrottleNetSpeed(Int32 id, Int32 throttleNetSpeed, Int32 throttleSmoothness, Boolean throttleOnlyForeground) { }

	// RVA: 0xFFFFFFFF7597FCF4
	public static Void Hades_Downloader_SetOnlyWifi(Int32 id, Boolean onlyWifi) { }

	// RVA: 0xFFFFFFFF75980DF0
	public static IntPtr Hades_Downloader_GetDownloadInfo(Int32 id) { }

	// RVA: 0xFFFFFFFF75980DF8
	public static Void Hades_Downloader_ReleaseCharArray(IntPtr strPtr) { }

	// RVA: 0xFFFFFFFF75980DFC
	public static IntPtr Hades_Downloader_GetMultiDownloadInfo(Int32 id) { }

	// RVA: 0xFFFFFFFF75980E04
	public static Int32 Hades_Downloader_GetDownloadId(String url, String md5, String save_path, String name) { }

	// RVA: 0xFFFFFFFF75980E0C
	public static Int32 Hades_Downloader_Download(String downloadConfigJson) { }

	// RVA: 0xFFFFFFFF75980E14
	public static Int32 Hades_Downloader_Create(String downloadConfigJson) { }

	// RVA: 0xFFFFFFFF75980E1C
	public static Int32 Hades_Downloader_CreateMultiTask(String downloadConfigJson) { }

	// RVA: 0xFFFFFFFF75980E24
	public static Int32 Hades_Downloader_SetLogLevel(Int32 logLevel) { }

	// RVA: 0xFFFFFFFF75980E2C
	public static Void Init(String initParams) { }

	// RVA: 0xFFFFFFFF759810B0
	private static Void UnityEditorInit(String initParams) { }

	// RVA: 0xFFFFFFFF75980EC0
	private static Void NoUnityEditorInit(String initParams) { }

	// RVA: 0xFFFFFFFF75981010
	public static Void SetupDownloadCallBack() { }

	// RVA: 0xFFFFFFFF759810C8
	public static Void RegistEventCallBack() { }

	// RVA: 0xFFFFFFFF7598117C
	public static Void InitAndroid(String initParams) { }

	// RVA: 0xFFFFFFFF75980BD0
	public static Void HandleDownloadCallBackFromNative(Int32 id, Int32 status, String message) { }

	// RVA: 0xFFFFFFFF75980CC4
	public static Void HandleDownloadEventCallbackFromNative(String eventName, String eventParams) { }

	// RVA: 0xFFFFFFFF75981448
	public static Void DoCallbackActions() { }

	// RVA: 0xFFFFFFFF759815A4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759815AC
	private static Void .cctor() { }

}

// Namespace: 
public sealed class DownloadCallback
{
	// Methods

	// RVA: 0xFFFFFFFF759810B4
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75981690
	public virtual Void Invoke(Int32 id, Int32 status, String message) { }

	// RVA: 0xFFFFFFFF75981D58
	public virtual IAsyncResult BeginInvoke(Int32 id, Int32 status, String message, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75981E04
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class DownloadEventCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75981168
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7598198C
	public virtual Void Invoke(String eventName, String eventParams) { }

	// RVA: 0xFFFFFFFF75981E10
	public virtual IAsyncResult BeginInvoke(String eventName, String eventParams, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75981E6C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class <>c__DisplayClass33_0
{
	// Fields
	public Int32 id; // 0x10
	public Int32 status; // 0x14
	public String message; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75981438
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75981614
	internal Void <HandleDownloadCallBackFromNative>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public String eventName; // 0x10
	public String eventParams; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75981440
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75981914
	internal Void <HandleDownloadEventCallbackFromNative>b__0() { }

}

// Namespace: Hades
public class DownloadLoom
{
	// Fields
	public static DownloadLoom _current; // 0x0
	private static Boolean initialized; // 0x8

	// Properties
	public static DownloadLoom Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75981E78
	public static DownloadLoom get_Current() { }

	// RVA: 0xFFFFFFFF75980F1C
	public static Void Initialize() { }

	// RVA: 0xFFFFFFFF75981EC4
	private Void Update() { }

	// RVA: 0xFFFFFFFF75981F18
	public Void .ctor() { }

}

// Namespace: Hades
internal enum DownloadCallbackStatus
{
	// Fields
	public Int32 value__; // 0x10
	public const DownloadCallbackStatus kSingleChange = 0;
	public const DownloadCallbackStatus kMultiChange = 1;
	public const DownloadCallbackStatus KMultiInit = 2;
	public const DownloadCallbackStatus kBatchChange = 3;
}

// Namespace: Hades
public abstract class DownloadBaseTask
{
	// Fields
	public DownloadInfo downloadInfo; // 0x10
	public DownloadMultiInfo downloadMultiInfo; // 0x18
	public DownloadBatchInfo downloadBatchInfo; // 0x20
	private DownloadStartEventHandler DownloadStartEvent; // 0x28
	private DownloadPauseEventHandler DownloadPauseEvent; // 0x30
	private DownloadDeleteEventHandler DownloadDeleteEvent; // 0x38
	private DownloadProgressEventHandler DownloadProgressEvent; // 0x40
	private DownloadSuccessEventHandler DownloadSuccessEvent; // 0x48
	private DownloadFailedEventHandler DownloadFailedEvent; // 0x50
	public readonly Int32 _taskId; // 0x58

	// Methods

	// RVA: 0xFFFFFFFF7597DAC8
	public Void add_DownloadStartEvent(DownloadStartEventHandler value) { }

	// RVA: 0xFFFFFFFF7597DB64
	public Void remove_DownloadStartEvent(DownloadStartEventHandler value) { }

	// RVA: 0xFFFFFFFF7597DC00
	public Void add_DownloadPauseEvent(DownloadPauseEventHandler value) { }

	// RVA: 0xFFFFFFFF7597DC9C
	public Void remove_DownloadPauseEvent(DownloadPauseEventHandler value) { }

	// RVA: 0xFFFFFFFF7597DD38
	public Void add_DownloadDeleteEvent(DownloadDeleteEventHandler value) { }

	// RVA: 0xFFFFFFFF7597DDD4
	public Void remove_DownloadDeleteEvent(DownloadDeleteEventHandler value) { }

	// RVA: 0xFFFFFFFF7597DE70
	public Void add_DownloadProgressEvent(DownloadProgressEventHandler value) { }

	// RVA: 0xFFFFFFFF7597DF0C
	public Void remove_DownloadProgressEvent(DownloadProgressEventHandler value) { }

	// RVA: 0xFFFFFFFF7597DFA8
	public Void add_DownloadSuccessEvent(DownloadSuccessEventHandler value) { }

	// RVA: 0xFFFFFFFF7597E044
	public Void remove_DownloadSuccessEvent(DownloadSuccessEventHandler value) { }

	// RVA: 0xFFFFFFFF7597E0E0
	public Void add_DownloadFailedEvent(DownloadFailedEventHandler value) { }

	// RVA: 0xFFFFFFFF7597E17C
	public Void remove_DownloadFailedEvent(DownloadFailedEventHandler value) { }

	// RVA: 0xFFFFFFFF7597E218
	public Void .ctor(Int32 taskId) { }

	// RVA: 0xFFFFFFFF7597E318
	public Int32 GetTaskId() { }

	// RVA: 0xFFFFFFFF7597E320
	public Void UpdateDownloadInfo(DownloadCPPInfo cppInfo) { }

	// RVA: 0xFFFFFFFF7597E3EC
	public Void UpdateDownloadMultiInfo(DownloadMultiCPPInfo cppInfo) { }

	// RVA: 0xFFFFFFFF7597E474
	public Void UpdateDownloadBatchInfo(DownloadBatchCPPInfo cppInfo) { }

	// RVA: 0xFFFFFFFF7597E4D0
	public Void InvokeEvent(DownloadStatus status, DownloadInfo downloadInfo) { }

	// RVA: 0xFFFFFFFF7597FAB8
	public Void Start() { }

	// RVA: 0xFFFFFFFF7597FB18
	public Void Pause() { }

	// RVA: 0xFFFFFFFF7597FB78
	public Void Cancel(Boolean deleteFile) { }

	// RVA: 0xFFFFFFFF7597FBD8
	public Boolean IsDownloading() { }

	// RVA: 0xFFFFFFFF7597FC38
	public Void SetThrottleNetSpeed(Int64 throttleNetSpeed, Int32 throttleSmoothness, Boolean throttleOnlyForeground) { }

	// RVA: 0xFFFFFFFF7597FC98
	public Void SetOnlyWifi(Boolean onlyWifi) { }

	// RVA: 0xFFFFFFFF7597FCF8
	public Int32 GetDownloadStatus() { }

}

// Namespace: Hades
public class DownloadTask
{
	// Methods

	// RVA: 0xFFFFFFFF759853F8
	public Void .ctor(Int32 taskId) { }

	// RVA: 0xFFFFFFFF75985D08
	public DownloadInfo QueryDownloadInfo() { }

}

// Namespace: Hades
public class DownloadMultiTask
{
	// Fields
	private DownloadMultiStartEventHandler DownloadMultiStartEvent; // 0x60
	private DownloadMultiPauseEventHandler DownloadMultiPauseEvent; // 0x68
	private DownloadMultiDeleteEventHandler DownloadMultiDeleteEvent; // 0x70
	private DownloadMultiProgressEventHandler DownloadMultiProgressEvent; // 0x78
	private DownloadMultiSuccessEventHandler DownloadMultiSuccessEvent; // 0x80
	private DownloadMultiFailedEventHandler DownloadMultiFailedEvent; // 0x88
	private DownloadBatchStartEventHandler DownloadBatchStartEvent; // 0x90
	private DownloadBatchProgressEventHandler DownloadBatchProgressEvent; // 0x98
	private DownloadBatchEndEventHandler DownloadBatchEndEvent; // 0xA0

	// Methods

	// RVA: 0xFFFFFFFF75983868
	public Void .ctor(Int32 taskId) { }

	// RVA: 0xFFFFFFFF7598386C
	public Void add_DownloadMultiStartEvent(DownloadMultiStartEventHandler value) { }

	// RVA: 0xFFFFFFFF75983908
	public Void remove_DownloadMultiStartEvent(DownloadMultiStartEventHandler value) { }

	// RVA: 0xFFFFFFFF759839A4
	public Void add_DownloadMultiPauseEvent(DownloadMultiPauseEventHandler value) { }

	// RVA: 0xFFFFFFFF75983A40
	public Void remove_DownloadMultiPauseEvent(DownloadMultiPauseEventHandler value) { }

	// RVA: 0xFFFFFFFF75983ADC
	public Void add_DownloadMultiDeleteEvent(DownloadMultiDeleteEventHandler value) { }

	// RVA: 0xFFFFFFFF75983B78
	public Void remove_DownloadMultiDeleteEvent(DownloadMultiDeleteEventHandler value) { }

	// RVA: 0xFFFFFFFF75983C14
	public Void add_DownloadMultiProgressEvent(DownloadMultiProgressEventHandler value) { }

	// RVA: 0xFFFFFFFF75983CB0
	public Void remove_DownloadMultiProgressEvent(DownloadMultiProgressEventHandler value) { }

	// RVA: 0xFFFFFFFF75983D4C
	public Void add_DownloadMultiSuccessEvent(DownloadMultiSuccessEventHandler value) { }

	// RVA: 0xFFFFFFFF75983DE8
	public Void remove_DownloadMultiSuccessEvent(DownloadMultiSuccessEventHandler value) { }

	// RVA: 0xFFFFFFFF75983E84
	public Void add_DownloadMultiFailedEvent(DownloadMultiFailedEventHandler value) { }

	// RVA: 0xFFFFFFFF75983F20
	public Void remove_DownloadMultiFailedEvent(DownloadMultiFailedEventHandler value) { }

	// RVA: 0xFFFFFFFF75983FBC
	public Void add_DownloadBatchStartEvent(DownloadBatchStartEventHandler value) { }

	// RVA: 0xFFFFFFFF75984058
	public Void remove_DownloadBatchStartEvent(DownloadBatchStartEventHandler value) { }

	// RVA: 0xFFFFFFFF759840F4
	public Void add_DownloadBatchProgressEvent(DownloadBatchProgressEventHandler value) { }

	// RVA: 0xFFFFFFFF75984190
	public Void remove_DownloadBatchProgressEvent(DownloadBatchProgressEventHandler value) { }

	// RVA: 0xFFFFFFFF7598422C
	public Void add_DownloadBatchEndEvent(DownloadBatchEndEventHandler value) { }

	// RVA: 0xFFFFFFFF759842C8
	public Void remove_DownloadBatchEndEvent(DownloadBatchEndEventHandler value) { }

	// RVA: 0xFFFFFFFF75984364
	public DownloadMultiInfo QueryDownloadInfo() { }

	// RVA: 0xFFFFFFFF75984418
	public Void InvokeMultiEvent(DownloadStatus status, DownloadMultiInfo downloadInfo) { }

	// RVA: 0xFFFFFFFF759844A0
	public Void InvokeBatchEvent(DownloadStatus status, DownloadBatchInfo batchInfo) { }

}

// Namespace: Hades
public class DownloadService
{
	// Fields
	public readonly Hashtable _taskMap; // 0x10
	public readonly Hashtable _multiTaskMap; // 0x18
	public Dictionary<T0, T1> _singleToMultiDic; // 0x20
	public DownloadDepend mDepend; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75984B24
	public Void Init(DownloadDepend depend) { }

	// RVA: 0xFFFFFFFF75984D04
	public Void SetThrottleNetSpeed(Int32 throttleNetSpeed, Boolean throttleOnlyForeground, Int32 throttleSmoothness) { }

	// RVA: 0xFFFFFFFF7597D918
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75984D60
	public Void OnDownloadCallback(Int32 id, Int32 status, String message) { }

	// RVA: 0xFFFFFFFF759852A0
	public Void OnReportEventCallback(String eventName, String eventParams) { }

	// RVA: 0xFFFFFFFF759852B8
	public IDownloadTask CreateTask(DownloadTaskConfig config) { }

	// RVA: 0xFFFFFFFF759853FC
	public IDownloadMultiTask CreateMultiTask(DownloadMultiTaskConfig config) { }

	// RVA: 0xFFFFFFFF7598553C
	public Void SetLogLevel(LogPriority logLevel) { }

	// RVA: 0xFFFFFFFF75985390
	private String JsonStrFromConfig(DownloadTaskConfig config) { }

	// RVA: 0xFFFFFFFF759854D4
	private String JsonStrFromMultiConfig(DownloadMultiTaskConfig multiConfig) { }

	// RVA: 0xFFFFFFFF75985000
	public DownloadBaseTask GetTask(Int32 taskID) { }

	// RVA: 0xFFFFFFFF759850F8
	public DownloadBaseTask GetMultiTaskFromSubId(Int32 subId) { }

}

// Namespace: 
public class DownloadDependWin
{
	// Fields
	public String pkgName; // 0x48
	public String versionCode; // 0x50

	// Methods

	// RVA: 0xFFFFFFFF759858F8
	public Void .ctor() { }

}

// Namespace: 
public class MultiInitObj
{
	// Fields
	public List<T0> subIds; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75985160
	public static MultiInitObj FromString(String jsonString) { }

	// RVA: 0xFFFFFFFF75985C20
	public Void .ctor() { }

}

// Namespace: 
private struct JsonConfigStruct
{
	// Fields
	public String url; // 0x10
	public String md5; // 0x18
	public String file_name; // 0x20
	public String save_path; // 0x28
	public Int64 start_offset; // 0x30
	public Int64 end_offset; // 0x38
	public Int32 retry_count; // 0x40
	public Int32 backup_host_retry_count; // 0x44
	public List<T0> backup_hosts; // 0x48
	public Boolean only_wifi; // 0x50
	public Int64 throttle_net_speed; // 0x58
	public Int32 throttle_smoothness; // 0x60
	public Boolean throttle_only_foreground; // 0x64
	public Int64 expect_file_length; // 0x68
	public Boolean over_write; // 0x70
	public String download_setting; // 0x78
	public Boolean show_notification; // 0x80
	public String notification_name; // 0x88
	public String headers; // 0x90
	public Boolean auto_resume; // 0x98

	// Methods

	// RVA: 0xFFFFFFFF75985598
	public static JsonConfigStruct CreateWithConfig(DownloadTaskConfig config) { }

}

// Namespace: 
private struct JsonMultiConfigStruct
{
	// Fields
	public List<T0> subConfigs; // 0x10
	public Boolean show_notification; // 0x18
	public String notification_name; // 0x20
	public Boolean auto_resume; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75985700
	public static JsonMultiConfigStruct CreateWithConfig(DownloadMultiTaskConfig config) { }

}

// Namespace: Hades
public class PriorityPolicy
{
	// Fields
	public const Int32 FIFO = 0;
	public const Int32 LIFO = 1;
	public const Int32 LowInterrupt = 2;
	public const Int32 EqualInterrupt = 4;
	public const Int32 FlexInterrupt = 8;

	// Methods

	// RVA: 0xFFFFFFFF759870A8
	public Void .ctor() { }

}

// Namespace: Hades
public sealed class TgrpReportEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF7598EC34
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7598EC48
	public virtual Void Invoke(String eventName, String eventParam) { }

	// RVA: 0xFFFFFFFF7598F014
	public virtual IAsyncResult BeginInvoke(String eventName, String eventParam, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7598F070
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public class TgrpDependend
{
	// Methods

	// RVA: 0xFFFFFFFF7598E9D0
	public Void .ctor() { }

}

// Namespace: Hades
public sealed class BatchListenerStartHandler
{
	// Methods

	// RVA: 0xFFFFFFFF7597D4AC
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597D4C0
	public virtual Void Invoke(Int32 batchId, Int64 curBytes, Int64 totalBytes, TGRPResInfo[] downList, TGRPResInfo[] succList) { }

	// RVA: 0xFFFFFFFF7597D774
	public virtual IAsyncResult BeginInvoke(Int32 batchId, Int64 curBytes, Int64 totalBytes, TGRPResInfo[] downList, TGRPResInfo[] succList, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597D840
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class BatchListenerProgressHandler
{
	// Methods

	// RVA: 0xFFFFFFFF7597D0CC
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597D0E0
	public virtual Void Invoke(Int32 batchId, Int64 curBytes, Int64 totalBytes, Double speed, Int64 curTime, TGRPResInfo[] succList) { }

	// RVA: 0xFFFFFFFF7597D3B0
	public virtual IAsyncResult BeginInvoke(Int32 batchId, Int64 curBytes, Int64 totalBytes, Double speed, Int64 curTime, TGRPResInfo[] succList, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597D4A0
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class BatchListenerEndHandler
{
	// Methods

	// RVA: 0xFFFFFFFF7597CD38
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7597CD4C
	public virtual Void Invoke(Int32 batchId, TGRPResInfo[] succList, TGRPResInfo[] unfinishList, Int32 status, String errorMsg) { }

	// RVA: 0xFFFFFFFF7597D000
	public virtual IAsyncResult BeginInvoke(Int32 batchId, TGRPResInfo[] succList, TGRPResInfo[] unfinishList, Int32 status, String errorMsg, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7597D0C0
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public class BatchListener
{
	// Fields
	public BatchListenerStartHandler OnBatchStartHandler; // 0x10
	public BatchListenerProgressHandler OnBatchProgressHandler; // 0x18
	public BatchListenerEndHandler OnBatchEndHandler; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF7597CD30
	public Void .ctor() { }

}

// Namespace: Hades
public sealed class ResCheckStartHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75987AD4
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75987AE8
	public virtual Void Invoke(Int32 batchId) { }

	// RVA: 0xFFFFFFFF75987D3C
	public virtual IAsyncResult BeginInvoke(Int32 batchId, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75987DCC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class ResCheckProgressHandler
{
	// Methods

	// RVA: 0xFFFFFFFF7598774C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75987760
	public virtual Void Invoke(Int32 batchId, Int32 curFiles, Int32 totalFiles, Int64 curTime) { }

	// RVA: 0xFFFFFFFF759879FC
	public virtual IAsyncResult BeginInvoke(Int32 batchId, Int32 curFiles, Int32 totalFiles, Int64 curTime, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75987AC8
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class ResCheckEndHandler
{
	// Methods

	// RVA: 0xFFFFFFFF759873FC
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75987410
	public virtual Void Invoke(Int32 batchId, TGRPResInfo[] correctList, TGRPResInfo[] incorrectList) { }

	// RVA: 0xFFFFFFFF75987694
	public virtual IAsyncResult BeginInvoke(Int32 batchId, TGRPResInfo[] correctList, TGRPResInfo[] incorrectList, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75987738
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public class ResCheckListener
{
	// Fields
	public ResCheckStartHandler OnResCheckStartHandler; // 0x10
	public ResCheckProgressHandler OnResCheckProgressHandler; // 0x18
	public ResCheckEndHandler OnResCheckEndHandler; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75987744
	public Void .ctor() { }

}

// Namespace: Hades
public struct TGRPResInfo
{
	// Fields
	public Int32 tgrpId; // 0x10
	public Int32 index; // 0x14

	// Properties
	public String name { get; }
	public String md5 { get; }
	public String savePath { get; }
	public String absPath { get; }
	public String resPath { get; }

	// Methods

	// RVA: 0xFFFFFFFF70F050D8
	public Void .ctor(Int64 pTgrpId, Int32 pIndex) { }

	// RVA: 0xFFFFFFFF70F050E0
	public String get_name() { }

	// RVA: 0xFFFFFFFF70F050E4
	public String get_md5() { }

	// RVA: 0xFFFFFFFF70F050E8
	public String get_savePath() { }

	// RVA: 0xFFFFFFFF70F050EC
	public String get_absPath() { }

	// RVA: 0xFFFFFFFF70F050F0
	public String get_resPath() { }

	// RVA: 0xFFFFFFFF70F050F4
	public String Description() { }

	// RVA: 0xFFFFFFFF70F050FC
	public String GetResInfoProperty(TgrpResinfoProperty property) { }

}

// Namespace: Hades
public struct TGRPBatchDownloadInfo
{
	// Fields
	public Int64 tgrpId; // 0x10
	public Int32 batchId; // 0x18
	public Int64 curBytes; // 0x20
	public Int64 totalBytes; // 0x28
}

// Namespace: Hades
public sealed class TGRPInitSuccessHandler
{
	// Methods

	// RVA: 0xFFFFFFFF7598BDD8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75988B28
	public virtual Void Invoke(TGRPResInfo[] addResList, TGRPResInfo[] deleteResList, TGRPResInfo[] modifyResList) { }

	// RVA: 0xFFFFFFFF7598BDEC
	public virtual IAsyncResult BeginInvoke(TGRPResInfo[] addResList, TGRPResInfo[] deleteResList, TGRPResInfo[] modifyResList, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7598BE48
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class TGRPInitFailHandler
{
	// Methods

	// RVA: 0xFFFFFFFF7598BD24
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75988F14
	public virtual Void Invoke(Int32 errorCode, String errorMsg) { }

	// RVA: 0xFFFFFFFF7598BD38
	public virtual IAsyncResult BeginInvoke(Int32 errorCode, String errorMsg, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7598BDCC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class GlobalDownloadAddQueue
{
	// Methods

	// RVA: 0xFFFFFFFF75985E84
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75985E98
	public virtual Void Invoke(TGRPResInfo[] list) { }

	// RVA: 0xFFFFFFFF75986228
	public virtual IAsyncResult BeginInvoke(TGRPResInfo[] list, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75986278
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class GlobalDownloadProgress
{
	// Methods

	// RVA: 0xFFFFFFFF759864F8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7598650C
	public virtual Void Invoke(Int64 curBytes, Int64 totalBytes) { }

	// RVA: 0xFFFFFFFF75986778
	public virtual IAsyncResult BeginInvoke(Int64 curBytes, Int64 totalBytes, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75986818
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class GlobalDownloadQueueEmpty
{
	// Methods

	// RVA: 0xFFFFFFFF75986824
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75986838
	public virtual Void Invoke(TGRPResInfo[] successList, TGRPResInfo[] unfinishedList, Int32 status, String errMsg) { }

	// RVA: 0xFFFFFFFF75986C44
	public virtual IAsyncResult BeginInvoke(TGRPResInfo[] successList, TGRPResInfo[] unfinishedList, Int32 status, String errMsg, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75986CDC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public sealed class GlobalDownloadAllResSuccess
{
	// Methods

	// RVA: 0xFFFFFFFF75986284
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75986298
	public virtual Void Invoke() { }

	// RVA: 0xFFFFFFFF75986494
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759864EC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Hades
public class InitConfig
{
	// Fields
	public String url; // 0x10
	public List<T0> backupHosts; // 0x18
	public List<T0> diffPatchUrls; // 0x20
	public List<T0> incrementalPackUrls; // 0x28
	public String appBaseResJson; // 0x30
	public Dictionary<T0, T1> requestHeaders; // 0x38

	// Methods

	// RVA: 0xFFFFFFFF75986CF8
	public Void .ctor() { }

}

// Namespace: Hades
public interface ITGRPDownloader
{
	// Methods

	// RVA: -1
	public abstract Void add_OnInitSuccess(TGRPInitSuccessHandler value) { }

	// RVA: -1
	public abstract Void remove_OnInitSuccess(TGRPInitSuccessHandler value) { }

	// RVA: -1
	public abstract Void add_OnInitFail(TGRPInitFailHandler value) { }

	// RVA: -1
	public abstract Void remove_OnInitFail(TGRPInitFailHandler value) { }

	// RVA: -1
	public abstract Void add_OnGlobalDownloadAddQueue(GlobalDownloadAddQueue value) { }

	// RVA: -1
	public abstract Void remove_OnGlobalDownloadAddQueue(GlobalDownloadAddQueue value) { }

	// RVA: -1
	public abstract Void add_OnGlobalDownloadProgress(GlobalDownloadProgress value) { }

	// RVA: -1
	public abstract Void remove_OnGlobalDownloadProgress(GlobalDownloadProgress value) { }

	// RVA: -1
	public abstract Void add_OnGlobalDownloadQueueEmpty(GlobalDownloadQueueEmpty value) { }

	// RVA: -1
	public abstract Void remove_OnGlobalDownloadQueueEmpty(GlobalDownloadQueueEmpty value) { }

	// RVA: -1
	public abstract Void add_OnGlobalDownloadAllResSuccess(GlobalDownloadAllResSuccess value) { }

	// RVA: -1
	public abstract Void remove_OnGlobalDownloadAllResSuccess(GlobalDownloadAllResSuccess value) { }

	// RVA: -1
	public abstract Void Init(InitConfig initConfig) { }

	// RVA: -1
	public abstract Void SetMaxParallelCount(Int32 count) { }

	// RVA: -1
	public abstract Void SetOnlyWifi(Boolean onlyWifi) { }

	// RVA: -1
	public abstract Void SetRetryTime(Int32 retryTime) { }

	// RVA: -1
	public abstract Void SetThrottleNetSpeed(Int64 speed) { }

	// RVA: -1
	public abstract Boolean IsInited() { }

	// RVA: -1
	public abstract Boolean IsIniting() { }

	// RVA: -1
	public abstract Int32 GetResCount() { }

	// RVA: -1
	public abstract TGRPResInfo[] GetResInfoList() { }

	// RVA: -1
	public abstract TGRPResInfo[] GetResInfoListByLabel(String label) { }

	// RVA: -1
	public abstract TGRPResInfo[] GetDownloadedResInfoList() { }

	// RVA: -1
	public abstract TGRPResInfo[] GetNotDownloadedResInfoList() { }

	// RVA: -1
	public abstract Int64 GetAllResDataTotalBytes() { }

	// RVA: -1
	public abstract Int64 GetListResDataDownloadedBytes(List<T0> paths) { }

	// RVA: -1
	public abstract Int64 GetListResDataDownloadedBytes(List<T0> resInfos) { }

	// RVA: -1
	public abstract Int64 GetAllResDataDownloadedBytes() { }

	// RVA: -1
	public abstract TGRPResInfo GetResInfo(String path) { }

	// RVA: -1
	public abstract Boolean IsResFileDownloaded(String path) { }

	// RVA: -1
	public abstract Boolean IsResFileDownloaded(TGRPResInfo resinfo) { }

	// RVA: -1
	public abstract Boolean IsResFileCorrect(String path) { }

	// RVA: -1
	public abstract Boolean IsResFileCorrect(TGRPResInfo resinfo) { }

	// RVA: -1
	public abstract Boolean IsAllFilesDownloaded() { }

	// RVA: -1
	public abstract Int32 DownloadAllRes(BatchListener batchListenr, Boolean isSequential) { }

	// RVA: -1
	public abstract Int32 DownloadResList(List<T0> paths, BatchListener batchListenr, Boolean isSequential) { }

	// RVA: -1
	public abstract Int32 DownloadResList(List<T0> resInfos, BatchListener batchListener, Boolean isSequential) { }

	// RVA: -1
	public abstract Int32 DownloadResInDirectory(String directory, BatchListener batchListenr, Boolean isSequential) { }

	// RVA: -1
	public abstract Int32 DownloadByLabel(String label, BatchListener batchListenr, Boolean isSequential) { }

	// RVA: -1
	public abstract Int64 GetListResDataTotalBytes(List<T0> paths) { }

	// RVA: -1
	public abstract Int64 GetListResDataTotalBytes(List<T0> resInfos) { }

	// RVA: -1
	public abstract Int32 CreateBatchByAllRes(Boolean is_sequential) { }

	// RVA: -1
	public abstract Int64 GetTotalBytesByLabel(String label) { }

	// RVA: -1
	public abstract Int32 CreateBatchByResList(List<T0> paths, Boolean isSequential) { }

	// RVA: -1
	public abstract Int32 CreateBatchByResPathList(List<T0> paths, Boolean isSequential) { }

	// RVA: -1
	public abstract Int32 CreateBatchByDirectory(String directory, Boolean isSequential) { }

	// RVA: -1
	public abstract Int32 CreateBatchByLabel(String label, Boolean isSequential) { }

	// RVA: -1
	public abstract Int32 ExcludeResFromBatch(Int32 batchId, List<T0> resPaths) { }

	// RVA: -1
	public abstract Void RegisterBatchListener(Int32 batchId, BatchListener batchListener) { }

	// RVA: -1
	public abstract Void UnregisterBatchListener(Int32 batchId) { }

	// RVA: -1
	public abstract Void SetPriority(Int32 batchId, Int32 priority, Int32 policy) { }

	// RVA: -1
	public abstract Int32 GetDownloadingBatchId() { }

	// RVA: -1
	public abstract List<T0> GetDownloadingBatchSequence() { }

	// RVA: -1
	public abstract Int64 GetDownloadedBytesByLabel(String label) { }

	// RVA: -1
	public abstract Void StartDownload(Int32 batchId) { }

	// RVA: -1
	public abstract Void PauseDownload(Int32 batchId) { }

	// RVA: -1
	public abstract Boolean DeleteRes(String path) { }

	// RVA: -1
	public abstract Boolean DeleteRes(TGRPResInfo resinfo) { }

	// RVA: -1
	public abstract TGRPBatchDownloadInfo GetTGRPBatchDownloadInfo(Int32 batchId) { }

	// RVA: -1
	public abstract Void ClearResNotInBatch() { }

	// RVA: -1
	public abstract Void SetFileSystem(Int64 cppFileSystem) { }

	// RVA: -1
	public abstract Void Release() { }

	// RVA: -1
	public abstract Void RegisterResCheckListener(Int32 batchId, ResCheckListener listener) { }

	// RVA: -1
	public abstract Void UnregisterResCheckListener(Int32 batchId) { }

	// RVA: -1
	public abstract Void ResCheck(Int32 batchId) { }

	// RVA: -1
	public abstract Void ClearBatchInfo(Int32 batchId) { }

}

// Namespace: Hades
public interface ITGRPService
{
	// Methods

	// RVA: -1
	public abstract ITGRPDownloader ObtainTGRPDownloader(String tgrpName, String parentPath, String subPath) { }

	// RVA: -1
	public abstract Void ReleaseTGRPDownloader(String tgrpName, String parentPath, String subPath) { }

	// RVA: -1
	public abstract Void Init(TgrpDependend depend) { }

	// RVA: -1
	public abstract Void SetLogLevel(LogPriority logLevel) { }

}

// Namespace: Hades
public static class TGRP
{
	// Fields
	private static TGRPService _service; // 0x0

	// Properties
	public static ITGRPService Service { get; }

	// Methods

	// RVA: 0xFFFFFFFF75987DD8
	public static ITGRPService get_Service() { }

	// RVA: 0xFFFFFFFF75987E38
	private static Void .cctor() { }

}

// Namespace: Hades
public class HadesTgrpErrorCode
{
	// Fields
	public const Int32 kTgrpPathIsEmpty = 4294460296;
	public const Int32 kIsNotTgrpFile = 4294460295;
	public const Int32 kVersionError = 4294460294;
	public const Int32 kTgrpHeaderError = 4294460293;
	public const Int32 kFileCountError = 4294460292;
	public const Int32 kTgrpUnKnownFlagError = 4294460287;
	public const Int32 kGzipError = 4294459196;

	// Methods

	// RVA: 0xFFFFFFFF75986CF0
	public Void .ctor() { }

}

// Namespace: Hades
public class IntListObj
{
	// Fields
	public List<T0> rangeIndexs; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75986D2C
	public List<T0> GetIndexs() { }

	// RVA: 0xFFFFFFFF75986E30
	public static IntListObj FromString(String jsonStr) { }

	// RVA: 0xFFFFFFFF75986F64
	public Void .ctor() { }

}

// Namespace: Hades
public class NormalIntListObj
{
	// Fields
	public List<T0> intValues; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75986F6C
	public static NormalIntListObj FromString(String jsonStr) { }

	// RVA: 0xFFFFFFFF759870A0
	public Void .ctor() { }

}

// Namespace: Hades
public class Serialization<T0>
{
	// Fields
	private List<T0> target; // 0x0

	// Methods

	// RVA: -1
	public List<T0> ToList() { }

	// RVA: -1
	public Void .ctor(List<T0> target) { }

}

// Namespace: Hades
public class Serialization<T0, T1>
{
	// Fields
	private List<T0> keys; // 0x0
	private List<T0> values; // 0x0
	private Dictionary<T0, T1> target; // 0x0

	// Methods

	// RVA: -1
	public Dictionary<T0, T1> ToDictionary() { }

	// RVA: -1
	public Void .ctor(Dictionary<T0, T1> target) { }

	// RVA: -1
	public Void OnBeforeSerialize() { }

	// RVA: -1
	public Void OnAfterDeserialize() { }

}

// Namespace: Hades
public class TGRPInterface
{
	// Fields
	public static InitCallback initCallback; // 0x0
	public static DownloadCallback downloadCallback; // 0x8
	public static DownloadEventCallback eventCallback; // 0x10
	private static List<T0> downloadCallbackActs; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF7598C14C
	public static Int32 InitTGRPDownload(String initParams) { }

	// RVA: 0xFFFFFFFF7598C154
	public static Void Hades_Tgrp_Update() { }

	// RVA: 0xFFFFFFFF7598C158
	public static Void Hades_Downloader_Update() { }

	// RVA: 0xFFFFFFFF7598C15C
	public static Void Hades_Downloader_SetApplicationInfo(String pkgName, String versionCode) { }

	// RVA: 0xFFFFFFFF7598C160
	public static Int32 Hades_Downloader_InitWinDownload(String initParams) { }

	// RVA: 0xFFFFFFFF7598C168
	public static Void Hades_Downloader_UnityWinInit(Int32 type) { }

	// RVA: 0xFFFFFFFF7598C16C
	public static Int32 Hades_Downloader_InitMacDownload(String initParams) { }

	// RVA: 0xFFFFFFFF7598A61C
	public static Void Hades_Downloader_ReleaseCharArray(IntPtr strPtr) { }

	// RVA: 0xFFFFFFFF7598C174
	public static Void Hades_Tgrp_InitTGRPService() { }

	// RVA: 0xFFFFFFFF7598C178
	public static Void Hades_Tgrp_SetInitCallback(InitCallback callback) { }

	// RVA: 0xFFFFFFFF7598C17C
	public static Void Hades_Tgrp_SetDownloadCallback(DownloadCallback callback) { }

	// RVA: 0xFFFFFFFF7598C180
	public static Void Hades_Downloader_SetDownloadEventCallBack(DownloadEventCallback callback) { }

	// RVA: 0xFFFFFFFF7598C184
	public static Int64 Hades_Tgrp_Obtain(String tgrpName, String parentPath, String subPath) { }

	// RVA: 0xFFFFFFFF7598C18C
	public static Int64 Hades_Tgrp_ReleaseTGRPDownloader(String tgrpName, String parentPath, String subPath) { }

	// RVA: 0xFFFFFFFF7598B430
	public static Void Hades_Tgrp_SetMaxParallelCount(Int64 tgrpId, Int32 num) { }

	// RVA: 0xFFFFFFFF7598B490
	public static Void Hades_Tgrp_SetOnlyWifi(Int64 tgrpId, Boolean only_wifi) { }

	// RVA: 0xFFFFFFFF7598B4F0
	public static Void Hades_Tgrp_SetRetryTime(Int64 tgrpId, Int32 retry_time) { }

	// RVA: 0xFFFFFFFF7598B550
	public static Void Hades_Tgrp_SetThrottleNetSpeed(Int64 tgrpId, Int64 speed) { }

	// RVA: 0xFFFFFFFF7598955C
	public static Void Hades_Tgrp_Init(Int64 tgrpId, String initJson) { }

	// RVA: 0xFFFFFFFF7598B154
	public static Boolean Hades_Tgrp_IsInited(Int64 tgrpId) { }

	// RVA: 0xFFFFFFFF7598B1B4
	public static Boolean Hades_Tgrp_IsIniting(Int64 tgrpId) { }

	// RVA: 0xFFFFFFFF7598B02C
	public static Int32 Hades_Tgrp_GetResCount(Int64 tgrpId) { }

	// RVA: 0xFFFFFFFF7598B0F4
	public static IntPtr Hades_Tgrp_GetResInfoList(Int64 tgrpId) { }

	// RVA: 0xFFFFFFFF7598ABF0
	public static IntPtr Hades_Tgrp_GetResInfoListByLabel(Int64 tgrpId, String label) { }

	// RVA: 0xFFFFFFFF7598AB30
	public static IntPtr Hades_Tgrp_GetNotDownloadedResInfoList(Int64 tgrpId) { }

	// RVA: 0xFFFFFFFF7598A7F4
	public static IntPtr Hades_Tgrp_GetDownloadedResInfoList(Int64 tgrpId) { }

	// RVA: 0xFFFFFFFF7598A734
	public static Int64 Hades_Tgrp_GetAllResDataTotalBytes(Int64 tgrpId) { }

	// RVA: 0xFFFFFFFF7598A89C
	public static Int64 Hades_Tgrp_GetListResDataDownloadedBytes(Int64 tgrpId, String pathsJson) { }

	// RVA: 0xFFFFFFFF7598A6D4
	public static Int64 Hades_Tgrp_GetAllResDataDownloadedBytes(Int64 tgrpId) { }

	// RVA: 0xFFFFFFFF7598B2D0
	public static Boolean Hades_Tgrp_IsResFileDownloaded(Int64 tgrpId, String path) { }

	// RVA: 0xFFFFFFFF7598B214
	public static Boolean Hades_Tgrp_IsResFileCorrect(Int64 tgrpId, String path) { }

	// RVA: 0xFFFFFFFF7598974C
	public static Int32 Hades_Tgrp_DownloadAllRes(Int64 tgrpId, Boolean isSequential) { }

	// RVA: 0xFFFFFFFF759899C4
	public static Int32 Hades_Tgrp_DownloadResList(Int64 tgrpId, String pathsJson, Boolean isSequential) { }

	// RVA: 0xFFFFFFFF75989C34
	public static Int32 Hades_Tgrp_CreateBatchByResList(Int64 tgrpId, String indexJson, Boolean isSequential) { }

	// RVA: 0xFFFFFFFF7598A140
	public static Int32 Hades_Tgrp_CreateBatchByResPathList(Int64 tgrpId, String pathsJson, Boolean isSequential) { }

	// RVA: 0xFFFFFFFF7598C194
	public static Int32 Hades_Tgrp_DownloadResInDirectory(Int64 tgrpId, String directory, Boolean isSequential) { }

	// RVA: 0xFFFFFFFF7598C19C
	public static Int32 Hades_Tgrp_DownloadByLabel(Int64 tgrpId, String label, Boolean isSequential) { }

	// RVA: 0xFFFFFFFF7598AF0C
	public static Int64 Hades_Tgrp_GetListResDataTotalBytes(Int64 tgrpId, String resIndexsJson) { }

	// RVA: 0xFFFFFFFF7598AF6C
	public static Int64 Hades_Tgrp_GetTotalBytesByLabel(Int64 tgrpId, String label) { }

	// RVA: 0xFFFFFFFF7598AFCC
	public static Int64 Hades_Tgrp_GetDownloadedBytesByLabel(Int64 tgrpId, String label) { }

	// RVA: 0xFFFFFFFF75989C3C
	public static Void Hades_Tgrp_StartDownload(Int64 tgrpId, Int32 batchId) { }

	// RVA: 0xFFFFFFFF7598B3D0
	public static Void Hades_Tgrp_PauseDownload(Int64 tgrpId, Int32 batchId) { }

	// RVA: 0xFFFFFFFF75989F00
	public static Int32 Hades_Tgrp_CreateBatchByAllRes(Int64 tgrpId, Boolean is_sequential) { }

	// RVA: 0xFFFFFFFF759895B8
	public static Boolean Hades_Tgrp_DeleteRes(Int64 tgrpId, String path) { }

	// RVA: 0xFFFFFFFF7598B034
	public static Int32 Hades_Tgrp_GetResInfoIndex(Int64 tgrpId, String path) { }

	// RVA: 0xFFFFFFFF7598C1A4
	public static IntPtr Hades_Tgrp_GetResinfoProperty(Int64 tgrpId, Int32 resIndex, TgrpResinfoProperty property) { }

	// RVA: 0xFFFFFFFF75988540
	public static Void Hades_Tgrp_RegistCallback(TGRPStatusEnum cbType) { }

	// RVA: 0xFFFFFFFF75989D6C
	public static Int32 Hades_Tgrp_CreateBatchByDirectory(Int64 tgrpId, String directory, Boolean is_sequential) { }

	// RVA: 0xFFFFFFFF75989EA0
	public static Int32 Hades_Tgrp_CreateBatchByLabel(Int64 tgrpId, String label, Boolean is_sequential) { }

	// RVA: 0xFFFFFFFF7598B8C4
	public static Int32 Hades_Tgrp_ExcludeResFromBatch(Int64 tgrpId, Int32 batchId, String excludePathsJson) { }

	// RVA: 0xFFFFFFFF7598A508
	public static Void Hades_Tgrp_SetPriority(Int64 tgrpId, Int32 batch_id, Int32 priority, Int32 policy) { }

	// RVA: 0xFFFFFFFF7598A564
	public static Int32 Hades_Tgrp_GetDownloadingBatchId(Int64 tgrpId) { }

	// RVA: 0xFFFFFFFF7598A614
	public static IntPtr Hades_Tgrp_GetDownloadingBatchSequence(Int64 tgrpId) { }

	// RVA: 0xFFFFFFFF7598C1AC
	public static Int32 Hades_Downloader_SetLogLevel(Int32 logLevel) { }

	// RVA: 0xFFFFFFFF7598B5B4
	public static Int32 Hades_Tgrp_GetBatchDownloadInfo(Int64 tgrpId, Int32 batchId, out TGRPBatchDownloadInfo batchInfo) { }

	// RVA: 0xFFFFFFFF7598B620
	public static Void Hades_Tgrp_ClearResNotInBatch(Int64 tgrpId) { }

	// RVA: 0xFFFFFFFF7598B680
	public static Void Hades_Tgrp_SetFileSystem(Int64 tgrpId, Int64 cppFileSystem) { }

	// RVA: 0xFFFFFFFF7598B79C
	public static Void Hades_Tgrp_ReleaseTGRPDownloaderId(Int64 tgrpId) { }

	// RVA: 0xFFFFFFFF7598BD14
	public static Int32 Hades_Tgrp_ResCheck(Int64 tgrpId, Int32 batchId) { }

	// RVA: 0xFFFFFFFF7598B85C
	public static Void Hades_Tgrp_ClearBatchInfo(Int64 tgrpId, Int32 batchId) { }

	// RVA: 0xFFFFFFFF7598C1B4
	public static Void Init(String initParams) { }

	// RVA: 0xFFFFFFFF7598C340
	private static Void UnityEditorInit(String initParams) { }

	// RVA: 0xFFFFFFFF7598C2BC
	private static Void NoUnityEditorInit(String initParams) { }

	// RVA: 0xFFFFFFFF7598C39C
	public static Void RegistEventCallBack() { }

	// RVA: 0xFFFFFFFF7598C450
	public static Void InitAndroid(String initParams) { }

	// RVA: 0xFFFFFFFF7598C70C
	public static Void InitDownloader(TgrpDependend depend) { }

	// RVA: 0xFFFFFFFF7598CAB8
	public static Void InitTGRPService() { }

	// RVA: 0xFFFFFFFF7598BE54
	public static Void HandleInitCallbackFromNative(Int64 tgrpId, String initJson, String resInfoJson) { }

	// RVA: 0xFFFFFFFF7598BF58
	public static Void HandleDownloadCallbackFromNative(Int64 tgrpId, Int32 type, String resultJson) { }

	// RVA: 0xFFFFFFFF7598C050
	public static Void HandleDownloadEventCallbackFromNative(String eventName, String eventParams) { }

	// RVA: 0xFFFFFFFF7598CE04
	public static Void DoCallbackActions() { }

	// RVA: 0xFFFFFFFF7598CF60
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF7598CF68
	private static Void .cctor() { }

}

// Namespace: 
public enum TgrpCallBackType
{
	// Fields
	public Int32 value__; // 0x10
	public const TgrpCallBackType Res = 0;
	public const TgrpCallBackType Queue = 1;
	public const TgrpCallBackType Batch = 2;
	public const TgrpCallBackType ResCheck = 3;
}

// Namespace: 
public enum TgrpResinfoProperty
{
	// Fields
	public Int32 value__; // 0x10
	public const TgrpResinfoProperty Name = 0;
	public const TgrpResinfoProperty Md5 = 1;
	public const TgrpResinfoProperty SavePath = 2;
	public const TgrpResinfoProperty AbsPath = 3;
	public const TgrpResinfoProperty ResPath = 4;
}

// Namespace: 
public sealed class InitCallback
{
	// Methods

	// RVA: 0xFFFFFFFF7598C318
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7598D04C
	public virtual Void Invoke(Int64 tgrpId, String initJson, String resInfoJson) { }

	// RVA: 0xFFFFFFFF7598DB30
	public virtual IAsyncResult BeginInvoke(Int64 tgrpId, String initJson, String resInfoJson, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7598DBD4
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class DownloadCallback
{
	// Methods

	// RVA: 0xFFFFFFFF7598C32C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7598D34C
	public virtual Void Invoke(Int64 tgrpId, Int32 callBackType, String resultJson) { }

	// RVA: 0xFFFFFFFF7598DA10
	public virtual IAsyncResult BeginInvoke(Int64 tgrpId, Int32 callBackType, String resultJson, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7598DABC
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class DownloadEventCallback
{
	// Methods

	// RVA: 0xFFFFFFFF7598C43C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7598D644
	public virtual Void Invoke(String eventName, String eventParams) { }

	// RVA: 0xFFFFFFFF7598DAC8
	public virtual IAsyncResult BeginInvoke(String eventName, String eventParams, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7598DB24
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class <>c__DisplayClass75_0
{
	// Fields
	public Int64 tgrpId; // 0x10
	public String initJson; // 0x18
	public String resInfoJson; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF7598CDEC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF7598CFD0
	internal Void <HandleInitCallbackFromNative>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass76_0
{
	// Fields
	public Int64 tgrpId; // 0x10
	public Int32 type; // 0x18
	public String resultJson; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF7598CDF4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF7598D2CC
	internal Void <HandleDownloadCallbackFromNative>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass77_0
{
	// Fields
	public String eventName; // 0x10
	public String eventParams; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF7598CDFC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF7598D5CC
	internal Void <HandleDownloadEventCallbackFromNative>b__0() { }

}

// Namespace: Hades
public class RangeStrUtil
{
	// Methods

	// RVA: 0xFFFFFFFF759870B0
	public static String CustomJsonForStringList(List<T0> strList) { }

	// RVA: 0xFFFFFFFF75987230
	public static TGRPResInfo[] ResInfosFromRangeIndexList(Int64 tgrpId, List<T0> rangedIndexList) { }

	// RVA: 0xFFFFFFFF759873F4
	public Void .ctor() { }

}

// Namespace: Hades
public struct TGRPQueueCallbackInfo
{
	// Fields
	public Int64 tgrpId; // 0x10
	public Int32 what; // 0x18
	public Int64 curBytes; // 0x20
	public Int64 totalBytes; // 0x28
	public String errorMsg; // 0x30
	public List<T0> vec1; // 0x38
	public List<T0> vec2; // 0x40
}

// Namespace: Hades
public struct TGRPBatchCallbackInfo
{
	// Fields
	public Int64 tgrpId; // 0x10
	public Int32 batchId; // 0x18
	public Int32 what; // 0x1C
	public Int64 curBytes; // 0x20
	public Int64 totalBytes; // 0x28
	public Double speed; // 0x30
	public Int64 curTime; // 0x38
	public String errorMsg; // 0x40
	public List<T0> vec1; // 0x48
	public List<T0> vec2; // 0x50
}

// Namespace: Hades
public struct TGRPResCheckCallbackInfo
{
	// Fields
	public Int64 tgrpId; // 0x10
	public Int32 what; // 0x18
	public Int32 batchId; // 0x1C
	public Int32 curFiles; // 0x20
	public Int32 totalFiles; // 0x24
	public Int64 curTime; // 0x28
	public List<T0> correctList; // 0x30
	public List<T0> incorrectList; // 0x38
}

// Namespace: Hades
public struct TGRPInitInfo
{
	// Fields
	public Int32 status; // 0x10
	public Int32 errorCode; // 0x14
	public String errorMsg; // 0x18
	public List<T0> added; // 0x20
	public List<T0> deleted; // 0x28
	public List<T0> modified; // 0x30
}

// Namespace: Hades
public struct TGRPDownloadInfo
{
	// Fields
	public Int32 status; // 0x10
	public Int32 index; // 0x14
	public Int32 errorCode; // 0x18
	public String errorMsg; // 0x20
	public Int64 curBytes; // 0x28
	public Int64 totalBytes; // 0x30
}

// Namespace: Hades
public struct TGRPGlobalDownloadInfo
{
	// Fields
	public Int64 tgrpId; // 0x10
	public Int32 what; // 0x18
	public Int64 curBytes; // 0x20
	public Int64 totalBytes; // 0x28
	public String errorMsg; // 0x30
	public List<T0> vec1; // 0x38
	public List<T0> vec2; // 0x40
}

// Namespace: Hades
public class TGRPAllResDic
{
	// Fields
	public Int64 mTgrpId; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75987FA8
	public Void .ctor(Int64 pTgrpId) { }

	// RVA: 0xFFFFFFFF75987FD4
	public List<T0> GetResList(List<T0> indexList) { }

	// RVA: 0xFFFFFFFF75988110
	public TGRPResInfo GetResInfoWithIndex(Int32 index) { }

}

// Namespace: Hades
public class TGRPDownloader
{
	// Fields
	public Int32 tgrpId; // 0x10
	private TGRPInitSuccessHandler OnInitSuccess; // 0x18
	private TGRPInitFailHandler OnInitFail; // 0x20
	private GlobalDownloadAddQueue mOnGlobalDownloadAddQueue; // 0x28
	private GlobalDownloadProgress mOnGlobalDownloadProgress; // 0x30
	private GlobalDownloadQueueEmpty mOnGlobalDownloadQueueEmpty; // 0x38
	private GlobalDownloadAllResSuccess mOnGlobalDownloadAllResSuccess; // 0x40

	// Methods

	// RVA: 0xFFFFFFFF7598811C
	public Void add_OnInitSuccess(TGRPInitSuccessHandler value) { }

	// RVA: 0xFFFFFFFF759881B8
	public Void remove_OnInitSuccess(TGRPInitSuccessHandler value) { }

	// RVA: 0xFFFFFFFF75988254
	public Void add_OnInitFail(TGRPInitFailHandler value) { }

	// RVA: 0xFFFFFFFF759882F0
	public Void remove_OnInitFail(TGRPInitFailHandler value) { }

	// RVA: 0xFFFFFFFF7598838C
	public Void add_mOnGlobalDownloadAddQueue(GlobalDownloadAddQueue value) { }

	// RVA: 0xFFFFFFFF75988428
	public Void remove_mOnGlobalDownloadAddQueue(GlobalDownloadAddQueue value) { }

	// RVA: 0xFFFFFFFF759884C4
	public Void add_OnGlobalDownloadAddQueue(GlobalDownloadAddQueue value) { }

	// RVA: 0xFFFFFFFF75988544
	public Void remove_OnGlobalDownloadAddQueue(GlobalDownloadAddQueue value) { }

	// RVA: 0xFFFFFFFF75988548
	public Void add_mOnGlobalDownloadProgress(GlobalDownloadProgress value) { }

	// RVA: 0xFFFFFFFF759885E4
	public Void remove_mOnGlobalDownloadProgress(GlobalDownloadProgress value) { }

	// RVA: 0xFFFFFFFF75988680
	public Void add_OnGlobalDownloadProgress(GlobalDownloadProgress value) { }

	// RVA: 0xFFFFFFFF759886FC
	public Void remove_OnGlobalDownloadProgress(GlobalDownloadProgress value) { }

	// RVA: 0xFFFFFFFF75988700
	public Void add_mOnGlobalDownloadQueueEmpty(GlobalDownloadQueueEmpty value) { }

	// RVA: 0xFFFFFFFF7598879C
	public Void remove_mOnGlobalDownloadQueueEmpty(GlobalDownloadQueueEmpty value) { }

	// RVA: 0xFFFFFFFF75988838
	public Void add_OnGlobalDownloadQueueEmpty(GlobalDownloadQueueEmpty value) { }

	// RVA: 0xFFFFFFFF759888B4
	public Void remove_OnGlobalDownloadQueueEmpty(GlobalDownloadQueueEmpty value) { }

	// RVA: 0xFFFFFFFF759888B8
	public Void add_mOnGlobalDownloadAllResSuccess(GlobalDownloadAllResSuccess value) { }

	// RVA: 0xFFFFFFFF75988954
	public Void remove_mOnGlobalDownloadAllResSuccess(GlobalDownloadAllResSuccess value) { }

	// RVA: 0xFFFFFFFF759889F0
	public Void add_OnGlobalDownloadAllResSuccess(GlobalDownloadAllResSuccess value) { }

	// RVA: 0xFFFFFFFF75988A6C
	public Void remove_OnGlobalDownloadAllResSuccess(GlobalDownloadAllResSuccess value) { }

	// RVA: 0xFFFFFFFF75988A70
	public Void InvokeInitEvent(TGRPInitInfo initInfo) { }

	// RVA: 0xFFFFFFFF75989184
	public Void InvokeGlobalDownloadEvent(TGRPGlobalDownloadInfo info) { }

	// RVA: 0xFFFFFFFF75989288
	private String JsonStrFromConfig(InitConfig config) { }

	// RVA: 0xFFFFFFFF759893B8
	public Void Init(InitConfig initConfig) { }

	// RVA: 0xFFFFFFFF75989560
	public Boolean DeleteRes(String path) { }

	// RVA: 0xFFFFFFFF759895C0
	public Boolean DeleteRes(TGRPResInfo resinfo) { }

	// RVA: 0xFFFFFFFF75989620
	public Int32 DownloadAllRes(BatchListener batchListener, Boolean isSequential) { }

	// RVA: 0xFFFFFFFF7598988C
	public Int32 DownloadResList(List<T0> paths, BatchListener batchListener, Boolean isSequential) { }

	// RVA: 0xFFFFFFFF759899CC
	public Int32 DownloadResList(List<T0> resInfos, BatchListener batchListener, Boolean isSequential) { }

	// RVA: 0xFFFFFFFF75989C40
	public Int32 DownloadResInDirectory(String directory, BatchListener batchListener, Boolean isSequential) { }

	// RVA: 0xFFFFFFFF75989D74
	public Int32 DownloadByLabel(String label, BatchListener batchListener, Boolean isSequential) { }

	// RVA: 0xFFFFFFFF75989EA8
	public Int32 CreateBatchByAllRes(Boolean isSequential) { }

	// RVA: 0xFFFFFFFF75989F08
	public Int32 CreateBatchByResList(List<T0> paths, Boolean isSequential) { }

	// RVA: 0xFFFFFFFF7598A0DC
	public Int32 CreateBatchByResPathList(List<T0> paths, Boolean isSequential) { }

	// RVA: 0xFFFFFFFF7598A148
	public Int32 CreateBatchByDirectory(String directory, Boolean isSequential) { }

	// RVA: 0xFFFFFFFF7598A1A0
	public Int32 CreateBatchByLabel(String label, Boolean isSequential) { }

	// RVA: 0xFFFFFFFF7598A1F8
	public Void RegisterBatchListener(Int32 batchId, BatchListener batchListener) { }

	// RVA: 0xFFFFFFFF7598A300
	public Void UnregisterBatchListener(Int32 batchId) { }

	// RVA: 0xFFFFFFFF7598A4AC
	public Void SetPriority(Int32 batchId, Int32 priority, Int32 policy) { }

	// RVA: 0xFFFFFFFF7598A50C
	public Int32 GetDownloadingBatchId() { }

	// RVA: 0xFFFFFFFF7598A56C
	public List<T0> GetDownloadingBatchSequence() { }

	// RVA: 0xFFFFFFFF7598A620
	public Void StartDownload(Int32 batchId) { }

	// RVA: 0xFFFFFFFF7598A67C
	public Int64 GetAllResDataDownloadedBytes() { }

	// RVA: 0xFFFFFFFF7598A6DC
	public Int64 GetAllResDataTotalBytes() { }

	// RVA: 0xFFFFFFFF7598A73C
	public TGRPResInfo[] GetDownloadedResInfoList() { }

	// RVA: 0xFFFFFFFF7598A7FC
	public Int64 GetListResDataDownloadedBytes(List<T0> paths) { }

	// RVA: 0xFFFFFFFF7598A8A4
	public Int64 GetListResDataDownloadedBytes(List<T0> resInfos) { }

	// RVA: 0xFFFFFFFF7598AA78
	public TGRPResInfo[] GetNotDownloadedResInfoList() { }

	// RVA: 0xFFFFFFFF7598AB38
	public TGRPResInfo[] GetResInfoListByLabel(String label) { }

	// RVA: 0xFFFFFFFF7598ABF8
	public Int64 GetListResDataTotalBytes(List<T0> paths) { }

	// RVA: 0xFFFFFFFF7598AD74
	public Int64 GetListResDataTotalBytes(List<T0> resInfos) { }

	// RVA: 0xFFFFFFFF7598AF14
	public Int64 GetTotalBytesByLabel(String label) { }

	// RVA: 0xFFFFFFFF7598AF74
	public Int64 GetDownloadedBytesByLabel(String label) { }

	// RVA: 0xFFFFFFFF7598AFD4
	public Int32 GetResCount() { }

	// RVA: 0xFFFFFFFF7598A080
	public TGRPResInfo GetResInfo(String path) { }

	// RVA: 0xFFFFFFFF7598B03C
	public TGRPResInfo[] GetResInfoList() { }

	// RVA: 0xFFFFFFFF7598B0FC
	public Boolean IsInited() { }

	// RVA: 0xFFFFFFFF7598B15C
	public Boolean IsIniting() { }

	// RVA: 0xFFFFFFFF7598B1BC
	public Boolean IsResFileCorrect(String path) { }

	// RVA: 0xFFFFFFFF7598B21C
	public Boolean IsResFileCorrect(TGRPResInfo resinfo) { }

	// RVA: 0xFFFFFFFF7598B278
	public Boolean IsResFileDownloaded(String path) { }

	// RVA: 0xFFFFFFFF7598B2D8
	public Boolean IsResFileDownloaded(TGRPResInfo resinfo) { }

	// RVA: 0xFFFFFFFF7598B334
	public Boolean IsAllFilesDownloaded() { }

	// RVA: 0xFFFFFFFF7598B374
	public Void PauseDownload(Int32 batchId) { }

	// RVA: 0xFFFFFFFF7598B3D4
	public Void SetMaxParallelCount(Int32 cnt) { }

	// RVA: 0xFFFFFFFF7598B434
	public Void SetOnlyWifi(Boolean onlyWifi) { }

	// RVA: 0xFFFFFFFF7598B494
	public Void SetRetryTime(Int32 retryTime) { }

	// RVA: 0xFFFFFFFF7598B4F4
	public Void SetThrottleNetSpeed(Int64 speed) { }

	// RVA: 0xFFFFFFFF7598B554
	public TGRPBatchDownloadInfo GetTGRPBatchDownloadInfo(Int32 batchId) { }

	// RVA: 0xFFFFFFFF7598B5C4
	public Void ClearResNotInBatch() { }

	// RVA: 0xFFFFFFFF7598B624
	public Void SetFileSystem(Int64 cppFileSystem) { }

	// RVA: 0xFFFFFFFF7598B684
	public Void Release() { }

	// RVA: 0xFFFFFFFF7598B800
	public Void ClearBatchInfo(Int32 batchId) { }

	// RVA: 0xFFFFFFFF7598B860
	public Int32 ExcludeResFromBatch(Int32 batchId, List<T0> paths) { }

	// RVA: 0xFFFFFFFF7598B8CC
	public Void RegisterResCheckListener(Int32 batchId, ResCheckListener listener) { }

	// RVA: 0xFFFFFFFF7598BB0C
	public Void UnregisterResCheckListener(Int32 batchId) { }

	// RVA: 0xFFFFFFFF7598BCB8
	public Void ResCheck(Int32 batchId) { }

	// RVA: 0xFFFFFFFF7598BD1C
	public Void .ctor() { }

}

// Namespace: 
private struct JsonConfigStruct
{
	// Fields
	public String url; // 0x10
	public List<T0> backupHosts; // 0x18
	public List<T0> diffPatchUrls; // 0x20
	public String appBaseResJson; // 0x28
	public List<T0> incrementalPackUrls; // 0x30
	public String headers; // 0x38

	// Methods

	// RVA: 0xFFFFFFFF759892F0
	public static JsonConfigStruct CreateWithConfig(InitConfig config) { }

}

// Namespace: Hades
public class TGRPService
{
	// Fields
	private Dictionary<T0, T1> tgrpTasks; // 0x10
	private TgrpDependend _depend; // 0x18
	private Dictionary<T0, T1> batchListenerDic; // 0x20
	private Dictionary<T0, T1> resCheckListenerDic; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75989754
	public Void RegisterTgrpBatchListener(Int64 tgrpId, Int32 batchId, BatchListener batchListener) { }

	// RVA: 0xFFFFFFFF7598A3F8
	public Void UnregisterTgrpBatchListener(Int64 tgrpId, Int32 batchId) { }

	// RVA: 0xFFFFFFFF7598B9D4
	public Void RegisterResCheckListener(Int64 tgrpId, Int32 batchId, ResCheckListener resCheckListener) { }

	// RVA: 0xFFFFFFFF7598BC04
	public Void UnRegisterResCheckListener(Int64 tgrpId, Int32 batchId) { }

	// RVA: 0xFFFFFFFF7598DD88
	public Void Init(TgrpDependend depend) { }

	// RVA: 0xFFFFFFFF7598E020
	public ITGRPDownloader ObtainTGRPDownloader(String tgrpName, String parentPath, String subPath) { }

	// RVA: 0xFFFFFFFF7598E238
	public Void ReleaseTGRPDownloader(String tgrpName, String parentPath, String subPath) { }

	// RVA: 0xFFFFFFFF7598E294
	public Void PauseAllTGRPDownloaders() { }

	// RVA: 0xFFFFFFFF7598E3DC
	public Void SetLogLevel(LogPriority logLevel) { }

	// RVA: 0xFFFFFFFF7598B7A0
	public Void RemoveTgrpDownloader(Int64 tgrpId) { }

	// RVA: 0xFFFFFFFF7598E438
	public Void OnInitCallback(Int64 tgrpId, String initInfoJson, String resInfoJson) { }

	// RVA: 0xFFFFFFFF7598E520
	public Void OnDownloadCallback(Int64 tgrpId, Int32 type, String downloadInfoJson) { }

	// RVA: 0xFFFFFFFF7598E9A4
	public Void OnEventCallback(String eventName, String eventParams) { }

	// RVA: 0xFFFFFFFF75987EA4
	public Void .ctor() { }

}

// Namespace: 
private class TGRPInitParam
{
	// Fields
	public String name; // 0x10
	public String parentPath; // 0x18
	public String subPath; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF7598E230
	public Void .ctor() { }

}

// Namespace: 
public enum TGRPStatusEnum
{
	// Fields
	public Int32 value__; // 0x10
	public const TGRPStatusEnum INIT_SUCCESS = 4294967295;
	public const TGRPStatusEnum INIT_FAIL = 4294967294;
	public const TGRPStatusEnum DOWNLOAD_RES_START = 1;
	public const TGRPStatusEnum DOWNLOAD_RES_PAUSE = 2;
	public const TGRPStatusEnum DOWNLOAD_RES_SUCCESS = 3;
	public const TGRPStatusEnum DOWNLOAD_RES_FAIL = 4;
	public const TGRPStatusEnum DOWNLOAD_RES_PROGRESS = 5;
	public const TGRPStatusEnum DOWNLOAD_BATCH_START = 6;
	public const TGRPStatusEnum DOWNLOAD_BATCH_PROGRESS = 7;
	public const TGRPStatusEnum DOWNLOAD_BATCH_END = 8;
	public const TGRPStatusEnum ADD_TO_DOWNLOAD_QUEUE = 9;
	public const TGRPStatusEnum DOWNLOAD_PROGRESS = 10;
	public const TGRPStatusEnum DOWNLOAD_QUEUE_EMPTY = 11;
	public const TGRPStatusEnum ALL_RES_DOWNLOAD_SUCCESS = 12;
	public const TGRPStatusEnum RES_CHECK_START = 13;
	public const TGRPStatusEnum RES_CHECK_PROGRESS = 14;
	public const TGRPStatusEnum RES_CHECK_END = 15;
}

// Namespace: Hades
public class TgrpLoom
{
	// Fields
	public static TgrpLoom _current; // 0x0
	private static Boolean initialized; // 0x8

	// Properties
	public static TgrpLoom Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF7598DFD4
	public static TgrpLoom get_Current() { }

	// RVA: 0xFFFFFFFF7598E9D4
	public static Void Initialize() { }

	// RVA: 0xFFFFFFFF7598EAC8
	private Void Update() { }

	// RVA: 0xFFFFFFFF7598EB48
	public Void OnApplicationQuit() { }

	// RVA: 0xFFFFFFFF7598EB4C
	private Void StopTGRPDownloader() { }

	// RVA: 0xFFFFFFFF7598EC2C
	public Void .ctor() { }

}

// Namespace: testinternal
public class TestCase
{
	// Methods

	// RVA: 0xFFFFFFFF759A1A10
	public static Void testSize(IntPtr vm, AndroidJavaObject AppContext, String AppId, String Flavor, Int32 Region, Boolean Sandbox, Boolean UseGameChannel, Boolean Accountless) { }

	// RVA: 0xFFFFFFFF759A1A14
	public static Void testTriangle() { }

	// RVA: 0xFFFFFFFF759A1A18
	public static Void testCube(String did, String iid) { }

	// RVA: 0xFFFFFFFF759A1A1C
	public static Void testSquare(Int32 userType, String openId, Int64 serverId, String roleId) { }

	// RVA: 0xFFFFFFFF759A1A20
	public static Void testHeight() { }

	// RVA: 0xFFFFFFFF759A1A24
	public static Void testWidth() { }

	// RVA: 0xFFFFFFFF759A1A28
	public static Void testLength() { }

	// RVA: 0xFFFFFFFF759A1A2C
	public static Void calcDistance() { }

	// RVA: 0xFFFFFFFF759A1A30
	public Void .ctor() { }

}

// Namespace: LuaInterface
public class MonoPInvokeCallbackAttribute
{
	// Fields
	private Type type; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75993218
	public Void .ctor(Type t) { }

}

// Namespace: LuaInterface
public enum LuaTypes
{
	// Fields
	public Int32 value__; // 0x10
	public const LuaTypes LUA_TNONE = 4294967295;
	public const LuaTypes LUA_TNIL = 0;
	public const LuaTypes LUA_TNUMBER = 3;
	public const LuaTypes LUA_TSTRING = 4;
	public const LuaTypes LUA_TBOOLEAN = 1;
	public const LuaTypes LUA_TTABLE = 5;
	public const LuaTypes LUA_TFUNCTION = 6;
	public const LuaTypes LUA_TUSERDATA = 7;
	public const LuaTypes LUA_TTHREAD = 8;
	public const LuaTypes LUA_TLIGHTUSERDATA = 2;
}

// Namespace: LuaInterface
public enum LuaGCOptions
{
	// Fields
	public Int32 value__; // 0x10
	public const LuaGCOptions LUA_GCSTOP = 0;
	public const LuaGCOptions LUA_GCRESTART = 1;
	public const LuaGCOptions LUA_GCCOLLECT = 2;
	public const LuaGCOptions LUA_GCCOUNT = 3;
	public const LuaGCOptions LUA_GCCOUNTB = 4;
	public const LuaGCOptions LUA_GCSTEP = 5;
	public const LuaGCOptions LUA_GCSETPAUSE = 6;
	public const LuaGCOptions LUA_GCSETSTEPMUL = 7;
}

// Namespace: LuaInterface
public enum LuaThreadStatus
{
	// Fields
	public Int32 value__; // 0x10
	public const LuaThreadStatus LUA_YIELD = 1;
	public const LuaThreadStatus LUA_ERRRUN = 2;
	public const LuaThreadStatus LUA_ERRSYNTAX = 3;
	public const LuaThreadStatus LUA_ERRMEM = 4;
	public const LuaThreadStatus LUA_ERRERR = 5;
}

// Namespace: LuaInterface
public class LuaIndexes
{
	// Fields
	public static Int32 LUA_REGISTRYINDEX; // 0x0
	public static Int32 LUA_ENVIRONINDEX; // 0x4
	public static Int32 LUA_GLOBALSINDEX; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF759931EC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759931F4
	private static Void .cctor() { }

}

// Namespace: LuaInterface
public struct ReaderInfo
{
	// Fields
	public String chunkData; // 0x10
	public Boolean finished; // 0x18
}

// Namespace: LuaInterface
public sealed class LuaCSFunction
{
	// Methods

	// RVA: 0xFFFFFFFF75990B58
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75990B6C
	public virtual Int32 Invoke(IntPtr luaState) { }

	// RVA: 0xFFFFFFFF75990DC0
	public virtual IAsyncResult BeginInvoke(IntPtr luaState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75990E50
	public virtual Int32 EndInvoke(IAsyncResult result) { }

}

// Namespace: LuaInterface
public sealed class LuaChunkReader
{
	// Methods

	// RVA: 0xFFFFFFFF75990E7C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75990E90
	public virtual String Invoke(IntPtr luaState, ref ReaderInfo data, ref UInt32 size) { }

	// RVA: 0xFFFFFFFF75991114
	public virtual IAsyncResult BeginInvoke(IntPtr luaState, ref ReaderInfo data, ref UInt32 size, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759911FC
	public virtual String EndInvoke(ref ReaderInfo data, ref UInt32 size, IAsyncResult result) { }

}

// Namespace: LuaInterface
public sealed class LuaFunctionCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75992EC8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75992EDC
	public virtual Int32 Invoke(IntPtr luaState) { }

	// RVA: 0xFFFFFFFF75993130
	public virtual IAsyncResult BeginInvoke(IntPtr luaState, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759931C0
	public virtual Int32 EndInvoke(IAsyncResult result) { }

}

// Namespace: LuaInterface
public class LuaDLL
{
	// Fields
	public static Int32 LUA_MULTRET; // 0x0
	private const String LUADLL = "__Internal";
	public static Boolean s_useToStringNew; // 0x4
	public static Int32 s_useToStringNewMaxCount; // 0x8
	private static MutableString ms; // 0x10
	public static Boolean s_usePushStringNew; // 0x18
	private static Byte[] _pushStringSwapBuffer; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75991250
	public static extern Int32 tolua_openlibs(IntPtr L) { }

	// RVA: 0xFFFFFFFF75991254
	public static extern Int32 luaopen_sdplua(IntPtr L) { }

	// RVA: 0xFFFFFFFF75991258
	public static extern Int32 luaopen_rudp(IntPtr L) { }

	// RVA: 0xFFFFFFFF7599125C
	public static extern Int32 luaopen_socket_core(IntPtr L) { }

	// RVA: 0xFFFFFFFF75991260
	public static Int32 lua_upvalueindex(Int32 i) { }

	// RVA: 0xFFFFFFFF759912A8
	public static extern Int32 lua_tothread(IntPtr L, Int32 index) { }

	// RVA: 0xFFFFFFFF759912AC
	public static extern Int32 lua_xmove(IntPtr from, IntPtr to, Int32 n) { }

	// RVA: 0xFFFFFFFF759912B0
	public static extern Int32 lua_yield(IntPtr L, Int32 nresults) { }

	// RVA: 0xFFFFFFFF759912B4
	public static extern IntPtr lua_newthread(IntPtr L) { }

	// RVA: 0xFFFFFFFF759912B8
	public static extern Int32 lua_resume(IntPtr L, Int32 narg) { }

	// RVA: 0xFFFFFFFF759912BC
	public static extern Int32 lua_status(IntPtr L) { }

	// RVA: 0xFFFFFFFF759912C0
	public static extern Int32 lua_pushthread(IntPtr L) { }

	// RVA: 0xFFFFFFFF759912C4
	public static Int32 luaL_getn(IntPtr luaState, Int32 i) { }

	// RVA: 0xFFFFFFFF7599130C
	public static extern Int32 lua_gc(IntPtr luaState, LuaGCOptions what, Int32 data) { }

	// RVA: 0xFFFFFFFF75991310
	public static extern String lua_typename(IntPtr luaState, LuaTypes type) { }

	// RVA: 0xFFFFFFFF75991344
	public static String luaL_typename(IntPtr luaState, Int32 stackPos) { }

	// RVA: 0xFFFFFFFF759913B4
	public static Int32 lua_isfunction(IntPtr luaState, Int32 stackPos) { }

	// RVA: 0xFFFFFFFF75991428
	public static Int32 lua_islightuserdata(IntPtr luaState, Int32 stackPos) { }

	// RVA: 0xFFFFFFFF7599149C
	public static Int32 lua_istable(IntPtr luaState, Int32 stackPos) { }

	// RVA: 0xFFFFFFFF75991510
	public static Int32 lua_isthread(IntPtr luaState, Int32 stackPos) { }

	// RVA: 0xFFFFFFFF75991584
	public static extern Int32 luaL_error_rethrow(IntPtr luaState, String message) { }

	// RVA: 0xFFFFFFFF759915C8
	public static Int32 luaL_error(IntPtr luaState, String message) { }

	// RVA: 0xFFFFFFFF759915E4
	public static extern String luaL_gsub(IntPtr luaState, String str, String pattern, String replacement) { }

	// RVA: 0xFFFFFFFF75991680
	public static extern Void lua_getfenv(IntPtr luaState, Int32 stackPos) { }

	// RVA: 0xFFFFFFFF75991684
	public static extern Int32 lua_isuserdata(IntPtr luaState, Int32 stackPos) { }

	// RVA: 0xFFFFFFFF75991688
	public static extern Int32 lua_lessthan(IntPtr luaState, Int32 stackPos1, Int32 stackPos2) { }

	// RVA: 0xFFFFFFFF7599168C
	public static extern Int32 lua_rawequal(IntPtr luaState, Int32 stackPos1, Int32 stackPos2) { }

	// RVA: 0xFFFFFFFF75991690
	public static extern Int32 lua_setfenv(IntPtr luaState, Int32 stackPos) { }

	// RVA: 0xFFFFFFFF75991694
	public static extern Void lua_setfield(IntPtr luaState, Int32 stackPos, String name) { }

	// RVA: 0xFFFFFFFF759916DC
	public static extern Int32 luaL_callmeta(IntPtr luaState, Int32 stackPos, String name) { }

	// RVA: 0xFFFFFFFF75991730
	public static extern IntPtr luaL_newstate() { }

	// RVA: 0xFFFFFFFF75991734
	public static IntPtr lua_open() { }

	// RVA: 0xFFFFFFFF75991760
	public static extern Void lua_close(IntPtr luaState) { }

	// RVA: 0xFFFFFFFF75991764
	public static extern Void luaL_openlibs(IntPtr luaState) { }

	// RVA: 0xFFFFFFFF75991308
	public static extern Int32 lua_objlen(IntPtr luaState, Int32 stackPos) { }

	// RVA: 0xFFFFFFFF75991768
	public static Int32 lua_strlen(IntPtr luaState, Int32 stackPos) { }

	// RVA: 0xFFFFFFFF759917AC
	public static extern Int32 luaL_loadstring(IntPtr luaState, String chunk) { }

	// RVA: 0xFFFFFFFF759917F0
	public static Int32 luaL_dostring(IntPtr luaState, String chunk) { }

	// RVA: 0xFFFFFFFF75991884
	public static Int32 lua_dostring(IntPtr luaState, String chunk) { }

	// RVA: 0xFFFFFFFF759918C8
	public static extern Void lua_createtable(IntPtr luaState, Int32 narr, Int32 nrec) { }

	// RVA: 0xFFFFFFFF759918CC
	public static Void lua_newtable(IntPtr luaState) { }

	// RVA: 0xFFFFFFFF75991910
	public static Int32 luaL_dofile(IntPtr luaState, String fileName) { }

	// RVA: 0xFFFFFFFF759919E4
	public static Void lua_getglobal(IntPtr luaState, String name) { }

	// RVA: 0xFFFFFFFF75991BC0
	public static Void lua_setglobal(IntPtr luaState, String name) { }

	// RVA: 0xFFFFFFFF75991C4C
	public static Void lua_rawglobal(IntPtr luaState, String name) { }

	// RVA: 0xFFFFFFFF75991CC4
	public static extern Void lua_settop(IntPtr luaState, Int32 newTop) { }

	// RVA: 0xFFFFFFFF75991CC8
	public static Void lua_pop(IntPtr luaState, Int32 amount) { }

	// RVA: 0xFFFFFFFF75991D0C
	public static extern Void lua_insert(IntPtr luaState, Int32 newTop) { }

	// RVA: 0xFFFFFFFF75991D10
	public static extern Void lua_remove(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF75991BBC
	public static extern Void lua_gettable(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF75991CC0
	public static extern Void lua_rawget(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF75991D14
	public static extern Void lua_settable(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF75991D18
	public static extern Void lua_rawset(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF75991D1C
	public static extern Void lua_setmetatable(IntPtr luaState, Int32 objIndex) { }

	// RVA: 0xFFFFFFFF75991D20
	public static extern Int32 lua_getmetatable(IntPtr luaState, Int32 objIndex) { }

	// RVA: 0xFFFFFFFF75991D24
	public static extern Int32 lua_equal(IntPtr luaState, Int32 index1, Int32 index2) { }

	// RVA: 0xFFFFFFFF75991D28
	public static extern Void lua_pushvalue(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF75991D2C
	public static extern Void lua_replace(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF75991D30
	public static extern Int32 lua_gettop(IntPtr luaState) { }

	// RVA: 0xFFFFFFFF759913B0
	public static extern LuaTypes lua_type(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF75991D34
	public static Boolean lua_isnil(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF75991D84
	public static extern Boolean lua_isnumber(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF75991DA0
	public static Boolean lua_isboolean(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF75991DF0
	public static extern Int32 luaL_ref(IntPtr luaState, Int32 registryIndex) { }

	// RVA: 0xFFFFFFFF75991DF4
	public static Int32 lua_ref(IntPtr luaState, Int32 lockRef) { }

	// RVA: 0xFFFFFFFF75991E68
	public static extern Void lua_rawgeti(IntPtr luaState, Int32 tableIndex, Int32 index) { }

	// RVA: 0xFFFFFFFF75991E6C
	public static extern Void lua_rawseti(IntPtr luaState, Int32 tableIndex, Int32 index) { }

	// RVA: 0xFFFFFFFF75991E70
	public static extern IntPtr lua_newuserdata(IntPtr luaState, Int32 size) { }

	// RVA: 0xFFFFFFFF75991E74
	public static extern IntPtr lua_touserdata(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF75991E78
	public static Void lua_getref(IntPtr luaState, Int32 reference) { }

	// RVA: 0xFFFFFFFF75991EF0
	public static extern Void luaL_unref(IntPtr luaState, Int32 registryIndex, Int32 reference) { }

	// RVA: 0xFFFFFFFF75991EF4
	public static Void lua_unref(IntPtr luaState, Int32 reference) { }

	// RVA: 0xFFFFFFFF75991F6C
	public static extern Boolean lua_isstring(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF75991F88
	public static extern Boolean lua_iscfunction(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF75991FA4
	public static extern Void lua_pushnil(IntPtr luaState) { }

	// RVA: 0xFFFFFFFF75991FA8
	public static Void lua_pushstdcallcfunction(IntPtr luaState, LuaCSFunction function, Int32 n) { }

	// RVA: 0xFFFFFFFF75992110
	public static extern Void lua_call(IntPtr luaState, Int32 nArgs, Int32 nResults) { }

	// RVA: 0xFFFFFFFF75991880
	public static extern Int32 lua_pcall(IntPtr luaState, Int32 nArgs, Int32 nResults, Int32 errfunc) { }

	// RVA: 0xFFFFFFFF75992114
	public static extern IntPtr lua_tocfunction(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF75992118
	public static extern Double lua_tonumber(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF7599211C
	public static extern Boolean lua_toboolean(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF75992138
	public static extern IntPtr lua_tolstring(IntPtr luaState, Int32 index, out IntPtr strLen) { }

	// RVA: 0xFFFFFFFF7599213C
	private static String AnsiToUnicode(IntPtr source, Int32 strlen) { }

	// RVA: 0xFFFFFFFF759921C8
	public static String lua_tostring(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF759927FC
	public static extern Void lua_atpanic(IntPtr luaState, LuaCSFunction panicf) { }

	// RVA: 0xFFFFFFFF75992828
	public static extern Void lua_pushnumber(IntPtr luaState, Double number) { }

	// RVA: 0xFFFFFFFF7599282C
	public static extern Void lua_pushinteger(IntPtr luaState, IntPtr number) { }

	// RVA: 0xFFFFFFFF75992830
	public static Void pushinteger(IntPtr luaState, Int32 number) { }

	// RVA: 0xFFFFFFFF75992880
	public static extern Void lua_pushboolean(IntPtr luaState, Boolean value) { }

	// RVA: 0xFFFFFFFF75992884
	public static extern Void lua_pushlstring(IntPtr luaState, Byte[] str, Int32 size) { }

	// RVA: 0xFFFFFFFF75992894
	private static extern Void lua_pushstring(IntPtr luaState, String str) { }

	// RVA: 0xFFFFFFFF75991A58
	public static Void lua_pushstring_new(IntPtr luaState, String str) { }

	// RVA: 0xFFFFFFFF759928CC
	public static extern Int32 luaL_newmetatable(IntPtr luaState, String meta) { }

	// RVA: 0xFFFFFFFF75992910
	public static extern Void lua_getfield(IntPtr luaState, Int32 stackPos, String meta) { }

	// RVA: 0xFFFFFFFF75992958
	public static Void luaL_getmetatable(IntPtr luaState, String meta) { }

	// RVA: 0xFFFFFFFF759929E4
	public static extern IntPtr luaL_checkudata(IntPtr luaState, Int32 stackPos, String meta) { }

	// RVA: 0xFFFFFFFF75992A38
	public static extern LuaTypes luaL_getmetafield(IntPtr luaState, Int32 stackPos, String field) { }

	// RVA: 0xFFFFFFFF75992A8C
	public static extern Int32 lua_load(IntPtr luaState, LuaChunkReader chunkReader, ref ReaderInfo data, String chunkName) { }

	// RVA: 0xFFFFFFFF75992B60
	public static extern Int32 luaL_loadbuffer(IntPtr luaState, Byte[] buff, Int32 size, String name) { }

	// RVA: 0xFFFFFFFF759919A0
	public static extern Int32 luaL_loadfile(IntPtr luaState, String filename) { }

	// RVA: 0xFFFFFFFF75992BC4
	public static extern Boolean luaL_checkmetatable(IntPtr luaState, Int32 obj) { }

	// RVA: 0xFFFFFFFF75992BE0
	public static extern Int32 luanet_tonetobject(IntPtr luaState, Int32 obj) { }

	// RVA: 0xFFFFFFFF75992BE4
	public static extern Void luanet_newudata(IntPtr luaState, Int32 val) { }

	// RVA: 0xFFFFFFFF75992BE8
	public static extern Int32 luanet_rawnetobj(IntPtr luaState, Int32 obj) { }

	// RVA: 0xFFFFFFFF75992BEC
	public static extern Int32 luanet_checkudata(IntPtr luaState, Int32 obj, String meta) { }

	// RVA: 0xFFFFFFFF75992C40
	public static extern Void lua_error(IntPtr luaState) { }

	// RVA: 0xFFFFFFFF75992C44
	public static extern Boolean lua_checkstack(IntPtr luaState, Int32 extra) { }

	// RVA: 0xFFFFFFFF75992C60
	public static extern Int32 lua_next(IntPtr luaState, Int32 index) { }

	// RVA: 0xFFFFFFFF75992C64
	public static extern Void lua_pushlightuserdata(IntPtr luaState, IntPtr udata) { }

	// RVA: 0xFFFFFFFF75992C68
	public static extern IntPtr luanet_gettag() { }

	// RVA: 0xFFFFFFFF75992C6C
	public static extern Void luaL_where(IntPtr luaState, Int32 level) { }

	// RVA: 0xFFFFFFFF75992C70
	public static extern Void lua_pushcclosure(IntPtr luaState, IntPtr fn, Int32 n) { }

	// RVA: 0xFFFFFFFF75992C74
	public static extern String lua_getupvalue(IntPtr L, Int32 funcindex, Int32 n) { }

	// RVA: 0xFFFFFFFF75992CA8
	public static Int32 luaL_typerror(IntPtr luaState, Int32 narg, String tname) { }

	// RVA: 0xFFFFFFFF75992D48
	public static Int32 luaL_argerror(IntPtr luaState, Int32 narg, String extramsg) { }

	// RVA: 0xFFFFFFFF75992DFC
	public static extern Void tolua_getfloat2(IntPtr luaState, Int32 reference, Int32 stack, ref Single x, ref Single y) { }

	// RVA: 0xFFFFFFFF75992E00
	public static extern Void tolua_getfloat3(IntPtr luaState, Int32 reference, Int32 stack, ref Single x, ref Single y, ref Single z) { }

	// RVA: 0xFFFFFFFF75992E04
	public static extern Void tolua_getfloat4(IntPtr luaState, Int32 reference, Int32 stack, ref Single x, ref Single y, ref Single z, ref Single w) { }

	// RVA: 0xFFFFFFFF75992E08
	public static extern Void tolua_getfloat6(IntPtr luaState, Int32 reference, Int32 stack, ref Single x, ref Single y, ref Single z, ref Single x1, ref Single y1, ref Single z1) { }

	// RVA: 0xFFFFFFFF75992E14
	public static extern Void tolua_pushfloat2(IntPtr luaState, Int32 reference, Single x, Single y) { }

	// RVA: 0xFFFFFFFF75992E18
	public static extern Void tolua_pushfloat3(IntPtr luaState, Int32 reference, Single x, Single y, Single z) { }

	// RVA: 0xFFFFFFFF75992E1C
	public static extern Void tolua_pushfloat4(IntPtr luaState, Int32 reference, Single x, Single y, Single z, Single w) { }

	// RVA: 0xFFFFFFFF75992E20
	public static extern Boolean tolua_pushudata(IntPtr L, Int32 reference, Int32 index) { }

	// RVA: 0xFFFFFFFF75992E3C
	public static extern Boolean tolua_pushnewudata(IntPtr L, Int32 metaRef, Int32 weakTableRef, Int32 index) { }

	// RVA: 0xFFFFFFFF75992E58
	public static extern Void tolua_setindex(IntPtr L) { }

	// RVA: 0xFFFFFFFF75992E5C
	public static extern Void tolua_setnewindex(IntPtr L) { }

	// RVA: 0xFFFFFFFF75992E60
	public static extern UInt32 tolua_getmemory(IntPtr L) { }

	// RVA: 0xFFFFFFFF75992E64
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75992E6C
	private static Void .cctor() { }

}

// Namespace: LuaInterface
public static class LuaDLLToStringCounter
{
	// Methods

	// RVA: 0xFFFFFFFF759927F8
	public static Void Stats(String str) { }

	// RVA: 0xFFFFFFFF75992EC4
	public static Void Save() { }

}

// Namespace: LuaInterface
public static class LuaDLLToStringIntern
{
	// Methods

	// RVA: 0xFFFFFFFF7599241C
	public static Void Init(Int32 maxCount) { }

}

// Namespace: LuaInterface
public class MutableString
{
	// Fields
	private String m_buffer; // 0x10
	private Int32 m_capacity; // 0x18
	private static List<T0> assistCharList; // 0x0

	// Properties
	public Int32 Length { get; }

	// Methods

	// RVA: 0xFFFFFFFF759923A8
	public Void .ctor(Int32 capacity) { }

	// RVA: 0xFFFFFFFF7599324C
	public sealed override String ToString() { }

	// RVA: 0xFFFFFFFF75993254
	public Void Reset() { }

	// RVA: 0xFFFFFFFF75993284
	public Int32 get_Length() { }

	// RVA: 0xFFFFFFFF759932C0
	private Void ExpandIfFull(Int32 targetCapacity) { }

	// RVA: 0xFFFFFFFF75993384
	public Void Append(Char c) { }

	// RVA: 0xFFFFFFFF75993408
	public Void Append(Single v, Int32 pointLength) { }

	// RVA: 0xFFFFFFFF7599356C
	public Void Append(Int32 n, Int32 minLen) { }

	// RVA: 0xFFFFFFFF75993750
	public Void Append(String str) { }

	// RVA: 0xFFFFFFFF75992664
	public Boolean FromUTF8(IntPtr src, Int32 len) { }

	// RVA: 0xFFFFFFFF759927B4
	public String GetCopy() { }

	// RVA: 0xFFFFFFFF75993848
	private static Void .cctor() { }

}

// Namespace: LuaInterface
public class ULuaExt
{
	// Fields
	private static List<T0> s_funcList; // 0x0
	private static lua_CSFunction FixCSFunctionWraper; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF759938B4
	private static Int32 FixCSFunction(IntPtr L) { }

	// RVA: 0xFFFFFFFF7599201C
	public static Int32 PushStdcallCFunction(IntPtr luaState, LuaCSFunction function, Int32 n) { }

	// RVA: 0xFFFFFFFF75993A48
	public static Void ClearFixedFuncList() { }

	// RVA: 0xFFFFFFFF75993AC4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75993ACC
	private static Void .cctor() { }

}

// Namespace: MobaPlugin.AOTLib
public struct AvProNativeLib
{
	// Methods

	// RVA: 0xFFFFFFFF75994598
	public static extern IntPtr GetRenderEventFunc() { }

	// RVA: 0xFFFFFFFF75994608
	public static extern Int32 _GetWidth(Int32 iPlayerIndex) { }

	// RVA: 0xFFFFFFFF75994688
	public static extern Int32 _GetHeight(Int32 iPlayerIndex) { }

	// RVA: 0xFFFFFFFF75994704
	public static extern Int32 _GetTextureHandle(Int32 iPlayerIndex) { }

	// RVA: 0xFFFFFFFF75994784
	public static extern Int64 _GetDuration(Int32 iPlayerIndex) { }

	// RVA: 0xFFFFFFFF75994804
	public static extern Int32 _GetLastErrorCode(Int32 iPlayerIndex) { }

	// RVA: 0xFFFFFFFF75994884
	public static extern Int32 _GetFrameCount(Int32 iPlayerIndex) { }

	// RVA: 0xFFFFFFFF75994904
	public static extern Single _GetVideoDisplayRate(Int32 iPlayerIndex) { }

	// RVA: 0xFFFFFFFF75994984
	public static extern Boolean _CanPlay(Int32 iPlayerIndex) { }

}


