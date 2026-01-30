using System;

namespace MimeKit.Cryptography;

public sealed class RsaSignaturePadding : IEquatable<RsaSignaturePadding>
{
	public static readonly RsaSignaturePadding Pkcs1 = new RsaSignaturePadding(RsaSignaturePaddingScheme.Pkcs1);

	public static readonly RsaSignaturePadding Pss = new RsaSignaturePadding(RsaSignaturePaddingScheme.Pss);

	public RsaSignaturePaddingScheme Scheme { get; private set; }

	private RsaSignaturePadding(RsaSignaturePaddingScheme scheme)
	{
		Scheme = scheme;
	}

	public bool Equals(RsaSignaturePadding other)
	{
		if (other == null)
		{
			return false;
		}
		return other.Scheme == Scheme;
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as RsaSignaturePadding);
	}

	public override int GetHashCode()
	{
		return Scheme.GetHashCode();
	}

	public override string ToString()
	{
		if (Scheme != RsaSignaturePaddingScheme.Pkcs1)
		{
			return "Pss";
		}
		return "Pkcs1";
	}

	public static bool operator ==(RsaSignaturePadding left, RsaSignaturePadding right)
	{
		return left?.Equals(right) ?? ((object)right == null);
	}

	public static bool operator !=(RsaSignaturePadding left, RsaSignaturePadding right)
	{
		return !(left == right);
	}
}
