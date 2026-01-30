using System;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Internal;

internal class vAC : IntraTextAdornmentManagerBase<ITextView, CM.w7A>
{
	internal static vAC z1n;

	public vAC(ITextView P_0)
	{
		grA.DaB7cz();
		base._002Ector(P_0, AdornmentLayerDefinitions.CollapsedRegion, isForLanguage: false);
	}

	protected override void AddAdornment(AdornmentChangeReason P_0, ITextViewLine P_1, TagSnapshotRange<CM.w7A> P_2, TextBounds P_3)
	{
		if (P_2 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7610));
		}
		double x = Math.Round(P_3.X);
		double y = Math.Round(P_3.Y);
		double width = Math.Round(P_3.Width);
		double height = Math.Round(P_3.Height);
		CollapsedRegionAdornment collapsedRegionAdornment = new CollapsedRegionAdornment(P_2);
		collapsedRegionAdornment.Width = width;
		collapsedRegionAdornment.Height = height;
		collapsedRegionAdornment.Content = P_2.Tag.Text;
		collapsedRegionAdornment.FontSize = base.View.DefaultFontSize;
		collapsedRegionAdornment.FontFamily = new FontFamily(base.View.DefaultFontFamilyName);
		collapsedRegionAdornment.Padding = new Thickness(0.0, 1.0, 0.0, 0.0);
		IHighlightingStyle highlightingStyle = base.View.HighlightingStyleRegistry?[cT.CollapsedText];
		if (highlightingStyle != null && highlightingStyle.Foreground.HasValue)
		{
			SolidColorBrush solidColorBrush = new SolidColorBrush(highlightingStyle.Foreground.Value);
			if (solidColorBrush.CanFreeze)
			{
				solidColorBrush.Freeze();
			}
			collapsedRegionAdornment.BorderBrush = solidColorBrush;
			collapsedRegionAdornment.Foreground = solidColorBrush;
		}
		base.AdornmentLayer.AddAdornment(P_0, collapsedRegionAdornment, new Point(x, y), P_2.Tag.Key, null);
	}

	public static vAC c8l(ITextView P_0)
	{
		return new vAC(P_0);
	}

	protected override void OnClosed()
	{
		base.AdornmentLayer.RemoveAllAdornments(AdornmentChangeReason.ManagerClosed);
		base.OnClosed();
	}

	internal static bool p1q()
	{
		return z1n == null;
	}

	internal static vAC d1x()
	{
		return z1n;
	}
}
