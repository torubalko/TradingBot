using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using ActiproSoftware.Products.Text;
using ActiproSoftware.Text.RegularExpressions;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

public class DynamicLexicalPatternGroup : IKeyedObject
{
	private HybridDictionary qTR;

	private CaseSensitivity? cTf;

	private DynamicLexicalState oTt;

	private string DTQ;

	private string nTn;

	private object ATG;

	private IDynamicLexicalPatternCollection vTe;

	private DynamicLexicalPatternType OTy;

	private bool JTz;

	private CharClass o2S;

	private string Y2V;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IClassificationType R2B;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string B29;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DynamicLexicalScope a2A;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object K2u;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int C28;

	private static DynamicLexicalPatternGroup c53;

	public CaseSensitivity? CaseSensitivity
	{
		get
		{
			return cTf;
		}
		set
		{
			if (cTf != value)
			{
				if (OTy == DynamicLexicalPatternType.Regex && value == ActiproSoftware.Text.CaseSensitivity.AutoCorrect)
				{
					throw new ArgumentException(SR.GetString(SRName.ExAutoCorrectNotPermittedWithRegex));
				}
				cTf = value;
				InvalidateRegexs(null);
			}
		}
	}

	public IClassificationType ClassificationType
	{
		[CompilerGenerated]
		get
		{
			return R2B;
		}
		[CompilerGenerated]
		set
		{
			R2B = value;
		}
	}

