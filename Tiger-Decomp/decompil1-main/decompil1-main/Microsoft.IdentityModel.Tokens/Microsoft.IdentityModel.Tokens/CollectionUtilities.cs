using System.Collections.Generic;
using System.Linq;

namespace Microsoft.IdentityModel.Tokens;

public static class CollectionUtilities
{
	public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
	{
		if (enumerable != null)
		{
			return !enumerable.Any();
		}
		return true;
	}
}
