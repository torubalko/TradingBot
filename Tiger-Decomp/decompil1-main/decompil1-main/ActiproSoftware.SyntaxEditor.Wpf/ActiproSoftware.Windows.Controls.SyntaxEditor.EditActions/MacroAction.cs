using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows.Input;
using System.Xml;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public class MacroAction : EditActionBase, IEnumerable<IEditAction>, IEnumerable, IMacroAction, IEditAction, IKeyedObject, ICommand
{
	private List<IEditAction> aLh;

	internal static MacroAction wkM;

	public override bool CanRecordInMacro => false;

	public int Count => aLh.Count;

	public bool IsEmpty => Count == 0;

	public IEditAction this[int index] => aLh[index];

	public MacroAction()
	{
		grA.DaB7cz();
		aLh = new List<IEditAction>();
		base._002Ector(SR.GetString(SRName.UICommandMacroText));
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return aLh.GetEnumerator();
	}

	public void Add(IEditAction action)
	{
		if (action == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7788));
		}
		if (!action.CanRecordInMacro)
		{
			throw new ArgumentException(SR.GetString(SRName.ExEditActionCannotRecord));
		}
		aLh.Add(action);
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		foreach (IEditAction item in aLh)
		{
			view.ExecuteEditAction(item);
		}
	}

	public IEnumerator<IEditAction> GetEnumerator()
	{
		return aLh.GetEnumerator();
	}

	public override void ReadFromXml(XmlReader reader)
	{
		if (reader == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(195884));
		}
		reader.Read();
		if (!reader.EOF && reader.NodeType == XmlNodeType.XmlDeclaration)
		{
			reader.Read();
		}
		if (reader.IsEmptyElement)
		{
			return;
		}
		int depth = reader.Depth;
		reader.Read();
		while (!reader.EOF && reader.Depth > depth)
		{
			XmlNodeType nodeType = reader.NodeType;
			XmlNodeType xmlNodeType = nodeType;
			if (xmlNodeType == XmlNodeType.Element)
			{
				string name = reader.Name;
				string text = name;
				if (text == Q7Z.tqM(195986))
				{
					string attribute = reader.GetAttribute(Q7Z.tqM(196010));
					string attribute2 = reader.GetAttribute(Q7Z.tqM(196038));
					Type type = vAE.m0l(string.Format(CultureInfo.InvariantCulture, Q7Z.tqM(196058), new object[2] { attribute2, attribute }));
					if (type != null && Activator.CreateInstance(type) is IEditAction editAction)
					{
						editAction.ReadFromXml(reader);
						Add(editAction);
					}
				}
			}
			reader.Read();
		}
	}

	public override void WriteToXml(XmlWriter writer)
	{
		if (writer == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(195920));
		}
		writer.WriteStartElement(Q7Z.tqM(196078));
		using (IEnumerator<IEditAction> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				IEditAction current = enumerator.Current;
				writer.WriteStartElement(Q7Z.tqM(195986));
				string text = current.GetType().Assembly.FullName;
				int num = text.IndexOf(',');
				if (num > 0)
				{
					text = text.Substring(0, num);
				}
				writer.WriteAttributeString(Q7Z.tqM(196010), text);
				writer.WriteAttributeString(Q7Z.tqM(196038), current.GetType().FullName);
				current.WriteToXml(writer);
				writer.WriteEndElement();
			}
		}
		writer.WriteEndElement();
	}

	internal static bool xk3()
	{
		return wkM == null;
	}

	internal static MacroAction Lkv()
	{
		return wkM;
	}
}
