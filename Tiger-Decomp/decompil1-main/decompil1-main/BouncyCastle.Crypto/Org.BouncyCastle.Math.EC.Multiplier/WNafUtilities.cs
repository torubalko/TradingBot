using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Multiplier;

public abstract class WNafUtilities
{
	private class ConfigureBasepointCallback : IPreCompCallback
	{
		private readonly ECCurve m_curve;

		private readonly int m_confWidth;

		internal ConfigureBasepointCallback(ECCurve curve, int confWidth)
		{
			m_curve = curve;
			m_confWidth = confWidth;
		}

		public PreCompInfo Precompute(PreCompInfo existing)
		{
			WNafPreCompInfo existingWNaf = existing as WNafPreCompInfo;
			if (existingWNaf != null && existingWNaf.ConfWidth == m_confWidth)
			{
				existingWNaf.PromotionCountdown = 0;
				return existingWNaf;
			}
			WNafPreCompInfo result = new WNafPreCompInfo();
			result.PromotionCountdown = 0;
			result.ConfWidth = m_confWidth;
			if (existingWNaf != null)
			{
				result.PreComp = existingWNaf.PreComp;
				result.PreCompNeg = existingWNaf.PreCompNeg;
				result.Twice = existingWNaf.Twice;
				result.Width = existingWNaf.Width;
			}
			return result;
		}
	}

	private class MapPointCallback : IPreCompCallback
	{
		private readonly WNafPreCompInfo m_infoP;

		private readonly bool m_includeNegated;

		private readonly ECPointMap m_pointMap;

		internal MapPointCallback(WNafPreCompInfo infoP, bool includeNegated, ECPointMap pointMap)
		{
			m_infoP = infoP;
			m_includeNegated = includeNegated;
			m_pointMap = pointMap;
		}

		public PreCompInfo Precompute(PreCompInfo existing)
		{
			WNafPreCompInfo result = new WNafPreCompInfo();
			result.ConfWidth = m_infoP.ConfWidth;
			ECPoint twiceP = m_infoP.Twice;
			if (twiceP != null)
			{
				ECPoint twiceQ = m_pointMap.Map(twiceP);
				result.Twice = twiceQ;
			}
			ECPoint[] preCompP = m_infoP.PreComp;
			ECPoint[] preCompQ = new ECPoint[preCompP.Length];
			for (int i = 0; i < preCompP.Length; i++)
			{
				preCompQ[i] = m_pointMap.Map(preCompP[i]);
			}
			result.PreComp = preCompQ;
			result.Width = m_infoP.Width;
			if (m_includeNegated)
			{
				ECPoint[] preCompNegQ = new ECPoint[preCompQ.Length];
				for (int j = 0; j < preCompNegQ.Length; j++)
				{
					preCompNegQ[j] = preCompQ[j].Negate();
				}
				result.PreCompNeg = preCompNegQ;
			}
			return result;
		}
	}

	private class PrecomputeCallback : IPreCompCallback
	{
		private readonly ECPoint m_p;

		private readonly int m_minWidth;

		private readonly bool m_includeNegated;

		internal PrecomputeCallback(ECPoint p, int minWidth, bool includeNegated)
		{
			m_p = p;
			m_minWidth = minWidth;
			m_includeNegated = includeNegated;
		}

