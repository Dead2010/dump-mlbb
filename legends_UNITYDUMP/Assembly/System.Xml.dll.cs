// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class SR
{
	// Methods

	// RVA: 0xFFFFFFFF75A722E0
	internal static String GetString(String name, Object[] args) { }

	// RVA: 0xFFFFFFFF75A72330
	internal static String GetString(CultureInfo culture, String name, Object[] args) { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class AbsoluteQuery
{
	// Methods

	// RVA: 0xFFFFFFFF75A5CFCC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A5D01C
	private Void .ctor(AbsoluteQuery other) { }

	// RVA: 0xFFFFFFFF75A5D078
	public override Object Evaluate(XPathNodeIterator context) { }

	// RVA: 0xFFFFFFFF75A5D104
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class AstNode
{
	// Properties
	public abstract AstType Type { get; }
	public abstract XPathResultType ReturnType { get; }

	// Methods

	// RVA: -1
	public abstract AstType get_Type() { }

	// RVA: -1
	public abstract XPathResultType get_ReturnType() { }

	// RVA: 0xFFFFFFFF75A5D15C
	protected Void .ctor() { }

}

// Namespace: 
public enum AstType
{
	// Fields
	public Int32 value__; // 0x10
	public const AstType Axis = 0;
	public const AstType Operator = 1;
	public const AstType Filter = 2;
	public const AstType ConstantOperand = 3;
	public const AstType Function = 4;
	public const AstType Group = 5;
	public const AstType Root = 6;
	public const AstType Variable = 7;
	public const AstType Error = 8;
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class AttributeQuery
{
	// Fields
	private Boolean onAttribute; // 0x54

	// Methods

	// RVA: 0xFFFFFFFF75A5D160
	public Void .ctor(Query qyParent, String Name, String Prefix, XPathNodeType Type) { }

	// RVA: 0xFFFFFFFF75A5D268
	private Void .ctor(AttributeQuery other) { }

	// RVA: 0xFFFFFFFF75A5D39C
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A5D3F8
	public override XPathNavigator Advance() { }

	// RVA: 0xFFFFFFFF75A5D4F4
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Axis
{
	// Fields
	private AxisType axisType; // 0x10
	private AstNode input; // 0x18
	private String prefix; // 0x20
	private String name; // 0x28
	private XPathNodeType nodeType; // 0x30
	protected Boolean abbrAxis; // 0x34
	private String urn; // 0x38

	// Properties
	public override AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public AstNode Input { get; }
	public String Prefix { get; }
	public String Name { get; }
	public XPathNodeType NodeType { get; }
	public AxisType TypeOfAxis { get; }
	public Boolean AbbrAxis { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A5D55C
	public Void .ctor(AxisType axisType, AstNode input, String prefix, String name, XPathNodeType nodetype) { }

	// RVA: 0xFFFFFFFF75A5D62C
	public Void .ctor(AxisType axisType, AstNode input) { }

	// RVA: 0xFFFFFFFF75A5D66C
	public override AstType get_Type() { }

	// RVA: 0xFFFFFFFF75A5D674
	public override XPathResultType get_ReturnType() { }

	// RVA: 0xFFFFFFFF75A5D67C
	public AstNode get_Input() { }

	// RVA: 0xFFFFFFFF75A5D684
	public String get_Prefix() { }

	// RVA: 0xFFFFFFFF75A5D68C
	public String get_Name() { }

	// RVA: 0xFFFFFFFF75A5D694
	public XPathNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF75A5D69C
	public AxisType get_TypeOfAxis() { }

	// RVA: 0xFFFFFFFF75A5D6A4
	public Boolean get_AbbrAxis() { }

}

// Namespace: 
public enum AxisType
{
	// Fields
	public Int32 value__; // 0x10
	public const AxisType Ancestor = 0;
	public const AxisType AncestorOrSelf = 1;
	public const AxisType Attribute = 2;
	public const AxisType Child = 3;
	public const AxisType Descendant = 4;
	public const AxisType DescendantOrSelf = 5;
	public const AxisType Following = 6;
	public const AxisType FollowingSibling = 7;
	public const AxisType Namespace = 8;
	public const AxisType Parent = 9;
	public const AxisType Preceding = 10;
	public const AxisType PrecedingSibling = 11;
	public const AxisType Self = 12;
	public const AxisType None = 13;
}

// Namespace: MS.Internal.Xml.XPath
internal abstract class BaseAxisQuery
{
	// Fields
	internal Query qyInput; // 0x18
	private Boolean nameTest; // 0x20
	private String name; // 0x28
	private String prefix; // 0x30
	private String nsUri; // 0x38
	private XPathNodeType typeTest; // 0x40
	protected XPathNavigator currentNode; // 0x48
	protected Int32 position; // 0x50

	// Properties
	protected String Name { get; }
	protected String Namespace { get; }
	protected Boolean NameTest { get; }
	protected XPathNodeType TypeTest { get; }
	public override Int32 CurrentPosition { get; }
	public override XPathNavigator Current { get; }
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A5D6AC
	protected Void .ctor(Query qyInput) { }

	// RVA: 0xFFFFFFFF75A5D164
	protected Void .ctor(Query qyInput, String name, String prefix, XPathNodeType typeTest) { }

	// RVA: 0xFFFFFFFF75A5D29C
	protected Void .ctor(BaseAxisQuery other) { }

	// RVA: 0xFFFFFFFF75A5D3A4
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A5D878
	public override Void SetXsltContext(XsltContext context) { }

	// RVA: 0xFFFFFFFF75A5D8F4
	protected String get_Name() { }

	// RVA: 0xFFFFFFFF75A5D8FC
	protected String get_Namespace() { }

	// RVA: 0xFFFFFFFF75A5D904
	protected Boolean get_NameTest() { }

	// RVA: 0xFFFFFFFF75A5D90C
	protected XPathNodeType get_TypeTest() { }

	// RVA: 0xFFFFFFFF75A5D914
	public override Int32 get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75A5D91C
	public override XPathNavigator get_Current() { }

	// RVA: 0xFFFFFFFF75A5D924
	public virtual Boolean matches(XPathNavigator e) { }

	// RVA: 0xFFFFFFFF75A5DA44
	public override Object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A5DAAC
	public override XPathResultType get_StaticType() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class BooleanExpr
{
	// Fields
	private Query opnd1; // 0x18
	private Query opnd2; // 0x20
	private Boolean isOr; // 0x28

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A5DAB4
	public Void .ctor(Op op, Query opnd1, Query opnd2) { }

	// RVA: 0xFFFFFFFF75A5DCC8
	private Void .ctor(BooleanExpr other) { }

	// RVA: 0xFFFFFFFF75A5DD90
	public override Void SetXsltContext(XsltContext context) { }

	// RVA: 0xFFFFFFFF75A5DDE4
	public override Object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A5DE98
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A5DEF0
	public override XPathResultType get_StaticType() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class BooleanFunctions
{
	// Fields
	private Query arg; // 0x18
	private FunctionType funcType; // 0x20

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A5DC6C
	public Void .ctor(FunctionType funcType, Query arg) { }

	// RVA: 0xFFFFFFFF75A5DEF8
	private Void .ctor(BooleanFunctions other) { }

	// RVA: 0xFFFFFFFF75A5DF64
	public override Void SetXsltContext(XsltContext context) { }

	// RVA: 0xFFFFFFFF75A5DF80
	public override Object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A5E2A0
	internal static Boolean toBoolean(Double number) { }

	// RVA: 0xFFFFFFFF75A5E2F8
	internal static Boolean toBoolean(String str) { }

	// RVA: 0xFFFFFFFF75A5E050
	internal Boolean toBoolean(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A5E31C
	public override XPathResultType get_StaticType() { }

	// RVA: 0xFFFFFFFF75A5E178
	private Boolean Not(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A5E1D8
	private Boolean Lang(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A5E324
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class CacheAxisQuery
{
	// Fields
	protected List<T0> outputBuffer; // 0x58

	// Properties
	public override XPathNavigator Current { get; }
	public override Int32 CurrentPosition { get; }
	public override Int32 Count { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A5E37C
	public Void .ctor(Query qyInput, String name, String prefix, XPathNodeType typeTest) { }

	// RVA: 0xFFFFFFFF75A5E438
	protected Void .ctor(CacheAxisQuery other) { }

	// RVA: 0xFFFFFFFF75A5E4E8
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A5E4F0
	public override Object Evaluate(XPathNodeIterator context) { }

	// RVA: 0xFFFFFFFF75A5E58C
	public override XPathNavigator Advance() { }

	// RVA: 0xFFFFFFFF75A5E624
	public override XPathNavigator get_Current() { }

	// RVA: 0xFFFFFFFF75A5E6A0
	public override Int32 get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75A5E6A8
	public override Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75A5E6F4
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class CacheChildrenQuery
{
	// Fields
	private XPathNavigator nextInput; // 0x60
	private ClonableStack<T0> elementStk; // 0x68
	private ClonableStack<T0> positionStk; // 0x70
	private Boolean needInput; // 0x78

	// Methods

	// RVA: 0xFFFFFFFF75A5E6FC
	public Void .ctor(Query qyInput, String name, String prefix, XPathNodeType type) { }

	// RVA: 0xFFFFFFFF75A5E8C0
	private Void .ctor(CacheChildrenQuery other) { }

	// RVA: 0xFFFFFFFF75A5EAB4
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A5EBC8
	public override XPathNavigator Advance() { }

	// RVA: 0xFFFFFFFF75A5EDC0
	private Boolean DecideNextNode() { }

	// RVA: 0xFFFFFFFF75A5ED40
	private XPathNavigator GetNextInput() { }

	// RVA: 0xFFFFFFFF75A5EFF8
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class CacheOutputQuery
{
	// Fields
	internal Query input; // 0x18
	protected List<T0> outputBuffer; // 0x20

	// Properties
	public override XPathNavigator Current { get; }
	public override XPathResultType StaticType { get; }
	public override Int32 CurrentPosition { get; }
	public override Int32 Count { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A5F050
	public Void .ctor(Query input) { }

	// RVA: 0xFFFFFFFF75A5F110
	protected Void .ctor(CacheOutputQuery other) { }

	// RVA: 0xFFFFFFFF75A5F1EC
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A5F1F4
	public override Void SetXsltContext(XsltContext context) { }

	// RVA: 0xFFFFFFFF75A5F21C
	public override Object Evaluate(XPathNodeIterator context) { }

	// RVA: 0xFFFFFFFF75A5F298
	public override XPathNavigator Advance() { }

	// RVA: 0xFFFFFFFF75A5F330
	public override XPathNavigator get_Current() { }

	// RVA: 0xFFFFFFFF75A5F3AC
	public override XPathResultType get_StaticType() { }

	// RVA: 0xFFFFFFFF75A5F3B4
	public override Int32 get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75A5F3BC
	public override Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75A5F408
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class ChildrenQuery
{
	// Fields
	private XPathNodeIterator iterator; // 0x58

	// Methods

	// RVA: 0xFFFFFFFF75A5E80C
	public Void .ctor(Query qyInput, String name, String prefix, XPathNodeType type) { }

	// RVA: 0xFFFFFFFF75A5E9C4
	protected Void .ctor(ChildrenQuery other) { }

	// RVA: 0xFFFFFFFF75A5EB44
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A5F428
	public override XPathNavigator Advance() { }

	// RVA: 0xFFFFFFFF75A5F640
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class ClonableStack<T0>
{
	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	private Void .ctor(IEnumerable<T0> collection) { }

	// RVA: -1
	public Void Push(T value) { }

	// RVA: -1
	public T Pop() { }

	// RVA: -1
	public T Peek() { }

	// RVA: -1
	public ClonableStack<T0> Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class CompiledXpathExpr
{
	// Fields
	private Query query; // 0x10
	private String expr; // 0x18
	private Boolean needContext; // 0x20

	// Properties
	internal Query QueryTree { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A5F698
	internal Void .ctor(Query query, String expression, Boolean needContext) { }

	// RVA: 0xFFFFFFFF75A5F714
	internal Query get_QueryTree() { }

	// RVA: 0xFFFFFFFF75A5F784
	public override Void SetContext(XmlNamespaceManager nsManager) { }

	// RVA: 0xFFFFFFFF75A5F794
	public override Void SetContext(IXmlNamespaceResolver nsResolver) { }

}

// Namespace: 
private class UndefinedXsltContext
{
	// Fields
	private IXmlNamespaceResolver nsResolver; // 0x50

	// Properties
	public override String DefaultNamespace { get; }
	public override Boolean Whitespace { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A5F8C0
	public Void .ctor(IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75A5F908
	public override String get_DefaultNamespace() { }

	// RVA: 0xFFFFFFFF75A5F91C
	public override String LookupNamespace(String prefix) { }

	// RVA: 0xFFFFFFFF75A5FA30
	public override IXsltContextVariable ResolveVariable(String prefix, String name) { }

	// RVA: 0xFFFFFFFF75A5FA84
	public override IXsltContextFunction ResolveFunction(String prefix, String name, XPathResultType[] ArgTypes) { }

	// RVA: 0xFFFFFFFF75A5FAD8
	public override Boolean get_Whitespace() { }

	// RVA: 0xFFFFFFFF75A5FAE0
	public override Boolean PreserveWhitespace(XPathNavigator node) { }

}

// Namespace: MS.Internal.Xml.XPath
internal class ContextQuery
{
	// Fields
	protected XPathNavigator contextNode; // 0x18

	// Properties
	public override XPathNavigator Current { get; }
	public override XPathResultType StaticType { get; }
	public override Int32 CurrentPosition { get; }
	public override Int32 Count { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A5CFF4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A5D020
	protected Void .ctor(ContextQuery other) { }

	// RVA: 0xFFFFFFFF75A5FAE8
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A5FAF0
	public override XPathNavigator get_Current() { }

	// RVA: 0xFFFFFFFF75A5FAF8
	public override Object Evaluate(XPathNodeIterator context) { }

	// RVA: 0xFFFFFFFF75A5FB58
	public override XPathNavigator Advance() { }

	// RVA: 0xFFFFFFFF75A5FB78
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A5FBD0
	public override XPathResultType get_StaticType() { }

	// RVA: 0xFFFFFFFF75A5FBD8
	public override Int32 get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75A5FBE0
	public override Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75A5FBE8
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class DescendantBaseQuery
{
	// Fields
	protected Boolean matchSelf; // 0x54
	protected Boolean abbrAxis; // 0x55

	// Methods

	// RVA: 0xFFFFFFFF75A5FBF0
	public Void .ctor(Query qyParent, String Name, String Prefix, XPathNodeType Type, Boolean matchSelf, Boolean abbrAxis) { }

	// RVA: 0xFFFFFFFF75A5FC28
	public Void .ctor(DescendantBaseQuery other) { }

}

// Namespace: MS.Internal.Xml.XPath
internal class DescendantQuery
{
	// Fields
	private XPathNodeIterator nodeIterator; // 0x58

	// Methods

	// RVA: 0xFFFFFFFF75A5FF40
	internal Void .ctor(Query qyParent, String Name, String Prefix, XPathNodeType Type, Boolean matchSelf, Boolean abbrAxis) { }

	// RVA: 0xFFFFFFFF75A5FF78
	public Void .ctor(DescendantQuery other) { }

	// RVA: 0xFFFFFFFF75A5FFE0
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A6001C
	public override XPathNavigator Advance() { }

	// RVA: 0xFFFFFFFF75A60200
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class DescendantOverDescendantQuery
{
	// Fields
	private Int32 level; // 0x58

	// Methods

	// RVA: 0xFFFFFFFF75A5FC5C
	public Void .ctor(Query qyParent, Boolean matchSelf, String name, String prefix, XPathNodeType typeTest, Boolean abbrAxis) { }

	// RVA: 0xFFFFFFFF75A5FCA0
	private Void .ctor(DescendantOverDescendantQuery other) { }

	// RVA: 0xFFFFFFFF75A5FCDC
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A5FCE4
	public override XPathNavigator Advance() { }

	// RVA: 0xFFFFFFFF75A5FE1C
	private Boolean MoveToFirstChild() { }

	// RVA: 0xFFFFFFFF75A5FE64
	private Boolean MoveUpUntillNext() { }

	// RVA: 0xFFFFFFFF75A5FED0
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class DocumentOrderQuery
{
	// Methods

	// RVA: 0xFFFFFFFF75A60258
	public Void .ctor(Query qyParent) { }

	// RVA: 0xFFFFFFFF75A6025C
	private Void .ctor(DocumentOrderQuery other) { }

	// RVA: 0xFFFFFFFF75A60260
	public override Object Evaluate(XPathNodeIterator context) { }

	// RVA: 0xFFFFFFFF75A60434
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class EmptyQuery
{
	// Properties
	public override Int32 CurrentPosition { get; }
	public override Int32 Count { get; }
	public override QueryProps Properties { get; }
	public override XPathResultType StaticType { get; }
	public override XPathNavigator Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A6048C
	public override XPathNavigator Advance() { }

	// RVA: 0xFFFFFFFF75A60494
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A60498
	public override Object Evaluate(XPathNodeIterator context) { }

	// RVA: 0xFFFFFFFF75A6049C
	public override Int32 get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75A604A4
	public override Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75A604AC
	public override QueryProps get_Properties() { }

	// RVA: 0xFFFFFFFF75A604B4
	public override XPathResultType get_StaticType() { }

	// RVA: 0xFFFFFFFF75A604BC
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A604C0
	public override XPathNavigator get_Current() { }

	// RVA: 0xFFFFFFFF75A604C8
	public Void .ctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class ExtensionQuery
{
	// Fields
	protected String prefix; // 0x18
	protected String name; // 0x20
	protected XsltContext xsltContext; // 0x28
	private ResetableIterator queryIterator; // 0x30

	// Properties
	public override XPathNavigator Current { get; }
	public override Int32 CurrentPosition { get; }
	protected String QName { get; }
	public override Int32 Count { get; }
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A604F4
	public Void .ctor(String prefix, String name) { }

	// RVA: 0xFFFFFFFF75A6056C
	protected Void .ctor(ExtensionQuery other) { }

	// RVA: 0xFFFFFFFF75A606A0
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A606BC
	public override XPathNavigator get_Current() { }

	// RVA: 0xFFFFFFFF75A60760
	public override XPathNavigator Advance() { }

	// RVA: 0xFFFFFFFF75A60800
	public override Int32 get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75A6081C
	protected Object ProcessResult(Object value) { }

	// RVA: 0xFFFFFFFF75A60D5C
	protected String get_QName() { }

	// RVA: 0xFFFFFFFF75A60DA0
	public override Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75A60DC0
	public override XPathResultType get_StaticType() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Filter
{
	// Fields
	private AstNode input; // 0x10
	private AstNode condition; // 0x18

	// Properties
	public override AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public AstNode Input { get; }
	public AstNode Condition { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A60DC8
	public Void .ctor(AstNode input, AstNode condition) { }

	// RVA: 0xFFFFFFFF75A60E2C
	public override AstType get_Type() { }

	// RVA: 0xFFFFFFFF75A60E34
	public override XPathResultType get_ReturnType() { }

	// RVA: 0xFFFFFFFF75A60E3C
	public AstNode get_Input() { }

	// RVA: 0xFFFFFFFF75A60E44
	public AstNode get_Condition() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FilterQuery
{
	// Fields
	private Query cond; // 0x58
	private Boolean noPosition; // 0x60

	// Properties
	public Query Condition { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A60E4C
	public Void .ctor(Query qyParent, Query cond, Boolean noPosition) { }

	// RVA: 0xFFFFFFFF75A60E9C
	private Void .ctor(FilterQuery other) { }

	// RVA: 0xFFFFFFFF75A60EFC
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A60F38
	public Query get_Condition() { }

	// RVA: 0xFFFFFFFF75A60F40
	public override Void SetXsltContext(XsltContext input) { }

	// RVA: 0xFFFFFFFF75A61030
	public override XPathNavigator Advance() { }

	// RVA: 0xFFFFFFFF75A610B8
	internal Boolean EvaluatePredicate() { }

	// RVA: 0xFFFFFFFF75A6121C
	public override QueryProps get_Properties() { }

	// RVA: 0xFFFFFFFF75A61250
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FollowingQuery
{
	// Fields
	private XPathNavigator input; // 0x58
	private XPathNodeIterator iterator; // 0x60

	// Methods

	// RVA: 0xFFFFFFFF75A61934
	public Void .ctor(Query qyInput, String name, String prefix, XPathNodeType typeTest) { }

	// RVA: 0xFFFFFFFF75A61938
	private Void .ctor(FollowingQuery other) { }

	// RVA: 0xFFFFFFFF75A619D8
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A61A14
	public override XPathNavigator Advance() { }

	// RVA: 0xFFFFFFFF75A61CA0
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FollSiblingQuery
{
	// Fields
	private ClonableStack<T0> elementStk; // 0x58
	private List<T0> parentStk; // 0x60
	private XPathNavigator nextInput; // 0x68

	// Methods

	// RVA: 0xFFFFFFFF75A612A8
	public Void .ctor(Query qyInput, String name, String prefix, XPathNodeType type) { }

	// RVA: 0xFFFFFFFF75A613B8
	private Void .ctor(FollSiblingQuery other) { }

	// RVA: 0xFFFFFFFF75A614D4
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A61558
	private Boolean Visited(XPathNavigator nav) { }

	// RVA: 0xFFFFFFFF75A6164C
	private XPathNavigator FetchInput() { }

	// RVA: 0xFFFFFFFF75A616B8
	public override XPathNavigator Advance() { }

	// RVA: 0xFFFFFFFF75A618DC
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class ForwardPositionQuery
{
	// Methods

	// RVA: 0xFFFFFFFF75A61CF8
	public Void .ctor(Query input) { }

	// RVA: 0xFFFFFFFF75A61CFC
	protected Void .ctor(ForwardPositionQuery other) { }

	// RVA: 0xFFFFFFFF75A61D00
	public override Object Evaluate(XPathNodeIterator context) { }

	// RVA: 0xFFFFFFFF75A61DAC
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Function
{
	// Fields
	private FunctionType functionType; // 0x10
	private ArrayList argumentList; // 0x18
	private String name; // 0x20
	private String prefix; // 0x28
	internal static XPathResultType[] ReturnTypes; // 0x0

	// Properties
	public override AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public FunctionType TypeOfFunction { get; }
	public ArrayList ArgumentList { get; }
	public String Prefix { get; }
	public String Name { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A61E04
	public Void .ctor(FunctionType ftype, ArrayList argumentList) { }

	// RVA: 0xFFFFFFFF75A61E6C
	public Void .ctor(String prefix, String name, ArrayList argumentList) { }

	// RVA: 0xFFFFFFFF75A61F14
	public Void .ctor(FunctionType ftype, AstNode arg) { }

	// RVA: 0xFFFFFFFF75A61F8C
	public override AstType get_Type() { }

	// RVA: 0xFFFFFFFF75A61F94
	public override XPathResultType get_ReturnType() { }

	// RVA: 0xFFFFFFFF75A62024
	public FunctionType get_TypeOfFunction() { }

	// RVA: 0xFFFFFFFF75A6202C
	public ArrayList get_ArgumentList() { }

	// RVA: 0xFFFFFFFF75A62034
	public String get_Prefix() { }

	// RVA: 0xFFFFFFFF75A6203C
	public String get_Name() { }

	// RVA: 0xFFFFFFFF75A62044
	private static Void .cctor() { }

}

// Namespace: 
public enum FunctionType
{
	// Fields
	public Int32 value__; // 0x10
	public const FunctionType FuncLast = 0;
	public const FunctionType FuncPosition = 1;
	public const FunctionType FuncCount = 2;
	public const FunctionType FuncID = 3;
	public const FunctionType FuncLocalName = 4;
	public const FunctionType FuncNameSpaceUri = 5;
	public const FunctionType FuncName = 6;
	public const FunctionType FuncString = 7;
	public const FunctionType FuncBoolean = 8;
	public const FunctionType FuncNumber = 9;
	public const FunctionType FuncTrue = 10;
	public const FunctionType FuncFalse = 11;
	public const FunctionType FuncNot = 12;
	public const FunctionType FuncConcat = 13;
	public const FunctionType FuncStartsWith = 14;
	public const FunctionType FuncContains = 15;
	public const FunctionType FuncSubstringBefore = 16;
	public const FunctionType FuncSubstringAfter = 17;
	public const FunctionType FuncSubstring = 18;
	public const FunctionType FuncStringLength = 19;
	public const FunctionType FuncNormalize = 20;
	public const FunctionType FuncTranslate = 21;
	public const FunctionType FuncLang = 22;
	public const FunctionType FuncSum = 23;
	public const FunctionType FuncFloor = 24;
	public const FunctionType FuncCeiling = 25;
	public const FunctionType FuncRound = 26;
	public const FunctionType FuncUserDefined = 27;
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FunctionQuery
{
	// Fields
	private IList<T0> args; // 0x38
	private IXsltContextFunction function; // 0x40

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A620E0
	public Void .ctor(String prefix, String name, List<T0> args) { }

	// RVA: 0xFFFFFFFF75A62184
	private Void .ctor(FunctionQuery other) { }

	// RVA: 0xFFFFFFFF75A623A0
	public override Void SetXsltContext(XsltContext context) { }

	// RVA: 0xFFFFFFFF75A62880
	public override Object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A62E04
	public override XPathResultType get_StaticType() { }

	// RVA: 0xFFFFFFFF75A62EBC
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Group
{
	// Fields
	private AstNode groupNode; // 0x10

	// Properties
	public override AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public AstNode GroupNode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A62F14
	public Void .ctor(AstNode groupNode) { }

	// RVA: 0xFFFFFFFF75A62F4C
	public override AstType get_Type() { }

	// RVA: 0xFFFFFFFF75A62F54
	public override XPathResultType get_ReturnType() { }

	// RVA: 0xFFFFFFFF75A62F5C
	public AstNode get_GroupNode() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class GroupQuery
{
	// Properties
	public override XPathResultType StaticType { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A62F64
	public Void .ctor(Query qy) { }

	// RVA: 0xFFFFFFFF75A62F68
	private Void .ctor(GroupQuery other) { }

	// RVA: 0xFFFFFFFF75A62F6C
	public override XPathNavigator Advance() { }

	// RVA: 0xFFFFFFFF75A62FD4
	public override Object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A62FFC
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A63054
	public override XPathResultType get_StaticType() { }

	// RVA: 0xFFFFFFFF75A6307C
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class IDQuery
{
	// Methods

	// RVA: 0xFFFFFFFF75A63084
	public Void .ctor(Query arg) { }

	// RVA: 0xFFFFFFFF75A63088
	private Void .ctor(IDQuery other) { }

	// RVA: 0xFFFFFFFF75A6308C
	public override Object Evaluate(XPathNodeIterator context) { }

	// RVA: 0xFFFFFFFF75A633C0
	private Void ProcessIds(XPathNavigator contextNode, String val) { }

	// RVA: 0xFFFFFFFF75A634DC
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class IteratorFilter
{
	// Fields
	private XPathNodeIterator innerIterator; // 0x18
	private String name; // 0x20
	private Int32 position; // 0x28

	// Properties
	public override XPathNavigator Current { get; }
	public override Int32 CurrentPosition { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A5F5D0
	internal Void .ctor(XPathNodeIterator innerIterator, String name) { }

	// RVA: 0xFFFFFFFF75A63534
	private Void .ctor(IteratorFilter it) { }

	// RVA: 0xFFFFFFFF75A635C8
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A63620
	public override XPathNavigator get_Current() { }

	// RVA: 0xFFFFFFFF75A63648
	public override Int32 get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75A63650
	public override Boolean MoveNext() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class LogicalExpr
{
	// Fields
	private Op op; // 0x14
	private Query opnd1; // 0x18
	private Query opnd2; // 0x20
	private static readonly cmpXslt[][] CompXsltE; // 0x0
	private static readonly cmpXslt[][] CompXsltO; // 0x8

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A636DC
	public Void .ctor(Op op, Query opnd1, Query opnd2) { }

	// RVA: 0xFFFFFFFF75A63764
	private Void .ctor(LogicalExpr other) { }

	// RVA: 0xFFFFFFFF75A637F0
	public override Void SetXsltContext(XsltContext context) { }

	// RVA: 0xFFFFFFFF75A63844
	public override Object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A63D8C
	private static Boolean cmpQueryQueryE(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A63FF0
	private static Boolean cmpQueryQueryO(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A64240
	private static Boolean cmpQueryNumber(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A643AC
	private static Boolean cmpQueryStringE(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A644E0
	private static Boolean cmpQueryStringO(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A6468C
	private static Boolean cmpRtfQueryE(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A647F0
	private static Boolean cmpRtfQueryO(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A64920
	private static Boolean cmpQueryBoolE(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A64A10
	private static Boolean cmpQueryBoolO(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A649FC
	private static Boolean cmpBoolBoolE(Op op, Boolean n1, Boolean n2) { }

	// RVA: 0xFFFFFFFF75A64B60
	private static Boolean cmpBoolBoolE(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A64C4C
	private static Boolean cmpBoolBoolO(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A64D90
	private static Boolean cmpBoolNumberE(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A64E80
	private static Boolean cmpBoolNumberO(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A64FB8
	private static Boolean cmpBoolStringE(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A65098
	private static Boolean cmpRtfBoolE(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A65168
	private static Boolean cmpBoolStringO(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A652A0
	private static Boolean cmpRtfBoolO(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A641CC
	private static Boolean cmpNumberNumber(Op op, Double n1, Double n2) { }

	// RVA: 0xFFFFFFFF75A64630
	private static Boolean cmpNumberNumberO(Op op, Double n1, Double n2) { }

	// RVA: 0xFFFFFFFF75A653C0
	private static Boolean cmpNumberNumber(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A65504
	private static Boolean cmpStringNumber(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A65644
	private static Boolean cmpRtfNumber(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A644A8
	private static Boolean cmpStringStringE(Op op, String n1, String n2) { }

	// RVA: 0xFFFFFFFF75A65764
	private static Boolean cmpStringStringE(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A65820
	private static Boolean cmpRtfStringE(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A658C8
	private static Boolean cmpRtfRtfE(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A65960
	private static Boolean cmpStringStringO(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A65A7C
	private static Boolean cmpRtfStringO(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A65B7C
	private static Boolean cmpRtfRtfO(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A65C60
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A64768
	private static String Rtf(Object o) { }

	// RVA: 0xFFFFFFFF75A65CB8
	public override XPathResultType get_StaticType() { }

	// RVA: 0xFFFFFFFF75A65CC0
	private static Void .cctor() { }

}

// Namespace: 
private sealed class cmpXslt
{
	// Methods

	// RVA: 0xFFFFFFFF75A66AF8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75A63AEC
	public virtual Boolean Invoke(Op op, Object val1, Object val2) { }

	// RVA: 0xFFFFFFFF75A66B3C
	public virtual IAsyncResult BeginInvoke(Op op, Object val1, Object val2, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75A66C00
	public virtual Boolean EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private struct NodeSet
{
	// Fields
	private Query opnd; // 0x10
	private XPathNavigator current; // 0x18

	// Properties
	public String Value { get; }

	// Methods

	// RVA: 0xFFFFFFFF711450EC
	public Void .ctor(Object opnd) { }

	// RVA: 0xFFFFFFFF711450F4
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF711450FC
	public Void Reset() { }

	// RVA: 0xFFFFFFFF71145124
	public String get_Value() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class MergeFilterQuery
{
	// Fields
	private Query child; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75A66C2C
	public Void .ctor(Query input, Query child) { }

	// RVA: 0xFFFFFFFF75A66C6C
	private Void .ctor(MergeFilterQuery other) { }

	// RVA: 0xFFFFFFFF75A66CBC
	public override Void SetXsltContext(XsltContext xsltContext) { }

	// RVA: 0xFFFFFFFF75A66D10
	public override Object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A66D98
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NamespaceQuery
{
	// Fields
	private Boolean onNamespace; // 0x54

	// Methods

	// RVA: 0xFFFFFFFF75A66DF0
	public Void .ctor(Query qyParent, String Name, String Prefix, XPathNodeType Type) { }

	// RVA: 0xFFFFFFFF75A66DF4
	private Void .ctor(NamespaceQuery other) { }

	// RVA: 0xFFFFFFFF75A66E28
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A66E30
	public override XPathNavigator Advance() { }

	// RVA: 0xFFFFFFFF75A66F1C
	public override Boolean matches(XPathNavigator e) { }

	// RVA: 0xFFFFFFFF75A66FAC
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NodeFunctions
{
	// Fields
	private Query arg; // 0x18
	private FunctionType funcType; // 0x20
	private XsltContext xsltContext; // 0x28

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A67014
	public Void .ctor(FunctionType funcType, Query arg) { }

	// RVA: 0xFFFFFFFF75A67074
	public override Void SetXsltContext(XsltContext context) { }

	// RVA: 0xFFFFFFFF75A67108
	private XPathNavigator EvaluateArg(XPathNodeIterator context) { }

	// RVA: 0xFFFFFFFF75A6716C
	public override Object Evaluate(XPathNodeIterator context) { }

	// RVA: 0xFFFFFFFF75A6731C
	public override XPathResultType get_StaticType() { }

	// RVA: 0xFFFFFFFF75A673AC
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NumberFunctions
{
	// Fields
	private Query arg; // 0x18
	private FunctionType ftype; // 0x20

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A67464
	public Void .ctor(FunctionType ftype, Query arg) { }

	// RVA: 0xFFFFFFFF75A674C0
	private Void .ctor(NumberFunctions other) { }

	// RVA: 0xFFFFFFFF75A6752C
	public override Void SetXsltContext(XsltContext context) { }

	// RVA: 0xFFFFFFFF75A64B4C
	internal static Double Number(Boolean arg) { }

	// RVA: 0xFFFFFFFF75A6418C
	internal static Double Number(String arg) { }

	// RVA: 0xFFFFFFFF75A67548
	public override Object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A675D0
	private Double Number(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A677E8
	private Double Sum(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A67878
	private Double Floor(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A67900
	private Double Ceiling(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A67988
	private Double Round(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A679EC
	public override XPathResultType get_StaticType() { }

	// RVA: 0xFFFFFFFF75A679F4
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NumericExpr
{
	// Fields
	private Op op; // 0x14
	private Query opnd1; // 0x18
	private Query opnd2; // 0x20

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A67A4C
	public Void .ctor(Op op, Query opnd1, Query opnd2) { }

	// RVA: 0xFFFFFFFF75A67BD8
	private Void .ctor(NumericExpr other) { }

	// RVA: 0xFFFFFFFF75A67C64
	public override Void SetXsltContext(XsltContext context) { }

	// RVA: 0xFFFFFFFF75A67CB8
	public override Object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A67DD0
	private static Double GetValue(Op op, Double n1, Double n2) { }

	// RVA: 0xFFFFFFFF75A67E30
	public override XPathResultType get_StaticType() { }

	// RVA: 0xFFFFFFFF75A67E38
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Operand
{
	// Fields
	private XPathResultType type; // 0x10
	private Object val; // 0x18

	// Properties
	public override AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public Object OperandValue { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A67E90
	public Void .ctor(String val) { }

	// RVA: 0xFFFFFFFF75A67ED0
	public Void .ctor(Double val) { }

	// RVA: 0xFFFFFFFF75A67F24
	public override AstType get_Type() { }

	// RVA: 0xFFFFFFFF75A67F2C
	public override XPathResultType get_ReturnType() { }

	// RVA: 0xFFFFFFFF75A67F34
	public Object get_OperandValue() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class OperandQuery
{
	// Fields
	internal Object val; // 0x18

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A67F3C
	public Void .ctor(Object val) { }

	// RVA: 0xFFFFFFFF75A67F88
	public override Object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A67F90
	public override XPathResultType get_StaticType() { }

	// RVA: 0xFFFFFFFF75A67F98
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Operator
{
	// Fields
	private static Op[] invertOp; // 0x0
	private Op opType; // 0x10
	private AstNode opnd1; // 0x18
	private AstNode opnd2; // 0x20

	// Properties
	public override AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public Op OperatorType { get; }
	public AstNode Operand1 { get; }
	public AstNode Operand2 { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A63A60
	public static Op InvertOperator(Op op) { }

	// RVA: 0xFFFFFFFF75A67F9C
	public Void .ctor(Op op, AstNode opnd1, AstNode opnd2) { }

	// RVA: 0xFFFFFFFF75A68004
	public override AstType get_Type() { }

	// RVA: 0xFFFFFFFF75A6800C
	public override XPathResultType get_ReturnType() { }

	// RVA: 0xFFFFFFFF75A6802C
	public Op get_OperatorType() { }

	// RVA: 0xFFFFFFFF75A68034
	public AstNode get_Operand1() { }

	// RVA: 0xFFFFFFFF75A6803C
	public AstNode get_Operand2() { }

	// RVA: 0xFFFFFFFF75A68044
	private static Void .cctor() { }

}

// Namespace: 
public enum Op
{
	// Fields
	public Int32 value__; // 0x10
	public const Op INVALID = 0;
	public const Op OR = 1;
	public const Op AND = 2;
	public const Op EQ = 3;
	public const Op NE = 4;
	public const Op LT = 5;
	public const Op LE = 6;
	public const Op GT = 7;
	public const Op GE = 8;
	public const Op PLUS = 9;
	public const Op MINUS = 10;
	public const Op MUL = 11;
	public const Op DIV = 12;
	public const Op MOD = 13;
	public const Op UNION = 14;
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class ParentQuery
{
	// Methods

	// RVA: 0xFFFFFFFF75A680E0
	public Void .ctor(Query qyInput, String Name, String Prefix, XPathNodeType Type) { }

	// RVA: 0xFFFFFFFF75A680E4
	private Void .ctor(ParentQuery other) { }

	// RVA: 0xFFFFFFFF75A680E8
	public override Object Evaluate(XPathNodeIterator context) { }

	// RVA: 0xFFFFFFFF75A68190
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class PrecedingQuery
{
	// Fields
	private XPathNodeIterator workIterator; // 0x58
	private ClonableStack<T0> ancestorStk; // 0x60

	// Properties
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A685BC
	public Void .ctor(Query qyInput, String name, String prefix, XPathNodeType typeTest) { }

	// RVA: 0xFFFFFFFF75A6867C
	private Void .ctor(PrecedingQuery other) { }

	// RVA: 0xFFFFFFFF75A68740
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A687B4
	public override XPathNavigator Advance() { }

	// RVA: 0xFFFFFFFF75A68A70
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A68AC8
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class PreSiblingQuery
{
	// Properties
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A681E8
	public Void .ctor(Query qyInput, String name, String prefix, XPathNodeType typeTest) { }

	// RVA: 0xFFFFFFFF75A681EC
	protected Void .ctor(PreSiblingQuery other) { }

	// RVA: 0xFFFFFFFF75A681F0
	private Boolean NotVisited(XPathNavigator nav, List<T0> parentStk) { }

	// RVA: 0xFFFFFFFF75A682EC
	public override Object Evaluate(XPathNodeIterator context) { }

	// RVA: 0xFFFFFFFF75A6855C
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A685B4
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal enum QueryProps
{
	// Fields
	public Int32 value__; // 0x10
	public const QueryProps None = 0;
	public const QueryProps Position = 1;
	public const QueryProps Count = 2;
	public const QueryProps Cached = 4;
	public const QueryProps Reverse = 8;
	public const QueryProps Merge = 16;
}

// Namespace: MS.Internal.Xml.XPath
internal abstract class Query
{
	// Properties
	public override Int32 Count { get; }
	public abstract XPathResultType StaticType { get; }
	public virtual QueryProps Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A5D780
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A5D7AC
	protected Void .ctor(Query other) { }

	// RVA: 0xFFFFFFFF75A68B3C
	public override Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75A68B64
	public override Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75A68C5C
	public virtual Void SetXsltContext(XsltContext context) { }

	// RVA: -1
	public abstract Object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: -1
	public abstract XPathNavigator Advance() { }

	// RVA: -1
	public abstract XPathResultType get_StaticType() { }

	// RVA: 0xFFFFFFFF75A68AD0
	public virtual QueryProps get_Properties() { }

	// RVA: 0xFFFFFFFF75A5D7E4
	public static Query Clone(Query input) { }

	// RVA: 0xFFFFFFFF75A5F410
	protected static XPathNodeIterator Clone(XPathNodeIterator input) { }

	// RVA: 0xFFFFFFFF75A5EA9C
	protected static XPathNavigator Clone(XPathNavigator input) { }

	// RVA: 0xFFFFFFFF75A602B4
	public Boolean Insert(List<T0> buffer, XPathNavigator nav) { }

	// RVA: 0xFFFFFFFF75A68C60
	private static Int32 GetMedian(Int32 l, Int32 r) { }

	// RVA: 0xFFFFFFFF75A5EEE0
	public static XmlNodeOrder CompareNodes(XPathNavigator l, XPathNavigator r) { }

	// RVA: 0xFFFFFFFF75A632F8
	protected XPathResultType GetXPathType(Object value) { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class QueryBuilder
{
	// Fields
	private String query; // 0x10
	private Boolean allowVar; // 0x18
	private Boolean allowKey; // 0x19
	private Boolean allowCurrent; // 0x1A
	private Boolean needContext; // 0x1B
	private BaseAxisQuery firstInput; // 0x20
	private Int32 parseDepth; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75A68C6C
	private Void Reset() { }

	// RVA: 0xFFFFFFFF75A68C78
	private Query ProcessAxis(Axis root, Flags flags, out Props props) { }

	// RVA: 0xFFFFFFFF75A69700
	private Boolean CanBeNumber(Query q) { }

	// RVA: 0xFFFFFFFF75A69764
	private Query ProcessFilter(Filter root, Flags flags, out Props props) { }

	// RVA: 0xFFFFFFFF75A69CBC
	private Query ProcessOperator(Operator root, out Props props) { }

	// RVA: 0xFFFFFFFF75A69F40
	private Query ProcessVariable(Variable root) { }

	// RVA: 0xFFFFFFFF75A6A0B0
	private Query ProcessFunction(Function root, out Props props) { }

	// RVA: 0xFFFFFFFF75A6A798
	private List<T0> ProcessArguments(ArrayList args, out Props props) { }

	// RVA: 0xFFFFFFFF75A69318
	private Query ProcessNode(AstNode root, Flags flags, out Props props) { }

	// RVA: 0xFFFFFFFF75A6A97C
	private Query Build(AstNode root, String query) { }

	// RVA: 0xFFFFFFFF75A6A9E8
	internal Query Build(String query, Boolean allowVar, Boolean allowKey) { }

	// RVA: 0xFFFFFFFF75A6ABA0
	internal Query Build(String query, out Boolean needContext) { }

	// RVA: 0xFFFFFFFF75A6ABD4
	public Void .ctor() { }

}

// Namespace: 
private enum Flags
{
	// Fields
	public Int32 value__; // 0x10
	public const Flags None = 0;
	public const Flags SmartDesc = 1;
	public const Flags PosFilter = 2;
	public const Flags Filter = 4;
}

// Namespace: 
private enum Props
{
	// Fields
	public Int32 value__; // 0x10
	public const Props None = 0;
	public const Props PosFilter = 1;
	public const Props HasPosition = 2;
	public const Props HasLast = 4;
	public const Props NonFlat = 8;
}

// Namespace: MS.Internal.Xml.XPath
internal abstract class ResetableIterator
{
	// Properties
	public abstract override Int32 CurrentPosition { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A68AD8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A68B04
	protected Void .ctor(ResetableIterator other) { }

	// RVA: 0xFFFFFFFF75A5DAA0
	protected Void ResetCount() { }

	// RVA: -1
	public abstract Void Reset() { }

	// RVA: -1
	public abstract override Int32 get_CurrentPosition() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class ReversePositionQuery
{
	// Properties
	public override Int32 CurrentPosition { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A69CB8
	public Void .ctor(Query input) { }

	// RVA: 0xFFFFFFFF75A6ABD8
	private Void .ctor(ReversePositionQuery other) { }

	// RVA: 0xFFFFFFFF75A6ABDC
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A6AC34
	public override Int32 get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75A6AC8C
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Root
{
	// Properties
	public override AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A6AC94
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A6AC98
	public override AstType get_Type() { }

	// RVA: 0xFFFFFFFF75A6ACA0
	public override XPathResultType get_ReturnType() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class StringFunctions
{
	// Fields
	private FunctionType funcType; // 0x14
	private IList<T0> argList; // 0x18
	private static readonly CompareInfo compareInfo; // 0x0

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A6A920
	public Void .ctor(FunctionType funcType, IList<T0> argList) { }

	// RVA: 0xFFFFFFFF75A6ACA8
	private Void .ctor(StringFunctions other) { }

	// RVA: 0xFFFFFFFF75A6AE94
	public override Void SetXsltContext(XsltContext context) { }

	// RVA: 0xFFFFFFFF75A6AFFC
	public override Object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A63480
	internal static String toString(Double num) { }

	// RVA: 0xFFFFFFFF75A634BC
	internal static String toString(Boolean b) { }

	// RVA: 0xFFFFFFFF75A6B0EC
	private String toString(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A6C8B4
	public override XPathResultType get_StaticType() { }

	// RVA: 0xFFFFFFFF75A6B474
	private String Concat(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A6B630
	private Boolean StartsWith(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A6B7E8
	private Boolean Contains(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A6B9C0
	private String SubstringBefore(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A6BBDC
	private String SubstringAfter(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A6BDF4
	private String Substring(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A6C1C8
	private Double StringLength(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A6C358
	private String Normalize(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A6C5E0
	private String Translate(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A6C8DC
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A6C934
	private static Void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class UnionExpr
{
	// Fields
	internal Query qy1; // 0x18
	internal Query qy2; // 0x20
	private Boolean advance1; // 0x28
	private Boolean advance2; // 0x29
	private XPathNavigator currentNode; // 0x30
	private XPathNavigator nextNode; // 0x38

	// Properties
	public override XPathResultType StaticType { get; }
	public override XPathNavigator Current { get; }
	public override Int32 CurrentPosition { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A69EC4
	public Void .ctor(Query query1, Query query2) { }

	// RVA: 0xFFFFFFFF75A6C9D0
	private Void .ctor(UnionExpr other) { }

	// RVA: 0xFFFFFFFF75A6CACC
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A6CB40
	public override Void SetXsltContext(XsltContext xsltContext) { }

	// RVA: 0xFFFFFFFF75A6CB94
	public override Object Evaluate(XPathNodeIterator context) { }

	// RVA: 0xFFFFFFFF75A6CC1C
	private XPathNavigator ProcessSamePosition(XPathNavigator result) { }

	// RVA: 0xFFFFFFFF75A6CC6C
	private XPathNavigator ProcessBeforePosition(XPathNavigator res1, XPathNavigator res2) { }

	// RVA: 0xFFFFFFFF75A6CCD4
	private XPathNavigator ProcessAfterPosition(XPathNavigator res1, XPathNavigator res2) { }

	// RVA: 0xFFFFFFFF75A6CD3C
	public override XPathNavigator Advance() { }

	// RVA: 0xFFFFFFFF75A6CF04
	public override XPathResultType get_StaticType() { }

	// RVA: 0xFFFFFFFF75A6CF0C
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A6CF64
	public override XPathNavigator get_Current() { }

	// RVA: 0xFFFFFFFF75A6CF6C
	public override Int32 get_CurrentPosition() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class ValueQuery
{
	// Properties
	public sealed override XPathNavigator Current { get; }
	public sealed override Int32 CurrentPosition { get; }
	public sealed override Int32 Count { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A5DC40
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A5DD58
	protected Void .ctor(ValueQuery other) { }

	// RVA: 0xFFFFFFFF75A6CFC0
	public sealed override Void Reset() { }

	// RVA: 0xFFFFFFFF75A6CFC4
	public sealed override XPathNavigator get_Current() { }

	// RVA: 0xFFFFFFFF75A6D018
	public sealed override Int32 get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75A6D06C
	public sealed override Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75A6D0C0
	public sealed override XPathNavigator Advance() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Variable
{
	// Fields
	private String localname; // 0x10
	private String prefix; // 0x18

	// Properties
	public override AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public String Localname { get; }
	public String Prefix { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A6D114
	public Void .ctor(String name, String prefix) { }

	// RVA: 0xFFFFFFFF75A6D178
	public override AstType get_Type() { }

	// RVA: 0xFFFFFFFF75A6D180
	public override XPathResultType get_ReturnType() { }

	// RVA: 0xFFFFFFFF75A6D188
	public String get_Localname() { }

	// RVA: 0xFFFFFFFF75A6D190
	public String get_Prefix() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class VariableQuery
{
	// Fields
	private IXsltContextVariable variable; // 0x38

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A6A038
	public Void .ctor(String name, String prefix) { }

	// RVA: 0xFFFFFFFF75A6D198
	private Void .ctor(VariableQuery other) { }

	// RVA: 0xFFFFFFFF75A6D1E4
	public override Void SetXsltContext(XsltContext context) { }

	// RVA: 0xFFFFFFFF75A6D2F0
	public override Object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A6D3F0
	public override XPathResultType get_StaticType() { }

	// RVA: 0xFFFFFFFF75A6D460
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathAncestorQuery
{
	// Fields
	private Boolean matchSelf; // 0x60

	// Properties
	public override Int32 CurrentPosition { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A696D4
	public Void .ctor(Query qyInput, String name, String prefix, XPathNodeType typeTest, Boolean matchSelf) { }

	// RVA: 0xFFFFFFFF75A6D4B8
	private Void .ctor(XPathAncestorQuery other) { }

	// RVA: 0xFFFFFFFF75A6D4EC
	public override Object Evaluate(XPathNodeIterator context) { }

	// RVA: 0xFFFFFFFF75A6D614
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A6D67C
	public override Int32 get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75A6D6D4
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathArrayIterator
{
	// Fields
	protected IList list; // 0x18
	protected Int32 index; // 0x20

	// Properties
	public override XPathNavigator Current { get; }
	public override Int32 CurrentPosition { get; }
	public override Int32 Count { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A6D6DC
	public Void .ctor(XPathArrayIterator it) { }

	// RVA: 0xFFFFFFFF75A60C14
	public Void .ctor(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75A6D744
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A6D79C
	public override XPathNavigator get_Current() { }

	// RVA: 0xFFFFFFFF75A6D90C
	public override Int32 get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75A6D914
	public override Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75A6D998
	public override Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75A6DA4C
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A6DA54
	public override IEnumerator GetEnumerator() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class XPathAxisIterator
{
	// Fields
	internal XPathNavigator nav; // 0x18
	internal XPathNodeType type; // 0x20
	internal String name; // 0x28
	internal String uri; // 0x30
	internal Int32 position; // 0x38
	internal Boolean matchSelf; // 0x3C
	internal Boolean first; // 0x3D

	// Properties
	public override XPathNavigator Current { get; }
	public override Int32 CurrentPosition { get; }
	protected virtual Boolean Matches { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A6DAD4
	public Void .ctor(XPathNavigator nav, Boolean matchSelf) { }

	// RVA: 0xFFFFFFFF75A6DB30
	public Void .ctor(XPathNavigator nav, XPathNodeType type, Boolean matchSelf) { }

	// RVA: 0xFFFFFFFF75A6DB9C
	public Void .ctor(XPathNavigator nav, String name, String namespaceURI, Boolean matchSelf) { }

	// RVA: 0xFFFFFFFF75A6DCCC
	public Void .ctor(XPathAxisIterator it) { }

	// RVA: 0xFFFFFFFF75A6DD98
	public override XPathNavigator get_Current() { }

	// RVA: 0xFFFFFFFF75A6DDA0
	public override Int32 get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75A6DDA8
	protected virtual Boolean get_Matches() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathChildIterator
{
	// Methods

	// RVA: 0xFFFFFFFF75A6DED8
	public Void .ctor(XPathNavigator nav, XPathNodeType type) { }

	// RVA: 0xFFFFFFFF75A6DF38
	public Void .ctor(XPathNavigator nav, String name, String namespaceURI) { }

	// RVA: 0xFFFFFFFF75A6DF40
	public Void .ctor(XPathChildIterator it) { }

	// RVA: 0xFFFFFFFF75A6DF44
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A6DF9C
	public override Boolean MoveNext() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathDescendantIterator
{
	// Fields
	private Int32 level; // 0x40

	// Methods

	// RVA: 0xFFFFFFFF75A6E034
	public Void .ctor(XPathNavigator nav, XPathNodeType type, Boolean matchSelf) { }

	// RVA: 0xFFFFFFFF75A6E0A0
	public Void .ctor(XPathNavigator nav, String name, String namespaceURI, Boolean matchSelf) { }

	// RVA: 0xFFFFFFFF75A6E0A4
	public Void .ctor(XPathDescendantIterator it) { }

	// RVA: 0xFFFFFFFF75A6E0D8
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A6E140
	public override Boolean MoveNext() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathEmptyIterator
{
	// Fields
	public static XPathEmptyIterator Instance; // 0x0

	// Properties
	public override XPathNavigator Current { get; }
	public override Int32 CurrentPosition { get; }
	public override Int32 Count { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A6E234
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF75A6E260
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A6E264
	public override XPathNavigator get_Current() { }

	// RVA: 0xFFFFFFFF75A6E26C
	public override Int32 get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75A6E274
	public override Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75A6E27C
	public override Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75A6E284
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A6E288
	private static Void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathParser
{
	// Fields
	private XPathScanner scanner; // 0x10
	private Int32 parseDepth; // 0x18
	private static readonly XPathResultType[] temparray1; // 0x0
	private static readonly XPathResultType[] temparray2; // 0x8
	private static readonly XPathResultType[] temparray3; // 0x10
	private static readonly XPathResultType[] temparray4; // 0x18
	private static readonly XPathResultType[] temparray5; // 0x20
	private static readonly XPathResultType[] temparray6; // 0x28
	private static readonly XPathResultType[] temparray7; // 0x30
	private static readonly XPathResultType[] temparray8; // 0x38
	private static readonly XPathResultType[] temparray9; // 0x40
	private static Hashtable functionTable; // 0x48
	private static Hashtable AxesTable; // 0x50

	// Methods

	// RVA: 0xFFFFFFFF75A6E304
	private Void .ctor(XPathScanner scanner) { }

	// RVA: 0xFFFFFFFF75A6AABC
	public static AstNode ParseXPathExpresion(String xpathExpresion) { }

	// RVA: 0xFFFFFFFF75A6E414
	private AstNode ParseExpresion(AstNode qyInput) { }

	// RVA: 0xFFFFFFFF75A6E4B0
	private AstNode ParseOrExpr(AstNode qyInput) { }

	// RVA: 0xFFFFFFFF75A6E5C4
	private AstNode ParseAndExpr(AstNode qyInput) { }

	// RVA: 0xFFFFFFFF75A6E744
	private AstNode ParseEqualityExpr(AstNode qyInput) { }

	// RVA: 0xFFFFFFFF75A6E848
	private AstNode ParseRelationalExpr(AstNode qyInput) { }

	// RVA: 0xFFFFFFFF75A6E974
	private AstNode ParseAdditiveExpr(AstNode qyInput) { }

	// RVA: 0xFFFFFFFF75A6EA78
	private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	// RVA: 0xFFFFFFFF75A6EBD0
	private AstNode ParseUnaryExpr(AstNode qyInput) { }

	// RVA: 0xFFFFFFFF75A6ED0C
	private AstNode ParseUnionExpr(AstNode qyInput) { }

	// RVA: 0xFFFFFFFF75A6F008
	private static Boolean IsNodeType(XPathScanner scaner) { }

	// RVA: 0xFFFFFFFF75A6EE44
	private AstNode ParsePathExpr(AstNode qyInput) { }

	// RVA: 0xFFFFFFFF75A6F190
	private AstNode ParseFilterExpr(AstNode qyInput) { }

	// RVA: 0xFFFFFFFF75A6F714
	private AstNode ParsePredicate(AstNode qyInput) { }

	// RVA: 0xFFFFFFFF75A6F358
	private AstNode ParseLocationPath(AstNode qyInput) { }

	// RVA: 0xFFFFFFFF75A6F270
	private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	// RVA: 0xFFFFFFFF75A6F7B4
	private static Boolean IsStep(LexKind lexKind) { }

	// RVA: 0xFFFFFFFF75A6F7F4
	private AstNode ParseStep(AstNode qyInput) { }

	// RVA: 0xFFFFFFFF75A6FAE4
	private AstNode ParseNodeTest(AstNode qyInput, AxisType axisType, XPathNodeType nodeType) { }

	// RVA: 0xFFFFFFFF75A6F0D8
	private static Boolean IsPrimaryExpr(XPathScanner scanner) { }

	// RVA: 0xFFFFFFFF75A6F4AC
	private AstNode ParsePrimaryExpr(AstNode qyInput) { }

	// RVA: 0xFFFFFFFF75A6FE0C
	private AstNode ParseMethod(AstNode qyInput) { }

	// RVA: 0xFFFFFFFF75A6FD80
	private Void CheckToken(LexKind t) { }

	// RVA: 0xFFFFFFFF75A6F788
	private Void PassToken(LexKind t) { }

	// RVA: 0xFFFFFFFF75A6E728
	private Void NextLex() { }

	// RVA: 0xFFFFFFFF75A6E6D8
	private Boolean TestOp(String op) { }

	// RVA: 0xFFFFFFFF75A6EF78
	private Void CheckNodeSet(XPathResultType t) { }

	// RVA: 0xFFFFFFFF75A707B4
	private static Hashtable CreateFunctionTable() { }

	// RVA: 0xFFFFFFFF75A71400
	private static Hashtable CreateAxesTable() { }

	// RVA: 0xFFFFFFFF75A6F9D8
	private AxisType GetAxis(XPathScanner scaner) { }

	// RVA: 0xFFFFFFFF75A71794
	private static Void .cctor() { }

}

// Namespace: 
private class ParamInfo
{
	// Fields
	private FunctionType ftype; // 0x10
	private Int32 minargs; // 0x14
	private Int32 maxargs; // 0x18
	private XPathResultType[] argTypes; // 0x20

	// Properties
	public FunctionType FType { get; }
	public Int32 Minargs { get; }
	public Int32 Maxargs { get; }
	public XPathResultType[] ArgTypes { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A71A14
	public FunctionType get_FType() { }

	// RVA: 0xFFFFFFFF75A71A1C
	public Int32 get_Minargs() { }

	// RVA: 0xFFFFFFFF75A71A24
	public Int32 get_Maxargs() { }

	// RVA: 0xFFFFFFFF75A71A2C
	public XPathResultType[] get_ArgTypes() { }

	// RVA: 0xFFFFFFFF75A713C0
	internal Void .ctor(FunctionType ftype, Int32 minargs, Int32 maxargs, XPathResultType[] argTypes) { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathScanner
{
	// Fields
	private String xpathExpr; // 0x10
	private Int32 xpathExprIndex; // 0x18
	private LexKind kind; // 0x1C
	private Char currentChar; // 0x20
	private String name; // 0x28
	private String prefix; // 0x30
	private String stringValue; // 0x38
	private Double numberValue; // 0x40
	private Boolean canBeFunction; // 0x48
	private XmlCharType xmlCharType; // 0x50

	// Properties
	public String SourceText { get; }
	private Char CurerntChar { get; }
	public LexKind Kind { get; }
	public String Name { get; }
	public String Prefix { get; }
	public String StringValue { get; }
	public Double NumberValue { get; }
	public Boolean CanBeFunction { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A6E33C
	public Void .ctor(String xpathExpr) { }

	// RVA: 0xFFFFFFFF75A71AA0
	public String get_SourceText() { }

	// RVA: 0xFFFFFFFF75A71AA8
	private Char get_CurerntChar() { }

	// RVA: 0xFFFFFFFF75A71A34
	private Boolean NextChar() { }

	// RVA: 0xFFFFFFFF75A71AB0
	public LexKind get_Kind() { }

	// RVA: 0xFFFFFFFF75A71AB8
	public String get_Name() { }

	// RVA: 0xFFFFFFFF75A71AC0
	public String get_Prefix() { }

	// RVA: 0xFFFFFFFF75A71AC8
	public String get_StringValue() { }

	// RVA: 0xFFFFFFFF75A71AD0
	public Double get_NumberValue() { }

	// RVA: 0xFFFFFFFF75A71AD8
	public Boolean get_CanBeFunction() { }

	// RVA: 0xFFFFFFFF75A71AE0
	private Void SkipSpace() { }

	// RVA: 0xFFFFFFFF75A70374
	public Boolean NextLex() { }

	// RVA: 0xFFFFFFFF75A71C8C
	private Double ScanNumber() { }

	// RVA: 0xFFFFFFFF75A71B20
	private Double ScanFraction() { }

	// RVA: 0xFFFFFFFF75A71BBC
	private String ScanString() { }

	// RVA: 0xFFFFFFFF75A71D50
	private String ScanName() { }

}

// Namespace: 
public enum LexKind
{
	// Fields
	public Int32 value__; // 0x10
	public const LexKind Comma = 44;
	public const LexKind Slash = 47;
	public const LexKind At = 64;
	public const LexKind Dot = 46;
	public const LexKind LParens = 40;
	public const LexKind RParens = 41;
	public const LexKind LBracket = 91;
	public const LexKind RBracket = 93;
	public const LexKind Star = 42;
	public const LexKind Plus = 43;
	public const LexKind Minus = 45;
	public const LexKind Eq = 61;
	public const LexKind Lt = 60;
	public const LexKind Gt = 62;
	public const LexKind Bang = 33;
	public const LexKind Dollar = 36;
	public const LexKind Apos = 39;
	public const LexKind Quote = 34;
	public const LexKind Union = 124;
	public const LexKind Ne = 78;
	public const LexKind Le = 76;
	public const LexKind Ge = 71;
	public const LexKind And = 65;
	public const LexKind Or = 79;
	public const LexKind DotDot = 68;
	public const LexKind SlashSlash = 83;
	public const LexKind Name = 110;
	public const LexKind String = 115;
	public const LexKind Number = 100;
	public const LexKind Axe = 97;
	public const LexKind Eof = 69;
}

// Namespace: MS.Internal.Xml.XPath
internal class XPathSelectionIterator
{
	// Fields
	private XPathNavigator nav; // 0x18
	private Query query; // 0x20
	private Int32 position; // 0x28

	// Properties
	public override Int32 Count { get; }
	public override XPathNavigator Current { get; }
	public override Int32 CurrentPosition { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A62D70
	internal Void .ctor(XPathNavigator nav, Query query) { }

	// RVA: 0xFFFFFFFF75A71DCC
	protected Void .ctor(XPathSelectionIterator it) { }

	// RVA: 0xFFFFFFFF75A71ED8
	public override Void Reset() { }

	// RVA: 0xFFFFFFFF75A71F00
	public override Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75A71FA0
	public override Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75A71FC8
	public override XPathNavigator get_Current() { }

	// RVA: 0xFFFFFFFF75A71FD0
	public override Int32 get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75A71FD8
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathSelfQuery
{
	// Methods

	// RVA: 0xFFFFFFFF75A696FC
	public Void .ctor(Query qyInput, String Name, String Prefix, XPathNodeType Type) { }

	// RVA: 0xFFFFFFFF75A72030
	private Void .ctor(XPathSelfQuery other) { }

	// RVA: 0xFFFFFFFF75A72034
	public override XPathNavigator Advance() { }

	// RVA: 0xFFFFFFFF75A720C8
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathSingletonIterator
{
	// Fields
	private XPathNavigator nav; // 0x18
	private Int32 position; // 0x20

	// Properties
	public override XPathNavigator Current { get; }
	public override Int32 CurrentPosition { get; }
	public override Int32 Count { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A72120
	public Void .ctor(XPathNavigator nav) { }

	// RVA: 0xFFFFFFFF75A7216C
	public Void .ctor(XPathNavigator nav, Boolean moved) { }

	// RVA: 0xFFFFFFFF75A721D0
	public Void .ctor(XPathSingletonIterator it) { }

	// RVA: 0xFFFFFFFF75A7224C
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A722A4
	public override XPathNavigator get_Current() { }

	// RVA: 0xFFFFFFFF75A722AC
	public override Int32 get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75A722B4
	public override Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75A722BC
	public override Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75A722D8
	public override Void Reset() { }

}

// Namespace: MS.Internal.Xml.Cache
internal abstract class XPathDocumentBaseIterator
{
	// Fields
	protected XPathDocumentNavigator ctxt; // 0x18
	protected Int32 pos; // 0x20

	// Properties
	public override XPathNavigator Current { get; }
	public override Int32 CurrentPosition { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A59008
	protected Void .ctor(XPathDocumentNavigator ctxt) { }

	// RVA: 0xFFFFFFFF75A590EC
	protected Void .ctor(XPathDocumentBaseIterator iter) { }

	// RVA: 0xFFFFFFFF75A59188
	public override XPathNavigator get_Current() { }

	// RVA: 0xFFFFFFFF75A59190
	public override Int32 get_CurrentPosition() { }

}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentElementChildIterator
{
	// Fields
	private String localName; // 0x28
	private String namespaceUri; // 0x30

	// Methods

	// RVA: 0xFFFFFFFF75A59198
	public Void .ctor(XPathDocumentNavigator parent, String name, String namespaceURI) { }

	// RVA: 0xFFFFFFFF75A592B0
	public Void .ctor(XPathDocumentElementChildIterator iter) { }

	// RVA: 0xFFFFFFFF75A59328
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A59380
	public override Boolean MoveNext() { }

}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentKindChildIterator
{
	// Fields
	private XPathNodeType typ; // 0x24

	// Methods

	// RVA: 0xFFFFFFFF75A597D8
	public Void .ctor(XPathDocumentNavigator parent, XPathNodeType typ) { }

	// RVA: 0xFFFFFFFF75A59800
	public Void .ctor(XPathDocumentKindChildIterator iter) { }

	// RVA: 0xFFFFFFFF75A59834
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A5989C
	public override Boolean MoveNext() { }

}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentElementDescendantIterator
{
	// Fields
	private XPathDocumentNavigator end; // 0x28
	private String localName; // 0x30
	private String namespaceUri; // 0x38
	private Boolean matchSelf; // 0x40

	// Methods

	// RVA: 0xFFFFFFFF75A59400
	public Void .ctor(XPathDocumentNavigator root, String name, String namespaceURI, Boolean matchSelf) { }

	// RVA: 0xFFFFFFFF75A5958C
	public Void .ctor(XPathDocumentElementDescendantIterator iter) { }

	// RVA: 0xFFFFFFFF75A59628
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A59680
	public override Boolean MoveNext() { }

}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentKindDescendantIterator
{
	// Fields
	private XPathDocumentNavigator end; // 0x28
	private XPathNodeType typ; // 0x30
	private Boolean matchSelf; // 0x34

	// Methods

	// RVA: 0xFFFFFFFF75A5991C
	public Void .ctor(XPathDocumentNavigator root, XPathNodeType typ, Boolean matchSelf) { }

	// RVA: 0xFFFFFFFF75A599F8
	public Void .ctor(XPathDocumentKindDescendantIterator iter) { }

	// RVA: 0xFFFFFFFF75A59A5C
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A59AB4
	public override Boolean MoveNext() { }

}

// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathDocumentNavigator
{
	// Fields
	private XPathNode[] pageCurrent; // 0x10
	private XPathNode[] pageParent; // 0x18
	private Int32 idxCurrent; // 0x20
	private Int32 idxParent; // 0x24
	private String atomizedLocalName; // 0x28

	// Properties
	public override String Value { get; }
	public override XPathNodeType NodeType { get; }
	public override String LocalName { get; }
	public override String NamespaceURI { get; }
	public override String Name { get; }
	public override String Prefix { get; }
	public override String BaseURI { get; }
	public override XmlNameTable NameTable { get; }
	public override Object UnderlyingObject { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A59BD8
	public Void .ctor(XPathNode[] pageCurrent, Int32 idxCurrent, XPathNode[] pageParent, Int32 idxParent) { }

	// RVA: 0xFFFFFFFF75A59094
	public Void .ctor(XPathDocumentNavigator nav) { }

	// RVA: 0xFFFFFFFF75A59C98
	public override String get_Value() { }

	// RVA: 0xFFFFFFFF75A5A104
	public override XPathNavigator Clone() { }

	// RVA: 0xFFFFFFFF75A5A180
	public override XPathNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF75A5A1D0
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF75A5A238
	public override String get_NamespaceURI() { }

	// RVA: 0xFFFFFFFF75A5A2A0
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF75A5A328
	public override String get_Prefix() { }

	// RVA: 0xFFFFFFFF75A5A390
	public override String get_BaseURI() { }

	// RVA: 0xFFFFFFFF75A5A4F0
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xFFFFFFFF75A5A560
	public override Boolean MoveToFirstAttribute() { }

	// RVA: 0xFFFFFFFF75A5A620
	public override Boolean MoveToNextAttribute() { }

	// RVA: 0xFFFFFFFF75A5A710
	public override Boolean MoveToAttribute(String localName, String namespaceURI) { }

	// RVA: 0xFFFFFFFF75A5A970
	public override Boolean MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0xFFFFFFFF75A5AD18
	public override Boolean MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0xFFFFFFFF75A5AEA8
	public override Boolean MoveToNext() { }

	// RVA: 0xFFFFFFFF75A5AF88
	public override Boolean MoveToFirstChild() { }

	// RVA: 0xFFFFFFFF75A5B170
	public override Boolean MoveToParent() { }

	// RVA: 0xFFFFFFFF75A5B2B8
	public override Boolean MoveTo(XPathNavigator other) { }

	// RVA: 0xFFFFFFFF75A5B374
	public override Boolean MoveToId(String id) { }

	// RVA: 0xFFFFFFFF75A5B440
	public override Boolean IsSamePosition(XPathNavigator other) { }

	// RVA: 0xFFFFFFFF75A5B4E8
	public override Void MoveToRoot() { }

	// RVA: 0xFFFFFFFF75A5B590
	public override Boolean MoveToChild(String localName, String namespaceURI) { }

	// RVA: 0xFFFFFFFF75A5B764
	public override Boolean MoveToNext(String localName, String namespaceURI) { }

	// RVA: 0xFFFFFFFF75A5B930
	public override Boolean MoveToChild(XPathNodeType type) { }

	// RVA: 0xFFFFFFFF75A5BB94
	public override Boolean MoveToNext(XPathNodeType type) { }

	// RVA: 0xFFFFFFFF75A5BD0C
	public override Boolean MoveToFollowing(String localName, String namespaceURI, XPathNavigator end) { }

	// RVA: 0xFFFFFFFF75A5C274
	public override Boolean MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0xFFFFFFFF75A5C734
	public override XPathNodeIterator SelectChildren(XPathNodeType type) { }

	// RVA: 0xFFFFFFFF75A5C79C
	public override XPathNodeIterator SelectChildren(String name, String namespaceURI) { }

	// RVA: 0xFFFFFFFF75A5C838
	public override XPathNodeIterator SelectDescendants(XPathNodeType type, Boolean matchSelf) { }

	// RVA: 0xFFFFFFFF75A5C8A8
	public override XPathNodeIterator SelectDescendants(String name, String namespaceURI, Boolean matchSelf) { }

	// RVA: 0xFFFFFFFF75A5C95C
	public override XmlNodeOrder ComparePosition(XPathNavigator other) { }

	// RVA: 0xFFFFFFFF75A5CB18
	public override Boolean IsDescendant(XPathNavigator other) { }

	// RVA: 0xFFFFFFFF75A5CA74
	private Int32 GetPrimaryLocation() { }

	// RVA: 0xFFFFFFFF75A5CA94
	private Int32 GetSecondaryLocation() { }

	// RVA: 0xFFFFFFFF75A5CCB0
	public override Object get_UnderlyingObject() { }

	// RVA: 0xFFFFFFFF75A5CCC0
	public Int32 GetPositionHashCode() { }

	// RVA: 0xFFFFFFFF75A596F8
	public Boolean IsElementMatch(String localName, String namespaceURI) { }

	// RVA: 0xFFFFFFFF75A59B2C
	public Boolean IsKindMatch(XPathNodeType typ) { }

	// RVA: 0xFFFFFFFF75A5BE98
	private Int32 GetFollowingEnd(XPathDocumentNavigator end, Boolean useParentOfVirtual, out XPathNode[] pageEnd) { }

}

// Namespace: MS.Internal.Xml.Cache
internal struct XPathNode
{
	// Fields
	private XPathNodeInfoAtom info; // 0x10
	private UInt16 idxSibling; // 0x18
	private UInt16 idxParent; // 0x1A
	private UInt16 idxSimilar; // 0x1C
	private UInt16 posOffset; // 0x1E
	private UInt32 props; // 0x20
	private String value; // 0x28

	// Properties
	public XPathNodeType NodeType { get; }
	public String Prefix { get; }
	public String LocalName { get; }
	public String Name { get; }
	public String NamespaceUri { get; }
	public XPathDocument Document { get; }
	public String BaseUri { get; }
	public XPathNodePageInfo PageInfo { get; }
	public Boolean IsXmlNamespaceNode { get; }
	public Boolean HasSibling { get; }
	public Boolean HasCollapsedText { get; }
	public Boolean HasAttribute { get; }
	public Boolean HasContentChild { get; }
	public Boolean HasElementChild { get; }
	public Boolean IsAttrNmsp { get; }
	public Boolean IsText { get; }
	public Boolean HasNamespaceDecls { get; }
	public String Value { get; }

	// Methods

	// RVA: 0xFFFFFFFF71144D8C
	public XPathNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF71144D98
	public String get_Prefix() { }

	// RVA: 0xFFFFFFFF71144DB8
	public String get_LocalName() { }

	// RVA: 0xFFFFFFFF71144DD8
	public String get_Name() { }

	// RVA: 0xFFFFFFFF71144DE0
	public String get_NamespaceUri() { }

	// RVA: 0xFFFFFFFF71144E00
	public XPathDocument get_Document() { }

	// RVA: 0xFFFFFFFF71144E20
	public String get_BaseUri() { }

	// RVA: 0xFFFFFFFF71144E40
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0xFFFFFFFF71144E60
	public Int32 GetRoot(out XPathNode[] pageNode) { }

	// RVA: 0xFFFFFFFF71144E68
	public Int32 GetParent(out XPathNode[] pageNode) { }

	// RVA: 0xFFFFFFFF71144EB4
	public Int32 GetSibling(out XPathNode[] pageNode) { }

	// RVA: 0xFFFFFFFF71144F00
	public Int32 GetSimilarElement(out XPathNode[] pageNode) { }

	// RVA: 0xFFFFFFFF71144F4C
	public Boolean NameMatch(String localName, String namespaceName) { }

	// RVA: 0xFFFFFFFF71144F8C
	public Boolean ElementMatch(String localName, String namespaceName) { }

	// RVA: 0xFFFFFFFF71144F94
	public Boolean get_IsXmlNamespaceNode() { }

	// RVA: 0xFFFFFFFF71144F9C
	public Boolean get_HasSibling() { }

	// RVA: 0xFFFFFFFF71144FAC
	public Boolean get_HasCollapsedText() { }

	// RVA: 0xFFFFFFFF71144FB8
	public Boolean get_HasAttribute() { }

	// RVA: 0xFFFFFFFF71144FC4
	public Boolean get_HasContentChild() { }

	// RVA: 0xFFFFFFFF71144FD0
	public Boolean get_HasElementChild() { }

	// RVA: 0xFFFFFFFF71144FDC
	public Boolean get_IsAttrNmsp() { }

	// RVA: 0xFFFFFFFF71144FF0
	public Boolean get_IsText() { }

	// RVA: 0xFFFFFFFF71144FF8
	public Boolean get_HasNamespaceDecls() { }

	// RVA: 0xFFFFFFFF71145004
	public String get_Value() { }

}

// Namespace: MS.Internal.Xml.Cache
internal struct XPathNodeRef
{
	// Fields
	private XPathNode[] page; // 0x10
	private Int32 idx; // 0x18

	// Properties
	public XPathNode[] Page { get; }
	public Int32 Index { get; }

	// Methods

	// RVA: 0xFFFFFFFF71145048
	public Void .ctor(XPathNode[] page, Int32 idx) { }

	// RVA: 0xFFFFFFFF71145090
	public XPathNode[] get_Page() { }

	// RVA: 0xFFFFFFFF71145098
	public Int32 get_Index() { }

	// RVA: 0xFFFFFFFF711450A0
	public override Int32 GetHashCode() { }

}

// Namespace: MS.Internal.Xml.Cache
internal abstract class XPathNodeHelper
{
	// Methods

	// RVA: 0xFFFFFFFF75A5AAB4
	public static Int32 GetLocalNamespaces(XPathNode[] pageElem, Int32 idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0xFFFFFFFF75A5AB50
	public static Int32 GetInScopeNamespaces(XPathNode[] pageElem, Int32 idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0xFFFFFFFF75A5A5C8
	public static Boolean GetFirstAttribute(ref XPathNode[] pageNode, ref Int32 idxNode) { }

	// RVA: 0xFFFFFFFF75A5A630
	public static Boolean GetNextAttribute(ref XPathNode[] pageNode, ref Int32 idxNode) { }

	// RVA: 0xFFFFFFFF75A5B068
	public static Boolean GetContentChild(ref XPathNode[] pageNode, ref Int32 idxNode) { }

	// RVA: 0xFFFFFFFF75A5AEB8
	public static Boolean GetContentSibling(ref XPathNode[] pageNode, ref Int32 idxNode) { }

	// RVA: 0xFFFFFFFF75A5B200
	public static Boolean GetParent(ref XPathNode[] pageNode, ref Int32 idxNode) { }

	// RVA: 0xFFFFFFFF75A5CC6C
	public static Int32 GetLocation(XPathNode[] pageNode, Int32 idxNode) { }

	// RVA: 0xFFFFFFFF75A5B634
	public static Boolean GetElementChild(ref XPathNode[] pageNode, ref Int32 idxNode, String localName, String namespaceName) { }

	// RVA: 0xFFFFFFFF75A5B808
	public static Boolean GetElementSibling(ref XPathNode[] pageNode, ref Int32 idxNode, String localName, String namespaceName) { }

	// RVA: 0xFFFFFFFF75A5BA20
	public static Boolean GetContentChild(ref XPathNode[] pageNode, ref Int32 idxNode, XPathNodeType typ) { }

	// RVA: 0xFFFFFFFF75A5BBA8
	public static Boolean GetContentSibling(ref XPathNode[] pageNode, ref Int32 idxNode, XPathNodeType typ) { }

	// RVA: 0xFFFFFFFF75A5A804
	public static Boolean GetAttribute(ref XPathNode[] pageNode, ref Int32 idxNode, String localName, String namespaceName) { }

	// RVA: 0xFFFFFFFF75A5BFA0
	public static Boolean GetElementFollowing(ref XPathNode[] pageCurrent, ref Int32 idxCurrent, XPathNode[] pageEnd, Int32 idxEnd, String localName, String namespaceName) { }

	// RVA: 0xFFFFFFFF75A5C588
	public static Boolean GetContentFollowing(ref XPathNode[] pageCurrent, ref Int32 idxCurrent, XPathNode[] pageEnd, Int32 idxEnd, XPathNodeType typ) { }

	// RVA: 0xFFFFFFFF75A59F80
	public static Boolean GetTextFollowing(ref XPathNode[] pageCurrent, ref Int32 idxCurrent, XPathNode[] pageEnd, Int32 idxEnd) { }

	// RVA: 0xFFFFFFFF75A59E64
	public static Boolean GetNonDescendant(ref XPathNode[] pageNode, ref Int32 idxNode) { }

	// RVA: 0xFFFFFFFF75A5CE88
	private static Void GetChild(ref XPathNode[] pageNode, ref Int32 idxNode) { }

}

// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathNodePageInfo
{
	// Fields
	private Int32 pageNum; // 0x10
	private Int32 nodeCount; // 0x14
	private XPathNode[] pageNext; // 0x18

	// Properties
	public Int32 PageNumber { get; }
	public Int32 NodeCount { get; }
	public XPathNode[] NextPage { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A5CF58
	public Int32 get_PageNumber() { }

	// RVA: 0xFFFFFFFF75A5CF60
	public Int32 get_NodeCount() { }

	// RVA: 0xFFFFFFFF75A5CF68
	public XPathNode[] get_NextPage() { }

}

// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathNodeInfoAtom
{
	// Fields
	private String localName; // 0x10
	private String namespaceUri; // 0x18
	private String prefix; // 0x20
	private String baseUri; // 0x28
	private XPathNode[] pageParent; // 0x30
	private XPathNode[] pageSibling; // 0x38
	private XPathNode[] pageSimilar; // 0x40
	private XPathDocument doc; // 0x48
	private XPathNodePageInfo pageInfo; // 0x50

	// Properties
	public XPathNodePageInfo PageInfo { get; }
	public String LocalName { get; }
	public String NamespaceUri { get; }
	public String Prefix { get; }
	public String BaseUri { get; }
	public XPathNode[] SiblingPage { get; }
	public XPathNode[] SimilarElementPage { get; }
	public XPathNode[] ParentPage { get; }
	public XPathDocument Document { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A5CF10
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0xFFFFFFFF75A5CF18
	public String get_LocalName() { }

	// RVA: 0xFFFFFFFF75A5CF20
	public String get_NamespaceUri() { }

	// RVA: 0xFFFFFFFF75A5CF28
	public String get_Prefix() { }

	// RVA: 0xFFFFFFFF75A5CF30
	public String get_BaseUri() { }

	// RVA: 0xFFFFFFFF75A5CF38
	public XPathNode[] get_SiblingPage() { }

	// RVA: 0xFFFFFFFF75A5CF40
	public XPathNode[] get_SimilarElementPage() { }

	// RVA: 0xFFFFFFFF75A5CF48
	public XPathNode[] get_ParentPage() { }

	// RVA: 0xFFFFFFFF75A5CF50
	public XPathDocument get_Document() { }

}

// Namespace: System.Xml
internal abstract class Base64Encoder
{
	// Fields
	private Byte[] leftOverBytes; // 0x10
	private Int32 leftOverBytesCount; // 0x18
	private Char[] charsLine; // 0x20

	// Methods

	// RVA: -1
	internal abstract Void WriteChars(Char[] chars, Int32 index, Int32 count) { }

	// RVA: 0xFFFFFFFF75A72338
	internal Void Flush() { }

}

// Namespace: System.Xml
internal class XmlTextWriterBase64Encoder
{
	// Fields
	private XmlTextEncoder xmlTextEncoder; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75AEEEF4
	internal override Void WriteChars(Char[] chars, Int32 index, Int32 count) { }

}

// Namespace: System.Xml
internal class BinHexDecoder
{
	// Fields
	private Byte[] buffer; // 0x10
	private Int32 curIndex; // 0x18
	private Int32 endIndex; // 0x1C
	private Boolean hasHalfByteCached; // 0x20
	private Byte cachedHalfByte; // 0x21

	// Properties
	internal override Boolean IsFull { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A723CC
	internal override Boolean get_IsFull() { }

	// RVA: 0xFFFFFFFF75A723DC
	internal override Int32 Decode(Char[] chars, Int32 startPos, Int32 len) { }

	// RVA: 0xFFFFFFFF75A72740
	public static Byte[] Decode(Char[] chars, Boolean allowOddChars) { }

	// RVA: 0xFFFFFFFF75A72564
	private static Void Decode(Char* pChars, Char* pCharsEndPos, Byte* pBytes, Byte* pBytesEndPos, ref Boolean hasHalfByteCached, ref Byte cachedHalfByte, out Int32 charsDecoded, out Int32 bytesDecoded) { }

}

// Namespace: System.Xml
internal static class BinHexEncoder
{
	// Methods

	// RVA: 0xFFFFFFFF75A72904
	internal static String Encode(Byte[] inArray, Int32 offsetIn, Int32 count) { }

	// RVA: 0xFFFFFFFF75A72A24
	private static Int32 Encode(Byte[] inArray, Int32 offsetIn, Int32 count, Char[] outArray) { }

}

// Namespace: System.Xml
internal static class Bits
{
	// Fields
	private static readonly UInt32 MASK_0101010101010101; // 0x0
	private static readonly UInt32 MASK_0011001100110011; // 0x4
	private static readonly UInt32 MASK_0000111100001111; // 0x8
	private static readonly UInt32 MASK_0000000011111111; // 0xC
	private static readonly UInt32 MASK_1111111111111111; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75A72DF0
	public static Int32 Count(UInt32 num) { }

	// RVA: 0xFFFFFFFF75A72E94
	public static Int32 LeastPosition(UInt32 num) { }

	// RVA: 0xFFFFFFFF75A72F08
	private static Void .cctor() { }

}

// Namespace: System.Xml
internal static class BinaryCompatibility
{
	// Fields
	private static Boolean _targetsAtLeast_Desktop_V4_5_2; // 0x0

	// Properties
	internal static Boolean TargetsAtLeast_Desktop_V4_5_2 { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A72B64
	internal static Boolean get_TargetsAtLeast_Desktop_V4_5_2() { }

	// RVA: 0xFFFFFFFF75A72BC4
	private static Boolean RunningOnCheck(String propertyName) { }

	// RVA: 0xFFFFFFFF75A72D90
	private static Void .cctor() { }

}

// Namespace: System.Xml
public enum ConformanceLevel
{
	// Fields
	public Int32 value__; // 0x10
	public const ConformanceLevel Auto = 0;
	public const ConformanceLevel Fragment = 1;
	public const ConformanceLevel Document = 2;
}

// Namespace: System.Xml
public enum DtdProcessing
{
	// Fields
	public Int32 value__; // 0x10
	public const DtdProcessing Prohibit = 0;
	public const DtdProcessing Ignore = 1;
	public const DtdProcessing Parse = 2;
}

// Namespace: System.Xml
public enum EntityHandling
{
	// Fields
	public Int32 value__; // 0x10
	public const EntityHandling ExpandEntities = 1;
	public const EntityHandling ExpandCharEntities = 2;
}

// Namespace: System.Xml
internal interface IDtdInfo
{
	// Properties
	public abstract XmlQualifiedName Name { get; }
	public abstract String InternalDtdSubset { get; }
	public abstract Boolean HasDefaultAttributes { get; }
	public abstract Boolean HasNonCDataAttributes { get; }

	// Methods

	// RVA: -1
	public abstract XmlQualifiedName get_Name() { }

	// RVA: -1
	public abstract String get_InternalDtdSubset() { }

	// RVA: -1
	public abstract Boolean get_HasDefaultAttributes() { }

	// RVA: -1
	public abstract Boolean get_HasNonCDataAttributes() { }

	// RVA: -1
	public abstract IDtdAttributeListInfo LookupAttributeList(String prefix, String localName) { }

	// RVA: -1
	public abstract IDtdEntityInfo LookupEntity(String name) { }

}

// Namespace: System.Xml
internal interface IDtdAttributeListInfo
{
	// Properties
	public abstract Boolean HasNonCDataAttributes { get; }

	// Methods

	// RVA: -1
	public abstract Boolean get_HasNonCDataAttributes() { }

	// RVA: -1
	public abstract IDtdAttributeInfo LookupAttribute(String prefix, String localName) { }

	// RVA: -1
	public abstract IEnumerable<T0> LookupDefaultAttributes() { }

}

// Namespace: System.Xml
internal interface IDtdAttributeInfo
{
	// Properties
	public abstract String Prefix { get; }
	public abstract String LocalName { get; }
	public abstract Int32 LineNumber { get; }
	public abstract Int32 LinePosition { get; }
	public abstract Boolean IsNonCDataType { get; }
	public abstract Boolean IsDeclaredInExternal { get; }
	public abstract Boolean IsXmlAttribute { get; }

	// Methods

	// RVA: -1
	public abstract String get_Prefix() { }

	// RVA: -1
	public abstract String get_LocalName() { }

	// RVA: -1
	public abstract Int32 get_LineNumber() { }

	// RVA: -1
	public abstract Int32 get_LinePosition() { }

	// RVA: -1
	public abstract Boolean get_IsNonCDataType() { }

	// RVA: -1
	public abstract Boolean get_IsDeclaredInExternal() { }

	// RVA: -1
	public abstract Boolean get_IsXmlAttribute() { }

}

// Namespace: System.Xml
internal interface IDtdDefaultAttributeInfo
{
	// Properties
	public abstract String DefaultValueExpanded { get; }
	public abstract Object DefaultValueTyped { get; }
	public abstract Int32 ValueLineNumber { get; }
	public abstract Int32 ValueLinePosition { get; }

	// Methods

	// RVA: -1
	public abstract String get_DefaultValueExpanded() { }

	// RVA: -1
	public abstract Object get_DefaultValueTyped() { }

	// RVA: -1
	public abstract Int32 get_ValueLineNumber() { }

	// RVA: -1
	public abstract Int32 get_ValueLinePosition() { }

}

// Namespace: System.Xml
internal interface IDtdEntityInfo
{
	// Properties
	public abstract String Name { get; }
	public abstract Boolean IsExternal { get; }
	public abstract Boolean IsDeclaredInExternal { get; }
	public abstract Boolean IsUnparsedEntity { get; }
	public abstract Boolean IsParameterEntity { get; }
	public abstract String BaseUriString { get; }
	public abstract String DeclaredUriString { get; }
	public abstract String SystemId { get; }
	public abstract String PublicId { get; }
	public abstract String Text { get; }
	public abstract Int32 LineNumber { get; }
	public abstract Int32 LinePosition { get; }

	// Methods

	// RVA: -1
	public abstract String get_Name() { }

	// RVA: -1
	public abstract Boolean get_IsExternal() { }

	// RVA: -1
	public abstract Boolean get_IsDeclaredInExternal() { }

	// RVA: -1
	public abstract Boolean get_IsUnparsedEntity() { }

	// RVA: -1
	public abstract Boolean get_IsParameterEntity() { }

	// RVA: -1
	public abstract String get_BaseUriString() { }

	// RVA: -1
	public abstract String get_DeclaredUriString() { }

	// RVA: -1
	public abstract String get_SystemId() { }

	// RVA: -1
	public abstract String get_PublicId() { }

	// RVA: -1
	public abstract String get_Text() { }

	// RVA: -1
	public abstract Int32 get_LineNumber() { }

	// RVA: -1
	public abstract Int32 get_LinePosition() { }

}

// Namespace: System.Xml
internal interface IDtdParser
{
	// Methods

	// RVA: -1
	public abstract IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, Boolean saveInternalSubset) { }

	// RVA: -1
	public abstract IDtdInfo ParseFreeFloatingDtd(String baseUri, String docTypeName, String publicId, String systemId, String internalSubset, IDtdParserAdapter adapter) { }

}

// Namespace: System.Xml
internal interface IDtdParserAdapter
{
	// Properties
	public abstract XmlNameTable NameTable { get; }
	public abstract IXmlNamespaceResolver NamespaceResolver { get; }
	public abstract Uri BaseUri { get; }
	public abstract Char[] ParsingBuffer { get; }
	public abstract Int32 ParsingBufferLength { get; }
	public abstract Int32 CurrentPosition { get; set; }
	public abstract Int32 LineNo { get; }
	public abstract Int32 LineStartPosition { get; }
	public abstract Boolean IsEof { get; }
	public abstract Int32 EntityStackLength { get; }
	public abstract Boolean IsEntityEolNormalized { get; }

	// Methods

	// RVA: -1
	public abstract XmlNameTable get_NameTable() { }

	// RVA: -1
	public abstract IXmlNamespaceResolver get_NamespaceResolver() { }

	// RVA: -1
	public abstract Uri get_BaseUri() { }

	// RVA: -1
	public abstract Char[] get_ParsingBuffer() { }

	// RVA: -1
	public abstract Int32 get_ParsingBufferLength() { }

	// RVA: -1
	public abstract Int32 get_CurrentPosition() { }

	// RVA: -1
	public abstract Void set_CurrentPosition(Int32 value) { }

	// RVA: -1
	public abstract Int32 get_LineNo() { }

	// RVA: -1
	public abstract Int32 get_LineStartPosition() { }

	// RVA: -1
	public abstract Boolean get_IsEof() { }

	// RVA: -1
	public abstract Int32 get_EntityStackLength() { }

	// RVA: -1
	public abstract Boolean get_IsEntityEolNormalized() { }

	// RVA: -1
	public abstract Int32 ReadData() { }

	// RVA: -1
	public abstract Void OnNewLine(Int32 pos) { }

	// RVA: -1
	public abstract Int32 ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: -1
	public abstract Int32 ParseNamedCharRef(Boolean expand, StringBuilder internalSubsetBuilder) { }

	// RVA: -1
	public abstract Void ParsePI(StringBuilder sb) { }

	// RVA: -1
	public abstract Void ParseComment(StringBuilder sb) { }

	// RVA: -1
	public abstract Boolean PushEntity(IDtdEntityInfo entity, out Int32 entityId) { }

	// RVA: -1
	public abstract Boolean PopEntity(out IDtdEntityInfo oldEntity, out Int32 newEntityId) { }

	// RVA: -1
	public abstract Boolean PushExternalSubset(String systemId, String publicId) { }

	// RVA: -1
	public abstract Void PushInternalDtd(String baseUri, String internalDtd) { }

	// RVA: -1
	public abstract Void OnSystemId(String systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: -1
	public abstract Void OnPublicId(String publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: -1
	public abstract Void Throw(Exception e) { }

}

// Namespace: System.Xml
internal interface IDtdParserAdapterWithValidation
{
	// Properties
	public abstract Boolean DtdValidation { get; }
	public abstract IValidationEventHandling ValidationEventHandling { get; }

	// Methods

	// RVA: -1
	public abstract Boolean get_DtdValidation() { }

	// RVA: -1
	public abstract IValidationEventHandling get_ValidationEventHandling() { }

}

// Namespace: System.Xml
internal interface IDtdParserAdapterV1
{
	// Properties
	public abstract Boolean V1CompatibilityMode { get; }
	public abstract Boolean Normalization { get; }
	public abstract Boolean Namespaces { get; }

	// Methods

	// RVA: -1
	public abstract Boolean get_V1CompatibilityMode() { }

	// RVA: -1
	public abstract Boolean get_Normalization() { }

	// RVA: -1
	public abstract Boolean get_Namespaces() { }

}

// Namespace: System.Xml
internal interface IValidationEventHandling
{
	// Methods

	// RVA: -1
	public abstract Void SendEvent(Exception exception, XmlSeverityType severity) { }

}

// Namespace: System.Xml
internal abstract class IncrementalReadDecoder
{
	// Properties
	internal abstract Boolean IsFull { get; }

	// Methods

	// RVA: -1
	internal abstract Boolean get_IsFull() { }

	// RVA: -1
	internal abstract Int32 Decode(Char[] chars, Int32 startPos, Int32 len) { }

	// RVA: 0xFFFFFFFF75A81CC4
	protected Void .ctor() { }

}

// Namespace: System.Xml
internal class IncrementalReadDummyDecoder
{
	// Properties
	internal override Boolean IsFull { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A81CC8
	internal override Boolean get_IsFull() { }

	// RVA: 0xFFFFFFFF75A81CD0
	internal override Int32 Decode(Char[] chars, Int32 startPos, Int32 len) { }

	// RVA: 0xFFFFFFFF75A81CD8
	public Void .ctor() { }

}

// Namespace: System.Xml
public enum ReadState
{
	// Fields
	public Int32 value__; // 0x10
	public const ReadState Initial = 0;
	public const ReadState Interactive = 1;
	public const ReadState Error = 2;
	public const ReadState EndOfFile = 3;
	public const ReadState Closed = 4;
}

// Namespace: System.Xml
internal class SecureStringHasher
{
	// Fields
	private static HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private Int32 hashCodeRandomizer; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75ABAAB8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75ABAAE0
	public Boolean Equals(String x, String y) { }

	// RVA: 0xFFFFFFFF75ABAAF4
	public Int32 GetHashCode(String key) { }

	// RVA: 0xFFFFFFFF75ABB120
	private static Int32 GetHashCodeOfString(String key, Int32 sLen, Int64 additionalEntropy) { }

	// RVA: 0xFFFFFFFF75ABAB98
	private static HashCodeOfStringDelegate GetHashCodeDelegate() { }

}

// Namespace: 
private sealed class HashCodeOfStringDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75ABB194
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75ABACD8
	public virtual Int32 Invoke(String s, Int32 sLen, Int64 additionalEntropy) { }

	// RVA: 0xFFFFFFFF75ABB1D8
	public virtual IAsyncResult BeginInvoke(String s, Int32 sLen, Int64 additionalEntropy, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75ABB284
	public virtual Int32 EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Xml
public enum ValidationType
{
	// Fields
	public Int32 value__; // 0x10
	public const ValidationType None = 0;
	public const ValidationType Auto = 1;
	public const ValidationType DTD = 2;
	public const ValidationType XDR = 3;
	public const ValidationType Schema = 4;
}

// Namespace: System.Xml
public enum WhitespaceHandling
{
	// Fields
	public Int32 value__; // 0x10
	public const WhitespaceHandling All = 0;
	public const WhitespaceHandling Significant = 1;
	public const WhitespaceHandling None = 2;
}

// Namespace: System.Xml
public class XmlParserContext
{
	// Fields
	private XmlNameTable _nt; // 0x10
	private XmlNamespaceManager _nsMgr; // 0x18
	private String _docTypeName; // 0x20
	private String _pubId; // 0x28
	private String _sysId; // 0x30
	private String _internalSubset; // 0x38
	private String _xmlLang; // 0x40
	private XmlSpace _xmlSpace; // 0x48
	private String _baseURI; // 0x50
	private Encoding _encoding; // 0x58

	// Properties
	public XmlNameTable NameTable { get; }
	public XmlNamespaceManager NamespaceManager { get; }
	public String DocTypeName { get; }
	public String PublicId { get; }
	public String SystemId { get; }
	public String BaseURI { get; }
	public String InternalSubset { get; }
	public String XmlLang { get; }
	public XmlSpace XmlSpace { get; }
	public Encoding Encoding { get; }
	internal Boolean HasDtdInfo { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AD2C7C
	public Void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, String docTypeName, String pubId, String sysId, String internalSubset, String baseURI, String xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0xFFFFFFFF75AD74C0
	public Void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, String docTypeName, String pubId, String sysId, String internalSubset, String baseURI, String xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	// RVA: 0xFFFFFFFF75AD785C
	public XmlNameTable get_NameTable() { }

	// RVA: 0xFFFFFFFF75AD7864
	public XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0xFFFFFFFF75AD786C
	public String get_DocTypeName() { }

	// RVA: 0xFFFFFFFF75AD7874
	public String get_PublicId() { }

	// RVA: 0xFFFFFFFF75AD787C
	public String get_SystemId() { }

	// RVA: 0xFFFFFFFF75AD7884
	public String get_BaseURI() { }

	// RVA: 0xFFFFFFFF75AD788C
	public String get_InternalSubset() { }

	// RVA: 0xFFFFFFFF75AD7894
	public String get_XmlLang() { }

	// RVA: 0xFFFFFFFF75AD789C
	public XmlSpace get_XmlSpace() { }

	// RVA: 0xFFFFFFFF75AD78A4
	public Encoding get_Encoding() { }

	// RVA: 0xFFFFFFFF75AD78AC
	internal Boolean get_HasDtdInfo() { }

}

// Namespace: System.Xml
public abstract class XmlReader
{
	// Fields
	private static UInt32 IsTextualNodeBitmap; // 0x0
	private static UInt32 CanReadContentAsBitmap; // 0x4
	private static UInt32 HasValueBitmap; // 0x8

	// Properties
	public virtual XmlReaderSettings Settings { get; }
	public abstract XmlNodeType NodeType { get; }
	public virtual String Name { get; }
	public abstract String LocalName { get; }
	public abstract String NamespaceURI { get; }
	public abstract String Prefix { get; }
	public abstract String Value { get; }
	public abstract String BaseURI { get; }
	public abstract Boolean IsEmptyElement { get; }
	public virtual Boolean IsDefault { get; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }
	public abstract ReadState ReadState { get; }
	public abstract XmlNameTable NameTable { get; }
	public virtual Boolean CanResolveEntity { get; }
	internal virtual IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AD869C
	public virtual XmlReaderSettings get_Settings() { }

	// RVA: -1
	public abstract XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF75AD86A4
	public virtual String get_Name() { }

	// RVA: -1
	public abstract String get_LocalName() { }

	// RVA: -1
	public abstract String get_NamespaceURI() { }

	// RVA: -1
	public abstract String get_Prefix() { }

	// RVA: -1
	public abstract String get_Value() { }

	// RVA: -1
	public abstract String get_BaseURI() { }

	// RVA: -1
	public abstract Boolean get_IsEmptyElement() { }

	// RVA: 0xFFFFFFFF75AD8778
	public virtual Boolean get_IsDefault() { }

	// RVA: 0xFFFFFFFF75AD8780
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: -1
	public abstract Boolean MoveToAttribute(String name) { }

	// RVA: -1
	public abstract Boolean MoveToFirstAttribute() { }

	// RVA: -1
	public abstract Boolean MoveToNextAttribute() { }

	// RVA: -1
	public abstract Boolean MoveToElement() { }

	// RVA: -1
	public abstract Boolean ReadAttributeValue() { }

	// RVA: -1
	public abstract Boolean Read() { }

	// RVA: 0xFFFFFFFF75AD87C8
	public virtual Void Close() { }

	// RVA: -1
	public abstract ReadState get_ReadState() { }

	// RVA: -1
	public abstract XmlNameTable get_NameTable() { }

	// RVA: -1
	public abstract String LookupNamespace(String prefix) { }

	// RVA: 0xFFFFFFFF75AD87CC
	public virtual Boolean get_CanResolveEntity() { }

	// RVA: -1
	public abstract Void ResolveEntity() { }

	// RVA: 0xFFFFFFFF75AD87D4
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75AD87E8
	protected virtual Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75AD883C
	internal virtual IDtdInfo get_DtdInfo() { }

	// RVA: 0xFFFFFFFF75AD8844
	internal static Int32 CalcBufferSize(Stream input) { }

	// RVA: 0xFFFFFFFF75AD88D4
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF75AD88D8
	private static Void .cctor() { }

}

// Namespace: System.Xml
public sealed class XmlReaderSettings
{
	// Fields
	private Boolean useAsync; // 0x10
	private XmlNameTable nameTable; // 0x18
	private XmlResolver xmlResolver; // 0x20
	private Int32 lineNumberOffset; // 0x28
	private Int32 linePositionOffset; // 0x2C
	private ConformanceLevel conformanceLevel; // 0x30
	private Boolean checkCharacters; // 0x34
	private Int64 maxCharactersInDocument; // 0x38
	private Int64 maxCharactersFromEntities; // 0x40
	private Boolean ignoreWhitespace; // 0x48
	private Boolean ignorePIs; // 0x49
	private Boolean ignoreComments; // 0x4A
	private DtdProcessing dtdProcessing; // 0x4C
	private ValidationType validationType; // 0x50
	private XmlSchemaValidationFlags validationFlags; // 0x54
	private XmlSchemaSet schemas; // 0x58
	private ValidationEventHandler valEventHandler; // 0x60
	private Boolean closeInput; // 0x68
	private Boolean isReadOnly; // 0x69
	private Boolean <IsXmlResolverSet>k__BackingField; // 0x6A
	private static Nullable<T0> s_enableLegacyXmlSettings; // 0x0

	// Properties
	public XmlNameTable NameTable { set; }
	internal Boolean IsXmlResolverSet { set; }
	public XmlResolver XmlResolver { set; }
	public Int32 LineNumberOffset { set; }
	public Int32 LinePositionOffset { set; }
	public ConformanceLevel ConformanceLevel { set; }
	public Boolean CheckCharacters { set; }
	public Int64 MaxCharactersInDocument { set; }
	public Int64 MaxCharactersFromEntities { set; }
	public Boolean IgnoreWhitespace { set; }
	public Boolean IgnoreProcessingInstructions { set; }
	public Boolean IgnoreComments { set; }
	public DtdProcessing DtdProcessing { set; }
	public ValidationType ValidationType { get; }
	public XmlSchemaSet Schemas { get; }
	internal Boolean ReadOnly { set; }

	// Methods

	// RVA: 0xFFFFFFFF75AD8934
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AD8944
	public Void set_NameTable(XmlNameTable value) { }

	// RVA: 0xFFFFFFFF75AD8A88
	internal Void set_IsXmlResolverSet(Boolean value) { }

	// RVA: 0xFFFFFFFF75AD8A90
	public Void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xFFFFFFFF75AD8B0C
	internal XmlResolver GetXmlResolver() { }

	// RVA: 0xFFFFFFFF75AD8B14
	public Void set_LineNumberOffset(Int32 value) { }

	// RVA: 0xFFFFFFFF75AD8B70
	public Void set_LinePositionOffset(Int32 value) { }

	// RVA: 0xFFFFFFFF75AD8BCC
	public Void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0xFFFFFFFF75AD8C6C
	public Void set_CheckCharacters(Boolean value) { }

	// RVA: 0xFFFFFFFF75AD8CC8
	public Void set_MaxCharactersInDocument(Int64 value) { }

	// RVA: 0xFFFFFFFF75AD8D64
	public Void set_MaxCharactersFromEntities(Int64 value) { }

	// RVA: 0xFFFFFFFF75AD8E00
	public Void set_IgnoreWhitespace(Boolean value) { }

	// RVA: 0xFFFFFFFF75AD8E5C
	public Void set_IgnoreProcessingInstructions(Boolean value) { }

	// RVA: 0xFFFFFFFF75AD8EB8
	public Void set_IgnoreComments(Boolean value) { }

	// RVA: 0xFFFFFFFF75AD8F14
	public Void set_DtdProcessing(DtdProcessing value) { }

	// RVA: 0xFFFFFFFF75AD8FB4
	public ValidationType get_ValidationType() { }

	// RVA: 0xFFFFFFFF75ACFE3C
	public XmlSchemaSet get_Schemas() { }

	// RVA: 0xFFFFFFFF75AD8FBC
	internal Void set_ReadOnly(Boolean value) { }

	// RVA: 0xFFFFFFFF75AD89BC
	private Void CheckReadOnly(String propertyName) { }

	// RVA: 0xFFFFFFFF75AD893C
	private Void Initialize() { }

	// RVA: 0xFFFFFFFF75AD8FC4
	private Void Initialize(XmlResolver resolver) { }

	// RVA: 0xFFFFFFFF75AD908C
	private static XmlResolver CreateDefaultResolver() { }

	// RVA: 0xFFFFFFFF75AD90E0
	internal static Boolean EnableLegacyXmlSettings() { }

}

// Namespace: System.Xml
public enum XmlSpace
{
	// Fields
	public Int32 value__; // 0x10
	public const XmlSpace None = 0;
	public const XmlSpace Default = 1;
	public const XmlSpace Preserve = 2;
}

// Namespace: System.Xml
internal class XmlTextEncoder
{
	// Fields
	private TextWriter textWriter; // 0x10
	private Boolean inAttribute; // 0x18
	private Char quoteChar; // 0x1A
	private StringBuilder attrValue; // 0x20
	private Boolean cacheAttrValue; // 0x28
	private XmlCharType xmlCharType; // 0x30

	// Properties
	internal Char QuoteChar { set; }
	internal String AttributeValue { get; }

	// Methods

	// RVA: 0xFFFFFFFF7236E8CC
	internal Void .ctor(TextWriter textWriter) { }

	// RVA: 0xFFFFFFFF75AD9E74
	internal Void set_QuoteChar(Char value) { }

	// RVA: 0xFFFFFFFF7236E980
	internal Void StartAttribute(Boolean cacheAttrValue) { }

	// RVA: 0xFFFFFFFF7236EA18
	internal Void EndAttribute() { }

	// RVA: 0xFFFFFFFF75AD9E7C
	internal String get_AttributeValue() { }

	// RVA: 0xFFFFFFFF75AD9EC4
	internal Void WriteSurrogateChar(Char lowChar, Char highChar) { }

	// RVA: 0xFFFFFFFF7236EA64
	internal Void Write(String text) { }

	// RVA: 0xFFFFFFFF7236EF58
	internal Void WriteRawWithSurrogateChecking(String text) { }

	// RVA: 0xFFFFFFFF75ADA110
	internal Void WriteRaw(Char[] array, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF75ADA23C
	internal Void WriteEntityRef(String name) { }

	// RVA: 0xFFFFFFFF75AD9F9C
	private Void WriteStringFragment(String str, Int32 offset, Int32 count, Char[] helperBuffer) { }

	// RVA: 0xFFFFFFFF75ADA050
	private Void WriteCharEntityImpl(Char ch) { }

	// RVA: 0xFFFFFFFF75ADA2A4
	private Void WriteCharEntityImpl(String strVal) { }

	// RVA: 0xFFFFFFFF75ADA0A4
	private Void WriteEntityRefImpl(String name) { }

}

// Namespace: System.Xml
public class XmlTextReader
{
	// Fields
	private XmlTextReaderImpl impl; // 0x10

	// Properties
	public override XmlNodeType NodeType { get; }
	public override String Name { get; }
	public override String LocalName { get; }
	public override String NamespaceURI { get; }
	public override String Prefix { get; }
	public override String Value { get; }
	public override String BaseURI { get; }
	public override Boolean IsEmptyElement { get; }
	public override Boolean IsDefault { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override Boolean CanResolveEntity { get; }
	public EntityHandling EntityHandling { set; }
	public XmlResolver XmlResolver { set; }
	internal XmlTextReaderImpl Impl { get; }
	internal Boolean XmlValidatingReaderCompatibilityMode { set; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AC9BCC
	public Void .ctor(Stream input, XmlNameTable nt) { }

	// RVA: 0xFFFFFFFF75ACA208
	public Void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0xFFFFFFFF75AC9A18
	public Void .ctor(String url, XmlNameTable nt) { }

	// RVA: 0xFFFFFFFF75ADA55C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF75ADA584
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF75ADA5AC
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF75ADA5D4
	public override String get_NamespaceURI() { }

	// RVA: 0xFFFFFFFF75ADA5FC
	public override String get_Prefix() { }

	// RVA: 0xFFFFFFFF75ADA624
	public override String get_Value() { }

	// RVA: 0xFFFFFFFF75ADA64C
	public override String get_BaseURI() { }

	// RVA: 0xFFFFFFFF75ADA674
	public override Boolean get_IsEmptyElement() { }

	// RVA: 0xFFFFFFFF75ADA69C
	public override Boolean get_IsDefault() { }

	// RVA: 0xFFFFFFFF75ADA6C4
	public override Boolean MoveToAttribute(String name) { }

	// RVA: 0xFFFFFFFF75ADA6EC
	public override Boolean MoveToFirstAttribute() { }

	// RVA: 0xFFFFFFFF75ADA714
	public override Boolean MoveToNextAttribute() { }

	// RVA: 0xFFFFFFFF75ADA73C
	public override Boolean MoveToElement() { }

	// RVA: 0xFFFFFFFF75ADA764
	public override Boolean ReadAttributeValue() { }

	// RVA: 0xFFFFFFFF75ADA78C
	public override Boolean Read() { }

	// RVA: 0xFFFFFFFF75ADA7B4
	public override Void Close() { }

	// RVA: 0xFFFFFFFF75ADA7DC
	public override ReadState get_ReadState() { }

	// RVA: 0xFFFFFFFF75ADA804
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xFFFFFFFF75ADA82C
	public override String LookupNamespace(String prefix) { }

	// RVA: 0xFFFFFFFF75ADA868
	public override Boolean get_CanResolveEntity() { }

	// RVA: 0xFFFFFFFF75ADA870
	public override Void ResolveEntity() { }

	// RVA: 0xFFFFFFFF75ADA898
	private String System.Xml.IXmlNamespaceResolver.LookupNamespace(String prefix) { }

	// RVA: 0xFFFFFFFF75ADA8C0
	private String System.Xml.IXmlNamespaceResolver.LookupPrefix(String namespaceName) { }

	// RVA: 0xFFFFFFFF75AC9900
	public Void set_EntityHandling(EntityHandling value) { }

	// RVA: 0xFFFFFFFF75AC991C
	public Void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xFFFFFFFF75ADA9BC
	internal XmlTextReaderImpl get_Impl() { }

	// RVA: 0xFFFFFFFF75AC98E4
	internal Void set_XmlValidatingReaderCompatibilityMode(Boolean value) { }

	// RVA: 0xFFFFFFFF75ADA9C4
	internal override IDtdInfo get_DtdInfo() { }

}

// Namespace: System.Xml
internal class XmlTextReaderImpl
{
	// Fields
	private LaterInitParam laterInitParam; // 0x10
	private XmlCharType xmlCharType; // 0x18
	private ParsingState ps; // 0x20
	private ParsingFunction parsingFunction; // 0x98
	private ParsingFunction nextParsingFunction; // 0x9C
	private ParsingFunction nextNextParsingFunction; // 0xA0
	private NodeData[] nodes; // 0xA8
	private NodeData curNode; // 0xB0
	private Int32 index; // 0xB8
	private Int32 curAttrIndex; // 0xBC
	private Int32 attrCount; // 0xC0
	private Int32 attrHashtable; // 0xC4
	private Int32 attrDuplWalkCount; // 0xC8
	private Boolean attrNeedNamespaceLookup; // 0xCC
	private Boolean fullAttrCleanup; // 0xCD
	private NodeData[] attrDuplSortingArray; // 0xD0
	private XmlNameTable nameTable; // 0xD8
	private Boolean nameTableFromSettings; // 0xE0
	private XmlResolver xmlResolver; // 0xE8
	private String url; // 0xF0
	private Boolean normalize; // 0xF8
	private Boolean supportNamespaces; // 0xF9
	private WhitespaceHandling whitespaceHandling; // 0xFC
	private DtdProcessing dtdProcessing; // 0x100
	private EntityHandling entityHandling; // 0x104
	private Boolean ignorePIs; // 0x108
	private Boolean ignoreComments; // 0x109
	private Boolean checkCharacters; // 0x10A
	private Int32 lineNumberOffset; // 0x10C
	private Int32 linePositionOffset; // 0x110
	private Boolean closeInput; // 0x114
	private Int64 maxCharactersInDocument; // 0x118
	private Int64 maxCharactersFromEntities; // 0x120
	private Boolean v1Compat; // 0x128
	private XmlNamespaceManager namespaceManager; // 0x130
	private String lastPrefix; // 0x138
	private XmlContext xmlContext; // 0x140
	private ParsingState[] parsingStatesStack; // 0x148
	private Int32 parsingStatesStackTop; // 0x150
	private String reportedBaseUri; // 0x158
	private Encoding reportedEncoding; // 0x160
	private IDtdInfo dtdInfo; // 0x168
	private XmlNodeType fragmentType; // 0x170
	private XmlParserContext fragmentParserContext; // 0x178
	private Boolean fragment; // 0x180
	private IncrementalReadDecoder incReadDecoder; // 0x188
	private IncrementalReadState incReadState; // 0x190
	private LineInfo incReadLineInfo; // 0x194
	private Int32 incReadDepth; // 0x19C
	private Int32 incReadLeftStartPos; // 0x1A0
	private Int32 incReadLeftEndPos; // 0x1A4
	private Int32 attributeValueBaseEntityId; // 0x1A8
	private Boolean emptyEntityInAttributeResolved; // 0x1AC
	private IValidationEventHandling validationEventHandling; // 0x1B0
	private OnDefaultAttributeUseDelegate onDefaultAttributeUse; // 0x1B8
	private Boolean validatingReaderCompatFlag; // 0x1C0
	private Boolean addDefaultAttributesAndNormalize; // 0x1C1
	private StringBuilder stringBuilder; // 0x1C8
	private Boolean rootElementParsed; // 0x1D0
	private Boolean standalone; // 0x1D1
	private Int32 nextEntityId; // 0x1D4
	private ParsingMode parsingMode; // 0x1D8
	private ReadState readState; // 0x1DC
	private IDtdEntityInfo lastEntity; // 0x1E0
	private Boolean afterResetState; // 0x1E8
	private Int32 documentStartBytePos; // 0x1EC
	private Int32 readValueOffset; // 0x1F0
	private Int64 charactersInDocument; // 0x1F8
	private Int64 charactersFromEntities; // 0x200
	private Dictionary<T0, T1> currentEntities; // 0x208
	private Boolean disableUndeclaredEntityCheck; // 0x210
	private XmlReader outerReader; // 0x218
	private Boolean xmlResolverIsSet; // 0x220
	private String Xml; // 0x228
	private String XmlNs; // 0x230
	private Task<T0> parseText_dummyTask; // 0x238

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override String Name { get; }
	public override String LocalName { get; }
	public override String NamespaceURI { get; }
	public override String Prefix { get; }
	public override String Value { get; }
	public override String BaseURI { get; }
	public override Boolean IsEmptyElement { get; }
	public override Boolean IsDefault { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override Boolean CanResolveEntity { get; }
	internal XmlReader OuterReader { set; }
	internal Boolean Namespaces { set; }
	internal EntityHandling EntityHandling { set; }
	internal XmlResolver XmlResolver { set; }
	internal XmlNameTable DtdParserProxy_NameTable { get; }
	internal IXmlNamespaceResolver DtdParserProxy_NamespaceResolver { get; }
	internal Boolean DtdParserProxy_DtdValidation { get; }
	internal Boolean DtdParserProxy_Normalization { get; }
	internal Boolean DtdParserProxy_Namespaces { get; }
	internal Boolean DtdParserProxy_V1CompatibilityMode { get; }
	internal Uri DtdParserProxy_BaseUri { get; }
	internal Boolean DtdParserProxy_IsEof { get; }
	internal Char[] DtdParserProxy_ParsingBuffer { get; }
	internal Int32 DtdParserProxy_ParsingBufferLength { get; }
	internal Int32 DtdParserProxy_CurrentPosition { get; set; }
	internal Int32 DtdParserProxy_EntityStackLength { get; }
	internal Boolean DtdParserProxy_IsEntityEolNormalized { get; }
	internal IValidationEventHandling DtdParserProxy_ValidationEventHandling { get; }
	internal Int32 DtdParserProxy_LineNo { get; }
	internal Int32 DtdParserProxy_LineStartPosition { get; }
	private Boolean IsResolverNull { get; }
	private Boolean InAttributeValueIterator { get; }
	private Boolean DtdValidation { get; }
	private Boolean InEntity { get; }
	internal override IDtdInfo DtdInfo { get; }
	internal Boolean XmlValidatingReaderCompatibilityMode { set; }
	internal Boolean DisableUndeclaredEntityCheck { set; }

	// Methods

	// RVA: 0xFFFFFFFF75ADA9EC
	internal Void .ctor(XmlNameTable nt) { }

	// RVA: 0xFFFFFFFF75ADA33C
	internal Void .ctor(Stream input, XmlNameTable nt) { }

	// RVA: 0xFFFFFFFF75ADAE08
	internal Void .ctor(String url, Stream input, XmlNameTable nt) { }

	// RVA: 0xFFFFFFFF75ADA358
	internal Void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0xFFFFFFFF75ADAF6C
	internal Void .ctor(String url, TextReader input, XmlNameTable nt) { }

	// RVA: 0xFFFFFFFF75AD2CAC
	internal Void .ctor(String xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	// RVA: 0xFFFFFFFF75AD40D8
	internal Void .ctor(String xmlFragment, XmlParserContext context) { }

	// RVA: 0xFFFFFFFF75ADA374
	public Void .ctor(String url, XmlNameTable nt) { }

	// RVA: 0xFFFFFFFF75ADB4D4
	private Void FinishInitUriString() { }

	// RVA: 0xFFFFFFFF75ADBB38
	private Void FinishInitStream() { }

	// RVA: 0xFFFFFFFF75ADBBE8
	private Void FinishInitTextReader() { }

	// RVA: 0xFFFFFFFF75ADBC7C
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xFFFFFFFF75ADBEB4
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF75ADBED4
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF75ADBEFC
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF75ADBF1C
	public override String get_NamespaceURI() { }

	// RVA: 0xFFFFFFFF75ADBF3C
	public override String get_Prefix() { }

	// RVA: 0xFFFFFFFF75ADBF5C
	public override String get_Value() { }

	// RVA: 0xFFFFFFFF75ADC1A0
	public override String get_BaseURI() { }

	// RVA: 0xFFFFFFFF75ADC1A8
	public override Boolean get_IsEmptyElement() { }

	// RVA: 0xFFFFFFFF75ADC1C8
	public override Boolean get_IsDefault() { }

	// RVA: 0xFFFFFFFF75ADC1E8
	public override ReadState get_ReadState() { }

	// RVA: 0xFFFFFFFF75ADC1F0
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xFFFFFFFF75ADC1F8
	public override Boolean get_CanResolveEntity() { }

	// RVA: 0xFFFFFFFF75ADC200
	public override Boolean MoveToAttribute(String name) { }

	// RVA: 0xFFFFFFFF75ADC56C
	public override Boolean MoveToFirstAttribute() { }

	// RVA: 0xFFFFFFFF75ADC608
	public override Boolean MoveToNextAttribute() { }

	// RVA: 0xFFFFFFFF75ADC6C8
	public override Boolean MoveToElement() { }

	// RVA: 0xFFFFFFFF75ADC778
	private Void FinishInit() { }

	// RVA: 0xFFFFFFFF75ADC7C4
	public override Boolean Read() { }

	// RVA: 0xFFFFFFFF75ADE9FC
	public override Void Close() { }

	// RVA: 0xFFFFFFFF75ADEA04
	public override String LookupNamespace(String prefix) { }

	// RVA: 0xFFFFFFFF75ADEA40
	public override Boolean ReadAttributeValue() { }

	// RVA: 0xFFFFFFFF75ADF11C
	public override Void ResolveEntity() { }

	// RVA: 0xFFFFFFFF75ADF844
	internal Void set_OuterReader(XmlReader value) { }

	// RVA: 0xFFFFFFFF75ADF87C
	private String System.Xml.IXmlNamespaceResolver.LookupNamespace(String prefix) { }

	// RVA: 0xFFFFFFFF75ADF88C
	private String System.Xml.IXmlNamespaceResolver.LookupPrefix(String namespaceName) { }

	// RVA: 0xFFFFFFFF75ADA8F0
	internal String LookupPrefix(String namespaceName) { }

	// RVA: 0xFFFFFFFF75AD2DE4
	internal Void set_Namespaces(Boolean value) { }

	// RVA: 0xFFFFFFFF75ADA918
	internal Void set_EntityHandling(EntityHandling value) { }

	// RVA: 0xFFFFFFFF75AD2FEC
	internal Void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xFFFFFFFF75ADF8B4
	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	// RVA: 0xFFFFFFFF75ADF8BC
	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	// RVA: 0xFFFFFFFF75ADF8C4
	internal Boolean get_DtdParserProxy_DtdValidation() { }

	// RVA: 0xFFFFFFFF75ADF8E4
	internal Boolean get_DtdParserProxy_Normalization() { }

	// RVA: 0xFFFFFFFF75ADF8EC
	internal Boolean get_DtdParserProxy_Namespaces() { }

	// RVA: 0xFFFFFFFF75ADF8F4
	internal Boolean get_DtdParserProxy_V1CompatibilityMode() { }

	// RVA: 0xFFFFFFFF75ADF8FC
	internal Uri get_DtdParserProxy_BaseUri() { }

	// RVA: 0xFFFFFFFF75ADF9AC
	internal Boolean get_DtdParserProxy_IsEof() { }

	// RVA: 0xFFFFFFFF75ADF9B4
	internal Char[] get_DtdParserProxy_ParsingBuffer() { }

	// RVA: 0xFFFFFFFF75ADF9BC
	internal Int32 get_DtdParserProxy_ParsingBufferLength() { }

	// RVA: 0xFFFFFFFF75ADF9C4
	internal Int32 get_DtdParserProxy_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75ADF9CC
	internal Void set_DtdParserProxy_CurrentPosition(Int32 value) { }

	// RVA: 0xFFFFFFFF75ADF9D4
	internal Int32 get_DtdParserProxy_EntityStackLength() { }

	// RVA: 0xFFFFFFFF75ADF9E0
	internal Boolean get_DtdParserProxy_IsEntityEolNormalized() { }

	// RVA: 0xFFFFFFFF75ADF9E8
	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	// RVA: 0xFFFFFFFF75ADF9F0
	internal Void DtdParserProxy_OnNewLine(Int32 pos) { }

	// RVA: 0xFFFFFFFF75ADFA18
	internal Int32 get_DtdParserProxy_LineNo() { }

	// RVA: 0xFFFFFFFF75ADFA20
	internal Int32 get_DtdParserProxy_LineStartPosition() { }

	// RVA: 0xFFFFFFFF75ADFA28
	internal Int32 DtdParserProxy_ReadData() { }

	// RVA: 0xFFFFFFFF75ADFE88
	internal Int32 DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0xFFFFFFFF75ADFF74
	internal Int32 DtdParserProxy_ParseNamedCharRef(Boolean expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0xFFFFFFFF75ADFFE8
	internal Void DtdParserProxy_ParsePI(StringBuilder sb) { }

	// RVA: 0xFFFFFFFF75AE0380
	internal Void DtdParserProxy_ParseComment(StringBuilder sb) { }

	// RVA: 0xFFFFFFFF75AE0764
	private Boolean get_IsResolverNull() { }

	// RVA: 0xFFFFFFFF75ADB474
	private XmlResolver GetTempResolver() { }

	// RVA: 0xFFFFFFFF75AE07A8
	internal Boolean DtdParserProxy_PushEntity(IDtdEntityInfo entity, out Int32 entityId) { }

	// RVA: 0xFFFFFFFF75AE0FB8
	internal Boolean DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out Int32 newEntityId) { }

	// RVA: 0xFFFFFFFF75AE109C
	internal Boolean DtdParserProxy_PushExternalSubset(String systemId, String publicId) { }

	// RVA: 0xFFFFFFFF75AE1810
	internal Void DtdParserProxy_PushInternalDtd(String baseUri, String internalDtd) { }

	// RVA: 0xFFFFFFFF75AE1AB4
	internal Void DtdParserProxy_Throw(Exception e) { }

	// RVA: 0xFFFFFFFF75AE1B64
	internal Void DtdParserProxy_OnSystemId(String systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0xFFFFFFFF75AE1C6C
	internal Void DtdParserProxy_OnPublicId(String publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0xFFFFFFFF75AE1CF0
	private Void Throw(Int32 pos, String res, String arg) { }

	// RVA: 0xFFFFFFFF75AE1DA0
	private Void Throw(Int32 pos, String res, String[] args) { }

	// RVA: 0xFFFFFFFF75AE1E2C
	private Void Throw(Int32 pos, String res) { }

	// RVA: 0xFFFFFFFF75AE1E54
	private Void Throw(String res) { }

	// RVA: 0xFFFFFFFF75AE1E70
	private Void Throw(String res, Int32 lineNo, Int32 linePos) { }

	// RVA: 0xFFFFFFFF75AE1D08
	private Void Throw(String res, String arg) { }

	// RVA: 0xFFFFFFFF75AE1F08
	private Void Throw(String res, String arg, Int32 lineNo, Int32 linePos) { }

	// RVA: 0xFFFFFFFF75AE1DB8
	private Void Throw(String res, String[] args) { }

	// RVA: 0xFFFFFFFF75AE1F94
	private Void Throw(String res, String arg, Exception innerException) { }

	// RVA: 0xFFFFFFFF75AE1FEC
	private Void Throw(String res, String[] args, Exception innerException) { }

	// RVA: 0xFFFFFFFF75AE1AC0
	private Void Throw(Exception e) { }

	// RVA: 0xFFFFFFFF75AE2078
	private Void ReThrow(Exception e, Int32 lineNo, Int32 linePos) { }

	// RVA: 0xFFFFFFFF75ADE7CC
	private Void ThrowWithoutLineInfo(String res) { }

	// RVA: 0xFFFFFFFF75AE20F4
	private Void ThrowWithoutLineInfo(String res, String arg) { }

	// RVA: 0xFFFFFFFF75AE2174
	private Void ThrowWithoutLineInfo(String res, String[] args, Exception innerException) { }

	// RVA: 0xFFFFFFFF75AE21D4
	private Void ThrowInvalidChar(Char[] data, Int32 length, Int32 invCharPos) { }

	// RVA: 0xFFFFFFFF75AE2064
	private Void SetErrorState() { }

	// RVA: 0xFFFFFFFF75AE06C0
	private Void SendValidationEvent(XmlSeverityType severity, String code, String arg, Int32 lineNo, Int32 linePos) { }

	// RVA: 0xFFFFFFFF75AE2240
	private Void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	// RVA: 0xFFFFFFFF75ADC498
	private Boolean get_InAttributeValueIterator() { }

	// RVA: 0xFFFFFFFF75ADC4BC
	private Void FinishAttributeValueIterator() { }

	// RVA: 0xFFFFFFFF75ADF8D4
	private Boolean get_DtdValidation() { }

	// RVA: 0xFFFFFFFF75ADAF28
	private Void InitStreamInput(Stream stream, Encoding encoding) { }

	// RVA: 0xFFFFFFFF75ADAF50
	private Void InitStreamInput(String baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0xFFFFFFFF75AE2494
	private Void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	// RVA: 0xFFFFFFFF75AE24FC
	private Void InitStreamInput(Uri baseUri, String baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0xFFFFFFFF75ADB7D0
	private Void InitStreamInput(Uri baseUri, String baseUriStr, Stream stream, Byte[] bytes, Int32 byteCount, Encoding encoding) { }

	// RVA: 0xFFFFFFFF75ADB068
	private Void InitTextReaderInput(String baseUriStr, TextReader input) { }

	// RVA: 0xFFFFFFFF75AE2888
	private Void InitTextReaderInput(String baseUriStr, Uri baseUri, TextReader input) { }

	// RVA: 0xFFFFFFFF75ADB074
	private Void InitStringInput(String baseUriStr, Encoding originalEncoding, String str) { }

	// RVA: 0xFFFFFFFF75ADB194
	private Void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, Boolean allowXmlDeclFragment) { }

	// RVA: 0xFFFFFFFF75ADBACC
	private Void ProcessDtdFromParserContext(XmlParserContext context) { }

	// RVA: 0xFFFFFFFF75ADD428
	private Void OpenUrl() { }

	// RVA: 0xFFFFFFFF75AE2BD8
	private Void OpenUrlDelegate(Object xmlResolver) { }

	// RVA: 0xFFFFFFFF75AE250C
	private Encoding DetectEncoding() { }

	// RVA: 0xFFFFFFFF75AE2718
	private Void SetupEncoding(Encoding encoding) { }

	// RVA: 0xFFFFFFFF75AE2CDC
	private Void SwitchEncoding(Encoding newEncoding) { }

	// RVA: 0xFFFFFFFF75AE2E90
	private Encoding CheckEncoding(String newEncodingName) { }

	// RVA: 0xFFFFFFFF75AE2DE0
	private Void UnDecodeChars() { }

	// RVA: 0xFFFFFFFF75AE317C
	private Void SwitchEncodingToUTF8() { }

	// RVA: 0xFFFFFFFF75ADFA2C
	private Int32 ReadData() { }

	// RVA: 0xFFFFFFFF75AE31DC
	private Int32 GetChars(Int32 maxCharsCount) { }

	// RVA: 0xFFFFFFFF75AE32FC
	private Void InvalidCharRecovery(ref Int32 bytesCount, out Int32 charsCount) { }

	// RVA: 0xFFFFFFFF75AC9CB4
	internal Void Close(Boolean closeInput) { }

	// RVA: 0xFFFFFFFF75AE3528
	private Void ShiftBuffer(Int32 sourcePos, Int32 destPos, Int32 count) { }

	// RVA: 0xFFFFFFFF75ADD64C
	private Boolean ParseXmlDeclaration(Boolean isTextDecl) { }

	// RVA: 0xFFFFFFFF75ADCF68
	private Boolean ParseDocumentContent() { }

	// RVA: 0xFFFFFFFF75ADCC5C
	private Boolean ParseElementContent() { }

	// RVA: 0xFFFFFFFF75AE4A94
	private Void ThrowUnclosedElements() { }

	// RVA: 0xFFFFFFFF75AE39CC
	private Void ParseElement() { }

	// RVA: 0xFFFFFFFF75AE5320
	private Void AddDefaultAttributesAndNormalize() { }

	// RVA: 0xFFFFFFFF75AE4714
	private Void ParseEndElement() { }

	// RVA: 0xFFFFFFFF75AE64BC
	private Void ThrowTagMismatch(NodeData startTag) { }

	// RVA: 0xFFFFFFFF75AE4D54
	private Void ParseAttributes() { }

	// RVA: 0xFFFFFFFF75AE5CA0
	private Void ElementNamespaceLookup() { }

	// RVA: 0xFFFFFFFF75AE63E4
	private Void AttributeNamespaceLookup() { }

	// RVA: 0xFFFFFFFF75AE74D8
	private Void AttributeDuplCheck() { }

	// RVA: 0xFFFFFFFF75AE7164
	private Void OnDefaultNamespaceDecl(NodeData attr) { }

	// RVA: 0xFFFFFFFF75AE7268
	private Void OnNamespaceDecl(NodeData attr) { }

	// RVA: 0xFFFFFFFF75AE7330
	private Void OnXmlReservedAttribute(NodeData attr) { }

	// RVA: 0xFFFFFFFF75AE6870
	private Void ParseAttributeValueSlow(Int32 curPos, Char quoteChar, NodeData attr) { }

	// RVA: 0xFFFFFFFF75AE7B70
	private Void AddAttributeChunkToList(NodeData attr, NodeData chunk, ref NodeData lastChunk) { }

	// RVA: 0xFFFFFFFF75AE412C
	private Boolean ParseText() { }

	// RVA: 0xFFFFFFFF75AE7D44
	private Boolean ParseText(out Int32 startPos, out Int32 endPos, ref Int32 outOrChars) { }

	// RVA: 0xFFFFFFFF75ADBFB4
	private Void FinishPartialValue() { }

	// RVA: 0xFFFFFFFF75ADC0B0
	private Void FinishOtherValueIterator() { }

	// RVA: 0xFFFFFFFF75ADE858
	private Void SkipPartialTextValue() { }

	// RVA: 0xFFFFFFFF75ADE8A0
	private Void FinishReadValueChunk() { }

	// RVA: 0xFFFFFFFF75ADE8C0
	private Void FinishReadContentAsBinary() { }

	// RVA: 0xFFFFFFFF75ADE91C
	private Void FinishReadElementContentAsBinary() { }

	// RVA: 0xFFFFFFFF75AE4508
	private Boolean ParseRootLevelWhitespace() { }

	// RVA: 0xFFFFFFFF75ADE310
	private Void ParseEntityReference() { }

	// RVA: 0xFFFFFFFF75AE3E48
	private EntityType HandleEntityReference(Boolean isInAttributeValue, EntityExpandType expandType, out Int32 charRefEndPos) { }

	// RVA: 0xFFFFFFFF75ADF354
	private EntityType HandleGeneralEntityReference(String name, Boolean isInAttributeValue, Boolean pushFakeEntityIfNullResolver, Int32 entityStartLinePos) { }

	// RVA: 0xFFFFFFFF75AE316C
	private Boolean get_InEntity() { }

	// RVA: 0xFFFFFFFF75AE2308
	private Boolean HandleEntityEnd(Boolean checkEntityNesting) { }

	// RVA: 0xFFFFFFFF75ADE38C
	private Void SetupEndEntityNodeInContent() { }

	// RVA: 0xFFFFFFFF75AE85AC
	private Void SetupEndEntityNodeInAttribute() { }

	// RVA: 0xFFFFFFFF75AE369C
	private Boolean ParsePI() { }

	// RVA: 0xFFFFFFFF75AE0030
	private Boolean ParsePI(StringBuilder piInDtdStringBuilder) { }

	// RVA: 0xFFFFFFFF75AE8644
	private Boolean ParsePIValue(out Int32 outStartPos, out Int32 outEndPos) { }

	// RVA: 0xFFFFFFFF75AE36A4
	private Boolean ParseComment() { }

	// RVA: 0xFFFFFFFF75AE371C
	private Void ParseCData() { }

	// RVA: 0xFFFFFFFF75AE0560
	private Void ParseCDataOrComment(XmlNodeType type) { }

	// RVA: 0xFFFFFFFF75AE89B4
	private Boolean ParseCDataOrComment(XmlNodeType type, out Int32 outStartPos, out Int32 outEndPos) { }

	// RVA: 0xFFFFFFFF75AE3724
	private Boolean ParseDoctypeDecl() { }

	// RVA: 0xFFFFFFFF75AE8DB4
	private Void ParseDtd() { }

	// RVA: 0xFFFFFFFF75AE90D8
	private Void SkipDtd() { }

	// RVA: 0xFFFFFFFF75AE93FC
	private Void SkipPublicOrSystemIdLiteral() { }

	// RVA: 0xFFFFFFFF75AE94A0
	private Void SkipUntil(Char stopChar, Boolean recognizeLiterals) { }

	// RVA: 0xFFFFFFFF75AE1598
	private Int32 EatWhitespaces(StringBuilder sb) { }

	// RVA: 0xFFFFFFFF75AE8340
	private Int32 ParseCharRefInline(Int32 startPos, out Int32 charCount, out EntityType entityType) { }

	// RVA: 0xFFFFFFFF75ADFEB0
	private Int32 ParseNumericCharRef(Boolean expand, StringBuilder internalSubsetBuilder, out EntityType entityType) { }

	// RVA: 0xFFFFFFFF75AE9904
	private Int32 ParseNumericCharRefInline(Int32 startPos, Boolean expand, StringBuilder internalSubsetBuilder, out Int32 charCount, out EntityType entityType) { }

	// RVA: 0xFFFFFFFF75ADFF78
	private Int32 ParseNamedCharRef(Boolean expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0xFFFFFFFF75AE9F24
	private Int32 ParseNamedCharRefInline(Int32 startPos, Boolean expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0xFFFFFFFF75AE3558
	private Int32 ParseName() { }

	// RVA: 0xFFFFFFFF75AE4D44
	private Int32 ParseQName(out Int32 colonPos) { }

	// RVA: 0xFFFFFFFF75AEA214
	private Int32 ParseQName(Boolean isQName, Int32 startOffset, out Int32 colonPos) { }

	// RVA: 0xFFFFFFFF75AEA458
	private Boolean ReadDataInName(ref Int32 pos) { }

	// RVA: 0xFFFFFFFF75AE7C00
	private String ParseEntityName() { }

	// RVA: 0xFFFFFFFF75ADE268
	private NodeData AddNode(Int32 nodeIndex, Int32 nodeDepth) { }

	// RVA: 0xFFFFFFFF75AEA4A4
	private NodeData AllocNode(Int32 nodeIndex, Int32 nodeDepth) { }

	// RVA: 0xFFFFFFFF75AE1BE8
	private NodeData AddAttributeNoChecks(String name, Int32 attrDepth) { }

	// RVA: 0xFFFFFFFF75AE66D0
	private NodeData AddAttribute(Int32 endNamePos, Int32 colonPos) { }

	// RVA: 0xFFFFFFFF75AEA5E4
	private NodeData AddAttribute(String localName, String prefix, String nameWPrefix) { }

	// RVA: 0xFFFFFFFF75ADE2B8
	private Void PopElementContext() { }

	// RVA: 0xFFFFFFFF75ADFA04
	private Void OnNewLine(Int32 pos) { }

	// RVA: 0xFFFFFFFF75ADE6FC
	private Void OnEof() { }

	// RVA: 0xFFFFFFFF75AE7854
	private String LookupNamespace(NodeData node) { }

	// RVA: 0xFFFFFFFF75AE7990
	private Void AddNamespace(String prefix, String uri, NodeData attr) { }

	// RVA: 0xFFFFFFFF75ADE22C
	private Void ResetAttributes() { }

	// RVA: 0xFFFFFFFF75AEA768
	private Void FullAttributeCleanup() { }

	// RVA: 0xFFFFFFFF75AE7900
	private Void PushXmlContext() { }

	// RVA: 0xFFFFFFFF75AEA714
	private Void PopXmlContext() { }

	// RVA: 0xFFFFFFFF75AE8560
	private XmlNodeType GetWhitespaceType() { }

	// RVA: 0xFFFFFFFF75AE82E4
	private XmlNodeType GetTextNodeType(Int32 orChars) { }

	// RVA: 0xFFFFFFFF75AE11E4
	private Void PushExternalEntityOrSubset(String publicId, String systemId, Uri baseUri, String entityName) { }

	// RVA: 0xFFFFFFFF75AEA818
	private Boolean OpenAndPush(Uri uri) { }

	// RVA: 0xFFFFFFFF75AE08B4
	private Boolean PushExternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0xFFFFFFFF75AE0C70
	private Void PushInternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0xFFFFFFFF75AE1044
	private Void PopEntity() { }

	// RVA: 0xFFFFFFFF75AEAA04
	private Void RegisterEntity(IDtdEntityInfo entity) { }

	// RVA: 0xFFFFFFFF75AEAC98
	private Void UnregisterEntity() { }

	// RVA: 0xFFFFFFFF75AE1898
	private Void PushParsingState() { }

	// RVA: 0xFFFFFFFF75AE3498
	private Void PopParsingState() { }

	// RVA: 0xFFFFFFFF75AEACFC
	private Int32 IncrementalRead() { }

	// RVA: 0xFFFFFFFF75ADE524
	private Void FinishIncrementalRead() { }

	// RVA: 0xFFFFFFFF75ADE5C4
	private Boolean ParseFragmentAttribute() { }

	// RVA: 0xFFFFFFFF75ADECDC
	private Boolean ParseAttributeValueChunk() { }

	// RVA: 0xFFFFFFFF75ADE650
	private Void ParseXmlDeclarationFragment() { }

	// RVA: 0xFFFFFFFF75AE3704
	private Void ThrowUnexpectedToken(Int32 pos, String expectedToken) { }

	// RVA: 0xFFFFFFFF75AE3548
	private Void ThrowUnexpectedToken(String expectedToken1) { }

	// RVA: 0xFFFFFFFF75AE39B4
	private Void ThrowUnexpectedToken(Int32 pos, String expectedToken1, String expectedToken2) { }

	// RVA: 0xFFFFFFFF75AE3580
	private Void ThrowUnexpectedToken(String expectedToken1, String expectedToken2) { }

	// RVA: 0xFFFFFFFF75AE39AC
	private String ParseUnexpectedToken(Int32 pos) { }

	// RVA: 0xFFFFFFFF75AEB618
	private String ParseUnexpectedToken() { }

	// RVA: 0xFFFFFFFF75AE6644
	private Void ThrowExpectingWhitespace(Int32 pos) { }

	// RVA: 0xFFFFFFFF75ADC2E4
	private Int32 GetIndexOfAttributeWithoutPrefix(String name) { }

	// RVA: 0xFFFFFFFF75ADC3DC
	private Int32 GetIndexOfAttributeWithPrefix(String name) { }

	// RVA: 0xFFFFFFFF75AE83B8
	private Boolean ZeroEndingStream(Int32 pos) { }

	// RVA: 0xFFFFFFFF75AE2998
	private Void ParseDtdFromParserContext() { }

	// RVA: 0xFFFFFFFF75AE8448
	private Boolean MoveToNextContentNode(Boolean moveIfOnContentNode) { }

	// RVA: 0xFFFFFFFF75AEB6F8
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0xFFFFFFFF75AD3F7C
	internal Void SetDtdInfo(IDtdInfo newDtdInfo) { }

	// RVA: 0xFFFFFFFF75AD3EAC
	internal Void set_XmlValidatingReaderCompatibilityMode(Boolean value) { }

	// RVA: 0xFFFFFFFF75AE5D0C
	private Boolean AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, Boolean definedInDtd, NodeData[] nameSortedNodeData) { }

	// RVA: 0xFFFFFFFF75AEB700
	private NodeData AddDefaultAttributeInternal(String localName, String ns, String prefix, String value, Int32 lineNo, Int32 linePos, Int32 valueLineNo, Int32 valueLinePos, Boolean isXmlAttribute) { }

	// RVA: 0xFFFFFFFF75AEB990
	internal Void set_DisableUndeclaredEntityCheck(Boolean value) { }

	// RVA: 0xFFFFFFFF75AE19D0
	private Void RegisterConsumedCharacters(Int64 characters, Boolean inEntityReference) { }

	// RVA: 0xFFFFFFFF75AEB998
	internal static String StripSpaces(String value) { }

	// RVA: 0xFFFFFFFF75AEBB98
	internal static Void StripSpaces(Char[] value, Int32 index, ref Int32 len) { }

	// RVA: 0xFFFFFFFF75AE31C0
	internal static Void BlockCopyChars(Char[] src, Int32 srcOffset, Char[] dst, Int32 dstOffset, Int32 count) { }

	// RVA: 0xFFFFFFFF75AE31D4
	internal static Void BlockCopy(Byte[] src, Int32 srcOffset, Byte[] dst, Int32 dstOffset, Int32 count) { }

}

// Namespace: 
private enum ParsingFunction
{
	// Fields
	public Int32 value__; // 0x10
	public const ParsingFunction ElementContent = 0;
	public const ParsingFunction NoData = 1;
	public const ParsingFunction OpenUrl = 2;
	public const ParsingFunction SwitchToInteractive = 3;
	public const ParsingFunction SwitchToInteractiveXmlDecl = 4;
	public const ParsingFunction DocumentContent = 5;
	public const ParsingFunction MoveToElementContent = 6;
	public const ParsingFunction PopElementContext = 7;
	public const ParsingFunction PopEmptyElementContext = 8;
	public const ParsingFunction ResetAttributesRootLevel = 9;
	public const ParsingFunction Error = 10;
	public const ParsingFunction Eof = 11;
	public const ParsingFunction ReaderClosed = 12;
	public const ParsingFunction EntityReference = 13;
	public const ParsingFunction InIncrementalRead = 14;
	public const ParsingFunction FragmentAttribute = 15;
	public const ParsingFunction ReportEndEntity = 16;
	public const ParsingFunction AfterResolveEntityInContent = 17;
	public const ParsingFunction AfterResolveEmptyEntityInContent = 18;
	public const ParsingFunction XmlDeclarationFragment = 19;
	public const ParsingFunction GoToEof = 20;
	public const ParsingFunction PartialTextValue = 21;
	public const ParsingFunction InReadAttributeValue = 22;
	public const ParsingFunction InReadValueChunk = 23;
	public const ParsingFunction InReadContentAsBinary = 24;
	public const ParsingFunction InReadElementContentAsBinary = 25;
}

// Namespace: 
private enum ParsingMode
{
	// Fields
	public Int32 value__; // 0x10
	public const ParsingMode Full = 0;
	public const ParsingMode SkipNode = 1;
	public const ParsingMode SkipContent = 2;
}

// Namespace: 
private enum EntityType
{
	// Fields
	public Int32 value__; // 0x10
	public const EntityType CharacterDec = 0;
	public const EntityType CharacterHex = 1;
	public const EntityType CharacterNamed = 2;
	public const EntityType Expanded = 3;
	public const EntityType Skipped = 4;
	public const EntityType FakeExpanded = 5;
	public const EntityType Unexpanded = 6;
	public const EntityType ExpandedInAttribute = 7;
}

// Namespace: 
private enum EntityExpandType
{
	// Fields
	public Int32 value__; // 0x10
	public const EntityExpandType All = 0;
	public const EntityExpandType OnlyGeneral = 1;
	public const EntityExpandType OnlyCharacter = 2;
}

// Namespace: 
private enum IncrementalReadState
{
	// Fields
	public Int32 value__; // 0x10
	public const IncrementalReadState Text = 0;
	public const IncrementalReadState StartTag = 1;
	public const IncrementalReadState PI = 2;
	public const IncrementalReadState CDATA = 3;
	public const IncrementalReadState Comment = 4;
	public const IncrementalReadState Attributes = 5;
	public const IncrementalReadState AttributeValue = 6;
	public const IncrementalReadState ReadData = 7;
	public const IncrementalReadState EndElement = 8;
	public const IncrementalReadState End = 9;
	public const IncrementalReadState ReadValueChunk_OnCachedValue = 10;
	public const IncrementalReadState ReadValueChunk_OnPartialValue = 11;
	public const IncrementalReadState ReadContentAsBinary_OnCachedValue = 12;
	public const IncrementalReadState ReadContentAsBinary_OnPartialValue = 13;
	public const IncrementalReadState ReadContentAsBinary_End = 14;
}

// Namespace: 
private class LaterInitParam
{
	// Fields
	public Boolean useAsync; // 0x10
	public Stream inputStream; // 0x18
	public Byte[] inputBytes; // 0x20
	public Int32 inputByteCount; // 0x28
	public Uri inputbaseUri; // 0x30
	public String inputUriStr; // 0x38
	public XmlResolver inputUriResolver; // 0x40
	public XmlParserContext inputContext; // 0x48
	public TextReader inputTextReader; // 0x50
	public InitInputType initType; // 0x58
}

// Namespace: 
private enum InitInputType
{
	// Fields
	public Int32 value__; // 0x10
	public const InitInputType UriString = 0;
	public const InitInputType Stream = 1;
	public const InitInputType TextReader = 2;
	public const InitInputType Invalid = 3;
}

// Namespace: 
private struct ParsingState
{
	// Fields
	internal Char[] chars; // 0x10
	internal Int32 charPos; // 0x18
	internal Int32 charsUsed; // 0x1C
	internal Encoding encoding; // 0x20
	internal Boolean appendMode; // 0x28
	internal Stream stream; // 0x30
	internal Decoder decoder; // 0x38
	internal Byte[] bytes; // 0x40
	internal Int32 bytePos; // 0x48
	internal Int32 bytesUsed; // 0x4C
	internal TextReader textReader; // 0x50
	internal Int32 lineNo; // 0x58
	internal Int32 lineStartPos; // 0x5C
	internal String baseUriStr; // 0x60
	internal Uri baseUri; // 0x68
	internal Boolean isEof; // 0x70
	internal Boolean isStreamEof; // 0x71
	internal IDtdEntityInfo entity; // 0x78
	internal Int32 entityId; // 0x80
	internal Boolean eolNormalized; // 0x84
	internal Boolean entityResolvedManually; // 0x85

	// Properties
	internal Int32 LineNo { get; }
	internal Int32 LinePos { get; }

	// Methods

	// RVA: 0xFFFFFFFF71145DB8
	internal Void Clear() { }

	// RVA: 0xFFFFFFFF71145DC0
	internal Void Close(Boolean closeInput) { }

	// RVA: 0xFFFFFFFF71145DF8
	internal Int32 get_LineNo() { }

	// RVA: 0xFFFFFFFF71145E00
	internal Int32 get_LinePos() { }

}

// Namespace: 
private class XmlContext
{
	// Fields
	internal XmlSpace xmlSpace; // 0x10
	internal String xmlLang; // 0x18
	internal String defaultNamespace; // 0x20
	internal XmlContext previousContext; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75AED38C
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75AED428
	internal Void .ctor(XmlContext previousContext) { }

}

// Namespace: 
private class NoNamespaceManager
{
	// Properties
	public override String DefaultNamespace { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AEC4D8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AEC4E0
	public override String get_DefaultNamespace() { }

	// RVA: 0xFFFFFFFF75AEC4F4
	public override Void PushScope() { }

	// RVA: 0xFFFFFFFF75AEC4F8
	public override Boolean PopScope() { }

	// RVA: 0xFFFFFFFF75AEC500
	public override Void AddNamespace(String prefix, String uri) { }

	// RVA: 0xFFFFFFFF75AEC504
	public override IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75AEC50C
	public override String LookupNamespace(String prefix) { }

	// RVA: 0xFFFFFFFF75AEC520
	public override String LookupPrefix(String uri) { }

}

// Namespace: 
internal class DtdParserProxy
{
	// Fields
	private XmlTextReaderImpl reader; // 0x10

	// Properties
	private XmlNameTable System.Xml.IDtdParserAdapter.NameTable { get; }
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.NamespaceResolver { get; }
	private Uri System.Xml.IDtdParserAdapter.BaseUri { get; }
	private Boolean System.Xml.IDtdParserAdapter.IsEof { get; }
	private Char[] System.Xml.IDtdParserAdapter.ParsingBuffer { get; }
	private Int32 System.Xml.IDtdParserAdapter.ParsingBufferLength { get; }
	private Int32 System.Xml.IDtdParserAdapter.CurrentPosition { get; set; }
	private Int32 System.Xml.IDtdParserAdapter.EntityStackLength { get; }
	private Boolean System.Xml.IDtdParserAdapter.IsEntityEolNormalized { get; }
	private Int32 System.Xml.IDtdParserAdapter.LineNo { get; }
	private Int32 System.Xml.IDtdParserAdapter.LineStartPosition { get; }
	private Boolean System.Xml.IDtdParserAdapterWithValidation.DtdValidation { get; }
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.ValidationEventHandling { get; }
	private Boolean System.Xml.IDtdParserAdapterV1.Normalization { get; }
	private Boolean System.Xml.IDtdParserAdapterV1.Namespaces { get; }
	private Boolean System.Xml.IDtdParserAdapterV1.V1CompatibilityMode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AEC0E0
	internal Void .ctor(XmlTextReaderImpl reader) { }

	// RVA: 0xFFFFFFFF75AEC118
	private XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

	// RVA: 0xFFFFFFFF75AEC138
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

	// RVA: 0xFFFFFFFF75AEC158
	private Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

	// RVA: 0xFFFFFFFF75AEC178
	private Boolean System.Xml.IDtdParserAdapter.get_IsEof() { }

	// RVA: 0xFFFFFFFF75AEC198
	private Char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

	// RVA: 0xFFFFFFFF75AEC1B8
	private Int32 System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

	// RVA: 0xFFFFFFFF75AEC1D8
	private Int32 System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75AEC1F8
	private Void System.Xml.IDtdParserAdapter.set_CurrentPosition(Int32 value) { }

	// RVA: 0xFFFFFFFF75AEC218
	private Int32 System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

	// RVA: 0xFFFFFFFF75AEC238
	private Boolean System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

	// RVA: 0xFFFFFFFF75AEC258
	private Void System.Xml.IDtdParserAdapter.OnNewLine(Int32 pos) { }

	// RVA: 0xFFFFFFFF75AEC278
	private Int32 System.Xml.IDtdParserAdapter.get_LineNo() { }

	// RVA: 0xFFFFFFFF75AEC298
	private Int32 System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

	// RVA: 0xFFFFFFFF75AEC2B8
	private Int32 System.Xml.IDtdParserAdapter.ReadData() { }

	// RVA: 0xFFFFFFFF75AEC2D8
	private Int32 System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0xFFFFFFFF75AEC2F8
	private Int32 System.Xml.IDtdParserAdapter.ParseNamedCharRef(Boolean expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0xFFFFFFFF75AEC318
	private Void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

	// RVA: 0xFFFFFFFF75AEC338
	private Void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

	// RVA: 0xFFFFFFFF75AEC358
	private Boolean System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, out Int32 entityId) { }

	// RVA: 0xFFFFFFFF75AEC378
	private Boolean System.Xml.IDtdParserAdapter.PopEntity(out IDtdEntityInfo oldEntity, out Int32 newEntityId) { }

	// RVA: 0xFFFFFFFF75AEC398
	private Boolean System.Xml.IDtdParserAdapter.PushExternalSubset(String systemId, String publicId) { }

	// RVA: 0xFFFFFFFF75AEC3B8
	private Void System.Xml.IDtdParserAdapter.PushInternalDtd(String baseUri, String internalDtd) { }

	// RVA: 0xFFFFFFFF75AEC3D8
	private Void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

	// RVA: 0xFFFFFFFF75AEC3F8
	private Void System.Xml.IDtdParserAdapter.OnSystemId(String systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0xFFFFFFFF75AEC418
	private Void System.Xml.IDtdParserAdapter.OnPublicId(String publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0xFFFFFFFF75AEC438
	private Boolean System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

	// RVA: 0xFFFFFFFF75AEC458
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

	// RVA: 0xFFFFFFFF75AEC478
	private Boolean System.Xml.IDtdParserAdapterV1.get_Normalization() { }

	// RVA: 0xFFFFFFFF75AEC498
	private Boolean System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

	// RVA: 0xFFFFFFFF75AEC4B8
	private Boolean System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode() { }

}

// Namespace: 
private class NodeData
{
	// Fields
	private static NodeData s_None; // 0x0
	internal XmlNodeType type; // 0x10
	internal String localName; // 0x18
	internal String prefix; // 0x20
	internal String ns; // 0x28
	internal String nameWPrefix; // 0x30
	private String value; // 0x38
	private Char[] chars; // 0x40
	private Int32 valueStartPos; // 0x48
	private Int32 valueLength; // 0x4C
	internal LineInfo lineInfo; // 0x50
	internal LineInfo lineInfo2; // 0x58
	internal Char quoteChar; // 0x60
	internal Int32 depth; // 0x64
	private Boolean isEmptyOrDefault; // 0x68
	internal Int32 entityId; // 0x6C
	internal Boolean xmlContextPushed; // 0x70
	internal NodeData nextAttrValueChunk; // 0x78
	internal Object schemaType; // 0x80
	internal Object typedValue; // 0x88

	// Properties
	internal static NodeData None { get; }
	internal Int32 LineNo { get; }
	internal Int32 LinePos { get; }
	internal Boolean IsEmptyElement { get; set; }
	internal Boolean IsDefaultAttribute { get; set; }
	internal Boolean ValueBuffered { get; }
	internal String StringValue { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AEC528
	internal static NodeData get_None() { }

	// RVA: 0xFFFFFFFF75AEC5CC
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75AEC6B8
	internal Int32 get_LineNo() { }

	// RVA: 0xFFFFFFFF75AEC6C0
	internal Int32 get_LinePos() { }

	// RVA: 0xFFFFFFFF75AEC6C8
	internal Boolean get_IsEmptyElement() { }

	// RVA: 0xFFFFFFFF75AEC6EC
	internal Void set_IsEmptyElement(Boolean value) { }

	// RVA: 0xFFFFFFFF75AEC6F4
	internal Boolean get_IsDefaultAttribute() { }

	// RVA: 0xFFFFFFFF75AEC718
	internal Void set_IsDefaultAttribute(Boolean value) { }

	// RVA: 0xFFFFFFFF75AEC720
	internal Boolean get_ValueBuffered() { }

	// RVA: 0xFFFFFFFF75AEC730
	internal String get_StringValue() { }

	// RVA: 0xFFFFFFFF75AEC788
	internal Void TrimSpacesInValue() { }

	// RVA: 0xFFFFFFFF75AEC5F4
	internal Void Clear(XmlNodeType type) { }

	// RVA: 0xFFFFFFFF75AEC7F4
	internal Void ClearName() { }

	// RVA: 0xFFFFFFFF75AEC8C0
	internal Void SetLineInfo(Int32 lineNo, Int32 linePos) { }

	// RVA: 0xFFFFFFFF75AEC8CC
	internal Void SetLineInfo2(Int32 lineNo, Int32 linePos) { }

	// RVA: 0xFFFFFFFF75AEC8D8
	internal Void SetValueNode(XmlNodeType type, String value) { }

	// RVA: 0xFFFFFFFF75AEC92C
	internal Void SetValueNode(XmlNodeType type, Char[] chars, Int32 startPos, Int32 len) { }

	// RVA: 0xFFFFFFFF75AEC9A8
	internal Void SetNamedNode(XmlNodeType type, String localName) { }

	// RVA: 0xFFFFFFFF75AEC9C0
	internal Void SetNamedNode(XmlNodeType type, String localName, String prefix, String nameWPrefix) { }

	// RVA: 0xFFFFFFFF75AECAA0
	internal Void SetValue(String value) { }

	// RVA: 0xFFFFFFFF75AECAE0
	internal Void SetValue(Char[] chars, Int32 startPos, Int32 len) { }

	// RVA: 0xFFFFFFFF75AECB54
	internal Void OnBufferInvalidated() { }

	// RVA: 0xFFFFFFFF75AECBB0
	internal Void CopyTo(Int32 valueOffset, StringBuilder sb) { }

	// RVA: 0xFFFFFFFF75AECC2C
	internal String GetNameWPrefix(XmlNameTable nt) { }

	// RVA: 0xFFFFFFFF75AECC40
	internal String CreateNameWPrefix(XmlNameTable nt) { }

	// RVA: 0xFFFFFFFF75AECCD0
	private Int32 System.IComparable.CompareTo(Object obj) { }

}

// Namespace: 
private class DtdDefaultAttributeInfoToNodeDataComparer
{
	// Fields
	private static IComparer<T0> s_instance; // 0x0

	// Properties
	internal static IComparer<T0> Instance { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AEBCD8
	internal static IComparer<T0> get_Instance() { }

	// RVA: 0xFFFFFFFF75AEBD38
	public Int32 Compare(Object x, Object y) { }

	// RVA: 0xFFFFFFFF75AEC074
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AEC078
	private static Void .cctor() { }

}

// Namespace: 
internal sealed class OnDefaultAttributeUseDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75AECDAC
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75AECDF0
	public virtual Void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

	// RVA: 0xFFFFFFFF75AED1BC
	public virtual IAsyncResult BeginInvoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75AED218
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Xml
public enum Formatting
{
	// Fields
	public Int32 value__; // 0x10
	public const Formatting None = 0;
	public const Formatting Indented = 1;
}

// Namespace: System.Xml
public class XmlTextWriter
{
	// Fields
	private TextWriter textWriter; // 0x10
	private XmlTextEncoder xmlEncoder; // 0x18
	private Encoding encoding; // 0x20
	private Formatting formatting; // 0x28
	private Boolean indented; // 0x2C
	private Int32 indentation; // 0x30
	private Char indentChar; // 0x34
	private TagInfo[] stack; // 0x38
	private Int32 top; // 0x40
	private State[] stateTable; // 0x48
	private State currentState; // 0x50
	private Token lastToken; // 0x54
	private XmlTextWriterBase64Encoder base64Encoder; // 0x58
	private Char quoteChar; // 0x60
	private Char curQuoteChar; // 0x62
	private Boolean namespaces; // 0x64
	private SpecialAttr specialAttr; // 0x68
	private String prefixForXmlNs; // 0x70
	private Boolean flush; // 0x78
	private Namespace[] nsStack; // 0x80
	private Int32 nsTop; // 0x88
	private Dictionary<T0, T1> nsHashtable; // 0x90
	private Boolean useNsHashtable; // 0x98
	private XmlCharType xmlCharType; // 0xA0
	private static String[] stateName; // 0x0
	private static String[] tokenName; // 0x8
	private static readonly State[] stateTableDefault; // 0x10
	private static readonly State[] stateTableDocument; // 0x18

	// Properties
	public Formatting Formatting { set; }
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0xFFFFFFFF7236F2D8
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF7236F560
	public Void .ctor(Stream w, Encoding encoding) { }

	// RVA: 0xFFFFFFFF7236F654
	public Void .ctor(String filename, Encoding encoding) { }

	// RVA: 0xFFFFFFFF7236F6C4
	public Void set_Formatting(Formatting value) { }

	// RVA: 0xFFFFFFFF75AED4C4
	public override Void WriteDocType(String name, String pubid, String sysid, String subset) { }

	// RVA: 0xFFFFFFFF7236FD60
	public override Void WriteStartElement(String prefix, String localName, String ns) { }

	// RVA: 0xFFFFFFFF723705C8
	public override Void WriteEndElement() { }

	// RVA: 0xFFFFFFFF723708C8
	public override Void WriteFullEndElement() { }

	// RVA: 0xFFFFFFFF723708D0
	public override Void WriteStartAttribute(String prefix, String localName, String ns) { }

	// RVA: 0xFFFFFFFF72370F10
	public override Void WriteEndAttribute() { }

	// RVA: 0xFFFFFFFF75AEDD48
	public override Void WriteCData(String text) { }

	// RVA: 0xFFFFFFFF75AEDF18
	public override Void WriteComment(String text) { }

	// RVA: 0xFFFFFFFF72370FC0
	public override Void WriteProcessingInstruction(String name, String text) { }

	// RVA: 0xFFFFFFFF75AEE110
	public override Void WriteEntityRef(String name) { }

	// RVA: 0xFFFFFFFF75AEE218
	public override Void WriteWhitespace(String ws) { }

	// RVA: 0xFFFFFFFF72371270
	public override Void WriteString(String text) { }

	// RVA: 0xFFFFFFFF75AEE394
	public override WriteState get_WriteState() { }

	// RVA: 0xFFFFFFFF72371350
	public override Void Close() { }

	// RVA: 0xFFFFFFFF72371528
	public override Void Flush() { }

	// RVA: 0xFFFFFFFF7236F870
	private Void AutoComplete(Token token) { }

	// RVA: 0xFFFFFFFF723714B4
	private Void AutoCompleteAll() { }

	// RVA: 0xFFFFFFFF723705D0
	private Void InternalWriteEndElement(Boolean longFormat) { }

	// RVA: 0xFFFFFFFF723716F4
	private Void WriteEndStartTag(Boolean empty) { }

	// RVA: 0xFFFFFFFF72371698
	private Void WriteEndAttributeQuote() { }

	// RVA: 0xFFFFFFFF72371550
	private Void Indent(Boolean beforeEndElement) { }

	// RVA: 0xFFFFFFFF72370388
	private Void PushNamespace(String prefix, String ns, Boolean declared) { }

	// RVA: 0xFFFFFFFF75AEE6A4
	private Void AddNamespace(String prefix, String ns, Boolean declared) { }

	// RVA: 0xFFFFFFFF75AEE9B8
	private Void AddToNamespaceHashtable(Int32 namespaceIndex) { }

	// RVA: 0xFFFFFFFF75AEE3E8
	private Void PopNamespaces(Int32 indexFrom, Int32 indexTo) { }

	// RVA: 0xFFFFFFFF75AEDC48
	private String GeneratePrefix() { }

	// RVA: 0xFFFFFFFF723711B0
	private Void InternalWriteProcessingInstruction(String name, String text) { }

	// RVA: 0xFFFFFFFF75AED834
	private Int32 LookupNamespace(String prefix) { }

	// RVA: 0xFFFFFFFF75AEDB24
	private Int32 LookupNamespaceInCurrentScope(String prefix) { }

	// RVA: 0xFFFFFFFF75AED904
	private String FindPrefix(String ns) { }

	// RVA: 0xFFFFFFFF7236F6D8
	private Void ValidateName(String name, Boolean isNCName) { }

	// RVA: 0xFFFFFFFF75AEE4A0
	private Void HandleSpecialAttribute() { }

	// RVA: 0xFFFFFFFF75AED9D8
	private Void VerifyPrefixXml(String prefix, String ns) { }

	// RVA: 0xFFFFFFFF72370214
	private Void PushStack() { }

	// RVA: 0xFFFFFFFF75AEE3B8
	private Void FlushEncoders() { }

	// RVA: 0xFFFFFFFF75AEEA78
	private static Void .cctor() { }

}

// Namespace: 
private enum NamespaceState
{
	// Fields
	public Int32 value__; // 0x10
	public const NamespaceState Uninitialized = 0;
	public const NamespaceState NotDeclaredButInScope = 1;
	public const NamespaceState DeclaredButNotWrittenOut = 2;
	public const NamespaceState DeclaredAndWrittenOut = 3;
}

// Namespace: 
private struct TagInfo
{
	// Fields
	internal String name; // 0x10
	internal String prefix; // 0x18
	internal String defaultNs; // 0x20
	internal NamespaceState defaultNsState; // 0x28
	internal XmlSpace xmlSpace; // 0x2C
	internal String xmlLang; // 0x30
	internal Int32 prevNsTop; // 0x38
	internal Int32 prefixCount; // 0x3C
	internal Boolean mixed; // 0x40

	// Methods

	// RVA: 0xFFFFFFFF71146100
	internal Void Init(Int32 nsTop) { }

}

// Namespace: 
private struct Namespace
{
	// Fields
	internal String prefix; // 0x10
	internal String ns; // 0x18
	internal Boolean declared; // 0x20
	internal Int32 prevNsIndex; // 0x24

	// Methods

	// RVA: 0xFFFFFFFF71145F08
	internal Void Set(String prefix, String ns, Boolean declared) { }

}

// Namespace: 
private enum SpecialAttr
{
	// Fields
	public Int32 value__; // 0x10
	public const SpecialAttr None = 0;
	public const SpecialAttr XmlSpace = 1;
	public const SpecialAttr XmlLang = 2;
	public const SpecialAttr XmlNs = 3;
}

// Namespace: 
private enum State
{
	// Fields
	public Int32 value__; // 0x10
	public const State Start = 0;
	public const State Prolog = 1;
	public const State PostDTD = 2;
	public const State Element = 3;
	public const State Attribute = 4;
	public const State Content = 5;
	public const State AttrOnly = 6;
	public const State Epilog = 7;
	public const State Error = 8;
	public const State Closed = 9;
}

// Namespace: 
private enum Token
{
	// Fields
	public Int32 value__; // 0x10
	public const Token PI = 0;
	public const Token Doctype = 1;
	public const Token Comment = 2;
	public const Token CData = 3;
	public const Token StartElement = 4;
	public const Token EndElement = 5;
	public const Token LongEndElement = 6;
	public const Token StartAttribute = 7;
	public const Token EndAttribute = 8;
	public const Token Content = 9;
	public const Token Base64 = 10;
	public const Token RawData = 11;
	public const Token Whitespace = 12;
	public const Token Empty = 13;
}

// Namespace: System.Xml
public enum WriteState
{
	// Fields
	public Int32 value__; // 0x10
	public const WriteState Start = 0;
	public const WriteState Prolog = 1;
	public const WriteState Element = 2;
	public const WriteState Attribute = 3;
	public const WriteState Content = 4;
	public const WriteState Closed = 5;
	public const WriteState Error = 6;
}

// Namespace: System.Xml
public abstract class XmlWriter
{
	// Properties
	public abstract WriteState WriteState { get; }

	// Methods

	// RVA: -1
	public abstract Void WriteDocType(String name, String pubid, String sysid, String subset) { }

	// RVA: -1
	public abstract Void WriteStartElement(String prefix, String localName, String ns) { }

	// RVA: -1
	public abstract Void WriteEndElement() { }

	// RVA: -1
	public abstract Void WriteFullEndElement() { }

	// RVA: -1
	public abstract Void WriteStartAttribute(String prefix, String localName, String ns) { }

	// RVA: -1
	public abstract Void WriteEndAttribute() { }

	// RVA: -1
	public abstract Void WriteCData(String text) { }

	// RVA: -1
	public abstract Void WriteComment(String text) { }

	// RVA: -1
	public abstract Void WriteProcessingInstruction(String name, String text) { }

	// RVA: -1
	public abstract Void WriteEntityRef(String name) { }

	// RVA: -1
	public abstract Void WriteWhitespace(String ws) { }

	// RVA: -1
	public abstract Void WriteString(String text) { }

	// RVA: -1
	public abstract WriteState get_WriteState() { }

	// RVA: 0xFFFFFFFF75AEFC00
	public virtual Void Close() { }

	// RVA: -1
	public abstract Void Flush() { }

	// RVA: 0xFFFFFFFF75AEFC04
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF75AEFC18
	protected virtual Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75AED4C0
	protected Void .ctor() { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNavigator
{
	// Fields
	private XmlDocument document; // 0x10
	private XmlNode source; // 0x18
	private Int32 attributeIndex; // 0x20
	private XmlElement namespaceParent; // 0x28

	// Properties
	public override XmlNameTable NameTable { get; }
	public override XPathNodeType NodeType { get; }
	public override String LocalName { get; }
	public override String NamespaceURI { get; }
	public override String Name { get; }
	public override String Prefix { get; }
	public override String Value { get; }
	private String ValueDocument { get; }
	private String ValueText { get; }
	public override String BaseURI { get; }
	public override String XmlLang { get; }
	public override Object UnderlyingObject { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A72F60
	public Void .ctor(XmlDocument document, XmlNode node) { }

	// RVA: 0xFFFFFFFF75A73138
	public Void .ctor(DocumentXPathNavigator other) { }

	// RVA: 0xFFFFFFFF75A7321C
	public override XPathNavigator Clone() { }

	// RVA: 0xFFFFFFFF75A73274
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xFFFFFFFF75A7329C
	public override XPathNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF75A73320
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF75A73348
	public override String get_NamespaceURI() { }

	// RVA: 0xFFFFFFFF75A733E0
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF75A734E4
	public override String get_Prefix() { }

	// RVA: 0xFFFFFFFF75A7357C
	public override String get_Value() { }

	// RVA: 0xFFFFFFFF75A73624
	private String get_ValueDocument() { }

	// RVA: 0xFFFFFFFF75A73670
	private String get_ValueText() { }

	// RVA: 0xFFFFFFFF75A737CC
	public override String get_BaseURI() { }

	// RVA: 0xFFFFFFFF75A737F4
	public override String get_XmlLang() { }

	// RVA: 0xFFFFFFFF75A7381C
	public override Object get_UnderlyingObject() { }

	// RVA: 0xFFFFFFFF75A73840
	public override Boolean MoveToAttribute(String localName, String namespaceURI) { }

	// RVA: 0xFFFFFFFF75A739C8
	public override Boolean MoveToFirstAttribute() { }

	// RVA: 0xFFFFFFFF75A73AF8
	public override Boolean MoveToNextAttribute() { }

	// RVA: 0xFFFFFFFF75A73DFC
	public override Boolean MoveToNamespace(String name) { }

	// RVA: 0xFFFFFFFF75A7400C
	public override Boolean MoveToFirstNamespace(XPathNamespaceScope scope) { }

	// RVA: 0xFFFFFFFF75A74264
	private static Boolean MoveToFirstNamespaceLocal(XmlAttributeCollection attributes, ref Int32 index) { }

	// RVA: 0xFFFFFFFF75A742DC
	private static Boolean MoveToFirstNamespaceGlobal(ref XmlAttributeCollection attributes, ref Int32 index) { }

	// RVA: 0xFFFFFFFF75A7455C
	public override Boolean MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0xFFFFFFFF75A74860
	private static Boolean MoveToNextNamespaceLocal(XmlAttributeCollection attributes, ref Int32 index) { }

	// RVA: 0xFFFFFFFF75A7441C
	private static Boolean MoveToNextNamespaceGlobal(ref XmlAttributeCollection attributes, ref Int32 index) { }

	// RVA: 0xFFFFFFFF75A748C8
	private Boolean PathHasDuplicateNamespace(XmlElement top, XmlElement bottom, String localName) { }

	// RVA: 0xFFFFFFFF75A7499C
	public override String LookupNamespace(String prefix) { }

	// RVA: 0xFFFFFFFF75A74A00
	public override Boolean MoveToNext() { }

	// RVA: 0xFFFFFFFF75A74C94
	public override Boolean MoveToFirstChild() { }

	// RVA: 0xFFFFFFFF75A74DF4
	public override Boolean MoveToParent() { }

	// RVA: 0xFFFFFFFF75A74EDC
	public override Void MoveToRoot() { }

	// RVA: 0xFFFFFFFF75A74FD8
	public override Boolean MoveTo(XPathNavigator other) { }

	// RVA: 0xFFFFFFFF75A75098
	public override Boolean MoveToId(String id) { }

	// RVA: 0xFFFFFFFF75A7511C
	public override Boolean MoveToChild(String localName, String namespaceUri) { }

	// RVA: 0xFFFFFFFF75A75230
	public override Boolean MoveToChild(XPathNodeType type) { }

	// RVA: 0xFFFFFFFF75A75340
	public override Boolean MoveToFollowing(String localName, String namespaceUri, XPathNavigator end) { }

	// RVA: 0xFFFFFFFF75A75598
	public override Boolean MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0xFFFFFFFF75A75818
	public override Boolean MoveToNext(String localName, String namespaceUri) { }

	// RVA: 0xFFFFFFFF75A758F8
	public override Boolean MoveToNext(XPathNodeType type) { }

	// RVA: 0xFFFFFFFF75A75A30
	public override Boolean IsSamePosition(XPathNavigator other) { }

	// RVA: 0xFFFFFFFF75A75AC8
	public override Boolean IsDescendant(XPathNavigator other) { }

	// RVA: 0xFFFFFFFF75A75BF0
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xFFFFFFFF75A75C18
	private static XmlNode OwnerNode(XmlNode node) { }

	// RVA: 0xFFFFFFFF75A75CA0
	private static Int32 GetDepth(XmlNode node) { }

	// RVA: 0xFFFFFFFF75A75CD4
	private XmlNodeOrder Compare(XmlNode node1, XmlNode node2) { }

	// RVA: 0xFFFFFFFF75A75E9C
	public override XmlNodeOrder ComparePosition(XPathNavigator other) { }

	// RVA: 0xFFFFFFFF75A760EC
	private XmlNode System.Xml.IHasXmlNode.GetNode() { }

	// RVA: 0xFFFFFFFF75A760F4
	public override XPathNodeIterator SelectDescendants(String localName, String namespaceURI, Boolean matchSelf) { }

	// RVA: 0xFFFFFFFF75A76470
	public override XPathNodeIterator SelectDescendants(XPathNodeType nt, Boolean includeSelf) { }

	// RVA: 0xFFFFFFFF75A72FF8
	internal Void ResetPosition(XmlNode node) { }

	// RVA: 0xFFFFFFFF75A73D50
	private static Boolean ResetAttributePosition(XmlAttribute attribute, XmlAttributeCollection attributes, out Int32 index) { }

	// RVA: 0xFFFFFFFF75A73C80
	private static Boolean CheckAttributePosition(XmlAttribute attribute, out XmlAttributeCollection attributes, Int32 index) { }

	// RVA: 0xFFFFFFFF75A732D4
	private Void CalibrateText() { }

	// RVA: 0xFFFFFFFF75A74B40
	private XmlNode ParentNode(XmlNode node) { }

	// RVA: 0xFFFFFFFF75A765D4
	private XmlNode ParentNodeTail(XmlNode parent) { }

	// RVA: 0xFFFFFFFF75A74D64
	private XmlNode FirstChild(XmlNode node) { }

	// RVA: 0xFFFFFFFF75A76630
	private XmlNode FirstChildTail(XmlNode child) { }

	// RVA: 0xFFFFFFFF75A7376C
	private XmlNode NextSibling(XmlNode node) { }

	// RVA: 0xFFFFFFFF75A7668C
	private XmlNode NextSiblingTail(XmlNode node, XmlNode sibling) { }

	// RVA: 0xFFFFFFFF75A76574
	private XmlNode PreviousText(XmlNode node) { }

	// RVA: 0xFFFFFFFF75A76750
	private XmlNode PreviousTextTail(XmlNode node, XmlNode text) { }

	// RVA: 0xFFFFFFFF75A75B44
	private static Boolean IsDescendant(XmlNode top, XmlNode bottom) { }

	// RVA: 0xFFFFFFFF75A74BD0
	private static Boolean IsValidChild(XmlNode parent, XmlNode child) { }

	// RVA: 0xFFFFFFFF75A74AE8
	private XmlNode TextEnd(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_Empty
{
	// Fields
	private XPathNavigator nav; // 0x18

	// Properties
	public override XPathNavigator Current { get; }
	public override Int32 CurrentPosition { get; }
	public override Int32 Count { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A762B8
	internal Void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0xFFFFFFFF75A7725C
	internal Void .ctor(DocumentXPathNodeIterator_Empty other) { }

	// RVA: 0xFFFFFFFF75A772C0
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A77318
	public override Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75A77320
	public override XPathNavigator get_Current() { }

	// RVA: 0xFFFFFFFF75A77328
	public override Int32 get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75A77330
	public override Int32 get_Count() { }

}

// Namespace: System.Xml
internal abstract class DocumentXPathNodeIterator_ElemDescendants
{
	// Fields
	private DocumentXPathNavigator nav; // 0x18
	private Int32 level; // 0x20
	private Int32 position; // 0x24

	// Properties
	public override XPathNavigator Current { get; }
	public override Int32 CurrentPosition { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A76868
	internal Void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0xFFFFFFFF75A76918
	internal Void .ctor(DocumentXPathNodeIterator_ElemDescendants other) { }

	// RVA: -1
	protected abstract Boolean Match(XmlNode node) { }

	// RVA: 0xFFFFFFFF75A77244
	public override XPathNavigator get_Current() { }

	// RVA: 0xFFFFFFFF75A7724C
	public override Int32 get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75A77254
	protected Void SetPosition(Int32 pos) { }

	// RVA: 0xFFFFFFFF75A76BD8
	public override Boolean MoveNext() { }

}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_AllElemChildren
{
	// Methods

	// RVA: 0xFFFFFFFF75A76570
	internal Void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0xFFFFFFFF75A76914
	internal Void .ctor(DocumentXPathNodeIterator_AllElemChildren other) { }

	// RVA: 0xFFFFFFFF75A769CC
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A76A24
	protected override Boolean Match(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_AllElemChildren_AndSelf
{
	// Methods

	// RVA: 0xFFFFFFFF75A7656C
	internal Void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0xFFFFFFFF75A76A5C
	internal Void .ctor(DocumentXPathNodeIterator_AllElemChildren_AndSelf other) { }

	// RVA: 0xFFFFFFFF75A76A60
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A76AB8
	public override Boolean MoveNext() { }

}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_ElemChildren_NoLocalName
{
	// Fields
	private String nsAtom; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75A76358
	internal Void .ctor(DocumentXPathNavigator nav, String nsAtom) { }

	// RVA: 0xFFFFFFFF75A76FE4
	internal Void .ctor(DocumentXPathNodeIterator_ElemChildren_NoLocalName other) { }

	// RVA: 0xFFFFFFFF75A771A8
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A77200
	protected override Boolean Match(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName
{
	// Methods

	// RVA: 0xFFFFFFFF75A76318
	internal Void .ctor(DocumentXPathNavigator nav, String nsAtom) { }

	// RVA: 0xFFFFFFFF75A76FE0
	internal Void .ctor(DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName other) { }

	// RVA: 0xFFFFFFFF75A77030
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A77088
	public override Boolean MoveNext() { }

}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_ElemChildren
{
	// Fields
	protected String localNameAtom; // 0x28
	protected String nsAtom; // 0x30

	// Methods

	// RVA: 0xFFFFFFFF75A76404
	internal Void .ctor(DocumentXPathNavigator nav, String localNameAtom, String nsAtom) { }

	// RVA: 0xFFFFFFFF75A76D20
	internal Void .ctor(DocumentXPathNodeIterator_ElemChildren other) { }

	// RVA: 0xFFFFFFFF75A76D98
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A76DF0
	protected override Boolean Match(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_ElemChildren_AndSelf
{
	// Methods

	// RVA: 0xFFFFFFFF75A76398
	internal Void .ctor(DocumentXPathNavigator nav, String localNameAtom, String nsAtom) { }

	// RVA: 0xFFFFFFFF75A76E64
	internal Void .ctor(DocumentXPathNodeIterator_ElemChildren_AndSelf other) { }

	// RVA: 0xFFFFFFFF75A76E68
	public override XPathNodeIterator Clone() { }

	// RVA: 0xFFFFFFFF75A76EC0
	public override Boolean MoveNext() { }

}

// Namespace: System.Xml
internal class DomNameTable
{
	// Fields
	private XmlName[] entries; // 0x10
	private Int32 count; // 0x18
	private Int32 mask; // 0x1C
	private XmlDocument ownerDocument; // 0x20
	private XmlNameTable nameTable; // 0x28
	private const Int32 InitialSize = 64;

	// Methods

	// RVA: 0xFFFFFFFF72369028
	public Void .ctor(XmlDocument document) { }

	// RVA: 0xFFFFFFFF75A77338
	public XmlName GetName(String prefix, String localName, String ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xFFFFFFFF723690D0
	public XmlName AddName(String prefix, String localName, String ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xFFFFFFFF75A7747C
	private Void Grow() { }

}

// Namespace: System.Xml
internal class XPathNodeList
{
	// Fields
	private List<T0> list; // 0x10
	private XPathNodeIterator nodeIterator; // 0x18
	private Boolean done; // 0x20
	private static readonly Object[] nullparams; // 0x0

	// Properties
	public override Int32 Count { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AC1B00
	public Void .ctor(XPathNodeIterator nodeIterator) { }

	// RVA: 0xFFFFFFFF75AC1BB8
	public override Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75AC1D00
	private XmlNode GetNode(XPathNavigator n) { }

	// RVA: 0xFFFFFFFF75AC1C1C
	internal Int32 ReadUntil(Int32 index) { }

	// RVA: 0xFFFFFFFF75AC1DEC
	public override XmlNode Item(Int32 index) { }

	// RVA: 0xFFFFFFFF75AC1E90
	public override IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75AC1EEC
	private static Void .cctor() { }

}

// Namespace: System.Xml
internal class XmlNodeListEnumerator
{
	// Fields
	private XPathNodeList list; // 0x10
	private Int32 index; // 0x18
	private Boolean valid; // 0x1C

	// Properties
	public Object Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AD729C
	public Void .ctor(XPathNodeList list) { }

	// RVA: 0xFFFFFFFF75AD72E0
	public Void Reset() { }

	// RVA: 0xFFFFFFFF75AD72EC
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75AD7364
	public Object get_Current() { }

}

// Namespace: System.Xml
public class XmlAttribute
{
	// Fields
	private XmlName name; // 0x18
	private XmlLinkedNode lastChild; // 0x20

	// Properties
	internal Int32 LocalNameHash { get; }
	internal XmlName XmlName { get; set; }
	public override XmlNode ParentNode { get; }
	public override String Name { get; }
	public override String LocalName { get; }
	public override String NamespaceURI { get; }
	public override String Prefix { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlDocument OwnerDocument { get; }
	public override String Value { get; set; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override String InnerText { set; }
	internal override Boolean IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public virtual Boolean Specified { get; }
	public virtual XmlElement OwnerElement { get; }
	public override String InnerXml { set; }
	public override String BaseURI { get; }
	internal override String XmlLang { get; }
	internal override XPathNodeType XPNodeType { get; }
	internal override String XPLocalName { get; }
	internal Boolean IsNamespace { get; }

	// Methods

	// RVA: 0xFFFFFFFF72369918
	internal Void .ctor(XmlName name, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75AC1F5C
	internal Int32 get_LocalNameHash() { }

	// RVA: 0xFFFFFFFF75AC1F7C
	protected internal Void .ctor(String prefix, String localName, String namespaceURI, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75AC1FC0
	internal XmlName get_XmlName() { }

	// RVA: 0xFFFFFFFF75AC1FC8
	internal Void set_XmlName(XmlName value) { }

	// RVA: 0xFFFFFFFF75AC2000
	public override XmlNode CloneNode(Boolean deep) { }

	// RVA: 0xFFFFFFFF72369A7C
	public override XmlNode get_ParentNode() { }

	// RVA: 0xFFFFFFFF75AC20CC
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF72369A84
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF72369AA4
	public override String get_NamespaceURI() { }

	// RVA: 0xFFFFFFFF72369AC4
	public override String get_Prefix() { }

	// RVA: 0xFFFFFFFF72369AE4
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF72369AEC
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0xFFFFFFFF72369B0C
	public override String get_Value() { }

	// RVA: 0xFFFFFFFF72369B1C
	public override Void set_Value(String value) { }

	// RVA: 0xFFFFFFFF75AC20EC
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xFFFFFFFF72369B2C
	public override Void set_InnerText(String value) { }

	// RVA: 0xFFFFFFFF72369BA0
	internal Boolean PrepareOwnerElementInElementIdAttrMap() { }

	// RVA: 0xFFFFFFFF75AC20F4
	internal Void ResetOwnerElementInElementIdAttrMap(String oldInnerText) { }

	// RVA: 0xFFFFFFFF72369C60
	internal override Boolean get_IsContainer() { }

	// RVA: 0xFFFFFFFF75AC22E4
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF72369C68
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0xFFFFFFFF72369C70
	internal override Void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0xFFFFFFFF72369CA8
	internal override Boolean IsValidChildType(XmlNodeType type) { }

	// RVA: 0xFFFFFFFF75AC24A0
	public virtual Boolean get_Specified() { }

	// RVA: 0xFFFFFFFF75AC24A8
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0xFFFFFFFF72369CB8
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0xFFFFFFFF72369D40
	public virtual XmlElement get_OwnerElement() { }

	// RVA: 0xFFFFFFFF75AC2530
	public override Void set_InnerXml(String value) { }

	// RVA: 0xFFFFFFFF72369D8C
	public override Void WriteTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF72369E44
	public override Void WriteContentTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75AC25B4
	public override String get_BaseURI() { }

	// RVA: 0xFFFFFFFF72369EE8
	internal override Void SetParent(XmlNode node) { }

	// RVA: 0xFFFFFFFF75AC2628
	internal override String get_XmlLang() { }

	// RVA: 0xFFFFFFFF75AC269C
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0xFFFFFFFF75AC26EC
	internal override String get_XPLocalName() { }

	// RVA: 0xFFFFFFFF75AC26BC
	internal Boolean get_IsNamespace() { }

}

// Namespace: System.Xml
public sealed class XmlAttributeCollection
{
	// Properties
	public XmlAttribute ItemOf { get; }
	public XmlAttribute ItemOf { get; }
	public XmlAttribute ItemOf { get; }
	private Boolean System.Collections.ICollection.IsSynchronized { get; }
	private Object System.Collections.ICollection.SyncRoot { get; }
	private Int32 System.Collections.ICollection.Count { get; }

	// Methods

	// RVA: 0xFFFFFFFF72369F20
	internal Void .ctor(XmlNode parent) { }

	// RVA: 0xFFFFFFFF72369F58
	public XmlAttribute get_ItemOf(Int32 i) { }

	// RVA: 0xFFFFFFFF7236A0F8
	public XmlAttribute get_ItemOf(String name) { }

	// RVA: 0xFFFFFFFF75AC275C
	public XmlAttribute get_ItemOf(String localName, String namespaceURI) { }

	// RVA: 0xFFFFFFFF75AC2898
	public override XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0xFFFFFFFF75AC2A2C
	public XmlAttribute Append(XmlAttribute node) { }

	// RVA: 0xFFFFFFFF75AC2BC4
	public XmlAttribute Remove(XmlAttribute node) { }

	// RVA: 0xFFFFFFFF75AC2C5C
	public XmlAttribute RemoveAt(Int32 i) { }

	// RVA: 0xFFFFFFFF75AC2CEC
	public Void RemoveAll() { }

	// RVA: 0xFFFFFFFF75AC2D3C
	private Void System.Collections.ICollection.CopyTo(Array array, Int32 index) { }

	// RVA: 0xFFFFFFFF75AC2DCC
	private Boolean System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xFFFFFFFF75AC2DD4
	private Object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xFFFFFFFF75AC2DD8
	private Int32 System.Collections.ICollection.get_Count() { }

	// RVA: 0xFFFFFFFF75AC2DE0
	internal override XmlNode AddNode(XmlNode node) { }

	// RVA: 0xFFFFFFFF75AC2F90
	internal override XmlNode InsertNodeAt(Int32 i, XmlNode node) { }

	// RVA: 0xFFFFFFFF75AC3010
	internal override XmlNode RemoveNodeAt(Int32 i) { }

	// RVA: 0xFFFFFFFF75AC2B70
	internal Void Detach(XmlAttribute attr) { }

	// RVA: 0xFFFFFFFF7236A320
	internal Void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0xFFFFFFFF75AC3188
	internal Void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0xFFFFFFFF75AC2EA0
	internal Int32 RemoveDuplicateAttribute(XmlAttribute attr) { }

	// RVA: 0xFFFFFFFF75AC217C
	internal Boolean PrepareParentInElementIdAttrMap(String attrPrefix, String attrLocalName) { }

	// RVA: 0xFFFFFFFF75AC2244
	internal Void ResetParentInElementIdAttrMap(String oldVal, String newVal) { }

	// RVA: 0xFFFFFFFF7236A2AC
	internal XmlAttribute InternalAppendAttribute(XmlAttribute node) { }

}

// Namespace: System.Xml
public class XmlCDataSection
{
	// Properties
	public override String Name { get; }
	public override String LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	internal override XPathNodeType XPNodeType { get; }
	internal override Boolean IsText { get; }
	public override XmlNode PreviousText { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AC32B4
	protected internal Void .ctor(String data, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75AC32FC
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF75AC3328
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF75AC3354
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF75AC335C
	public override XmlNode get_ParentNode() { }

	// RVA: 0xFFFFFFFF75AC33EC
	public override XmlNode CloneNode(Boolean deep) { }

	// RVA: 0xFFFFFFFF75AC344C
	public override Void WriteTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75AC3494
	public override Void WriteContentTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75AC3498
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0xFFFFFFFF75AC34A0
	internal override Boolean get_IsText() { }

	// RVA: 0xFFFFFFFF75AC34A8
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
public abstract class XmlCharacterData
{
	// Fields
	private String data; // 0x20

	// Properties
	public override String Value { get; set; }
	public override String InnerText { get; set; }
	public virtual String Data { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF7236A44C
	protected internal Void .ctor(String data, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75AC3BE8
	public override String get_Value() { }

	// RVA: 0xFFFFFFFF75AC3BF8
	public override Void set_Value(String value) { }

	// RVA: 0xFFFFFFFF75AC3C08
	public override String get_InnerText() { }

	// RVA: 0xFFFFFFFF75AC3C18
	public override Void set_InnerText(String value) { }

	// RVA: 0xFFFFFFFF7236A620
	public virtual String get_Data() { }

	// RVA: 0xFFFFFFFF75AC3C28
	public virtual Void set_Data(String value) { }

	// RVA: 0xFFFFFFFF75AC3D0C
	internal Boolean CheckOnData(String data) { }

	// RVA: 0xFFFFFFFF75AC3D4C
	internal Boolean DecideXPNodeTypeForTextNodes(XmlNode node, ref XPathNodeType xnt) { }

}

// Namespace: System.Xml
internal sealed class XmlChildEnumerator
{
	// Fields
	internal XmlNode container; // 0x10
	internal XmlNode child; // 0x18
	internal Boolean isFirst; // 0x20

	// Properties
	private Object System.Collections.IEnumerator.Current { get; }
	internal XmlNode Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF7236A640
	internal Void .ctor(XmlNode container) { }

	// RVA: 0xFFFFFFFF7236A6C4
	private Boolean System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0xFFFFFFFF7236A768
	internal Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75AC3E2C
	private Void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xFFFFFFFF7236A808
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xFFFFFFFF7236A870
	internal XmlNode get_Current() { }

}

// Namespace: System.Xml
internal class XmlChildNodes
{
	// Fields
	private XmlNode container; // 0x10

	// Properties
	public override Int32 Count { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AC3E88
	public Void .ctor(XmlNode container) { }

	// RVA: 0xFFFFFFFF75AC3ECC
	public override XmlNode Item(Int32 i) { }

	// RVA: 0xFFFFFFFF75AC3F34
	public override Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75AC3F8C
	public override IEnumerator GetEnumerator() { }

}

// Namespace: System.Xml
public class XmlComment
{
	// Properties
	public override String Name { get; }
	public override String LocalName { get; }
	public override XmlNodeType NodeType { get; }
	internal override XPathNodeType XPNodeType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AC4014
	protected internal Void .ctor(String comment, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75AC405C
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF75AC4088
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF75AC40B4
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF75AC40BC
	public override XmlNode CloneNode(Boolean deep) { }

	// RVA: 0xFFFFFFFF75AC411C
	public override Void WriteTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75AC4164
	public override Void WriteContentTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75AC4168
	internal override XPathNodeType get_XPNodeType() { }

}

// Namespace: System.Xml
public class XmlDeclaration
{
	// Fields
	private String version; // 0x20
	private String encoding; // 0x28
	private String standalone; // 0x30

	// Properties
	public String Version { get; set; }
	public String Encoding { get; set; }
	public String Standalone { get; set; }
	public override String Value { get; set; }
	public override String InnerText { get; set; }
	public override String Name { get; }
	public override String LocalName { get; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0xFFFFFFFF7236A9AC
	protected internal Void .ctor(String version, String encoding, String standalone, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75AC6D48
	public String get_Version() { }

	// RVA: 0xFFFFFFFF75AC6D50
	internal Void set_Version(String value) { }

	// RVA: 0xFFFFFFFF75AC6D88
	public String get_Encoding() { }

	// RVA: 0xFFFFFFFF75AC6CBC
	public Void set_Encoding(String value) { }

	// RVA: 0xFFFFFFFF75AC6D90
	public String get_Standalone() { }

	// RVA: 0xFFFFFFFF7236AD50
	public Void set_Standalone(String value) { }

	// RVA: 0xFFFFFFFF7236AE50
	public override String get_Value() { }

	// RVA: 0xFFFFFFFF75AC6D98
	public override Void set_Value(String value) { }

	// RVA: 0xFFFFFFFF7236AE60
	public override String get_InnerText() { }

	// RVA: 0xFFFFFFFF75AC6DA8
	public override Void set_InnerText(String value) { }

	// RVA: 0xFFFFFFFF7236AFCC
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF75AC71BC
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF7236AFD8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF75AC71CC
	public override XmlNode CloneNode(Boolean deep) { }

	// RVA: 0xFFFFFFFF7236AFE0
	public override Void WriteTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75AC7214
	public override Void WriteContentTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF7236ACCC
	private Boolean IsValidXmlVersion(String ver) { }

}

// Namespace: System.Xml
public class XmlDocument
{
	// Fields
	private XmlImplementation implementation; // 0x18
	private DomNameTable domNameTable; // 0x20
	private XmlLinkedNode lastChild; // 0x28
	private XmlNamedNodeMap entities; // 0x30
	private Hashtable htElementIdMap; // 0x38
	private Hashtable htElementIDAttrDecl; // 0x40
	private SchemaInfo schemaInfo; // 0x48
	private XmlSchemaSet schemas; // 0x50
	private Boolean reportValidity; // 0x58
	private Boolean actualLoadingStatus; // 0x59
	private XmlNodeChangedEventHandler onNodeInsertingDelegate; // 0x60
	private XmlNodeChangedEventHandler onNodeInsertedDelegate; // 0x68
	private XmlNodeChangedEventHandler onNodeRemovingDelegate; // 0x70
	private XmlNodeChangedEventHandler onNodeRemovedDelegate; // 0x78
	private XmlNodeChangedEventHandler onNodeChangingDelegate; // 0x80
	private XmlNodeChangedEventHandler onNodeChangedDelegate; // 0x88
	internal Boolean fEntRefNodesPresent; // 0x90
	internal Boolean fCDataNodesPresent; // 0x91
	private Boolean preserveWhitespace; // 0x92
	private Boolean isLoading; // 0x93
	internal String strDocumentName; // 0x98
	internal String strDocumentFragmentName; // 0xA0
	internal String strCommentName; // 0xA8
	internal String strTextName; // 0xB0
	internal String strCDataSectionName; // 0xB8
	internal String strEntityName; // 0xC0
	internal String strID; // 0xC8
	internal String strXmlns; // 0xD0
	internal String strXml; // 0xD8
	internal String strSpace; // 0xE0
	internal String strLang; // 0xE8
	internal String strEmpty; // 0xF0
	internal String strNonSignificantWhitespaceName; // 0xF8
	internal String strSignificantWhitespaceName; // 0x100
	internal String strReservedXmlns; // 0x108
	internal String strReservedXml; // 0x110
	internal String baseURI; // 0x118
	private XmlResolver resolver; // 0x120
	internal Boolean bSetResolver; // 0x128
	internal Object objLock; // 0x130
	private XmlAttribute namespaceXml; // 0x138
	internal static EmptyEnumerator EmptyEnumerator; // 0x0
	internal static IXmlSchemaInfo NotKnownSchemaInfo; // 0x8
	internal static IXmlSchemaInfo ValidSchemaInfo; // 0x10
	internal static IXmlSchemaInfo InvalidSchemaInfo; // 0x18

	// Properties
	internal SchemaInfo DtdSchemaInfo { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public virtual XmlDocumentType DocumentType { get; }
	internal virtual XmlDeclaration Declaration { get; }
	public XmlImplementation Implementation { get; }
	public override String Name { get; }
	public override String LocalName { get; }
	public XmlElement DocumentElement { get; }
	internal override Boolean IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlDocument OwnerDocument { get; }
	public XmlSchemaSet Schemas { set; }
	internal Boolean CanReportValidity { get; }
	internal Boolean HasSetResolver { get; }
	public XmlNameTable NameTable { get; }
	public override Boolean IsReadOnly { get; }
	internal XmlNamedNodeMap Entities { get; set; }
	internal Boolean IsLoading { get; set; }
	internal Boolean ActualLoadingStatus { get; }
	internal Encoding TextEncoding { get; }
	public override String InnerText { set; }
	public override String InnerXml { set; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override String BaseURI { get; }
	internal override XPathNodeType XPNodeType { get; }
	internal Boolean HasEntityReferences { get; }
	internal XmlAttribute NamespaceXml { get; }

	// Methods

	// RVA: 0xFFFFFFFF7236B050
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF7236B144
	protected internal Void .ctor(XmlImplementation imp) { }

	// RVA: 0xFFFFFFFF75AC721C
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0xFFFFFFFF75AC7224
	internal Void set_DtdSchemaInfo(SchemaInfo value) { }

	// RVA: 0xFFFFFFFF7236B5DC
	internal static Void CheckName(String name) { }

	// RVA: 0xFFFFFFFF75AC72D8
	internal XmlName AddXmlName(String prefix, String localName, String namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xFFFFFFFF75AC72F8
	internal XmlName GetXmlName(String prefix, String localName, String namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xFFFFFFFF7236B67C
	internal XmlName AddAttrXmlName(String prefix, String localName, String namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xFFFFFFFF75AC7318
	internal Boolean AddIdInfo(XmlName eleName, XmlName attrName) { }

	// RVA: 0xFFFFFFFF75AC73CC
	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	// RVA: 0xFFFFFFFF7236B768
	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	// RVA: 0xFFFFFFFF75AC7470
	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	// RVA: 0xFFFFFFFF75AC79D4
	internal Void AddElementWithId(String id, XmlElement elem) { }

	// RVA: 0xFFFFFFFF75AC7B90
	internal Void RemoveElementWithId(String id, XmlElement elem) { }

	// RVA: 0xFFFFFFFF75AC7CA8
	public override XmlNode CloneNode(Boolean deep) { }

	// RVA: 0xFFFFFFFF7236B77C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF7236B784
	public override XmlNode get_ParentNode() { }

	// RVA: 0xFFFFFFFF75AC7DCC
	public virtual XmlDocumentType get_DocumentType() { }

	// RVA: 0xFFFFFFFF7236B78C
	internal virtual XmlDeclaration get_Declaration() { }

	// RVA: 0xFFFFFFFF75AC7E58
	public XmlImplementation get_Implementation() { }

	// RVA: 0xFFFFFFFF75AC7E60
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF75AC7E68
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF7236B80C
	public XmlElement get_DocumentElement() { }

	// RVA: 0xFFFFFFFF7236B868
	internal override Boolean get_IsContainer() { }

	// RVA: 0xFFFFFFFF7236B870
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0xFFFFFFFF7236B878
	internal override Void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0xFFFFFFFF7236B8B0
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0xFFFFFFFF75AC7E70
	public Void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0xFFFFFFFF75AC7EA8
	internal Boolean get_CanReportValidity() { }

	// RVA: 0xFFFFFFFF75AC7EB0
	internal Boolean get_HasSetResolver() { }

	// RVA: 0xFFFFFFFF75AC7EB8
	internal XmlResolver GetResolver() { }

	// RVA: 0xFFFFFFFF7236B8B8
	internal override Boolean IsValidChildType(XmlNodeType type) { }

	// RVA: 0xFFFFFFFF75AC7EC0
	private Boolean HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0xFFFFFFFF75AC7F84
	private Boolean HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0xFFFFFFFF7236B9D0
	internal override Boolean CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xFFFFFFFF7236BAE4
	public XmlAttribute CreateAttribute(String name) { }

	// RVA: 0xFFFFFFFF7236BCD8
	internal Void SetDefaultNamespace(String prefix, String localName, ref String namespaceURI) { }

	// RVA: 0xFFFFFFFF75AC7FF8
	public virtual XmlCDataSection CreateCDataSection(String data) { }

	// RVA: 0xFFFFFFFF75AC806C
	public virtual XmlComment CreateComment(String data) { }

	// RVA: 0xFFFFFFFF75AC80D8
	public virtual XmlDocumentType CreateDocumentType(String name, String publicId, String systemId, String internalSubset) { }

	// RVA: 0xFFFFFFFF75AC829C
	public virtual XmlDocumentFragment CreateDocumentFragment() { }

	// RVA: 0xFFFFFFFF7236BD84
	public XmlElement CreateElement(String name) { }

	// RVA: 0xFFFFFFFF7236BDF4
	internal Void AddDefaultAttributes(XmlElement elem) { }

	// RVA: 0xFFFFFFFF7236C014
	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	// RVA: 0xFFFFFFFF75AC83A0
	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, String attrPrefix, String attrLocalname, String attrNamespaceURI) { }

	// RVA: 0xFFFFFFFF75AC8538
	public virtual XmlEntityReference CreateEntityReference(String name) { }

	// RVA: 0xFFFFFFFF75AC86DC
	public virtual XmlProcessingInstruction CreateProcessingInstruction(String target, String data) { }

	// RVA: 0xFFFFFFFF7236C0EC
	public virtual XmlDeclaration CreateXmlDeclaration(String version, String encoding, String standalone) { }

	// RVA: 0xFFFFFFFF7236C14C
	public virtual XmlText CreateTextNode(String text) { }

	// RVA: 0xFFFFFFFF75AC87E0
	public virtual XmlSignificantWhitespace CreateSignificantWhitespace(String text) { }

	// RVA: 0xFFFFFFFF75AC8918
	public override XPathNavigator CreateNavigator() { }

	// RVA: 0xFFFFFFFF75AC892C
	protected internal virtual XPathNavigator CreateNavigator(XmlNode node) { }

	// RVA: 0xFFFFFFFF75AC8C6C
	internal static Boolean IsTextNode(XmlNodeType nt) { }

	// RVA: 0xFFFFFFFF75AC8AC4
	private XmlNode NormalizeText(XmlNode n) { }

	// RVA: 0xFFFFFFFF75AC8C84
	public virtual XmlWhitespace CreateWhitespace(String text) { }

	// RVA: 0xFFFFFFFF75AC8CF0
	public virtual XmlElement GetElementById(String elementId) { }

	// RVA: 0xFFFFFFFF75AC90A4
	private XmlNode ImportNodeInternal(XmlNode node, Boolean deep) { }

	// RVA: 0xFFFFFFFF75AC95A8
	private Void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	// RVA: 0xFFFFFFFF75AC7D30
	private Void ImportChildren(XmlNode fromNode, XmlNode toNode, Boolean deep) { }

	// RVA: 0xFFFFFFFF7236B5BC
	public XmlNameTable get_NameTable() { }

	// RVA: 0xFFFFFFFF7236C1AC
	public virtual XmlAttribute CreateAttribute(String prefix, String localName, String namespaceURI) { }

	// RVA: 0xFFFFFFFF75AC96D0
	protected internal virtual XmlAttribute CreateDefaultAttribute(String prefix, String localName, String namespaceURI) { }

	// RVA: 0xFFFFFFFF7236C200
	public virtual XmlElement CreateElement(String prefix, String localName, String namespaceURI) { }

	// RVA: 0xFFFFFFFF75AC9754
	public override Boolean get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF75AC975C
	internal XmlNamedNodeMap get_Entities() { }

	// RVA: 0xFFFFFFFF75AC97F8
	internal Void set_Entities(XmlNamedNodeMap value) { }

	// RVA: 0xFFFFFFFF75AC9830
	internal Boolean get_IsLoading() { }

	// RVA: 0xFFFFFFFF75AC9838
	internal Void set_IsLoading(Boolean value) { }

	// RVA: 0xFFFFFFFF75AC9840
	internal Boolean get_ActualLoadingStatus() { }

	// RVA: 0xFFFFFFFF75AC9848
	private XmlTextReader SetupReader(XmlTextReader tr) { }

	// RVA: 0xFFFFFFFF75AC9938
	public virtual Void Load(String filename) { }

	// RVA: 0xFFFFFFFF75AC9AF0
	public virtual Void Load(Stream inStream) { }

	// RVA: 0xFFFFFFFF75AC9DA4
	public virtual Void Load(XmlReader reader) { }

	// RVA: 0xFFFFFFFF75ACA10C
	public virtual Void LoadXml(String xml) { }

	// RVA: 0xFFFFFFFF7236C458
	internal Encoding get_TextEncoding() { }

	// RVA: 0xFFFFFFFF75ACA2F0
	public override Void set_InnerText(String value) { }

	// RVA: 0xFFFFFFFF75ACA368
	public override Void set_InnerXml(String value) { }

	// RVA: 0xFFFFFFFF7236C4CC
	public virtual Void Save(String filename) { }

	// RVA: 0xFFFFFFFF7236C6B4
	public override Void WriteTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF7236C6C4
	public override Void WriteContentTo(XmlWriter xw) { }

	// RVA: 0xFFFFFFFF7236C9E8
	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, String oldValue, String newValue, XmlNodeChangedAction action) { }

	// RVA: 0xFFFFFFFF75ACA564
	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	// RVA: 0xFFFFFFFF75ACA5F4
	internal override Void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0xFFFFFFFF75ACAA08
	internal override Void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0xFFFFFFFF75ACAA50
	internal XmlAttribute GetDefaultAttribute(XmlElement elem, String attrPrefix, String attrLocalname, String attrNamespaceURI) { }

	// RVA: 0xFFFFFFFF75ACAC7C
	internal XmlEntity GetEntityNode(String name) { }

	// RVA: 0xFFFFFFFF75ACADE8
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xFFFFFFFF75ACAF48
	public override String get_BaseURI() { }

	// RVA: 0xFFFFFFFF75ACAF50
	internal Void SetBaseURI(String inBaseURI) { }

	// RVA: 0xFFFFFFFF75ACAF88
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75ACB194
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0xFFFFFFFF75ACB19C
	internal Boolean get_HasEntityReferences() { }

	// RVA: 0xFFFFFFFF75ACB1A4
	internal XmlAttribute get_NamespaceXml() { }

	// RVA: 0xFFFFFFFF75ACB24C
	private static Void .cctor() { }

}

// Namespace: System.Xml
public class XmlDocumentFragment
{
	// Fields
	private XmlLinkedNode lastChild; // 0x18

	// Properties
	public override String Name { get; }
	public override String LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override XmlDocument OwnerDocument { get; }
	public override String InnerXml { set; }
	internal override Boolean IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	internal override XPathNodeType XPNodeType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AC82F4
	protected internal Void .ctor(XmlDocument ownerDocument) { }

	// RVA: 0xFFFFFFFF75ACB35C
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF75ACB388
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF75ACB3B4
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF75ACB3BC
	public override XmlNode get_ParentNode() { }

	// RVA: 0xFFFFFFFF75ACB3C4
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0xFFFFFFFF75ACB410
	public override Void set_InnerXml(String value) { }

	// RVA: 0xFFFFFFFF75ACB690
	public override XmlNode CloneNode(Boolean deep) { }

	// RVA: 0xFFFFFFFF75ACB714
	internal override Boolean get_IsContainer() { }

	// RVA: 0xFFFFFFFF75ACB71C
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0xFFFFFFFF75ACB724
	internal override Void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0xFFFFFFFF75ACB75C
	internal override Boolean IsValidChildType(XmlNodeType type) { }

	// RVA: 0xFFFFFFFF75ACB7D4
	internal override Boolean CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xFFFFFFFF75ACB84C
	public override Void WriteTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75ACB85C
	public override Void WriteContentTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75ACBA78
	internal override XPathNodeType get_XPNodeType() { }

}

// Namespace: System.Xml
public class XmlDocumentType
{
	// Fields
	private String name; // 0x20
	private String publicId; // 0x28
	private String systemId; // 0x30
	private String internalSubset; // 0x38
	private Boolean namespaces; // 0x40
	private XmlNamedNodeMap entities; // 0x48
	private XmlNamedNodeMap notations; // 0x50
	private SchemaInfo schemaInfo; // 0x58

	// Properties
	public override String Name { get; }
	public override String LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override Boolean IsReadOnly { get; }
	public XmlNamedNodeMap Entities { get; }
	public XmlNamedNodeMap Notations { get; }
	public String PublicId { get; }
	public String SystemId { get; }
	public String InternalSubset { get; }
	internal Boolean ParseWithNamespaces { get; }
	internal SchemaInfo DtdSchemaInfo { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75AC8160
	protected internal Void .ctor(String name, String publicId, String systemId, String internalSubset, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75ACBAEC
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF75ACBAF4
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF75ACBAFC
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF75ACBB04
	public override XmlNode CloneNode(Boolean deep) { }

	// RVA: 0xFFFFFFFF75ACBB4C
	public override Boolean get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF75ACAD4C
	public XmlNamedNodeMap get_Entities() { }

	// RVA: 0xFFFFFFFF75ACBB54
	public XmlNamedNodeMap get_Notations() { }

	// RVA: 0xFFFFFFFF75ACBBF0
	public String get_PublicId() { }

	// RVA: 0xFFFFFFFF75ACBBF8
	public String get_SystemId() { }

	// RVA: 0xFFFFFFFF75ACBC00
	public String get_InternalSubset() { }

	// RVA: 0xFFFFFFFF75ACBC08
	internal Boolean get_ParseWithNamespaces() { }

	// RVA: 0xFFFFFFFF75ACBC10
	public override Void WriteTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75ACBC44
	public override Void WriteContentTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75ACBC48
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0xFFFFFFFF75ACBC50
	internal Void set_DtdSchemaInfo(SchemaInfo value) { }

}

// Namespace: System.Xml
internal class XmlDOMTextWriter
{
	// Methods

	// RVA: 0xFFFFFFFF7236A8D8
	public Void .ctor(String filename, Encoding encoding) { }

	// RVA: 0xFFFFFFFF7236A934
	public override Void WriteStartElement(String prefix, String localName, String ns) { }

	// RVA: 0xFFFFFFFF7236A970
	public override Void WriteStartAttribute(String prefix, String localName, String ns) { }

}

// Namespace: System.Xml
public class XmlElement
{
	// Fields
	private XmlName name; // 0x20
	private XmlAttributeCollection attributes; // 0x28
	private XmlLinkedNode lastChild; // 0x30

	// Properties
	internal XmlName XmlName { get; set; }
	public override String Name { get; }
	public override String LocalName { get; }
	public override String NamespaceURI { get; }
	public override String Prefix { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override XmlDocument OwnerDocument { get; }
	internal override Boolean IsContainer { get; }
	public Boolean IsEmpty { get; set; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlAttributeCollection Attributes { get; }
	public virtual Boolean HasAttributes { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override String InnerXml { set; }
	public override String InnerText { get; set; }
	public override XmlNode NextSibling { get; }
	internal override XPathNodeType XPNodeType { get; }
	internal override String XPLocalName { get; }

	// Methods

	// RVA: 0xFFFFFFFF7236C278
	internal Void .ctor(XmlName name, Boolean empty, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75ACD00C
	protected internal Void .ctor(String prefix, String localName, String namespaceURI, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75ACD058
	internal XmlName get_XmlName() { }

	// RVA: 0xFFFFFFFF75ACD060
	internal Void set_XmlName(XmlName value) { }

	// RVA: 0xFFFFFFFF75ACD098
	public override XmlNode CloneNode(Boolean deep) { }

	// RVA: 0xFFFFFFFF75ACD600
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF7236CAC0
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF7236CAE0
	public override String get_NamespaceURI() { }

	// RVA: 0xFFFFFFFF7236CB00
	public override String get_Prefix() { }

	// RVA: 0xFFFFFFFF7236CB20
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF7236CB28
	public override XmlNode get_ParentNode() { }

	// RVA: 0xFFFFFFFF7236CB30
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0xFFFFFFFF7236CB50
	internal override Boolean get_IsContainer() { }

	// RVA: 0xFFFFFFFF75ACD7A4
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75ACD534
	public Boolean get_IsEmpty() { }

	// RVA: 0xFFFFFFFF75ACD544
	public Void set_IsEmpty(Boolean value) { }

	// RVA: 0xFFFFFFFF7236CB58
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0xFFFFFFFF7236CB68
	internal override Void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0xFFFFFFFF7236CBA0
	internal override Boolean IsValidChildType(XmlNodeType type) { }

	// RVA: 0xFFFFFFFF7236CBB8
	public override XmlAttributeCollection get_Attributes() { }

	// RVA: 0xFFFFFFFF7236CCF4
	public virtual Boolean get_HasAttributes() { }

	// RVA: 0xFFFFFFFF75ACDA24
	public virtual String GetAttribute(String name) { }

	// RVA: 0xFFFFFFFF7236CD24
	public virtual Void SetAttribute(String name, String value) { }

	// RVA: 0xFFFFFFFF7236CE2C
	public virtual XmlAttribute GetAttributeNode(String name) { }

	// RVA: 0xFFFFFFFF75ACDA6C
	public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	// RVA: 0xFFFFFFFF75ACDB84
	public virtual XmlAttribute GetAttributeNode(String localName, String namespaceURI) { }

	// RVA: 0xFFFFFFFF75ACDC00
	public virtual Boolean HasAttribute(String name) { }

	// RVA: 0xFFFFFFFF7236CE94
	public override Void WriteTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF7236CF88
	private static Void WriteElementTo(XmlWriter writer, XmlElement e) { }

	// RVA: 0xFFFFFFFF7236D1A0
	private Void WriteStartElement(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75ACDC28
	public override Void WriteContentTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75ACDC90
	public virtual Void RemoveAllAttributes() { }

	// RVA: 0xFFFFFFFF75ACDCDC
	public override Void RemoveAll() { }

	// RVA: 0xFFFFFFFF75ACD9B0
	internal Void RemoveAllChildren() { }

	// RVA: 0xFFFFFFFF75ACDD60
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xFFFFFFFF75ACDD68
	public override Void set_InnerXml(String value) { }

	// RVA: 0xFFFFFFFF75ACDEA4
	public override String get_InnerText() { }

	// RVA: 0xFFFFFFFF75ACDEA8
	public override Void set_InnerText(String value) { }

	// RVA: 0xFFFFFFFF7236D450
	public override XmlNode get_NextSibling() { }

	// RVA: 0xFFFFFFFF7236D498
	internal override Void SetParent(XmlNode node) { }

	// RVA: 0xFFFFFFFF75ACDFBC
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0xFFFFFFFF75ACDFC4
	internal override String get_XPLocalName() { }

}

// Namespace: System.Xml
public class XmlEntity
{
	// Fields
	private String publicId; // 0x18
	private String systemId; // 0x20
	private String notationName; // 0x28
	private String name; // 0x30
	private String unparsedReplacementStr; // 0x38
	private String baseURI; // 0x40
	private XmlLinkedNode lastChild; // 0x48
	private Boolean childrenFoliating; // 0x50

	// Properties
	public override Boolean IsReadOnly { get; }
	public override String Name { get; }
	public override String LocalName { get; }
	public override String InnerText { get; set; }
	internal override Boolean IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlNodeType NodeType { get; }
	public String SystemId { get; }
	public override String InnerXml { set; }
	public override String BaseURI { get; }

	// Methods

	// RVA: 0xFFFFFFFF75ACDFD4
	internal Void .ctor(String name, String strdata, String publicId, String systemId, String notationName, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75ACE0E4
	public override XmlNode CloneNode(Boolean deep) { }

	// RVA: 0xFFFFFFFF75ACE15C
	public override Boolean get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF75ACE164
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF75ACE16C
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF75ACE174
	public override String get_InnerText() { }

	// RVA: 0xFFFFFFFF75ACE178
	public override Void set_InnerText(String value) { }

	// RVA: 0xFFFFFFFF75ACE1F0
	internal override Boolean get_IsContainer() { }

	// RVA: 0xFFFFFFFF75ACE1F8
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0xFFFFFFFF75ACE2D8
	internal override Void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0xFFFFFFFF75ACE310
	internal override Boolean IsValidChildType(XmlNodeType type) { }

	// RVA: 0xFFFFFFFF75ACE328
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF75ACE330
	public String get_SystemId() { }

	// RVA: 0xFFFFFFFF75ACE338
	public override Void set_InnerXml(String value) { }

	// RVA: 0xFFFFFFFF75ACE3B0
	public override Void WriteTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75ACE3B4
	public override Void WriteContentTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75ACE3B8
	public override String get_BaseURI() { }

	// RVA: 0xFFFFFFFF75ACE3C0
	internal Void SetBaseURI(String inBaseURI) { }

}

// Namespace: System.Xml
public class XmlEntityReference
{
	// Fields
	private String name; // 0x20
	private XmlLinkedNode lastChild; // 0x28

	// Properties
	public override String Name { get; }
	public override String LocalName { get; }
	public override String Value { get; set; }
	public override XmlNodeType NodeType { get; }
	public override Boolean IsReadOnly { get; }
	internal override Boolean IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override String BaseURI { get; }
	internal String ChildBaseURI { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AC85A0
	protected internal Void .ctor(String name, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75ACE3F8
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF75ACE400
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF75ACE408
	public override String get_Value() { }

	// RVA: 0xFFFFFFFF75ACE410
	public override Void set_Value(String value) { }

	// RVA: 0xFFFFFFFF75ACE488
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF75ACE490
	public override XmlNode CloneNode(Boolean deep) { }

	// RVA: 0xFFFFFFFF75ACE4D4
	public override Boolean get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF75ACE4DC
	internal override Boolean get_IsContainer() { }

	// RVA: 0xFFFFFFFF75ACE4E4
	internal override Void SetParent(XmlNode node) { }

	// RVA: 0xFFFFFFFF75ACEAC0
	internal override Void SetParentForLoad(XmlNode node) { }

	// RVA: 0xFFFFFFFF75ACEAD0
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0xFFFFFFFF75ACEAD8
	internal override Void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0xFFFFFFFF75ACEB10
	internal override Boolean IsValidChildType(XmlNodeType type) { }

	// RVA: 0xFFFFFFFF75ACEB28
	public override Void WriteTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75ACEB58
	public override Void WriteContentTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75ACED74
	public override String get_BaseURI() { }

	// RVA: 0xFFFFFFFF75ACEDA8
	private String ConstructBaseURI(String baseURI, String systemId) { }

	// RVA: 0xFFFFFFFF75ACEE60
	internal String get_ChildBaseURI() { }

}

// Namespace: System.Xml
public enum XmlNodeChangedAction
{
	// Fields
	public Int32 value__; // 0x10
	public const XmlNodeChangedAction Insert = 0;
	public const XmlNodeChangedAction Remove = 1;
	public const XmlNodeChangedAction Change = 2;
}

// Namespace: System.Xml
public class XmlImplementation
{
	// Fields
	private XmlNameTable nameTable; // 0x10

	// Properties
	internal XmlNameTable NameTable { get; }

	// Methods

	// RVA: 0xFFFFFFFF7236B0F4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75ACFD54
	public Void .ctor(XmlNameTable nt) { }

	// RVA: 0xFFFFFFFF75ACFD8C
	public virtual XmlDocument CreateDocument() { }

	// RVA: 0xFFFFFFFF75ACFDC4
	internal XmlNameTable get_NameTable() { }

}

// Namespace: System.Xml
public abstract class XmlLinkedNode
{
	// Fields
	internal XmlLinkedNode next; // 0x18

	// Properties
	public override XmlNode PreviousSibling { get; }
	public override XmlNode NextSibling { get; }

	// Methods

	// RVA: 0xFFFFFFFF7236AC38
	internal Void .ctor(XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75ACFDCC
	public override XmlNode get_PreviousSibling() { }

	// RVA: 0xFFFFFFFF7236D5A0
	public override XmlNode get_NextSibling() { }

}

// Namespace: System.Xml
internal class XmlLoader
{
	// Fields
	private XmlDocument doc; // 0x10
	private XmlReader reader; // 0x18
	private Boolean preserveWhitespace; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75AC9E78
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AC9E7C
	internal Void Load(XmlDocument doc, XmlReader reader, Boolean preserveWhitespace) { }

	// RVA: 0xFFFFFFFF75ACFEB8
	private Void LoadDocSequence(XmlDocument parentDoc) { }

	// RVA: 0xFFFFFFFF75ACFF28
	private XmlNode LoadNode(Boolean skipOverWhitespace) { }

	// RVA: 0xFFFFFFFF75AD04FC
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0xFFFFFFFF75AD0E68
	private XmlAttribute LoadDefaultAttribute() { }

	// RVA: 0xFFFFFFFF75AD102C
	private Void LoadAttributeValue(XmlNode parent, Boolean direct) { }

	// RVA: 0xFFFFFFFF75AD0848
	private XmlEntityReference LoadEntityReferenceNode(Boolean direct) { }

	// RVA: 0xFFFFFFFF75AD0A2C
	private XmlDeclaration LoadDeclarationNode() { }

	// RVA: 0xFFFFFFFF75AD0BB8
	private XmlDocumentType LoadDocumentTypeNode() { }

	// RVA: 0xFFFFFFFF75AD1344
	private XmlNode LoadNodeDirect() { }

	// RVA: 0xFFFFFFFF75AD260C
	private XmlAttribute LoadAttributeNodeDirect() { }

	// RVA: 0xFFFFFFFF75ACBA80
	internal Void ParseDocumentType(XmlDocumentType dtNode) { }

	// RVA: 0xFFFFFFFF75AD2750
	private Void ParseDocumentType(XmlDocumentType dtNode, Boolean bUseResolver, XmlResolver resolver) { }

	// RVA: 0xFFFFFFFF75AD1730
	private Void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	// RVA: 0xFFFFFFFF75AD31BC
	private XmlParserContext GetContext(XmlNode node) { }

	// RVA: 0xFFFFFFFF75ACB484
	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, String innerxmltext, XmlNodeType nt) { }

	// RVA: 0xFFFFFFFF75ACDE18
	internal Void LoadInnerXmlElement(XmlElement node, String innerxmltext) { }

	// RVA: 0xFFFFFFFF75AD3E8C
	internal Void LoadInnerXmlAttribute(XmlAttribute node, String innerxmltext) { }

	// RVA: 0xFFFFFFFF75AD3BE8
	private Void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, Boolean fCheckElemAttrs) { }

	// RVA: 0xFFFFFFFF75AD3E94
	private String EntitizeName(String name) { }

	// RVA: 0xFFFFFFFF75ACE270
	internal Void ExpandEntity(XmlEntity ent) { }

	// RVA: 0xFFFFFFFF75ACE590
	internal Void ExpandEntityReference(XmlEntityReference eref) { }

	// RVA: 0xFFFFFFFF75AD3964
	private XmlReader CreateInnerXmlReader(String xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75AC6FA0
	internal static Void ParseXmlDeclarationValue(String strValue, out String version, out String encoding, out String standalone) { }

	// RVA: 0xFFFFFFFF75AD0D5C
	internal static Exception UnexpectedNodeType(XmlNodeType nodetype) { }

}

// Namespace: System.Xml
internal class XmlName
{
	// Fields
	private String prefix; // 0x10
	private String localName; // 0x18
	private String ns; // 0x20
	private String name; // 0x28
	private Int32 hashCode; // 0x30
	internal XmlDocument ownerDoc; // 0x38
	internal XmlName next; // 0x40

	// Properties
	public String LocalName { get; }
	public String NamespaceURI { get; }
	public String Prefix { get; }
	public Int32 HashCode { get; }
	public XmlDocument OwnerDocument { get; }
	public String Name { get; }
	public virtual XmlSchemaValidity Validity { get; }
	public virtual Boolean IsDefault { get; }
	public virtual Boolean IsNil { get; }
	public virtual XmlSchemaSimpleType MemberType { get; }
	public virtual XmlSchemaType SchemaType { get; }
	public virtual XmlSchemaElement SchemaElement { get; }
	public virtual XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0xFFFFFFFF7236D5F8
	public static XmlName Create(String prefix, String localName, String ns, Int32 hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xFFFFFFFF7236D744
	internal Void .ctor(String prefix, String localName, String ns, Int32 hashCode, XmlDocument ownerDoc, XmlName next) { }

	// RVA: 0xFFFFFFFF75AD4620
	public String get_LocalName() { }

	// RVA: 0xFFFFFFFF75AD4628
	public String get_NamespaceURI() { }

	// RVA: 0xFFFFFFFF75AD4630
	public String get_Prefix() { }

	// RVA: 0xFFFFFFFF75AD4638
	public Int32 get_HashCode() { }

	// RVA: 0xFFFFFFFF75AD4640
	public XmlDocument get_OwnerDocument() { }

	// RVA: 0xFFFFFFFF75ACD61C
	public String get_Name() { }

	// RVA: 0xFFFFFFFF75AD4648
	public virtual XmlSchemaValidity get_Validity() { }

	// RVA: 0xFFFFFFFF75AD4650
	public virtual Boolean get_IsDefault() { }

	// RVA: 0xFFFFFFFF75AD4658
	public virtual Boolean get_IsNil() { }

	// RVA: 0xFFFFFFFF75AD4660
	public virtual XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0xFFFFFFFF75AD4668
	public virtual XmlSchemaType get_SchemaType() { }

	// RVA: 0xFFFFFFFF75AD4670
	public virtual XmlSchemaElement get_SchemaElement() { }

	// RVA: 0xFFFFFFFF75AD4678
	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0xFFFFFFFF7236D844
	public virtual Boolean Equals(IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xFFFFFFFF7236D850
	public static Int32 GetHashCode(String name) { }

}

// Namespace: System.Xml
internal sealed class XmlNameEx
{
	// Fields
	private Byte flags; // 0x48
	private XmlSchemaSimpleType memberType; // 0x50
	private XmlSchemaType schemaType; // 0x58
	private Object decl; // 0x60

	// Properties
	public override XmlSchemaValidity Validity { get; }
	public override Boolean IsDefault { get; }
	public override Boolean IsNil { get; }
	public override XmlSchemaSimpleType MemberType { get; }
	public override XmlSchemaType SchemaType { get; }
	public override XmlSchemaElement SchemaElement { get; }
	public override XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AD41D8
	internal Void .ctor(String prefix, String localName, String ns, Int32 hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xFFFFFFFF75AD46D4
	public override XmlSchemaValidity get_Validity() { }

	// RVA: 0xFFFFFFFF75AD4708
	public override Boolean get_IsDefault() { }

	// RVA: 0xFFFFFFFF75AD4714
	public override Boolean get_IsNil() { }

	// RVA: 0xFFFFFFFF75AD4720
	public override XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0xFFFFFFFF75AD4728
	public override XmlSchemaType get_SchemaType() { }

	// RVA: 0xFFFFFFFF75AD4730
	public override XmlSchemaElement get_SchemaElement() { }

	// RVA: 0xFFFFFFFF75AD47AC
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0xFFFFFFFF75AD4680
	public Void SetValidity(XmlSchemaValidity value) { }

	// RVA: 0xFFFFFFFF75AD4694
	public Void SetIsDefault(Boolean value) { }

	// RVA: 0xFFFFFFFF75AD46B4
	public Void SetIsNil(Boolean value) { }

	// RVA: 0xFFFFFFFF75AD4828
	public override Boolean Equals(IXmlSchemaInfo schemaInfo) { }

}

// Namespace: System.Xml
public class XmlNamedNodeMap
{
	// Fields
	internal XmlNode parent; // 0x10
	internal SmallXmlNodeList nodes; // 0x18

	// Properties
	public virtual Int32 Count { get; }

	// Methods

	// RVA: 0xFFFFFFFF7236C420
	internal Void .ctor(XmlNode parent) { }

	// RVA: 0xFFFFFFFF75AD4C18
	public virtual XmlNode GetNamedItem(String name) { }

	// RVA: 0xFFFFFFFF75AD4D58
	public virtual XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0xFFFFFFFF7236D97C
	public virtual Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75AD4F90
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75AD4C88
	internal Int32 FindNodeOffset(String name) { }

	// RVA: 0xFFFFFFFF75AD4E28
	internal Int32 FindNodeOffset(String localName, String namespaceURI) { }

	// RVA: 0xFFFFFFFF7236DA14
	internal virtual XmlNode AddNode(XmlNode node) { }

	// RVA: 0xFFFFFFFF75AD5090
	internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75AD5138
	internal virtual XmlNode RemoveNodeAt(Int32 i) { }

	// RVA: 0xFFFFFFFF75AD4F30
	internal XmlNode ReplaceNodeAt(Int32 i, XmlNode node) { }

	// RVA: 0xFFFFFFFF75AD536C
	internal virtual XmlNode InsertNodeAt(Int32 i, XmlNode node) { }

}

// Namespace: 
internal struct SmallXmlNodeList
{
	// Fields
	private Object field; // 0x10

	// Properties
	public Int32 Count { get; }
	public Object Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF71145B98
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF71145BA0
	public Object get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF71145BA8
	public Void Add(Object value) { }

	// RVA: 0xFFFFFFFF71145BB0
	public Void RemoveAt(Int32 index) { }

	// RVA: 0xFFFFFFFF71145BB8
	public Void Insert(Int32 index, Object value) { }

	// RVA: 0xFFFFFFFF71145BC0
	public IEnumerator GetEnumerator() { }

}

// Namespace: 
private class SingleObjectEnumerator
{
	// Fields
	private Object loneValue; // 0x10
	private Int32 position; // 0x18

	// Properties
	public Object Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AD5688
	public Void .ctor(Object value) { }

	// RVA: 0xFFFFFFFF75AD56C8
	public Object get_Current() { }

	// RVA: 0xFFFFFFFF75AD5738
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75AD5750
	public Void Reset() { }

}

// Namespace: System.Xml
public abstract class XmlNode
{
	// Fields
	internal XmlNode parentNode; // 0x10

	// Properties
	public abstract String Name { get; }
	public virtual String Value { get; set; }
	public abstract XmlNodeType NodeType { get; }
	public virtual XmlNode ParentNode { get; }
	public virtual XmlNodeList ChildNodes { get; }
	public virtual XmlNode PreviousSibling { get; }
	public virtual XmlNode NextSibling { get; }
	public virtual XmlAttributeCollection Attributes { get; }
	public virtual XmlDocument OwnerDocument { get; }
	public virtual XmlNode FirstChild { get; }
	public virtual XmlNode LastChild { get; }
	internal virtual Boolean IsContainer { get; }
	internal virtual XmlLinkedNode LastNode { get; set; }
	public virtual Boolean HasChildNodes { get; }
	public virtual String NamespaceURI { get; }
	public virtual String Prefix { get; }
	public abstract String LocalName { get; }
	public virtual Boolean IsReadOnly { get; }
	public virtual String InnerText { get; set; }
	public virtual String InnerXml { set; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }
	public virtual String BaseURI { get; }
	internal virtual String XmlLang { get; }
	internal virtual XPathNodeType XPNodeType { get; }
	internal virtual String XPLocalName { get; }
	internal virtual Boolean IsText { get; }
	public virtual XmlNode PreviousText { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AC7218
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF7236D4D0
	internal Void .ctor(XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75AD60E0
	public virtual XPathNavigator CreateNavigator() { }

	// RVA: 0xFFFFFFFF75AD6164
	public XmlNode SelectSingleNode(String xpath) { }

	// RVA: 0xFFFFFFFF75AD6234
	public XmlNode SelectSingleNode(String xpath, XmlNamespaceManager nsmgr) { }

	// RVA: 0xFFFFFFFF75AD6194
	public XmlNodeList SelectNodes(String xpath) { }

	// RVA: -1
	public abstract String get_Name() { }

	// RVA: 0xFFFFFFFF7236DCE0
	public virtual String get_Value() { }

	// RVA: 0xFFFFFFFF75AD632C
	public virtual Void set_Value(String value) { }

	// RVA: -1
	public abstract XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF7236DCE8
	public virtual XmlNode get_ParentNode() { }

	// RVA: 0xFFFFFFFF75AD6454
	public virtual XmlNodeList get_ChildNodes() { }

	// RVA: 0xFFFFFFFF75AD64B0
	public virtual XmlNode get_PreviousSibling() { }

	// RVA: 0xFFFFFFFF75AD64B8
	public virtual XmlNode get_NextSibling() { }

	// RVA: 0xFFFFFFFF75AD64C0
	public virtual XmlAttributeCollection get_Attributes() { }

	// RVA: 0xFFFFFFFF7236DDA8
	public virtual XmlDocument get_OwnerDocument() { }

	// RVA: 0xFFFFFFFF7236DE40
	public virtual XmlNode get_FirstChild() { }

	// RVA: 0xFFFFFFFF7236DE68
	public virtual XmlNode get_LastChild() { }

	// RVA: 0xFFFFFFFF75AD64C8
	internal virtual Boolean get_IsContainer() { }

	// RVA: 0xFFFFFFFF75AD64D0
	internal virtual XmlLinkedNode get_LastNode() { }

	// RVA: 0xFFFFFFFF75AD64D8
	internal virtual Void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0xFFFFFFFF75AD64DC
	internal Boolean AncestorNode(XmlNode node) { }

	// RVA: 0xFFFFFFFF75AC902C
	internal Boolean IsConnected() { }

	// RVA: 0xFFFFFFFF75AD6554
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0xFFFFFFFF7236DE78
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0xFFFFFFFF75AD6A00
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75AD6BD4
	internal virtual Boolean IsValidChildType(XmlNodeType type) { }

	// RVA: 0xFFFFFFFF7236E3C4
	internal virtual Boolean CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xFFFFFFFF7236E3CC
	public virtual Boolean get_HasChildNodes() { }

	// RVA: -1
	public abstract XmlNode CloneNode(Boolean deep) { }

	// RVA: 0xFFFFFFFF75AD6BDC
	internal virtual Void CopyChildren(XmlDocument doc, XmlNode container, Boolean deep) { }

	// RVA: 0xFFFFFFFF75AD6C7C
	public virtual String get_NamespaceURI() { }

	// RVA: 0xFFFFFFFF75AD6C90
	public virtual String get_Prefix() { }

	// RVA: -1
	public abstract String get_LocalName() { }

	// RVA: 0xFFFFFFFF7236E3F4
	public virtual Boolean get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF7236E4B0
	internal static Boolean HasReadOnlyParent(XmlNode n) { }

	// RVA: 0xFFFFFFFF75AD6CA4
	public virtual XmlNode Clone() { }

	// RVA: 0xFFFFFFFF75AD6CB8
	private Object System.ICloneable.Clone() { }

	// RVA: 0xFFFFFFFF75AD6CCC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFFFFFFFF75ACA3F8
	public IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75AD6D08
	private Void AppendChildText(StringBuilder builder) { }

	// RVA: 0xFFFFFFFF7236D33C
	public virtual String get_InnerText() { }

	// RVA: 0xFFFFFFFF7236E560
	public virtual Void set_InnerText(String value) { }

	// RVA: 0xFFFFFFFF75AD6E20
	public virtual Void set_InnerXml(String value) { }

	// RVA: 0xFFFFFFFF75AD6E98
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xFFFFFFFF75AD6ED8
	public virtual String get_BaseURI() { }

	// RVA: -1
	public abstract Void WriteTo(XmlWriter w) { }

	// RVA: -1
	public abstract Void WriteContentTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF7236D2C8
	public virtual Void RemoveAll() { }

	// RVA: 0xFFFFFFFF7236D548
	internal virtual Void SetParent(XmlNode node) { }

	// RVA: 0xFFFFFFFF75AD6FF8
	internal virtual Void SetParentForLoad(XmlNode node) { }

	// RVA: 0xFFFFFFFF7236BBD4
	internal static Void SplitName(String name, out String prefix, out String localName) { }

	// RVA: 0xFFFFFFFF7236E648
	internal virtual XmlNode FindChild(XmlNodeType type) { }

	// RVA: 0xFFFFFFFF7236E6B0
	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, String oldValue, String newValue, XmlNodeChangedAction action) { }

	// RVA: 0xFFFFFFFF75AD7030
	internal virtual Void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0xFFFFFFFF75AD7084
	internal virtual Void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0xFFFFFFFF75AD70D8
	internal virtual String get_XmlLang() { }

	// RVA: 0xFFFFFFFF75AD719C
	internal virtual XPathNodeType get_XPNodeType() { }

	// RVA: 0xFFFFFFFF75AD71A4
	internal virtual String get_XPLocalName() { }

	// RVA: 0xFFFFFFFF7236E7D0
	internal virtual Boolean get_IsText() { }

	// RVA: 0xFFFFFFFF75AD71B8
	public virtual XmlNode get_PreviousText() { }

	// RVA: 0xFFFFFFFF75ACD970
	internal static Void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	// RVA: 0xFFFFFFFF75AD69AC
	internal static Void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

}

// Namespace: System.Xml
public class XmlNodeChangedEventArgs
{
	// Fields
	private XmlNodeChangedAction action; // 0x10
	private XmlNode node; // 0x18
	private XmlNode oldParent; // 0x20
	private XmlNode newParent; // 0x28
	private String oldValue; // 0x30
	private String newValue; // 0x38

	// Properties
	public XmlNodeChangedAction Action { get; }

	// Methods

	// RVA: 0xFFFFFFFF75ACA434
	public Void .ctor(XmlNode node, XmlNode oldParent, XmlNode newParent, String oldValue, String newValue, XmlNodeChangedAction action) { }

	// RVA: 0xFFFFFFFF75AD71C0
	public XmlNodeChangedAction get_Action() { }

}

// Namespace: System.Xml
public sealed class XmlNodeChangedEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75AD71C8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75ACA63C
	public virtual Void Invoke(Object sender, XmlNodeChangedEventArgs e) { }

	// RVA: 0xFFFFFFFF75AD720C
	public virtual IAsyncResult BeginInvoke(Object sender, XmlNodeChangedEventArgs e, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75AD7268
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Xml
public abstract class XmlNodeList
{
	// Properties
	public abstract Int32 Count { get; }
	public virtual XmlNode ItemOf { get; }

	// Methods

	// RVA: -1
	public abstract XmlNode Item(Int32 index) { }

	// RVA: -1
	public abstract Int32 get_Count() { }

	// RVA: -1
	public abstract IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75AD7274
	public virtual XmlNode get_ItemOf(Int32 i) { }

	// RVA: 0xFFFFFFFF75AD7284
	private Void System.IDisposable.Dispose() { }

	// RVA: 0xFFFFFFFF75AD7294
	protected virtual Void PrivateDisposeNodeList() { }

	// RVA: 0xFFFFFFFF75AD7298
	protected Void .ctor() { }

}

// Namespace: System.Xml
public class XmlNotation
{
	// Fields
	private String publicId; // 0x18
	private String systemId; // 0x20
	private String name; // 0x28

	// Properties
	public override String Name { get; }
	public override String LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override Boolean IsReadOnly { get; }
	public override String InnerXml { set; }

	// Methods

	// RVA: 0xFFFFFFFF75AD30B0
	internal Void .ctor(String name, String publicId, String systemId, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75AD73A8
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF75AD73B0
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF75AD73B8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF75AD73C0
	public override XmlNode CloneNode(Boolean deep) { }

	// RVA: 0xFFFFFFFF75AD7438
	public override Boolean get_IsReadOnly() { }

	// RVA: 0xFFFFFFFF75AD7440
	public override Void set_InnerXml(String value) { }

	// RVA: 0xFFFFFFFF75AD74B8
	public override Void WriteTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75AD74BC
	public override Void WriteContentTo(XmlWriter w) { }

}

// Namespace: System.Xml
public class XmlProcessingInstruction
{
	// Fields
	private String target; // 0x20
	private String data; // 0x28

	// Properties
	public override String Name { get; }
	public override String LocalName { get; }
	public override String Value { get; set; }
	public String Data { set; }
	public override String InnerText { get; set; }
	public override XmlNodeType NodeType { get; }
	internal override String XPLocalName { get; }
	internal override XPathNodeType XPNodeType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AC874C
	protected internal Void .ctor(String target, String data, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75AD7928
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF75AD7948
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF75AD7958
	public override String get_Value() { }

	// RVA: 0xFFFFFFFF75AD7960
	public override Void set_Value(String value) { }

	// RVA: 0xFFFFFFFF75AD7964
	public Void set_Data(String value) { }

	// RVA: 0xFFFFFFFF75AD7A48
	public override String get_InnerText() { }

	// RVA: 0xFFFFFFFF75AD7A50
	public override Void set_InnerText(String value) { }

	// RVA: 0xFFFFFFFF75AD7A54
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF75AD7A5C
	public override XmlNode CloneNode(Boolean deep) { }

	// RVA: 0xFFFFFFFF75AD7AA0
	public override Void WriteTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75AD7AD0
	public override Void WriteContentTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75AD7AD4
	internal override String get_XPLocalName() { }

	// RVA: 0xFFFFFFFF75AD7AE4
	internal override XPathNodeType get_XPNodeType() { }

}

// Namespace: System.Xml
public class XmlSignificantWhitespace
{
	// Properties
	public override String Name { get; }
	public override String LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override String Value { get; set; }
	internal override XPathNodeType XPNodeType { get; }
	internal override Boolean IsText { get; }
	public override XmlNode PreviousText { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AC8848
	protected internal Void .ctor(String strData, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75AD9998
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF75AD99C4
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF75AD99F0
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF75AD99F8
	public override XmlNode get_ParentNode() { }

	// RVA: 0xFFFFFFFF75AD9A90
	public override XmlNode CloneNode(Boolean deep) { }

	// RVA: 0xFFFFFFFF75AD9AF0
	public override String get_Value() { }

	// RVA: 0xFFFFFFFF75AD9B00
	public override Void set_Value(String value) { }

	// RVA: 0xFFFFFFFF75AD9BBC
	public override Void WriteTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75AD9C04
	public override Void WriteContentTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75AD9C08
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0xFFFFFFFF75AD9C3C
	internal override Boolean get_IsText() { }

	// RVA: 0xFFFFFFFF75AD9C44
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
public class XmlText
{
	// Properties
	public override String Name { get; }
	public override String LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override String Value { get; set; }
	internal override XPathNodeType XPNodeType { get; }
	internal override Boolean IsText { get; }
	public override XmlNode PreviousText { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AD1338
	internal Void .ctor(String strData) { }

	// RVA: 0xFFFFFFFF75AC87D8
	protected internal Void .ctor(String strData, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75AD9C8C
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF75AD9CB8
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF7236E7D8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF7236E7E0
	public override XmlNode get_ParentNode() { }

	// RVA: 0xFFFFFFFF75AD9CE4
	public override XmlNode CloneNode(Boolean deep) { }

	// RVA: 0xFFFFFFFF7236E874
	public override String get_Value() { }

	// RVA: 0xFFFFFFFF75AD9D44
	public override Void set_Value(String value) { }

	// RVA: 0xFFFFFFFF7236E884
	public override Void WriteTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75AD9E18
	public override Void WriteContentTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75AD9E1C
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0xFFFFFFFF75AD9E24
	internal override Boolean get_IsText() { }

	// RVA: 0xFFFFFFFF75AD9E2C
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
internal class XmlUnspecifiedAttribute
{
	// Fields
	private Boolean fSpecified; // 0x28

	// Properties
	public override Boolean Specified { get; }
	public override String InnerText { set; }

	// Methods

	// RVA: 0xFFFFFFFF75AEEF14
	protected internal Void .ctor(String prefix, String localName, String namespaceURI, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75AEEF1C
	public override Boolean get_Specified() { }

	// RVA: 0xFFFFFFFF75AEEF24
	public override XmlNode CloneNode(Boolean deep) { }

	// RVA: 0xFFFFFFFF75AEF054
	public override Void set_InnerText(String value) { }

	// RVA: 0xFFFFFFFF75AEF080
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0xFFFFFFFF75AEF0AC
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0xFFFFFFFF75AEF0D8
	public override Void WriteTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75AEF0EC
	internal Void SetSpecified(Boolean f) { }

}

// Namespace: System.Xml
public class XmlWhitespace
{
	// Properties
	public override String Name { get; }
	public override String LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override String Value { get; set; }
	internal override XPathNodeType XPNodeType { get; }
	internal override Boolean IsText { get; }
	public override XmlNode PreviousText { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AEF838
	protected internal Void .ctor(String strData, XmlDocument doc) { }

	// RVA: 0xFFFFFFFF75AEF908
	public override String get_Name() { }

	// RVA: 0xFFFFFFFF75AEF934
	public override String get_LocalName() { }

	// RVA: 0xFFFFFFFF75AEF960
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFFFFFFFF75AEF968
	public override XmlNode get_ParentNode() { }

	// RVA: 0xFFFFFFFF75AEFA04
	public override String get_Value() { }

	// RVA: 0xFFFFFFFF75AEFA14
	public override Void set_Value(String value) { }

	// RVA: 0xFFFFFFFF75AEFAD0
	public override XmlNode CloneNode(Boolean deep) { }

	// RVA: 0xFFFFFFFF75AEFB30
	public override Void WriteTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75AEFB78
	public override Void WriteContentTo(XmlWriter w) { }

	// RVA: 0xFFFFFFFF75AEFB7C
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0xFFFFFFFF75AEFBB0
	internal override Boolean get_IsText() { }

	// RVA: 0xFFFFFFFF75AEFBB8
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
internal sealed class EmptyEnumerator
{
	// Properties
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A81C50
	private Boolean System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0xFFFFFFFF75A81C58
	private Void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xFFFFFFFF75A81C5C
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xFFFFFFFF75A81CC0
	public Void .ctor() { }

}

// Namespace: System.Xml
public interface IHasXmlNode
{
	// Methods

	// RVA: -1
	public abstract XmlNode GetNode() { }

}

// Namespace: System.Xml
public interface IXmlNamespaceResolver
{
	// Methods

	// RVA: -1
	public abstract String LookupNamespace(String prefix) { }

	// RVA: -1
	public abstract String LookupPrefix(String namespaceName) { }

}

// Namespace: System.Xml
internal struct LineInfo
{
	// Fields
	internal Int32 lineNo; // 0x10
	internal Int32 linePos; // 0x14

	// Methods

	// RVA: 0xFFFFFFFF7114514C
	public Void .ctor(Int32 lineNo, Int32 linePos) { }

	// RVA: 0xFFFFFFFF71145154
	public Void Set(Int32 lineNo, Int32 linePos) { }

}

// Namespace: System.Xml
public class NameTable
{
	// Fields
	private Entry[] entries; // 0x10
	private Int32 count; // 0x18
	private Int32 mask; // 0x1C
	private Int32 hashCodeRandomizer; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF7236938C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF723693E4
	public override String Add(String key) { }

	// RVA: 0xFFFFFFFF75A81CEC
	public override String Add(Char[] key, Int32 start, Int32 len) { }

	// RVA: 0xFFFFFFFF75A81F20
	public override String Get(String value) { }

	// RVA: 0xFFFFFFFF72369518
	private String AddEntry(String str, Int32 hashCode) { }

	// RVA: 0xFFFFFFFF75A820DC
	private Void Grow() { }

	// RVA: 0xFFFFFFFF75A81E5C
	private static Boolean TextEquals(String str1, Char[] str2, Int32 str2Start, Int32 str2Length) { }

}

// Namespace: 
private class Entry
{
	// Fields
	internal String str; // 0x10
	internal Int32 hashCode; // 0x18
	internal Entry next; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75A82070
	internal Void .ctor(String str, Int32 hashCode, Entry next) { }

}

// Namespace: System.Xml
internal static class Ref
{
	// Methods

	// RVA: 0xFFFFFFFF75A82230
	public static Boolean Equal(String strA, String strB) { }

}

// Namespace: System.Xml
internal class DtdParser
{
	// Fields
	private IDtdParserAdapter readerAdapter; // 0x10
	private IDtdParserAdapterWithValidation readerAdapterWithValidation; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaInfo schemaInfo; // 0x28
	private XmlCharType xmlCharType; // 0x30
	private String systemId; // 0x38
	private String publicId; // 0x40
	private Boolean normalize; // 0x48
	private Boolean validate; // 0x49
	private Boolean supportNamespaces; // 0x4A
	private Boolean v1Compat; // 0x4B
	private Char[] chars; // 0x50
	private Int32 charsUsed; // 0x58
	private Int32 curPos; // 0x5C
	private ScanningFunction scanningFunction; // 0x60
	private ScanningFunction nextScaningFunction; // 0x64
	private ScanningFunction savedScanningFunction; // 0x68
	private Boolean whitespaceSeen; // 0x6C
	private Int32 tokenStartPos; // 0x70
	private Int32 colonPos; // 0x74
	private StringBuilder internalSubsetValueSb; // 0x78
	private Int32 externalEntitiesDepth; // 0x80
	private Int32 currentEntityId; // 0x84
	private Boolean freeFloatingDtd; // 0x88
	private Boolean hasFreeFloatingInternalSubset; // 0x89
	private StringBuilder stringBuilder; // 0x90
	private Int32 condSectionDepth; // 0x98
	private LineInfo literalLineInfo; // 0x9C
	private Char literalQuoteChar; // 0xA4
	private String documentBaseUri; // 0xA8
	private String externalDtdBaseUri; // 0xB0
	private Dictionary<T0, T1> undeclaredNotations; // 0xB8
	private Int32[] condSectionEntityIds; // 0xC0

	// Properties
	private Boolean ParsingInternalSubset { get; }
	private Boolean IgnoreEntityReferences { get; }
	private Boolean SaveInternalSubsetValue { get; }
	private Boolean ParsingTopLevelMarkup { get; }
	private Boolean SupportNamespaces { get; }
	private Boolean Normalize { get; }
	private Int32 LineNo { get; }
	private Int32 LinePos { get; }
	private String BaseUriStr { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A775CC
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF75A776F0
	internal static IDtdParser Create() { }

	// RVA: 0xFFFFFFFF75A77740
	private Void Initialize(IDtdParserAdapter readerAdapter) { }

	// RVA: 0xFFFFFFFF75A77B78
	private Void InitializeFreeFloatingDtd(String baseUri, String docTypeName, String publicId, String systemId, String internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0xFFFFFFFF75A78010
	private IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, Boolean saveInternalSubset) { }

	// RVA: 0xFFFFFFFF75A7842C
	private IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(String baseUri, String docTypeName, String publicId, String systemId, String internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0xFFFFFFFF75A7845C
	private Boolean get_ParsingInternalSubset() { }

	// RVA: 0xFFFFFFFF75A7846C
	private Boolean get_IgnoreEntityReferences() { }

	// RVA: 0xFFFFFFFF75A7847C
	private Boolean get_SaveInternalSubsetValue() { }

	// RVA: 0xFFFFFFFF75A78540
	private Boolean get_ParsingTopLevelMarkup() { }

	// RVA: 0xFFFFFFFF75A78570
	private Boolean get_SupportNamespaces() { }

	// RVA: 0xFFFFFFFF75A78578
	private Boolean get_Normalize() { }

	// RVA: 0xFFFFFFFF75A78044
	private Void Parse(Boolean saveInternalSubset) { }

	// RVA: 0xFFFFFFFF75A785E8
	private Void ParseInDocumentDtd(Boolean saveInternalSubset) { }

	// RVA: 0xFFFFFFFF75A78580
	private Void ParseFreeFloatingDtd() { }

	// RVA: 0xFFFFFFFF75A79AFC
	private Void ParseInternalSubset() { }

	// RVA: 0xFFFFFFFF75A79B00
	private Void ParseExternalSubset() { }

	// RVA: 0xFFFFFFFF75A79CC8
	private Void ParseSubset() { }

	// RVA: 0xFFFFFFFF75A7A068
	private Void ParseAttlistDecl() { }

	// RVA: 0xFFFFFFFF75A7B9E0
	private Void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, Boolean ignoreErrors) { }

	// RVA: 0xFFFFFFFF75A7BF6C
	private Void ParseAttlistDefault(SchemaAttDef attrDef, Boolean ignoreErrors) { }

	// RVA: 0xFFFFFFFF75A7A59C
	private Void ParseElementDecl() { }

	// RVA: 0xFFFFFFFF75A7C714
	private Void ParseElementOnlyContent(ParticleContentValidator pcv, Int32 startParenEntityId) { }

	// RVA: 0xFFFFFFFF75A7CA58
	private Void ParseHowMany(ParticleContentValidator pcv) { }

	// RVA: 0xFFFFFFFF75A7C494
	private Void ParseElementMixedContent(ParticleContentValidator pcv, Int32 startParenEntityId) { }

	// RVA: 0xFFFFFFFF75A7A908
	private Void ParseEntityDecl() { }

	// RVA: 0xFFFFFFFF75A7AC80
	private Void ParseNotationDecl() { }

	// RVA: 0xFFFFFFFF75A7C20C
	private Void AddUndeclaredNotation(String notationName) { }

	// RVA: 0xFFFFFFFF75A7AE88
	private Void ParseComment() { }

	// RVA: 0xFFFFFFFF75A7B0EC
	private Void ParsePI() { }

	// RVA: 0xFFFFFFFF75A7B268
	private Void ParseCondSection() { }

	// RVA: 0xFFFFFFFF75A795F8
	private Void ParseExternalId(Token idTokenType, Token declType, out String publicId, out String systemId) { }

	// RVA: 0xFFFFFFFF75A78B3C
	private Token GetToken(Boolean needWhiteSpace) { }

	// RVA: 0xFFFFFFFF75A7D210
	private Token ScanSubsetContent() { }

	// RVA: 0xFFFFFFFF75A7D184
	private Token ScanNameExpected() { }

	// RVA: 0xFFFFFFFF75A7D1B4
	private Token ScanQNameExpected() { }

	// RVA: 0xFFFFFFFF75A7D1E4
	private Token ScanNmtokenExpected() { }

	// RVA: 0xFFFFFFFF75A7D990
	private Token ScanDoctype1() { }

	// RVA: 0xFFFFFFFF75A7DAF8
	private Token ScanDoctype2() { }

	// RVA: 0xFFFFFFFF75A7FEFC
	private Token ScanClosingTag() { }

	// RVA: 0xFFFFFFFF75A7DBB8
	private Token ScanElement1() { }

	// RVA: 0xFFFFFFFF75A7DDAC
	private Token ScanElement2() { }

	// RVA: 0xFFFFFFFF75A7DF80
	private Token ScanElement3() { }

	// RVA: 0xFFFFFFFF75A7E014
	private Token ScanElement4() { }

	// RVA: 0xFFFFFFFF75A7E0FC
	private Token ScanElement5() { }

	// RVA: 0xFFFFFFFF75A7E200
	private Token ScanElement6() { }

	// RVA: 0xFFFFFFFF75A7E298
	private Token ScanElement7() { }

	// RVA: 0xFFFFFFFF75A7E304
	private Token ScanAttlist1() { }

	// RVA: 0xFFFFFFFF75A7E3D0
	private Token ScanAttlist2() { }

	// RVA: 0xFFFFFFFF75A7EADC
	private Token ScanAttlist3() { }

	// RVA: 0xFFFFFFFF75A7EB54
	private Token ScanAttlist4() { }

	// RVA: 0xFFFFFFFF75A7EBEC
	private Token ScanAttlist5() { }

	// RVA: 0xFFFFFFFF75A7EC84
	private Token ScanAttlist6() { }

	// RVA: 0xFFFFFFFF75A7F054
	private Token ScanAttlist7() { }

	// RVA: 0xFFFFFFFF75A80570
	private Token ScanLiteral(LiteralType literalType) { }

	// RVA: 0xFFFFFFFF75A810DC
	private XmlQualifiedName ScanEntityName() { }

	// RVA: 0xFFFFFFFF75A7F108
	private Token ScanNotation1() { }

	// RVA: 0xFFFFFFFF75A7F244
	private Token ScanSystemId() { }

	// RVA: 0xFFFFFFFF75A7F418
	private Token ScanEntity1() { }

	// RVA: 0xFFFFFFFF75A7F4A0
	private Token ScanEntity2() { }

	// RVA: 0xFFFFFFFF75A7F610
	private Token ScanEntity3() { }

	// RVA: 0xFFFFFFFF75A7F2F0
	private Token ScanPublicId1() { }

	// RVA: 0xFFFFFFFF75A7F39C
	private Token ScanPublicId2() { }

	// RVA: 0xFFFFFFFF75A7F724
	private Token ScanCondSection1() { }

	// RVA: 0xFFFFFFFF75A7FA04
	private Token ScanCondSection2() { }

	// RVA: 0xFFFFFFFF75A7FA88
	private Token ScanCondSection3() { }

	// RVA: 0xFFFFFFFF75A80200
	private Void ScanName() { }

	// RVA: 0xFFFFFFFF75A80208
	private Void ScanQName() { }

	// RVA: 0xFFFFFFFF75A81458
	private Void ScanQName(Boolean isQName) { }

	// RVA: 0xFFFFFFFF75A816D0
	private Boolean ReadDataInName() { }

	// RVA: 0xFFFFFFFF75A80210
	private Void ScanNmtoken() { }

	// RVA: 0xFFFFFFFF75A80380
	private Boolean EatPublicKeyword() { }

	// RVA: 0xFFFFFFFF75A80478
	private Boolean EatSystemKeyword() { }

	// RVA: 0xFFFFFFFF75A79498
	private XmlQualifiedName GetNameQualified(Boolean canHavePrefix) { }

	// RVA: 0xFFFFFFFF75A7C1F0
	private String GetNameString() { }

	// RVA: 0xFFFFFFFF75A7C3A0
	private String GetNmtokenString() { }

	// RVA: 0xFFFFFFFF75A7C428
	private String GetValue() { }

	// RVA: 0xFFFFFFFF75A7C3BC
	private String GetValueWithStrippedSpaces() { }

	// RVA: 0xFFFFFFFF75A7FF7C
	private Int32 ReadData() { }

	// RVA: 0xFFFFFFFF75A7899C
	private Void LoadParsingBuffer() { }

	// RVA: 0xFFFFFFFF75A79AF4
	private Void SaveParsingBuffer() { }

	// RVA: 0xFFFFFFFF75A7B570
	private Void SaveParsingBuffer(Int32 internalSubsetValueEndPos) { }

	// RVA: 0xFFFFFFFF75A7D05C
	private Boolean HandleEntityReference(Boolean paramEntity, Boolean inLiteral, Boolean inAttribute) { }

	// RVA: 0xFFFFFFFF75A81918
	private Boolean HandleEntityReference(XmlQualifiedName entityName, Boolean paramEntity, Boolean inLiteral, Boolean inAttribute) { }

	// RVA: 0xFFFFFFFF75A80048
	private Boolean HandleEntityEnd(Boolean inLiteral) { }

	// RVA: 0xFFFFFFFF75A81224
	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, Boolean paramEntity, Boolean mustBeDeclared, Boolean inAttribute) { }

	// RVA: 0xFFFFFFFF75A7B4A0
	private Void SendValidationEvent(Int32 pos, XmlSeverityType severity, String code, String arg) { }

	// RVA: 0xFFFFFFFF75A7C134
	private Void SendValidationEvent(XmlSeverityType severity, String code, String arg) { }

	// RVA: 0xFFFFFFFF75A78858
	private Void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	// RVA: 0xFFFFFFFF75A7C128
	private Boolean IsAttributeValueType(Token token) { }

	// RVA: 0xFFFFFFFF75A7B6CC
	private Int32 get_LineNo() { }

	// RVA: 0xFFFFFFFF75A7B774
	private Int32 get_LinePos() { }

	// RVA: 0xFFFFFFFF75A78748
	private String get_BaseUriStr() { }

	// RVA: 0xFFFFFFFF75A7943C
	private Void OnUnexpectedError() { }

	// RVA: 0xFFFFFFFF75A7B254
	private Void Throw(Int32 curPos, String res) { }

	// RVA: 0xFFFFFFFF75A7CAE0
	private Void Throw(Int32 curPos, String res, String arg) { }

	// RVA: 0xFFFFFFFF75A7CE00
	private Void Throw(Int32 curPos, String res, String[] args) { }

	// RVA: 0xFFFFFFFF75A7B828
	private Void Throw(String res, String arg, Int32 lineNo, Int32 linePos) { }

	// RVA: 0xFFFFFFFF75A77F94
	private Void ThrowInvalidChar(Int32 pos, String data, Int32 invCharPos) { }

	// RVA: 0xFFFFFFFF75A7CFDC
	private Void ThrowInvalidChar(Char[] data, Int32 length, Int32 invCharPos) { }

	// RVA: 0xFFFFFFFF75A7B6C4
	private Void ThrowUnexpectedToken(Int32 pos, String expectedToken) { }

	// RVA: 0xFFFFFFFF75A7CCBC
	private Void ThrowUnexpectedToken(Int32 pos, String expectedToken1, String expectedToken2) { }

	// RVA: 0xFFFFFFFF75A7D0B0
	private String ParseUnexpectedToken(Int32 startPos) { }

	// RVA: 0xFFFFFFFF75A81718
	internal static String StripSpaces(String value) { }

}

// Namespace: 
private enum Token
{
	// Fields
	public Int32 value__; // 0x10
	public const Token CDATA = 0;
	public const Token ID = 1;
	public const Token IDREF = 2;
	public const Token IDREFS = 3;
	public const Token ENTITY = 4;
	public const Token ENTITIES = 5;
	public const Token NMTOKEN = 6;
	public const Token NMTOKENS = 7;
	public const Token NOTATION = 8;
	public const Token None = 9;
	public const Token PERef = 10;
	public const Token AttlistDecl = 11;
	public const Token ElementDecl = 12;
	public const Token EntityDecl = 13;
	public const Token NotationDecl = 14;
	public const Token Comment = 15;
	public const Token PI = 16;
	public const Token CondSectionStart = 17;
	public const Token CondSectionEnd = 18;
	public const Token Eof = 19;
	public const Token REQUIRED = 20;
	public const Token IMPLIED = 21;
	public const Token FIXED = 22;
	public const Token QName = 23;
	public const Token Name = 24;
	public const Token Nmtoken = 25;
	public const Token Quote = 26;
	public const Token LeftParen = 27;
	public const Token RightParen = 28;
	public const Token GreaterThan = 29;
	public const Token Or = 30;
	public const Token LeftBracket = 31;
	public const Token RightBracket = 32;
	public const Token PUBLIC = 33;
	public const Token SYSTEM = 34;
	public const Token Literal = 35;
	public const Token DOCTYPE = 36;
	public const Token NData = 37;
	public const Token Percent = 38;
	public const Token Star = 39;
	public const Token QMark = 40;
	public const Token Plus = 41;
	public const Token PCDATA = 42;
	public const Token Comma = 43;
	public const Token ANY = 44;
	public const Token EMPTY = 45;
	public const Token IGNORE = 46;
	public const Token INCLUDE = 47;
}

// Namespace: 
private enum ScanningFunction
{
	// Fields
	public Int32 value__; // 0x10
	public const ScanningFunction SubsetContent = 0;
	public const ScanningFunction Name = 1;
	public const ScanningFunction QName = 2;
	public const ScanningFunction Nmtoken = 3;
	public const ScanningFunction Doctype1 = 4;
	public const ScanningFunction Doctype2 = 5;
	public const ScanningFunction Element1 = 6;
	public const ScanningFunction Element2 = 7;
	public const ScanningFunction Element3 = 8;
	public const ScanningFunction Element4 = 9;
	public const ScanningFunction Element5 = 10;
	public const ScanningFunction Element6 = 11;
	public const ScanningFunction Element7 = 12;
	public const ScanningFunction Attlist1 = 13;
	public const ScanningFunction Attlist2 = 14;
	public const ScanningFunction Attlist3 = 15;
	public const ScanningFunction Attlist4 = 16;
	public const ScanningFunction Attlist5 = 17;
	public const ScanningFunction Attlist6 = 18;
	public const ScanningFunction Attlist7 = 19;
	public const ScanningFunction Entity1 = 20;
	public const ScanningFunction Entity2 = 21;
	public const ScanningFunction Entity3 = 22;
	public const ScanningFunction Notation1 = 23;
	public const ScanningFunction CondSection1 = 24;
	public const ScanningFunction CondSection2 = 25;
	public const ScanningFunction CondSection3 = 26;
	public const ScanningFunction Literal = 27;
	public const ScanningFunction SystemId = 28;
	public const ScanningFunction PublicId1 = 29;
	public const ScanningFunction PublicId2 = 30;
	public const ScanningFunction ClosingTag = 31;
	public const ScanningFunction ParamEntitySpace = 32;
	public const ScanningFunction None = 33;
}

// Namespace: 
private enum LiteralType
{
	// Fields
	public Int32 value__; // 0x10
	public const LiteralType AttributeValue = 0;
	public const LiteralType EntityReplText = 1;
	public const LiteralType SystemOrPublicID = 2;
}

// Namespace: 
private class UndeclaredNotation
{
	// Fields
	internal String name; // 0x10
	internal Int32 lineNo; // 0x18
	internal Int32 linePos; // 0x1C
	internal UndeclaredNotation next; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75A81BE4
	internal Void .ctor(String name, Int32 lineNo, Int32 linePos) { }

}

// Namespace: 
private class ParseElementOnlyContent_LocalFrame
{
	// Fields
	public Int32 startParenEntityId; // 0x10
	public Token parsingSchema; // 0x14

	// Methods

	// RVA: 0xFFFFFFFF75A81BD8
	public Void .ctor(Int32 startParentEntityIdParam) { }

}

// Namespace: System.Xml
public enum XmlTokenizedType
{
	// Fields
	public Int32 value__; // 0x10
	public const XmlTokenizedType CDATA = 0;
	public const XmlTokenizedType ID = 1;
	public const XmlTokenizedType IDREF = 2;
	public const XmlTokenizedType IDREFS = 3;
	public const XmlTokenizedType ENTITY = 4;
	public const XmlTokenizedType ENTITIES = 5;
	public const XmlTokenizedType NMTOKEN = 6;
	public const XmlTokenizedType NMTOKENS = 7;
	public const XmlTokenizedType NOTATION = 8;
	public const XmlTokenizedType ENUMERATION = 9;
	public const XmlTokenizedType QName = 10;
	public const XmlTokenizedType NCName = 11;
	public const XmlTokenizedType None = 12;
}

// Namespace: System.Xml
internal static class ValidateNames
{
	// Fields
	private static XmlCharType xmlCharType; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF72369628
	internal static Int32 ParseNmtoken(String s, Int32 offset) { }

	// RVA: 0xFFFFFFFF75ABCFD8
	internal static Int32 ParseNmtokenNoNamespaces(String s, Int32 offset) { }

	// RVA: 0xFFFFFFFF75ABD0B0
	internal static Int32 ParseNameNoNamespaces(String s, Int32 offset) { }

	// RVA: 0xFFFFFFFF75ABD1E0
	internal static Boolean IsNameNoNamespaces(String s) { }

	// RVA: 0xFFFFFFFF72369730
	internal static Int32 ParseNCName(String s, Int32 offset) { }

	// RVA: 0xFFFFFFFF72369860
	internal static Int32 ParseNCName(String s) { }

	// RVA: 0xFFFFFFFF75ABD248
	internal static Int32 ParseQName(String s, Int32 offset, out Int32 colonOffset) { }

	// RVA: 0xFFFFFFFF75ABD2F8
	internal static Void ParseQNameThrow(String s, out String prefix, out String localName) { }

	// RVA: 0xFFFFFFFF75ABD414
	internal static Void ThrowInvalidName(String s, Int32 offsetStartChar, Int32 offsetBadChar) { }

	// RVA: 0xFFFFFFFF75ABD60C
	internal static Exception GetInvalidNameException(String s, Int32 offsetStartChar, Int32 offsetBadChar) { }

	// RVA: 0xFFFFFFFF75ABD774
	private static Void .cctor() { }

}

// Namespace: System.Xml
internal struct XmlCharType
{
	// Fields
	private static Object s_Lock; // 0x0
	private static Byte[] s_CharProperties; // 0x8
	internal Byte[] charProperties; // 0x10

	// Properties
	private static Object StaticLock { get; }
	public static XmlCharType Instance { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AC3614
	private static Object get_StaticLock() { }

	// RVA: 0xFFFFFFFF75AC366C
	private static Void InitInstance() { }

	// RVA: 0xFFFFFFFF7236A494
	private static Void SetProperties(String ranges, Byte value) { }

	// RVA: 0xFFFFFFFF7114591C
	private Void .ctor(Byte[] charProperties) { }

	// RVA: 0xFFFFFFFF723698A8
	public static XmlCharType get_Instance() { }

	// RVA: 0xFFFFFFFF71145954
	public Boolean IsWhiteSpace(Char ch) { }

	// RVA: 0xFFFFFFFF7114595C
	public Boolean IsNCNameSingleChar(Char ch) { }

	// RVA: 0xFFFFFFFF71145964
	public Boolean IsStartNCNameSingleChar(Char ch) { }

	// RVA: 0xFFFFFFFF7114596C
	public Boolean IsNameSingleChar(Char ch) { }

	// RVA: 0xFFFFFFFF71145998
	public Boolean IsCharData(Char ch) { }

	// RVA: 0xFFFFFFFF711459A0
	public Boolean IsPubidChar(Char ch) { }

	// RVA: 0xFFFFFFFF75AC394C
	public static Boolean IsDigit(Char ch) { }

	// RVA: 0xFFFFFFFF75AC3970
	internal static Boolean IsHighSurrogate(Int32 ch) { }

	// RVA: 0xFFFFFFFF75AC3980
	internal static Boolean IsLowSurrogate(Int32 ch) { }

	// RVA: 0xFFFFFFFF75ABC154
	internal static Boolean IsSurrogate(Int32 ch) { }

	// RVA: 0xFFFFFFFF75AC3990
	internal static Int32 CombineSurrogateChar(Int32 lowChar, Int32 highChar) { }

	// RVA: 0xFFFFFFFF75AC39A8
	internal static Void SplitSurrogateChar(Int32 combinedChar, out Char lowChar, out Char highChar) { }

	// RVA: 0xFFFFFFFF711459A4
	internal Boolean IsOnlyWhitespace(String str) { }

	// RVA: 0xFFFFFFFF711459C4
	internal Int32 IsOnlyWhitespaceWithPos(String str) { }

	// RVA: 0xFFFFFFFF711459CC
	internal Int32 IsOnlyCharData(String str) { }

	// RVA: 0xFFFFFFFF7236A578
	internal static Boolean IsOnlyDigits(String str, Int32 startPos, Int32 len) { }

	// RVA: 0xFFFFFFFF711459D4
	internal Int32 IsPublicId(String str) { }

	// RVA: 0xFFFFFFFF75AC395C
	private static Boolean InRange(Int32 value, Int32 start, Int32 end) { }

}

// Namespace: System.Xml
internal static class XmlComplianceUtil
{
	// Methods

	// RVA: 0xFFFFFFFF75AC4170
	public static String NonCDataNormalize(String value) { }

	// RVA: 0xFFFFFFFF75AC43E4
	public static String CDataNormalize(String value) { }

}

// Namespace: System.Xml
internal enum ExceptionType
{
	// Fields
	public Int32 value__; // 0x10
	public const ExceptionType ArgumentException = 0;
	public const ExceptionType XmlException = 1;
}

// Namespace: System.Xml
public class XmlConvert
{
	// Fields
	private static XmlCharType xmlCharType; // 0x0
	internal static Char[] crt; // 0x8
	private static readonly Int32 c_EncodedCharLength; // 0x10
	internal static readonly Char[] WhitespaceChars; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75AC459C
	internal static Byte[] FromBinHexString(String s, Boolean allowOddCount) { }

	// RVA: 0xFFFFFFFF75AA9B1C
	internal static String ToBinHexString(Byte[] inArray) { }

	// RVA: 0xFFFFFFFF75AC462C
	public static String VerifyName(String name) { }

	// RVA: 0xFFFFFFFF75AC4814
	internal static Exception TryVerifyName(String name) { }

	// RVA: 0xFFFFFFFF75AC492C
	internal static Exception TryVerifyNCName(String name) { }

	// RVA: 0xFFFFFFFF75AC49A0
	internal static Exception TryVerifyTOKEN(String token) { }

	// RVA: 0xFFFFFFFF75AC4AB4
	internal static Exception TryVerifyNMTOKEN(String name) { }

	// RVA: 0xFFFFFFFF75AC4B8C
	internal static Exception TryVerifyNormalizedString(String str) { }

	// RVA: 0xFFFFFFFF75AA57C0
	public static String ToString(Boolean value) { }

	// RVA: 0xFFFFFFFF75AABE5C
	public static String ToString(Decimal value) { }

	// RVA: 0xFFFFFFFF75AB42F8
	public static String ToString(SByte value) { }

	// RVA: 0xFFFFFFFF75AB42C0
	public static String ToString(Int16 value) { }

	// RVA: 0xFFFFFFFF75AABEF4
	public static String ToString(Int32 value) { }

	// RVA: 0xFFFFFFFF75AABF8C
	public static String ToString(Int64 value) { }

	// RVA: 0xFFFFFFFF75AB4288
	public static String ToString(Byte value) { }

	// RVA: 0xFFFFFFFF75AB4330
	public static String ToString(UInt16 value) { }

	// RVA: 0xFFFFFFFF75AB4368
	public static String ToString(UInt32 value) { }

	// RVA: 0xFFFFFFFF75AB43A0
	public static String ToString(UInt64 value) { }

	// RVA: 0xFFFFFFFF75AAE3B4
	public static String ToString(Single value) { }

	// RVA: 0xFFFFFFFF75AAE4C8
	public static String ToString(Double value) { }

	// RVA: 0xFFFFFFFF75AA53DC
	public static Boolean ToBoolean(String s) { }

	// RVA: 0xFFFFFFFF75AC4CEC
	internal static Exception TryToBoolean(String s, out Boolean result) { }

	// RVA: 0xFFFFFFFF75AC4E64
	public static Char ToChar(String s) { }

	// RVA: 0xFFFFFFFF75AC4F38
	internal static Exception TryToChar(String s, out Char result) { }

	// RVA: 0xFFFFFFFF75AAAE20
	public static Decimal ToDecimal(String s) { }

	// RVA: 0xFFFFFFFF75AC5040
	internal static Exception TryToDecimal(String s, out Decimal result) { }

	// RVA: 0xFFFFFFFF75AAAE74
	internal static Decimal ToInteger(String s) { }

	// RVA: 0xFFFFFFFF75AC515C
	internal static Exception TryToInteger(String s, out Decimal result) { }

	// RVA: 0xFFFFFFFF75AC5284
	internal static Exception TryToSByte(String s, out SByte result) { }

	// RVA: 0xFFFFFFFF75AC5380
	internal static Exception TryToInt16(String s, out Int16 result) { }

	// RVA: 0xFFFFFFFF75AAB660
	public static Int32 ToInt32(String s) { }

	// RVA: 0xFFFFFFFF75AC547C
	internal static Exception TryToInt32(String s, out Int32 result) { }

	// RVA: 0xFFFFFFFF75AABA98
	public static Int64 ToInt64(String s) { }

	// RVA: 0xFFFFFFFF75AC5578
	internal static Exception TryToInt64(String s, out Int64 result) { }

	// RVA: 0xFFFFFFFF75AC5674
	internal static Exception TryToByte(String s, out Byte result) { }

	// RVA: 0xFFFFFFFF75AC5770
	internal static Exception TryToUInt16(String s, out UInt16 result) { }

	// RVA: 0xFFFFFFFF75AC586C
	internal static Exception TryToUInt32(String s, out UInt32 result) { }

	// RVA: 0xFFFFFFFF75AC5968
	internal static Exception TryToUInt64(String s, out UInt64 result) { }

	// RVA: 0xFFFFFFFF75AADB28
	public static Single ToSingle(String s) { }

	// RVA: 0xFFFFFFFF75AC5A64
	internal static Exception TryToSingle(String s, out Single result) { }

	// RVA: 0xFFFFFFFF75AADC30
	public static Double ToDouble(String s) { }

	// RVA: 0xFFFFFFFF75AC5C28
	internal static Exception TryToDouble(String s, out Double result) { }

	// RVA: 0xFFFFFFFF75AC5E0C
	internal static Double ToXPathDouble(Object o) { }

	// RVA: 0xFFFFFFFF75AC602C
	internal static Double XPathRound(Double value) { }

	// RVA: 0xFFFFFFFF75AC60F0
	internal static Exception TryToTimeSpan(String s, out TimeSpan result) { }

	// RVA: 0xFFFFFFFF75AC6184
	public static Guid ToGuid(String s) { }

	// RVA: 0xFFFFFFFF75AC61B4
	internal static Exception TryToGuid(String s, out Guid result) { }

	// RVA: 0xFFFFFFFF75AAA048
	internal static Uri ToUri(String s) { }

	// RVA: 0xFFFFFFFF75AC63E8
	internal static Exception TryToUri(String s, out Uri result) { }

	// RVA: 0xFFFFFFFF75AC657C
	internal static Boolean StrEqual(Char[] chars, Int32 strPos1, Int32 strLen1, String str2) { }

	// RVA: 0xFFFFFFFF75AC4C98
	internal static String TrimString(String value) { }

	// RVA: 0xFFFFFFFF75AA9618
	internal static String[] SplitString(String value) { }

	// RVA: 0xFFFFFFFF75AC4C44
	internal static Boolean IsNegativeZero(Double value) { }

	// RVA: 0xFFFFFFFF75AC6660
	private static Int64 DoubleToInt64Bits(Double value) { }

	// RVA: 0xFFFFFFFF75AC6668
	internal static Exception CreateException(String res, String arg, ExceptionType exceptionType, Int32 lineNo, Int32 linePos) { }

	// RVA: 0xFFFFFFFF75AC6734
	internal static Exception CreateException(String res, String[] args, ExceptionType exceptionType, Int32 lineNo, Int32 linePos) { }

	// RVA: 0xFFFFFFFF75AC67D0
	internal static Exception CreateInvalidSurrogatePairException(Char low, Char hi) { }

	// RVA: 0xFFFFFFFF75AC6818
	internal static Exception CreateInvalidSurrogatePairException(Char low, Char hi, ExceptionType exceptionType) { }

	// RVA: 0xFFFFFFFF75AC6874
	internal static Exception CreateInvalidSurrogatePairException(Char low, Char hi, ExceptionType exceptionType, Int32 lineNo, Int32 linePos) { }

	// RVA: 0xFFFFFFFF75AC69C4
	internal static Exception CreateInvalidHighSurrogateCharException(Char hi) { }

	// RVA: 0xFFFFFFFF75AC6A04
	internal static Exception CreateInvalidHighSurrogateCharException(Char hi, ExceptionType exceptionType) { }

	// RVA: 0xFFFFFFFF75AC6A50
	internal static Exception CreateInvalidHighSurrogateCharException(Char hi, ExceptionType exceptionType, Int32 lineNo, Int32 linePos) { }

	// RVA: 0xFFFFFFFF75AC4768
	internal static Exception CreateInvalidNameCharException(String name, Int32 index, ExceptionType exceptionType) { }

	// RVA: 0xFFFFFFFF75AC6B2C
	internal static ArgumentException CreateInvalidNameArgumentException(String name, String argumentName) { }

	// RVA: 0xFFFFFFFF75AC6BAC
	private static Void .cctor() { }

}

// Namespace: System.Xml
internal class XmlDownloadManager
{
	// Fields
	private Hashtable connections; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75ACBC88
	internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0xFFFFFFFF75ACBD54
	private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0xFFFFFFFF75ACC2A8
	internal Void Remove(String host) { }

	// RVA: 0xFFFFFFFF75ACC3E4
	internal Task<T0> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0xFFFFFFFF75ACC54C
	private Task<T0> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0xFFFFFFFF75ACC71C
	public Void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Uri uri; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75ACC548
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75ACC720
	internal Stream <GetStreamAsync>b__0() { }

}

// Namespace: 
private struct <GetNonFileStreamAsync>d__5
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder<T0> <>t__builder; // 0x18
	public Uri uri; // 0x30
	public ICredentials credentials; // 0x38
	public IWebProxy proxy; // 0x40
	public RequestCachePolicy cachePolicy; // 0x48
	private WebRequest <req>5__1; // 0x50
	public XmlDownloadManager <>4__this; // 0x58
	private ConfiguredTaskAwaiter <>u__1; // 0x60

	// Methods

	// RVA: 0xFFFFFFFF711459D8
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF711459E0
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Xml
internal class OpenedHost
{
	// Fields
	internal Int32 nonCachedConnectionsCount; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75A8222C
	public Void .ctor() { }

}

// Namespace: System.Xml
internal class XmlRegisteredNonCachedStream
{
	// Fields
	protected Stream stream; // 0x28
	private XmlDownloadManager downloadManager; // 0x30
	private String host; // 0x38

	// Properties
	public override Boolean CanRead { get; }
	public override Boolean CanSeek { get; }
	public override Boolean CanWrite { get; }
	public override Int64 Length { get; }
	public override Int64 Position { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75ACC1EC
	internal Void .ctor(Stream stream, XmlDownloadManager downloadManager, String host) { }

	// RVA: 0xFFFFFFFF75AD922C
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75AD92C0
	protected override Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF75AD93C8
	public override IAsyncResult BeginRead(Byte[] buffer, Int32 offset, Int32 count, AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75AD93F0
	public override IAsyncResult BeginWrite(Byte[] buffer, Int32 offset, Int32 count, AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF75AD9418
	public override Int32 EndRead(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75AD9440
	public override Void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0xFFFFFFFF75AD9468
	public override Void Flush() { }

	// RVA: 0xFFFFFFFF75AD9490
	public override Int32 Read(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF75AD94B8
	public override Int32 ReadByte() { }

	// RVA: 0xFFFFFFFF75AD94E0
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xFFFFFFFF75AD9508
	public override Void SetLength(Int64 value) { }

	// RVA: 0xFFFFFFFF75AD9530
	public override Void Write(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF75AD9558
	public override Void WriteByte(Byte value) { }

	// RVA: 0xFFFFFFFF75AD9580
	public override Boolean get_CanRead() { }

	// RVA: 0xFFFFFFFF75AD95A8
	public override Boolean get_CanSeek() { }

	// RVA: 0xFFFFFFFF75AD95D0
	public override Boolean get_CanWrite() { }

	// RVA: 0xFFFFFFFF75AD95F8
	public override Int64 get_Length() { }

	// RVA: 0xFFFFFFFF75AD9620
	public override Int64 get_Position() { }

	// RVA: 0xFFFFFFFF75AD9648
	public override Void set_Position(Int64 value) { }

}

// Namespace: System.Xml
internal class XmlCachedStream
{
	// Fields
	private Uri uri; // 0x50

	// Methods

	// RVA: 0xFFFFFFFF75AC34F0
	internal Void .ctor(Uri uri, Stream stream) { }

}

// Namespace: System.Xml
internal class UTF16Decoder
{
	// Fields
	private Boolean bigEndian; // 0x20
	private Int32 lastByte; // 0x24

	// Methods

	// RVA: 0xFFFFFFFF75ABB43C
	public Void .ctor(Boolean bigEndian) { }

	// RVA: 0xFFFFFFFF75ABB470
	public override Int32 GetCharCount(Byte[] bytes, Int32 index, Int32 count) { }

	// RVA: 0xFFFFFFFF75ABB484
	public override Int32 GetCharCount(Byte[] bytes, Int32 index, Int32 count, Boolean flush) { }

	// RVA: 0xFFFFFFFF75ABB588
	public override Int32 GetChars(Byte[] bytes, Int32 byteIndex, Int32 byteCount, Char[] chars, Int32 charIndex) { }

	// RVA: 0xFFFFFFFF75ABB7C0
	public override Void Convert(Byte[] bytes, Int32 byteIndex, Int32 byteCount, Char[] chars, Int32 charIndex, Int32 charCount, Boolean flush, out Int32 bytesUsed, out Int32 charsUsed, out Boolean completed) { }

}

// Namespace: System.Xml
internal class SafeAsciiDecoder
{
	// Methods

	// RVA: 0xFFFFFFFF75A8224C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A82254
	public override Int32 GetCharCount(Byte[] bytes, Int32 index, Int32 count) { }

	// RVA: 0xFFFFFFFF75A8225C
	public override Int32 GetChars(Byte[] bytes, Int32 byteIndex, Int32 byteCount, Char[] chars, Int32 charIndex) { }

	// RVA: 0xFFFFFFFF75A822D8
	public override Void Convert(Byte[] bytes, Int32 byteIndex, Int32 byteCount, Char[] chars, Int32 charIndex, Int32 charCount, Boolean flush, out Int32 bytesUsed, out Int32 charsUsed, out Boolean completed) { }

}

// Namespace: System.Xml
internal class Ucs4Encoding
{
	// Fields
	internal Ucs4Decoder ucs4Decoder; // 0x38

	// Properties
	public override String WebName { get; }
	public override Int32 CodePage { get; }
	internal static Encoding UCS4_Littleendian { get; }
	internal static Encoding UCS4_Bigendian { get; }
	internal static Encoding UCS4_2143 { get; }
	internal static Encoding UCS4_3412 { get; }

	// Methods

	// RVA: 0xFFFFFFFF75ABC904
	public override String get_WebName() { }

	// RVA: 0xFFFFFFFF75ABC914
	public override Decoder GetDecoder() { }

	// RVA: 0xFFFFFFFF75ABC91C
	public override Int32 GetByteCount(Char[] chars, Int32 index, Int32 count) { }

	// RVA: 0xFFFFFFFF75ABC980
	public override Byte[] GetBytes(String s) { }

	// RVA: 0xFFFFFFFF75ABC988
	public override Int32 GetBytes(Char[] chars, Int32 charIndex, Int32 charCount, Byte[] bytes, Int32 byteIndex) { }

	// RVA: 0xFFFFFFFF75ABC990
	public override Int32 GetMaxByteCount(Int32 charCount) { }

	// RVA: 0xFFFFFFFF75ABC998
	public override Int32 GetCharCount(Byte[] bytes, Int32 index, Int32 count) { }

	// RVA: 0xFFFFFFFF75ABC9C0
	public override Int32 GetChars(Byte[] bytes, Int32 byteIndex, Int32 byteCount, Char[] chars, Int32 charIndex) { }

	// RVA: 0xFFFFFFFF75ABC9E8
	public override Int32 GetMaxCharCount(Int32 byteCount) { }

	// RVA: 0xFFFFFFFF75ABCA00
	public override Int32 get_CodePage() { }

	// RVA: 0xFFFFFFFF75ABCA08
	public override Encoder GetEncoder() { }

	// RVA: 0xFFFFFFFF75ABCA10
	internal static Encoding get_UCS4_Littleendian() { }

	// RVA: 0xFFFFFFFF75ABCB18
	internal static Encoding get_UCS4_Bigendian() { }

	// RVA: 0xFFFFFFFF75ABCC20
	internal static Encoding get_UCS4_2143() { }

	// RVA: 0xFFFFFFFF75ABCD28
	internal static Encoding get_UCS4_3412() { }

	// RVA: 0xFFFFFFFF75ABCE30
	public Void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding1234
{
	// Properties
	public override String EncodingName { get; }

	// Methods

	// RVA: 0xFFFFFFFF75ABCB68
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75ABCE38
	public override String get_EncodingName() { }

	// RVA: 0xFFFFFFFF75ABCE78
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding4321
{
	// Properties
	public override String EncodingName { get; }

	// Methods

	// RVA: 0xFFFFFFFF75ABCA60
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75ABCF70
	public override String get_EncodingName() { }

	// RVA: 0xFFFFFFFF75ABCFB0
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding2143
{
	// Properties
	public override String EncodingName { get; }

	// Methods

	// RVA: 0xFFFFFFFF75ABCC70
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75ABCEA0
	public override String get_EncodingName() { }

	// RVA: 0xFFFFFFFF75ABCEE0
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding3412
{
	// Properties
	public override String EncodingName { get; }

	// Methods

	// RVA: 0xFFFFFFFF75ABCD78
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75ABCF08
	public override String get_EncodingName() { }

	// RVA: 0xFFFFFFFF75ABCF48
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal abstract class Ucs4Decoder
{
	// Fields
	internal Byte[] lastBytes; // 0x20
	internal Int32 lastBytesCount; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75ABBA58
	public override Int32 GetCharCount(Byte[] bytes, Int32 index, Int32 count) { }

	// RVA: -1
	internal abstract Int32 GetFullChars(Byte[] bytes, Int32 byteIndex, Int32 byteCount, Char[] chars, Int32 charIndex) { }

	// RVA: 0xFFFFFFFF75ABBA74
	public override Int32 GetChars(Byte[] bytes, Int32 byteIndex, Int32 byteCount, Char[] chars, Int32 charIndex) { }

	// RVA: 0xFFFFFFFF75ABBC2C
	public override Void Convert(Byte[] bytes, Int32 byteIndex, Int32 byteCount, Char[] chars, Int32 charIndex, Int32 charCount, Boolean flush, out Int32 bytesUsed, out Int32 charsUsed, out Boolean completed) { }

	// RVA: 0xFFFFFFFF75ABBE80
	internal Void Ucs4ToUTF16(UInt32 code, Char[] chars, Int32 charIndex) { }

	// RVA: 0xFFFFFFFF75ABBEE4
	protected Void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder4321
{
	// Methods

	// RVA: 0xFFFFFFFF75ABC694
	internal override Int32 GetFullChars(Byte[] bytes, Int32 byteIndex, Int32 byteCount, Char[] chars, Int32 charIndex) { }

	// RVA: 0xFFFFFFFF75ABC8B4
	public Void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder1234
{
	// Methods

	// RVA: 0xFFFFFFFF75ABBF34
	internal override Int32 GetFullChars(Byte[] bytes, Int32 byteIndex, Int32 byteCount, Char[] chars, Int32 charIndex) { }

	// RVA: 0xFFFFFFFF75ABC164
	public Void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder2143
{
	// Methods

	// RVA: 0xFFFFFFFF75ABC1B4
	internal override Int32 GetFullChars(Byte[] bytes, Int32 byteIndex, Int32 byteCount, Char[] chars, Int32 charIndex) { }

	// RVA: 0xFFFFFFFF75ABC3D4
	public Void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder3412
{
	// Methods

	// RVA: 0xFFFFFFFF75ABC424
	internal override Int32 GetFullChars(Byte[] bytes, Int32 byteIndex, Int32 byteCount, Char[] chars, Int32 charIndex) { }

	// RVA: 0xFFFFFFFF75ABC644
	public Void .ctor() { }

}

// Namespace: System.Xml
public class XmlException
{
	// Fields
	private String res; // 0x88
	private String[] args; // 0x90
	private Int32 lineNumber; // 0x98
	private Int32 linePosition; // 0x9C
	private String sourceUri; // 0xA0
	private String message; // 0xA8

	// Properties
	public Int32 LineNumber { get; }
	public Int32 LinePosition { get; }
	public override String Message { get; }
	internal String ResString { get; }

	// Methods

	// RVA: 0xFFFFFFFF75ACEF0C
	protected Void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF75ACF4B0
	public override Void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF75ACF5E8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75ACF600
	public Void .ctor(String message) { }

	// RVA: 0xFFFFFFFF75ACF614
	public Void .ctor(String message, Exception innerException, Int32 lineNumber, Int32 linePosition) { }

	// RVA: 0xFFFFFFFF75ACF61C
	internal Void .ctor(String message, Exception innerException, Int32 lineNumber, Int32 linePosition, String sourceUri) { }

	// RVA: 0xFFFFFFFF75AC72C4
	internal Void .ctor(String res, String[] args) { }

	// RVA: 0xFFFFFFFF75ACA378
	internal Void .ctor(String res, String arg) { }

	// RVA: 0xFFFFFFFF75ACF900
	internal Void .ctor(String res, String arg, String sourceUri) { }

	// RVA: 0xFFFFFFFF75ACF984
	internal Void .ctor(String res, String arg, Int32 lineNumber, Int32 linePosition) { }

	// RVA: 0xFFFFFFFF75ACFA14
	internal Void .ctor(String res, String arg, Int32 lineNumber, Int32 linePosition, String sourceUri) { }

	// RVA: 0xFFFFFFFF75ACFAA8
	internal Void .ctor(String res, String[] args, Int32 lineNumber, Int32 linePosition) { }

	// RVA: 0xFFFFFFFF75ACFABC
	internal Void .ctor(String res, String[] args, Int32 lineNumber, Int32 linePosition, String sourceUri) { }

	// RVA: 0xFFFFFFFF75ACFAD0
	internal Void .ctor(String res, String[] args, Exception innerException, Int32 lineNumber, Int32 linePosition) { }

	// RVA: 0xFFFFFFFF75ACF828
	internal Void .ctor(String res, String[] args, Exception innerException, Int32 lineNumber, Int32 linePosition, String sourceUri) { }

	// RVA: 0xFFFFFFFF75ACF758
	private static String FormatUserMessage(String message, Int32 lineNumber, Int32 linePosition) { }

	// RVA: 0xFFFFFFFF75ACF284
	private static String CreateMessage(String res, String[] args, Int32 lineNumber, Int32 linePosition) { }

	// RVA: 0xFFFFFFFF75AC725C
	internal static String[] BuildCharExceptionArgs(String data, Int32 invCharIndex) { }

	// RVA: 0xFFFFFFFF75ACFCC4
	internal static String[] BuildCharExceptionArgs(Char[] data, Int32 length, Int32 invCharIndex) { }

	// RVA: 0xFFFFFFFF75ACFAD8
	internal static String[] BuildCharExceptionArgs(Char invChar, Char nextChar) { }

	// RVA: 0xFFFFFFFF75ACFD24
	public Int32 get_LineNumber() { }

	// RVA: 0xFFFFFFFF75ACFD2C
	public Int32 get_LinePosition() { }

	// RVA: 0xFFFFFFFF75ACFD34
	public override String get_Message() { }

	// RVA: 0xFFFFFFFF75ACFD4C
	internal String get_ResString() { }

}

// Namespace: System.Xml
public abstract class XmlNameTable
{
	// Methods

	// RVA: -1
	public abstract String Get(String array) { }

	// RVA: -1
	public abstract String Add(Char[] array, Int32 offset, Int32 length) { }

	// RVA: -1
	public abstract String Add(String array) { }

	// RVA: 0xFFFFFFFF7236D8E0
	protected Void .ctor() { }

}

// Namespace: System.Xml
public class XmlNamespaceManager
{
	// Fields
	private static IXmlNamespaceResolver s_EmptyResolver; // 0x0
	private NamespaceDeclaration[] nsdecls; // 0x10
	private Int32 lastDecl; // 0x18
	private XmlNameTable nameTable; // 0x20
	private Int32 scopeId; // 0x28
	private Dictionary<T0, T1> hashTable; // 0x30
	private Boolean useHashtable; // 0x38
	private String xml; // 0x40
	private String xmlNs; // 0x48
	private const Int32 MinDeclsCountForHashtable = 16;

	// Properties
	public virtual XmlNameTable NameTable { get; }
	public virtual String DefaultNamespace { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AD575C
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75AD29E8
	public Void .ctor(XmlNameTable nameTable) { }

	// RVA: 0xFFFFFFFF75AD57D0
	public virtual XmlNameTable get_NameTable() { }

	// RVA: 0xFFFFFFFF75AD57D8
	public virtual String get_DefaultNamespace() { }

	// RVA: 0xFFFFFFFF75AD5820
	public virtual Void PushScope() { }

	// RVA: 0xFFFFFFFF75AD5830
	public virtual Boolean PopScope() { }

	// RVA: 0xFFFFFFFF75AD58F8
	public virtual Void AddNamespace(String prefix, String uri) { }

	// RVA: 0xFFFFFFFF75AD5E78
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75AD5FA8
	public virtual String LookupNamespace(String prefix) { }

	// RVA: 0xFFFFFFFF75AD5CF4
	private Int32 LookupNamespaceDecl(String prefix) { }

	// RVA: 0xFFFFFFFF75AD6008
	public virtual String LookupPrefix(String uri) { }

}

// Namespace: 
private struct NamespaceDeclaration
{
	// Fields
	public String prefix; // 0x10
	public String uri; // 0x18
	public Int32 scopeId; // 0x20
	public Int32 previousNsIndex; // 0x24

	// Methods

	// RVA: 0xFFFFFFFF71145CB0
	public Void Set(String prefix, String uri, Int32 scopeId, Int32 previousNsIndex) { }

}

// Namespace: System.Xml
public enum XmlNodeOrder
{
	// Fields
	public Int32 value__; // 0x10
	public const XmlNodeOrder Before = 0;
	public const XmlNodeOrder After = 1;
	public const XmlNodeOrder Same = 2;
	public const XmlNodeOrder Unknown = 3;
}

// Namespace: System.Xml
public enum XmlNodeType
{
	// Fields
	public Int32 value__; // 0x10
	public const XmlNodeType None = 0;
	public const XmlNodeType Element = 1;
	public const XmlNodeType Attribute = 2;
	public const XmlNodeType Text = 3;
	public const XmlNodeType CDATA = 4;
	public const XmlNodeType EntityReference = 5;
	public const XmlNodeType Entity = 6;
	public const XmlNodeType ProcessingInstruction = 7;
	public const XmlNodeType Comment = 8;
	public const XmlNodeType Document = 9;
	public const XmlNodeType DocumentType = 10;
	public const XmlNodeType DocumentFragment = 11;
	public const XmlNodeType Notation = 12;
	public const XmlNodeType Whitespace = 13;
	public const XmlNodeType SignificantWhitespace = 14;
	public const XmlNodeType EndElement = 15;
	public const XmlNodeType EndEntity = 16;
	public const XmlNodeType XmlDeclaration = 17;
}

// Namespace: System.Xml
public class XmlQualifiedName
{
	// Fields
	private static HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private String name; // 0x10
	private String ns; // 0x18
	private Int32 hash; // 0x20
	public static readonly XmlQualifiedName Empty; // 0x8

	// Properties
	public String Namespace { get; }
	public String Name { get; }
	public Boolean IsEmpty { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AD7AEC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AD7B04
	public Void .ctor(String name) { }

	// RVA: 0xFFFFFFFF75AC84A4
	public Void .ctor(String name, String ns) { }

	// RVA: 0xFFFFFFFF75AD7B18
	public String get_Namespace() { }

	// RVA: 0xFFFFFFFF75AD7B20
	public String get_Name() { }

	// RVA: 0xFFFFFFFF75AD7B28
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75AD317C
	public Boolean get_IsEmpty() { }

	// RVA: 0xFFFFFFFF75AD8178
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75AD81BC
	public override Boolean Equals(Object other) { }

	// RVA: 0xFFFFFFFF75AD82C4
	public static Boolean op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0xFFFFFFFF75AD8278
	public static Boolean op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0xFFFFFFFF75AD7BD4
	private static HashCodeOfStringDelegate GetHashCodeDelegate() { }

	// RVA: 0xFFFFFFFF75AD8328
	private static Boolean IsRandomizedHashingDisabled() { }

	// RVA: 0xFFFFFFFF75AD8374
	private static Int32 GetHashCodeOfString(String s, Int32 length, Int64 additionalEntropy) { }

	// RVA: 0xFFFFFFFF75AD8398
	internal static XmlQualifiedName Parse(String s, IXmlNamespaceResolver nsmgr, out String prefix) { }

	// RVA: 0xFFFFFFFF75AD8528
	private static Void .cctor() { }

}

// Namespace: 
private sealed class HashCodeOfStringDelegate
{
	// Methods

	// RVA: 0xFFFFFFFF75AD8330
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75AD7D30
	public virtual Int32 Invoke(String s, Int32 sLen, Int64 additionalEntropy) { }

	// RVA: 0xFFFFFFFF75AD85C4
	public virtual IAsyncResult BeginInvoke(String s, Int32 sLen, Int64 additionalEntropy, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75AD8670
	public virtual Int32 EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Xml
public abstract class XmlResolver
{
	// Methods

	// RVA: -1
	public abstract Object GetEntity(Uri absoluteUri, String role, Type ofObjectToReturn) { }

	// RVA: 0xFFFFFFFF75AD9670
	public virtual Uri ResolveUri(Uri baseUri, String relativeUri) { }

	// RVA: 0xFFFFFFFF75AD983C
	public virtual Boolean SupportsType(Uri absoluteUri, Type type) { }

	// RVA: 0xFFFFFFFF75AD9940
	public virtual Task<T0> GetEntityAsync(Uri absoluteUri, String role, Type ofObjectToReturn) { }

	// RVA: 0xFFFFFFFF75AD9994
	protected Void .ctor() { }

}

// Namespace: System.Xml
public class XmlUrlResolver
{
	// Fields
	private static Object s_DownloadManager; // 0x0
	private ICredentials _credentials; // 0x10
	private IWebProxy _proxy; // 0x18
	private RequestCachePolicy _cachePolicy; // 0x20

	// Properties
	private static XmlDownloadManager DownloadManager { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AEF0F4
	private static XmlDownloadManager get_DownloadManager() { }

	// RVA: 0xFFFFFFFF75AEF1C8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AEF1D0
	public override Object GetEntity(Uri absoluteUri, String role, Type ofObjectToReturn) { }

	// RVA: 0xFFFFFFFF75AEF30C
	public override Uri ResolveUri(Uri baseUri, String relativeUri) { }

	// RVA: 0xFFFFFFFF75AEF314
	public override Task<T0> GetEntityAsync(Uri absoluteUri, String role, Type ofObjectToReturn) { }

}

// Namespace: 
private struct <GetEntityAsync>d__15
{
	// Fields
	public Int32 <>1__state; // 0x10
	public AsyncTaskMethodBuilder<T0> <>t__builder; // 0x18
	public Type ofObjectToReturn; // 0x30
	public Uri absoluteUri; // 0x38
	public XmlUrlResolver <>4__this; // 0x40
	private ConfiguredTaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0xFFFFFFFF71146108
	private Void MoveNext() { }

	// RVA: 0xFFFFFFFF71146110
	private Void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Xml
internal static class Res
{
	// Methods

	// RVA: 0xFFFFFFFF75A81CBC
	public static String GetString(String name) { }

	// RVA: 0xFFFFFFFF75A8223C
	public static String GetString(String name, Object[] args) { }

}

// Namespace: System.Xml.XPath
public interface IXPathNavigable
{
	// Methods

	// RVA: -1
	public abstract XPathNavigator CreateNavigator() { }

}

// Namespace: System.Xml.XPath
public class XPathDocument
{
	// Fields
	private XPathNode[] pageText; // 0x10
	private XPathNode[] pageRoot; // 0x18
	private XPathNode[] pageXmlNmsp; // 0x20
	private Int32 idxText; // 0x28
	private Int32 idxRoot; // 0x2C
	private Int32 idxXmlNmsp; // 0x30
	private XmlNameTable nameTable; // 0x38
	private Dictionary<T0, T1> mapNmsp; // 0x40
	private Dictionary<T0, T1> idValueMap; // 0x48

	// Properties
	internal XmlNameTable NameTable { get; }

	// Methods

	// RVA: 0xFFFFFFFF75ABD7B8
	internal XmlNameTable get_NameTable() { }

	// RVA: 0xFFFFFFFF75ABD7C0
	internal Int32 GetCollapsedTextNode(out XPathNode[] pageText) { }

	// RVA: 0xFFFFFFFF75ABD800
	internal Int32 GetRootNode(out XPathNode[] pageRoot) { }

	// RVA: 0xFFFFFFFF75ABD840
	internal Int32 GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

	// RVA: 0xFFFFFFFF75ABD880
	internal Int32 LookupNamespaces(XPathNode[] pageElem, Int32 idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0xFFFFFFFF75ABD974
	internal Int32 LookupIdElement(String id, out XPathNode[] pageElem) { }

}

// Namespace: System.Xml.XPath
public class XPathException
{
	// Fields
	private String res; // 0x88
	private String[] args; // 0x90
	private String message; // 0x98

	// Properties
	public override String Message { get; }

	// Methods

	// RVA: 0xFFFFFFFF75ABDA38
	protected Void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF75ABDD60
	public override Void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF75ABDE2C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75ABDEA4
	public Void .ctor(String message, Exception innerException) { }

	// RVA: 0xFFFFFFFF75ABDFB4
	internal static XPathException Create(String res) { }

	// RVA: 0xFFFFFFFF75ABE01C
	internal static XPathException Create(String res, String arg) { }

	// RVA: 0xFFFFFFFF75ABE0B8
	internal static XPathException Create(String res, String arg, String arg2) { }

	// RVA: 0xFFFFFFFF75ABE17C
	internal static XPathException Create(String res, String arg, Exception innerException) { }

	// RVA: 0xFFFFFFFF75ABE014
	private Void .ctor(String res, String[] args) { }

	// RVA: 0xFFFFFFFF75ABDF1C
	private Void .ctor(String res, String[] args, Exception inner) { }

	// RVA: 0xFFFFFFFF75ABDC44
	private static String CreateMessage(String res, String[] args) { }

	// RVA: 0xFFFFFFFF75ABE224
	public override String get_Message() { }

}

// Namespace: System.Xml.XPath
public enum XPathResultType
{
	// Fields
	public Int32 value__; // 0x10
	public const XPathResultType Number = 0;
	public const XPathResultType String = 1;
	public const XPathResultType Boolean = 2;
	public const XPathResultType NodeSet = 3;
	public const XPathResultType Navigator = 1;
	public const XPathResultType Any = 5;
	public const XPathResultType Error = 6;
}

// Namespace: System.Xml.XPath
public abstract class XPathExpression
{
	// Methods

	// RVA: 0xFFFFFFFF75ABE23C
	internal Void .ctor() { }

	// RVA: -1
	public abstract Void SetContext(XmlNamespaceManager nsManager) { }

	// RVA: -1
	public abstract Void SetContext(IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75ABE240
	public static XPathExpression Compile(String xpath) { }

	// RVA: 0xFFFFFFFF75ABE248
	public static XPathExpression Compile(String xpath, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.XPath
public abstract class XPathItem
{
	// Properties
	public abstract XmlSchemaType XmlType { get; }
	public abstract String Value { get; }
	public abstract Object TypedValue { get; }
	public abstract Type ValueType { get; }
	public abstract Boolean ValueAsBoolean { get; }
	public abstract DateTime ValueAsDateTime { get; }
	public abstract Double ValueAsDouble { get; }
	public abstract Int32 ValueAsInt { get; }
	public abstract Int64 ValueAsLong { get; }

	// Methods

	// RVA: -1
	public abstract XmlSchemaType get_XmlType() { }

	// RVA: -1
	public abstract String get_Value() { }

	// RVA: -1
	public abstract Object get_TypedValue() { }

	// RVA: -1
	public abstract Type get_ValueType() { }

	// RVA: -1
	public abstract Boolean get_ValueAsBoolean() { }

	// RVA: -1
	public abstract DateTime get_ValueAsDateTime() { }

	// RVA: -1
	public abstract Double get_ValueAsDouble() { }

	// RVA: -1
	public abstract Int32 get_ValueAsInt() { }

	// RVA: -1
	public abstract Int64 get_ValueAsLong() { }

	// RVA: 0xFFFFFFFF75ABE328
	public virtual Object ValueAs(Type returnType) { }

	// RVA: -1
	public abstract Object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75ABE33C
	protected Void .ctor() { }

}

// Namespace: System.Xml.XPath
public enum XPathNamespaceScope
{
	// Fields
	public Int32 value__; // 0x10
	public const XPathNamespaceScope All = 0;
	public const XPathNamespaceScope ExcludeXml = 1;
	public const XPathNamespaceScope Local = 2;
}

// Namespace: System.Xml.XPath
public abstract class XPathNavigator
{
	// Fields
	internal static readonly XPathNavigatorKeyComparer comparer; // 0x0
	internal static readonly Char[] NodeTypeLetter; // 0x8
	internal static readonly Char[] UniqueIdTbl; // 0x10
	internal static readonly Int32[] ContentKindMasks; // 0x18

	// Properties
	public override XmlSchemaType XmlType { get; }
	public override Object TypedValue { get; }
	public override Type ValueType { get; }
	public override Boolean ValueAsBoolean { get; }
	public override DateTime ValueAsDateTime { get; }
	public override Double ValueAsDouble { get; }
	public override Int32 ValueAsInt { get; }
	public override Int64 ValueAsLong { get; }
	public abstract XmlNameTable NameTable { get; }
	public abstract XPathNodeType NodeType { get; }
	public abstract String LocalName { get; }
	public abstract String Name { get; }
	public abstract String NamespaceURI { get; }
	public abstract String Prefix { get; }
	public abstract String BaseURI { get; }
	public virtual String XmlLang { get; }
	public virtual Object UnderlyingObject { get; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }

	// Methods

	// RVA: 0xFFFFFFFF75ABE340
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75ABE350
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0xFFFFFFFF75ABE4E0
	public override Object get_TypedValue() { }

	// RVA: 0xFFFFFFFF75ABE7D4
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75ABE9D0
	public override Boolean get_ValueAsBoolean() { }

	// RVA: 0xFFFFFFFF75ABEC98
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0xFFFFFFFF75ABEF60
	public override Double get_ValueAsDouble() { }

	// RVA: 0xFFFFFFFF75ABF228
	public override Int32 get_ValueAsInt() { }

	// RVA: 0xFFFFFFFF75ABF4F0
	public override Int64 get_ValueAsLong() { }

	// RVA: 0xFFFFFFFF75ABF7B8
	public override Object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75ABFAA0
	private Object System.ICloneable.Clone() { }

	// RVA: 0xFFFFFFFF75ABFAB0
	public virtual XPathNavigator CreateNavigator() { }

	// RVA: -1
	public abstract XmlNameTable get_NameTable() { }

	// RVA: 0xFFFFFFFF75ABFAC0
	public virtual String LookupNamespace(String prefix) { }

	// RVA: 0xFFFFFFFF75ABFC08
	public virtual String LookupPrefix(String namespaceURI) { }

	// RVA: -1
	public abstract XPathNavigator Clone() { }

	// RVA: -1
	public abstract XPathNodeType get_NodeType() { }

	// RVA: -1
	public abstract String get_LocalName() { }

	// RVA: -1
	public abstract String get_Name() { }

	// RVA: -1
	public abstract String get_NamespaceURI() { }

	// RVA: -1
	public abstract String get_Prefix() { }

	// RVA: -1
	public abstract String get_BaseURI() { }

	// RVA: 0xFFFFFFFF75ABFDC4
	public virtual String get_XmlLang() { }

	// RVA: 0xFFFFFFFF75ABFE6C
	public virtual Object get_UnderlyingObject() { }

	// RVA: 0xFFFFFFFF75ABFE74
	public virtual Boolean MoveToAttribute(String localName, String namespaceURI) { }

	// RVA: -1
	public abstract Boolean MoveToFirstAttribute() { }

	// RVA: -1
	public abstract Boolean MoveToNextAttribute() { }

	// RVA: 0xFFFFFFFF75ABFF3C
	public virtual Boolean MoveToNamespace(String name) { }

	// RVA: -1
	public abstract Boolean MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: -1
	public abstract Boolean MoveToNextNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0xFFFFFFFF75ABFFE0
	public Boolean MoveToFirstNamespace() { }

	// RVA: 0xFFFFFFFF75ABFFF4
	public Boolean MoveToNextNamespace() { }

	// RVA: -1
	public abstract Boolean MoveToNext() { }

	// RVA: -1
	public abstract Boolean MoveToFirstChild() { }

	// RVA: -1
	public abstract Boolean MoveToParent() { }

	// RVA: 0xFFFFFFFF75AC0008
	public virtual Void MoveToRoot() { }

	// RVA: -1
	public abstract Boolean MoveTo(XPathNavigator other) { }

	// RVA: -1
	public abstract Boolean MoveToId(String id) { }

	// RVA: 0xFFFFFFFF75AC003C
	public virtual Boolean MoveToChild(String localName, String namespaceURI) { }

	// RVA: 0xFFFFFFFF75AC0120
	public virtual Boolean MoveToChild(XPathNodeType type) { }

	// RVA: 0xFFFFFFFF75AC028C
	public virtual Boolean MoveToFollowing(String localName, String namespaceURI, XPathNavigator end) { }

	// RVA: 0xFFFFFFFF75AC055C
	public virtual Boolean MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0xFFFFFFFF75AC0710
	public virtual Boolean MoveToNext(String localName, String namespaceURI) { }

	// RVA: 0xFFFFFFFF75AC0810
	public virtual Boolean MoveToNext(XPathNodeType type) { }

	// RVA: -1
	public abstract Boolean IsSamePosition(XPathNavigator other) { }

	// RVA: 0xFFFFFFFF75AC08EC
	public virtual Boolean IsDescendant(XPathNavigator nav) { }

	// RVA: 0xFFFFFFFF75AC0974
	public virtual XmlNodeOrder ComparePosition(XPathNavigator nav) { }

	// RVA: 0xFFFFFFFF75AC0E1C
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xFFFFFFFF75AC0E64
	public virtual XPathExpression Compile(String xpath) { }

	// RVA: 0xFFFFFFFF75AC0E70
	public virtual XPathNodeIterator Select(String xpath) { }

	// RVA: 0xFFFFFFFF75AC0EAC
	public virtual XPathNodeIterator Select(XPathExpression expr) { }

	// RVA: 0xFFFFFFFF75AC0F70
	public virtual Object Evaluate(XPathExpression expr) { }

	// RVA: 0xFFFFFFFF75AC0F84
	public virtual Object Evaluate(XPathExpression expr, XPathNodeIterator context) { }

	// RVA: 0xFFFFFFFF75AC1158
	public virtual XPathNodeIterator SelectChildren(XPathNodeType type) { }

	// RVA: 0xFFFFFFFF75AC11DC
	public virtual XPathNodeIterator SelectChildren(String name, String namespaceURI) { }

	// RVA: 0xFFFFFFFF75AC1268
	public virtual XPathNodeIterator SelectDescendants(XPathNodeType type, Boolean matchSelf) { }

	// RVA: 0xFFFFFFFF75AC12F4
	public virtual XPathNodeIterator SelectDescendants(String name, String namespaceURI, Boolean matchSelf) { }

	// RVA: 0xFFFFFFFF75AC0450
	internal Boolean MoveToNonDescendant() { }

	// RVA: 0xFFFFFFFF75AC0C78
	private static Int32 GetDepth(XPathNavigator nav) { }

	// RVA: 0xFFFFFFFF75AC0CC0
	private XmlNodeOrder CompareSiblings(XPathNavigator n1, XPathNavigator n2) { }

	// RVA: 0xFFFFFFFF75AC0200
	internal static Int32 GetContentKindMask(XPathNodeType type) { }

	// RVA: 0xFFFFFFFF75AC1390
	internal static Int32 GetKindMask(XPathNodeType type) { }

	// RVA: 0xFFFFFFFF75AC13B4
	internal static Boolean IsText(XPathNodeType type) { }

	// RVA: 0xFFFFFFFF75AC13C4
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF75AC13C8
	private static Void .cctor() { }

}

// Namespace: System.Xml.XPath
internal class XPathNavigatorKeyComparer
{
	// Methods

	// RVA: 0xFFFFFFFF75AC153C
	private Boolean System.Collections.IEqualityComparer.Equals(Object obj1, Object obj2) { }

	// RVA: 0xFFFFFFFF75AC1614
	private Int32 System.Collections.IEqualityComparer.GetHashCode(Object obj) { }

	// RVA: 0xFFFFFFFF75AC1538
	public Void .ctor() { }

}

// Namespace: System.Xml.XPath
public abstract class XPathNodeIterator
{
	// Fields
	internal Int32 count; // 0x10

	// Properties
	public abstract XPathNavigator Current { get; }
	public abstract Int32 CurrentPosition { get; }
	public virtual Int32 Count { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AC17E4
	private Object System.ICloneable.Clone() { }

	// RVA: -1
	public abstract XPathNodeIterator Clone() { }

	// RVA: -1
	public abstract Boolean MoveNext() { }

	// RVA: -1
	public abstract XPathNavigator get_Current() { }

	// RVA: -1
	public abstract Int32 get_CurrentPosition() { }

	// RVA: 0xFFFFFFFF75AC17F4
	public virtual Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75AC1870
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF75AC1920
	protected Void .ctor() { }

}

// Namespace: 
private class Enumerator
{
	// Fields
	private XPathNodeIterator original; // 0x10
	private XPathNodeIterator current; // 0x18
	private Boolean iterationStarted; // 0x20

	// Properties
	public virtual Object Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AC18C8
	public Void .ctor(XPathNodeIterator original) { }

	// RVA: 0xFFFFFFFF75AC192C
	public virtual Object get_Current() { }

	// RVA: 0xFFFFFFFF75AC1A50
	public virtual Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF75AC1AF8
	public virtual Void Reset() { }

}

// Namespace: System.Xml.XPath
public enum XPathNodeType
{
	// Fields
	public Int32 value__; // 0x10
	public const XPathNodeType Root = 0;
	public const XPathNodeType Element = 1;
	public const XPathNodeType Attribute = 2;
	public const XPathNodeType Namespace = 3;
	public const XPathNodeType Text = 4;
	public const XPathNodeType SignificantWhitespace = 5;
	public const XPathNodeType Whitespace = 6;
	public const XPathNodeType ProcessingInstruction = 7;
	public const XPathNodeType Comment = 8;
	public const XPathNodeType All = 9;
}

// Namespace: System.Xml.Serialization
public class XmlSerializerNamespaces
{
	// Fields
	private Hashtable namespaces; // 0x10
}

// Namespace: System.Xml.Serialization
public class XmlAttributeAttribute
{
	// Fields
	private String attributeName; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75ABB2B0
	public Void .ctor(String attributeName) { }

}

// Namespace: System.Xml.Serialization
public class XmlElementAttribute
{
	// Fields
	private String elementName; // 0x10
	private Type type; // 0x18
	private Int32 order; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75ABB2F4
	public Void .ctor(String elementName, Type type) { }

}

// Namespace: System.Xml.Serialization
public class XmlEnumAttribute
{
	// Fields
	private String name; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75ABB36C
	public Void .ctor(String name) { }

}

// Namespace: System.Xml.Serialization
public class XmlIgnoreAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF75ABB3B0
	public Void .ctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlRootAttribute
{
	// Fields
	private String elementName; // 0x10
	private Boolean isNullable; // 0x18
	private String ns; // 0x20

	// Properties
	public String Namespace { set; }

	// Methods

	// RVA: 0xFFFFFFFF75ABB3B8
	public Void .ctor(String elementName) { }

	// RVA: 0xFFFFFFFF75ABB404
	public Void set_Namespace(String value) { }

}

// Namespace: System.Xml.Schema
internal class Asttree
{
	// Fields
	private ArrayList fAxisArray; // 0x10
	private String xpathexpr; // 0x18
	private Boolean isField; // 0x20
	private XmlNamespaceManager nsmgr; // 0x28
}

// Namespace: System.Xml.Schema
internal class BaseValidator
{}

// Namespace: System.Xml.Schema
internal sealed class BitSet
{
	// Fields
	private Int32 count; // 0x10
	private UInt32[] bits; // 0x18

	// Properties
	public Int32 Count { get; }
	public Boolean Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A82700
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF75A82704
	public Void .ctor(Int32 count) { }

	// RVA: 0xFFFFFFFF75A8275C
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75A82764
	public Boolean get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF75A827C4
	public Void Clear() { }

	// RVA: 0xFFFFFFFF75A827FC
	public Void Set(Int32 index) { }

	// RVA: 0xFFFFFFFF75A82768
	public Boolean Get(Int32 index) { }

	// RVA: 0xFFFFFFFF75A828EC
	public Int32 NextSet(Int32 startFrom) { }

	// RVA: 0xFFFFFFFF75A8298C
	public Void And(BitSet other) { }

	// RVA: 0xFFFFFFFF75A82A48
	public Void Or(BitSet other) { }

	// RVA: 0xFFFFFFFF75A82AF8
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF75A82B3C
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF75A82CA8
	public BitSet Clone() { }

	// RVA: 0xFFFFFFFF75A82D60
	public Boolean Intersects(BitSet other) { }

	// RVA: 0xFFFFFFFF75A82754
	private Int32 Subscript(Int32 bitIndex) { }

	// RVA: 0xFFFFFFFF75A8286C
	private Void EnsureLength(Int32 nRequiredLength) { }

}

// Namespace: System.Xml.Schema
internal class CompiledIdentityConstraint
{
	// Fields
	internal XmlQualifiedName name; // 0x10
	private ConstraintRole role; // 0x18
	private Asttree selector; // 0x20
	private Asttree[] fields; // 0x28
	internal XmlQualifiedName refer; // 0x30
	public static readonly CompiledIdentityConstraint Empty; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75A83310
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF75A833A4
	private static Void .cctor() { }

}

// Namespace: 
public enum ConstraintRole
{
	// Fields
	public Int32 value__; // 0x10
	public const ConstraintRole Unique = 0;
	public const ConstraintRole Key = 1;
	public const ConstraintRole Keyref = 2;
}

// Namespace: System.Xml.Schema
internal class UpaException
{
	// Fields
	private Object particle1; // 0x88
	private Object particle2; // 0x90

	// Methods

	// RVA: 0xFFFFFFFF75A985F0
	public Void .ctor(Object particle1, Object particle2) { }

}

// Namespace: System.Xml.Schema
internal class SymbolsDictionary
{
	// Fields
	private Int32 last; // 0x10
	private Hashtable names; // 0x18
	private Hashtable wildcards; // 0x20
	private ArrayList particles; // 0x28
	private Object particleLast; // 0x30
	private Boolean isUpaEnforced; // 0x38

	// Properties
	public Int32 Count { get; }
	public Boolean IsUpaEnforced { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75A9639C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A97798
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75A9B3A0
	public Boolean get_IsUpaEnforced() { }

	// RVA: 0xFFFFFFFF75A9B3A8
	public Void set_IsUpaEnforced(Boolean value) { }

	// RVA: 0xFFFFFFFF75A96744
	public Int32 AddName(XmlQualifiedName name, Object particle) { }

	// RVA: 0xFFFFFFFF75A96A14
	public Void AddNamespaceList(NamespaceList list, Object particle, Boolean allowLocal) { }

	// RVA: 0xFFFFFFFF75A9B3B0
	private Void AddWildcard(String wildcard, Object particle) { }

	// RVA: 0xFFFFFFFF75A94818
	public ICollection GetNamespaceListSymbols(NamespaceList list) { }

	// RVA: 0xFFFFFFFF75A96678
	public Boolean Exists(XmlQualifiedName name) { }

	// RVA: 0xFFFFFFFF75A95288
	public Object GetParticle(Int32 symbol) { }

}

// Namespace: System.Xml.Schema
internal struct Position
{
	// Fields
	public Int32 symbol; // 0x10
	public Object particle; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF71145334
	public Void .ctor(Int32 symbol, Object particle) { }

}

// Namespace: System.Xml.Schema
internal class Positions
{
	// Fields
	private ArrayList positions; // 0x10

	// Properties
	public Position Item { get; }
	public Int32 Count { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A952C8
	public Int32 Add(Int32 symbol, Object particle) { }

	// RVA: 0xFFFFFFFF75A98558
	public Position get_Item(Int32 pos) { }

	// RVA: 0xFFFFFFFF75A977A4
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF75A96434
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal abstract class SyntaxTreeNode
{
	// Properties
	public abstract Boolean IsNullable { get; }
	public virtual Boolean IsRangeNode { get; }

	// Methods

	// RVA: -1
	public abstract Void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: -1
	public abstract Void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: -1
	public abstract Boolean get_IsNullable() { }

	// RVA: 0xFFFFFFFF75A9B50C
	public virtual Boolean get_IsRangeNode() { }

	// RVA: 0xFFFFFFFF75A93BE8
	protected Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class LeafNode
{
	// Fields
	private Int32 pos; // 0x10

	// Properties
	public Int32 Pos { get; set; }
	public override Boolean IsNullable { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A93BEC
	public Void .ctor(Int32 pos) { }

	// RVA: 0xFFFFFFFF75A93BF4
	public Int32 get_Pos() { }

	// RVA: 0xFFFFFFFF75A93BFC
	public Void set_Pos(Int32 value) { }

	// RVA: 0xFFFFFFFF75A93C04
	public override Void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0xFFFFFFFF75A93C08
	public override Void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0xFFFFFFFF75A93C4C
	public override Boolean get_IsNullable() { }

}

// Namespace: System.Xml.Schema
internal class NamespaceListNode
{
	// Fields
	protected NamespaceList namespaceList; // 0x10
	protected Object particle; // 0x18

	// Properties
	public override Boolean IsNullable { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A94790
	public Void .ctor(NamespaceList namespaceList, Object particle) { }

	// RVA: 0xFFFFFFFF75A947F4
	public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

	// RVA: 0xFFFFFFFF75A94E68
	public override Void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0xFFFFFFFF75A95378
	public override Void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0xFFFFFFFF75A953CC
	public override Boolean get_IsNullable() { }

}

// Namespace: System.Xml.Schema
internal abstract class InteriorNode
{
	// Fields
	private SyntaxTreeNode leftChild; // 0x10
	private SyntaxTreeNode rightChild; // 0x18

	// Properties
	public SyntaxTreeNode LeftChild { get; set; }
	public SyntaxTreeNode RightChild { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75A93AEC
	public SyntaxTreeNode get_LeftChild() { }

	// RVA: 0xFFFFFFFF75A93AF4
	public Void set_LeftChild(SyntaxTreeNode value) { }

	// RVA: 0xFFFFFFFF75A93B2C
	public SyntaxTreeNode get_RightChild() { }

	// RVA: 0xFFFFFFFF75A93B34
	public Void set_RightChild(SyntaxTreeNode value) { }

	// RVA: 0xFFFFFFFF75A8315C
	protected Void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0xFFFFFFFF75A93B6C
	public override Void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0xFFFFFFFF75A8330C
	protected Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class SequenceNode
{
	// Properties
	public override Boolean IsNullable { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A9A720
	public override Void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0xFFFFFFFF75A9ABF8
	public override Boolean get_IsNullable() { }

	// RVA: 0xFFFFFFFF75A9AD44
	public override Void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0xFFFFFFFF75A96ED8
	public Void .ctor() { }

}

// Namespace: 
private struct SequenceConstructPosContext
{
	// Fields
	public SequenceNode this_; // 0x10
	public BitSet firstpos; // 0x18
	public BitSet lastpos; // 0x20
	public BitSet lastposLeft; // 0x28
	public BitSet firstposRight; // 0x30

	// Methods

	// RVA: 0xFFFFFFFF711453AC
	public Void .ctor(SequenceNode node, BitSet firstpos, BitSet lastpos) { }

}

// Namespace: System.Xml.Schema
internal sealed class ChoiceNode
{
	// Properties
	public override Boolean IsNullable { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A82E20
	private static Void ConstructChildPos(SyntaxTreeNode child, BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0xFFFFFFFF75A82F54
	public override Void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0xFFFFFFFF75A830C0
	public override Boolean get_IsNullable() { }

	// RVA: 0xFFFFFFFF75A83158
	public override Void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0xFFFFFFFF75A83308
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class PlusNode
{
	// Properties
	public override Boolean IsNullable { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A98808
	public override Void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0xFFFFFFFF75A988B4
	public override Boolean get_IsNullable() { }

	// RVA: 0xFFFFFFFF75A9714C
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class QmarkNode
{
	// Properties
	public override Boolean IsNullable { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A98DFC
	public override Void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0xFFFFFFFF75A98E24
	public override Boolean get_IsNullable() { }

	// RVA: 0xFFFFFFFF75A971A0
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class StarNode
{
	// Properties
	public override Boolean IsNullable { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A9AD48
	public override Void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0xFFFFFFFF75A9ADF4
	public override Boolean get_IsNullable() { }

	// RVA: 0xFFFFFFFF75A96F2C
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class LeafRangeNode
{
	// Fields
	private Decimal min; // 0x14
	private Decimal max; // 0x24
	private BitSet nextIteration; // 0x38

	// Properties
	public Decimal Max { get; }
	public Decimal Min { get; }
	public BitSet NextIteration { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75A93C54
	public Decimal get_Max() { }

	// RVA: 0xFFFFFFFF75A93C64
	public Decimal get_Min() { }

	// RVA: 0xFFFFFFFF75A93C74
	public BitSet get_NextIteration() { }

	// RVA: 0xFFFFFFFF75A93C7C
	public Void set_NextIteration(BitSet value) { }

}

// Namespace: System.Xml.Schema
internal class ContentValidator
{
	// Fields
	private XmlSchemaContentType contentType; // 0x10
	private Boolean isOpen; // 0x14
	private Boolean isEmptiable; // 0x15
	public static readonly ContentValidator Empty; // 0x0
	public static readonly ContentValidator TextOnly; // 0x8
	public static readonly ContentValidator Mixed; // 0x10
	public static readonly ContentValidator Any; // 0x18

	// Properties
	public XmlSchemaContentType ContentType { get; }
	public Boolean IsOpen { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A83414
	public Void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0xFFFFFFFF75A83424
	protected Void .ctor(XmlSchemaContentType contentType, Boolean isOpen, Boolean isEmptiable) { }

	// RVA: 0xFFFFFFFF75A83434
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0xFFFFFFFF75A8343C
	public Boolean get_IsOpen() { }

	// RVA: 0xFFFFFFFF75A83460
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class ParticleContentValidator
{
	// Fields
	private SymbolsDictionary symbols; // 0x18
	private Positions positions; // 0x20
	private Stack stack; // 0x28
	private SyntaxTreeNode contentNode; // 0x30
	private Boolean isPartial; // 0x38
	private Int32 minMaxNodesCount; // 0x3C
	private Boolean enableUpaCheck; // 0x40

	// Methods

	// RVA: 0xFFFFFFFF75A96228
	public Void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0xFFFFFFFF75A96230
	public Void .ctor(XmlSchemaContentType contentType, Boolean enableUpaCheck) { }

	// RVA: 0xFFFFFFFF75A962A8
	public Void Start() { }

	// RVA: 0xFFFFFFFF75A96484
	public Void OpenGroup() { }

	// RVA: 0xFFFFFFFF75A964B0
	public Void CloseGroup() { }

	// RVA: 0xFFFFFFFF75A9663C
	public Boolean Exists(XmlQualifiedName name) { }

	// RVA: 0xFFFFFFFF75A966AC
	public Void AddName(XmlQualifiedName name, Object particle) { }

	// RVA: 0xFFFFFFFF75A96954
	public Void AddNamespaceList(NamespaceList namespaceList, Object particle) { }

	// RVA: 0xFFFFFFFF75A96854
	private Void AddLeafNode(SyntaxTreeNode node) { }

	// RVA: 0xFFFFFFFF75A96D00
	public Void AddChoice() { }

	// RVA: 0xFFFFFFFF75A96DEC
	public Void AddSequence() { }

	// RVA: 0xFFFFFFFF75A96EDC
	public Void AddStar() { }

	// RVA: 0xFFFFFFFF75A970FC
	public Void AddPlus() { }

	// RVA: 0xFFFFFFFF75A97150
	public Void AddQMark() { }

	// RVA: 0xFFFFFFFF75A96F30
	private Void Closure(InteriorNode node) { }

	// RVA: 0xFFFFFFFF75A971A4
	public ContentValidator Finish(Boolean useDFA) { }

	// RVA: 0xFFFFFFFF75A977CC
	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals) { }

	// RVA: 0xFFFFFFFF75A97CD0
	private Void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	// RVA: 0xFFFFFFFF75A97B3C
	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	// RVA: 0xFFFFFFFF75A97F58
	private Void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	// RVA: 0xFFFFFFFF75A98680
	private Void CheckUniqueParticleAttribution(BitSet curpos) { }

	// RVA: 0xFFFFFFFF75A97FEC
	private Int32[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, Int32 endMarkerPos) { }

}

// Namespace: System.Xml.Schema
internal sealed class DfaContentValidator
{
	// Fields
	private Int32[][] transitionTable; // 0x18
	private SymbolsDictionary symbols; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75A92C18
	internal Void .ctor(Int32[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, Boolean isOpen, Boolean isEmptiable) { }

}

// Namespace: System.Xml.Schema
internal sealed class NfaContentValidator
{
	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private SymbolsDictionary symbols; // 0x28
	private Positions positions; // 0x30
	private Int32 endMarkerPos; // 0x38

	// Methods

	// RVA: 0xFFFFFFFF75A95420
	internal Void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, Int32 endMarkerPos, XmlSchemaContentType contentType, Boolean isOpen, Boolean isEmptiable) { }

}

// Namespace: System.Xml.Schema
internal sealed class RangeContentValidator
{
	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private BitSet positionsWithRangeTerminals; // 0x28
	private SymbolsDictionary symbols; // 0x30
	private Positions positions; // 0x38
	private Int32 minMaxNodesCount; // 0x40
	private Int32 endMarkerPos; // 0x44

	// Methods

	// RVA: 0xFFFFFFFF75A97E20
	internal Void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, Int32 endMarkerPos, XmlSchemaContentType contentType, Boolean isEmptiable, BitSet positionsWithRangeTerminals, Int32 minmaxNodesCount) { }

}

// Namespace: System.Xml.Schema
public enum XmlSchemaDatatypeVariety
{
	// Fields
	public Int32 value__; // 0x10
	public const XmlSchemaDatatypeVariety Atomic = 0;
	public const XmlSchemaDatatypeVariety List = 1;
	public const XmlSchemaDatatypeVariety Union = 2;
}

// Namespace: System.Xml.Schema
internal class XsdSimpleValue
{
	// Fields
	private XmlSchemaSimpleType xmlType; // 0x10
	private Object typedValue; // 0x18

	// Properties
	public XmlSchemaSimpleType XmlType { get; }
	public Object TypedValue { get; }

	// Methods

	// RVA: 0xFFFFFFFF75ABAAA8
	public XmlSchemaSimpleType get_XmlType() { }

	// RVA: 0xFFFFFFFF75ABAAB0
	public Object get_TypedValue() { }

}

// Namespace: System.Xml.Schema
internal enum RestrictionFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const RestrictionFlags Length = 1;
	public const RestrictionFlags MinLength = 2;
	public const RestrictionFlags MaxLength = 4;
	public const RestrictionFlags Pattern = 8;
	public const RestrictionFlags Enumeration = 16;
	public const RestrictionFlags WhiteSpace = 32;
	public const RestrictionFlags MaxInclusive = 64;
	public const RestrictionFlags MaxExclusive = 128;
	public const RestrictionFlags MinInclusive = 256;
	public const RestrictionFlags MinExclusive = 512;
	public const RestrictionFlags TotalDigits = 1024;
	public const RestrictionFlags FractionDigits = 2048;
}

// Namespace: System.Xml.Schema
internal enum XmlSchemaWhiteSpace
{
	// Fields
	public Int32 value__; // 0x10
	public const XmlSchemaWhiteSpace Preserve = 0;
	public const XmlSchemaWhiteSpace Replace = 1;
	public const XmlSchemaWhiteSpace Collapse = 2;
}

// Namespace: System.Xml.Schema
internal class RestrictionFacets
{
	// Fields
	internal Int32 Length; // 0x10
	internal Int32 MinLength; // 0x14
	internal Int32 MaxLength; // 0x18
	internal ArrayList Patterns; // 0x20
	internal ArrayList Enumeration; // 0x28
	internal XmlSchemaWhiteSpace WhiteSpace; // 0x30
	internal Object MaxInclusive; // 0x38
	internal Object MaxExclusive; // 0x40
	internal Object MinInclusive; // 0x48
	internal Object MinExclusive; // 0x50
	internal Int32 TotalDigits; // 0x58
	internal Int32 FractionDigits; // 0x5C
	internal RestrictionFlags Flags; // 0x60
}

// Namespace: System.Xml.Schema
internal abstract class DatatypeImplementation
{
	// Fields
	private XmlSchemaDatatypeVariety variety; // 0x10
	private RestrictionFacets restriction; // 0x18
	private DatatypeImplementation baseType; // 0x20
	private XmlValueConverter valueConverter; // 0x28
	private XmlSchemaType parentSchemaType; // 0x30
	private static Hashtable builtinTypes; // 0x0
	private static XmlSchemaSimpleType[] enumToTypeCode; // 0x8
	private static XmlSchemaSimpleType anySimpleType; // 0x10
	private static XmlSchemaSimpleType anyAtomicType; // 0x18
	private static XmlSchemaSimpleType untypedAtomicType; // 0x20
	private static XmlSchemaSimpleType yearMonthDurationType; // 0x28
	private static XmlSchemaSimpleType dayTimeDurationType; // 0x30
	internal static XmlQualifiedName QnAnySimpleType; // 0x38
	internal static XmlQualifiedName QnAnyType; // 0x40
	internal static FacetsChecker stringFacetsChecker; // 0x48
	internal static FacetsChecker miscFacetsChecker; // 0x50
	internal static FacetsChecker numeric2FacetsChecker; // 0x58
	internal static FacetsChecker binaryFacetsChecker; // 0x60
	internal static FacetsChecker dateTimeFacetsChecker; // 0x68
	internal static FacetsChecker durationFacetsChecker; // 0x70
	internal static FacetsChecker listFacetsChecker; // 0x78
	internal static FacetsChecker qnameFacetsChecker; // 0x80
	internal static FacetsChecker unionFacetsChecker; // 0x88
	private static readonly DatatypeImplementation c_anySimpleType; // 0x90
	private static readonly DatatypeImplementation c_anyURI; // 0x98
	private static readonly DatatypeImplementation c_base64Binary; // 0xA0
	private static readonly DatatypeImplementation c_boolean; // 0xA8
	private static readonly DatatypeImplementation c_byte; // 0xB0
	private static readonly DatatypeImplementation c_char; // 0xB8
	private static readonly DatatypeImplementation c_date; // 0xC0
	private static readonly DatatypeImplementation c_dateTime; // 0xC8
	private static readonly DatatypeImplementation c_dateTimeNoTz; // 0xD0
	private static readonly DatatypeImplementation c_dateTimeTz; // 0xD8
	private static readonly DatatypeImplementation c_day; // 0xE0
	private static readonly DatatypeImplementation c_decimal; // 0xE8
	private static readonly DatatypeImplementation c_double; // 0xF0
	private static readonly DatatypeImplementation c_doubleXdr; // 0xF8
	private static readonly DatatypeImplementation c_duration; // 0x100
	private static readonly DatatypeImplementation c_ENTITY; // 0x108
	private static readonly DatatypeImplementation c_ENTITIES; // 0x110
	private static readonly DatatypeImplementation c_ENUMERATION; // 0x118
	private static readonly DatatypeImplementation c_fixed; // 0x120
	private static readonly DatatypeImplementation c_float; // 0x128
	private static readonly DatatypeImplementation c_floatXdr; // 0x130
	private static readonly DatatypeImplementation c_hexBinary; // 0x138
	private static readonly DatatypeImplementation c_ID; // 0x140
	private static readonly DatatypeImplementation c_IDREF; // 0x148
	private static readonly DatatypeImplementation c_IDREFS; // 0x150
	private static readonly DatatypeImplementation c_int; // 0x158
	private static readonly DatatypeImplementation c_integer; // 0x160
	private static readonly DatatypeImplementation c_language; // 0x168
	private static readonly DatatypeImplementation c_long; // 0x170
	private static readonly DatatypeImplementation c_month; // 0x178
	private static readonly DatatypeImplementation c_monthDay; // 0x180
	private static readonly DatatypeImplementation c_Name; // 0x188
	private static readonly DatatypeImplementation c_NCName; // 0x190
	private static readonly DatatypeImplementation c_negativeInteger; // 0x198
	private static readonly DatatypeImplementation c_NMTOKEN; // 0x1A0
	private static readonly DatatypeImplementation c_NMTOKENS; // 0x1A8
	private static readonly DatatypeImplementation c_nonNegativeInteger; // 0x1B0
	private static readonly DatatypeImplementation c_nonPositiveInteger; // 0x1B8
	private static readonly DatatypeImplementation c_normalizedString; // 0x1C0
	private static readonly DatatypeImplementation c_NOTATION; // 0x1C8
	private static readonly DatatypeImplementation c_positiveInteger; // 0x1D0
	private static readonly DatatypeImplementation c_QName; // 0x1D8
	private static readonly DatatypeImplementation c_QNameXdr; // 0x1E0
	private static readonly DatatypeImplementation c_short; // 0x1E8
	private static readonly DatatypeImplementation c_string; // 0x1F0
	private static readonly DatatypeImplementation c_time; // 0x1F8
	private static readonly DatatypeImplementation c_timeNoTz; // 0x200
	private static readonly DatatypeImplementation c_timeTz; // 0x208
	private static readonly DatatypeImplementation c_token; // 0x210
	private static readonly DatatypeImplementation c_unsignedByte; // 0x218
	private static readonly DatatypeImplementation c_unsignedInt; // 0x220
	private static readonly DatatypeImplementation c_unsignedLong; // 0x228
	private static readonly DatatypeImplementation c_unsignedShort; // 0x230
	private static readonly DatatypeImplementation c_uuid; // 0x238
	private static readonly DatatypeImplementation c_year; // 0x240
	private static readonly DatatypeImplementation c_yearMonth; // 0x248
	internal static readonly DatatypeImplementation c_normalizedStringV1Compat; // 0x250
	internal static readonly DatatypeImplementation c_tokenV1Compat; // 0x258
	private static readonly DatatypeImplementation c_anyAtomicType; // 0x260
	private static readonly DatatypeImplementation c_dayTimeDuration; // 0x268
	private static readonly DatatypeImplementation c_untypedAtomicType; // 0x270
	private static readonly DatatypeImplementation c_yearMonthDuration; // 0x278
	private static readonly DatatypeImplementation[] c_tokenizedTypes; // 0x280
	private static readonly DatatypeImplementation[] c_tokenizedTypesXsd; // 0x288
	private static readonly SchemaDatatypeMap[] c_XdrTypes; // 0x290
	private static readonly SchemaDatatypeMap[] c_XsdTypes; // 0x298

	// Properties
	internal static XmlSchemaSimpleType AnySimpleType { get; }
	internal static XmlSchemaSimpleType UntypedAtomicType { get; }
	internal override FacetsChecker FacetsChecker { get; }
	internal override XmlValueConverter ValueConverter { get; }
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	public override XmlSchemaDatatypeVariety Variety { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override RestrictionFacets Restriction { get; }
	internal abstract Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8357C
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75A8922C
	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	// RVA: 0xFFFFFFFF75A8928C
	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	// RVA: 0xFFFFFFFF75A892EC
	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0xFFFFFFFF75A89378
	private static DatatypeImplementation FromTypeName(String name) { }

	// RVA: 0xFFFFFFFF75A89434
	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	// RVA: 0xFFFFFFFF75A8967C
	internal static Void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	// RVA: 0xFFFFFFFF75A88974
	internal static Void CreateBuiltinTypes() { }

	// RVA: 0xFFFFFFFF75A89900
	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0xFFFFFFFF75A87C78
	internal XmlSchemaDatatype DeriveByList(Int32 minSize, XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A89A9C
	internal override Boolean IsEqual(Object o1, Object o2) { }

	// RVA: 0xFFFFFFFF75A89AC4
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A89ACC
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A89B2C
	internal override XmlValueConverter get_ValueConverter() { }

	// RVA: 0xFFFFFFFF75A89B8C
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0xFFFFFFFF75A89B94
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A89BD8
	public override XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0xFFFFFFFF75A89BE0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A89BE8
	internal override RestrictionFacets get_Restriction() { }

	// RVA: -1
	internal abstract Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A89BF0
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xFFFFFFFF75A89BF8
	public override Object ParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0xFFFFFFFF75A89DBC
	internal String GetTypeName() { }

	// RVA: 0xFFFFFFFF75A89E2C
	protected Int32 Compare(Byte[] value1, Byte[] value2) { }

	// RVA: 0xFFFFFFFF75A89E90
	protected Void .ctor() { }

}

// Namespace: 
private class SchemaDatatypeMap
{
	// Fields
	private String name; // 0x10
	private DatatypeImplementation type; // 0x18
	private Int32 parentIndex; // 0x20

	// Properties
	public String Name { get; }
	public Int32 ParentIndex { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A888A8
	internal Void .ctor(String name, DatatypeImplementation type) { }

	// RVA: 0xFFFFFFFF75A8890C
	internal Void .ctor(String name, DatatypeImplementation type, Int32 parentIndex) { }

	// RVA: 0xFFFFFFFF75A89E98
	public static DatatypeImplementation op_Explicit(SchemaDatatypeMap sdm) { }

	// RVA: 0xFFFFFFFF75A89EB4
	public String get_Name() { }

	// RVA: 0xFFFFFFFF75A89EBC
	public Int32 get_ParentIndex() { }

	// RVA: 0xFFFFFFFF75A89EC4
	public Int32 CompareTo(Object obj) { }

}

// Namespace: System.Xml.Schema
internal class Datatype_List
{
	// Fields
	private DatatypeImplementation itemType; // 0x38
	private Int32 minListSize; // 0x40

	// Properties
	public override Type ValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override Type ListValueType { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A89F3C
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A89A0C
	internal Void .ctor(DatatypeImplementation type, Int32 minListSize) { }

	// RVA: 0xFFFFFFFF75A8A208
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A8A4A8
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A8A4B8
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0xFFFFFFFF75A8A4E0
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A8A508
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A8A568
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8A590
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

}

// Namespace: System.Xml.Schema
internal class Datatype_union
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XmlSchemaSimpleType[] types; // 0x38

	// Methods

	// RVA: 0xFFFFFFFF75A8998C
	internal Boolean HasAtomicMembers() { }

	// RVA: 0xFFFFFFFF75A90DF8
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_anySimpleType
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override Type ListValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8BA5C
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A8BABC
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A8BB1C
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A8BB7C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8BB84
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A8BBE4
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0xFFFFFFFF75A8BBEC
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xFFFFFFFF75A8BBF4
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A8BC5C
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A876F8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A8BCA0
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_anyAtomicType
{
	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8B9EC
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A8BA4C
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xFFFFFFFF75A8BA54
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A88790
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_untypedAtomicType
{
	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A91FC4
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A92024
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xFFFFFFFF75A9202C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A88848
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_string
{
	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A90C50
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A90C5C
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xFFFFFFFF75A90C64
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A90CC4
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A90CCC
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0xFFFFFFFF75A90CD4
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A8837C
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_boolean
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8C810
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A8C81C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A8C87C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8C884
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A8C8E4
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A8C944
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xFFFFFFFF75A8C94C
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A8C9C0
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A87810
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A8CAE4
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_float
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8EFE8
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A8EFF4
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A8F054
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8F05C
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A8F0BC
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A8F11C
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xFFFFFFFF75A8F124
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A8F198
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A87EA0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A8F2E4
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_double
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8E068
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A8E074
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A8E0D4
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8E0DC
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A8E13C
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A8E19C
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xFFFFFFFF75A8E1A4
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A8E218
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A87B60
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A8E364
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_decimal
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8DC20
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A8DC2C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A8DC8C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8DC94
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A8DCF4
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A8DD54
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xFFFFFFFF75A8DD5C
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A8DDD0
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A87B04
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A8DF1C
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_duration
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8E610
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A8E61C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A8E67C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8E684
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A8E6E4
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A8E744
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xFFFFFFFF75A8E74C
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A8E7C0
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A87C18
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A8E978
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonthDuration
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A924A0
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A92668
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8884C
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dayTimeDuration
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8DA50
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A8DC18
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A887EC
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeBase
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XsdDateTimeFlags dateTimeFlags; // 0x38

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8D47C
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A8D488
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A8D4E8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8D40C
	internal Void .ctor(XsdDateTimeFlags dateTimeFlags) { }

	// RVA: 0xFFFFFFFF75A8D4F0
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A8D550
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A8D5B0
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xFFFFFFFF75A8D5B8
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A8D6A0
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A8D988
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeNoTimeZone
{
	// Methods

	// RVA: 0xFFFFFFFF75A879E4
	internal Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeTimeZone
{
	// Methods

	// RVA: 0xFFFFFFFF75A87A44
	internal Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTime
{
	// Methods

	// RVA: 0xFFFFFFFF75A87984
	internal Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_timeNoTimeZone
{
	// Methods

	// RVA: 0xFFFFFFFF75A88438
	internal Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_timeTimeZone
{
	// Methods

	// RVA: 0xFFFFFFFF75A88498
	internal Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_time
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A90DD8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A883D8
	internal Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_date
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8D404
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A87924
	internal Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonth
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A92498
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A88728
	internal Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_year
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A92490
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A886C8
	internal Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_monthDay
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A9032C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A880DC
	internal Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_day
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8DA48
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A87AA4
	internal Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_month
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A90324
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8807C
	internal Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_hexBinary
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8F574
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A8F580
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A8F5E0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8F5E8
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A8F648
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A8F6A8
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xFFFFFFFF75A8F6B0
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A8F744
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A87F58
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A8F908
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_base64Binary
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8C3B4
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A8C3C0
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A8C420
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8C428
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A8C488
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A8C4E8
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xFFFFFFFF75A8C4F0
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A8C584
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A877B4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A8C744
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_anyURI
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8BD60
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A8BD6C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A8BDCC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8BDD4
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A8BE34
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A8BE94
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xFFFFFFFF75A8BE9C
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A8BF38
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A87758
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A8C2DC
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_QName
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8B1C0
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A8B1CC
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A8B22C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8B234
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0xFFFFFFFF75A8B23C
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A8B29C
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A8B2FC
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xFFFFFFFF75A8B304
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A88268
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A8B53C
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedString
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A906E8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A906F0
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xFFFFFFFF75A881AC
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedStringV1Compat
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A906F8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A88788
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_token
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A90DE0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A90DE8
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xFFFFFFFF75A884F8
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_tokenV1Compat
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A90DF0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8878C
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_language
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8FF08
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A88074
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_NMTOKEN
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8AD54
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8AD5C
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0xFFFFFFFF75A881A0
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_Name
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8B1B8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8813C
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_NCName
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8AC28
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8AC30
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A88140
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_ID
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A89F1C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A89F24
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0xFFFFFFFF75A87FB4
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_IDREF
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A89F2C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A89F34
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0xFFFFFFFF75A87FB8
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_ENTITY
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A89F04
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A89F0C
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0xFFFFFFFF75A87C74
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_NOTATION
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8AD64
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A8AD70
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A8ADD0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8ADD8
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0xFFFFFFFF75A8ADE0
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A8AE40
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A8AEA0
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xFFFFFFFF75A8AEA8
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A881B0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A8B0E0
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_integer
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8FDE8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8FDF0
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A88018
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_nonPositiveInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A905AC
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A9060C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A881A8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A90614
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_negativeInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A90334
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A90394
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A88144
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A9039C
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_long
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8FF10
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A8FF70
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8FF78
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A8FFEC
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A9004C
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A900AC
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A88078
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A901F8
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_int
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8F9D4
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A8FA34
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8FA3C
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A8FAB0
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A8FB10
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A8FB70
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A87FBC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A8FCBC
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_short
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A9083C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A9089C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A908A4
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A90918
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A90978
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A909D8
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A88320
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A90B24
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_byte
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8CBA4
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A8CC04
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8CC0C
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A8CC80
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A8CCE0
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A8CD40
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A8786C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A8CE8C
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_nonNegativeInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A90470
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A904D0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A881A4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A904D8
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedLong
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A91720
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A91780
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A91788
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A917FC
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A9185C
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A918BC
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A885B4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A91A44
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedInt
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A912EC
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A9134C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A91354
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A913C8
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A91428
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A91488
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A88558
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A915D4
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedShort
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A91B90
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A91BF0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A91BF8
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A91C6C
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A91CCC
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A91D2C
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A88610
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A91E78
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedByte
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A90EB8
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A90F18
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A90F20
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A90F94
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A90FF4
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A91054
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A884FC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A911A0
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_positiveInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A90700
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xFFFFFFFF75A90760
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75A8820C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A90768
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_doubleXdr
{
	// Methods

	// RVA: 0xFFFFFFFF75A8E424
	public override Object ParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0xFFFFFFFF75A87BBC
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_floatXdr
{
	// Methods

	// RVA: 0xFFFFFFFF75A8F3A4
	public override Object ParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0xFFFFFFFF75A87EFC
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_QNameXdr
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8B614
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0xFFFFFFFF75A8B61C
	public override Object ParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0xFFFFFFFF75A8B854
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A8B8B4
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A882C4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A8B914
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_ENUMERATION
{
	// Properties
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A89F14
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0xFFFFFFFF75A87E40
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_char
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A8CFC4
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A8D024
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A8D084
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A8D0F8
	public override Object ParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0xFFFFFFFF75A8D298
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A878C8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A8D344
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_fixed
{
	// Methods

	// RVA: 0xFFFFFFFF75A8EA38
	public override Object ParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0xFFFFFFFF75A8EEA8
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A87E44
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_uuid
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A92034
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A92094
	internal override Type get_ListValueType() { }

	// RVA: 0xFFFFFFFF75A920F4
	internal override Int32 Compare(Object value1, Object value2) { }

	// RVA: 0xFFFFFFFF75A9216C
	public override Object ParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0xFFFFFFFF75A9230C
	internal override Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: 0xFFFFFFFF75A8866C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A923B8
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class DtdValidator
{
	// Fields
	private static NamespaceManager namespaceManager; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75A92CEC
	public static Void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	// RVA: 0xFFFFFFFF75A930F4
	private static Void .cctor() { }

}

// Namespace: 
private class NamespaceManager
{
	// Methods

	// RVA: 0xFFFFFFFF75A93180
	public override String LookupNamespace(String prefix) { }

	// RVA: 0xFFFFFFFF75A93178
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal abstract class FacetsChecker
{
	// Methods

	// RVA: 0xFFFFFFFF75A93710
	internal virtual Exception CheckLexicalFacets(ref String parseString, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A939A4
	internal virtual Exception CheckValueFacets(Object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A939AC
	internal virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A939B4
	internal virtual Exception CheckValueFacets(Int64 value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A939BC
	internal virtual Exception CheckValueFacets(Int32 value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A939C4
	internal virtual Exception CheckValueFacets(Int16 value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A939CC
	internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A939D4
	internal virtual Exception CheckValueFacets(Double value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A939DC
	internal virtual Exception CheckValueFacets(Single value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A939E4
	internal virtual Exception CheckValueFacets(String value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A939EC
	internal virtual Exception CheckValueFacets(Byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A939F4
	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A939FC
	internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A93758
	internal Void CheckWhitespaceFacets(ref String s, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A9386C
	internal Exception CheckPatternFacets(RestrictionFacets restriction, String value) { }

	// RVA: 0xFFFFFFFF75A93A04
	internal virtual Boolean MatchEnumeration(Object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A93A0C
	internal static Decimal Power(Int32 x, Int32 y) { }

	// RVA: 0xFFFFFFFF75A826FC
	protected Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Numeric10FacetsChecker
{
	// Fields
	private static readonly Char[] signs; // 0x0
	private Decimal maxValue; // 0x10
	private Decimal minValue; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF75A8CFB8
	internal Void .ctor(Decimal minVal, Decimal maxVal) { }

	// RVA: 0xFFFFFFFF75A95538
	internal override Exception CheckValueFacets(Object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A955BC
	internal override Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A95B3C
	internal override Exception CheckValueFacets(Int64 value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A95BB4
	internal override Exception CheckValueFacets(Int32 value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A95C2C
	internal override Exception CheckValueFacets(Int16 value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A95CA4
	internal override Boolean MatchEnumeration(Object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A95A30
	internal Boolean MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0xFFFFFFFF75A8EC78
	internal Exception CheckTotalAndFractionDigits(Decimal value, Int32 totalDigits, Int32 fractionDigits, Boolean checkTotal, Boolean checkFraction) { }

	// RVA: 0xFFFFFFFF75A95D30
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Numeric2FacetsChecker
{
	// Methods

	// RVA: 0xFFFFFFFF75A95DAC
	internal override Exception CheckValueFacets(Object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A95E20
	internal override Exception CheckValueFacets(Double value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A96188
	internal override Exception CheckValueFacets(Single value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A9619C
	internal override Boolean MatchEnumeration(Object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A960C0
	private Boolean MatchEnumeration(Double value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0xFFFFFFFF75A876E0
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class DurationFacetsChecker
{
	// Methods

	// RVA: 0xFFFFFFFF75A93188
	internal override Exception CheckValueFacets(Object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A9326C
	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A936B4
	internal override Boolean MatchEnumeration(Object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A935B4
	private Boolean MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

	// RVA: 0xFFFFFFFF75A876E8
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class DateTimeFacetsChecker
{
	// Methods

	// RVA: 0xFFFFFFFF75A92670
	internal override Exception CheckValueFacets(Object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A926E8
	internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A92BAC
	internal override Boolean MatchEnumeration(Object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A92A88
	private Boolean MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A876E4
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class StringFacetsChecker
{
	// Fields
	private static Regex languagePattern; // 0x0

	// Properties
	private static Regex LanguagePattern { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A9ADFC
	private static Regex get_LanguagePattern() { }

	// RVA: 0xFFFFFFFF75A9AE98
	internal override Exception CheckValueFacets(Object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A9AEF8
	internal override Exception CheckValueFacets(String value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A8C0C0
	internal Exception CheckValueFacets(String value, XmlSchemaDatatype datatype, Boolean verifyUri) { }

	// RVA: 0xFFFFFFFF75A9B334
	internal override Boolean MatchEnumeration(Object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A9B180
	private Boolean MatchEnumeration(String value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A9AF00
	private Exception CheckBuiltInFacets(String s, XmlTypeCode typeCode, Boolean verifyUri) { }

	// RVA: 0xFFFFFFFF75A876D8
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class QNameFacetsChecker
{
	// Methods

	// RVA: 0xFFFFFFFF75A98918
	internal override Exception CheckValueFacets(Object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A98A34
	internal override Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A98D00
	internal override Boolean MatchEnumeration(Object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A98C00
	private Boolean MatchEnumeration(XmlQualifiedName value, ArrayList enumeration) { }

	// RVA: 0xFFFFFFFF75A876F0
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class MiscFacetsChecker
{
	// Methods

	// RVA: 0xFFFFFFFF75A876DC
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class BinaryFacetsChecker
{
	// Methods

	// RVA: 0xFFFFFFFF75A82370
	internal override Exception CheckValueFacets(Object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A823DC
	internal override Exception CheckValueFacets(Byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A82698
	internal override Boolean MatchEnumeration(Object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A82590
	private Boolean MatchEnumeration(Byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A826F8
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class ListFacetsChecker
{
	// Methods

	// RVA: 0xFFFFFFFF75A93CB4
	internal override Exception CheckValueFacets(Object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A93ED0
	internal override Boolean MatchEnumeration(Object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A876EC
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class UnionFacetsChecker
{
	// Methods

	// RVA: 0xFFFFFFFF75A9B514
	internal override Exception CheckValueFacets(Object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A9B5F8
	internal override Boolean MatchEnumeration(Object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xFFFFFFFF75A876F4
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
public interface IXmlSchemaInfo
{
	// Properties
	public abstract XmlSchemaValidity Validity { get; }
	public abstract Boolean IsDefault { get; }
	public abstract Boolean IsNil { get; }
	public abstract XmlSchemaSimpleType MemberType { get; }
	public abstract XmlSchemaType SchemaType { get; }
	public abstract XmlSchemaElement SchemaElement { get; }
	public abstract XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: -1
	public abstract XmlSchemaValidity get_Validity() { }

	// RVA: -1
	public abstract Boolean get_IsDefault() { }

	// RVA: -1
	public abstract Boolean get_IsNil() { }

	// RVA: -1
	public abstract XmlSchemaSimpleType get_MemberType() { }

	// RVA: -1
	public abstract XmlSchemaType get_SchemaType() { }

	// RVA: -1
	public abstract XmlSchemaElement get_SchemaElement() { }

	// RVA: -1
	public abstract XmlSchemaAttribute get_SchemaAttribute() { }

}

// Namespace: System.Xml.Schema
internal class NamespaceList
{
	// Fields
	private ListType type; // 0x10
	private Hashtable set; // 0x18
	private String targetNamespace; // 0x20

	// Properties
	public ListType Type { get; }
	public String Excluded { get; }
	public ICollection Enumerate { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A93F9C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75A93FA0
	public Void .ctor(String namespaces, String targetNamespace) { }

	// RVA: 0xFFFFFFFF75A94214
	public ListType get_Type() { }

	// RVA: 0xFFFFFFFF75A9421C
	public String get_Excluded() { }

	// RVA: 0xFFFFFFFF75A94224
	public ICollection get_Enumerate() { }

	// RVA: 0xFFFFFFFF75A942AC
	public virtual Boolean Allows(String ns) { }

	// RVA: 0xFFFFFFFF75A94338
	public Boolean Allows(XmlQualifiedName qname) { }

	// RVA: 0xFFFFFFFF75A94360
	public override String ToString() { }

}

// Namespace: 
public enum ListType
{
	// Fields
	public Int32 value__; // 0x10
	public const ListType Any = 0;
	public const ListType Other = 1;
	public const ListType Set = 2;
}

// Namespace: System.Xml.Schema
internal sealed class SchemaAttDef
{
	// Fields
	private String defExpanded; // 0x60
	private Int32 lineNum; // 0x68
	private Int32 linePos; // 0x6C
	private Int32 valueLineNum; // 0x70
	private Int32 valueLinePos; // 0x74
	private Reserve reserved; // 0x78
	private Boolean defaultValueChecked; // 0x7C
	private Boolean hasEntityRef; // 0x7D
	private XmlSchemaAttribute schemaAttribute; // 0x80
	public static readonly SchemaAttDef Empty; // 0x0

	// Properties
	private String System.Xml.IDtdAttributeInfo.Prefix { get; }
	private String System.Xml.IDtdAttributeInfo.LocalName { get; }
	private Int32 System.Xml.IDtdAttributeInfo.LineNumber { get; }
	private Int32 System.Xml.IDtdAttributeInfo.LinePosition { get; }
	private Boolean System.Xml.IDtdAttributeInfo.IsNonCDataType { get; }
	private Boolean System.Xml.IDtdAttributeInfo.IsDeclaredInExternal { get; }
	private Boolean System.Xml.IDtdAttributeInfo.IsXmlAttribute { get; }
	private String System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded { get; }
	private Object System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped { get; }
	private Int32 System.Xml.IDtdDefaultAttributeInfo.ValueLineNumber { get; }
	private Int32 System.Xml.IDtdDefaultAttributeInfo.ValueLinePosition { get; }
	internal Int32 LinePosition { get; set; }
	internal Int32 LineNumber { get; set; }
	internal Int32 ValueLinePosition { get; set; }
	internal Int32 ValueLineNumber { get; set; }
	internal String DefaultValueExpanded { get; set; }
	internal XmlTokenizedType TokenizedType { get; set; }
	internal Reserve Reserved { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75A98E2C
	public Void .ctor(XmlQualifiedName name, String prefix) { }

	// RVA: 0xFFFFFFFF75A98EDC
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF75A98F40
	private String System.Xml.IDtdAttributeInfo.get_Prefix() { }

	// RVA: 0xFFFFFFFF75A98F80
	private String System.Xml.IDtdAttributeInfo.get_LocalName() { }

	// RVA: 0xFFFFFFFF75A98FA0
	private Int32 System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	// RVA: 0xFFFFFFFF75A98FA8
	private Int32 System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	// RVA: 0xFFFFFFFF75A98FB0
	private Boolean System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	// RVA: 0xFFFFFFFF75A9900C
	private Boolean System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	// RVA: 0xFFFFFFFF75A99014
	private Boolean System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	// RVA: 0xFFFFFFFF75A99024
	private String System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	// RVA: 0xFFFFFFFF75A99044
	private Object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	// RVA: 0xFFFFFFFF75A9904C
	private Int32 System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	// RVA: 0xFFFFFFFF75A99054
	private Int32 System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

	// RVA: 0xFFFFFFFF75A9905C
	internal Int32 get_LinePosition() { }

	// RVA: 0xFFFFFFFF75A99064
	internal Void set_LinePosition(Int32 value) { }

	// RVA: 0xFFFFFFFF75A9906C
	internal Int32 get_LineNumber() { }

	// RVA: 0xFFFFFFFF75A99074
	internal Void set_LineNumber(Int32 value) { }

	// RVA: 0xFFFFFFFF75A9907C
	internal Int32 get_ValueLinePosition() { }

	// RVA: 0xFFFFFFFF75A99084
	internal Void set_ValueLinePosition(Int32 value) { }

	// RVA: 0xFFFFFFFF75A9908C
	internal Int32 get_ValueLineNumber() { }

	// RVA: 0xFFFFFFFF75A99094
	internal Void set_ValueLineNumber(Int32 value) { }

	// RVA: 0xFFFFFFFF75A930D4
	internal String get_DefaultValueExpanded() { }

	// RVA: 0xFFFFFFFF75A9909C
	internal Void set_DefaultValueExpanded(String value) { }

	// RVA: 0xFFFFFFFF75A98FE4
	internal XmlTokenizedType get_TokenizedType() { }

	// RVA: 0xFFFFFFFF75A990D4
	internal Void set_TokenizedType(XmlTokenizedType value) { }

	// RVA: 0xFFFFFFFF75A99118
	internal Reserve get_Reserved() { }

	// RVA: 0xFFFFFFFF75A99120
	internal Void set_Reserved(Reserve value) { }

	// RVA: 0xFFFFFFFF75A99128
	internal Void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	// RVA: 0xFFFFFFFF75A99358
	private static Void .cctor() { }

}

// Namespace: 
internal enum Reserve
{
	// Fields
	public Int32 value__; // 0x10
	public const Reserve None = 0;
	public const Reserve XmlSpace = 1;
	public const Reserve XmlLang = 2;
}

// Namespace: System.Xml.Schema
internal abstract class SchemaDeclBase
{
	// Fields
	protected XmlQualifiedName name; // 0x10
	protected String prefix; // 0x18
	protected Boolean isDeclaredInExternal; // 0x20
	protected Use presence; // 0x24
	protected XmlSchemaType schemaType; // 0x28
	protected XmlSchemaDatatype datatype; // 0x30
	protected String defaultValueRaw; // 0x38
	protected Object defaultValueTyped; // 0x40
	protected Int64 maxLength; // 0x48
	protected Int64 minLength; // 0x50
	protected List<T0> values; // 0x58

	// Properties
	internal XmlQualifiedName Name { get; }
	internal String Prefix { get; }
	internal Boolean IsDeclaredInExternal { get; set; }
	internal Use Presence { get; set; }
	internal XmlSchemaType SchemaType { set; }
	internal XmlSchemaDatatype Datatype { get; set; }
	internal List<T0> Values { get; }
	internal String DefaultValueRaw { get; }
	internal Object DefaultValueTyped { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75A98E30
	protected Void .ctor(XmlQualifiedName name, String prefix) { }

	// RVA: 0xFFFFFFFF75A98EE0
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF75A993A8
	internal XmlQualifiedName get_Name() { }

	// RVA: 0xFFFFFFFF75A98F60
	internal String get_Prefix() { }

	// RVA: 0xFFFFFFFF75A993B0
	internal Boolean get_IsDeclaredInExternal() { }

	// RVA: 0xFFFFFFFF75A993B8
	internal Void set_IsDeclaredInExternal(Boolean value) { }

	// RVA: 0xFFFFFFFF75A993C0
	internal Use get_Presence() { }

	// RVA: 0xFFFFFFFF75A993C8
	internal Void set_Presence(Use value) { }

	// RVA: 0xFFFFFFFF75A993D0
	internal Void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0xFFFFFFFF75A99408
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0xFFFFFFFF75A99410
	internal Void set_Datatype(XmlSchemaDatatype value) { }

	// RVA: 0xFFFFFFFF75A99448
	internal Void AddValue(String value) { }

	// RVA: 0xFFFFFFFF75A994C4
	internal List<T0> get_Values() { }

	// RVA: 0xFFFFFFFF75A994CC
	internal String get_DefaultValueRaw() { }

	// RVA: 0xFFFFFFFF75A994EC
	internal Object get_DefaultValueTyped() { }

	// RVA: 0xFFFFFFFF75A994F4
	internal Void set_DefaultValueTyped(Object value) { }

}

// Namespace: 
internal enum Use
{
	// Fields
	public Int32 value__; // 0x10
	public const Use Default = 0;
	public const Use Required = 1;
	public const Use Implied = 2;
	public const Use Fixed = 3;
	public const Use RequiredFixed = 4;
}

// Namespace: System.Xml.Schema
internal sealed class SchemaElementDecl
{
	// Fields
	private Dictionary<T0, T1> attdefs; // 0x60
	private List<T0> defaultAttdefs; // 0x68
	private Boolean isIdDeclared; // 0x70
	private Boolean hasNonCDataAttribute; // 0x71
	private Boolean isAbstract; // 0x72
	private Boolean isNillable; // 0x73
	private Boolean hasRequiredAttribute; // 0x74
	private Boolean isNotationDeclared; // 0x75
	private Dictionary<T0, T1> prohibitedAttributes; // 0x78
	private ContentValidator contentValidator; // 0x80
	private XmlSchemaAnyAttribute anyAttribute; // 0x88
	private XmlSchemaDerivationMethod block; // 0x90
	private CompiledIdentityConstraint[] constraints; // 0x98
	private XmlSchemaElement schemaElement; // 0xA0
	internal static readonly SchemaElementDecl Empty; // 0x0

	// Properties
	private Boolean System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes { get; }
	internal Boolean IsIdDeclared { get; set; }
	internal Boolean HasNonCDataAttribute { get; set; }
	internal Boolean IsNotationDeclared { get; set; }
	internal ContentValidator ContentValidator { get; set; }
	internal XmlSchemaAnyAttribute AnyAttribute { set; }
	internal IList<T0> DefaultAttDefs { get; }
	internal Dictionary<T0, T1> AttDefs { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A9952C
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75A89528
	internal Void .ctor(XmlSchemaDatatype dtype) { }

	// RVA: 0xFFFFFFFF75A99608
	internal Void .ctor(XmlQualifiedName name, String prefix) { }

	// RVA: 0xFFFFFFFF75A996FC
	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	// RVA: 0xFFFFFFFF75A997E8
	private Boolean System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	// RVA: 0xFFFFFFFF75A997F0
	private IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(String prefix, String localName) { }

	// RVA: 0xFFFFFFFF75A99894
	private IEnumerable<T0> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

	// RVA: 0xFFFFFFFF75A9989C
	internal Boolean get_IsIdDeclared() { }

	// RVA: 0xFFFFFFFF75A998A4
	internal Void set_IsIdDeclared(Boolean value) { }

	// RVA: 0xFFFFFFFF75A998AC
	internal Boolean get_HasNonCDataAttribute() { }

	// RVA: 0xFFFFFFFF75A998B4
	internal Void set_HasNonCDataAttribute(Boolean value) { }

	// RVA: 0xFFFFFFFF75A998BC
	internal Boolean get_IsNotationDeclared() { }

	// RVA: 0xFFFFFFFF75A998C4
	internal Void set_IsNotationDeclared(Boolean value) { }

	// RVA: 0xFFFFFFFF75A998CC
	internal ContentValidator get_ContentValidator() { }

	// RVA: 0xFFFFFFFF75A998D4
	internal Void set_ContentValidator(ContentValidator value) { }

	// RVA: 0xFFFFFFFF75A9990C
	internal Void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0xFFFFFFFF75A99944
	internal Void AddAttDef(SchemaAttDef attdef) { }

	// RVA: 0xFFFFFFFF75A99A68
	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	// RVA: 0xFFFFFFFF75A99AE8
	internal IList<T0> get_DefaultAttDefs() { }

	// RVA: 0xFFFFFFFF75A99AF0
	internal Dictionary<T0, T1> get_AttDefs() { }

	// RVA: 0xFFFFFFFF75A99AF8
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class SchemaEntity
{
	// Fields
	private XmlQualifiedName qname; // 0x10
	private String url; // 0x18
	private String pubid; // 0x20
	private String text; // 0x28
	private XmlQualifiedName ndata; // 0x30
	private Int32 lineNumber; // 0x38
	private Int32 linePosition; // 0x3C
	private Boolean isParameter; // 0x40
	private Boolean isExternal; // 0x41
	private Boolean parsingInProgress; // 0x42
	private Boolean isDeclaredInExternal; // 0x43
	private String baseURI; // 0x48
	private String declaredURI; // 0x50

	// Properties
	private String System.Xml.IDtdEntityInfo.Name { get; }
	private Boolean System.Xml.IDtdEntityInfo.IsExternal { get; }
	private Boolean System.Xml.IDtdEntityInfo.IsDeclaredInExternal { get; }
	private Boolean System.Xml.IDtdEntityInfo.IsUnparsedEntity { get; }
	private Boolean System.Xml.IDtdEntityInfo.IsParameterEntity { get; }
	private String System.Xml.IDtdEntityInfo.BaseUriString { get; }
	private String System.Xml.IDtdEntityInfo.DeclaredUriString { get; }
	private String System.Xml.IDtdEntityInfo.SystemId { get; }
	private String System.Xml.IDtdEntityInfo.PublicId { get; }
	private String System.Xml.IDtdEntityInfo.Text { get; }
	private Int32 System.Xml.IDtdEntityInfo.LineNumber { get; }
	private Int32 System.Xml.IDtdEntityInfo.LinePosition { get; }
	internal XmlQualifiedName Name { get; }
	internal String Url { get; set; }
	internal String Pubid { get; set; }
	internal Boolean IsExternal { get; set; }
	internal Boolean DeclaredInExternal { get; set; }
	internal XmlQualifiedName NData { get; set; }
	internal String Text { get; set; }
	internal Int32 Line { get; set; }
	internal Int32 Pos { get; set; }
	internal String BaseURI { get; set; }
	internal Boolean ParsingInProgress { get; set; }
	internal String DeclaredURI { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75A99B68
	internal Void .ctor(XmlQualifiedName qname, Boolean isParameter) { }

	// RVA: 0xFFFFFFFF75A99BF8
	private String System.Xml.IDtdEntityInfo.get_Name() { }

	// RVA: 0xFFFFFFFF75A99C18
	private Boolean System.Xml.IDtdEntityInfo.get_IsExternal() { }

	// RVA: 0xFFFFFFFF75A99C20
	private Boolean System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	// RVA: 0xFFFFFFFF75A99C28
	private Boolean System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	// RVA: 0xFFFFFFFF75A99C50
	private Boolean System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	// RVA: 0xFFFFFFFF75A99C58
	private String System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	// RVA: 0xFFFFFFFF75A99C98
	private String System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	// RVA: 0xFFFFFFFF75A99CD8
	private String System.Xml.IDtdEntityInfo.get_SystemId() { }

	// RVA: 0xFFFFFFFF75A99CE0
	private String System.Xml.IDtdEntityInfo.get_PublicId() { }

	// RVA: 0xFFFFFFFF75A99CE8
	private String System.Xml.IDtdEntityInfo.get_Text() { }

	// RVA: 0xFFFFFFFF75A99CF0
	private Int32 System.Xml.IDtdEntityInfo.get_LineNumber() { }

	// RVA: 0xFFFFFFFF75A99CF8
	private Int32 System.Xml.IDtdEntityInfo.get_LinePosition() { }

	// RVA: 0xFFFFFFFF75A99D00
	internal XmlQualifiedName get_Name() { }

	// RVA: 0xFFFFFFFF75A99D08
	internal String get_Url() { }

	// RVA: 0xFFFFFFFF75A99D10
	internal Void set_Url(String value) { }

	// RVA: 0xFFFFFFFF75A99D50
	internal String get_Pubid() { }

	// RVA: 0xFFFFFFFF75A99D58
	internal Void set_Pubid(String value) { }

	// RVA: 0xFFFFFFFF75A99D90
	internal Boolean get_IsExternal() { }

	// RVA: 0xFFFFFFFF75A99D98
	internal Void set_IsExternal(Boolean value) { }

	// RVA: 0xFFFFFFFF75A99DA0
	internal Boolean get_DeclaredInExternal() { }

	// RVA: 0xFFFFFFFF75A99DA8
	internal Void set_DeclaredInExternal(Boolean value) { }

	// RVA: 0xFFFFFFFF75A99DB0
	internal XmlQualifiedName get_NData() { }

	// RVA: 0xFFFFFFFF75A99DB8
	internal Void set_NData(XmlQualifiedName value) { }

	// RVA: 0xFFFFFFFF75A99DF0
	internal String get_Text() { }

	// RVA: 0xFFFFFFFF75A99DF8
	internal Void set_Text(String value) { }

	// RVA: 0xFFFFFFFF75A99E34
	internal Int32 get_Line() { }

	// RVA: 0xFFFFFFFF75A99E3C
	internal Void set_Line(Int32 value) { }

	// RVA: 0xFFFFFFFF75A99E44
	internal Int32 get_Pos() { }

	// RVA: 0xFFFFFFFF75A99E4C
	internal Void set_Pos(Int32 value) { }

	// RVA: 0xFFFFFFFF75A99C78
	internal String get_BaseURI() { }

	// RVA: 0xFFFFFFFF75A99E54
	internal Void set_BaseURI(String value) { }

	// RVA: 0xFFFFFFFF75A99E8C
	internal Boolean get_ParsingInProgress() { }

	// RVA: 0xFFFFFFFF75A99E94
	internal Void set_ParsingInProgress(Boolean value) { }

	// RVA: 0xFFFFFFFF75A99CB8
	internal String get_DeclaredURI() { }

	// RVA: 0xFFFFFFFF75A99E9C
	internal Void set_DeclaredURI(String value) { }

}

// Namespace: System.Xml.Schema
internal class SchemaInfo
{
	// Fields
	private Dictionary<T0, T1> elementDecls; // 0x10
	private Dictionary<T0, T1> undeclaredElementDecls; // 0x18
	private Dictionary<T0, T1> generalEntities; // 0x20
	private Dictionary<T0, T1> parameterEntities; // 0x28
	private XmlQualifiedName docTypeName; // 0x30
	private String internalDtdSubset; // 0x38
	private Boolean hasNonCDataAttributes; // 0x40
	private Boolean hasDefaultAttributes; // 0x41
	private Dictionary<T0, T1> targetNamespaces; // 0x48
	private Dictionary<T0, T1> attributeDecls; // 0x50
	private Int32 errorCount; // 0x58
	private SchemaType schemaType; // 0x5C
	private Dictionary<T0, T1> elementDeclsByType; // 0x60
	private Dictionary<T0, T1> notations; // 0x68

	// Properties
	public XmlQualifiedName DocTypeName { set; }
	internal String InternalDtdSubset { set; }
	internal Dictionary<T0, T1> ElementDecls { get; }
	internal Dictionary<T0, T1> UndeclaredElementDecls { get; }
	internal Dictionary<T0, T1> GeneralEntities { get; }
	internal Dictionary<T0, T1> ParameterEntities { get; }
	internal SchemaType SchemaType { get; set; }
	internal Dictionary<T0, T1> Notations { get; }
	private Boolean System.Xml.IDtdInfo.HasDefaultAttributes { get; }
	private Boolean System.Xml.IDtdInfo.HasNonCDataAttributes { get; }
	private XmlQualifiedName System.Xml.IDtdInfo.Name { get; }
	private String System.Xml.IDtdInfo.InternalDtdSubset { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A99ED4
	internal Void .ctor() { }

	// RVA: 0xFFFFFFFF75A9A0C0
	public Void set_DocTypeName(XmlQualifiedName value) { }

	// RVA: 0xFFFFFFFF75A9A0F8
	internal Void set_InternalDtdSubset(String value) { }

	// RVA: 0xFFFFFFFF75A9A130
	internal Dictionary<T0, T1> get_ElementDecls() { }

	// RVA: 0xFFFFFFFF75A9A138
	internal Dictionary<T0, T1> get_UndeclaredElementDecls() { }

	// RVA: 0xFFFFFFFF75A9A140
	internal Dictionary<T0, T1> get_GeneralEntities() { }

	// RVA: 0xFFFFFFFF75A9A1CC
	internal Dictionary<T0, T1> get_ParameterEntities() { }

	// RVA: 0xFFFFFFFF75A9A258
	internal SchemaType get_SchemaType() { }

	// RVA: 0xFFFFFFFF75A9A260
	internal Void set_SchemaType(SchemaType value) { }

	// RVA: 0xFFFFFFFF75A9A268
	internal Dictionary<T0, T1> get_Notations() { }

	// RVA: 0xFFFFFFFF75A9A2F4
	internal Void Finish() { }

	// RVA: 0xFFFFFFFF75A9A4FC
	private Boolean System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	// RVA: 0xFFFFFFFF75A9A504
	private Boolean System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	// RVA: 0xFFFFFFFF75A9A50C
	private IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(String prefix, String localName) { }

	// RVA: 0xFFFFFFFF75A9A5A4
	private IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(String name) { }

	// RVA: 0xFFFFFFFF75A9A650
	private XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	// RVA: 0xFFFFFFFF75A9A658
	private String System.Xml.IDtdInfo.get_InternalDtdSubset() { }

}

// Namespace: System.Xml.Schema
internal sealed class SchemaNames
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	public String NsDataType; // 0x18
	public String NsDataTypeAlias; // 0x20
	public String NsDataTypeOld; // 0x28
	public String NsXml; // 0x30
	public String NsXmlNs; // 0x38
	public String NsXdr; // 0x40
	public String NsXdrAlias; // 0x48
	public String NsXs; // 0x50
	public String NsXsi; // 0x58
	public String XsiType; // 0x60
	public String XsiNil; // 0x68
	public String XsiSchemaLocation; // 0x70
	public String XsiNoNamespaceSchemaLocation; // 0x78
	public String XsdSchema; // 0x80
	public String XdrSchema; // 0x88
	public XmlQualifiedName QnPCData; // 0x90
	public XmlQualifiedName QnXml; // 0x98
	public XmlQualifiedName QnXmlNs; // 0xA0
	public XmlQualifiedName QnDtDt; // 0xA8
	public XmlQualifiedName QnXmlLang; // 0xB0
	public XmlQualifiedName QnName; // 0xB8
	public XmlQualifiedName QnType; // 0xC0
	public XmlQualifiedName QnMaxOccurs; // 0xC8
	public XmlQualifiedName QnMinOccurs; // 0xD0
	public XmlQualifiedName QnInfinite; // 0xD8
	public XmlQualifiedName QnModel; // 0xE0
	public XmlQualifiedName QnOpen; // 0xE8
	public XmlQualifiedName QnClosed; // 0xF0
	public XmlQualifiedName QnContent; // 0xF8
	public XmlQualifiedName QnMixed; // 0x100
	public XmlQualifiedName QnEmpty; // 0x108
	public XmlQualifiedName QnEltOnly; // 0x110
	public XmlQualifiedName QnTextOnly; // 0x118
	public XmlQualifiedName QnOrder; // 0x120
	public XmlQualifiedName QnSeq; // 0x128
	public XmlQualifiedName QnOne; // 0x130
	public XmlQualifiedName QnMany; // 0x138
	public XmlQualifiedName QnRequired; // 0x140
	public XmlQualifiedName QnYes; // 0x148
	public XmlQualifiedName QnNo; // 0x150
	public XmlQualifiedName QnString; // 0x158
	public XmlQualifiedName QnID; // 0x160
	public XmlQualifiedName QnIDRef; // 0x168
	public XmlQualifiedName QnIDRefs; // 0x170
	public XmlQualifiedName QnEntity; // 0x178
	public XmlQualifiedName QnEntities; // 0x180
	public XmlQualifiedName QnNmToken; // 0x188
	public XmlQualifiedName QnNmTokens; // 0x190
	public XmlQualifiedName QnEnumeration; // 0x198
	public XmlQualifiedName QnDefault; // 0x1A0
	public XmlQualifiedName QnXdrSchema; // 0x1A8
	public XmlQualifiedName QnXdrElementType; // 0x1B0
	public XmlQualifiedName QnXdrElement; // 0x1B8
	public XmlQualifiedName QnXdrGroup; // 0x1C0
	public XmlQualifiedName QnXdrAttributeType; // 0x1C8
	public XmlQualifiedName QnXdrAttribute; // 0x1D0
	public XmlQualifiedName QnXdrDataType; // 0x1D8
	public XmlQualifiedName QnXdrDescription; // 0x1E0
	public XmlQualifiedName QnXdrExtends; // 0x1E8
	public XmlQualifiedName QnXdrAliasSchema; // 0x1F0
	public XmlQualifiedName QnDtType; // 0x1F8
	public XmlQualifiedName QnDtValues; // 0x200
	public XmlQualifiedName QnDtMaxLength; // 0x208
	public XmlQualifiedName QnDtMinLength; // 0x210
	public XmlQualifiedName QnDtMax; // 0x218
	public XmlQualifiedName QnDtMin; // 0x220
	public XmlQualifiedName QnDtMinExclusive; // 0x228
	public XmlQualifiedName QnDtMaxExclusive; // 0x230
	public XmlQualifiedName QnTargetNamespace; // 0x238
	public XmlQualifiedName QnVersion; // 0x240
	public XmlQualifiedName QnFinalDefault; // 0x248
	public XmlQualifiedName QnBlockDefault; // 0x250
	public XmlQualifiedName QnFixed; // 0x258
	public XmlQualifiedName QnAbstract; // 0x260
	public XmlQualifiedName QnBlock; // 0x268
	public XmlQualifiedName QnSubstitutionGroup; // 0x270
	public XmlQualifiedName QnFinal; // 0x278
	public XmlQualifiedName QnNillable; // 0x280
	public XmlQualifiedName QnRef; // 0x288
	public XmlQualifiedName QnBase; // 0x290
	public XmlQualifiedName QnDerivedBy; // 0x298
	public XmlQualifiedName QnNamespace; // 0x2A0
	public XmlQualifiedName QnProcessContents; // 0x2A8
	public XmlQualifiedName QnRefer; // 0x2B0
	public XmlQualifiedName QnPublic; // 0x2B8
	public XmlQualifiedName QnSystem; // 0x2C0
	public XmlQualifiedName QnSchemaLocation; // 0x2C8
	public XmlQualifiedName QnValue; // 0x2D0
	public XmlQualifiedName QnUse; // 0x2D8
	public XmlQualifiedName QnForm; // 0x2E0
	public XmlQualifiedName QnElementFormDefault; // 0x2E8
	public XmlQualifiedName QnAttributeFormDefault; // 0x2F0
	public XmlQualifiedName QnItemType; // 0x2F8
	public XmlQualifiedName QnMemberTypes; // 0x300
	public XmlQualifiedName QnXPath; // 0x308
	public XmlQualifiedName QnXsdSchema; // 0x310
	public XmlQualifiedName QnXsdAnnotation; // 0x318
	public XmlQualifiedName QnXsdInclude; // 0x320
	public XmlQualifiedName QnXsdImport; // 0x328
	public XmlQualifiedName QnXsdElement; // 0x330
	public XmlQualifiedName QnXsdAttribute; // 0x338
	public XmlQualifiedName QnXsdAttributeGroup; // 0x340
	public XmlQualifiedName QnXsdAnyAttribute; // 0x348
	public XmlQualifiedName QnXsdGroup; // 0x350
	public XmlQualifiedName QnXsdAll; // 0x358
	public XmlQualifiedName QnXsdChoice; // 0x360
	public XmlQualifiedName QnXsdSequence; // 0x368
	public XmlQualifiedName QnXsdAny; // 0x370
	public XmlQualifiedName QnXsdNotation; // 0x378
	public XmlQualifiedName QnXsdSimpleType; // 0x380
	public XmlQualifiedName QnXsdComplexType; // 0x388
	public XmlQualifiedName QnXsdUnique; // 0x390
	public XmlQualifiedName QnXsdKey; // 0x398
	public XmlQualifiedName QnXsdKeyRef; // 0x3A0
	public XmlQualifiedName QnXsdSelector; // 0x3A8
	public XmlQualifiedName QnXsdField; // 0x3B0
	public XmlQualifiedName QnXsdMinExclusive; // 0x3B8
	public XmlQualifiedName QnXsdMinInclusive; // 0x3C0
	public XmlQualifiedName QnXsdMaxInclusive; // 0x3C8
	public XmlQualifiedName QnXsdMaxExclusive; // 0x3D0
	public XmlQualifiedName QnXsdTotalDigits; // 0x3D8
	public XmlQualifiedName QnXsdFractionDigits; // 0x3E0
	public XmlQualifiedName QnXsdLength; // 0x3E8
	public XmlQualifiedName QnXsdMinLength; // 0x3F0
	public XmlQualifiedName QnXsdMaxLength; // 0x3F8
	public XmlQualifiedName QnXsdEnumeration; // 0x400
	public XmlQualifiedName QnXsdPattern; // 0x408
	public XmlQualifiedName QnXsdDocumentation; // 0x410
	public XmlQualifiedName QnXsdAppinfo; // 0x418
	public XmlQualifiedName QnSource; // 0x420
	public XmlQualifiedName QnXsdComplexContent; // 0x428
	public XmlQualifiedName QnXsdSimpleContent; // 0x430
	public XmlQualifiedName QnXsdRestriction; // 0x438
	public XmlQualifiedName QnXsdExtension; // 0x440
	public XmlQualifiedName QnXsdUnion; // 0x448
	public XmlQualifiedName QnXsdList; // 0x450
	public XmlQualifiedName QnXsdWhiteSpace; // 0x458
	public XmlQualifiedName QnXsdRedefine; // 0x460
	public XmlQualifiedName QnXsdAnyType; // 0x468
	internal XmlQualifiedName[] TokenToQName; // 0x470
}

// Namespace: System.Xml.Schema
internal sealed class SchemaNotation
{
	// Fields
	internal const Int32 SYSTEM = 0;
	internal const Int32 PUBLIC = 1;
	private XmlQualifiedName name; // 0x10
	private String systemLiteral; // 0x18
	private String pubid; // 0x20

	// Properties
	internal XmlQualifiedName Name { get; }
	internal String SystemLiteral { get; set; }
	internal String Pubid { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75A9A660
	internal Void .ctor(XmlQualifiedName name) { }

	// RVA: 0xFFFFFFFF75A9A698
	internal XmlQualifiedName get_Name() { }

	// RVA: 0xFFFFFFFF75A9A6A0
	internal String get_SystemLiteral() { }

	// RVA: 0xFFFFFFFF75A9A6A8
	internal Void set_SystemLiteral(String value) { }

	// RVA: 0xFFFFFFFF75A9A6E0
	internal String get_Pubid() { }

	// RVA: 0xFFFFFFFF75A9A6E8
	internal Void set_Pubid(String value) { }

}

// Namespace: System.Xml.Schema
internal enum SchemaType
{
	// Fields
	public Int32 value__; // 0x10
	public const SchemaType None = 0;
	public const SchemaType DTD = 1;
	public const SchemaType XDR = 2;
	public const SchemaType XSD = 3;
}

// Namespace: System.Xml.Schema
public class ValidationEventArgs
{
	// Fields
	private XmlSchemaException ex; // 0x10
	private XmlSeverityType severity; // 0x18

	// Properties
	public XmlSeverityType Severity { get; }
	public XmlSchemaException Exception { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A9B6C4
	public XmlSeverityType get_Severity() { }

	// RVA: 0xFFFFFFFF75A9B6CC
	public XmlSchemaException get_Exception() { }

}

// Namespace: System.Xml.Schema
public sealed class ValidationEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75A9B6D4
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75A9B718
	public virtual Void Invoke(Object sender, ValidationEventArgs e) { }

	// RVA: 0xFFFFFFFF75A9BAE4
	public virtual IAsyncResult BeginInvoke(Object sender, ValidationEventArgs e, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75A9BB40
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Xml.Schema
public sealed class XmlAtomicValue
{
	// Fields
	private XmlSchemaType xmlType; // 0x10
	private Object objVal; // 0x18
	private TypeCode clrType; // 0x20
	private Union unionVal; // 0x28
	private NamespacePrefixForQName nsPrefix; // 0x30

	// Properties
	public override XmlSchemaType XmlType { get; }
	public override Type ValueType { get; }
	public override Object TypedValue { get; }
	public override Boolean ValueAsBoolean { get; }
	public override DateTime ValueAsDateTime { get; }
	public override Double ValueAsDouble { get; }
	public override Int32 ValueAsInt { get; }
	public override Int64 ValueAsLong { get; }
	public override String Value { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A9CBE0
	internal Void .ctor(XmlSchemaType xmlType, Boolean value) { }

	// RVA: 0xFFFFFFFF75A9CF7C
	internal Void .ctor(XmlSchemaType xmlType, DateTime value) { }

	// RVA: 0xFFFFFFFF75A9D47C
	internal Void .ctor(XmlSchemaType xmlType, Double value) { }

	// RVA: 0xFFFFFFFF75A9D6D4
	internal Void .ctor(XmlSchemaType xmlType, Int32 value) { }

	// RVA: 0xFFFFFFFF75A9D924
	internal Void .ctor(XmlSchemaType xmlType, Int64 value) { }

	// RVA: 0xFFFFFFFF75A9DB8C
	internal Void .ctor(XmlSchemaType xmlType, String value) { }

	// RVA: 0xFFFFFFFF75A9F070
	internal Void .ctor(XmlSchemaType xmlType, String value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75A9D1F0
	internal Void .ctor(XmlSchemaType xmlType, Object value) { }

	// RVA: 0xFFFFFFFF75A8A9CC
	internal Void .ctor(XmlSchemaType xmlType, Object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75A9F3A0
	private Object System.ICloneable.Clone() { }

	// RVA: 0xFFFFFFFF75A9F3A4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0xFFFFFFFF75A9F3AC
	public override Type get_ValueType() { }

	// RVA: 0xFFFFFFFF75A9F3DC
	public override Object get_TypedValue() { }

	// RVA: 0xFFFFFFFF75A9F5D0
	public override Boolean get_ValueAsBoolean() { }

	// RVA: 0xFFFFFFFF75A9F6C4
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0xFFFFFFFF75A9F7B8
	public override Double get_ValueAsDouble() { }

	// RVA: 0xFFFFFFFF75A9F8A0
	public override Int32 get_ValueAsInt() { }

	// RVA: 0xFFFFFFFF75A9F994
	public override Int64 get_ValueAsLong() { }

	// RVA: 0xFFFFFFFF75A9FA88
	public override Object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75A9FC90
	public override String get_Value() { }

	// RVA: 0xFFFFFFFF75A9FD98
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75A9F298
	private String GetPrefixFromQName(String value) { }

}

// Namespace: 
private struct Union
{
	// Fields
	public Boolean boolVal; // 0x10
	public Double dblVal; // 0x10
	public Int64 i64Val; // 0x10
	public Int32 i32Val; // 0x10
	public DateTime dtVal; // 0x10
}

// Namespace: 
private class NamespacePrefixForQName
{
	// Fields
	public String prefix; // 0x10
	public String ns; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75A9F33C
	public Void .ctor(String prefix, String ns) { }

	// RVA: 0xFFFFFFFF75A9FDA8
	public String LookupNamespace(String prefix) { }

	// RVA: 0xFFFFFFFF75A9FDE8
	public String LookupPrefix(String namespaceName) { }

}

// Namespace: System.Xml.Schema
public class XmlSchema
{
	// Fields
	public const String Namespace = "http://www.w3.org/2001/XMLSchema";
	public const String InstanceNamespace = "http://www.w3.org/2001/XMLSchema-instance";
	private XmlSchemaForm attributeFormDefault; // 0x34
	private XmlSchemaForm elementFormDefault; // 0x38
	private XmlSchemaDerivationMethod blockDefault; // 0x3C
	private XmlSchemaDerivationMethod finalDefault; // 0x40
	private String targetNs; // 0x48
	private String version; // 0x50
	private XmlSchemaObjectCollection includes; // 0x58
	private XmlSchemaObjectCollection items; // 0x60
	private String id; // 0x68
	private XmlAttribute[] moreAttributes; // 0x70
	private Boolean isCompiled; // 0x78
	private Boolean isCompiledBySet; // 0x79
	private Boolean isPreprocessed; // 0x7A
	private Boolean isRedefined; // 0x7B
	private Int32 errorCount; // 0x7C
	private XmlSchemaObjectTable attributes; // 0x80
	private XmlSchemaObjectTable attributeGroups; // 0x88
	private XmlSchemaObjectTable elements; // 0x90
	private XmlSchemaObjectTable types; // 0x98
	private XmlSchemaObjectTable groups; // 0xA0
	private XmlSchemaObjectTable notations; // 0xA8
	private XmlSchemaObjectTable identityConstraints; // 0xB0
	private static Int32 globalIdCounter; // 0x0
	private ArrayList importedSchemas; // 0xB8
	private ArrayList importedNamespaces; // 0xC0
	private Int32 schemaId; // 0xC8
	private Uri baseUri; // 0xD0
	private Boolean isChameleon; // 0xD8
	private Hashtable ids; // 0xE0
	private XmlDocument document; // 0xE8
	private XmlNameTable nameTable; // 0xF0

	// Methods

	// RVA: 0xFFFFFFFF75AAF21C
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAnnotated
{
	// Fields
	private String id; // 0x38
	private XmlSchemaAnnotation annotation; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Methods

	// RVA: 0xFFFFFFFF75AAF268
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAnnotation
{
	// Fields
	private String id; // 0x38
	private XmlSchemaObjectCollection items; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48
}

// Namespace: System.Xml.Schema
public class XmlSchemaAny
{
	// Fields
	private String ns; // 0x78
	private XmlSchemaContentProcessing processContents; // 0x80
	private NamespaceList namespaceList; // 0x88

	// Properties
	public XmlSchemaContentProcessing ProcessContents { set; }
	internal NamespaceList NamespaceList { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AAF270
	public Void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0xFFFFFFFF75AAF278
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0xFFFFFFFF75AAF280
	internal Void BuildNamespaceList(String targetNamespace) { }

	// RVA: 0xFFFFFFFF75AAF31C
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAnyAttribute
{
	// Fields
	private String ns; // 0x50
	private XmlSchemaContentProcessing processContents; // 0x58
	private NamespaceList namespaceList; // 0x60

	// Properties
	public XmlSchemaContentProcessing ProcessContents { set; }

	// Methods

	// RVA: 0xFFFFFFFF75AAF3CC
	public Void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0xFFFFFFFF75AAF3D4
	internal Void BuildNamespaceList(String targetNamespace) { }

	// RVA: 0xFFFFFFFF75AAF470
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAttribute
{
	// Fields
	private String defaultValue; // 0x50
	private String fixedValue; // 0x58
	private String name; // 0x60
	private XmlSchemaForm form; // 0x68
	private XmlSchemaUse use; // 0x6C
	private XmlQualifiedName refName; // 0x70
	private XmlQualifiedName typeName; // 0x78
	private XmlQualifiedName qualifiedName; // 0x80
	private XmlSchemaSimpleType type; // 0x88
	private XmlSchemaSimpleType attributeType; // 0x90
	private SchemaAttDef attDef; // 0x98
}

// Namespace: System.Xml.Schema
public class XmlSchemaChoice
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	public override XmlSchemaObjectCollection Items { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AAF474
	public override XmlSchemaObjectCollection get_Items() { }

}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaCompilationSettings
{
	// Fields
	private Boolean enableUpaCheck; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75AAF47C
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaComplexType
{
	// Fields
	private XmlSchemaDerivationMethod block; // 0x94
	private XmlSchemaParticle contentTypeParticle; // 0x98
	private XmlSchemaAnyAttribute attributeWildcard; // 0xA0
	private static XmlSchemaComplexType anyTypeLax; // 0x0
	private static XmlSchemaComplexType anyTypeSkip; // 0x8
	private static XmlSchemaComplexType untypedAnyType; // 0x10
	private Byte pvFlags; // 0xA8

	// Properties
	internal static XmlSchemaComplexType AnyType { get; }
	internal static ContentValidator AnyTypeContentValidator { get; }
	public override Boolean IsMixed { set; }
	public XmlSchemaParticle ContentTypeParticle { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AAF488
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF75AAF6E0
	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	// RVA: 0xFFFFFFFF75AAFA0C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AAFF78
	internal static XmlSchemaComplexType get_AnyType() { }

	// RVA: 0xFFFFFFFF75AAFB1C
	internal static ContentValidator get_AnyTypeContentValidator() { }

	// RVA: 0xFFFFFFFF75AAFFD8
	public override Void set_IsMixed(Boolean value) { }

	// RVA: 0xFFFFFFFF75AAFFF8
	public XmlSchemaParticle get_ContentTypeParticle() { }

	// RVA: 0xFFFFFFFF75AB0000
	internal Void SetContentTypeParticle(XmlSchemaParticle value) { }

	// RVA: 0xFFFFFFFF75AB0038
	internal Void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

}

// Namespace: System.Xml.Schema
public enum XmlSchemaContentProcessing
{
	// Fields
	public Int32 value__; // 0x10
	public const XmlSchemaContentProcessing None = 0;
	public const XmlSchemaContentProcessing Skip = 1;
	public const XmlSchemaContentProcessing Lax = 2;
	public const XmlSchemaContentProcessing Strict = 3;
}

// Namespace: System.Xml.Schema
public enum XmlSchemaContentType
{
	// Fields
	public Int32 value__; // 0x10
	public const XmlSchemaContentType TextOnly = 0;
	public const XmlSchemaContentType Empty = 1;
	public const XmlSchemaContentType ElementOnly = 2;
	public const XmlSchemaContentType Mixed = 3;
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaDatatype
{
	// Properties
	public abstract Type ValueType { get; }
	public abstract XmlTokenizedType TokenizedType { get; }
	public virtual XmlSchemaDatatypeVariety Variety { get; }
	public virtual XmlTypeCode TypeCode { get; }
	internal abstract XmlValueConverter ValueConverter { get; }
	internal abstract RestrictionFacets Restriction { get; }
	internal abstract FacetsChecker FacetsChecker { get; }
	internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal String TypeCodeString { get; }

	// Methods

	// RVA: -1
	public abstract Type get_ValueType() { }

	// RVA: -1
	public abstract XmlTokenizedType get_TokenizedType() { }

	// RVA: -1
	public abstract Object ParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0xFFFFFFFF75AB0070
	public virtual XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0xFFFFFFFF75AB0078
	public virtual XmlTypeCode get_TypeCode() { }

	// RVA: -1
	internal abstract XmlValueConverter get_ValueConverter() { }

	// RVA: -1
	internal abstract RestrictionFacets get_Restriction() { }

	// RVA: -1
	internal abstract Int32 Compare(Object value1, Object value2) { }

	// RVA: -1
	internal abstract Exception TryParseValue(String s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue) { }

	// RVA: -1
	internal abstract FacetsChecker get_FacetsChecker() { }

	// RVA: -1
	internal abstract XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: -1
	internal abstract Boolean IsEqual(Object o1, Object o2) { }

	// RVA: 0xFFFFFFFF75AB0080
	internal String get_TypeCodeString() { }

	// RVA: 0xFFFFFFFF75AB01A8
	internal String TypeCodeToString(XmlTypeCode typeCode) { }

	// RVA: 0xFFFFFFFF75AB0610
	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0xFFFFFFFF75AB0670
	protected Void .ctor() { }

}

// Namespace: System.Xml.Schema
public enum XmlSchemaDerivationMethod
{
	// Fields
	public Int32 value__; // 0x10
	public const XmlSchemaDerivationMethod Empty = 0;
	public const XmlSchemaDerivationMethod Substitution = 1;
	public const XmlSchemaDerivationMethod Extension = 2;
	public const XmlSchemaDerivationMethod Restriction = 4;
	public const XmlSchemaDerivationMethod List = 8;
	public const XmlSchemaDerivationMethod Union = 16;
	public const XmlSchemaDerivationMethod All = 255;
	public const XmlSchemaDerivationMethod None = 256;
}

// Namespace: System.Xml.Schema
public class XmlSchemaElement
{
	// Fields
	private Boolean isAbstract; // 0x74
	private Boolean hasAbstractAttribute; // 0x75
	private Boolean isNillable; // 0x76
	private Boolean hasNillableAttribute; // 0x77
	private Boolean isLocalTypeDerivationChecked; // 0x78
	private XmlSchemaDerivationMethod block; // 0x7C
	private XmlSchemaDerivationMethod final; // 0x80
	private XmlSchemaForm form; // 0x84
	private String defaultValue; // 0x88
	private String fixedValue; // 0x90
	private String name; // 0x98
	private XmlQualifiedName refName; // 0xA0
	private XmlQualifiedName substitutionGroup; // 0xA8
	private XmlQualifiedName typeName; // 0xB0
	private XmlSchemaType type; // 0xB8
	private XmlQualifiedName qualifiedName; // 0xC0
	private XmlSchemaType elementType; // 0xC8
	private XmlSchemaDerivationMethod blockResolved; // 0xD0
	private XmlSchemaDerivationMethod finalResolved; // 0xD4
	private XmlSchemaObjectCollection constraints; // 0xD8
	private SchemaElementDecl elementDecl; // 0xE0
}

// Namespace: System.Xml.Schema
public class XmlSchemaException
{
	// Fields
	private String res; // 0x88
	private String[] args; // 0x90
	private String sourceUri; // 0x98
	private Int32 lineNumber; // 0xA0
	private Int32 linePosition; // 0xA4
	private XmlSchemaObject sourceSchemaObject; // 0xA8
	private String message; // 0xB0

	// Properties
	public override String Message { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AB0674
	protected Void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF75AB0A90
	public override Void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF75AB0BC8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AB0BDC
	public Void .ctor(String message) { }

	// RVA: 0xFFFFFFFF75AB0CE0
	public Void .ctor(String message, Exception innerException) { }

	// RVA: 0xFFFFFFFF75AB0BEC
	public Void .ctor(String message, Exception innerException, Int32 lineNumber, Int32 linePosition) { }

	// RVA: 0xFFFFFFFF75AB0DE8
	internal Void .ctor(String res, String arg) { }

	// RVA: 0xFFFFFFFF75AB0E78
	internal Void .ctor(String res, String arg, String sourceUri, Int32 lineNumber, Int32 linePosition) { }

	// RVA: 0xFFFFFFFF75AB0CEC
	internal Void .ctor(String res, String[] args, Exception innerException, String sourceUri, Int32 lineNumber, Int32 linePosition, XmlSchemaObject source) { }

	// RVA: 0xFFFFFFFF75AB0998
	internal static String CreateMessage(String res, String[] args) { }

	// RVA: 0xFFFFFFFF75AB0F1C
	public override String get_Message() { }

}

// Namespace: System.Xml.Schema
public enum XmlSchemaForm
{
	// Fields
	public Int32 value__; // 0x10
	public const XmlSchemaForm None = 0;
	public const XmlSchemaForm Qualified = 1;
	public const XmlSchemaForm Unqualified = 2;
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaGroupBase
{
	// Properties
	public abstract XmlSchemaObjectCollection Items { get; }

	// Methods

	// RVA: -1
	public abstract XmlSchemaObjectCollection get_Items() { }

	// RVA: 0xFFFFFFFF75AB0F34
	protected Void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaGroupRef
{}

// Namespace: System.Xml.Schema
public class XmlSchemaInfo
{
	// Fields
	private Boolean isDefault; // 0x10
	private Boolean isNil; // 0x11
	private XmlSchemaElement schemaElement; // 0x18
	private XmlSchemaAttribute schemaAttribute; // 0x20
	private XmlSchemaType schemaType; // 0x28
	private XmlSchemaSimpleType memberType; // 0x30
	private XmlSchemaValidity validity; // 0x38
	private XmlSchemaContentType contentType; // 0x3C

	// Properties
	public XmlSchemaValidity Validity { get; }
	public Boolean IsDefault { get; }
	public Boolean IsNil { get; }
	public XmlSchemaSimpleType MemberType { get; }
	public XmlSchemaType SchemaType { get; }
	public XmlSchemaElement SchemaElement { get; }
	public XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AB0F90
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AB1030
	internal Void .ctor(XmlSchemaValidity validity) { }

	// RVA: 0xFFFFFFFF75AB1058
	public XmlSchemaValidity get_Validity() { }

	// RVA: 0xFFFFFFFF75AB1060
	public Boolean get_IsDefault() { }

	// RVA: 0xFFFFFFFF75AB1068
	public Boolean get_IsNil() { }

	// RVA: 0xFFFFFFFF75AB1070
	public XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0xFFFFFFFF75AB1078
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0xFFFFFFFF75AB1080
	public XmlSchemaElement get_SchemaElement() { }

	// RVA: 0xFFFFFFFF75AB1088
	public XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0xFFFFFFFF75AB0F94
	internal Void Clear() { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaObject
{
	// Fields
	private Int32 lineNum; // 0x10
	private Int32 linePos; // 0x14
	private String sourceUri; // 0x18
	private XmlSerializerNamespaces namespaces; // 0x20
	private XmlSchemaObject parent; // 0x28
	private Boolean isProcessing; // 0x30

	// Methods

	// RVA: 0xFFFFFFFF75AB1090
	internal virtual Void OnAdd(XmlSchemaObjectCollection container, Object item) { }

	// RVA: 0xFFFFFFFF75AB1094
	internal virtual Void OnRemove(XmlSchemaObjectCollection container, Object item) { }

	// RVA: 0xFFFFFFFF75AB1098
	internal virtual Void OnClear(XmlSchemaObjectCollection container) { }

	// RVA: 0xFFFFFFFF75AAF26C
	protected Void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectCollection
{
	// Fields
	private XmlSchemaObject parent; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75AB109C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AAFE78
	public Int32 Add(XmlSchemaObject item) { }

	// RVA: 0xFFFFFFFF75AB10A4
	protected override Void OnInsert(Int32 index, Object item) { }

	// RVA: 0xFFFFFFFF75AB10C4
	protected override Void OnSet(Int32 index, Object oldValue, Object newValue) { }

	// RVA: 0xFFFFFFFF75AB1124
	protected override Void OnClear() { }

	// RVA: 0xFFFFFFFF75AB1144
	protected override Void OnRemove(Int32 index, Object item) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectTable
{
	// Fields
	private Dictionary<T0, T1> table; // 0x10
	private List<T0> entries; // 0x18
}

// Namespace: 
internal struct XmlSchemaObjectEntry
{
	// Fields
	internal XmlQualifiedName qname; // 0x10
	internal XmlSchemaObject xso; // 0x18
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaParticle
{
	// Fields
	private Decimal minOccurs; // 0x50
	private Decimal maxOccurs; // 0x60
	private Occurs flags; // 0x70
	internal static readonly XmlSchemaParticle Empty; // 0x0

	// Properties
	public Decimal MinOccurs { set; }
	public Decimal MaxOccurs { set; }

	// Methods

	// RVA: 0xFFFFFFFF75AAFB94
	public Void set_MinOccurs(Decimal value) { }

	// RVA: 0xFFFFFFFF75AAFCB0
	public Void set_MaxOccurs(Decimal value) { }

	// RVA: 0xFFFFFFFF75AAF378
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF75AB1164
	private static Void .cctor() { }

}

// Namespace: 
private enum Occurs
{
	// Fields
	public Int32 value__; // 0x10
	public const Occurs None = 0;
	public const Occurs Min = 1;
	public const Occurs Max = 2;
}

// Namespace: 
private class EmptyParticle
{
	// Methods

	// RVA: 0xFFFFFFFF75AB11E4
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSequence
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	public override XmlSchemaObjectCollection Items { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AB1240
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0xFFFFFFFF75AAFDFC
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSet
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private SortedList schemas; // 0x20
	private ValidationEventHandler internalEventHandler; // 0x28
	private ValidationEventHandler eventHandler; // 0x30
	private Boolean isCompiled; // 0x38
	private Hashtable schemaLocations; // 0x40
	private Hashtable chameleonSchemas; // 0x48
	private Hashtable targetNamespaces; // 0x50
	private Boolean compileAll; // 0x58
	private SchemaInfo cachedCompiledInfo; // 0x60
	private XmlReaderSettings readerSettings; // 0x68
	private XmlSchema schemaForSchema; // 0x70
	private XmlSchemaCompilationSettings compilationSettings; // 0x78
	internal XmlSchemaObjectTable elements; // 0x80
	internal XmlSchemaObjectTable attributes; // 0x88
	internal XmlSchemaObjectTable schemaTypes; // 0x90
	internal XmlSchemaObjectTable substitutionGroups; // 0x98
	private XmlSchemaObjectTable typeExtensions; // 0xA0
	private Object internalSyncObject; // 0xA8

	// Methods

	// RVA: 0xFFFFFFFF75AB1248
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AB1284
	public Void .ctor(XmlNameTable nameTable) { }

	// RVA: 0xFFFFFFFF75AB15A4
	private Void InternalValidationCallback(Object sender, ValidationEventArgs e) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleType
{
	// Fields
	private XmlSchemaSimpleTypeContent content; // 0x98

	// Properties
	public XmlSchemaSimpleTypeContent Content { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75AB1600
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75AB1604
	public XmlSchemaSimpleTypeContent get_Content() { }

	// RVA: 0xFFFFFFFF75AB160C
	public Void set_Content(XmlSchemaSimpleTypeContent value) { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaSimpleTypeContent
{
	// Methods

	// RVA: 0xFFFFFFFF75AB1644
	protected Void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeList
{
	// Fields
	private XmlQualifiedName itemTypeName; // 0x50
	private XmlSchemaSimpleType itemType; // 0x58
	private XmlSchemaSimpleType baseItemType; // 0x60

	// Properties
	public XmlSchemaSimpleType ItemType { set; }
	public XmlSchemaSimpleType BaseItemType { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75AB1648
	public Void set_ItemType(XmlSchemaSimpleType value) { }

	// RVA: 0xFFFFFFFF75AB1680
	public XmlSchemaSimpleType get_BaseItemType() { }

	// RVA: 0xFFFFFFFF75AB1688
	public Void set_BaseItemType(XmlSchemaSimpleType value) { }

	// RVA: 0xFFFFFFFF75AB16C0
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeRestriction
{
	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaObjectCollection facets; // 0x58

	// Properties
	public XmlQualifiedName BaseTypeName { set; }

	// Methods

	// RVA: 0xFFFFFFFF75AB1720
	public Void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0xFFFFFFFF75AB17AC
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeUnion
{}

// Namespace: System.Xml.Schema
public class XmlSchemaType
{
	// Fields
	private String name; // 0x50
	private XmlSchemaDerivationMethod final; // 0x58
	private XmlSchemaDerivationMethod derivedBy; // 0x5C
	private XmlSchemaType baseSchemaType; // 0x60
	private XmlSchemaDatatype datatype; // 0x68
	private XmlSchemaDerivationMethod finalResolved; // 0x70
	private SchemaElementDecl elementDecl; // 0x78
	private XmlQualifiedName qname; // 0x80
	private XmlSchemaType redefined; // 0x88
	private XmlSchemaContentType contentType; // 0x90

	// Properties
	public XmlQualifiedName QualifiedName { get; }
	public XmlSchemaType BaseXmlSchemaType { get; }
	public XmlSchemaDatatype Datatype { get; }
	public virtual Boolean IsMixed { set; }
	public XmlTypeCode TypeCode { get; }
	internal XmlValueConverter ValueConverter { get; }
	internal SchemaElementDecl ElementDecl { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75AB1860
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	// RVA: 0xFFFFFFFF75AB18C0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0xFFFFFFFF75AB18CC
	public XmlSchemaType get_BaseXmlSchemaType() { }

	// RVA: 0xFFFFFFFF75AB18D4
	public XmlSchemaDatatype get_Datatype() { }

	// RVA: 0xFFFFFFFF75AB18DC
	public virtual Void set_IsMixed(Boolean value) { }

	// RVA: 0xFFFFFFFF75AB18E0
	public XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75AB19B4
	internal XmlValueConverter get_ValueConverter() { }

	// RVA: 0xFFFFFFFF75AAFA98
	internal Void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0xFFFFFFFF75AB1A38
	internal Void SetBaseSchemaType(XmlSchemaType value) { }

	// RVA: 0xFFFFFFFF75AB1A70
	internal Void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	// RVA: 0xFFFFFFFF75AB1A78
	internal Void SetDatatype(XmlSchemaDatatype value) { }

	// RVA: 0xFFFFFFFF75AAFB10
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0xFFFFFFFF75AAFAD4
	internal Void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0xFFFFFFFF75AB1AB0
	internal Void SetContentType(XmlSchemaContentType value) { }

	// RVA: 0xFFFFFFFF75AAFF0C
	public Void .ctor() { }

}

// Namespace: System.Xml.Schema
public enum XmlSchemaUse
{
	// Fields
	public Int32 value__; // 0x10
	public const XmlSchemaUse None = 0;
	public const XmlSchemaUse Optional = 1;
	public const XmlSchemaUse Prohibited = 2;
	public const XmlSchemaUse Required = 3;
}

// Namespace: System.Xml.Schema
public enum XmlSchemaValidationFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const XmlSchemaValidationFlags None = 0;
	public const XmlSchemaValidationFlags ProcessInlineSchema = 1;
	public const XmlSchemaValidationFlags ProcessSchemaLocation = 2;
	public const XmlSchemaValidationFlags ReportValidationWarnings = 4;
	public const XmlSchemaValidationFlags ProcessIdentityConstraints = 8;
	public const XmlSchemaValidationFlags AllowXmlAttributes = 16;
}

// Namespace: System.Xml.Schema
public enum XmlSchemaValidity
{
	// Fields
	public Int32 value__; // 0x10
	public const XmlSchemaValidity NotKnown = 0;
	public const XmlSchemaValidity Valid = 1;
	public const XmlSchemaValidity Invalid = 2;
}

// Namespace: System.Xml.Schema
public enum XmlSeverityType
{
	// Fields
	public Int32 value__; // 0x10
	public const XmlSeverityType Error = 0;
	public const XmlSeverityType Warning = 1;
}

// Namespace: System.Xml.Schema
public enum XmlTypeCode
{
	// Fields
	public Int32 value__; // 0x10
	public const XmlTypeCode None = 0;
	public const XmlTypeCode Item = 1;
	public const XmlTypeCode Node = 2;
	public const XmlTypeCode Document = 3;
	public const XmlTypeCode Element = 4;
	public const XmlTypeCode Attribute = 5;
	public const XmlTypeCode Namespace = 6;
	public const XmlTypeCode ProcessingInstruction = 7;
	public const XmlTypeCode Comment = 8;
	public const XmlTypeCode Text = 9;
	public const XmlTypeCode AnyAtomicType = 10;
	public const XmlTypeCode UntypedAtomic = 11;
	public const XmlTypeCode String = 12;
	public const XmlTypeCode Boolean = 13;
	public const XmlTypeCode Decimal = 14;
	public const XmlTypeCode Float = 15;
	public const XmlTypeCode Double = 16;
	public const XmlTypeCode Duration = 17;
	public const XmlTypeCode DateTime = 18;
	public const XmlTypeCode Time = 19;
	public const XmlTypeCode Date = 20;
	public const XmlTypeCode GYearMonth = 21;
	public const XmlTypeCode GYear = 22;
	public const XmlTypeCode GMonthDay = 23;
	public const XmlTypeCode GDay = 24;
	public const XmlTypeCode GMonth = 25;
	public const XmlTypeCode HexBinary = 26;
	public const XmlTypeCode Base64Binary = 27;
	public const XmlTypeCode AnyUri = 28;
	public const XmlTypeCode QName = 29;
	public const XmlTypeCode Notation = 30;
	public const XmlTypeCode NormalizedString = 31;
	public const XmlTypeCode Token = 32;
	public const XmlTypeCode Language = 33;
	public const XmlTypeCode NmToken = 34;
	public const XmlTypeCode Name = 35;
	public const XmlTypeCode NCName = 36;
	public const XmlTypeCode Id = 37;
	public const XmlTypeCode Idref = 38;
	public const XmlTypeCode Entity = 39;
	public const XmlTypeCode Integer = 40;
	public const XmlTypeCode NonPositiveInteger = 41;
	public const XmlTypeCode NegativeInteger = 42;
	public const XmlTypeCode Long = 43;
	public const XmlTypeCode Int = 44;
	public const XmlTypeCode Short = 45;
	public const XmlTypeCode Byte = 46;
	public const XmlTypeCode NonNegativeInteger = 47;
	public const XmlTypeCode UnsignedLong = 48;
	public const XmlTypeCode UnsignedInt = 49;
	public const XmlTypeCode UnsignedShort = 50;
	public const XmlTypeCode UnsignedByte = 51;
	public const XmlTypeCode PositiveInteger = 52;
	public const XmlTypeCode YearMonthDuration = 53;
	public const XmlTypeCode DayTimeDuration = 54;
}

// Namespace: System.Xml.Schema
internal abstract class XmlValueConverter
{
	// Methods

	// RVA: -1
	public abstract Boolean ToBoolean(Int64 value) { }

	// RVA: -1
	public abstract Boolean ToBoolean(Int32 value) { }

	// RVA: -1
	public abstract Boolean ToBoolean(Double value) { }

	// RVA: -1
	public abstract Boolean ToBoolean(DateTime value) { }

	// RVA: -1
	public abstract Boolean ToBoolean(String value) { }

	// RVA: -1
	public abstract Boolean ToBoolean(Object value) { }

	// RVA: -1
	public abstract Int32 ToInt32(Boolean value) { }

	// RVA: -1
	public abstract Int32 ToInt32(Int64 value) { }

	// RVA: -1
	public abstract Int32 ToInt32(Double value) { }

	// RVA: -1
	public abstract Int32 ToInt32(DateTime value) { }

	// RVA: -1
	public abstract Int32 ToInt32(String value) { }

	// RVA: -1
	public abstract Int32 ToInt32(Object value) { }

	// RVA: -1
	public abstract Int64 ToInt64(Boolean value) { }

	// RVA: -1
	public abstract Int64 ToInt64(Int32 value) { }

	// RVA: -1
	public abstract Int64 ToInt64(Double value) { }

	// RVA: -1
	public abstract Int64 ToInt64(DateTime value) { }

	// RVA: -1
	public abstract Int64 ToInt64(String value) { }

	// RVA: -1
	public abstract Int64 ToInt64(Object value) { }

	// RVA: -1
	public abstract Decimal ToDecimal(String value) { }

	// RVA: -1
	public abstract Decimal ToDecimal(Object value) { }

	// RVA: -1
	public abstract Double ToDouble(Boolean value) { }

	// RVA: -1
	public abstract Double ToDouble(Int32 value) { }

	// RVA: -1
	public abstract Double ToDouble(Int64 value) { }

	// RVA: -1
	public abstract Double ToDouble(DateTime value) { }

	// RVA: -1
	public abstract Double ToDouble(String value) { }

	// RVA: -1
	public abstract Double ToDouble(Object value) { }

	// RVA: -1
	public abstract Single ToSingle(Double value) { }

	// RVA: -1
	public abstract Single ToSingle(String value) { }

	// RVA: -1
	public abstract Single ToSingle(Object value) { }

	// RVA: -1
	public abstract DateTime ToDateTime(Boolean value) { }

	// RVA: -1
	public abstract DateTime ToDateTime(Int32 value) { }

	// RVA: -1
	public abstract DateTime ToDateTime(Int64 value) { }

	// RVA: -1
	public abstract DateTime ToDateTime(Double value) { }

	// RVA: -1
	public abstract DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: -1
	public abstract DateTime ToDateTime(String value) { }

	// RVA: -1
	public abstract DateTime ToDateTime(Object value) { }

	// RVA: -1
	public abstract DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: -1
	public abstract DateTimeOffset ToDateTimeOffset(String value) { }

	// RVA: -1
	public abstract DateTimeOffset ToDateTimeOffset(Object value) { }

	// RVA: -1
	public abstract String ToString(Boolean value) { }

	// RVA: -1
	public abstract String ToString(Int32 value) { }

	// RVA: -1
	public abstract String ToString(Int64 value) { }

	// RVA: -1
	public abstract String ToString(Decimal value) { }

	// RVA: -1
	public abstract String ToString(Single value) { }

	// RVA: -1
	public abstract String ToString(Double value) { }

	// RVA: -1
	public abstract String ToString(DateTime value) { }

	// RVA: -1
	public abstract String ToString(DateTimeOffset value) { }

	// RVA: -1
	public abstract String ToString(Object value) { }

	// RVA: -1
	public abstract String ToString(Object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: -1
	public abstract Object ChangeType(Boolean value, Type destinationType) { }

	// RVA: -1
	public abstract Object ChangeType(Int32 value, Type destinationType) { }

	// RVA: -1
	public abstract Object ChangeType(Int64 value, Type destinationType) { }

	// RVA: -1
	public abstract Object ChangeType(Decimal value, Type destinationType) { }

	// RVA: -1
	public abstract Object ChangeType(Double value, Type destinationType) { }

	// RVA: -1
	public abstract Object ChangeType(DateTime value, Type destinationType) { }

	// RVA: -1
	public abstract Object ChangeType(String value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: -1
	public abstract Object ChangeType(Object value, Type destinationType) { }

	// RVA: -1
	public abstract Object ChangeType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AB6924
	protected Void .ctor() { }

}

// Namespace: System.Xml.Schema
internal abstract class XmlBaseConverter
{
	// Fields
	private XmlSchemaType schemaType; // 0x10
	private XmlTypeCode typeCode; // 0x18
	private Type clrTypeDefault; // 0x20
	protected static readonly Type ICollectionType; // 0x0
	protected static readonly Type IEnumerableType; // 0x8
	protected static readonly Type IListType; // 0x10
	protected static readonly Type ObjectArrayType; // 0x18
	protected static readonly Type StringArrayType; // 0x20
	protected static readonly Type XmlAtomicValueArrayType; // 0x28
	protected static readonly Type DecimalType; // 0x30
	protected static readonly Type Int32Type; // 0x38
	protected static readonly Type Int64Type; // 0x40
	protected static readonly Type StringType; // 0x48
	protected static readonly Type XmlAtomicValueType; // 0x50
	protected static readonly Type ObjectType; // 0x58
	protected static readonly Type ByteType; // 0x60
	protected static readonly Type Int16Type; // 0x68
	protected static readonly Type SByteType; // 0x70
	protected static readonly Type UInt16Type; // 0x78
	protected static readonly Type UInt32Type; // 0x80
	protected static readonly Type UInt64Type; // 0x88
	protected static readonly Type XPathItemType; // 0x90
	protected static readonly Type DoubleType; // 0x98
	protected static readonly Type SingleType; // 0xA0
	protected static readonly Type DateTimeType; // 0xA8
	protected static readonly Type DateTimeOffsetType; // 0xB0
	protected static readonly Type BooleanType; // 0xB8
	protected static readonly Type ByteArrayType; // 0xC0
	protected static readonly Type XmlQualifiedNameType; // 0xC8
	protected static readonly Type UriType; // 0xD0
	protected static readonly Type TimeSpanType; // 0xD8
	protected static readonly Type XPathNavigatorType; // 0xE0

	// Properties
	protected XmlSchemaType SchemaType { get; }
	protected XmlTypeCode TypeCode { get; }
	protected String XmlTypeName { get; }
	protected Type DefaultClrType { get; }

	// Methods

	// RVA: 0xFFFFFFFF75A9FE20
	protected Void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75A9BBB8
	protected Void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0xFFFFFFFF75A9FF3C
	protected Void .ctor(XmlBaseConverter converterAtomic) { }

	// RVA: 0xFFFFFFFF75A9FFD8
	protected Void .ctor(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	// RVA: 0xFFFFFFFF75AA005C
	public override Boolean ToBoolean(DateTime value) { }

	// RVA: 0xFFFFFFFF75AA0138
	public override Boolean ToBoolean(Double value) { }

	// RVA: 0xFFFFFFFF75AA021C
	public override Boolean ToBoolean(Int32 value) { }

	// RVA: 0xFFFFFFFF75AA02F8
	public override Boolean ToBoolean(Int64 value) { }

	// RVA: 0xFFFFFFFF75AA03D4
	public override Boolean ToBoolean(String value) { }

	// RVA: 0xFFFFFFFF75AA0490
	public override Boolean ToBoolean(Object value) { }

	// RVA: 0xFFFFFFFF75AA054C
	public override DateTime ToDateTime(Boolean value) { }

	// RVA: 0xFFFFFFFF75AA0628
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0xFFFFFFFF75AA0714
	public override DateTime ToDateTime(Double value) { }

	// RVA: 0xFFFFFFFF75AA07F8
	public override DateTime ToDateTime(Int32 value) { }

	// RVA: 0xFFFFFFFF75AA08D4
	public override DateTime ToDateTime(Int64 value) { }

	// RVA: 0xFFFFFFFF75AA09B0
	public override DateTime ToDateTime(String value) { }

	// RVA: 0xFFFFFFFF75AA0A6C
	public override DateTime ToDateTime(Object value) { }

	// RVA: 0xFFFFFFFF75AA0B28
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0xFFFFFFFF75AA0C14
	public override DateTimeOffset ToDateTimeOffset(String value) { }

	// RVA: 0xFFFFFFFF75AA0CE0
	public override DateTimeOffset ToDateTimeOffset(Object value) { }

	// RVA: 0xFFFFFFFF75AA0DAC
	public override Decimal ToDecimal(String value) { }

	// RVA: 0xFFFFFFFF75AA0E6C
	public override Decimal ToDecimal(Object value) { }

	// RVA: 0xFFFFFFFF75AA0F2C
	public override Double ToDouble(Boolean value) { }

	// RVA: 0xFFFFFFFF75AA1008
	public override Double ToDouble(DateTime value) { }

	// RVA: 0xFFFFFFFF75AA10E4
	public override Double ToDouble(Int32 value) { }

	// RVA: 0xFFFFFFFF75AA11C0
	public override Double ToDouble(Int64 value) { }

	// RVA: 0xFFFFFFFF75AA129C
	public override Double ToDouble(String value) { }

	// RVA: 0xFFFFFFFF75AA1358
	public override Double ToDouble(Object value) { }

	// RVA: 0xFFFFFFFF75AA1414
	public override Int32 ToInt32(Boolean value) { }

	// RVA: 0xFFFFFFFF75AA14F0
	public override Int32 ToInt32(DateTime value) { }

	// RVA: 0xFFFFFFFF75AA15CC
	public override Int32 ToInt32(Double value) { }

	// RVA: 0xFFFFFFFF75AA16B0
	public override Int32 ToInt32(Int64 value) { }

	// RVA: 0xFFFFFFFF75AA178C
	public override Int32 ToInt32(String value) { }

	// RVA: 0xFFFFFFFF75AA1848
	public override Int32 ToInt32(Object value) { }

	// RVA: 0xFFFFFFFF75AA1904
	public override Int64 ToInt64(Boolean value) { }

	// RVA: 0xFFFFFFFF75AA19E0
	public override Int64 ToInt64(DateTime value) { }

	// RVA: 0xFFFFFFFF75AA1ABC
	public override Int64 ToInt64(Double value) { }

	// RVA: 0xFFFFFFFF75AA1BA0
	public override Int64 ToInt64(Int32 value) { }

	// RVA: 0xFFFFFFFF75AA1C7C
	public override Int64 ToInt64(String value) { }

	// RVA: 0xFFFFFFFF75AA1D38
	public override Int64 ToInt64(Object value) { }

	// RVA: 0xFFFFFFFF75AA1DF4
	public override Single ToSingle(Double value) { }

	// RVA: 0xFFFFFFFF75AA1ED8
	public override Single ToSingle(String value) { }

	// RVA: 0xFFFFFFFF75AA1F94
	public override Single ToSingle(Object value) { }

	// RVA: 0xFFFFFFFF75AA2050
	public override String ToString(Boolean value) { }

	// RVA: 0xFFFFFFFF75AA2118
	public override String ToString(DateTime value) { }

	// RVA: 0xFFFFFFFF75AA21E0
	public override String ToString(DateTimeOffset value) { }

	// RVA: 0xFFFFFFFF75AA22B8
	public override String ToString(Decimal value) { }

	// RVA: 0xFFFFFFFF75AA2384
	public override String ToString(Double value) { }

	// RVA: 0xFFFFFFFF75AA2454
	public override String ToString(Int32 value) { }

	// RVA: 0xFFFFFFFF75AA251C
	public override String ToString(Int64 value) { }

	// RVA: 0xFFFFFFFF75AA25E4
	public override String ToString(Single value) { }

	// RVA: 0xFFFFFFFF75AA26B4
	public override String ToString(Object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AA2760
	public override String ToString(Object value) { }

	// RVA: 0xFFFFFFFF75AA2774
	public override Object ChangeType(Boolean value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AA27D0
	public override Object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AA282C
	public override Object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AA2888
	public override Object ChangeType(Double value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AA28E4
	public override Object ChangeType(Int32 value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AA2940
	public override Object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AA299C
	public override Object ChangeType(String value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AA29AC
	public override Object ChangeType(Object value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AA29C0
	protected XmlSchemaType get_SchemaType() { }

	// RVA: 0xFFFFFFFF75AA29C8
	protected XmlTypeCode get_TypeCode() { }

	// RVA: 0xFFFFFFFF75AA29D0
	protected String get_XmlTypeName() { }

	// RVA: 0xFFFFFFFF75AA2BB0
	protected Type get_DefaultClrType() { }

	// RVA: 0xFFFFFFFF75A9E938
	protected static Boolean IsDerivedFrom(Type derivedType, Type baseType) { }

	// RVA: 0xFFFFFFFF75A9EA8C
	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AA2AB8
	protected static String QNameToString(XmlQualifiedName name) { }

	// RVA: 0xFFFFFFFF75AA2BB8
	protected virtual Object ChangeListType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AA2C24
	protected static Byte[] StringToBase64Binary(String value) { }

	// RVA: 0xFFFFFFFF75AA2C90
	protected static DateTime StringToDate(String value) { }

	// RVA: 0xFFFFFFFF75AA2D14
	protected static DateTime StringToDateTime(String value) { }

	// RVA: 0xFFFFFFFF75AA2D98
	protected static TimeSpan StringToDayTimeDuration(String value) { }

	// RVA: 0xFFFFFFFF75AA2DF0
	protected static TimeSpan StringToDuration(String value) { }

	// RVA: 0xFFFFFFFF75AA2E48
	protected static DateTime StringToGDay(String value) { }

	// RVA: 0xFFFFFFFF75AA2ECC
	protected static DateTime StringToGMonth(String value) { }

	// RVA: 0xFFFFFFFF75AA2F50
	protected static DateTime StringToGMonthDay(String value) { }

	// RVA: 0xFFFFFFFF75AA2FD4
	protected static DateTime StringToGYear(String value) { }

	// RVA: 0xFFFFFFFF75AA3058
	protected static DateTime StringToGYearMonth(String value) { }

	// RVA: 0xFFFFFFFF75AA30DC
	protected static DateTimeOffset StringToDateOffset(String value) { }

	// RVA: 0xFFFFFFFF75AA3160
	protected static DateTimeOffset StringToDateTimeOffset(String value) { }

	// RVA: 0xFFFFFFFF75AA31E4
	protected static DateTimeOffset StringToGDayOffset(String value) { }

	// RVA: 0xFFFFFFFF75AA3268
	protected static DateTimeOffset StringToGMonthOffset(String value) { }

	// RVA: 0xFFFFFFFF75AA32EC
	protected static DateTimeOffset StringToGMonthDayOffset(String value) { }

	// RVA: 0xFFFFFFFF75AA3370
	protected static DateTimeOffset StringToGYearOffset(String value) { }

	// RVA: 0xFFFFFFFF75AA33F4
	protected static DateTimeOffset StringToGYearMonthOffset(String value) { }

	// RVA: 0xFFFFFFFF75AA3478
	protected static Byte[] StringToHexBinary(String value) { }

	// RVA: 0xFFFFFFFF75AA35A0
	protected static XmlQualifiedName StringToQName(String value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AA3804
	protected static DateTime StringToTime(String value) { }

	// RVA: 0xFFFFFFFF75AA3888
	protected static DateTimeOffset StringToTimeOffset(String value) { }

	// RVA: 0xFFFFFFFF75AA390C
	protected static TimeSpan StringToYearMonthDuration(String value) { }

	// RVA: 0xFFFFFFFF75AA3964
	protected static String AnyUriToString(Uri value) { }

	// RVA: 0xFFFFFFFF75AA397C
	protected static String Base64BinaryToString(Byte[] value) { }

	// RVA: 0xFFFFFFFF75AA39BC
	protected static String DateToString(DateTime value) { }

	// RVA: 0xFFFFFFFF75AA3A00
	protected static String DateTimeToString(DateTime value) { }

	// RVA: 0xFFFFFFFF75AA3A44
	protected static String DayTimeDurationToString(TimeSpan value) { }

	// RVA: 0xFFFFFFFF75AA3A9C
	protected static String DurationToString(TimeSpan value) { }

	// RVA: 0xFFFFFFFF75AA3AF4
	protected static String GDayToString(DateTime value) { }

	// RVA: 0xFFFFFFFF75AA3B38
	protected static String GMonthToString(DateTime value) { }

	// RVA: 0xFFFFFFFF75AA3B7C
	protected static String GMonthDayToString(DateTime value) { }

	// RVA: 0xFFFFFFFF75AA3BC0
	protected static String GYearToString(DateTime value) { }

	// RVA: 0xFFFFFFFF75AA3C04
	protected static String GYearMonthToString(DateTime value) { }

	// RVA: 0xFFFFFFFF75AA3C48
	protected static String DateOffsetToString(DateTimeOffset value) { }

	// RVA: 0xFFFFFFFF75AA3C90
	protected static String DateTimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0xFFFFFFFF75AA3CD8
	protected static String GDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0xFFFFFFFF75AA3D20
	protected static String GMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0xFFFFFFFF75AA3D68
	protected static String GMonthDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0xFFFFFFFF75AA3DB0
	protected static String GYearOffsetToString(DateTimeOffset value) { }

	// RVA: 0xFFFFFFFF75AA3DF8
	protected static String GYearMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0xFFFFFFFF75AA3E40
	protected static String QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AA3FFC
	protected static String TimeToString(DateTime value) { }

	// RVA: 0xFFFFFFFF75AA4040
	protected static String TimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0xFFFFFFFF75AA4088
	protected static String YearMonthDurationToString(TimeSpan value) { }

	// RVA: 0xFFFFFFFF75AA40E0
	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	// RVA: 0xFFFFFFFF75AA4108
	internal static Int32 DecimalToInt32(Decimal value) { }

	// RVA: 0xFFFFFFFF75AA428C
	protected static Int64 DecimalToInt64(Decimal value) { }

	// RVA: 0xFFFFFFFF75AA4410
	protected static UInt64 DecimalToUInt64(Decimal value) { }

	// RVA: 0xFFFFFFFF75AA4588
	protected static Byte Int32ToByte(Int32 value) { }

	// RVA: 0xFFFFFFFF75AA467C
	protected static Int16 Int32ToInt16(Int32 value) { }

	// RVA: 0xFFFFFFFF75AA4770
	protected static SByte Int32ToSByte(Int32 value) { }

	// RVA: 0xFFFFFFFF75AA4864
	protected static UInt16 Int32ToUInt16(Int32 value) { }

	// RVA: 0xFFFFFFFF75AA4958
	protected static Int32 Int64ToInt32(Int64 value) { }

	// RVA: 0xFFFFFFFF75AA4A4C
	protected static UInt32 Int64ToUInt32(Int64 value) { }

	// RVA: 0xFFFFFFFF75AA4B40
	protected static DateTime UntypedAtomicToDateTime(String value) { }

	// RVA: 0xFFFFFFFF75AA4BC4
	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(String value) { }

	// RVA: 0xFFFFFFFF75AA4C48
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlNumeric10Converter
{
	// Methods

	// RVA: 0xFFFFFFFF75AAAC8C
	protected Void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75AAACFC
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75AAAD54
	public override Decimal ToDecimal(String value) { }

	// RVA: 0xFFFFFFFF75AAAEC8
	public override Decimal ToDecimal(Object value) { }

	// RVA: 0xFFFFFFFF75AAB4E0
	public override Int32 ToInt32(Int64 value) { }

	// RVA: 0xFFFFFFFF75AAB540
	public override Int32 ToInt32(String value) { }

	// RVA: 0xFFFFFFFF75AAB694
	public override Int32 ToInt32(Object value) { }

	// RVA: 0xFFFFFFFF75AAB970
	public override Int64 ToInt64(Int32 value) { }

	// RVA: 0xFFFFFFFF75AAB978
	public override Int64 ToInt64(String value) { }

	// RVA: 0xFFFFFFFF75AABACC
	public override Int64 ToInt64(Object value) { }

	// RVA: 0xFFFFFFFF75AABD94
	public override String ToString(Decimal value) { }

	// RVA: 0xFFFFFFFF75AABE94
	public override String ToString(Int32 value) { }

	// RVA: 0xFFFFFFFF75AABF2C
	public override String ToString(Int64 value) { }

	// RVA: 0xFFFFFFFF75AABFC4
	public override String ToString(Object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AAC2E8
	public override Object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AAC840
	public override Object ChangeType(Int32 value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AACAF4
	public override Object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AACDB0
	public override Object ChangeType(String value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AAD070
	public override Object ChangeType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AAB1C0
	private Object ChangeTypeWildcardDestination(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AAC5A8
	private Object ChangeTypeWildcardSource(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlNumeric2Converter
{
	// Methods

	// RVA: 0xFFFFFFFF75AAD98C
	protected Void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75AAD9FC
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75AADA54
	public override Double ToDouble(String value) { }

	// RVA: 0xFFFFFFFF75AADD58
	public override Double ToDouble(Object value) { }

	// RVA: 0xFFFFFFFF75AADFD0
	public override Single ToSingle(Double value) { }

	// RVA: 0xFFFFFFFF75AADFD8
	public override Single ToSingle(String value) { }

	// RVA: 0xFFFFFFFF75AAE0AC
	public override Single ToSingle(Object value) { }

	// RVA: 0xFFFFFFFF75AAE328
	public override String ToString(Double value) { }

	// RVA: 0xFFFFFFFF75AAE5F4
	public override String ToString(Single value) { }

	// RVA: 0xFFFFFFFF75AAE65C
	public override String ToString(Object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AAE8D8
	public override Object ChangeType(Double value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AAEB3C
	public override Object ChangeType(String value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AAEDC8
	public override Object ChangeType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlDateTimeConverter
{
	// Methods

	// RVA: 0xFFFFFFFF75AA6248
	protected Void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75AA62B8
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75AA6310
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0xFFFFFFFF75AA6380
	public override DateTime ToDateTime(String value) { }

	// RVA: 0xFFFFFFFF75AA65C0
	public override DateTime ToDateTime(Object value) { }

	// RVA: 0xFFFFFFFF75AA6860
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0xFFFFFFFF75AA688C
	public override DateTimeOffset ToDateTimeOffset(String value) { }

	// RVA: 0xFFFFFFFF75AA6ACC
	public override DateTimeOffset ToDateTimeOffset(Object value) { }

	// RVA: 0xFFFFFFFF75AA6D78
	public override String ToString(DateTime value) { }

	// RVA: 0xFFFFFFFF75AA6F78
	public override String ToString(DateTimeOffset value) { }

	// RVA: 0xFFFFFFFF75AA719C
	public override String ToString(Object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AA7424
	public override Object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AA769C
	public override Object ChangeType(String value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AA7930
	public override Object ChangeType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlBooleanConverter
{
	// Methods

	// RVA: 0xFFFFFFFF75AA5284
	protected Void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75AA52F4
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75AA534C
	public override Boolean ToBoolean(String value) { }

	// RVA: 0xFFFFFFFF75AA552C
	public override Boolean ToBoolean(Object value) { }

	// RVA: 0xFFFFFFFF75AA576C
	public override String ToString(Boolean value) { }

	// RVA: 0xFFFFFFFF75AA57E0
	public override String ToString(Object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AA5A0C
	public override Object ChangeType(Boolean value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AA5C48
	public override Object ChangeType(String value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AA5E9C
	public override Object ChangeType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlMiscConverter
{
	// Methods

	// RVA: 0xFFFFFFFF75AA9670
	protected Void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75AA96E0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75AA9738
	public override String ToString(Object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AA9CD0
	public override Object ChangeType(String value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AAA304
	public override Object ChangeType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AA9B9C
	private Object ChangeTypeWildcardDestination(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AAA1B8
	private Object ChangeTypeWildcardSource(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlStringConverter
{
	// Methods

	// RVA: 0xFFFFFFFF75AB1AB8
	protected Void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75AB1B28
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75AB1B80
	public override String ToString(Object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AB1D2C
	public override Object ChangeType(String value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AB1F18
	public override Object ChangeType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlUntypedConverter
{
	// Fields
	private Boolean allowListToList; // 0x30
	public static readonly XmlValueConverter Untyped; // 0x0
	public static readonly XmlValueConverter UntypedList; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75AB21DC
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF75AB2284
	protected Void .ctor(XmlUntypedConverter atomicConverter, Boolean allowListToList) { }

	// RVA: 0xFFFFFFFF75AB2338
	public override Boolean ToBoolean(String value) { }

	// RVA: 0xFFFFFFFF75AB23C8
	public override Boolean ToBoolean(Object value) { }

	// RVA: 0xFFFFFFFF75AB2688
	public override DateTime ToDateTime(String value) { }

	// RVA: 0xFFFFFFFF75AB2728
	public override DateTime ToDateTime(Object value) { }

	// RVA: 0xFFFFFFFF75AB289C
	public override DateTimeOffset ToDateTimeOffset(String value) { }

	// RVA: 0xFFFFFFFF75AB293C
	public override DateTimeOffset ToDateTimeOffset(Object value) { }

	// RVA: 0xFFFFFFFF75AB2AB8
	public override Decimal ToDecimal(String value) { }

	// RVA: 0xFFFFFFFF75AB2B48
	public override Decimal ToDecimal(Object value) { }

	// RVA: 0xFFFFFFFF75AB2CD0
	public override Double ToDouble(String value) { }

	// RVA: 0xFFFFFFFF75AB2D60
	public override Double ToDouble(Object value) { }

	// RVA: 0xFFFFFFFF75AB2EEC
	public override Int32 ToInt32(String value) { }

	// RVA: 0xFFFFFFFF75AB2F90
	public override Int32 ToInt32(Object value) { }

	// RVA: 0xFFFFFFFF75AB3134
	public override Int64 ToInt64(String value) { }

	// RVA: 0xFFFFFFFF75AB31D8
	public override Int64 ToInt64(Object value) { }

	// RVA: 0xFFFFFFFF75AB337C
	public override Single ToSingle(String value) { }

	// RVA: 0xFFFFFFFF75AB340C
	public override Single ToSingle(Object value) { }

	// RVA: 0xFFFFFFFF75AB3598
	public override String ToString(Boolean value) { }

	// RVA: 0xFFFFFFFF75AB35EC
	public override String ToString(DateTime value) { }

	// RVA: 0xFFFFFFFF75AB364C
	public override String ToString(DateTimeOffset value) { }

	// RVA: 0xFFFFFFFF75AB36BC
	public override String ToString(Decimal value) { }

	// RVA: 0xFFFFFFFF75AB3720
	public override String ToString(Double value) { }

	// RVA: 0xFFFFFFFF75AB375C
	public override String ToString(Int32 value) { }

	// RVA: 0xFFFFFFFF75AB37BC
	public override String ToString(Int64 value) { }

	// RVA: 0xFFFFFFFF75AB381C
	public override String ToString(Single value) { }

	// RVA: 0xFFFFFFFF75AB3858
	public override String ToString(Object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AB43D8
	public override Object ChangeType(Boolean value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AB46B0
	public override Object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AB4818
	public override Object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AB49B0
	public override Object ChangeType(Double value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AB4B3C
	public override Object ChangeType(Int32 value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AB4CC8
	public override Object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75AB4E54
	public override Object ChangeType(String value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AB5648
	public override Object ChangeType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AB2554
	private Object ChangeTypeWildcardDestination(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AB4560
	private Object ChangeTypeWildcardSource(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AB6350
	protected override Object ChangeListType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AB65C4
	private Boolean SupportsType(Type clrType) { }

	// RVA: 0xFFFFFFFF75AB6848
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlAnyConverter
{
	// Fields
	public static readonly XmlValueConverter Item; // 0x0
	public static readonly XmlValueConverter AnyAtomic; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75A9BB4C
	protected Void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0xFFFFFFFF75A9BCC4
	public override Boolean ToBoolean(Object value) { }

	// RVA: 0xFFFFFFFF75A9BF80
	public override DateTime ToDateTime(Object value) { }

	// RVA: 0xFFFFFFFF75A9C108
	public override DateTimeOffset ToDateTimeOffset(Object value) { }

	// RVA: 0xFFFFFFFF75A9C2A0
	public override Decimal ToDecimal(Object value) { }

	// RVA: 0xFFFFFFFF75A9C42C
	public override Double ToDouble(Object value) { }

	// RVA: 0xFFFFFFFF75A9C5B4
	public override Int32 ToInt32(Object value) { }

	// RVA: 0xFFFFFFFF75A9C73C
	public override Int64 ToInt64(Object value) { }

	// RVA: 0xFFFFFFFF75A9C8C4
	public override Single ToSingle(Object value) { }

	// RVA: 0xFFFFFFFF75A9CA50
	public override Object ChangeType(Boolean value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75A9CDEC
	public override Object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75A9D03C
	public override Object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75A9D2E4
	public override Object ChangeType(Double value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75A9D544
	public override Object ChangeType(Int32 value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75A9D794
	public override Object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0xFFFFFFFF75A9D9E4
	public override Object ChangeType(String value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75A9DC80
	public override Object ChangeType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75A9BE4C
	private Object ChangeTypeWildcardDestination(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75A9CCA0
	private Object ChangeTypeWildcardSource(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75A9E9E8
	private XPathNavigator ToNavigator(XPathNavigator nav) { }

	// RVA: 0xFFFFFFFF75A9EC68
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlAnyListConverter
{
	// Fields
	public static readonly XmlValueConverter ItemList; // 0x0
	public static readonly XmlValueConverter AnyAtomicList; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF75A9ED1C
	protected Void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0xFFFFFFFF75A9ED24
	public override Object ChangeType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75A9EEE8
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlListConverter
{
	// Fields
	protected XmlValueConverter atomicConverter; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF75AA7DC8
	protected Void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0xFFFFFFFF75AA7E5C
	protected Void .ctor(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

	// RVA: 0xFFFFFFFF75AA7EF8
	protected Void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0xFFFFFFFF75AA7F68
	public static XmlValueConverter Create(XmlValueConverter atomicConverter) { }

	// RVA: 0xFFFFFFFF75AA80F4
	public override Object ChangeType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AA81F4
	protected override Object ChangeListType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AA8B00
	private Boolean IsListType(Type type) { }

	// RVA: -1
	private T[] ToArray(Object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AA912C
	private IList ToList(Object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AA90C4
	private List<T0> StringAsList(String value) { }

	// RVA: 0xFFFFFFFF75AA8DF8
	private String ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xFFFFFFFF75AA8C14
	private Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

}

// Namespace: System.Xml.Schema
internal enum XsdDateTimeFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const XsdDateTimeFlags DateTime = 1;
	public const XsdDateTimeFlags Time = 2;
	public const XsdDateTimeFlags Date = 4;
	public const XsdDateTimeFlags GYearMonth = 8;
	public const XsdDateTimeFlags GYear = 16;
	public const XsdDateTimeFlags GMonthDay = 32;
	public const XsdDateTimeFlags GDay = 64;
	public const XsdDateTimeFlags GMonth = 128;
	public const XsdDateTimeFlags XdrDateTimeNoTz = 256;
	public const XsdDateTimeFlags XdrDateTime = 512;
	public const XsdDateTimeFlags XdrTimeNoTz = 1024;
	public const XsdDateTimeFlags AllXsd = 255;
}

// Namespace: System.Xml.Schema
internal struct XsdDateTime
{
	// Fields
	private DateTime dt; // 0x10
	private UInt32 extra; // 0x18
	private static readonly Int32 Lzyyyy; // 0x0
	private static readonly Int32 Lzyyyy_; // 0x4
	private static readonly Int32 Lzyyyy_MM; // 0x8
	private static readonly Int32 Lzyyyy_MM_; // 0xC
	private static readonly Int32 Lzyyyy_MM_dd; // 0x10
	private static readonly Int32 Lzyyyy_MM_ddT; // 0x14
	private static readonly Int32 LzHH; // 0x18
	private static readonly Int32 LzHH_; // 0x1C
	private static readonly Int32 LzHH_mm; // 0x20
	private static readonly Int32 LzHH_mm_; // 0x24
	private static readonly Int32 LzHH_mm_ss; // 0x28
	private static readonly Int32 Lz_; // 0x2C
	private static readonly Int32 Lz_zz; // 0x30
	private static readonly Int32 Lz_zz_; // 0x34
	private static readonly Int32 Lz_zz_zz; // 0x38
	private static readonly Int32 Lz__; // 0x3C
	private static readonly Int32 Lz__mm; // 0x40
	private static readonly Int32 Lz__mm_; // 0x44
	private static readonly Int32 Lz__mm__; // 0x48
	private static readonly Int32 Lz__mm_dd; // 0x4C
	private static readonly Int32 Lz___; // 0x50
	private static readonly Int32 Lz___dd; // 0x54
	private static readonly XmlTypeCode[] typeCodes; // 0x58

	// Properties
	private DateTimeTypeCode InternalTypeCode { get; }
	private XsdDateTimeKind InternalKind { get; }
	public Int32 Year { get; }
	public Int32 Month { get; }
	public Int32 Day { get; }
	public Int32 Hour { get; }
	public Int32 Minute { get; }
	public Int32 Second { get; }
	public Int32 Fraction { get; }
	public Int32 ZoneHour { get; }
	public Int32 ZoneMinute { get; }

	// Methods

	// RVA: 0xFFFFFFFF71145468
	public Void .ctor(String text, XsdDateTimeFlags kinds) { }

	// RVA: 0xFFFFFFFF71145470
	private Void .ctor(Parser parser) { }

	// RVA: 0xFFFFFFFF711454A4
	private Void InitiateXsdDateTime(Parser parser) { }

	// RVA: 0xFFFFFFFF75AB73D8
	internal static Boolean TryParse(String text, XsdDateTimeFlags kinds, out XsdDateTime result) { }

	// RVA: 0xFFFFFFFF711454D8
	public Void .ctor(DateTime dateTime, XsdDateTimeFlags kinds) { }

	// RVA: 0xFFFFFFFF711454E0
	public Void .ctor(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	// RVA: 0xFFFFFFFF711454E8
	private DateTimeTypeCode get_InternalTypeCode() { }

	// RVA: 0xFFFFFFFF711454F0
	private XsdDateTimeKind get_InternalKind() { }

	// RVA: 0xFFFFFFFF711454F8
	public Int32 get_Year() { }

	// RVA: 0xFFFFFFFF71145504
	public Int32 get_Month() { }

	// RVA: 0xFFFFFFFF71145510
	public Int32 get_Day() { }

	// RVA: 0xFFFFFFFF7114551C
	public Int32 get_Hour() { }

	// RVA: 0xFFFFFFFF71145528
	public Int32 get_Minute() { }

	// RVA: 0xFFFFFFFF71145534
	public Int32 get_Second() { }

	// RVA: 0xFFFFFFFF71145540
	public Int32 get_Fraction() { }

	// RVA: 0xFFFFFFFF71145548
	public Int32 get_ZoneHour() { }

	// RVA: 0xFFFFFFFF71145550
	public Int32 get_ZoneMinute() { }

	// RVA: 0xFFFFFFFF75AB77D8
	public static DateTime op_Implicit(XsdDateTime xdt) { }

	// RVA: 0xFFFFFFFF75AB7BA0
	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	// RVA: 0xFFFFFFFF71145558
	public override String ToString() { }

	// RVA: 0xFFFFFFFF71145560
	private Void PrintDate(StringBuilder sb) { }

	// RVA: 0xFFFFFFFF71145568
	private Void PrintTime(StringBuilder sb) { }

	// RVA: 0xFFFFFFFF71145570
	private Void PrintZone(StringBuilder sb) { }

	// RVA: 0xFFFFFFFF71145578
	private Void IntToCharArray(Char[] text, Int32 start, Int32 value, Int32 digits) { }

	// RVA: 0xFFFFFFFF7114557C
	private Void ShortToCharArray(Char[] text, Int32 start, Int32 value) { }

	// RVA: 0xFFFFFFFF75AB87B4
	private static Void .cctor() { }

}

// Namespace: 
private enum DateTimeTypeCode
{
	// Fields
	public Int32 value__; // 0x10
	public const DateTimeTypeCode DateTime = 0;
	public const DateTimeTypeCode Time = 1;
	public const DateTimeTypeCode Date = 2;
	public const DateTimeTypeCode GYearMonth = 3;
	public const DateTimeTypeCode GYear = 4;
	public const DateTimeTypeCode GMonthDay = 5;
	public const DateTimeTypeCode GDay = 6;
	public const DateTimeTypeCode GMonth = 7;
	public const DateTimeTypeCode XdrDateTime = 8;
}

// Namespace: 
private enum XsdDateTimeKind
{
	// Fields
	public Int32 value__; // 0x10
	public const XsdDateTimeKind Unspecified = 0;
	public const XsdDateTimeKind Zulu = 1;
	public const XsdDateTimeKind LocalWestOfZulu = 2;
	public const XsdDateTimeKind LocalEastOfZulu = 3;
}

// Namespace: 
private struct Parser
{
	// Fields
	public DateTimeTypeCode typeCode; // 0x10
	public Int32 year; // 0x14
	public Int32 month; // 0x18
	public Int32 day; // 0x1C
	public Int32 hour; // 0x20
	public Int32 minute; // 0x24
	public Int32 second; // 0x28
	public Int32 fraction; // 0x2C
	public XsdDateTimeKind kind; // 0x30
	public Int32 zoneHour; // 0x34
	public Int32 zoneMinute; // 0x38
	private String text; // 0x40
	private Int32 length; // 0x48
	private static Int32[] Power10; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF71145670
	public Boolean Parse(String text, XsdDateTimeFlags kinds) { }

	// RVA: 0xFFFFFFFF71145678
	private Boolean ParseDate(Int32 start) { }

	// RVA: 0xFFFFFFFF71145680
	private Boolean ParseTimeAndZoneAndWhitespace(Int32 start) { }

	// RVA: 0xFFFFFFFF711456D4
	private Boolean ParseTimeAndWhitespace(Int32 start) { }

	// RVA: 0xFFFFFFFF7114571C
	private Boolean ParseTime(ref Int32 start) { }

	// RVA: 0xFFFFFFFF71145724
	private Boolean ParseZoneAndWhitespace(Int32 start) { }

	// RVA: 0xFFFFFFFF7114572C
	private Boolean Parse4Dig(Int32 start, ref Int32 num) { }

	// RVA: 0xFFFFFFFF71145734
	private Boolean Parse2Dig(Int32 start, ref Int32 num) { }

	// RVA: 0xFFFFFFFF7114573C
	private Boolean ParseChar(Int32 start, Char ch) { }

	// RVA: 0xFFFFFFFF75AB8AD4
	private static Boolean Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

	// RVA: 0xFFFFFFFF75AB93F0
	private static Void .cctor() { }

}

// Namespace: System.Xml.Schema
internal struct XsdDuration
{
	// Fields
	private Int32 years; // 0x10
	private Int32 months; // 0x14
	private Int32 days; // 0x18
	private Int32 hours; // 0x1C
	private Int32 minutes; // 0x20
	private Int32 seconds; // 0x24
	private UInt32 nanoseconds; // 0x28

	// Properties
	public Boolean IsNegative { get; }
	public Int32 Years { get; }
	public Int32 Months { get; }
	public Int32 Days { get; }
	public Int32 Hours { get; }
	public Int32 Minutes { get; }
	public Int32 Seconds { get; }
	public Int32 Nanoseconds { get; }

	// Methods

	// RVA: 0xFFFFFFFF71145788
	public Void .ctor(Boolean isNegative, Int32 years, Int32 months, Int32 days, Int32 hours, Int32 minutes, Int32 seconds, Int32 nanoseconds) { }

	// RVA: 0xFFFFFFFF71145798
	public Void .ctor(TimeSpan timeSpan, DurationType durationType) { }

	// RVA: 0xFFFFFFFF711457A0
	public Void .ctor(String s, DurationType durationType) { }

	// RVA: 0xFFFFFFFF711457A8
	public Boolean get_IsNegative() { }

	// RVA: 0xFFFFFFFF711457B4
	public Int32 get_Years() { }

	// RVA: 0xFFFFFFFF711457BC
	public Int32 get_Months() { }

	// RVA: 0xFFFFFFFF711457C4
	public Int32 get_Days() { }

	// RVA: 0xFFFFFFFF711457CC
	public Int32 get_Hours() { }

	// RVA: 0xFFFFFFFF711457D4
	public Int32 get_Minutes() { }

	// RVA: 0xFFFFFFFF711457DC
	public Int32 get_Seconds() { }

	// RVA: 0xFFFFFFFF711457E4
	public Int32 get_Nanoseconds() { }

	// RVA: 0xFFFFFFFF711457F0
	public TimeSpan ToTimeSpan(DurationType durationType) { }

	// RVA: 0xFFFFFFFF711457F8
	internal Exception TryToTimeSpan(out TimeSpan result) { }

	// RVA: 0xFFFFFFFF71145808
	internal Exception TryToTimeSpan(DurationType durationType, out TimeSpan result) { }

	// RVA: 0xFFFFFFFF71145810
	public override String ToString() { }

	// RVA: 0xFFFFFFFF7114581C
	internal String ToString(DurationType durationType) { }

	// RVA: 0xFFFFFFFF75ABA8F8
	internal static Exception TryParse(String s, out XsdDuration result) { }

	// RVA: 0xFFFFFFFF75AB9880
	internal static Exception TryParse(String s, DurationType durationType, out XsdDuration result) { }

	// RVA: 0xFFFFFFFF75ABA904
	private static String TryParseDigits(String s, ref Int32 offset, Boolean eatDigits, out Int32 result, out Int32 numDigits) { }

}

// Namespace: 
private enum Parts
{
	// Fields
	public Int32 value__; // 0x10
	public const Parts HasNone = 0;
	public const Parts HasYears = 1;
	public const Parts HasMonths = 2;
	public const Parts HasDays = 4;
	public const Parts HasHours = 8;
	public const Parts HasMinutes = 16;
	public const Parts HasSeconds = 32;
}

// Namespace: 
public enum DurationType
{
	// Fields
	public Int32 value__; // 0x10
	public const DurationType Duration = 0;
	public const DurationType YearMonthDuration = 1;
	public const DurationType DayTimeDuration = 2;
}

// Namespace: System.Xml.XmlConfiguration
public sealed class XmlReaderSection
{
	// Properties
	internal static Boolean ProhibitDefaultUrlResolver { get; }
	internal static Boolean CollapseWhiteSpaceIntoEmptyString { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AC4594
	internal static Boolean get_ProhibitDefaultUrlResolver() { }

	// RVA: 0xFFFFFFFF75AC43DC
	internal static Boolean get_CollapseWhiteSpaceIntoEmptyString() { }

}

// Namespace: System.Xml.Xsl
public interface IXsltContextFunction
{
	// Properties
	public abstract XPathResultType ReturnType { get; }

	// Methods

	// RVA: -1
	public abstract XPathResultType get_ReturnType() { }

	// RVA: -1
	public abstract Object Invoke(XsltContext xsltContext, Object[] args, XPathNavigator docContext) { }

}

// Namespace: System.Xml.Xsl
public interface IXsltContextVariable
{
	// Properties
	public abstract XPathResultType VariableType { get; }

	// Methods

	// RVA: -1
	public abstract XPathResultType get_VariableType() { }

	// RVA: -1
	public abstract Object Evaluate(XsltContext xsltContext) { }

}

// Namespace: System.Xml.Xsl
public abstract class XsltContext
{
	// Properties
	public abstract Boolean Whitespace { get; }

	// Methods

	// RVA: 0xFFFFFFFF75AEFC6C
	internal Void .ctor(Boolean dummy) { }

	// RVA: -1
	public abstract IXsltContextVariable ResolveVariable(String prefix, String name) { }

	// RVA: -1
	public abstract IXsltContextFunction ResolveFunction(String prefix, String name, XPathResultType[] ArgTypes) { }

	// RVA: -1
	public abstract Boolean get_Whitespace() { }

	// RVA: -1
	public abstract Boolean PreserveWhitespace(XPathNavigator node) { }

}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=112 49C5BA13401986EC93E4677F52CBE2248184DFBD; // 0x0
	internal static readonly __StaticArrayInitTypeSize=12 5BE9DB9EEB9CBB4D22472CA9734B1FA1D36126BD; // 0x70
	internal static readonly __StaticArrayInitTypeSize=6 5D100A87B697F3AE2015A5D3B2A7B5419E1BCA98; // 0x7C
	internal static readonly __StaticArrayInitTypeSize=416 6A0D50D692745A6663128CD315B71079584F3E59; // 0x82
	internal static readonly __StaticArrayInitTypeSize=32 7A32E1A19C182315E4263A65A72066492550D8CD; // 0x222
	internal static readonly __StaticArrayInitTypeSize=28 9E31F24F64765FCAA589F589324D17C9FCF6A06D; // 0x242
	internal static readonly __StaticArrayInitTypeSize=416 B368804F0C6DAB083B253A6B106D0783D5C32E90; // 0x25E
	internal static readonly __StaticArrayInitTypeSize=40 B9F0004E3873FDDCABFDA6174EA18F0859B637B4; // 0x3FE
	internal static readonly __StaticArrayInitTypeSize=20 BAD037B714E1CD1052149B51238A3D4351DD10B5; // 0x426
	internal static readonly Int64 EBC658B067B5C785A3F0BB67D73755F6FEE7F70C; // 0x440
	internal static readonly __StaticArrayInitTypeSize=36 ED18A4A1FF7C89B400D7CA156BA8D11BB09E1DE4; // 0x448
	internal static readonly __StaticArrayInitTypeSize=64 EE3413A2C088FF9432054D6E60A7CB6A498D25F0; // 0x46C
}

// Namespace: 
private struct __StaticArrayInitTypeSize=6
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=12
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=20
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=28
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=32
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=36
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=40
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=64
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=112
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=416
{}


