using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace isnQObHkoBLhLETXDS3X;

public class LOaTZ5HkYs6IUi82qZ8y<RiYytAliLCeoS09UWCP8> : ObservableCollection<RiYytAliLCeoS09UWCP8>
{
	[CompilerGenerated]
	private int dG9Hk4i13RH;

	private bool M8THkDkoX8y;

	private static object sOp8UoDSw5Lv0aTU43hx;

	public int Capacity
	{
		[CompilerGenerated]
		get
		{
			return dG9Hk4i13RH;
		}
		[CompilerGenerated]
		set
		{
			dG9Hk4i13RH = num;
		}
	}

	public void X9ZHkvvG9Ps(IEnumerable<RiYytAliLCeoS09UWCP8> P_0)
	{
		M8THkDkoX8y = true;
		foreach (RiYytAliLCeoS09UWCP8 item in P_0)
		{
			Add(item);
		}
		M8THkDkoX8y = false;
		OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
	}

	protected override void InsertItem(int P_0, RiYytAliLCeoS09UWCP8 DGh2oQlieMdnUBfQfi6Y)
	{
		if (Capacity != 0 && base.Count >= Capacity)
		{
			RemoveAt(0);
			P_0--;
		}
		base.InsertItem(P_0, DGh2oQlieMdnUBfQfi6Y);
	}

	public void rf8HkBEyiZ3()
	{
		M8THkDkoX8y = true;
	}

	public void qnkHka9KJbR()
	{
		M8THkDkoX8y = false;
		OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
	}

	protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs P_0)
	{
		if (!M8THkDkoX8y)
		{
			base.OnCollectionChanged(P_0);
		}
	}

	public LOaTZ5HkYs6IUi82qZ8y()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static LOaTZ5HkYs6IUi82qZ8y()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool Cu1kAHDS7WTaOPbNchRA()
	{
		return sOp8UoDSw5Lv0aTU43hx == null;
	}

	internal static object mBEfHuDS8XUZCNqFSV6K()
	{
		return sOp8UoDSw5Lv0aTU43hx;
	}
}
