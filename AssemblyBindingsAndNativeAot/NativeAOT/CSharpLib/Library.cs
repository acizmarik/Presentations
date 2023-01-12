using System.Runtime.InteropServices;

namespace CSharpLib;

public static class Library
{
	[UnmanagedCallersOnly(EntryPoint = "csharp_add_method")]
	public static int Add(int a, int b)
	{
		return a + b;
	}
}
