using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class BackspaceToPreviousWordAction : EditActionBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public IEditorView G9c;

		internal static _003C_003Ec__DisplayClass2_0 Bvm;

		public _003C_003Ec__DisplayClass2_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool evp()
		{
			return Bvm == null;
		}

		internal static _003C_003Ec__DisplayClass2_0 qv4()
		{
			return Bvm;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_1
	{
		public IWordBreakFinder m9G;

		public Dictionary<TextPosition, int> k9X;

		public TextPositionRange[] p9K;

		public _003C_003Ec__DisplayClass2_0 c9f;

		internal static _003C_003Ec__DisplayClass2_1 avD;

		public _003C_003Ec__DisplayClass2_1()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal Range s9a(ITextViewLine viewLine, Range characterRange)
		{
			if (viewLine != null && characterRange.Min > 0)
			{
				int offset = viewLine.CharacterIndexToOffset(characterRange.Min);
				int offset2 = m9G.FindPreviousWordStart(new TextSnapshotOffset(c9f.G9c.CurrentSnapshot, offset));
				characterRange = new Range(viewLine.OffsetToCharacterIndex(offset2), characterRange.Max);
			}
			return characterRange;
		}

		internal TextPositionRange R9x(TextPosition position)
		{
			if (k9X != null && k9X.TryGetValue(position, out var value))
			{
				return p9K[value];
			}
			return new TextPositionRange(position);
		}

		internal static bool VvB()
		{
			return avD == null;
		}

		internal static _003C_003Ec__DisplayClass2_1 Vv0()
		{
			return avD;
		}
	}

	internal static BackspaceToPreviousWordAction gSj;

	public BackspaceToPreviousWordAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandBackspaceToPreviousWordText));
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

	[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
	public override void Execute(IEditorView view)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.G9c = view;
		if (_003C_003Ec__DisplayClass2_.G9c == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		using (_003C_003Ec__DisplayClass2_.G9c.Selection.CreateBatch(EditorViewSelectionBatchOptions.None))
		{
			_003C_003Ec__DisplayClass2_1 CS_0024_003C_003E8__locals28 = new _003C_003Ec__DisplayClass2_1();
			CS_0024_003C_003E8__locals28.c9f = _003C_003Ec__DisplayClass2_;
			bool flag = false;
			bool flag2 = true;
			CS_0024_003C_003E8__locals28.p9K = CS_0024_003C_003E8__locals28.c9f.G9c.Selection.Ranges.ToArray();
			CS_0024_003C_003E8__locals28.m9G = CS_0024_003C_003E8__locals28.c9f.G9c.SyntaxEditor.Document.Language.GetWordBreakFinder() ?? new DefaultWordBreakFinder();
			CS_0024_003C_003E8__locals28.k9X = null;
			bool flag3 = default(bool);
			ITextSnapshot currentSnapshot = default(ITextSnapshot);
			int num3 = default(int);
			for (int num = CS_0024_003C_003E8__locals28.p9K.Length - 1; num >= 0; num--)
			{
				while (true)
				{
					TextPositionRange textPositionRange = CS_0024_003C_003E8__locals28.p9K[num];
					bool isZeroLength = textPositionRange.IsZeroLength;
					int num2 = 2;
					while (true)
					{
						switch (num2)
						{
						case 5:
							if (!flag3)
							{
								int num4 = currentSnapshot.PositionToOffset(textPositionRange.EndPosition);
								int num5 = CS_0024_003C_003E8__locals28.m9G.FindPreviousWordStart(new TextSnapshotOffset(currentSnapshot, num4));
								int num6 = Math.Max(0, Math.Min(num5, CS_0024_003C_003E8__locals28.c9f.G9c.CollapsedRegionManager.GetVisibleOffset(new TextSnapshotOffset(currentSnapshot, num5), hasFarAffinity: false)));
								if (vAE.u0u(CS_0024_003C_003E8__locals28.c9f.G9c.CurrentSnapshot[num6]))
								{
									num6--;
								}
								CS_0024_003C_003E8__locals28.p9K[num] = currentSnapshot.TextRangeToPositionRange(new TextRange(num6, num4));
								flag = true;
								flag2 = false;
								num2 = 0;
								if (uS3() == null)
								{
									continue;
								}
								goto IL_0066;
							}
							if (textPositionRange.EndPosition.Line > 0)
							{
								CS_0024_003C_003E8__locals28.p9K[num] = new TextPositionRange(new TextPosition(textPositionRange.EndPosition.Line - 1, currentSnapshot.Lines[Math.Min(currentSnapshot.Lines.Count - 1, textPositionRange.EndPosition.Line - 1)].Length), textPositionRange.EndPosition);
								flag = true;
								flag2 = false;
							}
							goto default;
						default:
							if (CS_0024_003C_003E8__locals28.k9X == null)
							{
								num2 = 1;
								if (HSM())
								{
									continue;
								}
								goto IL_0066;
							}
							goto IL_02d7;
						case 3:
							currentSnapshot = CS_0024_003C_003E8__locals28.c9f.G9c.CurrentSnapshot;
							flag3 = textPositionRange.EndPosition.Character == 0;
							num2 = 5;
							continue;
						case 2:
							if (!isZeroLength)
							{
								if (textPositionRange.Lines == 1 && CS_0024_003C_003E8__locals28.c9f.G9c.IsVirtualCharacter(textPositionRange.FirstPosition, lineTerminatorsAreVirtual: true))
								{
									CS_0024_003C_003E8__locals28.p9K[num] = new TextPositionRange(textPositionRange.FirstPosition);
									flag = true;
								}
								else
								{
									flag2 = false;
								}
								goto end_IL_0492;
							}
							num2 = 3;
							if (!HSM())
							{
								num2 = 1;
							}
							continue;
						case 1:
							CS_0024_003C_003E8__locals28.k9X = new Dictionary<TextPosition, int>();
							goto IL_02d7;
						case 4:
							break;
							IL_0066:
							num2 = num3;
							continue;
							IL_02d7:
							CS_0024_003C_003E8__locals28.k9X[textPositionRange.EndPosition] = num;
							goto end_IL_0492;
						}
						break;
					}
					continue;
					end_IL_0492:
					break;
				}
			}
			if (flag2)
			{
				if (flag)
				{
					CS_0024_003C_003E8__locals28.c9f.G9c.Selection.SelectRanges(CS_0024_003C_003E8__locals28.p9K);
				}
				return;
			}
			EditorViewTextChangeOptions editorViewTextChangeOptions = new EditorViewTextChangeOptions(CS_0024_003C_003E8__locals28.c9f.G9c)
			{
				CanApplyToMultipleSelections = true,
				CheckReadOnly = true
			};
			editorViewTextChangeOptions.BlockEditRangeAdjustFunc = delegate(ITextViewLine viewLine, Range characterRange)
			{
				if (viewLine != null && characterRange.Min > 0)
				{
					int offset = viewLine.CharacterIndexToOffset(characterRange.Min);
					int offset2 = CS_0024_003C_003E8__locals28.m9G.FindPreviousWordStart(new TextSnapshotOffset(CS_0024_003C_003E8__locals28.c9f.G9c.CurrentSnapshot, offset));
					characterRange = new Range(viewLine.OffsetToCharacterIndex(offset2), characterRange.Max);
				}
				return characterRange;
			};
			editorViewTextChangeOptions.ZeroLengthEditRangeAdjustFunc = (TextPosition position) => (CS_0024_003C_003E8__locals28.k9X != null && CS_0024_003C_003E8__locals28.k9X.TryGetValue(position, out var value)) ? CS_0024_003C_003E8__locals28.p9K[value] : new TextPositionRange(position);
			CS_0024_003C_003E8__locals28.c9f.G9c.DeleteSelectedText(TextChangeTypes.Delete, editorViewTextChangeOptions);
		}
	}

	internal static bool HSM()
	{
		return gSj == null;
	}

	internal static BackspaceToPreviousWordAction uS3()
	{
		return gSj;
	}
}
