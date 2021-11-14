namespace PathfinderFastGen.Models.BaseCharacterModels
{
	class Challenge : IStat
	{
		public BaseStat BaseChar { get; set; }
		public Characteristic LinkedChar{ get; set; }
		public int Bonus { get; set; }
		public int MagicBonus { get; set; }

		public Challenge(string name, int value)
		{
			BaseChar = new BaseStat(name, value);
		}

		public void ChangeBonus(int value)
		{
			Bonus += value;
		}

		public void ChangeMagicBonus(int value)
		{
			MagicBonus += value;
		}

	}
}
