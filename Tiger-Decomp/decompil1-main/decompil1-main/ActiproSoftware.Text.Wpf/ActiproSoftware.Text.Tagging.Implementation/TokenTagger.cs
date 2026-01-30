using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text.Lexing;
using ActiproSoftware.Text.Lexing.Implementation;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Tagging.Implementation;

[SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tagger")]
public class TokenTagger : TaggerBase<ITokenTag>, ITagger<IClassificationTag>, IOrderable, IKeyedObject
{
	private LexerContextProvider aA9;

	internal static TokenTagger MAR;

	public TokenTagger(ICodeDocument document)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5868), (IEnumerable<Ordering>)null, document, isForLanguage: true);
		aA9 = new LexerContextProvider(document);
	}

	IEnumerable<TagSnapshotRange<IClassificationTag>> ITagger<IClassificationTag>.GetTags(NormalizedTextSnapshotRangeCollection snapshotRanges, object parameter)
	{
		IEnumerable<TagSnapshotRange<ITokenTag>> tagRanges = GetTags(snapshotRanges, parameter);
		if (tagRanges == null)
		{
			yield break;
		}
		foreach (TagSnapshotRange<ITokenTag> tagRange in tagRanges)
		{
			IClassificationTag tag = tagRange.Tag as IClassificationTag;
			if (tag != null && tag.ClassificationType != null)
			{
				yield return new TagSnapshotRange<IClassificationTag>(tagRange.SnapshotRange, tag);
			}
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "lexer")]
	[SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "3#")]
	internal ITokenSet GetTokensInternal(ILexer lexer, TextSnapshotRange desiredSnapshotRange, object parseContext, out int invalidateThroughOffset)
	{
		return GetTokens(lexer, desiredSnapshotRange, parseContext, canUpdateLineContexts: false, out invalidateThroughOffset);
	}

	public virtual IClassificationType ClassifyToken(IToken token)
	{
		return (token is IMergableToken mergableToken) ? mergableToken.ClassificationType : null;
	}

	protected override void OnClosed()
	{
		base.OnClosed();
		if (aA9 != null)
		{
			aA9.Dispose();
			aA9 = null;
		}
	}

	public override IEnumerable<TagSnapshotRange<ITokenTag>> GetTags(NormalizedTextSnapshotRangeCollection snapshotRanges, object parameter)
	{
		if (snapshotRanges == null || snapshotRanges.Count == 0 || aA9 == null || base.Document == null)
		{
			yield break;
		}
		ISyntaxLanguage language = base.Document.Language;
		ILexer lexer = null;
		if (language != null)
		{
			lexer = language.GetService<ILexer>();
		}
		if (lexer == null)
		{
			yield break;
		}
		bool isFromUI = parameter is TextSnapshotRange;
		int maxInvalidateThroughOffset = snapshotRanges[0].StartOffset;
		foreach (TextSnapshotRange snapshotRange in snapshotRanges)
		{
			if (snapshotRange.IsDeleted || snapshotRange.IsZeroLength)
			{
				continue;
			}
			int invalidateThroughOffset;
			ITokenSet tokenSet = GetTokens(lexer, snapshotRange, parameter, isFromUI, out invalidateThroughOffset);
			maxInvalidateThroughOffset = Math.Max(maxInvalidateThroughOffset, invalidateThroughOffset);
			if (tokenSet == null)
			{
				continue;
			}
			ITextSnapshot snapshot = snapshotRange.Snapshot;
			foreach (IToken token in tokenSet)
			{
				yield return new TagSnapshotRange<ITokenTag>(tag: new TokenClassificationTag(token, ClassifyToken(token)), snapshotRange: new TextSnapshotRange(snapshot, token.TextRange));
			}
		}
		if (isFromUI && base.Document != null && snapshotRanges[0].Snapshot == base.Document.CurrentSnapshot)
		{
			int invalidateThroughOffset = Math.Max(isFromUI ? (((TextSnapshotRange)parameter).EndOffset + 1) : 0, snapshotRanges[snapshotRanges.Count - 1].EndOffset + 1);
			if (maxInvalidateThroughOffset > invalidateThroughOffset)
			{
				TextSnapshotRange changedSnapshotRange = new TextSnapshotRange(snapshotRanges[0].Snapshot, new TextRange(invalidateThroughOffset, maxInvalidateThroughOffset));
				RaiseTagsChanged(new TagsChangedEventArgs(changedSnapshotRange));
			}
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "lexer")]
	[SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "3#")]
	[SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "4#")]
	protected ITokenSet GetTokens(ILexer lexer, TextSnapshotRange desiredSnapshotRange, object parseContext, bool canUpdateLineContexts, out int invalidateThroughOffset)
	{
		invalidateThroughOffset = 0;
		if (aA9 == null)
		{
			return null;
		}
		return aA9.GetTokens(lexer, desiredSnapshotRange, parseContext, canUpdateLineContexts, out invalidateThroughOffset);
	}

	[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
	public void RaiseTagsChanged(TagsChangedEventArgs e)
	{
		OnTagsChanged(e);
	}

	internal static bool MA0()
	{
		return MAR == null;
	}

	internal static TokenTagger BAN()
	{
		return MAR;
	}
}
