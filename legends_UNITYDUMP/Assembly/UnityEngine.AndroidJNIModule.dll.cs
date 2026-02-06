// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public struct jvalue
{
	// Fields
	public Boolean z; // 0x10
	public SByte b; // 0x10
	public Char c; // 0x10
	public Int16 s; // 0x10
	public Int32 i; // 0x10
	public Int64 j; // 0x10
	public Single f; // 0x10
	public Double d; // 0x10
	public IntPtr l; // 0x10
}

// Namespace: UnityEngine
public static class AndroidJNIHelper
{
	// Methods

	// RVA: 0xFFFFFFFF75BD559C
	public static IntPtr GetConstructorID(IntPtr javaClass, String signature) { }

	// RVA: 0xFFFFFFFF75BD572C
	public static IntPtr GetMethodID(IntPtr javaClass, String methodName, String signature, Boolean isStatic) { }

	// RVA: 0xFFFFFFFF75BD58D8
	public static IntPtr GetFieldID(IntPtr javaClass, String fieldName, String signature, Boolean isStatic) { }

	// RVA: 0xFFFFFFFF75BD5B24
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0xFFFFFFFF75BD5B80
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0xFFFFFFFF75BD5CAC
	public static jvalue[] CreateJNIArgArray(Object[] args) { }

	// RVA: 0xFFFFFFFF75BD6118
	public static Void DeleteJNIArgArray(Object[] args, jvalue[] jniArgs) { }

	// RVA: 0xFFFFFFFF75BD61FC
	public static IntPtr GetConstructorID(IntPtr jclass, Object[] args) { }

	// RVA: 0xFFFFFFFF75BD6254
	public static IntPtr GetMethodID(IntPtr jclass, String methodName, Object[] args, Boolean isStatic) { }

	// RVA: -1
	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	// RVA: -1
	public static IntPtr GetMethodID(IntPtr jclass, String methodName, Object[] args, Boolean isStatic) { }

	// RVA: -1
	public static IntPtr GetFieldID(IntPtr jclass, String fieldName, Boolean isStatic) { }

}

// Namespace: UnityEngine
public static class AndroidJNI
{
	// Methods

	// RVA: 0xFFFFFFFF75BD3BB4
	public static Int32 AttachCurrentThread() { }

	// RVA: 0xFFFFFFFF75BD3BE8
	public static Int32 DetachCurrentThread() { }

	// RVA: 0xFFFFFFFF75BD3C1C
	public static IntPtr FindClass(String name) { }

	// RVA: 0xFFFFFFFF75BD3C5C
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0xFFFFFFFF75BD3C9C
	public static IntPtr ExceptionOccurred() { }

	// RVA: 0xFFFFFFFF75BD3CD0
	public static Void ExceptionClear() { }

	// RVA: 0xFFFFFFFF75BD3D04
	public static Int32 PushLocalFrame(Int32 capacity) { }

