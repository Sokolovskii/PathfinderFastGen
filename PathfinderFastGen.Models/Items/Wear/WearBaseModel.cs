namespace PathfinderFastGen.Models.Items.Wear
{
	public class WearBaseModel : IItem
	{
		public ItemBaseModel BaseItem { get; }
		public WearBaseModel(ItemBaseModel baseItem) => BaseItem = baseItem;
	}
}
