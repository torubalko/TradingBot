using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;
using Y5yGTB2uMdOTcllSMnCO;

namespace CCdXCfHSgQc7h5yAmOdL;

internal sealed class jQ2GTsHSde7tbnyxJTLc : ExpandableCollectionConverter
{
	private class tbpIecnyGUBAqAiBmgm6 : ListItemPropertyDescriptor
	{
		private int rZFnylGpmq4;

		private readonly Type GBgny4Y6v70;

		private PropertyDescriptor WbTnyDAakwW;

		[CompilerGenerated]
		private ComponentResourceKey Ct3nybJ4BB1;

		[CompilerGenerated]
		private string srdnyNEFEtq;

		private static tbpIecnyGUBAqAiBmgm6 RG5yB6NLkYsMPP9p6Gn8;

		public ComponentResourceKey EditorTemplate
		{
			[CompilerGenerated]
			get
			{
				return Ct3nybJ4BB1;
			}
			[CompilerGenerated]
			set
			{
				Ct3nybJ4BB1 = ct3nybJ4BB;
			}
		}

		public override string DisplayName => string.Format(DNmnyBNIgqF(), rZFnylGpmq4 + 1);

		public tbpIecnyGUBAqAiBmgm6(IList P_0, int P_1, Type P_2, Attribute[] P_3, bool P_4, bool P_5)
		{
			awPegXNLSkOks2aXnZiA();
			base._002Ector(P_0, P_1, P_2, P_3, P_4, P_5);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
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
				rZFnylGpmq4 = P_1;
				GBgny4Y6v70 = P_2;
				WbTnyDAakwW = a8RnyYfxfLV();
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 == 0)
				{
					num = 1;
				}
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public string DNmnyBNIgqF()
		{
			return srdnyNEFEtq;
		}

		[SpecialName]
		[CompilerGenerated]
		public void paDnyaAUYxN(string P_0)
		{
			srdnyNEFEtq = P_0;
		}

		private PropertyDescriptor a8RnyYfxfLV()
		{
			PropertyDescriptorCollection childProperties = GetChildProperties(RIcyjKNLLbpXEbLtGqGN(Mxc739NLxyyPqhG6dOe3(this), rZFnylGpmq4));
			int num = 0;
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
			{
				num2 = 1;
			}
			PropertyDescriptor propertyDescriptor = default(PropertyDescriptor);
			while (true)
			{
				switch (num2)
				{
				default:
					return propertyDescriptor;
				case 1:
					while (true)
					{
						if (num >= dH4m7WNLehdDOVPOKSC2(childProperties))
						{
							num2 = 2;
							break;
						}
						propertyDescriptor = childProperties[num];
						if (!propertyDescriptor.IsBrowsable || !(propertyDescriptor.Name == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-60853733 ^ -60863269)))
						{
							num++;
							continue;
						}
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
						{
							num2 = 0;
						}
						break;
					}
					break;
				case 2:
					return null;
				}
			}
		}

