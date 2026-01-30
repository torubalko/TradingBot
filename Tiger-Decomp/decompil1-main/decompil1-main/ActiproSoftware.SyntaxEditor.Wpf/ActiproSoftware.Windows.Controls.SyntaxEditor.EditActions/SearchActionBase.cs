using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public abstract class SearchActionBase : EditActionBase
{
	internal static SearchActionBase lJS;

	protected SearchActionBase(string text)
	{
		grA.DaB7cz();
		base._002Ector(text);
	}

	internal static bool wnG(IEditorView P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		TextPositionRange positionRange = P_0.Selection.PositionRange;
		if (positionRange.Lines == 1)
		{
			return true;
		}
		if (positionRange.Lines == 2 && positionRange.LastPosition.Character == 0)
		{
			return true;
		}
		return false;
	}

	protected virtual bool UpdateSearchOptionsFindTextFromSelection(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IEditorSearchOptions searchOptions = view.SyntaxEditor.SearchOptions;
		if (searchOptions != null && wnG(view))
		{
			string text;
			if (view.Selection.IsZeroLength)
			{
				text = view.CurrentSnapshot.GetSubstring(view.GetCurrentWordTextRange(), LineTerminator.Newline);
				if (text.Trim().Length == 0)
				{
					return false;
				}
			}
			else
			{
				text = ((view.Selection.PositionRange.Lines != 2) ? view.CurrentSnapshot.GetSubstring(view.Selection.TextRange, LineTerminator.Newline) : view.CurrentSnapshot.GetSubstring(view.Selection.FirstOffset, Math.Max(0, view.Selection.Length - 1), LineTerminator.Newline));
			}
			if (view.Selection.IsNormalized)
			{
				int num = text.LastIndexOf('\n');
				if (num != -1)
				{
					text = text.Substring(num + 1);
				}
			}
			else
			{
				int num2 = text.IndexOf('\n');
				if (num2 != -1)
				{
					text = text.Substring(0, num2);
				}
			}
			searchOptions.FindText = text;
			return true;
		}
		return false;
	}

	internal static bool kJk()
	{
		return lJS == null;
	}

	internal static SearchActionBase mJZ()
	{
		return lJS;
	}
}
