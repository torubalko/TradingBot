using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

internal class MultipleTextPositionRangeSnapshot : ITextPositionRangeCollection, IEnumerable<TextPositionRange>, IEnumerable
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__7 : IEnumerator<TextPositionRange>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private TextPositionRange _003C_003E2__current;

		public MultipleTextPositionRangeSnapshot _003C_003E4__this;

		private TextPositionRange[] _003C_003Es__1;

		private int _003C_003Es__2;

		private TextPositionRange _003CpositionRange_003E5__3;

		internal static _003CGetEnumerator_003Ed__7 rM1;

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
		public _003CGetEnumerator_003Ed__7(int _003C_003E1__state)
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
			int num = 2;
			int num3 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						_003C_003Es__1 = _003C_003E4__this.Wcs;
						_003C_003Es__2 = 0;
						goto IL_0127;
					case 1:
						if (num3 != 0)
						{
							if (num3 == 1)
							{
								_003C_003E1__state = -1;
								_003C_003Es__2++;
								goto IL_0127;
							}
							return false;
						}
						_003C_003E1__state = -1;
						num2 = 0;
						if (QM5())
						{
							continue;
						}
						break;
					case 2:
						{
							num3 = _003C_003E1__state;
							num2 = 1;
							if (QM5())
							{
								continue;
							}
							break;
						}
						IL_0127:
						if (_003C_003Es__2 >= _003C_003Es__1.Length)
						{
							_003C_003Es__1 = null;
							return false;
						}
						_003CpositionRange_003E5__3 = _003C_003Es__1[_003C_003Es__2];
						_003C_003E2__current = _003CpositionRange_003E5__3;
						_003C_003E1__state = 1;
						return true;
					}
					break;
				}
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

		internal static bool QM5()
		{
			return rM1 == null;
		}

		internal static _003CGetEnumerator_003Ed__7 WMP()
		{
			return rM1;
		}
	}

	private TextPositionRange[] Wcs;

	private int ccI;

	internal static MultipleTextPositionRangeSnapshot yUx;

	public int Count => Wcs.Length;

	public bool IsBlock => false;

	public TextPositionRange Primary => this[ccI];

	public int PrimaryIndex => ccI;

	public TextPositionRange this[int index] => Wcs[index];

	public MultipleTextPositionRangeSnapshot(IEnumerable<TextPositionRange> positionRanges, int primaryIndex)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (positionRanges == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1424));
		}
		Wcs = positionRanges.ToArray();
		ccI = Math.Max(0, Math.Min(Wcs.Length - 1, primaryIndex));
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public int BinarySearch(TextPosition value)
	{
		int num = 0;
		int num2 = Wcs.Length - 1;
		while (num <= num2)
		{
			int num3 = (num + num2) / 2;
			TextPositionRange textPositionRange = Wcs[num3];
			if (textPositionRange.Contains(value) || textPositionRange.FirstPosition == value)
			{
				return num3;
			}
			if (textPositionRange.LastPosition > value)
			{
				num2 = num3 - 1;
			}
			else
			{
				num = num3 + 1;
			}
		}
		if (num2 >= 0)
		{
			if (Wcs[num2].LastPosition > value)
			{
				return ~num2;
			}
			return ~(num2 + 1);
		}
		return -1;
	}

	public IEnumerator<TextPositionRange> GetEnumerator()
	{
		TextPositionRange[] wcs = default(TextPositionRange[]);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = 2;
			while (true)
			{
				int num2 = num;
				do
				{
					IL_0012:
					switch (num2)
					{
					case 1:
						goto IL_0080;
					case 2:
						goto IL_010a;
					}
					wcs = Wcs;
					num3 = 0;
					goto IL_0127;
					IL_010a:
					num4 = num5;
					num2 = 1;
					continue;
					IL_0080:
					if (num4 != 0)
					{
						if (num4 != 1)
						{
							yield break;
						}
						num3++;
						goto IL_0127;
					}
					num2 = 0;
					if (!_003CGetEnumerator_003Ed__7.QM5())
					{
						break;
					}
					goto IL_0012;
					IL_0127:
					if (num3 < wcs.Length)
					{
						goto end_IL_000e;
					}
					yield break;
				}
				while (_003CGetEnumerator_003Ed__7.QM5());
				continue;
				end_IL_000e:
				break;
			}
			yield return wcs[num3];
		}
	}

	internal static bool pUT()
	{
		return yUx == null;
	}

	internal static MultipleTextPositionRangeSnapshot eUk()
	{
		return yUx;
	}
}
