using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using ECOEgqlSad8NUJZ2Dr9n;
using lD5TUC1oYhVR4AjY0ZM;
using TcT9rJO5gOcIpqjOffS;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;

namespace CgZMeMO4gjZ3K8fl2rZ;

public class vmqWV2OlMO6iRopEpHv : UserControl, IComponentConnector
{
	public enum bH42VTnLyhei6qkQHNon
	{

	}

	private bool SI0OkCmluP;

	internal static vmqWV2OlMO6iRopEpHv qq1wf64BtFOrEcOua0OR;

	public vmqWV2OlMO6iRopEpHv()
	{
		UqKkm44ByGAiQ8uEQ2YH();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	public static bool MFEODRh7iE(string P_0, string P_1, bH42VTnLyhei6qkQHNon P_2, Window P_3 = null)
	{
		return dDGOb77pG7(P_0, P_1, RfXONhn1tE(P_2), P_3);
	}

	public static bool dDGOb77pG7(string P_0, string P_1, string P_2, Window P_3 = null)
	{
		tLdtBwO1ff36HsmTYfe obj = new tLdtBwO1ff36HsmTYfe
		{
			Caption = P_0
		};
		dKquvO4BZJCqsJgKvKEY(obj, P_1);
		vTuKPo4BVnULqVwBwIdi(obj, P_2);
		MXK7ZO1Y0M3if7KwDfj.BJn1BymkrG(obj, null, P_3);
		return asj9cZ4BCSQVckUeMmAZ(obj);
	}

	private static string RfXONhn1tE(bH42VTnLyhei6qkQHNon P_0)
	{
		switch (P_0)
		{
		case (bH42VTnLyhei6qkQHNon)0:
			return (string)xqk4r54Br5beEXP8MMKc();
		case (bH42VTnLyhei6qkQHNon)1:
			return TigerTrade.Properties.Resources.OnboardingMessageBoxGotItButton;
		default:
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => TigerTrade.Properties.Resources.OnboardingMessageBoxOkButton, 
			};
		}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!SI0OkCmluP)
		{
			SI0OkCmluP = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Uri uri = new Uri((string)nO87QQ4BKa4siUW76pq9(0x6D18F862 ^ 0x6D18BF12), UriKind.Relative);
			FsRWyF4Bm3qW67Cj7e1k(this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		SI0OkCmluP = true;
	}

	static vmqWV2OlMO6iRopEpHv()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void UqKkm44ByGAiQ8uEQ2YH()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool ypWEjr4BUcCiQLyTR2sm()
	{
		return qq1wf64BtFOrEcOua0OR == null;
	}

	internal static vmqWV2OlMO6iRopEpHv nZ6jaR4BT2ujjqgOgReF()
	{
		return qq1wf64BtFOrEcOua0OR;
	}

	internal static void dKquvO4BZJCqsJgKvKEY(object P_0, object P_1)
	{
		((tLdtBwO1ff36HsmTYfe)P_0).Description = (string)P_1;
	}

	internal static void vTuKPo4BVnULqVwBwIdi(object P_0, object P_1)
	{
		((tLdtBwO1ff36HsmTYfe)P_0).ButtonText = (string)P_1;
	}

	internal static bool asj9cZ4BCSQVckUeMmAZ(object P_0)
	{
		return ((tLdtBwO1ff36HsmTYfe)P_0).IsClosed;
	}

	internal static object xqk4r54Br5beEXP8MMKc()
	{
		return TigerTrade.Properties.Resources.OnboardingMessageBoxOkButton;
	}

	internal static object nO87QQ4BKa4siUW76pq9(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void FsRWyF4Bm3qW67Cj7e1k(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}
}
