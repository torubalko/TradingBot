using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

internal class SingleTextPositionRangeSnapshot : ITextPositionRangeCollection, IEnumerable<TextPositionRange>, IEnumerable
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__6 : IEnumerator<TextPositionRange>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private TextPositionRange _003C_003E2__current;

		public SingleTextPositionRangeSnapshot _003C_003E4__this;

		private static _003CGetEnumerator_003Ed__6 HMU;

		TextPositionRange IEnumerator<TextPositionRange>.Current
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
		public _003CGetEnumerator_003Ed__6(int _003C_003E1__state)
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
			int num = 1;
			int num3 = default(int);
			while (true)
			{
				int num2 = num;
				do
				{
					switch (num2)
					{
					default:
						switch (num3)
						{
						default:
							return false;
						case 0:
							_003C_003E1__state = -1;
							_003C_003E2__current = _003C_003E4__this.JcH;
							_003C_003E1__state = 1;
							return true;
						case 1:
							_003C_003E1__state = -1;
							return false;
						}
					case 1:
						break;
					}
					num3 = _003C_003E1__state;
					num2 = 0;
				}
				while (VM2());
			}
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

		internal static bool VM2()
		{
			return HMU == null;
		}

		internal static _003CGetEnumerator_003Ed__6 LMq()
		{
			return HMU;
		}
	}

	private TextPositionRange JcH;

	internal static SingleTextPositionRangeSnapshot LUJ;

	public int Count => 1;

	public virtual bool IsBlock => false;

	public TextPositionRange Primary => JcH;

	public int PrimaryIndex => 0;

	public TextPositionRange this[int index]
	{
		get
		{
			if (index != 0)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5502));
			}
			return JcH;
		}
	}

	public SingleTextPositionRangeSnapshot(TextPositionRange positionRange)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		JcH = positionRange;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public int BinarySearch(TextPosition value)
	{
		if (value < JcH.FirstPosition)
		{
			return -1;
		}
		if (value == JcH.FirstPosition || value < JcH.LastPosition)
		{
			return 0;
		}
		return -2;
	}

	public IEnumerator<TextPositionRange> GetEnumerator()
	{
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 1;
			while (true)
			{
				IL_000e:
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						goto IL_005e;
					}
					break;
					IL_005e:
					num3 = num4;
					num2 = 0;
					if (!_003CGetEnumerator_003Ed__6.VM2())
					{
						goto IL_000e;
					}
				}
				break;
			}
			switch (num3)
			{
			default:
				yield break;
			case 0:
				yield return JcH;
				break;
			}
		}
	}

	internal static bool lUy()
	{
		return LUJ == null;
	}

	internal static SingleTextPositionRangeSnapshot KUF()
	{
		return LUJ;
	}
}
