using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class SquiggleTagQuickInfoProvider : QuickInfoProviderBase
{
	private class I7x
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TagSnapshotRange<ISquiggleTag> Br0;

		internal static I7x RjP;

		public override bool Equals(object P_0)
		{
			if (!(P_0 is I7x i7x))
			{
				return false;
			}
			return i7x.Yr8().Equals(Yr8());
		}

		public override int GetHashCode()
		{
			return Yr8().GetHashCode();
		}

		[SpecialName]
		[CompilerGenerated]
		public TagSnapshotRange<ISquiggleTag> Yr8()
		{
			return Br0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void UrI(TagSnapshotRange<ISquiggleTag> P_0)
		{
			Br0 = P_0;
		}

		public I7x()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool wjo()
		{
			return RjP == null;
		}

		internal static I7x NjQ()
		{
			return RjP;
		}
	}

	private static SquiggleTagQuickInfoProvider FgR;

	protected override IEnumerable<Type> ContextTypes => new Type[1] { typeof(I7x) };

	public SquiggleTagQuickInfoProvider()
	{
		grA.DaB7cz();
		base._002Ector(Q7Z.tqM(14102));
	}

	public override object GetContext(IEditorView view, int offset)
	{
		if (view != null)
		{
			using ITagAggregator<ISquiggleTag> tagAggregator = view.CreateTagAggregator<ISquiggleTag>();
			foreach (TagSnapshotRange<ISquiggleTag> tag in tagAggregator.GetTags(new TextSnapshotRange(view.CurrentSnapshot, offset)))
			{
				if (tag != null && tag.Tag != null && tag.Tag.ContentProvider != null && (tag.SnapshotRange.Contains(offset) || (tag.SnapshotRange.IsZeroLength && tag.SnapshotRange.StartOffset == tag.SnapshotRange.Snapshot.Length)))
				{
					I7x i7x = new I7x();
					i7x.UrI(tag);
					return i7x;
				}
			}
		}
		return null;
	}

	protected override bool RequestSession(IEditorView view, object context)
	{
		if (view != null)
		{
			QuickInfoSession quickInfoSession = new QuickInfoSession();
			quickInfoSession.Context = context;
			if (context is I7x i7x)
			{
				quickInfoSession.Content = i7x.Yr8().Tag.ContentProvider.GetContent();
				bool flag = quickInfoSession.Content != null;
				int num = 0;
				if (!ugO())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (flag)
				{
					quickInfoSession.Open(view, i7x.Yr8().SnapshotRange.TranslateTo(view.CurrentSnapshot, TextRangeTrackingModes.Default));
					return true;
				}
			}
		}
		return false;
	}

	internal static bool ugO()
	{
		return FgR == null;
	}

	internal static SquiggleTagQuickInfoProvider Lg1()
	{
		return FgR;
	}
}
