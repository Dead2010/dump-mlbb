// Namespace: 
internal class <Module>
{}

// Namespace: Pathfinding.Poly2Tri
public static class P2T
{
	// Fields
	private static TriangulationAlgorithm _defaultAlgorithm; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF72365FA8
	public static Void Triangulate(Polygon p) { }

	// RVA: 0xFFFFFFFF723660BC
	public static TriangulationContext CreateContext(TriangulationAlgorithm algorithm) { }

	// RVA: 0xFFFFFFFF72366044
	public static Void Triangulate(TriangulationAlgorithm algorithm, Triangulatable t) { }

	// RVA: 0xFFFFFFFF72366110
	public static Void Triangulate(TriangulationContext tcx) { }

}

// Namespace: Pathfinding.Poly2Tri
public class Polygon
{
	// Fields
	protected List<T0> _points; // 0x10
	protected List<T0> _steinerPoints; // 0x18
	protected List<T0> _holes; // 0x20
	protected List<T0> _triangles; // 0x28
	protected PolygonPoint _last; // 0x30

	// Properties
	public TriangulationMode TriangulationMode { get; }
	public IList<T0> Points { get; }
	public IList<T0> Triangles { get; }
	public IList<T0> Holes { get; }

	// Methods

	// RVA: 0xFFFFFFFF723661DC
	public Void .ctor(IList<T0> points) { }

	// RVA: 0xFFFFFFFF72366740
	public TriangulationMode get_TriangulationMode() { }

	// RVA: 0xFFFFFFFF759F3064
	public Void ClearSteinerPoints() { }

	// RVA: 0xFFFFFFFF759F30BC
	public Void AddHole(Polygon poly) { }

	// RVA: 0xFFFFFFFF759F3170
	public Void AddPoints(IEnumerable<T0> list) { }

	// RVA: 0xFFFFFFFF759F354C
	public Void RemovePoint(PolygonPoint p) { }

	// RVA: 0xFFFFFFFF759F35FC
	public IList<T0> get_Points() { }

	// RVA: 0xFFFFFFFF759F3604
	public IList<T0> get_Triangles() { }

	// RVA: 0xFFFFFFFF759F360C
	public IList<T0> get_Holes() { }

	// RVA: 0xFFFFFFFF72366748
	public Void AddTriangle(DelaunayTriangle t) { }

	// RVA: 0xFFFFFFFF759F3614
	public Void AddTriangles(IEnumerable<T0> list) { }

	// RVA: 0xFFFFFFFF759F3674
	public Void ClearTriangles() { }

	// RVA: 0xFFFFFFFF72366838
	public Void Prepare(TriangulationContext tcx) { }

}

// Namespace: Pathfinding.Poly2Tri
public class PolygonPoint
{
	// Fields
	private PolygonPoint <Next>k__BackingField; // 0x28
	private PolygonPoint <Previous>k__BackingField; // 0x30

	// Properties
	public PolygonPoint Next { get; set; }
	public PolygonPoint Previous { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF72366C58
	public Void .ctor(Double x, Double y) { }

	// RVA: 0xFFFFFFFF759F36CC
	public PolygonPoint get_Next() { }

	// RVA: 0xFFFFFFFF759F36D4
	public Void set_Next(PolygonPoint value) { }

	// RVA: 0xFFFFFFFF759F370C
	public PolygonPoint get_Previous() { }

	// RVA: 0xFFFFFFFF759F3714
	public Void set_Previous(PolygonPoint value) { }

}

// Namespace: Pathfinding.Poly2Tri
public class DelaunayTriangle
{
	// Fields
	public FixedArray3<T0> Points; // 0x10
	public FixedArray3<T0> Neighbors; // 0x28
	public FixedBitArray3 EdgeIsConstrained; // 0x40
	public FixedBitArray3 EdgeIsDelaunay; // 0x43
	private Boolean <IsInterior>k__BackingField; // 0x46

