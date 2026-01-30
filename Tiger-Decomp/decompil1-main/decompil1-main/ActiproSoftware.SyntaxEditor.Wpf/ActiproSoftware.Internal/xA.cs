using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Internal;

internal class xA : Panel
{
	private CanvasControl VgX;

	private ScrollBar jgK;

	private ScrollBarVisibility egf;

	private ScrollBarSplitter xgD;

	private bool mgg;

	private bool IgQ;

	private o7 Mge;

	private Rect tgl;

	private ScrollBarBlock zgA;

	private EditorViewSelectionGripper pgv;

	private EditorViewSelectionGripper jgm;

	private ScrollBar ggC;

	private ScrollBarVisibility dgu;

	private EditorView sg1;

	private ScrollBarTray VgF;

	private ScrollBarTray bg3;

	private ScrollBarTray xgR;

	private ScrollBarTray DgY;

	private static xA vBL;

	public xA(EditorView P_0)
	{
		grA.DaB7cz();
		egf = ScrollBarVisibility.Visible;
		mgg = true;
		IgQ = true;
		dgu = ScrollBarVisibility.Visible;
		base._002Ector();
		bool flag = P_0 == null;
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		sg1 = P_0;
		UDs();
		qD9();
	}

	[SpecialName]
	private double zDy()
	{
		double num = 0.0;
		if (bg3 != null && bg3.DesiredSize.Width > 0.0)
		{
			num = Math.Max(num, bg3.DesiredSize.Height);
		}
		if (xgR != null && xgR.DesiredSize.Width > 0.0)
		{
			num = Math.Max(num, xgR.DesiredSize.Height);
		}
		if (mgg)
		{
			num = Math.Max(num, Math.Max((zgA != null) ? zgA.DesiredSize.Height : 0.0, (jgK != null) ? jgK.DesiredSize.Height : 0.0));
		}
		return num;
	}

	[SpecialName]
	private double sD2()
	{
		if (!mgg)
		{
			return 0.0;
		}
		return (jgK != null) ? 20 : 0;
	}

	[SpecialName]
	private double vDi()
	{
		if (!IgQ)
		{
			return 0.0;
		}
		return (ggC != null) ? 20 : 0;
	}

	[SpecialName]
	private double NDM()
	{
		double num = 0.0;
		if (DgY != null && DgY.DesiredSize.Height > 0.0)
		{
			num = Math.Max(num, DgY.DesiredSize.Width);
		}
		if (VgF != null && VgF.DesiredSize.Height > 0.0)
		{
			num = Math.Max(num, VgF.DesiredSize.Width);
		}
		if (IgQ)
		{
			num = Math.Max(num, Math.Max((ggC != null) ? ggC.DesiredSize.Width : 0.0, Math.Max((xgD != null) ? xgD.DesiredSize.Width : 0.0, (zgA != null) ? zgA.DesiredSize.Width : 0.0)));
		}
		return num;
	}

