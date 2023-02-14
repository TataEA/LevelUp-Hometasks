using Lesson1.Model;

Console.WriteLine("Введите имя магазина:");

var name = Console.ReadLine() ?? string.Empty;

Console.WriteLine("Введите адрес магазина:");

var adress = Console.ReadLine() ?? string.Empty;
var store = new Store(name, adress);

store.PrintInfo();
Console.WriteLine(store);