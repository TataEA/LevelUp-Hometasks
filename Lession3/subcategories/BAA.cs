using Lesson3.categories;

namespace Lesson3.subcategories
{
    internal class BAA : Food, ICanEat
    {
        public const bool NOSUGAR = false;

        public const int CALORIES = 458;
        public bool ParameterEat()
        {
            return true;
        }
        public BAA(bool nosugar, int calories, string nameBAA = "БАД") : base(ID, TYPE, NOSUGAR, CALORIES)
        {
            NameBAA = nameBAA;
        }
        private string NameBAA { get; }

        public override void PrintStore()
        {
            Console.WriteLine($"ID: {ID}, Тип: {TYPE}, Сахар: {NOSUGAR}, Калорийность: {CALORIES}, Товар: {NameBAA}");
        }
    }
}