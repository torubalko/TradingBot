using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Products.Text;
using ActiproSoftware.Text.Implementation;
using dg3ypDAonQcOidMs0w;

namespace ActiproSoftware.Text;

public static class TextChangeTypes
{
	private static ITextChangeType kP;

	private static ITextChangeType Tp;

	private static ITextChangeType ob;

	private static ITextChangeType wC;

	private static ITextChangeType LU;

	private static ITextChangeType wa;

	private static ITextChangeType nj;

	private static ITextChangeType fF;

	private static ITextChangeType nx;

	private static ITextChangeType lg;

	private static ITextChangeType nO;

	private static ITextChangeType Bl;

	private static ITextChangeType ei;

	private static ITextChangeType OW;

	private static ITextChangeType u5;

	private static ITextChangeType m6;

	private static ITextChangeType RZ;

	private static ITextChangeType H0;

	private static ITextChangeType yv;

	private static ITextChangeType UY;

	private static ITextChangeType No;

	private static ITextChangeType MD;

	private static ITextChangeType x1;

	private static ITextChangeType x4;

	private static ITextChangeType gK;

	private static ITextChangeType vk;

	private static ITextChangeType oE;

	private static ITextChangeType vr;

	private static ITextChangeType R3;

	private static ITextChangeType SJ;

	private static ITextChangeType hX;

	private static ITextChangeType fN;

	private static ITextChangeType tR;

	private static ITextChangeType zf;

	private static ITextChangeType ct;

	private static ITextChangeType KQ;

	private static ITextChangeType fn;

	private static TextChangeTypes gtd;

