using System;

using ImGuiNET;
using System.Diagnostics;
using System.Numerics;

namespace BlueMageHelper
{
    public class ConfigUI
    {
        public bool IsVisible { get; set; }
        private float opacity;
        private bool isLocked;
        private Configuration config;

        public ConfigUI(float opacity, bool isLocked, Configuration config)
        {
            this.config = config;
            this.opacity = opacity;
            this.isLocked = isLocked;
        }

        public void Draw()
        {
            if (!IsVisible)
                return;
            var flags = ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoTitleBar | ImGuiWindowFlags.AlwaysAutoResize;
            ImGui.SetNextWindowSizeConstraints(new Vector2(250, 100), new Vector2(1000, 1000));
            ImGui.Begin("config", flags);
            if (ImGui.SliderFloat("Opacity", ref opacity, 0.0f, 1.0f))
            {
                config.Opacity = opacity;
            }
            ImGui.NewLine();
            if (ImGui.Checkbox("Lock mob info box and enable clickthrough", ref isLocked))
            {
                config.isLocked = isLocked;
            }
            ImGui.NewLine();
            if (ImGui.Button("Save"))
            {
                IsVisible = false;
                config.Save();
            }
            
            ImGui.SameLine();
            ImGui.End();
        }
    }
}