	private void UDs()
	{
		PTg pTg = sg1.lfz();
		UIElementCollection uIElementCollection = this.v0D();
		VgX = sg1.aAY();
		int num;
		if (VgX != null)
		{
			num = 3;
			goto IL_0009;
		}
		goto IL_0281;
		IL_0281:
		Mge = sg1.ofh();
		if (Mge != null)
		{
			uIElementCollection.Add(Mge);
		}
		XDk();
		zgA = new ScrollBarBlock();
		uIElementCollection.Add(zgA);
		bg3 = new ScrollBarTray
		{
			Orientation = Orientation.Horizontal
		};
		BindingOperations.SetBinding(bg3, ContentControl.ContentTemplateProperty, vAE.A0X(sg1.SyntaxEditor, Q7Z.tqM(6558), BindingMode.OneWay, null));
		uIElementCollection.Add(bg3);
		DgY = new ScrollBarTray
		{
			Orientation = Orientation.Vertical
		};
		BindingOperations.SetBinding(DgY, ContentControl.ContentTemplateProperty, vAE.A0X(sg1.SyntaxEditor, Q7Z.tqM(6668), BindingMode.OneWay, null));
		uIElementCollection.Add(DgY);
		xgR = new ScrollBarTray
		{
			Orientation = Orientation.Horizontal
		};
		BindingOperations.SetBinding(xgR, ContentControl.ContentTemplateProperty, vAE.A0X(sg1.SyntaxEditor, Q7Z.tqM(6612), BindingMode.OneWay, null));
		uIElementCollection.Add(xgR);
		VgF = new ScrollBarTray
		{
			Orientation = Orientation.Vertical
		};
		BindingOperations.SetBinding(VgF, ContentControl.ContentTemplateProperty, vAE.A0X(sg1.SyntaxEditor, Q7Z.tqM(6500), BindingMode.OneWay, null));
		uIElementCollection.Add(VgF);
		num = 1;
		if (uBA() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 3:
				goto end_IL_0009;
			case 1:
				xgD = new ScrollBarSplitter();
				xgD.U0F(_0020: false);
				uIElementCollection.Add(xgD);
				jgK = pTg.X4S();
				uIElementCollection.Add(jgK);
				ggC = pTg.H49();
				uIElementCollection.Add(ggC);
				jgm = new EditorViewSelectionGripper
				{
					IsForSelectionEnd = false,
					Visibility = Visibility.Collapsed
				};
				uIElementCollection.Add(jgm);
				num = 2;
				continue;
			default:
				uIElementCollection.Add(pgv);
				Panel.SetZIndex(jgm, 1000);
				Panel.SetZIndex(pgv, 1000);
				return;
			}
			pgv = new EditorViewSelectionGripper
			{
				IsForSelectionEnd = true,
				Visibility = Visibility.Collapsed
			};
			num = 0;
			if (FBg())
			{
				continue;
			}
			goto IL_0005;
			continue;
			end_IL_0009:
			break;
		}
		uIElementCollection.Add(VgX);
		goto IL_0281;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	protected override Size ArrangeOverride(Size P_0)
	{
		Rect finalRect = new Rect(default(Point), P_0);
		double num = NDM();
		double num2 = zDy();
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		IEditorViewMarginCollection margins = sg1.Margins;
		for (int num7 = margins.Count - 1; num7 >= 0; num7--)
		{
			IEditorViewMargin editorViewMargin = margins[num7];
			FrameworkElement visualElement = editorViewMargin.VisualElement;
			if (visualElement != null)
			{
				if (editorViewMargin.Visibility == Visibility.Visible)
				{
					switch (editorViewMargin.Placement)
					{
					case EditorViewMarginPlacement.FixedBottom:
					{
						double height2 = visualElement.DesiredSize.Height;
						visualElement.Arrange(new Rect(finalRect.X + num3, finalRect.Bottom - num6 - height2, Math.Max(0.0, finalRect.Width - num3 - num5), Math.Max(0.0, height2)));
						num6 += height2;
						break;
					}
					case EditorViewMarginPlacement.FixedLeft:
					{
						double width2 = visualElement.DesiredSize.Width;
						visualElement.Arrange(new Rect(finalRect.X + num3, finalRect.Y + num4, Math.Max(0.0, width2), Math.Max(0.0, finalRect.Height - num4 - num6)));
						num3 += width2;
						break;
					}
					case EditorViewMarginPlacement.FixedRight:
					{
						double width = visualElement.DesiredSize.Width;
						visualElement.Arrange(new Rect(finalRect.Right - num5 - width, finalRect.Y + num4, Math.Max(0.0, width), Math.Max(0.0, finalRect.Height - num4 - num6)));
						num5 += width;
						break;
					}
					case EditorViewMarginPlacement.FixedTop:
					{
						double height = visualElement.DesiredSize.Height;
						visualElement.Arrange(new Rect(finalRect.X + num3, finalRect.Y + num4, Math.Max(0.0, finalRect.Width - num3 - num5), Math.Max(0.0, height)));
						num4 += height;
						break;
					}
					}
				}
				else
				{
					visualElement.Arrange(default(Rect));
				}
			}
		}
		Rect rect = new Rect(finalRect.X + num3, finalRect.Y + num4, Math.Max(0.0, finalRect.Width - num3 - num5), Math.Max(0.0, finalRect.Height - num4 - num6));
		tgl = new Rect(rect.X, rect.Y, Math.Max(0.0, rect.Width - (CDt() ? 0.0 : num)), Math.Max(0.0, rect.Height - (VDU() ? 0.0 : num2)));
		if (Mge != null)
		{
			Mge.Arrange(tgl);
		}
		bool flag = jgK.Visibility == Visibility.Visible && jgK.Opacity == 1.0;
		bool flag2 = ggC.Visibility == Visibility.Visible && ggC.Opacity == 1.0;
		if (zgA != null)
		{
			if (flag && flag2)
			{
				zgA.Arrange(new Rect(rect.Right - num, rect.Bottom - num2, num, num2));
			}
			else
			{
				zgA.Arrange(new Rect(rect.Right, rect.Bottom, 0.0, 0.0));
			}
		}
		double num8 = 0.0;
		if (xgD != null && xgD.L0g())
		{
			num8 = ((rect.Height < 60.0) ? 0.0 : xgD.DesiredSize.Height);
			xgD.Arrange(new Rect(rect.Right - num, rect.Top, num, num8));
		}
		Rect finalRect2 = new Rect(rect.Left, rect.Bottom - num2, Math.Max(0.0, rect.Width - (flag2 ? num : 0.0)), num2);
		Rect finalRect3 = new Rect(rect.Right - num, rect.Top + num8, num, Math.Max(0.0, rect.Height - num8 - (flag ? num2 : 0.0)));
		if (bg3 != null)
		{
			Rect finalRect4 = new Rect(finalRect2.Left, finalRect2.Top, bg3.DesiredSize.Width, finalRect2.Height);
			bg3.Arrange(finalRect4);
			finalRect2.X += finalRect4.Width;
			finalRect2.Width = Math.Max(0.0, finalRect2.Width - finalRect4.Width);
		}
		if (xgR != null)
		{
			Rect finalRect5 = new Rect(finalRect2.Right - xgR.DesiredSize.Width, finalRect2.Top, xgR.DesiredSize.Width, finalRect2.Height);
			xgR.Arrange(finalRect5);
			finalRect2.Width = Math.Max(0.0, finalRect2.Width - finalRect5.Width);
		}
		if (jgK != null)
		{
			jgK.Arrange(finalRect2);
		}
		if (DgY != null)
		{
			Rect finalRect6 = new Rect(finalRect3.Left, finalRect3.Top, finalRect3.Width, DgY.DesiredSize.Height);
			DgY.Arrange(finalRect6);
			finalRect3.Y += finalRect6.Height;
			finalRect3.Height = Math.Max(0.0, finalRect3.Height - finalRect6.Height);
		}
		if (VgF != null)
		{
			Rect finalRect7 = new Rect(finalRect3.Left, finalRect3.Bottom - VgF.DesiredSize.Height, finalRect3.Width, VgF.DesiredSize.Height);
			VgF.Arrange(finalRect7);
			finalRect3.Height = Math.Max(0.0, finalRect3.Height - finalRect7.Height);
		}
		if (ggC != null)
		{
			ggC.Arrange(finalRect3);
		}
		if (jgm != null)
		{
			jgm.Arrange(new Rect(jgm.Location, jgm.DesiredSize));
		}
		if (pgv != null)
		{
			pgv.Arrange(new Rect(pgv.Location, pgv.DesiredSize));
		}
		if (VgX != null)
		{
			VgX.Arrange(finalRect);
		}
		return P_0;
	}

