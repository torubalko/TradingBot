using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Cms;

public class RecipientID : X509CertStoreSelector
{
	private byte[] keyIdentifier;

	public byte[] KeyIdentifier
	{
		get
		{
			return Arrays.Clone(keyIdentifier);
		}
		set
		{
			keyIdentifier = Arrays.Clone(value);
		}
	}

	public override int GetHashCode()
	{
		int code = Arrays.GetHashCode(keyIdentifier) ^ Arrays.GetHashCode(base.SubjectKeyIdentifier);
		BigInteger serialNumber = base.SerialNumber;
		if (serialNumber != null)
		{
			code ^= serialNumber.GetHashCode();
		}
		X509Name issuer = base.Issuer;
		if (issuer != null)
		{
			code ^= issuer.GetHashCode();
		}
		return code;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is RecipientID id))
		{
			return false;
		}
		if (Arrays.AreEqual(keyIdentifier, id.keyIdentifier) && Arrays.AreEqual(base.SubjectKeyIdentifier, id.SubjectKeyIdentifier) && object.Equals(base.SerialNumber, id.SerialNumber))
		{
			return X509CertStoreSelector.IssuersMatch(base.Issuer, id.Issuer);
		}
		return false;
	}
}
