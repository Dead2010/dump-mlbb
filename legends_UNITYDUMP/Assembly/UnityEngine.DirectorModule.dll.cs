// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Playables
public class PlayableDirector
{
	// Fields
	private Action<T0> played; // 0x18
	private Action<T0> paused; // 0x20
	private Action<T0> stopped; // 0x28

	// Properties
	public PlayState state { get; }
	public DirectorWrapMode extrapolationMode { get; set; }
	public PlayableAsset playableAsset { get; }
	public PlayableGraph playableGraph { get; }
	public Boolean playOnAwake { set; }
	public DirectorUpdateMode timeUpdateMode { get; set; }
	public Double time { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF723CDF84
	public PlayState get_state() { }

	// RVA: 0xFFFFFFFF75C48CB0
	public Void set_extrapolationMode(DirectorWrapMode value) { }

	// RVA: 0xFFFFFFFF723CDFC8
	public DirectorWrapMode get_extrapolationMode() { }

	// RVA: 0xFFFFFFFF75C48D90
	public PlayableAsset get_playableAsset() { }

	// RVA: 0xFFFFFFFF723CE00C
	public PlayableGraph get_playableGraph() { }

	// RVA: 0xFFFFFFFF75C48EAC
	public Void set_playOnAwake(Boolean value) { }

	// RVA: 0xFFFFFFFF723CE068
	public Void SetGenericBinding(Object key, Object value) { }

	// RVA: 0xFFFFFFFF75C48FA4
	public Void set_timeUpdateMode(DirectorUpdateMode value) { }

	// RVA: 0xFFFFFFFF723CE0C4
	public DirectorUpdateMode get_timeUpdateMode() { }

	// RVA: 0xFFFFFFFF723CE108
	public Void set_time(Double value) { }

	// RVA: 0xFFFFFFFF723CE15C
	public Double get_time() { }

	// RVA: 0xFFFFFFFF723CE1A0
	public Void Evaluate() { }

	// RVA: 0xFFFFFFFF723CE1E4
	public Void Play() { }

	// RVA: 0xFFFFFFFF723CE228
	public Void Stop() { }

	// RVA: 0xFFFFFFFF723CE26C
	public Void Pause() { }

	// RVA: 0xFFFFFFFF75C48FF8
	public Void RebuildGraph() { }

	// RVA: 0xFFFFFFFF75C4903C
	public Void SetReferenceValue(PropertyName id, Object value) { }

	// RVA: 0xFFFFFFFF75C490F8
	public Object GetReferenceValue(PropertyName id, out Boolean idValid) { }

	// RVA: 0xFFFFFFFF723CE2B0
	public Object GetGenericBinding(Object key) { }

	// RVA: 0xFFFFFFFF75C48C70
	private PlayState GetPlayState() { }

	// RVA: 0xFFFFFFFF75C48D00
	private Void SetWrapMode(DirectorWrapMode mode) { }

	// RVA: 0xFFFFFFFF75C48D50
	private DirectorWrapMode GetWrapMode() { }

	// RVA: 0xFFFFFFFF75C48E54
	private PlayableGraph GetGraphHandle() { }

	// RVA: 0xFFFFFFFF75C48EFC
	private Void SetPlayOnAwake(Boolean on) { }

	// RVA: 0xFFFFFFFF75C48F4C
	private Void Internal_SetGenericBinding(Object key, Object value) { }

	// RVA: 0xFFFFFFFF75C48E14
	private ScriptableObject Internal_GetPlayableAsset() { }

	// RVA: 0xFFFFFFFF723CE304
	private Void SendOnPlayableDirectorPlay() { }

	// RVA: 0xFFFFFFFF723CE320
	private Void SendOnPlayableDirectorPause() { }

	// RVA: 0xFFFFFFFF723CE33C
	private Void SendOnPlayableDirectorStop() { }

	// RVA: 0xFFFFFFFF75C490A0
	private Void SetReferenceValue_Injected(ref PropertyName id, Object value) { }

	// RVA: 0xFFFFFFFF75C4915C
	private Object GetReferenceValue_Injected(ref PropertyName id, out Boolean idValid) { }

	// RVA: 0xFFFFFFFF75C491B4
	private Void GetGraphHandle_Injected(out PlayableGraph ret) { }

}


