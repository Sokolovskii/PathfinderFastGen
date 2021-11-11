namespace PathfinderFastGen.Models.Equipment
{
	public class ItemBaseModel
	{
		public string Name { get; }

		public int Price { get; }

		public float Weight { get; }

		public string Description { get; }

		public EquipmentCategory ItemCategory { get; }

		public ItemBaseModel(string name, int price, float weight, string description, EquipmentCategory itemCategory)
		{
			Name = name;
			Price = price;
			Weight = weight;
			Description = description;
			ItemCategory = itemCategory;
		}


	}

	public enum EquipmentCategory
	{
		Weapon,
		Wear,
		Shells,
		Potion,
		PotionIngredients,
		Medicine,
		Food,
		CampingEquipment,
		Artefact
	}
}
