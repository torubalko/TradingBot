using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls;

public sealed class ServerNameList
{
	private readonly IList m_serverNameList;

	public IList ServerNames => m_serverNameList;

	public ServerNameList(IList serverNameList)
	{
		if (serverNameList == null)
		{
			throw new ArgumentNullException("serverNameList");
		}
		m_serverNameList = serverNameList;
	}

	public void Encode(Stream output)
	{
		MemoryStream buf = new MemoryStream();
		short[] nameTypesSeen = TlsUtilities.EmptyShorts;
		foreach (ServerName entry in ServerNames)
		{
			nameTypesSeen = CheckNameType(nameTypesSeen, entry.NameType);
			if (nameTypesSeen == null)
			{
				throw new TlsFatalAlert(80);
			}
			entry.Encode(buf);
		}
		int i = (int)buf.Length;
		TlsUtilities.CheckUint16(i);
		TlsUtilities.WriteUint16(i, output);
		Streams.WriteBufTo(buf, output);
	}

	public static ServerNameList Parse(Stream input)
	{
		MemoryStream buf = new MemoryStream(TlsUtilities.ReadOpaque16(input, 1), writable: false);
		short[] nameTypesSeen = TlsUtilities.EmptyShorts;
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

	private static short[] CheckNameType(short[] nameTypesSeen, short nameType)
	{
		if (Arrays.Contains(nameTypesSeen, nameType))
		{
			return null;
		}
		return Arrays.Append(nameTypesSeen, nameType);
	}
}
