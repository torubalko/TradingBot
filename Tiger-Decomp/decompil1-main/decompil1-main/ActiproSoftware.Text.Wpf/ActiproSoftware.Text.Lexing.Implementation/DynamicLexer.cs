using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using ActiproSoftware.Products.Text;
using ActiproSoftware.Text.RegularExpressions;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
public class DynamicLexer : MergableLexerBase, IDynamicLexer, IMergableLexer, ILexer, IKeyedObject
{
	private IEnumerable<ILexicalStateTransition> iT5;

	private IDynamicLexicalMacroCollection YT6;

	private IDynamicLexicalStateCollection mTZ;

	internal static DynamicLexer F5j;

	public DynamicLexicalState DefaultLexicalState
	{
		get
		{
			return base.DefaultLexicalStateCore as DynamicLexicalState;
		}
		set
		{
			base.DefaultLexicalStateCore = value;
		}
	}

	public string Key
	{
		get
		{
			return base.KeyCore;
		}
		set
		{
			base.KeyCore = value;
		}
	}

	public IDynamicLexicalMacroCollection LexicalMacros => YT6;

	public ILexicalStateIdProvider LexicalStateIdProvider
	{
		get
		{
			return base.LexicalStateIdProviderCore;
		}
		set
		{
			base.LexicalStateIdProviderCore = value;
		}
	}

	public IDynamicLexicalStateCollection LexicalStates => mTZ;

	public ITokenIdProvider TokenIdProvider
	{
		get
		{
			return base.TokenIdProviderCore;
		}
		set
		{
			base.TokenIdProviderCore = value;
		}
	}

	public DynamicLexer()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		YT6 = new DynamicLexicalMacroCollection();
		mTZ = new DynamicLexicalStateCollection(this);
		DynamicLexicalState dynamicLexicalState = new DynamicLexicalState(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7862));
		mTZ.Add(dynamicLexicalState);
		DefaultLexicalState = dynamicLexicalState;
	}

	private void GTW()
	{
		foreach (DynamicLexicalState item in mTZ)
		{
			item.InvalidateRegexs();
			foreach (DynamicLexicalScope lexicalScope in item.LexicalScopes)
			{
				if (lexicalScope.StartLexicalPatternGroup != null)
				{
					lexicalScope.StartLexicalPatternGroup.InvalidateRegexs(null);
				}
				if (lexicalScope.EndLexicalPatternGroup != null)
				{
					lexicalScope.EndLexicalPatternGroup.InvalidateRegexs(null);
				}
			}
			foreach (DynamicLexicalPatternGroup lexicalPatternGroup in item.LexicalPatternGroups)
			{
				lexicalPatternGroup.InvalidateRegexs(null);
			}
		}
	}

	public override IEnumerable<ILexicalStateTransition> GetAllLexicalStateTransitions()
	{
		if (mTZ != null)
		{
			if (iT5 == null)
			{
				DynamicLexicalState[] lexicalStates = mTZ.ToArray();
				iT5 = LexicalStateCollection.GetAllLexicalStateTransitions(lexicalStates);
			}
			return iT5;
		}
		return null;
	}

	public override MergableLexerResult GetDefaultToken(ITextBufferReader reader, ILexicalState lexicalState)
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					if (flag)
					{
						throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7880));
					}
					if (lexicalState == null)
					{
						throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7896));
					}
					if (!(lexicalState is DynamicLexicalState dynamicLexicalState))
					{
						throw new ArgumentException(SR.GetString(SRName.ExInvalidDynamicLexerLexicalStateType));
					}
					reader.Read();
					return new MergableLexerResult(MatchType.LooseMatch, dynamicLexicalState.TokenLexerData);
				case 1:
					break;
				}
				flag = reader == null;
				num2 = 0;
			}
			while (o5l() == null);
		}
	}

	public override MergableLexerResult GetNextToken(ITextBufferReader reader, ILexicalState lexicalState)
	{
		if (!(lexicalState is DynamicLexicalState dynamicLexicalState))
		{
			throw new ArgumentException(SR.GetString(SRName.ExInvalidDynamicLexerLexicalStateType));
		}
		return dynamicLexicalState.Match(reader);
	}

	protected override void OnChanged(EventArgs e)
	{
		iT5 = null;
		base.OnChanged(e);
		GTW();
	}

	internal static bool T5K()
	{
		return F5j == null;
	}

	internal static DynamicLexer o5l()
	{
		return F5j;
	}
}
