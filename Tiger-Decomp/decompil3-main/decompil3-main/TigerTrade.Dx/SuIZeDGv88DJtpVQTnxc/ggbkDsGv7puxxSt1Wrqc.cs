using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Resources;
using fZl77HkDbCF2hZri4dVV;
using H59IbFkNkUTQB7uIfts0;
using kvtsvxkNBA3S7tECx5XS;
using mbUKQckNlyCOeZGxOWCQ;
using N7xXnIGvUSatoPYnxZZd;
using SharpDX;
using SharpDX.DirectWrite;
using uIAOJJGvrWQY0QNwa6k9;

namespace SuIZeDGv88DJtpVQTnxc;

internal class ggbkDsGv7puxxSt1Wrqc : CallbackBase, FontCollectionLoader, IUnknown, ICallbackable, IDisposable, FontFileLoader
{
	[Serializable]
	[CompilerGenerated]
	private sealed class OPqUoAGBwZqLgIGkJ6Wi
	{
		public static readonly OPqUoAGBwZqLgIGkJ6Wi u04GBA49hwo;

		public static Func<DictionaryEntry, bool> CDFGBPAZTuN;

		public static Func<DictionaryEntry, Uri> ia9GBJvxVII;

		internal static OPqUoAGBwZqLgIGkJ6Wi o5yacUkdIeLNM8VlPuN9;

		static OPqUoAGBwZqLgIGkJ6Wi()
		{
			vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
			P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
			jrgLldkdUC8Bmh6ffApS();
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_e3c56040434a4a628f0f01cc04d0408d == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			u04GBA49hwo = new OPqUoAGBwZqLgIGkJ6Wi();
		}

		public OPqUoAGBwZqLgIGkJ6Wi()
		{
			jrgLldkdUC8Bmh6ffApS();
			base._002Ector();
		}

		internal bool A7QGB7WYdqd(DictionaryEntry entry)
		{
			if (!((string)entry.Key).EndsWith((string)wPY3uNkdTuFy4KnAYWcv(-371631841 ^ -371633923)))
			{
				return ((string)entry.Key).EndsWith((string)wPY3uNkdTuFy4KnAYWcv(-377195341 ^ -377193123));
			}
			return true;
		}

		internal Uri C0aGB8cL1oM(DictionaryEntry entry)
		{
			return new Uri((string)Bdg3NBkdyKQcSCoOl7TA(wPY3uNkdTuFy4KnAYWcv(-2002318893 ^ -2002321367), (string)entry.Key), UriKind.Relative);
		}

		internal static void jrgLldkdUC8Bmh6ffApS()
		{
			qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		}

		internal static bool G2tbRRkdWgqaMQEOdefc()
		{
			return o5yacUkdIeLNM8VlPuN9 == null;
		}

		internal static OPqUoAGBwZqLgIGkJ6Wi MJPecykdt1CH87jJjFJx()
		{
			return o5yacUkdIeLNM8VlPuN9;
		}

		internal static object wPY3uNkdTuFy4KnAYWcv(int P_0)
		{
			return vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(P_0);
		}

		internal static object Bdg3NBkdyKQcSCoOl7TA(object P_0, object P_1)
		{
			return (string)P_0 + (string)P_1;
		}
	}

	private readonly List<JCXRYCGvCddFCgtJuPad> LDBGvJmD6q6;

	[CompilerGenerated]
	private readonly DataStream fOlGvFsNMFo;

	private static ggbkDsGv7puxxSt1Wrqc GflcL6kQITT8ARAuAWwg;

	public DataStream Key
	{
		[CompilerGenerated]
		get
		{
			return fOlGvFsNMFo;
		}
	}

	private static List<Uri> OGSGvAljWV5()
	{
		Assembly assembly = Type.GetTypeFromHandle(yjPYDZkNi1vFNQZb4QFE.z9KkWDtnqUA(33554469)).Assembly;
		string name = assembly.GetName().Name + vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(0x28B345BB ^ 0x28B34C7D);
		using Stream stream = assembly.GetManifestResourceStream(name);
		if (stream == null)
		{
			return new List<Uri>();
		}
		using ResourceReader source = new ResourceReader(stream);
		return (from DictionaryEntry entry in source
			where ((string)entry.Key).EndsWith((string)OPqUoAGBwZqLgIGkJ6Wi.wPY3uNkdTuFy4KnAYWcv(-371631841 ^ -371633923)) || ((string)entry.Key).EndsWith((string)OPqUoAGBwZqLgIGkJ6Wi.wPY3uNkdTuFy4KnAYWcv(-377195341 ^ -377193123))
			select new Uri((string)OPqUoAGBwZqLgIGkJ6Wi.Bdg3NBkdyKQcSCoOl7TA(OPqUoAGBwZqLgIGkJ6Wi.wPY3uNkdTuFy4KnAYWcv(-2002318893 ^ -2002321367), (string)entry.Key), UriKind.Relative)).ToList();
	}

