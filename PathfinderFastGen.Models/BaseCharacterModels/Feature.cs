namespace PathfinderFastGen.Models.BaseCharacterModels
{
	class Feature
	{
		public string Name { get; }
		public string Description { get; }
		public Feature DependsFeature { get; }
		public StatBonus[] Bonuses { get; }

		public Feature(string name, string description, Feature dependsFeature, params StatBonus[] bonuses)
		{
			Name = name;
			Description = description;
			DependsFeature = dependsFeature;
			Bonuses = bonuses;
		}
	}
}
