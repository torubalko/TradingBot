using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Internal;

internal class HTX : TextView, IPrinterView, ITextView
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public HTX esh;

		public AdornmentLayerDefinition GsN;

		internal static _003C_003Ec__DisplayClass40_0 LMI;

		public _003C_003Ec__DisplayClass40_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal MTG TsZ()
		{
			return new DAN(esh, GsN);
		}

		internal static bool sMc()
		{
			return LMI == null;
		}

		internal static _003C_003Ec__DisplayClass40_0 uMd()
		{
			return LMI;
		}
	}

	private ITagAggregator<IClassificationTag> lwH;

	private ICollapsedRegionManager Bwb;

	private IHighlightingStyleRegistry vwT;

	private ITagAggregator<IIntraLineSpacerTag> KwL;

	private ITagAggregator<IIntraTextSpacerTag> own;

	private A0 Iw8;

	private PrinterViewMarginCollection CwI;

	private IQ Tw5;

	public static readonly DependencyProperty kw0;

	public static readonly DependencyProperty DwB;

	private static HTX AlN;

	protected internal override bool ArePartiallyVisibleViewLinesAllowed => false;

	protected internal override ITagAggregator<IClassificationTag> ClassificationTagAggregator
	{
		get
		{
			if (lwH == null)
			{
				lwH = CreateTagAggregator<IClassificationTag>();
			}
			return lwH;
		}
	}

	public override ICollapsedRegionManager CollapsedRegionManager => Bwb;

	public override IHighlightingStyleRegistry HighlightingStyleRegistry => vwT;

	protected internal override ITagAggregator<IIntraLineSpacerTag> IntraLineSpacerTagAggregator
	{
		get
		{
			if (KwL == null)
			{
				KwL = CreateTagAggregator<IIntraLineSpacerTag>();
			}
			return KwL;
		}
	}

	protected internal override ITagAggregator<IIntraTextSpacerTag> IntraTextSpacerTagAggregator
	{
		get
		{
			if (own == null)
			{
				own = CreateTagAggregator<IIntraTextSpacerTag>();
			}
			return own;
		}
	}

	public override bool IsWhitespaceVisible => base.SyntaxEditor.PrintSettings?.IsWhitespaceVisible ?? false;

	protected internal override bool UseSyntaxEditorDisplayItemProperties => false;

	protected internal override WordWrapMode WordWrapMode => WordWrapMode.Word;

	public IPrinterViewMarginCollection Margins => CwI;

	protected internal override Rect ScrollableContentHostBounds
	{
		get
		{
			if (Iw8 == null)
			{
				return default(Rect);
			}
			return Iw8.IeB();
		}
	}

	public override Size TextAreaSize
	{
		get
		{
			if (Tw5 == null)
			{
				return default(Size);
			}
			return Tw5.PeO();
		}
	}

	public override Rect TextAreaViewportBounds
	{
		get
		{
			int num = 1;
			int num2 = num;
			bool flag = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 1:
					flag = Tw5 != null;
					num2 = 0;
					if (qlH())
					{
						num2 = 0;
					}
					continue;
				}
				if (!flag)
				{
					return default(Rect);
				}
				Rect rect = Iw8.IeB();
				Rect rect2 = Tw5.meJ();
				Thickness borderThickness = base.BorderThickness;
				return new Rect(borderThickness.Left + rect.X + rect2.X, borderThickness.Top + rect.Y + rect2.Y, rect2.Width, rect2.Height);
			}
		}
	}

	public int PageCount
	{
		get
		{
			return (int)GetValue(kw0);
		}
		internal set
		{
			SetValue(kw0, num);
		}
	}

	public int PageNumber
	{
		get
		{
			return (int)GetValue(DwB);
		}
		internal set
		{
			SetValue(DwB, num);
		}
	}

	public HTX(SyntaxEditor P_0, int P_1, IHighlightingStyleRegistry P_2)
	{
		grA.DaB7cz();
		CwI = new PrinterViewMarginCollection();
		base._002Ector(P_0, P_0.Document.CurrentSnapshot);
		if (P_2 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(193866));
		}
		PageNumber = P_1;
		vwT = P_2;
		Bwb = new jTa(this);
		nw1();
		ywF();
		Lwu();
		TextOptions.SetTextFormattingMode(this, TextFormattingMode.Ideal);
	}

	protected internal override void Close()
	{
		base.SyntaxEditor.VxH(new TextViewEventArgs(this));
		pAC();
		hwm();
		AwC();
	}

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	public override ITagAggregator<rT1> CreateTagAggregator<rT1>()
	{
		return new QAP<rT1>(this, _0020: false);
	}

	private void hwm()
	{
		dwR(null);
	}

	private void AwC()
	{
		DAu();
		CwI.Clear();
	}

	[SpecialName]
	private A0 gw3()
	{
		return Iw8;
	}

	[SpecialName]
	private void dwR(A0 P_0)
	{
		Iw8 = P_0;
		base.Content = Iw8;
	}

	private void Lwu()
	{
		vAC.c8l(this);
		AAH.o8I(this);
		oAt.w8S(this);
	}

	private void nw1()
	{
		nR nR2 = DAb();
		nR2.sld(AdornmentLayerDefinitions.TextBackground.Key, new Lazy<MTG>(() => new YA7()));
		nR2.sld(AdornmentLayerDefinitions.TextForeground.Key, new Lazy<MTG>(() => new VAr()));
		pwo(new IQ(this));
		dwR(new A0(this));
	}

	internal void ywF()
	{
		AwC();
		if (base.SyntaxEditor == null)
		{
			return;
		}
		IPrintSettings printSettings = base.SyntaxEditor.PrintSettings;
		if (printSettings == null)
		{
			return;
		}
		List<IPrinterViewMargin> list = new List<IPrinterViewMargin>(4);
		foreach (IPrinterViewMarginFactory viewMarginFactory in printSettings.ViewMarginFactories)
		{
			IPrinterViewMarginCollection printerViewMarginCollection = viewMarginFactory.CreateMargins(this);
			if (printerViewMarginCollection == null)
			{
				continue;
			}
			foreach (IPrinterViewMargin item in printerViewMarginCollection)
			{
				list.Add(item);
			}
		}
		IPrinterViewMargin[] array = OrderableHelper.Sort(list);
		IPrinterViewMargin[] array2 = array;
		foreach (IPrinterViewMargin printerViewMargin in array2)
		{
			PrinterViewMarginPlacement placement = printerViewMargin.Placement;
			PrinterViewMarginPlacement printerViewMarginPlacement = placement;
			if (printerViewMarginPlacement == PrinterViewMarginPlacement.Left || printerViewMarginPlacement == PrinterViewMarginPlacement.Right)
			{
				CwI.Add(printerViewMargin);
			}
		}
		IPrinterViewMargin[] array3 = array;
		foreach (IPrinterViewMargin printerViewMargin2 in array3)
		{
			PrinterViewMarginPlacement placement2 = printerViewMargin2.Placement;
			PrinterViewMarginPlacement printerViewMarginPlacement2 = placement2;
			if (printerViewMarginPlacement2 == PrinterViewMarginPlacement.Top || printerViewMarginPlacement2 == PrinterViewMarginPlacement.Bottom)
			{
				CwI.Add(printerViewMargin2);
			}
		}
		if (Tw5 != null)
		{
			Tw5.GeM();
		}
	}

	[SpecialName]
	internal IQ ow4()
	{
		return Tw5;
	}

	[SpecialName]
	private void pwo(IQ P_0)
	{
		Tw5 = P_0;
	}

	public override IAdornmentLayer GetAdornmentLayer(AdornmentLayerDefinition P_0)
	{
		int num = 1;
		_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = default(_003C_003Ec__DisplayClass40_0);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
				{
					_003C_003Ec__DisplayClass40_.esh = this;
					_003C_003Ec__DisplayClass40_.GsN = P_0;
					if (_003C_003Ec__DisplayClass40_.GsN == null)
					{
						throw new ArgumentNullException(Q7Z.tqM(8018));
					}
					if (Tw5 == null)
					{
						return null;
					}
					MTG mTG = DAb().sld(_003C_003Ec__DisplayClass40_.GsN.Key, new Lazy<MTG>(_003C_003Ec__DisplayClass40_.TsZ));
					return mTG as IAdornmentLayer;
				}
				case 1:
					break;
				}
				_003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
				num2 = 0;
			}
			while (qlH());
		}
	}

	public override Point TransformFromTextArea(Point P_0)
	{
		Rect textAreaViewportBounds = TextAreaViewportBounds;
		return new Point(P_0.X + textAreaViewportBounds.X, P_0.Y + textAreaViewportBounds.Y);
	}

	public override Rect TransformFromTextArea(Rect P_0)
	{
		Rect textAreaViewportBounds = TextAreaViewportBounds;
		return new Rect(P_0.X + textAreaViewportBounds.X, P_0.Y + textAreaViewportBounds.Y, P_0.Width, P_0.Height);
	}

	public override Point TransformToTextArea(Point P_0)
	{
		Rect textAreaViewportBounds = TextAreaViewportBounds;
		return new Point(P_0.X - textAreaViewportBounds.X, P_0.Y - textAreaViewportBounds.Y);
	}

	public override Rect TransformToTextArea(Rect P_0)
	{
		Rect textAreaViewportBounds = TextAreaViewportBounds;
		return new Rect(P_0.X - textAreaViewportBounds.X, P_0.Y - textAreaViewportBounds.Y, P_0.Width, P_0.Height);
	}

	static HTX()
	{
		grA.DaB7cz();
		kw0 = DependencyProperty.Register(Q7Z.tqM(193920), typeof(int), typeof(HTX), new PropertyMetadata(0));
		DwB = DependencyProperty.Register(Q7Z.tqM(193942), typeof(int), typeof(HTX), new PropertyMetadata(0));
	}

	internal static bool qlH()
	{
		return AlN == null;
	}

	internal static HTX alj()
	{
		return AlN;
	}
}
