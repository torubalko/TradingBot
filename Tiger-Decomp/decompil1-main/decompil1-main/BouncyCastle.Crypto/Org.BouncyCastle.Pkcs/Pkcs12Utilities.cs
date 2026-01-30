using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Pkcs;

public class Pkcs12Utilities
{
	public static byte[] ConvertToDefiniteLength(byte[] berPkcs12File)
	{
		return Pfx.GetInstance(berPkcs12File).GetEncoded("DER");
	}

	public static byte[] ConvertToDefiniteLength(byte[] berPkcs12File, char[] passwd)
	{
		Pfx instance = Pfx.GetInstance(berPkcs12File);
		ContentInfo info = instance.AuthSafe;
		info = new ContentInfo(content: new DerOctetString(Asn1Object.FromByteArray(Asn1OctetString.GetInstance(info.Content).GetOctets()).GetEncoded("DER")), contentType: info.ContentType);
		MacData mData = instance.MacData;
		try
		{
			int itCount = mData.IterationCount.IntValue;
			byte[] data = Asn1OctetString.GetInstance(info.Content).GetOctets();
			byte[] res = Pkcs12Store.CalculatePbeMac(mData.Mac.AlgorithmID.Algorithm, mData.GetSalt(), itCount, passwd, wrongPkcs12Zero: false, data);
			mData = new MacData(new DigestInfo(new AlgorithmIdentifier(mData.Mac.AlgorithmID.Algorithm, DerNull.Instance), res), mData.GetSalt(), itCount);
		}
		catch (Exception ex)
		{
			throw new IOException("error constructing MAC: " + ex.ToString());
		}
		return new Pfx(info, mData).GetEncoded("DER");
	}
}
