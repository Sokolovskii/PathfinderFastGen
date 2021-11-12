using System.ComponentModel;

namespace PathfinderFastGen.Models.Items.Wear
{
	class ArmorBaseModel
	{
		public int ArmorModify { get; }
		public ItemBaseModel BaseItem { get; }
		public int MaxDexterity { get; }
		public int ArmorFine { get; }
		public bool CanCastMagic { get; }
		public int ChanceFailCast { get; }
		public int Speed30Ft { get; }
		public int Speed20Ft { get; }
		public ArmorCategory WearCategory { get; }

		public ArmorBaseModel(ItemBaseModel baseItem,
			int armorModify,
			int maxDexterity,
			int armorFine,
			bool canCastMagic,
			int chanceFailCast,
			int speed30ft,
			int speed20ft,
			ArmorCategory category)
		{
			BaseItem = baseItem;
			ArmorModify = armorModify;
			MaxDexterity = maxDexterity;
			ArmorFine = armorFine;
			CanCastMagic = canCastMagic;
			ChanceFailCast = chanceFailCast;
			Speed30Ft = speed30ft;
			Speed20Ft = speed20ft;
			WearCategory = category;
		}
	}

	public enum ArmorCategory
	{
		[Description("Легкая броня")] LightArmor,
		[Description("Средняя броня")] MidArmor,
		[Description("Тяжёлая броня")] HeavyArmor,
		[Description("Щит")] Shield,
		[Description("Улучшение")] Upgrade
	}
}
