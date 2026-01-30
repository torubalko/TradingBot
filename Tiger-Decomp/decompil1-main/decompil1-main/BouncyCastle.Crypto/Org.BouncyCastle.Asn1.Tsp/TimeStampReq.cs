using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Tsp;

public class TimeStampReq : Asn1Encodable
{
	private readonly DerInteger version;

	private readonly MessageImprint messageImprint;

	private readonly DerObjectIdentifier tsaPolicy;

	private readonly DerInteger nonce;

	private readonly DerBoolean certReq;

	private readonly X509Extensions extensions;

	public DerInteger Version => version;

	public MessageImprint MessageImprint => messageImprint;

	public DerObjectIdentifier ReqPolicy => tsaPolicy;

	public DerInteger Nonce => nonce;

	public DerBoolean CertReq => certReq;

	public X509Extensions Extensions => extensions;

	public static TimeStampReq GetInstance(object obj)
	{
		if (obj is TimeStampReq)
		{
			return (TimeStampReq)obj;
		}
		if (obj == null)
		{
			return null;
		}
		return new TimeStampReq(Asn1Sequence.GetInstance(obj));
	}

	private TimeStampReq(Asn1Sequence seq)
	{
		int nbObjects = seq.Count;
		int seqStart = 0;
		version = DerInteger.GetInstance(seq[seqStart++]);
		messageImprint = MessageImprint.GetInstance(seq[seqStart++]);
		for (int opt = seqStart; opt < nbObjects; opt++)
		{
			if (seq[opt] is DerObjectIdentifier)
			{
				tsaPolicy = DerObjectIdentifier.GetInstance(seq[opt]);
			}
			else if (seq[opt] is DerInteger)
			{
				nonce = DerInteger.GetInstance(seq[opt]);
			}
			else if (seq[opt] is DerBoolean)
			{
				certReq = DerBoolean.GetInstance(seq[opt]);
			}
			else if (seq[opt] is Asn1TaggedObject)
			{
				Asn1TaggedObject tagged = (Asn1TaggedObject)seq[opt];
				if (tagged.TagNo == 0)
				{
					extensions = X509Extensions.GetInstance(tagged, explicitly: false);
				}
			}
		}
	}

	public TimeStampReq(MessageImprint messageImprint, DerObjectIdentifier tsaPolicy, DerInteger nonce, DerBoolean certReq, X509Extensions extensions)
	{
		version = new DerInteger(1);
		this.messageImprint = messageImprint;
		this.tsaPolicy = tsaPolicy;
		this.nonce = nonce;
		this.certReq = certReq;
		this.extensions = extensions;
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector v = new Asn1EncodableVector(version, messageImprint);
		v.AddOptional(tsaPolicy, nonce);
		if (certReq != null && certReq.IsTrue)
		{
			v.Add(certReq);
		}
		v.AddOptionalTagged(isExplicit: false, 0, extensions);
		return new DerSequence(v);
	}
}
