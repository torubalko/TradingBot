using System;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Tagging.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Indicators;

namespace ActiproSoftware.Internal;

internal class Ka : uT5<BookmarkIndicatorTagger, BookmarkIndicatorTag>, IBookmarkIndicatorManager, ILineIndicatorManager<BookmarkIndicatorTagger, BookmarkIndicatorTag>
{
	internal static Ka XgC;

	public Ka(IIndicatorManager P_0)
	{
		grA.DaB7cz();
		base._002Ector(P_0);
	}

	public bool ToggleEnabledState(BookmarkIndicatorTag P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192830));
		}
		IEditorDocument document = GRA().Document;
		if (document != null)
		{
			BookmarkIndicatorTagger value = null;
			if (document.Properties.TryGetValue<BookmarkIndicatorTagger>(typeof(BookmarkIndicatorTagger), out value))
			{
				TagVersionRange<BookmarkIndicatorTag> tagVersionRange = value[P_0];
				if (tagVersionRange != null)
				{
					tagVersionRange.Tag.IsEnabled = !tagVersionRange.Tag.IsEnabled;
					value.RaiseTagsChanged(new TagsChangedEventArgs(tagVersionRange.VersionRange.Translate(document.CurrentSnapshot)));
					return true;
				}
			}
		}
		return false;
	}

	internal static bool pgr()
	{
		return XgC == null;
	}

	internal static Ka IgX()
	{
		return XgC;
	}
}
