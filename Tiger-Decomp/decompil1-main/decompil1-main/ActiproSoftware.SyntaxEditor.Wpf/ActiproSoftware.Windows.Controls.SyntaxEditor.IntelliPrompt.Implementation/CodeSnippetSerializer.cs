using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class CodeSnippetSerializer
{
	internal static CodeSnippetSerializer ua9;

	private static string TuR(XAttribute P_0)
	{
		if (P_0 != null)
		{
			string value = P_0.Value;
			if (value != null)
			{
				value = value.Trim();
				int num = 0;
				if (SaR() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (!string.IsNullOrEmpty(value))
				{
					return value;
				}
			}
		}
		return null;
	}

	private static string IuY(XElement P_0)
	{
		if (P_0 != null)
		{
			string value = P_0.Value;
			bool flag = value != null;
			int num = 0;
			if (!xaJ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (flag)
			{
				value = value.Trim();
				if (!string.IsNullOrEmpty(value))
				{
					return value;
				}
			}
		}
		return null;
	}

	public IEnumerable<ICodeSnippet> LoadFromFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12470));
		}
		using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
		{
			if (fileStream != null)
			{
				return LoadFromStream(fileStream);
			}
		}
		return null;
	}

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public IEnumerable<ICodeSnippet> LoadFromStream(Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12670));
		}
		XElement root = XDocument.Load(stream).Root;
		List<ICodeSnippet> list = new List<ICodeSnippet>();
		if (root != null)
		{
			foreach (XElement item in root.Elements(XName.Get(Q7Z.tqM(12686), Q7Z.tqM(12712))))
			{
				XElement xElement = item.Element(XName.Get(Q7Z.tqM(12832), Q7Z.tqM(12712)));
				if (xElement == null)
				{
					continue;
				}
				CodeSnippet codeSnippet = new CodeSnippet();
				codeSnippet.Author = IuY(xElement.Element(XName.Get(Q7Z.tqM(12848), Q7Z.tqM(12712))));
				codeSnippet.Description = IuY(xElement.Element(XName.Get(Q7Z.tqM(12864), Q7Z.tqM(12712))));
				codeSnippet.HelpUrl = IuY(xElement.Element(XName.Get(Q7Z.tqM(12890), Q7Z.tqM(12712))));
				codeSnippet.Shortcut = IuY(xElement.Element(XName.Get(Q7Z.tqM(12908), Q7Z.tqM(12712))));
				codeSnippet.Title = IuY(xElement.Element(XName.Get(Q7Z.tqM(12928), Q7Z.tqM(12712))));
				XElement xElement2 = xElement.Element(XName.Get(Q7Z.tqM(12942), Q7Z.tqM(12712)));
				if (xElement2 != null)
				{
					foreach (XElement item2 in xElement2.Elements())
					{
						string text = IuY(item2);
						if (!string.IsNullOrEmpty(text))
						{
							codeSnippet.Keywords.Add(text);
						}
					}
				}
				XElement xElement3 = xElement.Element(XName.Get(Q7Z.tqM(12962), Q7Z.tqM(12712)));
				if (xElement3 != null)
				{
					foreach (XElement item3 in xElement3.Elements())
					{
						string text2 = IuY(item3);
						if (string.IsNullOrEmpty(text2))
						{
							continue;
						}
						string text3 = text2.ToUpperInvariant();
						string text4 = text3;
						if (!(text4 == Q7Z.tqM(12990)))
						{
							if (!(text4 == Q7Z.tqM(13012)))
							{
								if (text4 == Q7Z.tqM(13038))
								{
									codeSnippet.SnippetTypes |= CodeSnippetTypes.SurroundsWith;
								}
							}
							else
							{
								codeSnippet.SnippetTypes |= CodeSnippetTypes.Refactoring;
							}
						}
						else
						{
							codeSnippet.SnippetTypes |= CodeSnippetTypes.Expansion;
						}
					}
				}
				XElement xElement4 = item.Element(XName.Get(Q7Z.tqM(13068), Q7Z.tqM(12712)));
				if (xElement4 == null)
				{
					continue;
				}
				XElement xElement5 = xElement4.Element(XName.Get(Q7Z.tqM(13086), Q7Z.tqM(12712)));
				if (xElement5 == null)
				{
					continue;
				}
				codeSnippet.CodeDelimiter = TuR(xElement5.Attribute(XName.Get(Q7Z.tqM(13098))));
				codeSnippet.CodeLanguage = TuR(xElement5.Attribute(XName.Get(Q7Z.tqM(13120))));
				codeSnippet.CodeText = xElement5.Value;
				if (codeSnippet.SnippetTypes == CodeSnippetTypes.None && !string.IsNullOrEmpty(codeSnippet.CodeText))
				{
					codeSnippet.SnippetTypes |= CodeSnippetTypes.Expansion | CodeSnippetTypes.SurroundsWith;
				}
				string text5 = TuR(xElement5.Attribute(XName.Get(Q7Z.tqM(13140))));
				if (!string.IsNullOrEmpty(text5))
				{
					string text6 = text5.ToUpperInvariant();
					string text7 = text6;
					if (!(text7 == Q7Z.tqM(13152)))
					{
						if (!(text7 == Q7Z.tqM(13178)))
						{
							if (!(text7 == Q7Z.tqM(13204)))
							{
								if (text7 == Q7Z.tqM(13226))
								{
									codeSnippet.CodeKind = CodeSnippetKind.File;
								}
								else
								{
									codeSnippet.CodeKind = CodeSnippetKind.Any;
								}
							}
							else
							{
								codeSnippet.CodeKind = CodeSnippetKind.TypeDeclaration;
							}
						}
						else
						{
							codeSnippet.CodeKind = CodeSnippetKind.MemberDeclaration;
						}
					}
					else
					{
						codeSnippet.CodeKind = CodeSnippetKind.MemberBody;
					}
				}
				XElement xElement6 = xElement4.Element(XName.Get(Q7Z.tqM(13238), Q7Z.tqM(12712)));
				if (xElement6 != null)
				{
					foreach (XElement item4 in xElement6.Elements())
					{
						CodeSnippetDeclarationBase codeSnippetDeclarationBase = null;
						string localName = item4.Name.LocalName;
						string text8 = localName;
						if (!(text8 == Q7Z.tqM(13266)))
						{
							if (text8 == Q7Z.tqM(13284))
							{
								codeSnippetDeclarationBase = new CodeSnippetObjectDeclaration
								{
									Type = IuY(item4.Element(XName.Get(Q7Z.tqM(13300), Q7Z.tqM(12712))))
								};
							}
						}
						else
						{
							codeSnippetDeclarationBase = new CodeSnippetLiteralDeclaration();
						}
						if (codeSnippetDeclarationBase != null)
						{
							string text9 = TuR(item4.Attribute(XName.Get(Q7Z.tqM(13312))));
							if (!string.IsNullOrEmpty(text9))
							{
								codeSnippetDeclarationBase.IsEditable = text9.ToUpperInvariant() != Q7Z.tqM(13332);
							}
							codeSnippetDeclarationBase.DefaultText = IuY(item4.Element(XName.Get(Q7Z.tqM(13346), Q7Z.tqM(12712))));
							codeSnippetDeclarationBase.FunctionInvocation = IuY(item4.Element(XName.Get(Q7Z.tqM(13364), Q7Z.tqM(12712))));
							codeSnippetDeclarationBase.Id = IuY(item4.Element(XName.Get(Q7Z.tqM(13384), Q7Z.tqM(12712))));
							codeSnippetDeclarationBase.ToolTip = IuY(item4.Element(XName.Get(Q7Z.tqM(13392), Q7Z.tqM(12712))));
							codeSnippet.Declarations.Add(codeSnippetDeclarationBase);
						}
					}
				}
				XElement xElement7 = xElement4.Element(XName.Get(Q7Z.tqM(13410), Q7Z.tqM(12712)));
				if (xElement7 != null)
				{
					foreach (XElement item5 in xElement7.Elements())
					{
						string text10 = IuY(item5);
						if (!string.IsNullOrEmpty(text10))
						{
							codeSnippet.ImportedNamespaces.Add(text10);
						}
					}
				}
				XElement xElement8 = xElement4.Element(XName.Get(Q7Z.tqM(13428), Q7Z.tqM(12712)));
				if (xElement8 != null)
				{
					foreach (XElement item6 in xElement8.Elements())
					{
						CodeSnippetAssemblyReference codeSnippetAssemblyReference = new CodeSnippetAssemblyReference();
						codeSnippetAssemblyReference.Assembly = IuY(item6.Element(XName.Get(Q7Z.tqM(13452), Q7Z.tqM(12712))));
						codeSnippetAssemblyReference.Url = IuY(item6.Element(XName.Get(Q7Z.tqM(13472), Q7Z.tqM(12712))));
						codeSnippet.References.Add(codeSnippetAssemblyReference);
					}
				}
				list.Add(codeSnippet);
			}
		}
		return list;
	}

	public void SaveToFile(string path, params ICodeSnippet[] codeSnippets)
	{
		if (path == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12470));
		}
		using FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
		if (fileStream != null)
		{
			SaveToStream(fileStream, codeSnippets);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public void SaveToStream(Stream stream, params ICodeSnippet[] codeSnippets)
	{
		if (stream == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12670));
		}
		if (codeSnippets == null || codeSnippets.Length == 0)
		{
			return;
		}
		XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
		xmlWriterSettings.Indent = true;
		xmlWriterSettings.IndentChars = Q7Z.tqM(7824);
		XmlWriter xmlWriter = XmlWriter.Create(stream, xmlWriterSettings);
		xmlWriter.WriteStartDocument();
		xmlWriter.WriteStartElement(Q7Z.tqM(13482), Q7Z.tqM(12712));
		foreach (ICodeSnippet codeSnippet in codeSnippets)
		{
			if (codeSnippet == null)
			{
				continue;
			}
			xmlWriter.WriteStartElement(Q7Z.tqM(12686), Q7Z.tqM(12712));
			xmlWriter.WriteAttributeString(Q7Z.tqM(13510), Q7Z.tqM(13526));
			xmlWriter.WriteStartElement(Q7Z.tqM(12832), Q7Z.tqM(12712));
			if (!string.IsNullOrEmpty(codeSnippet.Title))
			{
				xmlWriter.WriteElementString(Q7Z.tqM(12928), Q7Z.tqM(12712), codeSnippet.Title);
			}
			if (!string.IsNullOrEmpty(codeSnippet.Shortcut))
			{
				xmlWriter.WriteElementString(Q7Z.tqM(12908), Q7Z.tqM(12712), codeSnippet.Shortcut);
			}
			if (!string.IsNullOrEmpty(codeSnippet.Description))
			{
				xmlWriter.WriteElementString(Q7Z.tqM(12864), Q7Z.tqM(12712), codeSnippet.Description);
			}
			if (!string.IsNullOrEmpty(codeSnippet.Author))
			{
				xmlWriter.WriteElementString(Q7Z.tqM(12848), Q7Z.tqM(12712), codeSnippet.Author);
			}
			if (!string.IsNullOrEmpty(codeSnippet.HelpUrl))
			{
				xmlWriter.WriteElementString(Q7Z.tqM(12890), Q7Z.tqM(12712), codeSnippet.HelpUrl);
			}
			xmlWriter.WriteStartElement(Q7Z.tqM(12962), Q7Z.tqM(12712));
			if ((codeSnippet.SnippetTypes & CodeSnippetTypes.Expansion) == CodeSnippetTypes.Expansion)
			{
				xmlWriter.WriteElementString(Q7Z.tqM(13540), Q7Z.tqM(12712), Q7Z.tqM(13566));
			}
			if ((codeSnippet.SnippetTypes & CodeSnippetTypes.Refactoring) == CodeSnippetTypes.Refactoring)
			{
				xmlWriter.WriteElementString(Q7Z.tqM(13540), Q7Z.tqM(12712), Q7Z.tqM(13588));
			}
			if ((codeSnippet.SnippetTypes & CodeSnippetTypes.SurroundsWith) == CodeSnippetTypes.SurroundsWith)
			{
				xmlWriter.WriteElementString(Q7Z.tqM(13540), Q7Z.tqM(12712), Q7Z.tqM(13614));
			}
			xmlWriter.WriteEndElement();
			if (codeSnippet.Keywords != null && codeSnippet.Keywords.Any())
			{
				xmlWriter.WriteStartElement(Q7Z.tqM(12942), Q7Z.tqM(12712));
				foreach (string keyword in codeSnippet.Keywords)
				{
					if (!string.IsNullOrEmpty(keyword))
					{
						xmlWriter.WriteElementString(Q7Z.tqM(13644), Q7Z.tqM(12712), keyword);
					}
				}
				xmlWriter.WriteEndElement();
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement(Q7Z.tqM(13068), Q7Z.tqM(12712));
			if (codeSnippet.Declarations != null && codeSnippet.Declarations.Any())
			{
				xmlWriter.WriteStartElement(Q7Z.tqM(13238), Q7Z.tqM(12712));
				foreach (ICodeSnippetDeclaration declaration in codeSnippet.Declarations)
				{
					if (declaration == null)
					{
						continue;
					}
					if (declaration is CodeSnippetObjectDeclaration codeSnippetObjectDeclaration)
					{
						xmlWriter.WriteStartElement(Q7Z.tqM(13284), Q7Z.tqM(12712));
						if (!string.IsNullOrEmpty(codeSnippetObjectDeclaration.Type))
						{
							xmlWriter.WriteElementString(Q7Z.tqM(13300), Q7Z.tqM(12712), codeSnippetObjectDeclaration.Type);
						}
					}
					else
					{
						xmlWriter.WriteStartElement(Q7Z.tqM(13266), Q7Z.tqM(12712));
					}
					if (!declaration.IsEditable)
					{
						xmlWriter.WriteAttributeString(Q7Z.tqM(13662), declaration.IsEditable.ToString(CultureInfo.InvariantCulture));
					}
					if (!string.IsNullOrEmpty(declaration.Id))
					{
						xmlWriter.WriteElementString(Q7Z.tqM(13384), Q7Z.tqM(12712), declaration.Id);
					}
					if (!string.IsNullOrEmpty(declaration.ToolTip))
					{
						xmlWriter.WriteElementString(Q7Z.tqM(13392), Q7Z.tqM(12712), declaration.ToolTip);
					}
					if (!string.IsNullOrEmpty(declaration.DefaultText))
					{
						xmlWriter.WriteElementString(Q7Z.tqM(13346), Q7Z.tqM(12712), declaration.DefaultText);
					}
					if (!string.IsNullOrEmpty(declaration.FunctionInvocation))
					{
						xmlWriter.WriteElementString(Q7Z.tqM(13364), Q7Z.tqM(12712), declaration.FunctionInvocation);
					}
					xmlWriter.WriteEndElement();
				}
				xmlWriter.WriteEndElement();
			}
			if (!string.IsNullOrEmpty(codeSnippet.CodeText))
			{
				xmlWriter.WriteStartElement(Q7Z.tqM(13086), Q7Z.tqM(12712));
				if (!string.IsNullOrEmpty(codeSnippet.CodeDelimiter))
				{
					xmlWriter.WriteAttributeString(Q7Z.tqM(13098), codeSnippet.CodeDelimiter);
				}
				if (!string.IsNullOrEmpty(codeSnippet.CodeLanguage))
				{
					xmlWriter.WriteAttributeString(Q7Z.tqM(13120), codeSnippet.CodeLanguage);
				}
				switch (codeSnippet.CodeKind)
				{
				case CodeSnippetKind.MemberBody:
					xmlWriter.WriteAttributeString(Q7Z.tqM(13140), Q7Z.tqM(13686));
					break;
				case CodeSnippetKind.MemberDeclaration:
					xmlWriter.WriteAttributeString(Q7Z.tqM(13140), Q7Z.tqM(13712));
					break;
				case CodeSnippetKind.TypeDeclaration:
					xmlWriter.WriteAttributeString(Q7Z.tqM(13140), Q7Z.tqM(13738));
					break;
				case CodeSnippetKind.File:
					xmlWriter.WriteAttributeString(Q7Z.tqM(13140), Q7Z.tqM(13760));
					break;
				}
				xmlWriter.WriteCData(codeSnippet.CodeText);
				xmlWriter.WriteEndElement();
			}
			if (codeSnippet.ImportedNamespaces != null && codeSnippet.ImportedNamespaces.Any())
			{
				xmlWriter.WriteStartElement(Q7Z.tqM(13410), Q7Z.tqM(12712));
				foreach (string importedNamespace in codeSnippet.ImportedNamespaces)
				{
					if (!string.IsNullOrEmpty(importedNamespace))
					{
						xmlWriter.WriteStartElement(Q7Z.tqM(13772), Q7Z.tqM(12712));
						xmlWriter.WriteElementString(Q7Z.tqM(13788), Q7Z.tqM(12712), importedNamespace);
						xmlWriter.WriteEndElement();
					}
				}
				xmlWriter.WriteEndElement();
			}
			if (codeSnippet.References != null && codeSnippet.References.Any())
			{
				xmlWriter.WriteStartElement(Q7Z.tqM(13428), Q7Z.tqM(12712));
				foreach (ICodeSnippetAssemblyReference reference in codeSnippet.References)
				{
					if (reference != null)
					{
						xmlWriter.WriteStartElement(Q7Z.tqM(13810), Q7Z.tqM(12712));
						if (!string.IsNullOrEmpty(reference.Assembly))
						{
							xmlWriter.WriteElementString(Q7Z.tqM(13452), Q7Z.tqM(12712), reference.Assembly);
						}
						if (!string.IsNullOrEmpty(reference.Url))
						{
							xmlWriter.WriteElementString(Q7Z.tqM(13472), Q7Z.tqM(12712), reference.Url);
						}
						xmlWriter.WriteEndElement();
					}
				}
				xmlWriter.WriteEndElement();
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteEndElement();
		}
		xmlWriter.WriteEndElement();
		xmlWriter.WriteEndDocument();
		xmlWriter.Flush();
	}

	public CodeSnippetSerializer()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool xaJ()
	{
		return ua9 == null;
	}

	internal static CodeSnippetSerializer SaR()
	{
		return ua9;
	}
}
