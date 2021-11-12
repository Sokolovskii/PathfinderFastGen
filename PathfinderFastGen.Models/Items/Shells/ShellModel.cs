namespace PathfinderFastGen.Models.Items.Shells
{
	class ShellModel : IItem
	{
		public ItemBaseModel BaseItem { get; }
		public int Volume { get; }
		public ShellModel(ItemBaseModel baseItem, int volume)
		{
			BaseItem = baseItem;
			Volume = volume;
		}
	}
}
