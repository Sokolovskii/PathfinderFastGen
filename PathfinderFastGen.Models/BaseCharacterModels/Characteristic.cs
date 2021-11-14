namespace PathfinderFastGen.Models.BaseCharacterModels
{
	public class Characteristic : IStat
	{
		public BaseStat BaseChar { get; set; }
		public int Modificator => CountModificator();
		public Characteristic(string name, int value)
		{
			BaseChar = new BaseStat(name, value);
		}
		private int CountModificator() 
		{
			return BaseChar.Value % 2 == 0 ? (BaseChar.Value - 10) / 2 : (BaseChar.Value - 11) / 2;
		}
	}
}
