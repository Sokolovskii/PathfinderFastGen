using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderFastGen.Models.Entities
{
	public class SkillEntity
	{
		public ClassEntity Class { get; set; }
		public List<SkillKeyValuePair> SkillKeyValuePairs { get; set; }
	}

	public class SkillKeyValuePair
	{
		public string Name { get; set; }
		public bool IsClassed { get; set; }
	}
}
