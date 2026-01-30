using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Parsing.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Ast")]
public abstract class AstNodeBase : IAstNode
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int? i8J;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IAstNode x8X;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int? F8N;

	private static AstNodeBase g12;

	public IList<IAstNode> Children
	{
		get
		{
			using (IEnumerator<IAstNode> enumerator = GetChildrenEnumerator())
			{
				if (enumerator != null)
				{
					List<IAstNode> list = new List<IAstNode>(4);
					while (enumerator.MoveNext())
					{
						list.Add(enumerator.Current);
					}
					return list;
				}
			}
			return new List<IAstNode>();
		}
	}

	public int? EndOffset
	{
		[CompilerGenerated]
		get
		{
			return i8J;
		}
		[CompilerGenerated]
		set
		{
			i8J = value;
		}
	}

	public bool HasChildren
	{
		get
		{
			using (IEnumerator<IAstNode> enumerator = GetChildrenEnumerator())
			{
				if (enumerator != null && enumerator.MoveNext())
				{
					return true;
				}
			}
			return false;
		}
	}

	public virtual int Id => 0;

	public int Length
	{
		get
		{
			int result;
			if (!StartOffset.HasValue || !EndOffset.HasValue)
			{
				result = 0;
				int num = 0;
				if (O1c() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			else
			{
				result = Math.Max(0, EndOffset.Value - StartOffset.Value);
			}
			return result;
		}
	}

	public IAstNode Parent
	{
		[CompilerGenerated]
		get
		{
			return x8X;
		}
		[CompilerGenerated]
		set
		{
			x8X = value;
		}
	}

	public IAstNode Root
	{
		get
		{
			IAstNode astNode = this;
			while (astNode.Parent != null)
			{
				astNode = astNode.Parent;
			}
			return astNode;
		}
	}

	public int? StartOffset
	{
		[CompilerGenerated]
		get
		{
			return F8N;
		}
		[CompilerGenerated]
		set
		{
			F8N = value;
		}
	}

	public virtual string Value
	{
		get
		{
			return GetType().Name;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public bool Contains(int offset)
	{
		if (StartOffset.HasValue && offset >= StartOffset.Value && (!EndOffset.HasValue || offset < EndOffset.Value))
		{
			return true;
		}
		return false;
	}

	public IAstNode FindChildNode(int offset)
	{
		using (IEnumerator<IAstNode> enumerator = GetChildrenEnumerator())
		{
			if (enumerator != null)
			{
				while (enumerator.MoveNext())
				{
					IAstNode current = enumerator.Current;
					if (current != null && current.Contains(offset))
					{
						return current;
					}
				}
			}
		}
		return null;
	}

	public IAstNode FindDescendantNode(int offset)
	{
		IAstNode astNode = FindChildNode(offset);
		if (astNode != null)
		{
			IAstNode astNode2 = astNode.FindDescendantNode(offset);
			IAstNode astNode3 = astNode2;
			if (astNode3 == null)
			{
				int num = 0;
				if (!s1q())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				astNode3 = astNode;
			}
			return astNode3;
		}
		return null;
	}

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	protected virtual IEnumerator<IAstNode> GetChildrenEnumerator()
	{
		return null;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = (HasChildren ? Children.Count : 0);
		if (Value != null)
		{
			if (num == 0)
			{
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5496));
			}
			int num2 = ((num > 0) ? 50 : 30);
			int num3 = Value.IndexOfAny(new char[2] { '\r', '\n' });
			if (num3 == -1 && Value.Length > num2)
			{
				num3 = num2;
			}
			if (num3 != -1)
			{
				stringBuilder.Append(Value.Substring(0, num3));
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5478));
			}
			else
			{
				stringBuilder.Append(Value);
			}
			if (num == 0)
			{
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5496));
			}
		}
		if (num > 0)
		{
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6982));
			stringBuilder.Append(num);
			stringBuilder.Append((num == 1) ? WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7666) : WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7644));
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7014));
		}
		if (StartOffset.HasValue)
		{
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7682));
			stringBuilder.Append(StartOffset.Value);
			if (EndOffset.HasValue)
			{
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7072));
				stringBuilder.Append(EndOffset.Value);
			}
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6120));
		}
		return stringBuilder.ToString();
	}

	public string ToTreeString(int indentLevel)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(new string('\t', indentLevel));
		stringBuilder.Append(Value);
		if (HasChildren)
		{
			stringBuilder.AppendLine(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6982));
			foreach (IAstNode child in Children)
			{
				if (child != null)
				{
					stringBuilder.Append(child.ToTreeString(Math.Min(1000000, indentLevel) + 1));
				}
			}
			stringBuilder.Append(new string('\t', indentLevel));
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7014));
		}
		stringBuilder.Append((!StartOffset.HasValue) ? null : (EndOffset.HasValue ? (WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7682) + StartOffset.Value + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7072) + EndOffset.Value + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6120)) : (WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7682) + StartOffset.Value + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6120))));
		stringBuilder.AppendLine();
		return stringBuilder.ToString();
	}

	protected AstNodeBase()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool s1q()
	{
		return g12 == null;
	}

	internal static AstNodeBase O1c()
	{
		return g12;
	}
}
