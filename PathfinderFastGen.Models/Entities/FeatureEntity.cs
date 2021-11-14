using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderFastGen.Models.Entities
{
	public class FeatureEntity
	{
		public ClassEntity Class { get; set; }
		public FeatureEntity DependsFeature { get; }
		public string Name { get; }
		public string Description { get; }
		public StatBonus[] Bonuses { get; }
	}
}
