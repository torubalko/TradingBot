using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;

namespace Org.BouncyCastle.Crmf;

public class CertificateRequestMessage
{
	public static readonly int popRaVerified = 0;

	public static readonly int popSigningKey = 1;

	public static readonly int popKeyEncipherment = 2;

	public static readonly int popKeyAgreement = 3;

	private readonly CertReqMsg certReqMsg;

	private readonly Controls controls;

	public bool HasControls => controls != null;

	public bool HasProofOfPossession => certReqMsg.Popo != null;

	public int ProofOfPossession => certReqMsg.Popo.Type;

	public bool HasSigningKeyProofOfPossessionWithPkMac
	{
		get
		{
			ProofOfPossession pop = certReqMsg.Popo;
			if (pop.Type == popSigningKey)
			{
				return PopoSigningKey.GetInstance(pop.Object).PoposkInput.PublicKeyMac != null;
			}
			return false;
		}
	}

	private static CertReqMsg ParseBytes(byte[] encoding)
	{
		return CertReqMsg.GetInstance(encoding);
	}

	public CertificateRequestMessage(byte[] encoded)
		: this(CertReqMsg.GetInstance(encoded))
	{
	}

	public CertificateRequestMessage(CertReqMsg certReqMsg)
	{
		this.certReqMsg = certReqMsg;
		controls = certReqMsg.CertReq.Controls;
	}

	public CertReqMsg ToAsn1Structure()
	{
		return certReqMsg;
	}

	public CertTemplate GetCertTemplate()
	{
		return certReqMsg.CertReq.CertTemplate;
	}

	public bool HasControl(DerObjectIdentifier objectIdentifier)
	{
		return FindControl(objectIdentifier) != null;
	}

	public IControl GetControl(DerObjectIdentifier type)
	{
		AttributeTypeAndValue found = FindControl(type);
		if (found != null)
		{
			if (found.Type.Equals(CrmfObjectIdentifiers.id_regCtrl_pkiArchiveOptions))
			{
				return new PkiArchiveControl(PkiArchiveOptions.GetInstance(found.Value));
			}
			if (found.Type.Equals(CrmfObjectIdentifiers.id_regCtrl_regToken))
			{
				return new RegTokenControl(DerUtf8String.GetInstance(found.Value));
			}
			if (found.Type.Equals(CrmfObjectIdentifiers.id_regCtrl_authenticator))
			{
				return new AuthenticatorControl(DerUtf8String.GetInstance(found.Value));
			}
		}
		return null;
	}

	public AttributeTypeAndValue FindControl(DerObjectIdentifier type)
	{
		if (controls == null)
		{
			return null;
		}
		AttributeTypeAndValue[] tAndV = controls.ToAttributeTypeAndValueArray();
		AttributeTypeAndValue found = null;
		for (int i = 0; i < tAndV.Length; i++)
		{
			if (tAndV[i].Type.Equals(type))
			{
				found = tAndV[i];
				break;
			}
		}
		return found;
	}

	public bool IsValidSigningKeyPop(IVerifierFactoryProvider verifierProvider)
	{
		ProofOfPossession pop = certReqMsg.Popo;
		if (pop.Type == popSigningKey)
		{
			PopoSigningKey popoSign = PopoSigningKey.GetInstance(pop.Object);
			if (popoSign.PoposkInput != null && popoSign.PoposkInput.PublicKeyMac != null)
			{
				throw new InvalidOperationException("verification requires password check");
			}
			return verifySignature(verifierProvider, popoSign);
		}
		throw new InvalidOperationException("not Signing Key type of proof of possession");
	}

	private bool verifySignature(IVerifierFactoryProvider verifierFactoryProvider, PopoSigningKey signKey)
	{
		IStreamCalculator calculator;
		try
		{
			calculator = verifierFactoryProvider.CreateVerifierFactory(signKey.AlgorithmIdentifier).CreateCalculator();
		}
		catch (Exception ex)
		{
			throw new CrmfException("unable to create verifier: " + ex.Message, ex);
		}
		if (signKey.PoposkInput != null)
		{
			byte[] b = signKey.GetDerEncoded();
			calculator.Stream.Write(b, 0, b.Length);
		}
		else
		{
			byte[] b2 = certReqMsg.CertReq.GetDerEncoded();
			calculator.Stream.Write(b2, 0, b2.Length);
		}
		return ((DefaultVerifierResult)calculator.GetResult()).IsVerified(signKey.Signature.GetBytes());
	}

	public byte[] GetEncoded()
	{
		return certReqMsg.GetEncoded();
	}
}
