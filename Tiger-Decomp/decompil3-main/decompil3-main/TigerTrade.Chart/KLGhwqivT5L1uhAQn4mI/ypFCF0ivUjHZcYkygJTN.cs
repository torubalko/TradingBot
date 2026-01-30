using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using DQ3RIRilFbsKdQctor4q;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Dx;

namespace KLGhwqivT5L1uhAQn4mI;

[ChartObject("Marker", "ChartObjectsMarker", 2, Type = typeof(ypFCF0ivUjHZcYkygJTN))]
[DataContract(Name = "MarkerObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public sealed class ypFCF0ivUjHZcYkygJTN : LineObjectBase
{
	private int TeJiB0FDADo;

	private Point[] Cq3iB2XU8bs;

	private Point[] zGSiBHXWk8F;

	private Rect nKWiBfrSohl;

	private ObjectPoint QgPiB9BQDh2;

	private ObjectPoint gXZiBnwk4Zc;

	private ObjectPoint[] qaUiBGl3Lha;

	private ObjectPoint nJKiBY2yxEu;

	private ObjectPoint fgHiBog5fOT;

	internal static ypFCF0ivUjHZcYkygJTN rNBbINLusjp9VkXic9Ej;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	public override bool SnapGrid => false;

	[DataMember(Name = "TopLeft")]
	[Browsable(false)]
	public ObjectPoint TopLeft
	{
		get
		{
			return QgPiB9BQDh2;
		}
		set
		{
			QgPiB9BQDh2 = qgPiB9BQDh;
		}
	}

	[Browsable(false)]
	[DataMember(Name = "BottomRight")]
	public ObjectPoint BottomRight
	{
		get
		{
			return gXZiBnwk4Zc;
		}
		set
		{
			gXZiBnwk4Zc = objectPoint;
		}
	}

	[DataMember(Name = "BasePoints")]
	[Browsable(false)]
	public ObjectPoint[] cPaivJNCA2c
	{
		get
		{
			return qaUiBGl3Lha;
		}
		set
		{
			qaUiBGl3Lha = array;
		}
	}

	[DataMember(Name = "PointsData")]
	[Browsable(false)]
	public string DU6ivpVtLtH
	{
		get
		{
			return VpSivyBdBw9();
		}
		set
		{
			aEcivZUvL4f(text);
		}
	}

	public ypFCF0ivUjHZcYkygJTN()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		Cq3iB2XU8bs = new Point[16384];
		zGSiBHXWk8F = new Point[16384];
		nKWiBfrSohl = Rect.Empty;
		qaUiBGl3Lha = new ObjectPoint[2];
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private string VpSivyBdBw9()
	{
		using MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(TeJiB0FDADo);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 != 0)
		{
			num = 0;
		}
		int num2 = default(int);
		Point point = default(Point);
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				if (num2 >= TeJiB0FDADo)
				{
					binaryWriter.Flush();
					memoryStream.Flush();
					return Convert.ToBase64String(memoryStream.ToArray());
				}
				goto case 1;
			case 1:
			{
				point = zGSiBHXWk8F[num2];
				int num3 = 4;
				num = num3;
				break;
			}
			case 4:
				binaryWriter.Write(point.X);
				binaryWriter.Write(point.Y);
				num2++;
				num = 2;
				break;
			default:
				num2 = 0;
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 == 0)
				{
					num = 3;
				}
				break;
			}
		}
	}

	private void aEcivZUvL4f(string P_0)
	{
		using MemoryStream input = new MemoryStream(Convert.FromBase64String(P_0));
		BinaryReader binaryReader = new BinaryReader(input);
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 1:
				zGSiBHXWk8F[num2].Y = binaryReader.ReadDouble();
				num2++;
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd == 0)
				{
					num = 0;
				}
				continue;
			case 3:
				TeJiB0FDADo = u4FFyALujGxDGP8qUMgC(binaryReader);
				zGSiBHXWk8F = new Point[TeJiB0FDADo];
				Cq3iB2XU8bs = new Point[TeJiB0FDADo];
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 == 0)
				{
					num = 0;
				}
				continue;
			default:
				num2 = 0;
				break;
			case 2:
				break;
			}
			if (num2 >= TeJiB0FDADo)
			{
				break;
			}
			zGSiBHXWk8F[num2].X = binaryReader.ReadDouble();
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
			{
				num = 1;
			}
		}
	}

	public override void ControlPointEditing(int P_0)
	{
		int num = 3;
		int num2 = num;
		Point point = default(Point);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
			{
				int num3 = 1 - P_0;
				base.ControlPoints[num3] = aaUivCqe8pv(cPaivJNCA2c[num3], point.X, point.Y);
				QgPiB9BQDh2 = aaUivCqe8pv(QgPiB9BQDh2, point.X, point.Y);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 3:
				if (!InSetup)
				{
					point = AjJivViIyEB(base.ControlPoints[P_0], cPaivJNCA2c[P_0]);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 2;
				}
				break;
			default:
				gXZiBnwk4Zc = aaUivCqe8pv(gXZiBnwk4Zc, point.X, point.Y);
				cPaivJNCA2c[0] = base.ControlPoints[0];
				cPaivJNCA2c[1] = base.ControlPoints[1];
				return;
			}
		}
	}

	public override void BeginDrag()
	{
		nJKiBY2yxEu = QgPiB9BQDh2;
		fgHiBog5fOT = gXZiBnwk4Zc;
		base.BeginDrag();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override void ControlPointsChanged()
	{
		E84ER7LuEbbRy69ZshCm(this, 0);
		base.ControlPointsChanged();
	}

	public override void DragObject(double P_0, double P_1)
	{
		QgPiB9BQDh2 = aaUivCqe8pv(nJKiBY2yxEu, P_0, P_1);
		gXZiBnwk4Zc = aaUivCqe8pv(fgHiBog5fOT, P_0, P_1);
		cPaivJNCA2c[0] = base.ControlPoints[0];
		cPaivJNCA2c[1] = base.ControlPoints[1];
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private Point AjJivViIyEB(ObjectPoint P_0, ObjectPoint P_1)
	{
		Point point = ToPoint(P_0);
		Point point2 = ToPoint(P_1);
		return new Point(point.X - point2.X, point.Y - point2.Y);
	}

	private ObjectPoint aaUivCqe8pv(ObjectPoint P_0, double P_1, double P_2)
	{
		Point point = ToPoint(P_0);
		Point valueFromPos = base.Canvas.GetValueFromPos(point.X + P_1, point.Y + P_2, snapToGrid: false);
		return new ObjectPoint(valueFromPos.X, valueFromPos.Y);
	}

	private void uGFivrrACGj()
	{
		int num = 10;
		int num2 = num;
		double num4 = default(double);
		double y = default(double);
		int num5 = default(int);
		Point point = default(Point);
		double num3 = default(double);
		double x = default(double);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num4 = y;
				num2 = 3;
				break;
			case 5:
			case 7:
				num5++;
				goto case 4;
			case 4:
				if (num5 >= TeJiB0FDADo)
				{
					num2 = 6;
					break;
				}
				point = zGSiBHXWk8F[num5];
				if (point.X > num3)
				{
					num3 = point.X;
					goto IL_0184;
				}
				goto default;
			case 3:
				num5 = 0;
				num2 = 4;
				break;
			case 10:
				if (!InSetup)
				{
					num2 = 9;
					break;
				}
				return;
			case 9:
				if (CflyduLuQ31h9PeSmE1O(nKWiBfrSohl, Rect.Empty) && nKWiBfrSohl.Width != 0.0 && nKWiBfrSohl.Height != 0.0)
				{
					return;
				}
				x = zGSiBHXWk8F[0].X;
				num2 = 8;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd != 0)
				{
					num2 = 6;
				}
				break;
			case 2:
				y = zGSiBHXWk8F[0].Y;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 != 0)
				{
					num2 = 1;
				}
				break;
			case 11:
				num4 = point.Y;
				num2 = 7;
				break;
			case 8:
				num3 = x;
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 != 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				nKWiBfrSohl = new Rect(x, y, num3 - x, num4 - y);
				return;
			default:
				{
					if (point.X < x)
					{
						x = point.X;
					}
					goto IL_0184;
				}
				IL_0184:
				if (point.Y > num4)
				{
					num2 = 11;
					break;
				}
				if (point.Y < y)
				{
					y = point.Y;
					num2 = 5;
					break;
				}
				goto case 5;
			}
		}
	}

	private void NxnivKqimtA()
	{
		Point point = default(Point);
		int num;
		if (!InSetup)
		{
			uGFivrrACGj();
			point = ToPoint(QgPiB9BQDh2);
			num = 5;
			goto IL_0009;
		}
		int num2 = 0;
		goto IL_01ca;
		IL_01ca:
		if (num2 < TeJiB0FDADo)
		{
			Cq3iB2XU8bs[num2] = zGSiBHXWk8F[num2];
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f77fe62e8d47b39673b4a8ce5cbdc5 != 0)
			{
				num = 1;
			}
		}
		else
		{
			num = 6;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 != 0)
			{
				num = 3;
			}
		}
		goto IL_0009;
		IL_0009:
		int num3 = default(int);
		Point point2 = default(Point);
		while (true)
		{
			switch (num)
			{
			case 2:
				num3 = 0;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 == 0)
				{
					num = 0;
				}
				continue;
			case 6:
				return;
			case 5:
				point2 = ToPoint(gXZiBnwk4Zc);
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 == 0)
				{
					num = 2;
				}
				continue;
			case 3:
				num3++;
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff != 0)
				{
					num = 1;
				}
				continue;
			default:
				if (num3 >= TeJiB0FDADo)
				{
					return;
				}
				Cq3iB2XU8bs[num3].X = point.X + (zGSiBHXWk8F[num3].X - nKWiBfrSohl.Left) * (point2.X - point.X) / nKWiBfrSohl.Width;
				Cq3iB2XU8bs[num3].Y = point.Y + (zGSiBHXWk8F[num3].Y - nKWiBfrSohl.Top) * (point2.Y - point.Y) / nKWiBfrSohl.Height;
				num = 3;
				continue;
			case 1:
				break;
			}
			break;
		}
		num2++;
		goto IL_01ca;
	}

	protected override void Draw(DxVisualQueue P_0, ref List<ObjectLabelInfo> P_1)
	{
		NxnivKqimtA();
		zCiCoRLudtg3DqfkQGks(P_0, base.LinePen, Cq3iB2XU8bs, TeJiB0FDADo);
	}

	protected override bool IsObjectOnChart()
	{
		return true;
	}

	public override void DrawControlPoints(DxVisualQueue P_0)
	{
		if (base.Canvas == null)
		{
			return;
		}
		int num = 0;
		while (num < base.ControlPoints.Length)
		{
			while (true)
			{
				DrawControlPoint(P_0, ToPoint(base.ControlPoints[num]));
				num++;
				int num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
				{
					num2 = 1;
				}
				switch (num2)
				{
				case 1:
					break;
				default:
					continue;
				}
				break;
			}
		}
	}

	protected override bool InObject(int P_0, int P_1)
	{
		int num = 1;
		int num2 = num;
		int i = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return false;
			case 1:
				i = 0;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5d6485f66cb24fc09096e66798254c7f != 0)
				{
					num2 = 0;
				}
				continue;
			}
			for (; i < TeJiB0FDADo - 1; i++)
			{
				if (mWMAq1LugwQCIGF6UOFI(P_0, P_1, Cq3iB2XU8bs[i], Cq3iB2XU8bs[i + 1], base.LineWidth + 2))
				{
					return true;
				}
			}
			num2 = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c == 0)
			{
				num2 = 2;
			}
		}
	}

	public void VNXivmA0XGp(ObjectPoint P_0)
	{
		if (!InSetup)
		{
			return;
		}
		int num;
		if (TeJiB0FDADo == zGSiBHXWk8F.Length)
		{
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_0235;
		IL_003f:
		zGSiBHXWk8F[TeJiB0FDADo] = ToPoint(P_0);
		num = 6;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 != 0)
		{
			num = 3;
		}
		goto IL_0009;
		IL_01c5:
		Array.Resize(ref zGSiBHXWk8F, zGSiBHXWk8F.Length * 2);
		goto IL_0235;
		IL_0235:
		if (TeJiB0FDADo == 0)
		{
			cPaivJNCA2c[0] = base.ControlPoints[0];
			zGSiBHXWk8F[TeJiB0FDADo] = ToPoint(base.ControlPoints[0]);
			TeJiB0FDADo++;
			QgPiB9BQDh2.X = base.ControlPoints[0].X;
			num = 9;
			goto IL_0009;
		}
		goto IL_003f;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 6:
				if (P_0.X > gXZiBnwk4Zc.X)
				{
					gXZiBnwk4Zc.X = P_0.X;
				}
				if (P_0.X < QgPiB9BQDh2.X)
				{
					QgPiB9BQDh2.X = P_0.X;
					num = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 == 0)
					{
						num = 4;
					}
					continue;
				}
				goto case 4;
			case 4:
				if (P_0.Y > QgPiB9BQDh2.Y)
				{
					num = 9;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 == 0)
					{
						num = 10;
					}
					continue;
				}
				goto case 2;
			case 2:
				if (P_0.Y < gXZiBnwk4Zc.Y)
				{
					gXZiBnwk4Zc.Y = P_0.Y;
				}
				base.ControlPoints[1] = P_0;
				cPaivJNCA2c[1] = P_0;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 != 0)
				{
					num = 1;
				}
				continue;
			case 5:
				goto IL_01c5;
			case 9:
				QgPiB9BQDh2.Y = base.ControlPoints[0].Y;
				gXZiBnwk4Zc = QgPiB9BQDh2;
				num = 3;
				continue;
			default:
				if (zGSiBHXWk8F.Length < 2097152)
				{
					num = 7;
					continue;
				}
				return;
			case 8:
				return;
			case 7:
				Array.Resize(ref Cq3iB2XU8bs, zGSiBHXWk8F.Length * 2);
				num = 5;
				continue;
			case 1:
				TeJiB0FDADo++;
				num = 8;
				continue;
			case 10:
			{
				QgPiB9BQDh2.Y = P_0.Y;
				int num2 = 2;
				num = num2;
				continue;
			}
			}
			break;
		}
		goto IL_003f;
	}

	static ypFCF0ivUjHZcYkygJTN()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool uw6yITLuXuBXWRNSPxSw()
	{
		return rNBbINLusjp9VkXic9Ej == null;
	}

	internal static ypFCF0ivUjHZcYkygJTN unpcb8Luc0hnTO6T6wTW()
	{
		return rNBbINLusjp9VkXic9Ej;
	}

	internal static int u4FFyALujGxDGP8qUMgC(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt32();
	}

	internal static void E84ER7LuEbbRy69ZshCm(object P_0, int index)
	{
		((ObjectBase)P_0).ControlPointEditing(index);
	}

	internal static bool CflyduLuQ31h9PeSmE1O(Rect P_0, Rect P_1)
	{
		return P_0 != P_1;
	}

	internal static void zCiCoRLudtg3DqfkQGks(object P_0, object P_1, object P_2, int P_3)
	{
		((DxVisualQueue)P_0).DrawLines((XPen)P_1, (Point[])P_2, P_3);
	}

	internal static bool mWMAq1LugwQCIGF6UOFI(int P_0, int P_1, Point P_2, Point P_3, int P_4)
	{
		return XyaVo8ilJa9AfK2KZEye.yd5ilujJMuv(P_0, P_1, P_2, P_3, P_4);
	}
}
