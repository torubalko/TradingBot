using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Rendering;

internal class CanvasDrawCache : DisposableObjectBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public bool dHk;

		public bool FHl;

		public string JHA;

		private static _003C_003Ec__DisplayClass35_0 y6M;

		public _003C_003Ec__DisplayClass35_0()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal Typeface OH0()
		{
			FontStyle style = (dHk ? FontStyles.Italic : FontStyles.Normal);
			FontWeight weight = (FHl ? FontWeights.Bold : FontWeights.Normal);
			return new Typeface(new FontFamily(JHA), style, weight, FontStretches.Normal);
		}

		internal static bool t6Y()
		{
			return y6M == null;
		}

		internal static _003C_003Ec__DisplayClass35_0 w6t()
		{
			return y6M;
		}
	}

	private Dictionary<Color, SolidColorBrush> JYB;

	private Dictionary<Color, Pen> WYp;

	private WeakReference DYb;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private float zYy;

	private CachingList<Brush> PYf;

	private CachingList<string> kYi;

	private CachingList<float> vYS;

	private Dictionary<string, Typeface> LY3;

	private Dictionary<TextLayoutFormat, TextLayoutRunProperties> LYt;

	private TextFormatter kYJ;

	private TextFormatter DY9;

	private static CanvasDrawCache one;

	internal float FontScale
	{
		[CompilerGenerated]
		get
		{
			return zYy;
		}
		[CompilerGenerated]
		private set
		{
			zYy = value;
		}
	}

	public ICanvas Canvas
	{
		get
		{
			if (DYb != null)
			{
				if (DYb.IsAlive)
				{
					return DYb.Target as ICanvas;
				}
				DYb = null;
			}
			return null;
		}
	}

	public CanvasDrawCache(ICanvas canvas, float fontScale)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		PYf = new CachingList<Brush>();
		kYi = new CachingList<string>();
		vYS = new CachingList<float>();
		LY3 = new Dictionary<string, Typeface>();
		LYt = new Dictionary<TextLayoutFormat, TextLayoutRunProperties>();
		base._002Ector();
		int num = 0;
		if (false)
		{
			num = 0;
		}
		switch (num)
		{
		}
		if (canvas == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116880));
		}
		DYb = new WeakReference(canvas);
		FontScale = fontScale;
	}

	private void QC1()
	{
		if (JYB != null)
		{
			JYB.Clear();
		}
	}

	private void oCz()
	{
		if (WYp != null)
		{
			WYp.Clear();
		}
	}

	public void Clear()
	{
		oCz();
		QC1();
		eYc();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			Clear();
		}
		base.Dispose(disposing);
	}

	public SolidColorBrush GetSolidColorBrush(Color color)
	{
		if (JYB == null)
		{
			JYB = new Dictionary<Color, SolidColorBrush>();
		}
		if (!JYB.TryGetValue(color, out var value))
		{
			value = new SolidColorBrush(color);
			value.Freeze();
			JYB[color] = value;
			int num = 0;
			if (!mn6())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		return value;
	}

	public Pen GetSquiggleLinePen(Color color)
	{
		if (WYp == null)
		{
			WYp = new Dictionary<Color, Pen>();
		}
		if (!WYp.TryGetValue(color, out var value))
		{
			SolidColorBrush solidColorBrush = GetSolidColorBrush(color);
			value = new Pen(solidColorBrush, 0.800000011920929);
			value.LineJoin = PenLineJoin.Round;
			value.MiterLimit = 10.0;
			value.StartLineCap = PenLineCap.Flat;
			int num = 0;
			if (!mn6())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			value.EndLineCap = PenLineCap.Flat;
			value.Freeze();
			WYp[color] = value;
		}
		return value;
	}

	private void eYc()
	{
		PYf.Clear();
		kYi.Clear();
		vYS.Clear();
		LYt.Clear();
		LY3.Clear();
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	private static TextFormatter sYj(TextFormattingMode P_0)
	{
		try
		{
			if (SecurityHelper.IsFullTrust)
			{
				TextFormatter textFormatter = bYv(P_0);
				if (textFormatter != null)
				{
					return textFormatter;
				}
			}
		}
		catch
		{
		}
		return TextFormatter.Create(P_0);
	}

	private static TextFormatter bYv(TextFormattingMode P_0)
	{
		MethodInfo method = typeof(TextFormatter).GetMethod(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116896), BindingFlags.Static | BindingFlags.NonPublic, null, new Type[1] { typeof(TextFormattingMode) }, null);
		if (method != null)
		{
			return method.Invoke(null, new object[1] { P_0 }) as TextFormatter;
		}
		return null;
	}

	private Typeface zYX(string P_0, Lazy<Typeface> P_1)
	{
		if (!LY3.TryGetValue(P_0, out var value))
		{
			value = P_1.Value;
			LY3[P_0] = value;
		}
		return value;
	}

	public Brush GetBrushAtIndex(int index)
	{
		return (index >= 0) ? PYf[index] : null;
	}

	public int GetBrushIndex(Brush brush)
	{
		return (brush != null) ? PYf.GetIndex(brush) : 0;
	}

	public string GetFontFamilyAtIndex(int index)
	{
		return kYi[index];
	}

	public int GetFontFamilyIndex(string fontFamilyName)
	{
		return (!string.IsNullOrEmpty(fontFamilyName)) ? kYi.GetIndex(fontFamilyName) : 0;
	}

	public float GetFontSizeAtIndex(int index)
	{
		return vYS[index];
	}

	public int GetFontSizeIndex(float fontSize)
	{
		return ((double)fontSize > 0.0) ? vYS.GetIndex(fontSize) : 0;
	}

	public TextFormatter GetOrCreateTextFormatter(TextFormattingMode mode)
	{
		if (mode == TextFormattingMode.Display)
		{
			if (kYJ == null)
			{
				kYJ = sYj(mode);
			}
			return kYJ;
		}
		if (DY9 == null)
		{
			DY9 = sYj(mode);
		}
		return DY9;
	}

	public TextLayoutRunProperties GetTextRunProperties(TextLayoutFormat format)
	{
		if (!LYt.TryGetValue(format, out var value))
		{
			string fontFamilyAtIndex = GetFontFamilyAtIndex(format.FontFamilyIndex);
			Typeface typeface = GetTypeface(fontFamilyAtIndex, format.IsBold, format.IsItalic);
			float fontSizeAtIndex = GetFontSizeAtIndex(format.FontSizeIndex);
			Brush brushAtIndex = GetBrushAtIndex(format.ForegroundIndex);
			Brush strikethroughBrush = GetBrushAtIndex(format.StrikethroughBrushIndex) ?? brushAtIndex;
			Brush underlineBrush = GetBrushAtIndex(format.UnderlineBrushIndex) ?? brushAtIndex;
			value = new TextLayoutRunProperties(typeface, fontSizeAtIndex, brushAtIndex, format.StrikethroughKind, strikethroughBrush, format.StrikethroughWeight, format.UnderlineKind, underlineBrush, format.UnderlineWeight);
			LYt[format] = value;
		}
		return value;
	}

	public Typeface GetTypeface(string fontFamilyName, bool isBold, bool isItalic)
	{
		_003C_003Ec__DisplayClass35_0 CS_0024_003C_003E8__locals9 = new _003C_003Ec__DisplayClass35_0();
		CS_0024_003C_003E8__locals9.dHk = isItalic;
		CS_0024_003C_003E8__locals9.FHl = isBold;
		CS_0024_003C_003E8__locals9.JHA = fontFamilyName;
		string text = string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116942), new object[3]
		{
			CS_0024_003C_003E8__locals9.FHl ? 1 : 0,
			CS_0024_003C_003E8__locals9.dHk ? 1 : 0,
			CS_0024_003C_003E8__locals9.JHA
		});
		return zYX(text, new Lazy<Typeface>(delegate
		{
			FontStyle style = (CS_0024_003C_003E8__locals9.dHk ? FontStyles.Italic : FontStyles.Normal);
			FontWeight weight = (CS_0024_003C_003E8__locals9.FHl ? FontWeights.Bold : FontWeights.Normal);
			return new Typeface(new FontFamily(CS_0024_003C_003E8__locals9.JHA), style, weight, FontStretches.Normal);
		}));
	}

	internal static bool mn6()
	{
		return one == null;
	}

	internal static CanvasDrawCache Unw()
	{
		return one;
	}
}
