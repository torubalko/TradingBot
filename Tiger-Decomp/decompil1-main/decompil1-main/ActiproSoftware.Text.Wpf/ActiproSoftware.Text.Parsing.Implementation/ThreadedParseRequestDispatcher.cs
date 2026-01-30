using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using ActiproSoftware.Products.Text;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Parsing.Implementation;

public class ThreadedParseRequestDispatcher : DisposableObject, IParseRequestDispatcher, IDisposable
{
	private class ei
	{
		private string dqz;

		private ThreadedParseRequestDispatcher TsS;

		private bool zsV;

		private DateTime bsB;

		private Thread ms9;

		private object bsA;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int gsu;

		internal static ei tfj;

		public int Number
		{
			[CompilerGenerated]
			get
			{
				return gsu;
			}
			[CompilerGenerated]
			private set
			{
				gsu = num;
			}
		}

		public ei(ThreadedParseRequestDispatcher P_0, int P_1, ThreadPriority P_2)
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			zsV = true;
			bsA = new object();
			base._002Ector();
			if (P_0 == null)
			{
				throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(18122));
			}
			TsS = P_0;
			bsB = DateTime.Now;
			Number = P_1;
			ms9 = new Thread(RqR);
			ms9.Priority = P_2;
			ms9.IsBackground = true;
			ms9.Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(18146) + Number;
			ms9.Start();
		}

		private void OqN(IParseRequest P_0)
		{
			Rqn(P_0.ParseHashKey);
			IParseData result = P_0.Parser.Parse(P_0);
			bool flag = P_0.Target != null;
			int num = 0;
			if (pfl() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (flag)
			{
				P_0.Target.NotifyParseComplete(P_0, result);
			}
			lock (TsS.jTj)
			{
				TsS.oTC = P_0.ParseHashKey;
				TsS.iTb = DateTime.Now;
			}
			Rqn(null);
			lock (TsS.LTU)
			{
				Monitor.Pulse(TsS.LTU);
			}
		}

		private void RqR()
		{
			while (zsV)
			{
				IParseRequest parseRequest = null;
				int num = 10000;
				bool flag;
				lock (TsS.jTj)
				{
					flag = TsS.jTj.Count > 0;
					if (flag)
					{
						for (int i = 0; i < TsS.jTj.Count; i++)
						{
							parseRequest = TsS.jTj[i];
							if (parseRequest.RepeatedRequestPause > 0)
							{
								if (TsS.WTH(parseRequest.ParseHashKey))
								{
									num = Math.Min(num, Math.Max(0, parseRequest.RepeatedRequestPause) + 100);
									parseRequest = null;
									continue;
								}
								if (parseRequest.ParseHashKey == TsS.oTC)
								{
									TimeSpan timeSpan = DateTime.Now - TsS.iTb;
									if (timeSpan.TotalMilliseconds < (double)parseRequest.RepeatedRequestPause)
									{
										num = Math.Min(num, Math.Max(0, (int)((double)parseRequest.RepeatedRequestPause - timeSpan.TotalMilliseconds)) + 100);
										parseRequest = null;
										continue;
									}
								}
							}
							TsS.jTj.RemoveAt(i);
							parseRequest.State = ParseRequestState.Processing;
							break;
						}
					}
				}
				if (flag && parseRequest == null)
				{
					lock (bsA)
					{
						Monitor.Wait(bsA, num);
					}
					continue;
				}
				if (parseRequest != null)
				{
					OqN(parseRequest);
					parseRequest.State = ParseRequestState.Processed;
					parseRequest = null;
				}
				lock (TsS.jTj)
				{
					flag = TsS.jTj.Count > 0;
				}
				if (!flag)
				{
					lock (bsA)
					{
						Monitor.Wait(bsA);
					}
				}
			}
		}

		public bool oqf(bool P_0)
		{
			lock (bsA)
			{
				if ((P_0 || DateTime.Now.Subtract(bsB).TotalSeconds >= 300.0) && ms9 != null)
				{
					zsV = false;
					switch (ms9.ThreadState & ~System.Threading.ThreadState.Background)
					{
					case System.Threading.ThreadState.WaitSleepJoin:
						Monitor.Pulse(bsA);
						break;
					default:
						try
						{
							ms9.Abort();
						}
						catch (ThreadAbortException)
						{
						}
						break;
					case System.Threading.ThreadState.Stopped:
					case System.Threading.ThreadState.Aborted:
						break;
					}
					return true;
				}
			}
			return false;
		}

		[SpecialName]
		public string NqQ()
		{
			lock (bsA)
			{
				return dqz;
			}
		}

		[SpecialName]
		private void Rqn(string P_0)
		{
			lock (bsA)
			{
				dqz = P_0;
				bsB = DateTime.Now;
			}
		}

		public bool cqt()
		{
			bool result = true;
			lock (bsA)
			{
				System.Threading.ThreadState threadState = ms9.ThreadState & ~System.Threading.ThreadState.Background;
				System.Threading.ThreadState threadState2 = threadState;
				System.Threading.ThreadState threadState3 = threadState2;
				if (threadState3 == System.Threading.ThreadState.Running || threadState3 == System.Threading.ThreadState.Unstarted)
				{
					result = false;
				}
				Monitor.Pulse(bsA);
			}
			return result;
		}

		internal static bool lfK()
		{
			return tfj == null;
		}

		internal static ei pfl()
		{
			return tfj;
		}
	}

	private int BTp;

	private DateTime iTb;

	private string oTC;

	private object LTU;

	private int kTa;

	private List<IParseRequest> jTj;

	private ThreadPriority VTF;

	private List<ei> lTx;

	internal static ThreadedParseRequestDispatcher v1l;

	public bool IsBusy => PendingRequestCount > 0;

	public int PendingRequestCount
	{
		get
		{
			lock (jTj)
			{
				int num = jTj.Count;
				foreach (ei item in lTx)
				{
					if (item.NqQ() != null)
					{
						num++;
					}
				}
				return num;
			}
		}
	}

	public ThreadedParseRequestDispatcher()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		iTb = DateTime.MinValue;
		LTU = new object();
		kTa = 1;
		jTj = new List<IParseRequest>();
		VTF = ThreadPriority.BelowNormal;
		lTx = new List<ei>();
		base._002Ector();
		try
		{
			kTa = Math.Max(1, Environment.ProcessorCount - 1);
		}
		catch (SecurityException)
		{
		}
	}

	public ThreadedParseRequestDispatcher(int maxThreadCount)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		iTb = DateTime.MinValue;
		LTU = new object();
		kTa = 1;
		jTj = new List<IParseRequest>();
		VTF = ThreadPriority.BelowNormal;
		lTx = new List<ei>();
		base._002Ector();
		if (maxThreadCount <= 0)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7790));
		}
		kTa = maxThreadCount;
	}

	public ThreadedParseRequestDispatcher(int maxThreadCount, ThreadPriority threadPriority)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(maxThreadCount);
		VTF = threadPriority;
	}

	private bool WTH(string P_0)
	{
		foreach (ei item in lTx)
		{
			if (item.NqQ() == P_0)
			{
				return true;
			}
		}
		return false;
	}

	private void FTP()
	{
		bool flag = false;
		for (int num = lTx.Count - 1; num >= 0; num--)
		{
			if (flag || !lTx[num].cqt())
			{
				if (flag && lTx[num].oqf(_0020: false))
				{
					lTx.RemoveAt(num);
				}
			}
			else
			{
				flag = true;
			}
		}
		if (flag || lTx.Count >= kTa)
		{
			return;
		}
		BTp = ((BTp >= 10000000) ? 1 : (BTp + 1));
		int num2 = 1;
		if (W1I() == null)
		{
			num2 = 1;
		}
		ei item = default(ei);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				lTx.Insert(0, item);
				return;
			case 1:
				item = new ei(this, BTp, VTF);
				num2 = 0;
				if (W1I() != null)
				{
					num2 = num3;
				}
				break;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			lock (jTj)
			{
				for (int num = lTx.Count - 1; num >= 0; num--)
				{
					lTx[num].oqf(_0020: true);
					lTx.RemoveAt(num);
				}
				for (int num2 = jTj.Count - 1; num2 >= 0; num2--)
				{
					jTj[num2].State = ParseRequestState.Aborted;
					jTj.RemoveAt(num2);
				}
				iTb = DateTime.MinValue;
				oTC = null;
			}
		}
		base.Dispose(disposing);
	}

	public IParseRequest[] GetPendingRequests()
	{
		lock (jTj)
		{
			IParseRequest[] array = new IParseRequest[jTj.Count];
			jTj.CopyTo(array);
			return array;
		}
	}

	public bool HasPendingRequest(string parseHashKey)
	{
		lock (jTj)
		{
			bool flag = WTH(parseHashKey);
			int num = 0;
			if (W1I() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
			{
				if (flag)
				{
					return true;
				}
				for (int i = 0; i < jTj.Count; i++)
				{
					if (jTj[i].ParseHashKey == parseHashKey)
					{
						return true;
					}
				}
				break;
			}
			}
		}
		return false;
	}

	public void QueueRequest(IParseRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7822));
		}
		if (request.Parser == null)
		{
			throw new ArgumentException(SR.GetString(SRName.ExParseRequestNoParser));
		}
		bool flag = false;
		lock (jTj)
		{
			flag = jTj.Count > 0;
			if (request.ParseHashKey != null)
			{
				for (int num = jTj.Count - 1; num >= 0; num--)
				{
					if (jTj[num].ParseHashKey == request.ParseHashKey)
					{
						jTj[num].State = ParseRequestState.Aborted;
						jTj.RemoveAt(num);
						break;
					}
				}
			}
			request.State = ParseRequestState.Queued;
			bool flag2 = false;
			for (int i = 0; i < jTj.Count; i++)
			{
				if (request.Priority > jTj[i].Priority)
				{
					flag2 = true;
					jTj.Insert(i, request);
					break;
				}
			}
			if (!flag2)
			{
				jTj.Add(request);
			}
			if (request.ParseHashKey == oTC)
			{
				iTb = DateTime.Now;
			}
			if (!flag)
			{
				FTP();
			}
		}
	}

	public int RemovePendingRequests(string parseHashKey)
	{
		lock (jTj)
		{
			int num = 0;
			int num4 = default(int);
			for (int num2 = jTj.Count - 1; num2 >= 0; num2--)
			{
				IParseRequest parseRequest = jTj[num2];
				if (parseRequest.ParseHashKey == parseHashKey)
				{
					jTj.RemoveAt(num2);
					num++;
					int num3 = 0;
					if (W1I() != null)
					{
						num3 = num4;
					}
					switch (num3)
					{
					}
				}
			}
			return num;
		}
	}

	public bool WaitForParse(string parseHashKey)
	{
		return WaitForParse(parseHashKey, 250);
	}

	public bool WaitForParse(string parseHashKey, int maximumWaitTime)
	{
		bool flag = false;
		bool flag2 = false;
		lock (jTj)
		{
			int num = 0;
			if (W1I() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				if (!WTH(parseHashKey))
				{
					for (int i = 0; i < jTj.Count; i++)
					{
						if (jTj[i].ParseHashKey == parseHashKey)
						{
							flag = true;
							flag2 = true;
							break;
						}
					}
				}
				else
				{
					flag = true;
				}
				break;
			}
		}
		if (flag)
		{
			if (flag2)
			{
				lock (jTj)
				{
					iTb = DateTime.MinValue;
					FTP();
				}
			}
			lock (LTU)
			{
				Monitor.Wait(LTU, maximumWaitTime);
			}
		}
		return flag;
	}

	internal static bool Y1o()
	{
		return v1l == null;
	}

	internal static ThreadedParseRequestDispatcher W1I()
	{
		return v1l;
	}
}
