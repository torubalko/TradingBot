using System;

namespace Org.BouncyCastle.Crypto.Tls;

internal class DtlsReplayWindow
{
	private const long VALID_SEQ_MASK = 281474976710655L;

	private const long WINDOW_SIZE = 64L;

	private long mLatestConfirmedSeq = -1L;

	private long mBitmap;

	internal bool ShouldDiscard(long seq)
	{
		if ((seq & 0xFFFFFFFFFFFFL) != seq)
		{
			return true;
		}
		if (seq <= mLatestConfirmedSeq)
		{
			long diff = mLatestConfirmedSeq - seq;
			if (diff >= 64)
			{
				return true;
			}
			if ((mBitmap & (1L << (int)diff)) != 0L)
			{
				return true;
			}
		}
		return false;
	}

	internal void ReportAuthenticated(long seq)
	{
		if ((seq & 0xFFFFFFFFFFFFL) != seq)
		{
			throw new ArgumentException("out of range", "seq");
		}
		if (seq <= mLatestConfirmedSeq)
		{
			long diff = mLatestConfirmedSeq - seq;
			if (diff < 64)
			{
				mBitmap |= 1L << (int)diff;
			}
			return;
		}
		long diff2 = seq - mLatestConfirmedSeq;
		if (diff2 >= 64)
		{
			mBitmap = 1L;
		}
		else
		{
			mBitmap <<= (int)diff2;
			mBitmap |= 1L;
		}
		mLatestConfirmedSeq = seq;
	}

	internal void Reset()
	{
		mLatestConfirmedSeq = -1L;
		mBitmap = 0L;
	}
}
