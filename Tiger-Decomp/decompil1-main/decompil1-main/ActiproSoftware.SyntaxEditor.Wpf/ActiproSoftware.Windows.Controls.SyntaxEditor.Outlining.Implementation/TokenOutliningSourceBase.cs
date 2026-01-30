using System;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Lexing;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining.Implementation;

public abstract class TokenOutliningSourceBase : IOutliningSource
{
	private ITextSnapshotReader emM;

	private IToken hmO;

	private static TokenOutliningSourceBase n75;

	protected TokenOutliningSourceBase(ITextSnapshot snapshot)
	{
		grA.DaB7cz();
		base._002Ector();
		if (snapshot == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12044));
		}
		emM = snapshot.GetReader(0);
	}

	[SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "1#")]
	[SuppressMessage("Microsoft.Maintainability", "CA1500:VariableNamesShouldNotMatchFieldNames", MessageId = "token")]
	protected abstract OutliningNodeAction GetNodeActionForToken(IToken token, out IOutliningNodeDefinition definition);

	public virtual OutliningNodeAction GetNodeAction(ref int offset, out IOutliningNodeDefinition definition)
	{
		emM.Offset = offset;
		if (hmO == null || !hmO.Contains(offset))
		{
			hmO = emM.Token;
		}
		if (hmO != null)
		{
			int endOffset = hmO.EndOffset;
			if (endOffset == offset + 1 || hmO.StartOffset == offset)
			{
				switch (GetNodeActionForToken(hmO, out definition))
				{
				case OutliningNodeAction.Start:
					if (hmO.StartOffset == offset)
					{
						offset = endOffset;
						return OutliningNodeAction.Start;
					}
					offset = endOffset;
					break;
				case OutliningNodeAction.End:
					if (endOffset == offset + 1)
					{
						return OutliningNodeAction.End;
					}
					offset = endOffset - 1;
					break;
				default:
					offset = endOffset;
					break;
				}
			}
			else
			{
				offset = endOffset - 1;
				definition = null;
			}
		}
		else
		{
			definition = null;
		}
		return OutliningNodeAction.None;
	}

	internal static bool K7G()
	{
		return n75 == null;
	}

	internal static TokenOutliningSourceBase H7N()
	{
		return n75;
	}
}
