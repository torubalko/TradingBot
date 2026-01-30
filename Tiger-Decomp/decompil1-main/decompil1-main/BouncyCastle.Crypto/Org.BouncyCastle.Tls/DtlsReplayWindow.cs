using System;

namespace Org.BouncyCastle.Tls;

internal sealed class DtlsReplayWindow
{
	private const long ValidSeqMask = 281474976710655L;

	private const long WindowSize = 64L;

	private long m_latestConfirmedSeq = -1L;

	private ulong m_bitmap;

	internal bool ShouldDiscard(long seq)
	{
		if ((seq & 0xFFFFFFFFFFFFL) != seq)
		{
			return true;
		}
		if (seq <= m_latestConfirmedSeq)
		{
			long diff = m_latestConfirmedSeq - seq;
			if (diff >= 64)
			{
				return true;
			}
			if ((m_bitmap & (ulong)(1L << (int)diff)) != 0L)
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
		if (seq <= m_latestConfirmedSeq)
		{
			long diff = m_latestConfirmedSeq - seq;
			if (diff < 64)
			{
				m_bitmap |= (ulong)(1L << (int)diff);
			}
			return;
		}
		long diff2 = seq - m_latestConfirmedSeq;
		if (diff2 >= 64)
		{
			m_bitmap = 1uL;
		}
		else
		{
			m_bitmap <<= (int)diff2;
			m_bitmap |= 1uL;
		}
		m_latestConfirmedSeq = seq;
	}

	internal void Reset(long seq)
	{
		if ((seq & 0xFFFFFFFFFFFFL) != seq)
		{
			throw new ArgumentException("out of range", "seq");
		}
		m_latestConfirmedSeq = seq;
		m_bitmap = ulong.MaxValue >> (int)System.Math.Max(0L, 63 - seq);
	}
}
