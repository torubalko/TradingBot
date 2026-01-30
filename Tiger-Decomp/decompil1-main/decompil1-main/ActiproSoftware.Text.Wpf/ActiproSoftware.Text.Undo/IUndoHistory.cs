using System;

namespace ActiproSoftware.Text.Undo;

public interface IUndoHistory
{
	bool CanRedo { get; }

	bool CanUndo { get; }

	IUndoableTextChangeStack RedoStack { get; }

	IUndoableTextChangeStack UndoStack { get; }

	event EventHandler Cleared;

	event EventHandler<UndoRedoRequestEventArgs> UndoRedoRequested;

	void Clear();

	void Clear(bool resetChangeTracking);

	SavePointChangeType GetChangeTypeForLineRange(int startLineIndex, int endLineIndex);

	bool Redo();

	int Redo(int count);

	bool Undo();

	int Undo(int count);
}
