// Namespace: 
internal class <Module>
{}

// Namespace: 
internal class AssemblyManager
{
	// Fields
	private static AssemblyManager _instance; // 0x0
	private List<T0> m_assemblies; // 0x10

	// Properties
	public static AssemblyManager Instance { get; }

	// Methods

	// RVA: 0xFFFFFFFF7469C220
	public static AssemblyManager get_Instance() { }

	// RVA: 0xFFFFFFFF7469C2A0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF7469C3F4
	public Void AddAssembly(Assembly assembly) { }

	// RVA: 0xFFFFFFFF7469C418
	public Type GetType(String typeName) { }

	// RVA: 0xFFFFFFFF7469C588
	public List<T0> GetTypes() { }

}

// Namespace: HybridCLR
public class GameLoader
{
	// Fields
	private static String lastGame; // 0x0
	private static String entryGame; // 0x8
	private String gamePath; // 0x10
	private String assemblyPath; // 0x18
	private String gameEntryTypeName; // 0x20
	private String argJson; // 0x28
	private Type entryType; // 0x30
	private Action<T0> eventCallback; // 0x38
	private static Boolean s_enablePreheat; // 0x10
	private static Boolean s_initedOpt; // 0x11

	// Methods

	// RVA: 0xFFFFFFFF7469C6E4
	private static Void InitLocalOpt() { }

	// RVA: 0xFFFFFFFF7469C8E4
	public Void .ctor(String pPath, String asmPath, Action<T0> eventCB, String entryTypeName, String argJsonStr) { }

	// RVA: 0xFFFFFFFF7469C9DC
	public Int32 Load() { }

	// RVA: 0xFFFFFFFF7469DFCC
	public Int32 Quit() { }

	// RVA: 0xFFFFFFFF7469E148
	public Int32 Unload() { }

	// RVA: 0xFFFFFFFF7469D7B4
	private Void InitComponentBridge() { }

	// RVA: 0xFFFFFFFF7469E33C
	private static Void .cctor() { }

}

// Namespace: HybridCLR
public class HybridFileInfo
{
	// Fields
	public String name; // 0x10
	public String res_path; // 0x18
	public Int32 len; // 0x20
	public String md5; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF7469E3A0
	public Void .ctor() { }

}

// Namespace: HybridCLR
public class HybridFiles
{
	// Fields
	public String version; // 0x10
	public Boolean isHybridEnable; // 0x18
	public List<T0> patchAOTList; // 0x20
	public List<T0> remoteUpdateList; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF7469E3A8
	public Void .ctor() { }

}

// Namespace: HybridCLR
public class HybridLoader
{
	// Fields
	private const String configName = "HybridFiles.json";
	private const Boolean HybridCLREnabled = 1;
	private static LogCallback messageCallback; // 0x0
	private static NativeLogCallback nativeLogCallback; // 0x8
	private HybridFiles hybridFiles; // 0x10
	private String hybridPersistentDataAssetsPath; // 0x18
	private String hybridStreamingAssetsPath; // 0x20
	private Dictionary<T0, T1> remoteUpdateAssemblyDict; // 0x28
	private HashSet<T0> aotPatchAssemblys; // 0x30
	private String curDataPath; // 0x38
	private static HybridLoader m_Instance; // 0x10

	// Properties
	public static HybridLoader Instance { get; set; }
	public static String DragonFolder { get; }

	// Methods

	// RVA: 0xFFFFFFFF7469CFF8
	public static HybridLoader get_Instance() { }

	// RVA: 0xFFFFFFFF7469E414
	public static Void set_Instance(HybridLoader value) { }

	// RVA: 0xFFFFFFFF7469E464
	public static String get_DragonFolder() { }

	// RVA: 0xFFFFFFFF7469E4A4
	public static extern Int32 il2cpp_init_hybridclr(Int32 state) { }

