// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
internal sealed class AssetFileNameExtensionAttribute
{
	// Fields
	private readonly String <preferredExtension>k__BackingField; // 0x10
	private readonly IEnumerable<T0> <otherExtensions>k__BackingField; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75C7E1E0
	public Void .ctor(String preferredExtension, String[] otherExtensions) { }

}

// Namespace: UnityEngine
internal class ThreadAndSerializationSafeAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75C7EDF4
	public Void .ctor() { }

}

// Namespace: UnityEngine
internal class WritableAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75C7EE04
	public Void .ctor() { }

}

// Namespace: UnityEngine
internal class RejectDragAndDropMaterial
{
	// Methods

	// RVA: 0xFFFFFFFF75C7ECCC
	public Void .ctor() { }

}

// Namespace: UnityEngine
internal class UnityEngineModuleAssembly
{
	// Methods

	// RVA: 0xFFFFFFFF75C7EDFC
	public Void .ctor() { }

}

// Namespace: UnityEngine
internal sealed class NativeClassAttribute
{
	// Fields
	private String <QualifiedNativeName>k__BackingField; // 0x10
	private String <Declaration>k__BackingField; // 0x18

	// Properties
	private String QualifiedNativeName { set; }
	private String Declaration { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C7EB48
	private Void set_QualifiedNativeName(String value) { }

	// RVA: 0xFFFFFFFF75C7EB80
	private Void set_Declaration(String value) { }

	// RVA: 0xFFFFFFFF75C7EBB8
	public Void .ctor(String qualifiedCppName) { }

	// RVA: 0xFFFFFFFF75C7EC5C
	public Void .ctor(String qualifiedCppName, String declaration) { }

}

// Namespace: UnityEngine
public sealed class UnityString
{
	// Methods

