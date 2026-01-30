using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crmf;

public class CertificateRequestMessageBuilder
{
	private readonly BigInteger _certReqId;

	private X509ExtensionsGenerator _extGenerator;

	private CertTemplateBuilder _templateBuilder;

	private IList _controls = Platform.CreateArrayList();

	private ISignatureFactory _popSigner;

	private PKMacBuilder _pkMacBuilder;

	private char[] _password;

	private GeneralName _sender;

	private int _popoType = 2;

	private PopoPrivKey _popoPrivKey;

	private Asn1Null _popRaVerified;

	private PKMacValue _agreeMac;

	public CertificateRequestMessageBuilder(BigInteger certReqId)
	{
		_certReqId = certReqId;
		_extGenerator = new X509ExtensionsGenerator();
		_templateBuilder = new CertTemplateBuilder();
	}

	public CertificateRequestMessageBuilder SetPublicKey(SubjectPublicKeyInfo publicKeyInfo)
	{
		if (publicKeyInfo != null)
		{
			_templateBuilder.SetPublicKey(publicKeyInfo);
		}
		return this;
	}

	public CertificateRequestMessageBuilder SetIssuer(X509Name issuer)
	{
		if (issuer != null)
		{
			_templateBuilder.SetIssuer(issuer);
		}
		return this;
	}

	public CertificateRequestMessageBuilder SetSubject(X509Name subject)
	{
		if (subject != null)
		{
			_templateBuilder.SetSubject(subject);
		}
		return this;
	}

	public CertificateRequestMessageBuilder SetSerialNumber(BigInteger serialNumber)
	{
		if (serialNumber != null)
		{
			_templateBuilder.SetSerialNumber(new DerInteger(serialNumber));
		}
		return this;
	}

	public CertificateRequestMessageBuilder SetValidity(Time notBefore, Time notAfter)
	{
		_templateBuilder.SetValidity(new OptionalValidity(notBefore, notAfter));
		return this;
	}

	public CertificateRequestMessageBuilder AddExtension(DerObjectIdentifier oid, bool critical, Asn1Encodable value)
	{
		_extGenerator.AddExtension(oid, critical, value);
		return this;
	}

	public CertificateRequestMessageBuilder AddExtension(DerObjectIdentifier oid, bool critical, byte[] value)
	{
		_extGenerator.AddExtension(oid, critical, value);
		return this;
	}

	public CertificateRequestMessageBuilder AddControl(IControl control)
	{
		_controls.Add(control);
		return this;
	}

	public CertificateRequestMessageBuilder SetProofOfPossessionSignKeySigner(ISignatureFactory popoSignatureFactory)
	{
		if (_popoPrivKey != null || _popRaVerified != null || _agreeMac != null)
		{
			throw new InvalidOperationException("only one proof of possession is allowed.");
		}
		_popSigner = popoSignatureFactory;
		return this;
	}

	public CertificateRequestMessageBuilder SetProofOfPossessionSubsequentMessage(SubsequentMessage msg)
	{
		if (_popoPrivKey != null || _popRaVerified != null || _agreeMac != null)
		{
			throw new InvalidOperationException("only one proof of possession is allowed.");
		}
		_popoType = 2;
		_popoPrivKey = new PopoPrivKey(msg);
		return this;
	}

	public CertificateRequestMessageBuilder SetProofOfPossessionSubsequentMessage(int type, SubsequentMessage msg)
	{
		if (_popoPrivKey != null || _popRaVerified != null || _agreeMac != null)
		{
			throw new InvalidOperationException("only one proof of possession is allowed.");
		}
		if (type != 2 && type != 3)
		{
			throw new ArgumentException("type must be ProofOfPossession.TYPE_KEY_ENCIPHERMENT || ProofOfPossession.TYPE_KEY_AGREEMENT");
		}
		_popoType = type;
		_popoPrivKey = new PopoPrivKey(msg);
		return this;
	}

	public CertificateRequestMessageBuilder SetProofOfPossessionAgreeMac(PKMacValue macValue)
	{
		if (_popSigner != null || _popRaVerified != null || _popoPrivKey != null)
		{
			throw new InvalidOperationException("only one proof of possession allowed");
		}
		_agreeMac = macValue;
		return this;
	}

	public CertificateRequestMessageBuilder SetProofOfPossessionRaVerified()
	{
		if (_popSigner != null || _popoPrivKey != null)
		{
			throw new InvalidOperationException("only one proof of possession allowed");
		}
		_popRaVerified = DerNull.Instance;
		return this;
	}

	public CertificateRequestMessageBuilder SetAuthInfoPKMAC(PKMacBuilder pkmacFactory, char[] password)
	{
		_pkMacBuilder = pkmacFactory;
		_password = password;
		return this;
	}

	public CertificateRequestMessageBuilder SetAuthInfoSender(X509Name sender)
	{
		return SetAuthInfoSender(new GeneralName(sender));
	}

	public CertificateRequestMessageBuilder SetAuthInfoSender(GeneralName sender)
	{
		_sender = sender;
		return this;
	}

	public CertificateRequestMessage Build()
	{
		Asn1EncodableVector v = new Asn1EncodableVector(new DerInteger(_certReqId));
		if (!_extGenerator.IsEmpty)
		{
			_templateBuilder.SetExtensions(_extGenerator.Generate());
		}
		v.Add(_templateBuilder.Build());
		if (_controls.Count > 0)
		{
			Asn1EncodableVector controlV = new Asn1EncodableVector();
			foreach (IControl control in _controls)
			{
				controlV.Add(new AttributeTypeAndValue(control.Type, control.Value));
			}
			v.Add(new DerSequence(controlV));
		}
		CertRequest request = CertRequest.GetInstance(new DerSequence(v));
		v = new Asn1EncodableVector(request);
		if (_popSigner != null)
		{
			CertTemplate template = request.CertTemplate;
			if (template.Subject == null || template.PublicKey == null)
			{
				ProofOfPossessionSigningKeyBuilder builder = new ProofOfPossessionSigningKeyBuilder(request.CertTemplate.PublicKey);
				if (_sender != null)
				{
					builder.SetSender(_sender);
				}
				else
				{
					builder.SetPublicKeyMac(_pkMacBuilder, _password);
				}
				v.Add(new ProofOfPossession(builder.Build(_popSigner)));
			}
			else
			{
				ProofOfPossessionSigningKeyBuilder builder2 = new ProofOfPossessionSigningKeyBuilder(request);
				v.Add(new ProofOfPossession(builder2.Build(_popSigner)));
			}
		}
		else if (_popoPrivKey != null)
		{
			v.Add(new ProofOfPossession(_popoType, _popoPrivKey));
		}
		else if (_agreeMac != null)
		{
			v.Add(new ProofOfPossession(3, PopoPrivKey.GetInstance(new DerTaggedObject(explicitly: false, 3, _agreeMac), isExplicit: true)));
		}
		else if (_popRaVerified != null)
		{
			v.Add(new ProofOfPossession());
		}
		return new CertificateRequestMessage(CertReqMsg.GetInstance(new DerSequence(v)));
	}
}
