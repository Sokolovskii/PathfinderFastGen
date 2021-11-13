namespace PathfinderFastGen.Models.BaseCharacterModels
{
	public class Characteristic : IStat
	{
		public IStat BaseChar { get; set; }
		public int Modificator => CountModificator();
		public Characteristic(string name, int value)
		{
			BaseChar = new IStat(name, value);
		}
		private int CountModificator() 
		{
			return BaseChar.Value % 2 == 0 ? (BaseChar.Value - 10) / 2 : (BaseChar.Value - 11) / 2;
		}
	}
}
