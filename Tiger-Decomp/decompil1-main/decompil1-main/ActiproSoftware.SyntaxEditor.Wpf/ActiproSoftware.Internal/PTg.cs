using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Internal;

internal class PTg : IEditorViewScroller
{
	private class d7y
	{
		private EditorView XrJ;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextPosition crt;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private TextViewScrollState PrZ;

		internal static d7y uMn;

		public TextViewScrollState ScrollState
		{
			[CompilerGenerated]
			get
			{
				return PrZ;
			}
			[CompilerGenerated]
			private set
			{
				PrZ = prZ;
			}
		}

		public d7y(EditorView P_0)
		{
			grA.DaB7cz();
			base._002Ector();
			XrJ = P_0;
			Prp(P_0.VisibleViewLines.FirstVisiblePosition);
			ScrollState = P_0.ScrollState;
		}

		[SpecialName]
		[CompilerGenerated]
		public TextPosition Yri()
		{
			return crt;
		}

		[SpecialName]
		[CompilerGenerated]
		private void Prp(TextPosition P_0)
		{
			crt = P_0;
		}

		public void Mr7()
		{
			TextPosition firstVisiblePosition = XrJ.VisibleViewLines.FirstVisiblePosition;
			if (firstVisiblePosition < Yri())
			{
				TextViewScrollState textViewScrollState = ScrollState;
				textViewScrollState.HorizontalAmount = XrJ.ScrollState.HorizontalAmount;
				XrJ.lfz().ScrollTo(textViewScrollState);
			}
		}

		internal static bool SMq()
		{
			return uMn == null;
		}

		internal static d7y wMx()
		{
			return uMn;
		}
	}

	private rT9 H4z;

	private ScrollBar ioW;

	private bool DoP;

	private bool boE;

	private EditorView coc;

	private ScrollBar Joa;

	private double gox;

