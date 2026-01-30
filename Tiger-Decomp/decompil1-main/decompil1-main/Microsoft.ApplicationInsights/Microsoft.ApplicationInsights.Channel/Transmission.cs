using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights.Extensibility.Implementation;

namespace Microsoft.ApplicationInsights.Channel;

public class Transmission
{
	internal const string ContentTypeHeader = "Content-Type";

	internal const string ContentEncodingHeader = "Content-Encoding";

	private static readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(100.0);

	private int isSending;

	public Uri EndpointAddress { get; private set; }

	public byte[] Content { get; private set; }

	public string ContentType { get; private set; }

	public string ContentEncoding { get; private set; }

	public TimeSpan Timeout { get; internal set; }

	public string Id { get; private set; }

	public ICollection<ITelemetry> TelemetryItems { get; private set; }

	public Transmission(Uri address, byte[] content, string contentType, string contentEncoding, TimeSpan timeout = default(TimeSpan))
	{
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		if (contentType == null)
		{
			throw new ArgumentNullException("contentType");
		}
		EndpointAddress = address;
		Content = content;
		ContentType = contentType;
		ContentEncoding = contentEncoding;
		Timeout = ((timeout == default(TimeSpan)) ? DefaultTimeout : timeout);
		Id = Convert.ToBase64String(BitConverter.GetBytes(WeakConcurrentRandom.Instance.Next()));
		TelemetryItems = null;
	}

	public Transmission(Uri address, ICollection<ITelemetry> telemetryItems, TimeSpan timeout = default(TimeSpan))
		: this(address, JsonSerializer.Serialize(telemetryItems), JsonSerializer.ContentType, JsonSerializer.CompressionType, timeout)
	{
		TelemetryItems = telemetryItems;
	}

	internal Transmission(Uri address, IEnumerable<ITelemetry> telemetryItems, string contentType, string contentEncoding, TimeSpan timeout = default(TimeSpan))
		: this(address, JsonSerializer.Serialize(telemetryItems), contentType, contentEncoding, timeout)
	{
	}

	protected internal Transmission()
	{
	}

	public virtual async Task<HttpWebResponseWrapper> SendAsync()
	{
		if (Interlocked.CompareExchange(ref isSending, 1, 0) != 0)
		{
			throw new InvalidOperationException("SendAsync is already in progress.");
		}
		try
		{
			WebRequest request = CreateRequest(EndpointAddress);
			Task<HttpWebResponseWrapper> sendTask = GetResponseAsync(request);
			Task task = Task.Delay(Timeout).ContinueWith(delegate
			{
				if (!sendTask.IsCompleted)
				{
					request.Abort();
				}
			});
			await Task.WhenAny(task, sendTask).ConfigureAwait(continueOnCapturedContext: false);
			return await sendTask.ConfigureAwait(continueOnCapturedContext: false);
		}
		finally
		{
			Interlocked.Exchange(ref isSending, 0);
		}
	}

	public virtual Tuple<Transmission, Transmission> Split(Func<int, int> calculateLength)
	{
		Transmission item = this;
		Transmission item2 = null;
		if (TelemetryItems != null)
		{
			int num = calculateLength(TelemetryItems.Count);
			if (num != TelemetryItems.Count)
			{
				List<ITelemetry> list = new List<ITelemetry>();
				List<ITelemetry> list2 = new List<ITelemetry>();
				int num2 = 0;
				foreach (ITelemetry telemetryItem in TelemetryItems)
				{
					if (num2 < num)
					{
						list.Add(telemetryItem);
					}
					else
					{
						list2.Add(telemetryItem);
					}
					num2++;
				}
				item = new Transmission(EndpointAddress, list);
				item2 = new Transmission(EndpointAddress, list2);
			}
		}
		else if (ContentType == JsonSerializer.ContentType)
		{
			bool compress = ContentEncoding == JsonSerializer.CompressionType;
			string[] array = JsonSerializer.Deserialize(Content, compress).Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
			int num3 = calculateLength(array.Length);
			if (num3 != array.Length)
			{
				string text = string.Empty;
				string text2 = string.Empty;
				for (int i = 0; i < array.Length; i++)
				{
					if (i < num3)
					{
						if (!string.IsNullOrEmpty(text))
						{
							text += Environment.NewLine;
						}
						text += array[i];
					}
					else
					{
						if (!string.IsNullOrEmpty(text2))
						{
							text2 += Environment.NewLine;
						}
						text2 += array[i];
					}
				}
				item = new Transmission(EndpointAddress, JsonSerializer.ConvertToByteArray(text, compress), ContentType, ContentEncoding);
				item2 = new Transmission(EndpointAddress, JsonSerializer.ConvertToByteArray(text2, compress), ContentType, ContentEncoding);
			}
		}
		else if (calculateLength(1) == 0)
		{
			item = null;
			item2 = this;
		}
		return Tuple.Create(item, item2);
	}

	protected virtual WebRequest CreateRequest(Uri address)
	{
		WebRequest webRequest = WebRequest.Create(address);
		webRequest.Method = "POST";
		if (!string.IsNullOrEmpty(ContentType))
		{
			webRequest.ContentType = ContentType;
		}
		if (!string.IsNullOrEmpty(ContentEncoding))
		{
			webRequest.Headers["Content-Encoding"] = ContentEncoding;
		}
		return webRequest;
	}

	private async Task<HttpWebResponseWrapper> GetResponseAsync(WebRequest request)
	{
		using (Stream requestStream = await request.GetRequestStreamAsync().ConfigureAwait(continueOnCapturedContext: false))
		{
			await requestStream.WriteAsync(Content, 0, Content.Length).ConfigureAwait(continueOnCapturedContext: false);
		}
		using WebResponse response = await request.GetResponseAsync().ConfigureAwait(continueOnCapturedContext: false);
		return CheckResponse(response);
	}

	private HttpWebResponseWrapper CheckResponse(WebResponse response)
	{
		HttpWebResponseWrapper httpWebResponseWrapper = null;
		if (response is HttpWebResponse { StatusCode: HttpStatusCode.PartialContent } httpWebResponse)
		{
			httpWebResponseWrapper = new HttpWebResponseWrapper
			{
				StatusCode = (int)httpWebResponse.StatusCode,
				StatusDescription = httpWebResponse.StatusDescription
			};
			if (httpWebResponse.Headers != null)
			{
				httpWebResponseWrapper.RetryAfterHeader = httpWebResponse.Headers["Retry-After"];
			}
			using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			httpWebResponseWrapper.Content = streamReader.ReadToEnd();
		}
		return httpWebResponseWrapper;
	}
}
