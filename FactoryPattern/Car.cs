using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public Car()
        {

        }
       
        public string VehicleType { get; set; }
        public bool IsDriveable { get; set; }
        public string MaxSpeed { get; set; }
        public bool HasFootbrake { get; set; }

        public void Drive()
        {
            Console.WriteLine($"This {VehicleType} is driveable - it's {IsDriveable}. It would be driving up to {MaxSpeed} if you were in it - duh.");
        }












    }
}
