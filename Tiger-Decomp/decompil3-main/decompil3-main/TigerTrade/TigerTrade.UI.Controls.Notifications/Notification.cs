using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using E4WgbSHDB8PvMrmn1Ivi;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using U2AoR19TNRFWN9WoaNy;
using xfdMo0lS4TP9pN36Goka;

namespace TigerTrade.UI.Controls.Notifications;

[TemplatePart(Name = "PART_CloseButton", Type = typeof(Button))]
internal sealed class Notification : ContentControl
{
	[CompilerGenerated]
	private sealed class PdOZ7vnIZ32LyHvCXwVj
	{
		public Button SRcnICyas61;

		private static PdOZ7vnIZ32LyHvCXwVj LVJ3LrN1zuAUN7o6MwW6;

		public PdOZ7vnIZ32LyHvCXwVj()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal void AuxnIVOyT8s(object sender, RoutedEventArgs args)
		{
			KUIQKFHDvnXGoCOabJCv.Y4PHDagtCgH<Notification>(SRcnICyas61)?.Close();
		}

		static PdOZ7vnIZ32LyHvCXwVj()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool MywNc2N50asXeOaMMdw8()
		{
			return LVJ3LrN1zuAUN7o6MwW6 == null;
		}

		internal static PdOZ7vnIZ32LyHvCXwVj qI4ZgqN524vA9LBQCvPl()
		{
			return LVJ3LrN1zuAUN7o6MwW6;
		}
	}

	[CompilerGenerated]
	private sealed class BmaptynIrCR5ghAfFe5j
	{
		public Storyboard vsmnIm3xH7x;

		internal static BmaptynIrCR5ghAfFe5j CdWkQPN5Hvhrt6TKYCpx;

		public BmaptynIrCR5ghAfFe5j()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal TimeSpan qTunIKVnldg(Timeline ch)
		{
			return n9IsyGN5nvt9usouFbOc(ch.Duration.TimeSpan, vsmnIm3xH7x.BeginTime ?? TimeSpan.Zero);
		}

		static BmaptynIrCR5ghAfFe5j()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool U8ACG3N5feQNYB6hC3S8()
		{
			return CdWkQPN5Hvhrt6TKYCpx == null;
		}

		internal static BmaptynIrCR5ghAfFe5j vOYZGUN59yxn1dCZWUmq()
		{
			return CdWkQPN5Hvhrt6TKYCpx;
		}

		internal static TimeSpan n9IsyGN5nvt9usouFbOc(TimeSpan P_0, TimeSpan P_1)
		{
			return P_0 + P_1;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class U8wyvCnIhbuqdWjjk47k
	{
		public static readonly U8wyvCnIhbuqdWjjk47k Ow1nIAO8Tqr;

		public static Func<EventTrigger, bool> V9QnIPOAw52;

		public static Func<BeginStoryboard, Storyboard> v0MnIJyY8lk;

		public static Func<Storyboard, long> hLDnIFgGsEo;

		private static U8wyvCnIhbuqdWjjk47k K2w0eiN5GCdxoRlMBdBO;

		static U8wyvCnIhbuqdWjjk47k()
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
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
					Ow1nIAO8Tqr = new U8wyvCnIhbuqdWjjk47k();
					return;
				}
			}
		}

		public U8wyvCnIhbuqdWjjk47k()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool kibnIwQ3vvq(EventTrigger t)
		{
			return t.RoutedEvent == NotificationCloseInvokedEvent;
		}

		internal Storyboard oIBnI7cccop(BeginStoryboard a)
		{
			return a.Storyboard;
		}

