using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Net;

namespace Org.BouncyCastle.Asn1.X509;

public class GeneralName : Asn1Encodable, IAsn1Choice
{
	public const int OtherName = 0;

	public const int Rfc822Name = 1;

	public const int DnsName = 2;

	public const int X400Address = 3;

	public const int DirectoryName = 4;

	public const int EdiPartyName = 5;

	public const int UniformResourceIdentifier = 6;

	public const int IPAddress = 7;

	public const int RegisteredID = 8;

	internal readonly Asn1Encodable obj;

	internal readonly int tag;

	public int TagNo => tag;

	public Asn1Encodable Name => obj;

	public GeneralName(X509Name directoryName)
	{
		obj = directoryName;
		tag = 4;
	}

	public GeneralName(Asn1Object name, int tag)
	{
		obj = name;
		this.tag = tag;
	}

	public GeneralName(int tag, Asn1Encodable name)
	{
		obj = name;
		this.tag = tag;
	}

	public GeneralName(int tag, string name)
	{
		this.tag = tag;
		switch (tag)
		{
		case 1:
		case 2:
		case 6:
			obj = new DerIA5String(name);
			break;
		case 8:
			obj = new DerObjectIdentifier(name);
			break;
		case 4:
			obj = new X509Name(name);
			break;
		case 7:
		{
			byte[] enc = toGeneralNameEncoding(name);
			if (enc == null)
			{
				throw new ArgumentException("IP Address is invalid", "name");
			}
			obj = new DerOctetString(enc);
			break;
		}
		default:
			throw new ArgumentException("can't process string for tag: " + tag, "tag");
		}
	}

	public static GeneralName GetInstance(object obj)
	{
		if (obj == null || obj is GeneralName)
		{
			return (GeneralName)obj;
		}
		if (obj is Asn1TaggedObject)
		{
			Asn1TaggedObject tagObj = (Asn1TaggedObject)obj;
			int tag = tagObj.TagNo;
			switch (tag)
			{
			case 0:
			case 3:
			case 5:
				return new GeneralName(tag, Asn1Sequence.GetInstance(tagObj, explicitly: false));
			case 1:
			case 2:
			case 6:
				return new GeneralName(tag, DerIA5String.GetInstance(tagObj, isExplicit: false));
			case 4:
				return new GeneralName(tag, X509Name.GetInstance(tagObj, explicitly: true));
			case 7:
				return new GeneralName(tag, Asn1OctetString.GetInstance(tagObj, isExplicit: false));
			case 8:
				return new GeneralName(tag, DerObjectIdentifier.GetInstance(tagObj, explicitly: false));
			default:
				throw new ArgumentException("unknown tag: " + tag);
			}
		}
		if (obj is byte[])
		{
			try
			{
				return GetInstance(Asn1Object.FromByteArray((byte[])obj));
			}
			catch (IOException)
			{
				throw new ArgumentException("unable to parse encoded general name");
			}
		}
		throw new ArgumentException("unknown object in GetInstance: " + Platform.GetTypeName(obj), "obj");
	}

	public static GeneralName GetInstance(Asn1TaggedObject tagObj, bool explicitly)
	{
		return GetInstance(Asn1TaggedObject.GetInstance(tagObj, explicitly: true));
	}

	public override string ToString()
	{
		StringBuilder buf = new StringBuilder();
		buf.Append(tag);
		buf.Append(": ");
		switch (tag)
		{
		case 1:
		case 2:
		case 6:
			buf.Append(DerIA5String.GetInstance(obj).GetString());
			break;
		case 4:
			buf.Append(X509Name.GetInstance(obj).ToString());
			break;
		default:
			buf.Append(obj.ToString());
			break;
		}
		return buf.ToString();
	}

