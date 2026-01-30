using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using ECOEgqlSad8NUJZ2Dr9n;
using FJcaV68EJDsTYN21IEo;
using OHR1Vy8IqpXfI835Uvb;
using Ox59HVA9Q7wHSnlqfC0;
using RKuPNS8sASkv4VNJZRJ;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using u93YQA8Pnh4YbCeMAYn;

namespace c6txb28tduC7kVCj1AA;

[DataContract(Name = "WatchlistFilter", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Windows.Settings")]
internal class OUKAUI8WpT2xw6YJ2wI
{
	[Serializable]
	[CompilerGenerated]
	private sealed class qqjL3PnctOfhGTqdfuZr
	{
		public static readonly qqjL3PnctOfhGTqdfuZr EpSncTH7uyF;

		public static Func<nYyprZ8AYX9rhoDMDln, bool> hMfncyyyeib;

		private static qqjL3PnctOfhGTqdfuZr PlZK0QNaZdx3EbMxvhvY;

		static qqjL3PnctOfhGTqdfuZr()
		{
			a36H7aNarkuQfwQwdEHL();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			EpSncTH7uyF = new qqjL3PnctOfhGTqdfuZr();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public qqjL3PnctOfhGTqdfuZr()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool RmgncUOORnk(nYyprZ8AYX9rhoDMDln c)
		{
			return c.FieldToFilter != t1m2w38qWLpU04cWlNb.None;
		}

		internal static void a36H7aNarkuQfwQwdEHL()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool dfuF6PNaVhASLccmXxJ9()
		{
			return PlZK0QNaZdx3EbMxvhvY == null;
		}

		internal static qqjL3PnctOfhGTqdfuZr ko7o24NaCpN1Tjm1audR()
		{
			return PlZK0QNaZdx3EbMxvhvY;
		}
	}

	[CompilerGenerated]
	private H3kFNI8eCsVQtCAbanV Rmw877eubE;

	[CompilerGenerated]
	private List<nYyprZ8AYX9rhoDMDln> bjj88oa5Mi;

	internal static OUKAUI8WpT2xw6YJ2wI H2n1bG4SujVH3Tiqx0E6;

	[DataMember(Name = "ConditionsUnionType")]
	[DefaultValue(H3kFNI8eCsVQtCAbanV.OGv8XbLXHB)]
	public H3kFNI8eCsVQtCAbanV Nkw8ChiE49
	{
		[CompilerGenerated]
		get
		{
			return Rmw877eubE;
		}
		[CompilerGenerated]
		set
		{
			Rmw877eubE = rmw877eubE;
		}
	}

	[DataMember(Name = "FilterConditions")]
	public List<nYyprZ8AYX9rhoDMDln> cd58myCju3
	{
		[CompilerGenerated]
		get
		{
			return bjj88oa5Mi;
		}
		[CompilerGenerated]
		set
		{
			bjj88oa5Mi = list;
		}
	}

	[SpecialName]
	public bool iqN8h5MFZr()
	{
		return cd58myCju3?.FirstOrDefault((nYyprZ8AYX9rhoDMDln c) => c.FieldToFilter != t1m2w38qWLpU04cWlNb.None) != null;
	}

	public static bool jMe8UBLdmb(Security P_0)
	{
		if (P_0.Change.HasValue)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			if (UUZBYu4x28EIE5PoFB19(P_0) != 0L)
			{
				return P_0.Value != 0;
			}
		}
		return false;
	}

	public bool nVb8TfrTKA(NR8mtNAffxeTPx6Q9TH P_0)
	{
		if (!iqN8h5MFZr())
		{
			return true;
		}
		bool flag = true;
		List<nYyprZ8AYX9rhoDMDln>.Enumerator enumerator = cd58myCju3.GetEnumerator();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
		{
			num = 0;
		}
		bool result = default(bool);
		switch (num)
		{
		default:
			{
				try
				{
					double? num5 = default(double?);
					H3kFNI8eCsVQtCAbanV h3kFNI8eCsVQtCAbanV = default(H3kFNI8eCsVQtCAbanV);
					while (enumerator.MoveNext())
					{
						nYyprZ8AYX9rhoDMDln current = enumerator.Current;
						bool flag2 = Nkw8ChiE49 == H3kFNI8eCsVQtCAbanV.OGv8XbLXHB;
						int num2;
						int num7;
						switch (current.FieldToFilter)
						{
						case t1m2w38qWLpU04cWlNb.Change:
							flag = false;
							num5 = P_0.Change;
							if (num5.HasValue)
							{
								int num6 = 14;
								num2 = num6;
								goto IL_0077;
							}
							num7 = 0;
							goto IL_0346;
						default:
							goto IL_021d;
						case t1m2w38qWLpU04cWlNb.Trades:
							goto IL_0273;
						case t1m2w38qWLpU04cWlNb.Value:
							{
								flag = false;
								num2 = 7;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 != 0)
								{
									num2 = 1;
								}
								goto IL_0077;
							}
							IL_0077:
							while (true)
							{
								int num3;
								int num4;
								switch (num2)
								{
								case 8:
									break;
								case 6:
									goto IL_00c7;
								case 2:
									goto IL_0138;
								case 4:
									num3 = (mg5xm14xnctmhI1o19sq(P_0.Value, YSditD4xfgMDPOnp96X6(current), current.ThresholdValue) ? 1 : 0);
									goto IL_033e;
								case 14:
									num5 = P_0.Change;
									num2 = 6;
									continue;
								case 3:
									if (h3kFNI8eCsVQtCAbanV != H3kFNI8eCsVQtCAbanV.KNh8cU1F6i || !flag2)
									{
										goto IL_0138;
									}
									result = true;
									num2 = 8;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
									{
										num2 = 2;
									}
									continue;
								case 1:
								case 9:
									goto IL_021d;
								case 10:
									if (TmjXwp4xHRHJSgLCylEP(P_0) != 0L)
									{
										num4 = (Xtv8ycPo93(TmjXwp4xHRHJSgLCylEP(P_0), YSditD4xfgMDPOnp96X6(current), qDxKfX4x9pRioIhmTHwb(current)) ? 1 : 0);
										goto IL_0321;
									}
									num2 = 12;
									continue;
								default:
									goto IL_0273;
								case 5:
									goto IL_029f;
								case 7:
									if (P_0.Value == 0L)
									{
										num2 = 11;
										continue;
									}
									goto case 4;
								case 13:
									result = false;
									break;
								case 12:
									num4 = 0;
									goto IL_0321;
								case 11:
									{
										num3 = 0;
										goto IL_033e;
									}
									IL_0321:
									flag2 = (byte)num4 != 0;
									num2 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
									{
										num2 = 1;
									}
									continue;
									IL_033e:
									flag2 = (byte)num3 != 0;
									goto IL_021d;
								}
								break;
								IL_029f:
								if (h3kFNI8eCsVQtCAbanV == H3kFNI8eCsVQtCAbanV.OGv8XbLXHB)
								{
									if (flag2)
									{
										goto IL_0138;
									}
									num2 = 13;
								}
								else
								{
									num2 = 3;
								}
							}
							break;
							IL_0273:
							flag = false;
							num2 = 10;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 != 0)
							{
								num2 = 3;
							}
							goto IL_0077;
							IL_00c7:
							num7 = (Xtv8ycPo93(num5.Value * 100.0, current.ComparisonType, current.ThresholdValue) ? 1 : 0);
							goto IL_0346;
							IL_0346:
							flag2 = (byte)num7 != 0;
							num2 = 8;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
							{
								num2 = 9;
							}
							goto IL_0077;
							IL_021d:
							h3kFNI8eCsVQtCAbanV = Nkw8ChiE49;
							num2 = 3;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
							{
								num2 = 5;
							}
							goto IL_0077;
						}
						goto IL_004b;
						IL_0138:;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				return Nkw8ChiE49 == H3kFNI8eCsVQtCAbanV.OGv8XbLXHB || flag;
			}
			IL_004b:
			return result;
		}
	}

	private static bool Xtv8ycPo93(double P_0, jPf0Cu8jTCDXaiEoTvm P_1, double P_2)
	{
		return P_1 switch
		{
			jPf0Cu8jTCDXaiEoTvm.Snn8QhMSFc => P_0 > P_2, 
			jPf0Cu8jTCDXaiEoTvm.VjH8dHfvsb => P_0 >= P_2, 
			jPf0Cu8jTCDXaiEoTvm.mRP8gEHXML => P_0 < P_2, 
			jPf0Cu8jTCDXaiEoTvm.LDI8R9CWvO => P_0 <= P_2, 
			_ => true, 
		};
	}

	public OUKAUI8WpT2xw6YJ2wI()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		bjj88oa5Mi = new List<nYyprZ8AYX9rhoDMDln>
		{
			new nYyprZ8AYX9rhoDMDln(),
			new nYyprZ8AYX9rhoDMDln(),
			new nYyprZ8AYX9rhoDMDln(),
			new nYyprZ8AYX9rhoDMDln()
		};
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static OUKAUI8WpT2xw6YJ2wI()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool uMWOdu4Sze629HfeD2cg()
	{
		return H2n1bG4SujVH3Tiqx0E6 == null;
	}

	internal static OUKAUI8WpT2xw6YJ2wI TrBrHt4x0SRhEFt2squr()
	{
		return H2n1bG4SujVH3Tiqx0E6;
	}

	internal static long UUZBYu4x28EIE5PoFB19(object P_0)
	{
		return ((Security)P_0).Trades;
	}

	internal static long TmjXwp4xHRHJSgLCylEP(object P_0)
	{
		return ((NR8mtNAffxeTPx6Q9TH)P_0).Trades;
	}

	internal static jPf0Cu8jTCDXaiEoTvm YSditD4xfgMDPOnp96X6(object P_0)
	{
		return ((nYyprZ8AYX9rhoDMDln)P_0).ComparisonType;
	}

	internal static double qDxKfX4x9pRioIhmTHwb(object P_0)
	{
		return ((nYyprZ8AYX9rhoDMDln)P_0).ThresholdValue;
	}

	internal static bool mg5xm14xnctmhI1o19sq(double P_0, jPf0Cu8jTCDXaiEoTvm P_1, double P_2)
	{
		return Xtv8ycPo93(P_0, P_1, P_2);
	}
}
