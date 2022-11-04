using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {

        }
        public string VehicleType { get; set; }
        public bool IsDriveable { get; set; }
        public bool HasHandbrake { get; set; }
        public string MaxSpeed { get; set; }
        public void Drive()
        {
            Console.WriteLine($"This {VehicleType} would be driving - it's {IsDriveable}. It can go up to {MaxSpeed} if you had any balance.");
        }










    }
}
