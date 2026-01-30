using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp;

public class ErrorMsgContent : Asn1Encodable
{
	private readonly PkiStatusInfo pkiStatusInfo;

	private readonly DerInteger errorCode;

	private readonly PkiFreeText errorDetails;

	public virtual PkiStatusInfo PkiStatusInfo => pkiStatusInfo;

	public virtual DerInteger ErrorCode => errorCode;

	public virtual PkiFreeText ErrorDetails => errorDetails;

	private ErrorMsgContent(Asn1Sequence seq)
	{
		pkiStatusInfo = PkiStatusInfo.GetInstance(seq[0]);
		for (int pos = 1; pos < seq.Count; pos++)
		{
			Asn1Encodable ae = seq[pos];
			if (ae is DerInteger)
			{
				errorCode = DerInteger.GetInstance(ae);
			}
			else
			{
				errorDetails = PkiFreeText.GetInstance(ae);
			}
		}
	}

	public static ErrorMsgContent GetInstance(object obj)
	{
		if (obj is ErrorMsgContent)
		{
			return (ErrorMsgContent)obj;
		}
		if (obj is Asn1Sequence)
		{
			return new ErrorMsgContent((Asn1Sequence)obj);
		}
		throw new ArgumentException("Invalid object: " + Platform.GetTypeName(obj), "obj");
	}

	public ErrorMsgContent(PkiStatusInfo pkiStatusInfo)
		: this(pkiStatusInfo, null, null)
	{
	}

	public ErrorMsgContent(PkiStatusInfo pkiStatusInfo, DerInteger errorCode, PkiFreeText errorDetails)
	{
		if (pkiStatusInfo == null)
		{
			throw new ArgumentNullException("pkiStatusInfo");
		}
		this.pkiStatusInfo = pkiStatusInfo;
		this.errorCode = errorCode;
		this.errorDetails = errorDetails;
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector v = new Asn1EncodableVector(pkiStatusInfo);
		v.AddOptional(errorCode, errorDetails);
		return new DerSequence(v);
	}
}
