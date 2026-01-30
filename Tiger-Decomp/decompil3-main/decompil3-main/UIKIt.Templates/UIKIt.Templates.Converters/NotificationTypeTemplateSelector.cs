using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using frv4s5X5SOo66jNvMvO6;
using hkZMMTXxD6qN8IAyOFGI;
using PWXKwRXxL9cVgWUpa4xk;
using UIKit.Core;

namespace UIKIt.Templates.Converters;

internal class NotificationTypeTemplateSelector : DataTemplateSelector
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DataTemplate k6Il28uU25Y;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DataTemplate riAl2AHyex5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DataTemplate PQIl2PaWKCq;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DataTemplate VyIl2JesDHJ;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DataTemplate aMIl2F2rCdO;

	internal static NotificationTypeTemplateSelector m7F359XgoeJrarWQGEwO;

	public DataTemplate NoneDataTemplate
	{
		[CompilerGenerated]
		get
		{
			return k6Il28uU25Y;
		}
		[CompilerGenerated]
		set
		{
			k6Il28uU25Y = dataTemplate;
		}
	}

	public DataTemplate ErrorDataTemplate
	{
		[CompilerGenerated]
		get
		{
			return riAl2AHyex5;
		}
		[CompilerGenerated]
		set
		{
			riAl2AHyex5 = dataTemplate;
		}
	}

	public DataTemplate SuccessDataTemplate
	{
		[CompilerGenerated]
		get
		{
			return PQIl2PaWKCq;
		}
		[CompilerGenerated]
		set
		{
			PQIl2PaWKCq = pQIl2PaWKCq;
		}
	}

	public DataTemplate InfoDataTemplate
	{
		[CompilerGenerated]
		get
		{
			return VyIl2JesDHJ;
		}
		[CompilerGenerated]
		set
		{
			VyIl2JesDHJ = vyIl2JesDHJ;
		}
	}

	public DataTemplate Value
	{
		[CompilerGenerated]
		get
		{
			return aMIl2F2rCdO;
		}
		[CompilerGenerated]
		set
		{
			aMIl2F2rCdO = dataTemplate;
		}
	}

	public override DataTemplate SelectTemplate(object P_0, DependencyObject P_1)
	{
		DataTemplate result = default(DataTemplate);
		if (P_0 is NotificationType)
		{
			NotificationType notificationType3 = default(NotificationType);
			while (true)
			{
				IL_0121:
				NotificationType notificationType = (NotificationType)P_0;
				if (1 == 0)
				{
					break;
				}
				NotificationType notificationType2 = notificationType;
				int num = 7;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 7:
						notificationType3 = notificationType2;
						num2 = 0;
						if (_003CModule_003E_007Babb06716_002D70a8_002D4032_002Db545_002D6fbf61bd2cd6_007D.m_64afb0d06e7044f8a16dc1f69baa7641 == 0)
						{
							num2 = 0;
						}
						continue;
					case 3:
						result = NoneDataTemplate;
						goto end_IL_0009;
					case 2:
						break;
					case 1:
					case 4:
					case 6:
					case 8:
						goto end_IL_0009;
					case 5:
						goto IL_0121;
					default:
						goto IL_0166;
					}
					goto IL_00b8;
					IL_0166:
					switch (notificationType3)
					{
					case NotificationType.Info:
						break;
					case NotificationType.None:
						goto IL_0078;
					case NotificationType.Success:
						goto IL_009c;
					case NotificationType.Error:
						goto IL_00b8;
					default:
						goto IL_017d;
					}
					result = InfoDataTemplate;
					num2 = 4;
					continue;
					IL_017d:
					num2 = 3;
					continue;
					IL_009c:
					result = SuccessDataTemplate;
					num2 = 6;
					continue;
					IL_0078:
					result = NoneDataTemplate;
					break;
					IL_00b8:
					result = ErrorDataTemplate;
					num2 = 8;
					if (_003CModule_003E_007Babb06716_002D70a8_002D4032_002Db545_002D6fbf61bd2cd6_007D.m_cc37f370120c4959b570f52e125ce084 == 0)
					{
						num2 = 1;
					}
					continue;
					end_IL_0009:
					break;
				}
				goto IL_00e4;
			}
		}
		result = NoneDataTemplate;
		goto IL_00e4;
		IL_00e4:
		return result;
	}

	public NotificationTypeTemplateSelector()
	{
		Gn8wU4Xx4ZYh48eQvpr3.zPVXtYYvGYD();
		base._002Ector();
	}

	static NotificationTypeTemplateSelector()
	{
		RMpEErX55SDH1mxasQVF.v64X5Ol3UFK();
		inixpGXxxRbVxvw72CyL.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool MtdlvxXgv6GHj8Sxxj4F()
	{
		return m7F359XgoeJrarWQGEwO == null;
	}

	internal static NotificationTypeTemplateSelector b8PsvMXgBkLDooaS6U59()
	{
		return m7F359XgoeJrarWQGEwO;
	}
}