	private byte[] toGeneralNameEncoding(string ip)
	{
		if (Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv6WithNetmask(ip) || Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv6(ip))
		{
			int slashIndex = ip.IndexOf('/');
			if (slashIndex < 0)
			{
				byte[] addr = new byte[16];
				int[] parsedIp = parseIPv6(ip);
				copyInts(parsedIp, addr, 0);
				return addr;
			}
			byte[] addr2 = new byte[32];
			int[] parsedIp2 = parseIPv6(ip.Substring(0, slashIndex));
			copyInts(parsedIp2, addr2, 0);
			string mask = ip.Substring(slashIndex + 1);
			parsedIp2 = ((mask.IndexOf(':') <= 0) ? parseMask(mask) : parseIPv6(mask));
			copyInts(parsedIp2, addr2, 16);
			return addr2;
		}
		if (Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv4WithNetmask(ip) || Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv4(ip))
		{
			int slashIndex2 = ip.IndexOf('/');
			if (slashIndex2 < 0)
			{
				byte[] addr3 = new byte[4];
				parseIPv4(ip, addr3, 0);
				return addr3;
			}
			byte[] addr4 = new byte[8];
			parseIPv4(ip.Substring(0, slashIndex2), addr4, 0);
			string mask2 = ip.Substring(slashIndex2 + 1);
			if (mask2.IndexOf('.') > 0)
			{
				parseIPv4(mask2, addr4, 4);
			}
			else
			{
				parseIPv4Mask(mask2, addr4, 4);
			}
			return addr4;
		}
		return null;
	}

	private void parseIPv4Mask(string mask, byte[] addr, int offset)
	{
		int maskVal = int.Parse(mask);
		for (int i = 0; i != maskVal; i++)
		{
			addr[i / 8 + offset] |= (byte)(1 << i % 8);
		}
	}

	private void parseIPv4(string ip, byte[] addr, int offset)
	{
		string[] array = ip.Split('.', '/');
		foreach (string token in array)
		{
			addr[offset++] = (byte)int.Parse(token);
		}
	}

	private int[] parseMask(string mask)
	{
		int[] res = new int[8];
		int maskVal = int.Parse(mask);
		for (int i = 0; i != maskVal; i++)
		{
			res[i / 16] |= 1 << i % 16;
		}
		return res;
	}

	private void copyInts(int[] parsedIp, byte[] addr, int offSet)
	{
		for (int i = 0; i != parsedIp.Length; i++)
		{
			addr[i * 2 + offSet] = (byte)(parsedIp[i] >> 8);
			addr[i * 2 + 1 + offSet] = (byte)parsedIp[i];
		}
	}

	private int[] parseIPv6(string ip)
	{
		if (Platform.StartsWith(ip, "::"))
		{
			ip = ip.Substring(1);
		}
		else if (Platform.EndsWith(ip, "::"))
		{
			ip = ip.Substring(0, ip.Length - 1);
		}
		IEnumerator sEnum = ip.Split(':').GetEnumerator();
		int index = 0;
		int[] val = new int[8];
		int doubleColon = -1;
		while (sEnum.MoveNext())
		{
			string e = (string)sEnum.Current;
			if (e.Length == 0)
			{
				doubleColon = index;
				val[index++] = 0;
				continue;
			}
			if (e.IndexOf('.') < 0)
			{
				val[index++] = int.Parse(e, NumberStyles.AllowHexSpecifier);
				continue;
			}
			string[] tokens = e.Split('.');
			val[index++] = (int.Parse(tokens[0]) << 8) | int.Parse(tokens[1]);
			val[index++] = (int.Parse(tokens[2]) << 8) | int.Parse(tokens[3]);
		}
		if (index != val.Length)
		{
			Array.Copy(val, doubleColon, val, val.Length - (index - doubleColon), index - doubleColon);
			for (int i = doubleColon; i != val.Length - (index - doubleColon); i++)
			{
				val[i] = 0;
			}
		}
		return val;
	}

	public override Asn1Object ToAsn1Object()
	{
		return new DerTaggedObject(tag == 4, tag, obj);
	}
}
