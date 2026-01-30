using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace ksQPwTiw35RnECmeKarT;

public abstract class L34dcYiwF8r2NgF7JX2P : INotifyPropertyChanged, IDataErrorInfo
{
	private IDictionary<string, Func<string>> aGVi7fN03TP;

	private bool HYbi79pvYtC;

	private bool zQ7i7n7oWMP;

	protected string GLli7GKDRx6;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static L34dcYiwF8r2NgF7JX2P nlHRLkX96sigBaUNIANK;

	public string Error => null;

	public string this[string P_0]
	{
		get
		{
			if (HYbi79pvYtC)
			{
				goto IL_005e;
			}
			string result = string.Empty;
			int num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_a863574b23b747caa2b08ae3edec8640 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 2:
				goto IL_005e;
			}
			goto IL_0030;
			IL_005e:
			result = dJsiwp18yTy(P_0);
			goto IL_0030;
			IL_0030:
			return result;
		}
	}

	public bool HasValidationErrors => zQ7i7n7oWMP;

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			int num = 1;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 1:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_aaee87d70b4c49aab4b237d8e1fb4ee6 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				}
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
				num2 = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_d8e6a87b8dc84e42a96070ff5524267e != 0)
				{
					num2 = 2;
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
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_13cf2cd6b38241bbaa1a8ec9e9113aad != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						break;
					default:
					{
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
						num = 0;
						if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_22f1d8a6a91b4fb198e1e1bbe4572bc0 != 0)
						{
							num = 1;
						}
						continue;
					}
					}
					break;
				}
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	private string dJsiwp18yTy(string P_0)
	{
		string text = default(string);
		int num;
		if (aGVi7fN03TP.TryGetValue(P_0, out var value))
		{
			text = value();
			num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_22f1d8a6a91b4fb198e1e1bbe4572bc0 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_004d;
		IL_0005:
		int num2;
		num = num2;
		goto IL_0009;
		IL_00c8:
		if (!string.IsNullOrEmpty(text))
		{
			zQ7i7n7oWMP = true;
		}
		string result = text;
		num2 = 3;
		goto IL_0005;
		IL_0009:
		switch (num)
		{
		case 1:
			break;
		case 2:
		case 3:
			return result;
		default:
			goto IL_00c8;
		}
		goto IL_004d;
		IL_004d:
		result = string.Empty;
		num2 = 2;
		goto IL_0005;
	}

	public bool m36iwuacAQh()
	{
		zQ7i7n7oWMP = false;
		try
		{
			using (IEnumerator<string> enumerator = aGVi7fN03TP.Keys.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					while (true)
					{
						string current = enumerator.Current;
						bool flag = !VZ7F9hX9qolE92x4V2HH(dJsiwp18yTy(current));
						int num = 0;
						if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5e0114e6421d4bf1bbeb31361714f3af == 0)
						{
							num = 0;
						}
						while (true)
						{
							switch (num)
							{
							case 1:
								break;
							default:
								goto IL_00d0;
							case 2:
								goto end_IL_0095;
							}
							break;
							IL_00d0:
							if (flag)
							{
								return false;
							}
							num = 2;
						}
						continue;
						end_IL_0095:
						break;
					}
				}
			}
			return true;
		}
		finally
		{
			ifWlfmRSlkr(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-1309555870 ^ -1309555940));
		}
	}

	protected void XiIiwzjTvfE()
	{
		aGVi7fN03TP.Clear();
	}

	protected void zQWi70AxQTn(string P_0, Func<string> P_1)
	{
		aGVi7fN03TP.Add(P_0, P_1);
	}

	public bool IsValid()
	{
		int num = 2;
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					goto end_IL_0012;
				case 2:
					zQ7i7n7oWMP = false;
					num2 = 1;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_936331747ae74ee19c9bb932c2cd39d1 != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					try
					{
						while (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							ifWlfmRSlkr(current);
						}
					}
					finally
					{
						if (enumerator != null)
						{
							i15DgZX9IWS2Ug55Eeju(enumerator);
						}
					}
					break;
				}
				HYbi79pvYtC = false;
				ifWlfmRSlkr(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x37B74BDF ^ 0x37B74BA1));
				return !zQ7i7n7oWMP;
				continue;
				end_IL_0012:
				break;
			}
			HYbi79pvYtC = true;
			enumerator = aGVi7fN03TP.Keys.GetEnumerator();
			num = 3;
		}
	}

	public void L1di72wQ4Kb()
	{
		IsValid();
	}

	protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
	{
		if (string.IsNullOrEmpty(propertyName))
		{
			throw new ArgumentException(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-53782092 ^ -53782244), OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x42D899B5 ^ 0x42D898BB));
		}
		if (EqualityComparer<T>.Default.Equals(field, value))
		{
			return false;
		}
		field = value;
		ifWlfmRSlkr(propertyName);
		return true;
	}

	protected virtual void ifWlfmRSlkr([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	protected L34dcYiwF8r2NgF7JX2P()
	{
		tcRAk8X9Wo6knQK08Vf1();
		aGVi7fN03TP = new Dictionary<string, Func<string>>();
		GLli7GKDRx6 = string.Empty;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_faecd961b0594031908711f9e1dd0981 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static L34dcYiwF8r2NgF7JX2P()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
		dZqjTlX9tfp8hvNvWxZ7();
	}

	internal static bool Ujg4IxX9MYsA4fuSK6mp()
	{
		return nlHRLkX96sigBaUNIANK == null;
	}

	internal static L34dcYiwF8r2NgF7JX2P loPMgpX9O28aBuQyPfL0()
	{
		return nlHRLkX96sigBaUNIANK;
	}

	internal static bool VZ7F9hX9qolE92x4V2HH(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void i15DgZX9IWS2Ug55Eeju(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void tcRAk8X9Wo6knQK08Vf1()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
	}

	internal static void dZqjTlX9tfp8hvNvWxZ7()
	{
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
	}
}
