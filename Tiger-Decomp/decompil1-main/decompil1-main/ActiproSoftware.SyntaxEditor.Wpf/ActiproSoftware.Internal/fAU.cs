using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Media;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Exporters;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

namespace ActiproSoftware.Internal;

internal abstract class fAU : YAZ, IHtmlTextExporter, ITextExporter
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string G5m;

	internal static fAU aG1;

	protected abstract bool IsFragment { get; }

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return G5m;
		}
		[CompilerGenerated]
		set
		{
			G5m = g5m;
		}
	}

	protected abstract bool UseCssClasses { get; }

	private static void p5e(StringBuilder P_0, IHighlightingStyle P_1)
	{
		Color? background = P_1.Background;
		if (background.HasValue && background.Value.A > 0)
		{
			P_0.AppendFormat(CultureInfo.InvariantCulture, Q7Z.tqM(200596), new object[3]
			{
				background.Value.R,
				background.Value.G,
				background.Value.B
			});
		}
		Color? foreground = P_1.Foreground;
		if (foreground.HasValue && foreground.Value.A > 0)
		{
			P_0.AppendFormat(CultureInfo.InvariantCulture, Q7Z.tqM(200678), new object[3]
			{
				foreground.Value.R,
				foreground.Value.G,
				foreground.Value.B
			});
		}
		if (P_1.Bold == true)
		{
			P_0.Append(Q7Z.tqM(200738));
		}
		if (P_1.Italic == true)
		{
			P_0.Append(Q7Z.tqM(200780));
		}
		if (P_1.UnderlineKind != LineKind.None)
		{
			P_0.Append(Q7Z.tqM(200824));
		}
		else if (P_1.StrikethroughKind != LineKind.None)
		{
			P_0.Append(Q7Z.tqM(200884));
		}
	}

	private static void C5l(StringBuilder P_0, string P_1)
	{
		P_0.Append(HtmlContentProvider.hFK(P_1, _0020: false));
	}

	private static IHighlightingStyle K5A(StringBuilder P_0, IHighlightingStyleRegistry P_1, IHighlightingStyle P_2, IClassificationTag P_3, Dictionary<IHighlightingStyle, string[]> P_4)
	{
		IClassificationType classificationType = P_3?.ClassificationType;
		IHighlightingStyle highlightingStyle = ((classificationType != null) ? P_1.oLD(P_3, classificationType) : null);
		if (P_2 != highlightingStyle)
		{
			if (P_2 != null && !P_2.HasDefaultFormatting)
			{
				P_0.Append(Q7Z.tqM(12580));
			}
			if (highlightingStyle != null && !highlightingStyle.HasDefaultFormatting)
			{
				if (P_4 != null)
				{
					string text = d5v(P_4, classificationType.Key, highlightingStyle);
					if (text != null)
					{
						P_0.AppendFormat(CultureInfo.InvariantCulture, Q7Z.tqM(200950), new object[1] { text });
					}
					else
					{
						highlightingStyle = null;
					}
				}
				else
				{
					P_0.Append(Q7Z.tqM(200990));
					p5e(P_0, highlightingStyle);
					P_0.Append(Q7Z.tqM(201020));
				}
			}
		}
		return highlightingStyle;
	}

	private static string d5v(Dictionary<IHighlightingStyle, string[]> P_0, string P_1, IHighlightingStyle P_2)
	{
		if (!string.IsNullOrEmpty(P_1))
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = new StringBuilder();
			foreach (char c in P_1)
			{
				if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9') || c == '-')
				{
					stringBuilder.Append(c);
					stringBuilder2.Append(c);
					continue;
				}
				string text = Q7Z.tqM(201028);
				int num = c;
				stringBuilder.Append(text + num.ToString(Q7Z.tqM(201034), CultureInfo.InvariantCulture));
				string text2 = Q7Z.tqM(201042);
				num = c;
				stringBuilder2.Append(text2 + num.ToString(Q7Z.tqM(201052), CultureInfo.InvariantCulture) + Q7Z.tqM(191762));
			}
			P_0[P_2] = new string[2]
			{
				stringBuilder.ToString(),
				stringBuilder2.ToString()
			};
			return stringBuilder2.ToString();
		}
		return null;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
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
		ICodeDocument codeDocument = P_0.Document as ICodeDocument;
		ITagger<ITokenTag> value = null;
		codeDocument?.Properties.TryGetValue<ITagger<ITokenTag>>(typeof(ITagger<ITokenTag>), out value);
		ITagger<IClassificationTag> tagger = value as ITagger<IClassificationTag>;
		Dictionary<IHighlightingStyle, string[]> dictionary = (UseCssClasses ? new Dictionary<IHighlightingStyle, string[]>() : null);
		foreach (TextRange item in P_1)
		{
			TextRange normalizedTextRange = item.NormalizedTextRange;
			if (stringBuilder.Length > 0)
			{
				C5l(stringBuilder, Q7Z.tqM(7894));
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
							highlightingStyle = K5A(stringBuilder, highlightingStyleRegistry, highlightingStyle, null, dictionary);
							C5l(stringBuilder, P_0.GetSubstring(new TextRange(num, item2.SnapshotRange.StartOffset), LineTerminator.Newline));
							num = item2.SnapshotRange.StartOffset;
						}
						highlightingStyle = K5A(stringBuilder, highlightingStyleRegistry, highlightingStyle, item2.Tag, dictionary);
						C5l(stringBuilder, P_0.GetSubstring(new TextRange(num, Math.Min(item2.SnapshotRange.EndOffset, normalizedTextRange.EndOffset)), LineTerminator.Newline));
						num = item2.SnapshotRange.EndOffset;
					}
				}
				highlightingStyle = K5A(stringBuilder, highlightingStyleRegistry, highlightingStyle, null, dictionary);
				if (num < normalizedTextRange.LastOffset)
				{
					C5l(stringBuilder, P_0.GetSubstring(new TextRange(num, normalizedTextRange.LastOffset), LineTerminator.Newline));
				}
			}
			else
			{
				C5l(stringBuilder, P_0.GetSubstring(normalizedTextRange, LineTerminator.Newline));
			}
		}
		if (!IsFragment)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append(Q7Z.tqM(201060));
			stringBuilder2.Append(Q7Z.tqM(201080));
			if (!string.IsNullOrEmpty(Title))
			{
				stringBuilder2.Append(Q7Z.tqM(201100));
				C5l(stringBuilder2, Title);
				stringBuilder2.Append(Q7Z.tqM(201118));
			}
			if (UseCssClasses)
			{
				stringBuilder2.Append(Q7Z.tqM(201142));
				foreach (KeyValuePair<IHighlightingStyle, string[]> item3 in dictionary)
				{
					stringBuilder2.Append(Q7Z.tqM(201164) + item3.Value[0] + Q7Z.tqM(201174));
					p5e(stringBuilder2, item3.Key);
					stringBuilder2.Append(Q7Z.tqM(201184));
				}
				stringBuilder2.Append(Q7Z.tqM(201194));
			}
			stringBuilder2.Append(Q7Z.tqM(201218));
			stringBuilder2.Append(Q7Z.tqM(201240));
			stringBuilder2.Append(Q7Z.tqM(201260));
			stringBuilder2.Append(Q7Z.tqM(201274));
			stringBuilder.Insert(0, stringBuilder2.ToString());
			stringBuilder.Append(Q7Z.tqM(201474));
			stringBuilder.Append(Q7Z.tqM(201496));
		}
		string text = stringBuilder.ToString();
		return base.LineTerminator switch
		{
			LineTerminator.CarriageReturnNewline => text, 
			LineTerminator.CarriageReturn => text.Replace(Q7Z.tqM(7886), Q7Z.tqM(7850)), 
			_ => text.Replace(Q7Z.tqM(7886), Q7Z.tqM(7894)), 
		};
	}

	protected fAU()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool PG5()
	{
		return aG1 == null;
	}

	internal static fAU yGG()
	{
		return aG1;
	}
}
