namespace PathfinderFastGen.Models.Items.CampingEquipment
{
	class CampingEquipmentModel : IItem
	{
		public ItemBaseModel BaseItem { get; }
		public CampingEquipmentModel(ItemBaseModel baseItem) => BaseItem = baseItem;
	}
}
