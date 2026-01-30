using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Rendering;

public class CanvasControl : Control, ICanvas
{
	private CanvasDrawCache wCD;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<CanvasDrawEventArgs> zCP;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool QCG;

	internal static CanvasControl Bng;

	protected internal bool IsForPrinter
	{
		[CompilerGenerated]
		get
		{
			return QCG;
		}
		[CompilerGenerated]
		private set
		{
			QCG = value;
		}
	}

	public event EventHandler<CanvasDrawEventArgs> Draw
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CanvasDrawEventArgs> eventHandler = zCP;
			EventHandler<CanvasDrawEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CanvasDrawEventArgs> value2 = (EventHandler<CanvasDrawEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref zCP, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CanvasDrawEventArgs> eventHandler = zCP;
			EventHandler<CanvasDrawEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CanvasDrawEventArgs> value2 = (EventHandler<CanvasDrawEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref zCP, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public CanvasControl()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(isForPrinter: false);
	}

	public CanvasControl(bool isForPrinter)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		IsForPrinter = isForPrinter;
		base.IsTabStop = false;
		base.Unloaded += QCN;
	}

	[SpecialName]
	private CanvasDrawCache lCK()
	{
		if (wCD == null)
		{
			float fontScale = 1f;
			wCD = new CanvasDrawCache(this, fontScale);
		}
		return wCD;
	}

	private void gCd()
	{
		if (wCD != null)
		{
			wCD.Dispose();
			wCD = null;
		}
	}

	private void QCN(object P_0, RoutedEventArgs P_1)
	{
		gCd();
	}

	private void FCM(DrawingContext P_0)
	{
		EventHandler<CanvasDrawEventArgs> eventHandler = zCP;
		if (eventHandler != null && P_0 != null)
		{
			Rect bounds = new Rect(0.0, 0.0, base.ActualWidth, base.ActualHeight);
			using CanvasDrawContext context = CreateDrawContext(this, P_0, bounds);
			CanvasDrawEventArgs e = new CanvasDrawEventArgs(context);
			eventHandler(this, e);
		}
	}

	protected virtual CanvasDrawContext CreateDrawContext(ICanvas canvas, DrawingContext platformRenderer, Rect bounds)
	{
		return new CanvasDrawContext(canvas, platformRenderer, bounds);
	}

	public IDisposable CreateTextBatch()
	{
		return new TextBatch(this);
	}

	public ITextLayout CreateTextLayout(string text, float maxWidth, string fontFamilyName, float fontSize, Color foreground)
	{
		StringTextProvider textProvider = new StringTextProvider(text);
		return CreateTextLayout(textProvider, maxWidth, fontFamilyName, fontSize, foreground, FontWeights.Normal, FontStyles.Normal, null);
	}

	public ITextLayout CreateTextLayout(ITextProvider textProvider, float maxWidth, string fontFamilyName, float fontSize, Color foreground, IEnumerable<ITextSpacer> spacers)
	{
		return CreateTextLayout(textProvider, maxWidth, fontFamilyName, fontSize, foreground, FontWeights.Normal, FontStyles.Normal, spacers);
	}

	public ITextLayout CreateTextLayout(ITextProvider textProvider, float maxWidth, string fontFamilyName, float fontSize, Color foreground, FontWeight fontWeight, FontStyle fontStyle, IEnumerable<ITextSpacer> spacers)
	{
		SolidColorBrush foreground2 = lCK()?.GetSolidColorBrush(foreground);
		return CreateTextLayout(textProvider, maxWidth, fontFamilyName, fontSize, foreground2, fontWeight, fontStyle, spacers);
	}

	public ITextLayout CreateTextLayout(string text, float maxWidth, string fontFamilyName, float fontSize, Brush foreground)
	{
		StringTextProvider textProvider = new StringTextProvider(text);
		return CreateTextLayout(textProvider, maxWidth, fontFamilyName, fontSize, foreground, FontWeights.Normal, FontStyles.Normal, null);
	}

	public ITextLayout CreateTextLayout(ITextProvider textProvider, float maxWidth, string fontFamilyName, float fontSize, Brush foreground, IEnumerable<ITextSpacer> spacers)
	{
		return CreateTextLayout(textProvider, maxWidth, fontFamilyName, fontSize, foreground, FontWeights.Normal, FontStyles.Normal, spacers);
	}

	public ITextLayout CreateTextLayout(ITextProvider textProvider, float maxWidth, string fontFamilyName, float fontSize, Brush foreground, FontWeight fontWeight, FontStyle fontStyle, IEnumerable<ITextSpacer> spacers)
	{
		return new TextLayout(lCK(), textProvider, maxWidth, fontFamilyName, fontSize, foreground, fontWeight, fontStyle, spacers);
	}

	public ITextSpacer CreateTextSpacer(int characterIndex, object key, Size size, double baseline)
	{
		return new TextSpacer(characterIndex, key, size, baseline);
	}

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public T ExecuteFunc<T>(Func<T> func)
	{
		T result = default(T);
		try
		{
			if (func != null)
			{
				result = func();
				return result;
			}
		}
		catch
		{
		}
		return result;
	}

	public SolidColorBrush GetSolidColorBrush(Color color)
	{
		return lCK().GetSolidColorBrush(color);
	}

	public Pen GetSquiggleLinePen(Color color)
	{
		return lCK().GetSquiggleLinePen(color);
	}

	public void InvalidateRender()
	{
		InvalidateVisual();
	}

	protected override void OnRender(DrawingContext drawingContext)
	{
		FCM(drawingContext);
	}

	internal static bool zn8()
	{
		return Bng == null;
	}

	internal static CanvasControl gnj()
	{
		return Bng;
	}
}
