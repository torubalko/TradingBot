using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;
using ActiproSoftware.Windows.Media;
using ActiproSoftware.Windows.Themes;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
public class IntelliPromptCodeSnippetSelector : ItemsControl
{
	private class BAq : ContentControl
	{
		private bool IVe;

		private TextBlock BVl;

		private static BAq QN8;

		[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
		public bool RVD
		{
			get
			{
				return IVe;
			}
			set
			{
				if (IVe == flag)
				{
					return;
				}
				IVe = flag;
				if (IVe)
				{
					vAE.P01(BVl, Cursors.Hand);
					BVl.TextDecorations = TextDecorations.Underline;
					Brush brush = (TryFindResource(AssetResourceKeys.HyperlinkForegroundNormalBrushKey) as Brush) ?? SystemColors.HotTrackBrush;
					if (brush != null)
					{
						BVl.Foreground = brush;
					}
				}
				else
				{
					vAE.P01(BVl, null);
					BVl.TextDecorations = null;
					BVl.ClearValue(TextBlock.ForegroundProperty);
				}
			}
		}

		[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
		public string Text
		{
			get
			{
				return BVl.Text;
			}
			set
			{
				BVl.Text = text;
			}
		}

		public BAq(ICodeSnippetFolder P_0)
		{
			grA.DaB7cz();
			base._002Ector();
			if (P_0 == null)
			{
				int num = 0;
				if (1 == 0)
				{
					int num2;
					num = num2;
				}
				switch (num)
				{
				default:
					throw new ArgumentNullException(Q7Z.tqM(12510));
				}
			}
			BVl = new TextBlock();
			BVl.VerticalAlignment = VerticalAlignment.Center;
			base.Content = BVl;
			base.DataContext = P_0;
			base.Focusable = false;
			base.FocusVisualStyle = null;
			base.IsTabStop = false;
		}

		[SpecialName]
		public ICodeSnippetFolder VVG()
		{
			return base.DataContext as ICodeSnippetFolder;
		}

		protected override void OnMouseLeftButtonDown(MouseButtonEventArgs P_0)
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException(Q7Z.tqM(1014));
			}
			if (!IVe || !(VisualTreeHelperExtended.GetAncestor(this, typeof(IntelliPromptCodeSnippetSelector)) is IntelliPromptCodeSnippetSelector { Session: CodeSnippetSelectionSession session } intelliPromptCodeSnippetSelector))
			{
				base.OnMouseLeftButtonDown(P_0);
				return;
			}
			int num = 0;
			if (pNe() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			while (intelliPromptCodeSnippetSelector.eQ5 != this)
			{
				session.Cuf();
			}
			P_0.Handled = true;
		}

		internal static bool mNU()
		{
			return QN8 == null;
		}

		internal static BAq pNe()
		{
			return QN8;
		}
	}

	private Rectangle NQ8;

	private Storyboard BQI;

	private BAq eQ5;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ICodeSnippetSelectionSession nQ0;

	private static IntelliPromptCodeSnippetSelector BBv;

	public double CurrentInputTextHorizontalOffset
	{
		get
		{
			if (eQ5 == null)
			{
				return 0.0;
			}
			return vAE.M03(eQ5, this).Transform(new Point(0.0, 0.0)).X;
		}
	}

	public ICodeSnippetSelectionSession Session
	{
		[CompilerGenerated]
		get
		{
			return nQ0;
		}
		[CompilerGenerated]
		private set
		{
			nQ0 = value;
		}
	}

	public IntelliPromptCodeSnippetSelector(ICodeSnippetSelectionSession session)
	{
		grA.DaB7cz();
		base._002Ector();
		if (session == null)
		{
			int num = 0;
			if (false)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			default:
				throw new ArgumentNullException(Q7Z.tqM(8536));
			}
		}
		base.DefaultStyleKey = typeof(IntelliPromptCodeSnippetSelector);
		Session = session;
		TQw();
		CQj();
		gQb(session.RootFolder);
	}

	private void CQj()
	{
		NQ8 = new Rectangle();
		NQ8.Fill = base.Foreground;
		NQ8.Width = 1.0;
		base.Items.Add(NQ8);
		ObjectAnimationUsingKeyFrames objectAnimationUsingKeyFrames = new ObjectAnimationUsingKeyFrames
		{
			KeyFrames = 
			{
				(ObjectKeyFrame)new DiscreteObjectKeyFrame
				{
					KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.0)),
					Value = 1.0
				},
				(ObjectKeyFrame)new DiscreteObjectKeyFrame
				{
					KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.5)),
					Value = 0.0
				}
			}
		};
		int num = 0;
		if (!SBf())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		Storyboard.SetTarget(objectAnimationUsingKeyFrames, NQ8);
		Storyboard.SetTargetProperty(objectAnimationUsingKeyFrames, new PropertyPath(UIElement.OpacityProperty));
		BQI = new Storyboard
		{
			RepeatBehavior = RepeatBehavior.Forever,
			Duration = new Duration(TimeSpan.FromSeconds(1.0))
		};
		BQI.Children.Add(objectAnimationUsingKeyFrames);
	}

	private void TQw()
	{
		TextBlock textBlock = new TextBlock();
		textBlock.Text = Session.Label;
		textBlock.VerticalAlignment = VerticalAlignment.Center;
		textBlock.Margin = new Thickness(0.0, 0.0, 7.0, 0.0);
		if (!string.IsNullOrEmpty(textBlock.Text))
		{
			base.Items.Add(textBlock);
		}
	}

	private void HQ6()
	{
		if (NQ8 != null)
		{
			vAE.c0a(NQ8);
		}
	}

	internal bool LQH()
	{
		if (eQ5.VVG() != Session.RootFolder)
		{
			base.Items.RemoveAt(base.Items.Count - 2);
			base.Items.RemoveAt(base.Items.Count - 2);
			eQ5 = base.Items[base.Items.Count - 2] as BAq;
			eQ5.RVD = false;
			return true;
		}
		return false;
	}

	[SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "System.Windows.Controls.TextBlock.set_Text(System.String)")]
	internal void gQb(ICodeSnippetFolder P_0)
	{
		if (P_0 != Session.RootFolder)
		{
			eQ5.Text = P_0.Name;
			eQ5.RVD = true;
			TextBlock textBlock = new TextBlock();
			textBlock.Text = Q7Z.tqM(8554);
			textBlock.VerticalAlignment = VerticalAlignment.Center;
			textBlock.Margin = new Thickness(7.0, 0.0, 7.0, 0.0);
			base.Items.Insert(base.Items.Count - 1, textBlock);
		}
		eQ5 = new BAq(P_0);
		base.Items.Insert(base.Items.Count - 1, eQ5);
	}

	internal void kQT(bool P_0)
	{
		if (BQI != null)
		{
			if (!P_0)
			{
				BQI.Stop();
			}
			else
			{
				BQI.Begin();
			}
		}
	}

	internal void gQL(string P_0)
	{
		eQ5.Text = P_0;
		HQ6();
	}

	internal static bool SBf()
	{
		return BBv == null;
	}

	internal static IntelliPromptCodeSnippetSelector aBi()
	{
		return BBv;
	}
}
