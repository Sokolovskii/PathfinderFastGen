using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderFastGen.Models.BaseCharacterModels
{
	public class Armor : IStat
	{
		public BaseStat BaseChar { get; }
		public Characteristic Dexterity { get; }
		public Size Size { get; }
		public int Bonus { get; set; }
		public int NaturalArmor { get; set; }
		
		public Armor(string name, int naturalArmor, int bonus, Characteristic dexterity, Size size)
		{
			BaseChar = new BaseStat(name);
			Dexterity = dexterity;
			NaturalArmor = naturalArmor;
			Bonus = bonus;
			Size = size;
		}

		public int GetKB()
		{
			switch (Size)
			{
				case (Size.Small):
					return Dexterity.Modificator + NaturalArmor + Bonus + 1;
				case (Size.Middle):
				default:
					return Dexterity.Modificator + NaturalArmor + Bonus;
				case (Size.Big):
					return Dexterity.Modificator + NaturalArmor + Bonus - 1; 			
			}
			
		}
	}
}
