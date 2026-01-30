using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Internal;

internal class AAH : AdornmentManagerBase<ITextView>
{
	private IAdornment u80;

	private Dictionary<ITextViewLine, int> O8B;

	internal static AAH G15;

	private AAH(ITextView P_0)
	{
		grA.DaB7cz();
		O8B = new Dictionary<ITextViewLine, int>();
		base._002Ector(P_0, AdornmentLayerDefinitions.Guides, isForLanguage: false);
		u80 = base.AdornmentLayer.AddAdornment(AdornmentChangeReason.Other, I8L, default(Rect), this, null);
		g88();
		P_0.TextAreaLayout += j8n;
	}

	private int B8T(ITextViewLine P_0, Lazy<ITextBufferReader> P_1, ref ITextBufferReader P_2)
	{
		int num = 0;
		ITextView view = base.View;
		if (view != null)
		{
			ITextViewLineCollection visibleViewLines = view.VisibleViewLines;
			if (visibleViewLines != null && visibleViewLines.Count > 0)
			{
				int num2 = visibleViewLines.IndexOf(P_0);
				bool flag = false;
				int num3 = num2;
				while (num3 > 0)
				{
					ITextViewLine textViewLine = visibleViewLines[--num3];
					if (textViewLine != null && O8B.TryGetValue(textViewLine, out var value))
					{
						flag = true;
						num = Math.Max(num, value);
						break;
					}
				}
				if (!flag)
				{
					ITextViewLine textViewLine = visibleViewLines[0];
					if (textViewLine != null)
					{
						int num4 = 0;
						for (textViewLine = textViewLine.PreviousLine; textViewLine != null; textViewLine = textViewLine.PreviousLine)
						{
							if (((DAp)textViewLine).Qbu(P_1, ref P_2) < textViewLine.CharacterCount)
							{
								flag = true;
								num = Math.Max(num, textViewLine.IndentAmount);
								break;
							}
							if (textViewLine.IsFirstLine || num4++ > 25)
							{
								break;
							}
						}
					}
				}
			}
		}
		return num;
	}

	private void I8L(TextViewDrawContext P_0, IAdornment P_1)
	{
		ITextView view = base.View;
		if (!base.IsActive || view.VisibleViewLines == null)
		{
			return;
		}
		Rect textAreaBounds = P_0.TextAreaBounds;
		int tabSize = view.SyntaxEditor.Document.TabSize;
		double defaultSpaceWidth = view.DefaultSpaceWidth;
		foreach (ITextViewLine visibleViewLine in view.VisibleViewLines)
		{
			if (O8B.TryGetValue(visibleViewLine, out var value) && value > tabSize)
			{
				int num = value / tabSize - ((value % tabSize == 0) ? 1 : 0);
				for (int i = 1; i <= num; i++)
				{
					double num2 = visibleViewLine.TextBounds.X + (double)i * defaultSpaceWidth * (double)tabSize - view.ScrollState.HorizontalAmount;
					Rect bounds = new Rect(textAreaBounds.X + num2, textAreaBounds.Y + visibleViewLine.Bounds.Y, 1.0, visibleViewLine.Bounds.Height).h0e();
					P_0.FillRectangle(bounds, P_0.IndentationGuidesBackground);
				}
			}
		}
	}

	private void j8n(object P_0, TextViewTextAreaLayoutEventArgs P_1)
	{
		if (O8B.Count > 0)
		{
			foreach (ITextViewLine removedViewLine in P_1.RemovedViewLines)
			{
				O8B.Remove(removedViewLine);
			}
			foreach (ITextViewLine addedOrUpdatedViewLine in P_1.AddedOrUpdatedViewLines)
			{
				O8B.Remove(addedOrUpdatedViewLine);
			}
		}
		g88();
		int num = 1;
		if (!D1G())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		do
		{
			switch (num)
			{
			case 1:
				if (!base.IsActive)
				{
					if (O8B.Count > 0)
					{
						O8B.Clear();
					}
					return;
				}
				break;
			default:
			{
				Lazy<ITextBufferReader> lazy = new Lazy<ITextBufferReader>(() => base.View.CurrentSnapshot.GetReader(0).BufferReader);
				ITextBufferReader textBufferReader = null;
				int tabSize = base.View.SyntaxEditor.Document.TabSize;
				{
					foreach (DAp addedOrUpdatedViewLine2 in P_1.AddedOrUpdatedViewLines)
					{
						if (addedOrUpdatedViewLine2.Qbu(lazy, ref textBufferReader) < addedOrUpdatedViewLine2.CharacterCount)
						{
							if (!O8B.ContainsKey(addedOrUpdatedViewLine2))
							{
								O8B[addedOrUpdatedViewLine2] = addedOrUpdatedViewLine2.IndentAmount;
							}
							continue;
						}
						int num3 = B8T(addedOrUpdatedViewLine2, lazy, ref textBufferReader);
						if (num3 % tabSize == 0)
						{
							num3++;
						}
						O8B[addedOrUpdatedViewLine2] = num3;
					}
					return;
				}
			}
			}
			num = 0;
		}
		while (H1N() == null);
		goto IL_0005;
	}

	private void g88()
	{
		base.IsActive = ((base.View is IPrinterView printerView) ? printerView.SyntaxEditor.PrintSettings.AreIndentationGuidesVisible : base.View.SyntaxEditor.AreIndentationGuidesVisible);
	}

	[SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments.Implementation.IndentationGuideAdornmentManager")]
	public static void o8I(ITextView P_0)
	{
		new AAH(P_0);
	}

	protected override void OnClosed()
	{
		ITextView view = base.View;
		view.TextAreaLayout -= j8n;
		if (u80 != null)
		{
			base.AdornmentLayer.RemoveAdornment(AdornmentChangeReason.ManagerClosed, u80);
			u80 = null;
		}
		base.OnClosed();
	}

	protected override void OnIsActiveChanged()
	{
		base.View.InvalidateRender();
	}

	[CompilerGenerated]
	private ITextBufferReader d85()
	{
		return base.View.CurrentSnapshot.GetReader(0).BufferReader;
	}

	internal static bool D1G()
	{
		return G15 == null;
	}

	internal static AAH H1N()
	{
		return G15;
	}
}
