using HarmonyLib;

namespace TeamUpgrades.Patches
{
    [HarmonyPatch(typeof(ItemUpgradePlayerGrabRange), nameof(ItemUpgradePlayerGrabRange.Upgrade))]
    class ItemUpgradePlayerGrabRangePatch
    {
        static bool Prefix(ItemUpgradePlayerGrabRange __instance)
        {
            var players = SemiFunc.PlayerGetAll();

            foreach (var player in players)
            {
                PunManager.instance.UpgradePlayerGrabRange(SemiFunc.PlayerGetSteamID(player));
            }

            return false;
        }
    }
}
