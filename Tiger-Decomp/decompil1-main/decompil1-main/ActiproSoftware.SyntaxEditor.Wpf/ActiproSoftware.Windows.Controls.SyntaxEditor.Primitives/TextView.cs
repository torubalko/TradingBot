using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

public abstract class TextView : ContentControl, ITextView
{
	private FAi QA0;

	private FAc NAB;

	private Color? EAV;

	private double RAr;

	private string kAs;

	private float lAk;

	private FontStyle? CAS;

	private FontWeight? lA9;

	private Color? LAy;

	private double oAq;

	private double uA2;

	private bool gA7;

	private PropertyDictionary TAi;

	private SyntaxEditor RAp;

	private nR SAM;

	private Guid vAO;

	private oAY JAU;

	private ITextViewLineCollection nAJ;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly IHighlightingStyleRegistry TAt;

	public static readonly RoutedEvent ClosedEvent;

	public static readonly RoutedEvent MarginsDestroyedEvent;

	public static readonly RoutedEvent ScrollBarUpdateRequestedEvent;

	public static readonly RoutedEvent TextAreaLayoutEvent;

	public static readonly DependencyProperty ScrollStateProperty;

	public static readonly DependencyProperty ZoomLevelProperty;

	internal static TextView l0V;

	protected internal virtual bool ArePartiallyVisibleViewLinesAllowed => true;

	protected internal abstract ITagAggregator<IClassificationTag> ClassificationTagAggregator { get; }

	public abstract ICollapsedRegionManager CollapsedRegionManager { get; }

	public ITextSnapshot CurrentSnapshot => (JAU != null) ? JAU.WTT() : null;

	public Color DefaultBackgroundColor
	{
		get
		{
			if (!EAV.HasValue)
			{
				if (UseSyntaxEditorDisplayItemProperties && SyntaxEditor.ReadLocalValue(Control.BackgroundProperty) is Brush brush)
				{
					Color? color = TextViewDrawContext.mHT(brush);
					if (color.HasValue)
					{
						EAV = color.Value;
					}
				}
				if (!EAV.HasValue)
				{
					IHighlightingStyle highlightingStyle = HighlightingStyleRegistry[cT.PlainText];
					if (highlightingStyle != null)
					{
						EAV = highlightingStyle.Background;
					}
				}
				if (!EAV.HasValue && UseSyntaxEditorDisplayItemProperties && SyntaxEditor.GetValue(Control.BackgroundProperty) is Brush brush2)
				{
					Color? color2 = TextViewDrawContext.mHT(brush2);
					if (color2.HasValue)
					{
						EAV = color2.Value;
					}
				}
				if (!EAV.HasValue)
				{
					EAV = DisplayItemClassificationTypeProvider.qU;
				}
			}
			return EAV.Value;
		}
	}

	public double DefaultCharacterWidth
	{
		get
		{
			if (RAr <= 0.0)
			{
				rAe();
			}
			return (RAr <= 0.0) ? 7.0 : RAr;
		}
	}

	public string DefaultFontFamilyName
	{
		get
		{
			if (string.IsNullOrEmpty(kAs))
			{
				if (UseSyntaxEditorDisplayItemProperties && SyntaxEditor.ReadLocalValue(Control.FontFamilyProperty) is FontFamily fontFamily)
				{
					kAs = fontFamily.Source;
				}
				if (string.IsNullOrEmpty(kAs))
				{
					IHighlightingStyle highlightingStyle = HighlightingStyleRegistry[cT.PlainText];
					if (highlightingStyle != null)
					{
						kAs = highlightingStyle.FontFamilyName;
					}
				}
				if (string.IsNullOrEmpty(kAs) && UseSyntaxEditorDisplayItemProperties && SyntaxEditor.GetValue(Control.FontFamilyProperty) is FontFamily fontFamily2)
				{
					kAs = fontFamily2.Source;
				}
				if (string.IsNullOrEmpty(kAs))
				{
					kAs = DisplayItemClassificationTypeProvider.rPa;
				}
			}
			return kAs;
		}
	}

