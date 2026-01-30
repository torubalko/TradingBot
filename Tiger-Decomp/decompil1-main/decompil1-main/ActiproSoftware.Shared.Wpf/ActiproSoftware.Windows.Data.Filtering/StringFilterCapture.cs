using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data.Filtering;

public class StringFilterCapture
{
	public static readonly DependencyProperty CapturesProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int hlh;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int Qlm;

	internal static StringFilterCapture fqb;

	public int Index
	{
		[CompilerGenerated]
		get
		{
			return hlh;
		}
		[CompilerGenerated]
		private set
		{
			hlh = value;
		}
	}

	public int Length
	{
		[CompilerGenerated]
		get
		{
			return Qlm;
		}
		[CompilerGenerated]
		private set
		{
			Qlm = value;
		}
	}

	public StringFilterCapture(int index, int length)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		Index = index;
		Length = length;
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static IEnumerable<StringFilterCapture> GetCaptures(FrameworkElement obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (IEnumerable<StringFilterCapture>)obj.GetValue(CapturesProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetCaptures(FrameworkElement obj, IEnumerable<StringFilterCapture> value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(CapturesProperty, value);
	}

	public override bool Equals(object obj)
	{
		bool result;
		if (!(obj is StringFilterCapture stringFilterCapture))
		{
			result = false;
			int num = 0;
			if (!Hq1())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else
		{
			result = Index == stringFilterCapture.Index && Length == stringFilterCapture.Length;
		}
		return result;
	}

	public override int GetHashCode()
	{
		return Index ^ Length;
	}

	public override string ToString()
	{
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112954) + Index + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112972) + Length + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112992);
	}

	static StringFilterCapture()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		CapturesProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112998), typeof(IEnumerable<StringFilterCapture>), typeof(StringFilterCapture), new PropertyMetadata(null));
	}

	internal static bool Hq1()
	{
		return fqb == null;
	}

	internal static StringFilterCapture cqg()
	{
		return fqb;
	}
}
