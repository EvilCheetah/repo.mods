using HarmonyLib;

namespace TeamUpgrades.Patches
{
    [HarmonyPatch(typeof(ItemUpgradePlayerTumbleLaunch), nameof(ItemUpgradePlayerTumbleLaunch.Upgrade))]
    class ItemUpgradePlayerTumbleLaunchPatch
    {
        static bool Prefix(ItemUpgradePlayerTumbleLaunch __instance)
        {
            var players = SemiFunc.PlayerGetAll();

            foreach (var player in players)
            {
                PunManager.instance.UpgradePlayerTumbleLaunch(SemiFunc.PlayerGetSteamID(player));
            }

            return false;
        }
    }
}
