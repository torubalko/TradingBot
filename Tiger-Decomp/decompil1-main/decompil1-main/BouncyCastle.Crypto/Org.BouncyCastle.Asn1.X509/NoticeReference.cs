using System;
using System.Collections;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.X509;

public class NoticeReference : Asn1Encodable
{
	private readonly DisplayText organization;

	private readonly Asn1Sequence noticeNumbers;

	public virtual DisplayText Organization => organization;

	private static Asn1EncodableVector ConvertVector(IList numbers)
	{
		Asn1EncodableVector av = new Asn1EncodableVector();
		foreach (object o in numbers)
		{
			DerInteger di;
			if (o is BigInteger)
			{
				di = new DerInteger((BigInteger)o);
			}
			else
			{
				if (!(o is int))
				{
					throw new ArgumentException();
				}
				di = new DerInteger((int)o);
			}
			av.Add(di);
		}
		return av;
	}

	public NoticeReference(string organization, IList numbers)
		: this(organization, ConvertVector(numbers))
	{
	}

	public NoticeReference(string organization, Asn1EncodableVector noticeNumbers)
		: this(new DisplayText(organization), noticeNumbers)
	{
	}

	public NoticeReference(DisplayText organization, Asn1EncodableVector noticeNumbers)
	{
		this.organization = organization;
		this.noticeNumbers = new DerSequence(noticeNumbers);
	}

	private NoticeReference(Asn1Sequence seq)
	{
		if (seq.Count != 2)
		{
			throw new ArgumentException("Bad sequence size: " + seq.Count, "seq");
		}
		organization = DisplayText.GetInstance(seq[0]);
		noticeNumbers = Asn1Sequence.GetInstance(seq[1]);
	}

	public static NoticeReference GetInstance(object obj)
	{
		if (obj is NoticeReference)
		{
			return (NoticeReference)obj;
		}
		if (obj == null)
		{
			return null;
		}
		return new NoticeReference(Asn1Sequence.GetInstance(obj));
	}

	public virtual DerInteger[] GetNoticeNumbers()
	{
		DerInteger[] tmp = new DerInteger[noticeNumbers.Count];
		for (int i = 0; i != noticeNumbers.Count; i++)
		{
			tmp[i] = DerInteger.GetInstance(noticeNumbers[i]);
		}
		return tmp;
	}

	public override Asn1Object ToAsn1Object()
	{
		return new DerSequence(organization, noticeNumbers);
	}
}
