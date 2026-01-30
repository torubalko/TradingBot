using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1;

public abstract class Asn1Set : Asn1Object, IEnumerable
{
	private class Asn1SetParserImpl : Asn1SetParser, IAsn1Convertible
	{
		private readonly Asn1Set outer;

		private readonly int max;

		private int index;

		public Asn1SetParserImpl(Asn1Set outer)
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

		public virtual Asn1Object ToAsn1Object()
		{
			return outer;
		}
	}

	private class DerComparer : IComparer
	{
		public int Compare(object x, object y)
		{
			byte[] a = (byte[])x;
			byte[] b = (byte[])y;
			int a2 = a[0] & -33;
			int b2 = b[0] & -33;
			if (a2 != b2)
			{
				if (a2 >= b2)
				{
					return 1;
				}
				return -1;
			}
			int len = System.Math.Min(a.Length, b.Length);
			for (int i = 1; i < len; i++)
			{
				byte ai = a[i];
				byte bi = b[i];
				if (ai != bi)
				{
					if (ai >= bi)
					{
						return 1;
					}
					return -1;
				}
			}
			return 0;
		}
	}

	internal Asn1Encodable[] elements;

	public virtual Asn1Encodable this[int index] => elements[index];

	public virtual int Count => elements.Length;

	public Asn1SetParser Parser => new Asn1SetParserImpl(this);

	public static Asn1Set GetInstance(object obj)
	{
		if (obj == null || obj is Asn1Set)
		{
			return (Asn1Set)obj;
		}
		if (obj is Asn1SetParser)
		{
			return GetInstance(((Asn1SetParser)obj).ToAsn1Object());
		}
		if (obj is byte[])
		{
			try
			{
				return GetInstance(Asn1Object.FromByteArray((byte[])obj));
			}
			catch (IOException ex)
			{
				throw new ArgumentException("failed to construct set from byte[]: " + ex.Message);
			}
		}
		if (obj is Asn1Encodable)
		{
			Asn1Object primitive = ((Asn1Encodable)obj).ToAsn1Object();
			if (primitive is Asn1Set)
			{
				return (Asn1Set)primitive;
			}
		}
		throw new ArgumentException("Unknown object in GetInstance: " + Platform.GetTypeName(obj), "obj");
	}

	public static Asn1Set GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		Asn1Object inner = obj.GetObject();
		if (explicitly)
		{
			if (!obj.IsExplicit())
			{
				throw new ArgumentException("object implicit - explicit expected.");
			}
			return (Asn1Set)inner;
		}
		if (obj.IsExplicit())
		{
			return new DerSet(inner);
		}
		if (inner is Asn1Set)
		{
			return (Asn1Set)inner;
		}
		if (inner is Asn1Sequence)
		{
			Asn1EncodableVector v = new Asn1EncodableVector();
			foreach (Asn1Encodable ae in (Asn1Sequence)inner)
			{
				v.Add(ae);
			}
			return new DerSet(v, needsSorting: false);
		}
		throw new ArgumentException("Unknown object in GetInstance: " + Platform.GetTypeName(obj), "obj");
	}

	protected internal Asn1Set()
	{
		elements = Asn1EncodableVector.EmptyElements;
	}

	protected internal Asn1Set(Asn1Encodable element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		elements = new Asn1Encodable[1] { element };
	}

	protected internal Asn1Set(params Asn1Encodable[] elements)
	{
		if (Arrays.IsNullOrContainsNull(elements))
		{
			throw new NullReferenceException("'elements' cannot be null, or contain null");
		}
		this.elements = Asn1EncodableVector.CloneElements(elements);
	}

	protected internal Asn1Set(Asn1EncodableVector elementVector)
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
		if (!(asn1Object is Asn1Set that))
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

	protected internal void Sort()
	{
		if (elements.Length >= 2)
		{
			int count = elements.Length;
			byte[][] keys = new byte[count][];
			for (int i = 0; i < count; i++)
			{
				keys[i] = elements[i].GetEncoded("DER");
			}
			Array.Sort(keys, elements, new DerComparer());
		}
	}

	public override string ToString()
	{
		return CollectionUtilities.ToString(elements);
	}
}
