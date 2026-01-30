using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Products;

internal class LicenseAdorner : Adorner
{
	private Rect fqB;

	private ActiproLicense uqp;

	private static LicenseAdorner pgN;

	public LicenseAdorner(ActiproLicense license, UIElement adornedElement)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(adornedElement);
		uqp = license;
	}

	protected override void OnRender(DrawingContext drawingContext)
	{
		if (drawingContext == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111048));
		}
		string textToFormat = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129622);
		switch ((KnownLicenseExceptionKind)uqp.ExceptionType)
		{
		case KnownLicenseExceptionKind.Expired:
			textToFormat = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129646);
			break;
		case KnownLicenseExceptionKind.None:
		case KnownLicenseExceptionKind.UnlicensedProduct:
			textToFormat = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129422);
			break;
		}
		FormattedText formattedText = new FormattedText(textToFormat, CultureInfo.CurrentCulture, base.FlowDirection, new Typeface(SystemFonts.MenuFontFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal), 12.0, Brushes.Black);
		fqB = new Rect(0.0, 0.0, formattedText.Width + 13.0, formattedText.Height + 2.0);
		drawingContext.DrawRectangle(new SolidColorBrush(Color.FromArgb((byte)(base.IsMouseOver ? 240u : 150u), byte.MaxValue, byte.MaxValue, byte.MaxValue)), new Pen(Brushes.Red, 1.0), fqB);
		drawingContext.DrawText(formattedText, new Point(3.0, 1.0));
		drawingContext.DrawGeometry(Brushes.Black, null, new PathGeometry(new PathFigure[1]
		{
			new PathFigure(new Point(fqB.Right - 9.0, fqB.Top + (fqB.Height - 3.0) / 2.0), new PathSegment[2]
			{
				new LineSegment(new Point(fqB.Right - 3.0, fqB.Top + (fqB.Height - 3.0) / 2.0), isStroked: false),
				new LineSegment(new Point(fqB.Right - 6.0, fqB.Top + (fqB.Height - 3.0) / 2.0 + 3.0), isStroked: false)
			}, closed: true)
		}));
	}

	protected override void OnIsMouseDirectlyOverChanged(DependencyPropertyChangedEventArgs e)
	{
		base.OnIsMouseDirectlyOverChanged(e);
		InvalidateVisual();
	}

	protected override void OnMouseUp(MouseButtonEventArgs e)
	{
		base.OnMouseUp(e);
		Popup popup = new Popup();
		popup.PlacementTarget = base.AdornedElement;
		popup.PlacementRectangle = fqB;
		popup.Placement = PlacementMode.Bottom;
		popup.StaysOpen = false;
		popup.Child = new LicenseAdornerPopup(uqp);
		popup.IsOpen = true;
	}

	internal static bool lgO()
	{
		return pgN == null;
	}

	internal static LicenseAdorner Agq()
	{
		return pgN;
	}
}
