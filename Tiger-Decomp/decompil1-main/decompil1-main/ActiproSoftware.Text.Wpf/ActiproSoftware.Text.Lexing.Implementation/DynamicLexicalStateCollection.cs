using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

internal class DynamicLexicalStateCollection : KeyedObservableCollection<DynamicLexicalState>, IDynamicLexicalStateCollection, IKeyedObservableCollection<DynamicLexicalState>, IObservableCollection<DynamicLexicalState>, IList<DynamicLexicalState>, ICollection<DynamicLexicalState>, IEnumerable<DynamicLexicalState>, IEnumerable, ILexicalStateCollection, IList<ILexicalState>, ICollection<ILexicalState>, IEnumerable<ILexicalState>
{
	private IDynamicLexer w2P;

	internal static DynamicLexicalStateCollection gPt;

	int ICollection<ILexicalState>.Count => base.Count;

	bool ICollection<ILexicalState>.IsReadOnly => false;

	ILexicalState IList<ILexicalState>.this[int index]
	{
		get
		{
			return base[index];
		}
		set
		{
			base[index] = (DynamicLexicalState)value;
		}
	}

	public DynamicLexicalStateCollection(IDynamicLexer parentLexer)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		w2P = parentLexer;
	}

	void ICollection<ILexicalState>.Add(ILexicalState item)
	{
		Add((DynamicLexicalState)item);
	}

	void ICollection<ILexicalState>.Clear()
	{
		Clear();
	}

	bool ICollection<ILexicalState>.Contains(ILexicalState item)
	{
		return Contains((DynamicLexicalState)item);
	}

	void ICollection<ILexicalState>.CopyTo(ILexicalState[] array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8132));
		}
		DynamicLexicalState[] array2 = new DynamicLexicalState[array.Length];
		CopyTo(array2, arrayIndex);
		Array.Copy(array2, array, array.Length);
	}

	bool ICollection<ILexicalState>.Remove(ILexicalState item)
	{
		return Remove((DynamicLexicalState)item);
	}

	IEnumerator<ILexicalState> IEnumerable<ILexicalState>.GetEnumerator()
	{
		int index = 0;
		if (index < base.Count)
		{
			yield return base[index];
			/*Error: Unable to find new state assignment for yield return*/;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		for (int index = 0; index < base.Count; index++)
		{
			yield return base[index];
		}
	}

	int IList<ILexicalState>.IndexOf(ILexicalState item)
	{
		return IndexOf((DynamicLexicalState)item);
	}

	void IList<ILexicalState>.Insert(int index, ILexicalState item)
	{
		Insert(index, (DynamicLexicalState)item);
	}

	void IList<ILexicalState>.RemoveAt(int index)
	{
		RemoveAt(index);
	}

	protected override void OnItemAdded(int index, DynamicLexicalState value)
	{
		base.OnItemAdded(index, value);
		if (w2P != null && value != null)
		{
			value.Lexer = w2P;
		}
	}

	protected override void OnItemRemoving(int index, DynamicLexicalState value)
	{
		base.OnItemRemoving(index, value);
		if (w2P != null && value != null && value.Lexer == w2P)
		{
			value.Lexer = null;
		}
	}

	[SpecialName]
	bool ICollection<DynamicLexicalState>.get_IsReadOnly()
	{
		return IsReadOnly;
	}

	internal static bool uPW()
	{
		return gPt == null;
	}

	internal static DynamicLexicalStateCollection ePn()
	{
		return gPt;
	}
}
