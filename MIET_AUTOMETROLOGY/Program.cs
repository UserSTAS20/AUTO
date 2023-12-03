class Program
{
    static void Main()
    {
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);

        }

        // Создать строку
        string writeText = "Привет, мир!";

        // Создать файл и записать в него содержимое строки
        File.WriteAllText("TextFile1.txt", writeText);

        // Прочитать содержимое файла в строку
        string readText = File.ReadAllText("TextFile1.txt");

        // Вывести содержимое на консоль
        Console.WriteLine(readText);

        // Добавить строку к файлу
        File.AppendAllText("TextFile1.txt", "\nЭто добавленная строка.");
    }
}