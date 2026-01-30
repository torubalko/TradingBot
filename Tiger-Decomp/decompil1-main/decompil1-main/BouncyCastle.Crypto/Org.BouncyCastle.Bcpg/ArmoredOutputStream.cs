using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg;

public class ArmoredOutputStream : BaseOutputStream
{
	public static readonly string HeaderVersion = "Version";

	private static readonly byte[] encodingTable = new byte[64]
	{
		65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
		75, 76, 77, 78, 79, 80, 81, 82, 83, 84,
		85, 86, 87, 88, 89, 90, 97, 98, 99, 100,
		101, 102, 103, 104, 105, 106, 107, 108, 109, 110,
		111, 112, 113, 114, 115, 116, 117, 118, 119, 120,
		121, 122, 48, 49, 50, 51, 52, 53, 54, 55,
		56, 57, 43, 47
	};

	private readonly Stream outStream;

	private int[] buf = new int[3];

	private int bufPtr;

	private Crc24 crc = new Crc24();

	private int chunkCount;

	private int lastb;

	private bool start = true;

	private bool clearText;

	private bool newLine;

	private string type;

	private static readonly string nl = Platform.NewLine;

	private static readonly string headerStart = "-----BEGIN PGP ";

	private static readonly string headerTail = "-----";

	private static readonly string footerStart = "-----END PGP ";

	private static readonly string footerTail = "-----";

	private static readonly string Version = "BCPG C# v" + AssemblyInfo.Version;

	private readonly IDictionary headers;

	private static void Encode(Stream outStream, int[] data, int len)
	{
		byte[] bs = new byte[4];
		int d1 = data[0];
		bs[0] = encodingTable[(d1 >> 2) & 0x3F];
		switch (len)
		{
		case 1:
			bs[1] = encodingTable[(d1 << 4) & 0x3F];
			bs[2] = 61;
			bs[3] = 61;
			break;
		case 2:
		{
			int d4 = data[1];
			bs[1] = encodingTable[((d1 << 4) | (d4 >> 4)) & 0x3F];
			bs[2] = encodingTable[(d4 << 2) & 0x3F];
			bs[3] = 61;
			break;
		}
		case 3:
		{
			int d2 = data[1];
			int d3 = data[2];
			bs[1] = encodingTable[((d1 << 4) | (d2 >> 4)) & 0x3F];
			bs[2] = encodingTable[((d2 << 2) | (d3 >> 6)) & 0x3F];
			bs[3] = encodingTable[d3 & 0x3F];
			break;
		}
		}
		outStream.Write(bs, 0, bs.Length);
	}

	public ArmoredOutputStream(Stream outStream)
	{
		this.outStream = outStream;
		headers = Platform.CreateHashtable(1);
		SetHeader(HeaderVersion, Version);
	}

	public ArmoredOutputStream(Stream outStream, IDictionary headers)
		: this(outStream)
	{
		foreach (string header in headers.Keys)
		{
			IList headerList = Platform.CreateArrayList(1);
			headerList.Add(headers[header]);
			this.headers[header] = headerList;
		}
	}

	public void SetHeader(string name, string val)
	{
		if (val == null)
		{
			headers.Remove(name);
			return;
		}
		IList valueList = (IList)headers[name];
		if (valueList == null)
		{
			valueList = Platform.CreateArrayList(1);
			headers[name] = valueList;
		}
		else
		{
			valueList.Clear();
		}
		valueList.Add(val);
	}

	public void AddHeader(string name, string val)
	{
		if (val != null && name != null)
		{
			IList valueList = (IList)headers[name];
			if (valueList == null)
			{
				valueList = Platform.CreateArrayList(1);
				headers[name] = valueList;
			}
			valueList.Add(val);
		}
	}

	public void ResetHeaders()
	{
		IList versions = (IList)headers[HeaderVersion];
		headers.Clear();
		if (versions != null)
		{
			headers[HeaderVersion] = versions;
		}
	}

