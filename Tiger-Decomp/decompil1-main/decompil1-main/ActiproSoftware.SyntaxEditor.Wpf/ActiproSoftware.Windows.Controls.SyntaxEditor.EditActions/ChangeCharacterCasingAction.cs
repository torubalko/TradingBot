using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public abstract class ChangeCharacterCasingAction : EditActionBase
{
	private static ChangeCharacterCasingAction IkP;

	protected abstract CharacterCasing? Casing { get; }

	protected ChangeCharacterCasingAction(string text)
	{
		grA.DaB7cz();
		base._002Ector(text);
	}

	private static string nLN(TextSnapshotRange P_0, CharacterCasing? P_1)
	{
		bool flag = false;
		StringBuilder stringBuilder = new StringBuilder();
		ITextSnapshotReader reader = P_0.Snapshot.GetReader(P_0.StartOffset);
		bool flag2 = true;
		if (P_0.StartOffset > 0)
		{
			flag2 = !char.IsLetter(reader.PeekCharacterReverse());
		}
		while (reader.Offset < P_0.EndOffset)
		{
			char c = reader.ReadCharacter();
			if (char.IsLetter(c))
			{
				switch (P_1)
				{
				case CharacterCasing.Lower:
					if (char.IsUpper(c))
					{
						c = char.ToLower(c, CultureInfo.CurrentCulture);
						flag = true;
					}
					break;
				case CharacterCasing.Normal:
					if (flag2)
					{
						flag2 = false;
						c = char.ToUpper(c, CultureInfo.CurrentCulture);
						flag = true;
					}
					break;
				case CharacterCasing.Upper:
					if (char.IsLower(c))
					{
						c = char.ToUpper(c, CultureInfo.CurrentCulture);
						flag = true;
					}
					break;
				default:
					if (char.IsUpper(c))
					{
						c = char.ToLower(c, CultureInfo.CurrentCulture);
						flag = true;
					}
					else if (char.IsLower(c))
					{
						c = char.ToUpper(c, CultureInfo.CurrentCulture);
						flag = true;
					}
					break;
				}
			}
			else
			{
				flag2 = true;
			}
			stringBuilder.Append(c);
		}
		return flag ? stringBuilder.ToString() : null;
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		return !view.SyntaxEditor.Document.IsReadOnly;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.None))
		{
			SelectionModes mode = view.Selection.Mode;
			ITextSnapshot currentSnapshot = view.CurrentSnapshot;
			EditorViewTextChangeOptions options = new EditorViewTextChangeOptions(view)
			{
				CheckReadOnly = true,
				VirtualCharacterFill = false,
				IsBlock = (mode == SelectionModes.Block)
			};
			ITextChange textChange = currentSnapshot.CreateTextChange(TextChangeTypes.TrimTrailingWhitespace, options);
			bool flag = false;
			TextPositionRange[] array = view.Selection.Ranges.ToArray();
			if (mode == SelectionModes.Block)
			{
				IList<TextRange> textRanges = view.Selection.GetTextRanges();
				for (int num = textRanges.Count - 1; num >= 0; num--)
				{
					TextRange textRange = textRanges[num];
					if (!textRange.IsZeroLength)
					{
						TextSnapshotRange textSnapshotRange = new TextSnapshotRange(currentSnapshot, textRange);
						string text = nLN(textSnapshotRange, Casing);
						if (text != null)
						{
							textChange.ReplaceText(textSnapshotRange, text);
						}
					}
				}
				if (textChange.Operations.Count > 0)
				{
					textChange.Apply();
					view.Selection.SelectRange(array[0], SelectionModes.Block);
				}
				return;
			}
			TextPositionRange[] array2 = new TextPositionRange[array.Length];
			for (int num2 = array.Length - 1; num2 >= 0; num2--)
			{
				TextPositionRange textPositionRange = array[num2];
				TextRange textRange2 = currentSnapshot.PositionRangeToTextRange(textPositionRange);
				if (textPositionRange.IsZeroLength)
				{
					if (view.IsVirtualCharacter(textPositionRange.FirstPosition, lineTerminatorsAreVirtual: true))
					{
						bool flag2 = textRange2.EndOffset >= currentSnapshot.Length;
						array2[num2] = (flag2 ? textPositionRange : new TextPositionRange(new TextPosition(textPositionRange.EndPosition.Line + 1, 0)));
						flag = flag || !flag2;
					}
					else
					{
						TextSnapshotRange textSnapshotRange2 = new TextSnapshotRange(currentSnapshot, textRange2.EndOffset, textRange2.EndOffset + 1);
						string text2 = nLN(textSnapshotRange2, Casing);
						if (text2 != null)
						{
							textChange.ReplaceText(textSnapshotRange2, text2);
						}
						array2[num2] = new TextPositionRange(textPositionRange.EndPosition.Line, textPositionRange.EndPosition.Character + 1, textPositionRange.EndPosition.Line, textPositionRange.EndPosition.Character + 1);
						flag = true;
					}
				}
				else
				{
					TextSnapshotRange textSnapshotRange3 = new TextSnapshotRange(currentSnapshot, textRange2);
					string text3 = nLN(textSnapshotRange3, Casing);
					if (text3 != null)
					{
						textChange.ReplaceText(textSnapshotRange3, text3);
					}
					array2[num2] = textPositionRange;
				}
			}
			if (textChange.Operations.Count > 0)
			{
				textChange.PostSelectionPositionRanges = TextPositionRange.CreateCollection(array2, view.Selection.Ranges.PrimaryIndex);
				textChange.Apply();
			}
			else if (flag)
			{
				view.Selection.SelectRanges(array2);
			}
		}
	}

	internal static bool Gko()
	{
		return IkP == null;
	}

	internal static ChangeCharacterCasingAction NkQ()
	{
		return IkP;
	}
}
