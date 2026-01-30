using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Internal;

internal class YA0 : LAu
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public YA0 PkW;

		public UIElement LkP;

		private static _003C_003Ec__DisplayClass4_0 xMb;

		public _003C_003Ec__DisplayClass4_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void osz()
		{
			PkW.C6i.Children.Remove(LkP);
		}

		internal static bool bMs()
		{
			return xMb == null;
		}

		internal static _003C_003Ec__DisplayClass4_0 pMP()
		{
			return xMb;
		}
	}

	private ju C6i;

	private static YA0 Ilu;

	public override UIElement VisualElement => C6i;

	public YA0()
	{
		grA.DaB7cz();
		base._002Ector(AdornmentLayerDefinitions.OverlayPanes.Key, AdornmentLayerDefinitions.OverlayPanes.Orderings);
		C6i = new ju();
	}

	public void u62(IOverlayPane P_0)
	{
		UIElement visualElement = P_0.VisualElement;
		if (visualElement != null)
		{
			C6i.Children.Add(visualElement);
			ju.yen(visualElement, _0020: true, null);
			visualElement.UpdateLayout();
		}
	}

	public override void Draw(TextViewDrawContext P_0)
	{
	}

	public void u67(IOverlayPane P_0)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals6.PkW = this;
		CS_0024_003C_003E8__locals6.LkP = P_0.VisualElement;
		if (CS_0024_003C_003E8__locals6.LkP != null)
		{
			ju.yen(CS_0024_003C_003E8__locals6.LkP, _0020: false, delegate
			{
				CS_0024_003C_003E8__locals6.PkW.C6i.Children.Remove(CS_0024_003C_003E8__locals6.LkP);
			});
		}
	}

	internal static bool sl8()
	{
		return Ilu == null;
	}

	internal static YA0 ClU()
	{
		return Ilu;
	}
}
