using System;

namespace Org.BouncyCastle.Bcpg;

public class RevocationKey : SignatureSubpacket
{
	public virtual RevocationKeyTag SignatureClass => (RevocationKeyTag)GetData()[0];

	public virtual PublicKeyAlgorithmTag Algorithm => (PublicKeyAlgorithmTag)GetData()[1];

	public RevocationKey(bool isCritical, bool isLongLength, byte[] data)
		: base(SignatureSubpacketTag.RevocationKey, isCritical, isLongLength, data)
	{
	}

	public RevocationKey(bool isCritical, RevocationKeyTag signatureClass, PublicKeyAlgorithmTag keyAlgorithm, byte[] fingerprint)
		: base(SignatureSubpacketTag.RevocationKey, isCritical, isLongLength: false, CreateData(signatureClass, keyAlgorithm, fingerprint))
	{
	}

	private static byte[] CreateData(RevocationKeyTag signatureClass, PublicKeyAlgorithmTag keyAlgorithm, byte[] fingerprint)
	{
		byte[] data = new byte[2 + fingerprint.Length];
		data[0] = (byte)signatureClass;
		data[1] = (byte)keyAlgorithm;
		Array.Copy(fingerprint, 0, data, 2, fingerprint.Length);
		return data;
	}

	public virtual byte[] GetFingerprint()
	{
		byte[] array = GetData();
		byte[] fingerprint = new byte[array.Length - 2];
		Array.Copy(array, 2, fingerprint, 0, fingerprint.Length);
		return fingerprint;
	}
}
