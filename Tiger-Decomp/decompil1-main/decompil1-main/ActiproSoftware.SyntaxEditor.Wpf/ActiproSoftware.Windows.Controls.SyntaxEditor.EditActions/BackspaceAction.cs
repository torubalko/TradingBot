using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class BackspaceAction : EditActionBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public Dictionary<TextPosition, int> bSd;

		public TextPositionRange[] JSz;

		internal static _003C_003Ec__DisplayClass2_0 o3w;

		public _003C_003Ec__DisplayClass2_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal TextPositionRange QSN(TextPosition position)
		{
			if (bSd == null || !bSd.TryGetValue(position, out var value))
			{
				return new TextPositionRange(position);
			}
			return JSz[value];
		}

		internal static bool S3u()
		{
			return o3w == null;
		}

		internal static _003C_003Ec__DisplayClass2_0 o38()
		{
			return o3w;
		}
	}

	private static BackspaceAction tSG;

	public BackspaceAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandBackspaceText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view.Selection.Ranges.Count == 1 && view.Selection.IsZeroLength && view.Selection.StartPosition == TextPosition.Zero)
		{
			return false;
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
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals14 = new _003C_003Ec__DisplayClass2_0();
			bool flag = false;
			bool flag2 = true;
			CS_0024_003C_003E8__locals14.JSz = view.Selection.Ranges.ToArray();
			CS_0024_003C_003E8__locals14.bSd = null;
			for (int num = CS_0024_003C_003E8__locals14.JSz.Length - 1; num >= 0; num--)
			{
				TextPositionRange textPositionRange = CS_0024_003C_003E8__locals14.JSz[num];
				if (textPositionRange.IsZeroLength)
				{
					ITextSnapshot currentSnapshot = view.CurrentSnapshot;
					if (textPositionRange.EndPosition.Character == 0)
					{
						if (textPositionRange.EndPosition.Line > 0)
						{
							CS_0024_003C_003E8__locals14.JSz[num] = new TextPositionRange(new TextPosition(textPositionRange.EndPosition.Line - 1, currentSnapshot.Lines[Math.Min(currentSnapshot.Lines.Count - 1, textPositionRange.EndPosition.Line - 1)].Length), textPositionRange.EndPosition);
							flag = true;
							flag2 = false;
						}
					}
					else
					{
						int num2 = currentSnapshot.PositionToOffset(textPositionRange.EndPosition);
						int num3 = Math.Max(0, Math.Min(num2 - 1, view.CollapsedRegionManager.GetVisibleOffset(new TextSnapshotOffset(currentSnapshot, num2 - 1), hasFarAffinity: false)));
						if (num2 - num3 == 1 && view.SyntaxEditor.Document.AutoConvertTabsToSpaces && view.SyntaxEditor.CanBackspaceOverSpacesToTabStop && num2 <= view.CurrentViewLine.FirstNonWhitespaceOffset)
						{
							int num4 = view.CurrentViewLine.GetCharacterColumn(num2 - 1) % view.SyntaxEditor.Document.TabSize;
							num3 -= num4;
						}
						if (vAE.u0u(view.CurrentSnapshot[num3]))
						{
							num3--;
						}
						CS_0024_003C_003E8__locals14.JSz[num] = currentSnapshot.TextRangeToPositionRange(new TextRange(num3, num2));
						flag = true;
						flag2 = false;
					}
					if (CS_0024_003C_003E8__locals14.bSd == null)
					{
						CS_0024_003C_003E8__locals14.bSd = new Dictionary<TextPosition, int>();
					}
					CS_0024_003C_003E8__locals14.bSd[textPositionRange.EndPosition] = num;
				}
				else if (textPositionRange.Lines == 1 && view.IsVirtualCharacter(textPositionRange.FirstPosition, lineTerminatorsAreVirtual: true))
				{
					CS_0024_003C_003E8__locals14.JSz[num] = new TextPositionRange(textPositionRange.FirstPosition);
					flag = true;
				}
				else
				{
					flag2 = false;
				}
			}
			if (flag2)
			{
				if (flag)
				{
					view.Selection.SelectRanges(CS_0024_003C_003E8__locals14.JSz);
				}
				return;
			}
			EditorViewTextChangeOptions editorViewTextChangeOptions = new EditorViewTextChangeOptions(view)
			{
				CanApplyToMultipleSelections = true,
				CheckReadOnly = true
			};
			editorViewTextChangeOptions.BlockEditRangeAdjustFunc = delegate(ITextViewLine viewLine, Range characterRange)
			{
				if (characterRange.Length == 0 && characterRange.Min > 0)
				{
					characterRange = new Range(characterRange.Min - 1, characterRange.Max);
				}
				return characterRange;
			};
			editorViewTextChangeOptions.ZeroLengthEditRangeAdjustFunc = (TextPosition position) => (CS_0024_003C_003E8__locals14.bSd == null || !CS_0024_003C_003E8__locals14.bSd.TryGetValue(position, out var value)) ? new TextPositionRange(position) : CS_0024_003C_003E8__locals14.JSz[value];
			view.DeleteSelectedText(TextChangeTypes.Delete, editorViewTextChangeOptions);
		}
	}

	internal static bool sSN()
	{
		return tSG == null;
	}

	internal static BackspaceAction GSH()
	{
		return tSG;
	}
}
