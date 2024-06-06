using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtusHome8.Models;

namespace OtusHome8
{
    public class CarTest
    {
        public static string CarClone() 
        {
            // Создаем экземпляр класса Car
            Car car = new Car { Model = "Model S", Brand = "Tesla", NumberOfDoors = 4 };
            // Клонируем объект Car
            Car clonedCar = (Car)car.Clone();

            // Сравниваем исходные и клонированные объекты
            return $"Original car model: {car.Model}, cloned car model: {clonedCar.Model}";
        }
    }
}
