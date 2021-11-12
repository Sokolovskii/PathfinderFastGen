namespace PathfinderFastGen.Models.BaseCharacterModels
{
	public class Characteristic : BaseStat
	{
		public override int Value {
			get => Value;
			set {
				Value = value;
				CountModificator();
			}
		}
		public Characteristic(string name, int value)
		{
			Name = name;
			Value = value;
		}
		public int Modificator { get; private set; }
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
