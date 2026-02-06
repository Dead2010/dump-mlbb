// Namespace: 
internal class <Module>
{}

// Namespace: Unity.Mathematics
public static class math
{
	// Methods

	// RVA: 0xFFFFFFFF75BBF1B4
	public static float3 float3(Single x, Single y, Single z) { }

	// RVA: 0xFFFFFFFF75BBF1B8
	public static UInt32 hash(float3 v) { }

	// RVA: 0xFFFFFFFF75BBF200
	public static UInt32 hash(float3x3 v) { }

	// RVA: 0xFFFFFFFF75BBF280
	public static float4 float4(Single x, Single y, Single z, Single w) { }

	// RVA: 0xFFFFFFFF75BBF284
	public static float4 float4(float3 xyz, Single w) { }

	// RVA: 0xFFFFFFFF75BBF288
	public static UInt32 hash(float4 v) { }

	// RVA: 0xFFFFFFFF75BBF2E8
	public static float4x4 float4x4(float4 c0, float4 c1, float4 c2, float4 c3) { }

	// RVA: 0xFFFFFFFF75BBF304
	public static UInt32 hash(float4x4 v) { }

	// RVA: 0xFFFFFFFF75BBF414
	public static Int32 asint(Single x) { }

	// RVA: 0xFFFFFFFF75BBF41C
	public static UInt32 asuint(Single x) { }

	// RVA: 0xFFFFFFFF75BBF424
	public static uint3 asuint(float3 x) { }

	// RVA: 0xFFFFFFFF75BBF438
	public static uint4 asuint(float4 x) { }

	// RVA: 0xFFFFFFFF75BBF454
	public static Single asfloat(Int32 x) { }

	// RVA: 0xFFFFFFFF75BBF45C
	public static Single asfloat(UInt32 x) { }

	// RVA: 0xFFFFFFFF75BBF464
	public static float3 asfloat(uint3 x) { }

	// RVA: 0xFFFFFFFF75BBF478
	public static Int32 min(Int32 x, Int32 y) { }

	// RVA: 0xFFFFFFFF75BBF484
	public static Single max(Single x, Single y) { }

	// RVA: 0xFFFFFFFF75BBF4C0
	public static Single lerp(Single x, Single y, Single s) { }

	// RVA: 0xFFFFFFFF75BBF4D0
	public static Single abs(Single x) { }

	// RVA: 0xFFFFFFFF75BBF4D8
	public static Single dot(float3 x, float3 y) { }

	// RVA: 0xFFFFFFFF75BBF4F0
	public static Single dot(float4 x, float4 y) { }

	// RVA: 0xFFFFFFFF75BBF510
	public static Single rcp(Single x) { }

	// RVA: 0xFFFFFFFF75BBF51C
	public static Single sqrt(Single x) { }

	// RVA: 0xFFFFFFFF75BBF558
	public static Single rsqrt(Single x) { }

	// RVA: 0xFFFFFFFF75BBF59C
	public static float3 normalizesafe(float3 x, float3 defaultvalue) { }

	// RVA: 0xFFFFFFFF75BBF63C
	public static Single length(float3 x) { }

	// RVA: 0xFFFFFFFF75BBF69C
	public static Single distance(float3 x, float3 y) { }

	// RVA: 0xFFFFFFFF75BBF71C
	public static float3 cross(float3 x, float3 y) { }

	// RVA: 0xFFFFFFFF75BBF744
	public static float3 select(float3 a, float3 b, Boolean c) { }

	// RVA: 0xFFFFFFFF75BBF758
	public static UInt32 csum(uint3 x) { }

	// RVA: 0xFFFFFFFF75BBF768
	public static UInt32 csum(uint4 x) { }

	// RVA: 0xFFFFFFFF75BBF780
	public static float3x3 float3x3(quaternion rotation) { }

	// RVA: 0xFFFFFFFF75BBF794
	public static float4 mul(float4x4 a, float4 b) { }

	// RVA: 0xFFFFFFFF75BBF7C8
	public static quaternion quaternion(float4 value) { }

