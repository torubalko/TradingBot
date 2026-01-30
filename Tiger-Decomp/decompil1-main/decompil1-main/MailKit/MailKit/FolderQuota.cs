namespace MailKit;

public class FolderQuota
{
	public IMailFolder QuotaRoot { get; private set; }

	public uint? MessageLimit { get; set; }

	public uint? StorageLimit { get; set; }

	public uint? CurrentMessageCount { get; set; }

	public uint? CurrentStorageSize { get; set; }

	public FolderQuota(IMailFolder quotaRoot)
	{
		QuotaRoot = quotaRoot;
	}
}
