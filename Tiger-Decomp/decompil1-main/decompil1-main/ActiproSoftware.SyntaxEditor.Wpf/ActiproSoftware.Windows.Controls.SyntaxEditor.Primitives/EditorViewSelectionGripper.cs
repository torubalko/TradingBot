using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
public class EditorViewSelectionGripper : Control
{
	private InputAdapter NQW;

	private DateTime OQP;

	private Point nQE;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DateTime KQc;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Point YQa;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool UQx;

	internal static EditorViewSelectionGripper LBO;

	internal Point Location
	{
		[CompilerGenerated]
		get
		{
			return YQa;
		}
		[CompilerGenerated]
		set
		{
			YQa = value;
		}
	}

	public bool IsForSelectionEnd
	{
		[CompilerGenerated]
		get
		{
			return UQx;
		}
		[CompilerGenerated]
		internal set
		{
			UQx = value;
		}
	}

	public EditorViewSelectionGripper()
	{
		grA.DaB7cz();
		OQP = EditorView.LDA;
		base._002Ector();
		base.DefaultStyleKey = typeof(EditorViewSelectionGripper);
		ygO();
		vgZ(DateTime.Now);
	}

	private void ygO()
	{
		NQW = new InputAdapter(this);
		NQW.PointerPressed += HgJ;
		NQW.AttachedEventKinds = InputAdapterEventKinds.PointerPressed;
	}

	internal static bool tgU(InputPointerEventArgs P_0)
	{
		return P_0.DeviceKind == InputDeviceKind.Touch;
	}

	[SpecialName]
	[CompilerGenerated]
	internal DateTime zgt()
	{
		return KQc;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void vgZ(DateTime value)
	{
		KQc = value;
	}

	private void HgJ(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 == null || P_1.Handled)
		{
			return;
		}
		int num = 0;
		if (UB5() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		EditorView ancestor = default(EditorView);
		do
		{
			Point position;
			switch (num)
			{
			default:
				P_1.Handled = true;
				position = P_1.GetPosition(this);
				ancestor = VisualTreeHelperExtended.GetAncestor<EditorView>(this);
				if (ancestor == null)
				{
					return;
				}
				if (tgU(P_1))
				{
					if (!P_1.IsPrimaryButton)
					{
						return;
					}
					if (vAE.L0A(nQE, position, OQP, DateTime.Now, P_1.DeviceKind == InputDeviceKind.Touch))
					{
						ancestor.Selection.SelectWord();
						OQP = EditorView.LDA;
						return;
					}
					break;
				}
				goto case 2;
			case 2:
				ancestor.DDX(value: false);
				return;
			case 1:
				OQP = DateTime.Now;
				return;
			}
			double num3 = base.DesiredSize.Height - base.Padding.Top - base.Padding.Bottom;
			Point point = new Point(base.DesiredSize.Width / 2.0 - position.X, base.Padding.Top - num3 / 2.0 - position.Y);
			ancestor.SfB(P_1, IsForSelectionEnd, point);
			nQE = position;
			num = 1;
		}
		while (DB1());
		goto IL_0005;
	}

	internal static bool DB1()
	{
		return LBO == null;
	}

	internal static EditorViewSelectionGripper UB5()
	{
		return LBO;
	}
}