	// Properties
	public Boolean IsInterior { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF72361BD8
	public Void .ctor(TriangulationPoint p1, TriangulationPoint p2, TriangulationPoint p3) { }

	// RVA: 0xFFFFFFFF759F2BF8
	public Boolean get_IsInterior() { }

	// RVA: 0xFFFFFFFF759F2C00
	public Void set_IsInterior(Boolean value) { }

	// RVA: 0xFFFFFFFF72364D4C
	public Int32 IndexOf(TriangulationPoint p) { }

	// RVA: 0xFFFFFFFF759F2C08
	public Int32 IndexCCWFrom(TriangulationPoint p) { }

	// RVA: 0xFFFFFFFF759F1AD4
	public Boolean Contains(TriangulationPoint p) { }

	// RVA: 0xFFFFFFFF72365C40
	private Void MarkNeighbor(TriangulationPoint p1, TriangulationPoint p2, DelaunayTriangle t) { }

	// RVA: 0xFFFFFFFF72361C74
	public Void MarkNeighbor(DelaunayTriangle t) { }

	// RVA: 0xFFFFFFFF7235FDA0
	public TriangulationPoint OppositePoint(DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0xFFFFFFFF723612B4
	public DelaunayTriangle NeighborCWFrom(TriangulationPoint point) { }

	// RVA: 0xFFFFFFFF7236118C
	public DelaunayTriangle NeighborCCWFrom(TriangulationPoint point) { }

	// RVA: 0xFFFFFFFF7235FD20
	public DelaunayTriangle NeighborAcrossFrom(TriangulationPoint point) { }

	// RVA: 0xFFFFFFFF72361100
	public TriangulationPoint PointCCWFrom(TriangulationPoint point) { }

	// RVA: 0xFFFFFFFF7236122C
	public TriangulationPoint PointCWFrom(TriangulationPoint point) { }

	// RVA: 0xFFFFFFFF72365E24
	private Void RotateCW() { }

	// RVA: 0xFFFFFFFF72364EC8
	public Void Legalize(TriangulationPoint oPoint, TriangulationPoint nPoint) { }

	// RVA: 0xFFFFFFFF759F2C40
	public override String ToString() { }

	// RVA: 0xFFFFFFFF759F1FF4
	public Void MarkConstrainedEdge(Int32 index) { }

	// RVA: 0xFFFFFFFF759F2000
	public Void MarkConstrainedEdge(TriangulationPoint p, TriangulationPoint q) { }

	// RVA: 0xFFFFFFFF72363FB8
	public Int32 EdgeIndex(TriangulationPoint p1, TriangulationPoint p2) { }

	// RVA: 0xFFFFFFFF759F2888
	public Boolean GetConstrainedEdgeCCW(TriangulationPoint p) { }

	// RVA: 0xFFFFFFFF759F1CD4
	public Boolean GetConstrainedEdgeCW(TriangulationPoint p) { }

	// RVA: 0xFFFFFFFF759F2A00
	public Void SetConstrainedEdgeCCW(TriangulationPoint p, Boolean ce) { }

	// RVA: 0xFFFFFFFF759F2A50
	public Void SetConstrainedEdgeCW(TriangulationPoint p, Boolean ce) { }

	// RVA: 0xFFFFFFFF759F28D0
	public Boolean GetDelaunayEdgeCCW(TriangulationPoint p) { }

	// RVA: 0xFFFFFFFF759F2918
	public Boolean GetDelaunayEdgeCW(TriangulationPoint p) { }

	// RVA: 0xFFFFFFFF759F2960
	public Void SetDelaunayEdgeCCW(TriangulationPoint p, Boolean ce) { }

	// RVA: 0xFFFFFFFF759F29B0
	public Void SetDelaunayEdgeCW(TriangulationPoint p, Boolean ce) { }

}

// Namespace: Pathfinding.Poly2Tri
public class AdvancingFront
{
	// Fields
	public AdvancingFrontNode Head; // 0x10
	public AdvancingFrontNode Tail; // 0x18
	protected AdvancingFrontNode Search; // 0x20

	// Methods

	// RVA: 0xFFFFFFFF7235EEB4
	public Void .ctor(AdvancingFrontNode head, AdvancingFrontNode tail) { }

	// RVA: 0xFFFFFFFF759F1458
	public Void AddNode(AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF759F145C
	public Void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF759F1460
	public override String ToString() { }

	// RVA: 0xFFFFFFFF759F1518
	private AdvancingFrontNode FindSearchNode(Double x) { }

	// RVA: 0xFFFFFFFF759F1520
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0xFFFFFFFF7235EF38
	private AdvancingFrontNode LocateNode(Double x) { }

	// RVA: 0xFFFFFFFF7235EFD0
	public AdvancingFrontNode LocatePoint(TriangulationPoint point) { }

}

// Namespace: Pathfinding.Poly2Tri
public class AdvancingFrontNode
{
	// Fields
	public AdvancingFrontNode Next; // 0x10
	public AdvancingFrontNode Prev; // 0x18
	public Double Value; // 0x20
	public TriangulationPoint Point; // 0x28
	public DelaunayTriangle Triangle; // 0x30

	// Properties
	public Boolean HasNext { get; }
	public Boolean HasPrev { get; }

	// Methods

	// RVA: 0xFFFFFFFF7235F108
	public Void .ctor(TriangulationPoint point) { }

	// RVA: 0xFFFFFFFF759F153C
	public Boolean get_HasNext() { }

	// RVA: 0xFFFFFFFF759F154C
	public Boolean get_HasPrev() { }

}

// Namespace: Pathfinding.Poly2Tri
public static class DTSweep
{
	// Methods

	// RVA: 0xFFFFFFFF7235F15C
	public static Void Triangulate(DTSweepContext tcx) { }

	// RVA: 0xFFFFFFFF7235F674
	private static Void Sweep(DTSweepContext tcx) { }

	// RVA: 0xFFFFFFFF759F155C
	private static Void FinalizationConvexHull(DTSweepContext tcx) { }

	// RVA: 0xFFFFFFFF759F1978
	private static Void TurnAdvancingFrontConvex(DTSweepContext tcx, AdvancingFrontNode b, AdvancingFrontNode c) { }

	// RVA: 0xFFFFFFFF7235F898
	private static Void FinalizationPolygon(DTSweepContext tcx) { }

	// RVA: 0xFFFFFFFF7235F9D8
	private static AdvancingFrontNode PointEvent(DTSweepContext tcx, TriangulationPoint point) { }

	// RVA: 0xFFFFFFFF72361798
	private static AdvancingFrontNode NewFrontTriangle(DTSweepContext tcx, TriangulationPoint point, AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF7235FB08
	private static Void EdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF72362990
	private static Void FillEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF72363104
	private static Void FillRightConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF759F1DAC
	private static Void FillRightConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF72363260
	private static Void FillRightBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF72362E38
	private static Void FillRightAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF759F1ED4
	private static Void FillLeftConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF72363864
	private static Void FillLeftConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF723639B8
	private static Void FillLeftBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF72362FA0
	private static Void FillLeftAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF72362678
	private static Boolean IsEdgeSideOfTriangle(DelaunayTriangle triangle, TriangulationPoint ep, TriangulationPoint eq) { }

	// RVA: 0xFFFFFFFF723629C0
	private static Void EdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle triangle, TriangulationPoint point) { }

	// RVA: 0xFFFFFFFF7236409C
	private static Void FlipEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0xFFFFFFFF759F236C
	private static TriangulationPoint NextFlipPoint(TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle ot, TriangulationPoint op) { }

	// RVA: 0xFFFFFFFF759F22C4
	private static DelaunayTriangle NextFlipTriangle(DTSweepContext tcx, Orientation o, DelaunayTriangle t, DelaunayTriangle ot, TriangulationPoint p, TriangulationPoint op) { }

	// RVA: 0xFFFFFFFF759F24D4
	private static Void FlipScanEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle flipTriangle, DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0xFFFFFFFF72361AD0
	private static Void FillAdvancingFront(DTSweepContext tcx, AdvancingFrontNode n) { }

	// RVA: 0xFFFFFFFF72364A90
	private static Void FillBasin(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF759F266C
	private static Void FillBasinReq(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF759F2808
	private static Boolean IsShallow(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF7236494C
	private static Double HoleAngle(AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF72364A08
	private static Double BasinAngle(AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF7236144C
	private static Void Fill(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF72361FB8
	private static Boolean Legalize(DTSweepContext tcx, DelaunayTriangle t) { }

	// RVA: 0xFFFFFFFF7235FF50
	private static Void RotateTrianglePair(DelaunayTriangle t, TriangulationPoint p, DelaunayTriangle ot, TriangulationPoint op) { }

}

// Namespace: Pathfinding.Poly2Tri
public class DTSweepBasin
{
	// Fields
	public AdvancingFrontNode leftNode; // 0x10
	public AdvancingFrontNode bottomNode; // 0x18
	public AdvancingFrontNode rightNode; // 0x20
	public Double width; // 0x28
	public Boolean leftHighest; // 0x30

	// Methods

	// RVA: 0xFFFFFFFF759F2AA0
	public Void .ctor() { }

}

// Namespace: Pathfinding.Poly2Tri
public class DTSweepConstraint
{
	// Methods

	// RVA: 0xFFFFFFFF72364F64
	public Void .ctor(TriangulationPoint p1, TriangulationPoint p2) { }

}

// Namespace: Pathfinding.Poly2Tri
public class DTSweepContext
{
	// Fields
	private readonly Single ALPHA; // 0x40
	public AdvancingFront Front; // 0x48
	public DTSweepBasin Basin; // 0x50
	public DTSweepEdgeEvent EdgeEvent; // 0x58
	private DTSweepPointComparator _comparator; // 0x60
	private TriangulationPoint <Head>k__BackingField; // 0x68
	private TriangulationPoint <Tail>k__BackingField; // 0x70

	// Properties
	public TriangulationPoint Head { get; set; }
	public TriangulationPoint Tail { get; set; }
	public override Boolean IsDebugEnabled { get; }
	public override TriangulationAlgorithm Algorithm { get; }

	// Methods

	// RVA: 0xFFFFFFFF72365180
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759F2AB0
	public TriangulationPoint get_Head() { }

	// RVA: 0xFFFFFFFF759F2AB8
	public Void set_Head(TriangulationPoint value) { }

	// RVA: 0xFFFFFFFF759F2AF0
	public TriangulationPoint get_Tail() { }

	// RVA: 0xFFFFFFFF759F2AF8
	public Void set_Tail(TriangulationPoint value) { }

	// RVA: 0xFFFFFFFF72365394
	public override Boolean get_IsDebugEnabled() { }

	// RVA: 0xFFFFFFFF759F1B2C
	public Void RemoveFromList(DelaunayTriangle triangle) { }

	// RVA: 0xFFFFFFFF759F1D1C
	public Void MeshClean(DelaunayTriangle triangle) { }

	// RVA: 0xFFFFFFFF7236539C
	private Void MeshCleanReq(DelaunayTriangle triangle) { }

	// RVA: 0xFFFFFFFF7236559C
	public override Void Clear() { }

	// RVA: 0xFFFFFFFF759F1D20
	public Void AddNode(AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF759F286C
	public Void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0xFFFFFFFF723616F4
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0xFFFFFFFF7235F1B4
	public Void CreateAdvancingFront() { }

	// RVA: 0xFFFFFFFF72360D54
	public Void MapTriangleToNodes(DelaunayTriangle t) { }

	// RVA: 0xFFFFFFFF723656C0
	public override Void PrepareTriangulation(Triangulatable t) { }

	// RVA: 0xFFFFFFFF759F1B8C
	public Void FinalizeTriangulation() { }

	// RVA: 0xFFFFFFFF72365B6C
	public override TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }

	// RVA: 0xFFFFFFFF72365BD8
	public override TriangulationAlgorithm get_Algorithm() { }

}

// Namespace: Pathfinding.Poly2Tri
public class DTSweepDebugContext
{
	// Fields
	private DelaunayTriangle _primaryTriangle; // 0x18
	private DelaunayTriangle _secondaryTriangle; // 0x20
	private TriangulationPoint _activePoint; // 0x28
	private AdvancingFrontNode _activeNode; // 0x30
	private DTSweepConstraint _activeConstraint; // 0x38

	// Properties
	public DelaunayTriangle PrimaryTriangle { set; }
	public DelaunayTriangle SecondaryTriangle { set; }
	public TriangulationPoint ActivePoint { set; }
	public AdvancingFrontNode ActiveNode { set; }
	public DTSweepConstraint ActiveConstraint { set; }

	// Methods

	// RVA: 0xFFFFFFFF759F1D3C
	public Void set_PrimaryTriangle(DelaunayTriangle value) { }

	// RVA: 0xFFFFFFFF759F2254
	public Void set_SecondaryTriangle(DelaunayTriangle value) { }

	// RVA: 0xFFFFFFFF759F2B38
	public Void set_ActivePoint(TriangulationPoint value) { }

	// RVA: 0xFFFFFFFF759F1C64
	public Void set_ActiveNode(AdvancingFrontNode value) { }

	// RVA: 0xFFFFFFFF759F1904
	public Void set_ActiveConstraint(DTSweepConstraint value) { }

	// RVA: 0xFFFFFFFF759F2BA8
	public override Void Clear() { }

}

// Namespace: Pathfinding.Poly2Tri
public class DTSweepEdgeEvent
{
	// Fields
	public DTSweepConstraint ConstrainedEdge; // 0x10
	public Boolean Right; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF759F2AA8
	public Void .ctor() { }

}

// Namespace: Pathfinding.Poly2Tri
public class DTSweepPointComparator
{
	// Methods

	// RVA: 0xFFFFFFFF759F2AAC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF72365BE0
	public Int32 Compare(TriangulationPoint p1, TriangulationPoint p2) { }

}

// Namespace: Pathfinding.Poly2Tri
public class PointOnEdgeException
{
	// Fields
	public readonly TriangulationPoint A; // 0x88
	public readonly TriangulationPoint B; // 0x90
	public readonly TriangulationPoint C; // 0x98

	// Methods

	// RVA: 0xFFFFFFFF759F2040
	public Void .ctor(String message, TriangulationPoint a, TriangulationPoint b, TriangulationPoint c) { }

}

// Namespace: Pathfinding.Poly2Tri
public enum Orientation
{
	// Fields
	public Int32 value__; // 0x10
	public const Orientation CW = 0;
	public const Orientation CCW = 1;
	public const Orientation Collinear = 2;
}

// Namespace: Pathfinding.Poly2Tri
public interface Triangulatable
{
	// Properties
	public abstract TriangulationMode TriangulationMode { get; }

	// Methods

	// RVA: -1
	public abstract Void Prepare(TriangulationContext tcx) { }

	// RVA: -1
	public abstract Void AddTriangle(DelaunayTriangle t) { }

	// RVA: -1
	public abstract Void AddTriangles(IEnumerable<T0> list) { }

	// RVA: -1
	public abstract TriangulationMode get_TriangulationMode() { }

}

// Namespace: Pathfinding.Poly2Tri
public enum TriangulationAlgorithm
{
	// Fields
	public Int32 value__; // 0x10
	public const TriangulationAlgorithm DTSweep = 0;
}

// Namespace: Pathfinding.Poly2Tri
public class TriangulationConstraint
{
	// Fields
	public TriangulationPoint P; // 0x10
	public TriangulationPoint Q; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF759F2AA4
	public Void .ctor() { }

}

// Namespace: Pathfinding.Poly2Tri
public abstract class TriangulationContext
{
	// Fields
	public readonly List<T0> Triangles; // 0x10
	public readonly List<T0> Points; // 0x18
	private TriangulationDebugContext <DebugContext>k__BackingField; // 0x20
	private TriangulationMode <TriangulationMode>k__BackingField; // 0x28
	private Triangulatable <Triangulatable>k__BackingField; // 0x30
	private Int32 <StepCount>k__BackingField; // 0x38
	private Boolean <IsDebugEnabled>k__BackingField; // 0x3C

	// Properties
	public TriangulationDebugContext DebugContext { get; }
	public TriangulationMode TriangulationMode { get; set; }
	public Triangulatable Triangulatable { get; set; }
	public Int32 StepCount { get; set; }
	public abstract TriangulationAlgorithm Algorithm { get; }
	public virtual Boolean IsDebugEnabled { get; }
	public DTSweepDebugContext DTDebugContext { get; }

	// Methods

	// RVA: 0xFFFFFFFF72365274
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF759F374C
	public TriangulationDebugContext get_DebugContext() { }

	// RVA: 0xFFFFFFFF759F3754
	public TriangulationMode get_TriangulationMode() { }

	// RVA: 0xFFFFFFFF759F375C
	protected Void set_TriangulationMode(TriangulationMode value) { }

	// RVA: 0xFFFFFFFF759F3764
	public Triangulatable get_Triangulatable() { }

	// RVA: 0xFFFFFFFF759F376C
	private Void set_Triangulatable(Triangulatable value) { }

	// RVA: 0xFFFFFFFF759F37A4
	public Int32 get_StepCount() { }

	// RVA: 0xFFFFFFFF759F37AC
	private Void set_StepCount(Int32 value) { }

	// RVA: 0xFFFFFFFF759F1868
	public Void Done() { }

	// RVA: -1
	public abstract TriangulationAlgorithm get_Algorithm() { }

	// RVA: 0xFFFFFFFF72365A38
	public virtual Void PrepareTriangulation(Triangulatable t) { }

	// RVA: -1
	public abstract TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }

	// RVA: 0xFFFFFFFF759F1974
	public Void Update(String message) { }

	// RVA: 0xFFFFFFFF72365648
	public virtual Void Clear() { }

	// RVA: 0xFFFFFFFF759F37B4
	public virtual Boolean get_IsDebugEnabled() { }

	// RVA: 0xFFFFFFFF759F1888
	public DTSweepDebugContext get_DTDebugContext() { }

}

// Namespace: Pathfinding.Poly2Tri
public abstract class TriangulationDebugContext
{
	// Fields
	protected TriangulationContext _tcx; // 0x10

	// Methods

	// RVA: -1
	public abstract Void Clear() { }

}

// Namespace: Pathfinding.Poly2Tri
public enum TriangulationMode
{
	// Fields
	public Int32 value__; // 0x10
	public const TriangulationMode Unconstrained = 0;
	public const TriangulationMode Constrained = 1;
	public const TriangulationMode Polygon = 2;
}

// Namespace: Pathfinding.Poly2Tri
public class TriangulationPoint
{
	// Fields
	public Double X; // 0x10
	public Double Y; // 0x18
	private List<T0> <Edges>k__BackingField; // 0x20

	// Properties
	public List<T0> Edges { get; set; }
	public Boolean HasEdges { get; }

	// Methods

	// RVA: 0xFFFFFFFF759F2B30
	public Void .ctor(Double x, Double y) { }

	// RVA: 0xFFFFFFFF759F37BC
	public List<T0> get_Edges() { }

	// RVA: 0xFFFFFFFF759F37C4
	private Void set_Edges(List<T0> value) { }

	// RVA: 0xFFFFFFFF759F37FC
	public override String ToString() { }

	// RVA: 0xFFFFFFFF7236503C
	public Void AddEdge(DTSweepConstraint e) { }

	// RVA: 0xFFFFFFFF759F1878
	public Boolean get_HasEdges() { }

}

// Namespace: Pathfinding.Poly2Tri
public class TriangulationUtil
{
	// Fields
	public static Double EPSILON; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF759F3918
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF72364DFC
	public static Boolean SmartIncircle(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd) { }

	// RVA: 0xFFFFFFFF72364828
	public static Boolean InScanArea(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd) { }

	// RVA: 0xFFFFFFFF72361354
	public static Orientation Orient2d(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc) { }

}

// Namespace: Pathfinding.Poly2Tri
public struct FixedArray3<T0>
{
	// Fields
	public T _0; // 0x0
	public T _1; // 0x0
	public T _2; // 0x0

	// Properties
	public T Item { get; set; }

	// Methods

	// RVA: -1
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: -1
	public T get_Item(Int32 index) { }

	// RVA: -1
	public Void set_Item(Int32 index, T value) { }

	// RVA: -1
	public Boolean Contains(T value) { }

	// RVA: -1
	public Int32 IndexOf(T value) { }

	// RVA: -1
	public Void Clear() { }

	// RVA: -1
	private IEnumerable<T0> Enumerate() { }

	// RVA: -1
	public IEnumerator<T0> GetEnumerator() { }

}

// Namespace: 
private sealed class <Enumerate>c__Iterator0
{
	// Fields
	internal Int32 <i>__0; // 0x0
	internal Int32 $PC; // 0x0
	internal T $current; // 0x0
	internal FixedArray3<T0> <>f__this; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1
	public Void .ctor() { }

	// RVA: -1
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }

	// RVA: -1
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: -1
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: -1
	private IEnumerator<T0> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: -1
	public Boolean MoveNext() { }

	// RVA: -1
	public Void Dispose() { }

	// RVA: -1
	public Void Reset() { }

}

// Namespace: Pathfinding.Poly2Tri
public struct FixedBitArray3
{
	// Fields
	public Boolean _0; // 0x10
	public Boolean _1; // 0x11
	public Boolean _2; // 0x12

	// Properties
	public Boolean Item { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF71144B68
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFFFFFFFF71144B70
	public Boolean get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF71144B78
	public Void set_Item(Int32 index, Boolean value) { }

	// RVA: 0xFFFFFFFF71144B80
	public Void Clear() { }

	// RVA: 0xFFFFFFFF71144B8C
	private IEnumerable<T0> Enumerate() { }

	// RVA: 0xFFFFFFFF71144B94
	public IEnumerator<T0> GetEnumerator() { }

}

// Namespace: 
private sealed class <Enumerate>c__Iterator1
{
	// Fields
	internal Int32 <i>__0; // 0x10
	internal Int32 $PC; // 0x14
	internal Boolean $current; // 0x18
	internal FixedBitArray3 <>f__this; // 0x19

	// Properties
	private Boolean System.Collections.Generic.IEnumerator<bool>.Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF759F2EC0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759F2EC4
	private Boolean System.Collections.Generic.IEnumerator<bool>.get_Current() { }

	// RVA: 0xFFFFFFFF759F2ECC
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xFFFFFFFF759F2EFC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFFFFFFFF759F2F00
	private IEnumerator<T0> System.Collections.Generic.IEnumerable<bool>.GetEnumerator() { }

	// RVA: 0xFFFFFFFF759F2F7C
	public Boolean MoveNext() { }

	// RVA: 0xFFFFFFFF759F3004
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF759F3010
	public Void Reset() { }

}


