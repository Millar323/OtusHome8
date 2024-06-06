using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtusHome8.Models;

namespace OtusHome8
{
    public class TruckTest
    {
        public static string TruckClone()
        {
            // Создаем экземпляр класса Truck
            Truck truck = new Truck { Model = "F-150", Brand = "Ford", LoadCapacity = 1200.5 };
            // Клонируем объект Truck
            Truck clonedTruck = (Truck)truck.Clone();

            // Сравниваем исходные и клонированные объекты
            return $"Original truck load capacity: {truck.LoadCapacity}, cloned truck load capacity: {clonedTruck.LoadCapacity}";
        }

    }
}
