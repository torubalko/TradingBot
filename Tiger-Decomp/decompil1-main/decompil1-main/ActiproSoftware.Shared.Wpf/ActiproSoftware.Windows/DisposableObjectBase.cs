using System;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows;

public abstract class DisposableObjectBase : IDisposable
{
	internal static DisposableObjectBase fR;

	protected DisposableObjectBase()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	~DisposableObjectBase()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	internal static bool H9()
	{
		return fR == null;
	}

	internal static DisposableObjectBase qc()
	{
		return fR;
	}
}
