using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class DeleteToNextWordAction : EditActionBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public IEditorView W9v;

		private static _003C_003Ec__DisplayClass2_0 Rvg;

		public _003C_003Ec__DisplayClass2_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool avA()
		{
			return Rvg == null;
		}

		internal static _003C_003Ec__DisplayClass2_0 lvl()
		{
			return Rvg;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_1
	{
		public IWordBreakFinder W9u;

		public Dictionary<TextPosition, int> c91;

		public TextPositionRange[] m9F;

		public _003C_003Ec__DisplayClass2_0 H93;

		private static _003C_003Ec__DisplayClass2_1 MvW;

		public _003C_003Ec__DisplayClass2_1()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal Range O9m(ITextViewLine viewLine, Range characterRange)
		{
			if (viewLine != null && !viewLine.IsVirtualCharacter(characterRange.Max, lineTerminatorsAreVirtual: true))
			{
				int offset = viewLine.CharacterIndexToOffset(characterRange.Max);
				int offset2 = W9u.FindNextWordStart(new TextSnapshotOffset(H93.W9v.CurrentSnapshot, offset));
				characterRange = new Range(characterRange.Min, viewLine.OffsetToCharacterIndex(offset2));
			}
			return characterRange;
		}

		internal TextPositionRange U9C(TextPosition position)
		{
			if (c91 != null && c91.TryGetValue(position, out var value))
			{
				return m9F[value];
			}
			return new TextPositionRange(position);
		}

		internal static bool VvS()
		{
			return MvW == null;
		}

		internal static _003C_003Ec__DisplayClass2_1 Rvk()
		{
			return MvW;
		}
	}

	internal static DeleteToNextWordAction PS6;

	public DeleteToNextWordAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandDeleteToNextWordText));
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
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.W9v = view;
		if (_003C_003Ec__DisplayClass2_.W9v == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		using (_003C_003Ec__DisplayClass2_.W9v.Selection.CreateBatch(EditorViewSelectionBatchOptions.None))
		{
			_003C_003Ec__DisplayClass2_1 CS_0024_003C_003E8__locals32 = new _003C_003Ec__DisplayClass2_1();
			CS_0024_003C_003E8__locals32.H93 = _003C_003Ec__DisplayClass2_;
			bool flag = false;
			bool flag2 = true;
			int num = 1;
			if (ESC() != null)
			{
				goto IL_0067;
			}
			goto IL_006b;
			IL_0067:
			int num2 = default(int);
			num = num2;
			goto IL_006b;
			IL_006b:
			int num8 = default(int);
			int num6 = default(int);
			bool isZeroLength = default(bool);
			ITextSnapshot currentSnapshot = default(ITextSnapshot);
			int num3 = default(int);
			TextPositionRange textPositionRange = default(TextPositionRange);
			while (true)
			{
				EditorViewTextChangeOptions editorViewTextChangeOptions;
				int value;
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					num8++;
					goto IL_02b9;
				case 3:
					CS_0024_003C_003E8__locals32.c91 = null;
					num6 = CS_0024_003C_003E8__locals32.m9F.Length - 1;
					goto IL_0124;
				case 1:
					CS_0024_003C_003E8__locals32.m9F = CS_0024_003C_003E8__locals32.H93.W9v.Selection.Ranges.ToArray();
					CS_0024_003C_003E8__locals32.W9u = CS_0024_003C_003E8__locals32.H93.W9v.SyntaxEditor.Document.Language.GetWordBreakFinder() ?? new DefaultWordBreakFinder();
					num = 3;
					if (!BSK())
					{
						num = 3;
					}
					continue;
				case 4:
					if (isZeroLength)
					{
						currentSnapshot = CS_0024_003C_003E8__locals32.H93.W9v.CurrentSnapshot;
						num3 = currentSnapshot.PositionToOffset(textPositionRange.EndPosition);
						if (CS_0024_003C_003E8__locals32.H93.W9v.IsVirtualCharacter(textPositionRange.EndPosition, lineTerminatorsAreVirtual: true))
						{
							if (num3 < currentSnapshot.Length)
							{
								int num4 = CS_0024_003C_003E8__locals32.W9u.FindNextWordStart(new TextSnapshotOffset(currentSnapshot, num3));
								int num5 = Math.Min(currentSnapshot.Length, Math.Max(num4, CS_0024_003C_003E8__locals32.H93.W9v.CollapsedRegionManager.GetVisibleOffset(new TextSnapshotOffset(currentSnapshot, num4), hasFarAffinity: true)));
								if (vAE.u0u(CS_0024_003C_003E8__locals32.H93.W9v.CurrentSnapshot[num5]))
								{
									num5++;
								}
								CS_0024_003C_003E8__locals32.m9F[num6] = new TextPositionRange(textPositionRange.EndPosition, currentSnapshot.OffsetToPosition(num5));
								flag = true;
								flag2 = false;
							}
							goto IL_0328;
						}
						goto case 5;
					}
					if (textPositionRange.Lines == 1 && CS_0024_003C_003E8__locals32.H93.W9v.IsVirtualCharacter(textPositionRange.FirstPosition, lineTerminatorsAreVirtual: true))
					{
						CS_0024_003C_003E8__locals32.m9F[num6] = new TextPositionRange(textPositionRange.FirstPosition);
						flag = true;
					}
					else
					{
						flag2 = false;
					}
					goto IL_00bd;
				case 5:
					{
						int num7 = CS_0024_003C_003E8__locals32.W9u.FindNextWordStart(new TextSnapshotOffset(currentSnapshot, num3));
						num8 = Math.Min(currentSnapshot.Length, Math.Max(num7, CS_0024_003C_003E8__locals32.H93.W9v.CollapsedRegionManager.GetVisibleOffset(new TextSnapshotOffset(currentSnapshot, num7), hasFarAffinity: true)));
						if (vAE.u0u(CS_0024_003C_003E8__locals32.H93.W9v.CurrentSnapshot[num8]))
						{
							num = 2;
							if (BSK())
							{
								continue;
							}
							break;
						}
						goto IL_02b9;
					}
					IL_00bd:
					num6--;
					goto IL_0124;
					IL_0328:
					if (CS_0024_003C_003E8__locals32.c91 == null)
					{
						CS_0024_003C_003E8__locals32.c91 = new Dictionary<TextPosition, int>();
					}
					CS_0024_003C_003E8__locals32.c91[textPositionRange.EndPosition] = num6;
					goto IL_00bd;
					IL_0124:
					if (num6 >= 0)
					{
						textPositionRange = CS_0024_003C_003E8__locals32.m9F[num6];
						isZeroLength = textPositionRange.IsZeroLength;
						num = 4;
						continue;
					}
					if (flag2)
					{
						if (!flag)
						{
							return;
						}
						CS_0024_003C_003E8__locals32.H93.W9v.Selection.SelectRanges(CS_0024_003C_003E8__locals32.m9F);
						num = 0;
						if (ESC() == null)
						{
							continue;
						}
						break;
					}
					editorViewTextChangeOptions = new EditorViewTextChangeOptions(CS_0024_003C_003E8__locals32.H93.W9v)
					{
						CanApplyToMultipleSelections = true,
						CheckReadOnly = true
					};
					editorViewTextChangeOptions.BlockEditRangeAdjustFunc = delegate(ITextViewLine viewLine, Range characterRange)
					{
						if (viewLine != null && !viewLine.IsVirtualCharacter(characterRange.Max, lineTerminatorsAreVirtual: true))
						{
							int offset = viewLine.CharacterIndexToOffset(characterRange.Max);
							int offset2 = CS_0024_003C_003E8__locals32.W9u.FindNextWordStart(new TextSnapshotOffset(CS_0024_003C_003E8__locals32.H93.W9v.CurrentSnapshot, offset));
							characterRange = new Range(characterRange.Min, viewLine.OffsetToCharacterIndex(offset2));
						}
						return characterRange;
					};
					editorViewTextChangeOptions.ZeroLengthEditRangeAdjustFunc = (TextPosition position) => (CS_0024_003C_003E8__locals32.c91 != null && CS_0024_003C_003E8__locals32.c91.TryGetValue(position, out value)) ? CS_0024_003C_003E8__locals32.m9F[value] : new TextPositionRange(position);
					CS_0024_003C_003E8__locals32.H93.W9v.DeleteSelectedText(TextChangeTypes.Delete, editorViewTextChangeOptions);
					return;
					IL_02b9:
					CS_0024_003C_003E8__locals32.m9F[num6] = currentSnapshot.TextRangeToPositionRange(new TextRange(num3, num8));
					flag = true;
					flag2 = false;
					goto IL_0328;
				}
				break;
			}
			goto IL_0067;
		}
	}

	internal static bool BSK()
	{
		return PS6 == null;
	}

	internal static DeleteToNextWordAction ESC()
	{
		return PS6;
	}
}
