using ActiproSoftware.Internal;
using ActiproSoftware.Text.Tagging;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments.Implementation;

public abstract class IntraTextAdornmentManagerBase<TView, TTag> : AdornmentManagerBase<TView> where TView : ITextView where TTag : IIntraTextSpacerTag
{
	private static object G13;

	protected IntraTextAdornmentManagerBase(TView view, AdornmentLayerDefinition layerDefinition)
	{
		grA.DaB7cz();
		this._002Ector(view, layerDefinition, isForLanguage: true);
	}

	protected IntraTextAdornmentManagerBase(TView view, AdornmentLayerDefinition layerDefinition, bool isForLanguage)
	{
		grA.DaB7cz();
		base._002Ector(view, layerDefinition, isForLanguage);
		view.TextAreaLayout += Q8r;
	}

	private void Q8r(object P_0, TextViewTextAreaLayoutEventArgs P_1)
	{
		foreach (ITextViewLine removedViewLine in P_1.RemovedViewLines)
		{
			foreach (TagSnapshotRange<TTag> intraTextSpacerTag in removedViewLine.GetIntraTextSpacerTags<TTag>())
			{
				if (intraTextSpacerTag.Tag != null && intraTextSpacerTag.Tag.Key != null)
				{
					base.AdornmentLayer.RemoveAdornments(AdornmentChangeReason.ViewLineRemoved, base.AdornmentLayer.FindAdornments(intraTextSpacerTag.Tag.Key));
				}
			}
		}
		foreach (ITextViewLine translatedViewLine in P_1.TranslatedViewLines)
		{
			foreach (TagSnapshotRange<TTag> intraTextSpacerTag2 in translatedViewLine.GetIntraTextSpacerTags<TTag>())
			{
				if (intraTextSpacerTag2.Tag != null && intraTextSpacerTag2.Tag.Key != null)
				{
					IAdornment[] array = base.AdornmentLayer.FindAdornments(intraTextSpacerTag2.Tag.Key);
					IAdornment[] array2 = array;
					foreach (IAdornment adornment in array2)
					{
						adornment.Translate(0.0, translatedViewLine.TranslationY);
					}
				}
			}
		}
		foreach (ITextViewLine addedOrUpdatedViewLine in P_1.AddedOrUpdatedViewLines)
		{
			foreach (TagSnapshotRange<TTag> intraTextSpacerTag3 in addedOrUpdatedViewLine.GetIntraTextSpacerTags<TTag>())
			{
				if (intraTextSpacerTag3.Tag != null && intraTextSpacerTag3.Tag.Key != null)
				{
					TextBounds intraTextSpacerBounds = addedOrUpdatedViewLine.GetIntraTextSpacerBounds(intraTextSpacerTag3.Tag.Key);
					if (!intraTextSpacerBounds.IsEmpty)
					{
						AddAdornment(AdornmentChangeReason.ViewLineAddedOrUpdated, addedOrUpdatedViewLine, intraTextSpacerTag3, intraTextSpacerBounds);
					}
				}
			}
		}
	}

	protected abstract void AddAdornment(AdornmentChangeReason reason, ITextViewLine viewLine, TagSnapshotRange<TTag> tagRange, TextBounds bounds);

	protected override void OnClosed()
	{
		TView view = base.View;
		view.TextAreaLayout -= Q8r;
		base.OnClosed();
	}

	internal static bool o1v()
	{
		return G13 == null;
	}

	internal static object E1f()
	{
		return G13;
	}
}
