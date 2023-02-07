Console.WriteLine("Введите свое имя:");
string name;
string surname;
string hobby;
string age;
do
{
    name = Console.ReadLine() ?? string.Empty;

    if (int.TryParse(name, out var nameSrting))
    {
        Console.WriteLine("Пожалуйста, введите свое Имя. Оно не должно быть числом:");
    }
    else
    {
        break;
    }
}
while (name as string != null);

Console.WriteLine("Введите свою фамилию:");
do
{
    surname = Console.ReadLine() ?? string.Empty;

    if (int.TryParse(surname, out var surnameString))
    {
        Console.WriteLine("Пожалуйста, введите свою Фамилию. Она не должна быть числом:");
    }
    else
    {
        break;
    }
}
while (surname as string != null);

Console.WriteLine("Введите свой возраст:");
do
{
    age = Console.ReadLine() ?? string.Empty;

    if (int.TryParse(age, out var ageString))
    {
        break;
    }
    else
    {
        Console.WriteLine("Пожалуйста, введите свой Возраст. Он должен быть числом:");

    }
}
while (age as string != null);

Console.WriteLine("Введите свое хобби:");
do
{
    hobby = Console.ReadLine() ?? string.Empty;

    if (int.TryParse(hobby, out var nhobbyString))
    {
        Console.WriteLine("Пожалуйста, введите свое Хобби. Оно не должна быть числом:");
    }
    else
    {
        break;
    }
}
while (hobby as string != null);

Console.Write($" Имя: {name} \n Фамилия: {surname} \n Возраст: {age} \n Хобби: {hobby}");



