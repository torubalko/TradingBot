using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Internal;

internal class zTB
{
	private int kRk;

	private Brush bRS;

	private CaretKind vR9;

	private int kRy;

	private CaretKind wRq;

	private int wR2;

	private TextPosition? DR7;

	private bool gRi;

	private bool sRp;

	private bool eRM;

	private BTZ TRO;

	private bool NRU;

	private SyntaxEditor kRJ;

	private static zTB OAL;

	public Brush CaretBrush
	{
		get
		{
			qRY();
			return bRS;
		}
	}

	public bool IsOverwriteModeActive
	{
		get
		{
			qRY();
			return gRi;
		}
	}

	public zTB(SyntaxEditor P_0)
	{
		grA.DaB7cz();
		kRk = 500;
		vR9 = CaretKind.VerticalLine;
		kRy = 1;
		wRq = CaretKind.Block;
		wR2 = 1;
		base._002Ector();
		if (P_0 == null)
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
				throw new ArgumentNullException(Q7Z.tqM(8238));
			}
		}
		kRJ = P_0;
		TRO = P_0.FGR().PLW(Q7Z.tqM(192886), ER4);
	}

	private void qRY()
	{
		if (!sRp)
		{
			bRS = kRJ.CaretBrush;
			if (bRS == null)
			{
				bRS = (kRJ.ActiveView.IsDefaultBackgroundColorLight ? Brushes.Black : Brushes.White);
			}
			kRk = Math.Max(0, kRJ.CaretBlinkInterval);
			vR9 = kRJ.CaretInsertKind;
			kRy = kRJ.CaretInsertWidth;
			wRq = kRJ.CaretOverwriteKind;
			wR2 = kRJ.CaretOverwriteWidth;
			gRi = kRJ.IsOverwriteModeActive;
			sRp = true;
		}
	}

	private void ER4()
	{
		if (NRU)
		{
			NRU = false;
			TRO.Stop();
			return;
		}
		xRr(!jRV());
		if (kRk > 0)
		{
			TRO.Start(kRk);
		}
	}

	private void FRo()
	{
		NRU = false;
		if (kRk <= 0 || !vAE.E0C(kRJ.ActiveView))
		{
			TRO.Stop();
		}
		else
		{
			TRO.Start(kRk);
		}
	}

	[SpecialName]
	public TextPosition? dR8()
	{
		return DR7;
	}

	public Rect XRj(ITextViewLine P_0, TextPosition P_1)
	{
		qRY();
		TextBounds textBounds = P_0.GetCharacterBounds(P_1);
		CaretKind caretKind = (gRi ? wRq : vR9);
		int num = Math.Max(1, Math.Min(8, gRi ? wR2 : kRy));
		if (num == 1)
		{
			double num2 = Math.Max(0.25, P_0.View.ZoomLevel);
			if (num2 < 1.0)
			{
				num = (int)Math.Ceiling((double)num / num2);
			}
		}
		if (caretKind == CaretKind.VerticalLine && P_1.Character > 0 && P_1 <= P_0.EndPosition)
		{
			TextBounds characterBounds = P_0.GetCharacterBounds(new TextPosition(P_1.Line, P_1.Character - 1));
			if (characterBounds.IsYValid && textBounds.IsRightToLeft != characterBounds.IsRightToLeft)
			{
				textBounds = new TextBounds(characterBounds.Rect, textBounds.IsRightToLeft);
			}
		}
		Rect result = caretKind switch
		{
			CaretKind.Block => new Rect(textBounds.X, 0.0, textBounds.Width, textBounds.Height), 
			CaretKind.HorizontalUnderline => new Rect(textBounds.X, textBounds.Height - (double)num, textBounds.Width, num), 
			_ => (!textBounds.IsLeftToRight) ? new Rect(textBounds.Right - (double)num, 0.0, num, textBounds.Height) : new Rect(textBounds.X, 0.0, num, textBounds.Height), 
		};
		result.X = Math.Round(result.X, MidpointRounding.AwayFromZero);
		result.Width = Math.Round(result.Width, MidpointRounding.AwayFromZero);
		return result;
	}

	public void cRw(bool P_0)
	{
		if (DR7.HasValue)
		{
			DR7 = null;
			kRJ.SGx((vTP)32);
		}
		GRL(_0020: false);
		if (P_0 && kRJ.ActiveView.HasFocus)
		{
			XRH();
		}
	}

	public void bR6()
	{
		bRS = null;
		sRp = false;
	}

	[SpecialName]
	public bool GR5()
	{
		return !NRU && TRO.IsEnabled;
	}

	[SpecialName]
	public bool jRV()
	{
		return eRM;
	}

	[SpecialName]
	private void xRr(bool P_0)
	{
		if (eRM != P_0)
		{
			eRM = P_0;
			kRJ.SGx((vTP)16);
		}
	}

	public void XRH()
	{
		xRr(_0020: true);
		FRo();
	}

	public void jRb()
	{
		if (GR5())
		{
			XRH();
		}
	}

	public void uRT(TextPosition P_0)
	{
		if (DR7 != P_0)
		{
			DR7 = P_0;
			kRJ.SGx((vTP)32);
		}
		GRL(_0020: true);
	}

	public void GRL(bool P_0)
	{
		NRU = true;
		xRr(P_0);
	}

	internal static bool CAg()
	{
		return OAL == null;
	}

	internal static zTB zAA()
	{
		return OAL;
	}
}
