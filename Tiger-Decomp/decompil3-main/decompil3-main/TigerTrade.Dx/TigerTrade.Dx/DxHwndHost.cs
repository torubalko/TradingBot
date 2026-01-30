using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using frVhYEG2rKDqTejMVStw;
using fZl77HkDbCF2hZri4dVV;
using H59IbFkNkUTQB7uIfts0;
using kvtsvxkNBA3S7tECx5XS;
using nmrhknGoaf9FnMR8Uhhm;

namespace TigerTrade.Dx;

public sealed class DxHwndHost : DxHwndHostBase
{
	[CompilerGenerated]
	private Action m_OnTimerTick;

	private readonly BDksuPGoBNt1WkpSSAaQ _dxVisual;

	private readonly nawYUmG2C9dJMZEo3okg _timer;

	private static DxHwndHost sTkg5TkcBnC8MCxW02hB;

	public bool WaitRedraw { get; set; }

	public Rect ClientRect { get; private set; }

	public bool IsDisposed { get; private set; }

	public event Action OnTimerTick
	{
		[CompilerGenerated]
		add
		{
			Action action = this.m_OnTimerTick;
			while (true)
			{
				Action action2 = action;
				Action value2 = (Action)lP65fTkcltn08oVgT8dJ(action2, value);
				int num = 1;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_10b7977984684a30b2d10583321d7520 == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 1:
						break;
					case 0:
						return;
					}
					action = Interlocked.CompareExchange(ref this.m_OnTimerTick, value2, action2);
					if ((object)action != action2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_a4bfd91901d845bcb60d0800e68c0832 == 0)
					{
						num = 0;
					}
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			Action action = this.m_OnTimerTick;
			while (true)
			{
				Action action2 = action;
				Action value2 = (Action)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref this.m_OnTimerTick, value2, action2);
				int num = 1;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_71bb8832f147473987544a7fa3578a88 != 0)
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
						break;
					}
					if ((object)action != action2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_1ecf08483ad04bb2aa32d881f01b6bdc == 0)
					{
						num = 0;
					}
				}
			}
		}
	}

	public event Action<bool> OnRenderVisual;

	public DxHwndHost()
	{
		VJbL4Akc4IIHkjMFrd9d();
		_timer = nawYUmG2C9dJMZEo3okg.BiKGHi36WhZ;
		base._002Ector();
		_dxVisual = new BDksuPGoBNt1WkpSSAaQ(this);
		int num = 1;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_e3c56040434a4a628f0f01cc04d0408d != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				ClientRect = Rect.Empty;
				num = 2;
				break;
			case 1:
				_dxVisual.atPGoxqQfqX(RiseOnRenderVisual);
				num = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_bd63eb643aa34f16bc5bf5aec8c37779 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				_timer.rkfG2PjB47x(TimerTick);
				return;
			}
		}
	}

	protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
	{
		VahRApkcDUfq2QssYi51(this, e);
		if (e.Property == UIElement.IsVisibleProperty)
		{
			_dxVisual.RSgGoisqYRI((bool)e.NewValue);
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_753e5d00adac40c8a6cf262825555139 != 0)
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

	protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
	{
		base.OnRenderSizeChanged(sizeInfo);
		Size size = PeLm35kcbI4x5QiQrFRt(sizeInfo);
		int num = 1;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_de21cd78737049749dce66b024a96c1f != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				if (size.Width > 0.0)
				{
					size = sizeInfo.NewSize;
					num = 3;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_05692657bf2742bd873f9ce176ecb3de == 0)
					{
						num = 3;
					}
					continue;
				}
				goto IL_0045;
			case 3:
				if (size.Height > 0.0)
				{
					Point location = new Point(0.0, 0.0);
					double width = PeLm35kcbI4x5QiQrFRt(sizeInfo).Width;
					size = sizeInfo.NewSize;
					ClientRect = new Rect(location, new Size(width, size.Height));
					break;
				}
				goto IL_0045;
			case 2:
				return;
				IL_0045:
				ClientRect = Rect.Empty;
				num = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_ff0a4d8796cd433cb37c0cf2a1b8489a == 0)
				{
					num = 0;
				}
				continue;
			}
			InvalidateVisual(full: true);
			num = 2;
		}
	}

	protected override void OnPaintBackground()
	{
		InvalidateVisual(full: true);
	}

	public void StartTimer(int interval)
	{
	}

	public void SetTimerInterval(int interval)
	{
	}

	private void TimerTick(object o, EventArgs args)
	{
		Action action = this.OnTimerTick;
		if (action != null)
		{
			tPJ5MukcNIHDi88YciBx(action);
		}
		if (!base.IsVisible)
		{
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_7401544be24240018f1726a67e2081fe == 0)
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
			StartRender();
		}
	}

	private void StartRender()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!DDXUOgkc1BcIG0uVKK37(ClientRect, jZvgANkckPqE6f2vepPZ()))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_56b8b1a6026c4b1e82172f38beccbc71 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (!IsDisposed)
				{
					_dxVisual.OxcGoD3Ufom();
				}
				return;
			}
		}
	}

	private void RiseOnRenderVisual(bool full)
	{
		this.OnRenderVisual?.Invoke(full);
	}

	public void Render(DxVisualQueue queue1, DxVisualQueue queue2)
	{
		if (!IsDisposed)
		{
			_dxVisual.sYrGobVONh4(queue1, queue2);
		}
	}

	public void InvalidateVisual(bool full = false)
	{
		if (!IsDisposed)
		{
			WaitRedraw = true;
			_dxVisual.EVbGoluypGU(full);
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_f1601605e25a48e58f87674317e812a9 == 0)
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

	public void InvalidateSecondVisual()
	{
		if (!IsDisposed)
		{
			_dxVisual.EVbGoluypGU(_0020: false);
		}
	}

	protected override void Dispose(bool disposing)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (disposing)
				{
					GC.SuppressFinalize(this);
					num2 = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_9dc87266080545b1b4e0ed15ee567184 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				_timer.w9EG2JK7vxK(TimerTick);
				_dxVisual.GYlGoLcevvd(RiseOnRenderVisual);
				_dxVisual.Dispose();
				return;
			case 2:
				if (IsDisposed)
				{
					num2 = 1;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_9dc87266080545b1b4e0ed15ee567184 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					IsDisposed = true;
					num2 = 3;
				}
				break;
			case 1:
				return;
			}
		}
	}

	~DxHwndHost()
	{
		Dispose(disposing: false);
	}

	static DxHwndHost()
	{
		NemT1skc52Vkht8A2khe();
		EmxsQQkcSIY9jwAr6d7o();
	}

	internal static object lP65fTkcltn08oVgT8dJ(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static bool kSyFlLkca0D7BquDBWDc()
	{
		return sTkg5TkcBnC8MCxW02hB == null;
	}

	internal static DxHwndHost Exg40DkciNKP0S4nKuei()
	{
		return sTkg5TkcBnC8MCxW02hB;
	}

	internal static void VJbL4Akc4IIHkjMFrd9d()
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
	}

	internal static void VahRApkcDUfq2QssYi51(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((FrameworkElement)P_0).OnPropertyChanged(P_1);
	}

	internal static Size PeLm35kcbI4x5QiQrFRt(object P_0)
	{
		return ((SizeChangedInfo)P_0).NewSize;
	}

	internal static void tPJ5MukcNIHDi88YciBx(object P_0)
	{
		P_0();
	}

	internal static Rect jZvgANkckPqE6f2vepPZ()
	{
		return Rect.Empty;
	}

	internal static bool DDXUOgkc1BcIG0uVKK37(Rect P_0, Rect P_1)
	{
		return P_0 != P_1;
	}

	internal static void NemT1skc52Vkht8A2khe()
	{
		vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
	}

	internal static void EmxsQQkcSIY9jwAr6d7o()
	{
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
	}
}
