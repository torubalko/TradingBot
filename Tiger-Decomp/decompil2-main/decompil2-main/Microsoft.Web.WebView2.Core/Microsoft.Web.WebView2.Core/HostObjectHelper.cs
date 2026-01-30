using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core;

[ClassInterface(ClassInterfaceType.AutoDual)]
[ComVisible(true)]
public class HostObjectHelper
{
	private const int DISP_E_MEMBERNOTFOUND = -2147352573;

	private const int DISP_E_TYPEMISMATCH = -2147352571;

	public bool IsMethod(object obj, string name)
	{
		Type type = obj.GetType();
		if (!type.IsClass || type.IsCOMObject)
		{
			throw new COMException(null, -2147352571);
		}
		if (type.GetMember(name).Length == 0)
		{
			throw new COMException(null, -2147352573);
		}
		MemberInfo[] member = type.GetMember(name);
		for (int i = 0; i < member.Length; i++)
		{
			if (member[i].MemberType == MemberTypes.Method)
			{
				return true;
			}
		}
		return false;
	}
}
