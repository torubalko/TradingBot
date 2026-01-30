using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

public class LexicalStateCollection : KeyedObservableCollection<LexicalStateBase>, ILexicalStateCollection, IList<ILexicalState>, ICollection<ILexicalState>, IEnumerable<ILexicalState>, IEnumerable
{
	[CompilerGenerated]
	private sealed class _003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CActiproSoftware_002DText_002DLexing_002DILexicalState_003E_002DGetEnumerator_003Ed__11 : IEnumerator<ILexicalState>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ILexicalState _003C_003E2__current;

		public LexicalStateCollection _003C_003E4__this;

		private int _003Cindex_003E5__1;

		internal static _003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CActiproSoftware_002DText_002DLexing_002DILexicalState_003E_002DGetEnumerator_003Ed__11 ife;

		ILexicalState IEnumerator<ILexicalState>.Current
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
		public _003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CActiproSoftware_002DText_002DLexing_002DILexicalState_003E_002DGetEnumerator_003Ed__11(int _003C_003E1__state)
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
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				int num2 = _003Cindex_003E5__1;
				int num3 = 0;
				if (!Bfg())
				{
					int num4 = default(int);
					num3 = num4;
				}
				switch (num3)
				{
				}
				_003Cindex_003E5__1 = num2 + 1;
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

		internal static bool Bfg()
		{
			return ife == null;
		}

		internal static _003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CActiproSoftware_002DText_002DLexing_002DILexicalState_003E_002DGetEnumerator_003Ed__11 Yfp()
		{
			return ife;
		}
	}

	private ILexer t2G;

	internal static LexicalStateCollection qPC;

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
			base[index] = (LexicalStateBase)value;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
	public LexicalStateCollection(ILexer parentLexer)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		t2G = parentLexer;
	}

	void ICollection<ILexicalState>.Add(ILexicalState item)
	{
		Add((LexicalStateBase)item);
	}

	void ICollection<ILexicalState>.Clear()
	{
		Clear();
	}

	bool ICollection<ILexicalState>.Contains(ILexicalState item)
	{
		return Contains((LexicalStateBase)item);
	}

	void ICollection<ILexicalState>.CopyTo(ILexicalState[] array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8132));
		}
		LexicalStateBase[] array2 = new LexicalStateBase[array.Length];
		CopyTo(array2, arrayIndex);
		Array.Copy(array2, array, array.Length);
	}

	bool ICollection<ILexicalState>.Remove(ILexicalState item)
	{
		return Remove((LexicalStateBase)item);
	}

	IEnumerator<ILexicalState> IEnumerable<ILexicalState>.GetEnumerator()
	{
		int index = 0;
		int num3 = default(int);
		while (index < base.Count)
		{
			yield return base[index];
			int num = index;
			int num2 = 0;
			if (!_003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CActiproSoftware_002DText_002DLexing_002DILexicalState_003E_002DGetEnumerator_003Ed__11.Bfg())
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
			index = num + 1;
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
		return IndexOf((LexicalStateBase)item);
	}

	void IList<ILexicalState>.Insert(int index, ILexicalState item)
	{
		Insert(index, (LexicalStateBase)item);
	}

	void IList<ILexicalState>.RemoveAt(int index)
	{
		RemoveAt(index);
	}

	internal static IEnumerable<ILexicalStateTransition> GetAllLexicalStateTransitions(IEnumerable<ILexicalState> lexicalStates)
	{
		if (lexicalStates == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(18244));
		}
		foreach (ILexicalState lexicalState in lexicalStates)
		{
			if (lexicalState == null)
			{
				continue;
			}
			if (lexicalState.Transition != null)
			{
				yield return lexicalState.Transition;
			}
			if (lexicalState.LexicalScopes == null)
			{
				continue;
			}
			foreach (ILexicalScope lexicalScope in lexicalState.LexicalScopes)
			{
				if (lexicalScope != null && lexicalScope.Transition != null)
				{
					yield return lexicalScope.Transition;
				}
			}
		}
	}

	public IEnumerable<ILexicalStateTransition> GetAllLexicalStateTransitions()
	{
		return GetAllLexicalStateTransitions(this);
	}

	protected override void OnItemAdded(int index, LexicalStateBase value)
	{
		base.OnItemAdded(index, value);
		if (t2G != null && value != null)
		{
			value.LexerCore = t2G;
		}
	}

	protected override void OnItemRemoving(int index, LexicalStateBase value)
	{
		base.OnItemRemoving(index, value);
		if (t2G != null && value != null && value.LexerCore == t2G)
		{
			value.LexerCore = null;
		}
	}

	internal static bool hPw()
	{
		return qPC == null;
	}

	internal static LexicalStateCollection WPa()
	{
		return qPC;
	}
}