		public PreCompInfo Precompute(PreCompInfo existing)
		{
			WNafPreCompInfo existingWNaf = existing as WNafPreCompInfo;
			int width = System.Math.Max(2, System.Math.Min(MAX_WIDTH, m_minWidth));
			int reqPreCompLen = 1 << width - 2;
			if (CheckExisting(existingWNaf, width, reqPreCompLen, m_includeNegated))
			{
				existingWNaf.DecrementPromotionCountdown();
				return existingWNaf;
			}
			WNafPreCompInfo result = new WNafPreCompInfo();
			ECCurve c = m_p.Curve;
			ECPoint[] preComp = null;
			ECPoint[] preCompNeg = null;
			ECPoint twiceP = null;
			if (existingWNaf != null)
			{
				int promotionCountdown = existingWNaf.DecrementPromotionCountdown();
				result.PromotionCountdown = promotionCountdown;
				int confWidth = existingWNaf.ConfWidth;
				result.ConfWidth = confWidth;
				preComp = existingWNaf.PreComp;
				preCompNeg = existingWNaf.PreCompNeg;
				twiceP = existingWNaf.Twice;
			}
			width = System.Math.Min(MAX_WIDTH, System.Math.Max(result.ConfWidth, width));
			reqPreCompLen = 1 << width - 2;
			int iniPreCompLen = 0;
			if (preComp == null)
			{
				preComp = EMPTY_POINTS;
			}
			else
			{
				iniPreCompLen = preComp.Length;
			}
			if (iniPreCompLen < reqPreCompLen)
			{
				preComp = ResizeTable(preComp, reqPreCompLen);
				if (reqPreCompLen == 1)
				{
					preComp[0] = m_p.Normalize();
				}
				else
				{
					int curPreCompLen = iniPreCompLen;
					if (curPreCompLen == 0)
					{
						preComp[0] = m_p;
						curPreCompLen = 1;
					}
					ECFieldElement iso = null;
					if (reqPreCompLen == 2)
					{
						preComp[1] = m_p.ThreeTimes();
					}
					else
					{
						ECPoint isoTwiceP = twiceP;
						ECPoint last = preComp[curPreCompLen - 1];
						if (isoTwiceP == null)
						{
							isoTwiceP = preComp[0].Twice();
							twiceP = isoTwiceP;
							if (!twiceP.IsInfinity && ECAlgorithms.IsFpCurve(c) && c.FieldSize >= 64)
							{
								int coordinateSystem = c.CoordinateSystem;
								if ((uint)(coordinateSystem - 2) <= 2u)
								{
									iso = twiceP.GetZCoord(0);
									isoTwiceP = c.CreatePoint(twiceP.XCoord.ToBigInteger(), twiceP.YCoord.ToBigInteger());
									ECFieldElement iso2 = iso.Square();
									ECFieldElement iso3 = iso2.Multiply(iso);
									last = last.ScaleX(iso2).ScaleY(iso3);
									if (iniPreCompLen == 0)
									{
										preComp[0] = last;
									}
								}
							}
						}
						while (curPreCompLen < reqPreCompLen)
						{
							last = (preComp[curPreCompLen++] = last.Add(isoTwiceP));
						}
					}
					c.NormalizeAll(preComp, iniPreCompLen, reqPreCompLen - iniPreCompLen, iso);
				}
			}
			if (m_includeNegated)
			{
				int pos;
				if (preCompNeg == null)
				{
					pos = 0;
					preCompNeg = new ECPoint[reqPreCompLen];
				}
				else
				{
					pos = preCompNeg.Length;
					if (pos < reqPreCompLen)
					{
						preCompNeg = ResizeTable(preCompNeg, reqPreCompLen);
					}
				}
				for (; pos < reqPreCompLen; pos++)
				{
					preCompNeg[pos] = preComp[pos].Negate();
				}
			}
			result.PreComp = preComp;
			result.PreCompNeg = preCompNeg;
			result.Twice = twiceP;
			result.Width = width;
			return result;
		}

		private bool CheckExisting(WNafPreCompInfo existingWNaf, int width, int reqPreCompLen, bool includeNegated)
		{
			if (existingWNaf != null && existingWNaf.Width >= System.Math.Max(existingWNaf.ConfWidth, width) && CheckTable(existingWNaf.PreComp, reqPreCompLen))
			{
				if (includeNegated)
				{
					return CheckTable(existingWNaf.PreCompNeg, reqPreCompLen);
				}
				return true;
			}
			return false;
		}

		private bool CheckTable(ECPoint[] table, int reqLen)
		{
			if (table != null)
			{
				return table.Length >= reqLen;
			}
			return false;
		}
	}

	private class PrecomputeWithPointMapCallback : IPreCompCallback
	{
		private readonly ECPoint m_point;

		private readonly ECPointMap m_pointMap;

		private readonly WNafPreCompInfo m_fromWNaf;

		private readonly bool m_includeNegated;

