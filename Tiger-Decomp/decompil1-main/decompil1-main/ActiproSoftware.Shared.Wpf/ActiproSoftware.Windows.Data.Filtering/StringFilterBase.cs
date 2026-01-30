using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using System.Windows;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data.Filtering;

public abstract class StringFilterBase : DataFilterBase
{
	public static readonly DependencyProperty OperationProperty;

	public static readonly DependencyProperty RegexOptionsProperty;

	public static readonly DependencyProperty StringComparisonProperty;

	public static readonly DependencyProperty ValueProperty;

	internal static StringFilterBase dqG;

	public StringFilterOperation Operation
	{
		get
		{
			return (StringFilterOperation)GetValue(OperationProperty);
		}
		set
		{
			SetValue(OperationProperty, value);
		}
	}

	public RegexOptions RegexOptions
	{
		get
		{
			return (RegexOptions)GetValue(RegexOptionsProperty);
		}
		set
		{
			SetValue(RegexOptionsProperty, value);
		}
	}

	public StringComparison StringComparison
	{
		get
		{
			return (StringComparison)GetValue(StringComparisonProperty);
		}
		set
		{
			SetValue(StringComparisonProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public string Value
	{
		get
		{
			return (string)GetValue(ValueProperty);
		}
		set
		{
			SetValue(ValueProperty, value);
		}
	}

	private IEnumerable<StringFilterCapture> FlT(string P_0, string P_1)
	{
		if (P_0 != null && P_1 != null)
		{
			int index = P_0.IndexOf(P_1, StringComparison);
			if (index != -1)
			{
				yield return new StringFilterCapture(index, P_1.Length);
			}
		}
	}

	private bool YlB(string P_0, string P_1)
	{
		if (P_0 == null)
		{
			return false;
		}
		if (P_1 != null)
		{
			return P_0.IndexOf(P_1, StringComparison) != -1;
		}
		return true;
	}

	private IEnumerable<StringFilterCapture> Mlp(string P_0, string P_1)
	{
		if (P_0 != null && P_1 != null && P_0.EndsWith(P_1, StringComparison))
		{
			yield return new StringFilterCapture(P_0.Length - P_1.Length, P_1.Length);
		}
	}

	private bool dlb(string P_0, string P_1)
	{
		if (P_0 != null)
		{
			bool flag = P_1 == null;
			int num = 0;
			if (lq0() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				if (!flag)
				{
					return P_0.EndsWith(P_1, StringComparison);
				}
				return true;
			}
		}
		return false;
	}

	private IEnumerable<StringFilterCapture> Bly(string P_0, string P_1)
	{
		if (P_0 != null && P_1 != null && P_0.Equals(P_1, StringComparison))
		{
			yield return new StringFilterCapture(0, P_1.Length);
		}
	}

	private bool flf(string P_0, string P_1)
	{
		if (P_0 != null || P_1 != null)
		{
			if (P_0 != null && P_1 != null)
			{
				int num = 0;
				if (!Mqn())
				{
					int num2 = default(int);
					num = num2;
				}
				return num switch
				{
					_ => P_0.Equals(P_1, StringComparison), 
				};
			}
			return false;
		}
		return true;
	}

	private IEnumerable<StringFilterCapture> zli(string P_0, string P_1)
	{
		if (P_0 == null || P_1 == null)
		{
			yield break;
		}
		Match match = null;
		try
		{
			RegexOptions regexOptions = RegexOptions;
			switch (StringComparison)
			{
			case StringComparison.CurrentCultureIgnoreCase:
			case StringComparison.InvariantCultureIgnoreCase:
			case StringComparison.OrdinalIgnoreCase:
				regexOptions |= RegexOptions.IgnoreCase;
				break;
			}
			match = Regex.Match(P_0, P_1, regexOptions);
		}
		catch (ArgumentException)
		{
		}
		if (match == null || match.Captures == null)
		{
			yield break;
		}
		foreach (Capture capture in match.Captures)
		{
			yield return new StringFilterCapture(capture.Index, capture.Length);
		}
	}

	private bool slS(string P_0, string P_1)
	{
		if (P_0 == null || P_1 == null)
		{
			return false;
		}
		try
		{
			RegexOptions regexOptions = RegexOptions;
			switch (StringComparison)
			{
			case StringComparison.CurrentCultureIgnoreCase:
			case StringComparison.InvariantCultureIgnoreCase:
			case StringComparison.OrdinalIgnoreCase:
				regexOptions |= RegexOptions.IgnoreCase;
				break;
			}
			return Regex.Match(P_0, P_1, regexOptions).Success;
		}
		catch (ArgumentException)
		{
			return false;
		}
	}

	private IEnumerable<StringFilterCapture> xl3(string P_0, string P_1)
	{
		if (P_0 != null && P_1 != null && P_0.StartsWith(P_1, StringComparison))
		{
			yield return new StringFilterCapture(0, P_1.Length);
		}
	}

	private bool Nlt(string P_0, string P_1)
	{
		if (P_0 == null)
		{
			return false;
		}
		if (P_1 == null)
		{
			return true;
		}
		return P_0.StartsWith(P_1, StringComparison);
	}

	protected virtual bool FilterByString(string source, string test)
	{
		return Operation switch
		{
			StringFilterOperation.Equals => flf(source, test), 
			StringFilterOperation.NotEquals => !flf(source, test), 
			StringFilterOperation.Contains => YlB(source, test), 
			StringFilterOperation.NotContains => !YlB(source, test), 
			StringFilterOperation.StartsWith => Nlt(source, test), 
			StringFilterOperation.NotStartsWith => !Nlt(source, test), 
			StringFilterOperation.EndsWith => dlb(source, test), 
			StringFilterOperation.NotEndsWith => !dlb(source, test), 
			StringFilterOperation.RegexMatch => slS(source, test), 
			StringFilterOperation.NotRegexMatch => !slS(source, test), 
			_ => false, 
		};
	}

	public virtual IEnumerable<StringFilterCapture> GetCaptures(string source, string test)
	{
		if (!string.IsNullOrEmpty(source) && !string.IsNullOrEmpty(test))
		{
			switch (Operation)
			{
			case StringFilterOperation.Equals:
				return Bly(source, test);
			case StringFilterOperation.Contains:
				return FlT(source, test);
			case StringFilterOperation.StartsWith:
				return xl3(source, test);
			case StringFilterOperation.EndsWith:
				return Mlp(source, test);
			case StringFilterOperation.RegexMatch:
				return zli(source, test);
			}
		}
		return null;
	}

	protected StringFilterBase()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static StringFilterBase()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		OperationProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112766), typeof(StringFilterOperation), typeof(StringFilterBase), new PropertyMetadata(StringFilterOperation.Contains, DataFilterBase.OnFilterRelatedPropertyValueChanged));
		RegexOptionsProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112890), typeof(RegexOptions), typeof(StringFilterBase), new PropertyMetadata(RegexOptions.None, DataFilterBase.OnFilterRelatedPropertyValueChanged));
		StringComparisonProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112918), typeof(StringComparison), typeof(StringFilterBase), new PropertyMetadata(StringComparison.CurrentCultureIgnoreCase, DataFilterBase.OnFilterRelatedPropertyValueChanged));
		ValueProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112788), typeof(string), typeof(StringFilterBase), new PropertyMetadata(null, DataFilterBase.OnFilterRelatedPropertyValueChanged));
	}

	internal static bool Mqn()
	{
		return dqG == null;
	}

	internal static StringFilterBase lq0()
	{
		return dqG;
	}
}
