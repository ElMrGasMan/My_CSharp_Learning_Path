namespace MethodsConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RandomInt.GuessRandom();
            //ExceptionHandling.IntHandling();
            //ExceptionHandling.CheckedKeyWord();

            /*
            Console.WriteLine("Please, insert a number of a month: ");

            try
            {
                string month = ExceptionHandling.ReturnMonth(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("The selected month is: {0}.", month);
            }
            catch (ArgumentOutOfRangeException e)
            {

                Console.WriteLine(e.Message);
            }
            */

            ExceptionHandling.ExampleUseFinally();
            
        }

        static double Divide2Numbers(double d, double d2) => Math.Round(d / d2, 3); 
        //This is an expression-bodied member, only for 1 sentence methods


        /* FUNCTION OVERLOADING */

        static int Sum(int num1, int num2) => num1 + num2;
        static double Sum(double num1, double num2) => num1 + num2;
        static double Sum(int num1, double num2) => num1 + num2;
        static double Sum(double num1, int num2) => num1 + num2;


        /* OPTIONAL PARAMETERS */

        static double Subtraction(int num1, int num2, double num3 = 5) => (num1 - num2) - num3;

        static int Multiplication(int num1, int num2, int num3 = 1) => num1 * num2 * num3;
        static int Multiplication(int num1, int num2) => num1 * num2;
        //In this ambiguity, the SECOND method gets called when we call
        //Multiplication(5, 6)
    }
}
