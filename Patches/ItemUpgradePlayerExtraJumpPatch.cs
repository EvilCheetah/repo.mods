using HarmonyLib;

namespace TeamUpgrades.Patches
{
    [HarmonyPatch(typeof(ItemUpgradePlayerExtraJump), nameof(ItemUpgradePlayerExtraJump.Upgrade))]
    internal class ItemUpgradePlayerExtraJumpPatch
    {
        static bool Prefix(ItemUpgradePlayerExtraJump __instance)
        {
            var players = SemiFunc.PlayerGetAll();

            foreach (var player in players)
            {
                PunManager.instance.UpgradePlayerExtraJump(SemiFunc.PlayerGetSteamID(player));
            }

            return false;
        }
    }
}
