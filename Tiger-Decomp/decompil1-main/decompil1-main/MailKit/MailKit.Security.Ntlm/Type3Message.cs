using System;
using System.Text;

namespace MailKit.Security.Ntlm;

internal class Type3Message : MessageBase
{
	private readonly Type2Message type2;

	private readonly byte[] challenge;

	public NtlmAuthLevel Level { get; set; }

	public string Domain { get; set; }

	public string Workstation { get; set; }

	public string Password { get; set; }

	public string Username { get; set; }

	public byte[] LM { get; private set; }

	public byte[] NT { get; set; }

	public Type3Message(byte[] message, int startIndex, int length)
		: base(3)
	{
		Decode(message, startIndex, length);
		type2 = null;
	}

	public Type3Message(Type2Message type2, Version osVersion, NtlmAuthLevel level, string userName, string password, string workstation)
		: base(3)
	{
		this.type2 = type2;
		challenge = type2.Nonce;
		Domain = type2.TargetName;
		base.OSVersion = osVersion;
		Username = userName;
		Password = password;
		Level = level;
		Workstation = workstation;
		base.Flags = (NtlmFlags)0;
		if (osVersion != null)
		{
			base.Flags |= NtlmFlags.NegotiateVersion;
		}
		if ((type2.Flags & NtlmFlags.NegotiateUnicode) != 0)
		{
			base.Flags |= NtlmFlags.NegotiateUnicode;
		}
		else
		{
			base.Flags |= NtlmFlags.NegotiateOem;
		}
		if ((type2.Flags & NtlmFlags.NegotiateNtlm) != 0)
		{
			base.Flags |= NtlmFlags.NegotiateNtlm;
		}
		if ((type2.Flags & NtlmFlags.NegotiateNtlm2Key) != 0)
		{
			base.Flags |= NtlmFlags.NegotiateNtlm2Key;
		}
		if ((type2.Flags & NtlmFlags.NegotiateTargetInfo) != 0)
		{
			base.Flags |= NtlmFlags.NegotiateTargetInfo;
		}
		if ((type2.Flags & NtlmFlags.RequestTarget) != 0)
		{
			base.Flags |= NtlmFlags.RequestTarget;
		}
	}

	~Type3Message()
	{
		if (challenge != null)
		{
			Array.Clear(challenge, 0, challenge.Length);
		}
		if (LM != null)
		{
			Array.Clear(LM, 0, LM.Length);
		}
		if (NT != null)
		{
			Array.Clear(NT, 0, NT.Length);
		}
	}

	private void Decode(byte[] message, int startIndex, int length)
	{
		ValidateArguments(message, startIndex, length);
		Password = null;
		if (message.Length >= 64)
		{
			base.Flags = (NtlmFlags)BitConverterLE.ToUInt32(message, startIndex + 60);
		}
		else
		{
			base.Flags = NtlmFlags.NegotiateUnicode | NtlmFlags.NegotiateNtlm | NtlmFlags.NegotiateAlwaysSign;
		}
		int num = BitConverterLE.ToUInt16(message, startIndex + 12);
		int num2 = BitConverterLE.ToUInt16(message, startIndex + 16);
		LM = new byte[num];
		Buffer.BlockCopy(message, startIndex + num2, LM, 0, num);
		int num3 = BitConverterLE.ToUInt16(message, startIndex + 20);
		int num4 = BitConverterLE.ToUInt16(message, startIndex + 24);
		NT = new byte[num3];
		Buffer.BlockCopy(message, startIndex + num4, NT, 0, num3);
		int len = BitConverterLE.ToUInt16(message, startIndex + 28);
		int num5 = BitConverterLE.ToUInt16(message, startIndex + 32);
		Domain = DecodeString(message, startIndex + num5, len);
		int len2 = BitConverterLE.ToUInt16(message, startIndex + 36);
		int num6 = BitConverterLE.ToUInt16(message, startIndex + 40);
		Username = DecodeString(message, startIndex + num6, len2);
		int len3 = BitConverterLE.ToUInt16(message, startIndex + 44);
		int num7 = BitConverterLE.ToUInt16(message, startIndex + 48);
		Workstation = DecodeString(message, startIndex + num7, len3);
		if ((base.Flags & NtlmFlags.NegotiateVersion) != 0 && length >= 72)
		{
			int major = message[startIndex + 64];
			int minor = message[startIndex + 65];
			int build = BitConverterLE.ToUInt16(message, startIndex + 66);
			base.OSVersion = new Version(major, minor, build);
		}
	}

