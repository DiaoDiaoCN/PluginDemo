using System.ComponentModel;

namespace ClassLibrary1
{
    internal sealed class MyConfig
    {
        [Description("是否启用")]
        public bool Enable { get; set; } = true;
    }
}
