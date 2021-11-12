namespace PathfinderFastGen.Models.Items.PotionIngredients
{
	class PotionIngredientModel : IItem
	{
		public ItemBaseModel BaseItem { get; }
		public PotionIngredientModel(ItemBaseModel baseItem)
		{
			BaseItem = baseItem;
		}
	}
}
