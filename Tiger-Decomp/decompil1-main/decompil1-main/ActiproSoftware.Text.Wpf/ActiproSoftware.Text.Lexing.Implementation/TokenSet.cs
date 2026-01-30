using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Tagging;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public class TokenSet : ITokenSet, IEnumerable<IToken>, IEnumerable, ITextRangeProvider
{
	private TextRange RmX;

	private List<IToken> RmN;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object amR;

	internal static TokenSet SU9;

	public int Count => RmN.Count;

	public IToken FirstToken => (RmN.Count > 0) ? RmN[0] : null;

	public bool FirstTokenExtendsBack
	{
		get
		{
			IToken firstToken = FirstToken;
			if (firstToken == null)
			{
				return false;
			}
			return firstToken.StartOffset < RmX.StartOffset;
		}
	}

	public IToken LastToken => (RmN.Count > 0) ? RmN[RmN.Count - 1] : null;

	public bool LastTokenExtendsForward
	{
		get
		{
			IToken lastToken = LastToken;
			if (lastToken != null)
			{
				return lastToken.EndOffset > RmX.EndOffset;
			}
			return false;
		}
	}

	public object ParseContext
	{
		[CompilerGenerated]
		get
		{
			return amR;
		}
		[CompilerGenerated]
		private set
		{
			amR = value;
		}
	}

	public TextRange TextRange
	{
		get
		{
			return RmX;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	[IndexerName("Tokens")]
	public IToken this[int index] => RmN[index];

	public TokenSet(TextRange textRange, IEnumerable<IToken> tokens, object parseContext)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		RmN = new List<IToken>();
		base._002Ector();
		RmX = textRange.NormalizedTextRange;
		if (tokens != null)
		{
			RmN.AddRange(tokens);
		}
		ParseContext = parseContext;
	}

	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	public TokenSet(TextRange textRange, IEnumerable<TagSnapshotRange<ITokenTag>> tagRanges, object parseContext)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		RmN = new List<IToken>();
		base._002Ector();
		RmX = textRange.NormalizedTextRange;
		if (tagRanges != null)
		{
			foreach (TagSnapshotRange<ITokenTag> tagRange in tagRanges)
			{
				RmN.Add(tagRange.Tag.Token);
			}
		}
		ParseContext = parseContext;
	}

	private int am3(int P_0)
	{
		int num = 0;
		int num2 = RmN.Count - 1;
		int result = default(int);
		int num5 = default(int);
		while (true)
		{
			bool flag = num <= num2;
			int num3 = 0;
			if (HU8())
			{
				num3 = 0;
			}
			int num4;
			while (true)
			{
				switch (num3)
				{
				case 1:
					return result;
				default:
					if (flag)
					{
						num4 = (num + num2) / 2;
						if (!RmN[num4].Contains(P_0))
						{
							break;
						}
						result = num4;
					}
					else if (num2 < 0)
					{
						result = -1;
					}
					else
					{
						if (RmN[num2].EndOffset <= P_0)
						{
							result = ~(num2 + 1);
							num3 = 1;
							if (mUL() != null)
							{
								num3 = num5;
							}
							continue;
						}
						result = ~num2;
					}
					goto case 1;
				}
				break;
			}
			if (RmN[num4].EndOffset <= P_0)
			{
				num = num4 + 1;
			}
			else
			{
				num2 = num4 - 1;
			}
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return RmN.GetEnumerator();
	}

	public IEnumerator<IToken> GetEnumerator()
	{
		return RmN.GetEnumerator();
	}

	public int IndexOf(int offset, int hintIndex)
	{
		if (hintIndex >= 0 && hintIndex < RmN.Count)
		{
			IToken token = RmN[hintIndex];
			if (token.Contains(offset))
			{
				return hintIndex;
			}
			if (offset < token.StartOffset)
			{
				if (hintIndex > 0 && RmN[hintIndex - 1].Contains(offset))
				{
					return hintIndex - 1;
				}
			}
			else if (hintIndex < RmN.Count - 1 && RmN[hintIndex + 1].Contains(offset))
			{
				return hintIndex + 1;
			}
		}
		int num = Math.Max(-1, am3(offset));
		if (num == -1)
		{
			IToken lastToken = LastToken;
			if (lastToken != null && lastToken.Length == 0 && lastToken.StartOffset == offset)
			{
				return RmN.Count - 1;
			}
		}
		return num;
	}

	internal static bool HU8()
	{
		return SU9 == null;
	}

	internal static TokenSet mUL()
	{
		return SU9;
	}
}
