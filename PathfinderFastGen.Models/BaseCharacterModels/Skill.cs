namespace PathfinderFastGen.Models.BaseCharacterModels
{
	public class Skill : BaseStat
	{
		public override int Value{ get; set; }
		public Characteristic LinkedChar { get; set; }
		public int Bonus { get; set; }
		public bool ClassedSkill { get; }
		public Skill(Characteristic linkedChar, bool classedSkill, int bonus, string name, int value)
		{
			LinkedChar = linkedChar;
			ClassedSkill = classedSkill;
			Bonus = bonus;
			Name = name;
			Value = value;
		}

		public int GetSum()
		{
			if (ClassedSkill)
			{
				return Value + Bonus + LinkedChar.Modificator + 3;
			}
			return LinkedChar.Modificator;
		}
	}
}
