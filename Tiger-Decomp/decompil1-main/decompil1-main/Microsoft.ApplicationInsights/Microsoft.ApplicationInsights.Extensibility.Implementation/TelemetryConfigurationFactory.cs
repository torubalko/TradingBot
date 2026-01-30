using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility.Implementation.Platform;
using Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

internal class TelemetryConfigurationFactory
{
	private const string AddElementName = "Add";

	private const string TypeAttributeName = "Type";

	private const string InstrumentationKeyWebSitesEnvironmentVariable = "APPINSIGHTS_INSTRUMENTATIONKEY";

	private static readonly MethodInfo LoadInstancesDefinition = typeof(TelemetryConfigurationFactory).GetRuntimeMethods().First((MethodInfo m) => m.Name == "LoadInstances");

	private static readonly XNamespace XmlNamespace = "http://schemas.microsoft.com/ApplicationInsights/2013/Settings";

	private static TelemetryConfigurationFactory instance;

	public static TelemetryConfigurationFactory Instance
	{
		get
		{
			return instance ?? (instance = new TelemetryConfigurationFactory());
		}
		set
		{
			instance = value;
		}
	}

	protected TelemetryConfigurationFactory()
	{
	}

	public virtual void Initialize(TelemetryConfiguration configuration, TelemetryModules modules, string serializedConfiguration)
	{
		modules?.Modules.Add(new DiagnosticsTelemetryModule());
		configuration.TelemetryInitializers.Add(new OperationCorrelationTelemetryInitializer());
		if (!string.IsNullOrEmpty(serializedConfiguration))
		{
			try
			{
				XDocument xml = XDocument.Parse(serializedConfiguration);
				LoadFromXml(configuration, modules, xml);
			}
			catch (XmlException ex)
			{
				CoreEventSource.Log.ConfigurationFileCouldNotBeParsedError(ex.Message);
			}
		}
		string environmentVariable = PlatformSingleton.Current.GetEnvironmentVariable("APPINSIGHTS_INSTRUMENTATIONKEY");
		if (!string.IsNullOrEmpty(environmentVariable))
		{
			configuration.InstrumentationKey = environmentVariable;
		}
		configuration.TelemetryChannel = configuration.TelemetryChannel ?? new InMemoryChannel();
		if (configuration.TelemetryProcessors == null)
		{
			configuration.TelemetryProcessorChainBuilder.Build();
		}
		InitializeComponents(configuration, modules);
	}

	public virtual void Initialize(TelemetryConfiguration configuration, TelemetryModules modules)
	{
		Initialize(configuration, modules, PlatformSingleton.Current.ReadConfigurationXml());
	}

	protected static object CreateInstance(Type interfaceType, string typeName, object[] constructorArgs = null)
	{
		Type type = GetType(typeName);
		if (type == null)
		{
			CoreEventSource.Log.TypeWasNotFoundConfigurationError(typeName);
			return null;
		}
		object obj;
		try
		{
			obj = ((constructorArgs != null) ? Activator.CreateInstance(type, constructorArgs) : Activator.CreateInstance(type));
		}
		catch (Exception ex)
		{
			CoreEventSource.Log.MissingMethodExceptionConfigurationError(typeName, ex.Message);
			return null;
		}
		if (!interfaceType.IsAssignableFrom(obj.GetType()))
		{
			CoreEventSource.Log.IncorrectTypeConfigurationError(type.AssemblyQualifiedName, interfaceType.FullName);
			return null;
		}
		return obj;
	}

	protected static void LoadFromXml(TelemetryConfiguration configuration, TelemetryModules modules, XDocument xml)
	{
		LoadInstance(xml.Element(XmlNamespace + "ApplicationInsights"), typeof(TelemetryConfiguration), configuration, null, modules);
	}

	protected static object LoadInstance(XElement definition, Type expectedType, object instance, object[] constructorArgs, TelemetryModules modules)
	{
		if (definition != null)
		{
			XAttribute xAttribute = definition.Attribute("Type");
			if (xAttribute != null)
			{
				if (instance == null || instance.GetType() != GetType(xAttribute.Value))
				{
					instance = CreateInstance(expectedType, xAttribute.Value, constructorArgs);
				}
			}
			else if (!definition.Elements().Any() && !definition.Attributes().Any())
			{
				LoadInstanceFromValue(definition, expectedType, ref instance);
			}
			else if (instance == null && !expectedType.IsAbstract())
			{
				instance = Activator.CreateInstance(expectedType);
			}
			else if (instance == null)
			{
				CoreEventSource.Log.IncorrectInstanceAtributesConfigurationError(definition.Name.LocalName);
			}
			if (instance != null)
			{
				LoadProperties(definition, instance, modules);
				if (GetCollectionElementType(instance.GetType(), out var elementType))
				{
					LoadInstancesDefinition.MakeGenericMethod(elementType).Invoke(null, new object[3] { definition, instance, modules });
				}
			}
		}
		return instance;
	}

	protected static void BuildTelemetryProcessorChain(XElement definition, TelemetryConfiguration telemetryConfiguration)
	{
		TelemetryProcessorChainBuilder telemetryProcessorChainBuilder = telemetryConfiguration.TelemetryProcessorChainBuilder;
		if (definition != null)
		{
			foreach (XElement addElement in definition.Elements(XmlNamespace + "Add"))
			{
				telemetryProcessorChainBuilder = telemetryProcessorChainBuilder.Use(delegate(ITelemetryProcessor current)
				{
					object[] constructorArgs = new object[1] { current };
					return (ITelemetryProcessor)LoadInstance(addElement, typeof(ITelemetryProcessor), telemetryConfiguration, constructorArgs, null);
				});
			}
		}
		telemetryProcessorChainBuilder.Build();
	}

