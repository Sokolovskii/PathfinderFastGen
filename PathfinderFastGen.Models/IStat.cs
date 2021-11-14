using System.Linq;

namespace PathfinderFastGen.Models
{
	public abstract class Stat
	{
		protected BaseStat BaseChar { get; set; }

		public int GetVal()
		{
			return BaseChar.Value;
		}

		public bool IsThatStat(string key)
		{
			return key == BaseChar.Name;
		}
	}

	interface IEditable
	{
		void EditStat(params int[] values);
	}

	public class BaseStat
	{
		public string Name { get; }
		public int Value
		{
			get => Value;
			set
			{
				if (value > MinVal) Value = value;
				else Value = MinVal;
			}
		}

		public int MinVal { get; set; }

		public void Change(params int[] values)
		{
			Value += values.Sum();
		}

		public BaseStat(string name, int value, int minVal = 1)
		{
			Name = name;
			Value = value;
			MinVal = minVal;
		}

		public BaseStat(string name, int minVal = 1)
		{
			Name = name;
			Value = minVal;
			MinVal = minVal;
		}
	}
}
