using System;
using System.Reflection;

try
{
	Assembly.Load("Assembly.dll");
}
catch (Exception ex)
{
	Console.WriteLine(ex.ToString());
}