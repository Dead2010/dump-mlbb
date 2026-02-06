// Namespace: 
internal class <Module>
{}

// Namespace: 
internal sealed class Locale
{
	// Methods

	// RVA: 0xFFFFFFFF759D4814
	public static String GetText(String msg) { }

}

// Namespace: Mono.Security
public class ASN1
{
	// Fields
	private Byte m_nTag; // 0x10
	private Byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public Int32 Count { get; }
	public Byte Tag { get; }
	public Int32 Length { get; }
	public Byte[] Value { get; set; }
	public ASN1 Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF759D8D38
	public Void .ctor(Byte tag) { }

	// RVA: 0xFFFFFFFF759D8D70
	public Void .ctor(Byte tag, Byte[] data) { }

	// RVA: 0xFFFFFFFF759D8DB4
	public Void .ctor(Byte[] data) { }

	// RVA: 0xFFFFFFFF759D9064
	public Int32 get_Count() { }

	// RVA: 0xFFFFFFFF759D9080
	public Byte get_Tag() { }

	// RVA: 0xFFFFFFFF759D9088
	public Int32 get_Length() { }

	// RVA: 0xFFFFFFFF759D90A0
	public Byte[] get_Value() { }

	// RVA: 0xFFFFFFFF759D9114
	public Void set_Value(Byte[] value) { }

	// RVA: 0xFFFFFFFF759D9194
	private Boolean CompareArray(Byte[] array1, Byte[] array2) { }

	// RVA: 0xFFFFFFFF759D9208
	public Boolean CompareValue(Byte[] value) { }

	// RVA: 0xFFFFFFFF759D9214
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0xFFFFFFFF759D9294
	public virtual Byte[] GetBytes() { }

	// RVA: 0xFFFFFFFF759D8F3C
	protected Void Decode(Byte[] asn1, ref Int32 anPos, Int32 anLength) { }

	// RVA: 0xFFFFFFFF759D9840
	protected Void DecodeTLV(Byte[] asn1, ref Int32 pos, out Byte tag, out Int32 length, out Byte[] content) { }

	// RVA: 0xFFFFFFFF759D9950
	public ASN1 get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF759D9A80
	public ASN1 Element(Int32 index, Byte anTag) { }

	// RVA: 0xFFFFFFFF759D9BD0
	public override String ToString() { }

}

// Namespace: Mono.Security
public static class ASN1Convert
{
	// Methods

	// RVA: 0xFFFFFFFF759D9E80
	public static ASN1 FromInt32(Int32 value) { }

	// RVA: 0xFFFFFFFF759DA000
	public static ASN1 FromOid(String oid) { }

	// RVA: 0xFFFFFFFF759DA0B4
	public static ASN1 FromUnsignedBigInteger(Byte[] big) { }

	// RVA: 0xFFFFFFFF759DA1BC
	public static Int32 ToInt32(ASN1 asn1) { }

	// RVA: 0xFFFFFFFF759DA2E4
	public static String ToOid(ASN1 asn1) { }

	// RVA: 0xFFFFFFFF759DA530
	public static DateTime ToDateTime(ASN1 time) { }

}

// Namespace: Mono.Security
internal sealed class BitConverterLE
{
	// Methods

	// RVA: 0xFFFFFFFF759DA950
	private static Byte[] GetUIntBytes(Byte* bytes) { }

	// RVA: 0xFFFFFFFF759DA9E8
	private static Byte[] GetULongBytes(Byte* bytes) { }

	// RVA: 0xFFFFFFFF759D9FDC
	internal static Byte[] GetBytes(Int32 value) { }

	// RVA: 0xFFFFFFFF759DAAC0
	internal static Byte[] GetBytes(Int64 value) { }

	// RVA: 0xFFFFFFFF759DAAE4
	private static Void UShortFromBytes(Byte* dst, Byte[] src, Int32 startIndex) { }

	// RVA: 0xFFFFFFFF759DABB0
	private static Void UIntFromBytes(Byte* dst, Byte[] src, Int32 startIndex) { }

	// RVA: 0xFFFFFFFF759DACEC
	internal static UInt16 ToUInt16(Byte[] value, Int32 startIndex) { }

	// RVA: 0xFFFFFFFF759DAD1C
	internal static UInt32 ToUInt32(Byte[] value, Int32 startIndex) { }

}

// Namespace: Mono.Security
public sealed class PKCS7
{}

// Namespace: 
public class ContentInfo
{
	// Fields
	private String contentType; // 0x10
	private ASN1 content; // 0x18

	// Properties
	public ASN1 ASN1 { get; }
	public ASN1 Content { get; set; }
	public String ContentType { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF759E0098
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759E011C
	public Void .ctor(String oid) { }

	// RVA: 0xFFFFFFFF759E014C
	public Void .ctor(Byte[] data) { }

	// RVA: 0xFFFFFFFF759E01B4
	public Void .ctor(ASN1 asn1) { }

	// RVA: 0xFFFFFFFF759E0388
	public ASN1 get_ASN1() { }

	// RVA: 0xFFFFFFFF759E0448
	public ASN1 get_Content() { }

	// RVA: 0xFFFFFFFF759E0450
	public Void set_Content(ASN1 value) { }

	// RVA: 0xFFFFFFFF759E0458
	public String get_ContentType() { }

	// RVA: 0xFFFFFFFF759E0460
	public Void set_ContentType(String value) { }

	// RVA: 0xFFFFFFFF759E038C
	internal ASN1 GetASN1() { }

}

// Namespace: 
public class EncryptedData
{
	// Fields
	private Byte _version; // 0x10
	private ContentInfo _content; // 0x18
	private ContentInfo _encryptionAlgorithm; // 0x20
	private Byte[] _encrypted; // 0x28

	// Properties
	public ContentInfo EncryptionAlgorithm { get; }
	public Byte[] EncryptedContent { get; }

	// Methods

	// RVA: 0xFFFFFFFF759E0468
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759E0490
	public Void .ctor(ASN1 asn1) { }

	// RVA: 0xFFFFFFFF759E07A4
	public ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0xFFFFFFFF759E07AC
	public Byte[] get_EncryptedContent() { }

}

// Namespace: Mono.Security.X509
internal class SafeBag
{
	// Fields
	private String _bagOID; // 0x10
	private ASN1 _asn1; // 0x18

	// Properties
	public String BagOID { get; }
	public ASN1 ASN1 { get; }

	// Methods

	// RVA: 0xFFFFFFFF759E7B0C
	public Void .ctor(String bagOID, ASN1 asn1) { }

	// RVA: 0xFFFFFFFF759EBCB8
	public String get_BagOID() { }

	// RVA: 0xFFFFFFFF759EBCC0
	public ASN1 get_ASN1() { }

}

// Namespace: Mono.Security.X509
public class PKCS12
{
	// Fields
	private Byte[] _password; // 0x10
	private ArrayList _keyBags; // 0x18
	private ArrayList _secretBags; // 0x20
	private X509CertificateCollection _certs; // 0x28
	private Boolean _keyBagsChanged; // 0x30
	private Boolean _secretBagsChanged; // 0x31
	private Boolean _certsChanged; // 0x32
	private Int32 _iterations; // 0x34
	private ArrayList _safeBags; // 0x38
	private RandomNumberGenerator _rng; // 0x40
	private static Int32 password_max_length; // 0x0

	// Properties
	public String Password { set; }
	public Int32 IterationCount { get; set; }
	public ArrayList Keys { get; }
	public X509CertificateCollection Certificates { get; }
	internal RandomNumberGenerator RNG { get; }
	public static Int32 MaximumPasswordLength { get; }

	// Methods

	// RVA: 0xFFFFFFFF759E48C4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759E49C0
	public Void .ctor(Byte[] data) { }

	// RVA: 0xFFFFFFFF759E5260
	public Void .ctor(Byte[] data, String password) { }

	// RVA: 0xFFFFFFFF759E4BE4
	private Void Decode(Byte[] data) { }

	// RVA: 0xFFFFFFFF759E5B8C
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF759E49F8
	public Void set_Password(String value) { }

	// RVA: 0xFFFFFFFF759E5C20
	public Int32 get_IterationCount() { }

	// RVA: 0xFFFFFFFF759E5C28
	public Void set_IterationCount(Int32 value) { }

	// RVA: 0xFFFFFFFF759E5C30
	public ArrayList get_Keys() { }

	// RVA: 0xFFFFFFFF759E639C
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0xFFFFFFFF759E6960
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0xFFFFFFFF759E53F4
	private Boolean Compare(Byte[] expected, Byte[] actual) { }

	// RVA: 0xFFFFFFFF759E699C
	private SymmetricAlgorithm GetSymmetricAlgorithm(String algorithmOid, Byte[] salt, Int32 iterationCount) { }

	// RVA: 0xFFFFFFFF759E6280
	public Byte[] Decrypt(String algorithmOid, Byte[] salt, Int32 iterationCount, Byte[] encryptedData) { }

	// RVA: 0xFFFFFFFF759E5AF8
	public Byte[] Decrypt(EncryptedData ed) { }

	// RVA: 0xFFFFFFFF759E7188
	public Byte[] Encrypt(String algorithmOid, Byte[] salt, Int32 iterationCount, Byte[] data) { }

	// RVA: 0xFFFFFFFF759E72EC
	private DSAParameters GetExistingParameters(out Boolean found) { }

	// RVA: 0xFFFFFFFF759E79A8
	private Void AddPrivateKey(PrivateKeyInfo pki) { }

	// RVA: 0xFFFFFFFF759E5468
	private Void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0xFFFFFFFF759E7B5C
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0xFFFFFFFF759E52A4
	private Byte[] MAC(Byte[] password, Byte[] salt, Int32 iterations, Byte[] data) { }

	// RVA: 0xFFFFFFFF759E8880
	public Byte[] GetBytes() { }

	// RVA: 0xFFFFFFFF759EAA8C
	private ContentInfo EncryptedContentInfo(ASN1 safeBags, String algorithmOid) { }

	// RVA: 0xFFFFFFFF759EAA84
	public Void AddCertificate(X509Certificate cert) { }

	// RVA: 0xFFFFFFFF759EADDC
	public Void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0xFFFFFFFF759EAA7C
	public Void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0xFFFFFFFF759EB030
	public Void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0xFFFFFFFF759EB534
	public Object Clone() { }

	// RVA: 0xFFFFFFFF759EB610
	public static Int32 get_MaximumPasswordLength() { }

