using System;
using System.Runtime.Serialization;

namespace MailKit;

[Serializable]
public class FolderNotOpenException : InvalidOperationException
{
	public string FolderName { get; private set; }

	public FolderAccess FolderAccess { get; private set; }

	protected FolderNotOpenException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		string value = info.GetString("FolderAccess");
		if (!Enum.TryParse<FolderAccess>(value, out var result))
		{
			FolderAccess = FolderAccess.ReadOnly;
		}
		else
		{
			FolderAccess = result;
		}
		FolderName = info.GetString("FolderName");
	}

	public FolderNotOpenException(string folderName, FolderAccess access, string message, Exception innerException)
		: base(message, innerException)
	{
		if (folderName == null)
		{
			throw new ArgumentNullException("folderName");
		}
		FolderName = folderName;
		FolderAccess = access;
	}

	public FolderNotOpenException(string folderName, FolderAccess access, string message)
		: base(message)
	{
		if (folderName == null)
		{
			throw new ArgumentNullException("folderName");
		}
		FolderName = folderName;
		FolderAccess = access;
	}

	public FolderNotOpenException(string folderName, FolderAccess access)
		: this(folderName, access, GetDefaultMessage(access))
	{
	}

	private static string GetDefaultMessage(FolderAccess access)
	{
		if (access == FolderAccess.ReadWrite)
		{
			return "The folder is not currently open in read-write mode.";
		}
		return "The folder is not currently open.";
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("FolderAccess", FolderAccess.ToString());
		info.AddValue("FolderName", FolderName);
	}
}
