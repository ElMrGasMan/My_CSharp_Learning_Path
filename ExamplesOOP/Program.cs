
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


            // ANONYMOUS CLASS AND TUPLE-------------------------------------------------------------------

            /* The following is a declaration of an "Anonymous class".
             * These are used mostly when it's unnecesary to create a whole new
             * class to define a data structure. */

            var person = new { Name = "John", Age = 31, CatName = "Garfield" };
            var anotherPerson = new { Name = "Me", Age = 45, CatName = "Pochita" };

            person = anotherPerson; //Possible because they are identical. 

            /* Now, Tuples and ValueTuples are a data structure that works similary to
             * Anonymus Classes, but tuples are immutable and don't need named properties. 
             * The diference between Tuples and ValueTuples is that ValueTuples are stored 
             * in the stack while Tuples are stored in the heap, this means that Tuples are 
             * reference type while ValueTuples are a value representation of them, this 
             * makes VaueTuples slightly faster and more predictable. */

            var car1 = Tuple.Create("Volkswagen", "Gol", 2006); //Tuple
            var tank1 = (Name: "Leopard 2", "A7", 2014); //ValueTuple
            //ValueTuples also permit named properties 

            //It's not neceesary to use the "var" keyword to initialize them:

            Tuple<string, string, int> car2 = new("Volkswagen", "Gol", 2005); //Tuples
            (string name, string variant, int) tank2 = ("Leopard 2", "A7+", 2015); //ValueTuples

        }
    }
}
