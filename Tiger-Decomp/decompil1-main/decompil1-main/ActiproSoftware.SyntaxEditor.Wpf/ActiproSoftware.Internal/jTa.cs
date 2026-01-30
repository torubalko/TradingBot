using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Internal;

internal class jTa : ICollapsedRegionManager
{
	[Flags]
	private enum z7F
	{

	}

	private class z7n
	{
		private z7F nrr;

		internal static z7n kju;

		internal bool erB(z7F P_0)
		{
			return (nrr & P_0) == P_0;
		}

		internal void orV(z7F P_0, bool P_1)
		{
			if (!P_1)
			{
				nrr &= ~P_0;
			}
			else
			{
				nrr |= P_0;
			}
		}

		public z7n()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool Kj8()
		{
			return kju == null;
		}

		internal static z7n BjU()
		{
			return kju;
		}
	}

	[DefaultMember("Item")]
	public class n7Y
	{
		private List<ITextVersionRange> Tr2;

		internal static n7Y Sje;

		public int Count => Tr2.Count;

		public int rrs(TextSnapshotOffset P_0)
		{
			int num = 0;
			int num2 = Tr2.Count - 1;
			while (num <= num2)
			{
				int num3 = (num + num2) / 2;
				TextSnapshotRange textSnapshotRange = ((Tr2[num3].Document == P_0.Snapshot.Document) ? Tr2[num3].Translate(P_0.Snapshot) : TextSnapshotRange.Deleted);
				if (textSnapshotRange.IsDeleted)
				{
					Tr2.RemoveAt(num3);
					num2--;
					continue;
				}
				if (textSnapshotRange.Contains(P_0.Offset))
				{
					return num3;
				}
				if (textSnapshotRange.EndOffset > P_0.Offset)
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
				if (Tr2[num2].Translate(P_0.Snapshot).EndOffset > P_0.Offset)
				{
					return ~num2;
				}
				return ~(num2 + 1);
			}
			return -1;
		}

		public TextSnapshotRange Ark(TextSnapshotRange P_0, NormalizedTextSnapshotRangeCollection P_1)
		{
			int num = int.MaxValue;
			int num2 = 0;
			P_0 = new TextSnapshotRange(P_0.Snapshot, Math.Min(P_0.StartOffset, (P_1.Count > 0) ? P_1[0].StartOffset : P_0.StartOffset), Math.Max(P_0.EndOffset, (P_1.Count > 0) ? P_1[P_1.Count - 1].EndOffset : P_0.EndOffset));
			int num3 = rrs(new TextSnapshotOffset(P_0.Snapshot, P_0.StartOffset));
			if (num3 < 0)
			{
				num3 = ~num3;
			}
			int num4 = 0;
			while (num3 < Tr2.Count && num4 < P_1.Count)
			{
				TextSnapshotRange textSnapshotRange = Tr2[num3].Translate(P_0.Snapshot);
				TextSnapshotRange textSnapshotRange2 = P_1[num4];
				if (textSnapshotRange.IsDeleted)
				{
					Tr2.RemoveAt(num3);
					continue;
				}
				if (textSnapshotRange.StartOffset >= P_0.EndOffset)
				{
					break;
				}
				if (textSnapshotRange.StartOffset == textSnapshotRange2.StartOffset)
				{
					if (textSnapshotRange.EndOffset == textSnapshotRange2.EndOffset)
					{
						num3++;
						num4++;
					}
					else if (textSnapshotRange.EndOffset < textSnapshotRange2.EndOffset)
					{
						num = Math.Min(num, textSnapshotRange.EndOffset);
						num2 = Math.Max(num2, textSnapshotRange2.EndOffset);
						Tr2.RemoveAt(num3);
					}
					else
					{
						num = Math.Min(num, textSnapshotRange2.EndOffset);
						num2 = Math.Max(num2, textSnapshotRange.EndOffset);
						Tr2.RemoveAt(num3);
					}
				}
				else if (textSnapshotRange.StartOffset < textSnapshotRange2.EndOffset)
				{
					num = Math.Min(num, textSnapshotRange.StartOffset);
					num2 = Math.Max(num2, textSnapshotRange.EndOffset);
					Tr2.RemoveAt(num3);
				}
				else
				{
					num = Math.Min(num, textSnapshotRange2.StartOffset);
					num2 = Math.Max(num2, textSnapshotRange2.EndOffset);
					num4++;
					Tr2.Insert(num3++, textSnapshotRange2.ToVersionRange(TextRangeTrackingModes.DeleteWhenZeroLength));
				}
			}
			while (num3 < Tr2.Count)
			{
				TextSnapshotRange textSnapshotRange3 = Tr2[num3].Translate(P_0.Snapshot);
				if (!textSnapshotRange3.IsDeleted && textSnapshotRange3.StartOffset >= P_0.EndOffset)
				{
					break;
				}
				if (!textSnapshotRange3.IsDeleted)
				{
					num = Math.Min(num, textSnapshotRange3.StartOffset);
					num2 = Math.Max(num2, textSnapshotRange3.EndOffset);
				}
				Tr2.RemoveAt(num3);
			}
			while (num4 < P_1.Count)
			{
				num = Math.Min(num, P_1[num4].StartOffset);
				num2 = Math.Max(num2, P_1[num4].EndOffset);
				Tr2.Insert(num3++, P_1[num4++].ToVersionRange(TextRangeTrackingModes.DeleteWhenZeroLength));
			}
			if (num != int.MaxValue)
			{
				return new TextSnapshotRange(P_0.Snapshot, num, num2);
			}
			return TextSnapshotRange.Deleted;
		}

