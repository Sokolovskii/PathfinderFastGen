using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderFastGen.Models.BaseCharacterModels.ChallengeModels
{
	class Challenge : BaseStat
	{
		public Characteristic LinkedChar{ get; set; }
		public int Bonus { get; set; }
		public int MagicBonus { get; set; }
		
	}
}
