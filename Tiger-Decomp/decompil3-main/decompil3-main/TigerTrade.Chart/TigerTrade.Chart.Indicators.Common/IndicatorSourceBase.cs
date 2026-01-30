using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using CxrNctLVMAMdEWPCMHj4;
using TigerTrade.Chart.Annotations;
using TigerTrade.Core.Utils.Config;

namespace TigerTrade.Chart.Indicators.Common;

[DataContract(Name = "IndicatorSourceBase", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public abstract class IndicatorSourceBase : INotifyPropertyChanged
{
	private string _name;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static List<Type> _sources;

	internal static IndicatorSourceBase vswn2DeOyTYSXqdAM7LA;

	[Browsable(false)]
	public string Name
	{
		get
		{
			if (!rDmPTNeOCldcFuiugS9F(_name))
			{
				return _name;
			}
			IndicatorSourceAttribute indicatorSourceAttribute = (IndicatorSourceAttribute)Attribute.GetCustomAttribute(GetType(), Type.GetTypeFromHandle(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(33554754)));
			_name = (string)((indicatorSourceAttribute != null) ? K4ErOCeOKQXiOGLoX6au(indicatorSourceAttribute) : Bp0NSdeOrGmdM3HYlFlc(0x7394D272 ^ 0x73945464));
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 == 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => _name, 
			};
		}
	}

	[Browsable(false)]
	[DataMember(Name = "SelectedSeries")]
	public string SelectedSeries { get; set; }

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				int num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
						num = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc == 0)
						{
							num = 0;
						}
						continue;
					}
					break;
				}
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_929b6fa00f634070a51f43668e9cc32e == 0)
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
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
						num = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e != 0)
						{
							num = 1;
						}
						continue;
					}
					break;
				}
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	protected IndicatorSourceBase()
	{
		K7ifoceOmhXaTM9aTe0c();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_caac71a6f9cb44c08459ac3c8bd80328 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		SelectedSeries = "";
	}

	public abstract IEnumerable<string> GetSeriesList();

	public abstract double[] GetSeries(IndicatorsHelper helper);

	public abstract void CopySettings(IndicatorSourceBase source);

	public override string ToString()
	{
		return (string)Bp0NSdeOrGmdM3HYlFlc(0x28B345BB ^ 0x28B3C25F);
	}

	public IndicatorSourceBase CloneSource()
	{
		return ConfigSerializer.LoadFromString<IndicatorSourceBase>(ConfigSerializer.SaveToString(this, GetTypes()), GetTypes());
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		if (propertyChangedEventHandler != null)
		{
			DIa6GYeOhBnx2kAFx3Um(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
		}
	}

	public static void SetSources(List<Type> sources)
	{
		if (_sources == null)
		{
			_sources = sources;
		}
	}

	private static IEnumerable<Type> GetTypes()
	{
		return _sources ?? new List<Type>();
	}

	static IndicatorSourceBase()
	{
		JZlq3JeOwGlimLasRSpD();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool rDmPTNeOCldcFuiugS9F(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object Bp0NSdeOrGmdM3HYlFlc(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static object K4ErOCeOKQXiOGLoX6au(object P_0)
	{
		return ((IndicatorSourceAttribute)P_0).Name;
	}

	internal static bool A4MtQgeOZyIYCvYylP51()
	{
		return vswn2DeOyTYSXqdAM7LA == null;
	}

	internal static IndicatorSourceBase faHlRKeOVDqrWuxLu3Wq()
	{
		return vswn2DeOyTYSXqdAM7LA;
	}

	internal static void K7ifoceOmhXaTM9aTe0c()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static void DIa6GYeOhBnx2kAFx3Um(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (PropertyChangedEventArgs)P_2);
	}

	internal static void JZlq3JeOwGlimLasRSpD()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
