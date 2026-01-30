using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls;

public class ServerNameList
{
	protected readonly IList mServerNameList;

	public virtual IList ServerNames => mServerNameList;

	public ServerNameList(IList serverNameList)
	{
		if (serverNameList == null)
		{
			throw new ArgumentNullException("serverNameList");
		}
		mServerNameList = serverNameList;
	}

	public virtual void Encode(Stream output)
	{
		MemoryStream buf = new MemoryStream();
		byte[] nameTypesSeen = TlsUtilities.EmptyBytes;
		foreach (ServerName entry in ServerNames)
		{
			nameTypesSeen = CheckNameType(nameTypesSeen, entry.NameType);
			if (nameTypesSeen == null)
			{
				throw new TlsFatalAlert(80);
			}
			entry.Encode(buf);
		}
		TlsUtilities.CheckUint16(buf.Length);
		TlsUtilities.WriteUint16((int)buf.Length, output);
		Streams.WriteBufTo(buf, output);
	}

	public static ServerNameList Parse(Stream input)
	{
		int num = TlsUtilities.ReadUint16(input);
		if (num < 1)
		{
			throw new TlsFatalAlert(50);
		}
		MemoryStream buf = new MemoryStream(TlsUtilities.ReadFully(num, input), writable: false);
		byte[] nameTypesSeen = TlsUtilities.EmptyBytes;
		IList server_name_list = Platform.CreateArrayList();
		while (buf.Position < buf.Length)
		{
			ServerName entry = ServerName.Parse(buf);
			nameTypesSeen = CheckNameType(nameTypesSeen, entry.NameType);
			if (nameTypesSeen == null)
			{
				throw new TlsFatalAlert(47);
			}
			server_name_list.Add(entry);
		}
		return new ServerNameList(server_name_list);
	}

	private static byte[] CheckNameType(byte[] nameTypesSeen, byte nameType)
	{
		if (!NameType.IsValid(nameType) || Arrays.Contains(nameTypesSeen, nameType))
		{
			return null;
		}
		return Arrays.Append(nameTypesSeen, nameType);
	}
}