	[SpecialName]
	public bool VDU()
	{
		switch (egf)
		{
		case ScrollBarVisibility.Auto:
		{
			bool flag = jgK != null && jgK.Visibility == Visibility.Visible && jgK.Opacity == 1.0;
			return !flag;
		}
		case ScrollBarVisibility.Visible:
			return false;
		default:
			return true;
		}
	}

	[SpecialName]
	public bool CDt()
	{
		switch (dgu)
		{
		default:
			return true;
		case ScrollBarVisibility.Auto:
		{
			bool flag = ggC != null && ggC.Visibility == Visibility.Visible && ggC.Opacity == 1.0;
			int num = 0;
			if (!FBg())
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => !flag, 
			};
		}
		case ScrollBarVisibility.Visible:
			return false;
		}
	}

	public void XDk()
	{
		UIElementCollection uIElementCollection = this.v0D();
		int num = Math.Min(uIElementCollection.Count, 2);
		int num3 = default(int);
		foreach (IEditorViewMargin margin in sg1.Margins)
		{
			EditorViewMarginPlacement placement = margin.Placement;
			EditorViewMarginPlacement editorViewMarginPlacement = placement;
			if ((uint)(editorViewMarginPlacement - 4) > 3u)
			{
				continue;
			}
			FrameworkElement visualElement = margin.VisualElement;
			bool flag = visualElement != null;
			int num2 = 0;
			if (uBA() != null)
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
			if (flag)
			{
				uIElementCollection.Insert(num++, visualElement);
			}
		}
	}

	[SpecialName]
	public bool CDh()
	{
		return xgD != null && xgD.L0g();
	}

	[SpecialName]
	public void GDN(bool P_0)
	{
		if (xgD != null)
		{
			xgD.U0F(P_0);
		}
	}

	public void lDS()
	{
		UIElementCollection uIElementCollection = this.v0D();
		foreach (IEditorViewMargin margin in sg1.Margins)
		{
			EditorViewMarginPlacement placement = margin.Placement;
			EditorViewMarginPlacement editorViewMarginPlacement = placement;
			if ((uint)(editorViewMarginPlacement - 4) <= 3u)
			{
				FrameworkElement visualElement = margin.VisualElement;
				if (visualElement != null && uIElementCollection.Contains(visualElement))
				{
					uIElementCollection.Remove(visualElement);
				}
			}
		}
	}

	[SpecialName]
	public Rect EDz()
	{
		return tgl;
	}

	[SpecialName]
	public EditorViewSelectionGripper NgP()
	{
		return pgv;
	}

	[SpecialName]
	public EditorViewSelectionGripper mgc()
	{
		return jgm;
	}

	public void qD9()
	{
		ScrollBarVisibility scrollBarVisibility = egf;
		ScrollBarVisibility scrollBarVisibility2 = dgu;
		egf = sg1.SyntaxEditor.HorizontalScrollBarVisibility;
		dgu = sg1.SyntaxEditor.VerticalScrollBarVisibility;
		bool isMultiLine = sg1.SyntaxEditor.IsMultiLine;
		if (!isMultiLine)
		{
			mgg = false;
		}
		else if (sg1.SyntaxEditor.IsWordWrapEnabled)
		{
			mgg = false;
			egf = ScrollBarVisibility.Hidden;
		}
		else
		{
			ScrollBarVisibility scrollBarVisibility3 = egf;
			ScrollBarVisibility scrollBarVisibility4 = scrollBarVisibility3;
			if (scrollBarVisibility4 == ScrollBarVisibility.Auto || scrollBarVisibility4 == ScrollBarVisibility.Visible)
			{
				mgg = true;
			}
			else
			{
				mgg = false;
			}
		}
		if (!isMultiLine)
		{
			IgQ = false;
		}
		else
		{
			ScrollBarVisibility scrollBarVisibility5 = dgu;
			ScrollBarVisibility scrollBarVisibility6 = scrollBarVisibility5;
			if (scrollBarVisibility6 == ScrollBarVisibility.Auto || scrollBarVisibility6 == ScrollBarVisibility.Visible)
			{
				IgQ = true;
			}
			else
			{
				IgQ = false;
			}
		}
		if (egf != scrollBarVisibility || dgu != scrollBarVisibility2)
		{
			InvalidateMeasure();
		}
	}

	[SpecialName]
	public double kgx()
	{
		return (ggC != null) ? ggC.ActualWidth : 0.0;
	}

	protected override Size MeasureOverride(Size P_0)
	{
		if (VgX != null)
		{
			VgX.Measure(P_0);
		}
		double num = P_0.Width;
		double num2 = P_0.Height;
		foreach (IEditorViewMargin margin in sg1.Margins)
		{
			FrameworkElement visualElement = margin.VisualElement;
			if (visualElement != null && margin.Visibility == Visibility.Visible)
			{
				switch (margin.Placement)
				{
				case EditorViewMarginPlacement.FixedTop:
				case EditorViewMarginPlacement.FixedBottom:
					visualElement.Measure(new Size(num, num2));
					num2 = Math.Max(0.0, num2 - visualElement.DesiredSize.Height);
					break;
				case EditorViewMarginPlacement.FixedLeft:
				case EditorViewMarginPlacement.FixedRight:
					visualElement.Measure(new Size(num, num2));
					num = Math.Max(0.0, num - visualElement.DesiredSize.Width);
					break;
				}
			}
		}
		double num3 = (mgg ? SystemParameters.ScrollHeight : 0.0);
		double num4 = (IgQ ? SystemParameters.ScrollWidth : 0.0);
		if (zgA != null)
		{
			zgA.Measure(new Size(num, num2));
			num3 = Math.Max(num3, zgA.DesiredSize.Height);
			num4 = Math.Max(num4, zgA.DesiredSize.Width);
		}
		double num5 = Math.Max(0.0, num - num4);
		double num6 = Math.Max(0.0, num2 - num3);
		Size size = default(Size);
		if (Mge != null)
		{
			Mge.Measure(new Size(num5, num6));
			size = Mge.DesiredSize;
		}
		if (bg3 != null)
		{
			bg3.Measure(new Size(num, num2));
			num5 = Math.Max(0.0, num5 - bg3.DesiredSize.Width);
		}
		if (xgR != null)
		{
			xgR.Measure(new Size(num, num2));
			num5 = Math.Max(0.0, num5 - xgR.DesiredSize.Width);
		}
		if (xgD != null)
		{
			xgD.Measure(new Size(num, num2));
			num4 = Math.Max(num4, xgD.DesiredSize.Width);
		}
		if (jgK != null)
		{
			jgK.Measure(new Size(num5, num2));
		}
		if (DgY != null)
		{
			DgY.Measure(new Size(num, num2));
			num6 = Math.Max(0.0, num6 - DgY.DesiredSize.Height);
		}
		if (VgF != null)
		{
			VgF.Measure(new Size(num, num2));
			num6 = Math.Max(0.0, num6 - VgF.DesiredSize.Height);
		}
		if (ggC != null)
		{
			ggC.Measure(new Size(num, num6));
		}
		if (jgm != null)
		{
			jgm.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
		}
		if (pgv != null)
		{
			pgv.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
		}
		Size result = new Size(Math.Max(size.Width, sD2() + NDM()) + NDM(), Math.Max(size.Height, vDi() + zDy()) + zDy());
		if (!double.IsPositiveInfinity(P_0.Width))
		{
			result.Width = Math.Min(result.Width, P_0.Width);
		}
		if (!double.IsPositiveInfinity(P_0.Height))
		{
			result.Height = Math.Min(result.Height, P_0.Height);
		}
		return result;
	}

	internal static bool FBg()
	{
		return vBL == null;
	}

	internal static xA uBA()
	{
		return vBL;
	}
}
