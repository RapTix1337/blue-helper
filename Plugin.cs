using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using BlueMageHelper.Attributes;
using Dalamud.Game.Text.SeStringHandling.Payloads;
using Dalamud.Game.ClientState.Actors.Types;
using Dalamud.Game.Internal;
using Dalamud.Plugin;
using Lumina.Excel.GeneratedSheets;
using Action = Lumina.Excel.GeneratedSheets.Action;

namespace BlueMageHelper
{
    public class Plugin : IDalamudPlugin
    {
        private DalamudPluginInterface pluginInterface;
        private PluginCommandManager<Plugin> commandManager;
        private Configuration config;
        private PluginUI ui;
        private ConfigUI cui;
        private Actor previousTarget;
        internal PluginAddressResolver Address;
        private IsActionUnlockedDelegate IsActionUnlocked;

        public string Name => "Blue Mage Helper";

        public void Initialize(DalamudPluginInterface pluginInterface)
        {
            this.pluginInterface = pluginInterface ?? throw new ArgumentNullException(nameof(pluginInterface), "DalamudPluginInterface cannot be null");

            this.config = (Configuration)this.pluginInterface.GetPluginConfig() ?? new Configuration();
            this.config.Initialize(this.pluginInterface);

            this.ui = new PluginUI(config);
            this.cui = new ConfigUI(config.Opacity, config.isLocked, config);
            this.pluginInterface.UiBuilder.OnBuildUi += this.ui.Draw;
            this.pluginInterface.UiBuilder.OnBuildUi += this.cui.Draw;

            this.commandManager = new PluginCommandManager<Plugin>(this, this.pluginInterface);
            
            this.pluginInterface.Framework.OnUpdateEvent += this.GetData;
            Address = new PluginAddressResolver();
            Address.Setup(pluginInterface.TargetModuleScanner);
            IsActionUnlocked = Marshal.GetDelegateForFunctionPointer<IsActionUnlockedDelegate>(Address.IsActionUnlockedAddress);

            try
            {
                LoadData();
            }
            catch (Exception e)
            {
                PluginLog.Error(e, "Boom");
            }
        }

        [Command("/bmhc")]
        [HelpMessage("Opens the Blue Mage Helper Config")]
        public void OpenConfig(string command, string args)
        {
            cui.IsVisible = true;
        }
        
        internal List<ActionData> ActionDataStorage = new();

