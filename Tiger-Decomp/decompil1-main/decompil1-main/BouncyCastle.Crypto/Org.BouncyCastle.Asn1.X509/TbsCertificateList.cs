using System;
using System.Collections;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.X509;

public class TbsCertificateList : Asn1Encodable
{
	private class RevokedCertificatesEnumeration : IEnumerable
	{
		private class RevokedCertificatesEnumerator : IEnumerator
		{
			private readonly IEnumerator e;

			public object Current => new CrlEntry(Asn1Sequence.GetInstance(e.Current));

			internal RevokedCertificatesEnumerator(IEnumerator e)
			{
				this.e = e;
			}

			public bool MoveNext()
			{
				return e.MoveNext();
			}

			public void Reset()
			{
				e.Reset();
			}
		}

		private readonly IEnumerable en;

		internal RevokedCertificatesEnumeration(IEnumerable en)
		{
			this.en = en;
		}

		public IEnumerator GetEnumerator()
		{
			return new RevokedCertificatesEnumerator(en.GetEnumerator());
		}
	}

	internal Asn1Sequence seq;

	internal DerInteger version;

	internal AlgorithmIdentifier signature;

	internal X509Name issuer;

	internal Time thisUpdate;

	internal Time nextUpdate;

	internal Asn1Sequence revokedCertificates;

	internal X509Extensions crlExtensions;

	public int Version => version.IntValueExact + 1;

	public DerInteger VersionNumber => version;

	public AlgorithmIdentifier Signature => signature;

	public X509Name Issuer => issuer;

	public Time ThisUpdate => thisUpdate;

	public Time NextUpdate => nextUpdate;

	public X509Extensions Extensions => crlExtensions;

	public static TbsCertificateList GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return GetInstance(Asn1Sequence.GetInstance(obj, explicitly));
	}

	public static TbsCertificateList GetInstance(object obj)
	{
		TbsCertificateList list = obj as TbsCertificateList;
		if (obj == null || list != null)
		{
			return list;
		}
		if (obj is Asn1Sequence)
		{
			return new TbsCertificateList((Asn1Sequence)obj);
		}
		throw new ArgumentException("unknown object in factory: " + Platform.GetTypeName(obj), "obj");
	}

	internal TbsCertificateList(Asn1Sequence seq)
	{
		if (seq.Count < 3 || seq.Count > 7)
		{
			throw new ArgumentException("Bad sequence size: " + seq.Count);
		}
		int seqPos = 0;
		this.seq = seq;
		if (seq[seqPos] is DerInteger)
		{
			version = DerInteger.GetInstance(seq[seqPos++]);
		}
		else
		{
			version = new DerInteger(0);
		}
		signature = AlgorithmIdentifier.GetInstance(seq[seqPos++]);
		issuer = X509Name.GetInstance(seq[seqPos++]);
		thisUpdate = Time.GetInstance(seq[seqPos++]);
		if (seqPos < seq.Count && (seq[seqPos] is DerUtcTime || seq[seqPos] is DerGeneralizedTime || seq[seqPos] is Time))
		{
			nextUpdate = Time.GetInstance(seq[seqPos++]);
		}
		if (seqPos < seq.Count && !(seq[seqPos] is Asn1TaggedObject))
		{
			revokedCertificates = Asn1Sequence.GetInstance(seq[seqPos++]);
		}
		if (seqPos < seq.Count && seq[seqPos] is Asn1TaggedObject)
		{
			crlExtensions = X509Extensions.GetInstance(seq[seqPos]);
		}
	}

	public CrlEntry[] GetRevokedCertificates()
	{
		if (revokedCertificates == null)
		{
			return new CrlEntry[0];
		}
		CrlEntry[] entries = new CrlEntry[revokedCertificates.Count];
		for (int i = 0; i < entries.Length; i++)
		{
			entries[i] = new CrlEntry(Asn1Sequence.GetInstance(revokedCertificates[i]));
		}
		return entries;
	}

	public IEnumerable GetRevokedCertificateEnumeration()
	{
		if (revokedCertificates == null)
		{
			return EmptyEnumerable.Instance;
		}
		return new RevokedCertificatesEnumeration(revokedCertificates);
	}

	public override Asn1Object ToAsn1Object()
	{
		return seq;
	}
}