	// RVA: 0xFFFFFFFF759EB670
	private static Void .cctor() { }

}

// Namespace: 
public class DeriveBytes
{
	// Fields
	private static Byte[] keyDiversifier; // 0x0
	private static Byte[] ivDiversifier; // 0x8
	private static Byte[] macDiversifier; // 0x10
	private String _hashName; // 0x10
	private Int32 _iterations; // 0x18
	private Byte[] _password; // 0x20
	private Byte[] _salt; // 0x28

	// Properties
	public String HashName { set; }
	public Int32 IterationCount { set; }
	public Byte[] Password { set; }
	public Byte[] Salt { set; }

	// Methods

	// RVA: 0xFFFFFFFF759E6F90
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759EB6BC
	public Void set_HashName(String value) { }

	// RVA: 0xFFFFFFFF759EB6C4
	public Void set_IterationCount(Int32 value) { }

	// RVA: 0xFFFFFFFF759E6F98
	public Void set_Password(Byte[] value) { }

	// RVA: 0xFFFFFFFF759E7020
	public Void set_Salt(Byte[] value) { }

	// RVA: 0xFFFFFFFF759EB6CC
	private Void Adjust(Byte[] a, Int32 aOff, Byte[] b) { }

	// RVA: 0xFFFFFFFF759EB78C
	private Byte[] Derive(Byte[] diversifier, Int32 n) { }

	// RVA: 0xFFFFFFFF759E7098
	public Byte[] DeriveKey(Int32 size) { }

	// RVA: 0xFFFFFFFF759E7110
	public Byte[] DeriveIV(Int32 size) { }

	// RVA: 0xFFFFFFFF759E8808
	public Byte[] DeriveMAC(Int32 size) { }

	// RVA: 0xFFFFFFFF759EBBB4
	private static Void .cctor() { }

}

// Namespace: Mono.Security.X509
public sealed class X501
{
	// Fields
	private static Byte[] countryName; // 0x0
	private static Byte[] organizationName; // 0x8
	private static Byte[] organizationalUnitName; // 0x10
	private static Byte[] commonName; // 0x18
	private static Byte[] localityName; // 0x20
	private static Byte[] stateOrProvinceName; // 0x28
	private static Byte[] streetAddress; // 0x30
	private static Byte[] domainComponent; // 0x38
	private static Byte[] userid; // 0x40
	private static Byte[] email; // 0x48
	private static Byte[] dnQualifier; // 0x50
	private static Byte[] title; // 0x58
	private static Byte[] surname; // 0x60
	private static Byte[] givenName; // 0x68
	private static Byte[] initial; // 0x70

	// Methods

	// RVA: 0xFFFFFFFF759EBCC8
	public static String ToString(ASN1 seq) { }

	// RVA: 0xFFFFFFFF759EC438
	public static String ToString(ASN1 seq, Boolean reversed, String separator, Boolean quotes) { }

	// RVA: 0xFFFFFFFF759EBDF0
	private static Void AppendEntry(StringBuilder sb, ASN1 entry, Boolean quotes) { }

	// RVA: 0xFFFFFFFF759EC5E8
	private static Void .cctor() { }

}

// Namespace: Mono.Security.X509
public class X509Crl
{
	// Fields
	private String issuer; // 0x10
	private Byte version; // 0x18
	private DateTime thisUpdate; // 0x20
	private DateTime nextUpdate; // 0x28
	private ArrayList entries; // 0x30
	private String signatureOID; // 0x38
	private Byte[] signature; // 0x40
	private X509ExtensionCollection extensions; // 0x48
	private Byte[] encoded; // 0x50
	private Byte[] hash_value; // 0x58

	// Properties
	public X509ExtensionCollection Extensions { get; }
	public Byte[] Hash { get; }
	public String IssuerName { get; }
	public DateTime NextUpdate { get; }

	// Methods

	// RVA: 0xFFFFFFFF759EE9CC
	public Void .ctor(Byte[] crl) { }

	// RVA: 0xFFFFFFFF759EEAAC
	private Void Parse(Byte[] crl) { }

	// RVA: 0xFFFFFFFF759EF25C
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0xFFFFFFFF759EF264
	public Byte[] get_Hash() { }

	// RVA: 0xFFFFFFFF759EF3F8
	public String get_IssuerName() { }

	// RVA: 0xFFFFFFFF759EF400
	public DateTime get_NextUpdate() { }

	// RVA: 0xFFFFFFFF759EF408
	private Boolean Compare(Byte[] array1, Byte[] array2) { }

	// RVA: 0xFFFFFFFF759EF478
	public X509CrlEntry GetCrlEntry(X509Certificate x509) { }

	// RVA: 0xFFFFFFFF759EF51C
	public X509CrlEntry GetCrlEntry(Byte[] serialNumber) { }

	// RVA: 0xFFFFFFFF759EF6F4
	internal Boolean VerifySignature(DSA dsa) { }

	// RVA: 0xFFFFFFFF759EF998
	internal Boolean VerifySignature(RSA rsa) { }

	// RVA: 0xFFFFFFFF759EFA6C
	public Boolean VerifySignature(AsymmetricAlgorithm aa) { }

}

// Namespace: 
public class X509CrlEntry
{
	// Fields
	private Byte[] sn; // 0x10
	private DateTime revocationDate; // 0x18
	private X509ExtensionCollection extensions; // 0x20

	// Properties
	public Byte[] SerialNumber { get; }
	public DateTime RevocationDate { get; }
	public X509ExtensionCollection Extensions { get; }

	// Methods

	// RVA: 0xFFFFFFFF759EF174
	internal Void .ctor(ASN1 entry) { }

	// RVA: 0xFFFFFFFF759EF6A0
	public Byte[] get_SerialNumber() { }

	// RVA: 0xFFFFFFFF759EFBE4
	public DateTime get_RevocationDate() { }

	// RVA: 0xFFFFFFFF759EFBEC
	public X509ExtensionCollection get_Extensions() { }

}

// Namespace: Mono.Security.X509
public class X509Certificate
{
	// Fields
	private ASN1 decoder; // 0x10
	private Byte[] m_encodedcert; // 0x18
	private DateTime m_from; // 0x20
	private DateTime m_until; // 0x28
	private ASN1 issuer; // 0x30
	private String m_issuername; // 0x38
	private String m_keyalgo; // 0x40
	private Byte[] m_keyalgoparams; // 0x48
	private ASN1 subject; // 0x50
	private String m_subject; // 0x58
	private Byte[] m_publickey; // 0x60
	private Byte[] signature; // 0x68
	private String m_signaturealgo; // 0x70
	private Byte[] m_signaturealgoparams; // 0x78
	private Byte[] certhash; // 0x80
	private RSA _rsa; // 0x88
	private DSA _dsa; // 0x90
	private Int32 version; // 0x98
	private Byte[] serialnumber; // 0xA0
	private Byte[] issuerUniqueID; // 0xA8
	private Byte[] subjectUniqueID; // 0xB0
	private X509ExtensionCollection extensions; // 0xB8
	private static String encoding_error; // 0x0

	// Properties
	public DSA DSA { get; set; }
	public X509ExtensionCollection Extensions { get; }
	public Byte[] Hash { get; }
	public virtual String IssuerName { get; }
	public virtual String KeyAlgorithm { get; }
	public virtual Byte[] KeyAlgorithmParameters { get; set; }
	public virtual Byte[] PublicKey { get; }
	public virtual RSA RSA { get; set; }
	public virtual Byte[] RawData { get; }
	public virtual Byte[] SerialNumber { get; }
	public virtual Byte[] Signature { get; }
	public virtual String SignatureAlgorithm { get; }
	public virtual String SubjectName { get; }
	public virtual DateTime ValidFrom { get; }
	public virtual DateTime ValidUntil { get; }
	public Int32 Version { get; }

	// Methods

	// RVA: 0xFFFFFFFF759EC9EC
	private Void Parse(Byte[] data) { }

	// RVA: 0xFFFFFFFF759E671C
	public Void .ctor(Byte[] data) { }

	// RVA: 0xFFFFFFFF759ED7EC
	private Byte[] GetUnsignedBigInteger(Byte[] integer) { }

	// RVA: 0xFFFFFFFF759E765C
	public DSA get_DSA() { }

	// RVA: 0xFFFFFFFF759ED870
	public Void set_DSA(DSA value) { }

	// RVA: 0xFFFFFFFF759ED8B4
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0xFFFFFFFF759ED8BC
	public Byte[] get_Hash() { }

	// RVA: 0xFFFFFFFF759EDAB0
	public virtual String get_IssuerName() { }

	// RVA: 0xFFFFFFFF759EDAB8
	public virtual String get_KeyAlgorithm() { }

	// RVA: 0xFFFFFFFF759EDAC0
	public virtual Byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0xFFFFFFFF759EDB10
	public virtual Void set_KeyAlgorithmParameters(Byte[] value) { }

	// RVA: 0xFFFFFFFF759EDB18
	public virtual Byte[] get_PublicKey() { }

	// RVA: 0xFFFFFFFF759EDB68
	public virtual RSA get_RSA() { }

	// RVA: 0xFFFFFFFF759EDD10
	public virtual Void set_RSA(RSA value) { }

	// RVA: 0xFFFFFFFF759EDD5C
	public virtual Byte[] get_RawData() { }

	// RVA: 0xFFFFFFFF759EDDAC
	public virtual Byte[] get_SerialNumber() { }

	// RVA: 0xFFFFFFFF759EDDFC
	public virtual Byte[] get_Signature() { }

	// RVA: 0xFFFFFFFF759EE250
	public virtual String get_SignatureAlgorithm() { }

	// RVA: 0xFFFFFFFF759EE258
	public virtual String get_SubjectName() { }

	// RVA: 0xFFFFFFFF759EE260
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0xFFFFFFFF759EE268
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0xFFFFFFFF759EE270
	public Int32 get_Version() { }

	// RVA: 0xFFFFFFFF759EE278
	internal Boolean VerifySignature(DSA dsa) { }

	// RVA: 0xFFFFFFFF759EE33C
	internal Boolean VerifySignature(RSA rsa) { }

	// RVA: 0xFFFFFFFF759EE460
	public Boolean VerifySignature(AsymmetricAlgorithm aa) { }

	// RVA: 0xFFFFFFFF759EE5D8
	public ASN1 GetIssuerName() { }

	// RVA: 0xFFFFFFFF759EE5E0
	public ASN1 GetSubjectName() { }

	// RVA: 0xFFFFFFFF759EE5E8
	public virtual Void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFFFFFFFF759ED6D0
	private static Byte[] PEM(String type, Byte[] data) { }

