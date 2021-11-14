using System.Linq;

namespace PathfinderFastGen.Models.BaseCharacterModels
{
	class Challenge : Stat, IEditable
	{ 
		public Characteristic LinkedChar{ get; set; }
		public int Bonus { get; set; }

		public Challenge(string name, int value, Characteristic linkedChar)
		{
			BaseChar = new BaseStat(name, value, 0);
			LinkedChar = linkedChar;
		}

		public void EditStat(params int[] values)
		{
			Bonus += values.Sum();
		}
	}
}
