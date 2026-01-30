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
public abstract class IndicatorClassificationTaggerBase<TTag> : IndicatorTaggerBase<TTag>, ITagger<IClassificationTag>, IOrderable, IKeyedObject where TTag : class, IIndicatorTag, IClassificationTag
{
	[CompilerGenerated]
	private sealed class _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIClassificationTag_003E_002DGetTags_003Ed__1 : IEnumerable<TagSnapshotRange<IClassificationTag>>, IEnumerable, IEnumerator<TagSnapshotRange<IClassificationTag>>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private TagSnapshotRange<IClassificationTag> _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private NormalizedTextSnapshotRangeCollection snapshotRanges;

		public NormalizedTextSnapshotRangeCollection _003C_003E3__snapshotRanges;

		private object parameter;

		public object _003C_003E3__parameter;

		public IndicatorClassificationTaggerBase<TTag> _003C_003E4__this;

		private IEnumerator<TagSnapshotRange<TTag>> _003C_003Es__1;

		private TagSnapshotRange<TTag> _003CtagRange_003E5__2;

		private static object YfH;

		TagSnapshotRange<IClassificationTag> IEnumerator<TagSnapshotRange<IClassificationTag>>.Current
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
		public _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIClassificationTag_003E_002DGetTags_003Ed__1(int _003C_003E1__state)
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
				switch (_003C_003E1__state)
				{
				case 0:
					_003C_003E1__state = -1;
					_003C_003Es__1 = _003C_003E4__this.GetTags(snapshotRanges, parameter).GetEnumerator();
					_003C_003E1__state = -3;
					break;
				default:
					result = false;
					goto end_IL_0009;
				case 1:
					_003C_003E1__state = -3;
					_003CtagRange_003E5__2 = null;
					break;
				}
				int num;
				if (!_003C_003Es__1.MoveNext())
				{
					_003C_003Em__Finally1();
					_003C_003Es__1 = null;
					num = 1;
					if (BfM() != null)
					{
						goto IL_0016;
					}
					goto IL_001a;
				}
				_003CtagRange_003E5__2 = _003C_003Es__1.Current;
				_003C_003E2__current = new TagSnapshotRange<IClassificationTag>(new TextSnapshotRange(_003CtagRange_003E5__2.SnapshotRange.Snapshot, _003CtagRange_003E5__2.SnapshotRange.StartOffset, _003CtagRange_003E5__2.SnapshotRange.EndOffset), _003CtagRange_003E5__2.Tag);
				_003C_003E1__state = 1;
				result = true;
				goto end_IL_0009;
				IL_001a:
				while (true)
				{
					switch (num)
					{
					case 1:
						goto IL_00d7;
					case 0:
						break;
					}
					break;
					IL_00d7:
					result = false;
					num = 0;
					if (Ifj())
					{
						continue;
					}
					goto IL_0016;
				}
				goto end_IL_0009;
				IL_0016:
				int num2 = default(int);
				num = num2;
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
		IEnumerator<TagSnapshotRange<IClassificationTag>> IEnumerable<TagSnapshotRange<IClassificationTag>>.GetEnumerator()
		{
			_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIClassificationTag_003E_002DGetTags_003Ed__1 _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIClassificationTag_003E_002DGetTags_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIClassificationTag_003E_002DGetTags_003Ed__ = this;
			}
			else
			{
				_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIClassificationTag_003E_002DGetTags_003Ed__ = new _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIClassificationTag_003E_002DGetTags_003Ed__1(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIClassificationTag_003E_002DGetTags_003Ed__.snapshotRanges = _003C_003E3__snapshotRanges;
			_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIClassificationTag_003E_002DGetTags_003Ed__.parameter = _003C_003E3__parameter;
			return _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIClassificationTag_003E_002DGetTags_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<TagSnapshotRange<IClassificationTag>>)this).GetEnumerator();
		}

		internal static bool Ifj()
		{
			return YfH == null;
		}

		internal static object BfM()
		{
			return YfH;
		}
	}

	protected IndicatorClassificationTaggerBase(string key, IEnumerable<Ordering> orderings, ICodeDocument document, bool isForLanguage)
	{
		grA.DaB7cz();
		base._002Ector(key, orderings, document, isForLanguage);
	}

	IEnumerable<TagSnapshotRange<IClassificationTag>> ITagger<IClassificationTag>.GetTags(NormalizedTextSnapshotRangeCollection snapshotRanges, object parameter)
	{
		foreach (TagSnapshotRange<TTag> tagRange in GetTags(snapshotRanges, parameter))
		{
			yield return new TagSnapshotRange<IClassificationTag>(new TextSnapshotRange(tagRange.SnapshotRange.Snapshot, tagRange.SnapshotRange.StartOffset, tagRange.SnapshotRange.EndOffset), tagRange.Tag);
		}
		int num = 1;
		if (_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIClassificationTag_003E_002DGetTags_003Ed__1.BfM() != null)
		{
			goto IL_0016;
		}
		goto IL_001a;
		IL_001a:
		do
		{
			switch (num)
			{
			default:
				yield break;
			case 0:
				yield break;
			case 1:
				break;
			}
			num = 0;
		}
		while (_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIClassificationTag_003E_002DGetTags_003Ed__1.Ifj());
		goto IL_0016;
		IL_0016:
		int num2 = default(int);
		num = num2;
		goto IL_001a;
	}
}
