using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Indicators;

namespace ActiproSoftware.Internal;

internal class VTn<VTY, wTo> : ISingleTextRangeIndicatorManager<VTY, wTo> where VTY : class, ICollectionTagger<wTo> where wTo : IIndicatorTag, new()
{
	private IIndicatorManager IR1;

	internal static object iA0;

	public TagVersionRange<wTo> this[wTo XTl] => IR1.GetInstance<VTY, wTo>(XTl);

	public VTn(IIndicatorManager P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192868));
		}
		IR1 = P_0;
	}

	[SpecialName]
	internal IIndicatorManager vRC()
	{
		return IR1;
	}

	public void Clear()
	{
		IR1.Clear<VTY, wTo>();
	}

	public TagVersionRange<wTo> GetInstance()
	{
		using (IEnumerator<TagVersionRange<wTo>> enumerator = IR1.GetInstances<VTY, wTo>().GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				return enumerator.Current;
			}
		}
		return null;
	}

	public TagVersionRange<wTo> SetInstance(TextSnapshotRange P_0)
	{
		return SetInstance(P_0, new wTo());
	}

	public TagVersionRange<wTo> SetInstance(TextSnapshotRange P_0, wTo GTy)
	{
		Clear();
		return IR1.Add<VTY, wTo>(P_0, GTy);
	}

	internal static bool rA7()
	{
		return iA0 == null;
	}

	internal static object SAn()
	{
		return iA0;
	}
}
