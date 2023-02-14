namespace Lesson3.categories
{
    internal class Cloth : StoreItem
    {
        public const string ID = "2";

        public const string TYPE = "Одежда";

        public Cloth(string id, string type, int size, string gender) : base(ID, TYPE)
        {
            Size = size;
            Gender = gender;
        }

        public int Size { get; }

        public string Gender { get; }

    }
}
