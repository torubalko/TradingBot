using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Text.Tagging.Implementation;

public class BreakpointIndicatorTag : IndicatorClassificationTagBase, INotifyPropertyChanged
{
	private bool L8M;

	internal static BreakpointIndicatorTag X5l;

	public override IClassificationType ClassificationType => L8M ? cT.BreakpointEnabled : cT.BreakpointDisabled;

	public bool IsEnabled
	{
		get
		{
			return L8M;
		}
		set
		{
			if (L8M != value)
			{
				L8M = value;
				NotifyPropertyChanged(Q7Z.tqM(197946));
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	public override void DrawGlyph(TextViewDrawContext context, ITextViewLine viewLine, TagSnapshotRange<IIndicatorTag> tagRange, Rect bounds)
	{
		if (context == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7756));
		}
		Point location = GetLocation(bounds);
		Size glyphSize = GlyphSize;
		Color color = Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
		Color color2 = Color.FromArgb(byte.MaxValue, 229, 21, 0);
		int num = (int)Math.Max(9.0, Math.Min(bounds.Width, bounds.Height) - 2.0);
		if (num % 2 == 0)
		{
			num++;
		}
		location.X += (int)Math.Round((glyphSize.Width - (double)num) / 2.0, MidpointRounding.AwayFromZero);
		location.Y += (int)Math.Round((glyphSize.Height - (double)num) / 2.0, MidpointRounding.AwayFromZero);
		context.FillEllipse(new Rect(location.X, location.Y, num, num), color);
		location.X += 1.0;
		location.Y += 1.0;
		num -= 2;
		if (IsEnabled)
		{
			context.FillEllipse(new Rect(location.X, location.Y, num, num), color2);
		}
		else
		{
			context.DrawEllipse(new Rect(location.X + 0.5, location.Y + 0.5, num - 1, num - 1), color2, LineKind.Solid, 1f);
		}
	}

	protected void NotifyPropertyChanged(string propertyName)
	{
		OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
	}

	protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
	{
		this.PropertyChanged?.Invoke(this, e);
	}

	public BreakpointIndicatorTag()
	{
		grA.DaB7cz();
		L8M = true;
		base._002Ector();
	}

	internal static bool l5W()
	{
		return X5l == null;
	}

	internal static BreakpointIndicatorTag j5S()
	{
		return X5l;
	}
}
