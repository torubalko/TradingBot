using System;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Docking.Primitives;

namespace ActiproSoftware.Internal;

internal abstract class xN : gh
{
	private DockHost ClY;

	private static xN xYL;

	public DockHost DockHost
	{
		get
		{
			return ClY;
		}
		protected set
		{
			if (ClY == dockHost)
			{
				return;
			}
			if (ClY != null)
			{
				ClY.mGM(xll);
				ClY.Closed -= mlM;
				ClY.JGL(mlv);
				ClY.fGs(yl7);
				ClY.nG9(JlR);
				ClY.OGV(WlS);
			}
			ClY = dockHost;
			if (ClY != null)
			{
				ClY.RGl(xll);
				ClY.Closed += mlM;
				ClY.tGS(mlv);
				ClY.IGp(yl7);
				ClY.tG6(JlR);
				int num = 0;
				if (GY9() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				ClY.GGF(WlS);
			}
		}
	}

	public DockSite DockSite
	{
		get
		{
			if (ClY == null)
			{
				return null;
			}
			return ClY.DockSite;
		}
	}

	public abstract Point Location { get; set; }

	protected xN(DockHost P_0)
	{
		IVH.CecNqz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9182));
		}
		DockHost = P_0;
	}

	private void xll(object P_0, EventArgs P_1)
	{
		amx();
	}

	private void mlM(object P_0, EventArgs P_1)
	{
		gmo();
	}

	private void mlv(object P_0, X9 P_1)
	{
		im1(P_1);
	}

	private void yl7(object P_0, EventArgs P_1)
	{
		rmT();
	}

	private void JlR(object P_0, EventArgs P_1)
	{
		Xmv();
	}

	private void WlS(object P_0, EventArgs P_1)
	{
		LmI();
	}

	protected abstract void gmm();

	public abstract void Kmi();

	protected abstract void gmo();

	protected abstract void im1(X9 P_0);

	protected abstract void Xmv();

	protected abstract void rmT();

	protected abstract void LmI();

	public abstract void Vmu(bool P_0, bool P_1, bool P_2);

	public static Rect XlL(Rect P_0, Rect P_1, double P_2)
	{
		int num;
		if (P_1.Width > 0.0 && P_1.Height > 0.0)
		{
			num = 1;
			if (GY9() != null)
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_01ca;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 2:
				P_0.Y += P_1.Top - P_0.Top;
				break;
			default:
				P_0.Y += P_1.Top - P_0.Bottom + P_2;
				break;
			case 1:
				P_2 = Math.Max(20.0, P_2);
				if (P_0.Right > P_1.Right)
				{
					if (!(P_0.Left < P_1.Right))
					{
						P_0.X += P_1.Right - P_0.Right;
					}
					else if (P_0.Left + P_2 > P_1.Right)
					{
						P_0.X += P_1.Right - P_0.Left - P_2;
					}
				}
				if (P_0.Left < P_1.Left)
				{
					if (!(P_0.Right > P_1.Left))
					{
						P_0.X += P_1.Left - P_0.Left;
					}
					else if (P_0.Right - P_2 < P_1.Left)
					{
						P_0.X += P_1.Left - P_0.Right + P_2;
					}
				}
				if (P_0.Bottom > P_1.Bottom)
				{
					if (!(P_0.Top < P_1.Bottom))
					{
						P_0.Y += P_1.Bottom - P_0.Bottom;
					}
					else if (P_0.Top + P_2 > P_1.Bottom)
					{
						P_0.Y += P_1.Bottom - P_0.Top - P_2;
					}
				}
				if (!(P_0.Top < P_1.Top))
				{
					break;
				}
				if (!(P_0.Bottom > P_1.Top))
				{
					goto case 2;
				}
				if (!(P_0.Bottom - P_2 < P_1.Top))
				{
					break;
				}
				goto IL_0135;
			}
			break;
			IL_0135:
			num = 0;
			if (GY9() == null)
			{
				continue;
			}
			goto IL_0005;
		}
		goto IL_01ca;
		IL_01ca:
		return P_0;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	protected abstract void dmw();

	public void Al3()
	{
		if (ClY != null)
		{
			ClY.XeK(Location);
		}
	}

	protected virtual void amx()
	{
	}

	[SpecialName]
	public virtual Window NmX()
	{
		return null;
	}

	[SpecialName]
	public virtual FloatingWindowControl Qmq()
	{
		return null;
	}

	internal static bool WYl()
	{
		return xYL == null;
	}

	internal static xN GY9()
	{
		return xYL;
	}
}
