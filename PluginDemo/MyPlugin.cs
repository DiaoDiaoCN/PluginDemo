using PluginAPI.Core.Attributes;
using PluginAPI.Events;

namespace ClassLibrary1
{
    internal class MyPlugin
    {
        public static MyPlugin myPlugin { get; private set; }

        [PluginEntryPoint("我的插件", "1.0.0", "我的第一个插件.", "作者")]
        void LoadPlugin()
        {
            myPlugin = this;
            EventManager.RegisterEvents(this);
        }

        [PluginConfig]
        public MyConfig DDconfig;
    }
}
