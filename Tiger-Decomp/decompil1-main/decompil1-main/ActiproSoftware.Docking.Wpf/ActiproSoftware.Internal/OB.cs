using System;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Internal;

internal class OB : AdvancedTabItemEventArgs
{
	[CompilerGenerated]
	private InputPointerEventArgs Q2K;

	[CompilerGenerated]
	private Point E2J;

	[CompilerGenerated]
	private Action W2n;

	internal static OB kt;

	[SpecialName]
	[CompilerGenerated]
	internal InputPointerEventArgs G2k()
	{
		return Q2K;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void t2C(InputPointerEventArgs P_0)
	{
		Q2K = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public Point p2N()
	{
		return E2J;
	}

	[SpecialName]
	[CompilerGenerated]
	public void o2Q(Point P_0)
	{
		E2J = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public Action R2a()
	{
		return W2n;
	}

	[SpecialName]
	[CompilerGenerated]
	public void i2W(Action P_0)
	{
		W2n = P_0;
	}

	public OB()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool ap()
	{
		return kt == null;
	}

	internal static OB L4()
	{
		return kt;
	}
}
