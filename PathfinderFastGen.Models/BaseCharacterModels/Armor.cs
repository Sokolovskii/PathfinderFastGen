using System.Linq;

namespace PathfinderFastGen.Models.BaseCharacterModels
{
	public class Armor : Stat, IEditable
	{
		public Characteristic Dexterity { get; }
		public Size Size { get; }
		public int Bonus { get; set; }
		
		public Armor(int bonus, Characteristic dexterity, Size size)
		{
			BaseChar = new BaseStat(CharacteristicKeys.Armor, 0);
			Dexterity = dexterity;
			Bonus = bonus;
			Size = size;
		}
		public int GetKB()
		{
			switch (Size)
			{
				case (Size.Small):
					return Dexterity.Modificator + Bonus + 1;
				case (Size.Middle):
				default:
					return Dexterity.Modificator + Bonus;
				case (Size.Big):
					return Dexterity.Modificator + Bonus - 1; 			
			}
			
		}

		public void EditStat(params int[] values)
		{
			Bonus += values.Sum();
		}
	}
}
