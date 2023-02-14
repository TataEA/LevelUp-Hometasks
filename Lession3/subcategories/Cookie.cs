using Lesson3.categories;

namespace Lesson3.subcategories
{
    internal class Cookie : Food, ICanEat
    {
        public const bool NOSUGAR = true;

        public const int CALORIES = 330;
        public bool ParameterEat()
        {
            return true;
        }
        public Cookie(bool nosugar, int calories, string nameCookie = "Овсяное печенье") : base(ID, TYPE, NOSUGAR, CALORIES)
        {
            NameCookie = nameCookie;
        }
        private string NameCookie { get; }

        public override void PrintStore()
        {
            Console.WriteLine($"ID: {ID}, Тип: {TYPE}, Сахар: {NOSUGAR}, Калорийность: {CALORIES}, Товар: {NameCookie}");
        }
    }
}