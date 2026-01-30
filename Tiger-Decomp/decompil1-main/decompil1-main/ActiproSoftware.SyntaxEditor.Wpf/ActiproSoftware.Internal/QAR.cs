using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;

namespace ActiproSoftware.Internal;

internal class QAR : ITextLayout, IDisposable
{
	private List<CAM> YHW;

	private NA5 vHP;

	private int[] UHE;

	private IList<TagSnapshotRange<IIntraLineSpacerTag>> jHc;

	private ITextLayout mHa;

	private static QAR WWp;

	public IList<ITextLayoutLine> Lines => mHa.Lines;

	public IList<ITextSpacer> Spacers => mHa.Spacers;

	public double SpaceWidth => mHa.SpaceWidth;

	public int TabSize
	{
		get
		{
			return mHa.TabSize;
		}
		set
		{
			mHa.TabSize = tabSize;
		}
	}

	public ITextProvider TextProvider => mHa.TextProvider;

	public TextFormattingMode TextFormattingMode
	{
		get
		{
			return mHa.TextFormattingMode;
		}
		set
		{
			mHa.TextFormattingMode = textFormattingMode;
		}
	}

	public TextLayoutWrapping TextWrapping
	{
		get
		{
			return mHa.TextWrapping;
		}
		set
		{
			mHa.TextWrapping = textWrapping;
		}
	}

	public QAR(NA5 P_0, ITextLayout P_1, IList<TagSnapshotRange<IIntraLineSpacerTag>> P_2)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(194008));
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(194044));
		}
		vHP = P_0;
		mHa = P_1;
		jHc = P_2;
	}

	public void e6M(TextRange P_0, IHighlightingStyle P_1)
	{
		CAM item = new CAM(P_0, P_1);
		if (YHW == null)
		{
			YHW = new List<CAM>();
		}
		YHW.Add(item);
	}

	[SpecialName]
	public IList<CAM> i6t()
	{
		return YHW;
	}

	public void Dispose()
	{
		mHa.Dispose();
	}

	public int R6O(Lazy<ITextBufferReader> P_0, ref ITextBufferReader P_1, int P_2)
	{
		if (UHE == null)
		{
			UHE = new int[Lines.Count];
			for (int num = UHE.Length - 1; num >= 0; num--)
			{
				UHE[num] = -1;
			}
		}
		if (P_2 < 0 || P_2 >= UHE.Length)
		{
			throw new ArgumentOutOfRangeException(Q7Z.tqM(194074));
		}
		if (UHE[P_2] == -1)
		{
			ITextLayoutLine textLayoutLine = Lines[P_2];
			int startCharacterIndex = textLayoutLine.StartCharacterIndex;
			int num2 = startCharacterIndex + Math.Max(0, textLayoutLine.CharacterCount - (textLayoutLine.HasHardLineBreak ? 1 : 0));
			ITextProvider textProvider = TextProvider;
			int offset = textProvider.Translate(startCharacterIndex, TextProviderTranslateModes.ToSourceText);
			int num3 = textProvider.Translate(num2, TextProviderTranslateModes.ToSourceText);
			if (P_1 == null)
			{
				P_1 = P_0.Value;
			}
			P_1.Offset = offset;
			while (!P_1.IsAtEnd && P_1.Offset < num3)
			{
				char c = P_1.Read();
				char c2 = c;
				char c3 = c2;
				if (c3 == '\t' || c3 == ' ')
				{
					continue;
				}
				num3 = P_1.Offset - 1;
				UHE[P_2] = textProvider.Translate(num3, TextProviderTranslateModes.FromSourceText);
				break;
			}
			if (UHE[P_2] == -1)
			{
				UHE[P_2] = num2;
			}
		}
		return UHE[P_2];
	}

	[SpecialName]
	public IList<TagSnapshotRange<IIntraLineSpacerTag>> A6h()
	{
		return jHc;
	}

	public void RunTextFormatter(IDisposable P_0)
	{
		mHa.RunTextFormatter(P_0);
	}

	public void V6U(ITextSnapshot P_0)
	{
		vHP.THl(P_0);
	}

	public void SetFontFamily(int P_0, int P_1, string P_2)
	{
		mHa.SetFontFamily(P_0, P_1, P_2);
	}

	public void SetFontSize(int P_0, int P_1, float P_2)
	{
		mHa.SetFontSize(P_0, P_1, P_2);
	}

	public void SetFontStyle(int P_0, int P_1, FontStyle P_2)
	{
		mHa.SetFontStyle(P_0, P_1, P_2);
	}

	public void SetFontWeight(int P_0, int P_1, FontWeight P_2)
	{
		mHa.SetFontWeight(P_0, P_1, P_2);
	}

	public void SetForeground(int P_0, int P_1, Color P_2)
	{
		mHa.SetForeground(P_0, P_1, P_2);
	}

	public void SetForeground(int P_0, int P_1, Brush P_2)
	{
		mHa.SetForeground(P_0, P_1, P_2);
	}

	public void SetStrikethrough(int P_0, int P_1, bool P_2)
	{
		mHa.SetStrikethrough(P_0, P_1, P_2);
	}

	public void SetStrikethrough(int P_0, int P_1, LineKind P_2, Color? P_3, TextLineWeight P_4 = TextLineWeight.Single)
	{
		mHa.SetStrikethrough(P_0, P_1, P_2, P_3, P_4);
	}

	public void SetStrikethrough(int P_0, int P_1, LineKind P_2, Brush P_3, TextLineWeight P_4 = TextLineWeight.Single)
	{
		mHa.SetStrikethrough(P_0, P_1, P_2, P_3, P_4);
	}

	public void SetUnderline(int P_0, int P_1, bool P_2)
	{
		mHa.SetUnderline(P_0, P_1, P_2);
	}

	public void SetUnderline(int P_0, int P_1, LineKind P_2, Color? P_3, TextLineWeight P_4 = TextLineWeight.Single)
	{
		mHa.SetUnderline(P_0, P_1, P_2, P_3, P_4);
	}

	public void SetUnderline(int P_0, int P_1, LineKind P_2, Brush P_3, TextLineWeight P_4 = TextLineWeight.Single)
	{
		mHa.SetUnderline(P_0, P_1, P_2, P_3, P_4);
	}

	public void a6J(int P_0)
	{
		vHP.JHA(P_0);
		if (YHW == null)
		{
			return;
		}
		foreach (CAM item in YHW)
		{
			item.UHx(P_0);
		}
	}

	[SpecialName]
	public IList<TextRange> j6d()
	{
		return vHP.sHm();
	}

	internal static bool eW4()
	{
		return WWp == null;
	}

	internal static QAR qWD()
	{
		return WWp;
	}
}