	// RVA: 0xFFFFFFFF759EE64C
	private static Void .cctor() { }

}

// Namespace: Mono.Security.X509
public class X509CertificateCollection
{
	// Properties
	public X509Certificate Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF759E49B8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759EE6A8
	public X509Certificate get_Item(Int32 index) { }

	// RVA: 0xFFFFFFFF759E68C0
	public Int32 Add(X509Certificate value) { }

	// RVA: 0xFFFFFFFF759E7520
	public X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0xFFFFFFFF759EE7EC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFFFFFFFF759EE818
	public override Int32 GetHashCode() { }

}

// Namespace: 
public class X509CertificateEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509Certificate Current { get; }
	private Object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0xFFFFFFFF759EE750
	public Void .ctor(X509CertificateCollection mappings) { }

	// RVA: 0xFFFFFFFF759E7578
	public X509Certificate get_Current() { }

	// RVA: 0xFFFFFFFF759EE844
	private Object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xFFFFFFFF759EE8C8
	private Boolean System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0xFFFFFFFF759EE948
	private Void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xFFFFFFFF759E7928
	public Boolean MoveNext() { }

}

// Namespace: Mono.Security.X509
public class X509Extension
{
	// Fields
	protected String extnOid; // 0x10
	protected Boolean extnCritical; // 0x18
	protected ASN1 extnValue; // 0x20

	// Properties
	public String Oid { get; }
	public Boolean Critical { get; }
	public ASN1 Value { get; }

	// Methods

	// RVA: 0xFFFFFFFF759EFBF4
	public Void .ctor(ASN1 asn1) { }

	// RVA: 0xFFFFFFFF759E431C
	public Void .ctor(X509Extension extension) { }

	// RVA: 0xFFFFFFFF759EFEDC
	protected virtual Void Decode() { }

	// RVA: 0xFFFFFFFF759EFEE0
	protected virtual Void Encode() { }

	// RVA: 0xFFFFFFFF759EFEE4
	public String get_Oid() { }

	// RVA: 0xFFFFFFFF759EFEEC
	public Boolean get_Critical() { }

	// RVA: 0xFFFFFFFF759EFEA0
	public ASN1 get_Value() { }

	// RVA: 0xFFFFFFFF759EFEF4
	public override Boolean Equals(Object obj) { }

	// RVA: 0xFFFFFFFF759F0030
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF759F0058
	private Void WriteLine(StringBuilder sb, Int32 n, Int32 pos) { }

	// RVA: 0xFFFFFFFF759F0264
	public override String ToString() { }

}

// Namespace: Mono.Security.X509
public sealed class X509ExtensionCollection
{
	// Fields
	private Boolean readOnly; // 0x18

	// Properties
	public X509Extension Item { get; }

	// Methods

	// RVA: 0xFFFFFFFF759F0328
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759ED598
	public Void .ctor(ASN1 asn1) { }

	// RVA: 0xFFFFFFFF759F0330
	public Int32 IndexOf(String oid) { }

	// RVA: 0xFFFFFFFF759F0480
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFFFFFFFF759F04AC
	public X509Extension get_Item(String oid) { }

}

// Namespace: Mono.Security.X509
public class X509Store
{
	// Fields
	private String _storePath; // 0x10
	private X509CertificateCollection _certificates; // 0x18
	private ArrayList _crls; // 0x20
	private Boolean _crl; // 0x28
	private Boolean _newFormat; // 0x29

	// Properties
	public X509CertificateCollection Certificates { get; }
	public ArrayList Crls { get; }

	// Methods

	// RVA: 0xFFFFFFFF759F0574
	internal Void .ctor(String path, Boolean crl, Boolean newFormat) { }

	// RVA: 0xFFFFFFFF759F05C4
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0xFFFFFFFF759F0888
	public ArrayList get_Crls() { }

	// RVA: 0xFFFFFFFF759F0C60
	private Byte[] Load(String filename) { }

	// RVA: 0xFFFFFFFF759F0DC8
	private X509Certificate LoadCertificate(String filename) { }

	// RVA: 0xFFFFFFFF759F0E2C
	private X509Crl LoadCrl(String filename) { }

	// RVA: 0xFFFFFFFF759F0E90
	private Boolean CheckStore(String path, Boolean throwException) { }

	// RVA: 0xFFFFFFFF759F0610
	private X509CertificateCollection BuildCertificatesCollection(String storeName) { }

	// RVA: 0xFFFFFFFF759F0904
	private ArrayList BuildCrlsCollection(String storeName) { }

}

// Namespace: Mono.Security.X509
public sealed class X509StoreManager
{
	// Fields
	private static String _userPath; // 0x0
	private static String _localMachinePath; // 0x8
	private static X509Stores _userStore; // 0x10
	private static X509Stores _machineStore; // 0x18

	// Properties
	internal static String CurrentUserPath { get; }
	internal static String LocalMachinePath { get; }
	public static X509Stores CurrentUser { get; }
	public static X509Stores LocalMachine { get; }

	// Methods

	// RVA: 0xFFFFFFFF759F0F98
	internal static String get_CurrentUserPath() { }

	// RVA: 0xFFFFFFFF759F1090
	internal static String get_LocalMachinePath() { }

	// RVA: 0xFFFFFFFF759F1188
	public static X509Stores get_CurrentUser() { }

	// RVA: 0xFFFFFFFF759F1288
	public static X509Stores get_LocalMachine() { }

}

// Namespace: Mono.Security.X509
public class X509Stores
{
	// Fields
	private String _storePath; // 0x10
	private Boolean _newFormat; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF759F1240
	internal Void .ctor(String path, Boolean newFormat) { }

	// RVA: 0xFFFFFFFF759F1340
	public X509Store Open(String storeName, Boolean create) { }

}

// Namespace: Mono.Security.X509.Extensions
public class AuthorityKeyIdentifierExtension
{
	// Fields
	private Byte[] aki; // 0x28

	// Properties
	public Byte[] Identifier { get; }

	// Methods

	// RVA: 0xFFFFFFFF759E4318
	public Void .ctor(X509Extension extension) { }

	// RVA: 0xFFFFFFFF759E4498
	protected override Void Decode() { }

	// RVA: 0xFFFFFFFF759E45BC
	protected override Void Encode() { }

	// RVA: 0xFFFFFFFF759E470C
	public Byte[] get_Identifier() { }

