using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DBnSBuk72GkpbxLXiEP;
using ECOEgqlSad8NUJZ2Dr9n;
using k7lvGwG7nsmvY8cRB5pp;
using k88Q51iwn84dxUE4tGQC;
using lD5TUC1oYhVR4AjY0ZM;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Tc;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;

namespace xMytj7Sc6fOwB2cfgU8;

internal class uKHRY8SXIy6et5Q7Ras : Kb4Jsjiw9kA3pBXEIXBC
{
	[Serializable]
	[CompilerGenerated]
	private sealed class vDTDNMnkYxbcf2ctN3n3
	{
		public static readonly vDTDNMnkYxbcf2ctN3n3 VOdnkvvtGQe;

		public static Action rM2nkB7NrU1;

		internal static vDTDNMnkYxbcf2ctN3n3 NiaZ8yNfgVON2nJ5poaG;

		static vDTDNMnkYxbcf2ctN3n3()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			VOdnkvvtGQe = new vDTDNMnkYxbcf2ctN3n3();
		}

		public vDTDNMnkYxbcf2ctN3n3()
		{
			OqasTINfMF9WrdQpjaWt();
			base._002Ector();
		}

		internal void PaqnkoaKXyh()
		{
			MXK7ZO1Y0M3if7KwDfj.FnF1D2pOqC((aI4kSFkwtQiWxIKtw47)7);
		}

		internal static bool Wv50gLNfRjbP1LRRgWSY()
		{
			return NiaZ8yNfgVON2nJ5poaG == null;
		}

		internal static vDTDNMnkYxbcf2ctN3n3 mM5pGANf613b6HhpCdVC()
		{
			return NiaZ8yNfgVON2nJ5poaG;
		}

		internal static void OqasTINfMF9WrdQpjaWt()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}
	}

	private AdVNpgG79ErxvcbgBD1J VaMSRRKHRT;

	[CompilerGenerated]
	private readonly ICommand dywS6d3xJ3;

	internal static uKHRY8SXIy6et5Q7Ras wWYNxU40BtIKAAgMBM2l;

	public ICommand ConnectCommand
	{
		[CompilerGenerated]
		get
		{
			return dywS6d3xJ3;
		}
	}

	public uKHRY8SXIy6et5Q7Ras()
	{
		TIiuBq40ldtL37xB37cB();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				base.CanClose = true;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
				{
					num = 0;
				}
				break;
			default:
				AIfiwgWdPwq(delegate
				{
					MXK7ZO1Y0M3if7KwDfj.FnF1D2pOqC((aI4kSFkwtQiWxIKtw47)7);
				});
				dywS6d3xJ3 = new RelayCommand(SEuSjZn0hC);
				return;
			}
		}
	}

	public override void pfwlfRMSBV3(object P_0 = null)
	{
		int num = 1;
		int num2 = num;
		AdVNpgG79ErxvcbgBD1J adVNpgG79ErxvcbgBD1J = default(AdVNpgG79ErxvcbgBD1J);
		while (true)
		{
			switch (num2)
			{
			case 1:
				adVNpgG79ErxvcbgBD1J = P_0 as AdVNpgG79ErxvcbgBD1J;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (adVNpgG79ErxvcbgBD1J != null)
				{
					VaMSRRKHRT = adVNpgG79ErxvcbgBD1J;
				}
				return;
			}
		}
	}

	private void SEuSjZn0hC(object P_0)
	{
		WgGQJO404318taPawG6W(this, true);
		DataManager.ClientConnect(VaMSRRKHRT.mWXlYwTb86e.ConnectionID);
		DataManager.OnConnected += pCJSQ2CQfZ;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		DataManager.OnError += gSRSEfxS3l;
	}

	private void gSRSEfxS3l(ConnectionInfo P_0, string P_1)
	{
		if (P_0.IsConnected)
		{
			u1JSdCUHiR();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
		base.IsBusy = false;
	}

	private void pCJSQ2CQfZ(ConnectionInfo P_0)
	{
		u1JSdCUHiR();
		base.IsBusy = false;
	}

	private void u1JSdCUHiR()
	{
		jV5lf6tiiHF();
		MXK7ZO1Y0M3if7KwDfj.FnF1D2pOqC((aI4kSFkwtQiWxIKtw47)16, VaMSRRKHRT);
	}

	public override void jV5lf6tiiHF()
	{
		DataManager.OnConnected -= pCJSQ2CQfZ;
		DataManager.OnError -= gSRSEfxS3l;
		base.jV5lf6tiiHF();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static uKHRY8SXIy6et5Q7Ras()
	{
		YSNUZS40DU3p5sEZZ8dr();
	}

	internal static void TIiuBq40ldtL37xB37cB()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool P0VYoW40aNiXbO5mVUYX()
	{
		return wWYNxU40BtIKAAgMBM2l == null;
	}

	internal static uKHRY8SXIy6et5Q7Ras EK0HhN40ih2nKDpjkjEM()
	{
		return wWYNxU40BtIKAAgMBM2l;
	}

	internal static void WgGQJO404318taPawG6W(object P_0, bool P_1)
	{
		((Kb4Jsjiw9kA3pBXEIXBC)P_0).IsBusy = P_1;
	}

	internal static void YSNUZS40DU3p5sEZZ8dr()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
