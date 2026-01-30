using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using EDugZvNwF6e5LYsQZ3C5;
using jegfceGfr7jyXhg9BWa7;
using nff6NvN8pYC4xeKDOd05;
using OrDDjnN8w7riQsQI5MiI;
using TigerTrade.Core.Utils.Logging;

namespace TigerTrade.Core.Utils.Config;

public sealed class ConfigSerializer
{
	[CompilerGenerated]
	private sealed class GShncdGnKEsEw4VFsZAB<J1KgMfNwKOVktk4JRZl1> where J1KgMfNwKOVktk4JRZl1 : ICloneable
	{
		public string NIeNwmWxgDB;

		public DataContractResolver uatNwhACD3A;

		public J1KgMfNwKOVktk4JRZl1 vJRNww1Cyd8;

		internal static object cmoWQbkGOaYIfUfI2UE5;

		public GShncdGnKEsEw4VFsZAB()
		{
			PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
			base._002Ector();
		}

		internal Task<bool> mQAGnmRgQq3()
		{
			SaveToFile(vJRNww1Cyd8, NIeNwmWxgDB, uatNwhACD3A);
			return Task.FromResult(result: true);
		}

		static GShncdGnKEsEw4VFsZAB()
		{
			RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
			a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool XPUWbFkGqgqIoWjF5SMf()
		{
			return cmoWQbkGOaYIfUfI2UE5 == null;
		}

		internal static object w6LkeikGIccRy5crhQcW()
		{
			return cmoWQbkGOaYIfUfI2UE5;
		}
	}

	private static readonly ConcurrentDictionary<string, SH1XNLGfCOyMRI6Zfi1I<bool>> handlers;

	internal static ConfigSerializer mfVZnwkfrfmkOxBZMI92;

	private static DataContractSerializer GetSerializer<T>(IEnumerable<Type> knownTypes, DataContractResolver resolver)
	{
		if (resolver == null)
		{
			return new DataContractSerializer(typeof(T), knownTypes);
		}
		return new DataContractSerializer(typeof(T), null, int.MaxValue, ignoreExtensionDataObject: false, preserveObjectReferences: false, null, resolver);
	}

	private static T Load<T>(Stream stream, IEnumerable<Type> knownTypes, DataContractResolver resolver = null)
	{
		return (T)GetSerializer<T>(knownTypes, resolver).ReadObject(stream);
	}

	private static void Save<T>(T o, XmlWriter writer, IEnumerable<Type> knownTypes, DataContractResolver resolver = null)
	{
		GetSerializer<T>(knownTypes, resolver).WriteObject(writer, o);
	}

	public static T LoadFromFile<T>(string fileName, DataContractResolver resolver = null)
	{
		try
		{
			if (!File.Exists(fileName))
			{
				return default(T);
			}
			using FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			return Load<T>(stream, null, resolver);
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
			return default(T);
		}
	}

	public static T LoadFromString<T>(string data, DataContractResolver resolver = null)
	{
		return LoadFromString<T>(Encoding.UTF8.GetBytes(data), resolver);
	}

	public static T LoadFromString<T>(string data, IEnumerable<Type> knownTypes)
	{
		return LoadFromString<T>(Encoding.UTF8.GetBytes(data), knownTypes);
	}

	public static T LoadFromString<T>(byte[] data, DataContractResolver resolver = null)
	{
		try
		{
			using MemoryStream stream = new MemoryStream(data);
			return Load<T>(stream, null, resolver);
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
			return default(T);
		}
	}

	public static T LoadFromString<T>(byte[] data, IEnumerable<Type> knownTypes)
	{
		try
		{
			using MemoryStream stream = new MemoryStream(data);
			return Load<T>(stream, knownTypes);
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
			return default(T);
		}
	}

	public static void SaveToFile<T>(T o, string fileName, DataContractResolver resolver = null)
	{
		try
		{
			XmlWriterSettings settings = new XmlWriterSettings
			{
				Indent = true
			};
			using XmlWriter writer = XmlWriter.Create(fileName, settings);
			Save(o, writer, null, resolver);
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
		}
	}

