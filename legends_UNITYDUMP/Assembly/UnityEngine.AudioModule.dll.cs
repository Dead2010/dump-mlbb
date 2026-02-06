// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public enum AudioVelocityUpdateMode
{
	// Fields
	public Int32 value__; // 0x10
	public const AudioVelocityUpdateMode Auto = 0;
	public const AudioVelocityUpdateMode Fixed = 1;
	public const AudioVelocityUpdateMode Dynamic = 2;
}

// Namespace: UnityEngine
public enum FFTWindow
{
	// Fields
	public Int32 value__; // 0x10
	public const FFTWindow Rectangular = 0;
	public const FFTWindow Triangle = 1;
	public const FFTWindow Hamming = 2;
	public const FFTWindow Hanning = 3;
	public const FFTWindow Blackman = 4;
	public const FFTWindow BlackmanHarris = 5;
}

// Namespace: UnityEngine
public enum AudioRolloffMode
{
	// Fields
	public Int32 value__; // 0x10
	public const AudioRolloffMode Logarithmic = 0;
	public const AudioRolloffMode Linear = 1;
	public const AudioRolloffMode Custom = 2;
}

// Namespace: UnityEngine
public enum AudioSourceCurveType
{
	// Fields
	public Int32 value__; // 0x10
	public const AudioSourceCurveType CustomRolloff = 0;
	public const AudioSourceCurveType SpatialBlend = 1;
	public const AudioSourceCurveType ReverbZoneMix = 2;
	public const AudioSourceCurveType Spread = 3;
}

// Namespace: UnityEngine
public sealed class AudioSettings
{
	// Fields
	private static AudioConfigurationChangeHandler OnAudioConfigurationChanged; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF75BEAEC4
	internal static Void InvokeOnAudioConfigurationChanged(Boolean deviceWasChanged) { }

	// RVA: 0xFFFFFFFF75BEB194
	internal static Boolean StartAudioOutput() { }

	// RVA: 0xFFFFFFFF75BEB1C8
	internal static Boolean StopAudioOutput() { }

}

