using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Rendering;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting.Implementation;

public class HighlightingStyle : ObservableObjectBase, IHighlightingStyle, INotifyPropertyChanged
{
	private Color? background;

	private bool JLe;

	private bool? HLl;

	private Color? XLA;

	private HighlightingStyleBorderCornerKind yLv;

	private LineKind mLm;

	private string SLC;

	private float GLu;

	private Color? mL1;

	private bool dLF;

	private bool xL3;

	private bool rLR;

	private bool qLY;

	private bool NL4;

	private bool? cLo;

	private LineKind jLj;

	private object SLw;

	private LineKind oL6;

	private Color? MLH;

	private TextLineWeight JLb;

	private Color? pLT;

	private TextLineWeight lLL;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool hLn;

	private static HighlightingStyle KW8;

	public Color? Background
	{
		get
		{
			return background;
		}
		set
		{
			if (!(background == value))
			{
				background = value;
				qLg();
				NotifyPropertyChanged(Q7Z.tqM(194448));
			}
		}
	}

	public bool BackgroundSpansVirtualSpace
	{
		get
		{
			return JLe;
		}
		set
		{
			if (JLe != value)
			{
				JLe = value;
				qLg();
				NotifyPropertyChanged(Q7Z.tqM(194472));
			}
		}
	}

	public bool? Bold
	{
		get
		{
			return HLl;
		}
		set
		{
			if (HLl != value)
			{
				HLl = value;
				qLg();
				NotifyPropertyChanged(Q7Z.tqM(194530));
			}
		}
	}

	public Color? BorderColor
	{
		get
		{
			return XLA;
		}
		set
		{
			if (!(XLA == value))
			{
				XLA = value;
				qLg();
				NotifyPropertyChanged(Q7Z.tqM(194542));
			}
		}
	}

	public HighlightingStyleBorderCornerKind BorderCornerKind
	{
		get
		{
			return yLv;
		}
		set
		{
			if (yLv != value)
			{
				yLv = value;
				qLg();
				NotifyPropertyChanged(Q7Z.tqM(194568));
			}
		}
	}

	public LineKind BorderKind
	{
		get
		{
			return mLm;
		}
		set
		{
			if (mLm != value)
			{
				mLm = value;
				qLg();
				NotifyPropertyChanged(Q7Z.tqM(194604));
			}
		}
	}

	public string FontFamilyName
	{
		get
		{
			return SLC;
		}
		set
		{
			if (!(SLC == value))
			{
				SLC = value;
				qLg();
				NotifyPropertyChanged(Q7Z.tqM(194628));
			}
		}
	}

	[TypeConverter(typeof(FontSizeConverter))]
	public float FontSize
	{
		get
		{
			return GLu;
		}
		set
		{
			if (GLu != value)
			{
				GLu = value;
				qLg();
				NotifyPropertyChanged(Q7Z.tqM(194660));
			}
		}
	}

	public Color? Foreground
	{
		get
		{
			return mL1;
		}
		set
		{
			if (!(mL1 == value))
			{
				mL1 = value;
				qLg();
				NotifyPropertyChanged(Q7Z.tqM(194680));
			}
		}
	}

	public bool HasBackground => Background.HasValue;

	public bool HasBorder => (Foreground.HasValue || BorderColor.HasValue) && BorderKind != LineKind.None;

	public bool HasDefaultFormatting
	{
		[CompilerGenerated]
		get
		{
			return hLn;
		}
		[CompilerGenerated]
		private set
		{
			hLn = value;
		}
	}

	public bool HasFontChange => FontFamilyName != null || (double)FontSize > 0.0;

	public bool HasStrikethrough => (Foreground.HasValue || StrikethroughColor.HasValue) && StrikethroughKind != LineKind.None;

	public bool HasUnderline => (Foreground.HasValue || UnderlineColor.HasValue) && UnderlineKind != LineKind.None;

	public bool IsBackgroundEditable
	{
		get
		{
			return dLF;
		}
		set
		{
			if (dLF != value)
			{
				dLF = value;
				NotifyPropertyChanged(Q7Z.tqM(194704));
			}
		}
	}

	public bool IsBoldEditable
	{
		get
		{
			return xL3;
		}
		set
		{
			if (xL3 != value)
			{
				xL3 = value;
				NotifyPropertyChanged(Q7Z.tqM(194748));
			}
		}
	}

	public bool IsBorderEditable
	{
		get
		{
			return rLR;
		}
		set
		{
			if (rLR != value)
			{
				rLR = value;
				NotifyPropertyChanged(Q7Z.tqM(194780));
			}
		}
	}

