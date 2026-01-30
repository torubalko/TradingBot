using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Windows.Controls.Docking;

namespace ActiproSoftware.Internal;

internal class bv : DependencyObject, lX
{
	[CompilerGenerated]
	private Size eCR;

	[CompilerGenerated]
	private DateTime xCS;

	[CompilerGenerated]
	private Guid mCL;

	internal static bv E1L;

	IEnumerable<lX> lX.ChildNodes
	{
		get
		{
			yield break;
		}
	}

	public Size ContainerDockedSize
	{
		[CompilerGenerated]
		get
		{
			return eCR;
		}
		[CompilerGenerated]
		internal set
		{
			eCR = size;
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	public DateTime lCM
	{
		[CompilerGenerated]
		get
		{
			return xCS;
		}
		[CompilerGenerated]
		internal set
		{
			xCS = dateTime;
		}
	}

	public Guid UniqueId
	{
		[CompilerGenerated]
		get
		{
			return mCL;
		}
		[CompilerGenerated]
		internal set
		{
			mCL = guid;
		}
	}

	internal bv()
	{
		IVH.CecNqz();
		base._002Ector();
		ContainerDockedSize = new Size(200.0, 200.0);
		lCM = DateTime.Now;
	}

	public bv(bv P_0)
	{
		IVH.CecNqz();
		this._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9064));
		}
		ContainerDockedSize = P_0.ContainerDockedSize;
		UniqueId = P_0.UniqueId;
	}

	public bv(DockingWindow P_0)
	{
		IVH.CecNqz();
		this._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		ContainerDockedSize = P_0.Skx();
		UniqueId = P_0.UniqueId;
	}

	internal static bool w1l()
	{
		return E1L == null;
	}

	internal static bv x19()
	{
		return E1L;
	}
}
