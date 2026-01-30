using System;
using System.Collections.Generic;

namespace MimeKit.Text;

internal class Trie
{
	private class TrieState
	{
		public TrieState Next;

		public TrieState Fail;

		public TrieMatch Match;

		public string Pattern;

		public int Depth;

		public TrieState(TrieState fail)
		{
			Fail = fail;
		}
	}

	private class TrieMatch
	{
		public TrieMatch Next;

		public TrieState State;

		public char Value { get; private set; }

		public TrieMatch(char value)
		{
			Value = value;
		}
	}

	private List<TrieState> failStates;

	private TrieState root;

	private bool icase;

	public Trie(bool ignoreCase)
	{
		failStates = new List<TrieState>();
		root = new TrieState(null);
		icase = ignoreCase;
	}

	public Trie()
		: this(ignoreCase: false)
	{
	}

	private static void ValidateArguments(char[] text, int startIndex, int count)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		if (startIndex < 0 || startIndex > text.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || count > text.Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
	}

	private static TrieMatch FindMatch(TrieState state, char value)
	{
		TrieMatch trieMatch = state.Match;
		while (trieMatch != null && trieMatch.Value != value)
		{
			trieMatch = trieMatch.Next;
		}
		return trieMatch;
	}

	private TrieState Insert(TrieState state, int depth, char value)
	{
		TrieState trieState = new TrieState(root);
		TrieMatch trieMatch = new TrieMatch(value);
		trieMatch.Next = state.Match;
		trieMatch.State = trieState;
		state.Match = trieMatch;
		if (failStates.Count < depth + 1)
		{
			failStates.Add(null);
		}
		trieState.Next = failStates[depth];
		failStates[depth] = trieState;
		return trieState;
	}

	public void Add(string pattern)
	{
		TrieState trieState = root;
		int num = 0;
		if (pattern == null)
		{
			throw new ArgumentNullException("pattern");
		}
		if (pattern.Length == 0)
		{
			throw new ArgumentException("The pattern cannot be empty.", "pattern");
		}
		for (int i = 0; i < pattern.Length; i++)
		{
			char value = (icase ? char.ToLower(pattern[i]) : pattern[i]);
			TrieMatch trieMatch = FindMatch(trieState, value);
			trieState = ((trieMatch != null) ? trieMatch.State : Insert(trieState, num, value));
			num++;
		}
		trieState.Pattern = pattern;
		trieState.Depth = num;
		for (int j = 0; j < failStates.Count; j++)
		{
			for (trieState = failStates[j]; trieState != null; trieState = trieState.Next)
			{
				for (TrieMatch trieMatch = trieState.Match; trieMatch != null; trieMatch = trieMatch.Next)
				{
					TrieState state = trieMatch.State;
					TrieState fail = trieState.Fail;
					TrieMatch trieMatch2 = null;
					char value = trieMatch.Value;
					while (fail != null && (trieMatch2 = FindMatch(fail, value)) == null)
					{
						fail = fail.Fail;
					}
					if (fail != null)
					{
						state.Fail = trieMatch2.State;
						if (state.Fail.Depth > state.Depth)
						{
							state.Depth = state.Fail.Depth;
						}
					}
					else if ((trieMatch2 = FindMatch(root, value)) != null)
					{
						state.Fail = trieMatch2.State;
					}
					else
					{
						state.Fail = root;
					}
				}
			}
		}
	}

	public int Search(char[] text, int startIndex, int count, out string pattern)
	{
		ValidateArguments(text, startIndex, count);
		int num = Math.Min(text.Length, startIndex + count);
		TrieState trieState = root;
		TrieMatch trieMatch = null;
		int num2 = 0;
		int result = -1;
		pattern = null;
		for (int i = startIndex; i < num; i++)
		{
			char value = (icase ? char.ToLower(text[i]) : text[i]);
			while (trieState != null && (trieMatch = FindMatch(trieState, value)) == null && num2 == 0)
			{
				trieState = trieState.Fail;
			}
			if (trieState == root)
			{
				if (num2 > 0)
				{
					return result;
				}
				result = i;
			}
			if (trieState == null)
			{
				if (num2 > 0)
				{
					return result;
				}
				trieState = root;
				result = i;
			}
			else if (trieMatch != null)
			{
				trieState = trieMatch.State;
				if (trieState.Depth > num2)
				{
					pattern = trieState.Pattern;
					num2 = trieState.Depth;
				}
			}
			else if (num2 > 0)
			{
				return result;
			}
		}
		if (num2 <= 0)
		{
			return -1;
		}
		return result;
	}

	public int Search(char[] text, int startIndex, out string pattern)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		return Search(text, startIndex, text.Length - startIndex, out pattern);
	}

	public int Search(char[] text, out string pattern)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		return Search(text, 0, text.Length, out pattern);
	}
}
