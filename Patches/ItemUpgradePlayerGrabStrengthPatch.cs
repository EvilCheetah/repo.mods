using HarmonyLib;

namespace TeamUpgrades.Patches
{
    [HarmonyPatch(typeof(ItemUpgradePlayerGrabStrength), nameof(ItemUpgradePlayerGrabStrength.Upgrade))]
    class ItemUpgradePlayerGrabStrengthPatch
    {
        static bool Prefix(ItemUpgradePlayerGrabStrength __instance)
        {
            var players = SemiFunc.PlayerGetAll();

            foreach (var player in players)
            {
                PunManager.instance.UpgradePlayerGrabStrength(SemiFunc.PlayerGetSteamID(player));
            }

            return false;
        }
    }
}