	public float DefaultFontSize
	{
		get
		{
			if (lAk <= 0f)
			{
				if (UseSyntaxEditorDisplayItemProperties)
				{
					object obj = SyntaxEditor.ReadLocalValue(SyntaxEditor.TextAreaFontSizeProperty);
					if (obj != null && obj != DependencyProperty.UnsetValue)
					{
						if (obj is BindingExpression)
						{
							lAk = (float)(double)SyntaxEditor.GetValue(SyntaxEditor.TextAreaFontSizeProperty);
						}
						else
						{
							lAk = (float)(double)obj;
						}
					}
					if (lAk <= 0f)
					{
						obj = SyntaxEditor.ReadLocalValue(Control.FontSizeProperty);
						if (obj != null && obj != DependencyProperty.UnsetValue)
						{
							if (obj is BindingExpression)
							{
								lAk = (float)(double)SyntaxEditor.GetValue(Control.FontSizeProperty);
							}
							else
							{
								lAk = (float)(double)obj;
							}
						}
					}
				}
				if (lAk <= 0f)
				{
					IHighlightingStyle highlightingStyle = HighlightingStyleRegistry[cT.PlainText];
					if (highlightingStyle != null)
					{
						lAk = highlightingStyle.FontSize;
					}
				}
				if (UseSyntaxEditorDisplayItemProperties)
				{
					if (lAk <= 0f)
					{
						lAk = (float)(double)SyntaxEditor.GetValue(SyntaxEditor.TextAreaFontSizeProperty);
					}
					if (lAk <= 0f)
					{
						lAk = (float)(double)SyntaxEditor.GetValue(Control.FontSizeProperty);
					}
				}
				if (lAk <= 0f)
				{
					lAk = DisplayItemClassificationTypeProvider.jPx;
				}
			}
			return lAk;
		}
	}

	public FontStyle DefaultFontStyle
	{
		get
		{
			if (!CAS.HasValue)
			{
				if (UseSyntaxEditorDisplayItemProperties)
				{
					object obj = SyntaxEditor.ReadLocalValue(Control.FontStyleProperty);
					if (obj != null && obj != DependencyProperty.UnsetValue)
					{
						if (obj is BindingExpression)
						{
							CAS = (FontStyle)SyntaxEditor.GetValue(Control.FontStyleProperty);
						}
						else
						{
							CAS = (FontStyle)obj;
						}
					}
				}
				if (!CAS.HasValue)
				{
					IHighlightingStyle highlightingStyle = HighlightingStyleRegistry[cT.PlainText];
					if (highlightingStyle != null && highlightingStyle.Italic.HasValue)
					{
						CAS = (highlightingStyle.Italic.Value ? FontStyles.Italic : FontStyles.Normal);
					}
				}
				if (UseSyntaxEditorDisplayItemProperties && !CAS.HasValue)
				{
					CAS = (FontStyle)SyntaxEditor.GetValue(Control.FontStyleProperty);
				}
				if (!CAS.HasValue)
				{
					CAS = FontStyles.Normal;
				}
			}
			return CAS.Value;
		}
	}

	public FontWeight DefaultFontWeight
	{
		get
		{
			if (!lA9.HasValue)
			{
				if (UseSyntaxEditorDisplayItemProperties)
				{
					object obj = SyntaxEditor.ReadLocalValue(Control.FontWeightProperty);
					if (obj != null && obj != DependencyProperty.UnsetValue)
					{
						if (obj is BindingExpression)
						{
							lA9 = (FontWeight)SyntaxEditor.GetValue(Control.FontWeightProperty);
						}
						else
						{
							lA9 = (FontWeight)obj;
						}
					}
				}
				if (!lA9.HasValue)
				{
					IHighlightingStyle highlightingStyle = HighlightingStyleRegistry[cT.PlainText];
					if (highlightingStyle != null && highlightingStyle.Bold.HasValue)
					{
						lA9 = (highlightingStyle.Bold.Value ? FontWeights.Bold : FontWeights.Normal);
					}
				}
				if (UseSyntaxEditorDisplayItemProperties && !lA9.HasValue)
				{
					lA9 = (FontWeight)SyntaxEditor.GetValue(Control.FontWeightProperty);
				}
				if (!lA9.HasValue)
				{
					lA9 = FontWeights.Normal;
				}
			}
			return lA9.Value;
		}
	}

	public Color DefaultForegroundColor
	{
		get
		{
			if (!LAy.HasValue)
			{
				if (UseSyntaxEditorDisplayItemProperties && SyntaxEditor.ReadLocalValue(Control.ForegroundProperty) is Brush brush)
				{
					Color? color = TextViewDrawContext.mHT(brush);
					if (color.HasValue)
					{
						LAy = color.Value;
					}
				}
				if (!LAy.HasValue)
				{
					IHighlightingStyle highlightingStyle = HighlightingStyleRegistry[cT.PlainText];
					if (highlightingStyle != null)
					{
						LAy = highlightingStyle.Foreground;
					}
				}
				if (!LAy.HasValue && UseSyntaxEditorDisplayItemProperties && SyntaxEditor.GetValue(Control.ForegroundProperty) is Brush brush2)
				{
					Color? color2 = TextViewDrawContext.mHT(brush2);
					if (color2.HasValue)
					{
						LAy = color2.Value;
					}
				}
				if (!LAy.HasValue)
				{
					LAy = DisplayItemClassificationTypeProvider.UJ;
				}
			}
			return LAy.Value;
		}
	}

