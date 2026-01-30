using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using ActiproSoftware.Text;

namespace ActiproSoftware.Internal;

internal class sAD : kAk
{
	internal static sAD oGW;

	public override string DataFormat => DataFormats.Html;

	public override string Export(ITextSnapshot P_0, ICollection<TextRange> P_1)
	{
		string value = Q7Z.tqM(199796);
		string text = Q7Z.tqM(200090);
		string value2 = Q7Z.tqM(200144) + text + Q7Z.tqM(200314);
		string value3 = Q7Z.tqM(200400);
		string value4 = string.Format(CultureInfo.InvariantCulture, Q7Z.tqM(200468), new object[1] { base.Export(P_0, P_1) });
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(value);
		int length = stringBuilder.Length;
		stringBuilder.Append(value2);
		int length2 = stringBuilder.Length;
		stringBuilder.Append(value4);
		int length3 = stringBuilder.Length;
		stringBuilder.Append(value3);
		int length4 = stringBuilder.Length;
		stringBuilder.Replace(Q7Z.tqM(200500), string.Format(CultureInfo.InvariantCulture, Q7Z.tqM(200520), new object[1] { length }));
		stringBuilder.Replace(Q7Z.tqM(200536), string.Format(CultureInfo.InvariantCulture, Q7Z.tqM(200520), new object[1] { length4 }));
		stringBuilder.Replace(Q7Z.tqM(200556), string.Format(CultureInfo.InvariantCulture, Q7Z.tqM(200520), new object[1] { length2 }));
		stringBuilder.Replace(Q7Z.tqM(200576), string.Format(CultureInfo.InvariantCulture, Q7Z.tqM(200520), new object[1] { length3 }));
		return stringBuilder.ToString();
	}

	public sAD()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool SGS()
	{
		return oGW == null;
	}

	internal static sAD xGk()
	{
		return oGW;
	}
}
