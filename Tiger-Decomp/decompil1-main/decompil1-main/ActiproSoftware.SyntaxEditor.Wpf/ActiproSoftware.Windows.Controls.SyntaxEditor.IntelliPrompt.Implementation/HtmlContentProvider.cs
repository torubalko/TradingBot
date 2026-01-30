using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Xml;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Exporters;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class HtmlContentProvider : IContentProvider
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Color? yFm;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string NFC;

	private static HtmlContentProvider lL1;

	public Color? BackgroundColorHint
	{
		[CompilerGenerated]
		get
		{
			return yFm;
		}
		[CompilerGenerated]
		set
		{
			yFm = value;
		}
	}

	public string HtmlSnippet
	{
		[CompilerGenerated]
		get
		{
			return NFC;
		}
		[CompilerGenerated]
		set
		{
			NFC = value;
		}
	}

	public HtmlContentProvider(string htmlSnippet)
	{
		grA.DaB7cz();
		base._002Ector();
		HtmlSnippet = htmlSnippet;
	}

	public HtmlContentProvider(string htmlSnippet, Color backgroundColorHint)
	{
		grA.DaB7cz();
		this._002Ector(htmlSnippet);
		BackgroundColorHint = backgroundColorHint;
	}

	internal static string hFK(string P_0, bool P_1)
	{
		if (P_0 != null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num2 = default(int);
			foreach (char c in P_0)
			{
				char c2 = c;
				char c3 = c2;
				int num;
				if ((uint)c3 <= 34u)
				{
					if (c3 != '\n')
					{
						switch (c3)
						{
						case '\r':
							continue;
						case '"':
							stringBuilder.Append(Q7Z.tqM(191698));
							continue;
						}
						goto IL_0248;
					}
					if (!P_1)
					{
						goto IL_0075;
					}
					stringBuilder.Append(Q7Z.tqM(191738));
					num = 2;
					if (!tL5())
					{
						goto IL_0005;
					}
				}
				else if (c3 != '&')
				{
					num = 0;
					if (ELG() != null)
					{
						goto IL_0005;
					}
				}
				else
				{
					stringBuilder.Append(Q7Z.tqM(191684));
					num = 3;
				}
				goto IL_0009;
				IL_0075:
				stringBuilder.Append(Q7Z.tqM(7886));
				continue;
				IL_0005:
				num = num2;
				goto IL_0009;
				IL_0009:
				switch (num)
				{
				case 4:
					break;
				case 2:
				case 3:
					continue;
				case 1:
					goto IL_0248;
				default:
					goto IL_0287;
				}
				goto IL_0075;
				IL_0287:
				switch (c3)
				{
				case '<':
					stringBuilder.Append(Q7Z.tqM(191714));
					continue;
				case '>':
					stringBuilder.Append(Q7Z.tqM(191726));
					continue;
				}
				goto IL_0248;
				IL_0248:
				if (c >= '\u00a0')
				{
					string text = Q7Z.tqM(191754);
					int num3 = c;
					stringBuilder.Append(text + num3.ToString(NumberFormatInfo.InvariantInfo) + Q7Z.tqM(191762));
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.ToString();
		}
		return null;
	}

	internal static HtmlContentProvider lFf(IHighlightingStyleRegistry P_0, TextSnapshotRange P_1, int P_2, int P_3)
	{
		int num = Math.Max(1, P_1.Snapshot.Document.TabSize);
		int indentAmount = P_1.StartLine.IndentAmount;
		ITextBufferReader bufferReader = P_1.Snapshot.GetReader(P_1.StartOffset).BufferReader;
		int num2 = 0;
		int num3 = 0;
		int num4 = Math.Min(P_1.EndOffset, P_1.StartOffset + P_3);
		int num5 = 1;
		List<ActiproSoftware.Text.TextRange> list = new List<ActiproSoftware.Text.TextRange>();
		int num6 = P_1.StartOffset;
		while (bufferReader.Offset < num4 && num5 <= P_2)
		{
			switch (bufferReader.Read())
			{
			case '\n':
				list.Add(new ActiproSoftware.Text.TextRange(num6, bufferReader.Offset - 1));
				num6 = bufferReader.Offset;
				num2 = 0;
				num3 = indentAmount;
				num5++;
				break;
			case ' ':
				if (num3 > 0)
				{
					num6++;
					num3--;
				}
				else
				{
					num2++;
				}
				break;
			case '\t':
			{
				int num7 = num - num2 % num;
				if (num3 > 0)
				{
					if (num3 >= num7)
					{
						num6++;
						num3 -= num7;
						num7 = 0;
					}
					else
					{
						num7 -= num3;
						num3 = 0;
					}
				}
				if (num7 > 0)
				{
					num2 += num7;
				}
				break;
			}
			default:
				num2++;
				num3 = 0;
				break;
			}
		}
		list.Add(new ActiproSoftware.Text.TextRange(num6, bufferReader.Offset));
		string text = new TextExporterFactory(P_0).CreateHtmlInlineFragment().Export(P_1.Snapshot, list);
		text = text.Replace(Q7Z.tqM(7824), new string(' ', num));
		if (num5 > P_2 || P_1.Length > P_3)
		{
			text += Q7Z.tqM(11524);
		}
		return new HtmlContentProvider(text);
	}

	public static string Escape(string text)
	{
		return hFK(text, _0020: true);
	}

	public virtual object GetContent()
	{
		try
		{
			return tFe(HtmlSnippet);
		}
		catch (XmlException)
		{
			return null;
		}
	}

	protected virtual Image GetImage(string source)
	{
		return null;
	}

	public static UIColor ResolveForegroundColor(IHighlightingStyleRegistry registry, IClassificationType classificationType, Color defaultColor)
	{
		if (classificationType != null)
		{
			if (registry == null)
			{
				registry = AmbientHighlightingStyleRegistry.Instance;
			}
			IHighlightingStyle highlightingStyle = registry[classificationType];
			if (highlightingStyle != null && highlightingStyle.Foreground.HasValue)
			{
				return UIColor.FromColor(highlightingStyle.Foreground.Value);
			}
		}
		return UIColor.FromColor(defaultColor);
	}

	public static UIColor GetCommentForegroundColor(IHighlightingStyleRegistry registry)
	{
		return ResolveForegroundColor(registry, ClassificationTypes.Comment, Colors.Green);
	}

	public static UIColor GetKeywordForegroundColor(IHighlightingStyleRegistry registry)
	{
		return ResolveForegroundColor(registry, ClassificationTypes.Keyword, Colors.Blue);
	}

	public static UIColor GetNeutralForegroundColor(IHighlightingStyleRegistry registry)
	{
		if (ResolveForegroundColor(registry, cT.PlainText, Colors.Black).IsLight)
		{
			return UIColor.FromArgb(byte.MaxValue, 144, 144, 144);
		}
		return UIColor.FromArgb(byte.MaxValue, 112, 112, 112);
	}

	public static UIColor GetTypeNameForegroundColor(IHighlightingStyleRegistry registry)
	{
		if (ResolveForegroundColor(registry, cT.PlainText, Colors.Black).IsLight)
		{
			return UIColor.FromArgb(byte.MaxValue, 78, 201, 176);
		}
		return UIColor.FromArgb(byte.MaxValue, 43, 145, 175);
	}

	private static FontFamily tFD(string P_0)
	{
		if (P_0.StartsWith(Q7Z.tqM(191768), StringComparison.Ordinal))
		{
			P_0 = P_0.Substring(1);
		}
		if (P_0.EndsWith(Q7Z.tqM(191768), StringComparison.Ordinal))
		{
			P_0 = P_0.Substring(0, P_0.Length - 1);
		}
		if (P_0.StartsWith(Q7Z.tqM(191774), StringComparison.Ordinal))
		{
			P_0 = P_0.Substring(1);
		}
		if (P_0.EndsWith(Q7Z.tqM(191774), StringComparison.Ordinal))
		{
			P_0 = P_0.Substring(0, P_0.Length - 1);
		}
		string text = P_0.ToUpperInvariant();
		string text2 = text;
		if (!(text2 == Q7Z.tqM(191780)))
		{
			if (!(text2 == Q7Z.tqM(191804)))
			{
				if (text2 == Q7Z.tqM(191818))
				{
					P_0 = Q7Z.tqM(191888);
				}
			}
			else
			{
				P_0 = Q7Z.tqM(191854);
			}
		}
		else
		{
			P_0 = Q7Z.tqM(191840);
		}
		return new FontFamily(P_0);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private static void wFg(Inline P_0, string P_1)
	{
		if (P_1 == null)
		{
			return;
		}
		string[] array = P_1.Split(';');
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (text.Trim().Length <= 0)
			{
				continue;
			}
			string[] array3 = text.Trim().Split(':');
			if (array3.Length != 2)
			{
				continue;
			}
			string text2 = array3[1].Trim();
			if (text2.Length <= 0)
			{
				continue;
			}
			string text3 = array3[0].Trim();
			string text4 = text3;
			switch (global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text4))
			{
			case 3328355879u:
				if (text4 == Q7Z.tqM(191914))
				{
					try
					{
						P_0.Background = vAE.F0K(UIColor.FromWebColor(text2).ToColor());
					}
					catch (ArgumentException)
					{
					}
				}
				break;
			case 1031692888u:
				if (text4 == Q7Z.tqM(191950))
				{
					try
					{
						P_0.Foreground = vAE.F0K(UIColor.FromWebColor(text2).ToColor());
					}
					catch (ArgumentException)
					{
					}
				}
				break;
			case 549768767u:
			{
				if (!(text4 == Q7Z.tqM(191964)))
				{
					break;
				}
				string[] array4 = text2.Split(',');
				if (array4 == null)
				{
					break;
				}
				string[] array5 = array4;
				foreach (string text9 in array5)
				{
					if (text9 != null && !string.IsNullOrEmpty(text9.Trim()))
					{
						FontFamily fontFamily = tFD(text9.Trim());
						if (fontFamily != null)
						{
							P_0.FontFamily = fontFamily;
							break;
						}
					}
				}
				break;
			}
			case 4284404126u:
			{
				if (!(text4 == Q7Z.tqM(191990)))
				{
					break;
				}
				double result2;
				if (text2.Length > 2 && !char.IsNumber(text2[text2.Length - 2]))
				{
					if (double.TryParse(text2.Substring(0, text2.Length - 2), out var result))
					{
						P_0.FontSize = result * 96.0 / 72.0;
					}
				}
				else if (double.TryParse(text2, out result2))
				{
					P_0.FontSize = result2 * 96.0 / 72.0;
				}
				break;
			}
			case 3247228931u:
			{
				if (!(text4 == Q7Z.tqM(192012)))
				{
					break;
				}
				string text7 = text2.ToUpperInvariant();
				string text8 = text7;
				switch (global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text8))
				{
				case 2291914577u:
					if (!(text8 == Q7Z.tqM(192096)))
					{
						goto end_IL_00b8;
					}
					goto IL_0642;
				case 147274918u:
					if (!(text8 == Q7Z.tqM(192106)))
					{
						goto end_IL_00b8;
					}
					goto IL_0642;
				case 1033846015u:
					if (!(text8 == Q7Z.tqM(192116)))
					{
						goto end_IL_00b8;
					}
					goto IL_0642;
				case 3721057460u:
					if (!(text8 == Q7Z.tqM(192126)))
					{
						goto end_IL_00b8;
					}
					goto IL_0642;
				case 3360754038u:
					if (!(text8 == Q7Z.tqM(192136)))
					{
						goto end_IL_00b8;
					}
					goto IL_0642;
				case 1040501633u:
					if (!(text8 == Q7Z.tqM(192148)))
					{
						goto end_IL_00b8;
					}
					goto IL_0642;
				case 1731450012u:
					if (text8 == Q7Z.tqM(192164))
					{
						break;
					}
					goto end_IL_00b8;
				case 3286718301u:
					if (text8 == Q7Z.tqM(192174))
					{
						break;
					}
					goto end_IL_00b8;
				case 1162866994u:
					if (text8 == Q7Z.tqM(192184))
					{
						break;
					}
					goto end_IL_00b8;
				case 2855274715u:
					if (text8 == Q7Z.tqM(192194))
					{
						break;
					}
					goto end_IL_00b8;
				case 731423408u:
					if (text8 == Q7Z.tqM(192204))
					{
						break;
					}
					goto end_IL_00b8;
				case 1525104964u:
					if (text8 == Q7Z.tqM(192214))
					{
						break;
					}
					goto end_IL_00b8;
				case 1009949074u:
					if (text8 == Q7Z.tqM(192232))
					{
						break;
					}
					goto end_IL_00b8;
				default:
					goto end_IL_00b8;
					IL_0642:
					P_0.FontWeight = FontWeights.Bold;
					goto end_IL_00b8;
				}
				P_0.FontWeight = FontWeights.Normal;
				break;
			}
			case 252494808u:
			{
				if (!(text4 == Q7Z.tqM(192038)))
				{
					break;
				}
				string text10 = text2.ToUpperInvariant();
				string text11 = text10;
				if (!(text11 == Q7Z.tqM(192248)) && !(text11 == Q7Z.tqM(192264)))
				{
					if (text11 == Q7Z.tqM(192232))
					{
						P_0.FontStyle = FontStyles.Normal;
					}
				}
				else
				{
					P_0.FontStyle = FontStyles.Italic;
				}
				break;
			}
			case 2041122471u:
				{
					if (!(text4 == Q7Z.tqM(192062)))
					{
						break;
					}
					string text5 = text2.ToUpperInvariant();
					string text6 = text5;
					if (!(text6 == Q7Z.tqM(192282)))
					{
						if (text6 == Q7Z.tqM(192310))
						{
							P_0.TextDecorations = TextDecorations.Underline;
						}
						else
						{
							P_0.TextDecorations = null;
						}
					}
					else
					{
						P_0.TextDecorations = TextDecorations.Strikethrough;
					}
					break;
				}
				end_IL_00b8:
				break;
			}
		}
	}

	private Span hFQ(XmlReader P_0, string P_1, Span P_2)
	{
		int num2 = default(int);
		while (P_0.Read())
		{
			XmlNodeType nodeType = P_0.NodeType;
			XmlNodeType xmlNodeType = nodeType;
			if (xmlNodeType <= XmlNodeType.Text)
			{
				int num = 2;
				if (ELG() != null)
				{
					num = num2;
				}
				switch (num)
				{
				case 1:
					if (xmlNodeType == XmlNodeType.Text)
					{
						P_2.Inlines.Add(new Run
						{
							Text = P_0.Value
						});
					}
					continue;
				case 2:
					if (xmlNodeType == XmlNodeType.Element)
					{
						Inline inline = fFl(P_0);
						if (inline != null)
						{
							P_2.Inlines.Add(inline);
						}
						continue;
					}
					goto case 1;
				}
			}
			switch (xmlNodeType)
			{
			case XmlNodeType.Whitespace:
			case XmlNodeType.SignificantWhitespace:
				P_2.Inlines.Add(new Run
				{
					Text = P_0.Value
				});
				break;
			case XmlNodeType.EndElement:
			{
				string text = P_0.Name.ToLower(CultureInfo.CurrentCulture);
				if (text == P_1)
				{
					return P_2;
				}
				break;
			}
			}
		}
		return null;
	}

	private UIElement tFe(string P_0)
	{
		string text = string.Format(CultureInfo.InvariantCulture, Q7Z.tqM(192332), new object[1] { P_0 });
		text = text.Replace(Q7Z.tqM(192368), Q7Z.tqM(192384));
		using StringReader input = new StringReader(text);
		XmlReader xmlReader = XmlReader.Create(input, new XmlReaderSettings
		{
			CheckCharacters = false
		});
		TextBlock textBlock = new TextBlock();
		textBlock.SnapsToDevicePixels = true;
		textBlock.TextWrapping = TextWrapping.Wrap;
		textBlock.Inlines.Add(NFv(xmlReader));
		AutomationProperties.SetItemStatus(textBlock, P_0);
		return textBlock;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private Inline fFl(XmlReader P_0)
	{
		Inline inline = null;
		string attribute = P_0.GetAttribute(Q7Z.tqM(192400));
		string text = P_0.Name.ToLower(CultureInfo.CurrentCulture);
		string text2 = text;
		string text3 = text2;
		switch (global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text3))
		{
		case 3826002220u:
			if (text3 == Q7Z.tqM(10840))
			{
				string attribute4 = P_0.GetAttribute(Q7Z.tqM(192486));
				if (attribute4 != null && !P_0.IsEmptyElement)
				{
					inline = hFQ(P_0, text, new Hyperlink
					{
						NavigateUri = new Uri(attribute4),
						Focusable = false
					});
				}
			}
			break;
		case 3876335077u:
			if (text3 == Q7Z.tqM(192414))
			{
				goto IL_024d;
			}
			break;
		case 3307167098u:
			if (!(text3 == Q7Z.tqM(192420)))
			{
				break;
			}
			goto IL_024d;
		case 1328268469u:
			if (text3 == Q7Z.tqM(192436))
			{
				inline = new LineBreak();
			}
			break;
		case 1075471351u:
			if (!(text3 == Q7Z.tqM(192444)))
			{
				break;
			}
			goto IL_0280;
		case 3960223172u:
			if (!(text3 == Q7Z.tqM(192452)))
			{
				break;
			}
			goto IL_0280;
		case 2229740804u:
		{
			if (!(text3 == Q7Z.tqM(192458)))
			{
				break;
			}
			string attribute2 = P_0.GetAttribute(Q7Z.tqM(192498));
			if (attribute2 == null)
			{
				break;
			}
			Image image = zFA(attribute2);
			if (image == null)
			{
				break;
			}
			inline = new InlineUIContainer
			{
				Child = image
			};
			string attribute3 = P_0.GetAttribute(Q7Z.tqM(192508));
			if (attribute3 != null)
			{
				attribute3 = attribute3.ToLower(CultureInfo.CurrentCulture);
				string text4 = attribute3;
				string text5 = text4;
				if (text5 == Q7Z.tqM(192522))
				{
					inline.BaselineAlignment = BaselineAlignment.Bottom;
				}
				else
				{
					inline.BaselineAlignment = BaselineAlignment.Baseline;
				}
			}
			break;
		}
		case 687964865u:
			if (text3 == Q7Z.tqM(192468) && !P_0.IsEmptyElement)
			{
				inline = hFQ(P_0, text, new Span());
			}
			break;
		case 4027333648u:
			{
				if (text3 == Q7Z.tqM(192480) && !P_0.IsEmptyElement)
				{
					inline = hFQ(P_0, text, new Underline());
				}
				break;
			}
			IL_0280:
			if (!P_0.IsEmptyElement)
			{
				inline = hFQ(P_0, text, new Italic());
			}
			break;
			IL_024d:
			if (!P_0.IsEmptyElement)
			{
				inline = hFQ(P_0, text, new Bold());
			}
			break;
		}
		if (inline != null && attribute != null)
		{
			wFg(inline, attribute);
		}
		return inline;
	}

	private Image zFA(string P_0)
	{
		if (P_0 != null && P_0.StartsWith(Q7Z.tqM(192544), StringComparison.OrdinalIgnoreCase))
		{
			string value = P_0.Substring(Q7Z.tqM(192544).Length);
			try
			{
				if (Enum.TryParse<CommonImageKind>(value, ignoreCase: true, out var result))
				{
					Image image = new Image();
					image.SnapsToDevicePixels = true;
					image.Stretch = Stretch.None;
					image.Source = new CommonImageSourceProvider(result).GetImageSource(BackgroundColorHint);
					return image;
				}
			}
			catch (ArgumentNullException)
			{
			}
			catch (ArgumentException)
			{
			}
		}
		return GetImage(P_0);
	}

	private Inline NFv(XmlReader P_0)
	{
		Span span = new Span();
		while (P_0.Read())
		{
			switch (P_0.NodeType)
			{
			case XmlNodeType.Element:
			{
				Inline inline = fFl(P_0);
				if (inline != null)
				{
					span.Inlines.Add(inline);
				}
				break;
			}
			case XmlNodeType.Whitespace:
			case XmlNodeType.SignificantWhitespace:
				span.Inlines.Add(new Run
				{
					Text = P_0.Value
				});
				break;
			case XmlNodeType.Text:
				span.Inlines.Add(new Run
				{
					Text = P_0.Value
				});
				break;
			}
		}
		return span;
	}

	internal static bool tL5()
	{
		return lL1 == null;
	}

	internal static HtmlContentProvider ELG()
	{
		return lL1;
	}
}
