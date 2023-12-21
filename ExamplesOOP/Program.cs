
namespace ExamplesOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Square square = new Square(10.45);

            Console.WriteLine(square.CalculateArea());
            Console.WriteLine(square.CalculatePerimeter());
            */

            /*
            Square square = new Square(10.45);
            Vehicle vehicle = new();
            Vehicle vehicle2 = new(4, 2, 500, "Mint");

            Console.WriteLine(vehicle.Wheels);
            Console.WriteLine(vehicle2.Doors);
            vehicle2.Doors = 6;

            Console.WriteLine(vehicle);
            Console.WriteLine(vehicle2);

            Console.WriteLine(vehicle.Equals(square));
            */

            Point origin = new();
            Point destiny = new(14, 9);
            double distance = Math.Round(origin.DistanceTo(destiny), 3);

            Console.WriteLine($"The first point is in the origin: {origin}.");
            Console.WriteLine($"The second point is our destiny: {destiny}.");
            Console.WriteLine($"The distance between them is: {distance}.");
        }
    }
}