	// RVA: 0xFFFFFFFF7469E4A8
	public static extern Int32 il2cpp_hybridclr_enabled() { }

	// RVA: 0xFFFFFFFF7469E4AC
	private static extern Void hybridclr_setlogcallback(NativeLogCallback callback) { }

	// RVA: 0xFFFFFFFF7469E4C0
	public static Boolean IsHybridCLREnabled() { }

	// RVA: 0xFFFFFFFF7469D078
	public Void Init(String dataPath) { }

	// RVA: 0xFFFFFFFF7469D22C
	public Void LoadHybridFiles() { }

	// RVA: 0xFFFFFFFF7469E7EC
	private Byte[] LoadHybridBytes(String resPath) { }

	// RVA: 0xFFFFFFFF7469E558
	private Boolean LoadHybridConfig() { }

	// RVA: 0xFFFFFFFF7469EB34
	public Type GetRemoteUpdateAssemblyTypeForComponent(String typeName) { }

	// RVA: 0xFFFFFFFF7469EFFC
	public Assembly GetAssembly(String name) { }

	// RVA: 0xFFFFFFFF7469F120
	public Boolean UnloadAssembly(String name) { }

	// RVA: 0xFFFFFFFF7469E1C4
	public Boolean UnloadAllAssembly() { }

	// RVA: 0xFFFFFFFF7469E2EC
	public IEnumerable<T0> GetAssemblies() { }

	// RVA: 0xFFFFFFFF7469DA3C
	public Type GetRemoteUpdateAssemblyType(String typeName) { }

	// RVA: 0xFFFFFFFF7469DCA0
	public static Void Log(String msg) { }

	// RVA: 0xFFFFFFFF7469D72C
	public static Void LogError(String msg) { }

	// RVA: 0xFFFFFFFF7469E3B0
	private static Void OnNativeLog(IntPtr ptr, Int32 type) { }

	// RVA: 0xFFFFFFFF7469F5F8
	public static Void SetLogCallback(LogCallback callback) { }

	// RVA: 0xFFFFFFFF7469DD28
	public Void PreheatTotalAssembly(Assembly asm) { }

	// RVA: 0xFFFFFFFF7469E40C
	public Void .ctor() { }

}

// Namespace: 
public sealed class LogCallback
{
	// Methods

	// RVA: 0xFFFFFFFF7469F784
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7469F1D4
	public virtual Void Invoke(String msg, LogType type) { }

	// RVA: 0xFFFFFFFF7469F798
	public virtual IAsyncResult BeginInvoke(String msg, LogType type, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7469F858
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class NativeLogCallback
{
	// Methods

	// RVA: 0xFFFFFFFF7469F770
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7469F864
	public virtual Void Invoke(IntPtr ptr, Int32 type) { }

	// RVA: 0xFFFFFFFF7469FAD0
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Int32 type, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF7469FB78
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: HybridCLR
internal class ILog
{
	// Fields
	private static LogLevel m_gLogLevel; // 0x0
	public static Boolean s_printToUnity; // 0x4

	// Methods

	// RVA: 0xFFFFFFFF7469FB84
	public static Void SetILogLevel(LogLevel level) { }

	// RVA: 0xFFFFFFFF7469FBE8
	public static Void InfoFormat(String format, Object[] args) { }

	// RVA: 0xFFFFFFFF7469FC30
	public static Void Error(String v) { }

	// RVA: 0xFFFFFFFF7469FC70
	public static Void ErrorFormat(String format, Object[] args) { }

	// RVA: 0xFFFFFFFF7469FCB8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF7469FCC0
	private static Void .cctor() { }

}

// Namespace: 
public enum LogLevel
{
	// Fields
	public Int32 value__; // 0x10
	public const LogLevel DebugLevel = 0;
	public const LogLevel InfoLevel = 1;
	public const LogLevel WarnLevel = 2;
	public const LogLevel ErrorLevel = 3;
}


