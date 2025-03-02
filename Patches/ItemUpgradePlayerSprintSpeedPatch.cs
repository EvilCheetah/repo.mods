using HarmonyLib;

namespace REPOTeamBoosters.Patches
{
    [HarmonyPatch(typeof(ItemUpgradePlayerSprintSpeed), nameof(ItemUpgradePlayerSprintSpeed.Upgrade))]
    internal class ItemUpgradePlayerSprintSpeedPatch
    {
        static bool Prefix(ItemUpgradePlayerHealth __instance)
        {
            var players = SemiFunc.PlayerGetAll();

            foreach (var player in players)
            {
                PunManager.instance.UpgradePlayerSprintSpeed(SemiFunc.PlayerGetSteamID(player));
            }

            return false;
        }
    }
}
