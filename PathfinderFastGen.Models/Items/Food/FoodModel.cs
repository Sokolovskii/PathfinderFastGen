namespace PathfinderFastGen.Models.Items.Food
{
	class FoodModel : IItem
	{
		public ItemBaseModel BaseItem { get; }
		public FoodModel(ItemBaseModel baseItem) => BaseItem = baseItem;
	}
}
