using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using TeamHeals.Config;
using TeamHeals.Patches;

namespace TeamHeals
{
    [BepInPlugin(mod_guid, mod_name, mod_version)]
    public class TeamHealsPlugin : BaseUnityPlugin
    {
        private const string mod_guid    = "EvilCheetah.REPO.TeamHeals";
        private const string mod_name    = "Team Heals";
        private const string mod_version = "1.0.0";

        private readonly Harmony harmony = new Harmony(mod_guid);

        private static TeamHealsPlugin instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }

            Configuration.Init(Config);

            mls = BepInEx.Logging.Logger.CreateLogSource(mod_guid);

            mls.LogInfo("Team Heals mod has been activated");

            harmony.PatchAll(typeof(TeamHealsPlugin));
            harmony.PatchAll(typeof(ItemHealthPackPatch));
            harmony.PatchAll(typeof(PunManagerPatch));
        }
    }
}
