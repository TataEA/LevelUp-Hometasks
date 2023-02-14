using Lesson3.categories;

namespace Lesson3.subcategories
{
    internal class Pants : Cloth, ICanEat
    {
        public const int SIZE = 56;

        public const string GENDER = "муж";

        public bool ParameterEat()
        {
            return false;
        }
        public Pants(int size, string gemder, string brand = "Grishko", string product = "Спортивные штаны") : base(ID, TYPE, SIZE, GENDER)
        {
            Brand = brand;
            Product = product;
        }

        private string Brand { get; }

        private string Product { get; }

        public override void PrintStore()
        {
            Console.WriteLine($"ID: {ID}, Тип: {TYPE}, Размер: {SIZE}, Пол: {GENDER}, Бренд: {Brand}, Товар: {Product}");
        }
    }
}