namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////ARRAYS

            //int[] ints = new int[10];
            //int[] ints2 = [10, 20, 30, 40, 50, 61, 71, 82, 93, 104];
            //int[] ints3 = new int[5] { 10, 20, 30, 45, 55 };

            //ints[0] = 666;
            //ints[4] = 616;
            //ints[9] = 1337;

            //Console.WriteLine(ints[0]);
            //Console.WriteLine(ints[5]); //Default value is 0


            ////IMPLICIT ARRAY (using "var")

            //var values = new[] { 30, 40.45, 122, 12.3 }; //Possible because they all end up as double
            ////var values1 = new[] { "Joel", "Martin", 30 }; <- Not possible


            ////OBJECT ARRAYS

            //RandomObject[] randomObjects = new RandomObject[2];
            //RandomObject randomObject = new();

            //randomObjects[0] = new(false, 20003);
            //randomObjects[1] = randomObject;


            ////ANONYMUS ARRAYS

            //var peoples = new[]
            //{
            //    new { Name = "MasterOfTheSky", Age = 17 },
            //    new { Name = "WhenLegendsRise", Age = 18 },
            //    new { Name = "IHaveADicotomy", Age = 19 }
            //    // new { Name = "IHaveADicotomy", Age = "19" } <- Not possible, all must be identical
            //};

            ForLoop.ForLoopArr();
            int[] ints4 = [69, 1, 20, 33, 5];

            Console.WriteLine("The current array: ");
            ForLoop.PrintData(ints4);
            Console.WriteLine("The array is tinkered with... ");
            ForLoop.ChangeData(ints4);
            Console.WriteLine("The change is reflected in the original array since is passed a a reference value.");
            ForLoop.PrintData(ints4);
        }
    }

    class RandomObject 
    {
        private bool randomFlag;
        private int randomValue;
        public bool RandomFlag { get => randomFlag; set => randomFlag = value; }
        public int RandomValue { get => randomValue; set => randomValue = value; }

        public RandomObject()
        {
            Random random = new Random();
            randomFlag = Convert.ToBoolean(random.Next(0, 2));
            randomValue = random.Next(-2333, 2333);
        }

        public RandomObject(bool randomFlag, int randomValue)
        {
            this.randomFlag = randomFlag;
            this.randomValue = randomValue;
        }

        public override string? ToString()
        {
            return $"I'm a random object with random properties such as a bool: {randomFlag}, and an int: {randomValue}.";
        }
    }
}
