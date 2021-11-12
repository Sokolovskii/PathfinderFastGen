using System.ComponentModel;

namespace PathfinderFastGen.Models.Items
{
	public interface IItem
	{
		ItemBaseModel BaseItem { get; }
	}
	public class ItemBaseModel
	{
		public int Id { get; set; }
		public string Name { get; }
		public float Price { get; set; }
		public float Weight { get; set; }
		public string Description { get; }
		public ItemCategory ItemCategory { get; }
	}

	public enum ItemCategory
	{
		[Description("Оружие")] Weapon,
		[Description("Одежда и броня")] Wear,
		[Description("Боеприпасы")] Shells,
		[Description("Зелье")] Potion,
		[Description("Ингредиент")] PotionIngredients,
		[Description("Пища или напиток")] Food,
		[Description("Походное снаряжение или набор инструментов")] CampingEquipment,
		[Description("Артефакт")] Artefact
	}
}
