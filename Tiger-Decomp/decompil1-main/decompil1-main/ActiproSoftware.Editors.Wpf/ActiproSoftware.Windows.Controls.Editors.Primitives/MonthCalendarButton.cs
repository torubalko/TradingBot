using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[ToolboxItem(false)]
public class MonthCalendarButton : Button
{
	private static MonthCalendarButton zjC;

	protected override void OnLostMouseCapture(MouseEventArgs e)
	{
		if (e != null && e.OriginalSource == this && base.TemplatedParent is MonthCalendar monthCalendar)
		{
			monthCalendar.Focus();
		}
		base.OnLostMouseCapture(e);
	}

	public MonthCalendarButton()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool ajE()
	{
		return zjC == null;
	}

	internal static MonthCalendarButton Pj3()
	{
		return zjC;
	}
}