		internal PrecomputeWithPointMapCallback(ECPoint point, ECPointMap pointMap, WNafPreCompInfo fromWNaf, bool includeNegated)
		{
			m_point = point;
			m_pointMap = pointMap;
			m_fromWNaf = fromWNaf;
			m_includeNegated = includeNegated;
		}

		public PreCompInfo Precompute(PreCompInfo existing)
		{
			WNafPreCompInfo existingWNaf = existing as WNafPreCompInfo;
			int width = m_fromWNaf.Width;
			int reqPreCompLen = m_fromWNaf.PreComp.Length;
			if (CheckExisting(existingWNaf, width, reqPreCompLen, m_includeNegated))
			{
				existingWNaf.DecrementPromotionCountdown();
				return existingWNaf;
			}
			WNafPreCompInfo result = new WNafPreCompInfo();
			result.PromotionCountdown = m_fromWNaf.PromotionCountdown;
			ECPoint twiceFrom = m_fromWNaf.Twice;
			if (twiceFrom != null)
			{
				ECPoint twice = m_pointMap.Map(twiceFrom);
				result.Twice = twice;
			}
			ECPoint[] preCompFrom = m_fromWNaf.PreComp;
			ECPoint[] preComp = new ECPoint[preCompFrom.Length];
			for (int i = 0; i < preCompFrom.Length; i++)
			{
				preComp[i] = m_pointMap.Map(preCompFrom[i]);
			}
			result.PreComp = preComp;
			result.Width = width;
			if (m_includeNegated)
			{
				ECPoint[] preCompNeg = new ECPoint[preComp.Length];
				for (int j = 0; j < preCompNeg.Length; j++)
				{
					preCompNeg[j] = preComp[j].Negate();
				}
				result.PreCompNeg = preCompNeg;
			}
			return result;
		}

		private bool CheckExisting(WNafPreCompInfo existingWNaf, int width, int reqPreCompLen, bool includeNegated)
		{
			if (existingWNaf != null && existingWNaf.Width >= width && CheckTable(existingWNaf.PreComp, reqPreCompLen))
			{
				if (includeNegated)
				{
					return CheckTable(existingWNaf.PreCompNeg, reqPreCompLen);
				}
				return true;
			}
			return false;
		}

		private bool CheckTable(ECPoint[] table, int reqLen)
		{
			if (table != null)
			{
				return table.Length >= reqLen;
			}
			return false;
		}
	}

	public static readonly string PRECOMP_NAME = "bc_wnaf";

	private static readonly int[] DEFAULT_WINDOW_SIZE_CUTOFFS = new int[6] { 13, 41, 121, 337, 897, 2305 };

	private static readonly int MAX_WIDTH = 16;

	private static readonly ECPoint[] EMPTY_POINTS = new ECPoint[0];

	public static void ConfigureBasepoint(ECPoint p)
	{
		ECCurve c = p.Curve;
		if (c != null)
		{
			int bits = c.Order?.BitLength ?? (c.FieldSize + 1);
			int confWidth = System.Math.Min(MAX_WIDTH, GetWindowSize(bits) + 3);
			c.Precompute(p, PRECOMP_NAME, new ConfigureBasepointCallback(c, confWidth));
		}
	}

	public static int[] GenerateCompactNaf(BigInteger k)
	{
		if (k.BitLength >> 16 != 0)
		{
			throw new ArgumentException("must have bitlength < 2^16", "k");
		}
		if (k.SignValue == 0)
		{
			return Arrays.EmptyInts;
		}
		BigInteger bigInteger = k.ShiftLeft(1).Add(k);
		int bits = bigInteger.BitLength;
		int[] naf = new int[bits >> 1];
		BigInteger diff = bigInteger.Xor(k);
		int highBit = bits - 1;
		int length = 0;
		int zeroes = 0;
		for (int i = 1; i < highBit; i++)
		{
			if (!diff.TestBit(i))
			{
				zeroes++;
				continue;
			}
			int digit = ((!k.TestBit(i)) ? 1 : (-1));
			naf[length++] = (digit << 16) | zeroes;
			zeroes = 1;
			i++;
		}
		naf[length++] = 0x10000 | zeroes;
		if (naf.Length > length)
		{
			naf = Trim(naf, length);
		}
		return naf;
	}

