using System.Threading.Tasks;

namespace MailKit.Net.Imap;

internal delegate Task ImapUntaggedHandler(ImapEngine engine, ImapCommand ic, int index, bool doAsync);
