using Dalamud.Configuration;
using Dalamud.Plugin;
using Newtonsoft.Json;

namespace BlueMageHelper
{
    public class Configuration : IPluginConfiguration
    {
        public int Version { get; set; }
        public float Opacity { get; set; } = 1.0f;
        public bool isLocked { get; set; } = false;

        // Add any other properties or methods here.
        [JsonIgnore] private DalamudPluginInterface pluginInterface;

        public void Initialize(DalamudPluginInterface pluginInterface)
        {
            this.pluginInterface = pluginInterface;
        }

        public void Save()
        {
            this.pluginInterface.SavePluginConfig(this);
        }
    }
}