	// RVA: 0xFFFFFFFF75BBF7CC
	public static quaternion inverse(quaternion q) { }

	// RVA: 0xFFFFFFFF75BBF804
	public static quaternion mul(quaternion a, quaternion b) { }

	// RVA: 0xFFFFFFFF75BBF878
	public static float3 mul(quaternion q, float3 v) { }

	// RVA: 0xFFFFFFFF75BBF8F4
	public static UInt32 hash(quaternion q) { }

	// RVA: 0xFFFFFFFF75BBF954
	public static uint3 uint3(UInt32 x, UInt32 y, UInt32 z) { }

	// RVA: 0xFFFFFFFF75BBF964
	public static UInt32 hash(uint3 v) { }

	// RVA: 0xFFFFFFFF75BBF9A4
	public static uint4 uint4(UInt32 x, UInt32 y, UInt32 z, UInt32 w) { }

	// RVA: 0xFFFFFFFF75BBF9BC
	public static UInt32 hash(uint4 v) { }

}

// Namespace: 
internal struct IntFloatUnion
{
	// Fields
	public Int32 intValue; // 0x10
	public Single floatValue; // 0x10
}

// Namespace: Unity.Mathematics
public struct float3
{
	// Fields
	public Single x; // 0x10
	public Single y; // 0x14
	public Single z; // 0x18
	public static readonly float3 zero; // 0x0

	// Properties
	public float3 xyz { get; }
	public float3 yzx { get; }

	// Methods

	// RVA: 0xFFFFFFFF71148A14
	public Void .ctor(Single x, Single y, Single z) { }

	// RVA: 0xFFFFFFFF75BBCDE0
	public static float3 op_Multiply(float3 lhs, float3 rhs) { }

	// RVA: 0xFFFFFFFF75BBCDF0
	public static float3 op_Multiply(float3 lhs, Single rhs) { }

	// RVA: 0xFFFFFFFF75BBCE00
	public static float3 op_Multiply(Single lhs, float3 rhs) { }

	// RVA: 0xFFFFFFFF75BBCE14
	public static float3 op_Addition(float3 lhs, float3 rhs) { }

	// RVA: 0xFFFFFFFF75BBCE24
	public static float3 op_Subtraction(float3 lhs, float3 rhs) { }

	// RVA: 0xFFFFFFFF75BBCE34
	public static float3 op_Division(float3 lhs, float3 rhs) { }

	// RVA: 0xFFFFFFFF71148A20
	public float3 get_xyz() { }

	// RVA: 0xFFFFFFFF71148A2C
	public float3 get_yzx() { }

	// RVA: 0xFFFFFFFF71148A38
	public Boolean Equals(float3 rhs) { }

	// RVA: 0xFFFFFFFF71148A68
	public override Boolean Equals(Object o) { }

	// RVA: 0xFFFFFFFF71148A70
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF71148AB4
	public override String ToString() { }

	// RVA: 0xFFFFFFFF71148B64
	public String ToString(String format, IFormatProvider formatProvider) { }

	// RVA: 0xFFFFFFFF723A972C
	public static Vector3 op_Implicit(float3 v) { }

	// RVA: 0xFFFFFFFF723A9730
	public static float3 op_Implicit(Vector3 v) { }

}

// Namespace: 
internal sealed class DebuggerProxy
{}

// Namespace: Unity.Mathematics
public struct float3x3
{
	// Fields
	public float3 c0; // 0x10
	public float3 c1; // 0x1C
	public float3 c2; // 0x28
	public static readonly float3x3 identity; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF71148C14
	public Void .ctor(Single m00, Single m01, Single m02, Single m10, Single m11, Single m12, Single m20, Single m21, Single m22) { }

	// RVA: 0xFFFFFFFF71148C30
	public Boolean Equals(float3x3 rhs) { }

	// RVA: 0xFFFFFFFF71148CCC
	public override Boolean Equals(Object o) { }

	// RVA: 0xFFFFFFFF71148CD4
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF71148D54
	public override String ToString() { }

