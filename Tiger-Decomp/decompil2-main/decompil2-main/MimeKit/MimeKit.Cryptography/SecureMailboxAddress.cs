using System;
using System.Collections.Generic;
using System.Text;
using MimeKit.Utils;

namespace MimeKit.Cryptography;

public class SecureMailboxAddress : MailboxAddress
{
	public string Fingerprint { get; private set; }

	public SecureMailboxAddress(Encoding encoding, string name, IEnumerable<string> route, string address, string fingerprint)
		: base(encoding, name, route, address)
	{
		ValidateFingerprint(fingerprint);
		Fingerprint = fingerprint;
	}

	public SecureMailboxAddress(string name, IEnumerable<string> route, string address, string fingerprint)
		: base(name, route, address)
	{
		ValidateFingerprint(fingerprint);
		Fingerprint = fingerprint;
	}

	[Obsolete("Use new SecureMailboxAddress (string.Empty, route, address, fingerprint) instead.")]
	public SecureMailboxAddress(IEnumerable<string> route, string address, string fingerprint)
		: base(route, address)
	{
		ValidateFingerprint(fingerprint);
		Fingerprint = fingerprint;
	}

	public SecureMailboxAddress(Encoding encoding, string name, string address, string fingerprint)
		: base(encoding, name, address)
	{
		ValidateFingerprint(fingerprint);
		Fingerprint = fingerprint;
	}

	public SecureMailboxAddress(string name, string address, string fingerprint)
		: base(name, address)
	{
		ValidateFingerprint(fingerprint);
		Fingerprint = fingerprint;
	}

	[Obsolete("Use new SecureMailboxAddress (string.Empty, address, fingerprint) instead.")]
	public SecureMailboxAddress(string address, string fingerprint)
		: base(address)
	{
		ValidateFingerprint(fingerprint);
		Fingerprint = fingerprint;
	}

	private static void ValidateFingerprint(string fingerprint)
	{
		if (fingerprint == null)
		{
			throw new ArgumentNullException("fingerprint");
		}
		for (int i = 0; i < fingerprint.Length; i++)
		{
			if (fingerprint[i] > '\u0080' || !((byte)fingerprint[i]).IsXDigit())
			{
				throw new ArgumentException("The fingerprint should be a hex-encoded string.", "fingerprint");
			}
		}
	}
}
