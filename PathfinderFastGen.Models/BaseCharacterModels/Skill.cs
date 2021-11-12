namespace PathfinderFastGen.Models.BaseCharacterModels
{
	public class Skill : BaseStat
	{
		public override int Value{ get; set; }
		public (string charName, int charValue) LinkedCharacteristic { get; set; }
		public int Bonus { get; set; }
		public bool ClassedSkill { get; }
		public Skill(string linkedCharacteristicName, int linkedCharacteristicValue, bool classedSkill, int bonus, string name, int value)
		{
			LinkedCharacteristic = (linkedCharacteristicName, linkedCharacteristicValue);
			ClassedSkill = classedSkill;
			Bonus = bonus;
			Name = name;
			Value = value;
		}

		public int GetSum()
		{
			if (ClassedSkill)
			{
				return Value + Bonus + LinkedCharacteristic.charValue + 3;
			}
			return LinkedCharacteristic.charValue;
		}
	}
}
