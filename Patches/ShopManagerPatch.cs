using HarmonyLib;
using ScalingPrices.Config;

namespace ScalingPrices.Patches
{
    [HarmonyPatch(typeof(ShopManager), "Update")]
    internal class ShopManagerPatch
    {
        private static readonly AccessTools.FieldRef<ShopManager, float>
            upgrade_increase_ref = AccessTools.FieldRefAccess<ShopManager, float>("upgradeValueIncrease");

        private static readonly AccessTools.FieldRef<ShopManager, float>
            health_pack_increase_ref = AccessTools.FieldRefAccess<ShopManager, float>("healthPackValueIncrease");

        private static readonly AccessTools.FieldRef<ShopManager, float>
            crystal_increase_ref = AccessTools.FieldRefAccess<ShopManager, float>("crystalValueIncrease");

        static void Postfix(ShopManager __instance)
        {
            ref var upgrade_increase = ref upgrade_increase_ref(__instance);
            ref var health_pack_increase = ref health_pack_increase_ref(__instance);
            ref var crystal_increase = ref crystal_increase_ref(__instance);

            upgrade_increase = Configuration.UpgradeBasePriceMultiplier.Value + Configuration.UpgradeAdditionalCostPerPlayer.Value * SemiFunc.PlayerGetAll().Count;
            health_pack_increase = Configuration.HealthPackBasePriceMultiplier.Value + Configuration.HealthPackAdditionalCostPerPlayer.Value * SemiFunc.PlayerGetAll().Count;
            crystal_increase = Configuration.CrystalBasePriceMultiplier.Value + Configuration.CrystalAdditionalCostPerPlayer.Value * SemiFunc.PlayerGetAll().Count;
        }
    }
}
