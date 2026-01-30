using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Internal;

internal class PAB : AdornmentManagerBase<IEditorView>
{
	private IAdornment G81;

	internal static PAB t1a;

	private PAB(IEditorView P_0)
	{
		grA.DaB7cz();
		base._002Ector(P_0, AdornmentLayerDefinitions.Highlight, isForLanguage: false);
		G81 = base.AdornmentLayer.AddAdornment(AdornmentChangeReason.Other, o8A, default(Rect), this, null);
		V8C();
		P_0.SyntaxEditor.ActiveViewChanged += S8v;
		P_0.TextAreaLayout += K8m;
	}

	private void o8A(TextViewDrawContext P_0, IAdornment P_1)
	{
		IEditorView view = base.View;
		if (!base.IsActive)
		{
			return;
		}
		ITextViewLine viewLine = view.GetViewLine(view.Selection.EndPosition);
		if (viewLine.Visibility != TextViewLineVisibility.Hidden)
		{
			Rect textAreaBounds = P_0.TextAreaBounds;
			Rect textBounds = viewLine.TextBounds;
			Rect bounds = new Rect(textAreaBounds.X, textAreaBounds.Y + textBounds.Y, textAreaBounds.Width, textBounds.Height).h0e();
			Brush currentLineBackground = P_0.CurrentLineBackground;
			if (currentLineBackground != null)
			{
				P_0.FillRectangle(bounds, currentLineBackground);
			}
			Pen currentLineBorderPen = P_0.CurrentLineBorderPen;
			if (currentLineBorderPen != null)
			{
				P_0.DrawRectangle(bounds, currentLineBorderPen);
			}
		}
	}

	private void S8v(object P_0, EditorViewChangedEventArgs P_1)
	{
		V8C();
	}

	private void K8m(object P_0, TextViewTextAreaLayoutEventArgs P_1)
	{
		V8C();
	}

	private void V8C()
	{
		IEditorView view = base.View;
		base.IsActive = view.SyntaxEditor.IsCurrentLineHighlightingEnabled && view.IsActive;
	}

	[SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments.Implementation.CurrentLineHighlightManager")]
	public static void A8u(IEditorView P_0)
	{
		new PAB(P_0);
	}

	protected override void OnClosed()
	{
		IEditorView view = base.View;
		view.SyntaxEditor.ActiveViewChanged -= S8v;
		view.TextAreaLayout -= K8m;
		if (G81 != null)
		{
			base.AdornmentLayer.RemoveAdornment(AdornmentChangeReason.ManagerClosed, G81);
			G81 = null;
		}
		base.OnClosed();
	}

	protected override void OnIsActiveChanged()
	{
		base.View.InvalidateRender();
	}

	internal static bool p1L()
	{
		return t1a == null;
	}

	internal static PAB R1g()
	{
		return t1a;
	}
}
