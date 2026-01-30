using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;
using ActiproSoftware.Windows.Themes;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

[TemplateVisualState(Name = "SelectedRootSymbolActive", GroupName = "RootSymbolStates")]
[TemplateVisualState(Name = "RootDropDown", GroupName = "DisplayModeStates")]
[TemplateVisualState(Name = "SelectedMemberSymbolActive", GroupName = "MemberSymbolStates")]
[TemplateVisualState(Name = "SelectedMemberSymbolInactive", GroupName = "MemberSymbolStates")]
[TemplateVisualState(Name = "SelectedRootSymbolInactive", GroupName = "RootSymbolStates")]
[TemplateVisualState(Name = "DualDropDown", GroupName = "DisplayModeStates")]
[TemplateVisualState(Name = "MemberDropDown", GroupName = "DisplayModeStates")]
public class NavigableSymbolSelector : Control
{
	private enum gAe
	{
		Selection = 1
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public NavigableSymbolSelector I0b;

		public SyntaxEditor y0T;

		internal static _003C_003Ec__DisplayClass8_0 aNn;

		public _003C_003Ec__DisplayClass8_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void O0H(object o)
		{
			I0b.JaL(y0T.Document);
		}

		internal static bool cNq()
		{
			return aNn == null;
		}

		internal static _003C_003Ec__DisplayClass8_0 pNx()
		{
			return aNn;
		}
	}

	private bool maS;

	private bool Ra9;

	private gAe May;

	private bool jaq;

	public static readonly DependencyProperty AreMemberSymbolsSupportedProperty;

	public static readonly DependencyProperty AreRootSymbolsSupportedProperty;

	public static readonly DependencyProperty IsInSelectedMemberSymbolProperty;

	public static readonly DependencyProperty IsInSelectedRootSymbolProperty;

	public static readonly DependencyProperty MemberSymbolsProperty;

	public static readonly DependencyProperty RootSymbolsProperty;

	public static readonly DependencyProperty SelectedMemberSymbolProperty;

	public static readonly DependencyProperty SelectedRootSymbolProperty;

	public static readonly DependencyProperty SyntaxEditorProperty;

	private string ua2;

	private static NavigableSymbolSelector Q4y;

	public bool AreMemberSymbolsSupported
	{
		get
		{
			return (bool)GetValue(AreMemberSymbolsSupportedProperty);
		}
		set
		{
			SetValue(AreMemberSymbolsSupportedProperty, value);
		}
	}

	public bool AreRootSymbolsSupported
	{
		get
		{
			return (bool)GetValue(AreRootSymbolsSupportedProperty);
		}
		set
		{
			SetValue(AreRootSymbolsSupportedProperty, value);
		}
	}

	public bool IsInSelectedMemberSymbol
	{
		get
		{
			return (bool)GetValue(IsInSelectedMemberSymbolProperty);
		}
		private set
		{
			SetValue(IsInSelectedMemberSymbolProperty, value);
		}
	}

	public bool IsInSelectedRootSymbol
	{
		get
		{
			return (bool)GetValue(IsInSelectedRootSymbolProperty);
		}
		private set
		{
			SetValue(IsInSelectedRootSymbolProperty, value);
		}
	}

	public IEnumerable<INavigableSymbol> MemberSymbols
	{
		get
		{
			return (IEnumerable<INavigableSymbol>)GetValue(MemberSymbolsProperty);
		}
		private set
		{
			SetValue(MemberSymbolsProperty, value);
		}
	}

	public IEnumerable<INavigableSymbol> RootSymbols
	{
		get
		{
			return (IEnumerable<INavigableSymbol>)GetValue(RootSymbolsProperty);
		}
		private set
		{
			SetValue(RootSymbolsProperty, value);
		}
	}

	public INavigableSymbol SelectedMemberSymbol
	{
		get
		{
			return (INavigableSymbol)GetValue(SelectedMemberSymbolProperty);
		}
		set
		{
			SetValue(SelectedMemberSymbolProperty, value);
		}
	}

