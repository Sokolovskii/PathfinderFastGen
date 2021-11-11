namespace PathfinderFastGen.Models.BaseCharacterModels
{
	public class BaseStat
	{
		public string Name { get; }
		public int Value { get; set; }

		public BaseStat(string name, int value)
		{
			Name = name;
			Value = value;
		}
	}
}
