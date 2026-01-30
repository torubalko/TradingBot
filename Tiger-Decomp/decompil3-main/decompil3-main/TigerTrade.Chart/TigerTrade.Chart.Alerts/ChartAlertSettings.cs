using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Annotations;
using TigerTrade.Core.Utils.Time;

namespace TigerTrade.Chart.Alerts;

[DataContract(Name = "ChartAlertSettings", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Alerts")]
public sealed class ChartAlertSettings : INotifyPropertyChanged
{
	private bool _active;

	private ChartAlertExecution _execution;

	private bool _deleteLevelAfterAlert;

	private DateTime? _expiration;

	private bool _playSound;

	private string _signal;

	private ChartAlertPlayDuration _duration;

	private bool _showPopup;

	private bool _sendEmail;

	private bool _sendTelegram;

	private string _message;

	private bool _log;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static ChartAlertSettings FFRD3ieWr4qLtHWjNFcA;

	[DataMember(Name = "Active")]
	[NotifyParentProperty(true)]
	public bool Active
	{
		get
		{
			return _active;
		}
		set
		{
			if (value != _active)
			{
				_active = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2D313048 ^ 0x2D319D1C));
				OnPropertyChanged((string)fJOqC0eWh27x3xmLE2ZC(-1380525184 ^ -1380550940));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
		}
	}

	[DataMember(Name = "Execution")]
	public ChartAlertExecution Execution
	{
		get
		{
			return _execution;
		}
		set
		{
			if (value != _execution)
			{
				_execution = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x22BF43FC ^ 0x22BFEE84));
			}
		}
	}

	[DataMember(Name = "DeleteLevelAfterAlert")]
	public bool DeleteLevelAfterAlert
	{
		get
		{
			return _deleteLevelAfterAlert;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (value != _deleteLevelAfterAlert)
					{
						_deleteLevelAfterAlert = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2002318893 ^ -2002279331));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3086d3efc49e46839e3f8d95f5cafecb == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "Expiration")]
	public DateTime? Expiration
	{
		get
		{
			return _expiration;
		}
		set
		{
			if (!value.Equals(_expiration))
			{
				_expiration = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-3429745 ^ -3471565));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x1487846E ^ 0x1487290A));
			}
		}
	}

	[DataMember(Name = "PlaySound")]
	public bool PlaySound
	{
		get
		{
			return _playSound;
		}
		set
		{
			if (value != _playSound)
			{
				_playSound = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-602153869 ^ -602181209));
			}
		}
	}

	[DataMember(Name = "Signal")]
	[DefaultValue("")]
	public string Signal
	{
		get
		{
			return _signal;
		}
		set
		{
			if (!(value == _signal))
			{
				_signal = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-371631841 ^ -371600683));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
		}
	}

	[DataMember(Name = "Duration")]
	public ChartAlertPlayDuration Duration
	{
		get
		{
			return _duration;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (value != _duration)
					{
						_duration = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6AB40973 ^ 0x6AB4A499));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "ShowPopup")]
	public bool ShowPopup
	{
		get
		{
			return _showPopup;
		}
		set
		{
			if (value != _showPopup)
			{
				_showPopup = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x5EA8FF2A ^ 0x5EA852D4));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
		}
	}

	[DataMember(Name = "SendEmail")]
	public bool SendEmail
	{
		get
		{
			return _sendEmail;
		}
		set
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
					if (value == _sendEmail)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 == 0)
						{
							num2 = 0;
						}
						break;
					}
					_sendEmail = value;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x50C1C840 ^ 0x50C16654));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "SendTelegram")]
	public bool SendTelegram
	{
		get
		{
			return _sendTelegram;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (value != _sendTelegram)
					{
						_sendTelegram = value;
						OnPropertyChanged((string)fJOqC0eWh27x3xmLE2ZC(0xECA3F28 ^ 0xECA9102));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "Message")]
	public string Message
	{
		get
		{
			return _message;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (!(value == _message))
					{
						_message = value;
						OnPropertyChanged((string)fJOqC0eWh27x3xmLE2ZC(-2123795572 ^ -2123768374));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "Log")]
	public bool Log
	{
		get
		{
			return _log;
		}
		set
		{
			if (value != _log)
			{
				_log = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)fJOqC0eWh27x3xmLE2ZC(-338769610 ^ -338794642));
			}
		}
	}

	public bool IsActive
	{
		get
		{
			int num = 1;
			int num2 = num;
			DateTime? expiration = default(DateTime?);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (Active)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return false;
				default:
					expiration = Expiration;
					num2 = 3;
					break;
				case 3:
					if (!expiration.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 != 0)
						{
							num2 = 2;
						}
						break;
					}
					return Expiration > Qm6kKOeWwCTXXriS1fUf();
				case 2:
					return true;
				}
			}
		}
	}

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
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 != 0)
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
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 == 0)
				{
					num2 = 2;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 1;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 1:
					propertyChangedEventHandler2 = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
				{
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)e37EYgeWPZ74kLeai4RZ(propertyChangedEventHandler, value);
					propertyChangedEventHandler2 = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler);
					if ((object)propertyChangedEventHandler2 == propertyChangedEventHandler)
					{
						return;
					}
					break;
				}
				}
				propertyChangedEventHandler = propertyChangedEventHandler2;
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d == 0)
				{
					num2 = 2;
				}
			}
		}
	}

	public ChartAlertSettings Clone()
	{
		return (ChartAlertSettings)MemberwiseClone();
	}

	public void Copy(ChartAlertSettings alert, bool copyActive = false)
	{
		int num = 7;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					Active = alert.Active;
					goto case 4;
				case 4:
					Execution = alert.Execution;
					num2 = 2;
					break;
				case 5:
					Log = alert.Log;
					return;
				case 7:
					if (copyActive)
					{
						goto end_IL_0012;
					}
					goto case 3;
				case 3:
					if (!alert.Active)
					{
						Active = false;
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 == 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 4;
				case 2:
					DeleteLevelAfterAlert = alert.DeleteLevelAfterAlert;
					Expiration = alert.Expiration;
					PlaySound = alert.PlaySound;
					Signal = alert.Signal;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a == 0)
					{
						num2 = 1;
					}
					break;
				default:
					SendTelegram = kwXf2weWAy6Qyh22kZsh(alert);
					Message = alert.Message;
					num2 = 5;
					break;
				case 1:
					Duration = alert.Duration;
					ShowPopup = A0OppReW7nHYFg5YUKHv(alert);
					SendEmail = JJpFxfeW8GpVBkivPOvO(alert);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	public bool Equals(ChartAlertSettings other)
	{
		if (other == null)
		{
			return false;
		}
		int num;
		if (this == other)
		{
			num = 5;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
			{
				num = 3;
			}
		}
		else
		{
			if (_active != other._active || _execution != other._execution || _deleteLevelAfterAlert != other._deleteLevelAfterAlert || !Nullable.Equals(_expiration, other._expiration))
			{
				goto IL_003a;
			}
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b != 0)
			{
				num = 0;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				break;
			case 5:
				return true;
			default:
				if (_playSound != other._playSound)
				{
					break;
				}
				if (!(_signal == other._signal))
				{
					num = 4;
					continue;
				}
				if (_duration == other._duration)
				{
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
					{
						num = 1;
					}
					continue;
				}
				break;
			case 1:
				if (_showPopup == other._showPopup && _sendEmail == other._sendEmail)
				{
					num = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd != 0)
					{
						num = 2;
					}
					continue;
				}
				break;
			case 3:
				if (_sendTelegram == other._sendTelegram)
				{
					if (_message == other._message)
					{
						return _log == other._log;
					}
					num = 2;
					continue;
				}
				break;
			}
			break;
		}
		goto IL_003a;
		IL_003a:
		return false;
	}

	public override int GetHashCode()
	{
		return (int)(((((((((((((((((((((uint)(_active.GetHashCode() * 397) ^ (uint)_execution) * 397) ^ (uint)_deleteLevelAfterAlert.GetHashCode()) * 397) ^ (uint)_expiration.GetHashCode()) * 397) ^ (uint)_playSound.GetHashCode()) * 397) ^ (uint)((_signal != null) ? _signal.GetHashCode() : 0)) * 397) ^ (uint)_duration) * 397) ^ (uint)_showPopup.GetHashCode()) * 397) ^ (uint)_sendEmail.GetHashCode()) * 397) ^ (uint)_sendTelegram.GetHashCode()) * 397) ^ (uint)((_message != null) ? _message.GetHashCode() : 0)) * 397) ^ _log.GetHashCode();
	}

	[NotifyPropertyChangedInvocator]
	private void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		if (propertyChangedEventHandler != null)
		{
			Is2WqQeWJpVKkNFaNCOO(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
		}
	}

	public ChartAlertSettings()
	{
		m4DlZ1eWFJyvt3asDv5g();
		base._002Ector();
	}

	static ChartAlertSettings()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object fJOqC0eWh27x3xmLE2ZC(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool LmxAmveWK2VgXOJ8QsMG()
	{
		return FFRD3ieWr4qLtHWjNFcA == null;
	}

	internal static ChartAlertSettings XlQP4LeWmn6sXyCEPCiF()
	{
		return FFRD3ieWr4qLtHWjNFcA;
	}

	internal static DateTime Qm6kKOeWwCTXXriS1fUf()
	{
		return TimeHelper.LocalTime;
	}

	internal static bool A0OppReW7nHYFg5YUKHv(object P_0)
	{
		return ((ChartAlertSettings)P_0).ShowPopup;
	}

	internal static bool JJpFxfeW8GpVBkivPOvO(object P_0)
	{
		return ((ChartAlertSettings)P_0).SendEmail;
	}

	internal static bool kwXf2weWAy6Qyh22kZsh(object P_0)
	{
		return ((ChartAlertSettings)P_0).SendTelegram;
	}

	internal static object e37EYgeWPZ74kLeai4RZ(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static void Is2WqQeWJpVKkNFaNCOO(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (PropertyChangedEventArgs)P_2);
	}

	internal static void m4DlZ1eWFJyvt3asDv5g()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}
}
