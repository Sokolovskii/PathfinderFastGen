namespace PathfinderFastGen.Models.MetaParameters
{
	class Race
	{
		public string Name { get; }
		public StatBonus[] RaceBonuses { get; }
		public int Speed { get; }
		public int MiddleAge { get; }
		public int OldAge { get; }

		public Race(string name, int speed, int middleAge, int oldAge, params StatBonus[] raceBonuses)
		{
			Name = name;
			Speed = speed;
			MiddleAge = middleAge;
			OldAge = oldAge;
			RaceBonuses = raceBonuses;
		}
	}
}