		public override object GetValue(object P_0)
		{
			int num = 1;
			int num2 = num;
			IList list = default(IList);
			while (true)
			{
				switch (num2)
				{
				case 1:
					list = P_0 as IList;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf != 0)
					{
						num2 = 0;
					}
					break;
				default:
				{
					if (list == null)
					{
						return aGghOjNLsqhByD26gmtN(this, P_0);
					}
					object component = list[rZFnylGpmq4];
					return WbTnyDAakwW.GetValue(component);
				}
				}
			}
		}

		public override void SetValue(object P_0, object P_1)
		{
			IList list = P_0 as IList;
			if (list == null)
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					break;
				default:
					base.SetValue(P_0, P_1);
					return;
				}
			}
			object obj = list[rZFnylGpmq4];
			KRDvFHNLXPtCuigVl05w(WbTnyDAakwW, obj, P_1);
		}

		public override object GetEditor(Type P_0)
		{
			if (EditorTemplate == null)
			{
				return P4lX2sNLcG4hA2LrNlA9(this, P_0);
			}
			PropertyEditor propertyEditor = new PropertyEditor();
			SuviS7NLjtEkdbX7rAsv(propertyEditor, EditorTemplate);
			ctDalDNLECkqhn3esUCw(propertyEditor, GBgny4Y6v70);
			return propertyEditor;
		}

		protected override void OnValueChanged(object P_0, EventArgs P_1)
		{
			base.OnValueChanged(P_0, P_1);
		}

		static tbpIecnyGUBAqAiBmgm6()
		{
			hJ9rPYNLQxucbuRXDKAW();
		}

		internal static void awPegXNLSkOks2aXnZiA()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool pZuXtuNL1rVtf6SpRUFN()
		{
			return RG5yB6NLkYsMPP9p6Gn8 == null;
		}

		internal static tbpIecnyGUBAqAiBmgm6 uSqhoPNL538Rr58NNKvI()
		{
			return RG5yB6NLkYsMPP9p6Gn8;
		}

		internal static object Mxc739NLxyyPqhG6dOe3(object P_0)
		{
			return ((ListItemPropertyDescriptor)P_0).List;
		}

		internal static object RIcyjKNLLbpXEbLtGqGN(object P_0, int P_1)
		{
			return ((IList)P_0)[P_1];
		}

		internal static int dH4m7WNLehdDOVPOKSC2(object P_0)
		{
			return ((PropertyDescriptorCollection)P_0).Count;
		}

		internal static object aGghOjNLsqhByD26gmtN(object P_0, object P_1)
		{
			return ((ListItemPropertyDescriptor)P_0).GetValue(P_1);
		}

		internal static void KRDvFHNLXPtCuigVl05w(object P_0, object P_1, object P_2)
		{
			((PropertyDescriptor)P_0).SetValue(P_1, P_2);
		}

		internal static object P4lX2sNLcG4hA2LrNlA9(object P_0, Type P_1)
		{
			return ((PropertyDescriptor)P_0).GetEditor(P_1);
		}

		internal static void SuviS7NLjtEkdbX7rAsv(object P_0, object P_1)
		{
			((PropertyEditor)P_0).ValueTemplateKey = P_1;
		}

		internal static void ctDalDNLECkqhn3esUCw(object P_0, Type P_1)
		{
			((PropertyEditor)P_0).PropertyType = P_1;
		}

		internal static void hJ9rPYNLQxucbuRXDKAW()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	private static jQ2GTsHSde7tbnyxJTLc Y4xR8XDeMAv3N7mfpDg1;

	protected override PropertyDescriptor CreateListItemPropertyDescriptor(ITypeDescriptorContext P_0, Attribute[] P_1, IList P_2, int P_3, Type P_4)
	{
		string text = P_0.PropertyDescriptor?.Name;
		if (!Xuur4fDeW4HZDkm1Bkmr(text, r18ZLoDeI5EchQp4O1CQ(0x2C8374E4 ^ 0x2C8250FA)))
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7D553BE0 ^ 0x7D55BF26))
					{
						tbpIecnyGUBAqAiBmgm6 tbpIecnyGUBAqAiBmgm = new tbpIecnyGUBAqAiBmgm6(P_2, P_3, P_4, P_1, _0020: false, _0020: false);
						tbpIecnyGUBAqAiBmgm.paDnyaAUYxN(Resources.MarketSettingsDomTickSizeLabelFormat);
						tbpIecnyGUBAqAiBmgm.EditorTemplate = GkLLyu2u6r5iib1URMmF.DoubleFlatListTemplate;
						return tbpIecnyGUBAqAiBmgm;
					}
					return (PropertyDescriptor)teIuUNDeT8bgMS3nhAFc(this, P_0, P_1, P_2, P_3, P_4);
				}
				if (Xuur4fDeW4HZDkm1Bkmr(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x741B85CB ^ 0x741AA187)))
				{
					tbpIecnyGUBAqAiBmgm6 tbpIecnyGUBAqAiBmgm2 = new tbpIecnyGUBAqAiBmgm6(P_2, P_3, P_4, P_1, _0020: false, _0020: false);
					tbpIecnyGUBAqAiBmgm2.paDnyaAUYxN(Resources.MarketSettingsDomVisibleDepthLabelFormat);
					tbpIecnyGUBAqAiBmgm2.EditorTemplate = GkLLyu2u6r5iib1URMmF.DoubleFlatListTemplate;
					return tbpIecnyGUBAqAiBmgm2;
				}
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
				{
					num = 1;
				}
			}
		}
		tbpIecnyGUBAqAiBmgm6 tbpIecnyGUBAqAiBmgm3 = new tbpIecnyGUBAqAiBmgm6(P_2, P_3, P_4, P_1, _0020: false, _0020: false);
		Pt4b4YDetKPXgxW01OhQ(tbpIecnyGUBAqAiBmgm3, Resources.MarketSettingsDomPriceScaleMultiplierLabelFormat);
		tbpIecnyGUBAqAiBmgm3.EditorTemplate = (ComponentResourceKey)qOZnUVDeUbd1r5EkFUgP();
		return tbpIecnyGUBAqAiBmgm3;
	}

	public override object ConvertTo(ITypeDescriptorContext P_0, CultureInfo P_1, object P_2, Type P_3)
	{
		int num = 20;
		int num2 = num;
		uint num3 = default(uint);
		ICollection collection = default(ICollection);
		string name = default(string);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (num3 != 3584481192u)
				{
					num2 = 7;
					break;
				}
				goto case 8;
			case 7:
				if (num3 != 3704894449u)
				{
					num2 = 21;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
					{
						num2 = 23;
					}
					break;
				}
				goto case 16;
			case 19:
				collection = P_2 as ICollection;
				num2 = 24;
				break;
			case 20:
				if (P_3 == Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777226)))
				{
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
					{
						num2 = 19;
					}
					break;
				}
				goto default;
			case 26:
				if (Xuur4fDeW4HZDkm1Bkmr(name, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--855742383 ^ 0x3300B36F)))
				{
					return string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7DB10E6E ^ 0x7DB14226), HMG1ltDeVKvEI9YUdum1(), VAl3n0DeZntvHAEpqZLu(collection));
				}
				goto default;
			case 10:
				return Resources.ChildrenCollectionConverterNoLevels;
			case 21:
				return string.Format((string)r18ZLoDeI5EchQp4O1CQ(-837284864 ^ -837271480), Resources.ChildrenCollectionConverterLevels, collection.Count);
			case 12:
				if (collection.Count <= 0)
				{
					num2 = 10;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
					{
						num2 = 11;
					}
					break;
				}
				return string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-225822163 ^ -225829283), collection.Count);
			case 11:
				return T9fUywDeCUhHcc5KfJhS();
			case 23:
				if (num3 != 3881513226u)
				{
					goto default;
				}
				goto case 17;
			case 15:
				if (!(name == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-181342698 ^ -181371540)))
				{
					goto default;
				}
				num2 = 12;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
				{
					num2 = 12;
				}
				break;
			case 2:
				if (num3 == 1575996236 && Xuur4fDeW4HZDkm1Bkmr(name, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x22BF43FC ^ 0x22BE67E2)))
				{
					goto IL_039e;
				}
				goto default;
			case 18:
				if (num3 == 108686242)
				{
					if (!(name == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--500511424 ^ 0x1DD41626)))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 12;
				}
				if (num3 == 416792261)
				{
					goto case 26;
				}
				if (num3 != 982000571 || !(name == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6EC99CAF ^ 0x6EC8B851)))
				{
					goto default;
				}
				if (collection.Count > 0)
				{
					return JUw3epDeKoKkldR11Lh6(r18ZLoDeI5EchQp4O1CQ(-1848952786 ^ -1848959906), collection.Count);
				}
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return Resources.ChildrenCollectionConverterNoValues;
			default:
				return base.ConvertTo(P_0, P_1, P_2, P_3);
			case 17:
				if (name == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E045860))
				{
					goto IL_04f4;
				}
				goto default;
			case 24:
				if (collection != null)
				{
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
					{
						num2 = 13;
					}
					break;
				}
				goto default;
			case 16:
				if (name == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-342738082 ^ -342704232))
				{
					goto case 12;
				}
				goto default;
			case 8:
				if (!(name == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xC1DDB3B ^ 0xC1D486F)))
				{
					goto default;
				}
				goto case 12;
			case 25:
				if (num3 != 1779893013)
				{
					if (num3 != 2321471592u)
					{
						if (num3 == 2812563461u)
						{
							goto case 15;
						}
						goto default;
					}
					if (!(name == (string)r18ZLoDeI5EchQp4O1CQ(0x735715F1 ^ 0x7356319B)))
					{
						num2 = 3;
						break;
					}
				}
				else if (!(name == (string)r18ZLoDeI5EchQp4O1CQ(-617064403 ^ -616989521)))
				{
					num2 = 4;
					break;
				}
				if (VAl3n0DeZntvHAEpqZLu(collection) <= 0)
				{
					return Resources.ChildrenCollectionConverterNoFilters;
				}
				return string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4297C3EB ^ 0x42978FA3), Resources.ChildrenCollectionConverterFilters, VAl3n0DeZntvHAEpqZLu(collection));
			case 13:
				{
					if (P_0.PropertyDescriptor != null)
					{
						name = P_0.PropertyDescriptor.Name;
						num3 = zRtfRNDeykYq6qTcPNmi(name);
						if (num3 > 1575996236)
						{
							if (num3 <= 2812563461u)
							{
								num2 = 25;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
								{
									num2 = 5;
								}
								break;
							}
							goto case 5;
						}
						if (num3 <= 982000571)
						{
							num2 = 18;
							break;
						}
						if (num3 != 1130978781)
						{
							if (num3 != 1530550159)
							{
								num2 = 2;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
								{
									num2 = 2;
								}
								break;
							}
							if (!(name == (string)r18ZLoDeI5EchQp4O1CQ(0x1487846E ^ 0x1486A022)))
							{
								num2 = 6;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
								{
									num2 = 14;
								}
								break;
							}
							goto IL_039e;
						}
						if (name == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-527080372 ^ -527154990))
						{
							goto IL_04f4;
						}
					}
					goto default;
				}
				IL_04f4:
				if (collection.Count > 0)
				{
					num2 = 21;
					break;
				}
				goto case 10;
				IL_039e:
				if (VAl3n0DeZntvHAEpqZLu(collection) <= 0)
				{
					return RUwojODerAyp0s62A8LJ();
				}
				return string.Format((string)r18ZLoDeI5EchQp4O1CQ(-2074141628 ^ -2074128372), Resources.ChildrenCollectionConverterValues, collection.Count);
			}
		}
	}

	public jQ2GTsHSde7tbnyxJTLc()
	{
		gftMEeDemukr28Wy7keW();
		base._002Ector();
	}

	static jQ2GTsHSde7tbnyxJTLc()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object r18ZLoDeI5EchQp4O1CQ(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool Xuur4fDeW4HZDkm1Bkmr(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void Pt4b4YDetKPXgxW01OhQ(object P_0, object P_1)
	{
		((tbpIecnyGUBAqAiBmgm6)P_0).paDnyaAUYxN((string)P_1);
	}

	internal static object qOZnUVDeUbd1r5EkFUgP()
	{
		return GkLLyu2u6r5iib1URMmF.IntFlatListTemplate;
	}

	internal static object teIuUNDeT8bgMS3nhAFc(object P_0, object P_1, object P_2, object P_3, int P_4, Type P_5)
	{
		return ((ExpandableCollectionConverter)P_0).CreateListItemPropertyDescriptor((ITypeDescriptorContext)P_1, (Attribute[])P_2, (IList)P_3, P_4, P_5);
	}

	internal static bool U1VYyQDeOaJHi439Hvaf()
	{
		return Y4xR8XDeMAv3N7mfpDg1 == null;
	}

	internal static jQ2GTsHSde7tbnyxJTLc FyQYyPDeq0hQ5ReLd8MS()
	{
		return Y4xR8XDeMAv3N7mfpDg1;
	}

	internal static uint zRtfRNDeykYq6qTcPNmi(object P_0)
	{
		return global::_003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	internal static int VAl3n0DeZntvHAEpqZLu(object P_0)
	{
		return ((ICollection)P_0).Count;
	}

	internal static object HMG1ltDeVKvEI9YUdum1()
	{
		return Resources.ChildrenCollectionConverterPoints;
	}

	internal static object T9fUywDeCUhHcc5KfJhS()
	{
		return Resources.ChildrenCollectionConverterNoFilters;
	}

	internal static object RUwojODerAyp0s62A8LJ()
	{
		return Resources.ChildrenCollectionConverterNoValues;
	}

	internal static object JUw3epDeKoKkldR11Lh6(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void gftMEeDemukr28Wy7keW()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}
}
