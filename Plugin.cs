using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Loader;

namespace Scp3114Rotation
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "NotIntense";
        public override string Name { get; } = "SCP-3114Rotation";
        public override bool IgnoreRequiredVersionCheck { get; } = true;

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Spawned += OnSpawn;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Spawned -= OnSpawn;
            base.OnDisabled();
        }

        public void OnSpawn(SpawnedEventArgs ev)
        {
            if(ev.Reason == Exiled.API.Enums.SpawnReason.RoundStart 
                && ev.Player.Role.Type == PlayerRoles.RoleTypeId.Scp106 
                && Player.List.Where(x => x.Role.Type == PlayerRoles.RoleTypeId.Scp3114).Count() < 1)
            {
                int chance = Loader.Random.Next(0, 101);

                if (chance <= Config.ReplacementChance)
                    ev.Player.Role.Set(PlayerRoles.RoleTypeId.Scp3114);
            }
        }
    }
}