	protected static void LoadInstances<T>(XElement definition, ICollection<T> instances, TelemetryModules modules)
	{
		if (definition == null)
		{
			return;
		}
		foreach (XElement item in definition.Elements(XmlNamespace + "Add"))
		{
			object obj = null;
			XAttribute xAttribute = item.Attribute("Type");
			if (xAttribute != null)
			{
				Type type = GetType(xAttribute.Value);
				obj = instances.FirstOrDefault((T i) => i.GetType() == type);
			}
			if (obj == null)
			{
				obj = LoadInstance(item, typeof(T), obj, null, modules);
				if (obj != null)
				{
					instances.Add((T)obj);
				}
			}
			else
			{
				LoadProperties(item, obj, null);
			}
		}
	}

	protected static void LoadProperties(XElement instanceDefinition, object instance, TelemetryModules modules)
	{
		List<XElement> list = GetPropertyDefinitions(instanceDefinition).ToList();
		if (list.Count <= 0)
		{
			return;
		}
		Type type = instance.GetType();
		Dictionary<string, PropertyInfo> dictionary = type.GetProperties().ToDictionary((PropertyInfo p) => p.Name);
		foreach (XElement item in list)
		{
			string localName = item.Name.LocalName;
			if (dictionary.TryGetValue(localName, out var value))
			{
				if (localName == "TelemetryProcessors")
				{
					BuildTelemetryProcessorChain(item, (TelemetryConfiguration)instance);
					continue;
				}
				object value2 = value.GetValue(instance, null);
				value2 = LoadInstance(item, value.PropertyType, value2, null, modules);
				if (value2 != null && value.CanWrite)
				{
					value.SetValue(instance, value2, null);
				}
			}
			else if (modules != null && localName == "TelemetryModules")
			{
				LoadInstance(item, modules.Modules.GetType(), modules.Modules, null, modules);
			}
			else if (!(instance is TelemetryConfiguration))
			{
				CoreEventSource.Log.IncorrectPropertyConfigurationError(type.AssemblyQualifiedName, localName);
			}
		}
	}

	private static void InitializeComponents(TelemetryConfiguration configuration, TelemetryModules modules)
	{
		InitializeComponent(configuration.TelemetryChannel, configuration);
		InitializeComponents(configuration.TelemetryInitializers, configuration);
		InitializeComponents(configuration.TelemetryProcessorChain.TelemetryProcessors, configuration);
		if (modules != null)
		{
			InitializeComponents(modules.Modules, configuration);
		}
	}

	private static void InitializeComponents(IEnumerable components, TelemetryConfiguration configuration)
	{
		foreach (object component in components)
		{
			InitializeComponent(component, configuration);
		}
	}

	private static void InitializeComponent(object component, TelemetryConfiguration configuration)
	{
		if (component is ITelemetryModule telemetryModule)
		{
			try
			{
				telemetryModule.Initialize(configuration);
			}
			catch (Exception exception)
			{
				CoreEventSource.Log.ComponentInitializationConfigurationError(component.ToString(), exception.ToInvariantString());
			}
		}
	}

	private static void LoadInstanceFromValue(XElement definition, Type expectedType, ref object instance)
	{
		if (string.IsNullOrEmpty(definition.Value))
		{
			instance = (typeof(ValueType).IsAssignableFrom(expectedType) ? Activator.CreateInstance(expectedType) : null);
			return;
		}
		try
		{
			string text = definition.Value.Trim();
			expectedType = Nullable.GetUnderlyingType(expectedType) ?? expectedType;
			if (text == "null")
			{
				instance = null;
			}
			else if (expectedType == typeof(TimeSpan))
			{
				instance = TimeSpan.Parse(text, CultureInfo.InvariantCulture);
			}
			else
			{
				instance = Convert.ChangeType(text, expectedType, CultureInfo.InvariantCulture);
			}
		}
		catch (InvalidCastException ex)
		{
			CoreEventSource.Log.LoadInstanceFromValueConfigurationError(definition.Name.LocalName, definition.Value, ex.Message);
		}
	}

	private static Type GetType(string typeName)
	{
		return GetManagedType(typeName);
	}

	private static Type GetManagedType(string typeName)
	{
		try
		{
			return Type.GetType(typeName);
		}
		catch (IOException)
		{
			return null;
		}
	}

	private static bool GetCollectionElementType(Type type, out Type elementType)
	{
		Type type2 = type.GetInterfaces().FirstOrDefault((Type i) => i.IsGenericType() && i.GetGenericTypeDefinition() == typeof(ICollection<>));
		elementType = ((type2 != null) ? type2.GetGenericArguments()[0] : null);
		return elementType != null;
	}

	private static IEnumerable<XElement> GetPropertyDefinitions(XElement instanceDefinition)
	{
		IEnumerable<XElement> first = from a in instanceDefinition.Attributes()
			where !a.IsNamespaceDeclaration && a.Name.LocalName != "Type"
			select new XElement(a.Name, a.Value);
		IEnumerable<XElement> second = from e in instanceDefinition.Elements()
			where e.Name.LocalName != "Add"
			select e;
		return first.Concat(second);
	}
}
