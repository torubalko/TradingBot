using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.UI.Common.Converters;
using TuAMtrl1Nd3XoZQQUXf0;

namespace sgw74pH5ppMfOgsdR2Ke;

public class cMNw0MH53TaTHBVWwyNj : MultiBinding
{
	private static readonly BaselineMarginConverter qW0HS0K3Z8K;

	private Thickness Ai6HS2POwU1;

	internal static cMNw0MH53TaTHBVWwyNj ax71P6DenCVxA76b0oEd;

	public Thickness BaseMargin
	{
		get
		{
			return Ai6HS2POwU1;
		}
		set
		{
			Ai6HS2POwU1 = thickness;
			base.ConverterParameter = thickness;
		}
	}

	public cMNw0MH53TaTHBVWwyNj()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		Collection<BindingBase> bindings = base.Bindings;
		Binding binding = new Binding();
		yyGaBqDevxZFdarKCqni(binding, new PropertyPath((string)ojfuHqDeoySV55UHim2k(-1962651919 ^ -1962648293)));
		binding.RelativeSource = new RelativeSource(RelativeSourceMode.Self);
		bindings.Add(binding);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				base.Bindings.Add(new Binding
				{
					Path = new PropertyPath((string)ojfuHqDeoySV55UHim2k(0x6D18F862 ^ 0x6D19DBBA)),
					RelativeSource = new RelativeSource(RelativeSourceMode.Self)
				});
				base.Converter = qW0HS0K3Z8K;
				return;
			}
			base.Bindings.Add(new Binding
			{
				RelativeSource = new RelativeSource(RelativeSourceMode.Self)
			});
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
			{
				num = 1;
			}
		}
	}

	static cMNw0MH53TaTHBVWwyNj()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		qW0HS0K3Z8K = new BaselineMarginConverter();
	}

	internal static bool syrr0pDeG6O6S38tOZlf()
	{
		return ax71P6DenCVxA76b0oEd == null;
	}

	internal static cMNw0MH53TaTHBVWwyNj V1ei4cDeYRng5RtMpMNb()
	{
		return ax71P6DenCVxA76b0oEd;
	}

	internal static object ojfuHqDeoySV55UHim2k(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void yyGaBqDevxZFdarKCqni(object P_0, object P_1)
	{
		((Binding)P_0).Path = (PropertyPath)P_1;
	}
}
