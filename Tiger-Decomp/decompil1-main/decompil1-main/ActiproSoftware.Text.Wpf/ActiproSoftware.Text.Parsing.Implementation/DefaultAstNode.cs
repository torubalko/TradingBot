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
public class DefaultAstNode : IAstNode
{
	private List<IAstNode> J8R;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int? G8f;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IAstNode I8t;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int? a8Q;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string T8n;

	private static DefaultAstNode e19;

	public IList<IAstNode> Children
	{
		get
		{
			if (J8R == null)
			{
				J8R = new List<IAstNode>();
			}
			return J8R;
		}
	}

	public int? EndOffset
	{
		[CompilerGenerated]
		get
		{
			return G8f;
		}
		[CompilerGenerated]
		set
		{
			G8f = value;
		}
	}

	public bool HasChildren => J8R != null && J8R.Count > 0;

	public virtual int Id => 0;

	public int Length
	{
		get
		{
			if (StartOffset.HasValue && EndOffset.HasValue)
			{
				return Math.Max(0, EndOffset.Value - StartOffset.Value);
			}
			return 0;
		}
	}

	public IAstNode Parent
	{
		[CompilerGenerated]
		get
		{
			return I8t;
		}
		[CompilerGenerated]
		set
		{
			I8t = value;
		}
	}

	public int? StartOffset
	{
		[CompilerGenerated]
		get
		{
			return a8Q;
		}
		[CompilerGenerated]
		set
		{
			a8Q = value;
		}
	}

	public string Value
	{
		[CompilerGenerated]
		get
		{
			return T8n;
		}
		[CompilerGenerated]
		set
		{
			T8n = value;
		}
	}

	public bool Contains(int offset)
	{
		if (StartOffset.HasValue && offset >= StartOffset.Value)
		{
			if (EndOffset.HasValue)
			{
				int num = 0;
				if (U1L() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (offset >= EndOffset.Value)
				{
					goto IL_0054;
				}
			}
			return true;
		}
		goto IL_0054;
		IL_0054:
		return false;
	}

	public IAstNode FindChildNode(int offset)
	{
		if (J8R != null)
		{
			foreach (IAstNode item in J8R)
			{
				if (item != null && item.Contains(offset))
				{
					return item;
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
			return astNode2 ?? astNode;
		}
		return null;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = ((J8R != null) ? J8R.Count : 0);
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
		if (HasChildren)
		{
			stringBuilder.Append(Value);
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
		else
		{
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5496));
			stringBuilder.Append(Value);
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5496));
		}
		stringBuilder.AppendLine();
		return stringBuilder.ToString();
	}

	public DefaultAstNode()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool e18()
	{
		return e19 == null;
	}

	internal static DefaultAstNode U1L()
	{
		return e19;
	}
}
