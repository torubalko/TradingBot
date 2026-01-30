using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

namespace ActiproSoftware.Internal;

[SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
internal class nK : IIntelliPromptManager
{
	private Jw tF8;

	private GN QFI;

	private SyntaxEditor AF5;

	internal static nK iLf;

	public IIntelliPromptSessionCollection Sessions => QFI;

	internal nK(SyntaxEditor P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8238));
		}
		AF5 = P_0;
		QFI = new GN();
		QFI.ItemAdded += vFL;
		QFI.ItemRemoved += vFL;
	}

	private bool RFb()
	{
		foreach (IIntelliPromptSession item in QFI)
		{
			if (item.ClosesOnLostFocus)
			{
				return true;
			}
		}
		return false;
	}

	private void jFT(object P_0, EventArgs P_1)
	{
		IIntelliPromptSession[] array = QFI.ToArray();
		IIntelliPromptSession[] array2 = array;
		foreach (IIntelliPromptSession intelliPromptSession in array2)
		{
			if (intelliPromptSession.ClosesOnLostFocus && intelliPromptSession.IsOpen)
			{
				intelliPromptSession.Close(cancelled: true);
			}
		}
	}

	private void vFL(object P_0, CollectionChangeEventArgs<IIntelliPromptSession> P_1)
	{
		if (AF5 != null)
		{
			AF5.jGF()?.n6g();
		}
		fFn();
	}

	private void fFn()
	{
		bool flag = RFb();
		if (tF8 != null == flag)
		{
			return;
		}
		int num;
		if (flag && AF5 != null)
		{
			tF8 = new Jw(AF5);
			num = 1;
			if (kL2() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0009;
		}
		goto IL_00a4;
		IL_0009:
		switch (num)
		{
		default:
			return;
		case 0:
			return;
		case 1:
			break;
		}
		tF8.fF4(jFT);
		if (tF8.WFR())
		{
			tF8.PFF();
			return;
		}
		goto IL_00a4;
		IL_00a4:
		if (tF8 == null)
		{
			return;
		}
		tF8.nFo(jFT);
		tF8.Dispose();
		tF8 = null;
		num = 0;
		if (kL2() != null)
		{
			num = 0;
		}
		goto IL_0009;
	}

	public void CloseAllSessions()
	{
		QFI.lFU();
	}

	public void CloseSessions(IIntelliPromptSessionType P_0)
	{
		QFI.FFJ(P_0, null);
	}

	public void RepositionAll()
	{
		QFI.sFt();
	}

	internal static bool uLi()
	{
		return iLf == null;
	}

	internal static nK kL2()
	{
		return iLf;
	}
}
