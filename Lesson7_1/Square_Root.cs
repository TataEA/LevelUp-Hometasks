namespace Lesson7_1
{
    internal class Square_Root
    {
        public Square_Root (int firstNumber, int lastNumber)
        {
            for (int i = firstNumber; i <= lastNumber; i++ )
            {
                int number = i;
                Console.WriteLine ($" Число: {number}, Квадратный корень: {Math.Sqrt(number)}");
            }
        }   
    }
}