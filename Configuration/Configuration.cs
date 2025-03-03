using BepInEx.Configuration;

namespace ScalingPrices.Config
{
    internal class Configuration
    {
        public static ConfigEntry<float> UpgradeBasePriceMultiplier;
        public static ConfigEntry<float> UpgradeAdditionalCostPerPlayer;

        public static ConfigEntry<float> HealthPackBasePriceMultiplier;
        public static ConfigEntry<float> HealthPackAdditionalCostPerPlayer;

        public static ConfigEntry<float> CrystalBasePriceMultiplier;
        public static ConfigEntry<float> CrystalAdditionalCostPerPlayer;

        public static void Init(ConfigFile config)
        {
            UpgradeBasePriceMultiplier = config.Bind<float>(
                "ItemType.Upgrade",
                "PriceMultiplier",
                0.5f,
                "Multiplier applied to the base price of items"
            );

            UpgradeAdditionalCostPerPlayer = config.Bind<float>(
                "ItemType.Upgrade",
                "AdditionalCostPerPlayer",
                0f,
                "Fixed fee added per player to linearly increase the overall item price"
            );


            HealthPackBasePriceMultiplier = config.Bind<float>(
                "ItemType.HealthPack",
                "PriceMultiplier",
                0.05f,
                "Multiplier applied to the base price of items"
            );

            HealthPackAdditionalCostPerPlayer = config.Bind<float>(
                "ItemType.HealthPack",
                "AdditionalCostPerPlayer",
                0f,
                "Fixed fee added per player to linearly increase the overall item price"
            );


            CrystalBasePriceMultiplier = config.Bind<float>(
                "ItemType.Crystal",
                "PriceMultiplier",
                0.2f,
                "Multiplier applied to the base price of items"
            );

            CrystalAdditionalCostPerPlayer = config.Bind<float>(
                "ItemType.Crystal",
                "AdditionalCostPerPlayer",
                0f,
                "Fixed fee added per player to linearly increase the overall item price"
            );
        }
    }
}
