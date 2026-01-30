using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Undo;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Internal;

internal class DAp : ITextViewLine, ITextRangeProvider
{
	[CompilerGenerated]
	private sealed class _003CGetBackgroundBorderRuns_003Ed__23 : IEnumerable<CAM>, IEnumerable, IEnumerator<CAM>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private CAM _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public DAp _003C_003E4__this;

		private IList<CAM> _003CbackgroundBorderRuns_003E5__1;

		private IEnumerator<CAM> _003C_003Es__2;

		private CAM _003Crun_003E5__3;

		private TextRange _003CtextRange_003E5__4;

		internal static _003CGetBackgroundBorderRuns_003Ed__23 fME;

		CAM IEnumerator<CAM>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CGetBackgroundBorderRuns_003Ed__23(int _003C_003E1__state)
		{
			grA.DaB7cz();
			base._002Ector();
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num != -3 && num != 1)
			{
				return;
			}
			try
			{
			}
			finally
			{
				_003C_003Em__Finally1();
			}
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				int num2;
				if (num == 0)
				{
					_003C_003E1__state = -1;
					num2 = 1;
					if (!PMw())
					{
						num2 = 1;
					}
					goto IL_001a;
				}
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -3;
				goto IL_0118;
				IL_0140:
				if (!_003C_003Es__2.MoveNext())
				{
					_003C_003Em__Finally1();
					_003C_003Es__2 = null;
					goto IL_0088;
				}
				_003Crun_003E5__3 = _003C_003Es__2.Current;
				_003CtextRange_003E5__4 = _003Crun_003E5__3.iHf();
				if (_003CtextRange_003E5__4.StartOffset < _003C_003E4__this.EndOffsetIncludingLineTerminator && _003CtextRange_003E5__4.EndOffset > _003C_003E4__this.StartOffset)
				{
					num2 = 0;
					if (!PMw())
					{
						num2 = 0;
					}
					goto IL_001a;
				}
				goto IL_0118;
				IL_001a:
				int num3 = default(int);
				while (true)
				{
					switch (num2)
					{
					case 2:
						break;
					default:
						_003C_003E2__current = _003Crun_003E5__3;
						_003C_003E1__state = 1;
						return true;
					case 1:
						_003CbackgroundBorderRuns_003E5__1 = _003C_003E4__this.nb5.i6t();
						num2 = 2;
						if (pMu() != null)
						{
							num2 = num3;
						}
						continue;
					}
					break;
				}
				if (_003CbackgroundBorderRuns_003E5__1 == null)
				{
					goto IL_0088;
				}
				_003C_003Es__2 = _003CbackgroundBorderRuns_003E5__1.GetEnumerator();
				_003C_003E1__state = -3;
				goto IL_0140;
				IL_0118:
				_003CtextRange_003E5__4 = default(TextRange);
				_003Crun_003E5__3 = null;
				goto IL_0140;
				IL_0088:
				return false;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003Es__2 != null)
			{
				_003C_003Es__2.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<CAM> IEnumerable<CAM>.GetEnumerator()
		{
			_003CGetBackgroundBorderRuns_003Ed__23 result;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				result = this;
			}
			else
			{
				result = new _003CGetBackgroundBorderRuns_003Ed__23(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			return result;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<CAM>)this).GetEnumerator();
		}

		internal static bool PMw()
		{
			return fME == null;
		}

		internal static _003CGetBackgroundBorderRuns_003Ed__23 pMu()
		{
			return fME;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetIntraLineSpacerTags_003Ed__66<TTag> : IEnumerable<TagSnapshotRange<TTag>>, IEnumerable, IEnumerator<TagSnapshotRange<TTag>>, IDisposable, IEnumerator where TTag : IIntraLineSpacerTag
	{
		private int _003C_003E1__state;

		private TagSnapshotRange<TTag> _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public DAp _003C_003E4__this;

		private IEnumerator<TagSnapshotRange<IIntraLineSpacerTag>> _003C_003Es__1;

		private TagSnapshotRange<IIntraLineSpacerTag> _003CintraLineSpacerTagRange_003E5__2;

		internal static object MM8;

		TagSnapshotRange<TTag> IEnumerator<TagSnapshotRange<TTag>>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CGetIntraLineSpacerTags_003Ed__66(int _003C_003E1__state)
		{
			grA.DaB7cz();
			base._002Ector();
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num != -3 && num != 1)
			{
				return;
			}
			try
			{
			}
			finally
			{
				_003C_003Em__Finally1();
			}
		}

		private bool MoveNext()
		{
			bool result = default(bool);
			try
			{
				int num = _003C_003E1__state;
				if (num == 0)
				{
					_003C_003E1__state = -1;
					if (_003C_003E4__this.Yb8 == null)
					{
						goto IL_0049;
					}
					_003C_003Es__1 = _003C_003E4__this.Yb8.GetEnumerator();
					_003C_003E1__state = -3;
					goto IL_00dc;
				}
				if (num == 1)
				{
					_003C_003E1__state = -3;
					goto IL_00bf;
				}
				result = false;
				goto end_IL_0009;
				IL_0016:
				int num3 = default(int);
				int num2 = num3;
				goto IL_001a;
				IL_0049:
				result = false;
				num2 = 0;
				if (!cMU())
				{
					goto IL_0016;
				}
				goto IL_001a;
				IL_001a:
				switch (num2)
				{
				default:
					goto end_IL_0009;
				case 2:
					break;
				case 1:
					goto end_IL_0009;
				case 0:
					goto end_IL_0009;
				}
				goto IL_00dc;
				IL_00dc:
				if (!_003C_003Es__1.MoveNext())
				{
					_003C_003Em__Finally1();
					_003C_003Es__1 = null;
					goto IL_0049;
				}
				_003CintraLineSpacerTagRange_003E5__2 = _003C_003Es__1.Current;
				if (_003CintraLineSpacerTagRange_003E5__2.Tag.GetType() == typeof(TTag))
				{
					_003C_003E2__current = new TagSnapshotRange<TTag>(_003CintraLineSpacerTagRange_003E5__2.SnapshotRange, (TTag)_003CintraLineSpacerTagRange_003E5__2.Tag);
					_003C_003E1__state = 1;
					result = true;
					num2 = 1;
					if (oMe() != null)
					{
						goto IL_0016;
					}
					goto IL_001a;
				}
				goto IL_00bf;
				IL_00bf:
				_003CintraLineSpacerTagRange_003E5__2 = null;
				num2 = 2;
				if (oMe() != null)
				{
					goto IL_0016;
				}
				goto IL_001a;
				end_IL_0009:;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003Es__1 != null)
			{
				_003C_003Es__1.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<TagSnapshotRange<TTag>> IEnumerable<TagSnapshotRange<TTag>>.GetEnumerator()
		{
			_003CGetIntraLineSpacerTags_003Ed__66<TTag> result;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				result = this;
			}
			else
			{
				result = new _003CGetIntraLineSpacerTags_003Ed__66<TTag>(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			return result;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<TagSnapshotRange<TTag>>)this).GetEnumerator();
		}

		internal static bool cMU()
		{
			return MM8 == null;
		}

		internal static object oMe()
		{
			return MM8;
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_VisibleSnapshotRanges_003Ed__139 : IEnumerable<TextSnapshotRange>, IEnumerable, IEnumerator<TextSnapshotRange>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private TextSnapshotRange _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public DAp _003C_003E4__this;

		private TextRange _003CtextRange_003E5__1;

		private IEnumerator<TextRange> _003C_003Es__2;

		private TextRange _003CvisibleTextRange_003E5__3;

		internal static _003Cget_VisibleSnapshotRanges_003Ed__139 y3q;

		TextSnapshotRange IEnumerator<TextSnapshotRange>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003Cget_VisibleSnapshotRanges_003Ed__139(int _003C_003E1__state)
		{
			grA.DaB7cz();
			base._002Ector();
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num != -3 && num != 1)
			{
				return;
			}
			try
			{
			}
			finally
			{
				_003C_003Em__Finally1();
			}
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				if (num == 0)
				{
					_003C_003E1__state = -1;
					if (_003C_003E4__this.nbq == null)
					{
						_003CtextRange_003E5__1 = _003C_003E4__this.TextRangeIncludingLineTerminator;
						_003C_003Es__2 = _003C_003E4__this.nb5.j6d().GetEnumerator();
						_003C_003E1__state = -3;
						goto IL_012d;
					}
					goto IL_022e;
				}
				int num3 = default(int);
				while (true)
				{
					IL_0201:
					if (num == 1)
					{
						while (true)
						{
							_003C_003E1__state = -3;
							int num2 = 1;
							if (!B3x())
							{
								num2 = num3;
							}
							switch (num2)
							{
							case 1:
								goto end_IL_00a0;
							case 2:
								goto IL_0201;
							}
							continue;
							end_IL_00a0:
							break;
						}
						break;
					}
					return false;
				}
				goto IL_00f0;
				IL_012d:
				if (!_003C_003Es__2.MoveNext())
				{
					_003C_003Em__Finally1();
					_003C_003Es__2 = null;
					_003CtextRange_003E5__1 = default(TextRange);
					goto IL_022e;
				}
				_003CvisibleTextRange_003E5__3 = _003C_003Es__2.Current;
				if (_003CvisibleTextRange_003E5__3.IntersectsWith(_003CtextRange_003E5__1))
				{
					_003C_003E2__current = new TextSnapshotRange(_003C_003E4__this.Dbr, Math.Max(_003CvisibleTextRange_003E5__3.StartOffset, _003CtextRange_003E5__1.StartOffset), Math.Min(_003CvisibleTextRange_003E5__3.EndOffset, _003CtextRange_003E5__1.EndOffset));
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_00f0;
				IL_00f0:
				_003CvisibleTextRange_003E5__3 = default(TextRange);
				goto IL_012d;
				IL_022e:
				return false;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003Es__2 != null)
			{
				_003C_003Es__2.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<TextSnapshotRange> IEnumerable<TextSnapshotRange>.GetEnumerator()
		{
			_003Cget_VisibleSnapshotRanges_003Ed__139 result;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				result = this;
			}
			else
			{
				result = new _003Cget_VisibleSnapshotRanges_003Ed__139(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			return result;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<TextSnapshotRange>)this).GetEnumerator();
		}

		internal static bool B3x()
		{
			return y3q == null;
		}

		internal static _003Cget_VisibleSnapshotRanges_003Ed__139 G3a()
		{
			return y3q;
		}
	}

	private Rect? Lb6;

	private TextViewLineChange xbH;

	private int ebb;

	private TextPosition wbT;

	private int? AbL;

	private int? Dbn;

	private IList<TagSnapshotRange<IIntraLineSpacerTag>> Yb8;

	private bool? qbI;

	private QAR nb5;

	private ITextLayoutLine ib0;

	private int cbB;

	private Thickness QbV;

	private ITextSnapshot Dbr;

	private int lbs;

	private TextPosition qbk;

	private double WbS;

	private ITextView ub9;

	private double Jby;

	private IEnumerable<TextSnapshotRange> nbq;

	private TextPosition Ub2;

	private TextViewLineVisibility Sb7;

	private static DAp WWF;

	public double Baseline => ib0.Baseline;

	public double BottomMargin => QbV.Bottom;

	public Rect Bounds
	{
		get
		{
			if (!Lb6.HasValue)
			{
				Lb6 = new Rect(0.0, Tb4(), QbV.Left + ib0.Width + QbV.Right, QbV.Top + ib0.Height + QbV.Bottom);
			}
			return Lb6.Value;
		}
	}

	public TextViewLineChange Change
	{
		get
		{
			return xbH;
		}
		internal set
		{
			xbH = textViewLineChange;
			if (xbH == TextViewLineChange.None)
			{
				WbS = 0.0;
			}
			else
			{
				Lb6 = null;
			}
		}
	}

	public int CharacterCount => ib0.CharacterCount - (ib0.HasHardLineBreak ? 1 : 0);

	public int EndOffset => ebb - (ib0.HasHardLineBreak ? 1 : 0);

	public int EndOffsetIncludingLineTerminator => ebb;

	public TextPosition EndPosition
	{
		get
		{
			if (wbT.IsEmpty)
			{
				wbT = Dbr.OffsetToPosition(EndOffset);
			}
			return wbT;
		}
	}

	public TextPosition EndPositionIncludingLineTerminator
	{
		get
		{
			TextPosition endPosition = EndPosition;
			if (ib0.HasHardLineBreak)
			{
				return new TextPosition(endPosition.Line, endPosition.Character + 1);
			}
			return endPosition;
		}
	}

	public int FirstNonWhitespaceCharacterIndex
	{
		get
		{
			if (!AbL.HasValue)
			{
				Lazy<ITextBufferReader> lazy = new Lazy<ITextBufferReader>(() => Dbr.GetReader(0).BufferReader);
				ITextBufferReader textBufferReader = null;
				AbL = nb5.R6O(lazy, ref textBufferReader, cbB) - ib0.StartCharacterIndex;
			}
			return AbL.Value;
		}
	}

	public int FirstNonWhitespaceOffset => CharacterIndexToOffset(FirstNonWhitespaceCharacterIndex);

	public bool HasHardLineBreak => ib0.HasHardLineBreak;

	public int IndentAmount
	{
		get
		{
			if (!Dbn.HasValue)
			{
				int num = CharacterIndexToOffset(FirstNonWhitespaceCharacterIndex);
				Dbn = GetCharacterColumn(num);
			}
			return Dbn.Value;
		}
	}

	public bool IsFirstLine => StartOffset == 0;

	public bool IsLastLine => EndOffset == Dbr.Length;

	public bool IsPureWhitespace
	{
		get
		{
			if (!qbI.HasValue)
			{
				qbI = FirstNonWhitespaceCharacterIndex >= CharacterCount;
			}
			return qbI.Value;
		}
	}

	public bool IsVirtualLine => false;

	public bool IsWrapped => cbB > 0;

	public TextPosition MaxPosition
	{
		get
		{
			int num = 1;
			int num2 = num;
			TextPosition endPosition = default(TextPosition);
			while (true)
			{
				switch (num2)
				{
				default:
					if (HasHardLineBreak || IsLastLine)
					{
						return new TextPosition(endPosition.Line, int.MaxValue);
					}
					return endPosition;
				case 1:
					endPosition = EndPosition;
					num2 = 0;
					if (bWJ() == null)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ITextViewLine NextLine => View.GetViewLine(this, 1);

	public TextPositionRange PositionRange => new TextPositionRange(StartPosition, EndPosition);

	public ITextViewLine PreviousLine => View.GetViewLine(this, -1);

	public SavePointChangeType SavePointChangeType => ub9.SyntaxEditor.Document.UndoHistory.GetChangeTypeForLineRange(StartPosition.Line, EndPosition.Line);

	public Size Size => new Size(QbV.Left + ib0.Width + QbV.Right, QbV.Top + ib0.Height + QbV.Bottom);

	public TextSnapshotRange SnapshotRange => new TextSnapshotRange(Dbr, TextRange);

	public TextSnapshotRange SnapshotRangeIncludingLineTerminator => new TextSnapshotRange(Dbr, TextRangeIncludingLineTerminator);

	public int StartOffset => lbs;

	public TextPosition StartPosition
	{
		get
		{
			if (qbk.IsEmpty)
			{
				qbk = new TextPosition(Dbr.OffsetToPosition(StartOffset), hasFarAffinity: true);
			}
			return qbk;
		}
	}

	public int TabStopLevel
	{
		get
		{
			int num = Math.Max(1, View.SyntaxEditor.Document.TabSize);
			return IndentAmount / num;
		}
		set
		{
			int num = Math.Max(0, val);
			string insertText = (View.SyntaxEditor.Document.AutoConvertTabsToSpaces ? new string(' ', View.SyntaxEditor.Document.TabSize * num) : new string('\t', num));
			ITextChange textChange = View.CurrentSnapshot.CreateTextChange(TextChangeTypes.AutoIndent, new EditorViewTextChangeOptions(View)
			{
				RetainSelection = true
			});
			textChange.ReplaceText(new TextRange(StartOffset, FirstNonWhitespaceOffset), insertText);
			textChange.Apply();
		}
	}

	public string Text
	{
		get
		{
			return ub9.CurrentSnapshot.GetSubstring(TextRange, LineTerminator.Newline);
		}
		set
		{
			ub9.SyntaxEditor.Document.ReplaceText(TextChangeTypes.TextReplacement, TextRange, text);
		}
	}

	public Rect TextBounds => new Rect(QbV.Left, Tb4() + QbV.Top, ib0.Width, ib0.Height);

	public TextRange TextRange
	{
		get
		{
			return new TextRange(StartOffset, EndOffset);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public TextRange TextRangeIncludingLineTerminator => new TextRange(StartOffset, EndOffsetIncludingLineTerminator);

	public Size TextSize => new Size(ib0.Width, ib0.Height);

	public double TopMargin => QbV.Top;

	public double TranslationY => WbS;

	public ITextView View => ub9;

	public TextViewLineVisibility Visibility
	{
		get
		{
			return Sb7;
		}
		internal set
		{
			Sb7 = sb;
		}
	}

	public IEnumerable<TextSnapshotRange> VisibleSnapshotRanges
	{
		get
		{
			if (nbq != null)
			{
				yield break;
			}
			TextRange textRange = TextRangeIncludingLineTerminator;
			int num2 = default(int);
			foreach (TextRange visibleTextRange in nb5.j6d())
			{
				if (!visibleTextRange.IntersectsWith(textRange))
				{
					continue;
				}
				yield return new TextSnapshotRange(Dbr, Math.Max(visibleTextRange.StartOffset, textRange.StartOffset), Math.Min(visibleTextRange.EndOffset, textRange.EndOffset));
				while (true)
				{
					int num = 1;
					if (!_003Cget_VisibleSnapshotRanges_003Ed__139.B3x())
					{
						num = num2;
					}
					switch (num)
					{
					default:
						continue;
					case 1:
						break;
					case 2:
					{
						int num3;
						if (num3 != 1)
						{
							yield break;
						}
						continue;
					}
					}
					break;
				}
			}
		}
	}

	public TextPosition VisibleStartPosition
	{
		get
		{
			int num = default(int);
			TagSnapshotRange<IIntraTextSpacerTag> intraTextSpacerTag = default(TagSnapshotRange<IIntraTextSpacerTag>);
			IIntraTextSpacerTag tag = default(IIntraTextSpacerTag);
			int num2;
			if (Ub2.IsEmpty)
			{
				num = 0;
				TextRange textRange = nb5.j6d().FirstOrDefault();
				if (StartOffset < textRange.StartOffset)
				{
					intraTextSpacerTag = GetIntraTextSpacerTag(0);
					if (intraTextSpacerTag != null)
					{
						tag = intraTextSpacerTag.Tag;
						if (tag != null)
						{
							num2 = 0;
							if (bWJ() != null)
							{
								num2 = 0;
							}
							goto IL_0009;
						}
					}
				}
				goto IL_0059;
			}
			goto IL_01a0;
			IL_0059:
			if (num <= 0)
			{
				Ub2 = StartPosition;
			}
			else
			{
				Ub2 = Dbr.OffsetToPosition(StartOffset + num);
			}
			goto IL_01a0;
			IL_01a0:
			TextPosition ub = Ub2;
			num2 = 1;
			if (bWJ() != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			goto IL_0009;
			IL_0009:
			switch (num2)
			{
			case 1:
				return ub;
			}
			if (tag.Key != null && tag.Size.Width == 0.0)
			{
				num = Math.Max(0, intraTextSpacerTag.SnapshotRange.EndOffset - StartOffset);
			}
			goto IL_0059;
		}
	}

	public int WordWrapIndex => cbB;

	public DAp(ITextView P_0, QAR P_1, int P_2)
	{
		grA.DaB7cz();
		xbH = TextViewLineChange.None;
		wbT = TextPosition.Empty;
		qbk = TextPosition.Empty;
		Ub2 = TextPosition.Empty;
		Sb7 = TextViewLineVisibility.Hidden;
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(194142));
		}
		if (P_2 < 0 || P_2 >= P_1.Lines.Count)
		{
			throw new ArgumentOutOfRangeException(Q7Z.tqM(194158));
		}
		ub9 = P_0;
		nb5 = P_1;
		cbB = P_2;
		ib0 = P_1.Lines[P_2];
		Dbr = P_0.CurrentSnapshot;
		ITextProvider textProvider = P_1.TextProvider;
		lbs = textProvider.Translate(ib0.StartCharacterIndex, TextProviderTranslateModes.ToSourceText);
		ebb = textProvider.Translate(ib0.StartCharacterIndex + ib0.CharacterCount, TextProviderTranslateModes.ToSourceText | TextProviderTranslateModes.PositiveTracking);
		rbe();
	}

	private void rbe()
	{
		IList<TagSnapshotRange<IIntraLineSpacerTag>> list = nb5.A6h();
		if (list == null)
		{
			return;
		}
		TextRange textRangeIncludingLineTerminator = TextRangeIncludingLineTerminator;
		foreach (TagSnapshotRange<IIntraLineSpacerTag> item in list)
		{
			IIntraLineSpacerTag intraLineSpacerTag = item?.Tag;
			if (intraLineSpacerTag == null)
			{
				continue;
			}
			bool flag = false;
			if (intraLineSpacerTag.TopMargin > 0.0 && textRangeIncludingLineTerminator.Contains(item.SnapshotRange.StartOffset))
			{
				QbV.Top = Math.Max(QbV.Top, intraLineSpacerTag.TopMargin);
				flag = true;
			}
			if (intraLineSpacerTag.BottomMargin > 0.0 && textRangeIncludingLineTerminator.Contains(item.SnapshotRange.EndOffset))
			{
				QbV.Bottom = Math.Max(QbV.Bottom, intraLineSpacerTag.BottomMargin);
				flag = true;
			}
			if (flag)
			{
				if (Yb8 == null)
				{
					Yb8 = new List<TagSnapshotRange<IIntraLineSpacerTag>>();
				}
				Yb8.Add(item);
			}
		}
	}

	internal IEnumerable<CAM> cbl()
	{
		int num = 1;
		if (!_003CGetBackgroundBorderRuns_003Ed__23.PMw())
		{
			num = 1;
		}
		IList<CAM> backgroundBorderRuns = default(IList<CAM>);
		CAM run = default(CAM);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 2:
			{
				if (backgroundBorderRuns == null)
				{
					yield break;
				}
				using (IEnumerator<CAM> enumerator = backgroundBorderRuns.GetEnumerator())
				{
					for (; enumerator.MoveNext(); run = null)
					{
						run = enumerator.Current;
						TextRange textRange = run.iHf();
						if (textRange.StartOffset < EndOffsetIncludingLineTerminator && textRange.EndOffset > StartOffset)
						{
							num = 0;
							if (!_003CGetBackgroundBorderRuns_003Ed__23.PMw())
							{
								num = 0;
							}
							goto end_IL_001a;
						}
						IL_0118:;
					}
				}
				yield break;
			}
			default:
				yield return run;
				goto IL_0118;
			case 1:
				{
					backgroundBorderRuns = nb5.i6t();
					num = 2;
					if (_003CGetBackgroundBorderRuns_003Ed__23.pMu() != null)
					{
						num = num2;
					}
					break;
				}
				end_IL_001a:
				break;
			}
		}
	}

	[SpecialName]
	internal QAR XbF()
	{
		return nb5;
	}

	[SpecialName]
	internal ITextLayoutLine pbR()
	{
		return ib0;
	}

	internal void rbA(ITextSnapshot P_0)
	{
		Dbr = P_0;
		wbT = TextPosition.Empty;
		qbk = TextPosition.Empty;
		nbq = null;
		Ub2 = TextPosition.Empty;
		nb5.V6U(P_0);
	}

	internal void pbv(double P_0, double P_1)
	{
		QbV.Left = P_0;
		QbV.Right = P_1;
		Lb6 = null;
	}

	internal void Nbm(double P_0, bool P_1)
	{
		double num = P_0 - Jby;
		if (!P_1)
		{
			WbS = num;
			int num2 = 0;
			if (bWJ() != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
		else
		{
			WbS += num;
		}
		if (num != 0.0)
		{
			Jby = P_0;
			if (Lb6.HasValue)
			{
				Rect value = Lb6.Value;
				value.Y = Jby;
				Lb6 = value;
			}
		}
	}

	internal void tbC(int P_0)
	{
		lbs += P_0;
		ebb += P_0;
		if (cbB == 0)
		{
			nb5.a6J(P_0);
		}
	}

	[SpecialName]
	internal double Tb4()
	{
		return Jby;
	}

	public int CharacterIndexToOffset(int P_0)
	{
		int characterIndex = ib0.StartCharacterIndex + Math.Max(0, Math.Min(CharacterCount, P_0));
		return nb5.TextProvider.Translate(characterIndex, TextProviderTranslateModes.ToSourceText);
	}

	public TextPosition CharacterIndexToPosition(int P_0)
	{
		TextPosition endPosition = EndPosition;
		int num = P_0 - CharacterCount;
		TextPosition result;
		if (num > 0)
		{
			result = new TextPosition(endPosition.Line, endPosition.Character + num);
		}
		else
		{
			int offset = CharacterIndexToOffset(P_0);
			result = ub9.OffsetToPosition(offset);
			int num2 = 0;
			if (bWJ() != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
		return result;
	}

	public override bool Equals(object P_0)
	{
		return P_0 is DAp dAp && ib0 == dAp.ib0 && cbB == dAp.cbB;
	}

	public TextBounds GetCharacterBounds(int P_0)
	{
		int characterIndex = ib0.StartCharacterIndex + OffsetToCharacterIndex(P_0);
		ITextBounds characterBounds = ib0.GetCharacterBounds(characterIndex, allowVirtualSpace: false);
		TextBounds result = new TextBounds(QbV.Left + characterBounds.X, Tb4() + QbV.Top + characterBounds.Y, characterBounds.Width, characterBounds.Height, characterBounds.IsRightToLeft);
		if (Visibility == TextViewLineVisibility.Hidden)
		{
			result.IsYValid = false;
		}
		return result;
	}

	public TextBounds GetCharacterBounds(TextPosition P_0)
	{
		int characterIndex = ib0.StartCharacterIndex + PositionToCharacterIndex(P_0);
		ITextBounds characterBounds = ib0.GetCharacterBounds(characterIndex, allowVirtualSpace: true);
		TextBounds result = new TextBounds(QbV.Left + characterBounds.X, Tb4() + QbV.Top + characterBounds.Y, characterBounds.Width, characterBounds.Height, characterBounds.IsRightToLeft);
		if (Visibility == TextViewLineVisibility.Hidden)
		{
			result.IsYValid = false;
		}
		return result;
	}

	public int GetCharacterColumn(int P_0)
	{
		double num = GetCharacterBounds(P_0).X - QbV.Left;
		return (int)Math.Round(num / Math.Max(1.0, nb5.SpaceWidth));
	}

	public int GetCharacterColumn(TextPosition P_0)
	{
		int num = GetCharacterColumn(ub9.PositionToOffset(P_0));
		if (P_0 > EndPosition)
		{
			num += P_0.Character - EndPosition.Character;
		}
		return num;
	}

	public int Qbu(Lazy<ITextBufferReader> P_0, ref ITextBufferReader P_1)
	{
		if (!AbL.HasValue)
		{
			AbL = nb5.R6O(P_0, ref P_1, cbB) - ib0.StartCharacterIndex;
		}
		return AbL.Value;
	}

	public override int GetHashCode()
	{
		return nb5.GetHashCode() ^ cbB.GetHashCode();
	}

	public IEnumerable<TagSnapshotRange<cAI>> GetIntraLineSpacerTags<cAI>() where cAI : IIntraLineSpacerTag
	{
		int num;
		if (Yb8 != null)
		{
			using IEnumerator<TagSnapshotRange<IIntraLineSpacerTag>> enumerator = Yb8.GetEnumerator();
			goto IL_00dc;
			IL_00dc:
			if (enumerator.MoveNext())
			{
				TagSnapshotRange<IIntraLineSpacerTag> intraLineSpacerTagRange = enumerator.Current;
				if (!(intraLineSpacerTagRange.Tag.GetType() == typeof(cAI)))
				{
					num = 2;
					if (_003CGetIntraLineSpacerTags_003Ed__66<cAI>.oMe() != null)
					{
						goto IL_0016;
					}
					goto IL_001a;
				}
				yield return new TagSnapshotRange<cAI>(intraLineSpacerTagRange.SnapshotRange, (cAI)intraLineSpacerTagRange.Tag);
				/*Error: Unable to find 'return true' for yield return*/;
			}
		}
		num = 0;
		if (!_003CGetIntraLineSpacerTags_003Ed__66<cAI>.cMU())
		{
			goto IL_0016;
		}
		goto IL_001a;
		IL_001a:
		switch (num)
		{
		default:
			/*Error near IL_0007: Unexpected return in MoveNext()*/;
		case 0:
			/*Error near IL_0007: Unexpected return in MoveNext()*/;
		case 1:
			/*Error near IL_0007: Unexpected return in MoveNext()*/;
		case 2:
			break;
		}
		goto IL_00dc;
		IL_0016:
		int num2 = default(int);
		num = num2;
		goto IL_001a;
	}

	public TextBounds GetIntraTextSpacerBounds(object P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(194192));
		}
		IList<ITextSpacer> spacers = nb5.Spacers;
		if (spacers != null)
		{
			int startCharacterIndex = ib0.StartCharacterIndex;
			int num = startCharacterIndex + CharacterCount;
			foreach (ITextSpacer item in spacers)
			{
				if (item.CharacterIndex >= startCharacterIndex && item.CharacterIndex < num && item.Key is TagSnapshotRange<IIntraTextSpacerTag> { Tag: { } tag } && tag.Key == P_0)
				{
					ITextBounds textBounds = ib0.GetTextBounds(item.CharacterIndex, 1, allowVirtualSpace: false).FirstOrDefault();
					if (textBounds != null)
					{
						Rect rect = textBounds.Rect;
						rect.X += QbV.Left;
						rect.Y = Tb4() + QbV.Top;
						return new TextBounds(rect, textBounds.IsRightToLeft);
					}
					break;
				}
			}
		}
		return ActiproSoftware.Windows.Controls.SyntaxEditor.TextBounds.Empty;
	}

	public TagSnapshotRange<IIntraTextSpacerTag> GetIntraTextSpacerTag(int P_0)
	{
		IList<ITextSpacer> spacers = nb5.Spacers;
		if (spacers != null)
		{
			int num = ib0.StartCharacterIndex + P_0;
			foreach (ITextSpacer item in spacers)
			{
				if (item.CharacterIndex == num && item.Key is TagSnapshotRange<IIntraTextSpacerTag> { Tag: { } } tagSnapshotRange)
				{
					return tagSnapshotRange;
				}
			}
		}
		return null;
	}

	public IEnumerable<TagSnapshotRange<cAx>> GetIntraTextSpacerTags<cAx>() where cAx : IIntraTextSpacerTag
	{
		IList<ITextSpacer> spacers = nb5.Spacers;
		if (spacers == null)
		{
			yield break;
		}
		int startLayoutCharacterIndex = ib0.StartCharacterIndex;
		int endLayoutCharacterIndex = startLayoutCharacterIndex + CharacterCount;
		foreach (ITextSpacer spacer in spacers)
		{
			if (spacer.CharacterIndex >= startLayoutCharacterIndex && spacer.CharacterIndex < endLayoutCharacterIndex && spacer.Key is TagSnapshotRange<IIntraTextSpacerTag> { Tag: var tag } tagRange && tag != null && tag.GetType() == typeof(cAx))
			{
				yield return new TagSnapshotRange<cAx>(tagRange.SnapshotRange, (cAx)tag);
			}
		}
	}

	public IEnumerable<TextBounds> GetTextBounds(TextRange P_0)
	{
		int startLayoutCharacterIndex = ib0.StartCharacterIndex + OffsetToCharacterIndex(P_0.FirstOffset);
		int endLayoutCharacterIndex = (P_0.IsZeroLength ? startLayoutCharacterIndex : (ib0.StartCharacterIndex + OffsetToCharacterIndex(P_0.LastOffset)));
		if (HasHardLineBreak && P_0.FirstOffset <= EndOffset && P_0.LastOffset >= EndOffsetIncludingLineTerminator)
		{
			endLayoutCharacterIndex++;
		}
		TextBounds? pendingTextBounds = null;
		foreach (ITextBounds textBounds in ib0.GetTextBounds(startLayoutCharacterIndex, endLayoutCharacterIndex - startLayoutCharacterIndex, allowVirtualSpace: true))
		{
			Rect rect = textBounds.Rect;
			rect.X += QbV.Left;
			rect.Y = Tb4() + QbV.Top;
			TextBounds resolvedTextBounds = new TextBounds(rect, textBounds.IsRightToLeft);
			if (Visibility == TextViewLineVisibility.Hidden)
			{
				resolvedTextBounds.IsYValid = false;
			}
			if (pendingTextBounds.HasValue)
			{
				if (pendingTextBounds.Value.X + pendingTextBounds.Value.Width != resolvedTextBounds.X || pendingTextBounds.Value.IsRightToLeft != resolvedTextBounds.IsRightToLeft)
				{
					yield return pendingTextBounds.Value;
					pendingTextBounds = null;
					continue;
				}
				Rect mergedRect = pendingTextBounds.Value.Rect;
				mergedRect.Width += resolvedTextBounds.Width;
				TextBounds mergedTextBounds = new TextBounds(mergedRect, resolvedTextBounds.IsRightToLeft);
				if (!resolvedTextBounds.IsYValid)
				{
					mergedTextBounds.IsYValid = false;
				}
				pendingTextBounds = mergedTextBounds;
			}
			else
			{
				pendingTextBounds = resolvedTextBounds;
			}
		}
		if (pendingTextBounds.HasValue)
		{
			yield return pendingTextBounds.Value;
		}
	}

	public IEnumerable<TextBounds> GetTextBounds(TextPositionRange P_0)
	{
		int startLayoutCharacterIndex = ib0.StartCharacterIndex + PositionToCharacterIndex(P_0.FirstPosition);
		int endLayoutCharacterIndex = (P_0.IsZeroLength ? startLayoutCharacterIndex : (ib0.StartCharacterIndex + PositionToCharacterIndex(P_0.LastPosition)));
		foreach (ITextBounds textBounds in ib0.GetTextBounds(startLayoutCharacterIndex, endLayoutCharacterIndex - startLayoutCharacterIndex, allowVirtualSpace: true))
		{
			Rect rect = textBounds.Rect;
			rect.X += QbV.Left;
			rect.Y = Tb4() + QbV.Top;
			TextBounds finalTextBounds = new TextBounds(rect, textBounds.IsRightToLeft);
			if (Visibility == TextViewLineVisibility.Hidden)
			{
				finalTextBounds.IsYValid = false;
			}
			yield return finalTextBounds;
		}
	}

	public bool IsVirtualCharacter(int P_0, bool P_1)
	{
		return P_0 >= ib0.CharacterCount - ((P_1 && ib0.HasHardLineBreak) ? 1 : 0);
	}

	public int LocationToCharacterIndex(double P_0, LocationToPositionAlgorithm P_1)
	{
		P_0 -= QbV.Left;
		int num = ib0.HitTest(new Point(P_0, ib0.Baseline));
		int num2;
		int num4;
		int result = default(int);
		int num5 = default(int);
		if (num == -1)
		{
			if ((uint)P_1 <= 1u)
			{
				if (!(P_0 < 0.0))
				{
					num2 = 0;
					if (bWJ() != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_0009;
				}
				num4 = 0;
				goto IL_0244;
			}
			result = -1;
		}
		else
		{
			num5 = num - ib0.StartCharacterIndex;
			if (P_1 == LocationToPositionAlgorithm.BestFit)
			{
				goto IL_008e;
			}
			if (P_1 == LocationToPositionAlgorithm.Absolute)
			{
				result = ((HasHardLineBreak || num5 < CharacterCount) ? num5 : (-1));
				num2 = 2;
				goto IL_0009;
			}
			result = num5;
		}
		goto IL_015f;
		IL_0009:
		switch (num2)
		{
		case 1:
			goto IL_008e;
		case 2:
			goto IL_015f;
		}
		num4 = CharacterCount;
		goto IL_0244;
		IL_008e:
		ITextBounds characterBounds = ib0.GetCharacterBounds(num, allowVirtualSpace: true);
		result = ((!(P_0 >= characterBounds.X + characterBounds.Width / 2.0)) ? (num5 + (characterBounds.IsRightToLeft ? 1 : 0)) : (num5 + ((!characterBounds.IsRightToLeft) ? 1 : 0)));
		goto IL_015f;
		IL_015f:
		return result;
		IL_0244:
		result = num4;
		goto IL_015f;
	}

	public int LocationToOffset(double P_0, LocationToPositionAlgorithm P_1)
	{
		int num = LocationToCharacterIndex(P_0, P_1);
		if (num == -1)
		{
			return -1;
		}
		return CharacterIndexToOffset(num);
	}

	public TextPosition LocationToPosition(double P_0, LocationToPositionAlgorithm P_1)
	{
		return LocationToPosition(P_0, P_1, _0020: false);
	}

	public TextPosition LocationToPosition(double P_0, LocationToPositionAlgorithm P_1, bool P_2)
	{
		if (P_2 || ub9.SyntaxEditor.IsVirtualSpaceAtLineEndEnabled)
		{
			Rect bounds = Bounds;
			if (P_0 >= bounds.Right)
			{
				double spaceWidth = nb5.SpaceWidth;
				int num = (int)((P_0 - bounds.Right + ((P_1 == LocationToPositionAlgorithm.BestFit) ? (spaceWidth / 2.0) : 0.0)) / spaceWidth);
				TextPosition endPosition = EndPosition;
				return new TextPosition(endPosition.Line, endPosition.Character + num);
			}
		}
		int num2 = LocationToOffset(P_0, P_1);
		if (num2 != -1)
		{
			TextPosition textPosition = ub9.OffsetToPosition(num2);
			return (num2 == StartOffset) ? new TextPosition(textPosition, hasFarAffinity: true) : textPosition;
		}
		return TextPosition.Empty;
	}

	public int OffsetToCharacterIndex(int P_0)
	{
		P_0 = Math.Max(StartOffset, Math.Min(EndOffset, P_0));
		int num = nb5.TextProvider.Translate(P_0, TextProviderTranslateModes.FromSourceText);
		return num - ib0.StartCharacterIndex;
	}

	public int PositionToCharacterIndex(TextPosition P_0)
	{
		TextPosition endPosition = EndPosition;
		int num = ((P_0 > endPosition) ? (P_0.Character - endPosition.Character) : 0);
		int num2 = ub9.PositionToOffset(P_0);
		return OffsetToCharacterIndex(num2) + num;
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, Q7Z.tqM(194208), new object[2] { VisibleStartPosition, TextRangeIncludingLineTerminator });
	}

	[CompilerGenerated]
	private ITextBufferReader Wb1()
	{
		return Dbr.GetReader(0).BufferReader;
	}

	internal static bool VW9()
	{
		return WWF == null;
	}

	internal static DAp bWJ()
	{
		return WWF;
	}
}
