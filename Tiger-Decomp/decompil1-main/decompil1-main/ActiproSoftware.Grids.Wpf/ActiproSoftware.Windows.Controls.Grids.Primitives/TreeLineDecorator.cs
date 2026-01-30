using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.Primitives;

[ToolboxItem(false)]
public class TreeLineDecorator : Decorator
{
	private struct DR
	{
		[CompilerGenerated]
		private double Wmw;

		[CompilerGenerated]
		private bool QmX;

		[CompilerGenerated]
		private double dm2;

		private static object LXc;

		[SpecialName]
		[CompilerGenerated]
		public double dmd()
		{
			return Wmw;
		}

		[SpecialName]
		[CompilerGenerated]
		public void jmB(double P_0)
		{
			Wmw = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public bool dmM()
		{
			return QmX;
		}

		[SpecialName]
		[CompilerGenerated]
		public void gme(bool P_0)
		{
			QmX = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public double tmG()
		{
			return dm2;
		}

		[SpecialName]
		[CompilerGenerated]
		public void Jmu(double P_0)
		{
			dm2 = P_0;
		}

		internal static bool RXR()
		{
			return LXc == null;
		}

		internal static object IXX()
		{
			return LXc;
		}
	}

	public static readonly DependencyProperty TreeLineBrushProperty;

	internal static TreeLineDecorator ksu;

	public Brush TreeLineBrush
	{
		get
		{
			return (Brush)GetValue(TreeLineBrushProperty);
		}
		set
		{
			SetValue(TreeLineBrushProperty, value);
		}
	}

	protected override void OnRender(DrawingContext drawingContext)
	{
		base.OnRender(drawingContext);
		if (!(base.TemplatedParent is TreeListBoxItem treeListBoxItem))
		{
			return;
		}
		oT oT = treeListBoxItem.ntA();
		if (oT == null)
		{
			return;
		}
		TreeListBox treeListBox = oT.nNQ();
		if (treeListBox == null || !treeListBox.HasTreeLines)
		{
			return;
		}
		TreeListBoxItemAdapter itemAdapter = treeListBox.ItemAdapter;
		if (itemAdapter == null)
		{
			return;
		}
		List<DR> list = new List<DR>();
		int num = oT.LKi();
		int num2 = num;
		oT oT2 = oT;
		double num3 = itemAdapter.GetIndentAmount(treeListBox, oT2.sNm(), num2);
		while (num2 > 0 && oT2 != null)
		{
			double indentAmount = itemAdapter.GetIndentAmount(treeListBox, oT2.sNm(), --num2);
			double num4 = Math.Floor(num3 - (num3 - indentAmount) / 2.0) - 0.5;
			DR item = default(DR);
			item.jmB(num4);
			item.gme(oT2.tNd().kK3().LastOrDefault((oT n) => n.IsVisible) == oT2);
			item.Jmu(num3);
			list.Insert(0, item);
			num3 = indentAmount;
			oT2 = oT2.tNd();
		}
		Rect rect = treeListBoxItem.TransformToDescendant(this).TransformBounds(new Rect(default(Point), treeListBoxItem.DesiredSize));
		Pen pen = null;
		for (num2 = 1; num2 <= list.Count; num2++)
		{
			DR dR = list[num2 - 1];
			if (num2 != num && dR.dmM())
			{
				continue;
			}
			double num5 = Math.Round(rect.Height / 2.0, MidpointRounding.AwayFromZero) - ((rect.Height % 2.0 == 1.0) ? 0.5 : 1.5);
			if (pen == null)
			{
				pen = new Pen(TreeLineBrush, 1.0);
				pen.StartLineCap = PenLineCap.Square;
				pen.EndLineCap = PenLineCap.Square;
				if (pen.CanFreeze)
				{
					pen.Freeze();
				}
			}
			bool flag = num2 == num;
			if (flag && oT.IsExpandable)
			{
				drawingContext.DrawLine(pen, new Point(dR.dmd(), rect.Y), new Point(dR.dmd(), Math.Max(rect.Y + 1.0, num5 - 7.0)));
				if (!dR.dmM())
				{
					drawingContext.DrawLine(pen, new Point(dR.dmd(), Math.Min(rect.Bottom - 1.0, num5 + 7.0)), new Point(dR.dmd(), rect.Bottom));
				}
				drawingContext.DrawLine(pen, new Point(dR.dmd() + 7.0 - 1.0, num5), new Point(dR.tmG() - 2.5, num5));
			}
			else
			{
				drawingContext.DrawLine(pen, new Point(dR.dmd(), rect.Y), new Point(dR.dmd(), dR.dmM() ? num5 : rect.Bottom));
				if (flag)
				{
					drawingContext.DrawLine(pen, new Point(dR.dmd(), num5), new Point(dR.tmG() - 2.5, num5));
				}
			}
		}
	}

	public TreeLineDecorator()
	{
		fc.taYSkz();
		base._002Ector();
	}

	static TreeLineDecorator()
	{
		fc.taYSkz();
		TreeLineBrushProperty = DependencyProperty.Register(xv.hTz(5780), typeof(Brush), typeof(TreeLineDecorator), new PropertyMetadata(Brushes.Black));
	}

	internal static bool fsq()
	{
		return ksu == null;
	}

	internal static TreeLineDecorator QsH()
	{
		return ksu;
	}
}
