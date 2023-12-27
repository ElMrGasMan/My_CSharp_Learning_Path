namespace DataStructures
{
    internal class ForLoop
    {
        public static void ForLoopArr() 
        {
            int[] ints = [5, 2, 7, 4, 5, 6];

            Console.WriteLine("First for loop----------------------------------------------");
            for (int i = 0;  i < 4; i++) 
            {
                Console.WriteLine(ints[i]);
            }

            Console.WriteLine("Second for loop (using .lenght)-----------------------------");
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }

            Console.WriteLine("Descending ordered array------------------------------------");
            Array.Sort(ints);
            Array.Reverse(ints);

            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }

            //FOREACH-----------------------------------------------------------------------------------

            RandomObject[] randomObjects = new RandomObject[3];
            randomObjects[0] = new();
            randomObjects[1] = new();
            randomObjects[2] = new();

            foreach (RandomObject obj in randomObjects)
            {
                Console.WriteLine(obj);
            }
            
        }


        public static void PrintData(int[] data) 
        {
            foreach(int numb in data) 
            {
                Console.WriteLine(numb);
            }
        }

        public static void ChangeData(int[] data) 
        {
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i * 66 + 1;
            }
        }
    }
}
