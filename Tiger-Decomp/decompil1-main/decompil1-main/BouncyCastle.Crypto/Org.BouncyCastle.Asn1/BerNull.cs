using System;

namespace Org.BouncyCastle.Asn1;

[Obsolete("Use 'DerNull' instead")]
public class BerNull : DerNull
{
	[Obsolete("Use 'DerNull.Instance' instead")]
	public new static readonly BerNull Instance = new BerNull();

	private BerNull()
	{
	}
}