		public void mrS()
		{
			Tr2.Clear();
		}

		[SpecialName]
		public ITextVersionRange ary(int P_0)
		{
			return Tr2[P_0];
		}

		public n7Y()
		{
			grA.DaB7cz();
			Tr2 = new List<ITextVersionRange>();
			base._002Ector();
		}

		internal static bool pjz()
		{
			return Sje == null;
		}

		internal static n7Y MMm()
		{
			return Sje;
		}
	}

	private int jYv;

	private n7Y MYm;

	private z7n cYC;

	private ITagAggregator<ICollapsedRegionTag> VYu;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<TextSnapshotRangeEventArgs> nY1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ITextView hYF;

	internal static jTa UA9;

	public event EventHandler<TextSnapshotRangeEventArgs> RegionsChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<TextSnapshotRangeEventArgs> eventHandler = nY1;
			EventHandler<TextSnapshotRangeEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<TextSnapshotRangeEventArgs> value2 = (EventHandler<TextSnapshotRangeEventArgs>)Delegate.Combine(eventHandler2, b);
				eventHandler = Interlocked.CompareExchange(ref nY1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<TextSnapshotRangeEventArgs> eventHandler = nY1;
			EventHandler<TextSnapshotRangeEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<TextSnapshotRangeEventArgs> value2 = (EventHandler<TextSnapshotRangeEventArgs>)Delegate.Remove(eventHandler2, value3);
				eventHandler = Interlocked.CompareExchange(ref nY1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public jTa(ITextView P_0)
	{
		grA.DaB7cz();
		MYm = new n7Y();
		cYC = new z7n();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		nYl(P_0);
		cYC.orV((z7F)1, _0020: true);
		VYu = P_0.CreateTagAggregator<ICollapsedRegionTag>();
		VYu.TagsChanged += HYf;
		P_0.SyntaxEditor.DocumentChanged += eYX;
		P_0.SyntaxEditor.DocumentTextChanged += nYK;
		FYg(P_0.CurrentSnapshot.SnapshotRange);
	}

	private void eYX(object P_0, EditorDocumentChangedEventArgs P_1)
	{
		MYm.mrS();
		if (P_1.NewValue != null)
		{
			FYg(P_1.NewValue.CurrentSnapshot.SnapshotRange);
		}
	}

	private void nYK(object P_0, EditorSnapshotChangedEventArgs P_1)
	{
		if (!P_1.ChangedSnapshotRange.IsDeleted)
		{
			FYg(P_1.ChangedSnapshotRange);
		}
	}

	private void HYf(object P_0, TagsChangedEventArgs P_1)
	{
		FYg(P_1.SnapshotRange);
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	private void jYD(object P_0, RoutedEventArgs P_1)
	{
		DYQ();
	}

	private void FYg(TextSnapshotRange P_0)
	{
		lock (MYm)
		{
			int num = 0;
			if (fAR() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			IEnumerable<TagSnapshotRange<ICollapsedRegionTag>> tags = VYu.GetTags(new NormalizedTextSnapshotRangeCollection(P_0), rYe());
			List<TextSnapshotRange> list = new List<TextSnapshotRange>();
			if (tags != null)
			{
				foreach (TagSnapshotRange<ICollapsedRegionTag> item in tags)
				{
					if (!item.SnapshotRange.IsZeroLength)
					{
						list.Add(item.SnapshotRange);
					}
				}
			}
			NormalizedTextSnapshotRangeCollection normalizedTextSnapshotRangeCollection = new NormalizedTextSnapshotRangeCollection(list, mergeSequentialRanges: false);
			TextSnapshotRange snapshotRange = MYm.Ark(P_0, normalizedTextSnapshotRangeCollection);
			if (!snapshotRange.IsDeleted)
			{
				b8U(new TextSnapshotRangeEventArgs(snapshotRange));
			}
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	public void DYQ()
	{
		if (cYC.erB((z7F)1))
		{
			cYC.orV((z7F)1, _0020: false);
			OnClosed();
		}
	}

	public TextSnapshotRange GetCollapsedRange(TextSnapshotOffset P_0)
	{
		bool flag = false;
		if (!cYC.erB((z7F)1))
		{
			return TextSnapshotRange.Deleted;
		}
		lock (MYm)
		{
			if (MYm.Count > 0)
			{
				if (jYv < MYm.Count && MYm.ary(jYv).Document == P_0.Snapshot.Document)
				{
					TextSnapshotRange result = MYm.ary(jYv).Translate(P_0.Snapshot);
					if (result.Contains(P_0.Offset))
					{
						return result;
					}
				}
				int num = MYm.rrs(P_0);
				if (num >= 0)
				{
					jYv = num;
					return MYm.ary(num).Translate(P_0.Snapshot);
				}
			}
		}
		return TextSnapshotRange.Deleted;
	}

	public NormalizedTextSnapshotRangeCollection GetCollapsedRanges(TextSnapshotRange P_0)
	{
		bool flag = false;
		if (!cYC.erB((z7F)1))
		{
			return null;
		}
		lock (MYm)
		{
			if (MYm.Count > 0)
			{
				int i = MYm.rrs(new TextSnapshotOffset(P_0.Snapshot, P_0.StartOffset));
				if (i < 0)
				{
					i = ~i;
				}
				if (i < MYm.Count)
				{
					List<TextSnapshotRange> list = null;
					for (; i < MYm.Count; i++)
					{
						TextSnapshotRange item = MYm.ary(i).Translate(P_0.Snapshot);
						if (!item.IsDeleted)
						{
							if (!item.OverlapsWith(P_0))
							{
								break;
							}
							if (list == null)
							{
								list = new List<TextSnapshotRange>();
							}
							list.Add(item);
						}
					}
					if (list != null)
					{
						return new NormalizedTextSnapshotRangeCollection(list, mergeSequentialRanges: false);
					}
				}
			}
		}
		return null;
	}

	public int GetVisibleOffset(TextSnapshotOffset P_0, bool P_1)
	{
		bool flag = false;
		int result = P_0.Offset;
		TextSnapshotRange collapsedRange = GetCollapsedRange(P_0);
		if (!collapsedRange.IsDeleted)
		{
			int num = 0;
			if (fAR() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			result = (P_1 ? collapsedRange.EndOffset : collapsedRange.StartOffset);
		}
		return result;
	}

	protected virtual void OnClosed()
	{
		rYe().SyntaxEditor.DocumentTextChanged -= nYK;
		rYe().SyntaxEditor.DocumentChanged -= eYX;
		VYu.TagsChanged -= HYf;
		VYu.Dispose();
	}

	protected virtual void b8U(TextSnapshotRangeEventArgs P_0)
	{
		nY1?.Invoke(this, P_0);
	}

	[SpecialName]
	[CompilerGenerated]
	public ITextView rYe()
	{
		return hYF;
	}

	[SpecialName]
	[CompilerGenerated]
	private void nYl(ITextView P_0)
	{
		hYF = P_0;
	}

	internal static bool PAJ()
	{
		return UA9 == null;
	}

	internal static jTa fAR()
	{
		return UA9;
	}
}
