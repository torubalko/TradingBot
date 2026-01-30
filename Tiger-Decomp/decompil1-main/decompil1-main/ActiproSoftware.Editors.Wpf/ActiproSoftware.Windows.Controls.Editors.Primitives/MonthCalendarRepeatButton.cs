using System.ComponentModel;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[ToolboxItem(false)]
public class MonthCalendarRepeatButton : RepeatButton
{
	private static MonthCalendarRepeatButton njb;

	protected override void OnLostMouseCapture(MouseEventArgs e)
	{
		if (e != null && e.OriginalSource == this && base.TemplatedParent is MonthCalendar monthCalendar)
		{
			monthCalendar.Focus();
		}
		base.OnLostMouseCapture(e);
	}

	public MonthCalendarRepeatButton()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool djd()
	{
		return njb == null;
	}

	internal static MonthCalendarRepeatButton mjv()
	{
		return njb;
	}
}
