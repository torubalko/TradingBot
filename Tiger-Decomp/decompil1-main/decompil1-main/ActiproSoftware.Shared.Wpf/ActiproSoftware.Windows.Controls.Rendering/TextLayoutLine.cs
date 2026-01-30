using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media.TextFormatting;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Rendering;

internal class TextLayoutLine : ITextLayoutLine
{
	private double? TIu;

	private IList<TextLine> JI2;

	private double? vIe;

	private int? HI7;

	private int kIF;

	private TextLayout AIo;

	private double? fIQ;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool XIO;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int bI0;

	internal static TextLayoutLine Vni;

	internal IList<TextLine> FormattedLines => JI2;

	public double Baseline
	{
		get
		{
			if (!TIu.HasValue)
			{
				TIu = JI2.Max((TextLine l) => l.Baseline);
			}
			return TIu.Value;
		}
	}

	public int CharacterCount
	{
		get
		{
			if (!HI7.HasValue)
			{
				int num = ((!HasHardLineBreak && kIF == AIo.Lines.Count - 1) ? 1 : 0);
				HI7 = JI2.Sum((TextLine l) => l.Length) - num;
			}
			return HI7.Value;
		}
	}

	public bool HasHardLineBreak
	{
		[CompilerGenerated]
		get
		{
			return XIO;
		}
		[CompilerGenerated]
		set
		{
			XIO = value;
		}
	}

	public double Height
	{
		get
		{
			if (!vIe.HasValue)
			{
				double a = 1.0 + JI2.Max((TextLine l) => l.Height) + 1.0;
				vIe = Math.Ceiling(a);
			}
			return vIe.Value;
		}
	}

	public int StartCharacterIndex
	{
		[CompilerGenerated]
		get
		{
			return bI0;
		}
		[CompilerGenerated]
		private set
		{
			bI0 = value;
		}
	}

	public double Width
	{
		get
		{
			if (!fIQ.HasValue)
			{
				fIQ = JI2.Sum((TextLine l) => l.WidthIncludingTrailingWhitespace);
			}
			return fIQ.Value;
		}
	}

