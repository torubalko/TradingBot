using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Tsp;

public class TstInfo : Asn1Encodable
{
	private readonly DerInteger version;

	private readonly DerObjectIdentifier tsaPolicyId;

	private readonly MessageImprint messageImprint;

	private readonly DerInteger serialNumber;

	private readonly DerGeneralizedTime genTime;

	private readonly Accuracy accuracy;

	private readonly DerBoolean ordering;

	private readonly DerInteger nonce;

	private readonly GeneralName tsa;

	private readonly X509Extensions extensions;

	public DerInteger Version => version;

	public MessageImprint MessageImprint => messageImprint;

	public DerObjectIdentifier Policy => tsaPolicyId;

	public DerInteger SerialNumber => serialNumber;

	public Accuracy Accuracy => accuracy;

	public DerGeneralizedTime GenTime => genTime;

	public DerBoolean Ordering => ordering;

	public DerInteger Nonce => nonce;

	public GeneralName Tsa => tsa;

	public X509Extensions Extensions => extensions;

	public static TstInfo GetInstance(object obj)
	{
		if (obj is TstInfo)
		{
			return (TstInfo)obj;
		}
		if (obj == null)
		{
			return null;
		}
		return new TstInfo(Asn1Sequence.GetInstance(obj));
	}

	private TstInfo(Asn1Sequence seq)
	{
		IEnumerator e = seq.GetEnumerator();
		e.MoveNext();
		version = DerInteger.GetInstance(e.Current);
		e.MoveNext();
		tsaPolicyId = DerObjectIdentifier.GetInstance(e.Current);
		e.MoveNext();
		messageImprint = MessageImprint.GetInstance(e.Current);
		e.MoveNext();
		serialNumber = DerInteger.GetInstance(e.Current);
		e.MoveNext();
		genTime = DerGeneralizedTime.GetInstance(e.Current);
		ordering = DerBoolean.False;
		while (e.MoveNext())
		{
			Asn1Object o = (Asn1Object)e.Current;
			if (o is Asn1TaggedObject)
			{
				DerTaggedObject tagged = (DerTaggedObject)o;
				switch (tagged.TagNo)
				{
				case 0:
					tsa = GeneralName.GetInstance(tagged, explicitly: true);
					break;
				case 1:
					extensions = X509Extensions.GetInstance(tagged, explicitly: false);
					break;
				default:
					throw new ArgumentException("Unknown tag value " + tagged.TagNo);
				}
			}
			if (o is DerSequence)
			{
				accuracy = Accuracy.GetInstance(o);
			}
			if (o is DerBoolean)
			{
				ordering = DerBoolean.GetInstance(o);
			}
			if (o is DerInteger)
			{
				nonce = DerInteger.GetInstance(o);
			}
		}
	}

	public TstInfo(DerObjectIdentifier tsaPolicyId, MessageImprint messageImprint, DerInteger serialNumber, DerGeneralizedTime genTime, Accuracy accuracy, DerBoolean ordering, DerInteger nonce, GeneralName tsa, X509Extensions extensions)
	{
		version = new DerInteger(1);
		this.tsaPolicyId = tsaPolicyId;
		this.messageImprint = messageImprint;
		this.serialNumber = serialNumber;
		this.genTime = genTime;
		this.accuracy = accuracy;
		this.ordering = ordering;
		this.nonce = nonce;
		this.tsa = tsa;
		this.extensions = extensions;
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector v = new Asn1EncodableVector(version, tsaPolicyId, messageImprint, serialNumber, genTime);
		v.AddOptional(accuracy);
		if (ordering != null && ordering.IsTrue)
		{
			v.Add(ordering);
		}
		v.AddOptional(nonce);
		v.AddOptionalTagged(isExplicit: true, 0, tsa);
		v.AddOptionalTagged(isExplicit: false, 1, extensions);
		return new DerSequence(v);
	}
}
