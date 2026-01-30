using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using bnYBBQ4RRnJxHbvk4Rm;
using ECOEgqlSad8NUJZ2Dr9n;
using EnbFBYDM2yQV9ADoCAu;
using euNCE9lsfjbYKw86YuS;
using Jf1VIKDZINSDRBiuBQc;
using kdr31Pb18Xnr06fR8JM;
using pBQZTE4DLtk18IAiFuJ;
using TuAMtrl1Nd3XoZQQUXf0;
using vG0WidHawbhpKdkcelf8;
using YEElclH3lvRpuu1MG0YY;

namespace TigerTrade.UI.ToolControls.Accounts;

internal sealed class AccountsControl : mMZmHD44odQv31rC92N, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class PAKYZ1nbd4UZv8IcKxcS
	{
		public static readonly PAKYZ1nbd4UZv8IcKxcS u39nbRjOsjd;

		public static Predicate<object> PHJnb63A4gC;

		private static PAKYZ1nbd4UZv8IcKxcS xnxdb6NHBhHYICyHABpf;

		static PAKYZ1nbd4UZv8IcKxcS()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					LYNM5kNHlQPF4d1vjCGf();
					u39nbRjOsjd = new PAKYZ1nbd4UZv8IcKxcS();
					return;
				}
			}
		}

		public PAKYZ1nbd4UZv8IcKxcS()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool epknbgcWJQl(object o)
		{
			if (o is eakZg1DyNSTxJkfMByw eakZg1DyNSTxJkfMByw)
			{
				return eakZg1DyNSTxJkfMByw.IsVisible;
			}
			return false;
		}

		internal static void LYNM5kNHlQPF4d1vjCGf()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool WcNa4SNHa2km5CAkem6V()
		{
			return xnxdb6NHBhHYICyHABpf == null;
		}

		internal static PAKYZ1nbd4UZv8IcKxcS hNRPoQNHim66jBVE3els()
		{
			return xnxdb6NHBhHYICyHABpf;
		}
	}

	private CollectionViewSource viewSource;

	internal u0GAIHHahyHxCr1XJKud DataGrid;

	private bool _contentLoaded;

	internal static AccountsControl KGIu2Ml3o8v75A6TgGk9;

	public urBSmSD6tHrGPCBpwFe ViewModel { get; }

	public AccountsControl()
	{
		twwAvSl3aq5EFOgBYxex();
		base._002Ector(OaCAQw4g9HMlYQ2QToH.Accounts);
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				ViewModel = new urBSmSD6tHrGPCBpwFe();
				InitializeComponent();
				viewSource = (CollectionViewSource)base.Resources[QeaC3Nl3iuBo7D4GknPm(-1416986301 ^ -1416978611)];
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
				{
					num = 0;
				}
				break;
			default:
				((ICollectionView)bxUkj1l3lMkGMa7ebpZD(viewSource)).Filter = (object o) => o is eakZg1DyNSTxJkfMByw eakZg1DyNSTxJkfMByw && eakZg1DyNSTxJkfMByw.IsVisible;
				return;
			}
		}
	}

	private void DataGrid_OnMouseRightButtonUp(object sender, MouseButtonEventArgs e)
	{
		int num = 4;
		DependencyObject dependencyObject = default(DependencyObject);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
				case 3:
					if (dependencyObject == null || dependencyObject is DataGridCell || dependencyObject is DataGridColumnHeader)
					{
						if (!(dependencyObject is DataGridColumnHeader))
						{
							num2 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto default;
					}
					dependencyObject = VisualTreeHelper.GetParent(dependencyObject);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
					{
						num2 = 2;
					}
					continue;
				default:
					DataGrid.rWAHi2QjAqn();
					return;
				case 4:
					break;
				}
				break;
			}
			dependencyObject = (DependencyObject)e.OriginalSource;
			num = 3;
		}
	}

	public override void Deserialize(string workspaceID, bBd5AkleWrv2LnDCh5X settings)
	{
		DataGrid.to8HinyXyDi(b0Y45wEcGs(workspaceID));
	}

	public override void Serialize(string workspaceID, bBd5AkleWrv2LnDCh5X settings)
	{
		DataGrid.kUmHi9sIHwh(b0Y45wEcGs(workspaceID));
	}

	private void MenuButton_Click(object sender, RoutedEventArgs e)
	{
		if (!(((ButtonBase)sender).CommandParameter.ToString() == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2074141628 ^ -2074135814)))
		{
			return;
		}
		Xi7715l34rc7Qr5YxOVH(base.ParentWindow);
		XhswApH3iouMedcVCcQ4.vAZH34trGu5();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
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
			XhswApH3iouMedcVCcQ4.H3VH3DTMgWf();
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
			{
				num = 1;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6F7F734B ^ 0x6F7F5DA3), UriKind.Relative);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		if (connectionId != 1)
		{
			if (connectionId != 2)
			{
				_contentLoaded = true;
				return;
			}
			DataGrid = (u0GAIHHahyHxCr1XJKud)target;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
			{
				num = 0;
			}
		}
		else
		{
			((Button)target).Click += MenuButton_Click;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
			{
				num = 1;
			}
		}
		switch (num)
		{
		case 1:
			break;
		case 0:
			break;
		}
	}

	static AccountsControl()
	{
		wqkvNBl3D6KpLq2vrgGK();
	}

	internal static void twwAvSl3aq5EFOgBYxex()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object QeaC3Nl3iuBo7D4GknPm(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object bxUkj1l3lMkGMa7ebpZD(object P_0)
	{
		return ((CollectionViewSource)P_0).View;
	}

	internal static bool JJrRIxl3vWuPaLEui87f()
	{
		return KGIu2Ml3o8v75A6TgGk9 == null;
	}

	internal static AccountsControl rO07qOl3B60lakOZTFS9()
	{
		return KGIu2Ml3o8v75A6TgGk9;
	}

	internal static void Xi7715l34rc7Qr5YxOVH(object P_0)
	{
		IeR8GIbkxpRdsiC2GtW.XYDb6RbGFn((Window)P_0);
	}

	internal static void wqkvNBl3D6KpLq2vrgGK()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