	public bool IsForegroundEditable
	{
		get
		{
			return qLY;
		}
		set
		{
			if (qLY != value)
			{
				qLY = value;
				NotifyPropertyChanged(Q7Z.tqM(194816));
			}
		}
	}

	public bool IsItalicEditable
	{
		get
		{
			return NL4;
		}
		set
		{
			if (NL4 != value)
			{
				NL4 = value;
				NotifyPropertyChanged(Q7Z.tqM(194860));
			}
		}
	}

	public bool? Italic
	{
		get
		{
			return cLo;
		}
		set
		{
			if (cLo != value)
			{
				cLo = value;
				qLg();
				NotifyPropertyChanged(Q7Z.tqM(194896));
			}
		}
	}

	public Color? StrikethroughColor
	{
		get
		{
			return MLH;
		}
		set
		{
			if (!(MLH == value))
			{
				MLH = value;
				qLg();
				NotifyPropertyChanged(Q7Z.tqM(194912));
			}
		}
	}

	public LineKind StrikethroughKind
	{
		get
		{
			return jLj;
		}
		set
		{
			if (jLj != value)
			{
				jLj = value;
				qLg();
				NotifyPropertyChanged(Q7Z.tqM(194952));
			}
		}
	}

	public TextLineWeight StrikethroughWeight
	{
		get
		{
			return JLb;
		}
		set
		{
			if (JLb != value)
			{
				JLb = value;
				qLg();
				NotifyPropertyChanged(Q7Z.tqM(194990));
			}
		}
	}

	public object Tag
	{
		get
		{
			return SLw;
		}
		set
		{
			if (SLw != value)
			{
				SLw = value;
				NotifyPropertyChanged(Q7Z.tqM(13964));
			}
		}
	}

	public Color? UnderlineColor
	{
		get
		{
			return pLT;
		}
		set
		{
			if (!(pLT == value))
			{
				pLT = value;
				qLg();
				NotifyPropertyChanged(Q7Z.tqM(195116));
			}
		}
	}

	public LineKind UnderlineKind
	{
		get
		{
			return oL6;
		}
		set
		{
			if (oL6 != value)
			{
				oL6 = value;
				qLg();
				NotifyPropertyChanged(Q7Z.tqM(195148));
			}
		}
	}

	public TextLineWeight UnderlineWeight
	{
		get
		{
			return lLL;
		}
		set
		{
			if (lLL != value)
			{
				lLL = value;
				qLg();
				NotifyPropertyChanged(Q7Z.tqM(195178));
			}
		}
	}

	public HighlightingStyle()
	{
		grA.DaB7cz();
		this._002Ector(null, null, null, null, LineKind.None, backgroundSpansVirtualSpace: false);
	}

	public HighlightingStyle(Color? foreground)
	{
		grA.DaB7cz();
		this._002Ector(foreground, null, null, null, LineKind.None, backgroundSpansVirtualSpace: false);
	}

	public HighlightingStyle(Color? foreground, Color? background)
	{
		grA.DaB7cz();
		this._002Ector(foreground, background, null, null, LineKind.None, backgroundSpansVirtualSpace: false);
	}

	public HighlightingStyle(Color? foreground, Color? background, bool? bold, bool? italic, LineKind underlineKind)
	{
		grA.DaB7cz();
		this._002Ector(foreground, background, bold, italic, underlineKind, backgroundSpansVirtualSpace: false);
	}

	public HighlightingStyle(Color? foreground, Color? background, bool? bold, bool? italic, LineKind underlineKind, bool backgroundSpansVirtualSpace)
	{
		grA.DaB7cz();
		dLF = true;
		xL3 = true;
		qLY = true;
		NL4 = true;
		base._002Ector();
		mL1 = foreground;
		this.background = background;
		HLl = bold;
		cLo = italic;
		oL6 = underlineKind;
		JLe = backgroundSpansVirtualSpace;
		qLg();
	}

	private void qLg()
	{
		HasDefaultFormatting = !mL1.HasValue && !background.HasValue && !HLl.HasValue && !cLo.HasValue && SLC == null && GLu <= 0f && !XLA.HasValue && mLm == LineKind.None && yLv == HighlightingStyleBorderCornerKind.Square && oL6 == LineKind.None && jLj == LineKind.None && !pLT.HasValue && lLL == TextLineWeight.Single && !MLH.HasValue && JLb == TextLineWeight.Single && !JLe;
	}

	public override string ToString()
	{
		return Q7Z.tqM(195032) + (Foreground.HasValue ? Foreground.ToString() : Q7Z.tqM(195072)) + Q7Z.tqM(11640);
	}

	internal static bool VWU()
	{
		return KW8 == null;
	}

	internal static HighlightingStyle qWe()
	{
		return KW8;
	}
}