	public static void SaveToFileDebounced<T>(T o, string fileName, int debounceTime = 2000, DataContractResolver resolver = null) where T : ICloneable
	{
		GShncdGnKEsEw4VFsZAB<T> CS_0024_003C_003E8__locals11 = new GShncdGnKEsEw4VFsZAB<T>();
		CS_0024_003C_003E8__locals11.NIeNwmWxgDB = fileName;
		CS_0024_003C_003E8__locals11.uatNwhACD3A = resolver;
		lock (handlers)
		{
			if (debounceTime == 0)
			{
				SaveToFile(o, CS_0024_003C_003E8__locals11.NIeNwmWxgDB, CS_0024_003C_003E8__locals11.uatNwhACD3A);
				return;
			}
			if (!handlers.TryGetValue(CS_0024_003C_003E8__locals11.NIeNwmWxgDB, out var value))
			{
				value = new SH1XNLGfCOyMRI6Zfi1I<bool>(debounceTime);
				handlers.TryAdd(CS_0024_003C_003E8__locals11.NIeNwmWxgDB, value);
			}
			CS_0024_003C_003E8__locals11.vJRNww1Cyd8 = ThickCopy(o, CS_0024_003C_003E8__locals11.uatNwhACD3A);
			value.RslGfKJwbUF(delegate
			{
				SaveToFile(CS_0024_003C_003E8__locals11.vJRNww1Cyd8, CS_0024_003C_003E8__locals11.NIeNwmWxgDB, CS_0024_003C_003E8__locals11.uatNwhACD3A);
				return Task.FromResult(result: true);
			});
		}
	}

	public static string SaveToString<T>(T o, DataContractResolver resolver = null)
	{
		try
		{
			using MemoryStream memoryStream = new MemoryStream();
			XmlWriterSettings settings = new XmlWriterSettings
			{
				Indent = true
			};
			using (XmlWriter writer = XmlWriter.Create(memoryStream, settings))
			{
				Save(o, writer, null, resolver);
			}
			byte[] array = new byte[memoryStream.Length];
			Array.Copy(memoryStream.GetBuffer(), 0L, array, 0L, memoryStream.Length);
			return Encoding.UTF8.GetString(array);
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
			return "";
		}
	}

	public static string SaveToString<T>(T o, IEnumerable<Type> knownTypes)
	{
		try
		{
			using MemoryStream memoryStream = new MemoryStream();
			XmlWriterSettings settings = new XmlWriterSettings
			{
				Indent = true
			};
			using (XmlWriter writer = XmlWriter.Create(memoryStream, settings))
			{
				Save(o, writer, knownTypes);
			}
			byte[] array = new byte[memoryStream.Length];
			Array.Copy(memoryStream.GetBuffer(), 0L, array, 0L, memoryStream.Length);
			return Encoding.UTF8.GetString(array);
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
			return "";
		}
	}

	private static T ThickCopy<T>(T source, DataContractResolver resolver) where T : ICloneable
	{
		return (T)source.Clone();
	}

	public ConfigSerializer()
	{
		darXAukfhf9xS97ZQ5Fx();
		base._002Ector();
	}

	static ConfigSerializer()
	{
		RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
		handlers = new ConcurrentDictionary<string, SH1XNLGfCOyMRI6Zfi1I<bool>>();
		int num = 0;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_43b845a976944f6c88f75a33ff11de75 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void darXAukfhf9xS97ZQ5Fx()
	{
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
	}

	internal static bool QxnjkakfKPDIJ1FcJRMj()
	{
		return mfVZnwkfrfmkOxBZMI92 == null;
	}

	internal static ConfigSerializer VgWNEHkfmQgYWyyL5sBP()
	{
		return mfVZnwkfrfmkOxBZMI92;
	}
}