	private string DecodeString(byte[] buffer, int offset, int len)
	{
		Encoding encoding = (((base.Flags & NtlmFlags.NegotiateUnicode) != 0) ? Encoding.Unicode : Encoding.UTF8);
		return encoding.GetString(buffer, offset, len);
	}

	private byte[] EncodeString(string text)
	{
		if (text == null)
		{
			return new byte[0];
		}
		Encoding encoding = (((base.Flags & NtlmFlags.NegotiateUnicode) != 0) ? Encoding.Unicode : Encoding.UTF8);
		return encoding.GetBytes(text);
	}

	public override byte[] Encode()
	{
		byte[] array = EncodeString(Domain);
		byte[] array2 = EncodeString(Username);
		byte[] array3 = EncodeString(Workstation);
		int num = 64;
		ChallengeResponse2.Compute(type2, Level, Username, Password, Domain, out var lm, out var ntlm);
		bool flag;
		if (flag = (type2.Flags & NtlmFlags.NegotiateVersion) != 0 && base.OSVersion != null)
		{
			num += 8;
		}
		int num2 = ((lm != null) ? lm.Length : 0);
		int num3 = ((ntlm != null) ? ntlm.Length : 0);
		byte[] array4 = PrepareMessage(num + array.Length + array2.Length + array3.Length + num2 + num3);
		short num4 = (short)(num + array.Length + array2.Length + array3.Length);
		array4[12] = (byte)num2;
		array4[13] = 0;
		array4[14] = array4[12];
		array4[15] = array4[13];
		array4[16] = (byte)num4;
		array4[17] = (byte)(num4 >> 8);
		short num5 = (short)(num4 + num2);
		array4[20] = (byte)num3;
		array4[21] = (byte)(num3 >> 8);
		array4[22] = array4[20];
		array4[23] = array4[21];
		array4[24] = (byte)num5;
		array4[25] = (byte)(num5 >> 8);
		short num6 = (short)array.Length;
		short num7 = (short)num;
		array4[28] = (byte)num6;
		array4[29] = (byte)(num6 >> 8);
		array4[30] = array4[28];
		array4[31] = array4[29];
		array4[32] = (byte)num7;
		array4[33] = (byte)(num7 >> 8);
		short num8 = (short)array2.Length;
		short num9 = (short)(num7 + num6);
		array4[36] = (byte)num8;
		array4[37] = (byte)(num8 >> 8);
		array4[38] = array4[36];
		array4[39] = array4[37];
		array4[40] = (byte)num9;
		array4[41] = (byte)(num9 >> 8);
		short num10 = (short)array3.Length;
		short num11 = (short)(num9 + num8);
		array4[44] = (byte)num10;
		array4[45] = (byte)(num10 >> 8);
		array4[46] = array4[44];
		array4[47] = array4[45];
		array4[48] = (byte)num11;
		array4[49] = (byte)(num11 >> 8);
		short num12 = (short)array4.Length;
		array4[56] = (byte)num12;
		array4[57] = (byte)(num12 >> 8);
		array4[60] = (byte)base.Flags;
		array4[61] = (byte)((uint)base.Flags >> 8);
		array4[62] = (byte)((uint)base.Flags >> 16);
		array4[63] = (byte)((uint)base.Flags >> 24);
		if (flag)
		{
			array4[64] = (byte)base.OSVersion.Major;
			array4[65] = (byte)base.OSVersion.Minor;
			array4[66] = (byte)base.OSVersion.Build;
			array4[67] = (byte)(base.OSVersion.Build >> 8);
			array4[68] = 0;
			array4[69] = 0;
			array4[70] = 0;
			array4[71] = 15;
		}
		Buffer.BlockCopy(array, 0, array4, num7, array.Length);
		Buffer.BlockCopy(array2, 0, array4, num9, array2.Length);
		Buffer.BlockCopy(array3, 0, array4, num11, array3.Length);
		if (lm != null)
		{
			Buffer.BlockCopy(lm, 0, array4, num4, lm.Length);
			Array.Clear(lm, 0, lm.Length);
		}
		if (ntlm != null)
		{
			Buffer.BlockCopy(ntlm, 0, array4, num5, ntlm.Length);
			Array.Clear(ntlm, 0, ntlm.Length);
		}
		return array4;
	}
}
