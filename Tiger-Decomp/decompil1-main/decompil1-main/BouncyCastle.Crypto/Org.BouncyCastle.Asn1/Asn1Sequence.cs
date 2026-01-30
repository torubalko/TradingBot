using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1;

public abstract class Asn1Sequence : Asn1Object, IEnumerable
{
	private class Asn1SequenceParserImpl : Asn1SequenceParser, IAsn1Convertible
	{
		private readonly Asn1Sequence outer;

		private readonly int max;

		private int index;

		public Asn1SequenceParserImpl(Asn1Sequence outer)
		{
			this.outer = outer;
			max = outer.Count;
		}

		public IAsn1Convertible ReadObject()
		{
			if (index == max)
			{
				return null;
			}
			Asn1Encodable obj = outer[index++];
			if (obj is Asn1Sequence)
			{
				return ((Asn1Sequence)obj).Parser;
			}
			if (obj is Asn1Set)
			{
				return ((Asn1Set)obj).Parser;
			}
			return obj;
		}

		public Asn1Object ToAsn1Object()
		{
			return outer;
		}
	}

	internal Asn1Encodable[] elements;

	public virtual Asn1SequenceParser Parser => new Asn1SequenceParserImpl(this);

	public virtual Asn1Encodable this[int index] => elements[index];

	public virtual int Count => elements.Length;

	public static Asn1Sequence GetInstance(object obj)
	{
		if (obj == null || obj is Asn1Sequence)
		{
			return (Asn1Sequence)obj;
		}
		if (obj is Asn1SequenceParser)
		{
			return GetInstance(((Asn1SequenceParser)obj).ToAsn1Object());
		}
		if (obj is byte[])
		{
			try
			{
				return GetInstance(Asn1Object.FromByteArray((byte[])obj));
			}
			catch (IOException ex)
			{
				throw new ArgumentException("failed to construct sequence from byte[]: " + ex.Message);
			}
		}
		if (obj is Asn1Encodable)
		{
			Asn1Object primitive = ((Asn1Encodable)obj).ToAsn1Object();
			if (primitive is Asn1Sequence)
			{
				return (Asn1Sequence)primitive;
			}
		}
		throw new ArgumentException("Unknown object in GetInstance: " + Platform.GetTypeName(obj), "obj");
	}

	public static Asn1Sequence GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		Asn1Object inner = obj.GetObject();
		if (explicitly)
		{
			if (!obj.IsExplicit())
			{
				throw new ArgumentException("object implicit - explicit expected.");
			}
			return (Asn1Sequence)inner;
		}
		if (obj.IsExplicit())
		{
			if (obj is BerTaggedObject)
			{
				return new BerSequence(inner);
			}
			return new DerSequence(inner);
		}
		if (inner is Asn1Sequence)
		{
			return (Asn1Sequence)inner;
		}
		throw new ArgumentException("Unknown object in GetInstance: " + Platform.GetTypeName(obj), "obj");
	}

	protected internal Asn1Sequence()
	{
		elements = Asn1EncodableVector.EmptyElements;
	}

	protected internal Asn1Sequence(Asn1Encodable element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		elements = new Asn1Encodable[1] { element };
	}

	protected internal Asn1Sequence(params Asn1Encodable[] elements)
	{
		if (Arrays.IsNullOrContainsNull(elements))
		{
			throw new NullReferenceException("'elements' cannot be null, or contain null");
		}
		this.elements = Asn1EncodableVector.CloneElements(elements);
	}

	protected internal Asn1Sequence(Asn1EncodableVector elementVector)
	{
		if (elementVector == null)
		{
			throw new ArgumentNullException("elementVector");
		}
		elements = elementVector.TakeElements();
	}

	public virtual IEnumerator GetEnumerator()
	{
		return elements.GetEnumerator();
	}

	public virtual Asn1Encodable[] ToArray()
	{
		return Asn1EncodableVector.CloneElements(elements);
	}

	protected override int Asn1GetHashCode()
	{
		int i = elements.Length;
		int hc = i + 1;
		while (--i >= 0)
		{
			hc *= 257;
			hc ^= elements[i].ToAsn1Object().CallAsn1GetHashCode();
		}
		return hc;
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is Asn1Sequence that))
		{
			return false;
		}
		int count = Count;
		if (that.Count != count)
		{
			return false;
		}
		for (int i = 0; i < count; i++)
		{
			Asn1Object o1 = elements[i].ToAsn1Object();
			Asn1Object o2 = that.elements[i].ToAsn1Object();
			if (o1 != o2 && !o1.CallAsn1Equals(o2))
			{
				return false;
			}
		}
		return true;
	}

	public override string ToString()
	{
		return CollectionUtilities.ToString(elements);
	}
}