	public double DefaultLineHeight
	{
		get
		{
			if (oAq <= 0.0)
			{
				rAe();
			}
			return oAq;
		}
	}

	public double DefaultSpaceWidth
	{
		get
		{
			if (uA2 <= 0.0)
			{
				rAe();
			}
			return (uA2 <= 0.0) ? 7.0 : uA2;
		}
	}

	public virtual IHighlightingStyleRegistry HighlightingStyleRegistry
	{
		[CompilerGenerated]
		get
		{
			return TAt;
		}
	}

	protected internal abstract ITagAggregator<IIntraLineSpacerTag> IntraLineSpacerTagAggregator { get; }

	protected internal abstract ITagAggregator<IIntraTextSpacerTag> IntraTextSpacerTagAggregator { get; }

	public bool IsDefaultBackgroundColorLight => UIColor.FromColor(DefaultBackgroundColor).IsLight;

	public abstract bool IsWhitespaceVisible { get; }

	public PropertyDictionary Properties => TAi;

	protected internal abstract Rect ScrollableContentHostBounds { get; }

	public SyntaxEditor SyntaxEditor => RAp;

	public virtual Thickness TextAreaPadding => default(Thickness);

	public abstract Size TextAreaSize { get; }

	public abstract Rect TextAreaViewportBounds { get; }

	public Guid UniqueId => vAO;

	protected internal abstract bool UseSyntaxEditorDisplayItemProperties { get; }

	public ITextViewLineCollection VisibleViewLines
	{
		get
		{
			if (JAU != null)
			{
				JAU.gTH();
			}
			return nAJ;
		}
		internal set
		{
			nAJ = value;
		}
	}

	public FrameworkElement VisualElement => this;

	protected internal abstract WordWrapMode WordWrapMode { get; }

	public TextViewScrollState ScrollState
	{
		get
		{
			return (TextViewScrollState)GetValue(ScrollStateProperty);
		}
		internal set
		{
			SetValue(ScrollStateProperty, value);
		}
	}

	public double ZoomLevel
	{
		get
		{
			return (double)GetValue(ZoomLevelProperty);
		}
		private set
		{
			SetValue(ZoomLevelProperty, value);
		}
	}

	protected internal virtual ITagAggregator<ISquiggleTag> SquiggleTagAggregator => null;

	public event RoutedEventHandler Closed
	{
		add
		{
			AddHandler(ClosedEvent, value);
		}
		remove
		{
			RemoveHandler(ClosedEvent, value);
		}
	}

	public event RoutedEventHandler MarginsDestroyed
	{
		add
		{
			AddHandler(MarginsDestroyedEvent, value);
		}
		remove
		{
			RemoveHandler(MarginsDestroyedEvent, value);
		}
	}

	public event RoutedEventHandler ScrollBarUpdateRequested
	{
		add
		{
			AddHandler(ScrollBarUpdateRequestedEvent, value);
		}
		remove
		{
			RemoveHandler(ScrollBarUpdateRequestedEvent, value);
		}
	}

	public event EventHandler<TextViewTextAreaLayoutEventArgs> TextAreaLayout
	{
		add
		{
			AddHandler(TextAreaLayoutEvent, value);
		}
		remove
		{
			RemoveHandler(TextAreaLayoutEvent, value);
		}
	}

