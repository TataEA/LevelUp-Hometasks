using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson7_1
{
    internal class Square_Root
    {
        public void RangeSquare(int firstNumber, int lastNumber)
        {

            int[] massiv = Enumerable.Range(firstNumber, lastNumber - firstNumber + 1).ToArray(); // создается массив по диапазону

            var squares = from n in massiv.AsParallel().AsOrdered() // разбиваем и сортируем AsOrdered (без него неверный опрядок, заметен на 100 записях)
                          select n;

            foreach (var n in squares)
            {
                 Console.WriteLine($" Число: {n}, Квадратный корень: {Math.Sqrt(n)}");
            } 
        }
    }
}