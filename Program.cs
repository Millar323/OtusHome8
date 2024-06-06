using OtusHome8;


// Демонстрация функции клонирования
class Program
{
    static void Main()
    {
        // Сравниваем исходные и клонированные объекты
        Console.WriteLine(CarTest.CarClone());
        Console.WriteLine(TruckTest.TruckClone());
    }
}