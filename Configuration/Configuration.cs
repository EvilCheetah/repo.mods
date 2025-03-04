﻿using BepInEx.Configuration;


namespace TeamUpgrades.Configuration
{
    internal class Configuration
    {
        public static ConfigEntry<bool> EnableItemUpgradeMapPlayerCountPatch;
        public static ConfigEntry<bool> EnableItemUpgradePlayerEnergyPatch;
        public static ConfigEntry<bool> EnableItemUpgradePlayerExtraJumpPatch;
        public static ConfigEntry<bool> EnableItemUpgradePlayerGrabRangePatch;
        public static ConfigEntry<bool> EnableItemUpgradePlayerGrabStrengthPatch;
        public static ConfigEntry<bool> EnableItemUpgradePlayerGrabThrowPatch;
        public static ConfigEntry<bool> EnableItemUpgradePlayerHealthPatch;
        public static ConfigEntry<bool> EnableItemUpgradePlayerSprintSpeedPatch;
        public static ConfigEntry<bool> EnableItemUpgradePlayerTumbleLaunchPatch;

        public static void Init(ConfigFile config)
        {
            EnableItemUpgradeMapPlayerCountPatch = config.Bind<bool>(
                "General",
                "EnableUpgradeMapPlayer",
                true,
                "Enables Team Upgrades for Map Player Count Upgrade"
            );

            EnableItemUpgradePlayerEnergyPatch = config.Bind<bool>(
                "General",
                "EnableUpgradePlayerEnergy",
                true,
                "Enables Team Upgrades for Player Energy Upgrade"
            );

            EnableItemUpgradePlayerExtraJumpPatch = config.Bind<bool>(
                "General",
                "EnableUpgradePlayerExtraJump",
                true,
                "Enables Team Upgrades for Player Extra Jump Upgrade"
            );

            EnableItemUpgradePlayerGrabRangePatch = config.Bind<bool>(
                "General",
                "EnableUpgradePlayerGrabRange",
                true,
                "Enables Team Upgrades for Player Grab Range Upgrade"
            );

            EnableItemUpgradePlayerGrabStrengthPatch = config.Bind<bool>(
                "General",
                "EnableUpgradePlayerGrabStrength",
                true,
                "Enables Team Upgrades for Player Grab Strength Upgrade"
            );

            EnableItemUpgradePlayerGrabThrowPatch = config.Bind<bool>(
                "General",
                "EnableUpgradePlayerGrabThrow",
                true,
                "Enables Team Upgrades for Player Grab Throw Upgrade"
            );

            EnableItemUpgradePlayerHealthPatch = config.Bind<bool>(
                "General",
                "EnableUpgradePlayerHealth",
                true,
                "Enables Team Upgrades for Player Health Upgrade"
            );

            EnableItemUpgradePlayerSprintSpeedPatch = config.Bind<bool>(
                "General",
                "EnableUpgradePlayerSprintSpeed",
                true,
                "Enables Team Upgrades for Player Sprint Speed Upgrade"
            );

            EnableItemUpgradePlayerTumbleLaunchPatch = config.Bind<bool>(
                "General",
                "EnableUpgradePlayerTumbleLaunch",
                true,
                "Enables Team Upgrades for Player Tumble Launch Upgrade"
            );
        }
    }
}
