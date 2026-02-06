// Namespace: 
internal class <Module>
{}

// Namespace: LitJson
public enum JsonType
{
	// Fields
	public Int32 value__; // 0x10
	public const JsonType None = 0;
	public const JsonType Object = 1;
	public const JsonType Array = 2;
	public const JsonType String = 3;
	public const JsonType Int = 4;
	public const JsonType Long = 5;
	public const JsonType Double = 6;
	public const JsonType Boolean = 7;
}

// Namespace: LitJson
public interface IJsonWrapper
{
	// Properties
	public abstract Boolean IsArray { get; }
	public abstract Boolean IsBoolean { get; }
	public abstract Boolean IsDouble { get; }
	public abstract Boolean IsInt { get; }
	public abstract Boolean IsLong { get; }
	public abstract Boolean IsObject { get; }
	public abstract Boolean IsString { get; }

	// Methods

	// RVA: -1
	public abstract Boolean get_IsArray() { }

	// RVA: -1
	public abstract Boolean get_IsBoolean() { }

	// RVA: -1
	public abstract Boolean get_IsDouble() { }

	// RVA: -1
	public abstract Boolean get_IsInt() { }

	// RVA: -1
	public abstract Boolean get_IsLong() { }

	// RVA: -1
	public abstract Boolean get_IsObject() { }

	// RVA: -1
	public abstract Boolean get_IsString() { }

	// RVA: -1
	public abstract Boolean GetBoolean() { }

	// RVA: -1
	public abstract Double GetDouble() { }

	// RVA: -1
	public abstract Int32 GetInt() { }

	// RVA: -1
	public abstract Int64 GetLong() { }

	// RVA: -1
	public abstract String GetString() { }

	// RVA: -1
	public abstract Void SetBoolean(Boolean val) { }

	// RVA: -1
	public abstract Void SetDouble(Double val) { }

	// RVA: -1
	public abstract Void SetInt(Int32 val) { }

	// RVA: -1
	public abstract Void SetJsonType(JsonType type) { }

	// RVA: -1
	public abstract Void SetLong(Int64 val) { }

	// RVA: -1
	public abstract Void SetString(String val) { }

	// RVA: -1
	public abstract String ToJson() { }

	// RVA: -1
	public abstract Void ToJson(JsonWriter writer) { }

}

// Namespace: LitJson
public class JsonData
{
	// Fields
	private IList<T0> inst_array; // 0x10
	private Boolean inst_boolean; // 0x18
	private Double inst_double; // 0x20
	private Int32 inst_int; // 0x28
	private Int64 inst_long; // 0x30
	private IDictionary<T0, T1> inst_object; // 0x38
	private String inst_string; // 0x40
	private String json; // 0x48
	private JsonType type; // 0x50
	private IList<T0> object_list; // 0x58

	// Properties
	private Int32 ICollection.Count { get; }
	private Boolean ICollection.IsSynchronized { get; }
	private Object ICollection.SyncRoot { get; }
	private Boolean IDictionary.IsFixedSize { get; }
	private Boolean IDictionary.IsReadOnly { get; }
	private ICollection IDictionary.Keys { get; }
	private ICollection IDictionary.Values { get; }
	private Boolean IJsonWrapper.IsArray { get; }
	private Boolean IJsonWrapper.IsBoolean { get; }
	private Boolean IJsonWrapper.IsDouble { get; }
	private Boolean IJsonWrapper.IsInt { get; }
	private Boolean IJsonWrapper.IsLong { get; }
	private Boolean IJsonWrapper.IsObject { get; }
	private Boolean IJsonWrapper.IsString { get; }
	private Boolean IList.IsFixedSize { get; }
	private Boolean IList.IsReadOnly { get; }
	private Object IDictionary.Item { get; set; }
	private Object IList.Item { get; set; }
	public Int32 Count { get; }
	public Boolean IsArray { get; }
	public Boolean IsBoolean { get; }
	public Boolean IsDouble { get; }
	public Boolean IsInt { get; }
	public Boolean IsLong { get; }
	public Boolean IsObject { get; }
	public Boolean IsString { get; }
	public JsonData Item { get; set; }
	public Int32 Item { set; }

	// Methods

	// RVA: 0xFFFFFFFF759C5B84
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759C5B8C
	public Void .ctor(Object obj) { }