	// RVA: 0xFFFFFFFF75BD3D44
	public static IntPtr PopLocalFrame(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF75BD3D84
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	// RVA: 0xFFFFFFFF75BD3DC4
	public static Void DeleteGlobalRef(IntPtr obj) { }

	// RVA: 0xFFFFFFFF75BD3E04
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	// RVA: 0xFFFFFFFF75BD3E44
	public static Void DeleteWeakGlobalRef(IntPtr obj) { }

	// RVA: 0xFFFFFFFF75BD3E84
	public static IntPtr NewLocalRef(IntPtr obj) { }

	// RVA: 0xFFFFFFFF75BD3EC4
	public static Void DeleteLocalRef(IntPtr obj) { }

	// RVA: 0xFFFFFFFF75BD3F04
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD3F5C
	public static IntPtr GetObjectClass(IntPtr obj) { }

	// RVA: 0xFFFFFFFF75BD3F9C
	public static IntPtr GetMethodID(IntPtr clazz, String name, String sig) { }

	// RVA: 0xFFFFFFFF75BD3FF4
	public static IntPtr GetFieldID(IntPtr clazz, String name, String sig) { }

	// RVA: 0xFFFFFFFF75BD404C
	public static IntPtr GetStaticMethodID(IntPtr clazz, String name, String sig) { }

	// RVA: 0xFFFFFFFF75BD40A4
	public static IntPtr GetStaticFieldID(IntPtr clazz, String name, String sig) { }

	// RVA: 0xFFFFFFFF75BD40FC
	public static IntPtr NewString(String chars) { }

	// RVA: 0xFFFFFFFF75BD413C
	private static IntPtr NewStringFromStr(String chars) { }

	// RVA: 0xFFFFFFFF75BD417C
	public static String GetStringChars(IntPtr str) { }

	// RVA: 0xFFFFFFFF75BD41BC
	public static String CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD4214
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD426C
	public static Int32 CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD42C4
	public static Boolean CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD431C
	public static Int16 CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD4374
	public static SByte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD43CC
	public static Char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD4424
	public static Single CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD447C
	public static Double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD44D4
	public static Int64 CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD452C
	public static Void CallVoidMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD4584
	public static String GetStringField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD45D4
	public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD4624
	public static Boolean GetBooleanField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD4674
	public static SByte GetSByteField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD46C4
	public static Char GetCharField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD4714
	public static Int16 GetShortField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD4764
	public static Int32 GetIntField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD47B4
	public static Int64 GetLongField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD4804
	public static Single GetFloatField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD4854
	public static Double GetDoubleField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD48A4
	public static String CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD48FC
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD4954
	public static Int32 CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD49AC
	public static Boolean CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD4A04
	public static Int16 CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD4A5C
	public static SByte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD4AB4
	public static Char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD4B0C
	public static Single CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD4B64
	public static Double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD4BBC
	public static Int64 CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD4C14
	public static Void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD4C6C
	public static String GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD4CBC
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD4D0C
	public static Boolean GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD4D5C
	public static SByte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD4DAC
	public static Char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD4DFC
	public static Int16 GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD4E4C
	public static Int32 GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD4E9C
	public static Int64 GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD4EEC
	public static Single GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD4F3C
	public static Double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD4F8C
	public static IntPtr ToBooleanArray(Boolean[] array) { }

	// RVA: 0xFFFFFFFF75BD4FCC
	public static IntPtr ToByteArray(Byte[] array) { }

	// RVA: 0xFFFFFFFF75BD500C
	public static IntPtr ToSByteArray(SByte[] array) { }

	// RVA: 0xFFFFFFFF75BD504C
	public static IntPtr ToCharArray(Char[] array) { }

	// RVA: 0xFFFFFFFF75BD508C
	public static IntPtr ToShortArray(Int16[] array) { }

	// RVA: 0xFFFFFFFF75BD50CC
	public static IntPtr ToIntArray(Int32[] array) { }

	// RVA: 0xFFFFFFFF75BD510C
	public static IntPtr ToLongArray(Int64[] array) { }

	// RVA: 0xFFFFFFFF75BD514C
	public static IntPtr ToFloatArray(Single[] array) { }

	// RVA: 0xFFFFFFFF75BD518C
	public static IntPtr ToDoubleArray(Double[] array) { }

	// RVA: 0xFFFFFFFF75BD51CC
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	// RVA: 0xFFFFFFFF75BD521C
	public static Boolean[] FromBooleanArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD525C
	public static Byte[] FromByteArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD529C
	public static SByte[] FromSByteArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD52DC
	public static Char[] FromCharArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD531C
	public static Int16[] FromShortArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD535C
	public static Int32[] FromIntArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD539C
	public static Int64[] FromLongArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD53DC
	public static Single[] FromFloatArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD541C
	public static Double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD545C
	public static Int32 GetArrayLength(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD549C
	public static IntPtr NewObjectArray(Int32 size, IntPtr clazz, IntPtr obj) { }

	// RVA: 0xFFFFFFFF75BD54F4
	public static IntPtr GetObjectArrayElement(IntPtr array, Int32 index) { }

	// RVA: 0xFFFFFFFF75BD5544
	public static Void SetObjectArrayElement(IntPtr array, Int32 index, IntPtr obj) { }

}

// Namespace: UnityEngine
internal class AndroidJNISafe
{
	// Methods

	// RVA: 0xFFFFFFFF75BD62DC
	public static Void CheckException() { }

	// RVA: 0xFFFFFFFF75BD6628
	public static Void DeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0xFFFFFFFF75BD6684
	public static Void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0xFFFFFFFF75BD65CC
	public static Void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0xFFFFFFFF75BD66E0
	public static IntPtr NewString(String chars) { }

	// RVA: 0xFFFFFFFF75BD6760
	public static String GetStringChars(IntPtr str) { }

	// RVA: 0xFFFFFFFF75BD67DC
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0xFFFFFFFF75BD6858
	public static IntPtr GetStaticMethodID(IntPtr clazz, String name, String sig) { }

	// RVA: 0xFFFFFFFF75BD68F0
	public static IntPtr GetMethodID(IntPtr obj, String name, String sig) { }

	// RVA: 0xFFFFFFFF75BD6984
	public static IntPtr GetFieldID(IntPtr clazz, String name, String sig) { }

	// RVA: 0xFFFFFFFF75BD6A18
	public static IntPtr GetStaticFieldID(IntPtr clazz, String name, String sig) { }

	// RVA: 0xFFFFFFFF75BD6AAC
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0xFFFFFFFF75BD6B28
	public static IntPtr FindClass(String name) { }

	// RVA: 0xFFFFFFFF75BD6BA8
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD6C3C
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD6CC8
	public static String GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD6D54
	public static Char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD6DE0
	public static Double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD6E78
	public static Single GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD6F10
	public static Int64 GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD6F9C
	public static Int16 GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD7028
	public static SByte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD70B4
	public static Boolean GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD7140
	public static Int32 GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD71CC
	public static Void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD7264
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD72F8
	public static String CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD738C
	public static Char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD7420
	public static Double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD74C0
	public static Single CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD7560
	public static Int64 CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD75F4
	public static Int16 CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD7688
	public static SByte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD771C
	public static Boolean CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD77B0
	public static Int32 CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD7844
	public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD78D0
	public static String GetStringField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD795C
	public static Char GetCharField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD79E8
	public static Double GetDoubleField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD7A80
	public static Single GetFloatField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD7B18
	public static Int64 GetLongField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD7BA4
	public static Int16 GetShortField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD7C30
	public static SByte GetSByteField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD7CBC
	public static Boolean GetBooleanField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD7D48
	public static Int32 GetIntField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0xFFFFFFFF75BD7DD4
	public static Void CallVoidMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD7E6C
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD7F00
	public static String CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD7F94
	public static Char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD8028
	public static Double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD80C8
	public static Single CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD8168
	public static Int64 CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD81FC
	public static Int16 CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD8290
	public static SByte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD8324
	public static Boolean CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD83B8
	public static Int32 CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0xFFFFFFFF75BD844C
	public static Char[] FromCharArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD84C8
	public static Double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD8544
	public static Single[] FromFloatArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD85C0
	public static Int64[] FromLongArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD863C
	public static Int16[] FromShortArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD86B8
	public static Byte[] FromByteArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD8734
	public static SByte[] FromSByteArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD87B0
	public static Boolean[] FromBooleanArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD882C
	public static Int32[] FromIntArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD88A8
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0xFFFFFFFF75BD8934
	public static IntPtr ToCharArray(Char[] array) { }

	// RVA: 0xFFFFFFFF75BD89B0
	public static IntPtr ToDoubleArray(Double[] array) { }

	// RVA: 0xFFFFFFFF75BD8A2C
	public static IntPtr ToFloatArray(Single[] array) { }

	// RVA: 0xFFFFFFFF75BD8AA8
	public static IntPtr ToLongArray(Int64[] array) { }

	// RVA: 0xFFFFFFFF75BD8B24
	public static IntPtr ToShortArray(Int16[] array) { }

	// RVA: 0xFFFFFFFF75BD8BA0
	public static IntPtr ToByteArray(Byte[] array) { }

	// RVA: 0xFFFFFFFF75BD8C1C
	public static IntPtr ToSByteArray(SByte[] array) { }

	// RVA: 0xFFFFFFFF75BD8C98
	public static IntPtr ToBooleanArray(Boolean[] array) { }

	// RVA: 0xFFFFFFFF75BD8D14
	public static IntPtr ToIntArray(Int32[] array) { }

	// RVA: 0xFFFFFFFF75BD8D90
	public static IntPtr GetObjectArrayElement(IntPtr array, Int32 index) { }

	// RVA: 0xFFFFFFFF75BD8E1C
	public static Int32 GetArrayLength(IntPtr array) { }

}

// Namespace: UnityEngine
public sealed class AndroidJavaRunnable
{
	// Methods

	// RVA: 0xFFFFFFFF75BDAF60
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75BDAF74
	public virtual Void Invoke() { }

	// RVA: 0xFFFFFFFF75BDB170
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BDB1C8
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine
public sealed class AndroidJavaException
{
	// Fields
	private String mJavaStackTrace; // 0x88

	// Properties
	public override String StackTrace { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BD6568
	internal Void .ctor(String message, String javaStackTrace) { }

	// RVA: 0xFFFFFFFF75BD91B8
	public override String get_StackTrace() { }

}

// Namespace: UnityEngine
internal class GlobalJavaObjectRef
{
	// Fields
	private Boolean m_disposed; // 0x10
	protected IntPtr m_jobject; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75BD905C
	public Void .ctor(IntPtr jobject) { }

	// RVA: 0xFFFFFFFF75BDB97C
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75BD96B0
	public static IntPtr op_Implicit(GlobalJavaObjectRef obj) { }

	// RVA: 0xFFFFFFFF75BD987C
	public Void Dispose() { }

}

// Namespace: UnityEngine
internal class AndroidJavaRunnableProxy
{
	// Fields
	private AndroidJavaRunnable mRunnable; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75BDB1D4
	public Void .ctor(AndroidJavaRunnable runnable) { }

}

// Namespace: UnityEngine
public class AndroidJavaProxy
{
	// Fields
	public readonly AndroidJavaClass javaInterface; // 0x10
	internal IntPtr proxyObject; // 0x18
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x0
	private static readonly IntPtr s_HashCodeMethodID; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75BD99C0
	public Void .ctor(String javaInterface) { }

	// RVA: 0xFFFFFFFF75BD9A1C
	public Void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0xFFFFFFFF75BD9A54
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75BD9AC0
	public virtual AndroidJavaObject Invoke(String methodName, Object[] args) { }

	// RVA: 0xFFFFFFFF75BDA7E4
	public virtual AndroidJavaObject Invoke(String methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0xFFFFFFFF75BDAE8C
	internal AndroidJavaObject GetProxyObject() { }

	// RVA: 0xFFFFFFFF75BDA628
	internal IntPtr GetRawProxy() { }

	// RVA: 0xFFFFFFFF75BDAECC
	private static Void .cctor() { }

}

// Namespace: UnityEngine
public class AndroidJavaObject
{
	// Fields
	private static Boolean enableDebugPrints; // 0x0
	internal GlobalJavaObjectRef m_jobject; // 0x10
	internal GlobalJavaObjectRef m_jclass; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75BD91E8
	public Void .ctor(String className, Object[] args) { }

	// RVA: 0xFFFFFFFF75BD93F0
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75BD9444
	public Void Call(String methodName, Object[] args) { }

	// RVA: 0xFFFFFFFF75BD9538
	public Void CallStatic(String methodName, Object[] args) { }

	// RVA: -1
	public FieldType Get(String fieldName) { }

	// RVA: -1
	public FieldType GetStatic(String fieldName) { }

	// RVA: 0xFFFFFFFF75BD9630
	public IntPtr GetRawObject() { }

	// RVA: 0xFFFFFFFF75BD9670
	public IntPtr GetRawClass() { }

	// RVA: -1
	public ReturnType Call(String methodName, Object[] args) { }

	// RVA: -1
	public ReturnType CallStatic(String methodName, Object[] args) { }

	// RVA: 0xFFFFFFFF75BD8FC8
	protected Void DebugPrint(String msg) { }

	// RVA: 0xFFFFFFFF75BD9228
	private Void _AndroidJavaObject(String className, Object[] args) { }

	// RVA: 0xFFFFFFFF75BD96CC
	internal Void .ctor(IntPtr jobject) { }

	// RVA: 0xFFFFFFFF75BD8EE8
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75BD97A4
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75BD981C
	protected virtual Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75BD9448
	protected Void _Call(String methodName, Object[] args) { }

	// RVA: -1
	protected ReturnType _Call(String methodName, Object[] args) { }

	// RVA: -1
	protected FieldType _Get(String fieldName) { }

	// RVA: 0xFFFFFFFF75BD953C
	protected Void _CallStatic(String methodName, Object[] args) { }

	// RVA: -1
	protected ReturnType _CallStatic(String methodName, Object[] args) { }

	// RVA: -1
	protected FieldType _GetStatic(String fieldName) { }

	// RVA: 0xFFFFFFFF75BD98CC
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0xFFFFFFFF75BD993C
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: 0xFFFFFFFF75BD9650
	protected IntPtr _GetRawObject() { }

	// RVA: 0xFFFFFFFF75BD9690
	protected IntPtr _GetRawClass() { }

	// RVA: 0xFFFFFFFF75BD99AC
	private static Void .cctor() { }

}

// Namespace: UnityEngine
public class AndroidJavaClass
{
	// Methods

	// RVA: 0xFFFFFFFF75BD8E98
	public Void .ctor(String className) { }

	// RVA: 0xFFFFFFFF75BD8EF0
	private Void _AndroidJavaClass(String className) { }

	// RVA: 0xFFFFFFFF75BD90DC
	internal Void .ctor(IntPtr jclass) { }

}

// Namespace: UnityEngine
internal class AndroidReflection
{
	// Fields
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; // 0x0
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; // 0x8
	private static readonly IntPtr s_ReflectionHelperGetMethodID; // 0x10
	private static readonly IntPtr s_ReflectionHelperGetFieldID; // 0x18
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; // 0x20
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; // 0x28
	private static readonly IntPtr s_ReflectionHelperSetNativeExceptionOnProxy; // 0x30
	private static readonly IntPtr s_FieldGetDeclaringClass; // 0x38

	// Methods

	// RVA: 0xFFFFFFFF75BDB254
	public static Boolean IsPrimitive(Type t) { }

	// RVA: 0xFFFFFFFF75BDB26C
	public static Boolean IsAssignableFrom(Type t, Type from) { }

	// RVA: 0xFFFFFFFF75BDB290
	private static IntPtr GetStaticMethodID(String clazz, String methodName, String signature) { }

	// RVA: 0xFFFFFFFF75BDB30C
	private static IntPtr GetMethodID(String clazz, String methodName, String signature) { }

	// RVA: 0xFFFFFFFF75BDB388
	public static IntPtr GetConstructorMember(IntPtr jclass, String signature) { }

	// RVA: 0xFFFFFFFF75BDB460
	public static IntPtr GetMethodMember(IntPtr jclass, String methodName, String signature, Boolean isStatic) { }

	// RVA: 0xFFFFFFFF75BDB5C8
	public static IntPtr GetFieldMember(IntPtr jclass, String fieldName, String signature, Boolean isStatic) { }

	// RVA: 0xFFFFFFFF75BDB6D4
	public static IntPtr GetFieldClass(IntPtr field) { }

	// RVA: 0xFFFFFFFF75BDB720
	public static String GetFieldSignature(IntPtr field) { }

	// RVA: 0xFFFFFFFF75BDB790
	public static IntPtr NewProxyInstance(IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0xFFFFFFFF75BDA728
	public static Void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, Boolean methodNotFound) { }

	// RVA: 0xFFFFFFFF75BDB81C
	private static Void .cctor() { }

}

// Namespace: UnityEngine
internal sealed class _AndroidJNIHelper
{
	// Methods

	// RVA: 0xFFFFFFFF75BD5C50
	public static IntPtr CreateJavaProxy(IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	// RVA: 0xFFFFFFFF75BD5B28
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0xFFFFFFFF75BDB9E4
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	// RVA: 0xFFFFFFFF75BD5CB0
	public static jvalue[] CreateJNIArgArray(Object[] args) { }

	// RVA: 0xFFFFFFFF75BDC6E8
	public static Object UnboxArray(AndroidJavaObject obj) { }

	// RVA: 0xFFFFFFFF75BDA91C
	public static Object Unbox(AndroidJavaObject obj) { }

	// RVA: 0xFFFFFFFF75BD9F54
	public static AndroidJavaObject Box(Object obj) { }

	// RVA: 0xFFFFFFFF75BD611C
	public static Void DeleteJNIArgArray(Object[] args, jvalue[] jniArgs) { }

	// RVA: 0xFFFFFFFF75BDC078
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: -1
	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	// RVA: 0xFFFFFFFF75BD6228
	public static IntPtr GetConstructorID(IntPtr jclass, Object[] args) { }

	// RVA: 0xFFFFFFFF75BD6298
	public static IntPtr GetMethodID(IntPtr jclass, String methodName, Object[] args, Boolean isStatic) { }

	// RVA: -1
	public static IntPtr GetMethodID(IntPtr jclass, String methodName, Object[] args, Boolean isStatic) { }

	// RVA: -1
	public static IntPtr GetFieldID(IntPtr jclass, String fieldName, Boolean isStatic) { }

	// RVA: 0xFFFFFFFF75BD55A0
	public static IntPtr GetConstructorID(IntPtr jclass, String signature) { }

	// RVA: 0xFFFFFFFF75BD5730
	public static IntPtr GetMethodID(IntPtr jclass, String methodName, String signature, Boolean isStatic) { }

	// RVA: 0xFFFFFFFF75BDCBE4
	private static IntPtr GetMethodIDFallback(IntPtr jclass, String methodName, String signature, Boolean isStatic) { }

	// RVA: 0xFFFFFFFF75BD58DC
	public static IntPtr GetFieldID(IntPtr jclass, String fieldName, String signature, Boolean isStatic) { }

	// RVA: 0xFFFFFFFF75BDCC84
	public static String GetSignature(Object obj) { }

	// RVA: 0xFFFFFFFF75BDCB30
	public static String GetSignature(Object[] args) { }

	// RVA: -1
	public static String GetSignature(Object[] args) { }

}


