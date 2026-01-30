using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using ECOEgqlSad8NUJZ2Dr9n;
using reuqbSHkyZtO3nPa1eKn;
using TeKe9DHvMky5awWIwL0S;
using TigerTrade.Core.UI.Commands;
using ttPdaPH4UIV7wakQ3boE;
using TuAMtrl1Nd3XoZQQUXf0;

namespace GsE4xeHvtKDIAXvk2dAJ;

internal class KOno0wHvWTyE4K6THHe8 : xRgq7gHkTVINiHGAKc0y, vGAIWNHv6VDDXsQkVUsi
{
	private readonly IInputElement xqgHvT7BEjs;

	private readonly IInputElement GPEHvyPpjJ2;

	[CompilerGenerated]
	private readonly ICommand pyRHvZuAbgF;

	private bool nTfHvVVFSDU;

	private static KOno0wHvWTyE4K6THHe8 JeJR4ADbqfIp9wFXfgRD;

	public ICommand LockCommand
	{
		[CompilerGenerated]
		get
		{
			return pyRHvZuAbgF;
		}
	}

	public bool Locked
	{
		get
		{
			return nTfHvVVFSDU;
		}
		set
		{
			if (flag != nTfHvVVFSDU)
			{
				nTfHvVVFSDU = flag;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				JZYHkZsWiJ6((string)mBHhaTDbtDcMRAexk5bE(-5977659 ^ -5906723));
			}
		}
	}

	public KOno0wHvWTyE4K6THHe8(IInputElement P_0, IInputElement P_1)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		pyRHvZuAbgF = new RelayCommand(Lock);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			xqgHvT7BEjs = P_0;
			GPEHvyPpjJ2 = P_1;
			T1PidKH4tUNimKjMkjFl.bYFH4VA7N0W(this);
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 != 0)
			{
				num = 1;
			}
		}
	}

	private void Lock(object p)
	{
		Locked = !Locked;
		if (!Locked)
		{
			T1PidKH4tUNimKjMkjFl.WrpH4hGq9Hn();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			T1PidKH4tUNimKjMkjFl.Lock();
		}
	}

	public bool RnMl9Hhj8oL(IInputElement P_0)
	{
		if (!xqgHvT7BEjs.Equals(P_0))
		{
			return GPEHvyPpjJ2.Equals(P_0);
		}
		return true;
	}

	static KOno0wHvWTyE4K6THHe8()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object mBHhaTDbtDcMRAexk5bE(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool pidkSaDbI3BEa2sLYyMy()
	{
		return JeJR4ADbqfIp9wFXfgRD == null;
	}

	internal static KOno0wHvWTyE4K6THHe8 J0op2NDbWVEP3W75tYxE()
	{
		return JeJR4ADbqfIp9wFXfgRD;
	}
}
