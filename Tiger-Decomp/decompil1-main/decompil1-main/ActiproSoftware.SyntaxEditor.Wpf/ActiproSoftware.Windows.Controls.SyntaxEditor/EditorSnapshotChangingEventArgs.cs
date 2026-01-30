using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.RegularExpressions;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public class EditorSnapshotChangingEventArgs : CancelRoutedEventArgs
{
	private ITextSnapshot HaK;

	private ITextSnapshot aaf;

	private ITextChange paD;

	private static EditorSnapshotChangingEventArgs jb;

	public bool IsTypedWordStart => EditorSnapshotChangedEventArgs.GetIsTypedWordStart(HaK, paD, CharClass.Alpha);

	public ITextSnapshot NewSnapshot => HaK;

	public ITextSnapshot OldSnapshot => aaf;

	public ITextChange TextChange => paD;

	public string TypedText
	{
		get
		{
			if (paD != null && !paD.IsUndo && !paD.IsRedo && paD.Operations.Count == 1 && paD.Operations[0].InsertionLength > 0 && paD.Type == TextChangeTypes.Typing)
			{
				return paD.Operations[0].InsertedText;
			}
			return null;
		}
	}

	public EditorSnapshotChangingEventArgs(ITextSnapshot oldSnapshot, ITextSnapshot newSnapshot, ITextChange textChange)
	{
		grA.DaB7cz();
		base._002Ector();
		aaf = oldSnapshot;
		HaK = newSnapshot;
		paD = textChange;
	}

	internal static bool xs()
	{
		return jb == null;
	}

	internal static EditorSnapshotChangingEventArgs EP()
	{
		return jb;
	}
}
