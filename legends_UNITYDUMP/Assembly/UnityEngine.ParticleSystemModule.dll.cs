// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public sealed class ParticleSystem
{
	// Properties
	public Single startDelay { get; set; }
	public Boolean loop { get; set; }
	public Boolean playOnAwake { get; set; }
	public Single duration { get; }
	public Single playbackSpeed { get; set; }
	public Boolean enableEmission { get; set; }
	public Single emissionRate { get; set; }
	public Single startSpeed { get; set; }
	public Single startSize { get; set; }
	public Color startColor { get; set; }
	public Single startRotation { get; set; }
	public Vector3 startRotation3D { get; set; }
	public Single startLifetime { get; set; }
	public Single gravityModifier { get; set; }
	public Int32 maxParticles { get; set; }
	public ParticleSystemSimulationSpace simulationSpace { get; set; }
	public ParticleSystemScalingMode scalingMode { get; set; }
	public Boolean automaticCullingEnabled { get; }
	public Boolean isPlaying { get; }
	public Boolean isEmitting { get; }
	public Boolean isStopped { get; }
	public Boolean isPaused { get; }
	public Int32 particleCount { get; }
	public Single time { get; set; }
	public UInt32 randomSeed { get; set; }
	public Boolean useAutoRandomSeed { get; set; }
	public Boolean proceduralSimulationSupported { get; }
	public MainModule main { get; }
	public EmissionModule emission { get; }
	public ShapeModule shape { get; }
	public VelocityOverLifetimeModule velocityOverLifetime { get; }
	public LimitVelocityOverLifetimeModule limitVelocityOverLifetime { get; }
	public InheritVelocityModule inheritVelocity { get; }
	public ForceOverLifetimeModule forceOverLifetime { get; }
	public ColorOverLifetimeModule colorOverLifetime { get; }
	public ColorBySpeedModule colorBySpeed { get; }
	public SizeOverLifetimeModule sizeOverLifetime { get; }
	public SizeBySpeedModule sizeBySpeed { get; }
	public RotationOverLifetimeModule rotationOverLifetime { get; }
	public RotationBySpeedModule rotationBySpeed { get; }
	public ExternalForcesModule externalForces { get; }
	public NoiseModule noise { get; }
	public CollisionModule collision { get; }
	public TriggerModule trigger { get; }
	public SubEmittersModule subEmitters { get; }
	public TextureSheetAnimationModule textureSheetAnimation { get; }
	public LightsModule lights { get; }
	public TrailModule trails { get; }
	public CustomDataModule customData { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C6C77C
	public Void Emit(Vector3 position, Vector3 velocity, Single size, Single lifetime, Color32 color) { }

	// RVA: 0xFFFFFFFF75C6CA60
	public Void Emit(Particle particle) { }

	// RVA: 0xFFFFFFFF75C6CAB0
	public Single get_startDelay() { }

	// RVA: 0xFFFFFFFF75C6CB5C
	public Void set_startDelay(Single value) { }

	// RVA: 0xFFFFFFFF75C6CC28
	public Boolean get_loop() { }

	// RVA: 0xFFFFFFFF75C6CC94
	public Void set_loop(Boolean value) { }

	// RVA: 0xFFFFFFFF75C6CD58
	public Boolean get_playOnAwake() { }

	// RVA: 0xFFFFFFFF75C6CE04
	public Void set_playOnAwake(Boolean value) { }

	// RVA: 0xFFFFFFFF75C6CEC8
	public Single get_duration() { }

	// RVA: 0xFFFFFFFF75C6CF34
	public Single get_playbackSpeed() { }

	// RVA: 0xFFFFFFFF723D4D4C
	public Void set_playbackSpeed(Single value) { }

	// RVA: 0xFFFFFFFF75C6CFF0
	public Boolean get_enableEmission() { }

	// RVA: 0xFFFFFFFF75C6D05C
	public Void set_enableEmission(Boolean value) { }

	// RVA: 0xFFFFFFFF75C6D120
	public Single get_emissionRate() { }

	// RVA: 0xFFFFFFFF75C6D1CC
	public Void set_emissionRate(Single value) { }

	// RVA: 0xFFFFFFFF75C6D2E4
	public Single get_startSpeed() { }

	// RVA: 0xFFFFFFFF75C6D390
	public Void set_startSpeed(Single value) { }

	// RVA: 0xFFFFFFFF75C6D45C
	public Single get_startSize() { }

	// RVA: 0xFFFFFFFF75C6D508
	public Void set_startSize(Single value) { }

	// RVA: 0xFFFFFFFF75C6D5D4
	public Color get_startColor() { }

	// RVA: 0xFFFFFFFF75C6D6EC
	public Void set_startColor(Color value) { }

	// RVA: 0xFFFFFFFF75C6D860
	public Single get_startRotation() { }

	// RVA: 0xFFFFFFFF75C6D90C
	public Void set_startRotation(Single value) { }

	// RVA: 0xFFFFFFFF75C6D9D8
	public Vector3 get_startRotation3D() { }

	// RVA: 0xFFFFFFFF75C6DBD4
	public Void set_startRotation3D(Vector3 value) { }

	// RVA: 0xFFFFFFFF75C6DDA8
	public Single get_startLifetime() { }

	// RVA: 0xFFFFFFFF75C6DE54
	public Void set_startLifetime(Single value) { }

	// RVA: 0xFFFFFFFF75C6DF20
	public Single get_gravityModifier() { }

	// RVA: 0xFFFFFFFF75C6DFCC
	public Void set_gravityModifier(Single value) { }

	// RVA: 0xFFFFFFFF75C6E098
	public Int32 get_maxParticles() { }

	// RVA: 0xFFFFFFFF75C6E144
	public Void set_maxParticles(Int32 value) { }

	// RVA: 0xFFFFFFFF75C6E1B8
	public ParticleSystemSimulationSpace get_simulationSpace() { }

	// RVA: 0xFFFFFFFF75C6E224
	public Void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	// RVA: 0xFFFFFFFF75C6E2E8
	public ParticleSystemScalingMode get_scalingMode() { }

	// RVA: 0xFFFFFFFF75C6E394
	public Void set_scalingMode(ParticleSystemScalingMode value) { }

	// RVA: 0xFFFFFFFF75C6E458
	public Boolean get_automaticCullingEnabled() { }

	// RVA: 0xFFFFFFFF723D4F90
	public Boolean get_isPlaying() { }

	// RVA: 0xFFFFFFFF75C6E4D8
	public Boolean get_isEmitting() { }

	// RVA: 0xFFFFFFFF75C6E518
	public Boolean get_isStopped() { }

	// RVA: 0xFFFFFFFF75C6E55C
	public Boolean get_isPaused() { }

	// RVA: 0xFFFFFFFF75C6E59C
	public Int32 get_particleCount() { }

	// RVA: 0xFFFFFFFF75C6E5DC
	public Single get_time() { }

	// RVA: 0xFFFFFFFF723D4FD4
	public Void set_time(Single value) { }

	// RVA: 0xFFFFFFFF75C6E61C
	public UInt32 get_randomSeed() { }

	// RVA: 0xFFFFFFFF75C6E65C
	public Void set_randomSeed(UInt32 value) { }

	// RVA: 0xFFFFFFFF75C6E6AC
	public Boolean get_useAutoRandomSeed() { }

	// RVA: 0xFFFFFFFF75C6E6F0
	public Void set_useAutoRandomSeed(Boolean value) { }

	// RVA: 0xFFFFFFFF75C6E498
	public Boolean get_proceduralSimulationSupported() { }

	// RVA: 0xFFFFFFFF75C6E744
	internal Single GetParticleCurrentSize(ref Particle particle) { }

	// RVA: 0xFFFFFFFF75C6E794
	internal Vector3 GetParticleCurrentSize3D(ref Particle particle) { }

	// RVA: 0xFFFFFFFF75C6E85C
	internal Color32 GetParticleCurrentColor(ref Particle particle) { }

	// RVA: 0xFFFFFFFF75C6E91C
	internal Int32 GetParticleMeshIndex(ref Particle particle) { }

	// RVA: 0xFFFFFFFF75C6E96C
	public Void SetParticles([Out] Particle[] particles, Int32 size, Int32 offset) { }

	// RVA: 0xFFFFFFFF75C6E9D4
	public Void SetParticles([Out] Particle[] particles, Int32 size) { }

	// RVA: 0xFFFFFFFF75C6EA30
	public Void SetParticles([Out] Particle[] particles) { }

	// RVA: 0xFFFFFFFF75C6EA88
	private Void SetParticlesWithNativeArray(IntPtr particles, Int32 particlesLength, Int32 size, Int32 offset) { }

	// RVA: 0xFFFFFFFF75C6EAF8
	public Void SetParticles([Out] NativeArray<T0> particles, Int32 size, Int32 offset) { }

	// RVA: 0xFFFFFFFF75C6EBA4
	public Void SetParticles([Out] NativeArray<T0> particles, Int32 size) { }

	// RVA: 0xFFFFFFFF75C6EBA8
	public Void SetParticles([Out] NativeArray<T0> particles) { }

	// RVA: 0xFFFFFFFF75C6EBB0
	public Int32 GetParticles([Out] Particle[] particles, Int32 size, Int32 offset) { }

	// RVA: 0xFFFFFFFF75C6EC18
	public Int32 GetParticles([Out] Particle[] particles, Int32 size) { }

	// RVA: 0xFFFFFFFF75C6EC74
	public Int32 GetParticles([Out] Particle[] particles) { }

	// RVA: 0xFFFFFFFF75C6ECCC
	private Int32 GetParticlesWithNativeArray(IntPtr particles, Int32 particlesLength, Int32 size, Int32 offset) { }

	// RVA: 0xFFFFFFFF75C6ED3C
	public Int32 GetParticles([Out] NativeArray<T0> particles, Int32 size, Int32 offset) { }

	// RVA: 0xFFFFFFFF75C6EDE8
	public Int32 GetParticles([Out] NativeArray<T0> particles, Int32 size) { }

	// RVA: 0xFFFFFFFF75C6EDEC
	public Int32 GetParticles([Out] NativeArray<T0> particles) { }

	// RVA: 0xFFFFFFFF75C6EDF4
	public Void SetCustomParticleData(List<T0> customData, ParticleSystemCustomData streamIndex) { }

	// RVA: 0xFFFFFFFF75C6EE4C
	public Int32 GetCustomParticleData(List<T0> customData, ParticleSystemCustomData streamIndex) { }

	// RVA: 0xFFFFFFFF75C6EEA4
	public PlaybackState GetPlaybackState() { }

	// RVA: 0xFFFFFFFF75C6EF90
	public Void SetPlaybackState(PlaybackState playbackState) { }

	// RVA: 0xFFFFFFFF75C6F030
	private Void GetTrailDataInternal(ref Trails trailData) { }

	// RVA: 0xFFFFFFFF75C6F080
	public Trails GetTrails() { }

	// RVA: 0xFFFFFFFF75C6F1D8
	public Void SetTrails(Trails trailData) { }

	// RVA: 0xFFFFFFFF723D5030
	public Void Simulate(Single t, Boolean withChildren, Boolean restart, Boolean fixedTimeStep) { }

	// RVA: 0xFFFFFFFF75C6F278
	public Void Simulate(Single t, Boolean withChildren, Boolean restart) { }

	// RVA: 0xFFFFFFFF75C6F2E4
	public Void Simulate(Single t, Boolean withChildren) { }

	// RVA: 0xFFFFFFFF75C6F34C
	public Void Simulate(Single t) { }

	// RVA: 0xFFFFFFFF723D509C
	public Void Play(Boolean withChildren) { }

	// RVA: 0xFFFFFFFF723D50F8
	public Void Play() { }

	// RVA: 0xFFFFFFFF723D5150
	public Void Pause(Boolean withChildren) { }

	// RVA: 0xFFFFFFFF723D51A4
	public Void Pause() { }

	// RVA: 0xFFFFFFFF723D51FC
	public Void Stop(Boolean withChildren, ParticleSystemStopBehavior stopBehavior) { }

	// RVA: 0xFFFFFFFF723D5258
	public Void Stop(Boolean withChildren) { }

	// RVA: 0xFFFFFFFF75C6F3A8
	public Void Stop() { }

	// RVA: 0xFFFFFFFF723D52B8
	public Void Clear(Boolean withChildren) { }

	// RVA: 0xFFFFFFFF75C6F3F0
	public Void Clear() { }

	// RVA: 0xFFFFFFFF75C6F434
	public Boolean IsAlive(Boolean withChildren) { }

	// RVA: 0xFFFFFFFF75C6F484
	public Boolean IsAlive() { }

	// RVA: 0xFFFFFFFF75C6F4C8
	public Void Emit(Int32 count) { }

	// RVA: 0xFFFFFFFF75C6F518
	private Void Emit_Internal(Int32 count) { }

	// RVA: 0xFFFFFFFF75C6F568
	public Void Emit(EmitParams emitParams, Int32 count) { }

	// RVA: 0xFFFFFFFF75C6CA10
	private Void EmitOld_Internal(ref Particle particle) { }

	// RVA: 0xFFFFFFFF75C6F618
	public Void TriggerSubEmitter(Int32 subEmitterIndex) { }

	// RVA: 0xFFFFFFFF75C6F6C4
	public Void TriggerSubEmitter(Int32 subEmitterIndex, ref Particle particle) { }

	// RVA: 0xFFFFFFFF75C6F74C
	internal Void TriggerSubEmitterForParticle(Int32 subEmitterIndex, Particle particle) { }

	// RVA: 0xFFFFFFFF75C6F66C
	public Void TriggerSubEmitter(Int32 subEmitterIndex, List<T0> particles) { }

	// RVA: 0xFFFFFFFF75C6F7FC
	public static Void ResetPreMappedBufferMemory() { }

	// RVA: 0xFFFFFFFF75C6F830
	public static Void SetMaximumPreMappedBufferCounts(Int32 vertexBuffersCount, Int32 indexBuffersCount) { }

	// RVA: 0xFFFFFFFF75C6F880
	internal Void* GetManagedJobData() { }

	// RVA: 0xFFFFFFFF75C6F8C0
	internal JobHandle GetManagedJobHandle() { }

	// RVA: 0xFFFFFFFF75C6F968
	internal Void SetManagedJobHandle(JobHandle handle) { }

	// RVA: 0xFFFFFFFF75C6FA0C
	internal static JobHandle ScheduleManagedJob(ref JobScheduleParameters parameters, Void* additionalData) { }

	// RVA: 0xFFFFFFFF75C6FACC
	internal static Void CopyManagedJobData(Void* systemPtr, out NativeParticleData particleData) { }

	// RVA: 0xFFFFFFFF723D4C1C
	public MainModule get_main() { }

	// RVA: 0xFFFFFFFF723D4DCC
	public EmissionModule get_emission() { }

	// RVA: 0xFFFFFFFF75C6FB8C
	public ShapeModule get_shape() { }

	// RVA: 0xFFFFFFFF75C6FC08
	public VelocityOverLifetimeModule get_velocityOverLifetime() { }

	// RVA: 0xFFFFFFFF75C6FC84
	public LimitVelocityOverLifetimeModule get_limitVelocityOverLifetime() { }

	// RVA: 0xFFFFFFFF75C6FD00
	public InheritVelocityModule get_inheritVelocity() { }

	// RVA: 0xFFFFFFFF75C6FD7C
	public ForceOverLifetimeModule get_forceOverLifetime() { }

	// RVA: 0xFFFFFFFF75C6FDF8
	public ColorOverLifetimeModule get_colorOverLifetime() { }

	// RVA: 0xFFFFFFFF75C6FE74
	public ColorBySpeedModule get_colorBySpeed() { }

	// RVA: 0xFFFFFFFF75C6FEF0
	public SizeOverLifetimeModule get_sizeOverLifetime() { }

	// RVA: 0xFFFFFFFF75C6FF6C
	public SizeBySpeedModule get_sizeBySpeed() { }

	// RVA: 0xFFFFFFFF75C6FFE8
	public RotationOverLifetimeModule get_rotationOverLifetime() { }

	// RVA: 0xFFFFFFFF75C70064
	public RotationBySpeedModule get_rotationBySpeed() { }

	// RVA: 0xFFFFFFFF75C700E0
	public ExternalForcesModule get_externalForces() { }

	// RVA: 0xFFFFFFFF75C7015C
	public NoiseModule get_noise() { }

	// RVA: 0xFFFFFFFF75C701D8
	public CollisionModule get_collision() { }

	// RVA: 0xFFFFFFFF75C70254
	public TriggerModule get_trigger() { }

	// RVA: 0xFFFFFFFF75C702D0
	public SubEmittersModule get_subEmitters() { }

	// RVA: 0xFFFFFFFF75C7034C
	public TextureSheetAnimationModule get_textureSheetAnimation() { }

	// RVA: 0xFFFFFFFF75C703C8
	public LightsModule get_lights() { }

	// RVA: 0xFFFFFFFF723D530C
	public TrailModule get_trails() { }

	// RVA: 0xFFFFFFFF75C7047C
	public CustomDataModule get_customData() { }

	// RVA: 0xFFFFFFFF75C704F8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C6E804
	private Void GetParticleCurrentSize3D_Injected(ref Particle particle, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C6E8C4
	private Void GetParticleCurrentColor_Injected(ref Particle particle, out Color32 ret) { }

	// RVA: 0xFFFFFFFF75C6EF40
	private Void GetPlaybackState_Injected(out PlaybackState ret) { }

	// RVA: 0xFFFFFFFF75C6EFE0
	private Void SetPlaybackState_Injected(ref PlaybackState playbackState) { }

	// RVA: 0xFFFFFFFF75C6F228
	private Void SetTrails_Injected(ref Trails trailData) { }

	// RVA: 0xFFFFFFFF75C6F5C0
	private Void Emit_Injected(ref EmitParams emitParams, Int32 count) { }

	// RVA: 0xFFFFFFFF75C6F7A4
	private Void TriggerSubEmitterForParticle_Injected(Int32 subEmitterIndex, ref Particle particle) { }

	// RVA: 0xFFFFFFFF75C6F918
	private Void GetManagedJobHandle_Injected(out JobHandle ret) { }

	// RVA: 0xFFFFFFFF75C6F9BC
	private Void SetManagedJobHandle_Injected(ref JobHandle handle) { }

	// RVA: 0xFFFFFFFF75C6FA74
	private static Void ScheduleManagedJob_Injected(ref JobScheduleParameters parameters, Void* additionalData, out JobHandle ret) { }

}

// Namespace: 
public struct MainModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Properties
	public Single duration { get; }
	public Boolean loop { get; set; }
	public MinMaxCurve startDelay { get; }
	public Single startDelayMultiplier { get; set; }
	public MinMaxCurve startLifetime { get; set; }
	public Single startLifetimeMultiplier { get; set; }
	public Single startSpeedMultiplier { get; set; }
	public Boolean startSize3D { get; set; }
	public MinMaxCurve startSize { set; }
	public Single startSizeMultiplier { get; set; }
	public MinMaxCurve startSizeX { set; }
	public Single startSizeXMultiplier { get; set; }
	public MinMaxCurve startSizeY { set; }
	public Single startSizeYMultiplier { get; set; }
	public MinMaxCurve startSizeZ { set; }
	public Boolean startRotation3D { get; set; }
	public Single startRotationMultiplier { get; set; }
	public MinMaxCurve startRotationX { set; }
	public Single startRotationXMultiplier { get; set; }
	public MinMaxCurve startRotationY { set; }
	public Single startRotationYMultiplier { get; set; }
	public MinMaxCurve startRotationZ { set; }
	public Single startRotationZMultiplier { get; set; }
	public MinMaxGradient startColor { get; set; }
	public Single gravityModifierMultiplier { get; set; }
	public ParticleSystemSimulationSpace simulationSpace { get; set; }
	public Single simulationSpeed { get; set; }
	public Boolean useUnscaledTime { get; }
	public ParticleSystemScalingMode scalingMode { get; set; }
	public Boolean playOnAwake { get; set; }
	public Int32 maxParticles { get; set; }
	public ParticleSystemCullingMode cullingMode { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF71150050
	internal Void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0xFFFFFFFF71150088
	public Single get_duration() { }

	// RVA: 0xFFFFFFFF711500C8
	public Boolean get_loop() { }

	// RVA: 0xFFFFFFFF71150108
	public Void set_loop(Boolean value) { }

	// RVA: 0xFFFFFFFF71150158
	public MinMaxCurve get_startDelay() { }

	// RVA: 0xFFFFFFFF711501C4
	public Single get_startDelayMultiplier() { }

	// RVA: 0xFFFFFFFF71150204
	public Void set_startDelayMultiplier(Single value) { }

	// RVA: 0xFFFFFFFF71150254
	public MinMaxCurve get_startLifetime() { }

	// RVA: 0xFFFFFFFF711502C0
	public Void set_startLifetime(MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF71150318
	public Single get_startLifetimeMultiplier() { }

	// RVA: 0xFFFFFFFF71150358
	public Void set_startLifetimeMultiplier(Single value) { }

	// RVA: 0xFFFFFFFF711503A8
	public Single get_startSpeedMultiplier() { }

	// RVA: 0xFFFFFFFF711503E8
	public Void set_startSpeedMultiplier(Single value) { }

	// RVA: 0xFFFFFFFF71150438
	public Boolean get_startSize3D() { }

	// RVA: 0xFFFFFFFF71150478
	public Void set_startSize3D(Boolean value) { }

	// RVA: 0xFFFFFFFF711504C8
	public Void set_startSize(MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF71150520
	public Single get_startSizeMultiplier() { }

	// RVA: 0xFFFFFFFF71150560
	public Void set_startSizeMultiplier(Single value) { }

	// RVA: 0xFFFFFFFF711505B0
	public Void set_startSizeX(MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF71150608
	public Single get_startSizeXMultiplier() { }

	// RVA: 0xFFFFFFFF71150648
	public Void set_startSizeXMultiplier(Single value) { }

	// RVA: 0xFFFFFFFF71150698
	public Void set_startSizeY(MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF711506F0
	public Single get_startSizeYMultiplier() { }

	// RVA: 0xFFFFFFFF71150730
	public Void set_startSizeYMultiplier(Single value) { }

	// RVA: 0xFFFFFFFF71150780
	public Void set_startSizeZ(MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF711507D8
	public Boolean get_startRotation3D() { }

	// RVA: 0xFFFFFFFF71150818
	public Void set_startRotation3D(Boolean value) { }

	// RVA: 0xFFFFFFFF71150868
	public Single get_startRotationMultiplier() { }

	// RVA: 0xFFFFFFFF711508A8
	public Void set_startRotationMultiplier(Single value) { }

	// RVA: 0xFFFFFFFF711508F8
	public Void set_startRotationX(MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF71150950
	public Single get_startRotationXMultiplier() { }

	// RVA: 0xFFFFFFFF71150990
	public Void set_startRotationXMultiplier(Single value) { }

	// RVA: 0xFFFFFFFF711509E0
	public Void set_startRotationY(MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF71150A38
	public Single get_startRotationYMultiplier() { }

	// RVA: 0xFFFFFFFF71150A78
	public Void set_startRotationYMultiplier(Single value) { }

	// RVA: 0xFFFFFFFF71150AC8
	public Void set_startRotationZ(MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF71150B20
	public Single get_startRotationZMultiplier() { }

	// RVA: 0xFFFFFFFF71150B60
	public Void set_startRotationZMultiplier(Single value) { }

	// RVA: 0xFFFFFFFF71150BB0
	public MinMaxGradient get_startColor() { }

	// RVA: 0xFFFFFFFF71150C34
	public Void set_startColor(MinMaxGradient value) { }

	// RVA: 0xFFFFFFFF71150C9C
	public Single get_gravityModifierMultiplier() { }

	// RVA: 0xFFFFFFFF71150CDC
	public Void set_gravityModifierMultiplier(Single value) { }

	// RVA: 0xFFFFFFFF71150D2C
	public ParticleSystemSimulationSpace get_simulationSpace() { }

	// RVA: 0xFFFFFFFF71150D6C
	public Void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	// RVA: 0xFFFFFFFF71150DBC
	public Single get_simulationSpeed() { }

	// RVA: 0xFFFFFFFF71150DFC
	public Void set_simulationSpeed(Single value) { }

	// RVA: 0xFFFFFFFF71150E4C
	public Boolean get_useUnscaledTime() { }

	// RVA: 0xFFFFFFFF71150E8C
	public ParticleSystemScalingMode get_scalingMode() { }

	// RVA: 0xFFFFFFFF71150ECC
	public Void set_scalingMode(ParticleSystemScalingMode value) { }

	// RVA: 0xFFFFFFFF71150F1C
	public Boolean get_playOnAwake() { }

	// RVA: 0xFFFFFFFF71150F5C
	public Void set_playOnAwake(Boolean value) { }

	// RVA: 0xFFFFFFFF71150FAC
	public Int32 get_maxParticles() { }

	// RVA: 0xFFFFFFFF71150FEC
	public Void set_maxParticles(Int32 value) { }

	// RVA: 0xFFFFFFFF7115103C
	public ParticleSystemCullingMode get_cullingMode() { }

	// RVA: 0xFFFFFFFF7115107C
	public Void set_cullingMode(ParticleSystemCullingMode value) { }

	// RVA: 0xFFFFFFFF75C70708
	private static Single get_duration_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C70748
	private static Boolean get_loop_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C70788
	private static Void set_loop_Injected(ref MainModule _unity_self, Boolean value) { }

	// RVA: 0xFFFFFFFF75C707D8
	private static Void get_startDelay_Injected(ref MainModule _unity_self, out MinMaxCurve ret) { }

	// RVA: 0xFFFFFFFF75C70828
	private static Single get_startDelayMultiplier_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C70868
	private static Void set_startDelayMultiplier_Injected(ref MainModule _unity_self, Single value) { }

	// RVA: 0xFFFFFFFF75C708B8
	private static Void get_startLifetime_Injected(ref MainModule _unity_self, out MinMaxCurve ret) { }

	// RVA: 0xFFFFFFFF75C70958
	private static Void set_startLifetime_Injected(ref MainModule _unity_self, ref MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF75C709A8
	private static Single get_startLifetimeMultiplier_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C709E8
	private static Void set_startLifetimeMultiplier_Injected(ref MainModule _unity_self, Single value) { }

	// RVA: 0xFFFFFFFF75C70A38
	private static Single get_startSpeedMultiplier_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C70A78
	private static Void set_startSpeedMultiplier_Injected(ref MainModule _unity_self, Single value) { }

	// RVA: 0xFFFFFFFF75C70B08
	private static Boolean get_startSize3D_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C70B98
	private static Void set_startSize3D_Injected(ref MainModule _unity_self, Boolean value) { }

	// RVA: 0xFFFFFFFF75C70BE8
	private static Void set_startSize_Injected(ref MainModule _unity_self, ref MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF75C70C38
	private static Single get_startSizeMultiplier_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C70C78
	private static Void set_startSizeMultiplier_Injected(ref MainModule _unity_self, Single value) { }

	// RVA: 0xFFFFFFFF75C70D18
	private static Void set_startSizeX_Injected(ref MainModule _unity_self, ref MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF75C70DA8
	private static Single get_startSizeXMultiplier_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C70E38
	private static Void set_startSizeXMultiplier_Injected(ref MainModule _unity_self, Single value) { }

	// RVA: 0xFFFFFFFF75C70ED8
	private static Void set_startSizeY_Injected(ref MainModule _unity_self, ref MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF75C70F68
	private static Single get_startSizeYMultiplier_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C70FF8
	private static Void set_startSizeYMultiplier_Injected(ref MainModule _unity_self, Single value) { }

	// RVA: 0xFFFFFFFF75C71098
	private static Void set_startSizeZ_Injected(ref MainModule _unity_self, ref MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF75C71128
	private static Boolean get_startRotation3D_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C711B8
	private static Void set_startRotation3D_Injected(ref MainModule _unity_self, Boolean value) { }

	// RVA: 0xFFFFFFFF75C71208
	private static Single get_startRotationMultiplier_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C71248
	private static Void set_startRotationMultiplier_Injected(ref MainModule _unity_self, Single value) { }

	// RVA: 0xFFFFFFFF75C712E8
	private static Void set_startRotationX_Injected(ref MainModule _unity_self, ref MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF75C71338
	private static Single get_startRotationXMultiplier_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C71378
	private static Void set_startRotationXMultiplier_Injected(ref MainModule _unity_self, Single value) { }

	// RVA: 0xFFFFFFFF75C71418
	private static Void set_startRotationY_Injected(ref MainModule _unity_self, ref MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF75C71468
	private static Single get_startRotationYMultiplier_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C714A8
	private static Void set_startRotationYMultiplier_Injected(ref MainModule _unity_self, Single value) { }

	// RVA: 0xFFFFFFFF75C71548
	private static Void set_startRotationZ_Injected(ref MainModule _unity_self, ref MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF75C71598
	private static Single get_startRotationZMultiplier_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C715D8
	private static Void set_startRotationZMultiplier_Injected(ref MainModule _unity_self, Single value) { }

	// RVA: 0xFFFFFFFF75C71628
	private static Void get_startColor_Injected(ref MainModule _unity_self, out MinMaxGradient ret) { }

	// RVA: 0xFFFFFFFF75C71678
	private static Void set_startColor_Injected(ref MainModule _unity_self, ref MinMaxGradient value) { }

	// RVA: 0xFFFFFFFF75C716C8
	private static Single get_gravityModifierMultiplier_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C71708
	private static Void set_gravityModifierMultiplier_Injected(ref MainModule _unity_self, Single value) { }

	// RVA: 0xFFFFFFFF75C71758
	private static ParticleSystemSimulationSpace get_simulationSpace_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C71798
	private static Void set_simulationSpace_Injected(ref MainModule _unity_self, ParticleSystemSimulationSpace value) { }

	// RVA: 0xFFFFFFFF75C717E8
	private static Single get_simulationSpeed_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C71828
	private static Void set_simulationSpeed_Injected(ref MainModule _unity_self, Single value) { }

	// RVA: 0xFFFFFFFF75C71878
	private static Boolean get_useUnscaledTime_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C718B8
	private static ParticleSystemScalingMode get_scalingMode_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C718F8
	private static Void set_scalingMode_Injected(ref MainModule _unity_self, ParticleSystemScalingMode value) { }

	// RVA: 0xFFFFFFFF75C71948
	private static Boolean get_playOnAwake_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C71988
	private static Void set_playOnAwake_Injected(ref MainModule _unity_self, Boolean value) { }

	// RVA: 0xFFFFFFFF75C719D8
	private static Int32 get_maxParticles_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C71A18
	private static Void set_maxParticles_Injected(ref MainModule _unity_self, Int32 value) { }

	// RVA: 0xFFFFFFFF75C71AA8
	private static ParticleSystemCullingMode get_cullingMode_Injected(ref MainModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C71AE8
	private static Void set_cullingMode_Injected(ref MainModule _unity_self, ParticleSystemCullingMode value) { }

}

// Namespace: 
public struct EmissionModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Properties
	public Boolean enabled { get; set; }
	public MinMaxCurve rateOverTime { get; set; }
	public Single rateOverTimeMultiplier { get; }
	public Int32 burstCount { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114FA4C
	internal Void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0xFFFFFFFF7114FA84
	public Boolean get_enabled() { }

	// RVA: 0xFFFFFFFF7114FAC4
	public Void set_enabled(Boolean value) { }

	// RVA: 0xFFFFFFFF7114FB14
	public MinMaxCurve get_rateOverTime() { }

	// RVA: 0xFFFFFFFF7114FB80
	public Void set_rateOverTime(MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF7114FBD8
	public Single get_rateOverTimeMultiplier() { }

	// RVA: 0xFFFFFFFF7114FC18
	public Burst GetBurst(Int32 index) { }

	// RVA: 0xFFFFFFFF7114FCA4
	public Int32 get_burstCount() { }

	// RVA: 0xFFFFFFFF75C70500
	private static Boolean get_enabled_Injected(ref EmissionModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C70540
	private static Void set_enabled_Injected(ref EmissionModule _unity_self, Boolean value) { }

	// RVA: 0xFFFFFFFF75C70590
	private static Void get_rateOverTime_Injected(ref EmissionModule _unity_self, out MinMaxCurve ret) { }

	// RVA: 0xFFFFFFFF75C705E0
	private static Void set_rateOverTime_Injected(ref EmissionModule _unity_self, ref MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF75C70630
	private static Single get_rateOverTimeMultiplier_Injected(ref EmissionModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C70670
	private static Void GetBurst_Injected(ref EmissionModule _unity_self, Int32 index, out Burst ret) { }

	// RVA: 0xFFFFFFFF75C706C8
	private static Int32 get_burstCount_Injected(ref EmissionModule _unity_self) { }

}

// Namespace: 
public struct ShapeModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Properties
	public Boolean enabled { get; set; }
	public Vector3 position { get; set; }
	public Vector3 scale { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF71151828
	internal Void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0xFFFFFFFF71151860
	public Boolean get_enabled() { }

	// RVA: 0xFFFFFFFF711518A0
	public Void set_enabled(Boolean value) { }

	// RVA: 0xFFFFFFFF711518F0
	public Vector3 get_position() { }

	// RVA: 0xFFFFFFFF711518F8
	public Void set_position(Vector3 value) { }

	// RVA: 0xFFFFFFFF71151950
	public Vector3 get_scale() { }

	// RVA: 0xFFFFFFFF71151958
	public Void set_scale(Vector3 value) { }

	// RVA: 0xFFFFFFFF75C72648
	private static Boolean get_enabled_Injected(ref ShapeModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C726D8
	private static Void set_enabled_Injected(ref ShapeModule _unity_self, Boolean value) { }

	// RVA: 0xFFFFFFFF75C72788
	private static Void get_position_Injected(ref ShapeModule _unity_self, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C72830
	private static Void set_position_Injected(ref ShapeModule _unity_self, ref Vector3 value) { }

	// RVA: 0xFFFFFFFF75C728E0
	private static Void get_scale_Injected(ref ShapeModule _unity_self, out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C72988
	private static Void set_scale_Injected(ref ShapeModule _unity_self, ref Vector3 value) { }

}

// Namespace: 
public struct SubEmittersModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Properties
	public Int32 subEmittersCount { get; }

	// Methods

	// RVA: 0xFFFFFFFF71151C2C
	internal Void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0xFFFFFFFF71151C64
	public Int32 get_subEmittersCount() { }

	// RVA: 0xFFFFFFFF71151CA4
	public ParticleSystem GetSubEmitterSystem(Int32 index) { }

	// RVA: 0xFFFFFFFF75C72C90
	private static Int32 get_subEmittersCount_Injected(ref SubEmittersModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C72D20
	private static ParticleSystem GetSubEmitterSystem_Injected(ref SubEmittersModule _unity_self, Int32 index) { }

}

// Namespace: 
public struct TextureSheetAnimationModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Properties
	public Boolean enabled { get; }
	public Int32 numTilesX { get; }
	public Int32 numTilesY { get; }
	public ParticleSystemAnimationType animation { get; }
	public MinMaxCurve frameOverTime { get; set; }
	public MinMaxCurve startFrame { set; }
	public Int32 cycleCount { get; }
	public Int32 rowIndex { get; }

	// Methods

	// RVA: 0xFFFFFFFF71151D30
	internal Void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0xFFFFFFFF71151D68
	public Boolean get_enabled() { }

	// RVA: 0xFFFFFFFF71151DA8
	public Int32 get_numTilesX() { }

	// RVA: 0xFFFFFFFF71151DE8
	public Int32 get_numTilesY() { }

	// RVA: 0xFFFFFFFF71151E28
	public ParticleSystemAnimationType get_animation() { }

	// RVA: 0xFFFFFFFF71151E68
	public MinMaxCurve get_frameOverTime() { }

	// RVA: 0xFFFFFFFF71151ED4
	public Void set_frameOverTime(MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF71151F2C
	public Void set_startFrame(MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF71151F84
	public Int32 get_cycleCount() { }

	// RVA: 0xFFFFFFFF71151FC4
	public Int32 get_rowIndex() { }

	// RVA: 0xFFFFFFFF75C72DB0
	private static Boolean get_enabled_Injected(ref TextureSheetAnimationModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C72E30
	private static Int32 get_numTilesX_Injected(ref TextureSheetAnimationModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C72EB0
	private static Int32 get_numTilesY_Injected(ref TextureSheetAnimationModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C72F30
	private static ParticleSystemAnimationType get_animation_Injected(ref TextureSheetAnimationModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C72FDC
	private static Void get_frameOverTime_Injected(ref TextureSheetAnimationModule _unity_self, out MinMaxCurve ret) { }

	// RVA: 0xFFFFFFFF75C7307C
	private static Void set_frameOverTime_Injected(ref TextureSheetAnimationModule _unity_self, ref MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF75C7311C
	private static Void set_startFrame_Injected(ref TextureSheetAnimationModule _unity_self, ref MinMaxCurve value) { }

	// RVA: 0xFFFFFFFF75C731AC
	private static Int32 get_cycleCount_Injected(ref TextureSheetAnimationModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C7322C
	private static Int32 get_rowIndex_Injected(ref TextureSheetAnimationModule _unity_self) { }

}

// Namespace: 
public struct Particle
{
	// Fields
	private Vector3 m_Position; // 0x10
	private Vector3 m_Velocity; // 0x1C
	private Vector3 m_AnimatedVelocity; // 0x28
	private Vector3 m_InitialVelocity; // 0x34
	private Vector3 m_AxisOfRotation; // 0x40
	private Vector3 m_Rotation; // 0x4C
	private Vector3 m_AngularVelocity; // 0x58
	private Vector3 m_StartSize; // 0x64
	private Color32 m_StartColor; // 0x70
	private UInt32 m_RandomSeed; // 0x74
	private UInt32 m_ParentRandomSeed; // 0x78
	private Single m_Lifetime; // 0x7C
	private Single m_StartLifetime; // 0x80
	private Int32 m_MeshIndex; // 0x84
	private Single m_EmitAccumulator0; // 0x88
	private Single m_EmitAccumulator1; // 0x8C
	private UInt32 m_Flags; // 0x90

	// Properties
	public Single lifetime { set; }
	public Vector3 position { get; set; }
	public Vector3 velocity { set; }
	public Single remainingLifetime { get; set; }
	public Single startLifetime { get; set; }
	public Color32 startColor { set; }
	public UInt32 randomSeed { set; }
	public Single startSize { set; }
	public Single rotation { get; }
	public Vector3 rotation3D { get; set; }
	public Vector3 angularVelocity3D { set; }

	// Methods

	// RVA: 0xFFFFFFFF711513E8
	public Void set_lifetime(Single value) { }

	// RVA: 0xFFFFFFFF711513F0
	public Vector3 get_position() { }

	// RVA: 0xFFFFFFFF711513FC
	public Void set_position(Vector3 value) { }

	// RVA: 0xFFFFFFFF71151408
	public Void set_velocity(Vector3 value) { }

	// RVA: 0xFFFFFFFF71151414
	public Single get_remainingLifetime() { }

	// RVA: 0xFFFFFFFF7115141C
	public Void set_remainingLifetime(Single value) { }

	// RVA: 0xFFFFFFFF71151424
	public Single get_startLifetime() { }

	// RVA: 0xFFFFFFFF7115142C
	public Void set_startLifetime(Single value) { }

	// RVA: 0xFFFFFFFF71151434
	public Void set_startColor(Color32 value) { }

	// RVA: 0xFFFFFFFF7115143C
	public Void set_randomSeed(UInt32 value) { }

	// RVA: 0xFFFFFFFF71151444
	public Void set_startSize(Single value) { }

	// RVA: 0xFFFFFFFF71151494
	public Single get_rotation() { }

	// RVA: 0xFFFFFFFF711514A8
	public Vector3 get_rotation3D() { }

	// RVA: 0xFFFFFFFF711514B0
	public Void set_rotation3D(Vector3 value) { }

	// RVA: 0xFFFFFFFF711514B8
	public Void set_angularVelocity3D(Vector3 value) { }

	// RVA: 0xFFFFFFFF711514C0
	public Single GetCurrentSize(ParticleSystem system) { }

	// RVA: 0xFFFFFFFF71151518
	public Vector3 GetCurrentSize3D(ParticleSystem system) { }

	// RVA: 0xFFFFFFFF71151538
	public Color32 GetCurrentColor(ParticleSystem system) { }

}

// Namespace: 
public struct Burst
{
	// Fields
	private Single m_Time; // 0x10
	private MinMaxCurve m_Count; // 0x18
	private Int32 m_RepeatCount; // 0x38
	private Single m_RepeatInterval; // 0x3C
	private Single m_InvProbability; // 0x40

	// Properties
	public Single time { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114F838
	public Single get_time() { }

}

// Namespace: 
public struct MinMaxCurve
{
	// Fields
	private ParticleSystemCurveMode m_Mode; // 0x10
	private Single m_CurveMultiplier; // 0x14
	private AnimationCurve m_CurveMin; // 0x18
	private AnimationCurve m_CurveMax; // 0x20
	private Single m_ConstantMin; // 0x28
	private Single m_ConstantMax; // 0x2C

	// Properties
	public ParticleSystemCurveMode mode { get; }
	public AnimationCurve curveMax { get; }
	public AnimationCurve curveMin { get; }
	public Single constantMax { get; }
	public Single constantMin { get; }
	public Single constant { get; set; }
	public AnimationCurve curve { get; }

	// Methods

	// RVA: 0xFFFFFFFF711510CC
	public Void .ctor(Single constant) { }

	// RVA: 0xFFFFFFFF71151130
	public ParticleSystemCurveMode get_mode() { }

	// RVA: 0xFFFFFFFF71151138
	public AnimationCurve get_curveMax() { }

	// RVA: 0xFFFFFFFF71151140
	public AnimationCurve get_curveMin() { }

	// RVA: 0xFFFFFFFF71151148
	public Single get_constantMax() { }

	// RVA: 0xFFFFFFFF71151150
	public Single get_constantMin() { }

	// RVA: 0xFFFFFFFF71151158
	public Single get_constant() { }

	// RVA: 0xFFFFFFFF71151160
	public Void set_constant(Single value) { }

	// RVA: 0xFFFFFFFF71151168
	public AnimationCurve get_curve() { }

	// RVA: 0xFFFFFFFF71151170
	public Single Evaluate(Single time) { }

	// RVA: 0xFFFFFFFF7115117C
	public Single Evaluate(Single time, Single lerpFactor) { }

	// RVA: 0xFFFFFFFF723D4E64
	public static MinMaxCurve op_Implicit(Single constant) { }

}

// Namespace: 
public struct MinMaxGradient
{
	// Fields
	private ParticleSystemGradientMode m_Mode; // 0x10
	private Gradient m_GradientMin; // 0x18
	private Gradient m_GradientMax; // 0x20
	private Color m_ColorMin; // 0x28
	private Color m_ColorMax; // 0x38

	// Properties
	public ParticleSystemGradientMode mode { get; set; }
	public Gradient gradientMax { get; set; }
	public Gradient gradientMin { get; set; }
	public Color colorMax { get; set; }
	public Color colorMin { get; set; }
	public Color color { get; set; }
	public Gradient gradient { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF71151184
	public Void .ctor(Color color) { }

	// RVA: 0xFFFFFFFF7115118C
	public Void .ctor(Gradient gradient) { }

	// RVA: 0xFFFFFFFF71151194
	public Void .ctor(Color min, Color max) { }

	// RVA: 0xFFFFFFFF71151240
	public Void .ctor(Gradient min, Gradient max) { }

	// RVA: 0xFFFFFFFF71151248
	public ParticleSystemGradientMode get_mode() { }

	// RVA: 0xFFFFFFFF71151250
	public Void set_mode(ParticleSystemGradientMode value) { }

	// RVA: 0xFFFFFFFF71151258
	public Gradient get_gradientMax() { }

	// RVA: 0xFFFFFFFF71151260
	public Void set_gradientMax(Gradient value) { }

	// RVA: 0xFFFFFFFF71151298
	public Gradient get_gradientMin() { }

	// RVA: 0xFFFFFFFF711512A0
	public Void set_gradientMin(Gradient value) { }

	// RVA: 0xFFFFFFFF711512D8
	public Color get_colorMax() { }

	// RVA: 0xFFFFFFFF711512E4
	public Void set_colorMax(Color value) { }

	// RVA: 0xFFFFFFFF711512F0
	public Color get_colorMin() { }

	// RVA: 0xFFFFFFFF711512FC
	public Void set_colorMin(Color value) { }

	// RVA: 0xFFFFFFFF71151308
	public Color get_color() { }

	// RVA: 0xFFFFFFFF71151314
	public Void set_color(Color value) { }

	// RVA: 0xFFFFFFFF71151320
	public Gradient get_gradient() { }

	// RVA: 0xFFFFFFFF71151328
	public Void set_gradient(Gradient value) { }

	// RVA: 0xFFFFFFFF71151360
	public Color Evaluate(Single time) { }

	// RVA: 0xFFFFFFFF7115136C
	public Color Evaluate(Single time, Single lerpFactor) { }

	// RVA: 0xFFFFFFFF75C6D7BC
	public static MinMaxGradient op_Implicit(Color color) { }

}

// Namespace: 
public struct EmitParams
{
	// Fields
	private Particle m_Particle; // 0x10
	private Boolean m_PositionSet; // 0x94
	private Boolean m_VelocitySet; // 0x95
	private Boolean m_AxisOfRotationSet; // 0x96
	private Boolean m_RotationSet; // 0x97
	private Boolean m_AngularVelocitySet; // 0x98
	private Boolean m_StartSizeSet; // 0x99
	private Boolean m_StartColorSet; // 0x9A
	private Boolean m_RandomSeedSet; // 0x9B
	private Boolean m_StartLifetimeSet; // 0x9C
	private Boolean m_MeshIndexSet; // 0x9D
	private Boolean m_ApplyShapeToPosition; // 0x9E
}

// Namespace: 
public struct PlaybackState
{
	// Fields
	internal Single m_AccumulatedDt; // 0x10
	internal Single m_StartDelay; // 0x14
	internal Single m_PlaybackTime; // 0x18
	internal Int32 m_RingBufferIndex; // 0x1C
	internal Emission m_Emission; // 0x20
	internal Initial m_Initial; // 0x38
	internal Shape m_Shape; // 0x78
	internal Force m_Force; // 0xD4
	internal Collision m_Collision; // 0x114
	internal Noise m_Noise; // 0x154
	internal Lights m_Lights; // 0x158
	internal Trail m_Trail; // 0x16C
}

// Namespace: 
internal struct Seed
{
	// Fields
	public UInt32 x; // 0x10
	public UInt32 y; // 0x14
	public UInt32 z; // 0x18
	public UInt32 w; // 0x1C
}

// Namespace: 
internal struct Seed4
{
	// Fields
	public Seed x; // 0x10
	public Seed y; // 0x20
	public Seed z; // 0x30
	public Seed w; // 0x40
}

// Namespace: 
internal struct Emission
{
	// Fields
	public Single m_ParticleSpacing; // 0x10
	public Single m_ToEmitAccumulator; // 0x14
	public Seed m_Random; // 0x18
}

// Namespace: 
internal struct Initial
{
	// Fields
	public Seed4 m_Random; // 0x10
}

// Namespace: 
internal struct Shape
{
	// Fields
	public Seed4 m_Random; // 0x10
	public Single m_RadiusTimer; // 0x50
	public Single m_RadiusTimerPrev; // 0x54
	public Single m_ArcTimer; // 0x58
	public Single m_ArcTimerPrev; // 0x5C
	public Single m_MeshSpawnTimer; // 0x60
	public Single m_MeshSpawnTimerPrev; // 0x64
	public Int32 m_OrderedMeshVertexIndex; // 0x68
}

// Namespace: 
internal struct Force
{
	// Fields
	public Seed4 m_Random; // 0x10
}

// Namespace: 
internal struct Collision
{
	// Fields
	public Seed4 m_Random; // 0x10
}

// Namespace: 
internal struct Noise
{
	// Fields
	public Single m_ScrollOffset; // 0x10
}

// Namespace: 
internal struct Lights
{
	// Fields
	public Seed m_Random; // 0x10
	public Single m_ParticleEmissionCounter; // 0x20
}

// Namespace: 
internal struct Trail
{
	// Fields
	public Single m_Timer; // 0x10
}

// Namespace: 
public struct Trails
{
	// Fields
	internal List<T0> positions; // 0x10
	internal List<T0> frontPositions; // 0x18
	internal List<T0> backPositions; // 0x20
	internal List<T0> positionCounts; // 0x28
	internal Int32 maxTrailCount; // 0x30
	internal Int32 maxPositionsPerTrailCount; // 0x34
}

// Namespace: 
public struct VelocityOverLifetimeModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF711521A4
	internal Void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct LimitVelocityOverLifetimeModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114FFDC
	internal Void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct InheritVelocityModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114FEF4
	internal Void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct ForceOverLifetimeModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114FE80
	internal Void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct ColorOverLifetimeModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114F964
	internal Void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct ColorBySpeedModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114F8F0
	internal Void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct SizeOverLifetimeModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Properties
	public Boolean enabled { get; }
	public MinMaxCurve x { get; }
	public MinMaxCurve y { get; }
	public Boolean separateAxes { get; }

	// Methods

	// RVA: 0xFFFFFFFF71151A60
	internal Void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0xFFFFFFFF71151A98
	public Boolean get_enabled() { }

	// RVA: 0xFFFFFFFF71151AD8
	public MinMaxCurve get_x() { }

	// RVA: 0xFFFFFFFF71151B44
	public MinMaxCurve get_y() { }

	// RVA: 0xFFFFFFFF71151BB0
	public Boolean get_separateAxes() { }

	// RVA: 0xFFFFFFFF75C72A18
	private static Boolean get_enabled_Injected(ref SizeOverLifetimeModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C72AC4
	private static Void get_x_Injected(ref SizeOverLifetimeModule _unity_self, out MinMaxCurve ret) { }

	// RVA: 0xFFFFFFFF75C72B80
	private static Void get_y_Injected(ref SizeOverLifetimeModule _unity_self, out MinMaxCurve ret) { }

	// RVA: 0xFFFFFFFF75C72C10
	private static Boolean get_separateAxes_Injected(ref SizeOverLifetimeModule _unity_self) { }

}

// Namespace: 
public struct SizeBySpeedModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF711519EC
	internal Void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct RotationOverLifetimeModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Properties
	public Boolean enabled { get; }
	public MinMaxCurve x { get; }
	public MinMaxCurve y { get; }
	public MinMaxCurve z { get; }
	public Boolean separateAxes { get; }

	// Methods

	// RVA: 0xFFFFFFFF711515F0
	internal Void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0xFFFFFFFF71151628
	public Boolean get_enabled() { }

	// RVA: 0xFFFFFFFF71151668
	public MinMaxCurve get_x() { }

	// RVA: 0xFFFFFFFF711516D4
	public MinMaxCurve get_y() { }

	// RVA: 0xFFFFFFFF71151740
	public MinMaxCurve get_z() { }

	// RVA: 0xFFFFFFFF711517AC
	public Boolean get_separateAxes() { }

	// RVA: 0xFFFFFFFF75C72314
	private static Boolean get_enabled_Injected(ref RotationOverLifetimeModule _unity_self) { }

	// RVA: 0xFFFFFFFF75C723C0
	private static Void get_x_Injected(ref RotationOverLifetimeModule _unity_self, out MinMaxCurve ret) { }

	// RVA: 0xFFFFFFFF75C7247C
	private static Void get_y_Injected(ref RotationOverLifetimeModule _unity_self, out MinMaxCurve ret) { }

	// RVA: 0xFFFFFFFF75C72538
	private static Void get_z_Injected(ref RotationOverLifetimeModule _unity_self, out MinMaxCurve ret) { }

	// RVA: 0xFFFFFFFF75C725C8
	private static Boolean get_separateAxes_Injected(ref RotationOverLifetimeModule _unity_self) { }

}

// Namespace: 
public struct RotationBySpeedModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7115157C
	internal Void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct ExternalForcesModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114FE0C
	internal Void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct NoiseModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF711513B0
	internal Void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct CollisionModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114F87C
	internal Void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct TriggerModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF71152130
	internal Void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct LightsModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114FF68
	internal Void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct TrailModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Properties
	public Boolean enabled { get; }

	// Methods

	// RVA: 0xFFFFFFFF71152040
	internal Void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0xFFFFFFFF71152078
	public Boolean get_enabled() { }

	// RVA: 0xFFFFFFFF75C7326C
	private static Boolean get_enabled_Injected(ref TrailModule _unity_self) { }

}

// Namespace: 
public struct CustomDataModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114F9D8
	internal Void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: UnityEngine
public enum ParticleSystemRenderMode
{
	// Fields
	public Int32 value__; // 0x10
	public const ParticleSystemRenderMode Billboard = 0;
	public const ParticleSystemRenderMode Stretch = 1;
	public const ParticleSystemRenderMode HorizontalBillboard = 2;
	public const ParticleSystemRenderMode VerticalBillboard = 3;
	public const ParticleSystemRenderMode Mesh = 4;
	public const ParticleSystemRenderMode None = 5;
}

// Namespace: UnityEngine
public enum ParticleSystemSortMode
{
	// Fields
	public Int32 value__; // 0x10
	public const ParticleSystemSortMode None = 0;
	public const ParticleSystemSortMode Distance = 1;
	public const ParticleSystemSortMode OldestInFront = 2;
	public const ParticleSystemSortMode YoungestInFront = 3;
}

// Namespace: UnityEngine
public enum ParticleSystemRenderSpace
{
	// Fields
	public Int32 value__; // 0x10
	public const ParticleSystemRenderSpace View = 0;
	public const ParticleSystemRenderSpace World = 1;
	public const ParticleSystemRenderSpace Local = 2;
	public const ParticleSystemRenderSpace Facing = 3;
	public const ParticleSystemRenderSpace Velocity = 4;
}

// Namespace: UnityEngine
public enum ParticleSystemCurveMode
{
	// Fields
	public Int32 value__; // 0x10
	public const ParticleSystemCurveMode Constant = 0;
	public const ParticleSystemCurveMode Curve = 1;
	public const ParticleSystemCurveMode TwoCurves = 2;
	public const ParticleSystemCurveMode TwoConstants = 3;
}

// Namespace: UnityEngine
public enum ParticleSystemGradientMode
{
	// Fields
	public Int32 value__; // 0x10
	public const ParticleSystemGradientMode Color = 0;
	public const ParticleSystemGradientMode Gradient = 1;
	public const ParticleSystemGradientMode TwoColors = 2;
	public const ParticleSystemGradientMode TwoGradients = 3;
	public const ParticleSystemGradientMode RandomColor = 4;
}

// Namespace: UnityEngine
public enum ParticleSystemAnimationType
{
	// Fields
	public Int32 value__; // 0x10
	public const ParticleSystemAnimationType WholeSheet = 0;
	public const ParticleSystemAnimationType SingleRow = 1;
}

// Namespace: UnityEngine
public enum ParticleSystemSimulationSpace
{
	// Fields
	public Int32 value__; // 0x10
	public const ParticleSystemSimulationSpace Local = 0;
	public const ParticleSystemSimulationSpace World = 1;
	public const ParticleSystemSimulationSpace Custom = 2;
}

// Namespace: UnityEngine
public enum ParticleSystemStopBehavior
{
	// Fields
	public Int32 value__; // 0x10
	public const ParticleSystemStopBehavior StopEmittingAndClear = 0;
	public const ParticleSystemStopBehavior StopEmitting = 1;
}

// Namespace: UnityEngine
public enum ParticleSystemScalingMode
{
	// Fields
	public Int32 value__; // 0x10
	public const ParticleSystemScalingMode Hierarchy = 0;
	public const ParticleSystemScalingMode Local = 1;
	public const ParticleSystemScalingMode Shape = 2;
}

// Namespace: UnityEngine
public enum ParticleSystemCullingMode
{
	// Fields
	public Int32 value__; // 0x10
	public const ParticleSystemCullingMode Automatic = 0;
	public const ParticleSystemCullingMode PauseAndCatchup = 1;
	public const ParticleSystemCullingMode Pause = 2;
	public const ParticleSystemCullingMode AlwaysSimulate = 3;
}

// Namespace: UnityEngine
public enum ParticleSystemVertexStream
{
	// Fields
	public Int32 value__; // 0x10
	public const ParticleSystemVertexStream Position = 0;
	public const ParticleSystemVertexStream Normal = 1;
	public const ParticleSystemVertexStream Tangent = 2;
	public const ParticleSystemVertexStream Color = 3;
	public const ParticleSystemVertexStream UV = 4;
	public const ParticleSystemVertexStream UV2 = 5;
	public const ParticleSystemVertexStream UV3 = 6;
	public const ParticleSystemVertexStream UV4 = 7;
	public const ParticleSystemVertexStream AnimBlend = 8;
	public const ParticleSystemVertexStream AnimFrame = 9;
	public const ParticleSystemVertexStream Center = 10;
	public const ParticleSystemVertexStream VertexID = 11;
	public const ParticleSystemVertexStream SizeX = 12;
	public const ParticleSystemVertexStream SizeXY = 13;
	public const ParticleSystemVertexStream SizeXYZ = 14;
	public const ParticleSystemVertexStream Rotation = 15;
	public const ParticleSystemVertexStream Rotation3D = 16;
	public const ParticleSystemVertexStream RotationSpeed = 17;
	public const ParticleSystemVertexStream RotationSpeed3D = 18;
	public const ParticleSystemVertexStream Velocity = 19;
	public const ParticleSystemVertexStream Speed = 20;
	public const ParticleSystemVertexStream AgePercent = 21;
	public const ParticleSystemVertexStream InvStartLifetime = 22;
	public const ParticleSystemVertexStream StableRandomX = 23;
	public const ParticleSystemVertexStream StableRandomXY = 24;
	public const ParticleSystemVertexStream StableRandomXYZ = 25;
	public const ParticleSystemVertexStream StableRandomXYZW = 26;
	public const ParticleSystemVertexStream VaryingRandomX = 27;
	public const ParticleSystemVertexStream VaryingRandomXY = 28;
	public const ParticleSystemVertexStream VaryingRandomXYZ = 29;
	public const ParticleSystemVertexStream VaryingRandomXYZW = 30;
	public const ParticleSystemVertexStream Custom1X = 31;
	public const ParticleSystemVertexStream Custom1XY = 32;
	public const ParticleSystemVertexStream Custom1XYZ = 33;
	public const ParticleSystemVertexStream Custom1XYZW = 34;
	public const ParticleSystemVertexStream Custom2X = 35;
	public const ParticleSystemVertexStream Custom2XY = 36;
	public const ParticleSystemVertexStream Custom2XYZ = 37;
	public const ParticleSystemVertexStream Custom2XYZW = 38;
	public const ParticleSystemVertexStream NoiseSumX = 39;
	public const ParticleSystemVertexStream NoiseSumXY = 40;
	public const ParticleSystemVertexStream NoiseSumXYZ = 41;
	public const ParticleSystemVertexStream NoiseImpulseX = 42;
	public const ParticleSystemVertexStream NoiseImpulseXY = 43;
	public const ParticleSystemVertexStream NoiseImpulseXYZ = 44;
	public const ParticleSystemVertexStream MeshIndex = 45;
}

// Namespace: UnityEngine
public enum ParticleSystemCustomData
{
	// Fields
	public Int32 value__; // 0x10
	public const ParticleSystemCustomData Custom1 = 0;
	public const ParticleSystemCustomData Custom2 = 1;
}

// Namespace: UnityEngine
public enum ParticleSystemVertexStreams
{
	// Fields
	public Int32 value__; // 0x10
	public const ParticleSystemVertexStreams Position = 1;
	public const ParticleSystemVertexStreams Normal = 2;
	public const ParticleSystemVertexStreams Tangent = 4;
	public const ParticleSystemVertexStreams Color = 8;
	public const ParticleSystemVertexStreams UV = 16;
	public const ParticleSystemVertexStreams UV2BlendAndFrame = 32;
	public const ParticleSystemVertexStreams CenterAndVertexID = 64;
	public const ParticleSystemVertexStreams Size = 128;
	public const ParticleSystemVertexStreams Rotation = 256;
	public const ParticleSystemVertexStreams Velocity = 512;
	public const ParticleSystemVertexStreams Lifetime = 1024;
	public const ParticleSystemVertexStreams Custom1 = 2048;
	public const ParticleSystemVertexStreams Custom2 = 4096;
	public const ParticleSystemVertexStreams Random = 8192;
	public const ParticleSystemVertexStreams None = 0;
	public const ParticleSystemVertexStreams All = 2147483647;
}

// Namespace: UnityEngine
public sealed class ParticleSystemRenderer
{
	// Properties
	public ParticleSystemRenderSpace alignment { get; set; }
	public ParticleSystemRenderMode renderMode { get; set; }
	public ParticleSystemSortMode sortMode { get; set; }
	public Single lengthScale { get; set; }
	public Single velocityScale { get; set; }
	public Single cameraVelocityScale { get; set; }
	public Single normalDirection { get; set; }
	public Single shadowBias { get; set; }
	public Single sortingFudge { get; set; }
	public Single minParticleSize { get; set; }
	public Single maxParticleSize { get; set; }
	public Vector3 pivot { get; set; }
	public Vector3 flip { get; set; }
	public SpriteMaskInteraction maskInteraction { get; set; }
	public Material trailMaterial { get; set; }
	public Boolean enableGPUInstancing { get; set; }
	public Boolean allowRoll { get; set; }
	public Mesh mesh { get; set; }
	public Int32 meshCount { get; }
	public Int32 activeVertexStreamsCount { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C732AC
	public Void EnableVertexStreams(ParticleSystemVertexStreams streams) { }

	// RVA: 0xFFFFFFFF75C738A4
	public Void DisableVertexStreams(ParticleSystemVertexStreams streams) { }

	// RVA: 0xFFFFFFFF75C738AC
	public Boolean AreVertexStreamsEnabled(ParticleSystemVertexStreams streams) { }

	// RVA: 0xFFFFFFFF75C73B34
	public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	// RVA: 0xFFFFFFFF75C732B4
	internal Void Internal_SetVertexStreams(ParticleSystemVertexStreams streams, Boolean enabled) { }

	// RVA: 0xFFFFFFFF75C738D4
	internal ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	// RVA: 0xFFFFFFFF75C73C18
	public ParticleSystemRenderSpace get_alignment() { }

	// RVA: 0xFFFFFFFF75C73C58
	public Void set_alignment(ParticleSystemRenderSpace value) { }

	// RVA: 0xFFFFFFFF75C73CA8
	public ParticleSystemRenderMode get_renderMode() { }

	// RVA: 0xFFFFFFFF75C73CE8
	public Void set_renderMode(ParticleSystemRenderMode value) { }

	// RVA: 0xFFFFFFFF75C73D38
	public ParticleSystemSortMode get_sortMode() { }

	// RVA: 0xFFFFFFFF75C73D78
	public Void set_sortMode(ParticleSystemSortMode value) { }

	// RVA: 0xFFFFFFFF75C73DC8
	public Single get_lengthScale() { }

	// RVA: 0xFFFFFFFF75C73E08
	public Void set_lengthScale(Single value) { }

	// RVA: 0xFFFFFFFF75C73E58
	public Single get_velocityScale() { }

	// RVA: 0xFFFFFFFF75C73E98
	public Void set_velocityScale(Single value) { }

	// RVA: 0xFFFFFFFF75C73EE8
	public Single get_cameraVelocityScale() { }

	// RVA: 0xFFFFFFFF75C73F28
	public Void set_cameraVelocityScale(Single value) { }

	// RVA: 0xFFFFFFFF75C73F78
	public Single get_normalDirection() { }

	// RVA: 0xFFFFFFFF75C73FB8
	public Void set_normalDirection(Single value) { }

	// RVA: 0xFFFFFFFF75C74008
	public Single get_shadowBias() { }

	// RVA: 0xFFFFFFFF75C74048
	public Void set_shadowBias(Single value) { }

	// RVA: 0xFFFFFFFF723D571C
	public Single get_sortingFudge() { }

	// RVA: 0xFFFFFFFF723D5770
	public Void set_sortingFudge(Single value) { }

	// RVA: 0xFFFFFFFF75C74098
	public Single get_minParticleSize() { }

	// RVA: 0xFFFFFFFF75C740D8
	public Void set_minParticleSize(Single value) { }

	// RVA: 0xFFFFFFFF75C74128
	public Single get_maxParticleSize() { }

	// RVA: 0xFFFFFFFF75C74168
	public Void set_maxParticleSize(Single value) { }

	// RVA: 0xFFFFFFFF75C741B8
	public Vector3 get_pivot() { }

	// RVA: 0xFFFFFFFF75C74268
	public Void set_pivot(Vector3 value) { }

	// RVA: 0xFFFFFFFF75C74310
	public Vector3 get_flip() { }

	// RVA: 0xFFFFFFFF75C743C0
	public Void set_flip(Vector3 value) { }

	// RVA: 0xFFFFFFFF75C74468
	public SpriteMaskInteraction get_maskInteraction() { }

	// RVA: 0xFFFFFFFF75C744A8
	public Void set_maskInteraction(SpriteMaskInteraction value) { }

	// RVA: 0xFFFFFFFF75C744F8
	public Material get_trailMaterial() { }

	// RVA: 0xFFFFFFFF75C74538
	public Void set_trailMaterial(Material value) { }

	// RVA: 0xFFFFFFFF75C74588
	public Boolean get_enableGPUInstancing() { }

	// RVA: 0xFFFFFFFF75C745C8
	public Void set_enableGPUInstancing(Boolean value) { }

	// RVA: 0xFFFFFFFF75C74618
	public Boolean get_allowRoll() { }

	// RVA: 0xFFFFFFFF75C74658
	public Void set_allowRoll(Boolean value) { }

	// RVA: 0xFFFFFFFF75C746A8
	public Mesh get_mesh() { }

	// RVA: 0xFFFFFFFF75C746E8
	public Void set_mesh(Mesh value) { }

	// RVA: 0xFFFFFFFF75C74738
	public Int32 GetMeshes([Out] Mesh[] meshes) { }

	// RVA: 0xFFFFFFFF75C74788
	public Void SetMeshes(Mesh[] meshes, Int32 size) { }

	// RVA: 0xFFFFFFFF75C747E0
	public Void SetMeshes(Mesh[] meshes) { }

	// RVA: 0xFFFFFFFF75C74840
	public Int32 get_meshCount() { }

	// RVA: 0xFFFFFFFF75C74880
	public Void BakeMesh(Mesh mesh, Boolean useTransform) { }

	// RVA: 0xFFFFFFFF75C748F0
	public Void BakeMesh(Mesh mesh, Camera camera, Boolean useTransform) { }

	// RVA: 0xFFFFFFFF75C74958
	public Void BakeTrailsMesh(Mesh mesh, Boolean useTransform) { }

	// RVA: 0xFFFFFFFF75C749C8
	public Void BakeTrailsMesh(Mesh mesh, Camera camera, Boolean useTransform) { }

	// RVA: 0xFFFFFFFF75C73B38
	public Int32 get_activeVertexStreamsCount() { }

	// RVA: 0xFFFFFFFF75C73BC8
	public Void SetActiveVertexStreams(List<T0> streams) { }

	// RVA: 0xFFFFFFFF75C73B78
	public Void GetActiveVertexStreams(List<T0> streams) { }

	// RVA: 0xFFFFFFFF75C74A30
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C74218
	private Void get_pivot_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C742C0
	private Void set_pivot_Injected(ref Vector3 value) { }

	// RVA: 0xFFFFFFFF75C74370
	private Void get_flip_Injected(out Vector3 ret) { }

	// RVA: 0xFFFFFFFF75C74418
	private Void set_flip_Injected(ref Vector3 value) { }

}

// Namespace: UnityEngine.ParticleSystemJobs
internal struct NativeParticleData
{
	// Fields
	internal Int32 count; // 0x10
	internal Array3 positions; // 0x18
	internal Array3 velocities; // 0x30
	internal Array3 rotations; // 0x48
	internal Array3 rotationalSpeeds; // 0x60
	internal Array3 sizes; // 0x78
	internal Void* startColors; // 0x90
	internal Void* aliveTimePercent; // 0x98
	internal Void* inverseStartLifetimes; // 0xA0
	internal Void* randomSeeds; // 0xA8
	internal Array4 customData1; // 0xB0
	internal Array4 customData2; // 0xD0
}

// Namespace: 
internal struct Array3
{
	// Fields
	internal Single* x; // 0x10
	internal Single* y; // 0x18
	internal Single* z; // 0x20
}

// Namespace: 
internal struct Array4
{
	// Fields
	internal Single* x; // 0x10
	internal Single* y; // 0x18
	internal Single* z; // 0x20
	internal Single* w; // 0x28
}


