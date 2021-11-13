namespace PathfinderFastGen.Models.Entities
{
	class AttackEntity
	{
		public ClassEntity Class { get; set; }
		public int Level { get; set; }
		public int FirstAttackValue { get; set; }
		public int SecondAttackValue { get; set; }
		public int ThirdAttackValue { get; set; }
	}
}
