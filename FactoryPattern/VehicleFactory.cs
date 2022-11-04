using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string wheels)
        {


            
            switch (wheels.ToLower())
            {
                case "2":
                case "two":
                    return new Motorcycle() { VehicleType = "Motorcycle", MaxSpeed = "205 MPH", IsDriveable = true };
                    
                case "4":
                case "four":
                    return new Car() { VehicleType = "Car", MaxSpeed = "115 MPH", IsDriveable = true };
                default:
                    return new Car();

            }
 
                
                   

            
        }






    }
}   