	// RVA: 0xFFFFFFFF759E475C
	public override String ToString() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public class ChallengeResponse
{
	// Fields
	private static Byte[] magic; // 0x0
	private static Byte[] nullEncMagic; // 0x8
	private Boolean _disposed; // 0x10
	private Byte[] _challenge; // 0x18
	private Byte[] _lmpwd; // 0x20
	private Byte[] _ntpwd; // 0x28

	// Properties
	public String Password { set; }
	public Byte[] Challenge { set; }
	public Byte[] LM { get; }
	public Byte[] NT { get; }

	// Methods

	// RVA: 0xFFFFFFFF759E07FC
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759E085C
	public Void .ctor(String password, Byte[] challenge) { }

	// RVA: 0xFFFFFFFF759E0DB8
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF759E08A0
	public Void set_Password(String value) { }

	// RVA: 0xFFFFFFFF759E0CB0
	public Void set_Challenge(Byte[] value) { }

	// RVA: 0xFFFFFFFF759E0F88
	public Byte[] get_LM() { }

	// RVA: 0xFFFFFFFF759E12F0
	public Byte[] get_NT() { }

	// RVA: 0xFFFFFFFF759E0E2C
	public Void Dispose() { }

	// RVA: 0xFFFFFFFF759E1378
	private Void Dispose(Boolean disposing) { }

	// RVA: 0xFFFFFFFF759E1010
	private Byte[] GetResponse(Byte[] pwd) { }

	// RVA: 0xFFFFFFFF759E13F4
	private Byte[] PrepareDESKey(Byte[] key56bits, Int32 position) { }

	// RVA: 0xFFFFFFFF759E0E74
	private Byte[] PasswordToKey(String password, Int32 position) { }

	// RVA: 0xFFFFFFFF759E1588
	private static Void .cctor() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public static class ChallengeResponse2
{
	// Fields
	private static Byte[] magic; // 0x0
	private static Byte[] nullEncMagic; // 0x8

	// Methods

	// RVA: 0xFFFFFFFF759E164C
	private static Byte[] Compute_LM(String password, Byte[] challenge) { }

	// RVA: 0xFFFFFFFF759E1DDC
	private static Byte[] Compute_NTLM_Password(String password) { }

	// RVA: 0xFFFFFFFF759E1EBC
	private static Byte[] Compute_NTLM(String password, Byte[] challenge) { }

	// RVA: 0xFFFFFFFF759E1F30
	private static Void Compute_NTLMv2_Session(String password, Byte[] challenge, out Byte[] lm, out Byte[] ntlm) { }

	// RVA: 0xFFFFFFFF759E2100
	private static Byte[] Compute_NTLMv2(Type2Message type2, String username, String password, String domain) { }

	// RVA: 0xFFFFFFFF759E25C0
	public static Void Compute(Type2Message type2, NtlmAuthLevel level, String username, String password, String domain, out Byte[] lm, out Byte[] ntlm) { }

	// RVA: 0xFFFFFFFF759E1AE8
	private static Byte[] GetResponse(Byte[] challenge, Byte[] pwd) { }

	// RVA: 0xFFFFFFFF759E27D0
	private static Byte[] PrepareDESKey(Byte[] key56bits, Int32 position) { }

	// RVA: 0xFFFFFFFF759E1998
	private static Byte[] PasswordToKey(String password, Int32 position) { }

	// RVA: 0xFFFFFFFF759E2964
	private static Void .cctor() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public abstract class MessageBase
{
	// Fields
	private static Byte[] header; // 0x0
	private Int32 _type; // 0x10
	private NtlmFlags _flags; // 0x14

	// Properties
	public NtlmFlags Flags { get; set; }
	public Int32 Type { get; }

	// Methods

	// RVA: 0xFFFFFFFF759E2A28
	protected Void .ctor(Int32 messageType) { }

	// RVA: 0xFFFFFFFF759E2A54
	public NtlmFlags get_Flags() { }

	// RVA: 0xFFFFFFFF759E2A5C
	public Void set_Flags(NtlmFlags value) { }

	// RVA: 0xFFFFFFFF759E2A64
	public Int32 get_Type() { }

	// RVA: 0xFFFFFFFF759E2A6C
	protected Byte[] PrepareMessage(Int32 messageSize) { }

	// RVA: 0xFFFFFFFF759E2B60
	protected virtual Void Decode(Byte[] message) { }

	// RVA: 0xFFFFFFFF759E2CD8
	protected Boolean CheckHeader(Byte[] message) { }

	// RVA: -1
	public abstract Byte[] GetBytes() { }

	// RVA: 0xFFFFFFFF759E2E10
	private static Void .cctor() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public enum NtlmAuthLevel
{
	// Fields
	public Int32 value__; // 0x10
	public const NtlmAuthLevel LM_and_NTLM = 0;
	public const NtlmAuthLevel LM_and_NTLM_and_try_NTLMv2_Session = 1;
	public const NtlmAuthLevel NTLM_only = 2;
	public const NtlmAuthLevel NTLMv2_only = 3;
}

// Namespace: Mono.Security.Protocol.Ntlm
public enum NtlmFlags
{
	// Fields
	public Int32 value__; // 0x10
	public const NtlmFlags NegotiateUnicode = 1;
	public const NtlmFlags NegotiateOem = 2;
	public const NtlmFlags RequestTarget = 4;
	public const NtlmFlags NegotiateNtlm = 512;
	public const NtlmFlags NegotiateDomainSupplied = 4096;
	public const NtlmFlags NegotiateWorkstationSupplied = 8192;
	public const NtlmFlags NegotiateAlwaysSign = 32768;
	public const NtlmFlags NegotiateNtlm2Key = 524288;
	public const NtlmFlags Negotiate128 = 536870912;
	public const NtlmFlags Negotiate56 = 2147483648;
}

// Namespace: Mono.Security.Protocol.Ntlm
public static class NtlmSettings
{
	// Fields
	private static NtlmAuthLevel defaultAuthLevel; // 0x0

	// Properties
	public static NtlmAuthLevel DefaultAuthLevel { get; }

	// Methods

	// RVA: 0xFFFFFFFF759E2E8C
	public static NtlmAuthLevel get_DefaultAuthLevel() { }

	// RVA: 0xFFFFFFFF759E2EEC
	private static Void .cctor() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type1Message
{
	// Fields
	private String _host; // 0x18
	private String _domain; // 0x20

	// Properties
	public String Domain { set; }
	public String Host { set; }

	// Methods

	// RVA: 0xFFFFFFFF759E2F38
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759E2FDC
	public Void set_Domain(String value) { }

	// RVA: 0xFFFFFFFF759E3040
	public Void set_Host(String value) { }

	// RVA: 0xFFFFFFFF759E30A4
	protected override Void Decode(Byte[] message) { }

	// RVA: 0xFFFFFFFF759E31AC
	public override Byte[] GetBytes() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type2Message
{
	// Fields
	private Byte[] _nonce; // 0x18
	private String _targetName; // 0x20
	private Byte[] _targetInfo; // 0x28

	// Properties
	public Byte[] Nonce { get; }
	public String TargetName { get; }
	public Byte[] TargetInfo { get; }

	// Methods

	// RVA: 0xFFFFFFFF759E33EC
	public Void .ctor(Byte[] message) { }

	// RVA: 0xFFFFFFFF759E3498
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF759E256C
	public Byte[] get_Nonce() { }

	// RVA: 0xFFFFFFFF759E3514
	public String get_TargetName() { }

	// RVA: 0xFFFFFFFF759E2518
	public Byte[] get_TargetInfo() { }

	// RVA: 0xFFFFFFFF759E351C
	protected override Void Decode(Byte[] message) { }

	// RVA: 0xFFFFFFFF759E3694
	public override Byte[] GetBytes() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type3Message
{
	// Fields
	private NtlmAuthLevel _level; // 0x18
	private Byte[] _challenge; // 0x20
	private String _host; // 0x28
	private String _domain; // 0x30
	private String _username; // 0x38
	private String _password; // 0x40
	private Type2Message _type2; // 0x48
	private Byte[] _lm; // 0x50
	private Byte[] _nt; // 0x58

	// Properties
	public String Domain { set; }
	public String Password { set; }
	public String Username { set; }

	// Methods

	// RVA: 0xFFFFFFFF759E3758
	public Void .ctor(Type2Message type2) { }

	// RVA: 0xFFFFFFFF759E391C
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF759E39D0
	public Void set_Domain(String value) { }

	// RVA: 0xFFFFFFFF759E3A34
	public Void set_Password(String value) { }

	// RVA: 0xFFFFFFFF759E3A3C
	public Void set_Username(String value) { }

	// RVA: 0xFFFFFFFF759E3A44
	protected override Void Decode(Byte[] message) { }

	// RVA: 0xFFFFFFFF759E3C94
	private String DecodeString(Byte[] buffer, Int32 offset, Int32 len) { }

	// RVA: 0xFFFFFFFF759E3CFC
	private Byte[] EncodeString(String text) { }

	// RVA: 0xFFFFFFFF759E3D64
	public override Byte[] GetBytes() { }

}

// Namespace: Mono.Security.Interface
public enum AlertLevel
{
	// Fields
	public Byte value__; // 0x10
	public const AlertLevel Warning = 1;
	public const AlertLevel Fatal = 2;
}

// Namespace: Mono.Security.Interface
public enum AlertDescription
{
	// Fields
	public Byte value__; // 0x10
	public const AlertDescription CloseNotify = 0;
	public const AlertDescription UnexpectedMessage = 10;
	public const AlertDescription BadRecordMAC = 20;
	public const AlertDescription DecryptionFailed_RESERVED = 21;
	public const AlertDescription RecordOverflow = 22;
	public const AlertDescription DecompressionFailure = 30;
	public const AlertDescription HandshakeFailure = 40;
	public const AlertDescription NoCertificate_RESERVED = 41;
	public const AlertDescription BadCertificate = 42;
	public const AlertDescription UnsupportedCertificate = 43;
	public const AlertDescription CertificateRevoked = 44;
	public const AlertDescription CertificateExpired = 45;
	public const AlertDescription CertificateUnknown = 46;
	public const AlertDescription IlegalParameter = 47;
	public const AlertDescription UnknownCA = 48;
	public const AlertDescription AccessDenied = 49;
	public const AlertDescription DecodeError = 50;
	public const AlertDescription DecryptError = 51;
	public const AlertDescription ExportRestriction = 60;
	public const AlertDescription ProtocolVersion = 70;
	public const AlertDescription InsuficientSecurity = 71;
	public const AlertDescription InternalError = 80;
	public const AlertDescription UserCancelled = 90;
	public const AlertDescription NoRenegotiation = 100;
	public const AlertDescription UnsupportedExtension = 110;
}

// Namespace: Mono.Security.Interface
public class Alert
{
	// Fields
	private AlertLevel level; // 0x10
	private AlertDescription description; // 0x11

	// Properties
	public AlertLevel Level { get; }
	public AlertDescription Description { get; }

	// Methods

	// RVA: 0xFFFFFFFF759DEE24
	public AlertLevel get_Level() { }

	// RVA: 0xFFFFFFFF759DEE2C
	public AlertDescription get_Description() { }

	// RVA: 0xFFFFFFFF759DEE34
	public Void .ctor(AlertDescription description) { }

	// RVA: 0xFFFFFFFF759DEE9C
	private Void inferAlertLevel() { }

	// RVA: 0xFFFFFFFF759DEEE0
	public override String ToString() { }

}

// Namespace: Mono.Security.Interface
public class ValidationResult
{
	// Fields
	private Boolean trusted; // 0x10
	private Boolean user_denied; // 0x11
	private Int32 error_code; // 0x14
	private Nullable<T0> policy_errors; // 0x18

	// Properties
	public Boolean Trusted { get; }
	public Boolean UserDenied { get; }

	// Methods

	// RVA: 0xFFFFFFFF759E0034
	public Void .ctor(Boolean trusted, Boolean user_denied, Int32 error_code, Nullable<T0> policy_errors) { }

	// RVA: 0xFFFFFFFF759E0088
	public Boolean get_Trusted() { }

	// RVA: 0xFFFFFFFF759E0090
	public Boolean get_UserDenied() { }

}

// Namespace: Mono.Security.Interface
public interface ICertificateValidator
{
	// Properties
	public abstract MonoTlsSettings Settings { get; }

	// Methods

	// RVA: -1
	public abstract MonoTlsSettings get_Settings() { }

	// RVA: -1
	public abstract Boolean SelectClientCertificate(String targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers, out X509Certificate clientCertificate) { }

	// RVA: -1
	public abstract ValidationResult ValidateCertificate(String targetHost, Boolean serverMode, X509CertificateCollection certificates) { }

}

// Namespace: Mono.Security.Interface
internal interface ICertificateValidator2
{
	// Methods

	// RVA: -1
	public abstract ValidationResult ValidateCertificate(String targetHost, Boolean serverMode, X509Certificate leaf, X509Chain chain) { }

}

// Namespace: Mono.Security.Interface
public static class CertificateValidationHelper
{
	// Fields
	private static readonly Boolean noX509Chain; // 0x0
	private static readonly Boolean supportsTrustAnchors; // 0x1

	// Methods

	// RVA: 0xFFFFFFFF759DEF88
	private static Void .cctor() { }

	// RVA: 0xFFFFFFFF759DEFF0
	internal static ICertificateValidator2 GetInternalValidator(MonoTlsSettings settings, MonoTlsProvider provider) { }

}

// Namespace: Mono.Security.Interface
public enum CipherSuiteCode
{
	// Fields
	public UInt16 value__; // 0x10
	public const CipherSuiteCode TLS_NULL_WITH_NULL_NULL = 0;
	public const CipherSuiteCode TLS_RSA_WITH_NULL_MD5 = 1;
	public const CipherSuiteCode TLS_RSA_WITH_NULL_SHA = 2;
	public const CipherSuiteCode TLS_RSA_EXPORT_WITH_RC4_40_MD5 = 3;
	public const CipherSuiteCode TLS_RSA_WITH_RC4_128_MD5 = 4;
	public const CipherSuiteCode TLS_RSA_WITH_RC4_128_SHA = 5;
	public const CipherSuiteCode TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5 = 6;
	public const CipherSuiteCode TLS_RSA_WITH_IDEA_CBC_SHA = 7;
	public const CipherSuiteCode TLS_RSA_EXPORT_WITH_DES40_CBC_SHA = 8;
	public const CipherSuiteCode TLS_RSA_WITH_DES_CBC_SHA = 9;
	public const CipherSuiteCode TLS_RSA_WITH_3DES_EDE_CBC_SHA = 10;
	public const CipherSuiteCode TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA = 11;
	public const CipherSuiteCode TLS_DH_DSS_WITH_DES_CBC_SHA = 12;
	public const CipherSuiteCode TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA = 13;
	public const CipherSuiteCode TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA = 14;
	public const CipherSuiteCode TLS_DH_RSA_WITH_DES_CBC_SHA = 15;
	public const CipherSuiteCode TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA = 16;
	public const CipherSuiteCode TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA = 17;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_DES_CBC_SHA = 18;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA = 19;
	public const CipherSuiteCode TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA = 20;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_DES_CBC_SHA = 21;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 22;
	public const CipherSuiteCode TLS_DH_anon_EXPORT_WITH_RC4_40_MD5 = 23;
	public const CipherSuiteCode TLS_DH_anon_WITH_RC4_128_MD5 = 24;
	public const CipherSuiteCode TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 25;
	public const CipherSuiteCode TLS_DH_anon_WITH_DES_CBC_SHA = 26;
	public const CipherSuiteCode TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 27;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CBC_SHA = 47;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_128_CBC_SHA = 48;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_128_CBC_SHA = 49;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_128_CBC_SHA = 50;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 51;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_128_CBC_SHA = 52;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CBC_SHA = 53;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_256_CBC_SHA = 54;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_256_CBC_SHA = 55;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_256_CBC_SHA = 56;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 57;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_256_CBC_SHA = 58;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 65;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA = 66;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA = 67;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA = 68;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA = 69;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA = 70;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 132;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA = 133;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA = 134;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA = 135;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA = 136;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA = 137;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 186;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 187;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 188;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 189;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 190;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256 = 191;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 192;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 193;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 194;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 195;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 196;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256 = 197;
	public const CipherSuiteCode TLS_RSA_WITH_SEED_CBC_SHA = 150;
	public const CipherSuiteCode TLS_DH_DSS_WITH_SEED_CBC_SHA = 151;
	public const CipherSuiteCode TLS_DH_RSA_WITH_SEED_CBC_SHA = 152;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_SEED_CBC_SHA = 153;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_SEED_CBC_SHA = 154;
	public const CipherSuiteCode TLS_DH_anon_WITH_SEED_CBC_SHA = 155;
	public const CipherSuiteCode TLS_PSK_WITH_RC4_128_SHA = 138;
	public const CipherSuiteCode TLS_PSK_WITH_3DES_EDE_CBC_SHA = 139;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CBC_SHA = 140;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CBC_SHA = 141;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_RC4_128_SHA = 142;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA = 143;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_CBC_SHA = 144;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_CBC_SHA = 145;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_RC4_128_SHA = 146;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA = 147;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_128_CBC_SHA = 148;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_256_CBC_SHA = 149;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 49154;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 49155;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 49156;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 49157;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_NULL_SHA = 49158;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 49159;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 49160;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 49161;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 49162;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_NULL_SHA = 49163;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_RC4_128_SHA = 49164;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 49165;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 49166;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 49167;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_NULL_SHA = 49168;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_RC4_128_SHA = 49169;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 49170;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 49171;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 49172;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_NULL_SHA = 49173;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_RC4_128_SHA = 49174;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 49175;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 49176;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 49177;
	public const CipherSuiteCode TLS_PSK_WITH_NULL_SHA = 44;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_NULL_SHA = 45;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_NULL_SHA = 46;
	public const CipherSuiteCode TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 49178;
	public const CipherSuiteCode TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA = 49179;
	public const CipherSuiteCode TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA = 49180;
	public const CipherSuiteCode TLS_SRP_SHA_WITH_AES_128_CBC_SHA = 49181;
	public const CipherSuiteCode TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA = 49182;
	public const CipherSuiteCode TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA = 49183;
	public const CipherSuiteCode TLS_SRP_SHA_WITH_AES_256_CBC_SHA = 49184;
	public const CipherSuiteCode TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA = 49185;
	public const CipherSuiteCode TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA = 49186;
	public const CipherSuiteCode TLS_RSA_WITH_NULL_SHA256 = 59;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CBC_SHA256 = 60;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CBC_SHA256 = 61;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_128_CBC_SHA256 = 62;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_128_CBC_SHA256 = 63;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_128_CBC_SHA256 = 64;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_256_CBC_SHA256 = 104;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_256_CBC_SHA256 = 105;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_256_CBC_SHA256 = 106;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 107;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 108;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 109;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_GCM_SHA256 = 156;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_GCM_SHA384 = 157;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 158;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 159;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_128_GCM_SHA256 = 160;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_256_GCM_SHA384 = 161;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_128_GCM_SHA256 = 162;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_256_GCM_SHA384 = 163;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_128_GCM_SHA256 = 164;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_256_GCM_SHA384 = 165;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 166;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 167;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 49188;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 49189;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 49190;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 49191;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 49192;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 49193;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 49194;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 49195;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 49196;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 49197;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 49198;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 49199;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 49200;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 49201;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 49202;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_GCM_SHA256 = 168;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_GCM_SHA384 = 169;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 170;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 171;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 172;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 173;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CBC_SHA256 = 174;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CBC_SHA384 = 175;
	public const CipherSuiteCode TLS_PSK_WITH_NULL_SHA256 = 176;
	public const CipherSuiteCode TLS_PSK_WITH_NULL_SHA384 = 177;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 178;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 179;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_NULL_SHA256 = 180;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_NULL_SHA384 = 181;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 182;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 183;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_NULL_SHA256 = 184;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_NULL_SHA384 = 185;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_RC4_128_SHA = 49203;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA = 49204;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 49205;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 49206;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256 = 49207;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384 = 49208;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_NULL_SHA = 49209;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_NULL_SHA256 = 49210;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_NULL_SHA384 = 49211;
	public const CipherSuiteCode TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49266;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49267;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49268;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49269;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49270;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49271;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49272;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49273;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49274;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49275;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49276;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49277;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49278;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49279;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49280;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49281;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49282;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49283;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256 = 49284;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384 = 49285;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49286;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49287;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49288;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49289;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49290;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49291;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49292;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49293;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49294;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49295;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49296;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49297;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49298;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49299;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49300;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49301;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49302;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49303;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49304;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49305;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49306;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49307;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CCM = 49308;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CCM = 49309;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CCM = 49310;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CCM = 49311;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CCM_8 = 49312;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CCM_8 = 49313;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CCM_8 = 49314;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CCM_8 = 49315;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CCM = 49316;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CCM = 49317;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_CCM = 49318;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_CCM = 49319;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CCM_8 = 49320;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CCM_8 = 49321;
	public const CipherSuiteCode TLS_PSK_DHE_WITH_AES_128_CCM_8 = 49322;
	public const CipherSuiteCode TLS_PSK_DHE_WITH_AES_256_CCM_8 = 49323;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52243;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256 = 52244;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52245;
	public const CipherSuiteCode TLS_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58384;
	public const CipherSuiteCode TLS_RSA_WITH_SALSA20_SHA1 = 58385;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58386;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_SALSA20_SHA1 = 58387;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_ESTREAM_SALSA20_SHA1 = 58388;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_SALSA20_SHA1 = 58389;
	public const CipherSuiteCode TLS_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58390;
	public const CipherSuiteCode TLS_PSK_WITH_SALSA20_SHA1 = 58391;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58392;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_SALSA20_SHA1 = 58393;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58394;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_SALSA20_SHA1 = 58395;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58396;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_SALSA20_SHA1 = 58397;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58398;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_SALSA20_SHA1 = 58399;
	public const CipherSuiteCode TLS_FALLBACK_SCSV = 22016;
}

// Namespace: Mono.Security.Interface
public interface IMonoSslStream
{
	// Properties
	public abstract Boolean IsAuthenticated { get; }
	public abstract Boolean CanRead { get; }
	public abstract Boolean CanWrite { get; }
	public abstract Int64 Length { get; }
	public abstract Int64 Position { get; }
	public abstract AuthenticatedStream AuthenticatedStream { get; }
	public abstract Int32 ReadTimeout { get; set; }
	public abstract Int32 WriteTimeout { get; }
	public abstract X509Certificate InternalLocalCertificate { get; }

	// Methods

	// RVA: -1
	public abstract Void AuthenticateAsClient(String targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, Boolean checkCertificateRevocation) { }

	// RVA: -1
	public abstract Task AuthenticateAsClientAsync(String targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, Boolean checkCertificateRevocation) { }

	// RVA: -1
	public abstract Int32 Read(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: -1
	public abstract Void Write(Byte[] buffer, Int32 offset, Int32 count) { }

	// RVA: -1
	public abstract IAsyncResult BeginRead(Byte[] buffer, Int32 offset, Int32 count, AsyncCallback asyncCallback, Object asyncState) { }

	// RVA: -1
	public abstract Int32 EndRead(IAsyncResult asyncResult) { }

	// RVA: -1
	public abstract IAsyncResult BeginWrite(Byte[] buffer, Int32 offset, Int32 count, AsyncCallback asyncCallback, Object asyncState) { }

	// RVA: -1
	public abstract Void EndWrite(IAsyncResult asyncResult) { }

	// RVA: -1
	public abstract Boolean get_IsAuthenticated() { }

	// RVA: -1
	public abstract Boolean get_CanRead() { }

	// RVA: -1
	public abstract Boolean get_CanWrite() { }

	// RVA: -1
	public abstract Int64 get_Length() { }

	// RVA: -1
	public abstract Int64 get_Position() { }

	// RVA: -1
	public abstract Void SetLength(Int64 value) { }

	// RVA: -1
	public abstract AuthenticatedStream get_AuthenticatedStream() { }

	// RVA: -1
	public abstract Int32 get_ReadTimeout() { }

	// RVA: -1
	public abstract Void set_ReadTimeout(Int32 value) { }

	// RVA: -1
	public abstract Int32 get_WriteTimeout() { }

	// RVA: -1
	public abstract X509Certificate get_InternalLocalCertificate() { }

}

// Namespace: Mono.Security.Interface
public class MonoTlsConnectionInfo
{
	// Fields
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; // 0x10
	private TlsProtocols <ProtocolVersion>k__BackingField; // 0x14
	private String <PeerDomainName>k__BackingField; // 0x18

	// Properties
	public CipherSuiteCode CipherSuiteCode { get; set; }
	public TlsProtocols ProtocolVersion { get; set; }
	public String PeerDomainName { set; }

	// Methods

	// RVA: 0xFFFFFFFF759DFA24
	public CipherSuiteCode get_CipherSuiteCode() { }

	// RVA: 0xFFFFFFFF759DFA2C
	public Void set_CipherSuiteCode(CipherSuiteCode value) { }

	// RVA: 0xFFFFFFFF759DFA34
	public TlsProtocols get_ProtocolVersion() { }

	// RVA: 0xFFFFFFFF759DFA3C
	public Void set_ProtocolVersion(TlsProtocols value) { }

	// RVA: 0xFFFFFFFF759DFA44
	public Void set_PeerDomainName(String value) { }

	// RVA: 0xFFFFFFFF759DFA4C
	public override String ToString() { }

	// RVA: 0xFFFFFFFF759DFAF4
	public Void .ctor() { }

}

// Namespace: Mono.Security.Interface
public enum MonoSslPolicyErrors
{
	// Fields
	public Int32 value__; // 0x10
	public const MonoSslPolicyErrors None = 0;
	public const MonoSslPolicyErrors RemoteCertificateNotAvailable = 1;
	public const MonoSslPolicyErrors RemoteCertificateNameMismatch = 2;
	public const MonoSslPolicyErrors RemoteCertificateChainErrors = 4;
}

// Namespace: Mono.Security.Interface
public sealed class MonoRemoteCertificateValidationCallback
{
	// Methods

	// RVA: 0xFFFFFFFF759DF500
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF759DF514
	public virtual Boolean Invoke(String targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

	// RVA: 0xFFFFFFFF759DF924
	public virtual IAsyncResult BeginInvoke(String targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759DF9F8
	public virtual Boolean EndInvoke(IAsyncResult result) { }

}

// Namespace: Mono.Security.Interface
public sealed class MonoLocalCertificateSelectionCallback
{
	// Methods

	// RVA: 0xFFFFFFFF759DF070
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF759DF084
	public virtual X509Certificate Invoke(String targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

	// RVA: 0xFFFFFFFF759DF494
	public virtual IAsyncResult BeginInvoke(String targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759DF4F4
	public virtual X509Certificate EndInvoke(IAsyncResult result) { }

}

// Namespace: Mono.Security.Interface
public abstract class MonoTlsProvider
{
	// Properties
	public abstract Guid ID { get; }
	public abstract String Name { get; }
	public abstract Boolean SupportsSslStream { get; }
	public abstract Boolean SupportsConnectionInfo { get; }
	public abstract Boolean SupportsMonoExtensions { get; }
	public abstract SslProtocols SupportedProtocols { get; }
	internal abstract Boolean SupportsCleanShutdown { get; }

	// Methods

	// RVA: 0xFFFFFFFF759DFAFC
	internal Void .ctor() { }

	// RVA: -1
	public abstract Guid get_ID() { }

	// RVA: -1
	public abstract String get_Name() { }

	// RVA: -1
	public abstract Boolean get_SupportsSslStream() { }

	// RVA: -1
	public abstract Boolean get_SupportsConnectionInfo() { }

	// RVA: -1
	public abstract Boolean get_SupportsMonoExtensions() { }

	// RVA: -1
	public abstract SslProtocols get_SupportedProtocols() { }

	// RVA: -1
	public abstract IMonoSslStream CreateSslStream(Stream innerStream, Boolean leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: -1
	internal abstract IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, Boolean leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: -1
	internal abstract Boolean ValidateCertificate(ICertificateValidator2 validator, String targetHost, Boolean serverMode, X509CertificateCollection certificates, Boolean wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref Int32 status11) { }

	// RVA: -1
	internal abstract Boolean get_SupportsCleanShutdown() { }

}

// Namespace: Mono.Security.Interface
public static class MonoTlsProviderFactory
{
	// Methods

	// RVA: 0xFFFFFFFF759DFB04
	public static MonoTlsProvider GetProvider() { }

}

// Namespace: Mono.Security.Interface
public sealed class MonoTlsSettings
{
	// Fields
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; // 0x10
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; // 0x18
	private Nullable<T0> <CertificateValidationTime>k__BackingField; // 0x20
	private X509CertificateCollection <TrustAnchors>k__BackingField; // 0x30
	private Object <UserSettings>k__BackingField; // 0x38
	private String[] <CertificateSearchPaths>k__BackingField; // 0x40
	private Boolean <SendCloseNotify>k__BackingField; // 0x48
	private Nullable<T0> <EnabledProtocols>k__BackingField; // 0x4C
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; // 0x58
	private Boolean cloned; // 0x60
	private Boolean checkCertName; // 0x61
	private Boolean checkCertRevocationStatus; // 0x62
	private Nullable<T0> useServicePointManagerCallback; // 0x63
	private Boolean skipSystemValidators; // 0x65
	private Boolean callbackNeedsChain; // 0x66
	private ICertificateValidator certificateValidator; // 0x68
	private static MonoTlsSettings defaultSettings; // 0x0

	// Properties
	public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }
	public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback { get; set; }
	public Nullable<T0> UseServicePointManagerCallback { get; set; }
	public Boolean CallbackNeedsCertificateChain { get; }
	public Nullable<T0> CertificateValidationTime { get; set; }
	public X509CertificateCollection TrustAnchors { get; set; }
	public Object UserSettings { get; set; }
	internal String[] CertificateSearchPaths { get; set; }
	internal Boolean SendCloseNotify { get; set; }
	public Nullable<T0> EnabledProtocols { get; set; }
	public CipherSuiteCode[] EnabledCiphers { get; set; }
	public static MonoTlsSettings DefaultSettings { get; }
	public ICertificateValidator CertificateValidator { get; }

	// Methods

	// RVA: 0xFFFFFFFF759DFB7C
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	// RVA: 0xFFFFFFFF759DFB84
	public Void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	// RVA: 0xFFFFFFFF759DFB8C
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	// RVA: 0xFFFFFFFF759DFB94
	public Void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	// RVA: 0xFFFFFFFF759DFB9C
	public Nullable<T0> get_UseServicePointManagerCallback() { }

	// RVA: 0xFFFFFFFF759DFBA4
	public Void set_UseServicePointManagerCallback(Nullable<T0> value) { }

	// RVA: 0xFFFFFFFF759DFBAC
	public Boolean get_CallbackNeedsCertificateChain() { }

	// RVA: 0xFFFFFFFF759DFBB4
	public Nullable<T0> get_CertificateValidationTime() { }

	// RVA: 0xFFFFFFFF759DFBC0
	public Void set_CertificateValidationTime(Nullable<T0> value) { }

	// RVA: 0xFFFFFFFF759DFBC8
	public X509CertificateCollection get_TrustAnchors() { }

	// RVA: 0xFFFFFFFF759DFBD0
	public Void set_TrustAnchors(X509CertificateCollection value) { }

	// RVA: 0xFFFFFFFF759DFBD8
	public Object get_UserSettings() { }

	// RVA: 0xFFFFFFFF759DFBE0
	public Void set_UserSettings(Object value) { }

	// RVA: 0xFFFFFFFF759DFBE8
	internal String[] get_CertificateSearchPaths() { }

	// RVA: 0xFFFFFFFF759DFBF0
	internal Void set_CertificateSearchPaths(String[] value) { }

	// RVA: 0xFFFFFFFF759DFBF8
	internal Boolean get_SendCloseNotify() { }

	// RVA: 0xFFFFFFFF759DFC00
	internal Void set_SendCloseNotify(Boolean value) { }

	// RVA: 0xFFFFFFFF759DFC08
	public Nullable<T0> get_EnabledProtocols() { }

	// RVA: 0xFFFFFFFF759DFC10
	public Void set_EnabledProtocols(Nullable<T0> value) { }

	// RVA: 0xFFFFFFFF759DFC18
	public CipherSuiteCode[] get_EnabledCiphers() { }

	// RVA: 0xFFFFFFFF759DFC20
	public Void set_EnabledCiphers(CipherSuiteCode[] value) { }

	// RVA: 0xFFFFFFFF759DFC28
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759DFC3C
	public static MonoTlsSettings get_DefaultSettings() { }

	// RVA: 0xFFFFFFFF759DFCC8
	public static MonoTlsSettings CopyDefaultSettings() { }

	// RVA: 0xFFFFFFFF759DFD3C
	public ICertificateValidator get_CertificateValidator() { }

	// RVA: 0xFFFFFFFF759DFD44
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	// RVA: 0xFFFFFFFF759DFCE4
	public MonoTlsSettings Clone() { }

	// RVA: 0xFFFFFFFF759DFDC8
	private Void .ctor(MonoTlsSettings other) { }

}

// Namespace: Mono.Security.Interface
public sealed class TlsException
{
	// Fields
	private Alert alert; // 0x88

	// Methods

	// RVA: 0xFFFFFFFF759DFF20
	public Void .ctor(Alert alert, String message) { }

	// RVA: 0xFFFFFFFF759DFF84
	public Void .ctor(AlertDescription description, String message) { }

}

// Namespace: Mono.Security.Interface
public enum TlsProtocols
{
	// Fields
	public Int32 value__; // 0x10
	public const TlsProtocols Zero = 0;
	public const TlsProtocols Tls10Client = 128;
	public const TlsProtocols Tls10Server = 64;
	public const TlsProtocols Tls10 = 192;
	public const TlsProtocols Tls11Client = 512;
	public const TlsProtocols Tls11Server = 256;
	public const TlsProtocols Tls11 = 768;
	public const TlsProtocols Tls12Client = 2048;
	public const TlsProtocols Tls12Server = 1024;
	public const TlsProtocols Tls12 = 3072;
	public const TlsProtocols ClientMask = 2688;
	public const TlsProtocols ServerMask = 1344;
}

// Namespace: Mono.Security.Cryptography
public sealed class CryptoConvert
{
	// Methods

	// RVA: 0xFFFFFFFF759DAD4C
	public static String ToHex(Byte[] input) { }

}

// Namespace: Mono.Security.Cryptography
public abstract class MD2
{
	// Methods

	// RVA: 0xFFFFFFFF759DAE5C
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF759DAE88
	public static MD2 Create() { }

}

// Namespace: Mono.Security.Cryptography
public class MD2Managed
{
	// Fields
	private Byte[] state; // 0x28
	private Byte[] checksum; // 0x30
	private Byte[] buffer; // 0x38
	private Int32 count; // 0x40
	private Byte[] x; // 0x48
	private static readonly Byte[] PI_SUBST; // 0x0

	// Methods

	// RVA: 0xFFFFFFFF759DAF88
	private Byte[] Padding(Int32 nLength) { }

	// RVA: 0xFFFFFFFF759DAED8
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759DAFE4
	public override Void Initialize() { }

	// RVA: 0xFFFFFFFF759DB050
	protected override Void HashCore(Byte[] array, Int32 ibStart, Int32 cbSize) { }

	// RVA: 0xFFFFFFFF759DB3CC
	protected override Byte[] HashFinal() { }

	// RVA: 0xFFFFFFFF759DB140
	private Void MD2Transform(Byte[] state, Byte[] checksum, Byte[] block, Int32 index) { }

	// RVA: 0xFFFFFFFF759DB4CC
	private static Void .cctor() { }

}

// Namespace: Mono.Security.Cryptography
public abstract class MD4
{
	// Methods

	// RVA: 0xFFFFFFFF759DB548
	protected Void .ctor() { }

	// RVA: 0xFFFFFFFF759DB574
	public static MD4 Create() { }

}

// Namespace: Mono.Security.Cryptography
public class MD4Managed
{
	// Fields
	private UInt32[] state; // 0x28
	private Byte[] buffer; // 0x30
	private UInt32[] count; // 0x38
	private UInt32[] x; // 0x40
	private Byte[] digest; // 0x48

	// Methods

	// RVA: 0xFFFFFFFF759DB5C4
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759DB69C
	public override Void Initialize() { }

	// RVA: 0xFFFFFFFF759DB764
	protected override Void HashCore(Byte[] array, Int32 ibStart, Int32 cbSize) { }

	// RVA: 0xFFFFFFFF759DBF24
	protected override Byte[] HashFinal() { }

	// RVA: 0xFFFFFFFF759DC108
	private Byte[] Padding(Int32 nLength) { }

	// RVA: 0xFFFFFFFF759DC150
	private UInt32 F(UInt32 x, UInt32 y, UInt32 z) { }

	// RVA: 0xFFFFFFFF759DC160
	private UInt32 G(UInt32 x, UInt32 y, UInt32 z) { }

	// RVA: 0xFFFFFFFF759DC174
	private UInt32 H(UInt32 x, UInt32 y, UInt32 z) { }

	// RVA: 0xFFFFFFFF759DC180
	private UInt32 ROL(UInt32 x, Byte n) { }

	// RVA: 0xFFFFFFFF759DC18C
	private Void FF(ref UInt32 a, UInt32 b, UInt32 c, UInt32 d, UInt32 x, Byte s) { }

	// RVA: 0xFFFFFFFF759DC1B4
	private Void GG(ref UInt32 a, UInt32 b, UInt32 c, UInt32 d, UInt32 x, Byte s) { }

	// RVA: 0xFFFFFFFF759DC1EC
	private Void HH(ref UInt32 a, UInt32 b, UInt32 c, UInt32 d, UInt32 x, Byte s) { }

	// RVA: 0xFFFFFFFF759DC010
	private Void Encode(Byte[] output, UInt32[] input) { }

	// RVA: 0xFFFFFFFF759DC21C
	private Void Decode(UInt32[] output, Byte[] input, Int32 index) { }

	// RVA: 0xFFFFFFFF759DB8A4
	private Void MD4Transform(UInt32[] state, Byte[] block, Int32 index) { }

}

// Namespace: Mono.Security.Cryptography
public sealed class PKCS1
{
	// Fields
	private static Byte[] emptySHA1; // 0x0
	private static Byte[] emptySHA256; // 0x8
	private static Byte[] emptySHA384; // 0x10
	private static Byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF759DC2C8
	internal static String HashNameFromOid(String oid, Boolean throwOnError) { }

	// RVA: 0xFFFFFFFF759DC690
	internal static HashAlgorithm CreateFromOid(String oid) { }

	// RVA: 0xFFFFFFFF759DC6F4
	internal static HashAlgorithm CreateFromName(String name) { }

	// RVA: 0xFFFFFFFF759DCB38
	private static Void .cctor() { }

}

// Namespace: Mono.Security.Cryptography
public sealed class PKCS8
{}

// Namespace: 
public class PrivateKeyInfo
{
	// Fields
	private Int32 _version; // 0x10
	private String _algorithm; // 0x18
	private Byte[] _key; // 0x20
	private ArrayList _list; // 0x28

	// Properties
	public Byte[] PrivateKey { get; }

	// Methods

	// RVA: 0xFFFFFFFF759DD074
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759DD0C0
	public Void .ctor(Byte[] data) { }

	// RVA: 0xFFFFFFFF759DD354
	public Byte[] get_PrivateKey() { }

	// RVA: 0xFFFFFFFF759DD0EC
	private Void Decode(Byte[] data) { }

	// RVA: 0xFFFFFFFF759DD3A4
	private static Byte[] RemoveLeadingZero(Byte[] bigInt) { }

	// RVA: 0xFFFFFFFF759DD428
	private static Byte[] Normalize(Byte[] bigInt, Int32 length) { }

	// RVA: 0xFFFFFFFF759DD4B8
	public static RSA DecodeRSA(Byte[] keypair) { }

	// RVA: 0xFFFFFFFF759DD8D0
	public static Byte[] Encode(RSA rsa) { }

	// RVA: 0xFFFFFFFF759DDA9C
	public static DSA DecodeDSA(Byte[] privateKey, DSAParameters dsaParameters) { }

	// RVA: 0xFFFFFFFF759DDBB4
	public static Byte[] Encode(DSA dsa) { }

	// RVA: 0xFFFFFFFF759DDC08
	public static Byte[] Encode(AsymmetricAlgorithm aa) { }

}

// Namespace: 
public class EncryptedPrivateKeyInfo
{
	// Fields
	private String _algorithm; // 0x10
	private Byte[] _salt; // 0x18
	private Int32 _iterations; // 0x20
	private Byte[] _data; // 0x28

	// Properties
	public String Algorithm { get; }
	public Byte[] EncryptedData { get; }
	public Byte[] Salt { get; }
	public Int32 IterationCount { get; }

	// Methods

	// RVA: 0xFFFFFFFF759DCC7C
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF759DCC84
	public Void .ctor(Byte[] data) { }

	// RVA: 0xFFFFFFFF759DCF6C
	public String get_Algorithm() { }

	// RVA: 0xFFFFFFFF759DCF74
	public Byte[] get_EncryptedData() { }

	// RVA: 0xFFFFFFFF759DCFC4
	public Byte[] get_Salt() { }

	// RVA: 0xFFFFFFFF759DD06C
	public Int32 get_IterationCount() { }

	// RVA: 0xFFFFFFFF759DCCB4
	private Void Decode(Byte[] data) { }

}

// Namespace: Mono.Security.Cryptography
public class RSAManaged
{
	// Fields
	private Boolean isCRTpossible; // 0x20
	private Boolean keypairGenerated; // 0x21
	private Boolean m_disposed; // 0x22
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	private KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public Boolean PublicOnly { get; }

	// Methods

	// RVA: 0xFFFFFFFF759DDD2C
	private Void GenerateKeyPair() { }

	// RVA: 0xFFFFFFFF759DE4F4
	public Boolean get_PublicOnly() { }

	// RVA: 0xFFFFFFFF759DE588
	public override RSAParameters ExportParameters(Boolean includePrivateParameters) { }

	// RVA: 0xFFFFFFFF759DE92C
	public override Void ImportParameters(RSAParameters parameters) { }

	// RVA: 0xFFFFFFFF759DE898
	private Byte[] GetPaddedValue(BigInteger value, Int32 length) { }

}

// Namespace: 
public sealed class KeyGeneratedEventHandler
{
	// Methods

	// RVA: 0xFFFFFFFF759DEDA8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF759DE128
	public virtual Void Invoke(Object sender, EventArgs e) { }

	// RVA: 0xFFFFFFFF759DEDBC
	public virtual IAsyncResult BeginInvoke(Object sender, EventArgs e, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759DEE18
	public virtual Void EndInvoke(IAsyncResult result) { }

}

// Namespace: Mono.Math
public class BigInteger
{
	// Fields
	private UInt32 length; // 0x10
	private UInt32[] data; // 0x18
	internal static readonly UInt32[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0xFFFFFFFF759D4818
	public Void .ctor(Sign sign, UInt32 len) { }

	// RVA: 0xFFFFFFFF759D486C
	public Void .ctor(BigInteger bi) { }

	// RVA: 0xFFFFFFFF759D4904
	public Void .ctor(BigInteger bi, UInt32 len) { }

	// RVA: 0xFFFFFFFF759D49D8
	public Void .ctor(Byte[] inData) { }

	// RVA: 0xFFFFFFFF759D4C48
	public Void .ctor(UInt32 ui) { }

	// RVA: 0xFFFFFFFF759D4C98
	public static BigInteger op_Implicit(UInt32 value) { }

	// RVA: 0xFFFFFFFF759D4D1C
	public static BigInteger op_Implicit(Int32 value) { }

	// RVA: 0xFFFFFFFF759D4DE0
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xFFFFFFFF759D52E0
	public static UInt32 op_Modulus(BigInteger bi, UInt32 ui) { }

	// RVA: 0xFFFFFFFF759D535C
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xFFFFFFFF759D57E4
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xFFFFFFFF759D5818
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xFFFFFFFF759D5ACC
	public static BigInteger op_LeftShift(BigInteger bi1, Int32 shiftVal) { }

	// RVA: 0xFFFFFFFF759D5CD8
	public static BigInteger op_RightShift(BigInteger bi1, Int32 shiftVal) { }

	// RVA: 0xFFFFFFFF759D5E9C
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0xFFFFFFFF759D5F24
	public static BigInteger GenerateRandom(Int32 bits, RandomNumberGenerator rng) { }

	// RVA: 0xFFFFFFFF759D60B8
	public static BigInteger GenerateRandom(Int32 bits) { }

	// RVA: 0xFFFFFFFF759D611C
	public Int32 BitCount() { }

	// RVA: 0xFFFFFFFF759D61A0
	public Boolean TestBit(Int32 bitNum) { }

	// RVA: 0xFFFFFFFF759D626C
	public Void SetBit(UInt32 bitNum) { }

	// RVA: 0xFFFFFFFF759D6274
	public Void SetBit(UInt32 bitNum, Boolean value) { }

	// RVA: 0xFFFFFFFF759D62F4
	public Int32 LowestSetBit() { }

	// RVA: 0xFFFFFFFF759D6378
	public Byte[] GetBytes() { }

	// RVA: 0xFFFFFFFF759D4F28
	public static Boolean op_Equality(BigInteger bi1, UInt32 ui) { }

	// RVA: 0xFFFFFFFF759D64B4
	public static Boolean op_Inequality(BigInteger bi1, UInt32 ui) { }

	// RVA: 0xFFFFFFFF759D652C
	public static Boolean op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xFFFFFFFF759D65DC
	public static Boolean op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xFFFFFFFF759D668C
	public static Boolean op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xFFFFFFFF759D66A8
	public static Boolean op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xFFFFFFFF759D66C0
	public static Boolean op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xFFFFFFFF759D66DC
	public static Boolean op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xFFFFFFFF759D66F8
	public String ToString(UInt32 radix) { }

	// RVA: 0xFFFFFFFF759D6750
	public String ToString(UInt32 radix, String characterSet) { }

	// RVA: 0xFFFFFFFF759D4BE4
	private Void Normalize() { }

	// RVA: 0xFFFFFFFF759D69C0
	public override Int32 GetHashCode() { }

	// RVA: 0xFFFFFFFF759D6A20
	public override String ToString() { }

	// RVA: 0xFFFFFFFF759D6A6C
	public override Boolean Equals(Object o) { }

	// RVA: 0xFFFFFFFF759D6BAC
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0xFFFFFFFF759D6EF0
	public static BigInteger GeneratePseudoPrime(Int32 bits) { }

	// RVA: 0xFFFFFFFF759D6F60
	public Void Incr2() { }

	// RVA: 0xFFFFFFFF759D6FF8
	private static Void .cctor() { }

}

// Namespace: 
public enum Sign
{
	// Fields
	public Int32 value__; // 0x10
	public const Sign Negative = 4294967295;
	public const Sign Zero = 0;
	public const Sign Positive = 1;
}

// Namespace: 
public sealed class ModulusRing
{
	// Fields
	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF759D7670
	public Void .ctor(BigInteger modulus) { }

	// RVA: 0xFFFFFFFF759D7970
	public Void BarrettReduction(BigInteger x) { }

	// RVA: 0xFFFFFFFF759D7C74
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0xFFFFFFFF759D77B4
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0xFFFFFFFF759D7D78
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	// RVA: 0xFFFFFFFF759D7EBC
	public BigInteger Pow(UInt32 b, BigInteger exp) { }

}

// Namespace: 
private sealed class Kernel
{
	// Methods

	// RVA: 0xFFFFFFFF759D50F0
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0xFFFFFFFF759D7074
	public static Void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0xFFFFFFFF759D717C
	public static Void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xFFFFFFFF759D4FA0
	public static Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xFFFFFFFF759D6934
	public static UInt32 SingleByteDivideInPlace(BigInteger n, UInt32 d) { }

	// RVA: 0xFFFFFFFF759D52E4
	public static UInt32 DwordMod(BigInteger n, UInt32 d) { }

	// RVA: 0xFFFFFFFF759D7320
	public static BigInteger[] DwordDivMod(BigInteger n, UInt32 d) { }

	// RVA: 0xFFFFFFFF759D5394
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xFFFFFFFF759D5AD0
	public static BigInteger LeftShift(BigInteger bi, Int32 n) { }

	// RVA: 0xFFFFFFFF759D5CDC
	public static BigInteger RightShift(BigInteger bi, Int32 n) { }

	// RVA: 0xFFFFFFFF759D59EC
	public static Void Multiply(UInt32[] x, UInt32 xOffset, UInt32 xLen, UInt32[] y, UInt32 yOffset, UInt32 yLen, UInt32[] d, UInt32 dOffset) { }

	// RVA: 0xFFFFFFFF759D74AC
	public static Void MultiplyMod2p32pmod(UInt32[] x, Int32 xOffset, Int32 xLen, UInt32[] y, Int32 yOffest, Int32 yLen, UInt32[] d, Int32 dOffset, Int32 mod) { }

	// RVA: 0xFFFFFFFF759D75A8
	public static UInt32 modInverse(BigInteger bi, UInt32 modulus) { }

	// RVA: 0xFFFFFFFF759D6BB0
	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }

}

// Namespace: Mono.Math.Prime
public enum ConfidenceFactor
{
	// Fields
	public Int32 value__; // 0x10
	public const ConfidenceFactor ExtraLow = 0;
	public const ConfidenceFactor Low = 1;
	public const ConfidenceFactor Medium = 2;
	public const ConfidenceFactor High = 3;
	public const ConfidenceFactor ExtraHigh = 4;
	public const ConfidenceFactor Provable = 5;
}

// Namespace: Mono.Math.Prime
public sealed class PrimalityTest
{
	// Methods

	// RVA: 0xFFFFFFFF759D7FD8
	public Void .ctor(Object object, IntPtr method) { }

	// RVA: 0xFFFFFFFF759D83D8
	public virtual Boolean Invoke(BigInteger bi, ConfidenceFactor confidence) { }

	// RVA: 0xFFFFFFFF759D8808
	public virtual IAsyncResult BeginInvoke(BigInteger bi, ConfidenceFactor confidence, AsyncCallback callback, Object object) { }

	// RVA: 0xFFFFFFFF759D88C8
	public virtual Boolean EndInvoke(IAsyncResult result) { }

}

// Namespace: Mono.Math.Prime
public sealed class PrimalityTests
{
	// Methods

	// RVA: 0xFFFFFFFF759D88F4
	private static Int32 GetSPPRounds(BigInteger bi, ConfidenceFactor confidence) { }

	// RVA: 0xFFFFFFFF759D8AB4
	public static Boolean RabinMillerTest(BigInteger n, ConfidenceFactor confidence) { }

}

// Namespace: Mono.Math.Prime.Generator
public abstract class PrimeGeneratorBase
{
	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual Int32 TrialDivisionBounds { get; }

	// Methods

	// RVA: 0xFFFFFFFF759D7F58
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0xFFFFFFFF759D7F60
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0xFFFFFFFF759D7FEC
	public virtual Int32 get_TrialDivisionBounds() { }

	// RVA: -1
	public abstract BigInteger GenerateNewPrime(Int32 bits) { }

	// RVA: 0xFFFFFFFF759D7FF4
	protected Void .ctor() { }

}

// Namespace: Mono.Math.Prime.Generator
public class SequentialSearchPrimeGeneratorBase
{
	// Methods

	// RVA: 0xFFFFFFFF759D7FFC
	protected virtual BigInteger GenerateSearchBase(Int32 bits, Object context) { }

	// RVA: 0xFFFFFFFF759D8078
	public override BigInteger GenerateNewPrime(Int32 bits) { }

	// RVA: 0xFFFFFFFF759D808C
	public virtual BigInteger GenerateNewPrime(Int32 bits, Object context) { }

	// RVA: 0xFFFFFFFF759D8800
	protected virtual Boolean IsPrimeAcceptable(BigInteger bi, Object context) { }

	// RVA: 0xFFFFFFFF759D6F58
	public Void .ctor() { }

}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=3 12D04472A8285260EA12FD3813CDFA9F2D2B548C; // 0x0
	internal static readonly __StaticArrayInitTypeSize=3 13A35EF1A549297C70E2AD46045BBD2ECA17852D; // 0x3
	internal static readonly Int64 16968835DEF6DD3BB86EABA9DEC53BF41851CD6D; // 0x8
	internal static readonly __StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD; // 0x10
	internal static readonly __StaticArrayInitTypeSize=3 235D99572263B22ADFEE10FDA0C25E12F4D94FFC; // 0x13
	internal static readonly __StaticArrayInitTypeSize=14 2D3CF0F15AC2DDEC2956EA1B7BBE43FB8B923130; // 0x16
	internal static readonly __StaticArrayInitTypeSize=64 320B018758ECE3752FFEDBAEB1A6DB67C80B9359; // 0x24
	internal static readonly __StaticArrayInitTypeSize=3 3E3442C7396F3F2BB4C7348F4A2074C7DC677D68; // 0x64
	internal static readonly __StaticArrayInitTypeSize=48 4E3B533C39447AAEB59A8E48FABD7E15B5B5D195; // 0x67
	internal static readonly __StaticArrayInitTypeSize=10 56DFA5053B3131883637F53219E7D88CCEF35949; // 0x97
	internal static readonly __StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D; // 0xA1
	internal static readonly __StaticArrayInitTypeSize=3132 6E5DC824F803F8565AF31B42199DAE39FE7F4EA9; // 0xAA
	internal static readonly Int64 6FA00AC9FFFD87F82A38A7F9ECC8134F4A7052AF; // 0xCE8
	internal static readonly __StaticArrayInitTypeSize=3 736D39815215889F11249D9958F6ED12D37B9F57; // 0xCF0
	internal static readonly __StaticArrayInitTypeSize=3 86F4F563FA2C61798AE6238D789139739428463A; // 0xCF3
	internal static readonly __StaticArrayInitTypeSize=3 97FB30C84FF4A41CD4625B44B2940BFC8DB43003; // 0xCF6
	internal static readonly __StaticArrayInitTypeSize=64 9A9C3962CD4753376E3507C8CB5FD8FCC4B4EDB5; // 0xCF9
	internal static readonly __StaticArrayInitTypeSize=3 9BB00D1FCCBAF03165447FC8028E7CA07CA9FE88; // 0xD39
	internal static readonly __StaticArrayInitTypeSize=3 A323DB0813C4D072957BA6FDA79D9776674CD06B; // 0xD3C
	internal static readonly Int64 AEA5F1CC5CFE1660539EDD691FE017F775F63A0D; // 0xD40
	internal static readonly __StaticArrayInitTypeSize=20 BE1BDEC0AA74B4DCB079943E70528096CCA985F8; // 0xD48
	internal static readonly __StaticArrayInitTypeSize=3 BF477463CE2F5EF38FC4C644BBBF4DF109E7670A; // 0xD5C
	internal static readonly __StaticArrayInitTypeSize=64 CF0B42666EF5E37EDEA0AB8E173E42C196D03814; // 0xD5F
	internal static readonly __StaticArrayInitTypeSize=32 D28E8ABDBD777A482CE0EE5C24814ACAE52AABFE; // 0xD9F
	internal static readonly __StaticArrayInitTypeSize=256 D2C5BAE967587C6F3D9F2C4551911E0575A1101F; // 0xDBF
	internal static readonly __StaticArrayInitTypeSize=64 E75835D001C843F156FBA01B001DFE1B8029AC17; // 0xEBF
	internal static readonly __StaticArrayInitTypeSize=10 EC5BB4F59D4B9B2E9ECD3904D44A8275F23AFB11; // 0xEFF
	internal static readonly __StaticArrayInitTypeSize=3 EC83FB16C20052BEE2B4025159BC2ED45C9C70C3; // 0xF09

	// Methods

	// RVA: 0xFFFFFFFF759D4798
	internal static UInt32 ComputeStringHash(String s) { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=3
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=9
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=10
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=14
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=20
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=32
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=48
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=64
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=256
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=3132
{}


