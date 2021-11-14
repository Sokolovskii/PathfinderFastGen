namespace PathfinderFastGen.Models.BaseCharacterModels
{
	public class Characteristic : Stat, IEditable
	{
		public int Modificator { get; set; }
		public Characteristic(string name, int value)
		{
			BaseChar = new BaseStat(name, value);
			CountModificator();
		}
		private void CountModificator() 
		{
			if(BaseChar.Value % 2 == 0)
			{
				Modificator = (BaseChar.Value - 10) / 2;
				return;
			}
			Modificator = (BaseChar.Value - 11) / 2;
		}

		public void EditStat(params int[] values)
		{
			BaseChar.Change(values);
			CountModificator();
		}
	}
}
