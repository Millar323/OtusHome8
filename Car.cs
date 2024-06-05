using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHome8
{
    internal class Car : Vehicle
    {
        // Производный класс Car
        public int NumberOfDoors { get; set; }

        // Переопределение метода клонирования для Car
        public override Vehicle Clone()
        {
            return (Car)MemberwiseClone();
        }
    }
}
