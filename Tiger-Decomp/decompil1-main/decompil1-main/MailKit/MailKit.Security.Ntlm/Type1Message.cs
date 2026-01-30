using System;
using System.Text;

namespace MailKit.Security.Ntlm;

internal class Type1Message : MessageBase
{
	internal static readonly NtlmFlags DefaultFlags = NtlmFlags.NegotiateUnicode | NtlmFlags.NegotiateOem | NtlmFlags.RequestTarget | NtlmFlags.NegotiateNtlm;

	private string workstation;

	private string domain;

	public string Domain
	{
		get
		{
			return domain;
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				base.Flags &= ~NtlmFlags.NegotiateDomainSupplied;
				value = string.Empty;
			}
			else
			{
				base.Flags |= NtlmFlags.NegotiateDomainSupplied;
			}
			domain = value;
		}
	}

	public string Workstation
	{
		get
		{
			return workstation;
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				base.Flags &= ~NtlmFlags.NegotiateWorkstationSupplied;
				value = string.Empty;
			}
			else
			{
				base.Flags |= NtlmFlags.NegotiateWorkstationSupplied;
			}
			workstation = value;
		}
	}

	public Type1Message(string workstation, string domainName, Version osVersion)
		: base(1)
	{
		base.Flags = DefaultFlags;
		Workstation = workstation;
		base.OSVersion = osVersion;
		Domain = domainName;
		if (osVersion != null)
		{
			base.Flags |= NtlmFlags.NegotiateVersion;
		}
	}

	public Type1Message(byte[] message, int startIndex, int length)
		: base(1)
	{
		Decode(message, startIndex, length);
	}

	private void Decode(byte[] message, int startIndex, int length)
	{
		ValidateArguments(message, startIndex, length);
		base.Flags = (NtlmFlags)BitConverterLE.ToUInt32(message, startIndex + 12);
		ushort count = BitConverterLE.ToUInt16(message, startIndex + 16);
		ushort num = BitConverterLE.ToUInt16(message, startIndex + 20);
		domain = Encoding.UTF8.GetString(message, startIndex + num, count);
		ushort count2 = BitConverterLE.ToUInt16(message, startIndex + 24);
		ushort num2 = BitConverterLE.ToUInt16(message, startIndex + 28);
		workstation = Encoding.UTF8.GetString(message, startIndex + num2, count2);
		if ((base.Flags & NtlmFlags.NegotiateVersion) != 0 && length >= 40)
		{
			int major = message[startIndex + 32];
			int minor = message[startIndex + 33];
			int build = BitConverterLE.ToUInt16(message, startIndex + 34);
			base.OSVersion = new Version(major, minor, build);
		}
	}

	public override byte[] Encode()
	{
		int num = 0;
		bool flag;
		if (flag = (base.Flags & NtlmFlags.NegotiateVersion) != 0)
		{
			num = 8;
		}
		int num2 = 32 + num;
		int num3 = num2 + workstation.Length;
		byte[] array = PrepareMessage(32 + domain.Length + workstation.Length + num);
		array[12] = (byte)base.Flags;
		array[13] = (byte)((uint)base.Flags >> 8);
		array[14] = (byte)((uint)base.Flags >> 16);
		array[15] = (byte)((uint)base.Flags >> 24);
		array[16] = (byte)domain.Length;
		array[17] = (byte)(domain.Length >> 8);
		array[18] = array[16];
		array[19] = array[17];
		array[20] = (byte)num3;
		array[21] = (byte)(num3 >> 8);
		array[24] = (byte)workstation.Length;
		array[25] = (byte)(workstation.Length >> 8);
		array[26] = array[24];
		array[27] = array[25];
		array[28] = (byte)num2;
		array[29] = (byte)(num2 >> 8);
		if (flag)
		{
			array[32] = (byte)base.OSVersion.Major;
			array[33] = (byte)base.OSVersion.Minor;
			array[34] = (byte)base.OSVersion.Build;
			array[35] = (byte)(base.OSVersion.Build >> 8);
			array[36] = 0;
			array[37] = 0;
			array[38] = 0;
			array[39] = 15;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(workstation.ToUpperInvariant());
		Buffer.BlockCopy(bytes, 0, array, num2, bytes.Length);
		bytes = Encoding.UTF8.GetBytes(domain.ToUpperInvariant());
		Buffer.BlockCopy(bytes, 0, array, num3, bytes.Length);
		return array;
	}
}
