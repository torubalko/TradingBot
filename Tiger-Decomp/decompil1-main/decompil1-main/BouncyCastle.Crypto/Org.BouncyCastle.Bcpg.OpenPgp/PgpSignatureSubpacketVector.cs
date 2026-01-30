using System;
using System.IO;
using Org.BouncyCastle.Bcpg.Sig;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public class PgpSignatureSubpacketVector
{
	private readonly SignatureSubpacket[] packets;

	[Obsolete("Use 'Count' property instead")]
	public int Size => packets.Length;

	public int Count => packets.Length;

	public static PgpSignatureSubpacketVector FromSubpackets(SignatureSubpacket[] packets)
	{
		if (packets == null)
		{
			packets = new SignatureSubpacket[0];
		}
		return new PgpSignatureSubpacketVector(packets);
	}

	internal PgpSignatureSubpacketVector(SignatureSubpacket[] packets)
	{
		this.packets = packets;
	}

	public SignatureSubpacket GetSubpacket(SignatureSubpacketTag type)
	{
		for (int i = 0; i != packets.Length; i++)
		{
			if (packets[i].SubpacketType == type)
			{
				return packets[i];
			}
		}
		return null;
	}

	public bool HasSubpacket(SignatureSubpacketTag type)
	{
		return GetSubpacket(type) != null;
	}

	public SignatureSubpacket[] GetSubpackets(SignatureSubpacketTag type)
	{
		int count = 0;
		for (int i = 0; i < packets.Length; i++)
		{
			if (packets[i].SubpacketType == type)
			{
				count++;
			}
		}
		SignatureSubpacket[] result = new SignatureSubpacket[count];
		int pos = 0;
		for (int j = 0; j < packets.Length; j++)
		{
			if (packets[j].SubpacketType == type)
			{
				result[pos++] = packets[j];
			}
		}
		return result;
	}

	public NotationData[] GetNotationDataOccurrences()
	{
		SignatureSubpacket[] notations = GetSubpackets(SignatureSubpacketTag.NotationData);
		NotationData[] vals = new NotationData[notations.Length];
		for (int i = 0; i < notations.Length; i++)
		{
			vals[i] = (NotationData)notations[i];
		}
		return vals;
	}

	[Obsolete("Use 'GetNotationDataOccurrences' instead")]
	public NotationData[] GetNotationDataOccurences()
	{
		return GetNotationDataOccurrences();
	}

	public long GetIssuerKeyId()
	{
		SignatureSubpacket p = GetSubpacket(SignatureSubpacketTag.IssuerKeyId);
		if (p != null)
		{
			return ((IssuerKeyId)p).KeyId;
		}
		return 0L;
	}

	public bool HasSignatureCreationTime()
	{
		return GetSubpacket(SignatureSubpacketTag.CreationTime) != null;
	}

	public DateTime GetSignatureCreationTime()
	{
		return ((SignatureCreationTime)(GetSubpacket(SignatureSubpacketTag.CreationTime) ?? throw new PgpException("SignatureCreationTime not available"))).GetTime();
	}

	public long GetSignatureExpirationTime()
	{
		SignatureSubpacket p = GetSubpacket(SignatureSubpacketTag.ExpireTime);
		if (p != null)
		{
			return ((SignatureExpirationTime)p).Time;
		}
		return 0L;
	}

	public long GetKeyExpirationTime()
	{
		SignatureSubpacket p = GetSubpacket(SignatureSubpacketTag.KeyExpireTime);
		if (p != null)
		{
			return ((KeyExpirationTime)p).Time;
		}
		return 0L;
	}

	public int[] GetPreferredHashAlgorithms()
	{
		SignatureSubpacket p = GetSubpacket(SignatureSubpacketTag.PreferredHashAlgorithms);
		if (p != null)
		{
			return ((PreferredAlgorithms)p).GetPreferences();
		}
		return null;
	}

	public int[] GetPreferredSymmetricAlgorithms()
	{
		SignatureSubpacket p = GetSubpacket(SignatureSubpacketTag.PreferredSymmetricAlgorithms);
		if (p != null)
		{
			return ((PreferredAlgorithms)p).GetPreferences();
		}
		return null;
	}

	public int[] GetPreferredCompressionAlgorithms()
	{
		SignatureSubpacket p = GetSubpacket(SignatureSubpacketTag.PreferredCompressionAlgorithms);
		if (p != null)
		{
			return ((PreferredAlgorithms)p).GetPreferences();
		}
		return null;
	}

	public int GetKeyFlags()
	{
		SignatureSubpacket p = GetSubpacket(SignatureSubpacketTag.KeyFlags);
		if (p != null)
		{
			return ((KeyFlags)p).Flags;
		}
		return 0;
	}

	public string GetSignerUserId()
	{
		SignatureSubpacket p = GetSubpacket(SignatureSubpacketTag.SignerUserId);
		if (p != null)
		{
			return ((SignerUserId)p).GetId();
		}
		return null;
	}

	public bool IsPrimaryUserId()
	{
		return ((PrimaryUserId)GetSubpacket(SignatureSubpacketTag.PrimaryUserId))?.IsPrimaryUserId() ?? false;
	}

	public PgpSignatureList GetEmbeddedSignatures()
	{
		SignatureSubpacket[] sigs = GetSubpackets(SignatureSubpacketTag.EmbeddedSignature);
		PgpSignature[] l = new PgpSignature[sigs.Length];
		for (int i = 0; i < sigs.Length; i++)
		{
			try
			{
				l[i] = new PgpSignature(SignaturePacket.FromByteArray(sigs[i].GetData()));
			}
			catch (IOException ex)
			{
				throw new PgpException("Unable to parse signature packet: " + ex.Message, ex);
			}
		}
		return new PgpSignatureList(l);
	}

	public SignatureSubpacketTag[] GetCriticalTags()
	{
		int count = 0;
		for (int i = 0; i != packets.Length; i++)
		{
			if (packets[i].IsCritical())
			{
				count++;
			}
		}
		SignatureSubpacketTag[] list = new SignatureSubpacketTag[count];
		count = 0;
		for (int j = 0; j != packets.Length; j++)
		{
			if (packets[j].IsCritical())
			{
				list[count++] = packets[j].SubpacketType;
			}
		}
		return list;
	}

	public Features GetFeatures()
	{
		SignatureSubpacket p = GetSubpacket(SignatureSubpacketTag.Features);
		if (p == null)
		{
			return null;
		}
		return new Features(p.IsCritical(), p.IsLongLength(), p.GetData());
	}

	internal SignatureSubpacket[] ToSubpacketArray()
	{
		return packets;
	}
}
