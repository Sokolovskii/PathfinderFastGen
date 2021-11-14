using System.Linq;

namespace PathfinderFastGen.Models.BaseCharacterModels
{
	public class Skill : Stat, IEditable
	{
		public Characteristic LinkedChar { get; set; }
		public int Bonus { get; set; }
		public bool ClassedSkill { get; }
		public Skill(string name, Characteristic linkedChar, bool classedSkill, int bonus)
		{
			BaseChar = new BaseStat(name, 0);
			LinkedChar = linkedChar;
			ClassedSkill = classedSkill;
			Bonus = bonus;
		}

		public int GetSum()
		{
			if (ClassedSkill)
			{
				return BaseChar.Value + Bonus + LinkedChar.Modificator + 3;
			}
			return LinkedChar.Modificator;
		}

		public void EditStat(params int[] values)
		{
			Bonus += values.Sum();
		}
	}
}
