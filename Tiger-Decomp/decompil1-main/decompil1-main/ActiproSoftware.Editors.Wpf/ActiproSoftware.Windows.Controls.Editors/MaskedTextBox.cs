using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using ActiproSoftware.Internal;
using ActiproSoftware.Products;
using ActiproSoftware.Products.Editors;

namespace ActiproSoftware.Windows.Controls.Editors;

[SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
public class MaskedTextBox : TextBox
{
	private enum pdq
	{
		Default
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public MaskedTextBox kuJ;

		public int zue;

		private static _003C_003Ec__DisplayClass58_0 etp;

		public _003C_003Ec__DisplayClass58_0()
		{
			awj.QuEwGz();
			base._002Ector();
		}

		internal void yun()
		{
			if (kuJ.k2G == zue)
			{
				kuJ.d2f(pdq.Default);
			}
		}

		internal static bool nt4()
		{
			return etp == null;
		}

		internal static _003C_003Ec__DisplayClass58_0 wt0()
		{
			return etp;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "AutoCorrected")]
	public static readonly DependencyProperty IsCaseAutoCorrectedProperty;

	public static readonly DependencyProperty IsCaseSensitiveProperty;

	public static readonly DependencyProperty IsMatchedProperty;

	public static readonly DependencyProperty MaskProperty;

	public static readonly DependencyProperty MaskKindProperty;

	public static readonly DependencyProperty MatchedTextProperty;

	public static readonly DependencyProperty PromptCharProperty;

	public static readonly DependencyProperty PromptVisibilityProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler d2g;

	private bool n2o;

	private bool L2O;

	private bool y2T;

	private int B2I;

	private int Y2b;

	private string p2D;

	private int k2G;

	private string H2q;

	private C1 a2u;

	internal static MaskedTextBox hWC;

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "AutoCorrected")]
	public bool IsCaseAutoCorrected
	{
		get
		{
			return (bool)GetValue(IsCaseAutoCorrectedProperty);
		}
		set
		{
			SetValue(IsCaseAutoCorrectedProperty, value);
		}
	}

	public bool IsCaseSensitive
	{
		get
		{
			return (bool)GetValue(IsCaseSensitiveProperty);
		}
		set
		{
			SetValue(IsCaseSensitiveProperty, value);
		}
	}

	public bool IsMatched
	{
		get
		{
			return (bool)GetValue(IsMatchedProperty);
		}
		private set
		{
			SetValue(IsMatchedProperty, value);
		}
	}

	public string Mask
	{
		get
		{
			return (string)GetValue(MaskProperty);
		}
		set
		{
			SetValue(MaskProperty, value);
		}
	}

	public MaskKind MaskKind
	{
		get
		{
			return (MaskKind)GetValue(MaskKindProperty);
		}
		set
		{
			SetValue(MaskKindProperty, value);
		}
	}

	public string MatchedText
	{
		get
		{
			return (string)GetValue(MatchedTextProperty);
		}
		set
		{
			SetValue(MatchedTextProperty, value);
		}
	}

	public char PromptChar
	{
		get
		{
			return (char)GetValue(PromptCharProperty);
		}
		set
		{
			SetValue(PromptCharProperty, value);
		}
	}

	public MaskPromptVisibility PromptVisibility
	{
		get
		{
			return (MaskPromptVisibility)GetValue(PromptVisibilityProperty);
		}
		set
		{
			SetValue(PromptVisibilityProperty, value);
		}
	}

	public event EventHandler IsMatchedChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = d2g;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref d2g, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = d2g;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref d2g, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public MaskedTextBox()
	{
		awj.QuEwGz();
		p2D = string.Empty;
		base._002Ector();
		base.DefaultStyleKey = typeof(MaskedTextBox);
		ActiproLicenseValidator.ValidateLicense(ActiproSoftware.Products.Editors.AssemblyInfo.Instance, GetType(), this);
		base.SelectionChanged += y2P;
		base.TextChanged += s22;
	}

	private static void mPz(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		MaskedTextBox maskedTextBox = (MaskedTextBox)P_0;
		maskedTextBox.S26();
	}

	private static void e2Q(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		MaskedTextBox maskedTextBox = (MaskedTextBox)P_0;
		if (!maskedTextBox.y2T)
		{
			maskedTextBox.Text = maskedTextBox.MatchedText;
		}
	}

	private static void B2V(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		MaskedTextBox maskedTextBox = (MaskedTextBox)P_0;
		maskedTextBox.d2f(pdq.Default);
	}

	private static void F2C(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		MaskedTextBox maskedTextBox = (MaskedTextBox)P_0;
		maskedTextBox.q2a();
	}

	private void S26()
	{
		d2g?.Invoke(this, EventArgs.Empty);
	}

	[SpecialName]
	private bool t20()
	{
		return PromptVisibility switch
		{
			MaskPromptVisibility.FocusedOnly => Ad6.cuR() == this, 
			MaskPromptVisibility.Always => true, 
			_ => false, 
		};
	}

	private string m2M()
	{
		if (H2q == null)
		{
			H2q = Mask;
			if (H2q != null)
			{
				MaskKind maskKind = MaskKind;
				MaskKind maskKind2 = maskKind;
				if (maskKind2 == MaskKind.Wildcard)
				{
					H2q = vO.roi(H2q);
				}
			}
			if (H2q == null)
			{
				H2q = string.Empty;
			}
		}
		return H2q;
	}

	private C1 I2s()
	{
		if (a2u == null)
		{
			string text = m2M();
			if (!string.IsNullOrEmpty(text))
			{
				fw fw = (IsCaseAutoCorrected ? fw.a05 : ((!IsCaseSensitive) ? ((fw)1) : ((fw)0)));
				try
				{
					XA xA = new Jj().pou(QdM.AR8(18652) + text + QdM.AR8(18658), fw);
					a2u = new p4().ios(xA, PromptChar, _0020: false);
				}
				catch (oG)
				{
				}
			}
		}
		return a2u;
	}

	private void A2j()
	{
		H2q = null;
		a2u = null;
	}

	private void y2P(object P_0, RoutedEventArgs P_1)
	{
		if (n2o && t20())
		{
			string matchedText = MatchedText;
			if (matchedText != null && base.SelectionStart > matchedText.Length)
			{
				base.SelectionStart = matchedText.Length;
				base.SelectionLength = 0;
			}
		}
		Y2b = base.SelectionStart;
		B2I = base.SelectionLength;
	}

	private void s22(object P_0, TextChangedEventArgs P_1)
	{
		if (!L2O)
		{
			d2f((pdq)1);
		}
	}

	private void q2a()
	{
		_003C_003Ec__DisplayClass58_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass58_0();
		CS_0024_003C_003E8__locals5.kuJ = this;
		k2G = (k2G + 1) % 1000;
		CS_0024_003C_003E8__locals5.zue = k2G;
		A2j();
		base.Dispatcher.BeginInvoke(DispatcherPriority.Send, (Action)delegate
		{
			if (CS_0024_003C_003E8__locals5.kuJ.k2G == CS_0024_003C_003E8__locals5.zue)
			{
				CS_0024_003C_003E8__locals5.kuJ.d2f(pdq.Default);
			}
		});
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void d2f(pdq P_0)
	{
		C1 c = I2s();
		if (c == null)
		{
			IsMatched = false;
			return;
		}
		string text = base.Text;
		bool flag = t20();
		char promptChar = PromptChar;
		if (flag && P_0 == (pdq)1 && base.SelectionStart == Y2b + 1 && base.SelectionLength == 0)
		{
			if (text.Length > 0 && text[0] == promptChar && Y2b > 0 && text.StartsWith(new string(promptChar, Y2b), StringComparison.OrdinalIgnoreCase))
			{
				text = text.Substring(Y2b);
				base.SelectionStart -= Y2b;
			}
			else if (Y2b + 1 < text.Length && text[Y2b + 1] == promptChar)
			{
				text = text.Substring(0, Y2b + 1) + text.Substring(Y2b + 2);
			}
		}
		string text2 = text;
		if (flag)
		{
			int num = text2.IndexOf(promptChar);
			if (num != -1)
			{
				text2 = text2.Substring(0, num);
			}
		}
		tk tk = c.pgi(text, flag);
		bool flag2 = Y2b == 1 && base.SelectionStart == 0 && base.SelectionLength == 0;
		if (!tk.lY7() && P_0 == (pdq)1 && !flag2 && text2.Length > 0)
		{
			M2X(p2D);
			base.SelectionStart = Y2b;
			base.SelectionLength = B2I;
			return;
		}
		if (tk.lY7() && P_0 == (pdq)1 && text2.Length > Y2b && tk.MatchedText.Length > 0 && tk.MatchedText.Length < MatchedText.Length && Y2b == tk.MatchedText.Length)
		{
			M2X(p2D);
			base.SelectionStart = Y2b;
			base.SelectionLength = B2I;
			return;
		}
		int y2b = Y2b;
		int b2I = B2I;
		string text3 = p2D;
		Y2b = base.SelectionStart;
		B2I = base.SelectionLength;
		p2D = tk.UYn();
		M2X(p2D);
		switch (P_0)
		{
		case (pdq)2:
		{
			int j;
			for (j = Y2b; j < tk.UYn().Length && tk.BYU().Contains(j); j++)
			{
			}
			if (j != Y2b)
			{
				base.SelectionStart = j;
				base.SelectionLength = 0;
			}
			break;
		}
		case (pdq)1:
		{
			if (text.Length == p2D.Length - 1 && b2I == 0 && B2I == 0 && ((y2b > 0 && y2b - 1 <= text.Length && text == p2D.Substring(0, y2b - 1) + p2D.Substring(y2b)) || (y2b < p2D.Length && text == p2D.Substring(0, y2b) + p2D.Substring(y2b + 1))))
			{
				break;
			}
			if (flag && text3 == p2D && y2b < text3.Length && text3[y2b] == promptChar)
			{
				base.SelectionStart = y2b;
				base.SelectionLength = b2I;
				break;
			}
			int i;
			for (i = Y2b; i < tk.UYn().Length && tk.BYU().Contains(i); i++)
			{
			}
			if (i != Y2b)
			{
				base.SelectionStart = i;
				base.SelectionLength = 0;
			}
			break;
		}
		}
		x2l(tk.MatchedText);
		IsMatched = tk.lY7() && !tk.kYh();
	}

	private void x2l(string P_0)
	{
		if (MatchedText == P_0)
		{
			return;
		}
		try
		{
			y2T = true;
			MatchedText = P_0;
		}
		finally
		{
			y2T = false;
		}
	}

	private void M2X(string P_0)
	{
		if (base.Text == P_0)
		{
			return;
		}
		try
		{
			L2O = true;
			base.Text = P_0;
			int num = Math.Min(Y2b, P_0.Length);
			int selectionLength = Math.Min(B2I, P_0.Length - num);
			base.SelectionStart = num;
			base.SelectionLength = selectionLength;
		}
		finally
		{
			L2O = false;
		}
	}

	protected override void OnGotFocus(RoutedEventArgs e)
	{
		base.OnGotFocus(e);
		if (PromptVisibility == MaskPromptVisibility.FocusedOnly)
		{
			d2f((pdq)2);
		}
	}

	protected override void OnLostFocus(RoutedEventArgs e)
	{
		base.OnLostFocus(e);
		if (PromptVisibility == MaskPromptVisibility.FocusedOnly)
		{
			d2f((pdq)2);
		}
	}

	protected override void OnMouseDown(MouseButtonEventArgs e)
	{
		try
		{
			n2o = true;
			base.OnMouseDown(e);
		}
		finally
		{
			n2o = false;
		}
	}

	static MaskedTextBox()
	{
		awj.QuEwGz();
		IsCaseAutoCorrectedProperty = DependencyProperty.Register(QdM.AR8(20006), typeof(bool), typeof(MaskedTextBox), new PropertyMetadata(false, F2C));
		IsCaseSensitiveProperty = DependencyProperty.Register(QdM.AR8(20048), typeof(bool), typeof(MaskedTextBox), new PropertyMetadata(false, F2C));
		IsMatchedProperty = DependencyProperty.Register(QdM.AR8(20082), typeof(bool), typeof(MaskedTextBox), new PropertyMetadata(false, mPz));
		MaskProperty = DependencyProperty.Register(QdM.AR8(20104), typeof(string), typeof(MaskedTextBox), new PropertyMetadata(null, F2C));
		MaskKindProperty = DependencyProperty.Register(QdM.AR8(20116), typeof(MaskKind), typeof(MaskedTextBox), new PropertyMetadata(MaskKind.Regex, F2C));
		MatchedTextProperty = DependencyProperty.Register(QdM.AR8(20136), typeof(string), typeof(MaskedTextBox), new PropertyMetadata(string.Empty, e2Q));
		PromptCharProperty = DependencyProperty.Register(QdM.AR8(20162), typeof(char), typeof(MaskedTextBox), new PropertyMetadata('•', F2C));
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		PromptVisibilityProperty = DependencyProperty.Register(QdM.AR8(20186), typeof(MaskPromptVisibility), typeof(MaskedTextBox), new PropertyMetadata(MaskPromptVisibility.FocusedOnly, B2V));
	}

	internal static bool DWE()
	{
		return hWC == null;
	}

	internal static MaskedTextBox mW3()
	{
		return hWC;
	}
}
