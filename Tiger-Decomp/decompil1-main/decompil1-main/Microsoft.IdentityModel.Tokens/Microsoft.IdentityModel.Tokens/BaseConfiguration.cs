using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.IdentityModel.Tokens;

public abstract class BaseConfiguration
{
	public virtual string Issuer { get; set; }

	public virtual ICollection<SecurityKey> SigningKeys { get; } = new Collection<SecurityKey>();
}
