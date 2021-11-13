using System.ComponentModel;

namespace PathfinderFastGen.Models
{
	public static class CharacteristicKeys
	{
		public const string Strength = "Сила";
		public const string Dexterity = "Ловкость";
		public const string Durability = "Выносливость";
		public const string Intellegence = "Интеллект";
		public const string Wisdom = "Мудрость";
		public const string Charisma = "Харизма";

		public const string Armor = "Броня";
		public const string Attack = "БМА";

		public const string Persistance = "Стойкость";
		public const string Reaction = "Реакция";
		public const string Will = "Воля";

		public const string Acrobatics = "Акробатика";
		public const string Bluff = "Блеф";
		public const string HorseRiding = "Верховая езда";
		public const string Attention = "Внимание";
		public const string Surviving = "Выживание";
		public const string Diplomacy = "Дипломатия";
		public const string Training = "Дрессировка";
		public const string Intimidation = "Запугивание";
		public const string Knowledge_Elite = "Знание(Высший свет)";
		public const string Knowledge_Geography = "Знание(География)";
		public const string Knowledge_Engeniring = "Знание(Инженерное дело)";
		public const string Knowledge_History = "Знание(История)";
		public const string Knowledge_LocalHistory = "Знание(Краеведение)";
		public const string Knowledge_Magic = "Знание(Магия)";
		public const string Knowledge_Plans = "Знание(Планы)";
		public const string Knowledge_Dungeons = "Знание(Подземелья)";
		public const string Knowledge_Nature = "Знание(Природа)";
		public const string Knowledge_Religion = "Знание(Религия)";
		public const string Flexibility = "Изворотливость";
		public const string UsingMagicItems = "Использование магических предметов";
		public const string Sorcery = "Колдовство";
		public const string Climbing = "Лазание";
		public const string Healing = "Лечение";
		public const string SleightOfHand = "Ловкость рук";
		public const string Disguise = "Маскировка";
		public const string Mechanic = "Механика";
		public const string Evaluation = "Оценка";
		public const string Swimming = "Плавание";
		public const string Flying = "Полет";
		public const string Insight = "Проницательность";
		public const string Stelth = "Скрытность";
		public const string Linguistics = "Языкознание";
	}
	public enum Size
	{
		[Description("Малое")] Small,
		[Description("Среднее")] Middle,
		[Description("Большое")] Big
	}

	public class StatBonus
	{
		public string Key { get; }
		public string Value { get; }
	}

	public static class RaceKeys
	{
		public const string Gnome = "Гном";
		public const string Dwarf = "Дварф";
		public const string Halfling = "Полурослик";
		public const string Human = "Человек";
		public const string HalfElf = "Полуэльф";
		public const string HalfOrc = "Полуорк";
		public const string Elf = "Эльф";
	}

	public static class ClassKeys
	{

	}

	public enum Races
	{
		[Description("Гном")] Gnome,
		[Description("Дварф")] Dwarf,
		[Description("Полурослик")] Halfling,
		[Description("Человек")] Human,
		[Description("Полуорк")] HaldOrc,
		[Description("Полуэльф")] HalfElf,
		[Description("Эльф")] Elf,
	}

	public enum Classes
	{

	}
}
