using System.Linq;

namespace PathfinderFastGen.Models.BaseCharacterModels
{
	public abstract class BaseStat
	{
		public string Name { get; set; }
		public virtual int Value
		{
			get => Value;
			set 
			{
				Value = value;
			}
		}

		public void Add(params int[] values)
		{
			Value += values.Sum();
		} 

		public void Sub(params int[] values)
		{
			if ((Value - values.Sum()) >= 1)
				Value -= values.Sum();
			else
				Value = 1;
		}
	}
}
