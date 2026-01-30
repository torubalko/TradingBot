using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls.Primitives;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class IndicatorQuickInfoProvider : QuickInfoProviderBase
{
	private class B7I
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private TagSnapshotRange<IIndicatorTag> zrn;

		internal static B7I ajd;

		public override bool Equals(object P_0)
		{
			if (!(P_0 is B7I b7I))
			{
				return false;
			}
			return b7I.xrb().Equals(xrb());
		}

		public override int GetHashCode()
		{
			return xrb().GetHashCode();
		}

		[SpecialName]
		[CompilerGenerated]
		public TagSnapshotRange<IIndicatorTag> xrb()
		{
			return zrn;
		}

		[SpecialName]
		[CompilerGenerated]
		public void MrT(TagSnapshotRange<IIndicatorTag> P_0)
		{
			zrn = P_0;
		}

		public B7I()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool LjT()
		{
			return ajd == null;
		}

		internal static B7I Wjt()
		{
			return ajd;
		}
	}

	internal static IndicatorQuickInfoProvider RLN;

	protected override IEnumerable<Type> ContextTypes => new Type[1] { typeof(B7I) };

	public IndicatorQuickInfoProvider()
	{
		grA.DaB7cz();
		base._002Ector(Q7Z.tqM(7664));
	}

	public override object GetContext(IHitTestResult hitTestResult)
	{
		if (hitTestResult == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(14128));
		}
		B7I result = null;
		if (hitTestResult.Type == HitTestResultType.ViewMargin && hitTestResult.ViewMargin.Key == Q7Z.tqM(7664) && hitTestResult.View != null && hitTestResult.ViewLine != null)
		{
			ITagAggregator<IIndicatorTag> tagAggregator = hitTestResult.View.CreateTagAggregator<IIndicatorTag>();
			if (tagAggregator != null)
			{
				IEnumerable<TagSnapshotRange<IIndicatorTag>> tags = tagAggregator.GetTags(new NormalizedTextSnapshotRangeCollection(hitTestResult.ViewLine.SnapshotRange), null);
				if (tags != null)
				{
					foreach (TagSnapshotRange<IIndicatorTag> item in tags)
					{
						if (item != null && item.Tag != null && item.Tag.ContentProvider != null && hitTestResult.ViewLine.TextRange.IntersectsWith(item.SnapshotRange.StartOffset))
						{
							B7I b7I = new B7I();
							b7I.MrT(item);
							result = b7I;
						}
					}
				}
			}
		}
		return result;
	}

	public override object GetContext(IEditorView view, int offset)
	{
		return null;
	}

	protected override bool RequestSession(IEditorView view, object context)
	{
		QuickInfoSession quickInfoSession = default(QuickInfoSession);
		B7I b7I = default(B7I);
		int num;
		if (view != null)
		{
			quickInfoSession = new QuickInfoSession();
			quickInfoSession.Context = context;
			b7I = context as B7I;
			if (b7I != null)
			{
				quickInfoSession.Content = b7I.xrb().Tag.ContentProvider.GetContent();
				num = 0;
				if (!JLH())
				{
					num = 0;
				}
				goto IL_0009;
			}
		}
		goto IL_0149;
		IL_0149:
		bool result = false;
		num = 1;
		if (!JLH())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			return result;
		default:
		{
			if (quickInfoSession.Content == null)
			{
				break;
			}
			IEditorViewMargin editorViewMargin = view.Margins[Q7Z.tqM(7664)];
			ITextViewLine viewLine = view.GetViewLine(b7I.xrb().SnapshotRange.StartOffset);
			if (editorViewMargin == null || viewLine == null)
			{
				break;
			}
			Rect placementRectangle = view.TransformFromTextArea(viewLine.Bounds);
			placementRectangle.X = 0.0;
			placementRectangle.Y -= 2.0;
			placementRectangle.Width = editorViewMargin.VisualElement.ActualWidth;
			placementRectangle.Height += 4.0;
			quickInfoSession.Open(view, PlacementMode.Bottom, view.VisualElement, placementRectangle);
			result = true;
			goto case 1;
		}
		}
		goto IL_0149;
	}

	internal static bool JLH()
	{
		return RLN == null;
	}

	internal static IndicatorQuickInfoProvider uLj()
	{
		return RLN;
	}
}
