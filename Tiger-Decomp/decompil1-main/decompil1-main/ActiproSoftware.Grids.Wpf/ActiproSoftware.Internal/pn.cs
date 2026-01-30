using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Grids;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;

namespace ActiproSoftware.Internal;

internal class pn : PropertyModel, IRootModel, IPropertyModel, IDataModel, IDisposable
{
	private object[] qEp;

	private WeakReference SEE;

	internal static pn fFn;

	protected override bool IsRoot => true;

	public object Source => wEW();

	public override IList<object> Values => qEp;

	public pn(PropertyGrid P_0, object[] P_1)
	{
		fc.taYSkz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(xv.hTz(9584));
		}
		SEE = new WeakReference(P_0);
		qEp = P_1;
		base.Name = xv.hTz(9604);
		wpd(P_1?.FirstOrDefault());
		FE5();
	}

	[SpecialName]
	internal PropertyGrid wEW()
	{
		if (SEE != null)
		{
			if (SEE.IsAlive)
			{
				return SEE.Target as PropertyGrid;
			}
			SEE = null;
		}
		return null;
	}

	internal void gEP(IDataModel P_0)
	{
		if (P_0 != null)
		{
			PropertyGrid propertyGrid = wEW();
			if (propertyGrid != null)
			{
				PropertyGridItemAdapter.VPk(propertyGrid, P_0);
			}
		}
	}

	internal void sE1(PropertyModelChildChangeEventArgs P_0)
	{
		if (P_0 != null)
		{
			wEW()?.Ik(P_0);
		}
	}

	internal void AEt(PropertyModelChildChangeEventArgs P_0)
	{
		if (P_0 != null)
		{
			wEW()?.PQ(P_0);
		}
	}

	internal void PEU(PropertyModelChildChangeEventArgs P_0)
	{
		if (P_0 != null)
		{
			wEW()?.Ny(P_0);
		}
	}

	internal void pE6(PropertyModelChildChangeEventArgs P_0)
	{
		if (P_0 != null)
		{
			wEW()?.ad(P_0);
		}
	}

	internal void CEq(PropertyModelValueChangeEventArgs P_0)
	{
		if (P_0 != null)
		{
			wEW()?.zB(P_0);
		}
	}

	internal void sEJ(PropertyModelValueChangeEventArgs P_0)
	{
		if (P_0 != null)
		{
			wEW()?.DR(P_0);
		}
	}

	private void FE5()
	{
		bool isImmutable = false;
		if (qEp != null)
		{
			object[] array = qEp;
			int i = 0;
			int num = 0;
			if (FF2() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			for (; i < array.Length; i++)
			{
				object obj = array[i];
				if (obj != null)
				{
					ImmutableObjectAttribute immutableObjectAttribute = TypeDescriptor.GetAttributes(obj).OfType<ImmutableObjectAttribute>().FirstOrDefault();
					if (immutableObjectAttribute != null && immutableObjectAttribute.Immutable)
					{
						isImmutable = true;
						break;
					}
				}
			}
		}
		base.IsImmutable = isImmutable;
	}

	protected override void Dispose(bool P_0)
	{
		if (P_0)
		{
			SEE = null;
		}
		base.Dispose(P_0);
	}

	[SpecialName]
	object IDataModel.get_Tag()
	{
		return base.Tag;
	}

	[SpecialName]
	void IDataModel.set_Tag(object P_0)
	{
		base.Tag = P_0;
	}

	internal static bool zFw()
	{
		return fFn == null;
	}

	internal static pn FF2()
	{
		return fFn;
	}
}
