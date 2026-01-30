using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using BfZtb759KlUg4482QKym;
using cvbYuioiYy5DUwW89Uxt;
using H8QTRvGbABkuXcjGi3Wu;
using hqRKukoBvZpc4wIphZe8;
using K1GcsD5GTtMSlaiJI0Xh;
using mNNspJGxubRWBYJmp7RU;
using NpShD3GN5IUYRX7ZeG8q;
using x97CE55GhEYKgt7TSVZT;

namespace c0MHhToamHULoqAC8ldx;

public class JKiJRyoaKDmkFpOUPDi9 : PsO19ZoBo5RP3Z6m6RKY
{
	[CompilerGenerated]
	private string dqaoi08F8lt;

	[CompilerGenerated]
	private List<f8skKYoiGdAaekg4uXCB> AEUoi2JVxF1;

	[CompilerGenerated]
	private List<f8skKYoiGdAaekg4uXCB> uy2oiHli6JD;

	[CompilerGenerated]
	private string dlaoifW9jMT;

	[CompilerGenerated]
	private long tE3oi9j3LEX;

	[CompilerGenerated]
	private long FOCoin5migg;

	private static JKiJRyoaKDmkFpOUPDi9 wHZGIxSTUsf3CPpmCIFk;

	public string Symbol
	{
		[CompilerGenerated]
		get
		{
			return dqaoi08F8lt;
		}
		[CompilerGenerated]
		set
		{
			dqaoi08F8lt = text;
		}
	}

	public List<f8skKYoiGdAaekg4uXCB> Asks
	{
		[CompilerGenerated]
		get
		{
			return AEUoi2JVxF1;
		}
		[CompilerGenerated]
		set
		{
			AEUoi2JVxF1 = aEUoi2JVxF;
		}
	}

	public List<f8skKYoiGdAaekg4uXCB> Bids
	{
		[CompilerGenerated]
		get
		{
			return uy2oiHli6JD;
		}
		[CompilerGenerated]
		set
		{
			uy2oiHli6JD = list;
		}
	}

	public string EventType
	{
		[CompilerGenerated]
		get
		{
			return dlaoifW9jMT;
		}
		[CompilerGenerated]
		set
		{
			dlaoifW9jMT = text;
		}
	}

	public long FromVersion
	{
		[CompilerGenerated]
		get
		{
			return tE3oi9j3LEX;
		}
		[CompilerGenerated]
		set
		{
			tE3oi9j3LEX = num;
		}
	}

	public long ToVersion
	{
		[CompilerGenerated]
		get
		{
			return FOCoin5migg;
		}
		[CompilerGenerated]
		set
		{
			FOCoin5migg = fOCoin5migg;
		}
	}

