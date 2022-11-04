namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does your vehicle have?");
            bool user = int.TryParse(Console.ReadLine(), out int result);

            IVehicle vehicle = VehicleFactory.GetVehicle(result);
            vehicle.Drive();
            
        }
    }
}