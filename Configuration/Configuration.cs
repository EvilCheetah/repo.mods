using BepInEx.Configuration;

namespace ScalingPrices.Config
{
    internal class Configuration
    {
        public static ConfigEntry<float> ItemValueMultiplier;
        public static ConfigEntry<float> UpgradeIncrease;
        public static ConfigEntry<float> HealthPackIncrease;
        public static ConfigEntry<float> CrystalIncrease;

        public static ConfigEntry<float> UpgradeIncreasePerPlayer;
        public static ConfigEntry<float> HealthPackIncreasePerPlayer;
        public static ConfigEntry<float> CrystalIncreasePerPlayer;

        public static void Init(ConfigFile config)
        {
            ItemValueMultiplier = config.Bind<float>(
                "Default",
                "ValueMultiplier",
                4f,
                "Multiplier applied to the base price of items"
            );

            UpgradeIncrease = config.Bind<float>(
                "Default",
                "UpgradeIncrease",
                0.5f,
                "Multiplier applied to the base price of items"
            );

            HealthPackIncrease = config.Bind<float>(
                "Default",
                "HealthPackIncrease",
                0.05f,
                "Multiplier applied to the base price of items"
            );

            CrystalIncrease = config.Bind<float>(
                "Default",
                "CrystalIncrease",
                0.2f,
                "Multiplier applied to the base price of items"
            );


            UpgradeIncreasePerPlayer = config.Bind<float>(
                "PerPlayerIncrease",
                "UpgradeIncrease",
                0f,
                "Multiplier applied to the base price of items"
            );

            HealthPackIncreasePerPlayer = config.Bind<float>(
                "PerPlayerIncrease",
                "HealthPackIncrease",
                0f,
                "Multiplier applied to the base price of items"
            );

            CrystalIncreasePerPlayer = config.Bind<float>(
                "PerPlayerIncrease",
                "CrystalIncrease",
                0f,
                "Multiplier applied to the base price of items"
            );
        }
    }
}
