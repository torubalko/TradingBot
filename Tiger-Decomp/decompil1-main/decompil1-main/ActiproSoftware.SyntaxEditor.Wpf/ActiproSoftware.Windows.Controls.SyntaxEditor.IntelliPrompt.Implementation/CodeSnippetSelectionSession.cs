using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.Primitives;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class CodeSnippetSelectionSession : IntelliPromptSessionBase, ICodeSnippetSelectionSession, IIntelliPromptSession, IServiceLocator, IEditorViewPointerInputEventSink, INotifyPropertyChanged
{
	private class I7R : CompletionSession
	{
		private CodeSnippetSelectionSession SrA;

		private static I7R jjx;

		protected override Rect? PlacementRectangle
		{
			get
			{
				Rect? bounds = SrA.Bounds;
				if (bounds.HasValue && !bounds.Value.IsEmpty)
				{
					double num = 1.0;
					return new Rect((int)Math.Round(bounds.Value.X + SrA.VuF.CurrentInputTextHorizontalOffset + num), (int)Math.Ceiling(bounds.Value.Y), 0.0, (int)Math.Ceiling(bounds.Value.Height));
				}
				return null;
			}
		}

		public I7R(CodeSnippetSelectionSession P_0)
		{
			grA.DaB7cz();
			base._002Ector();
			if (P_0 == null)
			{
				throw new ArgumentNullException(Q7Z.tqM(219528));
			}
			SrA = P_0;
		}

		protected override void OnCommitting(CancelEventArgs P_0)
		{
			if (P_0 == null)
			{
				int num = 0;
				if (!kja())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
					throw new ArgumentNullException(Q7Z.tqM(1014));
				}
			}
			P_0.Cancel = true;
			if (!(base.Selection.Item.Tag is ICodeSnippetMetadata codeSnippetMetadata))
			{
				if (base.Selection.Item.Tag is ICodeSnippetFolder codeSnippetFolder)
				{
					SrA.EuD(codeSnippetFolder);
				}
				else
				{
					Close(cancelled: true);
				}
			}
			else
			{
				SrA.Hux(codeSnippetMetadata);
			}
		}

		protected override void OnViewKeyDown(IEditorView P_0, KeyEventArgs P_1)
		{
			if (P_1 == null)
			{
				throw new ArgumentNullException(Q7Z.tqM(1014));
			}
			switch (P_1.Key)
			{
			case Key.Back:
				SrA.wuX();
				P_1.Handled = true;
				break;
			case Key.Return:
				if (base.Selection != null)
				{
					Commit();
				}
				P_1.Handled = true;
				break;
			case Key.Escape:
				SrA.Close(cancelled: true);
				P_1.Handled = true;
				break;
			case Key.Left:
			case Key.Right:
				P_1.Handled = true;
				break;
			default:
				base.OnViewKeyDown(P_0, P_1);
				break;
			}
		}

		protected override void OnViewSelectionChanged(IEditorView P_0, EditorViewSelectionEventArgs P_1)
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException(Q7Z.tqM(952));
			}
			if (!base.SnapshotRange.IntersectsWith(P_0.Selection.EndOffset))
			{
				SrA.Close(cancelled: true);
			}
		}

		protected override void OnViewTextInput(IEditorView P_0, TextCompositionEventArgs P_1)
		{
			int num = 1;
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				do
				{
					switch (num2)
					{
					default:
						if (flag)
						{
							throw new ArgumentNullException(Q7Z.tqM(1014));
						}
						if (!string.IsNullOrEmpty(P_1.Text) && P_1.Text.Length > 0 && !char.IsControl(P_1.Text[0]))
						{
							SrA.nuG(P_1.Text);
							P_1.Handled = true;
						}
						return;
					case 1:
						break;
					}
					flag = P_1 == null;
					num2 = 0;
				}
				while (kja());
			}
		}

		internal static bool kja()
		{
			return jjx == null;
		}

		internal static I7R VjL()
		{
			return jjx;
		}
	}

	private I7R Juv;

	private string Fum;

	private List<ICodeSnippetFolder> BuC;

	private string muu;

	private ICodeSnippetFolder Uu1;

	private IntelliPromptCodeSnippetSelector VuF;

	private Popup ju3;

	internal static CodeSnippetSelectionSession Dak;

	public override Rect? Bounds => (ju3 != null) ? GetPopupBounds(ju3) : ((Rect?)null);

	protected override bool CanOpenForReadOnlyTextRanges => false;

	public override bool ClosesOnLostFocus => true;

	public string Label
	{
		get
		{
			return muu;
		}
		set
		{
			if (!(muu == value))
			{
				muu = value;
				NotifyPropertyChanged(Q7Z.tqM(12632));
			}
		}
	}

	public ICodeSnippetFolder RootFolder
	{
		get
		{
			return Uu1;
		}
		set
		{
			if (Uu1 != value)
			{
				Uu1 = value;
				NotifyPropertyChanged(Q7Z.tqM(12646));
			}
		}
	}

	public override IIntelliPromptSessionType SessionType => IntelliPromptSessionTypes.CodeSnippetSelection;

	public event PropertyChangedEventHandler PropertyChanged;

	public CodeSnippetSelectionSession()
	{
		grA.DaB7cz();
		Fum = string.Empty;
		BuC = new List<ICodeSnippetFolder>();
		base._002Ector();
		RegisterService((IEditorViewPointerInputEventSink)this);
	}

	void IEditorViewPointerInputEventSink.NotifyPointerEntered(IEditorView view, InputPointerEventArgs e)
	{
	}

	void IEditorViewPointerInputEventSink.NotifyPointerExited(IEditorView view, InputPointerEventArgs e)
	{
	}

	void IEditorViewPointerInputEventSink.NotifyPointerHovered(IEditorView view, InputPointerEventArgs e)
	{
	}

	void IEditorViewPointerInputEventSink.NotifyPointerMoved(IEditorView view, InputPointerEventArgs e)
	{
	}

	void IEditorViewPointerInputEventSink.NotifyPointerPressed(IEditorView view, InputPointerButtonEventArgs e)
	{
		OnViewPointerPressed(view, e);
	}

	void IEditorViewPointerInputEventSink.NotifyPointerReleased(IEditorView view, InputPointerButtonEventArgs e)
	{
	}

	void IEditorViewPointerInputEventSink.NotifyPointerWheel(IEditorView view, InputPointerWheelEventArgs e)
	{
	}

	internal void Hux(ICodeSnippetMetadata P_0)
	{
		IEditorView view = base.View;
		Close(cancelled: false);
		ICodeSnippet codeSnippet = P_0.GetCodeSnippet();
		if (codeSnippet != null)
		{
			CodeSnippetTemplateSession codeSnippetTemplateSession = new CodeSnippetTemplateSession();
			codeSnippetTemplateSession.XuB(value: false);
			codeSnippetTemplateSession.CodeSnippet = codeSnippet;
			codeSnippetTemplateSession.Open(view);
			int num = 0;
			if (NaF() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		if (view != null && !vAE.E0C(view))
		{
			view.Focus();
		}
	}

	private void nuG(string P_0)
	{
		Qug(Fum + P_0);
	}

	private void wuX()
	{
		if (Fum.Length <= 0)
		{
			Cuf();
		}
		else
		{
			Qug(Fum.Substring(0, Fum.Length - 1));
		}
	}

	private void wuK(object P_0, object P_1)
	{
		if (base.IsOpen)
		{
			Close(cancelled: true);
		}
	}

	internal void Cuf()
	{
		if (BuC.Count > 1)
		{
			VuF.LQH();
			ICodeSnippetFolder codeSnippetFolder = BuC[BuC.Count - 1];
			BuC.Remove(codeSnippetFolder);
			ICodeSnippetFolder codeSnippetFolder2 = BuC[BuC.Count - 1];
			puQ(codeSnippetFolder2);
			Qug(codeSnippetFolder.Name);
		}
	}

	private void EuD(ICodeSnippetFolder P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12510));
		}
		Qug(P_0.Name);
		BuC.Add(P_0);
		VuF.gQb(P_0);
		Qug(string.Empty);
		puQ(P_0);
	}

	private void Qug(string P_0)
	{
		if (Fum == P_0)
		{
			return;
		}
		Fum = P_0;
		int num = 0;
		if (NaF() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (Juv != null)
		{
			Juv.R16(Fum, _0020: true);
		}
		if (VuF != null)
		{
			VuF.gQL(Fum);
		}
	}

	private void puQ(ICodeSnippetFolder P_0)
	{
		if (Juv != null)
		{
			Juv.Close(cancelled: true);
		}
		IEditorView view = base.View;
		if (view == null || P_0 == null)
		{
			return;
		}
		if (Juv == null)
		{
			Juv = new I7R(this);
		}
		else
		{
			Juv.Items.Clear();
		}
		CommonImageSourceProvider imageSourceProvider = new CommonImageSourceProvider(CommonImageKind.FolderClosed);
		foreach (ICodeSnippetFolder folder in P_0.Folders)
		{
			Juv.Items.Add(new CompletionItem(folder.Name, imageSourceProvider, folder));
		}
		imageSourceProvider = new CommonImageSourceProvider(CommonImageKind.CodeSnippet);
		foreach (ICodeSnippetMetadata item in P_0.Items)
		{
			Juv.Items.Add(new CompletionItem(item.Title, imageSourceProvider, CreateDescriptionProvider(item), item.Title, null, item));
		}
		OnCompletionSessionInitializing(Juv);
		Juv.Reposition();
		Juv.Open(view, new TextRange(view.Selection.EndOffset));
		view.Focus();
	}

	protected virtual IContentProvider CreateDescriptionProvider(ICodeSnippetMetadata metadata)
	{
		if (metadata != null)
		{
			bool flag = !string.IsNullOrEmpty(metadata.Description);
			bool flag2 = !string.IsNullOrEmpty(metadata.Shortcut);
			if (flag || flag2)
			{
				StringBuilder stringBuilder = new StringBuilder();
				IHighlightingStyleRegistry registry = ((base.View != null) ? base.View.HighlightingStyleRegistry : null);
				if (flag)
				{
					stringBuilder.Append(Q7Z.tqM(12526) + HtmlContentProvider.GetCommentForegroundColor(registry).ToWebColor() + Q7Z.tqM(12570));
					stringBuilder.Append(HtmlContentProvider.Escape(metadata.Description));
					stringBuilder.Append(Q7Z.tqM(12580));
				}
				if (flag2)
				{
					if (flag)
					{
						stringBuilder.Append(Q7Z.tqM(12598));
					}
					stringBuilder.Append(Q7Z.tqM(12526) + HtmlContentProvider.GetNeutralForegroundColor(registry).ToWebColor() + Q7Z.tqM(12570));
					stringBuilder.Append(HtmlContentProvider.Escape(SR.GetString(SRName.UIIntelliPromptPopupContentCodeSnippetShortcutPrefix)));
					stringBuilder.Append(Q7Z.tqM(12612));
					stringBuilder.Append(HtmlContentProvider.Escape(metadata.Shortcut));
				}
				return new HtmlContentProvider(stringBuilder.ToString());
			}
		}
		return null;
	}

	protected void NotifyPropertyChanged(string name)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}

	protected override void OnClosed(CancelEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		if (Juv != null)
		{
			Juv.Close(e.Cancel);
			Juv = null;
		}
		Due();
		Fum = string.Empty;
		BuC.Clear();
		base.OnClosed(e);
	}

	protected virtual void OnCompletionSessionInitializing(ICompletionSession session)
	{
		if (session == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8536));
		}
		session.SortItems();
	}

	protected override void OnOpened(EventArgs e)
	{
		if (RootFolder == null || RootFolder.Folders == null || RootFolder.Items == null || RootFolder.Folders.Count + RootFolder.Items.Count == 0)
		{
			Close(cancelled: true);
			return;
		}
		Fum = string.Empty;
		BuC.Clear();
		BuC.Add(RootFolder);
		if (!nul())
		{
			Close(cancelled: true);
			return;
		}
		Reposition();
		if (ju3 != null)
		{
			ju3.IsOpen = true;
			VuF.kQT(_0020: true);
			puQ(RootFolder);
			base.OnOpened(e);
		}
	}

	protected virtual void OnViewPointerPressed(IEditorView view, InputPointerButtonEventArgs e)
	{
		Close(cancelled: true);
	}

	public void Open(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		Open(view, view.Selection.TextRange);
	}

	private void Due()
	{
		if (ju3 != null)
		{
			ju3.Closed -= wuK;
			ju3.IsKeyboardFocusWithinChanged -= PuA;
			ju3.IsOpen = false;
			ju3.PlacementTarget = null;
			ju3 = null;
			int num = 0;
			if (!aaZ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		if (VuF != null)
		{
			VuF.kQT(_0020: false);
			VuF = null;
		}
	}

	private bool nul()
	{
		VuF = CreatePopupContent();
		if (VuF != null)
		{
			ju3 = new Popup();
			ju3.StaysOpen = true;
			if (BrowserInteropHelper.IsBrowserHosted)
			{
				ju3.Child = VuF;
			}
			else
			{
				ju3.AllowsTransparency = true;
				ShadowChrome child = tFB(base.View, VuF, _0020: false);
				ju3.Child = child;
			}
			Dv.EFc(ju3, PlacementMode.Relative);
			ju3.PlacementTarget = base.View.VisualElement;
			ju3.Closed += wuK;
			ju3.IsKeyboardFocusWithinChanged += PuA;
			return true;
		}
		return false;
	}

	private void PuA(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (true.Equals(P_1.NewValue) && base.View != null)
		{
			base.View.Focus();
		}
	}

	protected virtual IntelliPromptCodeSnippetSelector CreatePopupContent()
	{
		IntelliPromptCodeSnippetSelector intelliPromptCodeSnippetSelector = new IntelliPromptCodeSnippetSelector(this);
		intelliPromptCodeSnippetSelector.DataContext = this;
		SyntaxEditor syntaxEditor = base.View.SyntaxEditor;
		int num = 0;
		if (!aaZ())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			double num3 = Math.Max(syntaxEditor.MinIntelliPromptZoomLevel, Math.Min(syntaxEditor.MaxIntelliPromptZoomLevel, syntaxEditor.ZoomLevel));
			intelliPromptCodeSnippetSelector.LayoutTransform = new ScaleTransform
			{
				ScaleX = num3,
				ScaleY = num3
			};
			if (num3 > 1.0)
			{
				TextOptions.SetTextFormattingMode(intelliPromptCodeSnippetSelector, TextFormattingMode.Ideal);
			}
			return intelliPromptCodeSnippetSelector;
		}
		}
	}

	public override void Reposition()
	{
		if (ju3 == null)
		{
			return;
		}
		Rect rect = OF0(_0020: false);
		if (rect.IsEmpty)
		{
			Close(cancelled: true);
			return;
		}
		rect.Width = 0.0;
		if (!hFr(ju3, rect))
		{
			ju3.HorizontalOffset++;
			ju3.HorizontalOffset--;
		}
	}

	internal static bool aaZ()
	{
		return Dak == null;
	}

	internal static CodeSnippetSelectionSession NaF()
	{
		return Dak;
	}
}
