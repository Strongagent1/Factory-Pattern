namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {    
            
                Console.WriteLine("How many wheels would you like for your vehicle, 2 or 4?");
                string wheels = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(wheels);
            
            vehicle.Drive();
           
        }
    }
}
