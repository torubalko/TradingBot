using System;
using System.Collections;
using System.Collections.Generic;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

public class LexicalScopeCollection : SimpleObservableCollection<LexicalScopeBase>, ILexicalScopeCollection, IList<ILexicalScope>, ICollection<ILexicalScope>, IEnumerable<ILexicalScope>, IEnumerable
{
	private ILexicalState x2Y;

	private static LexicalScopeCollection IPI;

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
			base[index] = (LexicalScopeBase)value;
		}
	}

	public LexicalScopeCollection(ILexicalState parentLexicalState)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		x2Y = parentLexicalState;
	}

	void ICollection<ILexicalScope>.Add(ILexicalScope item)
	{
		Add((LexicalScopeBase)item);
	}

	void ICollection<ILexicalScope>.Clear()
	{
		Clear();
	}

	bool ICollection<ILexicalScope>.Contains(ILexicalScope item)
	{
		return Contains((LexicalScopeBase)item);
	}

	void ICollection<ILexicalScope>.CopyTo(ILexicalScope[] array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8132));
		}
		LexicalScopeBase[] array2 = new LexicalScopeBase[array.Length];
		CopyTo(array2, arrayIndex);
		Array.Copy(array2, array, array.Length);
	}

	bool ICollection<ILexicalScope>.Remove(ILexicalScope item)
	{
		return Remove((LexicalScopeBase)item);
	}

	IEnumerator<ILexicalScope> IEnumerable<ILexicalScope>.GetEnumerator()
	{
		for (int index = 0; index < base.Count; index++)
		{
			yield return base[index];
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
		return IndexOf((LexicalScopeBase)item);
	}

	void IList<ILexicalScope>.Insert(int index, ILexicalScope item)
	{
		Insert(index, (LexicalScopeBase)item);
	}

	void IList<ILexicalScope>.RemoveAt(int index)
	{
		RemoveAt(index);
	}

	protected override void OnItemAdded(int index, LexicalScopeBase value)
	{
		base.OnItemAdded(index, value);
		if (x2Y != null && value != null)
		{
			value.LexicalStateCore = x2Y;
		}
	}

	protected override void OnItemRemoving(int index, LexicalScopeBase value)
	{
		base.OnItemRemoving(index, value);
		if (x2Y != null && value != null && value.LexicalStateCore == x2Y)
		{
			value.LexicalStateCore = null;
		}
	}

	internal static bool ePH()
	{
		return IPI == null;
	}

	internal static LexicalScopeCollection VP6()
	{
		return IPI;
	}
}