	public static int[] GenerateCompactWindowNaf(int width, BigInteger k)
	{
		switch (width)
		{
		case 2:
			return GenerateCompactNaf(k);
		default:
			throw new ArgumentException("must be in the range [2, 16]", "width");
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 10:
		case 11:
		case 12:
		case 13:
		case 14:
		case 15:
		case 16:
		{
			if (k.BitLength >> 16 != 0)
			{
				throw new ArgumentException("must have bitlength < 2^16", "k");
			}
			if (k.SignValue == 0)
			{
				return Arrays.EmptyInts;
			}
			int[] wnaf = new int[k.BitLength / width + 1];
			int pow2 = 1 << width;
			int mask = pow2 - 1;
			int sign = pow2 >> 1;
			bool carry = false;
			int length = 0;
			int pos = 0;
			while (pos <= k.BitLength)
			{
				if (k.TestBit(pos) == carry)
				{
					pos++;
					continue;
				}
				k = k.ShiftRight(pos);
				int digit = k.IntValue & mask;
				if (carry)
				{
					digit++;
				}
				carry = (digit & sign) != 0;
				if (carry)
				{
					digit -= pow2;
				}
				int zeroes = ((length > 0) ? (pos - 1) : pos);
				wnaf[length++] = (digit << 16) | zeroes;
				pos = width;
			}
			if (wnaf.Length > length)
			{
				wnaf = Trim(wnaf, length);
			}
			return wnaf;
		}
		}
	}

	public static byte[] GenerateJsf(BigInteger g, BigInteger h)
	{
		byte[] jsf = new byte[System.Math.Max(g.BitLength, h.BitLength) + 1];
		BigInteger k0 = g;
		BigInteger k1 = h;
		int j = 0;
		int d0 = 0;
		int d1 = 0;
		int offset = 0;
		while ((d0 | d1) != 0 || k0.BitLength > offset || k1.BitLength > offset)
		{
			int n0 = ((k0.IntValue >>> offset) + d0) & 7;
			int n1 = ((k1.IntValue >>> offset) + d1) & 7;
			int u0 = n0 & 1;
			if (u0 != 0)
			{
				u0 -= n0 & 2;
				if (n0 + u0 == 4 && (n1 & 3) == 2)
				{
					u0 = -u0;
				}
			}
			int u1 = n1 & 1;
			if (u1 != 0)
			{
				u1 -= n1 & 2;
				if (n1 + u1 == 4 && (n0 & 3) == 2)
				{
					u1 = -u1;
				}
			}
			if (d0 << 1 == 1 + u0)
			{
				d0 ^= 1;
			}
			if (d1 << 1 == 1 + u1)
			{
				d1 ^= 1;
			}
			if (++offset == 30)
			{
				offset = 0;
				k0 = k0.ShiftRight(30);
				k1 = k1.ShiftRight(30);
			}
			jsf[j++] = (byte)((u0 << 4) | (u1 & 0xF));
		}
		if (jsf.Length > j)
		{
			jsf = Trim(jsf, j);
		}
		return jsf;
	}

	public static byte[] GenerateNaf(BigInteger k)
	{
		if (k.SignValue == 0)
		{
			return Arrays.EmptyBytes;
		}
		BigInteger bigInteger = k.ShiftLeft(1).Add(k);
		int digits = bigInteger.BitLength - 1;
		byte[] naf = new byte[digits];
		BigInteger diff = bigInteger.Xor(k);
		for (int i = 1; i < digits; i++)
		{
			if (diff.TestBit(i))
			{
				naf[i - 1] = (byte)((!k.TestBit(i)) ? 1u : uint.MaxValue);
				i++;
			}
		}
		naf[digits - 1] = 1;
		return naf;
	}

