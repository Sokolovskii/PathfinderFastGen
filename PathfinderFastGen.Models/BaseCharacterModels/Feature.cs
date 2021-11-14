namespace PathfinderFastGen.Models.BaseCharacterModels
{
	class Feature
	{
		public Feature DependsFeature { get; }
		public string Name { get; }
		public string Description { get; }
		public StatBonus[] Bonuses { get; }
	}
}
