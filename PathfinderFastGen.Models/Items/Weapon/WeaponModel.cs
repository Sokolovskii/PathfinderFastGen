using System.ComponentModel;

namespace PathfinderFastGen.Models.Items.Weapon
{
	class WeaponModel : WeaponBaseModel, IItem
	{
		public Size Size { get; private set; }
		public string Damage { get; private set; }
		public WeaponModel(ItemBaseModel baseItem,
			WeaponCategory category,
			WeaponSubCategory subCategory,
			MeleeWeaponDamage damageVars,
			AttackType attackType,
			string criticalAttack,
			string distance)

			: base(baseItem,
				category, 
				subCategory, 
				damageVars, 
				attackType, 
				criticalAttack, 
				distance){}

		public void SetSize(Size size)
		{
			switch (size)
			{
				case Size.Small:
					BaseItem.Weight /= 2;
					Damage = DamageVars.SmallDamage;
					break;
				case Size.Middle:
					Damage = DamageVars.MiddleDamage;
					break;
				case Size.Big:
					BaseItem.Weight *= 2;
					BaseItem.Price *= 2;
					Damage = DamageVars.BigDamage;
					break;
				default:
					Damage = "Не определен";
					break;
			}
		}
	}
	public enum Size
	{
		[Description("Малое")] Small,
		[Description("Среднее")] Middle,
		[Description("Большое")] Big
	}
}
