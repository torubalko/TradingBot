using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments.Implementation;

namespace ActiproSoftware.Internal;

internal class bAs : AdornmentManagerBase<IEditorView>
{
	private List<IAdornment> i8g;

	private bool C8Q;

	private int H8e;

	private static bAs p1B;

	public bAs(IEditorView P_0)
	{
		grA.DaB7cz();
		base._002Ector(P_0, AdornmentLayerDefinitions.Caret, isForLanguage: false);
		P_0.TextAreaLayout += tnz;
	}

	private IAdornment xnN(zTB P_0, int P_1)
	{
		if (i8g == null)
		{
			i8g = new List<IAdornment>();
		}
		if (P_1 >= i8g.Count)
		{
			int num = 0;
			if (a17() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			UIElement visualElement = V8X(P_0.CaretBrush, wnd(P_0));
			IAdornment item = base.AdornmentLayer.AddAdornment(AdornmentChangeReason.Other, visualElement, new Point(0.0, 0.0), this, null);
			i8g.Add(item);
		}
		return i8g[Math.Min(i8g.Count - 1, P_1)];
	}

	private double wnd(zTB P_0)
	{
		return (!g8K()) ? 0.0 : (P_0.IsOverwriteModeActive ? 0.3 : 1.0);
	}

	private void tnz(object P_0, TextViewTextAreaLayoutEventArgs P_1)
	{
		N8x();
	}

	private void h8W(int P_0)
	{
		if (i8g != null && P_0 < i8g.Count)
		{
			for (int num = i8g.Count - 1; num >= P_0; num--)
			{
				base.AdornmentLayer.RemoveAdornment(AdornmentChangeReason.Other, i8g[num]);
			}
			i8g.RemoveRange(P_0, i8g.Count - P_0);
		}
	}

	private void S8P(zTB P_0)
	{
		if (i8g == null || i8g.Count <= 0)
		{
			return;
		}
		double num = wnd(P_0);
		for (int num2 = i8g.Count - 1; num2 >= 0; num2--)
		{
			IAdornment adornment = i8g[num2];
			if (adornment.VisualElement is Rectangle rectangle)
			{
				rectangle.Opacity = ((num2 == H8e) ? 1.0 : 0.4) * num;
			}
		}
	}

	private void D8E(ITextPositionRangeCollection P_0, ITextViewLineCollection P_1)
	{
		int num = 0;
		if (P_1.Count > 0)
		{
			int num2 = P_0.BinarySearch(P_1[0].StartPosition);
			if (num2 < 0)
			{
				num2 = ~num2;
			}
			if (num2 < P_0.Count)
			{
				TextPosition endPosition = P_0[num2].EndPosition;
				zTB zTB2 = base.View.SyntaxEditor.LGl();
				foreach (ITextViewLine item in P_1)
				{
					TextPosition startPosition = item.StartPosition;
					TextPosition maxPosition = item.MaxPosition;
					while (num2 < P_0.Count)
					{
						if (endPosition >= startPosition && endPosition <= maxPosition)
						{
							if (endPosition.HasFarAffinity && endPosition == maxPosition && !item.HasHardLineBreak && !item.IsLastLine)
							{
								break;
							}
							Rect rect = zTB2.XRj(item, endPosition);
							IAdornment adornment = xnN(zTB2, num++);
							adornment.Location = new Point(rect.X, item.TextBounds.Y + rect.Y);
							if (adornment.VisualElement is Rectangle rectangle)
							{
								rectangle.Width = rect.Width;
								rectangle.Height = rect.Height;
							}
						}
						if (endPosition > maxPosition || ++num2 >= P_0.Count)
						{
							break;
						}
						endPosition = P_0[num2].EndPosition;
					}
					if (num2 >= P_0.Count)
					{
						break;
					}
				}
			}
		}
		h8W(num);
		S8P(base.View.SyntaxEditor.LGl());
	}

	public static bAs a8c(IEditorView P_0)
	{
		return new bAs(P_0);
	}

	[SpecialName]
	public bool g8K()
	{
		return C8Q;
	}

	[SpecialName]
	private void R8f(bool P_0)
	{
		if (C8Q != P_0)
		{
			C8Q = P_0;
			S8P(base.View.SyntaxEditor.LGl());
		}
	}

	protected override void OnClosed()
	{
		base.View.TextAreaLayout -= tnz;
		h8W(0);
		base.OnClosed();
	}

	public void u8a()
	{
		if (i8g == null || i8g.Count <= 0)
		{
			return;
		}
		zTB zTB2 = base.View.SyntaxEditor.LGl();
		S8P(zTB2);
		Brush brush = zTB2.CaretBrush;
		foreach (IAdornment item in i8g)
		{
			if (item.VisualElement is Rectangle rectangle && rectangle.Fill != zTB2.CaretBrush)
			{
				rectangle.Fill = zTB2.CaretBrush;
			}
		}
	}

	public void N8x()
	{
		IEditorView view = base.View;
		bool flag = view != null;
		int num = 0;
		if (!I10())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			ITextViewLineCollection visibleViewLines = view.VisibleViewLines;
			if (visibleViewLines != null)
			{
				TextPosition? textPosition = view.SyntaxEditor.LGl().dR8();
				ITextPositionRangeCollection textPositionRangeCollection = (textPosition.HasValue ? TextPositionRange.CreateCollection(new TextPositionRange[1]
				{
					new TextPositionRange(textPosition.Value)
				}, 0) : view.Selection.Ranges);
				H8e = textPositionRangeCollection.PrimaryIndex;
				D8E(textPositionRangeCollection, visibleViewLines);
			}
		}
	}

	public void o8G()
	{
		IEditorView view = base.View;
		zTB zTB2 = view.SyntaxEditor.LGl();
		R8f(zTB2.jRV() && (view.HasFocus || zTB2.dR8().HasValue));
	}

	private static UIElement V8X(Brush P_0, double P_1)
	{
		Rectangle rectangle = new Rectangle();
		rectangle.SnapsToDevicePixels = true;
		rectangle.IsHitTestVisible = false;
		rectangle.Fill = P_0;
		rectangle.Opacity = P_1;
		return rectangle;
	}

	internal static bool I10()
	{
		return p1B == null;
	}

	internal static bAs a17()
	{
		return p1B;
	}
}
