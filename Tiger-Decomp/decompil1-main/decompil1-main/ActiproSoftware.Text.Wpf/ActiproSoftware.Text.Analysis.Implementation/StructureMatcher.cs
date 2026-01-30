using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Lexing;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Analysis.Implementation;

public class StructureMatcher : IStructureMatcher
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool KdR;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool Edf;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool ydt;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool idQ;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int? kdn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int? AdG;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int? gde;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int? fdy;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int? Tdz;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int? mLS;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int? RLV;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int? KLB;

	internal static StructureMatcher LqZ;

	public bool CanMatchAngleBraces
	{
		[CompilerGenerated]
		get
		{
			return KdR;
		}
		[CompilerGenerated]
		set
		{
			KdR = value;
		}
	}

	public bool CanMatchCurlyBraces
	{
		[CompilerGenerated]
		get
		{
			return Edf;
		}
		[CompilerGenerated]
		set
		{
			Edf = value;
		}
	}

	public bool CanMatchParentheses
	{
		[CompilerGenerated]
		get
		{
			return ydt;
		}
		[CompilerGenerated]
		set
		{
			ydt = value;
		}
	}

	public bool CanMatchSquareBraces
	{
		[CompilerGenerated]
		get
		{
			return idQ;
		}
		[CompilerGenerated]
		set
		{
			idQ = value;
		}
	}

	public int? CloseAngleBraceTokenId
	{
		[CompilerGenerated]
		get
		{
			return kdn;
		}
		[CompilerGenerated]
		set
		{
			kdn = value;
		}
	}

	public int? CloseCurlyBraceTokenId
	{
		[CompilerGenerated]
		get
		{
			return AdG;
		}
		[CompilerGenerated]
		set
		{
			AdG = value;
		}
	}

	public int? CloseParenthesisTokenId
	{
		[CompilerGenerated]
		get
		{
			return gde;
		}
		[CompilerGenerated]
		set
		{
			gde = value;
		}
	}

	public int? CloseSquareBraceTokenId
	{
		[CompilerGenerated]
		get
		{
			return fdy;
		}
		[CompilerGenerated]
		set
		{
			fdy = value;
		}
	}

	public int? OpenAngleBraceTokenId
	{
		[CompilerGenerated]
		get
		{
			return Tdz;
		}
		[CompilerGenerated]
		set
		{
			Tdz = value;
		}
	}

	public int? OpenCurlyBraceTokenId
	{
		[CompilerGenerated]
		get
		{
			return mLS;
		}
		[CompilerGenerated]
		set
		{
			mLS = value;
		}
	}

	public int? OpenParenthesisTokenId
	{
		[CompilerGenerated]
		get
		{
			return RLV;
		}
		[CompilerGenerated]
		set
		{
			RLV = value;
		}
	}

	public int? OpenSquareBraceTokenId
	{
		[CompilerGenerated]
		get
		{
			return KLB;
		}
		[CompilerGenerated]
		set
		{
			KLB = value;
		}
	}

	public StructureMatcher()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		CanMatchCurlyBraces = true;
		CanMatchParentheses = true;
		CanMatchSquareBraces = true;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private char VdJ(ITextSnapshotReader P_0, char P_1, bool P_2)
	{
		if (P_2)
		{
			switch (P_1)
			{
			case '<':
				if (!CanMatchAngleBraces)
				{
					break;
				}
				if (OpenAngleBraceTokenId.HasValue)
				{
					IToken token3 = P_0.PeekToken();
					if (token3 == null || token3.Id != OpenAngleBraceTokenId.Value)
					{
						break;
					}
				}
				return '>';
			case '{':
				if (!CanMatchCurlyBraces)
				{
					break;
				}
				if (OpenCurlyBraceTokenId.HasValue)
				{
					IToken token4 = P_0.PeekToken();
					if (token4 == null || token4.Id != OpenCurlyBraceTokenId.Value)
					{
						break;
					}
				}
				return '}';
			case '(':
				if (!CanMatchParentheses)
				{
					break;
				}
				if (OpenParenthesisTokenId.HasValue)
				{
					IToken token2 = P_0.PeekToken();
					if (token2 == null || token2.Id != OpenParenthesisTokenId.Value)
					{
						break;
					}
				}
				return ')';
			case '[':
				if (!CanMatchSquareBraces)
				{
					break;
				}
				if (OpenSquareBraceTokenId.HasValue)
				{
					IToken token = P_0.PeekToken();
					if (token == null || token.Id != OpenSquareBraceTokenId.Value)
					{
						break;
					}
				}
				return ']';
			}
		}
		else
		{
			switch (P_1)
			{
			case '>':
				if (!CanMatchAngleBraces)
				{
					break;
				}
				if (CloseAngleBraceTokenId.HasValue)
				{
					IToken token7 = P_0.PeekToken();
					if (token7 == null || token7.Id != CloseAngleBraceTokenId.Value)
					{
						break;
					}
				}
				return '<';
			case '}':
				if (!CanMatchCurlyBraces)
				{
					break;
				}
				if (CloseCurlyBraceTokenId.HasValue)
				{
					IToken token8 = P_0.PeekToken();
					if (token8 == null || token8.Id != CloseCurlyBraceTokenId.Value)
					{
						break;
					}
				}
				return '{';
			case ')':
				if (!CanMatchParentheses)
				{
					break;
				}
				if (CloseParenthesisTokenId.HasValue)
				{
					IToken token6 = P_0.PeekToken();
					if (token6 == null || token6.Id != CloseParenthesisTokenId.Value)
					{
						break;
					}
				}
				return '(';
			case ']':
				if (!CanMatchSquareBraces)
				{
					break;
				}
				if (CloseSquareBraceTokenId.HasValue)
				{
					IToken token5 = P_0.PeekToken();
					if (token5 == null || token5.Id != CloseSquareBraceTokenId.Value)
					{
						break;
					}
				}
				return '[';
			}
		}
		return '\0';
	}

	private IStructureMatchResultSet YdX(ITextSnapshotReader P_0, char P_1, char P_2)
	{
		int offset = P_0.Offset;
		StructureMatchResultCollection structureMatchResultCollection = null;
		int num = 1;
		while (!P_0.IsAtSnapshotStart)
		{
			char c = P_0.ReadCharacterReverse();
			if (c == P_2)
			{
				if (VdJ(P_0, c, _0020: true) != 0 && --num <= 0)
				{
					structureMatchResultCollection = new StructureMatchResultCollection();
					structureMatchResultCollection.Add(new StructureMatchResult(new TextSnapshotRange(P_0.Snapshot, P_0.Offset, P_0.Offset + 1))
					{
						MatchEdges = StructureMatchEdges.Start,
						NavigationSnapshotOffset = new TextSnapshotOffset(P_0.Snapshot, P_0.Offset)
					});
					structureMatchResultCollection.Add(new StructureMatchResult(new TextSnapshotRange(P_0.Snapshot, offset, offset + 1))
					{
						IsSource = true,
						MatchEdges = StructureMatchEdges.End,
						NavigationSnapshotOffset = new TextSnapshotOffset(P_0.Snapshot, offset + 1)
					});
					break;
				}
			}
			else if (c == P_1 && VdJ(P_0, c, _0020: false) != 0)
			{
				num++;
			}
		}
		return new StructureMatchResultSet(structureMatchResultCollection);
	}

	private IStructureMatchResultSet pdN(ITextSnapshotReader P_0, char P_1, char P_2)
	{
		int num = P_0.Offset - 1;
		StructureMatchResultCollection structureMatchResultCollection = null;
		int num2 = 1;
		int num3 = 0;
		if (Hq8() != null)
		{
			num3 = 0;
		}
		char c = default(char);
		int num4 = default(int);
		while (true)
		{
			switch (num3)
			{
			case 2:
				if (c == P_1 && VdJ(P_0, c, _0020: true) != 0)
				{
					num2++;
				}
				goto IL_00cb;
			default:
				{
					if (P_0.IsAtSnapshotEnd)
					{
						break;
					}
					c = P_0.PeekCharacter();
					if (c == P_2)
					{
						if (VdJ(P_0, c, _0020: false) == '\0' || --num2 > 0)
						{
							goto IL_00cb;
						}
						structureMatchResultCollection = new StructureMatchResultCollection();
						structureMatchResultCollection.Add(new StructureMatchResult(new TextSnapshotRange(P_0.Snapshot, num, num + 1))
						{
							IsSource = true,
							MatchEdges = StructureMatchEdges.Start,
							NavigationSnapshotOffset = new TextSnapshotOffset(P_0.Snapshot, num)
						});
						structureMatchResultCollection.Add(new StructureMatchResult(new TextSnapshotRange(P_0.Snapshot, P_0.Offset, P_0.Offset + 1))
						{
							MatchEdges = StructureMatchEdges.End,
							NavigationSnapshotOffset = new TextSnapshotOffset(P_0.Snapshot, P_0.Offset + 1)
						});
						break;
					}
					goto case 2;
				}
				IL_00cb:
				P_0.ReadCharacter();
				num3 = 1;
				if (Hq8() != null)
				{
					num3 = num4;
				}
				continue;
			}
			break;
		}
		return new StructureMatchResultSet(structureMatchResultCollection);
	}

	public virtual IStructureMatchResultSet Match(TextSnapshotOffset snapshotOffset, IStructureMatchOptions options)
	{
		if (snapshotOffset.IsDeleted)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5754));
		}
		ITextSnapshotReader reader = snapshotOffset.Snapshot.GetReader(snapshotOffset.Offset);
		reader.Options.DefaultTokenLoadBufferLength = 250;
		reader.Options.InitialTokenLoadBufferLength = 4;
		char c = reader.PeekCharacter();
		char c2 = VdJ(reader, c, _0020: true);
		if (c2 != 0)
		{
			reader.ReadCharacter();
			return pdN(reader, c, c2);
		}
		c = reader.ReadCharacterReverse();
		c2 = VdJ(reader, c, _0020: false);
		if (c2 != 0)
		{
			return YdX(reader, c, c2);
		}
		if (options != null && options.IsNavigationRequest)
		{
			c = reader.PeekCharacter();
			c2 = VdJ(reader, c, _0020: true);
			reader.ReadCharacter();
			if (c2 != 0)
			{
				return pdN(reader, c, c2);
			}
			c = reader.PeekCharacter();
			c2 = VdJ(reader, c, _0020: false);
			if (c2 != 0)
			{
				return YdX(reader, c, c2);
			}
		}
		return null;
	}

	internal static bool Aq9()
	{
		return LqZ == null;
	}

	internal static StructureMatcher Hq8()
	{
		return LqZ;
	}
}
