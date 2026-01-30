using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TU1GsM2Dm9QaIaTGcmUQ;

[Browsable(false)]
[DataContract(Name = "SettingsParam", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config")]
internal abstract class NeyDU62DKFU8Qyxyvfd6<ttQgExlaaT2ERO205EDg> : ICloneable
{
	[CompilerGenerated]
	private ttQgExlaaT2ERO205EDg G9f2D3gZoog;

	[CompilerGenerated]
	private Dictionary<string, ttQgExlaaT2ERO205EDg> kil2DpMspQd;

	private string ljU2DuFytcY;

	private bool Chx2Dzrtlhv;

	private ttQgExlaaT2ERO205EDg RQ22b0Gd5uv;

	private static object p7VgNy4tqvnkk2Ra7hf6;

	[DataMember(Name = "Value")]
	[Browsable(false)]
	public ttQgExlaaT2ERO205EDg Value
	{
		[CompilerGenerated]
		get
		{
			return G9f2D3gZoog;
		}
		[CompilerGenerated]
		set
		{
			G9f2D3gZoog = value;
		}
	}

	[Browsable(false)]
	[DataMember(Name = "Values")]
	public Dictionary<string, ttQgExlaaT2ERO205EDg> Values
	{
		[CompilerGenerated]
		get
		{
			return kil2DpMspQd;
		}
		[CompilerGenerated]
		set
		{
			kil2DpMspQd = dictionary;
		}
	}

	protected NeyDU62DKFU8Qyxyvfd6()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		Values = new Dictionary<string, ttQgExlaaT2ERO205EDg>();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ttQgExlaaT2ERO205EDg kOx2DhNaCjU(string P_0, ttQgExlaaT2ERO205EDg FPD69jlalOOgFMwsjiUk)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return FPD69jlalOOgFMwsjiUk;
		}
		if (Chx2Dzrtlhv && P_0 == ljU2DuFytcY)
		{
			return RQ22b0Gd5uv;
		}
		if (!Values.ContainsKey(P_0))
		{
			return FPD69jlalOOgFMwsjiUk;
		}
		ljU2DuFytcY = P_0;
		RQ22b0Gd5uv = Values[P_0];
		Chx2Dzrtlhv = true;
		Value = RQ22b0Gd5uv;
		return RQ22b0Gd5uv;
	}

	public ttQgExlaaT2ERO205EDg Jva2DwEHfew(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return Value;
		}
		if (Chx2Dzrtlhv && P_0 == ljU2DuFytcY)
		{
			return RQ22b0Gd5uv;
		}
		if (!Values.ContainsKey(P_0))
		{
			Values.Add(P_0, Value);
		}
		ljU2DuFytcY = P_0;
		RQ22b0Gd5uv = Values[P_0];
		Chx2Dzrtlhv = true;
		Value = RQ22b0Gd5uv;
		return RQ22b0Gd5uv;
	}

	protected bool OEH2D7JKopw(string P_0, ttQgExlaaT2ERO205EDg iymAfVla4yOEHLFZ2A3Z)
	{
		Chx2Dzrtlhv = false;
		if (string.IsNullOrEmpty(P_0))
		{
			if (object.Equals(iymAfVla4yOEHLFZ2A3Z, Value))
			{
				return false;
			}
			Value = iymAfVla4yOEHLFZ2A3Z;
			return true;
		}
		if (!Values.ContainsKey(P_0))
		{
			Value = iymAfVla4yOEHLFZ2A3Z;
			Values.Add(P_0, Value);
			return true;
		}
		if (object.Equals(iymAfVla4yOEHLFZ2A3Z, Values[P_0]))
		{
			Value = iymAfVla4yOEHLFZ2A3Z;
			return false;
		}
		Value = iymAfVla4yOEHLFZ2A3Z;
		Values[P_0] = iymAfVla4yOEHLFZ2A3Z;
		return true;
	}

	public void QSM2D8R8ont(NeyDU62DKFU8Qyxyvfd6<ttQgExlaaT2ERO205EDg> P_0, bool P_1 = false)
	{
		Chx2Dzrtlhv = false;
		Value = P_0.Value;
		Values.Clear();
		if (P_1)
		{
			return;
		}
		foreach (KeyValuePair<string, ttQgExlaaT2ERO205EDg> item in P_0.Values)
		{
			Values.Add(item.Key, item.Value);
		}
	}

	public void Clear()
	{
		Values.Clear();
		Value = default(ttQgExlaaT2ERO205EDg);
	}

	public abstract object Clone();

	static NeyDU62DKFU8Qyxyvfd6()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool W6BrKT4tIxWrnhAuDQCb()
	{
		return p7VgNy4tqvnkk2Ra7hf6 == null;
	}

	internal static object zNEoj14tWL5iN4TXaleS()
	{
		return p7VgNy4tqvnkk2Ra7hf6;
	}
}
