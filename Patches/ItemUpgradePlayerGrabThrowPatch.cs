using HarmonyLib;

namespace TeamUpgrades.Patches
{
    [HarmonyPatch(typeof(ItemUpgradePlayerGrabThrow), nameof(ItemUpgradePlayerGrabThrow.Upgrade))]
    class ItemUpgradePlayerGrabThrowPatch
    {
        static bool Prefix(ItemUpgradePlayerGrabThrow __instance)
        {
            var players = SemiFunc.PlayerGetAll();

            foreach (var player in players)
            {
                PunManager.instance.UpgradePlayerThrowStrength(SemiFunc.PlayerGetSteamID(player));
            }

            return false;
        }
    }
}
