namespace PathfinderFastGen.Models.BaseCharacterModels
{
	public class Characteristic : BaseStat
	{
		public Characteristic(string name, int value) : base(name, value) 
		{
			CountModificator();
		}
		public int Modificator { get; private set; }
		public void Add(int value) 
		{
			Value += value;
			CountModificator();
		}
		public void Sub(int value) 
		{
			if(Value - value > 1)
			{
				Value -= value;
			}
			else
			{
				Value = 1;
			}
			CountModificator();
		}

		private void CountModificator() 
		{
			if(Value % 2 == 0)
			{
				Modificator = (Value - 10) / 2;
			}
			else
			{
				Modificator = (Value - 11) / 2;
			}
		}


	}
}