	// RVA: 0xFFFFFFFF759C5D78
	private Int32 System.Collections.ICollection.get_Count() { }

	// RVA: 0xFFFFFFFF759C5E04
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF759C5F54
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xFFFFFFFF759C5FDC
	private Boolean System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0xFFFFFFFF759C61C4
	private Boolean System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF759C624C
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0xFFFFFFFF759C6564
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0xFFFFFFFF759C68A0
	private Boolean LitJson.IJsonWrapper.get_IsArray() { }

	// RVA: 0xFFFFFFFF759C68C0
	private Boolean LitJson.IJsonWrapper.get_IsBoolean() { }

	// RVA: 0xFFFFFFFF759C68E0
	private Boolean LitJson.IJsonWrapper.get_IsDouble() { }

	// RVA: 0xFFFFFFFF759C6900
	private Boolean LitJson.IJsonWrapper.get_IsInt() { }

	// RVA: 0xFFFFFFFF759C6920
	private Boolean LitJson.IJsonWrapper.get_IsLong() { }

	// RVA: 0xFFFFFFFF759C6940
	private Boolean LitJson.IJsonWrapper.get_IsObject() { }

	// RVA: 0xFFFFFFFF759C6960
	private Boolean LitJson.IJsonWrapper.get_IsString() { }

	// RVA: 0xFFFFFFFF759C6980
	private Boolean System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xFFFFFFFF759C6B18
	private Boolean System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF759C6BA0
	private Object System.Collections.IDictionary.get_Item(Object key) { }

	// RVA: 0xFFFFFFFF759C6C2C
	private Void System.Collections.IDictionary.set_Item(Object key, Object value) { }

	// RVA: 0xFFFFFFFF759C7128
	private Object System.Collections.IList.get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF759C71B4
	private Void System.Collections.IList.set_Item(Int32 index, Object value) { }

	// RVA: 0xFFFFFFFF759C74A0
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF759C753C
	private Void System.Collections.IDictionary.Add(Object key, Object value) { }

	// RVA: 0xFFFFFFFF759C76EC
	private Void System.Collections.IDictionary.Clear() { }

	// RVA: 0xFFFFFFFF759C7818
	private Boolean System.Collections.IDictionary.Contains(Object key) { }

	// RVA: 0xFFFFFFFF759C78A8
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0xFFFFFFFF759C7940
	private Void System.Collections.IDictionary.Remove(Object key) { }

	// RVA: 0xFFFFFFFF759C7BC0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFFFFFFFF759C7C44
	private Boolean LitJson.IJsonWrapper.GetBoolean() { }

	// RVA: 0xFFFFFFFF759C7CCC
	private Double LitJson.IJsonWrapper.GetDouble() { }

	// RVA: 0xFFFFFFFF759C7D54
	private Int32 LitJson.IJsonWrapper.GetInt() { }

	// RVA: 0xFFFFFFFF759C7DDC
	private Int64 LitJson.IJsonWrapper.GetLong() { }

	// RVA: 0xFFFFFFFF759C7E64
	private String LitJson.IJsonWrapper.GetString() { }

	// RVA: 0xFFFFFFFF759C7EEC
	private Void LitJson.IJsonWrapper.SetBoolean(Boolean val) { }

	// RVA: 0xFFFFFFFF759C7F04
	private Void LitJson.IJsonWrapper.SetDouble(Double val) { }

	// RVA: 0xFFFFFFFF759C7F1C
	private Void LitJson.IJsonWrapper.SetInt(Int32 val) { }

	// RVA: 0xFFFFFFFF759C7F34
	private Void LitJson.IJsonWrapper.SetLong(Int64 val) { }

	// RVA: 0xFFFFFFFF759C7F4C
	private Void LitJson.IJsonWrapper.SetString(String val) { }

	// RVA: 0xFFFFFFFF759C7F84
	private String LitJson.IJsonWrapper.ToJson() { }

	// RVA: 0xFFFFFFFF759C8050
	private Void LitJson.IJsonWrapper.ToJson(JsonWriter writer) { }

	// RVA: 0xFFFFFFFF759C80B8
	private Int32 System.Collections.IList.Add(Object value) { }

	// RVA: 0xFFFFFFFF759C8168
	private Void System.Collections.IList.Clear() { }

	// RVA: 0xFFFFFFFF759C8204
	private Boolean System.Collections.IList.Contains(Object value) { }

