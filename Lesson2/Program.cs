string name;
string surname;
string hobby;
string ageString;
int age;

Console.WriteLine("Введите свое имя:");

name = Console.ReadLine() ?? string.Empty;

while (String.IsNullOrEmpty(name) == true)
{
    Console.WriteLine("Имя не может быть пустым");
    name = Console.ReadLine() ?? string.Empty;
}

Console.WriteLine("Введите свою фамилию:");

surname = Console.ReadLine() ?? string.Empty;

while (String.IsNullOrEmpty(surname) == true)
{
    Console.WriteLine("Фамилия не может быть пустой");
    surname = Console.ReadLine() ?? string.Empty;
}

Console.WriteLine("Введите свой возраст:");

ageString = (Console.ReadLine()) ?? string.Empty;

while (String.IsNullOrEmpty(ageString) == true)
{
    Console.WriteLine("Возраст не может быть пустой");
    ageString = Console.ReadLine() ?? string.Empty;
}

while (!int.TryParse(ageString, out var ageInt))
{
    Console.WriteLine("Возраст должен быть числом");
    ageString = Console.ReadLine() ?? string.Empty;
}
age = Convert.ToInt32(ageString);

if (age > 116 || age <= 0)
{
    Console.WriteLine("Возраст превышает допустимые значения");
    ageString = Console.ReadLine() ?? string.Empty;
}

Console.WriteLine("Введите свое хобби:");

hobby = Console.ReadLine() ?? string.Empty;

while (String.IsNullOrEmpty(hobby) == true)
{
    Console.WriteLine("Хобби не может быть пустым");
    hobby = Console.ReadLine() ?? string.Empty;
}

Console.Write($" Имя: {name} \n Фамилия: {surname} \n Возраст: {ageString} \n Хобби: {hobby}");