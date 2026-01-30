using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public sealed class OfferedPsks
{
	internal class BindersConfig
	{
		internal readonly TlsPsk[] m_psks;

		internal readonly short[] m_pskKeyExchangeModes;

		internal readonly TlsSecret[] m_earlySecrets;

		internal int m_bindersSize;

		internal BindersConfig(TlsPsk[] psks, short[] pskKeyExchangeModes, TlsSecret[] earlySecrets, int bindersSize)
		{
			m_psks = psks;
			m_pskKeyExchangeModes = pskKeyExchangeModes;
			m_earlySecrets = earlySecrets;
			m_bindersSize = bindersSize;
		}
	}

	internal class SelectedConfig
	{
		internal readonly int m_index;

		internal readonly TlsPsk m_psk;

		internal readonly short[] m_pskKeyExchangeModes;

		internal readonly TlsSecret m_earlySecret;

		internal SelectedConfig(int index, TlsPsk psk, short[] pskKeyExchangeModes, TlsSecret earlySecret)
		{
			m_index = index;
			m_psk = psk;
			m_pskKeyExchangeModes = pskKeyExchangeModes;
			m_earlySecret = earlySecret;
		}
	}

	private readonly IList m_identities;

	private readonly IList m_binders;

	private readonly int m_bindersSize;

	public IList Binders => m_binders;

	public int BindersSize => m_bindersSize;

	public IList Identities => m_identities;

	public OfferedPsks(IList identities)
		: this(identities, null, -1)
	{
	}

	private OfferedPsks(IList identities, IList binders, int bindersSize)
	{
		if (identities == null || identities.Count < 1)
		{
			throw new ArgumentException("cannot be null or empty", "identities");
		}
		if (binders != null && identities.Count != binders.Count)
		{
			throw new ArgumentException("must be the same length as 'identities' (or null)", "binders");
		}
		if (binders != null != bindersSize >= 0)
		{
			throw new ArgumentException("must be >= 0 iff 'binders' are present", "bindersSize");
		}
		m_identities = identities;
		m_binders = binders;
		m_bindersSize = bindersSize;
	}

	public int GetIndexOfIdentity(PskIdentity pskIdentity)
	{
		int i = 0;
		for (int count = m_identities.Count; i < count; i++)
		{
			if (pskIdentity.Equals(m_identities[i]))
			{
				return i;
			}
		}
		return -1;
	}

	public void Encode(Stream output)
	{
		int lengthOfIdentitiesList = 0;
		foreach (PskIdentity identity in m_identities)
		{
			lengthOfIdentitiesList += identity.GetEncodedLength();
		}
		TlsUtilities.CheckUint16(lengthOfIdentitiesList);
		TlsUtilities.WriteUint16(lengthOfIdentitiesList, output);
		foreach (PskIdentity identity2 in m_identities)
		{
			identity2.Encode(output);
		}
		if (m_binders == null)
		{
			return;
		}
		int lengthOfBindersList = 0;
		foreach (byte[] binder in m_binders)
		{
			lengthOfBindersList += 1 + binder.Length;
		}
		TlsUtilities.CheckUint16(lengthOfBindersList);
		TlsUtilities.WriteUint16(lengthOfBindersList, output);
		foreach (byte[] binder2 in m_binders)
		{
			TlsUtilities.WriteOpaque8(binder2, output);
		}
	}

	internal static void EncodeBinders(Stream output, TlsCrypto crypto, TlsHandshakeHash handshakeHash, BindersConfig bindersConfig)
	{
		TlsPsk[] psks = bindersConfig.m_psks;
		TlsSecret[] earlySecrets = bindersConfig.m_earlySecrets;
		int expectedLengthOfBindersList = bindersConfig.m_bindersSize - 2;
		TlsUtilities.CheckUint16(expectedLengthOfBindersList);
		TlsUtilities.WriteUint16(expectedLengthOfBindersList, output);
		int lengthOfBindersList = 0;
		for (int i = 0; i < psks.Length; i++)
		{
			TlsPsk obj = psks[i];
			TlsSecret earlySecret = earlySecrets[i];
			bool isExternalPsk = true;
			int pskCryptoHashAlgorithm = TlsCryptoUtilities.GetHashForPrf(obj.PrfAlgorithm);
			TlsHash hash = crypto.CreateHash(pskCryptoHashAlgorithm);
			handshakeHash.CopyBufferTo(new TlsHashSink(hash));
			byte[] transcriptHash = hash.CalculateHash();
			byte[] binder = TlsUtilities.CalculatePskBinder(crypto, isExternalPsk, pskCryptoHashAlgorithm, earlySecret, transcriptHash);
			lengthOfBindersList += 1 + binder.Length;
			TlsUtilities.WriteOpaque8(binder, output);
		}
		if (expectedLengthOfBindersList != lengthOfBindersList)
		{
			throw new TlsFatalAlert(80);
		}
	}

	internal static int GetBindersSize(TlsPsk[] psks)
	{
		int lengthOfBindersList = 0;
		for (int i = 0; i < psks.Length; i++)
		{
			int prfCryptoHashAlgorithm = TlsCryptoUtilities.GetHashForPrf(psks[i].PrfAlgorithm);
			lengthOfBindersList += 1 + TlsCryptoUtilities.GetHashOutputSize(prfCryptoHashAlgorithm);
		}
		TlsUtilities.CheckUint16(lengthOfBindersList);
		return 2 + lengthOfBindersList;
	}

	public static OfferedPsks Parse(Stream input)
	{
		IList identities = Platform.CreateArrayList();
		int num = TlsUtilities.ReadUint16(input);
		if (num < 7)
		{
			throw new TlsFatalAlert(50);
		}
		MemoryStream buf = new MemoryStream(TlsUtilities.ReadFully(num, input), writable: false);
		do
		{
			PskIdentity identity = PskIdentity.Parse(buf);
			identities.Add(identity);
		}
		while (buf.Position < buf.Length);
		IList binders = Platform.CreateArrayList();
		int totalLengthBinders = TlsUtilities.ReadUint16(input);
		if (totalLengthBinders < 33)
		{
			throw new TlsFatalAlert(50);
		}
		MemoryStream buf2 = new MemoryStream(TlsUtilities.ReadFully(totalLengthBinders, input), writable: false);
		do
		{
			byte[] binder = TlsUtilities.ReadOpaque8(buf2, 32);
			binders.Add(binder);
		}
		while (buf2.Position < buf2.Length);
		return new OfferedPsks(identities, binders, 2 + totalLengthBinders);
	}
}
