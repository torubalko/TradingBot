using System;
using System.Collections;
using System.IO;

namespace Org.BouncyCastle.Crypto.Tls;

public abstract class TlsSRTPUtils
{
	public static void AddUseSrtpExtension(IDictionary extensions, UseSrtpData useSRTPData)
	{
		extensions[14] = CreateUseSrtpExtension(useSRTPData);
	}

	public static UseSrtpData GetUseSrtpExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 14);
		if (extensionData != null)
		{
			return ReadUseSrtpExtension(extensionData);
		}
		return null;
	}

	public static byte[] CreateUseSrtpExtension(UseSrtpData useSrtpData)
	{
		if (useSrtpData == null)
		{
			throw new ArgumentNullException("useSrtpData");
		}
		MemoryStream buf = new MemoryStream();
		TlsUtilities.WriteUint16ArrayWithUint16Length(useSrtpData.ProtectionProfiles, buf);
		TlsUtilities.WriteOpaque8(useSrtpData.Mki, buf);
		return buf.ToArray();
	}

	public static UseSrtpData ReadUseSrtpExtension(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		MemoryStream buf = new MemoryStream(extensionData, writable: true);
		int length = TlsUtilities.ReadUint16(buf);
		if (length < 2 || (length & 1) != 0)
		{
			throw new TlsFatalAlert(50);
		}
		int[] protectionProfiles = TlsUtilities.ReadUint16Array(length / 2, buf);
		byte[] mki = TlsUtilities.ReadOpaque8(buf);
		TlsProtocol.AssertEmpty(buf);
		return new UseSrtpData(protectionProfiles, mki);
	}
}
