using System.ComponentModel;

namespace PathfinderFastGen.Models.Items.Artefact
{
	public class MagicEffect
	{
		public int Id { get; set; }
		public string Name { get; }
		public int PriceBonus { get; }
		public TypeOfItemForEffect TypeOfItemForEffect{ get; }
	}

	public enum TypeOfItemForEffect
	{
		[Description("Магический предмет")]MagicItem,
		[Description("Ожерелье")] Neckless,
		[Description("Кольцо")] Ring,
		[Description("Броня")] Armor,
		[Description("Щит")] Shield,
		[Description("Головной убор")] Helm,
		[Description("Очки")] Glasses,
		[Description("Оружие")] Weapon
	}
}
