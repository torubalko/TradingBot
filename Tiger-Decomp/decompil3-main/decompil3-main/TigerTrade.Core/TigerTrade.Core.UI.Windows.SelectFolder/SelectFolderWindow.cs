using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Threading;
using ActiproSoftware.Windows.Controls.Grids;
using EDugZvNwF6e5LYsQZ3C5;
using nff6NvN8pYC4xeKDOd05;
using OrDDjnN8w7riQsQI5MiI;
using PN1Qd8G9bJBwNRXWTdhj;
using TigerTrade.Core.Properties;

namespace TigerTrade.Core.UI.Windows.SelectFolder;

public sealed class SelectFolderWindow : Window, IComponentConnector
{
	[CompilerGenerated]
	private sealed class IWEqmwGnhR7R4EQsi7kK
	{
		public SelectFolderWindow LwFGn8MkloM;

		public XlqaOmG9DOfp7AvVTOS8 GtoGnAicamE;

		private static IWEqmwGnhR7R4EQsi7kK KIsy69kGWGo89EjTEFyP;

		public IWEqmwGnhR7R4EQsi7kK()
		{
			LuQBY9kGTwgsxT23f3WM();
			base._002Ector();
		}

		internal void svjGnwvkGRx()
		{
			wpjcjvGnPTXW0jnT2I0C wpjcjvGnPTXW0jnT2I0C = new wpjcjvGnPTXW0jnT2I0C
			{
				M4cGn3C4IRy = this,
				LZYGnFoYTrD = null
			};
			int num = 1;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_3003f96c370e481ba4f92d4c1a0a7ae5 == 0)
			{
				num = 1;
			}
			switch (num)
			{
			case 1:
				try
				{
					wpjcjvGnPTXW0jnT2I0C.LZYGnFoYTrD = (string[])OkQnQtkGyCKTsGUKwGsU();
				}
				catch (IOException)
				{
				}
				break;
			}
			LwFGn8MkloM.Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(wpjcjvGnPTXW0jnT2I0C.EZxGnJp4KN7));
		}

		internal void iwyGn7SklT7()
		{
			int num = 1;
			int num2 = num;
			qNQY6MGnpDLrlABMGl4v qNQY6MGnpDLrlABMGl4v = default(qNQY6MGnpDLrlABMGl4v);
			while (true)
			{
				switch (num2)
				{
				case 2:
					qNQY6MGnpDLrlABMGl4v.k9aGnziQT34 = null;
					try
					{
						qNQY6MGnpDLrlABMGl4v.k9aGnziQT34 = Directory.GetDirectories(GtoGnAicamE.Path);
					}
					catch (IOException)
					{
					}
					((Dispatcher)DZcqPfkGZORanXl0YxU5(LwFGn8MkloM)).BeginInvoke(DispatcherPriority.Background, (Delegate)new Action(qNQY6MGnpDLrlABMGl4v.UphGnuTt1Dm));
					return;
				case 1:
					qNQY6MGnpDLrlABMGl4v = new qNQY6MGnpDLrlABMGl4v();
					num2 = 0;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_caa8a213c8b9430d9f7c3714c3c1b2a3 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					qNQY6MGnpDLrlABMGl4v.KWDGG0cNir8 = this;
					num2 = 0;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_08b8b644b9994e7ca961743f659e4e03 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		static IWEqmwGnhR7R4EQsi7kK()
		{
			wKJQoVkGV5yPIBp1CZRD();
			a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static void LuQBY9kGTwgsxT23f3WM()
		{
			PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
		}

		internal static bool hf6QLPkGtG1niMb8FaSd()
		{
			return KIsy69kGWGo89EjTEFyP == null;
		}

		internal static IWEqmwGnhR7R4EQsi7kK TQsgMOkGUMIywQY3QYs5()
		{
			return KIsy69kGWGo89EjTEFyP;
		}

		internal static object OkQnQtkGyCKTsGUKwGsU()
		{
			return Environment.GetLogicalDrives();
		}

		internal static object DZcqPfkGZORanXl0YxU5(object P_0)
		{
			return ((DispatcherObject)P_0).Dispatcher;
		}

		internal static void wKJQoVkGV5yPIBp1CZRD()
		{
			RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
		}
	}

	[CompilerGenerated]
	private sealed class wpjcjvGnPTXW0jnT2I0C
	{
		public string[] LZYGnFoYTrD;

		public IWEqmwGnhR7R4EQsi7kK M4cGn3C4IRy;

		private static wpjcjvGnPTXW0jnT2I0C piKMVNkGCAHpXdmSVbs2;

		public wpjcjvGnPTXW0jnT2I0C()
		{
			GQLSIykGmtlReNHa8n01();
			base._002Ector();
		}

		internal void EZxGnJp4KN7()
		{
			TO5SyukGhZbMRXSJ57g5(M4cGn3C4IRy.GtoGnAicamE.Children);
			if (LZYGnFoYTrD != null)
			{
				string[] array = LZYGnFoYTrD;
				int num = 0;
				int num2 = 2;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_583676900d234e42b13914d805f1fbd3 != 0)
				{
					num2 = 0;
				}
				XlqaOmG9DOfp7AvVTOS8 item = default(XlqaOmG9DOfp7AvVTOS8);
				while (true)
				{
					switch (num2)
					{
					case 2:
					case 3:
					{
						if (num >= array.Length)
						{
							num2 = 0;
							if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_25c30bc541e143758adfffff1fb8d41e != 0)
							{
								num2 = 0;
							}
							continue;
						}
						string text = array[num];
						item = new XlqaOmG9DOfp7AvVTOS8
						{
							Name = text,
							Path = text
						};
						num2 = 1;
						if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_1291cd35ffa748008aac4f936319d8b5 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					case 1:
					{
						M4cGn3C4IRy.GtoGnAicamE.Children.Add(item);
						num++;
						int num3 = 3;
						num2 = num3;
						continue;
					}
					}
					break;
				}
			}
			M4cGn3C4IRy.GtoGnAicamE.IsLoading = false;
		}

		static wpjcjvGnPTXW0jnT2I0C()
		{
			RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
			a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static void GQLSIykGmtlReNHa8n01()
		{
			PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
		}

		internal static bool w7HkS0kGrUkmyCaTFsT0()
		{
			return piKMVNkGCAHpXdmSVbs2 == null;
		}

		internal static wpjcjvGnPTXW0jnT2I0C JCCVkEkGKOrNu2rnuLpy()
		{
			return piKMVNkGCAHpXdmSVbs2;
		}

		internal static void TO5SyukGhZbMRXSJ57g5(object P_0)
		{
			((Collection<XlqaOmG9DOfp7AvVTOS8>)P_0).Clear();
		}
	}

	[CompilerGenerated]
	private sealed class qNQY6MGnpDLrlABMGl4v
	{
		public string[] k9aGnziQT34;

		public IWEqmwGnhR7R4EQsi7kK KWDGG0cNir8;

		internal static qNQY6MGnpDLrlABMGl4v QnFQ1YkGwcvLlMRPyCI1;

		public qNQY6MGnpDLrlABMGl4v()
		{
			PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
			base._002Ector();
		}

		internal void UphGnuTt1Dm()
		{
			kOSYHCkGAkhAlxZjDpoB(KWDGG0cNir8.GtoGnAicamE.Children);
			if (k9aGnziQT34 != null)
			{
				int num = 0;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_b4f383c2ef60442582501c46cbd6e5c8 == 0)
				{
					num = 1;
				}
				string text = default(string);
				XlqaOmG9DOfp7AvVTOS8 item = default(XlqaOmG9DOfp7AvVTOS8);
				string[] array = default(string[]);
				int num2 = default(int);
				while (true)
				{
					switch (num)
					{
					case 2:
						if ((y2IlpRkGP2dq11p7vAtB(new DirectoryInfo(text)) & FileAttributes.Hidden) != FileAttributes.Hidden)
						{
							item = new XlqaOmG9DOfp7AvVTOS8
							{
								Name = Path.GetFileName(text),
								Path = text
							};
							num = 0;
							if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_52c6a6e4ab8247c1a9fa3a8313af5589 != 0)
							{
								num = 0;
							}
							continue;
						}
						goto IL_0027;
					case 1:
					{
						array = k9aGnziQT34;
						num2 = 0;
						int num3 = 3;
						num = num3;
						continue;
					}
					case 4:
						text = array[num2];
						num = 2;
						continue;
					default:
						KWDGG0cNir8.GtoGnAicamE.Children.Add(item);
						goto IL_0027;
					case 3:
						{
							if (num2 >= array.Length)
							{
								break;
							}
							goto case 4;
						}
						IL_0027:
						num2++;
						goto case 3;
					}
					break;
				}
			}
			KWDGG0cNir8.GtoGnAicamE.IsLoading = false;
		}

		static qNQY6MGnpDLrlABMGl4v()
		{
			cej8lOkGJT9MMpJYphPc();
			a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool Tfh5nqkG7Ts1fKwVjWh1()
		{
			return QnFQ1YkGwcvLlMRPyCI1 == null;
		}

		internal static qNQY6MGnpDLrlABMGl4v srGycakG8TVb62V8OSUP()
		{
			return QnFQ1YkGwcvLlMRPyCI1;
		}

		internal static void kOSYHCkGAkhAlxZjDpoB(object P_0)
		{
			((Collection<XlqaOmG9DOfp7AvVTOS8>)P_0).Clear();
		}

		internal static FileAttributes y2IlpRkGP2dq11p7vAtB(object P_0)
		{
			return ((FileSystemInfo)P_0).Attributes;
		}

		internal static void cej8lOkGJT9MMpJYphPc()
		{
			RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
		}
	}

	private readonly XlqaOmG9DOfp7AvVTOS8 _rootNodeModel;

	internal Button ButtonOk;

	internal Button ButtonCancel;

	internal TreeListBox TreeListBox;

	private bool _contentLoaded;

	private static SelectFolderWindow id6jFDk9TD7jVQiGHVgt;

	public string SelectedFolder { get; set; }

	public SelectFolderWindow()
	{
		u4E4smk9VA9fOlRK9EqZ();
		base._002Ector();
		InitializeComponent();
		_rootNodeModel = new XlqaOmG9DOfp7AvVTOS8
		{
			Name = (string)EhmK2Ik9C3RjHWDGsjWV()
		};
		int num = 0;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_17f48e9409d64a0386c570d11c68f824 == 0)
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
			TreeListBox.RootItem = _rootNodeModel;
			_rootNodeModel.IsExpanded = true;
			num = 0;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_3251a113e608497585c7df3489d778ef != 0)
			{
				num = 1;
			}
		}
	}

	private void OnTreeListBoxItemExpanding(object sender, TreeListBoxItemExpansionEventArgs e)
	{
		IWEqmwGnhR7R4EQsi7kK CS_0024_003C_003E8__locals10 = new IWEqmwGnhR7R4EQsi7kK();
		CS_0024_003C_003E8__locals10.LwFGn8MkloM = this;
		CS_0024_003C_003E8__locals10.GtoGnAicamE = e.Item as XlqaOmG9DOfp7AvVTOS8;
		int num = 2;
		int num2 = num;
		while (true)
		{
			Task task;
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				if (CS_0024_003C_003E8__locals10.GtoGnAicamE.Children.Count <= 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_dbd670bee0e840219277072e73777cbe != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 4:
				task = new Task(delegate
				{
					wpjcjvGnPTXW0jnT2I0C wpjcjvGnPTXW0jnT2I0C = new wpjcjvGnPTXW0jnT2I0C();
					wpjcjvGnPTXW0jnT2I0C.M4cGn3C4IRy = CS_0024_003C_003E8__locals10;
					wpjcjvGnPTXW0jnT2I0C.LZYGnFoYTrD = null;
					int num3 = 1;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_3003f96c370e481ba4f92d4c1a0a7ae5 == 0)
					{
						num3 = 1;
					}
					switch (num3)
					{
					case 1:
						try
						{
							wpjcjvGnPTXW0jnT2I0C.LZYGnFoYTrD = (string[])IWEqmwGnhR7R4EQsi7kK.OkQnQtkGyCKTsGUKwGsU();
						}
						catch (IOException)
						{
						}
						break;
					}
					CS_0024_003C_003E8__locals10.LwFGn8MkloM.Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(wpjcjvGnPTXW0jnT2I0C.EZxGnJp4KN7));
				});
				goto IL_0028;
			case 3:
				return;
			case 1:
				{
					VXaGD0k9rBdcvOGYqMdZ(CS_0024_003C_003E8__locals10.GtoGnAicamE, true);
					task = null;
					if (CS_0024_003C_003E8__locals10.GtoGnAicamE == _rootNodeModel)
					{
						num2 = 4;
						break;
					}
					task = new Task(delegate
					{
						int num3 = 1;
						int num4 = num3;
						qNQY6MGnpDLrlABMGl4v qNQY6MGnpDLrlABMGl4v = default(qNQY6MGnpDLrlABMGl4v);
						while (true)
						{
							switch (num4)
							{
							case 2:
								qNQY6MGnpDLrlABMGl4v.k9aGnziQT34 = null;
								try
								{
									qNQY6MGnpDLrlABMGl4v.k9aGnziQT34 = Directory.GetDirectories(CS_0024_003C_003E8__locals10.GtoGnAicamE.Path);
								}
								catch (IOException)
								{
								}
								((Dispatcher)IWEqmwGnhR7R4EQsi7kK.DZcqPfkGZORanXl0YxU5(CS_0024_003C_003E8__locals10.LwFGn8MkloM)).BeginInvoke(DispatcherPriority.Background, (Delegate)new Action(qNQY6MGnpDLrlABMGl4v.UphGnuTt1Dm));
								return;
							case 1:
								qNQY6MGnpDLrlABMGl4v = new qNQY6MGnpDLrlABMGl4v();
								num4 = 0;
								if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_caa8a213c8b9430d9f7c3714c3c1b2a3 == 0)
								{
									num4 = 0;
								}
								break;
							default:
								qNQY6MGnpDLrlABMGl4v.KWDGG0cNir8 = CS_0024_003C_003E8__locals10;
								num4 = 0;
								if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_08b8b644b9994e7ca961743f659e4e03 != 0)
								{
									num4 = 2;
								}
								break;
							}
						}
					});
					goto IL_0028;
				}
				IL_0028:
				task.Start();
				num2 = 0;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_2e8f9d59c4ed4588bb0181fd18668558 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void ButtonOk_Click(object sender, RoutedEventArgs e)
	{
		base.DialogResult = true;
		sPWSWck9KlmEPIoCTydI(this);
	}

	private void TreeListBox_ItemSelecting(object sender, TreeListBoxItemEventArgs e)
	{
		if (Jimpmik9mQLNTqTWSSRC(e) is XlqaOmG9DOfp7AvVTOS8 { Path: not null } xlqaOmG9DOfp7AvVTOS)
		{
			SelectedFolder = xlqaOmG9DOfp7AvVTOS.Path;
			int num = 0;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_d9c7ae7fb1634a7eb31f7674bad7490f != 0)
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

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri((string)cKFlgLk9hk8v1UfHMxQ8(0x741B85CB ^ 0x741B82F7), UriKind.Relative);
			int num = 0;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_dcf268e092ac4c578bd712a783bfb281 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			w227urk9wCnRIUPxv3lX(this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				tCo6tQk973aYWLmjvQJB(ButtonOk, new RoutedEventHandler(ButtonOk_Click));
				return;
			case 4:
				switch (connectionId)
				{
				default:
					num2 = 3;
					continue;
				case 3:
					TreeListBox = (TreeListBox)target;
					TreeListBox.ItemExpanding += OnTreeListBoxItemExpanding;
					num2 = 0;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_407a936cdcee468f8f1b7daf91c47727 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					ButtonCancel = (Button)target;
					return;
				case 1:
					break;
				}
				break;
			case 3:
				_contentLoaded = true;
				return;
			default:
				TreeListBox.ItemSelecting += TreeListBox_ItemSelecting;
				return;
			case 1:
				break;
			}
			ButtonOk = (Button)target;
			num2 = 2;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_0ef8be99fae94c90b579a4d7752c6260 != 0)
			{
				num2 = 1;
			}
		}
	}

	static SelectFolderWindow()
	{
		MjrkRdk98TTupmfOhm58();
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool mEnVnCk9ykQt8S2xreJV()
	{
		return id6jFDk9TD7jVQiGHVgt == null;
	}

	internal static SelectFolderWindow TeNRgCk9Z5iePtTFWkNY()
	{
		return id6jFDk9TD7jVQiGHVgt;
	}

	internal static void u4E4smk9VA9fOlRK9EqZ()
	{
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
	}

	internal static object EhmK2Ik9C3RjHWDGsjWV()
	{
		return TigerTrade.Core.Properties.Resources.SelectFolderWindowRootFolder;
	}

	internal static void VXaGD0k9rBdcvOGYqMdZ(object P_0, bool P_1)
	{
		((XlqaOmG9DOfp7AvVTOS8)P_0).IsLoading = P_1;
	}

	internal static void sPWSWck9KlmEPIoCTydI(object P_0)
	{
		((Window)P_0).Close();
	}

	internal static object Jimpmik9mQLNTqTWSSRC(object P_0)
	{
		return ((TreeListBoxItemEventArgs)P_0).Item;
	}

	internal static object cKFlgLk9hk8v1UfHMxQ8(int P_0)
	{
		return RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(P_0);
	}

	internal static void w227urk9wCnRIUPxv3lX(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static void tCo6tQk973aYWLmjvQJB(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}

	internal static void MjrkRdk98TTupmfOhm58()
	{
		RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
	}
}
