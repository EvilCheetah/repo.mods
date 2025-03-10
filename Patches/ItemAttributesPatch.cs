using HarmonyLib;
using Photon.Pun;
using UnityEngine;
using ScalingPrices.Helpers;
using ScalingPrices.Config;

namespace ScalingPrices.Patches
{
    [HarmonyPatch(typeof(ItemAttributes), nameof(ItemAttributes.GetValue))]
    class ItemAttributesPatch
    {
        static public bool Prefix(ItemAttributes __instance)
        {
            ItemAttributesHelper.Instance = __instance;


            if ( !GameManager.Multiplayer() || PhotonNetwork.IsMasterClient )
            {
                float value = Random.Range(ItemAttributesHelper.ItemValueMin, ItemAttributesHelper.ItemValueMax) * ShopManagerHelper.ItemValueMultiplier;

                if (value < 1000f)
                {
                    value = 1000f;
                }

                if (value >= 1000f)
                {
                    value = Mathf.Ceil(value / 1000f);
                }

                switch (ItemAttributesHelper.ItemType)
                {
                case SemiFunc.itemType.item_upgrade:
                    value += value * ShopManagerHelper.UpgradeIncrease * (float)StatsManager.instance.GetItemsUpgradesPurchased(ItemAttributesHelper.ItemAssetName) +
                                     SemiFunc.PlayerGetAll().Count     * Configuration.UpgradeIncreasePerPlayer.Value;
                    break;

                case SemiFunc.itemType.healthPack:
                    value += value * ShopManagerHelper.HealthPackIncrease * (float)RunManager.instance.levelsCompleted     +
                                     SemiFunc.PlayerGetAll().Count        * Configuration.HealthPackIncreasePerPlayer.Value;
                    break;

                case SemiFunc.itemType.power_crystal:
                    value += value * ShopManagerHelper.CrystalIncrease * (float)RunManager.instance.levelsCompleted  +
                                     SemiFunc.PlayerGetAll().Count     * Configuration.CrystalIncreasePerPlayer.Value;
                    break;
                }

                ItemAttributesHelper.ItemValue = (int)value;

                if ( GameManager.Multiplayer() )
                {
                    ItemAttributesHelper.PhotonView.RPC("GetValueRPC", RpcTarget.Others, ItemAttributesHelper.ItemValue);
                }
            }

            return false;
        }
    }
}
