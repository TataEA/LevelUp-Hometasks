namespace Lesson3.categories
{
    internal class Food : StoreItem
    {
        public const string ID = "1";

        public const string TYPE = "Еда";

        public Food(string id, string type, bool nosugar, int calories) : base(ID, TYPE)
        {
            Nosugar = nosugar;
            Calories = calories;
        }

        public bool Nosugar { get; }

        public int Calories { get; }


    }
}
