using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens;

public abstract class BaseConfigurationManager
{
	private TimeSpan _automaticRefreshInterval = DefaultAutomaticRefreshInterval;

	private TimeSpan _refreshInterval = DefaultRefreshInterval;

	private TimeSpan _lastKnownGoodLifetime = DefaultLastKnownGoodConfigurationLifetime;

	private BaseConfiguration _lastKnownGoodConfiguration;

	private DateTime? _lastKnownGoodConfigFirstUse;

	public static readonly TimeSpan DefaultAutomaticRefreshInterval = new TimeSpan(0, 12, 0, 0);

	public static readonly TimeSpan DefaultLastKnownGoodConfigurationLifetime = new TimeSpan(0, 1, 0, 0);

	public static readonly TimeSpan DefaultRefreshInterval = new TimeSpan(0, 0, 5, 0);

	public static readonly TimeSpan MinimumAutomaticRefreshInterval = new TimeSpan(0, 0, 5, 0);

	public static readonly TimeSpan MinimumRefreshInterval = new TimeSpan(0, 0, 0, 1);

	public TimeSpan AutomaticRefreshInterval
	{
		get
		{
			return _automaticRefreshInterval;
		}
		set
		{
			if (value < MinimumAutomaticRefreshInterval)
			{
				throw LogHelper.LogExceptionMessage(new ArgumentOutOfRangeException("value", LogHelper.FormatInvariant("IDX10108: When setting AutomaticRefreshInterval, the value must be greater than MinimumAutomaticRefreshInterval: '{0}'. value: '{1}'.", LogHelper.MarkAsNonPII(MinimumAutomaticRefreshInterval), LogHelper.MarkAsNonPII(value))));
			}
			_automaticRefreshInterval = value;
		}
	}

	public BaseConfiguration LastKnownGoodConfiguration
	{
		get
		{
			if (!_lastKnownGoodConfigFirstUse.HasValue && _lastKnownGoodConfiguration != null)
			{
				_lastKnownGoodConfigFirstUse = DateTime.UtcNow;
			}
			return _lastKnownGoodConfiguration;
		}
		set
		{
			_lastKnownGoodConfiguration = value ?? throw LogHelper.LogArgumentNullException("value");
			_lastKnownGoodConfigFirstUse = null;
		}
	}

	public TimeSpan LastKnownGoodLifetime
	{
		get
		{
			return _lastKnownGoodLifetime;
		}
		set
		{
			if (value < TimeSpan.Zero)
			{
				throw LogHelper.LogExceptionMessage(new ArgumentOutOfRangeException("value", LogHelper.FormatInvariant("IDX10110: When setting LastKnownGoodLifetime, the value must be greater than or equal to zero. value: '{0}'.", value)));
			}
			_lastKnownGoodLifetime = value;
		}
	}

	public string MetadataAddress { get; set; }

	public TimeSpan RefreshInterval
	{
		get
		{
			return _refreshInterval;
		}
		set
		{
			if (value < MinimumRefreshInterval)
			{
				throw LogHelper.LogExceptionMessage(new ArgumentOutOfRangeException("value", LogHelper.FormatInvariant("IDX10107: When setting RefreshInterval, the value must be greater than MinimumRefreshInterval: '{0}'. value: '{1}'.", LogHelper.MarkAsNonPII(MinimumRefreshInterval), LogHelper.MarkAsNonPII(value))));
			}
			_refreshInterval = value;
		}
	}

	public bool UseLastKnownGoodConfiguration { get; set; } = true;

	public bool IsLastKnownGoodValid
	{
		get
		{
			if (_lastKnownGoodConfiguration != null)
			{
				if (_lastKnownGoodConfigFirstUse.HasValue)
				{
					DateTime utcNow = DateTime.UtcNow;
					DateTime? dateTime = _lastKnownGoodConfigFirstUse + LastKnownGoodLifetime;
					return utcNow < dateTime;
				}
				return true;
			}
			return false;
		}
	}

	public virtual Task<BaseConfiguration> GetBaseConfigurationAsync(CancellationToken cancel)
	{
		throw new NotImplementedException();
	}

	public abstract void RequestRefresh();
}
