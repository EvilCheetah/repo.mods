using HarmonyLib;
using Photon.Pun;

namespace ScalingPrices.Helpers
{
    internal class ItemAttributesHelper
    {
        public static ItemAttributes Instance { get; set; }

        private static readonly AccessTools.FieldRef<ItemAttributes, PhotonView>
            photon_view_ref = AccessTools.FieldRefAccess<ItemAttributes, PhotonView>("photonView");

        private static readonly AccessTools.FieldRef<ItemAttributes, string>
            item_asset_name_ref = AccessTools.FieldRefAccess<ItemAttributes, string>("itemAssetName");

        private static readonly AccessTools.FieldRef<ItemAttributes, SemiFunc.itemType>
            item_type_ref       = AccessTools.FieldRefAccess<ItemAttributes, SemiFunc.itemType>("itemType");

        private static readonly AccessTools.FieldRef<ItemAttributes, int>
            item_value_ref      = AccessTools.FieldRefAccess<ItemAttributes, int>("value");

        private static readonly AccessTools.FieldRef<ItemAttributes, float>
            item_value_min_ref  = AccessTools.FieldRefAccess<ItemAttributes, float>("itemValueMin");

        private static readonly AccessTools.FieldRef<ItemAttributes, float>
            item_value_max_ref  = AccessTools.FieldRefAccess<ItemAttributes, float>("itemValueMax");


        public static PhotonView PhotonView
        {
            get => photon_view_ref(Instance);
        }

        public static string ItemAssetName
        {
            get => item_asset_name_ref(Instance);
            set => item_asset_name_ref(Instance) = value;
        }
        
        public static SemiFunc.itemType ItemType
        {
            get => item_type_ref(Instance);
            set => item_type_ref(Instance) = value;
        }

        public static int ItemValue
        {
            get => item_value_ref(Instance);
            set => item_value_ref(Instance) = value;
        }

        public static float ItemValueMin
        {
            get => item_value_min_ref(Instance);
            set => item_value_min_ref(Instance) = value;
        }

        public static float ItemValueMax
        {
            get => item_value_max_ref(Instance);
            set => item_value_max_ref(Instance);
        }
    }
}