	// RVA: 0xFFFFFFFF759C8294
	private Int32 System.Collections.IList.IndexOf(Object value) { }

	// RVA: 0xFFFFFFFF759C8324
	private Void System.Collections.IList.Insert(Int32 index, Object value) { }

	// RVA: 0xFFFFFFFF759C83D8
	private Void System.Collections.IList.Remove(Object value) { }

	// RVA: 0xFFFFFFFF759C8484
	private Void System.Collections.IList.RemoveAt(Int32 index) { }

	// RVA: 0xFFFFFFFF759C8530
	private IDictionaryEnumerator System.Collections.Specialized.IOrderedDictionary.GetEnumerator() { }

	// RVA: 0xFFFFFFFF759C5D7C
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF759C68B0
	public Boolean get_IsArray() { }

	// RVA: 0xFFFFFFFF759C68D0
	public Boolean get_IsBoolean() { }

	// RVA: 0xFFFFFFFF759C68F0
	public Boolean get_IsDouble() { }

	// RVA: 0xFFFFFFFF759C6910
	public Boolean get_IsInt() { }

	// RVA: 0xFFFFFFFF759C6930
	public Boolean get_IsLong() { }

	// RVA: 0xFFFFFFFF759C6950
	public Boolean get_IsObject() { }

	// RVA: 0xFFFFFFFF759C6970
	public Boolean get_IsString() { }

	// RVA: 0xFFFFFFFF759C8650
	public JsonData get_Item(String prop_name) { }

	// RVA: 0xFFFFFFFF759C6D84
	public Void set_Item(String prop_name, JsonData value) { }

	// RVA: 0xFFFFFFFF759C71F8
	public Void set_Item(Int32 index, JsonData value) { }

	// RVA: 0xFFFFFFFF759C5E8C
	private ICollection EnsureCollection() { }

	// RVA: 0xFFFFFFFF759C6064
	private IDictionary EnsureDictionary() { }

	// RVA: 0xFFFFFFFF759C6A08
	private IList EnsureList() { }

	// RVA: 0xFFFFFFFF759C6CF8
	private JsonData ToJsonData(Object obj) { }

	// RVA: 0xFFFFFFFF759C870C
	private static Void WriteJson(IJsonWrapper obj, JsonWriter writer) { }

	// RVA: 0xFFFFFFFF759C80BC
	public Int32 Add(Object value) { }

	// RVA: 0xFFFFFFFF759C9A38
	public Boolean Equals(JsonData x) { }

	// RVA: 0xFFFFFFFF759C9B24
	public Void SetJsonType(JsonType type) { }

	// RVA: 0xFFFFFFFF759C7F88
	public String ToJson() { }

	// RVA: 0xFFFFFFFF759C8084
	public Void ToJson(JsonWriter writer) { }

	// RVA: 0xFFFFFFFF759C9D28
	public override String ToString() { }

}

// Namespace: LitJson
internal class OrderedDictionaryEnumerator
{
	// Fields
	private IEnumerator<T0> list_enumerator; // 0x10

	// Properties
	public Object Current { get; }
	public DictionaryEntry Entry { get; }
	public Object Key { get; }
	public Object Value { get; }

	// Methods

	// RVA: 0xFFFFFFFF759C861C
	public Void .ctor(IEnumerator<T0> enumerator) { }

	// RVA: 0xFFFFFFFF759D437C
	public Object get_Current() { }

	// RVA: 0xFFFFFFFF759D43DC
	public DictionaryEntry get_Entry() { }

	// RVA: 0xFFFFFFFF759D44C8
	public Object get_Key() { }

	// RVA: 0xFFFFFFFF759D4578
	public Object get_Value() { }

	// RVA: 0xFFFFFFFF759D4630
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF759D46B0
	public Void Reset() { }

}

// Namespace: LitJson
public class JsonException
{
	// Methods

	// RVA: 0xFFFFFFFF759C9E1C
	internal Void .ctor(ParserToken token, Exception inner_exception) { }

	// RVA: 0xFFFFFFFF759C9EB8
	internal Void .ctor(Int32 c) { }

	// RVA: 0xFFFFFFFF759C9F40
	public Void .ctor(String message) { }

}

// Namespace: LitJson
internal struct PropertyMetadata
{
	// Fields
	public MemberInfo Info; // 0x10
	public Boolean IsField; // 0x18
	public Type Type; // 0x20
}

