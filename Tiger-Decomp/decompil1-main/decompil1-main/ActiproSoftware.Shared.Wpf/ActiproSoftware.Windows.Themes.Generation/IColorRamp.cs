using System.Collections;
using System.Collections.Generic;

namespace ActiproSoftware.Windows.Themes.Generation;

public interface IColorRamp : IEnumerable<IColorRampShade>, IEnumerable
{
	IColorRampShade Base { get; }

	IColorRampShade Darkest { get; }

	ColorFamilyName FamilyName { get; }

	string Name { get; }

	IColorRampShade this[ShadeName shadeName] { get; }

	IColorRampShade GetShade(int shadeNumber);
}
