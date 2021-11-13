using System.Linq;

namespace PathfinderFastGen.Models
{
	interface IStat
	{
		BaseStat BaseChar { get; }
	}

	public class BaseStat
	{
		public string Name { get; }
		public int Value
		{
			get => Value;
			set
			{
				if (value > 1) Value = value;
				else Value = 1;
			}
		}

		public void Change(params int[] values)
		{
			Value += values.Sum();
		}

		public BaseStat(string name, int value)
		{
			Name = name;
			Value = value;
		}

		public BaseStat(string name)
		{
			Name = name;
			Value = 1;
		}
	}
}