// Namespace: LitJson
internal struct ArrayMetadata
{
	// Fields
	private Type element_type; // 0x10
	private Boolean is_array; // 0x18
	private Boolean is_list; // 0x19

	// Properties
	public Type ElementType { get; set; }
	public Boolean IsArray { get; set; }
	public Boolean IsList { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF71144A44
	public Type get_ElementType() { }

	// RVA: 0xFFFFFFFF71144A4C
	public Void set_ElementType(Type value) { }

	// RVA: 0xFFFFFFFF71144A54
	public Boolean get_IsArray() { }

	// RVA: 0xFFFFFFFF71144A5C
	public Void set_IsArray(Boolean value) { }

	// RVA: 0xFFFFFFFF71144A64
	public Boolean get_IsList() { }

	// RVA: 0xFFFFFFFF71144A6C
	public Void set_IsList(Boolean value) { }

}

// Namespace: LitJson
internal struct ObjectMetadata
{
	// Fields
	private Type element_type; // 0x10
	private Boolean is_dictionary; // 0x18
	private IDictionary<T0, T1> properties; // 0x20

	// Properties
	public Type ElementType { get; set; }
	public Boolean IsDictionary { get; set; }
	public IDictionary<T0, T1> Properties { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF71144AB0
	public Type get_ElementType() { }

	// RVA: 0xFFFFFFFF71144AB8
	public Void set_ElementType(Type value) { }

	// RVA: 0xFFFFFFFF71144AC0
	public Boolean get_IsDictionary() { }

	// RVA: 0xFFFFFFFF71144AC8
	public Void set_IsDictionary(Boolean value) { }

	// RVA: 0xFFFFFFFF71144AD0
	public IDictionary<T0, T1> get_Properties() { }

	// RVA: 0xFFFFFFFF71144AD8
	public Void set_Properties(IDictionary<T0, T1> value) { }

}

// Namespace: LitJson
public class JsonMapper
{
	// Fields
	private static Int32 max_nesting_depth; // 0x0
	private static IFormatProvider datetime_format; // 0x8
	private static IDictionary<T0, T1> base_exporters_table; // 0x10
	private static IDictionary<T0, T1> custom_exporters_table; // 0x18
	private static IDictionary<T0, T1> base_importers_table; // 0x20
	private static IDictionary<T0, T1> custom_importers_table; // 0x28
	private static IDictionary<T0, T1> array_metadata; // 0x30
	private static readonly Object array_metadata_lock; // 0x38
	private static IDictionary<T0, T1> conv_ops; // 0x40
	private static readonly Object conv_ops_lock; // 0x48
	private static IDictionary<T0, T1> object_metadata; // 0x50
	private static readonly Object object_metadata_lock; // 0x58
	private static IDictionary<T0, T1> type_properties; // 0x60
	private static readonly Object type_properties_lock; // 0x68
	private static JsonWriter static_writer; // 0x70
	private static readonly Object static_writer_lock; // 0x78

	// Methods

	// RVA: 0xFFFFFFFF759C9F48
	private static Void .cctor() { }

	// RVA: -1
	public static T ToObject(String json) { }

	// RVA: -1
	public static Void RegisterImporter(ImporterFunc<T0, T1> importer) { }

	// RVA: 0xFFFFFFFF759CB15C
	private static Void AddArrayMetadata(Type type) { }

	// RVA: 0xFFFFFFFF759CB54C
	private static Void AddObjectMetadata(Type type) { }

	// RVA: 0xFFFFFFFF759CBBEC
	private static Void AddTypeProperties(Type type) { }

	// RVA: 0xFFFFFFFF759CC0E8
	private static MethodInfo GetConvOp(Type t1, Type t2) { }

	// RVA: 0xFFFFFFFF759CC7E8
	private static Object ReadValue(Type inst_type, JsonReader reader) { }

	// RVA: 0xFFFFFFFF759CDB60
	private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader) { }

	// RVA: 0xFFFFFFFF759CA37C
	private static Void RegisterBaseExporters() { }

	// RVA: 0xFFFFFFFF759CAB04
	private static Void RegisterBaseImporters() { }

	// RVA: 0xFFFFFFFF759CE388
	private static Void RegisterImporter(IDictionary<T0, T1> table, Type json_type, Type value_type, ImporterFunc importer) { }

