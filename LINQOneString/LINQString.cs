class LINQString
{
    static void Main(string[] args)
    {
        try
        { 
            Console.WriteLine($"Сумма чётных чисел равна {File.ReadAllText("C:\\Users\\User\\Desktop\\учеба\\ООПиП\\лаб9\\number.txt").Split(' ').Select(double.Parse).Where(num => num % 2 == 0).Sum()}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл не найден.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Некорректный формат данных в файле.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
        Console.ReadLine();
    }
}