using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public sealed class ProtocolVersion
{
	public static readonly ProtocolVersion SSLv3 = new ProtocolVersion(768, "SSL 3.0");

	public static readonly ProtocolVersion TLSv10 = new ProtocolVersion(769, "TLS 1.0");

	public static readonly ProtocolVersion TLSv11 = new ProtocolVersion(770, "TLS 1.1");

	public static readonly ProtocolVersion TLSv12 = new ProtocolVersion(771, "TLS 1.2");

	public static readonly ProtocolVersion TLSv13 = new ProtocolVersion(772, "TLS 1.3");

	public static readonly ProtocolVersion DTLSv10 = new ProtocolVersion(65279, "DTLS 1.0");

	public static readonly ProtocolVersion DTLSv12 = new ProtocolVersion(65277, "DTLS 1.2");

	internal static readonly ProtocolVersion CLIENT_EARLIEST_SUPPORTED_DTLS = DTLSv10;

	internal static readonly ProtocolVersion CLIENT_EARLIEST_SUPPORTED_TLS = SSLv3;

	internal static readonly ProtocolVersion CLIENT_LATEST_SUPPORTED_DTLS = DTLSv12;

	internal static readonly ProtocolVersion CLIENT_LATEST_SUPPORTED_TLS = TLSv13;

	internal static readonly ProtocolVersion SERVER_EARLIEST_SUPPORTED_DTLS = DTLSv10;

	internal static readonly ProtocolVersion SERVER_EARLIEST_SUPPORTED_TLS = SSLv3;

	internal static readonly ProtocolVersion SERVER_LATEST_SUPPORTED_DTLS = DTLSv12;

	internal static readonly ProtocolVersion SERVER_LATEST_SUPPORTED_TLS = TLSv13;

	private readonly int version;

	private readonly string name;

	public int FullVersion => version;

	public int MajorVersion => version >> 8;

	public int MinorVersion => version & 0xFF;

	public string Name => name;

	public bool IsDtls => MajorVersion == 254;

	public bool IsSsl => this == SSLv3;

	public bool IsTls => MajorVersion == 3;

	public static bool Contains(ProtocolVersion[] versions, ProtocolVersion version)
	{
		if (versions != null && version != null)
		{
			for (int i = 0; i < versions.Length; i++)
			{
				if (version.Equals(versions[i]))
				{
					return true;
				}
			}
		}
		return false;
	}

	public static ProtocolVersion GetEarliestDtls(ProtocolVersion[] versions)
	{
		ProtocolVersion earliest = null;
		if (versions != null)
		{
			foreach (ProtocolVersion next in versions)
			{
				if (next != null && next.IsDtls && (earliest == null || next.MinorVersion > earliest.MinorVersion))
				{
					earliest = next;
				}
			}
		}
		return earliest;
	}

	public static ProtocolVersion GetEarliestTls(ProtocolVersion[] versions)
	{
		ProtocolVersion earliest = null;
		if (versions != null)
		{
			foreach (ProtocolVersion next in versions)
			{
				if (next != null && next.IsTls && (earliest == null || next.MinorVersion < earliest.MinorVersion))
				{
					earliest = next;
				}
			}
		}
		return earliest;
	}

	public static ProtocolVersion GetLatestDtls(ProtocolVersion[] versions)
	{
		ProtocolVersion latest = null;
		if (versions != null)
		{
			foreach (ProtocolVersion next in versions)
			{
				if (next != null && next.IsDtls && (latest == null || next.MinorVersion < latest.MinorVersion))
				{
					latest = next;
				}
			}
		}
		return latest;
	}

	public static ProtocolVersion GetLatestTls(ProtocolVersion[] versions)
	{
		ProtocolVersion latest = null;
		if (versions != null)
		{
			foreach (ProtocolVersion next in versions)
			{
				if (next != null && next.IsTls && (latest == null || next.MinorVersion > latest.MinorVersion))
				{
					latest = next;
				}
			}
		}
		return latest;
	}

	internal static bool IsSupportedDtlsVersionClient(ProtocolVersion version)
	{
		if (version != null && version.IsEqualOrLaterVersionOf(CLIENT_EARLIEST_SUPPORTED_DTLS))
		{
			return version.IsEqualOrEarlierVersionOf(CLIENT_LATEST_SUPPORTED_DTLS);
		}
		return false;
	}

	internal static bool IsSupportedDtlsVersionServer(ProtocolVersion version)
	{
		if (version != null && version.IsEqualOrLaterVersionOf(SERVER_EARLIEST_SUPPORTED_DTLS))
		{
			return version.IsEqualOrEarlierVersionOf(SERVER_LATEST_SUPPORTED_DTLS);
		}
		return false;
	}

	internal static bool IsSupportedTlsVersionClient(ProtocolVersion version)
	{
		if (version == null)
		{
			return false;
		}
		int fullVersion = version.FullVersion;
		if (fullVersion >= CLIENT_EARLIEST_SUPPORTED_TLS.FullVersion)
		{
			return fullVersion <= CLIENT_LATEST_SUPPORTED_TLS.FullVersion;
		}
		return false;
	}

	internal static bool IsSupportedTlsVersionServer(ProtocolVersion version)
	{
		if (version == null)
		{
			return false;
		}
		int fullVersion = version.FullVersion;
		if (fullVersion >= SERVER_EARLIEST_SUPPORTED_TLS.FullVersion)
		{
			return fullVersion <= SERVER_LATEST_SUPPORTED_TLS.FullVersion;
		}
		return false;
	}

	private ProtocolVersion(int v, string name)
	{
		version = v & 0xFFFF;
		this.name = name;
	}

	public ProtocolVersion[] DownTo(ProtocolVersion min)
	{
		if (!IsEqualOrLaterVersionOf(min))
		{
			throw new ArgumentException("must be an equal or earlier version of this one", "min");
		}
		IList result = Platform.CreateArrayList();
		result.Add(this);
		ProtocolVersion current = this;
		while (!current.Equals(min))
		{
			current = current.GetPreviousVersion();
			result.Add(current);
		}
		ProtocolVersion[] versions = new ProtocolVersion[result.Count];
		for (int i = 0; i < result.Count; i++)
		{
			versions[i] = (ProtocolVersion)result[i];
		}
		return versions;
	}

	public ProtocolVersion GetEquivalentTlsVersion()
	{
		return MajorVersion switch
		{
			3 => this, 
			254 => MinorVersion switch
			{
				255 => TLSv11, 
				253 => TLSv12, 
				_ => null, 
			}, 
			_ => null, 
		};
	}

	public ProtocolVersion GetNextVersion()
	{
		int major = MajorVersion;
		int minor = MinorVersion;
		switch (major)
		{
		case 3:
			if (minor == 255)
			{
				return null;
			}
			return Get(major, minor + 1);
		case 254:
			return minor switch
			{
				0 => null, 
				255 => DTLSv12, 
				_ => Get(major, minor - 1), 
			};
		default:
			return null;
		}
	}

	public ProtocolVersion GetPreviousVersion()
	{
		int major = MajorVersion;
		int minor = MinorVersion;
		switch (major)
		{
		case 3:
			if (minor == 0)
			{
				return null;
			}
			return Get(major, minor - 1);
		case 254:
			return minor switch
			{
				255 => null, 
				253 => DTLSv10, 
				_ => Get(major, minor + 1), 
			};
		default:
			return null;
		}
	}

	public bool IsEarlierVersionOf(ProtocolVersion version)
	{
		if (version == null || MajorVersion != version.MajorVersion)
		{
			return false;
		}
		int diffMinorVersion = MinorVersion - version.MinorVersion;
		if (!IsDtls)
		{
			return diffMinorVersion < 0;
		}
		return diffMinorVersion > 0;
	}

	public bool IsEqualOrEarlierVersionOf(ProtocolVersion version)
	{
		if (version == null || MajorVersion != version.MajorVersion)
		{
			return false;
		}
		int diffMinorVersion = MinorVersion - version.MinorVersion;
		if (!IsDtls)
		{
			return diffMinorVersion <= 0;
		}
		return diffMinorVersion >= 0;
	}

	public bool IsEqualOrLaterVersionOf(ProtocolVersion version)
	{
		if (version == null || MajorVersion != version.MajorVersion)
		{
			return false;
		}
		int diffMinorVersion = MinorVersion - version.MinorVersion;
		if (!IsDtls)
		{
			return diffMinorVersion >= 0;
		}
		return diffMinorVersion <= 0;
	}

	public bool IsLaterVersionOf(ProtocolVersion version)
	{
		if (version == null || MajorVersion != version.MajorVersion)
		{
			return false;
		}
		int diffMinorVersion = MinorVersion - version.MinorVersion;
		if (!IsDtls)
		{
			return diffMinorVersion > 0;
		}
		return diffMinorVersion < 0;
	}

	public override bool Equals(object other)
	{
		if (this != other)
		{
			if (other is ProtocolVersion)
			{
				return Equals((ProtocolVersion)other);
			}
			return false;
		}
		return true;
	}

	public bool Equals(ProtocolVersion other)
	{
		if (other != null)
		{
			return version == other.version;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return version;
	}

	public static ProtocolVersion Get(int major, int minor)
	{
		return major switch
		{
			3 => minor switch
			{
				0 => SSLv3, 
				1 => TLSv10, 
				2 => TLSv11, 
				3 => TLSv12, 
				4 => TLSv13, 
				_ => GetUnknownVersion(major, minor, "TLS"), 
			}, 
			254 => minor switch
			{
				255 => DTLSv10, 
				254 => throw new ArgumentException("{0xFE, 0xFE} is a reserved protocol version"), 
				253 => DTLSv12, 
				_ => GetUnknownVersion(major, minor, "DTLS"), 
			}, 
			_ => GetUnknownVersion(major, minor, "UNKNOWN"), 
		};
	}

	public ProtocolVersion[] Only()
	{
		return new ProtocolVersion[1] { this };
	}

	public override string ToString()
	{
		return name;
	}

	private static void CheckUint8(int versionOctet)
	{
		if (!TlsUtilities.IsValidUint8(versionOctet))
		{
			throw new ArgumentException("not a valid octet", "versionOctet");
		}
	}

	private static ProtocolVersion GetUnknownVersion(int major, int minor, string prefix)
	{
		CheckUint8(major);
		CheckUint8(minor);
		int v = (major << 8) | minor;
		string hex = Platform.ToUpperInvariant(Convert.ToString(0x10000 | v, 16).Substring(1));
		return new ProtocolVersion(v, prefix + " 0x" + hex);
	}
}
