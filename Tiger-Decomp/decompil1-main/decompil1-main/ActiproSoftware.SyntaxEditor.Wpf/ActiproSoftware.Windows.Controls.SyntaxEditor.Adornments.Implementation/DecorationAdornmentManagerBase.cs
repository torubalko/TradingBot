using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments.Implementation;

public abstract class DecorationAdornmentManagerBase<TView, TTag> : AdornmentManagerBase<TView> where TView : ITextView where TTag : ITag
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public TagsChangedEventArgs e;

		public DecorationAdornmentManagerBase<TView, TTag> _003C_003E4__this;

		internal static object UfF;

		public _003C_003Ec__DisplayClass4_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void jyC(object o)
		{
			TextRange textRange = ((e.SnapshotRange.Snapshot.Document != _003C_003E4__this.View.CurrentSnapshot.Document) ? ((TextRange)_003C_003E4__this.View.CurrentSnapshot.SnapshotRange) : e.SnapshotRange.TranslateTo(_003C_003E4__this.View.CurrentSnapshot, TextRangeTrackingModes.Default).TextRange);
			_003C_003E4__this.c8Y(textRange);
		}

		internal static bool Lf9()
		{
			return UfF == null;
		}

		internal static object ofJ()
		{
			return UfF;
		}
	}

	private ITagAggregator<TTag> l84;

	internal static object N1A;

	protected DecorationAdornmentManagerBase(TView view, AdornmentLayerDefinition layerDefinition)
	{
		grA.DaB7cz();
		this._002Ector(view, layerDefinition, isForLanguage: true);
	}

	protected DecorationAdornmentManagerBase(TView view, AdornmentLayerDefinition layerDefinition, bool isForLanguage)
	{
		grA.DaB7cz();
		base._002Ector(view, layerDefinition, isForLanguage);
		l84 = view.CreateTagAggregator<TTag>();
		l84.TagsChanged += q83;
		EventHandler<TextViewTextAreaLayoutEventArgs> value = a8R;
		view.TextAreaLayout += value;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void O8F(AdornmentChangeReason P_0, ITextViewLine P_1)
	{
		IEnumerable<TagSnapshotRange<TTag>> tags = l84.GetTags(new NormalizedTextSnapshotRangeCollection(P_1.VisibleSnapshotRanges, mergeSequentialRanges: true), null);
		if (tags == null)
		{
			return;
		}
		foreach (TagSnapshotRange<TTag> item in tags)
		{
			TextRange textRange = TextRange.Intersect(P_1.TextRangeIncludingLineTerminator, item.SnapshotRange.TextRange);
			if (!textRange.IsZeroLength)
			{
				if (base.View != null && base.View.CollapsedRegionManager != null)
				{
					NormalizedTextSnapshotRangeCollection collapsedRanges = base.View.CollapsedRegionManager.GetCollapsedRanges(item.SnapshotRange);
					if (collapsedRanges != null)
					{
						foreach (TextSnapshotRange item2 in collapsedRanges)
						{
							if (textRange.StartOffset < item2.StartOffset)
							{
								if (textRange.EndOffset <= item2.StartOffset)
								{
									break;
								}
								if (textRange.EndOffset <= item2.EndOffset)
								{
									textRange = new TextRange(Math.Min(item2.StartOffset, textRange.StartOffset), item2.StartOffset);
									continue;
								}
								TextRange textRange2 = new TextRange(Math.Min(item2.StartOffset, textRange.StartOffset), item2.StartOffset);
								if (!textRange2.IsDeleted && !textRange2.IsZeroLength)
								{
									IEnumerable<TextBounds> textBounds = P_1.GetTextBounds(textRange2);
									if (textBounds != null)
									{
										foreach (TextBounds item3 in textBounds)
										{
											AddAdornment(P_0, P_1, item, item3);
										}
									}
								}
								textRange = new TextRange(item2.EndOffset, Math.Max(item2.EndOffset, textRange.EndOffset));
							}
							else if (textRange.StartOffset < item2.EndOffset)
							{
								if (textRange.EndOffset <= item2.EndOffset)
								{
									textRange = TextRange.Deleted;
									break;
								}
								textRange = new TextRange(item2.EndOffset, Math.Max(item2.EndOffset, textRange.EndOffset));
							}
						}
					}
				}
				if (textRange.IsDeleted || textRange.IsZeroLength)
				{
					continue;
				}
				IEnumerable<TextBounds> textBounds2 = P_1.GetTextBounds(textRange);
				if (textBounds2 == null)
				{
					continue;
				}
				foreach (TextBounds item4 in textBounds2)
				{
					AddAdornment(P_0, P_1, item, item4);
				}
			}
			else if (!textRange.IsDeleted && item.SnapshotRange.StartOffset == P_1.EndOffset && item.SnapshotRange.StartOffset == item.SnapshotRange.Snapshot.Length)
			{
				TextBounds[] array = P_1.GetTextBounds(textRange).ToArray();
				if (array != null && array.Length == 1)
				{
					AddAdornment(P_0, P_1, item, array[0]);
				}
			}
		}
	}

	private void q83(object P_0, TagsChangedEventArgs P_1)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals8.e = P_1;
		CS_0024_003C_003E8__locals8._003C_003E4__this = this;
		vAE.l0x<object>(base.View.SyntaxEditor, delegate
		{
			TextRange textRange = ((CS_0024_003C_003E8__locals8.e.SnapshotRange.Snapshot.Document != CS_0024_003C_003E8__locals8._003C_003E4__this.View.CurrentSnapshot.Document) ? ((TextRange)CS_0024_003C_003E8__locals8._003C_003E4__this.View.CurrentSnapshot.SnapshotRange) : CS_0024_003C_003E8__locals8.e.SnapshotRange.TranslateTo(CS_0024_003C_003E8__locals8._003C_003E4__this.View.CurrentSnapshot, TextRangeTrackingModes.Default).TextRange);
			CS_0024_003C_003E8__locals8._003C_003E4__this.c8Y(textRange);
		}, null);
	}

	private void a8R(object P_0, TextViewTextAreaLayoutEventArgs P_1)
	{
		foreach (ITextViewLine addedOrUpdatedViewLine in P_1.AddedOrUpdatedViewLines)
		{
			O8F(AdornmentChangeReason.ViewLineAddedOrUpdated, addedOrUpdatedViewLine);
		}
		int num3 = default(int);
		foreach (ITextViewLine translatedViewLine in P_1.TranslatedViewLines)
		{
			IAdornment[] array = base.AdornmentLayer.FindAdornments(translatedViewLine);
			IAdornment[] array2 = array;
			int num = 0;
			while (num < array2.Length)
			{
				IAdornment adornment = array2[num];
				adornment.Translate(0.0, translatedViewLine.TranslationY);
				num++;
				int num2 = 0;
				if (!x1l())
				{
					num2 = num3;
				}
				switch (num2)
				{
				}
			}
		}
		foreach (ITextViewLine removedViewLine in P_1.RemovedViewLines)
		{
			base.AdornmentLayer.RemoveAdornments(AdornmentChangeReason.ViewLineRemoved, base.AdornmentLayer.FindAdornments(removedViewLine));
		}
	}

	private void c8Y(TextRange P_0)
	{
		foreach (ITextViewLine visibleViewLine in base.View.VisibleViewLines)
		{
			if (visibleViewLine.TextRangeIncludingLineTerminator.OverlapsWith(P_0) || (visibleViewLine.StartOffset == P_0.EndOffset && visibleViewLine.TextRange.IsZeroLength && visibleViewLine.IsLastLine) || (visibleViewLine.EndOffset == P_0.StartOffset && P_0.IsZeroLength && visibleViewLine.IsLastLine))
			{
				base.AdornmentLayer.RemoveAdornments(AdornmentChangeReason.TagsChanged, base.AdornmentLayer.FindAdornments(visibleViewLine));
				O8F(AdornmentChangeReason.TagsChanged, visibleViewLine);
			}
		}
	}

	protected abstract void AddAdornment(AdornmentChangeReason reason, ITextViewLine viewLine, TagSnapshotRange<TTag> tagRange, TextBounds bounds);

	protected override void OnClosed()
	{
		l84.TagsChanged -= q83;
		TView view = base.View;
		view.TextAreaLayout -= a8R;
		l84.Dispose();
		base.OnClosed();
	}

	internal static bool x1l()
	{
		return N1A == null;
	}

	internal static object j1W()
	{
		return N1A;
	}
}