	public JKiJRyoaKDmkFpOUPDi9()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Asks = new List<f8skKYoiGdAaekg4uXCB>();
		Bids = new List<f8skKYoiGdAaekg4uXCB>();
	}

	public override byte[] EL3lnODvZSu()
	{
		throw new NotImplementedException();
	}

	public override void wW7lnMCBwVI(byte[] P_0)
	{
		try
		{
			ym0asCGxpiu8Fl8r4Obt ym0asCGxpiu8Fl8r4Obt = ym0asCGxpiu8Fl8r4Obt.PHIGLnjLLLX.ParseFrom(P_0);
			if (S9TvGASTZnAS1TTEuqsE(ym0asCGxpiu8Fl8r4Obt) != (ym0asCGxpiu8Fl8r4Obt.T1USQjagkmGrRImRFERf)313)
			{
				return;
			}
			Ie321eGb8qNMT3T3x2vL ie321eGb8qNMT3T3x2vL = (Ie321eGb8qNMT3T3x2vL)AsmbiVSTVT0X93uqMiMZ(ym0asCGxpiu8Fl8r4Obt);
			Symbol = (string)WtdXK0STCjo4H4gTVSYn(ym0asCGxpiu8Fl8r4Obt);
			EOWkekSTr0mRV69akC6i(Asks);
			Bids.Clear();
			int num = 5;
			IEnumerator<YZfSd3GN1xjjmYMxrTVe> enumerator = default(IEnumerator<YZfSd3GN1xjjmYMxrTVe>);
			long? obj;
			while (true)
			{
				switch (num)
				{
				case 4:
					enumerator = ie321eGb8qNMT3T3x2vL.Bids.GetEnumerator();
					try
					{
						while (YtQOK4ST8T6muXbK2j3Z(enumerator))
						{
							YZfSd3GN1xjjmYMxrTVe current2 = enumerator.Current;
							List<f8skKYoiGdAaekg4uXCB> list = Bids;
							f8skKYoiGdAaekg4uXCB f8skKYoiGdAaekg4uXCB = new f8skKYoiGdAaekg4uXCB();
							bBdfa3ST79BIDnwI0Zgx(f8skKYoiGdAaekg4uXCB, v9ysxcSThWMSAAcGF83F(current2.Price, XdYqWlSTKVGjgaJStNRI()));
							f8skKYoiGdAaekg4uXCB.Quantity = decimal.Parse((string)qBMZmPSTmjFhb2FihvGq(current2), CultureInfo.InvariantCulture);
							list.Add(f8skKYoiGdAaekg4uXCB);
						}
					}
					finally
					{
						enumerator?.Dispose();
					}
					goto case 2;
				case 3:
					try
					{
						while (enumerator.MoveNext())
						{
							YZfSd3GN1xjjmYMxrTVe current = enumerator.Current;
							Asks.Add(new f8skKYoiGdAaekg4uXCB
							{
								Price = decimal.Parse(current.Price, (IFormatProvider)XdYqWlSTKVGjgaJStNRI()),
								Quantity = v9ysxcSThWMSAAcGF83F(qBMZmPSTmjFhb2FihvGq(current), CultureInfo.InvariantCulture)
							});
						}
					}
					finally
					{
						if (enumerator != null)
						{
							LTps2ESTwZRVknoAuokw(enumerator);
						}
					}
					goto case 4;
				default:
					FromVersion = xZch09STAXhZN6UmQMmE(ie321eGb8qNMT3T3x2vL.FromVersion, CultureInfo.InvariantCulture);
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
					{
						num = 1;
					}
					continue;
				case 5:
					enumerator = ie321eGb8qNMT3T3x2vL.Asks.GetEnumerator();
					num = 3;
					continue;
				case 1:
					ToVersion = xZch09STAXhZN6UmQMmE(ie321eGb8qNMT3T3x2vL.ToVersion, XdYqWlSTKVGjgaJStNRI());
					obj = (ym0asCGxpiu8Fl8r4Obt.FqwGLPLJic1 ? new long?(ym0asCGxpiu8Fl8r4Obt.SendTime) : ((long?)null));
					break;
				case 2:
					EventType = ie321eGb8qNMT3T3x2vL.EventType;
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a != 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			}
			base.SendTime = obj;
		}
		catch (Exception innerException)
		{
			throw new InvalidOperationException(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1047165041 ^ -1047200481), innerException);
		}
	}

	static JKiJRyoaKDmkFpOUPDi9()
	{
		ojiMmdSTP3MFb5fRiPyw();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool FtWUuqSTTojdlLkketax()
	{
		return wHZGIxSTUsf3CPpmCIFk == null;
	}

	internal static JKiJRyoaKDmkFpOUPDi9 ATQrf8STy9nVdkgNW5ln()
	{
		return wHZGIxSTUsf3CPpmCIFk;
	}

	internal static ym0asCGxpiu8Fl8r4Obt.T1USQjagkmGrRImRFERf S9TvGASTZnAS1TTEuqsE(object P_0)
	{
		return ((ym0asCGxpiu8Fl8r4Obt)P_0).IAHGLFy7emd;
	}

	internal static object AsmbiVSTVT0X93uqMiMZ(object P_0)
	{
		return ((ym0asCGxpiu8Fl8r4Obt)P_0).PublicAggreDepths;
	}

	internal static object WtdXK0STCjo4H4gTVSYn(object P_0)
	{
		return ((ym0asCGxpiu8Fl8r4Obt)P_0).Symbol;
	}

	internal static void EOWkekSTr0mRV69akC6i(object P_0)
	{
		((List<f8skKYoiGdAaekg4uXCB>)P_0).Clear();
	}

	internal static object XdYqWlSTKVGjgaJStNRI()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static object qBMZmPSTmjFhb2FihvGq(object P_0)
	{
		return ((YZfSd3GN1xjjmYMxrTVe)P_0).Quantity;
	}

	internal static decimal v9ysxcSThWMSAAcGF83F(object P_0, object P_1)
	{
		return decimal.Parse((string)P_0, (IFormatProvider)P_1);
	}

	internal static void LTps2ESTwZRVknoAuokw(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void bBdfa3ST79BIDnwI0Zgx(object P_0, decimal P_1)
	{
		((f8skKYoiGdAaekg4uXCB)P_0).Price = P_1;
	}

	internal static bool YtQOK4ST8T6muXbK2j3Z(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static long xZch09STAXhZN6UmQMmE(object P_0, object P_1)
	{
		return long.Parse((string)P_0, (IFormatProvider)P_1);
	}

	internal static void ojiMmdSTP3MFb5fRiPyw()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
