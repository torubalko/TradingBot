using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Threading;
using System.Windows;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Exporters;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Internal;

internal class cTH : dTt
{
	private IDataObject aYY;

	internal static cTH TAO;

	internal cTH()
	{
		grA.DaB7cz();
		base._002Ector();
		aYY = new DataObject();
	}

	internal cTH(IDataObject P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192900));
		}
		aYY = P_0;
	}

	internal void mY3(SyntaxEditor P_0, ITextSnapshot P_1, IList<TextRange> P_2)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8238));
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12044));
		}
		if (P_2 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192924));
		}
		if (P_2.Count <= 0)
		{
			return;
		}
		TextExporterFactory textExporterFactory = new TextExporterFactory(P_0.HighlightingStyleRegistry);
		List<ITextExporter> list = new List<ITextExporter>();
		if (P_0.CanCutCopyDragWithHtml)
		{
			list.Add(textExporterFactory.CreateHtmlClipboard());
		}
		if (P_0.CanCutCopyDragWithRtf)
		{
			list.Add(textExporterFactory.CreateRtf());
		}
		if (list.Count <= 0)
		{
			return;
		}
		foreach (ITextExporter item in list)
		{
			if (item != null && !string.IsNullOrEmpty(item.DataFormat))
			{
				string text = item.Export(P_1, P_2);
				if (text != null)
				{
					W8y(item.DataFormat, text, _0020: true);
				}
			}
		}
	}

	internal void rYR(IEditorView P_0)
	{
		TextPositionRange positionRange = P_0.Selection.PositionRange;
		W8y(Q7Z.tqM(192948), P_0.UniqueId.ToString(), _0020: false);
		W8y(Q7Z.tqM(192988), P_0.SyntaxEditor.Document.UniqueId.ToString(), _0020: false);
		W8y(Q7Z.tqM(193036), string.Format(CultureInfo.InvariantCulture, Q7Z.tqM(193094), positionRange.StartPosition.Line, positionRange.StartPosition.Character, positionRange.EndPosition.Line, positionRange.EndPosition.Character), _0020: false);
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public override object GetData(string P_0)
	{
		object result = null;
		try
		{
			if (GetDataPresent(P_0))
			{
				try
				{
					result = aYY.GetData(P_0, autoConvert: false);
				}
				catch (OutOfMemoryException)
				{
				}
				catch (SystemException)
				{
					try
					{
						Thread.Sleep(100);
						result = aYY.GetData(P_0, autoConvert: false);
					}
					catch (SystemException)
					{
					}
				}
			}
		}
		catch
		{
		}
		return result;
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public override bool GetDataPresent(string P_0)
	{
		try
		{
			return aYY.GetDataPresent(P_0, autoConvert: false);
		}
		catch (SystemException)
		{
			try
			{
				Thread.Sleep(100);
				return aYY.GetDataPresent(P_0, autoConvert: false);
			}
			catch (SystemException)
			{
				return false;
			}
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	protected override void W8y(string P_0, object P_1, bool P_2)
	{
		try
		{
			aYY.SetData(P_0, P_1, P_2);
		}
		catch (SystemException)
		{
			try
			{
				Thread.Sleep(100);
				aYY.SetData(P_0, P_1, P_2);
			}
			catch (SystemException)
			{
			}
		}
	}

	public override IDataObject ToDataObject()
	{
		return aYY;
	}

	internal static bool dA1()
	{
		return TAO == null;
	}

	internal static cTH BA5()
	{
		return TAO;
	}
}
