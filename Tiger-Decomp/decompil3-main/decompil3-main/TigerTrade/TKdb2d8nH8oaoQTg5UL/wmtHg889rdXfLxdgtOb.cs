using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using c6txb28tduC7kVCj1AA;
using ECOEgqlSad8NUJZ2Dr9n;
using ft4IOl2kyqsXh3EvCREm;
using PMcgNO73xwFCF4saBbt;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TKdb2d8nH8oaoQTg5UL;

[DataContract(Name = "WatchlistSettings", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Windows.Settings")]
internal sealed class wmtHg889rdXfLxdgtOb : KqZtUj2kTEAQfYBkeSKy
{
	private List<string> b7k81tjY3V;

	private List<OH1uQS7FddMfiLAwow4> YkD85M1g4K;

	[CompilerGenerated]
	private int NPZ8SnTPks;

	[CompilerGenerated]
	private OUKAUI8WpT2xw6YJ2wI tZ88xDFmoq;

	[CompilerGenerated]
	private string B7J8LOgO5U;

	private static wmtHg889rdXfLxdgtOb oZsuEU4SWoaMBMQPXZYX;

	[DataMember(Name = "SelectedSymbols")]
	public List<string> ySF8omJND7
	{
		get
		{
			return b7k81tjY3V ?? (b7k81tjY3V = new List<string>());
		}
		set
		{
			b7k81tjY3V = list;
		}
	}

	[DataMember(Name = "SelectedSymbolsSettings")]
	public List<OH1uQS7FddMfiLAwow4> TFW8aql5aq
	{
		get
		{
			return YkD85M1g4K ?? (YkD85M1g4K = new List<OH1uQS7FddMfiLAwow4>());
		}
		set
		{
			YkD85M1g4K = ykD85M1g4K;
		}
	}

	[DataMember(Name = "SelectedGroupId")]
	public int eUL84Si48S
	{
		[CompilerGenerated]
		get
		{
			return NPZ8SnTPks;
		}
		[CompilerGenerated]
		set
		{
			NPZ8SnTPks = nPZ8SnTPks;
		}
	}

	[DataMember(Name = "Filter")]
	public OUKAUI8WpT2xw6YJ2wI Filter
	{
		[CompilerGenerated]
		get
		{
			return tZ88xDFmoq;
		}
		[CompilerGenerated]
		set
		{
			tZ88xDFmoq = oUKAUI8WpT2xw6YJ2wI;
		}
	}

	[DataMember(Name = "SymbolFilter")]
	public string SymbolFilter
	{
		[CompilerGenerated]
		get
		{
			return B7J8LOgO5U;
		}
		[CompilerGenerated]
		set
		{
			B7J8LOgO5U = b7J8LOgO5U;
		}
	}

	public override string DefaultTitle => (string)ga6l574STPawB2qNqGBB();

	public wmtHg889rdXfLxdgtOb()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		base.vlP2kmioDGU = (string)HSOfeF4SyDu7XWkt5Cfu(this);
		ySF8omJND7 = new List<string>();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Filter = new OUKAUI8WpT2xw6YJ2wI();
				num = 2;
				break;
			case 2:
				SymbolFilter = string.Empty;
				return;
			case 1:
				TFW8aql5aq = new List<OH1uQS7FddMfiLAwow4>();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	static wmtHg889rdXfLxdgtOb()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool RUSPXo4St81AO7TrAnpX()
	{
		return oZsuEU4SWoaMBMQPXZYX == null;
	}

	internal static wmtHg889rdXfLxdgtOb xNpxZN4SUpHCHDEeJMp5()
	{
		return oZsuEU4SWoaMBMQPXZYX;
	}

	internal static object ga6l574STPawB2qNqGBB()
	{
		return Resources.WatchlistControlTitle;
	}

	internal static object HSOfeF4SyDu7XWkt5Cfu(object P_0)
	{
		return ((KqZtUj2kTEAQfYBkeSKy)P_0).DefaultTitle;
	}
}
