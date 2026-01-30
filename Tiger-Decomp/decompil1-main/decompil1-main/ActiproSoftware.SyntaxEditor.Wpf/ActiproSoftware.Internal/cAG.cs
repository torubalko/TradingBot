using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Exporters;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;

namespace ActiproSoftware.Internal;

internal class cAG : YAZ, IRtfTextExporter, ITextExporter
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string S51;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private double v5F;

	private static cAG VGN;

	public override string DataFormat => DataFormats.Rtf;

	public string FontFamily
	{
		[CompilerGenerated]
		get
		{
			return S51;
		}
		[CompilerGenerated]
		set
		{
			S51 = s;
		}
	}

	public double FontSizeInPoints
	{
		[CompilerGenerated]
		get
		{
			return v5F;
		}
		[CompilerGenerated]
		set
		{
			v5F = num;
		}
	}

	private static void M5C(StringBuilder P_0, string P_1)
	{
		foreach (char c in P_1)
		{
			switch (c)
			{
			case '\\':
				P_0.Append(Q7Z.tqM(201518));
				continue;
			case '{':
				P_0.Append(Q7Z.tqM(201526));
				continue;
			case '}':
				P_0.Append(Q7Z.tqM(201534));
				continue;
			case '\n':
				P_0.Append(Q7Z.tqM(201542));
				continue;
			case '\r':
				continue;
			}
			if (c >= '\u0080')
			{
				P_0.Append(Q7Z.tqM(201558));
				int num = c;
				P_0.Append(num.ToString(CultureInfo.InvariantCulture));
				P_0.Append(Q7Z.tqM(195936));
			}
			else
			{
				P_0.Append(c);
			}
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private static IHighlightingStyle P5u(StringBuilder P_0, IHighlightingStyleRegistry P_1, IHighlightingStyle P_2, IClassificationTag P_3, List<Color> P_4)
	{
		IClassificationType classificationType = P_3?.ClassificationType;
		IHighlightingStyle highlightingStyle = ((classificationType != null) ? P_1.oLD(P_3, classificationType) : null);
		if (P_2 != highlightingStyle)
		{
			if (P_2 != null && !P_2.HasDefaultFormatting)
			{
				if (P_2.Background.HasValue)
				{
					Color? background = P_2.Background;
					if (background.HasValue && background.Value.A > 0)
					{
						P_0.Append(Q7Z.tqM(201566));
					}
				}
				if (P_2.Bold == true)
				{
					P_0.Append(Q7Z.tqM(201614));
				}
				if (P_2.Italic == true)
				{
					P_0.Append(Q7Z.tqM(201624));
				}
				if (P_2.UnderlineKind != LineKind.None)
				{
					P_0.Append(Q7Z.tqM(201634));
				}
				P_0.Append(Q7Z.tqM(201646));
				P_0.Append(Q7Z.tqM(195936));
			}
			if (highlightingStyle != null && !highlightingStyle.HasDefaultFormatting)
			{
				Color? foreground = highlightingStyle.Foreground;
				Color item = ((foreground.HasValue && foreground.Value.A > 0) ? foreground.Value : Colors.Black);
				int num = P_4.IndexOf(item) + 1;
				if (num == 0)
				{
					P_4.Add(item);
					num = P_4.Count;
				}
				P_0.Append(Q7Z.tqM(201658) + num);
				if (highlightingStyle.Background.HasValue)
				{
					Color? background2 = highlightingStyle.Background;
					if (background2.HasValue && background2.Value.A > 0)
					{
						num = P_4.IndexOf(background2.Value) + 1;
						if (num == 0)
						{
							P_4.Add(background2.Value);
							num = P_4.Count;
						}
						P_0.Append(Q7Z.tqM(201668) + num + Q7Z.tqM(201706) + num);
					}
				}
				if (highlightingStyle.Bold == true)
				{
					P_0.Append(Q7Z.tqM(201716));
				}
				if (highlightingStyle.Italic == true)
				{
					P_0.Append(Q7Z.tqM(201724));
				}
				if (highlightingStyle.UnderlineKind != LineKind.None)
				{
					P_0.Append(Q7Z.tqM(201732));
				}
				P_0.Append(Q7Z.tqM(195936));
			}
		}
		return highlightingStyle;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
	public override string Export(ITextSnapshot P_0, ICollection<TextRange> P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12044));
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192924));
		}
		if (P_1.Count == 0)
		{
			return null;
		}
		IHighlightingStyleRegistry highlightingStyleRegistry = base.HighlightingStyleRegistry ?? AmbientHighlightingStyleRegistry.Instance;
		StringBuilder stringBuilder = new StringBuilder();
		List<Color> list = new List<Color>();
		list.Add(Colors.Black);
		ICodeDocument codeDocument = P_0.Document as ICodeDocument;
		ITagger<ITokenTag> value = null;
		codeDocument?.Properties.TryGetValue<ITagger<ITokenTag>>(typeof(ITagger<ITokenTag>), out value);
		ITagger<IClassificationTag> tagger = value as ITagger<IClassificationTag>;
		foreach (TextRange item in P_1)
		{
			TextRange normalizedTextRange = item.NormalizedTextRange;
			if (stringBuilder.Length > 0)
			{
				M5C(stringBuilder, Q7Z.tqM(7894));
			}
			IEnumerable<TagSnapshotRange<IClassificationTag>> enumerable = null;
			if (tagger != null)
			{
				enumerable = tagger.GetTags(new NormalizedTextSnapshotRangeCollection(new TextSnapshotRange(P_0, normalizedTextRange)), null);
			}
			if (enumerable != null)
			{
				int num = normalizedTextRange.StartOffset;
				IHighlightingStyle highlightingStyle = null;
				foreach (TagSnapshotRange<IClassificationTag> item2 in enumerable)
				{
					if (item2.SnapshotRange.EndOffset > normalizedTextRange.StartOffset && item2.SnapshotRange.StartOffset < normalizedTextRange.EndOffset)
					{
						if (num < item2.SnapshotRange.StartOffset)
						{
							highlightingStyle = P5u(stringBuilder, highlightingStyleRegistry, highlightingStyle, null, list);
							M5C(stringBuilder, P_0.GetSubstring(new TextRange(num, item2.SnapshotRange.StartOffset), LineTerminator.Newline));
							num = item2.SnapshotRange.StartOffset;
						}
						highlightingStyle = P5u(stringBuilder, highlightingStyleRegistry, highlightingStyle, item2.Tag, list);
						M5C(stringBuilder, P_0.GetSubstring(new TextRange(num, Math.Min(item2.SnapshotRange.EndOffset, normalizedTextRange.EndOffset)), LineTerminator.Newline));
						num = item2.SnapshotRange.EndOffset;
					}
				}
				highlightingStyle = P5u(stringBuilder, highlightingStyleRegistry, highlightingStyle, null, list);
				if (num < normalizedTextRange.LastOffset)
				{
					M5C(stringBuilder, P_0.GetSubstring(new TextRange(num, normalizedTextRange.LastOffset), LineTerminator.Newline));
				}
			}
			else
			{
				M5C(stringBuilder, P_0.GetSubstring(normalizedTextRange, LineTerminator.Newline));
			}
		}
		StringBuilder stringBuilder2 = new StringBuilder();
		if (!string.IsNullOrEmpty(FontFamily))
		{
			stringBuilder2.Append(Q7Z.tqM(201742));
			M5C(stringBuilder2, FontFamily.Trim());
			stringBuilder2.Append(Q7Z.tqM(201774));
		}
		StringBuilder stringBuilder3 = new StringBuilder();
		stringBuilder3.Append(Q7Z.tqM(201784));
		foreach (Color item3 in list)
		{
			stringBuilder3.AppendFormat(CultureInfo.InvariantCulture, Q7Z.tqM(201810), new object[3] { item3.R, item3.G, item3.B });
		}
		stringBuilder3.Append(Q7Z.tqM(201864));
		string text = string.Format(CultureInfo.InvariantCulture, Q7Z.tqM(201870), Q7Z.tqM(201930), stringBuilder2, stringBuilder3, (FontFamily != null) ? Q7Z.tqM(201954) : string.Empty, (FontSizeInPoints > 0.1) ? (Q7Z.tqM(201964) + Math.Round(FontSizeInPoints) * 2.0) : string.Empty, stringBuilder, Q7Z.tqM(201864));
		return base.LineTerminator switch
		{
			LineTerminator.CarriageReturnNewline => text, 
			LineTerminator.CarriageReturn => text.Replace(Q7Z.tqM(7886), Q7Z.tqM(7850)), 
			_ => text.Replace(Q7Z.tqM(7886), Q7Z.tqM(7894)), 
		};
	}

	public cAG()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool VGH()
	{
		return VGN == null;
	}

	internal static cAG jGj()
	{
		return VGN;
	}
}
