using BepInEx.Configuration;

namespace TeamHeals.Config
{
    internal class Configuration
    {
        public static ConfigEntry<float> HealAmountMultiplier;

        public static void Init(ConfigFile config)
        {
            HealAmountMultiplier = config.Bind<float>(
                "General",
                "HealAmountMultiplier",
                1f,
                "Multiplier applied to the health pack healing"
            );
        }
    }
}
