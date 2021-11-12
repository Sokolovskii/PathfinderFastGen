using System.ComponentModel;

namespace PathfinderFastGen.Models.Items.Weapon
{
	class WeaponBaseModel : IItem
	{
		public WeaponCategory Category { get; }
		public WeaponSubCategory SubCategory { get; }
		public MeleeWeaponDamage DamageVars { get; }
		public AttackType AttackType { get; }
		public string CriticalAttack { get; }
		public string Distance { get; }
		public ItemBaseModel BaseItem { get; protected set; }

		public WeaponBaseModel( ItemBaseModel baseItem,
			WeaponCategory category,
			WeaponSubCategory subCategory,
			MeleeWeaponDamage damageVars,
			AttackType attackType,
			string criticalAttack,
			string distance)
		{
			BaseItem = baseItem;
			Category = category;
			SubCategory = subCategory;
			DamageVars = damageVars;
			AttackType = attackType;
			CriticalAttack = criticalAttack;
			Distance = distance;
		}
	}

	public enum WeaponCategory
	{
		[Description("Импровизированное оружие")] DIYWeapon,
		[Description("Простое оружие")] SimpleWeapon,
		[Description("Особое оружие")] SpecialWeapon,
		[Description("Экзотическое оружие")] ExoticWeapon
	}

	public enum WeaponSubCategory
	{
		[Description("Безоружные атаки")] Weaponless,
		[Description("Одноручное ближнего боя")] OnehandedMeleeWeapon,
		[Description("Полуторное ближнего боя")] OneAndHalfMeleeWeapon,
		[Description("Двуручное ближнего боя")] TwohandedMeleeWeapon,
		[Description("Дистанционное оружие")] DistanceWeapon
	}

	public enum AttackType
	{
		[Description("Р")] Chop,
		[Description("К")] Thrust,
		[Description("Д")] Blunt,
		[Description("К/Р")] ChopThrust,
		[Description("Д/К")] BluntThrust
	}
}
