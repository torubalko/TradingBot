using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using ActiproSoftware.Windows.Controls;
using ciQ7MQHkM693awgKHy3A;
using ECOEgqlSad8NUJZ2Dr9n;
using PRwo7j2JwPH2wR5oDfhn;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace TigerTrade.UI.Controls.SymbolSearch;

internal sealed class SymbolSearchCombo : aUQvKjHk6H77hbYGG0GM, IComponentConnector
{
	private string _symbolName;

	public static readonly DependencyProperty SelectedSymbolProperty;

	internal PopupButton PopupButton;

	internal aotaDg2JhsIDP0L6eD4o SymbolSearchControl;

	private bool _contentLoaded;

	internal static SymbolSearchCombo tQVs8ZDYDcL4fGJv9SRL;

	public string SymbolName
	{
		get
		{
			return _symbolName;
		}
		set
		{
			if (!(value == _symbolName))
			{
				_symbolName = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				cY7HkOvo1nf((string)ION667DYkhhi9HUGH0aC(-1763895751 ^ -1763877849));
			}
		}
	}

	public string SelectedSymbol
	{
		get
		{
			return (string)GetValue(SelectedSymbolProperty);
		}
		set
		{
			SetValue(SelectedSymbolProperty, value);
		}
	}

	private static void PropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
	{
		if (!(dependencyObject is SymbolSearchCombo symbolSearchCombo))
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			Symbol symbol = (Symbol)jZXggtDY1QZTZFdBDpm9(args.NewValue as string);
			YjbxHxDY5wnIagwLn4vW(symbolSearchCombo, (symbol != null) ? symbol.Name : "");
		}
	}

	public SymbolSearchCombo()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	private void SymbolSearchControl_SymbolSelected(Symbol symbol)
	{
		SelectedSymbol = (string)((symbol != null) ? I4f4OgDYSsxhaimYBrQb(symbol) : "");
		PopupButton.IsPopupOpen = false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x37B74BDF ^ 0x37B7A4B3), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)GGYf7FDYxGQ9H0tmCIyj(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (connectionId != 2)
				{
					_contentLoaded = true;
				}
				else
				{
					SymbolSearchControl = (aotaDg2JhsIDP0L6eD4o)target;
				}
				return;
			case 1:
				if (connectionId != 1)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				break;
			}
			break;
		}
		PopupButton = (PopupButton)target;
	}

	static SymbolSearchCombo()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				SelectedSymbolProperty = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4662F6AF ^ 0x4662DAEB), vSlfImDYL0itVwQHMC9x(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777226)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555153)), new PropertyMetadata("", PropertyChangedCallback));
				return;
			case 1:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object ION667DYkhhi9HUGH0aC(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool Ph62xuDYbTI35qnNUIyt()
	{
		return tQVs8ZDYDcL4fGJv9SRL == null;
	}

	internal static SymbolSearchCombo wOwyjJDYNdoSLNUlmKlf()
	{
		return tQVs8ZDYDcL4fGJv9SRL;
	}

	internal static object jZXggtDY1QZTZFdBDpm9(object P_0)
	{
		return SymbolManager.Get((string)P_0);
	}

	internal static void YjbxHxDY5wnIagwLn4vW(object P_0, object P_1)
	{
		((SymbolSearchCombo)P_0).SymbolName = (string)P_1;
	}

	internal static object I4f4OgDYSsxhaimYBrQb(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static object GGYf7FDYxGQ9H0tmCIyj(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static Type vSlfImDYL0itVwQHMC9x(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
