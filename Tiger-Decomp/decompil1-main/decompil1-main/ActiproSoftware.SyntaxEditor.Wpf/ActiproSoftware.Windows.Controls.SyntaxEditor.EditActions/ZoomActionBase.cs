using System;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public abstract class ZoomActionBase : EditActionBase
{
	private static ZoomActionBase kZE;

	protected ZoomActionBase(string text)
	{
		grA.DaB7cz();
		base._002Ector(text);
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		return (view.SyntaxEditor.ZoomModesAllowed & ZoomModes.Keyboard) == ZoomModes.Keyboard;
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	protected internal static void IncrementZoomLevel(IEditorView view, double factor)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		SyntaxEditor syntaxEditor = view.SyntaxEditor;
		double num = factor * Math.Max(0.05, Math.Min(1.0, syntaxEditor.ZoomLevelIncrement));
		double num2 = syntaxEditor.axs(syntaxEditor.ZoomLevel + num, _0020: true);
		if (syntaxEditor.ZoomLevel != num2)
		{
			syntaxEditor.ZoomLevel = num2;
		}
	}

	internal static bool xZw()
	{
		return kZE == null;
	}

	internal static ZoomActionBase JZu()
	{
		return kZE;
	}
}
