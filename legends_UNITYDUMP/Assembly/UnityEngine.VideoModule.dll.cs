// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Experimental.Video
public struct VideoClipPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF71153BB0
	public PlayableHandle GetHandle() { }

	// RVA: 0xFFFFFFFF71153BBC
	public Boolean Equals(VideoClipPlayable other) { }

}

// Namespace: UnityEngine.Video
public sealed class VideoClip
{}

// Namespace: UnityEngine.Video
public enum VideoRenderMode
{
	// Fields
	public Int32 value__; // 0x10
	public const VideoRenderMode CameraFarPlane = 0;
	public const VideoRenderMode CameraNearPlane = 1;
	public const VideoRenderMode RenderTexture = 2;
	public const VideoRenderMode MaterialOverride = 3;
	public const VideoRenderMode APIOnly = 4;
}

// Namespace: UnityEngine.Video
public enum Video3DLayout
{
	// Fields
	public Int32 value__; // 0x10
	public const Video3DLayout No3D = 0;
	public const Video3DLayout SideBySide3D = 1;
	public const Video3DLayout OverUnder3D = 2;
}

// Namespace: UnityEngine.Video
public enum VideoAspectRatio
{
	// Fields
	public Int32 value__; // 0x10
	public const VideoAspectRatio NoScaling = 0;
	public const VideoAspectRatio FitVertically = 1;
	public const VideoAspectRatio FitHorizontally = 2;
	public const VideoAspectRatio FitInside = 3;
	public const VideoAspectRatio FitOutside = 4;
	public const VideoAspectRatio Stretch = 5;
}

// Namespace: UnityEngine.Video
public enum VideoTimeSource
{
	// Fields
	public Int32 value__; // 0x10
	public const VideoTimeSource AudioDSPTimeSource = 0;
	public const VideoTimeSource GameTimeSource = 1;
}

// Namespace: UnityEngine.Video
public enum VideoTimeReference
{
	// Fields
	public Int32 value__; // 0x10
	public const VideoTimeReference Freerun = 0;
	public const VideoTimeReference InternalTime = 1;
	public const VideoTimeReference ExternalTime = 2;
}

// Namespace: UnityEngine.Video
public enum VideoSource
{
	// Fields
	public Int32 value__; // 0x10
	public const VideoSource VideoClip = 0;
	public const VideoSource Url = 1;
}

// Namespace: UnityEngine.Video
public enum VideoAudioOutputMode
{
	// Fields
	public Int32 value__; // 0x10
	public const VideoAudioOutputMode None = 0;
	public const VideoAudioOutputMode AudioSource = 1;
	public const VideoAudioOutputMode Direct = 2;
	public const VideoAudioOutputMode APIOnly = 3;
}

// Namespace: UnityEngine.Video
public sealed class VideoPlayer
{
	// Fields
	private EventHandler prepareCompleted; // 0x18
	private EventHandler loopPointReached; // 0x20
	private EventHandler started; // 0x28
	private EventHandler frameDropped; // 0x30
	private ErrorEventHandler errorReceived; // 0x38
	private EventHandler seekCompleted; // 0x40
	private TimeEventHandler clockResyncOccurred; // 0x48
	private FrameReadyEventHandler frameReady; // 0x50

	// Methods

	// RVA: 0xFFFFFFFF75CA78E4
	private static Void InvokePrepareCompletedCallback_Internal(VideoPlayer source) { }

	// RVA: 0xFFFFFFFF75CA7CA0
	private static Void InvokeFrameReadyCallback_Internal(VideoPlayer source, Int64 frameIdx) { }

	// RVA: 0xFFFFFFFF75CA80F0
	private static Void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) { }

	// RVA: 0xFFFFFFFF75CA811C
	private static Void InvokeStartedCallback_Internal(VideoPlayer source) { }

	// RVA: 0xFFFFFFFF75CA8148
	private static Void InvokeFrameDroppedCallback_Internal(VideoPlayer source) { }

	// RVA: 0xFFFFFFFF75CA8174
	private static Void InvokeErrorReceivedCallback_Internal(VideoPlayer source, String errorStr) { }

	// RVA: 0xFFFFFFFF75CA8570
	private static Void InvokeSeekCompletedCallback_Internal(VideoPlayer source) { }

	// RVA: 0xFFFFFFFF75CA859C
	private static Void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, Double seconds) { }

}

// Namespace: 
public sealed class EventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75CA8A54
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75CA7910
	public virtual Void Invoke(VideoPlayer source) { }

	// RVA: 0xFFFFFFFF75CA8A68
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75CA8AB8
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class ErrorEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75CA89D8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75CA81A4
	public virtual Void Invoke(VideoPlayer source, String message) { }

	// RVA: 0xFFFFFFFF75CA89EC
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, String message, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75CA8A48
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class FrameReadyEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75CA8AC4
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75CA7CD0
	public virtual Void Invoke(VideoPlayer source, Int64 frameIdx) { }

	// RVA: 0xFFFFFFFF75CA8AD8
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, Int64 frameIdx, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75CA8B68
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class TimeEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF75CA8B74
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF75CA85C8
	public virtual Void Invoke(VideoPlayer source, Double seconds) { }

	// RVA: 0xFFFFFFFF75CA8B88
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, Double seconds, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF75CA8C1C
	public virtual Void EndInvoke(IAsyncResult result) { }

}


