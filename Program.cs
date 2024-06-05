using OtusHome8;


// Демонстрация функции клонирования
class Program
{
    static void Main()
    {
        Car car = new Car { Model = "Model S", Brand = "Tesla", NumberOfDoors = 4 };
        Car clonedCar = (Car)car.Clone();

        Truck truck = new Truck { Model = "F-150", Brand = "Ford", LoadCapacity = 1200.5 };
        Truck clonedTruck = (Truck)truck.Clone();

        Console.WriteLine($"Original car model: {car.Model}, cloned car model: {clonedCar.Model}");
        Console.WriteLine($"Original truck load capacity: {truck.LoadCapacity}, cloned truck load capacity: {clonedTruck.LoadCapacity}");
    }
}