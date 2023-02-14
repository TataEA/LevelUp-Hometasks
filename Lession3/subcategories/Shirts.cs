using Lesson3.categories;

namespace Lesson3.subcategories
{
    internal class Shirts : Cloth, ICanEat
    {
        public const int SIZE = 42;

        public const string GENDER = "жен";

        public bool ParameterEat()
        {
            return false;
        }
        public Shirts(int size, string gender, string brand = "Gaff Gang", string product = "Рубашка") : base(ID, TYPE, SIZE, GENDER)
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