using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

namespace ActiproSoftware.Internal;

internal class hB : SimpleObservableCollection<ISignatureItem>, ISignatureItemCollection, IObservableCollection<ISignatureItem>, IList<ISignatureItem>, ICollection<ISignatureItem>, IEnumerable<ISignatureItem>, IEnumerable
{
	internal static hB wgF;

	public hB()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	[SpecialName]
	bool ICollection<ISignatureItem>.get_IsReadOnly()
	{
		return IsReadOnly;
	}

	internal static bool Yg9()
	{
		return wgF == null;
	}

	internal static hB sgJ()
	{
		return wgF;
	}
}
