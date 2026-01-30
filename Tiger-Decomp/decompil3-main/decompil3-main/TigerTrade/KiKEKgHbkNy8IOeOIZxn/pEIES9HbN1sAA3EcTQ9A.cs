using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace KiKEKgHbkNy8IOeOIZxn;

internal class pEIES9HbN1sAA3EcTQ9A : DataTemplateSelector
{
	[CompilerGenerated]
	private DataTemplate i28HbLmOHrm;

	[CompilerGenerated]
	private DataTemplate EnrHbeFpoQL;

	private static pEIES9HbN1sAA3EcTQ9A nQ0fS4DSNqq6iItkUjKU;

	public DataTemplate NullOrEmptyValue
	{
		[CompilerGenerated]
		get
		{
			return i28HbLmOHrm;
		}
		[CompilerGenerated]
		set
		{
			i28HbLmOHrm = dataTemplate;
		}
	}

	public DataTemplate Value
	{
		[CompilerGenerated]
		get
		{
			return EnrHbeFpoQL;
		}
		[CompilerGenerated]
		set
		{
			EnrHbeFpoQL = enrHbeFpoQL;
		}
	}

	public override DataTemplate SelectTemplate(object P_0, DependencyObject P_1)
	{
		string value = P_0 as string;
		if (P_0 != null)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			if (!string.IsNullOrEmpty(value))
			{
				return Value;
			}
		}
		return NullOrEmptyValue;
	}

	public pEIES9HbN1sAA3EcTQ9A()
	{
		llh4JrDS5HeAlASKdcQl();
		base._002Ector();
	}

	static pEIES9HbN1sAA3EcTQ9A()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool JDkQ4UDSkbOAeKbXD7SF()
	{
		return nQ0fS4DSNqq6iItkUjKU == null;
	}

	internal static pEIES9HbN1sAA3EcTQ9A OV937DDS1Surv5W4hPqu()
	{
		return nQ0fS4DSNqq6iItkUjKU;
	}

	internal static void llh4JrDS5HeAlASKdcQl()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}
}