	// RVA: 0xFFFFFFFF723D5C3C
	public static String Format(String fmt, Object[] args) { }

}

// Namespace: UnityEngine.Bindings
internal class VisibleToOtherModulesAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75C7EB38
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C7EB40
	public Void .ctor(String[] modules) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeConditionalAttribute
{
	// Fields
	private String <Condition>k__BackingField; // 0x10
	private Boolean <Enabled>k__BackingField; // 0x18

	// Properties
	public String Condition { set; }
	public Boolean Enabled { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C7E354
	public Void set_Condition(String value) { }

	// RVA: 0xFFFFFFFF75C7E38C
	public Void set_Enabled(Boolean value) { }

	// RVA: 0xFFFFFFFF75C7E394
	public Void .ctor(String condition) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeHeaderAttribute
{
	// Fields
	private String <Header>k__BackingField; // 0x10

	// Properties
	public String Header { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C7E3E8
	public Void set_Header(String value) { }

	// RVA: 0xFFFFFFFF75C7E420
	public Void .ctor(String header) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeNameAttribute
{
	// Fields
	private String <Name>k__BackingField; // 0x10

	// Properties
	public String Name { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C7E62C
	public Void set_Name(String value) { }

	// RVA: 0xFFFFFFFF75C7E664
	public Void .ctor(String name) { }

}

// Namespace: UnityEngine.Bindings
internal sealed class NativeWritableSelfAttribute
{
	// Fields
	private Boolean <WritableSelf>k__BackingField; // 0x10

	// Properties
	public Boolean WritableSelf { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C7E9F0
	public Void set_WritableSelf(Boolean value) { }

	// RVA: 0xFFFFFFFF75C7E9F8
	public Void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class NativeMethodAttribute
{
	// Fields
	private String <Name>k__BackingField; // 0x10
	private Boolean <IsThreadSafe>k__BackingField; // 0x18
	private Boolean <IsFreeFunction>k__BackingField; // 0x19
	private Boolean <ThrowsException>k__BackingField; // 0x1A
	private Boolean <HasExplicitThis>k__BackingField; // 0x1B

	// Properties
	public String Name { set; }
	public Boolean IsThreadSafe { set; }
	public Boolean IsFreeFunction { set; }
	public Boolean ThrowsException { set; }
	public Boolean HasExplicitThis { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C7E4DC
	public Void set_Name(String value) { }

	// RVA: 0xFFFFFFFF75C7E514
	public Void set_IsThreadSafe(Boolean value) { }

	// RVA: 0xFFFFFFFF75C7E51C
	public Void set_IsFreeFunction(Boolean value) { }

	// RVA: 0xFFFFFFFF75C7E524
	public Void set_ThrowsException(Boolean value) { }

	// RVA: 0xFFFFFFFF75C7E52C
	public Void set_HasExplicitThis(Boolean value) { }

	// RVA: 0xFFFFFFFF75C7E27C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C7E534
	public Void .ctor(String name) { }

	// RVA: 0xFFFFFFFF75C7E2AC
	public Void .ctor(String name, Boolean isFreeFunction) { }

	// RVA: 0xFFFFFFFF75C7E304
	public Void .ctor(String name, Boolean isFreeFunction, Boolean isThreadSafe) { }

}

// Namespace: UnityEngine.Bindings
internal enum TargetType
{
	// Fields
	public Int32 value__; // 0x10
	public const TargetType Function = 0;
	public const TargetType Field = 1;
}

// Namespace: UnityEngine.Bindings
internal class NativePropertyAttribute
{
	// Fields
	private TargetType <TargetType>k__BackingField; // 0x1C

	// Properties
	public TargetType TargetType { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C7E75C
	public Void set_TargetType(TargetType value) { }

	// RVA: 0xFFFFFFFF75C7E764
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C7E76C
	public Void .ctor(String name) { }

	// RVA: 0xFFFFFFFF75C7E770
	public Void .ctor(String name, Boolean isFree, TargetType targetType) { }

}

// Namespace: UnityEngine.Bindings
internal enum CodegenOptions
{
	// Fields
	public Int32 value__; // 0x10
	public const CodegenOptions Auto = 0;
	public const CodegenOptions Custom = 1;
	public const CodegenOptions Force = 2;
}

// Namespace: UnityEngine.Bindings
internal class NativeAsStructAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75C7E34C
	public Void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class NativeTypeAttribute
{
	// Fields
	private String <Header>k__BackingField; // 0x10
	private String <IntermediateScriptingStructName>k__BackingField; // 0x18
	private CodegenOptions <CodegenOptions>k__BackingField; // 0x20

	// Properties
	public String Header { set; }
	public String IntermediateScriptingStructName { set; }
	public CodegenOptions CodegenOptions { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C7E7DC
	public Void set_Header(String value) { }

	// RVA: 0xFFFFFFFF75C7E814
	public Void set_IntermediateScriptingStructName(String value) { }

	// RVA: 0xFFFFFFFF75C7E84C
	public Void set_CodegenOptions(CodegenOptions value) { }

	// RVA: 0xFFFFFFFF75C7E854
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C7E87C
	public Void .ctor(CodegenOptions codegenOptions) { }

	// RVA: 0xFFFFFFFF75C7E8A8
	public Void .ctor(String header) { }

	// RVA: 0xFFFFFFFF75C7E998
	public Void .ctor(CodegenOptions codegenOptions, String intermediateStructName) { }

}

// Namespace: UnityEngine.Bindings
internal class NotNullAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75C7EA24
	public Void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class UnmarshalledAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75C7EB30
	public Void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class FreeFunctionAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75C7E250
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C7E284
	public Void .ctor(String name) { }

	// RVA: 0xFFFFFFFF75C7E2D4
	public Void .ctor(String name, Boolean isThreadSafe) { }

}

// Namespace: UnityEngine.Bindings
internal class ThreadSafeAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75C7EB04
	public Void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal enum StaticAccessorType
{
	// Fields
	public Int32 value__; // 0x10
	public const StaticAccessorType Dot = 0;
	public const StaticAccessorType Arrow = 1;
	public const StaticAccessorType DoubleColon = 2;
	public const StaticAccessorType ArrowWithDefaultReturnIfNull = 3;
}

// Namespace: UnityEngine.Bindings
internal class StaticAccessorAttribute
{
	// Fields
	private String <Name>k__BackingField; // 0x10
	private StaticAccessorType <Type>k__BackingField; // 0x18

	// Properties
	public String Name { set; }
	public StaticAccessorType Type { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C7EA2C
	public Void set_Name(String value) { }

	// RVA: 0xFFFFFFFF75C7EA64
	public Void set_Type(StaticAccessorType value) { }

	// RVA: 0xFFFFFFFF75C7EA6C
	internal Void .ctor(String name) { }

	// RVA: 0xFFFFFFFF75C7EAB0
	public Void .ctor(String name, StaticAccessorType type) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeThrowsAttribute
{
	// Fields
	private Boolean <ThrowsException>k__BackingField; // 0x10

	// Properties
	public Boolean ThrowsException { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C7E7A8
	public Void set_ThrowsException(Boolean value) { }

	// RVA: 0xFFFFFFFF75C7E7B0
	public Void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class IgnoreAttribute
{
	// Fields
	private Boolean <DoesNotContributeToSize>k__BackingField; // 0x10

	// Properties
	public Boolean DoesNotContributeToSize { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C7E33C
	public Void set_DoesNotContributeToSize(Boolean value) { }

	// RVA: 0xFFFFFFFF75C7E344
	public Void .ctor() { }

}

// Namespace: UnityEngine.Scripting
internal class UsedByNativeCodeAttribute
{
	// Fields
	private String <Name>k__BackingField; // 0x10

	// Properties
	public String Name { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C7ED70
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C7ED78
	public Void .ctor(String name) { }

	// RVA: 0xFFFFFFFF75C7EDBC
	public Void set_Name(String value) { }

}

// Namespace: UnityEngine.Scripting
public class RequiredByNativeCodeAttribute
{
	// Fields
	private String <Name>k__BackingField; // 0x10
	private Boolean <Optional>k__BackingField; // 0x18
	private Boolean <GenerateProxy>k__BackingField; // 0x19

	// Properties
	public String Name { set; }
	public Boolean Optional { set; }
	public Boolean GenerateProxy { set; }

	// Methods

	// RVA: 0xFFFFFFFF75C7ECDC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C7ECE4
	public Void .ctor(String name) { }

	// RVA: 0xFFFFFFFF75C7ED28
	public Void set_Name(String value) { }

	// RVA: 0xFFFFFFFF75C7ED60
	public Void set_Optional(Boolean value) { }

	// RVA: 0xFFFFFFFF75C7ED68
	public Void set_GenerateProxy(Boolean value) { }

}

// Namespace: UnityEngine.Scripting
internal class GeneratedByOldBindingsGeneratorAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75C7ECD4
	public Void .ctor() { }

}


