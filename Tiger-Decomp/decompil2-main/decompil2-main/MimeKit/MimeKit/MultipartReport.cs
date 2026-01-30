using System;

namespace MimeKit;

public class MultipartReport : Multipart
{
	public string ReportType
	{
		get
		{
			return base.ContentType.Parameters["report-type"];
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!(ReportType == value))
			{
				base.ContentType.Parameters["report-type"] = value.Trim();
			}
		}
	}

	public MultipartReport(MimeEntityConstructorArgs args)
		: base(args)
	{
	}

	public MultipartReport(string reportType, params object[] args)
		: base("report", args)
	{
		if (reportType == null)
		{
			throw new ArgumentNullException("reportType");
		}
		ReportType = reportType;
	}

	public MultipartReport(string reportType)
		: base("report")
	{
		if (reportType == null)
		{
			throw new ArgumentNullException("reportType");
		}
		ReportType = reportType;
	}

	public override void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitMultipartReport(this);
	}
}
