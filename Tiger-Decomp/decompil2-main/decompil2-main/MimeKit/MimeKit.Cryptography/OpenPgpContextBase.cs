using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.IO;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace MimeKit.Cryptography;

public abstract class OpenPgpContextBase : CryptographyContext
{
	private static readonly string[] ProtocolSubtypes = new string[6] { "pgp-signature", "pgp-encrypted", "pgp-keys", "x-pgp-signature", "x-pgp-encrypted", "x-pgp-keys" };

	private const string BeginPublicKeyBlock = "-----BEGIN PGP PUBLIC KEY BLOCK-----";

	private const string EndPublicKeyBlock = "-----END PGP PUBLIC KEY BLOCK-----";

	private const int BufferLength = 4096;

	private static readonly EncryptionAlgorithm[] DefaultEncryptionAlgorithmRank = new EncryptionAlgorithm[11]
	{
		EncryptionAlgorithm.Idea,
		EncryptionAlgorithm.TripleDes,
		EncryptionAlgorithm.Cast5,
		EncryptionAlgorithm.Blowfish,
		EncryptionAlgorithm.Aes128,
		EncryptionAlgorithm.Aes192,
		EncryptionAlgorithm.Aes256,
		EncryptionAlgorithm.Twofish,
		EncryptionAlgorithm.Camellia128,
		EncryptionAlgorithm.Camellia192,
		EncryptionAlgorithm.Camellia256
	};

	private static readonly DigestAlgorithm[] DefaultDigestAlgorithmRank = new DigestAlgorithm[6]
	{
		DigestAlgorithm.Sha1,
		DigestAlgorithm.RipeMD160,
		DigestAlgorithm.Sha256,
		DigestAlgorithm.Sha384,
		DigestAlgorithm.Sha512,
		DigestAlgorithm.Sha224
	};

	private EncryptionAlgorithm defaultAlgorithm;

	private HttpClient client;

	private Uri keyServer;

	public EncryptionAlgorithm DefaultEncryptionAlgorithm
	{
		get
		{
			return defaultAlgorithm;
		}
		set
		{
			GetSymmetricKeyAlgorithm(value);
			defaultAlgorithm = value;
		}
	}

	private bool IsValidKeyServer
	{
		get
		{
			if (keyServer == null)
			{
				return false;
			}
			switch (keyServer.Scheme.ToLowerInvariant())
			{
			case "https":
			case "http":
			case "hkp":
				return true;
			default:
				return false;
			}
		}
	}

	public Uri KeyServer
	{
		get
		{
			return keyServer;
		}
		set
		{
			if (value != null && !value.IsAbsoluteUri)
			{
				throw new ArgumentException("The key server URI must be absolute.", "value");
			}
			keyServer = value;
		}
	}

	public bool AutoKeyRetrieve { get; set; }

	public override string SignatureProtocol => "application/pgp-signature";

	public override string EncryptionProtocol => "application/pgp-encrypted";

	public override string KeyExchangeProtocol => "application/pgp-keys";

	protected OpenPgpContextBase()
	{
		base.EncryptionAlgorithmRank = DefaultEncryptionAlgorithmRank;
		base.DigestAlgorithmRank = DefaultDigestAlgorithmRank;
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
		defaultAlgorithm = EncryptionAlgorithm.Cast5;
		client = new HttpClient();
	}

	protected abstract string GetPasswordForKey(PgpSecretKey key);

	protected abstract PgpPublicKeyRing GetPublicKeyRing(long keyId, CancellationToken cancellationToken);

	protected abstract Task<PgpPublicKeyRing> GetPublicKeyRingAsync(long keyId, CancellationToken cancellationToken);

	protected abstract PgpSecretKey GetSecretKey(long keyId);

	public abstract IList<PgpPublicKey> GetPublicKeys(IEnumerable<MailboxAddress> mailboxes);

	public abstract PgpSecretKey GetSigningKey(MailboxAddress mailbox);

