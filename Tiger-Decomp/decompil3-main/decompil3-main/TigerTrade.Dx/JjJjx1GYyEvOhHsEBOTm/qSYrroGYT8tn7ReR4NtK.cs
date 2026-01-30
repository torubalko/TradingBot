using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Windows;
using fZl77HkDbCF2hZri4dVV;
using H59IbFkNkUTQB7uIfts0;
using kvtsvxkNBA3S7tECx5XS;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.DXGI;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Dx;
using Yiu4KPGYi3JSJwCKNkjP;

namespace JjJjx1GYyEvOhHsEBOTm;

internal abstract class qSYrroGYT8tn7ReR4NtK : IDisposable
{
	private bool L9qGof05ei4;

	private Size k7qGo95d8Od;

	[CompilerGenerated]
	private readonly SharpDX.Direct2D1.Factory gbSGonydbSc;

	[CompilerGenerated]
	private RenderTarget n2lGoGyJ5Nv;

	[CompilerGenerated]
	private RenderTarget aKyGoYT7kjm;

	[CompilerGenerated]
	private RenderTarget VdnGooFxneW;

	private readonly DxHwndHost hkjGovu1uX8;

	internal static qSYrroGYT8tn7ReR4NtK qVJGCckchDFBoUaURDlN;

	[SpecialName]
	[CompilerGenerated]
	protected SharpDX.Direct2D1.Factory a8mGY7NyjDk()
	{
		return gbSGonydbSc;
	}

	[SpecialName]
	[CompilerGenerated]
	protected RenderTarget NoaGYAkGdXN()
	{
		return n2lGoGyJ5Nv;
	}

	[SpecialName]
	[CompilerGenerated]
	private void MorGYPwpxiw(RenderTarget P_0)
	{
		n2lGoGyJ5Nv = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	protected RenderTarget cQCGYFU292R()
	{
		return aKyGoYT7kjm;
	}

	[SpecialName]
	[CompilerGenerated]
	private void wWTGY3oOJeO(RenderTarget P_0)
	{
		aKyGoYT7kjm = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	protected RenderTarget pXTGYuCsJC7()
	{
		return VdnGooFxneW;
	}

	[SpecialName]
	[CompilerGenerated]
	private void wlyGYzbIvCV(RenderTarget P_0)
	{
		VdnGooFxneW = P_0;
	}

	protected qSYrroGYT8tn7ReR4NtK(DxHwndHost P_0)
	{
		TrTKJNkc8VyOTSdbewEj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_81fc17157f934e0c8e49b4bbf662606f != 0)
		{
			num = 1;
		}
		FactoryType factoryType = default(FactoryType);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				factoryType = (Leluf5GYa57RQgFK4kLP.fNvGYlApuWJ() ? FactoryType.MultiThreaded : FactoryType.SingleThreaded);
				num = 2;
				break;
			case 0:
				return;
			case 2:
				gbSGonydbSc = new SharpDX.Direct2D1.Factory(factoryType);
				hkjGovu1uX8 = P_0;
				num = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_dd11dc8fd7944dd1aa43a7ff9cc7db54 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void Dispose()
	{
		gQbEKdkcA8MeI7LBox0s(this, true);
		DQ1HgRkcPvlcEKR0eO24(this);
	}

	protected virtual void Dispose(bool P_0)
	{
		GP7GYVxAJUh();
		if (P_0)
		{
			a8mGY7NyjDk().Dispose();
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_e5265bb46bfc4c9cb38e87dd07ed422a == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
		L9qGof05ei4 = true;
	}

	protected void vUSGYZ0UvQ0()
	{
		if (L9qGof05ei4)
		{
			throw new ObjectDisposedException(ApwwuBkcJ29t1NgGjKaZ(this).Name);
		}
	}

	~qSYrroGYT8tn7ReR4NtK()
	{
		try
		{
			gQbEKdkcA8MeI7LBox0s(this, false);
		}
		finally
		{
			vkX8ypkcFmfnABHbFkhm(this);
		}
	}

	protected virtual void NI3lnR04gYb()
	{
	}

	protected virtual void IWUlng7y0Qt()
	{
	}

	[SpecialName]
	public bool jfvGo2n7NWE()
	{
		return pXTGYuCsJC7() != null;
	}

	public void GP7GYVxAJUh()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				eMUa3Qkc3McA3CWqLlY1(this);
				num2 = 2;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_f1601605e25a48e58f87674317e812a9 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				MorGYPwpxiw(null);
				return;
			case 1:
				NoaGYAkGdXN().Dispose();
				num2 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_eb0f0656842b4d3d84079c96f5d54d68 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (cQCGYFU292R() != null)
				{
					cQCGYFU292R().Dispose();
					wWTGY3oOJeO(null);
				}
				if (NoaGYAkGdXN() == null)
				{
					return;
				}
				goto case 1;
			}
		}
	}

