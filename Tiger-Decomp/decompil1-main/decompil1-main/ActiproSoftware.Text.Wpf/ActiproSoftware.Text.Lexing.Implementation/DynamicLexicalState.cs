using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.RegularExpressions;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

public class DynamicLexicalState : LexicalStateBase
{
	private HybridDictionary M2L;

	private CaseSensitivity c2q;

	private IList<DynamicLexicalPattern> o2s;

	private object n2I;

	private IDynamicLexicalPatternGroupCollection T27;

	private bool g2M;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IMergableTokenLexerData d2w;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IClassificationType m2H;

	private static DynamicLexicalState F5z;

	internal IMergableTokenLexerData TokenLexerData
	{
		[CompilerGenerated]
		get
		{
			return d2w;
		}
		[CompilerGenerated]
		set
		{
			d2w = value;
		}
	}

	public IDynamicLexicalStateCollection ChildLexicalStates => (IDynamicLexicalStateCollection)base.ChildLexicalStatesCore;

	public CaseSensitivity DefaultCaseSensitivity
	{
		get
		{
			return c2q;
		}
		set
		{
			if (c2q == value)
			{
				return;
			}
			c2q = value;
			foreach (DynamicLexicalPatternGroup item in T27)
			{
				if (!item.CaseSensitivity.HasValue)
				{
					item.InvalidateRegexs(null);
				}
			}
		}
	}

	public IClassificationType DefaultClassificationType
	{
		[CompilerGenerated]
		get
		{
			return m2H;
		}
		[CompilerGenerated]
		set
		{
			m2H = value;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
	public IDynamicLexer Lexer
	{
		get
		{
			return base.LexerCore as IDynamicLexer;
		}
		internal set
		{
			base.LexerCore = value;
		}
	}

	public IDynamicLexicalPatternGroupCollection LexicalPatternGroups => T27;

	public IDynamicLexicalScopeCollection LexicalScopes => (IDynamicLexicalScopeCollection)base.LexicalScopesCore;

	public DynamicLexicalState(string key)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(0, key);
	}

	public DynamicLexicalState(int id, string key)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		c2q = CaseSensitivity.Insensitive;
		n2I = new object();
		base._002Ector(id, key);
		T27 = new DynamicLexicalPatternGroupCollection(this);
		TokenLexerData = new DynamicLexicalStateTokenData(this);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void V2d()
	{
		lock (n2I)
		{
			foreach (DynamicLexicalPatternGroup item in T27)
			{
				item.CompileRegexs();
			}
			M2L = new HybridDictionary();
			foreach (DynamicLexicalPatternGroup item2 in T27)
			{
				foreach (DynamicLexicalPattern pattern in item2.Patterns)
				{
					if (pattern.StartsWith == null || pattern.StartsWith.HasCategorySpecification || pattern.StartsWith.CharacterCount >= 8)
					{
						continue;
					}
					foreach (CharInterval item3 in pattern.StartsWith)
					{
						for (int i = 0; i < item3.Count; i++)
						{
							if (M2L[(char)(item3.Start + i)] == null)
							{
								M2L[(char)(item3.Start + i)] = new List<DynamicLexicalPattern>();
							}
						}
					}
				}
			}
			o2s = new List<DynamicLexicalPattern>();
			foreach (DynamicLexicalPatternGroup item4 in T27)
			{
				foreach (DynamicLexicalPattern pattern2 in item4.Patterns)
				{
					if (pattern2.StartsWith != null && !pattern2.StartsWith.HasCategorySpecification && pattern2.StartsWith.CharacterCount < 8)
					{
						foreach (CharInterval item5 in pattern2.StartsWith)
						{
							for (int j = 0; j < item5.Count; j++)
							{
								((IList)M2L[(char)(item5.Start + j)]).Add(pattern2);
							}
						}
						continue;
					}
					o2s.Add(pattern2);
					foreach (char key in M2L.Keys)
					{
						((IList)M2L[key]).Add(pattern2);
					}
				}
			}
			g2M = true;
		}
	}

	internal void InvalidateRegexs()
	{
		g2M = false;
	}

	internal MergableLexerResult Match(ITextBufferReader reader)
	{
		if (!g2M)
		{
			V2d();
		}
		IList<DynamicLexicalPattern> list;
		lock (n2I)
		{
			list = (IList<DynamicLexicalPattern>)M2L[reader.Peek()];
			if (list == null)
			{
				list = o2s;
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			DynamicLexicalPattern dynamicLexicalPattern = list[i];
			lock (dynamicLexicalPattern)
			{
				switch (dynamicLexicalPattern.RegexCode.Match(reader, allowZeroLengthMatch: false))
				{
				case MatchType.LooseMatch:
					return new MergableLexerResult(MatchType.LooseMatch, dynamicLexicalPattern.TokenLexerData);
				case MatchType.ExactMatch:
					return new MergableLexerResult(MatchType.ExactMatch, dynamicLexicalPattern.TokenLexerData);
				}
			}
		}
		return MergableLexerResult.NoMatch;
	}

	protected override ILexicalStateCollection CreateChildLexicalStates()
	{
		return new DynamicLexicalStateCollection(null);
	}

	protected override ILexicalScopeCollection CreateLexicalScopes()
	{
		return new DynamicLexicalScopeCollection(this);
	}

	internal static bool BPd()
	{
		return F5z == null;
	}

	internal static DynamicLexicalState sPi()
	{
		return F5z;
	}
}
