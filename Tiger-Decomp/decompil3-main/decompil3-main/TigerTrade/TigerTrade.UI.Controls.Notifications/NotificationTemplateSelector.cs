using System.Windows;
using System.Windows.Controls;
using ECOEgqlSad8NUJZ2Dr9n;
using M7Qhok2zS37wTYN0rqJn;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.Controls.Notifications;

internal sealed class NotificationTemplateSelector : DataTemplateSelector
{
	private DataTemplate _defaultStringTemplate;

	private DataTemplate _defaultNotificationTemplate;

	internal static NotificationTemplateSelector KjfP47DBzSZ53bKjXQlT;

	private void GetTemplatesFromResources(FrameworkElement container)
	{
		_defaultStringTemplate = ((container != null) ? fK3Sb3DaH31EUii0jUD1(container, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x706541F3 ^ 0x7065BC55)) : null) as DataTemplate;
		_defaultNotificationTemplate = container?.FindResource(PKk2n9DafKoZaVhVLl5W(-176525661 ^ -176516233)) as DataTemplate;
	}

	public override DataTemplate SelectTemplate(object item, DependencyObject container)
	{
		if (_defaultStringTemplate == null)
		{
			goto IL_0077;
		}
		goto IL_0087;
		IL_0087:
		if (item is string)
		{
			return _defaultStringTemplate;
		}
		if (item is FcjPXM2z5nD8Dwq2mFW6)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				break;
			default:
				return _defaultNotificationTemplate;
			}
			goto IL_0077;
		}
		return base.SelectTemplate(item, container);
		IL_0077:
		if (_defaultNotificationTemplate == null)
		{
			GetTemplatesFromResources((FrameworkElement)container);
		}
		goto IL_0087;
	}

	public NotificationTemplateSelector()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static NotificationTemplateSelector()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object fK3Sb3DaH31EUii0jUD1(object P_0, object P_1)
	{
		return ((FrameworkElement)P_0).FindResource(P_1);
	}

	internal static object PKk2n9DafKoZaVhVLl5W(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool h3COQNDa0ijEVnlo7nnJ()
	{
		return KjfP47DBzSZ53bKjXQlT == null;
	}

	internal static NotificationTemplateSelector vuYkG6Da2vj5csJDMm1e()
	{
		return KjfP47DBzSZ53bKjXQlT;
	}
}
