using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class CollapsedRegionQuickInfoProvider : QuickInfoProviderBase
{
	private class d7M
	{
		public TagSnapshotRange<IIntraTextSpacerTag> WrR;

		private static d7M ojZ;

		public override bool Equals(object P_0)
		{
			if (!(P_0 is d7M d7M))
			{
				return false;
			}
			return d7M.WrR.Equals(WrR);
		}

		public override int GetHashCode()
		{
			return WrR.GetHashCode();
		}

		public d7M()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool pjF()
		{
			return ojZ == null;
		}

		internal static d7M Hj9()
		{
			return ojZ;
		}
	}

	private int qu7;

	private int Hui;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool kup;

	private static CollapsedRegionQuickInfoProvider Raj;

	protected override IEnumerable<Type> ContextTypes => new Type[1] { typeof(d7M) };

	public bool IsSyntaxHighlightingEnabled
	{
		[CompilerGenerated]
		get
		{
			return kup;
		}
		[CompilerGenerated]
		set
		{
			kup = value;
		}
	}

	public CollapsedRegionQuickInfoProvider()
	{
		grA.DaB7cz();
		qu7 = 25;
		Hui = 1000;
		kup = true;
		base._002Ector(Q7Z.tqM(14068), new Ordering(Q7Z.tqM(14102), OrderPlacement.After));
	}

	protected virtual object GetContent(IEditorView view, TextSnapshotRange snapshotRange)
	{
		if (!IsSyntaxHighlightingEnabled)
		{
			return PlainTextContentProvider.l30(snapshotRange, qu7, Hui).GetContent();
		}
		return HtmlContentProvider.lFf(view.HighlightingStyleRegistry, snapshotRange, qu7, Hui).GetContent();
	}

	public override object GetContext(IHitTestResult hitTestResult)
	{
		if (hitTestResult == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(14128));
		}
		if (hitTestResult.Type == HitTestResultType.ViewTextAreaOverIntraTextSpacer && hitTestResult.IntraTextSpacerTag != null)
		{
			_ = hitTestResult.IntraTextSpacerTag.SnapshotRange;
			if (!hitTestResult.IntraTextSpacerTag.SnapshotRange.IsZeroLength && hitTestResult.IntraTextSpacerTag.Tag is ICollapsedRegionTag)
			{
				return new d7M
				{
					WrR = hitTestResult.IntraTextSpacerTag
				};
			}
		}
		return null;
	}

	public override object GetContext(IEditorView view, int offset)
	{
		return null;
	}

	protected override bool RequestSession(IEditorView view, object context)
	{
		QuickInfoSession quickInfoSession = new QuickInfoSession();
		quickInfoSession.Context = context;
		if (context is d7M d7M)
		{
			TextSnapshotRange snapshotRange = d7M.WrR.SnapshotRange;
			quickInfoSession.Content = GetContent(view, snapshotRange);
			quickInfoSession.Open(view, snapshotRange.TextRange);
			return true;
		}
		return false;
	}

	internal static bool NaM()
	{
		return Raj == null;
	}

	internal static CollapsedRegionQuickInfoProvider Fa3()
	{
		return Raj;
	}
}
