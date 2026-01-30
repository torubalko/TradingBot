using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using ActiproSoftware.Windows.Controls.Grids;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;
using ActiproSoftware.Windows.Data.Filtering;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;

namespace B5A5hB2z2EVuSQ5VHGmu;

internal sealed class VoU9lv2z05uTExIsC3Ip : PropertyGrid, IComponentConnector
{
	private bool vTA2zfAyd9i;

	private static VoU9lv2z05uTExIsC3Ip c5rSplDvPcC9lpaK6gLs;

	public VoU9lv2z05uTExIsC3Ip()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		InitializeComponent();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
			{
				PropertyEditorCollection propertyEditors = base.PropertyEditors;
				PropertyEditor propertyEditor = new PropertyEditor();
				pUYlEmDvpFVlv8syRoUK(propertyEditor, bACCdYDv3VABjfKkrTQQ(typeof(int?).TypeHandle));
				propertyEditor.ValueTemplate = (DataTemplate)base.Resources[NRHOFtDvu474njghN5Z1(-1763895751 ^ -1763840845)];
				propertyEditors.Add(propertyEditor);
				PropertyEditorCollection propertyEditors2 = base.PropertyEditors;
				PropertyEditor obj = new PropertyEditor
				{
					PropertyType = bACCdYDv3VABjfKkrTQQ(typeof(long?).TypeHandle)
				};
				JikQI6DvzOW9fu1boJb0(obj, (DataTemplate)base.Resources[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-90307782 ^ -90244722)]);
				propertyEditors2.Add(obj);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac != 0)
				{
					num = 0;
				}
				break;
			}
			case 1:
				base.PropertyEditors.Add(new PropertyEditor
				{
					PropertyType = typeof(DateTime?),
					ValueTemplate = (DataTemplate)base.Resources[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3544E813 ^ 0x35441329)]
				});
				return;
			default:
				base.PropertyEditors.Add(new PropertyEditor
				{
					PropertyType = typeof(double?),
					ValueTemplate = (DataTemplate)base.Resources[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-624753169 ^ -624689359)]
				});
				base.PropertyEditors.Add(new PropertyEditor
				{
					PropertyType = bACCdYDv3VABjfKkrTQQ(typeof(TimeSpan?).TypeHandle),
					ValueTemplate = (DataTemplate)dxCVQ1DB0daYBHydqAsO(base.Resources, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24B0B9E6 ^ 0x24B042EC))
				});
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public void jj12zHToQKX(string P_0, bool P_1 = true)
	{
		DataFilterGroup dataFilterGroup = new DataFilterGroup
		{
			Operation = DataFilterGroupOperation.Or
		};
		int num;
		if (P_1)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_0175;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
			{
				DataFilterCollection children = dataFilterGroup.Children;
				PropertyModelStringFilter obj2 = new PropertyModelStringFilter
				{
					Source = PropertyModelStringFilterSource.DisplayName,
					Operation = StringFilterOperation.StartsWith
				};
				NhCYtvDB9cC4fksdSRQL(obj2, TigerTrade.Properties.Resources.MarketSettingsDomVisibleDepthLabelFormat.Remove(vGjQLODBG1hTb1seBKiS(TigerTrade.Properties.Resources.MarketSettingsDomVisibleDepthLabelFormat) - 3));
				lYsJqCDBnPTQmD7aTn7L(obj2, StringComparison.CurrentCultureIgnoreCase);
				children.Add(obj2);
				object obj3 = BZtvHtDBH6xqZTWdCuK6(dataFilterGroup);
				PropertyModelStringFilter obj4 = new PropertyModelStringFilter
				{
					Source = PropertyModelStringFilterSource.DisplayName,
					Operation = StringFilterOperation.StartsWith
				};
				NhCYtvDB9cC4fksdSRQL(obj4, H7XWhoDBoiL8k5ngrqRI(A1X13dDBYvjLfDBKl7u9(), TigerTrade.Properties.Resources.MarketSettingsDomTickSizeLabelFormat.Length - 3));
				lYsJqCDBnPTQmD7aTn7L(obj4, StringComparison.CurrentCultureIgnoreCase);
				((Collection<IDataFilter>)obj3).Add((IDataFilter)obj4);
				int num2 = 3;
				num = num2;
				continue;
			}
			case 2:
				return;
			case 1:
			{
				lgu1K1DB2kZkaqgrbyiG(dataFilterGroup, DataFilterGroupOperation.Or);
				object obj = BZtvHtDBH6xqZTWdCuK6(dataFilterGroup);
				PropertyModelStringFilter propertyModelStringFilter = new PropertyModelStringFilter();
				D27ETfDBfDSCMG5MQ1et(propertyModelStringFilter, PropertyModelStringFilterSource.DisplayName);
				propertyModelStringFilter.Operation = StringFilterOperation.StartsWith;
				NhCYtvDB9cC4fksdSRQL(propertyModelStringFilter, TigerTrade.Properties.Resources.MarketSettingsDomPriceScaleMultiplierLabelFormat.Remove(TigerTrade.Properties.Resources.MarketSettingsDomPriceScaleMultiplierLabelFormat.Length - 3));
				lYsJqCDBnPTQmD7aTn7L(propertyModelStringFilter, StringComparison.CurrentCultureIgnoreCase);
				((Collection<IDataFilter>)obj).Add((IDataFilter)propertyModelStringFilter);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
				{
					num = 0;
				}
				continue;
			}
			case 3:
				break;
			}
			break;
		}
		goto IL_0175;
		IL_0175:
		dataFilterGroup.Children.Add(new PropertyModelStringFilter
		{
			Source = PropertyModelStringFilterSource.Description,
			Operation = StringFilterOperation.Contains,
			Value = P_0,
			StringComparison = StringComparison.CurrentCultureIgnoreCase
		});
		base.DataFilter = dataFilterGroup;
		base.IsFilterActive = true;
		num = 2;
		goto IL_0009;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!vTA2zfAyd9i)
		{
			vTA2zfAyd9i = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Uri resourceLocator = new Uri((string)NRHOFtDvu474njghN5Z1(-45476899 ^ -45422409), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		vTA2zfAyd9i = true;
	}

	static VoU9lv2z05uTExIsC3Ip()
	{
		WRRcL7DBvrhQ03fOGSYX();
	}

	internal static Type bACCdYDv3VABjfKkrTQQ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void pUYlEmDvpFVlv8syRoUK(object P_0, Type P_1)
	{
		((PropertyEditor)P_0).PropertyType = P_1;
	}

	internal static object NRHOFtDvu474njghN5Z1(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void JikQI6DvzOW9fu1boJb0(object P_0, object P_1)
	{
		((PropertyEditor)P_0).ValueTemplate = (DataTemplate)P_1;
	}

	internal static object dxCVQ1DB0daYBHydqAsO(object P_0, object P_1)
	{
		return ((ResourceDictionary)P_0)[P_1];
	}

	internal static bool hBc7E9DvJsvYVwKwI4On()
	{
		return c5rSplDvPcC9lpaK6gLs == null;
	}

	internal static VoU9lv2z05uTExIsC3Ip WF6xqrDvFtA7dfX9pi4x()
	{
		return c5rSplDvPcC9lpaK6gLs;
	}

	internal static void lgu1K1DB2kZkaqgrbyiG(object P_0, DataFilterGroupOperation P_1)
	{
		((DataFilterGroup)P_0).Operation = P_1;
	}

	internal static object BZtvHtDBH6xqZTWdCuK6(object P_0)
	{
		return ((DataFilterGroup)P_0).Children;
	}

	internal static void D27ETfDBfDSCMG5MQ1et(object P_0, PropertyModelStringFilterSource P_1)
	{
		((PropertyModelStringFilter)P_0).Source = P_1;
	}

	internal static void NhCYtvDB9cC4fksdSRQL(object P_0, object P_1)
	{
		((StringFilterBase)P_0).Value = (string)P_1;
	}

	internal static void lYsJqCDBnPTQmD7aTn7L(object P_0, StringComparison P_1)
	{
		((StringFilterBase)P_0).StringComparison = P_1;
	}

	internal static int vGjQLODBG1hTb1seBKiS(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object A1X13dDBYvjLfDBKl7u9()
	{
		return TigerTrade.Properties.Resources.MarketSettingsDomTickSizeLabelFormat;
	}

	internal static object H7XWhoDBoiL8k5ngrqRI(object P_0, int P_1)
	{
		return ((string)P_0).Remove(P_1);
	}

	internal static void WRRcL7DBvrhQ03fOGSYX()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
