using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Threading;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Internal;

internal class VAy
{
	private class H7B : BTZ, IKeyedObject
	{
		private VAy PSy;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int FSq;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string uS2;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DateTime eS7;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action hSi;

		internal static H7B K3G;

		public bool IsEnabled => PSy != null && dSI() > 0;

		public string Key
		{
			[CompilerGenerated]
			get
			{
				return uS2;
			}
			[CompilerGenerated]
			private set
			{
				uS2 = text;
			}
		}

		public H7B(VAy P_0, string P_1, Action P_2)
		{
			grA.DaB7cz();
			base._002Ector();
			if (P_0 == null)
			{
				throw new ArgumentNullException(Q7Z.tqM(192868));
			}
			if (P_2 == null)
			{
				throw new ArgumentNullException(Q7Z.tqM(219642));
			}
			PSy = P_0;
			Key = P_1;
			nSS(P_2);
		}

		public void Destroy()
		{
			if (PSy != null)
			{
				PSy.BTZ(this);
				PSy = null;
				nSS(null);
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public int dSI()
		{
			return FSq;
		}

		[SpecialName]
		[CompilerGenerated]
		public void hS5(int P_0)
		{
			FSq = P_0;
		}

		public void Start(int P_0)
		{
			if (PSy != null)
			{
				PSy.fTd(this, P_0);
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public DateTime VSV()
		{
			return eS7;
		}

		[SpecialName]
		[CompilerGenerated]
		public void zSr(DateTime P_0)
		{
			eS7 = P_0;
		}

		public void Stop()
		{
			if (PSy != null)
			{
				PSy.bTz(this);
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public Action NSk()
		{
			return hSi;
		}

		[SpecialName]
		[CompilerGenerated]
		private void nSS(Action P_0)
		{
			hSi = P_0;
		}

		internal static bool x3N()
		{
			return K3G == null;
		}

		internal static H7B s3H()
		{
			return K3G;
		}
	}

	private DispatcherTimer aLP;

	private bool wLE;

	private object WLc;

	private List<H7B> LLa;

	private static VAy KWi;

	public VAy()
	{
		grA.DaB7cz();
		WLc = new object();
		LLa = new List<H7B>();
		base._002Ector();
		JTt();
	}

	private void JTt()
	{
		aLP = new DispatcherTimer();
		aLP.Tick += hTh;
	}

	private void BTZ(H7B P_0)
	{
		bTz(P_0);
		lock (WLc)
		{
			int num = LLa.IndexOf(P_0);
			if (num != -1)
			{
				LLa.RemoveAt(num);
			}
		}
	}

	private void hTh(object P_0, object P_1)
	{
		xTN();
	}

	private void xTN()
	{
		if (wLE)
		{
			return;
		}
		try
		{
			wLE = true;
			int num = int.MaxValue;
			lock (WLc)
			{
				for (int num2 = LLa.Count - 1; num2 >= 0; num2--)
				{
					if (num2 < LLa.Count)
					{
						H7B h7B = LLa[num2];
						if (h7B.IsEnabled)
						{
							int num3 = (int)DateTime.Now.Subtract(h7B.VSV()).TotalMilliseconds;
							if (num3 >= h7B.dSI())
							{
								h7B.hS5(0);
								h7B.NSk()();
							}
							if (h7B.IsEnabled)
							{
								num3 = (int)DateTime.Now.Subtract(h7B.VSV()).TotalMilliseconds;
								int val = Math.Max(50, h7B.dSI() - num3);
								num = Math.Min(num, val);
							}
						}
					}
				}
			}
			if (num > 0 && num != int.MaxValue)
			{
				aLP.Interval = TimeSpan.FromMilliseconds(num);
				if (!aLP.IsEnabled)
				{
					aLP.Start();
				}
			}
			else if (aLP.IsEnabled)
			{
				aLP.Stop();
			}
		}
		finally
		{
			wLE = false;
		}
	}

	private void fTd(H7B P_0, int P_1)
	{
		bTz(P_0);
		P_0.hS5(Math.Min(32767, P_1));
		P_0.zSr(DateTime.Now);
		xTN();
	}

	private void bTz(H7B P_0)
	{
		if (P_0.IsEnabled)
		{
			P_0.hS5(0);
			xTN();
		}
	}

	public BTZ PLW(string P_0, Action P_1)
	{
		H7B h7B = new H7B(this, P_0, P_1);
		lock (WLc)
		{
			LLa.Add(h7B);
		}
		return h7B;
	}

	internal static bool eW2()
	{
		return KWi == null;
	}

	internal static VAy KWV()
	{
		return KWi;
	}
}
