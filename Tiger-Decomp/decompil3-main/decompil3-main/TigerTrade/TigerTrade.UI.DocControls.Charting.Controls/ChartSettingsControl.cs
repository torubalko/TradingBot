using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using ActiproSoftware.Windows.Controls.Grids;
using AMj7i59xpIF2mbHGTtbm;
using b1neT39sxtGuKbVPRyqn;
using B5A5hB2z2EVuSQ5VHGmu;
using ciQ7MQHkM693awgKHy3A;
using ECOEgqlSad8NUJZ2Dr9n;
using EJe4wJ9Qij5iWcVlhgYj;
using jS3Y2j9pTQRy0FnOknFG;
using kUGTJY2EWaL0gsjmSsK0;
using LBWsN39Q2OCG4fj6vDfg;
using Microsoft.Win32;
using PMH7kB9LS7xf0LikQbe5;
using TigerTrade.Chart.Settings;
using TigerTrade.Core.Utils.Config;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.DocControls.Charting.Controls;

internal sealed class ChartSettingsControl : aUQvKjHk6H77hbYGG0GM, IComponentConnector
{
	private z76M7N9QaE0P3ElcZAyt _selectedTemplate;

	internal Grid GridTemplate;

	internal ComboBox ComboBoxThemes;

	internal TabControl TabControl;

	internal VoU9lv2z05uTExIsC3Ip PropertyGridGeneral;

	internal VoU9lv2z05uTExIsC3Ip PropertyGridCluster;

	internal VoU9lv2z05uTExIsC3Ip PropertyGridTrading;

	private bool _contentLoaded;

	private static ChartSettingsControl A8B6JV4PF760cKek6i0L;

	public ObservableCollection<z76M7N9QaE0P3ElcZAyt> Templates { get; set; }

