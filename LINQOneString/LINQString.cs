string filePath = "C:\\Users\\User\\Desktop\\учеба\\ООПиП\\лаб9\\number.txt";
double sumOfEvenNumbers = File.ReadAllText(filePath)
    .Split(' ')
    .Select(double.Parse)
    .Where(num => num % 2 == 0)
    .Sum();
Console.WriteLine($"Сумма чётных чисел равна {sumOfEvenNumbers}");
