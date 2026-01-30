using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class CompletionItem : ICompletionItem
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string U1x;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string r1G;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IContentProvider a1X;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IImageSourceProvider x1K;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object g1f;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string p1D;

	private static CompletionItem ka6;

	public string AutoCompletePostText
	{
		[CompilerGenerated]
		get
		{
			return U1x;
		}
		[CompilerGenerated]
		set
		{
			U1x = value;
		}
	}

	public string AutoCompletePreText
	{
		[CompilerGenerated]
		get
		{
			return r1G;
		}
		[CompilerGenerated]
		set
		{
			r1G = value;
		}
	}

	public IContentProvider DescriptionProvider
	{
		[CompilerGenerated]
		get
		{
			return a1X;
		}
		[CompilerGenerated]
		set
		{
			a1X = value;
		}
	}

	public IImageSourceProvider ImageSourceProvider
	{
		[CompilerGenerated]
		get
		{
			return x1K;
		}
		[CompilerGenerated]
		set
		{
			x1K = value;
		}
	}

	public object Tag
	{
		[CompilerGenerated]
		get
		{
			return g1f;
		}
		[CompilerGenerated]
		set
		{
			g1f = value;
		}
	}

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return p1D;
		}
		[CompilerGenerated]
		set
		{
			p1D = value;
		}
	}

	public CompletionItem()
	{
		grA.DaB7cz();
		this._002Ector(null, null, null, null, null, null);
	}

	public CompletionItem(string text, IImageSourceProvider imageSourceProvider)
	{
		grA.DaB7cz();
		this._002Ector(text, imageSourceProvider, null, text, null, null);
	}

	public CompletionItem(string text, IImageSourceProvider imageSourceProvider, object tag)
	{
		grA.DaB7cz();
		this._002Ector(text, imageSourceProvider, null, text, null, tag);
	}

	public CompletionItem(string text, IImageSourceProvider imageSourceProvider, IContentProvider descriptionProvider)
	{
		grA.DaB7cz();
		this._002Ector(text, imageSourceProvider, descriptionProvider, text, null, null);
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "PreText")]
	public CompletionItem(string text, IImageSourceProvider imageSourceProvider, IContentProvider descriptionProvider, string autoCompletePreText, string autoCompletePostText)
	{
		grA.DaB7cz();
		this._002Ector(text, imageSourceProvider, descriptionProvider, autoCompletePreText, autoCompletePostText, null);
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "PreText")]
	public CompletionItem(string text, IImageSourceProvider imageSourceProvider, IContentProvider descriptionProvider, string autoCompletePreText, string autoCompletePostText, object tag)
	{
		grA.DaB7cz();
		base._002Ector();
		Text = text;
		ImageSourceProvider = imageSourceProvider;
		DescriptionProvider = descriptionProvider;
		AutoCompletePreText = autoCompletePreText;
		AutoCompletePostText = autoCompletePostText;
		Tag = tag;
	}

	internal static bool UaK()
	{
		return ka6 == null;
	}

	internal static CompletionItem CaC()
	{
		return ka6;
	}
}
