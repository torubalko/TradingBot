using System.Collections.Generic;
using ActiproSoftware.Windows.Controls.Editors.Primitives;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;

namespace MQCU1r2JmS7RUTRpngQN;

internal sealed class Li572t2JKH213AbsVVkS : PartEditBoxBase<string>
{
	internal static Li572t2JKH213AbsVVkS Eit6O9DYaGhUvbn1a70v;

	protected override string ConvertToString(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return null;
		}
		Symbol symbol = SymbolManager.Get(P_0);
		if (symbol == null)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => null, 
			};
		}
		return symbol.Name;
	}

	protected override IncrementalChangeRequest<string> CreateIncrementalChangeRequest(IncrementalChangeRequestKind P_0)
	{
		return new IncrementalChangeRequest<string>();
	}

	protected override IList<IPart> GenerateParts()
	{
		return new List<IPart>();
	}

	protected override bool IsValidValue(string P_0)
	{
		return true;
	}

	protected override void RaiseValueChangedEvent()
	{
	}

	protected override void ResetValue()
	{
	}

	protected override bool TryConvertFromString(string P_0, bool P_1, out string P_2)
	{
		P_2 = P_0;
		return true;
	}

	protected override void OnValueChanged(string P_0, string P_1)
	{
		base.IsPopupOpen = false;
	}

	public Li572t2JKH213AbsVVkS()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static Li572t2JKH213AbsVVkS()
	{
		kjl9tSDY4InNKjJxJYxI();
	}

	internal static bool QCQL4JDYi1crUaCF6134()
	{
		return Eit6O9DYaGhUvbn1a70v == null;
	}

	internal static Li572t2JKH213AbsVVkS m8ZcvFDYlCwTSx37DPZM()
	{
		return Eit6O9DYaGhUvbn1a70v;
	}

	internal static void kjl9tSDY4InNKjJxJYxI()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