	public void BeginClearText(HashAlgorithmTag hashAlgorithm)
	{
		string hash = hashAlgorithm switch
		{
			HashAlgorithmTag.Sha1 => "SHA1", 
			HashAlgorithmTag.Sha256 => "SHA256", 
			HashAlgorithmTag.Sha384 => "SHA384", 
			HashAlgorithmTag.Sha512 => "SHA512", 
			HashAlgorithmTag.MD2 => "MD2", 
			HashAlgorithmTag.MD5 => "MD5", 
			HashAlgorithmTag.RipeMD160 => "RIPEMD160", 
			_ => throw new IOException("unknown hash algorithm tag in beginClearText: " + hashAlgorithm), 
		};
		DoWrite("-----BEGIN PGP SIGNED MESSAGE-----" + nl);
		DoWrite("Hash: " + hash + nl + nl);
		clearText = true;
		newLine = true;
		lastb = 0;
	}

	public void EndClearText()
	{
		clearText = false;
	}

	public override void WriteByte(byte b)
	{
		if (clearText)
		{
			outStream.WriteByte(b);
			if (newLine)
			{
				if (b != 10 || lastb != 13)
				{
					newLine = false;
				}
				if (b == 45)
				{
					outStream.WriteByte(32);
					outStream.WriteByte(45);
				}
			}
			if (b == 13 || (b == 10 && lastb != 13))
			{
				newLine = true;
			}
			lastb = b;
			return;
		}
		if (start)
		{
			switch ((PacketTag)(((b & 0x40) == 0) ? ((b & 0x3F) >> 2) : (b & 0x3F)))
			{
			case PacketTag.PublicKey:
				type = "PUBLIC KEY BLOCK";
				break;
			case PacketTag.SecretKey:
				type = "PRIVATE KEY BLOCK";
				break;
			case PacketTag.Signature:
				type = "SIGNATURE";
				break;
			default:
				type = "MESSAGE";
				break;
			}
			DoWrite(headerStart + type + headerTail + nl);
			IList versionHeaders = (IList)headers[HeaderVersion];
			if (versionHeaders != null)
			{
				WriteHeaderEntry(HeaderVersion, versionHeaders[0].ToString());
			}
			foreach (DictionaryEntry de in headers)
			{
				string k = (string)de.Key;
				if (!(k != HeaderVersion))
				{
					continue;
				}
				foreach (string v in (IList)de.Value)
				{
					WriteHeaderEntry(k, v);
				}
			}
			DoWrite(nl);
			start = false;
		}
		if (bufPtr == 3)
		{
			Encode(outStream, buf, bufPtr);
			bufPtr = 0;
			if ((++chunkCount & 0xF) == 0)
			{
				DoWrite(nl);
			}
		}
		crc.Update(b);
		buf[bufPtr++] = b & 0xFF;
	}

	public override void Close()
	{
		if (type != null)
		{
			DoClose();
			type = null;
			start = true;
			base.Close();
		}
	}

	private void DoClose()
	{
		if (bufPtr > 0)
		{
			Encode(outStream, buf, bufPtr);
		}
		DoWrite(nl + "=");
		int crcV = crc.Value;
		buf[0] = (crcV >> 16) & 0xFF;
		buf[1] = (crcV >> 8) & 0xFF;
		buf[2] = crcV & 0xFF;
		Encode(outStream, buf, 3);
		DoWrite(nl);
		DoWrite(footerStart);
		DoWrite(type);
		DoWrite(footerTail);
		DoWrite(nl);
		outStream.Flush();
	}

	private void WriteHeaderEntry(string name, string v)
	{
		DoWrite(name + ": " + v + nl);
	}

	private void DoWrite(string s)
	{
		byte[] bs = Strings.ToAsciiByteArray(s);
		outStream.Write(bs, 0, bs.Length);
	}
}
