using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;
using ActiproSoftware.Windows.Data.Filtering;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
[TemplateVisualState(Name = "PartialUnselected", GroupName = "PartialSelectionStates")]
[TemplateVisualState(Name = "PartialSelected", GroupName = "PartialSelectionStates")]
[ToolboxItem(false)]
public class IntelliPromptCompletionListBoxItem : ListBoxItem
{
	private DateTime Fej;

	private Point Jew;

	public static readonly DependencyProperty HighlightedCapturesProperty;

	public static readonly DependencyProperty IsPartialSelectionProperty;

	internal static IntelliPromptCompletionListBoxItem OBs;

	public bool IsPartialSelection
	{
		get
		{
			return (bool)GetValue(IsPartialSelectionProperty);
		}
		set
		{
			SetValue(IsPartialSelectionProperty, value);
		}
	}

	public IntelliPromptCompletionListBoxItem()
	{
		grA.DaB7cz();
		Fej = DateTime.Today;
		base._002Ector();
		base.DefaultStyleKey = typeof(IntelliPromptCompletionListBoxItem);
	}

	internal void oeF(CompletionSession P_0, bool P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8536));
		}
		if (P_1)
		{
			P_0.Closed += yeR;
			P_0.t1I(heY);
			Re4(P_0);
		}
		else
		{
			P_0.Closed -= yeR;
			P_0.e15(heY);
		}
	}

	private static void ve3(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		IntelliPromptCompletionListBoxItem intelliPromptCompletionListBoxItem = (IntelliPromptCompletionListBoxItem)P_0;
		intelliPromptCompletionListBoxItem.yeo();
	}

	private void yeR(object P_0, CancelEventArgs P_1)
	{
		CompletionSession completionSession = (CompletionSession)P_0;
		oeF(completionSession, _0020: false);
	}

	private void heY(object P_0, EventArgs P_1)
	{
		CompletionSession completionSession = (CompletionSession)P_0;
		Re4(completionSession);
	}

	private void Re4(CompletionSession P_0)
	{
		ICompletionItem completionItem = (ICompletionItem)base.Content;
		IList<StringFilterCapture> highlightedCaptures = GetHighlightedCaptures(this);
		StringFilterCapture[] array = P_0.K1F(completionItem).ToArray();
		if ((highlightedCaptures != null && highlightedCaptures.Count != 0) || array.Length != 0)
		{
			SetHighlightedCaptures(this, array);
		}
	}

	private void yeo()
	{
		if (!IsPartialSelection)
		{
			VisualStateManager.GoToState(this, Q7Z.tqM(9216), useTransitions: false);
		}
		else
		{
			VisualStateManager.GoToState(this, Q7Z.tqM(9182), useTransitions: false);
		}
	}

	public static IList<StringFilterCapture> GetHighlightedCaptures(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(9254));
		}
		return (IList<StringFilterCapture>)obj.GetValue(HighlightedCapturesProperty);
	}

	public static void SetHighlightedCaptures(DependencyObject obj, IList<StringFilterCapture> value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(9254));
		}
		obj.SetValue(HighlightedCapturesProperty, value);
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		yeo();
	}

	protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		base.OnMouseLeftButtonDown(e);
		Point position = e.GetPosition(this);
		bool flag = vAE.L0A(Jew, position, Fej, DateTime.Now, _0020: false);
		Fej = DateTime.Now;
		Jew = position;
		IntelliPromptCompletionList ancestor = VisualTreeHelperExtended.GetAncestor<IntelliPromptCompletionList>(this);
		if (ancestor != null)
		{
			ICompletionSession session = ancestor.Session;
			if (session != null)
			{
				if (flag && session.Selection != null)
				{
					if (ItemsControl.ItemsControlFromItemContainer(this) is ListBox listBox)
					{
						listBox.ReleaseMouseCapture();
					}
					session.View?.Focus();
					session.Commit();
				}
				else
				{
					ancestor.IQN(new CompletionSelection((ICompletionItem)base.Content, CompletionSelectionState.Full), _0020: false);
				}
			}
		}
		e.Handled = true;
	}

	static IntelliPromptCompletionListBoxItem()
	{
		grA.DaB7cz();
		HighlightedCapturesProperty = DependencyProperty.RegisterAttached(Q7Z.tqM(9264), typeof(IList<StringFilterCapture>), typeof(IntelliPromptCompletionListBoxItem), new PropertyMetadata(null));
		IsPartialSelectionProperty = DependencyProperty.Register(Q7Z.tqM(9142), typeof(bool), typeof(IntelliPromptCompletionListBoxItem), new PropertyMetadata(false, ve3));
	}

	internal static bool ABP()
	{
		return OBs == null;
	}

	internal static IntelliPromptCompletionListBoxItem aBo()
	{
		return OBs;
	}
}
