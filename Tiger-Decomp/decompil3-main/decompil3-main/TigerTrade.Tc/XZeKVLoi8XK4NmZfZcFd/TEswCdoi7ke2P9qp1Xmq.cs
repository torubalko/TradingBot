using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using BfZtb759KlUg4482QKym;
using hqRKukoBvZpc4wIphZe8;
using K1GcsD5GTtMSlaiJI0Xh;
using mNNspJGxubRWBYJmp7RU;
using mZRZI3Gbs2KEtKORnbYr;
using tNudDpolHtj0euTcJsqP;
using uNylOQGbvkq9FK5Qpplt;
using x97CE55GhEYKgt7TSVZT;

namespace XZeKVLoi8XK4NmZfZcFd;

public class TEswCdoi7ke2P9qp1Xmq : PsO19ZoBo5RP3Z6m6RKY
{
	[CompilerGenerated]
	private string AxpoiuZWxyB;

	[CompilerGenerated]
	private List<ecfDaDol23uUJl1nvGXX> j8doizCC6LR;

	[CompilerGenerated]
	private string JpRol0LZQdA;

	internal static TEswCdoi7ke2P9qp1Xmq DylodwSyBr4KJYm9S8oY;

	public string Symbol
	{
		[CompilerGenerated]
		get
		{
			return AxpoiuZWxyB;
		}
		[CompilerGenerated]
		set
		{
			AxpoiuZWxyB = axpoiuZWxyB;
		}
	}

	public List<ecfDaDol23uUJl1nvGXX> Deals
	{
		[CompilerGenerated]
		get
		{
			return j8doizCC6LR;
		}
		[CompilerGenerated]
		set
		{
			j8doizCC6LR = list;
		}
	}

	public string EventType
	{
		[CompilerGenerated]
		get
		{
			return JpRol0LZQdA;
		}
		[CompilerGenerated]
		set
		{
			JpRol0LZQdA = jpRol0LZQdA;
		}
	}

	public TEswCdoi7ke2P9qp1Xmq()
	{
		W7CowCSylmvxTE6TPTO4();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Deals = new List<ecfDaDol23uUJl1nvGXX>();
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
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ceb7e581f1314bbd87cbf42baae4882f == 0)
			{
				num = 0;
			}
			APsxxYGboQ9bZG7QNiTv aPsxxYGboQ9bZG7QNiTv = default(APsxxYGboQ9bZG7QNiTv);
			IEnumerator<LiJvZxGbe5HXvuwlVfuJ> enumerator = default(IEnumerator<LiJvZxGbe5HXvuwlVfuJ>);
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				default:
					if (ia4H68Sy4wsb7ilQwE0y(ym0asCGxpiu8Fl8r4Obt) != (ym0asCGxpiu8Fl8r4Obt.T1USQjagkmGrRImRFERf)314)
					{
						return;
					}
					aPsxxYGboQ9bZG7QNiTv = ym0asCGxpiu8Fl8r4Obt.PublicAggreDeals;
					Symbol = (string)vZjyQASyDDYCeRG6OwnQ(ym0asCGxpiu8Fl8r4Obt);
					Deals.Clear();
					enumerator = aPsxxYGboQ9bZG7QNiTv.Deals.GetEnumerator();
					num = 2;
					break;
				case 2:
					try
					{
						while (enumerator.MoveNext())
						{
							LiJvZxGbe5HXvuwlVfuJ current = enumerator.Current;
							Deals.Add(new ecfDaDol23uUJl1nvGXX
							{
								Price = decimal.Parse(current.Price, CultureInfo.InvariantCulture),
								Quantity = QTdWrmSybq2ZokaNYMkD(current.Quantity, CultureInfo.InvariantCulture),
								TradeType = rNCW48SyNwJ2e1WbIpOg(current),
								Time = current.Time
							});
						}
						int num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 != 0)
						{
							num2 = 0;
						}
						switch (num2)
						{
						case 0:
							break;
						}
					}
					finally
					{
						enumerator?.Dispose();
					}
					EventType = aPsxxYGboQ9bZG7QNiTv.EventType;
					num = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_df9cc36c31bd47b69eead74fc374d2af == 0)
					{
						num = 3;
					}
					break;
				case 3:
					base.SendTime = (C7BqMISykVTCOFSTdpZ9(ym0asCGxpiu8Fl8r4Obt) ? new long?(ym0asCGxpiu8Fl8r4Obt.SendTime) : ((long?)null));
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2eeb07b76a6b47ee89babb98850d4c1d != 0)
					{
						num = 1;
					}
					break;
				}
			}
		}
		catch (Exception innerException)
		{
			throw new InvalidOperationException(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0xAD5B8B3 ^ 0xAD4C383), innerException);
		}
	}

	static TEswCdoi7ke2P9qp1Xmq()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		DISWtrSy1uCeBE0JrK8J();
	}

	internal static bool QEoaJaSyaMotcVpgY7Sn()
	{
		return DylodwSyBr4KJYm9S8oY == null;
	}

	internal static TEswCdoi7ke2P9qp1Xmq IwIf1RSyib74i2VVANd3()
	{
		return DylodwSyBr4KJYm9S8oY;
	}

	internal static void W7CowCSylmvxTE6TPTO4()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static ym0asCGxpiu8Fl8r4Obt.T1USQjagkmGrRImRFERf ia4H68Sy4wsb7ilQwE0y(object P_0)
	{
		return ((ym0asCGxpiu8Fl8r4Obt)P_0).IAHGLFy7emd;
	}

	internal static object vZjyQASyDDYCeRG6OwnQ(object P_0)
	{
		return ((ym0asCGxpiu8Fl8r4Obt)P_0).Symbol;
	}

	internal static decimal QTdWrmSybq2ZokaNYMkD(object P_0, object P_1)
	{
		return decimal.Parse((string)P_0, (IFormatProvider)P_1);
	}

	internal static int rNCW48SyNwJ2e1WbIpOg(object P_0)
	{
		return ((LiJvZxGbe5HXvuwlVfuJ)P_0).TradeType;
	}

	internal static bool C7BqMISykVTCOFSTdpZ9(object P_0)
	{
		return ((ym0asCGxpiu8Fl8r4Obt)P_0).FqwGLPLJic1;
	}

	internal static void DISWtrSy1uCeBE0JrK8J()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
