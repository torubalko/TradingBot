using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Asn1;

internal class ConstructedOctetStream : BaseInputStream
{
	private readonly Asn1StreamParser _parser;

	private bool _first = true;

	private Stream _currentStream;

	internal ConstructedOctetStream(Asn1StreamParser parser)
	{
		_parser = parser;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (_currentStream == null)
		{
			if (!_first)
			{
				return 0;
			}
			Asn1OctetStringParser next = GetNextParser();
			if (next == null)
			{
				return 0;
			}
			_first = false;
			_currentStream = next.GetOctetStream();
		}
		int totalRead = 0;
		while (true)
		{
			int numRead = _currentStream.Read(buffer, offset + totalRead, count - totalRead);
			if (numRead > 0)
			{
				totalRead += numRead;
				if (totalRead == count)
				{
					return totalRead;
				}
				continue;
			}
			Asn1OctetStringParser next2 = GetNextParser();
			if (next2 == null)
			{
				break;
			}
			_currentStream = next2.GetOctetStream();
		}
		_currentStream = null;
		return totalRead;
	}

	public override int ReadByte()
	{
		if (_currentStream == null)
		{
			if (!_first)
			{
				return 0;
			}
			Asn1OctetStringParser next = GetNextParser();
			if (next == null)
			{
				return 0;
			}
			_first = false;
			_currentStream = next.GetOctetStream();
		}
		while (true)
		{
			int b = _currentStream.ReadByte();
			if (b >= 0)
			{
				return b;
			}
			Asn1OctetStringParser next2 = GetNextParser();
			if (next2 == null)
			{
				break;
			}
			_currentStream = next2.GetOctetStream();
		}
		_currentStream = null;
		return -1;
	}

	private Asn1OctetStringParser GetNextParser()
	{
		IAsn1Convertible asn1Obj = _parser.ReadObject();
		if (asn1Obj == null)
		{
			return null;
		}
		if (asn1Obj is Asn1OctetStringParser)
		{
			return (Asn1OctetStringParser)asn1Obj;
		}
		throw new IOException("unknown object encountered: " + Platform.GetTypeName(asn1Obj));
	}
}
