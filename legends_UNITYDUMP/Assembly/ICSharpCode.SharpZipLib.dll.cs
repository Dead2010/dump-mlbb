// Namespace: 
internal class <Module>
{}

// Namespace: ICSharpCode.SharpZipLib
public class SharpZipBaseException
{
	// Methods

	// RVA: 0xFFFFFFFF759BBC44
	protected Void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF759BBC54
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759BBC64
	public Void .ctor(String message) { }

}

// Namespace: ICSharpCode.SharpZipLib.Checksums
public sealed class Adler32
{
	// Fields
	private const UInt32 BASE = 65521;
	private UInt32 checksum; // 0x10

	// Properties
	public Int64 Value { get; }

	// Methods

	// RVA: 0xFFFFFFFF759BA77C
	public Int64 get_Value() { }

	// RVA: 0xFFFFFFFF759BA784
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759BA790
	public Void Reset() { }

	// RVA: 0xFFFFFFFF72356C00
	public Void Update(Byte[] buffer, Int32 offset, Int32 count) { }

}

// Namespace: ICSharpCode.SharpZipLib.Checksums
public sealed class Crc32
{
	// Fields
	private static readonly UInt32[] CrcTable; // 0x0
	private UInt32 crc; // 0x10

	// Properties
	public Int64 Value { get; }

	// Methods

	// RVA: 0xFFFFFFFF759BA79C
	internal static UInt32 ComputeCrc32(UInt32 oldCrc, Byte value) { }

	// RVA: 0xFFFFFFFF759BA81C
	public Int64 get_Value() { }

	// RVA: 0xFFFFFFFF759BA824
	public Void Reset() { }

	// RVA: 0xFFFFFFFF759BA82C
	public Void Update(Int32 value) { }

	// RVA: 0xFFFFFFFF72356D8C
	public Void Update(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF759BA8E4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759BA8E8
	private static Void .cctor() { }

}

// Namespace: ICSharpCode.SharpZipLib.Encryption
public abstract class PkzipClassic
{
	// Methods

	// RVA: 0xFFFFFFFF759BA94C
	public static Byte[] GenerateKeys(Byte[] seed) { }

	// RVA: 0xFFFFFFFF759BAB54
	protected Void .ctor() { }

}

// Namespace: ICSharpCode.SharpZipLib.Encryption
internal class PkzipClassicCryptoBase
{
	// Fields
	private UInt32[] keys; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF759BAB5C
	protected Byte TransformByte() { }

	// RVA: 0xFFFFFFFF759BABA8
	protected Void SetKeys(Byte[] keyData) { }

	// RVA: 0xFFFFFFFF759BAD14
	protected Void UpdateKeys(Byte ch) { }

	// RVA: 0xFFFFFFFF759BADE8
	protected Void Reset() { }

	// RVA: 0xFFFFFFFF759BAE34
	public Void .ctor() { }

}

// Namespace: ICSharpCode.SharpZipLib.Encryption
internal class PkzipClassicEncryptCryptoTransform
{
	// Properties
	public Int32 InputBlockSize { get; }
	public Int32 OutputBlockSize { get; }
	public Boolean CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0xFFFFFFFF759BAF9C
	internal Void .ctor(Byte[] keyBlock) { }

	// RVA: 0xFFFFFFFF759BAFA0
	public Byte[] TransformFinalBlock(Byte[] inputBuffer, Int32 inputOffset, Int32 inputCount) { }

	// RVA: 0xFFFFFFFF759BB00C
	public Int32 TransformBlock(Byte[] inputBuffer, Int32 inputOffset, Int32 inputCount, Byte[] outputBuffer, Int32 outputOffset) { }

	// RVA: 0xFFFFFFFF759BB0E4
	public Int32 get_InputBlockSize() { }

	// RVA: 0xFFFFFFFF759BB0EC
	public Int32 get_OutputBlockSize() { }

	// RVA: 0xFFFFFFFF759BB0F4
	public Boolean get_CanTransformMultipleBlocks() { }

	// RVA: 0xFFFFFFFF759BB0FC
	public Void Dispose() { }

}

// Namespace: ICSharpCode.SharpZipLib.Encryption
internal class PkzipClassicDecryptCryptoTransform
{
	// Properties
	public Int32 InputBlockSize { get; }
	public Int32 OutputBlockSize { get; }
	public Boolean CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0xFFFFFFFF759BAE38
	internal Void .ctor(Byte[] keyBlock) { }

	// RVA: 0xFFFFFFFF759BAE3C
	public Byte[] TransformFinalBlock(Byte[] inputBuffer, Int32 inputOffset, Int32 inputCount) { }

	// RVA: 0xFFFFFFFF759BAEA8
	public Int32 TransformBlock(Byte[] inputBuffer, Int32 inputOffset, Int32 inputCount, Byte[] outputBuffer, Int32 outputOffset) { }

	// RVA: 0xFFFFFFFF759BAF80
	public Int32 get_InputBlockSize() { }

	// RVA: 0xFFFFFFFF759BAF88
	public Int32 get_OutputBlockSize() { }

	// RVA: 0xFFFFFFFF759BAF90
	public Boolean get_CanTransformMultipleBlocks() { }

	// RVA: 0xFFFFFFFF759BAF98
	public Void Dispose() { }

}

// Namespace: ICSharpCode.SharpZipLib.Encryption
public sealed class PkzipClassicManaged
{
	// Fields
	private Byte[] key_; // 0x48

	// Properties
	public override Int32 BlockSize { get; set; }
	public override KeySizes[] LegalKeySizes { get; }
	public override Byte[] Key { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF759BB100
	public override Int32 get_BlockSize() { }

	// RVA: 0xFFFFFFFF759BB108
	public override Void set_BlockSize(Int32 value) { }

	// RVA: 0xFFFFFFFF759BB188
	public override KeySizes[] get_LegalKeySizes() { }

	// RVA: 0xFFFFFFFF759BB200
	public override Void GenerateIV() { }

	// RVA: 0xFFFFFFFF759BB204
	public override Byte[] get_Key() { }

	// RVA: 0xFFFFFFFF759BB278
	public override Void set_Key(Byte[] value) { }

	// RVA: 0xFFFFFFFF759BB384
	public override Void GenerateKey() { }

	// RVA: 0xFFFFFFFF759BB3F4
	public override ICryptoTransform CreateEncryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	// RVA: 0xFFFFFFFF759BB48C
	public override ICryptoTransform CreateDecryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	// RVA: 0xFFFFFFFF759BB524
	public Void .ctor() { }

}

// Namespace: ICSharpCode.SharpZipLib.Encryption
internal class ZipAESTransform
{
	// Fields
	private Int32 _blockSize; // 0x10
	private ICryptoTransform _encryptor; // 0x18
	private readonly Byte[] _counterNonce; // 0x20
	private Byte[] _encryptBuffer; // 0x28
	private Int32 _encrPos; // 0x30
	private Byte[] _pwdVerifier; // 0x38
	private HMACSHA1 _hmacsha1; // 0x40
	private Boolean _finalised; // 0x48
	private Boolean _writeMode; // 0x49

	// Properties
	public Byte[] PwdVerifier { get; }
	public Int32 InputBlockSize { get; }
	public Int32 OutputBlockSize { get; }
	public Boolean CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0xFFFFFFFF759BB52C
	public Void .ctor(String key, Byte[] saltBytes, Int32 blockSize, Boolean writeMode) { }

