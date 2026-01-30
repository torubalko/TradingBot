using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Lexing;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Internal;

internal class ATk : IHitTestResult
{
	private int RjR;

	private ITextViewLine bjY;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TagSnapshotRange<IIntraTextSpacerTag> Vj4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Point Sjo;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TextPosition Ojj;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ITextSnapshot Njw;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private SyntaxEditor Oj6;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Point QjH;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private HitTestResultType pjb;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IEditorView qjT;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IEditorViewMargin zjL;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private FrameworkElement Xjn;

	internal static ATk Sl7;

	public TagSnapshotRange<IIntraTextSpacerTag> IntraTextSpacerTag
	{
		[CompilerGenerated]
		get
		{
			return Vj4;
		}
		[CompilerGenerated]
		private set
		{
			Vj4 = vj;
		}
	}

	public Point Location
	{
		[CompilerGenerated]
		get
		{
			return Sjo;
		}
		[CompilerGenerated]
		private set
		{
			Sjo = sjo;
		}
	}

	public int Offset
	{
		get
		{
			if (RjR == -1 && Snapshot != null && !Position.IsEmpty)
			{
				int num = 0;
				if (Klq() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				RjR = Snapshot.PositionToOffset(Position);
			}
			return RjR;
		}
	}

	public TextPosition Position
	{
		[CompilerGenerated]
		get
		{
			return Ojj;
		}
		[CompilerGenerated]
		private set
		{
			Ojj = ojj;
		}
	}

	public ITextSnapshot Snapshot
	{
		[CompilerGenerated]
		get
		{
			return Njw;
		}
		[CompilerGenerated]
		private set
		{
			Njw = njw;
		}
	}

	public SyntaxEditor SyntaxEditor
	{
		[CompilerGenerated]
		get
		{
			return Oj6;
		}
		[CompilerGenerated]
		private set
		{
			Oj6 = oj;
		}
	}

	public Point TextAreaLocation
	{
		[CompilerGenerated]
		get
		{
			return QjH;
		}
		[CompilerGenerated]
		private set
		{
			QjH = qjH;
		}
	}

	public HitTestResultType Type
	{
		[CompilerGenerated]
		get
		{
			return pjb;
		}
		[CompilerGenerated]
		private set
		{
			pjb = hitTestResultType;
		}
	}

	public IEditorView View
	{
		[CompilerGenerated]
		get
		{
			return qjT;
		}
		[CompilerGenerated]
		private set
		{
			qjT = editorView;
		}
	}

	public ITextViewLine ViewLine
	{
		get
		{
			if (bjY == null && View != null && !Position.IsEmpty)
			{
				bjY = View.GetViewLine(Position);
			}
			return bjY;
		}
	}

	public IEditorViewMargin ViewMargin
	{
		[CompilerGenerated]
		get
		{
			return zjL;
		}
		[CompilerGenerated]
		private set
		{
			zjL = editorViewMargin;
		}
	}

	public FrameworkElement VisualElement
	{
		[CompilerGenerated]
		get
		{
			return Xjn;
		}
		[CompilerGenerated]
		private set
		{
			Xjn = xjn;
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public ATk(SyntaxEditor P_0, Point P_1, bool P_2)
	{
		grA.DaB7cz();
		RjR = -1;
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8238));
		}
		SyntaxEditor = P_0;
		Location = P_1;
		Type = HitTestResultType.Other;
		Position = TextPosition.Empty;
		Point point = default(Point);
		IEnumerable<EditorView> enumerable = P_0.mG5();
		if (enumerable != null)
		{
			try
			{
				foreach (EditorView item in enumerable)
				{
					point = vAE.N0R(P_0, item.VisualElement).Transform(P_1);
					if (xjg(item.VisualElement, point))
					{
						View = item;
						break;
					}
				}
			}
			catch (InvalidOperationException)
			{
			}
		}
		if (P_2)
		{
			return;
		}
		if (View != null)
		{
			Snapshot = View.CurrentSnapshot;
			foreach (IEditorViewMargin margin in View.Margins)
			{
				if (margin.VisualElement != null && margin.VisualElement.Visibility == Visibility.Visible)
				{
					Point point2 = vAE.N0R(View.VisualElement, margin.VisualElement).Transform(point);
					if (xjg(margin.VisualElement, point2))
					{
						Type = HitTestResultType.ViewMargin;
						ViewMargin = margin;
						VisualElement = margin.VisualElement;
						break;
					}
				}
			}
			TextAreaLocation = View.TransformToTextArea(point);
			Position = View.LocationToPosition(TextAreaLocation, LocationToPositionAlgorithm.Absolute);
			bool flag = true;
			if (Position.IsEmpty)
			{
				Position = View.LocationToPosition(TextAreaLocation, LocationToPositionAlgorithm.Block);
				flag = false;
			}
			if (View.TextAreaViewportBounds.Contains(point))
			{
				VisualElement = View.VisualElement;
				if (flag)
				{
					Type = HitTestResultType.ViewTextAreaOverCharacter;
					ITextViewLine viewLine = ViewLine;
					if (viewLine != null)
					{
						Rect bounds = viewLine.Bounds;
						if (TextAreaLocation.Y < bounds.Top || TextAreaLocation.Y >= bounds.Bottom)
						{
							Type = HitTestResultType.ViewTextAreaOverIntraLineSpacer;
						}
						else
						{
							int num = viewLine.LocationToCharacterIndex(TextAreaLocation.X, LocationToPositionAlgorithm.Absolute);
							if (num != -1)
							{
								IntraTextSpacerTag = viewLine.GetIntraTextSpacerTag(num);
								if (IntraTextSpacerTag != null)
								{
									Type = HitTestResultType.ViewTextAreaOverIntraTextSpacer;
								}
							}
						}
					}
				}
				else
				{
					ITextViewLine viewLine2 = View.GetViewLine(TextAreaLocation.Y, LocationToPositionAlgorithm.Absolute);
					if (viewLine2 != null)
					{
						Rect bounds2 = viewLine2.Bounds;
						if (TextAreaLocation.Y < bounds2.Top || TextAreaLocation.Y >= bounds2.Bottom)
						{
							Type = HitTestResultType.ViewTextAreaOverIntraLineSpacer;
						}
						else
						{
							Type = HitTestResultType.ViewTextAreaOverLine;
						}
					}
					else
					{
						Type = HitTestResultType.ViewTextArea;
					}
				}
			}
		}
		else
		{
			IEditorView activeView = P_0.ActiveView;
			if (activeView != null)
			{
				Snapshot = activeView.CurrentSnapshot;
			}
		}
		bool flag2 = false;
		switch (Type)
		{
		case HitTestResultType.ViewMargin:
			flag2 = P_0.ScrollBarTrayLeftTemplate != null || P_0.ScrollBarTrayTopTemplate != null || P_0.ScrollBarTrayRightTemplate != null || P_0.ScrollBarTrayBottomTemplate != null;
			break;
		case HitTestResultType.Other:
			flag2 = true;
			break;
		}
		if (!flag2)
		{
			return;
		}
		KjQ(typeof(ScrollBar), typeof(EditorViewSplitter), typeof(ScrollBarBlock), typeof(ScrollBarTray), typeof(ScrollBarSplitter));
		if (VisualElement != null)
		{
			if (VisualElement is ScrollBar)
			{
				Type = HitTestResultType.ViewScrollBar;
			}
			else if (VisualElement is EditorViewSplitter)
			{
				Type = HitTestResultType.Splitter;
			}
			else if (VisualElement is ScrollBarBlock)
			{
				Type = HitTestResultType.ViewScrollBarBlock;
			}
			else if (VisualElement is ScrollBarSplitter)
			{
				Type = HitTestResultType.ViewScrollBarSplitter;
			}
			else if (VisualElement is ScrollBarTray)
			{
				Type = HitTestResultType.ViewScrollBarTray;
			}
		}
	}

