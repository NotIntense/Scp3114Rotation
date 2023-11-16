using Exiled.API.Interfaces;
using System.ComponentModel;

namespace Scp3114Rotation
{
    public class Config : IConfig
    {
        [Description("Gets or sets if the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Gets or sets if the plugin's debug logs are enabled.")]
        public bool Debug { get; set; } = false;

        [Description("Gets or sets a % chance SCP-106 has to be replaced by SCP-3114.")]
        public int ReplacementChance { get; set; } = 50;
    }
}
