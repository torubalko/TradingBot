using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Internal;

internal class VAr : LAu
{
	internal static VAr IlK;

	public VAr()
	{
		grA.DaB7cz();
		base._002Ector(AdornmentLayerDefinitions.TextForeground.Key, AdornmentLayerDefinitions.TextForeground.Orderings);
	}

	private static void i6V(TextViewDrawContext P_0, double P_1, double P_2, ITextViewLineCollection P_3)
	{
		foreach (DAp item in P_3)
		{
			Rect textBounds = item.TextBounds;
			P_0.DrawText(new Point(P_1 + textBounds.X, P_2 + textBounds.Y), item.pbR());
		}
	}

	private static void a6r(TextViewDrawContext P_0, double P_1, double P_2, double P_3, double P_4)
	{
		float num = 1f;
		int num2 = (int)(2f * num);
		Rect bounds = new Rect((int)Math.Round(P_1 + (P_3 - (double)num2) / 2.0, MidpointRounding.AwayFromZero), (int)Math.Round(P_2 + (P_4 - (double)num2) / 2.0, MidpointRounding.AwayFromZero), num2, num2);
		if (!(P_0.Scale >= 1.25))
		{
			P_0.FillRectangle(bounds, P_0.VisibleWhitespaceForeground);
		}
		else
		{
			P_0.FillEllipse(bounds, P_0.VisibleWhitespaceForeground);
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "width")]
	private static void u6s(TextViewDrawContext P_0, double P_1, double P_2, double P_3, double P_4)
	{
		float num = 1f;
		P_1 += 1.0;
		int num2 = (int)(5f * num);
		int num3 = (int)(3f * num);
		int num4 = 0;
		if (qlr() != null)
		{
			int num5 = default(int);
			num4 = num5;
		}
		switch (num4)
		{
		}
		Pen pen = P_0.bbE();
		double value = P_2 + P_4 / 2.0;
		value = Math.Round(value, MidpointRounding.AwayFromZero);
		P_0.DrawLine(new Point(P_1, value), new Point(P_1 + (double)num2 - 1.0, value), pen);
		Pen pen2 = P_0.Cba();
		double num6 = (pen.Thickness - pen2.Thickness) / 2.0;
		P_0.DrawLine(new Point(P_1 + (double)num2 + num6, value + num6), new Point(P_1 + (double)num2 - (double)num3 + num6, value - (double)num3 + num6), pen2);
		P_0.DrawLine(new Point(P_1 + (double)num2 + num6, value + num6), new Point(P_1 + (double)num2 - (double)num3 + num6, value + (double)num3 + num6), pen2);
	}

	private static void p6k(TextViewDrawContext P_0, double P_1, double P_2, double P_3, ITextViewLineCollection P_4)
	{
		Rect bounds = P_0.Bounds;
		if (bounds.Width == 0.0)
		{
			return;
		}
		foreach (DAp item in P_4)
		{
			ITextLayoutLine textLayoutLine = item.pbR();
			int num = textLayoutLine.HitTest(new Point(0.0 - P_2, 0.0));
			int num2 = ((num != -1) ? (num - textLayoutLine.StartCharacterIndex) : 0);
			int num3 = textLayoutLine.HitTest(new Point(0.0 - P_2 + bounds.Width, 0.0));
			int num4 = Math.Max(1, (num3 != -1) ? (num3 - textLayoutLine.StartCharacterIndex) : item.CharacterCount);
			ITextBufferReader bufferReader = item.SnapshotRange.Snapshot.GetReader(0).BufferReader;
			int length = bufferReader.Length;
			for (int i = num2; i < num4; i++)
			{
				int num5 = item.CharacterIndexToOffset(i);
				if (num5 < length)
				{
					bufferReader.Offset = num5;
					switch (bufferReader.Read())
					{
					case ' ':
					{
						TextBounds characterBounds2 = item.GetCharacterBounds(num5);
						a6r(P_0, P_1 + P_2 + characterBounds2.X, P_3 + characterBounds2.Y, characterBounds2.Width, characterBounds2.Height);
						break;
					}
					case '\t':
					{
						TextBounds characterBounds = item.GetCharacterBounds(num5);
						u6s(P_0, P_1 + P_2 + characterBounds.X, P_3 + characterBounds.Y, characterBounds.Width, characterBounds.Height);
						break;
					}
					}
				}
			}
		}
	}

	public override void Draw(TextViewDrawContext P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		ITextView view = P_0.View;
		if (view == null)
		{
			return;
		}
		ITextViewLineCollection visibleViewLines = view.VisibleViewLines;
		if (visibleViewLines == null)
		{
			return;
		}
		double x = P_0.TextAreaBounds.X;
		double y = P_0.TextAreaBounds.Y;
		int num = 1;
		if (!HlC())
		{
			int num2 = default(int);
			num = num2;
		}
		TextViewScrollState scrollState = default(TextViewScrollState);
		while (true)
		{
			switch (num)
			{
			default:
			{
				double num3 = 0.0 - scrollState.HorizontalAmount;
				if (view.IsWhitespaceVisible)
				{
					p6k(P_0, x, num3, y, visibleViewLines);
				}
				i6V(P_0, x + num3, y, visibleViewLines);
				return;
			}
			case 1:
				scrollState = view.ScrollState;
				num = 0;
				if (qlr() == null)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static bool HlC()
	{
		return IlK == null;
	}

	internal static VAr qlr()
	{
		return IlK;
	}
}