	internal static bool xjg(FrameworkElement P_0, Point P_1)
	{
		if (P_0 != null)
		{
			return new Rect(0.0, 0.0, P_0.ActualWidth, P_0.ActualHeight).Contains(P_1);
		}
		throw new ArgumentNullException(Q7Z.tqM(193602));
	}

	public ITextSnapshotReader GetReader()
	{
		int offset = Offset;
		if (Snapshot != null && offset >= 0 && offset <= Snapshot.Length)
		{
			return Snapshot.GetReader(offset);
		}
		return null;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat(CultureInfo.CurrentCulture, Q7Z.tqM(193620), new object[1] { Type });
		switch (Type)
		{
		case HitTestResultType.ViewMargin:
		{
			IEditorViewMargin viewMargin = ViewMargin;
			if (viewMargin != null)
			{
				stringBuilder.AppendFormat(CultureInfo.CurrentCulture, Q7Z.tqM(193668), new object[1] { viewMargin.Key });
			}
			break;
		}
		case HitTestResultType.ViewTextAreaOverCharacter:
		{
			ITextSnapshotReader reader = GetReader();
			char character = reader.Character;
			string text = character switch
			{
				'\0' => Q7Z.tqM(193682), 
				'\n' => Q7Z.tqM(193696), 
				'\t' => Q7Z.tqM(193710), 
				_ => character.ToString(), 
			};
			stringBuilder.AppendFormat(CultureInfo.CurrentCulture, Q7Z.tqM(193724), Position.Line, Position.Character, reader.Offset, text);
			IToken token = reader.Token;
			if (token != null)
			{
				stringBuilder.AppendFormat(CultureInfo.CurrentCulture, Q7Z.tqM(193816), new object[1] { (!string.IsNullOrEmpty(token.Key)) ? token.Key : token.Id.ToString(CultureInfo.InvariantCulture) });
			}
			break;
		}
		}
		stringBuilder.Append(Q7Z.tqM(11640));
		return stringBuilder.ToString();
	}

	internal void KjQ(params Type[] allowedTypes)
	{
		HitTestResult hitTestResult = VisualTreeHelper.HitTest(SyntaxEditor, Location);
		if (hitTestResult != null && hitTestResult.VisualHit != null)
		{
			VisualElement = VisualTreeHelperExtended.GetAncestor(hitTestResult.VisualHit, allowedTypes) as FrameworkElement;
		}
	}

	internal static bool Oln()
	{
		return Sl7 == null;
	}

	internal static ATk Klq()
	{
		return Sl7;
	}
}