	protected TextView(SyntaxEditor syntaxEditor, ITextSnapshot initialSnapshot)
	{
		grA.DaB7cz();
		TAi = new PropertyDictionary();
		vAO = Guid.NewGuid();
		base._002Ector();
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		if (syntaxEditor == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8238));
		}
		RAp = syntaxEditor;
		SAM = new nR(this);
		NAB = new FAc(this);
		JAU = new oAY(this, initialSnapshot);
		nAJ = new lAn();
		gA4(new FAi(this));
		base.Unloaded += WAv;
	}

	[SpecialName]
	internal FAi aAY()
	{
		return QA0;
	}

	[SpecialName]
	private void gA4(FAi value)
	{
		if (QA0 != value)
		{
			if (QA0 != null)
			{
				QA0.Draw -= aAA;
			}
			QA0 = value;
			if (QA0 != null)
			{
				QA0.Draw += aAA;
			}
		}
	}

	[SpecialName]
	internal FAc pAj()
	{
		return NAB;
	}

	[SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "ActiproSoftware.Windows.Controls.Rendering.CanvasControl.CreateTextLayout(System.String,System.Single,System.String,System.Single,System.Windows.Media.Color)")]
	private void rAe()
	{
		if (QA0 == null)
		{
			return;
		}
		using ITextLayout textLayout = QA0.CreateTextLayout(Q7Z.tqM(10840), float.MaxValue, DefaultFontFamilyName, DefaultFontSize, Colors.Black);
		TextFormattingMode textFormattingMode = TextOptions.GetTextFormattingMode(this);
		textLayout.TextFormattingMode = textFormattingMode;
		ITextLayoutLine textLayoutLine = textLayout.Lines[0];
		oAq = Math.Round(textLayoutLine.Height, MidpointRounding.AwayFromZero);
		RAr = textLayoutLine.Width;
		uA2 = textLayout.SpaceWidth;
	}

	internal void PAl()
	{
		EAV = null;
		RAr = 0.0;
		kAs = null;
		lAk = 0f;
		CAS = null;
		lA9 = null;
		LAy = null;
		oAq = 0.0;
		int num = 0;
		if (O0c() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		uA2 = 0.0;
	}

	[SpecialName]
	internal bool hA6()
	{
		return gA7;
	}

	private void aAA(object P_0, CanvasDrawEventArgs P_1)
	{
		if (NAB != null)
		{
			NAB.KHj(P_1);
		}
	}

	private void WAv(object P_0, RoutedEventArgs P_1)
	{
		if (JAU != null)
		{
			JAU.ITo();
		}
	}

	internal void hAm(TextViewScrollState P_0)
	{
		if (ScrollState != P_0)
		{
			try
			{
				gA7 = true;
				ScrollState = P_0;
			}
			finally
			{
				gA7 = false;
			}
		}
	}

	[SpecialName]
	internal nR DAb()
	{
		return SAM;
	}

	[SpecialName]
	internal oAY WAL()
	{
		return JAU;
	}

	protected internal abstract void Close();

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	public abstract ITagAggregator<T> CreateTagAggregator<T>() where T : ITag;

	public abstract IAdornmentLayer GetAdornmentLayer(AdornmentLayerDefinition layerDefinition);

	public ITextViewLine GetViewLine(int offset)
	{
		return GetViewLine(offset, hasFarAffinity: true);
	}

	public ITextViewLine GetViewLine(int offset, bool hasFarAffinity)
	{
		ITextViewLine textViewLine = null;
		if (JAU != null)
		{
			JAU.gTH();
			textViewLine = JAU.PT4(offset, hasFarAffinity);
			if (textViewLine != null)
			{
				foreach (ITextViewLine item in nAJ)
				{
					if (item.StartPosition == textViewLine.StartPosition && item.EndPositionIncludingLineTerminator == textViewLine.EndPositionIncludingLineTerminator)
					{
						return item;
					}
				}
			}
		}
		return textViewLine;
	}

	public ITextViewLine GetViewLine(TextPosition position)
	{
		return GetViewLine(PositionToOffset(position), position.HasFarAffinity);
	}

	public ITextViewLine GetViewLine(ITextViewLine viewLine, int lineDelta)
	{
		return GetViewLine(viewLine, lineDelta, forceVirtualSpace: false);
	}

	public ITextViewLine GetViewLine(ITextViewLine viewLine, int lineDelta, bool forceVirtualSpace)
	{
		int num = nAJ.IndexOf(viewLine);
		if (lineDelta < 0)
		{
			if (num != -1)
			{
				int num2 = num;
				if (-lineDelta <= num2)
				{
					viewLine = nAJ[num + lineDelta];
					lineDelta = 0;
				}
				else
				{
					viewLine = nAJ[num - num2];
					lineDelta += num2;
				}
			}
			while (lineDelta < 0 && viewLine.StartOffset > 0)
			{
				viewLine = ((!viewLine.IsVirtualLine || viewLine.StartPosition.Line <= CurrentSnapshot.Lines.Count) ? GetViewLine(viewLine.StartOffset - ((!viewLine.IsVirtualLine) ? 1 : 0), hasFarAffinity: false) : new vAl(this, new TextPosition(viewLine.StartPosition.Line - 1, 0)));
				lineDelta++;
			}
		}
		else
		{
			if (num != -1)
			{
				int num3 = nAJ.Count - num - 1;
				if (lineDelta <= num3)
				{
					viewLine = nAJ[num + lineDelta];
					lineDelta = 0;
				}
				else
				{
					viewLine = nAJ[num + num3];
					lineDelta -= num3;
				}
			}
			int length = CurrentSnapshot.Length;
			while (lineDelta > 0 && viewLine.EndOffset < length)
			{
				viewLine = GetViewLine(viewLine.EndOffsetIncludingLineTerminator, hasFarAffinity: true);
				lineDelta--;
			}
			if (lineDelta > 0 && (forceVirtualSpace || SyntaxEditor.IsVirtualSpaceAtDocumentEndEnabled))
			{
				return new vAl(this, new TextPosition(viewLine.EndPosition.Line + lineDelta, 0));
			}
		}
		return viewLine;
	}

	public void InvalidateRender()
	{
		if (QA0 != null)
		{
			QA0.InvalidateRender();
		}
	}

	public TextPosition OffsetToPosition(int offset)
	{
		ITextSnapshot currentSnapshot = CurrentSnapshot;
		offset = Math.Max(0, Math.Min(currentSnapshot.Length, offset));
		return currentSnapshot.OffsetToPosition(offset);
	}

	protected internal virtual void OnRendered()
	{
	}

	protected virtual void OnScrollStatePropertyChanged(TextViewScrollState oldValue, TextViewScrollState newValue)
	{
		if (!gA7 && JAU != null)
		{
			JAU.LTj();
		}
	}

	public int PositionToOffset(TextPosition position)
	{
		if (position.IsEmpty)
		{
			return -1;
		}
		ITextSnapshot currentSnapshot = CurrentSnapshot;
		if (position.Line >= currentSnapshot.Lines.Count)
		{
			return currentSnapshot.Length;
		}
		return currentSnapshot.PositionToOffset(new TextPosition(position.Line, position.Character));
	}

	public abstract Point TransformFromTextArea(Point location);

	public abstract Rect TransformFromTextArea(Rect bounds);

	public abstract Point TransformToTextArea(Point location);

	public abstract Rect TransformToTextArea(Rect bounds);

	internal void pAC()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = ClosedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnClosed(e);
		RaiseEvent(e);
		int num = 0;
		if (!h0I())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal void DAu()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			int num = 0;
			if (O0c() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			e.RoutedEvent = MarginsDestroyedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnMarginsDestroyed(e);
		RaiseEvent(e);
	}

	internal void gA1()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		bool flag = e.RoutedEvent == null;
		int num = 0;
		if (O0c() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			e.RoutedEvent = ScrollBarUpdateRequestedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnScrollBarUpdateRequested(e);
		RaiseEvent(e);
	}

	internal void eAF(TextViewTextAreaLayoutEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = TextAreaLayoutEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnTextAreaLayout(P_0);
		RaiseEvent(P_0);
	}

	protected virtual void OnClosed(RoutedEventArgs e)
	{
	}

	protected virtual void OnMarginsDestroyed(RoutedEventArgs e)
	{
	}

	protected virtual void OnScrollBarUpdateRequested(RoutedEventArgs e)
	{
	}

	protected virtual void OnTextAreaLayout(TextViewTextAreaLayoutEventArgs e)
	{
	}

	private static void uA3(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TextView textView = (TextView)P_0;
		bool flag = true;
		TextViewScrollState oldValue = (TextViewScrollState)P_1.OldValue;
		TextViewScrollState newValue = (TextViewScrollState)P_1.NewValue;
		textView.OnScrollStatePropertyChanged(oldValue, newValue);
	}

	private static void wAR(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TextView textView = (TextView)P_0;
		bool flag = true;
		double oldValue = (double)P_1.OldValue;
		double newValue = (double)P_1.NewValue;
		textView.OnZoomLevelPropertyChanged(oldValue, newValue);
	}

	protected virtual void OnZoomLevelPropertyChanged(double oldValue, double newValue)
	{
	}

	static TextView()
	{
		grA.DaB7cz();
		ClosedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(10846), RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(TextView));
		MarginsDestroyedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(10862), RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(TextView));
		ScrollBarUpdateRequestedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(10898), RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(TextView));
		TextAreaLayoutEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(10950), RoutingStrategy.Direct, typeof(EventHandler<TextViewTextAreaLayoutEventArgs>), typeof(TextView));
		ScrollStateProperty = DependencyProperty.Register(Q7Z.tqM(10982), typeof(TextViewScrollState), typeof(TextView), new PropertyMetadata(default(TextViewScrollState), uA3));
		ZoomLevelProperty = DependencyProperty.Register(Q7Z.tqM(7420), typeof(double), typeof(TextView), new PropertyMetadata(1.0, wAR));
	}

	internal static bool h0I()
	{
		return l0V == null;
	}

	internal static TextView O0c()
	{
		return l0V;
	}
}
