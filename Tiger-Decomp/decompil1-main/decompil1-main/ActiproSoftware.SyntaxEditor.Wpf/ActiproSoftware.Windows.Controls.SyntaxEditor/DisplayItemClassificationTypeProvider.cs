using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public class DisplayItemClassificationTypeProvider
{
	private IHighlightingStyleRegistry ix;

	private IClassificationType yG;

	private IClassificationType XX;

	private IClassificationType RK;

	private IClassificationType vf;

	private IClassificationType WD;

	private IClassificationType vg;

	private IClassificationType QQ;

	private IClassificationType ee;

	private IClassificationType Tl;

	private IClassificationType lA;

	private IClassificationType Gv;

	private IClassificationType km;

	private IClassificationType vC;

	private IClassificationType du;

	private IClassificationType G1;

	private IClassificationType YF;

	private IClassificationType I3;

	private IClassificationType NR;

	private IClassificationType MY;

	private IClassificationType q4;

	private IClassificationType lo;

	private IClassificationType oj;

	private IClassificationType Rw;

	internal static double h6;

	internal static Color? OH;

	internal static Color? lb;

	internal static Color? gT;

	internal static Color? wL;

	internal static Color? on;

	internal static Color p8;

	internal static Color KI;

	internal static Color A5;

	internal static Color I0;

	internal static Color tB;

	internal static Color iV;

	internal static Color Ur;

	internal static Color Rs;

	internal static Color Mk;

	internal static Color qS;

	internal static Color C9;

	internal static Color Jy;

	internal static Color eq;

	internal static Color y2;

	internal static Color m7;

	internal static Color Bi;

	internal static Color Mp;

	internal static Color uM;

	internal static Color uO;

	internal static Color qU;

	internal static Color UJ;

	internal static Color Et;

	internal static Color UZ;

	internal static Color bh;

	internal static Color QN;

	internal static Color Wd;

	internal static Color uz;

	internal static Color gPW;

	internal static Color XPP;

	internal static Color hPE;

	internal static Color APc;

	internal static string rPa;

	internal static float jPx;

	internal static DisplayItemClassificationTypeProvider YF;

	public IClassificationType BreakpointDisabled
	{
		get
		{
			if (yG == null)
			{
				yG = ix.GetClassificationType(cT.BreakpointDisabled.Key);
				if (yG == null)
				{
					Color ur = Ur;
					int num = 0;
					if (uJ() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					yG = cT.BreakpointDisabled;
					ix.Register(yG, new HighlightingStyle
					{
						BorderColor = ur,
						BorderKind = LineKind.Solid,
						IsBackgroundEditable = false,
						IsBoldEditable = false,
						IsBorderEditable = true,
						IsForegroundEditable = false,
						IsItalicEditable = false
					});
				}
			}
			return yG;
		}
	}

	public IClassificationType BreakpointEnabled
	{
		get
		{
			if (XX == null)
			{
				XX = ix.GetClassificationType(cT.BreakpointEnabled.Key);
				bool flag = XX == null;
				int num = 0;
				if (uJ() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (flag)
				{
					Color mk = Mk;
					Color rs = Rs;
					XX = cT.BreakpointEnabled;
					ix.Register(XX, new HighlightingStyle(mk, rs)
					{
						IsBoldEditable = false,
						IsItalicEditable = false
					});
				}
			}
			return XX;
		}
	}

	public IClassificationType CodeSnippetDependentField
	{
		get
		{
			if (RK == null)
			{
				int num = 0;
				if (uJ() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				RK = ix.GetClassificationType(cT.CodeSnippetDependentField.Key);
				if (RK == null)
				{
					Color black = Colors.Black;
					RK = cT.CodeSnippetDependentField;
					ix.Register(RK, new HighlightingStyle
					{
						BorderColor = black,
						BorderKind = LineKind.Dot,
						IsBackgroundEditable = false,
						IsBoldEditable = false,
						IsBorderEditable = true,
						IsForegroundEditable = false,
						IsItalicEditable = false
					});
				}
			}
			return RK;
		}
	}

	public IClassificationType CodeSnippetField
	{
		get
		{
			if (vf == null)
			{
				vf = ix.GetClassificationType(cT.CodeSnippetField.Key);
				if (vf == null)
				{
					Color value = qS;
					vf = cT.CodeSnippetField;
					ix.Register(vf, new HighlightingStyle(null, value)
					{
						IsBoldEditable = false,
						IsForegroundEditable = false,
						IsItalicEditable = false
					});
				}
			}
			return vf;
		}
	}

	public IClassificationType CollapsedText
	{
		get
		{
			if (WD == null)
			{
				WD = ix.GetClassificationType(cT.CollapsedText.Key);
				int num = 0;
				if (!B9())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (WD == null)
				{
					Color gray = Colors.Gray;
					WD = cT.CollapsedText;
					ix.Register(WD, new HighlightingStyle(gray)
					{
						IsBackgroundEditable = false,
						IsBoldEditable = false,
						IsItalicEditable = false
					});
				}
			}
			return WD;
		}
	}

	public IClassificationType CollapsibleRegion
	{
		get
		{
			if (vg == null)
			{
				vg = ix.GetClassificationType(cT.CollapsibleRegion.Key);
				if (vg == null)
				{
					Color kI = KI;
					Color value = p8;
					vg = cT.CollapsibleRegion;
					ix.Register(vg, new HighlightingStyle(kI, value)
					{
						IsBoldEditable = false,
						IsItalicEditable = false
					});
				}
			}
			IClassificationType classificationType = vg;
			int num = 0;
			if (!B9())
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => classificationType, 
			};
		}
	}

	public IClassificationType CurrentLine
	{
		get
		{
			if (QQ == null)
			{
				QQ = ix.GetClassificationType(cT.CurrentLine.Key);
				if (QQ == null)
				{
					Color a = A5;
					QQ = cT.CurrentLine;
					ix.Register(QQ, new HighlightingStyle
					{
						BorderColor = a,
						BorderKind = LineKind.Solid,
						IsBoldEditable = false,
						IsBorderEditable = true,
						IsForegroundEditable = false,
						IsItalicEditable = false
					});
				}
			}
			return QQ;
		}
	}

	public IClassificationType CurrentStatement
	{
		get
		{
			if (ee == null)
			{
				ee = ix.GetClassificationType(cT.CurrentStatement.Key);
				if (ee == null)
				{
					Color jy = Jy;
					Color c = C9;
					int num = 0;
					if (uJ() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					ee = cT.CurrentStatement;
					ix.Register(ee, new HighlightingStyle(jy, c)
					{
						IsBoldEditable = false,
						IsItalicEditable = false
					});
				}
			}
			return ee;
		}
	}

	public IClassificationType DelimiterMatching
	{
		get
		{
			if (Tl == null)
			{
				Tl = ix.GetClassificationType(cT.DelimiterMatching.Key);
				if (Tl == null)
				{
					Color i = I0;
					Tl = cT.DelimiterMatching;
					ix.Register(Tl, new HighlightingStyle
					{
						Background = i,
						IsBoldEditable = false,
						IsForegroundEditable = false,
						IsItalicEditable = false
					});
				}
			}
			return Tl;
		}
	}

	public IClassificationType FindMatchHighlight
	{
		get
		{
			if (lA == null)
			{
				lA = ix.GetClassificationType(cT.FindMatchHighlight.Key);
				if (lA == null)
				{
					Color value = tB;
					int num = 0;
					if (!B9())
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					lA = cT.FindMatchHighlight;
					ix.Register(lA, new HighlightingStyle
					{
						Background = value,
						IsBoldEditable = false,
						IsForegroundEditable = false,
						IsItalicEditable = false
					});
				}
			}
			return lA;
		}
	}

	public IClassificationType FindScopeHighlight
	{
		get
		{
			if (Gv == null)
			{
				Gv = ix.GetClassificationType(cT.FindScopeHighlight.Key);
				if (Gv == null)
				{
					int num = 0;
					if (!B9())
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					Color value = eq;
					Gv = cT.FindScopeHighlight;
					ix.Register(Gv, new HighlightingStyle
					{
						Background = value,
						IsBoldEditable = false,
						IsForegroundEditable = false,
						IsItalicEditable = false
					});
				}
			}
			return Gv;
		}
	}

	public IClassificationType InactiveSelectedText
	{
		get
		{
			if (km == null)
			{
				km = ix.GetClassificationType(cT.InactiveSelectedText.Key);
				if (km == null)
				{
					Color value = y2;
					km = cT.InactiveSelectedText;
					ix.Register(km, new HighlightingStyle
					{
						Background = value,
						IsForegroundEditable = false,
						IsBoldEditable = false,
						IsItalicEditable = false
					});
				}
			}
			IClassificationType classificationType = km;
			int num = 0;
			if (uJ() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => classificationType, 
			};
		}
	}

	public IClassificationType IndentationGuides
	{
		get
		{
			if (vC == null)
			{
				int num = 0;
				if (uJ() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				vC = ix.GetClassificationType(cT.IndentationGuides.Key);
				if (vC == null)
				{
					Color value = iV;
					vC = cT.IndentationGuides;
					ix.Register(vC, new HighlightingStyle
					{
						Background = value,
						IsBoldEditable = false,
						IsForegroundEditable = false,
						IsItalicEditable = false
					});
				}
			}
			return vC;
		}
	}

	public IClassificationType IndicatorMargin
	{
		get
		{
			if (du == null)
			{
				du = ix.GetClassificationType(cT.IndicatorMargin.Key);
				if (du == null)
				{
					Color value = m7;
					du = cT.IndicatorMargin;
					ix.Register(du, new HighlightingStyle
					{
						Background = value,
						IsBoldEditable = false,
						IsForegroundEditable = false,
						IsItalicEditable = false
					});
				}
			}
			return du;
		}
	}

	public IClassificationType LineNumbers
	{
		get
		{
			if (G1 == null)
			{
				G1 = ix.GetClassificationType(cT.LineNumbers.Key);
				if (G1 == null)
				{
					Color bi = Bi;
					G1 = cT.LineNumbers;
					int num = 0;
					if (!B9())
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					ix.Register(G1, new HighlightingStyle(bi)
					{
						IsBoldEditable = false,
						IsItalicEditable = false
					});
				}
			}
			return G1;
		}
	}

	public IClassificationType OutliningMarginSquare
	{
		get
		{
			if (this.YF == null)
			{
				this.YF = ix.GetClassificationType(cT.OutliningMarginSquare.Key);
				if (this.YF == null)
				{
					Color value = uM;
					Color mp = Mp;
					this.YF = cT.OutliningMarginSquare;
					ix.Register(this.YF, new HighlightingStyle(value, mp)
					{
						IsBoldEditable = false,
						IsItalicEditable = false
					});
				}
			}
			IClassificationType yF = this.YF;
			int num = 0;
			if (uJ() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => yF, 
			};
		}
	}

	public IClassificationType OutliningMarginVerticalRule
	{
		get
		{
			int num = 1;
			int num2 = num;
			bool flag = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 1:
					flag = I3 == null;
					num2 = 0;
					if (uJ() != null)
					{
						num2 = 0;
					}
					continue;
				}
				if (flag)
				{
					I3 = ix.GetClassificationType(cT.OutliningMarginVerticalRule.Key);
					if (I3 == null)
					{
						Color value = uO;
						I3 = cT.OutliningMarginVerticalRule;
						ix.Register(I3, new HighlightingStyle(value)
						{
							IsBackgroundEditable = false,
							IsBoldEditable = false,
							IsItalicEditable = false
						});
					}
				}
				return I3;
			}
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "PlainText")]
	public IClassificationType PlainText
	{
		get
		{
			if (NR == null)
			{
				NR = ix.GetClassificationType(cT.PlainText.Key);
				if (NR == null)
				{
					NR = cT.PlainText;
					ix.Register(NR, new HighlightingStyle
					{
						IsBoldEditable = false,
						IsItalicEditable = false
					});
				}
			}
			return NR;
		}
	}

	public IClassificationType RevertedChangesMark
	{
		get
		{
			if (MY == null)
			{
				MY = ix.GetClassificationType(cT.RevertedChangesMark.Key);
				if (MY == null)
				{
					Color value = uz;
					MY = cT.RevertedChangesMark;
					ix.Register(MY, new HighlightingStyle
					{
						Background = value,
						IsForegroundEditable = false,
						IsBoldEditable = false,
						IsItalicEditable = false
					});
					int num = 0;
					if (uJ() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
				}
			}
			return MY;
		}
	}

	public IClassificationType SavedChangesMark
	{
		get
		{
			if (q4 == null)
			{
				q4 = ix.GetClassificationType(cT.SavedChangesMark.Key);
				if (q4 == null)
				{
					int num = 0;
					if (uJ() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					Color value = gPW;
					q4 = cT.SavedChangesMark;
					ix.Register(q4, new HighlightingStyle
					{
						Background = value,
						IsForegroundEditable = false,
						IsBoldEditable = false,
						IsItalicEditable = false
					});
				}
			}
			return q4;
		}
	}

	public IClassificationType SelectedText
	{
		get
		{
			if (lo == null)
			{
				lo = ix.GetClassificationType(cT.SelectedText.Key);
				if (lo == null)
				{
					Color value = bh;
					lo = cT.SelectedText;
					ix.Register(lo, new HighlightingStyle
					{
						Background = value,
						IsForegroundEditable = false,
						IsBoldEditable = false,
						IsItalicEditable = false
					});
				}
			}
			return lo;
		}
	}

	public IClassificationType UnsavedChangesMark
	{
		get
		{
			if (oj == null)
			{
				oj = ix.GetClassificationType(cT.UnsavedChangesMark.Key);
				if (oj == null)
				{
					Color xPP = XPP;
					oj = cT.UnsavedChangesMark;
					int num = 0;
					if (uJ() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					ix.Register(oj, new HighlightingStyle
					{
						Background = xPP,
						IsForegroundEditable = false,
						IsBoldEditable = false,
						IsItalicEditable = false
					});
				}
			}
			return oj;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public IClassificationType VisibleWhitespace
	{
		get
		{
			if (Rw == null)
			{
				Rw = ix.GetClassificationType(cT.VisibleWhitespace.Key);
				if (Rw == null)
				{
					Color qN = QN;
					int num = 0;
					if (uJ() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					Rw = cT.VisibleWhitespace;
					ix.Register(Rw, new HighlightingStyle(qN)
					{
						IsBackgroundEditable = false,
						IsBoldEditable = false,
						IsItalicEditable = false
					});
				}
			}
			return Rw;
		}
	}

	public DisplayItemClassificationTypeProvider()
	{
		grA.DaB7cz();
		this._002Ector(null);
	}

	public DisplayItemClassificationTypeProvider(IHighlightingStyleRegistry registry)
	{
		grA.DaB7cz();
		base._002Ector();
		ix = registry ?? AmbientHighlightingStyleRegistry.Instance;
	}

	public IEnumerable<IClassificationType> RegisterAll()
	{
		return new IClassificationType[23]
		{
			BreakpointDisabled, BreakpointEnabled, CodeSnippetDependentField, CodeSnippetField, CollapsedText, CollapsibleRegion, CurrentLine, CurrentStatement, DelimiterMatching, FindMatchHighlight,
			FindScopeHighlight, InactiveSelectedText, IndentationGuides, IndicatorMargin, LineNumbers, OutliningMarginSquare, OutliningMarginVerticalRule, PlainText, RevertedChangesMark, SavedChangesMark,
			SelectedText, UnsavedChangesMark, VisibleWhitespace
		};
	}

	static DisplayItemClassificationTypeProvider()
	{
		grA.DaB7cz();
		h6 = 0.4;
		OH = null;
		lb = null;
		gT = null;
		wL = null;
		on = null;
		p8 = Color.FromArgb(128, 237, 239, 245);
		KI = Color.FromArgb(128, 215, 221, 232);
		int num = 2;
		if (false)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		do
		{
			IL_0009_2:
			switch (num)
			{
			case 3:
				Et = Color.FromArgb(byte.MaxValue, 227, 227, 227);
				UZ = Color.FromArgb(byte.MaxValue, 128, 128, 128);
				bh = Color.FromArgb(byte.MaxValue, 153, 204, byte.MaxValue);
				QN = Color.FromArgb(byte.MaxValue, 43, 145, 175);
				Wd = Color.FromArgb(byte.MaxValue, 43, 145, 175);
				uz = Color.FromArgb(byte.MaxValue, 247, 201, 60);
				num = 0;
				if (false)
				{
					num = 0;
				}
				goto IL_0009_2;
			default:
				gPW = Color.FromArgb(byte.MaxValue, 108, 226, 108);
				XPP = Color.FromArgb(byte.MaxValue, byte.MaxValue, 238, 98);
				hPE = Color.FromArgb(byte.MaxValue, 128, 128, 128);
				APc = Color.FromArgb(byte.MaxValue, 64, 64, 64);
				rPa = Q7Z.tqM(64);
				jPx = 12f;
				return;
			case 1:
				Ur = Color.FromArgb(byte.MaxValue, 171, 97, 107);
				Rs = Color.FromArgb(byte.MaxValue, 171, 97, 107);
				Mk = Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
				qS = Color.FromArgb(byte.MaxValue, byte.MaxValue, 225, 136);
				C9 = Color.FromArgb(byte.MaxValue, byte.MaxValue, 238, 98);
				Jy = Color.FromArgb(byte.MaxValue, 0, 0, 0);
				eq = Color.FromArgb(byte.MaxValue, 231, 235, 247);
				y2 = Color.FromArgb(byte.MaxValue, 204, 221, 238);
				m7 = Color.FromArgb(byte.MaxValue, 240, 240, 240);
				Bi = Color.FromArgb(byte.MaxValue, 43, 145, 175);
				Mp = Color.FromArgb(byte.MaxValue, 226, 226, 226);
				uM = Color.FromArgb(byte.MaxValue, 85, 85, 85);
				uO = Color.FromArgb(byte.MaxValue, 165, 165, 165);
				qU = Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
				UJ = Color.FromArgb(byte.MaxValue, 0, 0, 0);
				num = 3;
				goto IL_0009_2;
			case 2:
				break;
			}
			A5 = Color.FromArgb(48, 160, 160, 160);
			I0 = Color.FromArgb(48, 160, 160, 160);
			tB = Color.FromArgb(200, 244, 167, 33);
			iV = Color.FromArgb(64, 192, 192, 192);
			num = 1;
		}
		while (true);
		goto IL_0005;
	}

	internal static bool B9()
	{
		return YF == null;
	}

	internal static DisplayItemClassificationTypeProvider uJ()
	{
		return YF;
	}
}
