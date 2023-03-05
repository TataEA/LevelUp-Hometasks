using Lesson7_1;
using static System.Formats.Asn1.AsnWriter;

int M;
int N;

Console.WriteLine("Введите начальное значение диапозона:");
var firstNumber = Console.ReadLine() ?? String.Empty;

 while (!int.TryParse(firstNumber, out M) || M < 0)
{
    Console.WriteLine("Значение должно быть положительным числом");
    firstNumber = Console.ReadLine() ?? String.Empty;
}

Console.WriteLine("Введите последнее значение диапозона:");
var lastNumber = Console.ReadLine();

while (!int.TryParse(lastNumber, out N) || N < 0)
{
    Console.WriteLine("Значение должно быть положительным числом");
    lastNumber = Console.ReadLine() ?? String.Empty;
}

while (M > N)
{
    Console.WriteLine("Начало диапозона не может быть больше его окончания. Введите последнее значение больше начального");
    lastNumber = Console.ReadLine();
    while (!int.TryParse(lastNumber, out N) || N < 0)
    {
        Console.WriteLine("Значение должно быть положительным числом");
        lastNumber = Console.ReadLine() ?? String.Empty;
    }
}

_ = new Square_Root(M, N);