	public ggbkDsGv7puxxSt1Wrqc(Factory P_0)
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		LDBGvJmD6q6 = new List<JCXRYCGvCddFCgtJuPad>();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_e3a78f5673ba492cb3624f6fd9b0982f == 0)
		{
			num = 2;
		}
		DataStream dataStream = default(DataStream);
		byte[] array = default(byte[]);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 3:
			{
				using (List<Uri>.Enumerator enumerator = OGSGvAljWV5().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						while (true)
						{
							IL_01b3:
							StreamResourceInfo streamResourceInfo = (StreamResourceInfo)aWSTtKkQUoVkVGuZdBYC(enumerator.Current);
							if (streamResourceInfo == null)
							{
								break;
							}
							int num3 = 2;
							while (true)
							{
								switch (num3)
								{
								case 1:
									dataStream = new DataStream(array.Length, canRead: true, canWrite: true);
									JjnrhOkQym8dqFlpcMZr(dataStream, array, 0, array.Length);
									num3 = 3;
									continue;
								case 2:
									array = Utilities.ReadStream((Stream)lWOs6JkQTCFW6VcpeObT(streamResourceInfo));
									num3 = 0;
									if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_9ea6ac1b9978445f984c9b1d9e0008bf == 0)
									{
										num3 = 1;
									}
									continue;
								case 3:
									break;
								default:
									goto IL_01b3;
								}
								break;
							}
							dataStream.Position = 0L;
							LDBGvJmD6q6.Add(new JCXRYCGvCddFCgtJuPad(dataStream));
							break;
						}
					}
				}
				goto case 4;
			}
			case 1:
				Key.Write(num2);
				num2++;
				num = 5;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_90af539e848d4c66b5ac1596d8ba32ec == 0)
				{
					num = 1;
				}
				break;
			case 2:
			case 5:
				if (num2 >= LDBGvJmD6q6.Count)
				{
					num = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_2389a6f9140241a4a585b48e518be2dd == 0)
					{
						num = 0;
					}
					break;
				}
				goto case 1;
			default:
				Key.Position = 0L;
				P_0.RegisterFontFileLoader(this);
				CycvdGkQZvY9DZkch5hN(P_0, this);
				return;
			case 4:
				fOlGvFsNMFo = new DataStream(4 * LDBGvJmD6q6.Count, canRead: true, canWrite: true);
				num2 = 0;
				num = 2;
				break;
			}
		}
	}

	FontFileEnumerator FontCollectionLoader.CreateEnumeratorFromKey(Factory P_0, DataPointer P_1)
	{
		return new taqTK6GvtgLuKCD96KsM(P_0, this, new DataStream(P4GkyBkQVlht8NjFsHML(Key), Key.Length, canRead: true, canWrite: true));
	}

	FontFileStream FontFileLoader.CreateStreamFromKey(DataPointer P_0)
	{
		int index = P_0.ToDataStream().Read<int>();
		return LDBGvJmD6q6[index];
	}

	static ggbkDsGv7puxxSt1Wrqc()
	{
		vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object aWSTtKkQUoVkVGuZdBYC(object P_0)
	{
		return Application.GetResourceStream((Uri)P_0);
	}

	internal static object lWOs6JkQTCFW6VcpeObT(object P_0)
	{
		return ((StreamResourceInfo)P_0).Stream;
	}

	internal static void JjnrhOkQym8dqFlpcMZr(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void CycvdGkQZvY9DZkch5hN(object P_0, object P_1)
	{
		((Factory)P_0).RegisterFontCollectionLoader((FontCollectionLoader)P_1);
	}

	internal static bool tycNA7kQW92F8GRlumfU()
	{
		return GflcL6kQITT8ARAuAWwg == null;
	}

	internal static ggbkDsGv7puxxSt1Wrqc hX9kgCkQtpAnLWEN2Q3A()
	{
		return GflcL6kQITT8ARAuAWwg;
	}

	internal static IntPtr P4GkyBkQVlht8NjFsHML(object P_0)
	{
		return ((DataStream)P_0).DataPointer;
	}
}
