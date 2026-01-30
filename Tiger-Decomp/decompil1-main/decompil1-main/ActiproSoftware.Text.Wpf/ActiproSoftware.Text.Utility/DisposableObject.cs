using System;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Utility;

public abstract class DisposableObject : IDisposable
{
	internal static DisposableObject rtX;

	protected DisposableObject()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	~DisposableObject()
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

	internal static bool Mt3()
	{
		return rtX == null;
	}

	internal static DisposableObject KtC()
	{
		return rtX;
	}
}
