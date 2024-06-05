using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHome8
{
    // Производный класс Truck
    public class Truck : Vehicle
    {
        public double LoadCapacity { get; set; }

        // Переопределение метода клонирования для Truck
        public override Vehicle Clone()
        {
            return (Truck)MemberwiseClone();
        }
    }

}
