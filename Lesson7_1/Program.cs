using Lesson7_1;

Console.WriteLine("Введите начальное и конечное значения диапазона через пробел:");
string rangeString = Console.ReadLine() ?? string.Empty;

string[] rangeArr = rangeString.Split(new Char[] { ' ' });

for (int i = 0; i < 2; i++) // Проверка только двух значений, так как для диапазона нужны только два числа
{
    while (!int.TryParse(rangeArr[i], out int num) || num < 0)
    {
        Console.WriteLine($"Значение номер {i+1} должно быть положительным числом");
        rangeArr[i] = Console.ReadLine() ?? string.Empty;
    }
}

int M = Math.Min(int.Parse(rangeArr[0]), int.Parse(rangeArr[1])); // находит начало диапазона и переводит в int
int N = Math.Max(int.Parse(rangeArr[0]), int.Parse(rangeArr[1])); // находит конец диапазона и переводит в int

var exemplar = new Square_Root();
exemplar.RangeSquare(M, N);