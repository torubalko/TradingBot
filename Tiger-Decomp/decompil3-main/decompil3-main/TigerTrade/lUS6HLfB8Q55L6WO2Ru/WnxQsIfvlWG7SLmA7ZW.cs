using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace lUS6HLfB8Q55L6WO2Ru;

public class WnxQsIfvlWG7SLmA7ZW : Window, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct u1qvvAnl7TfxoJloeXgb : IAsyncStateMachine
	{
		public int UdYnl8qVYXN;

		public AsyncVoidMethodBuilder pI9nlAKRqMm;

		public WnxQsIfvlWG7SLmA7ZW T39nlP55wgK;

		private TaskAwaiter tSYnlJdanmx;

		internal static object QBVwBEbuZWAkJLw0IWSU;

		private void MoveNext()
		{
			int num = UdYnl8qVYXN;
			WnxQsIfvlWG7SLmA7ZW CS_0024_003C_003E8__locals1 = T39nlP55wgK;
			try
			{
				TaskAwaiter awaiter;
				int num2;
				if (num == 0)
				{
					awaiter = tSYnlJdanmx;
					tSYnlJdanmx = default(TaskAwaiter);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
					{
						num2 = 0;
					}
					goto IL_0051;
				}
				goto IL_00fc;
				IL_004d:
				int num3;
				num2 = num3;
				goto IL_0051;
				IL_0142:
				num = (UdYnl8qVYXN = 0);
				tSYnlJdanmx = awaiter;
				num3 = 2;
				goto IL_004d;
				IL_0051:
				while (true)
				{
					switch (num2)
					{
					default:
						num = (UdYnl8qVYXN = -1);
						goto IL_008b;
					case 3:
						if (!awaiter.IsCompleted)
						{
							num2 = 4;
							continue;
						}
						goto IL_008b;
					case 2:
						pI9nlAKRqMm.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 1:
						break;
					case 4:
						goto IL_0142;
						IL_008b:
						awaiter.GetResult();
						goto end_IL_0041;
					}
					break;
				}
				goto IL_00fc;
				IL_00fc:
				awaiter = Task.Run(delegate
				{
					DDZRC5lZZ1meEu96W8lJ(1000);
					Application.Current.Dispatcher.BeginInvoke((Action)delegate
					{
						IhMVqBlZVYBuF5cQbenp(CS_0024_003C_003E8__locals1);
					});
				}).GetAwaiter();
				num3 = 3;
				goto IL_004d;
				end_IL_0041:;
			}
			catch (Exception exception)
			{
				UdYnl8qVYXN = -2;
				pI9nlAKRqMm.SetException(exception);
				int num4 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
				return;
			}
			UdYnl8qVYXN = -2;
			int num5 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 != 0)
			{
				num5 = 0;
			}
			while (true)
			{
				switch (num5)
				{
				case 1:
					return;
				}
				pI9nlAKRqMm.SetResult();
				num5 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
				{
					num5 = 1;
				}
			}
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			pI9nlAKRqMm.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static u1qvvAnl7TfxoJloeXgb()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool Ek4ts3buV738XHCJGXVA()
		{
			return QBVwBEbuZWAkJLw0IWSU == null;
		}

		internal static object hjg0IQbuCmDVOlTy55mg()
		{
			return QBVwBEbuZWAkJLw0IWSU;
		}
	}

	internal ProgressBar pb;

	private bool IcBf4cYyvG;

	private static WnxQsIfvlWG7SLmA7ZW vxxFVklZtnLvPdjtOBKh;

	public WnxQsIfvlWG7SLmA7ZW()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		InitializeComponent();
		base.Loaded += aSOfa2RiGd;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[AsyncStateMachine(typeof(u1qvvAnl7TfxoJloeXgb))]
	private void aSOfa2RiGd(object P_0, RoutedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		u1qvvAnl7TfxoJloeXgb stateMachine = default(u1qvvAnl7TfxoJloeXgb);
		while (true)
		{
			switch (num2)
			{
			case 1:
				stateMachine.pI9nlAKRqMm = AYfs23lZyCTE1u3qJFYZ();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				stateMachine.T39nlP55wgK = this;
				stateMachine.UdYnl8qVYXN = -1;
				stateMachine.pI9nlAKRqMm.Start(ref stateMachine);
				return;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!IcBf4cYyvG)
		{
			IcBf4cYyvG = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--927068468 ^ 0x3741F9E0), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c != 0)
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		if (P_0 != 1)
		{
			IcBf4cYyvG = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			pb = (ProgressBar)P_1;
		}
	}

	[CompilerGenerated]
	private void gNOfihYZbd()
	{
		DDZRC5lZZ1meEu96W8lJ(1000);
		Application.Current.Dispatcher.BeginInvoke((Action)delegate
		{
			IhMVqBlZVYBuF5cQbenp(this);
		});
	}

	[CompilerGenerated]
	private void vv4fldfT4A()
	{
		IhMVqBlZVYBuF5cQbenp(this);
	}

	static WnxQsIfvlWG7SLmA7ZW()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool Nj8jjvlZUdulUUGFwsvh()
	{
		return vxxFVklZtnLvPdjtOBKh == null;
	}

	internal static WnxQsIfvlWG7SLmA7ZW CQRacPlZTfDvE8MQ6B0S()
	{
		return vxxFVklZtnLvPdjtOBKh;
	}

	internal static AsyncVoidMethodBuilder AYfs23lZyCTE1u3qJFYZ()
	{
		return AsyncVoidMethodBuilder.Create();
	}

	internal static void DDZRC5lZZ1meEu96W8lJ(int P_0)
	{
		Thread.Sleep(P_0);
	}

	internal static void IhMVqBlZVYBuF5cQbenp(object P_0)
	{
		((Window)P_0).Close();
	}
}