	// RVA: 0xFFFFFFFF759CE5CC
	private static Void WriteValue(Object obj, JsonWriter writer, Boolean writer_is_private, Int32 depth) { }

	// RVA: 0xFFFFFFFF759CF99C
	public static String ToJson(Object obj) { }

	// RVA: 0xFFFFFFFF759CFB74
	public static Void ToJson(Object obj, JsonWriter writer) { }

	// RVA: 0xFFFFFFFF759CFBC0
	public static JsonData ToObject(String json) { }

	// RVA: 0xFFFFFFFF759CFCEC
	public static IJsonWrapper ToWrapper(WrapperFactory factory, String json) { }

}

// Namespace: 
private class <>c__CompilerGenerated0
{
	// Methods

	// RVA: 0xFFFFFFFF759CE378
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759CFDE4
	internal Void <RegisterBaseExporters>c__7(Object obj, JsonWriter writer) { }

	// RVA: 0xFFFFFFFF759CFE70
	internal Void <RegisterBaseExporters>c__8(Object obj, JsonWriter writer) { }

	// RVA: 0xFFFFFFFF759CFEFC
	internal Void <RegisterBaseExporters>c__9(Object obj, JsonWriter writer) { }

	// RVA: 0xFFFFFFFF759CFFBC
	internal Void <RegisterBaseExporters>c__10(Object obj, JsonWriter writer) { }

	// RVA: 0xFFFFFFFF759D00F4
	internal Void <RegisterBaseExporters>c__11(Object obj, JsonWriter writer) { }

	// RVA: 0xFFFFFFFF759D0180
	internal Void <RegisterBaseExporters>c__12(Object obj, JsonWriter writer) { }

	// RVA: 0xFFFFFFFF759D020C
	internal Void <RegisterBaseExporters>c__13(Object obj, JsonWriter writer) { }

	// RVA: 0xFFFFFFFF759D0298
	internal Void <RegisterBaseExporters>c__14(Object obj, JsonWriter writer) { }

	// RVA: 0xFFFFFFFF759D0324
	internal Void <RegisterBaseExporters>c__15(Object obj, JsonWriter writer) { }

}

// Namespace: 
private class <>c__CompilerGenerated1
{
	// Methods

	// RVA: 0xFFFFFFFF759CE380
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759D0384
	internal Object <RegisterBaseImporters>c__16(Object input) { }

	// RVA: 0xFFFFFFFF759D0418
	internal Object <RegisterBaseImporters>c__17(Object input) { }

	// RVA: 0xFFFFFFFF759D04AC
	internal Object <RegisterBaseImporters>c__18(Object input) { }

	// RVA: 0xFFFFFFFF759D0540
	internal Object <RegisterBaseImporters>c__19(Object input) { }

	// RVA: 0xFFFFFFFF759D05D4
	internal Object <RegisterBaseImporters>c__20(Object input) { }

	// RVA: 0xFFFFFFFF759D0668
	internal Object <RegisterBaseImporters>c__21(Object input) { }

	// RVA: 0xFFFFFFFF759D06FC
	internal Object <RegisterBaseImporters>c__22(Object input) { }

	// RVA: 0xFFFFFFFF759D0790
	internal Object <RegisterBaseImporters>c__23(Object input) { }

	// RVA: 0xFFFFFFFF759D0824
	internal Object <RegisterBaseImporters>c__24(Object input) { }

	// RVA: 0xFFFFFFFF759D08B8
	internal Object <RegisterBaseImporters>c__25(Object input) { }

	// RVA: 0xFFFFFFFF759D094C
	internal Object <RegisterBaseImporters>c__26(Object input) { }

	// RVA: 0xFFFFFFFF759D09D0
	internal Object <RegisterBaseImporters>c__27(Object input) { }

}

// Namespace: 
private class <>c__CompilerGenerated4
{
	// Methods

