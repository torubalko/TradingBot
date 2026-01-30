using ActiproSoftware.Internal;
using ActiproSoftware.Text.Tagging;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments.Implementation;

public abstract class IntraLineAdornmentManagerBase<TView, TTag> : AdornmentManagerBase<TView> where TView : ITextView where TTag : IIntraLineSpacerTag
{
	private static object M1H;

	protected IntraLineAdornmentManagerBase(TView view, AdornmentLayerDefinition layerDefinition)
	{
		grA.DaB7cz();
		this._002Ector(view, layerDefinition, isForLanguage: true);
	}

	protected IntraLineAdornmentManagerBase(TView view, AdornmentLayerDefinition layerDefinition, bool isForLanguage)
	{
		grA.DaB7cz();
		base._002Ector(view, layerDefinition, isForLanguage);
		view.TextAreaLayout += j8V;
	}

	private void j8V(object P_0, TextViewTextAreaLayoutEventArgs P_1)
	{
		foreach (ITextViewLine removedViewLine in P_1.RemovedViewLines)
		{
			foreach (TagSnapshotRange<TTag> intraLineSpacerTag in removedViewLine.GetIntraLineSpacerTags<TTag>())
			{
				if (intraLineSpacerTag.Tag != null && intraLineSpacerTag.Tag.Key != null)
				{
					base.AdornmentLayer.RemoveAdornments(AdornmentChangeReason.ViewLineRemoved, base.AdornmentLayer.FindAdornments(intraLineSpacerTag.Tag.Key));
				}
			}
		}
		foreach (ITextViewLine translatedViewLine in P_1.TranslatedViewLines)
		{
			foreach (TagSnapshotRange<TTag> intraLineSpacerTag2 in translatedViewLine.GetIntraLineSpacerTags<TTag>())
			{
				if (intraLineSpacerTag2.Tag != null && intraLineSpacerTag2.Tag.Key != null)
				{
					IAdornment[] array = base.AdornmentLayer.FindAdornments(intraLineSpacerTag2.Tag.Key);
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
			foreach (TagSnapshotRange<TTag> intraLineSpacerTag3 in addedOrUpdatedViewLine.GetIntraLineSpacerTags<TTag>())
			{
				if (intraLineSpacerTag3.Tag != null && intraLineSpacerTag3.Tag.Key != null)
				{
					AddAdornment(addedOrUpdatedViewLine, intraLineSpacerTag3);
				}
			}
		}
	}

	protected abstract void AddAdornment(ITextViewLine viewLine, TagSnapshotRange<TTag> tagRange);

	protected override void OnClosed()
	{
		TView view = base.View;
		view.TextAreaLayout -= j8V;
		base.OnClosed();
	}

	internal static bool n1j()
	{
		return M1H == null;
	}

	internal static object x1M()
	{
		return M1H;
	}
}
