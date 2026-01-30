using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace MailKit.Net;

internal class NetworkStream : Stream
{
	private SocketAsyncEventArgs send;

	private SocketAsyncEventArgs recv;

	private bool ownsSocket;

	private bool connected;

	public Socket Socket { get; private set; }

	public bool DataAvailable
	{
		get
		{
			if (connected)
			{
				return Socket.Available > 0;
			}
			return false;
		}
	}

	public override bool CanRead => connected;

	public override bool CanWrite => connected;

	public override bool CanSeek => false;

	public override bool CanTimeout => connected;

	public override long Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public override long Position
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public override int ReadTimeout
	{
		get
		{
			int receiveTimeout = Socket.ReceiveTimeout;
			if (receiveTimeout != 0)
			{
				return receiveTimeout;
			}
			return -1;
		}
		set
		{
			if (value <= 0 && value != -1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			Socket.ReceiveTimeout = value;
		}
	}

	public override int WriteTimeout
	{
		get
		{
			int sendTimeout = Socket.SendTimeout;
			if (sendTimeout != 0)
			{
				return sendTimeout;
			}
			return -1;
		}
		set
		{
			if (value <= 0 && value != -1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			Socket.SendTimeout = value;
		}
	}

	public NetworkStream(Socket socket, bool ownsSocket)
	{
		send = new SocketAsyncEventArgs();
		send.Completed += AsyncOperationCompleted;
		send.AcceptSocket = socket;
		recv = new SocketAsyncEventArgs();
		recv.Completed += AsyncOperationCompleted;
		recv.AcceptSocket = socket;
		this.ownsSocket = ownsSocket;
		connected = socket.Connected;
		Socket = socket;
	}

	private void AsyncOperationCompleted(object sender, SocketAsyncEventArgs args)
	{
		TaskCompletionSource<bool> taskCompletionSource = (TaskCompletionSource<bool>)args.UserToken;
		if (args.SocketError == SocketError.Success)
		{
			taskCompletionSource.TrySetResult(result: true);
		}
		else
		{
			taskCompletionSource.TrySetException(new SocketException((int)args.SocketError));
		}
	}

	private void Cleanup()
	{
		if (send != null)
		{
			send.Completed -= AsyncOperationCompleted;
			send.AcceptSocket = null;
			send?.Dispose();
			send = null;
		}
		if (recv != null)
		{
			recv.Completed -= AsyncOperationCompleted;
			recv.AcceptSocket = null;
			recv.Dispose();
			recv = null;
		}
	}

	private void Disconnect()
	{
		try
		{
			Socket.Disconnect(reuseSocket: false);
			Socket.Dispose();
		}
		catch
		{
		}
		finally
		{
			connected = false;
			Cleanup();
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		try
		{
			return Socket.Receive(buffer, offset, count, SocketFlags.None);
		}
		catch (SocketException ex)
		{
			throw new IOException(ex.Message, ex);
		}
	}

	public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		using CancellationTokenSource timeout = new CancellationTokenSource(ReadTimeout);
		using CancellationTokenSource linked = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, timeout.Token);
		using (linked.Token.Register(delegate
		{
			tcs.TrySetCanceled();
		}, useSynchronizationContext: false))
		{
			recv.SetBuffer(buffer, offset, count);
			recv.UserToken = tcs;
			if (!Socket.ReceiveAsync(recv))
			{
				AsyncOperationCompleted(null, recv);
			}
			try
			{
				await tcs.Task.ConfigureAwait(continueOnCapturedContext: false);
				return recv.BytesTransferred;
			}
			catch (OperationCanceledException)
			{
				Disconnect();
				throw;
			}
			catch (Exception ex2)
			{
				Disconnect();
				if (ex2 is SocketException)
				{
					throw new IOException(ex2.Message, ex2);
				}
				throw;
			}
		}
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		try
		{
			Socket.Send(buffer, offset, count, SocketFlags.None);
		}
		catch (SocketException ex)
		{
			throw new IOException(ex.Message, ex);
		}
	}

	public override async Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		using CancellationTokenSource timeout = new CancellationTokenSource(WriteTimeout);
		using CancellationTokenSource linked = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, timeout.Token);
		using (linked.Token.Register(delegate
		{
			tcs.TrySetCanceled();
		}, useSynchronizationContext: false))
		{
			send.SetBuffer(buffer, offset, count);
			send.UserToken = tcs;
			if (!Socket.SendAsync(send))
			{
				AsyncOperationCompleted(null, send);
			}
			try
			{
				await tcs.Task.ConfigureAwait(continueOnCapturedContext: false);
			}
			catch (OperationCanceledException)
			{
				Disconnect();
				throw;
			}
			catch (Exception ex2)
			{
				Disconnect();
				if (ex2 is SocketException)
				{
					throw new IOException(ex2.Message, ex2);
				}
				throw;
			}
		}
	}

	public override void Flush()
	{
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return Task.FromResult(result: true);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	public static NetworkStream Get(Stream stream)
	{
		if (stream is CompressedStream compressedStream)
		{
			stream = compressedStream.InnerStream;
		}
		if (stream is SslStream sslStream)
		{
			stream = sslStream.InnerStream;
		}
		return stream as NetworkStream;
	}

	public void Poll(SelectMode mode, CancellationToken cancellationToken)
	{
		if (cancellationToken.CanBeCanceled)
		{
			do
			{
				cancellationToken.ThrowIfCancellationRequested();
			}
			while (!Socket.Poll(250000, mode));
			cancellationToken.ThrowIfCancellationRequested();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (ownsSocket && connected)
			{
				ownsSocket = false;
				Disconnect();
			}
			else
			{
				Cleanup();
			}
		}
		base.Dispose(disposing);
	}
}
