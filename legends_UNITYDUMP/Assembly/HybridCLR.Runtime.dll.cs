// Namespace: 
internal class <Module>
{}

// Namespace: HybridCLR
public enum HomologousImageMode
{
	// Fields
	public Int32 value__; // 0x10
	public const HomologousImageMode Consistent = 0;
	public const HomologousImageMode SuperSet = 1;
}

// Namespace: HybridCLR
public enum LoadImageErrorCode
{
	// Fields
	public Int32 value__; // 0x10
	public const LoadImageErrorCode OK = 0;
	public const LoadImageErrorCode BAD_IMAGE = 1;
	public const LoadImageErrorCode NOT_IMPLEMENT = 2;
	public const LoadImageErrorCode AOT_ASSEMBLY_NOT_FIND = 3;
	public const LoadImageErrorCode HOMOLOGOUS_ONLY_SUPPORT_AOT_ASSEMBLY = 4;
	public const LoadImageErrorCode HOMOLOGOUS_ASSEMBLY_HAS_LOADED = 5;
	public const LoadImageErrorCode INVALID_HOMOLOGOUS_MODE = 6;
	public const LoadImageErrorCode PDB_BAD_FILE = 7;
	public const LoadImageErrorCode UNKNOWN_IMAGE_FORMAT = 8;
	public const LoadImageErrorCode UNSUPPORT_FORMAT_VERSION = 9;
	public const LoadImageErrorCode UNSUPPORT_ENCRYPTION_ALGORHITHM = 10;
}

// Namespace: HybridCLR
public static class RuntimeApi
{
	// Methods

	// RVA: 0xFFFFFFFF759A1A38
	public static LoadImageErrorCode LoadMetadataForAOTAssembly(Byte[] dllBytes, HomologousImageMode mode) { }

	// RVA: 0xFFFFFFFF759A1A88
	public static Boolean PreJitMethod(MethodInfo method) { }

	// RVA: 0xFFFFFFFF759A1AC8
	public static Boolean PreJitClass(Type type) { }

	// RVA: 0xFFFFFFFF759A1B08
	public static Int32 GetInterpreterThreadObjectStackSize() { }

	// RVA: 0xFFFFFFFF759A1B84
	public static Void SetInterpreterThreadObjectStackSize(Int32 size) { }

	// RVA: 0xFFFFFFFF759A1C18
	public static Int32 GetInterpreterThreadFrameStackSize() { }

	// RVA: 0xFFFFFFFF759A1C54
	public static Void SetInterpreterThreadFrameStackSize(Int32 size) { }

	// RVA: 0xFFFFFFFF759A1C98
	public static Boolean IsTransformOptimizationEnabled() { }

	// RVA: 0xFFFFFFFF759A1CE0
	public static Void EnableTransformOptimization(Boolean enable) { }

	// RVA: 0xFFFFFFFF759A1D48
	public static Boolean IsDisableMetadataReuse() { }

	// RVA: 0xFFFFFFFF759A1BC8
	public static Void SetRuntimeOption(RuntimeOptionId optionId, Int32 value) { }

	// RVA: 0xFFFFFFFF759A1B44
	public static Int32 GetRuntimeOption(RuntimeOptionId optionId) { }

	// RVA: 0xFFFFFFFF759A1D90
	public static Boolean IsFullGenericSharingEnabled() { }

	// RVA: 0xFFFFFFFF759A1D98
	public static Boolean TryUnloadAssembly(Assembly assembly, Boolean printObjectReferenceLink) { }

	// RVA: 0xFFFFFFFF759A1DE8
	public static Boolean ForceUnloadAssembly(Assembly assembly, Boolean ignoreObjectReferenceValidation, Boolean printObjectReferenceLink) { }

	// RVA: 0xFFFFFFFF759A1E40
	public static Void LoadAccessPolicy(Byte[] accessPolicyData) { }

}

// Namespace: HybridCLR
public enum RuntimeOptionId
{
	// Fields
	public Int32 value__; // 0x10
	public const RuntimeOptionId InterpreterThreadObjectStackSize = 1;
	public const RuntimeOptionId InterpreterThreadFrameStackSize = 2;
	public const RuntimeOptionId ThreadExceptionFlowSize = 3;
	public const RuntimeOptionId MaxMethodBodyCacheSize = 4;
	public const RuntimeOptionId MaxMethodInlineDepth = 5;
	public const RuntimeOptionId MaxInlineableMethodBodySize = 6;
	public const RuntimeOptionId TransformOptimization = 100;
	public const RuntimeOptionId DisableMetadataReuse = 200;
}


