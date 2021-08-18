using ImGuiNET;
using System.Numerics;

namespace BlueMageHelper
{
    public class PluginUI
    {
        public bool IsVisible { get; set; }

        //settings
        private Configuration config;
        
        //constructor
        public PluginUI(Configuration config)
        {
            this.config = config;
        }

        public void Draw()
        {
            if (!IsVisible)
                return;
            var mobData = DataHandler.Mobs(TargetData.NameID);
            var flags = ImGuiWindowFlags.NoResize | ImGuiWindowFlags.AlwaysAutoResize | ImGuiWindowFlags.NoTitleBar;
            if(config.isLocked)
            {
                flags |= ImGuiWindowFlags.NoInputs;
            }
            ImGui.SetNextWindowSizeConstraints(new Vector2(250, 0), new Vector2(9001, 9001));
            ImGui.SetNextWindowBgAlpha(config.Opacity);
            
            ImGui.Begin("MobInfo", flags);
            // if(mobData != null)
            if(true)
            {
                ImGui.Text("Name:\n" + TargetData.Name);
                ImGui.NewLine();
                // ImGui.Text("Difficulty:\n" + mobData.Difficulty);
                ImGui.Text("NameID:\n" + TargetData.NameID);
            }
            // else
            // {
            //     ImGui.Text(("No Data"));
            // }
            ImGui.End();
        }
    }
}
