using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using cY9HKMfP6DC0C8LIwE00;
using ECOEgqlSad8NUJZ2Dr9n;
using NHkZqbf77HnCtq0ER8ta;
using TigerTrade.Annotations;
using TuAMtrl1Nd3XoZQQUXf0;

namespace UQo6BdfP2mN8TGiUMEQT;

[DataContract(Name = "PriceLevelsList", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Market.Common")]
internal sealed class YiXl9IfP06OkWU6fDkUP : INotifyPropertyChanged
{
	[Serializable]
	[CompilerGenerated]
	private sealed class gfJVkJnJX5BGmtYCaem3
	{
		public static readonly gfJVkJnJX5BGmtYCaem3 cLrnJjdYa5V;

		public static Predicate<BpmEftf7wYbuVebk5Vku> GbLnJEXQk0R;

		private static gfJVkJnJX5BGmtYCaem3 PPbpTiNOjBviJyqENNgV;

		static gfJVkJnJX5BGmtYCaem3()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			eMo5n4NOdtvc0v6YQNeR();
			cLrnJjdYa5V = new gfJVkJnJX5BGmtYCaem3();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public gfJVkJnJX5BGmtYCaem3()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool CfYnJcKQcWf(BpmEftf7wYbuVebk5Vku lvl)
		{
			if (lvl is tQdY3yfPR6B0dxodinwZ tQdY3yfPR6B0dxodinwZ)
			{
				return tQdY3yfPR6B0dxodinwZ.YNJfPtJgce2;
			}
			return true;
		}

		internal static void eMo5n4NOdtvc0v6YQNeR()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool k8CR9pNOEqCBqJRNksK4()
		{
			return PPbpTiNOjBviJyqENNgV == null;
		}

		internal static gfJVkJnJX5BGmtYCaem3 AoyXQiNOQiSZSfQxZZPZ()
		{
			return PPbpTiNOjBviJyqENNgV;
		}
	}

	private Dictionary<string, List<BpmEftf7wYbuVebk5Vku>> NqUfPvy7wRC;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static YiXl9IfP06OkWU6fDkUP VaTXexbiiDAPSUtsx6IN;

	[DataMember(Name = "Levels")]
	public Dictionary<string, List<BpmEftf7wYbuVebk5Vku>> Levels
	{
		get
		{
			return NqUfPvy7wRC ?? (NqUfPvy7wRC = new Dictionary<string, List<BpmEftf7wYbuVebk5Vku>>());
		}
		set
		{
			if (!object.Equals(dictionary, NqUfPvy7wRC))
			{
				NqUfPvy7wRC = dictionary;
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			int num = 2;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
				{
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					goto case 1;
				}
				case 1:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
					{
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 != 0)
						{
							num = 0;
						}
						continue;
					}
					case 1:
						break;
					}
					break;
				}
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public List<BpmEftf7wYbuVebk5Vku> IDQfPHZll5G(string P_0)
	{
		if (Levels.ContainsKey(P_0))
		{
			return Levels[P_0].ToList();
		}
		return new List<BpmEftf7wYbuVebk5Vku>();
	}

	public void Ia0fPf3Ad95(string P_0, List<BpmEftf7wYbuVebk5Vku> P_1)
	{
		if (!Levels.ContainsKey(P_0))
		{
			Levels.Add(P_0, new List<BpmEftf7wYbuVebk5Vku>());
		}
		if (!BpmEftf7wYbuVebk5Vku.bYof7AHatOb(Levels[P_0], P_1))
		{
			Levels[P_0] = P_1;
			Mh1fPGJW8fE(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-342738082 ^ -342735410));
		}
	}

	public void yalfP9nMZxk(string P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
			{
				if (!Levels.TryGetValue(P_0, out var value))
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
					{
						num2 = 0;
					}
					break;
				}
				value.RemoveAll((BpmEftf7wYbuVebk5Vku lvl) => !(lvl is tQdY3yfPR6B0dxodinwZ tQdY3yfPR6B0dxodinwZ) || tQdY3yfPR6B0dxodinwZ.YNJfPtJgce2);
				Mh1fPGJW8fE(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7ADBF691 ^ 0x7ADB8801));
				return;
			}
			case 0:
				return;
			}
		}
	}

	public void vhafPnugja4(YiXl9IfP06OkWU6fDkUP P_0)
	{
		Levels.Clear();
		Dictionary<string, List<BpmEftf7wYbuVebk5Vku>>.Enumerator enumerator = P_0.Levels.GetEnumerator();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			try
			{
				KeyValuePair<string, List<BpmEftf7wYbuVebk5Vku>> current = default(KeyValuePair<string, List<BpmEftf7wYbuVebk5Vku>>);
				List<BpmEftf7wYbuVebk5Vku> list = default(List<BpmEftf7wYbuVebk5Vku>);
				while (true)
				{
					int num2;
					if (!enumerator.MoveNext())
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						current = enumerator.Current;
						int num3 = 2;
						num2 = num3;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							return;
						case 2:
							list = new List<BpmEftf7wYbuVebk5Vku>();
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					}
					Levels.Add(current.Key, list);
					foreach (BpmEftf7wYbuVebk5Vku item in current.Value)
					{
						list.Add((BpmEftf7wYbuVebk5Vku)item.Clone());
					}
				}
			}
			finally
			{
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
			}
		}
	}

	[NotifyPropertyChangedInvocator]
	private void Mh1fPGJW8fE([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	public YiXl9IfP06OkWU6fDkUP()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static YiXl9IfP06OkWU6fDkUP()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool NpLcnrbilSng1yo0UQBA()
	{
		return VaTXexbiiDAPSUtsx6IN == null;
	}

	internal static YiXl9IfP06OkWU6fDkUP lQBDrcbi4IvRUDjvZG5O()
	{
		return VaTXexbiiDAPSUtsx6IN;
	}
}
