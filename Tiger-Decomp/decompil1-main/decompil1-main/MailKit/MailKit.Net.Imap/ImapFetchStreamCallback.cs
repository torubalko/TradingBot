using System.IO;

namespace MailKit.Net.Imap;

public delegate void ImapFetchStreamCallback(ImapFolder folder, int index, UniqueId uid, Stream stream);