		internal long x06nI8jkQtD(Storyboard s)
		{
			int num = 1;
			int num2 = num;
			BmaptynIrCR5ghAfFe5j bmaptynIrCR5ghAfFe5j = default(BmaptynIrCR5ghAfFe5j);
			Duration duration = default(Duration);
			TimeSpan timeSpan;
			while (true)
			{
				switch (num2)
				{
				case 1:
					bmaptynIrCR5ghAfFe5j = new BmaptynIrCR5ghAfFe5j();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					duration = e5paPyN5vftMbQgbkqEM(bmaptynIrCR5ghAfFe5j.vsmnIm3xH7x);
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 != 0)
					{
						num2 = 3;
					}
					continue;
				default:
					bmaptynIrCR5ghAfFe5j.vsmnIm3xH7x = s;
					duration = bmaptynIrCR5ghAfFe5j.vsmnIm3xH7x.Duration;
					if (duration.HasTimeSpan)
					{
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					timeSpan = TimeSpan.MaxValue;
					break;
				case 3:
					timeSpan = duration.TimeSpan + (bmaptynIrCR5ghAfFe5j.vsmnIm3xH7x.BeginTime ?? TimeSpan.Zero);
					break;
				}
				break;
			}
			TimeSpan timeSpan2 = timeSpan;
			return ExQsQNN5BxM5nXCuKi6g(timeSpan2.Ticks, bmaptynIrCR5ghAfFe5j.vsmnIm3xH7x.Children.Select(bmaptynIrCR5ghAfFe5j.qTunIKVnldg).Max().Ticks);
		}

		internal static bool PFeZu9N5YhGuyHRJOBIC()
		{
			return K2w0eiN5GCdxoRlMBdBO == null;
		}

		internal static U8wyvCnIhbuqdWjjk47k f7vu5YN5oPmjHUTdgyLZ()
		{
			return K2w0eiN5GCdxoRlMBdBO;
		}

		internal static Duration e5paPyN5vftMbQgbkqEM(object P_0)
		{
			return ((Timeline)P_0).Duration;
		}

