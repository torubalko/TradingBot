using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using ActiproSoftware.Windows.Controls.Grids;
using B5A5hB2z2EVuSQ5VHGmu;
using CjttZVHEzEWfhqQAXjq2;
using ECOEgqlSad8NUJZ2Dr9n;
using Microsoft.Win32;
using n4LmhZHDb0i8YpSGr2Xl;
using oecYxS9xZZ8gWvdvTg3u;
using OWUMXkHkWgCUprHQ3jb9;
using PHcSXE2EXkfja7joO6Wv;
using TigerTrade.Chart.Theme;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;
using vOxNrm9xLdv0Lpm9nq3V;

namespace HUfIdi2QnjBRctpElcaj;

internal sealed class hFI3Kk2Q99FbdfaSsliM : PbGEeJHkI13kYvWpne18, IComponentConnector
{
	[CompilerGenerated]
	private sealed class qyc4KFnMHJeZRr9CAiVT
	{
		public Window zQsnM9dsR66;

		public ChartTheme dvVnMn7oydi;

		public Action<ChartTheme, bool> eLCnMGdABmI;

		internal static qyc4KFnMHJeZRr9CAiVT klcssMNbVwKgMC8ksJeE;

		public qyc4KFnMHJeZRr9CAiVT()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal void IGknMf3N3px(hFI3Kk2Q99FbdfaSsliM w)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					w.Owner = zQsnM9dsR66;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					w.Theme = dvVnMn7oydi;
					w.qIJ2Q4oClRp(eLCnMGdABmI);
					return;
				}
			}
		}

		static qyc4KFnMHJeZRr9CAiVT()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool f5n0pANbCsay9kf1WNPg()
		{
			return klcssMNbVwKgMC8ksJeE == null;
		}

		internal static qyc4KFnMHJeZRr9CAiVT acGCaONbrjKW350cev3d()
		{
			return klcssMNbVwKgMC8ksJeE;
		}
	}

	[CompilerGenerated]
	private Action<ChartTheme, bool> ldm2QLegHAG;

	private ChartTheme nQj2QeTZI6x;

	private ChartTheme sPx2QsChZfN;

	[CompilerGenerated]
	private ObservableCollection<FxhV0D9xxKsZanj5Yt0Z> h9F2QXB5O2k;

	private FxhV0D9xxKsZanj5Yt0Z nPc2Qc1f87F;

	internal ComboBox ComboBoxThemes;

	internal VoU9lv2z05uTExIsC3Ip PropGrid;

	private bool IVl2Qj2EWhP;

	internal static hFI3Kk2Q99FbdfaSsliM ox0lNk474qUyDHxhkBho;

	public ChartTheme Theme
	{
		get
		{
			return sPx2QsChZfN;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					if (!object.Equals(chartTheme, sPx2QsChZfN))
					{
						sPx2QsChZfN = chartTheme;
						if (nQj2QeTZI6x == null)
						{
							nQj2QeTZI6x = new ChartTheme();
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto IL_0082;
					}
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					{
						nQj2QeTZI6x.CopyTheme(chartTheme);
						goto IL_0082;
					}
					IL_0082:
					ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5CD4F15 ^ 0x5CDDD65));
					return;
				}
			}
		}
	}

	public ObservableCollection<FxhV0D9xxKsZanj5Yt0Z> Themes
	{
		[CompilerGenerated]
		get
		{
			return h9F2QXB5O2k;
		}
		[CompilerGenerated]
		set
		{
			h9F2QXB5O2k = observableCollection;
		}
	}

	public FxhV0D9xxKsZanj5Yt0Z SelectedTheme
	{
		get
		{
			return nPc2Qc1f87F;
		}
		set
		{
			if (!object.Equals(objA, nPc2Qc1f87F))
			{
				nPc2Qc1f87F = objA;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x32DEA4F1 ^ 0x32DE368F));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1251569705 ^ -1251599029));
			}
		}
	}

	public bool ThemeIsSelected => SelectedTheme != null;

	[SpecialName]
	[CompilerGenerated]
	public Action<ChartTheme, bool> Ptl2QlC5NJU()
	{
		return ldm2QLegHAG;
	}

	[SpecialName]
	[CompilerGenerated]
	public void qIJ2Q4oClRp(Action<ChartTheme, bool> P_0)
	{
		ldm2QLegHAG = P_0;
	}

	public hFI3Kk2Q99FbdfaSsliM()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				EM6yK047kQZQ9um5nwCa(PropGrid.Columns[0], new GridLength(7.0, GridUnitType.Star));
				num = 2;
				continue;
			case 2:
				EM6yK047kQZQ9um5nwCa(PropGrid.Columns[1], new GridLength(3.0, GridUnitType.Star));
				return;
			}
			AZ07bS47N4HKwANaO7de(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x11D1040B ^ 0x11D1C6AB));
			Themes = new ObservableCollection<FxhV0D9xxKsZanj5Yt0Z>();
			nBQ2QYrJxqM();
			InitializeComponent();
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b != 0)
			{
				num = 1;
			}
		}
	}

	private void gMH2QGomJeR(object P_0, SelectionChangedEventArgs P_1)
	{
		if (SelectedTheme == null || !(SelectedTheme.UoY9xXA3gCm() == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4220DA8 ^ 0x42242D2)))
		{
			return;
		}
		SelectedTheme = null;
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			D1ei70475h5O7ceTiZhY(openFileDialog, wSpyaZ471JhUaTPmaw0s(0xAD5B8B3 ^ 0xAD5E8A1));
			OpenFileDialog openFileDialog2 = openFileDialog;
			if (openFileDialog2.ShowDialog() != true)
			{
				return;
			}
			int num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
			{
				num = 1;
			}
			ChartTheme chartTheme = default(ChartTheme);
			while (true)
			{
				switch (num)
				{
				case 2:
					chartTheme = inug6w9xygmyBdLc9sPv.TZv9xCX5nmF(openFileDialog2.FileName);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
					{
						num = 0;
					}
					continue;
				case 1:
					return;
				}
				if (chartTheme != null)
				{
					Theme.CopyTheme(chartTheme);
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
					{
						num = 1;
					}
					continue;
				}
				return;
			}
		}
		catch (Exception ex)
		{
			C1wgNI47ShWHSkHkcecq(ex);
		}
	}

	public void nBQ2QYrJxqM()
	{
		Themes.Clear();
		Themes.Add(new FxhV0D9xxKsZanj5Yt0Z(TigerTrade.Properties.Resources.CommonThemeLoadFromFile, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1192989954 ^ -1193007740), null));
		foreach (ChartTheme stdTheme in ChartTheme.StdThemes)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Themes.Add(new FxhV0D9xxKsZanj5Yt0Z(stdTheme.ThemeName, (string)FF642w47xbGjFoKKVCI9(stdTheme), stdTheme));
		}
		while (true)
		{
			List<ChartTheme>.Enumerator enumerator2 = inug6w9xygmyBdLc9sPv.ViW9xmxLwFn().GetEnumerator();
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			try
			{
				while (enumerator2.MoveNext())
				{
					ChartTheme current2 = enumerator2.Current;
					int num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					}
					Themes.Add(new FxhV0D9xxKsZanj5Yt0Z((string)yrsXjc47Lt2NOoCWZx2x(current2), (string)FF642w47xbGjFoKKVCI9(current2), current2));
				}
				return;
			}
			finally
			{
				((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
			}
		}
	}

	private void ApplyTheme()
	{
		if (SelectedTheme?.Theme != null)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Theme.CopyTheme(SelectedTheme.Theme);
		}
	}

	private void RemoveTheme()
	{
		if (SelectedTheme != null)
		{
			inug6w9xygmyBdLc9sPv.Remove(SelectedTheme.UoY9xXA3gCm());
			nBQ2QYrJxqM();
		}
	}

	private void SaveTheme()
	{
		HUQHiA2EsHqTOTOdqir7 hUQHiA2EsHqTOTOdqir = new HUQHiA2EsHqTOTOdqir7
		{
			Owner = this
		};
		bool? flag = hUQHiA2EsHqTOTOdqir.ShowDialog();
		bool flag2 = true;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
		{
			num = 0;
		}
		ChartTheme chartTheme = default(ChartTheme);
		SaveFileDialog saveFileDialog = default(SaveFileDialog);
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			default:
				if (flag == flag2 && !string.IsNullOrEmpty(hUQHiA2EsHqTOTOdqir.ThemeName))
				{
					num = 6;
					break;
				}
				return;
			case 1:
			{
				chartTheme.CopyTheme(Theme);
				if (!hUQHiA2EsHqTOTOdqir.dUp2EgBIm3b())
				{
					inug6w9xygmyBdLc9sPv.xyA9xKl3osr(chartTheme);
					nBQ2QYrJxqM();
					return;
				}
				SaveFileDialog obj = new SaveFileDialog
				{
					FileName = hUQHiA2EsHqTOTOdqir.ThemeName + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1309555870 ^ -1309568156)
				};
				D1ei70475h5O7ceTiZhY(obj, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--927068468 ^ 0x3741A126));
				saveFileDialog = obj;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
				{
					num = 5;
				}
				break;
			}
			case 3:
				return;
			case 6:
			{
				ChartTheme obj2 = new ChartTheme
				{
					ThemeID = Guid.NewGuid().ToString()
				};
				CVMwpp47e8TXhWukioL8(obj2, hUQHiA2EsHqTOTOdqir.ThemeName);
				chartTheme = obj2;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
				{
					num = 1;
				}
				break;
			}
			case 2:
			{
				OsSWvN47sgwkXZo9UiKw(saveFileDialog.FileName, Theme);
				int num2 = 4;
				num = num2;
				break;
			}
			case 5:
				flag = saveFileDialog.ShowDialog();
				flag2 = true;
				if (flag != flag2)
				{
					return;
				}
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void Bfv2QoclPwt(object P_0, RoutedEventArgs P_1)
	{
		string text = NNimTP47XjeaD2mbr08f((ButtonBase)P_0).ToString();
		int num;
		if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-60853733 ^ -60825345))
		{
			ApplyTheme();
			num = 3;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
			{
				num = 3;
			}
		}
		else
		{
			if (!bOtLSV47ceqMfIr1AgrB(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-490987856 ^ -490959796)))
			{
				goto IL_0109;
			}
			RemoveTheme();
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
			{
				num = 1;
			}
		}
		switch (num)
		{
		default:
			return;
		case 0:
			return;
		case 1:
			return;
		case 3:
			return;
		case 2:
			break;
		}
		goto IL_0109;
		IL_0109:
		if (bOtLSV47ceqMfIr1AgrB(text, wSpyaZ471JhUaTPmaw0s(-962524685 ^ -962487579)))
		{
			SaveTheme();
		}
	}

	private void LbI2Qva1FJ3(object P_0, RoutedEventArgs P_1)
	{
		if (Ptl2QlC5NJU() != null)
		{
			nQj2QeTZI6x.CopyTheme(Theme);
			Ptl2QlC5NJU()(Theme, arg2: true);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
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

	private void f342QB7Mm2K(object P_0, RoutedEventArgs P_1)
	{
		base.DialogResult = true;
		Close();
	}

	private void VlB2Qa7ywyf(object P_0, RoutedEventArgs P_1)
	{
		MnLxqK47jEy0VVjFONLU(Theme, nQj2QeTZI6x);
		Close();
	}

	public static bool mSY2Qi2EwYf(Window P_0, ChartTheme P_1, Action<ChartTheme, bool> P_2)
	{
		qyc4KFnMHJeZRr9CAiVT qyc4KFnMHJeZRr9CAiVT = new qyc4KFnMHJeZRr9CAiVT();
		qyc4KFnMHJeZRr9CAiVT.zQsnM9dsR66 = P_0;
		qyc4KFnMHJeZRr9CAiVT.dvVnMn7oydi = P_1;
		qyc4KFnMHJeZRr9CAiVT.eLCnMGdABmI = P_2;
		return qRUNhyHDDQmkuIovYJo1.R1XHD1KJGrd(delegate(hFI3Kk2Q99FbdfaSsliM w)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					w.Owner = qyc4KFnMHJeZRr9CAiVT.zQsnM9dsR66;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					w.Theme = qyc4KFnMHJeZRr9CAiVT.dvVnMn7oydi;
					w.qIJ2Q4oClRp(qyc4KFnMHJeZRr9CAiVT.eLCnMGdABmI);
					return;
				}
			}
		}) == true;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
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
			case 1:
			{
				if (IVl2Qj2EWhP)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
					{
						num2 = 0;
					}
					break;
				}
				IVl2Qj2EWhP = true;
				Uri uri = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24B0B9E6 ^ 0x24B07B22), UriKind.Relative);
				zRf0fp47E6j8BcGWO10w(this, uri);
				return;
			}
			case 0:
				return;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)sgq4lD47Qunqw932cv7R(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 3:
				switch (P_0)
				{
				case 4:
					x20yYf47dKNHrMddEXel((Button)P_1, new RoutedEventHandler(Bfv2QoclPwt));
					return;
				case 1:
					ComboBoxThemes = (ComboBox)P_1;
					ComboBoxThemes.SelectionChanged += gMH2QGomJeR;
					return;
				case 2:
					((Button)P_1).Click += Bfv2QoclPwt;
					return;
				case 3:
					((Button)P_1).Click += Bfv2QoclPwt;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					((Button)P_1).Click += LbI2Qva1FJ3;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 != 0)
					{
						num2 = 4;
					}
					break;
				default:
					num2 = 2;
					break;
				case 6:
					x20yYf47dKNHrMddEXel((Button)P_1, new RoutedEventHandler(f342QB7Mm2K));
					return;
				case 8:
					PropGrid = (VoU9lv2z05uTExIsC3Ip)P_1;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
					{
						num2 = 5;
					}
					break;
				case 7:
					x20yYf47dKNHrMddEXel((Button)P_1, new RoutedEventHandler(VlB2Qa7ywyf));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
					{
						num2 = 0;
					}
					break;
				}
				break;
			case 4:
				return;
			case 5:
				return;
			case 2:
				IVl2Qj2EWhP = true;
				return;
			case 0:
				return;
			}
		}
	}

	static hFI3Kk2Q99FbdfaSsliM()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool oFUCGd47DOGNxYbjJebX()
	{
		return ox0lNk474qUyDHxhkBho == null;
	}

	internal static hFI3Kk2Q99FbdfaSsliM M3R9hZ47bQcxMpeSsswR()
	{
		return ox0lNk474qUyDHxhkBho;
	}

	internal static void AZ07bS47N4HKwANaO7de(object P_0)
	{
		mycy5LHEu3qqvRcny9Mb.oh3HQGPC2PW((string)P_0);
	}

	internal static void EM6yK047kQZQ9um5nwCa(object P_0, GridLength P_1)
	{
		((TreeListViewColumn)P_0).Width = P_1;
	}

	internal static object wSpyaZ471JhUaTPmaw0s(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void D1ei70475h5O7ceTiZhY(object P_0, object P_1)
	{
		((FileDialog)P_0).Filter = (string)P_1;
	}

	internal static void C1wgNI47ShWHSkHkcecq(object P_0)
	{
		LogManager.WriteError((Exception)P_0);
	}

	internal static object FF642w47xbGjFoKKVCI9(object P_0)
	{
		return ((ChartTheme)P_0).ThemeID;
	}

	internal static object yrsXjc47Lt2NOoCWZx2x(object P_0)
	{
		return ((ChartTheme)P_0).ThemeName;
	}

	internal static void CVMwpp47e8TXhWukioL8(object P_0, object P_1)
	{
		((ChartTheme)P_0).ThemeName = (string)P_1;
	}

	internal static void OsSWvN47sgwkXZo9UiKw(object P_0, object P_1)
	{
		inug6w9xygmyBdLc9sPv.lHJ9xrVXX36((string)P_0, (ChartTheme)P_1);
	}

	internal static object NNimTP47XjeaD2mbr08f(object P_0)
	{
		return ((ButtonBase)P_0).CommandParameter;
	}

	internal static bool bOtLSV47ceqMfIr1AgrB(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void MnLxqK47jEy0VVjFONLU(object P_0, object P_1)
	{
		((ChartTheme)P_0).CopyTheme((ChartTheme)P_1);
	}

	internal static void zRf0fp47E6j8BcGWO10w(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static object sgq4lD47Qunqw932cv7R(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void x20yYf47dKNHrMddEXel(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}
}
