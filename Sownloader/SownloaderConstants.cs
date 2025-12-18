using System.Reflection;

namespace Sownloader;

public static class SownloaderConstants
{
    public static string GetVersion()
    {
        return Assembly.GetEntryAssembly()!.GetName()!.Version!.ToString(3);
    }
}