	public static ITextChangeType AutoComplete
	{
		get
		{
			if (kP == null)
			{
				kP = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(296), SR.GetString(SRName.UITextChangeTypeAutoComplete));
			}
			return kP;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "AutoCorrect")]
	public static ITextChangeType AutoCorrect
	{
		get
		{
			if (Tp == null)
			{
				Tp = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(324), SR.GetString(SRName.UITextChangeTypeAutoCorrect));
			}
			return Tp;
		}
	}

	public static ITextChangeType AutoFormat
	{
		get
		{
			if (ob == null)
			{
				ob = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(350), SR.GetString(SRName.UITextChangeTypeAutoFormat));
			}
			return ob;
		}
	}

	public static ITextChangeType AutoIndent
	{
		get
		{
			if (wC == null)
			{
				wC = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(374), SR.GetString(SRName.UITextChangeTypeAutoIndent));
			}
			return wC;
		}
	}

	public static ITextChangeType AutoReplace
	{
		get
		{
			if (LU == null)
			{
				LU = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(398), SR.GetString(SRName.UITextChangeTypeAutoReplace));
			}
			return LU;
		}
	}

	public static ITextChangeType Backspace
	{
		get
		{
			if (wa == null)
			{
				wa = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(424), SR.GetString(SRName.UITextChangeTypeBackspace));
			}
			return wa;
		}
	}

	public static ITextChangeType ChangeCase
	{
		get
		{
			if (nj == null)
			{
				nj = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(446), SR.GetString(SRName.UITextChangeTypeChangeCase));
			}
			return nj;
		}
	}

	public static ITextChangeType CommentLines
	{
		get
		{
			if (fF == null)
			{
				fF = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(470), SR.GetString(SRName.UITextChangeTypeCommentLines));
			}
			return fF;
		}
	}

	public static ITextChangeType ConvertSpacesToTabs
	{
		get
		{
			if (nx == null)
			{
				nx = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(498), SR.GetString(SRName.UITextChangeTypeConvertSpacesToTabs));
			}
			return nx;
		}
	}

	public static ITextChangeType ConvertTabsToSpaces
	{
		get
		{
			if (lg == null)
			{
				lg = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(540), SR.GetString(SRName.UITextChangeTypeConvertTabsToSpaces));
			}
			return lg;
		}
	}

	public static ITextChangeType Custom
	{
		get
		{
			if (nO == null)
			{
				nO = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(582), SR.GetString(SRName.UITextChangeTypeCustom));
			}
			return nO;
		}
	}

	public static ITextChangeType Cut
	{
		get
		{
			if (Bl == null)
			{
				Bl = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(598), SR.GetString(SRName.UITextChangeTypeCut));
			}
			return Bl;
		}
	}

	public static ITextChangeType Delete
	{
		get
		{
			if (ei == null)
			{
				ei = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(608), SR.GetString(SRName.UITextChangeTypeDelete));
			}
			return ei;
		}
	}

	public static ITextChangeType DragAndDrop
	{
		get
		{
			if (OW == null)
			{
				OW = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(624), SR.GetString(SRName.UITextChangeTypeDragAndDrop));
			}
			return OW;
		}
	}

	public static ITextChangeType Duplicate
	{
		get
		{
			if (u5 == null)
			{
				u5 = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(650), SR.GetString(SRName.UITextChangeTypeDuplicate));
			}
			return u5;
		}
	}

	public static ITextChangeType Enter
	{
		get
		{
			if (m6 == null)
			{
				m6 = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(672), SR.GetString(SRName.UITextChangeTypeEnter));
			}
			return m6;
		}
	}

	public static ITextChangeType HeaderAndFooterChange
	{
		get
		{
			if (RZ == null)
			{
				RZ = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(686), SR.GetString(SRName.UITextChangeTypeHeaderAndFooterChange));
			}
			return RZ;
		}
	}

	public static ITextChangeType Indent
	{
		get
		{
			if (H0 == null)
			{
				H0 = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(732), SR.GetString(SRName.UITextChangeTypeIndent));
			}
			return H0;
		}
	}

	public static ITextChangeType InsertCodeSnippetTemplate
	{
		get
		{
			if (yv == null)
			{
				yv = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(748), SR.GetString(SRName.UITextChangeTypeInsertCodeSnippetTemplate));
			}
			return yv;
		}
	}

	public static ITextChangeType InsertFile
	{
		get
		{
			if (UY == null)
			{
				UY = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(802), SR.GetString(SRName.UITextChangeTypeInsertFile));
			}
			return UY;
		}
	}

	public static ITextChangeType MoveSelectedLinesDown
	{
		get
		{
			if (No == null)
			{
				No = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(826), SR.GetString(SRName.UITextChangeTypeMoveSelectedLinesDown));
			}
			return No;
		}
	}

	public static ITextChangeType MoveSelectedLinesUp
	{
		get
		{
			if (MD == null)
			{
				MD = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(872), SR.GetString(SRName.UITextChangeTypeMoveSelectedLinesUp));
			}
			return MD;
		}
	}

	public static ITextChangeType OpenLine
	{
		get
		{
			if (x1 == null)
			{
				x1 = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(914), SR.GetString(SRName.UITextChangeTypeOpenLine));
			}
			return x1;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Outdent")]
	public static ITextChangeType Outdent
	{
		get
		{
			if (x4 == null)
			{
				x4 = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(934), SR.GetString(SRName.UITextChangeTypeOutdent));
			}
			return x4;
		}
	}

	public static ITextChangeType Paste
	{
		get
		{
			if (gK == null)
			{
				gK = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(952), SR.GetString(SRName.UITextChangeTypePaste));
			}
			return gK;
		}
	}

	public static ITextChangeType Replace
	{
		get
		{
			if (vk == null)
			{
				vk = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(966), SR.GetString(SRName.UITextChangeTypeReplace));
			}
			return vk;
		}
	}

	public static ITextChangeType ReplaceAll
	{
		get
		{
			if (oE == null)
			{
				oE = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(984), SR.GetString(SRName.UITextChangeTypeReplaceAll));
			}
			return oE;
		}
	}

	public static ITextChangeType SpellingChange
	{
		get
		{
			if (vr == null)
			{
				vr = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1008), SR.GetString(SRName.UITextChangeTypeSpellingChange));
			}
			return vr;
		}
	}

	public static ITextChangeType TextReplacement
	{
		get
		{
			if (R3 == null)
			{
				R3 = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1040), SR.GetString(SRName.UITextChangeTypeTextReplacement));
			}
			return R3;
		}
	}

	public static ITextChangeType ToggleCase
	{
		get
		{
			if (SJ == null)
			{
				SJ = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1074), SR.GetString(SRName.UITextChangeTypeToggleCase));
			}
			return SJ;
		}
	}

	public static ITextChangeType TransposeCharacters
	{
		get
		{
			if (hX == null)
			{
				hX = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1098), SR.GetString(SRName.UITextChangeTypeTransposeCharacters));
			}
			return hX;
		}
	}

	public static ITextChangeType TransposeLines
	{
		get
		{
			if (fN == null)
			{
				fN = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1140), SR.GetString(SRName.UITextChangeTypeTransposeLines));
			}
			return fN;
		}
	}

	public static ITextChangeType TransposeWords
	{
		get
		{
			if (tR == null)
			{
				tR = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1172), SR.GetString(SRName.UITextChangeTypeTransposeWords));
			}
			return tR;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public static ITextChangeType TrimTrailingWhitespace
	{
		get
		{
			if (zf == null)
			{
				zf = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1204), SR.GetString(SRName.UITextChangeTypeTrimTrailingWhitespace));
			}
			return zf;
		}
	}

	public static ITextChangeType Typing
	{
		get
		{
			if (ct == null)
			{
				ct = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1252), SR.GetString(SRName.UITextChangeTypeTyping));
			}
			return ct;
		}
	}

	public static ITextChangeType UncommentLines
	{
		get
		{
			if (KQ == null)
			{
				KQ = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1268), SR.GetString(SRName.UITextChangeTypeUncommentLines));
			}
			return KQ;
		}
	}

	public static ITextChangeType UpdateCodeSnippetTemplateFields
	{
		get
		{
			if (fn == null)
			{
				fn = new TextChangeType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1300), SR.GetString(SRName.UITextChangeTypeUpdateCodeSnippetTemplateFields));
			}
			return fn;
		}
	}

	internal static bool dti()
	{
		return gtd == null;
	}

	internal static TextChangeTypes ktt()
	{
		return gtd;
	}
}
