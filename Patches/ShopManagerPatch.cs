using HarmonyLib;
using ScalingPrices.Config;
using ScalingPrices.Helpers;

namespace ScalingPrices.Patches
{
    [HarmonyPatch(typeof(ShopManager), "Update")]
    internal class ShopManagerPatch
    {
        static void Postfix(ShopManager __instance)
        {
            ShopManagerHelper.Instance = __instance;

            ShopManagerHelper.ItemValueMultiplier = Configuration.ItemValueMultiplier.Value;
            ShopManagerHelper.UpgradeIncrease     = Configuration.UpgradeIncrease.Value;
            ShopManagerHelper.HealthPackIncrease  = Configuration.HealthPackIncrease.Value;
            ShopManagerHelper.CrystalIncrease     = Configuration.CrystalIncrease.Value;
        }
    }
}