	public override bool Supports(string protocol)
	{
		if (protocol == null)
		{
			throw new ArgumentNullException("protocol");
		}
		if (!protocol.StartsWith("application/", StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}
		int length = "application/".Length;
		int num = protocol.Length - length;
		for (int i = 0; i < ProtocolSubtypes.Length; i++)
		{
			if (num == ProtocolSubtypes[i].Length && string.Compare(protocol, length, ProtocolSubtypes[i], 0, num, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return true;
			}
		}
		return false;
	}

	public override string GetDigestAlgorithmName(DigestAlgorithm micalg)
	{
		return micalg switch
		{
			DigestAlgorithm.MD5 => "pgp-md5", 
			DigestAlgorithm.Sha1 => "pgp-sha1", 
			DigestAlgorithm.RipeMD160 => "pgp-ripemd160", 
			DigestAlgorithm.MD2 => "pgp-md2", 
			DigestAlgorithm.Tiger192 => "pgp-tiger192", 
			DigestAlgorithm.Haval5160 => "pgp-haval-5-160", 
			DigestAlgorithm.Sha256 => "pgp-sha256", 
			DigestAlgorithm.Sha384 => "pgp-sha384", 
			DigestAlgorithm.Sha512 => "pgp-sha512", 
			DigestAlgorithm.Sha224 => "pgp-sha224", 
			DigestAlgorithm.MD4 => "pgp-md4", 
			_ => throw new ArgumentOutOfRangeException("micalg"), 
		};
	}

	public override DigestAlgorithm GetDigestAlgorithm(string micalg)
	{
		if (micalg == null)
		{
			throw new ArgumentNullException("micalg");
		}
		return micalg.ToLowerInvariant() switch
		{
			"pgp-md5" => DigestAlgorithm.MD5, 
			"pgp-sha1" => DigestAlgorithm.Sha1, 
			"pgp-ripemd160" => DigestAlgorithm.RipeMD160, 
			"pgp-md2" => DigestAlgorithm.MD2, 
			"pgp-tiger192" => DigestAlgorithm.Tiger192, 
			"pgp-haval-5-160" => DigestAlgorithm.Haval5160, 
			"pgp-sha256" => DigestAlgorithm.Sha256, 
			"pgp-sha384" => DigestAlgorithm.Sha384, 
			"pgp-sha512" => DigestAlgorithm.Sha512, 
			"pgp-sha224" => DigestAlgorithm.Sha224, 
			"pgp-md4" => DigestAlgorithm.MD4, 
			_ => DigestAlgorithm.None, 
		};
	}

	private static string HexEncode(byte[] data)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < data.Length; i++)
		{
			stringBuilder.Append(data[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	protected static bool IsMatch(PgpPublicKey key, MailboxAddress mailbox)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (mailbox == null)
		{
			throw new ArgumentNullException("mailbox");
		}
		if (mailbox is SecureMailboxAddress secureMailboxAddress && !string.IsNullOrEmpty(secureMailboxAddress.Fingerprint))
		{
			if (secureMailboxAddress.Fingerprint.Length > 16)
			{
				string value = HexEncode(key.GetFingerprint());
				return secureMailboxAddress.Fingerprint.Equals(value, StringComparison.OrdinalIgnoreCase);
			}
			string value2 = ((int)key.KeyId).ToString("X2");
			return secureMailboxAddress.Fingerprint.EndsWith(value2, StringComparison.OrdinalIgnoreCase);
		}
		foreach (string userId in key.GetUserIds())
		{
			if (MailboxAddress.TryParse(userId, out var mailbox2) && mailbox.Address.Equals(mailbox2.Address, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
		}
		return false;
	}

	protected static bool IsMatch(PgpSecretKey key, MailboxAddress mailbox)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (mailbox == null)
		{
			throw new ArgumentNullException("mailbox");
		}
		if (mailbox is SecureMailboxAddress secureMailboxAddress && !string.IsNullOrEmpty(secureMailboxAddress.Fingerprint))
		{
			if (secureMailboxAddress.Fingerprint.Length > 16)
			{
				string value = HexEncode(key.PublicKey.GetFingerprint());
				return secureMailboxAddress.Fingerprint.Equals(value, StringComparison.OrdinalIgnoreCase);
			}
			string value2 = ((int)key.KeyId).ToString("X2");
			return secureMailboxAddress.Fingerprint.EndsWith(value2, StringComparison.OrdinalIgnoreCase);
		}
		foreach (string userId in key.UserIds)
		{
			if (MailboxAddress.TryParse(userId, out var mailbox2) && mailbox.Address.Equals(mailbox2.Address, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
		}
		return false;
	}

	protected static bool IsExpired(PgpPublicKey key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		long validSeconds = key.GetValidSeconds();
		if (validSeconds != 0L)
		{
			DateTime dateTime = key.CreationTime.AddSeconds(validSeconds);
			if (dateTime <= DateTime.Now)
			{
				return true;
			}
		}
		return false;
	}

	private async Task<PgpPublicKeyRing> RetrievePublicKeyRingAsync(long keyId, bool doAsync, CancellationToken cancellationToken)
	{
		if (!IsValidKeyServer)
		{
			return null;
		}
		string text = keyServer.Scheme.ToLowerInvariant();
		UriBuilder uriBuilder = new UriBuilder();
		uriBuilder.Scheme = ((text == "hkp") ? "http" : text);
		uriBuilder.Host = keyServer.Host;
		if (keyServer.IsDefaultPort)
		{
			if (text == "hkp")
			{
				uriBuilder.Port = 11371;
			}
		}
		else
		{
			uriBuilder.Port = keyServer.Port;
		}
		uriBuilder.Path = "/pks/lookup";
		uriBuilder.Query = string.Format(CultureInfo.InvariantCulture, "op=get&search=0x{0:X}", keyId);
		using MemoryBlockStream stream = new MemoryBlockStream();
		using (FilteredStream filtered = new FilteredStream(stream))
		{
			filtered.Add(new OpenPgpBlockFilter("-----BEGIN PGP PUBLIC KEY BLOCK-----", "-----END PGP PUBLIC KEY BLOCK-----"));
			if (doAsync)
			{
				using HttpResponseMessage response = await client.GetAsync(uriBuilder.ToString(), cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				await response.Content.CopyToAsync(filtered).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uriBuilder.ToString());
				using WebResponse webResponse = httpWebRequest.GetResponse();
				Stream responseStream = webResponse.GetResponseStream();
				responseStream.CopyTo(filtered, 4096);
			}
			filtered.Flush();
		}
		stream.Position = 0L;
		using ArmoredInputStream inputStream = new ArmoredInputStream(stream, hasHeaders: true);
		PgpPublicKeyRingBundle pgpPublicKeyRingBundle = new PgpPublicKeyRingBundle(inputStream);
		Import(pgpPublicKeyRingBundle);
		return pgpPublicKeyRingBundle.GetPublicKeyRing(keyId);
	}

	protected PgpPublicKeyRing RetrievePublicKeyRing(long keyId, CancellationToken cancellationToken)
	{
		return RetrievePublicKeyRingAsync(keyId, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	protected Task<PgpPublicKeyRing> RetrievePublicKeyRingAsync(long keyId, CancellationToken cancellationToken)
	{
		return RetrievePublicKeyRingAsync(keyId, doAsync: true, cancellationToken);
	}

	protected PgpPrivateKey GetPrivateKey(PgpSecretKey key)
	{
		int num = 0;
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		do
		{
			string passwordForKey;
			if ((passwordForKey = GetPasswordForKey(key)) == null)
			{
				throw new OperationCanceledException();
			}
			try
			{
				PgpPrivateKey pgpPrivateKey = key.ExtractPrivateKey(passwordForKey.ToCharArray());
				if (pgpPrivateKey == null)
				{
					break;
				}
				return pgpPrivateKey;
			}
			catch (Exception)
			{
				goto IL_003c;
			}
			IL_003c:
			num++;
		}
		while (num < 3);
		throw new UnauthorizedAccessException();
	}

	public static HashAlgorithmTag GetHashAlgorithm(DigestAlgorithm digestAlgo)
	{
		return digestAlgo switch
		{
			DigestAlgorithm.MD5 => HashAlgorithmTag.MD5, 
			DigestAlgorithm.Sha1 => HashAlgorithmTag.Sha1, 
			DigestAlgorithm.RipeMD160 => HashAlgorithmTag.RipeMD160, 
			DigestAlgorithm.DoubleSha => throw new NotSupportedException("The Double SHA digest algorithm is not supported."), 
			DigestAlgorithm.MD2 => HashAlgorithmTag.MD2, 
			DigestAlgorithm.Tiger192 => throw new NotSupportedException("The Tiger-192 digest algorithm is not supported."), 
			DigestAlgorithm.Haval5160 => throw new NotSupportedException("The HAVAL 5 160 digest algorithm is not supported."), 
			DigestAlgorithm.Sha256 => HashAlgorithmTag.Sha256, 
			DigestAlgorithm.Sha384 => HashAlgorithmTag.Sha384, 
			DigestAlgorithm.Sha512 => HashAlgorithmTag.Sha512, 
			DigestAlgorithm.Sha224 => HashAlgorithmTag.Sha224, 
			DigestAlgorithm.MD4 => throw new NotSupportedException("The MD4 digest algorithm is not supported."), 
			_ => throw new ArgumentOutOfRangeException("digestAlgo"), 
		};
	}

	public override MimePart Sign(MailboxAddress signer, DigestAlgorithm digestAlgo, Stream content)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		PgpSecretKey signingKey = GetSigningKey(signer);
		return Sign(signingKey, digestAlgo, content);
	}

	public ApplicationPgpSignature Sign(PgpSecretKey signer, DigestAlgorithm digestAlgo, Stream content)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (!signer.IsSigningKey)
		{
			throw new ArgumentException("The specified secret key cannot be used for signing.", "signer");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		HashAlgorithmTag hashAlgorithm = GetHashAlgorithm(digestAlgo);
		MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		using (ArmoredOutputStream armoredOutputStream = new ArmoredOutputStream(memoryBlockStream))
		{
			armoredOutputStream.SetHeader("Version", null);
			PgpSignatureGenerator pgpSignatureGenerator = new PgpSignatureGenerator(signer.PublicKey.Algorithm, hashAlgorithm);
			byte[] array = ArrayPool<byte>.Shared.Rent(4096);
			try
			{
				pgpSignatureGenerator.InitSign(1, GetPrivateKey(signer));
				int len;
				while ((len = content.Read(array, 0, 4096)) > 0)
				{
					pgpSignatureGenerator.Update(array, 0, len);
				}
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(array);
			}
			PgpSignature pgpSignature = pgpSignatureGenerator.Generate();
			pgpSignature.Encode(armoredOutputStream);
			armoredOutputStream.Flush();
		}
		memoryBlockStream.Position = 0L;
		return new ApplicationPgpSignature(memoryBlockStream);
	}

	public static DigestAlgorithm GetDigestAlgorithm(HashAlgorithmTag hashAlgorithm)
	{
		return hashAlgorithm switch
		{
			HashAlgorithmTag.MD5 => DigestAlgorithm.MD5, 
			HashAlgorithmTag.Sha1 => DigestAlgorithm.Sha1, 
			HashAlgorithmTag.RipeMD160 => DigestAlgorithm.RipeMD160, 
			HashAlgorithmTag.DoubleSha => DigestAlgorithm.DoubleSha, 
			HashAlgorithmTag.MD2 => DigestAlgorithm.MD2, 
			HashAlgorithmTag.Tiger192 => DigestAlgorithm.Tiger192, 
			HashAlgorithmTag.Haval5pass160 => DigestAlgorithm.Haval5160, 
			HashAlgorithmTag.Sha256 => DigestAlgorithm.Sha256, 
			HashAlgorithmTag.Sha384 => DigestAlgorithm.Sha384, 
			HashAlgorithmTag.Sha512 => DigestAlgorithm.Sha512, 
			HashAlgorithmTag.Sha224 => DigestAlgorithm.Sha224, 
			_ => throw new ArgumentOutOfRangeException("hashAlgorithm"), 
		};
	}

	public static PublicKeyAlgorithm GetPublicKeyAlgorithm(PublicKeyAlgorithmTag algorithm)
	{
		return algorithm switch
		{
			PublicKeyAlgorithmTag.RsaGeneral => PublicKeyAlgorithm.RsaGeneral, 
			PublicKeyAlgorithmTag.RsaEncrypt => PublicKeyAlgorithm.RsaEncrypt, 
			PublicKeyAlgorithmTag.RsaSign => PublicKeyAlgorithm.RsaSign, 
			PublicKeyAlgorithmTag.ElGamalGeneral => PublicKeyAlgorithm.ElGamalGeneral, 
			PublicKeyAlgorithmTag.ElGamalEncrypt => PublicKeyAlgorithm.ElGamalEncrypt, 
			PublicKeyAlgorithmTag.Dsa => PublicKeyAlgorithm.Dsa, 
			PublicKeyAlgorithmTag.EC => PublicKeyAlgorithm.EllipticCurve, 
			PublicKeyAlgorithmTag.ECDsa => PublicKeyAlgorithm.EllipticCurveDsa, 
			PublicKeyAlgorithmTag.DiffieHellman => PublicKeyAlgorithm.DiffieHellman, 
			_ => throw new ArgumentOutOfRangeException("algorithm"), 
		};
	}

	private bool TryGetPublicKey(PgpPublicKeyRing keyring, long keyId, out PgpPublicKey pubkey)
	{
		if (keyring != null)
		{
			foreach (PgpPublicKey publicKey in keyring.GetPublicKeys())
			{
				if (publicKey.KeyId == keyId)
				{
					pubkey = publicKey;
					return true;
				}
			}
		}
		pubkey = null;
		return false;
	}

	private async Task<DigitalSignatureCollection> GetDigitalSignaturesAsync(PgpSignatureList signatureList, Stream content, bool doAsync, CancellationToken cancellationToken)
	{
		List<IDigitalSignature> signatures = new List<IDigitalSignature>();
		for (int i = 0; i < signatureList.Count; i++)
		{
			long keyId = signatureList[i].KeyId;
			PgpPublicKeyRing keyring = ((!doAsync) ? GetPublicKeyRing(keyId, cancellationToken) : (await GetPublicKeyRingAsync(keyId, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)));
			TryGetPublicKey(keyring, keyId, out var pubkey);
			OpenPgpDigitalSignature item = new OpenPgpDigitalSignature(keyring, pubkey, signatureList[i])
			{
				PublicKeyAlgorithm = GetPublicKeyAlgorithm(signatureList[i].KeyAlgorithm),
				DigestAlgorithm = GetDigestAlgorithm(signatureList[i].HashAlgorithm),
				CreationDate = signatureList[i].CreationTime
			};
			if (pubkey != null)
			{
				signatureList[i].InitVerify(pubkey);
			}
			signatures.Add(item);
		}
		byte[] array = ArrayPool<byte>.Shared.Rent(4096);
		try
		{
			int length;
			while ((length = content.Read(array, 0, 4096)) > 0)
			{
				for (int j = 0; j < signatures.Count; j++)
				{
					if (signatures[j].SignerCertificate != null)
					{
						OpenPgpDigitalSignature openPgpDigitalSignature = (OpenPgpDigitalSignature)signatures[j];
						openPgpDigitalSignature.Signature.Update(array, 0, length);
					}
				}
			}
		}
		finally
		{
			ArrayPool<byte>.Shared.Return(array);
		}
		return new DigitalSignatureCollection(signatures);
	}

	private Task<DigitalSignatureCollection> VerifyAsync(Stream content, Stream signatureData, bool doAsync, CancellationToken cancellationToken)
	{
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		if (signatureData == null)
		{
			throw new ArgumentNullException("signatureData");
		}
		using ArmoredInputStream inputStream = new ArmoredInputStream(signatureData);
		PgpObjectFactory pgpObjectFactory = new PgpObjectFactory(inputStream);
		PgpObject pgpObject = pgpObjectFactory.NextPgpObject();
		if (pgpObject is PgpCompressedData pgpCompressedData)
		{
			pgpObjectFactory = new PgpObjectFactory(pgpCompressedData.GetDataStream());
			pgpObject = pgpObjectFactory.NextPgpObject();
		}
		if (pgpObject == null)
		{
			throw new FormatException("Invalid PGP format.");
		}
		PgpSignatureList signatureList = (PgpSignatureList)pgpObject;
		return GetDigitalSignaturesAsync(signatureList, content, doAsync, cancellationToken);
	}

	public override DigitalSignatureCollection Verify(Stream content, Stream signatureData, CancellationToken cancellationToken = default(CancellationToken))
	{
		return VerifyAsync(content, signatureData, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<DigitalSignatureCollection> VerifyAsync(Stream content, Stream signatureData, CancellationToken cancellationToken = default(CancellationToken))
	{
		return VerifyAsync(content, signatureData, doAsync: true, cancellationToken);
	}

	private static Stream Compress(Stream content, byte[] buf, int bufferLength)
	{
		PgpCompressedDataGenerator pgpCompressedDataGenerator = new PgpCompressedDataGenerator(CompressionAlgorithmTag.ZLib);
		MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		using (Stream stream = pgpCompressedDataGenerator.Open(memoryBlockStream))
		{
			PgpLiteralDataGenerator pgpLiteralDataGenerator = new PgpLiteralDataGenerator();
			using (Stream stream2 = pgpLiteralDataGenerator.Open(stream, 't', "mime.txt", content.Length, DateTime.Now))
			{
				int count;
				while ((count = content.Read(buf, 0, bufferLength)) > 0)
				{
					stream2.Write(buf, 0, count);
				}
				stream2.Flush();
			}
			stream.Flush();
		}
		memoryBlockStream.Position = 0L;
		return memoryBlockStream;
	}

	private static Stream Encrypt(PgpEncryptedDataGenerator encrypter, Stream content)
	{
		MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		using (ArmoredOutputStream armoredOutputStream = new ArmoredOutputStream(memoryBlockStream))
		{
			byte[] array = ArrayPool<byte>.Shared.Rent(4096);
			try
			{
				armoredOutputStream.SetHeader("Version", null);
				using (Stream stream = Compress(content, array, 4096))
				{
					using Stream stream2 = encrypter.Open(armoredOutputStream, stream.Length);
					try
					{
						int count;
						while ((count = stream.Read(array, 0, 4096)) > 0)
						{
							stream2.Write(array, 0, count);
						}
					}
					finally
					{
						ArrayPool<byte>.Shared.Return(array);
					}
					stream2.Flush();
				}
				armoredOutputStream.Flush();
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(array);
			}
		}
		memoryBlockStream.Position = 0L;
		return memoryBlockStream;
	}

	internal static SymmetricKeyAlgorithmTag GetSymmetricKeyAlgorithm(EncryptionAlgorithm algorithm)
	{
		return algorithm switch
		{
			EncryptionAlgorithm.Aes128 => SymmetricKeyAlgorithmTag.Aes128, 
			EncryptionAlgorithm.Aes192 => SymmetricKeyAlgorithmTag.Aes192, 
			EncryptionAlgorithm.Aes256 => SymmetricKeyAlgorithmTag.Aes256, 
			EncryptionAlgorithm.Camellia128 => SymmetricKeyAlgorithmTag.Camellia128, 
			EncryptionAlgorithm.Camellia192 => SymmetricKeyAlgorithmTag.Camellia192, 
			EncryptionAlgorithm.Camellia256 => SymmetricKeyAlgorithmTag.Camellia256, 
			EncryptionAlgorithm.Cast5 => SymmetricKeyAlgorithmTag.Cast5, 
			EncryptionAlgorithm.Des => SymmetricKeyAlgorithmTag.Des, 
			EncryptionAlgorithm.TripleDes => SymmetricKeyAlgorithmTag.TripleDes, 
			EncryptionAlgorithm.Idea => SymmetricKeyAlgorithmTag.Idea, 
			EncryptionAlgorithm.Blowfish => SymmetricKeyAlgorithmTag.Blowfish, 
			EncryptionAlgorithm.Twofish => SymmetricKeyAlgorithmTag.Twofish, 
			_ => throw new NotSupportedException($"{algorithm} is not supported."), 
		};
	}

	public override MimePart Encrypt(IEnumerable<MailboxAddress> recipients, Stream content)
	{
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		return Encrypt(GetPublicKeys(recipients), content);
	}

	public MimePart Encrypt(EncryptionAlgorithm algorithm, IEnumerable<MailboxAddress> recipients, Stream content)
	{
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		return Encrypt(algorithm, GetPublicKeys(recipients), content);
	}

	public MimePart Encrypt(EncryptionAlgorithm algorithm, IEnumerable<PgpPublicKey> recipients, Stream content)
	{
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		PgpEncryptedDataGenerator pgpEncryptedDataGenerator = new PgpEncryptedDataGenerator(GetSymmetricKeyAlgorithm(algorithm), withIntegrityPacket: true);
		HashSet<long> hashSet = new HashSet<long>();
		int num = 0;
		foreach (PgpPublicKey recipient in recipients)
		{
			if (!recipient.IsEncryptionKey)
			{
				throw new ArgumentException("One or more of the recipient keys cannot be used for encrypting.", "recipients");
			}
			if (hashSet.Add(recipient.KeyId))
			{
				pgpEncryptedDataGenerator.AddMethod(recipient);
				num++;
			}
		}
		if (num == 0)
		{
			throw new ArgumentException("No recipients specified.", "recipients");
		}
		Stream stream = Encrypt(pgpEncryptedDataGenerator, content);
		return new MimePart("application", "octet-stream")
		{
			ContentDisposition = new ContentDisposition("attachment"),
			Content = new MimeContent(stream)
		};
	}

	public MimePart Encrypt(IEnumerable<PgpPublicKey> recipients, Stream content)
	{
		return Encrypt(defaultAlgorithm, recipients, content);
	}

	public MimePart SignAndEncrypt(MailboxAddress signer, DigestAlgorithm digestAlgo, IEnumerable<MailboxAddress> recipients, Stream content)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		PgpSecretKey signingKey = GetSigningKey(signer);
		return SignAndEncrypt(signingKey, digestAlgo, GetPublicKeys(recipients), content);
	}

	public MimePart SignAndEncrypt(MailboxAddress signer, DigestAlgorithm digestAlgo, EncryptionAlgorithm cipherAlgo, IEnumerable<MailboxAddress> recipients, Stream content)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		PgpSecretKey signingKey = GetSigningKey(signer);
		return SignAndEncrypt(signingKey, digestAlgo, cipherAlgo, GetPublicKeys(recipients), content);
	}

	public MimePart SignAndEncrypt(PgpSecretKey signer, DigestAlgorithm digestAlgo, EncryptionAlgorithm cipherAlgo, IEnumerable<PgpPublicKey> recipients, Stream content)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (!signer.IsSigningKey)
		{
			throw new ArgumentException("The specified secret key cannot be used for signing.", "signer");
		}
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		PgpEncryptedDataGenerator pgpEncryptedDataGenerator = new PgpEncryptedDataGenerator(GetSymmetricKeyAlgorithm(cipherAlgo), withIntegrityPacket: true);
		HashAlgorithmTag hashAlgorithm = GetHashAlgorithm(digestAlgo);
		HashSet<long> hashSet = new HashSet<long>();
		int num = 0;
		foreach (PgpPublicKey recipient in recipients)
		{
			if (!recipient.IsEncryptionKey)
			{
				throw new ArgumentException("One or more of the recipient keys cannot be used for encrypting.", "recipients");
			}
			if (hashSet.Add(recipient.KeyId))
			{
				pgpEncryptedDataGenerator.AddMethod(recipient);
				num++;
			}
		}
		if (num == 0)
		{
			throw new ArgumentException("No recipients specified.", "recipients");
		}
		PgpCompressedDataGenerator pgpCompressedDataGenerator = new PgpCompressedDataGenerator(CompressionAlgorithmTag.ZLib);
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		using (Stream stream = pgpCompressedDataGenerator.Open(memoryBlockStream))
		{
			PgpSignatureGenerator pgpSignatureGenerator = new PgpSignatureGenerator(signer.PublicKey.Algorithm, hashAlgorithm);
			pgpSignatureGenerator.InitSign(1, GetPrivateKey(signer));
			PgpSignatureSubpacketGenerator pgpSignatureSubpacketGenerator = new PgpSignatureSubpacketGenerator();
			IEnumerator enumerator2 = signer.PublicKey.GetUserIds().GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					string userId = (string)enumerator2.Current;
					pgpSignatureSubpacketGenerator.SetSignerUserId(isCritical: false, userId);
				}
			}
			finally
			{
				IDisposable disposable = enumerator2 as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			pgpSignatureGenerator.SetHashedSubpackets(pgpSignatureSubpacketGenerator.Generate());
			PgpOnePassSignature pgpOnePassSignature = pgpSignatureGenerator.GenerateOnePassVersion(isNested: false);
			pgpOnePassSignature.Encode(stream);
			PgpLiteralDataGenerator pgpLiteralDataGenerator = new PgpLiteralDataGenerator();
			using (Stream stream2 = pgpLiteralDataGenerator.Open(stream, 't', "mime.txt", content.Length, DateTime.Now))
			{
				byte[] array = ArrayPool<byte>.Shared.Rent(4096);
				try
				{
					int num2;
					while ((num2 = content.Read(array, 0, 4096)) > 0)
					{
						pgpSignatureGenerator.Update(array, 0, num2);
						stream2.Write(array, 0, num2);
					}
				}
				finally
				{
					ArrayPool<byte>.Shared.Return(array);
				}
				stream2.Flush();
			}
			PgpSignature pgpSignature = pgpSignatureGenerator.Generate();
			pgpSignature.Encode(stream);
			stream.Flush();
		}
		memoryBlockStream.Position = 0L;
		MemoryBlockStream memoryBlockStream2 = new MemoryBlockStream();
		using (ArmoredOutputStream armoredOutputStream = new ArmoredOutputStream(memoryBlockStream2))
		{
			armoredOutputStream.SetHeader("Version", null);
			using (Stream stream3 = pgpEncryptedDataGenerator.Open(armoredOutputStream, memoryBlockStream.Length))
			{
				byte[] array2 = ArrayPool<byte>.Shared.Rent(4096);
				try
				{
					int count;
					while ((count = memoryBlockStream.Read(array2, 0, 4096)) > 0)
					{
						stream3.Write(array2, 0, count);
					}
				}
				finally
				{
					ArrayPool<byte>.Shared.Return(array2);
				}
				stream3.Flush();
			}
			armoredOutputStream.Flush();
		}
		memoryBlockStream2.Position = 0L;
		return new MimePart("application", "octet-stream")
		{
			ContentDisposition = new ContentDisposition("attachment"),
			Content = new MimeContent(memoryBlockStream2)
		};
	}

	public MimePart SignAndEncrypt(PgpSecretKey signer, DigestAlgorithm digestAlgo, IEnumerable<PgpPublicKey> recipients, Stream content)
	{
		return SignAndEncrypt(signer, digestAlgo, defaultAlgorithm, recipients, content);
	}

	private async Task<DigitalSignatureCollection> DecryptToAsync(Stream encryptedData, Stream decryptedData, bool doAsync, CancellationToken cancellationToken)
	{
		if (encryptedData == null)
		{
			throw new ArgumentNullException("encryptedData");
		}
		if (decryptedData == null)
		{
			throw new ArgumentNullException("decryptedData");
		}
		using ArmoredInputStream armored = new ArmoredInputStream(encryptedData);
		PgpObjectFactory factory = new PgpObjectFactory(armored);
		PgpObject pgpObject = factory.NextPgpObject();
		PgpEncryptedDataList pgpEncryptedDataList = pgpObject as PgpEncryptedDataList;
		if (pgpEncryptedDataList == null)
		{
			pgpObject = factory.NextPgpObject();
			pgpEncryptedDataList = pgpObject as PgpEncryptedDataList;
			if (pgpEncryptedDataList == null)
			{
				throw new PgpException("Unexpected OpenPGP packet.");
			}
		}
		PgpPublicKeyEncryptedData pgpPublicKeyEncryptedData = null;
		PrivateKeyNotFoundException ex = null;
		bool flag = false;
		PgpSecretKey pgpSecretKey = null;
		foreach (PgpEncryptedData encryptedDataObject in pgpEncryptedDataList.GetEncryptedDataObjects())
		{
			if ((pgpPublicKeyEncryptedData = encryptedDataObject as PgpPublicKeyEncryptedData) != null)
			{
				flag = true;
				try
				{
					pgpSecretKey = GetSecretKey(pgpPublicKeyEncryptedData.KeyId);
				}
				catch (PrivateKeyNotFoundException ex2)
				{
					ex = ex2;
					continue;
				}
				break;
			}
		}
		if (!flag)
		{
			throw new PgpException("No encrypted packets found.");
		}
		if (pgpSecretKey == null)
		{
			throw ex;
		}
		factory = new PgpObjectFactory(pgpPublicKeyEncryptedData.GetDataStream(GetPrivateKey(pgpSecretKey)));
		List<IDigitalSignature> onepassList = null;
		PgpSignatureList signatureList = null;
		PgpCompressedData compressed = null;
		long position = decryptedData.Position;
		long nwritten = 0L;
		for (pgpObject = factory.NextPgpObject(); pgpObject != null; pgpObject = factory.NextPgpObject())
		{
			if (pgpObject is PgpCompressedData)
			{
				if (compressed != null)
				{
					throw new PgpException("Recursive compression packets are not supported.");
				}
				compressed = (PgpCompressedData)pgpObject;
				factory = new PgpObjectFactory(compressed.GetDataStream());
			}
			else if (pgpObject is PgpOnePassSignatureList)
			{
				if (nwritten == 0L)
				{
					PgpOnePassSignatureList onepasses = (PgpOnePassSignatureList)pgpObject;
					onepassList = new List<IDigitalSignature>();
					for (int i = 0; i < onepasses.Count; i++)
					{
						PgpOnePassSignature onepass = onepasses[i];
						PgpPublicKeyRing keyring = ((!doAsync) ? GetPublicKeyRing(onepass.KeyId, cancellationToken) : (await GetPublicKeyRingAsync(onepass.KeyId, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)));
						if (!TryGetPublicKey(keyring, onepass.KeyId, out var pubkey))
						{
							onepassList = null;
							break;
						}
						onepass.InitVerify(pubkey);
						OpenPgpDigitalSignature item = new OpenPgpDigitalSignature(keyring, pubkey, onepass)
						{
							PublicKeyAlgorithm = GetPublicKeyAlgorithm(onepass.KeyAlgorithm),
							DigestAlgorithm = GetDigestAlgorithm(onepass.HashAlgorithm)
						};
						onepassList.Add(item);
					}
				}
			}
			else if (pgpObject is PgpSignatureList)
			{
				signatureList = (PgpSignatureList)pgpObject;
			}
			else if (pgpObject is PgpLiteralData)
			{
				PgpLiteralData pgpLiteralData = (PgpLiteralData)pgpObject;
				using Stream stream = pgpLiteralData.GetDataStream();
				byte[] buf = ArrayPool<byte>.Shared.Rent(4096);
				try
				{
					while (true)
					{
						int num;
						int i = (num = stream.Read(buf, 0, 4096));
						if (num <= 0)
						{
							break;
						}
						if (onepassList != null)
						{
							for (int j = 0; j < i; j++)
							{
								byte b = buf[j];
								for (int k = 0; k < onepassList.Count; k++)
								{
									OpenPgpDigitalSignature openPgpDigitalSignature = (OpenPgpDigitalSignature)onepassList[k];
									openPgpDigitalSignature.OnePassSignature.Update(b);
								}
							}
						}
						if (doAsync)
						{
							await decryptedData.WriteAsync(buf, 0, i, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
						}
						else
						{
							decryptedData.Write(buf, 0, i);
						}
						nwritten += i;
					}
				}
				finally
				{
					ArrayPool<byte>.Shared.Return(buf);
				}
			}
		}
		DigitalSignatureCollection result;
		if (signatureList != null)
		{
			if (onepassList != null && signatureList.Count == onepassList.Count)
			{
				for (int l = 0; l < onepassList.Count; l++)
				{
					OpenPgpDigitalSignature openPgpDigitalSignature2 = (OpenPgpDigitalSignature)onepassList[l];
					openPgpDigitalSignature2.CreationDate = signatureList[l].CreationTime;
					openPgpDigitalSignature2.Signature = signatureList[l];
				}
				result = new DigitalSignatureCollection(onepassList);
			}
			else
			{
				decryptedData.Position = position;
				result = await GetDigitalSignaturesAsync(signatureList, decryptedData, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				decryptedData.Position = decryptedData.Length;
			}
		}
		else
		{
			result = null;
		}
		return result;
	}

	public DigitalSignatureCollection DecryptTo(Stream encryptedData, Stream decryptedData, CancellationToken cancellationToken = default(CancellationToken))
	{
		return DecryptToAsync(encryptedData, decryptedData, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public Task<DigitalSignatureCollection> DecryptToAsync(Stream encryptedData, Stream decryptedData, CancellationToken cancellationToken = default(CancellationToken))
	{
		return DecryptToAsync(encryptedData, decryptedData, doAsync: true, cancellationToken);
	}

	public MimeEntity Decrypt(Stream encryptedData, out DigitalSignatureCollection signatures, CancellationToken cancellationToken = default(CancellationToken))
	{
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		signatures = DecryptTo(encryptedData, memoryBlockStream, cancellationToken);
		memoryBlockStream.Position = 0L;
		return MimeEntity.Load(memoryBlockStream, cancellationToken);
	}

	public override MimeEntity Decrypt(Stream encryptedData, CancellationToken cancellationToken = default(CancellationToken))
	{
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		DecryptTo(encryptedData, memoryBlockStream, cancellationToken);
		memoryBlockStream.Position = 0L;
		return MimeEntity.Load(memoryBlockStream, cancellationToken);
	}

	public abstract void Import(PgpPublicKeyRingBundle bundle);

	protected override void Dispose(bool disposing)
	{
		if (disposing && client != null)
		{
			client.Dispose();
			client = null;
		}
		base.Dispose(disposing);
	}
}
