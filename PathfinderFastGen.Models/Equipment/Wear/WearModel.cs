namespace PathfinderFastGen.Models.Equipment.Armor
{
	public class WearModel : ItemBaseModel
	{
		public int? ArmorModify { get; }
		public int? MaxDexterity { get; }
		public int? ArmorFine { get; }
		public bool CanCastMagic { get; }
		public int? ChanceFailCast { get; }
		public int? Speed30Ft { get; }
		public int? Speed20Ft { get; }

		public WearCategory WearCategory { get; }

		public WearModel(string name, 
			int price, 
			float weight, 
			string description, 
			int? armorModify, 
			int? maxDexterity, 
			int? armorFine,
			bool canCastMagic,
			int? chanceFailCast,
			int? speed30ft,
			int? speed20ft,
			WearCategory category) : base(name, price, weight, description, EquipmentCategory.Wear)
		{
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

	public enum WearCategory
	{
		Wear,
		LightArmor,
		MidArmor,
		HeavyArmor,
		Shields,
		Upgrade
	}
}
