// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public static class ScreenCapture
{
	// Methods

	// RVA: 0xFFFFFFFF75C7E05C
	public static Void CaptureScreenshot(String filename) { }

	// RVA: 0xFFFFFFFF75C7E0FC
	public static Void CaptureScreenshot(String filename, Int32 superSize) { }

	// RVA: 0xFFFFFFFF75C7E150
	public static Texture2D CaptureScreenshotAsTexture() { }

	// RVA: 0xFFFFFFFF75C7E0A4
	private static Void CaptureScreenshot(String filename, Int32 superSize, StereoScreenCaptureMode CaptureMode) { }

	// RVA: 0xFFFFFFFF75C7E190
	private static Texture2D CaptureScreenshotAsTexture(Int32 superSize, StereoScreenCaptureMode stereoScreenCaptureMode) { }

}

// Namespace: 
public enum StereoScreenCaptureMode
{
	// Fields
	public Int32 value__; // 0x10
	public const StereoScreenCaptureMode LeftEye = 1;
	public const StereoScreenCaptureMode RightEye = 2;
	public const StereoScreenCaptureMode BothEyes = 3;
}