	private static PTg cA6;

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	private EditorView b4h
	{
		get
		{
			return coc;
		}
		set
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
						break;
					default:
						if (!flag)
						{
							if (coc != null)
							{
								coc.ScrollBarUpdateRequested -= b4L;
								coc.TextAreaLayout -= S4n;
								m4q();
							}
							coc = editorView;
							if (coc != null)
							{
								coc.ScrollBarUpdateRequested += b4L;
								coc.TextAreaLayout += S4n;
								f4y();
							}
						}
						return;
					}
					flag = coc == editorView;
					num2 = 0;
				}
				while (lAC() == null);
			}
		}
	}

	public bool IsHorizontalScrollBarVisible
	{
		get
		{
			return ioW.Opacity > 0.0;
		}
		private set
		{
			if (IsHorizontalScrollBarVisible != flag)
			{
				ioW.IsHitTestVisible = flag;
				ioW.Opacity = (flag ? 1 : 0);
				if (coc != null)
				{
					coc.AfR();
				}
			}
		}
	}

	public bool IsHorizontalScrollingEnabled
	{
		get
		{
			if (coc != null)
			{
				ScrollBarVisibility horizontalScrollBarVisibility = coc.SyntaxEditor.HorizontalScrollBarVisibility;
				ScrollBarVisibility scrollBarVisibility = horizontalScrollBarVisibility;
				if (scrollBarVisibility == ScrollBarVisibility.Auto || scrollBarVisibility == ScrollBarVisibility.Visible)
				{
					return true;
				}
			}
			return false;
		}
	}

	public bool IsVerticalScrollBarVisible
	{
		get
		{
			return Joa.Opacity > 0.0;
		}
		private set
		{
			if (IsVerticalScrollBarVisible != flag)
			{
				Joa.IsHitTestVisible = flag;
				Joa.Opacity = (flag ? 1 : 0);
				if (coc != null)
				{
					coc.AfR();
				}
			}
		}
	}

	public bool IsVerticalScrollingEnabled
	{
		get
		{
			if (coc != null)
			{
				ScrollBarVisibility verticalScrollBarVisibility = coc.SyntaxEditor.VerticalScrollBarVisibility;
				ScrollBarVisibility scrollBarVisibility = verticalScrollBarVisibility;
				if (scrollBarVisibility == ScrollBarVisibility.Auto || scrollBarVisibility == ScrollBarVisibility.Visible)
				{
					return true;
				}
			}
			return false;
		}
	}

	public PTg(EditorView P_0)
	{
		grA.DaB7cz();
		gox = 1.0;
		base._002Ector();
		b4h = P_0;
	}

	private d7y F4w()
	{
		return new d7y(coc);
	}

	internal void C46(TextPosition P_0, bool P_1)
	{
		Rect rect = coc.TransformToTextArea(coc.TextAreaViewportBounds);
		if (rect.Width == 0.0 && rect.Height == 0.0)
		{
			return;
		}
		ITextViewLine viewLine = coc.GetViewLine(P_0);
		Rect textBounds = viewLine.TextBounds;
		TextViewScrollState scrollState = coc.ScrollState;
		bool flag = viewLine.Visibility != TextViewLineVisibility.FullyVisible;
		if (viewLine.Visibility == TextViewLineVisibility.PartiallyVisible && viewLine.TopMargin + viewLine.BottomMargin > 0.0 && textBounds.Y >= rect.Y && textBounds.Bottom <= rect.Bottom)
		{
			flag = false;
		}
		TextViewScrollState? textViewScrollState = null;
		TextViewScrollState value;
		if (flag)
		{
			TextViewVerticalAnchorPlacement verticalAnchorPlacement = (P_1 ? TextViewVerticalAnchorPlacement.TextCenter : ((P_0 <= scrollState.VerticalAnchorTextPosition) ? TextViewVerticalAnchorPlacement.TextTop : TextViewVerticalAnchorPlacement.TextBottom));
			value = new TextViewScrollState(P_0, verticalAnchorPlacement, 0.0, scrollState.HorizontalAmount)
			{
				CanScrollPastDocumentEnd = coc.SyntaxEditor.CanScrollPastDocumentEnd
			};
			textViewScrollState = value;
		}
		if (rect.Width > 0.0 && !coc.SyntaxEditor.IsWordWrapEnabled)
		{
			TextBounds characterBounds = viewLine.GetCharacterBounds(P_0);
			double num = scrollState.HorizontalAmount;
			if (coc.SyntaxEditor.IsMultiLine)
			{
				if (characterBounds.Right > rect.Right)
				{
					double num2 = (coc.gft() ? 1.0 : (0.15 * rect.Width));
					num += (double)(int)Math.Round(characterBounds.Left - rect.Right + num2, MidpointRounding.AwayFromZero);
				}
				else if (characterBounds.X < rect.X)
				{
					double num3 = (coc.gft() ? 0.0 : (0.15 * rect.Width));
					num = (int)Math.Round(Math.Max(0.0, scrollState.HorizontalAmount - (rect.X - characterBounds.X) - num3), MidpointRounding.AwayFromZero);
				}
			}
			else
			{
				bool flag2 = false;
				if (characterBounds.Right > rect.Right)
				{
					double num4 = 1.0;
					num += (double)(int)Math.Round(characterBounds.Left - rect.Right + num4, MidpointRounding.AwayFromZero);
				}
				else if (characterBounds.X < rect.X)
				{
					double num5 = 0.0;
					num = (int)Math.Round(Math.Max(0.0, scrollState.HorizontalAmount - (rect.X - characterBounds.X) - num5), MidpointRounding.AwayFromZero);
					flag2 = true;
				}
				double width = viewLine.Size.Width;
				if (width <= rect.Width || (flag2 && num < 0.15 * rect.Width))
				{
					num = 0.0;
				}
				else
				{
					double num6 = Math.Max(0.0, width - num);
					double num7 = Math.Max(0.0, rect.Width - num6 - 1.0);
					num -= num7;
				}
			}
			if (num != scrollState.HorizontalAmount)
			{
				if (!textViewScrollState.HasValue)
				{
					textViewScrollState = scrollState;
				}
				value = new TextViewScrollState(textViewScrollState.Value.VerticalAnchorTextPosition, textViewScrollState.Value.VerticalAnchorPlacement, textViewScrollState.Value.VerticalAmountOffset, num)
				{
					CanScrollPastDocumentEnd = coc.SyntaxEditor.CanScrollPastDocumentEnd
				};
				textViewScrollState = value;
			}
		}
		if (textViewScrollState.HasValue)
		{
			ScrollTo(textViewScrollState.Value);
		}
	}

	private int k4H(Orientation P_0, ScrollEventType P_1)
	{
		if (H4z != null && H4z.YwJ(P_0, P_1))
		{
			return H4z.ywt();
		}
		if (coc != null)
		{
			SyntaxEditor syntaxEditor = coc.SyntaxEditor;
			H4z = new rT9(P_0, P_1, (int)syntaxEditor.ScrollBarAccelerationInterval.TotalMilliseconds, syntaxEditor.ScrollBarAccelerationMaximum);
			return H4z.ywt();
		}
		return 1;
	}

	[SpecialName]
	internal double D4U()
	{
		return (ioW != null) ? ioW.Maximum : 0.0;
	}

	private void y4b(object P_0, ScrollEventArgs P_1)
	{
		if (!boE && P_1 != null)
		{
			boE = true;
			try
			{
				p40((int)P_1.NewValue);
			}
			finally
			{
				boE = false;
			}
		}
	}

	private void b4T(object P_0, ScrollEventArgs P_1)
	{
		if (boE || P_1 == null)
		{
			return;
		}
		boE = true;
		try
		{
			double num = Math.Max(1.0, coc.DefaultLineHeight);
			switch (P_1.ScrollEventType)
			{
			case ScrollEventType.LargeDecrement:
				o48();
				P4I(0.0, 0.0 - Math.Max(num, coc.TextAreaSize.Height - num));
				break;
			case ScrollEventType.LargeIncrement:
				o48();
				P4I(0.0, Math.Max(num, coc.TextAreaSize.Height - num));
				break;
			case ScrollEventType.SmallDecrement:
				P4I(0.0, (0.0 - num) * (double)k4H(Orientation.Vertical, ScrollEventType.SmallDecrement));
				break;
			case ScrollEventType.SmallIncrement:
				P4I(0.0, num * (double)k4H(Orientation.Vertical, ScrollEventType.SmallIncrement));
				break;
			default:
				o48();
				M4B((int)P_1.NewValue);
				break;
			}
		}
		finally
		{
			boE = false;
		}
	}

	private void b4L(object P_0, object P_1)
	{
		q4V();
	}

	private void S4n(object P_0, TextViewTextAreaLayoutEventArgs P_1)
	{
		q4V();
	}

	private void o48()
	{
		H4z = null;
	}

	private void P4I(double P_0, double P_1)
	{
		if (coc != null)
		{
			TextViewScrollState scrollState = coc.ScrollState;
			int num = 0;
			if (!hAK())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			scrollState.CanScrollPastDocumentEnd = coc.SyntaxEditor.CanScrollPastDocumentEnd;
			scrollState.HorizontalAmount += P_0;
			scrollState.VerticalAmountOffset += P_1;
			q45(scrollState);
		}
	}

	private void q45(TextViewScrollState P_0)
	{
		if (coc == null)
		{
			return;
		}
		if (!DoP)
		{
			q4V();
		}
		if (P_0.HorizontalAmount < 0.0)
		{
			P_0.HorizontalAmount = 0.0;
		}
		if (ioW != null && ioW.Value != P_0.HorizontalAmount)
		{
			if (ioW.Maximum < P_0.HorizontalAmount)
			{
				ioW.Maximum = P_0.HorizontalAmount;
			}
			ioW.Value = P_0.HorizontalAmount;
		}
		if (Joa != null)
		{
			if (coc.SyntaxEditor.IsWordWrapEnabled)
			{
				int num = coc.CurrentSnapshot.PositionToOffset(P_0.VerticalAnchorTextPosition);
				if (Joa.Value != (double)num)
				{
					Joa.Value = num;
				}
			}
			else if (Joa.Value != (double)P_0.VerticalAnchorTextPosition.Line)
			{
				Joa.Value = P_0.VerticalAnchorTextPosition.Line;
			}
		}
		if (coc.ScrollState != P_0)
		{
			coc.ScrollState = P_0;
		}
		if (coc.IsActive)
		{
			coc.SyntaxEditor.LGl()?.jRb();
		}
	}

	private void p40(int P_0)
	{
		if (coc != null)
		{
			TextViewScrollState scrollState = coc.ScrollState;
			scrollState.CanScrollPastDocumentEnd = coc.SyntaxEditor.CanScrollPastDocumentEnd;
			scrollState.HorizontalAmount = P_0;
			q45(scrollState);
		}
	}

	private void M4B(int P_0)
	{
		if (coc != null)
		{
			TextPosition verticalAnchorTextPosition = R4r(P_0);
			TextViewScrollState scrollState = coc.ScrollState;
			scrollState.CanScrollPastDocumentEnd = coc.SyntaxEditor.CanScrollPastDocumentEnd;
			scrollState.VerticalAnchorTextPosition = verticalAnchorTextPosition;
			int num = 0;
			if (!hAK())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			scrollState.VerticalAmountOffset = 0.0;
			q45(scrollState);
		}
	}

	private void q4V()
	{
		if (coc == null)
		{
			return;
		}
		DoP = true;
		bool isWordWrapEnabled = coc.SyntaxEditor.IsWordWrapEnabled;
		Size textAreaSize = coc.TextAreaSize;
		ITextViewLineCollection visibleViewLines = coc.VisibleViewLines;
		if (ioW != null)
		{
			if (isWordWrapEnabled)
			{
				ioW.Maximum = 0.0;
				ioW.SmallChange = 1.0;
				ioW.LargeChange = 1.0;
				IsHorizontalScrollBarVisible = false;
			}
			else
			{
				double num = visibleViewLines.MaxWidth;
				oAY oAY2 = coc.WAL();
				if (oAY2 != null)
				{
					AAo aAo = oAY2.WTn();
					if (aAo != null)
					{
						num = Math.Max(num, aAo.OTp());
					}
				}
				double num2 = Math.Max(ioW.Value, Math.Max(0.0, num - (double)(int)(0.85 * textAreaSize.Width)));
				ioW.Maximum = num2;
				double num3 = Math.Max(1.0, coc.DefaultCharacterWidth);
				ioW.SmallChange = Math.Max(1.0, num3);
				ioW.LargeChange = Math.Max(3.0, textAreaSize.Width - 2.0 * num3);
				IsHorizontalScrollBarVisible = coc.SyntaxEditor.HorizontalScrollBarVisibility != ScrollBarVisibility.Auto || num2 > 0.0;
			}
			ioW.ViewportSize = Math.Max(0.0, textAreaSize.Width);
		}
		if (Joa == null)
		{
			return;
		}
		if (isWordWrapEnabled)
		{
			double num4 = Math.Max(0, coc.CurrentSnapshot.Length);
			Joa.LargeChange = Math.Max(1.0, Math.Min(num4, (int)(textAreaSize.Width * textAreaSize.Height / 300.0)));
			Joa.ViewportSize = Joa.LargeChange;
			Joa.Maximum = num4;
		}
		else
		{
			double defaultLineHeight = coc.DefaultLineHeight;
			if (defaultLineHeight > 0.0)
			{
				int num5 = (coc.SyntaxEditor.CanScrollPastDocumentEnd ? 1 : coc.VisibleViewLines.FullyVisibleCount);
				double num4 = Math.Max(0, coc.CurrentSnapshot.Lines.Count - num5);
				Joa.LargeChange = Math.Max(1.0, (textAreaSize.Height - defaultLineHeight) / defaultLineHeight);
				Joa.ViewportSize = Math.Max(1.0, textAreaSize.Height / defaultLineHeight);
				Joa.Maximum = num4;
			}
		}
		double num6 = ((coc.SyntaxEditor.HorizontalScrollBarVisibility == ScrollBarVisibility.Auto) ? ioW.ActualHeight : 0.0);
		IsVerticalScrollBarVisible = coc.SyntaxEditor.VerticalScrollBarVisibility != ScrollBarVisibility.Auto || visibleViewLines.Count <= 0 || !visibleViewLines[0].IsFirstLine || !(visibleViewLines[0].Bounds.Y >= 0.0) || !visibleViewLines[visibleViewLines.Count - 1].IsLastLine || !(visibleViewLines[visibleViewLines.Count - 1].Bounds.Bottom < textAreaSize.Height - num6);
	}

	private TextPosition R4r(int P_0)
	{
		if (coc != null && coc.SyntaxEditor.IsWordWrapEnabled)
		{
			return coc.GetViewLine(P_0)?.StartPosition ?? TextPosition.Zero;
		}
		return new TextPosition(P_0, 0);
	}

	public static ScrollBar V4s()
	{
		ScrollBar scrollBar = new ScrollBar
		{
			Orientation = Orientation.Horizontal,
			SmallChange = 10.0,
			LargeChange = 100.0
		};
		AutomationProperties.SetAutomationId(scrollBar, Q7Z.tqM(193390));
		return scrollBar;
	}

	public static ScrollBar I4k()
	{
		ScrollBar scrollBar = new ScrollBar
		{
			Orientation = Orientation.Vertical,
			SmallChange = 1.0,
			LargeChange = 3.0
		};
		AutomationProperties.SetAutomationId(scrollBar, Q7Z.tqM(193432));
		return scrollBar;
	}

	public ScrollBar X4S()
	{
		if (ioW == null)
		{
			ioW = V4s();
			ioW.Scroll += y4b;
			ioW.ValueChanged += w42;
		}
		return ioW;
	}

	public ScrollBar H49()
	{
		if (Joa == null)
		{
			Joa = I4k();
			Joa.Scroll += b4T;
			Joa.ValueChanged += S47;
		}
		return Joa;
	}

	public void ScrollByPixels(double P_0, double P_1)
	{
		if (boE)
		{
			return;
		}
		boE = true;
		try
		{
			P4I(P_0, P_1);
		}
		finally
		{
			boE = false;
		}
	}

	public void ScrollDown()
	{
		coc.ExecuteEditAction(EditorCommands.ScrollDown);
	}

	public void ScrollHorizontallyByPixels(double P_0)
	{
		if (boE)
		{
			return;
		}
		boE = true;
		try
		{
			P4I(P_0, 0.0);
		}
		finally
		{
			boE = false;
		}
	}

	public void ScrollIntoView(TextPosition P_0, bool P_1)
	{
		C46(P_0, P_1);
	}

	public void ScrollLeft()
	{
		coc.ExecuteEditAction(EditorCommands.ScrollLeft);
	}

	public void ScrollLineToVisibleBottom()
	{
		coc.ExecuteEditAction(EditorCommands.ScrollLineToVisibleBottom);
	}

	public void ScrollLineToVisibleMiddle()
	{
		coc.ExecuteEditAction(EditorCommands.ScrollLineToVisibleMiddle);
	}

	public void ScrollLineToVisibleTop()
	{
		coc.ExecuteEditAction(EditorCommands.ScrollLineToVisibleTop);
	}

	public void ScrollPageDown()
	{
		coc.ExecuteEditAction(EditorCommands.ScrollPageDown);
	}

	public void ScrollPageUp()
	{
		coc.ExecuteEditAction(EditorCommands.ScrollPageUp);
	}

	public void ScrollRight()
	{
		coc.ExecuteEditAction(EditorCommands.ScrollRight);
	}

	public void ScrollTo(TextViewScrollState P_0)
	{
		if (boE)
		{
			return;
		}
		boE = true;
		try
		{
			q45(P_0);
		}
		finally
		{
			boE = false;
		}
	}

	public void ScrollToCaret()
	{
		C46(coc.Selection.CaretPosition, _0020: false);
	}

	public void ScrollToDocumentEnd()
	{
		coc.ExecuteEditAction(EditorCommands.ScrollToDocumentEnd);
	}

	public void ScrollToDocumentStart()
	{
		coc.ExecuteEditAction(EditorCommands.ScrollToDocumentStart);
	}

	public void ScrollUp()
	{
		coc.ExecuteEditAction(EditorCommands.ScrollUp);
	}

	public void ScrollVerticallyByLine(int P_0)
	{
		d7y d7y = F4w();
		TextViewScrollState textViewScrollState = d7y.ScrollState;
		textViewScrollState.CanScrollPastDocumentEnd = P_0 <= 0 && coc.SyntaxEditor.CanScrollPastDocumentEnd;
		textViewScrollState.VerticalAnchorTextPosition = coc.PositionFinder.GetPositionForLineDelta(textViewScrollState.VerticalAnchorTextPosition, P_0, null, forceVirtualSpace: false);
		coc.lfz().ScrollTo(textViewScrollState);
		if (P_0 > 0)
		{
			d7y.Mr7();
		}
	}

	public void ScrollVerticallyByPixels(double P_0)
	{
		if (boE)
		{
			return;
		}
		boE = true;
		try
		{
			P4I(0.0, P_0);
		}
		finally
		{
			boE = false;
		}
	}

	private void f4y()
	{
		if (coc != null)
		{
			coc.ManipulationCompleted += H4i;
			coc.ManipulationDelta += g4p;
			coc.ManipulationInertiaStarting += a4M;
			coc.ManipulationStarting += Y4O;
		}
	}

	private void m4q()
	{
		if (coc != null)
		{
			coc.ManipulationCompleted -= H4i;
			coc.ManipulationDelta -= g4p;
			coc.ManipulationInertiaStarting -= a4M;
			coc.ManipulationStarting -= Y4O;
		}
	}

	private void w42(object P_0, RoutedPropertyChangedEventArgs<double> P_1)
	{
		if (boE || P_1 == null || (vAE.A0o() & ModifierKeys.Shift) == 0)
		{
			return;
		}
		boE = true;
		try
		{
			o48();
			p40((int)P_1.NewValue);
		}
		finally
		{
			boE = false;
		}
	}

	private void S47(object P_0, RoutedPropertyChangedEventArgs<double> P_1)
	{
		if (boE || P_1 == null || (vAE.A0o() & ModifierKeys.Shift) == 0)
		{
			return;
		}
		boE = true;
		try
		{
			o48();
			M4B((int)P_1.NewValue);
		}
		finally
		{
			boE = false;
		}
	}

	private void H4i(object P_0, ManipulationCompletedEventArgs P_1)
	{
		if (coc != null)
		{
			coc.ofq(value: false);
		}
		if (P_1 == null || P_1.Handled)
		{
			return;
		}
		int num = 0;
		if (!hAK())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (P_1.Device != null)
		{
			P_1.Handled = true;
		}
	}

	private void g4p(object P_0, ManipulationDeltaEventArgs P_1)
	{
		if (coc != null && !coc.ef7() && P_1 != null && !P_1.Handled && P_1.Device != null)
		{
			ManipulationDelta deltaManipulation = P_1.DeltaManipulation;
			double x = deltaManipulation.Scale.X;
			bool flag = deltaManipulation.Translation.X != 0.0 || deltaManipulation.Translation.Y != 0.0;
			bool flag2 = x != 1.0;
			if (flag || flag2)
			{
				coc.ofq(value: true);
			}
			coc.lfz().ScrollByPixels(0.0 - deltaManipulation.Translation.X, 0.0 - deltaManipulation.Translation.Y);
			gox *= x;
			SyntaxEditor syntaxEditor = coc.SyntaxEditor;
			if ((syntaxEditor.ZoomModesAllowed & ZoomModes.Touch) == ZoomModes.Touch)
			{
				syntaxEditor.ZoomLevel = syntaxEditor.axs(gox, _0020: true);
			}
			P_1.Handled = true;
		}
	}

	private void a4M(object P_0, ManipulationInertiaStartingEventArgs P_1)
	{
		if (P_1 != null)
		{
			P_1.TranslationBehavior.DesiredDeceleration = 0.00096;
			P_1.Handled = true;
		}
	}

	private void Y4O(object P_0, ManipulationStartingEventArgs P_1)
	{
		if (coc == null || P_1 == null)
		{
			return;
		}
		coc.ofq(value: false);
		P_1.Mode = ManipulationModes.Translate;
		if ((coc.SyntaxEditor.ZoomModesAllowed & ZoomModes.Touch) == ZoomModes.Touch)
		{
			P_1.Mode |= ManipulationModes.Scale;
		}
		foreach (IManipulator manipulator in P_1.Manipulators)
		{
			if (!coc.TextAreaViewportBounds.Contains(manipulator.GetPosition(coc)))
			{
				P_1.Mode = ManipulationModes.None;
				P_1.Cancel();
				break;
			}
		}
		gox = coc.SyntaxEditor.ZoomLevel;
		P_1.Handled = true;
	}

	internal static bool hAK()
	{
		return cA6 == null;
	}

	internal static PTg lAC()
	{
		return cA6;
	}
}