	public INavigableSymbol SelectedRootSymbol
	{
		get
		{
			return (INavigableSymbol)GetValue(SelectedRootSymbolProperty);
		}
		set
		{
			SetValue(SelectedRootSymbolProperty, value);
		}
	}

	public SyntaxEditor SyntaxEditor
	{
		get
		{
			return (SyntaxEditor)GetValue(SyntaxEditorProperty);
		}
		set
		{
			SetValue(SyntaxEditorProperty, value);
		}
	}

	public NavigableSymbolSelector()
	{
		grA.DaB7cz();
		May = (gAe)0;
		base._002Ector();
		base.DefaultStyleKey = typeof(NavigableSymbolSelector);
	}

	private void Wa1(INavigableSymbol P_0)
	{
		SyntaxEditor syntaxEditor = SyntaxEditor;
		if (syntaxEditor != null && P_0 != null && !P_0.SnapshotRange.IsDeleted)
		{
			TextSnapshotOffset textSnapshotOffset = P_0.NavigationSnapshotOffset ?? new TextSnapshotOffset(P_0.SnapshotRange.Snapshot, P_0.SnapshotRange.StartOffset);
			ITextSnapshot currentSnapshot = syntaxEditor.ActiveView.CurrentSnapshot;
			int num = textSnapshotOffset.Offset;
			if (textSnapshotOffset.Snapshot.Document == currentSnapshot.Document)
			{
				num = textSnapshotOffset.TranslateTo(currentSnapshot, TextOffsetTrackingMode.Negative);
			}
			TextPosition position = currentSnapshot.OffsetToPosition(num);
			syntaxEditor.ActiveView.Scroller.ScrollIntoView(position, scrollToVerticalMiddle: true);
			syntaxEditor.ActiveView.Selection.CaretOffset = num;
			syntaxEditor.ActiveView.Focus();
		}
	}

	private void AaF()
	{
		if (!Ra9)
		{
			Wa1(SelectedMemberSymbol);
		}
	}

