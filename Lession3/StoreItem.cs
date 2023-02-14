namespace Lesson3
{
    internal class StoreItem
    {
        public StoreItem(string id, string type)
        {
            Id = id;
            Type = type;
        }
        public string Id { get; }

        public string Type { get; }

        public virtual void PrintStore()
        {
            Console.WriteLine("В магазине");
        }
    }
}