	// RVA: 0xFFFFFFFF71148D5C
	public String ToString(String format, IFormatProvider formatProvider) { }

	// RVA: 0xFFFFFFFF71148D64
	public Void .ctor(quaternion q) { }

	// RVA: 0xFFFFFFFF75BBDAC0
	private static Void .cctor() { }

}

// Namespace: Unity.Mathematics
public struct float4
{
	// Fields
	public Single x; // 0x10
	public Single y; // 0x14
	public Single z; // 0x18
	public Single w; // 0x1C
	public static readonly float4 zero; // 0x0

	// Properties
	public float4 xyzx { get; }
	public float4 yzxy { get; }
	public float4 yzxz { get; }
	public float4 zxyy { get; }
	public float4 zxyz { get; }
	public float4 wwwx { get; }
	public float4 wwww { get; }
	public float3 xyz { get; }
	public float3 yxw { get; }
	public float3 zwx { get; }
	public float3 wzy { get; }

	// Methods

	// RVA: 0xFFFFFFFF71148D6C
	public Void .ctor(Single x, Single y, Single z, Single w) { }

	// RVA: 0xFFFFFFFF71148D78
	public Void .ctor(float3 xyz, Single w) { }

	// RVA: 0xFFFFFFFF75BBDB30
	public static float4 op_Multiply(float4 lhs, float4 rhs) { }

	// RVA: 0xFFFFFFFF75BBDB44
	public static float4 op_Multiply(float4 lhs, Single rhs) { }

	// RVA: 0xFFFFFFFF75BBDB58
	public static float4 op_Multiply(Single lhs, float4 rhs) { }

	// RVA: 0xFFFFFFFF75BBDB70
	public static float4 op_Addition(float4 lhs, float4 rhs) { }

	// RVA: 0xFFFFFFFF75BBDB84
	public static float4 op_Subtraction(float4 lhs, float4 rhs) { }

	// RVA: 0xFFFFFFFF71148D84
	public float4 get_xyzx() { }

	// RVA: 0xFFFFFFFF71148D94
	public float4 get_yzxy() { }

	// RVA: 0xFFFFFFFF71148DA4
	public float4 get_yzxz() { }

	// RVA: 0xFFFFFFFF71148DB4
	public float4 get_zxyy() { }

	// RVA: 0xFFFFFFFF71148DC4
	public float4 get_zxyz() { }

	// RVA: 0xFFFFFFFF71148DD4
	public float4 get_wwwx() { }

	// RVA: 0xFFFFFFFF71148DE8
	public float4 get_wwww() { }

	// RVA: 0xFFFFFFFF71148DFC
	public float3 get_xyz() { }

	// RVA: 0xFFFFFFFF71148E08
	public float3 get_yxw() { }

	// RVA: 0xFFFFFFFF71148E14
	public float3 get_zwx() { }

	// RVA: 0xFFFFFFFF71148E20
	public float3 get_wzy() { }

	// RVA: 0xFFFFFFFF71148E2C
	public Boolean Equals(float4 rhs) { }

	// RVA: 0xFFFFFFFF71148E68
	public override Boolean Equals(Object o) { }

	// RVA: 0xFFFFFFFF71148E70
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF71148EC8
	public override String ToString() { }

	// RVA: 0xFFFFFFFF71148ED0
	public String ToString(String format, IFormatProvider formatProvider) { }

}

// Namespace: 
internal sealed class DebuggerProxy
{}

// Namespace: Unity.Mathematics
public struct float4x4
{
	// Fields
	public float4 c0; // 0x10
	public float4 c1; // 0x20
	public float4 c2; // 0x30
	public float4 c3; // 0x40
	public static readonly float4x4 identity; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF71148ED8
	public Void .ctor(float4 c0, float4 c1, float4 c2, float4 c3) { }

	// RVA: 0xFFFFFFFF71148EF4
	public Void .ctor(Single m00, Single m01, Single m02, Single m03, Single m10, Single m11, Single m12, Single m13, Single m20, Single m21, Single m22, Single m23, Single m30, Single m31, Single m32, Single m33) { }

