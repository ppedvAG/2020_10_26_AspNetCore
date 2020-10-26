using PluginSample_PluginDLL;
using System;

namespace PluginSample_ThePlugin
{
    public class MySpecialPlugIn : IMyPlugin
    {
        public string PluginName { get; set; } = "MySpecial Plugin Sonder Edition";
        public string Version { get; set; } = "Version 1.2";

        public void Execute()
        {
            Console.WriteLine($"MySpecialPlugIn wirtd ausgeführt");
        }
    }
}
