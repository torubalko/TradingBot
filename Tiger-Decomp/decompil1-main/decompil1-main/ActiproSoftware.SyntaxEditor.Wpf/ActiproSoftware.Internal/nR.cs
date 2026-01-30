using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Internal;

internal class nR : Panel
{
	private Size QAK;

	private List<MTG> GAf;

	private TextView vAD;

	private Cursor FAg;

	private bool GAQ;

	internal static nR j0f;

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	public bool XAX
	{
		get
		{
			return GAQ;
		}
		set
		{
			if (GAQ != flag)
			{
				GAQ = flag;
				iAP();
			}
		}
	}

	public nR(TextView P_0)
	{
		grA.DaB7cz();
		GAf = new List<MTG>();
		base._002Ector();
		if (P_0 != null)
		{
			vAD = P_0;
			FAW();
			return;
		}
		throw new ArgumentNullException(Q7Z.tqM(952));
	}

	private void clZ(MTG P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(10820));
		}
		GAf.Add(P_0);
		MTG[] array = OrderableHelper.Sort(GAf.ToArray());
		Array.Reverse(array);
		GAf.Clear();
		int num = 0;
		if (c02() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		GAf.AddRange(array);
		UIElementCollection uIElementCollection = this.v0D();
		uIElementCollection.Clear();
		foreach (MTG item in GAf)
		{
			UIElement visualElement = item.VisualElement;
			if (visualElement != null)
			{
				uIElementCollection.Add(visualElement);
			}
		}
	}

	internal void Ylh()
	{
		ITextSnapshot currentSnapshot = vAD.CurrentSnapshot;
		foreach (MTG item in GAf)
		{
			if (item is DAN dAN)
			{
				dAN.znS(currentSnapshot);
			}
		}
	}

	protected override Size ArrangeOverride(Size P_0)
	{
		Rect rect = new Rect(0.0, 0.0, P_0.Width, P_0.Height);
		base.Clip = new RectangleGeometry
		{
			Rect = rect
		};
		if (QAK != P_0)
		{
			vAD.WAL().HTw(QAK, P_0);
		}
		vAD.WAL().gTH();
		QAK = P_0;
		Rect finalRect = new Rect(0.0 - vAD.ScrollState.HorizontalAmount, 0.0, vAD.ScrollState.HorizontalAmount + P_0.Width, P_0.Height);
		UIElementCollection uIElementCollection = this.v0D();
		foreach (UIElement item in uIElementCollection)
		{
			if (item is ju ju2)
			{
				ju2.geL(vAD as EditorView);
			}
			item.Arrange(finalRect);
		}
		Size size = P_0;
		int num = 0;
		if (c02() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		return num switch
		{
			_ => size, 
		};
	}

	public MTG dlN(string P_0)
	{
		foreach (MTG item in GAf)
		{
			if (item.Key == P_0)
			{
				return item;
			}
		}
		return null;
	}

	public MTG sld(string P_0, Lazy<MTG> P_1)
	{
		MTG mTG = dlN(P_0);
		if (mTG == null && P_1 != null)
		{
			mTG = P_1.Value;
			if (mTG != null)
			{
				clZ(mTG);
			}
		}
		return mTG;
	}

	[SpecialName]
	public IList<MTG> WAc()
	{
		return GAf;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new EditorViewTextAreaAutomationPeer(this);
	}

	private FrameworkElement zlz()
	{
		return this;
	}

	private void FAW()
	{
		base.Background = Brushes.Transparent;
		iAP();
	}

	private void iAP()
	{
		FrameworkElement frameworkElement = zlz();
		Cursor cursor = FAg ?? (GAQ ? Cursors.Arrow : Cursors.IBeam);
		vAE.P01(frameworkElement, cursor);
	}

	protected override Size MeasureOverride(Size P_0)
	{
		Size result = default(Size);
		foreach (UIElement child in base.Children)
		{
			child.Measure(P_0);
			result.Width = Math.Max(result.Width, child.DesiredSize.Width);
			result.Height = Math.Max(result.Height, child.DesiredSize.Height);
		}
		if (!(vAD is EditorView editorView) || !editorView.gft())
		{
			goto IL_0176;
		}
		if (editorView.SyntaxEditor.IsLoaded)
		{
			goto IL_010e;
		}
		goto IL_022f;
		IL_011e:
		result.Height = Math.Min(P_0.Height, result.Height);
		goto IL_0176;
		IL_0176:
		return result;
		IL_010e:
		result = editorView.Xf3(P_0);
		Thickness textAreaPadding = editorView.TextAreaPadding;
		result.Height += textAreaPadding.Top + textAreaPadding.Bottom;
		goto IL_022f;
		IL_022f:
		if (!double.IsPositiveInfinity(P_0.Width))
		{
			result.Width = Math.Min(P_0.Width, result.Width);
		}
		if (!double.IsPositiveInfinity(P_0.Height))
		{
			int num = 0;
			if (c02() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_011e;
			}
			goto IL_010e;
		}
		goto IL_0176;
	}

	public void XAE(Cursor P_0)
	{
		FAg = P_0;
		iAP();
	}

	internal static bool s0i()
	{
		return j0f == null;
	}

	internal static nR c02()
	{
		return j0f;
	}
}
