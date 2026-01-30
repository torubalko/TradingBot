using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class TypingAction : EditActionBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public bool f9Y;

		internal static _003C_003Ec__DisplayClass2_0 mvZ;

		public _003C_003Ec__DisplayClass2_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal Range g9R(ITextViewLine viewLine, Range characterRange)
		{
			if ((characterRange.Length == 0) & f9Y)
			{
				characterRange = new Range(characterRange.Min, characterRange.Max + 1);
			}
			return characterRange;
		}

		internal static bool QvF()
		{
			return mvZ == null;
		}

		internal static _003C_003Ec__DisplayClass2_0 wv9()
		{
			return mvZ;
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool fLJ;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string WLt;

	private static TypingAction Nk7;

	public bool Overwrite
	{
		[CompilerGenerated]
		get
		{
			return fLJ;
		}
		[CompilerGenerated]
		private set
		{
			fLJ = value;
		}
	}

	public string TypedText
	{
		[CompilerGenerated]
		get
		{
			return WLt;
		}
		[CompilerGenerated]
		private set
		{
			WLt = value;
		}
	}

	public TypingAction()
	{
		grA.DaB7cz();
		base._002Ector(null);
		TypedText = string.Empty;
	}

	public TypingAction(string typedText, bool overwrite)
	{
		grA.DaB7cz();
		base._002Ector(null);
		TypedText = typedText;
		Overwrite = overwrite;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (TypedText == null)
		{
			return;
		}
		using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.None))
		{
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass2_0();
			CS_0024_003C_003E8__locals3.f9Y = Overwrite;
			int num;
			if (CS_0024_003C_003E8__locals3.f9Y)
			{
				num = 0;
				if (!Jkn())
				{
					goto IL_001e;
				}
				goto IL_0022;
			}
			goto IL_017a;
			IL_017a:
			EditorViewTextChangeOptions editorViewTextChangeOptions = new EditorViewTextChangeOptions(view)
			{
				CanApplyToBlockEdit = true,
				CanApplyToMultipleSelections = true,
				CheckReadOnly = !view.IsIncrementalSearchActive
			};
			editorViewTextChangeOptions.BlockEditRangeAdjustFunc = delegate(ITextViewLine viewLine, Range characterRange)
			{
				if ((characterRange.Length == 0) & CS_0024_003C_003E8__locals3.f9Y)
				{
					characterRange = new Range(characterRange.Min, characterRange.Max + 1);
				}
				return characterRange;
			};
			view.ReplaceSelectedText(TextChangeTypes.Typing, TypedText, editorViewTextChangeOptions);
			return;
			IL_001e:
			int num2 = default(int);
			num = num2;
			goto IL_0022;
			IL_0022:
			TextPositionRange[] array = default(TextPositionRange[]);
			while (true)
			{
				switch (num)
				{
				default:
				{
					bool flag = false;
					array = view.Selection.Ranges.ToArray();
					for (int num3 = array.Length - 1; num3 >= 0; num3--)
					{
						TextPositionRange textPositionRange = array[num3];
						if (textPositionRange.IsZeroLength)
						{
							flag = true;
							array[num3] = new TextPositionRange(textPositionRange.EndPosition.Line, textPositionRange.EndPosition.Character, textPositionRange.EndPosition.Line, textPositionRange.EndPosition.Character + 1);
						}
					}
					if (!flag)
					{
						break;
					}
					goto IL_00cc;
				}
				case 1:
					view.Selection.SelectRanges(array);
					break;
				}
				break;
				IL_00cc:
				num = 1;
				if (okq() == null)
				{
					continue;
				}
				goto IL_001e;
			}
			goto IL_017a;
		}
	}

	public override void ReadFromXml(XmlReader reader)
	{
		if (reader == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(195884));
		}
		TypedText = reader.GetAttribute(Q7Z.tqM(195942)) ?? reader.GetAttribute(Q7Z.tqM(7058));
		Overwrite = Convert.ToBoolean(reader.GetAttribute(Q7Z.tqM(195964)), CultureInfo.InvariantCulture);
	}

	public override void WriteToXml(XmlWriter writer)
	{
		if (writer == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(195920));
		}
		writer.WriteAttributeString(Q7Z.tqM(195942), TypedText);
		writer.WriteAttributeString(Q7Z.tqM(195964), Convert.ToString(Overwrite, CultureInfo.InvariantCulture));
	}

	internal static bool Jkn()
	{
		return Nk7 == null;
	}

	internal static TypingAction okq()
	{
		return Nk7;
	}
}
