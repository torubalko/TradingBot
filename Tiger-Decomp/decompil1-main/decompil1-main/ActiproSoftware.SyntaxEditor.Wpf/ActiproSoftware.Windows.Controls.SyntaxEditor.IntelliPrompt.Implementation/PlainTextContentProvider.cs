using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "PlainText")]
public class PlainTextContentProvider : IContentProvider
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string q3B;

	internal static PlainTextContentProvider Egp;

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return q3B;
		}
		[CompilerGenerated]
		set
		{
			q3B = value;
		}
	}

	public PlainTextContentProvider(string text)
	{
		grA.DaB7cz();
		base._002Ector();
		Text = text;
	}

	internal static PlainTextContentProvider l30(TextSnapshotRange P_0, int P_1, int P_2)
	{
		int num = Math.Max(1, P_0.Snapshot.Document.TabSize);
		ITextSnapshotLine startLine = P_0.StartLine;
		int indentAmount = startLine.IndentAmount;
		ITextBufferReader bufferReader = P_0.Snapshot.GetReader(P_0.StartOffset).BufferReader;
		StringBuilder stringBuilder = new StringBuilder();
		int num2 = 0;
		int num3 = 0;
		int num4 = Math.Min(P_0.EndOffset, P_0.StartOffset + P_2);
		int num5 = 1;
		while (bufferReader.Offset < num4 && num5 <= P_1)
		{
			char c = bufferReader.Read();
			switch (c)
			{
			case '\n':
				stringBuilder.Append(Q7Z.tqM(7886));
				num2 = 0;
				num3 = indentAmount;
				num5++;
				break;
			case ' ':
				if (num3 > 0)
				{
					num3--;
					break;
				}
				stringBuilder.Append(' ');
				num2++;
				break;
			case '\t':
			{
				int num6 = num - num2 % num;
				if (num3 > 0)
				{
					if (num3 >= num6)
					{
						num3 -= num6;
						num6 = 0;
					}
					else
					{
						num6 -= num3;
						num3 = 0;
					}
				}
				if (num6 > 0)
				{
					stringBuilder.Append(new string(' ', num6));
					num2 += num6;
				}
				break;
			}
			default:
				stringBuilder.Append(c);
				num2++;
				num3 = 0;
				break;
			}
		}
		if (num5 > P_1 || P_0.Length > P_2)
		{
			stringBuilder.Append(Q7Z.tqM(11524));
		}
		return new PlainTextContentProvider(stringBuilder.ToString());
	}

	public virtual object GetContent()
	{
		TextBlock textBlock = new TextBlock();
		textBlock.SnapsToDevicePixels = true;
		textBlock.TextWrapping = TextWrapping.Wrap;
		textBlock.Text = Text;
		return textBlock;
	}

	internal static bool rg4()
	{
		return Egp == null;
	}

	internal static PlainTextContentProvider pgD()
	{
		return Egp;
	}
}