	public bool IsCaseSensitive => WTX() == ActiproSoftware.Text.CaseSensitivity.Sensitive;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return B29;
		}
		[CompilerGenerated]
		set
		{
			B29 = value;
		}
	}

	public DynamicLexicalScope LexicalScope
	{
		[CompilerGenerated]
		get
		{
			return a2A;
		}
		[CompilerGenerated]
		internal set
		{
			a2A = value;
		}
	}

	public DynamicLexicalState LexicalState
	{
		get
		{
			if (oTt != null)
			{
				return oTt;
			}
			bool flag = LexicalScope != null;
			int num = 0;
			if (J5w() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				if (flag)
				{
					return LexicalScope.LexicalState;
				}
				return null;
			}
		}
		internal set
		{
			oTt = value;
		}
	}

	public string LookAheadPattern
	{
		get
		{
			return DTQ;
		}
		set
		{
			if (!(DTQ == value))
			{
				DTQ = value;
				InvalidateRegexs(null);
			}
		}
	}

	public string LookBehindPattern
	{
		get
		{
			return nTn;
		}
		set
		{
			if (!(nTn == value))
			{
				nTn = value;
				InvalidateRegexs(null);
			}
		}
	}

	public IDynamicLexicalPatternCollection Patterns => vTe;

	public DynamicLexicalPatternType PatternType
	{
		get
		{
			return OTy;
		}
		set
		{
			if (OTy != value)
			{
				OTy = value;
				InvalidateRegexs(null);
			}
		}
	}

	public object Tag
	{
		[CompilerGenerated]
		get
		{
			return K2u;
		}
		[CompilerGenerated]
		set
		{
			K2u = value;
		}
	}

	public int TokenId
	{
		[CompilerGenerated]
		get
		{
			return C28;
		}
		[CompilerGenerated]
		set
		{
			C28 = value;
		}
	}

	public string TokenKey => Y2V;

	public DynamicLexicalPatternGroup(DynamicLexicalPatternType patternType, string tokenKey, IClassificationType classificationType)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		ATG = new object();
		base._002Ector();
		vTe = new DynamicLexicalPatternCollection(this);
		OTy = patternType;
		Y2V = tokenKey;
		ClassificationType = classificationType;
	}

	[SpecialName]
	private CaseSensitivity WTX()
	{
		if (cTf.HasValue)
		{
			return cTf.Value;
		}
		CaseSensitivity caseSensitivity = LexicalState?.DefaultCaseSensitivity ?? ActiproSoftware.Text.CaseSensitivity.Insensitive;
		if (caseSensitivity == ActiproSoftware.Text.CaseSensitivity.AutoCorrect && OTy == DynamicLexicalPatternType.Regex)
		{
			caseSensitivity = ActiproSoftware.Text.CaseSensitivity.Insensitive;
		}
		return caseSensitivity;
	}

	internal void CompileRegexs()
	{
		lock (ATG)
		{
			if (JTz)
			{
				return;
			}
			RegexParser regexParser = new RegexParser();
			RegexCompiler regexCompiler = new RegexCompiler();
			IRegexMacroMap macroMap = null;
			if (LexicalState != null)
			{
				macroMap = LexicalState.Lexer.LexicalMacros as IRegexMacroMap;
			}
			CaseSensitivity caseSensitivity = WTX();
			string text = string.Empty;
			if (nTn != null && nTn.Trim().Length > 0)
			{
				text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8038) + nTn + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8052);
				try
				{
					RegexNode regexNode = regexParser.ParsePatternAndExpandMacros(text, requestAllowCapturing: false, requestIsReplacementPattern: false, macroMap, caseSensitivity);
				}
				catch (InvalidRegexPatternException ex)
				{
					throw new InvalidRegexPatternException(ex.Message + Environment.NewLine + string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExInvalidDynamicLexicalPatternGroupLookBehindRegex), new object[2] { Y2V, nTn }));
				}
			}
			string text2 = string.Empty;
			if (DTQ != null && DTQ.Trim().Length > 0)
			{
				text2 = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8060) + DTQ + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6120);
				try
				{
					RegexNode regexNode2 = regexParser.ParsePatternAndExpandMacros(text2, requestAllowCapturing: false, requestIsReplacementPattern: false, macroMap, caseSensitivity);
				}
				catch (InvalidRegexPatternException ex2)
				{
					throw new InvalidRegexPatternException(ex2.Message + Environment.NewLine + string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExInvalidDynamicLexicalPatternGroupLookAheadRegex), new object[2] { Y2V, DTQ }));
				}
			}
			o2S = new CharClass();
			qTR = new HybridDictionary();
			foreach (DynamicLexicalPattern pattern2 in Patterns)
			{
				if (pattern2.RegexCode != null)
				{
					continue;
				}
				string pattern = pattern2.Pattern;
				StringBuilder stringBuilder = new StringBuilder();
				if (OTy == DynamicLexicalPatternType.Explicit)
				{
					stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5496));
					stringBuilder.Append(RegexHelper.Escape(pattern));
					stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5496));
				}
				else
				{
					stringBuilder.Append(pattern);
				}
				RegexNode regexNode3;
				try
				{
					regexNode3 = regexParser.ParsePatternAndExpandMacros(text + stringBuilder.ToString() + text2, requestAllowCapturing: false, requestIsReplacementPattern: false, macroMap, caseSensitivity);
				}
				catch (InvalidRegexPatternException ex3)
				{
					throw new InvalidRegexPatternException(ex3.Message + Environment.NewLine + string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExInvalidDynamicLexicalPatternGroupRegex), new object[2] { Y2V, stringBuilder }));
				}
				pattern2.RegexCode = regexCompiler.Compile(regexNode3, isRightToLeft: false);
				pattern2.StartsWith = new CharClass();
				if (!regexNode3.GetPrefixCharacters(pattern2.StartsWith))
				{
					pattern2.StartsWith = null;
				}
				if (o2S == null)
				{
					continue;
				}
				if (o2S.CanMergeWith(pattern2.StartsWith))
				{
					o2S.AddRange(pattern2.StartsWith);
					if (OTy == DynamicLexicalPatternType.Explicit)
					{
						IList<DynamicLexicalPattern> list = (IList<DynamicLexicalPattern>)qTR[pattern[0]];
						if (list == null)
						{
							list = new List<DynamicLexicalPattern>();
						}
						list.Add(pattern2);
						if (caseSensitivity == ActiproSoftware.Text.CaseSensitivity.Sensitive)
						{
							qTR[pattern[0]] = list;
							continue;
						}
						qTR[char.ToLowerInvariant(pattern[0])] = list;
						qTR[char.ToUpperInvariant(pattern[0])] = list;
					}
				}
				else
				{
					o2S = null;
				}
			}
			if (o2S != null && o2S.Count == 0)
			{
				o2S = null;
			}
			JTz = true;
		}
	}

	internal void InvalidateRegexs(DynamicLexicalPattern singleLexicalPattern)
	{
		JTz = false;
		if (singleLexicalPattern == null)
		{
			foreach (DynamicLexicalPattern item in vTe)
			{
				item.RegexCode = null;
			}
		}
		else
		{
			singleLexicalPattern.RegexCode = null;
		}
		if (LexicalState != null)
		{
			LexicalState.InvalidateRegexs();
		}
	}

	internal MergableLexerResult Match(ITextBufferReader reader)
	{
		if (!JTz)
		{
			CompileRegexs();
		}
		char c = reader.Peek();
		IList<DynamicLexicalPattern> list = vTe;
		if (OTy == DynamicLexicalPatternType.Explicit)
		{
			list = (IList<DynamicLexicalPattern>)qTR[c];
			if (list == null)
			{
				return MergableLexerResult.NoMatch;
			}
		}
		else if (o2S != null && !o2S.Contains(c))
		{
			return MergableLexerResult.NoMatch;
		}
		for (int i = 0; i < list.Count; i++)
		{
			DynamicLexicalPattern dynamicLexicalPattern = list[i];
			lock (dynamicLexicalPattern)
			{
				switch (dynamicLexicalPattern.RegexCode.Match(reader, allowZeroLengthMatch: false))
				{
				case MatchType.ExactMatch:
					return new MergableLexerResult(MatchType.ExactMatch, dynamicLexicalPattern.TokenLexerData);
				case MatchType.LooseMatch:
					return new MergableLexerResult(MatchType.LooseMatch, dynamicLexicalPattern.TokenLexerData);
				}
			}
		}
		return MergableLexerResult.NoMatch;
	}

	public override string ToString()
	{
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8074) + string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7968), new object[1] { Key }) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
	}

	internal static bool a5C()
	{
		return c53 == null;
	}

	internal static DynamicLexicalPatternGroup J5w()
	{
		return c53;
	}
}
