using System.Text;

internal class Program
{
    public static async Task Main()
    {
        Console.WriteLine("Введите путь до каталога");
        string path = Console.ReadLine() ?? string.Empty;
        string newFile = path + @"\result.txt";
   
         try
        {
            var allFilePath = Directory.EnumerateFiles(path, "*.txt", SearchOption.AllDirectories); // Находит все текстовые документы

            foreach (string txtPath in allFilePath)
            {
                using (StreamReader file = new StreamReader(txtPath)) // Чтение документа
                {
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
        }
        catch (Exception)
        {
            Console.WriteLine("Каталог не найден");
        }
    }
}