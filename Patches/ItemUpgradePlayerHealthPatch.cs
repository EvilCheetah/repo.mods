using HarmonyLib;

namespace REPOTeamBoosters.Patches
{
    [HarmonyPatch(typeof(ItemUpgradePlayerHealth), nameof(ItemUpgradePlayerHealth.Upgrade))]
    internal class ItemUpgradePlayerHealthPatch
    {
        static bool Prefix(ItemUpgradePlayerHealth __instance)
        {
            var players = SemiFunc.PlayerGetAll();

            foreach (var player in players)
            {
                PunManager.instance.UpgradePlayerHealth(SemiFunc.PlayerGetSteamID(player));
            }

            return false;
        }
    }
}
