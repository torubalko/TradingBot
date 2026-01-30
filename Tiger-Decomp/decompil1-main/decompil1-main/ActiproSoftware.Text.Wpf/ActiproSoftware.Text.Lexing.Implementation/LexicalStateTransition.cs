using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

public class LexicalStateTransition : ILexicalStateTransition
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ISyntaxLanguage vmB;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ILexicalScope jm9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ILexicalState VmA;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ILexicalScope Smu;

	internal static LexicalStateTransition QPv;

	public ISyntaxLanguage ChildLanguage
	{
		[CompilerGenerated]
		get
		{
			return vmB;
		}
		[CompilerGenerated]
		private set
		{
			vmB = value;
		}
	}

	public ILexicalScope ChildLexicalScope
	{
		[CompilerGenerated]
		get
		{
			return jm9;
		}
		[CompilerGenerated]
		private set
		{
			jm9 = value;
		}
	}

	public ILexicalState ChildLexicalState
	{
		[CompilerGenerated]
		get
		{
			return VmA;
		}
		[CompilerGenerated]
		private set
		{
			VmA = value;
		}
	}

	public ILexicalScope ParentLexicalScope
	{
		[CompilerGenerated]
		get
		{
			return Smu;
		}
		[CompilerGenerated]
		internal set
		{
			Smu = value;
		}
	}

	public LexicalStateTransition(ISyntaxLanguage childLanguage, ILexicalState childLexicalState, LexicalScopeBase childLexicalScope)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (childLanguage == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8266));
		}
		if (childLexicalState == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8296));
		}
		ChildLanguage = childLanguage;
		ChildLexicalState = childLexicalState;
		ChildLexicalScope = childLexicalScope;
		if (childLexicalScope != null)
		{
			int num = 0;
			if (false)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			}
			childLexicalScope.ParentTransitionCore = this;
		}
	}

	internal static bool WPY()
	{
		return QPv == null;
	}

	internal static LexicalStateTransition kPe()
	{
		return QPv;
	}
}
