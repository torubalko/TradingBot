using System;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Internal;

internal class FAi : CanvasControl
{
	private TextView LHR;

	private static FAi AWa;

	public FAi(TextView P_0)
	{
		grA.DaB7cz();
		base._002Ector(P_0 is IPrinterView);
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		LHR = P_0;
	}

	protected override CanvasDrawContext CreateDrawContext(ICanvas P_0, DrawingContext P_1, Rect P_2)
	{
		return new TextViewDrawContext(LHR, P_0, P_1, P_2);
	}

	internal static bool tWL()
	{
		return AWa == null;
	}

	internal static FAi LWg()
	{
		return AWa;
	}
}
