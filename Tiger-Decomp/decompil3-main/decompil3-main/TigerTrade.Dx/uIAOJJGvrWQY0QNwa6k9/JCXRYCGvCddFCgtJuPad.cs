using System;
using System.Runtime.CompilerServices;
using System.Threading;
using fZl77HkDbCF2hZri4dVV;
using H59IbFkNkUTQB7uIfts0;
using kvtsvxkNBA3S7tECx5XS;
using SharpDX;
using SharpDX.DirectWrite;

namespace uIAOJJGvrWQY0QNwa6k9;

internal sealed class JCXRYCGvCddFCgtJuPad : FontFileStream, IUnknown, ICallbackable, IDisposable
{
	private readonly DataStream GdDGvmuR9kD;

	private bool PmJGvhVyxne;

	[CompilerGenerated]
	private IDisposable vROGvwfDcI6;

	internal static JCXRYCGvCddFCgtJuPad SiEIlRkQQcyQJyrdmrhq;

	public IDisposable Shadow
	{
		[CompilerGenerated]
		get
		{
			return vROGvwfDcI6;
		}
		[CompilerGenerated]
		set
		{
			vROGvwfDcI6 = disposable;
		}
	}

	public JCXRYCGvCddFCgtJuPad(DataStream P_0)
	{
		j58iLikQRFQuG3E2yUQm();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_e3a78f5673ba492cb3624f6fd9b0982f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		GdDGvmuR9kD = P_0;
	}

	public void ReadFileFragment(out IntPtr P_0, long P_1, long P_2, out IntPtr P_3)
	{
		int num = 1;
		int num2 = num;
		JCXRYCGvCddFCgtJuPad jCXRYCGvCddFCgtJuPad = default(JCXRYCGvCddFCgtJuPad);
		while (true)
		{
			switch (num2)
			{
			case 1:
				jCXRYCGvCddFCgtJuPad = this;
				num2 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_1f10bc03091f4bd381d7108e341d458d == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(jCXRYCGvCddFCgtJuPad, ref lockTaken);
				P_3 = IntPtr.Zero;
				GdDGvmuR9kD.Position = P_1;
				P_0 = l4XqafkQ6rx0dyju9L4H(GdDGvmuR9kD);
				int num3 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_a37a4622ccdb43ca9169ef0d80d56ae1 == 0)
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
				if (lockTaken)
				{
					BiFWNnkQML5rAfJjPacB(jCXRYCGvCddFCgtJuPad);
				}
			}
		}
	}

	public void ReleaseFileFragment(IntPtr P_0)
	{
	}

	public long GetFileSize()
	{
		return GdDGvmuR9kD.Length;
	}

	public long GetLastWriteTime()
	{
		return 0L;
	}

	public Result QueryInterface(ref Guid P_0, out IntPtr P_1)
	{
		P_1 = IntPtr.Zero;
		return Result.Ok;
	}

	public int AddReference()
	{
		return 0;
	}

	public int Release()
	{
		return 0;
	}

	private void gZZGvKCkkFR(bool P_0)
	{
		if (PmJGvhVyxne)
		{
			return;
		}
		if (!P_0)
		{
			goto IL_0028;
		}
		GdDGvmuR9kD.Dispose();
		int num = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_9c97202d436d4fdeb9d5766e35301e16 != 0)
		{
			num = 0;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			return;
		}
		goto IL_0028;
		IL_0028:
		PmJGvhVyxne = true;
		num = 1;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_f86e5f1f94bb473ea99521e551650092 != 0)
		{
			num = 0;
		}
		goto IL_0009;
	}

	public void Dispose()
	{
		gZZGvKCkkFR(_0020: true);
		VRgXQ6kQOuL39AMMjXIX(this);
	}

	static JCXRYCGvCddFCgtJuPad()
	{
		vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
		fM6fGgkQq6qRLbXHUEpE();
	}

	internal static bool sbGiLmkQdcIg7k2IPpA4()
	{
		return SiEIlRkQQcyQJyrdmrhq == null;
	}

	internal static JCXRYCGvCddFCgtJuPad AHXPqZkQgkGybiMHt9n8()
	{
		return SiEIlRkQQcyQJyrdmrhq;
	}

	internal static void j58iLikQRFQuG3E2yUQm()
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
	}

	internal static IntPtr l4XqafkQ6rx0dyju9L4H(object P_0)
	{
		return ((DataStream)P_0).PositionPointer;
	}

	internal static void BiFWNnkQML5rAfJjPacB(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static void VRgXQ6kQOuL39AMMjXIX(object P_0)
	{
		GC.SuppressFinalize(P_0);
	}

	internal static void fM6fGgkQq6qRLbXHUEpE()
	{
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
	}
}
