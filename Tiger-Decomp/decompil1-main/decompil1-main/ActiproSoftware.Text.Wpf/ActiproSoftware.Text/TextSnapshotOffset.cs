using System;
using System.Collections.Generic;
using ActiproSoftware.Products.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text;

public struct TextSnapshotOffset : ITextRangeProvider
{
	private ITextSnapshot sVP;

	private int WVp;

	internal static object Ttl;

	TextRange ITextRangeProvider.TextRange
	{
		get
		{
			return new TextRange(WVp);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public int Column
	{
		get
		{
			int num = 1;
			ITextBufferReader bufferReader = default(ITextBufferReader);
			int tabSize = default(int);
			int num4 = default(int);
			while (true)
			{
				int num2 = num;
				do
				{
					IL_0012:
					switch (num2)
					{
					case 2:
						while (bufferReader.Offset < WVp)
						{
							char c = bufferReader.Read();
							char c2 = c;
							char c3 = c2;
							if (c3 == '\t')
							{
								int num3 = tabSize - num4 % tabSize;
								num4 += num3;
							}
							else
							{
								num4++;
							}
						}
						goto IL_004f;
					case 1:
						break;
					default:
						{
							if (!IsDeleted)
							{
								tabSize = sVP.Document.TabSize;
								bufferReader = sVP.GetReader(Line.StartOffset).BufferReader;
								num2 = 2;
								if (LtI() != null)
								{
									num2 = 2;
								}
								goto IL_0012;
							}
							goto IL_004f;
						}
						IL_004f:
						return num4;
					}
					num4 = 0;
					num2 = 0;
				}
				while (LtI() == null);
			}
		}
	}

	public static TextSnapshotOffset Deleted => new TextSnapshotOffset(null);

	public bool IsDeleted => sVP == null || WVp < 0;

	public ITextSnapshotLine Line
	{
		get
		{
			int num = sVP.Lines.IndexOf(WVp);
			return (num != -1) ? sVP.Lines[num] : null;
		}
	}

	public int Offset => WVp;

	public TextPosition Position => sVP.OffsetToPosition(WVp);

	public ITextSnapshot Snapshot => sVP;

	private TextSnapshotOffset(ITextSnapshot snapshot)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		sVP = snapshot;
		WVp = -1;
	}

	public TextSnapshotOffset(ITextSnapshot snapshot, int offset)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		if (snapshot == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1676));
		}
		sVP = snapshot;
		WVp = Math.Max(0, Math.Min(snapshot.Length, offset));
	}

	internal static int Translate(ITextVersion fromVersion, ITextVersion toVersion, int offset, TextOffsetTrackingMode trackingMode, bool boundsCheck)
	{
		if (fromVersion == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1520));
		}
		if (toVersion != null)
		{
			if (fromVersion.Document != toVersion.Document)
			{
				throw new ArgumentException(SR.GetString(SRName.ExTextVersionDocumentMismatch));
			}
			int num;
			if (fromVersion != toVersion)
			{
				num = ((fromVersion.Number > toVersion.Number) ? AVw(fromVersion, toVersion, offset, trackingMode) : uVH(fromVersion, toVersion, offset, trackingMode));
			}
			else
			{
				int num2 = 1;
				if (LtI() != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				default:
				{
					int result = default(int);
					return result;
				}
				case 1:
					break;
				}
				num = offset;
			}
			if (!boundsCheck)
			{
				return num;
			}
			return Math.Max(0, Math.Min(toVersion.Length, num));
		}
		throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1546));
	}

	private static int AVw(ITextVersion P_0, ITextVersion P_1, int P_2, TextOffsetTrackingMode P_3)
	{
		int num = P_2;
		Stack<ITextVersion> stack = new Stack<ITextVersion>();
		ITextVersion textVersion = P_1;
		while (textVersion != null && textVersion != P_0)
		{
			stack.Push(textVersion);
			textVersion = textVersion.Next;
		}
		while (stack.Count > 0)
		{
			ITextVersion textVersion2 = stack.Pop();
			IList<ITextChangeRangedOperation> operations = textVersion2.Operations;
			if (operations == null)
			{
				continue;
			}
			for (int num2 = operations.Count - 1; num2 >= 0; num2--)
			{
				ITextChangeRangedOperation textChangeRangedOperation = operations[num2];
				if (P_3 == TextOffsetTrackingMode.Positive)
				{
					if (textChangeRangedOperation.StartOffset <= num)
					{
						num = ((textChangeRangedOperation.InsertionEndOffset > num) ? textChangeRangedOperation.DeletionEndOffset : (num - textChangeRangedOperation.LengthDelta));
					}
				}
				else if (textChangeRangedOperation.StartOffset < num)
				{
					num = ((textChangeRangedOperation.InsertionEndOffset >= num) ? textChangeRangedOperation.StartOffset : (num - textChangeRangedOperation.LengthDelta));
				}
			}
		}
		return num;
	}

	private static int uVH(ITextVersion P_0, ITextVersion P_1, int P_2, TextOffsetTrackingMode P_3)
	{
		int num = P_2;
		ITextVersion textVersion = P_0;
		while (textVersion != null && textVersion != P_1)
		{
			IList<ITextChangeRangedOperation> operations = textVersion.Operations;
			if (operations != null)
			{
				foreach (ITextChangeRangedOperation item in operations)
				{
					if (P_3 == TextOffsetTrackingMode.Positive)
					{
						if (item.StartOffset <= num)
						{
							num = ((item.DeletionEndOffset > num) ? item.InsertionEndOffset : (num + item.LengthDelta));
						}
					}
					else if (item.StartOffset < num)
					{
						num = ((item.DeletionEndOffset >= num) ? item.StartOffset : (num + item.LengthDelta));
					}
				}
			}
			textVersion = textVersion.Next;
		}
		return num;
	}

	public int CompareTo(int value)
	{
		return WVp.CompareTo(value);
	}

	public int CompareTo(TextSnapshotOffset snapshotOffset)
	{
		if (sVP != null)
		{
			return WVp.CompareTo(snapshotOffset.TranslateTo(sVP, TextOffsetTrackingMode.Negative).Offset);
		}
		return WVp.CompareTo(snapshotOffset.WVp);
	}

	public override bool Equals(object obj)
	{
		if (obj == null || !(obj is TextSnapshotOffset))
		{
			return false;
		}
		TextSnapshotOffset textSnapshotOffset = (TextSnapshotOffset)obj;
		return sVP == textSnapshotOffset.sVP && WVp == textSnapshotOffset.WVp;
	}

	public override int GetHashCode()
	{
		return ((sVP != null) ? sVP.GetHashCode() : 0) ^ WVp.GetHashCode();
	}

	public override string ToString()
	{
		if (IsDeleted)
		{
			return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1696);
		}
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1718) + sVP.Version.Number + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1732) + WVp + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
	}

	public TextSnapshotOffset TranslateTo(ITextSnapshot toSnapshot, TextOffsetTrackingMode trackingMode)
	{
		if (IsDeleted)
		{
			return this;
		}
		if (toSnapshot == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1652));
		}
		return new TextSnapshotOffset(toSnapshot, Translate(sVP.Version, toSnapshot.Version, WVp, trackingMode, boundsCheck: true));
	}

	public static implicit operator int(TextSnapshotOffset snapshotOffset)
	{
		return snapshotOffset.WVp;
	}

	public static bool operator ==(TextSnapshotOffset left, TextSnapshotOffset right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(TextSnapshotOffset left, TextSnapshotOffset right)
	{
		return !(left == right);
	}

	public static bool operator <(TextSnapshotOffset left, TextSnapshotOffset right)
	{
		return left.CompareTo(right) < 0;
	}

	public static bool operator >(TextSnapshotOffset left, TextSnapshotOffset right)
	{
		return left.CompareTo(right) > 0;
	}

	internal static bool Ato()
	{
		return Ttl == null;
	}

	internal static object LtI()
	{
		return Ttl;
	}
}
