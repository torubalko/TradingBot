using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Input;
using System.Xml;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

public abstract class EditActionBase : RoutedUICommand, IEditAction, IKeyedObject, ICommand
{
	internal static EditActionBase mAc;

	public virtual bool CanRecordInMacro => true;

	public virtual string Key
	{
		get
		{
			string text = GetType().Name;
			if (text != null && text.EndsWith(Q7Z.tqM(193288), StringComparison.OrdinalIgnoreCase))
			{
				text = text.Substring(0, text.Length - 6);
			}
			return text;
		}
	}

	protected EditActionBase(string text)
	{
		grA.DaB7cz();
		base._002Ector();
		if (!string.IsNullOrEmpty(text))
		{
			base.Text = text;
		}
	}

	private static IEditorView tYZ(object P_0)
	{
		IEditorView editorView = P_0 as IEditorView;
		if (editorView == null && P_0 is SyntaxEditor syntaxEditor)
		{
			editorView = syntaxEditor.ActiveView;
		}
		return editorView;
	}

	public virtual bool CanExecute(IEditorView view)
	{
		return true;
	}

	public abstract void Execute(IEditorView view);

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public static string GetKeyText(ModifierKeys modifiers, Key key)
	{
		bool flag = (modifiers & ModifierKeys.Control) == ModifierKeys.Control;
		bool flag2 = (modifiers & ModifierKeys.Shift) == ModifierKeys.Shift;
		bool flag3 = (modifiers & ModifierKeys.Alt) == ModifierKeys.Alt;
		string text = null;
		return string.Concat(str3: key switch
		{
			System.Windows.Input.Key.Add => SR.GetString(SRName.UIKeyAddText), 
			System.Windows.Input.Key.Back => SR.GetString(SRName.UIKeyBackText), 
			System.Windows.Input.Key.D0 => SR.GetString(SRName.UIKeyD0Text), 
			System.Windows.Input.Key.D1 => SR.GetString(SRName.UIKeyD1Text), 
			System.Windows.Input.Key.D2 => SR.GetString(SRName.UIKeyD2Text), 
			System.Windows.Input.Key.D3 => SR.GetString(SRName.UIKeyD3Text), 
			System.Windows.Input.Key.D4 => SR.GetString(SRName.UIKeyD4Text), 
			System.Windows.Input.Key.D5 => SR.GetString(SRName.UIKeyD5Text), 
			System.Windows.Input.Key.D6 => SR.GetString(SRName.UIKeyD6Text), 
			System.Windows.Input.Key.D7 => SR.GetString(SRName.UIKeyD7Text), 
			System.Windows.Input.Key.D8 => SR.GetString(SRName.UIKeyD8Text), 
			System.Windows.Input.Key.D9 => SR.GetString(SRName.UIKeyD9Text), 
			System.Windows.Input.Key.Decimal => SR.GetString(SRName.UIKeyDecimalText), 
			System.Windows.Input.Key.Delete => SR.GetString(SRName.UIKeyDeleteText), 
			System.Windows.Input.Key.Divide => SR.GetString(SRName.UIKeyDivideText), 
			System.Windows.Input.Key.Down => SR.GetString(SRName.UIKeyDownText), 
			System.Windows.Input.Key.Return => SR.GetString(SRName.UIKeyReturnText), 
			System.Windows.Input.Key.Escape => SR.GetString(SRName.UIKeyEscapeText), 
			System.Windows.Input.Key.Insert => SR.GetString(SRName.UIKeyInsertText), 
			System.Windows.Input.Key.Left => SR.GetString(SRName.UIKeyLeftText), 
			System.Windows.Input.Key.LWin => SR.GetString(SRName.UIKeyLWinText), 
			System.Windows.Input.Key.Multiply => SR.GetString(SRName.UIKeyMultiplyText), 
			System.Windows.Input.Key.NumPad0 => SR.GetString(SRName.UIKeyNumPad0Text), 
			System.Windows.Input.Key.NumPad1 => SR.GetString(SRName.UIKeyNumPad1Text), 
			System.Windows.Input.Key.NumPad2 => SR.GetString(SRName.UIKeyNumPad2Text), 
			System.Windows.Input.Key.NumPad3 => SR.GetString(SRName.UIKeyNumPad3Text), 
			System.Windows.Input.Key.NumPad4 => SR.GetString(SRName.UIKeyNumPad4Text), 
			System.Windows.Input.Key.NumPad5 => SR.GetString(SRName.UIKeyNumPad5Text), 
			System.Windows.Input.Key.NumPad6 => SR.GetString(SRName.UIKeyNumPad6Text), 
			System.Windows.Input.Key.NumPad7 => SR.GetString(SRName.UIKeyNumPad7Text), 
			System.Windows.Input.Key.NumPad8 => SR.GetString(SRName.UIKeyNumPad8Text), 
			System.Windows.Input.Key.NumPad9 => SR.GetString(SRName.UIKeyNumPad9Text), 
			System.Windows.Input.Key.Oem6 => SR.GetString(SRName.UIKeyOemCloseBracketsText), 
			System.Windows.Input.Key.OemComma => SR.GetString(SRName.UIKeyOemCommaText), 
			System.Windows.Input.Key.OemMinus => SR.GetString(SRName.UIKeyOemMinusText), 
			System.Windows.Input.Key.Oem4 => SR.GetString(SRName.UIKeyOemOpenBracketsText), 
			System.Windows.Input.Key.OemPeriod => SR.GetString(SRName.UIKeyOemPeriodText), 
			System.Windows.Input.Key.Oem5 => SR.GetString(SRName.UIKeyOemPipeText), 
			System.Windows.Input.Key.OemPlus => SR.GetString(SRName.UIKeyOemPlusText), 
			System.Windows.Input.Key.Oem2 => SR.GetString(SRName.UIKeyOemQuestionText), 
			System.Windows.Input.Key.Oem7 => SR.GetString(SRName.UIKeyOemQuotesText), 
			System.Windows.Input.Key.Oem1 => SR.GetString(SRName.UIKeyOemSemicolonText), 
			System.Windows.Input.Key.Oem3 => SR.GetString(SRName.UIKeyOemTildeText), 
			System.Windows.Input.Key.Next => SR.GetString(SRName.UIKeyPageDownText), 
			System.Windows.Input.Key.Prior => SR.GetString(SRName.UIKeyPageUpText), 
			System.Windows.Input.Key.Pause => SR.GetString(SRName.UIKeyPauseText), 
			System.Windows.Input.Key.Right => SR.GetString(SRName.UIKeyRightText), 
			System.Windows.Input.Key.RWin => SR.GetString(SRName.UIKeyRWinText), 
			System.Windows.Input.Key.Subtract => SR.GetString(SRName.UIKeySubtractText), 
			System.Windows.Input.Key.Up => SR.GetString(SRName.UIKeyUpText), 
			_ => key.ToString(), 
		}, str0: flag ? (SR.GetString(SRName.UIModifierKeysControlText) + SR.GetString(SRName.UIModifierKeysDelimiterText)) : string.Empty, str1: flag2 ? (SR.GetString(SRName.UIModifierKeysShiftText) + SR.GetString(SRName.UIModifierKeysDelimiterText)) : string.Empty, str2: flag3 ? (SR.GetString(SRName.UIModifierKeysAltText) + SR.GetString(SRName.UIModifierKeysDelimiterText)) : string.Empty);
	}

	public virtual void ReadFromXml(XmlReader reader)
	{
	}

	public virtual void WriteToXml(XmlWriter writer)
	{
	}

	private void hYh(object P_0, CanExecuteRoutedEventArgs P_1)
	{
		if (P_1 != null)
		{
			IEditorView editorView = tYZ(P_1.OriginalSource);
			P_1.CanExecute = editorView != null && CanExecute(editorView);
			P_1.Handled = true;
			return;
		}
		throw new ArgumentNullException(Q7Z.tqM(1014));
	}

	private void qYN(object P_0, ExecutedRoutedEventArgs P_1)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		IEditorView editorView = tYZ(P_1.OriginalSource);
		if (editorView != null)
		{
			editorView.ExecuteEditAction(this);
			P_1.Handled = true;
		}
	}

	public CommandBinding CreateCommandBinding()
	{
		return CreateCommandBinding(null);
	}

	public CommandBinding CreateCommandBinding(ICommand alternateCommand)
	{
		return new CommandBinding(alternateCommand ?? this, qYN, hYh);
	}

	internal static bool EAd()
	{
		return mAc == null;
	}

	internal static EditActionBase OAT()
	{
		return mAc;
	}
}
