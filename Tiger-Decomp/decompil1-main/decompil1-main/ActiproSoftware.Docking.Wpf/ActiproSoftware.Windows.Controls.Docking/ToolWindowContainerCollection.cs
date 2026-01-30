using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking;

public class ToolWindowContainerCollection : DeferrableObservableCollection<ToolWindowContainer>
{
	private static ToolWindowContainerCollection jE;

	internal void G2T(ToolWindowContainerCollection P_0)
	{
		if (P_0 != null)
		{
			for (int num = base.Count - 1; num >= 0; num--)
			{
				RemoveAt(num);
			}
			AddRange(P_0);
			for (int num2 = P_0.Count - 1; num2 >= 0; num2--)
			{
				P_0.RemoveAt(num2);
			}
		}
	}

	public ToolWindowContainerCollection()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool Ck()
	{
		return jE == null;
	}

	internal static ToolWindowContainerCollection Nq()
	{
		return jE;
	}
}
