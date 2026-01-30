using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text.Undo;

[SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public interface IUndoableTextChangeStack : IEnumerable<IUndoableTextChange>, IEnumerable
{
	int Capacity { get; set; }

	int Count { get; }

	bool IsAtSavePoint { get; }

	event EventHandler CapacityChanged;

	event EventHandler StackChanged;

	void CopyTo(IUndoableTextChange[] array, int arrayIndex);

	IUndoableTextChange GetTextChange(int index);

	int IndexOf(IUndoableTextChange textChange);
}
