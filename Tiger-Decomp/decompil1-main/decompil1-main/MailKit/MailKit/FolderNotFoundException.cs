using System;
using System.Runtime.Serialization;
using System.Security;

namespace MailKit;

[Serializable]
public class FolderNotFoundException : Exception
{
	public string FolderName { get; private set; }

	protected FolderNotFoundException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		FolderName = info.GetString("FolderName");
	}

	public FolderNotFoundException(string message, string folderName, Exception innerException)
		: base(message, innerException)
	{
		if (folderName == null)
		{
			throw new ArgumentNullException("folderName");
		}
		FolderName = folderName;
	}

	public FolderNotFoundException(string message, string folderName)
		: base(message)
	{
		if (folderName == null)
		{
			throw new ArgumentNullException("folderName");
		}
		FolderName = folderName;
	}

	public FolderNotFoundException(string folderName)
		: this("The requested folder could not be found.", folderName)
	{
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("FolderName", FolderName);
	}
}
