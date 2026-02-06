// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public enum WindZoneMode
{
	// Fields
	public Int32 value__; // 0x10
	public const WindZoneMode Directional = 0;
	public const WindZoneMode Spherical = 1;
}

// Namespace: UnityEngine
public class WindZone
{
	// Properties
	public WindZoneMode mode { get; set; }
	public Single radius { get; set; }
	public Single windMain { get; set; }
	public Single windTurbulence { get; set; }
	public Single windPulseMagnitude { get; set; }
	public Single windPulseFrequency { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75CA8C28
	public WindZoneMode get_mode() { }

	// RVA: 0xFFFFFFFF75CA8C68
	public Void set_mode(WindZoneMode value) { }

	// RVA: 0xFFFFFFFF75CA8CB8
	public Single get_radius() { }

	// RVA: 0xFFFFFFFF75CA8CF8
	public Void set_radius(Single value) { }

	// RVA: 0xFFFFFFFF75CA8D48
	public Single get_windMain() { }

	// RVA: 0xFFFFFFFF75CA8D88
	public Void set_windMain(Single value) { }

	// RVA: 0xFFFFFFFF75CA8DD8
	public Single get_windTurbulence() { }

	// RVA: 0xFFFFFFFF75CA8E18
	public Void set_windTurbulence(Single value) { }

	// RVA: 0xFFFFFFFF75CA8E68
	public Single get_windPulseMagnitude() { }

	// RVA: 0xFFFFFFFF75CA8EA8
	public Void set_windPulseMagnitude(Single value) { }

	// RVA: 0xFFFFFFFF75CA8EF8
	public Single get_windPulseFrequency() { }

	// RVA: 0xFFFFFFFF75CA8F38
	public Void set_windPulseFrequency(Single value) { }

	// RVA: 0xFFFFFFFF75CA8F88
	public Void .ctor() { }

}


