using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Tagging.Implementation;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Internal;

internal class SF : CollectionTagger<Xx>, ITagger<IClassificationTag>, IOrderable, IKeyedObject
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

		public SF _003C_003E4__this;

		private IEnumerator<TagSnapshotRange<Xx>> _003C_003Es__1;

		private TagSnapshotRange<Xx> _003CtagRange_003E5__2;

		internal static _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIClassificationTag_003E_002DGetTags_003Ed__1 Yjm;

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
			try
			{
				int num = _003C_003E1__state;
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_00ae;
					}
					_003C_003E1__state = -3;
					_003CtagRange_003E5__2 = null;
				}
				else
				{
					_003C_003E1__state = -1;
					_003C_003Es__1 = _003C_003E4__this.GetTags(snapshotRanges, parameter).GetEnumerator();
					_003C_003E1__state = -3;
				}
				if (!_003C_003Es__1.MoveNext())
				{
					_003C_003Em__Finally1();
					_003C_003Es__1 = null;
					int num2 = 0;
					if (!Gjp())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					case 1:
						break;
					default:
						return false;
					}
					goto IL_00ae;
				}
				_003CtagRange_003E5__2 = _003C_003Es__1.Current;
				_003C_003E2__current = new TagSnapshotRange<IClassificationTag>(_003CtagRange_003E5__2.SnapshotRange, _003CtagRange_003E5__2.Tag);
				_003C_003E1__state = 1;
				return true;
				IL_00ae:
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

		internal static bool Gjp()
		{
			return Yjm == null;
		}

		internal static _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIClassificationTag_003E_002DGetTags_003Ed__1 lj4()
		{
			return Yjm;
		}
	}

	private static SF Mx8;

	public SF(ICodeDocument P_0)
	{
		grA.DaB7cz();
		base._002Ector(Q7Z.tqM(12422), (IEnumerable<Ordering>)null, P_0, isForLanguage: true);
	}

	IEnumerable<TagSnapshotRange<IClassificationTag>> ITagger<IClassificationTag>.GetTags(NormalizedTextSnapshotRangeCollection P_0, object P_1)
	{
		foreach (TagSnapshotRange<Xx> tagRange in GetTags(P_0, P_1))
		{
			yield return new TagSnapshotRange<IClassificationTag>(tagRange.SnapshotRange, tagRange.Tag);
		}
		int num = 0;
		if (!_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIClassificationTag_003E_002DGetTags_003Ed__1.Gjp())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 1:
			break;
		}
	}

	public void lC9(TagsChangedEventArgs P_0)
	{
		OnTagsChanged(P_0);
	}

	internal static bool ixU()
	{
		return Mx8 == null;
	}

	internal static SF xxe()
	{
		return Mx8;
	}
}
