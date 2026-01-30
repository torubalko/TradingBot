using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Windows.Markup;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

[ContentProperty("Children")]
public abstract class DataModelBase : ObservableObjectBase, IDataModel, IDisposable
{
	private DataModelCollection nnG;

	private bool tnu;

	private bool BnO;

	private bool znw;

	private DataModelSortComparer anX;

	private object xn2;

	private WeakReference vnv;

	internal static DataModelBase J6B;

	string IDataModel.Description => DescriptionResolved;

	string IDataModel.DisplayName => DisplayNameResolved;

	bool IDataModel.IsInitialized
	{
		get
		{
			return IsInitialized;
		}
		set
		{
			IsInitialized = value;
		}
	}

	bool IDataModel.IsModified => IsModifiedResolved;

	string IDataModel.Name => NameResolved;

	IDataModel IDataModel.Parent
	{
		get
		{
			return Parent;
		}
		set
		{
			if (Parent != value)
			{
				Parent = value;
				if (value == null && CanAutoDispose)
				{
					Dispose(disposing: true);
				}
			}
		}
	}

	DataModelSortImportance IDataModel.SortImportance => SortImportanceResolved;

	int IDataModel.SortOrder => SortOrderResolved;

	private bool IsInitialized
	{
		get
		{
			return BnO;
		}
		set
		{
			if (BnO != value)
			{
				BnO = value;
				NotifyPropertyChanged(xv.hTz(8870));
			}
		}
	}

	public virtual bool CanAutoDispose => true;

	public DataModelCollection Children
	{
		get
		{
			if (nnG == null)
			{
				nnG = new DataModelCollection();
				nnG.CollectionChanged += knB;
			}
			return nnG;
		}
	}

	protected abstract string DescriptionResolved { get; }

	protected abstract string DisplayNameResolved { get; }

	public bool IsExpanded
	{
		get
		{
			return tnu;
		}
		set
		{
			if (tnu != value)
			{
				tnu = value;
				NotifyPropertyChanged(xv.hTz(3132));
			}
		}
	}

	protected abstract bool IsModifiedResolved { get; }

	public virtual bool IsRoot => false;

	public bool IsSelected
	{
		get
		{
			return znw;
		}
		set
		{
			if (znw != value)
			{
				znw = value;
				NotifyPropertyChanged(xv.hTz(3156));
			}
		}
	}

	protected abstract string NameResolved { get; }

	public IDataModel Parent
	{
		get
		{
			if (vnv != null)
			{
				if (vnv.IsAlive)
				{
					return vnv.Target as IDataModel;
				}
				vnv = null;
			}
			return null;
		}
		private set
		{
			if (Parent != value)
			{
				vnv = ((value != null) ? new WeakReference(value) : null);
			}
		}
	}

	public DataModelSortComparer SortComparer
	{
		get
		{
			return anX;
		}
		set
		{
			if (anX != value)
			{
				anX = value;
				NotifyPropertyChanged(xv.hTz(1272));
				InR();
			}
		}
	}

	protected abstract DataModelSortImportance SortImportanceResolved { get; }

	protected abstract int SortOrderResolved { get; }

	public object Tag
	{
		get
		{
			return xn2;
		}
		set
		{
			if (xn2 != value)
			{
				xn2 = value;
				NotifyPropertyChanged(xv.hTz(8900));
			}
		}
	}

	~DataModelBase()
	{
		Dispose(disposing: false);
	}

	private void knB(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		if (P_1 == null)
		{
			return;
		}
		IList oldItems = P_1.OldItems;
		if (oldItems != null)
		{
			foreach (object item in oldItems)
			{
				if (item is IDataModel dataModel && dataModel.Parent == this)
				{
					dataModel.Parent = null;
				}
			}
		}
		IList newItems = P_1.NewItems;
		int num = 0;
		if (j64() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (newItems == null)
		{
			return;
		}
		foreach (object item2 in newItems)
		{
			if (item2 is IDataModel dataModel2)
			{
				dataModel2.Parent = this;
			}
		}
	}

	private void InR()
	{
		if (anX == null || nnG == null || nnG.Count <= 0)
		{
			return;
		}
		int num = 0;
		if (!f6t())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		List<IDataModel> list = new List<IDataModel>(nnG);
		list.Sort(anX);
		for (int num3 = nnG.Count - 1; num3 >= 0; num3--)
		{
			IDataModel dataModel = list[num3];
			IDataModel dataModel2 = nnG[num3];
			if (dataModel != dataModel2)
			{
				int num4 = nnG.IndexOf(dataModel);
				if (num4 != -1)
				{
					nnG.Move(num4, num3);
				}
			}
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			this.Xn8();
		}
	}

	protected virtual void RefreshChildren()
	{
		IsInitialized = false;
		this.zn3()?.gEP(this);
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.InvariantCulture, xv.hTz(8910), new object[2]
		{
			GetType().Name,
			NameResolved
		});
	}

	protected DataModelBase()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool f6t()
	{
		return J6B == null;
	}

	internal static DataModelBase j64()
	{
		return J6B;
	}
}
