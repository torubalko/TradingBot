using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.Icao;

public class LdsSecurityObject : Asn1Encodable
{
	public const int UBDataGroups = 16;

	private DerInteger version = new DerInteger(0);

	private AlgorithmIdentifier digestAlgorithmIdentifier;

	private DataGroupHash[] datagroupHash;

	private LdsVersionInfo versionInfo;

	public BigInteger Version => version.Value;

	public AlgorithmIdentifier DigestAlgorithmIdentifier => digestAlgorithmIdentifier;

	public LdsVersionInfo VersionInfo => versionInfo;

	public static LdsSecurityObject GetInstance(object obj)
	{
		if (obj is LdsSecurityObject)
		{
			return (LdsSecurityObject)obj;
		}
		if (obj != null)
		{
			return new LdsSecurityObject(Asn1Sequence.GetInstance(obj));
		}
		return null;
	}

	private LdsSecurityObject(Asn1Sequence seq)
	{
		if (seq == null || seq.Count == 0)
		{
			throw new ArgumentException("null or empty sequence passed.");
		}
		IEnumerator e = seq.GetEnumerator();
		e.MoveNext();
		version = DerInteger.GetInstance(e.Current);
		e.MoveNext();
		digestAlgorithmIdentifier = AlgorithmIdentifier.GetInstance(e.Current);
		e.MoveNext();
		Asn1Sequence datagroupHashSeq = Asn1Sequence.GetInstance(e.Current);
		if (version.HasValue(1))
		{
			e.MoveNext();
			versionInfo = LdsVersionInfo.GetInstance(e.Current);
		}
		CheckDatagroupHashSeqSize(datagroupHashSeq.Count);
		datagroupHash = new DataGroupHash[datagroupHashSeq.Count];
		for (int i = 0; i < datagroupHashSeq.Count; i++)
		{
			datagroupHash[i] = DataGroupHash.GetInstance(datagroupHashSeq[i]);
		}
	}

	public LdsSecurityObject(AlgorithmIdentifier digestAlgorithmIdentifier, DataGroupHash[] datagroupHash)
	{
		version = new DerInteger(0);
		this.digestAlgorithmIdentifier = digestAlgorithmIdentifier;
		this.datagroupHash = datagroupHash;
		CheckDatagroupHashSeqSize(datagroupHash.Length);
	}

	public LdsSecurityObject(AlgorithmIdentifier digestAlgorithmIdentifier, DataGroupHash[] datagroupHash, LdsVersionInfo versionInfo)
	{
		version = new DerInteger(1);
		this.digestAlgorithmIdentifier = digestAlgorithmIdentifier;
		this.datagroupHash = datagroupHash;
		this.versionInfo = versionInfo;
		CheckDatagroupHashSeqSize(datagroupHash.Length);
	}

	private void CheckDatagroupHashSeqSize(int size)
	{
		if (size < 2 || size > 16)
		{
			throw new ArgumentException("wrong size in DataGroupHashValues : not in (2.." + 16 + ")");
		}
	}

	public DataGroupHash[] GetDatagroupHash()
	{
		return datagroupHash;
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1Encodable[] elements = datagroupHash;
		DerSequence hashSeq = new DerSequence(elements);
		Asn1EncodableVector v = new Asn1EncodableVector(version, digestAlgorithmIdentifier, hashSeq);
		v.AddOptional(versionInfo);
		return new DerSequence(v);
	}
}
