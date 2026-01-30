using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

namespace ActiproSoftware.Text.Tagging.Implementation;

public abstract class IndicatorTagBase : IIndicatorTag, ITag
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IContentProvider jIG;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object XIX;

	private static IndicatorTagBase B5c;

	public IContentProvider ContentProvider
	{
		[CompilerGenerated]
		get
		{
			return jIG;
		}
		[CompilerGenerated]
		set
		{
			jIG = value;
		}
	}

	public virtual Size GlyphSize => new Size(16.0, 16.0);

	public object Tag
	{
		[CompilerGenerated]
		get
		{
			return XIX;
		}
		[CompilerGenerated]
		set
		{
			XIX = value;
		}
	}

	public abstract void DrawGlyph(TextViewDrawContext context, ITextViewLine viewLine, TagSnapshotRange<IIndicatorTag> tagRange, Rect bounds);

	protected Point GetLocation(Rect bounds)
	{
		return GetLocation(bounds, HorizontalAlignment.Center, VerticalAlignment.Center);
	}

	protected Point GetLocation(Rect bounds, HorizontalAlignment horizontalAlignment, VerticalAlignment verticalAlignment)
	{
		Size glyphSize = GlyphSize;
		return new Point(horizontalAlignment switch
		{
			HorizontalAlignment.Left => bounds.Left, 
			HorizontalAlignment.Right => bounds.Right - glyphSize.Width, 
			_ => bounds.Left + Math.Round((bounds.Width - glyphSize.Width) / 2.0, MidpointRounding.AwayFromZero), 
		}, verticalAlignment switch
		{
			VerticalAlignment.Top => bounds.Top, 
			VerticalAlignment.Bottom => bounds.Bottom - glyphSize.Height, 
			_ => bounds.Top + Math.Round((bounds.Height - glyphSize.Height) / 2.0, MidpointRounding.AwayFromZero), 
		});
	}

	protected IndicatorTagBase()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool s5d()
	{
		return B5c == null;
	}

	internal static IndicatorTagBase r5T()
	{
		return B5c;
	}
}
