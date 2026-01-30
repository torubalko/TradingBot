using System.Diagnostics.CodeAnalysis;
using System.Windows;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Internal;

internal abstract class dTt : IDataStore
{
	private static dTt QAG;

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public DataStoreTextKind TextKind
	{
		get
		{
			try
			{
				bool dataPresent = GetDataPresent(Q7Z.tqM(193128));
				int num = 0;
				if (!jAN())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
					if (dataPresent)
					{
						return DataStoreTextKind.Block;
					}
					if (!GetDataPresent(Q7Z.tqM(193166)))
					{
						break;
					}
					return DataStoreTextKind.FullLine;
				}
			}
			catch
			{
			}
			return DataStoreTextKind.Default;
		}
	}

	public abstract object GetData(string P_0);

	public abstract bool GetDataPresent(string P_0);

	public string GetText()
	{
		string text = GetData(DataFormats.UnicodeText) as string;
		if (string.IsNullOrEmpty(text))
		{
			text = GetData(DataFormats.Text) as string;
		}
		return text;
	}

	public void SetData(string P_0, object P_1)
	{
		W8y(P_0, P_1, _0020: false);
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public void SetText(string P_0, DataStoreTextKind P_1)
	{
		try
		{
			W8y(DataFormats.UnicodeText, P_0, _0020: true);
			int num = 0;
			if (!jAN())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			W8y(DataFormats.Text, P_0, _0020: true);
			switch (P_1)
			{
			case DataStoreTextKind.FullLine:
				W8y(Q7Z.tqM(193166), true, _0020: false);
				break;
			case DataStoreTextKind.Block:
				W8y(Q7Z.tqM(193128), true, _0020: false);
				break;
			}
		}
		catch
		{
		}
	}

	protected abstract void W8y(string P_0, object P_1, bool P_2);

	public abstract IDataObject ToDataObject();

	protected dTt()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool jAN()
	{
		return QAG == null;
	}

	internal static dTt WAH()
	{
		return QAG;
	}
}
