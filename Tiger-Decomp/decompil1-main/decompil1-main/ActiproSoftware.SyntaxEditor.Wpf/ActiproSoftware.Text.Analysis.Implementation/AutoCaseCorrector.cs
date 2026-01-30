using ActiproSoftware.Internal;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Lexing;

namespace ActiproSoftware.Text.Analysis.Implementation;

public class AutoCaseCorrector : AutoCorrectorBase
{
	private static AutoCaseCorrector lGf;

	public override void AutoCorrect(TextSnapshotRange snapshotRange)
	{
		if (snapshotRange.IsDeleted)
		{
			return;
		}
		ITextSnapshot snapshot = snapshotRange.Snapshot;
		ITextSnapshotReader reader = snapshot.GetReader(snapshotRange.StartOffset);
		reader.Options.PrimaryScanDirection = TextScanDirection.Forward;
		reader.Options.DefaultTokenLoadBufferLength = snapshotRange.Length;
		ITextChange textChange = null;
		int num = 2;
		if (PGi())
		{
			num = 2;
		}
		IToken token = default(IToken);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 2:
				if (reader.Offset >= snapshotRange.EndOffset)
				{
					break;
				}
				goto default;
			case 1:
			{
				string caseCorrectText = GetCaseCorrectText(snapshot, token);
				if (!string.IsNullOrEmpty(caseCorrectText) && snapshot.GetSubstring(token.TextRange) != caseCorrectText)
				{
					if (textChange == null)
					{
						textChange = snapshotRange.Snapshot.CreateTextChange(TextChangeTypes.AutoCorrect, new TextChangeOptions
						{
							CanMergeIntoPreviousChange = true,
							CheckReadOnly = true,
							OffsetDelta = TextChangeOffsetDelta.SequentialOnly,
							RetainSelection = true
						});
					}
					textChange.ReplaceText(token.TextRange, caseCorrectText);
				}
				goto IL_0151;
			}
			default:
				{
					token = reader.Token;
					if (token != null)
					{
						num = 1;
						if (EG2() != null)
						{
							num = num2;
						}
						continue;
					}
					goto IL_0151;
				}
				IL_0151:
				if (!reader.GoToNextToken())
				{
					break;
				}
				goto case 2;
			}
			break;
		}
		textChange?.Apply();
	}

	protected virtual string GetCaseCorrectText(ITextSnapshot snapshot, IToken token)
	{
		if (token is IMergableToken mergableToken && mergableToken.HasFlag(MergableLexerFlags.LooseMatch))
		{
			return mergableToken.AutoCaseCorrectText;
		}
		return null;
	}

	public AutoCaseCorrector()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool PGi()
	{
		return lGf == null;
	}

	internal static AutoCaseCorrector EG2()
	{
		return lGf;
	}
}
