using System.Text;

internal class Program
{
    public static async Task Main()
    {
        Console.WriteLine("Введите путь до каталога");
        string path = Console.ReadLine() ?? string.Empty;
        string newFile = path + @"\resultFile.txt";
         try
        {
            var allFilePaths = Directory.EnumerateFiles(path, "*.txt", SearchOption.AllDirectories); // Находит все текстовые документы

            foreach (string txtPath in allFilePaths)
            {
                using (StreamReader file = new StreamReader(txtPath)) // Чтение документа
                    {
                        string text = await file.ReadToEndAsync(); 

                        using (FileStream mergeFile = new FileStream(newFile, FileMode.Append)) // Добавление данных в новый файл
                        {
                            byte[] buffer = Encoding.Default.GetBytes(text);
                            await mergeFile.WriteAsync(buffer, 0, buffer.Length);
                            Console.WriteLine("Текст записан в файл");
                        }
                }
            }
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Каталог не найден");
        }
    }
}