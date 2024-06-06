using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHome8.Models
{
    // Производный класс Truck
    public class Truck : Car
    {
        public double LoadCapacity { get; set; }

        // Переопределение метода клонирования для Truck
        public override Car Clone()
        {
            return (Truck)MemberwiseClone();
        }
    }

}
