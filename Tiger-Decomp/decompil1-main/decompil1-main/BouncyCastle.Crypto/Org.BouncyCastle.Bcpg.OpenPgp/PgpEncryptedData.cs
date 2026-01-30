using System;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public abstract class PgpEncryptedData
{
	internal class TruncatedStream : BaseInputStream
	{
		private const int LookAheadSize = 22;

		private const int LookAheadBufSize = 512;

		private const int LookAheadBufLimit = 490;

		private readonly Stream inStr;

		private readonly byte[] lookAhead = new byte[512];

		private int bufStart;

		private int bufEnd;

		internal TruncatedStream(Stream inStr)
		{
			int numRead = Streams.ReadFully(inStr, lookAhead, 0, lookAhead.Length);
			if (numRead < 22)
			{
				throw new EndOfStreamException();
			}
			this.inStr = inStr;
			bufStart = 0;
			bufEnd = numRead - 22;
		}

		private int FillBuffer()
		{
			if (bufEnd < 490)
			{
				return 0;
			}
			Array.Copy(lookAhead, 490, lookAhead, 0, 22);
			bufEnd = Streams.ReadFully(inStr, lookAhead, 22, 490);
			bufStart = 0;
			return bufEnd;
		}

		public override int ReadByte()
		{
			if (bufStart < bufEnd)
			{
				return lookAhead[bufStart++];
			}
			if (FillBuffer() < 1)
			{
				return -1;
			}
			return lookAhead[bufStart++];
		}

		public override int Read(byte[] buf, int off, int len)
		{
			int avail = bufEnd - bufStart;
			int pos = off;
			while (len > avail)
			{
				Array.Copy(lookAhead, bufStart, buf, pos, avail);
				bufStart += avail;
				pos += avail;
				len -= avail;
				if ((avail = FillBuffer()) < 1)
				{
					return pos - off;
				}
			}
			Array.Copy(lookAhead, bufStart, buf, pos, len);
			bufStart += len;
			return pos + len - off;
		}

		internal byte[] GetLookAhead()
		{
			byte[] temp = new byte[22];
			Array.Copy(lookAhead, bufStart, temp, 0, 22);
			return temp;
		}
	}

	internal InputStreamPacket encData;

	internal Stream encStream;

	internal TruncatedStream truncStream;

	internal PgpEncryptedData(InputStreamPacket encData)
	{
		this.encData = encData;
	}

	public virtual Stream GetInputStream()
	{
		return encData.GetInputStream();
	}

	public bool IsIntegrityProtected()
	{
		return encData is SymmetricEncIntegrityPacket;
	}

	public bool Verify()
	{
		if (!IsIntegrityProtected())
		{
			throw new PgpException("data not integrity protected.");
		}
		DigestStream dIn = (DigestStream)encStream;
		while (encStream.ReadByte() >= 0)
		{
		}
		byte[] lookAhead = truncStream.GetLookAhead();
		IDigest digest = dIn.ReadDigest();
		digest.BlockUpdate(lookAhead, 0, 2);
		byte[] array = DigestUtilities.DoFinal(digest);
		byte[] streamDigest = new byte[array.Length];
		Array.Copy(lookAhead, 2, streamDigest, 0, streamDigest.Length);
		return Arrays.ConstantTimeAreEqual(array, streamDigest);
	}
}
