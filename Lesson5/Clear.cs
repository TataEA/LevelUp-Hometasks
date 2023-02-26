using System.Text.RegularExpressions;

namespace Lesson5
{
    internal static class Clear
    {
        public static string ClearString(this string testString) 
        {
            string newString = Regex.Replace(testString, @"[^0-9a-zA-Z: ]+", ""); // оставит только цифры и буквы, но не уберет пробелы

            string newString2 = Regex.Replace(newString, @"\s+", " "); // Уберет лишние пробелы. Используется два выражения, чтобы не было пробела, если недопустимый символ в середине слова

            newString2 = newString2.Trim();

            return newString2;
        }
    }
}