	// RVA: 0xFFFFFFFF759BB880
	public Int32 TransformBlock(Byte[] inputBuffer, Int32 inputOffset, Int32 inputCount, Byte[] outputBuffer, Int32 outputOffset) { }

	// RVA: 0xFFFFFFFF759BBAC0
	public Byte[] get_PwdVerifier() { }

	// RVA: 0xFFFFFFFF759BBAC8
	public Byte[] GetAuthCode() { }

	// RVA: 0xFFFFFFFF759BBB3C
	public Byte[] TransformFinalBlock(Byte[] inputBuffer, Int32 inputOffset, Int32 inputCount) { }

	// RVA: 0xFFFFFFFF759BBBA4
	public Int32 get_InputBlockSize() { }

	// RVA: 0xFFFFFFFF759BBBAC
	public Int32 get_OutputBlockSize() { }

	// RVA: 0xFFFFFFFF759BBBB4
	public Boolean get_CanTransformMultipleBlocks() { }

	// RVA: 0xFFFFFFFF759BBBBC
	public Void Dispose() { }

}

// Namespace: ICSharpCode.SharpZipLib.GZip
public class GZipException
{
	// Methods

	// RVA: 0xFFFFFFFF759BBC3C
	protected Void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF759BBC4C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759BBC5C
	public Void .ctor(String message) { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip.Compression.Streams
public class InflaterInputStream
{
	// Fields
	protected Inflater inf; // 0x28
	protected InflaterInputBuffer inputBuffer; // 0x30
	private Stream baseInputStream; // 0x38
	protected Int64 csize; // 0x40
	private Boolean isClosed; // 0x48
	private Boolean isStreamOwner; // 0x49

	// Properties
	public override Boolean CanRead { get; }
	public override Boolean CanSeek { get; }
	public override Boolean CanWrite { get; }
	public override Int64 Length { get; }
	public override Int64 Position { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF759BF5D0
	public Void .ctor(Stream baseInputStream, Inflater inf) { }

	// RVA: 0xFFFFFFFF72356F00
	public Void .ctor(Stream baseInputStream, Inflater inflater, Int32 bufferSize) { }

	// RVA: 0xFFFFFFFF759BF5D8
	public Int64 Skip(Int64 count) { }

	// RVA: 0xFFFFFFFF759BF704
	protected Void StopDecrypting() { }

	// RVA: 0xFFFFFFFF7235E41C
	protected Void Fill() { }

	// RVA: 0xFFFFFFFF759BF724
	public override Boolean get_CanRead() { }

	// RVA: 0xFFFFFFFF759BF74C
	public override Boolean get_CanSeek() { }

	// RVA: 0xFFFFFFFF759BF754
	public override Boolean get_CanWrite() { }

	// RVA: 0xFFFFFFFF759BF75C
	public override Int64 get_Length() { }

	// RVA: 0xFFFFFFFF759BF77C
	public override Int64 get_Position() { }

	// RVA: 0xFFFFFFFF759BF7A4
	public override Void set_Position(Int64 value) { }

	// RVA: 0xFFFFFFFF759BF80C
	public override Void Flush() { }

	// RVA: 0xFFFFFFFF759BF834
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xFFFFFFFF759BF89C
	public override Void SetLength(Int64 value) { }

	// RVA: 0xFFFFFFFF759BF904
	public override Void Write(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF759BF96C
	public override Void WriteByte(Byte value) { }

	// RVA: 0xFFFFFFFF759BF9D4
	public override IAsyncResult BeginWrite(Byte[] buffer, Int32 offset, Int32 count, AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF7235E4D0
	public override Void Close() { }

	// RVA: 0xFFFFFFFF723570BC
	public override Int32 Read(Byte[] buffer, Int32 offset, Int32 count) { }

}

// Namespace: ICSharpCode.SharpZipLib.GZip
public class GZipInputStream
{
	// Fields
	protected Crc32 crc; // 0x50
	private Boolean readGZIPHeader; // 0x58

	// Methods

	// RVA: 0xFFFFFFFF759BBC6C
	public Void .ctor(Stream baseInputStream) { }

	// RVA: 0xFFFFFFFF759BBCBC
	public Void .ctor(Stream baseInputStream, Int32 size) { }

	// RVA: 0xFFFFFFFF759BBDFC
	public override Int32 Read(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF759BBECC
	private Boolean ReadHeader() { }

	// RVA: 0xFFFFFFFF759BC2D8
	private Void ReadFooter() { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip.Compression.Streams
public class DeflaterOutputStream
{
	// Fields
	private String password; // 0x28
	private ICryptoTransform cryptoTransform_; // 0x30
	protected Byte[] AESAuthCode; // 0x38
	private Byte[] buffer_; // 0x40
	protected Deflater deflater_; // 0x48
	protected Stream baseOutputStream_; // 0x50
	private Boolean isClosed_; // 0x58
	private Boolean isStreamOwner_; // 0x59
	private static RNGCryptoServiceProvider _aesRnd; // 0x0

	// Properties
	public Boolean IsStreamOwner { get; }
	public Boolean CanPatchEntries { get; }
	public String Password { get; }
	public override Boolean CanRead { get; }
	public override Boolean CanSeek { get; }
	public override Boolean CanWrite { get; }
	public override Int64 Length { get; }
	public override Int64 Position { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF759BE90C
	public Void .ctor(Stream baseOutputStream, Deflater deflater) { }

	// RVA: 0xFFFFFFFF759BC880
	public Void .ctor(Stream baseOutputStream, Deflater deflater, Int32 bufferSize) { }

	// RVA: 0xFFFFFFFF759BCE24
	public virtual Void Finish() { }

	// RVA: 0xFFFFFFFF759BE9BC
	public Boolean get_IsStreamOwner() { }

	// RVA: 0xFFFFFFFF759BE9C4
	public Boolean get_CanPatchEntries() { }

	// RVA: 0xFFFFFFFF759BE9EC
	public String get_Password() { }

	// RVA: 0xFFFFFFFF759BE914
	protected Void EncryptBlock(Byte[] buffer, Int32 offset, Int32 length) { }

	// RVA: 0xFFFFFFFF759BE9F4
	protected Void InitializePassword(String password) { }

	// RVA: 0xFFFFFFFF759BEB34
	protected Void InitializeAESPassword(ZipEntry entry, String rawPassword, out Byte[] salt, out Byte[] pwdVerifier) { }

	// RVA: 0xFFFFFFFF7235E088
	protected Void Deflate() { }

	// RVA: 0xFFFFFFFF759BEDD4
	public override Boolean get_CanRead() { }

	// RVA: 0xFFFFFFFF759BEDDC
	public override Boolean get_CanSeek() { }

	// RVA: 0xFFFFFFFF759BEDE4
	public override Boolean get_CanWrite() { }

	// RVA: 0xFFFFFFFF759BEE0C
	public override Int64 get_Length() { }

	// RVA: 0xFFFFFFFF759BEE34
	public override Int64 get_Position() { }

	// RVA: 0xFFFFFFFF759BEE5C
	public override Void set_Position(Int64 value) { }

	// RVA: 0xFFFFFFFF759BEEC4
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xFFFFFFFF759BEF2C
	public override Void SetLength(Int64 value) { }

	// RVA: 0xFFFFFFFF759BEF94
	public override Int32 ReadByte() { }

	// RVA: 0xFFFFFFFF759BEFFC
	public override Int32 Read(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF759BF064
	public override IAsyncResult BeginRead(Byte[] buffer, Int32 offset, Int32 count, AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF759BF0CC
	public override IAsyncResult BeginWrite(Byte[] buffer, Int32 offset, Int32 count, AsyncCallback callback, Object state) { }

	// RVA: 0xFFFFFFFF759BF134
	public override Void Flush() { }

	// RVA: 0xFFFFFFFF759BF180
	public override Void Close() { }

	// RVA: 0xFFFFFFFF759BF2B8
	private Void GetAuthCodeIfAES() { }

	// RVA: 0xFFFFFFFF759BF34C
	public override Void WriteByte(Byte value) { }

	// RVA: 0xFFFFFFFF759BCC70
	public override Void Write(Byte[] buffer, Int32 offset, Int32 count) { }

}

// Namespace: ICSharpCode.SharpZipLib.GZip
public class GZipOutputStream
{
	// Fields
	protected Crc32 crc; // 0x60
	private OutputState state_; // 0x68

	// Methods

	// RVA: 0xFFFFFFFF759BC674
	public Void .ctor(Stream baseOutputStream) { }

	// RVA: 0xFFFFFFFF759BC67C
	public Void .ctor(Stream baseOutputStream, Int32 size) { }

	// RVA: 0xFFFFFFFF759BCA54
	public override Void Write(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF759BCCA0
	public override Void Close() { }

	// RVA: 0xFFFFFFFF759BCD34
	public override Void Finish() { }

	// RVA: 0xFFFFFFFF759BCB30
	private Void WriteHeader() { }

}

// Namespace: 
private enum OutputState
{
	// Fields
	public Int32 value__; // 0x10
	public const OutputState Header = 0;
	public const OutputState Footer = 1;
	public const OutputState Finished = 2;
	public const OutputState Closed = 3;
}

// Namespace: ICSharpCode.SharpZipLib.Zip.Compression.Streams
public class InflaterInputBuffer
{
	// Fields
	private Int32 rawLength; // 0x10
	private Byte[] rawData; // 0x18
	private Int32 clearTextLength; // 0x20
	private Byte[] clearText; // 0x28
	private Byte[] internalClearText; // 0x30
	private Int32 available; // 0x38
	private ICryptoTransform cryptoTransform; // 0x40
	private Stream inputStream; // 0x48

	// Properties
	public Int32 RawLength { get; }
	public Int32 Available { get; set; }
	public ICryptoTransform CryptoTransform { set; }

	// Methods

	// RVA: 0xFFFFFFFF7235E1A4
	public Void .ctor(Stream stream, Int32 bufferSize) { }

	// RVA: 0xFFFFFFFF759BF39C
	public Int32 get_RawLength() { }

	// RVA: 0xFFFFFFFF759BF3A4
	public Int32 get_Available() { }

	// RVA: 0xFFFFFFFF759BF3AC
	public Void set_Available(Int32 value) { }

	// RVA: 0xFFFFFFFF7235E240
	public Void SetInflaterInput(Inflater inflater) { }

	// RVA: 0xFFFFFFFF723571D8
	public Void Fill() { }

	// RVA: 0xFFFFFFFF759BF3B4
	public Int32 ReadRawBuffer(Byte[] buffer) { }

	// RVA: 0xFFFFFFFF7235E2A8
	public Int32 ReadRawBuffer(Byte[] outBuffer, Int32 offset, Int32 length) { }

	// RVA: 0xFFFFFFFF759BC544
	public Int32 ReadClearTextBuffer(Byte[] outBuffer, Int32 offset, Int32 length) { }

	// RVA: 0xFFFFFFFF72357300
	public Int32 ReadLeByte() { }

	// RVA: 0xFFFFFFFF759BF3DC
	public Int32 ReadLeShort() { }

	// RVA: 0xFFFFFFFF7235E3C4
	public Int32 ReadLeInt() { }

	// RVA: 0xFFFFFFFF759BF40C
	public Int64 ReadLeLong() { }

	// RVA: 0xFFFFFFFF759BF440
	public Void set_CryptoTransform(ICryptoTransform value) { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip.Compression.Streams
public class OutputWindow
{
	// Fields
	private const Int32 WindowSize = 32768;
	private const Int32 WindowMask = 32767;
	private Byte[] window; // 0x10
	private Int32 windowEnd; // 0x18
	private Int32 windowFilled; // 0x1C

	// Methods

	// RVA: 0xFFFFFFFF7235C02C
	public Void Write(Int32 value) { }

	// RVA: 0xFFFFFFFF7235E518
	private Void SlowRepeat(Int32 repStart, Int32 length, Int32 distance) { }

	// RVA: 0xFFFFFFFF7235C2F8
	public Void Repeat(Int32 length, Int32 distance) { }

	// RVA: 0xFFFFFFFF759BE51C
	public Int32 CopyStored(StreamManipulator input, Int32 length) { }

	// RVA: 0xFFFFFFFF759BE4F0
	public Int32 GetFreeSpace() { }

	// RVA: 0xFFFFFFFF759BFBEC
	public Int32 GetAvailable() { }

	// RVA: 0xFFFFFFFF7235D5A4
	public Int32 CopyOutput(Byte[] output, Int32 offset, Int32 len) { }

	// RVA: 0xFFFFFFFF759BE450
	public Void Reset() { }

	// RVA: 0xFFFFFFFF759BE400
	public Void .ctor() { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip.Compression.Streams
public class StreamManipulator
{
	// Fields
	private Byte[] window_; // 0x10
	private Int32 windowStart_; // 0x18
	private Int32 windowEnd_; // 0x1C
	private UInt32 buffer_; // 0x20
	private Int32 bitsInBuffer_; // 0x24

	// Properties
	public Int32 AvailableBits { get; }
	public Int32 AvailableBytes { get; }
	public Boolean IsNeedingInput { get; }

	// Methods

	// RVA: 0xFFFFFFFF759BE3FC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF7235B9A4
	public Int32 PeekBits(Int32 bitCount) { }

	// RVA: 0xFFFFFFFF759BE458
	public Void DropBits(Int32 bitCount) { }

	// RVA: 0xFFFFFFFF759BFBF4
	public Int32 get_AvailableBits() { }

	// RVA: 0xFFFFFFFF759BE6CC
	public Int32 get_AvailableBytes() { }

	// RVA: 0xFFFFFFFF759BE500
	public Void SkipToByteBoundary() { }

	// RVA: 0xFFFFFFFF759BE5F8
	public Boolean get_IsNeedingInput() { }

	// RVA: 0xFFFFFFFF759BFA3C
	public Int32 CopyBytes(Byte[] output, Int32 offset, Int32 length) { }

	// RVA: 0xFFFFFFFF759BE448
	public Void Reset() { }

	// RVA: 0xFFFFFFFF7235D268
	public Void SetInput(Byte[] buffer, Int32 offset, Int32 count) { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip.Compression
public class Deflater
{
	// Fields
	private Int32 level; // 0x10
	private Boolean noZlibHeaderOrFooter; // 0x14
	private Int32 state; // 0x18
	private Int64 totalOut; // 0x20
	private DeflaterPending pending; // 0x28
	private DeflaterEngine engine; // 0x30

	// Properties
	public Int64 TotalIn { get; }
	public Int64 TotalOut { get; }
	public Boolean IsFinished { get; }
	public Boolean IsNeedingInput { get; }

	// Methods

	// RVA: 0xFFFFFFFF759BC71C
	public Void .ctor(Int32 level, Boolean noZlibHeaderOrFooter) { }

	// RVA: 0xFFFFFFFF759BD32C
	public Void Reset() { }

	// RVA: 0xFFFFFFFF759BD078
	public Int64 get_TotalIn() { }

	// RVA: 0xFFFFFFFF759BD378
	public Int64 get_TotalOut() { }

	// RVA: 0xFFFFFFFF759BD380
	public Void Flush() { }

	// RVA: 0xFFFFFFFF759BD390
	public Void Finish() { }

	// RVA: 0xFFFFFFFF759BD3A0
	public Boolean get_IsFinished() { }

	// RVA: 0xFFFFFFFF759BD3EC
	public Boolean get_IsNeedingInput() { }

	// RVA: 0xFFFFFFFF759BD424
	public Void SetInput(Byte[] input, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF759BD26C
	public Void SetLevel(Int32 level) { }

	// RVA: 0xFFFFFFFF759BD24C
	public Void SetStrategy(DeflateStrategy strategy) { }

	// RVA: 0xFFFFFFFF723575A4
	public Int32 Deflate(Byte[] output, Int32 offset, Int32 length) { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip.Compression
public class DeflaterConstants
{
	// Fields
	public static Int32 MAX_BLOCK_SIZE; // 0x0
	public static Int32[] GOOD_LENGTH; // 0x8
	public static Int32[] MAX_LAZY; // 0x10
	public static Int32[] NICE_LENGTH; // 0x18
	public static Int32[] MAX_CHAIN; // 0x20
	public static Int32[] COMPR_FUNC; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF759BD9D4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759BD9D8
	private static Void .cctor() { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip.Compression
public enum DeflateStrategy
{
	// Fields
	public Int32 value__; // 0x10
	public const DeflateStrategy Default = 0;
	public const DeflateStrategy Filtered = 1;
	public const DeflateStrategy HuffmanOnly = 2;
}

// Namespace: ICSharpCode.SharpZipLib.Zip.Compression
public class DeflaterEngine
{
	// Fields
	private Int32 ins_h; // 0x10
	private Int16[] head; // 0x18
	private Int16[] prev; // 0x20
	private Int32 matchStart; // 0x28
	private Int32 matchLen; // 0x2C
	private Boolean prevAvailable; // 0x30
	private Int32 blockStart; // 0x34
	private Int32 strstart; // 0x38
	private Int32 lookahead; // 0x3C
	private Byte[] window; // 0x40
	private DeflateStrategy strategy; // 0x48
	private Int32 max_chain; // 0x4C
	private Int32 max_lazy; // 0x50
	private Int32 niceLength; // 0x54
	private Int32 goodLength; // 0x58
	private Int32 compressionFunction; // 0x5C
	private Byte[] inputBuf; // 0x60
	private Int64 totalIn; // 0x68
	private Int32 inputOff; // 0x70
	private Int32 inputEnd; // 0x74
	private DeflaterPending pending; // 0x78
	private DeflaterHuffman huffman; // 0x80
	private Adler32 adler; // 0x88

	// Properties
	public Int32 Adler { get; }
	public Int64 TotalIn { get; }
	public DeflateStrategy Strategy { set; }

	// Methods

	// RVA: 0xFFFFFFFF759BD0E0
	public Void .ctor(DeflaterPending pending) { }

	// RVA: 0xFFFFFFFF7235790C
	public Boolean Deflate(Boolean flush, Boolean finish) { }

	// RVA: 0xFFFFFFFF759BD4D8
	public Void SetInput(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF759BD414
	public Boolean NeedsInput() { }

	// RVA: 0xFFFFFFFF72357458
	public Void Reset() { }

	// RVA: 0xFFFFFFFF759BD91C
	public Void ResetAdler() { }

	// RVA: 0xFFFFFFFF759BD8FC
	public Int32 get_Adler() { }

	// RVA: 0xFFFFFFFF759BE0A4
	public Int64 get_TotalIn() { }

	// RVA: 0xFFFFFFFF759BE0AC
	public Void set_Strategy(DeflateStrategy value) { }

	// RVA: 0xFFFFFFFF759BD614
	public Void SetLevel(Int32 level) { }

	// RVA: 0xFFFFFFFF72357B40
	public Void FillWindow() { }

	// RVA: 0xFFFFFFFF723581A0
	private Void UpdateHash() { }

	// RVA: 0xFFFFFFFF7235913C
	private Int32 InsertString() { }

	// RVA: 0xFFFFFFFF72358FB8
	private Void SlideWindow() { }

	// RVA: 0xFFFFFFFF723591D4
	private Boolean FindLongestMatch(Int32 curMatch) { }

	// RVA: 0xFFFFFFFF759BDD4C
	private Boolean DeflateStored(Boolean flush, Boolean finish) { }

	// RVA: 0xFFFFFFFF759BDE54
	private Boolean DeflateFast(Boolean flush, Boolean finish) { }

	// RVA: 0xFFFFFFFF72357C60
	private Boolean DeflateSlow(Boolean flush, Boolean finish) { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip.Compression
public class DeflaterHuffman
{
	// Fields
	private static readonly Int32[] BL_ORDER; // 0x0
	private static readonly Byte[] bit4Reverse; // 0x8
	private static Int16[] staticLCodes; // 0x10
	private static Byte[] staticLLength; // 0x18
	private static Int16[] staticDCodes; // 0x20
	private static Byte[] staticDLength; // 0x28
	public DeflaterPending pending; // 0x10
	private Tree literalTree; // 0x18
	private Tree distTree; // 0x20
	private Tree blTree; // 0x28
	private Int16[] d_buf; // 0x30
	private Byte[] l_buf; // 0x38
	private Int32 last_lit; // 0x40
	private Int32 extra_bits; // 0x44

	// Methods

	// RVA: 0xFFFFFFFF72359800
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF759BDBD4
	public Void .ctor(DeflaterPending pending) { }

	// RVA: 0xFFFFFFFF72358058
	public Void Reset() { }

	// RVA: 0xFFFFFFFF72359F28
	public Void SendAllTrees(Int32 blTreeCodes) { }

	// RVA: 0xFFFFFFFF7235A5E0
	public Void CompressBlock() { }

	// RVA: 0xFFFFFFFF759BE0B4
	public Void FlushStoredBlock(Byte[] stored, Int32 storedOffset, Int32 storedLength, Boolean lastBlock) { }

	// RVA: 0xFFFFFFFF723581F8
	public Void FlushBlock(Byte[] stored, Int32 storedOffset, Int32 storedLength, Boolean lastBlock) { }

	// RVA: 0xFFFFFFFF759BE154
	public Boolean IsFull() { }

	// RVA: 0xFFFFFFFF72358F1C
	public Boolean TallyLit(Int32 literal) { }

	// RVA: 0xFFFFFFFF72359638
	public Boolean TallyDist(Int32 distance, Int32 length) { }

	// RVA: 0xFFFFFFFF72359DF0
	public static Int16 BitReverse(Int32 toReverse) { }

	// RVA: 0xFFFFFFFF759BE220
	private static Int32 Lcode(Int32 length) { }

	// RVA: 0xFFFFFFFF759BE25C
	private static Int32 Dcode(Int32 distance) { }

}

// Namespace: 
private class Tree
{
	// Fields
	public Int16[] freqs; // 0x10
	public Byte[] length; // 0x18
	public Int32 minNumCodes; // 0x20
	public Int32 numCodes; // 0x24
	private Int16[] codes; // 0x28
	private Int32[] bl_counts; // 0x30
	private Int32 maxLength; // 0x38
	private DeflaterHuffman dh; // 0x40

	// Methods

	// RVA: 0xFFFFFFFF759BE164
	public Void .ctor(DeflaterHuffman dh, Int32 elems, Int32 minCodes, Int32 maxLength) { }

	// RVA: 0xFFFFFFFF72359EB0
	public Void Reset() { }

	// RVA: 0xFFFFFFFF7235AB38
	public Void WriteSymbol(Int32 code) { }

	// RVA: 0xFFFFFFFF759BE34C
	public Void SetStaticCodes(Int16[] staticCodes, Byte[] staticLengths) { }

	// RVA: 0xFFFFFFFF7235A080
	public Void BuildCodes() { }

	// RVA: 0xFFFFFFFF7235ABA4
	public Void BuildTree() { }

	// RVA: 0xFFFFFFFF7235B44C
	public Int32 GetEncodedLength() { }

	// RVA: 0xFFFFFFFF7235B27C
	public Void CalcBLFreq(Tree blTree) { }

	// RVA: 0xFFFFFFFF7235A2F8
	public Void WriteTree(Tree blTree) { }

	// RVA: 0xFFFFFFFF7235B4C0
	private Void BuildLength(Int32[] childs) { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip.Compression
public class PendingBuffer
{
	// Fields
	private Byte[] buffer_; // 0x10
	private Int32 start; // 0x18
	private Int32 end; // 0x1C
	private UInt32 bits; // 0x20
	private Int32 bitCount; // 0x24

	// Properties
	public Int32 BitCount { get; }
	public Boolean IsFlushed { get; }

	// Methods

	// RVA: 0xFFFFFFFF759BE3B0
	public Void .ctor(Int32 bufferSize) { }

	// RVA: 0xFFFFFFFF759BD36C
	public Void Reset() { }

	// RVA: 0xFFFFFFFF759BE290
	public Void WriteShort(Int32 value) { }

	// RVA: 0xFFFFFFFF759BE300
	public Void WriteBlock(Byte[] block, Int32 offset, Int32 length) { }

	// RVA: 0xFFFFFFFF759BE904
	public Int32 get_BitCount() { }

	// RVA: 0xFFFFFFFF759BD940
	public Void AlignToByte() { }

	// RVA: 0xFFFFFFFF72357A94
	public Void WriteBits(Int32 b, Int32 count) { }

	// RVA: 0xFFFFFFFF759BD88C
	public Void WriteShortMSB(Int32 s) { }

	// RVA: 0xFFFFFFFF759BD3DC
	public Boolean get_IsFlushed() { }

	// RVA: 0xFFFFFFFF7235782C
	public Int32 Flush(Byte[] output, Int32 offset, Int32 length) { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip.Compression
public class DeflaterPending
{
	// Methods

	// RVA: 0xFFFFFFFF759BD098
	public Void .ctor() { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip.Compression
public class Inflater
{
	// Fields
	private const Int32 DECODE_HEADER = 0;
	private const Int32 DECODE_DICT = 1;
	private const Int32 DECODE_BLOCKS = 2;
	private const Int32 DECODE_STORED_LEN1 = 3;
	private const Int32 DECODE_STORED_LEN2 = 4;
	private const Int32 DECODE_STORED = 5;
	private const Int32 DECODE_DYN_HEADER = 6;
	private const Int32 DECODE_HUFFMAN = 7;
	private const Int32 DECODE_HUFFMAN_LENBITS = 8;
	private const Int32 DECODE_HUFFMAN_DIST = 9;
	private const Int32 DECODE_HUFFMAN_DISTBITS = 10;
	private const Int32 DECODE_CHKSUM = 11;
	private const Int32 FINISHED = 12;
	private static readonly Int32[] CPLENS; // 0x0
	private static readonly Int32[] CPLEXT; // 0x8
	private static readonly Int32[] CPDIST; // 0x10
	private static readonly Int32[] CPDEXT; // 0x18
	private Int32 mode; // 0x10
	private Int32 readAdler; // 0x14
	private Int32 neededBits; // 0x18
	private Int32 repLength; // 0x1C
	private Int32 repDist; // 0x20
	private Int32 uncomprLen; // 0x24
	private Boolean isLastBlock; // 0x28
	private Int64 totalOut; // 0x30
	private Int64 totalIn; // 0x38
	private Boolean noHeader; // 0x40
	private StreamManipulator input; // 0x48
	private OutputWindow outputWindow; // 0x50
	private InflaterDynHeader dynHeader; // 0x58
	private InflaterHuffmanTree litlenTree; // 0x60
	private InflaterHuffmanTree distTree; // 0x68
	private Adler32 adler; // 0x70

	// Properties
	public Boolean IsNeedingInput { get; }
	public Boolean IsNeedingDictionary { get; }
	public Boolean IsFinished { get; }
	public Int64 TotalOut { get; }
	public Int64 TotalIn { get; }
	public Int32 RemainingInput { get; }

	// Methods

	// RVA: 0xFFFFFFFF759BE3F4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759BBD10
	public Void .ctor(Boolean noHeader) { }

	// RVA: 0xFFFFFFFF723573A4
	public Void Reset() { }

	// RVA: 0xFFFFFFFF7235B850
	private Boolean DecodeHeader() { }

	// RVA: 0xFFFFFFFF759BE46C
	private Boolean DecodeDict() { }

	// RVA: 0xFFFFFFFF7235BA50
	private Boolean DecodeHuffman() { }

	// RVA: 0xFFFFFFFF7235C41C
	private Boolean DecodeChksum() { }

	// RVA: 0xFFFFFFFF7235C624
	private Boolean Decode() { }

	// RVA: 0xFFFFFFFF759BE608
	public Void SetInput(Byte[] buffer, Int32 index, Int32 count) { }

	// RVA: 0xFFFFFFFF7235D3DC
	public Int32 Inflate(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF759BE644
	public Boolean get_IsNeedingInput() { }

	// RVA: 0xFFFFFFFF759BE66C
	public Boolean get_IsNeedingDictionary() { }

	// RVA: 0xFFFFFFFF759BC29C
	public Boolean get_IsFinished() { }

	// RVA: 0xFFFFFFFF759BE690
	public Int64 get_TotalOut() { }

	// RVA: 0xFFFFFFFF759BE698
	public Int64 get_TotalIn() { }

	// RVA: 0xFFFFFFFF759BC518
	public Int32 get_RemainingInput() { }

	// RVA: 0xFFFFFFFF759BE6E0
	private static Void .cctor() { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip.Compression
internal class InflaterDynHeader
{
	// Fields
	private const Int32 LNUM = 0;
	private const Int32 DNUM = 1;
	private const Int32 BLNUM = 2;
	private const Int32 BLLENS = 3;
	private const Int32 LENS = 4;
	private const Int32 REPS = 5;
	private static readonly Int32[] repMin; // 0x0
	private static readonly Int32[] repBits; // 0x8
	private static readonly Int32[] BL_ORDER; // 0x10
	private Byte[] blLens; // 0x10
	private Byte[] litdistLens; // 0x18
	private InflaterHuffmanTree blTree; // 0x20
	private Int32 mode; // 0x28
	private Int32 lnum; // 0x2C
	private Int32 dnum; // 0x30
	private Int32 blnum; // 0x34
	private Int32 num; // 0x38
	private Int32 repSymbol; // 0x3C
	private Byte lastLen; // 0x40
	private Int32 ptr; // 0x44

	// Methods

	// RVA: 0xFFFFFFFF759BE518
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF7235CB14
	public Boolean Decode(StreamManipulator input) { }

	// RVA: 0xFFFFFFFF7235D19C
	public InflaterHuffmanTree BuildLitLenTree() { }

	// RVA: 0xFFFFFFFF7235D204
	public InflaterHuffmanTree BuildDistTree() { }

	// RVA: 0xFFFFFFFF759BE814
	private static Void .cctor() { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip.Compression
public class InflaterHuffmanTree
{
	// Fields
	private const Int32 MAX_BITLEN = 15;
	private Int16[] tree; // 0x10
	public static InflaterHuffmanTree defLitLenTree; // 0x0
	public static InflaterHuffmanTree defDistTree; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF7235D684
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF759BE810
	public Void .ctor(Byte[] codeLengths) { }

	// RVA: 0xFFFFFFFF7235DA08
	private Void BuildTree(Byte[] codeLengths) { }

	// RVA: 0xFFFFFFFF7235C0CC
	public Int32 GetSymbol(StreamManipulator input) { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip
public enum UseZip64
{
	// Fields
	public Int32 value__; // 0x10
	public const UseZip64 Off = 0;
	public const UseZip64 On = 1;
	public const UseZip64 Dynamic = 2;
}

// Namespace: ICSharpCode.SharpZipLib.Zip
public enum CompressionMethod
{
	// Fields
	public Int32 value__; // 0x10
	public const CompressionMethod Stored = 0;
	public const CompressionMethod Deflated = 8;
	public const CompressionMethod Deflate64 = 9;
	public const CompressionMethod BZip2 = 11;
	public const CompressionMethod WinZipAES = 99;
}

// Namespace: ICSharpCode.SharpZipLib.Zip
public sealed class ZipConstants
{
	// Fields
	private static Int32 defaultCodePage; // 0x0

	// Properties
	public static Int32 DefaultCodePage { get; }

	// Methods

	// RVA: 0xFFFFFFFF759BFBFC
	public static Int32 get_DefaultCodePage() { }

	// RVA: 0xFFFFFFFF759BFC3C
	public static String ConvertToString(Byte[] data, Int32 count) { }

	// RVA: 0xFFFFFFFF759BFCFC
	public static String ConvertToStringExt(Int32 flags, Byte[] data) { }

	// RVA: 0xFFFFFFFF759BEA98
	public static Byte[] ConvertToArray(String str) { }

	// RVA: 0xFFFFFFFF759BFDA4
	public static Byte[] ConvertToArray(Int32 flags, String str) { }

	// RVA: 0xFFFFFFFF759BFE28
	private static Void .cctor() { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip
public class ZipEntry
{
	// Fields
	private Known known; // 0x10
	private Int32 externalFileAttributes; // 0x14
	private UInt16 versionMadeBy; // 0x18
	private String name; // 0x20
	private UInt64 size; // 0x28
	private UInt64 compressedSize; // 0x30
	private UInt16 versionToExtract; // 0x38
	private UInt32 crc; // 0x3C
	private UInt32 dosTime; // 0x40
	private CompressionMethod method; // 0x44
	private Byte[] extra; // 0x48
	private String comment; // 0x50
	private Int32 flags; // 0x58
	private Int64 zipFileIndex; // 0x60
	private Int64 offset; // 0x68
	private Boolean forceZip64_; // 0x70
	private Byte cryptoCheckValue_; // 0x71
	private Int32 _aesVer; // 0x74
	private Int32 _aesEncryptionStrength; // 0x78

	// Properties
	public Boolean HasCrc { get; }
	public Boolean IsCrypted { get; set; }
	internal Byte CryptoCheckValue { get; set; }
	public Int32 Flags { get; set; }
	public Int64 Offset { get; set; }
	public Int32 ExternalFileAttributes { get; }
	public Int32 HostSystem { get; }
	public Int32 Version { get; }
	public Boolean CanDecompress { get; }
	public Boolean LocalHeaderRequiresZip64 { get; }
	public Boolean CentralHeaderRequiresZip64 { get; }
	public Int64 DosTime { get; set; }
	public DateTime DateTime { set; }
	public String Name { get; }
	public Int64 Size { get; set; }
	public Int64 CompressedSize { get; set; }
	public Int64 Crc { get; set; }
	public CompressionMethod CompressionMethod { get; set; }
	internal CompressionMethod CompressionMethodForHeader { get; }
	public Byte[] ExtraData { get; set; }
	public Int32 AESKeySize { get; }
	internal Byte AESEncryptionStrength { get; }
	internal Int32 AESSaltLen { get; }
	internal Int32 AESOverheadSize { get; }
	public String Comment { get; }
	public Boolean IsDirectory { get; }

	// Methods

	// RVA: 0xFFFFFFFF759BFE88
	public Void .ctor(String name) { }

	// RVA: 0xFFFFFFFF759BFFE4
	internal Void .ctor(String name, Int32 versionRequiredToExtract) { }

	// RVA: 0xFFFFFFFF759BFE98
	internal Void .ctor(String name, Int32 versionRequiredToExtract, Int32 madeByInfo, CompressionMethod method) { }

	// RVA: 0xFFFFFFFF759C0108
	public Boolean get_HasCrc() { }

	// RVA: 0xFFFFFFFF759C0114
	public Boolean get_IsCrypted() { }

	// RVA: 0xFFFFFFFF759C0120
	public Void set_IsCrypted(Boolean value) { }

	// RVA: 0xFFFFFFFF759C0134
	internal Byte get_CryptoCheckValue() { }

	// RVA: 0xFFFFFFFF759C013C
	internal Void set_CryptoCheckValue(Byte value) { }

	// RVA: 0xFFFFFFFF759C0144
	public Int32 get_Flags() { }

	// RVA: 0xFFFFFFFF759C014C
	public Void set_Flags(Int32 value) { }

	// RVA: 0xFFFFFFFF759C0154
	public Int64 get_Offset() { }

	// RVA: 0xFFFFFFFF759C015C
	public Void set_Offset(Int64 value) { }

	// RVA: 0xFFFFFFFF759C0164
	public Int32 get_ExternalFileAttributes() { }

	// RVA: 0xFFFFFFFF759C017C
	private Boolean HasDosAttributes(Int32 attributes) { }

	// RVA: 0xFFFFFFFF759C01B4
	public Int32 get_HostSystem() { }

	// RVA: 0xFFFFFFFF7235E598
	public Int32 get_Version() { }

	// RVA: 0xFFFFFFFF759C02B8
	public Boolean get_CanDecompress() { }

	// RVA: 0xFFFFFFFF759C0354
	public Void ForceZip64() { }

	// RVA: 0xFFFFFFFF759C0360
	public Boolean IsZip64Forced() { }

	// RVA: 0xFFFFFFFF759C0368
	public Boolean get_LocalHeaderRequiresZip64() { }

	// RVA: 0xFFFFFFFF759C01BC
	public Boolean get_CentralHeaderRequiresZip64() { }

	// RVA: 0xFFFFFFFF759C03BC
	public Int64 get_DosTime() { }

	// RVA: 0xFFFFFFFF759C03D4
	public Void set_DosTime(Int64 value) { }

	// RVA: 0xFFFFFFFF759BFFF0
	public Void set_DateTime(DateTime value) { }

	// RVA: 0xFFFFFFFF759C03E8
	public String get_Name() { }

	// RVA: 0xFFFFFFFF759C03F0
	public Int64 get_Size() { }

	// RVA: 0xFFFFFFFF759C0408
	public Void set_Size(Int64 value) { }

	// RVA: 0xFFFFFFFF759C041C
	public Int64 get_CompressedSize() { }

	// RVA: 0xFFFFFFFF759C0434
	public Void set_CompressedSize(Int64 value) { }

	// RVA: 0xFFFFFFFF759C0448
	public Int64 get_Crc() { }

	// RVA: 0xFFFFFFFF759C0460
	public Void set_Crc(Int64 value) { }

	// RVA: 0xFFFFFFFF759C0474
	public CompressionMethod get_CompressionMethod() { }

	// RVA: 0xFFFFFFFF759C047C
	public Void set_CompressionMethod(CompressionMethod value) { }

	// RVA: 0xFFFFFFFF759C04DC
	internal CompressionMethod get_CompressionMethodForHeader() { }

	// RVA: 0xFFFFFFFF759C050C
	public Byte[] get_ExtraData() { }

	// RVA: 0xFFFFFFFF759C0514
	public Void set_ExtraData(Byte[] value) { }

	// RVA: 0xFFFFFFFF759BED14
	public Int32 get_AESKeySize() { }

	// RVA: 0xFFFFFFFF759C05D8
	internal Byte get_AESEncryptionStrength() { }

	// RVA: 0xFFFFFFFF759BECFC
	internal Int32 get_AESSaltLen() { }

	// RVA: 0xFFFFFFFF759C05E0
	internal Int32 get_AESOverheadSize() { }

	// RVA: 0xFFFFFFFF759C05FC
	internal Void ProcessExtraData(Boolean localHeader) { }

	// RVA: 0xFFFFFFFF759C0C34
	private Void ProcessAESExtraData(ZipExtraData extraData) { }

	// RVA: 0xFFFFFFFF759C0D98
	public String get_Comment() { }

	// RVA: 0xFFFFFFFF759C0220
	public Boolean get_IsDirectory() { }

	// RVA: 0xFFFFFFFF759C0344
	public Boolean IsCompressionMethodSupported() { }

	// RVA: 0xFFFFFFFF759C0DA0
	public Object Clone() { }

	// RVA: 0xFFFFFFFF759C0E68
	public override String ToString() { }

	// RVA: 0xFFFFFFFF759C04D0
	public static Boolean IsCompressionMethodSupported(CompressionMethod method) { }

}

// Namespace: 
private enum Known
{
	// Fields
	public Byte value__; // 0x10
	public const Known None = 0;
	public const Known Size = 1;
	public const Known CompressedSize = 2;
	public const Known Crc = 4;
	public const Known Time = 8;
	public const Known ExternalAttributes = 16;
}

// Namespace: ICSharpCode.SharpZipLib.Zip
public class ZipException
{
	// Methods

	// RVA: 0xFFFFFFFF759C0E70
	protected Void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF759C0E78
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759BF3D4
	public Void .ctor(String message) { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip
public sealed class ZipExtraData
{
	// Fields
	private Int32 _index; // 0x10
	private Int32 _readValueStart; // 0x14
	private Int32 _readValueLength; // 0x18
	private MemoryStream _newEntry; // 0x20
	private Byte[] _data; // 0x28

	// Properties
	public Int32 Length { get; }
	public Int32 ValueLength { get; }
	public Int32 CurrentReadIndex { get; }
	public Int32 UnreadCount { get; }

	// Methods

	// RVA: 0xFFFFFFFF759C0A00
	public Void .ctor(Byte[] data) { }

	// RVA: 0xFFFFFFFF759C0E80
	public Byte[] GetEntryData() { }

	// RVA: 0xFFFFFFFF759C0F3C
	public Int32 get_Length() { }

	// RVA: 0xFFFFFFFF759C0F5C
	public Int32 get_ValueLength() { }

	// RVA: 0xFFFFFFFF759C0F64
	public Int32 get_CurrentReadIndex() { }

	// RVA: 0xFFFFFFFF759C0B30
	public Int32 get_UnreadCount() { }

	// RVA: 0xFFFFFFFF7235E6BC
	public Boolean Find(Int32 headerID) { }

	// RVA: 0xFFFFFFFF759C0F6C
	public Void AddEntry(Int32 headerID, Byte[] fieldData) { }

	// RVA: 0xFFFFFFFF759C12B0
	public Void StartNewEntry() { }

	// RVA: 0xFFFFFFFF759C1300
	public Void AddNewEntry(Int32 headerID) { }

	// RVA: 0xFFFFFFFF759C1370
	public Void AddData(Byte data) { }

	// RVA: 0xFFFFFFFF759C1398
	public Void AddLeShort(Int32 toAdd) { }

	// RVA: 0xFFFFFFFF759C13EC
	public Void AddLeInt(Int32 toAdd) { }

	// RVA: 0xFFFFFFFF759C141C
	public Void AddLeLong(Int64 toAdd) { }

	// RVA: 0xFFFFFFFF759C1178
	public Boolean Delete(Int32 headerID) { }

	// RVA: 0xFFFFFFFF759C0A50
	public Int64 ReadLong() { }

	// RVA: 0xFFFFFFFF7235E768
	public Int32 ReadInt() { }

	// RVA: 0xFFFFFFFF759C0A90
	public Int32 ReadShort() { }

	// RVA: 0xFFFFFFFF759C0BC8
	public Int32 ReadByte() { }

	// RVA: 0xFFFFFFFF759C0B00
	public Void Skip(Int32 amount) { }

	// RVA: 0xFFFFFFFF7235E8A8
	private Void ReadCheck(Int32 length) { }

	// RVA: 0xFFFFFFFF7235E808
	private Int32 ReadShortInternal() { }

	// RVA: 0xFFFFFFFF759C1240
	private Void SetShort(ref Int32 index, Int32 source) { }

	// RVA: 0xFFFFFFFF759C1464
	public Void Dispose() { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip
internal class ZipHelperStream
{
	// Fields
	private Boolean isOwner_; // 0x28
	private Stream stream_; // 0x30

	// Properties
	public override Boolean CanRead { get; }
	public override Boolean CanSeek { get; }
	public override Int64 Length { get; }
	public override Int64 Position { get; set; }
	public override Boolean CanWrite { get; }

	// Methods

	// RVA: 0xFFFFFFFF759C1480
	public Void .ctor(Stream stream) { }

	// RVA: 0xFFFFFFFF759C14D8
	public override Boolean get_CanRead() { }

	// RVA: 0xFFFFFFFF759C1500
	public override Boolean get_CanSeek() { }

	// RVA: 0xFFFFFFFF759C1528
	public override Int64 get_Length() { }

	// RVA: 0xFFFFFFFF759C1550
	public override Int64 get_Position() { }

	// RVA: 0xFFFFFFFF759C1578
	public override Void set_Position(Int64 value) { }

	// RVA: 0xFFFFFFFF759C15A0
	public override Boolean get_CanWrite() { }

	// RVA: 0xFFFFFFFF759C15C8
	public override Void Flush() { }

	// RVA: 0xFFFFFFFF759C15F0
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xFFFFFFFF759C1618
	public override Void SetLength(Int64 value) { }

	// RVA: 0xFFFFFFFF759C1640
	public override Int32 Read(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF759C1668
	public override Void Write(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF759C1690
	public override Void Close() { }

	// RVA: 0xFFFFFFFF759C1708
	public Void WriteZip64EndOfCentralDirectory(Int64 noOfEntries, Int64 sizeEntries, Int64 centralDirOffset) { }

	// RVA: 0xFFFFFFFF759C1918
	public Void WriteEndOfCentralDirectory(Int64 noOfEntries, Int64 sizeEntries, Int64 startOfCentralDirectory, Byte[] comment) { }

	// RVA: 0xFFFFFFFF759C18C4
	public Void WriteLEShort(Int32 value) { }

	// RVA: 0xFFFFFFFF759C1B7C
	public Void WriteLEUshort(UInt16 value) { }

	// RVA: 0xFFFFFFFF759C1854
	public Void WriteLEInt(Int32 value) { }

	// RVA: 0xFFFFFFFF759C1BD0
	public Void WriteLEUint(UInt32 value) { }

	// RVA: 0xFFFFFFFF759C1880
	public Void WriteLELong(Int64 value) { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip
public class ZipInputStream
{
	// Fields
	private ReadDataHandler internalReader; // 0x50
	private Crc32 crc; // 0x58
	private ZipEntry entry; // 0x60
	private Int64 size; // 0x68
	private Int32 method; // 0x70
	private Int32 flags; // 0x74
	private String password; // 0x78

	// Properties
	public Boolean CanDecompressEntry { get; }
	public override Int64 Length { get; }

	// Methods

	// RVA: 0xFFFFFFFF759C1C00
	public Void .ctor(Stream baseInputStream) { }

	// RVA: 0xFFFFFFFF759C1D20
	public Boolean get_CanDecompressEntry() { }

	// RVA: 0xFFFFFFFF759C1D30
	public ZipEntry GetNextEntry() { }

	// RVA: 0xFFFFFFFF759C2408
	private Void ReadDataDescriptor() { }

	// RVA: 0xFFFFFFFF759C2590
	private Void CompleteCloseEntry(Boolean testCrc) { }

	// RVA: 0xFFFFFFFF759C2258
	public Void CloseEntry() { }

	// RVA: 0xFFFFFFFF759C26A8
	public override Int64 get_Length() { }

	// RVA: 0xFFFFFFFF759C2728
	public override Int32 ReadByte() { }

	// RVA: 0xFFFFFFFF759C278C
	private Int32 ReadingNotAvailable(Byte[] destination, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF759C27E8
	private Int32 ReadingNotSupported(Byte[] destination, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF759C2840
	private Int32 InitialRead(Byte[] destination, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF759C2F44
	public override Int32 Read(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF759C2B88
	private Int32 BodyRead(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF7235EDBC
	public override Void Close() { }

}

// Namespace: 
private sealed class ReadDataHandler
{
	// Methods

	// RVA: 0xFFFFFFFF759C1CDC
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF7235E968
	public virtual Int32 Invoke(Byte[] b, Int32 offset, Int32 length) { }

	// RVA: 0xFFFFFFFF759C3020
	public virtual IAsyncResult BeginInvoke(Byte[] b, Int32 offset, Int32 length, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759C30C4
	public virtual Int32 EndInvoke(IAsyncResult result) { }

}

// Namespace: ICSharpCode.SharpZipLib.Zip
public class ZipOutputStream
{
	// Fields
	private ArrayList entries; // 0x60
	private Crc32 crc; // 0x68
	private ZipEntry curEntry; // 0x70
	private Int32 defaultCompressionLevel; // 0x78
	private CompressionMethod curMethod; // 0x7C
	private Int64 size; // 0x80
	private Int64 offset; // 0x88
	private Byte[] zipComment; // 0x90
	private Boolean patchEntryHeader; // 0x98
	private Int64 crcPatchPos; // 0xA0
	private Int64 sizePatchPos; // 0xA8
	private UseZip64 useZip64_; // 0xB0

	// Methods

	// RVA: 0xFFFFFFFF759C30F0
	public Void .ctor(Stream baseOutputStream) { }

	// RVA: 0xFFFFFFFF759C3208
	public Void SetLevel(Int32 level) { }

	// RVA: 0xFFFFFFFF759C323C
	private Void WriteLeShort(Int32 value) { }

	// RVA: 0xFFFFFFFF759C3290
	private Void WriteLeInt(Int32 value) { }

	// RVA: 0xFFFFFFFF759C32BC
	private Void WriteLeLong(Int64 value) { }

	// RVA: 0xFFFFFFFF759C3300
	public Void PutNextEntry(ZipEntry entry) { }

	// RVA: 0xFFFFFFFF759C3C08
	public Void CloseEntry() { }

	// RVA: 0xFFFFFFFF759C4548
	private Void WriteEncryptionHeader(Int64 crcValue) { }

	// RVA: 0xFFFFFFFF759C4410
	private static Void AddExtraDataAES(ZipEntry entry, ZipExtraData extraData) { }

	// RVA: 0xFFFFFFFF759C44C0
	private Void WriteAESHeader(ZipEntry entry) { }

	// RVA: 0xFFFFFFFF759C4604
	public override Void Write(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF759C4808
	private Void CopyAndEncrypt(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: 0xFFFFFFFF759C48D0
	public override Void Finish() { }

}

// Namespace: 
internal class <PrivateImplementationDetails>{8E8FA28D-216A-43EC-8DCB-2258D1F7BF00}
{
	// Fields
	internal static __StaticArrayInitTypeSize=1024 $$method0x60004f9-1; // 0x0
	internal static __StaticArrayInitTypeSize=12 $$method0x60000dd-1; // 0x400
	internal static __StaticArrayInitTypeSize=10 $$method0x6000152-1; // 0x40C
	internal static __StaticArrayInitTypeSize=40 $$method0x60004fc-1; // 0x416
	internal static __StaticArrayInitTypeSize=40 $$method0x60004fc-2; // 0x43E
	internal static __StaticArrayInitTypeSize=40 $$method0x60004fc-3; // 0x466
	internal static __StaticArrayInitTypeSize=40 $$method0x60004fc-4; // 0x48E
	internal static __StaticArrayInitTypeSize=40 $$method0x60004fc-5; // 0x4B6
	internal static __StaticArrayInitTypeSize=76 $$method0x600029d-1; // 0x4DE
	internal static __StaticArrayInitTypeSize=16 $$method0x600029d-2; // 0x52A
	internal static __StaticArrayInitTypeSize=116 $$method0x60004fd-1; // 0x53A
	internal static __StaticArrayInitTypeSize=116 $$method0x60004fd-2; // 0x5AE
	internal static __StaticArrayInitTypeSize=120 $$method0x60004fd-3; // 0x622
	internal static __StaticArrayInitTypeSize=120 $$method0x60004fd-4; // 0x69A
	internal static __StaticArrayInitTypeSize=12 $$method0x60004fe-1; // 0x712
	internal static __StaticArrayInitTypeSize=12 $$method0x60004fe-2; // 0x71E
	internal static __StaticArrayInitTypeSize=76 $$method0x60004fe-3; // 0x72A
}

// Namespace: 
private struct __StaticArrayInitTypeSize=1024
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=12
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=10
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=40
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=76
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=16
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=116
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=120
{}


