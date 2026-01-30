namespace MailKit;

public interface ITransferProgress
{
	void Report(long bytesTransferred, long totalSize);

	void Report(long bytesTransferred);
}
