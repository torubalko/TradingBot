using System;
using System.Collections;

namespace Org.BouncyCastle.Asn1;

public class Asn1EncodableVector : IEnumerable
{
	internal static readonly Asn1Encodable[] EmptyElements = new Asn1Encodable[0];

	private const int DefaultCapacity = 10;

	private Asn1Encodable[] elements;

	private int elementCount;

	private bool copyOnWrite;

	public Asn1Encodable this[int index]
	{
		get
		{
			if (index >= elementCount)
			{
				throw new IndexOutOfRangeException(index + " >= " + elementCount);
			}
			return elements[index];
		}
	}

	public int Count => elementCount;

	public static Asn1EncodableVector FromEnumerable(IEnumerable e)
	{
		Asn1EncodableVector v = new Asn1EncodableVector();
		foreach (Asn1Encodable obj in e)
		{
			v.Add(obj);
		}
		return v;
	}

	public Asn1EncodableVector()
		: this(10)
	{
	}

	public Asn1EncodableVector(int initialCapacity)
	{
		if (initialCapacity < 0)
		{
			throw new ArgumentException("must not be negative", "initialCapacity");
		}
		elements = ((initialCapacity == 0) ? EmptyElements : new Asn1Encodable[initialCapacity]);
		elementCount = 0;
		copyOnWrite = false;
	}

	public Asn1EncodableVector(params Asn1Encodable[] v)
		: this()
	{
		Add(v);
	}

	public void Add(Asn1Encodable element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		int capacity = elements.Length;
		int minCapacity = elementCount + 1;
		if ((minCapacity > capacity) | copyOnWrite)
		{
			Reallocate(minCapacity);
		}
		elements[elementCount] = element;
		elementCount = minCapacity;
	}

	public void Add(params Asn1Encodable[] objs)
	{
		foreach (Asn1Encodable obj in objs)
		{
			Add(obj);
		}
	}

	public void AddOptional(params Asn1Encodable[] objs)
	{
		if (objs == null)
		{
			return;
		}
		foreach (Asn1Encodable obj in objs)
		{
			if (obj != null)
			{
				Add(obj);
			}
		}
	}

	public void AddOptionalTagged(bool isExplicit, int tagNo, Asn1Encodable obj)
	{
		if (obj != null)
		{
			Add(new DerTaggedObject(isExplicit, tagNo, obj));
		}
	}

	public void AddAll(Asn1EncodableVector other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		int otherElementCount = other.Count;
		if (otherElementCount < 1)
		{
			return;
		}
		int capacity = elements.Length;
		int minCapacity = elementCount + otherElementCount;
		if ((minCapacity > capacity) | copyOnWrite)
		{
			Reallocate(minCapacity);
		}
		int i = 0;
		do
		{
			Asn1Encodable otherElement = other[i];
			if (otherElement == null)
			{
				throw new NullReferenceException("'other' elements cannot be null");
			}
			elements[elementCount + i] = otherElement;
		}
		while (++i < otherElementCount);
		elementCount = minCapacity;
	}

	public IEnumerator GetEnumerator()
	{
		return CopyElements().GetEnumerator();
	}

	internal Asn1Encodable[] CopyElements()
	{
		if (elementCount == 0)
		{
			return EmptyElements;
		}
		Asn1Encodable[] copy = new Asn1Encodable[elementCount];
		Array.Copy(elements, 0, copy, 0, elementCount);
		return copy;
	}

	internal Asn1Encodable[] TakeElements()
	{
		if (elementCount == 0)
		{
			return EmptyElements;
		}
		if (elements.Length == elementCount)
		{
			copyOnWrite = true;
			return elements;
		}
		Asn1Encodable[] copy = new Asn1Encodable[elementCount];
		Array.Copy(elements, 0, copy, 0, elementCount);
		return copy;
	}

	private void Reallocate(int minCapacity)
	{
		Asn1Encodable[] copy = new Asn1Encodable[System.Math.Max(elements.Length, minCapacity + (minCapacity >> 1))];
		Array.Copy(elements, 0, copy, 0, elementCount);
		elements = copy;
		copyOnWrite = false;
	}

	internal static Asn1Encodable[] CloneElements(Asn1Encodable[] elements)
	{
		if (elements.Length >= 1)
		{
			return (Asn1Encodable[])elements.Clone();
		}
		return EmptyElements;
	}
}
