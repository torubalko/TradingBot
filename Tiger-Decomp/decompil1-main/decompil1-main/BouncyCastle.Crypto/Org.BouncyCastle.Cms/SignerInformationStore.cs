using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms;

public class SignerInformationStore
{
	private readonly IList all;

	private readonly IDictionary table = Platform.CreateHashtable();

	public int Count => all.Count;

	public SignerInformationStore(SignerInformation signerInfo)
	{
		all = Platform.CreateArrayList(1);
		all.Add(signerInfo);
		SignerID sid = signerInfo.SignerID;
		table[sid] = all;
	}

	public SignerInformationStore(ICollection signerInfos)
	{
		foreach (SignerInformation signer in signerInfos)
		{
			SignerID sid = signer.SignerID;
			IList list = (IList)table[sid];
			if (list == null)
			{
				list = (IList)(table[sid] = Platform.CreateArrayList(1));
			}
			list.Add(signer);
		}
		all = Platform.CreateArrayList(signerInfos);
	}

	public SignerInformation GetFirstSigner(SignerID selector)
	{
		IList list = (IList)table[selector];
		if (list != null)
		{
			return (SignerInformation)list[0];
		}
		return null;
	}

	public ICollection GetSigners()
	{
		return Platform.CreateArrayList(all);
	}

	public ICollection GetSigners(SignerID selector)
	{
		IList list = (IList)table[selector];
		if (list != null)
		{
			return Platform.CreateArrayList(list);
		}
		return Platform.CreateArrayList();
	}
}
