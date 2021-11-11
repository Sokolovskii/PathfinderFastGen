using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderFastGen.Models.Equipment.Weapon
{
	class WeaponModel : ItemBaseModel
	{
		public WeaponModel(string name, int price, float weight, string description, EquipmentCategory itemCategory) : base(name, price, weight, description, itemCategory)
		{
		}
	}
}
