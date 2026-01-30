using System;
using System.Collections.Generic;
using System.IO;

namespace MimeKit.Cryptography;

public abstract class GnuPGContext : OpenPgpContext
{
	private static readonly Dictionary<string, EncryptionAlgorithm> EncryptionAlgorithms;

	private static readonly Dictionary<string, DigestAlgorithm> DigestAlgorithms;

	private static readonly char[] Whitespace;

	private static readonly string GnuPGHomeDir;

	static GnuPGContext()
	{
		Whitespace = new char[2] { ' ', '\t' };
		string text = Environment.GetEnvironmentVariable("GNUPGHOME");
		if (text == null)
		{
			if (Path.DirectorySeparatorChar == '\\')
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				text = Path.Combine(folderPath, "gnupg");
			}
			else
			{
				string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
				text = Path.Combine(folderPath2, ".gnupg");
			}
		}
		GnuPGHomeDir = text;
		EncryptionAlgorithms = new Dictionary<string, EncryptionAlgorithm>(StringComparer.Ordinal)
		{
			{
				"AES",
				EncryptionAlgorithm.Aes128
			},
			{
				"AES128",
				EncryptionAlgorithm.Aes128
			},
			{
				"AES192",
				EncryptionAlgorithm.Aes192
			},
			{
				"AES256",
				EncryptionAlgorithm.Aes256
			},
			{
				"BLOWFISH",
				EncryptionAlgorithm.Blowfish
			},
			{
				"CAMELLIA128",
				EncryptionAlgorithm.Camellia128
			},
			{
				"CAMELLIA192",
				EncryptionAlgorithm.Camellia192
			},
			{
				"CAMELLIA256",
				EncryptionAlgorithm.Camellia256
			},
			{
				"CAST5",
				EncryptionAlgorithm.Cast5
			},
			{
				"IDEA",
				EncryptionAlgorithm.Idea
			},
			{
				"3DES",
				EncryptionAlgorithm.TripleDes
			},
			{
				"TWOFISH",
				EncryptionAlgorithm.Twofish
			}
		};
		DigestAlgorithms = new Dictionary<string, DigestAlgorithm>(StringComparer.Ordinal)
		{
			{
				"RIPEMD160",
				DigestAlgorithm.RipeMD160
			},
			{
				"SHA1",
				DigestAlgorithm.Sha1
			},
			{
				"SHA224",
				DigestAlgorithm.Sha224
			},
			{
				"SHA256",
				DigestAlgorithm.Sha256
			},
			{
				"SHA384",
				DigestAlgorithm.Sha384
			},
			{
				"SHA512",
				DigestAlgorithm.Sha512
			}
		};
	}

	protected GnuPGContext()
		: this(GnuPGHomeDir)
	{
	}

	protected GnuPGContext(string gnupgDir)
		: base(Path.Combine(gnupgDir, "pubring.gpg"), Path.Combine(gnupgDir, "secring.gpg"))
	{
		if (gnupgDir == null)
		{
			throw new ArgumentNullException("gnupgDir");
		}
		string configFile = Path.Combine(gnupgDir, "gpg.conf");
		LoadConfiguration(configFile);
		EncryptionAlgorithm[] array = base.EncryptionAlgorithmRank;
		foreach (EncryptionAlgorithm algorithm in array)
		{
			Enable(algorithm);
		}
		DigestAlgorithm[] array2 = base.DigestAlgorithmRank;
		foreach (DigestAlgorithm algorithm2 in array2)
		{
			Enable(algorithm2);
		}
	}

	private void UpdateKeyServer(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			base.KeyServer = null;
		}
		else if (Uri.IsWellFormedUriString(value, UriKind.Absolute))
		{
			base.KeyServer = new Uri(value, UriKind.Absolute);
		}
	}

	private void UpdateKeyServerOptions(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return;
		}
		string[] array = value.Split(Whitespace, StringSplitOptions.RemoveEmptyEntries);
		foreach (string text in array)
		{
			if (text == "auto-key-retrieve")
			{
				base.AutoKeyRetrieve = true;
			}
		}
	}

	private static EncryptionAlgorithm[] ParseEncryptionAlgorithms(string value)
	{
		string[] array = value.Split(Whitespace, StringSplitOptions.RemoveEmptyEntries);
		List<EncryptionAlgorithm> list = new List<EncryptionAlgorithm>();
		HashSet<EncryptionAlgorithm> hashSet = new HashSet<EncryptionAlgorithm>();
		for (int i = 0; i < array.Length; i++)
		{
			string key = array[i].ToUpperInvariant();
			if (EncryptionAlgorithms.TryGetValue(key, out var value2) && hashSet.Add(value2))
			{
				list.Add(value2);
			}
		}
		if (!hashSet.Contains(EncryptionAlgorithm.TripleDes))
		{
			list.Add(EncryptionAlgorithm.TripleDes);
		}
		return list.ToArray();
	}

	private static DigestAlgorithm[] ParseDigestAlgorithms(string value)
	{
		string[] array = value.Split(Whitespace, StringSplitOptions.RemoveEmptyEntries);
		List<DigestAlgorithm> list = new List<DigestAlgorithm>();
		HashSet<DigestAlgorithm> hashSet = new HashSet<DigestAlgorithm>();
		for (int i = 0; i < array.Length; i++)
		{
			string key = array[i].ToUpperInvariant();
			if (DigestAlgorithms.TryGetValue(key, out var value2) && hashSet.Add(value2))
			{
				list.Add(value2);
			}
		}
		if (!hashSet.Contains(DigestAlgorithm.Sha1))
		{
			list.Add(DigestAlgorithm.Sha1);
		}
		return list.ToArray();
	}

	private void UpdatePersonalCipherPreferences(string value)
	{
		base.EncryptionAlgorithmRank = ParseEncryptionAlgorithms(value);
	}

	private void UpdatePersonalDigestPreferences(string value)
	{
		base.DigestAlgorithmRank = ParseDigestAlgorithms(value);
	}

	private void LoadConfiguration(string configFile)
	{
		if (!File.Exists(configFile))
		{
			return;
		}
		using StreamReader streamReader = File.OpenText(configFile);
		string text;
		while ((text = streamReader.ReadLine()) != null)
		{
			int i;
			for (i = 0; i < text.Length && char.IsWhiteSpace(text[i]); i++)
			{
			}
			if (i != text.Length && text[i] != '#')
			{
				int j;
				for (j = i; j < text.Length && !char.IsWhiteSpace(text[j]); j++)
				{
				}
				string text2 = text.Substring(i, j - i);
				string value = ((j >= text.Length) ? null : text.Substring(j + 1).Trim());
				switch (text2)
				{
				case "keyserver":
					UpdateKeyServer(value);
					break;
				case "keyserver-options":
					UpdateKeyServerOptions(value);
					break;
				case "personal-cipher-preferences":
					UpdatePersonalCipherPreferences(value);
					break;
				case "personal-digest-preferences":
					UpdatePersonalDigestPreferences(value);
					break;
				}
			}
		}
	}
}
