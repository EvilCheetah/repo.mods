using System;
using HarmonyLib;
using TeamHeals.Config;

namespace TeamHeals.Patches
{
    [HarmonyPatch(typeof(ItemHealthPack))]
    internal class ItemHealthPackPatch
    {
        private static readonly AccessTools.FieldRef<ItemHealthPack, ItemToggle>
            item_toggle_ref = AccessTools.FieldRefAccess<ItemHealthPack, ItemToggle>("itemToggle");

        private static readonly AccessTools.FieldRef<ItemToggle, int>
            player_photon_id_ref = AccessTools.FieldRefAccess<ItemToggle, int>("playerTogglePhotonID");

        [HarmonyPostfix]
        [HarmonyPatch("Start")]
        static void OverrideHealAmount(ItemHealthPack __instance)
        {
            // Works fine
            __instance.healAmount = (int)Math.Ceiling(__instance.healAmount * Configuration.HealAmountMultiplier.Value);
        }

        [HarmonyPostfix]
        [HarmonyPatch(nameof(ItemHealthPack.OnDestroy))]
        static void HealAll(ItemHealthPack __instance)
        {
            ref var item_toggle      = ref item_toggle_ref(__instance);
            ref var player_photon_id = ref player_photon_id_ref(item_toggle);

            var health_pack_user     = SemiFunc.PlayerAvatarGetFromPhotonID(player_photon_id);
            var players              = SemiFunc.PlayerGetAll();

            foreach (var player in players)
            {
                if (player.photonView.ViewID == health_pack_user.photonView.ViewID)
                {
                    continue;
                }

                player.playerHealth.HealOther(__instance.healAmount, effect: true);
            }
        }
    }
}