	internal TextLayoutLine(TextLayout layout, int lineIndex, int startCharacterIndex, IList<TextLine> formattedLines)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		if (layout == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117796));
		}
		if (formattedLines == null || formattedLines.Count == 0)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117812));
		}
		AIo = layout;
		kIF = lineIndex;
		StartCharacterIndex = startCharacterIndex;
		JI2 = formattedLines;
	}

	internal void Draw(CanvasDrawContext context, Point location)
	{
		if (context == null)
		{
			return;
		}
		Rect clipBounds = context.ClipBounds;
		int num2 = default(int);
		foreach (TextLine item in JI2)
		{
			int num = 0;
			if (dnh() != null)
			{
				num = num2;
			}
			switch (num)
			{
			}
			Rect rect = new Rect(location.X, location.Y, item.Width, Height);
			if (clipBounds.IntersectsWith(rect))
			{
				context.PushClip(Rect.Intersect(clipBounds, rect));
				item.Draw(origin: new Point(location.X, location.Y + 1.0 + Baseline - item.Baseline), drawingContext: context.PlatformRenderer, inversion: InvertAxes.None);
				context.PopClip();
			}
			location.X += item.WidthIncludingTrailingWhitespace;
		}
	}

	private ITextBounds aIw(TextLine P_0, int P_1, double P_2)
	{
		IList<TextBounds> textBounds = P_0.GetTextBounds(P_1, 1);
		if (textBounds.Count > 0)
		{
			int num = 0;
			if (!enp())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
			{
				TextBounds textBounds2 = textBounds[0];
				Rect rectangle = textBounds2.Rectangle;
				rectangle.X += P_2;
				rectangle.Y = 0.0;
				rectangle.Height = Height;
				bool isRightToLeft = textBounds2.FlowDirection == FlowDirection.RightToLeft;
				return new TextLayoutBounds(rectangle, isRightToLeft);
			}
			}
		}
		return new TextLayoutBounds(new Rect(0.0, 0.0, 0.0, Height), isRightToLeft: false);
	}

	public ITextBounds GetCharacterBounds(int characterIndex, bool allowVirtualSpace)
	{
		int num = characterIndex - StartCharacterIndex - (CharacterCount - (HasHardLineBreak ? 1 : 0));
		if (num < 0)
		{
			double num2 = 0.0;
			int num3 = 0;
			if (!enp())
			{
				int num4 = default(int);
				num3 = num4;
			}
			switch (num3)
			{
			default:
			{
				int num5 = StartCharacterIndex;
				if (characterIndex - num5 < CharacterCount)
				{
					int num7 = default(int);
					foreach (TextLine item in JI2)
					{
						num5 += item.Length;
						bool flag = characterIndex < num5;
						int num6 = 0;
						if (dnh() != null)
						{
							num6 = num7;
						}
						switch (num6)
						{
						}
						if (flag)
						{
							return aIw(item, characterIndex, num2);
						}
						num2 += item.WidthIncludingTrailingWhitespace;
					}
				}
				return new TextLayoutBounds(new Rect(0.0, 0.0, 0.0, Height), isRightToLeft: false);
			}
			}
		}
		return new TextLayoutBounds(new Rect(Width + (allowVirtualSpace ? ((double)num * AIo.SpaceWidth) : 0.0), 0.0, AIo.SpaceWidth, Height), isRightToLeft: false);
	}

	public IEnumerable<ITextBounds> GetTextBounds(int characterIndex, int characterCount, bool allowVirtualSpace)
	{
		int characterBeforeLine = StartCharacterIndex - characterIndex;
		if (characterBeforeLine > 0)
		{
			characterIndex += characterBeforeLine;
			characterCount -= characterBeforeLine;
		}
		int virtualStartCharacterIndex = characterIndex - StartCharacterIndex - (CharacterCount - (HasHardLineBreak ? 1 : 0));
		int virtualEndCharacterIndex = characterIndex + characterCount - StartCharacterIndex - (CharacterCount - (HasHardLineBreak ? 1 : 0));
		if (virtualStartCharacterIndex >= 0)
		{
			if (allowVirtualSpace)
			{
				yield return new TextLayoutBounds(new Rect(Width + (double)virtualStartCharacterIndex * AIo.SpaceWidth, 0.0, (double)(virtualEndCharacterIndex - virtualStartCharacterIndex) * AIo.SpaceWidth, Height), isRightToLeft: false);
			}
			else
			{
				yield return new TextLayoutBounds(new Rect(Width, 0.0, 0.0, Height), isRightToLeft: false);
			}
			yield break;
		}
		double x = 0.0;
		int lineEndCharacterIndex = StartCharacterIndex;
		bool yieldSuccess = false;
		foreach (TextLine formattedLine in JI2)
		{
			lineEndCharacterIndex += formattedLine.Length;
			if (characterIndex < lineEndCharacterIndex)
			{
				int characterCountOnFormattedLine = Math.Min(characterCount, lineEndCharacterIndex - characterIndex);
				IList<TextBounds> formattedLineTextBounds = formattedLine.GetTextBounds(characterIndex, Math.Max(1, characterCountOnFormattedLine));
				if (formattedLineTextBounds != null)
				{
					foreach (TextBounds textBounds in formattedLineTextBounds)
					{
						yieldSuccess = true;
						Rect rect = textBounds.Rectangle;
						rect.X += x;
						rect.Y = 0.0;
						if (characterCountOnFormattedLine == 0)
						{
							rect.Width = 0.0;
						}
						rect.Height = Height;
						yield return new TextLayoutBounds(rect, textBounds.FlowDirection == FlowDirection.RightToLeft);
					}
				}
				characterIndex += characterCountOnFormattedLine;
				characterCount -= characterCountOnFormattedLine;
				if (characterCount <= 0)
				{
					break;
				}
			}
			x += formattedLine.WidthIncludingTrailingWhitespace;
		}
		if (virtualEndCharacterIndex > 0)
		{
			if (allowVirtualSpace)
			{
				yield return new TextLayoutBounds(new Rect(Width, 0.0, (double)virtualEndCharacterIndex * AIo.SpaceWidth, Height), isRightToLeft: false);
			}
			else if (HasHardLineBreak)
			{
				yield return new TextLayoutBounds(new Rect(Width, 0.0, AIo.SpaceWidth, Height), isRightToLeft: false);
			}
			else if (!yieldSuccess)
			{
				yield return new TextLayoutBounds(new Rect(Width, 0.0, 0.0, Height), isRightToLeft: false);
			}
		}
	}

	public int HitTest(Point location)
	{
		double num = location.X;
		if (new Rect(0.0, 0.0, Width + AIo.SpaceWidth, Height).Contains(location))
		{
			foreach (TextLine item in JI2)
			{
				double widthIncludingTrailingWhitespace = item.WidthIncludingTrailingWhitespace;
				if (num < widthIncludingTrailingWhitespace)
				{
					return item.GetCharacterHitFromDistance(num).FirstCharacterIndex;
				}
				num -= widthIncludingTrailingWhitespace;
			}
			return StartCharacterIndex + CharacterCount - (HasHardLineBreak ? 1 : 0);
		}
		return -1;
	}

	internal static bool enp()
	{
		return Vni == null;
	}

	internal static TextLayoutLine dnh()
	{
		return Vni;
	}
}
