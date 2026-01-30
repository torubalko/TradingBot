using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Internal;

internal class DT2
{
	private ISyntaxLanguage P6C;

	private Dictionary<Type, IEnumerable> l6u;

	private Dictionary<ITextView, Dictionary<Type, IEnumerable>> d61;

	private SyntaxEditor V6F;

	private Dictionary<Type, IEnumerable> A63;

	private Dictionary<ITextView, Dictionary<Type, IEnumerable>> D6R;

	private static DT2 TlV;

	public DT2(SyntaxEditor P_0)
	{
		grA.DaB7cz();
		l6u = new Dictionary<Type, IEnumerable>();
		d61 = new Dictionary<ITextView, Dictionary<Type, IEnumerable>>();
		A63 = new Dictionary<Type, IEnumerable>();
		D6R = new Dictionary<ITextView, Dictionary<Type, IEnumerable>>();
		base._002Ector();
		if (P_0 == null)
		{
			int num = 0;
			if (false)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			default:
				throw new ArgumentNullException(Q7Z.tqM(8238));
			}
		}
		V6F = P_0;
	}

	private static void a6c<GTf>(List<GTf> P_0, ISyntaxLanguage P_1) where GTf : class
	{
		if (P_1 == null)
		{
			return;
		}
		GTf service = P_1.GetService<GTf>();
		if (service != null)
		{
			P_0.Add(service);
		}
		lock (P_1.SyncRoot)
		{
			foreach (object allServiceType in P_1.GetAllServiceTypes())
			{
				if (allServiceType as Type != typeof(GTf) && P_1.GetService(allServiceType) is GTf item && !P_0.Contains(item))
				{
					P_0.Add(item);
				}
			}
		}
	}

	private void C6a<BT6>(List<BT6> P_0) where BT6 : class
	{
		if (V6F.eGu() is BT6 item)
		{
			P_0.Add(item);
		}
		IIntelliPromptManager intelliPrompt = V6F.IntelliPrompt;
		if (intelliPrompt != null)
		{
			IIntelliPromptSessionCollection sessions = intelliPrompt.Sessions;
			if (sessions != null)
			{
				for (int num = sessions.Count - 1; num >= 0; num--)
				{
					IIntelliPromptSession intelliPromptSession = sessions[num];
					if (intelliPromptSession != null && intelliPromptSession.IsOpen)
					{
						BT6 service = intelliPromptSession.GetService<BT6>();
						if (service != null)
						{
							P_0.Add(service);
						}
						lock (intelliPromptSession.SyncRoot)
						{
							foreach (object allServiceType in intelliPromptSession.GetAllServiceTypes())
							{
								if (allServiceType as Type != typeof(BT6) && intelliPromptSession.GetService(allServiceType) is BT6 item2 && !P_0.Contains(item2))
								{
									P_0.Add(item2);
								}
							}
						}
					}
				}
			}
		}
		IEditorDocument document = V6F.Document;
		if (document != null && document.OutliningManager is BT6 item3)
		{
			P_0.Add(item3);
		}
	}

	private static void m6x<KTe>(List<KTe> P_0, ITextView P_1) where KTe : class
	{
		if (P_1 != null && P_1 is KTe item)
		{
			P_0.Add(item);
		}
	}

	private IEnumerable<DTJ> C6G<DTJ>(bool P_0, ITextView P_1, ISyntaxLanguage P_2) where DTJ : class
	{
		if (P6C != P_2)
		{
			n6g();
		}
		Dictionary<Type, IEnumerable> value = (P_0 ? l6u : A63);
		if (P_1 != null)
		{
			if (P_0)
			{
				if (!d61.TryGetValue(P_1, out value))
				{
					value = new Dictionary<Type, IEnumerable>();
					d61[P_1] = value;
				}
			}
			else if (!D6R.TryGetValue(P_1, out value))
			{
				value = new Dictionary<Type, IEnumerable>();
				D6R[P_1] = value;
			}
		}
		List<DTJ> list = null;
		Type typeFromHandle = typeof(DTJ);
		if (!value.TryGetValue(typeFromHandle, out var value2))
		{
			P6C = P_2;
			list = new List<DTJ>();
			C6a(list);
			if (P_1 != null)
			{
				m6x(list, P_1);
			}
			a6c(list, P_2);
			if (P_0)
			{
				list = E6K(list);
			}
			value[typeFromHandle] = list;
		}
		else
		{
			list = value2 as List<DTJ>;
		}
		return list;
	}

	private void y6X(object P_0, CollectionChangeEventArgs<object> P_1)
	{
		n6g();
	}

	private List<BTW> E6K<BTW>(List<BTW> P_0)
	{
		Comparison<BTW> preComparison = delegate(BTW left, BTW right)
		{
			IIntelliPromptSession intelliPromptSession = left as IIntelliPromptSession;
			IIntelliPromptSession intelliPromptSession2 = right as IIntelliPromptSession;
			if (intelliPromptSession != null)
			{
				return (intelliPromptSession2 == null) ? (-1) : 0;
			}
			return (intelliPromptSession2 != null) ? 1 : 0;
		};
		Comparison<BTW> fallbackComparison = delegate(BTW VTq, BTW CTz)
		{
			IIntelliPromptManager intelliPrompt = V6F.IntelliPrompt;
			if (intelliPrompt != null)
			{
				IIntelliPromptSessionCollection sessions = intelliPrompt.Sessions;
				if (sessions != null && sessions.Count > 0)
				{
					IIntelliPromptSession intelliPromptSession = VTq as IIntelliPromptSession;
					IIntelliPromptSession intelliPromptSession2 = CTz as IIntelliPromptSession;
					if (intelliPromptSession != null && intelliPromptSession2 != null)
					{
						int num = sessions.IndexOf(intelliPromptSession);
						int num2 = sessions.IndexOf(intelliPromptSession2);
						if (num != -1 && num2 != -1)
						{
							return num2.CompareTo(num);
						}
					}
				}
			}
			return 0;
		};
		P_0 = new List<BTW>(OrderableHelper.Sort(P_0, preComparison, fallbackComparison));
		return P_0;
	}

	public void e6f(ISyntaxLanguage P_0)
	{
		if (P_0 != null)
		{
			P_0.ServiceAdded += y6X;
			P_0.ServiceRemoved += y6X;
		}
		n6g();
	}

	public void z6D(ISyntaxLanguage P_0)
	{
		if (P_0 != null)
		{
			P_0.ServiceAdded -= y6X;
			P_0.ServiceRemoved -= y6X;
		}
		n6g();
	}

	public void n6g()
	{
		P6C = null;
		l6u.Clear();
		d61.Clear();
		A63.Clear();
		D6R.Clear();
	}

	public IEnumerable<AT8> g6Q<AT8>(bool P_0, ITextView P_1 = null) where AT8 : class
	{
		ISyntaxLanguage syntaxLanguage = ((V6F.Document != null) ? V6F.Document.Language : null);
		return C6G<AT8>(P_0, P_1, syntaxLanguage);
	}

	public void q6e(ISyntaxLanguage P_0)
	{
		uTb uTb2 = V6F.gGw();
		if (uTb2 == null)
		{
			return;
		}
		IEnumerable<IAdornmentManagerProvider> enumerable = C6G<IAdornmentManagerProvider>(_0020: true, null, P_0);
		IEnumerable<ITextViewLifecycleEventSink> enumerable2 = C6G<ITextViewLifecycleEventSink>(_0020: true, null, P_0);
		foreach (EditorView item in uTb2.O4R())
		{
			foreach (IAdornmentManagerProvider item2 in enumerable)
			{
				item2.GetAdornmentManager(item);
			}
			foreach (ITextViewLifecycleEventSink item3 in enumerable2)
			{
				item3.NotifyViewAttached(item);
			}
		}
	}

	public void r6l(ISyntaxLanguage P_0)
	{
		uTb uTb2 = V6F.gGw();
		if (uTb2 == null)
		{
			return;
		}
		IEnumerable<ITextViewLifecycleEventSink> enumerable = C6G<ITextViewLifecycleEventSink>(_0020: true, null, P_0);
		foreach (EditorView item in uTb2.O4R())
		{
			foreach (ITextViewLifecycleEventSink item2 in enumerable)
			{
				item2.NotifyViewDetached(item);
			}
		}
	}

	public void k6A(ITextView P_0)
	{
		uTb uTb2 = V6F.gGw();
		if (uTb2 == null)
		{
			return;
		}
		IEnumerable<IAdornmentManagerProvider> enumerable = g6Q<IAdornmentManagerProvider>(_0020: true);
		foreach (IAdornmentManagerProvider item in enumerable)
		{
			item.GetAdornmentManager(P_0);
		}
		IEnumerable<ITextViewLifecycleEventSink> enumerable2 = g6Q<ITextViewLifecycleEventSink>(_0020: true);
		foreach (ITextViewLifecycleEventSink item2 in enumerable2)
		{
			item2.NotifyViewAttached(P_0);
		}
	}

	public void u6v(ITextView P_0)
	{
		d61.Remove(P_0);
		D6R.Remove(P_0);
		uTb uTb2 = V6F.gGw();
		if (uTb2 == null)
		{
			return;
		}
		IEnumerable<ITextViewLifecycleEventSink> enumerable = g6Q<ITextViewLifecycleEventSink>(_0020: true);
		foreach (ITextViewLifecycleEventSink item in enumerable)
		{
			item.NotifyViewDetached(P_0);
		}
	}

	[CompilerGenerated]
	private int Q6m<ITj>(ITj VTq, ITj CTz)
	{
		IIntelliPromptManager intelliPrompt = V6F.IntelliPrompt;
		if (intelliPrompt != null)
		{
			IIntelliPromptSessionCollection sessions = intelliPrompt.Sessions;
			if (sessions != null && sessions.Count > 0)
			{
				IIntelliPromptSession intelliPromptSession = VTq as IIntelliPromptSession;
				IIntelliPromptSession intelliPromptSession2 = CTz as IIntelliPromptSession;
				if (intelliPromptSession != null && intelliPromptSession2 != null)
				{
					int num = sessions.IndexOf(intelliPromptSession);
					int num2 = sessions.IndexOf(intelliPromptSession2);
					if (num != -1 && num2 != -1)
					{
						return num2.CompareTo(num);
					}
				}
			}
		}
		return 0;
	}

	internal static bool BlI()
	{
		return TlV == null;
	}

	internal static DT2 flc()
	{
		return TlV;
	}
}
