using HarmonyLib;

namespace REPOTeamBoosters.Patches
{
    [HarmonyPatch(typeof(ItemUpgradeMapPlayerCount), nameof(ItemUpgradeMapPlayerCount.Upgrade))]
    internal class ItemUpgradeMapPlayerCountPatch
    {
        static bool Prefix(ItemUpgradeMapPlayerCount __instance)
        {
            var players = SemiFunc.PlayerGetAll();

            foreach (var player in players)
            {
                PunManager.instance.UpgradeMapPlayerCount(SemiFunc.PlayerGetSteamID(player));
            }

            return false;
        }
    }
}
