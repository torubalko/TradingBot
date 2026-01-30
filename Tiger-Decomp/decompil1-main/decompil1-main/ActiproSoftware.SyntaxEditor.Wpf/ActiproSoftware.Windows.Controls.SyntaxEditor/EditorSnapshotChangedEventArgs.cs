using System;
using System.Windows;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.RegularExpressions;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public class EditorSnapshotChangedEventArgs : RoutedEventArgs
{
	private TextSnapshotRange? raa;

	private ITextSnapshot yax;

	private ITextSnapshot MaG;

	private ITextChange OaX;

	internal static EditorSnapshotChangedEventArgs kT;

	public TextSnapshotRange ChangedSnapshotRange
	{
		get
		{
			if (!raa.HasValue)
			{
				raa = Wac();
			}
			return raa.Value;
		}
	}

	public bool IsTypedWordStart => GetIsTypedWordStart(yax, OaX, CharClass.Alpha);

	public ITextSnapshot NewSnapshot => yax;

	public ITextSnapshot OldSnapshot => MaG;

	public ITextChange TextChange => OaX;

	public string TypedText
	{
		get
		{
			if (OaX != null && !OaX.IsUndo && !OaX.IsRedo && OaX.Operations.Count == 1 && OaX.Operations[0].InsertionLength > 0 && OaX.Type == TextChangeTypes.Typing)
			{
				return OaX.Operations[0].InsertedText;
			}
			return null;
		}
	}

	public EditorSnapshotChangedEventArgs(ITextSnapshot oldSnapshot, ITextSnapshot newSnapshot, ITextChange textChange)
	{
		grA.DaB7cz();
		base._002Ector();
		MaG = oldSnapshot;
		yax = newSnapshot;
		OaX = textChange;
	}

	private TextSnapshotRange Wac()
	{
		int num;
		if (TextChange != null)
		{
			num = 0;
			if (WY() != null)
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_0030;
		IL_0030:
		return TextSnapshotRange.Deleted;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_0131;
			}
			break;
			IL_0131:
			num3 = int.MaxValue;
			num = 1;
			if (Ut())
			{
				continue;
			}
			goto IL_0005;
		}
		int num4 = 0;
		int num5 = TextChange.Operations.Count - 1;
		while (num5 >= 0)
		{
			ITextChangeOperation textChangeOperation = TextChange.Operations[num5];
			if (!textChangeOperation.IsTextReplacement)
			{
				num3 = Math.Min(num3, textChangeOperation.StartOffset);
				num4 = Math.Max(num4, Math.Max(textChangeOperation.DeletionEndOffset, textChangeOperation.InsertionEndOffset));
				num5--;
				continue;
			}
			return NewSnapshot.SnapshotRange;
		}
		if (num3 != int.MaxValue)
		{
			return new TextSnapshotRange(NewSnapshot, num3, num4);
		}
		goto IL_0030;
	}

	public static bool GetIsTypedWordStart(ITextSnapshot snapshot, ITextChange textChange, CharClass wordStartChars)
	{
		if (snapshot != null && textChange != null && !textChange.IsUndo && !textChange.IsRedo && textChange.Operations.Count == 1 && textChange.Type == TextChangeTypes.Typing)
		{
			ITextChangeOperation textChangeOperation = textChange.Operations[0];
			if (textChangeOperation.InsertionLength == 1 && wordStartChars != null && wordStartChars.Contains(textChangeOperation.InsertedText[0]))
			{
				ITextSnapshotReader reader = snapshot.GetReader(textChangeOperation.InsertionEndOffset);
				if (reader != null)
				{
					reader.GoToCurrentWordStart();
					if (reader.Offset == textChangeOperation.StartOffset)
					{
						reader.GoToCurrentWordEnd();
						if (reader.Offset == textChangeOperation.InsertionEndOffset)
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	internal static bool Ut()
	{
		return kT == null;
	}

	internal static EditorSnapshotChangedEventArgs WY()
	{
		return kT;
	}
}
