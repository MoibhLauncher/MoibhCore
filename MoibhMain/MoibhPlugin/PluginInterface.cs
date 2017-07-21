using System;
using System.Collections.Generic;
using System.Text;

namespace  MoibhPlugin
{
    public interface PluginInterface
    {
        PluginInfo GetPluginInfo();
        void RegPermission();
    }
}
