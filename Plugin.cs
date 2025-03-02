using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using REPOTeamBoosters.Patches;
using TeamUpgrades.Patches;


namespace REPOTeamBoosters
{
    [BepInPlugin(mod_guid, mod_name, mod_version)]
    public class TeamBoostersBase : BaseUnityPlugin
    {
        private const string mod_guid = "EvilCheetah.REPO.TeamBoosters";
        private const string mod_name = "R.E.P.O. Team Boosters";
        private const string mod_version = "1.0.0";

        private readonly Harmony harmony = new Harmony(mod_guid);

        private static TeamBoostersBase instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(mod_guid);

            mls.LogInfo("Team Boosters mod has been activated");

            harmony.PatchAll(typeof(TeamBoostersBase));
            harmony.PatchAll(typeof(ItemUpgradeMapPlayerCountPatch));
            harmony.PatchAll(typeof(ItemUpgradePlayerEnergyPatch));
            harmony.PatchAll(typeof(ItemUpgradePlayerExtraJumpPatch));
            harmony.PatchAll(typeof(ItemUpgradePlayerGrabRangePatch));
            harmony.PatchAll(typeof(ItemUpgradePlayerGrabStrengthPatch));
            harmony.PatchAll(typeof(ItemUpgradePlayerGrabThrowPatch));
            harmony.PatchAll(typeof(ItemUpgradePlayerHealthPatch));
            harmony.PatchAll(typeof(ItemUpgradePlayerSprintSpeedPatch));
            harmony.PatchAll(typeof(ItemUpgradePlayerTumbleLaunchPatch));
        }
    }
}
