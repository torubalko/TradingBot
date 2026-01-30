using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Parsing;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

namespace ActiproSoftware.Text.Tagging.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tagger")]
public class ParseErrorTagger : CollectionTagger<ISquiggleTag>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public ICodeDocument Jyj;

		private static _003C_003Ec__DisplayClass3_0 rfi;

		public _003C_003Ec__DisplayClass3_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void jyo(WeakEventListener<ParseErrorTagger, EventArgs> weakEventListener)
		{
			Jyj.ParseDataChanged -= weakEventListener.OnEvent;
		}

		internal static bool Mf2()
		{
			return rfi == null;
		}

		internal static _003C_003Ec__DisplayClass3_0 CfV()
		{
			return rfi;
		}
	}

	private WeakEventListener<ParseErrorTagger, EventArgs> rID;

	private int yIg;

	internal static ParseErrorTagger y5s;

	public int MaximumParseErrorCount
	{
		get
		{
			return yIg;
		}
		set
		{
			if (yIg != value)
			{
				yIg = Math.Max(0, value);
				XIf();
			}
		}
	}

	public ParseErrorTagger(ICodeDocument document)
	{
		grA.DaB7cz();
		yIg = 5000;
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals5.Jyj = document;
		base._002Ector(Q7Z.tqM(198208), (IEnumerable<Ordering>)null, CS_0024_003C_003E8__locals5.Jyj, isForLanguage: false);
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		if (CS_0024_003C_003E8__locals5.Jyj == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(11024));
		}
		rID = new WeakEventListener<ParseErrorTagger, EventArgs>(this, delegate(ParseErrorTagger instance, object source, EventArgs eventArgs)
		{
			instance.aIK(source, eventArgs);
		}, delegate(WeakEventListener<ParseErrorTagger, EventArgs> weakEventListener)
		{
			CS_0024_003C_003E8__locals5.Jyj.ParseDataChanged -= weakEventListener.OnEvent;
		});
		CS_0024_003C_003E8__locals5.Jyj.ParseDataChanged += rID.OnEvent;
		XIf();
	}

	private void aIK(object P_0, EventArgs P_1)
	{
		XIf();
	}

	private void XIf()
	{
		using (CreateBatch())
		{
			Clear();
			if (!(base.Document?.ParseData is IParseErrorProvider parseErrorProvider))
			{
				return;
			}
			ITextSnapshot textSnapshot = parseErrorProvider.Snapshot ?? base.Document.CurrentSnapshot;
			if (parseErrorProvider.Errors == null)
			{
				return;
			}
			int num = 0;
			foreach (IParseError error in parseErrorProvider.Errors)
			{
				if (num++ > yIg)
				{
					break;
				}
				if (error.PositionRange.StartPosition.Line >= 0 && error.PositionRange.EndPosition.Line < textSnapshot.Lines.Count)
				{
					int num2 = textSnapshot.PositionToOffset(error.PositionRange.StartPosition);
					int num3 = textSnapshot.PositionToOffset(error.PositionRange.EndPosition);
					if (error.PositionRange.EndPosition.Line < textSnapshot.Lines.Count - 1 && error.PositionRange.EndPosition.Character > textSnapshot.Lines[error.PositionRange.EndPosition.Line].Length)
					{
						num3++;
					}
					TextSnapshotRange textSnapshotRange = new TextSnapshotRange(textSnapshot, num2, num3);
					if (!textSnapshotRange.IsZeroLength || num2 == textSnapshot.Length)
					{
						Add(new TagVersionRange<ISquiggleTag>(textSnapshotRange.ToVersionRange(TextRangeTrackingModes.Default), new SquiggleTag(error.ClassificationType, new PlainTextContentProvider(error.Description))));
					}
				}
			}
		}
	}

	protected override void OnClosed()
	{
		if (rID != null)
		{
			rID.Detach();
			rID = null;
		}
		base.OnClosed();
	}

	internal static bool W5P()
	{
		return y5s == null;
	}

	internal static ParseErrorTagger L5o()
	{
		return y5s;
	}
}