	public z76M7N9QaE0P3ElcZAyt SelectedTemplate
	{
		get
		{
			return _selectedTemplate;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (!object.Equals(value, _selectedTemplate))
					{
						_selectedTemplate = value;
						cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--146713930 ^ 0x8BEE3F0));
						cY7HkOvo1nf((string)j4QWxu4Pu7GoDYMDuw9J(0x7D553BE0 ^ 0x7D55753E));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool TemplateIsSelected => SelectedTemplate != null;

	public ChartSettings ChartSettings { get; set; }

	public ChartSettingsControl()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		base.Focusable = false;
		Templates = new ObservableCollection<z76M7N9QaE0P3ElcZAyt>();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 3:
			{
				InitializeComponent();
				int num2 = 2;
				num = num2;
				break;
			}
			default:
				PropertyGridTrading.Columns[1].Width = new GridLength(4.0, GridUnitType.Star);
				BuildTemplatesList();
				K3FFIA9Q0nWGKAkBaIfc.niZ9QY0ts0b(BuildTemplatesList);
				return;
			case 4:
				PropertyGridCluster.Columns[1].Width = new GridLength(4.0, GridUnitType.Star);
				PropertyGridTrading.Columns[0].Width = new GridLength(6.0, GridUnitType.Star);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				AlPHec4Pz8UWq0N0vRIS(PropertyGridGeneral.Columns[0], new GridLength(6.0, GridUnitType.Star));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				PropertyGridGeneral.Columns[1].Width = new GridLength(4.0, GridUnitType.Star);
				AlPHec4Pz8UWq0N0vRIS(PropertyGridCluster.Columns[0], new GridLength(6.0, GridUnitType.Star));
				num = 4;
				break;
			}
		}
	}

	public void LoadSettings()
	{
		if (ChartSettings != null)
		{
			PropertyGridGeneral.DataObject = ChartSettings.VisualSettings;
			PropertyGridCluster.DataObject = ChartSettings.ClusterSettings;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			PropertyGridTrading.DataObject = ChartSettings.TradeSettings;
		}
	}

	public void UnloadSettings()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				PropertyGridCluster.DataObject = null;
				PropertyGridTrading.DataObject = null;
				return;
			case 1:
				PropertyGridGeneral.DataObject = null;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void ComboBoxThemes_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (SelectedTemplate == null || !(SelectedTemplate.FMt9Q4BYade() == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24B0B9E6 ^ 0x24B0F69C)))
		{
			return;
		}
		SelectedTemplate = null;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
		{
			num = 1;
		}
		OpenFileDialog openFileDialog = default(OpenFileDialog);
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				openFileDialog = new OpenFileDialog();
				if (openFileDialog.ShowDialog() == true)
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
					{
						num = 0;
					}
					continue;
				}
				return;
			}
			try
			{
				if (File.Exists(openFileDialog.FileName))
				{
					ChartSettings chartSettings = ConfigSerializer.LoadFromFile<ChartSettings>(openFileDialog.FileName, jjKtVJ9pUSOpdg38tqnP.PV29p3fNsns());
					PglBwY4J0cpkhExemgZ2(ChartSettings, chartSettings, false);
					int num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					case 0:
						break;
					}
				}
				return;
			}
			catch (Exception e2)
			{
				LogManager.WriteError(e2);
				return;
			}
		}
	}

	private void TemplateButton_Click(object sender, RoutedEventArgs e)
	{
		int num = 4;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				text = nfA1tY4J2Q4XG1rIyKga((ButtonBase)sender).ToString();
				num2 = 3;
				break;
			case 3:
				if (!(text == (string)j4QWxu4Pu7GoDYMDuw9J(-1309555870 ^ -1309569800)))
				{
					if (!(text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-60853733 ^ -60867165)))
					{
						if (!(text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x746ED405 ^ 0x746E9BDD)))
						{
							return;
						}
						SaveTemplate();
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						RemoveTemplate();
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
						{
							num2 = 0;
						}
					}
				}
				else
				{
					SetTemplate();
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
					{
						num2 = 2;
					}
				}
				break;
			case 0:
				return;
			case 2:
				return;
			case 1:
				return;
			}
		}
	}

	public void BuildTemplatesList()
	{
		int num = 1;
		int num2 = num;
		List<ChartSettings>.Enumerator enumerator = default(List<ChartSettings>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 1:
				Templates.Clear();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				try
				{
					while (enumerator.MoveNext())
					{
						ChartSettings current = enumerator.Current;
						Templates.Add(new z76M7N9QaE0P3ElcZAyt(current.TemplateName, current.TemplateID, current));
					}
					int num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
			}
			Templates.Add(new z76M7N9QaE0P3ElcZAyt(TigerTrade.Properties.Resources.CommonTemplateLoadFromFile, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--737722733 ^ 0x2BF88E17), null));
			ObservableCollection<z76M7N9QaE0P3ElcZAyt> templates = Templates;
			string commonTemplateDefault = TigerTrade.Properties.Resources.CommonTemplateDefault;
			object obj = j4QWxu4Pu7GoDYMDuw9J(0x20B584D2 ^ 0x20B5CB26);
			ChartSettings chartSettings = new ChartSettings();
			T6SQfC4JH35MBvPd2ek4(chartSettings, false);
			chartSettings.ContainsTheme = false;
			tcAOeK4JfDXQiovrsZ1n(chartSettings, false);
			lu9Xq94J93xXuH8lCSQX(chartSettings, false);
			templates.Add(new z76M7N9QaE0P3ElcZAyt(commonTemplateDefault, (string)obj, chartSettings));
			enumerator = K3FFIA9Q0nWGKAkBaIfc.qLt9QGrSG3y().GetEnumerator();
			num2 = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
			{
				num2 = 2;
			}
		}
	}

	private void SetTemplate()
	{
		int num = 1;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				z76M7N9QaE0P3ElcZAyt selectedTemplate = SelectedTemplate;
				if (selectedTemplate == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj = selectedTemplate.AFW9QbsPZiQ();
				break;
			}
			default:
				obj = null;
				break;
			}
			break;
		}
		if (obj != null)
		{
			ChartSettings.CopySettings(SelectedTemplate.AFW9QbsPZiQ(), full: false);
		}
	}

	private void RemoveTemplate()
	{
		if (SelectedTemplate != null)
		{
			K3FFIA9Q0nWGKAkBaIfc.Remove((string)vXe6kN4JnMlhgKCN90CB(SelectedTemplate));
			BuildTemplatesList();
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
	}

	private void SaveTemplate()
	{
		Bcg93Q2EIm3qXbSX0Tjk bcg93Q2EIm3qXbSX0Tjk = new Bcg93Q2EIm3qXbSX0Tjk();
		f4p3R84JGMHU0mQ0sJsQ(bcg93Q2EIm3qXbSX0Tjk, base.ParentWindow);
		Bcg93Q2EIm3qXbSX0Tjk bcg93Q2EIm3qXbSX0Tjk2 = bcg93Q2EIm3qXbSX0Tjk;
		bool? flag = bcg93Q2EIm3qXbSX0Tjk2.ShowDialog();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
		{
			num = 4;
		}
		ChartSettings chartSettings = default(ChartSettings);
		SaveFileDialog saveFileDialog = default(SaveFileDialog);
		while (true)
		{
			SaveFileDialog saveFileDialog2;
			switch (num)
			{
			case 18:
				chartSettings.DataCycle = null;
				num = 13;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be != 0)
				{
					num = 11;
				}
				break;
			case 2:
				chartSettings = new ChartSettings
				{
					TemplateID = Guid.NewGuid().ToString(),
					TemplateName = bcg93Q2EIm3qXbSX0Tjk2.TemplateName
				};
				chartSettings.CopySettings(ChartSettings, full: true);
				if (!bcg93Q2EIm3qXbSX0Tjk2.OptionIndicators)
				{
					foreach (CR9nZ49x3RUlacnAckjy area in chartSettings.Areas)
					{
						area.Indicators.Clear();
					}
					goto case 17;
				}
				chartSettings.ContainsIndicators = true;
				num = 15;
				break;
			case 6:
			case 11:
				if (!bcg93Q2EIm3qXbSX0Tjk2.OptionTheme)
				{
					num = 16;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 != 0)
					{
						num = 4;
					}
					break;
				}
				goto case 3;
			case 5:
				if (string.IsNullOrEmpty((string)k9lS824JYI1vnsxSJgQ2(bcg93Q2EIm3qXbSX0Tjk2)))
				{
					return;
				}
				ChartSettings.SaveTemplate();
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
				{
					num = 0;
				}
				break;
			case 15:
				if (!bcg93Q2EIm3qXbSX0Tjk2.OptionObjects)
				{
					num = 14;
					break;
				}
				goto case 10;
			case 12:
				if (!bcg93Q2EIm3qXbSX0Tjk2.OptionPeriod)
				{
					num = 18;
					break;
				}
				T6SQfC4JH35MBvPd2ek4(chartSettings, true);
				num = 11;
				break;
			case 13:
				chartSettings.ContainsPeriod = false;
				num = 6;
				break;
			case 17:
				tcAOeK4JfDXQiovrsZ1n(chartSettings, false);
				goto case 15;
			default:
				if (bcg93Q2EIm3qXbSX0Tjk2.OptionTrading)
				{
					goto case 1;
				}
				n9T5Qw4JBnLF6aJm0ysD(sZauGk4JvFNNcNAolMVX(chartSettings));
				kJ2e0a4JaQ3ujMarBFkB(chartSettings, false);
				goto IL_04e8;
			case 3:
				chartSettings.ContainsTheme = true;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
				{
					num = 0;
				}
				break;
			case 7:
				if (flag == true)
				{
					ConfigSerializer.SaveToFile(chartSettings, saveFileDialog.FileName, (DataContractResolver)BEPQr14J4X4Un8gdXUPf());
				}
				return;
			case 16:
				chartSettings.Theme = null;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
				{
					num = 8;
				}
				break;
			case 1:
				chartSettings.ContainsTradeSettings = true;
				goto IL_04e8;
			case 8:
				EJmCUX4JoSbGX8Ukmh12(chartSettings, false);
				goto default;
			case 14:
				foreach (CR9nZ49x3RUlacnAckjy area2 in chartSettings.Areas)
				{
					area2.Objects.Clear();
					int num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					}
				}
				goto case 9;
			case 10:
				chartSettings.ContainsPeriod = true;
				goto case 12;
			case 9:
				chartSettings.ContainsPeriod = false;
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b != 0)
				{
					num = 12;
				}
				break;
			case 4:
				{
					if (flag == true)
					{
						int num2 = 5;
						num = num2;
						break;
					}
					return;
				}
				IL_04e8:
				if (!TRyGlG4JirtMSPlqJFBO(bcg93Q2EIm3qXbSX0Tjk2))
				{
					K3FFIA9Q0nWGKAkBaIfc.ayu9QnZhkD9(chartSettings);
					BuildTemplatesList();
					return;
				}
				saveFileDialog2 = new SaveFileDialog();
				qcF3iu4JlVapkLJqsoqj(saveFileDialog2, bcg93Q2EIm3qXbSX0Tjk2.TemplateName + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-837284864 ^ -837264378));
				saveFileDialog2.Filter = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--134855371 ^ 0x809EAD9);
				saveFileDialog = saveFileDialog2;
				flag = saveFileDialog.ShowDialog();
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 == 0)
				{
					num = 7;
				}
				break;
			}
		}
	}

	public void SetupAsWindow()
	{
		WkNjLM4JD5WwjvisHmwO(TabControl, new Thickness(1.0));
		GQvdf34JblbcPp2y6jCC(GridTemplate, new Thickness(0.0, 0.0, 0.0, 10.0));
	}

	private void PropertyGridCluster_PropertyValueChanged(object sender, PropertyModelValueChangeEventArgs e)
	{
		ChartSettings.RiseUpdate();
	}

	private void PropertyGridCluster_ChildPropertyAdded(object sender, PropertyModelChildChangeEventArgs e)
	{
		ChartSettings.RiseUpdate();
		eongog4JNiBBrNylOZwT(ChartSettings.ClusterSettings);
	}

	private void PropertyGridCluster_ChildPropertyRemoved(object sender, PropertyModelChildChangeEventArgs e)
	{
		ChartSettings.RiseUpdate();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				if (!_contentLoaded)
				{
					_contentLoaded = true;
					Uri uri = new Uri((string)j4QWxu4Pu7GoDYMDuw9J(-1801468030 ^ -1801516120), UriKind.Relative);
					jtHmJ94JkFp2LYwNAFUR(this, uri);
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		case 9:
			PropertyGridTrading = (VoU9lv2z05uTExIsC3Ip)target;
			break;
		case 8:
			PropertyGridCluster = (VoU9lv2z05uTExIsC3Ip)target;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd != 0)
			{
				num = 2;
			}
			goto IL_0009;
		case 7:
			PropertyGridGeneral = (VoU9lv2z05uTExIsC3Ip)target;
			break;
		case 6:
			TabControl = (TabControl)target;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		default:
			_contentLoaded = true;
			break;
		case 4:
			((Button)target).Click += TemplateButton_Click;
			break;
		case 1:
			GridTemplate = (Grid)target;
			break;
		case 5:
			((Button)target).Click += TemplateButton_Click;
			break;
		case 3:
			ex3Tv44J11TpSjIdQhq9((Button)target, new RoutedEventHandler(TemplateButton_Click));
			num = 4;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f != 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 2:
			{
				ComboBoxThemes = (ComboBox)target;
				ComboBoxThemes.SelectionChanged += ComboBoxThemes_SelectionChanged;
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
				{
					num = 3;
				}
				goto IL_0009;
			}
			IL_0009:
			switch (num)
			{
			default:
				return;
			case 2:
				return;
			case 0:
				return;
			case 4:
				return;
			case 1:
				break;
			case 3:
				return;
			}
			goto case 1;
		}
	}

	static ChartSettingsControl()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object j4QWxu4Pu7GoDYMDuw9J(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool cZGqHm4P3kflSU0FstVh()
	{
		return A8B6JV4PF760cKek6i0L == null;
	}

	internal static ChartSettingsControl y04koH4PpDCbK2qsmrGa()
	{
		return A8B6JV4PF760cKek6i0L;
	}

	internal static void AlPHec4Pz8UWq0N0vRIS(object P_0, GridLength P_1)
	{
		((TreeListViewColumn)P_0).Width = P_1;
	}

	internal static void PglBwY4J0cpkhExemgZ2(object P_0, object P_1, bool full)
	{
		((ChartSettings)P_0).CopySettings((ChartSettings)P_1, full);
	}

	internal static object nfA1tY4J2Q4XG1rIyKga(object P_0)
	{
		return ((ButtonBase)P_0).CommandParameter;
	}

	internal static void T6SQfC4JH35MBvPd2ek4(object P_0, bool value)
	{
		((ChartSettings)P_0).ContainsPeriod = value;
	}

	internal static void tcAOeK4JfDXQiovrsZ1n(object P_0, bool value)
	{
		((ChartSettings)P_0).ContainsIndicators = value;
	}

	internal static void lu9Xq94J93xXuH8lCSQX(object P_0, bool value)
	{
		((ChartSettings)P_0).ContainsObjects = value;
	}

	internal static object vXe6kN4JnMlhgKCN90CB(object P_0)
	{
		return ((z76M7N9QaE0P3ElcZAyt)P_0).FMt9Q4BYade();
	}

	internal static void f4p3R84JGMHU0mQ0sJsQ(object P_0, object P_1)
	{
		((Window)P_0).Owner = (Window)P_1;
	}

	internal static object k9lS824JYI1vnsxSJgQ2(object P_0)
	{
		return ((Bcg93Q2EIm3qXbSX0Tjk)P_0).TemplateName;
	}

	internal static void EJmCUX4JoSbGX8Ukmh12(object P_0, bool value)
	{
		((ChartSettings)P_0).ContainsTheme = value;
	}

	internal static object sZauGk4JvFNNcNAolMVX(object P_0)
	{
		return ((ChartSettings)P_0).TradeSettings;
	}

	internal static void n9T5Qw4JBnLF6aJm0ysD(object P_0)
	{
		((dyykKj9sS7wbwJvEPZ4K)P_0).m4U9sjCwE3j();
	}

	internal static void kJ2e0a4JaQ3ujMarBFkB(object P_0, bool value)
	{
		((ChartSettings)P_0).ContainsTradeSettings = value;
	}

	internal static bool TRyGlG4JirtMSPlqJFBO(object P_0)
	{
		return ((Bcg93Q2EIm3qXbSX0Tjk)P_0).dio2EPqO8EP();
	}

	internal static void qcF3iu4JlVapkLJqsoqj(object P_0, object P_1)
	{
		((FileDialog)P_0).FileName = (string)P_1;
	}

	internal static object BEPQr14J4X4Un8gdXUPf()
	{
		return jjKtVJ9pUSOpdg38tqnP.PV29p3fNsns();
	}

	internal static void WkNjLM4JD5WwjvisHmwO(object P_0, Thickness P_1)
	{
		((Control)P_0).BorderThickness = P_1;
	}

	internal static void GQvdf34JblbcPp2y6jCC(object P_0, Thickness P_1)
	{
		((FrameworkElement)P_0).Margin = P_1;
	}

	internal static void eongog4JNiBBrNylOZwT(object P_0)
	{
		((KO34fu9L5FtbhDmWJ1ad)P_0).dSA9Lemf56t();
	}

	internal static void jtHmJ94JkFp2LYwNAFUR(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static void ex3Tv44J11TpSjIdQhq9(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}
}