		internal static long ExQsQNN5BxM5nXCuKi6g(long P_0, long P_1)
		{
			return Math.Min(P_0, P_1);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct MLtjw3nI3PlZkDhBT5qh : IAsyncStateMachine
	{
		public int t42nIpHk8CV;

		public AsyncVoidMethodBuilder OqinIuxcuOL;

		public Notification lYHnIzEXhjh;

		private TaskAwaiter v2ynW0YrY9U;

		internal static object AWVoI5N5aoZNgcLTZxvd;

		private void MoveNext()
		{
			int num = t42nIpHk8CV;
			Notification notification = lYHnIzEXhjh;
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
			{
				num2 = 0;
			}
			TaskAwaiter awaiter = default(TaskAwaiter);
			while (true)
			{
				switch (num2)
				{
				case 1:
					OqinIuxcuOL.SetResult();
					return;
				}
				try
				{
					int num3;
					if (num != 0)
					{
						num3 = 3;
					}
					else
					{
						awaiter = v2ynW0YrY9U;
						num3 = 2;
					}
					while (true)
					{
						switch (num3)
						{
						case 6:
							return;
						case 5:
							awaiter = Task.Delay(notification._closingAnimationTime).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (t42nIpHk8CV = 0);
								v2ynW0YrY9U = awaiter;
								OqinIuxcuOL.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							}
							goto IL_0147;
						case 1:
							notification.RaiseEvent(new RoutedEventArgs(NotificationCloseInvokedEvent));
							num3 = 5;
							continue;
						case 3:
							if (notification.IsClosing)
							{
								break;
							}
							goto default;
						case 2:
							v2ynW0YrY9U = default(TaskAwaiter);
							num = (t42nIpHk8CV = -1);
							goto IL_0147;
						case 4:
							notification.RaiseEvent(new RoutedEventArgs(NotificationClosedEvent));
							break;
						default:
							{
								notification.IsClosing = true;
								num3 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
								{
									num3 = 0;
								}
								continue;
							}
							IL_0147:
							awaiter.GetResult();
							num3 = 4;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						break;
					}
				}
				catch (Exception exception)
				{
					t42nIpHk8CV = -2;
					int num4 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					}
					OqinIuxcuOL.SetException(exception);
					return;
				}
				t42nIpHk8CV = -2;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 != 0)
				{
					num2 = 0;
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
			OqinIuxcuOL.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static MLtjw3nI3PlZkDhBT5qh()
		{
			M1FImvN54rgG2hLuBGVP();
		}

		internal static bool kAKa7QN5inWd1ELvLdKe()
		{
			return AWVoI5N5aoZNgcLTZxvd == null;
		}

		internal static object dZZ5vrN5lF3XwBNqvkox()
		{
			return AWVoI5N5aoZNgcLTZxvd;
		}

		internal static void M1FImvN54rgG2hLuBGVP()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	private TimeSpan _closingAnimationTime;

	public static readonly RoutedEvent NotificationCloseInvokedEvent;

	public static readonly RoutedEvent NotificationClosedEvent;

	public static readonly DependencyProperty CloseOnClickProperty;

	internal static Notification oyIWN2DBBCBs44BiU3Lm;

	public bool IsClosing { get; set; }

	public event RoutedEventHandler NotificationCloseInvoked
	{
		add
		{
			AddHandler(NotificationCloseInvokedEvent, value);
		}
		remove
		{
			RemoveHandler(NotificationCloseInvokedEvent, value);
		}
	}

	public event RoutedEventHandler NotificationClosed
	{
		add
		{
			AddHandler(NotificationClosedEvent, value);
		}
		remove
		{
			RemoveHandler(NotificationClosedEvent, value);
		}
	}

	static Notification()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		NotificationCloseInvokedEvent = EventManager.RegisterRoutedEvent(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1009517961 ^ -1009581673), RoutingStrategy.Bubble, VQrfSkDBlPf91xBq7016(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777421)), VQrfSkDBlPf91xBq7016(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555176)));
		NotificationClosedEvent = (RoutedEvent)E1X1WUDBDHvAdWu1dcaP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1763895751 ^ -1763841491), RoutingStrategy.Bubble, Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777421)), Type.GetTypeFromHandle(t1uLacDB4pwfi5G6Kl7r(33555176)));
		CloseOnClickProperty = (DependencyProperty)tJWqYyDBbLqb7H3Fqf2i(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461949456 ^ -1461938228), VQrfSkDBlPf91xBq7016(t1uLacDB4pwfi5G6Kl7r(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555176)), new FrameworkPropertyMetadata(true, CloseOnClickChanged));
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555176)), new FrameworkPropertyMetadata(Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555176))));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public static bool GetCloseOnClick(DependencyObject obj)
	{
		return (bool)IiNKTqDBNMM90UPeDbyE(obj, CloseOnClickProperty);
	}

	public static void SetCloseOnClick(DependencyObject obj, bool value)
	{
		obj.SetValue(CloseOnClickProperty, value);
	}

	private static void CloseOnClickChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
	{
		PdOZ7vnIZ32LyHvCXwVj CS_0024_003C_003E8__locals4 = new PdOZ7vnIZ32LyHvCXwVj();
		CS_0024_003C_003E8__locals4.SRcnICyas61 = dependencyObject as Button;
		if (CS_0024_003C_003E8__locals4.SRcnICyas61 == null || !(bool)dependencyPropertyChangedEventArgs.NewValue)
		{
			return;
		}
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				CS_0024_003C_003E8__locals4.SRcnICyas61.Click += delegate
				{
					KUIQKFHDvnXGoCOabJCv.Y4PHDagtCgH<Notification>(CS_0024_003C_003E8__locals4.SRcnICyas61)?.Close();
				};
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		if (GetTemplateChild(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x20B584D2 ^ 0x20B5788A)) is Button button)
		{
			button.Click += OnCloseButtonOnClick;
		}
		base.MouseDown += OnMouseDown;
		int num = 2;
		IEnumerable<Storyboard> enumerable = default(IEnumerable<Storyboard>);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
			{
				EventTrigger eventTrigger = ((ControlTemplate)vdw5mZDBkTEMdxkvdkRB(this)).Triggers.OfType<EventTrigger>().FirstOrDefault((EventTrigger t) => t.RoutedEvent == NotificationCloseInvokedEvent);
				enumerable = ((eventTrigger != null) ? (from a in ((IEnumerable)TUbAJwDB10AMFOrSAREO(eventTrigger)).OfType<BeginStoryboard>()
					select a.Storyboard) : null);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
				{
					num = 1;
				}
				break;
			}
			case 1:
				_closingAnimationTime = new TimeSpan(enumerable?.Max(delegate(Storyboard s)
				{
					int num2 = 1;
					int num3 = num2;
					BmaptynIrCR5ghAfFe5j bmaptynIrCR5ghAfFe5j = default(BmaptynIrCR5ghAfFe5j);
					Duration duration = default(Duration);
					TimeSpan timeSpan;
					while (true)
					{
						switch (num3)
						{
						case 1:
							bmaptynIrCR5ghAfFe5j = new BmaptynIrCR5ghAfFe5j();
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							duration = U8wyvCnIhbuqdWjjk47k.e5paPyN5vftMbQgbkqEM(bmaptynIrCR5ghAfFe5j.vsmnIm3xH7x);
							num3 = 2;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 != 0)
							{
								num3 = 3;
							}
							continue;
						default:
							bmaptynIrCR5ghAfFe5j.vsmnIm3xH7x = s;
							duration = bmaptynIrCR5ghAfFe5j.vsmnIm3xH7x.Duration;
							if (duration.HasTimeSpan)
							{
								num3 = 2;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 != 0)
								{
									num3 = 2;
								}
								continue;
							}
							timeSpan = TimeSpan.MaxValue;
							break;
						case 3:
							timeSpan = duration.TimeSpan + (bmaptynIrCR5ghAfFe5j.vsmnIm3xH7x.BeginTime ?? TimeSpan.Zero);
							break;
						}
						break;
					}
					TimeSpan timeSpan2 = timeSpan;
					return U8wyvCnIhbuqdWjjk47k.ExQsQNN5BxM5nXCuKi6g(timeSpan2.Ticks, bmaptynIrCR5ghAfFe5j.vsmnIm3xH7x.Children.Select(bmaptynIrCR5ghAfFe5j.qTunIKVnldg).Max().Ticks);
				}) ?? 0);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void OnMouseDown(object sender, MouseButtonEventArgs e)
	{
		hNXfXl9U6G1YI9MQ7eq.Instance.MainWindow.Activate();
	}

	private void OnCloseButtonOnClick(object sender, RoutedEventArgs args)
	{
		int num = 2;
		int num2 = num;
		Button button = default(Button);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				button = sender as Button;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (button == null)
				{
					return;
				}
				button.Click -= OnCloseButtonOnClick;
				Close();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[AsyncStateMachine(typeof(MLtjw3nI3PlZkDhBT5qh))]
	public void Close()
	{
		int num = 1;
		int num2 = num;
		MLtjw3nI3PlZkDhBT5qh stateMachine = default(MLtjw3nI3PlZkDhBT5qh);
		while (true)
		{
			switch (num2)
			{
			default:
				stateMachine.lYHnIzEXhjh = this;
				stateMachine.t42nIpHk8CV = -1;
				stateMachine.OqinIuxcuOL.Start(ref stateMachine);
				return;
			case 1:
				stateMachine.OqinIuxcuOL = AsyncVoidMethodBuilder.Create();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public Notification()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		_closingAnimationTime = TimeSpan.Zero;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Sri1kJDBanEkMK71wh6h()
	{
		return oyIWN2DBBCBs44BiU3Lm == null;
	}

	internal static Notification uIjs1eDBi1Gfm5lVyBnL()
	{
		return oyIWN2DBBCBs44BiU3Lm;
	}

	internal static Type VQrfSkDBlPf91xBq7016(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static RuntimeTypeHandle t1uLacDB4pwfi5G6Kl7r(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static object E1X1WUDBDHvAdWu1dcaP(object P_0, RoutingStrategy P_1, Type P_2, Type P_3)
	{
		return EventManager.RegisterRoutedEvent((string)P_0, P_1, P_2, P_3);
	}

	internal static object tJWqYyDBbLqb7H3Fqf2i(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.RegisterAttached((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}

	internal static object IiNKTqDBNMM90UPeDbyE(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static object vdw5mZDBkTEMdxkvdkRB(object P_0)
	{
		return ((Control)P_0).Template;
	}

	internal static object TUbAJwDB10AMFOrSAREO(object P_0)
	{
		return ((EventTrigger)P_0).Actions;
	}
}
