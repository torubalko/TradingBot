using System;
using System.Security.Cryptography;
using System.Text;

namespace MailKit.Security.Ntlm;

internal class Type2Message : MessageBase
{
	private byte[] targetInfo;

	private byte[] nonce;

	public byte[] Nonce
	{
		get
		{
			return (byte[])nonce.Clone();
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Length != 8)
			{
				throw new ArgumentException("Invalid Nonce Length (should be 8 bytes).", "value");
			}
			nonce = (byte[])value.Clone();
		}
	}

	public string TargetName { get; set; }

	public TargetInfo TargetInfo { get; set; }

	public byte[] EncodedTargetInfo
	{
		get
		{
			if (targetInfo != null)
			{
				return (byte[])targetInfo.Clone();
			}
			return new byte[0];
		}
	}

	public Type2Message()
		: base(2)
	{
		base.Flags = NtlmFlags.NegotiateUnicode | NtlmFlags.NegotiateNtlm;
		nonce = new byte[8];
		using RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
		randomNumberGenerator.GetBytes(nonce);
	}

	public Type2Message(Version osVersion)
		: this()
	{
		base.OSVersion = osVersion;
	}

	public Type2Message(byte[] message, int startIndex, int length)
		: base(2)
	{
		nonce = new byte[8];
		Decode(message, startIndex, length);
	}

	~Type2Message()
	{
		if (nonce != null)
		{
			Array.Clear(nonce, 0, nonce.Length);
		}
	}

	private void Decode(byte[] message, int startIndex, int length)
	{
		ValidateArguments(message, startIndex, length);
		base.Flags = (NtlmFlags)BitConverterLE.ToUInt32(message, startIndex + 20);
		Buffer.BlockCopy(message, startIndex + 24, nonce, 0, 8);
		ushort num = BitConverterLE.ToUInt16(message, startIndex + 12);
		ushort num2 = BitConverterLE.ToUInt16(message, startIndex + 16);
		if (num > 0)
		{
			Encoding encoding = (((base.Flags & NtlmFlags.NegotiateUnicode) != 0) ? Encoding.Unicode : Encoding.UTF8);
			TargetName = encoding.GetString(message, startIndex + num2, num);
		}
		if ((base.Flags & NtlmFlags.NegotiateVersion) != 0 && length >= 56)
		{
			int major = message[startIndex + 48];
			int minor = message[startIndex + 49];
			int build = BitConverterLE.ToUInt16(message, startIndex + 50);
			base.OSVersion = new Version(major, minor, build);
		}
		if (length >= 48 && num2 >= 48)
		{
			ushort num3 = BitConverterLE.ToUInt16(message, startIndex + 40);
			ushort num4 = BitConverterLE.ToUInt16(message, startIndex + 44);
			if (num3 > 0 && num4 < length && num3 <= length - num4)
			{
				TargetInfo = new TargetInfo(message, startIndex + num4, num3, (base.Flags & NtlmFlags.NegotiateOem) == 0);
				targetInfo = new byte[num3];
				Buffer.BlockCopy(message, startIndex + num4, targetInfo, 0, num3);
			}
		}
	}

	public override byte[] Encode()
	{
		int num = 40;
		int num2 = 48;
		byte[] array = null;
		int num3 = 40;
		bool flag;
		if (flag = (base.Flags & NtlmFlags.NegotiateVersion) != 0)
		{
			num += 16;
			num2 += 16;
			num3 += 16;
		}
		if (TargetName != null)
		{
			Encoding encoding = (((base.Flags & NtlmFlags.NegotiateUnicode) != 0) ? Encoding.Unicode : Encoding.UTF8);
			array = encoding.GetBytes(TargetName);
			num2 += array.Length;
			num3 += array.Length;
		}
		if (TargetInfo != null || targetInfo != null)
		{
			if (targetInfo == null)
			{
				targetInfo = TargetInfo.Encode((base.Flags & NtlmFlags.NegotiateUnicode) != 0);
			}
			num3 += targetInfo.Length + 8;
			num += 8;
		}
		byte[] array2 = PrepareMessage(num3);
		array2[16] = (byte)num3;
		array2[17] = (byte)(num3 >> 8);
		array2[20] = (byte)base.Flags;
		array2[21] = (byte)((uint)base.Flags >> 8);
		array2[22] = (byte)((uint)base.Flags >> 16);
		array2[23] = (byte)((uint)base.Flags >> 24);
		Buffer.BlockCopy(nonce, 0, array2, 24, nonce.Length);
		if (array != null)
		{
			array2[12] = (byte)array.Length;
			array2[13] = (byte)(array.Length >> 8);
			array2[14] = (byte)array.Length;
			array2[15] = (byte)(array.Length >> 8);
			array2[16] = (byte)num;
			array2[17] = (byte)(num >> 8);
			Buffer.BlockCopy(array, 0, array2, num, array.Length);
		}
		if (targetInfo != null)
		{
			array2[40] = (byte)targetInfo.Length;
			array2[41] = (byte)(targetInfo.Length >> 8);
			array2[42] = (byte)targetInfo.Length;
			array2[43] = (byte)(targetInfo.Length >> 8);
			array2[44] = (byte)num2;
			array2[45] = (byte)(num2 >> 8);
			Buffer.BlockCopy(targetInfo, 0, array2, num2, targetInfo.Length);
		}
		if (flag)
		{
			array2[48] = (byte)base.OSVersion.Major;
			array2[49] = (byte)base.OSVersion.Minor;
			array2[50] = (byte)base.OSVersion.Build;
			array2[51] = (byte)(base.OSVersion.Build >> 8);
			array2[52] = 0;
			array2[53] = 0;
			array2[54] = 0;
			array2[55] = 15;
		}
		return array2;
	}
}
