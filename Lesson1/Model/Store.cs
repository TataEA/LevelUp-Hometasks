
namespace Lesson1.Model
{
    internal class Store
    {
        public string Name { get; set; }
        public string Adress { get; set; }

        public Store(string name, string adress)
        {
            Name = name;
            Adress = adress;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Название: {Name}, Адрес: {Adress}");
        }
    }

}
