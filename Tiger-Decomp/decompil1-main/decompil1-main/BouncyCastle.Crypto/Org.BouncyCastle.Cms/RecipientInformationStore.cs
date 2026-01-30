using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms;

public class RecipientInformationStore
{
	private readonly IList all;

	private readonly IDictionary table = Platform.CreateHashtable();

	public RecipientInformation this[RecipientID selector] => GetFirstRecipient(selector);

	public int Count => all.Count;

	public RecipientInformationStore(ICollection recipientInfos)
	{
		foreach (RecipientInformation recipientInformation in recipientInfos)
		{
			RecipientID rid = recipientInformation.RecipientID;
			IList list = (IList)table[rid];
			if (list == null)
			{
				list = (IList)(table[rid] = Platform.CreateArrayList(1));
			}
			list.Add(recipientInformation);
		}
		all = Platform.CreateArrayList(recipientInfos);
	}

	public RecipientInformation GetFirstRecipient(RecipientID selector)
	{
		IList list = (IList)table[selector];
		if (list != null)
		{
			return (RecipientInformation)list[0];
		}
		return null;
	}

	public ICollection GetRecipients()
	{
		return Platform.CreateArrayList(all);
	}

	public ICollection GetRecipients(RecipientID selector)
	{
		IList list = (IList)table[selector];
		if (list != null)
		{
			return Platform.CreateArrayList(list);
		}
		return Platform.CreateArrayList();
	}
}
