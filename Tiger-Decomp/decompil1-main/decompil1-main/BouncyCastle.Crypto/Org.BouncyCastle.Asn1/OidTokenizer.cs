namespace Org.BouncyCastle.Asn1;

public class OidTokenizer
{
	private string oid;

	private int index;

	public bool HasMoreTokens => index != -1;

	public OidTokenizer(string oid)
	{
		this.oid = oid;
	}

	public string NextToken()
	{
		if (index == -1)
		{
			return null;
		}
		int end = oid.IndexOf('.', index);
		if (end == -1)
		{
			string result = oid.Substring(index);
			index = -1;
			return result;
		}
		string result2 = oid.Substring(index, end - index);
		index = end + 1;
		return result2;
	}
}
