using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

internal class DynamicLexicalScopeCollection : SimpleObservableCollection<DynamicLexicalScope>, IDynamicLexicalScopeCollection, IObservableCollection<DynamicLexicalScope>, IList<DynamicLexicalScope>, ICollection<DynamicLexicalScope>, IEnumerable<DynamicLexicalScope>, IEnumerable, ILexicalScopeCollection, IList<ILexicalScope>, ICollection<ILexicalScope>, IEnumerable<ILexicalScope>
{
	[CompilerGenerated]
	private sealed class _003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CActiproSoftware_002DText_002DLexing_002DILexicalScope_003E_002DGetEnumerator_003Ed__11 : IEnumerator<ILexicalScope>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ILexicalScope _003C_003E2__current;

		public DynamicLexicalScopeCollection _003C_003E4__this;

		private int _003Cindex_003E5__1;

		internal static _003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CActiproSoftware_002DText_002DLexing_002DILexicalScope_003E_002DGetEnumerator_003Ed__11 Afo;

		ILexicalScope IEnumerator<ILexicalScope>.Current
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
		public _003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CActiproSoftware_002DText_002DLexing_002DILexicalScope_003E_002DGetEnumerator_003Ed__11(int _003C_003E1__state)
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			if (num != 0)
			{
				int num3 = default(int);
				while (true)
				{
					if (num != 1)
					{
						return false;
					}
					_003C_003E1__state = -1;
					int num2 = 0;
					if (!SfI())
					{
						num2 = num3;
					}
					switch (num2)
					{
					case 1:
						continue;
					}
					break;
				}
				_003Cindex_003E5__1++;
			}
			else
			{
				_003C_003E1__state = -1;
				_003Cindex_003E5__1 = 0;
			}
			if (_003Cindex_003E5__1 >= _003C_003E4__this.Count)
			{
				return false;
			}
			_003C_003E2__current = _003C_003E4__this[_003Cindex_003E5__1];
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		internal static bool SfI()
		{
			return Afo == null;
		}

		internal static _003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CActiproSoftware_002DText_002DLexing_002DILexicalScope_003E_002DGetEnumerator_003Ed__11 KfH()
		{
			return Afo;
		}
	}

	private DynamicLexicalState d2h;

	private static DynamicLexicalScopeCollection R5m;

	int ICollection<ILexicalScope>.Count => base.Count;

	bool ICollection<ILexicalScope>.IsReadOnly => false;

	ILexicalScope IList<ILexicalScope>.this[int index]
	{
		get
		{
			return base[index];
		}
		set
		{
			base[index] = (DynamicLexicalScope)value;
		}
	}

	public DynamicLexicalScopeCollection(DynamicLexicalState parentLexicalState)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		d2h = parentLexicalState;
	}

	void ICollection<ILexicalScope>.Add(ILexicalScope item)
	{
		Add((DynamicLexicalScope)item);
	}

	void ICollection<ILexicalScope>.Clear()
	{
		Clear();
	}

	bool ICollection<ILexicalScope>.Contains(ILexicalScope item)
	{
		return Contains((DynamicLexicalScope)item);
	}

	void ICollection<ILexicalScope>.CopyTo(ILexicalScope[] array, int arrayIndex)
	{
		if (array != null)
		{
			DynamicLexicalScope[] array2 = new DynamicLexicalScope[array.Length];
			CopyTo(array2, arrayIndex);
			Array.Copy(array2, array, array.Length);
			return;
		}
		throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8132));
	}

	bool ICollection<ILexicalScope>.Remove(ILexicalScope item)
	{
		return Remove((DynamicLexicalScope)item);
	}

	IEnumerator<ILexicalScope> IEnumerable<ILexicalScope>.GetEnumerator()
	{
		int num2 = default(int);
		for (int index = 0; index < base.Count; index++)
		{
			yield return base[index];
			while (true)
			{
				int num = 0;
				if (!_003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CActiproSoftware_002DText_002DLexing_002DILexicalScope_003E_002DGetEnumerator_003Ed__11.SfI())
				{
					num = num2;
				}
				switch (num)
				{
				case 1:
					break;
				default:
					goto end_IL_00c4;
				}
				int num3;
				if (num3 == 1)
				{
					continue;
				}
				yield break;
				continue;
				end_IL_00c4:
				break;
			}
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		for (int index = 0; index < base.Count; index++)
		{
			yield return base[index];
		}
	}

	int IList<ILexicalScope>.IndexOf(ILexicalScope item)
	{
		return IndexOf((DynamicLexicalScope)item);
	}

	void IList<ILexicalScope>.Insert(int index, ILexicalScope item)
	{
		Insert(index, (DynamicLexicalScope)item);
	}

	void IList<ILexicalScope>.RemoveAt(int index)
	{
		RemoveAt(index);
	}

	protected override void OnItemAdded(int index, DynamicLexicalScope value)
	{
		base.OnItemAdded(index, value);
		if (d2h != null && value != null)
		{
			value.LexicalState = d2h;
		}
	}

	protected override void OnItemRemoving(int index, DynamicLexicalScope value)
	{
		base.OnItemRemoving(index, value);
		if (d2h != null && value != null && value.LexicalState == d2h)
		{
			value.LexicalState = null;
		}
	}

	[SpecialName]
	bool ICollection<DynamicLexicalScope>.get_IsReadOnly()
	{
		return IsReadOnly;
	}

	internal static bool b5S()
	{
		return R5m == null;
	}

	internal static DynamicLexicalScopeCollection B5B()
	{
		return R5m;
	}
}