	// RVA: 0xFFFFFFFF759CFCD0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759D0A80
	internal IJsonWrapper <ToObject>c__30() { }

}

// Namespace: 
private class <>c__CompilerGenerated6<T0, T1>
{
	// Fields
	internal ImporterFunc<T0, T1> <7:importer>; // 0x0

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	internal Object <RegisterImporter>c__32(Object input) { }

}

// Namespace: LitJson
public enum JsonToken
{
	// Fields
	public Int32 value__; // 0x10
	public const JsonToken None = 0;
	public const JsonToken ObjectStart = 1;
	public const JsonToken PropertyName = 2;
	public const JsonToken ObjectEnd = 3;
	public const JsonToken ArrayStart = 4;
	public const JsonToken ArrayEnd = 5;
	public const JsonToken Int = 6;
	public const JsonToken Long = 7;
	public const JsonToken Double = 8;
	public const JsonToken String = 9;
	public const JsonToken Boolean = 10;
	public const JsonToken Null = 11;
}

// Namespace: LitJson
public class JsonReader
{
	// Fields
	private static IDictionary<T0, T1> parse_table; // 0x0
	private Stack<T0> automaton_stack; // 0x10
	private Int32 current_input; // 0x18
	private Int32 current_symbol; // 0x1C
	private Boolean end_of_json; // 0x20
	private Boolean end_of_input; // 0x21
	private Lexer lexer; // 0x28
	private Boolean parser_in_string; // 0x30
	private Boolean parser_return; // 0x31
	private Boolean read_started; // 0x32
	private TextReader reader; // 0x38
	private Boolean reader_is_owned; // 0x40
	private Object token_value; // 0x48
	private JsonToken token; // 0x50

	// Properties
	public JsonToken Token { get; }
	public Object Value { get; }

	// Methods

	// RVA: 0xFFFFFFFF759CFD94
	public Void .ctor(String json_text) { }

	// RVA: 0xFFFFFFFF759D0AD4
	private Void .ctor(TextReader reader, Boolean owned) { }

	// RVA: 0xFFFFFFFF759D0D18
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF759D1278
	public JsonToken get_Token() { }

	// RVA: 0xFFFFFFFF759D1280
	public Object get_Value() { }

	// RVA: 0xFFFFFFFF759D0D1C
	private static Void PopulateParseTable() { }

	// RVA: 0xFFFFFFFF759D138C
	private static Void TableAddCol(ParserToken row, Int32 col, Int32[] symbols) { }

	// RVA: 0xFFFFFFFF759D1288
	private static Void TableAddRow(ParserToken rule) { }

	// RVA: 0xFFFFFFFF759D14F4
	private Void ProcessNumber(String number) { }

	// RVA: 0xFFFFFFFF759D164C
	private Void ProcessSymbol() { }

	// RVA: 0xFFFFFFFF759D17EC
	private Boolean ReadToken() { }

	// RVA: 0xFFFFFFFF759D1A08
	public Void Close() { }

	// RVA: 0xFFFFFFFF759CD690
	public Boolean Read() { }

}

// Namespace: LitJson
internal enum Condition
{
	// Fields
	public Int32 value__; // 0x10
	public const Condition InArray = 0;
	public const Condition InObject = 1;
	public const Condition NotAProperty = 2;
	public const Condition Property = 3;
	public const Condition Value = 4;
}

// Namespace: LitJson
internal class WriterContext
{
	// Fields
	public Int32 Count; // 0x10
	public Boolean InArray; // 0x14
	public Boolean InObject; // 0x15
	public Boolean ExpectingValue; // 0x16
	public Int32 Padding; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF759D1DE8
	public Void .ctor() { }

}

// Namespace: LitJson
public class JsonWriter
{
	// Fields
	private static NumberFormatInfo number_format; // 0x0
	private WriterContext context; // 0x10
	private Stack<T0> ctx_stack; // 0x18
	private Boolean has_reached_end; // 0x20
	private Char[] hex_seq; // 0x28
	private Int32 indentation; // 0x30
	private Int32 indent_value; // 0x34
	private StringBuilder inst_string_builder; // 0x38
	private Boolean pretty_print; // 0x40
	private Boolean validate; // 0x41
	private TextWriter writer; // 0x48

