using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using ScalingPrices.Config;
using ScalingPrices.Patches;

namespace ScalingPrices
{
    [BepInPlugin(mod_guid, mod_name, mod_version)]
    public class ScalingPricingBase : BaseUnityPlugin
    {
        private const string mod_guid    = "EvilCheetah.REPO.PlayerCountPricing";
        private const string mod_name    = "Scaling Prices";
        private const string mod_version = "1.1.1";

        private readonly Harmony harmony = new Harmony(mod_guid);

        private static ScalingPricingBase instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(mod_guid);
            Configuration.Init(Config);

            mls.LogInfo("Player Count Pricing mod has been activated");

            harmony.PatchAll(typeof(ScalingPricingBase));
            harmony.PatchAll(typeof(ShopManagerPatch));
            harmony.PatchAll(typeof(ItemAttributesPatch));
        }
    }
}
