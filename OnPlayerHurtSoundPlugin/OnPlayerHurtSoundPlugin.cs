using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Utils;
using Microsoft.Extensions.Localization;
using static OnPlayerHurtSoundPlugin.OnPlayerHurtSoundPlugin;

namespace OnPlayerHurtSoundPlugin
{
    [MinimumApiVersion(80)]
    public class OnPlayerHurtSoundPlugin : BasePlugin, IPluginConfig<HurtSoundPluginConfig>
    {
        public override string ModuleName => "OnPlayerHurtSoundPlugin";
        public override string ModuleVersion => "[EarlyBeta]";
        public override string ModuleAuthor => "hlymcn";
        public override string ModuleDescription => "Play a custom sound when a player hurts.";
        public required HurtSoundPluginConfig Config { get; set; }
        public readonly IStringLocalizer<OnPlayerHurtSoundPlugin> _localizer;

        public OnPlayerHurtSoundPlugin(IStringLocalizer<OnPlayerHurtSoundPlugin> localizer)
        {
            _localizer = localizer;
        }

        public override void Load(bool hotReload)
        {
            RegisterEventHandler<EventPlayerHurt>(OnPlayerHurt);
        }

        private HookResult OnPlayerHurt(EventPlayerHurt @event, GameEventInfo info)
        {
            var player = @event.Userid;
            if (player == null || !player.IsValid || player.IsBot)
                return HookResult.Continue;

            if (@event.Attacker == null)
            {
                var sound = Config.HurtSounds[Random.Shared.NextDistinct(Config.HurtSounds.Count)];
                player.ExecuteClientCommand($"play \"{sound}\"");
            }

            return HookResult.Continue;
        }

        public void OnConfigParsed(HurtSoundPluginConfig config)
        {
            Config = config;
            if (config.HurtSounds.Count == 0)
            {
                Server.PrintToConsole("音源文件未设置!");
            }
            else
            {
                Server.PrintToConsole($"载入 {config.HurtSounds.Count} 个音源文件!");
            }
        }

        public class HurtSoundPluginConfig : BasePluginConfig
        {
            public List<string> HurtSounds { get; set; } = [];
        }
    }
}