using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Internal;

internal class DAN : Canvas, IAdornmentLayer, IKeyedObject, MTG, IOrderable
{
	private List<IAdornment> Hny;

	private AdornmentLayerDefinition Fnq;

	private ReadOnlyCollection<IAdornment> Yn2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ITextView nn7;

	private static DAN JOu;

	public ReadOnlyCollection<IAdornment> Adornments => Yn2;

	public string Key => Fnq.Key;

	public IEnumerable<Ordering> Orderings => Fnq.Orderings;

	public ITextView View
	{
		[CompilerGenerated]
		get
		{
			return nn7;
		}
		[CompilerGenerated]
		private set
		{
			nn7 = textView;
		}
	}

	public UIElement VisualElement => this;

	public DAN(ITextView P_0, AdornmentLayerDefinition P_1)
	{
		grA.DaB7cz();
		base._002Ector();
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(11988));
		}
		View = P_0;
		Fnq = P_1;
		Hny = new List<IAdornment>();
		Yn2 = new ReadOnlyCollection<IAdornment>(Hny);
	}

	private IAdornment Sns(AdornmentChangeReason P_0, UIElement P_1, DrawAdornmentCallback P_2, Point P_3, Size P_4, object P_5, ITextViewLine P_6, TextSnapshotRange? P_7, TextRangeTrackingModes? P_8, Action<IAdornment> P_9)
	{
		bool flag = true;
		if (P_7.HasValue && !View.CurrentSnapshot.TextRange.IntersectsWith(P_7.Value.TextRange))
		{
			flag = false;
		}
		if (flag)
		{
			IAdornment adornment2;
			if (P_1 == null)
			{
				IAdornment adornment = new LAm(P_2, P_4, P_5, P_6, P_7, P_8, P_9);
				adornment2 = adornment;
			}
			else
			{
				IAdornment adornment = new xAa(P_1, P_5, P_6, P_7, P_8, P_9);
				adornment2 = adornment;
			}
			IAdornment adornment3 = adornment2;
			adornment3.Location = P_3;
			Hny.Add(adornment3);
			UIElementCollection uIElementCollection = this.v0D();
			if (P_1 != null)
			{
				uIElementCollection.Add(P_1);
			}
			if (adornment3.DrawCallback != null)
			{
				if ((uint)(P_0 - 2) > 1u)
				{
					View.InvalidateRender();
				}
			}
			return adornment3;
		}
		return null;
	}

	internal void Enk(AdornmentChangeReason P_0, int P_1, IAdornment P_2)
	{
		Action<IAdornment> removedCallback = P_2.RemovedCallback;
		bool flag = removedCallback != null;
		int num = 1;
		if (!FO8())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		UIElementCollection uIElementCollection = default(UIElementCollection);
		do
		{
			switch (num)
			{
			default:
				uIElementCollection.Remove(P_2.VisualElement);
				break;
			case 1:
			{
				if (flag)
				{
					removedCallback(P_2);
				}
				UIElement visualElement = P_2.VisualElement;
				if (visualElement == null)
				{
					break;
				}
				goto IL_00dd;
			}
			}
			Hny.RemoveAt(P_1);
			if (P_2.DrawCallback != null)
			{
				if ((uint)(P_0 - 2) > 1u)
				{
					View.InvalidateRender();
				}
			}
			return;
			IL_00dd:
			uIElementCollection = this.v0D();
			num = 0;
		}
		while (FO8());
		goto IL_0005;
	}

	internal void znS(ITextSnapshot P_0)
	{
		TextSnapshotRange? textSnapshotRange = null;
		for (int num = Hny.Count - 1; num >= 0; num--)
		{
			if (Hny[num] is XAK { SnapshotRange: not null, SnapshotRange: var snapshotRange } xAK)
			{
				if (snapshotRange.Value.Snapshot.Document == P_0.Document)
				{
					xAK.znb(P_0);
					TextSnapshotRange value = xAK.SnapshotRange.Value;
					if (!textSnapshotRange.HasValue)
					{
						textSnapshotRange = View.VisibleViewLines.SnapshotRange;
					}
					if (!textSnapshotRange.Value.IntersectsWith(value))
					{
						Enk(AdornmentChangeReason.ViewLineRemoved, num, xAK);
					}
				}
				else
				{
					Enk(AdornmentChangeReason.DocumentChanged, num, xAK);
				}
			}
		}
	}

	public IAdornment AddAdornment(AdornmentChangeReason P_0, UIElement P_1, Point P_2, object P_3, Action<IAdornment> P_4 = null)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197748));
		}
		return Sns(P_0, P_1, null, P_2, P_1.DesiredSize, P_3, null, null, null, P_4);
	}

	public IAdornment AddAdornment(AdornmentChangeReason P_0, DrawAdornmentCallback P_1, Rect P_2, object P_3, Action<IAdornment> P_4 = null)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197778));
		}
		return Sns(P_0, null, P_1, new Point(P_2.X, P_2.Y), new Size(P_2.Width, P_2.Height), P_3, null, null, null, P_4);
	}

	public IAdornment AddAdornment(AdornmentChangeReason P_0, UIElement P_1, Point P_2, object P_3, ITextViewLine P_4, TextSnapshotRange P_5, TextRangeTrackingModes P_6 = TextRangeTrackingModes.ExpandBothEdges, Action<IAdornment> P_7 = null)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197748));
		}
		return Sns(P_0, P_1, null, P_2, P_1.DesiredSize, P_3, P_4, P_5, P_6, P_7);
	}

	public IAdornment AddAdornment(AdornmentChangeReason P_0, DrawAdornmentCallback P_1, Rect P_2, object P_3, ITextViewLine P_4, TextSnapshotRange P_5, TextRangeTrackingModes P_6 = TextRangeTrackingModes.ExpandBothEdges, Action<IAdornment> P_7 = null)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197778));
		}
		return Sns(P_0, null, P_1, new Point(P_2.X, P_2.Y), new Size(P_2.Width, P_2.Height), P_3, P_4, P_5, P_6, P_7);
	}

	protected override Size ArrangeOverride(Size P_0)
	{
		foreach (UIElement child in base.Children)
		{
			if (!child.IsMeasureValid)
			{
				child.Measure(P_0);
			}
		}
		return base.ArrangeOverride(P_0);
	}

	public virtual void Draw(TextViewDrawContext P_0)
	{
		foreach (IAdornment item in Hny)
		{
			item.DrawCallback?.Invoke(P_0, item);
		}
	}

	public IAdornment FindAdornment(UIElement P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197748));
		}
		foreach (IAdornment item in Hny)
		{
			if (item.VisualElement == P_0)
			{
				return item;
			}
		}
		return null;
	}

	public IAdornment[] FindAdornments(TextSnapshotRange P_0)
	{
		List<IAdornment> list = new List<IAdornment>();
		foreach (IAdornment item in Hny)
		{
			if (item.SnapshotRange.HasValue && (P_0.OverlapsWith(item.SnapshotRange.Value) || (item.SnapshotRange.Value.IsZeroLength && P_0.Contains(item.SnapshotRange.Value.StartOffset))))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	public IAdornment[] FindAdornments(object P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192830));
		}
		List<IAdornment> list = new List<IAdornment>();
		foreach (IAdornment item in Hny)
		{
			if (P_0.Equals(item.Tag))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	public IAdornment[] FindAdornments(ITextViewLine P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(11110));
		}
		List<IAdornment> list = new List<IAdornment>();
		foreach (IAdornment item in Hny)
		{
			if (P_0.Equals(item.ViewLine))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	public IAdornment[] FindAdornments(Predicate<IAdornment> P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197806));
		}
		List<IAdornment> list = new List<IAdornment>();
		foreach (IAdornment item in Hny)
		{
			if (P_0(item))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	public bool RemoveAdornment(AdornmentChangeReason P_0, IAdornment P_1)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197820));
		}
		return RemoveAdornments(P_0, new IAdornment[1] { P_1 });
	}

	public bool RemoveAdornments(AdornmentChangeReason P_0, IEnumerable<IAdornment> P_1)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197858));
		}
		bool result = false;
		foreach (IAdornment item in P_1)
		{
			if (item != null)
			{
				int num = Hny.IndexOf(item);
				if (num != -1)
				{
					result = true;
					Enk(P_0, num, item);
				}
			}
		}
		return result;
	}

	public bool RemoveAllAdornments(AdornmentChangeReason P_0)
	{
		return RemoveAdornments(P_0, Hny.ToArray());
	}

	public override string ToString()
	{
		return GetType().Name + Q7Z.tqM(197898) + Key + Q7Z.tqM(11640);
	}

	[SpecialName]
	double IAdornmentLayer.get_Opacity()
	{
		return base.Opacity;
	}

	[SpecialName]
	void IAdornmentLayer.set_Opacity(double P_0)
	{
		base.Opacity = P_0;
	}

	internal static bool FO8()
	{
		return JOu == null;
	}

	internal static DAN KOU()
	{
		return JOu;
	}
}
