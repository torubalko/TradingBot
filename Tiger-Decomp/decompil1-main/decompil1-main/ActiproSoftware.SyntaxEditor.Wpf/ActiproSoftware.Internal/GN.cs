using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

namespace ActiproSoftware.Internal;

internal class GN : SimpleObservableCollection<IIntelliPromptSession>, IIntelliPromptSessionCollection, IObservableCollection<IIntelliPromptSession>, IList<IIntelliPromptSession>, ICollection<IIntelliPromptSession>, IEnumerable<IIntelliPromptSession>, IEnumerable
{
	internal static GN uLd;

	public IIntelliPromptSession this[IIntelliPromptSessionType P_0]
	{
		get
		{
			int num = IndexOf(P_0);
			if (num != -1)
			{
				return base[num];
			}
			return null;
		}
	}

	internal void lFU()
	{
		IIntelliPromptSession[] array = new IIntelliPromptSession[base.Count];
		CopyTo(array, 0);
		Array.Reverse(array);
		IIntelliPromptSession[] array2 = array;
		int num = 0;
		if (eLt() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		foreach (IIntelliPromptSession intelliPromptSession in array2)
		{
			intelliPromptSession.Close(cancelled: true);
		}
	}

	internal void FFJ(IIntelliPromptSessionType P_0, IIntelliPromptSession P_1)
	{
		IIntelliPromptSession[] array = new IIntelliPromptSession[base.Count];
		CopyTo(array, 0);
		Array.Reverse(array);
		IIntelliPromptSession[] array2 = array;
		foreach (IIntelliPromptSession intelliPromptSession in array2)
		{
			if (intelliPromptSession != P_1 && intelliPromptSession.SessionType == P_0)
			{
				intelliPromptSession.Close(cancelled: true);
			}
		}
	}

	internal void sFt()
	{
		IIntelliPromptSession[] array = new IIntelliPromptSession[base.Count];
		CopyTo(array, 0);
		IIntelliPromptSession[] array2 = array;
		foreach (IIntelliPromptSession intelliPromptSession in array2)
		{
			intelliPromptSession.Reposition();
		}
		int num = 0;
		if (!pLT())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public bool Contains(IIntelliPromptSessionType P_0)
	{
		return IndexOf(P_0) != -1;
	}

	public int IndexOf(IIntelliPromptSessionType P_0)
	{
		for (int i = 0; i < base.Count; i++)
		{
			if (base[i].SessionType == P_0)
			{
				return i;
			}
		}
		return -1;
	}

	protected override void OnItemAdded(int P_0, IIntelliPromptSession P_1)
	{
		if (P_1 != null && P_1.SessionType != null && !P_1.SessionType.AreMultipleSessionsAllowed)
		{
			FFJ(P_1.SessionType, P_1);
		}
		base.OnItemAdded(P_0, P_1);
	}

	public GN()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	[SpecialName]
	bool ICollection<IIntelliPromptSession>.get_IsReadOnly()
	{
		return IsReadOnly;
	}

	internal static bool pLT()
	{
		return uLd == null;
	}

	internal static GN eLt()
	{
		return uLd;
	}
}
