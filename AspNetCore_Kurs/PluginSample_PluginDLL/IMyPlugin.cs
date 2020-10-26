using System;

namespace PluginSample_PluginDLL
{
    public interface IMyPlugin
    {
        string PluginName { get; set; }
        string Version { get; set; }

        void Execute();
    }
}
