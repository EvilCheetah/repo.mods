# Description
You can now adjust the price scaling for `Crystals`, `Health Packs`, and `Upgrades` (Boosters).

**How It Works in the Code:**
- **Initial Calculation:**  
    The item's value is first calculated using a random range multiplied by `ValueMultiplier`. It is then normalized (with a minimum of 1000, then divided by 1000 and rounded up).

- **Bonus Adjustments:**  
    Depending on the item type, the code increases the value further:  
    - **For Upgrades:** The value is increased by a percentage based on the number of upgrades purchased multiplied by `UpgradeIncrease` (from the Default category) and an additional fixed bonus per player from the PerPlayerIncrease setting.  
    - **For Health Packs & Power Crystals:** The value is boosted by a percentage based on the levels completed multiplied by their respective Default increase values and a fixed bonus per player from the corresponding PerPlayerIncrease value.

## **Summary of Scaling Factors**

| Item Type          | Scaling Factors                                |
| ------------------ | ---------------------------------------------- |
| **Upgrades**       | Increases with number of purchases and players |
| **Health Packs**   | Increases with levels completed and players    |
| **Power Crystals** | Increases with levels completed and players    |


## Configuration
| Category            | Variable              | Default Value | Description                                                                                                            |
| ------------------- | --------------------- | ------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `Default`           | ValueMultiplier       | `4`           | Multiplies the base random value range to determine the item's initial value.                                          |
| `Default`           | UpgradeIncrease       | `0.5`         | Applies a percentage bonus for upgrade items based on the number of upgrades purchased for the specific upgrade type.  |
| `Default`           | HealthPackIncrease    | `0.05`        | Applies a percentage bonus for health packs based on the number of levels completed.                                   |
| `Default`           | CrystalIncrease       | `0.2`         | Applies a percentage bonus for power crystals based on the number of levels completed.                                 |
| `PerPlayerIncrease` | UpgradeIncrease       | `0.0`         | Adds a fixed bonus per active player for upgrade items.                                                                |
| `PerPlayerIncrease` | HealthPackIncrease    | `0.0`         | Adds a fixed bonus per active player for health pack items.                                                            |
| `PerPlayerIncrease` | CrystalIncrease       | `0.0`         | Adds a fixed bonus per active player for power crystal items.                                                          |


## Feedback and Suggestions
If you have any feedback or suggestions, feel free to open an issue on the [GitHub repository](https://github.com/EvilCheetah/repo.mods).

## Say Thanks
If you'd like to show your appreciation, you can give me a profile award on my [Steam Page](https://steamcommunity.com/id/EvilCheetah/).
