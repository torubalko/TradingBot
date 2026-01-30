using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace MimeKit.Cryptography;

public class X509CertificateStore : IX509Store
{
	private readonly Dictionary<X509Certificate, AsymmetricKeyParameter> keys;

	private readonly HashSet<X509Certificate> unique;

	private readonly List<X509Certificate> certs;

	public IEnumerable<X509Certificate> Certificates => certs;

	public X509CertificateStore()
	{
		keys = new Dictionary<X509Certificate, AsymmetricKeyParameter>();
		unique = new HashSet<X509Certificate>();
		certs = new List<X509Certificate>();
	}

	public AsymmetricKeyParameter GetPrivateKey(X509Certificate certificate)
	{
		if (!keys.TryGetValue(certificate, out var value))
		{
			return null;
		}
		return value;
	}

	public void Add(X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (unique.Add(certificate))
		{
			certs.Add(certificate);
		}
	}

	public void AddRange(IEnumerable<X509Certificate> certificates)
	{
		if (certificates == null)
		{
			throw new ArgumentNullException("certificates");
		}
		foreach (X509Certificate certificate in certificates)
		{
			if (unique.Add(certificate))
			{
				certs.Add(certificate);
			}
		}
	}

	public void Remove(X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (unique.Remove(certificate))
		{
			certs.Remove(certificate);
		}
	}

	public void RemoveRange(IEnumerable<X509Certificate> certificates)
	{
		if (certificates == null)
		{
			throw new ArgumentNullException("certificates");
		}
		foreach (X509Certificate certificate in certificates)
		{
			if (unique.Remove(certificate))
			{
				certs.Remove(certificate);
			}
		}
	}

	public void Import(Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		X509CertificateParser x509CertificateParser = new X509CertificateParser();
		foreach (X509Certificate item in x509CertificateParser.ReadCertificates(stream))
		{
			if (unique.Add(item))
			{
				certs.Add(item);
			}
		}
	}

	public void Import(string fileName)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		using FileStream stream = File.OpenRead(fileName);
		Import(stream);
	}

	public void Import(byte[] rawData)
	{
		if (rawData == null)
		{
			throw new ArgumentNullException("rawData");
		}
		using MemoryStream stream = new MemoryStream(rawData, writable: false);
		Import(stream);
	}

	public void Import(Stream stream, string password)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		Pkcs12Store pkcs12Store = new Pkcs12Store(stream, password.ToCharArray());
		foreach (string alias in pkcs12Store.Aliases)
		{
			if (pkcs12Store.IsKeyEntry(alias))
			{
				X509CertificateEntry[] certificateChain = pkcs12Store.GetCertificateChain(alias);
				AsymmetricKeyEntry key = pkcs12Store.GetKey(alias);
				for (int i = 0; i < certificateChain.Length; i++)
				{
					if (unique.Add(certificateChain[i].Certificate))
					{
						certs.Add(certificateChain[i].Certificate);
					}
				}
				if (key.Key.IsPrivate)
				{
					keys.Add(certificateChain[0].Certificate, key.Key);
				}
			}
			else if (pkcs12Store.IsCertificateEntry(alias))
			{
				X509CertificateEntry certificate = pkcs12Store.GetCertificate(alias);
				if (unique.Add(certificate.Certificate))
				{
					certs.Add(certificate.Certificate);
				}
			}
		}
	}

	public void Import(string fileName, string password)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		using FileStream stream = File.OpenRead(fileName);
		Import(stream, password);
	}

	public void Import(byte[] rawData, string password)
	{
		if (rawData == null)
		{
			throw new ArgumentNullException("rawData");
		}
		using MemoryStream stream = new MemoryStream(rawData, writable: false);
		Import(stream, password);
	}

	public void Export(Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		foreach (X509Certificate cert in certs)
		{
			byte[] encoded = cert.GetEncoded();
			stream.Write(encoded, 0, encoded.Length);
		}
	}

	public void Export(string fileName)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		using FileStream stream = File.Create(fileName);
		Export(stream);
	}

	public void Export(Stream stream, string password)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		Pkcs12Store pkcs12Store = new Pkcs12Store();
		foreach (X509Certificate cert in certs)
		{
			if (!keys.ContainsKey(cert))
			{
				string commonName = cert.GetCommonName();
				if (commonName != null)
				{
					X509CertificateEntry certEntry = new X509CertificateEntry(cert);
					pkcs12Store.SetCertificateEntry(commonName, certEntry);
				}
			}
		}
		foreach (KeyValuePair<X509Certificate, AsymmetricKeyParameter> key in keys)
		{
			string commonName2 = key.Key.GetCommonName();
			if (commonName2 != null)
			{
				AsymmetricKeyEntry keyEntry = new AsymmetricKeyEntry(key.Value);
				X509CertificateEntry item = new X509CertificateEntry(key.Key);
				List<X509CertificateEntry> list = new List<X509CertificateEntry>();
				list.Add(item);
				pkcs12Store.SetKeyEntry(commonName2, keyEntry, list.ToArray());
			}
		}
		pkcs12Store.Save(stream, password.ToCharArray(), new SecureRandom());
	}

	public void Export(string fileName, string password)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		using FileStream stream = File.Create(fileName);
		Export(stream, password);
	}

	public IEnumerable<X509Certificate> GetMatches(IX509Selector selector)
	{
		foreach (X509Certificate cert in certs)
		{
			if (selector == null || selector.Match(cert))
			{
				yield return cert;
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
