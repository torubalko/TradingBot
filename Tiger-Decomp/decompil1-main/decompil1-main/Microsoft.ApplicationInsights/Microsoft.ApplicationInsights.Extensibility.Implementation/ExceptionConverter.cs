using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

internal static class ExceptionConverter
{
	public const int MaxParsedStackLength = 32768;

	internal static ExceptionDetails ConvertToExceptionDetails(Exception exception, ExceptionDetails parentExceptionDetails)
	{
		ExceptionDetails exceptionDetails = ExceptionDetails.CreateWithoutStackInfo(exception, parentExceptionDetails);
		Tuple<List<Microsoft.ApplicationInsights.Extensibility.Implementation.External.StackFrame>, bool> tuple = SanitizeStackFrame(new StackTrace(exception, fNeedFileInfo: true).GetFrames(), GetStackFrame, GetStackFrameLength);
		exceptionDetails.parsedStack = tuple.Item1;
		exceptionDetails.hasFullStack = tuple.Item2;
		return exceptionDetails;
	}

	private static Tuple<List<TOutput>, bool> SanitizeStackFrame<TInput, TOutput>(IList<TInput> inputList, Func<TInput, int, TOutput> converter, Func<TOutput, int> lengthGetter)
	{
		List<TOutput> list = new List<TOutput>();
		bool item = true;
		if (inputList != null && inputList.Count > 0)
		{
			int num = 0;
			for (int i = 0; i < inputList.Count; i++)
			{
				int num2 = ((i % 2 == 0) ? (inputList.Count - 1 - i / 2) : (i / 2));
				TOutput val = converter(inputList[num2], num2);
				num += lengthGetter(val);
				if (num > 32768)
				{
					item = false;
					break;
				}
				list.Insert(list.Count / 2, val);
			}
		}
		return new Tuple<List<TOutput>, bool>(list, item);
	}

	private static Microsoft.ApplicationInsights.Extensibility.Implementation.External.StackFrame GetStackFrame(System.Diagnostics.StackFrame stackFrame, int frameId)
	{
		Microsoft.ApplicationInsights.Extensibility.Implementation.External.StackFrame stackFrame2 = new Microsoft.ApplicationInsights.Extensibility.Implementation.External.StackFrame
		{
			level = frameId
		};
		MethodBase method = stackFrame.GetMethod();
		string method2 = ((!(method.DeclaringType != null)) ? method.Name : (method.DeclaringType.FullName + "." + method.Name));
		stackFrame2.method = method2;
		stackFrame2.assembly = method.Module.Assembly.FullName;
		stackFrame2.fileName = stackFrame.GetFileName();
		int fileLineNumber = stackFrame.GetFileLineNumber();
		if (fileLineNumber != 0)
		{
			stackFrame2.line = fileLineNumber;
		}
		return stackFrame2;
	}

	private static int GetStackFrameLength(Microsoft.ApplicationInsights.Extensibility.Implementation.External.StackFrame stackFrame)
	{
		return ((stackFrame.method != null) ? stackFrame.method.Length : 0) + ((stackFrame.assembly != null) ? stackFrame.assembly.Length : 0) + ((stackFrame.fileName != null) ? stackFrame.fileName.Length : 0);
	}
}