        [Command("/test")]
        [HelpMessage("Opens the Blue Mage Helper Config")]
        public void Test(string command, string args)
        {
            PluginLog.Debug("Trying to load Blue spell names:");
            ActionDataStorage.ForEach(data => PluginLog.Debug(data.Name+":"+data.IsActionUnlocked));
        }
        
        
        public void LoadData()
        {
            var aozActionSheet = pluginInterface.Data.GetExcelSheet<AozAction>();
            var actionSheet = pluginInterface.Data.GetExcelSheet<Action>();
            var aozActionTransientSheet = pluginInterface.Data.GetExcelSheet<AozActionTransient>();
            var actionTransientSheet = pluginInterface.Data.GetExcelSheet<ActionTransient>();
            bool first = true;

            foreach (var row in aozActionSheet)
            {
                if (row.RowId == 0)
                    continue;

                var aozActionRow = row.Action.Value;
                var actionTransientRow = actionTransientSheet.GetRow(aozActionRow.RowId);
                var aozActionTransientRow = aozActionTransientSheet.GetRow(row.RowId);

                var statsParts = GetLuminaSeStringParts(aozActionTransientRow.Stats);
                if (first)
                {
                    PluginLog.Debug("Blue Debug:");
                    PluginLog.Debug(GetLuminaSeStringText(aozActionRow.Name)+":");
                    // PluginLog.Debug(aozActionTransientRow.Unknown10);
                    // foreach (string stat in statsParts)
                    // {
                    //     PluginLog.Debug(stat);
                    // }

                    first = false;
                }

                var spellType = (SpellType)Enum.Parse(typeof(SpellType), statsParts[0]);

                var spellAspects = statsParts[1].Split('/')
                    .Select(str => (SpellAspect)Enum.Parse(typeof(SpellAspect), str))
                    .ToArray();

                var spellRank = (SpellRank)statsParts[2].Trim().Length - 1;

                var spellTarget = (SpellTarget)0;
                if (aozActionTransientRow.TargetsEnemy)
                    spellTarget |= SpellTarget.Enemy;
                if (aozActionTransientRow.TargetsSelfOrAlly)
                    spellTarget |= SpellTarget.SelfOrAlly;
                if (spellTarget == 0)
                    spellTarget = SpellTarget.Untargetable;

                var spellEffects = new object[] {
                    aozActionTransientRow.CauseSlow ? SpellEffect.Slow : null,
                    aozActionTransientRow.CausePetrify ? SpellEffect.PetrificationAndFreeze : null,
                    aozActionTransientRow.CauseParalysis ? SpellEffect.Paralysis : null,
                    aozActionTransientRow.CauseInterrupt ? SpellEffect.Interruption : null,
                    aozActionTransientRow.CauseBlind? SpellEffect.Blind : null,
                    aozActionTransientRow.CauseStun ? SpellEffect.Stun : null,
                    aozActionTransientRow.CauseSleep ? SpellEffect.Sleep : null,
                    aozActionTransientRow.CauseBind ? SpellEffect.Bind : null,
                    aozActionTransientRow.CauseHeavy ? SpellEffect.Heavy : null,
                    aozActionTransientRow.CauseDeath ? SpellEffect.FlatDamageAndDeath : null,
                }.OfType<SpellEffect>().ToArray();

                var iconTex = pluginInterface.Data.GetIcon(aozActionRow.Icon);

                ActionDataStorage.Add(new()
                {
                    ActionID = aozActionRow.RowId,
                    Number = aozActionTransientRow.Number,
                    Name = GetLuminaSeStringText(aozActionRow.Name),
                    Description = GetLuminaSeStringText(actionTransientRow.Description),
                    Fluff = GetLuminaSeStringText(aozActionTransientRow.Description),
                    Rank = spellRank,
                    Type = spellType,
                    Target = spellTarget,
                    Aspects = spellAspects,
                    Effects = spellEffects,
                    IconID = aozActionRow.Icon,
                    CastTime = (SpellCast)aozActionRow.Cast100ms,
                    RecastTime = (SpellRecast)aozActionRow.Recast100ms,
                    IsActionUnlocked = IsActionUnlocked(Address.ClientGameUiHotbarAddress, aozActionRow.UnlockLink)
                }); ;
            }

            ActionDataStorage = ActionDataStorage.OrderBy(data => data.Number).ToList();
        }
        
        private string[] GetLuminaSeStringParts(Lumina.Text.SeString seString)
        {
            var bytes = Encoding.UTF8.GetBytes(seString.RawString);
            var parts = pluginInterface.SeStringManager.Parse(bytes).Payloads
                .OfType<TextPayload>()
                .Where(payload => !payload.Text.StartsWith("\u0003"))
                .Select(payload => payload.Text)
                .ToArray();
            return parts;
        }

        private string GetLuminaSeStringText(Lumina.Text.SeString seString)
        {
            return string.Join("", GetLuminaSeStringParts(seString));
        }


        public void GetData(Framework framework)
        {
            var target = pluginInterface.ClientState.Targets.CurrentTarget;
            if (target == null || target == previousTarget)
            {
                ui.IsVisible = false;
                return;
            }

            TargetData t = new TargetData();
            if (!t.IsBattleNpc(target))
            {
                ui.IsVisible = false;
                return;
            }
            else
            {
                previousTarget = target;
                ui.IsVisible = true;
            }

            ui.IsVisible = true;
        }

        #region IDisposable Support
        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;

            this.commandManager.Dispose();

            this.pluginInterface.SavePluginConfig(this.config);

            this.pluginInterface.UiBuilder.OnBuildUi -= this.ui.Draw;

            this.pluginInterface.Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
