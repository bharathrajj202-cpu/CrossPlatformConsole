using System;
using System.Runtime.InteropServices;
namespace CrossPlatformConsole;
class Program
{
    static void Main(string[] args)
    {
        var platform = GetPlatformInfo();
        Console.WriteLine("Cross Platform Application: ");
        Console.WriteLine("Operating System: "+platform.OS);
        Console.WriteLine("Architecture: "+platform.Architecture);
    }

    static (string OS,string Architecture) GetPlatformInfo()
    {
        return(RuntimeInformation.OSDescription,RuntimeInformation.ProcessArchitecture.ToString());
    }
}