// Namespace: 
public sealed class AudioConfigurationChangeHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75BEB1FC
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75BEAF24
	public virtual Void Invoke(Boolean deviceWasChanged) { }

	// RVA: 0xFFFFFFFF75BEB210
	public virtual IAsyncResult BeginInvoke(Boolean deviceWasChanged, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BEB2A0
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public static class Mobile
{
	// Fields
	private static Boolean <muteState>k__BackingField; // 0x0
	private static Boolean _stopAudioOutputOnMute; // 0x1
	private static Action<T0> OnMuteStateChanged; // 0x8

	// Properties
	public static Boolean muteState { get; set; }
	public static Boolean stopAudioOutputOnMute { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BEB2AC
	public static Boolean get_muteState() { }

	// RVA: 0xFFFFFFFF75BEB30C
	private static Void set_muteState(Boolean value) { }

	// RVA: 0xFFFFFFFF75BEB370
	public static Boolean get_stopAudioOutputOnMute() { }

	// RVA: 0xFFFFFFFF75BEB3D8
	internal static Void InvokeOnMuteStateChanged(Boolean mute) { }

	// RVA: 0xFFFFFFFF75BEB5F8
	public static Void StartAudioOutput() { }

	// RVA: 0xFFFFFFFF75BEB5C4
	public static Void StopAudioOutput() { }

	// RVA: 0xFFFFFFFF75BEB62C
	private static Void .cctor() { }

}

// Namespace: UnityEngine
public sealed class AudioClip
{
	// Fields
	private PCMReaderCallback m_PCMReaderCallback; // 0x18
	private PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	// Properties
	public Single length { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BEA358
	private Void .ctor() { }

	// RVA: 0xFFFFFFFF75BEA3B4
	public Single get_length() { }

	// RVA: 0xFFFFFFFF75BEA3F4
	private Void InvokePCMReaderCallback_Internal(Single[] data) { }

	// RVA: 0xFFFFFFFF75BEA794
	private Void InvokePCMSetPositionCallback_Internal(Int32 position) { }

}

// Namespace: 
public sealed class PCMReaderCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75BEA9F8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75BEA404
	public virtual Void Invoke(Single[] data) { }

	// RVA: 0xFFFFFFFF75BEAA0C
	public virtual IAsyncResult BeginInvoke(Single[] data, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BEAA5C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class PCMSetPositionCallback
{
	// Methods

	// RVA: 0xFFFFFFFF75BEAA68
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75BEA7A4
	public virtual Void Invoke(Int32 position) { }

	// RVA: 0xFFFFFFFF75BEAA7C
	public virtual IAsyncResult BeginInvoke(Int32 position, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BEAB0C
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine
public class AudioBehaviour
{
	// Methods

	// RVA: 0xFFFFFFFF75BEA350
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioListener
{
	// Properties
	public static Single volume { get; set; }
	public static Boolean pause { get; set; }
	public AudioVelocityUpdateMode velocityUpdateMode { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75BEAB18
	private static Void GetOutputDataHelper([Out] Single[] samples, Int32 channel) { }

	// RVA: 0xFFFFFFFF75BEAB68
	private static Void GetSpectrumDataHelper([Out] Single[] samples, Int32 channel, FFTWindow window) { }

	// RVA: 0xFFFFFFFF75BEABC0
	public static Single get_volume() { }

	// RVA: 0xFFFFFFFF75BEABF4
	public static Void set_volume(Single value) { }

	// RVA: 0xFFFFFFFF75BEAC38
	public static Boolean get_pause() { }

	// RVA: 0xFFFFFFFF75BEAC6C
	public static Void set_pause(Boolean value) { }

	// RVA: 0xFFFFFFFF75BEACAC
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0xFFFFFFFF75BEACEC
	public Void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0xFFFFFFFF75BEAD3C
	public static Single[] GetOutputData(Int32 numSamples, Int32 channel) { }

	// RVA: 0xFFFFFFFF75BEADA4
	public static Void GetOutputData(Single[] samples, Int32 channel) { }

	// RVA: 0xFFFFFFFF75BEADF4
	public static Single[] GetSpectrumData(Int32 numSamples, Int32 channel, FFTWindow window) { }

	// RVA: 0xFFFFFFFF75BEAE64
	public static Void GetSpectrumData(Single[] samples, Int32 channel, FFTWindow window) { }

	// RVA: 0xFFFFFFFF75BEAEBC
	public Void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioSource
{
	// Properties
	public Single volume { get; set; }
	public Single pitch { get; set; }
	public Single time { get; set; }
	public Int32 timeSamples { get; set; }
	public AudioClip clip { get; set; }
	public AudioMixerGroup outputAudioMixerGroup { get; set; }
	public Boolean isPlaying { get; }
	public Boolean isVirtual { get; }
	public Boolean loop { get; set; }
	public Boolean ignoreListenerVolume { get; set; }
	public Boolean playOnAwake { get; set; }
	public Boolean ignoreListenerPause { get; set; }
	public AudioVelocityUpdateMode velocityUpdateMode { get; set; }
	public Single panStereo { get; set; }
	public Single spatialBlend { get; set; }
	public Boolean spatialize { get; set; }
	public Boolean spatializePostEffects { get; set; }
	public Single reverbZoneMix { get; set; }
	public Boolean bypassEffects { get; set; }
	public Boolean bypassListenerEffects { get; set; }
	public Boolean bypassReverbZones { get; set; }
	public Single dopplerLevel { get; set; }
	public Single spread { get; set; }
	public Int32 priority { get; set; }
	public Boolean mute { get; set; }
	public Single minDistance { get; set; }
	public Single maxDistance { get; set; }
	public AudioRolloffMode rolloffMode { get; set; }
	public Single minVolume { get; set; }
	public Single maxVolume { get; set; }
	public Single rolloffFactor { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75BEB674
	private static Single GetPitch(AudioSource source) { }

	// RVA: 0xFFFFFFFF75BEB6B4
	private static Void SetPitch(AudioSource source, Single pitch) { }

	// RVA: 0xFFFFFFFF75BEB704
	private static Void PlayHelper(AudioSource source, UInt64 delay) { }

	// RVA: 0xFFFFFFFF75BEB754
	private Void Play(Double delay) { }

	// RVA: 0xFFFFFFFF75BEB7A4
	private static Void PlayOneShotHelper(AudioSource source, AudioClip clip, Single volumeScale) { }

	// RVA: 0xFFFFFFFF75BEB804
	private Void Stop(Boolean stopOneShots) { }

	// RVA: 0xFFFFFFFF75BEB854
	private static Void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0xFFFFFFFF75BEB8AC
	private static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type) { }

	// RVA: 0xFFFFFFFF75BEB8FC
	private static Void GetOutputDataHelper(AudioSource source, [Out] Single[] samples, Int32 channel) { }

	// RVA: 0xFFFFFFFF75BEB954
	private static Void GetSpectrumDataHelper(AudioSource source, [Out] Single[] samples, Int32 channel, FFTWindow window) { }

	// RVA: 0xFFFFFFFF75BEB9BC
	public Single get_volume() { }

	// RVA: 0xFFFFFFFF75BEB9FC
	public Void set_volume(Single value) { }

	// RVA: 0xFFFFFFFF75BEBA4C
	public Single get_pitch() { }

	// RVA: 0xFFFFFFFF75BEBA8C
	public Void set_pitch(Single value) { }

	// RVA: 0xFFFFFFFF75BEBADC
	public Single get_time() { }

	// RVA: 0xFFFFFFFF75BEBB1C
	public Void set_time(Single value) { }

	// RVA: 0xFFFFFFFF75BEBB6C
	public Int32 get_timeSamples() { }

	// RVA: 0xFFFFFFFF75BEBBAC
	public Void set_timeSamples(Int32 value) { }

	// RVA: 0xFFFFFFFF75BEBBFC
	public AudioClip get_clip() { }

	// RVA: 0xFFFFFFFF75BEBC3C
	public Void set_clip(AudioClip value) { }

	// RVA: 0xFFFFFFFF75BEBC8C
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0xFFFFFFFF75BEBCCC
	public Void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	// RVA: 0xFFFFFFFF75BEBD1C
	public Void Play() { }

	// RVA: 0xFFFFFFFF75BEBD60
	public Void Play(UInt64 delay) { }

	// RVA: 0xFFFFFFFF75BEBDB0
	public Void PlayDelayed(Single delay) { }

	// RVA: 0xFFFFFFFF75BEBE18
	public Void PlayScheduled(Double time) { }

	// RVA: 0xFFFFFFFF75BEBE78
	public Void PlayOneShot(AudioClip clip) { }

	// RVA: 0xFFFFFFFF75BEBE80
	public Void PlayOneShot(AudioClip clip, Single volumeScale) { }

	// RVA: 0xFFFFFFFF75BEBF48
	public Void SetScheduledStartTime(Double time) { }

	// RVA: 0xFFFFFFFF75BEBF98
	public Void SetScheduledEndTime(Double time) { }

	// RVA: 0xFFFFFFFF75BEBFE8
	public Void Stop() { }

	// RVA: 0xFFFFFFFF75BEC02C
	public Void Pause() { }

	// RVA: 0xFFFFFFFF75BEC06C
	public Void UnPause() { }

	// RVA: 0xFFFFFFFF75BEC0AC
	public Boolean get_isPlaying() { }

	// RVA: 0xFFFFFFFF75BEC0EC
	public Boolean get_isVirtual() { }

	// RVA: 0xFFFFFFFF75BEC12C
	public static Void PlayClipAtPoint(AudioClip clip, Vector3 position) { }

	// RVA: 0xFFFFFFFF75BEC134
	public static Void PlayClipAtPoint(AudioClip clip, Vector3 position, Single volume) { }

	// RVA: 0xFFFFFFFF75BEC3D8
	public Boolean get_loop() { }

	// RVA: 0xFFFFFFFF75BEC418
	public Void set_loop(Boolean value) { }

	// RVA: 0xFFFFFFFF75BEC468
	public Boolean get_ignoreListenerVolume() { }

	// RVA: 0xFFFFFFFF75BEC4A8
	public Void set_ignoreListenerVolume(Boolean value) { }

	// RVA: 0xFFFFFFFF75BEC4F8
	public Boolean get_playOnAwake() { }

	// RVA: 0xFFFFFFFF75BEC538
	public Void set_playOnAwake(Boolean value) { }

	// RVA: 0xFFFFFFFF75BEC588
	public Boolean get_ignoreListenerPause() { }

	// RVA: 0xFFFFFFFF75BEC5C8
	public Void set_ignoreListenerPause(Boolean value) { }

	// RVA: 0xFFFFFFFF75BEC618
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0xFFFFFFFF75BEC658
	public Void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0xFFFFFFFF75BEC6A8
	public Single get_panStereo() { }

	// RVA: 0xFFFFFFFF75BEC6E8
	public Void set_panStereo(Single value) { }

	// RVA: 0xFFFFFFFF75BEC738
	public Single get_spatialBlend() { }

	// RVA: 0xFFFFFFFF75BEC388
	public Void set_spatialBlend(Single value) { }

	// RVA: 0xFFFFFFFF75BEC778
	public Boolean get_spatialize() { }

	// RVA: 0xFFFFFFFF75BEC7B8
	public Void set_spatialize(Boolean value) { }

	// RVA: 0xFFFFFFFF75BEC808
	public Boolean get_spatializePostEffects() { }

	// RVA: 0xFFFFFFFF75BEC848
	public Void set_spatializePostEffects(Boolean value) { }

	// RVA: 0xFFFFFFFF75BEC898
	public Void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0xFFFFFFFF75BEC8F0
	public AnimationCurve GetCustomCurve(AudioSourceCurveType type) { }

	// RVA: 0xFFFFFFFF75BEC940
	public Single get_reverbZoneMix() { }

	// RVA: 0xFFFFFFFF75BEC980
	public Void set_reverbZoneMix(Single value) { }

	// RVA: 0xFFFFFFFF75BEC9D0
	public Boolean get_bypassEffects() { }

	// RVA: 0xFFFFFFFF75BECA10
	public Void set_bypassEffects(Boolean value) { }

	// RVA: 0xFFFFFFFF75BECA60
	public Boolean get_bypassListenerEffects() { }

	// RVA: 0xFFFFFFFF75BECAA0
	public Void set_bypassListenerEffects(Boolean value) { }

	// RVA: 0xFFFFFFFF75BECAF0
	public Boolean get_bypassReverbZones() { }

	// RVA: 0xFFFFFFFF75BECB30
	public Void set_bypassReverbZones(Boolean value) { }

	// RVA: 0xFFFFFFFF75BECB80
	public Single get_dopplerLevel() { }

	// RVA: 0xFFFFFFFF75BECBC0
	public Void set_dopplerLevel(Single value) { }

	// RVA: 0xFFFFFFFF75BECC10
	public Single get_spread() { }

	// RVA: 0xFFFFFFFF75BECC50
	public Void set_spread(Single value) { }

	// RVA: 0xFFFFFFFF75BECCA0
	public Int32 get_priority() { }

	// RVA: 0xFFFFFFFF75BECCE0
	public Void set_priority(Int32 value) { }

	// RVA: 0xFFFFFFFF75BECD30
	public Boolean get_mute() { }

	// RVA: 0xFFFFFFFF75BECD70
	public Void set_mute(Boolean value) { }

	// RVA: 0xFFFFFFFF75BECDC0
	public Single get_minDistance() { }

	// RVA: 0xFFFFFFFF75BECE00
	public Void set_minDistance(Single value) { }

	// RVA: 0xFFFFFFFF75BECE50
	public Single get_maxDistance() { }

	// RVA: 0xFFFFFFFF75BECE90
	public Void set_maxDistance(Single value) { }

	// RVA: 0xFFFFFFFF75BECEE0
	public AudioRolloffMode get_rolloffMode() { }

	// RVA: 0xFFFFFFFF75BECF20
	public Void set_rolloffMode(AudioRolloffMode value) { }

	// RVA: 0xFFFFFFFF75BECF70
	public Single[] GetOutputData(Int32 numSamples, Int32 channel) { }

	// RVA: 0xFFFFFFFF75BECFDC
	public Void GetOutputData(Single[] samples, Int32 channel) { }

	// RVA: 0xFFFFFFFF75BED034
	public Single[] GetSpectrumData(Int32 numSamples, Int32 channel, FFTWindow window) { }

	// RVA: 0xFFFFFFFF75BED0B0
	public Void GetSpectrumData(Single[] samples, Int32 channel, FFTWindow window) { }

	// RVA: 0xFFFFFFFF75BED118
	public Single get_minVolume() { }

	// RVA: 0xFFFFFFFF75BED180
	public Void set_minVolume(Single value) { }

	// RVA: 0xFFFFFFFF75BED1E0
	public Single get_maxVolume() { }

	// RVA: 0xFFFFFFFF75BED248
	public Void set_maxVolume(Single value) { }

	// RVA: 0xFFFFFFFF75BED2A8
	public Single get_rolloffFactor() { }

	// RVA: 0xFFFFFFFF75BED310
	public Void set_rolloffFactor(Single value) { }

	// RVA: 0xFFFFFFFF75BED370
	public Boolean SetSpatializerFloat(Int32 index, Single value) { }

	// RVA: 0xFFFFFFFF75BED3D0
	public Boolean GetSpatializerFloat(Int32 index, out Single value) { }

	// RVA: 0xFFFFFFFF75BED428
	public Boolean GetAmbisonicDecoderFloat(Int32 index, out Single value) { }

	// RVA: 0xFFFFFFFF75BED480
	public Boolean SetAmbisonicDecoderFloat(Int32 index, Single value) { }

	// RVA: 0xFFFFFFFF75BED4E0
	public Void .ctor() { }

}

// Namespace: UnityEngine
public enum WebCamKind
{
	// Fields
	public Int32 value__; // 0x10
	public const WebCamKind WideAngle = 1;
	public const WebCamKind Telephoto = 2;
	public const WebCamKind ColorAndDepth = 3;
}

// Namespace: UnityEngine
public struct WebCamDevice
{
	// Fields
	internal String m_Name; // 0x10
	internal String m_DepthCameraName; // 0x18
	internal Int32 m_Flags; // 0x20
	internal WebCamKind m_Kind; // 0x24
	internal Resolution[] m_Resolutions; // 0x28

	// Properties
	public String name { get; }
	public Boolean isFrontFacing { get; }

	// Methods

	// RVA: 0xFFFFFFFF7114AB54
	public String get_name() { }

	// RVA: 0xFFFFFFFF7114AB5C
	public Boolean get_isFrontFacing() { }

}

// Namespace: UnityEngine
public sealed class WebCamTexture
{
	// Properties
	public Boolean isPlaying { get; }
	public static WebCamDevice[] devices { get; }
	public Int32 videoRotationAngle { get; }

	// Methods

	// RVA: 0xFFFFFFFF75BEDA04
	private static Void Internal_CreateWebCamTexture(WebCamTexture self, String scriptingDevice, Int32 requestedWidth, Int32 requestedHeight, Int32 maxFramerate) { }

	// RVA: 0xFFFFFFFF75BEDA74
	public Void .ctor(String deviceName, Int32 requestedWidth, Int32 requestedHeight, Int32 requestedFPS) { }

	// RVA: 0xFFFFFFFF75BEDB0C
	public Void Play() { }

	// RVA: 0xFFFFFFFF75BEDB4C
	private static Void INTERNAL_CALL_Play(WebCamTexture self) { }

	// RVA: 0xFFFFFFFF75BEDB8C
	public Void Pause() { }

	// RVA: 0xFFFFFFFF75BEDBCC
	private static Void INTERNAL_CALL_Pause(WebCamTexture self) { }

	// RVA: 0xFFFFFFFF75BEDC0C
	public Void Stop() { }

	// RVA: 0xFFFFFFFF75BEDC4C
	private static Void INTERNAL_CALL_Stop(WebCamTexture self) { }

	// RVA: 0xFFFFFFFF75BEDC8C
	public Boolean get_isPlaying() { }

	// RVA: 0xFFFFFFFF75BEDCCC
	public static WebCamDevice[] get_devices() { }

	// RVA: 0xFFFFFFFF75BEDD00
	public Int32 get_videoRotationAngle() { }

}

// Namespace: UnityEngine.Audio
public struct AudioClipPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114A898
	public PlayableHandle GetHandle() { }

	// RVA: 0xFFFFFFFF7114A8A4
	public Boolean Equals(AudioClipPlayable other) { }

}

// Namespace: UnityEngine.Audio
public class AudioMixer
{
	// Methods

	// RVA: 0xFFFFFFFF75BEA040
	public Boolean SetFloat(String name, Single value) { }

	// RVA: 0xFFFFFFFF75BEA0A0
	public Boolean GetFloat(String name, out Single value) { }

}

// Namespace: UnityEngine.Audio
public class AudioMixerGroup
{
	// Methods

	// RVA: 0xFFFFFFFF75BEA0F8
	internal Void .ctor() { }

}

// Namespace: UnityEngine.Audio
public struct AudioMixerPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114A8AC
	public PlayableHandle GetHandle() { }

	// RVA: 0xFFFFFFFF7114A8B8
	public Boolean Equals(AudioMixerPlayable other) { }

}

// Namespace: UnityEngine.Audio
public struct AudioPlayableOutput
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF7114A8C0
	internal Void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0xFFFFFFFF7114A8C8
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0xFFFFFFFF75BEA268
	public static AudioPlayableOutput op_Explicit(PlayableOutput output) { }

	// RVA: 0xFFFFFFFF7114A8D4
	public Void SetEvaluateOnSeek(Boolean value) { }

	// RVA: 0xFFFFFFFF75BEA300
	private static Void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, Boolean value) { }

}

// Namespace: UnityEngine.Experimental.Audio
public class AudioSampleProvider
{
	// Fields
	private SampleFramesHandler sampleFramesAvailable; // 0x10
	private SampleFramesHandler sampleFramesOverflow; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75BED4E8
	private Void InvokeSampleFramesAvailable(Int32 sampleFrameCount) { }

	// RVA: 0xFFFFFFFF75BED924
	private Void InvokeSampleFramesOverflow(Int32 droppedSampleFrameCount) { }

}

// Namespace: 
public sealed class SampleFramesHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75BED93C
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75BED500
	public virtual Void Invoke(AudioSampleProvider provider, UInt32 sampleFrameCount) { }

	// RVA: 0xFFFFFFFF75BED950
	public virtual IAsyncResult BeginInvoke(AudioSampleProvider provider, UInt32 sampleFrameCount, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75BED9E4
	public virtual Void EndInvoke(IAsyncResult result) { }

}


