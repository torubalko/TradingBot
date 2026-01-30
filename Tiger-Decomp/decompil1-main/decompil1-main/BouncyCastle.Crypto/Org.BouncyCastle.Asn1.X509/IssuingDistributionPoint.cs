using System;
using System.Text;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509;

public class IssuingDistributionPoint : Asn1Encodable
{
	private readonly DistributionPointName _distributionPoint;

	private readonly bool _onlyContainsUserCerts;

	private readonly bool _onlyContainsCACerts;

	private readonly ReasonFlags _onlySomeReasons;

	private readonly bool _indirectCRL;

	private readonly bool _onlyContainsAttributeCerts;

	private readonly Asn1Sequence seq;

	public bool OnlyContainsUserCerts => _onlyContainsUserCerts;

	public bool OnlyContainsCACerts => _onlyContainsCACerts;

	public bool IsIndirectCrl => _indirectCRL;

	public bool OnlyContainsAttributeCerts => _onlyContainsAttributeCerts;

	public DistributionPointName DistributionPoint => _distributionPoint;

	public ReasonFlags OnlySomeReasons => _onlySomeReasons;

	public static IssuingDistributionPoint GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return GetInstance(Asn1Sequence.GetInstance(obj, explicitly));
	}

	public static IssuingDistributionPoint GetInstance(object obj)
	{
		if (obj == null || obj is IssuingDistributionPoint)
		{
			return (IssuingDistributionPoint)obj;
		}
		if (obj is Asn1Sequence)
		{
			return new IssuingDistributionPoint((Asn1Sequence)obj);
		}
		throw new ArgumentException("unknown object in factory: " + Platform.GetTypeName(obj), "obj");
	}

	public IssuingDistributionPoint(DistributionPointName distributionPoint, bool onlyContainsUserCerts, bool onlyContainsCACerts, ReasonFlags onlySomeReasons, bool indirectCRL, bool onlyContainsAttributeCerts)
	{
		_distributionPoint = distributionPoint;
		_indirectCRL = indirectCRL;
		_onlyContainsAttributeCerts = onlyContainsAttributeCerts;
		_onlyContainsCACerts = onlyContainsCACerts;
		_onlyContainsUserCerts = onlyContainsUserCerts;
		_onlySomeReasons = onlySomeReasons;
		Asn1EncodableVector vec = new Asn1EncodableVector();
		if (distributionPoint != null)
		{
			vec.Add(new DerTaggedObject(explicitly: true, 0, distributionPoint));
		}
		if (onlyContainsUserCerts)
		{
			vec.Add(new DerTaggedObject(explicitly: false, 1, DerBoolean.True));
		}
		if (onlyContainsCACerts)
		{
			vec.Add(new DerTaggedObject(explicitly: false, 2, DerBoolean.True));
		}
		if (onlySomeReasons != null)
		{
			vec.Add(new DerTaggedObject(explicitly: false, 3, onlySomeReasons));
		}
		if (indirectCRL)
		{
			vec.Add(new DerTaggedObject(explicitly: false, 4, DerBoolean.True));
		}
		if (onlyContainsAttributeCerts)
		{
			vec.Add(new DerTaggedObject(explicitly: false, 5, DerBoolean.True));
		}
		seq = new DerSequence(vec);
	}

	private IssuingDistributionPoint(Asn1Sequence seq)
	{
		this.seq = seq;
		for (int i = 0; i != seq.Count; i++)
		{
			Asn1TaggedObject o = Asn1TaggedObject.GetInstance(seq[i]);
			switch (o.TagNo)
			{
			case 0:
				_distributionPoint = DistributionPointName.GetInstance(o, explicitly: true);
				break;
			case 1:
				_onlyContainsUserCerts = DerBoolean.GetInstance(o, isExplicit: false).IsTrue;
				break;
			case 2:
				_onlyContainsCACerts = DerBoolean.GetInstance(o, isExplicit: false).IsTrue;
				break;
			case 3:
				_onlySomeReasons = new ReasonFlags(DerBitString.GetInstance(o, isExplicit: false));
				break;
			case 4:
				_indirectCRL = DerBoolean.GetInstance(o, isExplicit: false).IsTrue;
				break;
			case 5:
				_onlyContainsAttributeCerts = DerBoolean.GetInstance(o, isExplicit: false).IsTrue;
				break;
			default:
				throw new ArgumentException("unknown tag in IssuingDistributionPoint");
			}
		}
	}

	public override Asn1Object ToAsn1Object()
	{
		return seq;
	}

	public override string ToString()
	{
		string sep = Platform.NewLine;
		StringBuilder buf = new StringBuilder();
		buf.Append("IssuingDistributionPoint: [");
		buf.Append(sep);
		if (_distributionPoint != null)
		{
			appendObject(buf, sep, "distributionPoint", _distributionPoint.ToString());
		}
		if (_onlyContainsUserCerts)
		{
			appendObject(buf, sep, "onlyContainsUserCerts", _onlyContainsUserCerts.ToString());
		}
		if (_onlyContainsCACerts)
		{
			appendObject(buf, sep, "onlyContainsCACerts", _onlyContainsCACerts.ToString());
		}
		if (_onlySomeReasons != null)
		{
			appendObject(buf, sep, "onlySomeReasons", _onlySomeReasons.ToString());
		}
		if (_onlyContainsAttributeCerts)
		{
			appendObject(buf, sep, "onlyContainsAttributeCerts", _onlyContainsAttributeCerts.ToString());
		}
		if (_indirectCRL)
		{
			appendObject(buf, sep, "indirectCRL", _indirectCRL.ToString());
		}
		buf.Append("]");
		buf.Append(sep);
		return buf.ToString();
	}

	private void appendObject(StringBuilder buf, string sep, string name, string val)
	{
		string indent = "    ";
		buf.Append(indent);
		buf.Append(name);
		buf.Append(":");
		buf.Append(sep);
		buf.Append(indent);
		buf.Append(indent);
		buf.Append(val);
		buf.Append(sep);
	}
}
