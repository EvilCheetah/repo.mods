using HarmonyLib;

namespace ScalingPrices.Helpers
{
    class ShopManagerHelper
    {
        public static ShopManager Instance { get; set; }


        private static readonly AccessTools.FieldRef<ShopManager, float>
            item_value_multiplier_ref = AccessTools.FieldRefAccess<ShopManager, float>("itemValueMultiplier");

        private static readonly AccessTools.FieldRef<ShopManager, float>
            upgrade_increase_ref      = AccessTools.FieldRefAccess<ShopManager, float>("upgradeValueIncrease");

        private static readonly AccessTools.FieldRef<ShopManager, float>
            health_pack_increase_ref  = AccessTools.FieldRefAccess<ShopManager, float>("healthPackValueIncrease");

        private static readonly AccessTools.FieldRef<ShopManager, float>
            crystal_increase_ref      = AccessTools.FieldRefAccess<ShopManager, float>("crystalValueIncrease");


        public static float ItemValueMultiplier
        {
            get => item_value_multiplier_ref(Instance);
            set => item_value_multiplier_ref(Instance) = value;
        }

        public static float UpgradeIncrease
        {
            get => upgrade_increase_ref(Instance);
            set => upgrade_increase_ref(Instance) = value;
        }

        public static float HealthPackIncrease
        {
            get => health_pack_increase_ref(Instance);
            set => health_pack_increase_ref(Instance) = value;
        }

        public static float CrystalIncrease
        {
            get => crystal_increase_ref(Instance);
            set => crystal_increase_ref(Instance) = value;
        }
    }
}
