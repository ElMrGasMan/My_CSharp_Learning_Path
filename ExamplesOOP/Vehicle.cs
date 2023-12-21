namespace ExamplesOOP
{
    // SETTERS AND GETTERS, CONSTRUCTORS
    partial class Vehicle
    {
        private int wheels;
        private int doors;
        private double hp;
        private string model;
        private static uint id = 0;
        public int Wheels { get => wheels; set => wheels = value; }
        public int Doors { get => doors; set => doors = value; }
        public double Hp { get => hp; set => hp = value; }
        public string Model { get => model; set => model = value; }
        public static uint Id { get => id; set => id = value; }

        public Vehicle()
        {
            wheels = 4;
            doors = 4;
            hp = 300;
            model = "Unknown";
            id++;
        }

        public Vehicle(int wheels, int doors, double hp, string model = "Unknown")
        {
            this.wheels = wheels;
            this.doors = doors;
            this.hp = hp;
            this.model = model;
            id++;
        }
    }

    //-----------------------------------------------------------------------------------------------------

    // METHODS
    partial class Vehicle
    {
        public override string? ToString()
        {
            return $"This car model is {model}, it has {wheels}" +
                    $" wheels and {doors} doors and a {hp}Hp engine.\n";
        }

        //Both Equals and GetHashCode must be Overwritten.
        public override bool Equals(object? obj)
        {
            return Equals(obj as Vehicle);
        }

        public bool Equals(Vehicle? other)
        {
            return other is not null &&
                    wheels == other.wheels &&
                    doors == other.doors &&
                    hp == other.hp &&
                    model == other.model;
        }

        //Override GetHashCode mostly only when using Hash Tables.
        public override int GetHashCode()
        {
            return HashCode.Combine(wheels, doors, hp, model);
        }
    }
}
