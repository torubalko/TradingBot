using System;
using System.ComponentModel;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Searching;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

public class EditorSearchOptions : IEditorSearchOptions, ISearchOptions, ICloneable, INotifyPropertyChanged
{
	private string RYd;

	private bool EYz;

	private bool S4W;

	private int P4P;

	private ISearchPatternProvider T4E;

	private string r4c;

	private EditorSearchScope M4a;

	private bool w4x;

	private static readonly EditorSearchOptions p4G;

	private static EditorSearchOptions wAt;

	public static IEditorSearchOptions Default => p4G;

	public string FindText
	{
		get
		{
			return RYd ?? string.Empty;
		}
		set
		{
			if (!(RYd == value))
			{
				RYd = value;
				NotifyPropertyChanged(Q7Z.tqM(9652));
			}
		}
	}

	public bool MatchCase
	{
		get
		{
			return EYz;
		}
		set
		{
			if (EYz != value)
			{
				EYz = value;
				NotifyPropertyChanged(Q7Z.tqM(9672));
			}
		}
	}

	public bool MatchWholeWord
	{
		get
		{
			return S4W;
		}
		set
		{
			if (S4W != value)
			{
				S4W = value;
				NotifyPropertyChanged(Q7Z.tqM(9694));
			}
		}
	}

	public int MaximumResultCount
	{
		get
		{
			return P4P;
		}
		set
		{
			if (value <= 0)
			{
				throw new ArgumentOutOfRangeException(Q7Z.tqM(191580));
			}
			if (P4P != value)
			{
				P4P = value;
				NotifyPropertyChanged(Q7Z.tqM(193304));
			}
		}
	}

	public ISearchPatternProvider PatternProvider
	{
		get
		{
			return T4E;
		}
		set
		{
			if (T4E != value)
			{
				T4E = value;
				NotifyPropertyChanged(Q7Z.tqM(9726));
			}
		}
	}

	public string ReplaceText
	{
		get
		{
			return r4c ?? string.Empty;
		}
		set
		{
			if (!(r4c == value))
			{
				r4c = value;
				NotifyPropertyChanged(Q7Z.tqM(193344));
			}
		}
	}

	public EditorSearchScope Scope
	{
		get
		{
			return M4a;
		}
		set
		{
			if (M4a != value)
			{
				M4a = value;
				NotifyPropertyChanged(Q7Z.tqM(9638));
			}
		}
	}

	public bool SearchUp
	{
		get
		{
			return w4x;
		}
		set
		{
			if (w4x != value)
			{
				w4x = value;
				NotifyPropertyChanged(Q7Z.tqM(193370));
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	public virtual object Clone()
	{
		EditorSearchOptions editorSearchOptions = new EditorSearchOptions();
		editorSearchOptions.RYd = RYd;
		editorSearchOptions.EYz = EYz;
		editorSearchOptions.S4W = S4W;
		editorSearchOptions.P4P = P4P;
		editorSearchOptions.T4E = T4E ?? SearchPatternProviders.Normal;
		int num = 0;
		if (!lAY())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			editorSearchOptions.r4c = r4c;
			editorSearchOptions.M4a = M4a;
			editorSearchOptions.w4x = w4x;
			return editorSearchOptions;
		}
	}

	public override bool Equals(object obj)
	{
		if (obj is EditorSearchOptions editorSearchOptions)
		{
			return RYd == editorSearchOptions.RYd && EYz == editorSearchOptions.EYz && S4W == editorSearchOptions.S4W && P4P == editorSearchOptions.P4P && T4E == editorSearchOptions.T4E && r4c == editorSearchOptions.r4c && M4a == editorSearchOptions.M4a && w4x == editorSearchOptions.w4x;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	protected void NotifyPropertyChanged(string name)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}

	public EditorSearchOptions()
	{
		grA.DaB7cz();
		P4P = int.MaxValue;
		T4E = SearchPatternProviders.Normal;
		base._002Ector();
	}

	static EditorSearchOptions()
	{
		grA.DaB7cz();
		p4G = new EditorSearchOptions();
	}

	internal static bool lAY()
	{
		return wAt == null;
	}

	internal static EditorSearchOptions UAb()
	{
		return wAt;
	}
}
