using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crmf;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cmp;

public class ProtectedPkiMessage
{
	private readonly PkiMessage pkiMessage;

	public PkiHeader Header => pkiMessage.Header;

	public PkiBody Body => pkiMessage.Body;

	public bool HasPasswordBasedMacProtected => Header.ProtectionAlg.Algorithm.Equals(CmpObjectIdentifiers.passwordBasedMac);

	public ProtectedPkiMessage(GeneralPkiMessage pkiMessage)
	{
		if (!pkiMessage.HasProtection)
		{
			throw new ArgumentException("pki message not protected");
		}
		this.pkiMessage = pkiMessage.ToAsn1Structure();
	}

	public ProtectedPkiMessage(PkiMessage pkiMessage)
	{
		if (pkiMessage.Header.ProtectionAlg == null)
		{
			throw new ArgumentException("pki message not protected");
		}
		this.pkiMessage = pkiMessage;
	}

	public PkiMessage ToAsn1Message()
	{
		return pkiMessage;
	}

	public X509Certificate[] GetCertificates()
	{
		CmpCertificate[] certs = pkiMessage.GetExtraCerts();
		if (certs == null)
		{
			return new X509Certificate[0];
		}
		X509Certificate[] res = new X509Certificate[certs.Length];
		for (int t = 0; t < certs.Length; t++)
		{
			res[t] = new X509Certificate(X509CertificateStructure.GetInstance(certs[t].GetEncoded()));
		}
		return res;
	}

	public bool Verify(IVerifierFactory verifierFactory)
	{
		IStreamCalculator streamCalculator = verifierFactory.CreateCalculator();
		return ((IVerifier)Process(streamCalculator)).IsVerified(pkiMessage.Protection.GetBytes());
	}

	private object Process(IStreamCalculator streamCalculator)
	{
		byte[] enc = new DerSequence(new Asn1EncodableVector { pkiMessage.Header, pkiMessage.Body }).GetDerEncoded();
		streamCalculator.Stream.Write(enc, 0, enc.Length);
		streamCalculator.Stream.Flush();
		Platform.Dispose(streamCalculator.Stream);
		return streamCalculator.GetResult();
	}

	public bool Verify(PKMacBuilder pkMacBuilder, char[] password)
	{
		if (!CmpObjectIdentifiers.passwordBasedMac.Equals(pkiMessage.Header.ProtectionAlg.Algorithm))
		{
			throw new InvalidOperationException("protection algorithm is not mac based");
		}
		PbmParameter parameter = PbmParameter.GetInstance(pkiMessage.Header.ProtectionAlg.Parameters);
		pkMacBuilder.SetParameters(parameter);
		return Arrays.ConstantTimeAreEqual(((IBlockResult)Process(pkMacBuilder.Build(password).CreateCalculator())).Collect(), pkiMessage.Protection.GetBytes());
	}
}
