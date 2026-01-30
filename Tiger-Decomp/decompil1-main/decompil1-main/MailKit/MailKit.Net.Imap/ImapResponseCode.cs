namespace MailKit.Net.Imap;

internal class ImapResponseCode
{
	public readonly ImapResponseCodeType Type;

	public bool IsTagged;

	public bool IsError;

	public string Message;

	internal ImapResponseCode(ImapResponseCodeType type, bool isError)
	{
		IsError = isError;
		Type = type;
	}

	public static ImapResponseCode Create(ImapResponseCodeType type)
	{
		return type switch
		{
			ImapResponseCodeType.Alert => new ImapResponseCode(type, isError: false), 
			ImapResponseCodeType.BadCharset => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.Capability => new ImapResponseCode(type, isError: false), 
			ImapResponseCodeType.NewName => new NewNameResponseCode(type), 
			ImapResponseCodeType.Parse => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.PermanentFlags => new PermanentFlagsResponseCode(type), 
			ImapResponseCodeType.ReadOnly => new ImapResponseCode(type, isError: false), 
			ImapResponseCodeType.ReadWrite => new ImapResponseCode(type, isError: false), 
			ImapResponseCodeType.TryCreate => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.UidNext => new UidNextResponseCode(type), 
			ImapResponseCodeType.UidValidity => new UidValidityResponseCode(type), 
			ImapResponseCodeType.Unseen => new UnseenResponseCode(type), 
			ImapResponseCodeType.Referral => new ImapResponseCode(type, isError: false), 
			ImapResponseCodeType.UnknownCte => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.AppendUid => new AppendUidResponseCode(type), 
			ImapResponseCodeType.CopyUid => new CopyUidResponseCode(type), 
			ImapResponseCodeType.UidNotSticky => new ImapResponseCode(type, isError: false), 
			ImapResponseCodeType.UrlMech => new ImapResponseCode(type, isError: false), 
			ImapResponseCodeType.BadUrl => new BadUrlResponseCode(type), 
			ImapResponseCodeType.TooBig => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.HighestModSeq => new HighestModSeqResponseCode(type), 
			ImapResponseCodeType.Modified => new ModifiedResponseCode(type), 
			ImapResponseCodeType.NoModSeq => new ImapResponseCode(type, isError: false), 
			ImapResponseCodeType.CompressionActive => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.Closed => new ImapResponseCode(type, isError: false), 
			ImapResponseCodeType.NotSaved => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.BadComparator => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.Annotate => new AnnotateResponseCode(type), 
			ImapResponseCodeType.Annotations => new AnnotationsResponseCode(type), 
			ImapResponseCodeType.MaxConvertMessages => new MaxConvertResponseCode(type), 
			ImapResponseCodeType.MaxConvertParts => new MaxConvertResponseCode(type), 
			ImapResponseCodeType.TempFail => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.NoUpdate => new NoUpdateResponseCode(type), 
			ImapResponseCodeType.Metadata => new MetadataResponseCode(type), 
			ImapResponseCodeType.NotificationOverflow => new ImapResponseCode(type, isError: false), 
			ImapResponseCodeType.BadEvent => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.UndefinedFilter => new UndefinedFilterResponseCode(type), 
			ImapResponseCodeType.Unavailable => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.AuthenticationFailed => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.AuthorizationFailed => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.Expired => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.PrivacyRequired => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.ContactAdmin => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.NoPerm => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.InUse => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.ExpungeIssued => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.Corruption => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.ServerBug => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.ClientBug => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.CanNot => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.Limit => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.OverQuota => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.AlreadyExists => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.NonExistent => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.UseAttr => new ImapResponseCode(type, isError: true), 
			ImapResponseCodeType.MailboxId => new MailboxIdResponseCode(type), 
			ImapResponseCodeType.WebAlert => new WebAlertResponseCode(type), 
			_ => new ImapResponseCode(type, isError: true), 
		};
	}
}
