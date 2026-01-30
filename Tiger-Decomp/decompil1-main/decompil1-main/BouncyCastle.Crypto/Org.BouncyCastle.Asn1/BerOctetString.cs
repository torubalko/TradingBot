using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class BerOctetString : DerOctetString, IEnumerable
{
	private class ChunkEnumerator : IEnumerator
	{
		private readonly byte[] octets;

		private readonly int segmentLimit;

		private DerOctetString currentSegment;

		private int nextSegmentPos;

		public object Current
		{
			get
			{
				if (currentSegment == null)
				{
					throw new InvalidOperationException();
				}
				return currentSegment;
			}
		}

		internal ChunkEnumerator(byte[] octets, int segmentLimit)
		{
			this.octets = octets;
			this.segmentLimit = segmentLimit;
		}

		public bool MoveNext()
		{
			if (nextSegmentPos >= octets.Length)
			{
				currentSegment = null;
				return false;
			}
			int length = System.Math.Min(octets.Length - nextSegmentPos, segmentLimit);
			byte[] segment = new byte[length];
			Array.Copy(octets, nextSegmentPos, segment, 0, length);
			currentSegment = new DerOctetString(segment);
			nextSegmentPos += length;
			return true;
		}

		public void Reset()
		{
			currentSegment = null;
			nextSegmentPos = 0;
		}
	}

	private const int DefaultSegmentLimit = 1000;

	private readonly int segmentLimit;

	private readonly Asn1OctetString[] elements;

	private bool IsConstructed
	{
		get
		{
			if (elements == null)
			{
				return str.Length > segmentLimit;
			}
			return true;
		}
	}

	public static BerOctetString FromSequence(Asn1Sequence seq)
	{
		int count = seq.Count;
		Asn1OctetString[] v = new Asn1OctetString[count];
		for (int i = 0; i < count; i++)
		{
			v[i] = Asn1OctetString.GetInstance(seq[i]);
		}
		return new BerOctetString(v);
	}

	internal static byte[] FlattenOctetStrings(Asn1OctetString[] octetStrings)
	{
		int count = octetStrings.Length;
		switch (count)
		{
		case 0:
			return Asn1OctetString.EmptyOctets;
		case 1:
			return octetStrings[0].str;
		default:
		{
			int totalOctets = 0;
			for (int i = 0; i < count; i++)
			{
				totalOctets += octetStrings[i].str.Length;
			}
			byte[] str = new byte[totalOctets];
			int pos = 0;
			for (int j = 0; j < count; j++)
			{
				byte[] octets = octetStrings[j].str;
				Array.Copy(octets, 0, str, pos, octets.Length);
				pos += octets.Length;
			}
			return str;
		}
		}
	}

	private static Asn1OctetString[] ToOctetStringArray(IEnumerable e)
	{
		IList list = Platform.CreateArrayList(e);
		int count = list.Count;
		Asn1OctetString[] v = new Asn1OctetString[count];
		for (int i = 0; i < count; i++)
		{
			v[i] = Asn1OctetString.GetInstance(list[i]);
		}
		return v;
	}

	[Obsolete("Will be removed")]
	public BerOctetString(IEnumerable e)
		: this(ToOctetStringArray(e))
	{
	}

	public BerOctetString(byte[] str)
		: this(str, 1000)
	{
	}

	public BerOctetString(Asn1OctetString[] elements)
		: this(elements, 1000)
	{
	}

	public BerOctetString(byte[] str, int segmentLimit)
		: this(str, null, segmentLimit)
	{
	}

	public BerOctetString(Asn1OctetString[] elements, int segmentLimit)
		: this(FlattenOctetStrings(elements), elements, segmentLimit)
	{
	}

	private BerOctetString(byte[] octets, Asn1OctetString[] elements, int segmentLimit)
		: base(octets)
	{
		this.elements = elements;
		this.segmentLimit = segmentLimit;
	}

	public IEnumerator GetEnumerator()
	{
		if (elements == null)
		{
			return new ChunkEnumerator(str, segmentLimit);
		}
		return elements.GetEnumerator();
	}

	[Obsolete("Use GetEnumerator() instead")]
	public IEnumerator GetObjects()
	{
		return GetEnumerator();
	}

	internal override int EncodedLength(bool withID)
	{
		throw Platform.CreateNotImplementedException("BerOctetString.EncodedLength");
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		if (!asn1Out.IsBer || !IsConstructed)
		{
			base.Encode(asn1Out, withID);
			return;
		}
		asn1Out.WriteIdentifier(withID, 36);
		asn1Out.WriteByte(128);
		if (elements != null)
		{
			Asn1Object[] primitives = elements;
			asn1Out.WritePrimitives(primitives);
		}
		else
		{
			int segmentLength;
			for (int pos = 0; pos < str.Length; pos += segmentLength)
			{
				segmentLength = System.Math.Min(str.Length - pos, segmentLimit);
				DerOctetString.Encode(asn1Out, withID: true, str, pos, segmentLength);
			}
		}
		asn1Out.WriteByte(0);
		asn1Out.WriteByte(0);
	}
}
