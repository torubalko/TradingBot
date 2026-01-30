using System;

namespace Org.BouncyCastle.Asn1.Tsp;

public class Accuracy : Asn1Encodable
{
	private readonly DerInteger seconds;

	private readonly DerInteger millis;

	private readonly DerInteger micros;

	protected const int MinMillis = 1;

	protected const int MaxMillis = 999;

	protected const int MinMicros = 1;

	protected const int MaxMicros = 999;

	public DerInteger Seconds => seconds;

	public DerInteger Millis => millis;

	public DerInteger Micros => micros;

	public Accuracy(DerInteger seconds, DerInteger millis, DerInteger micros)
	{
		if (millis != null)
		{
			int millisValue = millis.IntValueExact;
			if (millisValue < 1 || millisValue > 999)
			{
				throw new ArgumentException("Invalid millis field : not in (1..999)");
			}
		}
		if (micros != null)
		{
			int microsValue = micros.IntValueExact;
			if (microsValue < 1 || microsValue > 999)
			{
				throw new ArgumentException("Invalid micros field : not in (1..999)");
			}
		}
		this.seconds = seconds;
		this.millis = millis;
		this.micros = micros;
	}

	private Accuracy(Asn1Sequence seq)
	{
		for (int i = 0; i < seq.Count; i++)
		{
			if (seq[i] is DerInteger)
			{
				seconds = (DerInteger)seq[i];
			}
			else
			{
				if (!(seq[i] is Asn1TaggedObject))
				{
					continue;
				}
				Asn1TaggedObject extra = (Asn1TaggedObject)seq[i];
				switch (extra.TagNo)
				{
				case 0:
				{
					millis = DerInteger.GetInstance(extra, isExplicit: false);
					int millisValue = millis.IntValueExact;
					if (millisValue < 1 || millisValue > 999)
					{
						throw new ArgumentException("Invalid millis field : not in (1..999)");
					}
					break;
				}
				case 1:
				{
					micros = DerInteger.GetInstance(extra, isExplicit: false);
					int microsValue = micros.IntValueExact;
					if (microsValue < 1 || microsValue > 999)
					{
						throw new ArgumentException("Invalid micros field : not in (1..999)");
					}
					break;
				}
				default:
					throw new ArgumentException("Invalid tag number");
				}
			}
		}
	}

	public static Accuracy GetInstance(object obj)
	{
		if (obj is Accuracy)
		{
			return (Accuracy)obj;
		}
		if (obj == null)
		{
			return null;
		}
		return new Accuracy(Asn1Sequence.GetInstance(obj));
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector v = new Asn1EncodableVector();
		v.AddOptional(seconds);
		v.AddOptionalTagged(isExplicit: false, 0, millis);
		v.AddOptionalTagged(isExplicit: false, 1, micros);
		return new DerSequence(v);
	}
}
