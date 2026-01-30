using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using ActiproSoftware.Products.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.RegularExpressions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Searching.Implementation;

public static class TextSearcher
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public ITextChange Lqr;

		private static _003C_003Ec__DisplayClass18_0 Bf8;

		public _003C_003Ec__DisplayClass18_0()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal TextSnapshotRange vqE(TextRange t)
		{
			return new TextSnapshotRange(Lqr.Snapshot, t);
		}

		internal static bool AfL()
		{
			return Bf8 == null;
		}

		internal static _003C_003Ec__DisplayClass18_0 Rfs()
		{
			return Bf8;
		}
	}

	internal static TextSearcher OVD;

	private static void IuS(ITextChange P_0, ISearchOptions P_1, ISearchResultSet P_2)
	{
		if (P_2.Results.Count <= 0)
		{
			return;
		}
		IEnumerator<ISearchResult> enumerator = P_2.Results.GetEnumerator();
		int num = 0;
		if (YVY() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		try
		{
			while (enumerator.MoveNext())
			{
				ISearchResult current = enumerator.Current;
				string insertText = Qu2(P_1, current.Captures);
				P_0.ReplaceText(current.TextRange, insertText);
			}
		}
		finally
		{
			enumerator?.Dispose();
		}
		if (!P_0.Apply())
		{
			return;
		}
		ITextSnapshot currentSnapshot = P_0.Snapshot.Document.CurrentSnapshot;
		int num3 = 0;
		foreach (SearchResult result in P_2.Results)
		{
			int length = Qu2(P_1, result.Captures).Length;
			result.ReplaceSnapshotRange = TextSnapshotRange.FromSpan(currentSnapshot, result.FindSnapshotRange.StartOffset + num3, length);
			int num4 = length - result.FindSnapshotRange.Length;
			num3 += num4;
		}
	}

	private static List<ISearchCapture> iuV(ITextBufferReader P_0, int[] P_1)
	{
		List<ISearchCapture> list = new List<ISearchCapture>();
		for (int i = 0; i < P_1.Length; i += 2)
		{
			if (P_1[i] != -1)
			{
				int length = Math.Abs(P_1[i + 1] - P_1[i]);
				string key = ((i == 0) ? WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6510) : (i / 2).ToString(CultureInfo.InvariantCulture));
				list.Add(new SearchCapture(key, TextRange.FromSpan(P_1[i], length), P_0.GetSubstring(P_1[i], length)));
			}
		}
		return list;
	}

	private static Regex iuB(ISearchOptions P_0)
	{
		ISearchPatternProvider searchPatternProvider = P_0.PatternProvider ?? SearchPatternProviders.Normal;
		string findText = P_0.FindText;
		string text = Regex.Escape(findText);
		if (P_0.MatchWholeWord && findText != null && findText.Length > 0)
		{
			text = ((searchPatternProvider != SearchPatternProviders.Normal || CharClass.Word.Contains(findText[0])) ? WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6516) : string.Empty) + text + ((searchPatternProvider != SearchPatternProviders.Normal || CharClass.Word.Contains(findText[findText.Length - 1])) ? WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6526) : string.Empty);
		}
		RegexOptions options = (RegexOptions)(0x20 | ((!P_0.MatchCase && !searchPatternProvider.RequiresCaseSensitivity) ? 1 : 0));
		return new Regex(text, options);
	}

	private static RegexCode Ku9(ISearchOptions P_0)
	{
		ISearchPatternProvider searchPatternProvider = P_0.PatternProvider ?? SearchPatternProviders.Normal;
		string findText = P_0.FindText;
		string text = searchPatternProvider.GetFindPattern(findText);
		if (P_0.MatchWholeWord && findText != null && findText.Length > 0)
		{
			text = ((searchPatternProvider != SearchPatternProviders.Normal || CharClass.Word.Contains(findText[0])) ? WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6516) : string.Empty) + text + ((searchPatternProvider != SearchPatternProviders.Normal || CharClass.Word.Contains(findText[findText.Length - 1])) ? WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6526) : string.Empty);
		}
		text = string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6536), new object[1] { text });
		RegexNode rootNode = new RegexParser().ParsePattern(text, requestAllowCapturing: true, requestIsReplacementPattern: false, (!P_0.MatchCase && !searchPatternProvider.RequiresCaseSensitivity) ? CaseSensitivity.Insensitive : CaseSensitivity.Sensitive);
		return new RegexCompiler().Compile(rootNode, isRightToLeft: false);
	}

	private static RegexNode guA(ISearchOptions P_0)
	{
		ISearchPatternProvider searchPatternProvider = P_0.PatternProvider ?? SearchPatternProviders.Normal;
		string replacePattern = searchPatternProvider.GetReplacePattern(P_0.ReplaceText);
		if (replacePattern == null || replacePattern.Length == 0)
		{
			return null;
		}
		return new RegexParser().ParsePattern(replacePattern, requestAllowCapturing: true, requestIsReplacementPattern: true, CaseSensitivity.Sensitive);
	}

	private static ISearchResultSet ruu(SearchOperationType P_0, ITextSnapshot P_1, ISearchOptions P_2, TextRange P_3)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1676));
		}
		if (P_2 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6554));
		}
		LuL(P_2);
		ITextBufferReader bufferReader = P_1.GetReader(P_3.StartOffset).BufferReader;
		P_3.Normalize();
		RegexCode regexCode = Ku9(P_2);
		int num = ((P_2.MaximumResultCount > 0) ? P_2.MaximumResultCount : int.MaxValue);
		CancellationToken none = CancellationToken.None;
		SearchResultCollection searchResultCollection = new SearchResultCollection();
		int startOffset = P_3.StartOffset;
		ISearchResult searchResult = zud(P_1, bufferReader, startOffset, P_3.EndOffset, P_3.EndOffset, regexCode, none);
		while (searchResult != null && searchResult.TextRange.EndOffset <= P_3.EndOffset)
		{
			searchResultCollection.Add(searchResult);
			if (--num <= 0)
			{
				break;
			}
			startOffset = searchResult.TextRange.StartOffset + ((searchResult.TextRange.Length <= 0) ? 1 : searchResult.TextRange.Length);
			searchResult = zud(P_1, bufferReader, startOffset, P_3.EndOffset, P_3.EndOffset, regexCode, none);
		}
		if (searchResultCollection.Count == 0)
		{
		}
		return new SearchResultSet(P_0, P_2.Clone() as ISearchOptions, searchResultCollection, wrapped: false);
	}

	private static ISearchResultSet Bu8(SearchOperationType P_0, ITextSnapshot P_1, ISearchOptions P_2, TextRange P_3)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1676));
		}
		if (P_2 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6554));
		}
		LuL(P_2);
		string text = P_1.GetText(LineTerminator.Newline);
		P_3.Normalize();
		int num = Math.Max(0, Math.Min(text.Length, P_3.StartOffset));
		int num2 = Math.Max(0, Math.Min(text.Length, P_3.EndOffset));
		if (P_3.StartOffset > 0 || P_3.EndOffset < text.Length)
		{
			text = text.Substring(num, num2 - num);
		}
		Regex regex = iuB(P_2);
		int num3 = ((P_2.MaximumResultCount > 0) ? P_2.MaximumResultCount : int.MaxValue);
		SearchResultCollection searchResultCollection = new SearchResultCollection();
		MatchCollection matchCollection = regex.Matches(text);
		if (matchCollection != null)
		{
			foreach (Match item2 in matchCollection)
			{
				if (item2 != null)
				{
					TextSnapshotRange textSnapshotRange = new TextSnapshotRange(P_1, num + item2.Index, num + item2.Index + item2.Length);
					SearchResult item = new SearchResult(textSnapshotRange, new SearchCaptureCollection(new SearchCapture[1]
					{
						new SearchCapture(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6510), textSnapshotRange, item2.Value)
					}));
					searchResultCollection.Add(item);
					if (--num3 <= 0)
					{
						break;
					}
				}
			}
		}
		if (searchResultCollection.Count == 0)
		{
		}
		return new SearchResultSet(P_0, P_2.Clone() as ISearchOptions, searchResultCollection, wrapped: false);
	}

	private static ISearchResultSet tuT(SearchOperationType P_0, ITextSnapshot P_1, ISearchOptions P_2, int P_3, bool P_4, TextRange P_5, CancellationToken P_6)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1676));
		}
		if (P_2 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6554));
		}
		if (!P_5.IntersectsWith(P_3))
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5930), SR.GetString(SRName.ExStartOffsetNotInSearchRange));
		}
		LuL(P_2);
		P_5.Normalize();
		ITextBufferReader bufferReader = P_1.GetReader(P_5.StartOffset).BufferReader;
		RegexCode regexCode = Ku9(P_2);
		SearchResultCollection searchResultCollection = new SearchResultCollection();
		if (P_2.SearchUp)
		{
			ISearchResult searchResult = Vuh(P_1, bufferReader, P_3, P_5.StartOffset, P_5.EndOffset, regexCode, P_6);
			if (searchResult != null)
			{
				searchResultCollection.Add(searchResult);
				return new SearchResultSet(P_0, P_2.Clone() as ISearchOptions, searchResultCollection, wrapped: false);
			}
			if (P_4)
			{
				searchResult = Vuh(P_1, bufferReader, P_5.EndOffset, P_3, P_5.EndOffset, regexCode, P_6);
				if (searchResult != null && searchResult.TextRange.StartOffset >= P_3)
				{
					searchResultCollection.Add(searchResult);
				}
			}
		}
		else
		{
			ISearchResult searchResult2 = zud(P_1, bufferReader, P_3, P_5.EndOffset, P_5.EndOffset, regexCode, P_6);
			if (searchResult2 != null)
			{
				searchResultCollection.Add(searchResult2);
				return new SearchResultSet(P_0, P_2.Clone() as ISearchOptions, searchResultCollection, wrapped: false);
			}
			if (P_4)
			{
				searchResult2 = zud(P_1, bufferReader, P_5.StartOffset, P_3, P_5.EndOffset, regexCode, P_6);
				if (searchResult2 != null && searchResult2.TextRange.StartOffset <= P_3)
				{
					searchResultCollection.Add(searchResult2);
				}
			}
		}
		if (searchResultCollection.Count == 0)
		{
		}
		return new SearchResultSet(P_0, P_2.Clone() as ISearchOptions, searchResultCollection, wrapped: true);
	}

	private static string Qu2(ISearchOptions P_0, ISearchCaptureCollection P_1)
	{
		RegexNode regexNode = guA(P_0);
		StringBuilder stringBuilder = new StringBuilder();
		Lum(stringBuilder, regexNode, P_1);
		return stringBuilder.ToString();
	}

	private static void Lum(StringBuilder P_0, RegexNode P_1, ISearchCaptureCollection P_2)
	{
		if (P_1 == null)
		{
			return;
		}
		switch (P_1.NodeType)
		{
		case 17:
		{
			foreach (RegexNode child in P_1.Children)
			{
				Lum(P_0, child, P_2);
			}
			break;
		}
		case 1:
		case 4:
			P_0.Append(P_1.StringData);
			break;
		case 26:
		{
			ISearchCapture searchCapture = P_2[P_1.StringData];
			if (searchCapture != null)
			{
				P_0.Append(searchCapture.Text);
			}
			break;
		}
		}
	}

	private static bool Kuc(ISearchOptions P_0)
	{
		return P_0 != null && (P_0.PatternProvider == null || P_0.PatternProvider == SearchPatternProviders.Normal);
	}

	private static ISearchResult Vuh(ITextSnapshot P_0, ITextBufferReader P_1, int P_2, int P_3, int P_4, RegexCode P_5, CancellationToken P_6)
	{
		if (--P_2 < 0)
		{
			return null;
		}
		P_1.Offset = P_2;
		ISearchResult result = null;
		int[] captureResults = null;
		while (P_1.Offset >= 0)
		{
			P_2 = P_1.Offset;
			if (P_2 < P_3 || (P_2 % 500 == 0 && P_6.IsCancellationRequested))
			{
				break;
			}
			if (P_5.MatchWithCapture(P_1, out captureResults) != MatchType.NoMatch)
			{
				if (P_1.Offset <= P_4)
				{
					result = new SearchResult(new TextSnapshotRange(P_0, P_2, P_1.Offset), new SearchCaptureCollection(iuV(P_1, captureResults)));
					break;
				}
				P_1.Offset = P_2;
			}
			if (P_1.ReadReverse() == '\0')
			{
				break;
			}
		}
		return result;
	}

	private static ISearchResult zud(ITextSnapshot P_0, ITextBufferReader P_1, int P_2, int P_3, int P_4, RegexCode P_5, CancellationToken P_6)
	{
		ISearchResult result = null;
		int[] captureResults = null;
		int num = P_1.Length - ((P_2 >= P_1.Length) ? 1 : 0);
		if (P_2 <= num)
		{
			P_1.Offset = P_2;
			while (P_1.Offset <= num)
			{
				P_2 = P_1.Offset;
				if (P_2 > P_3 || (P_2 % 500 == 0 && P_6.IsCancellationRequested))
				{
					break;
				}
				if (P_5.MatchWithCapture(P_1, out captureResults) != MatchType.NoMatch)
				{
					if (P_1.Offset <= P_4)
					{
						result = new SearchResult(new TextSnapshotRange(P_0, P_2, P_1.Offset), new SearchCaptureCollection(iuV(P_1, captureResults)));
						break;
					}
					P_1.Offset = P_2;
				}
				if (P_1.Read() == '\0')
				{
					break;
				}
			}
		}
		return result;
	}

	private static void LuL(ISearchOptions P_0)
	{
		if (string.IsNullOrEmpty(P_0.FindText))
		{
			throw new ArgumentException(SR.GetString(SRName.ExNoFindText), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6554));
		}
	}

	public static ISearchResultSet FindAll(ITextSnapshot snapshot, ISearchOptions options, TextRange searchTextRange)
	{
		if (!Kuc(options))
		{
			return ruu(SearchOperationType.FindAll, snapshot, options, searchTextRange);
		}
		return Bu8(SearchOperationType.FindAll, snapshot, options, searchTextRange);
	}

	public static ISearchResultSet FindNext(ITextSnapshot snapshot, ISearchOptions options, int startOffset, bool canWrap, TextRange searchTextRange)
	{
		return tuT(SearchOperationType.FindNext, snapshot, options, startOffset, canWrap, searchTextRange, CancellationToken.None);
	}

	public static ISearchResultSet FindNext(ITextSnapshot snapshot, ISearchOptions options, int startOffset, bool canWrap, TextRange searchTextRange, CancellationToken cancellationToken)
	{
		return tuT(SearchOperationType.FindNext, snapshot, options, startOffset, canWrap, searchTextRange, cancellationToken);
	}

	public static ISearchResultSet ReplaceAll(ITextDocument document, object source, ISearchOptions options, params TextRange[] searchTextRanges)
	{
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass18_0();
		if (document == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5516));
		}
		CS_0024_003C_003E8__locals7.Lqr = document.CreateTextChange(TextChangeTypes.ReplaceAll, new TextChangeOptions
		{
			OffsetDelta = TextChangeOffsetDelta.SequentialOnly,
			RetainSelection = true,
			Source = source
		});
		ISearchResultSet searchResultSet = null;
		if (searchTextRanges != null && searchTextRanges.Length != 0)
		{
			if (searchTextRanges.Length > 1)
			{
				NormalizedTextSnapshotRangeCollection normalizedTextSnapshotRangeCollection = new NormalizedTextSnapshotRangeCollection(searchTextRanges.Select((TextRange t) => new TextSnapshotRange(CS_0024_003C_003E8__locals7.Lqr.Snapshot, t)), mergeSequentialRanges: true);
				foreach (TextSnapshotRange item in normalizedTextSnapshotRangeCollection)
				{
					ISearchResultSet searchResultSet2 = ruu(SearchOperationType.ReplaceAll, CS_0024_003C_003E8__locals7.Lqr.Snapshot, options, item);
					if (searchResultSet != null)
					{
						if (searchResultSet2 == null || searchResultSet2.Results.Count <= 0)
						{
							continue;
						}
						foreach (ISearchResult result in searchResultSet2.Results)
						{
							searchResultSet.Results.Add(result);
						}
					}
					else
					{
						searchResultSet = searchResultSet2;
					}
				}
			}
			else
			{
				searchResultSet = ruu(SearchOperationType.ReplaceAll, CS_0024_003C_003E8__locals7.Lqr.Snapshot, options, searchTextRanges[0]);
			}
		}
		else
		{
			searchResultSet = ruu(SearchOperationType.ReplaceAll, CS_0024_003C_003E8__locals7.Lqr.Snapshot, options, TextRange.FromSpan(0, CS_0024_003C_003E8__locals7.Lqr.Snapshot.Length));
		}
		IuS(CS_0024_003C_003E8__locals7.Lqr, options, searchResultSet);
		return searchResultSet;
	}

	public static ISearchResultSet ReplaceNext(ITextDocument document, object source, ISearchOptions options, int startOffset, bool canWrap, TextRange searchTextRange)
	{
		if (document == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5516));
		}
		ITextChange textChange = document.CreateTextChange(TextChangeTypes.Replace, new TextChangeOptions
		{
			OffsetDelta = TextChangeOffsetDelta.SequentialOnly,
			Source = source
		});
		ISearchResultSet searchResultSet = tuT(SearchOperationType.ReplaceNext, textChange.Snapshot, options, startOffset, canWrap, searchTextRange, CancellationToken.None);
		IuS(textChange, options, searchResultSet);
		return searchResultSet;
	}

	internal static bool iVv()
	{
		return OVD == null;
	}

	internal static TextSearcher YVY()
	{
		return OVD;
	}
}
