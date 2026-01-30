using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2HostObjectHelper
{
	private class RawHelper : ICoreWebView2StagingHostObjectHelper
	{
		private const int DISP_E_MEMBERNOTFOUND = -2147352573;

		private const int DISP_E_TYPEMISMATCH = -2147352571;

		private const int WIN_BOOL_TRUE = 1;

		private const int WIN_BOOL_FALSE = 0;

		public int IsMethodMember(ref object rawObject, string memberName)
		{
			Type type = rawObject.GetType();
			if (!type.IsClass || type.IsCOMObject)
			{
				throw new COMException(null, -2147352571);
			}
			if (type.GetMember(memberName).Length == 0)
			{
				throw new COMException(null, -2147352573);
			}
			MemberInfo[] member = type.GetMember(memberName);
			for (int i = 0; i < member.Length; i++)
			{
				if (member[i].MemberType == MemberTypes.Method)
				{
					return 1;
				}
			}
			return 0;
		}
	}

	internal ICoreWebView2StagingHostObjectHelper _nativeICoreWebView2StagingHostObjectHelper;

	private void Initialize()
	{
		_nativeICoreWebView2StagingHostObjectHelper = new RawHelper();
	}

	internal CoreWebView2HostObjectHelper(object rawCoreWebView2HostObjectHelper)
	{
		_nativeICoreWebView2StagingHostObjectHelper = (ICoreWebView2StagingHostObjectHelper)rawCoreWebView2HostObjectHelper;
		Initialize();
	}

	public int IsMethodMember(object rawObject, string memberName)
	{
		return _nativeICoreWebView2StagingHostObjectHelper.IsMethodMember(ref rawObject, memberName);
	}

	internal CoreWebView2HostObjectHelper()
	{
		Initialize();
	}
}