	private void pa3()
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals8.I0b = this;
		if (jaq)
		{
			return;
		}
		CS_0024_003C_003E8__locals8.y0T = SyntaxEditor;
		if (maS && CS_0024_003C_003E8__locals8.y0T != null)
		{
			if (May != gAe.Selection && !Ra9)
			{
				Wa1(SelectedRootSymbol);
			}
			vAE.d0c<object>(this, delegate
			{
				CS_0024_003C_003E8__locals8.I0b.JaL(CS_0024_003C_003E8__locals8.y0T.Document);
			}, null);
			return;
		}
		bool ra = Ra9;
		try
		{
			Ra9 = true;
			INavigableSymbolProvider navigableSymbolProvider = ((CS_0024_003C_003E8__locals8.y0T != null) ? CS_0024_003C_003E8__locals8.y0T.Document.Language.GetService<INavigableSymbolProvider>() : null);
			if (navigableSymbolProvider != null)
			{
				TextSnapshotOffset endSnapshotOffset = CS_0024_003C_003E8__locals8.y0T.ActiveView.Selection.EndSnapshotOffset;
				INavigableSymbolSet symbols = navigableSymbolProvider.GetSymbols(NavigableRequestContexts.NavigableSymbolSelector, endSnapshotOffset, SelectedRootSymbol);
				if (symbols != null)
				{
					MemberSymbols = symbols.Symbols;
				}
				else
				{
					MemberSymbols = null;
				}
				pa6(endSnapshotOffset);
			}
			else
			{
				MemberSymbols = null;
				SelectedMemberSymbol = null;
				IsInSelectedMemberSymbol = false;
			}
		}
		finally
		{
			Ra9 = ra;
		}
		if (!Ra9)
		{
			Wa1(SelectedRootSymbol);
		}
	}

	private void TaR(object P_0, EditorDocumentChangedEventArgs P_1)
	{
		Man();
	}

	private void uaY(object P_0, EditorDocumentLanguageChangedEventArgs P_1)
	{
		Man();
	}

	private void da4(object P_0, EventArgs P_1)
	{
		May = (gAe)2;
	}

	private void rao(SyntaxEditor P_0, SyntaxEditor P_1)
	{
		int num = 2;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 1:
					if (flag)
					{
						return;
					}
					if (P_0 == null)
					{
						break;
					}
					goto IL_00a0;
				case 2:
					flag = P_0 == P_1;
					num2 = 1;
					if (U46() == null)
					{
						num2 = 1;
					}
					goto IL_0012;
				}
				if (P_1 != null)
				{
					P_1.DocumentChanged += TaR;
					P_1.DocumentLanguageChanged += uaY;
					P_1.DocumentParseDataChanged += da4;
					P_1.UserInterfaceUpdate += Caj;
					P_1.ViewSelectionChanged += zaw;
				}
				Man();
				return;
				IL_00a0:
				P_0.DocumentChanged -= TaR;
				P_0.DocumentLanguageChanged -= uaY;
				P_0.DocumentParseDataChanged -= da4;
				P_0.UserInterfaceUpdate -= Caj;
				P_0.ViewSelectionChanged -= zaw;
				num2 = 0;
			}
			while (S4h());
		}
	}

	private void Caj(object P_0, EventArgs P_1)
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					goto IL_0072;
				default:
				{
					if (flag)
					{
						return;
					}
					gAe may = May;
					gAe gAe = may;
					if (gAe == gAe.Selection)
					{
						if (SyntaxEditor != null)
						{
							goto case 2;
						}
						break;
					}
					if (gAe == (gAe)2)
					{
						Man();
					}
					break;
				}
				case 2:
					try
					{
						Ra9 = true;
						TextSnapshotOffset endSnapshotOffset = SyntaxEditor.ActiveView.Selection.EndSnapshotOffset;
						if (!SaH(endSnapshotOffset))
						{
							pa6(endSnapshotOffset);
						}
					}
					finally
					{
						Ra9 = false;
					}
					break;
				}
				May = (gAe)0;
				return;
				IL_0072:
				flag = May == (gAe)0;
				num2 = 0;
			}
			while (U46() == null);
		}
	}

	private void zaw(object P_0, EditorViewSelectionEventArgs P_1)
	{
		if (P_1.View.IsActive && May == (gAe)0)
		{
			May = gAe.Selection;
		}
	}

	private void pa6(TextSnapshotOffset? P_0)
	{
		INavigableSymbol navigableSymbol = null;
		bool flag = false;
		if (P_0.HasValue)
		{
			IEnumerable<INavigableSymbol> memberSymbols = MemberSymbols;
			int num = BaT(memberSymbols, P_0.Value);
			navigableSymbol = Rab(memberSymbols, num);
			flag = navigableSymbol != null && (navigableSymbol.SnapshotRange.Contains(num) || num == navigableSymbol.SnapshotRange.EndOffset);
		}
		if (IsInSelectedMemberSymbol != flag)
		{
			IsInSelectedMemberSymbol = flag;
			GaB(_0020: false);
		}
		if (SelectedMemberSymbol != navigableSymbol)
		{
			SelectedMemberSymbol = navigableSymbol;
		}
	}

	private bool SaH(TextSnapshotOffset? P_0)
	{
		INavigableSymbol navigableSymbol = null;
		bool flag = false;
		if (P_0.HasValue)
		{
			IEnumerable<INavigableSymbol> rootSymbols = RootSymbols;
			int num = BaT(rootSymbols, P_0.Value);
			navigableSymbol = Rab(rootSymbols, num);
			flag = navigableSymbol != null && (navigableSymbol.SnapshotRange.Contains(num) || num == navigableSymbol.SnapshotRange.EndOffset);
		}
		if (IsInSelectedRootSymbol != flag)
		{
			IsInSelectedRootSymbol = flag;
			GaB(_0020: false);
		}
		if (SelectedRootSymbol != navigableSymbol)
		{
			SelectedRootSymbol = navigableSymbol;
			return true;
		}
		return false;
	}

	private static INavigableSymbol Rab(IEnumerable<INavigableSymbol> P_0, int P_1)
	{
		if (P_0 != null)
		{
			INavigableSymbol navigableSymbol = null;
			INavigableSymbol navigableSymbol2 = null;
			INavigableSymbol navigableSymbol3 = null;
			foreach (INavigableSymbol item in P_0)
			{
				if (item == null || item.SnapshotRange.IsDeleted)
				{
					continue;
				}
				if (item.SnapshotRange.Contains(P_1))
				{
					if (navigableSymbol2 == null || item.SnapshotRange.StartOffset > navigableSymbol2.SnapshotRange.StartOffset)
					{
						navigableSymbol2 = item;
					}
				}
				else if (navigableSymbol2 == null && (P_1 == item.SnapshotRange.EndOffset || P_1 < item.SnapshotRange.StartOffset) && (navigableSymbol == null || item.SnapshotRange.StartOffset < navigableSymbol.SnapshotRange.StartOffset))
				{
					navigableSymbol = item;
				}
				if (navigableSymbol3 == null || item.SnapshotRange.EndOffset > navigableSymbol3.SnapshotRange.EndOffset)
				{
					navigableSymbol3 = item;
				}
			}
			return navigableSymbol2 ?? navigableSymbol ?? navigableSymbol3;
		}
		return null;
	}

	private static int BaT(IEnumerable<INavigableSymbol> P_0, TextSnapshotOffset P_1)
	{
		int offset = P_1.Offset;
		if (P_0 != null)
		{
			INavigableSymbol navigableSymbol = P_0.FirstOrDefault();
			if (navigableSymbol != null && navigableSymbol.SnapshotRange.Snapshot != null && navigableSymbol.SnapshotRange.Snapshot.Document == P_1.Snapshot.Document)
			{
				offset = P_1.TranslateTo(navigableSymbol.SnapshotRange.Snapshot, TextOffsetTrackingMode.Negative).Offset;
			}
		}
		return offset;
	}

	private void JaL(ICodeDocument P_0)
	{
		ua2 = ThemeManager.CurrentTheme;
		May = (gAe)0;
		try
		{
			jaq = true;
			Ra9 = true;
			INavigableSymbolProvider navigableSymbolProvider = P_0?.Language.GetService<INavigableSymbolProvider>();
			if (navigableSymbolProvider != null && SyntaxEditor != null)
			{
				TextSnapshotOffset endSnapshotOffset = SyntaxEditor.ActiveView.Selection.EndSnapshotOffset;
				INavigableSymbolSet symbols = navigableSymbolProvider.GetSymbols(NavigableRequestContexts.NavigableSymbolSelector, endSnapshotOffset, null);
				if (symbols != null)
				{
					maS = symbols.IsPartial;
					RootSymbols = symbols.Symbols;
				}
				else
				{
					maS = false;
					RootSymbols = null;
				}
				SaH(endSnapshotOffset);
				INavigableSymbolSet symbols2 = navigableSymbolProvider.GetSymbols(NavigableRequestContexts.NavigableSymbolSelector, endSnapshotOffset, SelectedRootSymbol);
				if (symbols2 != null)
				{
					MemberSymbols = symbols2.Symbols;
				}
				else
				{
					MemberSymbols = null;
				}
				pa6(endSnapshotOffset);
			}
			else
			{
				if (IsInSelectedRootSymbol || IsInSelectedMemberSymbol)
				{
					IsInSelectedRootSymbol = false;
					IsInSelectedMemberSymbol = false;
					GaB(_0020: false);
				}
				maS = false;
				RootSymbols = null;
				MemberSymbols = null;
				SelectedRootSymbol = null;
				SelectedMemberSymbol = null;
			}
		}
		finally
		{
			jaq = false;
			Ra9 = false;
		}
	}

	private void Man()
	{
		JaL((SyntaxEditor != null) ? SyntaxEditor.Document : null);
	}

	private static void Ga8(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		NavigableSymbolSelector navigableSymbolSelector = (NavigableSymbolSelector)P_0;
		navigableSymbolSelector.InvalidateMeasure();
		navigableSymbolSelector.GaB(_0020: false);
	}

	private static void FaI(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		NavigableSymbolSelector navigableSymbolSelector = (NavigableSymbolSelector)P_0;
		navigableSymbolSelector.AaF();
	}

	private static void Ja5(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		NavigableSymbolSelector navigableSymbolSelector = (NavigableSymbolSelector)P_0;
		navigableSymbolSelector.pa3();
	}

	private static void La0(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		NavigableSymbolSelector navigableSymbolSelector = (NavigableSymbolSelector)P_0;
		bool flag = true;
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_1.OldValue;
		SyntaxEditor syntaxEditor2 = (SyntaxEditor)P_1.NewValue;
		navigableSymbolSelector.rao(syntaxEditor, syntaxEditor2);
	}

	private void GaB(bool P_0)
	{
		if (IsInSelectedRootSymbol)
		{
			VisualStateManager.GoToState(this, Q7Z.tqM(1020), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, Q7Z.tqM(1072), P_0);
		}
		if (IsInSelectedMemberSymbol)
		{
			VisualStateManager.GoToState(this, Q7Z.tqM(1128), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, Q7Z.tqM(1184), P_0);
		}
		if (!AreMemberSymbolsSupported)
		{
			VisualStateManager.GoToState(this, Q7Z.tqM(1304), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, AreRootSymbolsSupported ? Q7Z.tqM(1276) : Q7Z.tqM(1244), P_0);
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		GaB(_0020: false);
	}

	protected override void OnRender(DrawingContext drawingContext)
	{
		if (ThemeManager.CurrentTheme != ua2)
		{
			Man();
		}
		base.OnRender(drawingContext);
	}

	static NavigableSymbolSelector()
	{
		grA.DaB7cz();
		AreMemberSymbolsSupportedProperty = DependencyProperty.Register(Q7Z.tqM(1332), typeof(bool), typeof(NavigableSymbolSelector), new PropertyMetadata(true, Ga8));
		AreRootSymbolsSupportedProperty = DependencyProperty.Register(Q7Z.tqM(1386), typeof(bool), typeof(NavigableSymbolSelector), new PropertyMetadata(true, Ga8));
		IsInSelectedMemberSymbolProperty = DependencyProperty.Register(Q7Z.tqM(1436), typeof(bool), typeof(NavigableSymbolSelector), new PropertyMetadata(false));
		IsInSelectedRootSymbolProperty = DependencyProperty.Register(Q7Z.tqM(1488), typeof(bool), typeof(NavigableSymbolSelector), new PropertyMetadata(false));
		MemberSymbolsProperty = DependencyProperty.Register(Q7Z.tqM(1536), typeof(IEnumerable<INavigableSymbol>), typeof(NavigableSymbolSelector), new PropertyMetadata(null));
		RootSymbolsProperty = DependencyProperty.Register(Q7Z.tqM(1566), typeof(IEnumerable<INavigableSymbol>), typeof(NavigableSymbolSelector), new PropertyMetadata(null));
		SelectedMemberSymbolProperty = DependencyProperty.Register(Q7Z.tqM(1592), typeof(INavigableSymbol), typeof(NavigableSymbolSelector), new PropertyMetadata(null, FaI));
		SelectedRootSymbolProperty = DependencyProperty.Register(Q7Z.tqM(1636), typeof(INavigableSymbol), typeof(NavigableSymbolSelector), new PropertyMetadata(null, Ja5));
		SyntaxEditorProperty = DependencyProperty.Register(Q7Z.tqM(1676), typeof(SyntaxEditor), typeof(NavigableSymbolSelector), new PropertyMetadata(null, La0));
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool S4h()
	{
		return Q4y == null;
	}

	internal static NavigableSymbolSelector U46()
	{
		return Q4y;
	}
}