	public static byte[] GenerateWindowNaf(int width, BigInteger k)
	{
		switch (width)
		{
		case 2:
			return GenerateNaf(k);
		default:
			throw new ArgumentException("must be in the range [2, 8]", "width");
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		{
			if (k.SignValue == 0)
			{
				return Arrays.EmptyBytes;
			}
			byte[] wnaf = new byte[k.BitLength + 1];
			int pow2 = 1 << width;
			int mask = pow2 - 1;
			int sign = pow2 >> 1;
			bool carry = false;
			int length = 0;
			int pos = 0;
			while (pos <= k.BitLength)
			{
				if (k.TestBit(pos) == carry)
				{
					pos++;
					continue;
				}
				k = k.ShiftRight(pos);
				int digit = k.IntValue & mask;
				if (carry)
				{
					digit++;
				}
				carry = (digit & sign) != 0;
				if (carry)
				{
					digit -= pow2;
				}
				length += ((length > 0) ? (pos - 1) : pos);
				wnaf[length++] = (byte)digit;
				pos = width;
			}
			if (wnaf.Length > length)
			{
				wnaf = Trim(wnaf, length);
			}
			return wnaf;
		}
		}
	}

	public static int GetNafWeight(BigInteger k)
	{
		if (k.SignValue == 0)
		{
			return 0;
		}
		return k.ShiftLeft(1).Add(k).Xor(k)
			.BitCount;
	}

	public static WNafPreCompInfo GetWNafPreCompInfo(ECPoint p)
	{
		return GetWNafPreCompInfo(p.Curve.GetPreCompInfo(p, PRECOMP_NAME));
	}

	public static WNafPreCompInfo GetWNafPreCompInfo(PreCompInfo preCompInfo)
	{
		return preCompInfo as WNafPreCompInfo;
	}

	public static int GetWindowSize(int bits)
	{
		return GetWindowSize(bits, DEFAULT_WINDOW_SIZE_CUTOFFS, MAX_WIDTH);
	}

	public static int GetWindowSize(int bits, int maxWidth)
	{
		return GetWindowSize(bits, DEFAULT_WINDOW_SIZE_CUTOFFS, maxWidth);
	}

	public static int GetWindowSize(int bits, int[] windowSizeCutoffs)
	{
		return GetWindowSize(bits, windowSizeCutoffs, MAX_WIDTH);
	}

	public static int GetWindowSize(int bits, int[] windowSizeCutoffs, int maxWidth)
	{
		int w;
		for (w = 0; w < windowSizeCutoffs.Length && bits >= windowSizeCutoffs[w]; w++)
		{
		}
		return System.Math.Max(2, System.Math.Min(maxWidth, w + 2));
	}

	[Obsolete]
	public static ECPoint MapPointWithPrecomp(ECPoint p, int minWidth, bool includeNegated, ECPointMap pointMap)
	{
		ECCurve curve = p.Curve;
		WNafPreCompInfo infoP = Precompute(p, minWidth, includeNegated);
		ECPoint q = pointMap.Map(p);
		curve.Precompute(q, PRECOMP_NAME, new MapPointCallback(infoP, includeNegated, pointMap));
		return q;
	}

	public static WNafPreCompInfo Precompute(ECPoint p, int minWidth, bool includeNegated)
	{
		return (WNafPreCompInfo)p.Curve.Precompute(p, PRECOMP_NAME, new PrecomputeCallback(p, minWidth, includeNegated));
	}

	public static WNafPreCompInfo PrecomputeWithPointMap(ECPoint p, ECPointMap pointMap, WNafPreCompInfo fromWNaf, bool includeNegated)
	{
		return (WNafPreCompInfo)p.Curve.Precompute(p, PRECOMP_NAME, new PrecomputeWithPointMapCallback(p, pointMap, fromWNaf, includeNegated));
	}

	private static byte[] Trim(byte[] a, int length)
	{
		byte[] result = new byte[length];
		Array.Copy(a, 0, result, 0, result.Length);
		return result;
	}

	private static int[] Trim(int[] a, int length)
	{
		int[] result = new int[length];
		Array.Copy(a, 0, result, 0, result.Length);
		return result;
	}

	private static ECPoint[] ResizeTable(ECPoint[] a, int length)
	{
		ECPoint[] result = new ECPoint[length];
		Array.Copy(a, 0, result, 0, a.Length);
		return result;
	}
}