	// RVA: 0xFFFFFFFF71148F28
	public Boolean Equals(float4x4 rhs) { }

	// RVA: 0xFFFFFFFF71149034
	public override Boolean Equals(Object o) { }

	// RVA: 0xFFFFFFFF7114903C
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114914C
	public override String ToString() { }

	// RVA: 0xFFFFFFFF71149154
	public String ToString(String format, IFormatProvider formatProvider) { }

	// RVA: 0xFFFFFFFF75BBF060
	public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale) { }

	// RVA: 0xFFFFFFFF75BBF148
	private static Void .cctor() { }

}

// Namespace: Unity.Mathematics
public struct quaternion
{
	// Fields
	public float4 value; // 0x10
	public static readonly quaternion identity; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF723A9734
	public static Quaternion op_Implicit(quaternion q) { }

	// RVA: 0xFFFFFFFF723A9738
	public static quaternion op_Implicit(Quaternion q) { }

	// RVA: 0xFFFFFFFF7114915C
	public Void .ctor(Single x, Single y, Single z, Single w) { }

	// RVA: 0xFFFFFFFF71149168
	public Void .ctor(float4 value) { }

	// RVA: 0xFFFFFFFF71149174
	public Boolean Equals(quaternion x) { }

	// RVA: 0xFFFFFFFF711491B0
	public override Boolean Equals(Object x) { }

	// RVA: 0xFFFFFFFF71149270
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF711492C8
	public override String ToString() { }

	// RVA: 0xFFFFFFFF711492D0
	public String ToString(String format, IFormatProvider formatProvider) { }

	// RVA: 0xFFFFFFFF75BBFF90
	private static Void .cctor() { }

}

// Namespace: Unity.Mathematics
public struct uint3
{
	// Fields
	public UInt32 x; // 0x10
	public UInt32 y; // 0x14
	public UInt32 z; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF711492D8
	public Void .ctor(UInt32 x, UInt32 y, UInt32 z) { }

	// RVA: 0xFFFFFFFF75BBFFEC
	public static uint3 op_Multiply(uint3 lhs, uint3 rhs) { }

	// RVA: 0xFFFFFFFF75BC0008
	public static uint3 op_Addition(uint3 lhs, uint3 rhs) { }

	// RVA: 0xFFFFFFFF75BC0024
	public static uint3 op_ExclusiveOr(uint3 lhs, uint3 rhs) { }

	// RVA: 0xFFFFFFFF711492E4
	public Boolean Equals(uint3 rhs) { }

	// RVA: 0xFFFFFFFF71149318
	public override Boolean Equals(Object o) { }

	// RVA: 0xFFFFFFFF71149320
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF71149368
	public override String ToString() { }

	// RVA: 0xFFFFFFFF71149418
	public String ToString(String format, IFormatProvider formatProvider) { }

}

// Namespace: 
internal sealed class DebuggerProxy
{}

// Namespace: Unity.Mathematics
public struct uint4
{
	// Fields
	public UInt32 x; // 0x10
	public UInt32 y; // 0x14
	public UInt32 z; // 0x18
	public UInt32 w; // 0x1C

	// Methods

	// RVA: 0xFFFFFFFF711494C8
	public Void .ctor(UInt32 x, UInt32 y, UInt32 z, UInt32 w) { }

	// RVA: 0xFFFFFFFF75BC02C8
	public static uint4 op_Multiply(uint4 lhs, uint4 rhs) { }

	// RVA: 0xFFFFFFFF75BC02F4
	public static uint4 op_Addition(uint4 lhs, uint4 rhs) { }

	// RVA: 0xFFFFFFFF711494D4
	public Boolean Equals(uint4 rhs) { }

	// RVA: 0xFFFFFFFF71149518
	public override Boolean Equals(Object o) { }

	// RVA: 0xFFFFFFFF71149520
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF7114957C
	public override String ToString() { }

	// RVA: 0xFFFFFFFF71149584
	public String ToString(String format, IFormatProvider formatProvider) { }

}

// Namespace: 
internal sealed class DebuggerProxy
{}


