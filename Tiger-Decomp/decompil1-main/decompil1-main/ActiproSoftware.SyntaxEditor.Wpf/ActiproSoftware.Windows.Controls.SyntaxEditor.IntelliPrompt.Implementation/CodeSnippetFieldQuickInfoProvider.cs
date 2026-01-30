using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class CodeSnippetFieldQuickInfoProvider : QuickInfoProviderBase
{
	private class W7Q
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private TagSnapshotRange<Xx> Lrg;

		internal static W7Q fHU;

		public override bool Equals(object P_0)
		{
			if (P_0 is W7Q w7Q)
			{
				return w7Q.prK().Equals(prK());
			}
			return false;
		}

		public override int GetHashCode()
		{
			return prK().GetHashCode();
		}

		[SpecialName]
		[CompilerGenerated]
		public TagSnapshotRange<Xx> prK()
		{
			return Lrg;
		}

		[SpecialName]
		[CompilerGenerated]
		public void brf(TagSnapshotRange<Xx> P_0)
		{
			Lrg = P_0;
		}

		public W7Q()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool YHe()
		{
			return fHU == null;
		}

		internal static W7Q PHz()
		{
			return fHU;
		}
	}

	private static CodeSnippetFieldQuickInfoProvider bxC;

	protected override IEnumerable<Type> ContextTypes => new Type[1] { typeof(W7Q) };

	public CodeSnippetFieldQuickInfoProvider()
	{
		grA.DaB7cz();
		base._002Ector(Q7Z.tqM(216));
	}

	public override object GetContext(IEditorView view, int offset)
	{
		if (view != null)
		{
			using ITagAggregator<Xx> tagAggregator = view.CreateTagAggregator<Xx>();
			foreach (TagSnapshotRange<Xx> tag in tagAggregator.GetTags(new TextSnapshotRange(view.CurrentSnapshot, offset)))
			{
				if (tag == null || tag.Tag == null || tag.Tag.xCH() == null || string.IsNullOrEmpty(tag.Tag.xCH().ToolTip) || (!tag.SnapshotRange.Contains(offset) && (!tag.SnapshotRange.IsZeroLength || tag.SnapshotRange.StartOffset != tag.SnapshotRange.Snapshot.Length)))
				{
					continue;
				}
				W7Q w7Q = new W7Q();
				w7Q.brf(tag);
				return w7Q;
			}
		}
		return null;
	}

	protected override bool RequestSession(IEditorView view, object context)
	{
		QuickInfoSession quickInfoSession;
		int num;
		if (view != null)
		{
			quickInfoSession = new QuickInfoSession();
			quickInfoSession.Context = context;
			if (context is W7Q w7Q)
			{
				string toolTip = w7Q.prK().Tag.xCH().ToolTip;
				if (!string.IsNullOrEmpty(toolTip))
				{
					num = 0;
					if (FxX() != null)
					{
						goto IL_0005;
					}
					goto IL_0009;
				}
			}
		}
		goto IL_0093;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001b;
			case 1:
				break;
			}
			break;
			IL_001b:
			quickInfoSession.Content = new PlainTextContentProvider(w7Q.prK().Tag.xCH().ToolTip).GetContent();
			flag = quickInfoSession.Content != null;
			num = 1;
			if (FxX() == null)
			{
				continue;
			}
			goto IL_0005;
		}
		if (flag)
		{
			quickInfoSession.Open(view, w7Q.prK().SnapshotRange.TranslateTo(view.CurrentSnapshot, TextRangeTrackingModes.Default));
			return true;
		}
		goto IL_0093;
		IL_0093:
		return false;
	}

	internal static bool Lxr()
	{
		return bxC == null;
	}

	internal static CodeSnippetFieldQuickInfoProvider FxX()
	{
		return bxC;
	}
}
