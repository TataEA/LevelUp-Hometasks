using System.Text.RegularExpressions;

namespace Lesson5
{
    internal static class Clear
    {
        public static string ClearString(this string testString) 
        {
            string filteredString = Regex.Replace(testString, @"[^0-9a-zA-Z: ]+", ""); // оставит только цифры и буквы, но не уберет пробелы

            filteredString = Regex.Replace(filteredString, @"\s+", " "); // Уберет лишние пробелы. Используется два выражения, чтобы не было пробела, если недопустимый символ в середине слова

            filteredString = filteredString.Trim();

            return filteredString;
        }
    }
}