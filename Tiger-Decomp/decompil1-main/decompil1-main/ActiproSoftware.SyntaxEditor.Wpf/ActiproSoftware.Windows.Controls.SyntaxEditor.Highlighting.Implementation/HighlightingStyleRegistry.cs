using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media;
using System.Xml;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public class HighlightingStyleRegistry : IHighlightingStyleRegistry, IClassificationTypeRegistry, IEnumerable<IClassificationType>, IEnumerable, IEnumerable<KeyValuePair<IClassificationType, IHighlightingStyle>>
{
	private Dictionary<string, IClassificationType> hLV;

	private Dictionary<IClassificationType, IHighlightingStyle> HLr;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler hLs;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string qLk;

	internal static HighlightingStyleRegistry TWz;

	IClassificationType IClassificationTypeRegistry.this[string key] => GetClassificationType(key);

	public ICollection<IClassificationType> ClassificationTypes
	{
		get
		{
			Comparison<IClassificationType> fallbackComparison = (IClassificationType left, IClassificationType right) => string.Compare(left.Description, right.Description, StringComparison.CurrentCulture);
			return OrderableHelper.Sort(HLr.Keys, null, fallbackComparison);
		}
	}

	public int Count => HLr.Count;

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return qLk;
		}
		[CompilerGenerated]
		set
		{
			qLk = value;
		}
	}

	public ICollection<IHighlightingStyle> HighlightingStyles => HLr.Values;

	public IHighlightingStyle this[IClassificationType classificationType]
	{
		get
		{
			if (HLr.TryGetValue(classificationType, out var value))
			{
				return value;
			}
			return null;
		}
	}

	public event EventHandler Changed
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = hLs;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref hLs, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = hLs;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref hLs, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return HLr.GetEnumerator();
	}

	IEnumerator<IClassificationType> IEnumerable<IClassificationType>.GetEnumerator()
	{
		foreach (IClassificationType key in HLr.Keys)
		{
			yield return key;
		}
	}

	private void qL8(IHighlightingStyle P_0, IHighlightingStyle P_1)
	{
		if (P_0 != null)
		{
			P_0.PropertyChanged -= TL0;
		}
		if (P_1 != null)
		{
			P_1.PropertyChanged += TL0;
		}
	}

	private IClassificationType iLI(string P_0)
	{
		foreach (IClassificationType key in HLr.Keys)
		{
			if (string.Compare(key.Description, P_0, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return key;
			}
		}
		return null;
	}

	private IClassificationType mL5(string P_0)
	{
		foreach (IClassificationType key in HLr.Keys)
		{
			if (key.Key == P_0)
			{
				return key;
			}
		}
		return null;
	}

	private void TL0(object P_0, PropertyChangedEventArgs P_1)
	{
		OnChanged(EventArgs.Empty);
	}

	public IClassificationType GetClassificationType(string key)
	{
		if (hLV.TryGetValue(key, out var value))
		{
			return value;
		}
		return null;
	}

	public IEnumerator<KeyValuePair<IClassificationType, IHighlightingStyle>> GetEnumerator()
	{
		return HLr.GetEnumerator();
	}

	protected virtual void OnChanged(EventArgs e)
	{
		hLs?.Invoke(this, e);
	}

	public bool Register(IClassificationType classificationType, IHighlightingStyle style)
	{
		return Register(classificationType, style, overwriteExisting: false);
	}

	public bool Register(IClassificationType classificationType, IHighlightingStyle style, bool overwriteExisting)
	{
		if (classificationType == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(195212));
		}
		if (style == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192400));
		}
		if (!overwriteExisting && HLr.ContainsKey(classificationType))
		{
			return false;
		}
		IHighlightingStyle highlightingStyle = this[classificationType];
		HLr[classificationType] = style;
		qL8(highlightingStyle, style);
		if (GetClassificationType(classificationType.Key) == null)
		{
			hLV[classificationType.Key] = classificationType;
		}
		OnChanged(EventArgs.Empty);
		return true;
	}

	public bool Unregister(IClassificationType classificationType)
	{
		if (classificationType == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(195212));
		}
		IHighlightingStyle highlightingStyle = this[classificationType];
		bool flag = HLr.Remove(classificationType);
		qL8(highlightingStyle, null);
		if (GetClassificationType(classificationType.Key) == classificationType)
		{
			hLV.Remove(classificationType.Key);
			classificationType = mL5(classificationType.Key);
			if (classificationType != null)
			{
				hLV[classificationType.Key] = classificationType;
				int num = 0;
				if (!xSm())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
		}
		if (flag)
		{
			OnChanged(EventArgs.Empty);
		}
		return flag;
	}

	private static XmlAttribute JLB(XmlAttributeCollection P_0, string P_1)
	{
		return P_0[P_1];
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	[SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "ActiproSoftware.Windows.Media.UIColor.FromWebColor(System.String)")]
	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public bool ImportHighlightingStyles(Stream stream)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(stream);
		XmlNode xmlNode = xmlDocument.SelectSingleNode(Q7Z.tqM(195252));
		if (xmlNode != null)
		{
			XmlAttribute xmlAttribute = JLB(xmlNode.Attributes, Q7Z.tqM(195640));
			if (xmlAttribute != null && xmlAttribute.Value != null)
			{
				IEnumerable<FontFamily> enumerable = null;
				try
				{
					enumerable = Fonts.SystemFontFamilies;
				}
				catch
				{
				}
				string fontFamilyName = null;
				if (enumerable != null)
				{
					foreach (FontFamily item in enumerable)
					{
						if (string.CompareOrdinal(item.Source, xmlAttribute.Value) == 0)
						{
							fontFamilyName = xmlAttribute.Value;
							break;
						}
					}
				}
				IHighlightingStyle highlightingStyle = HLr[cT.PlainText];
				if (highlightingStyle != null)
				{
					highlightingStyle.FontFamilyName = fontFamilyName;
				}
				IHighlightingStyle highlightingStyle2 = HLr[cT.LineNumbers];
				if (highlightingStyle2 != null)
				{
					highlightingStyle2.FontFamilyName = fontFamilyName;
				}
			}
			xmlAttribute = JLB(xmlNode.Attributes, Q7Z.tqM(194660));
			if (xmlAttribute != null && xmlAttribute.Value != null && float.TryParse(xmlAttribute.Value, out var result) && result > 0f)
			{
				result *= 1.3333334f;
				IHighlightingStyle highlightingStyle3 = HLr[cT.PlainText];
				if (highlightingStyle3 != null)
				{
					highlightingStyle3.FontSize = result;
				}
				IHighlightingStyle highlightingStyle4 = HLr[cT.LineNumbers];
				if (highlightingStyle4 != null)
				{
					highlightingStyle4.FontSize = result;
				}
			}
			XmlNodeList xmlNodeList = xmlNode.SelectNodes(Q7Z.tqM(195660));
			foreach (XmlNode item2 in xmlNodeList)
			{
				string text = JLB(item2.Attributes, Q7Z.tqM(195684))?.Value;
				string text2 = text;
				string text3 = text2;
				if (text3 == Q7Z.tqM(195696))
				{
					text = Q7Z.tqM(195732);
				}
				if (text == null)
				{
					continue;
				}
				IClassificationType classificationType = iLI(text);
				if (classificationType == null)
				{
					continue;
				}
				IHighlightingStyle highlightingStyle5 = HLr[classificationType];
				if (highlightingStyle5 == null)
				{
					continue;
				}
				xmlAttribute = JLB(item2.Attributes, Q7Z.tqM(194680));
				if (xmlAttribute != null)
				{
					string value = xmlAttribute.Value;
					if (value != null && value.Length >= 6)
					{
						if (value != Q7Z.tqM(195764))
						{
							value = value.Substring(value.Length - 6);
							Color value2 = UIColor.FromWebColor(Q7Z.tqM(195788) + value.Substring(4, 2) + value.Substring(2, 2) + value.Substring(0, 2)).ToColor();
							highlightingStyle5.Foreground = value2;
						}
						else
						{
							highlightingStyle5.Foreground = null;
						}
					}
				}
				xmlAttribute = JLB(item2.Attributes, Q7Z.tqM(194448));
				if (xmlAttribute != null)
				{
					string value3 = xmlAttribute.Value;
					if (value3 != null && value3.Length >= 6)
					{
						if (value3 != Q7Z.tqM(195764))
						{
							value3 = value3.Substring(value3.Length - 6);
							Color value4 = UIColor.FromWebColor(Q7Z.tqM(195788) + value3.Substring(4, 2) + value3.Substring(2, 2) + value3.Substring(0, 2)).ToColor();
							if (text == Q7Z.tqM(195794))
							{
								highlightingStyle5.BorderColor = value4;
								highlightingStyle5.Background = null;
							}
							else
							{
								highlightingStyle5.Background = value4;
							}
						}
						else
						{
							highlightingStyle5.Background = null;
						}
					}
				}
				xmlAttribute = JLB(item2.Attributes, Q7Z.tqM(195854));
				if (xmlAttribute != null)
				{
					highlightingStyle5.Bold = xmlAttribute.Value == Q7Z.tqM(195874);
				}
			}
			return true;
		}
		return false;
	}

	public HighlightingStyleRegistry()
	{
		grA.DaB7cz();
		hLV = new Dictionary<string, IClassificationType>();
		HLr = new Dictionary<IClassificationType, IHighlightingStyle>();
		base._002Ector();
	}

	internal static bool xSm()
	{
		return TWz == null;
	}

	internal static HighlightingStyleRegistry QSp()
	{
		return TWz;
	}
}
