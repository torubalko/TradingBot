using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Tagging.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public abstract class IndicatorTaggerBase<TTag> : CollectionTagger<TTag>, ITagger<IIndicatorTag>, IOrderable, IKeyedObject where TTag : class, IIndicatorTag
{
	[CompilerGenerated]
	private sealed class _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIndicatorTag_003E_002DGetTags_003Ed__1 : IEnumerable<TagSnapshotRange<IIndicatorTag>>, IEnumerable, IEnumerator<TagSnapshotRange<IIndicatorTag>>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private TagSnapshotRange<IIndicatorTag> _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private NormalizedTextSnapshotRangeCollection snapshotRanges;

		public NormalizedTextSnapshotRangeCollection _003C_003E3__snapshotRanges;

		private object parameter;

		public object _003C_003E3__parameter;

		public IndicatorTaggerBase<TTag> _003C_003E4__this;

		private IEnumerator<TagSnapshotRange<TTag>> _003C_003Es__1;

		private TagSnapshotRange<TTag> _003CtagRange_003E5__2;

		internal static object If3;

		TagSnapshotRange<IIndicatorTag> IEnumerator<TagSnapshotRange<IIndicatorTag>>.Current
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
		public _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIndicatorTag_003E_002DGetTags_003Ed__1(int _003C_003E1__state)
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
					_003C_003Es__1 = _003C_003E4__this.GetTags(snapshotRanges, parameter).GetEnumerator();
					int num2 = 0;
					if (!pfv())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					case 1:
						break;
					default:
						goto IL_0180;
					}
				}
				else if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -3;
				_003CtagRange_003E5__2 = null;
				goto IL_004a;
				IL_0180:
				_003C_003E1__state = -3;
				goto IL_004a;
				IL_004a:
				if (_003C_003Es__1.MoveNext())
				{
					_003CtagRange_003E5__2 = _003C_003Es__1.Current;
					_003C_003E2__current = new TagSnapshotRange<IIndicatorTag>(new TextSnapshotRange(_003CtagRange_003E5__2.SnapshotRange.Snapshot, _003CtagRange_003E5__2.SnapshotRange.StartOffset, _003CtagRange_003E5__2.SnapshotRange.EndOffset), _003CtagRange_003E5__2.Tag);
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003Em__Finally1();
				_003C_003Es__1 = null;
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
		IEnumerator<TagSnapshotRange<IIndicatorTag>> IEnumerable<TagSnapshotRange<IIndicatorTag>>.GetEnumerator()
		{
			_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIndicatorTag_003E_002DGetTags_003Ed__1 _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIndicatorTag_003E_002DGetTags_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIndicatorTag_003E_002DGetTags_003Ed__ = this;
			}
			else
			{
				_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIndicatorTag_003E_002DGetTags_003Ed__ = new _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIndicatorTag_003E_002DGetTags_003Ed__1(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIndicatorTag_003E_002DGetTags_003Ed__.snapshotRanges = _003C_003E3__snapshotRanges;
			_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIndicatorTag_003E_002DGetTags_003Ed__.parameter = _003C_003E3__parameter;
			return _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIndicatorTag_003E_002DGetTags_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<TagSnapshotRange<IIndicatorTag>>)this).GetEnumerator();
		}

		internal static bool pfv()
		{
			return If3 == null;
		}

		internal static object Rff()
		{
			return If3;
		}
	}

	private static object b5t;

	protected IndicatorTaggerBase(string key, IEnumerable<Ordering> orderings, ICodeDocument document, bool isForLanguage)
	{
		grA.DaB7cz();
		base._002Ector(key, orderings, document, isForLanguage);
	}

	IEnumerable<TagSnapshotRange<IIndicatorTag>> ITagger<IIndicatorTag>.GetTags(NormalizedTextSnapshotRangeCollection snapshotRanges, object parameter)
	{
		IEnumerator<TagSnapshotRange<TTag>> enumerator = GetTags(snapshotRanges, parameter).GetEnumerator();
		int num = 0;
		if (!_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIndicatorTag_003E_002DGetTags_003Ed__1.pfv())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 1:
			goto IL_004a;
		}
		try
		{
			goto IL_004a;
			IL_004a:
			while (enumerator.MoveNext())
			{
				TagSnapshotRange<TTag> tagRange = enumerator.Current;
				TextSnapshotRange snapshotRange = tagRange.SnapshotRange;
				ITextSnapshot snapshot = snapshotRange.Snapshot;
				snapshotRange = tagRange.SnapshotRange;
				int startOffset = snapshotRange.StartOffset;
				snapshotRange = tagRange.SnapshotRange;
				yield return new TagSnapshotRange<IIndicatorTag>(new TextSnapshotRange(snapshot, startOffset, snapshotRange.EndOffset), tagRange.Tag);
			}
		}
		finally
		{
			enumerator?.Dispose();
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
	public void RaiseTagsChanged(TagsChangedEventArgs e)
	{
		OnTagsChanged(e);
	}

	internal static bool p5Y()
	{
		return b5t == null;
	}

	internal static object Q5b()
	{
		return b5t;
	}
}
