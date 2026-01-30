using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.History;
using x97CE55GhEYKgt7TSVZT;

namespace VDwVG4GPe3HG2fpIs6rk;

internal sealed class VTBmk0GPLt0h4qPv1gQF : IDataReader<Bar>
{
	private readonly List<Bar> ctUGPcC0nNc;

	private int dJvGPju29oP;

	[CompilerGenerated]
	private readonly bool qoXGPE7TRi9;

	[CompilerGenerated]
	private Bar xGEGPQZxPGT;

	[CompilerGenerated]
	private Bar EWTGPdnVXvt;

	internal static VTBmk0GPLt0h4qPv1gQF WOL3rO5w2HREKlmqlnJx;

	public bool IsEmpty
	{
		[CompilerGenerated]
		get
		{
			return qoXGPE7TRi9;
		}
	}

	public Bar LastItem
	{
		[CompilerGenerated]
		get
		{
			return xGEGPQZxPGT;
		}
		[CompilerGenerated]
		private set
		{
			xGEGPQZxPGT = bar;
		}
	}

	public Bar PrevItem
	{
		[CompilerGenerated]
		get
		{
			return EWTGPdnVXvt;
		}
		[CompilerGenerated]
		private set
		{
			EWTGPdnVXvt = eWTGPdnVXvt;
		}
	}

	public VTBmk0GPLt0h4qPv1gQF(List<Bar> P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		dJvGPju29oP = -1;
		base._002Ector();
		ctUGPcC0nNc = P_0;
		qoXGPE7TRi9 = P_0 == null || P_0.Count == 0;
	}

	public bool Read()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return true;
			case 2:
				PrevItem = null;
				return false;
			default:
				return false;
			case 1:
				if (!IsEmpty)
				{
					dJvGPju29oP++;
					if (dJvGPju29oP >= ctUGPcC0nNc.Count)
					{
						LastItem = null;
						num2 = 2;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 == 0)
						{
							num2 = 2;
						}
						break;
					}
					PrevItem = LastItem;
					LastItem = ctUGPcC0nNc[dJvGPju29oP];
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e == 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 == 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	public void Reset()
	{
		dJvGPju29oP = -1;
	}

	public void Dispose()
	{
		ctUGPcC0nNc.Clear();
	}

	static VTBmk0GPLt0h4qPv1gQF()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		ABAoI75w9tXlRjR4RJKQ();
	}

	internal static bool cNqtTG5wHnPvFHK0OKIC()
	{
		return WOL3rO5w2HREKlmqlnJx == null;
	}

	internal static VTBmk0GPLt0h4qPv1gQF HCns9s5wfRpUkZ1VN5Ej()
	{
		return WOL3rO5w2HREKlmqlnJx;
	}

	internal static void ABAoI75w9tXlRjR4RJKQ()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
