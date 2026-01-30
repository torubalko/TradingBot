using System;
using System.Collections;
using System.Collections.Generic;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace MimeKit.Cryptography;

public class X509CertificateChain : IList<X509Certificate>, ICollection<X509Certificate>, IEnumerable<X509Certificate>, IEnumerable, IX509Store
{
	private readonly List<X509Certificate> certificates;

	public X509Certificate this[int index]
	{
		get
		{
			return certificates[index];
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			certificates[index] = value;
		}
	}

	public int Count => certificates.Count;

	public bool IsReadOnly => false;

	public X509CertificateChain()
	{
		certificates = new List<X509Certificate>();
	}

	public X509CertificateChain(IEnumerable<X509Certificate> collection)
	{
		certificates = new List<X509Certificate>(collection);
	}

	public int IndexOf(X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		return certificates.IndexOf(certificate);
	}

	public void Insert(int index, X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		certificates.Insert(index, certificate);
	}

	public void RemoveAt(int index)
	{
		if (index < 0 || index >= certificates.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		certificates.RemoveAt(index);
	}

	public void Add(X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		certificates.Add(certificate);
	}

	public void AddRange(IEnumerable<X509Certificate> certificates)
	{
		if (certificates == null)
		{
			throw new ArgumentNullException("certificates");
		}
		foreach (X509Certificate certificate in certificates)
		{
			Add(certificate);
		}
	}

	public void Clear()
	{
		certificates.Clear();
	}

	public bool Contains(X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		return certificates.Contains(certificate);
	}

	public void CopyTo(X509Certificate[] array, int arrayIndex)
	{
		certificates.CopyTo(array, arrayIndex);
	}

	public bool Remove(X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		return certificates.Remove(certificate);
	}

	public void RemoveRange(IEnumerable<X509Certificate> certificates)
	{
		if (certificates == null)
		{
			throw new ArgumentNullException("certificates");
		}
		foreach (X509Certificate certificate in certificates)
		{
			Remove(certificate);
		}
	}

	public IEnumerator<X509Certificate> GetEnumerator()
	{
		return certificates.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return certificates.GetEnumerator();
	}

	public IEnumerable<X509Certificate> GetMatches(IX509Selector selector)
	{
		foreach (X509Certificate certificate in certificates)
		{
			if (selector == null || selector.Match(certificate))
			{
				yield return certificate;
			}
		}
	}

	ICollection IX509Store.GetMatches(IX509Selector selector)
	{
		List<X509Certificate> list = new List<X509Certificate>();
		foreach (X509Certificate match in GetMatches(selector))
		{
			list.Add(match);
		}
		return list;
	}
}