	// Properties
	public Boolean PrettyPrint { set; }
	public TextWriter TextWriter { get; }
	public Boolean Validate { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF759CA2CC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759C9C8C
	public Void .ctor(TextWriter writer) { }

	// RVA: 0xFFFFFFFF759D1B80
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF759D1BD4
	public Void set_PrettyPrint(Boolean value) { }

	// RVA: 0xFFFFFFFF759D1BDC
	public TextWriter get_TextWriter() { }

	// RVA: 0xFFFFFFFF759D1BE4
	public Boolean get_Validate() { }

	// RVA: 0xFFFFFFFF759D1BEC
	public Void set_Validate(Boolean value) { }

	// RVA: 0xFFFFFFFF759D1BF4
	private Void DoValidation(Condition cond) { }

	// RVA: 0xFFFFFFFF759D1A70
	private Void Init() { }

	// RVA: 0xFFFFFFFF759D1DF0
	private static Void IntToHex(Int32 n, Char[] hex) { }

	// RVA: 0xFFFFFFFF759D1F0C
	private Void Indent() { }

	// RVA: 0xFFFFFFFF759D1F24
	private Void Put(String str) { }

	// RVA: 0xFFFFFFFF759D1FC0
	private Void PutNewline() { }

	// RVA: 0xFFFFFFFF759D1FC8
	private Void PutNewline(Boolean add_comma) { }

	// RVA: 0xFFFFFFFF759D2064
	private Void PutString(String str) { }

	// RVA: 0xFFFFFFFF759D2320
	private Void Unindent() { }

	// RVA: 0xFFFFFFFF759D2338
	public override String ToString() { }

	// RVA: 0xFFFFFFFF759CFA9C
	public Void Reset() { }

	// RVA: 0xFFFFFFFF759C9244
	public Void Write(Boolean boolean) { }

	// RVA: 0xFFFFFFFF759D001C
	public Void Write(Decimal number) { }

	// RVA: 0xFFFFFFFF759C92B0
	public Void Write(Double number) { }

	// RVA: 0xFFFFFFFF759C93E8
	public Void Write(Int32 number) { }

	// RVA: 0xFFFFFFFF759C94B8
	public Void Write(Int64 number) { }

	// RVA: 0xFFFFFFFF759C91DC
	public Void Write(String str) { }

	// RVA: 0xFFFFFFFF759CF8CC
	public Void Write(UInt64 number) { }

	// RVA: 0xFFFFFFFF759C9668
	public Void WriteArrayEnd() { }

	// RVA: 0xFFFFFFFF759C9588
	public Void WriteArrayStart() { }

	// RVA: 0xFFFFFFFF759C9950
	public Void WriteObjectEnd() { }

	// RVA: 0xFFFFFFFF759C9750
	public Void WriteObjectStart() { }

	// RVA: 0xFFFFFFFF759C9830
	public Void WritePropertyName(String property_name) { }

}

// Namespace: LitJson
internal class FsmContext
{
	// Fields
	public Boolean Return; // 0x10
	public Int32 NextState; // 0x14
	public Lexer L; // 0x18
	public Int32 StateStack; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF759C5778
	public Void .ctor() { }

}

// Namespace: LitJson
internal class Lexer
{
	// Fields
	private static Int32[] fsm_return_table; // 0x0
	private static StateHandler[] fsm_handler_table; // 0x8
	private Boolean allow_comments; // 0x10
	private Boolean allow_single_quoted_strings; // 0x11
	private Boolean end_of_input; // 0x12
	private FsmContext fsm_context; // 0x18
	private Int32 input_buffer; // 0x20
	private Int32 input_char; // 0x24
	private TextReader reader; // 0x28
	private Int32 state; // 0x30
	private StringBuilder string_buffer; // 0x38
	private String string_value; // 0x40
	private Int32 token; // 0x48
	private Int32 unichar; // 0x4C

	// Properties
	public Boolean EndOfInput { get; }
	public Int32 Token { get; }
	public String StringValue { get; }

	// Methods

	// RVA: 0xFFFFFFFF759D0C30
	public Void .ctor(TextReader reader) { }

	// RVA: 0xFFFFFFFF759D235C
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF759D2C20
	public Boolean get_EndOfInput() { }

	// RVA: 0xFFFFFFFF759D2C28
	public Int32 get_Token() { }

	// RVA: 0xFFFFFFFF759D2C30
	public String get_StringValue() { }

	// RVA: 0xFFFFFFFF759D2C38
	private static Int32 HexValue(Int32 digit) { }

	// RVA: 0xFFFFFFFF759D2360
	private static Void PopulateFsmTables() { }

	// RVA: 0xFFFFFFFF759D2CD0
	private static Char ProcessEscChar(Int32 esc_char) { }

