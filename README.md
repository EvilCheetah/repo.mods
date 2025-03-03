# Description
You can now adjust the price scaling for `Crystals`, `Health Packs`, and `Upgrades` (Boosters).

# Note regarding Upgrades
Each upgrade is considered a different type. You will see the changes when you adjust the configuration and purchase multiple units of a single type.
Here is the equation for how the cost is calculated:
```
cost = (BasePriceMultiplier + AdditionalCostPerPlayer * AllPlayers.Count)
```


## Configuration
| Category                   | Variable                    | Default Value   | Description                                                            |
|--------------------------- | --------------------------- | --------------- | ---------------------------------------------------------------------- |
| `ItemType.Upgrade`         | PriceMultiplier             | `0.5`           | Multiplier applied to the base price of items                          |
| `ItemType.Upgrade`         | AdditionalCostPerPlayer     | `0.0`           | Fixed fee added per player to linearly increase the overall item price |
| `ItemType.HealthPack`      | PriceMultiplier             | `0.05`          | Multiplier applied to the base price of items                          |
| `ItemType.HealthPack`      | AdditionalCostPerPlayer     | `0.0`           | Fixed fee added per player to linearly increase the overall item price |
| `ItemType.Crystal`         | PriceMultiplier             | `0.2`           | Multiplier applied to the base price of items                          |
| `ItemType.Crystal`         | AdditionalCostPerPlayer     | `0.0`           | Fixed fee added per player to linearly increase the overall item price |


## Feedback and Suggestions
If you have any feedback or suggestions, feel free to open an issue on the [GitHub repository](https://github.com/EvilCheetah/repo.mods).

## Say Thanks
If you'd like to show your appreciation, you can give me a profile award on my [Steam Page](https://steamcommunity.com/id/EvilCheetah/).
