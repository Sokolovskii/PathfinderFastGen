namespace PathfinderFastGen.Models.BaseCharacterModels
{
	class Attack : Stat
	{
		public (int secondVal, int thirdVal) BonusVal { get; }
		public Characteristic Strength { get; }
		public Characteristic Dexterity { get; }
		public Size Size { get; }

		public Attack(int firstVal, int secondVal, int thirdVal, Characteristic strength, Characteristic dexterity, Size size)
		{
			BaseChar = new BaseStat(CharacteristicKeys.Attack, firstVal);
			BonusVal = (secondVal, thirdVal);
			Strength = strength;
			Dexterity = dexterity;
			Size = size;
		}

		public int GetMBM()
		{
			var value = BaseChar.Value + Strength.Modificator;
			switch (Size)
			{
				case (Size.Small):
					return value - 1;
				case (Size.Middle):
				default:
					return value;
				case (Size.Big):
					return value + 1;
			}
		}

		public int GetZBM()
		{
			var baseValue = BaseChar.Value + Strength.Modificator + Dexterity.Modificator + 10;
			switch (Size)
			{
				case (Size.Small):
					return baseValue - 1;
				case (Size.Middle):
				default:
					return baseValue;
				case (Size.Big):
					return baseValue + 1;
			}
		}
	}
}