	// RVA: 0xFFFFFFFF759D2DA8
	private static Boolean State1(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D2FC0
	private static Boolean State2(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D3050
	private static Boolean State3(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D316C
	private static Boolean State4(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D3250
	private static Boolean State5(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D32B8
	private static Boolean State6(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D33A4
	private static Boolean State7(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D3420
	private static Boolean State8(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D34E4
	private static Boolean State9(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D3534
	private static Boolean State10(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D3584
	private static Boolean State11(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D35D8
	private static Boolean State12(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D3628
	private static Boolean State13(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D3678
	private static Boolean State14(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D36C8
	private static Boolean State15(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D371C
	private static Boolean State16(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D376C
	private static Boolean State17(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D37BC
	private static Boolean State18(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D3810
	private static Boolean State19(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D38A0
	private static Boolean State20(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D38F4
	private static Boolean State21(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D39F8
	private static Boolean State22(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D3CA8
	private static Boolean State23(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D3D38
	private static Boolean State24(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D3D94
	private static Boolean State25(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D3DF8
	private static Boolean State26(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D3E4C
	private static Boolean State27(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D3EA0
	private static Boolean State28(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D2F5C
	private Boolean GetChar() { }

	// RVA: 0xFFFFFFFF759D3F04
	private Int32 NextChar() { }

	// RVA: 0xFFFFFFFF759D184C
	public Boolean NextToken() { }

	// RVA: 0xFFFFFFFF759D3160
	private Void UngetChar() { }

}

// Namespace: 
private sealed class StateHandler
{
	// Methods

	// RVA: 0xFFFFFFFF759D2CBC
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF759D3F44
	public virtual Boolean Invoke(FsmContext ctx) { }

	// RVA: 0xFFFFFFFF759D42D8
	public virtual IAsyncResult BeginInvoke(FsmContext ctx, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759D4328
	public virtual Boolean EndInvoke(IAsyncResult result) { }

}

// Namespace: LitJson
internal enum ParserToken
{
	// Fields
	public Int32 value__; // 0x10
	public const ParserToken None = 65536;
	public const ParserToken Number = 65537;
	public const ParserToken True = 65538;
	public const ParserToken False = 65539;
	public const ParserToken Null = 65540;
	public const ParserToken CharSeq = 65541;
	public const ParserToken Char = 65542;
	public const ParserToken Text = 65543;
	public const ParserToken Object = 65544;
	public const ParserToken ObjectPrime = 65545;
	public const ParserToken Pair = 65546;
	public const ParserToken PairRest = 65547;
	public const ParserToken Array = 65548;
	public const ParserToken ArrayPrime = 65549;
	public const ParserToken Value = 65550;
	public const ParserToken ValueRest = 65551;
	public const ParserToken String = 65552;
	public const ParserToken End = 65553;
	public const ParserToken Epsilon = 65554;
}

// Namespace: LitJson
internal sealed class ExporterFunc
{
	// Methods

	// RVA: 0xFFFFFFFF759C5330
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF759C5344
	public virtual Void Invoke(Object obj, JsonWriter writer) { }

	// RVA: 0xFFFFFFFF759C5710
	public virtual IAsyncResult BeginInvoke(Object obj, JsonWriter writer, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759C576C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: LitJson
internal sealed class ImporterFunc
{
	// Methods

	// RVA: 0xFFFFFFFF759C5780
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF759C5794
	public virtual Object Invoke(Object input) { }

	// RVA: 0xFFFFFFFF759C5B28
	public virtual IAsyncResult BeginInvoke(Object input, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759C5B78
	public virtual Object EndInvoke(IAsyncResult result) { }

}

// Namespace: LitJson
public sealed class ImporterFunc<T0, T1>
{
	// Methods

	// RVA: -1
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: -1
	public virtual TValue Invoke(TJson input) { }

	// RVA: -1
	public virtual IAsyncResult BeginInvoke(TJson input, AsyncCallback callback, Object object) { }

	// RVA: -1
	public virtual TValue EndInvoke(IAsyncResult result) { }

}

// Namespace: LitJson
public sealed class WrapperFactory
{
	// Methods

	// RVA: 0xFFFFFFFF759CFCD8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF759CE178
	public virtual IJsonWrapper Invoke() { }

	// RVA: 0xFFFFFFFF759D4734
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759D478C
	public virtual IJsonWrapper EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal class <PrivateImplementationDetails>
{
	// Fields
	internal static $ArrayType$116 $$field-0; // 0x0
}

// Namespace: 
private struct $ArrayType$116
{}


