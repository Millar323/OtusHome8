using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtusHome8.Interfaces;

namespace OtusHome8.Models
{
    // Базовый класс Vehicle
    public abstract class Vehicle : IMyCloneable<Vehicle>, ICloneable
    {
        public string Model { get; set; }
        public string Brand { get; set; }

        // Реализация метода клонирования для IMyCloneable
        public virtual Vehicle Clone()
        {
            return (Vehicle)MemberwiseClone();
        }

        // Реализация метода клонирования для ICloneable
        object ICloneable.Clone()
        {
            return Clone();
        }
    }

}
