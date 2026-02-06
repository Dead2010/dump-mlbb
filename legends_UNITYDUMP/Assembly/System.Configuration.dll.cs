// Namespace: 
internal class <Module>
{}

// Namespace: System.Configuration
public abstract class ConfigurationSection
{
	// Methods

	// RVA: 0xFFFFFFFF759F3A54
	protected internal virtual Void DeserializeSection(XmlReader reader) { }

	// RVA: 0xFFFFFFFF759F3A8C
	protected internal override Boolean IsModified() { }

	// RVA: 0xFFFFFFFF759F3AC4
	protected internal override Void ResetModified() { }

	// RVA: 0xFFFFFFFF759F3AFC
	protected internal virtual String SerializeSection(ConfigurationElement parentElement, String name, ConfigurationSaveMode saveMode) { }

}

// Namespace: System.Configuration
public abstract class ConfigurationElement
{
	// Properties
	protected internal virtual ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF759F3974
	protected internal virtual ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0xFFFFFFFF759F39AC
	protected internal virtual Boolean IsModified() { }

	// RVA: 0xFFFFFFFF759F39E4
	protected internal virtual Void Reset(ConfigurationElement parentElement) { }

	// RVA: 0xFFFFFFFF759F3A1C
	protected internal virtual Void ResetModified() { }

}

// Namespace: System.Configuration
public abstract class ConfigurationElementCollection
{}

// Namespace: System.Configuration
public enum ConfigurationSaveMode
{
	// Fields
	public Int32 value__; // 0x10
	public const ConfigurationSaveMode Full = 2;
	public const ConfigurationSaveMode Minimal = 1;
	public const ConfigurationSaveMode Modified = 0;
}

// Namespace: System.Configuration
public class ConfigurationPropertyCollection
{}

// Namespace: System.Configuration
public sealed class ConfigurationCollectionAttribute
{
	// Methods

	// RVA: 0xFFFFFFFF759F3970
	public Void .ctor(Type itemType) { }

}

// Namespace: System.Configuration
public class ConfigurationSectionGroup
{}

// Namespace: System.Configuration
public sealed class IgnoreSection
{
	// Properties
	protected internal override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0xFFFFFFFF759F3B34
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759F3B6C
	protected internal override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0xFFFFFFFF759F3BA4
	protected internal override Void DeserializeSection(XmlReader xmlReader) { }

	// RVA: 0xFFFFFFFF759F3BDC
	protected internal override Boolean IsModified() { }

	// RVA: 0xFFFFFFFF759F3C14
	protected internal override Void Reset(ConfigurationElement parentSection) { }

	// RVA: 0xFFFFFFFF759F3C4C
	protected internal override Void ResetModified() { }

	// RVA: 0xFFFFFFFF759F3C84
	protected internal override String SerializeSection(ConfigurationElement parentSection, String name, ConfigurationSaveMode saveMode) { }

}

// Namespace: Unity
internal sealed class ThrowStub
{
	// Methods

	// RVA: 0xFFFFFFFF759F3CBC
	public static Void ThrowNotSupportedException() { }

}


