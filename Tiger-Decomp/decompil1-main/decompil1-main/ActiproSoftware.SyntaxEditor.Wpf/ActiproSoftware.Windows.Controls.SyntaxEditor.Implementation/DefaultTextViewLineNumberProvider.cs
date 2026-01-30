using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

public class DefaultTextViewLineNumberProvider : ITextViewLineNumberProvider
{
	private static DefaultTextViewLineNumberProvider HYj;

	internal static DefaultTextViewLineNumberProvider SAj;

	[SpecialName]
	internal static DefaultTextViewLineNumberProvider fY4()
	{
		if (HYj == null)
		{
			HYj = new DefaultTextViewLineNumberProvider();
		}
		return HYj;
	}

	public virtual string ConvertLineNumberToString(int lineNumber)
	{
		return lineNumber.ToString(CultureInfo.CurrentCulture);
	}

	public virtual string GetLargestLineNumberText(ITextView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IEditorDocument document = view.SyntaxEditor.Document;
		int lineNumber = GetLineNumberOrigin(document) + document.CurrentSnapshot.Lines.Count - 1;
		return ConvertLineNumberToString(lineNumber);
	}

	public virtual int GetLineNumber(ITextViewLine viewLine)
	{
		if (viewLine == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(11110));
		}
		IEditorDocument document = viewLine.SnapshotRange.Snapshot.Document as IEditorDocument;
		return GetLineNumberOrigin(document) + viewLine.VisibleStartPosition.Line;
	}

	protected virtual int GetLineNumberOrigin(IEditorDocument document)
	{
		return document?.LineNumberOrigin ?? 1;
	}

	public virtual string GetLineNumberText(ITextViewLine viewLine)
	{
		if (viewLine == null || viewLine.IsWrapped)
		{
			return null;
		}
		int lineNumber = GetLineNumber(viewLine);
		int num = 0;
		if (rA3() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		return num switch
		{
			_ => ConvertLineNumberToString(lineNumber), 
		};
	}

	public DefaultTextViewLineNumberProvider()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool rAM()
	{
		return SAj == null;
	}

	internal static DefaultTextViewLineNumberProvider rA3()
	{
		return SAj;
	}
}
