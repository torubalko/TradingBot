using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Internal;

internal class o7 : Panel
{
	private Size ugi;

	private Rect egp;

	private EditorView mgM;

	internal static o7 MB9;

	public o7(EditorView P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_0 != null)
		{
			mgM = P_0;
			hgk();
			return;
		}
		throw new ArgumentNullException(Q7Z.tqM(952));
	}

	private void hgk()
	{
		UIElementCollection uIElementCollection = this.v0D();
		nR nR2 = mgM.DAb();
		for (int num = uIElementCollection.Count - 1; num >= 0; num--)
		{
			if (uIElementCollection[num] != nR2)
			{
				uIElementCollection.RemoveAt(num);
			}
		}
		if (nR2 != null && !uIElementCollection.Contains(nR2))
		{
			uIElementCollection.Add(nR2);
		}
		foreach (IEditorViewMargin margin in mgM.Margins)
		{
			EditorViewMarginPlacement placement = margin.Placement;
			EditorViewMarginPlacement editorViewMarginPlacement = placement;
			if ((uint)editorViewMarginPlacement <= 3u)
			{
				FrameworkElement visualElement = margin.VisualElement;
				if (visualElement != null)
				{
					uIElementCollection.Add(visualElement);
				}
			}
		}
	}

	protected override Size ArrangeOverride(Size P_0)
	{
		double zoomLevel = mgM.ZoomLevel;
		Rect rect = new Rect(0.0, 0.0, P_0.Width, P_0.Height);
		Rect rect2 = new Rect(rect.X / zoomLevel, rect.Y / zoomLevel, rect.Width / zoomLevel, rect.Height / zoomLevel);
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		IEditorViewMarginCollection margins = mgM.Margins;
		for (int num5 = margins.Count - 1; num5 >= 0; num5--)
		{
			IEditorViewMargin editorViewMargin = margins[num5];
			FrameworkElement visualElement = editorViewMargin.VisualElement;
			if (visualElement != null)
			{
				if (editorViewMargin.Visibility == Visibility.Visible)
				{
					switch (editorViewMargin.Placement)
					{
					case EditorViewMarginPlacement.ScrollableBottom:
					{
						double height2 = visualElement.DesiredSize.Height;
						visualElement.Arrange(new Rect(rect2.X + num, rect2.Bottom - num4 - height2, Math.Max(0.0, rect2.Width - num - num3), Math.Max(0.0, height2)));
						num4 += height2;
						break;
					}
					case EditorViewMarginPlacement.ScrollableLeft:
					{
						double width2 = visualElement.DesiredSize.Width;
						visualElement.Arrange(new Rect(rect2.X + num, rect2.Y + num2, Math.Max(0.0, width2), Math.Max(0.0, rect2.Height - num2 - num4)));
						num += width2;
						break;
					}
					case EditorViewMarginPlacement.ScrollableRight:
					{
						double width = visualElement.DesiredSize.Width;
						visualElement.Arrange(new Rect(rect2.Right - num3 - width, rect2.Y + num2, Math.Max(0.0, width), Math.Max(0.0, rect2.Height - num2 - num4)));
						num3 += width;
						break;
					}
					case EditorViewMarginPlacement.ScrollableTop:
					{
						double height = visualElement.DesiredSize.Height;
						visualElement.Arrange(new Rect(rect2.X + num, rect2.Y + num2, Math.Max(0.0, rect2.Width - num - num3), Math.Max(0.0, height)));
						num2 += height;
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
		ugi = new Size(Math.Max(0.0, rect2.Width - num - num3), Math.Max(0.0, rect2.Height - num2 - num4));
		egp = new Rect(num * zoomLevel, num2 * zoomLevel, Math.Max(0.0, rect.Width - (num + num3) * zoomLevel), Math.Max(0.0, rect.Height - (num2 + num4) * zoomLevel));
		nR nR2 = mgM.DAb();
		if (nR2 != null)
		{
			Rect finalRect = new Rect(rect.X + num, rect.Y + num2, ugi.Width, ugi.Height);
			nR2.Arrange(finalRect);
		}
		else
		{
			ugi = default(Size);
		}
		return P_0;
	}

	public void XgS()
	{
		mgM.DAb()?.InvalidateArrange();
	}

	public void Cg9()
	{
		hgk();
	}

	[SpecialName]
	public Size xgy()
	{
		return ugi;
	}

	[SpecialName]
	public Rect Mg2()
	{
		return egp;
	}

	protected override Size MeasureOverride(Size P_0)
	{
		Size result = default(Size);
		double zoomLevel = mgM.ZoomLevel;
		double num = P_0.Width / zoomLevel;
		double num2 = P_0.Height / zoomLevel;
		using (IEnumerator<IEditorViewMargin> enumerator = mgM.Margins.GetEnumerator())
		{
			int num4 = default(int);
			while (enumerator.MoveNext())
			{
				IEditorViewMargin current;
				FrameworkElement visualElement;
				bool flag;
				while (true)
				{
					current = enumerator.Current;
					visualElement = current.VisualElement;
					flag = visualElement != null;
					int num3 = 0;
					if (nBR() != null)
					{
						num3 = num4;
					}
					switch (num3)
					{
					case 1:
						continue;
					}
					break;
				}
				if (flag && current.Visibility == Visibility.Visible)
				{
					switch (current.Placement)
					{
					case EditorViewMarginPlacement.ScrollableLeft:
					case EditorViewMarginPlacement.ScrollableRight:
						visualElement.Measure(new Size(num, num2));
						result.Width += visualElement.DesiredSize.Width;
						num = Math.Max(0.0, num - visualElement.DesiredSize.Width);
						break;
					case EditorViewMarginPlacement.ScrollableTop:
					case EditorViewMarginPlacement.ScrollableBottom:
						visualElement.Measure(new Size(num, num2));
						result.Height += visualElement.DesiredSize.Height;
						num2 = Math.Max(0.0, num2 - visualElement.DesiredSize.Height);
						break;
					}
				}
			}
		}
		nR nR2 = mgM.DAb();
		if (nR2 != null)
		{
			nR2.Measure(new Size(num, num2));
			result.Width += nR2.DesiredSize.Width;
			result.Height += nR2.DesiredSize.Height;
		}
		int num5;
		if (mgM.gft())
		{
			num5 = 0;
			if (!oBJ())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		return default(Size);
		IL_0009:
		do
		{
			IL_0009_2:
			switch (num5)
			{
			case 2:
				if (!double.IsPositiveInfinity(P_0.Height))
				{
					break;
				}
				goto case 1;
			default:
				result.Width = Math.Ceiling(result.Width * zoomLevel);
				result.Height = Math.Ceiling(result.Height * zoomLevel);
				if (!double.IsPositiveInfinity(P_0.Width))
				{
					result.Width = Math.Min(result.Width, P_0.Width);
					num5 = 2;
					goto IL_0009_2;
				}
				goto case 2;
			case 1:
				return result;
			}
			result.Height = Math.Min(result.Height, P_0.Height);
			num5 = 1;
		}
		while (nBR() == null);
		goto IL_0005;
		IL_0005:
		int num6 = default(int);
		num5 = num6;
		goto IL_0009;
	}

	internal static bool oBJ()
	{
		return MB9 == null;
	}

	internal static o7 nBR()
	{
		return MB9;
	}
}
