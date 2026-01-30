using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MimeKit;

public class MimeIterator : IEnumerator<MimeEntity>, IDisposable, IEnumerator
{
	private class MimeNode
	{
		public readonly MimeEntity Entity;

		public readonly bool Indexed;

		public MimeNode(MimeEntity entity, bool indexed)
		{
			Entity = entity;
			Indexed = indexed;
		}
	}

	private readonly Stack<MimeNode> stack = new Stack<MimeNode>();

	private readonly List<int> path = new List<int>();

	private bool moveFirst = true;

	private MimeEntity current;

	private int index = -1;

	public MimeMessage Message { get; private set; }

	public MimeEntity Parent
	{
		get
		{
			if (current == null)
			{
				throw new InvalidOperationException();
			}
			if (stack.Count <= 0)
			{
				return null;
			}
			return stack.Peek().Entity;
		}
	}

	public MimeEntity Current
	{
		get
		{
			if (current == null)
			{
				throw new InvalidOperationException();
			}
			return current;
		}
	}

	object IEnumerator.Current => Current;

	public string PathSpecifier
	{
		get
		{
			if (current == null)
			{
				throw new InvalidOperationException();
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < path.Count; i++)
			{
				stringBuilder.AppendFormat("{0}.", path[i] + 1);
			}
			stringBuilder.AppendFormat("{0}", index + 1);
			return stringBuilder.ToString();
		}
	}

	public int Depth
	{
		get
		{
			if (current == null)
			{
				throw new InvalidOperationException();
			}
			return stack.Count;
		}
	}

	public MimeIterator(MimeMessage message)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		Message = message;
	}

	~MimeIterator()
	{
		Dispose(disposing: false);
	}

	private void Push(MimeEntity entity)
	{
		if (index != -1)
		{
			path.Add(index);
		}
		stack.Push(new MimeNode(entity, index != -1));
	}

	private bool Pop()
	{
		if (stack.Count == 0)
		{
			return false;
		}
		MimeNode mimeNode = stack.Pop();
		if (mimeNode.Indexed)
		{
			index = path[path.Count - 1];
			path.RemoveAt(path.Count - 1);
		}
		current = mimeNode.Entity;
		return true;
	}

	public bool MoveNext()
	{
		if (moveFirst)
		{
			current = Message.Body;
			moveFirst = false;
			return current != null;
		}
		MessagePart messagePart = current as MessagePart;
		Multipart multipart = current as Multipart;
		if (messagePart != null)
		{
			current = ((messagePart.Message != null) ? messagePart.Message.Body : null);
			if (current != null)
			{
				Push(messagePart);
				index = ((current is Multipart) ? (-1) : 0);
				return true;
			}
		}
		if (multipart != null && multipart.Count > 0)
		{
			Push(current);
			current = multipart[0];
			index = 0;
			return true;
		}
		while (stack.Count > 0)
		{
			if (stack.Peek().Entity is Multipart { Count: var count } multipart2 && count > ++index)
			{
				current = multipart2[index];
				return true;
			}
			if (!Pop())
			{
				break;
			}
		}
		current = null;
		index = -1;
		return false;
	}

	private static int[] Parse(string pathSpecifier)
	{
		string[] array = pathSpecifier.Split('.');
		int[] array2 = new int[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			if (!int.TryParse(array[i], out var result) || result < 0)
			{
				throw new FormatException("Invalid path specifier format.");
			}
			array2[i] = result - 1;
		}
		return array2;
	}

	public bool MoveTo(string pathSpecifier)
	{
		if (pathSpecifier == null)
		{
			throw new ArgumentNullException("pathSpecifier");
		}
		if (pathSpecifier.Length == 0)
		{
			throw new ArgumentException("The path specifier cannot be empty.", "pathSpecifier");
		}
		int[] array = Parse(pathSpecifier);
		for (int i = 0; i < Math.Min(array.Length, path.Count); i++)
		{
			if (array[i] < path[i])
			{
				Reset();
				break;
			}
		}
		if (!moveFirst && array.Length < path.Count)
		{
			Reset();
		}
		if (moveFirst && !MoveNext())
		{
			return false;
		}
		do
		{
			if (path.Count + 1 == array.Length)
			{
				int i;
				for (i = 0; i < path.Count && array[i] == path[i]; i++)
				{
				}
				if (i == path.Count && array[i] == index)
				{
					return true;
				}
			}
		}
		while (MoveNext());
		return false;
	}

	public void Reset()
	{
		moveFirst = true;
		current = null;
		stack.Clear();
		path.Clear();
		index = -1;
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