	public void nA9GYC5JRgE(bool P_0)
	{
		vUSGYZ0UvQ0();
		if (NoaGYAkGdXN() != null)
		{
			int num = 1;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_d8dfc4bf987547c385760d806fa39030 == 0)
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
				case 3:
				{
					Bitmap bitmap = ((BitmapRenderTarget)cQCGYFU292R()).Bitmap;
					NoaGYAkGdXN().DrawBitmap(bitmap, 1f, BitmapInterpolationMode.NearestNeighbor);
					eFcfpgkcptSXM2hqhcTB(bitmap);
					goto IL_0099;
				}
				case 1:
					NoaGYAkGdXN().BeginDraw();
					num = 2;
					break;
				case 2:
					{
						if (P_0)
						{
							num = 3;
							break;
						}
						goto IL_0099;
					}
					IL_0099:
					wlyGYzbIvCV(NoaGYAkGdXN());
					num = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_ad54b84e60ad4cb5b706bdc362a3d52b == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
		throw new InvalidOperationException(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-3429745 ^ -3429959));
	}

	[SecurityCritical]
	[HandleProcessCorruptedStateExceptions]
	public void oFAGYrmb8YA()
	{
		try
		{
			NoaGYAkGdXN()?.EndDraw();
		}
		catch (SharpDXException ex)
		{
			try
			{
				if (!(rW2FM5kcuX8oa1AnLE9j(ex) == RNLjSAkczlpNqSahD5gD(SharpDX.Direct2D1.ResultCode.RecreateTarget)))
				{
					C7PJ2bkj08D23DRhbGMP(ex);
				}
				else
				{
					DIsGYwvHobb();
				}
			}
			catch (Exception ex2)
			{
				C7PJ2bkj08D23DRhbGMP(ex2);
			}
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
		}
	}

	public void JIJGYKRW3WY()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				vUSGYZ0UvQ0();
				num2 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_cca28d80996a4dc593cc44ee0d127763 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (NoaGYAkGdXN() == null)
				{
					throw new InvalidOperationException((string)hmkcuhkj2VFuWrJrxfel(-1999650146 ^ -1999650392));
				}
				wlyGYzbIvCV(cQCGYFU292R());
				CtoYhekjH0ywx45uoPti(cQCGYFU292R());
				return;
			}
		}
	}

	[HandleProcessCorruptedStateExceptions]
	[SecurityCritical]
	public void IfaGYm1amQm()
	{
		try
		{
			RenderTarget renderTarget = cQCGYFU292R();
			if (renderTarget != null)
			{
				renderTarget.EndDraw();
				int num = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_cca28d80996a4dc593cc44ee0d127763 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
			}
			wlyGYzbIvCV(NoaGYAkGdXN());
		}
		catch (SharpDXException ex)
		{
			try
			{
				if (XGEW0JkjfpNmuNCXuySB(ex.ResultCode, RNLjSAkczlpNqSahD5gD(SharpDX.Direct2D1.ResultCode.RecreateTarget)))
				{
					DIsGYwvHobb();
					return;
				}
				LogManager.WriteError(ex);
				int num2 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_753e5d00adac40c8a6cf262825555139 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			catch (Exception e)
			{
				LogManager.WriteError(e);
			}
		}
		catch (Exception e2)
		{
			LogManager.WriteError(e2);
		}
	}

	public void CqLGYhkv66n(double P_0, double P_1)
	{
		vUSGYZ0UvQ0();
		int num;
		if (P_0 < 0.0)
		{
			num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_9ea6ac1b9978445f984c9b1d9e0008bf != 0)
			{
				num = 0;
			}
		}
		else
		{
			if (!(P_1 < 0.0))
			{
				k7qGo95d8Od = new Size(P_0, P_1);
				DIsGYwvHobb();
				return;
			}
			num = 1;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_e3a78f5673ba492cb3624f6fd9b0982f == 0)
			{
				num = 0;
			}
		}
		switch (num)
		{
		case 1:
			throw new ArgumentOutOfRangeException(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(0x6D18F862 ^ 0x6D18FBD2), vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(0x7F645F3C ^ 0x7F645C42));
		default:
			throw new ArgumentOutOfRangeException(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-837284864 ^ -837283984), (string)hmkcuhkj2VFuWrJrxfel(-45476899 ^ -45477725));
		}
	}

	private void DIsGYwvHobb()
	{
		RenderTarget renderTarget = NoaGYAkGdXN();
		if (renderTarget == null)
		{
			goto IL_00ee;
		}
		MH5WTUkj9xYOkVMk23ZR(renderTarget);
		int num = 1;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_753e5d00adac40c8a6cf262825555139 == 0)
		{
			num = 1;
		}
		goto IL_0009;
		IL_0009:
		HwndRenderTargetProperties hwndRenderTargetProperties = default(HwndRenderTargetProperties);
		RenderTargetProperties renderTargetProperties = default(RenderTargetProperties);
		int height = default(int);
		int width = default(int);
		while (true)
		{
			switch (num)
			{
			case 3:
				hwndRenderTargetProperties.Hwnd = hkjGovu1uX8.Handle;
				num = 5;
				continue;
			case 1:
				break;
			case 4:
			{
				hwndRenderTargetProperties.PresentOptions = PresentOptions.Immediately;
				HwndRenderTargetProperties hwndProperties = hwndRenderTargetProperties;
				MorGYPwpxiw(new WindowRenderTarget(a8mGY7NyjDk(), renderTargetProperties, hwndProperties)
				{
					TextAntialiasMode = TextAntialiasMode.Cleartype,
					AntialiasMode = AntialiasMode.PerPrimitive
				});
				wWTGY3oOJeO(new BitmapRenderTarget(NoaGYAkGdXN(), CompatibleRenderTargetOptions.None)
				{
					TextAntialiasMode = TextAntialiasMode.Cleartype,
					AntialiasMode = AntialiasMode.PerPrimitive
				});
				int num2 = 2;
				num = num2;
				continue;
			}
			default:
				height = (int)(k7qGo95d8Od.Height * (double)K5dj6jkjn5dRjPEAybjR(a8mGY7NyjDk()).Height / 96.0);
				hwndRenderTargetProperties = default(HwndRenderTargetProperties);
				num = 3;
				continue;
			case 5:
				hwndRenderTargetProperties.PixelSize = new Size2(width, height);
				num = 4;
				continue;
			case 6:
				goto IL_0186;
			case 2:
				IWUlng7y0Qt();
				NI3lnR04gYb();
				return;
			}
			break;
		}
		goto IL_00ee;
		IL_0186:
		renderTargetProperties = new RenderTargetProperties(RenderTargetType.Default, new PixelFormat(Format.B8G8R8A8_UNorm, SharpDX.Direct2D1.AlphaMode.Ignore), a8mGY7NyjDk().DesktopDpi.Width, K5dj6jkjn5dRjPEAybjR(a8mGY7NyjDk()).Height, RenderTargetUsage.None, FeatureLevel.Level_DEFAULT);
		width = (int)(k7qGo95d8Od.Width * (double)K5dj6jkjn5dRjPEAybjR(a8mGY7NyjDk()).Width / 96.0);
		num = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_eb0f0656842b4d3d84079c96f5d54d68 == 0)
		{
			num = 0;
		}
		goto IL_0009;
		IL_00ee:
		RenderTarget renderTarget2 = cQCGYFU292R();
		if (renderTarget2 == null)
		{
			goto IL_0186;
		}
		renderTarget2.Dispose();
		num = 6;
		goto IL_0009;
	}

	static qSYrroGYT8tn7ReR4NtK()
	{
		fxApXkkjGIMo7tSoM7E1();
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool mOpovxkcwhuH1uAHbgDT()
	{
		return qVJGCckchDFBoUaURDlN == null;
	}

	internal static qSYrroGYT8tn7ReR4NtK EvK8Egkc7e70t67ofUJ4()
	{
		return qVJGCckchDFBoUaURDlN;
	}

	internal static void TrTKJNkc8VyOTSdbewEj()
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
	}

	internal static void gQbEKdkcA8MeI7LBox0s(object P_0, bool P_1)
	{
		((qSYrroGYT8tn7ReR4NtK)P_0).Dispose(P_1);
	}

	internal static void DQ1HgRkcPvlcEKR0eO24(object P_0)
	{
		GC.SuppressFinalize(P_0);
	}

	internal static Type ApwwuBkcJ29t1NgGjKaZ(object P_0)
	{
		return P_0.GetType();
	}

	internal static void vkX8ypkcFmfnABHbFkhm(object P_0)
	{
		P_0.Finalize();
	}

	internal static void eMUa3Qkc3McA3CWqLlY1(object P_0)
	{
		((qSYrroGYT8tn7ReR4NtK)P_0).IWUlng7y0Qt();
	}

	internal static void eFcfpgkcptSXM2hqhcTB(object P_0)
	{
		((DisposeBase)P_0).Dispose();
	}

	internal static Result rW2FM5kcuX8oa1AnLE9j(object P_0)
	{
		return ((SharpDXException)P_0).ResultCode;
	}

	internal static Result RNLjSAkczlpNqSahD5gD(object P_0)
	{
		return (ResultDescriptor)P_0;
	}

	internal static void C7PJ2bkj08D23DRhbGMP(object P_0)
	{
		LogManager.WriteError((Exception)P_0);
	}

	internal static object hmkcuhkj2VFuWrJrxfel(int P_0)
	{
		return vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(P_0);
	}

	internal static void CtoYhekjH0ywx45uoPti(object P_0)
	{
		((RenderTarget)P_0).BeginDraw();
	}

	internal static bool XGEW0JkjfpNmuNCXuySB(Result P_0, Result P_1)
	{
		return P_0 == P_1;
	}

	internal static void MH5WTUkj9xYOkVMk23ZR(object P_0)
	{
		((DisposeBase)P_0).Dispose();
	}

	internal static Size2F K5dj6jkjn5dRjPEAybjR(object P_0)
	{
		return ((SharpDX.Direct2D1.Factory)P_0).DesktopDpi;
	}

	internal static void fxApXkkjGIMo7tSoM7E1()
	{
		vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
	}
}
