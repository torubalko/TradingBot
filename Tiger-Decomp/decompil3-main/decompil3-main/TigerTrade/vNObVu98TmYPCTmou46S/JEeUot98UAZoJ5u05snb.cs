using System.Collections.Generic;
using System.Diagnostics;
using ECOEgqlSad8NUJZ2Dr9n;
using ESfWR89rpJGqlpJwL5ej;
using RReHnj98tFXb2WU84IRi;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.History;
using TuAMtrl1Nd3XoZQQUXf0;

namespace vNObVu98TmYPCTmou46S;

internal sealed class JEeUot98UAZoJ5u05snb
{
	private readonly U2sMUm9r39JSXDgxgx8p JQn98CMEFho;

	private readonly Dictionary<string, i0u3GU98WvLrPO2Y47fC> sjH98r9orks;

	private readonly Dictionary<string, i0u3GU98WvLrPO2Y47fC> mLY98KQX6iU;

	private static JEeUot98UAZoJ5u05snb Fht9fNbr53Uah0Tfm1E0;

	public JEeUot98UAZoJ5u05snb(U2sMUm9r39JSXDgxgx8p P_0)
	{
		Qh4Lt1brLYb4vgoJ75a7();
		sjH98r9orks = new Dictionary<string, i0u3GU98WvLrPO2Y47fC>();
		mLY98KQX6iU = new Dictionary<string, i0u3GU98WvLrPO2Y47fC>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				JQn98CMEFho = P_0;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void LJZ98yIJOjk(string P_0, i0u3GU98WvLrPO2Y47fC P_1)
	{
		if (sjH98r9orks.ContainsKey(P_0))
		{
			return;
		}
		sjH98r9orks.Add(P_0, P_1);
		if (mLY98KQX6iU.ContainsKey(P_0))
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
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
			mLY98KQX6iU.Add(P_0, P_1);
		}
	}

	public bool XNT98ZG767r(string P_0, List<IDataReader<Tick>> P_1)
	{
		if (!sjH98r9orks.ContainsKey(P_0))
		{
			return false;
		}
		Stopwatch stopwatch = Stopwatch.StartNew();
		sjH98r9orks[P_0].FnNln1FUM5Q(P_0, P_1);
		sjH98r9orks.Remove(P_0);
		stopwatch.Stop();
		return true;
	}

	public bool QDo98Vmy3h8(string P_0, IDataReader<Tick> P_1)
	{
		if (P_1.IsEmpty || !mLY98KQX6iU.ContainsKey(P_0))
		{
			return false;
		}
		Stopwatch stopwatch = Stopwatch.StartNew();
		mLY98KQX6iU[P_0].yyvln51SWGe(P_0, P_1);
		mLY98KQX6iU.Remove(P_0);
		stopwatch.Stop();
		return true;
	}

	static JEeUot98UAZoJ5u05snb()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void Qh4Lt1brLYb4vgoJ75a7()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool oi7OiDbrSivvDELqR3Lj()
	{
		return Fht9fNbr53Uah0Tfm1E0 == null;
	}

	internal static JEeUot98UAZoJ5u05snb FyYXcsbrxhlK2KXhXo2U()
	{
		return Fht9fNbr53Uah0Tfm1E0;
	}
}
